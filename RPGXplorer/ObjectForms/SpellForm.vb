Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class SpellForm
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
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents SpellTab As System.Windows.Forms.TabPage
    Public WithEvents XP As System.Windows.Forms.CheckBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents SubschoolDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DivineFocusCheck As System.Windows.Forms.CheckBox
    Public WithEvents FocusCheck As System.Windows.Forms.CheckBox
    Public WithEvents MaterialCheck As System.Windows.Forms.CheckBox
    Public WithEvents SomaticCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents VerbalCheck As System.Windows.Forms.CheckBox
    Public WithEvents PotionCheck As System.Windows.Forms.CheckBox
    Public WithEvents SchoolDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Levels As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents LevelListBox As RPGXplorer.ListBox
    Public WithEvents SpellLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents RemoveLevel As System.Windows.Forms.Button
    Public WithEvents AddLevel As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents DescriptorsTab As System.Windows.Forms.TabPage
    Public WithEvents Descriptors As RPGXplorer.ListBox
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents RemoveDescriptor As System.Windows.Forms.Button
    Public WithEvents AddDescriptor As System.Windows.Forms.Button
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents DescriptorDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents AddDiscriptor As System.Windows.Forms.TabControl
    Public WithEvents Spell2Tab As System.Windows.Forms.TabPage
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Range As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents CastingTime As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents TargetAreaEffect As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Duration As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents SavingThrow As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents SpellResistance As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ComponentCost As DevExpress.XtraEditors.SpinEdit
    Public WithEvents XPCost As DevExpress.XtraEditors.SpinEdit
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents CostLabel As System.Windows.Forms.Label
    Public WithEvents VariableCost As System.Windows.Forms.CheckBox
    Public WithEvents VariableXP As System.Windows.Forms.CheckBox
    Public WithEvents TypeLabel As System.Windows.Forms.Label
    Public WithEvents LevelDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents LevelsString As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents AutoFormat As System.Windows.Forms.Button
    Public WithEvents OtherCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine6 As RPGXplorer.IndentedLine
    Public WithEvents OtherText As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.SpellTab = New System.Windows.Forms.TabPage
        Me.IndentedLine6 = New RPGXplorer.IndentedLine
        Me.OtherText = New DevExpress.XtraEditors.TextEdit
        Me.OtherCheck = New System.Windows.Forms.CheckBox
        Me.VariableXP = New System.Windows.Forms.CheckBox
        Me.VariableCost = New System.Windows.Forms.CheckBox
        Me.ComponentCost = New DevExpress.XtraEditors.SpinEdit
        Me.XPCost = New DevExpress.XtraEditors.SpinEdit
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.XP = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SubschoolDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DivineFocusCheck = New System.Windows.Forms.CheckBox
        Me.FocusCheck = New System.Windows.Forms.CheckBox
        Me.MaterialCheck = New System.Windows.Forms.CheckBox
        Me.SomaticCheck = New System.Windows.Forms.CheckBox
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.VerbalCheck = New System.Windows.Forms.CheckBox
        Me.PotionCheck = New System.Windows.Forms.CheckBox
        Me.SchoolDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Levels = New System.Windows.Forms.TabPage
        Me.AutoFormat = New System.Windows.Forms.Button
        Me.LevelsString = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.TypeLabel = New System.Windows.Forms.Label
        Me.LevelDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.LevelListBox = New RPGXplorer.ListBox
        Me.SpellLevel = New DevExpress.XtraEditors.SpinEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.RemoveLevel = New System.Windows.Forms.Button
        Me.AddLevel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DescriptorsTab = New System.Windows.Forms.TabPage
        Me.Descriptors = New RPGXplorer.ListBox
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.RemoveDescriptor = New System.Windows.Forms.Button
        Me.AddDescriptor = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.DescriptorDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.AddDiscriptor = New System.Windows.Forms.TabControl
        Me.Spell2Tab = New System.Windows.Forms.TabPage
        Me.Label14 = New System.Windows.Forms.Label
        Me.SpellResistance = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.SavingThrow = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Duration = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Range = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CastingTime = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.TargetAreaEffect = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.SpellTab.SuspendLayout()
        CType(Me.OtherText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubschoolDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Levels.SuspendLayout()
        CType(Me.LevelsString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpellLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescriptorsTab.SuspendLayout()
        CType(Me.DescriptorDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.AddDiscriptor.SuspendLayout()
        Me.Spell2Tab.SuspendLayout()
        CType(Me.SpellResistance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavingThrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Duration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Range.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CastingTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetAreaEffect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 465)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 465)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'SpellTab
        '
        Me.SpellTab.Controls.Add(Me.IndentedLine6)
        Me.SpellTab.Controls.Add(Me.OtherText)
        Me.SpellTab.Controls.Add(Me.OtherCheck)
        Me.SpellTab.Controls.Add(Me.VariableXP)
        Me.SpellTab.Controls.Add(Me.VariableCost)
        Me.SpellTab.Controls.Add(Me.ComponentCost)
        Me.SpellTab.Controls.Add(Me.XPCost)
        Me.SpellTab.Controls.Add(Me.WeightLabel)
        Me.SpellTab.Controls.Add(Me.CostLabel)
        Me.SpellTab.Controls.Add(Me.XP)
        Me.SpellTab.Controls.Add(Me.Label5)
        Me.SpellTab.Controls.Add(Me.SubschoolDropdown)
        Me.SpellTab.Controls.Add(Me.DivineFocusCheck)
        Me.SpellTab.Controls.Add(Me.FocusCheck)
        Me.SpellTab.Controls.Add(Me.MaterialCheck)
        Me.SpellTab.Controls.Add(Me.SomaticCheck)
        Me.SpellTab.Controls.Add(Me.IndentedLine2)
        Me.SpellTab.Controls.Add(Me.VerbalCheck)
        Me.SpellTab.Controls.Add(Me.PotionCheck)
        Me.SpellTab.Controls.Add(Me.SchoolDropdown)
        Me.SpellTab.Controls.Add(Me.Label1)
        Me.SpellTab.Controls.Add(Me.IndentedLine1)
        Me.SpellTab.Controls.Add(Me.Description)
        Me.SpellTab.Controls.Add(Me.Label3)
        Me.SpellTab.Controls.Add(Me.ObjectName)
        Me.SpellTab.Controls.Add(Me.Label2)
        Me.SpellTab.Location = New System.Drawing.Point(4, 22)
        Me.SpellTab.Name = "SpellTab"
        Me.SpellTab.Size = New System.Drawing.Size(407, 409)
        Me.SpellTab.TabIndex = 3
        Me.SpellTab.Text = "Spell"
        '
        'IndentedLine6
        '
        Me.IndentedLine6.CausesValidation = False
        Me.IndentedLine6.Location = New System.Drawing.Point(16, 295)
        Me.IndentedLine6.Name = "IndentedLine6"
        Me.IndentedLine6.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine6.TabIndex = 187
        Me.IndentedLine6.TabStop = False
        '
        'OtherText
        '
        Me.OtherText.Enabled = False
        Me.OtherText.Location = New System.Drawing.Point(135, 260)
        Me.OtherText.Name = "OtherText"
        '
        'OtherText.Properties
        '
        Me.OtherText.Properties.AutoHeight = False
        Me.OtherText.Properties.MaxLength = 100
        Me.OtherText.Size = New System.Drawing.Size(200, 21)
        Me.OtherText.TabIndex = 11
        '
        'OtherCheck
        '
        Me.OtherCheck.CausesValidation = False
        Me.Errors.SetIconPadding(Me.OtherCheck, -3)
        Me.OtherCheck.Location = New System.Drawing.Point(15, 260)
        Me.OtherCheck.Name = "OtherCheck"
        Me.OtherCheck.Size = New System.Drawing.Size(115, 21)
        Me.OtherCheck.TabIndex = 10
        Me.OtherCheck.Text = "Other Component"
        '
        'VariableXP
        '
        Me.VariableXP.CausesValidation = False
        Me.VariableXP.Enabled = False
        Me.VariableXP.Location = New System.Drawing.Point(210, 340)
        Me.VariableXP.Name = "VariableXP"
        Me.VariableXP.Size = New System.Drawing.Size(125, 21)
        Me.VariableXP.TabIndex = 15
        Me.VariableXP.Text = "Varies (see Rules)"
        '
        'VariableCost
        '
        Me.VariableCost.CausesValidation = False
        Me.VariableCost.Enabled = False
        Me.VariableCost.Location = New System.Drawing.Point(210, 310)
        Me.VariableCost.Name = "VariableCost"
        Me.VariableCost.Size = New System.Drawing.Size(125, 21)
        Me.VariableCost.TabIndex = 13
        Me.VariableCost.Text = "Varies (see Rules)"
        '
        'ComponentCost
        '
        Me.ComponentCost.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ComponentCost.Enabled = False
        Me.ComponentCost.Location = New System.Drawing.Point(110, 310)
        Me.ComponentCost.Name = "ComponentCost"
        '
        'ComponentCost.Properties
        '
        Me.ComponentCost.Properties.Appearance.Options.UseTextOptions = True
        Me.ComponentCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ComponentCost.Properties.AutoHeight = False
        Me.ComponentCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ComponentCost.Properties.Mask.BeepOnError = True
        Me.ComponentCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ComponentCost.Properties.Mask.ShowPlaceHolders = False
        Me.ComponentCost.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.ComponentCost.Size = New System.Drawing.Size(85, 21)
        Me.ComponentCost.TabIndex = 12
        '
        'XPCost
        '
        Me.XPCost.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.XPCost.Enabled = False
        Me.Errors.SetIconPadding(Me.XPCost, 130)
        Me.XPCost.Location = New System.Drawing.Point(110, 340)
        Me.XPCost.Name = "XPCost"
        '
        'XPCost.Properties
        '
        Me.XPCost.Properties.Appearance.Options.UseTextOptions = True
        Me.XPCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XPCost.Properties.AutoHeight = False
        Me.XPCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.XPCost.Properties.Mask.BeepOnError = True
        Me.XPCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.XPCost.Properties.Mask.ShowPlaceHolders = False
        Me.XPCost.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.XPCost.Size = New System.Drawing.Size(85, 21)
        Me.XPCost.TabIndex = 14
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 340)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(55, 21)
        Me.WeightLabel.TabIndex = 184
        Me.WeightLabel.Text = "XP Cost"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostLabel
        '
        Me.CostLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CostLabel.Location = New System.Drawing.Point(15, 310)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(90, 21)
        Me.CostLabel.TabIndex = 183
        Me.CostLabel.Text = "Component Cost"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'XP
        '
        Me.XP.CausesValidation = False
        Me.XP.Location = New System.Drawing.Point(265, 230)
        Me.XP.Name = "XP"
        Me.XP.Size = New System.Drawing.Size(55, 21)
        Me.XP.TabIndex = 9
        Me.XP.Text = "XP"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.CausesValidation = False
        Me.Label5.Location = New System.Drawing.Point(15, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Subschool"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubschoolDropdown
        '
        Me.SubschoolDropdown.CausesValidation = False
        Me.SubschoolDropdown.EditValue = ""
        Me.SubschoolDropdown.Location = New System.Drawing.Point(85, 150)
        Me.SubschoolDropdown.Name = "SubschoolDropdown"
        '
        'SubschoolDropdown.Properties
        '
        Me.SubschoolDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubschoolDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SubschoolDropdown.Size = New System.Drawing.Size(150, 20)
        Me.SubschoolDropdown.TabIndex = 3
        '
        'DivineFocusCheck
        '
        Me.DivineFocusCheck.CausesValidation = False
        Me.DivineFocusCheck.Location = New System.Drawing.Point(135, 230)
        Me.DivineFocusCheck.Name = "DivineFocusCheck"
        Me.DivineFocusCheck.Size = New System.Drawing.Size(115, 21)
        Me.DivineFocusCheck.TabIndex = 8
        Me.DivineFocusCheck.Text = "Divine Focus (DF)"
        '
        'FocusCheck
        '
        Me.FocusCheck.CausesValidation = False
        Me.FocusCheck.Location = New System.Drawing.Point(15, 230)
        Me.FocusCheck.Name = "FocusCheck"
        Me.FocusCheck.Size = New System.Drawing.Size(104, 21)
        Me.FocusCheck.TabIndex = 7
        Me.FocusCheck.Text = "Focus (F)"
        '
        'MaterialCheck
        '
        Me.MaterialCheck.CausesValidation = False
        Me.Errors.SetIconPadding(Me.MaterialCheck, -3)
        Me.MaterialCheck.Location = New System.Drawing.Point(265, 200)
        Me.MaterialCheck.Name = "MaterialCheck"
        Me.MaterialCheck.Size = New System.Drawing.Size(85, 21)
        Me.MaterialCheck.TabIndex = 6
        Me.MaterialCheck.Text = "Material (M)"
        '
        'SomaticCheck
        '
        Me.SomaticCheck.CausesValidation = False
        Me.SomaticCheck.Location = New System.Drawing.Point(135, 200)
        Me.SomaticCheck.Name = "SomaticCheck"
        Me.SomaticCheck.Size = New System.Drawing.Size(85, 21)
        Me.SomaticCheck.TabIndex = 5
        Me.SomaticCheck.Text = "Somatic (S)"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 185)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 136
        Me.IndentedLine2.TabStop = False
        '
        'VerbalCheck
        '
        Me.VerbalCheck.CausesValidation = False
        Me.VerbalCheck.Location = New System.Drawing.Point(15, 200)
        Me.VerbalCheck.Name = "VerbalCheck"
        Me.VerbalCheck.Size = New System.Drawing.Size(75, 21)
        Me.VerbalCheck.TabIndex = 4
        Me.VerbalCheck.Text = "Verbal (V)"
        '
        'PotionCheck
        '
        Me.PotionCheck.CausesValidation = False
        Me.PotionCheck.Location = New System.Drawing.Point(15, 375)
        Me.PotionCheck.Name = "PotionCheck"
        Me.PotionCheck.Size = New System.Drawing.Size(214, 21)
        Me.PotionCheck.TabIndex = 16
        Me.PotionCheck.Text = "Effect can be stored in a potion or oil"
        '
        'SchoolDropdown
        '
        Me.SchoolDropdown.EditValue = ""
        Me.SchoolDropdown.Location = New System.Drawing.Point(85, 120)
        Me.SchoolDropdown.Name = "SchoolDropdown"
        '
        'SchoolDropdown.Properties
        '
        Me.SchoolDropdown.Properties.AutoHeight = False
        Me.SchoolDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SchoolDropdown.Properties.DropDownRows = 10
        Me.SchoolDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SchoolDropdown.Size = New System.Drawing.Size(150, 21)
        Me.SchoolDropdown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "School"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 127
        Me.IndentedLine1.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(305, 46)
        Me.Description.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(85, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(150, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Levels
        '
        Me.Levels.Controls.Add(Me.AutoFormat)
        Me.Levels.Controls.Add(Me.LevelsString)
        Me.Levels.Controls.Add(Me.Label7)
        Me.Levels.Controls.Add(Me.IndentedLine5)
        Me.Levels.Controls.Add(Me.TypeLabel)
        Me.Levels.Controls.Add(Me.LevelDropdown)
        Me.Levels.Controls.Add(Me.IndentedLine3)
        Me.Levels.Controls.Add(Me.LevelListBox)
        Me.Levels.Controls.Add(Me.SpellLevel)
        Me.Levels.Controls.Add(Me.Label6)
        Me.Levels.Controls.Add(Me.RemoveLevel)
        Me.Levels.Controls.Add(Me.AddLevel)
        Me.Levels.Controls.Add(Me.Label4)
        Me.Levels.Controls.Add(Me.TypeDropdown)
        Me.Levels.Location = New System.Drawing.Point(4, 22)
        Me.Levels.Name = "Levels"
        Me.Levels.Size = New System.Drawing.Size(407, 409)
        Me.Levels.TabIndex = 4
        Me.Levels.Text = "Levels"
        '
        'AutoFormat
        '
        Me.AutoFormat.CausesValidation = False
        Me.AutoFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoFormat.Location = New System.Drawing.Point(280, 320)
        Me.AutoFormat.Name = "AutoFormat"
        Me.AutoFormat.Size = New System.Drawing.Size(110, 24)
        Me.AutoFormat.TabIndex = 7
        Me.AutoFormat.Text = "Suggest"
        '
        'LevelsString
        '
        Me.LevelsString.Location = New System.Drawing.Point(60, 320)
        Me.LevelsString.Name = "LevelsString"
        '
        'LevelsString.Properties
        '
        Me.LevelsString.Properties.AutoHeight = False
        Me.LevelsString.Properties.MaxLength = 100
        Me.LevelsString.Size = New System.Drawing.Size(205, 21)
        Me.LevelsString.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.CausesValidation = False
        Me.Label7.Location = New System.Drawing.Point(15, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Levels"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine5
        '
        Me.IndentedLine5.CausesValidation = False
        Me.IndentedLine5.Location = New System.Drawing.Point(16, 305)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 139
        Me.IndentedLine5.TabStop = False
        '
        'TypeLabel
        '
        Me.TypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TypeLabel.CausesValidation = False
        Me.TypeLabel.Location = New System.Drawing.Point(15, 45)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(50, 21)
        Me.TypeLabel.TabIndex = 138
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelDropdown
        '
        Me.LevelDropdown.CausesValidation = False
        Me.LevelDropdown.Location = New System.Drawing.Point(75, 45)
        Me.LevelDropdown.Name = "LevelDropdown"
        '
        'LevelDropdown.Properties
        '
        Me.LevelDropdown.Properties.AutoHeight = False
        Me.LevelDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LevelDropdown.Properties.DropDownRows = 10
        Me.LevelDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.LevelDropdown.Size = New System.Drawing.Size(150, 21)
        Me.LevelDropdown.TabIndex = 1
        '
        'IndentedLine3
        '
        Me.IndentedLine3.CausesValidation = False
        Me.IndentedLine3.Location = New System.Drawing.Point(16, 110)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 136
        Me.IndentedLine3.TabStop = False
        '
        'LevelListBox
        '
        Me.LevelListBox.CausesValidation = False
        Me.LevelListBox.Location = New System.Drawing.Point(15, 125)
        Me.LevelListBox.Name = "LevelListBox"
        Me.LevelListBox.Size = New System.Drawing.Size(250, 165)
        Me.LevelListBox.TabIndex = 5
        '
        'SpellLevel
        '
        Me.SpellLevel.CausesValidation = False
        Me.SpellLevel.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpellLevel.Location = New System.Drawing.Point(75, 75)
        Me.SpellLevel.Name = "SpellLevel"
        '
        'SpellLevel.Properties
        '
        Me.SpellLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.SpellLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpellLevel.Properties.AutoHeight = False
        Me.SpellLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpellLevel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.SpellLevel.Properties.IsFloatValue = False
        Me.SpellLevel.Properties.Mask.EditMask = "N00"
        Me.SpellLevel.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.SpellLevel.Size = New System.Drawing.Size(50, 21)
        Me.SpellLevel.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.CausesValidation = False
        Me.Label6.Location = New System.Drawing.Point(15, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Level"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveLevel
        '
        Me.RemoveLevel.CausesValidation = False
        Me.RemoveLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLevel.Location = New System.Drawing.Point(280, 155)
        Me.RemoveLevel.Name = "RemoveLevel"
        Me.RemoveLevel.Size = New System.Drawing.Size(110, 24)
        Me.RemoveLevel.TabIndex = 4
        Me.RemoveLevel.Text = "Remove Level"
        '
        'AddLevel
        '
        Me.AddLevel.CausesValidation = False
        Me.AddLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLevel.Location = New System.Drawing.Point(280, 125)
        Me.AddLevel.Name = "AddLevel"
        Me.AddLevel.Size = New System.Drawing.Size(110, 24)
        Me.AddLevel.TabIndex = 3
        Me.AddLevel.Text = "Add Level"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TypeDropdown
        '
        Me.TypeDropdown.CausesValidation = False
        Me.TypeDropdown.Location = New System.Drawing.Point(75, 15)
        Me.TypeDropdown.Name = "TypeDropdown"
        '
        'TypeDropdown.Properties
        '
        Me.TypeDropdown.Properties.AutoHeight = False
        Me.TypeDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeDropdown.Properties.DropDownRows = 10
        Me.TypeDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TypeDropdown.Size = New System.Drawing.Size(150, 21)
        Me.TypeDropdown.TabIndex = 0
        '
        'DescriptorsTab
        '
        Me.DescriptorsTab.Controls.Add(Me.Descriptors)
        Me.DescriptorsTab.Controls.Add(Me.IndentedLine4)
        Me.DescriptorsTab.Controls.Add(Me.RemoveDescriptor)
        Me.DescriptorsTab.Controls.Add(Me.AddDescriptor)
        Me.DescriptorsTab.Controls.Add(Me.Label9)
        Me.DescriptorsTab.Controls.Add(Me.DescriptorDropdown)
        Me.DescriptorsTab.Location = New System.Drawing.Point(4, 22)
        Me.DescriptorsTab.Name = "DescriptorsTab"
        Me.DescriptorsTab.Size = New System.Drawing.Size(407, 409)
        Me.DescriptorsTab.TabIndex = 6
        Me.DescriptorsTab.Text = "Descriptors"
        '
        'Descriptors
        '
        Me.Descriptors.CausesValidation = False
        Me.Descriptors.Location = New System.Drawing.Point(15, 65)
        Me.Descriptors.Name = "Descriptors"
        Me.Descriptors.Size = New System.Drawing.Size(250, 270)
        Me.Descriptors.TabIndex = 147
        '
        'IndentedLine4
        '
        Me.IndentedLine4.CausesValidation = False
        Me.IndentedLine4.Location = New System.Drawing.Point(16, 50)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 146
        Me.IndentedLine4.TabStop = False
        '
        'RemoveDescriptor
        '
        Me.RemoveDescriptor.CausesValidation = False
        Me.RemoveDescriptor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveDescriptor.Location = New System.Drawing.Point(280, 95)
        Me.RemoveDescriptor.Name = "RemoveDescriptor"
        Me.RemoveDescriptor.Size = New System.Drawing.Size(110, 24)
        Me.RemoveDescriptor.TabIndex = 141
        Me.RemoveDescriptor.Text = "Remove Descriptor"
        '
        'AddDescriptor
        '
        Me.AddDescriptor.CausesValidation = False
        Me.AddDescriptor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDescriptor.Location = New System.Drawing.Point(280, 65)
        Me.AddDescriptor.Name = "AddDescriptor"
        Me.AddDescriptor.Size = New System.Drawing.Size(110, 24)
        Me.AddDescriptor.TabIndex = 140
        Me.AddDescriptor.Text = "Add Descriptor"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.CausesValidation = False
        Me.Label9.Location = New System.Drawing.Point(15, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Descriptor"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescriptorDropdown
        '
        Me.DescriptorDropdown.CausesValidation = False
        Me.DescriptorDropdown.Location = New System.Drawing.Point(85, 15)
        Me.DescriptorDropdown.Name = "DescriptorDropdown"
        '
        'DescriptorDropdown.Properties
        '
        Me.DescriptorDropdown.Properties.AutoHeight = False
        Me.DescriptorDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DescriptorDropdown.Properties.DropDownRows = 20
        Me.DescriptorDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DescriptorDropdown.Size = New System.Drawing.Size(150, 21)
        Me.DescriptorDropdown.TabIndex = 137
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 409)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 409)
        Me.PropertiesTab.TabIndex = 0
        '
        'AddDiscriptor
        '
        Me.AddDiscriptor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddDiscriptor.Controls.Add(Me.SpellTab)
        Me.AddDiscriptor.Controls.Add(Me.Spell2Tab)
        Me.AddDiscriptor.Controls.Add(Me.Levels)
        Me.AddDiscriptor.Controls.Add(Me.DescriptorsTab)
        Me.AddDiscriptor.Controls.Add(Me.TabPage1)
        Me.AddDiscriptor.ItemSize = New System.Drawing.Size(42, 18)
        Me.AddDiscriptor.Location = New System.Drawing.Point(15, 15)
        Me.AddDiscriptor.Name = "AddDiscriptor"
        Me.AddDiscriptor.SelectedIndex = 0
        Me.AddDiscriptor.Size = New System.Drawing.Size(415, 435)
        Me.AddDiscriptor.TabIndex = 0
        '
        'Spell2Tab
        '
        Me.Spell2Tab.Controls.Add(Me.Label14)
        Me.Spell2Tab.Controls.Add(Me.SpellResistance)
        Me.Spell2Tab.Controls.Add(Me.Label13)
        Me.Spell2Tab.Controls.Add(Me.SavingThrow)
        Me.Spell2Tab.Controls.Add(Me.Label12)
        Me.Spell2Tab.Controls.Add(Me.Duration)
        Me.Spell2Tab.Controls.Add(Me.Label11)
        Me.Spell2Tab.Controls.Add(Me.Label8)
        Me.Spell2Tab.Controls.Add(Me.Range)
        Me.Spell2Tab.Controls.Add(Me.CastingTime)
        Me.Spell2Tab.Controls.Add(Me.Label10)
        Me.Spell2Tab.Controls.Add(Me.TargetAreaEffect)
        Me.Spell2Tab.Location = New System.Drawing.Point(4, 22)
        Me.Spell2Tab.Name = "Spell2Tab"
        Me.Spell2Tab.Size = New System.Drawing.Size(407, 409)
        Me.Spell2Tab.TabIndex = 7
        Me.Spell2Tab.Text = "Spell 2"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.CausesValidation = False
        Me.Label14.Location = New System.Drawing.Point(15, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 21)
        Me.Label14.TabIndex = 193
        Me.Label14.Text = "Spell Resistance"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellResistance
        '
        Me.SpellResistance.CausesValidation = False
        Me.SpellResistance.EditValue = ""
        Me.SpellResistance.Location = New System.Drawing.Point(115, 190)
        Me.SpellResistance.Name = "SpellResistance"
        '
        'SpellResistance.Properties
        '
        Me.SpellResistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpellResistance.Properties.DropDownRows = 20
        Me.SpellResistance.Size = New System.Drawing.Size(270, 20)
        Me.SpellResistance.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.CausesValidation = False
        Me.Label13.Location = New System.Drawing.Point(15, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 21)
        Me.Label13.TabIndex = 191
        Me.Label13.Text = "Saving Throw"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SavingThrow
        '
        Me.SavingThrow.CausesValidation = False
        Me.SavingThrow.EditValue = ""
        Me.SavingThrow.Location = New System.Drawing.Point(115, 160)
        Me.SavingThrow.Name = "SavingThrow"
        '
        'SavingThrow.Properties
        '
        Me.SavingThrow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SavingThrow.Properties.DropDownRows = 20
        Me.SavingThrow.Size = New System.Drawing.Size(270, 20)
        Me.SavingThrow.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.CausesValidation = False
        Me.Label12.Location = New System.Drawing.Point(15, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 21)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Duration"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Duration
        '
        Me.Duration.EditValue = ""
        Me.Duration.Location = New System.Drawing.Point(115, 130)
        Me.Duration.Name = "Duration"
        '
        'Duration.Properties
        '
        Me.Duration.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Duration.Properties.DropDownRows = 20
        Me.Duration.Size = New System.Drawing.Size(270, 20)
        Me.Duration.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.CausesValidation = False
        Me.Label11.Location = New System.Drawing.Point(15, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 20)
        Me.Label11.TabIndex = 186
        Me.Label11.Text = "Target(s), Area or Effect"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.CausesValidation = False
        Me.Label8.Location = New System.Drawing.Point(15, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Range"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Range
        '
        Me.Range.EditValue = ""
        Me.Range.Location = New System.Drawing.Point(115, 45)
        Me.Range.Name = "Range"
        '
        'Range.Properties
        '
        Me.Range.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Range.Properties.DropDownRows = 20
        Me.Range.Size = New System.Drawing.Size(270, 20)
        Me.Range.TabIndex = 1
        '
        'CastingTime
        '
        Me.CastingTime.EditValue = ""
        Me.CastingTime.Location = New System.Drawing.Point(115, 15)
        Me.CastingTime.Name = "CastingTime"
        '
        'CastingTime.Properties
        '
        Me.CastingTime.Properties.AutoHeight = False
        Me.CastingTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CastingTime.Properties.DropDownRows = 20
        Me.CastingTime.Size = New System.Drawing.Size(270, 21)
        Me.CastingTime.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.CausesValidation = False
        Me.Label10.Location = New System.Drawing.Point(15, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 184
        Me.Label10.Text = "Casting Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetAreaEffect
        '
        Me.TargetAreaEffect.EditValue = ""
        Me.TargetAreaEffect.Location = New System.Drawing.Point(115, 100)
        Me.TargetAreaEffect.Name = "TargetAreaEffect"
        '
        'TargetAreaEffect.Properties
        '
        Me.TargetAreaEffect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TargetAreaEffect.Properties.DropDownRows = 20
        Me.TargetAreaEffect.Size = New System.Drawing.Size(270, 20)
        Me.TargetAreaEffect.TabIndex = 5
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'SpellForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 503)
        Me.Controls.Add(Me.AddDiscriptor)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SpellForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpellForm"
        Me.SpellTab.ResumeLayout(False)
        CType(Me.OtherText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubschoolDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Levels.ResumeLayout(False)
        CType(Me.LevelsString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpellLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescriptorsTab.ResumeLayout(False)
        CType(Me.DescriptorDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.AddDiscriptor.ResumeLayout(False)
        Me.Spell2Tab.ResumeLayout(False)
        CType(Me.SpellResistance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavingThrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Duration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Range.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CastingTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetAreaEffect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'indexes
    Private SchoolDataList As DataListItem()
    Private SubSchoolDataList As DataListItem()
    Private ClassDataList As DataListItem()
    Private DomainDataList As DataListItem()
    Private DescriptorsList As DataListItem()
    Private CategoryDataList As DataListItem()

    'object collections
    Private ExistingSpellLevels As New Objects.ObjectDataCollection
    Private SpellLevels As New Objects.ObjectDataCollection
    Private ExistingDescriptors As New Objects.ObjectDataCollection
    Private SpellDescriptors As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Dim Exclusions As New ArrayList
        Dim ClassDefinitions As Objects.ObjectDataCollection
        Try

            'build exclusion list for classes
            ClassDefinitions = Objects.GetAllObjectsOfType(Xml.DBTypes.Classes, Objects.ClassType)
            For Each ClassObject As Objects.ObjectData In ClassDefinitions
                If ClassObject.Element("CasterAbility") = "No" OrElse ClassObject.Element("CasterAbility") = "Psionic" Then
                    Exclusions.Add(ClassObject.ObjectGUID)
                ElseIf ClassObject.Element("CasterAbility") = "Prestige Advancement" And ClassObject.Element("PrestigeSpellType") = "" Then
                    Exclusions.Add(ClassObject.ObjectGUID)
                End If
            Next

            'load the data lists
            ClassDataList = Rules.Index.DataListExclude(ClassDefinitions, Exclusions)
            SchoolDataList = Rules.Index.DataList(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType)
            DomainDataList = Rules.Index.DataList(Xml.DBTypes.Domains, Objects.DomainDefinitionType)
            CategoryDataList = Rules.Index.DataList(Xml.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellCategoryDefinitionType)
            DescriptorsList = Rules.Index.DataList(Xml.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellDescriptorDefinitionType)

            'populate ComboBoxEditors
            TypeDropdown.Properties.Items.AddRange(RPGXplorer.Rules.Lists.SpellLevelTypes)
            SchoolDropdown.Properties.Items.AddRange(SchoolDataList)
            DescriptorDropdown.Properties.Items.AddRange(DescriptorsList)
            CastingTime.Properties.Items.AddRange(GetExistingValues("CastingTime").ToArray)
            Range.Properties.Items.AddRange(GetExistingValues("Range").ToArray)
            TargetAreaEffect.Properties.Items.AddRange(GetExistingValues("TargetAreaEffect").ToArray)
            Duration.Properties.Items.AddRange(GetExistingValues("Duration").ToArray)
            SavingThrow.Properties.Items.AddRange(GetExistingValues("SavingThrow").ToArray)
            SpellResistance.Properties.Items.AddRange(GetExistingValues("SpellResistance").ToArray)

            ComponentCost.Properties.DisplayFormat.Format = New GoldFormatter

            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init new Object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Spells)
            mObject.Type = Objects.SpellDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Spell"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Spell"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            Description.Text = mObject.Element("Description")

            SchoolDropdown.SelectedIndex = Rules.Index.GetGuidIndex(SchoolDataList, mObject.GetFKGuid("School"))
            'SchoolDropdown.Text = mObject.Element("School")

            If SubschoolDropdown.Properties.Enabled Then
                SubschoolDropdown.SelectedIndex = Rules.Index.GetGuidIndex(SubSchoolDataList, mObject.GetFKGuid("Subschool"))
            End If

            'initialise the checkboxes
            If Obj.Element("AllowPotion") = "Yes" Then PotionCheck.CheckState = CheckState.Checked
            If Obj.Element("VerbalComponent") = "Yes" Then VerbalCheck.CheckState = CheckState.Checked
            If Obj.Element("SomaticComponent") = "Yes" Then SomaticCheck.CheckState = CheckState.Checked
            If Obj.Element("MaterialComponent") = "Yes" Then MaterialCheck.CheckState = CheckState.Checked
            If Obj.Element("Focus") = "Yes" Then FocusCheck.CheckState = CheckState.Checked
            If Obj.Element("DivineFocus") = "Yes" Then DivineFocusCheck.CheckState = CheckState.Checked
            If Obj.Element("XP") = "Yes" Then XP.Checked = True Else XP.Checked = False
            If Obj.Element("OtherComponent") <> "" Then
                OtherCheck.Checked = True
                OtherText.Text = Obj.Element("OtherComponent")
            End If

            CastingTime.Text = Obj.Element("CastingTime")
            Range.Text = Obj.Element("Range")
            TargetAreaEffect.Text = Obj.Element("TargetAreaEffect")
            Duration.Text = Obj.Element("Duration")
            SavingThrow.Text = Obj.Element("SavingThrow")
            SpellResistance.Text = Obj.Element("SpellResistance")
            If Obj.Element("ComponentCost") = "Varies (see Rules)" Then
                VariableCost.Checked = True
            Else
                If Obj.Element("ComponentCost") <> "" Then ComponentCost.EditValue = CType(Obj.Element("ComponentCost").Replace(" gp", ""), Integer)
            End If
            If Obj.Element("XPCost") = "Varies (see Rules)" Then
                VariableXP.Checked = True
            Else
                XPCost.EditValue = Obj.ElementAsInteger("XPCost")
            End If

            LevelsString.Text = Obj.Element("ClassLevels")

            'get spell levels
            ExistingSpellLevels = mObject.ChildrenOfType(Objects.SpellLevelType)
            For Each Child In ExistingSpellLevels
                SpellLevels.Add(Child)
                LevelListBox.AddItem(Child.Name, Child.ObjectGUID)
            Next

            'get descriptors
            ExistingDescriptors = mObject.ChildrenOfType(Objects.SpellDescriptorType)
            For Each Child In ExistingDescriptors
                SpellDescriptors.Add(Child)
                Descriptors.AddItem(Child.Name, Child.ObjectGUID)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj, ClassObj As Objects.ObjectData
        Dim Components As String = ""
        Dim Descriptors As String = ""
        Dim Divine, Arcane As Boolean

        Try
            If Me.Validate() Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("Description") = Description.Text

                If Not SchoolDropdown.Text = "" Then mObject.FKElement("School", SchoolDropdown.Text, "Name", CType(SchoolDropdown.SelectedItem, DataListItem).ObjectGUID) Else mObject.FKSetNull("School")
                If SubschoolDropdown.SelectedIndex <> -1 Then
                    mObject.FKElement("Subschool", SubschoolDropdown.Text, "Name", CType(SubschoolDropdown.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.FKSetNull("Subschool")
                End If

                If PotionCheck.CheckState = CheckState.Checked Then mObject.Element("AllowPotion") = "Yes" Else mObject.Element("AllowPotion") = ""
                If VerbalCheck.CheckState = CheckState.Checked Then
                    mObject.Element("VerbalComponent") = "Yes"
                    Components &= "V, "
                Else
                    mObject.Element("VerbalComponent") = "No"
                End If
                If SomaticCheck.CheckState = CheckState.Checked Then
                    mObject.Element("SomaticComponent") = "Yes"
                    Components &= "S, "
                Else
                    mObject.Element("SomaticComponent") = "No"
                End If
                If MaterialCheck.CheckState = CheckState.Checked Then
                    mObject.Element("MaterialComponent") = "Yes"
                    Components &= "M, "
                Else
                    mObject.Element("MaterialComponent") = "No"
                End If
                If FocusCheck.CheckState = CheckState.Checked Then
                    mObject.Element("Focus") = "Yes"
                    Components &= "F, "
                Else
                    mObject.Element("Focus") = "No"
                End If
                If DivineFocusCheck.CheckState = CheckState.Checked Then
                    mObject.Element("DivineFocus") = "Yes"
                    Components &= "DF, "
                Else
                    mObject.Element("DivineFocus") = "No"
                End If
                If XP.Checked = True Then
                    mObject.Element("XP") = "Yes"
                    Components &= "XP, "
                Else
                    mObject.Element("XP") = "No"
                End If
                If OtherCheck.Checked = True Then
                    mObject.Element("OtherComponent") = OtherText.Text
                    Components &= (OtherText.Text & ", ")
                Else
                    mObject.Element("OtherComponent") = ""
                End If

                Components = Components.TrimEnd(New Char() {","c, " "c})
                mObject.Element("Components") = Components

                mObject.Element("CastingTime") = CastingTime.Text
                mObject.Element("Range") = Range.Text
                mObject.Element("TargetAreaEffect") = TargetAreaEffect.Text
                mObject.Element("Duration") = Duration.Text
                mObject.Element("SavingThrow") = SavingThrow.Text
                mObject.Element("SpellResistance") = SpellResistance.Text

                If ComponentCost.Properties.Enabled Then
                    If CType(ComponentCost.EditValue, Integer) = 0 Then
                        mObject.Element("ComponentCost") = ""
                    Else
                        mObject.Element("ComponentCost") = Rules.Formatting.FormatGP(CType(ComponentCost.EditValue, Integer))
                    End If
                ElseIf VariableCost.Checked Then
                    mObject.Element("ComponentCost") = "Varies (see Rules)"
                Else
                    mObject.Element("ComponentCost") = ""
                End If

                If XPCost.Properties.Enabled Then
                    mObject.Element("XPCost") = XPCost.Text
                ElseIf VariableXP.Checked Then
                    mObject.Element("XPCost") = "Varies (see Rules)"
                Else
                    mObject.Element("XPCost") = ""
                End If

                'set the Arcane and Divine elements
                mObject.Element("Arcane") = "" : Arcane = False
                mObject.Element("Divine") = "" : Divine = False

                'set the arcane and divine flags
                For Each Obj In SpellLevels
                    Select Case Rules.SpellList.GetSpellLevelSourceElement(Obj)

                        Case "Class"
                            ClassObj = Obj.GetFKObject("Class")
                            If Not ClassObj.IsEmpty Then
                                Select Case ClassObj.Element("CasterType")
                                    Case "Arcane"
                                        mObject.Element("Arcane") = "Yes"
                                        Arcane = True

                                    Case "Divine"
                                        mObject.Element("Divine") = "Yes"
                                        Divine = True
                                End Select
                            End If

                        Case "Domain"
                            mObject.Element("Divine") = "Yes"
                            Divine = True
                    End Select
                    If Arcane AndAlso Divine Then Exit For
                Next

                mObject.Element("ClassLevels") = LevelsString.Text
                mObject = PropertiesTab.UpdateObject(mObject)

                'spell levels
                For Each Obj In ExistingSpellLevels
                    If Not SpellLevels.Contains(Obj.ObjectGUID) Then
                        Dim ElementString As String = Rules.SpellList.GetSpellLevelSourceElement(Obj)
                        Dim Spells As New Objects.ObjectDataCollection : Spells.Add(Obj)
                        Rules.SpellList.RemoveSpellLevels(Spells, Obj.GetFKGuid(ElementString), False)
                    End If
                Next

                For Each Obj In SpellLevels
                    If Not ExistingSpellLevels.Contains(Obj.ObjectGUID) Then
                        Dim ElementString As String = Rules.SpellList.GetSpellLevelSourceElement(Obj)
                        Dim Spells As New Objects.ObjectDataCollection : Spells.Add(mObject)
                        Rules.SpellList.CreateSpellLevels(Obj.GetFKObject(ElementString), Spells, Obj.ElementAsInteger("Level"), False)
                    End If

                Next

                'descriptors
                For Each Obj In ExistingDescriptors
                    If Not SpellDescriptors.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                Descriptors = ""
                For Each Obj In SpellDescriptors
                    If Not ExistingDescriptors.Contains(Obj.ObjectGUID) Then Obj.Save()
                    Descriptors &= Obj.Name & ", "
                Next
                Descriptors = Descriptors.TrimEnd(New Char() {","c, " "c})
                mObject.Element("Descriptors") = Descriptors

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                Select Case mMode
                    Case FormMode.Add
                        Caches.AddSpell(mObject)
                    Case FormMode.Edit
                        Caches.ReplaceSpell(mObject)
                End Select
                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)
                Me.DialogResult = DialogResult.OK : Me.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'show
    Public Shadows Sub Show()
        Try
            MyBase.Show()
            If Commands.EditForm Is Nothing Then
                Commands.EditForm = Me
            Else
                OK.Enabled = False : Me.Text = Me.Text.Replace("Edit", "View") : Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_green.ico")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If Commands.EditForm Is Me Then
                Commands.EditForm = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.SpellTab.Controls, Errors) And General.ValidateForm(Me.Spell2Tab.Controls, Errors)

            If (VerbalCheck.Checked Or SomaticCheck.Checked Or MaterialCheck.Checked Or OtherCheck.Checked) = False Then
                Errors.SetError(MaterialCheck, General.ValidationSpellFormComponents)
                Validate = False
            Else
                Errors.SetError(MaterialCheck, "")
            End If

            If XPCost.Properties.Enabled = True AndAlso CType(XPCost.EditValue, Integer) = 0 Then
                Errors.SetError(XPCost, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(XPCost, "")
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

    Private Sub MaterialCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialCheck.CheckedChanged
        Try
            If MaterialCheck.Checked Then
                ComponentCost.Properties.Enabled = True
                VariableCost.Enabled = True
            Else
                VariableCost.Enabled = False
                VariableCost.Checked = False
                ComponentCost.Properties.Enabled = False
                ComponentCost.EditValue = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub XP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XP.CheckedChanged
        Try
            If XP.Checked Then
                XPCost.Properties.Enabled = True
                VariableXP.Enabled = True
            Else
                VariableXP.Enabled = False
                VariableXP.Checked = False
                XPCost.Properties.Enabled = False
                XPCost.EditValue = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub VariableCost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableCost.CheckedChanged
        Try
            If VariableCost.Checked Then
                ComponentCost.Properties.Enabled = False
                ComponentCost.EditValue = 0
            Else
                ComponentCost.Properties.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub VariableXP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableXP.CheckedChanged
        Try
            If VariableXP.Checked Then
                XPCost.Properties.Enabled = False
                XPCost.EditValue = 0
            Else
                XPCost.Properties.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Tab Code"

    Private Sub AddLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLevel.Click
        Dim Obj As New Objects.ObjectData
        Dim ObjGuid As Objects.ObjectKey
        Dim FKElement As String = ""

        Try
            If LevelDropdown.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select something to add.")
                Exit Sub
            End If

            ObjGuid = CType(LevelDropdown.SelectedItem, DataListItem).ObjectGUID

            Select Case TypeDropdown.SelectedItem.ToString
                Case "Class"
                    If SpellLevels.ContainsFK("Class", ObjGuid) Then
                        General.ShowInfoDialog("This Class has already been added.")
                        Exit Sub
                    End If
                    FKElement = "Class"
                Case "Domain"
                    If SpellLevels.ContainsFK("Domain", ObjGuid) Then
                        General.ShowInfoDialog("This Domain has already been added.")
                        Exit Sub
                    End If
                    FKElement = "Domain"
                Case "Category"
                    If SpellLevels.ContainsFK("Category", ObjGuid) Then
                        General.ShowInfoDialog("This Category has already been added.")
                        Exit Sub
                    End If
                    FKElement = "Category"
            End Select

            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Spells)
            Obj.ParentGUID = mObject.ObjectGUID
            Obj.Type = Objects.SpellLevelType
            Obj.Element("Level") = SpellLevel.EditValue.ToString
            Obj.FKElement(FKElement, LevelDropdown.Text, "Name", ObjGuid)

            LevelListBox.AddItem(Obj.Name, Obj.ObjectGUID)
            SpellLevels.Add(Obj)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveLevel.Click
        Try
            If LevelListBox.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a level to remove.")
                Exit Sub
            Else
                SpellLevels.Remove(LevelListBox.ItemGUID())
                LevelListBox.RemoveSelectedItem()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddDescriptor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDescriptor.Click
        Dim Obj As Objects.ObjectData

        Try
            If DescriptorDropdown.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a spell descriptor to add.")
                Exit Sub
            End If

            If SpellDescriptors.ContainsFK("SpellDescriptor", CType(DescriptorDropdown.SelectedItem, DataListItem).ObjectGUID) Then
                General.ShowInfoDialog("This spell descriptor is already in the list.")
            Else
                Obj = ExistingDescriptors.Item("SpellDescriptor", CType(DescriptorDropdown.SelectedItem, DataListItem).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.Name = DescriptorDropdown.Text
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Spells)
                    Obj.Type = Objects.SpellDescriptorType
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.FKElement("SpellDescriptor", DescriptorDropdown.Text, "Name", CType(DescriptorDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                SpellDescriptors.Add(Obj)
                Descriptors.AddItem(Obj.Name, Obj.ObjectGUID)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveDescriptor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveDescriptor.Click
        Try
            Try
                If Descriptors.SelectedIndex = -1 Then
                    General.ShowInfoDialog("Please select a descriptor to remove.")
                Else
                    SpellDescriptors.Remove(Descriptors.ItemGUID)
                    Descriptors.RemoveSelectedItem()
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load the SubschoolDropdown with the correct items
    Private Sub SchoolDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolDropdown.SelectedIndexChanged
        Dim School As New Objects.ObjectData
        Dim Subschools As Objects.ObjectDataCollection

        Try
            School.Load(CType(SchoolDropdown.SelectedItem, DataListItem).ObjectGUID)
            Subschools = School.ChildrenOfType(Objects.SpellSubschoolType)

            If Subschools.Count > 0 Then
                SubschoolDropdown.Properties.Enabled = True
                SubschoolDropdown.Properties.Items.Clear()
                SubSchoolDataList = Rules.Index.DataList(Subschools, False)
                SubschoolDropdown.Properties.Items.AddRange(SubSchoolDataList)
                SubschoolDropdown.SelectedIndex = -1
            Else
                SubschoolDropdown.Properties.Enabled = False
                SubschoolDropdown.SelectedIndex = -1
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SubschoolDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubschoolDropdown.SelectedIndexChanged
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'get a list of existing values in use for the element
    Private Function GetExistingValues(ByVal ElementName As String) As ArrayList
        Try
            Dim Values As New ArrayList
            Dim Nodes As System.Xml.XmlNodeList = XML.SelectNodes(Xml.DBTypes.Spells, "/RPGXplorerDatabase/RPGXplorerObject/" & ElementName)

            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText)
            Next

            Values.Sort()
            Return Values

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Private Sub TypeDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeDropdown.SelectedIndexChanged
        Try
            If TypeDropdown.SelectedIndex <> -1 Then
                Select Case CType(TypeDropdown.SelectedItem, String)
                    Case "Class"
                        LevelDropdown.Properties.Items.Clear()
                        LevelDropdown.SelectedIndex = -1
                        LevelDropdown.Properties.Items.AddRange(ClassDataList)
                        TypeLabel.Text = "Class"
                    Case "Domain"
                        LevelDropdown.Properties.Items.Clear()
                        LevelDropdown.SelectedIndex = -1
                        LevelDropdown.Properties.Items.AddRange(DomainDataList)
                        TypeLabel.Text = "Domain"
                    Case "Category"
                        LevelDropdown.Properties.Items.Clear()
                        LevelDropdown.SelectedIndex = -1
                        LevelDropdown.Properties.Items.AddRange(CategoryDataList)
                        TypeLabel.Text = "Category"
                End Select
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'suggest a levels string for this spell
    Private Sub AutoFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoFormat.Click
        Try
            Dim SpellLevelStrings As New ArrayList

            For Each Obj As Objects.ObjectData In SpellLevels
                Dim ClassObj As Objects.ObjectData = Obj.GetFKObject("Class")

                'if its not an inherited spell level
                If Obj.Element("Inherited") <> "True" Then
                    If Not ClassObj.IsEmpty Then
                        SpellLevelStrings.Add(ClassObj.Element("Abbreviation") & " " & Obj.Element("Level"))
                    Else
                        SpellLevelStrings.Add(Obj.Name)
                    End If
                End If
            Next

            SpellLevelStrings.Sort()
            LevelsString.Text = CommonLogic.CommaSeparatedList(SpellLevelStrings)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Private Sub SchoolDropdown_ParseEditValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles SchoolDropdown.ParseEditValue
    '    Dim TestStr As General.DataListItem

    '    If Not SchoolDataList Is Nothing Then
    '        TestStr = SchoolDataList(Rules.Index.GetNameIndex(SchoolDataList, e.Value.ToString))
    '        e.Value = TestStr
    '    End If

    'End Sub

    Private Sub SpellLevel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellLevel.EditValueChanged
        If SpellLevel.Value < 0 Then SpellLevel.Value = 0
    End Sub

    'other component box
    Private Sub OtherCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherCheck.CheckedChanged
        Try
            If OtherCheck.CheckState = CheckState.Checked Then
                OtherText.Enabled = True
            Else
                OtherText.Enabled = False
                OtherText.Text = ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

End Class
