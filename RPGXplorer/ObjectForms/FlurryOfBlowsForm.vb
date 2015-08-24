Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class FlurryOfBlowsForm
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
    Public WithEvents Penalty As RPGXplorer.Modifier
    Public WithEvents BonusAttacks As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents MainTab As System.Windows.Forms.TabPage
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MainTab = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.BonusAttacks = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Penalty = New RPGXplorer.Modifier
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.MainTab.SuspendLayout()
        CType(Me.BonusAttacks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MainTab.Controls.Add(Me.Label3)
        Me.MainTab.Controls.Add(Me.BonusAttacks)
        Me.MainTab.Controls.Add(Me.Label2)
        Me.MainTab.Controls.Add(Me.Penalty)
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Size = New System.Drawing.Size(407, 349)
        Me.MainTab.TabIndex = 2
        Me.MainTab.Text = "Flurry of Blows"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Penalty to all attacks"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BonusAttacks
        '
        Me.BonusAttacks.CausesValidation = False
        Me.BonusAttacks.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BonusAttacks.Location = New System.Drawing.Point(130, 15)
        Me.BonusAttacks.Name = "BonusAttacks"
        '
        'BonusAttacks.Properties
        '
        Me.BonusAttacks.Properties.Appearance.Options.UseTextOptions = True
        Me.BonusAttacks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BonusAttacks.Properties.AutoHeight = False
        Me.BonusAttacks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.BonusAttacks.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.BonusAttacks.Properties.MaxValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.BonusAttacks.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BonusAttacks.Size = New System.Drawing.Size(50, 21)
        Me.BonusAttacks.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Bonus attacks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Penalty
        '
        Me.Penalty.CausesValidation = False
        Me.Penalty.Location = New System.Drawing.Point(130, 45)
        Me.Penalty.Name = "Penalty"
        Me.Penalty.Size = New System.Drawing.Size(50, 21)
        Me.Penalty.TabIndex = 1
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
        'FlurryOfBlowsForm
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
        Me.Name = "FlurryOfBlowsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlurryOfBlowsForm"
        Me.TabControl1.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        CType(Me.BonusAttacks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
            Penalty.ModifierSpin.Properties.MinValue = -5
            Penalty.ModifierSpin.Properties.MaxValue = 0
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
            mObject.Type = Objects.FlurryOfBlowsType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Flurry of Blows"
            Me.Icon = New Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim temp As String = ""

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form 
            Me.Text = "Edit Flurry of Blows"
            Me.Icon = New Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            Me.BonusAttacks.Text = mObject.Element("BonusAttacks")
            Me.Penalty.Text = mObject.Element("Penalty")

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
                mObject.Element("BonusAttacks") = Me.BonusAttacks.Text
                mObject.Element("Penalty") = Me.Penalty.Text
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
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class

