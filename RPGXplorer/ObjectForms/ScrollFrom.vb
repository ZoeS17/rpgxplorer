Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class ScrollForm
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
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents SpellType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ScrollTab As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents SpellsTab As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents AddSpell As System.Windows.Forms.Button
    Public WithEvents RemoveSpell As System.Windows.Forms.Button
    Public WithEvents CasterLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ThreatRangeLabel As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents SpellBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents SpellList As RPGXplorer.ListBox
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents Calculate As System.Windows.Forms.CheckBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents ClassDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents XPCost As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Suggest As System.Windows.Forms.CheckBox
    Public WithEvents CostToCreate As RPGXplorer.MoneySpin
    Public WithEvents XPLabel As System.Windows.Forms.Label
    Public WithEvents CostLabel As System.Windows.Forms.Label
    Public WithEvents CostSeparator As RPGXplorer.IndentedLine
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ScrollTab = New System.Windows.Forms.TabPage
        Me.CostToCreate = New RPGXplorer.MoneySpin
        Me.Suggest = New System.Windows.Forms.CheckBox
        Me.CostSeparator = New RPGXplorer.IndentedLine
        Me.Calculate = New System.Windows.Forms.CheckBox
        Me.XPCost = New DevExpress.XtraEditors.SpinEdit
        Me.XPLabel = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SpellType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.SpellsTab = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.ClassDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SpellList = New RPGXplorer.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SpellBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CasterLevel = New DevExpress.XtraEditors.SpinEdit
        Me.ThreatRangeLabel = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.AddSpell = New System.Windows.Forms.Button
        Me.RemoveSpell = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ScrollTab.SuspendLayout()
        CType(Me.XPCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpellType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpellsTab.SuspendLayout()
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpellBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.ScrollTab)
        Me.TabControl1.Controls.Add(Me.SpellsTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ScrollTab
        '
        Me.ScrollTab.Controls.Add(Me.CostToCreate)
        Me.ScrollTab.Controls.Add(Me.Suggest)
        Me.ScrollTab.Controls.Add(Me.CostSeparator)
        Me.ScrollTab.Controls.Add(Me.Calculate)
        Me.ScrollTab.Controls.Add(Me.XPCost)
        Me.ScrollTab.Controls.Add(Me.XPLabel)
        Me.ScrollTab.Controls.Add(Me.CostLabel)
        Me.ScrollTab.Controls.Add(Me.MarketPrice)
        Me.ScrollTab.Controls.Add(Me.IndentedLine3)
        Me.ScrollTab.Controls.Add(Me.Description)
        Me.ScrollTab.Controls.Add(Me.Label21)
        Me.ScrollTab.Controls.Add(Me.Label4)
        Me.ScrollTab.Controls.Add(Me.SpellType)
        Me.ScrollTab.Controls.Add(Me.Label2)
        Me.ScrollTab.Controls.Add(Me.ObjectName)
        Me.ScrollTab.Controls.Add(Me.Label1)
        Me.ScrollTab.Location = New System.Drawing.Point(4, 22)
        Me.ScrollTab.Name = "ScrollTab"
        Me.ScrollTab.Size = New System.Drawing.Size(407, 349)
        Me.ScrollTab.TabIndex = 0
        Me.ScrollTab.Text = "Scroll"
        '
        'CostToCreate
        '
        Me.CostToCreate.Location = New System.Drawing.Point(95, 230)
        Me.CostToCreate.Name = "CostToCreate"
        Me.CostToCreate.Size = New System.Drawing.Size(190, 21)
        Me.CostToCreate.TabIndex = 6
        Me.CostToCreate.Visible = False
        '
        'Suggest
        '
        Me.Suggest.Checked = True
        Me.Suggest.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Suggest.Location = New System.Drawing.Point(305, 15)
        Me.Suggest.Name = "Suggest"
        Me.Suggest.Size = New System.Drawing.Size(65, 21)
        Me.Suggest.TabIndex = 1
        Me.Suggest.Text = "Suggest"
        '
        'CostSeparator
        '
        Me.CostSeparator.Location = New System.Drawing.Point(15, 215)
        Me.CostSeparator.Name = "CostSeparator"
        Me.CostSeparator.Size = New System.Drawing.Size(375, 5)
        Me.CostSeparator.TabIndex = 269
        Me.CostSeparator.TabStop = False
        Me.CostSeparator.Visible = False
        '
        'Calculate
        '
        Me.Calculate.Checked = True
        Me.Calculate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Calculate.Location = New System.Drawing.Point(15, 150)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(104, 21)
        Me.Calculate.TabIndex = 4
        Me.Calculate.Text = "Calculate Price"
        '
        'XPCost
        '
        Me.XPCost.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.XPCost.Location = New System.Drawing.Point(95, 260)
        Me.XPCost.Name = "XPCost"
        '
        'XPCost.Properties
        '
        Me.XPCost.Properties.Appearance.Options.UseTextOptions = True
        Me.XPCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XPCost.Properties.AutoHeight = False
        Me.XPCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.XPCost.Properties.IsFloatValue = False
        Me.XPCost.Properties.Mask.EditMask = "9999999999"
        Me.XPCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.XPCost.Properties.Mask.SaveLiteral = False
        Me.XPCost.Properties.Mask.ShowPlaceHolders = False
        Me.XPCost.Properties.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.XPCost.Size = New System.Drawing.Size(80, 21)
        Me.XPCost.TabIndex = 7
        Me.XPCost.Visible = False
        '
        'XPLabel
        '
        Me.XPLabel.Location = New System.Drawing.Point(15, 260)
        Me.XPLabel.Name = "XPLabel"
        Me.XPLabel.Size = New System.Drawing.Size(80, 21)
        Me.XPLabel.TabIndex = 265
        Me.XPLabel.Text = "XP Cost"
        Me.XPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.XPLabel.Visible = False
        '
        'CostLabel
        '
        Me.CostLabel.Location = New System.Drawing.Point(15, 230)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(80, 21)
        Me.CostLabel.TabIndex = 264
        Me.CostLabel.Text = "Cost to Create"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CostLabel.Visible = False
        '
        'MarketPrice
        '
        Me.MarketPrice.Enabled = False
        Me.MarketPrice.Location = New System.Drawing.Point(95, 180)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 5
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(16, 105)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 253
        Me.IndentedLine3.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = "A heavy sheet of vellum inscribed with magic writings."
        Me.Description.Location = New System.Drawing.Point(95, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(295, 46)
        Me.Description.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 252
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 250
        Me.Label4.Text = "Scroll Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellType
        '
        Me.SpellType.Location = New System.Drawing.Point(95, 120)
        Me.SpellType.Name = "SpellType"
        '
        'SpellType.Properties
        '
        Me.SpellType.Properties.AutoHeight = False
        Me.SpellType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpellType.Properties.DropDownRows = 10
        Me.SpellType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpellType.Size = New System.Drawing.Size(100, 21)
        Me.SpellType.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Market Price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.Errors.SetIconPadding(Me.ObjectName, 80)
        Me.ObjectName.Location = New System.Drawing.Point(95, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Scroll Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellsTab
        '
        Me.SpellsTab.Controls.Add(Me.Label7)
        Me.SpellsTab.Controls.Add(Me.ClassDropdown)
        Me.SpellsTab.Controls.Add(Me.SpellList)
        Me.SpellsTab.Controls.Add(Me.Label6)
        Me.SpellsTab.Controls.Add(Me.SpellBox)
        Me.SpellsTab.Controls.Add(Me.CasterLevel)
        Me.SpellsTab.Controls.Add(Me.ThreatRangeLabel)
        Me.SpellsTab.Controls.Add(Me.IndentedLine2)
        Me.SpellsTab.Controls.Add(Me.AddSpell)
        Me.SpellsTab.Controls.Add(Me.RemoveSpell)
        Me.SpellsTab.Location = New System.Drawing.Point(4, 22)
        Me.SpellsTab.Name = "SpellsTab"
        Me.SpellsTab.Size = New System.Drawing.Size(407, 349)
        Me.SpellsTab.TabIndex = 2
        Me.SpellsTab.Text = "Spells"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 276
        Me.Label7.Text = "Class"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClassDropdown
        '
        Me.ClassDropdown.CausesValidation = False
        Me.ClassDropdown.Location = New System.Drawing.Point(95, 45)
        Me.ClassDropdown.Name = "ClassDropdown"
        '
        'ClassDropdown.Properties
        '
        Me.ClassDropdown.Properties.AutoHeight = False
        Me.ClassDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClassDropdown.Properties.DropDownRows = 10
        Me.ClassDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassDropdown.Size = New System.Drawing.Size(200, 21)
        Me.ClassDropdown.TabIndex = 1
        '
        'SpellList
        '
        Me.SpellList.Location = New System.Drawing.Point(15, 125)
        Me.SpellList.Name = "SpellList"
        Me.SpellList.Size = New System.Drawing.Size(250, 210)
        Me.SpellList.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 273
        Me.Label6.Text = "Spell"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellBox
        '
        Me.SpellBox.CausesValidation = False
        Me.SpellBox.Location = New System.Drawing.Point(95, 15)
        Me.SpellBox.Name = "SpellBox"
        '
        'SpellBox.Properties
        '
        Me.SpellBox.Properties.AutoHeight = False
        Me.SpellBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpellBox.Properties.DropDownRows = 10
        Me.SpellBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpellBox.Size = New System.Drawing.Size(200, 21)
        Me.SpellBox.TabIndex = 0
        '
        'CasterLevel
        '
        Me.CasterLevel.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CasterLevel.Enabled = False
        Me.CasterLevel.Location = New System.Drawing.Point(95, 75)
        Me.CasterLevel.Name = "CasterLevel"
        '
        'CasterLevel.Properties
        '
        Me.CasterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CasterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CasterLevel.Properties.AutoHeight = False
        Me.CasterLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CasterLevel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.CasterLevel.Properties.IsFloatValue = False
        Me.CasterLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CasterLevel.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.CasterLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Size = New System.Drawing.Size(50, 21)
        Me.CasterLevel.TabIndex = 2
        '
        'ThreatRangeLabel
        '
        Me.ThreatRangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ThreatRangeLabel.Location = New System.Drawing.Point(15, 75)
        Me.ThreatRangeLabel.Name = "ThreatRangeLabel"
        Me.ThreatRangeLabel.Size = New System.Drawing.Size(70, 21)
        Me.ThreatRangeLabel.TabIndex = 271
        Me.ThreatRangeLabel.Text = "Caster Level"
        Me.ThreatRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 269
        Me.IndentedLine2.TabStop = False
        '
        'AddSpell
        '
        Me.AddSpell.Location = New System.Drawing.Point(280, 125)
        Me.AddSpell.Name = "AddSpell"
        Me.AddSpell.Size = New System.Drawing.Size(100, 24)
        Me.AddSpell.TabIndex = 3
        Me.AddSpell.Text = "Add Spell"
        '
        'RemoveSpell
        '
        Me.RemoveSpell.Location = New System.Drawing.Point(280, 160)
        Me.RemoveSpell.Name = "RemoveSpell"
        Me.RemoveSpell.Size = New System.Drawing.Size(100, 24)
        Me.RemoveSpell.TabIndex = 4
        Me.RemoveSpell.Text = "Remove Spell"
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
        Me.PropertiesTab.TabIndex = 1
		'
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'ScrollForm
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
        Me.Name = "ScrollForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scroll"
        Me.TabControl1.ResumeLayout(False)
        Me.ScrollTab.ResumeLayout(False)
        CType(Me.XPCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpellType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpellsTab.ResumeLayout(False)
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpellBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Structures"

    Private Structure SpellLevelInfo
        Public SpellLevel As Integer
        Public CasterClass As Objects.ObjectData
        Public MinCasterLevel As Integer
    End Structure

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mScribeScroll As Boolean = False
    Private mCharacter As Rules.Character
    Private mInitialCost As Money
    Private mInitialXP As Integer

    'data lists
    Private SpellsDataList As DataListItem()

    'scroll spell objects
    Private ExistingSpells As New Objects.ObjectDataCollection
    Private CurrentSpells As New Objects.ObjectDataCollection
    Private NewSpells As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try

            'Loads Lists
            SpellsDataList = Rules.Index.DataList(XML.DBTypes.Spells, Objects.SpellDefinitionType)

            'Populate ComboBoxEditors
            SpellType.Properties.Items.AddRange(Rules.Lists.ScrollSpellTypes)

            'Custom Formatting
            Me.CasterLevel.Properties.DisplayFormat.Format = New LevelFormatter
            MarketPrice.MaxGP = 999999

            'scribe scroll
            If mScribeScroll Then
                CostSeparator.Visible = True
                CostLabel.Visible = True
                CostToCreate.Visible = True
                XPLabel.Visible = True
                XPCost.Visible = True
            End If

            'init properties
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Scrolls)
            mObject.Type = Objects.ScrollDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID
            mObject.HTML = "Rules/Scrolls.htm"

            'init form
            Me.Text = "Add Scroll"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for scribe scroll
    Public Sub InitScribeScroll(ByVal Folder As Objects.ObjectData, ByVal Character As Rules.Character)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add
            mScribeScroll = True
            mCharacter = Character

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(mFolder.ObjectGUID.Database)
            mObject.Type = Objects.ItemType
            mObject.ParentGUID = mFolder.ObjectGUID
            mObject.HTML = "Rules/Scrolls.htm"
            mObject.ImageFilename = Objects.ObjectTypes.Item(Objects.ScrollDefinitionType).ImageFilename

            'init form
            Me.Text = "Scribe Scroll"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData, Optional ByVal Character As Rules.Character = Nothing)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit
            If Not Character Is Nothing Then
                mScribeScroll = True
                mCharacter = Character
            End If

            'init form
            Me.Text = "Edit Scroll"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            If mObject.Element("CalculatePrice") = "Yes" Then Calculate.Checked = True Else Calculate.Checked = False
            MarketPrice.Value = mObject.Element("MarketPrice")
            SpellType.Text = mObject.Element("SpellType")

            ExistingSpells = mObject.ChildrenOfType(Objects.ScrollSpellType)
            For Each Child As Objects.ObjectData In ExistingSpells
                CurrentSpells.Add(Child)
                SpellList.AddItem(Child.Name & " (CL " & Child.ElementAsInteger("CasterLevel") & ")", Child.ObjectGUID)
            Next

            Description.Text = Obj.Element("Description")

            If Calculate.Checked Then CalculatePrice()

            'get the current values for cost to create and xp
            If mScribeScroll Then
                mInitialCost = CostToCreate.Money
                mInitialXP = CType(XPCost.EditValue, Integer)

            End If

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
                        'do nothing yet
                    Case FormMode.Edit
                        'do nothing yet
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text

                If mScribeScroll Then

                    'check that character has enough xp
                    Dim CharacterXP As Integer = mCharacter.CharacterObject.ElementAsInteger("XP")
                    If CharacterXP < CType(XPCost.EditValue, Integer) Then
                        General.ShowInfoDialog("Not enough XP to scribe this scroll. Adjust XP cost manually if desired. Action cancelled")
                        Exit Sub
                    End If

                    'check that character has enough money
                    If mCharacter.Inventory.Money.InCopper < CostToCreate.Money.InCopper Then
                        General.ShowInfoDialog("Not enough money to scribe this scroll. Adjust the cost of the scroll manually if desired. Action cancelled.")
                        Exit Sub
                    End If

                    'remove money and xp
                    CharacterXP -= CType(XPCost.EditValue, Integer)
                    Dim CharacterObj As Objects.ObjectData = mCharacter.CharacterObject
                    CharacterObj.ElementAsInteger("XP") = CharacterXP
                    mCharacter.Inventory.RemoveMoneySpent(CostToCreate.Money)

                    'item elements
                    mObject.Element("ItemType") = Objects.ScrollDefinitionType
                    mObject.Element("BaseWeight") = Rules.Formatting.FormatPounds(0)
                    mObject.Element("Weight") = Rules.Formatting.FormatPounds(0)
                    mObject.Element("BaseCost") = MarketPrice.Value
                    mObject.Element("Cost") = MarketPrice.Value
                    mObject.Element("Quantity") = "1"
                    mObject.Element("ImageFilename") = "MagicItemsScrolls.png"
                Else
                    mObject.Element("MarketPrice") = MarketPrice.Value
                End If

                mObject.Element("SpellType") = SpellType.Text

                If Calculate.Checked Then mObject.Element("CalculatePrice") = "Yes" Else mObject.Element("CalculatePrice") = ""

                'update scroll spells
                For Each Obj In ExistingSpells
                    If Not CurrentSpells.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                For Each Obj In CurrentSpells
                    If ExistingSpells.Contains(Obj.ObjectGUID) Then CurrentSpells.Remove(Obj.ObjectGUID)
                Next
                CurrentSpells.Save()

                mObject.Element("Description") = Description.Text

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                CharacterManager.SetDirty(mCharacter.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
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
            Validate = General.ValidateForm(Me.ScrollTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.SpellsTab.Controls, Errors)

            If MarketPrice.Money.InCopper = 0 Then
                Errors.SetError(MarketPrice, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(MarketPrice, "")
            End If

            If SpellList.Count = 0 Then
                Errors.SetError(SpellList, "Please provide at least 1 Spell.")
                Validate = False
            Else
                Errors.SetError(SpellList, "")
            End If

            If Not mScribeScroll Then
                If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                    If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                        Errors.SetError(ObjectName, General.ValidationUniqueName)
                        Validate = False
                    Else
                        Errors.SetError(ObjectName, "")
                    End If
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Scroll Tab Code"

    'Update the SpellBox to only show Arcane or Divine spells as specified
    Private Sub SpellType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellType.SelectedIndexChanged
        Dim TempItem As DataListItem
        Try

            SpellBox.SelectedIndex = -1
            SpellBox.Properties.Items.Clear()
            CasterLevel.EditValue = 0
            CasterLevel.Properties.Enabled = False

            'Update the SpellsComboBoxEditor
            If SpellType.Text <> "" Then
                SpellBox.Properties.Enabled = True
                For Each TempItem In SpellsDataList
                    If (CType(TempItem.ValueMember, Objects.ObjectData)).Element(SpellType.Text) = "Yes" Then
                        SpellBox.Properties.Items.Add(TempItem)
                    End If
                Next

                'Update the SpellsList
                UpdateSpellList()
            Else
                SpellBox.Properties.Enabled = False
            End If

            If Calculate.Checked Then CalculatePrice()

        Catch ex As Exception
        End Try
    End Sub

    'Remove invalid spells from the SpellList
    Private Sub UpdateSpellList()
        Dim tempobj As Objects.ObjectData
        Try

            For Each tempobj In CurrentSpells
                If Not tempobj.Element("SpellType") = SpellType.Text Then
                    CurrentSpells.Remove(tempobj.ObjectGUID)
                    SpellList.RemoveItem(tempobj.Name)
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'to calc or not to calc...
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

#Region "Spells Tab Code"

    'Add spell to list box
    Private Sub AddSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSpell.Click
        Try

            If SpellBox.SelectedIndex = -1 Or ClassDropdown.SelectedIndex = -1 Then Exit Sub

            'create the scroll spell object
            Dim Obj As New Objects.ObjectData
            Obj.Name = SpellBox.Text
            Obj.Type = Objects.ScrollSpellType
            If mScribeScroll Then
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
            Else
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Scrolls)
            End If
            Obj.ParentGUID = mObject.ObjectGUID
            Dim SpellGuid As Objects.ObjectKey = CType(SpellBox.SelectedItem(), DataListItem).ObjectGUID
            Obj.HTMLGUID = SpellGuid
            Obj.FKElement("Spell", SpellBox.Text, "Name", SpellGuid)
            Dim SpellLevelInfo As SpellLevelInfo = CType(CType(ClassDropdown.SelectedItem, DataListItem).ValueMember, SpellLevelInfo)
            Obj.ElementAsInteger("SpellLevel") = SpellLevelInfo.SpellLevel
            Obj.Element("SpellType") = SpellType.Text
            Obj.Element("CasterLevel") = CasterLevel.Value.ToString
            SpellList.AddItem(Obj.Name & " (CL " & CasterLevel.Value.ToString & ")", Obj.ObjectGUID)
            CurrentSpells.Add(Obj)
            If mScribeScroll And mMode = FormMode.Edit Then NewSpells.Add(Obj)

            If Calculate.Checked Then CalculatePrice()
            If Suggest.Checked Then SuggestName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove spell from list box
    Private Sub RemoveSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSpell.Click
        Try
            If SpellList.SelectedIndex = -1 Then Exit Sub
            CurrentSpells.Remove(SpellList.ItemGUID)
            If mScribeScroll And mMode = FormMode.Edit Then
                If NewSpells.Contains(SpellList.ItemGUID) Then NewSpells.Remove(SpellList.ItemGUID)
            End If
            SpellList.RemoveSelectedItem()

            If Calculate.Checked Then CalculatePrice()
            If Suggest.Checked Then SuggestName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the spell levels for this spell 
    Private Sub SpellBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellBox.SelectedIndexChanged
        Try
            ClassDropdown.Properties.Items.Clear()

            If SpellBox.SelectedIndex > -1 Then

                'get the selected spell
                Dim SpellDef As New Objects.ObjectData
                SpellDef.Load(CType(SpellBox.SelectedItem(), DataListItem).ObjectGUID)
                Dim ClassSpellLevel As DataListItem
                Dim SpellLevelInfo As SpellLevelInfo
                Dim MinCasterLevel As Integer = 999
                Dim Caster As Objects.ObjectData
                Dim Level As Integer

                'populate the classes dropdown
                For Each SpellLevel As Objects.ObjectData In SpellDef.Children
                    Caster = SpellLevel.GetFKObject(SpellLevel.GetFirstFKElementName)
                    If Caster.Type = Objects.ClassType Then
                        MinCasterLevel = Rules.CasterLevel.MinimumCasterLevelForSpell(SpellLevel.ElementAsInteger("Level"), Caster)
                        If Not MinCasterLevel = 999 Then
                            SpellLevelInfo.SpellLevel = SpellLevel.ElementAsInteger("Level")
                            SpellLevelInfo.CasterClass = Caster
                            SpellLevelInfo.MinCasterLevel = MinCasterLevel
                            ClassSpellLevel = New DataListItem(SpellLevelInfo, Caster.Name)
                            ClassDropdown.Properties.Items.Add(ClassSpellLevel)
                        End If
                    Else
                        Level = SpellLevel.ElementAsInteger("Level")
                        If Level > 0 Then
                            SpellLevelInfo.SpellLevel = Level
                            SpellLevelInfo.CasterClass = Caster
                            SpellLevelInfo.MinCasterLevel = (Level * 2) - 1
                            ClassSpellLevel = New DataListItem(SpellLevelInfo, Caster.Name)
                            ClassDropdown.Properties.Items.Add(ClassSpellLevel)
                        End If
                    End If
                Next
            End If

            'enable/disable
            If ClassDropdown.Properties.Items.Count > 0 Then
                ClassDropdown.Properties.Enabled = True
            Else
                ClassDropdown.Properties.Enabled = False
            End If
            ClassDropdown.SelectedIndex = -1

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'class dropdown handler
    Private Sub ClassDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassDropdown.SelectedIndexChanged
        Try
            If ClassDropdown.SelectedIndex = -1 Then
                CasterLevel.Properties.Enabled = False
                CasterLevel.EditValue = 0
            Else
                Dim SpellLevelInfo As SpellLevelInfo = CType(CType(ClassDropdown.SelectedItem, DataListItem).ValueMember, SpellLevelInfo)
                CasterLevel.Properties.Enabled = True
                CasterLevel.Properties.MinValue = SpellLevelInfo.MinCasterLevel
                CasterLevel.EditValue = CasterLevel.Properties.MinValue
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Calculation Code"

    'suggest name
    Private Sub SuggestName()
        Try
            Dim Spells As New Hashtable

            'count each spell
            For Each ScrollSpell As Objects.ObjectData In CurrentSpells
                Dim AdjName As String = ScrollSpell.Name & " (CL " & ScrollSpell.Element("CasterLevel") & ")"

                If Spells.Contains(AdjName) Then
                    Dim Count As Integer = CType(Spells.Item(AdjName), Integer)

                    Count += 1
                    Spells.Item(AdjName) = Count
                Else
                    Spells.Add(AdjName, 1)
                End If
            Next

            'build the name string
            Dim Temp As New ArrayList

            For Each Item As DictionaryEntry In Spells
                Dim Count As Integer = CType(Item.Value, Integer)

                If Count = 1 Then
                    Temp.Add(CType(Item.Key, String))
                Else
                    Temp.Add(CType(Item.Key, String) & " x" & Count.ToString)
                End If
            Next

            Temp.Sort()

            If Temp.Count = 0 Then
                ObjectName.Text = "Scroll, Blank"
            Else
                Dim Name As String = "Scroll of "

                For Each Spell As String In Temp
                    Name &= Spell & ", "
                Next

                Name = Name.Remove(Name.Length - 2, 2)
                ObjectName.Text = Name
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'calculate the base price of the scroll
    Private Sub CalculatePrice()
        Try
            Dim Scroll As New Scroll

            Scroll.Calculate(CurrentSpells)
            MarketPrice.Money = Scroll.BasePrice

            If mScribeScroll Then
                Select Case mMode
                    Case FormMode.Add
                        CostToCreate.Money = Scroll.MaterialsCost
                        XPCost.EditValue = Scroll.XPCost
                    Case FormMode.Edit
                        Dim ScrollChanges As New Scroll

                        If NewSpells.Count > 0 Then
                            ScrollChanges.Calculate(NewSpells)
                            CostToCreate.Money = ScrollChanges.MaterialsCost
                            XPCost.EditValue = ScrollChanges.XPCost
                        Else
                            CostToCreate.Money = New Money
                            XPCost.EditValue = 0
                        End If
                End Select

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
