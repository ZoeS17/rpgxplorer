Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SetAbilityForm
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
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents AbilityDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Value As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ValueMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents SetValueTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ValueMod = New RPGXplorer.ReadOnlyTextBox
        Me.AbilityDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.Value = New DevExpress.XtraEditors.SpinEdit
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SetValueTab = New System.Windows.Forms.TabPage
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SetValueTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjLabel.Location = New System.Drawing.Point(15, 45)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(55, 21)
        Me.ObjLabel.TabIndex = 96
        Me.ObjLabel.Text = "Value"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 400)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(280, 400)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Ability"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValueMod
        '
        Me.ValueMod.BackColor = System.Drawing.Color.White
        Me.ValueMod.Caption = Nothing
        Me.ValueMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ValueMod.DockPadding.All = 1
        Me.ValueMod.ForeColor = System.Drawing.Color.Black
        Me.ValueMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.ValueMod.Location = New System.Drawing.Point(120, 45)
        Me.ValueMod.Name = "ValueMod"
        Me.ValueMod.Size = New System.Drawing.Size(35, 21)
        Me.ValueMod.TabIndex = 267
        Me.ValueMod.TabStop = False
        Me.ValueMod.TextColor = System.Drawing.Color.Black
        Me.ValueMod.Vertical = False
        '
        'AbilityDropdown
        '
        Me.AbilityDropdown.EditValue = ""
        Me.AbilityDropdown.Location = New System.Drawing.Point(65, 15)
        Me.AbilityDropdown.Name = "AbilityDropdown"
        '
        'AbilityDropdown.Properties
        '
        Me.AbilityDropdown.Properties.AutoHeight = False
        Me.AbilityDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AbilityDropdown.Properties.DropDownRows = 10
        Me.AbilityDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AbilityDropdown.Size = New System.Drawing.Size(150, 21)
        Me.AbilityDropdown.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Value
        '
        Me.Value.AllowDrop = True
        Me.Value.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Value.Location = New System.Drawing.Point(65, 45)
        Me.Value.Name = "Value"
        '
        'Value.Properties
        '
        Me.Value.Properties.Appearance.Options.UseTextOptions = True
        Me.Value.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Value.Properties.AutoHeight = False
        Me.Value.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Value.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Value.Properties.IsFloatValue = False
        Me.Value.Properties.Mask.EditMask = "d"
        Me.Value.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Value.Properties.Mask.SaveLiteral = False
        Me.Value.Properties.Mask.ShowPlaceHolders = False
        Me.Value.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Value.Properties.MinValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Value.Size = New System.Drawing.Size(50, 21)
        Me.Value.TabIndex = 1
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
        Me.SetValueTab.Controls.Add(Me.Value)
        Me.SetValueTab.Controls.Add(Me.AbilityDropdown)
        Me.SetValueTab.Controls.Add(Me.ObjLabel)
        Me.SetValueTab.Controls.Add(Me.Label1)
        Me.SetValueTab.Controls.Add(Me.ValueMod)
        Me.SetValueTab.Location = New System.Drawing.Point(4, 22)
        Me.SetValueTab.Name = "SetValueTab"
        Me.SetValueTab.Size = New System.Drawing.Size(407, 344)
        Me.SetValueTab.TabIndex = 2
        Me.SetValueTab.Text = "Set Ability"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 344)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Properties"
        Me.TabPage1.Visible = False
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'SetAbilityForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetAbilityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SetAbility"
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.SetValueTab.ResumeLayout(False)
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

        'load dropdowns
        AbilityDropdown.Properties.Items.AddRange(Rules.AbilityScores.Abilities)

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
            mObject.Type = Objects.SetAbilityType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Set Ability Value"
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
            AbilityDropdown.Text = mObject.Element("Ability")
            Value.Value = mObject.ElementAsInteger("Value")

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

                'save
                mObject.Element("Ability") = AbilityDropdown.Text
                mObject.ElementAsInteger("Value") = CInt(Value.Value)
                Select Case AbilityDropdown.Text
                    Case "STR"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Strength.ToString
                    Case "INT"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Intelligence.ToString
                    Case "DEX"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Dexterity.ToString
                    Case "CON"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Constitution.ToString
                    Case "WIS"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Wisdom.ToString
                    Case "CHA"
                        mObject.Element("AbilityKey") = RPGXplorer.References.Charisma.ToString
                End Select

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
            Validate = General.ValidateForm(Me.Controls, Me.ErrorProvider1)

            Return Validate
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

    Private Sub Value_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value.EditValueChanged
        Dim Modifier As Integer

        'Modifier
        Modifier = RPGXplorer.Rules.AbilityScores.AbilityScore(CInt(Value.Text)).Modifier
        If Modifier > 0 Then
            ValueMod.BackColor = BackColourPositive
            ValueMod.Text = "+" & Modifier.ToString
        ElseIf Modifier < 0 Then
            ValueMod.BackColor = BackColourNegative
            ValueMod.Text = Modifier.ToString
        Else
            ValueMod.BackColor = BackColourWhite
            ValueMod.Text = Modifier.ToString
        End If
    End Sub

End Class
