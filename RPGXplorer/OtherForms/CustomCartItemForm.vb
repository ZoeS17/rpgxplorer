Option Strict On
Option Explicit On 

Imports RPGXplorer.Rules
Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CustomCartItemForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents MoneyTab As System.Windows.Forms.TabPage
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents Calculate As System.Windows.Forms.CheckBox
    Public WithEvents EnhancementBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents DMaterialDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents EnhanceCheck As System.Windows.Forms.CheckBox
    Public WithEvents MasterCheck As System.Windows.Forms.CheckBox
    Public WithEvents MaterialDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents NameBox As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DMaterialLabel As System.Windows.Forms.Label
    Public WithEvents MaterialLabel As System.Windows.Forms.Label
    Public WithEvents EnhanceLabel As System.Windows.Forms.Label
    Public WithEvents MarketLabel As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents BuySize As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Money1 As RPGXplorer.Money = New RPGXplorer.Money
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomCartItemForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MoneyTab = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.BuySize = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DMaterialDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DMaterialLabel = New System.Windows.Forms.Label
        Me.EnhanceCheck = New System.Windows.Forms.CheckBox
        Me.MasterCheck = New System.Windows.Forms.CheckBox
        Me.MaterialDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.MaterialLabel = New System.Windows.Forms.Label
        Me.Calculate = New System.Windows.Forms.CheckBox
        Me.EnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.EnhanceLabel = New System.Windows.Forms.Label
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.MarketLabel = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label2 = New System.Windows.Forms.Label
        Me.NameBox = New RPGXplorer.ReadOnlyTextBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.MoneyTab.SuspendLayout()
        CType(Me.BuySize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.MoneyTab)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(362, 357)
        Me.TabControl1.TabIndex = 0
        '
        'MoneyTab
        '
        Me.MoneyTab.Controls.Add(Me.Label6)
        Me.MoneyTab.Controls.Add(Me.BuySize)
        Me.MoneyTab.Controls.Add(Me.DMaterialDropdown)
        Me.MoneyTab.Controls.Add(Me.DMaterialLabel)
        Me.MoneyTab.Controls.Add(Me.EnhanceCheck)
        Me.MoneyTab.Controls.Add(Me.MasterCheck)
        Me.MoneyTab.Controls.Add(Me.MaterialDropdown)
        Me.MoneyTab.Controls.Add(Me.MaterialLabel)
        Me.MoneyTab.Controls.Add(Me.Calculate)
        Me.MoneyTab.Controls.Add(Me.EnhancementBonus)
        Me.MoneyTab.Controls.Add(Me.EnhanceLabel)
        Me.MoneyTab.Controls.Add(Me.MarketPrice)
        Me.MoneyTab.Controls.Add(Me.MarketLabel)
        Me.MoneyTab.Controls.Add(Me.IndentedLine2)
        Me.MoneyTab.Controls.Add(Me.Label2)
        Me.MoneyTab.Controls.Add(Me.NameBox)
        Me.MoneyTab.Controls.Add(Me.IndentedLine1)
        Me.MoneyTab.Location = New System.Drawing.Point(4, 22)
        Me.MoneyTab.Name = "MoneyTab"
        Me.MoneyTab.Size = New System.Drawing.Size(354, 331)
        Me.MoneyTab.TabIndex = 0
        Me.MoneyTab.Text = "Custom Item"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 366
        Me.Label6.Text = "Purchase Size"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuySize
        '
        Me.BuySize.EditValue = ""
        Me.BuySize.Location = New System.Drawing.Point(130, 65)
        Me.BuySize.Name = "BuySize"
        Me.BuySize.Properties.AutoHeight = False
        Me.BuySize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuySize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BuySize.Size = New System.Drawing.Size(104, 21)
        Me.BuySize.TabIndex = 365
        '
        'DMaterialDropdown
        '
        Me.DMaterialDropdown.Location = New System.Drawing.Point(130, 125)
        Me.DMaterialDropdown.Name = "DMaterialDropdown"
        Me.DMaterialDropdown.Properties.AutoHeight = False
        Me.DMaterialDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DMaterialDropdown.Properties.DropDownRows = 10
        Me.DMaterialDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DMaterialDropdown.Size = New System.Drawing.Size(200, 21)
        Me.DMaterialDropdown.TabIndex = 363
        '
        'DMaterialLabel
        '
        Me.DMaterialLabel.Location = New System.Drawing.Point(15, 125)
        Me.DMaterialLabel.Name = "DMaterialLabel"
        Me.DMaterialLabel.Size = New System.Drawing.Size(110, 21)
        Me.DMaterialLabel.TabIndex = 364
        Me.DMaterialLabel.Text = "Material (Secondary)"
        Me.DMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnhanceCheck
        '
        Me.EnhanceCheck.Enabled = False
        Me.EnhanceCheck.Location = New System.Drawing.Point(15, 185)
        Me.EnhanceCheck.Name = "EnhanceCheck"
        Me.EnhanceCheck.Size = New System.Drawing.Size(104, 21)
        Me.EnhanceCheck.TabIndex = 362
        Me.EnhanceCheck.Text = "Magic/Psionic"
        '
        'MasterCheck
        '
        Me.MasterCheck.Location = New System.Drawing.Point(15, 155)
        Me.MasterCheck.Name = "MasterCheck"
        Me.MasterCheck.Size = New System.Drawing.Size(104, 21)
        Me.MasterCheck.TabIndex = 361
        Me.MasterCheck.Text = "Masterwork"
        '
        'MaterialDropdown
        '
        Me.MaterialDropdown.Location = New System.Drawing.Point(130, 95)
        Me.MaterialDropdown.Name = "MaterialDropdown"
        Me.MaterialDropdown.Properties.AutoHeight = False
        Me.MaterialDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MaterialDropdown.Properties.DropDownRows = 10
        Me.MaterialDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MaterialDropdown.Size = New System.Drawing.Size(200, 21)
        Me.MaterialDropdown.TabIndex = 359
        '
        'MaterialLabel
        '
        Me.MaterialLabel.Location = New System.Drawing.Point(15, 95)
        Me.MaterialLabel.Name = "MaterialLabel"
        Me.MaterialLabel.Size = New System.Drawing.Size(110, 21)
        Me.MaterialLabel.TabIndex = 360
        Me.MaterialLabel.Text = "Special Material"
        Me.MaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(15, 265)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(104, 21)
        Me.Calculate.TabIndex = 351
        Me.Calculate.Text = "Calculate Price"
        '
        'EnhancementBonus
        '
        Me.EnhancementBonus.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.EnhancementBonus.Enabled = False
        Me.EnhancementBonus.Location = New System.Drawing.Point(130, 215)
        Me.EnhancementBonus.Name = "EnhancementBonus"
        Me.EnhancementBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.EnhancementBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EnhancementBonus.Properties.AutoHeight = False
        Me.EnhancementBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.EnhancementBonus.Properties.DisplayFormat.FormatString = "+0;0;0"
        Me.EnhancementBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.EditFormat.FormatString = "+0;0;0"
        Me.EnhancementBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.IsFloatValue = False
        Me.EnhancementBonus.Properties.Mask.EditMask = "N00"
        Me.EnhancementBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EnhancementBonus.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.EnhancementBonus.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Size = New System.Drawing.Size(50, 21)
        Me.EnhancementBonus.TabIndex = 350
        '
        'EnhanceLabel
        '
        Me.EnhanceLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EnhanceLabel.Enabled = False
        Me.EnhanceLabel.Location = New System.Drawing.Point(35, 215)
        Me.EnhanceLabel.Name = "EnhanceLabel"
        Me.EnhanceLabel.Size = New System.Drawing.Size(90, 21)
        Me.EnhanceLabel.TabIndex = 356
        Me.EnhanceLabel.Text = "Enhancement"
        Me.EnhanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MarketPrice
        '
        Me.MarketPrice.Location = New System.Drawing.Point(90, 295)
        Me.MarketPrice.MaxGP = 999999
        Me.MarketPrice.Money = Money1
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 352
        Me.MarketPrice.Value = Nothing
        '
        'MarketLabel
        '
        Me.MarketLabel.Location = New System.Drawing.Point(15, 295)
        Me.MarketLabel.Name = "MarketLabel"
        Me.MarketLabel.Size = New System.Drawing.Size(70, 21)
        Me.MarketLabel.TabIndex = 354
        Me.MarketLabel.Text = "Market Price"
        Me.MarketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 250)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(325, 5)
        Me.IndentedLine2.TabIndex = 355
        Me.IndentedLine2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Base Item"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameBox
        '
        Me.NameBox.BackColor = System.Drawing.Color.White
        Me.NameBox.Caption = Nothing
        Me.NameBox.CaptionAligment = System.Drawing.ContentAlignment.MiddleLeft
        Me.NameBox.ForeColor = System.Drawing.Color.Black
        Me.NameBox.LineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.NameBox.Location = New System.Drawing.Point(130, 15)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Padding = New System.Windows.Forms.Padding(1)
        Me.NameBox.Size = New System.Drawing.Size(200, 21)
        Me.NameBox.TabIndex = 270
        Me.NameBox.TabStop = False
        Me.NameBox.TextColor = System.Drawing.Color.Black
        Me.NameBox.Vertical = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(325, 5)
        Me.IndentedLine1.TabIndex = 267
        Me.IndentedLine1.TabStop = False
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(227, 387)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(307, 387)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        '
        'CustomCartItemForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(394, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomCartItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Item"
        Me.TabControl1.ResumeLayout(False)
        Me.MoneyTab.ResumeLayout(False)
        CType(Me.BuySize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'items
    Public InventoryItem As Objects.ObjectData
    Private BaseItem As Objects.ObjectData
    Private CartKey As Objects.ObjectKey

    'datalist
    Private MaterialDataList As General.DataListItem()

    'flags
    Private BaseItemMasterwork As Boolean
    Private PrimaryMaterialMasterwork As Boolean
    Private SecondaryMaterialMasterwork As Boolean
    Private DoubleWeaponMode As Boolean

    'materials
    Private PrimaryMaterial As Rules.SpecialMaterial
    Private SecondaryMaterial As Rules.SpecialMaterial

    'event flag counter
    Private SuspendCalculateEventCounter As Integer

#End Region

    'init
    Public Function Init(ByVal BaseItem As Objects.ObjectData, ByVal CartSize As String, ByVal CartKey As Objects.ObjectKey) As Boolean
        Try

            'get vars
            Me.BaseItem = BaseItem
            Me.CartKey = CartKey

            'set name
            NameBox.Text = BaseItem.Name

            'get materials
            MaterialDataList = Rules.Index.DataList(Rules.SpecialMaterial.CompatibleMaterials(BaseItem), True)

            'set layout
            If BaseItem.Element("Double") = "Yes" Then
                DoubleWeaponMode = True
                MaterialLabel.Text = "Material (Primary)"
                MaterialDropdown.Properties.Items.AddRange(MaterialDataList)
                DMaterialDropdown.Properties.Items.AddRange(MaterialDataList)
                MaterialDropdown.SelectedIndex = 0
                DMaterialDropdown.SelectedIndex = 0
            Else
                DMaterialDropdown.Visible = False
                DMaterialLabel.Visible = False
                ShiftUpControls()
                MaterialDropdown.Properties.Items.AddRange(MaterialDataList)
                MaterialDropdown.SelectedIndex = 0
            End If

            BuySize.Properties.Items.AddRange(Rules.Lists.Sizes)
            BuySize.Text = CartSize

            If BaseItem.Element("Masterwork") = "Yes" Then BaseItemMasterwork = True
            UpdateMasterwork()

            Calculate.Checked = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'ok
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Weight As Double
        Dim Enhancement As Integer
        Try
            InventoryItem.Name = BaseItem.Name
            InventoryItem.ObjectGUID = Objects.ObjectKey.NewGuid(CartKey.Database)
            InventoryItem.Type = Objects.ItemType
            InventoryItem.ParentGUID = CartKey
            InventoryItem.HTMLGUID = BaseItem.ObjectGUID
            InventoryItem.Element("ItemType") = BaseItem.Type
            InventoryItem.FKElement("Item", BaseItem.Name, "Name", BaseItem.ObjectGUID)
            InventoryItem.Element("BaseCost") = MarketPrice.Money.DisplayString
            InventoryItem.Element("Cost") = MarketPrice.Money.DisplayString
            InventoryItem.Element("Quantity") = "1"
            InventoryItem.Element("Size") = BuySize.Text
            If Items.DisplaySize(BaseItem) Then
                InventoryItem.Element("DisplaySize") = BuySize.Text
            Else
                InventoryItem.Element("DisplaySize") = ""
            End If

            'calculate the weight
            Weight = CType(Items.ItemWeight(BaseItem, BuySize.Text), Double)

            If DoubleWeaponMode Then
                'split into two parts - treat seperately
                Dim PrimaryWeight, SecondaryWeight As Double
                Dim TempString As String = ""
                PrimaryWeight = Weight * 0.5 : SecondaryWeight = PrimaryWeight

                If Not PrimaryMaterial Is Nothing Then
                    PrimaryWeight = PrimaryWeight * PrimaryMaterial.WeightAdjustmet
                    InventoryItem.FKElement("Material", PrimaryMaterial.MaterialObject.Name, "Name", PrimaryMaterial.MaterialObject.ObjectGUID)
                    TempString = PrimaryMaterial.MaterialObject.Name
                End If

                If Not SecondaryMaterial Is Nothing Then
                    SecondaryWeight = SecondaryWeight * SecondaryMaterial.WeightAdjustmet
                    InventoryItem.FKElement("DMaterial", SecondaryMaterial.MaterialObject.Name, "Name", SecondaryMaterial.MaterialObject.ObjectGUID)

                    If TempString = "" Then
                        TempString = "-/" & SecondaryMaterial.MaterialObject.Name
                    Else
                        If Not TempString = SecondaryMaterial.MaterialObject.Name Then TempString = TempString & "/" & SecondaryMaterial.MaterialObject.Name
                    End If

                Else
                    If TempString <> "" Then TempString &= "/-"
                End If

                If TempString <> "" Then InventoryItem.Name = TempString & " " & InventoryItem.Name
                Weight = PrimaryWeight + SecondaryWeight
            Else
                If Not PrimaryMaterial Is Nothing Then
                    InventoryItem.FKElement("Material", PrimaryMaterial.MaterialObject.Name, "Name", PrimaryMaterial.MaterialObject.ObjectGUID)
                    InventoryItem.Name = PrimaryMaterial.MaterialObject.Name & " " & InventoryItem.Name
                    Weight = Weight * PrimaryMaterial.WeightAdjustmet
                End If
            End If

            InventoryItem.Element("BaseWeight") = Formatting.FormatPounds(Weight)
            InventoryItem.Element("Weight") = InventoryItem.Element("BaseWeight")

            If MasterCheck.Checked Then
                InventoryItem.Element("Masterwork") = "Yes"
                Enhancement = Integer.Parse(EnhancementBonus.Text)
                If Enhancement > 0 Then
                    InventoryItem.Element("EnhancementBonus") = "+" & Enhancement.ToString
                    InventoryItem.Name &= " +" & Enhancement.ToString
                    If BaseItem.Element("Double") = "Yes" Then InventoryItem.Name &= "/+" & Enhancement.ToString
                Else
                    InventoryItem.Element("EnhancementBonus") = ""
                    If MasterCheck.Enabled = True Then
                        InventoryItem.Name &= ", Masterwork"
                    End If
                End If
            Else
                InventoryItem.Element("Masterwork") = ""
                InventoryItem.Element("EnhancementBonus") = ""
            End If

            'can modifiers be activated/deactivated
            Select Case BaseItem.Type
                Case Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.StaffDefinitionType, Objects.RodDefinitionType, Objects.RingDefinitionType, Objects.UniversalItemDefinitionType, Objects.PsionicArtifactDefinitionType, Objects.PsionicPsicrownDefinitionType
                    InventoryItem.Element("Active") = "Yes"
                Case Objects.ItemDefinitionType
                    If BaseItem.HasChildren Then InventoryItem.Element("Active") = "Yes"
                Case Else
                    InventoryItem.Element("Active") = ""
            End Select

            'charges
            Select Case BaseItem.Type
                Case Objects.ItemDefinitionType, Objects.UniversalItemDefinitionType
                    InventoryItem.Element("Charges") = BaseItem.Element("DefaultUses")
                Case Objects.WandDefinitionType, Objects.StaffDefinitionType, Objects.PsionicDorjeDefinitionType
                    InventoryItem.Element("Charges") = "50"
                Case Objects.PsionicPsicrownDefinitionType
                    InventoryItem.Element("Charges") = BaseItem.Element("PowerPoints")
                Case Else
                    InventoryItem.Element("Charges") = ""
            End Select

            InventoryItem.ImageFilename = BaseItem.ImageFilename

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

#Region "Event Handlers"

    Private Sub MaterialDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialDropdown.SelectedIndexChanged
        Try

            SuspendCalculateEventCounter += 1

            PrimaryMaterial = Nothing
            PrimaryMaterialMasterwork = False

            If MaterialDropdown.SelectedIndex > 0 Then
                PrimaryMaterial = CType(Rules.SpecialMaterial.Materials.Item(CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID), Rules.SpecialMaterial)
                If Not PrimaryMaterial Is Nothing Then
                    If PrimaryMaterial.MaterialForcesMasterwork Then PrimaryMaterialMasterwork = True
                End If
            End If

            UpdateMasterwork()

            SuspendCalculateEventCounter -= 1

            If (SuspendCalculateEventCounter = 0) AndAlso Calculate.Checked Then
                CalculatePrice()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DMaterialDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DMaterialDropdown.SelectedIndexChanged
        Try

            SuspendCalculateEventCounter += 1

            SecondaryMaterial = Nothing
            SecondaryMaterialMasterwork = False

            If DMaterialDropdown.SelectedIndex > 0 Then
                SecondaryMaterial = CType(Rules.SpecialMaterial.Materials.Item(CType(DMaterialDropdown.SelectedItem, DataListItem).ObjectGUID), Rules.SpecialMaterial)
                If Not SecondaryMaterial Is Nothing Then
                    If SecondaryMaterial.MaterialForcesMasterwork Then SecondaryMaterialMasterwork = True
                End If
            End If

            UpdateMasterwork()

            SuspendCalculateEventCounter -= 1

            If (SuspendCalculateEventCounter = 0) AndAlso Calculate.Checked Then
                CalculatePrice()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub BuySize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuySize.SelectedIndexChanged
        Try

            If Calculate.Checked Then
                CalculatePrice()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MasterCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterCheck.CheckedChanged
        Try
            SuspendCalculateEventCounter += 1

            If MasterCheck.Checked Then
                EnhanceCheck.Enabled = True
            Else
                EnhanceCheck.Enabled = False
                EnhanceCheck.Checked = False
            End If

            SuspendCalculateEventCounter -= 1

            If (SuspendCalculateEventCounter = 0) AndAlso Calculate.Checked Then
                CalculatePrice()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EnhanceCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhanceCheck.CheckedChanged
        Try
            SuspendCalculateEventCounter += 1

            If EnhanceCheck.Checked Then
                EnhanceLabel.Enabled = True
                EnhancementBonus.Enabled = True
                EnhancementBonus.Value = 1
            Else
                EnhanceLabel.Enabled = False
                EnhancementBonus.Enabled = False
                EnhancementBonus.Value = 0
            End If

            SuspendCalculateEventCounter -= 1

            If (SuspendCalculateEventCounter = 0) AndAlso Calculate.Checked Then
                CalculatePrice()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EnhancementBonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancementBonus.EditValueChanged
        Try

            If (SuspendCalculateEventCounter = 0) AndAlso Calculate.Checked Then
                CalculatePrice()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Calculate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.CheckedChanged
        If Calculate.Checked Then
            MarketPrice.Enabled = False
            CalculatePrice()
        Else
            MarketPrice.Enabled = True
        End If
    End Sub

#End Region

#Region "Helper Commads"

    Private Sub ShiftUpControls()
        Try
            Dim TempLocation As System.Drawing.Point

            'mastercheck
            TempLocation = MasterCheck.Location
            TempLocation.Y -= 30
            MasterCheck.Location = TempLocation

            'EnhanceCheck
            TempLocation = EnhanceCheck.Location
            TempLocation.Y -= 30
            EnhanceCheck.Location = TempLocation

            'EnhanceLabel
            TempLocation = EnhanceLabel.Location
            TempLocation.Y -= 30
            EnhanceLabel.Location = TempLocation

            'EnhancementBonus
            TempLocation = EnhancementBonus.Location
            TempLocation.Y -= 30
            EnhancementBonus.Location = TempLocation

            'IndentedLine2
            TempLocation = IndentedLine2.Location
            TempLocation.Y -= 30
            IndentedLine2.Location = TempLocation

            'Calculate
            TempLocation = Calculate.Location
            TempLocation.Y -= 30
            Calculate.Location = TempLocation

            'MarketLabel
            TempLocation = MarketLabel.Location
            TempLocation.Y -= 30
            MarketLabel.Location = TempLocation

            'MarketPrice
            TempLocation = MarketPrice.Location
            TempLocation.Y -= 30
            MarketPrice.Location = TempLocation

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub UpdateMasterwork()
        Try
            If BaseItemMasterwork OrElse PrimaryMaterialMasterwork OrElse SecondaryMaterialMasterwork Then
                MasterCheck.Checked = True
                MasterCheck.Enabled = False
            Else
                MasterCheck.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub CalculatePrice()
        Dim PrimaryMaterialKey, SecondaryMaterialKey As Objects.ObjectKey
        Dim Price As RPGXplorer.Money

        Try

            If MaterialDropdown.SelectedIndex > 0 Then
                PrimaryMaterialKey = CType(MaterialDropdown.SelectedItem, DataListItem).ObjectGUID
            End If

            If DoubleWeaponMode Then
                If DMaterialDropdown.SelectedIndex > 0 Then
                    SecondaryMaterialKey = CType(DMaterialDropdown.SelectedItem, DataListItem).ObjectGUID
                End If

                If MasterCheck.Checked Then
                    Price = Rules.Items.EnhancedPrice(BaseItem, BuySize.Text, PrimaryMaterialKey, SecondaryMaterialKey, Integer.Parse(EnhancementBonus.Text), Integer.Parse(EnhancementBonus.Text))
                Else
                    If Not PrimaryMaterial Is Nothing Then
                        Price = Rules.Items.MarketPrice(PrimaryMaterial.CalculateNonEnhancedPrice(BaseItem, BuySize.Text, False, False, SecondaryMaterial))
                    Else
                        If Not SecondaryMaterial Is Nothing Then
                            Price = Rules.Items.MarketPrice(SecondaryMaterial.CalculateNonEnhancedPrice(BaseItem, BuySize.Text, False, True))
                        Else
                            Price = Rules.Items.ItemCost(BaseItem, BuySize.Text)
                        End If
                    End If
                End If
            Else
                If MasterCheck.Checked Then
                    Price = Rules.Items.EnhancedPrice(BaseItem, BuySize.Text, PrimaryMaterialKey, Integer.Parse(EnhancementBonus.Text))
                Else
                    If Not PrimaryMaterial Is Nothing Then
                        Price = Rules.Items.MarketPrice(PrimaryMaterial.CalculateNonEnhancedPrice(BaseItem, BuySize.Text))
                    Else
                        Price = Rules.Items.ItemCost(BaseItem, BuySize.Text)
                    End If
                End If
            End If

            If Not Price Is Nothing Then
                MarketPrice.Money = Price
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class


