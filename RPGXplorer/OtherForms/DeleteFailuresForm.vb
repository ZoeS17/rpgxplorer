Option Explicit On 
Option Strict On

Public Class DeleteFailuresForm
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
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents InfoLabel As System.Windows.Forms.Label
    Public WithEvents FailuresList As DevExpress.XtraEditors.ListBoxControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DeleteFailuresForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.FailuresList = New DevExpress.XtraEditors.ListBoxControl
        Me.Cancel = New System.Windows.Forms.Button
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.InfoLabel = New System.Windows.Forms.Label
        CType(Me.FailuresList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'FailuresList
        '
        Me.FailuresList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FailuresList.ItemHeight = 15
        Me.FailuresList.Location = New System.Drawing.Point(15, 45)
        Me.FailuresList.Name = "FailuresList"
        Me.FailuresList.Size = New System.Drawing.Size(563, 253)
        Me.FailuresList.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.FailuresList.TabIndex = 2
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
        Me.InfoLabel.Text = "The following components cannot be deleted for the reason shown."
        Me.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeleteFailuresForm
        '
        Me.AcceptButton = Me.Cancel
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(592, 366)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.FailuresList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteFailuresForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Failures"
        CType(Me.FailuresList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'init
    Public Sub Init(ByVal Failures As ObjectHashtable)
        Dim Obj As New Objects.ObjectData, FailCause As New Objects.ObjectData
        Dim FailSublist As ArrayList
        Dim Enumerator As IDictionaryEnumerator
        Dim FailedGuid As Objects.ObjectKey

        Try
            'load the failure list
            FailuresList.SelectionMode = SelectionMode.None
            FailuresList.SelectedIndex = -1

            Application.DoEvents()

            Enumerator = Failures.GetEnumerator
            While Enumerator.MoveNext
                Obj.Load(New Objects.ObjectKey(CStr(Enumerator.Key)))
                FailSublist = CType(Enumerator.Value, ArrayList)
                For Each FailedGuid In FailSublist
                    FailCause.Clear()
                    FailCause.Load(FailedGuid)
                    FailuresList.Items.Add(Obj.Name & " (Referenced by '" & FailCause.Path & "')")
                Next
            End While

            General.SetNormalCursor()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
