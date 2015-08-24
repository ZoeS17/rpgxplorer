Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SimpleSelectorForm
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
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents SelectDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.SelectDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.SelectDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(415, 5)
        Me.IndentedLine2.TabIndex = 90
        Me.IndentedLine2.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 65)
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
        Me.OK.Location = New System.Drawing.Point(280, 65)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(85, 21)
        Me.ObjLabel.TabIndex = 92
        Me.ObjLabel.Text = "Label"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectDropdown
        '
        Me.SelectDropdown.Location = New System.Drawing.Point(100, 15)
        Me.SelectDropdown.Name = "SelectDropdown"
        '
        'SelectDropdown.Properties
        '
        Me.SelectDropdown.Properties.AutoHeight = False
        Me.SelectDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SelectDropdown.Properties.DropDownRows = 10
        Me.SelectDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SelectDropdown.Size = New System.Drawing.Size(320, 21)
        Me.SelectDropdown.TabIndex = 0
        '
        'SimpleSelectorForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 103)
        Me.Controls.Add(Me.SelectDropdown)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SimpleSelectorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenericSimpleForm"
        CType(Me.SelectDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mType As String
    Private mSelectType As String
    Private mFKElementName As String
    Private mExcludeList As ArrayList

    'index
    Private ObjIndex As DataListItem()

    'init
    Public Sub Init()
        Try
            'init index
            If mExcludeList Is Nothing Then
                ObjIndex = Rules.Index.DataList(XML.MapTypeToDB(mSelectType), mSelectType)
            Else
                If mMode = FormMode.Edit Then
                    Dim FKGuid As Objects.ObjectKey = mObject.GetFKGuid(mFKElementName)
                    If mExcludeList.Contains(FKGuid) Then mExcludeList.Remove(FKGuid)
                End If
                ObjIndex = Rules.Index.DataListExclude(XML.MapTypeToDB(mSelectType), mSelectType, mExcludeList)
            End If

            'initialise controls
            If Not ObjIndex Is Nothing Then
                SelectDropdown.Properties.Items.AddRange(ObjIndex)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData, ByVal SelectType As String, ByVal Type As String, ByVal ShortFriendly As String, ByVal FKElementName As String, Optional ByVal ExclusionGuidList As ArrayList = Nothing)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add
            mType = Type
            mSelectType = SelectType
            mFKElementName = FKElementName
            mExcludeList = ExclusionGuidList

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = mType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add " & Objects.ObjectTypes.Item(Type).Friendly
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls
            ObjLabel.Text = ShortFriendly

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData, ByVal SelectType As String, ByVal Type As String, ByVal ShortFriendly As String, ByVal FKElementName As String, Optional ByVal ExclusionGuidList As ArrayList = Nothing)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit
            mType = Type
            mSelectType = SelectType
            mFKElementName = FKElementName
            mExcludeList = ExclusionGuidList

            'init form
            Me.Text = "Edit " & Objects.ObjectTypes.Item(Type).Friendly
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjLabel.Text = ShortFriendly
            SelectDropdown.SelectedIndex = Rules.Index.GetGuidIndex(ObjIndex, Obj.GetFKGuid(mFKElementName))

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
                mObject.Name = SelectDropdown.Text
                mObject.FKElement(mFKElementName, SelectDropdown.Text, "Name", CType(SelectDropdown.SelectedItem, DataListItem).ObjectGUID)
                mObject.HTML = ""
                mObject.HTMLGUID = Objects.ObjectKey.Empty

                'write obj and close form
                mObject.Save()

                'selective updates
                Select Case mType
                    Case Objects.FeatureDefinitionType
                        'if this feature has a nonability score on it, we need to update any Monster-Race/Race that it is placed on

                End Select


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

            Validate = General.ValidateForm(Me.Controls, Me.Errors)
            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class
