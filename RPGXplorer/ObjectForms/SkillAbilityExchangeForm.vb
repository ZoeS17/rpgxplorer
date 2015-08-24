Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SkillAbilityExchnageForm
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
    Public WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents AbilityDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents SetValueTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents SkillDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SkillAbilityExchnageForm))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SetValueTab = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SkillDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.AbilityDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SetValueTab.SuspendLayout()
        CType(Me.SkillDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 400)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(280, 400)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Ability"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SetValueTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 370)
        Me.TabControl1.TabIndex = 0
        '
        'SetValueTab
        '
        Me.SetValueTab.Controls.Add(Me.PictureBox1)
        Me.SetValueTab.Controls.Add(Me.SkillDropdown)
        Me.SetValueTab.Controls.Add(Me.Label2)
        Me.SetValueTab.Controls.Add(Me.AbilityDropdown)
        Me.SetValueTab.Controls.Add(Me.Label1)
        Me.SetValueTab.Controls.Add(Me.Label24)
        Me.SetValueTab.Controls.Add(Me.Label25)
        Me.SetValueTab.Location = New System.Drawing.Point(4, 22)
        Me.SetValueTab.Name = "SetValueTab"
        Me.SetValueTab.Size = New System.Drawing.Size(407, 344)
        Me.SetValueTab.TabIndex = 2
        Me.SetValueTab.Text = "Set Ability"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 311
        Me.PictureBox1.TabStop = False
        '
        'SkillDropdown
        '
        Me.SkillDropdown.EditValue = ""
        Me.SkillDropdown.Location = New System.Drawing.Point(65, 15)
        Me.SkillDropdown.Name = "SkillDropdown"
        '
        'SkillDropdown.Properties
        '
        Me.SkillDropdown.Properties.AutoHeight = False
        Me.SkillDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SkillDropdown.Properties.DropDownRows = 10
        Me.SkillDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SkillDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SkillDropdown.TabIndex = 268
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "Skill"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbilityDropdown
        '
        Me.AbilityDropdown.EditValue = ""
        Me.AbilityDropdown.Location = New System.Drawing.Point(65, 45)
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
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(40, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(255, 15)
        Me.Label24.TabIndex = 314
        Me.Label24.Text = "Will only replace the default ability modifier"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(40, 93)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(255, 15)
        Me.Label25.TabIndex = 315
        Me.Label25.Text = "if the new ability modifier is greater."
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 344)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Properties"
        Me.TabPage1.Visible = False
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SkillAbilityExchnageForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SkillAbilityExchnageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SkillAbilityExchnageForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SetValueTab.ResumeLayout(False)
        CType(Me.SkillDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private SkillDataList As General.DataListItem()

    'init
    Public Sub Init()

        'get datalists
        SkillDataList = Rules.Index.DataList(Xml.DBTypes.Skills, Objects.SkillDefinitionType)

        'load dropdowns
        AbilityDropdown.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
        SkillDropdown.Properties.Items.AddRange(SkillDataList)

        'init the properties tab
        PropertiesTab.Init(mObject, mMode)

    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.SkillAbilityExchangeType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Set Ability Value"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData, Optional ByVal UserAdded As Boolean = False)
        Try
            'init form vars
            mObject = Obj
            mFolder = Obj.Parent
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Modifier"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            AbilityDropdown.Text = mObject.Element("Ability")
            SkillDropdown.SelectedIndex = Rules.Index.GetGuidIndex(SkillDataList, mObject.GetFKGuid("Skill"))

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
                        CharacterManager.SetAllDirty()
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.FKElement("Skill", SkillDropdown.Text, "Name", CType(SkillDropdown.SelectedItem, DataListItem).ObjectGUID)
                mObject.Element("Ability") = AbilityDropdown.Text

                Select Case AbilityDropdown.Text
                    Case "STR"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Strength.ToString
                    Case "INT"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Intelligence.ToString
                    Case "DEX"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Dexterity.ToString
                    Case "CON"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Constitution.ToString
                    Case "WIS"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Wisdom.ToString
                    Case "CHA"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Charisma.ToString
                End Select

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
            Validate = General.ValidateForm(Me.Controls, Me.ErrorProvider1)

            Return Validate
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region



End Class
