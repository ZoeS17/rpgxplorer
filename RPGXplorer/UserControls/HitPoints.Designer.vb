<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HitPoints
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        ModifierSpin_ValueChanged(Nothing, Nothing)

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
        Me.ModifierSpin = New DevExpress.XtraEditors.SpinEdit
        Me.SpinDisplay = New System.Windows.Forms.TextBox
        CType(Me.ModifierSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModifierSpin
        '
        Me.ModifierSpin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModifierSpin.EditValue = 0
        Me.ModifierSpin.Location = New System.Drawing.Point(0, 0)
        Me.ModifierSpin.Name = "ModifierSpin"
        '
        'ModifierSpin.Properties
        '
        Me.ModifierSpin.Properties.AllowFocused = False
        Me.ModifierSpin.Properties.AutoHeight = False
        Me.ModifierSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ModifierSpin.Properties.IsFloatValue = False
        Me.ModifierSpin.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.ModifierSpin.Properties.MinValue = New Decimal(New Integer() {10, 0, 0, -2147483648})
        'Me.ModifierSpin.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", "BaseEdit", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
        '                Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
        '                Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
        '                Or DevExpress.Utils.StyleOptions.UseFont) _
        '                Or DevExpress.Utils.StyleOptions.UseForeColor) _
        '                Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
        '                Or DevExpress.Utils.StyleOptions.UseImage) _
        '                Or DevExpress.Utils.StyleOptions.UseWordWrap) _
        '                Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), False, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.ModifierSpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ModifierSpin.Size = New System.Drawing.Size(192, 54)
        Me.ModifierSpin.TabIndex = 97
        Me.ModifierSpin.TabStop = False
        '
        'SpinDisplay
        '
        Me.SpinDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpinDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpinDisplay.Location = New System.Drawing.Point(3, 3)
        Me.SpinDisplay.Name = "SpinDisplay"
        Me.SpinDisplay.Size = New System.Drawing.Size(169, 13)
        Me.SpinDisplay.TabIndex = 100
        Me.SpinDisplay.Text = ""
        '
        'HitPoints
        '
        Me.Controls.Add(Me.SpinDisplay)
        Me.Controls.Add(Me.ModifierSpin)
        Me.Name = "HitPoints"
        Me.Size = New System.Drawing.Size(192, 54)
        CType(Me.ModifierSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents ModifierSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SpinDisplay As System.Windows.Forms.TextBox

End Class
