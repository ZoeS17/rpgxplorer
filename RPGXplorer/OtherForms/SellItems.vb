Option Strict On
Option Explicit On 

Imports RPGXplorer.Rules
Imports RPGXplorer.Exceptions

Public Class SellItems
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
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Coins As RPGXplorer.MoneySpin2
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents BaseValue As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Sale As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Percentage As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Specific As System.Windows.Forms.RadioButton
    Public WithEvents PercentageRadio As System.Windows.Forms.RadioButton
    Public WithEvents Gold As System.Windows.Forms.RadioButton
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Platinum As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SellItems))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MoneyTab = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Gold = New System.Windows.Forms.RadioButton
        Me.Platinum = New System.Windows.Forms.RadioButton
        Me.Specific = New System.Windows.Forms.RadioButton
        Me.Percentage = New DevExpress.XtraEditors.SpinEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label2 = New System.Windows.Forms.Label
        Me.BaseValue = New RPGXplorer.ReadOnlyTextBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Coins = New RPGXplorer.MoneySpin2
        Me.Label4 = New System.Windows.Forms.Label
        Me.Sale = New RPGXplorer.ReadOnlyTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PercentageRadio = New System.Windows.Forms.RadioButton
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.MoneyTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(290, 357)
        Me.TabControl1.TabIndex = 0
        '
        'MoneyTab
        '
        Me.MoneyTab.Controls.Add(Me.Panel1)
        Me.MoneyTab.Controls.Add(Me.Specific)
        Me.MoneyTab.Controls.Add(Me.Percentage)
        Me.MoneyTab.Controls.Add(Me.IndentedLine2)
        Me.MoneyTab.Controls.Add(Me.Label2)
        Me.MoneyTab.Controls.Add(Me.BaseValue)
        Me.MoneyTab.Controls.Add(Me.IndentedLine1)
        Me.MoneyTab.Controls.Add(Me.Coins)
        Me.MoneyTab.Controls.Add(Me.Label4)
        Me.MoneyTab.Controls.Add(Me.Sale)
        Me.MoneyTab.Controls.Add(Me.Label5)
        Me.MoneyTab.Controls.Add(Me.PercentageRadio)
        Me.MoneyTab.Location = New System.Drawing.Point(4, 22)
        Me.MoneyTab.Name = "MoneyTab"
        Me.MoneyTab.Size = New System.Drawing.Size(282, 331)
        Me.MoneyTab.TabIndex = 0
        Me.MoneyTab.Text = "Sale"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Gold)
        Me.Panel1.Controls.Add(Me.Platinum)
        Me.Panel1.Location = New System.Drawing.Point(90, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 30)
        Me.Panel1.TabIndex = 273
        '
        'Gold
        '
        Me.Gold.Checked = True
        Me.Gold.Cursor = System.Windows.Forms.Cursors.Default
        Me.Gold.Location = New System.Drawing.Point(5, 5)
        Me.Gold.Name = "Gold"
        Me.Gold.Size = New System.Drawing.Size(55, 21)
        Me.Gold.TabIndex = 273
        Me.Gold.TabStop = True
        Me.Gold.Text = "Gold"
        '
        'Platinum
        '
        Me.Platinum.Location = New System.Drawing.Point(65, 5)
        Me.Platinum.Name = "Platinum"
        Me.Platinum.Size = New System.Drawing.Size(70, 21)
        Me.Platinum.TabIndex = 273
        Me.Platinum.Text = "Platinum"
        '
        'Specific
        '
        Me.Specific.Location = New System.Drawing.Point(15, 125)
        Me.Specific.Name = "Specific"
        Me.Specific.Size = New System.Drawing.Size(95, 21)
        Me.Specific.TabIndex = 2
        Me.Specific.Text = "Specific"
        '
        'Percentage
        '
        Me.Percentage.EditValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Percentage.Location = New System.Drawing.Point(115, 95)
        Me.Percentage.Name = "Percentage"
        '
        'Percentage.Properties
        '
        Me.Percentage.Properties.AutoHeight = False
        Me.Percentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Percentage.Properties.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.Percentage.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        'Me.Percentage.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        'Me.Percentage.Properties.UseCtrlIncrement = False
        Me.Percentage.Size = New System.Drawing.Size(75, 21)
        Me.Percentage.TabIndex = 1
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 250)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(250, 5)
        Me.IndentedLine2.TabIndex = 272
        Me.IndentedLine2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Base Value"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseValue
        '
        Me.BaseValue.BackColor = System.Drawing.Color.White
        Me.BaseValue.Caption = Nothing
        Me.BaseValue.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BaseValue.DockPadding.All = 1
        Me.BaseValue.ForeColor = System.Drawing.Color.Black
        Me.BaseValue.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.BaseValue.Location = New System.Drawing.Point(90, 15)
        Me.BaseValue.Name = "BaseValue"
        Me.BaseValue.Size = New System.Drawing.Size(175, 21)
        Me.BaseValue.TabIndex = 270
        Me.BaseValue.TabStop = False
        Me.BaseValue.TextColor = System.Drawing.Color.Black
        Me.BaseValue.Vertical = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(250, 5)
        Me.IndentedLine1.TabIndex = 267
        Me.IndentedLine1.TabStop = False
        '
        'Coins
        '
        Me.Coins.Enabled = False
        Me.Coins.Location = New System.Drawing.Point(115, 125)
        Me.Coins.Name = "Coins"
        Me.Coins.Size = New System.Drawing.Size(100, 111)
        Me.Coins.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(15, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Sale Value"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sale
        '
        Me.Sale.BackColor = System.Drawing.Color.White
        Me.Sale.Caption = Nothing
        Me.Sale.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Sale.DockPadding.All = 1
        Me.Sale.ForeColor = System.Drawing.Color.Black
        Me.Sale.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.Sale.Location = New System.Drawing.Point(90, 265)
        Me.Sale.Name = "Sale"
        Me.Sale.Size = New System.Drawing.Size(175, 21)
        Me.Sale.TabIndex = 263
        Me.Sale.TabStop = False
        Me.Sale.TextColor = System.Drawing.Color.Black
        Me.Sale.Vertical = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(15, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 271
        Me.Label5.Text = "Sell for"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PercentageRadio
        '
        Me.PercentageRadio.Checked = True
        Me.PercentageRadio.Location = New System.Drawing.Point(15, 95)
        Me.PercentageRadio.Name = "PercentageRadio"
        Me.PercentageRadio.Size = New System.Drawing.Size(85, 21)
        Me.PercentageRadio.TabIndex = 0
        Me.PercentageRadio.TabStop = True
        Me.PercentageRadio.Text = "Percentage"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(155, 387)
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
        Me.Cancel.Location = New System.Drawing.Point(235, 387)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        '
        'SellItems
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(322, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SellItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sell Items"
        Me.TabControl1.ResumeLayout(False)
        Me.MoneyTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private BaseMoney As New Money
    Private SaleMoney As Money
    Private SaleItems As New Objects.ObjectDataCollection
    Private Character As Character

#End Region

    'init
    Public Function Init() As Boolean
        Try
            'get the value of the items selected, including any children (not money)
            GetSaleItems(General.MainExplorer.CurrentSelectedObjects)
            BaseValue.Text = BaseMoney.DisplayString
            Coins.Money = BaseMoney

            'formatting
            Percentage.Properties.DisplayFormat.Format = New PercentFormatter

            'get the character
            Select Case General.MainExplorer.CurrentPanelType
                Case Explorer.PanelType.AssetsPanel
                    Character = CharacterManager.GetCharacter(CType(General.MainExplorer.CurrentPanel, AssetsPanel).CharacterKey)
                Case Explorer.PanelType.Inventory
                    Character = CharacterManager.GetCharacter(CType(General.MainExplorer.CurrentPanel, InventoryPanel).CharacterKey)
            End Select

            'check to see if selection contains worn armor or shield
            If Character.Inventory.ArmorWorn.IsNotEmpty Then
                If SaleItems.Contains(Character.Inventory.ArmorWorn) Then
                    General.ShowInfoDialog("Selected items contain the armor or shield (or both) that you are currently wearing.")
                    Return False
                End If
            End If

            If Character.Inventory.ShieldWorn.IsNotEmpty Then
                If SaleItems.Contains(Character.Inventory.ShieldWorn) Then
                    General.ShowInfoDialog("Selected items contain the armor or shield (or both) that you are currently wearing.")
                    Return False
                End If
            End If

            'check to see if the selection contains any money 
            For Each Item As Objects.ObjectData In SaleItems
                If Item.Type = Objects.MoneyType Then
                    General.ShowInfoDialog("Selected items contain money. You cannot sell money.")
                    Return False
                End If
            Next

            'check for equiped weapons
            Dim WeaponConfigFolder As Objects.ObjectData = Character.CharacterObject.FirstChildOfType(Objects.WeaponConfigFolderType)
            For Each WeaponConfig As Objects.ObjectData In WeaponConfigFolder.Children

                If Not WeaponConfig.GetFKGuid("PrimaryInventory").IsEmpty Then

                    If SaleItems.Contains(WeaponConfig.GetFKGuid("PrimaryInventory")) Then
                        General.ShowInfoDialog("Selected items contain a weapon or shield used in a weapon configuration.")
                        Return False
                    End If

                End If

                If Not WeaponConfig.GetFKGuid("OffHandInventory").IsEmpty Then
                    If SaleItems.Contains(WeaponConfig.GetFKGuid("OffHandInventory")) Then
                        General.ShowInfoDialog("Selected items contain a weapon or shield used in a weapon configuration.")
                        Return False
                    End If
                End If


                If Not WeaponConfig.GetFKGuid("BucklerInventory").IsEmpty Then
                    If SaleItems.Contains(WeaponConfig.GetFKGuid("BucklerInventory")) Then
                        General.ShowInfoDialog("Selected items contain a weapon or shield used in a weapon configuration.")
                        Return False
                    End If
                End If

            Next

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'ok
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim TreeNode As TreeNode

        Try
            General.MainExplorer.Undo.UndoRecord()
            General.SetWaitCursor()

            'delete the items
            General.MainExplorer.TreeView.BeginUpdate()
            For Each Item As Objects.ObjectData In SaleItems
                Item.Delete()

                TreeNode = CType(General.MainExplorer.TreeNodes(Item.ObjectGUID), TreeNode)
                If Not TreeNode Is Nothing Then
                    TreeNode.Remove()
                    General.MainExplorer.TreeNodes.Remove(Item.ObjectGUID)
                End If

            Next
            General.MainExplorer.TreeView.EndUpdate()

            'create money obj
            Dim MoneyObj As New Objects.ObjectData
            If Not Sale.Text = "" Then
                Dim ParentKey As Objects.ObjectKey
                If General.MainExplorer.CurrentFocus = Explorer.Focus.TreeView Then
                    ParentKey = General.MainExplorer.ObjectSelectedInTree.ParentGUID
                Else
                    ParentKey = General.MainExplorer.ObjectSelectedInTree.ObjectGUID
                End If
                MoneyObj.ObjectGUID = Objects.ObjectKey.NewGuid(ParentKey.Database)
                MoneyObj.ParentGUID = ParentKey
                MoneyObj.Name = Sale.Text
                MoneyObj.Type = Objects.MoneyType
                MoneyObj.Element("Cost") = Sale.Text
                MoneyObj.Element("Weight") = Rules.Formatting.FormatPounds(SaleMoney.Weight)
                MoneyObj.Save()
            End If

            'save, refresh explorer and close
            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
            WindowManager.SetDirty(Character.CharacterObject.ObjectGUID)
            General.MainExplorer.RefreshPanel()
            If MoneyObj.ObjectGUID.IsNotEmpty Then General.MainExplorer.SelectItemByGuid(MoneyObj.ObjectGUID)
            Me.DialogResult = DialogResult.OK : Me.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            General.SetNormalCursor()
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'get list of items - recursive 
    Private Sub GetSaleItems(ByVal Items As Objects.ObjectDataCollection)
        Try
            If Items Is Nothing Then Exit Sub

            For Each Item As Objects.ObjectData In Items
                SaleItems.Add(Item)
                BaseMoney.AddMoney(Item.Element("Cost"))
                GetSaleItems(Item.Children)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update sale value
    Private Sub UpdateSaleValue()
        Try
            SaleMoney = New Money

            If PercentageRadio.Checked Then
                Dim BaseCopper As Integer = BaseMoney.InCopper
                Dim SaleCopper As Integer = CType(BaseCopper * CType(Percentage.EditValue, Decimal) / 100, Integer)
                SaleMoney.Copper = SaleCopper
            Else
                SaleMoney.Copper = Coins.Money.InCopper
            End If

            'convert copper 
            If Gold.Checked Then
                SaleMoney = SaleMoney.InGold
            Else
                SaleMoney = SaleMoney.InPlatinum
            End If

            Sale.Text = SaleMoney.DisplayString

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handlers"

    Private Sub PercentageRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercentageRadio.CheckedChanged
        Try
            If PercentageRadio.Checked Then
                Percentage.Properties.Enabled = True
                UpdateSaleValue()
            Else
                Percentage.Properties.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Percentage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Percentage.EditValueChanged
        Try
            UpdateSaleValue()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Specific_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Specific.CheckedChanged
        Try
            If Specific.Checked Then
                Coins.Enabled = True
                UpdateSaleValue()
            Else
                Coins.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Coins_ValueChanged() Handles Coins.ValueChanged
        Try
            UpdateSaleValue()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Gold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gold.CheckedChanged
        Try
            UpdateSaleValue()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Platinum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Platinum.CheckedChanged
        Try
            UpdateSaleValue()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class


