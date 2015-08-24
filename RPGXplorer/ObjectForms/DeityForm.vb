Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class DeityForm
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
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents DeityTab As System.Windows.Forms.TabPage
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents NameLabel As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents TargetLabel As System.Windows.Forms.Label
    Public WithEvents DomainBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AddButton As System.Windows.Forms.Button
    Public WithEvents RemoveButton As System.Windows.Forms.Button
    Public WithEvents ChaoticEvil As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticNeutral As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticGood As System.Windows.Forms.CheckBox
    Public WithEvents NeutralEvil As System.Windows.Forms.CheckBox
    Public WithEvents TrueNeutral As System.Windows.Forms.CheckBox
    Public WithEvents NeutralGood As System.Windows.Forms.CheckBox
    Public WithEvents LawfulEvil As System.Windows.Forms.CheckBox
    Public WithEvents LawfulNeutral As System.Windows.Forms.CheckBox
    Public WithEvents LawfulGood As System.Windows.Forms.CheckBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents DomainList As RPGXplorer.ListBox
    Public WithEvents AlignmentDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents FavoredWeapon As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents PsionicList As RPGXplorer.ListBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents PsionicBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AddPsionic As System.Windows.Forms.Button
    Public WithEvents RemovePsionic As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.DeityTab = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.FavoredWeapon = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label8 = New System.Windows.Forms.Label
        Me.AlignmentDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChaoticEvil = New System.Windows.Forms.CheckBox
        Me.ChaoticNeutral = New System.Windows.Forms.CheckBox
        Me.ChaoticGood = New System.Windows.Forms.CheckBox
        Me.NeutralEvil = New System.Windows.Forms.CheckBox
        Me.TrueNeutral = New System.Windows.Forms.CheckBox
        Me.NeutralGood = New System.Windows.Forms.CheckBox
        Me.LawfulEvil = New System.Windows.Forms.CheckBox
        Me.LawfulNeutral = New System.Windows.Forms.CheckBox
        Me.LawfulGood = New System.Windows.Forms.CheckBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.DomainList = New RPGXplorer.ListBox
        Me.TargetLabel = New System.Windows.Forms.Label
        Me.DomainBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.AddButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.PsionicList = New RPGXplorer.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PsionicBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.AddPsionic = New System.Windows.Forms.Button
        Me.RemovePsionic = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.DeityTab.SuspendLayout()
        CType(Me.FavoredWeapon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlignmentDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DomainBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PsionicBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.DeityTab)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'DeityTab
        '
        Me.DeityTab.Controls.Add(Me.Label2)
        Me.DeityTab.Controls.Add(Me.FavoredWeapon)
        Me.DeityTab.Controls.Add(Me.IndentedLine2)
        Me.DeityTab.Controls.Add(Me.Label8)
        Me.DeityTab.Controls.Add(Me.AlignmentDropdown)
        Me.DeityTab.Controls.Add(Me.Label1)
        Me.DeityTab.Controls.Add(Me.ChaoticEvil)
        Me.DeityTab.Controls.Add(Me.ChaoticNeutral)
        Me.DeityTab.Controls.Add(Me.ChaoticGood)
        Me.DeityTab.Controls.Add(Me.NeutralEvil)
        Me.DeityTab.Controls.Add(Me.TrueNeutral)
        Me.DeityTab.Controls.Add(Me.NeutralGood)
        Me.DeityTab.Controls.Add(Me.LawfulEvil)
        Me.DeityTab.Controls.Add(Me.LawfulNeutral)
        Me.DeityTab.Controls.Add(Me.LawfulGood)
        Me.DeityTab.Controls.Add(Me.IndentedLine1)
        Me.DeityTab.Controls.Add(Me.Description)
        Me.DeityTab.Controls.Add(Me.Label21)
        Me.DeityTab.Controls.Add(Me.ObjectName)
        Me.DeityTab.Controls.Add(Me.NameLabel)
        Me.DeityTab.Controls.Add(Me.IndentedLine4)
        Me.DeityTab.Location = New System.Drawing.Point(4, 22)
        Me.DeityTab.Name = "DeityTab"
        Me.DeityTab.Size = New System.Drawing.Size(407, 349)
        Me.DeityTab.TabIndex = 0
        Me.DeityTab.Text = "Deity"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(10, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Favored Weapon"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FavoredWeapon
        '
        Me.FavoredWeapon.CausesValidation = False
        Me.FavoredWeapon.Location = New System.Drawing.Point(110, 310)
        Me.FavoredWeapon.Name = "FavoredWeapon"
        Me.FavoredWeapon.Properties.AutoHeight = False
        Me.FavoredWeapon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FavoredWeapon.Properties.DropDownRows = 10
        Me.FavoredWeapon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FavoredWeapon.Size = New System.Drawing.Size(150, 21)
        Me.FavoredWeapon.TabIndex = 12
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 155)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 204
        Me.IndentedLine2.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 21)
        Me.Label8.TabIndex = 203
        Me.Label8.Text = "Alignment"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlignmentDropdown
        '
        Me.AlignmentDropdown.Location = New System.Drawing.Point(85, 120)
        Me.AlignmentDropdown.Name = "AlignmentDropdown"
        Me.AlignmentDropdown.Properties.AutoHeight = False
        Me.AlignmentDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AlignmentDropdown.Properties.DropDownRows = 10
        Me.AlignmentDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AlignmentDropdown.Size = New System.Drawing.Size(150, 21)
        Me.AlignmentDropdown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Allowed Cleric Alignments"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChaoticEvil
        '
        Me.ChaoticEvil.CausesValidation = False
        Me.ChaoticEvil.Checked = True
        Me.ChaoticEvil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChaoticEvil.Location = New System.Drawing.Point(225, 260)
        Me.ChaoticEvil.Name = "ChaoticEvil"
        Me.ChaoticEvil.Size = New System.Drawing.Size(100, 21)
        Me.ChaoticEvil.TabIndex = 11
        Me.ChaoticEvil.Text = "Chaotic Evil"
        '
        'ChaoticNeutral
        '
        Me.ChaoticNeutral.CausesValidation = False
        Me.ChaoticNeutral.Checked = True
        Me.ChaoticNeutral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChaoticNeutral.Location = New System.Drawing.Point(115, 260)
        Me.ChaoticNeutral.Name = "ChaoticNeutral"
        Me.ChaoticNeutral.Size = New System.Drawing.Size(105, 21)
        Me.ChaoticNeutral.TabIndex = 10
        Me.ChaoticNeutral.Text = "Chaotic Neutral"
        '
        'ChaoticGood
        '
        Me.ChaoticGood.CausesValidation = False
        Me.ChaoticGood.Checked = True
        Me.ChaoticGood.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChaoticGood.Location = New System.Drawing.Point(15, 260)
        Me.ChaoticGood.Name = "ChaoticGood"
        Me.ChaoticGood.Size = New System.Drawing.Size(95, 21)
        Me.ChaoticGood.TabIndex = 9
        Me.ChaoticGood.Text = "Chaotic Good"
        '
        'NeutralEvil
        '
        Me.NeutralEvil.CausesValidation = False
        Me.NeutralEvil.Checked = True
        Me.NeutralEvil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NeutralEvil.Location = New System.Drawing.Point(225, 230)
        Me.NeutralEvil.Name = "NeutralEvil"
        Me.NeutralEvil.Size = New System.Drawing.Size(100, 21)
        Me.NeutralEvil.TabIndex = 8
        Me.NeutralEvil.Text = "Neutral Evil"
        '
        'TrueNeutral
        '
        Me.TrueNeutral.CausesValidation = False
        Me.TrueNeutral.Checked = True
        Me.TrueNeutral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TrueNeutral.Location = New System.Drawing.Point(115, 230)
        Me.TrueNeutral.Name = "TrueNeutral"
        Me.TrueNeutral.Size = New System.Drawing.Size(100, 21)
        Me.TrueNeutral.TabIndex = 7
        Me.TrueNeutral.Text = "True Neutral"
        '
        'NeutralGood
        '
        Me.NeutralGood.CausesValidation = False
        Me.NeutralGood.Checked = True
        Me.NeutralGood.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NeutralGood.Location = New System.Drawing.Point(15, 230)
        Me.NeutralGood.Name = "NeutralGood"
        Me.NeutralGood.Size = New System.Drawing.Size(90, 21)
        Me.NeutralGood.TabIndex = 6
        Me.NeutralGood.Text = "Neutral Good"
        '
        'LawfulEvil
        '
        Me.LawfulEvil.CausesValidation = False
        Me.LawfulEvil.Checked = True
        Me.LawfulEvil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LawfulEvil.Location = New System.Drawing.Point(225, 200)
        Me.LawfulEvil.Name = "LawfulEvil"
        Me.LawfulEvil.Size = New System.Drawing.Size(100, 21)
        Me.LawfulEvil.TabIndex = 5
        Me.LawfulEvil.Text = "Lawful Evil"
        '
        'LawfulNeutral
        '
        Me.LawfulNeutral.CausesValidation = False
        Me.LawfulNeutral.Checked = True
        Me.LawfulNeutral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LawfulNeutral.Location = New System.Drawing.Point(115, 200)
        Me.LawfulNeutral.Name = "LawfulNeutral"
        Me.LawfulNeutral.Size = New System.Drawing.Size(100, 21)
        Me.LawfulNeutral.TabIndex = 4
        Me.LawfulNeutral.Text = "Lawful Neutral"
        '
        'LawfulGood
        '
        Me.LawfulGood.CausesValidation = False
        Me.LawfulGood.Checked = True
        Me.LawfulGood.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LawfulGood.Location = New System.Drawing.Point(15, 200)
        Me.LawfulGood.Name = "LawfulGood"
        Me.LawfulGood.Size = New System.Drawing.Size(90, 21)
        Me.LawfulGood.TabIndex = 3
        Me.LawfulGood.Text = "Lawful Good"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(16, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 187
        Me.IndentedLine1.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(304, 46)
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 186
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(85, 15)
        Me.ObjectName.Name = "ObjectName"
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.NameLabel.Location = New System.Drawing.Point(15, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 21)
        Me.NameLabel.TabIndex = 185
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Location = New System.Drawing.Point(10, 295)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 204
        Me.IndentedLine4.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.IndentedLine3)
        Me.TabPage2.Controls.Add(Me.DomainList)
        Me.TabPage2.Controls.Add(Me.TargetLabel)
        Me.TabPage2.Controls.Add(Me.DomainBox)
        Me.TabPage2.Controls.Add(Me.AddButton)
        Me.TabPage2.Controls.Add(Me.RemoveButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(407, 349)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Domains"
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(16, 50)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 207
        Me.IndentedLine3.TabStop = False
        '
        'DomainList
        '
        Me.DomainList.Location = New System.Drawing.Point(15, 65)
        Me.DomainList.Name = "DomainList"
        Me.DomainList.Size = New System.Drawing.Size(240, 270)
        Me.DomainList.TabIndex = 203
        '
        'TargetLabel
        '
        Me.TargetLabel.Location = New System.Drawing.Point(15, 15)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(45, 21)
        Me.TargetLabel.TabIndex = 206
        Me.TargetLabel.Text = "Domain"
        Me.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DomainBox
        '
        Me.DomainBox.CausesValidation = False
        Me.DomainBox.Location = New System.Drawing.Point(65, 15)
        Me.DomainBox.Name = "DomainBox"
        Me.DomainBox.Properties.AutoHeight = False
        Me.DomainBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DomainBox.Properties.DropDownRows = 10
        Me.DomainBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DomainBox.Size = New System.Drawing.Size(150, 21)
        Me.DomainBox.TabIndex = 202
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(270, 65)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 24)
        Me.AddButton.TabIndex = 204
        Me.AddButton.Text = "Add Domain"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(270, 95)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(100, 24)
        Me.RemoveButton.TabIndex = 205
        Me.RemoveButton.Text = "Remove Domain"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.IndentedLine5)
        Me.TabPage3.Controls.Add(Me.PsionicList)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.PsionicBox)
        Me.TabPage3.Controls.Add(Me.AddPsionic)
        Me.TabPage3.Controls.Add(Me.RemovePsionic)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(407, 349)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Psionic Specializations"
        '
        'IndentedLine5
        '
        Me.IndentedLine5.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 213
        Me.IndentedLine5.TabStop = False
        '
        'PsionicList
        '
        Me.PsionicList.Location = New System.Drawing.Point(15, 65)
        Me.PsionicList.Name = "PsionicList"
        Me.PsionicList.Size = New System.Drawing.Size(240, 270)
        Me.PsionicList.TabIndex = 209
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "Specialization"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PsionicBox
        '
        Me.PsionicBox.CausesValidation = False
        Me.PsionicBox.Location = New System.Drawing.Point(100, 15)
        Me.PsionicBox.Name = "PsionicBox"
        Me.PsionicBox.Properties.AutoHeight = False
        Me.PsionicBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PsionicBox.Properties.DropDownRows = 10
        Me.PsionicBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PsionicBox.Size = New System.Drawing.Size(150, 21)
        Me.PsionicBox.TabIndex = 208
        '
        'AddPsionic
        '
        Me.AddPsionic.Location = New System.Drawing.Point(270, 65)
        Me.AddPsionic.Name = "AddPsionic"
        Me.AddPsionic.Size = New System.Drawing.Size(130, 24)
        Me.AddPsionic.TabIndex = 210
        Me.AddPsionic.Text = "Add Specialization"
        '
        'RemovePsionic
        '
        Me.RemovePsionic.Location = New System.Drawing.Point(270, 95)
        Me.RemovePsionic.Name = "RemovePsionic"
        Me.RemovePsionic.Size = New System.Drawing.Size(130, 24)
        Me.RemovePsionic.TabIndex = 211
        Me.RemovePsionic.Text = "Remove Specialization"
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
        'DeityForm
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
        Me.MinimizeBox = False
        Me.Name = "DeityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeityForm"
        Me.TabControl1.ResumeLayout(False)
        Me.DeityTab.ResumeLayout(False)
        CType(Me.FavoredWeapon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlignmentDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DomainBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PsionicBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private DomainsDatalist As DataListItem()
    Private SpecializationsDatalist As DataListItem()
    Private WeaponsList As DataListItem()

    Private ExistingDomains As New Objects.ObjectDataCollection
    Private CurrentDomains As New Objects.ObjectDataCollection

    Private ExistingSpecializations As New Objects.ObjectDataCollection
    Private CurrentSpecializations As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try
            'initialise controls
            DomainsDatalist = Rules.Index.DataList(XML.DBTypes.Domains, Objects.DomainDefinitionType)
            SpecializationsDatalist = Rules.Index.DataList(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType)
            WeaponsList = Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='']", True)

            AlignmentDropdown.Properties.Items.AddRange(Rules.Lists.AlignmentTypes)
            FavoredWeapon.Properties.Items.AddRange(WeaponsList)
            DomainBox.Properties.Items.AddRange(DomainsDatalist)
            PsionicBox.Properties.Items.AddRange(SpecializationsDatalist)

            'init Properties Tab
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Deities)
            mObject.Type = Objects.DeityDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Deity Definition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim child As Objects.ObjectData

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            ObjectName.Text = mObject.Name
            Description.Text = mObject.Element("Description")
            AlignmentDropdown.Text = mObject.Element("Alignment")
            FavoredWeapon.SelectedIndex = Rules.Index.GetGuidIndex(WeaponsList, mObject.GetFKGuid("FavoredWeapon"))

            'allowed cleric alignments
            If Obj.Element("LawfulGood") = "True" Then LawfulGood.CheckState = CheckState.Checked Else LawfulGood.Checked = False
            If Obj.Element("NeutralGood") = "True" Then NeutralGood.CheckState = CheckState.Checked Else NeutralGood.Checked = False
            If Obj.Element("ChaoticGood") = "True" Then ChaoticGood.CheckState = CheckState.Checked Else ChaoticGood.Checked = False
            If Obj.Element("LawfulNeutral") = "True" Then LawfulNeutral.CheckState = CheckState.Checked Else LawfulNeutral.Checked = False
            If Obj.Element("TrueNeutral") = "True" Then TrueNeutral.CheckState = CheckState.Checked Else TrueNeutral.Checked = False
            If Obj.Element("ChaoticNeutral") = "True" Then ChaoticNeutral.CheckState = CheckState.Checked Else ChaoticNeutral.Checked = False
            If Obj.Element("LawfulEvil") = "True" Then LawfulEvil.CheckState = CheckState.Checked Else LawfulEvil.Checked = False
            If Obj.Element("NeutralEvil") = "True" Then NeutralEvil.CheckState = CheckState.Checked Else NeutralEvil.Checked = False
            If Obj.Element("ChaoticEvil") = "True" Then ChaoticEvil.CheckState = CheckState.Checked Else ChaoticEvil.Checked = False

            ExistingDomains = mObject.ChildrenOfType(Objects.DeityDomainChildType)
            For Each child In ExistingDomains
                CurrentDomains.Add(child)
                DomainList.AddItem(child.Name, child.ObjectGUID)
            Next

            ExistingSpecializations = mObject.ChildrenOfType(Objects.DeityPsionicSpecializationChildType)
            For Each child In ExistingSpecializations
                CurrentSpecializations.Add(child)
                PsionicList.AddItem(child.Name, child.ObjectGUID)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim obj As Objects.ObjectData
        Dim domainstring As String = ""
        Dim psionicstring As String = ""

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        'do nothing yet
                        'TODO - Remove
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("Description") = Description.Text
                mObject.Element("Alignment") = AlignmentDropdown.Text
                If FavoredWeapon.SelectedIndex > 0 Then mObject.FKElement("FavoredWeapon", FavoredWeapon.Text, "Name", CType(FavoredWeapon.SelectedItem, DataListItem).ObjectGUID) Else mObject.FKSetNull("FavoredWeapon")

                'allowed cleric alignments
                If LawfulGood.CheckState = CheckState.Checked Then mObject.Element("LawfulGood") = "True" Else mObject.Element("LawfulGood") = "False"
                If NeutralGood.CheckState = CheckState.Checked Then mObject.Element("NeutralGood") = "True" Else mObject.Element("NeutralGood") = "False"
                If ChaoticGood.CheckState = CheckState.Checked Then mObject.Element("ChaoticGood") = "True" Else mObject.Element("ChaoticGood") = "False"
                If LawfulNeutral.CheckState = CheckState.Checked Then mObject.Element("LawfulNeutral") = "True" Else mObject.Element("LawfulNeutral") = "False"
                If TrueNeutral.CheckState = CheckState.Checked Then mObject.Element("TrueNeutral") = "True" Else mObject.Element("TrueNeutral") = "False"
                If ChaoticNeutral.CheckState = CheckState.Checked Then mObject.Element("ChaoticNeutral") = "True" Else mObject.Element("ChaoticNeutral") = "False"
                If LawfulEvil.CheckState = CheckState.Checked Then mObject.Element("LawfulEvil") = "True" Else mObject.Element("LawfulEvil") = "False"
                If NeutralEvil.CheckState = CheckState.Checked Then mObject.Element("NeutralEvil") = "True" Else mObject.Element("NeutralEvil") = "False"
                If ChaoticEvil.CheckState = CheckState.Checked Then mObject.Element("ChaoticEvil") = "True" Else mObject.Element("ChaoticEvil") = "False"

                'remove any objects no longer required
                For Each obj In ExistingDomains
                    If Not CurrentDomains.Contains(obj.ObjectGUID) Then obj.Delete()
                Next

                'save the final set of objects
                For Each obj In CurrentDomains
                    If Not ExistingDomains.Contains(obj.ObjectGUID) Then obj.Save()
                    domainstring &= obj.Name & ", "
                Next

                'remove any objects no longer required
                For Each obj In ExistingSpecializations
                    If Not CurrentSpecializations.Contains(obj.ObjectGUID) Then obj.Delete()
                Next

                'save the final set of objects
                For Each obj In CurrentSpecializations
                    If Not ExistingSpecializations.Contains(obj.ObjectGUID) Then obj.Save()
                    psionicstring &= obj.Name & ", "
                Next

                If Not domainstring Is Nothing Then domainstring = domainstring.TrimEnd(New Char() {" "c, ","c})
                If Not psionicstring Is Nothing Then psionicstring = psionicstring.TrimEnd(New Char() {" "c, ","c})

                mObject.Element("Domains") = domainstring
                mObject.Element("Specializations") = psionicstring
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
            Validate = General.ValidateForm(Me.DeityTab.Controls, Errors)

            If DomainList.Count < 2 Then
                Errors.SetError(DomainList, General.ValidationAtLeast2Required)
                Validate = False
            Else
                Errors.SetError(DomainList, "")
            End If

            If LawfulGood.Checked = False And LawfulNeutral.Checked = False And LawfulEvil.Checked = False And NeutralGood.Checked = False And TrueNeutral.Checked = False And NeutralEvil.Checked = False And ChaoticGood.Checked = False And ChaoticNeutral.Checked = False And ChaoticEvil.Checked = False Then
                Errors.SetError(NeutralEvil, General.ValidationAtLeast1Required)
                Validate = False
            Else
                Errors.SetError(NeutralEvil, "")
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

