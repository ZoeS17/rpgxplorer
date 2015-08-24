Option Explicit On
Option Strict On

Public Class CreateAttackDialog
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
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents ManufacturedRadio As System.Windows.Forms.RadioButton
    Public WithEvents NaturalRadio As System.Windows.Forms.RadioButton
    Public WithEvents PrimaryDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PrimarySpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SecondaryAttacks As System.Windows.Forms.ListBox
    Public WithEvents AddNatural As System.Windows.Forms.Button
    Public WithEvents SecondarySpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SecondaryDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AddManufactured As System.Windows.Forms.Button
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents NoneRadio As System.Windows.Forms.RadioButton
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents EnhancementBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents EnhancedCheck As System.Windows.Forms.CheckBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents ManufacturedSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents RemoveAttack As System.Windows.Forms.Button
    Public WithEvents SEnhancement As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SecondaryHalf As System.Windows.Forms.RadioButton
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents SecondaryMax As System.Windows.Forms.RadioButton
    Public WithEvents SecondaryFull As System.Windows.Forms.RadioButton
    Public WithEvents SecondaryNone As System.Windows.Forms.RadioButton
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents PrimaryNone As System.Windows.Forms.RadioButton
    Public WithEvents PrimaryMax As System.Windows.Forms.RadioButton
    Public WithEvents PrimaryFull As System.Windows.Forms.RadioButton
    Public WithEvents PrimaryHalf As System.Windows.Forms.RadioButton
    Public WithEvents PSTRLabel As System.Windows.Forms.Label
    Public WithEvents ShowCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAttackDialog))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ManufacturedRadio = New System.Windows.Forms.RadioButton
        Me.NaturalRadio = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.AddNatural = New System.Windows.Forms.Button
        Me.AddManufactured = New System.Windows.Forms.Button
        Me.RemoveAttack = New System.Windows.Forms.Button
        Me.NoneRadio = New System.Windows.Forms.RadioButton
        Me.EnhancedCheck = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ShowCheck = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SecondaryNone = New System.Windows.Forms.RadioButton
        Me.SecondaryMax = New System.Windows.Forms.RadioButton
        Me.SecondaryFull = New System.Windows.Forms.RadioButton
        Me.SecondaryHalf = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PrimaryNone = New System.Windows.Forms.RadioButton
        Me.PrimaryMax = New System.Windows.Forms.RadioButton
        Me.PrimaryFull = New System.Windows.Forms.RadioButton
        Me.PrimaryHalf = New System.Windows.Forms.RadioButton
        Me.PSTRLabel = New System.Windows.Forms.Label
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.PrimaryDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PrimarySpin = New DevExpress.XtraEditors.SpinEdit
        Me.SecondaryAttacks = New System.Windows.Forms.ListBox
        Me.SecondarySpin = New DevExpress.XtraEditors.SpinEdit
        Me.SecondaryDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.SEnhancement = New DevExpress.XtraEditors.SpinEdit
        Me.ManufacturedSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PrimaryDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimarySpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondarySpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondaryDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEnhancement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManufacturedSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(339, 620)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 24)
        Me.Cancel.TabIndex = 17
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(254, 620)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 24)
        Me.OK.TabIndex = 16
        Me.OK.Text = "OK"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Primary Attacks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ManufacturedRadio
        '
        Me.ManufacturedRadio.Location = New System.Drawing.Point(15, 115)
        Me.ManufacturedRadio.Name = "ManufacturedRadio"
        Me.ManufacturedRadio.Size = New System.Drawing.Size(105, 21)
        Me.ManufacturedRadio.TabIndex = 6
        Me.ManufacturedRadio.Text = "Manufactured"
        '
        'NaturalRadio
        '
        Me.NaturalRadio.Checked = True
        Me.NaturalRadio.Location = New System.Drawing.Point(15, 50)
        Me.NaturalRadio.Name = "NaturalRadio"
        Me.NaturalRadio.Size = New System.Drawing.Size(70, 21)
        Me.NaturalRadio.TabIndex = 0
        Me.NaturalRadio.TabStop = True
        Me.NaturalRadio.Text = "Natural"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 21)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Secondary Attacks - Natural"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddNatural
        '
        Me.AddNatural.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNatural.Location = New System.Drawing.Point(320, 234)
        Me.AddNatural.Name = "AddNatural"
        Me.AddNatural.Size = New System.Drawing.Size(95, 24)
        Me.AddNatural.TabIndex = 10
        Me.AddNatural.Text = "Add Attack"
        '
        'AddManufactured
        '
        Me.AddManufactured.Enabled = False
        Me.AddManufactured.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddManufactured.Location = New System.Drawing.Point(315, 348)
        Me.AddManufactured.Name = "AddManufactured"
        Me.AddManufactured.Size = New System.Drawing.Size(100, 25)
        Me.AddManufactured.TabIndex = 13
        Me.AddManufactured.Text = "Add Attack Slot"
        '
        'RemoveAttack
        '
        Me.RemoveAttack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveAttack.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAttack.Location = New System.Drawing.Point(315, 400)
        Me.RemoveAttack.Name = "RemoveAttack"
        Me.RemoveAttack.Size = New System.Drawing.Size(100, 24)
        Me.RemoveAttack.TabIndex = 15
        Me.RemoveAttack.Text = "Remove Attack"
        '
        'NoneRadio
        '
        Me.NoneRadio.Location = New System.Drawing.Point(15, 150)
        Me.NoneRadio.Name = "NoneRadio"
        Me.NoneRadio.Size = New System.Drawing.Size(105, 21)
        Me.NoneRadio.TabIndex = 7
        Me.NoneRadio.Text = "None"
        '
        'EnhancedCheck
        '
        Me.EnhancedCheck.Location = New System.Drawing.Point(30, 80)
        Me.EnhancedCheck.Name = "EnhancedCheck"
        Me.EnhancedCheck.Size = New System.Drawing.Size(100, 21)
        Me.EnhancedCheck.TabIndex = 4
        Me.EnhancedCheck.Text = "Enhanced"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(235, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 21)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "x"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(30, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Enhancement"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 248
        Me.Label6.Text = "Natural"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(225, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 21)
        Me.Label7.TabIndex = 245
        Me.Label7.Text = "x"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 21)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Secondary Attacks - Manufactured"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 20)
        Me.Label8.TabIndex = 248
        Me.Label8.Text = "Number of Attacks with Weapon"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShowCheck
        '
        Me.ShowCheck.Enabled = False
        Me.ShowCheck.Location = New System.Drawing.Point(15, 620)
        Me.ShowCheck.Name = "ShowCheck"
        Me.ShowCheck.Size = New System.Drawing.Size(160, 21)
        Me.ShowCheck.TabIndex = 249
        Me.ShowCheck.Text = "Show all Natural Weapons"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(190, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 21)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "STR Bonus:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.SecondaryNone)
        Me.Panel1.Controls.Add(Me.SecondaryMax)
        Me.Panel1.Controls.Add(Me.SecondaryFull)
        Me.Panel1.Controls.Add(Me.SecondaryHalf)
        Me.Panel1.Location = New System.Drawing.Point(260, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 21)
        Me.Panel1.TabIndex = 251
        '
        'SecondaryNone
        '
        Me.SecondaryNone.BackColor = System.Drawing.Color.Transparent
        Me.SecondaryNone.Location = New System.Drawing.Point(0, 0)
        Me.SecondaryNone.Name = "SecondaryNone"
        Me.SecondaryNone.Size = New System.Drawing.Size(40, 21)
        Me.SecondaryNone.TabIndex = 255
        Me.SecondaryNone.Text = "0"
        Me.SecondaryNone.UseVisualStyleBackColor = False
        '
        'SecondaryMax
        '
        Me.SecondaryMax.BackColor = System.Drawing.Color.Transparent
        Me.SecondaryMax.Location = New System.Drawing.Point(120, 0)
        Me.SecondaryMax.Name = "SecondaryMax"
        Me.SecondaryMax.Size = New System.Drawing.Size(40, 21)
        Me.SecondaryMax.TabIndex = 254
        Me.SecondaryMax.Text = "1½"
        Me.SecondaryMax.UseVisualStyleBackColor = False
        '
        'SecondaryFull
        '
        Me.SecondaryFull.BackColor = System.Drawing.Color.Transparent
        Me.SecondaryFull.Location = New System.Drawing.Point(80, 0)
        Me.SecondaryFull.Name = "SecondaryFull"
        Me.SecondaryFull.Size = New System.Drawing.Size(40, 21)
        Me.SecondaryFull.TabIndex = 253
        Me.SecondaryFull.Text = "1"
        Me.SecondaryFull.UseVisualStyleBackColor = False
        '
        'SecondaryHalf
        '
        Me.SecondaryHalf.BackColor = System.Drawing.Color.Transparent
        Me.SecondaryHalf.Checked = True
        Me.SecondaryHalf.Location = New System.Drawing.Point(40, 0)
        Me.SecondaryHalf.Name = "SecondaryHalf"
        Me.SecondaryHalf.Size = New System.Drawing.Size(40, 21)
        Me.SecondaryHalf.TabIndex = 252
        Me.SecondaryHalf.TabStop = True
        Me.SecondaryHalf.Text = "½"
        Me.SecondaryHalf.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PrimaryNone)
        Me.Panel2.Controls.Add(Me.PrimaryMax)
        Me.Panel2.Controls.Add(Me.PrimaryFull)
        Me.Panel2.Controls.Add(Me.PrimaryHalf)
        Me.Panel2.Location = New System.Drawing.Point(260, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 21)
        Me.Panel2.TabIndex = 253
        '
        'PrimaryNone
        '
        Me.PrimaryNone.BackColor = System.Drawing.Color.Transparent
        Me.PrimaryNone.Location = New System.Drawing.Point(0, 0)
        Me.PrimaryNone.Name = "PrimaryNone"
        Me.PrimaryNone.Size = New System.Drawing.Size(40, 21)
        Me.PrimaryNone.TabIndex = 255
        Me.PrimaryNone.Text = "0"
        Me.PrimaryNone.UseVisualStyleBackColor = False
        '
        'PrimaryMax
        '
        Me.PrimaryMax.BackColor = System.Drawing.Color.Transparent
        Me.PrimaryMax.Location = New System.Drawing.Point(120, 0)
        Me.PrimaryMax.Name = "PrimaryMax"
        Me.PrimaryMax.Size = New System.Drawing.Size(40, 21)
        Me.PrimaryMax.TabIndex = 254
        Me.PrimaryMax.Text = "1½"
        Me.PrimaryMax.UseVisualStyleBackColor = False
        '
        'PrimaryFull
        '
        Me.PrimaryFull.BackColor = System.Drawing.Color.Transparent
        Me.PrimaryFull.Checked = True
        Me.PrimaryFull.Location = New System.Drawing.Point(80, 0)
        Me.PrimaryFull.Name = "PrimaryFull"
        Me.PrimaryFull.Size = New System.Drawing.Size(40, 21)
        Me.PrimaryFull.TabIndex = 253
        Me.PrimaryFull.TabStop = True
        Me.PrimaryFull.Text = "1"
        Me.PrimaryFull.UseVisualStyleBackColor = False
        '
        'PrimaryHalf
        '
        Me.PrimaryHalf.BackColor = System.Drawing.Color.Transparent
        Me.PrimaryHalf.Location = New System.Drawing.Point(40, 0)
        Me.PrimaryHalf.Name = "PrimaryHalf"
        Me.PrimaryHalf.Size = New System.Drawing.Size(40, 21)
        Me.PrimaryHalf.TabIndex = 252
        Me.PrimaryHalf.Text = "½"
        Me.PrimaryHalf.UseVisualStyleBackColor = False
        '
        'PSTRLabel
        '
        Me.PSTRLabel.Location = New System.Drawing.Point(190, 80)
        Me.PSTRLabel.Name = "PSTRLabel"
        Me.PSTRLabel.Size = New System.Drawing.Size(70, 21)
        Me.PSTRLabel.TabIndex = 252
        Me.PSTRLabel.Text = "STR Bonus:"
        Me.PSTRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 185)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(404, 3)
        Me.IndentedLine3.TabIndex = 239
        Me.IndentedLine3.TabStop = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(0, 603)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(434, 5)
        Me.IndentedLine1.TabIndex = 98
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 385)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(404, 2)
        Me.IndentedLine2.TabIndex = 239
        Me.IndentedLine2.TabStop = False
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine4.Location = New System.Drawing.Point(15, 300)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(404, 2)
        Me.IndentedLine4.TabIndex = 239
        Me.IndentedLine4.TabStop = False
        '
        'PrimaryDropdown
        '
        Me.Errors.SetIconPadding(Me.PrimaryDropdown, 180)
        Me.PrimaryDropdown.Location = New System.Drawing.Point(80, 50)
        Me.PrimaryDropdown.Name = "PrimaryDropdown"
        Me.PrimaryDropdown.Properties.AutoHeight = False
        Me.PrimaryDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrimaryDropdown.Properties.DropDownRows = 10
        Me.PrimaryDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PrimaryDropdown.Size = New System.Drawing.Size(150, 21)
        Me.PrimaryDropdown.TabIndex = 1
        '
        'PrimarySpin
        '
        Me.PrimarySpin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimarySpin.Location = New System.Drawing.Point(255, 50)
        Me.PrimarySpin.Name = "PrimarySpin"
        Me.PrimarySpin.Properties.Appearance.Options.UseTextOptions = True
        Me.PrimarySpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PrimarySpin.Properties.AutoHeight = False
        Me.PrimarySpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PrimarySpin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrimarySpin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrimarySpin.Properties.IsFloatValue = False
        Me.PrimarySpin.Properties.Mask.EditMask = "N00"
        Me.PrimarySpin.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.PrimarySpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrimarySpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PrimarySpin.Size = New System.Drawing.Size(50, 21)
        Me.PrimarySpin.TabIndex = 2
        '
        'SecondaryAttacks
        '
        Me.SecondaryAttacks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SecondaryAttacks.IntegralHeight = False
        Me.SecondaryAttacks.Location = New System.Drawing.Point(15, 400)
        Me.SecondaryAttacks.Name = "SecondaryAttacks"
        Me.SecondaryAttacks.Size = New System.Drawing.Size(279, 185)
        Me.SecondaryAttacks.TabIndex = 14
        '
        'SecondarySpin
        '
        Me.SecondarySpin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SecondarySpin.Location = New System.Drawing.Point(245, 235)
        Me.SecondarySpin.Name = "SecondarySpin"
        Me.SecondarySpin.Properties.Appearance.Options.UseTextOptions = True
        Me.SecondarySpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SecondarySpin.Properties.AutoHeight = False
        Me.SecondarySpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SecondarySpin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SecondarySpin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SecondarySpin.Properties.IsFloatValue = False
        Me.SecondarySpin.Properties.Mask.EditMask = "N00"
        Me.SecondarySpin.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.SecondarySpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SecondarySpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SecondarySpin.Size = New System.Drawing.Size(50, 21)
        Me.SecondarySpin.TabIndex = 9
        '
        'SecondaryDropdown
        '
        Me.SecondaryDropdown.CausesValidation = False
        Me.SecondaryDropdown.Location = New System.Drawing.Point(65, 235)
        Me.SecondaryDropdown.Name = "SecondaryDropdown"
        Me.SecondaryDropdown.Properties.AutoHeight = False
        Me.SecondaryDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SecondaryDropdown.Properties.DropDownRows = 10
        Me.SecondaryDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SecondaryDropdown.Size = New System.Drawing.Size(155, 21)
        Me.SecondaryDropdown.TabIndex = 8
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'EnhancementBonus
        '
        Me.EnhancementBonus.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Enabled = False
        Me.EnhancementBonus.Location = New System.Drawing.Point(110, 80)
        Me.EnhancementBonus.Name = "EnhancementBonus"
        Me.EnhancementBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.EnhancementBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EnhancementBonus.Properties.AutoHeight = False
        Me.EnhancementBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.EnhancementBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.IsFloatValue = False
        Me.EnhancementBonus.Properties.Mask.EditMask = "N00"
        Me.EnhancementBonus.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.EnhancementBonus.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.EnhancementBonus.Size = New System.Drawing.Size(50, 21)
        Me.EnhancementBonus.TabIndex = 5
        '
        'SEnhancement
        '
        Me.SEnhancement.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SEnhancement.Location = New System.Drawing.Point(110, 265)
        Me.SEnhancement.Name = "SEnhancement"
        Me.SEnhancement.Properties.Appearance.Options.UseTextOptions = True
        Me.SEnhancement.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SEnhancement.Properties.AutoHeight = False
        Me.SEnhancement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SEnhancement.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SEnhancement.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SEnhancement.Properties.IsFloatValue = False
        Me.SEnhancement.Properties.Mask.EditMask = "N00"
        Me.SEnhancement.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.SEnhancement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SEnhancement.Size = New System.Drawing.Size(50, 21)
        Me.SEnhancement.TabIndex = 11
        '
        'ManufacturedSpin
        '
        Me.ManufacturedSpin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ManufacturedSpin.Location = New System.Drawing.Point(190, 350)
        Me.ManufacturedSpin.Name = "ManufacturedSpin"
        Me.ManufacturedSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.ManufacturedSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ManufacturedSpin.Properties.AutoHeight = False
        Me.ManufacturedSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ManufacturedSpin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ManufacturedSpin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ManufacturedSpin.Properties.IsFloatValue = False
        Me.ManufacturedSpin.Properties.Mask.EditMask = "N00"
        Me.ManufacturedSpin.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.ManufacturedSpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ManufacturedSpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ManufacturedSpin.Size = New System.Drawing.Size(50, 21)
        Me.ManufacturedSpin.TabIndex = 12
        '
        'CreateAttackDialog
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(433, 656)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PSTRLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ShowCheck)
        Me.Controls.Add(Me.EnhancementBonus)
        Me.Controls.Add(Me.SEnhancement)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PrimarySpin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EnhancedCheck)
        Me.Controls.Add(Me.NoneRadio)
        Me.Controls.Add(Me.RemoveAttack)
        Me.Controls.Add(Me.IndentedLine3)
        Me.Controls.Add(Me.AddManufactured)
        Me.Controls.Add(Me.SecondarySpin)
        Me.Controls.Add(Me.SecondaryDropdown)
        Me.Controls.Add(Me.AddNatural)
        Me.Controls.Add(Me.SecondaryAttacks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ManufacturedRadio)
        Me.Controls.Add(Me.PrimaryDropdown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.NaturalRadio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ManufacturedSpin)
        Me.Controls.Add(Me.IndentedLine4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(425, 500)
        Me.Name = "CreateAttackDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Attack Options"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PrimaryDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimarySpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondarySpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondaryDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEnhancement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManufacturedSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Enumerations"

    Enum AttackType
        Natural
        Manufactured
        None
    End Enum

#End Region

#Region "Strucutres"

    'strtucture for keeping information about an attak
    Structure AttackData

        Public Type As AttackType
        Public Number As Integer
        Public Weapon As Objects.ObjectData
        Public Enhancement As Integer
        Public STRBonus As Rules.Weapons.STRBonus

        Public Overrides Function ToString() As String
            Select Case Type

                Case AttackType.Manufactured
                    If Number > 1 Then
                        Return Number & " " & "Manufactured Weapons"
                    Else
                        Return Number & " " & "Manufactured Weapon"
                    End If

                Case AttackType.Natural
                    Dim STRString As String = ""

                    Select Case STRBonus
                        Case Rules.Weapons.STRBonus.Full
                            STRString = " (1 * STR Bonus)"
                        Case Rules.Weapons.STRBonus.Half
                            STRString = ""
                        Case Rules.Weapons.STRBonus.Max
                            STRString = " (1½ * STR Bonus)"
                        Case Rules.Weapons.STRBonus.None
                            STRString = " (No STR Bonus)"
                    End Select

                    If Enhancement > 0 Then
                        Return Number & " +" & Enhancement.ToString & " " & Weapon.Name & STRString
                    Else
                        Return Number & " " & Weapon.Name & STRString
                    End If

            End Select
            Return ""
        End Function

    End Structure

#End Region

#Region "Member Variables"

    Private IsLoading As Boolean = True
    Public WeaponsDatalist As General.DataListItem()
    Public FilteredDatalist As General.DataListItem()
    Public SecondaryNaturalWeapons As Boolean = False

#End Region

#Region "Properties"

    Public ReadOnly Property PrimaryAttackData() As AttackData
        Get
            Dim Attack As New AttackData

            If NaturalRadio.Checked Then
                Attack.Type = AttackType.Natural
                Attack.Number = CInt(PrimarySpin.Value)

                If ShowCheck.Checked OrElse FilteredDatalist.Length = 0 Then
                    Attack.Weapon = CType(CType(WeaponsDatalist(PrimaryDropdown.SelectedIndex), General.DataListItem).ValueMember, Objects.ObjectData)
                Else
                    Attack.Weapon = CType(CType(FilteredDatalist(PrimaryDropdown.SelectedIndex), General.DataListItem).ValueMember, Objects.ObjectData)
                End If

                If EnhancedCheck.Checked Then Attack.Enhancement = CInt(EnhancementBonus.Value)

                If PrimaryNone.Checked Then
                    Attack.STRBonus = Rules.Weapons.STRBonus.None
                ElseIf PrimaryHalf.Checked Then
                    Attack.STRBonus = Rules.Weapons.STRBonus.Half
                ElseIf PrimaryFull.Checked Then
                    Attack.STRBonus = Rules.Weapons.STRBonus.Full
                Else
                    Attack.STRBonus = Rules.Weapons.STRBonus.Max
                End If

            ElseIf ManufacturedRadio.Checked Then
                Attack.Type = AttackType.Manufactured
            Else
                Attack.Type = AttackType.None
            End If

            Return Attack

        End Get
    End Property

    Public ReadOnly Property SecondaryAttackData() As ArrayList
        Get
            Return New ArrayList(SecondaryAttacks.Items)
        End Get
    End Property

#End Region

    'init
    Public Sub Init(ByVal RaceObject As Objects.ObjectData)
        Try

            'get the weapons
            WeaponsDatalist = Rules.Index.DataList(RPGXplorer.ObjectQueries.NaturalWeapons)

            'get the filtered weapons from the creatures allowed weapons list
            'FilteredDatalist = Rules.Index.DataList(RaceObject.ChildrenOfType(Objects.NaturalWeaponType))

            Dim TempWeaponCollection As New Objects.ObjectDataCollection
            For Each TempWeapon As Objects.ObjectData In RaceObject.ChildrenOfType(Objects.NaturalWeaponType)
                TempWeaponCollection.Add(TempWeapon.GetFKObject("Weapon"))
            Next

            FilteredDatalist = Rules.Index.DataList(TempWeaponCollection)

            'load dropdowns
            If FilteredDatalist.Length > 0 Then
                ShowCheck.Enabled = True
                PrimaryDropdown.Properties.Items.AddRange(FilteredDatalist)
                SecondaryDropdown.Properties.Items.AddRange(FilteredDatalist)
            Else
                PrimaryDropdown.Properties.Items.AddRange(WeaponsDatalist)
                SecondaryDropdown.Properties.Items.AddRange(WeaponsDatalist)
            End If

            IsLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'validates panel
    Private Shadows Function Validate() As Boolean
        Try

            Validate = True

            'if we have a natural weapon make sure its specified
            If NaturalRadio.Checked Then
                If PrimaryDropdown.SelectedIndex = -1 Then
                    Validate = False
                    Errors.SetError(PrimaryDropdown, "Natural Weapon must be specified.")
                Else
                    Errors.SetError(PrimaryDropdown, "")
                End If
            Else
                Errors.SetError(PrimaryDropdown, "")
            End If

            'if we have no primary, make sure we have a secondary
            If NoneRadio.Checked = True Then
                If SecondaryAttacks.Items.Count = 0 Then
                    Validate = False
                    Errors.SetError(OK, "At least one attack must be specified.")
                Else
                    Errors.SetError(OK, "")
                End If
            Else
                Errors.SetError(OK, "")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'updates secondary attack list if  primary radio is changed
    Private Sub UpdateSecondaryAttacks()
        Try
            Dim RemoveList As New ArrayList
            Dim AD As AttackData

            For Each AD In SecondaryAttacks.Items
                If AD.Type = AttackType.Manufactured Then
                    RemoveList.Add(AD)
                End If
            Next

            For Each AD In RemoveList
                SecondaryAttacks.Items.Remove(AD)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EnableDisablePrimaryRadios(ByVal value As Boolean)
        Try
            If value = True Then
                PrimaryNone.Enabled = True
                PrimaryHalf.Enabled = True
                PrimaryFull.Enabled = True
                PrimaryMax.Enabled = True
                PSTRLabel.Enabled = True
            Else
                PrimaryNone.Enabled = False
                PrimaryHalf.Enabled = False
                PrimaryFull.Enabled = False
                PrimaryFull.Checked = True
                PrimaryMax.Enabled = False
                PSTRLabel.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Click Handlers"

    'ok
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.Validate Then
                'close dialog
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Try
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Event Handling"

    Private Sub Ordinary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NaturalRadio.CheckedChanged
        Try
            If NaturalRadio.Checked Then
                PrimaryDropdown.Enabled = True
                PrimarySpin.Enabled = True
                EnhancedCheck.Enabled = True
                EnableDisablePrimaryRadios(True)
                AddManufactured.Enabled = False
                UpdateSecondaryAttacks()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub InventoryOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManufacturedRadio.CheckedChanged
        Try
            If ManufacturedRadio.Checked Then
                PrimaryDropdown.Enabled = False
                PrimarySpin.Enabled = False
                EnhancedCheck.Enabled = False
                EnhancedCheck.Checked = False
                EnableDisablePrimaryRadios(False)
                PrimarySpin.Value = 1
                PrimaryDropdown.SelectedIndex = -1
                AddManufactured.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneRadio.CheckedChanged
        Try
            If NoneRadio.Checked Then
                PrimaryDropdown.Enabled = False
                PrimarySpin.Enabled = False
                EnhancedCheck.Enabled = False
                EnhancedCheck.Checked = False
                EnableDisablePrimaryRadios(False)
                PrimarySpin.Value = 1
                PrimaryDropdown.SelectedIndex = -1
                AddManufactured.Enabled = False
                UpdateSecondaryAttacks()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub EnhancedCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancedCheck.CheckedChanged
        If EnhancedCheck.Checked Then
            EnhancementBonus.Enabled = True
        Else
            EnhancementBonus.Value = 1
            EnhancementBonus.Enabled = False
        End If
    End Sub

    Private Sub AddManufactured_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddManufactured.Click
        Try
            If SecondaryAttacks.Items.Count > 4 Then
                General.ShowErrorDialog("A maximum of five offhand weapons are allowed.")
                Exit Sub
            End If
            'add a manufactured weapon slot
            Dim Attack As New AttackData
            Attack.Type = AttackType.Manufactured
            Attack.Number = CInt(ManufacturedSpin.Value)
            SecondaryAttacks.Items.Add(Attack)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SecondaryAttacks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SecondaryAttacks.DoubleClick
        Try
            RemoveAttack_Click(Nothing, Nothing)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAttack.Click
        Try
            If SecondaryAttacks.SelectedIndex <> -1 Then
                SecondaryAttacks.Items.RemoveAt(SecondaryAttacks.SelectedIndex)
            End If

            'if we have removed all secondary natural attacks - we may have to enanble primary str bonus
            SecondaryNaturalWeapons = False
            For Each Attack As AttackData In SecondaryAttacks.Items
                If Attack.Type = AttackType.Natural Then
                    SecondaryNaturalWeapons = True
                    Exit For
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddNatural_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNatural.Click
        Try
            If SecondaryDropdown.SelectedIndex = -1 Then Exit Sub

            If SecondaryAttacks.Items.Count > 4 Then
                General.ShowErrorDialog("A maximum of five offhand weapons are allowed.")
                Exit Sub
            End If

            Dim Attack As AttackData
            Attack.Type = AttackType.Natural
            Attack.Number = CInt(SecondarySpin.Value)

            'set STR bonus
            If SecondaryHalf.Checked Then
                Attack.STRBonus = Rules.Weapons.STRBonus.Half
            ElseIf SecondaryFull.Checked Then
                Attack.STRBonus = Rules.Weapons.STRBonus.Full
            ElseIf SecondaryMax.Checked Then
                Attack.STRBonus = Rules.Weapons.STRBonus.Max
            Else
                Attack.STRBonus = Rules.Weapons.STRBonus.None
            End If

            If ShowCheck.Checked OrElse FilteredDatalist.Length = 0 Then
                Attack.Weapon = CType(CType(WeaponsDatalist(SecondaryDropdown.SelectedIndex), General.DataListItem).ValueMember, Objects.ObjectData)
            Else
                Attack.Weapon = CType(CType(FilteredDatalist(SecondaryDropdown.SelectedIndex), General.DataListItem).ValueMember, Objects.ObjectData)
            End If

            Attack.Enhancement = CInt(SEnhancement.Value)
            SecondaryAttacks.Items.Add(Attack)

            'if we have added a secondary natural attack - disable the sole primary natural weapon bonus
            SecondaryHalf.Checked = True
            SecondaryNaturalWeapons = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Paint"

    Private Sub CreateAttackDialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height - (Me.Height - IndentedLine1.Top))
        Dim gradbrush As New Drawing2D.LinearGradientBrush(rect, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)

        Try
            e.Graphics.FillRectangle(gradbrush, rect)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'change dropdowns to include all natural weapons when checked
    Private Sub ShowCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCheck.CheckedChanged
        Try
            'clear current list
            PrimaryDropdown.Properties.Items.Clear()
            SecondaryDropdown.Properties.Items.Clear()

            If ShowCheck.Checked Then
                PrimaryDropdown.Properties.Items.AddRange(WeaponsDatalist)
                SecondaryDropdown.Properties.Items.AddRange(WeaponsDatalist)
            Else
                PrimaryDropdown.SelectedIndex = -1
                SecondaryDropdown.SelectedIndex = -1
                PrimaryDropdown.Properties.Items.AddRange(FilteredDatalist)
                SecondaryDropdown.Properties.Items.AddRange(FilteredDatalist)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''if we only have a single primary natural weapon we may need to enable the STR bonus
    'Private Sub PrimarySpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimarySpin.EditValueChanged
    '    If PrimarySpin.Value = 1 AndAlso NaturalRadio.Checked AndAlso (Not SecondaryNaturalWeapons) Then
    '        STRCheck.Enabled = True
    '    Else
    '        STRCheck.Enabled = False
    '        STRCheck.Checked = False
    '    End If
    'End Sub

End Class