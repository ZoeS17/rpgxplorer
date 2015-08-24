Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class ShoppingCart

        'this class handles everything to do with the shopping cart

#Region "Member Variables"

        Private mCharObj, mCartObj As Objects.ObjectData
        Private mCart As Objects.ObjectDataCollection
        Private mSize As String
        'Private mFree As Boolean

#End Region

#Region "Properties"

        'the cart
        Public ReadOnly Property Cart() As Objects.ObjectDataCollection
            Get
                Return mCart
            End Get
        End Property

        'the character
        Public ReadOnly Property Character() As Objects.ObjectData
            Get
                Return mCharObj
            End Get
        End Property

        'the cart object
        Public ReadOnly Property CartObject() As Objects.ObjectData
            Get
                Return mCartObj
            End Get
        End Property

        'size
        Public Property BuySize() As String
            Get
                Return mSize
            End Get
            Set(ByVal Value As String)
                mSize = Value
            End Set
        End Property

#End Region

        'constructor
        Public Sub New(ByVal CharObj As Objects.ObjectData)
            Try
                mCharObj = CharObj
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load
        Public Sub Load()
            Try
                mCartObj = mCharObj.FirstChildOfType(Objects.ShoppingCartType)

                'initialise the cart
                If mCartObj.IsEmpty Then
                    mCartObj.Name = "Shopping Cart"
                    mCartObj.ObjectGUID = Objects.ObjectKey.NewGuid(mCharObj.ObjectGUID.Database)
                    mCartObj.Type = Objects.ShoppingCartType
                    mCartObj.ParentGUID = mCharObj.ObjectGUID
                    'mCartObj.FKElement("Character", mCharObj.Name, "Name", mCharObj.ObjectGUID)
                    mCart = New Objects.ObjectDataCollection
                Else
                    mCart = mCartObj.ChildrenOfType(Objects.ItemType)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save
        Public Sub Save()
            Try
                mCartObj.Save()
                mCart.Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'the total weight of items in the shopping cart
        Public Function Weight() As Decimal
            Try
                Weight = 0
                For Each Item As Objects.ObjectData In mCart
                    Weight += New Decimal(CType(Item.Element("Weight").Replace(" lb.", ""), Double))
                Next
                Return Weight
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'the total cost of items in the cart
        Public Function Cost() As Money
            Try
                Cost = New Money
                For Each Item As Objects.ObjectData In mCart
                    Cost.AddMoney(New Money(Item.Element("Cost")))
                Next
                Return Cost.InGold
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'convert the definition into an inventory item
        Private Function ConvertToInventoryItem(ByVal Definition As Objects.ObjectData, Optional ByVal Masterwork As Boolean = False, Optional ByVal Enhancement As Integer = 0) As Objects.ObjectData
            Try
                Dim Item As New Objects.ObjectData
                Dim Cost As Money
                Dim Weight As Double
                Dim BaneKey As Objects.ObjectKey

                'select bane focus if any
                Select Case Definition.Type
                    Case Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType, Objects.PsionicWeaponDefinitionType, Objects.PsionicAmmoDefinitionType
                        If WeaponProperties.HasBaneCondition(Definition) Then
                            BaneKey = CommonLogic.SelectBaneFocus(Definition)
                            If BaneKey.Equals(Objects.ObjectKey.Empty) Then
                                General.ShowInfoDialog("No bane selected. Item will not be added to cart.")
                                Return Nothing
                            End If
                        End If
                End Select

                Item.Name = Definition.Name
                Item.ObjectGUID = Objects.ObjectKey.NewGuid(mCartObj.ObjectGUID.Database)
                Item.Type = Objects.ItemType
                Item.ParentGUID = mCartObj.ObjectGUID

                Select Case Definition.Type
                    Case Objects.PotionDefinitionType
                        Item.HTMLGUID = Definition.GetFKGuid("BaseSpell")
                    Case Objects.PotionDefinitionType
                        Item.HTMLGUID = Definition.GetFKGuid("BasePower")
                    Case Objects.WandDefinitionType
                        Item.HTMLGUID = Definition.GetFKGuid("Spell")
                    Case Objects.PsionicDorjeDefinitionType
                        Item.HTMLGUID = Definition.GetFKGuid("Power")
                    Case Else
                        Item.HTMLGUID = Definition.ObjectGUID
                End Select

                Item.Element("ItemType") = Definition.Type
                Item.FKElement("Item", Definition.Name, "Name", Definition.ObjectGUID)

                If Masterwork Or Enhancement > 0 Then
                    If mCharObj.GetFKObject("Race").Element("Nonhumanoid") = "Yes" Then
                        Cost = Items.EnhancedPrice(Definition, mSize, Enhancement, False)
                    Else
                        Cost = Items.EnhancedPrice(Definition, mSize, Enhancement)
                    End If
                Else
                    If mCharObj.GetFKObject("Race").Element("Nonhumanoid") = "Yes" Then
                        Cost = Items.ItemCost(Definition, mSize, False)
                    Else
                        Cost = Items.ItemCost(Definition, mSize)
                    End If
                End If

                Item.Element("BaseCost") = Cost.DisplayString
                Item.Element("Cost") = Cost.DisplayString
                Item.Element("Quantity") = "1"
                Item.Element("Size") = mSize
                If Items.DisplaySize(Definition) Then
                    Item.Element("DisplaySize") = mSize
                Else
                    Item.Element("DisplaySize") = ""
                End If

                'calculate weight - take into account for special materials
                Weight = CType(Items.ItemWeight(Definition, mSize), Double)

                Select Case Definition.Type
                    Case Objects.SpecificArmorDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType, Objects.PsionicAmmoDefinitionType, Objects.PsionicArmorDefinitionType, Objects.PsionicWeaponDefinitionType
                        If Definition.Element("Double") = "Yes" Then

                            'split into two parts - treat seperately
                            Dim PrimaryMaterial, SecondaryMaterial As Rules.SpecialMaterial
                            Dim PrimaryWeight, SecondaryWeight As Double
                            PrimaryWeight = Weight * 0.5 : SecondaryWeight = PrimaryWeight

                            PrimaryMaterial = CType(Rules.SpecialMaterial.Materials(Definition.GetFKGuid("Material")), Rules.SpecialMaterial)
                            SecondaryMaterial = CType(Rules.SpecialMaterial.Materials(Definition.GetFKGuid("DMaterial")), Rules.SpecialMaterial)

                            If Not PrimaryMaterial Is Nothing Then
                                PrimaryWeight = PrimaryWeight * PrimaryMaterial.WeightAdjustmet
                            End If

                            If Not SecondaryMaterial Is Nothing Then
                                SecondaryWeight = SecondaryWeight * SecondaryMaterial.WeightAdjustmet
                            End If
                            Weight = PrimaryWeight + SecondaryWeight
                        Else
                            Dim Material As Rules.SpecialMaterial
                            Material = CType(Rules.SpecialMaterial.Materials(Definition.GetFKGuid("Material")), Rules.SpecialMaterial)
                            If Not Material Is Nothing Then
                                Weight = Weight * Material.WeightAdjustmet
                            End If
                        End If

                        Item.Element("BaseWeight") = Formatting.FormatPounds(Weight)

                    Case Else
                        Item.Element("BaseWeight") = Formatting.FormatPounds(Weight)
                End Select

                Item.Element("Weight") = Item.Element("BaseWeight")

                If Masterwork Then
                    Item.Element("Masterwork") = "Yes"
                    If Enhancement > 0 Then
                        Item.Element("EnhancementBonus") = "+" & Enhancement.ToString
                        Item.Name &= " +" & Enhancement.ToString
                        If Definition.Element("Double") = "Yes" Then Item.Name &= "/+" & Enhancement.ToString
                    Else
                        Item.Element("EnhancementBonus") = ""
                        Item.Name &= ", Masterwork"
                    End If

                Else
                    Item.Element("Masterwork") = ""
                    Item.Element("EnhancementBonus") = ""
                End If

                'can modifiers be activated/deactivated
                Select Case Definition.Type
                    Case Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.StaffDefinitionType, Objects.RodDefinitionType, Objects.RingDefinitionType, Objects.UniversalItemDefinitionType, Objects.PsionicArtifactDefinitionType, Objects.PsionicPsicrownDefinitionType
                        Item.Element("Active") = "Yes"
                    Case Objects.ItemDefinitionType
                        If Definition.HasChildren Then Item.Element("Active") = "Yes"
                    Case Else
                        Item.Element("Active") = ""
                End Select

                'charges
                Select Case Definition.Type
                    Case Objects.ItemDefinitionType, Objects.UniversalItemDefinitionType
                        Item.Element("Charges") = Definition.Element("DefaultUses")
                    Case Objects.WandDefinitionType, Objects.StaffDefinitionType, Objects.PsionicDorjeDefinitionType
                        Item.Element("Charges") = "50"
                    Case Objects.PsionicPsicrownDefinitionType
                        Item.Element("Charges") = Definition.Element("PowerPoints")
                    Case Else
                        Item.Element("Charges") = ""
                End Select

                If Not BaneKey.Equals(Objects.ObjectKey.Empty) Then
                    Dim Bane As New Objects.ObjectData
                    Bane.Load(BaneKey)
                    Item.FKElement("Bane", Bane.Name, "Name", BaneKey)
                    Item.Name &= " (" & Bane.Name & ")"
                End If

                Item.ImageFilename = Definition.ImageFilename
                'Item.LoadRecordFKs()

                Return Item

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add to cart
        Public Sub AddToCart(ByVal Item As Objects.ObjectData, Optional ByVal Masterwork As Boolean = False, Optional ByVal Enhancement As Integer = 0)
            Try
                Dim InventoryItem As Objects.ObjectData = ConvertToInventoryItem(Item, Masterwork, Enhancement)
                If Not InventoryItem.IsEmpty Then
                    AddInventoryItemToCart(InventoryItem)
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'add a premade inventory item to the cart
        Public Sub AddInventoryItemToCart(ByVal InventoryItem As Objects.ObjectData)
            Try
                mCart.Add(InventoryItem)
                Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'add to cart
        Public Sub AddManyToCart(ByVal Items As Objects.ObjectDataCollection)
            Try
                For Each Item As Objects.ObjectData In Items
                    If Item.Element("BaseItem") = "" Then AddToCart(Item)
                Next
                Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove item from cart
        Public Sub RemoveFromCart(ByVal ItemGuid As Objects.ObjectKey)
            Try
                Cart.Item(ItemGuid).Delete()
                Cart.Remove(ItemGuid)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'clear the cart
        Public Sub EmptyCart()
            Try
                For Each Item As Objects.ObjectData In Cart
                    Item.Delete()
                Next
                Cart.Clear()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'get quantity
        Public Function GetQuantity(ByVal ItemGuid As Objects.ObjectKey) As Integer
            Dim Item As Objects.ObjectData

            Try
                Item = mCart.Item(ItemGuid)
                Return Item.ElementAsInteger("Quantity")
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'check to see if an item is a container
        Public Function IsContainer(ByVal ItemGuid As Objects.ObjectKey) As Boolean
            Dim BaseItem As New Objects.ObjectData

            BaseItem.Load(mCart.Item(ItemGuid).GetFKGuid("Item"))
            If BaseItem.Element("IsContainer") = "Yes" Then Return True Else Return False
        End Function

        'adjust quantity of an inventory item
        Public Function AdjustQuantity(ByVal ItemGuid As Objects.ObjectKey, ByVal Quantity As Integer) As Objects.ObjectData
            Dim Cost As Money
            Dim Weight As Double

            Dim Item As Objects.ObjectData = mCart.Item(ItemGuid)
            Cost = New Money(Item.Element("BaseCost"))
            Cost.Multiply(CType(Quantity, Double))

            Weight = Double.Parse(Item.Element("BaseWeight").Replace(" lb.", ""))
            Weight *= Quantity

            Item.Element("Cost") = Cost.DisplayString
            Item.Element("Quantity") = Quantity.ToString
            Item.Element("Weight") = Rules.Formatting.FormatPounds(Weight)
            Return Item
        End Function

        'load an individual inventory item into a list view item
        Public Sub MapInventoryItemToListViewItem(ByVal Item As Objects.ObjectData, ByVal ListViewItem As ListViewItem)
            ListViewItem.ImageIndex = Images.SmallImageIndex(Item.ImageFilename)
            ListViewItem.Tag = Item.ObjectGUID
            ListViewItem.SubItems.Clear()
            ListViewItem.Text = Item.Name
            ListViewItem.SubItems.Add(Item.Element("Cost"))
            ListViewItem.SubItems.Add(Item.Element("Weight"))
            ListViewItem.SubItems.Add(Objects.ObjectTypes.Item(Item.Element("ItemType")).Friendly)
            ListViewItem.SubItems.Add(Item.Element("Quantity"))
            ListViewItem.SubItems.Add(Item.Element("DisplaySize"))
        End Sub

    End Class

End Namespace