#Region "Domain Tab"

    Private Sub AddButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim Obj As New Objects.ObjectData
        Dim Guid As Objects.ObjectKey

        Try
            If DomainBox.Text = "" Then
                General.ShowInfoDialog("Please select a domain to add.")
                Exit Sub
            End If

            'Check if object as already been added
            Guid = DomainsDatalist(DomainBox.SelectedIndex).ObjectGUID

            If CurrentDomains.ContainsFK("Domain", Guid) Then
                General.ShowInfoDialog("This domain is already in the list.")
            Else
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Deities)
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.Type = Objects.DeityDomainChildType
                Obj.FKElement("Domain", DomainBox.Text, "Name", DomainsDatalist(DomainBox.SelectedIndex).ObjectGUID)

                DomainList.AddItem(Obj.Name, Obj.ObjectGUID)
                CurrentDomains.Add(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click

        Try
            If DomainList.List.SelectedItem Is Nothing Then
                General.ShowInfoDialog("Please select a domain to remove.")
                Exit Sub
            End If

            CurrentDomains.Remove(DomainList.ItemGUID())
            DomainList.RemoveSelectedItem()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Psionic Tab"

    Private Sub AddPsionic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPsionic.Click
        Dim Obj As New Objects.ObjectData
        Dim Guid As Objects.ObjectKey

        Try
            If PsionicBox.Text = "" Then
                General.ShowInfoDialog("Please select a specialization to add.")
                Exit Sub
            End If

            'Check if object as already been added
            Guid = SpecializationsDatalist(PsionicBox.SelectedIndex).ObjectGUID

            If CurrentSpecializations.ContainsFK("Specialization", Guid) Then
                General.ShowInfoDialog("This specialization is already in the list.")
            Else
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Deities)
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.Type = Objects.DeityPsionicSpecializationChildType
                Obj.FKElement("Specialization", PsionicBox.Text, "Name", SpecializationsDatalist(PsionicBox.SelectedIndex).ObjectGUID)

                PsionicList.AddItem(Obj.Name, Obj.ObjectGUID)
                CurrentSpecializations.Add(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemovePsionic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovePsionic.Click

        Try
            If PsionicList.List.SelectedItem Is Nothing Then
                General.ShowInfoDialog("Please select a specialization to remove.")
                Exit Sub
            End If

            CurrentSpecializations.Remove(PsionicList.ItemGUID())
            PsionicList.RemoveSelectedItem()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub


#End Region

End Class


