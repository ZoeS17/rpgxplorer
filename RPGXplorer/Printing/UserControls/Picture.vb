Public Class Picture
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
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Picture
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Picture"
        Me.Size = New System.Drawing.Size(56, 56)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public WriteOnly Property ImageFilename() As String
        Set(ByVal Value As String)
            Dim Bitmap As Bitmap
            Dim Path As String

            Try
                Path = General.BasePath & "Images\Printable\" & Value
                If System.IO.File.Exists(Path) Then
                    Bitmap = New Bitmap(Path)
                    Me.PictureBox1.Image = Bitmap
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Set
    End Property

End Class
