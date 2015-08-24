Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class FilterForm
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
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents MatchValuesButton As System.Windows.Forms.Button
    Public WithEvents MatchValuesRadio As System.Windows.Forms.RadioButton
    Public WithEvents MatchValues As DevExpress.XtraEditors.TextEdit
    Public WithEvents ContainsRadio As System.Windows.Forms.RadioButton
    Public Shadows WithEvents Contains As DevExpress.XtraEditors.TextEdit
    Public WithEvents FilterName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents LessThanCheck As System.Windows.Forms.CheckBox
    Public WithEvents GreaterThanCheck As System.Windows.Forms.CheckBox
    Public WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents FilterTermsList As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents LessThanSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents GreaterThanSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents RemoveButton As System.Windows.Forms.Button
    Public WithEvents FilterCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents NumericRadio As System.Windows.Forms.RadioButton
    Public WithEvents FilterTab As System.Windows.Forms.TabPage
    Public WithEvents AddButton As System.Windows.Forms.Button
    Public WithEvents UpdateButton As System.Windows.Forms.Button
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents NumericContext As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Public WithEvents NullRadio As System.Windows.Forms.RadioButton
    Public WithEvents EqualsRadio As System.Windows.Forms.RadioButton
    Public WithEvents NotEqualsRadio As System.Windows.Forms.RadioButton
    Public WithEvents EqualsPanel As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterForm))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.FilterTab = New System.Windows.Forms.TabPage
        Me.EqualsPanel = New System.Windows.Forms.Panel
        Me.EqualsRadio = New System.Windows.Forms.RadioButton
        Me.NotEqualsRadio = New System.Windows.Forms.RadioButton
        Me.NullRadio = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.AddButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.LessThanCheck = New System.Windows.Forms.CheckBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MatchValuesButton = New System.Windows.Forms.Button
        Me.FilterTermsList = New DevExpress.XtraEditors.ListBoxControl
        Me.MatchValuesRadio = New System.Windows.Forms.RadioButton
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.FilterName = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.FilterCombo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.MatchValues = New DevExpress.XtraEditors.TextEdit
        Me.ContainsRadio = New System.Windows.Forms.RadioButton
        Me.Contains = New DevExpress.XtraEditors.TextEdit
        Me.NumericRadio = New System.Windows.Forms.RadioButton
        Me.GreaterThanCheck = New System.Windows.Forms.CheckBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LessThanSpin = New DevExpress.XtraEditors.SpinEdit
        Me.GreaterThanSpin = New DevExpress.XtraEditors.SpinEdit
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.UpdateButton = New System.Windows.Forms.Button
        Me.NumericContext = New DevExpress.XtraEditors.ComboBoxEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.FilterTab.SuspendLayout()
        Me.EqualsPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterTermsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatchValues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contains.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LessThanSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreaterThanSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericContext.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(543, 605)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(465, 605)
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
        Me.TabControl1.Controls.Add(Me.FilterTab)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(598, 580)
        Me.TabControl1.TabIndex = 0
        '
        'FilterTab
        '
        Me.FilterTab.Controls.Add(Me.EqualsPanel)
        Me.FilterTab.Controls.Add(Me.NullRadio)
        Me.FilterTab.Controls.Add(Me.Label5)
        Me.FilterTab.Controls.Add(Me.PictureBox3)
        Me.FilterTab.Controls.Add(Me.Label3)
        Me.FilterTab.Controls.Add(Me.AddButton)
        Me.FilterTab.Controls.Add(Me.Label2)
        Me.FilterTab.Controls.Add(Me.LessThanCheck)
        Me.FilterTab.Controls.Add(Me.Label23)
        Me.FilterTab.Controls.Add(Me.PictureBox1)
        Me.FilterTab.Controls.Add(Me.MatchValuesButton)
        Me.FilterTab.Controls.Add(Me.FilterTermsList)
        Me.FilterTab.Controls.Add(Me.MatchValuesRadio)
        Me.FilterTab.Controls.Add(Me.IndentedLine1)
        Me.FilterTab.Controls.Add(Me.FilterName)
        Me.FilterTab.Controls.Add(Me.Label1)
        Me.FilterTab.Controls.Add(Me.FilterCombo)
        Me.FilterTab.Controls.Add(Me.RadioButton3)
        Me.FilterTab.Controls.Add(Me.Label4)
        Me.FilterTab.Controls.Add(Me.IndentedLine2)
        Me.FilterTab.Controls.Add(Me.MatchValues)
        Me.FilterTab.Controls.Add(Me.ContainsRadio)
        Me.FilterTab.Controls.Add(Me.Contains)
        Me.FilterTab.Controls.Add(Me.NumericRadio)
        Me.FilterTab.Controls.Add(Me.GreaterThanCheck)
        Me.FilterTab.Controls.Add(Me.PictureBox2)
        Me.FilterTab.Controls.Add(Me.LessThanSpin)
        Me.FilterTab.Controls.Add(Me.GreaterThanSpin)
        Me.FilterTab.Controls.Add(Me.RemoveButton)
        Me.FilterTab.Controls.Add(Me.UpdateButton)
        Me.FilterTab.Controls.Add(Me.NumericContext)
        Me.FilterTab.Location = New System.Drawing.Point(4, 22)
        Me.FilterTab.Name = "FilterTab"
        Me.FilterTab.Size = New System.Drawing.Size(590, 554)
        Me.FilterTab.TabIndex = 2
        Me.FilterTab.Text = "Filter"
        '
        'EqualsPanel
        '
        Me.EqualsPanel.Controls.Add(Me.EqualsRadio)
        Me.EqualsPanel.Controls.Add(Me.NotEqualsRadio)
        Me.EqualsPanel.Location = New System.Drawing.Point(305, 60)
        Me.EqualsPanel.Name = "EqualsPanel"
        Me.EqualsPanel.Size = New System.Drawing.Size(160, 30)
        Me.EqualsPanel.TabIndex = 315
        '
        'EqualsRadio
        '
        Me.EqualsRadio.Enabled = False
        Me.EqualsRadio.Location = New System.Drawing.Point(5, 5)
        Me.EqualsRadio.Name = "EqualsRadio"
        Me.EqualsRadio.Size = New System.Drawing.Size(65, 21)
        Me.EqualsRadio.TabIndex = 0
        Me.EqualsRadio.Text = "Equals"
        '
        'NotEqualsRadio
        '
        Me.NotEqualsRadio.Enabled = False
        Me.NotEqualsRadio.Location = New System.Drawing.Point(75, 5)
        Me.NotEqualsRadio.Name = "NotEqualsRadio"
        Me.NotEqualsRadio.Size = New System.Drawing.Size(80, 21)
        Me.NotEqualsRadio.TabIndex = 1
        Me.NotEqualsRadio.Text = "Not Equals"
        '
        'NullRadio
        '
        Me.NullRadio.Enabled = False
        Me.NullRadio.Location = New System.Drawing.Point(30, 300)
        Me.NullRadio.Name = "NullRadio"
        Me.NullRadio.Size = New System.Drawing.Size(150, 21)
        Me.NullRadio.TabIndex = 14
        Me.NullRadio.Text = "Blank/Empty"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 15)
        Me.Label5.TabIndex = 312
        Me.Label5.Text = "e.g. Money, Weight, Just a number"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(289, 273)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.TabIndex = 311
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Number Context"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(305, 335)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(125, 24)
        Me.AddButton.TabIndex = 15
        Me.AddButton.Text = "Add To Filter"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 15)
        Me.Label2.TabIndex = 309
        Me.Label2.Text = "Each of the terms in this filter must met for the component to be matched."
        '
        'LessThanCheck
        '
        Me.LessThanCheck.Enabled = False
        Me.LessThanCheck.Location = New System.Drawing.Point(45, 240)
        Me.LessThanCheck.Name = "LessThanCheck"
        Me.LessThanCheck.Size = New System.Drawing.Size(155, 21)
        Me.LessThanCheck.TabIndex = 10
        Me.LessThanCheck.Text = "Less Than or Equal To"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(245, 162)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(335, 15)
        Me.Label23.TabIndex = 309
        Me.Label23.Text = "Use commas to separate multiple items e.g. Clr 1, Wiz 1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(225, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 308
        Me.PictureBox1.TabStop = False
        '
        'MatchValuesButton
        '
        Me.MatchValuesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatchValuesButton.Enabled = False
        Me.MatchValuesButton.Location = New System.Drawing.Point(550, 100)
        Me.MatchValuesButton.Name = "MatchValuesButton"
        Me.MatchValuesButton.Size = New System.Drawing.Size(23, 21)
        Me.MatchValuesButton.TabIndex = 4
        Me.MatchValuesButton.Text = "..."
        '
        'FilterTermsList
        '
        Me.FilterTermsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilterTermsList.ItemHeight = 15
        Me.FilterTermsList.Location = New System.Drawing.Point(15, 425)
        Me.FilterTermsList.Name = "FilterTermsList"
        Me.FilterTermsList.Size = New System.Drawing.Size(550, 115)
        Me.FilterTermsList.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.FilterTermsList.TabIndex = 18
        '
        'MatchValuesRadio
        '
        Me.MatchValuesRadio.Enabled = False
        Me.MatchValuesRadio.Location = New System.Drawing.Point(30, 100)
        Me.MatchValuesRadio.Name = "MatchValuesRadio"
        Me.MatchValuesRadio.Size = New System.Drawing.Size(195, 21)
        Me.MatchValuesRadio.TabIndex = 2
        Me.MatchValuesRadio.Text = "Specific Value or Values"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(560, 5)
        Me.IndentedLine1.TabIndex = 6
        '
        'FilterName
        '
        Me.FilterName.EditValue = ""
        Me.FilterName.Location = New System.Drawing.Point(90, 15)
        Me.FilterName.Name = "FilterName"
        Me.FilterName.Properties.AutoHeight = False
        Me.FilterName.Size = New System.Drawing.Size(250, 21)
        Me.FilterName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filter Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FilterCombo
        '
        Me.FilterCombo.EditValue = ""
        Me.FilterCombo.Location = New System.Drawing.Point(90, 65)
        Me.FilterCombo.Name = "FilterCombo"
        Me.FilterCombo.Properties.AutoHeight = False
        Me.FilterCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FilterCombo.Properties.DropDownRows = 20
        Me.FilterCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FilterCombo.Size = New System.Drawing.Size(200, 21)
        Me.FilterCombo.TabIndex = 1
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(30, 100)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(195, 21)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.Text = "Match Specific Value or Values"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Filter On"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 375)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(560, 5)
        Me.IndentedLine2.TabIndex = 6
        '
        'MatchValues
        '
        Me.MatchValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatchValues.EditValue = ""
        Me.MatchValues.Location = New System.Drawing.Point(225, 100)
        Me.MatchValues.Name = "MatchValues"
        Me.MatchValues.Properties.AutoHeight = False
        Me.MatchValues.Properties.ReadOnly = True
        Me.MatchValues.Size = New System.Drawing.Size(320, 21)
        Me.MatchValues.TabIndex = 3
        Me.MatchValues.TabStop = False
        '
        'ContainsRadio
        '
        Me.ContainsRadio.Enabled = False
        Me.ContainsRadio.Location = New System.Drawing.Point(30, 130)
        Me.ContainsRadio.Name = "ContainsRadio"
        Me.ContainsRadio.Size = New System.Drawing.Size(195, 21)
        Me.ContainsRadio.TabIndex = 5
        Me.ContainsRadio.Text = "Specific Text"
        '
        'Contains
        '
        Me.Contains.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Contains.EditValue = ""
        Me.Contains.Enabled = False
        Me.Contains.Location = New System.Drawing.Point(225, 130)
        Me.Contains.Name = "Contains"
        Me.Contains.Properties.AutoHeight = False
        Me.Contains.Properties.Mask.BeepOnError = True
        Me.Contains.Properties.Mask.ShowPlaceHolders = False
        Me.Contains.Size = New System.Drawing.Size(320, 21)
        Me.Contains.TabIndex = 6
        '
        'NumericRadio
        '
        Me.NumericRadio.Enabled = False
        Me.NumericRadio.Location = New System.Drawing.Point(30, 180)
        Me.NumericRadio.Name = "NumericRadio"
        Me.NumericRadio.Size = New System.Drawing.Size(150, 21)
        Me.NumericRadio.TabIndex = 7
        Me.NumericRadio.Text = "Numeric Range"
        '
        'GreaterThanCheck
        '
        Me.GreaterThanCheck.Enabled = False
        Me.GreaterThanCheck.Location = New System.Drawing.Point(45, 210)
        Me.GreaterThanCheck.Name = "GreaterThanCheck"
        Me.GreaterThanCheck.Size = New System.Drawing.Size(155, 21)
        Me.GreaterThanCheck.TabIndex = 8
        Me.GreaterThanCheck.Text = "Greater Than or Equal To"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 395)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.TabIndex = 308
        Me.PictureBox2.TabStop = False
        '
        'LessThanSpin
        '
        Me.LessThanSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LessThanSpin.Enabled = False
        Me.LessThanSpin.Location = New System.Drawing.Point(205, 240)
        Me.LessThanSpin.Name = "LessThanSpin"
        Me.LessThanSpin.Properties.AutoHeight = False
        Me.LessThanSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LessThanSpin.Properties.Mask.EditMask = "n"
        Me.LessThanSpin.Size = New System.Drawing.Size(75, 21)
        Me.LessThanSpin.TabIndex = 11
        '
        'GreaterThanSpin
        '
        Me.GreaterThanSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GreaterThanSpin.Enabled = False
        Me.GreaterThanSpin.Location = New System.Drawing.Point(205, 210)
        Me.GreaterThanSpin.Name = "GreaterThanSpin"
        Me.GreaterThanSpin.Properties.AutoHeight = False
        Me.GreaterThanSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.GreaterThanSpin.Properties.Mask.EditMask = "n"
        Me.GreaterThanSpin.Size = New System.Drawing.Size(75, 21)
        Me.GreaterThanSpin.TabIndex = 9
        '
        'RemoveButton
        '
        Me.RemoveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.Location = New System.Drawing.Point(440, 390)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(125, 24)
        Me.RemoveButton.TabIndex = 17
        Me.RemoveButton.Text = "Remove Selected"
        '
        'UpdateButton
        '
        Me.UpdateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(440, 335)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(125, 24)
        Me.UpdateButton.TabIndex = 16
        Me.UpdateButton.Text = "Update Selected"
        '
        'NumericContext
        '
        Me.NumericContext.EditValue = ""
        Me.NumericContext.Enabled = False
        Me.NumericContext.Location = New System.Drawing.Point(150, 270)
        Me.NumericContext.Name = "NumericContext"
        Me.NumericContext.Properties.AutoHeight = False
        Me.NumericContext.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NumericContext.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.NumericContext.Size = New System.Drawing.Size(130, 21)
        Me.NumericContext.TabIndex = 13
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'FilterForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(627, 641)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(635, 645)
        Me.Name = "FilterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add or Edit Filter"
        Me.TabControl1.ResumeLayout(False)
        Me.FilterTab.ResumeLayout(False)
        Me.EqualsPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterTermsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatchValues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contains.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LessThanSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreaterThanSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericContext.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private IsLoading As Boolean
    Private _FilterManager As FilterManager
    Private _Mode As FormMode
    Private _CurrentName As String
    Private _CurrentKey As Objects.ObjectKey
    Private _FiltersForm As FiltersForm
    Private CurrentFolderType As String

    Private Terms As New Hashtable
    Private CurrentTerm As Term

    Private SuspendEvents As Boolean

    Private NumericContextIndex As DataListItem()

