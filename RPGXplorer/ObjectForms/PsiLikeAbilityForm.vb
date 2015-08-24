Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class PsiLikeAbilityForm
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
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Spell As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Usage As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Caster As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Ability As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents SpellDCLabel As System.Windows.Forms.Label
    Public WithEvents CasterLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents SpellDC As RPGXplorer.ReadOnlyTextBox
    Public WithEvents SpellLevel As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents SpellLevelSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SpecificBonsuFeatTab As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SpecificBonsuFeatTab = New System.Windows.Forms.TabPage
        Me.SpellLevel = New RPGXplorer.ReadOnlyTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SpellDC = New RPGXplorer.ReadOnlyTextBox
        Me.Notes = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.CasterLevel = New DevExpress.XtraEditors.SpinEdit
        Me.SpellDCLabel = New System.Windows.Forms.Label
        Me.Ability = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Caster = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Usage = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Spell = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SpellLevelSpin = New DevExpress.XtraEditors.SpinEdit
        Me.TabControl1.SuspendLayout()
        Me.SpecificBonsuFeatTab.SuspendLayout()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpellLevelSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.SpecificBonsuFeatTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'SpecificBonsuFeatTab
        '
        Me.SpecificBonsuFeatTab.Controls.Add(Me.SpellLevelSpin)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.SpellLevel)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label4)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.SpellDC)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Notes)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label21)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.CasterLevel)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.SpellDCLabel)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Ability)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label5)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Caster)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label3)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Usage)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label2)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label1)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label12)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Spell)
        Me.SpecificBonsuFeatTab.Location = New System.Drawing.Point(4, 22)
        Me.SpecificBonsuFeatTab.Name = "SpecificBonsuFeatTab"
        Me.SpecificBonsuFeatTab.Size = New System.Drawing.Size(407, 349)
        Me.SpecificBonsuFeatTab.TabIndex = 2
        Me.SpecificBonsuFeatTab.Text = "Psi Like Ability"
        '
        'SpellLevel
        '
        Me.SpellLevel.BackColor = System.Drawing.Color.White
        Me.SpellLevel.Caption = Nothing
        Me.SpellLevel.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.SpellLevel.CausesValidation = False
        Me.SpellLevel.ForeColor = System.Drawing.Color.Black
        Me.SpellLevel.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SpellLevel.Location = New System.Drawing.Point(340, 105)
        Me.SpellLevel.Name = "SpellLevel"
        Me.SpellLevel.Padding = New System.Windows.Forms.Padding(1)
        Me.SpellLevel.Size = New System.Drawing.Size(35, 21)
        Me.SpellLevel.TabIndex = 242
        Me.SpellLevel.TabStop = False
        Me.SpellLevel.TextColor = System.Drawing.Color.Black
        Me.SpellLevel.Vertical = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(270, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 241
        Me.Label4.Text = "Power Level"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellDC
        '
        Me.SpellDC.BackColor = System.Drawing.Color.White
        Me.SpellDC.Caption = Nothing
        Me.SpellDC.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.SpellDC.CausesValidation = False
        Me.SpellDC.ForeColor = System.Drawing.Color.Black
        Me.SpellDC.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SpellDC.Location = New System.Drawing.Point(260, 135)
        Me.SpellDC.Name = "SpellDC"
        Me.SpellDC.Padding = New System.Windows.Forms.Padding(1)
        Me.SpellDC.Size = New System.Drawing.Size(35, 21)
        Me.SpellDC.TabIndex = 240
        Me.SpellDC.TabStop = False
        Me.SpellDC.TextColor = System.Drawing.Color.Black
        Me.SpellDC.Vertical = False
        Me.SpellDC.Visible = False
        '
        'Notes
        '
        Me.Notes.CausesValidation = False
        Me.Notes.EditValue = ""
        Me.Notes.Location = New System.Drawing.Point(105, 165)
        Me.Notes.Name = "Notes"
        Me.Notes.Properties.MaxLength = 200
        Me.Notes.Size = New System.Drawing.Size(280, 50)
        Me.Notes.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 165)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 239
        Me.Label21.Text = "Notes:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CasterLevel
        '
        Me.CasterLevel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Location = New System.Drawing.Point(105, 75)
        Me.CasterLevel.Name = "CasterLevel"
        Me.CasterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CasterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CasterLevel.Properties.AutoHeight = False
        Me.CasterLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CasterLevel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.CasterLevel.Properties.IsFloatValue = False
        Me.CasterLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CasterLevel.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.CasterLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Size = New System.Drawing.Size(50, 21)
        Me.CasterLevel.TabIndex = 2
        '
        'SpellDCLabel
        '
        Me.SpellDCLabel.BackColor = System.Drawing.SystemColors.Control
        Me.SpellDCLabel.Location = New System.Drawing.Point(170, 135)
        Me.SpellDCLabel.Name = "SpellDCLabel"
        Me.SpellDCLabel.Size = New System.Drawing.Size(100, 21)
        Me.SpellDCLabel.TabIndex = 183
        Me.SpellDCLabel.Text = "Final Power DC = "
        Me.SpellDCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SpellDCLabel.Visible = False
        '
        'Ability
        '
        Me.Ability.EditValue = ""
        Me.Errors.SetIconPadding(Me.Ability, 3)
        Me.Ability.Location = New System.Drawing.Point(105, 135)
        Me.Ability.Name = "Ability"
        Me.Ability.Properties.AutoHeight = False
        Me.Ability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ability.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Ability.Size = New System.Drawing.Size(50, 21)
        Me.Ability.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "DC Ability"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Caster
        '
        Me.Caster.Location = New System.Drawing.Point(105, 105)
        Me.Caster.Name = "Caster"
        Me.Caster.Properties.AutoHeight = False
        Me.Caster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Caster.Properties.DropDownRows = 10
        Me.Caster.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Caster.Size = New System.Drawing.Size(150, 21)
        Me.Caster.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Manifest as"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usage
        '
        Me.Usage.EditValue = ""
        Me.Usage.Location = New System.Drawing.Point(105, 45)
        Me.Usage.Name = "Usage"
        Me.Usage.Properties.AutoHeight = False
        Me.Usage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Usage.Properties.DropDownRows = 20
        Me.Usage.Size = New System.Drawing.Size(100, 21)
        Me.Usage.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Usage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Manifester Level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(15, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 21)
        Me.Label12.TabIndex = 172
        Me.Label12.Text = "Power"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Spell
        '
        Me.Spell.Location = New System.Drawing.Point(105, 15)
        Me.Spell.Name = "Spell"
        Me.Spell.Properties.AutoHeight = False
        Me.Spell.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Spell.Properties.DropDownRows = 10
        Me.Spell.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Spell.Size = New System.Drawing.Size(200, 21)
        Me.Spell.TabIndex = 0
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
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 349)
        Me.PropertiesTab.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'SpellLevelSpin
        '
        Me.SpellLevelSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpellLevelSpin.Location = New System.Drawing.Point(340, 105)
        Me.SpellLevelSpin.Name = "SpellLevelSpin"
        Me.SpellLevelSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.SpellLevelSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpellLevelSpin.Properties.AutoHeight = False
        Me.SpellLevelSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpellLevelSpin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.SpellLevelSpin.Properties.IsFloatValue = False
        Me.SpellLevelSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SpellLevelSpin.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.SpellLevelSpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpellLevelSpin.Size = New System.Drawing.Size(50, 21)
        Me.SpellLevelSpin.TabIndex = 244
        Me.SpellLevelSpin.Visible = False
        '
        'PsiLikeAbilityForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PsiLikeAbilityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpellLikeAbilityForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SpecificBonsuFeatTab.ResumeLayout(False)
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpellLevelSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private MonsterMode As Boolean = False

    'datalists
    Private PowerList As DataListItem()
    Private ClassList As DataListItem()

    'lookup tables
    Private SpellLevelLookup As New Hashtable

    'init
    Public Sub Init()
        Try
            'datalists
            PowerList = Rules.Index.DataList(Xml.DBTypes.Powers, Objects.PowerDefinitionType)

            'initialise controls
            Spell.Properties.Items.AddRange(PowerList)
            Usage.Properties.Items.AddRange(GetExistingUsage())
            Ability.Properties.Items.AddRange(Rules.AbilityScores.Abilities)

            Me.CasterLevel.Properties.DisplayFormat.Format = New Rules.LevelFormatter
            SpellLevel.Text = "-"

            'display final spell DC?
            If mFolder.ObjectGUID.Database = XML.DBTypes.MonsterRaces Then
                SpellDCLabel.Visible = True
                SpellDC.Visible = True
                SpellDC.Text = "-"
                MonsterMode = True
            End If

            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''initialise the form for add
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            Select Case mFolder.Type
                Case Objects.PsiLikeAbilityFolderType
                    mObject.Type = Objects.PsiLikeAbilityTakenType
                Case Else
                    mObject.Type = Objects.PsiLikeAbilityType
            End Select
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Psi Like Ability"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            Select Case mFolder.Type
                Case Objects.PsiLikeAbilityFolderType
                    Dim LevelSelector As New NumericSelector
                    Dim CharacterLevel As Integer = CharacterManager.CurrentCharacter.CharacterLevel
                    LevelSelector.Init("Character Level", "Select level gained", 1, CharacterLevel, CharacterLevel)
                    If LevelSelector.ShowDialog = DialogResult.OK Then
                        mObject.ElementAsInteger("CharacterLevel") = LevelSelector.Value
                        mObject.Element("Source") = "User"
                        Return True
                    Else
                        Return False
                    End If
                Case Else
                    Return True
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mFolder = Obj.Parent
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Psi-Like Ability"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            Spell.SelectedIndex = Rules.Index.GetGuidIndex(PowerList, mObject.GetFKGuid("Power"))
            Usage.Text = mObject.Element("Usage")
            CasterLevel.Value = mObject.ElementAsInteger("ManifesterLevel")

            If Caster.Enabled Then
                Caster.SelectedIndex = Rules.Index.GetGuidIndex(ClassList, mObject.GetFKGuid("Class"))
            Else
                SpellLevelSpin.Value = mObject.ElementAsInteger("SpellLevel")
            End If

            Ability.Text = mObject.Element("Ability")
            Notes.Text = mObject.Element("Notes")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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
                mObject.FKElement("Power", Spell.Text, "Name", CType(Spell.SelectedItem, DataListItem).ObjectGUID)
                mObject.Element("Usage") = Usage.Text
                mObject.ElementAsInteger("ManifesterLevel") = CInt(CasterLevel.Value)

                If Caster.Enabled Then
                    mObject.FKElement("Class", Caster.Text, "Name", CType(Caster.SelectedItem, DataListItem).ObjectGUID)
                    mObject.ElementAsInteger("SpellLevel") = CInt(SpellLevel.Text)
                Else
                    mObject.ElementAsInteger("SpellLevel") = CInt(SpellLevelSpin.Text)
                End If

                mObject.Element("Ability") = Ability.Text
                mObject.Element("Notes") = Notes.Text

                PropertiesTab.UpdateObject(mObject)

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
            Validate = General.ValidateForm(SpecificBonsuFeatTab.Controls, Errors)
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

