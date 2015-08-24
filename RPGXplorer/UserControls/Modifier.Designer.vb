<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modifier
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
        Me.ModifierSpin = New DevExpress.XtraEditors.SpinEdit
        CType(Me.ModifierSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModifierSpin
        '
        Me.ModifierSpin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModifierSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ModifierSpin.Location = New System.Drawing.Point(0, 0)
        Me.ModifierSpin.Name = "ModifierSpin"
        '
        'ModifierSpin.Properties
        '
        Me.ModifierSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.ModifierSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ModifierSpin.Properties.AutoHeight = False
        Me.ModifierSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ModifierSpin.Properties.DisplayFormat.FormatString = "+0;-0;0"
        Me.ModifierSpin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ModifierSpin.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.ModifierSpin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ModifierSpin.Properties.IsFloatValue = False
        Me.ModifierSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ModifierSpin.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ModifierSpin.Properties.MinValue = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.ModifierSpin.Size = New System.Drawing.Size(235, 260)
        Me.ModifierSpin.TabIndex = 96
        '
        'Modifier
        '
        Me.Controls.Add(Me.ModifierSpin)
        Me.Name = "Modifier"
        Me.Size = New System.Drawing.Size(235, 260)
        CType(Me.ModifierSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents ModifierSpin As DevExpress.XtraEditors.SpinEdit

End Class
