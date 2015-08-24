Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class FavoredEnemyPanel
    Inherits RPGXplorer.PanelBase
    Implements IWizardPanel

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents ChosenListView As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents AddEnemy2 As System.Windows.Forms.Button
    Public WithEvents RemoveEnemy2 As System.Windows.Forms.Button
    Public WithEvents AddBonus2 As System.Windows.Forms.Button
    Public WithEvents RemoveBonus2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ChosenListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.AddEnemy2 = New System.Windows.Forms.Button
        Me.RemoveEnemy2 = New System.Windows.Forms.Button
        Me.AddBonus2 = New System.Windows.Forms.Button
        Me.RemoveBonus2 = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 21)
        Me.Label3.TabIndex = 310
        Me.Label3.Text = "Please select favored enemies"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChosenListView)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 255)
        Me.Panel2.TabIndex = 316
        '
        'ChosenListView
        '
        Me.ChosenListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChosenListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ChosenListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChosenListView.FullRowSelect = True
        Me.ChosenListView.HideSelection = False
        Me.ChosenListView.Location = New System.Drawing.Point(1, 1)
        Me.ChosenListView.MultiSelect = False
        Me.ChosenListView.Name = "ChosenListView"
        Me.ChosenListView.Size = New System.Drawing.Size(408, 253)
        Me.ChosenListView.TabIndex = 0
        Me.ChosenListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Monster Type"
        Me.ColumnHeader1.Width = 321
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Bonus"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 64
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 345)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 205)
        Me.Panel3.TabIndex = 328
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.AvailableSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSlots.FullRowSelect = True
        Me.AvailableSlots.HideSelection = False
        Me.AvailableSlots.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSlots.MultiSelect = False
        Me.AvailableSlots.Name = "AvailableSlots"
        Me.AvailableSlots.Size = New System.Drawing.Size(408, 203)
        Me.AvailableSlots.TabIndex = 123
        Me.AvailableSlots.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Level"
        Me.ColumnHeader7.Width = 63
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Enemy Choice"
        Me.ColumnHeader3.Width = 174
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Bonus Choice"
        Me.ColumnHeader4.Width = 146
        '
        'AddEnemy2
        '
        Me.AddEnemy2.Location = New System.Drawing.Point(15, 310)
        Me.AddEnemy2.Name = "AddEnemy2"
        Me.AddEnemy2.Size = New System.Drawing.Size(95, 24)
        Me.AddEnemy2.TabIndex = 329
        Me.AddEnemy2.Text = "Choose Enemy"
        '
        'RemoveEnemy2
        '
        Me.RemoveEnemy2.Location = New System.Drawing.Point(115, 310)
        Me.RemoveEnemy2.Name = "RemoveEnemy2"
        Me.RemoveEnemy2.Size = New System.Drawing.Size(95, 24)
        Me.RemoveEnemy2.TabIndex = 330
        Me.RemoveEnemy2.Text = "Remove Enemy"
        '
        'AddBonus2
        '
        Me.AddBonus2.Location = New System.Drawing.Point(230, 310)
        Me.AddBonus2.Name = "AddBonus2"
        Me.AddBonus2.Size = New System.Drawing.Size(95, 24)
        Me.AddBonus2.TabIndex = 331
        Me.AddBonus2.Text = "Add Bonus"
        '
        'RemoveBonus2
        '
        Me.RemoveBonus2.Location = New System.Drawing.Point(330, 310)
        Me.RemoveBonus2.Name = "RemoveBonus2"
        Me.RemoveBonus2.Size = New System.Drawing.Size(95, 24)
        Me.RemoveBonus2.TabIndex = 332
        Me.RemoveBonus2.Text = "Remove Bonus"
        '
        'FavoredEnemyPanel
        '
        Me.Controls.Add(Me.RemoveBonus2)
        Me.Controls.Add(Me.AddBonus2)
        Me.Controls.Add(Me.RemoveEnemy2)
        Me.Controls.Add(Me.AddEnemy2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FavoredEnemyPanel"
        Me.Size = New System.Drawing.Size(435, 575)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As EnemySlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, EnemySlot)
                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("No slot selected")
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

#End Region

#Region "Structures"

    Public Enum EnemySlotType
        Initial
        Normal
        InitialSingle
        BonusSingle
    End Enum

    Public Structure EnemySlot
        Implements IComparable

        Public CharacterLevel As Integer
        Public EnemyGuid As Objects.ObjectKey
        Public EnemyName As String
        Public BonusGuid As Objects.ObjectKey
        Public BonusName As String
        Public SlotType As EnemySlotType

        Public Sub Clear()
            CharacterLevel = Nothing

            EnemyGuid = Nothing
            EnemyName = Nothing

            BonusGuid = Nothing
            BonusName = Nothing
        End Sub

        Public Sub EnemyClear()
            EnemyGuid = Nothing
            EnemyName = Nothing
        End Sub

        Public Sub BonusClear()
            BonusGuid = Nothing
            BonusName = Nothing
        End Sub

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As EnemySlot
            Try
                Data = CType(obj, EnemySlot)
                If Data.CharacterLevel < CharacterLevel Then
                    Return 1
                ElseIf Data.CharacterLevel > CharacterLevel Then
                    Return -1
                ElseIf Data.CharacterLevel = CharacterLevel Then
                    If Data.EnemyName < EnemyName Then
                        Return 1
                    ElseIf Data.EnemyName > EnemyName Then
                        Return -1
                    Else
                        Return 0
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Structure

    Public Structure EnemyInfo
        Public EnemyObject As Objects.ObjectData
        Public EnemyChoice As ArrayList
    End Structure

