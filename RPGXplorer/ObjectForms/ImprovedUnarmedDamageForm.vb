Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ImprovedUnarmedDamageForm
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
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents MainTab As System.Windows.Forms.TabPage
    Public WithEvents DamageSmall As DevExpress.XtraEditors.TextEdit
    Public WithEvents DamageMedium As DevExpress.XtraEditors.TextEdit
    Public WithEvents DamageLarge As DevExpress.XtraEditors.TextEdit
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MainTab = New System.Windows.Forms.TabPage
        Me.DamageLarge = New DevExpress.XtraEditors.TextEdit
        Me.DamageMedium = New DevExpress.XtraEditors.TextEdit
        Me.DamageSmall = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.MainTab.SuspendLayout()
        CType(Me.DamageLarge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageMedium.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageSmall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MainTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.DamageLarge)
        Me.MainTab.Controls.Add(Me.DamageMedium)
        Me.MainTab.Controls.Add(Me.DamageSmall)
        Me.MainTab.Controls.Add(Me.Label3)
        Me.MainTab.Controls.Add(Me.Label1)
        Me.MainTab.Controls.Add(Me.Label2)
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Size = New System.Drawing.Size(407, 349)
        Me.MainTab.TabIndex = 2
        Me.MainTab.Text = "Improved Unarmed Damage"
        '
        'DamageLarge
        '
        Me.DamageLarge.EditValue = ""
        Me.DamageLarge.Location = New System.Drawing.Point(75, 75)
        Me.DamageLarge.Name = "DamageLarge"
        '
        'DamageLarge.Properties
        '
        Me.DamageLarge.Properties.AutoHeight = False
        Me.DamageLarge.Properties.MaxLength = 10
        Me.DamageLarge.Size = New System.Drawing.Size(75, 21)
        Me.DamageLarge.TabIndex = 3
        '
        'DamageMedium
        '
        Me.DamageMedium.EditValue = ""
        Me.DamageMedium.Location = New System.Drawing.Point(75, 45)
        Me.DamageMedium.Name = "DamageMedium"
        '
        'DamageMedium.Properties
        '
        Me.DamageMedium.Properties.AutoHeight = False
        Me.DamageMedium.Properties.MaxLength = 10
        Me.DamageMedium.Size = New System.Drawing.Size(75, 21)
        Me.DamageMedium.TabIndex = 1
        '
        'DamageSmall
        '
        Me.DamageSmall.EditValue = ""
        Me.DamageSmall.Location = New System.Drawing.Point(75, 15)
        Me.DamageSmall.Name = "DamageSmall"
        '
        'DamageSmall.Properties
        '
        Me.DamageSmall.Properties.AutoHeight = False
        Me.DamageSmall.Properties.Mask.BeepOnError = True
        Me.DamageSmall.Properties.Mask.ShowPlaceHolders = False
        Me.DamageSmall.Properties.MaxLength = 10
        Me.DamageSmall.Size = New System.Drawing.Size(75, 21)
        Me.DamageSmall.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Large"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Medium"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Small"
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
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 405)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 4
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
        Me.OK.TabIndex = 3
        Me.OK.Text = "OK"
        '
        'ImprovedUnarmedDamageForm
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
        Me.Name = "ImprovedUnarmedDamageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprovedUnarmedDamageForm"
        Me.TabControl1.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        CType(Me.DamageLarge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageMedium.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageSmall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
            mObject.Name = "Improved Unarmed Damage"
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.ImprovedUnarmedDamageType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Improved Unarmed Damage"
            Me.Icon = New Icon(General.BasePath & "Icons\row_add.ico")
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
            Me.Text = "Edit Improved Unarmed Damage"
            Me.Icon = New Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            Me.DamageSmall.Text = mObject.Element("DamageSmall")
            Me.DamageMedium.Text = mObject.Element("DamageMedium")
            Me.DamageLarge.Text = mObject.Element("DamageLarge")

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
                        'do nothing yet
                End Select

                'updates common to add and edit
                mObject.Element("DamageSmall") = Me.DamageSmall.Text
                mObject.Element("DamageMedium") = Me.DamageMedium.Text
                mObject.Element("DamageLarge") = Me.DamageLarge.Text

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
            Validate = General.ValidateForm(Me.MainTab.Controls, Errors)

            If DamageSmall.Text <> "" Then
                If Not Rules.Dice.ValidDiceRange(DamageSmall.Text) Then
                    Errors.SetError(DamageSmall, General.ValidationDiceRange)
                    Validate = False
                Else
                    Errors.SetError(DamageSmall, "")
                End If
            End If

            If DamageMedium.Text <> "" Then
                If Not Rules.Dice.ValidDiceRange(DamageMedium.Text) Then
                    Errors.SetError(DamageMedium, General.ValidationDiceRange)
                    Validate = False
                Else
                    Errors.SetError(DamageMedium, "")
                End If
            End If

            If DamageLarge.Text <> "" Then
                If Not Rules.Dice.ValidDiceRange(DamageLarge.Text) Then
                    Errors.SetError(DamageLarge, General.ValidationDiceRange)
                    Validate = False
                Else
                    Errors.SetError(DamageLarge, "")
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class

