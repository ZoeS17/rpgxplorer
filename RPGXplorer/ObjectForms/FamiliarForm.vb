Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class FamiliarForm
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
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Gender As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Race As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents CHAMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents WISMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents INTMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents CONMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DEXMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents STRMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents CHARaceMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents WISRaceMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents INTRaceMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents CONRaceMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DEXRaceMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents STRRaceMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents CharacterTab As System.Windows.Forms.TabPage
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents INT As DevExpress.XtraEditors.SpinEdit
    Public WithEvents CHA As DevExpress.XtraEditors.SpinEdit
    Public WithEvents WIS As DevExpress.XtraEditors.SpinEdit
    Public WithEvents STR As DevExpress.XtraEditors.SpinEdit
    Public WithEvents CON As DevExpress.XtraEditors.SpinEdit
    Public WithEvents DEX As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents CHAFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents WISFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents INTFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents CONFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DEXFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents STRFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents PlayerName As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents CompanionTypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Alignment As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label28 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.CharacterTab = New System.Windows.Forms.TabPage
        Me.Label29 = New System.Windows.Forms.Label
        Me.Alignment = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CompanionTypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.CHAFinal = New RPGXplorer.ReadOnlyTextBox
        Me.WISFinal = New RPGXplorer.ReadOnlyTextBox
        Me.INTFinal = New RPGXplorer.ReadOnlyTextBox
        Me.CONFinal = New RPGXplorer.ReadOnlyTextBox
        Me.DEXFinal = New RPGXplorer.ReadOnlyTextBox
        Me.STRFinal = New RPGXplorer.ReadOnlyTextBox
        Me.INT = New DevExpress.XtraEditors.SpinEdit
        Me.CHA = New DevExpress.XtraEditors.SpinEdit
        Me.WIS = New DevExpress.XtraEditors.SpinEdit
        Me.STR = New DevExpress.XtraEditors.SpinEdit
        Me.CON = New DevExpress.XtraEditors.SpinEdit
        Me.DEX = New DevExpress.XtraEditors.SpinEdit
        Me.PlayerName = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CHARaceMod = New RPGXplorer.ReadOnlyTextBox
        Me.WISRaceMod = New RPGXplorer.ReadOnlyTextBox
        Me.INTRaceMod = New RPGXplorer.ReadOnlyTextBox
        Me.CONRaceMod = New RPGXplorer.ReadOnlyTextBox
        Me.DEXRaceMod = New RPGXplorer.ReadOnlyTextBox
        Me.STRRaceMod = New RPGXplorer.ReadOnlyTextBox
        Me.CHAMod = New RPGXplorer.ReadOnlyTextBox
        Me.WISMod = New RPGXplorer.ReadOnlyTextBox
        Me.INTMod = New RPGXplorer.ReadOnlyTextBox
        Me.CONMod = New RPGXplorer.ReadOnlyTextBox
        Me.DEXMod = New RPGXplorer.ReadOnlyTextBox
        Me.STRMod = New RPGXplorer.ReadOnlyTextBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Gender = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Race = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.CharacterTab.SuspendLayout()
        CType(Me.Alignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanionTypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Race.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.CharacterTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 522)
        Me.TabControl1.TabIndex = 0
        '
        'CharacterTab
        '
        Me.CharacterTab.Controls.Add(Me.Label29)
        Me.CharacterTab.Controls.Add(Me.Alignment)
        Me.CharacterTab.Controls.Add(Me.CompanionTypeDropdown)
        Me.CharacterTab.Controls.Add(Me.Label28)
        Me.CharacterTab.Controls.Add(Me.Description)
        Me.CharacterTab.Controls.Add(Me.Label27)
        Me.CharacterTab.Controls.Add(Me.IndentedLine2)
        Me.CharacterTab.Controls.Add(Me.Label26)
        Me.CharacterTab.Controls.Add(Me.Label24)
        Me.CharacterTab.Controls.Add(Me.Label25)
        Me.CharacterTab.Controls.Add(Me.Label22)
        Me.CharacterTab.Controls.Add(Me.Label23)
        Me.CharacterTab.Controls.Add(Me.Label20)
        Me.CharacterTab.Controls.Add(Me.Label19)
        Me.CharacterTab.Controls.Add(Me.Label16)
        Me.CharacterTab.Controls.Add(Me.Label17)
        Me.CharacterTab.Controls.Add(Me.Label8)
        Me.CharacterTab.Controls.Add(Me.Label14)
        Me.CharacterTab.Controls.Add(Me.Label6)
        Me.CharacterTab.Controls.Add(Me.Label4)
        Me.CharacterTab.Controls.Add(Me.Label18)
        Me.CharacterTab.Controls.Add(Me.CHAFinal)
        Me.CharacterTab.Controls.Add(Me.WISFinal)
        Me.CharacterTab.Controls.Add(Me.INTFinal)
        Me.CharacterTab.Controls.Add(Me.CONFinal)
        Me.CharacterTab.Controls.Add(Me.DEXFinal)
        Me.CharacterTab.Controls.Add(Me.STRFinal)
        Me.CharacterTab.Controls.Add(Me.INT)
        Me.CharacterTab.Controls.Add(Me.CHA)
        Me.CharacterTab.Controls.Add(Me.WIS)
        Me.CharacterTab.Controls.Add(Me.STR)
        Me.CharacterTab.Controls.Add(Me.CON)
        Me.CharacterTab.Controls.Add(Me.DEX)
        Me.CharacterTab.Controls.Add(Me.PlayerName)
        Me.CharacterTab.Controls.Add(Me.Label21)
        Me.CharacterTab.Controls.Add(Me.Label15)
        Me.CharacterTab.Controls.Add(Me.Label11)
        Me.CharacterTab.Controls.Add(Me.CHARaceMod)
        Me.CharacterTab.Controls.Add(Me.WISRaceMod)
        Me.CharacterTab.Controls.Add(Me.INTRaceMod)
        Me.CharacterTab.Controls.Add(Me.CONRaceMod)
        Me.CharacterTab.Controls.Add(Me.DEXRaceMod)
        Me.CharacterTab.Controls.Add(Me.STRRaceMod)
        Me.CharacterTab.Controls.Add(Me.CHAMod)
        Me.CharacterTab.Controls.Add(Me.WISMod)
        Me.CharacterTab.Controls.Add(Me.INTMod)
        Me.CharacterTab.Controls.Add(Me.CONMod)
        Me.CharacterTab.Controls.Add(Me.DEXMod)
        Me.CharacterTab.Controls.Add(Me.STRMod)
        Me.CharacterTab.Controls.Add(Me.IndentedLine1)
        Me.CharacterTab.Controls.Add(Me.Label1)
        Me.CharacterTab.Controls.Add(Me.Label7)
        Me.CharacterTab.Controls.Add(Me.Label9)
        Me.CharacterTab.Controls.Add(Me.Label10)
        Me.CharacterTab.Controls.Add(Me.Label12)
        Me.CharacterTab.Controls.Add(Me.Label13)
        Me.CharacterTab.Controls.Add(Me.Gender)
        Me.CharacterTab.Controls.Add(Me.Label5)
        Me.CharacterTab.Controls.Add(Me.Label3)
        Me.CharacterTab.Controls.Add(Me.Race)
        Me.CharacterTab.Controls.Add(Me.ObjectName)
        Me.CharacterTab.Controls.Add(Me.Label2)
        Me.CharacterTab.Location = New System.Drawing.Point(4, 22)
        Me.CharacterTab.Name = "CharacterTab"
        Me.CharacterTab.Size = New System.Drawing.Size(407, 496)
        Me.CharacterTab.TabIndex = 0
        Me.CharacterTab.Text = "Character"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Location = New System.Drawing.Point(15, 165)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 21)
        Me.Label29.TabIndex = 336
        Me.Label29.Text = "Alignment"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alignment
        '
        Me.Alignment.Location = New System.Drawing.Point(110, 165)
        Me.Alignment.Name = "Alignment"
        Me.Alignment.Properties.AutoHeight = False
        Me.Alignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Alignment.Properties.DropDownRows = 10
        Me.Alignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Alignment.Size = New System.Drawing.Size(150, 21)
        Me.Alignment.TabIndex = 5
        '
        'CompanionTypeDropdown
        '
        Me.CompanionTypeDropdown.Location = New System.Drawing.Point(110, 45)
        Me.CompanionTypeDropdown.Name = "CompanionTypeDropdown"
        Me.CompanionTypeDropdown.Properties.AutoHeight = False
        Me.CompanionTypeDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanionTypeDropdown.Properties.DropDownRows = 10
        Me.CompanionTypeDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CompanionTypeDropdown.Size = New System.Drawing.Size(150, 21)
        Me.CompanionTypeDropdown.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.CausesValidation = False
        Me.Label28.Location = New System.Drawing.Point(15, 45)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 21)
        Me.Label28.TabIndex = 334
        Me.Label28.Text = "Companion Type"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.Location = New System.Drawing.Point(85, 435)
        Me.Description.Name = "Description"
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(305, 46)
        Me.Description.TabIndex = 12
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.CausesValidation = False
        Me.Label27.Location = New System.Drawing.Point(15, 435)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 21)
        Me.Label27.TabIndex = 333
        Me.Label27.Text = "Description"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(10, 420)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 331
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Location = New System.Drawing.Point(115, 215)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 15)
        Me.Label26.TabIndex = 330
        Me.Label26.Text = "Modifier"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(170, 385)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 21)
        Me.Label24.TabIndex = 329
        Me.Label24.Text = "="
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Location = New System.Drawing.Point(170, 355)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 21)
        Me.Label25.TabIndex = 328
        Me.Label25.Text = "="
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(170, 325)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 21)
        Me.Label22.TabIndex = 327
        Me.Label22.Text = "="
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(170, 295)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 21)
        Me.Label23.TabIndex = 326
        Me.Label23.Text = "="
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(170, 265)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(10, 21)
        Me.Label20.TabIndex = 325
        Me.Label20.Text = "="
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(170, 235)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 21)
        Me.Label19.TabIndex = 324
        Me.Label19.Text = "="
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(95, 355)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 21)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "+"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(95, 385)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 21)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "+"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(95, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "+"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(95, 325)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 21)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "+"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(95, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "+"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(95, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "+"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(190, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 317
        Me.Label18.Text = "Final"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CHAFinal
        '
        Me.CHAFinal.BackColor = System.Drawing.Color.White
        Me.CHAFinal.Caption = Nothing
        Me.CHAFinal.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHAFinal.ForeColor = System.Drawing.Color.Black
        Me.CHAFinal.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CHAFinal.Location = New System.Drawing.Point(190, 385)
        Me.CHAFinal.Name = "CHAFinal"
        Me.CHAFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.CHAFinal.Size = New System.Drawing.Size(35, 21)
        Me.CHAFinal.TabIndex = 316
        Me.CHAFinal.TabStop = False
        Me.CHAFinal.TextColor = System.Drawing.Color.Black
        Me.CHAFinal.Vertical = False
        '
        'WISFinal
        '
        Me.WISFinal.BackColor = System.Drawing.Color.White
        Me.WISFinal.Caption = Nothing
        Me.WISFinal.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.WISFinal.ForeColor = System.Drawing.Color.Black
        Me.WISFinal.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.WISFinal.Location = New System.Drawing.Point(190, 355)
        Me.WISFinal.Name = "WISFinal"
        Me.WISFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.WISFinal.Size = New System.Drawing.Size(35, 21)
        Me.WISFinal.TabIndex = 315
        Me.WISFinal.TabStop = False
        Me.WISFinal.TextColor = System.Drawing.Color.Black
        Me.WISFinal.Vertical = False
        '
        'INTFinal
        '
        Me.INTFinal.BackColor = System.Drawing.Color.White
        Me.INTFinal.Caption = Nothing
        Me.INTFinal.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.INTFinal.ForeColor = System.Drawing.Color.Black
        Me.INTFinal.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.INTFinal.Location = New System.Drawing.Point(190, 325)
        Me.INTFinal.Name = "INTFinal"
        Me.INTFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.INTFinal.Size = New System.Drawing.Size(35, 21)
        Me.INTFinal.TabIndex = 314
        Me.INTFinal.TabStop = False
        Me.INTFinal.TextColor = System.Drawing.Color.Black
        Me.INTFinal.Vertical = False
        '
        'CONFinal
        '
        Me.CONFinal.BackColor = System.Drawing.Color.White
        Me.CONFinal.Caption = Nothing
        Me.CONFinal.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CONFinal.ForeColor = System.Drawing.Color.Black
        Me.CONFinal.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CONFinal.Location = New System.Drawing.Point(190, 295)
        Me.CONFinal.Name = "CONFinal"
        Me.CONFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.CONFinal.Size = New System.Drawing.Size(35, 21)
        Me.CONFinal.TabIndex = 313
        Me.CONFinal.TabStop = False
        Me.CONFinal.TextColor = System.Drawing.Color.Black
        Me.CONFinal.Vertical = False
		'
        'DEXFinal
        '
        Me.DEXFinal.BackColor = System.Drawing.Color.White
        Me.DEXFinal.Caption = Nothing
        Me.DEXFinal.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.DEXFinal.ForeColor = System.Drawing.Color.Black
        Me.DEXFinal.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DEXFinal.Location = New System.Drawing.Point(190, 265)
        Me.DEXFinal.Name = "DEXFinal"
        Me.DEXFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.DEXFinal.Size = New System.Drawing.Size(35, 21)
        Me.DEXFinal.TabIndex = 312
        Me.DEXFinal.TabStop = False
        Me.DEXFinal.TextColor = System.Drawing.Color.Black
        Me.DEXFinal.Vertical = False
        '
        'STRFinal
        '
        Me.STRFinal.BackColor = System.Drawing.Color.White
        Me.STRFinal.Caption = Nothing
        Me.STRFinal.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.STRFinal.ForeColor = System.Drawing.Color.Black
        Me.STRFinal.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.STRFinal.Location = New System.Drawing.Point(190, 235)
        Me.STRFinal.Name = "STRFinal"
        Me.STRFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.STRFinal.Size = New System.Drawing.Size(35, 21)
        Me.STRFinal.TabIndex = 311
        Me.STRFinal.TabStop = False
        Me.STRFinal.TextColor = System.Drawing.Color.Black
        Me.STRFinal.Vertical = False
        '
        'INT
        '
        Me.INT.AllowDrop = True
        Me.INT.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.INT.Location = New System.Drawing.Point(110, 325)
        Me.INT.Name = "INT"
        Me.INT.Properties.Appearance.Options.UseTextOptions = True
        Me.INT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.INT.Properties.AutoHeight = False
        Me.INT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.INT.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.INT.Properties.IsFloatValue = False
        Me.INT.Properties.Mask.EditMask = "d"
        Me.INT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.INT.Properties.Mask.SaveLiteral = False
        Me.INT.Properties.Mask.ShowPlaceHolders = False
        Me.INT.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.INT.Size = New System.Drawing.Size(50, 21)
        Me.INT.TabIndex = 8
        '
        'CHA
        '
        Me.CHA.AllowDrop = True
        Me.CHA.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CHA.Location = New System.Drawing.Point(110, 385)
        Me.CHA.Name = "CHA"
        Me.CHA.Properties.Appearance.Options.UseTextOptions = True
        Me.CHA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CHA.Properties.AutoHeight = False
        Me.CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CHA.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.CHA.Properties.IsFloatValue = False
        Me.CHA.Properties.Mask.EditMask = "d"
        Me.CHA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CHA.Properties.Mask.SaveLiteral = False
        Me.CHA.Properties.Mask.ShowPlaceHolders = False
        Me.CHA.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.CHA.Size = New System.Drawing.Size(50, 21)
        Me.CHA.TabIndex = 10
        '
        'WIS
        '
        Me.WIS.AllowDrop = True
        Me.WIS.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WIS.Location = New System.Drawing.Point(110, 355)
        Me.WIS.Name = "WIS"
        Me.WIS.Properties.Appearance.Options.UseTextOptions = True
        Me.WIS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WIS.Properties.AutoHeight = False
        Me.WIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.WIS.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.WIS.Properties.IsFloatValue = False
        Me.WIS.Properties.Mask.EditMask = "d"
        Me.WIS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.WIS.Properties.Mask.SaveLiteral = False
        Me.WIS.Properties.Mask.ShowPlaceHolders = False
        Me.WIS.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.WIS.Size = New System.Drawing.Size(50, 21)
        Me.WIS.TabIndex = 9
        '
        'STR
        '
        Me.STR.AllowDrop = True
        Me.STR.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.STR.Location = New System.Drawing.Point(110, 235)
        Me.STR.Name = "STR"
        Me.STR.Properties.Appearance.Options.UseTextOptions = True
        Me.STR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.STR.Properties.AutoHeight = False
        Me.STR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.STR.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.STR.Properties.IsFloatValue = False
        Me.STR.Properties.Mask.EditMask = "d"
        Me.STR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.STR.Properties.Mask.SaveLiteral = False
        Me.STR.Properties.Mask.ShowPlaceHolders = False
        Me.STR.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.STR.Size = New System.Drawing.Size(50, 21)
        Me.STR.TabIndex = 5
        '
        'CON
        '
        Me.CON.AllowDrop = True
        Me.CON.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CON.Location = New System.Drawing.Point(110, 295)
        Me.CON.Name = "CON"
        Me.CON.Properties.Appearance.Options.UseTextOptions = True
        Me.CON.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CON.Properties.AutoHeight = False
        Me.CON.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CON.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.CON.Properties.IsFloatValue = False
        Me.CON.Properties.Mask.EditMask = "d"
        Me.CON.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CON.Properties.Mask.SaveLiteral = False
        Me.CON.Properties.Mask.ShowPlaceHolders = False
        Me.CON.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.CON.Size = New System.Drawing.Size(50, 21)
        Me.CON.TabIndex = 7
        '
        'DEX
        '
        Me.DEX.AllowDrop = True
        Me.DEX.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DEX.Location = New System.Drawing.Point(110, 265)
        Me.DEX.Name = "DEX"
        Me.DEX.Properties.Appearance.Options.UseTextOptions = True
        Me.DEX.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DEX.Properties.AutoHeight = False
        Me.DEX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DEX.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DEX.Properties.IsFloatValue = False
        Me.DEX.Properties.Mask.EditMask = "d"
        Me.DEX.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DEX.Properties.Mask.SaveLiteral = False
        Me.DEX.Properties.Mask.ShowPlaceHolders = False
        Me.DEX.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.DEX.Size = New System.Drawing.Size(50, 21)
        Me.DEX.TabIndex = 6
        '
        'PlayerName
        '
        Me.PlayerName.Location = New System.Drawing.Point(110, 75)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Properties.AutoHeight = False
        Me.PlayerName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlayerName.Properties.DropDownRows = 10
        Me.PlayerName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PlayerName.Size = New System.Drawing.Size(150, 21)
        Me.PlayerName.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.CausesValidation = False
        Me.Label21.Location = New System.Drawing.Point(15, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 21)
        Me.Label21.TabIndex = 303
        Me.Label21.Text = "Owner"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(225, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 278
        Me.Label15.Text = "Mod"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(55, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "Race"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CHARaceMod
        '
        Me.CHARaceMod.BackColor = System.Drawing.Color.White
        Me.CHARaceMod.Caption = Nothing
        Me.CHARaceMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHARaceMod.ForeColor = System.Drawing.Color.Black
        Me.CHARaceMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CHARaceMod.Location = New System.Drawing.Point(55, 385)
        Me.CHARaceMod.Name = "CHARaceMod"
        Me.CHARaceMod.Padding = New System.Windows.Forms.Padding(1)
        Me.CHARaceMod.Size = New System.Drawing.Size(35, 21)
        Me.CHARaceMod.TabIndex = 276
        Me.CHARaceMod.TabStop = False
        Me.CHARaceMod.TextColor = System.Drawing.Color.Black
        Me.CHARaceMod.Vertical = False
        '
        'WISRaceMod
        '
        Me.WISRaceMod.BackColor = System.Drawing.Color.White
        Me.WISRaceMod.Caption = Nothing
        Me.WISRaceMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.WISRaceMod.ForeColor = System.Drawing.Color.Black
        Me.WISRaceMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.WISRaceMod.Location = New System.Drawing.Point(55, 355)
        Me.WISRaceMod.Name = "WISRaceMod"
        Me.WISRaceMod.Padding = New System.Windows.Forms.Padding(1)
        Me.WISRaceMod.Size = New System.Drawing.Size(35, 21)
        Me.WISRaceMod.TabIndex = 275
        Me.WISRaceMod.TabStop = False
        Me.WISRaceMod.TextColor = System.Drawing.Color.Black
        Me.WISRaceMod.Vertical = False
        '
        'INTRaceMod
        '
        Me.INTRaceMod.BackColor = System.Drawing.Color.White
        Me.INTRaceMod.Caption = Nothing
        Me.INTRaceMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.INTRaceMod.ForeColor = System.Drawing.Color.Black
        Me.INTRaceMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.INTRaceMod.Location = New System.Drawing.Point(55, 325)
        Me.INTRaceMod.Name = "INTRaceMod"
        Me.INTRaceMod.Padding = New System.Windows.Forms.Padding(1)
        Me.INTRaceMod.Size = New System.Drawing.Size(35, 21)
        Me.INTRaceMod.TabIndex = 274
        Me.INTRaceMod.TabStop = False
        Me.INTRaceMod.TextColor = System.Drawing.Color.Black
        Me.INTRaceMod.Vertical = False
        '
        'CONRaceMod
        '
        Me.CONRaceMod.BackColor = System.Drawing.Color.White
        Me.CONRaceMod.Caption = Nothing
        Me.CONRaceMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CONRaceMod.ForeColor = System.Drawing.Color.Black
        Me.CONRaceMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CONRaceMod.Location = New System.Drawing.Point(55, 295)
        Me.CONRaceMod.Name = "CONRaceMod"
        Me.CONRaceMod.Padding = New System.Windows.Forms.Padding(1)
        Me.CONRaceMod.Size = New System.Drawing.Size(35, 21)
        Me.CONRaceMod.TabIndex = 273
        Me.CONRaceMod.TabStop = False
        Me.CONRaceMod.TextColor = System.Drawing.Color.Black
        Me.CONRaceMod.Vertical = False
        '
        'DEXRaceMod
        '
        Me.DEXRaceMod.BackColor = System.Drawing.Color.White
        Me.DEXRaceMod.Caption = Nothing
        Me.DEXRaceMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.DEXRaceMod.ForeColor = System.Drawing.Color.Black
        Me.DEXRaceMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DEXRaceMod.Location = New System.Drawing.Point(55, 265)
        Me.DEXRaceMod.Name = "DEXRaceMod"
        Me.DEXRaceMod.Padding = New System.Windows.Forms.Padding(1)
        Me.DEXRaceMod.Size = New System.Drawing.Size(35, 21)
        Me.DEXRaceMod.TabIndex = 272
        Me.DEXRaceMod.TabStop = False
        Me.DEXRaceMod.TextColor = System.Drawing.Color.Black
        Me.DEXRaceMod.Vertical = False
        '
        'STRRaceMod
        '
        Me.STRRaceMod.BackColor = System.Drawing.Color.White
        Me.STRRaceMod.Caption = Nothing
        Me.STRRaceMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.STRRaceMod.ForeColor = System.Drawing.Color.Black
        Me.STRRaceMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.STRRaceMod.Location = New System.Drawing.Point(55, 235)
        Me.STRRaceMod.Name = "STRRaceMod"
        Me.STRRaceMod.Padding = New System.Windows.Forms.Padding(1)
        Me.STRRaceMod.Size = New System.Drawing.Size(35, 21)
        Me.STRRaceMod.TabIndex = 271
        Me.STRRaceMod.TabStop = False
        Me.STRRaceMod.TextColor = System.Drawing.Color.Black
        Me.STRRaceMod.Vertical = False
        '
        'CHAMod
        '
        Me.CHAMod.BackColor = System.Drawing.Color.White
        Me.CHAMod.Caption = Nothing
        Me.CHAMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHAMod.ForeColor = System.Drawing.Color.Black
        Me.CHAMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CHAMod.Location = New System.Drawing.Point(230, 385)
        Me.CHAMod.Name = "CHAMod"
        Me.CHAMod.Padding = New System.Windows.Forms.Padding(1)
        Me.CHAMod.Size = New System.Drawing.Size(35, 21)
        Me.CHAMod.TabIndex = 270
        Me.CHAMod.TabStop = False
        Me.CHAMod.TextColor = System.Drawing.Color.Black
        Me.CHAMod.Vertical = False
        '
        'WISMod
        '
        Me.WISMod.BackColor = System.Drawing.Color.White
        Me.WISMod.Caption = Nothing
        Me.WISMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.WISMod.ForeColor = System.Drawing.Color.Black
        Me.WISMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.WISMod.Location = New System.Drawing.Point(230, 355)
        Me.WISMod.Name = "WISMod"
        Me.WISMod.Padding = New System.Windows.Forms.Padding(1)
        Me.WISMod.Size = New System.Drawing.Size(35, 21)
        Me.WISMod.TabIndex = 269
        Me.WISMod.TabStop = False
        Me.WISMod.TextColor = System.Drawing.Color.Black
        Me.WISMod.Vertical = False
        '
        'INTMod
        '
        Me.INTMod.BackColor = System.Drawing.Color.White
        Me.INTMod.Caption = Nothing
        Me.INTMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.INTMod.ForeColor = System.Drawing.Color.Black
        Me.INTMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.INTMod.Location = New System.Drawing.Point(230, 325)
        Me.INTMod.Name = "INTMod"
        Me.INTMod.Padding = New System.Windows.Forms.Padding(1)
        Me.INTMod.Size = New System.Drawing.Size(35, 21)
        Me.INTMod.TabIndex = 268
        Me.INTMod.TabStop = False
        Me.INTMod.TextColor = System.Drawing.Color.Black
        Me.INTMod.Vertical = False
        '
        'CONMod
        '
        Me.CONMod.BackColor = System.Drawing.Color.White
        Me.CONMod.Caption = Nothing
        Me.CONMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CONMod.ForeColor = System.Drawing.Color.Black
        Me.CONMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CONMod.Location = New System.Drawing.Point(230, 295)
        Me.CONMod.Name = "CONMod"
        Me.CONMod.Padding = New System.Windows.Forms.Padding(1)
        Me.CONMod.Size = New System.Drawing.Size(35, 21)
        Me.CONMod.TabIndex = 267
        Me.CONMod.TabStop = False
        Me.CONMod.TextColor = System.Drawing.Color.Black
        Me.CONMod.Vertical = False
        '
        'DEXMod
        '
        Me.DEXMod.BackColor = System.Drawing.Color.White
        Me.DEXMod.Caption = Nothing
        Me.DEXMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.DEXMod.ForeColor = System.Drawing.Color.Black
        Me.DEXMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DEXMod.Location = New System.Drawing.Point(230, 265)
        Me.DEXMod.Name = "DEXMod"
        Me.DEXMod.Padding = New System.Windows.Forms.Padding(1)
        Me.DEXMod.Size = New System.Drawing.Size(35, 21)
        Me.DEXMod.TabIndex = 266
        Me.DEXMod.TabStop = False
        Me.DEXMod.TextColor = System.Drawing.Color.Black
        Me.DEXMod.Vertical = False
        '
        'STRMod
        '
        Me.STRMod.BackColor = System.Drawing.Color.White
        Me.STRMod.Caption = Nothing
        Me.STRMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.STRMod.ForeColor = System.Drawing.Color.Black
        Me.STRMod.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.STRMod.Location = New System.Drawing.Point(230, 235)
        Me.STRMod.Name = "STRMod"
        Me.STRMod.Padding = New System.Windows.Forms.Padding(1)
        Me.STRMod.Size = New System.Drawing.Size(35, 21)
        Me.STRMod.TabIndex = 265
        Me.STRMod.TabStop = False
        Me.STRMod.TextColor = System.Drawing.Color.Black
        Me.STRMod.Vertical = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(10, 200)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 186
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 21)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "INT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 21)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "WIS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(15, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 21)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "CHA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 21)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "STR"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(15, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 21)
        Me.Label12.TabIndex = 175
        Me.Label12.Text = "DEX"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(15, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 21)
        Me.Label13.TabIndex = 174
        Me.Label13.Text = "CON"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(110, 135)
        Me.Gender.Name = "Gender"
        Me.Gender.Properties.AutoHeight = False
        Me.Gender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Gender.Properties.DropDownRows = 10
        Me.Gender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Gender.Size = New System.Drawing.Size(150, 21)
        Me.Gender.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Gender"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Race"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Race
        '
        Me.Race.Location = New System.Drawing.Point(110, 105)
        Me.Race.Name = "Race"
        Me.Race.Properties.AutoHeight = False
        Me.Race.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Race.Properties.DropDownRows = 10
        Me.Race.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Race.Size = New System.Drawing.Size(150, 21)
        Me.Race.TabIndex = 3
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(110, 15)
        Me.ObjectName.Name = "ObjectName"
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
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 496)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Properties"
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
        Me.Cancel.Location = New System.Drawing.Point(360, 552)
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
        Me.OK.Location = New System.Drawing.Point(280, 552)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'FamiliarForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 590)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FamiliarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FamiliarForm"
        Me.TabControl1.ResumeLayout(False)
        Me.CharacterTab.ResumeLayout(False)
        CType(Me.Alignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanionTypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Race.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private EditingExisting As Boolean

    'indexes
    Private PlayerIndex As Index.IndexEntry()
    Private RaceIndex As General.DataListItem()
    Private DeityIndex As Index.IndexEntry()

    'private
    Private RollAssignment(6) As Integer
    Private RollBeingDragged As Integer
    Private Character As Character
    Private MonsterRaces As Objects.ObjectDataCollection

    Private HoldPointCalculate As Boolean = False

    'init
    Public Sub Init()
        Try
            'indexes            
            Select Case mObject.ObjectGUID.Database
                Case XML.DBTypes.Monsters
                    PlayerIndex = Index.Index(XML.DBTypes.Monsters, Objects.MonsterType)
                Case XML.DBTypes.Characters
                    PlayerIndex = Index.Index(XML.DBTypes.Characters, Objects.CharacterType)
            End Select

            'collections
            MonsterRaces = Objects.GetAllObjectsOfType(XML.DBTypes.MonsterRaces, Objects.MonsterRaceDefinitionType)

            'initialise controls
            STRRaceMod.Text = "0"
            DEXRaceMod.Text = "0"
            CONRaceMod.Text = "0"
            INTRaceMod.Text = "0"
            WISRaceMod.Text = "0"
            CHARaceMod.Text = "0"

            CompanionTypeDropdown.Properties.Items.AddRange(Rules.Lists.CompanionTypes)
            If PlayerIndex IsNot Nothing Then PlayerName.Properties.Items.AddRange(Index.IndexNames(PlayerIndex))
            Gender.Properties.Items.AddRange(Lists.GenderTypes)

            UpdateModifiersAndFinal()

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

            'init object
            Select Case Folder.Type
                Case Objects.MonsterFolderType
                    mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Monsters)
                    mObject.Type = Objects.MonsterType
                Case Objects.CharacterFolderType
                    mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Characters)
                    mObject.Type = Objects.CharacterType
            End Select

            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Companion"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            'initialise controls
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
            Me.Text = "Edit Companion"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            PlayerName.Text = mObject.Element("Master")
            Race.EditValue = New DataListItem(Nothing, mObject.GetFKGuid("Race"), mObject.Element("Race"))
            Race_SelectedIndexChanged(Nothing, Nothing)

            Select Case mObject.Element("CharacterType")
                Case "Animal Companion"
                    If mObject.Element("Mount") = "Yes" Then
                        CompanionTypeDropdown.Text = "Mount"
                    Else
                        CompanionTypeDropdown.Text = "Animal Companion"
                    End If
                Case "Familiar"
                    CompanionTypeDropdown.Text = "Familiar or Psicrystal"
                Case "Special Mount"
                    CompanionTypeDropdown.Text = "Special Mount or Fiendish Servant"
            End Select

            Gender.Text = mObject.Element("Gender")
            Alignment.Text = mObject.Element("Alignment")
            Description.Text = mObject.Element("Description")

            Character = CharacterManager.GetCharacter(Obj.ObjectGUID)

            If Character.CharacterLevel > 0 Then
                EditingExisting = True
                STR.Value = Character.CurrentLevel.STR(True)
                CON.Value = Character.CurrentLevel.CON(True)
                DEX.Value = Character.CurrentLevel.DEX(True)
                INT.Value = Character.CurrentLevel.INT(True)
                WIS.Value = Character.CurrentLevel.WIS(True)
                CHA.Value = Character.CurrentLevel.CHA(True)
            Else
                STR.Text = mObject.Element("STR")
                CON.Text = mObject.Element("CON")
                DEX.Text = mObject.Element("DEX")
                INT.Text = mObject.Element("INT")
                WIS.Text = mObject.Element("WIS")
                CHA.Text = mObject.Element("CHA")
            End If

            'Check for existing levels
            Child = Obj.FirstChildOfType(Objects.CharacterLevelsFolderType)

            If EditingExisting Then
                PlayerName.Enabled = False
                CompanionTypeDropdown.Enabled = False
                Race.Properties.Enabled = False
                Label24.Visible = True
                Label25.Visible = True
                Label20.Visible = False
                Label23.Visible = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As New Objects.ObjectData
        Dim RaceObj As New Objects.ObjectData
        Dim SkillFolder As New Objects.ObjectData
        Dim WeaponsFolder As New Objects.ObjectData
        Dim TempParentGuid As Objects.ObjectKey
        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                mObject.Name = ObjectName.Text
                Select Case mMode
                    Case FormMode.Add

                        'fixed folders
                        Obj.Name = "Features"
                        Obj.Type = Objects.FeatureFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Feats"
                        Obj.Type = Objects.FeatFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Levels"
                        Obj.Type = Objects.CharacterLevelsFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        SkillFolder.Name = "Skills"
                        SkillFolder.Type = Objects.SkillFolderType
                        SkillFolder.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        SkillFolder.ParentGUID = mObject.ObjectGUID
                        SkillFolder.Save()

                        Obj.Clear()
                        Obj.Name = "Modifiers"
                        Obj.Type = Objects.ModifierFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Weapons"
                        Obj.Type = Objects.WeaponConfigFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()
                        WeaponsFolder = Obj

                        Obj.Clear()
                        Obj.Name = "Inventory"
                        Obj.Type = Objects.InventoryFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Languages"
                        Obj.Type = Objects.LanguageFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Magic"
                        Obj.Type = Objects.MagicFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()
                        TempParentGuid = Obj.ObjectGUID

                        Obj.Clear()
                        Obj.Name = "Spell Like Abilities"
                        Obj.Type = Objects.SpellLikeAbilityFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = TempParentGuid
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Psionic"
                        Obj.Type = Objects.PsionicFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()
                        TempParentGuid = Obj.ObjectGUID

                        Obj.Clear()
                        Obj.Name = "Psi Like Abilities"
                        Obj.Type = Objects.PsiLikeAbilityFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = TempParentGuid
                        Obj.Save()

                        'other elements
                        mObject.Element("CurrentHP") = "0"
                        mObject.Element("XP") = "0"

                    Case FormMode.Edit
                        'Update Character
                        CharacterManager.SetDirty(mObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)

                    Case FormMode.NotSet
                        Throw New DevelopmentException("Form Mode not set")
                End Select

                'get race object                
                RaceObj.Load(CType(Race.SelectedItem, DataListItem).ObjectGUID)

                'add in any default weapons
                If mMode = FormMode.Add Then
                    For Each WeaponConfig As Objects.ObjectData In RaceObj.ChildrenOfType(Objects.WeaponConfigType)
                        Dim NewConfig As Objects.ObjectData
                        NewConfig = WeaponConfig.CloneSingle(WeaponsFolder)
                        NewConfig.Save()
                    Next
                End If

                'updates common to add and edit
                mObject.Element("Name") = ObjectName.Text

                mObject.Element("Mount") = ""
                Select Case CompanionTypeDropdown.Text
                    Case "Animal Companion"
                        mObject.Element("CharacterType") = "Animal Companion"
                    Case "Familiar or Psicrystal"
                        mObject.Element("CharacterType") = "Familiar"
                    Case "Mount"
                        mObject.Element("CharacterType") = "Animal Companion"
                        mObject.Element("Mount") = "Yes"
                    Case "Special Mount or Fiendish Servant"
                        mObject.Element("CharacterType") = "Special Mount"
                End Select

                If PlayerIndex IsNot Nothing Then
                    mObject.FKElement("Master", PlayerName.Text, "Name", PlayerIndex(PlayerName.SelectedIndex).ObjectGUID)
                Else
                    mObject.FKSetNull("Master")
                End If
                mObject.FKElement("Race", Race.Text, "Name", RaceObj.ObjectGUID)
                mObject.Element("Gender") = Gender.Text
                mObject.Element("Alignment") = Alignment.Text
                mObject.Element("Description") = Description.Text

                Dim UpdateCharacter As Boolean = False
                If mMode = FormMode.Edit AndAlso Character.CharacterLevel > 0 Then UpdateCharacter = True

                If UpdateCharacter Then
                    Dim CurrentLevel As Character.Level = Character.CurrentLevel
                    CurrentLevel.STR = CType(STR.Value, Integer)
                    CurrentLevel.CON = CType(CON.Value, Integer)
                    CurrentLevel.DEX = CType(DEX.Value, Integer)
                    CurrentLevel.INT = CType(INT.Value, Integer)
                    CurrentLevel.WIS = CType(WIS.Value, Integer)
                    CurrentLevel.CHA = CType(CHA.Value, Integer)
                    Character.UpdateSavedLevel(CurrentLevel)
                    CharacterManager.SetDirty(mObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
                Else
                    mObject.Element("STR") = STR.Text
                    mObject.Element("CON") = CON.Text
                    mObject.Element("DEX") = DEX.Text
                    mObject.Element("INT") = INT.Text
                    mObject.Element("WIS") = WIS.Text
                    mObject.Element("CHA") = CHA.Text
                End If

                mObject = PropertiesTab.UpdateObject(mObject)
                mObject.Save()

                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.TreeView.BeginUpdate()

                    Dim CurrentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ObjectGUID), TreeNode)

                    'suspend event before removing node, so we dont run HandleTreeViewNodeSelect
                    Dim CurrentSuspend As Boolean = MainExplorer.SuspendEvents
                    If Not CurrentNode Is Nothing Then
                        MainExplorer.SuspendEvents = True
                        CurrentNode.Remove()
                        MainExplorer.SuspendEvents = CurrentSuspend
                    End If

                    Dim ParentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode)
                    Dim NewNode As TreeNode = General.MainExplorer.CompleteNodeFromObject(mObject)
                    General.MainExplorer.InsertNode(ParentNode, NewNode)

                    General.MainExplorer.TreeView.EndUpdate()

                End If

                'refresh explorer and close
                WindowManager.SetDirty(mObject.Parent)
                WindowManager.RefreshTreeNodes()
                WindowManager.RefreshTabNames()
                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)

                'resync XMLworkshop
                If Not (General.XMLWorkShop Is Nothing) Then
                    General.XMLWorkShop.ReInit()
                End If

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
                If mMode = FormMode.Add AndAlso DialogResult = Windows.Forms.DialogResult.OK Then
                    Commands.AddCharacterLevel(mObject)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.CharacterTab.Controls, Errors)




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

    Private Sub CHA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHA.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub CON_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CON.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DEX_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEX.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub INT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INT.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub STR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STR.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub WIS_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIS.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Tab Code"

    'set the minimum values for the controls
    Private Sub SetMinimums()
        Try
            If STRRaceMod.Text <> "-" Then
                STR.Enabled = True
                STR.Properties.MinValue = -1 * (CInt(STRRaceMod.Text) - 1) : STR.Value = 0
            Else
                STR.Enabled = False
                STR.Value = 0
            End If

            If DEXRaceMod.Text <> "-" Then
                DEX.Enabled = True
                DEX.Properties.MinValue = -1 * (CInt(DEXRaceMod.Text) - 1) : DEX.Value = 0
            Else
                DEX.Enabled = False
                DEX.Value = 0
            End If

            If CONRaceMod.Text <> "-" Then
                CON.Enabled = True
                CON.Properties.MinValue = -1 * (CInt(CONRaceMod.Text) - 1) : CON.Value = 0
            Else
                CON.Enabled = False
                CON.Value = 0
            End If

            If INTRaceMod.Text <> "-" Then
                INT.Enabled = True
                INT.Properties.MinValue = -1 * (CInt(INTRaceMod.Text) - 1) : INT.Value = 0
            Else
                INT.Enabled = False
                INT.Value = 0
            End If

            WIS.Properties.MinValue = -1 * (CInt(WISRaceMod.Text) - 1) : WIS.Value = 0
            CHA.Properties.MinValue = -1 * (CInt(CHARaceMod.Text) - 1) : CHA.Value = 0

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'refresh the modifier colours and values and final ability scores
    Private Sub UpdateModifiersAndFinal()
        Dim Modifier As Integer
        Try

            If STRRaceMod.Text <> "-" Then
                STRFinal.Text = (CInt(STR.EditValue) + CInt(STRRaceMod.Text)).ToString
            Else
                STRFinal.Text = "-"
            End If

            If DEXRaceMod.Text <> "-" Then
                DEXFinal.Text = (CInt(DEX.EditValue) + CInt(DEXRaceMod.Text)).ToString
            Else
                DEXFinal.Text = "-"
            End If

            If CONRaceMod.Text <> "-" Then
                CONFinal.Text = (CInt(CON.EditValue) + CInt(CONRaceMod.Text)).ToString
            Else
                CONFinal.Text = "-"
            End If

            If INTRaceMod.Text <> "-" Then
                INTFinal.Text = (CInt(INT.EditValue) + CInt(INTRaceMod.Text)).ToString
            Else
                INTFinal.Text = "-"
            End If

            WISFinal.Text = (CInt(WIS.EditValue) + CInt(WISRaceMod.Text)).ToString
            CHAFinal.Text = (CInt(CHA.EditValue) + CInt(CHARaceMod.Text)).ToString

            'strength
            If STRFinal.Text = "-" Then
                Modifier = AbilityScores.AbilityScore(-1).Modifier
            Else
                Modifier = AbilityScores.AbilityScore(CInt(STR.Text) + CInt(STRRaceMod.Text)).Modifier
            End If

            If Modifier > 0 Then
                STRMod.BackColor = BackColourPositive
                STRMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                STRMod.BackColor = BackColourNegative
                STRMod.Text = Modifier.ToString
            Else
                STRMod.BackColor = BackColourWhite
                STRMod.Text = Modifier.ToString
            End If

            'dexterity
            If DEXFinal.Text = "-" Then
                Modifier = AbilityScores.AbilityScore(-1).Modifier
            Else
                Modifier = AbilityScores.AbilityScore(CInt(DEX.Text) + CInt(DEXRaceMod.Text)).Modifier
            End If

            If Modifier > 0 Then
                DEXMod.BackColor = BackColourPositive
                DEXMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                DEXMod.BackColor = BackColourNegative
                DEXMod.Text = Modifier.ToString
            Else
                DEXMod.BackColor = BackColourWhite
                DEXMod.Text = Modifier.ToString
            End If

            'constitution
            If CONFinal.Text = "-" Then
                Modifier = AbilityScores.AbilityScore(-1).Modifier
            Else
                Modifier = AbilityScores.AbilityScore(CInt(CON.Text) + CInt(CONRaceMod.Text)).Modifier
            End If

            If Modifier > 0 Then
                CONMod.BackColor = BackColourPositive
                CONMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                CONMod.BackColor = BackColourNegative
                CONMod.Text = Modifier.ToString
            Else
                CONMod.BackColor = BackColourWhite
                CONMod.Text = Modifier.ToString
            End If

            'intelligence
            If INTFinal.Text = "-" Then
                Modifier = AbilityScores.AbilityScore(-1).Modifier
            Else
                Modifier = AbilityScores.AbilityScore(CInt(INT.Text) + CInt(INTRaceMod.Text)).Modifier
            End If

            If Modifier > 0 Then
                INTMod.BackColor = BackColourPositive
                INTMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                INTMod.BackColor = BackColourNegative
                INTMod.Text = Modifier.ToString
            Else
                INTMod.BackColor = BackColourWhite
                INTMod.Text = Modifier.ToString
            End If

            'wisdom
            Modifier = AbilityScores.AbilityScore(CInt(WIS.Text) + CInt(WISRaceMod.Text)).Modifier
            If Modifier > 0 Then
                WISMod.BackColor = BackColourPositive
                WISMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                WISMod.BackColor = BackColourNegative
                WISMod.Text = Modifier.ToString
            Else
                WISMod.BackColor = BackColourWhite
                WISMod.Text = Modifier.ToString
            End If

            'charisma
            Modifier = AbilityScores.AbilityScore(CInt(CHA.Text) + CInt(CHARaceMod.Text)).Modifier
            If Modifier > 0 Then
                CHAMod.BackColor = BackColourPositive
                CHAMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                CHAMod.BackColor = BackColourNegative
                CHAMod.Text = Modifier.ToString
            Else
                CHAMod.BackColor = BackColourWhite
                CHAMod.Text = Modifier.ToString
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle a change of race
    Private Sub Race_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Race.SelectedIndexChanged
        Dim RaceObj As New Objects.ObjectData

        Try
            RaceObj.Load(CType(Race.SelectedItem, DataListItem).ObjectGUID)
            STRRaceMod.Text = RaceObj.Element("STRModifier")
            CONRaceMod.Text = RaceObj.Element("CONModifier")
            DEXRaceMod.Text = RaceObj.Element("DEXModifier")
            INTRaceMod.Text = RaceObj.Element("INTModifier")
            WISRaceMod.Text = RaceObj.Element("WISModifier")
            CHARaceMod.Text = RaceObj.Element("CHAModifier")

            'Alignments
            Alignment.Properties.Items.Clear()

            If RaceObj.Element("LawfulGood") = "True" Then Alignment.Properties.Items.Add("Lawful Good")
            If RaceObj.Element("NeutralGood") = "True" Then Alignment.Properties.Items.Add("Neutral Good")
            If RaceObj.Element("ChaoticGood") = "True" Then Alignment.Properties.Items.Add("Chaotic Good")

            If RaceObj.Element("LawfulNeutral") = "True" Then Alignment.Properties.Items.Add("Lawful Neutral")
            If RaceObj.Element("TrueNeutral") = "True" Then Alignment.Properties.Items.Add("True Neutral")
            If RaceObj.Element("ChaoticNeutral") = "True" Then Alignment.Properties.Items.Add("Chaotic Neutral")

            If RaceObj.Element("LawfulEvil") = "True" Then Alignment.Properties.Items.Add("Lawful Evil")
            If RaceObj.Element("NeutralEvil") = "True" Then Alignment.Properties.Items.Add("Neutral Evil")
            If RaceObj.Element("ChaoticEvil") = "True" Then Alignment.Properties.Items.Add("Chaotic Evil")

            'pick automatically if only one choice
            If Alignment.Properties.Items.Count = 1 Then Alignment.SelectedIndex = 0

            'blank if required
            If Alignment.SelectedIndex = -1 Then
                Alignment.SelectedIndex = -1
            End If

            SetMinimums()
            UpdateModifiersAndFinal()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Drag and Drop"

    'function to set the background colour of each score - yellow means a roll has been assigned
    'Private Sub SetRollAssignedIndicators()
    '    Dim n As Integer

    '    Try
    '        STR.BackColor = Drawing.Color.White
    '        DEX.BackColor = Drawing.Color.White
    '        CON.BackColor = Drawing.Color.White
    '        INT.BackColor = Drawing.Color.White
    '        WIS.BackColor = Drawing.Color.White
    '        CHA.BackColor = Drawing.Color.White

    '        If RollAssignment(0) > 0 Then STR.BackColor = Drawing.Color.Gold
    '        If RollAssignment(1) > 0 Then DEX.BackColor = Drawing.Color.Gold
    '        If RollAssignment(2) > 0 Then CON.BackColor = Drawing.Color.Gold
    '        If RollAssignment(3) > 0 Then INT.BackColor = Drawing.Color.Gold
    '        If RollAssignment(4) > 0 Then WIS.BackColor = Drawing.Color.Gold
    '        If RollAssignment(5) > 0 Then CHA.BackColor = Drawing.Color.Gold

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

