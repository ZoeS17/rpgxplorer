Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CreateClassLevelsForm
    Inherits System.Windows.Forms.Form

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
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents MainTab As System.Windows.Forms.TabPage
    Public WithEvents Levels5 As System.Windows.Forms.RadioButton
    Public WithEvents Levels20 As System.Windows.Forms.RadioButton
    Public WithEvents Levels10 As System.Windows.Forms.RadioButton
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents BABHigh As System.Windows.Forms.RadioButton
    Public WithEvents BABMedium As System.Windows.Forms.RadioButton
    Public WithEvents BABLow As System.Windows.Forms.RadioButton
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents FortitudeHigh As System.Windows.Forms.RadioButton
    Public WithEvents FortitudeLow As System.Windows.Forms.RadioButton
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents ReflexHigh As System.Windows.Forms.RadioButton
    Public WithEvents ReflexLow As System.Windows.Forms.RadioButton
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents WillHigh As System.Windows.Forms.RadioButton
    Public WithEvents WillLow As System.Windows.Forms.RadioButton
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents FirstHDBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents LevelOffset As DevExpress.XtraEditors.SpinEdit
    Public WithEvents FirstHDBonusLabel As System.Windows.Forms.Label
    Public WithEvents LevelOffsetLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateClassLevelsForm))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MainTab = New System.Windows.Forms.TabPage
        Me.FirstHDBonusLabel = New System.Windows.Forms.Label
        Me.LevelOffsetLabel = New System.Windows.Forms.Label
        Me.FirstHDBonus = New DevExpress.XtraEditors.SpinEdit
        Me.LevelOffset = New DevExpress.XtraEditors.SpinEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Levels10 = New System.Windows.Forms.RadioButton
        Me.Levels5 = New System.Windows.Forms.RadioButton
        Me.Levels20 = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BABHigh = New System.Windows.Forms.RadioButton
        Me.BABLow = New System.Windows.Forms.RadioButton
        Me.BABMedium = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ReflexHigh = New System.Windows.Forms.RadioButton
        Me.ReflexLow = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FortitudeHigh = New System.Windows.Forms.RadioButton
        Me.FortitudeLow = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.WillHigh = New System.Windows.Forms.RadioButton
        Me.WillLow = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.MainTab.SuspendLayout()
        CType(Me.FirstHDBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 405)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(250, 405)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "Create Levels"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MainTab)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.FirstHDBonusLabel)
        Me.MainTab.Controls.Add(Me.LevelOffsetLabel)
        Me.MainTab.Controls.Add(Me.FirstHDBonus)
        Me.MainTab.Controls.Add(Me.LevelOffset)
        Me.MainTab.Controls.Add(Me.Panel5)
        Me.MainTab.Controls.Add(Me.Panel4)
        Me.MainTab.Controls.Add(Me.Label4)
        Me.MainTab.Controls.Add(Me.Panel2)
        Me.MainTab.Controls.Add(Me.Panel1)
        Me.MainTab.Controls.Add(Me.Label2)
        Me.MainTab.Controls.Add(Me.Label1)
        Me.MainTab.Controls.Add(Me.Label3)
        Me.MainTab.Controls.Add(Me.Panel3)
        Me.MainTab.Controls.Add(Me.Label5)
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Size = New System.Drawing.Size(407, 349)
        Me.MainTab.TabIndex = 2
        Me.MainTab.Text = "Class Levels"
        '
        'FirstHDBonusLabel
        '
        Me.FirstHDBonusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.FirstHDBonusLabel.Location = New System.Drawing.Point(265, 45)
        Me.FirstHDBonusLabel.Name = "FirstHDBonusLabel"
        Me.FirstHDBonusLabel.Size = New System.Drawing.Size(80, 21)
        Me.FirstHDBonusLabel.TabIndex = 140
        Me.FirstHDBonusLabel.Text = "First HD Bonus"
        Me.FirstHDBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FirstHDBonusLabel.Visible = False
        '
        'LevelOffsetLabel
        '
        Me.LevelOffsetLabel.BackColor = System.Drawing.SystemColors.Control
        Me.LevelOffsetLabel.Location = New System.Drawing.Point(265, 15)
        Me.LevelOffsetLabel.Name = "LevelOffsetLabel"
        Me.LevelOffsetLabel.Size = New System.Drawing.Size(80, 21)
        Me.LevelOffsetLabel.TabIndex = 139
        Me.LevelOffsetLabel.Text = "Starting HD"
        Me.LevelOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LevelOffsetLabel.Visible = False
        '
        'FirstHDBonus
        '
        Me.FirstHDBonus.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.FirstHDBonus.Location = New System.Drawing.Point(350, 45)
        Me.FirstHDBonus.Name = "FirstHDBonus"
        Me.FirstHDBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.FirstHDBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FirstHDBonus.Properties.AutoHeight = False
        Me.FirstHDBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FirstHDBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FirstHDBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FirstHDBonus.Properties.IsFloatValue = False
        Me.FirstHDBonus.Properties.Mask.BeepOnError = True
        Me.FirstHDBonus.Properties.Mask.EditMask = "d"
        Me.FirstHDBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.FirstHDBonus.Properties.Mask.ShowPlaceHolders = False
        Me.FirstHDBonus.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.FirstHDBonus.Size = New System.Drawing.Size(50, 21)
        Me.FirstHDBonus.TabIndex = 138
        Me.FirstHDBonus.Visible = False
        '
        'LevelOffset
        '
        Me.LevelOffset.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LevelOffset.Location = New System.Drawing.Point(350, 15)
        Me.LevelOffset.Name = "LevelOffset"
        Me.LevelOffset.Properties.Appearance.Options.UseTextOptions = True
        Me.LevelOffset.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LevelOffset.Properties.AutoHeight = False
        Me.LevelOffset.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LevelOffset.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LevelOffset.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LevelOffset.Properties.IsFloatValue = False
        Me.LevelOffset.Properties.Mask.BeepOnError = True
        Me.LevelOffset.Properties.Mask.EditMask = "d"
        Me.LevelOffset.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.LevelOffset.Properties.Mask.ShowPlaceHolders = False
        Me.LevelOffset.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.LevelOffset.Size = New System.Drawing.Size(50, 21)
        Me.LevelOffset.TabIndex = 137
        Me.LevelOffset.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Levels10)
        Me.Panel5.Controls.Add(Me.Levels5)
        Me.Panel5.Controls.Add(Me.Levels20)
        Me.Panel5.Location = New System.Drawing.Point(15, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(165, 35)
        Me.Panel5.TabIndex = 136
        '
        'Levels10
        '
        Me.Levels10.Location = New System.Drawing.Point(50, 0)
        Me.Levels10.Name = "Levels10"
        Me.Levels10.Size = New System.Drawing.Size(45, 24)
        Me.Levels10.TabIndex = 129
        Me.Levels10.Text = "10"
        '
        'Levels5
        '
        Me.Levels5.Location = New System.Drawing.Point(95, 0)
        Me.Levels5.Name = "Levels5"
        Me.Levels5.Size = New System.Drawing.Size(45, 24)
        Me.Levels5.TabIndex = 129
        Me.Levels5.Text = "5"
        '
        'Levels20
        '
        Me.Levels20.Checked = True
        Me.Levels20.Location = New System.Drawing.Point(5, 0)
        Me.Levels20.Name = "Levels20"
        Me.Levels20.Size = New System.Drawing.Size(45, 24)
        Me.Levels20.TabIndex = 129
        Me.Levels20.TabStop = True
        Me.Levels20.Text = "20"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BABHigh)
        Me.Panel4.Controls.Add(Me.BABLow)
        Me.Panel4.Location = New System.Drawing.Point(15, 105)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 85)
        Me.Panel4.TabIndex = 135
        '
        'BABHigh
        '
        Me.BABHigh.Checked = True
        Me.BABHigh.Location = New System.Drawing.Point(5, 0)
        Me.BABHigh.Name = "BABHigh"
        Me.BABHigh.Size = New System.Drawing.Size(140, 24)
        Me.BABHigh.TabIndex = 129
        Me.BABHigh.TabStop = True
        Me.BABHigh.Text = "High: +1,+2,+3,+4,+5"
        '
        'BABLow
        '
        Me.BABLow.Location = New System.Drawing.Point(5, 60)
        Me.BABLow.Name = "BABLow"
        Me.BABLow.Size = New System.Drawing.Size(155, 24)
        Me.BABLow.TabIndex = 131
        Me.BABLow.Text = "Low: +0,+1,+1,+2,+2"
        '
        'BABMedium
        '
        Me.BABMedium.Location = New System.Drawing.Point(5, 30)
        Me.BABMedium.Name = "BABMedium"
        Me.BABMedium.Size = New System.Drawing.Size(155, 24)
        Me.BABMedium.TabIndex = 129
        Me.BABMedium.Text = "Medium: +0,+1,+2,+3,+3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(165, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Reflex"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ReflexHigh)
        Me.Panel2.Controls.Add(Me.ReflexLow)
        Me.Panel2.Location = New System.Drawing.Point(165, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(65, 55)
        Me.Panel2.TabIndex = 133
        '
        'ReflexHigh
        '
        Me.ReflexHigh.Checked = True
        Me.ReflexHigh.Location = New System.Drawing.Point(5, 0)
        Me.ReflexHigh.Name = "ReflexHigh"
        Me.ReflexHigh.Size = New System.Drawing.Size(55, 24)
        Me.ReflexHigh.TabIndex = 131
        Me.ReflexHigh.TabStop = True
        Me.ReflexHigh.Text = "High"
        '
        'ReflexLow
        '
        Me.ReflexLow.Location = New System.Drawing.Point(5, 30)
        Me.ReflexLow.Name = "ReflexLow"
        Me.ReflexLow.Size = New System.Drawing.Size(55, 24)
        Me.ReflexLow.TabIndex = 130
        Me.ReflexLow.Text = "Low"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FortitudeHigh)
        Me.Panel1.Controls.Add(Me.FortitudeLow)
        Me.Panel1.Location = New System.Drawing.Point(15, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 55)
        Me.Panel1.TabIndex = 132
        '
        'FortitudeHigh
        '
        Me.FortitudeHigh.Checked = True
        Me.FortitudeHigh.Location = New System.Drawing.Point(5, 0)
        Me.FortitudeHigh.Name = "FortitudeHigh"
        Me.FortitudeHigh.Size = New System.Drawing.Size(140, 24)
        Me.FortitudeHigh.TabIndex = 129
        Me.FortitudeHigh.TabStop = True
        Me.FortitudeHigh.Text = "High: +2,+3,+3,+4,+4"
        '
        'FortitudeLow
        '
        Me.FortitudeLow.Location = New System.Drawing.Point(5, 30)
        Me.FortitudeLow.Name = "FortitudeLow"
        Me.FortitudeLow.Size = New System.Drawing.Size(155, 24)
        Me.FortitudeLow.TabIndex = 129
        Me.FortitudeLow.Text = "Low: +0,+0,+1,+1,+1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 21)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Base Attack Progression"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "How many levels do you wish to add?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Fortitude"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.WillHigh)
        Me.Panel3.Controls.Add(Me.WillLow)
        Me.Panel3.Location = New System.Drawing.Point(245, 230)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(65, 55)
        Me.Panel3.TabIndex = 133
        '
        'WillHigh
        '
        Me.WillHigh.Checked = True
        Me.WillHigh.Location = New System.Drawing.Point(5, 0)
        Me.WillHigh.Name = "WillHigh"
        Me.WillHigh.Size = New System.Drawing.Size(55, 24)
        Me.WillHigh.TabIndex = 131
        Me.WillHigh.TabStop = True
        Me.WillHigh.Text = "High"
        '
        'WillLow
        '
        Me.WillLow.Location = New System.Drawing.Point(5, 30)
        Me.WillLow.Name = "WillLow"
        Me.WillLow.Size = New System.Drawing.Size(55, 24)
        Me.WillLow.TabIndex = 130
        Me.WillLow.Text = "Low"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(245, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Will "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'CreateClassLevelsForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateClassLevelsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Class Levels"
        Me.TabControl1.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        CType(Me.FirstHDBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'enumeration
    Private Enum HighMediumLow
        Low
        Medium
        High
    End Enum

    'member vars
    Private _ClassLevelsFolder As Objects.ObjectData
    Private HitDiceMode As Boolean = False

    'init
    Public Sub Init(ByVal ClassLevelsFolder As Objects.ObjectData)
        Try
            _ClassLevelsFolder = ClassLevelsFolder

            If _ClassLevelsFolder.ObjectGUID.Database = XML.DBTypes.MonsterClasses Then
                Select Case _ClassLevelsFolder.Parent.Element("ClassType")
                    Case "Animal Companion", "Special Mount"
                        HitDiceMode = True

                        LevelOffset.Visible = True
                        LevelOffsetLabel.Visible = True

                        FirstHDBonus.Visible = True
                        FirstHDBonusLabel.Visible = True
                End Select
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            General.MainExplorer.Undo.UndoRecord()

            'get no of levels to add
            Dim NoOfLevels As Integer

            If Levels20.Checked Then
                NoOfLevels = 20
            ElseIf Levels10.Checked Then
                NoOfLevels = 10
            Else
                NoOfLevels = 5
            End If

            'bab
            Dim BAB As HighMediumLow

            If BABHigh.Checked Then
                BAB = HighMediumLow.High
            ElseIf BABMedium.Checked Then
                BAB = HighMediumLow.Medium
            Else
                BAB = HighMediumLow.Low
            End If

            'fortitude
            Dim Fortitude As HighMediumLow

            If FortitudeHigh.Checked Then
                Fortitude = HighMediumLow.High
            Else
                Fortitude = HighMediumLow.Low
            End If

            'reflex
            Dim Reflex As HighMediumLow

            If ReflexHigh.Checked Then
                Reflex = HighMediumLow.High
            Else
                Reflex = HighMediumLow.Low
            End If

            'will
            Dim Will As HighMediumLow

            If WillHigh.Checked Then
                Will = HighMediumLow.High
            Else
                Will = HighMediumLow.Low
            End If

            'set flags for spells per day/spells known
            Dim spd, sk, psionic As Boolean
            Dim ClassObj As Objects.ObjectData = Me._ClassLevelsFolder.Parent
            spd = Rules.CharacterClass.SPD(ClassObj)
            sk = Rules.CharacterClass.SK(ClassObj)
            psionic = Rules.CharacterClass.Psionic(ClassObj)

            'create the levels
            Dim Obj As New Objects.ObjectData

            Dim StartingLevelOffset As Integer = CInt(LevelOffset.Value)
            Dim FirstHDLevel As Integer = CInt(FirstHDBonus.Value)
            Dim RealLevel, LastRealLevel As Integer

            For Level As Integer = 1 To NoOfLevels

                Obj.Name = "Level " & Level.ToString
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(_ClassLevelsFolder.ObjectGUID.Database)

                Select Case _ClassLevelsFolder.Type
                    Case Objects.ClassLevelsFolderType
                        Obj.Type = Objects.ClassLevelType
                    Case Objects.MonsterClassLevelsFolderType
                        Obj.Type = Objects.MonsterClassLevelType
                End Select

                Obj.ParentGUID = _ClassLevelsFolder.ObjectGUID
                Obj.Element("Level") = Level.ToString

                If HitDiceMode Then

                    'temp code for mounts and companions
                    Dim HitDiceBonus As Integer = Level - FirstHDLevel
                    Select Case HitDiceBonus
                        Case Is < 0
                            HitDiceBonus = 0
                        Case 0
                            HitDiceBonus = 2
                        Case Else
                            'for every 3 bigger it is its an extra 2 hit dice
                            Dim WholePart As Integer = HitDiceBonus \ 3
                            HitDiceBonus = 2 + (WholePart * 2)
                    End Select

                    LastRealLevel = RealLevel
                    RealLevel = HitDiceBonus + StartingLevelOffset

                    If (Level - FirstHDLevel) Mod 3 = 0 Then
                        If Level >= FirstHDLevel Then
                            Obj.Element("HitDice") = "+2"
                        End If
                    End If

                    'bab
                    Select Case BAB
                        Case HighMediumLow.High
                            Obj.Element("BaseAttackBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(RealLevel) - Math.Floor(LastRealLevel), Integer))
                        Case HighMediumLow.Medium
                            Obj.Element("BaseAttackBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(RealLevel * 0.75) - Math.Floor((LastRealLevel) * 0.75), Integer))
                        Case HighMediumLow.Low
                            Obj.Element("BaseAttackBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(RealLevel * 0.5) - Math.Floor((LastRealLevel) * 0.5), Integer))
                    End Select

                    'fortitude
                    Select Case Fortitude
                        Case HighMediumLow.High
                            Dim Savef As Integer = CType(Math.Floor(RealLevel * 0.5) - Math.Floor((LastRealLevel) * 0.5), Integer)
                            If Level = 1 Then Savef += 2
                            Obj.Element("FortitudeSaveBonus") = Rules.Formatting.FormatModifier(Savef)
                        Case HighMediumLow.Low
                            Obj.Element("FortitudeSaveBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(RealLevel * 0.34) - Math.Floor((LastRealLevel) * 0.34), Integer))
                    End Select

                    'reflex
                    Select Case Fortitude
                        Case HighMediumLow.High
                            Dim Saver As Integer = CType(Math.Floor(RealLevel * 0.5) - Math.Floor((LastRealLevel) * 0.5), Integer)
                            If Level = 1 Then Saver += 2
                            Obj.Element("ReflexSaveBonus") = Rules.Formatting.FormatModifier(Saver)
                        Case HighMediumLow.Low
                            Obj.Element("ReflexSaveBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(RealLevel * 0.34) - Math.Floor((LastRealLevel) * 0.34), Integer))
                    End Select

                    'will
                    Select Case Will
                        Case HighMediumLow.High
                            Dim Savew As Integer = CType(Math.Floor(RealLevel * 0.5) - Math.Floor((LastRealLevel) * 0.5), Integer)
                            If Level = 1 Then Savew += 2
                            Obj.Element("WillSaveBonus") = Rules.Formatting.FormatModifier(Savew)
                        Case HighMediumLow.Low
                            Obj.Element("WillSaveBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(RealLevel * 0.34) - Math.Floor((LastRealLevel) * 0.34), Integer))
                    End Select

                Else

                    'bab
                    Select Case BAB
                        Case HighMediumLow.High
                            Obj.Element("BaseAttackBonus") = Rules.Formatting.FormatModifier(1)
                        Case HighMediumLow.Medium
                            Obj.Element("BaseAttackBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(Level * 0.75) - Math.Floor((Level - 1) * 0.75), Integer))
                        Case HighMediumLow.Low
                            Obj.Element("BaseAttackBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(Level * 0.5) - Math.Floor((Level - 1) * 0.5), Integer))
                    End Select

                    'fortitude
                    Select Case Fortitude
                        Case HighMediumLow.High
                            Dim Save As Integer = CType(Math.Floor(Level * 0.5) - Math.Floor((Level - 1) * 0.5), Integer)
                            If Level = 1 Then Save += 2
                            Obj.Element("FortitudeSaveBonus") = Rules.Formatting.FormatModifier(Save)
                        Case HighMediumLow.Low
                            Obj.Element("FortitudeSaveBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(Level * 0.34) - Math.Floor((Level - 1) * 0.34), Integer))
                    End Select

                    'reflex
                    Select Case Reflex
                        Case HighMediumLow.High
                            Dim Save As Integer = CType(Math.Floor(Level * 0.5) - Math.Floor((Level - 1) * 0.5), Integer)
                            If Level = 1 Then Save += 2
                            Obj.Element("ReflexSaveBonus") = Rules.Formatting.FormatModifier(Save)
                        Case HighMediumLow.Low
                            Obj.Element("ReflexSaveBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(Level * 0.34) - Math.Floor((Level - 1) * 0.34), Integer))
                    End Select

                    'will
                    Select Case Will
                        Case HighMediumLow.High
                            Dim Save As Integer = CType(Math.Floor(Level * 0.5) - Math.Floor((Level - 1) * 0.5), Integer)
                            If Level = 1 Then Save += 2
                            Obj.Element("WillSaveBonus") = Rules.Formatting.FormatModifier(Save)
                        Case HighMediumLow.Low
                            Obj.Element("WillSaveBonus") = Rules.Formatting.FormatModifier(CType(Math.Floor(Level * 0.34) - Math.Floor((Level - 1) * 0.34), Integer))
                    End Select

                End If

                Obj.Save()
                Obj.Clear()

                'spells per day
                If spd Then
                    Rules.CharacterClass.CreateSpellsPerDay(ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsPerDayFolderType).ObjectGUID, Level)
                End If

                'spells known
                If sk Then
                    Rules.CharacterClass.CreateSpellsKnown(ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsKnownFolderType).ObjectGUID, Level)
                End If

                'psionic powers
                If psionic Then
                    Rules.CharacterClass.CreatePowerProgression(ClassObj.FirstChildOfType(Objects.ClassLevelsPowerProgressionFolderType).ObjectGUID, Level)
                End If
            Next

            'save, refresh explorer and close
            CommonLogic.UpdateCumulativeModifiers(_ClassLevelsFolder)
            WindowManager.SetDirty(_ClassLevelsFolder)

            'General.MainExplorer.Refresh()
            'readd the levels folder
            General.MainExplorer.TreeView.BeginUpdate()

            Dim LevelsFolderNode As TreeNode = CType(General.MainExplorer.TreeNodes(_ClassLevelsFolder.ObjectGUID), TreeNode)
            If Not LevelsFolderNode Is Nothing Then LevelsFolderNode.Remove()

            Dim ClassNode As TreeNode = CType(General.MainExplorer.TreeNodes(_ClassLevelsFolder.ParentGUID), TreeNode)
            Dim NewNode As TreeNode = General.MainExplorer.CompleteNodeFromObject(_ClassLevelsFolder)
            General.MainExplorer.InsertNode(ClassNode, NewNode)

            General.MainExplorer.TreeView.EndUpdate()

            Me.DialogResult = DialogResult.OK : Me.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
    End Sub

End Class


