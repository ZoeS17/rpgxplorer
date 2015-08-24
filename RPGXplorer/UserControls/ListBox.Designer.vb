<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBox
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
        Me.List = New DevExpress.XtraEditors.ListBoxControl
        CType(Me.List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.List.ItemHeight = 15
        Me.List.Location = New System.Drawing.Point(0, 0)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(510, 365)
        Me.List.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.List.TabIndex = 1
        '
        'ListBox
        '
        Me.Controls.Add(Me.List)
        Me.Name = "ListBox"
        Me.Size = New System.Drawing.Size(510, 365)
        CType(Me.List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents List As DevExpress.XtraEditors.ListBoxControl

End Class
