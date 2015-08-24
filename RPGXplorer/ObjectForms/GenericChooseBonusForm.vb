Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class GenericChooseBonusForm
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
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents ChoiceTab As System.Windows.Forms.TabPage
    Public WithEvents EditChoicesButton As System.Windows.Forms.Button
    Public WithEvents SpecificCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SpecificRadio As System.Windows.Forms.RadioButton
    Public WithEvents ChooseFromListRadio As System.Windows.Forms.RadioButton
    Public WithEvents ChoiceList As DevExpress.XtraEditors.ListBoxControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ChoiceTab = New System.Windows.Forms.TabPage
        Me.ChoiceList = New DevExpress.XtraEditors.ListBoxControl
        Me.ChooseFromListRadio = New System.Windows.Forms.RadioButton
        Me.SpecificRadio = New System.Windows.Forms.RadioButton
        Me.EditChoicesButton = New System.Windows.Forms.Button
        Me.SpecificCombo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ChoiceTab.SuspendLayout()
        CType(Me.ChoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecificCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.ChoiceTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ChoiceTab
        '
        Me.ChoiceTab.Controls.Add(Me.ChoiceList)
        Me.ChoiceTab.Controls.Add(Me.ChooseFromListRadio)
        Me.ChoiceTab.Controls.Add(Me.SpecificRadio)
        Me.ChoiceTab.Controls.Add(Me.EditChoicesButton)
        Me.ChoiceTab.Controls.Add(Me.SpecificCombo)
        Me.ChoiceTab.Location = New System.Drawing.Point(4, 22)
        Me.ChoiceTab.Name = "ChoiceTab"
        Me.ChoiceTab.Size = New System.Drawing.Size(407, 349)
        Me.ChoiceTab.TabIndex = 2
        '
        'ChoiceList
        '
        Me.ChoiceList.Enabled = False
        Me.ChoiceList.Location = New System.Drawing.Point(40, 105)
        Me.ChoiceList.Name = "ChoiceList"
        Me.ChoiceList.Size = New System.Drawing.Size(225, 225)
        Me.ChoiceList.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ChoiceList.TabIndex = 4
        Me.ChoiceList.TabStop = False
        '
        'ChooseFromListRadio
        '
        Me.ChooseFromListRadio.Location = New System.Drawing.Point(15, 75)
        Me.ChooseFromListRadio.Name = "ChooseFromListRadio"
        Me.ChooseFromListRadio.Size = New System.Drawing.Size(125, 24)
        Me.ChooseFromListRadio.TabIndex = 2
        Me.ChooseFromListRadio.Text = "Choose From List"
        '
        'SpecificRadio
        '
        Me.SpecificRadio.Location = New System.Drawing.Point(15, 15)
        Me.SpecificRadio.Name = "SpecificRadio"
        Me.SpecificRadio.TabIndex = 0
        Me.SpecificRadio.Text = "Specific"
        '
        'EditChoicesButton
        '
        Me.EditChoicesButton.Enabled = False
        Me.EditChoicesButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditChoicesButton.Location = New System.Drawing.Point(280, 105)
        Me.EditChoicesButton.Name = "EditChoicesButton"
        Me.EditChoicesButton.Size = New System.Drawing.Size(110, 24)
        Me.EditChoicesButton.TabIndex = 3
        Me.EditChoicesButton.Text = "Edit Choices"
        '
        'SpecificCombo
        '
        Me.SpecificCombo.Enabled = False
        Me.SpecificCombo.Location = New System.Drawing.Point(40, 45)
        Me.SpecificCombo.Name = "SpecificCombo"
        '
        'SpecificCombo.Properties
        '
        Me.SpecificCombo.Properties.AutoHeight = False
        Me.SpecificCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpecificCombo.Properties.DropDownRows = 10
        Me.SpecificCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpecificCombo.Size = New System.Drawing.Size(225, 21)
        Me.SpecificCombo.TabIndex = 1
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
        'GenericChooseBonusForm
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
        Me.Name = "GenericChooseBonusForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenericChooseBonusForm"
        Me.TabControl1.ResumeLayout(False)
        Me.ChoiceTab.ResumeLayout(False)
        CType(Me.ChoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecificCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'vars
    Private Index As DataListItem()
    Private _List As Objects.ObjectDataCollection
    Private _ObjectType As String
    Private _Friendly As String
    Private Choices As New Objects.ObjectDataCollection
    Private _IsValidAdd As ConstructListDialog.IsValidAdd

    'init
    Public Sub Init()
        Try
            Index = Rules.Index.DataList(_List)

            'initialise controls
            SpecificCombo.Properties.Items.AddRange(Index)
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData, ByVal ObjectType As String, ByVal List As Objects.ObjectDataCollection, ByVal Friendly As String, Optional ByRef IsValidAdd As ConstructListDialog.IsValidAdd = Nothing)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add
            _ObjectType = ObjectType
            _List = List
            _Friendly = Friendly
            _IsValidAdd = IsValidAdd

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = ObjectType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Specific/Choose " & Friendly
            ChoiceTab.Text = Friendly
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls
            Select Case Folder.Type
                Case Objects.DomainDefinitionType, Objects.PsionicSpecializationDefinitionType
                    ChooseFromListRadio.Visible = False
                    EditChoicesButton.Visible = False
                    ChoiceList.Visible = False
            End Select

            SpecificRadio.Checked = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData, ByVal ObjectType As String, ByVal List As Objects.ObjectDataCollection, ByVal Friendly As String, Optional ByRef IsValidAdd As ConstructListDialog.IsValidAdd = Nothing)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit
            _ObjectType = ObjectType
            _List = List
            _Friendly = Friendly
            _IsValidAdd = IsValidAdd

            'init form
            Me.Text = "Edit Specific/Choose " & Friendly
            ChoiceTab.Text = Friendly
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            If mObject.Element("ChoiceType") = "Specific" Then
                SpecificRadio.Checked = True
                SpecificCombo.SelectedIndex = Rules.Index.GetGuidIndex(Index, mObject.GetFKGuid("Specific"))
            Else
                ChooseFromListRadio.Checked = True
                For n As Integer = 1 To mObject.ElementAsInteger("ChoiceCount")
                    Choices.Add(mObject.GetFKObject("Choice" & n.ToString))
                Next
                ChoiceList.Items.AddRange(Choices.ToArrayList.ToArray)
            End If

            If Obj.Parent.Type = Objects.DomainDefinitionType Then
                ChooseFromListRadio.Visible = False
                EditChoicesButton.Visible = False
                ChoiceList.Visible = False
            End If

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
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                If SpecificRadio.Checked Then
                    mObject.Element("ChoiceType") = "Specific"
                    mObject.FKElement("Specific", SpecificCombo.Text, "Name", CType(SpecificCombo.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.Element("ChoiceType") = "Choice"
                    mObject.ElementAsInteger("ChoiceCount") = ChoiceList.Items.Count

                    Dim n As Integer = 1

                    For Each Item As Objects.ObjectData In ChoiceList.Items
                        mObject.FKElement("Choice" & n.ToString, Item.Name, "Name", Item.ObjectGUID)
                        n += 1
                    Next
                End If

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
            Validate = General.ValidateForm(Me.ChoiceTab.Controls, Errors)

            If ChoiceList.Items.Count < 2 And ChoiceList.Enabled Then
                Errors.SetError(ChoiceList, General.ValidationAtLeast2Required)
                Validate = False
            Else
                Errors.SetError(ChoiceList, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Event Handlers"

    Private Sub SpecificRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecificRadio.CheckedChanged
        Try
            If SpecificRadio.Checked Then
                SpecificCombo.Enabled = True
            Else
                SpecificCombo.Enabled = False
                SpecificCombo.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ChooseFromListRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseFromListRadio.CheckedChanged
        Try
            If ChooseFromListRadio.Checked Then
                ChoiceList.Enabled = True
                EditChoicesButton.Enabled = True
            Else
                ChoiceList.Enabled = False
                EditChoicesButton.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EditChoicesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditChoicesButton.Click
        Try
            Dim EditChoiceForm As New ConstructListDialog

            EditChoiceForm.Init("Edit " & _Friendly & " Choices", "Select Choices", "Select " & _Friendly & "s", _Friendly, "Choices", _IsValidAdd)

            _List.RemoveList(Choices)

            EditChoiceForm.InitTextList(_List.ToArrayList, Choices.ToArrayList)
            If EditChoiceForm.ShowDialog() = DialogResult.OK Then
                Choices.Clear()
                For Each Obj As Objects.ObjectData In EditChoiceForm.ListBFinal
                    Choices.Add(Obj)
                Next
            End If

            ChoiceList.Items.Clear()
            ChoiceList.Items.AddRange(Choices.ToArrayList.ToArray)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

