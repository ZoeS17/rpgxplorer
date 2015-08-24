Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports System.xml
Imports RPGXplorer.Rules.Dice

Public Class NaturalWeaponForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents NameLabel As System.Windows.Forms.Label
    Public WithEvents TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents WeaponTab As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Damage As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents JunctionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageDropdown2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageDropdown1 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents DivideLabel As System.Windows.Forms.Label
    Public WithEvents ThreatRange As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Multiplier As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ThreatRangeLabel As System.Windows.Forms.Label
    Public WithEvents ExtraDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents NameCheck As System.Windows.Forms.CheckBox
    Public WithEvents RangeSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents RangeLabel As System.Windows.Forms.Label
    Public WithEvents RangedCheck As System.Windows.Forms.CheckBox
    Public WithEvents Increments As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IncrementsLabel As System.Windows.Forms.Label
    Public WithEvents MaxLabel As System.Windows.Forms.Label
    Public WithEvents SpinEdit1d As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ReadOnlyTextBox1 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents MaxRange As RPGXplorer.ReadOnlyTextBox
    Public WithEvents AttackDropdown As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.WeaponTab = New System.Windows.Forms.TabPage
        Me.MaxRange = New RPGXplorer.ReadOnlyTextBox
        Me.MaxLabel = New System.Windows.Forms.Label
        Me.Increments = New DevExpress.XtraEditors.SpinEdit
        Me.IncrementsLabel = New System.Windows.Forms.Label
        Me.RangeSpin = New DevExpress.XtraEditors.SpinEdit
        Me.RangeLabel = New System.Windows.Forms.Label
        Me.RangedCheck = New System.Windows.Forms.CheckBox
        Me.NameCheck = New System.Windows.Forms.CheckBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.ExtraDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.JunctionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageDropdown2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageDropdown1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AttackDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ThreatRangeLabel = New System.Windows.Forms.Label
        Me.ThreatRange = New DevExpress.XtraEditors.SpinEdit
        Me.Multiplier = New DevExpress.XtraEditors.SpinEdit
        Me.DivideLabel = New System.Windows.Forms.Label
        Me.Damage = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ReadOnlyTextBox1 = New RPGXplorer.ReadOnlyTextBox
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SpinEdit1d = New DevExpress.XtraEditors.SpinEdit
        Me.TabControl1.SuspendLayout()
        Me.WeaponTab.SuspendLayout()
        CType(Me.Increments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtraDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageDropdown2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageDropdown1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttackDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThreatRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Multiplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Damage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1d.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.WeaponTab)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 440)
        Me.TabControl1.TabIndex = 0
        '
        'WeaponTab
        '
        Me.WeaponTab.Controls.Add(Me.MaxRange)
        Me.WeaponTab.Controls.Add(Me.MaxLabel)
        Me.WeaponTab.Controls.Add(Me.Increments)
        Me.WeaponTab.Controls.Add(Me.IncrementsLabel)
        Me.WeaponTab.Controls.Add(Me.RangeSpin)
        Me.WeaponTab.Controls.Add(Me.RangeLabel)
        Me.WeaponTab.Controls.Add(Me.RangedCheck)
        Me.WeaponTab.Controls.Add(Me.NameCheck)
        Me.WeaponTab.Controls.Add(Me.IndentedLine1)
        Me.WeaponTab.Controls.Add(Me.ExtraDamage)
        Me.WeaponTab.Controls.Add(Me.Label3)
        Me.WeaponTab.Controls.Add(Me.JunctionDropdown)
        Me.WeaponTab.Controls.Add(Me.DamageDropdown2)
        Me.WeaponTab.Controls.Add(Me.DamageDropdown1)
        Me.WeaponTab.Controls.Add(Me.Label2)
        Me.WeaponTab.Controls.Add(Me.Label1)
        Me.WeaponTab.Controls.Add(Me.AttackDropdown)
        Me.WeaponTab.Controls.Add(Me.ThreatRangeLabel)
        Me.WeaponTab.Controls.Add(Me.ThreatRange)
        Me.WeaponTab.Controls.Add(Me.Multiplier)
        Me.WeaponTab.Controls.Add(Me.DivideLabel)
        Me.WeaponTab.Controls.Add(Me.Damage)
        Me.WeaponTab.Controls.Add(Me.Label9)
        Me.WeaponTab.Controls.Add(Me.ObjectName)
        Me.WeaponTab.Controls.Add(Me.NameLabel)
        Me.WeaponTab.Location = New System.Drawing.Point(4, 22)
        Me.WeaponTab.Name = "WeaponTab"
        Me.WeaponTab.Size = New System.Drawing.Size(407, 414)
        Me.WeaponTab.TabIndex = 0
        Me.WeaponTab.Text = "Weapon"
        '
        'MaxRange
        '
        Me.MaxRange.BackColor = System.Drawing.Color.White
        Me.MaxRange.Caption = Nothing
        Me.MaxRange.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MaxRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaxRange.ForeColor = System.Drawing.Color.Black
        Me.MaxRange.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MaxRange.Location = New System.Drawing.Point(270, 225)
        Me.MaxRange.Name = "MaxRange"
        Me.MaxRange.Padding = New System.Windows.Forms.Padding(1)
        Me.MaxRange.Size = New System.Drawing.Size(60, 21)
        Me.MaxRange.TabIndex = 280
        Me.MaxRange.TabStop = False
        Me.MaxRange.TextColor = System.Drawing.Color.Black
        Me.MaxRange.Vertical = False
        '
        'MaxLabel
        '
        Me.MaxLabel.BackColor = System.Drawing.SystemColors.Control
        Me.MaxLabel.Enabled = False
        Me.MaxLabel.Location = New System.Drawing.Point(170, 225)
        Me.MaxLabel.Name = "MaxLabel"
        Me.MaxLabel.Size = New System.Drawing.Size(105, 21)
        Me.MaxLabel.TabIndex = 224
        Me.MaxLabel.Text = "Maximum Range ="
        Me.MaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Increments
        '
        Me.Increments.CausesValidation = False
        Me.Increments.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Increments.Enabled = False
        Me.Increments.Location = New System.Drawing.Point(100, 225)
        Me.Increments.Name = "Increments"
        Me.Increments.Properties.Appearance.Options.UseTextOptions = True
        Me.Increments.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Increments.Properties.AutoHeight = False
        Me.Increments.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Increments.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Increments.Properties.IsFloatValue = False
        Me.Increments.Properties.Mask.BeepOnError = True
        Me.Increments.Properties.Mask.EditMask = "999"
        Me.Increments.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Increments.Properties.Mask.ShowPlaceHolders = False
        Me.Increments.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Increments.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Increments.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Increments.Size = New System.Drawing.Size(55, 21)
        Me.Increments.TabIndex = 223
        '
        'IncrementsLabel
        '
        Me.IncrementsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.IncrementsLabel.Enabled = False
        Me.IncrementsLabel.Location = New System.Drawing.Point(35, 225)
        Me.IncrementsLabel.Name = "IncrementsLabel"
        Me.IncrementsLabel.Size = New System.Drawing.Size(65, 21)
        Me.IncrementsLabel.TabIndex = 222
        Me.IncrementsLabel.Text = "Increments"
        Me.IncrementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RangeSpin
        '
        Me.RangeSpin.CausesValidation = False
        Me.RangeSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RangeSpin.Enabled = False
        Me.RangeSpin.Location = New System.Drawing.Point(100, 195)
        Me.RangeSpin.Name = "RangeSpin"
        Me.RangeSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.RangeSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RangeSpin.Properties.AutoHeight = False
        Me.RangeSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RangeSpin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RangeSpin.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RangeSpin.Properties.IsFloatValue = False
        Me.RangeSpin.Properties.Mask.BeepOnError = True
        Me.RangeSpin.Properties.Mask.EditMask = "999"
        Me.RangeSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RangeSpin.Properties.Mask.ShowPlaceHolders = False
        Me.RangeSpin.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.RangeSpin.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RangeSpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RangeSpin.Size = New System.Drawing.Size(55, 21)
        Me.RangeSpin.TabIndex = 221
        '
        'RangeLabel
        '
        Me.RangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.RangeLabel.Enabled = False
        Me.RangeLabel.Location = New System.Drawing.Point(35, 195)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(70, 21)
        Me.RangeLabel.TabIndex = 220
        Me.RangeLabel.Text = "Range"
        Me.RangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RangedCheck
        '
        Me.RangedCheck.Location = New System.Drawing.Point(15, 165)
        Me.RangedCheck.Name = "RangedCheck"
        Me.RangedCheck.Size = New System.Drawing.Size(110, 21)
        Me.RangedCheck.TabIndex = 219
        Me.RangedCheck.Text = "Ranged Weapon"
        '
        'NameCheck
        '
        Me.NameCheck.CausesValidation = False
        Me.NameCheck.Location = New System.Drawing.Point(280, 15)
        Me.NameCheck.Name = "NameCheck"
        Me.NameCheck.Size = New System.Drawing.Size(95, 21)
        Me.NameCheck.TabIndex = 218
        Me.NameCheck.Text = "Display Name"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(16, 260)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 217
        Me.IndentedLine1.TabStop = False
        '
        'ExtraDamage
        '
        Me.ExtraDamage.CausesValidation = False
        Me.ExtraDamage.Location = New System.Drawing.Point(95, 275)
        Me.ExtraDamage.Name = "ExtraDamage"
        Me.ExtraDamage.Properties.AutoHeight = False
        Me.ExtraDamage.Size = New System.Drawing.Size(200, 21)
        Me.ExtraDamage.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Extra Damage"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JunctionDropdown
        '
        Me.JunctionDropdown.CausesValidation = False
        Me.JunctionDropdown.Enabled = False
        Me.JunctionDropdown.Location = New System.Drawing.Point(205, 135)
        Me.JunctionDropdown.Name = "JunctionDropdown"
        Me.JunctionDropdown.Properties.AutoHeight = False
        Me.JunctionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JunctionDropdown.Properties.DropDownRows = 10
        Me.JunctionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.JunctionDropdown.Size = New System.Drawing.Size(50, 21)
        Me.JunctionDropdown.TabIndex = 6
        '
        'DamageDropdown2
        '
        Me.DamageDropdown2.Enabled = False
        Me.DamageDropdown2.Location = New System.Drawing.Point(265, 135)
        Me.DamageDropdown2.Name = "DamageDropdown2"
        Me.DamageDropdown2.Properties.AutoHeight = False
        Me.DamageDropdown2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageDropdown2.Properties.DropDownRows = 10
        Me.DamageDropdown2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageDropdown2.Size = New System.Drawing.Size(100, 21)
        Me.DamageDropdown2.TabIndex = 7
        '
        'DamageDropdown1
        '
        Me.Errors.SetIconPadding(Me.DamageDropdown1, 170)
        Me.DamageDropdown1.Location = New System.Drawing.Point(95, 135)
        Me.DamageDropdown1.Name = "DamageDropdown1"
        Me.DamageDropdown1.Properties.AutoHeight = False
        Me.DamageDropdown1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageDropdown1.Properties.DropDownRows = 10
        Me.DamageDropdown1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageDropdown1.Size = New System.Drawing.Size(100, 21)
        Me.DamageDropdown1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "Damage Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Attack Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttackDropdown
        '
        Me.AttackDropdown.Location = New System.Drawing.Point(95, 45)
        Me.AttackDropdown.Name = "AttackDropdown"
        Me.AttackDropdown.Properties.AutoHeight = False
        Me.AttackDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AttackDropdown.Properties.DropDownRows = 10
        Me.AttackDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AttackDropdown.Size = New System.Drawing.Size(100, 21)
        Me.AttackDropdown.TabIndex = 1
        '
        'ThreatRangeLabel
        '
        Me.ThreatRangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ThreatRangeLabel.Location = New System.Drawing.Point(15, 105)
        Me.ThreatRangeLabel.Name = "ThreatRangeLabel"
        Me.ThreatRangeLabel.Size = New System.Drawing.Size(75, 21)
        Me.ThreatRangeLabel.TabIndex = 207
        Me.ThreatRangeLabel.Text = "Threat Range"
        Me.ThreatRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ThreatRange
        '
        Me.ThreatRange.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ThreatRange.Location = New System.Drawing.Point(95, 105)
        Me.ThreatRange.Name = "ThreatRange"
        Me.ThreatRange.Properties.Appearance.Options.UseTextOptions = True
        Me.ThreatRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ThreatRange.Properties.AutoHeight = False
        Me.ThreatRange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ThreatRange.Properties.DisplayFormat.FormatString = "#-2\0"
        Me.ThreatRange.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ThreatRange.Properties.EditFormat.FormatString = "#-2\0"
        Me.ThreatRange.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ThreatRange.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ThreatRange.Properties.IsFloatValue = False
        Me.ThreatRange.Properties.Mask.EditMask = "N00"
        Me.ThreatRange.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ThreatRange.Properties.MinValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.ThreatRange.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ThreatRange.Size = New System.Drawing.Size(55, 21)
        Me.ThreatRange.TabIndex = 3
        '
        'Multiplier
        '
        Me.Multiplier.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Multiplier.Location = New System.Drawing.Point(180, 105)
        Me.Multiplier.Name = "Multiplier"
        Me.Multiplier.Properties.Appearance.Options.UseTextOptions = True
        Me.Multiplier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Multiplier.Properties.AutoHeight = False
        Me.Multiplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Multiplier.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Multiplier.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Multiplier.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Multiplier.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Multiplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Multiplier.Size = New System.Drawing.Size(50, 21)
        Me.Multiplier.TabIndex = 4
        '
        'DivideLabel
        '
        Me.DivideLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DivideLabel.Location = New System.Drawing.Point(160, 105)
        Me.DivideLabel.Name = "DivideLabel"
        Me.DivideLabel.Size = New System.Drawing.Size(10, 21)
        Me.DivideLabel.TabIndex = 206
        Me.DivideLabel.Text = "/"
        Me.DivideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Damage
        '
        Me.Damage.CausesValidation = False
        Me.Damage.Location = New System.Drawing.Point(95, 75)
        Me.Damage.Name = "Damage"
        Me.Damage.Properties.Appearance.Options.UseTextOptions = True
        Me.Damage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Damage.Properties.AutoHeight = False
        Me.Damage.Size = New System.Drawing.Size(60, 21)
        Me.Damage.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(15, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 21)
        Me.Label9.TabIndex = 201
        Me.Label9.Text = "Damage"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.CausesValidation = False
        Me.ObjectName.Location = New System.Drawing.Point(95, 15)
        Me.ObjectName.Name = "ObjectName"
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(180, 21)
        Me.ObjectName.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.NameLabel.Location = New System.Drawing.Point(15, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(75, 21)
        Me.NameLabel.TabIndex = 107
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PropertiesTab)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(407, 414)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 470)
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
        Me.OK.Location = New System.Drawing.Point(280, 470)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(170, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 224
        Me.Label5.Text = "Maximum Range ="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReadOnlyTextBox1
        '
        Me.ReadOnlyTextBox1.BackColor = System.Drawing.Color.White
        Me.ReadOnlyTextBox1.Caption = Nothing
        Me.ReadOnlyTextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ReadOnlyTextBox1.Location = New System.Drawing.Point(270, 225)
        Me.ReadOnlyTextBox1.Name = "ReadOnlyTextBox1"
        Me.ReadOnlyTextBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.ReadOnlyTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ReadOnlyTextBox1.TabIndex = 225
        Me.ReadOnlyTextBox1.TextColor = System.Drawing.Color.Empty
        Me.ReadOnlyTextBox1.Vertical = False
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'SpinEdit1d
        '
        Me.SpinEdit1d.CausesValidation = False
        Me.SpinEdit1d.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1d.Enabled = False
        Me.SpinEdit1d.Location = New System.Drawing.Point(100, 225)
        Me.SpinEdit1d.Name = "SpinEdit1d"
        Me.SpinEdit1d.Properties.Appearance.Options.UseTextOptions = True
        Me.SpinEdit1d.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpinEdit1d.Properties.AutoHeight = False
        Me.SpinEdit1d.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1d.Properties.IsFloatValue = False
        Me.SpinEdit1d.Properties.Mask.BeepOnError = True
        Me.SpinEdit1d.Properties.Mask.EditMask = "999"
        Me.SpinEdit1d.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.SpinEdit1d.Properties.Mask.ShowPlaceHolders = False
        Me.SpinEdit1d.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEdit1d.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1d.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpinEdit1d.Size = New System.Drawing.Size(55, 21)
        Me.SpinEdit1d.TabIndex = 223
        '
        'NaturalWeaponForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 508)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NaturalWeaponForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NaturalWeaponForm"
        Me.TabControl1.ResumeLayout(False)
        Me.WeaponTab.ResumeLayout(False)
        CType(Me.Increments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtraDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageDropdown2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageDropdown1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttackDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThreatRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Multiplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Damage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1d.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()
        Try

            'dropdowns
            AttackDropdown.Properties.Items.AddRange(Rules.Lists.NaturalAttackTypes)

            'add a blank damage option
            DamageDropdown1.Properties.Items.Add("")

            DamageDropdown1.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)
            DamageDropdown2.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)
            JunctionDropdown.Properties.Items.AddRange(Rules.Lists.JunctionTypes)

            RangeSpin.Properties.DisplayFormat.Format = New Rules.FeetFormatter
            RangeSpin.Properties.EditFormat.Format = New Rules.FeetFormatter

            'Init the properties tab
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.NaturalWeapons)

            'init object
            mObject.Type = Objects.NaturalWeaponDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Natural Weapon"
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

            'init form
            Me.Text = "Edit Natural Weapon"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = Obj.Name
            AttackDropdown.Text = mObject.Element("AttackType")

            Damage.Text = mObject.Element("Damage")

            If mObject.Element("ThreatRange") <> "" Then
                ThreatRange.Value = mObject.ElementAsInteger("ThreatRange")
            End If

            If mObject.Element("Multiplier") <> "" Then
                Multiplier.Value = mObject.ElementAsInteger("Multiplier")
            End If

            DamageDropdown1.Text = mObject.Element("DamageType1")
            JunctionDropdown.Text = mObject.Element("Junction")
            DamageDropdown2.Text = mObject.Element("DamageType2")

            If mObject.Element("OverrideName") = "True" Then
                NameCheck.Checked = True
            End If

            If mObject.Element("NaturalRanged") = "True" Then
                RangedCheck.Checked = True
                RangeSpin.Value = mObject.ElementAsInteger("RangeIncrement")
                Increments.Value = mObject.ElementAsInteger("Increments")
            End If

            Dim ExtraDamageString As String = mObject.Element("ExtraDamage")
            If ExtraDamageString <> "" Then
                ExtraDamage.Text = ExtraDamageString
            End If

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
                        'do nothing yet
                    Case FormMode.Edit
                        'TODO - DEV ONLY
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("AttackType") = AttackDropdown.Text
                mObject.Element("Damage") = Damage.Text

                'weapon emulation elements - to make a natural weapon polymorphic with a weapon definition
                If RangedCheck.Checked Then
                    mObject.Element("WeaponType") = "Ranged"
                Else
                    mObject.Element("WeaponType") = "Melee"
                End If


                If ThreatRange.Enabled Then
                    mObject.Element("ThreatRange") = ThreatRange.Value.ToString
                    mObject.Element("Multiplier") = Multiplier.Value.ToString

                    'combined crit string
                    If ThreatRange.Value = 20 Then
                        mObject.Element("Critical") = "x" & Multiplier.Value.ToString
                    Else
                        mObject.Element("Critical") = ThreatRange.Value.ToString & "-20/x" & Multiplier.Value.ToString
                    End If
                End If

                If DamageDropdown1.Enabled Then
                    mObject.Element("DamageType1") = DamageDropdown1.Text
                    If DamageDropdown2.Text <> "" Then
                        mObject.Element("Junction") = JunctionDropdown.Text
                        mObject.Element("DamageType2") = DamageDropdown2.Text
                        mObject.Element("DamageType") = DamageDropdown1.Text & " " & JunctionDropdown.Text & " " & DamageDropdown2.Text
                    Else
                        mObject.Element("Junction") = ""
                        mObject.Element("DamageType2") = ""
                        mObject.Element("DamageType") = DamageDropdown1.Text
                    End If
                End If

                If ExtraDamage.Text <> "" Then
                    mObject.Element("ExtraDamage") = ExtraDamage.Text
                End If

                If NameCheck.Checked Then
                    mObject.Element("OverrideName") = "True"
                End If

                If RangedCheck.Checked Then
                    mObject.Element("NaturalRanged") = "True"
                    mObject.Element("RangeIncrement") = RangeSpin.Value.ToString
                    mObject.Element("Increments") = Increments.Value.ToString
                End If

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
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

