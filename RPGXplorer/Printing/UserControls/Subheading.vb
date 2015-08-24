Option Explicit On 
Option Strict On

Imports System.Drawing

Public Class Subheading
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
        'Subheading
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Name = "Subheading"
        Me.Size = New System.Drawing.Size(152, 40)

    End Sub

#End Region

    <CLSCompliant(False)> Public _SubheadingText As String = "TEST"

    Public Property SubheadingText() As String
        Get
            Return _SubheadingText
        End Get
        Set(ByVal Value As String)
            _SubheadingText = Value
        End Set
    End Property

    Private Sub Subheading_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim rect As Rectangle
        Dim lrect As RectangleF
        Dim font As New Font("Arial", 8)
        Dim format As New StringFormat

        Try
            rect = New Rectangle(Me.Left, Me.Top, Me.Width - 1, Me.Height - 1)
            e.Graphics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.DrawRectangle(Pens.DimGray, rect)

            lrect = New RectangleF(Me.Left, Me.Top, Me.Width - 1, Me.Height - 1)
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center
            'e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            e.Graphics.DrawString(SubheadingText, font, Brushes.Black, lrect, format)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
