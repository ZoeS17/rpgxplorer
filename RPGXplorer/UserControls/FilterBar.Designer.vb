<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterBar
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
        Me.FilterButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.FilterDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.FilterDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterButton
        '
        Me.FilterButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterButton.Location = New System.Drawing.Point(430, 0)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(100, 24)
        Me.FilterButton.TabIndex = 142
        Me.FilterButton.Text = "Filters"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(320, 0)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 24)
        Me.ClearButton.TabIndex = 141
        Me.ClearButton.Text = "Clear Filter"
        '
        'FilterDropdown
        '
        Me.FilterDropdown.Location = New System.Drawing.Point(30, 2)
        Me.FilterDropdown.Name = "FilterDropdown"
        Me.FilterDropdown.Properties.AutoHeight = False
        Me.FilterDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FilterDropdown.Properties.DropDownRows = 30
        Me.FilterDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FilterDropdown.Size = New System.Drawing.Size(275, 21)
        Me.FilterDropdown.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.Image = Global.RPGXplorer.My.Resources.Resources.funnel
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 21)
        Me.Label1.TabIndex = 144
        '
        'FilterBar
        '
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FilterButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.FilterDropdown)
        Me.Name = "FilterBar"
        Me.Size = New System.Drawing.Size(530, 25)
        CType(Me.FilterDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ClearButton As System.Windows.Forms.Button
    Public WithEvents FilterButton As System.Windows.Forms.Button
    Public WithEvents FilterDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label1 As System.Windows.Forms.Label

End Class
