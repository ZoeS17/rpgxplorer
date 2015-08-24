Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SpellSchoolForm
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
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents NameLabel As System.Windows.Forms.Label
    Public WithEvents SchoolTab As System.Windows.Forms.TabPage
    Public WithEvents ProhibitedTab As System.Windows.Forms.TabPage
    Public WithEvents SchoolList As RPGXplorer.ListBox
    Public WithEvents TargetLabel As System.Windows.Forms.Label
    Public WithEvents SchoolBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AddButton As System.Windows.Forms.Button
    Public WithEvents RemoveButton As System.Windows.Forms.Button
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents SacrificeCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Prohibited As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents SpecialistCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SchoolTab = New System.Windows.Forms.TabPage
        Me.SpecialistCheck = New System.Windows.Forms.CheckBox
        Me.Prohibited = New DevExpress.XtraEditors.SpinEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.SacrificeCheck = New System.Windows.Forms.CheckBox
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.ProhibitedTab = New System.Windows.Forms.TabPage
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.SchoolList = New RPGXplorer.ListBox
        Me.TargetLabel = New System.Windows.Forms.Label
        Me.SchoolBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.AddButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SchoolTab.SuspendLayout()
        CType(Me.Prohibited.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProhibitedTab.SuspendLayout()
        CType(Me.SchoolBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.SchoolTab)
        Me.TabControl1.Controls.Add(Me.ProhibitedTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'SchoolTab
        '
        Me.SchoolTab.Controls.Add(Me.SpecialistCheck)
        Me.SchoolTab.Controls.Add(Me.Prohibited)
        Me.SchoolTab.Controls.Add(Me.Label6)
        Me.SchoolTab.Controls.Add(Me.IndentedLine1)
        Me.SchoolTab.Controls.Add(Me.SacrificeCheck)
        Me.SchoolTab.Controls.Add(Me.Description)
        Me.SchoolTab.Controls.Add(Me.Label21)
        Me.SchoolTab.Controls.Add(Me.ObjectName)
        Me.SchoolTab.Controls.Add(Me.NameLabel)
        Me.SchoolTab.Location = New System.Drawing.Point(4, 22)
        Me.SchoolTab.Name = "SchoolTab"
        Me.SchoolTab.Size = New System.Drawing.Size(407, 349)
        Me.SchoolTab.TabIndex = 0
        Me.SchoolTab.Text = "School"
        '
        'SpecialistCheck
        '
        Me.SpecialistCheck.CausesValidation = False
        Me.SpecialistCheck.Location = New System.Drawing.Point(15, 120)
        Me.SpecialistCheck.Name = "SpecialistCheck"
        Me.SpecialistCheck.Size = New System.Drawing.Size(160, 24)
        Me.SpecialistCheck.TabIndex = 2
        Me.SpecialistCheck.Text = "Can be specialist school"
        '
        'Prohibited
        '
        Me.Prohibited.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Prohibited.Enabled = False
        Me.Prohibited.Location = New System.Drawing.Point(250, 150)
        Me.Prohibited.Name = "Prohibited"
        '
        'Prohibited.Properties
        '
        Me.Prohibited.Properties.Appearance.Options.UseTextOptions = True
        Me.Prohibited.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Prohibited.Properties.AutoHeight = False
        Me.Prohibited.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Prohibited.Properties.IsFloatValue = False
        Me.Prohibited.Properties.Mask.BeepOnError = True
        Me.Prohibited.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Prohibited.Properties.Mask.ShowPlaceHolders = False
        Me.Prohibited.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Prohibited.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Prohibited.Size = New System.Drawing.Size(50, 21)
        Me.Prohibited.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 21)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "Specialization Prohibited Schools Required "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 188
        '
        'SacrificeCheck
        '
        Me.SacrificeCheck.CausesValidation = False
        Me.SacrificeCheck.Location = New System.Drawing.Point(15, 180)
        Me.SacrificeCheck.Name = "SacrificeCheck"
        Me.SacrificeCheck.Size = New System.Drawing.Size(230, 24)
        Me.SacrificeCheck.TabIndex = 4
        Me.SacrificeCheck.Text = "Can be specialization prohibited school"
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(304, 46)
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 187
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ObjectName.Size = New System.Drawing.Size(150, 21)
        Me.ObjectName.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.NameLabel.Location = New System.Drawing.Point(15, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 21)
        Me.NameLabel.TabIndex = 185
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProhibitedTab
        '
        Me.ProhibitedTab.Controls.Add(Me.IndentedLine2)
        Me.ProhibitedTab.Controls.Add(Me.SchoolList)
        Me.ProhibitedTab.Controls.Add(Me.TargetLabel)
        Me.ProhibitedTab.Controls.Add(Me.SchoolBox)
        Me.ProhibitedTab.Controls.Add(Me.AddButton)
        Me.ProhibitedTab.Controls.Add(Me.RemoveButton)
        Me.ProhibitedTab.Location = New System.Drawing.Point(4, 22)
        Me.ProhibitedTab.Name = "ProhibitedTab"
        Me.ProhibitedTab.Size = New System.Drawing.Size(407, 349)
        Me.ProhibitedTab.TabIndex = 2
        Me.ProhibitedTab.Text = "Available Prohibited Schools"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 204
        Me.IndentedLine2.TabStop = False
        '
        'SchoolList
        '
        Me.SchoolList.CausesValidation = False
        Me.SchoolList.Enabled = False
        Me.SchoolList.Location = New System.Drawing.Point(15, 65)
        Me.SchoolList.Name = "SchoolList"
        Me.SchoolList.Size = New System.Drawing.Size(260, 270)
        Me.SchoolList.TabIndex = 3
        '
        'TargetLabel
        '
        Me.TargetLabel.Location = New System.Drawing.Point(15, 15)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(45, 21)
        Me.TargetLabel.TabIndex = 200
        Me.TargetLabel.Text = "School"
        Me.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SchoolBox
        '
        Me.SchoolBox.CausesValidation = False
        Me.SchoolBox.Location = New System.Drawing.Point(65, 15)
        Me.SchoolBox.Name = "SchoolBox"
        '
        'SchoolBox.Properties
        '
        Me.SchoolBox.Properties.AutoHeight = False
        Me.SchoolBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SchoolBox.Properties.DropDownRows = 10
        Me.SchoolBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SchoolBox.Size = New System.Drawing.Size(150, 21)
        Me.SchoolBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.CausesValidation = False
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(290, 65)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 24)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        '
        'RemoveButton
        '
        Me.RemoveButton.CausesValidation = False
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.Location = New System.Drawing.Point(290, 100)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(100, 24)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Remove"
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
        'SpellSchoolForm
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
        Me.Name = "SpellSchoolForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpellSchoolForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SchoolTab.ResumeLayout(False)
        CType(Me.Prohibited.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProhibitedTab.ResumeLayout(False)
        CType(Me.SchoolBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'object collections
    Private ExistingSchools As New Objects.ObjectDataCollection
    Private CurrentSchools As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Dim ExclusionList As New ArrayList
        Dim SpellSchools As New Objects.ObjectDataCollection
        Dim Obj As Objects.ObjectData

        Try
            'initialise controls
            'spell school dropdown should only contain those schools that are sacrificable
            'current school if any should also be excluded.
            SpellSchools = Objects.GetObjectsByXPath(Xml.DBTypes.SpellSchools, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellSchoolType & "' and CanBeSacrificed='No']")

            For Each Obj In SpellSchools
                ExclusionList.Add(Obj.ObjectGUID)
            Next

            'add current school and universal
            If Not ExclusionList.Contains(mObject.ObjectGUID) Then ExclusionList.Add(mObject.ObjectGUID)

            SchoolBox.Properties.Items.AddRange(Rules.Index.DataListExclude(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType, ExclusionList))
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.SpellSchools)
            mObject.Type = Objects.SpellSchoolType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Spell School"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Spell School"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            ObjectName.Text = mObject.Name
            Description.Text = mObject.Element("Description")
            If mObject.Element("CanBeSpecialist") = "Yes" Then SpecialistCheck.Checked = True
            Prohibited.EditValue = mObject.ElementAsInteger("ProhibitedSchools")
            If mObject.Element("CanBeSacrificed") = "Yes" Then SacrificeCheck.Checked = True Else SacrificeCheck.Checked = False

            ExistingSchools = mObject.ChildrenOfType(Objects.SpellSchoolSacrificedType)
            For Each Child In ExistingSchools
                CurrentSchools.Add(Child)
                SchoolList.AddItem(Child.Name, Child.ObjectGUID)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As Objects.ObjectData

        Try
            If Validate() Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        'do nothing yet
                        mObject.ClearElements()
                End Select

                mObject.Name = ObjectName.Text
                mObject.Element("Description") = Description.Text
                If SpecialistCheck.Checked Then mObject.Element("CanBeSpecialist") = "Yes" Else mObject.Element("CanBeSpecialist") = "No"
                mObject.Element("ProhibitedSchools") = Prohibited.EditValue.ToString
                If SacrificeCheck.Checked Then mObject.Element("CanBeSacrificed") = "Yes" Else mObject.Element("CanBeSacrificed") = "No"

                'rationalise existing objects
                For Each Obj In ExistingSchools
                    If Not CurrentSchools.Contains(Obj.ObjectGUID) Then Obj.Delete()
                Next

                For Each Obj In CurrentSchools
                    If ExistingSchools.Contains(Obj.ObjectGUID) Then CurrentSchools.Remove(Obj.ObjectGUID)
                Next
                CurrentSchools.Save()

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.RefreshRenamedNode(mObject.ObjectGUID, mObject.Name)
                End If

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
            Validate = General.ValidateForm(Me.SchoolTab.Controls, Errors)

            If SchoolList.Count < CType(Prohibited.EditValue, Integer) And Prohibited.Properties.Enabled Then
                Errors.SetError(SchoolList, "Not enough prohibited schools defined.")
                Validate = False
            Else
                Errors.SetError(SchoolList, "")
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Tab Code"

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim Obj As New Objects.ObjectData
        Dim ObjGuid As Objects.ObjectKey

        Try
            If SchoolBox.SelectedIndex = -1 Then Exit Sub

            'If SchoolList.Count = CType(Prohibited.EditValue, Integer) Then
            '    General.ShowInfoDialog("You have already added the required number of prohibited schools.")
            '    Exit Sub
            'End If

            'Check if object as already been added
            ObjGuid = CType(SchoolBox.SelectedItem, DataListItem).ObjectGUID
            If CurrentSchools.ContainsFK("School", ObjGuid) Then
                General.ShowInfoDialog("This School has already been added.")
            Else
                Obj.Type = Objects.SpellSchoolSacrificedType
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.SpellSchools)
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.FKElement("School", SchoolBox.Text, "Name", ObjGuid)

                SchoolList.AddItem(Obj.Name, Obj.ObjectGUID)
                CurrentSchools.Add(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Try
            If SchoolList.SelectedIndex = -1 Then Exit Sub
            CurrentSchools.Remove(SchoolList.ItemGUID)
            SchoolList.RemoveSelectedItem()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

    Private Sub SpecialistCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialistCheck.CheckedChanged
        Try
            If SpecialistCheck.Checked Then
                Prohibited.Properties.Enabled = True
                SchoolBox.Properties.Enabled = True
                SchoolList.Enabled = True
                AddButton.Enabled = True
                RemoveButton.Enabled = True
            Else
                Prohibited.Value = 0
                Prohibited.Properties.Enabled = False
                SchoolBox.SelectedIndex = -1
                SchoolBox.Properties.Enabled = False
                SchoolList.Clear()
                SchoolList.Enabled = False
                AddButton.Enabled = False
                RemoveButton.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