#End Region

#Region "Spin Fix"

    Private AllowSpin As Boolean

    Private Sub SpinFix(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs)
        If AllowSpin Then
            AllowSpin = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

    Private Function CalculatePointsSpent() As Integer
        Try

            Dim Points As Integer
            Points = Rules.AbilityScores.AbilityScore(CInt(STR.Value)).PointCost
            Points += Rules.AbilityScores.AbilityScore(CInt(DEX.Value)).PointCost
            Points += Rules.AbilityScores.AbilityScore(CInt(CON.Value)).PointCost
            Points += Rules.AbilityScores.AbilityScore(CInt(INT.Value)).PointCost
            Points += Rules.AbilityScores.AbilityScore(CInt(WIS.Value)).PointCost
            Points += Rules.AbilityScores.AbilityScore(CInt(CHA.Value)).PointCost
            Return Points

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Private Sub CompanionTypeDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanionTypeDropdown.SelectedIndexChanged
        Select Case CompanionTypeDropdown.Text
            Case "Animal Companion"
                PropertiesTab.ImageFilename.Text = "AnimalCompanion.png"
            Case "Familiar or Psicrystal"
                PropertiesTab.ImageFilename.Text = "Familiar.png"
            Case "Special Mount or Fiendish Servant"
                PropertiesTab.ImageFilename.Text = "MountWhite.png"
            Case "Mount"
                PropertiesTab.ImageFilename.Text = "MountBrown.png"
            Case Else
                ' do nothing
        End Select

        'filter race options
        Dim CompantionType As String = CompanionTypeDropdown.Text
        Dim AllowedRaces As New Objects.ObjectDataCollection
        For Each RaceObj As Objects.ObjectData In MonsterRaces
            Select Case CompantionType
                Case "Animal Companion"
                    If RaceObj.Element("CompanionClass") <> "" Then AllowedRaces.Add(RaceObj)
                Case "Familiar or Psicrystal"
                    If RaceObj.Element("FamiliarClass") <> "" Then AllowedRaces.Add(RaceObj)
                Case "Special Mount or Fiendish Servant"
                    If RaceObj.Element("MountClass") <> "" Then AllowedRaces.Add(RaceObj)
                Case "Mount"
                    If RaceObj.Element("NormalMount") <> "" Then AllowedRaces.Add(RaceObj)
            End Select
        Next

        Race.Properties.Items.Clear()
        RaceIndex = Rules.Index.DataList(AllowedRaces, False)
        Race.Properties.Items.AddRange(RaceIndex)

        'blank if required
        If Race.SelectedIndex = -1 Then
            Race.SelectedIndex = -1
            Alignment.Properties.Items.Clear()
            Alignment.SelectedIndex = -1
        End If

    End Sub

End Class