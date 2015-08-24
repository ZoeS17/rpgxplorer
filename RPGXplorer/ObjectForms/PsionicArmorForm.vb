Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class PsionicArmorForm
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
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents AbilityListBox As RPGXplorer.ListBox
    Public WithEvents RemoveAbility As System.Windows.Forms.Button
    Public WithEvents AddAbility As System.Windows.Forms.Button
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents AbilityDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents BaseArmor As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SpecificTab As System.Windows.Forms.TabPage
    Public WithEvents AbilitiesTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents Effective As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents EnhancementBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Effective2 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Calculate As System.Windows.Forms.CheckBox
    Public WithEvents MaterialDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents NameCheck As System.Windows.Forms.CheckBox
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SpecificTab = New System.Windows.Forms.TabPage
        Me.NameCheck = New System.Windows.Forms.CheckBox
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.MaterialDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Calculate = New System.Windows.Forms.CheckBox
        Me.Effective = New RPGXplorer.ReadOnlyTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.EnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BaseArmor = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.AbilitiesTab = New System.Windows.Forms.TabPage
        Me.Effective2 = New RPGXplorer.ReadOnlyTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.AbilityListBox = New RPGXplorer.ListBox
        Me.RemoveAbility = New System.Windows.Forms.Button
        Me.AddAbility = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.AbilityDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SpecificTab.SuspendLayout()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseArmor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbilitiesTab.SuspendLayout()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SpecificTab.Controls.Add(Me.Label6)
        Me.SpecificTab.Controls.Add(Me.Calculate)
        Me.SpecificTab.Controls.Add(Me.Effective)
        Me.SpecificTab.Controls.Add(Me.Label3)
        Me.SpecificTab.Controls.Add(Me.EnhancementBonus)
        Me.SpecificTab.Controls.Add(Me.Label10)
        Me.SpecificTab.Controls.Add(Me.MarketPrice)
        Me.SpecificTab.Controls.Add(Me.IndentedLine2)
        Me.SpecificTab.Controls.Add(Me.Description)
        Me.SpecificTab.Controls.Add(Me.Label21)
        Me.SpecificTab.Controls.Add(Me.Label1)
        Me.SpecificTab.Controls.Add(Me.BaseArmor)
        Me.SpecificTab.Controls.Add(Me.Label4)
        Me.SpecificTab.Controls.Add(Me.Label2)
        Me.SpecificTab.Controls.Add(Me.IndentedLine1)
        Me.SpecificTab.Location = New System.Drawing.Point(4, 22)
        Me.SpecificTab.Name = "SpecificTab"
        Me.SpecificTab.Size = New System.Drawing.Size(407, 349)
        Me.SpecificTab.TabIndex = 0
        Me.SpecificTab.Text = "Psionic Armor or Shield"
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
        Me.MaterialDropdown.TabIndex = 349
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 350
        Me.Label6.Text = "Special Material"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(15, 230)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(104, 21)
        Me.Calculate.TabIndex = 7
        Me.Calculate.Text = "Calculate Price"
        '
        'Effective
        '
        Me.Effective.BackColor = System.Drawing.Color.White
        Me.Effective.Caption = Nothing
        Me.Effective.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Effective.DockPadding.All = 1
        Me.Effective.ForeColor = System.Drawing.Color.Black
        Me.Effective.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.Effective.Location = New System.Drawing.Point(300, 180)
        Me.Effective.Name = "Effective"
        Me.Effective.Size = New System.Drawing.Size(35, 21)
        Me.Effective.TabIndex = 346
        Me.Effective.TabStop = False
        Me.Effective.TextColor = System.Drawing.Color.Black
        Me.Effective.Vertical = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(175, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 21)
        Me.Label3.TabIndex = 345
        Me.Label3.Text = "Effective Enhancement"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 21)
        Me.Label10.TabIndex = 344
        Me.Label10.Text = "Enhancment"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MarketPrice
        '
        Me.MarketPrice.Location = New System.Drawing.Point(105, 260)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 8
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(16, 105)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 257
        Me.IndentedLine2.TabStop = False
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
        Me.Label21.TabIndex = 256
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "Market Price"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseArmor
        '
        Me.BaseArmor.Location = New System.Drawing.Point(105, 120)
        Me.BaseArmor.Name = "BaseArmor"
        '
        'BaseArmor.Properties
        '
        Me.BaseArmor.Properties.AutoHeight = False
        Me.BaseArmor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BaseArmor.Properties.DropDownRows = 10
        Me.BaseArmor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BaseArmor.Size = New System.Drawing.Size(200, 21)
        Me.BaseArmor.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 241
        Me.Label4.Text = "Base Item"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 234
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 215)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 257
        Me.IndentedLine1.TabStop = False
		'
        'AbilitiesTab
        '
        Me.AbilitiesTab.Controls.Add(Me.Effective2)
        Me.AbilitiesTab.Controls.Add(Me.Label5)
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
        Me.Effective2.Location = New System.Drawing.Point(140, 45)
        Me.Effective2.Name = "Effective2"
        Me.Effective2.Size = New System.Drawing.Size(35, 21)
        Me.Effective2.TabIndex = 348
        Me.Effective2.TabStop = False
        Me.Effective2.TextColor = System.Drawing.Color.Black
        Me.Effective2.Vertical = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 21)
        Me.Label5.TabIndex = 347
        Me.Label5.Text = "Effective Enhancement"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 246
        Me.IndentedLine3.TabStop = False
        '
        'AbilityListBox
        '
        Me.AbilityListBox.Location = New System.Drawing.Point(15, 95)
        Me.AbilityListBox.Name = "AbilityListBox"
        Me.AbilityListBox.Size = New System.Drawing.Size(250, 235)
        Me.AbilityListBox.TabIndex = 3
        '
        'RemoveAbility
        '
        Me.RemoveAbility.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAbility.Location = New System.Drawing.Point(280, 125)
        Me.RemoveAbility.Name = "RemoveAbility"
        Me.RemoveAbility.Size = New System.Drawing.Size(110, 24)
        Me.RemoveAbility.TabIndex = 2
        Me.RemoveAbility.Text = "Remove Ability"
        '
        'AddAbility
        '
        Me.AddAbility.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAbility.Location = New System.Drawing.Point(280, 95)
        Me.AddAbility.Name = "AddAbility"
        Me.AddAbility.Size = New System.Drawing.Size(110, 24)
        Me.AddAbility.TabIndex = 1
        Me.AddAbility.Text = "Add Ability"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 21)
        Me.Label11.TabIndex = 244
        Me.Label11.Text = "Special Ability"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbilityDropdown
        '
        Me.AbilityDropdown.CausesValidation = False
        Me.AbilityDropdown.Location = New System.Drawing.Point(140, 15)
        Me.AbilityDropdown.Name = "AbilityDropdown"
        '
        'AbilityDropdown.Properties
        '
        Me.AbilityDropdown.Properties.AutoHeight = False
        Me.AbilityDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AbilityDropdown.Properties.DropDownRows = 10
        Me.AbilityDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AbilityDropdown.Size = New System.Drawing.Size(150, 21)
        Me.AbilityDropdown.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
        Me.TabPage1.TabIndex = 2
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
        'PsionicArmorForm
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
        Me.Name = "PsionicArmorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Psionic Armor"
        Me.TabControl1.ResumeLayout(False)
        Me.SpecificTab.ResumeLayout(False)
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseArmor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbilitiesTab.ResumeLayout(False)
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'DataLists
    Private BaseArmorDataList() As DataListItem
    Private BaseShieldDatalist() As DataListItem
    Private CombinedDatalist() As DataListItem
    'Private AbilityDataList() As DataListItem
    Private AbilityList As ArrayList

    Private ExistingAbilities As New Objects.ObjectDataCollection
    Private CurrentAbilities As New Objects.ObjectDataCollection

    Private AbilityEnhancement As Integer

    'init
    Public Sub Init()

        Try
            'Load Datalists
            BaseArmorDataList = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.ArmorDefinitionType)
            BaseShieldDatalist = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.ShieldDefinitionType)

            'Merge the armor and shield types
            ReDim CombinedDatalist((BaseArmorDataList.GetLength(0) + BaseShieldDatalist.GetLength(0)) - 1)
            BaseArmorDataList.CopyTo(CombinedDatalist, 0)
            BaseShieldDatalist.CopyTo(CombinedDatalist, BaseArmorDataList.GetLength(0))
            Array.Sort(CombinedDatalist)

            'AbilityDataList = Rules.Index.DataList(Xml.DBTypes.ArmorMagicAbilities, Objects.PsionicArmorAbilityDefinitionType)

            AbilityList = New ArrayList(Rules.Index.DataList(Xml.DBTypes.ArmorMagicAbilities, Objects.PsionicArmorAbilityDefinitionType))
            AbilityList.AddRange(Rules.Index.DataList(Xml.DBTypes.ArmorMagicAbilities, Objects.ArmorMagicAbilityDefinitionType))

            'Populate ComoBoxes
            BaseArmor.Properties.Items.AddRange(CombinedDatalist)

            'Custom Formatting
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MagicArmor)
            mObject.Type = Objects.PsionicArmorDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Psionic Armor or Shield"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim MaterialKey As Objects.ObjectKey
        Dim Child, Ability As Objects.ObjectData
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'int form
            Me.Text = "Edit Psionic Armor or Shield"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            ObjectName.Text = Obj.Name
            Description.Text = Obj.Element("Description")
            If Obj.Element("Suggest") = "Yes" Then NameCheck.Checked = True Else NameCheck.Checked = False

            BaseArmor.SelectedIndex = Rules.Index.GetNameIndex(CombinedDatalist, Obj.Element("Armor"))
            MaterialKey = mObject.GetFKGuid("Material")
            If MaterialKey.IsNotEmpty Then
                For Each Item As DataListItem In MaterialDropdown.Properties.Items()
                    If Item.ObjectGUID.Equals(MaterialKey) Then
                        MaterialDropdown.SelectedItem = Item
                    End If
                Next
            End If

            MarketPrice.Money = New Money(mObject.Element("MarketPrice"))
            EnhancementBonus.Value = mObject.ElementAsInteger("EnhancementBonus")

            ExistingAbilities = mObject.ChildrenOfType(Objects.PsionicArmorAbilityType)
            For Each Child In ExistingAbilities
                CurrentAbilities.Add(Child)
                AbilityListBox.AddItem(Child.Name, Child.ObjectGUID)
                Ability = Child.GetFKObject("ArmorAbility")
                If Ability.Element("PriceType") = "Bonus" Then AbilityEnhancement += Ability.ElementAsInteger("Price")
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
        Dim Armor As New Objects.ObjectData
        Dim Abilities As String = ""

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("Description") = Description.Text
                Armor.Load(CType(BaseArmor.SelectedItem, DataListItem).ObjectGUID)
                mObject.Element("ArmorType") = Armor.Type
                mObject.FKElement("Armor", BaseArmor.Text, "Name", Armor.ObjectGUID)

                If MaterialDropdown.SelectedIndex > 0 Then
                    mObject.FKElement("Material", MaterialDropdown.Text, "Name", CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                If NameCheck.Checked Then mObject.Element("Suggest") = "Yes" Else mObject.Element("Suggest") = "No"
                If Calculate.Checked Then mObject.Element("Calculate") = "Yes" Else mObject.Element("Calculate") = "No"
                mObject.Element("MarketPrice") = MarketPrice.Money.DisplayString
                mObject.Element("EnhancementBonus") = EnhancementBonus.Text

                For Each Obj In ExistingAbilities
                    If Not CurrentAbilities.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                For Each Obj In CurrentAbilities
                    If ExistingAbilities.Contains(Obj.ObjectGUID) Then CurrentAbilities.Remove(Obj.ObjectGUID)
                    Abilities &= Obj.Name & ", "
                Next
                If Abilities <> "" Then Abilities = Abilities.TrimEnd(New Char() {","c, " "c})
                mObject.Element("Abilities") = Abilities

                CurrentAbilities.Save()
                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.RefreshRenamedNode(mObject.ObjectGUID, mObject.Name)
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

            If MarketPrice.Money.GoldDecimal = 0 Then
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

#Region "Magic Armor Tab"

    'Load the AdilityDropdowns with the legal ability choices, Remove any abilities that are no longer valid
    Private Sub BaseArmor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseArmor.SelectedIndexChanged
        Dim tempitem As DataListItem
        Dim AbilityObj, ArmorObj As Objects.ObjectData

        Try
            AbilityDropdown.SelectedIndex = -1
            AbilityDropdown.Properties.Items.Clear()
            MaterialDropdown.Properties.Items.Clear()

            If BaseArmor.SelectedIndex <> -1 Then

                'Enable relevant controls
                AbilityDropdown.Properties.Enabled = True

                ArmorObj = CType(CombinedDatalist(BaseArmor.SelectedIndex).ValueMember, Objects.ObjectData)

                'Update AbilityDropDown
                For Each tempitem In AbilityList
                    AbilityObj = CType(tempitem.ValueMember, Objects.ObjectData)
                    If CheckAbilityAgainstArmor(ArmorObj, AbilityObj) Then
                        AbilityDropdown.Properties.Items.Add(tempitem)
                    End If
                Next

                'is this new item compatible with the currently selected material?
                MaterialDropdown.Properties.Items.AddRange(Rules.Index.DataList(Rules.SpecialMaterial.CompatibleMaterials(ArmorObj), True))
                If MaterialDropdown.SelectedIndex < 0 Then MaterialDropdown.SelectedIndex = 0

                UpdateAbilitiesList(ArmorObj)

                'set icon name
                If mMode = FormMode.Add Then
                    PropertiesTab.ImageFilename.Text = ArmorObj.ImageFilename
                End If

                If Calculate.Checked Then CalculatePrice()
                If NameCheck.Checked Then GenerateName()

            Else
                AbilityDropdown.Properties.Enabled = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'determine the price of the armor/shield
    Private Sub CalculatePrice()
        Dim Armor As New Objects.ObjectData
        Dim SpecialAbility As Objects.ObjectData
        Dim AbilityDef As new Objects.ObjectData
        Dim MaterialKey As Objects.ObjectKey
        Dim Price As Money

        Try
            If BaseArmor.SelectedIndex = -1 Then Exit Sub

            'get base armor
            Armor.Load(CType(BaseArmor.SelectedItem, DataListItem).ObjectGUID)

            If MaterialDropdown.SelectedIndex > 0 Then
                MaterialKey = CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID
            End If

            Price = Rules.Items.EnhancedPrice(Armor, "Medium", MaterialKey, Integer.Parse(Effective.Text))

            'get any specific cost increases
            For Each SpecialAbility In CurrentAbilities
                AbilityDef = SpecialAbility.GetFKObject("ArmorAbility")
                If AbilityDef.Element("PriceType") = "Specific" Then Price.AddMoney(AbilityDef.Element("Price"))
            Next

            MarketPrice.Money = Price

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Update the effective enhancement when the enhancement is changed
    Private Sub EnhancementBonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancementBonus.EditValueChanged
        Try
            UpdateEnhancement()
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialDropdown.SelectedIndexChanged
        Try
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Abilities Tab"

    'Add Ability to the armor
    Private Sub AddAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAbility.Click
        Dim Obj As Objects.ObjectData
        Dim AbilityDef As New Objects.ObjectData

        Try
            If AbilityDropdown.SelectedIndex = -1 Then Exit Sub

            If Not CurrentAbilities.ContainsFK("ArmorAbility", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID) Then

                Obj = ExistingAbilities.Item("ArmorAbility", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.Name = AbilityDropdown.Text
                    Obj.Type = Objects.PsionicArmorAbilityType
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MagicArmor)
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.FKElement("ArmorAbility", AbilityDropdown.Text, "Name", CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                'update the enhancement
                AbilityDef.Load(CType(AbilityDropdown.SelectedItem, DataListItem).ObjectGUID)

                If AbilityDef.Element("PriceType") = "Bonus" Then
                    If Integer.Parse(EnhancementBonus.Text) + AbilityEnhancement + AbilityDef.ElementAsInteger("Price") > 10 Then
                        General.ShowInfoDialog("Effective enhancement cannot exceed +10")
                    Else
                        AbilityListBox.AddItem(Obj.Name, Obj.ObjectGUID)
                        CurrentAbilities.Add(Obj)
                        AbilityEnhancement += AbilityDef.ElementAsInteger("Price")
                        UpdateEnhancement()
                    End If
                Else
                    AbilityListBox.AddItem(Obj.Name, Obj.ObjectGUID)
                    CurrentAbilities.Add(Obj)
                End If

                If Calculate.Checked Then CalculatePrice()
                If NameCheck.Checked Then GenerateName()
            Else
                General.ShowInfoDialog("This ability is already in the list.")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Remove Ability from the armor
    Private Sub RemoveAbility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAbility.Click
        Dim Obj, AbilityDef As Objects.ObjectData

        Try
            If AbilityListBox.List.SelectedItem Is Nothing Then Exit Sub
            Obj = CurrentAbilities.Item(AbilityListBox.ItemGUID)
            AbilityDef = Obj.GetFKObject("ArmorAbility")
            If AbilityDef.Element("PriceType") = "Bonus" Then AbilityEnhancement -= AbilityDef.ElementAsInteger("Price")
            UpdateEnhancement()
            CurrentAbilities.Remove(AbilityListBox.ItemGUID)
            AbilityListBox.RemoveSelectedItem()
            If Calculate.Checked Then CalculatePrice()
            If NameCheck.Checked Then GenerateName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Returns True if the ability can legaly be placed on specified armor
    Private Function CheckAbilityAgainstArmor(ByVal ArmorObj As Objects.ObjectData, ByVal AbilityObj As Objects.ObjectData) As Boolean
        Try

            If AbilityObj.Element("ArmorType") = "Armor & Shield" Then Return True

            If (AbilityObj.Element("ArmorType") = "Shield") Then
                If (ArmorObj.Type = Objects.ShieldDefinitionType) Then Return True
            Else
                If (ArmorObj.Type = Objects.ArmorDefinitionType) Then Return True
            End If

            Return False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Removes allready selected abilities if they are no longer valid
    Private Sub UpdateAbilitiesList(ByVal ArmorObj As Objects.ObjectData)
        Dim tempobj As Objects.ObjectData
        Dim AbilityObj As Objects.ObjectData

        Try

            For Each tempobj In CurrentAbilities
                AbilityObj = tempobj.GetFKObject("ArmorAbility")

                If Not CheckAbilityAgainstArmor(ArmorObj, AbilityObj) Then
                    CurrentAbilities.Remove(tempobj.ObjectGUID)
                    AbilityListBox.RemoveItem(tempobj.Name)
                    AbilityEnhancement -= AbilityObj.ElementAsInteger("Price")
                End If
            Next

            UpdateEnhancement()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Update the effective enhancement
    Private Sub UpdateEnhancement()
        Dim Enhancement As Integer
        Try
            Enhancement = Integer.Parse(EnhancementBonus.Text) + AbilityEnhancement
            If Enhancement > 0 Then
                Effective.Text = "+" & Enhancement
                Effective2.Text = Effective.Text
            Else
                Effective.Text = "0"
                Effective2.Text = "0"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

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

#End Region

    Private Sub NameCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameCheck.CheckedChanged
        If NameCheck.Checked = True Then
            GenerateName()
        End If
    End Sub

    Private Sub GenerateName()
        Dim NameString As String = ""

        If BaseArmor.Text = "" Then
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

        NameString &= " " & BaseArmor.Text
        ObjectName.Text = NameString
    End Sub

End Class


