<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManifesterPanel
    Inherits DevExpress.XtraEditors.XtraUserControl

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
        Me.PowerPointsSpin = New DevExpress.XtraEditors.SpinEdit
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelControl36 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.CasterLevel = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.SpellNotes = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PowersKnownBox = New RPGXplorer.ReadOnlyTextBox
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        CType(Me.PowerPointsSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl36, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl36.SuspendLayout()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.SpellNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PowerPointsSpin
        '
        Me.PowerPointsSpin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PowerPointsSpin.Location = New System.Drawing.Point(80, 2)
        Me.PowerPointsSpin.Name = "PowerPointsSpin"
        Me.PowerPointsSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.PowerPointsSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PowerPointsSpin.Properties.AutoHeight = False
        Me.PowerPointsSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PowerPointsSpin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.PowerPointsSpin.Properties.IsFloatValue = False
        Me.PowerPointsSpin.Properties.Mask.BeepOnError = True
        Me.PowerPointsSpin.Properties.Mask.EditMask = "d"
        Me.PowerPointsSpin.Properties.Mask.ShowPlaceHolders = False
        Me.PowerPointsSpin.Properties.MaxLength = 3
        Me.PowerPointsSpin.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.PowerPointsSpin.Size = New System.Drawing.Size(55, 20)
        Me.PowerPointsSpin.TabIndex = 1
        Me.PowerPointsSpin.ToolTipController = Me.ToolTipController
        '
        'PanelControl36
        '
        Me.PanelControl36.Controls.Add(Me.LabelControl29)
        Me.PanelControl36.Controls.Add(Me.CasterLevel)
        Me.PanelControl36.Location = New System.Drawing.Point(15, 15)
        Me.PanelControl36.Name = "PanelControl36"
        Me.PanelControl36.Size = New System.Drawing.Size(140, 24)
        Me.ToolTipController.SetSuperTip(Me.PanelControl36, Nothing)
        Me.PanelControl36.TabIndex = 655
        '
        'LabelControl29
        '
        Me.LabelControl29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseTextOptions = True
        Me.LabelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl29.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl29.Location = New System.Drawing.Point(0, 2)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl29.TabIndex = 34
        Me.LabelControl29.Text = "Manifester Level"
        '
        'CasterLevel
        '
        Me.CasterLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CasterLevel.EditValue = "-"
        Me.CasterLevel.Location = New System.Drawing.Point(94, 2)
        Me.CasterLevel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.CasterLevel.Name = "CasterLevel"
        Me.CasterLevel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.CasterLevel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CasterLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CasterLevel.Properties.Appearance.Options.UseBackColor = True
        Me.CasterLevel.Properties.Appearance.Options.UseFont = True
        Me.CasterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CasterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CasterLevel.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CasterLevel.Properties.AutoHeight = False
        Me.CasterLevel.Properties.ReadOnly = True
        Me.CasterLevel.Size = New System.Drawing.Size(44, 20)
        Me.CasterLevel.TabIndex = 13
        Me.CasterLevel.TabStop = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SpellNotes)
        Me.GroupControl3.Location = New System.Drawing.Point(15, 65)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(558, 200)
        Me.ToolTipController.SetSuperTip(Me.GroupControl3, Nothing)
        Me.GroupControl3.TabIndex = 656
        Me.GroupControl3.Text = "Notes"
        '
        'SpellNotes
        '
        Me.SpellNotes.CausesValidation = False
        Me.SpellNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpellNotes.EditValue = ""
        Me.SpellNotes.Location = New System.Drawing.Point(2, 20)
        Me.SpellNotes.Name = "SpellNotes"
        Me.SpellNotes.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SpellNotes.Properties.Appearance.Options.UseBackColor = True
        Me.SpellNotes.Size = New System.Drawing.Size(554, 178)
        Me.SpellNotes.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.PowerPointsSpin)
        Me.PanelControl1.Location = New System.Drawing.Point(160, 15)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(137, 24)
        Me.ToolTipController.SetSuperTip(Me.PanelControl1, Nothing)
        Me.PanelControl1.TabIndex = 656
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(5, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 20)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Power Points"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.PowersKnownBox)
        Me.PanelControl2.Location = New System.Drawing.Point(302, 15)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(133, 24)
        Me.ToolTipController.SetSuperTip(Me.PanelControl2, Nothing)
        Me.PanelControl2.TabIndex = 657
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(5, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Powers Known"
        '
        'PowersKnownBox
        '
        Me.PowersKnownBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PowersKnownBox.BackColor = System.Drawing.Color.White
        Me.PowersKnownBox.Caption = Nothing
        Me.PowersKnownBox.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PowersKnownBox.ForeColor = System.Drawing.Color.Black
        Me.PowersKnownBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PowersKnownBox.Location = New System.Drawing.Point(87, 2)
        Me.PowersKnownBox.Name = "PowersKnownBox"
        Me.PowersKnownBox.Padding = New System.Windows.Forms.Padding(1)
        Me.PowersKnownBox.Size = New System.Drawing.Size(44, 20)
        Me.ToolTipController.SetSuperTip(Me.PowersKnownBox, Nothing)
        Me.PowersKnownBox.TabIndex = 578
        Me.PowersKnownBox.TextColor = System.Drawing.Color.Black
        Me.PowersKnownBox.Vertical = False
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(675, 2)
        Me.ToolTipController.SetSuperTip(Me.IndentedLine3, Nothing)
        Me.IndentedLine3.TabIndex = 245
        Me.IndentedLine3.TabStop = False
        '
        'ManifesterPanel
        '
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.PanelControl36)
        Me.Controls.Add(Me.IndentedLine3)
        Me.Name = "ManifesterPanel"
        Me.Size = New System.Drawing.Size(705, 685)
        Me.ToolTipController.SetSuperTip(Me, Nothing)
        CType(Me.PowerPointsSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl36, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl36.ResumeLayout(False)
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.SpellNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents PowerPointsSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PowersKnownBox As RPGXplorer.ReadOnlyTextBox
    Public WithEvents PanelControl36 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Private WithEvents CasterLevel As DevExpress.XtraEditors.TextEdit
    Public WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Public WithEvents SpellNotes As DevExpress.XtraEditors.MemoEdit
    Public WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents ToolTipController As DevExpress.Utils.ToolTipController

End Class
