Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class PrerequisiteForm
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
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents PrereqList As RPGXplorer.ListBox
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents RemovePrerequisite As System.Windows.Forms.Button
    Public WithEvents PrereqTab As System.Windows.Forms.TabPage
    Public WithEvents PrereqType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AllRequired As System.Windows.Forms.RadioButton
    Public WithEvents AtLeast As System.Windows.Forms.RadioButton
    Public WithEvents AtLeastNo As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents AddPrerequisite As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Prereq As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PrereqNo2 As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PrereqNo As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Level As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ValueLabel As System.Windows.Forms.Label
    Public Shadows WithEvents Focus As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Suggest As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.PrereqTab = New System.Windows.Forms.TabPage
        Me.Suggest = New System.Windows.Forms.CheckBox
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Focus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level = New DevExpress.XtraEditors.SpinEdit
        Me.ValueLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Prereq = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PrereqNo2 = New DevExpress.XtraEditors.SpinEdit
        Me.PrereqNo = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.AtLeastNo = New DevExpress.XtraEditors.SpinEdit
        Me.AtLeast = New System.Windows.Forms.RadioButton
        Me.AllRequired = New System.Windows.Forms.RadioButton
        Me.PrereqList = New RPGXplorer.ListBox
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.RemovePrerequisite = New System.Windows.Forms.Button
        Me.AddPrerequisite = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrereqType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
		Me.TabControl1.SuspendLayout()
        Me.PrereqTab.SuspendLayout()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Focus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prereq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrereqNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrereqNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtLeastNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrereqType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.PrereqTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'PrereqTab
        '
        Me.PrereqTab.Controls.Add(Me.Suggest)
        Me.PrereqTab.Controls.Add(Me.ObjectName)
        Me.PrereqTab.Controls.Add(Me.Label4)
        Me.PrereqTab.Controls.Add(Me.Focus)
        Me.PrereqTab.Controls.Add(Me.Level)
        Me.PrereqTab.Controls.Add(Me.ValueLabel)
        Me.PrereqTab.Controls.Add(Me.Label3)
        Me.PrereqTab.Controls.Add(Me.Prereq)
        Me.PrereqTab.Controls.Add(Me.PrereqNo2)
        Me.PrereqTab.Controls.Add(Me.PrereqNo)
        Me.PrereqTab.Controls.Add(Me.Label2)
        Me.PrereqTab.Controls.Add(Me.AtLeastNo)
        Me.PrereqTab.Controls.Add(Me.AtLeast)
        Me.PrereqTab.Controls.Add(Me.AllRequired)
        Me.PrereqTab.Controls.Add(Me.PrereqList)
        Me.PrereqTab.Controls.Add(Me.IndentedLine2)
        Me.PrereqTab.Controls.Add(Me.RemovePrerequisite)
        Me.PrereqTab.Controls.Add(Me.AddPrerequisite)
        Me.PrereqTab.Controls.Add(Me.Label1)
        Me.PrereqTab.Controls.Add(Me.PrereqType)
        Me.PrereqTab.Location = New System.Drawing.Point(4, 22)
        Me.PrereqTab.Name = "PrereqTab"
        Me.PrereqTab.Size = New System.Drawing.Size(407, 349)
        Me.PrereqTab.TabIndex = 2
        Me.PrereqTab.Text = "Prerequisite"
        '
        'Suggest
        '
        Me.Suggest.Checked = True
        Me.Suggest.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Suggest.Location = New System.Drawing.Point(305, 15)
        Me.Suggest.Name = "Suggest"
        Me.Suggest.Size = New System.Drawing.Size(80, 21)
        Me.Suggest.TabIndex = 1
        Me.Suggest.Text = "Suggest"
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(85, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Focus
        '
        Me.Focus.CausesValidation = False
        Me.Focus.Location = New System.Drawing.Point(85, 125)
        Me.Focus.Name = "Focus"
        '
        'Focus.Properties
        '
        Me.Focus.Properties.AutoHeight = False
        Me.Focus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Focus.Properties.DropDownRows = 10
        Me.Focus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Focus.Size = New System.Drawing.Size(200, 21)
        Me.Focus.TabIndex = 4
        Me.Focus.Visible = False
        '
        'Level
        '
        Me.Level.CausesValidation = False
        Me.Level.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Level.Location = New System.Drawing.Point(85, 125)
        Me.Level.Name = "Level"
        '
        'Level.Properties
        '
        Me.Level.Properties.Appearance.Options.UseTextOptions = True
        Me.Level.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level.Properties.AutoHeight = False
        Me.Level.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level.Properties.IsFloatValue = False
        Me.Level.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Level.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Level.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level.Size = New System.Drawing.Size(50, 21)
        Me.Level.TabIndex = 5
        Me.Level.Visible = False
        '
        'ValueLabel
        '
        Me.ValueLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ValueLabel.CausesValidation = False
        Me.ValueLabel.Location = New System.Drawing.Point(15, 125)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(70, 21)
        Me.ValueLabel.TabIndex = 136
        Me.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Prerequisite"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Prereq
        '
        Me.Prereq.CausesValidation = False
        Me.Prereq.Enabled = False
        Me.Prereq.Location = New System.Drawing.Point(85, 95)
        Me.Prereq.Name = "Prereq"
        '
        'Prereq.Properties
        '
        Me.Prereq.Properties.AutoHeight = False
        Me.Prereq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Prereq.Properties.DropDownRows = 10
        Me.Prereq.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Prereq.Size = New System.Drawing.Size(200, 21)
        Me.Prereq.TabIndex = 3
        '
        'PrereqNo2
        '
        Me.PrereqNo2.CausesValidation = False
        Me.PrereqNo2.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrereqNo2.Location = New System.Drawing.Point(85, 125)
        Me.PrereqNo2.Name = "PrereqNo2"
        '
        'PrereqNo2.Properties
        '
        Me.PrereqNo2.Properties.Appearance.Options.UseTextOptions = True
        Me.PrereqNo2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PrereqNo2.Properties.AutoHeight = False
        Me.PrereqNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PrereqNo2.Properties.DisplayFormat.FormatString = "+0;-0;0"
        Me.PrereqNo2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrereqNo2.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.PrereqNo2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrereqNo2.Properties.IsFloatValue = False
        Me.PrereqNo2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.PrereqNo2.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.PrereqNo2.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrereqNo2.Size = New System.Drawing.Size(50, 21)
        Me.PrereqNo2.TabIndex = 4
        Me.PrereqNo2.Visible = False
        '
        'PrereqNo
        '
        Me.PrereqNo.AllowDrop = True
        Me.PrereqNo.CausesValidation = False
        Me.PrereqNo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrereqNo.Location = New System.Drawing.Point(85, 125)
        Me.PrereqNo.Name = "PrereqNo"
        '
        'PrereqNo.Properties
        '
        Me.PrereqNo.Properties.Appearance.Options.UseTextOptions = True
        Me.PrereqNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PrereqNo.Properties.AutoHeight = False
        Me.PrereqNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PrereqNo.Properties.IsFloatValue = False
        Me.PrereqNo.Properties.Mask.EditMask = "d"
        Me.PrereqNo.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.PrereqNo.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PrereqNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PrereqNo.Size = New System.Drawing.Size(50, 21)
        Me.PrereqNo.TabIndex = 3
        Me.PrereqNo.Visible = False
        '
        'Label2
        '
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(225, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "required"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AtLeastNo
        '
        Me.AtLeastNo.AllowDrop = True
        Me.AtLeastNo.CausesValidation = False
        Me.AtLeastNo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AtLeastNo.Location = New System.Drawing.Point(170, 155)
        Me.AtLeastNo.Name = "AtLeastNo"
        '
        'AtLeastNo.Properties
        '
        Me.AtLeastNo.Properties.Appearance.Options.UseTextOptions = True
        Me.AtLeastNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AtLeastNo.Properties.AutoHeight = False
        Me.AtLeastNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.AtLeastNo.Properties.IsFloatValue = False
        Me.AtLeastNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.AtLeastNo.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.AtLeastNo.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AtLeastNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AtLeastNo.Size = New System.Drawing.Size(50, 21)
        Me.AtLeastNo.TabIndex = 7
        '
        'AtLeast
        '
        Me.AtLeast.CausesValidation = False
        Me.AtLeast.Location = New System.Drawing.Point(105, 155)
        Me.AtLeast.Name = "AtLeast"
        Me.AtLeast.Size = New System.Drawing.Size(70, 21)
        Me.AtLeast.TabIndex = 6
        Me.AtLeast.Text = "At least"
        '
        'AllRequired
        '
        Me.AllRequired.CausesValidation = False
        Me.AllRequired.Checked = True
        Me.AllRequired.Location = New System.Drawing.Point(15, 155)
        Me.AllRequired.Name = "AllRequired"
        Me.AllRequired.Size = New System.Drawing.Size(90, 21)
        Me.AllRequired.TabIndex = 5
        Me.AllRequired.TabStop = True
        Me.AllRequired.Text = "All required"
        '
        'PrereqList
        '
        Me.PrereqList.CausesValidation = False
        Me.PrereqList.Location = New System.Drawing.Point(15, 185)
        Me.PrereqList.Name = "PrereqList"
        Me.PrereqList.Size = New System.Drawing.Size(235, 150)
        Me.PrereqList.TabIndex = 10
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 127
        Me.IndentedLine2.TabStop = False
        '
        'RemovePrerequisite
        '
        Me.RemovePrerequisite.CausesValidation = False
        Me.RemovePrerequisite.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemovePrerequisite.Location = New System.Drawing.Point(265, 215)
        Me.RemovePrerequisite.Name = "RemovePrerequisite"
        Me.RemovePrerequisite.Size = New System.Drawing.Size(125, 24)
        Me.RemovePrerequisite.TabIndex = 9
        Me.RemovePrerequisite.Text = "Remove Prerequisite"
        '
        'AddPrerequisite
        '
        Me.AddPrerequisite.CausesValidation = False
        Me.AddPrerequisite.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPrerequisite.Location = New System.Drawing.Point(265, 185)
        Me.AddPrerequisite.Name = "AddPrerequisite"
        Me.AddPrerequisite.Size = New System.Drawing.Size(125, 24)
        Me.AddPrerequisite.TabIndex = 8
        Me.AddPrerequisite.Text = "Add Prerequisite"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrereqType
        '
        Me.PrereqType.CausesValidation = False
        Me.PrereqType.Location = New System.Drawing.Point(85, 65)
        Me.PrereqType.Name = "PrereqType"
        '
        'PrereqType.Properties
        '
        Me.PrereqType.Properties.AutoHeight = False
        Me.PrereqType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrereqType.Properties.DropDownRows = 10
        Me.PrereqType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PrereqType.Size = New System.Drawing.Size(200, 21)
        Me.PrereqType.TabIndex = 2
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
        'PrerequisiteForm
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
        Me.MinimizeBox = False
        Me.Name = "PrerequisiteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrerequisiteForm"
        Me.TabControl1.ResumeLayout(False)
        Me.PrereqTab.ResumeLayout(False)
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Focus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prereq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrereqNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrereqNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtLeastNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrereqType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'index
    Private PrereqIndex As DataListItem()
    Private FocusIndex As ArrayList

    'object collections
    Private ExistingPrereqs As New Objects.ObjectDataCollection
    Private Prereqs As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try
            'initialise controls
            PrereqType.Properties.Items.AddRange(Rules.Lists.PrerequisiteTypes)
            Level.Properties.DisplayFormat.Format = New Rules.LevelFormatter
            Level.Properties.EditFormat.Format = New Rules.LevelFormatter
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.PrerequisiteType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Prerequisite"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls
            ConfigureAtLeast()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'inir form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Prerequisite"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name

            For Each Child As Objects.ObjectData In mObject.ChildrenOfType(Objects.PrerequisiteChildType)
                Prereqs.Add(Child)
                ExistingPrereqs.Add(Child)
                PrereqList.AddItem(Child.Name, Child.ObjectGUID)
            Next

            ConfigureAtLeast()

            If mObject.Element("Criteria") = "AllRequired" Then
                AllRequired.Checked = True
            Else
                AtLeast.Checked = True
                AtLeastNo.Value = mObject.ElementAsInteger("CriteriaNo")
            End If

            Suggest.Checked = False
            If mObject.Element("SuggestedName") = "True" Then
                Suggest.Checked = True
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
                        CharacterManager.SetAllDirty()
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                If AllRequired.Checked Then
                    mObject.Element("Criteria") = "AllRequired"
                Else
                    mObject.Element("Criteria") = "AtLeastNRequired"
                    mObject.Element("CriteriaNo") = AtLeastNo.Text
                End If

                'remove prereqs no longer required
                For Each Obj In ExistingPrereqs
                    If Not Prereqs.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                'save required prereqs
                For Each Obj In Prereqs
                    If Not ExistingPrereqs.Contains(Obj.ObjectGUID) Then Obj.Save()
                Next

                If Suggest.Checked Then
                    mObject.Element("SuggestedName") = "True"
                Else
                    mObject.Element("SuggestedName") = ""
                End If

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                Select Case mObject.Parent.Type
                    Case Objects.FeatureDefinitionType
                        Caches.SetFeaturesDirty()
                    Case Objects.FeatDefinitionType
                        Caches.SetFeatsDirty()
                End Select
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
            Validate = General.ValidateForm(PrereqTab.Controls, Errors)

            If Prereqs.Count = 0 Then
                Errors.SetError(PrereqList, General.ValidationRequired)
                Validate = False
            Else
                Errors.SetError(PrereqList, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Buttons"

    Private Sub AddPrerequisite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPrerequisite.Click
        Dim Obj, PrereqObj As New Objects.ObjectData

        Try
            'determine type of prereq
            Select Case PrereqType.Text
                Case "Alignment"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select an alignment to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Alignment" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This alignment is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Alignment" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Alignment is " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Alignment"
                        PrereqObj.Element("Prerequisite") = Prereq.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Ability Score"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select an ability to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Ability Score" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This ability is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Ability Score" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text & " " & PrereqNo.Text
                        PrereqObj.Element("PrerequisiteType") = "Ability Score"
                        PrereqObj.Element("Prerequisite") = Prereq.Text
                        PrereqObj.Element("Of") = PrereqNo.Value.ToString

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Base Attack Bonus"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Base Attack Bonus" Then
                            General.ShowInfoDialog("Base Attack Bonus is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Base Attack Bonus" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Base Attack Bonus of " & PrereqNo2.Text
                    PrereqObj.Element("PrerequisiteType") = "Base Attack Bonus"
                    PrereqObj.Element("Of") = PrereqNo2.Value.ToString

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Caster Level"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Caster Level" Then
                            General.ShowInfoDialog("Caster Level is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Caster Level" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Caster Level " & Level.Text
                    PrereqObj.Element("PrerequisiteType") = "Caster Level"
                    PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Cast Specific Spell"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a spell to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Cast Specific Spell" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This spell is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Cast Specific Spell" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Can Cast " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Cast Specific Spell"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Cast Magic of Level"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a type of magic to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Cast Magic of Level" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This type of magic is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Cast Magic of Level" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Can Cast " & Prereq.Text & " Magic of " & Level.Text & " Level"
                        PrereqObj.Element("PrerequisiteType") = "Cast Magic of Level"
                        PrereqObj.Element("Prerequisite") = Prereq.Text
                        PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Character Level"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Character Level" Then
                            General.ShowInfoDialog("Character Level is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Character Level" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Character Level " & Level.Text
                    PrereqObj.Element("PrerequisiteType") = "Character Level"
                    PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Class Level"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a class to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Class Level" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This class is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Class Level" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text & " " & Level.Text
                        PrereqObj.Element("PrerequisiteType") = "Class Level"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Deity"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a deity to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Deity" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This deity is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Deity" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Worships " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Deity"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Domain"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a domain to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Domain" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This domain is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Domain" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Domain: " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Domain"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)
                    End If

                Case "Feat"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a feat to add.")
                    Else

                        'focus
                        If Focus.Visible Then
                            If Focus.SelectedIndex = -1 Then
                                General.ShowInfoDialog("Please select a focus.")
                                Exit Sub
                            End If
                        End If

                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Feat" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then

                                'if the feat has no focus - then we have it already
                                If Obj.Element("Focus") = "" Then
                                    General.ShowInfoDialog("This feat is already in the list.")
                                    Exit Sub
                                Else
                                    Select Case Obj.Element("Focus")
                                        Case "Any Weapon", "The Same Weapon", "Any Skill", "The Same Skill", "Any School", "The Same School", "Any Domain", "The Same Domain", "Any Alignment", "The Same Alignment", "Any Discipline", "The Same Discipline", "Any Specialization", "The Same Specialization", "Any Bludgeoning", "Any Piercing", "Any Slashing"
                                            If TypeOf Focus.SelectedItem Is String Then
                                                If CType(Focus.SelectedItem, String) = Obj.Element("Focus") Then
                                                    General.ShowInfoDialog("This feat is already in the list.")
                                                    Exit Sub
                                                End If
                                            End If
                                        Case Else
                                            If TypeOf Focus.SelectedItem Is DataListItem Then
                                                If Obj.GetFKGuid("Focus").Equals(CType(Focus.SelectedItem, DataListItem).ObjectGUID) Then
                                                    General.ShowInfoDialog("This feat is already in the list.")
                                                    Exit Sub
                                                End If
                                            End If
                                    End Select
                                End If
                            End If

                            'If Obj.Element("PrerequisiteType") = "Feat" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                            '    If Obj.Element("Focus") = "" Then
                            '        General.ShowInfoDialog("This feat is already in the list.")
                            '        Exit Sub
                            '    Else
                            '        Select Case Obj.Element("Focus")
                            '            Case "Any Weapon", "The Same Weapon", "Any Skill", "The Same Skill", "Any School", "The Same School", "Any Domain", "The Same Domain", "Any Alignment", "The Same Alignment", "Any Discipline", "The Same Discipline", "Any Specialization", "The Same Specialization"
                            '                If Focus.SelectedIndex < 2 Then
                            '                    General.ShowInfoDialog("This feat is already in the list.")
                            '                    Exit Sub
                            '                End If
                            '            Case Else
                            '                If TypeOf Focus.SelectedItem Is DataListItem Then
                            '                    If Obj.GetFKGuid("Focus").Equals(CType(Focus.SelectedItem, DataListItem).ObjectGUID) Then
                            '                        General.ShowInfoDialog("This feat is already in the list.")
                            '                        Exit Sub
                            '                    End If
                            '                End If
                            '        End Select
                            '    End If
                            'End If
                        Next


                        'check to see if we have an existing prereq obj for this
                        'For Each Obj In ExistingPrereqs
                        '    If Obj.Element("PrerequisiteType") = "Manifest Powers from Subdiscipline" And Obj.Element("Prerequisite") = Prereq.Text Then
                        '        PrereqObj = Obj
                        '        Exit For
                        '    End If
                        'Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Feat" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                If Obj.Element("Focus") = "" Then
                                    PrereqObj = Obj
                                    Exit For
                                Else

                                    If TypeOf Focus.SelectedItem Is String Then
                                        If Obj.Element("Focus") = Focus.Text Then
                                            PrereqObj = Obj
                                            Exit For
                                        End If
                                    Else
                                        If Obj.GetFKGuid("Focus").Equals(CType(Focus.SelectedItem, DataListItem).ObjectGUID) Then
                                            PrereqObj = Obj
                                            Exit For
                                        End If
                                    End If

                                    'Select Case Obj.Element("Focus")
                                    '    Case "Any Weapon", "Any Skill", "Any School", "Any Domain", "Any Alignment", "Any Discipline", "Any Specialization"
                                    '        If Focus.SelectedIndex = 0 Then
                                    '            PrereqObj = Obj
                                    '            Exit For
                                    '        End If
                                    '    Case "The Same Weapon", "The Same Skill", "The Same School", "The Same Domain", "The Same Alignment", "The Same Discipline", "The Same Specialization"
                                    '        If Focus.SelectedIndex = 1 Then
                                    '            PrereqObj = Obj
                                    '            Exit For
                                    '        End If
                                    '    Case Else
                                    '        If Obj.GetFKGuid("Focus").Equals(CType(Focus.SelectedItem, DataListItem).ObjectGUID) Then
                                    '            PrereqObj = Obj
                                    '            Exit For
                                    '        End If
                                    'End Select

                                End If
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text
                        If Focus.Visible Then PrereqObj.Name &= " (" & Focus.Text & ")"
                        PrereqObj.Element("PrerequisiteType") = "Feat"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        If TypeOf Focus.SelectedItem Is String Then
                            PrereqObj.Element("Focus") = Focus.Text
                        ElseIf TypeOf Focus.SelectedItem Is DataListItem Then
                            PrereqObj.FKElement("Focus", Focus.Text, "Name", CType(Focus.SelectedItem, DataListItem).ObjectGUID)
                        End If

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Feature"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a feature to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Feature" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This feature is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Feature" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Feature"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Feat of Type"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a feat type to add.")
                    Else
                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Feat of Type" And Obj.Element("Prerequisite") = Prereq.Text And Not PrereqList.Contains(Obj.ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Any " & Prereq.Text & " Feat"
                        PrereqObj.Element("PrerequisiteType") = "Feat of Type"
                        PrereqObj.Element("Prerequisite") = Prereq.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "First Level Only"

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "First Level Only" And Not PrereqList.Contains(Obj.ObjectGUID) Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "First Level Only"
                    PrereqObj.Element("PrerequisiteType") = "First Level Only"

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Gender"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a gender to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Gender" Then
                                General.ShowInfoDialog("Gender prerequisite is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Gender" Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Gender: " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Gender"
                        PrereqObj.Element("Prerequisite") = Prereq.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Language"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a language to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Language" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This language is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Language" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Language: " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Language"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Manifester Level"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Manifester Level" Then
                            General.ShowInfoDialog("Manifester Level is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Manifester Level" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Manifester Level " & Level.Text
                    PrereqObj.Element("PrerequisiteType") = "Manifester Level"
                    PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)


                Case "Manifest Power of Level"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Manifest Power of Level" Then
                            General.ShowInfoDialog("This type of prerequisite is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Manifest Power of Level" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Can Manifest Power of " & Level.Text & " Level"
                    PrereqObj.Element("PrerequisiteType") = "Manifest Power of Level"
                    PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)
                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Manifest Specific Power"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a power to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Specific Power" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This power is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Specific Power" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Can Manifest " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Manifest Specific Power"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Power Point Reserve"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Power Point Reserve" Then
                            General.ShowInfoDialog("Power Point Reserve is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Power Point Reserve" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Power Point Reserve of " & PrereqNo.Text
                    PrereqObj.Element("PrerequisiteType") = "Power Point Reserve"
                    PrereqObj.Element("Of") = PrereqNo.Value.ToString

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Psionic Specialization"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a psionic specialization to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Psionic Specialization" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This specialization is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Psionic Specialization" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Specialization: " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Psionic Specialization"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Psi-Like Ability of Manifester Level"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Psi-Like Ability of Manifester Level" Then
                            General.ShowInfoDialog("Psi-Like Ability of Manifester Level is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Psi-Like Ability of Manifester Level" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Psi-Like Ability of Manifester Level " & Level.Text
                    PrereqObj.Element("PrerequisiteType") = "Psi-Like Ability of Manifester Level"
                    PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)


                Case "Race"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a race to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Race" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This race is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Race" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Race"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Saving Throw"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a saving throw to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Saving Throw" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This saving throw is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Saving Throw" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text & " Saving Throw of " & PrereqNo.Text
                        PrereqObj.Element("PrerequisiteType") = "Saving Throw"
                        PrereqObj.Element("Prerequisite") = Prereq.Text
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Saving Throw (Base)"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a saving throw to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Saving Throw (Base)" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This saving throw is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Saving Throw (Base)" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Base " & Prereq.Text & " Saving Throw of " & PrereqNo.Text
                        PrereqObj.Element("PrerequisiteType") = "Saving Throw (Base)"
                        PrereqObj.Element("Prerequisite") = Prereq.Text
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Size"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a size to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Size" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("Size prerequisite is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Size" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Size: " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Size"
                        PrereqObj.Element("Prerequisite") = Prereq.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Skill"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a skill to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Skill" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                General.ShowInfoDialog("This skill is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Skill" And Obj.GetFKGuid("Prerequisite").Equals(CType(Prereq.SelectedItem, DataListItem).ObjectGUID) Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text & " " & PrereqNo.Text & " Rank(s)"
                        PrereqObj.Element("PrerequisiteType") = "Skill"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Value.ToString

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Skill Group"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a skill group to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Skill Group" And Obj.Element("Prerequisite") = Prereq.Text Then
                                If Obj.Element("Of") <> PrereqNo.Value.ToString Then
                                    General.ShowInfoDialog("This skill group is already in the list. To add it again you must require the same number of ranks.")
                                    Exit Sub
                                End If
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Skill Group" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = Prereq.Text & " " & PrereqNo.Text & " Rank(s)"
                        PrereqObj.Element("PrerequisiteType") = "Skill Group"
                        PrereqObj.Element("Prerequisite") = Prereq.Text
                        PrereqObj.Element("Of") = PrereqNo.Value.ToString

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Spell Resistance"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Spell Resistance" Then
                            General.ShowInfoDialog("Spell Resistance is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Spell Resistance" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Spell Resistance " & PrereqNo.Text
                    PrereqObj.Element("PrerequisiteType") = "Spell Resistance"
                    PrereqObj.Element("Of") = PrereqNo.Value.ToString

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Spell-Like Ability of Caster Level"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Spell-Like Ability of Caster Level" Then
                            General.ShowInfoDialog("Spell-Like Ability of Caster Level is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Spell-Like Ability of Caster Level" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Spell-Like Ability of Caster Level " & Level.Text
                    PrereqObj.Element("PrerequisiteType") = "Spell-Like Ability of Caster Level"
                    PrereqObj.ElementAsInteger("Of") = CType(Level.Value, Integer)

                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Cast Spells from School"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a spell school to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Cast Spells from School" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This spell school is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Cast Spells from School" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Cast " & PrereqNo.Text & " Spell(s) from " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Cast Spells from School"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If


                Case "Cast Spells from Subschool"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a spell subschool to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Cast Spells from Subschool" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This spell subschool is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Cast Spells from Subschool" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Cast " & PrereqNo.Text & " Spell(s) from " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Cast Spells from Subschool"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If


                Case "Cast Spells with Descriptor"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a descriptor to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Cast Spells with Descriptor" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This descriptor is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Cast Spells with Descriptor" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Cast " & PrereqNo.Text & " Spell(s) with " & Prereq.Text & " descriptor"
                        PrereqObj.Element("PrerequisiteType") = "Cast Spells with Descriptor"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If


                Case "Manifest Powers from Discipline"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a psionic discipline to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Powers from Discipline" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This psionic discipline is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Powers from Discipline" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Manifest " & PrereqNo.Text & " Powers(s) from " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Manifest Powers from Discipline"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Manifest Powers from Subdiscipline"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a psionic subdiscipline to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Powers from Subdiscipline" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This psionic subdiscipline is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Powers from Subdiscipline" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Manifest " & PrereqNo.Text & " Powers(s) from " & Prereq.Text
                        PrereqObj.Element("PrerequisiteType") = "Manifest Powers from Subdiscipline"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Manifest Powers with Descriptor"

                    If Prereq.SelectedIndex = -1 Then
                        General.ShowInfoDialog("Please select a descriptor to add.")
                    Else
                        'check to see if it is in list already
                        For Each Obj In Prereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Powers with Descriptor" And Obj.Element("Prerequisite") = Prereq.Text Then
                                General.ShowInfoDialog("This descriptor is already in the list.")
                                Exit Sub
                            End If
                        Next

                        'check to see if we have an existing prereq obj for this
                        For Each Obj In ExistingPrereqs
                            If Obj.Element("PrerequisiteType") = "Manifest Powers with Descriptor" And Obj.Element("Prerequisite") = Prereq.Text Then
                                PrereqObj = Obj
                                Exit For
                            End If
                        Next

                        'if no existing obj then create one
                        If PrereqObj.IsEmpty Then
                            PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            PrereqObj.Type = Objects.PrerequisiteChildType
                            PrereqObj.ParentGUID = mObject.ObjectGUID
                        End If

                        PrereqObj.Name = "Manifest " & PrereqNo.Text & " Powers(s) with " & Prereq.Text & " descriptor"
                        PrereqObj.Element("PrerequisiteType") = "Manifest Powers with Descriptor"
                        PrereqObj.FKElement("Prerequisite", Prereq.Text, "Name", CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
                        PrereqObj.Element("Of") = PrereqNo.Text

                        Prereqs.Add(PrereqObj)
                        PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                    End If

                Case "Flurry of Blows Ability"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Flurry of Blows Ability" Then
                            General.ShowInfoDialog("This prerequisite is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Flurry of Blows Ability" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Character has the Flurry of Blows Ability"
                    PrereqObj.Element("PrerequisiteType") = "Flurry of Blows Ability"
                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Damage Reduction (Racial/Class)"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Damage Reduction (Racial/Class)" Then
                            General.ShowInfoDialog("This prerequisite is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Damage Reduction (Racial/Class)" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Character has Damage Reduction"
                    PrereqObj.Element("PrerequisiteType") = "Damage Reduction (Racial/Class)"
                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

                Case "Fly Speed"

                    'check to see if it is in list already
                    For Each Obj In Prereqs
                        If Obj.Element("PrerequisiteType") = "Fly Speed" Then
                            General.ShowInfoDialog("This prerequisite is already in the list.")
                            Exit Sub
                        End If
                    Next

                    'check to see if we have an existing prereq obj for this
                    For Each Obj In ExistingPrereqs
                        If Obj.Element("PrerequisiteType") = "Fly Speed" Then
                            PrereqObj = Obj
                            Exit For
                        End If
                    Next

                    'if no existing obj then create one
                    If PrereqObj.IsEmpty Then
                        PrereqObj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                        PrereqObj.Type = Objects.PrerequisiteChildType
                        PrereqObj.ParentGUID = mObject.ObjectGUID
                    End If

                    PrereqObj.Name = "Character can Fly"
                    PrereqObj.Element("PrerequisiteType") = "Fly Speed"
                    Prereqs.Add(PrereqObj)
                    PrereqList.AddItem(PrereqObj.Name, PrereqObj.ObjectGUID)

            End Select

            ConfigureAtLeast()
            If Suggest.Checked Then SuggestName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemovePrerequisite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovePrerequisite.Click
        Try
            If PrereqList.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a prerequisite to remove.")
            Else
                Prereqs.Remove(PrereqList.ItemGUID)
                PrereqList.RemoveSelectedItem()
            End If

            ConfigureAtLeast()
            If Suggest.Checked Then SuggestName()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SuggestName()
        Dim Temp As String = ""

        Try
            If PrereqList.Count = 0 Then Exit Sub
            For Each Item As String In PrereqList.GetNames
                Temp &= Item & ", "
            Next
            If Temp <> "" Then Temp = Temp.TrimEnd(New Char() {","c, " "c})

            If Temp.Length > 50 Then Temp = Temp.Substring(0, 46) & "..."
            ObjectName.Text = Temp

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

    Private Sub PrereqType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrereqType.SelectedIndexChanged
        Try
            'reset controls
            Prereq.Properties.Items.Clear()
            Prereq.Text = ""
            PrereqNo.Value = 1
            PrereqNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            PrereqNo2.Value = 1
            Level.Value = 1
            Focus.SelectedIndex = -1

            'determine type of prereq
            Select Case PrereqType.Text
                Case "Alignment"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.AlignmentTypes)
                    HideNumbersAndFocus()
                Case "Ability Score"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 3
                    PrereqNo.Properties.MaxValue = 50
                    SetLabel("Score")
                Case "Base Attack Bonus"
                    Prereq.Properties.Enabled = False
                    PrereqNo2.Visible = True
                    SetLabel("BAB")
                Case "Caster Level", "Character Level"
                    Prereq.Properties.Enabled = False
                    Level.Visible = True
                Case "Cast Specific Spell"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Spells, Objects.SpellDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Cast Magic of Level"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.ScrollSpellTypes)
                    Level.Visible = True
                    Level.Properties.MaxValue = 9
                Case "Class Level"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Classes, Objects.ClassType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    Level.Visible = True
                    Level.Properties.MaxValue = Rules.Constants.MaxLevels
                Case "Damage Reduction"
                    Prereq.Properties.Enabled = False
                    HideNumbersAndFocus()
                Case "Deity"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Deities, Objects.DeityDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Domain"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Domains, Objects.DomainDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Feat"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Feats, Objects.FeatDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Feature"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Features, Objects.FeatureDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Feat of Type"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.FeatTypes)
                    HideNumbersAndFocus()
                Case "First Level Only"
                    Prereq.Enabled = False
                    HideNumbersAndFocus()
                Case "Flurry of Blows Ability"
                    Prereq.Properties.Enabled = False
                    HideNumbersAndFocus()
                Case "Fly Speed"
                    Prereq.Properties.Enabled = False
                    HideNumbersAndFocus()
                Case "Gender"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.GenderTypes)
                    HideNumbersAndFocus()
                Case "Language"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Languages, Objects.LanguageDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Manifester Level"
                    Prereq.Properties.Enabled = False
                    Level.Visible = True
                Case "Manifest Power of Level"
                    Prereq.Properties.Enabled = False
                    Level.Visible = True
                    Level.Properties.MaxValue = 9
                Case "Manifest Specific Power"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Powers, Objects.PowerDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Power Point Reserve"
                    Prereq.Properties.Enabled = False
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 999
                    PrereqNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    SetLabel("Points")
                Case "Psionic Specialization"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Psi-Like Ability of Manifester Level"
                    Prereq.Properties.Enabled = False
                    Level.Visible = True
                Case "Race"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.Races, Objects.RaceType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    HideNumbersAndFocus()
                Case "Saving Throw"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.SavingThrows)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Save")
                Case "Saving Throw (Base)"
                    Prereq.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.SavingThrows)
                    PrereqNo.Visible = True
                Case "Size"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.Sizes)
                    HideNumbersAndFocus()
                Case "Skill"
                    Prereq.Properties.Enabled = True
                    Dim Exclusions As New ArrayList
                    Exclusions.Add(References.SpeakLanguage)
                    PrereqIndex = Rules.Index.DataListExclude(XML.DBTypes.Skills, Objects.SkillDefinitionType, Exclusions)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    SetLabel("Ranks")
                Case "Skill Group"
                    Prereq.Properties.Enabled = True
                    Prereq.Properties.Items.AddRange(Rules.Lists.SkillGroups)
                    PrereqNo.Visible = True
                    SetLabel("Ranks")
                Case "Spell-Like Ability of Caster Level"
                    Prereq.Properties.Enabled = False
                    Level.Visible = True
                Case "Spell Resistance"
                    Prereq.Properties.Enabled = False
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("SR")
                Case "Cast Spells from School"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.SpellSchoolType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Spells")
                Case "Cast Spells from Subschool"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.SpellSubschoolType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Spells")
                Case "Cast Spells with Descriptor"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellDescriptorDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Spells")
                Case "Manifest Powers from Discipline"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.PsionicDisciplineType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Powers")
                Case "Manifest Powers from Subdiscipline"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.PsionicSubdisciplineType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Powers")
                Case "Manifest Powers with Descriptor"
                    Prereq.Properties.Enabled = True
                    PrereqIndex = Rules.Index.DataList(XML.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellDescriptorDefinitionType)
                    Prereq.Properties.Items.AddRange(PrereqIndex)
                    PrereqNo.Visible = True
                    PrereqNo.Properties.MinValue = 1
                    PrereqNo.Properties.MaxValue = 99
                    SetLabel("Powers")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Prereq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prereq.SelectedIndexChanged
        Dim Feat As New Objects.ObjectData
        Dim SchoolFocus, SkillFocus, WeaponFocus, DomainFocus, AlignmentFocus, DisciplineFocus, SpecializationFocus As Boolean

        Try
            If Not PrereqType.Text = "Feat" Then Exit Sub

            'get the feat and the type of focus
            Feat.Load(CType(Prereq.SelectedItem, DataListItem).ObjectGUID)
            Focus.Properties.Items.Clear()
            Focus.Text = ""
            Focus.SelectedItem = -1

            'get the type of the parent
            If mFolder.Type = Objects.FeatDefinitionType And mFolder.Element("FocusType") <> "" Then
                Select Case mFolder.Element("FocusType")
                    Case "Alignment"
                        AlignmentFocus = True
                    Case "Discipline Specialization"
                        SpecializationFocus = True
                    Case "Domain"
                        DomainFocus = True
                    Case "Power Discipline"
                        DisciplineFocus = True
                    Case "Spell School"
                        SchoolFocus = True
                    Case "Skill"
                        SkillFocus = True
                    Case Else
                        WeaponFocus = True
                End Select
            End If

            Select Case Feat.Element("FocusType")

                Case "Custom"
                    FocusIndex = New ArrayList
                    FocusIndex.Insert(0, "Any Focus")

                Case "Alignment"
                    FocusIndex = New ArrayList(Rules.Index.AlignmentDataList)
                    FocusIndex.Insert(0, "Any Alignment")
                    If AlignmentFocus Then FocusIndex.Insert(1, "The Same Alignment")

                Case "Discipline Specialization"
                    FocusIndex = New ArrayList(Rules.Index.DataList(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType))
                    FocusIndex.Insert(0, "Any Specialization")
                    If SpecializationFocus Then FocusIndex.Insert(1, "The Same Specialization")

                Case "Domain"
                    FocusIndex = New ArrayList(Rules.Index.DataList(XML.DBTypes.Domains, Objects.DomainDefinitionType))
                    FocusIndex.Insert(0, "Any Domain")
                    If DomainFocus Then FocusIndex.Insert(1, "The Same Domain")

                Case "Power Discipline"
                    FocusIndex = New ArrayList(Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.PsionicDisciplineType))
                    FocusIndex.Insert(0, "Any Discipline")
                    If DisciplineFocus Then FocusIndex.Insert(1, "The Same Discipline")

                Case "Spell School"
                    FocusIndex = New ArrayList(Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.SpellSchoolType))
                    FocusIndex.Insert(0, "Any School")
                    If SchoolFocus Then FocusIndex.Insert(1, "The Same School")

                Case "Skill"
                    Dim Exclusions As New ArrayList
                    Exclusions.Add(References.SpeakLanguage)
                    FocusIndex = New ArrayList(Rules.Index.DataListExclude(XML.DBTypes.Skills, Objects.SkillDefinitionType, Exclusions))
                    FocusIndex.Insert(0, "Any Skill")
                    If SkillFocus Then FocusIndex.Insert(1, "The Same Skill")

                    'weapons
                Case "Any Weapon"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='']"))
                    Dim Index As Integer = 0
                    FocusIndex.Insert(Index, "Any Weapon") : Index += 1
                    FocusIndex.Insert(Index, "Any Bludgeoning") : Index += 1
                    FocusIndex.Insert(Index, "Any Piercing") : Index += 1
                    FocusIndex.Insert(Index, "Any Slashing") : Index += 1
                    If WeaponFocus Then
                        FocusIndex.Insert(Index, "The Same Weapon") : Index += 1
                    End If
                    FocusIndex.Insert(Index, New DataListItem(Nothing, References.Grapple, "Grapple")) : Index += 1
                    FocusIndex.Insert(Index, New DataListItem(Nothing, References.Ray, "Ray")) : Index += 1
                    FocusIndex.Insert(Index, New DataListItem(Nothing, References.RangedSpell, "Ranged Spell")) : Index += 1
                    FocusIndex.Insert(Index, New DataListItem(Nothing, References.TouchSpell, "Touch Spell")) : Index += 1

                Case "Simple Weapon"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Simple']"))
                    FocusIndex.Insert(0, "Any Weapon")
                    FocusIndex.Insert(1, "Any Bludgeoning")
                    FocusIndex.Insert(2, "Any Piercing")
                    FocusIndex.Insert(3, "Any Slashing")
                    If WeaponFocus Then FocusIndex.Insert(4, "The Same Weapon")

                Case "Exotic Weapon"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Exotic']"))
                    FocusIndex.Insert(0, "Any Weapon")
                    FocusIndex.Insert(1, "Any Bludgeoning")
                    FocusIndex.Insert(2, "Any Piercing")
                    FocusIndex.Insert(3, "Any Slashing")
                    If WeaponFocus Then FocusIndex.Insert(4, "The Same Weapon")

                Case "Martial Weapon"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Martial']"))
                    FocusIndex.Insert(0, "Any Weapon")
                    FocusIndex.Insert(1, "Any Bludgeoning")
                    FocusIndex.Insert(2, "Any Piercing")
                    FocusIndex.Insert(3, "Any Slashing")
                    If WeaponFocus Then FocusIndex.Insert(4, "The Same Weapon")

                Case "Ranged Weapon"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Ranged']"))
                    FocusIndex.Insert(0, "Any Weapon")
                    FocusIndex.Insert(1, "Any Bludgeoning")
                    FocusIndex.Insert(2, "Any Piercing")
                    FocusIndex.Insert(3, "Any Slashing")
                    If WeaponFocus Then FocusIndex.Insert(4, "The Same Weapon")

                Case "Melee Weapon"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Melee']"))
                    FocusIndex.Insert(0, "Any Weapon")
                    FocusIndex.Insert(1, "Any Bludgeoning")
                    FocusIndex.Insert(2, "Any Piercing")
                    FocusIndex.Insert(3, "Any Slashing")
                    If WeaponFocus Then FocusIndex.Insert(4, "The Same Weapon")

                Case "Crossbow"
                    FocusIndex = New ArrayList(Rules.Index.DataListXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Ranged']"))
                    FocusIndex.Insert(0, "Any Weapon")
                    FocusIndex.Insert(1, "Any Bludgeoning")
                    FocusIndex.Insert(2, "Any Piercing")
                    FocusIndex.Insert(3, "Any Slashing")
                    If WeaponFocus Then FocusIndex.Insert(4, "The Same Weapon")
            End Select

            If Feat.Element("FocusType") <> "" Then
                Focus.Visible = True
                Focus.Properties.Items.AddRange(FocusIndex.ToArray)
            Else
                HideNumbersAndFocus()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SetLabel(ByVal Text As String)
        Try
            ValueLabel.Text = Text
            ValueLabel.Visible = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub HideNumbersAndFocus()
        Try
            ValueLabel.Visible = False
            PrereqNo.Visible = False
            PrereqNo.Properties.Enabled = False
            PrereqNo.Value = 1
            PrereqNo2.Visible = False
            PrereqNo2.Properties.Enabled = False
            PrereqNo2.Value = 1
            Level.Visible = False
            Level.Properties.Enabled = False
            Level.Value = 1
            Focus.Visible = False
            Focus.Properties.Enabled = False
            Focus.Properties.Items.Clear()
            Focus.SelectedIndex = -1
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub PrereqNo_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrereqNo.VisibleChanged
        Try
            If PrereqNo.Visible Then
                PrereqNo.Properties.Enabled = True
                PrereqNo.Properties.MinValue = 1
                PrereqNo.Properties.MaxValue = 99
                PrereqNo2.Visible = False
                PrereqNo2.Properties.Enabled = False
                PrereqNo2.Value = 1
                Focus.Visible = False
                Focus.Properties.Enabled = False
                Focus.Properties.Items.Clear()
                Focus.SelectedIndex = -1
                Level.Visible = False
                Level.Properties.Enabled = False
                Level.Value = 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub PrereqNo2_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrereqNo2.VisibleChanged
        Try
            If PrereqNo2.Visible Then
                PrereqNo2.Properties.Enabled = True
                PrereqNo2.Properties.MinValue = 1
                PrereqNo2.Properties.MaxValue = 99
                PrereqNo.Visible = False
                PrereqNo.Properties.Enabled = False
                PrereqNo.Value = 1
                Focus.Visible = False
                Focus.Properties.Enabled = False
                Focus.Properties.Items.Clear()
                Focus.SelectedIndex = -1
                Level.Visible = False
                Level.Properties.Enabled = False
                Level.Value = 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Level_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Level.VisibleChanged
        Try
            If Level.Visible Then
                SetLabel("Level")
                Level.Properties.Enabled = True
                Level.Properties.MinValue = 1
                Level.Properties.MaxValue = Rules.Constants.MaxLevels
                Focus.Visible = False
                Focus.Properties.Enabled = False
                Focus.Properties.Items.Clear()
                Focus.SelectedIndex = -1
                PrereqNo.Visible = False
                PrereqNo.Properties.Enabled = False
                PrereqNo.Value = 1
                PrereqNo2.Visible = False
                PrereqNo2.Properties.Enabled = False
                PrereqNo2.Value = 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Focus_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Focus.VisibleChanged
        Try
            If Focus.Visible Then
                SetLabel("Focus")
                Focus.Properties.Enabled = True
                Level.Visible = False
                Level.Properties.Enabled = False
                Level.Value = 1
                PrereqNo.Visible = False
                PrereqNo.Properties.Enabled = False
                PrereqNo.Value = 1
                PrereqNo2.Visible = False
                PrereqNo2.Properties.Enabled = False
                PrereqNo2.Value = 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AtLeast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtLeast.CheckedChanged
        Try
            If AtLeast.Checked = True Then
                AtLeastNo.Properties.Enabled = True
            Else
                AtLeastNo.Properties.Enabled = False
                AtLeastNo.Value = 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ConfigureAtLeast()
        Try
            If Prereqs.Count < 2 Then
                AllRequired.Enabled = False
                AllRequired.Checked = True
                AtLeast.Enabled = False
                AtLeastNo.Properties.Enabled = False
                AtLeastNo.Properties.MaxValue = 1
                AtLeastNo.Value = 1
                Label2.Enabled = False
            Else
                AllRequired.Enabled = True
                AtLeast.Enabled = True
                AtLeastNo.Properties.Enabled = True
                AtLeastNo.Properties.MaxValue = Prereqs.Count - 1
                Label2.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Suggest_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Suggest.CheckedChanged
        Try
            If Suggest.Checked Then SuggestName()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region


End Class

