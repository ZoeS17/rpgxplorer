Option Explicit On 
Option Strict On

Namespace Rules

    Public Class SpecialMaterial

#Region "Shared Variables"

        Public Shared Materials As New ObjectHashtable

#End Region

#Region "Member Variables"

        Public MaterialObject As Objects.ObjectData

        'compatibility flags
        Public WeaponCompatible As Boolean
        Public AmmoCompatible As Boolean
        Public LightArmorCompatible As Boolean
        Public MediumArmorCompatible As Boolean
        Public HeavyCompatible As Boolean
        Public ShieldCompatible As Boolean

        'flags
        Public MaterialForcesMasterwork As Boolean
        Public CostIncludesMasterwork As Boolean
        Public MuliplierEffectsMasterwork As Boolean

        'cost flag
        Public DoubleSameMaterial As Boolean

        'modifiers and values
        Public EnhancementAdjustment As Integer 'this is the cost adjustment
        Public WeightAdjustmet As Double
        Public AttackEnhancementAdjustment As Integer
        Public DamageEnhancementAdjustment As Integer

#End Region

        'constructor
        Public Sub New(ByVal SpecialMaterial As Objects.ObjectData)
            Try

                If Not SpecialMaterial.IsEmpty Then

                    'set base object
                    MaterialObject = SpecialMaterial

                    'set item compatibility flags
                    If MaterialObject.Element("AllowShield") = "Yes" Then ShieldCompatible = True
                    If MaterialObject.Element("AllowLightArmor") = "Yes" Then LightArmorCompatible = True
                    If MaterialObject.Element("AllowMediumArmor") = "Yes" Then MediumArmorCompatible = True
                    If MaterialObject.Element("AllowHeavyArmor") = "Yes" Then HeavyCompatible = True
                    If MaterialObject.Element("AllowWeapon") = "Yes" Then WeaponCompatible = True
                    If MaterialObject.Element("AllowAmmo") = "Yes" Then AmmoCompatible = True

                    'otherflags
                    If MaterialObject.Element("MaterialForcesMasterwork") = "Yes" Then MaterialForcesMasterwork = True
                    If MaterialObject.Element("CostIncludesMasterwork") = "Yes" Then CostIncludesMasterwork = True
                    If MaterialObject.Element("MuliplierEffectsMasterwork") = "Yes" Then MuliplierEffectsMasterwork = True

                    'get any ehnacement adjustment cost and other modifiers
                    EnhancementAdjustment = MaterialObject.ElementAsInteger("EnhancementAdjustment")
                    AttackEnhancementAdjustment = MaterialObject.ElementAsInteger("AttackEnhancementAdjustment")
                    DamageEnhancementAdjustment = MaterialObject.ElementAsInteger("DamageEnhancementAdjustment")

                    WeightAdjustmet = MaterialObject.ElementAsNumber("WeightAdjustment")
                    If WeightAdjustmet <= 0 Then WeightAdjustmet = 1

                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("Special Material object is empty")
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'is the material compatible with the given item
        Public Function Compatible(ByVal Item As Objects.ObjectData) As Boolean
            Try
                Select Case Item.Type

                    Case Objects.WeaponDefinitionType
                        If Me.WeaponCompatible Then Return True

                    Case Objects.ArmorDefinitionType
                        Select Case Item.Element("Training")
                            Case "Light"
                                If Me.LightArmorCompatible Then Return True
                            Case "Medium"
                                If Me.MediumArmorCompatible Then Return True
                            Case "Heavy"
                                If Me.HeavyCompatible Then Return True
                        End Select

                    Case Objects.ShieldDefinitionType
                        If Me.ShieldCompatible Then Return True

                End Select

                Return False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculates the non enhanced price
        Public Function CalculateNonEnhancedPrice(ByVal Item As Objects.ObjectData, ByVal Size As String, Optional ByVal ForceMasterwork As Boolean = False, Optional ByVal SecondHead As Boolean = False, Optional ByVal SecondaryMaterial As SpecialMaterial = Nothing, Optional ByVal Humanoid As Boolean = True) As Money
            Try
                'get the materials and set the masterwork flag
                Dim PMaterial As SpecialMaterial = Nothing
                Dim SMaterial As SpecialMaterial = Nothing
                DoubleSameMaterial = False

                If Not SecondaryMaterial Is Nothing Then
                    PMaterial = Me
                    SMaterial = SecondaryMaterial
                    If PMaterial.MaterialObject.ObjectGUID.Equals(SecondaryMaterial.MaterialObject.ObjectGUID) Then DoubleSameMaterial = True
                    If PMaterial.MaterialForcesMasterwork OrElse SMaterial.MaterialForcesMasterwork Then ForceMasterwork = True
                Else
                    If SecondHead Then
                        SMaterial = Me
                        If SMaterial.MaterialForcesMasterwork Then ForceMasterwork = True
                    Else
                        PMaterial = Me
                        If PMaterial.MaterialForcesMasterwork Then ForceMasterwork = True
                    End If
                End If

                'get the base price
                Dim Price As Money = New Money(Item.Element("Cost"))
                Dim WeightPrice As New Money

                If DoubleSameMaterial Then
                    'use pmaterial twice, as the doublesamematerial flag is an instance var, it will only be set correctly on the primary material
                    Price.AddMoney(PMaterial.CalculateScalableCostModifier(Item))
                    WeightPrice.AddMoney(PMaterial.CalculateScalableWeightModifier(Item))

                    Price.AddMoney(PMaterial.CalculateScalableCostModifier(Item))
                    WeightPrice.AddMoney(PMaterial.CalculateScalableWeightModifier(Item))
                Else
                    If Not PMaterial Is Nothing Then
                        Price.AddMoney(PMaterial.CalculateScalableCostModifier(Item))
                        WeightPrice.AddMoney(PMaterial.CalculateScalableWeightModifier(Item))
                    End If

                    If Not SMaterial Is Nothing Then
                        Price.AddMoney(SMaterial.CalculateScalableCostModifier(Item, True))
                        WeightPrice.AddMoney(SMaterial.CalculateScalableWeightModifier(Item, True))
                    End If
                End If

                'adjust for size
                If Item.Element("Masterwork") = "Yes" Then
                    Dim MasterworkPrice As Money = GetMasterworkModifier(Item)
                    If Item.Element("Double") = "Yes" Then
                        MasterworkPrice.Multiply(2)
                    End If
                    Price.RemoveMoney(MasterworkPrice)
                End If

                If (Humanoid = False) AndAlso (Item.Type = Objects.ArmorDefinitionType OrElse Item.Type = Objects.ShieldDefinitionType) Then
                    Select Case Size
                        Case "Fine", "Diminutive", "Tiny"
                            Price.Multiply(1)
                            WeightPrice.Multiply(0.1)
                        Case "Small"
                            Price.Multiply(2)
                            WeightPrice.Multiply(0.5)
                        Case "Medium"
                            Price.Multiply(2)
                        Case "Large"
                            Price.Multiply(4)
                            WeightPrice.Multiply(2)
                        Case "Huge"
                            Price.Multiply(8)
                            WeightPrice.Multiply(5)
                        Case "Gargantuan"
                            Price.Multiply(16)
                            WeightPrice.Multiply(8)
                        Case "Colossal"
                            Price.Multiply(32)
                            WeightPrice.Multiply(12)
                    End Select
                Else
                    Select Case Size
                        Case "Fine", "Diminutive", "Tiny"
                            Price.Multiply(0.5)
                            WeightPrice.Multiply(0.1)
                        Case "Small"
                            WeightPrice.Multiply(0.5)
                        Case "Large"
                            Price.Multiply(2)
                            WeightPrice.Multiply(2)
                        Case "Huge"
                            Price.Multiply(4)
                            WeightPrice.Multiply(5)
                        Case "Gargantuan"
                            Price.Multiply(8)
                            WeightPrice.Multiply(8)
                        Case "Colossal"
                            Price.Multiply(16)
                            WeightPrice.Multiply(12)
                    End Select
                End If

                Price.AddMoney(WeightPrice)

                'add cost for masterwork
                If (Item.Element("Masterwork") = "Yes") OrElse ForceMasterwork Then
                    If Item.Element("Double") = "Yes" Then
                        Dim PrimaryMasterworkPrice As Money = GetMasterworkModifier(Item)
                        Dim SecondaryMasterworkPrice As Money = GetMasterworkModifier(Item)

                        If Not PMaterial Is Nothing Then PrimaryMasterworkPrice.Multiply(MasterworkFactor(Item))
                        If Not SMaterial Is Nothing Then SecondaryMasterworkPrice.Multiply(MasterworkFactor(Item, True))

                        Price.AddMoney(PrimaryMasterworkPrice)
                        Price.AddMoney(SecondaryMasterworkPrice)

                    Else
                        Dim MasterworkPrice As New Money
                        MasterworkPrice.AddMoney(GetMasterworkModifier(Item))
                        MasterworkPrice.Multiply(MasterworkFactor(Item))
                        Price.AddMoney(MasterworkPrice)
                    End If
                End If

                Return Price

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculates the non enhanced price - this ammount is can be scaled based on the size cost modifier
        Public Function CalculateScalableCostModifier(ByVal Item As Objects.ObjectData, Optional ByVal SecondHead As Boolean = False) As Money
            Try
                Dim Price As New Money

                'find out material cost modifier tpye
                Dim BaseElement As String = GetPriceElement(Item, SecondHead)
                Dim Type As String = MaterialObject.Element(BaseElement & "CostType")
                Dim Value As Double = MaterialObject.ElementAsNumber(BaseElement & "CostModifier")

                Select Case Type

                    Case ""
                        Return Price

                    Case "Specific"
                        Price.Gold += CInt(Value)
                        If DoubleSameMaterial Then Price.Multiply(0.5)
                        If CostIncludesMasterwork Then
                            Price.RemoveMoney(GetMasterworkModifier(Item))
                        End If

                        Return Price

                    Case "Multiplier"
                        Price = New Money(Item.Element("Cost"))

                        If Item.Element("Double") = "Yes" Then Price.Multiply(0.5)
                        If Item.Element("Masterwork") = "Yes" Then Price.RemoveMoney(GetMasterworkModifier(Item))

                        Dim PriceModifier As New Money(Price.DisplayString)
                        PriceModifier.Multiply(Value)
                        PriceModifier.RemoveMoney(Price)

                        Return PriceModifier

                    Case Else
                        Return Price

                End Select

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculates the non enhanced price modifier - this ammount is can be scaled based on the size weight modifier
        Public Function CalculateScalableWeightModifier(ByVal Item As Objects.ObjectData, Optional ByVal SecondHead As Boolean = False) As Money
            Try
                Dim Price As New Money
                Dim ItemWeight As Double

                'find out material cost modifier tpye
                Dim BaseElement As String = GetPriceElement(Item, SecondHead)
                Dim Type As String = MaterialObject.Element(BaseElement & "CostType")
                Dim Value As Double = MaterialObject.ElementAsNumber(BaseElement & "CostModifier")

                Select Case Type

                    Case "PerPound"
                        ItemWeight = CType(Item.Element("Weight").Replace(" lb.", ""), Double)
                        If ItemWeight > 0 Then
                            If Item.Element("Double") = "Yes" Then ItemWeight = ItemWeight / 2
                        End If
                        Price.Gold = CInt(Value)
                        Price.Multiply(ItemWeight)

                        Return Price

                    Case Else
                        Return Price

                End Select

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the multiplication factor for the masterwork addition
        Public Function MasterworkFactor(ByVal Item As Objects.ObjectData, Optional ByVal SecondHead As Boolean = False) As Double
            Try
                Dim BaseElement As String = GetPriceElement(Item, SecondHead)
                Dim Type As String = MaterialObject.Element(BaseElement & "CostType")
                Dim Value As Double = MaterialObject.ElementAsNumber(BaseElement & "CostModifier")

                'if the per pound bonus includes the masterwork cost, then we dont want to add anything else
                If Type = "PerPound" And CostIncludesMasterwork Then
                    Return 0
                End If

                If MuliplierEffectsMasterwork And Type = "Multiplier" Then
                    Return Value
                Else
                    Return 1
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the masterwork modifier for the given item
        Private Function GetMasterworkModifier(ByVal Item As Objects.ObjectData) As Money
            Dim MasterworkModifier As New Money
            Try
                Select Case Item.Type
                    Case Objects.ArmorDefinitionType
                        MasterworkModifier.Gold = 150
                    Case Objects.ShieldDefinitionType
                        MasterworkModifier.Gold = 150
                    Case Objects.AmmoDefinitionType
                        MasterworkModifier.Gold = 6
                    Case Objects.WeaponDefinitionType
                        MasterworkModifier.Gold = 300
                End Select

                Return MasterworkModifier

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Private Function GetPriceElement(ByVal Item As Objects.ObjectData, ByVal SecondHead As Boolean) As String
            Try

                Select Case Item.Type

                    Case Objects.ArmorDefinitionType

                        Select Case Item.Element("Training")
                            Case "Light"
                                Return "LightArmor"
                            Case "Medium"
                                Return "MediumArmor"
                            Case "Heavy"
                                Return "HeavyArmor"
                        End Select

                    Case Objects.ShieldDefinitionType
                        Return "Shield"

                    Case Objects.AmmoDefinitionType
                        Return "Ammo"

                    Case Objects.WeaponDefinitionType
                        Dim EncumbranceType As String
                        Dim DamageType As String

                        'get the encumbrance type
                        If Item.Element("Double") = "Yes" Then
                            If DoubleSameMaterial Then
                                Return "DoubleWeapon"
                            Else
                                EncumbranceType = "OneHand"
                            End If
                        Else
                            EncumbranceType = Item.Element("Encumbrance")
                            If EncumbranceType.StartsWith("Two-Handed") Then
                                EncumbranceType = "TwoHand"
                            ElseIf EncumbranceType.Equals("One-Handed") Then
                                EncumbranceType = "OneHand"
                            End If
                        End If

                        'get the damage type
                        If SecondHead Then
                            DamageType = Item.Element("DDamageType1")
                        Else
                            DamageType = Item.Element("DamageType1")
                        End If

                        'check that this exists, if not consider 2nd damage type
                        If MaterialObject.Element(EncumbranceType & DamageType & "CostModifier") = "" Then
                            Dim SecondDamageType As String

                            'get the damage type
                            If SecondHead Then
                                SecondDamageType = Item.Element("DDamageType2")
                            Else
                                SecondDamageType = Item.Element("DamageType2")
                            End If

                            If MaterialObject.Element(EncumbranceType & SecondDamageType & "CostModifier") <> "" Then
                                Return EncumbranceType & SecondDamageType
                            End If
                        End If

                        Return EncumbranceType & DamageType
                End Select
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#Region "Shared Functions"

        'Public Shared Function CalculateDoubleWeaponNonEnhancedPrice(ByVal Item As Objects.ObjectData, ByVal Size As String, ByVal PMaterial As SpecialMaterial, ByVal SMaterial As SpecialMaterial, Optional ByVal ForceMasterwork As Boolean = False) As Money
        '    Try
        '        If Item.Element("Double") <> "Yes" Then Throw New RPGXplorer.Exceptions.DevelopmentException("Attempt to calculate special material cost of a double weapon failed, as weapon is not defined as a double weapon.")

        '        'get the base price
        '        Dim Price As Money = New Money(Item.Element("Cost"))
        '        Dim WeightPrice As New Money

        '        If Not PMaterial Is Nothing Then
        '            Price.AddMoney(PMaterial.CalculateScalableCostModifier(Item))
        '            WeightPrice.AddMoney(PMaterial.CalculateScalableWeightModifier(Item))
        '        End If

        '        If Not SMaterial Is Nothing Then
        '            Price.AddMoney(SMaterial.CalculateScalableCostModifier(Item, True))
        '            WeightPrice.AddMoney(SMaterial.CalculateScalableWeightModifier(Item, True))
        '        End If

        '        'adjust for size
        '        If Item.Element("Masterwork") = "Yes" Then Price.RemoveMoney("600gp")

        '        Select Case Size
        '            Case "Small"
        '                WeightPrice.Multiply(0.5)

        '            Case "Large"
        '                Price.Multiply(2)
        '                WeightPrice.Multiply(2)
        '        End Select

        '        Price.AddMoney(WeightPrice)

        '        'add cost for masterwork
        '        If (Item.Element("Masterwork") = "Yes") OrElse PMaterial.MaterialForcesMasterwork OrElse SMaterial.MaterialForcesMasterwork OrElse ForceMasterwork Then
        '            Dim MasterworkPrice As New Money("300gp")
        '            Dim SMasterworkPrice As New Money("300gp")
        '            MasterworkPrice.Multiply(PMaterial.MasterworkFactor(Item))
        '            SMasterworkPrice.Multiply(SMaterial.MasterworkFactor(Item, True))
        '            Price.AddMoney(MasterworkPrice)
        '            Price.AddMoney(SMasterworkPrice)
        '        End If

        '    Catch ex As Exception
        '        Throw New Exception(ex.Message, ex)
        '    End Try
        'End Function


        'return an arraylist of material ObjectData's which can be applied to the given item
        Public Shared Function CompatibleMaterials(ByVal Item As Objects.ObjectData) As Objects.ObjectDataCollection
            Try
                Dim MaterialList As New Objects.ObjectDataCollection

                Select Case Item.Type

                    Case Objects.WeaponDefinitionType
                        For Each Material As SpecialMaterial In Materials.Values
                            If material.WeaponCompatible Then MaterialList.Add(Material.MaterialObject)
                        Next

                    Case Objects.ArmorDefinitionType
                        Select Case Item.Element("Training")
                            Case "Light"
                                For Each Material As SpecialMaterial In Materials.Values
                                    If material.LightArmorCompatible Then MaterialList.Add(Material.MaterialObject)
                                Next
                            Case "Medium"
                                For Each Material As SpecialMaterial In Materials.Values
                                    If material.MediumArmorCompatible Then MaterialList.Add(Material.MaterialObject)
                                Next
                            Case "Heavy"
                                For Each Material As SpecialMaterial In Materials.Values
                                    If material.HeavyCompatible Then MaterialList.Add(Material.MaterialObject)
                                Next
                        End Select

                    Case Objects.ShieldDefinitionType
                        For Each Material As SpecialMaterial In Materials.Values
                            If material.shieldCompatible Then MaterialList.Add(Material.MaterialObject)
                        Next

                    Case Objects.AmmoDefinitionType
                        For Each Material As SpecialMaterial In Materials.Values
                            If material.AmmoCompatible Then MaterialList.Add(Material.MaterialObject)
                        Next

                End Select

                Return MaterialList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'loads the class with each special material
        Public Shared Sub Load()
            Try
                For Each TempObj As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Materials, Objects.SpecialMaterialDefinitionType)
                    Dim Material As New Rules.SpecialMaterial(TempObj)
                    Rules.SpecialMaterial.Materials.Add(TempObj.ObjectGUID, Material)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#End Region

    End Class

End Namespace


