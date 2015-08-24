Public Class NumericKeypad
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Public WithEvents Value9 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value8 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value7 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value6 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value3 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value4 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value5 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value2 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Value0 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Value9 = New DevExpress.XtraEditors.SimpleButton
        Me.Value8 = New DevExpress.XtraEditors.SimpleButton
        Me.Value7 = New DevExpress.XtraEditors.SimpleButton
        Me.Value6 = New DevExpress.XtraEditors.SimpleButton
        Me.Value3 = New DevExpress.XtraEditors.SimpleButton
        Me.Value4 = New DevExpress.XtraEditors.SimpleButton
        Me.Value5 = New DevExpress.XtraEditors.SimpleButton
        Me.Value2 = New DevExpress.XtraEditors.SimpleButton
        Me.Value1 = New DevExpress.XtraEditors.SimpleButton
        Me.Value0 = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'Value9
        '
        Me.Value9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value9.Location = New System.Drawing.Point(75, 75)
        Me.Value9.Name = "Value9"
        Me.Value9.Size = New System.Drawing.Size(35, 35)
        'Me.Value9.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value9.TabIndex = 27
        Me.Value9.Text = "9"
        '
        'Value8
        '
        Me.Value8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value8.Location = New System.Drawing.Point(40, 75)
        Me.Value8.Name = "Value8"
        Me.Value8.Size = New System.Drawing.Size(35, 35)
        'Me.Value8.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value8.TabIndex = 26
        Me.Value8.Text = "8"
        '
        'Value7
        '
        Me.Value7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value7.Location = New System.Drawing.Point(5, 75)
        Me.Value7.Name = "Value7"
        Me.Value7.Size = New System.Drawing.Size(35, 35)
        'Me.Value7.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value7.TabIndex = 25
        Me.Value7.Text = "7"
        '
        'Value6
        '
        Me.Value6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value6.Location = New System.Drawing.Point(75, 40)
        Me.Value6.Name = "Value6"
        Me.Value6.Size = New System.Drawing.Size(35, 35)
        'Me.Value6.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value6.TabIndex = 24
        Me.Value6.Text = "6"
        '
        'Value3
        '
        Me.Value3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value3.Location = New System.Drawing.Point(75, 5)
        Me.Value3.Name = "Value3"
        Me.Value3.Size = New System.Drawing.Size(35, 35)
        'Me.Value3.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value3.TabIndex = 23
        Me.Value3.Text = "3"
        '
        'Value4
        '
        Me.Value4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value4.Location = New System.Drawing.Point(5, 40)
        Me.Value4.Name = "Value4"
        Me.Value4.Size = New System.Drawing.Size(35, 35)
        'Me.Value4.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value4.TabIndex = 22
        Me.Value4.Text = "4"
        '
        'Value5
        '
        Me.Value5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value5.Location = New System.Drawing.Point(40, 40)
        Me.Value5.Name = "Value5"
        Me.Value5.Size = New System.Drawing.Size(35, 35)
        'Me.Value5.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value5.TabIndex = 21
        Me.Value5.Text = "5"
        '
        'Value2
        '
        Me.Value2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value2.Location = New System.Drawing.Point(40, 5)
        Me.Value2.Name = "Value2"
        Me.Value2.Size = New System.Drawing.Size(35, 35)
        'Me.Value2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value2.TabIndex = 20
        Me.Value2.Text = "2"
        '
        'Value1
        '
        Me.Value1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value1.Location = New System.Drawing.Point(5, 5)
        Me.Value1.Name = "Value1"
        Me.Value1.Size = New System.Drawing.Size(35, 35)
        'Me.Value1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value1.TabIndex = 19
        Me.Value1.Text = "1"
        '
        'Value0
        '
        Me.Value0.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.Value0.Location = New System.Drawing.Point(40, 110)
        Me.Value0.Name = "Value0"
        Me.Value0.Size = New System.Drawing.Size(35, 35)
        'Me.Value0.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.Value0.TabIndex = 28
        Me.Value0.Text = "0"
        '
        'NumericKeypad
        '
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.Value0)
        Me.Controls.Add(Me.Value9)
        Me.Controls.Add(Me.Value8)
        Me.Controls.Add(Me.Value7)
        Me.Controls.Add(Me.Value6)
        Me.Controls.Add(Me.Value3)
        Me.Controls.Add(Me.Value4)
        Me.Controls.Add(Me.Value5)
        Me.Controls.Add(Me.Value2)
        Me.Controls.Add(Me.Value1)
        Me.Name = "NumericKeypad"
        Me.Size = New System.Drawing.Size(115, 150)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
