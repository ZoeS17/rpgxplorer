Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class RollHitDicePanel
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
    Public WithEvents DiceRoller As RPGXplorer.Dice
    Public WithEvents HPLabel As System.Windows.Forms.Label
    Public WithEvents RollDie As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TotalHP As DevExpress.XtraEditors.TextEdit
    Public WithEvents RollHistory As RPGXplorer.ListBox
    Public WithEvents RollDie2 As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents TotalHP2 As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents RollAllButton As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents SmallLabel As System.Windows.Forms.Label
    Public WithEvents AverageButton As System.Windows.Forms.Button
    Public WithEvents CONMod As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.HPLabel = New System.Windows.Forms.Label
        Me.DiceRoller = New RPGXplorer.Dice
        Me.RollDie = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RollHistory = New RPGXplorer.ListBox
        Me.RollAllButton = New System.Windows.Forms.Button
        Me.RollDie2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.AverageButton = New System.Windows.Forms.Button
        Me.TotalHP = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TotalHP2 = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SmallLabel = New System.Windows.Forms.Label
        Me.CONMod = New DevExpress.XtraEditors.TextEdit
        Me.Panel1.SuspendLayout()
        CType(Me.TotalHP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TotalHP2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONMod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HPLabel
        '
        Me.HPLabel.BackColor = System.Drawing.Color.Transparent
        Me.HPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HPLabel.Location = New System.Drawing.Point(15, 15)
        Me.HPLabel.Name = "HPLabel"
        Me.HPLabel.Size = New System.Drawing.Size(245, 21)
        Me.HPLabel.TabIndex = 0
        Me.HPLabel.Text = "Please roll your hit points"
        Me.HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiceRoller
        '
        Me.DiceRoller.BackColor = System.Drawing.SystemColors.Control
        Me.DiceRoller.Location = New System.Drawing.Point(15, 45)
        Me.DiceRoller.Name = "DiceRoller"
        Me.DiceRoller.Size = New System.Drawing.Size(216, 76)
        Me.DiceRoller.TabIndex = 1
        '
        'RollDie
        '
        Me.RollDie.BackColor = System.Drawing.SystemColors.Control
        Me.RollDie.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RollDie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollDie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RollDie.Location = New System.Drawing.Point(185, 60)
        Me.RollDie.Name = "RollDie"
        Me.RollDie.Size = New System.Drawing.Size(100, 24)
        Me.RollDie.TabIndex = 1
        Me.RollDie.Text = "Roll Level N"
        Me.RollDie.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Total Hit Points"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 21)
        Me.Label2.TabIndex = 297
        Me.Label2.Text = "Hit Points Rolls"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RollHistory
        '
        Me.RollHistory.Location = New System.Drawing.Point(5, 60)
        Me.RollHistory.Name = "RollHistory"
        Me.RollHistory.Size = New System.Drawing.Size(165, 175)
        Me.RollHistory.TabIndex = 5
        '
        'RollAllButton
        '
        Me.RollAllButton.BackColor = System.Drawing.SystemColors.Control
        Me.RollAllButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RollAllButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RollAllButton.Location = New System.Drawing.Point(185, 95)
        Me.RollAllButton.Name = "RollAllButton"
        Me.RollAllButton.Size = New System.Drawing.Size(100, 24)
        Me.RollAllButton.TabIndex = 2
        Me.RollAllButton.Text = "Roll All"
        Me.RollAllButton.UseVisualStyleBackColor = False
        '
        'RollDie2
        '
        Me.RollDie2.BackColor = System.Drawing.SystemColors.Control
        Me.RollDie2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RollDie2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollDie2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RollDie2.Location = New System.Drawing.Point(185, 4)
        Me.RollDie2.Name = "RollDie2"
        Me.RollDie2.Size = New System.Drawing.Size(100, 24)
        Me.RollDie2.TabIndex = 1
        Me.RollDie2.Text = "Reroll"
        Me.RollDie2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.AverageButton)
        Me.Panel1.Controls.Add(Me.RollDie)
        Me.Panel1.Controls.Add(Me.RollAllButton)
        Me.Panel1.Controls.Add(Me.TotalHP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RollHistory)
        Me.Panel1.Location = New System.Drawing.Point(10, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 245)
        Me.Panel1.TabIndex = 299
        '
        'AverageButton
        '
        Me.AverageButton.BackColor = System.Drawing.SystemColors.Control
        Me.AverageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AverageButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AverageButton.Location = New System.Drawing.Point(185, 130)
        Me.AverageButton.Name = "AverageButton"
        Me.AverageButton.Size = New System.Drawing.Size(100, 24)
        Me.AverageButton.TabIndex = 298
        Me.AverageButton.Text = "Average All"
        Me.AverageButton.UseVisualStyleBackColor = False
        '
        'TotalHP
        '
        Me.TotalHP.EditValue = ""
        Me.TotalHP.Location = New System.Drawing.Point(120, 5)
        Me.TotalHP.Name = "TotalHP"
        Me.TotalHP.Properties.Appearance.Options.UseTextOptions = True
        Me.TotalHP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalHP.Properties.AutoHeight = False
        Me.TotalHP.Properties.ReadOnly = True
        Me.TotalHP.Size = New System.Drawing.Size(50, 21)
        Me.TotalHP.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TotalHP2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.RollDie2)
        Me.Panel2.Location = New System.Drawing.Point(10, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 35)
        Me.Panel2.TabIndex = 300
        '
        'TotalHP2
        '
        Me.TotalHP2.EditValue = ""
        Me.TotalHP2.Location = New System.Drawing.Point(120, 5)
        Me.TotalHP2.Name = "TotalHP2"
        Me.TotalHP2.Properties.Appearance.Options.UseTextOptions = True
        Me.TotalHP2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TotalHP2.Properties.AutoHeight = False
        Me.TotalHP2.Properties.ReadOnly = True
        Me.TotalHP2.Size = New System.Drawing.Size(50, 21)
        Me.TotalHP2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 300
        Me.Label3.Text = "Total Hit Points"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "CON Modifier"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SmallLabel
        '
        Me.SmallLabel.BackColor = System.Drawing.Color.Transparent
        Me.SmallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmallLabel.Location = New System.Drawing.Point(240, 45)
        Me.SmallLabel.Name = "SmallLabel"
        Me.SmallLabel.Size = New System.Drawing.Size(245, 75)
        Me.SmallLabel.TabIndex = 303
        Me.SmallLabel.Text = "SmallDiceMide info message"
        '
        'CONMod
        '
        Me.CONMod.EditValue = ""
        Me.CONMod.Location = New System.Drawing.Point(130, 135)
        Me.CONMod.Name = "CONMod"
        Me.CONMod.Properties.Appearance.Options.UseTextOptions = True
        Me.CONMod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CONMod.Properties.AutoHeight = False
        Me.CONMod.Properties.ReadOnly = True
        Me.CONMod.Size = New System.Drawing.Size(50, 21)
        Me.CONMod.TabIndex = 301
        '
        'RollHitDicePanel
        '
        Me.Controls.Add(Me.SmallLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DiceRoller)
        Me.Controls.Add(Me.HPLabel)
        Me.Controls.Add(Me.CONMod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RollHitDicePanel"
        Me.Size = New System.Drawing.Size(500, 415)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TotalHP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TotalHP2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONMod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised, HitDiceMode As Boolean
    Private Character As Rules.Character
    Private DiceRange As Rules.Dice.DiceRange
    Private LevelsToAdd, CurrentLevel, Marker, CurrentHP As Integer
    Private mHitPointRolls As New ArrayList
    Private Levels As LevellingUpWizard.LevelRangeCollection
    Private CONModifiers As Hashtable
    Private CONModifier As Integer

    'contains a mapping of hit dice to level
    Private LevelMapTable As Hashtable
    Private HitDice As Integer

    Private SmallHitDiceMode As Boolean
    Private Multiplier As Double = 1

    'structure to hold assignment history
    Public Structure HPRoll
        Public Level As Integer
        Public HPRoll As Double

        Public Overrides Function ToString() As String
            Return "Level " & Level & " - " & HPRoll
        End Function
    End Structure

#End Region

#Region "Properties"

    Public ReadOnly Property HitPointRolls() As ArrayList
        Get
            Return mHitPointRolls
        End Get
    End Property

#End Region

    'initialise this panel
    Public Sub Init(ByVal Character As Rules.Character, ByVal ExistingCharacter As Rules.Character, ByVal LevelRanges As LevellingUpWizard.LevelRangeCollection, ByVal LevelsToAdd As Integer, ByVal SmallHitDiceMode As Boolean)
        Try
            'Levels in a list of LevelRanges
            Me.Character = Character
            Me.Levels = LevelRanges
            Me.SmallHitDiceMode = SmallHitDiceMode
            CurrentLevel = ExistingCharacter.CharacterLevel

            'Only need the highest Con Modifier as it is backtracked to all levels
            CONModifier = Rules.AbilityScores.AbilityScore(Character.CurrentLevel.CON).Modifier
            Marker = 0
            CurrentHP = Character.HP

            Select Case Character.CharacterType
                Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                    'Me.LevelsToAdd = HitDice - ExistingCharacter.HitDice
                    Me.LevelsToAdd = HitDice
                    Me.CurrentLevel = ExistingCharacter.HitDice
                    HitDiceMode = True
                Case Else
                    Me.LevelsToAdd = LevelsToAdd
                    HitDiceMode = False
            End Select

            'Get the hitDice for the first class in the levels array
            mHitPointRolls.Clear()
            RollHistory.Clear()
            RollHistory.List.SortOrder = SortOrder.None

            UpdateTotalHPAndButtons()

            'hide controls for multiple levels if only adding one level
            If Me.LevelsToAdd = 1 Then
                Panel1.Visible = False
                Panel2.Visible = True
            Else
                Panel1.Visible = True
                Panel2.Visible = False
            End If

            If SmallHitDiceMode Then
                SmallLabel.Visible = True
                Multiplier = Character.RaceObject.ElementAsNumber("DiceNumber")
                SmallLabel.Text = "This value will be multiplied by " & Character.RaceObject.Element("DiceNumber") & " to get the final Hit Dice Roll."

                'set location
                Dim XoffSet As Integer = DiceRoller.Width + DiceRoller.Location.X + 10
                Dim Pos As System.Drawing.Point = SmallLabel.Location
                Pos.X = XoffSet
                SmallLabel.Location = Pos
            Else
                SmallLabel.Visible = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the panel
    Public Shadows Sub Update()
        Try
            CONModifier = Rules.AbilityScores.AbilityScore(Character.CurrentLevel.CON).Modifier
            UpdateTotalHPAndButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'is the panel required
    Public Function PanelRequired(ByVal ExistingCharacter As Rules.Character, ByVal NewCharacter As Rules.Character, ByVal LevelRanges As LevellingUpWizard.LevelRangeCollection) As Boolean
        Select Case ExistingCharacter.CharacterType
            Case Rules.Character.CharacterObjectType.Familiar
                Return False
            Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                LevelMapTable = New Hashtable(Rules.Constants.MaxLevels)
                HitDice = 0

                'change LevelsToAdd to the ammount of HitDice we need to roll
                Dim RacialHitDice As Double
                Dim ClassHitDice As Integer

                'if this is first level - add racial hit dice
                If NewCharacter.FirstNewLevel = 1 Then
                    RacialHitDice = NewCharacter.RaceObject.ElementAsNumber("DiceNumber")
                    If RacialHitDice < 1 Then RacialHitDice = 1

                    'map the racial hitdice levels to level 1
                    For i As Integer = 1 To CInt(RacialHitDice)
                        LevelMapTable.Item(i) = 1
                    Next

                    HitDice = CInt(RacialHitDice)
                End If

                'go through the classlevels and add any bonus HD - only one level range with an AC or SM
                Dim LevelRange As LevellingUpWizard.LevelRange = CType(LevelRanges.LevelRanges.Item(0), LevellingUpWizard.LevelRange)
                Dim AnimalClass As Rules.CharacterClass = NewCharacter.CharacterClasses(LevelRange.ClassTaken.ObjectGUID)

                'i is the class level count
                For i As Integer = LevelRange.StartClassLevel To (LevelRange.StartClassLevel + LevelRange.LevelsAdded) - 1
                    ClassHitDice = AnimalClass.ClassLevel(i).ElementAsInteger("HitDice")
                    If ClassHitDice > 0 Then
                        'j is the count of hitdice from this class level 
                        For j As Integer = 1 To ClassHitDice
                            HitDice += 1
                            LevelMapTable.Item(HitDice) = i + (LevelRange.StartCharacterLevel - LevelRange.StartClassLevel)
                        Next
                    End If

                Next

                If HitDice > 0 Then Return True Else Return False
            Case Else
                Return True
        End Select
    End Function

#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext
    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            If SmallHitDiceMode Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised
        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 500
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 500
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel
        Try
            If Marker = 0 Then
                If CurrentLevel = 0 Then
                    DiceRoller.SetMax()
                Else
                    DiceRoller.SetDie(Rules.Dice.RollDiceRange(DiceRange))
                End If

                AddRoll()

                If LevelsToAdd = 1 Then
                    RaiseEvent EnableNext(Me.IsFirstTab)
                End If
            Else
                DiceRoller.SetDie(CInt(Math.Floor(CType(mHitPointRolls(RollHistory.SelectedIndex), HPRoll).HPRoll)))
                If Marker = LevelsToAdd Then RaiseEvent EnableNext(Me.IsFirstTab)
            End If

            IsInitialised = True
            Me.Refresh()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Event Handlers"

    'dice has changed
    Private Sub DiceRoller_DiceClicked() Handles DiceRoller.DiceClicked
        Try
            UpdateRoll()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll the dice
    Private Sub RollDie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollDie.Click
        Try
            If Marker < LevelsToAdd Then

                'update the DiceRoller
                Dim ClassObj As Objects.ObjectData
                If HitDiceMode Then
                    ClassObj = Levels.GetLevelRange(CInt(LevelMapTable(Marker + 1))).ClassTaken
                Else
                    ClassObj = Levels.GetLevelRange(CurrentLevel + Marker + 1).ClassTaken
                End If

                DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
                DiceRange.DiceCount = 1
                DiceRoller.Init(DiceRange.Dice)
                DiceRoller.Width = DiceRoller.DieWidth

                DiceRoller.SetDie(Rules.Dice.RollDiceRange(DiceRange))
                AddRoll()
            Else
                DiceRoller.SetDie(Rules.Dice.RollDiceRange(DiceRange))
                UpdateRoll()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll the dice - single level
    Private Sub RollDie2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollDie2.Click
        Try
            DiceRoller.SetDie(Rules.Dice.RollDiceRange(DiceRange))
            If Marker < LevelsToAdd Then
                AddRoll()
            Else
                UpdateRoll()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll all levels
    Private Sub RollAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollAllButton.Click
        Try
            RollAll()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll average for all levels
    Private Sub AverageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AverageButton.Click
        Try
            RollAverage()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'make sure the roller and the selected item show the same hp roll
    Private Sub RollHistory_SelectedItemChanged() Handles RollHistory.SelectedItemChanged
        Dim Roll As HPRoll
        Dim ClassObj As Objects.ObjectData

        Try
            If RollHistory.SelectedIndex = -1 Then Exit Sub

            If HitDiceMode Then
                ClassObj = Levels.GetLevelRange(CurrentLevel + 1).ClassTaken
            Else
                ClassObj = Levels.GetLevelRange(CurrentLevel + RollHistory.SelectedIndex + 1).ClassTaken
            End If

            DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
            DiceRange.DiceCount = 1
            DiceRoller.Init(DiceRange.Dice)
            DiceRoller.Width = DiceRoller.DieWidth

            Roll = CType(mHitPointRolls(RollHistory.SelectedIndex), HPRoll)
            DiceRoller.SetDie(CInt(Math.Floor(Roll.HPRoll)))

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Helper Functions"

    'add roll
    Public Function AddRoll() As Boolean
        Dim Roll As HPRoll
        Try
            If HitDiceMode Then
                Roll.Level = CInt(LevelMapTable(Marker + 1))
            Else
                Roll.Level = CurrentLevel + Marker + 1
            End If

            Roll.HPRoll = DiceRoller.GetDieValue
            mHitPointRolls.Add(Roll)
            RollHistory.AddItem(Roll)
            RollHistory.SelectedIndex = Marker

            Marker += 1
            UpdateTotalHPAndButtons()

            If Marker = LevelsToAdd Then RaiseEvent EnableNext(Me.IsFirstTab)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'roll all
    Public Sub RollAll()
        Dim Roll As HPRoll
        Dim ClassObj As Objects.ObjectData

        Try
            RollHistory.Clear()
            mHitPointRolls.Clear()

            For n As Integer = CurrentLevel + 1 To CurrentLevel + LevelsToAdd
                If HitDiceMode Then
                    ClassObj = Levels.GetLevelRange(CInt(LevelMapTable.Item(n - CurrentLevel))).ClassTaken
                    DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
                    DiceRange.DiceCount = 1
                    Roll.Level = CInt(LevelMapTable(n - CurrentLevel))
                    Roll.HPRoll = Rules.Dice.RollDiceRange(DiceRange)
                Else
                    ClassObj = Levels.GetLevelRange(n).ClassTaken
                    DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
                    DiceRange.DiceCount = 1
                    Roll.Level = n
                    If n = 1 Then
                        Roll.HPRoll = Rules.Dice.GetDiceMax(DiceRange.Dice)
                    Else
                        Roll.HPRoll = Rules.Dice.RollDiceRange(DiceRange)
                    End If
                End If

                mHitPointRolls.Add(Roll)
                RollHistory.AddItem(Roll)

                RollHistory.SelectedIndex = n
            Next

            Marker = LevelsToAdd
            RaiseEvent EnableNext(Me.IsFirstTab)
            UpdateTotalHPAndButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll average
    Private Sub RollAverage()
        Dim Roll As HPRoll
        Dim ClassObj As Objects.ObjectData

        Try
            RollHistory.Clear()
            mHitPointRolls.Clear()

            For n As Integer = CurrentLevel + 1 To CurrentLevel + LevelsToAdd
                If HitDiceMode Then
                    ClassObj = Levels.GetLevelRange(CInt(LevelMapTable(n - CurrentLevel))).ClassTaken
                    DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
                    DiceRange.DiceCount = 1
                    Roll.Level = CInt(LevelMapTable(n - CurrentLevel))
                    Roll.HPRoll = Rules.Dice.GetDiceAverage(DiceRange.Dice)
                Else
                    ClassObj = Levels.GetLevelRange(n).ClassTaken
                    DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
                    DiceRange.DiceCount = 1

                    Roll.Level = n
                    If n = 1 Then
                        Roll.HPRoll = Rules.Dice.GetDiceAverage(DiceRange.Dice)
                    Else
                        Roll.HPRoll = Rules.Dice.GetDiceAverage(DiceRange.Dice)
                    End If
                End If

                mHitPointRolls.Add(Roll)
                RollHistory.AddItem(Roll)

                RollHistory.SelectedIndex = n
            Next

            Marker = LevelsToAdd
            RaiseEvent EnableNext(Me.IsFirstTab)
            UpdateTotalHPAndButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update roll
    Public Sub UpdateRoll()
        Dim Roll As HPRoll

        Try

            If HitDiceMode Then
                Roll.Level = CInt(LevelMapTable(RollHistory.SelectedIndex + 1))
            Else
                Roll.Level = CurrentLevel + RollHistory.SelectedIndex + 1
            End If

            Roll.HPRoll = DiceRoller.GetDieValue
            RollHistory.ItemObject(RollHistory.SelectedIndex) = Roll
            mHitPointRolls.Item(RollHistory.SelectedIndex) = Roll
            UpdateTotalHPAndButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update rolls
    Public Sub UpdateRolls()
        Dim Roll As HPRoll
        Dim n As Integer

        Try
            For n = 0 To RollHistory.Count - 1
                Roll = CType(RollHistory.ItemObject(n), HPRoll)
                RollHistory.ItemObject(n) = Roll
                mHitPointRolls.Item(n) = Roll
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'set button labels, total hp
    Private Shadows Sub UpdateTotalHPAndButtons()
        Dim HP As Integer
        Dim Roll As HPRoll
        Dim ClassObj As Objects.ObjectData

        Try
            If Marker = LevelsToAdd Then
                RollDie.Text = "Reroll Selected"
                RollAllButton.Text = "Reroll All"
            Else
                RollDie.Text = "Roll Next"
                RollAllButton.Text = "Roll All"

                Dim Adjust As Integer
                If CurrentLevel + Marker = CurrentLevel Then Adjust = 1 Else Adjust = 0

                'update the DiceRoller
                If HitDiceMode Then
                    ClassObj = Levels.GetLevelRange(CurrentLevel + 1).ClassTaken
                Else
                    ClassObj = Levels.GetLevelRange(CurrentLevel + Marker + Adjust).ClassTaken
                End If

                DiceRange.Dice = Rules.Dice.GetDice(ClassObj.Element("HitDice"))
                DiceRange.DiceCount = 1
                DiceRoller.Init(DiceRange.Dice)
                DiceRoller.Width = DiceRoller.DieWidth

            End If

            'total hit points
            HP = CurrentHP
            Dim TempHP As Double

            If SmallHitDiceMode Then
                For Each Roll In mHitPointRolls
                    TempHP += Math.Max(Math.Ceiling(Roll.HPRoll * Multiplier) + CONModifier, 1)
                Next
            Else
                For Each Roll In mHitPointRolls
                    TempHP += Math.Max((Roll.HPRoll + CONModifier), 1)
                Next
            End If

            HP += CInt(Math.Floor(TempHP))

            CONMod.Text = Rules.Formatting.FormatModifier(CONModifier)
            TotalHP.Text = HP.ToString
            TotalHP2.Text = HP.ToString

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region


End Class