#End Region

#Region "Properties"

    'filter name
    Public ReadOnly Property Filter() As Filter
        Get
            Dim retFilter As New Filter
            retFilter.Key = _CurrentKey
            retFilter.Name = FilterName.Text
            retFilter.FolderType = CurrentFolderType
            retFilter.Terms = New ArrayList

            For Each Item As DictionaryEntry In Terms
                retFilter.Terms.Add(CType(Item.Value, Term))
            Next
            Return retFilter
        End Get
    End Property

#End Region

    'init
    Private Sub Init(ByVal FolderType As String)
        Try
            CurrentFolderType = FolderType

            'populate list of available search criteria
            FilterCombo.Properties.Items.Add(New DataListItem("Name", "Name"))

            Dim ColumnDefs As ListViewManager.ListViewData = ListViewManager.ListViewColumnDefs.Item(CurrentFolderType)

            If Not ColumnDefs.Columns Is Nothing Then
                For n As Integer = 0 To ColumnDefs.Columns.GetUpperBound(0)
                    FilterCombo.Properties.Items.Add(New DataListItem(ColumnDefs.Elements(n), ColumnDefs.Columns(n).Text))
                Next
            End If

            FilterCombo.Properties.Items.Add(New DataListItem("Sourcebook", "Sourcebook"))
            FilterCombo.Properties.Items.Add(New DataListItem("License", "License"))
            FilterCombo.Properties.Items.Add(New DataListItem("Tags", "Tags"))

            'numeric context
            ReDim NumericContextIndex(2)
            NumericContextIndex(0) = New DataListItem(RPGXplorer.NumericContext.Number, "Number")
            NumericContextIndex(1) = New DataListItem(RPGXplorer.NumericContext.Money, "Money")
            NumericContextIndex(2) = New DataListItem(RPGXplorer.NumericContext.Weight, "Weight")
            NumericContext.Properties.Items.AddRange(NumericContextIndex)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'init add
    Public Sub InitAdd(ByVal FilterManager As FilterManager, ByVal FiltersForm As FiltersForm, ByVal FolderType As String)
        Try
            IsLoading = True
            _FilterManager = FilterManager
            _Mode = FormMode.Add
            _FiltersForm = FiltersForm
            _CurrentKey = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)

            If FolderType = "" Then
                FolderType = FilterManager.CurrentFolder.Type
            End If

            Init(FolderType)
            IsLoading = False
            EnableDisableButtons()
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'init edit
    Public Sub InitEdit(ByVal FilterManager As FilterManager, ByVal FiltersForm As FiltersForm, ByVal Filter As Filter, Optional ByVal FolderType As String = "")
        Try
            IsLoading = True
            _FilterManager = FilterManager
            _Mode = FormMode.Edit
            _FiltersForm = FiltersForm

            _CurrentName = Filter.Name
            _CurrentKey = Filter.Key
            FilterName.Text = Filter.Name

            SuspendEvents = True
            For Each Term As Term In Filter.Terms
                Dim TermName As String = Term.TermName
                Terms.Add(TermName, Term)
                FilterTermsList.Items.Add(TermName)
            Next
            SuspendEvents = False

            If FolderType = "" Then
                FolderType = FilterManager.CurrentFolder.Type
            End If

            Init(FolderType)
            FilterTermsList.SelectedIndex = 0
            IsLoading = False
            EnableDisableButtons()
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Validate() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
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

    'validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = True

            'name
            Dim CurrentFilterNames As ArrayList = _FiltersForm.FilterNames
            If _Mode = FormMode.Edit Then CurrentFilterNames.Remove(_CurrentName)

            If CurrentFilterNames.Contains(FilterName.Text) Then
                Errors.SetError(FilterName, General.ValidationUniqueName)
                Validate = False
            ElseIf FilterName.Text = "" Then
                Errors.SetError(FilterName, General.ValidationRequired)
                Validate = False
            Else
                Errors.SetError(FilterName, "")
            End If

            'terms
            If FilterTermsList.Items.Count = 0 Then
                Errors.SetError(FilterTermsList, General.ValidationAtLeast1Required)
                Validate = False
            Else
                Errors.SetError(FilterTermsList, "")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'load current term into the form
    Private Sub LoadCurrentTerm()
        Try
            For Each Item As Object In FilterCombo.Properties.Items
                If CType(Item, DataListItem).DisplayMember = CurrentTerm.Criteria Then
                    FilterCombo.SelectedItem = Item
                    Exit For
                End If
            Next

            'equals/not equals
            If CurrentTerm.NotEquals Then NotEqualsRadio.Checked = True

            'term type specific
            Select Case CurrentTerm.TermType
                Case TermType.MatchList
                    MatchValuesRadio.Checked = True
                    MatchValues.Text = CommonLogic.CommaSeparatedListNoSpace(CurrentTerm.Values)
                Case TermType.Contains
                    ContainsRadio.Checked = True
                    Contains.Text = CommonLogic.CommaSeparatedListNoSpace(CurrentTerm.Values)
                Case TermType.NumericGreaterThan
                    NumericRadio.Checked = True
                    GreaterThanCheck.Checked = True
                    GreaterThanSpin.EditValue = CurrentTerm.Values(0)
                    LessThanCheck.Checked = False
                    LessThanSpin.EditValue = 0
                    NumericContext.SelectedIndex = Rules.Index.GetObjectIndex(NumericContextIndex, CurrentTerm.NumericContext)
                Case TermType.NumericLessThan
                    NumericRadio.Checked = True
                    LessThanCheck.Checked = True
                    LessThanSpin.EditValue = CurrentTerm.Values(1)
                    GreaterThanCheck.Checked = False
                    GreaterThanSpin.EditValue = 0
                    NumericContext.SelectedIndex = Rules.Index.GetObjectIndex(NumericContextIndex, CurrentTerm.NumericContext)
                Case TermType.NumericRange
                    NumericRadio.Checked = True
                    GreaterThanCheck.Checked = True
                    GreaterThanSpin.EditValue = CurrentTerm.Values(0)
                    LessThanCheck.Checked = True
                    LessThanSpin.EditValue = CurrentTerm.Values(1)
                    NumericContext.SelectedIndex = Rules.Index.GetObjectIndex(NumericContextIndex, CurrentTerm.NumericContext)
                Case TermType.NoValue
                    NullRadio.Checked = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        If IsLoading Then Exit Sub
        Try
            Dim Add, Update, Remove As Boolean

            Add = True
            Update = True
            Remove = True

            'add/update
            If FilterCombo.SelectedIndex <> -1 Then

                'equals/not equals
                If NumericRadio.Checked Then
                    EqualsRadio.Checked = True
                    EqualsPanel.Enabled = False
                Else
                    EqualsPanel.Enabled = True
                End If

                'term type specific
                If MatchValuesRadio.Checked Then
                    If MatchValues.Text = "" Then
                        Add = False
                        Update = False
                    End If
                ElseIf ContainsRadio.Checked Then
                    If Contains.Text = "" Then
                        Add = False
                        Update = False
                    Else
                        Dim Regex As New System.Text.RegularExpressions.Regex("^[ \w]+(,[ \w]+)*$")
                        If Regex.IsMatch(Contains.Text, 0) Then
                            Contains.BackColor = Color.White
                            If Contains.Text.Length = 0 Then
                                Add = False
                                Update = False
                            End If
                        Else
                            Contains.BackColor = Color.Salmon
                            Add = False
                            Update = False
                        End If
                    End If
                ElseIf NumericRadio.Checked Then
                    If LessThanCheck.Checked And GreaterThanCheck.Checked Then
                        If CInt(LessThanSpin.EditValue) <= CInt(GreaterThanSpin.EditValue) Then
                            Add = False
                            Update = False
                            LessThanSpin.BackColor = Color.Salmon
                            GreaterThanSpin.BackColor = Color.Salmon
                        Else
                            LessThanSpin.BackColor = Color.White
                            GreaterThanSpin.BackColor = Color.White
                        End If
                    Else
                        LessThanSpin.BackColor = Color.White
                        GreaterThanSpin.BackColor = Color.White
                    End If
                    If NumericContext.SelectedIndex = -1 Then
                        Add = False
                        Update = False
                        NumericContext.BackColor = Color.Salmon
                    Else
                        NumericContext.BackColor = Color.White
                    End If
                End If
            Else
                Add = False
                Update = False
            End If

            'existing terms
            If FilterTermsList.SelectedIndex = -1 Then
                Update = False
                Remove = False
            End If

            'enable/disable
            If Add Then AddButton.Enabled = True Else AddButton.Enabled = False
            If Update Then UpdateButton.Enabled = True Else UpdateButton.Enabled = False
            If Remove Then RemoveButton.Enabled = True Else RemoveButton.Enabled = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update aspects of current term that are not done so on the fly
    Private Sub UpdateCurrentTerm()
        Try
            CurrentTerm.Criteria = FilterCombo.Text
            CurrentTerm.Element = CType(FilterCombo.SelectedItem, DataListItem).ValueMember.ToString

            'equals/not equals
            CurrentTerm.NotEquals = NotEqualsRadio.Checked

            'determine term type and set numeric values now
            If MatchValuesRadio.Checked Then
                CurrentTerm.TermType = TermType.MatchList
            ElseIf ContainsRadio.Checked Then
                CurrentTerm.TermType = TermType.Contains
                CurrentTerm.Values = New ArrayList(Contains.Text.Split(New Char() {","c}))
            ElseIf NumericRadio.Checked Then
                If GreaterThanCheck.Checked And LessThanCheck.Checked Then
                    CurrentTerm.TermType = TermType.NumericRange
                ElseIf GreaterThanCheck.Checked Then
                    CurrentTerm.TermType = TermType.NumericGreaterThan
                Else
                    CurrentTerm.TermType = TermType.NumericLessThan
                End If

                CurrentTerm.NumericContext = CType(CType(NumericContext.SelectedItem, DataListItem).ValueMember, NumericContext)

                CurrentTerm.Values = New ArrayList
                CurrentTerm.Values.Add(GreaterThanSpin.EditValue)
                CurrentTerm.Values.Add(LessThanSpin.EditValue)
            Else
                CurrentTerm.TermType = TermType.NoValue
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handlers"

    Private Sub FilterCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterCombo.SelectedIndexChanged
        Try
            EqualsRadio.Enabled = True
            EqualsRadio.Checked = True
            NotEqualsRadio.Enabled = True
            MatchValuesRadio.Enabled = True
            MatchValuesRadio.Checked = True
            MatchValues.Text = ""
            ContainsRadio.Enabled = True
            NumericRadio.Enabled = True
            NullRadio.Enabled = True

            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MatchValuesRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatchValuesRadio.CheckedChanged
        Try
            If MatchValuesRadio.Checked Then
                MatchValues.Properties.Enabled = True
                MatchValuesButton.Enabled = True
            Else
                MatchValues.Properties.Enabled = False
                MatchValues.Text = ""
                MatchValuesButton.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ContainsRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainsRadio.CheckedChanged
        Try
            If ContainsRadio.Checked Then
                CurrentTerm.TermType = TermType.Contains
                Contains.Properties.Enabled = True
            Else
                Contains.Properties.Enabled = False
                Contains.Text = ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub NumericRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericRadio.CheckedChanged
        Try
            If NumericRadio.Checked Then
                LessThanCheck.Enabled = True
                GreaterThanCheck.Enabled = True
                GreaterThanCheck.Checked = True
                NumericContext.Properties.Enabled = True
            Else
                LessThanCheck.Enabled = False
                LessThanCheck.Checked = False
                GreaterThanCheck.Enabled = False
                GreaterThanCheck.Checked = False
                NumericContext.Properties.Enabled = False
                NumericContext.SelectedIndex = -1
                LessThanSpin.BackColor = Color.White
                GreaterThanSpin.BackColor = Color.White
                NumericContext.BackColor = Color.White
            End If
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub LessThanCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LessThanCheck.CheckedChanged
        Try
            If LessThanCheck.Checked Then
                LessThanSpin.Properties.Enabled = True
            Else
                If GreaterThanCheck.Checked = False And NumericRadio.Checked Then
                    LessThanCheck.Checked = True
                    Exit Sub
                End If

                LessThanSpin.Properties.Enabled = False
                LessThanSpin.EditValue = 0
            End If
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub GreaterThanCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreaterThanCheck.CheckedChanged
        Try
            If GreaterThanCheck.Checked Then
                GreaterThanSpin.Properties.Enabled = True
            Else
                If LessThanCheck.Checked = False And NumericRadio.Checked Then
                    GreaterThanCheck.Checked = True
                    Exit Sub
                End If

                GreaterThanSpin.Properties.Enabled = False
                GreaterThanSpin.EditValue = 0
            End If
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub NullRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NullRadio.CheckedChanged
        EnableDisableButtons()
    End Sub

    Private Sub MatchValuesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatchValuesButton.Click
        Try
            Dim Form As New ConstructListDialog
            Dim Folder As Objects.ObjectData

            'get value lists
            Dim Available As New ArrayList
            Dim Matches As New ArrayList
            Dim Element As String = CType(FilterCombo.SelectedItem, DataListItem).ValueMember.ToString
            Dim Item As String

            'get complete list of data values
            If _FilterManager.CurrentFolder.IsEmpty OrElse Me.CurrentFolderType <> _FilterManager.CurrentFolder.Type Then
                Folder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & CurrentFolderType & "']")
            Else
                Folder = _FilterManager.CurrentFolder
            End If

            For Each Obj As Objects.ObjectData In Folder.ChildrenVisibleInListView
                Item = Obj.Element(Element)
                If Not Item = "" Then
                    If Not Available.Contains(Item) Then Available.Add(Item)
                End If
            Next

            'set existing matches for an edit
            If MatchValues.Text <> "" Then
                Matches = CurrentTerm.Values
            End If

            'init and show form
            Form.Init("Filter Matches for " & FilterCombo.Text, FilterCombo.Text, "Please select the values you wish to match.", "Available Values", "Matching Values")
            Form.InitTextList(Available, Matches)

            If Form.ShowDialog() = DialogResult.OK Then
                Matches = Form.ListBFinal
                Dim MatchString As String = CommonLogic.CommaSeparatedListNoSpace(Matches)
                MatchValues.Text = MatchString
                CurrentTerm.Values = Matches
            End If

            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Contains_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Contains.TextChanged
        Try
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub GreaterThanSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreaterThanSpin.EditValueChanged
        Try
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub LessThanSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LessThanSpin.EditValueChanged
        Try
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub NumericContext_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericContext.SelectedIndexChanged
        Try
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Try
            UpdateCurrentTerm()

            'add to list if not already there
            Dim TermName As String = CurrentTerm.TermName

            If Terms.Contains(TermName) Then
                General.ShowInfoDialog("This filter term is already in the list.")
            Else
                Terms.Add(TermName, CurrentTerm)
                SuspendEvents = True
                FilterTermsList.Items.Add(TermName)
                FilterTermsList.SelectedItem = TermName
                SuspendEvents = False
            End If

            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Try
            UpdateCurrentTerm()

            'remove existing term and replace with new one
            Dim SelectedTerm As String = FilterTermsList.SelectedValue.ToString
            Dim TermName As String = CurrentTerm.TermName

            SuspendEvents = True
            Terms.Remove(SelectedTerm)
            Terms.Add(TermName, CurrentTerm)
            FilterTermsList.Items.Remove(FilterTermsList.SelectedItem)
            FilterTermsList.Items.Add(TermName)
            FilterTermsList.SelectedItem = TermName
            SuspendEvents = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Try
            If General.ShowQuestionDialog("Are you sure you want to delete the selected term?") = DialogResult.Yes Then
                SuspendEvents = True
                Terms.Remove(FilterTermsList.SelectedItem.ToString)
                Dim SelectedIndex As Integer = FilterTermsList.SelectedIndex
                FilterTermsList.Items.Remove(FilterTermsList.SelectedItem)
                SuspendEvents = False
                SelectedIndex -= 1

                If SelectedIndex > 0 And SelectedIndex < FilterTermsList.Items.Count Then FilterTermsList.SelectedIndex = SelectedIndex
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FilterTermsList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterTermsList.SelectedIndexChanged
        Try
            If SuspendEvents Then Exit Sub

            'update the current term
            If Not FilterTermsList.SelectedIndex = -1 And Not FilterTermsList.Items.Count = 0 Then
                CurrentTerm.Clear()
                CurrentTerm = CType(Terms.Item(FilterTermsList.SelectedItem.ToString), Term)

                'enable controls
                EqualsRadio.Enabled = True
                NotEqualsRadio.Enabled = True
                MatchValuesRadio.Enabled = True
                ContainsRadio.Enabled = True
                NumericRadio.Enabled = True
                NullRadio.Enabled = True

                LoadCurrentTerm()
            End If

            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

