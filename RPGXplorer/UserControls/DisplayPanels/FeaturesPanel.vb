Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class FeaturesPanel
    Implements IPanel

#Region "Member Variables"

    Private _CharacterKey As Objects.ObjectKey
    Private _Filter As Objects.ObjectKey
    Public PanelMode As FeaturePanelMode

    Public Enum FeaturePanelMode
        ViewMode
        EditMode
    End Enum

#End Region

    'init
    Public Sub Init(ByVal CharacterKey As Objects.ObjectKey)
        _CharacterKey = CharacterKey
        PanelMode = FeaturePanelMode.ViewMode
        CType(Me.Parent, CentralDisplayForm).NeedsPanelInit = False
    End Sub

#Region "IPanel"

    Public Property IsDirty() As Boolean Implements IPanel.IsDirty
        Get

        End Get
        Set(ByVal Value As Boolean)

        End Set
    End Property

    Public ReadOnly Property ListView() As System.Windows.Forms.ListView Implements IPanel.ListView
        Get
            Return ListView1
        End Get
    End Property

    Public Sub Save() Implements IPanel.Save

    End Sub

    Public Overridable Sub RefreshPanelData() Implements IPanel.RefreshPanelData

        Dim Character As Rules.Character = CharacterManager.GetCharacter(_CharacterKey)

        ListView.BeginUpdate()
        ListView.Clear()
        General.MainExplorer.ListViewManager.SetListViewColumns()

        Dim Items() As ListViewItem
        Dim ObjectList As New ArrayList
        Dim ProgressiveObjectList As New ArrayList
        Dim CalculatedFeature As Rules.CalculatedFeature

        Dim Feature As Objects.ObjectData
        Dim FeatureGainedObject As Objects.ObjectData

        Dim PrerequisitesMet As Boolean

        Select Case PanelMode

            Case FeaturePanelMode.ViewMode

                'get the objects to be displayed
                For Each FeatureGainedObject In Character.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children
                    Feature = DirectCast(Caches.Features.Item(FeatureGainedObject.GetFKGuid("Feature")), Objects.ObjectData)

                    'check to see if this feature is in a chain
                    If Not Caches.FeatureChains.Contains(Feature.ObjectGUID) Then
                        ObjectList.Add(FeatureGainedObject)
                    Else
                        ProgressiveObjectList.Add(FeatureGainedObject)
                    End If
                Next

                'Get Calculated features
                For Each LibraryData As Library.LibraryData In Character.Features.CalculatedFeatures.ItemData
                    Dim FeatureGuid, ChainGuid As Objects.ObjectKey
                    Dim LastlevelUpdated As Integer

                    CalculatedFeature = CType(LibraryData.Data, Rules.CalculatedFeature)
                    FeatureGuid = CalculatedFeature.FeatureAtLevel(Character.CharacterLevel)

                    If FeatureGuid.IsNotEmpty Then
                        Feature = DirectCast(Caches.Features.Item(FeatureGuid), Objects.ObjectData)
                        FeatureGainedObject = New Objects.ObjectData

                        FeatureGainedObject.Name = Feature.Name
                        FeatureGainedObject.ObjectGUID = Objects.ObjectKey.NewGuid(_CharacterKey.Database)
                        FeatureGainedObject.HTMLGUID = FeatureGuid
                        FeatureGainedObject.Type = Objects.FeatureGainedType

                        'Find the last level this was updated
                        LastlevelUpdated = 1
                        For i As Integer = 1 To Character.CharacterLevel
                            If CalculatedFeature.FeatureAtLevel(i).Equals(FeatureGuid) Then
                                LastlevelUpdated = i
                                Exit For
                            End If
                        Next

                        ChainGuid = Caches.FeatureChains.ChainGuid(FeatureGuid)
                        FeatureGainedObject.Element("CharacterLevel") = LastlevelUpdated.ToString
                        FeatureGainedObject.Element("FeatureType") = Feature.Element("FeatureType")
                        FeatureGainedObject.Element("Description") = Feature.Element("Description")

                        'Get the source information form the feature taken at that level
                        For Each Obj As Objects.ObjectData In ProgressiveObjectList
                            If Caches.FeatureChains.ChainGuid(Obj.GetFKGuid("Feature")).Equals(ChainGuid) And Obj.ElementAsInteger("CharacterLevel") = LastlevelUpdated Then
                                FeatureGainedObject.Element("Class") = Obj.Element("Class")
                                FeatureGainedObject.Element("Source") = Obj.Element("Source")
                                FeatureGainedObject.Element("SourceType") = Obj.Element("SourceType")
                            End If
                        Next

                        ObjectList.Add(FeatureGainedObject)
                    End If
                Next

            Case FeaturePanelMode.EditMode

                'get the objects to be displayed
                For Each FeatureGainedObject In Character.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children
                    ObjectList.Add(FeatureGainedObject)
                Next

        End Select

        If ObjectList.Count > 0 Then
            ReDim Items(ObjectList.Count - 1)

            'get the list of elements to display
            Dim ListViewItem As ListViewItem
            Dim Element As String
            Dim ColumnCount As Integer = ListView.Columns.Count - 1

            'display them
            Dim ItemNo As Integer = 0

            For Each Obj As Objects.ObjectData In ObjectList

                'create a new list view item
                ListViewItem = New ListViewItem(Obj.Name)
                ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)
                ListViewItem.Tag = Obj

                'Colour
                If Obj.Element("Disabled") = "Yes" Then
                    ListViewItem.ForeColor = Color.Silver
                Else
                    If Not Caches.FeatureChains.Contains(Obj.HTMLGUID) Then
                        PrerequisitesMet = Character.Components.IsFeatureValid(Obj.HTMLGUID.ToString)

                        'The overrides element is added here, 3 states "Yes", "No" and ""
                        If Not PrerequisitesMet Then
                            If Obj.Element("IgnorePrerequisites") = "Yes" Then
                                ListViewItem.ForeColor = Color.Blue
                                Obj.Element("Overrides") = "Yes"
                            Else
                                ListViewItem.ForeColor = Color.Red
                                Obj.Element("Overrides") = "No"
                            End If
                        Else
                            Obj.Element("Overrides") = ""
                        End If
                    End If

                End If

                'add subitems
                If ColumnCount > 0 Then
                    For x As Integer = 0 To ColumnCount - 1
                        Element = ListViewManager.ListViewColumnDefs.Item(Objects.FeatureFolderType).Elements(x)
                        If Element = "Type" Then
                            ListViewItem.SubItems.Add(Objects.ObjectTypes.Item(Obj.Type).Friendly)
                        Else
                            ListViewItem.SubItems.Add(Obj.Element(Element))
                        End If
                    Next
                End If

                'add to list view
                Items(ItemNo) = ListViewItem
                ItemNo += 1
            Next

            ListView.Items.AddRange(Items)
            General.MainExplorer.ListViewManager.SortListView()
        End If
        ListView.EndUpdate()
    End Sub

    'read-only
    Public WriteOnly Property [ReadOnly]() As Boolean Implements IPanel.ReadOnly
        Set(ByVal value As Boolean)
            'do nothing
        End Set
    End Property

#End Region

#Region "List View Handlers"

    'got focus
    Private Sub ListView1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.GotFocus
        Try
            General.MainExplorer.CurrentFocus = RPGXplorer.Explorer.Focus.ListView

            If ListView1.SelectedItems.Count = 0 And ListView1.Items.Count > 0 Then
                ListView1.Items(0).Selected = True
            ElseIf ListView1.SelectedItems.Count > 0 Then
                General.MainExplorer.HandleListViewItemSelect()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'item selected
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            General.MainExplorer.HandleListViewItemSelect()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display the right-click menu
    Private Sub ListView1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseUp
        Try
            If e.Button = MouseButtons.Right AndAlso Not UI.ReadOnly Then
                ToolbarsAndMenus.BuildPopupMenu()
                ToolbarsAndMenus.PopupMenu.ShowPopup(New Point(Control.MousePosition.X, Control.MousePosition.Y))
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

End Class
