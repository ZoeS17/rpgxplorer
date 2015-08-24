Option Strict On
Option Explicit On

Public Class PanelBase
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
        'PanelBase
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Name = "PanelBase"
        Me.Size = New System.Drawing.Size(500, 400)

    End Sub

#End Region

    Private Sub PanelBase_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If Me.Width > 0 And Me.Height > 0 Then
            Dim g As Graphics = e.Graphics
            Dim gradbrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, Color.White, SystemColors.ControlLight, Drawing2D.LinearGradientMode.ForwardDiagonal)

            g.FillRectangle(gradbrush, Me.DisplayRectangle)
        End If
    End Sub

    Private Sub PanelBase_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

End Class
