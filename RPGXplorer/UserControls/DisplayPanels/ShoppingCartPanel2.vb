Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports DevExpress.XtraBars

Public Class ShoppingCartPanel2

    'member vars
    Private IsLoading As Boolean = False
    Private _Cart As Rules.ShoppingCart
    Private CharacterKey As Objects.ObjectKey

    'indexes
    Private CharacterIndex As DataListItem()

#Region "Properties"

    Public Property Cart() As Rules.ShoppingCart
        Get
            Return _Cart
        End Get
        Set(ByVal Value As Rules.ShoppingCart)
            _Cart = Value
        End Set
    End Property

    Public Property CurrentCharacterKey() As Objects.ObjectKey
        Get
            Return CharacterKey
        End Get
        Set(ByVal Value As Objects.ObjectKey)
            CharacterKey = Value
        End Set
    End Property

    Public ReadOnly Property ListView() As ListView
        Get
            Return CartListView
        End Get
    End Property

    Public Shadows ReadOnly Property Focused() As Boolean
        Get
            For Each Control As Control In Me.Controls
                If Control.Focused Then Return True
            Next

            Return False
        End Get
    End Property

#End Region

    'init
    Public Sub Init()
        Try
            IsLoading = True

            'load the indexes and dropdowns
            'load the indexes and dropdowns
            Dim CharIndex As DataListItem()
            Dim MonsterIndex As DataListItem()

            CharIndex = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.CharacterType)
            MonsterIndex = Rules.Index.DataList(Xml.DBTypes.Monsters, Objects.MonsterType)

            ReDim CharacterIndex((CharIndex.Length + MonsterIndex.Length) - 1)

            Array.Copy(CharIndex, 0, CharacterIndex, 0, CharIndex.Length)
            Array.Copy(MonsterIndex, 0, CharacterIndex, CharIndex.Length, MonsterIndex.Length)

            'CharacterIndex = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.CharacterType)

            Characters.Properties.Items.Clear()
            Characters.Properties.Items.AddRange(CharacterIndex)
            Characters.SelectedIndex = -1
            BuySize.Properties.Items.Clear()
            BuySize.Properties.Items.AddRange(Rules.Lists.Sizes)
            BuySize.SelectedIndex = -1
            CartListView.Items.Clear()
            Weight.Text = ""
            Funds.Text = ""
            Spent.Text = ""

            'init list view
            CartListView.View = View.Details
            CartListView.SmallImageList = Images.SmallImages
            CartListView.LargeImageList = Images.LargeImages
            CartListView.Columns.Clear()
            CartListView.Columns.Add("Name", 150, HorizontalAlignment.Left)
            CartListView.Columns.Add("Cost", 75, HorizontalAlignment.Center)
            CartListView.Columns.Add("Weight", 65, HorizontalAlignment.Center)
            CartListView.Columns.Add("Type", 75, HorizontalAlignment.Left)
            CartListView.Columns.Add("Qty", 50, HorizontalAlignment.Center)
            CartListView.Columns.Add("Size", 65, HorizontalAlignment.Center)

            'if no existing cart then get the current character
            If CharacterKey.IsEmpty Then
                Dim Character As Rules.Character = CharacterManager.CurrentCharacter
                If Not Character Is Nothing Then CharacterKey = Character.CharacterObject.ObjectGUID
            End If

            InitCharacter()
            IsLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'init for a selected character
    Private Sub InitCharacter()
        Try
            'get inventory and cart
            If CharacterKey.IsNotEmpty Then
                Dim Character As Rules.Character = CharacterManager.GetCharacter(CharacterKey)
                Characters.SelectedIndex = Rules.Index.GetGuidIndex(CharacterIndex, Character.CharacterObject.ObjectGUID)
                General.Config.Element("CurrentCart") = Character.CharacterObject.ObjectGUID.ToString
                _Cart = New Rules.ShoppingCart(Character.CharacterObject)
                _Cart.Load()
                _Cart.BuySize = Character.Size
                BuySize.Text = Character.Size
                BuySize.Enabled = True
                Funds.Text = Character.Inventory.Funds.DisplayString
                Purchase.Enabled = True
                Free.Enabled = True
                PutBack.Enabled = True
                Clear.Enabled = True
            Else
                _Cart = Nothing
                Quantity.EditValue = 1
                Quantity.Enabled = False
                BuySize.Text = ""
                BuySize.Enabled = False
                Purchase.Enabled = False
                Free.Enabled = False
                PutBack.Enabled = False
                Clear.Enabled = False
                Exit Sub
            End If

            'load the existing cart
            UpdateDisplays()
            LoadListView()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'switch to another character's cart
    Public Sub SwitchCharacter(ByVal CharKey As Objects.ObjectKey)
        If CharKey.Equals(CurrentCharacterKey) Then Exit Sub
        CurrentCharacterKey = CharKey
        If Not _Cart Is Nothing Then _Cart.Save()
        Quantity.Properties.Enabled = False
        Quantity.EditValue = 1
        InitCharacter()
    End Sub

    'is a character selected?
    Public Function NoCharacterSelected() As Boolean
        Return CharacterKey.IsEmpty
    End Function

    'reset the cart
    Public Sub ResetCart()
        _Cart = Nothing
        CharacterKey = Objects.ObjectKey.Empty
    End Sub

    'load list view item
    Public Sub LoadListView()
        Dim ListViewItem As ListViewItem

        Try
            CartListView.Items.Clear()
            CartListView.BeginUpdate()
            For Each Item As Objects.ObjectData In _Cart.Cart
                ListViewItem = New ListViewItem
                _Cart.MapInventoryItemToListViewItem(Item, ListViewItem)
                CartListView.Items.Add(ListViewItem)
            Next

            CartListView.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update displays
    Public Sub UpdateDisplays()
        Dim Character As Rules.Character = CharacterManager.GetCharacter(CharacterKey)

        Funds.Text = Character.Inventory.Funds.DisplayString
        Spent.Text = _Cart.Cost.DisplayString

        Dim TotalWeight As Double = Character.Inventory.Weight + _Cart.Weight
        Dim Load As String = Rules.Encumberance.CurrentLoad(Character.Size, Character.Inventory.STR, TotalWeight, Character.Quadruped)
        Weight.Text = Rules.Formatting.FormatPounds(TotalWeight) & " (" & Load & ")"

        'weight
        Select Case Load
            Case "Light"
                Weight.BackColor = General.BackColourPositive
            Case "Medium"
                Weight.BackColor = General.BackColourPaleYellow
            Case "Heavy"
                Weight.BackColor = General.BackColourNegative
            Case "Too Heavy"
                Weight.BackColor = Color.Red
        End Select
    End Sub

    'called from delete objects if cart has focus
    Public Sub DeleteKeyPutBack()
        PutBack_Click(Nothing, Nothing)
    End Sub

    'external refresh
    Public Sub ExternalRefresh()
        Try
            IsLoading = True

            'update the character dropdown
            Dim CharIndex As DataListItem()
            Dim MonsterIndex As DataListItem()

            CharIndex = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.CharacterType)
            MonsterIndex = Rules.Index.DataList(Xml.DBTypes.Monsters, Objects.MonsterType)

            ReDim CharacterIndex((CharIndex.Length + MonsterIndex.Length) - 1)

            Array.Copy(CharIndex, 0, CharacterIndex, 0, CharIndex.Length)
            Array.Copy(MonsterIndex, 0, CharacterIndex, CharIndex.Length, MonsterIndex.Length)

            'CharacterIndex = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.CharacterType)
            Characters.Properties.Items.Clear()
            Characters.Properties.Items.AddRange(CharacterIndex)
            Characters.SelectedIndex = -1

            'clear the settings
            CartListView.Items.Clear()
            Weight.Text = ""
            Funds.Text = ""
            Spent.Text = ""

            'update the select character info
            InitCharacter()

            IsLoading = False

        Catch ex As Exception
            IsLoading = False
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handlers"

    Private Sub Characters_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Characters.SelectedIndexChanged
        Try
            If IsLoading Then Exit Sub
            SwitchCharacter(CType(Characters.SelectedItem, DataListItem).ObjectGUID)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub BuySize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuySize.SelectedIndexChanged
        If IsLoading Then Exit Sub
        _Cart.BuySize = BuySize.Text
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Try
            If _Cart Is Nothing Then Exit Sub
            _Cart.EmptyCart()
            Quantity.Properties.Enabled = False
            Quantity.EditValue = 1
            UpdateDisplays()
            CartListView.Items.Clear()
            _Cart.Save()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub PutBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutBack.Click
        Try
            If _Cart Is Nothing Then Exit Sub
            If CartListView.SelectedItems.Count = 0 Then
                General.ShowInfoDialog("Please select items to put back.")
            Else
                For Each Item As ListViewItem In CartListView.SelectedItems
                    _Cart.RemoveFromCart(CType(Item.Tag, Objects.ObjectKey))
                Next
                Quantity.Properties.Enabled = False
                Quantity.EditValue = 1
                UpdateDisplays()
                LoadListView()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Purchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase.Click
        If _Cart Is Nothing Then Exit Sub

        Dim Character As Rules.Character = CharacterManager.GetCharacter(CharacterKey)

        If _Cart.Cost.InCopper > Character.Inventory.Funds.InCopper And Free.Checked = False Then
            General.ShowInfoDialog("Insufficient Funds.")
        Else
            General.MainExplorer.Undo.UndoRecord()
            If Not Free.Checked Then Character.Inventory.RemoveMoneySpent(_Cart.Cost)
            Character.Inventory.AddCartItems(_Cart.Cart)
            SetWaitCursor(MainExplorer.Form)
            CharacterManager.SetDirty(CharacterKey)
            Clear_Click(Nothing, Nothing)
            _Cart.Save()
            General.MainExplorer.RefreshPanel()
            SetNormalCursor(MainExplorer.Form)

        End If
    End Sub

    Private Sub Icons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Icons.Click
        Try
            CartListView.View = View.LargeIcon
            Quantity.Properties.Enabled = False
            Quantity.EditValue = 1
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Details.Click
        Try
            CartListView.View = View.Details
            Quantity.Properties.Enabled = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub CartListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CartListView.SelectedIndexChanged
        If IsLoading Then Exit Sub

        'only enable quantity if single item and not container or magic item
        If CartListView.SelectedItems.Count = 1 Then
            Dim ItemKey As Objects.ObjectKey = CType(CartListView.SelectedItems(0).Tag, Objects.ObjectKey)
            Dim Item, BaseItem As Objects.ObjectData
            Item = _Cart.Cart.Item(ItemKey)
            BaseItem = Item.GetFKObject("Item")

            Dim Qty As Boolean = False

            Select Case BaseItem.Type
                Case Objects.ItemDefinitionType
                    If Not Item.GetFKObject("Item").Element("IsContainer") = "Yes" Then Qty = True
                Case Objects.PotionDefinitionType, Objects.MagicAmmoDefinitionType, Objects.AmmoDefinitionType, Objects.WeaponDefinitionType
                    Qty = True
            End Select

            If Qty Then
                Quantity.Properties.Enabled = True
                Quantity.EditValue = _Cart.GetQuantity(ItemKey)
                Exit Sub
            End If
        End If
        Quantity.Properties.Enabled = False
        Quantity.EditValue = 1
    End Sub

    Private Sub Quantity_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quantity.EditValueChanged
        Dim CartItem As Objects.ObjectData

        Try
            If IsLoading Then Exit Sub
            If CartListView.Items.Count = 0 Or CartListView.SelectedItems.Count = 0 Or Quantity.Properties.Enabled = False Then Exit Sub
            CartItem = _Cart.AdjustQuantity(CType(CartListView.SelectedItems(0).Tag, Objects.ObjectKey), CType(Quantity.EditValue, Integer))
            CartListView.BeginUpdate()
            _Cart.MapInventoryItemToListViewItem(CartItem, CartListView.SelectedItems(0))
            CartListView.EndUpdate()
            UpdateDisplays()
            _Cart.Save()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ShoppingCartPanel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        Try
            Quantity.Properties.Enabled = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ShoppingCartPanel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Try
            Quantity.Properties.Enabled = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Paint Events"

    Private Sub ShoppingCartPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If Me.Width > 0 And Me.Height > 0 Then
            Dim g As Graphics = e.Graphics
            Dim rect As New Rectangle(0, 0, 250, Me.Height)
            Dim gradbrush As New Drawing2D.LinearGradientBrush(rect, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)
            g.FillRectangle(gradbrush, rect)

            'rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            'e.Graphics.DrawRectangle(New System.Drawing.Pen(General.StyleColorBannerColor2, 1), rect)
        End If
    End Sub

    Private Sub ShoppingCartPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

#End Region

End Class
