<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssetsPanel
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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Quantity = New DevExpress.XtraEditors.SpinEdit
        Me.Charges = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.AddMoney = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.ItemsValue = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Money = New DevExpress.XtraEditors.TextEdit
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charges.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.ItemsValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.Money.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ListView1.Location = New System.Drawing.Point(0, 70)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(775, 580)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(285, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 292
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Quantity
        '
        Me.Quantity.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Location = New System.Drawing.Point(340, 12)
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
        'Charges
        '
        Me.Charges.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Charges.Location = New System.Drawing.Point(340, 37)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(255, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 655
        Me.Label1.Text = "Charges/Uses"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddMoney
        '
        Me.AddMoney.Image = Global.RPGXplorer.My.Resources.Resources.goldbar
        Me.AddMoney.Location = New System.Drawing.Point(410, 35)
        Me.AddMoney.Name = "AddMoney"
        Me.AddMoney.Size = New System.Drawing.Size(105, 25)
        Me.AddMoney.TabIndex = 656
        Me.AddMoney.Text = "Add Money"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.LabelControl9)
        Me.PanelControl6.Controls.Add(Me.ItemsValue)
        Me.PanelControl6.Location = New System.Drawing.Point(10, 36)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(237, 24)
        Me.PanelControl6.TabIndex = 680
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
        Me.PanelControl4.Location = New System.Drawing.Point(10, 10)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(237, 24)
        Me.PanelControl4.TabIndex = 679
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
        'AssetsPanel
        '
        Me.Controls.Add(Me.PanelControl6)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.AddMoney)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Charges)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "AssetsPanel"
        Me.Size = New System.Drawing.Size(775, 648)
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charges.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.ItemsValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.Money.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ListView1 As System.Windows.Forms.ListView
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Quantity As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Charges As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents AddMoney As DevExpress.XtraEditors.SimpleButton
    Public WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Private WithEvents ItemsValue As DevExpress.XtraEditors.TextEdit
    Public WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Private WithEvents Money As DevExpress.XtraEditors.TextEdit

End Class
