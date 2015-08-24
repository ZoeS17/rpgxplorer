Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class PowerListPanel
    Implements IPanel

#Region "Member Variables"

    Public PanelMode As Rules.PowerList.PowerListOperationMode

#End Region

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
        Try
            'init
            ListView.BeginUpdate()
            ListView.Clear()
            General.MainExplorer.ListViewManager.SetListViewColumns()

            'Findout what the parent of this folder is
            Dim Folder As Objects.ObjectData = WindowManager.CurrentWindow.Folder
            Dim Parent As Objects.ObjectData = Folder.Parent
            Dim ObjectList As New Objects.ObjectDataCollection

            Select Case Folder.Type
                Case Objects.PowerListFolderType
                    PanelMode = Rules.PowerList.PowerListOperationMode.Definition
                Case Objects.ClassPowerListFolderType
                    PanelMode = Rules.PowerList.PowerListOperationMode.Character
                Case Else
                    Throw New DevelopmentException("Folder was not of expected type")
            End Select

            'if we are in definition mode, get the relevant "SpellLevel" objects
            If PanelMode = Rules.PowerList.PowerListOperationMode.Definition Then
                Dim TempObject As Objects.ObjectData
                Dim PowerInfoTable As ObjectHashtable = Rules.PowerList.powerListInfo(Parent.ObjectGUID)
                For Each PowerInfo As Rules.PowerList.PowerInfo In PowerInfoTable.Values
                    TempObject = Rules.PowerList.GeneratePowerListItem(PowerInfo, Folder.ObjectGUID)
                    ObjectList.Add(TempObject)
                Next

            Else
                'Get the spells form the spell learned objects
                Dim PowerDef As Objects.ObjectData
                ObjectList = Folder.Children

                'get the character
                Dim Character As Rules.Character = CharacterManager.CurrentCharacter
                Dim ClassKey As Objects.ObjectKey = Folder.GetFKGuid("Class")

                For Each Power As Objects.ObjectData In ObjectList
                    PowerDef = Power.GetFKObject("Power")
                    Power.HTML = PowerDef.HTML
                    Power.Element("Discipline") = PowerDef.Element("Discipline")
                    Power.Element("Subdiscipline") = PowerDef.Element("Subdiscipline")
                    Power.Element("Descriptors") = PowerDef.Element("Descriptors")
                    Power.Element("Display") = PowerDef.Element("Display")
                    Power.Element("CastingTime") = PowerDef.Element("CastingTime")
                    Power.Element("Range") = PowerDef.Element("Range")
                    Power.Element("TargetAreaEffect") = PowerDef.Element("TargetAreaEffect")
                    Power.Element("Duration") = PowerDef.Element("Duration")
                    Power.Element("SavingThrow") = PowerDef.Element("SavingThrow")
                    Power.Element("PowerResistance") = PowerDef.Element("PowerResistance")
                    Power.Element("XPCost") = PowerDef.Element("XPCost")
                    Power.Element("Augment") = PowerDef.Element("Augment")
                    Power.Element("Description") = PowerDef.Element("Description")

                    Power.Element("License") = PowerDef.Element("License")
                    Power.Element("Sourcebook") = PowerDef.Element("Sourcebook")
                    Power.Element("Tags") = PowerDef.Element("Tags")
                    Power.Element("PageNoRef") = PowerDef.Element("PageNoRef")

                Next
            End If

            'vars for creating listview items
            Dim Items() As ListViewItem
            Dim ListViewItem As ListViewItem
            Dim Element As String

            'handle filters
            'is this the first time a filter is being applied to this set of objects?
            If Not General.MainExplorer.FilterManager.CurrentFolder.ObjectGUID.Equals(General.MainExplorer.ObjectSelectedInTree.ObjectGUID) Then
                General.MainExplorer.FilterManager.InitFolder(General.MainExplorer.ObjectSelectedInTree)
            End If
            If General.MainExplorer.FilterManager.CurrentFilter <> "" Then ObjectList = General.MainExplorer.FilterManager.ProcessFilter(ObjectList)

            If ObjectList.Count > 0 Then
                ReDim Items(ObjectList.Count - 1)

                'get the list of elements to display
                Dim ColumnCount As Integer = ListView.Columns.Count - 1

                'display them
                Dim ItemNo As Integer = 0

                For Each Obj As Objects.ObjectData In ObjectList

                    'create a new list view item
                    ListViewItem = New ListViewItem(Obj.Name)
                    ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)

                    'set tag to manufactured object
                    ListViewItem.Tag = Obj

                    'add subitems
                    If ColumnCount > 0 Then
                        For x As Integer = 0 To ColumnCount - 1
                            Element = ListViewManager.ListViewColumnDefs.Item(Folder.Type).Elements(x)
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

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
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

    'before label edit
    Private Sub ListView1_BeforeLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles ListView1.BeforeLabelEdit
        e.CancelEdit = True
    End Sub

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
        If ListView1.SelectedItems.Count = 1 Then
            General.MainExplorer.ShowHelpForSelected()
        End If
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
