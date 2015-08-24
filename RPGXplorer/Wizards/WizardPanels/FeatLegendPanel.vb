Imports RPGXplorer.Rules


Public Class FeatLegendPanel
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        FeatBlock.BackColor = Constants.NormalFeatColor
        FighterBlock.BackColor = Constants.FighterBonusFeatColor
        FailedBlock.BackColor = Constants.FailedFeatColor
        TakenBlock.BackColor = Constants.TakenFeatColor

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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TakenBlock As System.Windows.Forms.Panel
    Public WithEvents FeatBlock As System.Windows.Forms.Panel
    Public WithEvents FighterBlock As System.Windows.Forms.Panel
    Public WithEvents FailedBlock As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FeatBlock = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FighterBlock = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.FailedBlock = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.TakenBlock = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'FeatBlock
        '
        Me.FeatBlock.BackColor = System.Drawing.SystemColors.Control
        Me.FeatBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FeatBlock.Location = New System.Drawing.Point(15, 15)
        Me.FeatBlock.Name = "FeatBlock"
        Me.FeatBlock.Size = New System.Drawing.Size(25, 25)
        Me.FeatBlock.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Normal Feat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(55, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fighter Bonus Feat"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FighterBlock
        '
        Me.FighterBlock.BackColor = System.Drawing.SystemColors.Control
        Me.FighterBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FighterBlock.Location = New System.Drawing.Point(15, 50)
        Me.FighterBlock.Name = "FighterBlock"
        Me.FighterBlock.Size = New System.Drawing.Size(25, 25)
        Me.FighterBlock.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(215, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Failed Prerequisites"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FailedBlock
        '
        Me.FailedBlock.BackColor = System.Drawing.SystemColors.Control
        Me.FailedBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FailedBlock.Location = New System.Drawing.Point(175, 15)
        Me.FailedBlock.Name = "FailedBlock"
        Me.FailedBlock.Size = New System.Drawing.Size(25, 25)
        Me.FailedBlock.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(215, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Already Taken"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TakenBlock
        '
        Me.TakenBlock.BackColor = System.Drawing.SystemColors.Control
        Me.TakenBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TakenBlock.Location = New System.Drawing.Point(175, 50)
        Me.TakenBlock.Name = "TakenBlock"
        Me.TakenBlock.Size = New System.Drawing.Size(25, 25)
        Me.TakenBlock.TabIndex = 8
        '
        'FeatLegendPanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(362, 88)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TakenBlock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FailedBlock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FighterBlock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FeatBlock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FeatLegendPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Feat Legend"
        Me.TopMost = True
        Me.ResumeLayout(False)

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
