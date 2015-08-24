Option Explicit On
Option Strict On

Imports System.Text

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class SpellListPanel
    Implements IPanel

#Region "Member Variables"

    Public PanelMode As Rules.SpellList.SpellListOperationMode

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
            'Dim Folder As Objects.ObjectData = General.MainExplorer.ObjectSelectedInTree
            Dim Folder As Objects.ObjectData = WindowManager.CurrentWindow.Folder
            Dim Parent As Objects.ObjectData = Folder.Parent
            Dim ObjectList As New Objects.ObjectDataCollection

            Select Case Folder.Type
                Case Objects.SpellListFolderType
                    PanelMode = Rules.SpellList.SpellListOperationMode.Definition
                Case Objects.ClassSpellListFolderType
                    PanelMode = Rules.SpellList.SpellListOperationMode.Character
                Case Else
                    Throw New DevelopmentException("Folder was not of expected type")
            End Select

            'if we are in definition mode, get the relevant "SpellLevel" objects
            If PanelMode = Rules.SpellList.SpellListOperationMode.Definition Then
                Dim TempObject As Objects.ObjectData
                Dim SpellInfoTable As ObjectHashtable = Rules.SpellList.SpellListInfo(Parent.ObjectGUID)
                For Each SpellInfo As Rules.SpellList.SpellInfo In SpellInfoTable.Values
                    TempObject = Rules.SpellList.GenerateSpellListItem(SpellInfo, Folder.ObjectGUID)
                    ObjectList.Add(TempObject)
                Next
            Else
                'Get the spells form the spell learned objects
                ObjectList = Folder.Children

                'get the character
                Dim Character As Rules.Character = CharacterManager.CurrentCharacter
                Dim ClassKey As Objects.ObjectKey = Folder.GetFKGuid("Class")
                Dim ProhibitedSchools As New ArrayList
                Dim Choice As Rules.Character.CharacterChoice

                For Each Data As Library.LibraryData In Character.Choices.ItemData(ClassKey)
                    Choice = DirectCast(Data.Data, Rules.Character.CharacterChoice)
                    If Choice.Type = Rules.Character.ChoiceType.SacrificedSchool Then ProhibitedSchools.Add(Choice.Data)
                Next

                Dim FolderKey As String = Folder.ObjectGUID.ToString
                Dim ClassKeyStr As String = ClassKey.ToString
                Dim ClassObj As New Objects.ObjectData
                ClassObj.Load(ClassKey)
                Dim ClassName As String = ClassObj.Name
                Dim Elements(21) As String

                For Each Spell As Objects.ObjectData In ObjectList
                    Dim SpellDef As Objects.ObjectData = DirectCast(Caches.Spells.Item(Spell.GetFKGuid("Spell")), Objects.ObjectData)
                    Array.Clear(Elements, 0, 21)
                    SpellDef.GetSpellDefElements(Elements)
                    Dim InnerXml As String = "<Name>" & Elements(0) & "</Name><Type>Spell Learned</Type><ObjectGUID>" & Spell.ObjectGUID.ToString & "</ObjectGUID><ParentGUID>" & FolderKey & "</ParentGUID><HTML>" & Elements(2) & "</HTML><HTMLGUID /><Class FK='" & ClassKeyStr & "' reference='Name'>" & ClassName & "</Class><Spell FK='" & Elements(1) & "' reference='Name'>" & Name & "</Spell><Source FK='" & ClassKeyStr & "' reference='Name'>" & ClassName & "</Source><Level>" & Spell.Element("Level") & "</Level><CharacterLevel>" & Spell.Element("CharacterLevel") & "</CharacterLevel><AutoObtained>Yes</AutoObtained><ImageFilename>Spell.png</ImageFilename><School>" & Elements(3) & "</School><Subschool>" & Elements(4) & "</Subschool><Descriptors>" & Elements(5) & "</Descriptors><Components>" & Elements(6) & "</Components><CastingTime>" & Elements(7) & "</CastingTime><Range>" & Elements(8) & "</Range><TargetAreaEffect>" & Elements(9) & "</TargetAreaEffect><Duration>" & Elements(10) & "</Duration><SavingThrow>" & Elements(11) & "</SavingThrow><SpellResistance>" & Elements(12) & "</SpellResistance><XPCost>" & Elements(13) & "</XPCost><ComponentCost>" & Elements(14) & "</ComponentCost><Description>" & Elements(15) & "</Description><License>" & Elements(16) & "</License><Sourcebook>" & Elements(17) & "</Sourcebook><Tags>" & Elements(18) & "</Tags><PageNoRef>" & Elements(19) & "</PageNoRef><Prohibited>"
                    If ProhibitedSchools.Contains(Elements(3)) Then InnerXml &= "True"
                    InnerXml &= "</Prohibited>"
                    Spell.XMLNode.InnerXml = InnerXml.ToString
                Next
            End If

            'handle filters
            'is this the first time a filter is being applied to this set of objects?
            If Not General.MainExplorer.FilterManager.CurrentFolder.ObjectGUID.Equals(General.MainExplorer.ObjectSelectedInTree.ObjectGUID) Then General.MainExplorer.FilterManager.InitFolder(General.MainExplorer.ObjectSelectedInTree)
            If General.MainExplorer.FilterManager.CurrentFilter <> "" Then ObjectList = General.MainExplorer.FilterManager.ProcessFilter(ObjectList)

            'vars for creating listview items
            Dim Items() As ListViewItem

            If ObjectList.Count > 0 Then
                ReDim Items(ObjectList.Count - 1)
                'get the list of elements to display
                Dim ColumnCount As Integer = ListView.Columns.Count - 1

                'display them
                Dim ItemNo As Integer = 0

                For Each Obj As Objects.ObjectData In ObjectList

                    'create a new list view item
                    Dim ListViewItem As New ListViewItem(Obj.Name)
                    ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)

                    'set tag to manufactured object
                    ListViewItem.Tag = Obj

                    'add subitems
                    If ColumnCount > 0 Then
                        For x As Integer = 0 To ColumnCount - 1
                            Dim Element As String = ListViewManager.ListViewColumnDefs.Item(Folder.Type).Elements(x)
                            If Element = "Type" Then
                                ListViewItem.SubItems.Add(Objects.ObjectTypes.Item(Obj.Type).Friendly)
                            Else
                                ListViewItem.SubItems.Add(Obj.Element(Element))
                            End If
                        Next
                    End If

                    'color
                    If Obj.Element("Prohibited") = "True" Then
                        ListViewItem.ForeColor = System.Drawing.Color.Red
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
