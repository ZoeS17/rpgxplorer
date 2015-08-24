<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetValue
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
        Me.AbilityCheck = New System.Windows.Forms.CheckBox
        Me.LevelCheck = New System.Windows.Forms.CheckBox
        Me.AbilityLabel = New System.Windows.Forms.Label
        Me.AbilityPlusLabel = New System.Windows.Forms.Label
        Me.LevelPlusLabel = New System.Windows.Forms.Label
        Me.LevelSpin = New DevExpress.XtraEditors.SpinEdit
        Me.Number = New DevExpress.XtraEditors.SpinEdit
        Me.AbilityDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LevelLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TagCheck = New System.Windows.Forms.CheckBox
        Me.TagPlusLabel = New System.Windows.Forms.Label
        Me.TagLabel1 = New System.Windows.Forms.Label
        Me.TagLabel2 = New System.Windows.Forms.Label
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TagDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TagSpin = New DevExpress.XtraEditors.SpinEdit
        CType(Me.LevelSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AbilityCheck
        '
        Me.AbilityCheck.Location = New System.Drawing.Point(30, 90)
        Me.AbilityCheck.Name = "AbilityCheck"
        Me.AbilityCheck.Size = New System.Drawing.Size(20, 24)
        Me.AbilityCheck.TabIndex = 6
        '
        'LevelCheck
        '
        Me.LevelCheck.Location = New System.Drawing.Point(30, 30)
        Me.LevelCheck.Name = "LevelCheck"
        Me.LevelCheck.Size = New System.Drawing.Size(20, 24)
        Me.LevelCheck.TabIndex = 1
        '
        'AbilityLabel
        '
        Me.AbilityLabel.BackColor = System.Drawing.SystemColors.Control
        Me.AbilityLabel.CausesValidation = False
        Me.AbilityLabel.Enabled = False
        Me.AbilityLabel.Location = New System.Drawing.Point(145, 90)
        Me.AbilityLabel.Name = "AbilityLabel"
        Me.AbilityLabel.Size = New System.Drawing.Size(50, 21)
        Me.AbilityLabel.TabIndex = 127
        Me.AbilityLabel.Text = "Modifier"
        Me.AbilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbilityPlusLabel
        '
        Me.AbilityPlusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.AbilityPlusLabel.CausesValidation = False
        Me.AbilityPlusLabel.Enabled = False
        Me.AbilityPlusLabel.Location = New System.Drawing.Point(55, 90)
        Me.AbilityPlusLabel.Name = "AbilityPlusLabel"
        Me.AbilityPlusLabel.Size = New System.Drawing.Size(15, 21)
        Me.AbilityPlusLabel.TabIndex = 126
        Me.AbilityPlusLabel.Text = "+"
        Me.AbilityPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelPlusLabel
        '
        Me.LevelPlusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.LevelPlusLabel.CausesValidation = False
        Me.LevelPlusLabel.Enabled = False
        Me.LevelPlusLabel.Location = New System.Drawing.Point(55, 30)
        Me.LevelPlusLabel.Name = "LevelPlusLabel"
        Me.LevelPlusLabel.Size = New System.Drawing.Size(15, 21)
        Me.LevelPlusLabel.TabIndex = 125
        Me.LevelPlusLabel.Text = "+"
        Me.LevelPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelSpin
        '
        Me.LevelSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LevelSpin.Enabled = False
        Me.LevelSpin.Location = New System.Drawing.Point(80, 30)
        Me.LevelSpin.Name = "LevelSpin"
        '
        'LevelSpin.Properties
        '
        Me.LevelSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.LevelSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LevelSpin.Properties.AutoHeight = False
        Me.LevelSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LevelSpin.Properties.IsFloatValue = False
        Me.LevelSpin.Properties.Mask.BeepOnError = True
        Me.LevelSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.LevelSpin.Properties.Mask.SaveLiteral = False
        Me.LevelSpin.Properties.Mask.ShowPlaceHolders = False
        Me.LevelSpin.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.LevelSpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LevelSpin.Size = New System.Drawing.Size(55, 21)
        Me.LevelSpin.TabIndex = 2
        '
        'Number
        '
        Me.Number.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Number.Location = New System.Drawing.Point(80, 0)
        Me.Number.Name = "Number"
        '
        'Number.Properties
        '
        Me.Number.Properties.Appearance.Options.UseTextOptions = True
        Me.Number.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Number.Properties.AutoHeight = False
        Me.Number.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Number.Properties.IsFloatValue = False
        Me.Number.Properties.Mask.BeepOnError = True
        Me.Number.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Number.Properties.Mask.ShowPlaceHolders = False
        Me.Number.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Number.Size = New System.Drawing.Size(55, 21)
        Me.Number.TabIndex = 0
        '
        'AbilityDropdown
        '
        Me.AbilityDropdown.Enabled = False
        Me.Errors.SetIconPadding(Me.AbilityDropdown, 60)
        Me.AbilityDropdown.Location = New System.Drawing.Point(80, 90)
        Me.AbilityDropdown.Name = "AbilityDropdown"
        '
        'AbilityDropdown.Properties
        '
        Me.AbilityDropdown.Properties.AutoHeight = False
        Me.AbilityDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AbilityDropdown.Properties.DropDownRows = 10
        Me.AbilityDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.AbilityDropdown.Size = New System.Drawing.Size(55, 21)
        Me.AbilityDropdown.TabIndex = 7
        '
        'LevelLabel
        '
        Me.LevelLabel.BackColor = System.Drawing.SystemColors.Control
        Me.LevelLabel.CausesValidation = False
        Me.LevelLabel.Enabled = False
        Me.LevelLabel.Location = New System.Drawing.Point(145, 30)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(115, 21)
        Me.LevelLabel.TabIndex = 123
        Me.LevelLabel.Text = "per Character Level"
        Me.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TagCheck
        '
        Me.TagCheck.Location = New System.Drawing.Point(30, 60)
        Me.TagCheck.Name = "TagCheck"
        Me.TagCheck.Size = New System.Drawing.Size(20, 24)
        Me.TagCheck.TabIndex = 3
        '
        'TagPlusLabel
        '
        Me.TagPlusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TagPlusLabel.CausesValidation = False
        Me.TagPlusLabel.Enabled = False
        Me.TagPlusLabel.Location = New System.Drawing.Point(55, 60)
        Me.TagPlusLabel.Name = "TagPlusLabel"
        Me.TagPlusLabel.Size = New System.Drawing.Size(15, 21)
        Me.TagPlusLabel.TabIndex = 131
        Me.TagPlusLabel.Text = "+"
        Me.TagPlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TagLabel1
        '
        Me.TagLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.TagLabel1.CausesValidation = False
        Me.TagLabel1.Enabled = False
        Me.TagLabel1.Location = New System.Drawing.Point(145, 60)
        Me.TagLabel1.Name = "TagLabel1"
        Me.TagLabel1.Size = New System.Drawing.Size(105, 21)
        Me.TagLabel1.TabIndex = 130
        Me.TagLabel1.Text = "per Class Level with "
        Me.TagLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TagLabel2
        '
        Me.TagLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.TagLabel2.CausesValidation = False
        Me.TagLabel2.Enabled = False
        Me.TagLabel2.Location = New System.Drawing.Point(360, 60)
        Me.TagLabel2.Name = "TagLabel2"
        Me.TagLabel2.Size = New System.Drawing.Size(30, 21)
        Me.TagLabel2.TabIndex = 133
        Me.TagLabel2.Text = "Tag"
        Me.TagLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'TagDropdown
        '
        Me.TagDropdown.Enabled = False
        Me.Errors.SetIconPadding(Me.TagDropdown, 60)
        Me.TagDropdown.Location = New System.Drawing.Point(255, 60)
        Me.TagDropdown.Name = "TagDropdown"
        '
        'TagDropdown.Properties
        '
        Me.TagDropdown.Properties.AutoHeight = False
        Me.TagDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TagDropdown.Properties.DropDownRows = 10
        Me.TagDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TagDropdown.Size = New System.Drawing.Size(100, 21)
        Me.TagDropdown.TabIndex = 5
        '
        'TagSpin
        '
        Me.TagSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TagSpin.Enabled = False
        Me.TagSpin.Location = New System.Drawing.Point(80, 60)
        Me.TagSpin.Name = "TagSpin"
        '
        'TagSpin.Properties
        '
        Me.TagSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.TagSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TagSpin.Properties.AutoHeight = False
        Me.TagSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TagSpin.Properties.IsFloatValue = False
        Me.TagSpin.Properties.Mask.BeepOnError = True
        Me.TagSpin.Properties.Mask.EditMask = "N00"
        Me.TagSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TagSpin.Properties.Mask.SaveLiteral = False
        Me.TagSpin.Properties.Mask.ShowPlaceHolders = False
        Me.TagSpin.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.TagSpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TagSpin.Size = New System.Drawing.Size(55, 21)
        Me.TagSpin.TabIndex = 4
        '
        'SetValue
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.TagLabel2)
        Me.Controls.Add(Me.TagDropdown)
        Me.Controls.Add(Me.TagCheck)
        Me.Controls.Add(Me.TagPlusLabel)
        Me.Controls.Add(Me.TagSpin)
        Me.Controls.Add(Me.TagLabel1)
        Me.Controls.Add(Me.AbilityCheck)
        Me.Controls.Add(Me.LevelCheck)
        Me.Controls.Add(Me.AbilityLabel)
        Me.Controls.Add(Me.AbilityPlusLabel)
        Me.Controls.Add(Me.LevelPlusLabel)
        Me.Controls.Add(Me.LevelSpin)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.AbilityDropdown)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.Label2)
        Me.Errors.SetIconPadding(Me, 60)
        Me.Name = "SetValue"
        Me.Size = New System.Drawing.Size(400, 120)
        CType(Me.LevelSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbilityDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents AbilityLabel As System.Windows.Forms.Label
    Public WithEvents AbilityPlusLabel As System.Windows.Forms.Label
    Public WithEvents LevelPlusLabel As System.Windows.Forms.Label
    Public WithEvents LevelSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Number As DevExpress.XtraEditors.SpinEdit
    Public WithEvents AbilityDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents LevelLabel As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents AbilityCheck As System.Windows.Forms.CheckBox
    Public WithEvents LevelCheck As System.Windows.Forms.CheckBox
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TagCheck As System.Windows.Forms.CheckBox
    Public WithEvents TagSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents TagLabel1 As System.Windows.Forms.Label
    Public WithEvents TagDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TagLabel2 As System.Windows.Forms.Label
    Public WithEvents TagPlusLabel As System.Windows.Forms.Label
    Public WithEvents Button1 As System.Windows.Forms.Button

End Class
