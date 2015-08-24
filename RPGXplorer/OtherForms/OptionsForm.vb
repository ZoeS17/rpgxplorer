Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports DevExpress.Skins

Public Class OptionsForm
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
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents CommandLine As DevExpress.XtraEditors.TextEdit
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents ChooseFile As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents CoinWeight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Prices As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents LookAndFeel As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents ShowSourcebook As System.Windows.Forms.CheckBox
    Public WithEvents ShowPageNo As System.Windows.Forms.CheckBox
    Public WithEvents ShowLicense As System.Windows.Forms.CheckBox
    Public WithEvents ShowTags As System.Windows.Forms.CheckBox
    Public WithEvents CharSheetTab As System.Windows.Forms.TabPage
    Public WithEvents InventoryBlanks As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents AssetBlanks As DevExpress.XtraEditors.SpinEdit
    Public WithEvents StartupCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Autosave As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Undo As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents IndentedLine6 As RPGXplorer.IndentedLine
    Public WithEvents DefaultWeaponsCheck As System.Windows.Forms.CheckBox
    Public WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.Label20 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Undo = New DevExpress.XtraEditors.SpinEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Autosave = New DevExpress.XtraEditors.SpinEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.StartupCheck = New System.Windows.Forms.CheckBox
        Me.ShowTags = New System.Windows.Forms.CheckBox
        Me.ShowLicense = New System.Windows.Forms.CheckBox
        Me.ShowPageNo = New System.Windows.Forms.CheckBox
        Me.ShowSourcebook = New System.Windows.Forms.CheckBox
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.Label4 = New System.Windows.Forms.Label
        Me.LookAndFeel = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Prices = New DevExpress.XtraEditors.SpinEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CoinWeight = New DevExpress.XtraEditors.SpinEdit
        Me.ChooseFile = New System.Windows.Forms.Button
        Me.CommandLine = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label1 = New System.Windows.Forms.Label
        Me.CharSheetTab = New System.Windows.Forms.TabPage
        Me.AssetBlanks = New DevExpress.XtraEditors.SpinEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.InventoryBlanks = New DevExpress.XtraEditors.SpinEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.DefaultWeaponsCheck = New System.Windows.Forms.CheckBox
        Me.IndentedLine6 = New RPGXplorer.IndentedLine
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Undo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Autosave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookAndFeel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prices.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoinWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CharSheetTab.SuspendLayout()
        CType(Me.AssetBlanks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBlanks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 640)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(280, 640)
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
        Me.TabControl1.Controls.Add(Me.Basics)
        Me.TabControl1.Controls.Add(Me.CharSheetTab)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 610)
        Me.TabControl1.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.IndentedLine6)
        Me.Basics.Controls.Add(Me.DefaultWeaponsCheck)
        Me.Basics.Controls.Add(Me.Label11)
        Me.Basics.Controls.Add(Me.PictureBox2)
        Me.Basics.Controls.Add(Me.IndentedLine5)
        Me.Basics.Controls.Add(Me.Label20)
        Me.Basics.Controls.Add(Me.PictureBox1)
        Me.Basics.Controls.Add(Me.Undo)
        Me.Basics.Controls.Add(Me.Label9)
        Me.Basics.Controls.Add(Me.Autosave)
        Me.Basics.Controls.Add(Me.Label8)
        Me.Basics.Controls.Add(Me.Label7)
        Me.Basics.Controls.Add(Me.IndentedLine4)
        Me.Basics.Controls.Add(Me.StartupCheck)
        Me.Basics.Controls.Add(Me.ShowTags)
        Me.Basics.Controls.Add(Me.ShowLicense)
        Me.Basics.Controls.Add(Me.ShowPageNo)
        Me.Basics.Controls.Add(Me.ShowSourcebook)
        Me.Basics.Controls.Add(Me.IndentedLine3)
        Me.Basics.Controls.Add(Me.Label4)
        Me.Basics.Controls.Add(Me.LookAndFeel)
        Me.Basics.Controls.Add(Me.IndentedLine2)
        Me.Basics.Controls.Add(Me.Prices)
        Me.Basics.Controls.Add(Me.Label3)
        Me.Basics.Controls.Add(Me.CoinWeight)
        Me.Basics.Controls.Add(Me.ChooseFile)
        Me.Basics.Controls.Add(Me.CommandLine)
        Me.Basics.Controls.Add(Me.Label2)
        Me.Basics.Controls.Add(Me.IndentedLine1)
        Me.Basics.Controls.Add(Me.Label1)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 584)
        Me.Basics.TabIndex = 2
        Me.Basics.Text = "Options"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(350, 40)
        Me.Label11.TabIndex = 317
        Me.Label11.Text = "When set to 0, the database will only be saved when the application is closed, or" & _
            " when explicitly done so via the save command on the File menu."
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = Global.RPGXplorer.My.Resources.Resources.warning1
        Me.PictureBox2.Location = New System.Drawing.Point(13, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.TabIndex = 315
        Me.PictureBox2.TabStop = False
        '
        'IndentedLine5
        '
        Me.IndentedLine5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine5.Location = New System.Drawing.Point(16, 85)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 314
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(45, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(350, 30)
        Me.Label20.TabIndex = 313
        Me.Label20.Text = "Systems with 512Mb or less shoud set the Undo Steps to 0. This will increase perf" & _
            "ormance, but the undo function will not be available."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RPGXplorer.My.Resources.Resources.warning1
        Me.PictureBox1.Location = New System.Drawing.Point(15, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox1.TabIndex = 311
        Me.PictureBox1.TabStop = False
        '
        'Undo
        '
        Me.Undo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Undo.Location = New System.Drawing.Point(135, 15)
        Me.Undo.Name = "Undo"
        Me.Undo.Properties.Appearance.Options.UseTextOptions = True
        Me.Undo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Undo.Properties.AutoHeight = False
        Me.Undo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Undo.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Undo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Undo.Size = New System.Drawing.Size(55, 21)
        Me.Undo.TabIndex = 124
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(180, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 21)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "minutes"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Autosave
        '
        Me.Autosave.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Autosave.Location = New System.Drawing.Point(120, 100)
        Me.Autosave.Name = "Autosave"
        Me.Autosave.Properties.Appearance.Options.UseTextOptions = True
        Me.Autosave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Autosave.Properties.AutoHeight = False
        Me.Autosave.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Autosave.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.Autosave.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Autosave.Size = New System.Drawing.Size(55, 21)
        Me.Autosave.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 21)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Autosave Interval  ="
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 21)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Undo Steps Cached  ="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine4.Location = New System.Drawing.Point(15, 180)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 118
        '
        'StartupCheck
        '
        Me.StartupCheck.Location = New System.Drawing.Point(14, 275)
        Me.StartupCheck.Name = "StartupCheck"
        Me.StartupCheck.Size = New System.Drawing.Size(245, 24)
        Me.StartupCheck.TabIndex = 117
        Me.StartupCheck.Text = "Show news on startup"
        '
        'ShowTags
        '
        Me.ShowTags.Location = New System.Drawing.Point(14, 545)
        Me.ShowTags.Name = "ShowTags"
        Me.ShowTags.Size = New System.Drawing.Size(245, 24)
        Me.ShowTags.TabIndex = 116
        Me.ShowTags.Text = "Show Tags Column"
        '
        'ShowLicense
        '
        Me.ShowLicense.Location = New System.Drawing.Point(14, 515)
        Me.ShowLicense.Name = "ShowLicense"
        Me.ShowLicense.Size = New System.Drawing.Size(245, 24)
        Me.ShowLicense.TabIndex = 115
        Me.ShowLicense.Text = "Show License Column"
        '
        'ShowPageNo
        '
        Me.ShowPageNo.Location = New System.Drawing.Point(14, 485)
        Me.ShowPageNo.Name = "ShowPageNo"
        Me.ShowPageNo.Size = New System.Drawing.Size(245, 24)
        Me.ShowPageNo.TabIndex = 114
        Me.ShowPageNo.Text = "Show Page No. Column"
        '
        'ShowSourcebook
        '
        Me.ShowSourcebook.Location = New System.Drawing.Point(14, 455)
        Me.ShowSourcebook.Name = "ShowSourcebook"
        Me.ShowSourcebook.Size = New System.Drawing.Size(245, 24)
        Me.ShowSourcebook.TabIndex = 113
        Me.ShowSourcebook.Text = "Show Sourcebook Column"
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine3.Location = New System.Drawing.Point(14, 440)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(14, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Look and Feel"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookAndFeel
        '
        Me.LookAndFeel.EditValue = ""
        Me.LookAndFeel.Location = New System.Drawing.Point(164, 405)
        Me.LookAndFeel.Name = "LookAndFeel"
        Me.LookAndFeel.Properties.AutoHeight = False
        Me.LookAndFeel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookAndFeel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.LookAndFeel.Size = New System.Drawing.Size(150, 21)
        Me.LookAndFeel.TabIndex = 110
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(14, 390)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 109
        '
        'Prices
        '
        Me.Prices.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Prices.Location = New System.Drawing.Point(164, 355)
        Me.Prices.Name = "Prices"
        Me.Prices.Properties.Appearance.Options.UseTextOptions = True
        Me.Prices.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Prices.Properties.AutoHeight = False
        Me.Prices.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Prices.Properties.IsFloatValue = False
        Me.Prices.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Prices.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Prices.Properties.MinValue = New Decimal(New Integer() {99, 0, 0, -2147483648})
        Me.Prices.Size = New System.Drawing.Size(75, 21)
        Me.Prices.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(14, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Marketplace Prices (+/-)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CoinWeight
        '
        Me.CoinWeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CoinWeight.Location = New System.Drawing.Point(164, 325)
        Me.CoinWeight.Name = "CoinWeight"
        Me.CoinWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.CoinWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CoinWeight.Properties.AutoHeight = False
        Me.CoinWeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CoinWeight.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.CoinWeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CoinWeight.Size = New System.Drawing.Size(75, 21)
        Me.CoinWeight.TabIndex = 106
        '
        'ChooseFile
        '
        Me.ChooseFile.Location = New System.Drawing.Point(369, 245)
        Me.ChooseFile.Name = "ChooseFile"
        Me.ChooseFile.Size = New System.Drawing.Size(23, 21)
        Me.ChooseFile.TabIndex = 1
        Me.ChooseFile.Text = "..."
        '
        'CommandLine
        '
        Me.CommandLine.Location = New System.Drawing.Point(164, 245)
        Me.CommandLine.Name = "CommandLine"
        Me.CommandLine.Properties.AutoHeight = False
        Me.CommandLine.Properties.MaxLength = 50
        Me.CommandLine.Size = New System.Drawing.Size(200, 21)
        Me.CommandLine.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(14, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 21)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "HTML Editor Command Line"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(14, 310)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(14, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 21)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Coin Weight - 100 coins = "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CharSheetTab
        '
        Me.CharSheetTab.Controls.Add(Me.AssetBlanks)
        Me.CharSheetTab.Controls.Add(Me.Label6)
        Me.CharSheetTab.Controls.Add(Me.InventoryBlanks)
        Me.CharSheetTab.Controls.Add(Me.Label5)
        Me.CharSheetTab.Location = New System.Drawing.Point(4, 22)
        Me.CharSheetTab.Name = "CharSheetTab"
        Me.CharSheetTab.Size = New System.Drawing.Size(407, 534)
        Me.CharSheetTab.TabIndex = 3
        Me.CharSheetTab.Text = "Character Sheet"
        '
        'AssetBlanks
        '
        Me.AssetBlanks.CausesValidation = False
        Me.AssetBlanks.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AssetBlanks.Location = New System.Drawing.Point(165, 45)
        Me.AssetBlanks.Name = "AssetBlanks"
        Me.AssetBlanks.Properties.Appearance.Options.UseTextOptions = True
        Me.AssetBlanks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AssetBlanks.Properties.AutoHeight = False
        Me.AssetBlanks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.AssetBlanks.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.AssetBlanks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AssetBlanks.Size = New System.Drawing.Size(75, 21)
        Me.AssetBlanks.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Blank Asset Lines"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InventoryBlanks
        '
        Me.InventoryBlanks.CausesValidation = False
        Me.InventoryBlanks.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.InventoryBlanks.Location = New System.Drawing.Point(165, 15)
        Me.InventoryBlanks.Name = "InventoryBlanks"
        Me.InventoryBlanks.Properties.Appearance.Options.UseTextOptions = True
        Me.InventoryBlanks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.InventoryBlanks.Properties.AutoHeight = False
        Me.InventoryBlanks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.InventoryBlanks.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.InventoryBlanks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.InventoryBlanks.Size = New System.Drawing.Size(75, 21)
        Me.InventoryBlanks.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 21)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Blank Inventory Lines"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DefaultWeaponsCheck
        '
        Me.DefaultWeaponsCheck.Location = New System.Drawing.Point(15, 195)
        Me.DefaultWeaponsCheck.Name = "DefaultWeaponsCheck"
        Me.DefaultWeaponsCheck.Size = New System.Drawing.Size(340, 24)
        Me.DefaultWeaponsCheck.TabIndex = 318
        Me.DefaultWeaponsCheck.Text = "Allow setting of racial default weapon configurations"
        '
        'IndentedLine6
        '
        Me.IndentedLine6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine6.Location = New System.Drawing.Point(15, 230)
        Me.IndentedLine6.Name = "IndentedLine6"
        Me.IndentedLine6.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine6.TabIndex = 319
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 678)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Undo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Autosave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookAndFeel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prices.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoinWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CharSheetTab.ResumeLayout(False)
        CType(Me.AssetBlanks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBlanks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'init
    Public Sub Init()
        Try
            'initialise controls
            Undo.Value = General.Config.ElementAsInteger("UndoSteps")
            Autosave.Value = General.Config.ElementAsInteger("AutosaveInterval")
            CommandLine.Text = General.Config.Element("HTMLEditorCommandLine")
            CoinWeight.EditValue = General.Config.Element("CoinWeight")
            Prices.EditValue = General.Config.Element("MarketPrices")

            'look and feel
            LookAndFeel.Properties.Items.Add("Flat")
            LookAndFeel.Properties.Items.Add("UltraFlat")
            LookAndFeel.Properties.Items.Add("Office2003")

            For Each Skin As SkinContainer In SkinManager.Default.Skins
                LookAndFeel.Properties.Items.Add(Skin.SkinName)
            Next

            If General.Config.Element("LookAndFeel") = "" Then
                LookAndFeel.Text = "Caramel"
            Else
                LookAndFeel.Text = General.Config.Element("LookAndFeel")
            End If

            If General.Config.Element("DefaultWeapons") = "Yes" Then DefaultWeaponsCheck.Checked = True
            If General.Config.Element("ShowSourcebook") = "Yes" Then ShowSourcebook.Checked = True
            If General.Config.Element("ShowPageNo") = "Yes" Then ShowPageNo.Checked = True
            If General.Config.Element("ShowLicense") = "Yes" Then ShowLicense.Checked = True
            If General.Config.Element("ShowTags") = "Yes" Then ShowTags.Checked = True
            If General.Config.Element("NewsOnStartup") = "True" Then StartupCheck.Checked = True

            'formatting
            CoinWeight.Properties.DisplayFormat.Format = New Rules.WeightFormatter
            CoinWeight.Properties.EditFormat.Format = New Rules.WeightFormatter
            Prices.Properties.DisplayFormat.Format = New Rules.MarketPricesFormatter
            Prices.Properties.EditFormat.Format = New Rules.MarketPricesFormatter

            'char sheet
            InventoryBlanks.EditValue = General.Config.ElementAsInteger("InventoryBlanks")
            AssetBlanks.EditValue = General.Config.ElementAsInteger("AssetsBlanks")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            General.MainExplorer.Undo.UndoRecord()

            'have we changed the undo size?
            Config.ElementAsInteger("UndoSteps") = CInt(Undo.Value)
            If General.UndoSteps <> CInt(Undo.Value) Then
                General.UndoSteps = CInt(Undo.Value)
                General.MainExplorer.Undo.NewUndoStack(CInt(Undo.Value))
            End If

            'have we changed the autosave
            Config.ElementAsInteger("AutosaveInterval") = CInt(Autosave.Value)
            If General.AutosaveInterval <> CInt(Autosave.Value) Then
                General.AutosaveInterval = CInt(Autosave.Value)
                If General.AutosaveInterval = 0 Then
                    General.MainExplorer.Form.Timer1.Enabled = False
                Else
                    General.MainExplorer.Form.Timer1.Interval = (60000 * General.AutosaveInterval)
                End If
            End If

            Config.Element("HTMLEditorCommandLine") = CommandLine.Text

            Config.Element("CoinWeight") = CoinWeight.EditValue.ToString
            General.CoinWeight = CType(CoinWeight.EditValue, Double)

            Config.Element("MarketPrices") = Prices.EditValue.ToString
            General.MarketPrices = CType(Prices.EditValue, Integer)

            ToolbarsAndMenus.MarketPricesEdit.EditValue = Prices.EditValue

            General.Config.Element("LookAndFeel") = LookAndFeel.Text

            If DefaultWeaponsCheck.Checked Then General.Config.Element("DefaultWeapons") = "Yes" Else General.Config.Element("DefaultWeapons") = ""
            If ShowSourcebook.Checked Then General.Config.Element("ShowSourcebook") = "Yes" Else General.Config.Element("ShowSourcebook") = ""
            If ShowPageNo.Checked Then General.Config.Element("ShowPageNo") = "Yes" Else General.Config.Element("ShowPageNo") = ""
            If ShowLicense.Checked Then General.Config.Element("ShowLicense") = "Yes" Else General.Config.Element("ShowLicense") = ""
            If ShowTags.Checked Then General.Config.Element("ShowTags") = "Yes" Else General.Config.Element("ShowTags") = ""
            If StartupCheck.Checked Then General.Config.Element("NewsOnStartup") = "True" Else General.Config.Element("NewsOnStartup") = "False"

            General.Config.Element("InventoryBlanks") = InventoryBlanks.EditValue.ToString
            General.Config.Element("AssetsBlanks") = AssetBlanks.EditValue.ToString

            'recalc all coin weights
            Dim MoneyObjs As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.Characters, Objects.MoneyType)
            MoneyObjs.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.Monsters, Objects.MoneyType))

            Dim Money As Money

            For Each MoneyObj As Objects.ObjectData In MoneyObjs
                Money = New Money(MoneyObj.Name)
                MoneyObj.Element("Weight") = Rules.Formatting.FormatPounds(Money.Weight)
                MoneyObj.Save()
            Next

            'set all inventory and asset panels to dirty
            ToolbarsAndMenus.InitConfig()
            WindowManager.SetAllDirty()
            General.MainExplorer.RefreshPanel()
            'General.MainExplorer.Refresh()
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If LookAndFeel.Text <> General.Config.Element("LookAndFeel") Then UI.SetLookAndFeel(General.Config.Element("LookAndFeel"))
        Me.Close()
    End Sub

    'choose file
    Private Sub ChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseFile.Click
        Try
            OpenFileDialog1.InitialDirectory = """C\:Program Files"""
            If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                CommandLine.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'change look and feel
    Private Sub LookAndFeel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookAndFeel.SelectedIndexChanged
        Try
            UI.SetLookAndFeel(LookAndFeel.Text)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class