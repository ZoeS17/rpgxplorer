Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class SpellFailureForm
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
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Verbal As System.Windows.Forms.CheckBox
    Public WithEvents Somatic As System.Windows.Forms.CheckBox
    Public WithEvents Material As System.Windows.Forms.CheckBox
    Public WithEvents Percentage As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.Percentage = New DevExpress.XtraEditors.SpinEdit
        Me.Material = New System.Windows.Forms.CheckBox
        Me.Somatic = New System.Windows.Forms.CheckBox
        Me.Verbal = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Basics.Controls.Add(Me.Percentage)
        Me.Basics.Controls.Add(Me.Material)
        Me.Basics.Controls.Add(Me.Somatic)
        Me.Basics.Controls.Add(Me.Verbal)
        Me.Basics.Controls.Add(Me.Label10)
        Me.Basics.Controls.Add(Me.IndentedLine1)
        Me.Basics.Controls.Add(Me.Label6)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 349)
        Me.Basics.TabIndex = 2
        Me.Basics.Text = "Spell Failure"
        '
        'Percentage
        '
        Me.Percentage.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Percentage.Location = New System.Drawing.Point(90, 15)
        Me.Percentage.Name = "Percentage"
        '
        'Percentage.Properties
        '
        Me.Percentage.Properties.Appearance.Options.UseTextOptions = True
        Me.Percentage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Percentage.Properties.AutoHeight = False
        Me.Percentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Percentage.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Percentage.Properties.IsFloatValue = False
        Me.Percentage.Properties.Mask.BeepOnError = True
        Me.Percentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Percentage.Properties.Mask.ShowPlaceHolders = False
        Me.Percentage.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Percentage.Size = New System.Drawing.Size(50, 21)
        Me.Percentage.TabIndex = 129
        '
        'Material
        '
        Me.Material.Location = New System.Drawing.Point(15, 150)
        Me.Material.Name = "Material"
        Me.Material.Size = New System.Drawing.Size(180, 21)
        Me.Material.TabIndex = 3
        Me.Material.Text = " Material component"
        '
        'Somatic
        '
        Me.Somatic.Location = New System.Drawing.Point(15, 120)
        Me.Somatic.Name = "Somatic"
        Me.Somatic.Size = New System.Drawing.Size(180, 21)
        Me.Somatic.TabIndex = 2
        Me.Somatic.Text = " Somatic component"
        '
        'Verbal
        '
        Me.Verbal.Location = New System.Drawing.Point(15, 90)
        Me.Verbal.Name = "Verbal"
        Me.Verbal.Size = New System.Drawing.Size(180, 21)
        Me.Verbal.TabIndex = 1
        Me.Verbal.Text = " Verbal component"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(225, 21)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Affects spells with the following components"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 127
        Me.IndentedLine1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Spell Failure"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'SpellFailureForm
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
        Me.Name = "SpellFailureForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpellFailureForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

            'Custom Formatting
            Percentage.Properties.DisplayFormat.Format = New PercentFormatter

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
            mObject.Type = Objects.SpellFailureType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Spell Failure"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Spell Failure"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            Percentage.Value = mObject.ElementAsInteger("Percentage")
            If mObject.Element("Verbal") = "Yes" Then Verbal.CheckState = CheckState.Checked Else Verbal.CheckState = CheckState.Unchecked
            If mObject.Element("Somatic") = "Yes" Then Somatic.CheckState = CheckState.Checked Else Somatic.CheckState = CheckState.Unchecked
            If mObject.Element("Material") = "Yes" Then Material.CheckState = CheckState.Checked Else Material.CheckState = CheckState.Unchecked

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim temp As String

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
                mObject.Name = "Spell Failure " & Percentage.Value.ToString & "%"
                mObject.Element("Percentage") = Percentage.Value.ToString
                temp = "("
                If Verbal.CheckState = CheckState.Checked Then
                    temp &= "V"
                    mObject.Element("Verbal") = "Yes"
                Else
                    mObject.Element("Verbal") = ""
                End If
                If Somatic.CheckState = CheckState.Checked Then
                    If temp <> "(" Then temp &= ",S" Else temp &= "S"
                    mObject.Element("Somatic") = "Yes"
                Else
                    mObject.Element("Somatic") = ""
                End If
                If Material.CheckState = CheckState.Checked Then
                    If temp <> "(" Then temp &= ",M" Else temp &= "M"
                    mObject.Element("Material") = "Yes"
                Else
                    mObject.Element("Material") = ""
                End If
                If temp <> "(" Then mObject.Name &= " " & temp & ")"

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

            Validate = Validate And General.ValidateForm(Me.Basics.Controls, Errors)

            General.ValidateFormIndicator(Validate, OK, Errors)

            Return Validate
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class

