<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeightSpin
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
        Me.GP = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.GP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GP
        '
        Me.GP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GP.Location = New System.Drawing.Point(0, 0)
        Me.GP.Name = "GP"
        Me.GP.Properties.AutoHeight = False
        Me.GP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GP.Properties.Mask.BeepOnError = True
        Me.GP.Size = New System.Drawing.Size(70, 21)
        Me.GP.TabIndex = 1
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(75, 0)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.AutoHeight = False
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.Mask.BeepOnError = True
        Me.SpinEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SpinEdit1.Properties.Mask.ShowPlaceHolders = False
        Me.SpinEdit1.Size = New System.Drawing.Size(70, 21)
        Me.SpinEdit1.TabIndex = 2
        '
        'HeightSpin
        '
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.GP)
        Me.Name = "HeightSpin"
        Me.Size = New System.Drawing.Size(145, 21)
        CType(Me.GP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GP As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit

End Class
