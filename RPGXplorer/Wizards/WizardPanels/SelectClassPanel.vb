Option Strict On
Option Explicit On

Imports RPGXplorer.LevellingUpWizard
Imports RPGXplorer.Rules.ExperienceAndLevelling

Public Class SelectClassPanel
    Inherits PanelBase
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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Levels As DevExpress.XtraEditors.SpinEdit
    Public WithEvents AddLevels As System.Windows.Forms.Button
    Public WithEvents RemoveLevels As System.Windows.Forms.Button
    Public WithEvents ClassListView As System.Windows.Forms.ListView
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents LevelsListView As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents IgnoreCheck As System.Windows.Forms.CheckBox
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Levels = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AddLevels = New System.Windows.Forms.Button
        Me.RemoveLevels = New System.Windows.Forms.Button
        Me.ClassListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LevelsListView = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.IgnoreCheck = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        CType(Me.Levels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Levels
        '
        Me.Levels.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Levels.Location = New System.Drawing.Point(100, 300)
        Me.Levels.Name = "Levels"
        Me.Levels.Properties.Appearance.Options.UseTextOptions = True
        Me.Levels.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Levels.Properties.AutoHeight = False
        Me.Levels.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Levels.Properties.IsFloatValue = False
        Me.Levels.Properties.Mask.BeepOnError = True
        Me.Levels.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Levels.Properties.Mask.ShowPlaceHolders = False
        Me.Levels.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Levels.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Levels.Size = New System.Drawing.Size(50, 21)
        Me.Levels.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Available Classes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Levels To Add"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please select character levels to add"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddLevels
        '
        Me.AddLevels.Location = New System.Drawing.Point(160, 300)
        Me.AddLevels.Name = "AddLevels"
        Me.AddLevels.Size = New System.Drawing.Size(90, 24)
        Me.AddLevels.TabIndex = 1
        Me.AddLevels.Text = "Add Levels"
        '
        'RemoveLevels
        '
        Me.RemoveLevels.BackColor = System.Drawing.Color.White
        Me.RemoveLevels.Location = New System.Drawing.Point(255, 300)
        Me.RemoveLevels.Name = "RemoveLevels"
        Me.RemoveLevels.Size = New System.Drawing.Size(90, 24)
        Me.RemoveLevels.TabIndex = 2
        Me.RemoveLevels.Text = "Remove Last"
        Me.RemoveLevels.UseVisualStyleBackColor = False
        '
        'ClassListView
        '
        Me.ClassListView.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ClassListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClassListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ClassListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassListView.FullRowSelect = True
        Me.ClassListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ClassListView.HideSelection = False
        Me.ClassListView.Location = New System.Drawing.Point(1, 1)
        Me.ClassListView.MultiSelect = False
        Me.ClassListView.Name = "ClassListView"
        Me.ClassListView.Size = New System.Drawing.Size(328, 223)
        Me.ClassListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ClassListView.TabIndex = 0
        Me.ClassListView.UseCompatibleStateImageBehavior = False
        Me.ClassListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 300
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ClassListView)
        Me.Panel1.Location = New System.Drawing.Point(15, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(330, 225)
        Me.Panel1.TabIndex = 124
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LevelsListView)
        Me.Panel2.Location = New System.Drawing.Point(15, 335)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(330, 215)
        Me.Panel2.TabIndex = 125
        '
        'LevelsListView
        '
        Me.LevelsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LevelsListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LevelsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.LevelsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LevelsListView.FullRowSelect = True
        Me.LevelsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LevelsListView.Location = New System.Drawing.Point(1, 1)
        Me.LevelsListView.MultiSelect = False
        Me.LevelsListView.Name = "LevelsListView"
        Me.LevelsListView.Size = New System.Drawing.Size(328, 213)
        Me.LevelsListView.TabIndex = 0
        Me.LevelsListView.TabStop = False
        Me.LevelsListView.UseCompatibleStateImageBehavior = False
        Me.LevelsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 300
        '
        'IgnoreCheck
        '
        Me.IgnoreCheck.BackColor = System.Drawing.Color.Transparent
        Me.IgnoreCheck.Location = New System.Drawing.Point(140, 35)
        Me.IgnoreCheck.Name = "IgnoreCheck"
        Me.IgnoreCheck.Size = New System.Drawing.Size(215, 24)
        Me.IgnoreCheck.TabIndex = 126
        Me.IgnoreCheck.Text = "Ignore Preconditions and Restrictions"
        Me.IgnoreCheck.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Browser)
        Me.Panel3.Location = New System.Drawing.Point(360, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(575, 535)
        Me.Panel3.TabIndex = 128
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(573, 533)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'SelectClassPanel
        '
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.IgnoreCheck)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RemoveLevels)
        Me.Controls.Add(Me.AddLevels)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Levels)
        Me.Name = "SelectClassPanel"
        Me.Size = New System.Drawing.Size(950, 565)
        CType(Me.Levels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean

    Private mLevelsToAdd As Integer
    Private ExistingCharacter As Rules.Character
    Private CurrentCharacterLevel As Integer

    Private CurrentLevels As New System.Collections.ArrayList

    'DataList
    Private ClassDatalist As General.DataListItem()

    Private IsLoading As Boolean
    Private PreviousURL As String

    Private MonsterLevels As Integer
    Private IsMount, IsMonster As Boolean

    'Fast lookup for class prereqs
    Private FastLookupsLoaded As Boolean = False
    Private PrereqCollection As Objects.ObjectDataCollection
    Private PrereqChildCollection As Objects.ObjectDataCollection

#End Region

#Region "Properties"

    'levels to add                                                              
    Public ReadOnly Property LevelsToAdd() As Integer
        Get
            Dim TotalLevels As Integer

            For Each TempRange As LevelRange In CurrentLevels
                TotalLevels += TempRange.LevelsAdded
            Next

            Return TotalLevels
        End Get
    End Property

    'The collection of Level Ranges
    Public ReadOnly Property CharacterLevelRanges() As LevellingUpWizard.LevelRangeCollection
        Get
            Dim ReturnCollection As New LevellingUpWizard.LevelRangeCollection
            ReturnCollection.Load(CurrentLevels)
            Return ReturnCollection
        End Get
    End Property

#End Region

    'initialise this panel
    Public Sub Init(ByVal ExistingCharacter As Rules.Character)
        Dim PreviousClasses As Objects.ObjectDataCollection
        Dim LastClass As New Objects.ObjectData

        Try
            If Not FastLookupsLoaded Then
                PrereqCollection = Objects.GetObjectsByXPath(XML.DBTypes.Classes, "//RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PrerequisiteType & "']")
                PrereqCollection.ConstructParentChildListFast()
                PrereqChildCollection = Objects.GetObjectsByXPath(XML.DBTypes.Classes, "//RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PrerequisiteChildType & "']")
                PrereqChildCollection.ConstructParentChildListFast()
                FastLookupsLoaded = True
            End If

            IsLoading = True
            IsInitialised = True
            Me.ExistingCharacter = ExistingCharacter

            'mount check
            IsMount = False
            If ExistingCharacter.CharacterObject.Element("Mount") = "Yes" Then
                IsMount = True
            End If

            IsMonster = False
            If ExistingCharacter.CharacterType = Rules.Character.CharacterObjectType.Monster Then
                IsMonster = True
            End If

            Me.CurrentCharacterLevel = ExistingCharacter.CharacterLevel
            If General.Config.Element("WizardIgnoreClassPrereqCheck") = "True" Then IgnoreCheck.Checked = True

            If General.Mode = General.AppMode.Full Then
                Levels.Properties.MaxValue = Rules.Constants.MaxLevels - ExistingCharacter.EffectiveCharacterLevel
            Else
                Levels.Properties.MaxValue = 5 - ExistingCharacter.CharacterLevel
            End If

            'filter the classes and add them to the selection
            Select Case ExistingCharacter.CharacterType
                Case Rules.Character.CharacterObjectType.Familiar, Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                    ClassDatalist = Rules.Index.DataList(XML.DBTypes.MonsterClasses, Objects.MonsterClassType)
                Case Rules.Character.CharacterObjectType.Monster
                    'need normal classes, plus monster's own type class
                    ClassDatalist = Rules.Index.DataList(XML.DBTypes.Classes, Objects.ClassType)
                    Dim MonstrerClass As Objects.ObjectData = ExistingCharacter.RaceObject.GetFKObject("MonsterType")
                    Dim TempDatalistItem As New General.DataListItem(MonstrerClass, MonstrerClass.ObjectGUID, MonstrerClass.Name)
                    Dim NewUpperBound As Integer = ClassDatalist.GetUpperBound(0) + 1
                    ReDim Preserve ClassDatalist(NewUpperBound)
                    ClassDatalist.SetValue(TempDatalistItem, NewUpperBound)
                Case Else
                    ClassDatalist = Rules.Index.DataList(XML.DBTypes.Classes, Objects.ClassType)
            End Select

            PreviousClasses = ExistingCharacter.CharactersClassObjects

            If PreviousClasses.Count > 0 Then LastClass = ExistingCharacter.HighestCharacterLevelObject.GetFKObject("Class")

            For Each TempItem As General.DataListItem In ClassDatalist
                If CheckRequirements(DirectCast(TempItem.ValueMember, Objects.ObjectData), PreviousClasses, LastClass) Then
                    Dim ListItem As New ListViewItem
                    ListItem.Text = TempItem.ToString
                    ListItem.Tag = TempItem
                    ClassListView.Items.Add(ListItem)
                End If
            Next

            'add in default monster levels
            If CurrentCharacterLevel = 0 Then

                'if we are a mount
                If IsMount Then
                    Dim MonsterClass As New Objects.ObjectData
                    MonsterClass.Load(References.Mount)
                    Dim StartLevels As Integer = Math.Max(CInt(ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")), 1)
                    MonsterLevels = StartLevels

                    Dim MonsterLevelRange As LevelRange
                    MonsterLevelRange.ClassTaken = MonsterClass
                    MonsterLevelRange.LevelsAdded = StartLevels
                    MonsterLevelRange.StartCharacterLevel = 1
                    MonsterLevelRange.StartClassLevel = 1

                    'Add New Lines to ClassesPickedBox
                    For i As Integer = 1 To StartLevels
                        Dim Listitem As New ListViewItem
                        Listitem.Text = "Level " & i & " - " & MonsterClass.Name & " " & i
                        LevelsListView.Items.Add(Listitem)
                        Listitem.EnsureVisible()
                    Next

                    'Add New Object to Collection
                    CurrentLevels.Add(MonsterLevelRange)

                    'minus one because it adds the current number in the Levels to add spin edit to the CurrentCharacterLevel
                    CurrentCharacterLevel = (StartLevels - 1)
                    AddUpdateLevels()

                    'if we are actualy a monster instance
                ElseIf IsMonster Then
                    Dim MonstrerClass As Objects.ObjectData = ExistingCharacter.RaceObject.GetFKObject("MonsterType")
                    Dim StartLevels As Integer = Math.Max(CInt(ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")), 1)
                    MonsterLevels = StartLevels

                    Dim MonsterLevelRange As LevelRange
                    MonsterLevelRange.ClassTaken = MonstrerClass
                    MonsterLevelRange.LevelsAdded = StartLevels
                    MonsterLevelRange.StartCharacterLevel = 1
                    MonsterLevelRange.StartClassLevel = 1

                    'Add New Lines to ClassesPickedBox
                    For i As Integer = 1 To StartLevels
                        Dim Listitem As New ListViewItem
                        Listitem.Text = "Level " & i & " - " & MonstrerClass.Name & " " & i
                        LevelsListView.Items.Add(Listitem)
                        Listitem.EnsureVisible()
                    Next

                    'Add New Object to Collection
                    CurrentLevels.Add(MonsterLevelRange)

                    'minus one because it adds the current number in the Levels to add spin edit to the CurrentCharacterLevel
                    CurrentCharacterLevel = (StartLevels - 1)
                    AddUpdateLevels()

                    'if we are are character with a Monster Playable Race
                ElseIf ExistingCharacter.RaceObject.Element("Monster") = "Yes" Then
                    Dim MonstrerClass As Objects.ObjectData = ExistingCharacter.RaceObject.GetFKObject("MonsterType")
                    Dim StartLevels As Integer = ExistingCharacter.RaceObject.ElementAsInteger("StartLevels")
                    MonsterLevels = StartLevels

                    Dim MonsterLevelRange As LevelRange
                    MonsterLevelRange.ClassTaken = MonstrerClass
                    MonsterLevelRange.LevelsAdded = StartLevels
                    MonsterLevelRange.StartCharacterLevel = 1
                    MonsterLevelRange.StartClassLevel = 1

                    'Add New Lines to ClassesPickedBox
                    For i As Integer = 1 To StartLevels
                        Dim Listitem As New ListViewItem
                        Listitem.Text = "Level " & i & " - " & MonstrerClass.Name & " " & i
                        LevelsListView.Items.Add(Listitem)
                        Listitem.EnsureVisible()
                    Next

                    'Add New Object to Collection
                    CurrentLevels.Add(MonsterLevelRange)

                    'minus one because it adds the current number in the Levels to add spin edit to the CurrentCharacterLevel
                    CurrentCharacterLevel = (StartLevels - 1)
                    AddUpdateLevels()
                End If
            End If

            IsLoading = False
            ClassListView.Items(0).Selected = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext
    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised
        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 950
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 650
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel

        'if this is a mount we cant add class levels to it, so enable next button now
        If IsMount OrElse IsMonster Then
            If General.Mode = General.AppMode.Trial Then
                If MonsterLevels <= 5 Then
                    RaiseEvent EnableNext(True)
                End If
            Else
                RaiseEvent EnableNext(True)
            End If
        End If

    End Sub

#End Region

#Region "Event Handlers"

    'levels has changed
    Private Sub Levels_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Levels.EditValueChanged
        Try
            mLevelsToAdd = CInt(Levels.EditValue)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'adds a number of levles of a specifed class
    Private Sub AddLevels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLevels.Click
        Dim SelectedClass As Objects.ObjectData
        Dim ClassLevel, CharacterLevel As Integer
        Dim CurrentLevelRange As New LevelRange
        Try

            'exit sub if (thier are no items selected) or (the item selected is multiclass restricted) or (we are at the level limit)
            If (ClassListView.SelectedItems.Count < 1) OrElse ClassListView.SelectedItems(0).ForeColor.Equals(Color.Red) OrElse (Levels.Properties.Enabled = False) Then Exit Sub

            'SelectedClass.Load(CType(ClassListView.SelectedItems(0).Tag, General.DataListItem).ObjectGUID)
            SelectedClass = CType(CType(ClassListView.SelectedItems(0).Tag, General.DataListItem).ValueMember, Objects.ObjectData)

            If CurrentLevels.Count > 0 Then CurrentLevelRange = DirectCast(CurrentLevels.Item(CurrentLevels.Count - 1), LevelRange)

            'If we are adding more levels to the last class range
            If CurrentLevelRange.ClassTaken.ObjectGUID.Equals(SelectedClass.ObjectGUID) Then
                Dim NewClassLevelsBegin, NewClassLevelsEnd As Integer

                'Get Starting Values
                NewClassLevelsBegin = (CurrentLevelRange.StartClassLevel + CurrentLevelRange.LevelsAdded)
                NewClassLevelsEnd = (NewClassLevelsBegin + mLevelsToAdd) - 1
                CharacterLevel = CurrentCharacterLevel + 1

                'Check Levels Exists
                If CheckLevels(NewClassLevelsBegin, NewClassLevelsEnd, SelectedClass) Then

                    'add New Lines to the LevelslistView
                    For CharacterLevel = CharacterLevel To (CurrentCharacterLevel + mLevelsToAdd)
                        ClassLevel = NewClassLevelsBegin + (CharacterLevel - (CurrentCharacterLevel + 1))

                        Dim Listitem As New ListViewItem
                        Listitem.SubItems.Clear()
                        Listitem.Text = "Level " & CharacterLevel & " - " & SelectedClass.Name & " " & ClassLevel
                        LevelsListView.Items.Add(Listitem)
                        Listitem.EnsureVisible()

                    Next
                    'Update Current Level Range in Collection
                    CurrentLevelRange.LevelsAdded = CurrentLevelRange.LevelsAdded + mLevelsToAdd
                    CurrentLevels.Item(CurrentLevels.Count - 1) = CurrentLevelRange
                    AddUpdateLevels()
                    RaiseEvent EnableNext(True)
                Else
                    General.ShowErrorDialog("Insufficient class levels defined.")
                End If

                'The current class we are adding is different from the previous one
            Else
                Dim NewRange As LevelRange

                'Get Starting Values for CharacterLevel and ClassLevel
                CharacterLevel = CurrentCharacterLevel + 1

                'ClassLevel = Rules.Character2.HighestClassLevel(ExistingCharacter.CharacterObject, SelectedClass) + 1
                ClassLevel = ExistingCharacter.HighestClasslevel(SelectedClass.ObjectGUID) + 1

                'Search through previous additions
                For Each temp As LevelRange In CurrentLevels

                    'Add levels to the Classlevel if this class has been previously picked
                    If temp.ClassTaken.ObjectGUID.Equals(SelectedClass.ObjectGUID) Then
                        ClassLevel = ClassLevel + temp.LevelsAdded
                    End If

                Next

                If CheckLevels(ClassLevel, (ClassLevel + mLevelsToAdd) - 1, SelectedClass) Then

                    'Make New LevelRange Object
                    NewRange.ClassTaken = SelectedClass
                    NewRange.StartCharacterLevel = CharacterLevel
                    NewRange.StartClassLevel = ClassLevel
                    NewRange.LevelsAdded = mLevelsToAdd

                    'Add New Lines to ClassesPickedBox
                    For CharacterLevel = CharacterLevel To (CurrentCharacterLevel + mLevelsToAdd)
                        ClassLevel = NewRange.StartClassLevel + (CharacterLevel - (CurrentCharacterLevel + 1))

                        Dim Listitem As New ListViewItem
                        Listitem.Text = "Level " & CharacterLevel & " - " & SelectedClass.Name & " " & ClassLevel
                        LevelsListView.Items.Add(Listitem)
                        Listitem.EnsureVisible()
                    Next

                    'Add New Object to Collection
                    CurrentLevels.Add(NewRange)
                    AddUpdateLevels()
                    RaiseEvent EnableNext(True)
                Else
                    General.ShowErrorDialog("Insufficient class levels defined.")
                End If

            End If

            If IgnoreCheck.CheckState = CheckState.Unchecked Then
                UpdateClassOptions()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'removes the last level added
    Private Sub RemoveLevels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveLevels.Click
        Try
            Dim CurrentLevelRange As LevelRange

            If LevelsListView.Items.Count < 1 Then Exit Sub

            If LevelsListView.Items.Count = MonsterLevels Then
                General.ShowInfoDialog("Cannot remove compulsory levels.")
                Exit Sub
            End If

            'Get current level range
            CurrentLevelRange = DirectCast(CurrentLevels.Item(CurrentLevels.Count - 1), LevelRange)

            'If more than one level exisits in the current range, remove the last one
            'If there is more than one, remove the entire object
            If CurrentLevelRange.LevelsAdded > 1 Then

                'Remove the last level
                CurrentLevelRange.LevelsAdded = CurrentLevelRange.LevelsAdded - 1

                'Update the collection
                CurrentLevels.Item(CurrentLevels.Count - 1) = CurrentLevelRange

            Else

                'Remove the Object from the collection
                CurrentLevels.Remove(CurrentLevelRange)

            End If

            'Update the ClassPickedBox
            LevelsListView.Items(LevelsListView.Items.Count - 1).EnsureVisible()
            LevelsListView.Items.RemoveAt(LevelsListView.Items.Count - 1)

            If LevelsListView.Items.Count < 1 Then RaiseEvent DisableNext()

            'Update Character Level, and Max levels
            CurrentCharacterLevel = CurrentCharacterLevel - 1

            If General.Mode = General.AppMode.Full Then
                Levels.Properties.MaxValue = (Rules.Constants.MaxLevels - CurrentCharacterLevel)
            Else
                Levels.Properties.MaxValue = 5 - CurrentCharacterLevel
            End If

            If Levels.Properties.MaxValue >= 1 Then
                Levels.Properties.Enabled = True
            End If

            'update the list of clases in the ClassListview
            If IgnoreCheck.CheckState = CheckState.Unchecked Then
                UpdateClassOptions()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display fix
    Private Sub LevelsListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelsListView.SelectedIndexChanged
        If LevelsListView.SelectedItems.Count > 0 Then
            LevelsListView.SelectedItems(0).Selected = False
        End If
    End Sub

    'update option when checkbox is toggled
    Private Sub IgnoreCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreCheck.CheckedChanged
        If IsLoading Then Exit Sub

        ClassListView.BeginUpdate()
        ClassListView.Items.Clear()

        If IgnoreCheck.Checked Then General.Config.Element("WizardIgnoreClassPrereqCheck") = "True" Else General.Config.Element("WizardIgnoreClassPrereqCheck") = ""

        Dim PreviousClasses As Objects.ObjectDataCollection = ExistingCharacter.CharactersClassObjects
        Dim LastClass As New Objects.ObjectData
        If PreviousClasses.Count > 0 Then LastClass = ExistingCharacter.HighestCharacterLevelObject.GetFKObject("Class")

        For Each TempItem As General.DataListItem In ClassDatalist
            If CheckRequirements(DirectCast(TempItem.ValueMember, Objects.ObjectData), PreviousClasses, LastClass) Then
                Dim ListItem As New ListViewItem
                ListItem.Text = TempItem.ToString
                ListItem.Tag = TempItem
                ClassListView.Items.Add(ListItem)
            End If
        Next

        ClassListView.EndUpdate()
        If IgnoreCheck.CheckState = CheckState.Unchecked Then
            UpdateClassOptions()
        End If

    End Sub

    'add a class level when doubled clicked
    Private Sub ClassListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassListView.DoubleClick
        AddLevels_Click(Nothing, Nothing)
    End Sub


#End Region

    'Checks that Class levels have been defined
    Private Function CheckLevels(ByVal LevelStart As Integer, ByVal LevelEnd As Integer, ByVal ClassObject As Objects.ObjectData) As Boolean
        Try
            Dim ClassInfo As Rules.CharacterClass = Caches.GetCharacterClass(ClassObject.ObjectGUID)

            'Make sure all the class levels are defined
            For I As Integer = LevelStart To LevelEnd
                If ClassInfo.LevelExists(I) = False Then
                    Return False
                End If
            Next

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Updates Character Level and Max Levels, only to be called from AddLevels_Click
    Private Sub AddUpdateLevels()
        Try
            CurrentCharacterLevel = CurrentCharacterLevel + mLevelsToAdd

            If General.Mode = General.AppMode.Full Then
                Levels.Properties.MaxValue = (Rules.Constants.MaxLevels - CurrentCharacterLevel)
            Else
                Levels.Properties.MaxValue = 5 - CurrentCharacterLevel
            End If

            If Levels.Properties.MaxValue < 1 OrElse IsMount Then
                'If max is set below min, min is set to max, so we need to reset the values
                Levels.Properties.MinValue = 1
                Levels.Properties.MaxValue = 1
                Levels.Properties.Enabled = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the selection options for classes with MultiClass restrictions
    Private Sub UpdateClassOptions()
        Dim LastClass As New Objects.ObjectData
        Dim LastLevel As Objects.ObjectData
        Dim PreviousClasses As Objects.ObjectDataCollection
        Dim TempLevelRange As LevelRange
        Try

            'get any classes the character allready has
            PreviousClasses = ExistingCharacter.CharactersClassObjects

            'get any classes that have been added since the start of the wizzard
            For Each TempLevelRange In CurrentLevels
                If Not PreviousClasses.Contains(TempLevelRange.ClassTaken.ObjectGUID) Then
                    PreviousClasses.Add(TempLevelRange.ClassTaken)
                End If
            Next

            'get ClassObject for the characters highest character level
            If CurrentLevels.Count > 0 Then
                LastClass = DirectCast(CurrentLevels.Item(CurrentLevels.Count - 1), LevelRange).ClassTaken
            Else
                LastLevel = ExistingCharacter.HighestCharacterLevelObject
                If LastLevel.ObjectGUID.IsNotEmpty Then
                    LastClass = LastLevel.GetFKObject("Class")
                End If
            End If

            For Each TempListItem As ListViewItem In ClassListView.Items
                If AllowedMulticlass(CType(CType(TempListItem.Tag, General.DataListItem).ValueMember, Objects.ObjectData), PreviousClasses, LastClass) Then
                    TempListItem.ForeColor = Color.Black
                    TempListItem.Text = CType(TempListItem.Tag, General.DataListItem).DisplayMember
                Else
                    TempListItem.ForeColor = Color.Red
                    TempListItem.Text = CType(TempListItem.Tag, General.DataListItem).DisplayMember & " (Multiclass Restricted)"
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'check class restrictions and prerequisites
    Private Function CheckRequirements(ByVal ClassObj As Objects.ObjectData, ByVal PreviousClasses As Objects.ObjectDataCollection, ByVal LastClass As Objects.ObjectData) As Boolean
        Select Case ExistingCharacter.CharacterType
            Case Rules.Character.CharacterObjectType.AnimalCompanion
                If IsMount Then
                    If ClassObj.ObjectGUID.Equals(References.Mount) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim AllowedComapanionClass As Objects.ObjectKey = ExistingCharacter.RaceObject.GetFKGuid("CompanionClass")
                    If ClassObj.ObjectGUID.Equals(AllowedComapanionClass) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Case Rules.Character.CharacterObjectType.Familiar
                Dim AllowedFamiliarClass As Objects.ObjectKey = ExistingCharacter.RaceObject.GetFKGuid("FamiliarClass")
                If ClassObj.ObjectGUID.Equals(AllowedFamiliarClass) Then
                    Return True
                Else
                    Return False
                End If
            Case Rules.Character.CharacterObjectType.SpecialMount
                Dim AllowedMountClass As Objects.ObjectKey = ExistingCharacter.RaceObject.GetFKGuid("MountClass")
                If ClassObj.ObjectGUID.Equals(AllowedMountClass) Then
                    Return True
                Else
                    Return False
                End If
            Case Else
                If IgnoreCheck.CheckState = CheckState.Checked Then Return True

                If AllowedAlignment(ClassObj, ExistingCharacter) AndAlso AllowedMulticlass(ClassObj, PreviousClasses, LastClass) Then

                    'check prerequisites
                    Dim PrerequisiteObjects As Objects.ObjectDataCollection = PrereqCollection.ChildrenFast(ClassObj.ObjectGUID)
                    For Each Prerequisite As Objects.ObjectData In PrerequisiteObjects
                        If Not ExistingCharacter.Prerequisites.HasPrerequisite(Prerequisite, ExistingCharacter.CharacterLevel, PrereqChildCollection.ChildrenFast(Prerequisite.ObjectGUID)) Then
                            Return False
                        End If
                    Next

                    Return True
                Else
                    Return False
                End If
        End Select
    End Function

    'returns True, if this class is allowed to be taken by a character of the given alignment
    Private Function AllowedAlignment(ByVal ClassObj As Objects.ObjectData, ByVal EC As Rules.Character) As Boolean
        Dim Alignment As String

        'if this is a monster class then it is not restricted by alignment
        If ClassObj.ObjectGUID.Database = XML.DBTypes.MonsterClasses Then Return True

        Try
            Alignment = EC.CharacterObject.Element("Alignment")

            'cleric specific
            If ClassObj.Element("RestrictAlignment") = "True" Then
                Dim Deity As Objects.ObjectData
                Deity = EC.CharacterObject.GetFKObject("Deity")

                'if the cleric worships a deity
                If Not Deity.IsEmpty Then
                    Select Case Alignment
                        Case "Lawful Good"
                            If (ClassObj.Element("LawfulGood") = "True") And (Deity.Element("LawfulGood") = "True") Then Return True
                        Case "Neutral Good"
                            If (ClassObj.Element("NeutralGood") = "True") And (Deity.Element("NeutralGood") = "True") Then Return True
                        Case "Chaotic Good"
                            If (ClassObj.Element("ChaoticGood") = "True") And (Deity.Element("ChaoticGood") = "True") Then Return True
                        Case "Lawful Neutral"
                            If (ClassObj.Element("LawfulNeutral") = "True") And (Deity.Element("LawfulNeutral") = "True") Then Return True
                        Case "True Neutral"
                            If (ClassObj.Element("TrueNeutral") = "True") And (Deity.Element("TrueNeutral") = "True") Then Return True
                        Case "Chaotic Neutral"
                            If (ClassObj.Element("ChaoticNeutral") = "True") And (Deity.Element("ChaoticNeutral") = "True") Then Return True
                        Case "Lawful Evil"
                            If (ClassObj.Element("LawfulEvil") = "True") And (Deity.Element("LawfulEvil") = "True") Then Return True
                        Case "Neutral Evil"
                            If (ClassObj.Element("NeutralEvil") = "True") And (Deity.Element("NeutralEvil") = "True") Then Return True
                        Case "Chaotic Evil"
                            If (ClassObj.Element("ChaoticEvil") = "True") And (Deity.Element("ChaoticEvil") = "True") Then Return True
                    End Select

                    Return False

                End If

            End If

            'general case for most classes
            Select Case Alignment
                Case "Lawful Good"
                    If ClassObj.Element("LawfulGood") = "True" Then Return True
                Case "Neutral Good"
                    If ClassObj.Element("NeutralGood") = "True" Then Return True
                Case "Chaotic Good"
                    If ClassObj.Element("ChaoticGood") = "True" Then Return True
                Case "Lawful Neutral"
                    If ClassObj.Element("LawfulNeutral") = "True" Then Return True
                Case "True Neutral"
                    If ClassObj.Element("TrueNeutral") = "True" Then Return True
                Case "Chaotic Neutral"
                    If ClassObj.Element("ChaoticNeutral") = "True" Then Return True
                Case "Lawful Evil"
                    If ClassObj.Element("LawfulEvil") = "True" Then Return True
                Case "Neutral Evil"
                    If ClassObj.Element("NeutralEvil") = "True" Then Return True
                Case "Chaotic Evil"
                    If ClassObj.Element("ChaoticEvil") = "True" Then Return True
            End Select

            Return False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'returns True, if the character is allowed to continue in a given class.
    Private Function AllowedMulticlass(ByVal ClassObj As Objects.ObjectData, ByVal PerviousClasses As Objects.ObjectDataCollection, ByVal LastClass As Objects.ObjectData) As Boolean
        Try

            'If the character has no previous classes return true
            If PerviousClasses.Count < 1 Then
                Return True
            End If

            Select Case ExistingCharacter.CharacterType

                Case Rules.Character.CharacterObjectType.Familiar

                    'if the class is a familiar class, but not the same one we picked before
                    If PerviousClasses.Contains(ClassObj.ObjectGUID) Then
                        Return True
                    Else
                        Return False
                    End If

                Case Else

                    'If this class is retricted and the character has chosen this class before
                    If ClassObj.Element("RestrictMulticlass") = "True" And PerviousClasses.Contains(ClassObj.ObjectGUID) Then

                        'If this class is the same as the characters previous class, they may continue with it
                        If ClassObj.ObjectGUID.Equals(LastClass.ObjectGUID) Then
                            Return True
                        Else
                            Return False
                        End If

                    End If

                    Return True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#Region "Paint Events"

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim rect As Rectangle = Panel1.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
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

    'show rule page
    Private Sub ClassListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassListView.SelectedIndexChanged
        Try
            If ClassListView.SelectedItems.Count > 0 Then
                Dim TempItem As General.DataListItem = CType(ClassListView.SelectedItems.Item(0).Tag, General.DataListItem)
                Dim TempObject As Objects.ObjectData = CType(TempItem.ValueMember, Objects.ObjectData)
                Dim URL As String

                If TempObject.HTML.IndexOf(":\") = 1 And IO.File.Exists(TempObject.HTML) Then
                    URL = "file://" & TempObject.HTML
                Else
                    If IO.File.Exists(General.HelpPath & TempObject.HTML) Then
                        URL = "file://" & General.HelpPath & TempObject.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
