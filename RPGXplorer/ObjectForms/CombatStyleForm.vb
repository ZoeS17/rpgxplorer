Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CombatStyleForm
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
    Public WithEvents Basics As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents ConditionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Level2 As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Level3 As DevExpress.XtraEditors.SpinEdit
    Public WithEvents FirstFeat1 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents StyleName1 As DevExpress.XtraEditors.TextEdit
    Public WithEvents SecondFeat1 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ThirdFeat1 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents StyleTab1 As System.Windows.Forms.TabPage
    Public WithEvents Level1 As DevExpress.XtraEditors.TextEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents StyleTab2 As System.Windows.Forms.TabPage
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents ThirdFeat2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SecondFeat2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents StyleName2 As DevExpress.XtraEditors.TextEdit
    Public WithEvents FirstFeat2 As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Level1 = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Level3 = New DevExpress.XtraEditors.SpinEdit
        Me.Level2 = New DevExpress.XtraEditors.SpinEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.ConditionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.StyleTab1 = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ThirdFeat1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SecondFeat1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.StyleName1 = New DevExpress.XtraEditors.TextEdit
        Me.FirstFeat1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.StyleTab2 = New System.Windows.Forms.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ThirdFeat2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SecondFeat2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.StyleName2 = New DevExpress.XtraEditors.TextEdit
        Me.FirstFeat2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.Level1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StyleTab1.SuspendLayout()
        CType(Me.ThirdFeat1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondFeat1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleName1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstFeat1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StyleTab2.SuspendLayout()
        CType(Me.ThirdFeat2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondFeat2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleName2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstFeat2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.Basics)
        Me.TabControl1.Controls.Add(Me.StyleTab1)
        Me.TabControl1.Controls.Add(Me.StyleTab2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.IndentedLine2)
        Me.Basics.Controls.Add(Me.Level1)
        Me.Basics.Controls.Add(Me.Label1)
        Me.Basics.Controls.Add(Me.Label2)
        Me.Basics.Controls.Add(Me.Label3)
        Me.Basics.Controls.Add(Me.Level3)
        Me.Basics.Controls.Add(Me.Level2)
        Me.Basics.Controls.Add(Me.Label8)
        Me.Basics.Controls.Add(Me.ConditionDropdown)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 349)
        Me.Basics.TabIndex = 0
        Me.Basics.Text = "Combat Style"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 241
        Me.IndentedLine2.TabStop = False
        '
        'Level1
        '
        Me.Level1.CausesValidation = False
        Me.Level1.Location = New System.Drawing.Point(205, 15)
        Me.Level1.Name = "Level1"
        '
        'Level1.Properties
        '
        Me.Level1.Properties.Appearance.Options.UseTextOptions = True
        Me.Level1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level1.Properties.AutoHeight = False
        Me.Level1.Properties.MaxLength = 50
        Me.Level1.Properties.ReadOnly = True
        Me.Level1.Size = New System.Drawing.Size(40, 21)
        Me.Level1.TabIndex = 240
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Combat Style Mastery Level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 21)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Improved Combat Style Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 21)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = "Combat Style Selection Level"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Level3
        '
        Me.Level3.CausesValidation = False
        Me.Level3.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Level3.Location = New System.Drawing.Point(205, 75)
        Me.Level3.Name = "Level3"
        '
        'Level3.Properties
        '
        Me.Level3.Properties.Appearance.Options.UseTextOptions = True
        Me.Level3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level3.Properties.AutoHeight = False
        Me.Level3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level3.Properties.IsFloatValue = False
        Me.Level3.Properties.Mask.BeepOnError = True
        Me.Level3.Properties.Mask.EditMask = "d"
        Me.Level3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Level3.Properties.Mask.ShowPlaceHolders = False
        Me.Level3.Size = New System.Drawing.Size(55, 21)
        Me.Level3.TabIndex = 2
        '
        'Level2
        '
        Me.Level2.CausesValidation = False
        Me.Level2.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Level2.Location = New System.Drawing.Point(205, 45)
        Me.Level2.Name = "Level2"
        '
        'Level2.Properties
        '
        Me.Level2.Properties.Appearance.Options.UseTextOptions = True
        Me.Level2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level2.Properties.AutoHeight = False
        Me.Level2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level2.Properties.IsFloatValue = False
        Me.Level2.Properties.Mask.BeepOnError = True
        Me.Level2.Properties.Mask.EditMask = "d"
        Me.Level2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Level2.Properties.Mask.ShowPlaceHolders = False
        Me.Level2.Size = New System.Drawing.Size(55, 21)
        Me.Level2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.CausesValidation = False
        Me.Label8.Location = New System.Drawing.Point(15, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 21)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Condition For Combat Style Benefit"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConditionDropdown
        '
        Me.ConditionDropdown.CausesValidation = False
        Me.ConditionDropdown.Location = New System.Drawing.Point(15, 155)
        Me.ConditionDropdown.Name = "ConditionDropdown"
        '
        'ConditionDropdown.Properties
        '
        Me.ConditionDropdown.Properties.AutoHeight = False
        Me.ConditionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConditionDropdown.Properties.DropDownRows = 10
        Me.ConditionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ConditionDropdown.Size = New System.Drawing.Size(200, 21)
        Me.ConditionDropdown.TabIndex = 3
        '
        'StyleTab1
        '
        Me.StyleTab1.Controls.Add(Me.Label10)
        Me.StyleTab1.Controls.Add(Me.Label9)
        Me.StyleTab1.Controls.Add(Me.Label7)
        Me.StyleTab1.Controls.Add(Me.ThirdFeat1)
        Me.StyleTab1.Controls.Add(Me.SecondFeat1)
        Me.StyleTab1.Controls.Add(Me.Label6)
        Me.StyleTab1.Controls.Add(Me.StyleName1)
        Me.StyleTab1.Controls.Add(Me.FirstFeat1)
        Me.StyleTab1.Location = New System.Drawing.Point(4, 22)
        Me.StyleTab1.Name = "StyleTab1"
        Me.StyleTab1.Size = New System.Drawing.Size(407, 349)
        Me.StyleTab1.TabIndex = 2
        Me.StyleTab1.Text = "Style Choice"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.CausesValidation = False
        Me.Label10.Location = New System.Drawing.Point(15, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 21)
        Me.Label10.TabIndex = 228
        Me.Label10.Text = "Third Feat"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.CausesValidation = False
        Me.Label9.Location = New System.Drawing.Point(15, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 21)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Second Feat"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.CausesValidation = False
        Me.Label7.Location = New System.Drawing.Point(15, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "First Feat"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ThirdFeat1
        '
        Me.ThirdFeat1.Location = New System.Drawing.Point(90, 105)
        Me.ThirdFeat1.Name = "ThirdFeat1"
        '
        'ThirdFeat1.Properties
        '
        Me.ThirdFeat1.Properties.AutoHeight = False
        Me.ThirdFeat1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ThirdFeat1.Properties.DropDownRows = 10
        Me.ThirdFeat1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ThirdFeat1.Size = New System.Drawing.Size(200, 21)
        Me.ThirdFeat1.TabIndex = 3
        '
        'SecondFeat1
        '
        Me.SecondFeat1.Location = New System.Drawing.Point(90, 75)
        Me.SecondFeat1.Name = "SecondFeat1"
        '
        'SecondFeat1.Properties
        '
        Me.SecondFeat1.Properties.AutoHeight = False
        Me.SecondFeat1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SecondFeat1.Properties.DropDownRows = 10
        Me.SecondFeat1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SecondFeat1.Size = New System.Drawing.Size(200, 21)
        Me.SecondFeat1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.CausesValidation = False
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 223
        Me.Label6.Text = "Style Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StyleName1
        '
        Me.StyleName1.Location = New System.Drawing.Point(90, 15)
        Me.StyleName1.Name = "StyleName1"
        '
        'StyleName1.Properties
        '
        Me.StyleName1.Properties.AutoHeight = False
        Me.StyleName1.Properties.MaxLength = 100
        Me.StyleName1.Size = New System.Drawing.Size(200, 21)
        Me.StyleName1.TabIndex = 0
        '
        'FirstFeat1
        '
        Me.FirstFeat1.Location = New System.Drawing.Point(90, 45)
        Me.FirstFeat1.Name = "FirstFeat1"
        '
        'FirstFeat1.Properties
        '
        Me.FirstFeat1.Properties.AutoHeight = False
        Me.FirstFeat1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FirstFeat1.Properties.DropDownRows = 10
        Me.FirstFeat1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FirstFeat1.Size = New System.Drawing.Size(200, 21)
        Me.FirstFeat1.TabIndex = 1
        '
        'StyleTab2
        '
        Me.StyleTab2.Controls.Add(Me.Label11)
        Me.StyleTab2.Controls.Add(Me.Label12)
        Me.StyleTab2.Controls.Add(Me.Label13)
        Me.StyleTab2.Controls.Add(Me.ThirdFeat2)
        Me.StyleTab2.Controls.Add(Me.SecondFeat2)
        Me.StyleTab2.Controls.Add(Me.Label14)
        Me.StyleTab2.Controls.Add(Me.StyleName2)
        Me.StyleTab2.Controls.Add(Me.FirstFeat2)
        Me.StyleTab2.Location = New System.Drawing.Point(4, 22)
        Me.StyleTab2.Name = "StyleTab2"
        Me.StyleTab2.Size = New System.Drawing.Size(407, 349)
        Me.StyleTab2.TabIndex = 3
        Me.StyleTab2.Text = "Style Choice"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.CausesValidation = False
        Me.Label11.Location = New System.Drawing.Point(15, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 21)
        Me.Label11.TabIndex = 244
        Me.Label11.Text = "Third Feat"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.CausesValidation = False
        Me.Label12.Location = New System.Drawing.Point(15, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 21)
        Me.Label12.TabIndex = 243
        Me.Label12.Text = "Second Feat"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.CausesValidation = False
        Me.Label13.Location = New System.Drawing.Point(15, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 21)
        Me.Label13.TabIndex = 242
        Me.Label13.Text = "First Feat"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ThirdFeat2
        '
        Me.ThirdFeat2.Location = New System.Drawing.Point(90, 105)
        Me.ThirdFeat2.Name = "ThirdFeat2"
        '
        'ThirdFeat2.Properties
        '
        Me.ThirdFeat2.Properties.AutoHeight = False
        Me.ThirdFeat2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ThirdFeat2.Properties.DropDownRows = 10
        Me.ThirdFeat2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ThirdFeat2.Size = New System.Drawing.Size(200, 21)
        Me.ThirdFeat2.TabIndex = 240
        '
        'SecondFeat2
        '
        Me.SecondFeat2.Location = New System.Drawing.Point(90, 75)
        Me.SecondFeat2.Name = "SecondFeat2"
        '
        'SecondFeat2.Properties
        '
        Me.SecondFeat2.Properties.AutoHeight = False
        Me.SecondFeat2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SecondFeat2.Properties.DropDownRows = 10
        Me.SecondFeat2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SecondFeat2.Size = New System.Drawing.Size(200, 21)
        Me.SecondFeat2.TabIndex = 239
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.CausesValidation = False
        Me.Label14.Location = New System.Drawing.Point(15, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 21)
        Me.Label14.TabIndex = 241
        Me.Label14.Text = "Style Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StyleName2
        '
        Me.StyleName2.Location = New System.Drawing.Point(90, 15)
        Me.StyleName2.Name = "StyleName2"
        '
        'StyleName2.Properties
        '
        Me.StyleName2.Properties.AutoHeight = False
        Me.StyleName2.Properties.MaxLength = 100
        Me.StyleName2.Size = New System.Drawing.Size(200, 21)
        Me.StyleName2.TabIndex = 237
        '
        'FirstFeat2
        '
        Me.FirstFeat2.Location = New System.Drawing.Point(90, 45)
        Me.FirstFeat2.Name = "FirstFeat2"
        '
        'FirstFeat2.Properties
        '
        Me.FirstFeat2.Properties.AutoHeight = False
        Me.FirstFeat2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FirstFeat2.Properties.DropDownRows = 10
        Me.FirstFeat2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FirstFeat2.Size = New System.Drawing.Size(200, 21)
        Me.FirstFeat2.TabIndex = 238
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
        'CombatStyleForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CombatStyleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combat Style"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.Level1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StyleTab1.ResumeLayout(False)
        CType(Me.ThirdFeat1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondFeat1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleName1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstFeat1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StyleTab2.ResumeLayout(False)
        CType(Me.ThirdFeat2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondFeat2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleName2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstFeat2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mInitOK As Boolean = True

    Private PreconditionIndex As DataListItem()
    Private FeatIndex As DataListItem()

    Private HighestLevel, Level As Integer

    'init
    Public Sub Init()
        Try
            'initialise controls

            'get the highest level
            For Each Obj As Objects.ObjectData In mObject.Parent.Parent.ChildrenOfType(Objects.ClassLevelType)
                Level = CInt(Obj.Element("Level"))
                If Level > HighestLevel Then HighestLevel = Level
            Next

            'must be 2 levels after the level being added to
            Level = mObject.Parent.ElementAsInteger("Level")
            If Level + 2 > HighestLevel Then
                General.ShowInfoDialog("You cannot add combat style to this level as there must be at least 2 higher levels defined.")
                mInitOK = False
                Exit Sub
            End If

            PreconditionIndex = Rules.Index.DataList(XML.DBTypes.SystemComponents, Objects.SystemPreconditionDefinitionType, True)

            Dim FeatObjects As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.Feats, XPathQueries.FeatsWithoutFocus)
            FeatIndex = Rules.Index.DataList(FeatObjects)

            'set upper level bounds for the combat styles
            Level1.Text = Level.ToString
            Level2.Properties.MinValue = Level + 1
            Level2.Properties.MaxValue = HighestLevel - 1
            Level3.Properties.MinValue = Level + 2
            Level3.Properties.MaxValue = HighestLevel

            ConditionDropdown.Properties.Items.AddRange(Rules.Index.DataList(XML.DBTypes.SystemComponents, Objects.SystemPreconditionDefinitionType, True))
            FirstFeat1.Properties.Items.AddRange(FeatIndex)
            SecondFeat1.Properties.Items.AddRange(FeatIndex)
            ThirdFeat1.Properties.Items.AddRange(FeatIndex)

            FirstFeat2.Properties.Items.AddRange(FeatIndex)
            SecondFeat2.Properties.Items.AddRange(FeatIndex)
            ThirdFeat2.Properties.Items.AddRange(FeatIndex)

            'init Properties Tab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object    
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.CombatStyleType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Combat Style"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            Return mInitOK

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Combat Style"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            Level2.Value = mObject.ElementAsInteger("SecondLevel")
            Level3.Value = mObject.ElementAsInteger("ThirdLevel")
            ConditionDropdown.SelectedIndex = Rules.Index.GetGuidIndex(PreconditionIndex, mObject.GetFKGuid("Condition"))

            StyleName1.Text = mObject.Element("Style1")
            FirstFeat1.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("FirstFeat1"))
            SecondFeat1.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("SecondFeat1"))
            ThirdFeat1.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("ThirdFeat1"))

            StyleName2.Text = mObject.Element("Style2")
            FirstFeat2.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("FirstFeat2"))
            SecondFeat2.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("SecondFeat2"))
            ThirdFeat2.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("ThirdFeat2"))

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As New Objects.ObjectData
        Dim Improved As New Objects.ObjectData
        Dim Mastery As New Objects.ObjectData
        Dim CharacterClass As Rules.CharacterClass

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                CharacterClass = Caches.GetCharacterClass(mObject.Parent.Parent.Parent.ParentGUID)

                Select Case mMode
                    Case FormMode.Add

                        'improved object
                        Improved.Name = "Improved Combat Style"
                        Improved.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Improved.Type = Objects.CombatStyleImprovedFeatType
                        Improved.ParentGUID = CharacterClass.ClassLevel(CInt(Level2.Value)).ObjectGUID
                        Improved.Save()

                        WindowManager.SetDirty(Improved.Parent)

                        'mastery object
                        Mastery.Name = "Combat Style Mastery"
                        Mastery.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Mastery.Type = Objects.CombatstyleMasteryFeatType
                        Mastery.ParentGUID = CharacterClass.ClassLevel(CInt(Level3.Value)).ObjectGUID
                        Mastery.Save()

                        WindowManager.SetDirty(Mastery.Parent)

                    Case FormMode.Edit

                        'style objects may have moved 
                        Improved = mObject.GetFKObject("ImprovedObject")
                        WindowManager.SetDirty(Improved.Parent)

                        If CInt(Level2.Value) <> mObject.ElementAsInteger("SecondLevel") Then
                            Improved.ParentGUID = CharacterClass.ClassLevel(CInt(Level2.Value)).ObjectGUID
                            Improved.Save()
                            WindowManager.SetDirty(Improved.Parent)
                        End If

                        Mastery = mObject.GetFKObject("MasteryObject")
                        WindowManager.SetDirty(Mastery.Parent)

                        If CInt(Level3.Value) <> mObject.ElementAsInteger("ThirdLevel") Then
                            Mastery.ParentGUID = CharacterClass.ClassLevel(CInt(Level3.Value)).ObjectGUID
                            Mastery.Save()
                            WindowManager.SetDirty(Mastery.Parent)
                        End If

                End Select

                mObject.Name = "Combat Style"
                mObject.Element("SecondLevel") = Level2.Text
                mObject.Element("ThirdLevel") = Level3.Text
                If ConditionDropdown.Text <> "" Then mObject.FKElement("Condition", ConditionDropdown.Text, "Name", CType(ConditionDropdown.SelectedItem, DataListItem).ObjectGUID) Else mObject.FKSetNull("Condition")

                mObject.Element("Style1") = StyleName1.Text
                mObject.FKElement("FirstFeat1", FirstFeat1.Text, "Name", CType(FirstFeat1.SelectedItem, DataListItem).ObjectGUID)
                mObject.FKElement("SecondFeat1", SecondFeat1.Text, "Name", CType(SecondFeat1.SelectedItem, DataListItem).ObjectGUID)
                mObject.FKElement("ThirdFeat1", ThirdFeat1.Text, "Name", CType(ThirdFeat1.SelectedItem, DataListItem).ObjectGUID)

                mObject.Element("Style2") = StyleName2.Text
                mObject.FKElement("FirstFeat2", FirstFeat2.Text, "Name", CType(FirstFeat2.SelectedItem, DataListItem).ObjectGUID)
                mObject.FKElement("SecondFeat2", SecondFeat2.Text, "Name", CType(SecondFeat2.SelectedItem, DataListItem).ObjectGUID)
                mObject.FKElement("ThirdFeat2", ThirdFeat2.Text, "Name", CType(ThirdFeat2.SelectedItem, DataListItem).ObjectGUID)

                'Keep a record of the feat bonus objects for easy retrival
                mObject.FKElement("ImprovedObject", "", "Name", Improved.ObjectGUID)
                mObject.FKElement("MasteryObject", "", "Name", Mastery.ObjectGUID)

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
            Validate = General.ValidateForm(Me.Basics.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.StyleTab1.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.StyleTab2.Controls, Errors)

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Style Choice Tab Code"

    'Code to Filter out options in the dropdowns as previous selections are made
    Private Sub FirstFeat1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstFeat1.SelectedIndexChanged
        Try
            SecondFeat1.Properties.Items.Clear()
            SecondFeat1.Properties.Items.AddRange(FeatIndex)
            SecondFeat1.Properties.Items.Remove(FirstFeat1.SelectedItem)
            If ThirdFeat1.SelectedIndex <> -1 Then SecondFeat1.Properties.Items.Remove(ThirdFeat1.SelectedItem)

            ThirdFeat1.Properties.Items.Clear()
            ThirdFeat1.Properties.Items.AddRange(FeatIndex)
            ThirdFeat1.Properties.Items.Remove(FirstFeat1.SelectedItem)
            If SecondFeat1.SelectedIndex <> -1 Then ThirdFeat1.Properties.Items.Remove(SecondFeat1.SelectedItem)
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub SecondFeat1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondFeat1.SelectedIndexChanged
        Try
            FirstFeat1.Properties.Items.Clear()
            FirstFeat1.Properties.Items.AddRange(FeatIndex)
            FirstFeat1.Properties.Items.Remove(SecondFeat1.SelectedItem)
            If ThirdFeat1.SelectedIndex <> -1 Then FirstFeat1.Properties.Items.Remove(ThirdFeat1.SelectedItem)

            ThirdFeat1.Properties.Items.Clear()
            ThirdFeat1.Properties.Items.AddRange(FeatIndex)
            ThirdFeat1.Properties.Items.Remove(SecondFeat1.SelectedItem)
            If FirstFeat1.SelectedIndex <> -1 Then ThirdFeat1.Properties.Items.Remove(FirstFeat1.SelectedItem)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ThirdFeat1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ThirdFeat1.SelectedIndexChanged
        Try
            FirstFeat1.Properties.Items.Clear()
            FirstFeat1.Properties.Items.AddRange(FeatIndex)
            FirstFeat1.Properties.Items.Remove(SecondFeat1.SelectedItem)
            If ThirdFeat1.SelectedIndex <> -1 Then FirstFeat1.Properties.Items.Remove(ThirdFeat1.SelectedItem)

            SecondFeat1.Properties.Items.Clear()
            SecondFeat1.Properties.Items.AddRange(FeatIndex)
            SecondFeat1.Properties.Items.Remove(FirstFeat1.SelectedItem)
            If ThirdFeat1.SelectedIndex <> -1 Then SecondFeat1.Properties.Items.Remove(ThirdFeat1.SelectedItem)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FirstFeat2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstFeat2.SelectedIndexChanged
        Try
            SecondFeat2.Properties.Items.Clear()
            SecondFeat2.Properties.Items.AddRange(FeatIndex)
            SecondFeat2.Properties.Items.Remove(FirstFeat2.SelectedItem)
            If ThirdFeat2.SelectedIndex <> -1 Then SecondFeat2.Properties.Items.Remove(ThirdFeat2.SelectedItem)

            ThirdFeat2.Properties.Items.Clear()
            ThirdFeat2.Properties.Items.AddRange(FeatIndex)
            ThirdFeat2.Properties.Items.Remove(FirstFeat2.SelectedItem)
            If SecondFeat2.SelectedIndex <> -1 Then ThirdFeat2.Properties.Items.Remove(SecondFeat2.SelectedItem)

        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub SecondFeat2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondFeat2.SelectedIndexChanged
        Try
            FirstFeat2.Properties.Items.Clear()
            FirstFeat2.Properties.Items.AddRange(FeatIndex)
            FirstFeat2.Properties.Items.Remove(SecondFeat2.SelectedItem)
            If ThirdFeat2.SelectedIndex <> -1 Then FirstFeat2.Properties.Items.Remove(ThirdFeat2.SelectedItem)

            ThirdFeat2.Properties.Items.Clear()
            ThirdFeat2.Properties.Items.AddRange(FeatIndex)
            ThirdFeat2.Properties.Items.Remove(SecondFeat2.SelectedItem)
            If FirstFeat2.SelectedIndex <> -1 Then ThirdFeat2.Properties.Items.Remove(FirstFeat2.SelectedItem)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ThirdFeat2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ThirdFeat2.SelectedIndexChanged
        Try
            FirstFeat2.Properties.Items.Clear()
            FirstFeat2.Properties.Items.AddRange(FeatIndex)
            FirstFeat2.Properties.Items.Remove(SecondFeat2.SelectedItem)
            If ThirdFeat2.SelectedIndex <> -1 Then FirstFeat2.Properties.Items.Remove(ThirdFeat2.SelectedItem)

            SecondFeat2.Properties.Items.Clear()
            SecondFeat2.Properties.Items.AddRange(FeatIndex)
            SecondFeat2.Properties.Items.Remove(FirstFeat2.SelectedItem)
            If ThirdFeat2.SelectedIndex <> -1 Then SecondFeat2.Properties.Items.Remove(ThirdFeat2.SelectedItem)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Combat Style Tab Code"

    'Event Handlers for the Spin Edits to insure the correct progression of the combat style
    Private Sub Level2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level2.EditValueChanged
        Try
            If Level2.Value < (Level + 1) Then Level2.Value = Level + 1
            If Level3.Value <= (Level2.Value + 1) Then Level3.Value = Level2.Value + 1
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    'Private Sub Level3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level3.EditValueChanged
    '    Try
    '        If Level3.Value <= (Level2.Value + 1) Then Level3.Value = Level2.Value + 1
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    Private Sub Level3_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles Level3.EditValueChanging
        Try
            If CType(e.NewValue, Decimal) < (Level2.Value + 1) Then
                e.Cancel = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub


#End Region


End Class
