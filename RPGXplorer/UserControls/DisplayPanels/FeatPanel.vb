Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class FeatPanel
    Implements IPanel

#Region "Member Variables"

    Private _CharacterKey As Objects.ObjectKey

#End Region

#Region "Properties"

    Public ReadOnly Property CharacterKey() As Objects.ObjectKey
        Get
            Return _CharacterKey
        End Get
    End Property

#End Region

    'init
    Public Sub Init(ByVal CharacterKey As Objects.ObjectKey)
        _CharacterKey = CharacterKey
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
        Dim Feat As Objects.ObjectData
        Dim FeatTaken As Objects.ObjectData

        'get the objects to be displayed
        For Each FeatTaken In Character.CharacterObject.FirstChildOfType(Objects.FeatFolderType).Children
            ObjectList.Add(FeatTaken)
        Next

        If ObjectList.Count > 0 Then
            ReDim Items(ObjectList.Count - 1)

            'get the list of elements to display
            Dim ListViewItem As ListViewItem
            Dim Element As String
            Dim ColumnCount As Integer = ListView.Columns.Count - 1

            'display them
            Dim ItemNo As Integer = 0
            Dim PrerequisitesMet As Boolean

            For Each Obj As Objects.ObjectData In ObjectList
                PrerequisitesMet = True

                'create a new list view item
                ListViewItem = New ListViewItem(Obj.Name)
                ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)
                ListViewItem.Tag = Obj.ObjectGUID

                'Colour
                If Obj.Element("Disabled") = "Yes" Then
                    ListViewItem.ForeColor = Color.Silver
                    Obj.Element("Overrides") = ""
                Else
                    Feat = Caches.Feats.Item(Obj.GetFKGuid("Feat"))

                    If Obj.GetFKGuid("Focus").IsEmpty Then
                        PrerequisitesMet = Character.Components.IsFeatValid(Feat.ObjectGUID.ToString)
                    Else
                        PrerequisitesMet = Character.Components.IsFeatValid(Feat.ObjectGUID.ToString & Obj.GetFKGuid("Focus").ToString)
                    End If

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

                'add subitems
                If ColumnCount > 0 Then
                    For x As Integer = 0 To ColumnCount - 1
                        Element = ListViewManager.ListViewColumnDefs.Item(Objects.FeatFolderType).Elements(x)
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
