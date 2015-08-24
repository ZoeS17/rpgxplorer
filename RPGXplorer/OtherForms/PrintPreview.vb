Public Class PrintPreview
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
    Public WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Public WithEvents AttributeScore1 As RPGXplorer.AttributeScore
    Public WithEvents Subheading1 As RPGXplorer.Subheading
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.AttributeScore1 = New RPGXplorer.AttributeScore
        Me.Subheading1 = New RPGXplorer.Subheading
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttributeScore1
        '
        Me.AttributeScore1.Location = New System.Drawing.Point(224, 224)
        Me.AttributeScore1.Modifier = "+1"
        Me.AttributeScore1.Name = "AttributeScore1"
        Me.AttributeScore1.Score = "14"
        Me.AttributeScore1.Size = New System.Drawing.Size(80, 72)
        Me.AttributeScore1.TabIndex = 0
        '
        'Subheading1
        '
        Me.Subheading1.BackColor = System.Drawing.Color.White
        Me.Subheading1.Location = New System.Drawing.Point(240, 152)
        Me.Subheading1.Name = "Subheading1"
        Me.Subheading1.Size = New System.Drawing.Size(80, 16)
        Me.Subheading1.SubheadingText = "TEST"
        Me.Subheading1.TabIndex = 1
        '
        'PrintPreview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(664, 518)
        Me.Controls.Add(Me.Subheading1)
        Me.Controls.Add(Me.AttributeScore1)
        Me.Name = "PrintPreview"
        Me.Text = "PrintPreview"
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
