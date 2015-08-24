Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SimpleSelectorDialog
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
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents SelectDropdown As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SimpleSelectorDialog))
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.SelectDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.SelectDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(-115, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(415, 5)
        Me.IndentedLine2.TabIndex = 90
        Me.IndentedLine2.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(230, 65)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(150, 65)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(80, 21)
        Me.ObjLabel.TabIndex = 92
        Me.ObjLabel.Text = "Label"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectDropdown
        '
        Me.SelectDropdown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectDropdown.Location = New System.Drawing.Point(100, 15)
        Me.SelectDropdown.Name = "SelectDropdown"
        '
        'SelectDropdown.Properties
        '
        Me.SelectDropdown.Properties.AutoHeight = False
        Me.SelectDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SelectDropdown.Properties.DropDownRows = 10
        'Me.SelectDropdown.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
        '                Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
        '                Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
        '                Or DevExpress.Utils.StyleOptions.UseFont) _
        '                Or DevExpress.Utils.StyleOptions.UseForeColor) _
        '                Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
        '                Or DevExpress.Utils.StyleOptions.UseImage) _
        '                Or DevExpress.Utils.StyleOptions.UseWordWrap) _
        '                Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.SelectDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SelectDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SelectDropdown.TabIndex = 0
        '
        'SimpleSelectorDialog
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(314, 103)
        Me.Controls.Add(Me.SelectDropdown)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SimpleSelectorDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selector Dialog"
        CType(Me.SelectDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mType As String
    Private mSelectType As String
    Private mFKElementName As String
    Private mExcludeList As ArrayList

    'index
    Private ObjIndex As DataListItem()

    'ret val
    Public SelectedValue As Objects.ObjectKey
    Public SelectedText As String

    'init
    Public Sub Init(ByVal SelectLabel As String, ByVal Caption As String, ByVal List As DataListItem())
        Try
            ObjLabel.Text = SelectLabel
            Me.Text = Caption

            'init index
            ObjIndex = List

            'initialise controls
            SelectDropdown.Properties.Items.AddRange(ObjIndex)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.Validate Then
                SelectedValue = CType(SelectDropdown.SelectedItem, DataListItem).ObjectGUID
                SelectedText = SelectDropdown.Text
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
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

End Class