#End Region

#Region "Member Variables"

    'panel variables
    Private Character As Rules.Character
    Private IsInitialised As Boolean

    Private NumberOfEnemies As Integer
    Private NumberOfSingleEnemies As Integer

    Private MonsterTypesDatalist() As DataListItem
    Private PreviousFavoredEnemies() As DataListItem

    Private PreviousEnemiesNumber As Integer
    Private RemainingEnemiesNumber As Integer
    Private RemainingBonusPointsNumber As Integer

    Private EnemySelection As Boolean
    Private BonusSelection As Boolean

    Private NewEnemyBonusPoints As New Hashtable
    'Private NewEnemyChoices As New Objects.ObjectDataCollection

    Private FeaturesFolder As Objects.ObjectData
    'Private MonsterCollection As Objects.ObjectDataCollection
    Private MonsterCollection As ArrayList
    Private FirstEnemy As Boolean

    Private Slot_AllowEnemy As Boolean = False
    Private Slot_AllowBonus As Boolean = False

    Private Available_AllowEnemy As Boolean = False
    Private Available_AllowBonus As Boolean = False

    Private LastClickedEnemy As String
    Private PreviousEnemies As New Hashtable

#End Region

    'initialise this panel
    'Public Sub Init(ByVal Character As Rules.Character)
    '    Dim EnemyObject As Objects.ObjectData

    '    Try
    '        'init vars
    '        IsInitialised = True
    '        EnemySelection = False
    '        BonusSelection = False
    '        PreviousEnemiesNumber = 0
    '        RemainingEnemiesNumber = NumberOfEnemies
    '        Me.Character = Character

    '        'Load Previous Enemies
    '        Dim ExcludeList As New ArrayList
    '        Dim FavoredEnemy As Rules.Character.CharacterChoice

    '        ChosenListView.BeginUpdate()
    '        ChosenListView.Items.Clear()

    '        For Each LibraryChoiceItem As Library.LibraryData In Character.Choices.ItemData

    '            FavoredEnemy = CType(LibraryChoiceItem.Data, Rules.Character.CharacterChoice)
    '            If FavoredEnemy.Type = Rules.Character.ChoiceType.FavoredEnemy Then
    '                PreviousEnemiesNumber += 1
    '                ExcludeList.Add(FavoredEnemy.DataGuid)

    '                Dim ListItem As New ListViewItem
    '                ListItem.Text = FavoredEnemy.Data
    '                ListItem.Tag = FavoredEnemy
    '                ListItem.SubItems.Add("+" & FavoredEnemy.Bonus.ToString)
    '                ListItem.ForeColor = Color.DarkGoldenrod
    '                ChosenListView.Items.Add(ListItem)
    '            End If

    '        Next

    '        ChosenListView.EndUpdate()

    '        'if we had added nothing too the ListView, we are assigning the first favored enemy, so we loose one bonus point
    '        If PreviousEnemiesNumber < 1 Then
    '            RemainingBonusPointsNumber = RemainingEnemiesNumber - 1
    '        Else
    '            RemainingBonusPointsNumber = RemainingEnemiesNumber
    '        End If

    '        If RemainingBonusPointsNumber < 1 Then BonusSelection = True

    '        'init the form
    '        MonsterTypesDatalist = Rules.Index.DataListExclude(Xml.DBTypes.MonsterTypes, Objects.MonsterTypeType, ExcludeList)
    '        EnemyDropdown.Properties.Items.AddRange(MonsterTypesDatalist)

    '        EnemyText.Text = RemainingEnemiesNumber.ToString
    '        BonusText.Text = RemainingBonusPointsNumber.ToString

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    'initialise this panel
    Public Sub Init2(ByVal Character As Rules.Character)

        Try
            'init vars
            IsInitialised = True
            FirstEnemy = True
            Me.Character = Character

            Dim Monsters As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(XML.DBTypes.MonsterTypes, Objects.MonsterTypeType)
            MonsterCollection = New ArrayList
            For Each MonsterData As Objects.ObjectData In Monsters
                MonsterCollection.Add(MonsterData)
            Next
            MonsterCollection.Sort()

            LoadEnemies()
            LoadSlots()

            AvailableSlots.Items(0).Selected = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'panel required
    Public Function PanelRequired(ByVal NewCharacter As Rules.Character, ByVal FirstLevel As Integer) As Boolean
        'ranger components
        NumberOfEnemies = NewCharacter.Components.SystemAbilityCount(References.FavoredEnemy, NewCharacter.CharacterLevel) - NewCharacter.Components.SystemAbilityCount(References.FavoredEnemy, FirstLevel - 1)
        If NumberOfEnemies > 0 Then Return True

        'slayer components
        NumberOfSingleEnemies = NewCharacter.Components.SystemAbilityCount(References.FavoredEnemySingle, NewCharacter.CharacterLevel) - NewCharacter.Components.SystemAbilityCount(References.FavoredEnemySingle, FirstLevel - 1)
        If NumberOfSingleEnemies > 0 Then Return True

        Return False

    End Function

