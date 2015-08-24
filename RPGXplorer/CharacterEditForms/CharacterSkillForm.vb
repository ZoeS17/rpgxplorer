Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CharacterSkillForm
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
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Ranks As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SkillLabel As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents InfoLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.SkillLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.InfoLabel = New System.Windows.Forms.Label
        Me.Ranks = New DevExpress.XtraEditors.SpinEdit
        CType(Me.Ranks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(140, 125)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 288
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(220, 125)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 289
        Me.Cancel.Text = "Cancel"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(275, 5)
        Me.IndentedLine2.TabIndex = 290
        Me.IndentedLine2.TabStop = False
        '
        'SkillLabel
        '
        Me.SkillLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkillLabel.Location = New System.Drawing.Point(15, 15)
        Me.SkillLabel.Name = "SkillLabel"
        Me.SkillLabel.Size = New System.Drawing.Size(275, 21)
        Me.SkillLabel.TabIndex = 294
        Me.SkillLabel.Text = "Skill Name"
        Me.SkillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 295
        Me.Label1.Text = "Ranks"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InfoLabel
        '
        Me.InfoLabel.Location = New System.Drawing.Point(15, 75)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(275, 21)
        Me.InfoLabel.TabIndex = 296
        Me.InfoLabel.Text = "Info"
        Me.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ranks
        '
        Me.Ranks.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ranks.Location = New System.Drawing.Point(70, 45)
        Me.Ranks.Name = "Ranks"
        '
        'Ranks.Properties
        '
        Me.Ranks.Properties.Appearance.Options.UseTextOptions = True
        Me.Ranks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ranks.Properties.AutoHeight = False
        Me.Ranks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Ranks.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Ranks.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Ranks.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ranks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Ranks.Size = New System.Drawing.Size(60, 21)
        Me.Ranks.TabIndex = 292
        '
        'CharacterSkillForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 163)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SkillLabel)
        Me.Controls.Add(Me.Ranks)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterSkillForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CharacterSkillForm"
        CType(Me.Ranks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Vairables"

    Private Character As Rules.Character
    Private SkillObject As Objects.ObjectData
    Private MaxRanks As Double
    Private MaxClassRanks As Integer
    Private MaxCrossClassRanks As Double
    Private CurrentRanks As Double

#End Region

    'init for editing a character skill
    Public Function Init(ByVal SkillPointsSpent As Objects.ObjectData) As Boolean
        Try
            'init vars
            SkillObject = SkillPointsSpent

            'get the character - get the character from the panel (in case locked window)
            Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey).Clone

            'check to see if this is a 0th level character
            If Character.CharacterLevel = 0 Then Return False

            'init form
            Me.Text = "Edit Skill Ranks"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Me.SkillLabel.Text = SkillPointsSpent.Element("Skill")

            'find max total
            MaxClassRanks = Rules.ExperienceAndLevelling.LevelDependentBenefits(Character.CharacterLevel).ClassSkillMaxRanks
            MaxCrossClassRanks = Rules.ExperienceAndLevelling.LevelDependentBenefits(Character.CharacterLevel).CrossClassSkillMaxRanks

            'set up the rank spin edit
            Ranks.Properties.Increment = 0.5D
            If Character.Skills.IsClassSkillAtLevel(SkillObject.GetFKGuid("Skill"), Character.CharacterLevel) Then
                MaxRanks = MaxClassRanks
                InfoLabel.Text = "Class Skill"
            Else
                MaxRanks = MaxCrossClassRanks
                InfoLabel.Text = "Cross-Class Skill"
            End If

            'get current total
            CurrentRanks = SkillObject.ElementAsNumber("Rank")

            'set limits
            Ranks.Properties.MinValue = 0
            'Ranks.Properties.MaxValue = CType(Math.Max(MaxRanks, CurrentRanks), Decimal)
            Ranks.Properties.MaxValue = 999
            Ranks.EditValue = CurrentRanks

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'ok
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            General.MainExplorer.Undo.UndoRecord()

            Dim RanksThisLevel As Double = SkillObject.ElementAsNumber("Level" & Character.CharacterLevel.ToString)
            Dim Change As Double = Ranks.Value - CurrentRanks

            'update the object
            SkillObject.Element("Level" & Character.CharacterLevel.ToString) = (RanksThisLevel + Change).ToString
            SkillObject.Element("Rank") = Ranks.Value.ToString

            'update the cached character
            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload, True)

            General.MainExplorer.RefreshPanel()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class