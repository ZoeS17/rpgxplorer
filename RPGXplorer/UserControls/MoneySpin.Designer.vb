<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoneySpin
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        GP.Properties.DisplayFormat.Format = New Rules.GPFormatter
        'GP.Properties.EditFormat.Format = New Rules.GPFormatter

        SP.Properties.DisplayFormat.Format = New Rules.SPFormatter
        'SP.Properties.EditFormat.Format = New Rules.SPFormatter

        CP.Properties.DisplayFormat.Format = New Rules.CPFormatter
        'CP.Properties.EditFormat.Format = New Rules.CPFormatter

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
        Me.components = New System.ComponentModel.Container
        Me.GP = New DevExpress.XtraEditors.SpinEdit
        Me.SP = New DevExpress.XtraEditors.SpinEdit
        Me.CP = New DevExpress.XtraEditors.SpinEdit
        CType(Me.GP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GP
        '
        Me.GP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GP.Location = New System.Drawing.Point(0, 0)
        Me.GP.Name = "GP"
        '
        'GP.Properties
        '
        Me.GP.Properties.Appearance.Options.UseTextOptions = True
        Me.GP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GP.Properties.AutoHeight = False
        Me.GP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.GP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GP.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.GP.Properties.IsFloatValue = False
        Me.GP.Properties.Mask.BeepOnError = True
        Me.GP.Properties.Mask.EditMask = "d"
        Me.GP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.GP.Properties.Mask.ShowPlaceHolders = False
        Me.GP.Properties.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.GP.Size = New System.Drawing.Size(75, 21)
        Me.GP.TabIndex = 0
        '
        'SP
        '
        Me.SP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SP.Location = New System.Drawing.Point(80, 0)
        Me.SP.Name = "SP"
        '
        'SP.Properties
        '
        Me.SP.Properties.Appearance.Options.UseTextOptions = True
        Me.SP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SP.Properties.AutoHeight = False
        Me.SP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.SP.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.SP.Properties.IsFloatValue = False
        Me.SP.Properties.Mask.BeepOnError = True
        Me.SP.Properties.Mask.EditMask = "9"
        Me.SP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SP.Properties.Mask.ShowPlaceHolders = False
        Me.SP.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.SP.Size = New System.Drawing.Size(50, 21)
        Me.SP.TabIndex = 1
        '
        'CP
        '
        Me.CP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CP.Location = New System.Drawing.Point(135, 0)
        Me.CP.Name = "CP"
        '
        'CP.Properties
        '
        Me.CP.Properties.Appearance.Options.UseTextOptions = True
        Me.CP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CP.Properties.AutoHeight = False
        Me.CP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CP.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.CP.Properties.IsFloatValue = False
        Me.CP.Properties.Mask.BeepOnError = True
        Me.CP.Properties.Mask.EditMask = "9"
        Me.CP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CP.Properties.Mask.ShowPlaceHolders = False
        Me.CP.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.CP.Size = New System.Drawing.Size(50, 21)
        Me.CP.TabIndex = 2
        '
        'MoneySpin
        '
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.SP)
        Me.Controls.Add(Me.GP)
        Me.Name = "MoneySpin"
        Me.Size = New System.Drawing.Size(185, 21)
        CType(Me.GP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents GP As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SP As DevExpress.XtraEditors.SpinEdit
    Public WithEvents CP As DevExpress.XtraEditors.SpinEdit

End Class
