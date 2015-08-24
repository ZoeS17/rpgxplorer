Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class PowerForm
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
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Levels As System.Windows.Forms.TabPage
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
    Public WithEvents SpellTab As System.Windows.Forms.TabPage
    Public WithEvents Spell2Tab As System.Windows.Forms.TabPage
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents XPCost As DevExpress.XtraEditors.SpinEdit
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents VariableXP As System.Windows.Forms.CheckBox
    Public WithEvents Display As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SubdisciplineDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DisciplineDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PowerResistance As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents LevelsString As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents TypeLabel As System.Windows.Forms.Label
    Public WithEvents LevelDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents LevelListBox As RPGXplorer.ListBox
    Public WithEvents PowerLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents RemoveLevel As System.Windows.Forms.Button
    Public WithEvents AddLevel As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents PointFormat As System.Windows.Forms.Button
    Public WithEvents PointsString As DevExpress.XtraEditors.TextEdit
    Public WithEvents LevelFormat As System.Windows.Forms.Button
    Public WithEvents AugmentCheck As System.Windows.Forms.CheckBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.SpellTab = New System.Windows.Forms.TabPage
        Me.Label17 = New System.Windows.Forms.Label
        Me.AugmentCheck = New System.Windows.Forms.CheckBox
        Me.VariableXP = New System.Windows.Forms.CheckBox
        Me.XPCost = New DevExpress.XtraEditors.SpinEdit
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SubdisciplineDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.DisciplineDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Levels = New System.Windows.Forms.TabPage
        Me.PointFormat = New System.Windows.Forms.Button
        Me.PointsString = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.LevelFormat = New System.Windows.Forms.Button
        Me.LevelsString = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.TypeLabel = New System.Windows.Forms.Label
        Me.LevelDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.LevelListBox = New RPGXplorer.ListBox
        Me.PowerLevel = New DevExpress.XtraEditors.SpinEdit
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
        Me.Display = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.PowerResistance = New DevExpress.XtraEditors.ComboBoxEdit
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
        CType(Me.XPCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubdisciplineDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisciplineDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Levels.SuspendLayout()
        CType(Me.PointsString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelsString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescriptorsTab.SuspendLayout()
        CType(Me.DescriptorDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.AddDiscriptor.SuspendLayout()
        Me.Spell2Tab.SuspendLayout()
        CType(Me.Display.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerResistance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OK.Location = New System.Drawing.Point(280, 415)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 0
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 415)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        '
        'SpellTab
        '
        Me.SpellTab.Controls.Add(Me.Label17)
        Me.SpellTab.Controls.Add(Me.AugmentCheck)
        Me.SpellTab.Controls.Add(Me.VariableXP)
        Me.SpellTab.Controls.Add(Me.XPCost)
        Me.SpellTab.Controls.Add(Me.WeightLabel)
        Me.SpellTab.Controls.Add(Me.Label5)
        Me.SpellTab.Controls.Add(Me.SubdisciplineDropdown)
        Me.SpellTab.Controls.Add(Me.IndentedLine2)
        Me.SpellTab.Controls.Add(Me.DisciplineDropdown)
        Me.SpellTab.Controls.Add(Me.Label1)
        Me.SpellTab.Controls.Add(Me.IndentedLine1)
        Me.SpellTab.Controls.Add(Me.Description)
        Me.SpellTab.Controls.Add(Me.Label3)
        Me.SpellTab.Controls.Add(Me.ObjectName)
        Me.SpellTab.Controls.Add(Me.Label2)
        Me.SpellTab.Location = New System.Drawing.Point(4, 22)
        Me.SpellTab.Name = "SpellTab"
        Me.SpellTab.Size = New System.Drawing.Size(407, 359)
        Me.SpellTab.TabIndex = 3
        Me.SpellTab.Text = "Power"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(15, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 21)
        Me.Label17.TabIndex = 191
        Me.Label17.Text = "Augmentable"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AugmentCheck
        '
        Me.AugmentCheck.CausesValidation = False
        Me.AugmentCheck.Location = New System.Drawing.Point(95, 230)
        Me.AugmentCheck.Name = "AugmentCheck"
        Me.AugmentCheck.Size = New System.Drawing.Size(125, 21)
        Me.AugmentCheck.TabIndex = 6
        Me.AugmentCheck.Text = "(see Rules)"
        '
        'VariableXP
        '
        Me.VariableXP.CausesValidation = False
        Me.VariableXP.Location = New System.Drawing.Point(190, 200)
        Me.VariableXP.Name = "VariableXP"
        Me.VariableXP.Size = New System.Drawing.Size(125, 21)
        Me.VariableXP.TabIndex = 5
        Me.VariableXP.Text = "Varies (see Rules)"
        '
        'XPCost
        '
        Me.XPCost.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.XPCost, 130)
        Me.XPCost.Location = New System.Drawing.Point(95, 200)
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
        Me.XPCost.TabIndex = 4
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 200)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(55, 21)
        Me.WeightLabel.TabIndex = 188
        Me.WeightLabel.Text = "XP Cost"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.CausesValidation = False
        Me.Label5.Location = New System.Drawing.Point(15, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Subdiscipline"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubdisciplineDropdown
        '
        Me.SubdisciplineDropdown.CausesValidation = False
        Me.SubdisciplineDropdown.EditValue = ""
        Me.SubdisciplineDropdown.Location = New System.Drawing.Point(95, 150)
        Me.SubdisciplineDropdown.Name = "SubdisciplineDropdown"
        '
        'SubdisciplineDropdown.Properties
        '
        Me.SubdisciplineDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubdisciplineDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SubdisciplineDropdown.Size = New System.Drawing.Size(150, 20)
        Me.SubdisciplineDropdown.TabIndex = 3
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
        'DisciplineDropdown
        '
        Me.DisciplineDropdown.EditValue = ""
        Me.DisciplineDropdown.Location = New System.Drawing.Point(95, 120)
        Me.DisciplineDropdown.Name = "DisciplineDropdown"
        '
        'DisciplineDropdown.Properties
        '
        Me.DisciplineDropdown.Properties.AutoHeight = False
        Me.DisciplineDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DisciplineDropdown.Properties.DropDownRows = 10
        Me.DisciplineDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DisciplineDropdown.Size = New System.Drawing.Size(150, 21)
        Me.DisciplineDropdown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Discipline"
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
        Me.Levels.Controls.Add(Me.PointFormat)
        Me.Levels.Controls.Add(Me.PointsString)
        Me.Levels.Controls.Add(Me.Label16)
        Me.Levels.Controls.Add(Me.LevelFormat)
        Me.Levels.Controls.Add(Me.LevelsString)
        Me.Levels.Controls.Add(Me.Label7)
        Me.Levels.Controls.Add(Me.IndentedLine5)
        Me.Levels.Controls.Add(Me.TypeLabel)
        Me.Levels.Controls.Add(Me.LevelDropdown)
        Me.Levels.Controls.Add(Me.IndentedLine3)
        Me.Levels.Controls.Add(Me.LevelListBox)
        Me.Levels.Controls.Add(Me.PowerLevel)
        Me.Levels.Controls.Add(Me.Label6)
        Me.Levels.Controls.Add(Me.RemoveLevel)
        Me.Levels.Controls.Add(Me.AddLevel)
        Me.Levels.Controls.Add(Me.Label4)
        Me.Levels.Controls.Add(Me.TypeDropdown)
        Me.Levels.Location = New System.Drawing.Point(4, 22)
        Me.Levels.Name = "Levels"
        Me.Levels.Size = New System.Drawing.Size(407, 359)
        Me.Levels.TabIndex = 4
        Me.Levels.Text = "Levels"
        '
        'PointFormat
        '
        Me.PointFormat.CausesValidation = False
        Me.PointFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointFormat.Location = New System.Drawing.Point(280, 325)
        Me.PointFormat.Name = "PointFormat"
        Me.PointFormat.Size = New System.Drawing.Size(110, 24)
        Me.PointFormat.TabIndex = 12
        Me.PointFormat.Text = "Suggest"
        '
        'PointsString
        '
        Me.PointsString.Location = New System.Drawing.Point(60, 325)
        Me.PointsString.Name = "PointsString"
        '
        'PointsString.Properties
        '
        Me.PointsString.Properties.AutoHeight = False
        Me.PointsString.Properties.MaxLength = 100
        Me.PointsString.Size = New System.Drawing.Size(205, 21)
        Me.PointsString.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.CausesValidation = False
        Me.Label16.Location = New System.Drawing.Point(16, 325)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 21)
        Me.Label16.TabIndex = 158
        Me.Label16.Text = "Points"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelFormat
        '
        Me.LevelFormat.CausesValidation = False
        Me.LevelFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelFormat.Location = New System.Drawing.Point(280, 290)
        Me.LevelFormat.Name = "LevelFormat"
        Me.LevelFormat.Size = New System.Drawing.Size(110, 24)
        Me.LevelFormat.TabIndex = 10
        Me.LevelFormat.Text = "Suggest"
        '
        'LevelsString
        '
        Me.LevelsString.Location = New System.Drawing.Point(60, 290)
        Me.LevelsString.Name = "LevelsString"
        '
        'LevelsString.Properties
        '
        Me.LevelsString.Properties.AutoHeight = False
        Me.LevelsString.Properties.MaxLength = 100
        Me.LevelsString.Size = New System.Drawing.Size(205, 21)
        Me.LevelsString.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.CausesValidation = False
        Me.Label7.Location = New System.Drawing.Point(15, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Levels"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine5
        '
        Me.IndentedLine5.CausesValidation = False
        Me.IndentedLine5.Location = New System.Drawing.Point(16, 275)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 154
        Me.IndentedLine5.TabStop = False
        '
        'TypeLabel
        '
        Me.TypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TypeLabel.CausesValidation = False
        Me.TypeLabel.Location = New System.Drawing.Point(15, 45)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(80, 21)
        Me.TypeLabel.TabIndex = 153
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelDropdown
        '
        Me.LevelDropdown.CausesValidation = False
        Me.LevelDropdown.Location = New System.Drawing.Point(100, 45)
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
        Me.IndentedLine3.TabIndex = 152
        Me.IndentedLine3.TabStop = False
        '
        'LevelListBox
        '
        Me.LevelListBox.CausesValidation = False
        Me.LevelListBox.Location = New System.Drawing.Point(15, 125)
        Me.LevelListBox.Name = "LevelListBox"
        Me.LevelListBox.Size = New System.Drawing.Size(250, 135)
        Me.LevelListBox.TabIndex = 8
        '
        'PowerLevel
        '
        Me.PowerLevel.CausesValidation = False
        Me.PowerLevel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PowerLevel.Location = New System.Drawing.Point(100, 75)
        Me.PowerLevel.Name = "PowerLevel"
        '
        'PowerLevel.Properties
        '
        Me.PowerLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.PowerLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PowerLevel.Properties.AutoHeight = False
        Me.PowerLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PowerLevel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.PowerLevel.Properties.IsFloatValue = False
        Me.PowerLevel.Properties.Mask.EditMask = "N00"
        Me.PowerLevel.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.PowerLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PowerLevel.Size = New System.Drawing.Size(50, 21)
        Me.PowerLevel.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.CausesValidation = False
        Me.Label6.Location = New System.Drawing.Point(15, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 151
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
        Me.RemoveLevel.TabIndex = 5
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
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TypeDropdown
        '
        Me.TypeDropdown.CausesValidation = False
        Me.TypeDropdown.Location = New System.Drawing.Point(100, 15)
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
        Me.DescriptorsTab.Size = New System.Drawing.Size(407, 359)
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
        Me.TabPage1.Size = New System.Drawing.Size(407, 359)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 359)
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
        Me.AddDiscriptor.Size = New System.Drawing.Size(415, 385)
        Me.AddDiscriptor.TabIndex = 0
        '
        'Spell2Tab
        '
        Me.Spell2Tab.Controls.Add(Me.Display)
        Me.Spell2Tab.Controls.Add(Me.Label15)
        Me.Spell2Tab.Controls.Add(Me.Label14)
        Me.Spell2Tab.Controls.Add(Me.PowerResistance)
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
        Me.Spell2Tab.Size = New System.Drawing.Size(407, 359)
        Me.Spell2Tab.TabIndex = 7
        Me.Spell2Tab.Text = "Power 2"
        '
        'Display
        '
        Me.Display.EditValue = ""
        Me.Display.Location = New System.Drawing.Point(115, 15)
        Me.Display.Name = "Display"
        '
        'Display.Properties
        '
        Me.Display.Properties.AutoHeight = False
        Me.Display.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Display.Properties.DropDownRows = 20
        Me.Display.Size = New System.Drawing.Size(270, 21)
        Me.Display.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.CausesValidation = False
        Me.Label15.Location = New System.Drawing.Point(15, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 21)
        Me.Label15.TabIndex = 194
        Me.Label15.Text = "Display"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.CausesValidation = False
        Me.Label14.Location = New System.Drawing.Point(15, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 21)
        Me.Label14.TabIndex = 193
        Me.Label14.Text = "Power Resistance"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PowerResistance
        '
        Me.PowerResistance.CausesValidation = False
        Me.PowerResistance.EditValue = ""
        Me.PowerResistance.Location = New System.Drawing.Point(115, 220)
        Me.PowerResistance.Name = "PowerResistance"
        '
        'PowerResistance.Properties
        '
        Me.PowerResistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PowerResistance.Properties.DropDownRows = 20
        Me.PowerResistance.Size = New System.Drawing.Size(270, 20)
        Me.PowerResistance.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.CausesValidation = False
        Me.Label13.Location = New System.Drawing.Point(15, 190)
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
        Me.SavingThrow.Location = New System.Drawing.Point(115, 190)
        Me.SavingThrow.Name = "SavingThrow"
        '
        'SavingThrow.Properties
        '
        Me.SavingThrow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SavingThrow.Properties.DropDownRows = 20
        Me.SavingThrow.Size = New System.Drawing.Size(270, 20)
        Me.SavingThrow.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.CausesValidation = False
        Me.Label12.Location = New System.Drawing.Point(15, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 21)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Duration"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Duration
        '
        Me.Duration.EditValue = ""
        Me.Duration.Location = New System.Drawing.Point(115, 160)
        Me.Duration.Name = "Duration"
        '
        'Duration.Properties
        '
        Me.Duration.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Duration.Properties.DropDownRows = 20
        Me.Duration.Size = New System.Drawing.Size(270, 20)
        Me.Duration.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.CausesValidation = False
        Me.Label11.Location = New System.Drawing.Point(15, 105)
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
        Me.Label8.Location = New System.Drawing.Point(15, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Range"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Range
        '
        Me.Range.EditValue = ""
        Me.Range.Location = New System.Drawing.Point(115, 75)
        Me.Range.Name = "Range"
        '
        'Range.Properties
        '
        Me.Range.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Range.Properties.DropDownRows = 20
        Me.Range.Size = New System.Drawing.Size(270, 20)
        Me.Range.TabIndex = 2
        '
        'CastingTime
        '
        Me.CastingTime.EditValue = ""
        Me.CastingTime.Location = New System.Drawing.Point(115, 45)
        Me.CastingTime.Name = "CastingTime"
        '
        'CastingTime.Properties
        '
        Me.CastingTime.Properties.AutoHeight = False
        Me.CastingTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CastingTime.Properties.DropDownRows = 20
        Me.CastingTime.Size = New System.Drawing.Size(270, 21)
        Me.CastingTime.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.CausesValidation = False
        Me.Label10.Location = New System.Drawing.Point(15, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 184
        Me.Label10.Text = "Manifesting Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetAreaEffect
        '
        Me.TargetAreaEffect.EditValue = ""
        Me.TargetAreaEffect.Location = New System.Drawing.Point(115, 130)
        Me.TargetAreaEffect.Name = "TargetAreaEffect"
        '
        'TargetAreaEffect.Properties
        '
        Me.TargetAreaEffect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TargetAreaEffect.Properties.DropDownRows = 20
        Me.TargetAreaEffect.Size = New System.Drawing.Size(270, 20)
        Me.TargetAreaEffect.TabIndex = 3
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'PowerForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 453)
        Me.Controls.Add(Me.AddDiscriptor)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PowerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PowerForm"
        Me.SpellTab.ResumeLayout(False)
        CType(Me.XPCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubdisciplineDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisciplineDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Levels.ResumeLayout(False)
        CType(Me.PointsString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelsString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescriptorsTab.ResumeLayout(False)
        CType(Me.DescriptorDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.AddDiscriptor.ResumeLayout(False)
        Me.Spell2Tab.ResumeLayout(False)
        CType(Me.Display.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerResistance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private DisciplineDataList As DataListItem()
    Private SubdisciplineDataList As DataListItem()
    Private ClassDataList As DataListItem()
    Private DisciplineSpecializationDataList As DataListItem()
    Private DescriptorsList As DataListItem()
    Private CategoryDataList As DataListItem()

    'object collections
    Private ExistingPowerLevels As New Objects.ObjectDataCollection
    Private PowerLevels As New Objects.ObjectDataCollection
    Private ExistingDescriptors As New Objects.ObjectDataCollection
    Private PowerDescriptors As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Dim Exclusions As New ArrayList
        Dim ClassDefinitions As Objects.ObjectDataCollection
        Try

            'build exclusion list for classes - change for psionic classes
            ClassDefinitions = Objects.GetAllObjectsOfType(Xml.DBTypes.Classes, Objects.ClassType)
            For Each ClassObject As Objects.ObjectData In ClassDefinitions
                If ClassObject.Element("CasterAbility") <> "Psionic" AndAlso ClassObject.Element("CasterAbility") <> "Prestige Advancement" Then
                    Exclusions.Add(ClassObject.ObjectGUID)
                ElseIf ClassObject.Element("CasterAbility") = "Prestige Advancement" And ClassObject.Element("AdvanceManifester") = "" Then
                    Exclusions.Add(ClassObject.ObjectGUID)
                End If
            Next

            'load the data lists
            ClassDataList = Rules.Index.DataListExclude(ClassDefinitions, Exclusions)
            DisciplineSpecializationDataList = Rules.Index.DataList(Xml.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType)
            DisciplineDataList = Rules.Index.DataList(Xml.DBTypes.SpellSchools, Objects.PsionicDisciplineType)
            DescriptorsList = Rules.Index.DataList(Xml.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellDescriptorDefinitionType)

            'populate ComboBoxEditors
            TypeDropdown.Properties.Items.AddRange(Rules.Lists.PowerLevelTypes)
            DisciplineDropdown.Properties.Items.AddRange(DisciplineDataList)
            DescriptorDropdown.Properties.Items.AddRange(DescriptorsList)

            Display.Properties.Items.AddRange(GetExistingValues("Display").ToArray)
            CastingTime.Properties.Items.AddRange(GetExistingValues("CastingTime").ToArray)
            Range.Properties.Items.AddRange(GetExistingValues("Range").ToArray)
            TargetAreaEffect.Properties.Items.AddRange(GetExistingValues("TargetAreaEffect").ToArray)
            Duration.Properties.Items.AddRange(GetExistingValues("Duration").ToArray)
            SavingThrow.Properties.Items.AddRange(GetExistingValues("SavingThrow").ToArray)
            PowerResistance.Properties.Items.AddRange(GetExistingValues("PowerResistance").ToArray)

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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Powers)
            mObject.Type = Objects.PowerDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Power"
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
            Me.Text = "Edit Power"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            Description.Text = mObject.Element("Description")

            DisciplineDropdown.SelectedIndex = Rules.Index.GetGuidIndex(DisciplineDataList, mObject.GetFKGuid("Discipline"))
            If SubdisciplineDropdown.Properties.Enabled Then
                SubdisciplineDropdown.SelectedIndex = Rules.Index.GetGuidIndex(SubdisciplineDataList, mObject.GetFKGuid("Subdiscipline"))
            End If

            Display.Text = Obj.Element("Display")
            CastingTime.Text = Obj.Element("CastingTime")
            Range.Text = Obj.Element("Range")
            TargetAreaEffect.Text = Obj.Element("TargetAreaEffect")
            Duration.Text = Obj.Element("Duration")
            SavingThrow.Text = Obj.Element("SavingThrow")
            PowerResistance.Text = Obj.Element("PowerResistance")

            If Obj.Element("XPCost") = "Varies (see Rules)" Then
                VariableXP.Checked = True
            Else
                XPCost.EditValue = Obj.ElementAsInteger("XPCost")
            End If

            If Obj.Element("Augment") = "Yes" Then AugmentCheck.Checked = True

            LevelsString.Text = Obj.Element("PowerLevels")
            PointsString.Text = Obj.Element("PowerPoints")

            'get spell levels
            ExistingPowerLevels = mObject.ChildrenOfType(Objects.PowerLevelType)
            For Each Child In ExistingPowerLevels
                PowerLevels.Add(Child)
                LevelListBox.AddItem(Child.Name, Child.ObjectGUID)
            Next

            'get descriptors
            ExistingDescriptors = mObject.ChildrenOfType(Objects.SpellDescriptorType)
            For Each Child In ExistingDescriptors
                PowerDescriptors.Add(Child)
                Descriptors.AddItem(Child.Name, Child.ObjectGUID)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As Objects.ObjectData
        Dim Descriptors As String
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
                mObject.FKElement("Discipline", DisciplineDropdown.Text, "Name", CType(DisciplineDropdown.SelectedItem, DataListItem).ObjectGUID)
                If SubdisciplineDropdown.SelectedIndex <> -1 Then
                    mObject.FKElement("Subdiscipline", SubdisciplineDropdown.Text, "Name", CType(SubdisciplineDropdown.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.FKSetNull("Subdiscipline")
                End If

                mObject.Element("Display") = Display.Text
                mObject.Element("CastingTime") = CastingTime.Text
                mObject.Element("Range") = Range.Text
                mObject.Element("TargetAreaEffect") = TargetAreaEffect.Text
                mObject.Element("Duration") = Duration.Text
                mObject.Element("SavingThrow") = SavingThrow.Text
                mObject.Element("PowerResistance") = PowerResistance.Text

                If XPCost.Value > 0 Then
                    mObject.Element("XPCost") = XPCost.Text
                ElseIf VariableXP.Checked Then
                    mObject.Element("XPCost") = "Varies (see Rules)"
                Else
                    mObject.Element("XPCost") = ""
                End If

                If AugmentCheck.Checked Then
                    mObject.Element("Augment") = "Yes"
                Else
                    mObject.Element("Augment") = ""
                End If

                mObject.Element("PowerLevels") = LevelsString.Text
                mObject.Element("PowerPoints") = PointsString.Text
                mObject = PropertiesTab.UpdateObject(mObject)


                'power levels
                For Each Obj In ExistingPowerLevels
                    If Not PowerLevels.Contains(Obj.ObjectGUID) Then
                        Dim ElementString As String = Rules.PowerList.GetPowerLevelSourceElement(Obj)
                        Dim Spells As New Objects.ObjectDataCollection : Spells.Add(Obj)
                        Rules.PowerList.RemovepowerLevels(Spells, Obj.GetFKGuid(ElementString))
                    End If
                Next

                For Each Obj In PowerLevels
                    If Not ExistingPowerLevels.Contains(Obj.ObjectGUID) Then
                        Dim ElementString As String = Rules.PowerList.GetPowerLevelSourceElement(Obj)
                        Dim Powers As New Objects.ObjectDataCollection : Powers.Add(mObject)
                        Rules.PowerList.CreatePowerLevels(Obj.GetFKObject(ElementString), Powers, Obj.ElementAsInteger("Level"))
                    End If
                Next

                'descriptors
                For Each Obj In ExistingDescriptors
                    If Not PowerDescriptors.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                Descriptors = ""
                For Each Obj In PowerDescriptors
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
                        Caches.AddPower(mObject)
                    Case FormMode.Edit
                        Caches.ReplacePower(mObject)
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

    Private Sub VariableXP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                    If PowerLevels.ContainsFK("Class", ObjGuid) Then
                        General.ShowInfoDialog("This Class has already been added.")
                        Exit Sub
                    End If
                    FKElement = "Class"
                Case "Discipline Specialization"
                    If PowerLevels.ContainsFK("DisciplineSpecialization", ObjGuid) Then
                        General.ShowInfoDialog("This Discipline Specialization has already been added.")
                        Exit Sub
                    End If
                    FKElement = "DisciplineSpecialization"
            End Select

            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Powers)
            Obj.ParentGUID = mObject.ObjectGUID
            Obj.Type = Objects.PowerLevelType
            Obj.Element("Level") = PowerLevel.EditValue.ToString
            Obj.FKElement(FKElement, LevelDropdown.Text, "Name", ObjGuid)

            LevelListBox.AddItem(Obj.Name, Obj.ObjectGUID)
            PowerLevels.Add(Obj)

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
                PowerLevels.Remove(LevelListBox.ItemGUID())
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
                General.ShowInfoDialog("Please select a power descriptor to add.")
                Exit Sub
            End If

            If PowerDescriptors.ContainsFK("PowerDescriptor", CType(DescriptorDropdown.SelectedItem, DataListItem).ObjectGUID) Then
                General.ShowInfoDialog("This power descriptor is already in the list.")
            Else
                Obj = ExistingDescriptors.Item("SpellDescriptor", CType(DescriptorDropdown.SelectedItem, DataListItem).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.Name = DescriptorDropdown.Text
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Powers)
                    Obj.Type = Objects.SpellDescriptorType
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.FKElement("SpellDescriptor", DescriptorDropdown.Text, "Name", CType(DescriptorDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                PowerDescriptors.Add(Obj)
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
                    PowerDescriptors.Remove(Descriptors.ItemGUID)
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
    Private Sub DisciplineDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisciplineDropdown.SelectedIndexChanged
        Dim Discipline As Objects.ObjectData
        Dim SubDisciplines As Objects.ObjectDataCollection

        Try

            Discipline = CType(CType(DisciplineDropdown.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
            SubDisciplines = Discipline.ChildrenOfType(Objects.PsionicSubdisciplineType)

            If SubDisciplines.Count > 0 Then
                SubdisciplineDropdown.Enabled = True
                SubdisciplineDropdown.Properties.Items.Clear()
                SubdisciplineDataList = Rules.Index.DataList(SubDisciplines)
                SubdisciplineDropdown.Properties.Items.AddRange(SubdisciplineDataList)
                SubdisciplineDropdown.SelectedItem = Nothing
            Else
                SubdisciplineDropdown.Enabled = False
                SubdisciplineDropdown.SelectedItem = Nothing
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load the correct types for the levelsdropdown
    Private Sub TypeDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeDropdown.SelectedIndexChanged
        Try
            If TypeDropdown.SelectedIndex <> -1 Then
                Select Case CType(TypeDropdown.SelectedItem, String)
                    Case "Class"
                        LevelDropdown.Properties.Items.Clear()
                        LevelDropdown.SelectedIndex = -1
                        LevelDropdown.Properties.Items.AddRange(ClassDataList)
                        TypeLabel.Text = "Class"
                    Case "Discipline Specialization"
                        LevelDropdown.Properties.Items.Clear()
                        LevelDropdown.SelectedIndex = -1
                        LevelDropdown.Properties.Items.AddRange(DisciplineSpecializationDataList)
                        TypeLabel.Text = "Specializaton"
                End Select
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'get a list of existing values in use for the element
    Private Function GetExistingValues(ByVal ElementName As String) As ArrayList
        Try
            Dim Values As New ArrayList
            Dim Nodes As System.Xml.XmlNodeList = XML.SelectNodes(Xml.DBTypes.Powers, "/RPGXplorerDatabase/RPGXplorerObject/" & ElementName)

            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText)
            Next

            Values.Sort()
            Return Values

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'suggest a levels string for this power
    Private Sub LevelFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelFormat.Click
        Try
            Dim PowerLevelStrings As New ArrayList

            For Each Obj As Objects.ObjectData In PowerLevels
                Dim ClassObj As Objects.ObjectData = Obj.GetFKObject("Class")

                'if its not an inherited power level
                If Obj.Element("Inherited") <> "True" Then
                    If Not ClassObj.IsEmpty Then
                        PowerLevelStrings.Add(ClassObj.Element("Abbreviation") & " " & Obj.Element("Level"))
                    Else
                        PowerLevelStrings.Add(Obj.Name)
                    End If
                End If
            Next

            PowerLevelStrings.Sort()
            LevelsString.Text = CommonLogic.CommaSeparatedList(PowerLevelStrings)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'suggest a points string for this power
    Private Sub PointFormat_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointFormat.Click
        Try
            Dim PowerPointStrings As New ArrayList
            Dim Tempstring As String
            Dim LastLevel As Integer = -1
            Dim LevelsSame As Boolean = True

            For Each Obj As Objects.ObjectData In PowerLevels
                'if its not an inherited power level
                If Obj.Element("Inherited") <> "True" Then
                    Dim ElementString As String = PowerList.GetPowerLevelSourceElement(Obj)
                    Dim SourceObj As Objects.ObjectData = Obj.GetFKObject(ElementString)
                    Dim Level As Integer = Obj.ElementAsInteger("Level")
                    If LastLevel <> -1 AndAlso Level <> LastLevel Then LevelsSame = False
                    LastLevel = Level
                    PowerPointStrings.Add(SourceObj.Name & " " & PowerList.PowerPoints(Level))
                End If
            Next

            If LevelsSame Then
                PointsString.Text = PowerList.PowerPoints(LastLevel).ToString()
            Else
                PowerPointStrings.Sort()

                Tempstring = CommonLogic.CommaSeparatedList(PowerPointStrings)
                If XPCost.Value > 0 Or (Not XPCost.Enabled) Then
                    If Tempstring <> "" Then Tempstring &= ", "
                    Tempstring &= "XP"
                End If

                PointsString.Text = Tempstring
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable or disable the XP spin edit
    Private Sub VariableXP_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableXP.CheckedChanged
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

End Class
