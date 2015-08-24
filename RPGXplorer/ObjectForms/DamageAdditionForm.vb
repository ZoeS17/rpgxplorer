Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules.Dice

Public Class DamageAdditionForm
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
    Public WithEvents DamageType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageLabel As System.Windows.Forms.Label
    Public WithEvents DamageTypeLabel As System.Windows.Forms.Label
    Public WithEvents Damage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DamageTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents CriticalCheck As System.Windows.Forms.CheckBox
    Public WithEvents ThrownCheck As System.Windows.Forms.CheckBox
    Public WithEvents CriticalMultiplier As System.Windows.Forms.CheckBox
    Public WithEvents Sunder As System.Windows.Forms.CheckBox
    Public WithEvents Permanent As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.DamageTab = New System.Windows.Forms.TabPage
        Me.Permanent = New System.Windows.Forms.CheckBox
        Me.Sunder = New System.Windows.Forms.CheckBox
        Me.CriticalMultiplier = New System.Windows.Forms.CheckBox
        Me.ThrownCheck = New System.Windows.Forms.CheckBox
        Me.CriticalCheck = New System.Windows.Forms.CheckBox
        Me.Damage = New DevExpress.XtraEditors.TextEdit
        Me.DamageLabel = New System.Windows.Forms.Label
        Me.DamageType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageTypeLabel = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.DamageTab.SuspendLayout()
        CType(Me.Damage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.DamageTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'DamageTab
        '
        Me.DamageTab.Controls.Add(Me.Permanent)
        Me.DamageTab.Controls.Add(Me.Sunder)
        Me.DamageTab.Controls.Add(Me.CriticalMultiplier)
        Me.DamageTab.Controls.Add(Me.ThrownCheck)
        Me.DamageTab.Controls.Add(Me.CriticalCheck)
        Me.DamageTab.Controls.Add(Me.Damage)
        Me.DamageTab.Controls.Add(Me.DamageLabel)
        Me.DamageTab.Controls.Add(Me.DamageType)
        Me.DamageTab.Controls.Add(Me.DamageTypeLabel)
        Me.DamageTab.Location = New System.Drawing.Point(4, 22)
        Me.DamageTab.Name = "DamageTab"
        Me.DamageTab.Size = New System.Drawing.Size(407, 349)
        Me.DamageTab.TabIndex = 0
        Me.DamageTab.Text = "Damage"
        '
        'Permanent
        '
        Me.Permanent.Enabled = False
        Me.Permanent.Location = New System.Drawing.Point(15, 195)
        Me.Permanent.Name = "Permanent"
        Me.Permanent.Size = New System.Drawing.Size(210, 21)
        Me.Permanent.TabIndex = 7
        Me.Permanent.Text = "Damage is Permanent on Critical Hit"
        '
        'Sunder
        '
        Me.Sunder.Location = New System.Drawing.Point(15, 165)
        Me.Sunder.Name = "Sunder"
        Me.Sunder.Size = New System.Drawing.Size(200, 21)
        Me.Sunder.TabIndex = 6
        Me.Sunder.Text = "Damage is Dealt to Target Weapon"
        '
        'CriticalMultiplier
        '
        Me.CriticalMultiplier.Enabled = False
        Me.CriticalMultiplier.Location = New System.Drawing.Point(35, 105)
        Me.CriticalMultiplier.Name = "CriticalMultiplier"
        Me.CriticalMultiplier.Size = New System.Drawing.Size(235, 21)
        Me.CriticalMultiplier.TabIndex = 3
        Me.CriticalMultiplier.Text = "Damage Increases with Critical Multiplier"
        '
        'ThrownCheck
        '
        Me.ThrownCheck.Location = New System.Drawing.Point(15, 135)
        Me.ThrownCheck.Name = "ThrownCheck"
        Me.ThrownCheck.Size = New System.Drawing.Size(180, 21)
        Me.ThrownCheck.TabIndex = 5
        Me.ThrownCheck.Text = "Only When Weapon is Thrown"
        '
        'CriticalCheck
        '
        Me.CriticalCheck.Location = New System.Drawing.Point(15, 75)
        Me.CriticalCheck.Name = "CriticalCheck"
        Me.CriticalCheck.Size = New System.Drawing.Size(125, 21)
        Me.CriticalCheck.TabIndex = 2
        Me.CriticalCheck.Text = "On Critical Hit Only"
        '
        'Damage
        '
        Me.Damage.Location = New System.Drawing.Point(95, 15)
        Me.Damage.Name = "Damage"
        '
        'Damage.Properties
        '
        Me.Damage.Properties.AutoHeight = False
        Me.Damage.Size = New System.Drawing.Size(60, 21)
        Me.Damage.TabIndex = 0
        '
        'DamageLabel
        '
        Me.DamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DamageLabel.Location = New System.Drawing.Point(15, 15)
        Me.DamageLabel.Name = "DamageLabel"
        Me.DamageLabel.Size = New System.Drawing.Size(75, 21)
        Me.DamageLabel.TabIndex = 211
        Me.DamageLabel.Text = "Damage"
        Me.DamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DamageType
        '
        Me.DamageType.CausesValidation = False
        Me.DamageType.Location = New System.Drawing.Point(95, 45)
        Me.DamageType.Name = "DamageType"
        '
        'DamageType.Properties
        '
        Me.DamageType.Properties.AutoHeight = False
        Me.DamageType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageType.Properties.DropDownRows = 10
        Me.DamageType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageType.Size = New System.Drawing.Size(100, 21)
        Me.DamageType.TabIndex = 1
        '
        'DamageTypeLabel
        '
        Me.DamageTypeLabel.Location = New System.Drawing.Point(15, 45)
        Me.DamageTypeLabel.Name = "DamageTypeLabel"
        Me.DamageTypeLabel.Size = New System.Drawing.Size(75, 23)
        Me.DamageTypeLabel.TabIndex = 0
        Me.DamageTypeLabel.Text = "Damage Type"
        Me.DamageTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'DamageAdditionForm
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
        Me.Name = "DamageAdditionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DamageAdditionForm"
        Me.TabControl1.ResumeLayout(False)
        Me.DamageTab.ResumeLayout(False)
        CType(Me.Damage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()
        Dim DamageTypes As ArrayList

        Try
            'populate ComboBoxEditros
            DamageType.Properties.Items.Add("")
            DamageTypes = New ArrayList(Rules.Lists.DamageTypesWeapon)

            'remove existing damage types from immediate parent
            'For Each DamageObj As Objects.ObjectData In mObject.Parent.ChildrenOfType(Objects.DamageAdditionType)
            '    DmgType = DamageObj.Element("DamageType")
            '    If DmgType <> "" And DamageTypes.Contains(DmgType) Then DamageTypes.Remove(DmgType)
            'Next

            'If DamageTypes.Count = 0 Then
            '    DamageType.Properties.Enabled = False
            'Else
            DamageType.Properties.Items.AddRange(DamageTypes.ToArray)
            'End If

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
            mObject.Type = Objects.DamageAdditionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Additional Damage"
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
            Me.Text = "Edit Additional Damage"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            Damage.Text = mObject.Element("Damage")
            DamageType.Text = mObject.Element("DamageType")
            DamageType_SelectedIndexChanged(Nothing, Nothing)

            If Obj.Element("OnCritical") = "Yes" Then CriticalCheck.CheckState = CheckState.Checked
            If Obj.Element("CriticalMultiplier") = "Yes" Then CriticalMultiplier.Checked = True
            If Obj.Element("WhenThrown") = "Yes" Then ThrownCheck.CheckState = CheckState.Checked
            If Obj.Element("SunderDamage") = "Yes" Then Sunder.Checked = True
            If Obj.Element("PermanentDamage") = "Yes" Then Permanent.Checked = True

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
                mObject.Name = Damage.Text & " Extra "
                mObject.Element("Damage") = Damage.Text
                If DamageType.Text <> "" Then
                    mObject.Name &= DamageType.Text & " Damage"
                    mObject.Element("DamageType") = DamageType.Text
                Else
                    mObject.Name &= "Damage"
                    mObject.Element("DamageType") = ""
                End If

                If CriticalCheck.Checked Then
                    mObject.Element("OnCritical") = "Yes"
                    mObject.Name &= " on Critical"
                    If CriticalMultiplier.Checked = True Then
                        mObject.Element("CriticalMultiplier") = "Yes"
                        Dim Extra As DiceRange = Rules.Dice.GetDiceRange(Damage.Text)
                        Extra.DiceCount += 1
                        mObject.Name &= ", x3 " & Extra.ToString
                        Extra.DiceCount += 1
                        mObject.Name &= ", x4 " & Extra.ToString
                    Else
                        mObject.Element("CriticalMultiplier") = ""
                    End If
                Else
                    mObject.Element("OnCritical") = ""
                    mObject.Element("CriticalMultiplier") = ""
                End If

                If ThrownCheck.Checked Then
                    mObject.Element("WhenThrown") = "Yes"
                    mObject.Name &= " When Thrown"
                Else
                    mObject.Element("WhenThrown") = ""
                End If

                If Sunder.Checked Then
                    mObject.Element("SunderDamage") = "Yes"
                    mObject.Name &= " vs. Weapon"
                Else
                    mObject.Element("SunderDamage") = ""
                End If

                If Permanent.Checked Then
                    mObject.Element("PermanentDamage") = "Yes"
                    mObject.Name &= " (Permanent Drain on Critical Hit)"
                Else
                    mObject.Element("PermanentDamage") = ""
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
            Validate = General.ValidateForm(Me.DamageTab.Controls, Errors)

            If (Damage.Text <> "") AndAlso ValidNumberDiceRange(Damage) Then
                If CriticalMultiplier.Checked Then
                    If ValidDiceRange(Damage) Then
                        Errors.SetError(Damage, "")
                    Else
                        Errors.SetError(Damage, ValidationCritical)
                        Validate = False
                    End If
                Else
                    Errors.SetError(Damage, "")
                End If
            Else
                Errors.SetError(Damage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

    Private Sub CriticalCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriticalCheck.CheckedChanged
        Try
            If CriticalCheck.Checked Then
                CriticalMultiplier.Enabled = True
                ThrownCheck.Checked = False
                Sunder.Checked = False
                Permanent.Checked = False
            Else
                CriticalMultiplier.Enabled = False
                CriticalMultiplier.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ThrownCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThrownCheck.CheckedChanged
        Try
            If ThrownCheck.Checked Then
                CriticalCheck.Checked = False
                Sunder.Checked = False
                Permanent.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Sunder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sunder.CheckedChanged
        Try
            If Sunder.Checked Then
                CriticalCheck.Checked = False
                ThrownCheck.Checked = False
                Permanent.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DamageType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DamageType.SelectedIndexChanged
        Try
            Select Case DamageType.Text
                Case "STR", "DEX", "CON", "INT", "WIS", "CHA"
                    Permanent.Enabled = True
                    Sunder.Enabled = False
                    Sunder.Checked = False
                Case Else
                    Permanent.Enabled = False
                    Permanent.Checked = False
                    Sunder.Enabled = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Permanent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Permanent.CheckedChanged
        Try
            If Permanent.Checked Then
                CriticalCheck.Checked = False
                ThrownCheck.Checked = False
                Sunder.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

