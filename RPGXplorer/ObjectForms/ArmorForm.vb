Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules
Imports RPGXplorer.Rules.Dice


Public Class ArmorForm
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
    Public WithEvents TrainingDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents SpellFailure As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ArmorCheck As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MaxDexBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ArmorBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Weight As DevExpress.XtraEditors.SpinEdit
	Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents ArmorTab As System.Windows.Forms.TabPage
    Public WithEvents DonTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Cost As RPGXplorer.MoneySpin
    Public WithEvents SDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents MDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents SDamageLabel As System.Windows.Forms.Label
    Public WithEvents MDamageLabel As System.Windows.Forms.Label
    Public WithEvents DamageTypeLabel As System.Windows.Forms.Label
    Public WithEvents DamageTab As System.Windows.Forms.TabPage
    Public WithEvents DamageDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents HoldItem As System.Windows.Forms.CheckBox
    Public WithEvents WieldWeapon As System.Windows.Forms.CheckBox
    Public WithEvents Encumberance As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents LDamageLabel As System.Windows.Forms.Label
    Public WithEvents LDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents MaxDexCheck As System.Windows.Forms.CheckBox
    Public WithEvents TowerShield As System.Windows.Forms.CheckBox
    Public WithEvents BaseItem As System.Windows.Forms.CheckBox
    Public WithEvents Masterwork As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents HDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents GDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents CDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents FDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents TDamage As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ArmorTab = New System.Windows.Forms.TabPage
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.MaxDexCheck = New System.Windows.Forms.CheckBox
        Me.Cost = New RPGXplorer.MoneySpin
        Me.Weight = New DevExpress.XtraEditors.SpinEdit
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.SpellFailure = New DevExpress.XtraEditors.SpinEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ArmorCheck = New DevExpress.XtraEditors.SpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.MaxDexBonus = New DevExpress.XtraEditors.SpinEdit
        Me.ArmorBonus = New DevExpress.XtraEditors.SpinEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.TrainingDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.DamageTab = New System.Windows.Forms.TabPage
        Me.HDamage = New DevExpress.XtraEditors.TextEdit
        Me.GDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.CDamage = New DevExpress.XtraEditors.TextEdit
        Me.FDamage = New DevExpress.XtraEditors.TextEdit
        Me.DDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TDamage = New DevExpress.XtraEditors.TextEdit
        Me.Encumberance = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.DamageDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageTypeLabel = New System.Windows.Forms.Label
        Me.SDamage = New DevExpress.XtraEditors.TextEdit
        Me.MDamage = New DevExpress.XtraEditors.TextEdit
        Me.SDamageLabel = New System.Windows.Forms.Label
        Me.MDamageLabel = New System.Windows.Forms.Label
        Me.LDamageLabel = New System.Windows.Forms.Label
        Me.LDamage = New DevExpress.XtraEditors.TextEdit
        Me.DonTab = New System.Windows.Forms.TabPage
        Me.BaseItem = New System.Windows.Forms.CheckBox
        Me.Masterwork = New System.Windows.Forms.CheckBox
        Me.WieldWeapon = New System.Windows.Forms.CheckBox
        Me.HoldItem = New System.Windows.Forms.CheckBox
        Me.TowerShield = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
		Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ArmorTab.SuspendLayout()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpellFailure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxDexBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DamageTab.SuspendLayout()
        CType(Me.HDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Encumberance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DonTab.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 425)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
		'
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 425)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
		'
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.ArmorTab)
        Me.TabControl1.Controls.Add(Me.DamageTab)
        Me.TabControl1.Controls.Add(Me.DonTab)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 395)
        Me.TabControl1.TabIndex = 0
		'
        'ArmorTab
        '
        Me.ArmorTab.Controls.Add(Me.IndentedLine2)
        Me.ArmorTab.Controls.Add(Me.MaxDexCheck)
        Me.ArmorTab.Controls.Add(Me.Cost)
        Me.ArmorTab.Controls.Add(Me.Weight)
        Me.ArmorTab.Controls.Add(Me.Description)
        Me.ArmorTab.Controls.Add(Me.Label17)
        Me.ArmorTab.Controls.Add(Me.SpellFailure)
        Me.ArmorTab.Controls.Add(Me.Label9)
        Me.ArmorTab.Controls.Add(Me.IndentedLine1)
        Me.ArmorTab.Controls.Add(Me.Label5)
        Me.ArmorTab.Controls.Add(Me.Label7)
        Me.ArmorTab.Controls.Add(Me.ArmorCheck)
        Me.ArmorTab.Controls.Add(Me.Label4)
        Me.ArmorTab.Controls.Add(Me.MaxDexBonus)
        Me.ArmorTab.Controls.Add(Me.ArmorBonus)
        Me.ArmorTab.Controls.Add(Me.Label8)
        Me.ArmorTab.Controls.Add(Me.TrainingDropdown)
        Me.ArmorTab.Controls.Add(Me.Label1)
        Me.ArmorTab.Controls.Add(Me.ObjectName)
        Me.ArmorTab.Controls.Add(Me.Label2)
        Me.ArmorTab.Location = New System.Drawing.Point(4, 22)
        Me.ArmorTab.Name = "ArmorTab"
        Me.ArmorTab.Size = New System.Drawing.Size(407, 369)
        Me.ArmorTab.TabIndex = 0
        Me.ArmorTab.Text = "Armor or Shield"
		'
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(16, 215)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 211
        Me.IndentedLine2.TabStop = False
		'
        'MaxDexCheck
        '
        Me.MaxDexCheck.Location = New System.Drawing.Point(15, 290)
        Me.MaxDexCheck.Name = "MaxDexCheck"
        Me.MaxDexCheck.Size = New System.Drawing.Size(130, 24)
        Me.MaxDexCheck.TabIndex = 7
        Me.MaxDexCheck.Text = "Max Dexterity Bonus"
		'
        'Cost
        '
        Me.Cost.Location = New System.Drawing.Point(95, 150)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(180, 21)
        Me.Cost.TabIndex = 3
		'
        'Weight
        '
        Me.Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Weight.Location = New System.Drawing.Point(95, 180)
        Me.Weight.Name = "Weight"
        '
        'Weight.Properties
        '
        Me.Weight.Properties.Appearance.Options.UseTextOptions = True
        Me.Weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.Properties.AutoHeight = False
        Me.Weight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Weight.Properties.Mask.ShowPlaceHolders = False
        Me.Weight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Weight.Size = New System.Drawing.Size(70, 21)
        Me.Weight.TabIndex = 4
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.Location = New System.Drawing.Point(95, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(295, 46)
        Me.Description.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.CausesValidation = False
        Me.Label17.Location = New System.Drawing.Point(15, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 21)
        Me.Label17.TabIndex = 210
        Me.Label17.Text = "Description"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'SpellFailure
        '
        Me.SpellFailure.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpellFailure.Location = New System.Drawing.Point(150, 320)
        Me.SpellFailure.Name = "SpellFailure"
        '
        'SpellFailure.Properties
        '
        Me.SpellFailure.Properties.Appearance.Options.UseTextOptions = True
        Me.SpellFailure.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpellFailure.Properties.AutoHeight = False
        Me.SpellFailure.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpellFailure.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.SpellFailure.Properties.IsFloatValue = False
        Me.SpellFailure.Properties.Mask.BeepOnError = True
        Me.SpellFailure.Properties.Mask.EditMask = "999"
        Me.SpellFailure.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SpellFailure.Properties.Mask.ShowPlaceHolders = False
        Me.SpellFailure.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.SpellFailure.Size = New System.Drawing.Size(50, 21)
        Me.SpellFailure.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(15, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 21)
        Me.Label9.TabIndex = 201
        Me.Label9.Text = "Spell Failure Chance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 200
        Me.IndentedLine1.TabStop = False
		'
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 21)
        Me.Label5.TabIndex = 196
        Me.Label5.Text = "Cost (S,M)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Weight (M)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'ArmorCheck
        '
        Me.ArmorCheck.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ArmorCheck.Location = New System.Drawing.Point(150, 260)
        Me.ArmorCheck.Name = "ArmorCheck"
        '
        'ArmorCheck.Properties
        '
        Me.ArmorCheck.Properties.Appearance.Options.UseTextOptions = True
        Me.ArmorCheck.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ArmorCheck.Properties.AutoHeight = False
        Me.ArmorCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ArmorCheck.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.ArmorCheck.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ArmorCheck.Properties.IsFloatValue = False
        Me.ArmorCheck.Properties.Mask.BeepOnError = True
        Me.ArmorCheck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ArmorCheck.Properties.Mask.ShowPlaceHolders = False
        Me.ArmorCheck.Properties.MinValue = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.ArmorCheck.Size = New System.Drawing.Size(50, 21)
        Me.ArmorCheck.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Armor Check Penalty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'MaxDexBonus
        '
        Me.MaxDexBonus.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MaxDexBonus.Enabled = False
        Me.MaxDexBonus.Location = New System.Drawing.Point(150, 290)
        Me.MaxDexBonus.Name = "MaxDexBonus"
        '
        'MaxDexBonus.Properties
        '
        Me.MaxDexBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.MaxDexBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaxDexBonus.Properties.AutoHeight = False
        Me.MaxDexBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MaxDexBonus.Properties.DisplayFormat.FormatString = "+0;-0;0"
        Me.MaxDexBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaxDexBonus.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.MaxDexBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaxDexBonus.Properties.IsFloatValue = False
        Me.MaxDexBonus.Properties.Mask.BeepOnError = True
        Me.MaxDexBonus.Properties.Mask.EditMask = "d"
        Me.MaxDexBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.MaxDexBonus.Properties.Mask.ShowPlaceHolders = False
        Me.MaxDexBonus.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.MaxDexBonus.Size = New System.Drawing.Size(50, 21)
        Me.MaxDexBonus.TabIndex = 8
        '
        'ArmorBonus
        '
        Me.ArmorBonus.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ArmorBonus.Location = New System.Drawing.Point(150, 230)
        Me.ArmorBonus.Name = "ArmorBonus"
        '
        'ArmorBonus.Properties
        '
        Me.ArmorBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.ArmorBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ArmorBonus.Properties.AutoHeight = False
        Me.ArmorBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ArmorBonus.Properties.DisplayFormat.FormatString = "+0;-0;0"
        Me.ArmorBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ArmorBonus.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.ArmorBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ArmorBonus.Properties.IsFloatValue = False
        Me.ArmorBonus.Properties.Mask.BeepOnError = True
        Me.ArmorBonus.Properties.Mask.EditMask = "d"
        Me.ArmorBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ArmorBonus.Properties.Mask.ShowPlaceHolders = False
        Me.ArmorBonus.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ArmorBonus.Size = New System.Drawing.Size(50, 21)
        Me.ArmorBonus.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Armor Bonus"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'TrainingDropdown
        '
        Me.TrainingDropdown.EditValue = ""
        Me.TrainingDropdown.Location = New System.Drawing.Point(95, 120)
        Me.TrainingDropdown.Name = "TrainingDropdown"
        '
        'TrainingDropdown.Properties
        '
        Me.TrainingDropdown.Properties.AutoHeight = False
        Me.TrainingDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TrainingDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TrainingDropdown.Size = New System.Drawing.Size(150, 21)
        Me.TrainingDropdown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Training"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(95, 15)
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
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'DamageTab
        '
        Me.DamageTab.Controls.Add(Me.HDamage)
        Me.DamageTab.Controls.Add(Me.GDamage)
        Me.DamageTab.Controls.Add(Me.Label12)
        Me.DamageTab.Controls.Add(Me.Label13)
        Me.DamageTab.Controls.Add(Me.Label14)
        Me.DamageTab.Controls.Add(Me.CDamage)
        Me.DamageTab.Controls.Add(Me.FDamage)
        Me.DamageTab.Controls.Add(Me.DDamage)
        Me.DamageTab.Controls.Add(Me.Label3)
        Me.DamageTab.Controls.Add(Me.Label10)
        Me.DamageTab.Controls.Add(Me.Label11)
        Me.DamageTab.Controls.Add(Me.TDamage)
        Me.DamageTab.Controls.Add(Me.Encumberance)
        Me.DamageTab.Controls.Add(Me.Label6)
        Me.DamageTab.Controls.Add(Me.DamageDropdown)
        Me.DamageTab.Controls.Add(Me.DamageTypeLabel)
        Me.DamageTab.Controls.Add(Me.SDamage)
        Me.DamageTab.Controls.Add(Me.MDamage)
        Me.DamageTab.Controls.Add(Me.SDamageLabel)
        Me.DamageTab.Controls.Add(Me.MDamageLabel)
        Me.DamageTab.Controls.Add(Me.LDamageLabel)
        Me.DamageTab.Controls.Add(Me.LDamage)
        Me.DamageTab.Location = New System.Drawing.Point(4, 22)
        Me.DamageTab.Name = "DamageTab"
        Me.DamageTab.Size = New System.Drawing.Size(407, 369)
        Me.DamageTab.TabIndex = 3
        Me.DamageTab.Text = "Damage"
		'
        'HDamage
        '
        Me.HDamage.CausesValidation = False
        Me.HDamage.Location = New System.Drawing.Point(95, 195)
        Me.HDamage.Name = "HDamage"
        '
        'HDamage.Properties
        '
        Me.HDamage.Properties.AutoHeight = False
        Me.HDamage.Size = New System.Drawing.Size(50, 21)
        Me.HDamage.TabIndex = 198
        '
        'GDamage
        '
        Me.GDamage.CausesValidation = False
        Me.GDamage.Location = New System.Drawing.Point(95, 225)
        Me.GDamage.Name = "GDamage"
        '
        'GDamage.Properties
        '
        Me.GDamage.Properties.AutoHeight = False
        Me.GDamage.Size = New System.Drawing.Size(50, 21)
        Me.GDamage.TabIndex = 199
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(15, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 21)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Huge"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(15, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 21)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Gargantuan"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(15, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 21)
        Me.Label14.TabIndex = 201
        Me.Label14.Text = "Colossal"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'CDamage
        '
        Me.CDamage.CausesValidation = False
        Me.CDamage.Location = New System.Drawing.Point(95, 255)
        Me.CDamage.Name = "CDamage"
        '
        'CDamage.Properties
        '
        Me.CDamage.Properties.AutoHeight = False
        Me.CDamage.Size = New System.Drawing.Size(50, 21)
        Me.CDamage.TabIndex = 200
        '
        'FDamage
        '
        Me.FDamage.CausesValidation = False
        Me.FDamage.Location = New System.Drawing.Point(95, 15)
        Me.FDamage.Name = "FDamage"
        '
        'FDamage.Properties
        '
        Me.FDamage.Properties.AutoHeight = False
        Me.FDamage.Size = New System.Drawing.Size(50, 21)
        Me.FDamage.TabIndex = 192
        '
        'DDamage
        '
        Me.DDamage.CausesValidation = False
        Me.DDamage.Location = New System.Drawing.Point(95, 45)
        Me.DDamage.Name = "DDamage"
        '
        'DDamage.Properties
        '
        Me.DDamage.Properties.AutoHeight = False
        Me.DDamage.Size = New System.Drawing.Size(50, 21)
        Me.DDamage.TabIndex = 193
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 21)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "Fine"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 21)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "Diminutive"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 21)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Tiny"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'TDamage
        '
        Me.TDamage.CausesValidation = False
        Me.TDamage.Location = New System.Drawing.Point(95, 75)
        Me.TDamage.Name = "TDamage"
        '
        'TDamage.Properties
        '
        Me.TDamage.Properties.AutoHeight = False
        Me.TDamage.Size = New System.Drawing.Size(50, 21)
        Me.TDamage.TabIndex = 194
        '
        'Encumberance
        '
        Me.Encumberance.CausesValidation = False
        Me.Encumberance.Enabled = False
        Me.Encumberance.Location = New System.Drawing.Point(230, 315)
        Me.Encumberance.Name = "Encumberance"
        '
        'Encumberance.Properties
        '
        Me.Encumberance.Properties.AutoHeight = False
        Me.Encumberance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Encumberance.Properties.DropDownRows = 10
        Me.Encumberance.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Encumberance.Size = New System.Drawing.Size(100, 21)
        Me.Encumberance.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 21)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "Encumberance For Two-Weapon Fighting"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'DamageDropdown
        '
        Me.DamageDropdown.CausesValidation = False
        Me.DamageDropdown.Enabled = False
        Me.DamageDropdown.Location = New System.Drawing.Point(95, 285)
        Me.DamageDropdown.Name = "DamageDropdown"
        '
        'DamageDropdown.Properties
        '
        Me.DamageDropdown.Properties.AutoHeight = False
        Me.DamageDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageDropdown.Properties.DropDownRows = 10
        Me.DamageDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageDropdown.Size = New System.Drawing.Size(100, 21)
        Me.DamageDropdown.TabIndex = 3
        '
        'DamageTypeLabel
        '
        Me.DamageTypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DamageTypeLabel.Location = New System.Drawing.Point(15, 285)
        Me.DamageTypeLabel.Name = "DamageTypeLabel"
        Me.DamageTypeLabel.Size = New System.Drawing.Size(75, 21)
        Me.DamageTypeLabel.TabIndex = 189
        Me.DamageTypeLabel.Text = "Damage Type"
        Me.DamageTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'SDamage
        '
        Me.SDamage.Location = New System.Drawing.Point(95, 105)
        Me.SDamage.Name = "SDamage"
        '
        'SDamage.Properties
        '
        Me.SDamage.Properties.AutoHeight = False
        Me.SDamage.Size = New System.Drawing.Size(50, 21)
        Me.SDamage.TabIndex = 0
        '
        'MDamage
        '
        Me.MDamage.Location = New System.Drawing.Point(95, 135)
        Me.MDamage.Name = "MDamage"
        '
        'MDamage.Properties
        '
        Me.MDamage.Properties.AutoHeight = False
        Me.MDamage.Size = New System.Drawing.Size(50, 21)
        Me.MDamage.TabIndex = 1
        '
        'SDamageLabel
        '
        Me.SDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.SDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDamageLabel.Location = New System.Drawing.Point(15, 105)
        Me.SDamageLabel.Name = "SDamageLabel"
        Me.SDamageLabel.Size = New System.Drawing.Size(40, 21)
        Me.SDamageLabel.TabIndex = 187
        Me.SDamageLabel.Text = "Small"
        Me.SDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'MDamageLabel
        '
        Me.MDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.MDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MDamageLabel.Location = New System.Drawing.Point(15, 135)
        Me.MDamageLabel.Name = "MDamageLabel"
        Me.MDamageLabel.Size = New System.Drawing.Size(50, 21)
        Me.MDamageLabel.TabIndex = 186
        Me.MDamageLabel.Text = "Medium"
        Me.MDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'LDamageLabel
        '
        Me.LDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.LDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDamageLabel.Location = New System.Drawing.Point(15, 165)
        Me.LDamageLabel.Name = "LDamageLabel"
        Me.LDamageLabel.Size = New System.Drawing.Size(40, 21)
        Me.LDamageLabel.TabIndex = 186
        Me.LDamageLabel.Text = "Large"
        Me.LDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'LDamage
        '
        Me.LDamage.Location = New System.Drawing.Point(95, 165)
        Me.LDamage.Name = "LDamage"
        '
        'LDamage.Properties
        '
        Me.LDamage.Properties.AutoHeight = False
        Me.LDamage.Size = New System.Drawing.Size(50, 21)
        Me.LDamage.TabIndex = 2
        '
        'DonTab
        '
        Me.DonTab.Controls.Add(Me.BaseItem)
        Me.DonTab.Controls.Add(Me.Masterwork)
        Me.DonTab.Controls.Add(Me.WieldWeapon)
        Me.DonTab.Controls.Add(Me.HoldItem)
        Me.DonTab.Controls.Add(Me.TowerShield)
        Me.DonTab.Location = New System.Drawing.Point(4, 22)
        Me.DonTab.Name = "DonTab"
        Me.DonTab.Size = New System.Drawing.Size(407, 369)
        Me.DonTab.TabIndex = 1
        Me.DonTab.Text = "Miscellaneous"
		'
        'BaseItem
        '
        Me.BaseItem.Location = New System.Drawing.Point(15, 45)
        Me.BaseItem.Name = "BaseItem"
        Me.BaseItem.Size = New System.Drawing.Size(205, 24)
        Me.BaseItem.TabIndex = 1
        Me.BaseItem.Text = "Base for Magic Armor or Shield only"
		'
        'Masterwork
        '
        Me.Masterwork.Location = New System.Drawing.Point(15, 15)
        Me.Masterwork.Name = "Masterwork"
        Me.Masterwork.TabIndex = 0
        Me.Masterwork.Text = "Masterwork"
		'
        'WieldWeapon
        '
        Me.WieldWeapon.Enabled = False
        Me.WieldWeapon.Location = New System.Drawing.Point(35, 135)
        Me.WieldWeapon.Name = "WieldWeapon"
        Me.WieldWeapon.Size = New System.Drawing.Size(175, 21)
        Me.WieldWeapon.TabIndex = 4
        Me.WieldWeapon.Text = "Can Wield Weapon (Buckler)"
		'
        'HoldItem
        '
        Me.HoldItem.Enabled = False
        Me.HoldItem.Location = New System.Drawing.Point(15, 105)
        Me.HoldItem.Name = "HoldItem"
        Me.HoldItem.Size = New System.Drawing.Size(240, 21)
        Me.HoldItem.TabIndex = 3
        Me.HoldItem.Text = "Can Hold Item in Same Hand"
		'
        'TowerShield
        '
        Me.TowerShield.Enabled = False
        Me.TowerShield.Location = New System.Drawing.Point(15, 75)
        Me.TowerShield.Name = "TowerShield"
        Me.TowerShield.Size = New System.Drawing.Size(240, 21)
        Me.TowerShield.TabIndex = 2
        Me.TowerShield.Text = "Requires Tower Shield Proficiency"
		'
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PropertiesTab)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(407, 369)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Properties"
		'
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
		'
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'ArmorForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 463)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ArmorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArmorForm"
        Me.TabControl1.ResumeLayout(False)
        Me.ArmorTab.ResumeLayout(False)
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpellFailure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxDexBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DamageTab.ResumeLayout(False)
        CType(Me.HDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Encumberance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DonTab.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mOldType As String

    'init
    Public Sub Init()
        Try
            'populate ComboBoxEditers
            TrainingDropdown.Properties.Items.AddRange(Rules.Lists.ArmorTrainingTypes)
            Encumberance.Properties.Items.AddRange(Rules.Lists.EncumbranceTypes)
            Encumberance.Properties.Items.RemoveAt(2)

            'Custom Formatters
            Weight.Properties.DisplayFormat.Format = New Rules.WeightFormatter
            SpellFailure.Properties.DisplayFormat.Format = New Rules.PercentFormatter
            Cost.MaxGP = 99999

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

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Characters)
            mObject.ParentGUID = mFolder.ObjectGUID
            'mObject.Type = Objects.ArmorDefinitionType

            'init form
            Me.Text = "Add Armor or Shield"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit
            mOldType = Obj.Type

            'init form
            Me.Text = "Edit Armor or Shield"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            ObjectName.Text = Obj.Name

            Weight.Value = CDec(mObject.Element("Weight").Replace(" lb.", ""))
            Cost.Value = Obj.Element("Cost")
            TrainingDropdown.Text = Obj.Element("Training")

            ArmorBonus.Value = mObject.ElementAsInteger("ArmorBonus")
            ArmorCheck.Value = mObject.ElementAsInteger("ArmorCheck")
            Dim Temp As String = mObject.Element("MaxDexBonus")
            If Temp = "-" Then
                MaxDexCheck.Checked = False
            Else
                MaxDexCheck.Checked = True
                MaxDexBonus.Value = CType(Temp, Integer)
            End If

            SpellFailure.Value = CInt(mObject.Element("SpellFailure").Replace("%", ""))
            If mObject.Element("Masterwork") = "Yes" Then Masterwork.Checked = True
            If mObject.Element("BaseItem") = "Yes" Then BaseItem.Checked = True

            FDamage.Text = mObject.Element("DamageFine")
            DDamage.Text = mObject.Element("DamageDiminutive")
            TDamage.Text = mObject.Element("DamageTiny")

            SDamage.Text = mObject.Element("DamageSmall")
            MDamage.Text = mObject.Element("DamageMedium")
            LDamage.Text = mObject.Element("DamageLarge")

            HDamage.Text = mObject.Element("DamageHuge")
            GDamage.Text = mObject.Element("DamageGargantuan")
            CDamage.Text = mObject.Element("DamageColossal")

            DamageDropdown.Text = mObject.Element("DamageType")
            Encumberance.Text = mObject.Element("Encumberance")

            If mObject.Element("TowerShield") = "Yes" Then TowerShield.Checked = True
            If mObject.Element("HoldItem") = "Yes" Then HoldItem.Checked = True
            If mObject.Element("WieldWeapon") = "Yes" Then WieldWeapon.Checked = True

            Description.Text = Obj.Element("Description")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text

                mObject.Element("Weight") = Weight.Value.ToString & " lb."
                mObject.Element("Cost") = Cost.Value
                mObject.Element("Training") = TrainingDropdown.Text

                Select Case TrainingDropdown.Text
                    Case "Medium", "Heavy"
                        mObject.Element("ReduceSpeed") = "Yes"
                    Case Else
                        mObject.Element("RecuceSpeed") = ""
                End Select

                mObject.Element("ArmorBonus") = ArmorBonus.Text
                mObject.Element("ArmorCheck") = ArmorCheck.Text
                If MaxDexCheck.Checked Then
                    mObject.Element("MaxDexBonus") = MaxDexBonus.Text
                Else
                    mObject.Element("MaxDexBonus") = "-"
                End If

                mObject.Element("SpellFailure") = SpellFailure.Value.ToString & "%"
                If Masterwork.Checked Then mObject.Element("Masterwork") = "Yes" Else mObject.Element("Masterwork") = ""
                If BaseItem.Checked Then mObject.Element("BaseItem") = "Yes" Else mObject.Element("BaseItem") = ""

                mObject.Element("DamageFine") = FDamage.Text
                mObject.Element("DamageDiminutive") = DDamage.Text
                mObject.Element("DamageTiny") = TDamage.Text

                mObject.Element("DamageSmall") = SDamage.Text
                mObject.Element("DamageMedium") = MDamage.Text
                mObject.Element("DamageLarge") = LDamage.Text

                mObject.Element("DamageHuge") = HDamage.Text
                mObject.Element("DamageGargantuan") = GDamage.Text
                mObject.Element("DamageColossal") = CDamage.Text

                mObject.Element("DamageType") = DamageDropdown.Text
                mObject.Element("Encumberance") = Encumberance.Text

                If TowerShield.Checked Then mObject.Element("TowerShield") = "Yes" Else mObject.Element("TowerShield") = ""
                If HoldItem.Checked Then mObject.Element("HoldItem") = "Yes" Else mObject.Element("HoldItem") = ""
                If WieldWeapon.Checked Then mObject.Element("WieldWeapon") = "Yes" Else mObject.Element("WieldWeapon") = ""

                mObject.Element("Description") = Description.Text

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.RefreshRenamedNode(mObject.ObjectGUID, mObject.Name)
                End If

                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)
                Me.DialogResult = DialogResult.OK : Me.Close()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
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
            Validate = General.ValidateForm(Me.ArmorTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.DonTab.Controls, Errors)

            'REMOVED to allow AC +0
            'If ArmorBonus.Text = "0" Then
            '    Errors.SetError(ArmorBonus, General.ValidationCannotBeZero)
            '    Validate = False
            'Else
            '    Errors.SetError(ArmorBonus, "")
            'End If

            If FDamage.Text = "" OrElse ValidNumberDiceRange(FDamage) Then
                Errors.SetError(FDamage, "")
            Else
                Errors.SetError(FDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If DDamage.Text = "" OrElse ValidNumberDiceRange(DDamage) Then
                Errors.SetError(DDamage, "")
            Else
                Errors.SetError(DDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If TDamage.Text = "" OrElse ValidNumberDiceRange(TDamage) Then
                Errors.SetError(TDamage, "")
            Else
                Errors.SetError(TDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If (FDamage.Text <> "" Or DDamage.Text <> "" Or TDamage.Text <> "" Or SDamage.Text <> "" Or MDamage.Text <> "" Or LDamage.Text <> "" Or HDamage.Text <> "" Or GDamage.Text <> "" Or CDamage.Text <> "") And DamageDropdown.Text = "" Then
                Errors.SetError(DamageDropdown, General.ValidationRequired)
                Validate = False
            Else
                Errors.SetError(DamageDropdown, "")
            End If

            If SDamage.Text = "" And DamageDropdown.Text <> "" Then
                Errors.SetError(SDamage, General.ValidationRequired)
                Validate = False
            Else
                If SDamage.Text <> "" And Not ValidNumberDiceRange(SDamage) Then
                    Errors.SetError(SDamage, ValidationPWNumberOrDiceRange)
                    Validate = False
                Else
                    Errors.SetError(SDamage, "")
                End If
            End If

            If MDamage.Text = "" And DamageDropdown.Text <> "" Then
                Errors.SetError(MDamage, General.ValidationRequired)
                Validate = False
            Else
                If MDamage.Text <> "" And Not ValidNumberDiceRange(MDamage) Then
                    Errors.SetError(MDamage, ValidationPWNumberOrDiceRange)
                    Validate = False
                Else
                    Errors.SetError(MDamage, "")
                End If
            End If

            If LDamage.Text = "" And DamageDropdown.Text <> "" Then
                Errors.SetError(LDamage, General.ValidationRequired)
                Validate = False
            Else
                If LDamage.Text <> "" And Not ValidNumberDiceRange(LDamage) Then
                    Errors.SetError(LDamage, ValidationPWNumberOrDiceRange)
                    Validate = False
                Else
                    Errors.SetError(LDamage, "")
                End If
            End If

            If HDamage.Text = "" OrElse ValidNumberDiceRange(HDamage) Then
                Errors.SetError(HDamage, "")
            Else
                Errors.SetError(HDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If GDamage.Text = "" OrElse ValidNumberDiceRange(GDamage) Then
                Errors.SetError(GDamage, "")
            Else
                Errors.SetError(GDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If CDamage.Text = "" OrElse ValidNumberDiceRange(CDamage) Then
                Errors.SetError(CDamage, "")
            Else
                Errors.SetError(CDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If Encumberance.Properties.Enabled = True And Encumberance.SelectedIndex = -1 And (MDamage.Text <> "" Or SDamage.Text <> "" Or LDamage.Text <> "" Or DamageDropdown.Text <> "") Then
                Errors.SetError(Encumberance, General.ValidationRequired)
                Validate = False
            Else
                Errors.SetError(Encumberance, "")
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name And mOldType <> mObject.Type Then
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

    'enable/disable Speed and Don Hastily Controls if a Shield is selected
    Private Sub TrainingDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingDropdown.SelectedIndexChanged
        Try
            If TrainingDropdown.Text = "Shield" Then
                mObject.Type = Objects.ShieldDefinitionType
                If WieldWeapon.Checked = False Then
                    DamageDropdown.Properties.Enabled = True
                End If
                DamageDropdown.Properties.Items.Clear()
                DamageDropdown.Properties.Items.Add("")
                DamageDropdown.Properties.Items.Add("Bludgeoning")
                DamageDropdown.Properties.Items.Add("Piercing")
                DamageDropdown.Properties.Items.Add("Slashing")
                Encumberance.Properties.Enabled = True
                HoldItem.Enabled = True
                TowerShield.Enabled = True
            Else
                mObject.Type = Objects.ArmorDefinitionType
                DamageDropdown.Properties.Enabled = True
                DamageDropdown.Properties.Items.Clear()
                DamageDropdown.Properties.Items.Add("")
                DamageDropdown.Properties.Items.Add("Piercing")
                Encumberance.Properties.Enabled = False
                Encumberance.SelectedIndex = -1
                TowerShield.Enabled = False
                TowerShield.Checked = False
                HoldItem.Enabled = False
                HoldItem.Checked = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub BaseItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseItem.CheckedChanged
        Try
            If BaseItem.Checked Then Masterwork.Checked = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Masterwork_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Masterwork.CheckedChanged
        Try
            If Masterwork.Checked = False Then BaseItem.Checked = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub HoldItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HoldItem.CheckedChanged
        Try
            If HoldItem.Checked Then
                WieldWeapon.Enabled = True
                TowerShield.Checked = False
            Else
                WieldWeapon.Checked = False
                WieldWeapon.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub TowerShield_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TowerShield.CheckedChanged
        If TowerShield.Checked Then
            HoldItem.Checked = False
        End If
    End Sub

    Private Sub WieldWeapon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WieldWeapon.CheckedChanged
        Try
            If WieldWeapon.Checked Then
                DDamage.Text = ""
                DDamage.Properties.Enabled = False
                FDamage.Text = ""
                FDamage.Properties.Enabled = False
                TDamage.Text = ""
                TDamage.Properties.Enabled = False
                SDamage.Text = ""
                SDamage.Properties.Enabled = False
                MDamage.Text = ""
                MDamage.Properties.Enabled = False
                LDamage.Text = ""
                LDamage.Properties.Enabled = False
                HDamage.Text = ""
                HDamage.Properties.Enabled = False
                GDamage.Text = ""
                GDamage.Properties.Enabled = False
                CDamage.Text = ""
                CDamage.Properties.Enabled = False
                DamageDropdown.SelectedIndex = -1
                DamageDropdown.Properties.Enabled = False
                Encumberance.Properties.Enabled = False
                Encumberance.SelectedIndex = -1
            Else
                DDamage.Properties.Enabled = True
                FDamage.Properties.Enabled = True
                TDamage.Properties.Enabled = True
                SDamage.Properties.Enabled = True
                MDamage.Properties.Enabled = True
                LDamage.Properties.Enabled = True
                HDamage.Properties.Enabled = True
                GDamage.Properties.Enabled = True
                CDamage.Properties.Enabled = True
                DamageDropdown.Properties.Enabled = True
                If TrainingDropdown.Text = "Shield" Then
                    Encumberance.Properties.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MaxDexCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxDexCheck.CheckedChanged
        If MaxDexCheck.Checked Then
            MaxDexBonus.Properties.Enabled = True
        Else
            MaxDexBonus.Value = 0
            MaxDexBonus.Properties.Enabled = False
        End If
    End Sub

#End Region

End Class
