Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class SpecificWeaponForm
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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents RemoveAbility As System.Windows.Forms.Button
    Public WithEvents AddAbility As System.Windows.Forms.Button
    Public WithEvents BaseWeapon As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AbilityListBox As RPGXplorer.ListBox
    Public WithEvents AbilityDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents DAddAbility As System.Windows.Forms.Button
    Public WithEvents DAbilityDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DAbilityListBox As RPGXplorer.ListBox
    Public WithEvents DRemoveAbility As System.Windows.Forms.Button
    Public WithEvents DLabel3 As System.Windows.Forms.Label
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Dlabel4 As System.Windows.Forms.Label
    Public WithEvents SpecificTab As System.Windows.Forms.TabPage
    Public WithEvents AbilitiesTab As System.Windows.Forms.TabPage
    Public WithEvents DAbilitiesTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents Calculate As System.Windows.Forms.CheckBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents Effective2 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Effective1 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents EnhancementBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Alignment As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents DEffective As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DEnhancementBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MaterialDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents MaterialLabel As System.Windows.Forms.Label
    Public WithEvents DMaterialDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DMaterialLabel As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents NameCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SpecificTab = New System.Windows.Forms.TabPage
        Me.NameCheck = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DMaterialDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DMaterialLabel = New System.Windows.Forms.Label
        Me.MaterialDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.MaterialLabel = New System.Windows.Forms.Label
        Me.Alignment = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Calculate = New System.Windows.Forms.CheckBox
        Me.Effective1 = New RPGXplorer.ReadOnlyTextBox
        Me.EnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.BaseWeapon = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AbilitiesTab = New System.Windows.Forms.TabPage
        Me.Effective2 = New RPGXplorer.ReadOnlyTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.AbilityListBox = New RPGXplorer.ListBox
        Me.RemoveAbility = New System.Windows.Forms.Button
        Me.AddAbility = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.AbilityDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DAbilitiesTab = New System.Windows.Forms.TabPage
        Me.DEnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.DEffective = New RPGXplorer.ReadOnlyTextBox
        Me.Dlabel4 = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.DAbilityListBox = New RPGXplorer.ListBox
        Me.DRemoveAbility = New System.Windows.Forms.Button
        Me.DAddAbility = New System.Windows.Forms.Button
        Me.DLabel3 = New System.Windows.Forms.Label
        Me.DAbilityDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SpecificTab.SuspendLayout()
        CType(Me.DMaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseWeapon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbilitiesTab.SuspendLayout()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DAbilitiesTab.SuspendLayout()
        CType(Me.DEnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 415)
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
        Me.OK.Location = New System.Drawing.Point(280, 415)
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
        Me.TabControl1.Controls.Add(Me.SpecificTab)
        Me.TabControl1.Controls.Add(Me.AbilitiesTab)
        Me.TabControl1.Controls.Add(Me.DAbilitiesTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 385)
        Me.TabControl1.TabIndex = 0
        '
        'SpecificTab
        '
        Me.SpecificTab.Controls.Add(Me.NameCheck)
        Me.SpecificTab.Controls.Add(Me.Label10)
        Me.SpecificTab.Controls.Add(Me.Label9)
        Me.SpecificTab.Controls.Add(Me.DMaterialDropdown)
        Me.SpecificTab.Controls.Add(Me.DMaterialLabel)
        Me.SpecificTab.Controls.Add(Me.MaterialDropdown)
        Me.SpecificTab.Controls.Add(Me.MaterialLabel)
        Me.SpecificTab.Controls.Add(Me.Alignment)
        Me.SpecificTab.Controls.Add(Me.Label8)
        Me.SpecificTab.Controls.Add(Me.Calculate)
        Me.SpecificTab.Controls.Add(Me.Effective1)
        Me.SpecificTab.Controls.Add(Me.EnhancementBonus)
        Me.SpecificTab.Controls.Add(Me.IndentedLine4)
        Me.SpecificTab.Controls.Add(Me.MarketPrice)
        Me.SpecificTab.Controls.Add(Me.Description)
        Me.SpecificTab.Controls.Add(Me.Label21)
        Me.SpecificTab.Controls.Add(Me.IndentedLine1)
        Me.SpecificTab.Controls.Add(Me.BaseWeapon)
        Me.SpecificTab.Controls.Add(Me.Label4)
        Me.SpecificTab.Controls.Add(Me.ObjectName)
        Me.SpecificTab.Controls.Add(Me.Label2)
        Me.SpecificTab.Controls.Add(Me.Label1)
        Me.SpecificTab.Location = New System.Drawing.Point(4, 22)
        Me.SpecificTab.Name = "SpecificTab"
        Me.SpecificTab.Size = New System.Drawing.Size(407, 359)
        Me.SpecificTab.TabIndex = 0
        Me.SpecificTab.Text = "Magic Weapon"
        '
        'NameCheck
        '
        Me.NameCheck.Checked = True
        Me.NameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NameCheck.Location = New System.Drawing.Point(325, 15)
        Me.NameCheck.Name = "NameCheck"
        Me.NameCheck.Size = New System.Drawing.Size(65, 21)
        Me.NameCheck.TabIndex = 361
        Me.NameCheck.Text = "Suggest"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 21)
        Me.Label10.TabIndex = 360
        Me.Label10.Text = "Enhancement"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(195, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 21)
        Me.Label9.TabIndex = 359
        Me.Label9.Text = "Effective Enhancement"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DMaterialDropdown
        '
        Me.DMaterialDropdown.CausesValidation = False
        Me.DMaterialDropdown.Enabled = False
        Me.DMaterialDropdown.Location = New System.Drawing.Point(130, 180)
        Me.DMaterialDropdown.Name = "DMaterialDropdown"
        '
        'DMaterialDropdown.Properties
        '
        Me.DMaterialDropdown.Properties.AutoHeight = False
        Me.DMaterialDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DMaterialDropdown.Properties.DropDownRows = 10
        Me.DMaterialDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DMaterialDropdown.Size = New System.Drawing.Size(200, 21)
        Me.DMaterialDropdown.TabIndex = 357
        '
        'DMaterialLabel
        '
        Me.DMaterialLabel.Location = New System.Drawing.Point(15, 180)
        Me.DMaterialLabel.Name = "DMaterialLabel"
        Me.DMaterialLabel.Size = New System.Drawing.Size(110, 21)
        Me.DMaterialLabel.TabIndex = 358
        Me.DMaterialLabel.Text = "Material (Secondary)"
        Me.DMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialDropdown
        '
        Me.MaterialDropdown.CausesValidation = False
        Me.MaterialDropdown.Location = New System.Drawing.Point(130, 150)
        Me.MaterialDropdown.Name = "MaterialDropdown"
        '
        'MaterialDropdown.Properties
        '
        Me.MaterialDropdown.Properties.AutoHeight = False
        Me.MaterialDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MaterialDropdown.Properties.DropDownRows = 10
        Me.MaterialDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MaterialDropdown.Size = New System.Drawing.Size(200, 21)
        Me.MaterialDropdown.TabIndex = 355
        '
        'MaterialLabel
        '
        Me.MaterialLabel.Location = New System.Drawing.Point(15, 150)
        Me.MaterialLabel.Name = "MaterialLabel"
        Me.MaterialLabel.Size = New System.Drawing.Size(110, 21)
        Me.MaterialLabel.TabIndex = 356
        Me.MaterialLabel.Text = "Material (Primary)"
        Me.MaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alignment
        '
        Me.Alignment.CausesValidation = False
        Me.Alignment.Location = New System.Drawing.Point(130, 240)
        Me.Alignment.Name = "Alignment"
        '
        'Alignment.Properties
        '
        Me.Alignment.Properties.AutoHeight = False
        Me.Alignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Alignment.Properties.DropDownRows = 10
        Me.Alignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Alignment.Size = New System.Drawing.Size(150, 21)
        Me.Alignment.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 354
        Me.Label8.Text = "Alignment"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(15, 290)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(104, 21)
        Me.Calculate.TabIndex = 5
        Me.Calculate.Text = "Calculate Price"
        '
        'Effective1
        '
        Me.Effective1.BackColor = System.Drawing.Color.White
        Me.Effective1.Caption = Nothing
        Me.Effective1.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Effective1.DockPadding.All = 1
        Me.Effective1.ForeColor = System.Drawing.Color.Black
        Me.Effective1.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.Effective1.Location = New System.Drawing.Point(325, 210)
        Me.Effective1.Name = "Effective1"
        Me.Effective1.Size = New System.Drawing.Size(35, 21)
        Me.Effective1.TabIndex = 352
        Me.Effective1.TabStop = False
        Me.Effective1.TextColor = System.Drawing.Color.Black
        Me.Effective1.Vertical = False
        '
        'EnhancementBonus
        '
        Me.EnhancementBonus.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Location = New System.Drawing.Point(130, 210)
        Me.EnhancementBonus.Name = "EnhancementBonus"
        '
        'EnhancementBonus.Properties
        '
        Me.EnhancementBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.EnhancementBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EnhancementBonus.Properties.AutoHeight = False
        Me.EnhancementBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.EnhancementBonus.Properties.DisplayFormat.FormatString = "+0;"
        Me.EnhancementBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.EditFormat.FormatString = "+0;"
        Me.EnhancementBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.IsFloatValue = False
        Me.EnhancementBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EnhancementBonus.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.EnhancementBonus.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Size = New System.Drawing.Size(50, 21)
        Me.EnhancementBonus.TabIndex = 3
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Location = New System.Drawing.Point(15, 275)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 349
        Me.IndentedLine4.TabStop = False
        '
        'MarketPrice
        '
        Me.MarketPrice.Location = New System.Drawing.Point(105, 320)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 6
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(95, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(295, 46)
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 258
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 231
        Me.IndentedLine1.TabStop = False
        '
        'BaseWeapon
        '
        Me.BaseWeapon.Location = New System.Drawing.Point(130, 120)
        Me.BaseWeapon.Name = "BaseWeapon"
        '
        'BaseWeapon.Properties
        '
        Me.BaseWeapon.Properties.AutoHeight = False
        Me.BaseWeapon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BaseWeapon.Properties.DropDownRows = 10
        Me.BaseWeapon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BaseWeapon.Size = New System.Drawing.Size(200, 21)
        Me.BaseWeapon.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 21)
        Me.Label4.TabIndex = 226
        Me.Label4.Text = "Base Item"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ObjectName.Size = New System.Drawing.Size(220, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Market Price"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbilitiesTab
        '
        Me.AbilitiesTab.AccessibleName = ""
        Me.AbilitiesTab.Controls.Add(Me.Effective2)
        Me.AbilitiesTab.Controls.Add(Me.Label3)
        Me.AbilitiesTab.Controls.Add(Me.IndentedLine3)
        Me.AbilitiesTab.Controls.Add(Me.AbilityListBox)
        Me.AbilitiesTab.Controls.Add(Me.RemoveAbility)
        Me.AbilitiesTab.Controls.Add(Me.AddAbility)
        Me.AbilitiesTab.Controls.Add(Me.Label11)
        Me.AbilitiesTab.Controls.Add(Me.AbilityDropdown)
        Me.AbilitiesTab.Location = New System.Drawing.Point(4, 22)
        Me.AbilitiesTab.Name = "AbilitiesTab"
        Me.AbilitiesTab.Size = New System.Drawing.Size(407, 359)
        Me.AbilitiesTab.TabIndex = 1
        Me.AbilitiesTab.Text = "Abilities"
        '
        'Effective2
        '
        Me.Effective2.BackColor = System.Drawing.Color.White
        Me.Effective2.Caption = Nothing
        Me.Effective2.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Effective2.DockPadding.All = 1
        Me.Effective2.ForeColor = System.Drawing.Color.Black
        Me.Effective2.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.Effective2.Location = New System.Drawing.Point(140, 15)
        Me.Effective2.Name = "Effective2"
        Me.Effective2.Size = New System.Drawing.Size(35, 21)
        Me.Effective2.TabIndex = 0
        Me.Effective2.TabStop = False
        Me.Effective2.TextColor = System.Drawing.Color.Black
        Me.Effective2.Vertical = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 21)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = "Effective Enhancement"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 146
        Me.IndentedLine3.TabStop = False
        '
        'AbilityListBox
        '
        Me.AbilityListBox.Location = New System.Drawing.Point(15, 95)
        Me.AbilityListBox.Name = "AbilityListBox"
        Me.AbilityListBox.Size = New System.Drawing.Size(250, 235)
        Me.AbilityListBox.TabIndex = 6
        '
        'RemoveAbility
        '
        Me.RemoveAbility.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAbility.Location = New System.Drawing.Point(280, 125)
        Me.RemoveAbility.Name = "RemoveAbility"
        Me.RemoveAbility.Size = New System.Drawing.Size(110, 24)
        Me.RemoveAbility.TabIndex = 5
        Me.RemoveAbility.Text = "Remove Ability"
        '
        'AddAbility
        '
        Me.AddAbility.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAbility.Location = New System.Drawing.Point(280, 95)
        Me.AddAbility.Name = "AddAbility"
        Me.AddAbility.Size = New System.Drawing.Size(110, 24)
        Me.AddAbility.TabIndex = 4
        Me.AddAbility.Text = "Add Ability"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 21)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "Magic Ability"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbilityDropdown
        '
        Me.AbilityDropdown.CausesValidation = False
        Me.AbilityDropdown.Enabled = False
        Me.AbilityDropdown.Location = New System.Drawing.Point(95, 45)
        Me.AbilityDropdown.Name = "AbilityDropdown"
        '
        'AbilityDropdown.Properties
        '
        Me.AbilityDropdown.Properties.AutoHeight = False
        Me.AbilityDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AbilityDropdown.Properties.DropDownRows = 10
        Me.AbilityDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AbilityDropdown.Size = New System.Drawing.Size(150, 21)
        Me.AbilityDropdown.TabIndex = 3
        '
        'DAbilitiesTab
        '
        Me.DAbilitiesTab.Controls.Add(Me.DEnhancementBonus)
        Me.DAbilitiesTab.Controls.Add(Me.Label7)
        Me.DAbilitiesTab.Controls.Add(Me.DEffective)
        Me.DAbilitiesTab.Controls.Add(Me.Dlabel4)
        Me.DAbilitiesTab.Controls.Add(Me.IndentedLine2)
        Me.DAbilitiesTab.Controls.Add(Me.DAbilityListBox)
        Me.DAbilitiesTab.Controls.Add(Me.DRemoveAbility)
        Me.DAbilitiesTab.Controls.Add(Me.DAddAbility)
        Me.DAbilitiesTab.Controls.Add(Me.DLabel3)
        Me.DAbilitiesTab.Controls.Add(Me.DAbilityDropdown)
        Me.DAbilitiesTab.Location = New System.Drawing.Point(4, 22)
        Me.DAbilitiesTab.Name = "DAbilitiesTab"
        Me.DAbilitiesTab.Size = New System.Drawing.Size(407, 359)
        Me.DAbilitiesTab.TabIndex = 2
        Me.DAbilitiesTab.Text = "Abilities (Double Weapon)"
        '
        'DEnhancementBonus
        '
        Me.DEnhancementBonus.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DEnhancementBonus.Enabled = False
        Me.DEnhancementBonus.Location = New System.Drawing.Point(140, 15)
        Me.DEnhancementBonus.Name = "DEnhancementBonus"
        '
        'DEnhancementBonus.Properties
        '
        Me.DEnhancementBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.DEnhancementBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DEnhancementBonus.Properties.AutoHeight = False
        Me.DEnhancementBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DEnhancementBonus.Properties.DisplayFormat.FormatString = "+0;0;0"
        Me.DEnhancementBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DEnhancementBonus.Properties.EditFormat.FormatString = "+0;0;0"
        Me.DEnhancementBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DEnhancementBonus.Properties.IsFloatValue = False
        Me.DEnhancementBonus.Properties.Mask.EditMask = "N00"
        Me.DEnhancementBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DEnhancementBonus.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.DEnhancementBonus.Size = New System.Drawing.Size(50, 21)
        Me.DEnhancementBonus.TabIndex = 348
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 21)
        Me.Label7.TabIndex = 347
        Me.Label7.Text = "Enhancement"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DEffective
        '
        Me.DEffective.BackColor = System.Drawing.Color.White
        Me.DEffective.Caption = Nothing
        Me.DEffective.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.DEffective.DockPadding.All = 1
        Me.DEffective.ForeColor = System.Drawing.Color.Black
        Me.DEffective.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.DEffective.Location = New System.Drawing.Point(140, 45)
        Me.DEffective.Name = "DEffective"
        Me.DEffective.Size = New System.Drawing.Size(35, 21)
        Me.DEffective.TabIndex = 2
        Me.DEffective.TabStop = False
        Me.DEffective.TextColor = System.Drawing.Color.Black
        Me.DEffective.Vertical = False
        '
        'Dlabel4
        '
        Me.Dlabel4.BackColor = System.Drawing.SystemColors.Control
        Me.Dlabel4.Enabled = False
        Me.Dlabel4.Location = New System.Drawing.Point(15, 45)
        Me.Dlabel4.Name = "Dlabel4"
        Me.Dlabel4.Size = New System.Drawing.Size(130, 21)
        Me.Dlabel4.TabIndex = 249
        Me.Dlabel4.Text = "Effective Enhancement"
        Me.Dlabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 246
        Me.IndentedLine2.TabStop = False
        '
        'DAbilityListBox
        '
        Me.DAbilityListBox.Enabled = False
        Me.DAbilityListBox.Location = New System.Drawing.Point(15, 125)
        Me.DAbilityListBox.Name = "DAbilityListBox"
        Me.DAbilityListBox.Size = New System.Drawing.Size(250, 205)
        Me.DAbilityListBox.TabIndex = 6
        '
        'DRemoveAbility
        '
        Me.DRemoveAbility.Enabled = False
        Me.DRemoveAbility.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRemoveAbility.Location = New System.Drawing.Point(280, 155)
        Me.DRemoveAbility.Name = "DRemoveAbility"
        Me.DRemoveAbility.Size = New System.Drawing.Size(110, 24)
        Me.DRemoveAbility.TabIndex = 5
        Me.DRemoveAbility.Text = "Remove Ability"
        '
        'DAddAbility
        '
        Me.DAddAbility.Enabled = False
        Me.DAddAbility.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAddAbility.Location = New System.Drawing.Point(280, 125)
        Me.DAddAbility.Name = "DAddAbility"
        Me.DAddAbility.Size = New System.Drawing.Size(110, 24)
        Me.DAddAbility.TabIndex = 4
        Me.DAddAbility.Text = "Add Ability"
        '
        'DLabel3
        '
        Me.DLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.DLabel3.Enabled = False
        Me.DLabel3.Location = New System.Drawing.Point(15, 75)
        Me.DLabel3.Name = "DLabel3"
        Me.DLabel3.Size = New System.Drawing.Size(75, 21)
        Me.DLabel3.TabIndex = 244
        Me.DLabel3.Text = "Magic Ability"
        Me.DLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DAbilityDropdown
        '
        Me.DAbilityDropdown.CausesValidation = False
        Me.DAbilityDropdown.Enabled = False
        Me.DAbilityDropdown.Location = New System.Drawing.Point(95, 75)
        Me.DAbilityDropdown.Name = "DAbilityDropdown"
        '
        'DAbilityDropdown.Properties
        '
        Me.DAbilityDropdown.Properties.AutoHeight = False
        Me.DAbilityDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DAbilityDropdown.Properties.DropDownRows = 10
        Me.DAbilityDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DAbilityDropdown.Size = New System.Drawing.Size(150, 21)
        Me.DAbilityDropdown.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 359)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Properties"
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
        'SpecificWeaponForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 453)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SpecificWeaponForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specific Weapon"
        Me.TabControl1.ResumeLayout(False)
        Me.SpecificTab.ResumeLayout(False)
        CType(Me.DMaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseWeapon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbilitiesTab.ResumeLayout(False)
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DAbilitiesTab.ResumeLayout(False)
        CType(Me.DEnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private BaseWeaponDataList() As DataListItem
    Private AbilityDataList() As DataListItem

    Private ExistingAbilities As New Objects.ObjectDataCollection
    Private CurrentAbilities As New Objects.ObjectDataCollection

    'Lists for Double Weapon Abilities
    Private DExistingAbilities As New Objects.ObjectDataCollection
    Private DCurrentAbilities As New Objects.ObjectDataCollection

    Private AbilityEnhancement As Integer
    Private DAbilityEnhancement As Integer

    'init
    Public Sub Init()
        Dim Exclusions As New ArrayList

        Try
            'Load Datalists
            BaseWeaponDataList = Rules.Index.DataList(Xml.DBTypes.Weapons, Objects.WeaponDefinitionType)
            If mMode = FormMode.Edit Then
                For Each Condition As Objects.ObjectData In mObject.ChildrenOfType(Objects.ConditionType)
                    For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                        Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbilityDefinition"))
                    Next
                Next
            End If

            AbilityDataList = Rules.Index.DataListExclude(Xml.DBTypes.WeaponMagicAbilities, Objects.WeaponMagicAbilityDefinitionType, Exclusions)
            Alignment.Properties.Items.Add("")
            Alignment.Properties.Items.AddRange(Rules.Lists.AlignmentAxis)

            'Populate ComoBoxes
            BaseWeapon.Properties.Items.AddRange(BaseWeaponDataList)

            MarketPrice.MaxGP = 999999

            'init propertiesTab
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.MagicWeapons)
            mObject.Type = Objects.SpecificWeaponDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Magic Weapon"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            UpdateEnhancement()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData
        Dim WeaponObj As Objects.ObjectData
        Dim MaterialKey As Objects.ObjectKey

        Try
            mObject = Obj
            mMode = FormMode.Edit
            Me.Text = "Edit Magic Weapon"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            ObjectName.Text = Obj.Name
            Description.Text = Obj.Element("Description")

            If Obj.Element("Suggest") = "Yes" Then NameCheck.Checked = True Else NameCheck.Checked = False
            BaseWeapon.SelectedIndex = Rules.Index.GetNameIndex(BaseWeaponDataList, Obj.Element("Weapon"))
            MarketPrice.Value = mObject.Element("MarketPrice")
            EnhancementBonus.Value = mObject.ElementAsInteger("EnhancementBonus")

            MaterialKey = mObject.GetFKGuid("Material")
            If MaterialKey.IsNotEmpty Then
                For Each Item As DataListItem In MaterialDropdown.Properties.Items()
                    If Item.ObjectGUID.Equals(MaterialKey) Then
                        MaterialDropdown.SelectedItem = Item
                    End If
                Next
            End If

            MaterialKey = mObject.GetFKGuid("DMaterial")
            If MaterialKey.IsNotEmpty Then
                For Each Item As DataListItem In DMaterialDropdown.Properties.Items()
                    If Item.ObjectGUID.Equals(MaterialKey) Then
                        DMaterialDropdown.SelectedItem = Item
                    End If
                Next
            End If

            WeaponObj = Obj.GetFKObject("Weapon")
            If WeaponObj.Element("Double") = "Yes" Then
                DEnhancementBonus.Value = mObject.ElementAsInteger("DEnhancementBonus")
            End If

            Alignment.Text = mObject.Element("Alignment")

            ExistingAbilities = mObject.ChildrenOfType(Objects.SpecificWeaponAbilityType)
            For Each Child In ExistingAbilities
                CurrentAbilities.Add(Child)
                AbilityListBox.AddItem(Child.Name, Child.ObjectGUID)
                AbilityEnhancement += Child.GetFKObject("WeaponMagicAbility").ElementAsInteger("PriceBonus")
            Next


            DExistingAbilities = mObject.ChildrenOfType(Objects.SpecificWeaponDoubleAbilityType)
            For Each Child In DExistingAbilities
                DCurrentAbilities.Add(Child)
                DAbilityListBox.AddItem(Child.Name, Child.ObjectGUID)
                DAbilityEnhancement += Child.GetFKObject("WeaponMagicAbility").ElementAsInteger("PriceBonus")
            Next

            UpdateEnhancement()

            If mObject.Element("Calculate") = "Yes" Then Calculate.Checked = True


        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As Objects.ObjectData

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        'do nothing yet
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("Description") = Description.Text

                If Not BaseWeapon.Text = "" Then
                    mObject.FKElement("Weapon", BaseWeapon.Text, "Name", CType(BaseWeapon.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.FKSetNull("Weapon")
                End If

                If MaterialDropdown.SelectedIndex > 0 Then
                    mObject.FKElement("Material", MaterialDropdown.Text, "Name", CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                If DMaterialDropdown.SelectedIndex > 0 Then
                    mObject.FKElement("DMaterial", DMaterialDropdown.Text, "Name", CType(DMaterialDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                If NameCheck.Checked Then mObject.Element("Suggest") = "Yes" Else mObject.Element("Suggest") = "No"
                If Calculate.Checked Then mObject.Element("Calculate") = "Yes" Else mObject.Element("Calculate") = "No"
                mObject.Element("MarketPrice") = MarketPrice.Value
                mObject.Element("EnhancementBonus") = EnhancementBonus.Text
                mObject.Element("Alignment") = Alignment.Text

                For Each Obj In ExistingAbilities
                    If Not CurrentAbilities.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                For Each Obj In CurrentAbilities
                    If ExistingAbilities.Contains(Obj.ObjectGUID) Then CurrentAbilities.Remove(Obj.ObjectGUID)
                Next
                CurrentAbilities.Save()

                mObject.Element("DEnhancementBonus") = DEnhancementBonus.Text
                For Each Obj In DExistingAbilities
                    If Not DCurrentAbilities.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                For Each Obj In DCurrentAbilities
                    If DExistingAbilities.Contains(Obj.ObjectGUID) Then DCurrentAbilities.Remove(Obj.ObjectGUID)
                Next
                DCurrentAbilities.Save()

                'combined enhancement
                If DEnhancementBonus.Enabled = True Then
                    mObject.Element("EnhancementDisplay") = EnhancementBonus.Text & "/" & DEnhancementBonus.Text
                Else
                    mObject.Element("EnhancementDisplay") = EnhancementBonus.Text
                End If

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.TreeView.BeginUpdate()

                    Dim CurrentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ObjectGUID), TreeNode)
                    If Not CurrentNode Is Nothing Then CurrentNode.Remove()
                    Dim ParentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode)
                    Dim NewNode As TreeNode = General.MainExplorer.CompleteNodeFromObject(mObject)
                    General.MainExplorer.InsertNode(ParentNode, NewNode)

                    General.MainExplorer.TreeView.EndUpdate()
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
            Validate = General.ValidateForm(SpecificTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(AbilitiesTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(DAbilitiesTab.Controls, Errors)

            If MarketPrice.Money.InCopper = 0 Then
                Errors.SetError(MarketPrice, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(MarketPrice, "")
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

#Region "Magic Weapon Tab"

    'Update the effective enhancement when the enhancement is changed
    Private Sub EnhancementBonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancementBonus.EditValueChanged
        Dim Enhancement As Integer
        Try

            Enhancement = Integer.Parse(EnhancementBonus.Text) + AbilityEnhancement

            If Enhancement > 10 Then
                EnhancementBonus.Value -= 1
            Else
                UpdateEnhancement()
                If Calculate.Checked Then CalculatePrice()
                If NameCheck.Checked Then GenerateName()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Update the effective enhancement when the enhancement is changed (Double Weapon)
    Private Sub DEnhancementBonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEnhancementBonus.EditValueChanged
        Dim DEnhancement As Integer
        Try
            'reset double list if the enhancement bonus is removed
            If DEnhancementBonus.Value = 0 Then

                DAbilityDropdown.SelectedIndex = -1
                EnableDoubleAbilities(False)

                'remove all abilities
                For Each Ability As Objects.ObjectData In DCurrentAbilities
                    Dim AbilityObj As Objects.ObjectData = Ability.GetFKObject("WeaponMagicAbility")
                    DCurrentAbilities.Remove(Ability.ObjectGUID)
                    DAbilityListBox.RemoveItem(Ability.Name)
                    DAbilityEnhancement -= AbilityObj.ElementAsInteger("PriceBonus")
                Next

                UpdateEnhancement()
                If Calculate.Checked Then CalculatePrice()
                If NameCheck.Checked Then GenerateName()

            Else

                EnableDoubleAbilities(True)
                DEnhancement = Integer.Parse(DEnhancementBonus.Text) + DAbilityEnhancement
                If DEnhancement > 10 Then
                    DEnhancementBonus.Value -= 1
                Else
                    UpdateEnhancement()
                    If Calculate.Checked Then CalculatePrice()
                    If NameCheck.Checked Then GenerateName()
                End If

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Abilities Tab"

    'Add Ability to the weapon (Primary Head)
    Private Sub AddAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAbility.Click
        Dim Obj As Objects.ObjectData
        Dim AbilityDef As New Objects.ObjectData
        Dim Effective As Integer

        Try
            If AbilityDropdown.SelectedIndex = -1 Then Exit Sub

            If Not CurrentAbilities.ContainsFK("WeaponMagicAbility", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID) Then

                Obj = ExistingAbilities.Item("WeaponMagicAbility", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.Name = AbilityDropdown.Text
                    Obj.Type = Objects.SpecificWeaponAbilityType
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.MagicWeapons)
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.FKElement("WeaponMagicAbility", AbilityDropdown.Text, "Name", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                'update the enhancement
                AbilityDef.Load(CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                Select Case AbilityDef.Element("PriceType")
                    Case "Specific"
                        AbilityListBox.AddItem(Obj.Name, Obj.ObjectGUID)
                        CurrentAbilities.Add(Obj)

                    Case Else
                        Effective = Integer.Parse(EnhancementBonus.Text) + AbilityEnhancement + AbilityDef.ElementAsInteger("PriceBonus")
                        If Effective > 10 Then
                            General.ShowInfoDialog("Effective enhancement cannot exceed +10")
                        Else
                            AbilityListBox.AddItem(Obj.Name, Obj.ObjectGUID)
                            CurrentAbilities.Add(Obj)
                            AbilityEnhancement += AbilityDef.ElementAsInteger("PriceBonus")
                            UpdateEnhancement()
                        End If
                End Select

                If Calculate.Checked Then CalculatePrice()
                If NameCheck.Checked Then GenerateName()
            Else
                General.ShowInfoDialog("This ability is already in the list.")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Remove Ability from the weapon (Primary Head)
    Private Sub RemoveAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAbility.Click
        Dim Obj As Objects.ObjectData

        Try
            If AbilityListBox.List.SelectedItem Is Nothing Then Exit Sub
            Obj = CurrentAbilities.Item(AbilityListBox.ItemGUID).GetFKObject("WeaponMagicAbility")
            Select Case Obj.Element("PriceType")
                Case "Specific"
                    'do nothing
                Case Else
                    AbilityEnhancement -= Obj.ElementAsInteger("PriceBonus")
            End Select
            UpdateEnhancement()
            CurrentAbilities.Remove(AbilityListBox.ItemGUID)
            AbilityListBox.RemoveSelectedItem()
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Returns True if the ability can legaly be placed on specified weapon (Primary Head)
    Private Function CheckAbilityAgainstWeapon(ByVal WeaponObj As Objects.ObjectData, ByVal AbilityObj As Objects.ObjectData) As Boolean
        Dim S, P, B As Boolean
        Dim OK As Boolean = True

        Try
            Select Case AbilityObj.Element("WeaponType")
                Case "Melee Weapons Only"
                    If Not WeaponObj.Element("WeaponType") = "Melee" Then OK = False
                Case "Melee, Thrown and Ammo Only"
                    If WeaponObj.Element("WeaponType") = "Ranged" Then OK = False
                Case "Ranged Weapons Only"
                    If Not WeaponObj.Element("WeaponType") = "Ranged" Then OK = False
                Case "Thrown Weapons Only"
                    If Not WeaponObj.Element("Thrown") = "Yes" Then OK = False
                Case "Ammunition Only"
                    OK = False
            End Select

            If OK Then
                If WeaponObj.Element("DamageType1") = "Slashing" Or WeaponObj.Element("DamageType2") = "Slashing" Then S = True
                If WeaponObj.Element("DamageType1") = "Piercing" Or WeaponObj.Element("DamageType2") = "Piercing" Then P = True
                If WeaponObj.Element("DamageType1") = "Bludgeoning" Or WeaponObj.Element("DamageType2") = "Bludgeoning" Then B = True

                If Not ((AbilityObj.Element("Slashing") = "Yes" And S) Or (AbilityObj.Element("Piercing") = "Yes" And P) Or (AbilityObj.Element("Bludgeoning") = "Yes" And B)) Then OK = False
            End If

            Return OK

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Removes already selected abilities if they are no longer valid (Primary Head)
    Private Sub UpdateAbilitiesList(ByVal WeaponObj As Objects.ObjectData)
        Dim AbilityObj As Objects.ObjectData

        Try
            For Each Ability As Objects.ObjectData In CurrentAbilities
                AbilityObj = Ability.GetFKObject("WeaponMagicAbility")

                If Not CheckAbilityAgainstWeapon(WeaponObj, AbilityObj) Then
                    CurrentAbilities.Remove(Ability.ObjectGUID)
                    AbilityListBox.RemoveItem(Ability.Name)
                    AbilityEnhancement -= AbilityObj.ElementAsInteger("PriceBonus")
                End If
            Next

            UpdateEnhancement()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Double Weapon Abilities"

    'Add Ability to the weapon (Secondary Head)
    Private Sub DAddAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAddAbility.Click
        Dim Obj As Objects.ObjectData
        Dim AbilityDef As New Objects.ObjectData
        Dim Effective As Integer

        Try
            If DAbilityDropdown.SelectedIndex = -1 Then Exit Sub

            If Not DCurrentAbilities.ContainsFK("WeaponMagicAbility", CType(DAbilityDropdown.SelectedItem, DataListItem).ObjectGUID) Then

                Obj = DExistingAbilities.Item("WeaponMagicAbility", CType(DAbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.Name = DAbilityDropdown.Text
                    Obj.Type = Objects.SpecificWeaponDoubleAbilityType
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.MagicWeapons)
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.FKElement("WeaponMagicAbility", DAbilityDropdown.Text, "Name", CType(DAbilityDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                'update the enhancement
                AbilityDef.Load(CType(DAbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                Select Case AbilityDef.Element("PriceType")
                    Case "Specific"
                        DAbilityListBox.AddItem(Obj.Name, Obj.ObjectGUID)
                        DCurrentAbilities.Add(Obj)

                    Case Else
                        Effective = Integer.Parse(DEnhancementBonus.Text) + DAbilityEnhancement + AbilityDef.ElementAsInteger("PriceBonus")
                        If Effective > 10 Then
                            General.ShowInfoDialog("Effective enhancement cannot exceed +10")
                        Else
                            DAbilityListBox.AddItem(Obj.Name, Obj.ObjectGUID)
                            DCurrentAbilities.Add(Obj)
                            DAbilityEnhancement += AbilityDef.ElementAsInteger("PriceBonus")
                            UpdateEnhancement()
                        End If
                End Select

                If Calculate.Checked Then CalculatePrice()
                If NameCheck.Checked Then GenerateName()
            Else
                General.ShowInfoDialog("This ability is already in the list.")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Remove Ability from the weapon (Secondary Head)
    Private Sub DRemoveAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DRemoveAbility.Click
        Dim Obj As Objects.ObjectData

        Try
            If DAbilityListBox.List.SelectedItem Is Nothing Then Exit Sub

            Obj = DCurrentAbilities.Item(DAbilityListBox.ItemGUID).GetFKObject("WeaponMagicAbility")
            Select Case Obj.Element("PriceType")
                Case "Specific"
                    'do nothing
                Case Else
                    DAbilityEnhancement -= Obj.ElementAsInteger("PriceBonus")
            End Select
            UpdateEnhancement()
            DCurrentAbilities.Remove(DAbilityListBox.ItemGUID)
            DAbilityListBox.RemoveSelectedItem()
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Returns True if the ability can legaly be placed on specified weapon (Secondary Head)
    Private Function DCheckAbilityAgainstWeapon(ByVal WeaponObj As Objects.ObjectData, ByVal AbilityObj As Objects.ObjectData) As Boolean
        Dim S, P, B As Boolean
        Dim OK As Boolean = True

        Try
            Select Case AbilityObj.Element("WeaponType")
                Case "Melee Weapons Only"
                    If Not WeaponObj.Element("WeaponType") = "Melee" Then OK = False
                Case "Melee, Thrown and Ammo Only"
                    If WeaponObj.Element("WeaponType") = "Ranged" Then OK = False
                Case "Ranged Weapons Only"
                    If Not WeaponObj.Element("WeaponType") = "Ranged" Then OK = False
                Case "Thrown Weapons Only"
                    If Not WeaponObj.Element("Thrown") = "Yes" Then OK = False
                Case "Ammunition Only"
                    OK = False
            End Select

            If OK Then
                If WeaponObj.Element("DDamageType1") = "Slashing" Or WeaponObj.Element("DDamageType2") = "Slashing" Then S = True
                If WeaponObj.Element("DDamageType1") = "Piercing" Or WeaponObj.Element("DDamageType2") = "Piercing" Then P = True
                If WeaponObj.Element("DDamageType1") = "Bludgeoning" Or WeaponObj.Element("DDamageType2") = "Bludgeoning" Then B = True

                If Not ((AbilityObj.Element("Slashing") = "Yes" And S) Or (AbilityObj.Element("Piercing") = "Yes" And P) Or (AbilityObj.Element("Bludgeoning") = "Yes" And B)) Then OK = False
            End If

            Return OK

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Removes already selected abilities if they are no longer valid (Secondary Head)
    Private Sub DUpdateAbilitiesList(ByVal WeaponObj As Objects.ObjectData)
        Dim AbilityObj As Objects.ObjectData

        Try
            For Each Ability As Objects.ObjectData In DCurrentAbilities
                AbilityObj = Ability.GetFKObject("WeaponMagicAbility")

                If WeaponObj.Element("Double") = "Yes" Then
                    If Not DCheckAbilityAgainstWeapon(WeaponObj, AbilityObj) Then
                        DCurrentAbilities.Remove(Ability.ObjectGUID)
                        DAbilityListBox.RemoveItem(Ability.ObjectGUID)
                        DAbilityEnhancement -= AbilityObj.ElementAsInteger("PriceBonus")
                    End If
                Else
                    DCurrentAbilities.Remove(Ability.ObjectGUID)
                    DAbilityListBox.RemoveItem(Ability.Name)
                    DAbilityEnhancement -= AbilityObj.ElementAsInteger("PriceBonus")
                End If
            Next

            UpdateEnhancement()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Cost and Enhancement"

    'Update the effective enhancement
    Private Sub UpdateEnhancement()
        Dim Enhancement As Integer
        Dim DEnhancement As Integer
        Try
            Enhancement = Integer.Parse(EnhancementBonus.Text) + AbilityEnhancement
            DEnhancement = Integer.Parse(DEnhancementBonus.Text) + DAbilityEnhancement

            If Enhancement > 0 Then
                Effective1.Text = "+" & Enhancement
                Effective2.Text = "+" & Enhancement
            Else
                Effective1.Text = "0"
                Effective2.Text = "0"
            End If

            If DEnhancement > 0 Then
                DEffective.Text = "+" & DEnhancement
            Else
                DEffective.Text = "0"
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'determine the price of the weapon
    Private Sub CalculatePrice()
        Dim Weapon As New Objects.ObjectData
        Dim AbilityDef As Objects.ObjectData
        Dim Price As Money
        Dim PrimaryMaterialKey, SecondaryMaterialKey As Objects.ObjectKey

        Try
            If BaseWeapon.SelectedIndex = -1 Then Exit Sub

            'get base weapon
            If MaterialDropdown.SelectedIndex > 0 Then
                PrimaryMaterialKey = CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID
            End If

            If DMaterialDropdown.SelectedIndex > 0 Then
                SecondaryMaterialKey = CType(DMaterialDropdown.SelectedItem, DataListItem).ObjectGUID
            End If

            Weapon.Load(CType(BaseWeapon.SelectedItem, DataListItem).ObjectGUID)
            Price = Rules.Items.EnhancedPrice(Weapon, "Medium", PrimaryMaterialKey, SecondaryMaterialKey, Integer.Parse(Effective1.Text), Integer.Parse(DEffective.Text))

            'get any specific cost increases
            For Each SpecialAbility As Objects.ObjectData In CurrentAbilities
                AbilityDef = SpecialAbility.GetFKObject("WeaponMagicAbility")
                If AbilityDef.Element("PriceType") = "Specific" Then Price.AddMoney(AbilityDef.Element("PriceBonus"))
            Next
            For Each SpecialAbility As Objects.ObjectData In DCurrentAbilities
                AbilityDef = SpecialAbility.GetFKObject("WeaponMagicAbility")
                If AbilityDef.Element("PriceType") = "Specific" Then Price.AddMoney(AbilityDef.Element("PriceBonus"))
            Next

            MarketPrice.Money = Price

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

    'Load the AdilityDropdowns with the legal ability choices, Remove any abilities that are no longer valid
    Private Sub BaseWeapon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseWeapon.SelectedIndexChanged
        Dim tempitem As DataListItem
        Dim AbilityObj, WeaponObj As Objects.ObjectData

        Try
            AbilityDropdown.SelectedIndex = -1
            AbilityDropdown.Properties.Items.Clear()
            AbilityDropdown.Properties.Enabled = True

            DAbilityDropdown.SelectedIndex = -1
            DAbilityDropdown.Properties.Items.Clear()

            MaterialDropdown.Properties.Items.Clear()
            DMaterialDropdown.Properties.Items.Clear()

            WeaponObj = CType(BaseWeaponDataList(BaseWeapon.SelectedIndex).ValueMember, Objects.ObjectData)
            If WeaponObj.Element("Double") = "Yes" Then
                EnableDoubleEnhancement(True)

                'update the Dropdown and List for double weapons
                WeaponObj = CType(BaseWeaponDataList(BaseWeapon.SelectedIndex).ValueMember, Objects.ObjectData)
                For Each tempitem In AbilityDataList
                    AbilityObj = CType(tempitem.ValueMember, Objects.ObjectData)
                    If DCheckAbilityAgainstWeapon(WeaponObj, AbilityObj) Then
                        DAbilityDropdown.Properties.Items.Add(tempitem)
                    End If
                Next
            Else
                EnableDoubleEnhancement(False)
            End If

            'Update AbilityDropDown (Or Primary Dropdown for Double Weapons)
            For Each tempitem In AbilityDataList
                AbilityObj = CType(tempitem.ValueMember, Objects.ObjectData)
                If CheckAbilityAgainstWeapon(WeaponObj, AbilityObj) Then
                    AbilityDropdown.Properties.Items.Add(tempitem)
                End If
            Next

            'Update the AbilityLists
            UpdateAbilitiesList(WeaponObj)

            'Update the DAbilityLists
            DUpdateAbilitiesList(WeaponObj)

            'is this new item compatible with the currently selected material?
            Dim TempDatalist As DataListItem() = Rules.Index.DataList(Rules.SpecialMaterial.CompatibleMaterials(WeaponObj), True)

            MaterialDropdown.Properties.Items.AddRange(TempDatalist)
            DMaterialDropdown.Properties.Items.AddRange(TempDatalist)
            If MaterialDropdown.SelectedIndex < 0 Then MaterialDropdown.SelectedIndex = 0
            If DMaterialDropdown.SelectedIndex < 0 Then DMaterialDropdown.SelectedIndex = 0

            'set icon name
            If mMode = FormMode.Add Then
                PropertiesTab.ImageFilename.Text = WeaponObj.ImageFilename
            End If

            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Enable/Disable the enhancement controls for double weapons
    Private Sub EnableDoubleEnhancement(ByVal value As Boolean)
        Try
            Label7.Enabled = value
            DEnhancementBonus.Enabled = value
            DMaterialDropdown.Enabled = value

            If value = False Then
                DEnhancementBonus.Value = 0
                DMaterialDropdown.SelectedIndex = 0
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Enable/Disable the ability controls for double weapons
    Private Sub EnableDoubleAbilities(ByVal value As Boolean)
        Try
            DLabel3.Enabled = value
            Dlabel4.Enabled = value
            DAbilityDropdown.Properties.Enabled = value
            DAbilityListBox.Enabled = value
            DAddAbility.Enabled = value
            DRemoveAbility.Enabled = value
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the price
    Private Sub Calculate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.CheckedChanged
        Try
            If Calculate.Checked Then
                MarketPrice.Enabled = False
                CalculatePrice()
            Else
                MarketPrice.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    Private Sub MaterialDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialDropdown.SelectedIndexChanged
        Try
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DMaterialDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DMaterialDropdown.SelectedIndexChanged
        Try
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub NameCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameCheck.CheckedChanged
        If NameCheck.Checked = True Then
            GenerateName()
        End If
    End Sub

    Private Sub GenerateName()
        Dim NameString As String = ""

        If BaseWeapon.Text = "" Then
            ObjectName.Text = NameString
            Exit Sub
        End If

        NameString = EnhancementBonus.Text & " "
        If MaterialDropdown.Text <> "" Then NameString &= MaterialDropdown.Text & ", "

        'primary abilities
        Dim PAbilityList As New ArrayList
        For Each TempObject As Objects.ObjectData In CurrentAbilities
            PAbilityList.Add(TempObject.Name)
        Next
        PAbilityList.Sort()

        For Each TempString As String In PAbilityList
            NameString &= TempString & ", "
        Next

        'remove last ", "
        NameString = NameString.TrimEnd(", ".ToCharArray)

        'do double weapon stuff is requires
        If DMaterialDropdown.Enabled Then
            NameString &= " / "

            If DEnhancementBonus.Value > 0 Then
                NameString &= DEnhancementBonus.Text & " "
            Else
                NameString &= "+0 "
            End If

            If DMaterialDropdown.Text <> "" Then NameString &= DMaterialDropdown.Text & ", "

            'secondary abilities
            Dim SAbilityList As New ArrayList
            For Each TempObject As Objects.ObjectData In DCurrentAbilities
                SAbilityList.Add(TempObject.Name)
            Next
            SAbilityList.Sort()
            For Each TempString As String In SAbilityList
                NameString &= TempString & ", "
            Next

            NameString = NameString.TrimEnd(", ".ToCharArray)
        End If

        NameString &= " " & BaseWeapon.Text
        ObjectName.Text = NameString
    End Sub


End Class