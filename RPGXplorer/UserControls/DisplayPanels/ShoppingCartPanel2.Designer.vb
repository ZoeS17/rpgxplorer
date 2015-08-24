<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingCartPanel2
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
        Me.Clear = New DevExpress.XtraEditors.SimpleButton
        Me.PutBack = New DevExpress.XtraEditors.SimpleButton
        Me.CartListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Free = New System.Windows.Forms.CheckBox
        Me.BuySize = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Purchase = New DevExpress.XtraEditors.SimpleButton
        Me.Characters = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Icons = New DevExpress.XtraEditors.SimpleButton
        Me.Details = New DevExpress.XtraEditors.SimpleButton
        Me.Quantity = New DevExpress.XtraEditors.SpinEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Funds = New RPGXplorer.ReadOnlyTextBox
        Me.Spent = New RPGXplorer.ReadOnlyTextBox
        Me.Weight = New RPGXplorer.ReadOnlyTextBox
        CType(Me.BuySize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Characters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clear
        '
        Me.Clear.Image = Global.RPGXplorer.My.Resources.Resources.shoppingbasket
        Me.Clear.Location = New System.Drawing.Point(10, 220)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(90, 25)
        Me.Clear.TabIndex = 10
        Me.Clear.Text = "Empty"
        '
        'PutBack
        '
        Me.PutBack.Image = Global.RPGXplorer.My.Resources.Resources.shoppingbasket_delete
        Me.PutBack.Location = New System.Drawing.Point(10, 185)
        Me.PutBack.Name = "PutBack"
        Me.PutBack.Size = New System.Drawing.Size(90, 25)
        Me.PutBack.TabIndex = 9
        Me.PutBack.Text = "Put Back"
        '
        'CartListView
        '
        Me.CartListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CartListView.BackColor = System.Drawing.SystemColors.Window
        Me.CartListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CartListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.CartListView.FullRowSelect = True
        Me.CartListView.HideSelection = False
        Me.CartListView.Location = New System.Drawing.Point(250, 0)
        Me.CartListView.Name = "CartListView"
        Me.CartListView.Size = New System.Drawing.Size(430, 280)
        Me.CartListView.TabIndex = 13
        Me.CartListView.UseCompatibleStateImageBehavior = False
        Me.CartListView.View = System.Windows.Forms.View.Details
        '
        'Free
        '
        Me.Free.BackColor = System.Drawing.Color.Transparent
        Me.Free.Location = New System.Drawing.Point(120, 185)
        Me.Free.Name = "Free"
        Me.Free.Size = New System.Drawing.Size(50, 25)
        Me.Free.TabIndex = 7
        Me.Free.Text = "Free"
        Me.Free.UseVisualStyleBackColor = False
        '
        'BuySize
        '
        Me.BuySize.EditValue = ""
        Me.BuySize.Location = New System.Drawing.Point(135, 35)
        Me.BuySize.Name = "BuySize"
        Me.BuySize.Properties.AutoHeight = False
        Me.BuySize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuySize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BuySize.Size = New System.Drawing.Size(104, 21)
        Me.BuySize.TabIndex = 2
        '
        'Purchase
        '
        Me.Purchase.Image = Global.RPGXplorer.My.Resources.Resources.goldbars
        Me.Purchase.Location = New System.Drawing.Point(175, 185)
        Me.Purchase.Name = "Purchase"
        Me.Purchase.Size = New System.Drawing.Size(65, 25)
        Me.Purchase.TabIndex = 8
        Me.Purchase.Text = "Buy"
        '
        'Characters
        '
        Me.Characters.EditValue = ""
        Me.Characters.Location = New System.Drawing.Point(90, 10)
        Me.Characters.Name = "Characters"
        Me.Characters.Properties.AutoHeight = False
        Me.Characters.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Characters.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Characters.Size = New System.Drawing.Size(150, 21)
        Me.Characters.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Image = Global.RPGXplorer.My.Resources.Resources.CharacterHumanMale
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(10, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "       Character"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Image = Global.RPGXplorer.My.Resources.Resources.money
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(10, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "       Funds"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Image = Global.RPGXplorer.My.Resources.Resources.goldbar
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(10, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "       Spent"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = Global.RPGXplorer.My.Resources.Resources.moneybag
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "       Weight"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Icons
        '
        Me.Icons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Icons.Image = Global.RPGXplorer.My.Resources.Resources.ViewModeLargeIcons
        Me.Icons.Location = New System.Drawing.Point(185, 245)
        Me.Icons.Name = "Icons"
        Me.Icons.Size = New System.Drawing.Size(25, 25)
        Me.Icons.TabIndex = 11
        '
        'Details
        '
        Me.Details.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Details.Image = Global.RPGXplorer.My.Resources.Resources.ViewModeDetails
        Me.Details.Location = New System.Drawing.Point(215, 245)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(25, 25)
        Me.Details.TabIndex = 12
        '
        'Quantity
        '
        Me.Quantity.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Enabled = False
        Me.Quantity.Location = New System.Drawing.Point(175, 150)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Properties.Appearance.Options.UseTextOptions = True
        Me.Quantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Quantity.Properties.AutoHeight = False
        Me.Quantity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Quantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Quantity.Properties.IsFloatValue = False
        Me.Quantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Quantity.Properties.Mask.ShowPlaceHolders = False
        Me.Quantity.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Quantity.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Size = New System.Drawing.Size(65, 21)
        Me.Quantity.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(60, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(20, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Purchase Size"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Funds
        '
        Me.Funds.BackColor = System.Drawing.Color.White
        Me.Funds.Caption = Nothing
        Me.Funds.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Funds.ForeColor = System.Drawing.Color.Black
        Me.Funds.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Funds.Location = New System.Drawing.Point(90, 95)
        Me.Funds.Name = "Funds"
        Me.Funds.Padding = New System.Windows.Forms.Padding(1)
        Me.Funds.Size = New System.Drawing.Size(150, 21)
        Me.Funds.TabIndex = 4
        Me.Funds.TabStop = False
        Me.Funds.TextColor = System.Drawing.Color.Black
        Me.Funds.Vertical = False
        '
        'Spent
        '
        Me.Spent.BackColor = System.Drawing.Color.White
        Me.Spent.Caption = Nothing
        Me.Spent.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Spent.ForeColor = System.Drawing.Color.Black
        Me.Spent.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Spent.Location = New System.Drawing.Point(90, 120)
        Me.Spent.Name = "Spent"
        Me.Spent.Padding = New System.Windows.Forms.Padding(1)
        Me.Spent.Size = New System.Drawing.Size(150, 21)
        Me.Spent.TabIndex = 5
        Me.Spent.TabStop = False
        Me.Spent.TextColor = System.Drawing.Color.Black
        Me.Spent.Vertical = False
        '
        'Weight
        '
        Me.Weight.BackColor = System.Drawing.Color.White
        Me.Weight.Caption = Nothing
        Me.Weight.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Weight.ForeColor = System.Drawing.Color.Black
        Me.Weight.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Weight.Location = New System.Drawing.Point(90, 65)
        Me.Weight.Name = "Weight"
        Me.Weight.Padding = New System.Windows.Forms.Padding(1)
        Me.Weight.Size = New System.Drawing.Size(150, 21)
        Me.Weight.TabIndex = 3
        Me.Weight.TabStop = False
        Me.Weight.TextColor = System.Drawing.Color.Black
        Me.Weight.Vertical = False
        '
        'ShoppingCartPanel2
        '
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.Icons)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.PutBack)
        Me.Controls.Add(Me.Free)
        Me.Controls.Add(Me.BuySize)
        Me.Controls.Add(Me.Purchase)
        Me.Controls.Add(Me.Characters)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Funds)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Spent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.CartListView)
        Me.Name = "ShoppingCartPanel2"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(680, 280)
        CType(Me.BuySize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Characters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Clear As DevExpress.XtraEditors.SimpleButton
    Public WithEvents PutBack As DevExpress.XtraEditors.SimpleButton
    Public WithEvents CartListView As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents Free As System.Windows.Forms.CheckBox
    Public WithEvents BuySize As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Purchase As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Characters As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Funds As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Spent As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Weight As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Icons As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Details As DevExpress.XtraEditors.SimpleButton
    Public WithEvents Quantity As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label

End Class
