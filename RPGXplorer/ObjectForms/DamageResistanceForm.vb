Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class DamageResistanceForm
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
    Public WithEvents Basics As System.Windows.Forms.TabPage
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents DamageType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Resistance As DevExpress.XtraEditors.SpinEdit
    Public WithEvents StackCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.StackCheck = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DamageType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Resistance = New DevExpress.XtraEditors.SpinEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.DamageType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Resistance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.Basics)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.StackCheck)
        Me.Basics.Controls.Add(Me.Label1)
        Me.Basics.Controls.Add(Me.Label4)
        Me.Basics.Controls.Add(Me.DamageType)
        Me.Basics.Controls.Add(Me.Resistance)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 349)
        Me.Basics.TabIndex = 2
        Me.Basics.Text = "Damage Resistance"
        '
        'StackCheck
        '
        Me.StackCheck.CausesValidation = False
        Me.StackCheck.Location = New System.Drawing.Point(105, 75)
        Me.StackCheck.Name = "StackCheck"
        Me.StackCheck.Size = New System.Drawing.Size(65, 21)
        Me.StackCheck.TabIndex = 2
        Me.StackCheck.Text = "Stacks"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Resistance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 21)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Damage type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DamageType
        '
        Me.DamageType.Location = New System.Drawing.Point(100, 15)
        Me.DamageType.Name = "DamageType"
        '
        'DamageType.Properties
        '
        Me.DamageType.Properties.AutoHeight = False
        Me.DamageType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageType.Properties.DropDownRows = 10
        Me.DamageType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageType.Size = New System.Drawing.Size(200, 21)
        Me.DamageType.TabIndex = 0
        '
        'Resistance
        '
        Me.Resistance.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Resistance.Location = New System.Drawing.Point(100, 45)
        Me.Resistance.Name = "Resistance"
        '
        'Resistance.Properties
        '
        Me.Resistance.Properties.Appearance.Options.UseTextOptions = True
        Me.Resistance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Resistance.Properties.AutoHeight = False
        Me.Resistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Resistance.Properties.IsFloatValue = False
        Me.Resistance.Properties.Mask.EditMask = "d"
        Me.Resistance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Resistance.Properties.MaxValue = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Resistance.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Resistance.Size = New System.Drawing.Size(70, 21)
        Me.Resistance.TabIndex = 1
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
        'DamageResistanceForm
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
        Me.Name = "DamageResistanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DamageResistanceForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.DamageType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Resistance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mInitOK As Boolean = True

    'init
    Public Sub Init()
        Dim Existing As Objects.ObjectDataCollection
        Dim Obj As Objects.ObjectData

        Try
            'initialise controls

            'check to see if there are existing objects of this type
            'if so, remove their resistance type from the list
            Existing = mObject.Parent.ChildrenOfType(Objects.DamageResistanceType)
            If Existing.Contains(mObject.ObjectGUID) Then Existing.Remove(mObject.ObjectGUID)

            If Not Existing.Count = 0 Then
                Dim DamageTypes As ArrayList = New ArrayList(Rules.Lists.DamageTypesResistance)

                For Each Obj In Existing
                    DamageTypes.Remove(Obj.Element("DamageType"))
                Next

                If DamageTypes.Count = 0 Then
                    General.ShowInfoDialog("This component already has a resistance to all damage types.")
                    mInitOK = False
                    Exit Sub
                End If

                DamageType.Properties.Items.AddRange(DamageTypes.ToArray)
            Else
                DamageType.Properties.Items.AddRange(Rules.Lists.DamageTypesResistance)
            End If

            'init properties tab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.Type = Objects.DamageResistanceType
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Damage Resistance"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls

            'this form returns false if the form should not be displayed
            Return mInitOK

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'inir form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Damage Resistance"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            DamageType.Text = mObject.Element("DamageType")
            Resistance.EditValue = mObject.ElementAsInteger("ResistanceReduction")
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
                        CharacterManager.SetAllDirty()
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                End Select

                'updates common to add and edit
                mObject.Name = "Damage Resistance " & Resistance.Text & " [" & DamageType.Text & "]"
                mObject.Element("DamageType") = DamageType.Text
                mObject.Element("ResistanceReduction") = Resistance.Text
                If StackCheck.Checked Then mObject.Element("Stacks") = "Yes" Else mObject.Element("Stacks") = ""

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
            Validate = General.ValidateForm(Basics.Controls, Errors)
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class

