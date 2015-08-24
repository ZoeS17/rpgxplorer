Public Class ErrorForm
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
    Public WithEvents OKButton As System.Windows.Forms.Button
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents ErrorMessageBox As DevExpress.XtraEditors.MemoEdit
    Public WithEvents CopyToClipboard As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorForm))
        Me.ErrorMessageBox = New DevExpress.XtraEditors.MemoEdit
        Me.OKButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CopyToClipboard = New System.Windows.Forms.Button
        CType(Me.ErrorMessageBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorMessageBox
        '
        Me.ErrorMessageBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorMessageBox.EditValue = ""
        Me.ErrorMessageBox.Location = New System.Drawing.Point(75, 40)
        Me.ErrorMessageBox.Name = "ErrorMessageBox"
        Me.ErrorMessageBox.Properties.ReadOnly = True
        Me.ErrorMessageBox.Size = New System.Drawing.Size(365, 273)
        Me.ErrorMessageBox.TabIndex = 0
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(365, 328)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "An error has occured"
        '
        'CopyToClipboard
        '
        Me.CopyToClipboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyToClipboard.Image = Global.RPGXplorer.My.Resources.Resources.copy
        Me.CopyToClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CopyToClipboard.Location = New System.Drawing.Point(75, 328)
        Me.CopyToClipboard.Name = "CopyToClipboard"
        Me.CopyToClipboard.Size = New System.Drawing.Size(116, 23)
        Me.CopyToClipboard.TabIndex = 1
        Me.CopyToClipboard.Text = "Copy to Clipboard"
        Me.CopyToClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorForm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(454, 366)
        Me.Controls.Add(Me.CopyToClipboard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.ErrorMessageBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ErrorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Error"
        Me.TopMost = True
        CType(Me.ErrorMessageBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property ErrorMessage() As String
        Get
            Return Me.ErrorMessageBox.Text
        End Get
        Set(ByVal Value As String)
            Me.ErrorMessageBox.Text = Value
        End Set
    End Property

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub CopyToClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToClipboard.Click
        System.Windows.Forms.Clipboard.SetText(Me.ErrorMessage)
    End Sub

End Class
