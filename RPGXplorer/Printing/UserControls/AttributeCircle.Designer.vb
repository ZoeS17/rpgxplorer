<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttributeCircle
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
        Me.ValueLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ValueLabel
        '
        Me.ValueLabel.BackColor = System.Drawing.Color.White
        Me.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValueLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueLabel.Image = Global.RPGXplorer.My.Resources.Resources.Circle
        Me.ValueLabel.Location = New System.Drawing.Point(0, 0)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(39, 40)
        Me.ValueLabel.TabIndex = 2
        Me.ValueLabel.Text = "10"
        Me.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AttributeCircle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ValueLabel)
        Me.Name = "AttributeCircle"
        Me.Size = New System.Drawing.Size(39, 40)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ValueLabel As System.Windows.Forms.Label

End Class
