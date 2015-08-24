Public Class Form1
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
    Public WithEvents Circle1 As RPGXplorer.Circle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Circle1 = New RPGXplorer.Circle
        Me.SuspendLayout()
        '
        'Circle1
        '
        Me.Circle1.BackColor = System.Drawing.Color.White
        Me.Circle1.Location = New System.Drawing.Point(112, 112)
        Me.Circle1.Name = "Circle1"
        Me.Circle1.Size = New System.Drawing.Size(80, 80)
        Me.Circle1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Circle1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
