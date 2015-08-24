Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Public Class SkillsPanel
    Implements IPanel

#Region "Member Variables"

    Private CharacterKey As Objects.ObjectKey

#End Region

    'init
    Public Sub Init(ByVal CharacterKey As Objects.ObjectKey)
        CType(Me.Parent, CentralDisplayForm).NeedsPanelInit = False
        Me.CharacterKey = CharacterKey
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
        Dim SkillList, ObjectList As Objects.ObjectDataCollection
        Dim SkillDef As Objects.ObjectData
        Dim SkillMod, Modifiers As Integer
        Dim CurrentLevel As Rules.Character.Level = Character.CurrentLevel
        Dim SkillAbility As String

        SkillList = Character.CharacterObject.FirstChildOfType(Objects.SkillFolderType).ChildrenOfType(Objects.SkillPointsSpentType)
        ObjectList = New Objects.ObjectDataCollection

        'precalc skill mods
        'Dim STRMod As Integer = Rules.AbilityScores.AbilityScore(CurrentLevel.STR).Modifier
        'Dim DEXMod As Integer = Rules.AbilityScores.AbilityScore(CurrentLevel.DEX).Modifier
        'Dim CONMod As Integer = Rules.AbilityScores.AbilityScore(CurrentLevel.CON).Modifier
        'Dim INTMod As Integer = Rules.AbilityScores.AbilityScore(CurrentLevel.INT).Modifier
        'Dim WISMod As Integer = Rules.AbilityScores.AbilityScore(CurrentLevel.WIS).Modifier
        'Dim CHAMod As Integer = Rules.AbilityScores.AbilityScore(CurrentLevel.CHA).Modifier

        'precalc skill mods
        Character.Skills.SkillAbilityScoresRefresh()
        Dim CheckPenalty As Integer = Character.Inventory.CheckPenalty

        For Each Skill As Objects.ObjectData In SkillList

            'get skill and set attributes
            SkillDef = Skill.GetFKObject("Skill")
            Skill.Element("Untrained") = SkillDef.Element("Untrained")

            'check for skill ability exchange objects
            SkillAbility = Character.Skills.SkillModifierAbility(SkillDef)
            Skill.Element("KeyAbility") = SkillAbility

            If Not SkillDef.ObjectGUID.Equals(References.SpeakLanguage) Then
                'get modifiers to this skill
                SkillMod = CType(Math.Floor(Skill.ElementAsNumber("Rank")), Integer)
                If Skill.ElementAsNumber("Rank") = 0 Then Skill.Element("Rank") = ""

                'new version includes ability modifiers
                Modifiers = Character.Skills.SkillModifier(SkillDef.ObjectGUID, SkillAbility)

                Skill.Element("Modifiers") = Rules.Formatting.FormatModifierHideZero(Modifiers)

                'check penalty
                If SkillDef.Element("ArmorCheckPenalty") = "Yes" Then
                    If CheckPenalty = 0 Then
                        Skill.Element("ArmorCheckPenalty") = "Yes"
                    Else
                        'update the modifier and set display val for check penalty
                        If SkillDef.ObjectGUID.Equals(References.Swim) Then
                            'swim
                            Modifiers += CheckPenalty * 2
                            Skill.Element("ArmorCheckPenalty") = Rules.Formatting.FormatModifierHideZero(CheckPenalty * 2)
                        Else
                            Modifiers += CheckPenalty
                            Skill.Element("ArmorCheckPenalty") = Rules.Formatting.FormatModifierHideZero(CheckPenalty)
                        End If
                    End If
                Else
                    Skill.Element("ArmorCheckPenalty") = ""
                End If

                'final
                SkillMod += Modifiers
                Skill.Element("SkillModifier") = Rules.Formatting.FormatModifierHideZero(SkillMod)

                ObjectList.Add(Skill)
            End If
        Next

        'handle filters
        'is this the first time a filter is being applied to this set of objects?
        If Not General.MainExplorer.FilterManager.CurrentFolder.ObjectGUID.Equals(General.MainExplorer.ObjectSelectedInTree.ObjectGUID) Then
            General.MainExplorer.FilterManager.InitFolder(General.MainExplorer.ObjectSelectedInTree)
        End If
        If General.MainExplorer.FilterManager.CurrentFilter <> "" Then ObjectList = General.MainExplorer.FilterManager.ProcessFilter(ObjectList)

        'size the item array or skip to end
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
                ListViewItem.Tag = Obj.ObjectGUID

                'add subitems
                If ColumnCount > 0 Then
                    For x As Integer = 0 To ColumnCount - 1
                        Element = ListViewManager.ListViewColumnDefs.Item(Objects.SkillFolderType).Elements(x)
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

        'modifiers
        Dim DisplayData As New ModifiersDisplay(Character.Components)
        SkillModifiers.Items.Clear()

        DisplayData.ProcessComponentsByConcept(ModifiersDisplay.DisplayConcept.Skills, True)
        For Each ModifierDisplay As ModifiersDisplay.Modifier In DisplayData.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Skills)
            SkillModifiers.Items.Add(" " & ModifierDisplay.ToString & " - " & ModifierDisplay.Source)
        Next
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