#Region "Tab Code"

    'for updating the damge type dropdowns
    Private Sub Damage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Damage.EditValueChanged
        Try

            If Damage.Text = "" Then
                DamageDropdown1.SelectedIndex = -1
                DamageDropdown1.Enabled = False

                ThreatRange.Value = 20
                Multiplier.Value = 2
                ThreatRange.Enabled = False
                Multiplier.Enabled = False
            Else
                DamageDropdown1.Enabled = True
                ThreatRange.Enabled = True
                Multiplier.Enabled = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'removes selected damage type from second dropdown
    Private Sub DamageDropdown1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageDropdown1.SelectedIndexChanged
        Try
            DamageDropdown2.Properties.Items.Clear()
            DamageDropdown2.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)

            If DamageDropdown1.Text <> "" And DamageDropdown1.Text <> DamageDropdown2.Text Then
                JunctionDropdown.Properties.Enabled = True
                DamageDropdown2.Properties.Items.Remove(DamageDropdown1.SelectedItem)
            ElseIf DamageDropdown1.Text = DamageDropdown2.Text And Not DamageDropdown1.SelectedIndex < 1 Then
                JunctionDropdown.Properties.Enabled = True
                JunctionDropdown.SelectedIndex = -1
                DamageDropdown2.Properties.Items.Remove(DamageDropdown1.SelectedItem)
            Else
                JunctionDropdown.Properties.Enabled = False
                JunctionDropdown.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enables second damage type box if required
    Private Sub JunctionDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JunctionDropdown.SelectedIndexChanged
        Try
            If JunctionDropdown.Text <> "" Then
                DamageDropdown2.Properties.Enabled = True
            Else
                DamageDropdown2.Properties.Enabled = False
                DamageDropdown2.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'formatting for critical box
    Private Sub ThreatRange_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreatRange.EditValueChanged
        Try
            If ThreatRange.Value = 20 Then
                ThreatRange.Text = "20"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'set the icon
    Private Sub AttackDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttackDropdown.SelectedIndexChanged
        Try

            If mMode = FormMode.Add Then
                Select Case AttackDropdown.Text
                    Case "Claw"
                        PropertiesTab.ImageFilename.Text = "Claw.png"
                    Case "Tentacle"
                        PropertiesTab.ImageFilename.Text = "Tentacle.png"
                    Case "Tail"
                        PropertiesTab.ImageFilename.Text = "TailSlap.png"
                    Case "Talon"
                        PropertiesTab.ImageFilename.Text = "Talon.png"
                    Case "Bite"
                        PropertiesTab.ImageFilename.Text = "Bite.png"
                    Case "Stamp"
                        PropertiesTab.ImageFilename.Text = "Stamp.png"
                    Case "Sting"
                        PropertiesTab.ImageFilename.Text = "Talon.png"
                    Case "Slam"
                        PropertiesTab.ImageFilename.Text = "Slam.png"
                    Case "Gore"
                        PropertiesTab.ImageFilename.Text = "Gore.png"
                    Case "Arm"
                        PropertiesTab.ImageFilename.Text = "Tentacle.png"
                    Case "Hoof"
                        PropertiesTab.ImageFilename.Text = "Stamp.png"
                    Case "Headbutt"
                        PropertiesTab.ImageFilename.Text = "Slam.png"
                    Case "Ram"
                        PropertiesTab.ImageFilename.Text = "Slam.png"
                    Case "Ram"
                        PropertiesTab.ImageFilename.Text = "Slam.png"
                    Case Else
                        ' do nothing
                End Select
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.WeaponTab.Controls, Errors)

            If (Damage.Properties.Enabled = False) OrElse (Damage.Text = "") OrElse (ValidNumberDiceRange(Damage)) Then
                Errors.SetError(Damage, "")
            Else
                Errors.SetError(Damage, ValidationPWNumberOrDiceRangeOrEmpty)
                Validate = False
            End If

            If ObjectName.Text = "" Then
                Errors.SetError(NameCheck, General.ValidationRequired)
                Validate = False
            ElseIf ObjectName.Text <> mObject.Name AndAlso XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                Errors.SetError(NameCheck, General.ValidationUniqueName)
                Validate = False
            Else
                Errors.SetError(NameCheck, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

    Private Sub RangedCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangedCheck.CheckedChanged
        If RangedCheck.Checked Then
            RangeLabel.Enabled = True
            RangeSpin.Enabled = True

            IncrementsLabel.Enabled = True
            Increments.Enabled = True

            MaxRange.Enabled = True
            MaxLabel.Enabled = True

            RangeSpin.Value = 5
        Else
            RangeLabel.Enabled = False
            RangeSpin.Enabled = False

            IncrementsLabel.Enabled = False
            Increments.Enabled = False

            MaxRange.Enabled = False
            MaxLabel.Enabled = False

            RangeSpin.Value = 0
            MaxRange.Text = ""
            Increments.Value = 1
        End If
    End Sub

    Private Sub RangeSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangeSpin.EditValueChanged
        UpdateMaxRange()
    End Sub

    Private Sub Increments_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Increments.EditValueChanged
        UpdateMaxRange()
    End Sub

    Private Sub UpdateMaxRange()
        Try
            If MaxRange.Enabled = True Then
                MaxRange.Caption = (RangeSpin.Value * Increments.Value).ToString & " ft."
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub WeaponTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeaponTab.Click

    End Sub
End Class