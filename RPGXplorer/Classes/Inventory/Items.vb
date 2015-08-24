Option Explicit On 
Option Strict On

Namespace Rules

    Public Class Items

        'this class is used to handle items

        'get the price of this item
        Public Shared Function ItemCost(ByVal Item As Objects.ObjectData, Optional ByVal Size As String = "", Optional ByVal Humanoid As Boolean = True) As Money
            Dim retItemCost As Money = Nothing
            Dim F, D, T, S, M, L, H, G, C As Double
            Dim BaseItem As Objects.ObjectData
            Dim EnhancementCost, BaseCost As Money

            Try
                EnhancementCost = New Money

                'get the base item cost
                Select Case Item.Type
                    Case Objects.PotionDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))
                    Case Objects.RingDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))
                    Case Objects.RodDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))
                    Case Objects.StaffDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))
                    Case Objects.ScrollDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))
                    Case Objects.WandDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))
                    Case Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                        retItemCost = New Money(Item.Element("Cost"))
                        If Item.Element("Masterwork") = "Yes" Then
                            BaseCost = New Money(Item.Element("Cost"))
                            If BaseCost.InCopper > 15000 Then
                                EnhancementCost = New Money("150gp")
                                retItemCost.RemoveMoney(EnhancementCost)
                            End If
                        End If

                    Case Objects.AmmoDefinitionType
                        retItemCost = New Money(Item.Element("Cost"))
                        If Item.Element("Masterwork") = "Yes" Then
                            BaseCost = New Money(Item.Element("Cost"))
                            If BaseCost.InCopper > 600 Then
                                EnhancementCost = New Money("6gp")
                                retItemCost.RemoveMoney(EnhancementCost)
                            End If
                        End If

                    Case Objects.WeaponDefinitionType
                        retItemCost = New Money(Item.Element("Cost"))
                        If Item.Element("Masterwork") = "Yes" Then
                            BaseCost = New Money(Item.Element("Cost"))
                            If Item.Element("Double") = "Yes" Then
                                If BaseCost.InCopper > 60000 Then EnhancementCost = New Money("600gp")
                            Else
                                If BaseCost.InCopper > 30000 Then EnhancementCost = New Money("300gp")
                            End If
                            retItemCost.RemoveMoney(EnhancementCost)
                        End If

                    Case Objects.MagicAmmoDefinitionType, Objects.PsionicAmmoDefinitionType

                        'return the set cost if nothing is no size modification
                        If Size = "" OrElse Size = "Medium" Then
                            Return MarketPrice(New Money(Item.Element("MarketPrice")))
                        End If

                        BaseItem = Item.GetFKObject("Weapon")
                        Dim MaterialKey As Objects.ObjectKey = Item.GetFKGuid("Material")
                        Dim Material As Rules.SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(MaterialKey), Rules.SpecialMaterial)

                        If Not Material Is Nothing Then
                            retItemCost = New Money(Item.Element("MarketPrice"))
                            Dim MediumCost As Money = Material.CalculateNonEnhancedPrice(BaseItem, "Medium", True, , , Humanoid)
                            Dim SizedCost As Money = Material.CalculateNonEnhancedPrice(BaseItem, Size, True, , , Humanoid)
                            Dim PriceDifference As New Money

                            If SizedCost.GoldDecimal > MediumCost.GoldDecimal Then
                                PriceDifference.AddMoney(SizedCost)
                                PriceDifference.RemoveMoney(MediumCost)
                                retItemCost.AddMoney(PriceDifference)
                                Return MarketPrice(retItemCost)
                            Else
                                PriceDifference.AddMoney(MediumCost)
                                PriceDifference.RemoveMoney(SizedCost)
                                retItemCost.RemoveMoney(PriceDifference)
                                Return MarketPrice(retItemCost)
                            End If

                        Else
                            EnhancementCost = New Money(Item.Element("MarketPrice"))
                            EnhancementCost.RemoveMoney(BaseItem.Element("Cost"))
                            If BaseItem.Element("Masterwork") = "Yes" Then
                                BaseCost = New Money(BaseItem.Element("Cost"))
                                If BaseCost.InCopper > 600 Then EnhancementCost.AddMoney("6gp")
                            End If
                            retItemCost = New Money(Item.Element("MarketPrice"))
                            retItemCost.RemoveMoney(EnhancementCost)
                        End If

                    Case Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType

                        'return the set cost if nothing is no size modification
                        If (Size = "" OrElse Size = "Medium") AndAlso Humanoid Then
                            Return MarketPrice(New Money(Item.Element("MarketPrice")))
                        End If

                        BaseItem = Item.GetFKObject("Armor")
                        Dim MaterialKey As Objects.ObjectKey = Item.GetFKGuid("Material")
                        Dim Material As Rules.SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(MaterialKey), Rules.SpecialMaterial)

                        If Not Material Is Nothing Then

                            retItemCost = New Money(Item.Element("MarketPrice"))
                            Dim MediumCost As Money = Material.CalculateNonEnhancedPrice(BaseItem, "Medium", True, , , Humanoid)
                            Dim SizedCost As Money = Material.CalculateNonEnhancedPrice(BaseItem, Size, True, , , Humanoid)
                            Dim PriceDifference As New Money

                            If SizedCost.GoldDecimal > MediumCost.GoldDecimal Then
                                PriceDifference.AddMoney(SizedCost)
                                PriceDifference.RemoveMoney(MediumCost)
                                retItemCost.AddMoney(PriceDifference)
                                Return MarketPrice(retItemCost)
                            Else
                                PriceDifference.AddMoney(MediumCost)
                                PriceDifference.RemoveMoney(SizedCost)
                                retItemCost.RemoveMoney(PriceDifference)
                                Return MarketPrice(retItemCost)
                            End If

                        Else
                            EnhancementCost = New Money(Item.Element("MarketPrice"))
                            EnhancementCost.RemoveMoney(BaseItem.Element("Cost"))
                            If BaseItem.Element("Masterwork") = "Yes" Then
                                BaseCost = New Money(BaseItem.Element("Cost"))
                                If BaseCost.InCopper > 15000 Then EnhancementCost.AddMoney("150gp")
                            End If
                            retItemCost = New Money(Item.Element("MarketPrice"))
                            retItemCost.RemoveMoney(EnhancementCost)
                        End If

                    Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                        'return the set cost if nothing is no size modification
                        If Size = "" OrElse Size = "Medium" Then
                            Return MarketPrice(New Money(Item.Element("MarketPrice")))
                        End If

                        BaseItem = Item.GetFKObject("Weapon")
                        Dim PMaterialKey As Objects.ObjectKey = Item.GetFKGuid("Material")
                        Dim PMaterial As Rules.SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(PMaterialKey), Rules.SpecialMaterial)

                        Dim SMaterialKey As Objects.ObjectKey = Item.GetFKGuid("DMaterial")
                        Dim SMaterial As Rules.SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(SMaterialKey), Rules.SpecialMaterial)

                        If (Not PMaterial Is Nothing) OrElse (Not SMaterial Is Nothing) Then

                            retItemCost = New Money(Item.Element("MarketPrice"))
                            Dim MediumCost, SizedCost As Money
                            If Not PMaterial Is Nothing Then
                                MediumCost = PMaterial.CalculateNonEnhancedPrice(BaseItem, "Medium", True, False, SMaterial, Humanoid)
                                SizedCost = PMaterial.CalculateNonEnhancedPrice(BaseItem, Size, True, False, SMaterial, Humanoid)
                            Else
                                MediumCost = SMaterial.CalculateNonEnhancedPrice(BaseItem, "Medium", True, True, , Humanoid)
                                SizedCost = SMaterial.CalculateNonEnhancedPrice(BaseItem, Size, True, True, , Humanoid)
                            End If

                            Dim PriceDifference As New Money

                            If SizedCost.GoldDecimal > MediumCost.GoldDecimal Then
                                PriceDifference.AddMoney(SizedCost)
                                PriceDifference.RemoveMoney(MediumCost)
                                retItemCost.AddMoney(PriceDifference)
                                Return MarketPrice(retItemCost)
                            Else
                                PriceDifference.AddMoney(MediumCost)
                                PriceDifference.RemoveMoney(SizedCost)
                                retItemCost.RemoveMoney(PriceDifference)
                                Return MarketPrice(retItemCost)
                            End If
                        Else
                            EnhancementCost = New Money(Item.Element("MarketPrice"))
                            EnhancementCost.RemoveMoney(BaseItem.Element("Cost"))
                            If BaseItem.Element("Masterwork") = "Yes" Then
                                BaseCost = New Money(BaseItem.Element("Cost"))
                                If BaseItem.Element("Double") = "Yes" Then
                                    If BaseCost.InCopper > 60000 Then EnhancementCost.AddMoney("600gp")
                                Else
                                    If BaseCost.InCopper > 30000 Then EnhancementCost.AddMoney("300gp")
                                End If
                            End If
                            retItemCost = New Money(Item.Element("MarketPrice"))
                            retItemCost.RemoveMoney(EnhancementCost)
                        End If

                    Case Objects.ItemDefinitionType
                        retItemCost = New Money(Item.Element("Cost"))

                    Case Objects.PsionicTattooDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                    Case Objects.PsionicArtifactDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                    Case Objects.PsionicPsicrownDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                    Case Objects.PsionicPowerStoneDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                    Case Objects.PsionicDorjeDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                    Case Objects.UniversalItemDefinitionType
                        retItemCost = New Money(Item.Element("MarketPrice"))

                End Select

                'adjust the cost for size
                F = 1 : D = 1 : T = 1 : S = 1 : M = 1 : L = 1 : H = 1 : G = 1 : C = 1

                Select Case Item.Type

                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType, Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType
                        If Humanoid Then
                            F = 0.5 : D = 0.5 : T = 0.5
                            S = 1 : M = 1 : L = 2
                            H = 4 : G = 8 : C = 16
                        Else
                            F = 1 : D = 1 : T = 1
                            S = 2 : M = 2 : L = 4
                            H = 8 : G = 16 : C = 32
                        End If

                    Case Objects.AmmoDefinitionType, Objects.WeaponDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType, Objects.PsionicAmmoDefinitionType, Objects.PsionicWeaponDefinitionType
                        F = 0.5 : D = 0.5 : T = 0.5
                        S = 1 : M = 1 : L = 2
                        H = 4 : G = 8 : C = 16

                    Case Objects.ItemDefinitionType
                        If Item.Element("AdjustForSize") = "Yes" Then
                            'shortcuts out of the function - saves having to look up all the size modifiers

                            Dim Factor As Double
                            Select Case Size
                                Case "Fine"
                                    Factor = Rules.Size.Size("Fine").ItemCostModifier
                                Case "Diminutive"
                                    Factor = Rules.Size.Size("Diminutive").ItemCostModifier
                                Case "Tiny"
                                    Factor = Rules.Size.Size("Tiny").ItemCostModifier
                                Case "Small"
                                    Factor = Rules.Size.Size("Small").ItemCostModifier
                                Case "Medium"
                                    Factor = Rules.Size.Size("Medium").ItemCostModifier
                                Case "Large"
                                    Factor = Rules.Size.Size("Large").ItemCostModifier
                                Case "Huge"
                                    Factor = Rules.Size.Size("Huge").ItemCostModifier
                                Case "Gargantuan"
                                    Factor = Rules.Size.Size("Gargantuan").ItemCostModifier
                                Case "Colossal"
                                    Factor = Rules.Size.Size("Colossal").ItemCostModifier
                            End Select

                            retItemCost.Multiply(Factor)

                        End If

                        If Not EnhancementCost Is Nothing Then retItemCost.AddMoney(EnhancementCost)

                        Return MarketPrice(retItemCost)

                End Select

                Select Case Size
                    Case "Fine"
                        retItemCost.Multiply(F)
                    Case "Diminutive"
                        retItemCost.Multiply(D)
                    Case "Tiny"
                        retItemCost.Multiply(T)
                    Case "Small"
                        retItemCost.Multiply(S)
                    Case "Medium"
                        retItemCost.Multiply(M)
                    Case "Large"
                        retItemCost.Multiply(L)
                    Case "Huge"
                        retItemCost.Multiply(H)
                    Case "Gargantuan"
                        retItemCost.Multiply(G)
                    Case "Colossal"
                        retItemCost.Multiply(C)
                End Select

                If Not EnhancementCost Is Nothing Then retItemCost.AddMoney(EnhancementCost)

                Return MarketPrice(retItemCost)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add up the prices of all these items
        Public Shared Function TotalPrice(ByVal Items As Objects.ObjectDataCollection, Optional ByVal Size As String = "", Optional ByVal Humanoid As Boolean = True) As Money
            Try
                TotalPrice = New Money

                For Each Item As Objects.ObjectData In Items
                    TotalPrice.AddMoney(ItemCost(Item, Size, Humanoid))
                Next

                Return TotalPrice

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the price of an enhanced item - FROM SPECIFIC ARMOR AND CUSTOM FORM
        Public Shared Function EnhancedPrice(ByVal Item As Objects.ObjectData, ByVal Size As String, ByVal Material As Objects.ObjectKey, Optional ByVal Enhancement As Integer = 0) As Money
            Try
                Select Case Item.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                        Return EnhancedArmorPrice(Item, Size, Material, Enhancement, True)
                    Case Objects.WeaponDefinitionType
                        If Item.Element("Ammo") = "Yes" Then
                            Return EnhancedAmmoPrice(Item, Size, Material, Enhancement)
                        Else
                            Return EnhancedWeaponPrice(Item, Size, Material, Nothing, Enhancement, 0)
                        End If
                    Case Objects.AmmoDefinitionType
                        Return EnhancedAmmoPrice(Item, Size, Material, Enhancement)
                    Case Else
                        Return New Money("0gp")
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the price of an enhanced item - FROM SPECIFIC WEAPON AND CUSTOM FORM
        Public Shared Function EnhancedPrice(ByVal Item As Objects.ObjectData, ByVal Size As String, ByVal PrimaryMaterial As Objects.ObjectKey, ByVal SecondaryMaterial As Objects.ObjectKey, ByVal Enhancement As Integer, ByVal DEnhancement As Integer) As Money
            Try
                Select Case Item.Type
                    Case Objects.WeaponDefinitionType
                        If Item.Element("Ammo") = "Yes" Then
                            Return EnhancedAmmoPrice(Item, Size, PrimaryMaterial, Enhancement)
                        Else
                            Return EnhancedWeaponPrice(Item, Size, PrimaryMaterial, SecondaryMaterial, Enhancement, DEnhancement)
                        End If
                    Case Else
                        Return New Money("0gp")
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the price of an enhanced item
        Public Shared Function EnhancedPrice(ByVal Item As Objects.ObjectData, ByVal Size As String, Optional ByVal Enhancement As Integer = 0, Optional ByVal Humanoid As Boolean = True) As Money
            Try
                Select Case Item.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType

                        Return EnhancedArmorPrice(Item, Size, Nothing, Enhancement, Humanoid)

                    Case Objects.WeaponDefinitionType
                        If Item.Element("Ammo") = "Yes" Then
                            Return EnhancedAmmoPrice(Item, Size, Enhancement)
                        Else
                            If Item.Element("Double") = "Yes" Then
                                Return EnhancedWeaponPrice(Item, Size, Enhancement, Enhancement)
                            Else
                                Return EnhancedWeaponPrice(Item, Size, Enhancement, 0)
                            End If
                        End If
                    Case Objects.AmmoDefinitionType
                        Return EnhancedAmmoPrice(Item, Size, Enhancement)
                    Case Else
                        Return New Money("0gp")
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'determine the price of the enhanced weapon - material version
        Private Shared Function EnhancedWeaponPrice(ByVal Weapon As Objects.ObjectData, ByVal Size As String, ByVal PMaterialKey As Objects.ObjectKey, ByVal SMaterialKey As Objects.ObjectKey, ByVal Enhancement As Integer, ByVal Denhancement As Integer) As Money
            Dim Price As Money
            Dim EnhancementPrice As Money

            'get the materials
            Dim PMaterial As SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(PMaterialKey), SpecialMaterial)
            Dim SMaterial As SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(SMaterialKey), SpecialMaterial)

            Try
                'check for special material
                If (PMaterial Is Nothing) AndAlso (SMaterial Is Nothing) Then

                    'get base weapon
                    Price = New Money(Weapon.Element("Cost"))

                    'adjust for size
                    If Weapon.Element("Masterwork") = "Yes" Then
                        If Weapon.Element("Double") = "Yes" Then
                            Price.RemoveMoney("600gp")
                        Else
                            Price.RemoveMoney("300gp")
                        End If
                    End If

                    Select Case Size
                        Case "Fine", "Diminutive", "Tiny"
                            Price.Multiply(0.5)
                        Case "Large"
                            Price.Multiply(2)
                        Case "Huge"
                            Price.Multiply(4)
                        Case "Gargantuan"
                            Price.Multiply(8)
                        Case "Colossal"
                            Price.Multiply(16)
                    End Select

                    'add cost for masterwork
                    If Weapon.Element("Double") = "Yes" Then
                        Price.AddMoney("600gp")
                    Else
                        Price.AddMoney("300gp")
                    End If

                Else
                    If Not PMaterial Is Nothing Then
                        Price = PMaterial.CalculateNonEnhancedPrice(Weapon, Size, True, False, SMaterial)
                    Else
                        Price = SMaterial.CalculateNonEnhancedPrice(Weapon, Size, True, True)
                    End If
                End If

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'adjust for effective enhancement
                Select Case Enhancement
                    Case 1
                        EnhancementPrice = New Money("2000gp")
                    Case 2
                        EnhancementPrice = New Money("8000gp")
                    Case 3
                        EnhancementPrice = New Money("18000gp")
                    Case 4
                        EnhancementPrice = New Money("32000gp")
                    Case 5
                        EnhancementPrice = New Money("50000gp")
                    Case 6
                        EnhancementPrice = New Money("72000gp")
                    Case 7
                        EnhancementPrice = New Money("98000gp")
                    Case 8
                        EnhancementPrice = New Money("128000gp")
                    Case 9
                        EnhancementPrice = New Money("162000gp")
                    Case 10
                        EnhancementPrice = New Money("200000gp")
                    Case Else
                        EnhancementPrice = Nothing
                End Select

                If Not EnhancementPrice Is Nothing Then
                    Price.AddMoney(EnhancementPrice)
                    If Not PMaterial Is Nothing Then
                        Price.Gold += PMaterial.EnhancementAdjustment
                    End If
                End If

                'adjust for effective enhancement
                Select Case Denhancement
                    Case 1
                        EnhancementPrice = New Money("2000gp")
                    Case 2
                        EnhancementPrice = New Money("8000gp")
                    Case 3
                        EnhancementPrice = New Money("18000gp")
                    Case 4
                        EnhancementPrice = New Money("32000gp")
                    Case 5
                        EnhancementPrice = New Money("50000gp")
                    Case 6
                        EnhancementPrice = New Money("72000gp")
                    Case 7
                        EnhancementPrice = New Money("98000gp")
                    Case 8
                        EnhancementPrice = New Money("128000gp")
                    Case 9
                        EnhancementPrice = New Money("162000gp")
                    Case 10
                        EnhancementPrice = New Money("200000gp")
                    Case Else
                        EnhancementPrice = Nothing
                End Select

                If Not EnhancementPrice Is Nothing Then
                    Price.AddMoney(EnhancementPrice)
                    If Not SMaterial Is Nothing Then
                        Price.Gold += SMaterial.EnhancementAdjustment
                    End If
                End If

                Return MarketPrice(Price)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'determine the price of the enhanced weapon
        Private Shared Function EnhancedWeaponPrice(ByVal Weapon As Objects.ObjectData, ByVal Size As String, ByVal Enhancement As Integer, ByVal Denhancement As Integer) As Money
            Dim Price As Money
            Dim EnhancementPrice As Money

            Try
                'get base weapon
                Price = New Money(Weapon.Element("Cost"))

                'adjust for size
                If Weapon.Element("Masterwork") = "Yes" Then
                    If Weapon.Element("Double") = "Yes" Then
                        Price.RemoveMoney("600gp")
                    Else
                        Price.RemoveMoney("300gp")
                    End If
                End If

                Select Case Size
                    Case "Fine", "Diminutive", "Tiny"
                        Price.Multiply(0.5)
                    Case "Large"
                        Price.Multiply(2)
                    Case "Huge"
                        Price.Multiply(4)
                    Case "Gargantuan"
                        Price.Multiply(8)
                    Case "Colossal"
                        Price.Multiply(16)
                End Select

                'add cost for masterwork
                If Weapon.Element("Double") = "Yes" Then
                    Price.AddMoney("600gp")
                Else
                    Price.AddMoney("300gp")
                End If

                'adjust for effective enhancement
                Select Case Enhancement
                    Case 1
                        EnhancementPrice = New Money("2000gp")
                    Case 2
                        EnhancementPrice = New Money("8000gp")
                    Case 3
                        EnhancementPrice = New Money("18000gp")
                    Case 4
                        EnhancementPrice = New Money("32000gp")
                    Case 5
                        EnhancementPrice = New Money("50000gp")
                    Case 6
                        EnhancementPrice = New Money("72000gp")
                    Case 7
                        EnhancementPrice = New Money("98000gp")
                    Case 8
                        EnhancementPrice = New Money("128000gp")
                    Case 9
                        EnhancementPrice = New Money("162000gp")
                    Case 10
                        EnhancementPrice = New Money("200000gp")
                    Case Else
                        EnhancementPrice = Nothing
                End Select

                If Not EnhancementPrice Is Nothing Then
                    Price.AddMoney(EnhancementPrice)
                End If

                'adjust for effective enhancement
                Select Case Denhancement
                    Case 1
                        EnhancementPrice = New Money("2000gp")
                    Case 2
                        EnhancementPrice = New Money("8000gp")
                    Case 3
                        EnhancementPrice = New Money("18000gp")
                    Case 4
                        EnhancementPrice = New Money("32000gp")
                    Case 5
                        EnhancementPrice = New Money("50000gp")
                    Case 6
                        EnhancementPrice = New Money("72000gp")
                    Case 7
                        EnhancementPrice = New Money("98000gp")
                    Case 8
                        EnhancementPrice = New Money("128000gp")
                    Case 9
                        EnhancementPrice = New Money("162000gp")
                    Case 10
                        EnhancementPrice = New Money("200000gp")
                    Case Else
                        EnhancementPrice = Nothing
                End Select

                If Not EnhancementPrice Is Nothing Then
                    Price.AddMoney(EnhancementPrice)
                End If

                Return MarketPrice(Price)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'determine the price of the enhanced armor/shield
        Private Shared Function EnhancedArmorPrice(ByVal Armor As Objects.ObjectData, ByVal Size As String, ByVal Material As Objects.ObjectKey, ByVal Enhancement As Integer, ByVal Humanoid As Boolean) As Money
            Dim Price As Money
            Dim NoEnhancement As Boolean
            Dim SpecialMaterial As SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(Material), SpecialMaterial)
            Try
                'check for special material
                If SpecialMaterial Is Nothing Then
                    'get base armor
                    Price = New Money(Armor.Element("Cost"))

                    'adjust for size
                    If Armor.Element("Masterwork") = "Yes" Then
                        Price.RemoveMoney("150gp")
                    End If

                    If Humanoid Then
                        Select Case Size
                            Case "Fine", "Diminutive", "Tiny"
                                Price.Multiply(0.5)
                            Case "Large"
                                Price.Multiply(2)
                            Case "Huge"
                                Price.Multiply(4)
                            Case "Gargantuan"
                                Price.Multiply(8)
                            Case "Colossal"
                                Price.Multiply(16)
                        End Select
                    Else
                        Select Case Size
                            Case "Small", "Medium"
                                Price.Multiply(2)
                            Case "Large"
                                Price.Multiply(4)
                            Case "Huge"
                                Price.Multiply(8)
                            Case "Gargantuan"
                                Price.Multiply(16)
                            Case "Colossal"
                                Price.Multiply(32)
                        End Select
                    End If

                    'add cost for masterwork
                    Price.AddMoney("150gp")

                Else
                    Price = SpecialMaterial.CalculateNonEnhancedPrice(Armor, Size, True, , , Humanoid)
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'adjust for effective enhancement
                Select Case Enhancement
                    Case 1
                        Price.AddMoney("1000gp")
                    Case 2
                        Price.AddMoney("4000gp")
                    Case 3
                        Price.AddMoney("9000gp")
                    Case 4
                        Price.AddMoney("16000gp")
                    Case 5
                        Price.AddMoney("25000gp")
                    Case 6
                        Price.AddMoney("36000gp")
                    Case 7
                        Price.AddMoney("49000gp")
                    Case 8
                        Price.AddMoney("64000gp")
                    Case 9
                        Price.AddMoney("81000gp")
                    Case 10
                        Price.AddMoney("100000gp")
                    Case Else
                        NoEnhancement = True
                End Select

                If Not SpecialMaterial Is Nothing Then
                    If Not NoEnhancement Then
                        Price.Gold += SpecialMaterial.EnhancementAdjustment
                    End If
                End If

                Return MarketPrice(Price)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'determine the price an enhanced ammo item
        Private Shared Function EnhancedAmmoPrice(ByVal Ammo As Objects.ObjectData, ByVal Size As String, ByVal Enhancement As Integer) As Money
            Dim Price As Money

            Try
                Price = New Money(Ammo.Element("Cost"))

                'adjust for size
                If Ammo.Element("Masterwork") = "" Then
                    Price.RemoveMoney("6gp")
                End If

                Select Case Size
                    Case "Fine", "Diminutive", "Tiny"
                        Price.Multiply(0.5)
                    Case "Large"
                        Price.Multiply(2)
                    Case "Huge"
                        Price.Multiply(4)
                    Case "Gargantuan"
                        Price.Multiply(8)
                    Case "Colossal"
                        Price.Multiply(16)
                End Select

                'add cost for masterwork
                Price.AddMoney("6gp")

                'adjust for effective enhancement
                Select Case Enhancement
                    Case 1
                        Price.AddMoney("40gp")
                    Case 2
                        Price.AddMoney("160gp")
                    Case 3
                        Price.AddMoney("360gp")
                    Case 4
                        Price.AddMoney("640gp")
                    Case 5
                        Price.AddMoney("1000gp")
                    Case 6
                        Price.AddMoney("1440gp")
                    Case 7
                        Price.AddMoney("1960gp")
                    Case 8
                        Price.AddMoney("2560gp")
                    Case 9
                        Price.AddMoney("3240gp")
                    Case 10
                        Price.AddMoney("4000gp")
                End Select

                Return MarketPrice(Price)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'determine the price an enhanced ammo item
        Private Shared Function EnhancedAmmoPrice(ByVal Ammo As Objects.ObjectData, ByVal Size As String, ByVal Material As Objects.ObjectKey, ByVal Enhancement As Integer) As Money
            Dim Price As Money
            Dim NoEnhancement As Boolean
            Dim SpecialMaterial As SpecialMaterial = CType(Rules.SpecialMaterial.Materials.Item(Material), SpecialMaterial)
            Try
                'check for special material
                If SpecialMaterial Is Nothing Then
                    Price = New Money(Ammo.Element("Cost"))

                    'adjust for size
                    If Ammo.Element("Masterwork") = "" Then
                        Price.RemoveMoney("6gp")
                    End If

                    Select Case Size
                        Case "Fine", "Diminutive", "Tiny"
                            Price.Multiply(0.5)
                        Case "Large"
                            Price.Multiply(2)
                        Case "Huge"
                            Price.Multiply(4)
                        Case "Gargantuan"
                            Price.Multiply(8)
                        Case "Colossal"
                            Price.Multiply(16)
                    End Select

                    'add cost for masterwork
                    Price.AddMoney("6gp")
                Else
                    Price = SpecialMaterial.CalculateNonEnhancedPrice(Ammo, Size, True)
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'adjust for effective enhancement
                Select Case Enhancement
                    Case 1
                        Price.AddMoney("40gp")
                    Case 2
                        Price.AddMoney("160gp")
                    Case 3
                        Price.AddMoney("360gp")
                    Case 4
                        Price.AddMoney("640gp")
                    Case 5
                        Price.AddMoney("1000gp")
                    Case 6
                        Price.AddMoney("1440gp")
                    Case 7
                        Price.AddMoney("1960gp")
                    Case 8
                        Price.AddMoney("2560gp")
                    Case 9
                        Price.AddMoney("3240gp")
                    Case 10
                        Price.AddMoney("4000gp")
                    Case Else
                        NoEnhancement = True
                End Select

                If Not SpecialMaterial Is Nothing Then
                    If Not NoEnhancement Then
                        Price.Gold += SpecialMaterial.EnhancementAdjustment
                    End If
                End If

                Return MarketPrice(Price)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'the weight of an item adjusted for size
        Public Shared Function ItemWeight(ByVal Item As Objects.ObjectData, Optional ByVal Size As String = "") As Decimal
            Dim D, F, T, S, L, H, G, C As Decimal
            Dim BaseItem As Objects.ObjectData

            ItemWeight = 0

            Try
                'get the base item weight
                Select Case Item.Type
                    Case Objects.PotionDefinitionType
                        ItemWeight = New Decimal(0.1625)
                    Case Objects.RingDefinitionType
                        ItemWeight = New Decimal(0.0625) '1 ounce
                    Case Objects.RodDefinitionType
                        ItemWeight = New Decimal(5)
                    Case Objects.StaffDefinitionType
                        ItemWeight = New Decimal(5)
                    Case Objects.ScrollDefinitionType
                        ItemWeight = New Decimal(0)
                    Case Objects.WandDefinitionType
                        ItemWeight = New Decimal(0.0625)
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType, Objects.AmmoDefinitionType, Objects.WeaponDefinitionType, Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.PsionicArtifactDefinitionType, Objects.UniversalItemDefinitionType
                        If Item.Element("Weight") = "-" Then
                            ItemWeight = 0
                        Else
                            ItemWeight = New Decimal(CType(Item.Element("Weight").Replace(" lb.", ""), Double))
                        End If
                    Case Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType, Objects.PsionicAmmoDefinitionType, Objects.PsionicWeaponDefinitionType
                        BaseItem = Item.GetFKObject("Weapon")
                        If BaseItem.Element("Weight") = "-" Then
                            ItemWeight = 0
                        Else
                            ItemWeight = New Decimal(CType(BaseItem.Element("Weight").Replace(" lb.", ""), Double))
                        End If
                    Case Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType
                        BaseItem = Item.GetFKObject("Armor")
                        If BaseItem.Element("Weight") = "-" Then
                            ItemWeight = 0
                        Else
                            ItemWeight = New Decimal(CType(BaseItem.Element("Weight").Replace(" lb.", ""), Double))
                        End If
                    Case Objects.ItemDefinitionType
                        If Item.Element("Weight") = "-" Then
                            ItemWeight = 0
                        Else
                            ItemWeight = New Decimal(CType(Item.Element("Weight").Replace(" lb.", ""), Double))
                        End If
                    Case Objects.PsionicDorjeDefinitionType
                        ItemWeight = New Decimal(0.25)
                    Case Objects.PsionicPsicrownDefinitionType
                        ItemWeight = New Decimal(1)
                    Case Objects.PsionicPowerStoneDefinitionType
                        ItemWeight = New Decimal(0)
                End Select

                'adjust the weight for size            
                Select Case Item.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType, Objects.AmmoDefinitionType, Objects.WeaponDefinitionType, Objects.SpecificArmorDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType
                        F = 0.1D : D = 0.1D : T = 0.1D
                        S = 0.5D : L = 2
                        H = 5 : G = 8 : C = 12

                        Select Case Size
                            Case "Fine"
                                Return ItemWeight * F
                            Case "Diminutive"
                                Return ItemWeight * D
                            Case "Tiny"
                                Return ItemWeight * T
                            Case "Small"
                                Return ItemWeight * S
                            Case "Large"
                                Return ItemWeight * L
                            Case "Huge"
                                Return ItemWeight * H
                            Case "Gargantuan"
                                Return ItemWeight * G
                            Case "Colossal"
                                Return ItemWeight * C
                            Case Else
                                Return ItemWeight
                        End Select

                    Case Objects.ItemDefinitionType
                        If Item.Element("AdjustForSize") = "Yes" Then

                            Select Case Size
                                Case "Fine"
                                    Return ItemWeight * CDec(Rules.Size.Size("Fine").ItemWeightModifier)
                                Case "Diminutive"
                                    Return ItemWeight * CDec(Rules.Size.Size("Diminutive").ItemWeightModifier)
                                Case "Tiny"
                                    Return ItemWeight * CDec(Rules.Size.Size("Tiny").ItemWeightModifier)
                                Case "Small"
                                    Return ItemWeight * CDec(Rules.Size.Size("Small").ItemWeightModifier)
                                Case "Medium"
                                    Return ItemWeight * CDec(Rules.Size.Size("Medium").ItemWeightModifier)
                                Case "Large"
                                    Return ItemWeight * CDec(Rules.Size.Size("Large").ItemWeightModifier)
                                Case "Huge"
                                    Return ItemWeight * CDec(Rules.Size.Size("Huge").ItemWeightModifier)
                                Case "Gargantuan"
                                    Return ItemWeight * CDec(Rules.Size.Size("Gargantuan").ItemWeightModifier)
                                Case "Colossal"
                                    Return ItemWeight * CDec(Rules.Size.Size("Colossal").ItemWeightModifier)
                                Case Else
                                    Return ItemWeight
                            End Select

                        Else
                            Return ItemWeight
                        End If

                    Case Else
                        Return ItemWeight

                End Select

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'should item size be displayed in inventory?
        Public Shared Function DisplaySize(ByVal Item As Objects.ObjectData) As Boolean
            Select Case Item.Type
                Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.SpecificArmorDefinitionType, Objects.MagicAmmoDefinitionType, Objects.WeaponDefinitionType, Objects.AmmoDefinitionType, Objects.PsionicWeaponDefinitionType, Objects.PsionicArmorDefinitionType
                    Return True
                Case Objects.PotionDefinitionType, Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.ScrollDefinitionType, Objects.PsionicPowerStoneDefinitionType, Objects.UniversalItemDefinitionType
                    Return False
                Case Objects.WandDefinitionType, Objects.RodDefinitionType, Objects.RingDefinitionType, Objects.StaffDefinitionType, Objects.PsionicDorjeDefinitionType, Objects.PsionicPsicrownDefinitionType
                    Return True
                Case Objects.ItemDefinitionType
                    If Item.Element("AdjustForSize") = "Yes" Then Return True Else Return False
            End Select
        End Function

        'adjust for market price
        Public Shared Function MarketPrice(ByVal Price As Money) As Money
            Try
                Dim Copper As Integer = Price.InCopper

                Copper = CType(Math.Round(Copper * ((General.MarketPrices + 100) / 100), 0), Integer)

                MarketPrice = New Money
                MarketPrice.Copper = Copper
                Return MarketPrice.InGold

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace

