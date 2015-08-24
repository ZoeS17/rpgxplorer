Option Explicit On 
Option Strict On

Public Class AttributeScore
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'AttributeScore
        '
        Me.Name = "AttributeScore"
        Me.Size = New System.Drawing.Size(48, 48)

    End Sub

#End Region

    <CLSCompliant(False)> Public _Score As String = "14"
    <CLSCompliant(False)> Public _Modifier As String = "+1"

    Public Property Score() As String
        Get
            Return _Score
        End Get
        Set(ByVal Value As String)
            _Score = Value
        End Set
    End Property

    Public Property Modifier() As String
        Get
            Return _Modifier
        End Get
        Set(ByVal Value As String)
            _Modifier = Value
        End Set
    End Property

    Private Sub AttributeScore_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim rect As Rectangle
        Dim lrect As RectangleF
        Dim font As New Font("Arial", 14, FontStyle.Bold)
        Dim format As New StringFormat
        Dim pen As New Pen(Color.DimGray, 2)

        rect = New Rectangle(Me.Left + 1, Me.Top + 1, Me.Width - 3, Me.Height - 3)
        pen.Alignment = Drawing2D.PenAlignment.Inset
        e.Graphics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawEllipse(pen, rect)

        lrect = New RectangleF(Me.Left, Me.Top, Me.Width - 1, CType(Me.Height * 0.8, Single))
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        e.Graphics.DrawString(_Score, font, Brushes.Black, lrect, format)

        font = New Font("Arial", 10)
        lrect = New RectangleF(Me.Left, Me.Top + CType(Me.Height / 2, Single), Me.Width - 1, CType(Me.Height * 0.5, Single))
        e.Graphics.DrawString(_Modifier, font, Brushes.Black, lrect, format)
    End Sub

    Private Sub AttributeScore_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub
End Class
