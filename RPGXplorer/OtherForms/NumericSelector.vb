Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class NumericSelector
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
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents SpinEdit As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.SpinEdit = New DevExpress.XtraEditors.SpinEdit
        CType(Me.SpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(95, 21)
        Me.ObjLabel.TabIndex = 96
        Me.ObjLabel.Text = "Label"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(252, 5)
        Me.IndentedLine2.TabIndex = 95
        Me.IndentedLine2.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(197, 67)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 94
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(117, 67)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 93
        Me.OK.Text = "OK"
        '
        'SpinEdit
        '
        Me.SpinEdit.AllowDrop = True
        Me.SpinEdit.EditValue = 1
        Me.SpinEdit.Location = New System.Drawing.Point(115, 15)
        Me.SpinEdit.Name = "SpinEdit"
        '
        'SpinEdit.Properties
        '
        Me.SpinEdit.Properties.AutoHeight = False
        Me.SpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit.Properties.IsFloatValue = False
        Me.SpinEdit.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        'TODO - Me.SpinEdit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor)                         Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis)                         Or DevExpress.Utils.StyleOptions.UseDrawFocusRect)                        Or DevExpress.Utils.StyleOptions.UseFont)                        Or DevExpress.Utils.StyleOptions.UseForeColor)                         Or DevExpress.Utils.StyleOptions.UseHorzAlignment)                         Or DevExpress.Utils.StyleOptions.UseImage)                         Or DevExpress.Utils.StyleOptions.UseWordWrap)                         Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), False, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.SpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpinEdit.Size = New System.Drawing.Size(80, 21)
        Me.SpinEdit.TabIndex = 97
        '
        'NumericSelector
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(279, 103)
        Me.Controls.Add(Me.SpinEdit)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NumericSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NumericSelector"
        CType(Me.SpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Value As Integer

    'init
    Public Sub Init(ByVal SelectLabel As String, ByVal Caption As String, ByVal MinValue As Integer, ByVal MaxValue As Integer, ByVal DefaultValue As Integer)
        Try
            ObjLabel.Text = SelectLabel
            Me.Text = Caption

            'init index
            SpinEdit.Properties.MinValue = MinValue
            SpinEdit.Properties.MaxValue = MaxValue

            If DefaultValue > MaxValue Then
                DefaultValue = MaxValue
            ElseIf DefaultValue < MinValue Then
                DefaultValue = MinValue
            End If

            SpinEdit.Value = DefaultValue

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Value = CInt(SpinEdit.Value)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
    End Sub

End Class