#End Region

    'get a list of existing values in use for the element
    Private Function GetExistingUsage() As ICollection
        Try
            Dim Values As New Hashtable(50)
            Dim Nodes As System.Xml.XmlNodeList

            'races
            Nodes = XML.SelectNodes(XML.DBTypes.Races, "/RPGXplorerDatabase/RPGXplorerObject/Usage")
            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText, Nothing)
            Next

            'monster races
            Nodes = XML.SelectNodes(XML.DBTypes.MonsterRaces, "/RPGXplorerDatabase/RPGXplorerObject/Usage")
            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText, Nothing)
            Next

            'classes
            Nodes = XML.SelectNodes(XML.DBTypes.Classes, "/RPGXplorerDatabase/RPGXplorerObject/Usage")
            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText, Nothing)
            Next

            'monster classes
            Nodes = XML.SelectNodes(Xml.DBTypes.MonsterClasses, "/RPGXplorerDatabase/RPGXplorerObject/Usage")
            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText, Nothing)
            Next

            Dim ReturnCollection(Values.Count - 1) As String
            Values.Keys.CopyTo(ReturnCollection, 0)

            Array.Sort(ReturnCollection)

            Return ReturnCollection

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'populate the class list with the available classes
    Private Sub Spell_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spell.SelectedIndexChanged
        Try
            Caster.Properties.Items.Clear()
            SpellLevelLookup.Clear()

            If Spell.SelectedIndex <> -1 Then

                Dim PowerObj As Objects.ObjectData = CType(CType(Spell.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
                Dim AllowedCasterClasses As New Objects.ObjectDataCollection

                For Each PowerLevel As Objects.ObjectData In PowerObj.ChildrenOfType(Objects.PowerLevelType)
                    If PowerLevel.Element("Class") <> "" Then
                        AllowedCasterClasses.Add(PowerLevel.GetFKObject("Class"))
                        SpellLevelLookup.Add(PowerLevel.GetFKGuid("Class"), PowerLevel.ElementAsInteger("Level"))
                    End If
                Next

                If AllowedCasterClasses.Count > 0 Then
                    ClassList = Rules.Index.DataList(AllowedCasterClasses)
                    Caster.Properties.Items.AddRange(ClassList)
                End If

            End If

            If Caster.SelectedIndex = -1 Then
                Caster.SelectedIndex = -1
            End If

            'if we are on a domain only spell, we need to allow for manuall editing of the DC
            If Caster.Properties.Items.Count = 0 Then
                Caster.Enabled = False
                SpellLevel.Visible = False
                SpellLevelSpin.Visible = True
            Else
                Caster.Enabled = True
                SpellLevel.Visible = True
                SpellLevelSpin.Visible = False
            End If

            UpdateSpellLevel()
            UpdateSpellDC()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub UpdateSpellLevel()
        Try
            If Caster.SelectedIndex <> -1 Then
                SpellLevel.Text = CInt(SpellLevelLookup(CType(Caster.SelectedItem, DataListItem).ObjectGUID)).ToString
            Else
                SpellLevel.Text = "-"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub UpdateSpellDC()

        If Not MonsterMode Then Exit Sub

        If Caster.Enabled Then

            If Caster.SelectedIndex <> -1 AndAlso Ability.SelectedIndex <> -1 Then
                Dim AbilityModifier As Integer = Rules.AbilityScores.AbilityScore(mFolder.ElementAsInteger(Ability.Text & "Modifier")).Modifier
                SpellDC.Text = (10 + CInt(SpellLevel.Text) + AbilityModifier).ToString
            Else
                SpellDC.Text = "-"
            End If

        Else

            If Ability.SelectedIndex <> -1 Then
                Dim AbilityModifier As Integer = Rules.AbilityScores.AbilityScore(mFolder.ElementAsInteger(Ability.Text & "Modifier")).Modifier
                SpellDC.Text = (10 + CInt(SpellLevelSpin.Text) + AbilityModifier).ToString
            Else
                SpellDC.Text = "-"
            End If

        End If

    End Sub

    Private Sub Caster_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caster.SelectedIndexChanged
        Try
            UpdateSpellLevel()
            UpdateSpellDC()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub Ability_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ability.SelectedIndexChanged
        Try
            UpdateSpellDC()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SpellLevelSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellLevelSpin.EditValueChanged
        Try
            UpdateSpellDC()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

