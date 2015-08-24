<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d4
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Value3 = New DevExpress.XtraEditors.SimpleButton
        Me.Value4 = New DevExpress.XtraEditors.SimpleButton
        Me.Value2 = New DevExpress.XtraEditors.SimpleButton
        Me.Value1 = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'Value3
        '
        Me.Value3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value3.Location = New System.Drawing.Point(3, 38)
        Me.Value3.Name = "Value3"
        Me.Value3.Size = New System.Drawing.Size(35, 35)
        'Me.Value3.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value3.TabIndex = 2
        Me.Value3.Text = "3"
        '
        'Value4
        '
        Me.Value4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value4.Location = New System.Drawing.Point(38, 38)
        Me.Value4.Name = "Value4"
        Me.Value4.Size = New System.Drawing.Size(35, 35)
        'Me.Value4.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value4.TabIndex = 3
        Me.Value4.Text = "4"
        '
        'Value2
        '
        Me.Value2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value2.Location = New System.Drawing.Point(38, 3)
        Me.Value2.Name = "Value2"
        Me.Value2.Size = New System.Drawing.Size(35, 35)
        'Me.Value2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value2.TabIndex = 1
        Me.Value2.Text = "2"
        '
        'Value1
        '
        Me.Value1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value1.Location = New System.Drawing.Point(3, 3)
        Me.Value1.Name = "Value1"
        Me.Value1.Size = New System.Drawing.Size(35, 35)
        'Me.Value1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value1.TabIndex = 0
        Me.Value1.Text = "1"
        '
        'd4
        '
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.Value3)
        Me.Controls.Add(Me.Value4)
        Me.Controls.Add(Me.Value2)
        Me.Controls.Add(Me.Value1)
        Me.Name = "d4"
        Me.Size = New System.Drawing.Size(76, 76)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Value1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value3 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value4 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value2 As DevExpress.XtraEditors.SimpleButton

End Class
