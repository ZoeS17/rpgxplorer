Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class CharacterForm
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
    Public WithEvents Alignment As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents INT As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents CHA As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents WIS As DevExpress.XtraEditors.SpinEdit
    Public WithEvents STR As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents CON As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents DEX As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
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
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Roll6 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Roll5 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Roll4 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Roll3 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Roll2 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Roll1 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents RollDice As System.Windows.Forms.Button
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents RollMethod As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents CHAFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents WISFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents INTFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents CONFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DEXFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents STRFinal As RPGXplorer.ReadOnlyTextBox
    Public WithEvents RollHeightWeightAge As System.Windows.Forms.Button
    Public WithEvents AgeRollType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents CharacterAge As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents CharacterTab As System.Windows.Forms.TabPage
    Public WithEvents CharacterWeight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents CharacterHeight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PlayerName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Deity As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents PointsDisplay As RPGXplorer.ReadOnlyTextBox
    Public WithEvents PointsLabel As System.Windows.Forms.Label
    Public WithEvents EliteButton As System.Windows.Forms.Button
    Public WithEvents NoneliteButton As System.Windows.Forms.Button
    Public WithEvents Reset As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.CharacterTab = New System.Windows.Forms.TabPage
        Me.EliteButton = New System.Windows.Forms.Button
        Me.NoneliteButton = New System.Windows.Forms.Button
        Me.Reset = New System.Windows.Forms.Button
        Me.PointsLabel = New System.Windows.Forms.Label
        Me.PointsDisplay = New RPGXplorer.ReadOnlyTextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Deity = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.PlayerName = New DevExpress.XtraEditors.TextEdit
        Me.CharacterHeight = New DevExpress.XtraEditors.SpinEdit
        Me.CharacterWeight = New DevExpress.XtraEditors.SpinEdit
        Me.AgeRollType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CharacterAge = New DevExpress.XtraEditors.SpinEdit
        Me.RollHeightWeightAge = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.CHAFinal = New RPGXplorer.ReadOnlyTextBox
        Me.WISFinal = New RPGXplorer.ReadOnlyTextBox
        Me.INTFinal = New RPGXplorer.ReadOnlyTextBox
        Me.CONFinal = New RPGXplorer.ReadOnlyTextBox
        Me.DEXFinal = New RPGXplorer.ReadOnlyTextBox
        Me.STRFinal = New RPGXplorer.ReadOnlyTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.RollMethod = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Roll6 = New RPGXplorer.ReadOnlyTextBox
        Me.Roll5 = New RPGXplorer.ReadOnlyTextBox
        Me.Roll4 = New RPGXplorer.ReadOnlyTextBox
        Me.Roll3 = New RPGXplorer.ReadOnlyTextBox
        Me.Roll2 = New RPGXplorer.ReadOnlyTextBox
        Me.Roll1 = New RPGXplorer.ReadOnlyTextBox
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
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.INT = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CHA = New DevExpress.XtraEditors.SpinEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.WIS = New DevExpress.XtraEditors.SpinEdit
        Me.STR = New DevExpress.XtraEditors.SpinEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CON = New DevExpress.XtraEditors.SpinEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.DEX = New DevExpress.XtraEditors.SpinEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Alignment = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Gender = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Race = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.RollDice = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.CharacterTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeRollType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Race.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CharacterTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 590)
        Me.TabControl1.TabIndex = 1
        '
        'CharacterTab
        '
        Me.CharacterTab.Controls.Add(Me.EliteButton)
        Me.CharacterTab.Controls.Add(Me.NoneliteButton)
        Me.CharacterTab.Controls.Add(Me.Reset)
        Me.CharacterTab.Controls.Add(Me.PointsLabel)
        Me.CharacterTab.Controls.Add(Me.PointsDisplay)
        Me.CharacterTab.Controls.Add(Me.Label25)
        Me.CharacterTab.Controls.Add(Me.Label24)
        Me.CharacterTab.Controls.Add(Me.Label20)
        Me.CharacterTab.Controls.Add(Me.Label23)
        Me.CharacterTab.Controls.Add(Me.PictureBox1)
        Me.CharacterTab.Controls.Add(Me.Label22)
        Me.CharacterTab.Controls.Add(Me.Deity)
        Me.CharacterTab.Controls.Add(Me.Label21)
        Me.CharacterTab.Controls.Add(Me.PlayerName)
        Me.CharacterTab.Controls.Add(Me.CharacterHeight)
        Me.CharacterTab.Controls.Add(Me.CharacterWeight)
        Me.CharacterTab.Controls.Add(Me.AgeRollType)
        Me.CharacterTab.Controls.Add(Me.CharacterAge)
        Me.CharacterTab.Controls.Add(Me.RollHeightWeightAge)
        Me.CharacterTab.Controls.Add(Me.Label18)
        Me.CharacterTab.Controls.Add(Me.CHAFinal)
        Me.CharacterTab.Controls.Add(Me.WISFinal)
        Me.CharacterTab.Controls.Add(Me.INTFinal)
        Me.CharacterTab.Controls.Add(Me.CONFinal)
        Me.CharacterTab.Controls.Add(Me.DEXFinal)
        Me.CharacterTab.Controls.Add(Me.STRFinal)
        Me.CharacterTab.Controls.Add(Me.Label17)
        Me.CharacterTab.Controls.Add(Me.RollMethod)
        Me.CharacterTab.Controls.Add(Me.Label16)
        Me.CharacterTab.Controls.Add(Me.Roll6)
        Me.CharacterTab.Controls.Add(Me.Roll5)
        Me.CharacterTab.Controls.Add(Me.Roll4)
        Me.CharacterTab.Controls.Add(Me.Roll3)
        Me.CharacterTab.Controls.Add(Me.Roll2)
        Me.CharacterTab.Controls.Add(Me.Roll1)
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
        Me.CharacterTab.Controls.Add(Me.IndentedLine2)
        Me.CharacterTab.Controls.Add(Me.Label14)
        Me.CharacterTab.Controls.Add(Me.Label4)
        Me.CharacterTab.Controls.Add(Me.Label6)
        Me.CharacterTab.Controls.Add(Me.IndentedLine1)
        Me.CharacterTab.Controls.Add(Me.INT)
        Me.CharacterTab.Controls.Add(Me.Label1)
        Me.CharacterTab.Controls.Add(Me.Label7)
        Me.CharacterTab.Controls.Add(Me.CHA)
        Me.CharacterTab.Controls.Add(Me.Label9)
        Me.CharacterTab.Controls.Add(Me.WIS)
        Me.CharacterTab.Controls.Add(Me.STR)
        Me.CharacterTab.Controls.Add(Me.Label10)
        Me.CharacterTab.Controls.Add(Me.Label12)
        Me.CharacterTab.Controls.Add(Me.CON)
        Me.CharacterTab.Controls.Add(Me.Label13)
        Me.CharacterTab.Controls.Add(Me.DEX)
        Me.CharacterTab.Controls.Add(Me.Label8)
        Me.CharacterTab.Controls.Add(Me.Alignment)
        Me.CharacterTab.Controls.Add(Me.Gender)
        Me.CharacterTab.Controls.Add(Me.Label5)
        Me.CharacterTab.Controls.Add(Me.Label3)
        Me.CharacterTab.Controls.Add(Me.Race)
        Me.CharacterTab.Controls.Add(Me.ObjectName)
        Me.CharacterTab.Controls.Add(Me.Label2)
        Me.CharacterTab.Controls.Add(Me.RollDice)
        Me.CharacterTab.Controls.Add(Me.Label19)
        Me.CharacterTab.Location = New System.Drawing.Point(4, 22)
        Me.CharacterTab.Name = "CharacterTab"
        Me.CharacterTab.Size = New System.Drawing.Size(407, 564)
        Me.CharacterTab.TabIndex = 0
        Me.CharacterTab.Text = "Character"
        '
        'EliteButton
        '
        Me.EliteButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliteButton.Location = New System.Drawing.Point(300, 325)
        Me.EliteButton.Name = "EliteButton"
        Me.EliteButton.Size = New System.Drawing.Size(85, 24)
        Me.EliteButton.TabIndex = 15
        Me.EliteButton.Text = "Elite"
        Me.EliteButton.Visible = False
        '
        'NoneliteButton
        '
        Me.NoneliteButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoneliteButton.Location = New System.Drawing.Point(300, 295)
        Me.NoneliteButton.Name = "NoneliteButton"
        Me.NoneliteButton.Size = New System.Drawing.Size(85, 24)
        Me.NoneliteButton.TabIndex = 13
        Me.NoneliteButton.Text = "Nonelite"
        Me.NoneliteButton.Visible = False
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(300, 355)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(85, 24)
        Me.Reset.TabIndex = 16
        Me.Reset.Text = "Reset"
        Me.Reset.Visible = False
        '
        'PointsLabel
        '
        Me.PointsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PointsLabel.Location = New System.Drawing.Point(300, 295)
        Me.PointsLabel.Name = "PointsLabel"
        Me.PointsLabel.Size = New System.Drawing.Size(90, 21)
        Me.PointsLabel.TabIndex = 312
        Me.PointsLabel.Text = "Points Spent"
        Me.PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PointsLabel.Visible = False
        '
        'PointsDisplay
        '
        Me.PointsDisplay.BackColor = System.Drawing.Color.White
        Me.PointsDisplay.Caption = Nothing
        Me.PointsDisplay.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PointsDisplay.ForeColor = System.Drawing.Color.Black
        Me.PointsDisplay.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PointsDisplay.Location = New System.Drawing.Point(300, 325)
        Me.PointsDisplay.Name = "PointsDisplay"
        Me.PointsDisplay.Padding = New System.Windows.Forms.Padding(1)
        Me.PointsDisplay.Size = New System.Drawing.Size(50, 21)
        Me.PointsDisplay.TabIndex = 311
        Me.PointsDisplay.TabStop = False
        Me.PointsDisplay.TextColor = System.Drawing.Color.Black
        Me.PointsDisplay.Vertical = False
        Me.PointsDisplay.Visible = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(55, 430)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(255, 15)
        Me.Label25.TabIndex = 310
        Me.Label25.Text = "at the character's current level."
        Me.Label25.Visible = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(55, 415)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(255, 15)
        Me.Label24.TabIndex = 309
        Me.Label24.Text = "Changes to the ability scores take effect"
        Me.Label24.Visible = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(55, 430)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(270, 15)
        Me.Label20.TabIndex = 308
        Me.Label20.Text = "Drag an assigned score onto another ability to swap."
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(55, 415)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(245, 15)
        Me.Label23.TabIndex = 307
        Me.Label23.Text = "Drag rolled scores onto an ability to assign."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 416)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 306
        Me.PictureBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(15, 165)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 21)
        Me.Label22.TabIndex = 305
        Me.Label22.Text = "Deity"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Deity
        '
        Me.Deity.Location = New System.Drawing.Point(110, 165)
        Me.Deity.Name = "Deity"
        Me.Deity.Properties.AutoHeight = False
        Me.Deity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Deity.Properties.DropDownRows = 10
        Me.Deity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Deity.Size = New System.Drawing.Size(150, 21)
        Me.Deity.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.CausesValidation = False
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 21)
        Me.Label21.TabIndex = 303
        Me.Label21.Text = "Player"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PlayerName
        '
        Me.PlayerName.CausesValidation = False
        Me.PlayerName.Location = New System.Drawing.Point(110, 45)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Properties.AutoHeight = False
        Me.PlayerName.Properties.MaxLength = 100
        Me.PlayerName.Size = New System.Drawing.Size(150, 21)
        Me.PlayerName.TabIndex = 1
        '
        'CharacterHeight
        '
        Me.CharacterHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CharacterHeight.Location = New System.Drawing.Point(70, 500)
        Me.CharacterHeight.Name = "CharacterHeight"
        Me.CharacterHeight.Properties.Appearance.Options.UseTextOptions = True
        Me.CharacterHeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CharacterHeight.Properties.AutoHeight = False
        Me.CharacterHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CharacterHeight.Properties.Mask.BeepOnError = True
        Me.CharacterHeight.Properties.Mask.EditMask = "9999"
        Me.CharacterHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.CharacterHeight.Properties.Mask.ShowPlaceHolders = False
        Me.CharacterHeight.Properties.MaxValue = New Decimal(New Integer() {2400, 0, 0, 0})
        Me.CharacterHeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CharacterHeight.Size = New System.Drawing.Size(100, 21)
        Me.CharacterHeight.TabIndex = 19
        '
        'CharacterWeight
        '
        Me.CharacterWeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CharacterWeight.Location = New System.Drawing.Point(70, 530)
        Me.CharacterWeight.Name = "CharacterWeight"
        Me.CharacterWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.CharacterWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CharacterWeight.Properties.AutoHeight = False
        Me.CharacterWeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CharacterWeight.Properties.Mask.BeepOnError = True
        Me.CharacterWeight.Properties.Mask.EditMask = "f4"
        Me.CharacterWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CharacterWeight.Properties.Mask.ShowPlaceHolders = False
        Me.CharacterWeight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.CharacterWeight.Size = New System.Drawing.Size(100, 21)
        Me.CharacterWeight.TabIndex = 20
        '
        'AgeRollType
        '
        Me.AgeRollType.EditValue = ""
        Me.AgeRollType.Location = New System.Drawing.Point(165, 470)
        Me.AgeRollType.Name = "AgeRollType"
        Me.AgeRollType.Properties.AutoHeight = False
        Me.AgeRollType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AgeRollType.Properties.DropDownRows = 10
        Me.AgeRollType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AgeRollType.Size = New System.Drawing.Size(210, 21)
        Me.AgeRollType.TabIndex = 18
        '
        'CharacterAge
        '
        Me.CharacterAge.AllowDrop = True
        Me.CharacterAge.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CharacterAge.Location = New System.Drawing.Point(70, 470)
        Me.CharacterAge.Name = "CharacterAge"
        Me.CharacterAge.Properties.Appearance.Options.UseTextOptions = True
        Me.CharacterAge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CharacterAge.Properties.AutoHeight = False
        Me.CharacterAge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CharacterAge.Properties.IsFloatValue = False
        Me.CharacterAge.Properties.Mask.BeepOnError = True
        Me.CharacterAge.Properties.Mask.EditMask = "d"
        Me.CharacterAge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CharacterAge.Properties.Mask.ShowPlaceHolders = False
        Me.CharacterAge.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.CharacterAge.Size = New System.Drawing.Size(60, 21)
        Me.CharacterAge.TabIndex = 17
        '
        'RollHeightWeightAge
        '
        Me.RollHeightWeightAge.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollHeightWeightAge.Location = New System.Drawing.Point(290, 525)
        Me.RollHeightWeightAge.Name = "RollHeightWeightAge"
        Me.RollHeightWeightAge.Size = New System.Drawing.Size(85, 24)
        Me.RollHeightWeightAge.TabIndex = 21
        Me.RollHeightWeightAge.Text = "ROLL"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(210, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 295
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
        Me.CHAFinal.Location = New System.Drawing.Point(210, 385)
        Me.CHAFinal.Name = "CHAFinal"
        Me.CHAFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.CHAFinal.Size = New System.Drawing.Size(35, 21)
        Me.CHAFinal.TabIndex = 294
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
        Me.WISFinal.Location = New System.Drawing.Point(210, 355)
        Me.WISFinal.Name = "WISFinal"
        Me.WISFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.WISFinal.Size = New System.Drawing.Size(35, 21)
        Me.WISFinal.TabIndex = 293
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
        Me.INTFinal.Location = New System.Drawing.Point(210, 325)
        Me.INTFinal.Name = "INTFinal"
        Me.INTFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.INTFinal.Size = New System.Drawing.Size(35, 21)
        Me.INTFinal.TabIndex = 292
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
        Me.CONFinal.Location = New System.Drawing.Point(210, 295)
        Me.CONFinal.Name = "CONFinal"
        Me.CONFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.CONFinal.Size = New System.Drawing.Size(35, 21)
        Me.CONFinal.TabIndex = 291
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
        Me.DEXFinal.Location = New System.Drawing.Point(210, 265)
        Me.DEXFinal.Name = "DEXFinal"
        Me.DEXFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.DEXFinal.Size = New System.Drawing.Size(35, 21)
        Me.DEXFinal.TabIndex = 290
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
        Me.STRFinal.Location = New System.Drawing.Point(210, 235)
        Me.STRFinal.Name = "STRFinal"
        Me.STRFinal.Padding = New System.Windows.Forms.Padding(1)
        Me.STRFinal.Size = New System.Drawing.Size(35, 21)
        Me.STRFinal.TabIndex = 289
        Me.STRFinal.TabStop = False
        Me.STRFinal.TextColor = System.Drawing.Color.Black
        Me.STRFinal.Vertical = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(300, 235)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 21)
        Me.Label17.TabIndex = 288
        Me.Label17.Text = "Roll Method"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RollMethod
        '
        Me.RollMethod.CausesValidation = False
        Me.RollMethod.Location = New System.Drawing.Point(300, 265)
        Me.RollMethod.Name = "RollMethod"
        Me.RollMethod.Properties.AutoHeight = False
        Me.RollMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RollMethod.Properties.DropDownRows = 10
        Me.RollMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RollMethod.Size = New System.Drawing.Size(90, 21)
        Me.RollMethod.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(105, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 15)
        Me.Label16.TabIndex = 285
        Me.Label16.Text = "Roll"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Roll6
        '
        Me.Roll6.BackColor = System.Drawing.Color.White
        Me.Roll6.Caption = Nothing
        Me.Roll6.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Roll6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Roll6.ForeColor = System.Drawing.Color.Black
        Me.Roll6.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Roll6.Location = New System.Drawing.Point(110, 385)
        Me.Roll6.Name = "Roll6"
        Me.Roll6.Padding = New System.Windows.Forms.Padding(1)
        Me.Roll6.Size = New System.Drawing.Size(35, 21)
        Me.Roll6.TabIndex = 284
        Me.Roll6.TabStop = False
        Me.Roll6.TextColor = System.Drawing.Color.Black
        Me.Roll6.Vertical = False
        '
        'Roll5
        '
        Me.Roll5.BackColor = System.Drawing.Color.White
        Me.Roll5.Caption = Nothing
        Me.Roll5.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Roll5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Roll5.ForeColor = System.Drawing.Color.Black
        Me.Roll5.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Roll5.Location = New System.Drawing.Point(110, 355)
        Me.Roll5.Name = "Roll5"
        Me.Roll5.Padding = New System.Windows.Forms.Padding(1)
        Me.Roll5.Size = New System.Drawing.Size(35, 21)
        Me.Roll5.TabIndex = 283
        Me.Roll5.TabStop = False
        Me.Roll5.TextColor = System.Drawing.Color.Black
        Me.Roll5.Vertical = False
        '
        'Roll4
        '
        Me.Roll4.BackColor = System.Drawing.Color.White
        Me.Roll4.Caption = Nothing
        Me.Roll4.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Roll4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Roll4.ForeColor = System.Drawing.Color.Black
        Me.Roll4.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Roll4.Location = New System.Drawing.Point(110, 325)
        Me.Roll4.Name = "Roll4"
        Me.Roll4.Padding = New System.Windows.Forms.Padding(1)
        Me.Roll4.Size = New System.Drawing.Size(35, 21)
        Me.Roll4.TabIndex = 282
        Me.Roll4.TabStop = False
        Me.Roll4.TextColor = System.Drawing.Color.Black
        Me.Roll4.Vertical = False
        '
        'Roll3
        '
        Me.Roll3.BackColor = System.Drawing.Color.White
        Me.Roll3.Caption = Nothing
        Me.Roll3.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Roll3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Roll3.ForeColor = System.Drawing.Color.Black
        Me.Roll3.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Roll3.Location = New System.Drawing.Point(110, 295)
        Me.Roll3.Name = "Roll3"
        Me.Roll3.Padding = New System.Windows.Forms.Padding(1)
        Me.Roll3.Size = New System.Drawing.Size(35, 21)
        Me.Roll3.TabIndex = 281
        Me.Roll3.TabStop = False
        Me.Roll3.TextColor = System.Drawing.Color.Black
        Me.Roll3.Vertical = False
        '
        'Roll2
        '
        Me.Roll2.BackColor = System.Drawing.Color.White
        Me.Roll2.Caption = Nothing
        Me.Roll2.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Roll2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Roll2.ForeColor = System.Drawing.Color.Black
        Me.Roll2.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Roll2.Location = New System.Drawing.Point(110, 265)
        Me.Roll2.Name = "Roll2"
        Me.Roll2.Padding = New System.Windows.Forms.Padding(1)
        Me.Roll2.Size = New System.Drawing.Size(35, 21)
        Me.Roll2.TabIndex = 280
        Me.Roll2.TabStop = False
        Me.Roll2.TextColor = System.Drawing.Color.Black
        Me.Roll2.Vertical = False
        '
        'Roll1
        '
        Me.Roll1.BackColor = System.Drawing.Color.White
        Me.Roll1.Caption = Nothing
        Me.Roll1.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Roll1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Roll1.ForeColor = System.Drawing.Color.Black
        Me.Roll1.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Roll1.Location = New System.Drawing.Point(110, 235)
        Me.Roll1.Name = "Roll1"
        Me.Roll1.Padding = New System.Windows.Forms.Padding(1)
        Me.Roll1.Size = New System.Drawing.Size(35, 21)
        Me.Roll1.TabIndex = 279
        Me.Roll1.TabStop = False
        Me.Roll1.TextColor = System.Drawing.Color.Black
        Me.Roll1.Vertical = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(245, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 278
        Me.Label15.Text = "Mod"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(160, 215)
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
        Me.CHARaceMod.Location = New System.Drawing.Point(160, 385)
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
        Me.WISRaceMod.Location = New System.Drawing.Point(160, 355)
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
        Me.INTRaceMod.Location = New System.Drawing.Point(160, 325)
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
        Me.CONRaceMod.Location = New System.Drawing.Point(160, 295)
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
        Me.DEXRaceMod.Location = New System.Drawing.Point(160, 265)
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
        Me.STRRaceMod.Location = New System.Drawing.Point(160, 235)
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
        Me.CHAMod.Location = New System.Drawing.Point(250, 385)
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
        Me.WISMod.Location = New System.Drawing.Point(250, 355)
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
        Me.INTMod.Location = New System.Drawing.Point(250, 325)
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
        Me.CONMod.Location = New System.Drawing.Point(250, 295)
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
        Me.DEXMod.Location = New System.Drawing.Point(250, 265)
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
        Me.STRMod.Location = New System.Drawing.Point(250, 235)
        Me.STRMod.Name = "STRMod"
        Me.STRMod.Padding = New System.Windows.Forms.Padding(1)
        Me.STRMod.Size = New System.Drawing.Size(35, 21)
        Me.STRMod.TabIndex = 265
        Me.STRMod.TabStop = False
        Me.STRMod.TextColor = System.Drawing.Color.Black
        Me.STRMod.Vertical = False
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 455)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 193
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(15, 470)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 21)
        Me.Label14.TabIndex = 192
        Me.Label14.Text = "Age"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Weight"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "Height"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 200)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 186
        '
        'INT
        '
        Me.INT.AllowDrop = True
        Me.INT.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.INT.Location = New System.Drawing.Point(55, 325)
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
        Me.INT.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.INT.Size = New System.Drawing.Size(50, 21)
        Me.INT.TabIndex = 9
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
        'CHA
        '
        Me.CHA.AllowDrop = True
        Me.CHA.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CHA.Location = New System.Drawing.Point(55, 385)
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
        Me.CHA.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.CHA.Size = New System.Drawing.Size(50, 21)
        Me.CHA.TabIndex = 11
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
        'WIS
        '
        Me.WIS.AllowDrop = True
        Me.WIS.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.WIS.Location = New System.Drawing.Point(55, 355)
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
        Me.WIS.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.WIS.Size = New System.Drawing.Size(50, 21)
        Me.WIS.TabIndex = 10
        '
        'STR
        '
        Me.STR.AllowDrop = True
        Me.STR.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.STR.Location = New System.Drawing.Point(55, 235)
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
        Me.STR.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.STR.Size = New System.Drawing.Size(50, 21)
        Me.STR.TabIndex = 6
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
        'CON
        '
        Me.CON.AllowDrop = True
        Me.CON.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CON.Location = New System.Drawing.Point(55, 295)
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
        Me.CON.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.CON.Size = New System.Drawing.Size(50, 21)
        Me.CON.TabIndex = 8
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
        'DEX
        '
        Me.DEX.AllowDrop = True
        Me.DEX.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DEX.Location = New System.Drawing.Point(55, 265)
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
        Me.DEX.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.DEX.Size = New System.Drawing.Size(50, 21)
        Me.DEX.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 21)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Alignment"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alignment
        '
        Me.Alignment.Location = New System.Drawing.Point(110, 135)
        Me.Alignment.Name = "Alignment"
        Me.Alignment.Properties.AutoHeight = False
        Me.Alignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Alignment.Properties.DropDownRows = 10
        Me.Alignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Alignment.Size = New System.Drawing.Size(150, 21)
        Me.Alignment.TabIndex = 4
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(110, 105)
        Me.Gender.Name = "Gender"
        Me.Gender.Properties.AutoHeight = False
        Me.Gender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Gender.Properties.DropDownRows = 10
        Me.Gender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Gender.Size = New System.Drawing.Size(150, 21)
        Me.Gender.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Gender"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Race"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Race
        '
        Me.Race.Location = New System.Drawing.Point(110, 75)
        Me.Race.Name = "Race"
        Me.Race.Properties.AutoHeight = False
        Me.Race.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Race.Properties.DropDownRows = 10
        Me.Race.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Race.Size = New System.Drawing.Size(150, 21)
        Me.Race.TabIndex = 2
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
        Me.Label2.Text = "Character Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RollDice
        '
        Me.RollDice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollDice.Location = New System.Drawing.Point(300, 295)
        Me.RollDice.Name = "RollDice"
        Me.RollDice.Size = New System.Drawing.Size(85, 24)
        Me.RollDice.TabIndex = 14
        Me.RollDice.Text = "ROLL"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(135, 470)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 20)
        Me.Label19.TabIndex = 278
        Me.Label19.Text = "yrs"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 564)
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
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 620)
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
        Me.OK.Location = New System.Drawing.Point(280, 620)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'CharacterForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 658)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CharacterForm"
        Me.TabControl1.ResumeLayout(False)
        Me.CharacterTab.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeRollType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private RaceIndex As Index.IndexEntry()
    Private DeityIndex As Index.IndexEntry()

    'private
    Private RollAssignment(6) As Integer
    Private RollBeingDragged As Integer
    Private Character As Character

    Private HoldPointCalculate As Boolean = False

    'init
    Public Sub Init()
        Try
            'indexes
            RaceIndex = Index.Index(Xml.DBTypes.Races, Objects.RaceType)
            DeityIndex = Index.Index(XML.DBTypes.Deities, Objects.DeityDefinitionType, True)

            'initialise controls
            STRRaceMod.Text = "0"
            DEXRaceMod.Text = "0"
            CONRaceMod.Text = "0"
            INTRaceMod.Text = "0"
            WISRaceMod.Text = "0"
            CHARaceMod.Text = "0"
            Race.Properties.Items.AddRange(Index.IndexNames(RaceIndex))
            Deity.Properties.Items.AddRange(Index.IndexNames(DeityIndex))
            Alignment.Properties.Items.AddRange(Lists.AlignmentTypes)
            Gender.Properties.Items.AddRange(Lists.GenderTypes)
            AgeRollType.Properties.Items.AddRange(Lists.AgeRollTypes)

            RollMethod.Properties.Items.AddRange(Rules.Lists.RollMethods)
            RollMethod.SelectedIndex = 0

            'set initial index of optional selections to 0 for validation
            AgeRollType.SelectedIndex = 0
            Deity.SelectedIndex = 0

            'customformatting
            CharacterHeight.Properties.DisplayFormat.Format = New HeightFormatter
            CharacterHeight.Properties.EditFormat.Format = New HeightFormatter
            CharacterWeight.Properties.DisplayFormat.Format = New WeightFormatter

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
                    mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Monsters)
                    mObject.Type = Objects.MonsterType
                Case Objects.CharacterFolderType
                    mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Characters)
                    mObject.Type = Objects.CharacterType
            End Select
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Character"
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
            Me.Text = "Edit Character"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            PlayerName.Text = mObject.Element("Player")
            Race.Text = mObject.Element("Race")
            Deity.Text = mObject.Element("Deity")
            Gender.Text = mObject.Element("Gender")
            Alignment.Text = mObject.Element("Alignment")

            'CHANGE TO USE CHARACTER MANAGER
            Character = CharacterManager.GetCharacter(mObject.ObjectGUID)

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

            CharacterHeight.Value = mObject.ElementAsInteger("Height")
            CharacterWeight.Value = mObject.ElementAsInteger("Weight")
            CharacterAge.Text = mObject.Element("Age")

            'Check for existing levels
            Child = Obj.FirstChildOfType(Objects.CharacterLevelsFolderType)

            If EditingExisting Then
                Race.Properties.Enabled = False
                RollMethod.Properties.Enabled = False
                RollDice.Enabled = False
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
        Dim TempParentGuid As Objects.ObjectKey
        Dim WeaponsFolder As New Objects.ObjectData
        Dim InventoryFolder As New Objects.ObjectData
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
                        InventoryFolder = Obj

                        Obj.Clear()
                        Obj.Name = "Inventory - Assets"
                        Obj.Type = Objects.AssetsFolderType
                        Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        Obj.ParentGUID = mObject.ObjectGUID
                        Obj.Save()

                        Obj.Clear()
                        Obj.Name = "Choices"
                        Obj.Type = Objects.CharacterChoiceFolderType
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
                RaceObj.Load(RaceIndex(Race.SelectedIndex).ObjectGUID)

                'add in any default items
                If mMode = FormMode.Add Then
                    Dim KeyMap As New ObjectHashtable
                    Dim WeaponConfigs As New Objects.ObjectDataCollection

                    'clone the Inventory Items, Money and Weapon configs
                    For Each TempObject As Objects.ObjectData In RaceObj.Children
                        Select Case TempObject.Type
                            Case Objects.ItemType
                                Dim NewInventoryObjects As Objects.ObjectDataCollection
                                NewInventoryObjects = TempObject.CloneWithKeyMap(InventoryFolder, KeyMap)
                                NewInventoryObjects.Save()

                            Case Objects.MoneyType
                                Dim NewInventoryObject As Objects.ObjectData
                                NewInventoryObject = TempObject.CloneSingle(InventoryFolder)
                                NewInventoryObject.Save()

                            Case Objects.WeaponConfigType
                                Dim NewWeaponConfigObject As Objects.ObjectData
                                NewWeaponConfigObject = TempObject.CloneSingle(WeaponsFolder)
                                NewWeaponConfigObject.Save()
                                WeaponConfigs.Add(NewWeaponConfigObject)
                        End Select
                    Next

                    'update the keys on the weapon configs
                    For Each WeaponConfig As Objects.ObjectData In WeaponConfigs
                        For Each Element As String In WeaponConfig.GetAllFKElements
                            'update any old FK's with new ones
                            Dim FK As Objects.ObjectKey
                            FK = WeaponConfig.GetFKGuid(Element)
                            If KeyMap.ContainsKey(FK) Then
                                WeaponConfig.SetFKGuid(Element, CType(KeyMap.Item(FK), Objects.ObjectKey))
                            End If
                        Next
                        WeaponConfig.Save() 'refresh the FKLookup
                    Next
                End If

                'updates common to add and edit
                mObject.Element("Name") = ObjectName.Text
                mObject.Element("Player") = PlayerName.Text
                mObject.FKElement("Race", Race.Text, "Name", RaceObj.ObjectGUID)

                If Not Deity.Text = "" Then
                    mObject.FKElement("Deity", Deity.Text, "Name", DeityIndex(Deity.SelectedIndex).ObjectGUID)
                Else
                    mObject.FKSetNull("Deity")
                End If

                mObject.Element("Gender") = Gender.Text
                mObject.Element("Alignment") = Alignment.Text

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

                mObject.Element("Age") = CharacterAge.Text
                mObject.Element("Height") = CharacterHeight.Value.ToString
                mObject.Element("Weight") = CharacterWeight.Value.ToString
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

            If CType(CharacterHeight.EditValue, Integer) = 0 Then
                Errors.SetError(CharacterHeight, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(CharacterHeight, "")
            End If

            If CType(CharacterWeight.EditValue, Integer) = 0 Then
                Errors.SetError(CharacterWeight, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(CharacterWeight, "")
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            'need to check for disallowed races

            If General.Mode = AppMode.Trial Then

                Try
                    If Race.SelectedIndex > -1 Then

                        'if the race is a monster race - check the number of levels it is forced to take
                        Dim RaceObj As New Objects.ObjectData
                        RaceObj.Load(RaceIndex(Race.SelectedIndex).ObjectGUID)
                        If RaceObj.Element("Monster") = "Yes" Then
                            Dim Levels As Integer = RaceObj.ElementAsInteger("StartLevels")
                            If Levels > 4 Then
                                Validate = False
                                General.ShowInfoDialog("This race is not allowed in trial mode as it must take more than 4 levels of a Monster Type class.")
                            End If
                        End If

                    End If
                Catch ex As Exception
                    'could not establish the race so do not validate
                    Validate = False
                End Try

            End If


            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

    Private Sub CHA_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CHA.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub CON_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CON.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DEX_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DEX.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub INT_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles INT.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub STR_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles STR.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub WIS_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WIS.EditValueChanged
        Try
            UpdateModifiersAndFinal()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Tab Code"

    'change image according to gender
    Private Sub Gender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gender.SelectedIndexChanged

        If mMode = FormMode.Add Then
            Dim MonsterFlag As Boolean = False
            If Race.Text <> "" Then
                Dim RaceObj As New Objects.ObjectData
                RaceObj.Load(RaceIndex(Race.SelectedIndex).ObjectGUID)
                If RaceObj.Element("Monster") = "Yes" Then MonsterFlag = True
            End If

            If MonsterFlag Then
                If Gender.Text = "Male" Then
                    PropertiesTab.ImageFilename.Text = "MonsterMale.png"
                Else
                    PropertiesTab.ImageFilename.Text = "MonsterFemale.png"
                End If
            Else
                If Gender.Text = "Male" Then
                    PropertiesTab.ImageFilename.Text = "CharacterHumanMale.png"
                Else
                    PropertiesTab.ImageFilename.Text = "CharacterHumanFemale.png"
                End If
            End If
        End If

    End Sub

    'set the minimum values for the controls
    Private Sub SetMinimums()
        Try
            If STRRaceMod.Text <> "-" Then
                STR.Enabled = True
                If CInt(STRRaceMod.Text) < 0 Then STR.Properties.MinValue = 1 + Math.Abs(CInt(STRRaceMod.Text)) Else STR.Properties.MinValue = 1
            Else
                STR.Enabled = False
                STR.Value = 0
            End If

            If DEXRaceMod.Text <> "-" Then
                DEX.Enabled = True
                If CInt(DEXRaceMod.Text) < 0 Then DEX.Properties.MinValue = 1 + Math.Abs(CInt(DEXRaceMod.Text)) Else DEX.Properties.MinValue = 1
            Else
                DEX.Enabled = False
                DEX.Value = 0
            End If

            If CONRaceMod.Text <> "-" Then
                CON.Enabled = True
                If CInt(CONRaceMod.Text) < 0 Then CON.Properties.MinValue = 1 + Math.Abs(CInt(CONRaceMod.Text)) Else CON.Properties.MinValue = 1
            Else
                CON.Enabled = False
                CON.Value = 0
            End If

            If INTRaceMod.Text <> "-" Then
                INT.Enabled = True
                If CInt(INTRaceMod.Text) < 0 Then INT.Properties.MinValue = 1 + Math.Abs(CInt(INTRaceMod.Text)) Else INT.Properties.MinValue = 1
            Else
                INT.Enabled = False
                INT.Value = 0
            End If

            If CInt(WISRaceMod.Text) < 0 Then WIS.Properties.MinValue = 1 + Math.Abs(CInt(WISRaceMod.Text)) Else WIS.Properties.MinValue = 1
            If CInt(CHARaceMod.Text) < 0 Then CHA.Properties.MinValue = 1 + Math.Abs(CInt(CHARaceMod.Text)) Else CHA.Properties.MinValue = 1

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

            If PointsDisplay.Visible = True And Not HoldPointCalculate Then
                PointsDisplay.Text = CalculatePointsSpent.ToString
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle a change of race
    Private Sub Race_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Race.SelectedIndexChanged
        Dim RaceObj As New Objects.ObjectData

        Try
            RaceObj.Load(RaceIndex(Race.SelectedIndex).ObjectGUID)
            STRRaceMod.Text = Formatting.FormatModifier(RaceObj.ElementAsInteger("STRModifier"))
            CONRaceMod.Text = Formatting.FormatModifier(RaceObj.ElementAsInteger("CONModifier"))
            DEXRaceMod.Text = Formatting.FormatModifier(RaceObj.ElementAsInteger("DEXModifier"))
            INTRaceMod.Text = Formatting.FormatModifier(RaceObj.ElementAsInteger("INTModifier"))
            WISRaceMod.Text = Formatting.FormatModifier(RaceObj.ElementAsInteger("WISModifier"))
            CHARaceMod.Text = Formatting.FormatModifier(RaceObj.ElementAsInteger("CHAModifier"))
            SetMinimums()
            UpdateModifiersAndFinal()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll the dice
    Private Sub RollDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollDice.Click
        Dim Rolls(6) As Integer
        Dim Dice As Rules.Dice.DiceRange
        Dim Discard13 As Boolean = False
        Dim n, Modifiers As Integer
        Dim ReRoll As Boolean = True

        Try
            'reset the dice assignments
            Array.Clear(RollAssignment, 0, 6)
            SetRollAssignedIndicators()

            Sound.PlaySoundFile(General.BasePath & "\Sounds\DiceRoll.wav")
            While ReRoll = True
                Select Case RollMethod.Text
                    Case "4d6"
                        'Default method
                        Dice.Dice = Rules.Dice.Dice.d6
                        Dice.DiceCount = 4

                        'roll the dice
                        Rolls(0) = Rules.Dice.RollDiceRangeDiscardLowest(Dice)
                        Rolls(1) = Rules.Dice.RollDiceRangeDiscardLowest(Dice)
                        Rolls(2) = Rules.Dice.RollDiceRangeDiscardLowest(Dice)
                        Rolls(3) = Rules.Dice.RollDiceRangeDiscardLowest(Dice)
                        Rolls(4) = Rules.Dice.RollDiceRangeDiscardLowest(Dice)
                        Rolls(5) = Rules.Dice.RollDiceRangeDiscardLowest(Dice)

                    Case "5d6"
                        Dice.Dice = Rules.Dice.Dice.d6
                        Dice.DiceCount = 5

                        'roll the dice
                        Rolls(0) = Rules.Dice.RollDiceRangeDiscardLowestTwo(Dice)
                        Rolls(1) = Rules.Dice.RollDiceRangeDiscardLowestTwo(Dice)
                        Rolls(2) = Rules.Dice.RollDiceRangeDiscardLowestTwo(Dice)
                        Rolls(3) = Rules.Dice.RollDiceRangeDiscardLowestTwo(Dice)
                        Rolls(4) = Rules.Dice.RollDiceRangeDiscardLowestTwo(Dice)
                        Rolls(5) = Rules.Dice.RollDiceRangeDiscardLowestTwo(Dice)

                    Case "3d6"
                        Dice.Dice = Rules.Dice.Dice.d6
                        Dice.DiceCount = 3

                        'roll the dice
                        Rolls(0) = Rules.Dice.RollDiceRange(Dice)
                        Rolls(1) = Rules.Dice.RollDiceRange(Dice)
                        Rolls(2) = Rules.Dice.RollDiceRange(Dice)
                        Rolls(3) = Rules.Dice.RollDiceRange(Dice)
                        Rolls(4) = Rules.Dice.RollDiceRange(Dice)
                        Rolls(5) = Rules.Dice.RollDiceRange(Dice)
                End Select

                'reroll if scores too low?

                'at least one score must be above 13
                Discard13 = True
                Modifiers = 0
                For n = 0 To 5
                    If Rolls(n) > 13 Then Discard13 = False
                    Modifiers += AbilityScores.AbilityScore(Rolls(n)).Modifier
                Next

                If Discard13 Or Modifiers <= 0 Then
                    ReRoll = True
                Else
                    ReRoll = False
                End If
            End While

            Roll1.Text = Rolls(0).ToString
            Roll2.Text = Rolls(1).ToString
            Roll3.Text = Rolls(2).ToString
            Roll4.Text = Rolls(3).ToString
            Roll5.Text = Rolls(4).ToString
            Roll6.Text = Rolls(5).ToString

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'randomly generate height, weight and age
    Private Sub RollHeightWeightAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollHeightWeightAge.Click
        Dim RaceObj As New Objects.ObjectData
        Dim HeightDice, WeightDice, AgeDice As Rules.Dice.DiceRange
        Dim Height, Weight, Age, HeightRoll, WeightMultiplier As Integer
        Dim WeightIsDice As Boolean
        Dim temp As String

        Dim SkipHeight, SkipWeight As Boolean

        Try
            If Race.SelectedIndex = -1 Or Gender.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a race and gender first.")
                Exit Sub
            End If

            Sound.PlaySoundFile(General.BasePath & "\Sounds\DiceRoll.wav")
            RaceObj.Load(RaceIndex(Race.SelectedIndex).ObjectGUID)

            Select Case Gender.Text
                Case "Male"

                    Height = RaceObj.ElementAsInteger("MaleBaseHeight")
                    Try
                        HeightDice = Rules.Dice.GetDiceRange(RaceObj.Element("MaleHeightRange"))
                    Catch ex As Exception
                        General.ShowErrorDialog("No height parameters have been specified for the selected Race.")
                        SkipHeight = True
                    End Try

                    Weight = RaceObj.ElementAsInteger("MaleBaseWeight")
                    temp = RaceObj.Element("MaleWeightMultiplier")
                    If temp <> "" Then
                        If temp.IndexOf("d") <> -1 Then
                            WeightDice = Rules.Dice.GetDiceRange(temp)
                            WeightIsDice = True
                        Else
                            WeightMultiplier = CInt(temp)
                            WeightIsDice = False
                        End If
                    Else
                        General.ShowErrorDialog("No weight parameters have been specified for the selected Race.")
                        SkipWeight = True
                    End If

                Case "Female"

                    Height = RaceObj.ElementAsInteger("FemaleBaseHeight")
                    Try
                        HeightDice = Rules.Dice.GetDiceRange(RaceObj.Element("FemaleHeightRange"))
                    Catch ex As Exception
                        General.ShowErrorDialog("No height parameters have been specified for the selected Race.")
                        SkipHeight = True
                    End Try

                    Weight = RaceObj.ElementAsInteger("FemaleBaseWeight")
                    temp = RaceObj.Element("FemaleWeightMultiplier")
                    If temp <> "" Then
                        If temp.IndexOf("d") <> -1 Then
                            WeightDice = Rules.Dice.GetDiceRange(temp)
                            WeightIsDice = True
                        Else
                            WeightMultiplier = CInt(temp)
                            WeightIsDice = False
                        End If
                    Else
                        General.ShowErrorDialog("No weight parameters have been specified for the selected Race.")
                        SkipWeight = True
                    End If

            End Select

            If Not SkipHeight Then
                HeightRoll = Rules.Dice.RollDiceRange(HeightDice)
                Height = Height + HeightRoll
            End If
            CharacterHeight.Value = (Height)

            If Not SkipWeight Then
                If WeightIsDice Then
                    Weight = Weight + (HeightRoll * Rules.Dice.RollDiceRange(WeightDice))
                Else
                    Weight = Weight + (HeightRoll * WeightMultiplier)
                End If
            End If
            CharacterWeight.Value = (Weight)

            'age
            Age = RaceObj.ElementAsInteger("Adulthood")

            Dim bErr As Boolean = False
            Try
                Select Case AgeRollType.SelectedIndex
                    Case 0
                        AgeDice = Rules.Dice.GetDiceRange(RaceObj.Element("StartingAgeRangeType1"))
                    Case 1
                        AgeDice = Rules.Dice.GetDiceRange(RaceObj.Element("StartingAgeRangeType2"))
                    Case 2
                        AgeDice = Rules.Dice.GetDiceRange(RaceObj.Element("StartingAgeRangeType3"))
                End Select
            Catch ex As Exception
                'no age dice defined
                General.ShowErrorDialog("No age parameters have been specified for the selected Race.")
                bErr = True
            End Try

            If bErr = False Then Age = Age + Rules.Dice.RollDiceRange(AgeDice)

            CharacterAge.EditValue = Age

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle clicking of reset button
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Try
            Dim ResetScore As Integer

            'find the zero point score
            For ResetScore = 1 To Rules.Constants.MaxAbilityScore
                If Rules.AbilityScores.AbilityScore(ResetScore).PointCost = 0 Then
                    Exit For
                End If
            Next

            HoldPointCalculate = True
            STR.Value = ResetScore
            DEX.Value = ResetScore
            CON.Value = ResetScore
            INT.Value = ResetScore
            WIS.Value = ResetScore
            CHA.Value = ResetScore
            HoldPointCalculate = False

            PointsDisplay.Text = CalculatePointsSpent.ToString

        Catch ex As Exception
            HoldPointCalculate = False
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles RollMethod option changing
    Private Sub RollMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollMethod.SelectedIndexChanged

        Select Case RollMethod.Text

            Case "Point Buy"
                RollDice.Visible = False

                PointsLabel.Visible = True
                PointsDisplay.Visible = True
                Reset.Visible = True

                ArrayButtons(False)

                ClearRolls()
                Array.Clear(RollAssignment, 0, 6)
                SetRollAssignedIndicators()

                PointsDisplay.Text = CalculatePointsSpent.ToString

            Case "Point Array"
                RollDice.Visible = False

                PointsLabel.Visible = False
                PointsDisplay.Visible = False

                ArrayButtons(True)

                ClearRolls()
                Array.Clear(RollAssignment, 0, 6)
                SetRollAssignedIndicators()

            Case Else
                RollDice.Visible = True

                PointsLabel.Visible = False
                PointsDisplay.Visible = False
                Reset.Visible = False

                ArrayButtons(False)
        End Select

    End Sub

    'handle clicking of nonelitebutton
    Private Sub NoneliteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneliteButton.Click
        Try
            Array.Clear(RollAssignment, 0, 6)
            SetRollAssignedIndicators()
            SetRolls(13, 12, 11, 10, 9, 8)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle clicking of elitebutton
    Private Sub EliteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliteButton.Click
        Try
            Array.Clear(RollAssignment, 0, 6)
            SetRollAssignedIndicators()
            SetRolls(15, 14, 13, 12, 10, 8)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Drag and Drop"

    'function to set the background colour of each score - yellow means a roll has been assigned
    Private Sub SetRollAssignedIndicators()
        Try
            STR.BackColor = Drawing.Color.White
            DEX.BackColor = Drawing.Color.White
            CON.BackColor = Drawing.Color.White
            INT.BackColor = Drawing.Color.White
            WIS.BackColor = Drawing.Color.White
            CHA.BackColor = Drawing.Color.White

            If RollAssignment(0) > 0 Then STR.BackColor = Drawing.Color.Gold
            If RollAssignment(1) > 0 Then DEX.BackColor = Drawing.Color.Gold
            If RollAssignment(2) > 0 Then CON.BackColor = Drawing.Color.Gold
            If RollAssignment(3) > 0 Then INT.BackColor = Drawing.Color.Gold
            If RollAssignment(4) > 0 Then WIS.BackColor = Drawing.Color.Gold
            If RollAssignment(5) > 0 Then CHA.BackColor = Drawing.Color.Gold

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'either clear the roll that was just dragged or replace it with the roll it was dropped onto
    Private Sub DoRollDropped(ByVal DroppedOnto As Integer, ByVal CurrentValue As Integer)
        Dim ReplacementText As String = ""

        Try
            If RollAssignment(DroppedOnto - 1) > 0 Or RollBeingDragged > 6 Then
                ReplacementText = CurrentValue.ToString
            Else
                ReplacementText = ""
            End If

            If RollAssignment(DroppedOnto - 1) = 0 And RollBeingDragged > 6 Then RollAssignment(RollBeingDragged - 7) = 0
            RollAssignment(DroppedOnto - 1) = RollBeingDragged

            Select Case RollBeingDragged
                Case 1
                    Roll1.Text = ReplacementText
                Case 2
                    Roll2.Text = ReplacementText
                Case 3
                    Roll3.Text = ReplacementText
                Case 4
                    Roll4.Text = ReplacementText
                Case 5
                    Roll5.Text = ReplacementText
                Case 6
                    Roll6.Text = ReplacementText
                Case 7
                    STR.Text = ReplacementText
                Case 8
                    DEX.Text = ReplacementText
                Case 9
                    CON.Text = ReplacementText
                Case 10
                    INT.Text = ReplacementText
                Case 11
                    WIS.Text = ReplacementText
                Case 12
                    CHA.Text = ReplacementText
            End Select

            SetRollAssignedIndicators()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll 1 mouse down
    Private Sub Roll1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Roll1.MouseDown
        Try
            If Roll1.Text = "" Then Exit Sub
            RollBeingDragged = 1
            Roll1.DoDragDrop(Roll1.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll 2 mouse down
    Private Sub Roll2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Roll2.MouseDown
        Try
            If Roll2.Text = "" Then Exit Sub
            RollBeingDragged = 2
            Roll2.DoDragDrop(Roll2.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll 3 mouse down
    Private Sub Roll3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Roll3.MouseDown
        Try
            If Roll3.Text = "" Then Exit Sub
            RollBeingDragged = 3
            Roll3.DoDragDrop(Roll3.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll 4 mouse down
    Private Sub Roll4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Roll4.MouseDown
        Try
            If Roll4.Text = "" Then Exit Sub
            RollBeingDragged = 4
            Roll4.DoDragDrop(Roll4.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll 5 mouse down
    Private Sub Roll5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Roll5.MouseDown
        Try
            If Roll5.Text = "" Then Exit Sub
            RollBeingDragged = 5
            Roll5.DoDragDrop(Roll5.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'roll 6 mouse down
    Private Sub Roll6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Roll6.MouseDown
        Try
            If Roll6.Text = "" Then Exit Sub
            RollBeingDragged = 6
            Roll6.DoDragDrop(Roll6.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'STR drag drop
    Private Sub STR_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles STR.DragDrop
        Try
            DoRollDropped(1, CInt(STR.EditValue))
            STR.Text = e.Data.GetData(DataFormats.Text).ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'STR drag enter
    Private Sub STR_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles STR.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.Text)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'DEX drag drop
    Private Sub DEX_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DEX.DragDrop
        Try
            DoRollDropped(2, CInt(DEX.EditValue))
            DEX.Text = e.Data.GetData(DataFormats.Text).ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'DEX drag enter
    Private Sub DEX_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DEX.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.Text)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'CON drag drop
    Private Sub CON_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles CON.DragDrop
        Try
            DoRollDropped(3, CInt(CON.EditValue))
            CON.Text = e.Data.GetData(DataFormats.Text).ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'CON drag enter
    Private Sub CON_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles CON.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.Text)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'INT drag drop
    Private Sub INT_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles INT.DragDrop
        Try
            DoRollDropped(4, CInt(INT.EditValue))
            INT.Text = e.Data.GetData(DataFormats.Text).ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'INT drag enter
    Private Sub INT_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles INT.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.Text)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'WIS drag drop
    Private Sub WIS_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles WIS.DragDrop
        Try
            DoRollDropped(5, CInt(WIS.EditValue))
            WIS.Text = e.Data.GetData(DataFormats.Text).ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'WIS drag enter
    Private Sub WIS_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles WIS.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.Text)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'CHA drag drop
    Private Sub CHA_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles CHA.DragDrop
        Try
            DoRollDropped(6, CInt(CHA.EditValue))
            CHA.Text = e.Data.GetData(DataFormats.Text).ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'CHA drag enter
    Private Sub CHA_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles CHA.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.Text)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'STR mouse down
    Private Sub STR_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles STR.MouseDown
        Try
            AllowSpin = True
            RollBeingDragged = 7
            If RollAssignment(0) > 0 Then STR.DoDragDrop(STR.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'DEX mouse down
    Private Sub DEX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DEX.MouseDown
        Try
            AllowSpin = True
            RollBeingDragged = 8
            If RollAssignment(1) > 0 Then DEX.DoDragDrop(DEX.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'CON mouse down
    Private Sub CON_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CON.MouseDown
        Try
            AllowSpin = True
            RollBeingDragged = 9
            If RollAssignment(2) > 0 Then CON.DoDragDrop(CON.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'INT mouse down
    Private Sub INT_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles INT.MouseDown
        Try
            AllowSpin = True
            RollBeingDragged = 10
            If RollAssignment(3) > 0 Then INT.DoDragDrop(INT.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'WIS mouse down
    Private Sub WIS_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles WIS.MouseDown
        Try
            AllowSpin = True
            RollBeingDragged = 11
            If RollAssignment(4) > 0 Then WIS.DoDragDrop(WIS.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'CHA mouse down
    Private Sub CHA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CHA.MouseDown
        Try
            AllowSpin = True
            Debug.WriteLine("Mouse Down")
            RollBeingDragged = 12
            If RollAssignment(5) > 0 Then CHA.DoDragDrop(CHA.Text, DragDropEffects.Move)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Spin Fix"

    Private AllowSpin As Boolean

    Private Sub SpinFix(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles STR.Spin, DEX.Spin, CON.Spin, INT.Spin, WIS.Spin, CHA.Spin
        If AllowSpin Then
            AllowSpin = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

    'hides and shows the array buttons
    Private Sub ArrayButtons(ByVal Visable As Boolean)
        NoneliteButton.Visible = Visable
        EliteButton.Visible = Visable
    End Sub

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

    Private Sub ClearRolls()
        Try
            Roll1.Text = ""
            Roll2.Text = ""
            Roll3.Text = ""
            Roll4.Text = ""
            Roll5.Text = ""
            Roll6.Text = ""
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SetRolls(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer, ByVal f As Integer)
        Try
            Roll1.Text = a.ToString
            Roll2.Text = b.ToString
            Roll3.Text = c.ToString
            Roll4.Text = d.ToString
            Roll5.Text = e.ToString
            Roll6.Text = f.ToString
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class