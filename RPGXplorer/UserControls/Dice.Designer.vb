<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dice
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
        Me.D8 = New RPGXplorer.d8
        Me.D10 = New RPGXplorer.d10
        Me.D6 = New RPGXplorer.d6
        Me.D4 = New RPGXplorer.d4
        Me.D12 = New RPGXplorer.d12
        Me.SuspendLayout()
        '
        'D8
        '
        Me.D8.BackColor = System.Drawing.Color.LightGray
        Me.D8.Location = New System.Drawing.Point(0, 0)
        Me.D8.Name = "D8"
        Me.D8.Size = New System.Drawing.Size(146, 76)
        Me.D8.TabIndex = 0
        Me.D8.Visible = False
        '
        'D10
        '
        Me.D10.BackColor = System.Drawing.Color.Silver
        Me.D10.Location = New System.Drawing.Point(0, 0)
        Me.D10.Name = "D10"
        Me.D10.Size = New System.Drawing.Size(181, 76)
        Me.D10.TabIndex = 1
        Me.D10.Visible = False
        '
        'D6
        '
        Me.D6.BackColor = System.Drawing.Color.LightGray
        Me.D6.Location = New System.Drawing.Point(0, 0)
        Me.D6.Name = "D6"
        Me.D6.Size = New System.Drawing.Size(111, 76)
        Me.D6.TabIndex = 2
        Me.D6.Visible = False
        '
        'D4
        '
        Me.D4.BackColor = System.Drawing.Color.LightGray
        Me.D4.Location = New System.Drawing.Point(0, 0)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(76, 76)
        Me.D4.TabIndex = 3
        Me.D4.Visible = False
        '
        'D12
        '
        Me.D12.BackColor = System.Drawing.Color.Silver
        Me.D12.Location = New System.Drawing.Point(0, 0)
        Me.D12.Name = "D12"
        Me.D12.Size = New System.Drawing.Size(216, 76)
        Me.D12.TabIndex = 4
        '
        'Dice
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.D12)
        Me.Controls.Add(Me.D4)
        Me.Controls.Add(Me.D6)
        Me.Controls.Add(Me.D10)
        Me.Controls.Add(Me.D8)
        Me.Name = "Dice"
        Me.Size = New System.Drawing.Size(220, 76)
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents D8 As RPGXplorer.d8
    Public WithEvents D10 As RPGXplorer.d10
    Public WithEvents D6 As RPGXplorer.d6
    Public WithEvents D4 As RPGXplorer.d4
    Public WithEvents D12 As RPGXplorer.d12

End Class
