<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryPanel
    Inherits DevExpress.XtraEditors.XtraUserControl

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
        Me.ByWeight = New System.Windows.Forms.RadioButton
        Me.ByArmor = New System.Windows.Forms.RadioButton
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Quantity = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Charges = New DevExpress.XtraEditors.SpinEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.AddMoney = New DevExpress.XtraEditors.SimpleButton
        Me.CarryingCapacities = New System.Windows.Forms.Label
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.ItemsValue = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Money = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Shield = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.CheckPenalty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.Run = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.SpellFailure = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl34 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.Weight = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Armor = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.MaxDEX = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Speed = New DevExpress.XtraEditors.TextEdit
        Me.DefaultButton = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charges.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.ItemsValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.Money.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Shield.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.CheckPenalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Run.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.SpellFailure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl34.SuspendLayout()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.Armor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.MaxDEX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Speed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByWeight
        '
        Me.ByWeight.BackColor = System.Drawing.Color.Transparent
        Me.ByWeight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ByWeight.Location = New System.Drawing.Point(15, 11)
        Me.ByWeight.Name = "ByWeight"
        Me.ByWeight.Size = New System.Drawing.Size(80, 22)
        Me.ByWeight.TabIndex = 0
        Me.ByWeight.Text = "By Weight"
        Me.ByWeight.UseVisualStyleBackColor = False
        '
        'ByArmor
        '
        Me.ByArmor.BackColor = System.Drawing.Color.Transparent
        Me.ByArmor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ByArmor.Location = New System.Drawing.Point(95, 11)
        Me.ByArmor.Name = "ByArmor"
        Me.ByArmor.Size = New System.Drawing.Size(70, 22)
        Me.ByArmor.TabIndex = 1
        Me.ByArmor.Text = "By Armor"
        Me.ByArmor.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(0, 145)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(775, 505)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Quantity
        '
        Me.Quantity.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Location = New System.Drawing.Point(65, 45)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Properties.Appearance.Options.UseTextOptions = True
        Me.Quantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Quantity.Properties.AutoHeight = False
        Me.Quantity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Quantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Quantity.Properties.IsFloatValue = False
        Me.Quantity.Properties.Mask.EditMask = "d"
        Me.Quantity.Properties.Mask.ShowPlaceHolders = False
        Me.Quantity.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Quantity.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Size = New System.Drawing.Size(50, 21)
        Me.Quantity.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 30)
        Me.Label1.TabIndex = 654
        Me.Label1.Text = "Charges /Uses"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Charges
        '
        Me.Charges.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Charges.Location = New System.Drawing.Point(65, 70)
        Me.Charges.Name = "Charges"
        Me.Charges.Properties.Appearance.Options.UseTextOptions = True
        Me.Charges.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Charges.Properties.AutoHeight = False
        Me.Charges.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Charges.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Charges.Properties.IsFloatValue = False
        Me.Charges.Properties.Mask.EditMask = "d"
        Me.Charges.Properties.Mask.ShowPlaceHolders = False
        Me.Charges.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Charges.Size = New System.Drawing.Size(50, 21)
        Me.Charges.TabIndex = 653
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(10, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 292
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddMoney
        '
        Me.AddMoney.Image = Global.RPGXplorer.My.Resources.Resources.goldbar
        Me.AddMoney.Location = New System.Drawing.Point(10, 110)
        Me.AddMoney.Name = "AddMoney"
        Me.AddMoney.Size = New System.Drawing.Size(105, 25)
        Me.AddMoney.TabIndex = 655
        Me.AddMoney.Text = "Add Money"
        '
        'CarryingCapacities
        '
        Me.CarryingCapacities.BackColor = System.Drawing.Color.Transparent
        Me.CarryingCapacities.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.CarryingCapacities.ForeColor = System.Drawing.Color.DimGray
        Me.CarryingCapacities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CarryingCapacities.Location = New System.Drawing.Point(235, 35)
        Me.CarryingCapacities.Name = "CarryingCapacities"
        Me.CarryingCapacities.Size = New System.Drawing.Size(380, 16)
        Me.CarryingCapacities.TabIndex = 668
        Me.CarryingCapacities.Text = "Light Load = 3lb."
        Me.CarryingCapacities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.LabelControl9)
        Me.PanelControl6.Controls.Add(Me.ItemsValue)
        Me.PanelControl6.Location = New System.Drawing.Point(376, 110)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(237, 24)
        Me.PanelControl6.TabIndex = 678
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl9.TabIndex = 34
        Me.LabelControl9.Text = "Value"
        '
        'ItemsValue
        '
        Me.ItemsValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsValue.EditValue = "-"
        Me.ItemsValue.Location = New System.Drawing.Point(55, 2)
        Me.ItemsValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ItemsValue.Name = "ItemsValue"
        Me.ItemsValue.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.ItemsValue.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ItemsValue.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsValue.Properties.Appearance.Options.UseBackColor = True
        Me.ItemsValue.Properties.Appearance.Options.UseFont = True
        Me.ItemsValue.Properties.Appearance.Options.UseTextOptions = True
        Me.ItemsValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ItemsValue.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ItemsValue.Properties.AutoHeight = False
        Me.ItemsValue.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.ItemsValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ItemsValue.Properties.ReadOnly = True
        Me.ItemsValue.Size = New System.Drawing.Size(180, 20)
        Me.ItemsValue.TabIndex = 13
        Me.ItemsValue.TabStop = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LabelControl8)
        Me.PanelControl4.Controls.Add(Me.Money)
        Me.PanelControl4.Location = New System.Drawing.Point(135, 110)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(237, 24)
        Me.PanelControl4.TabIndex = 677
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Money"
        '
        'Money
        '
        Me.Money.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Money.EditValue = "-"
        Me.Money.Location = New System.Drawing.Point(55, 2)
        Me.Money.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Money.Name = "Money"
        Me.Money.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Money.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Money.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money.Properties.Appearance.Options.UseBackColor = True
        Me.Money.Properties.Appearance.Options.UseFont = True
        Me.Money.Properties.Appearance.Options.UseTextOptions = True
        Me.Money.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Money.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Money.Properties.AutoHeight = False
        Me.Money.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Money.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Money.Properties.ReadOnly = True
        Me.Money.Size = New System.Drawing.Size(180, 20)
        Me.Money.TabIndex = 13
        Me.Money.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.Shield)
        Me.PanelControl1.Location = New System.Drawing.Point(376, 55)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(237, 24)
        Me.PanelControl1.TabIndex = 676
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
        Me.LabelControl4.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Shield"
        '
        'Shield
        '
        Me.Shield.EditValue = ""
        Me.Shield.Location = New System.Drawing.Point(55, 2)
        Me.Shield.Name = "Shield"
        Me.Shield.Properties.AutoHeight = False
        Me.Shield.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Shield.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Shield.Size = New System.Drawing.Size(180, 20)
        Me.Shield.TabIndex = 2
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.CheckPenalty)
        Me.PanelControl8.Controls.Add(Me.LabelControl6)
        Me.PanelControl8.Location = New System.Drawing.Point(376, 82)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(143, 24)
        Me.PanelControl8.TabIndex = 673
        '
        'CheckPenalty
        '
        Me.CheckPenalty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckPenalty.EditValue = "-"
        Me.CheckPenalty.Location = New System.Drawing.Point(90, 2)
        Me.CheckPenalty.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.CheckPenalty.Name = "CheckPenalty"
        Me.CheckPenalty.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.CheckPenalty.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CheckPenalty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPenalty.Properties.Appearance.Options.UseBackColor = True
        Me.CheckPenalty.Properties.Appearance.Options.UseFont = True
        Me.CheckPenalty.Properties.Appearance.Options.UseTextOptions = True
        Me.CheckPenalty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CheckPenalty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CheckPenalty.Properties.AutoHeight = False
        Me.CheckPenalty.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.CheckPenalty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CheckPenalty.Properties.ReadOnly = True
        Me.CheckPenalty.Size = New System.Drawing.Size(51, 20)
        Me.CheckPenalty.TabIndex = 13
        Me.CheckPenalty.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(0, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(85, 20)
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "Check Penalty"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Run)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Location = New System.Drawing.Point(505, 10)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(108, 24)
        Me.PanelControl3.TabIndex = 672
        '
        'Run
        '
        Me.Run.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Run.EditValue = "-"
        Me.Run.Location = New System.Drawing.Point(55, 2)
        Me.Run.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Run.Name = "Run"
        Me.Run.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Run.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Run.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Run.Properties.Appearance.Options.UseBackColor = True
        Me.Run.Properties.Appearance.Options.UseFont = True
        Me.Run.Properties.Appearance.Options.UseTextOptions = True
        Me.Run.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Run.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Run.Properties.AutoHeight = False
        Me.Run.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Run.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Run.Properties.ReadOnly = True
        Me.Run.Size = New System.Drawing.Size(51, 20)
        Me.Run.TabIndex = 13
        Me.Run.TabStop = False
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
        Me.LabelControl2.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Run"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.SpellFailure)
        Me.PanelControl9.Controls.Add(Me.LabelControl7)
        Me.PanelControl9.Location = New System.Drawing.Point(246, 82)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(126, 24)
        Me.PanelControl9.TabIndex = 675
        '
        'SpellFailure
        '
        Me.SpellFailure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpellFailure.EditValue = "-"
        Me.SpellFailure.Location = New System.Drawing.Point(73, 2)
        Me.SpellFailure.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.SpellFailure.Name = "SpellFailure"
        Me.SpellFailure.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.SpellFailure.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SpellFailure.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpellFailure.Properties.Appearance.Options.UseBackColor = True
        Me.SpellFailure.Properties.Appearance.Options.UseFont = True
        Me.SpellFailure.Properties.Appearance.Options.UseTextOptions = True
        Me.SpellFailure.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpellFailure.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SpellFailure.Properties.AutoHeight = False
        Me.SpellFailure.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.SpellFailure.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpellFailure.Properties.ReadOnly = True
        Me.SpellFailure.Size = New System.Drawing.Size(51, 20)
        Me.SpellFailure.TabIndex = 13
        Me.SpellFailure.TabStop = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 20)
        Me.LabelControl7.TabIndex = 34
        Me.LabelControl7.Text = "Spell Failure"
        '
        'PanelControl34
        '
        Me.PanelControl34.Controls.Add(Me.LabelControl17)
        Me.PanelControl34.Controls.Add(Me.Weight)
        Me.PanelControl34.Location = New System.Drawing.Point(170, 10)
        Me.PanelControl34.Name = "PanelControl34"
        Me.PanelControl34.Size = New System.Drawing.Size(223, 24)
        Me.PanelControl34.TabIndex = 669
        '
        'LabelControl17
        '
        Me.LabelControl17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseTextOptions = True
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl17.TabIndex = 34
        Me.LabelControl17.Text = "Weight"
        '
        'Weight
        '
        Me.Weight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Weight.EditValue = "-"
        Me.Weight.Location = New System.Drawing.Point(55, 2)
        Me.Weight.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Weight.Name = "Weight"
        Me.Weight.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Weight.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Weight.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weight.Properties.Appearance.Options.UseBackColor = True
        Me.Weight.Properties.Appearance.Options.UseFont = True
        Me.Weight.Properties.Appearance.Options.UseTextOptions = True
        Me.Weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Weight.Properties.AutoHeight = False
        Me.Weight.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Weight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Weight.Properties.ReadOnly = True
        Me.Weight.Size = New System.Drawing.Size(166, 20)
        Me.Weight.TabIndex = 13
        Me.Weight.TabStop = False
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Controls.Add(Me.Armor)
        Me.PanelControl5.Location = New System.Drawing.Point(135, 55)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(237, 24)
        Me.PanelControl5.TabIndex = 670
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
        Me.LabelControl3.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Armor"
        '
        'Armor
        '
        Me.Armor.EditValue = ""
        Me.Armor.Location = New System.Drawing.Point(55, 2)
        Me.Armor.Name = "Armor"
        Me.Armor.Properties.AutoHeight = False
        Me.Armor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Armor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Armor.Size = New System.Drawing.Size(180, 20)
        Me.Armor.TabIndex = 2
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.MaxDEX)
        Me.PanelControl7.Controls.Add(Me.LabelControl5)
        Me.PanelControl7.Location = New System.Drawing.Point(135, 82)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(108, 24)
        Me.PanelControl7.TabIndex = 674
        '
        'MaxDEX
        '
        Me.MaxDEX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaxDEX.EditValue = "-"
        Me.MaxDEX.Location = New System.Drawing.Point(55, 2)
        Me.MaxDEX.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MaxDEX.Name = "MaxDEX"
        Me.MaxDEX.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MaxDEX.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.MaxDEX.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxDEX.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.MaxDEX.Properties.Appearance.Options.UseBackColor = True
        Me.MaxDEX.Properties.Appearance.Options.UseFont = True
        Me.MaxDEX.Properties.Appearance.Options.UseForeColor = True
        Me.MaxDEX.Properties.Appearance.Options.UseTextOptions = True
        Me.MaxDEX.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaxDEX.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MaxDEX.Properties.AutoHeight = False
        Me.MaxDEX.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.MaxDEX.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MaxDEX.Properties.ReadOnly = True
        Me.MaxDEX.Size = New System.Drawing.Size(51, 20)
        Me.MaxDEX.TabIndex = 13
        Me.MaxDEX.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl5.TabIndex = 34
        Me.LabelControl5.Text = "Max Dex"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.Speed)
        Me.PanelControl2.Location = New System.Drawing.Point(395, 10)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(108, 24)
        Me.PanelControl2.TabIndex = 671
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
        Me.LabelControl1.Size = New System.Drawing.Size(49, 20)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Speed"
        '
        'Speed
        '
        Me.Speed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Speed.EditValue = "-"
        Me.Speed.Location = New System.Drawing.Point(55, 2)
        Me.Speed.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Speed.Name = "Speed"
        Me.Speed.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Speed.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Speed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed.Properties.Appearance.Options.UseBackColor = True
        Me.Speed.Properties.Appearance.Options.UseFont = True
        Me.Speed.Properties.Appearance.Options.UseTextOptions = True
        Me.Speed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Speed.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Speed.Properties.AutoHeight = False
        Me.Speed.Properties.DisplayFormat.FormatString = "+#;-#;+0"
        Me.Speed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Speed.Properties.ReadOnly = True
        Me.Speed.Size = New System.Drawing.Size(51, 20)
        Me.Speed.TabIndex = 13
        Me.Speed.TabStop = False
        '
        'DefaultButton
        '
        Me.DefaultButton.Location = New System.Drawing.Point(625, 11)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(140, 25)
        Me.DefaultButton.TabIndex = 679
        Me.DefaultButton.Text = "Set Default Inventory"
        Me.DefaultButton.Visible = False
        '
        'InventoryPanel
        '
        Me.Controls.Add(Me.DefaultButton)
        Me.Controls.Add(Me.PanelControl6)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl8)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl9)
        Me.Controls.Add(Me.PanelControl34)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl7)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.CarryingCapacities)
        Me.Controls.Add(Me.AddMoney)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Charges)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ByWeight)
        Me.Controls.Add(Me.ByArmor)
        Me.Name = "InventoryPanel"
        Me.Size = New System.Drawing.Size(775, 648)
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charges.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.ItemsValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.Money.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Shield.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.CheckPenalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Run.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.SpellFailure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl34.ResumeLayout(False)
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.Armor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.MaxDEX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.Speed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ByWeight As System.Windows.Forms.RadioButton
    Public WithEvents ListView1 As System.Windows.Forms.ListView
    Public WithEvents ByArmor As System.Windows.Forms.RadioButton
    Public WithEvents Quantity As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Charges As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents AddMoney As DevExpress.XtraEditors.SimpleButton
    Public WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Private WithEvents ItemsValue As DevExpress.XtraEditors.TextEdit
    Public WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Money As DevExpress.XtraEditors.TextEdit
    Public WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents Shield As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Private WithEvents CheckPenalty As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Private WithEvents Run As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Private WithEvents SpellFailure As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl34 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Weight As DevExpress.XtraEditors.TextEdit
    Public WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Public WithEvents Armor As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Private WithEvents MaxDEX As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Public WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Speed As DevExpress.XtraEditors.TextEdit
    Public WithEvents CarryingCapacities As System.Windows.Forms.Label
    Public WithEvents DefaultButton As DevExpress.XtraEditors.SimpleButton

End Class
