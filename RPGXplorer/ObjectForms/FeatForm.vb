Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class FeatForm
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
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents FeatType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents FighterBonusCheck As System.Windows.Forms.CheckBox
    Public WithEvents FeatTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents FocusCheck As System.Windows.Forms.CheckBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents FocusType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents Stacks As System.Windows.Forms.CheckBox
    Public WithEvents RayCheck As System.Windows.Forms.CheckBox
    Public WithEvents GrappleCheck As System.Windows.Forms.CheckBox
    Public WithEvents RangedCheck As System.Windows.Forms.CheckBox
    Public WithEvents TouchCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.FeatTab = New System.Windows.Forms.TabPage
        Me.TouchCheck = New System.Windows.Forms.CheckBox
        Me.RangedCheck = New System.Windows.Forms.CheckBox
        Me.RayCheck = New System.Windows.Forms.CheckBox
        Me.GrappleCheck = New System.Windows.Forms.CheckBox
        Me.Stacks = New System.Windows.Forms.CheckBox
        Me.FocusCheck = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.FocusType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.FighterBonusCheck = New System.Windows.Forms.CheckBox
        Me.FeatType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.FeatTab.SuspendLayout()
        CType(Me.FocusType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeatType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.FeatTab)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'FeatTab
        '
        Me.FeatTab.Controls.Add(Me.TouchCheck)
        Me.FeatTab.Controls.Add(Me.RangedCheck)
        Me.FeatTab.Controls.Add(Me.RayCheck)
        Me.FeatTab.Controls.Add(Me.GrappleCheck)
        Me.FeatTab.Controls.Add(Me.Stacks)
        Me.FeatTab.Controls.Add(Me.FocusCheck)
        Me.FeatTab.Controls.Add(Me.Label4)
        Me.FeatTab.Controls.Add(Me.FocusType)
        Me.FeatTab.Controls.Add(Me.FighterBonusCheck)
        Me.FeatTab.Controls.Add(Me.FeatType)
        Me.FeatTab.Controls.Add(Me.Label11)
        Me.FeatTab.Controls.Add(Me.IndentedLine1)
        Me.FeatTab.Controls.Add(Me.Description)
        Me.FeatTab.Controls.Add(Me.Label3)
        Me.FeatTab.Controls.Add(Me.ObjectName)
        Me.FeatTab.Controls.Add(Me.Label2)
        Me.FeatTab.Location = New System.Drawing.Point(4, 22)
        Me.FeatTab.Name = "FeatTab"
        Me.FeatTab.Size = New System.Drawing.Size(407, 349)
        Me.FeatTab.TabIndex = 2
        Me.FeatTab.Text = "Feat"
        '
        'TouchCheck
        '
        Me.TouchCheck.CausesValidation = False
        Me.TouchCheck.Location = New System.Drawing.Point(125, 300)
        Me.TouchCheck.Name = "TouchCheck"
        Me.TouchCheck.Size = New System.Drawing.Size(140, 21)
        Me.TouchCheck.TabIndex = 143
        Me.TouchCheck.Text = "Include Touch Spells"
        Me.TouchCheck.Visible = False
        '
        'RangedCheck
        '
        Me.RangedCheck.CausesValidation = False
        Me.RangedCheck.Location = New System.Drawing.Point(125, 270)
        Me.RangedCheck.Name = "RangedCheck"
        Me.RangedCheck.Size = New System.Drawing.Size(140, 21)
        Me.RangedCheck.TabIndex = 142
        Me.RangedCheck.Text = "Include Ranged Spells"
        Me.RangedCheck.Visible = False
        '
        'RayCheck
        '
        Me.RayCheck.CausesValidation = False
        Me.RayCheck.Location = New System.Drawing.Point(15, 300)
        Me.RayCheck.Name = "RayCheck"
        Me.RayCheck.Size = New System.Drawing.Size(105, 21)
        Me.RayCheck.TabIndex = 141
        Me.RayCheck.Text = "Include Ray"
        Me.RayCheck.Visible = False
        '
        'GrappleCheck
        '
        Me.GrappleCheck.CausesValidation = False
        Me.GrappleCheck.Location = New System.Drawing.Point(15, 270)
        Me.GrappleCheck.Name = "GrappleCheck"
        Me.GrappleCheck.Size = New System.Drawing.Size(105, 21)
        Me.GrappleCheck.TabIndex = 140
        Me.GrappleCheck.Text = "Include Grapple"
        Me.GrappleCheck.Visible = False
        '
        'Stacks
        '
        Me.Stacks.CausesValidation = False
        Me.Stacks.Location = New System.Drawing.Point(15, 180)
        Me.Stacks.Name = "Stacks"
        Me.Stacks.Size = New System.Drawing.Size(190, 21)
        Me.Stacks.TabIndex = 4
        Me.Stacks.Text = "Can be taken multiple times"
        '
        'FocusCheck
        '
        Me.FocusCheck.CausesValidation = False
        Me.FocusCheck.Location = New System.Drawing.Point(15, 210)
        Me.FocusCheck.Name = "FocusCheck"
        Me.FocusCheck.Size = New System.Drawing.Size(104, 21)
        Me.FocusCheck.TabIndex = 5
        Me.FocusCheck.Text = "Has Focus"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Focus Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FocusType
        '
        Me.FocusType.Enabled = False
        Me.FocusType.Location = New System.Drawing.Point(85, 240)
        Me.FocusType.Name = "FocusType"
        '
        'FocusType.Properties
        '
        Me.FocusType.Properties.AutoHeight = False
        Me.FocusType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FocusType.Properties.DropDownRows = 10
        Me.FocusType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FocusType.Size = New System.Drawing.Size(200, 21)
        Me.FocusType.TabIndex = 6
        '
        'FighterBonusCheck
        '
        Me.FighterBonusCheck.CausesValidation = False
        Me.FighterBonusCheck.Location = New System.Drawing.Point(15, 150)
        Me.FighterBonusCheck.Name = "FighterBonusCheck"
        Me.FighterBonusCheck.Size = New System.Drawing.Size(120, 21)
        Me.FighterBonusCheck.TabIndex = 3
        Me.FighterBonusCheck.Text = "Fighter Bonus Feat"
        '
        'FeatType
        '
        Me.FeatType.EditValue = ""
        Me.FeatType.Location = New System.Drawing.Point(85, 120)
        Me.FeatType.Name = "FeatType"
        '
        'FeatType.Properties
        '
        Me.FeatType.Properties.AutoHeight = False
        Me.FeatType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatType.Size = New System.Drawing.Size(150, 21)
        Me.FeatType.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.CausesValidation = False
        Me.Label11.Location = New System.Drawing.Point(15, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 127
        Me.IndentedLine1.TabStop = False
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
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PropertiesTab)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(407, 349)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Properties"
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
        'FeatForm
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
        Me.Name = "FeatForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeatForm"
        Me.TabControl1.ResumeLayout(False)
        Me.FeatTab.ResumeLayout(False)
        CType(Me.FocusType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeatType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
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
            FeatType.Properties.Items.AddRange(Rules.Lists.FeatTypes)
            FocusType.Properties.Items.AddRange(Rules.Lists.FocusFilters)
            FocusType.SelectedIndex = -1
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init new object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Feats)
            mObject.Type = Objects.FeatDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Feat"
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
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Feat"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            Description.Text = mObject.Element("Description")
            FeatType.Text = mObject.Element("FeatType")
            If mObject.Element("FighterBonusFeat") = "Yes" Then FighterBonusCheck.CheckState = CheckState.Checked
            If mObject.Element("HasFocus") = "Yes" Then FocusCheck.CheckState = CheckState.Checked
            If mObject.Element("Stacks") = "Yes" Then Stacks.Checked = True
            If FocusType.Properties.Enabled = True Then FocusType.Text = mObject.Element("FocusType")
            If mObject.Element("IncludeGrapple") = "Yes" Then GrappleCheck.CheckState = CheckState.Checked
            If mObject.Element("IncludeRay") = "Yes" Then RayCheck.CheckState = CheckState.Checked
            If mObject.Element("IncludeRanged") = "Yes" Then RangedCheck.CheckState = CheckState.Checked
            If mObject.Element("IncludeTouch") = "Yes" Then TouchCheck.CheckState = CheckState.Checked

            'If Training.Properties.Enabled Then Training.Text = mObject.Element("Training")
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
                mObject.Element("Description") = Description.Text
                mObject.Element("FeatType") = FeatType.Text
                If FighterBonusCheck.CheckState = CheckState.Checked Then mObject.Element("FighterBonusFeat") = "Yes" Else mObject.Element("FighterBonusFeat") = ""
                If FocusCheck.CheckState = CheckState.Checked Then mObject.Element("HasFocus") = "Yes" Else mObject.Element("HasFocus") = ""
                If Stacks.Checked Then mObject.Element("Stacks") = "Yes" Else mObject.Element("Stacks") = ""
                If FocusType.Properties.Enabled = True Then mObject.Element("FocusType") = FocusType.Text Else mObject.Element("FocusType") = ""
                If GrappleCheck.CheckState = CheckState.Checked Then mObject.Element("IncludeGrapple") = "Yes" Else mObject.Element("IncludeGrapple") = ""
                If RayCheck.CheckState = CheckState.Checked Then mObject.Element("IncludeRay") = "Yes" Else mObject.Element("IncludeRay") = ""
                If RangedCheck.CheckState = CheckState.Checked Then mObject.Element("IncludeRanged") = "Yes" Else mObject.Element("IncludeRanged") = ""
                If TouchCheck.CheckState = CheckState.Checked Then mObject.Element("IncludeTouch") = "Yes" Else mObject.Element("IncludeTouch") = ""

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                Caches.SetFeatsDirty()
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
            Validate = General.ValidateForm(Me.FeatTab.Controls, Errors)

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

#Region "Control Enabling and Disabling"

    Private Sub FocusCheck_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FocusCheck.CheckedChanged
        Try
            Select Case FocusCheck.CheckState
                Case CheckState.Checked
                    FocusType.Properties.Enabled = True
                    Stacks.Checked = False
                Case CheckState.Unchecked
                    FocusType.Properties.Enabled = False
                    FocusType.SelectedIndex = -1
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FocusType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FocusType.SelectedIndexChanged
        Try
            If FocusType.Text = "Any Weapon" Then
                RayCheck.Visible = True
                GrappleCheck.Visible = True
                TouchCheck.Visible = True
                RangedCheck.Visible = True
            Else
                RayCheck.CheckState = CheckState.Unchecked
                RayCheck.Visible = False

                GrappleCheck.CheckState = CheckState.Unchecked
                GrappleCheck.Visible = False

                TouchCheck.CheckState = CheckState.Unchecked
                TouchCheck.Visible = False

                RangedCheck.CheckState = CheckState.Unchecked
                RangedCheck.Visible = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Stacks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stacks.CheckedChanged
        Try
            If Stacks.Checked Then
                FocusCheck.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
