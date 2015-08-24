Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SkillForm
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
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Ability As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SkillGroup As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents SkillTab As System.Windows.Forms.TabPage
    Public WithEvents GroupCheck As System.Windows.Forms.CheckBox
    Public WithEvents ArmourCheck As System.Windows.Forms.CheckBox
    Public WithEvents TrainedOnly As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SkillTab = New System.Windows.Forms.TabPage
        Me.TrainedOnly = New System.Windows.Forms.CheckBox
        Me.ArmourCheck = New System.Windows.Forms.CheckBox
        Me.GroupCheck = New System.Windows.Forms.CheckBox
        Me.SkillGroup = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Ability = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SkillTab.SuspendLayout()
        CType(Me.SkillGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.SkillTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'SkillTab
        '
        Me.SkillTab.Controls.Add(Me.TrainedOnly)
        Me.SkillTab.Controls.Add(Me.ArmourCheck)
        Me.SkillTab.Controls.Add(Me.GroupCheck)
        Me.SkillTab.Controls.Add(Me.SkillGroup)
        Me.SkillTab.Controls.Add(Me.Ability)
        Me.SkillTab.Controls.Add(Me.IndentedLine2)
        Me.SkillTab.Controls.Add(Me.IndentedLine1)
        Me.SkillTab.Controls.Add(Me.Description)
        Me.SkillTab.Controls.Add(Me.Label3)
        Me.SkillTab.Controls.Add(Me.Label1)
        Me.SkillTab.Controls.Add(Me.ObjectName)
        Me.SkillTab.Controls.Add(Me.Label2)
        Me.SkillTab.Location = New System.Drawing.Point(4, 22)
        Me.SkillTab.Name = "SkillTab"
        Me.SkillTab.Size = New System.Drawing.Size(407, 349)
        Me.SkillTab.TabIndex = 2
        Me.SkillTab.Text = "Skill"
        '
        'TrainedOnly
        '
        Me.TrainedOnly.CausesValidation = False
        Me.TrainedOnly.Location = New System.Drawing.Point(15, 150)
        Me.TrainedOnly.Name = "TrainedOnly"
        Me.TrainedOnly.Size = New System.Drawing.Size(120, 21)
        Me.TrainedOnly.TabIndex = 3
        Me.TrainedOnly.Text = "Trained Only"
        '
        'ArmourCheck
        '
        Me.ArmourCheck.CausesValidation = False
        Me.ArmourCheck.Location = New System.Drawing.Point(15, 180)
        Me.ArmourCheck.Name = "ArmourCheck"
        Me.ArmourCheck.Size = New System.Drawing.Size(147, 21)
        Me.ArmourCheck.TabIndex = 4
        Me.ArmourCheck.Text = "Armor Check Penalty"
        '
        'GroupCheck
        '
        Me.GroupCheck.Location = New System.Drawing.Point(15, 230)
        Me.GroupCheck.Name = "GroupCheck"
        Me.GroupCheck.Size = New System.Drawing.Size(125, 21)
        Me.GroupCheck.TabIndex = 5
        Me.GroupCheck.Text = "Part of a Skill Group"
        '
        'SkillGroup
        '
        Me.SkillGroup.EditValue = ""
        Me.SkillGroup.Enabled = False
        Me.Errors.SetIconPadding(Me.SkillGroup, 3)
        Me.SkillGroup.Location = New System.Drawing.Point(145, 230)
        Me.SkillGroup.Name = "SkillGroup"
        '
        'SkillGroup.Properties
        '
        Me.SkillGroup.Properties.AutoHeight = False
        Me.SkillGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SkillGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SkillGroup.Size = New System.Drawing.Size(100, 21)
        Me.SkillGroup.TabIndex = 6
        '
        'Ability
        '
        Me.Ability.EditValue = ""
        Me.Errors.SetIconPadding(Me.Ability, 3)
        Me.Ability.Location = New System.Drawing.Point(85, 120)
        Me.Ability.Name = "Ability"
        '
        'Ability.Properties
        '
        Me.Ability.Properties.AutoHeight = False
        Me.Ability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ability.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Ability.Size = New System.Drawing.Size(50, 21)
        Me.Ability.TabIndex = 2
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 215)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 129
        Me.IndentedLine2.TabStop = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 127
        Me.IndentedLine1.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Errors.SetIconPadding(Me.Description, 3)
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
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Key Ability"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.Errors.SetIconPadding(Me.ObjectName, 3)
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
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'SkillForm
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
        Me.Name = "SkillForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SkillForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SkillTab.ResumeLayout(False)
        CType(Me.SkillGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
            Ability.Properties.Items.Add("")
            Ability.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
            SkillGroup.Properties.Items.AddRange(Rules.Lists.SkillGroups)
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Skills)
            mObject.Type = Objects.SkillDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Skill Definition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim temp As String

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form 
            Me.Text = "Edit Skill Definition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            Ability.Text = mObject.Element("KeyAbility")

            temp = mObject.Element("SkillGroup")
            If temp = "" Then
                GroupCheck.CheckState = CheckState.Unchecked
            Else
                GroupCheck.CheckState = CheckState.Checked
                SkillGroup.Text = temp
            End If

            If mObject.Element("Untrained") = "Yes" Then TrainedOnly.CheckState = CheckState.Unchecked Else TrainedOnly.CheckState = CheckState.Checked
            If mObject.Element("ArmorCheckPenalty") = "Yes" Then ArmourCheck.CheckState = CheckState.Checked Else ArmourCheck.CheckState = CheckState.Unchecked
            Description.Text = mObject.Element("Description")

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
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("KeyAbility") = Ability.Text
                If GroupCheck.CheckState = CheckState.Checked Then mObject.Element("SkillGroup") = SkillGroup.Text Else mObject.Element("SkillGroup") = ""
                If TrainedOnly.CheckState = CheckState.Unchecked Then mObject.Element("Untrained") = "Yes" Else mObject.Element("Untrained") = ""
                If ArmourCheck.CheckState = CheckState.Checked Then mObject.Element("ArmorCheckPenalty") = "Yes" Else mObject.Element("ArmorCheckPenalty") = ""
                mObject.Element("Description") = Description.Text
                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()

                'update characters
                If mMode = FormMode.Add Then
                    Dim SkillRank As New Rules.Character.SkillRank
                    SkillRank.SkillName = mObject.Name
                    SkillRank.SkillGuid = mObject.ObjectGUID
                    SkillRank.AssignedRanks = New Hashtable

                    'characters
                    For Each CharacterObj As Objects.ObjectData In Objects.GetAllObjectsOfType(Xml.DBTypes.Characters, Objects.CharacterType)
                        Dim TempObject As Objects.ObjectData
                        TempObject = SkillRank.CreateObject(CharacterObj)
                        TempObject.Save()
                    Next

                    'monsters                    
                    For Each CharacterObj As Objects.ObjectData In Objects.GetAllObjectsOfType(Xml.DBTypes.Monsters, Objects.MonsterType)
                        Dim TempObject As Objects.ObjectData
                        TempObject = SkillRank.CreateObject(CharacterObj)
                        TempObject.Save()
                    Next

                End If

                WindowManager.SetDirty(mObject.Parent)
                Select Case mMode
                    Case FormMode.Add
                        If Caches.SkillsCurrent Then Caches.Skills.Add(mObject)
                    Case FormMode.Edit
                        If Caches.SkillsCurrent Then Caches.Skills.Replace(mObject)
                End Select
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
            Validate = General.ValidateForm(Me.SkillTab.Controls, Errors)

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

    Private Sub GroupCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupCheck.CheckedChanged
        Try
            SkillGroup.SelectedIndex = -1
            If GroupCheck.CheckState = CheckState.Checked Then
                SkillGroup.Properties.Enabled = True
            Else
                SkillGroup.Properties.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

