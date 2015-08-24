Option Explicit On 
Option Strict On

Public Class PasteFailuresForm
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
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents PasteFailuresList As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents ContinueButton As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents InfoLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PasteFailuresForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PasteFailuresList = New DevExpress.XtraEditors.ListBoxControl
        Me.Cancel = New System.Windows.Forms.Button
        Me.ContinueButton = New System.Windows.Forms.Button
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.InfoLabel = New System.Windows.Forms.Label
        CType(Me.PasteFailuresList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 20)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PasteFailuresList
        '
        Me.PasteFailuresList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasteFailuresList.ItemHeight = 15
        Me.PasteFailuresList.Location = New System.Drawing.Point(15, 45)
        Me.PasteFailuresList.Name = "PasteFailuresList"
        Me.PasteFailuresList.Size = New System.Drawing.Size(563, 253)
        Me.PasteFailuresList.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.PasteFailuresList.TabIndex = 2
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(508, 328)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        '
        'ContinueButton
        '
        Me.ContinueButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContinueButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueButton.Location = New System.Drawing.Point(388, 328)
        Me.ContinueButton.Name = "Continue"
        Me.ContinueButton.Size = New System.Drawing.Size(110, 24)
        Me.ContinueButton.TabIndex = 3
        Me.ContinueButton.Text = "Continue Paste"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(0, 313)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(598, 5)
        Me.IndentedLine1.TabIndex = 5
        '
        'InfoLabel
        '
        Me.InfoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoLabel.Location = New System.Drawing.Point(40, 15)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(540, 20)
        Me.InfoLabel.TabIndex = 6
        Me.InfoLabel.Text = "The following components cannot be pasted."
        Me.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasteFailuresForm
        '
        Me.AcceptButton = Me.ContinueButton
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(592, 366)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.PasteFailuresList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PasteFailuresForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paste Failures"
        CType(Me.PasteFailuresList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'init
    Public Sub Init(ByVal Total As Integer, ByVal FailureMessages As ArrayList)
        Dim temp As String

        Try
            'load the failure list
            PasteFailuresList.SelectionMode = SelectionMode.None
            PasteFailuresList.Items.AddRange(FailureMessages.ToArray)
            PasteFailuresList.SelectedIndex = -1

            'adjust the message
            If Total = FailureMessages.Count Then
                InfoLabel.Text = General.PasteFailureAll
                ContinueButton.Enabled = False
            Else
                temp = General.PasteFailureSome.Replace("[count]", FailureMessages.Count.ToString)
                temp = temp.Replace("[total]", Total.ToString)
                InfoLabel.Text = temp
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'continue
    Private Sub Continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
