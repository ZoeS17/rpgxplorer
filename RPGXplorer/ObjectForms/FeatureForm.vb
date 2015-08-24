Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class FeatureForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Replaces As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents AbilityTab As System.Windows.Forms.TabPage
    Public WithEvents ReplacesCheck As System.Windows.Forms.CheckBox
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents MultipleCheck As System.Windows.Forms.CheckBox
    Public WithEvents FeatureType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents StackCheck As System.Windows.Forms.CheckBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.AbilityTab = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.MultipleCheck = New System.Windows.Forms.CheckBox
        Me.StackCheck = New System.Windows.Forms.CheckBox
        Me.ReplacesCheck = New System.Windows.Forms.CheckBox
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FeatureType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Replaces = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.AbilityTab.SuspendLayout()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeatureType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Replaces.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
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
        Me.TabControl1.Controls.Add(Me.AbilityTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'AbilityTab
        '
        Me.AbilityTab.Controls.Add(Me.Label4)
        Me.AbilityTab.Controls.Add(Me.IndentedLine2)
        Me.AbilityTab.Controls.Add(Me.MultipleCheck)
        Me.AbilityTab.Controls.Add(Me.StackCheck)
        Me.AbilityTab.Controls.Add(Me.ReplacesCheck)
        Me.AbilityTab.Controls.Add(Me.Description)
        Me.AbilityTab.Controls.Add(Me.Label3)
        Me.AbilityTab.Controls.Add(Me.Label1)
        Me.AbilityTab.Controls.Add(Me.FeatureType)
        Me.AbilityTab.Controls.Add(Me.ObjectName)
        Me.AbilityTab.Controls.Add(Me.Label2)
        Me.AbilityTab.Controls.Add(Me.Replaces)
        Me.AbilityTab.Controls.Add(Me.IndentedLine1)
        Me.AbilityTab.Location = New System.Drawing.Point(4, 22)
        Me.AbilityTab.Name = "AbilityTab"
        Me.AbilityTab.Size = New System.Drawing.Size(407, 349)
        Me.AbilityTab.TabIndex = 2
        Me.AbilityTab.Text = "Feature"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "* Affects entire progression"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 155)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 125
        Me.IndentedLine2.TabStop = False
        '
        'MultipleCheck
        '
        Me.MultipleCheck.Location = New System.Drawing.Point(15, 255)
        Me.MultipleCheck.Name = "MultipleCheck"
        Me.MultipleCheck.Size = New System.Drawing.Size(255, 21)
        Me.MultipleCheck.TabIndex = 8
        Me.MultipleCheck.Text = "This feature can be acquired more than once*"
        '
        'StackCheck
        '
        Me.StackCheck.CausesValidation = False
        Me.StackCheck.Enabled = False
        Me.StackCheck.Location = New System.Drawing.Point(35, 225)
        Me.StackCheck.Name = "StackCheck"
        Me.StackCheck.Size = New System.Drawing.Size(290, 21)
        Me.StackCheck.TabIndex = 6
        Me.StackCheck.Text = "Stack with levels gained from different classes*"
        '
        'ReplacesCheck
        '
        Me.ReplacesCheck.CausesValidation = False
        Me.ReplacesCheck.Location = New System.Drawing.Point(15, 170)
        Me.ReplacesCheck.Name = "ReplacesCheck"
        Me.ReplacesCheck.Size = New System.Drawing.Size(210, 21)
        Me.ReplacesCheck.TabIndex = 4
        Me.ReplacesCheck.Text = "Supercedes this feature"
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(305, 46)
        Me.Description.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Feature Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FeatureType
        '
        Me.FeatureType.CausesValidation = False
        Me.FeatureType.Location = New System.Drawing.Point(95, 120)
        Me.FeatureType.Name = "FeatureType"
        '
        'FeatureType.Properties
        '
        Me.FeatureType.Properties.AutoHeight = False
        Me.FeatureType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatureType.Properties.DropDownRows = 10
        Me.FeatureType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatureType.Size = New System.Drawing.Size(150, 21)
        Me.FeatureType.TabIndex = 2
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Replaces
        '
        Me.Replaces.Enabled = False
        Me.Replaces.Location = New System.Drawing.Point(35, 195)
        Me.Replaces.Name = "Replaces"
        '
        'Replaces.Properties
        '
        Me.Replaces.Properties.AutoHeight = False
        Me.Replaces.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Replaces.Properties.DropDownRows = 10
        Me.Replaces.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Replaces.Size = New System.Drawing.Size(200, 21)
        Me.Replaces.TabIndex = 5
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 120
        Me.IndentedLine1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
        Me.TabPage1.TabIndex = 6
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
        'FeatureForm
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
        Me.Name = "FeatureForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeatureForm"
        Me.TabControl1.ResumeLayout(False)
        Me.AbilityTab.ResumeLayout(False)
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeatureType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Replaces.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'index
    Private FeatureIndex As Rules.Index.IndexEntry()

    'init
    Public Sub Init()
        Try
            'load index
            FeatureIndex = Rules.Index.Index(Xml.DBTypes.Features, Objects.FeatureDefinitionType, False, mObject.ObjectGUID.ToString())

            'initialise controls
            FeatureType.Properties.Items.Add("")
            FeatureType.Properties.Items.AddRange(Rules.Lists.FeatureTypes)
            Replaces.Properties.Items.AddRange(Rules.Index.IndexNames(FeatureIndex))
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Features)
            mObject.Type = Objects.FeatureDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Feature"
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
            Me.Text = "Edit Feature"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = Obj.Name
            FeatureType.Text = mObject.Element("FeatureType")
            Description.Text = mObject.Element("Description")
            Replaces.SelectedIndex = Rules.Index.GetGuidIndex(FeatureIndex, mObject.GetFKGuid("Replaces"))
            If Replaces.SelectedIndex <> -1 Then ReplacesCheck.CheckState = CheckState.Checked
            If mObject.Element("CanBeTakenMultipleTimes") = "Yes" Then MultipleCheck.Checked = True
            If mObject.Element("Stacks") = "Yes" Then StackCheck.Checked = True

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
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("FeatureType") = FeatureType.Text
                mObject.Element("Description") = Description.Text

                If ReplacesCheck.CheckState = CheckState.Checked Then mObject.FKElement("Replaces", Replaces.Text, "Name", FeatureIndex(Replaces.SelectedIndex).ObjectGUID)
                If MultipleCheck.CheckState = CheckState.Checked Then mObject.Element("CanBeTakenMultipleTimes") = "Yes" Else mObject.Element("CanBeTakenMultipleTimes") = ""
                If StackCheck.CheckState = CheckState.Checked Then mObject.Element("Stacks") = "Yes" Else mObject.Element("Stacks") = ""

                mObject = PropertiesTab.UpdateObject(mObject)

                If ReplacesCheck.CheckState = CheckState.Checked Then

                    'Set the rest of the features in this chain with the same stacking and multiple settings
                    'TODO - REFACTOR to Feature.UpdateChain?
                    Dim FeatureChains As Rules.FeatureChainCollection = Caches.FeatureChains

                    If FeatureChains.Contains(FeatureIndex(Replaces.SelectedIndex).ObjectGUID) Then
                        Dim ChainGuid As Objects.ObjectKey = FeatureChains.ChainGuid(FeatureIndex(Replaces.SelectedIndex).ObjectGUID)
                        For Each LinkItem As Rules.FeatureLink In CType(FeatureChains.Chains(ChainGuid), Rules.FeatureChain).FeatureLinks
                            Dim TempObject As Objects.ObjectData = DirectCast(Caches.Features.Item(LinkItem.FeatureGuid), Objects.ObjectData)
                            TempObject.Element("Stacks") = mObject.Element("Stacks")
                            TempObject.Element("CanBeTakenMultipleTimes") = mObject.Element("CanBeTakenMultipleTimes")
                        Next
                    End If

                End If

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                Caches.SetFeaturesDirty()
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
            Validate = General.ValidateForm(Me.AbilityTab.Controls, Errors)

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            'If we are replacing an object - make sure we are the only one
            If (ReplacesCheck.CheckState = CheckState.Checked) AndAlso (Replaces.SelectedIndex > -1) Then
                Dim ReplacesGuid As Objects.ObjectKey = FeatureIndex(Replaces.SelectedIndex).ObjectGUID

                For Each TempObject As Objects.ObjectData In Caches.Features.Values
                    If TempObject.GetFKGuid("Replaces").Equals(ReplacesGuid) Then
                        If Not TempObject.ObjectGUID.Equals(mObject.ObjectGUID) Then
                            Validate = False
                            Errors.SetError(Replaces, "This feature is already replaced by " & TempObject.Name)
                            Exit For
                        End If
                    End If
                    Errors.SetError(Replaces, "")
                Next
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

    Private Sub ReplacesCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplacesCheck.CheckedChanged
        Try
            If ReplacesCheck.CheckState = CheckState.Checked Then
                Replaces.Properties.Enabled = True
                StackCheck.Enabled = True
                StackCheck.CheckState = CheckState.Unchecked
            Else
                Replaces.Properties.Enabled = False
                Replaces.Text = ""
                StackCheck.Enabled = False
                StackCheck.CheckState = CheckState.Unchecked
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub StackCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StackCheck.CheckedChanged
        Try

            If StackCheck.CheckState = CheckState.Checked Then
                MultipleCheck.CheckState = CheckState.Unchecked
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MultipleCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipleCheck.CheckedChanged
        Try
            If MultipleCheck.CheckState = CheckState.Checked Then
                StackCheck.CheckState = CheckState.Unchecked
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