#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext
    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised
        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 440
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 660
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel

    End Sub

#End Region

#Region "Event Handlers"

#End Region

    Private Sub LoadEnemies()
        Dim MonsterType As Objects.ObjectData

        ChosenListView.BeginUpdate()
        ChosenListView.Items.Clear()

        For Each MonsterType In MonsterCollection
            ChosenListView.Items.Add(LoadEnemy(MonsterType))
        Next

        ChosenListView.EndUpdate()

    End Sub

    Private Function LoadEnemy(ByVal MonsterType As Objects.ObjectData) As ListViewItem
        Dim MonsterItem As New ListViewItem

        Dim EnemyInfo As EnemyInfo

        MonsterItem.Text = MonsterType.Name
        EnemyInfo.EnemyObject = MonsterType

        'Check previous Favored Enemy choices
        If Character.Choices.ContainsKey(MonsterType.ObjectGUID) Then
            Dim EnemyChoice As Rules.Character.CharacterChoice
            Dim Enemies As ArrayList
            Dim BonusTotal As Integer

            Enemies = New ArrayList : BonusTotal = 0
            For Each Item As Library.LibraryData In Character.Choices.ItemData(MonsterType.ObjectGUID)
                EnemyChoice = CType(Item.Data, Rules.Character.CharacterChoice)

                If EnemyChoice.Type = Rules.Character.ChoiceType.FavoredEnemy Then
                    FirstEnemy = False
                Else
                    PreviousEnemies.Item(Character.Levels(EnemyChoice.LevelAcquired).ClassGuid) = True
                End If

                BonusTotal += EnemyChoice.Bonus
                Enemies.Add(EnemyChoice)
            Next

            MonsterItem.ForeColor = System.Drawing.Color.DarkGoldenrod
            MonsterItem.SubItems.Add("+" & BonusTotal.ToString)
            EnemyInfo.EnemyChoice = Enemies
        Else
            EnemyInfo.EnemyChoice = Nothing
            MonsterItem.SubItems.Add("")
        End If

        MonsterItem.Tag = EnemyInfo

        Return MonsterItem

    End Function

    Private Function AvailableEnemySlots() As ArrayList
        Dim Slots As New ArrayList
        Dim EnemyChoice As New Rules.Character.CharacterChoice
        Dim Found As Boolean

        For Each LibraryItem As Library.LibraryData In Character.Components.SystemAbilitiesLibrary.ItemData(References.FavoredEnemy)
            Dim Slot As New EnemySlot
            If LibraryItem.LevelAcquired >= Character.FirstNewLevel Then
                If FirstEnemy = True Then
                    Slot.Clear()
                    Slot.CharacterLevel = LibraryItem.LevelAcquired
                    Slot.SlotType = EnemySlotType.Initial
                    Slots.Add(Slot)
                    FirstEnemy = False
                Else
                    Slot.CharacterLevel = LibraryItem.LevelAcquired
                    Slot.SlotType = EnemySlotType.Normal
                    Slots.Add(Slot)
                End If
            End If
        Next

        For Each LibraryItem As Library.LibraryData In Character.Components.SystemAbilitiesLibrary.ItemData(References.FavoredEnemySingle)
            Dim Slot As New EnemySlot
            If LibraryItem.LevelAcquired >= Character.FirstNewLevel Then

                'is this the first favored enemy from this class
                If PreviousEnemies.Item(Character.Levels(LibraryItem.LevelAcquired).ClassGuid) Is Nothing Then
                    Slot.Clear()
                    Slot.CharacterLevel = LibraryItem.LevelAcquired
                    Slot.SlotType = EnemySlotType.InitialSingle
                    Slots.Add(Slot)
                    PreviousEnemies.Item(Character.Levels(LibraryItem.LevelAcquired).ClassGuid) = True
                Else

                    Found = False
                    'check if this enemy has been chosen already
                    For Each Item As Library.LibraryData In Character.Choices.ItemData
                        EnemyChoice = CType(Item.Data, Rules.Character.CharacterChoice)
                        If EnemyChoice.Type = Rules.Character.ChoiceType.FavoredEnemySingle Then
                            If Character.Levels(EnemyChoice.LevelAcquired).ClassGuid.Equals(Character.Levels(LibraryItem.LevelAcquired).ClassGuid) Then
                                Found = True
                                Exit For
                            End If
                        End If
                    Next

                    If Found Then
                        Character.Choices.RemoveItemObject(EnemyChoice.DataGuid, EnemyChoice)
                        EnemyChoice.Bonus += 2
                        If EnemyChoice.LevelsAssigned Is Nothing Then EnemyChoice.LevelsAssigned = New Hashtable
                        EnemyChoice.LevelsAssigned.Add(Slot.CharacterLevel, 2)
                        Character.Choices.AddItem(EnemyChoice.DataGuid, EnemyChoice)

                        Slot.CharacterLevel = LibraryItem.LevelAcquired
                        Slot.SlotType = EnemySlotType.BonusSingle
                        Slot.BonusGuid = EnemyChoice.DataGuid
                        Slot.BonusName = EnemyChoice.Data
                        Slots.Add(Slot)
                    Else
                        Slot.CharacterLevel = LibraryItem.LevelAcquired
                        Slot.SlotType = EnemySlotType.BonusSingle
                        Slots.Add(Slot)
                    End If

                End If
            End If
        Next

        Slots.Sort()
        Return Slots

    End Function

    Private Sub LoadSlots()
        Dim Slots As ArrayList
        Dim Slot As EnemySlot

        'Get the slots for the current class
        Slots = AvailableEnemySlots()

        'Clear the current slots
        AvailableSlots.BeginUpdate()
        AvailableSlots.Items.Clear()

        'Add each slot to the listview
        For Each Slot In Slots
            AvailableSlots.Items.Add(LoadSlot(Slot))
        Next

        AvailableSlots.EndUpdate()
    End Sub

    Private Function LoadSlot(ByVal Slot As EnemySlot) As ListViewItem
        Dim Item As New ListViewItem
        Select Case Slot.SlotType
            Case EnemySlotType.Initial, EnemySlotType.InitialSingle, EnemySlotType.Normal
                Item.Text = "Level " & Slot.CharacterLevel
                Item.Tag = Slot
                Item.SubItems.Add(Slot.EnemyName)
                Item.SubItems.Add(Slot.BonusName)
                Return Item
            Case EnemySlotType.BonusSingle
                Item.Text = "Level " & Slot.CharacterLevel
                Item.Tag = Slot
                Item.SubItems.Add(Character.Levels(Slot.CharacterLevel).ClassName & " Enemy Bonus")
                Item.SubItems.Add(Slot.BonusName)
                Return Item
        End Select
        Return Item
    End Function

    Private Sub UpdateEnemyList()
        Dim MonsterType As Objects.ObjectData

        ChosenListView.BeginUpdate()
        ChosenListView.Items.Clear()

        For Each MonsterType In MonsterCollection
            ChosenListView.Items.Add(LoadEnemy(MonsterType))
        Next

        'show current spell if any
        If LastClickedEnemy <> "" Then
            For Each Item As ListViewItem In ChosenListView.Items
                If Item.Text = LastClickedEnemy Then
                    Item.Selected = True
                    Item.EnsureVisible()
                    ChosenListView.EndUpdate()
                    Exit Sub
                End If
            Next
        End If

        If ChosenListView.Items.Count > 0 Then
            ChosenListView.Items(0).Selected = True
        End If

        ChosenListView.EndUpdate()

    End Sub

    'Private Sub AddEnemy_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim DataItem As DataListItem
    '    Dim ListItem As New ListViewItem
    '    Try

    '        If EnemyDropdown.SelectedIndex = -1 Then
    '            General.ShowInfoDialog("Please select an Enemy to add.")
    '            Exit Sub
    '        End If

    '        If RemainingEnemiesNumber < 1 Then
    '            General.ShowInfoDialog("Maximum number of Enemies already added.")
    '            Exit Sub
    '        End If

    '        DataItem = MonsterTypesDatalist(EnemyDropdown.SelectedIndex)

    '        If Character.Choices.ContainsKey(DataItem.ObjectGUID) Then
    '            General.ShowInfoDialog("This Monster Type has already been added.")
    '        Else
    '            Dim NewEnemy As Rules.Character.CharacterChoice
    '            NewEnemy.Type = Rules.Character.ChoiceType.FavoredEnemy
    '            NewEnemy.Data = DataItem.DisplayMember
    '            NewEnemy.DataGuid = DataItem.ObjectGUID
    '            NewEnemy.Bonus = 2
    '            Character.Choices.AddItem(NewEnemy.DataGuid, NewEnemy)

    '            ListItem.Text = NewEnemy.Data
    '            ListItem.Tag = NewEnemy
    '            ListItem.SubItems.Add("+" & NewEnemy.Bonus.ToString)
    '            ChosenListView.Items.Add(ListItem)

    '            'update the text boxes
    '            RemainingEnemiesNumber = RemainingEnemiesNumber - 1
    '            EnemyText.Text = RemainingEnemiesNumber.ToString

    '            'if we have added all the enemies set the flag to true
    '            If RemainingEnemiesNumber < 1 Then
    '                EnemySelection = True
    '                If EnemySelection And BonusSelection Then RaiseEvent EnableNext(False) Else RaiseEvent DisableNext()
    '            End If

    '        End If

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    'Private Sub RemoveEnemy_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim BonusPoints As Integer
    '    Dim MonsterGuid As Objects.ObjectKey

    '    Try
    '        If (ChosenListView.SelectedItems.Count < 1) Then
    '            General.ShowInfoDialog("Please select an Enemy to remove.")
    '            Exit Sub
    '        End If

    '        'If the Favored Enemy was obtained before the wizard started, it cannot be removed
    '        If (ChosenListView.SelectedIndices(0) < PreviousEnemiesNumber) Then
    '            General.ShowInfoDialog("Cannot remove a Favored Enemy from class level previously obtained.")
    '            Exit Sub
    '        End If

    '        'get any bonus objects assigned to this enemy and return them to the pool
    '        MonsterGuid = CType(ChosenListView.SelectedItems(0).Tag, Rules.Character.CharacterChoice).DataGuid
    '        RemainingBonusPointsNumber = RemainingBonusPointsNumber + CInt(NewEnemyBonusPoints(MonsterGuid))
    '        NewEnemyBonusPoints.Remove(MonsterGuid)

    '        'update the text boxes
    '        RemainingEnemiesNumber = RemainingEnemiesNumber + 1
    '        EnemyText.Text = RemainingEnemiesNumber.ToString
    '        BonusText.Text = RemainingBonusPointsNumber.ToString

    '        Character.Choices.RemoveItem(MonsterGuid, 0)
    '        ChosenListView.SelectedItems(0).Remove()

    '        EnemySelection = False
    '        RaiseEvent DisableNext()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    'Private Sub AddBonus_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim ListItem As ListViewItem
    '    Dim MonsterGuid As Objects.ObjectKey

    '    Try

    '        If (ChosenListView.SelectedItems.Count < 1) Then
    '            General.ShowInfoDialog("Please select an Enemy for the bonus.")
    '            Exit Sub
    '        End If

    '        If RemainingBonusPointsNumber < 1 Then
    '            General.ShowInfoDialog("Maximum number of bonuses already assigned.")
    '            Exit Sub
    '        End If

    '        'add the new bonus to the collection
    '        ListItem = ChosenListView.SelectedItems(0)
    '        MonsterGuid = CType(ChosenListView.SelectedItems(0).Tag, Rules.Character.CharacterChoice).DataGuid
    '        NewEnemyBonusPoints(MonsterGuid) = CInt(NewEnemyBonusPoints(MonsterGuid)) + 1

    '        'update Favored Enemy Choice
    '        Dim FavoredEnemy As Rules.Character.CharacterChoice

    '        'Should only be one of these
    '        For Each LibraryItem As Library.LibraryData In Character.Choices.ItemData(MonsterGuid)
    '            FavoredEnemy = CType(LibraryItem.Data, Rules.Character.CharacterChoice)
    '            FavoredEnemy.Bonus = FavoredEnemy.Bonus + 2

    '            'Update Character
    '            Character.Choices.RemoveItemStack(FavoredEnemy.DataGuid)
    '            Character.Choices.AddItem(FavoredEnemy.DataGuid, FavoredEnemy)

    '            Exit For
    '        Next

    '        'update the listviewitem
    '        ListItem.BackColor = General.BackColourPositive
    '        ListItem.SubItems.Item(1).Text = "+" & FavoredEnemy.Bonus.ToString

    '        'if we have added all the bonus points set the flag to true
    '        RemainingBonusPointsNumber = RemainingBonusPointsNumber - 1
    '        BonusText.Text = RemainingBonusPointsNumber.ToString

    '        If RemainingBonusPointsNumber < 1 Then
    '            BonusSelection = True
    '            If EnemySelection And BonusSelection Then RaiseEvent EnableNext(False) Else RaiseEvent DisableNext()
    '        End If

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    'Private Sub RemoveBonus_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim ListItem As ListViewItem
    '    Dim MonsterGuid As Objects.ObjectKey

    '    Try

    '        If (ChosenListView.SelectedItems.Count < 1) Then
    '            General.ShowInfoDialog("Please select an Enemy form which to remove the bonus.")
    '            Exit Sub
    '        End If

    '        ListItem = ChosenListView.SelectedItems(0)
    '        MonsterGuid = CType(ChosenListView.SelectedItems(0).Tag, Rules.Character.CharacterChoice).DataGuid

    '        If Not NewEnemyBonusPoints.Contains(MonsterGuid) Then
    '            General.ShowInfoDialog("This monster type does not have a new bouns assigned to it.")
    '            Exit Sub
    '        End If

    '        'update Favored Enemy Choice
    '        Dim FavoredEnemy As Rules.Character.CharacterChoice

    '        'Should only be one of these
    '        For Each LibraryItem As Library.LibraryData In Character.Choices.ItemData(MonsterGuid)
    '            FavoredEnemy = CType(LibraryItem.Data, Rules.Character.CharacterChoice)
    '            FavoredEnemy.Bonus = FavoredEnemy.Bonus - 2

    '            'Update Character
    '            Character.Choices.RemoveItemStack(FavoredEnemy.DataGuid)
    '            Character.Choices.AddItem(FavoredEnemy.DataGuid, FavoredEnemy)

    '            Exit For
    '        Next

    '        If CInt(NewEnemyBonusPoints(MonsterGuid)) > 1 Then
    '            NewEnemyBonusPoints(MonsterGuid) = CInt(NewEnemyBonusPoints(MonsterGuid)) - 1
    '            ListItem.SubItems.Item(1).Text = "+" & FavoredEnemy.Bonus.ToString
    '        Else
    '            NewEnemyBonusPoints.Remove(MonsterGuid)
    '            ListItem.SubItems.Item(1).Text = "+" & FavoredEnemy.Bonus.ToString
    '            ListItem.BackColor = Color.White
    '        End If

    '        RemainingBonusPointsNumber = RemainingBonusPointsNumber + 1
    '        BonusText.Text = RemainingBonusPointsNumber.ToString

    '        BonusSelection = False
    '        RaiseEvent DisableNext()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot As EnemySlot

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                UpdateEnemyList()

                Slot = SelectedSlot

                Select Case Slot.SlotType

                    Case EnemySlotType.BonusSingle
                        Slot_AllowEnemy = False
                        Slot_AllowBonus = False
                        RemoveBonus2.Enabled = False
                        RemoveEnemy2.Enabled = False

                    Case EnemySlotType.Initial
                        If Slot.EnemyName = "" Then
                            Slot_AllowEnemy = True
                            RemoveEnemy2.Enabled = False
                        Else
                            Slot_AllowEnemy = False
                            RemoveEnemy2.Enabled = True
                        End If
                        Slot_AllowBonus = False
                        RemoveBonus2.Enabled = False

                    Case EnemySlotType.InitialSingle
                        If Slot.EnemyName = "" Then
                            Slot_AllowEnemy = True
                            RemoveEnemy2.Enabled = False
                        Else
                            Slot_AllowEnemy = False
                            RemoveEnemy2.Enabled = True
                        End If
                        Slot_AllowBonus = False
                        RemoveBonus2.Enabled = False

                    Case EnemySlotType.Normal
                        If Slot.EnemyName = "" Then
                            Slot_AllowEnemy = True
                            RemoveEnemy2.Enabled = False
                        Else
                            Slot_AllowEnemy = False
                            RemoveEnemy2.Enabled = True
                        End If

                        If Slot.BonusName = "" Then
                            Slot_AllowBonus = True
                            RemoveBonus2.Enabled = False
                        Else
                            Slot_AllowBonus = False
                            RemoveBonus2.Enabled = True
                        End If
                End Select

                If Slot_AllowEnemy And Available_AllowEnemy Then AddEnemy2.Enabled = True Else AddEnemy2.Enabled = False
                If Slot_AllowBonus And Available_AllowBonus Then AddBonus2.Enabled = True Else AddBonus2.Enabled = False

                LastClickedEnemy = ""

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ChosenListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChosenListView.SelectedIndexChanged
        Dim EnemyInfo As EnemyInfo
        Dim EnemyChoices As ArrayList
        Try
            If ChosenListView.SelectedItems.Count > 0 Then

                EnemyInfo = CType(ChosenListView.SelectedItems(0).Tag, EnemyInfo)
                EnemyChoices = EnemyInfo.EnemyChoice

                If EnemyChoices Is Nothing Then
                    Available_AllowEnemy = True
                    Available_AllowBonus = False
                Else

                    Available_AllowEnemy = False
                    If AvailableSlots.SelectedItems.Count > 0 Then
                        Select Case SelectedSlot.SlotType
                            Case EnemySlotType.Initial, EnemySlotType.InitialSingle
                                Available_AllowEnemy = True

                            Case EnemySlotType.Normal
                                Available_AllowEnemy = True
                                For Each Choice As Rules.Character.CharacterChoice In EnemyChoices
                                    If Choice.Type = Rules.Character.ChoiceType.FavoredEnemy Then
                                        Available_AllowEnemy = False
                                        Exit For
                                    End If
                                Next

                            Case Else
                                Available_AllowEnemy = False
                        End Select
                    End If

                    Available_AllowBonus = True
                End If

                If Slot_AllowEnemy And Available_AllowEnemy Then AddEnemy2.Enabled = True Else AddEnemy2.Enabled = False
                If Slot_AllowBonus And Available_AllowBonus Then AddBonus2.Enabled = True Else AddBonus2.Enabled = False

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddEnemy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEnemy2.Click
        Dim EnemyInfo As EnemyInfo
        Dim Slot As EnemySlot
        Dim Slotindex As Integer

        Try
            If AvailableSlots.SelectedItems.Count + ChosenListView.SelectedItems.Count <> 2 Then Exit Sub

            EnemyInfo = CType(ChosenListView.SelectedItems(0).Tag, EnemyInfo)
            Slot = SelectedSlot
            Slotindex = AvailableSlots.SelectedItems(0).Index

            Select Case Slot.SlotType


                Case EnemySlotType.Initial, EnemySlotType.Normal

                    If Not EnemyInfo.EnemyChoice Is Nothing Then
                        For Each EnemyChoice As Rules.Character.CharacterChoice In EnemyInfo.EnemyChoice
                            If EnemyChoice.Type = Rules.Character.ChoiceType.FavoredEnemy Then
                                General.ShowInfoDialog("This Monster Type has already been added.")
                                Exit Sub
                            End If
                        Next
                    End If

                    'Update the slot
                    Slot.EnemyName = EnemyInfo.EnemyObject.Name
                    Slot.EnemyGuid = EnemyInfo.EnemyObject.ObjectGUID
                    Slotindex = AvailableSlots.SelectedItems(0).Index
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    'Add the new choice to the character
                    Dim NewEnemy As New Rules.Character.CharacterChoice
                    NewEnemy.LevelsAssigned = New Hashtable

                    NewEnemy.Type = Rules.Character.ChoiceType.FavoredEnemy
                    NewEnemy.Data = EnemyInfo.EnemyObject.Name
                    NewEnemy.DataGuid = EnemyInfo.EnemyObject.ObjectGUID
                    NewEnemy.Bonus = 2
                    NewEnemy.LevelAcquired = Slot.CharacterLevel
                    LastClickedEnemy = NewEnemy.Data
                    Character.Choices.AddItem(NewEnemy.DataGuid, NewEnemy, Slot.CharacterLevel)

                    EnableDisableNext()
                    MoveToNextAvailableSlot(Slotindex)

                Case EnemySlotType.InitialSingle

                    'Update the slot
                    Slot.EnemyName = EnemyInfo.EnemyObject.Name
                    Slot.EnemyGuid = EnemyInfo.EnemyObject.ObjectGUID
                    Slotindex = AvailableSlots.SelectedItems(0).Index
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    'Add the new choice to the character
                    Dim NewEnemy As New Rules.Character.CharacterChoice
                    NewEnemy.LevelsAssigned = New Hashtable

                    NewEnemy.Type = Rules.Character.ChoiceType.FavoredEnemySingle
                    NewEnemy.Data = EnemyInfo.EnemyObject.Name
                    NewEnemy.DataGuid = EnemyInfo.EnemyObject.ObjectGUID
                    NewEnemy.Bonus = 2
                    NewEnemy.LevelAcquired = Slot.CharacterLevel
                    LastClickedEnemy = NewEnemy.Data

                    'Search through the slots for any inital bonus slots from this class
                    For i As Integer = Slotindex + 1 To AvailableSlots.Items.Count - 1
                        Dim Tempslot As EnemySlot

                        Tempslot = CType(AvailableSlots.Items(i).Tag, EnemySlot)
                        If Tempslot.SlotType = EnemySlotType.BonusSingle Then
                            If Character.Levels(Slot.CharacterLevel).ClassGuid.Equals(Character.Levels(Tempslot.CharacterLevel).ClassGuid) Then
                                'Update the choice on the character
                                NewEnemy.Bonus += 2
                                NewEnemy.LevelsAssigned.Add(Tempslot.CharacterLevel, 2)

                                Tempslot.BonusGuid = NewEnemy.DataGuid
                                Tempslot.BonusName = NewEnemy.Data
                                AvailableSlots.Items(i) = LoadSlot(Tempslot)
                            End If
                        End If
                    Next

                    Character.Choices.AddItem(NewEnemy.DataGuid, NewEnemy, Slot.CharacterLevel)

                    EnableDisableNext()
                    MoveToNextAvailableSlot(Slotindex)
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveEnemy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveEnemy2.Click
        Dim Slot As EnemySlot
        Dim Slotindex As Integer
        Dim Maxindex As Integer = AvailableSlots.Items.Count - 1

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        Slot = SelectedSlot
        Slotindex = AvailableSlots.SelectedItems(0).Index

        Select Case Slot.SlotType

            Case EnemySlotType.Initial, EnemySlotType.Normal

                For Each Item As Library.LibraryData In Character.Choices.ItemData(Slot.EnemyGuid)
                    Dim EnemyChoice As Rules.Character.CharacterChoice
                    EnemyChoice = CType(Item.Data, Rules.Character.CharacterChoice)
                    If EnemyChoice.LevelAcquired = Slot.CharacterLevel Then
                        Character.Choices.RemoveItemObject(Slot.EnemyGuid, EnemyChoice)
                        Exit For
                    End If
                Next

                'Search through the slots for any containing bonuses for this enemy, put them back
                For i As Integer = Slotindex + 1 To Maxindex
                    Dim Tempslot As EnemySlot
                    Tempslot = CType(AvailableSlots.Items(i).Tag, EnemySlot)

                    If Tempslot.SlotType = EnemySlotType.Normal Then
                        If Tempslot.BonusGuid.Equals(Slot.EnemyGuid) Then
                            Tempslot.BonusClear()
                            AvailableSlots.Items(i) = LoadSlot(Tempslot)
                        End If
                    End If
                Next

                'Update the slot
                If Slot.EnemyGuid.Equals(Slot.BonusGuid) Then Slot.BonusClear()
                Slot.EnemyClear()
                AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
                AvailableSlots.Items(Slotindex).Selected = True

            Case EnemySlotType.InitialSingle

                For Each Item As Library.LibraryData In Character.Choices.ItemData(Slot.EnemyGuid)
                    Dim EnemyChoice As Rules.Character.CharacterChoice
                    EnemyChoice = CType(Item.Data, Rules.Character.CharacterChoice)
                    If EnemyChoice.LevelAcquired = Slot.CharacterLevel Then
                        Character.Choices.RemoveItemObject(Slot.EnemyGuid, EnemyChoice)
                        Exit For
                    End If
                Next

                'Search through the slots for any containing bonuses for this enemy, put them back
                For i As Integer = Slotindex + 1 To Maxindex
                    Dim Tempslot As EnemySlot
                    Tempslot = CType(AvailableSlots.Items(i).Tag, EnemySlot)
                    If Tempslot.SlotType = EnemySlotType.BonusSingle Then
                        If Tempslot.BonusGuid.Equals(Slot.EnemyGuid) Then
                            If Character.Levels(Slot.CharacterLevel).ClassGuid.Equals(Character.Levels(Tempslot.CharacterLevel).ClassGuid) Then
                                Tempslot.BonusClear()
                                AvailableSlots.Items(i) = LoadSlot(Tempslot)
                            End If
                        End If
                    End If
                Next

                'Update the slot
                If Slot.EnemyGuid.Equals(Slot.BonusGuid) Then Slot.BonusClear()
                Slot.EnemyClear()
                AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
                AvailableSlots.Items(Slotindex).Selected = True

        End Select

        RaiseEvent DisableNext()

    End Sub

    Private Sub AddBonus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBonus2.Click
        Dim EnemyInfo As EnemyInfo
        Dim Slot As EnemySlot
        Dim Slotindex, Infoindex As Integer
        Dim EnemyChoice As New Rules.Character.CharacterChoice

        Try
            If AvailableSlots.SelectedItems.Count + ChosenListView.SelectedItems.Count <> 2 Then Exit Sub

            EnemyInfo = CType(ChosenListView.SelectedItems(0).Tag, EnemyInfo)
            Slot = SelectedSlot

            If Not Character.Choices.ContainsKey(EnemyInfo.EnemyObject.ObjectGUID) Then
                General.ShowInfoDialog("This Monster Type has not been selected as a favored enemy.")
            Else

                'get the appropraite level choice
                For Each EnemyChoice In EnemyInfo.EnemyChoice
                    If EnemyChoice.Type = Rules.Character.ChoiceType.FavoredEnemy Then
                        Exit For
                    Else
                        EnemyChoice = Nothing
                    End If
                Next

                'Check that this slot is after the slot the enemy was first selected
                If EnemyChoice.DataGuid.IsEmpty Then
                    General.ShowInfoDialog("A bonus cannot be added to an enemy only selected from a Favored Enemy (Single) slot.")
                    Exit Sub
                End If

                If Slot.CharacterLevel < EnemyChoice.LevelAcquired Then
                    General.ShowInfoDialog("Bonuses can only be assigned to Monster Types selected before this level.")
                    Exit Sub
                End If

                'Update the slot
                Slot.BonusGuid = EnemyInfo.EnemyObject.ObjectGUID
                Slot.BonusName = EnemyInfo.EnemyObject.Name

                Slotindex = AvailableSlots.SelectedItems(0).Index
                AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                'Update the choice on the character
                Character.Choices.RemoveItemObject(EnemyChoice.DataGuid, EnemyChoice)

                EnemyChoice.Bonus += 2
                If EnemyChoice.LevelsAssigned Is Nothing Then EnemyChoice.LevelsAssigned = New Hashtable
                EnemyChoice.LevelsAssigned.Add(Slot.CharacterLevel, 2)
                Character.Choices.AddItem(EnemyChoice.DataGuid, EnemyChoice)

                'Update the ChosenListview
                Infoindex = ChosenListView.SelectedItems(0).Index
                ChosenListView.Items(Infoindex).Selected = True

                EnableDisableNext()
                MoveToNextAvailableSlot(Slotindex)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub RemoveBonus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBonus2.Click
        Dim Slot As EnemySlot
        Dim SlotIndex As Integer
        Dim EnemyChoice As New Rules.Character.CharacterChoice

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        'Update Enemy Choice
        Slot = SelectedSlot
        SlotIndex = AvailableSlots.SelectedItems(0).Index

        'get the appropraite level choice
        For Each Item As Library.LibraryData In Character.Choices.ItemData(Slot.BonusGuid)
            EnemyChoice = CType(Item.Data, Rules.Character.CharacterChoice)
            If EnemyChoice.Type = Rules.Character.ChoiceType.FavoredEnemy Then
                Exit For
            Else
                EnemyChoice = Nothing
            End If
        Next

        If EnemyChoice.DataGuid.IsEmpty Then
            General.ShowInfoDialog("Cannot find enemy choice from which to remove bonus.")
            Exit Sub
        End If

        Character.Choices.RemoveItemObject(EnemyChoice.DataGuid, EnemyChoice)
        EnemyChoice.Bonus -= 2
        EnemyChoice.LevelsAssigned.Remove(Slot.CharacterLevel)
        Character.Choices.AddItem(EnemyChoice.DataGuid, EnemyChoice)

        'Update Slot
        Slot.BonusClear()
        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
        AvailableSlots.Items(SlotIndex).Selected = True

        RaiseEvent DisableNext()

    End Sub

    'Enable/disable next
    Private Sub EnableDisableNext()
        For Each Item As ListViewItem In AvailableSlots.Items
            If Item.SubItems(1).Text = "" Then
                RaiseEvent DisableNext()
                Exit Sub
            End If

            If Item.SubItems(2).Text = "" And CType(Item.Tag, EnemySlot).SlotType = EnemySlotType.Normal Then
                RaiseEvent DisableNext()
                Exit Sub
            End If
        Next

        RaiseEvent EnableNext(False)
    End Sub

    'Move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        For Each Item As ListViewItem In AvailableSlots.Items
            If CType(Item.Tag, EnemySlot).EnemyName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)

                If Item.Index <> PreviousIndex Then
                    ChosenListView.Items(0).Selected = True
                End If

                Exit Sub
            End If

            If CType(Item.Tag, EnemySlot).BonusName = "" And CType(Item.Tag, EnemySlot).SlotType = EnemySlotType.Normal Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)

                If Item.Index <> PreviousIndex Then
                    ChosenListView.Items(0).Selected = True
                End If

                Exit Sub
            End If
        Next

        AvailableSlots.Items(PreviousIndex).Selected = True
        AvailableSlots.EnsureVisible(PreviousIndex)

    End Sub

#Region "Paint Events"

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Dim rect As Rectangle = Panel2.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        Dim rect As Rectangle = Panel3.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

#End Region

End Class
