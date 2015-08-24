<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeaponsPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeaponsPanel))
        Me.AddWeaponsConfig = New DevExpress.XtraEditors.SimpleButton
        Me.Delete = New DevExpress.XtraEditors.SimpleButton
        Me.MoveUp = New DevExpress.XtraEditors.SimpleButton
        Me.MoveDown = New DevExpress.XtraEditors.SimpleButton
        Me.Reset = New DevExpress.XtraEditors.SimpleButton
        Me.ConfigsPanel = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CombatModifiers = New DevExpress.XtraEditors.ListBoxControl
        Me.ReadOnlyTextBox1 = New RPGXplorer.ReadOnlyTextBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.BAB = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Grapple = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Ranged = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.Melee = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.DefaultButton = New DevExpress.XtraEditors.SimpleButton
        Me.AddMonsterConfig = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.CombatModifiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.BAB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Grapple.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Ranged.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Melee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddWeaponsConfig
        '
        Me.AddWeaponsConfig.Image = Global.RPGXplorer.My.Resources.Resources.row_add_after
        Me.AddWeaponsConfig.Location = New System.Drawing.Point(10, 40)
        Me.AddWeaponsConfig.Name = "AddWeaponsConfig"
        Me.AddWeaponsConfig.Size = New System.Drawing.Size(90, 25)
        Me.AddWeaponsConfig.TabIndex = 0
        Me.AddWeaponsConfig.Text = "Add Normal"
        '
        'Delete
        '
        Me.Delete.Image = Global.RPGXplorer.My.Resources.Resources.row_delete
        Me.Delete.Location = New System.Drawing.Point(310, 40)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 25)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "Delete"
        '
        'MoveUp
        '
        Me.MoveUp.Image = Global.RPGXplorer.My.Resources.Resources.arrow_up_green
        Me.MoveUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.MoveUp.Location = New System.Drawing.Point(210, 40)
        Me.MoveUp.Name = "MoveUp"
        Me.MoveUp.Size = New System.Drawing.Size(40, 25)
        Me.MoveUp.TabIndex = 1
        '
        'MoveDown
        '
        Me.MoveDown.Image = Global.RPGXplorer.My.Resources.Resources.arrow_down_green
        Me.MoveDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.MoveDown.Location = New System.Drawing.Point(255, 40)
        Me.MoveDown.Name = "MoveDown"
        Me.MoveDown.Size = New System.Drawing.Size(40, 25)
        Me.MoveDown.TabIndex = 2
        '
        'Reset
        '
        Me.Reset.Image = Global.RPGXplorer.My.Resources.Resources.table_new
        Me.Reset.Location = New System.Drawing.Point(390, 40)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 25)
        Me.Reset.TabIndex = 4
        Me.Reset.Text = "Reset"
        '
        'ConfigsPanel
        '
        Me.ConfigsPanel.AutoScroll = True
        Me.ConfigsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ConfigsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigsPanel.Location = New System.Drawing.Point(1, 75)
        Me.ConfigsPanel.Name = "ConfigsPanel"
        Me.ConfigsPanel.Size = New System.Drawing.Size(751, 259)
        Me.ConfigsPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panel1.Controls.Add(Me.CombatModifiers)
        Me.Panel1.Controls.Add(Me.ReadOnlyTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(1, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 100)
        Me.Panel1.TabIndex = 355
        '
        'CombatModifiers
        '
        Me.CombatModifiers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CombatModifiers.Appearance.BackColor = System.Drawing.Color.White
        Me.CombatModifiers.Appearance.Options.UseBackColor = True
        Me.CombatModifiers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CombatModifiers.ItemHeight = 15
        Me.CombatModifiers.Location = New System.Drawing.Point(1, 21)
        Me.CombatModifiers.Name = "CombatModifiers"
        Me.CombatModifiers.ShowToolTips = False
        Me.CombatModifiers.Size = New System.Drawing.Size(749, 78)
        Me.CombatModifiers.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.CombatModifiers.TabIndex = 40
        Me.CombatModifiers.TabStop = False
        '
        'ReadOnlyTextBox1
        '
        Me.ReadOnlyTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReadOnlyTextBox1.BackColor = System.Drawing.Color.LightYellow
        Me.ReadOnlyTextBox1.Caption = " Combat Modifiers"
        Me.ReadOnlyTextBox1.CaptionAligment = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReadOnlyTextBox1.ForeColor = System.Drawing.Color.Black
        Me.ReadOnlyTextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ReadOnlyTextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.ReadOnlyTextBox1.Name = "ReadOnlyTextBox1"
        Me.ReadOnlyTextBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.ReadOnlyTextBox1.Size = New System.Drawing.Size(753, 20)
        Me.ReadOnlyTextBox1.TabIndex = 39
        Me.ReadOnlyTextBox1.TabStop = False
        Me.ReadOnlyTextBox1.TextColor = System.Drawing.Color.Black
        Me.ReadOnlyTextBox1.Vertical = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(1, 334)
        Me.Splitter1.MinSize = 100
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(751, 5)
        Me.Splitter1.TabIndex = 356
        Me.Splitter1.TabStop = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.BAB)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Location = New System.Drawing.Point(10, 10)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(155, 24)
        Me.PanelControl4.TabIndex = 676
        '
        'BAB
        '
        Me.BAB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAB.EditValue = "-"
        Me.BAB.Location = New System.Drawing.Point(50, 2)
        Me.BAB.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.BAB.Name = "BAB"
        Me.BAB.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BAB.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.BAB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAB.Properties.Appearance.Options.UseBackColor = True
        Me.BAB.Properties.Appearance.Options.UseFont = True
        Me.BAB.Properties.Appearance.Options.UseTextOptions = True
        Me.BAB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BAB.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BAB.Properties.AutoHeight = False
        Me.BAB.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.BAB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BAB.Properties.ReadOnly = True
        Me.BAB.Size = New System.Drawing.Size(103, 20)
        Me.BAB.TabIndex = 13
        Me.BAB.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 20)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "BAB"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Grapple)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Location = New System.Drawing.Point(370, 10)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(95, 24)
        Me.PanelControl2.TabIndex = 675
        '
        'Grapple
        '
        Me.Grapple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grapple.EditValue = "-"
        Me.Grapple.Location = New System.Drawing.Point(52, 2)
        Me.Grapple.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Grapple.Name = "Grapple"
        Me.Grapple.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Grapple.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Grapple.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grapple.Properties.Appearance.Options.UseBackColor = True
        Me.Grapple.Properties.Appearance.Options.UseFont = True
        Me.Grapple.Properties.Appearance.Options.UseTextOptions = True
        Me.Grapple.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grapple.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Grapple.Properties.AutoHeight = False
        Me.Grapple.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Grapple.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grapple.Properties.ReadOnly = True
        Me.Grapple.Size = New System.Drawing.Size(41, 20)
        Me.Grapple.TabIndex = 13
        Me.Grapple.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 20)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Grapple"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Ranged)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(270, 10)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(95, 24)
        Me.PanelControl1.TabIndex = 674
        '
        'Ranged
        '
        Me.Ranged.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ranged.EditValue = "-"
        Me.Ranged.Location = New System.Drawing.Point(52, 2)
        Me.Ranged.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Ranged.Name = "Ranged"
        Me.Ranged.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Ranged.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ranged.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ranged.Properties.Appearance.Options.UseBackColor = True
        Me.Ranged.Properties.Appearance.Options.UseFont = True
        Me.Ranged.Properties.Appearance.Options.UseTextOptions = True
        Me.Ranged.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ranged.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Ranged.Properties.AutoHeight = False
        Me.Ranged.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Ranged.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Ranged.Properties.ReadOnly = True
        Me.Ranged.Size = New System.Drawing.Size(41, 20)
        Me.Ranged.TabIndex = 13
        Me.Ranged.TabStop = False
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
        Me.LabelControl1.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 20)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Ranged"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Melee)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Location = New System.Drawing.Point(170, 10)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(95, 24)
        Me.PanelControl3.TabIndex = 673
        '
        'Melee
        '
        Me.Melee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Melee.EditValue = "-"
        Me.Melee.Location = New System.Drawing.Point(52, 2)
        Me.Melee.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Melee.Name = "Melee"
        Me.Melee.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Melee.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Melee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Melee.Properties.Appearance.Options.UseBackColor = True
        Me.Melee.Properties.Appearance.Options.UseFont = True
        Me.Melee.Properties.Appearance.Options.UseTextOptions = True
        Me.Melee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Melee.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Melee.Properties.AutoHeight = False
        Me.Melee.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Melee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Melee.Properties.ReadOnly = True
        Me.Melee.Size = New System.Drawing.Size(41, 20)
        Me.Melee.TabIndex = 13
        Me.Melee.TabStop = False
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
        Me.LabelControl2.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 20)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Melee"
        '
        'DefaultButton
        '
        Me.DefaultButton.Location = New System.Drawing.Point(480, 40)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(160, 25)
        Me.DefaultButton.TabIndex = 358
        Me.DefaultButton.Text = "Set Default Weapon Configs"
        Me.DefaultButton.Visible = False
        '
        'AddMonsterConfig
        '
        Me.AddMonsterConfig.Image = Global.RPGXplorer.My.Resources.Resources.row_add_after
        Me.AddMonsterConfig.Location = New System.Drawing.Point(105, 40)
        Me.AddMonsterConfig.Name = "AddMonsterConfig"
        Me.AddMonsterConfig.Size = New System.Drawing.Size(90, 25)
        Me.AddMonsterConfig.TabIndex = 357
        Me.AddMonsterConfig.Text = "Add Monster"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.RPGXplorer.My.Resources.Resources.shield_red
        Me.PictureEdit1.Location = New System.Drawing.Point(469, 11)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(20, 20)
        Me.PictureEdit1.TabIndex = 356
        Me.PictureEdit1.ToolTip = resources.GetString("PictureEdit1.ToolTip")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PanelControl4)
        Me.Panel2.Controls.Add(Me.PanelControl2)
        Me.Panel2.Controls.Add(Me.PanelControl1)
        Me.Panel2.Controls.Add(Me.PanelControl3)
        Me.Panel2.Controls.Add(Me.DefaultButton)
        Me.Panel2.Controls.Add(Me.AddMonsterConfig)
        Me.Panel2.Controls.Add(Me.PictureEdit1)
        Me.Panel2.Controls.Add(Me.MoveDown)
        Me.Panel2.Controls.Add(Me.Reset)
        Me.Panel2.Controls.Add(Me.AddWeaponsConfig)
        Me.Panel2.Controls.Add(Me.Delete)
        Me.Panel2.Controls.Add(Me.MoveUp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(751, 74)
        Me.Panel2.TabIndex = 357
        '
        'WeaponsPanel
        '
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(100, 100)
        Me.Controls.Add(Me.ConfigsPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 70)
        Me.Name = "WeaponsPanel"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(753, 440)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CombatModifiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.BAB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.Grapple.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Ranged.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Melee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents AddWeaponsConfig As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Delete As DevExpress.XtraEditors.SimpleButton
    Public WithEvents MoveUp As DevExpress.XtraEditors.SimpleButton
    Public WithEvents MoveDown As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Reset As DevExpress.XtraEditors.SimpleButton
    Public WithEvents ConfigsPanel As System.Windows.Forms.Panel
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ReadOnlyTextBox1 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents CombatModifiers As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Public WithEvents AddMonsterConfig As DevExpress.XtraEditors.SimpleButton
    Public WithEvents DefaultButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Private WithEvents Melee As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Private WithEvents Grapple As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents Ranged As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Private WithEvents BAB As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Public WithEvents Panel2 As System.Windows.Forms.Panel

End Class
