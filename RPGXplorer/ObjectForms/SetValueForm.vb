Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SetValueForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents SystemElement As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents SetValue1 As RPGXplorer.SetValue
    Public WithEvents SetValueTab As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SetValueTab = New System.Windows.Forms.TabPage
        Me.SetValue1 = New RPGXplorer.SetValue
        Me.Label4 = New System.Windows.Forms.Label
        Me.SystemElement = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.TabControl1.SuspendLayout()
        Me.SetValueTab.SuspendLayout()
        CType(Me.SystemElement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 400)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 400)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
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
        Me.SetValueTab.Controls.Add(Me.SetValue1)
        Me.SetValueTab.Controls.Add(Me.Label4)
        Me.SetValueTab.Controls.Add(Me.SystemElement)
        Me.SetValueTab.Location = New System.Drawing.Point(4, 22)
        Me.SetValueTab.Name = "SetValueTab"
        Me.SetValueTab.Size = New System.Drawing.Size(407, 344)
        Me.SetValueTab.TabIndex = 2
        Me.SetValueTab.Text = "Set Value"
        '
        'SetValue1
        '
        Me.SetValue1.AbilityMod = ""
        Me.SetValue1.BackColor = System.Drawing.SystemColors.Control
        Me.SetValue1.BaseNumber = 1
        Me.SetValue1.Location = New System.Drawing.Point(15, 45)
        Me.SetValue1.Name = "SetValue1"
        Me.SetValue1.PerLevelNumber = 0
        Me.SetValue1.Size = New System.Drawing.Size(390, 130)
        Me.SetValue1.TabIndex = 114
        Me.SetValue1.TagNumber = 0
        Me.SetValue1.TagString = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Element"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SystemElement
        '
        Me.SystemElement.Location = New System.Drawing.Point(95, 15)
        Me.SystemElement.Name = "SystemElement"
        '
        'SystemElement.Properties
        '
        Me.SystemElement.Properties.AutoHeight = False
        Me.SystemElement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SystemElement.Properties.DropDownRows = 10
        Me.SystemElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SystemElement.Size = New System.Drawing.Size(200, 21)
        Me.SystemElement.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 344)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'SetValueForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SetValueForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SetValueForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SetValueTab.ResumeLayout(False)
        CType(Me.SystemElement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private ElementDataList As General.DataListItem()

    'init
    Public Sub Init()
        Dim ExcludeList As New ArrayList


        'build exclude list
        Dim SetValueObjects As Objects.ObjectDataCollection
        SetValueObjects = mFolder.ChildrenOfType(Objects.SetValueType)

        For Each TempObject As Objects.ObjectData In SetValueObjects
            If Not ExcludeList.Contains(TempObject.GetFKGuid("SystemElement")) Then
                ExcludeList.Add(TempObject.GetFKGuid("SystemElement"))
            End If
        Next

        If mMode = FormMode.Edit Then
            ExcludeList.Remove(mObject.GetFKGuid("SystemElement"))
        End If

        'get allowed element types
        ElementDataList = Rules.Index.DataListXPathExclude(Xml.DBTypes.SystemComponents, " /RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SystemElementType & "' and AllowSet='Yes']", ExcludeList)

        If Not ElementDataList Is Nothing Then
            SystemElement.Properties.Items.AddRange(ElementDataList)
        End If

        SetValue1.Init()

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
            mObject.Type = Objects.SetValueType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Set Value"
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

            SystemElement.SelectedIndex = Rules.Index.GetGuidIndex(ElementDataList, mObject.GetFKGuid("SystemElement"))
            Me.SetValue1.BaseNumber = mObject.ElementAsInteger("BaseNumber")

            If mObject.Element("LevelCheck") = "Yes" Then
                SetValue1.LevelCheck.CheckState = CheckState.Checked
                SetValue1.PerLevelNumber = mObject.ElementAsInteger("PerLevel")
            End If

            If mObject.Element("AbilityCheck") = "Yes" Then
                SetValue1.AbilityCheck.CheckState = CheckState.Checked
                SetValue1.AbilityMod = mObject.Element("AbilityMod")
            End If

            If mObject.Element("TagCheck") = "Yes" Then
                SetValue1.TagCheck.CheckState = CheckState.Checked
                SetValue1.TagNumber = mObject.ElementAsInteger("TagNumber")
                SetValue1.TagString = mObject.Element("TagString")
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
                        CharacterManager.SetAllDirty()
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                mObject.FKElement("SystemElement", SystemElement.Text, "Name", CType(SystemElement.SelectedItem, DataListItem).ObjectGUID)

                mObject.ElementAsInteger("BaseNumber") = SetValue1.BaseNumber

                If SetValue1.AbilityCheck.CheckState = CheckState.Checked Then
                    mObject.Element("AbilityCheck") = "Yes"
                    mObject.Element("AbilityMod") = SetValue1.AbilityMod
                End If

                If SetValue1.LevelCheck.CheckState = CheckState.Checked Then
                    mObject.Element("LevelCheck") = "Yes"
                    mObject.ElementAsInteger("PerLevel") = SetValue1.PerLevelNumber
                End If

                If SetValue1.TagCheck.CheckState = CheckState.Checked Then
                    mObject.Element("TagCheck") = "Yes"
                    mObject.ElementAsInteger("TagNumber") = SetValue1.TagNumber
                    mObject.Element("TagString") = SetValue1.TagString
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
            Validate = General.ValidateForm(Me.SetValueTab.Controls, Errors)
            Validate = Validate And SetValue1.Validate
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control enabling and disabling"

#End Region

End Class
