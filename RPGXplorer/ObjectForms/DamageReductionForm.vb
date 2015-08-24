Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class DamageReductionForm
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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents OvercomeByType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DR As DevExpress.XtraEditors.SpinEdit
    Public WithEvents DamageType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents JunctionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents OvercomeByType2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageType2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageType2Label As System.Windows.Forms.Label
    Public WithEvents OvercomeByType2Label As System.Windows.Forms.Label
    Public WithEvents DamageTypeLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.DamageType2Label = New System.Windows.Forms.Label
        Me.OvercomeByType2Label = New System.Windows.Forms.Label
        Me.JunctionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageType2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.OvercomeByType2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageTypeLabel = New System.Windows.Forms.Label
        Me.DamageType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DR = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.OvercomeByType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.JunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageType2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OvercomeByType2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OvercomeByType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.Basics)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.DamageType2Label)
        Me.Basics.Controls.Add(Me.OvercomeByType2Label)
        Me.Basics.Controls.Add(Me.JunctionDropdown)
        Me.Basics.Controls.Add(Me.DamageType2)
        Me.Basics.Controls.Add(Me.OvercomeByType2)
        Me.Basics.Controls.Add(Me.DamageTypeLabel)
        Me.Basics.Controls.Add(Me.DamageType)
        Me.Basics.Controls.Add(Me.DR)
        Me.Basics.Controls.Add(Me.Label1)
        Me.Basics.Controls.Add(Me.OvercomeByType)
        Me.Basics.Controls.Add(Me.Label2)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 349)
        Me.Basics.TabIndex = 2
        Me.Basics.Text = "Damage Reduction"
        '
        'DamageType2Label
        '
        Me.DamageType2Label.BackColor = System.Drawing.SystemColors.Control
        Me.DamageType2Label.Enabled = False
        Me.DamageType2Label.Location = New System.Drawing.Point(15, 165)
        Me.DamageType2Label.Name = "DamageType2Label"
        Me.DamageType2Label.Size = New System.Drawing.Size(75, 21)
        Me.DamageType2Label.TabIndex = 121
        Me.DamageType2Label.Text = "Damage type"
        Me.DamageType2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OvercomeByType2Label
        '
        Me.OvercomeByType2Label.BackColor = System.Drawing.SystemColors.Control
        Me.OvercomeByType2Label.Enabled = False
        Me.OvercomeByType2Label.Location = New System.Drawing.Point(15, 135)
        Me.OvercomeByType2Label.Name = "OvercomeByType2Label"
        Me.OvercomeByType2Label.Size = New System.Drawing.Size(75, 21)
        Me.OvercomeByType2Label.TabIndex = 120
        Me.OvercomeByType2Label.Text = "Overcome by"
        Me.OvercomeByType2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JunctionDropdown
        '
        Me.JunctionDropdown.CausesValidation = False
        Me.JunctionDropdown.Enabled = False
        Me.JunctionDropdown.Location = New System.Drawing.Point(100, 105)
        Me.JunctionDropdown.Name = "JunctionDropdown"
        '
        'JunctionDropdown.Properties
        '
        Me.JunctionDropdown.Properties.AutoHeight = False
        Me.JunctionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JunctionDropdown.Properties.DropDownRows = 10
        Me.JunctionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.JunctionDropdown.Size = New System.Drawing.Size(65, 21)
        Me.JunctionDropdown.TabIndex = 119
        '
        'DamageType2
        '
        Me.DamageType2.Enabled = False
        Me.DamageType2.Location = New System.Drawing.Point(100, 165)
        Me.DamageType2.Name = "DamageType2"
        '
        'DamageType2.Properties
        '
        Me.DamageType2.Properties.AutoHeight = False
        Me.DamageType2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageType2.Properties.DropDownRows = 10
        Me.DamageType2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageType2.Size = New System.Drawing.Size(200, 21)
        Me.DamageType2.TabIndex = 118
        '
        'OvercomeByType2
        '
        Me.OvercomeByType2.Enabled = False
        Me.OvercomeByType2.Location = New System.Drawing.Point(100, 135)
        Me.OvercomeByType2.Name = "OvercomeByType2"
        '
        'OvercomeByType2.Properties
        '
        Me.OvercomeByType2.Properties.AutoHeight = False
        Me.OvercomeByType2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OvercomeByType2.Properties.DropDownRows = 10
        Me.OvercomeByType2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.OvercomeByType2.Size = New System.Drawing.Size(200, 21)
        Me.OvercomeByType2.TabIndex = 117
        '
        'DamageTypeLabel
        '
        Me.DamageTypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DamageTypeLabel.Enabled = False
        Me.DamageTypeLabel.Location = New System.Drawing.Point(15, 75)
        Me.DamageTypeLabel.Name = "DamageTypeLabel"
        Me.DamageTypeLabel.Size = New System.Drawing.Size(75, 21)
        Me.DamageTypeLabel.TabIndex = 116
        Me.DamageTypeLabel.Text = "Damage type"
        Me.DamageTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DamageType
        '
        Me.DamageType.Enabled = False
        Me.DamageType.Location = New System.Drawing.Point(100, 75)
        Me.DamageType.Name = "DamageType"
        '
        'DamageType.Properties
        '
        Me.DamageType.Properties.AutoHeight = False
        Me.DamageType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageType.Properties.DropDownRows = 10
        Me.DamageType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageType.Size = New System.Drawing.Size(200, 21)
        Me.DamageType.TabIndex = 3
        '
        'DR
        '
        Me.DR.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DR.Location = New System.Drawing.Point(100, 15)
        Me.DR.Name = "DR"
        '
        'DR.Properties
        '
        Me.DR.Properties.Appearance.Options.UseTextOptions = True
        Me.DR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DR.Properties.AutoHeight = False
        Me.DR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DR.Properties.IsFloatValue = False
        Me.DR.Properties.Mask.EditMask = "d"
        Me.DR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DR.Properties.MaxValue = New Decimal(New Integer() {500, 0, 0, 0})
        Me.DR.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DR.Size = New System.Drawing.Size(70, 21)
        Me.DR.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Overcome by"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OvercomeByType
        '
        Me.OvercomeByType.Location = New System.Drawing.Point(100, 45)
        Me.OvercomeByType.Name = "OvercomeByType"
        '
        'OvercomeByType.Properties
        '
        Me.OvercomeByType.Properties.AutoHeight = False
        Me.OvercomeByType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OvercomeByType.Properties.DropDownRows = 10
        Me.OvercomeByType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.OvercomeByType.Size = New System.Drawing.Size(200, 21)
        Me.OvercomeByType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Reduction"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'DamageReductionForm
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
        Me.Name = "DamageReductionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DamageReductionForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.JunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageType2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OvercomeByType2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OvercomeByType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()

        Try
            'initialise controls
            OvercomeByType.Properties.Items.AddRange(Rules.Lists.DROvercomeType)
            DamageType.Properties.Items.AddRange(Rules.Lists.DamageTypesDR)

            JunctionDropdown.Properties.Items.AddRange(Rules.Lists.JunctionTypes)

            OvercomeByType2.Properties.Items.AddRange(Rules.Lists.DROvercomeType)
            DamageType2.Properties.Items.AddRange(Rules.Lists.DamageTypesDR)

            'init propertiestab
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
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Damage Reduction"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls

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
            Me.Text = "Edit Damage Reduction"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            DR.Text = mObject.Element("Reduction")

            OvercomeByType.Text = mObject.Element("DROvercomeByType")
            DamageType.Text = mObject.Element("DamageType")

            JunctionDropdown.Text = mObject.Element("Junction")

            OvercomeByType2.Text = mObject.Element("DROvercomeByType2")
            DamageType2.Text = mObject.Element("DamageType2")

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
                End Select

                'updates common to add and edit
                mObject.Type = Objects.DamageReductionType
                mObject.Name = "DR " & DR.Text & "/"

                If OvercomeByType.Text = "Damage Type" Then
                    mObject.Name &= DamageType.Text
                Else
                    mObject.Name &= OvercomeByType.Text
                End If

                If JunctionDropdown.Text <> "" Then
                    mObject.Name &= (" " & JunctionDropdown.Text & " ")

                    If OvercomeByType2.Text = "Damage Type" Then
                        mObject.Name &= DamageType2.Text
                    Else
                        mObject.Name &= OvercomeByType2.Text
                    End If

                End If

                mObject.Element("Reduction") = DR.Text

                'first pair
                mObject.Element("DROvercomeByType") = OvercomeByType.Text
                mObject.Element("DamageType") = DamageType.Text

                'junction
                mObject.Element("Junction") = JunctionDropdown.Text

                'second pair
                mObject.Element("DROvercomeByType2") = OvercomeByType2.Text
                mObject.Element("DamageType2") = DamageType2.Text

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
            Validate = General.ValidateForm(Basics.Controls, Errors)
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control enabling and disabling"

    Private Sub OvercomeByType_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OvercomeByType.EditValueChanged
        Try
            If OvercomeByType.Text = "Damage Type" Then
                DamageTypeLabel.Enabled = True
                DamageType.Properties.Enabled = True
            Else
                DamageTypeLabel.Enabled = False
                DamageType.Properties.Enabled = False
                DamageType.SelectedIndex = -1
            End If

            OvercomeByType2.Properties.Items.Clear()
            OvercomeByType2.Properties.Items.AddRange(Rules.Lists.DROvercomeType)

            'always remove the - option for the second dropdown
            OvercomeByType2.Properties.Items.Remove("-")

            If OvercomeByType.Text = "-" Then
                JunctionDropdown.Properties.Enabled = False
                JunctionDropdown.SelectedIndex = -1
                Exit Sub
            End If

            If OvercomeByType.Text = "Damage Type" Then
                JunctionDropdown.Properties.Enabled = True
                Exit Sub
            End If

            If OvercomeByType.Text <> "" Then
                JunctionDropdown.Properties.Enabled = True
                OvercomeByType2.Properties.Items.Remove(OvercomeByType.SelectedItem)
                If OvercomeByType.Text = OvercomeByType2.Text Then JunctionDropdown.SelectedIndex = -1
                Exit Sub
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DamageType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageType.SelectedIndexChanged
        Try

            'reset the other damage type dropdow
            DamageType2.Properties.Items.Clear()
            DamageType2.Properties.Items.AddRange(Rules.Lists.DamageTypesDR)

            If DamageType.Text <> "" Then
                DamageType2.Properties.Items.Remove(DamageType.SelectedItem)
                If DamageType.Text = DamageType2.Text Then
                    DamageType2.SelectedIndex = -1
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable the DamageDropdown2 control if a non-null option is selected
    Private Sub JunctionDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JunctionDropdown.SelectedIndexChanged
        Try
            If JunctionDropdown.Text <> "" Then
                OvercomeByType2Label.Enabled = True
                OvercomeByType2.Properties.Enabled = True
            Else
                OvercomeByType2Label.Enabled = False
                OvercomeByType2.Properties.Enabled = False
                OvercomeByType2.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OvercomeByType2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvercomeByType2.SelectedIndexChanged
        Try
            If OvercomeByType2.Text = "Damage Type" Then
                DamageType2Label.Enabled = True
                DamageType2.Properties.Enabled = True
            Else
                DamageType2Label.Enabled = False
                DamageType2.Properties.Enabled = False
                DamageType2.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class