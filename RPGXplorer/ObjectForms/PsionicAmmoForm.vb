Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class PsionicAmmoForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents SpecificTab As System.Windows.Forms.TabPage
    Public WithEvents AbilitiesTab As System.Windows.Forms.TabPage
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
    Public WithEvents MaterialDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents NameCheck As System.Windows.Forms.CheckBox
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SpecificTab = New System.Windows.Forms.TabPage
        Me.MaterialDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Calculate = New System.Windows.Forms.CheckBox
        Me.Effective1 = New RPGXplorer.ReadOnlyTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.EnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.BaseWeapon = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.NameCheck = New System.Windows.Forms.CheckBox
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.TabControl1.SuspendLayout()
        Me.SpecificTab.SuspendLayout()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseWeapon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbilitiesTab.SuspendLayout()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.SpecificTab)
        Me.TabControl1.Controls.Add(Me.AbilitiesTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'SpecificTab
        '
        Me.SpecificTab.Controls.Add(Me.NameCheck)
        Me.SpecificTab.Controls.Add(Me.ObjectName)
        Me.SpecificTab.Controls.Add(Me.MaterialDropdown)
        Me.SpecificTab.Controls.Add(Me.Label7)
        Me.SpecificTab.Controls.Add(Me.Calculate)
        Me.SpecificTab.Controls.Add(Me.Effective1)
        Me.SpecificTab.Controls.Add(Me.Label5)
        Me.SpecificTab.Controls.Add(Me.EnhancementBonus)
        Me.SpecificTab.Controls.Add(Me.Label6)
        Me.SpecificTab.Controls.Add(Me.IndentedLine4)
        Me.SpecificTab.Controls.Add(Me.MarketPrice)
        Me.SpecificTab.Controls.Add(Me.Description)
        Me.SpecificTab.Controls.Add(Me.Label21)
        Me.SpecificTab.Controls.Add(Me.IndentedLine1)
        Me.SpecificTab.Controls.Add(Me.BaseWeapon)
        Me.SpecificTab.Controls.Add(Me.Label4)
        Me.SpecificTab.Controls.Add(Me.Label2)
        Me.SpecificTab.Controls.Add(Me.Label1)
        Me.SpecificTab.Location = New System.Drawing.Point(4, 22)
        Me.SpecificTab.Name = "SpecificTab"
        Me.SpecificTab.Size = New System.Drawing.Size(407, 349)
        Me.SpecificTab.TabIndex = 0
        Me.SpecificTab.Text = "Psionic Ammunition"
        '
        'MaterialDropdown
        '
        Me.MaterialDropdown.CausesValidation = False
        Me.MaterialDropdown.Location = New System.Drawing.Point(105, 150)
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
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 356
        Me.Label7.Text = "Special Material"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(15, 230)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(104, 21)
        Me.Calculate.TabIndex = 4
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
        Me.Effective1.Location = New System.Drawing.Point(300, 180)
        Me.Effective1.Name = "Effective1"
        Me.Effective1.Size = New System.Drawing.Size(35, 21)
        Me.Effective1.TabIndex = 352
        Me.Effective1.TabStop = False
        Me.Effective1.TextColor = System.Drawing.Color.Black
        Me.Effective1.Vertical = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(175, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 21)
        Me.Label5.TabIndex = 351
        Me.Label5.Text = "Effective Enhancement"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnhancementBonus
        '
        Me.EnhancementBonus.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Location = New System.Drawing.Point(105, 180)
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 21)
        Me.Label6.TabIndex = 350
        Me.Label6.Text = "Enhancement"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Location = New System.Drawing.Point(15, 215)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 349
        Me.IndentedLine4.TabStop = False
        '
        'MarketPrice
        '
        Me.MarketPrice.Location = New System.Drawing.Point(105, 260)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 5
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
        Me.IndentedLine1.Location = New System.Drawing.Point(20, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 231
        Me.IndentedLine1.TabStop = False
        '
        'BaseWeapon
        '
        Me.BaseWeapon.Location = New System.Drawing.Point(105, 120)
        Me.BaseWeapon.Name = "BaseWeapon"
        '
        'BaseWeapon.Properties
        '
        Me.BaseWeapon.Properties.AutoHeight = False
        Me.BaseWeapon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BaseWeapon.Properties.DropDownRows = 10
        Me.BaseWeapon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BaseWeapon.Size = New System.Drawing.Size(150, 21)
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
        Me.Label1.Location = New System.Drawing.Point(15, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
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
        Me.AbilitiesTab.Size = New System.Drawing.Size(407, 349)
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
        Me.Label11.Text = "Special Ability"
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
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
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
        'NameCheck
        '
        Me.NameCheck.Checked = True
        Me.NameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NameCheck.Location = New System.Drawing.Point(325, 15)
        Me.NameCheck.Name = "NameCheck"
        Me.NameCheck.Size = New System.Drawing.Size(65, 21)
        Me.NameCheck.TabIndex = 364
        Me.NameCheck.Text = "Suggest"
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
        Me.ObjectName.TabIndex = 363
        '
        'PsionicAmmoForm
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
        Me.Name = "PsionicAmmoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Psionic Ammo"
        Me.TabControl1.ResumeLayout(False)
        Me.SpecificTab.ResumeLayout(False)
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseWeapon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbilitiesTab.ResumeLayout(False)
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private AbilityEnhancement As Integer

    Private IconName As String

    'init
    Public Sub Init()
        Try
            'Load Datalists
            BaseWeaponDataList = Rules.Index.DataList(Xml.DBTypes.Weapons, Objects.AmmoDefinitionType)
            AbilityDataList = Rules.Index.DataList(Xml.DBTypes.WeaponMagicAbilities, Objects.WeaponMagicAbilityDefinitionType)

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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MagicWeapons)
            mObject.Type = Objects.PsionicAmmoDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Psionic Ammunition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData
        Dim MaterialKey As Objects.ObjectKey

        Try
            mObject = Obj
            mMode = FormMode.Edit
            Me.Text = "Edit Psionic Ammunition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            ObjectName.Text = Obj.Name
            Description.Text = mObject.Element("Description")
            If Obj.Element("Suggest") = "Yes" Then NameCheck.Checked = True Else NameCheck.Checked = False

            BaseWeapon.SelectedIndex = Rules.Index.GetNameIndex(BaseWeaponDataList, Obj.Element("Weapon"))
            MaterialKey = mObject.GetFKGuid("Material")
            If MaterialKey.IsNotEmpty Then
                For Each Item As DataListItem In MaterialDropdown.Properties.Items()
                    If Item.ObjectGUID.Equals(MaterialKey) Then
                        MaterialDropdown.SelectedItem = Item
                    End If
                Next
            End If

            MarketPrice.Value = mObject.Element("MarketPrice")
            EnhancementBonus.Value = mObject.ElementAsInteger("EnhancementBonus")

            ExistingAbilities = mObject.ChildrenOfType(Objects.PsionicWeaponAbilityType)
            For Each Child In ExistingAbilities
                CurrentAbilities.Add(Child)
                AbilityListBox.AddItem(Child.Name, Child.ObjectGUID)
                AbilityEnhancement += Child.GetFKObject("WeaponAbility").ElementAsInteger("PriceBonus")
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
                        'do nothing
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

                If NameCheck.Checked Then mObject.Element("Suggest") = "Yes" Else mObject.Element("Suggest") = "No"
                If Calculate.Checked Then mObject.Element("Calculate") = "Yes" Else mObject.Element("Calculate") = "No"
                mObject.Element("MarketPrice") = MarketPrice.Value
                mObject.Element("EnhancementBonus") = EnhancementBonus.Text

                For Each Obj In ExistingAbilities
                    If Not CurrentAbilities.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                For Each Obj In CurrentAbilities
                    If ExistingAbilities.Contains(Obj.ObjectGUID) Then CurrentAbilities.Remove(Obj.ObjectGUID)
                Next
                CurrentAbilities.Save()

                mObject.Element("EnhancementDisplay") = EnhancementBonus.Text
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

#Region "Magic Ammo Tab"

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

#End Region

#Region "Abilities Tab"

    'Add Ability to the weapon (Primary Head)
    Private Sub AddAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAbility.Click
        Dim Obj As Objects.ObjectData
        Dim AbilityDef As New Objects.ObjectData
        Dim Effective As Integer

        Try
            If AbilityDropdown.SelectedIndex = -1 Then Exit Sub

            If Not CurrentAbilities.ContainsFK("WeaponAbility", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID) Then

                Obj = ExistingAbilities.Item("WeaponAbility", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.Name = AbilityDropdown.Text
                    Obj.Type = Objects.PsionicWeaponAbilityType
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MagicWeapons)
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.FKElement("WeaponAbility", AbilityDropdown.Text, "Name", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)
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

            Obj = CurrentAbilities.Item(AbilityListBox.ItemGUID).GetFKObject("WeaponAbility")
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
        Dim OK As Boolean = True

        Try
            Select Case AbilityObj.Element("WeaponType")
                Case "Melee Weapons Only"
                    OK = False
                Case "Ranged Weapons Only"
                    OK = False
                Case "Thrown Weapons Only"
                    OK = False
            End Select

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
                AbilityObj = Ability.GetFKObject("WeaponAbility")

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

#Region "Cost and Enhancement"

    'Update the effective enhancement
    Private Sub UpdateEnhancement()
        Dim Enhancement As Integer

        Try
            Enhancement = Integer.Parse(EnhancementBonus.Text) + AbilityEnhancement

            If Enhancement > 0 Then
                Effective1.Text = "+" & Enhancement
                Effective2.Text = "+" & Enhancement
            Else
                Effective1.Text = "0"
                Effective2.Text = "0"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'determine the price of the weapon
    Private Sub CalculatePrice()
        Dim Weapon As New Objects.ObjectData
        Dim AbilityDef As Objects.ObjectData
        Dim MaterialKey As Objects.ObjectKey
        Dim Price As Money

        Try
            If BaseWeapon.SelectedIndex = -1 Then Exit Sub

            'get base weapon
            Weapon.Load(CType(BaseWeapon.SelectedItem, DataListItem).ObjectGUID)

            If MaterialDropdown.SelectedIndex > 0 Then
                MaterialKey = CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID
            End If

            Price = Rules.Items.EnhancedPrice(Weapon, "Medium", MaterialKey, Integer.Parse(Effective1.Text))

            'get any specific cost increases
            For Each SpecialAbility As Objects.ObjectData In CurrentAbilities
                AbilityDef = SpecialAbility.GetFKObject("WeaponAbility")
                If AbilityDef.Element("PriceType") = "Specific" Then Price.AddMoney(AbilityDef.Element("PriceBonus"))
            Next

            MarketPrice.Money = Price

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'determine the price of the weapon
    'Private Sub CalculatePrice()
    '    Dim Weapon, AbilityDef As Objects.ObjectData
    '    Dim Price As Money

    '    Try
    '        If BaseWeapon.SelectedIndex = -1 Then Exit Sub

    '        'get base weapon
    '        Weapon.Load(CType(BaseWeapon.SelectedItem, DataListItem).ObjectGUID)
    '        Price = New Money(Weapon.Element("Cost"))

    '        'add cost for masterwork
    '        If Weapon.Element("Masterwork") = "" Then
    '            Price.AddMoney("6gp")
    '        End If

    '        'adjust for effective enhancement
    '        Select Case Effective1.Text
    '            Case "+1"
    '                Price.AddMoney("40gp")
    '            Case "+2"
    '                Price.AddMoney("160gp")
    '            Case "+3"
    '                Price.AddMoney("360gp")
    '            Case "+4"
    '                Price.AddMoney("640gp")
    '            Case "+5"
    '                Price.AddMoney("1000gp")
    '            Case "+6"
    '                Price.AddMoney("1440gp")
    '            Case "+7"
    '                Price.AddMoney("1960gp")
    '            Case "+8"
    '                Price.AddMoney("2560gp")
    '            Case "+9"
    '                Price.AddMoney("3240gp")
    '            Case "+10"
    '                Price.AddMoney("4000gp")
    '        End Select

    '        'get any specific cost increases
    '        For Each SpecialAbility As Objects.ObjectData In CurrentAbilities
    '            AbilityDef = SpecialAbility.GetFKObject("WeaponAbility")
    '            If AbilityDef.Element("PriceType") = "Specific" Then Price.AddMoney(AbilityDef.Element("PriceBonus"))
    '        Next

    '        MarketPrice.Money = Price

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

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
            MaterialDropdown.Properties.Items.Clear()

            WeaponObj = CType(BaseWeaponDataList(BaseWeapon.SelectedIndex).ValueMember, Objects.ObjectData)

            'Update AbilityDropDown (Or Primary Dropdown for Double Weapons)
            For Each tempitem In AbilityDataList
                AbilityObj = CType(tempitem.ValueMember, Objects.ObjectData)
                If CheckAbilityAgainstWeapon(WeaponObj, AbilityObj) Then
                    AbilityDropdown.Properties.Items.Add(tempitem)
                End If
            Next

            'is this new item compatible with the currently selected material?
            MaterialDropdown.Properties.Items.AddRange(Rules.Index.DataList(Rules.SpecialMaterial.CompatibleMaterials(WeaponObj), True))
            If MaterialDropdown.SelectedIndex < 0 Then MaterialDropdown.SelectedIndex = 0

            'Update the AbilityLists
            UpdateAbilitiesList(WeaponObj)

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

    Private Sub MaterialDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialDropdown.SelectedIndexChanged
        Try
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

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

        NameString &= " " & BaseWeapon.Text
        ObjectName.Text = NameString
    End Sub

End Class
