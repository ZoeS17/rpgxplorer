Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SpellLevelsForm
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
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents Level0Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level1Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level2Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level3Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level4Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level5Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level6Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level7Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level8Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Level9Spells As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SpellLevelsTab As System.Windows.Forms.TabPage
    Public WithEvents SpellPointsSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SpellPointsLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SpellLevelsTab = New System.Windows.Forms.TabPage
        Me.SpellPointsSpin = New DevExpress.XtraEditors.SpinEdit
        Me.SpellPointsLabel = New System.Windows.Forms.Label
        Me.Level9Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level8Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level7Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level6Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level5Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level4Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level3Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level2Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level1Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level0Spells = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SpellLevelsTab.SuspendLayout()
        CType(Me.SpellPointsSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level9Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level8Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level7Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level6Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level5Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level4Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level3Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level2Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level1Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level0Spells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
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
        Me.OK.Location = New System.Drawing.Point(280, 405)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SpellLevelsTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'SpellLevelsTab
        '
        Me.SpellLevelsTab.Controls.Add(Me.SpellPointsSpin)
        Me.SpellLevelsTab.Controls.Add(Me.SpellPointsLabel)
        Me.SpellLevelsTab.Controls.Add(Me.Level9Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level8Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level7Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level6Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level5Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level4Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level3Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level2Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level1Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Level0Spells)
        Me.SpellLevelsTab.Controls.Add(Me.Label10)
        Me.SpellLevelsTab.Controls.Add(Me.Label8)
        Me.SpellLevelsTab.Controls.Add(Me.Label9)
        Me.SpellLevelsTab.Controls.Add(Me.Label5)
        Me.SpellLevelsTab.Controls.Add(Me.Label6)
        Me.SpellLevelsTab.Controls.Add(Me.Label7)
        Me.SpellLevelsTab.Controls.Add(Me.Label4)
        Me.SpellLevelsTab.Controls.Add(Me.Label3)
        Me.SpellLevelsTab.Controls.Add(Me.Label2)
        Me.SpellLevelsTab.Controls.Add(Me.Label1)
        Me.SpellLevelsTab.Location = New System.Drawing.Point(4, 22)
        Me.SpellLevelsTab.Name = "SpellLevelsTab"
        Me.SpellLevelsTab.Size = New System.Drawing.Size(407, 349)
        Me.SpellLevelsTab.TabIndex = 0
        Me.SpellLevelsTab.Text = "Spell Levels"
        '
        'SpellPointsSpin
        '
        Me.SpellPointsSpin.CausesValidation = False
        Me.SpellPointsSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpellPointsSpin.Location = New System.Drawing.Point(280, 15)
        Me.SpellPointsSpin.Name = "SpellPointsSpin"
        '
        'SpellPointsSpin.Properties
        '
        Me.SpellPointsSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.SpellPointsSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpellPointsSpin.Properties.AutoHeight = False
        Me.SpellPointsSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpellPointsSpin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.SpellPointsSpin.Properties.IsFloatValue = False
        Me.SpellPointsSpin.Properties.Mask.EditMask = "d"
        Me.SpellPointsSpin.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.SpellPointsSpin.Size = New System.Drawing.Size(60, 21)
        Me.SpellPointsSpin.TabIndex = 141
        Me.SpellPointsSpin.Visible = False
        '
        'SpellPointsLabel
        '
        Me.SpellPointsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.SpellPointsLabel.Location = New System.Drawing.Point(200, 15)
        Me.SpellPointsLabel.Name = "SpellPointsLabel"
        Me.SpellPointsLabel.Size = New System.Drawing.Size(75, 21)
        Me.SpellPointsLabel.TabIndex = 140
        Me.SpellPointsLabel.Text = "Spell Points"
        Me.SpellPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SpellPointsLabel.Visible = False
        '
        'Level9Spells
        '
        Me.Level9Spells.EditValue = ""
        Me.Level9Spells.Location = New System.Drawing.Point(105, 285)
        Me.Level9Spells.Name = "Level9Spells"
        '
        'Level9Spells.Properties
        '
        Me.Level9Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level9Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level9Spells.Properties.AutoHeight = False
        Me.Level9Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level9Spells.Properties.DropDownRows = 10
        Me.Level9Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level9Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level9Spells.TabIndex = 9
        '
        'Level8Spells
        '
        Me.Level8Spells.EditValue = ""
        Me.Level8Spells.Location = New System.Drawing.Point(105, 255)
        Me.Level8Spells.Name = "Level8Spells"
        '
        'Level8Spells.Properties
        '
        Me.Level8Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level8Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level8Spells.Properties.AutoHeight = False
        Me.Level8Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level8Spells.Properties.DropDownRows = 10
        Me.Level8Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level8Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level8Spells.TabIndex = 8
        '
        'Level7Spells
        '
        Me.Level7Spells.EditValue = ""
        Me.Level7Spells.Location = New System.Drawing.Point(105, 225)
        Me.Level7Spells.Name = "Level7Spells"
        '
        'Level7Spells.Properties
        '
        Me.Level7Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level7Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level7Spells.Properties.AutoHeight = False
        Me.Level7Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level7Spells.Properties.DropDownRows = 10
        Me.Level7Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level7Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level7Spells.TabIndex = 7
        '
        'Level6Spells
        '
        Me.Level6Spells.EditValue = ""
        Me.Level6Spells.Location = New System.Drawing.Point(105, 195)
        Me.Level6Spells.Name = "Level6Spells"
        '
        'Level6Spells.Properties
        '
        Me.Level6Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level6Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level6Spells.Properties.AutoHeight = False
        Me.Level6Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level6Spells.Properties.DropDownRows = 10
        Me.Level6Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level6Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level6Spells.TabIndex = 6
        '
        'Level5Spells
        '
        Me.Level5Spells.EditValue = ""
        Me.Level5Spells.Location = New System.Drawing.Point(105, 165)
        Me.Level5Spells.Name = "Level5Spells"
        '
        'Level5Spells.Properties
        '
        Me.Level5Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level5Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level5Spells.Properties.AutoHeight = False
        Me.Level5Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level5Spells.Properties.DropDownRows = 10
        Me.Level5Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level5Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level5Spells.TabIndex = 5
        '
        'Level4Spells
        '
        Me.Level4Spells.EditValue = ""
        Me.Level4Spells.Location = New System.Drawing.Point(105, 135)
        Me.Level4Spells.Name = "Level4Spells"
        '
        'Level4Spells.Properties
        '
        Me.Level4Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level4Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level4Spells.Properties.AutoHeight = False
        Me.Level4Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level4Spells.Properties.DropDownRows = 10
        Me.Level4Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level4Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level4Spells.TabIndex = 4
        '
        'Level3Spells
        '
        Me.Level3Spells.EditValue = ""
        Me.Level3Spells.Location = New System.Drawing.Point(105, 105)
        Me.Level3Spells.Name = "Level3Spells"
        '
        'Level3Spells.Properties
        '
        Me.Level3Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level3Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level3Spells.Properties.AutoHeight = False
        Me.Level3Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level3Spells.Properties.DropDownRows = 10
        Me.Level3Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level3Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level3Spells.TabIndex = 3
        '
        'Level2Spells
        '
        Me.Level2Spells.EditValue = ""
        Me.Level2Spells.Location = New System.Drawing.Point(105, 75)
        Me.Level2Spells.Name = "Level2Spells"
        '
        'Level2Spells.Properties
        '
        Me.Level2Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level2Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level2Spells.Properties.AutoHeight = False
        Me.Level2Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level2Spells.Properties.DropDownRows = 10
        Me.Level2Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level2Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level2Spells.TabIndex = 2
        '
        'Level1Spells
        '
        Me.Level1Spells.EditValue = ""
        Me.Level1Spells.Location = New System.Drawing.Point(105, 45)
        Me.Level1Spells.Name = "Level1Spells"
        '
        'Level1Spells.Properties
        '
        Me.Level1Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level1Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level1Spells.Properties.AutoHeight = False
        Me.Level1Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level1Spells.Properties.DropDownRows = 10
        Me.Level1Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level1Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level1Spells.TabIndex = 1
        '
        'Level0Spells
        '
        Me.Level0Spells.EditValue = ""
        Me.Level0Spells.Location = New System.Drawing.Point(105, 15)
        Me.Level0Spells.Name = "Level0Spells"
        '
        'Level0Spells.Properties
        '
        Me.Level0Spells.Properties.Appearance.Options.UseTextOptions = True
        Me.Level0Spells.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level0Spells.Properties.AutoHeight = False
        Me.Level0Spells.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Level0Spells.Properties.DropDownRows = 10
        Me.Level0Spells.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level0Spells.Size = New System.Drawing.Size(60, 21)
        Me.Level0Spells.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "Level 9 Spells"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 21)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "Level 8 Spells"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(15, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 21)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Level 7 Spells"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Level 6 Spells"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Level 5 Spells"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Level 4 Spells"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Level 3 Spells"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Level 2 Spells"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Level 1 Spells"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Level 0 Spells"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
        Me.TabPage1.TabIndex = 1
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
        'SpellLevelsForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SpellLevelsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpellLevelsForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SpellLevelsTab.ResumeLayout(False)
        CType(Me.SpellPointsSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level9Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level8Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level7Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level6Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level5Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level4Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level3Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level2Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level1Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level0Spells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mPreviousLevel As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()
        Dim List As String() = Nothing
        Dim n As Integer

        Try
            'initialise controls
            Select Case mObject.Type
                Case Objects.SpellsKnownType
                    ReDim List(20)
                    List(0) = ""
                    For n = 1 To 20
                        List(n) = n.ToString
                    Next
                Case Objects.SpellsPerDayType
                    ReDim List(21)
                    List(0) = ""
                    For n = 0 To 20
                        List(n + 1) = n.ToString
                    Next
            End Select

            Level0Spells.Properties.Items.AddRange(List)
            Level1Spells.Properties.Items.AddRange(List)
            Level2Spells.Properties.Items.AddRange(List)
            Level3Spells.Properties.Items.AddRange(List)
            Level4Spells.Properties.Items.AddRange(List)
            Level5Spells.Properties.Items.AddRange(List)
            Level6Spells.Properties.Items.AddRange(List)
            Level7Spells.Properties.Items.AddRange(List)
            Level8Spells.Properties.Items.AddRange(List)
            Level9Spells.Properties.Items.AddRange(List)

            'init propertiestab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData, ByVal Type As String)
        Dim Obj As Objects.ObjectData
        Dim HighestLevel As Integer = 0
        Dim Level As Integer

        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object and form
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Classes)
            mObject.ParentGUID = mFolder.ObjectGUID
            mObject.Element("Level") = CStr(HighestLevel + 1)

            Select Case Type
                Case Objects.SpellsKnownType
                    mObject.Type = Objects.SpellsKnownType
                    Me.Text = "Add Spells Known"

                    'get the next level
                    For Each Obj In Folder.ChildrenOfType(Objects.SpellsKnownType)
                        Level = CInt(Obj.Element("Level"))
                        If Level > HighestLevel Then HighestLevel = Level
                    Next
                Case Objects.SpellsPerDayType
                    mObject.Type = Objects.SpellsPerDayType
                    Me.Text = "Add Spells per Day"

                    SpellPointsLabel.Visible = True
                    SpellPointsSpin.Visible = True

                    'get the next level
                    For Each Obj In Folder.ChildrenOfType(Objects.SpellsPerDayType)
                        Level = CInt(Obj.Element("Level"))
                        If Level > HighestLevel Then HighestLevel = Level
                    Next
            End Select

            SpellLevelsTab.Text = "Level " & CStr(HighestLevel + 1)
            mObject.Name = "Level " & CStr(HighestLevel + 1)
            mObject.Element("Level") = CStr(HighestLevel + 1)

            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls

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

            'init object
            Select Case mObject.Type
                Case Objects.SpellsKnownType
                    Me.Text = "Edit Spells Known"
                    TabControl1.TabPages(0).Text = "Spells Known"
                Case Objects.SpellsPerDayType
                    Me.Text = "Edit Spells per Day"
                    TabControl1.TabPages(0).Text = "Spells Per Day"

                    SpellPointsLabel.Visible = True
                    SpellPointsSpin.Visible = True

            End Select

            'init form
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            SpellLevelsTab.Text = "Level " & mObject.Element("Level")
            Init()

            'initialise controls
            Level0Spells.Text = mObject.Element("Level0Spells")
            Level1Spells.Text = mObject.Element("Level1Spells")
            Level2Spells.Text = mObject.Element("Level2Spells")
            Level3Spells.Text = mObject.Element("Level3Spells")
            Level4Spells.Text = mObject.Element("Level4Spells")
            Level5Spells.Text = mObject.Element("Level5Spells")
            Level6Spells.Text = mObject.Element("Level6Spells")
            Level7Spells.Text = mObject.Element("Level7Spells")
            Level8Spells.Text = mObject.Element("Level8Spells")
            Level9Spells.Text = mObject.Element("Level9Spells")

            'check previous level
            If mObject.ElementAsInteger("Level") > 1 Then
                Dim PreviousLevel As Objects.ObjectData

                PreviousLevel = Objects.GetObjectByXPath(Xml.DBTypes.Classes, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & mObject.ParentGUID.ToString & "' and Name='Level " & (mObject.ElementAsInteger("Level") - 1).ToString & "']")
                mPreviousLevel = PreviousLevel

                If Level0Spells.Text = "" Then
                    Level0Spells.Text = PreviousLevel.Element("Level0Spells")
                ElseIf CType(Level0Spells.Text, Integer) < mObject.ElementAsInteger("Level0Spells") Then
                    Level0Spells.Text = PreviousLevel.Element("Level0Spells")
                End If

                If Level1Spells.Text = "" Then
                    Level1Spells.Text = PreviousLevel.Element("Level1Spells")
                ElseIf CType(Level1Spells.Text, Integer) < mObject.ElementAsInteger("Level1Spells") Then
                    Level1Spells.Text = PreviousLevel.Element("Level1Spells")
                End If

                If Level2Spells.Text = "" Then
                    Level2Spells.Text = PreviousLevel.Element("Level2Spells")
                ElseIf CType(Level2Spells.Text, Integer) < mObject.ElementAsInteger("Level2Spells") Then
                    Level2Spells.Text = PreviousLevel.Element("Level2Spells")
                End If

                If Level3Spells.Text = "" Then
                    Level3Spells.Text = PreviousLevel.Element("Level3Spells")
                ElseIf CType(Level3Spells.Text, Integer) < mObject.ElementAsInteger("Level3Spells") Then
                    Level3Spells.Text = PreviousLevel.Element("Level3Spells")
                End If

                If Level4Spells.Text = "" Then
                    Level4Spells.Text = PreviousLevel.Element("Level4Spells")
                ElseIf CType(Level4Spells.Text, Integer) < mObject.ElementAsInteger("Level4Spells") Then
                    Level4Spells.Text = PreviousLevel.Element("Level4Spells")
                End If

                If Level5Spells.Text = "" Then
                    Level5Spells.Text = PreviousLevel.Element("Level5Spells")
                ElseIf CType(Level5Spells.Text, Integer) < mObject.ElementAsInteger("Level5Spells") Then
                    Level5Spells.Text = PreviousLevel.Element("Level5Spells")
                End If

                If Level6Spells.Text = "" Then
                    Level6Spells.Text = PreviousLevel.Element("Level6Spells")
                ElseIf CType(Level6Spells.Text, Integer) < mObject.ElementAsInteger("Level6Spells") Then
                    Level6Spells.Text = PreviousLevel.Element("Level6Spells")
                End If

                If Level7Spells.Text = "" Then
                    Level7Spells.Text = PreviousLevel.Element("Level7Spells")
                ElseIf CType(Level7Spells.Text, Integer) < mObject.ElementAsInteger("Level7Spells") Then
                    Level7Spells.Text = PreviousLevel.Element("Level7Spells")
                End If

                If Level8Spells.Text = "" Then
                    Level8Spells.Text = PreviousLevel.Element("Level8Spells")
                ElseIf CType(Level8Spells.Text, Integer) < mObject.ElementAsInteger("Level8Spells") Then
                    Level8Spells.Text = PreviousLevel.Element("Level8Spells")
                End If

                If Level9Spells.Text = "" Then
                    Level9Spells.Text = PreviousLevel.Element("Level9Spells")
                ElseIf CType(Level9Spells.Text, Integer) < mObject.ElementAsInteger("Level9Spells") Then
                    Level9Spells.Text = PreviousLevel.Element("Level9Spells")
                End If

                If mObject.Type = Objects.SpellsPerDayType Then
                    If mObject.Element("SpellPoints") = "" Then
                        SpellPointsSpin.Value = PreviousLevel.ElementAsInteger("SpellPoints")
                    ElseIf mObject.ElementAsInteger("SpellPoints") < PreviousLevel.ElementAsInteger("SpellPoints") Then
                        SpellPointsSpin.Value = PreviousLevel.ElementAsInteger("SpellPoints")
                    Else
                        SpellPointsSpin.Value = mObject.ElementAsInteger("SpellPoints")
                    End If
                End If

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
                        'do nothing yet
                End Select

                'updates common to add and edit
                mObject.Element("Level0Spells") = Level0Spells.Text
                mObject.Element("Level1Spells") = Level1Spells.Text
                mObject.Element("Level2Spells") = Level2Spells.Text
                mObject.Element("Level3Spells") = Level3Spells.Text
                mObject.Element("Level4Spells") = Level4Spells.Text
                mObject.Element("Level5Spells") = Level5Spells.Text
                mObject.Element("Level6Spells") = Level6Spells.Text
                mObject.Element("Level7Spells") = Level7Spells.Text
                mObject.Element("Level8Spells") = Level8Spells.Text
                mObject.Element("Level9Spells") = Level9Spells.Text

                If mObject.Type = Objects.SpellsPerDayType Then
                    mObject.Element("SpellPoints") = SpellPointsSpin.Value.ToString
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

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean

        Try
            Validate = True

            If mObject.Type = Objects.SpellsPerDayType Then
                If SpellPointsSpin.Value < mPreviousLevel.ElementAsInteger("SpellPoints") Then
                    Errors.SetError(SpellPointsSpin, General.ValidationSpellPoints)
                    Validate = False
                Else
                    Errors.SetError(SpellPointsSpin, "")
                End If
            End If

            If General.ConvertToInteger(Level9Spells.Text) < mPreviousLevel.ElementAsInteger("Level9Spells") Then
                Errors.SetError(Level9Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level9Spells, "")
            End If

            If General.ConvertToInteger(Level8Spells.Text) < mPreviousLevel.ElementAsInteger("Level8Spells") Then
                Errors.SetError(Level8Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level8Spells, "")
            End If

            If General.ConvertToInteger(Level7Spells.Text) < mPreviousLevel.ElementAsInteger("Level7Spells") Then
                Errors.SetError(Level7Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level7Spells, "")
            End If

            If General.ConvertToInteger(Level6Spells.Text) < mPreviousLevel.ElementAsInteger("Level6Spells") Then
                Errors.SetError(Level6Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level6Spells, "")
            End If

            If General.ConvertToInteger(Level5Spells.Text) < mPreviousLevel.ElementAsInteger("Level5Spells") Then
                Errors.SetError(Level5Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level5Spells, "")
            End If

            If General.ConvertToInteger(Level4Spells.Text) < mPreviousLevel.ElementAsInteger("Level4Spells") Then
                Errors.SetError(Level4Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level4Spells, "")
            End If

            If General.ConvertToInteger(Level3Spells.Text) < mPreviousLevel.ElementAsInteger("Level3Spells") Then
                Errors.SetError(Level3Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level3Spells, "")
            End If

            If General.ConvertToInteger(Level2Spells.Text) < mPreviousLevel.ElementAsInteger("Level2Spells") Then
                Errors.SetError(Level2Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level2Spells, "")
            End If

            If General.ConvertToInteger(Level1Spells.Text) < mPreviousLevel.ElementAsInteger("Level1Spells") Then
                Errors.SetError(Level1Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level1Spells, "")
            End If

            If General.ConvertToInteger(Level0Spells.Text) < mPreviousLevel.ElementAsInteger("Level0Spells") Then
                Errors.SetError(Level0Spells, General.ValidationSpellLevels)
                Validate = False
            Else
                Errors.SetError(Level0Spells, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

            Return Validate

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

    Private Sub SpellPointsSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellPointsSpin.EditValueChanged
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SpellPointsSpin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpellPointsSpin.Leave
        If SpellPointsSpin.Value > SpellPointsSpin.Properties.MaxValue Then
            SpellPointsSpin.Value = SpellPointsSpin.Properties.MaxValue
        ElseIf SpellPointsSpin.Value < SpellPointsSpin.Properties.MinValue Then
            SpellPointsSpin.Value = SpellPointsSpin.Properties.MinValue
        End If
    End Sub

End Class
