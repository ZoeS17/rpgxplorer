Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class MonsterTypeForm
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
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Type As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SubType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents RemoveSubtype As System.Windows.Forms.Button
    Public WithEvents AddSubtype As System.Windows.Forms.Button
    Public WithEvents SubtypesList As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents MonsterTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MonsterTab = New System.Windows.Forms.TabPage
        Me.SubtypesList = New DevExpress.XtraEditors.ListBoxControl
        Me.RemoveSubtype = New System.Windows.Forms.Button
        Me.AddSubtype = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label16 = New System.Windows.Forms.Label
        Me.SubType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Type = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.MonsterTab.SuspendLayout()
        CType(Me.SubtypesList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.MonsterTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'MonsterTab
        '
        Me.MonsterTab.Controls.Add(Me.SubtypesList)
        Me.MonsterTab.Controls.Add(Me.RemoveSubtype)
        Me.MonsterTab.Controls.Add(Me.AddSubtype)
        Me.MonsterTab.Controls.Add(Me.IndentedLine2)
        Me.MonsterTab.Controls.Add(Me.Label16)
        Me.MonsterTab.Controls.Add(Me.SubType)
        Me.MonsterTab.Controls.Add(Me.Type)
        Me.MonsterTab.Controls.Add(Me.Label11)
        Me.MonsterTab.Location = New System.Drawing.Point(4, 22)
        Me.MonsterTab.Name = "MonsterTab"
        Me.MonsterTab.Size = New System.Drawing.Size(407, 349)
        Me.MonsterTab.TabIndex = 0
        Me.MonsterTab.Text = "Monster Type"
        '
        'SubtypesList
        '
        Me.SubtypesList.ItemHeight = 15
        Me.SubtypesList.Location = New System.Drawing.Point(15, 95)
        Me.SubtypesList.Name = "SubtypesList"
        Me.SubtypesList.Size = New System.Drawing.Size(250, 235)
        Me.SubtypesList.TabIndex = 2
        '
        'RemoveSubtype
        '
        Me.RemoveSubtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSubtype.Location = New System.Drawing.Point(280, 125)
        Me.RemoveSubtype.Name = "RemoveSubtype"
        Me.RemoveSubtype.Size = New System.Drawing.Size(110, 24)
        Me.RemoveSubtype.TabIndex = 4
        Me.RemoveSubtype.Text = "Remove Subtype"
        '
        'AddSubtype
        '
        Me.AddSubtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubtype.Location = New System.Drawing.Point(280, 95)
        Me.AddSubtype.Name = "AddSubtype"
        Me.AddSubtype.Size = New System.Drawing.Size(110, 24)
        Me.AddSubtype.TabIndex = 3
        Me.AddSubtype.Text = "Add Subtype"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(16, 80)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 183
        Me.IndentedLine2.TabStop = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(15, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 21)
        Me.Label16.TabIndex = 182
        Me.Label16.Text = "Subtype"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubType
        '
        Me.SubType.CausesValidation = False
        Me.SubType.Enabled = False
        Me.SubType.Location = New System.Drawing.Point(75, 45)
        Me.SubType.Name = "SubType"
        Me.SubType.Properties.AutoHeight = False
        Me.SubType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubType.Properties.DropDownRows = 10
        Me.SubType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SubType.Size = New System.Drawing.Size(150, 21)
        Me.SubType.TabIndex = 1
        '
        'Type
        '
        Me.Type.EditValue = ""
        Me.Type.Location = New System.Drawing.Point(75, 15)
        Me.Type.Name = "Type"
        Me.Type.Properties.AutoHeight = False
        Me.Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Type.Size = New System.Drawing.Size(150, 21)
        Me.Type.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'MonsterTypeForm
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
        Me.Name = "MonsterTypeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonsterType"
        Me.TabControl1.ResumeLayout(False)
        Me.MonsterTab.ResumeLayout(False)
        CType(Me.SubtypesList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private Subtypes As New Collections.Specialized.StringCollection

    'init
    Public Sub Init()
        Try
            Type.Properties.Items.AddRange(Rules.Lists.MonsterDefinitionTypes)
            SubType.Properties.Items.AddRange(Rules.Lists.MonsterSubtypes)

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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MonsterTypes)
            mObject.Type = Objects.MonsterTypeType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Monster Type"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim sortarray As String()
        Dim inputstring As String

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init for
            Me.Text = "Edit Monster Type"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            Type.Text = mObject.Element("MonsterType")
            inputstring = mObject.Element("MonsterSubtypes")

            If inputstring <> "" Then
                sortarray = inputstring.Split(",".ToCharArray)
                For Each temp As String In sortarray
                    Subtypes.Add(temp.Trim)
                    SubtypesList.Items.Add(temp.Trim)
                Next
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Temp As String

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
                If Subtypes.Count > 0 Then
                    Temp = GetName()
                    mObject.Name = (Type.Text & " (" & Temp & ")")
                    mObject.Element("MonsterType") = Type.Text
                    mObject.Element("MonsterSubtypes") = Temp
                Else
                    mObject.Name = Type.Text
                    mObject.Element("MonsterSubtypes") = ""
                End If

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
        Dim Temp As String

        Try
            Validate = General.ValidateForm(MonsterTab.Controls, Errors)

            If Subtypes.Count > 0 Then
                Temp = Type.Text & " (" & GetName() & ")"
            Else
                Temp = Type.Text
            End If

            If Temp <> "" And Temp <> mObject.Name Then
                If XML.ObjectExists(Temp, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(Type, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(Type, "")
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Tab Code"

    'get name
    Private Function GetName() As String
        Dim sortarray As String()
        GetName = ""

        Try
            ReDim sortarray(Subtypes.Count - 1)
            Subtypes.CopyTo(sortarray, 0)
            Array.Sort(sortarray)

            For Each temp As String In sortarray
                GetName = GetName & temp & ", "
            Next

            GetName = GetName.TrimEnd(", ".ToCharArray)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Add subtype to the current creature type
    Private Sub AddSubtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubtype.Click
        Try
            Dim Str As String

            If SubType.SelectedIndex = -1 Then Exit Sub

            Str = SubType.Text

            If Subtypes.Contains(Str) Then
                General.ShowInfoDialog("This subtype has already been added.")
            Else
                Subtypes.Add(Str)
                SubtypesList.Items.Add(Str)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Removesubtype form the current creature type
    Private Sub RemoveSubtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSubtype.Click
        Try
            If SubtypesList.SelectedIndex = -1 Then Exit Sub

            Subtypes.Remove(SubtypesList.Text)
            SubtypesList.Items.Remove(SubtypesList.SelectedItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

    'Enable the Subtype controls, when a main type is selected
    Private Sub Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type.SelectedIndexChanged
        Try
            If Type.Text <> "" Then
                SubType.Properties.Enabled = True
            Else
                SubType.Properties.Enabled = False
                SubType.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
