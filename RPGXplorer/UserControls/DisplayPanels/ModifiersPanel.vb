Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class ModifiersPanel
    Implements IPanel


#Region "Member Variables"

    Private CharacterKey As Objects.ObjectKey

#End Region

    'init
    Public Sub Init(ByVal CharacterKey As Objects.ObjectKey)
        Me.CharacterKey = CharacterKey
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

        Dim Character As Rules.Character = CharacterManager.GetCharacter(CharacterKey)

        ListView.BeginUpdate()
        ListView.Clear()
        General.MainExplorer.ListViewManager.SetListViewColumns()

        Dim ListViewItem As ListViewItem
        Dim Element As String
        Dim Items() As ListViewItem

        'get the objects to be displayed
        Dim ObjectList As New Objects.ObjectDataCollection
        Dim ModifierDisplayObject As New Objects.ObjectData
        Dim DisplayData As New ModifiersDisplay(Character.Components)
        DisplayData.ProcessAllComponents(False, False)

        For Each ModifierDisplay As ModifiersDisplay.Modifier In DisplayData.GetAllModifiers()
            ModifierDisplayObject.Clear()

            If ModifierDisplay.Source = "User" Then
                ModifierDisplayObject.Type = Objects.ModifierType
                ModifierDisplayObject.ObjectGUID = CType(ModifierDisplay.Tag, Objects.ObjectKey)
                If ModifierDisplay.UserDisabled Then ModifierDisplayObject.Element("Disabled") = "Yes"
            Else
                ModifierDisplayObject.Type = Objects.ModifierInfoType
                ModifierDisplayObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Folders)
            End If

            ModifierDisplayObject.Element("Name2") = ModifierDisplay.ToString
            ModifierDisplayObject.Element("Source") = ModifierDisplay.Source
            ModifierDisplayObject.Element("Notes") = ModifierDisplay.Notes
            ModifierDisplayObject.Element("ModifierTypeDisplay") = ModifierDisplay.Type
            ModifierDisplayObject.Element("Valid") = ModifierDisplay.Valid.ToString
            ModifierDisplayObject.CreateDefaultRulePage()
            ObjectList.Add(ModifierDisplayObject)
        Next

        If ObjectList.Count > 0 Then
            ReDim Items(ObjectList.Count - 1)

            'get the list of elements to display
            Dim ColumnCount As Integer = ListView.Columns.Count - 1

            'display them
            Dim ItemNo As Integer = 0

            For Each Obj As Objects.ObjectData In ObjectList
                'create a new list view item
                ListViewItem = New ListViewItem(Obj.Element("Name2"))
                If Obj.Type = Objects.ModifierInfoType Then
                    ListViewItem.Tag = Obj.HTML
                Else
                    ListViewItem.Tag = Obj.ObjectGUID
                    ListViewItem.ForeColor = System.Drawing.Color.Blue
                End If
                If Obj.Element("Valid") = "False" Then ListViewItem.ForeColor = System.Drawing.Color.Red
                If Obj.Element("Disabled") = "Yes" Then ListViewItem.ForeColor = Color.Silver
                ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)

                'add subitems
                If ColumnCount > 0 Then
                    For x As Integer = 0 To ColumnCount - 1
                        Element = ListViewManager.ListViewColumnDefs.Item(Objects.ModifierFolderType).Elements(x)
                        ListViewItem.SubItems.Add(Obj.Element(Element))
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

    Private _ReadOnly As Boolean = False

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
        General.MainExplorer.HandleListViewItemSelect()
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
