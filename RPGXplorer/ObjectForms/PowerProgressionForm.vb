Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class PowerProgressionForm
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
    Public WithEvents Basics As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents ClassLevel As DevExpress.XtraEditors.TextEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Points As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Powers As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Level As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.Level = New DevExpress.XtraEditors.SpinEdit
        Me.Powers = New DevExpress.XtraEditors.SpinEdit
        Me.Points = New DevExpress.XtraEditors.SpinEdit
        Me.ClassLevel = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Powers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Points.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Basics.Controls.Add(Me.Level)
        Me.Basics.Controls.Add(Me.Powers)
        Me.Basics.Controls.Add(Me.Points)
        Me.Basics.Controls.Add(Me.ClassLevel)
        Me.Basics.Controls.Add(Me.Label2)
        Me.Basics.Controls.Add(Me.Label1)
        Me.Basics.Controls.Add(Me.IndentedLine1)
        Me.Basics.Controls.Add(Me.Label3)
        Me.Basics.Controls.Add(Me.Label11)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 349)
        Me.Basics.TabIndex = 0
        Me.Basics.Text = "Power Progression"
        '
        'Level
        '
        Me.Level.CausesValidation = False
        Me.Level.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Level.Enabled = False
        Me.Level.Location = New System.Drawing.Point(135, 125)
        Me.Level.Name = "Level"
        '
        'Level.Properties
        '
        Me.Level.Properties.Appearance.Options.UseTextOptions = True
        Me.Level.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level.Properties.AutoHeight = False
        Me.Level.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Level.Properties.IsFloatValue = False
        Me.Level.Properties.Mask.EditMask = "d"
        Me.Level.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Level.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level.Size = New System.Drawing.Size(60, 21)
        Me.Level.TabIndex = 144
        '
        'Powers
        '
        Me.Powers.CausesValidation = False
        Me.Powers.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Powers.Location = New System.Drawing.Point(135, 95)
        Me.Powers.Name = "Powers"
        '
        'Powers.Properties
        '
        Me.Powers.Properties.Appearance.Options.UseTextOptions = True
        Me.Powers.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Powers.Properties.AutoHeight = False
        Me.Powers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Powers.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Powers.Properties.IsFloatValue = False
        Me.Powers.Properties.Mask.EditMask = "d"
        Me.Powers.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Powers.Size = New System.Drawing.Size(60, 21)
        Me.Powers.TabIndex = 143
        '
        'Points
        '
        Me.Points.CausesValidation = False
        Me.Points.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Points.Location = New System.Drawing.Point(135, 65)
        Me.Points.Name = "Points"
        '
        'Points.Properties
        '
        Me.Points.Properties.Appearance.Options.UseTextOptions = True
        Me.Points.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Points.Properties.AutoHeight = False
        Me.Points.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Points.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Points.Properties.IsFloatValue = False
        Me.Points.Properties.Mask.EditMask = "d"
        Me.Points.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Points.Size = New System.Drawing.Size(60, 21)
        Me.Points.TabIndex = 142
        '
        'ClassLevel
        '
        Me.ClassLevel.Location = New System.Drawing.Point(60, 15)
        Me.ClassLevel.Name = "ClassLevel"
        '
        'ClassLevel.Properties
        '
        Me.ClassLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.ClassLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ClassLevel.Properties.AutoHeight = False
        Me.ClassLevel.Properties.MaxLength = 50
        Me.ClassLevel.Properties.ReadOnly = True
        Me.ClassLevel.Size = New System.Drawing.Size(40, 21)
        Me.ClassLevel.TabIndex = 0
        Me.ClassLevel.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(15, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Max Power Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Powers  Known"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 119
        Me.IndentedLine1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Power Points / Day"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 21)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Level"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'PowerProgressionForm
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
        Me.Name = "PowerProgressionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PowerProgressionForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Powers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Points.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mMode As FormMode
    Private PreviousLevel As Objects.ObjectData

    'init
    Public Sub Init()
        Try
            'initialise controls
            TabControl1.TabPages(0).Text = mObject.Parent.Name & " Level"

            Points.Properties.MinValue = 0
            Points.Properties.MaxValue = 999

            Powers.Properties.MinValue = 0
            Powers.Properties.MaxValue = 99

            Level.Properties.MinValue = 0
            Level.Properties.MaxValue = 9

            Level.Properties.DisplayFormat.Format = New Rules.PsionicFormatter
            Level.Properties.EditFormat.Format = New Rules.PsionicFormatter

            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            mObject = Obj
            mMode = FormMode.Edit
            Me.Text = "Edit Power Progression"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ClassLevel.Text = mObject.Element("Level")
            Points.Text = mObject.Element("PowerPoints")
            Powers.Text = mObject.Element("PowersKnown")
            Level.Text = Sorter.StripLeftNumbers(mObject.Element("MaxPowerLevel")).ToString

            PreviousLevel = Objects.GetObjectByXPath(XML.DBTypes.Classes, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & mObject.ParentGUID.ToString & "' and Name='Level " & (mObject.ElementAsInteger("Level") - 1).ToString & "']")

            'check previous level
            If mObject.ElementAsInteger("Level") > 1 Then

                If CType(Points.Text, Integer) < PreviousLevel.ElementAsInteger("PowerPoints") Then
                    Points.Text = PreviousLevel.Element("PowerPoints")
                End If

                If CType(Powers.Text, Integer) < PreviousLevel.ElementAsInteger("PowersKnown") Then
                    Powers.Text = PreviousLevel.Element("PowersKnown")
                End If

                If Level.Value < Sorter.StripLeftNumbers(PreviousLevel.Element("MaxPowerLevel")) Then
                    Level.Value = Sorter.StripLeftNumbers(PreviousLevel.Element("MaxPowerLevel"))
                End If

            End If

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
                        'do nothing
                    Case FormMode.Edit
                        'do nothing
                End Select

                'updates common to add and edit
                mObject.Element("PowerPoints") = Points.Text
                mObject.Element("PowersKnown") = Powers.Text
                mObject.Element("MaxPowerLevel") = Level.Text

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

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = True

            If Points.Value < PreviousLevel.ElementAsInteger("PowerPoints") Then
                Errors.SetError(Points, "This number cannot be less than the previous Power Points")
                Validate = False
            Else
                Errors.SetError(Points, "")
            End If

            If Powers.Value < PreviousLevel.ElementAsInteger("PowersKnown") Then
                Errors.SetError(Powers, "This number cannot be less than the previous Powers Known")
                Validate = False
            Else
                Errors.SetError(Powers, "")
            End If

            If Level.Value < Sorter.StripLeftNumbers(PreviousLevel.Element("MaxPowerLevel")) Then
                Errors.SetError(Level, "This number cannot be less than the previous Maximum Power Level")
                Validate = False
            Else
                Errors.SetError(Level, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

            Return Validate

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

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

    'enable/disable max level control
    Private Sub Powers_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Powers.EditValueChanged
        Try
            If Powers.Value > 0 Then
                Level.Enabled = True
                Label2.Enabled = True
                Level.Properties.MinValue = 1
            Else
                Label2.Enabled = False
                Level.Enabled = False
                Level.Properties.MinValue = 0
                Level.Value = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Points_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Points.Leave
        If Points.Value > Points.Properties.MaxValue Then
            Points.Value = Points.Properties.MaxValue
        ElseIf Points.Value < Points.Properties.MinValue Then
            Points.Value = Points.Properties.MinValue
        End If
    End Sub

    Private Sub Powers_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Powers.Leave
        If Powers.Value > Powers.Properties.MaxValue Then
            Powers.Value = Powers.Properties.MaxValue
        ElseIf Powers.Value < Powers.Properties.MinValue Then
            Powers.Value = Powers.Properties.MinValue
        End If
    End Sub

End Class
