Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class RegenerationForm
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
    Public WithEvents HPPerRound As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents RegenerationRadio As System.Windows.Forms.RadioButton
    Public WithEvents FastHealingRadio As System.Windows.Forms.RadioButton
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.FastHealingRadio = New System.Windows.Forms.RadioButton
        Me.RegenerationRadio = New System.Windows.Forms.RadioButton
        Me.HPPerRound = New DevExpress.XtraEditors.SpinEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.HPPerRound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cancel.TabIndex = 1
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
        Me.OK.TabIndex = 0
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
        Me.Basics.Controls.Add(Me.FastHealingRadio)
        Me.Basics.Controls.Add(Me.RegenerationRadio)
        Me.Basics.Controls.Add(Me.HPPerRound)
        Me.Basics.Controls.Add(Me.Label8)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 349)
        Me.Basics.TabIndex = 2
        Me.Basics.Text = "Regeneration"
        '
        'FastHealingRadio
        '
        Me.FastHealingRadio.Location = New System.Drawing.Point(15, 45)
        Me.FastHealingRadio.Name = "FastHealingRadio"
        Me.FastHealingRadio.Size = New System.Drawing.Size(104, 21)
        Me.FastHealingRadio.TabIndex = 1
        Me.FastHealingRadio.Text = " Fast healing"
        '
        'RegenerationRadio
        '
        Me.RegenerationRadio.Location = New System.Drawing.Point(15, 15)
        Me.RegenerationRadio.Name = "RegenerationRadio"
        Me.RegenerationRadio.Size = New System.Drawing.Size(104, 21)
        Me.RegenerationRadio.TabIndex = 0
        Me.RegenerationRadio.Text = " Regeneration"
        '
        'HPPerRound
        '
        Me.HPPerRound.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HPPerRound.Location = New System.Drawing.Point(125, 75)
        Me.HPPerRound.Name = "HPPerRound"
        '
        'HPPerRound.Properties
        '
        Me.HPPerRound.Properties.Appearance.Options.UseTextOptions = True
        Me.HPPerRound.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.HPPerRound.Properties.AutoHeight = False
        Me.HPPerRound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HPPerRound.Properties.IsFloatValue = False
        Me.HPPerRound.Properties.Mask.BeepOnError = True
        Me.HPPerRound.Properties.Mask.EditMask = "999"
        Me.HPPerRound.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.HPPerRound.Properties.Mask.ShowPlaceHolders = False
        Me.HPPerRound.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.HPPerRound.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HPPerRound.Size = New System.Drawing.Size(50, 21)
        Me.HPPerRound.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 21)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "Hit points per round"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'RegenerationForm
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
        Me.Name = "RegenerationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegenerationForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.HPPerRound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
            mObject.Type = Objects.RegenerationType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Regeneration"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls
            RegenerationRadio.Checked = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim temp As String = ""

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Regeneration"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            If mObject.Element("RegenerationType") = "Regeneration" Then RegenerationRadio.Checked = True Else FastHealingRadio.Checked = True
            HPPerRound.EditValue = mObject.Element("HPPerRound")

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
                If RegenerationRadio.Checked = True Then
                    mObject.Name = "Regeneration (" & HPPerRound.Text & " HP per round)"
                    mObject.Element("RegenerationType") = "Regeneration"
                Else
                    mObject.Name = "Fast Healing (" & HPPerRound.Text & " HP per round)"
                    mObject.Element("RegenerationType") = "Fast Healing"
                End If
                mObject.Element("HPPerRound") = HPPerRound.Text

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                General.MainExplorer.RefreshPanel()
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
            Validate = True
            General.ValidateFormIndicator(Validate, OK, Errors)
            Return Validate
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class

