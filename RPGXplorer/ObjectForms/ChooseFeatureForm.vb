Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ChooseFeatureForm
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
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents RemoveFromGroup As System.Windows.Forms.Button
    Public WithEvents AddToGroup As System.Windows.Forms.Button
    Public WithEvents FeatureList As RPGXplorer.ListBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents FeatureDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents ChooseFeatureTab As System.Windows.Forms.TabPage
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents BonusFeat As System.Windows.Forms.CheckBox
    Public WithEvents Override As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ChooseFeatureTab = New System.Windows.Forms.TabPage
        Me.Override = New System.Windows.Forms.CheckBox
        Me.BonusFeat = New System.Windows.Forms.CheckBox
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.RemoveFromGroup = New System.Windows.Forms.Button
        Me.AddToGroup = New System.Windows.Forms.Button
        Me.FeatureList = New RPGXplorer.ListBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.FeatureDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ChooseFeatureTab.SuspendLayout()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeatureDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.ChooseFeatureTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ChooseFeatureTab
        '
        Me.ChooseFeatureTab.Controls.Add(Me.Override)
        Me.ChooseFeatureTab.Controls.Add(Me.BonusFeat)
        Me.ChooseFeatureTab.Controls.Add(Me.ObjectName)
        Me.ChooseFeatureTab.Controls.Add(Me.Label2)
        Me.ChooseFeatureTab.Controls.Add(Me.IndentedLine1)
        Me.ChooseFeatureTab.Controls.Add(Me.RemoveFromGroup)
        Me.ChooseFeatureTab.Controls.Add(Me.AddToGroup)
        Me.ChooseFeatureTab.Controls.Add(Me.FeatureList)
        Me.ChooseFeatureTab.Controls.Add(Me.Label12)
        Me.ChooseFeatureTab.Controls.Add(Me.FeatureDropdown)
        Me.ChooseFeatureTab.Location = New System.Drawing.Point(4, 22)
        Me.ChooseFeatureTab.Name = "ChooseFeatureTab"
        Me.ChooseFeatureTab.Size = New System.Drawing.Size(407, 349)
        Me.ChooseFeatureTab.TabIndex = 4
        Me.ChooseFeatureTab.Text = "Choose Feature"
        '
        'Override
        '
        Me.Override.Location = New System.Drawing.Point(255, 45)
        Me.Override.Name = "Override"
        Me.Override.Size = New System.Drawing.Size(140, 21)
        Me.Override.TabIndex = 157
        Me.Override.Text = "Override prerequisites"
        '
        'BonusFeat
        '
        Me.BonusFeat.Location = New System.Drawing.Point(255, 15)
        Me.BonusFeat.Name = "BonusFeat"
        Me.BonusFeat.Size = New System.Drawing.Size(135, 21)
        Me.BonusFeat.TabIndex = 1
        Me.BonusFeat.Text = "Add bonus feat option"
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(70, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(150, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 154
        Me.IndentedLine1.TabStop = False
        '
        'RemoveFromGroup
        '
        Me.RemoveFromGroup.CausesValidation = False
        Me.RemoveFromGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveFromGroup.Location = New System.Drawing.Point(280, 125)
        Me.RemoveFromGroup.Name = "RemoveFromGroup"
        Me.RemoveFromGroup.Size = New System.Drawing.Size(110, 24)
        Me.RemoveFromGroup.TabIndex = 4
        Me.RemoveFromGroup.Text = "Remove Choice"
        '
        'AddToGroup
        '
        Me.AddToGroup.CausesValidation = False
        Me.AddToGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddToGroup.Location = New System.Drawing.Point(280, 95)
        Me.AddToGroup.Name = "AddToGroup"
        Me.AddToGroup.Size = New System.Drawing.Size(110, 24)
        Me.AddToGroup.TabIndex = 3
        Me.AddToGroup.Text = "Add Choice"
        '
        'FeatureList
        '
        Me.FeatureList.CausesValidation = False
        Me.FeatureList.Location = New System.Drawing.Point(15, 95)
        Me.FeatureList.Name = "FeatureList"
        Me.FeatureList.Size = New System.Drawing.Size(250, 240)
        Me.FeatureList.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(15, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 21)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Feature"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FeatureDropdown
        '
        Me.FeatureDropdown.CausesValidation = False
        Me.FeatureDropdown.Location = New System.Drawing.Point(70, 45)
        Me.FeatureDropdown.Name = "FeatureDropdown"
        '
        'FeatureDropdown.Properties
        '
        Me.FeatureDropdown.Properties.AutoHeight = False
        Me.FeatureDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatureDropdown.Properties.DropDownRows = 10
        Me.FeatureDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatureDropdown.Size = New System.Drawing.Size(150, 21)
        Me.FeatureDropdown.TabIndex = 2
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
        'ChooseFeatureForm
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
        Me.Name = "ChooseFeatureForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChooseFeatureForm"
        Me.TabControl1.ResumeLayout(False)
        Me.ChooseFeatureTab.ResumeLayout(False)
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeatureDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'indexes
    Private FeatureIndex As Rules.Index.IndexEntry()

    'object collections
    Private ExistingMembers As New Objects.ObjectDataCollection
    Private Members As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try
            'indexes
            FeatureIndex = Rules.Index.Index(Xml.DBTypes.Features, Objects.FeatureDefinitionType)

            'initialise controls
            FeatureDropdown.Properties.Items.AddRange(Rules.Index.IndexNames(FeatureIndex))
            FeatureList.Clear()
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

            'init new object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.ChooseFeatureType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Choose Feature"
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
            Me.Text = "Edit Choose Feature"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            If mObject.Element("BonusFeatOption") = "Yes" Then BonusFeat.Checked = True
            If mObject.Element("OverridePrerequisites") = "Yes" Then Override.Checked = True

            ExistingMembers = mObject.ChildrenOfType(Objects.ChooseFeatureMemberType)
            FeatureList.AddObjects(ExistingMembers)
            Members.AddMany(ExistingMembers)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As New Objects.ObjectData

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
                mObject.Name = ObjectName.Text
                If BonusFeat.Checked Then mObject.Element("BonusFeatOption") = "Yes" Else mObject.Element("BonusFeatOption") = "No"
                If Override.Checked Then mObject.Element("OverridePrerequisites") = "Yes" Else mObject.Element("OverridePrerequisites") = "No"
                mObject = PropertiesTab.UpdateObject(mObject)

                'delete the object no longer required
                For Each Obj In ExistingMembers
                    If Not Members.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                'save the new objects
                For Each Obj In Members
                    If Not ExistingMembers.Contains(Obj.ObjectGUID) Then Obj.Save()
                Next

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectItemByGuid(Obj.ObjectGUID)
                Me.DialogResult = DialogResult.OK
                Me.Close()

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
            Validate = General.ValidateForm(Me.ChooseFeatureTab.Controls, Errors)

            If Members.Count < 2 Then
                Errors.SetError(FeatureList, General.ValidationAtLeast2Required)
                Validate = False
            Else
                Errors.SetError(FeatureList, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Tab Code"

    Private Sub AddToGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToGroup.Click
        Dim Obj As Objects.ObjectData

        Try
            If FeatureDropdown.Text = "" Then
                General.ShowInfoDialog("Please select a feature.")
                Exit Sub
            End If

            'check to see if this feature has already been added
            If Members.ContainsFK("Feature", FeatureIndex(FeatureDropdown.SelectedIndex).ObjectGUID) Then
                General.ShowInfoDialog("This feature has already been added.")
            Else
                'look to see if the object is in the collection of existing feature members first
                Obj = ExistingMembers.Item("Feature", FeatureIndex(FeatureDropdown.SelectedIndex).ObjectGUID)

                If Obj.IsEmpty Then
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                    Obj.Name = FeatureDropdown.Text
                    Obj.ParentGUID = mObject.ObjectGUID
                    Obj.Type = Objects.ChooseFeatureMemberType
                    Obj.FKElement("Feature", FeatureDropdown.Text, "Name", FeatureIndex(FeatureDropdown.SelectedIndex).ObjectGUID)
                End If

                FeatureList.AddItem(FeatureDropdown.Text, Obj.ObjectGUID)
                Members.Add(Obj)

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveFromGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFromGroup.Click
        Try
            If FeatureList.List.SelectedItem Is Nothing Then
                General.ShowInfoDialog("Please select a feature to remove.")
            Else
                Members.Remove(FeatureList.ItemGUID())
                FeatureList.RemoveSelectedItem()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

