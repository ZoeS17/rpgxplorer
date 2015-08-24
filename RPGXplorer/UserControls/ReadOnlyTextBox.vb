Public Class ReadOnlyTextBox

    <CLSCompliant(False)> Public _LineColor As Color = System.Drawing.Color.FromArgb(172, 168, 153)
    <CLSCompliant(False)> Public _Caption As String
    <CLSCompliant(False)> Public _Alignment As Drawing.ContentAlignment
    <CLSCompliant(False)> Public _TextColor As Color
    <CLSCompliant(False)> Public _Vertical As Boolean

    Public Property LineColor() As System.Drawing.Color
        Get
            Return _LineColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            _LineColor = Value
            Me.Refresh()
        End Set
    End Property

    Public Property TextColor() As System.Drawing.Color
        Get
            Return _TextColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            Me.ForeColor = Value
            _TextColor = Value
            Me.Refresh()
        End Set
    End Property

    Public Property Caption() As String
        Get
            Return _Caption
        End Get
        Set(ByVal Value As String)
            _Caption = Value
            Me.Refresh()
        End Set
    End Property

    Public Property CaptionAligment() As Drawing.ContentAlignment
        Get
            Return _Alignment
        End Get
        Set(ByVal Value As Drawing.ContentAlignment)
            _Alignment = Value
            Me.Refresh()
        End Set
    End Property

    Public Property Vertical() As Boolean
        Get
            Return _Vertical
        End Get
        Set(ByVal Value As Boolean)
            _Vertical = Value
            Me.Refresh()
        End Set
    End Property

    Public Shadows Property Text() As String
        Get
            Return _Caption
        End Get
        Set(ByVal Value As String)
            _Caption = Value
            Me.Refresh()
        End Set
    End Property

    Private Sub ReadOnlyTextBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        'Dim gradbrush As New Drawing2D.LinearGradientBrush(rect, Me.BackColor, Me.BackColor, Drawing2D.LinearGradientMode.ForwardDiagonal)
        'e.Graphics.FillRectangle(New System.Drawing.SolidBrush(Me.BackColor))
        'e.Graphics.FillRectangle(gradbrush, rect)
        e.Graphics.DrawRectangle(New Pen(_LineColor, 1), rect)

        Dim format As New StringFormat
        format.LineAlignment = StringAlignment.Center
        Select Case _Alignment
            Case ContentAlignment.MiddleLeft
                format.Alignment = StringAlignment.Near
            Case ContentAlignment.MiddleCenter
                format.Alignment = StringAlignment.Center
            Case ContentAlignment.MiddleRight
                format.Alignment = StringAlignment.Far
        End Select
        format.Trimming = StringTrimming.EllipsisCharacter
        format.FormatFlags = StringFormatFlags.NoWrap

        'Dim NewFont As New Font("Microsoft Sans Serif", 8)
        e.Graphics.DrawString(_Caption, Me.Font, New SolidBrush(_TextColor), New RectangleF(rect.X, rect.Y, Me.Width, Me.Height), format)

    End Sub

End Class
