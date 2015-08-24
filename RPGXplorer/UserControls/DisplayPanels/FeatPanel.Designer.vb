<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeatPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'initialise the list view
        ListView1.SmallImageList = Images.SmallImages
        ListView1.LargeImageList = Images.LargeImages
        ListView1.FullRowSelect = True
        ListView1.Sorting = SortOrder.None
    End Sub

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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(1, 1)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(750, 566)
        Me.ListView1.TabIndex = 35
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'FeatPanel
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.ListView1)
        Me.DockPadding.All = 1
        Me.Name = "FeatPanel"
        Me.Size = New System.Drawing.Size(752, 568)
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents ListView1 As System.Windows.Forms.ListView

End Class
