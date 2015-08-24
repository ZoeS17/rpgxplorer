Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class MonsterWeapons
        Inherits Weapons
        <CLSCompliant(False)> Public _OffHandItems As New ArrayList
        <CLSCompliant(False)> Public _OffHandWields As New ArrayList
        <CLSCompliant(False)> Private _OffHandCount As Integer

#Region "Overridden Properties"

        'get off hand item by index
        Public Overloads Property OffHandItem(ByVal index As Integer) As WeaponsData
            Get
                Return CType(_OffHandItems.Item(index - 1), WeaponsData)
            End Get
            Set(ByVal Value As WeaponsData)
                _OffHandItems(index - 1) = Value
            End Set
        End Property

        'get off hand wield by index
        Public Overloads Property OffHandWield(ByVal index As Integer) As Wield
            Get
                Return CType(_OffHandWields.Item(index - 1), Wield)
            End Get
            Set(ByVal Value As Wield)
                _OffHandWields(index - 1) = Value
            End Set
        End Property

        'is the character two weapon fighting?
        Public Overrides ReadOnly Property TwoWeaponFighting() As Boolean
            Get
                Try
                    'if we are wielding a double weapon
                    If _PrimaryWield = Weapons.Wield.DoubleWeapon Then
                        Return True
                    End If

                    'set flag for having a manufactured primary weapon
                    Dim PrimaryWeaponFlag, OffHandWeaponFlag As Boolean
                    If (Not PrimaryWeapon.IsNatural) AndAlso _PrimaryWield <> Weapons.Wield.NotSet AndAlso _PrimaryWield <> Weapons.Wield.Shield Then
                        PrimaryWeaponFlag = True
                    End If

                    'check the offhands
                    For i As Integer = 1 To OffHandCount
                        If (Not OffHandItem(i).IsNatural) AndAlso (OffHandWield(i) <> Weapons.Wield.NotSet AndAlso OffHandWield(i) <> Weapons.Wield.Shield) Then
                            If PrimaryWeaponFlag OrElse OffHandWeaponFlag OrElse OffHandItem(i).AttackNumber > 1 Then Return True
                            OffHandWeaponFlag = True
                        End If
                    Next

                    Return False

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'are all off hand weapons light?
        Public Overrides ReadOnly Property OffHandWeaponLight() As Boolean
            Get
                Try

                    For i As Integer = 1 To OffHandCount
                        If Not OffHandItem(i).IsNatural Then

                            Select Case OffHandWield(i)
                                Case Weapons.Wield.OneHanded
                                    If Not (_Character.Components.SystemAbilities(References.OversizedTwoWeaponFighting) OrElse OffHandItem(i).WieldData.WieldType = Weapons.WieldType.LightMelee) Then Return False

                                Case Weapons.Wield.ShieldBash
                                    If Not OffHandItem(i).WieldData.WieldType = Weapons.WieldType.LightShield Then Return False

                                Case Wield.NotSet
                                    'do nothing?

                                Case Else
                                    Return False

                            End Select

                        End If
                    Next

                    Return True

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'is a monk attack possible with current configuration?
        Public Overrides ReadOnly Property MonkAttackPossible() As Boolean
            Get
                If Not (_Inventory.Unarmored And _Attacks.FlurryOfBlows) Then Return False
                If _PrimaryWeapon.DisableFlurry Then Return False
                If BucklerWielded Then Return False

                If Not _PrimaryWeapon.IsEmpty Then
                    'if primary is a natural attack, no manufacted or unarmed strikes can exist
                    If _PrimaryWeapon.IsNatural Then Return False

                    If Not _PrimaryWeapon.Properties.MonkWeapon Then Return False
                End If

                'check all the off hands
                For i As Integer = 1 To OffHandCount
                    If Not OffHandItem(i).IsEmpty Then
                        If Not OffHandItem(i).IsNatural Then
                            If Not OffHandItem(i).Properties.MonkWeapon Then Return False
                        End If
                    End If
                Next

                Return True

            End Get
        End Property

#End Region

#Region "Properties"

        Public ReadOnly Property OffHandCount() As Integer
            Get
                Return _OffHandCount
            End Get
        End Property

#End Region

        'init
        Public Overrides Sub Init(ByVal Character As Character, ByRef WeaponProficiency As Rules.Proficiency, ByRef Inventory As Inventory, ByVal WeaponsFolder As Objects.ObjectKey, ByVal BaseLineComponents As Rules.Components)
            Try
                MyBase.Init(Character, WeaponProficiency, Inventory, WeaponsFolder, BaseLineComponents)

                'extra init

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load 
        Public Overrides Sub Load(ByVal Obj As Objects.ObjectData)
            Dim WeaponData As New WeaponsData

            Try
                IsLoading = True
                WeaponsObj = Obj

                'index
                _Index = WeaponsObj.ElementAsInteger("Index")

                'primary
                If WeaponsObj.Element("PrimaryWeapon") <> "" Then
                    WeaponData.Item = WeaponsObj.GetFKObject("PrimaryWeapon")
                    WeaponData.InventoryItem = WeaponsObj.GetFKObject("PrimaryInventory")
                    WeaponData.BaseItem = CommonLogic.GetBaseWeaponOrArmor(WeaponData.Item)
                    WeaponData.Hand = Hand.Primary
                    If WeaponsObj.Element("PrimaryMasterwork") = "Yes" Then WeaponData.Masterwork = True
                    WeaponData.Enhancement = WeaponsObj.ElementAsInteger("PrimaryEnhancement")
                    WeaponData.Weapons = Me

                    'check for empty string for backwards compatability
                    If WeaponsObj.Element("PrimaryHandSTRMod") = "" Then
                        WeaponData.PrimaryHandSTRMod = STRBonus.Full
                    Else
                        WeaponData.PrimaryHandSTRMod = CType(WeaponsObj.ElementAsInteger("PrimaryHandSTRMod"), STRBonus)
                    End If

                    WeaponData.WeaponSize = WeaponsObj.Element("PrimarySize")
                    WeaponData.WieldData = GetWieldData(WeaponData.BaseItem, WeaponData.WeaponSize)

                    If WeaponsObj.Element("DisableFinesse") = "Yes" Then WeaponData.DisableFinesse = True
                    WeaponData.Properties = New WeaponProperties(WeaponData, _Character, WeaponProperties.InitMode.Weapons)
                    WeaponData.Bane = WeaponsObj.GetFKGuid("PrimaryBane")
                    If WeaponsObj.Element("PrimaryImprovisedMelee") = "Yes" Then WeaponData.ImprovisedMelee = True
                    If WeaponsObj.Element("DisableFlurry") = "Yes" Then WeaponData.DisableFlurry = True
                    WeaponData.AttackNumber = WeaponsObj.ElementAsInteger("PrimaryAttackNumber")

                    PrimaryWeapon = WeaponData
                    PrimaryWield = CType(WeaponsObj.ElementAsInteger("PrimaryWield"), Wield)
                End If

                WeaponData.Clear()

                'offhand - only used in the Primary Double weapon situation
                If WeaponsObj.Element("OffHandItem") <> "" Then
                    WeaponData.Item = WeaponsObj.GetFKObject("OffHandItem")
                    WeaponData.InventoryItem = WeaponsObj.GetFKObject("OffHandInventory")
                    WeaponData.BaseItem = CommonLogic.GetBaseWeaponOrArmor(WeaponData.Item)
                    WeaponData.Hand = Hand.OffHand
                    If WeaponsObj.Element("OffHandMasterwork") = "Yes" Then WeaponData.Masterwork = True
                    WeaponData.Enhancement = WeaponsObj.ElementAsInteger("OffHandEnhancement")
                    WeaponData.Weapons = Me
                    WeaponData.OffHandSTRMod = STRBonus.Half
                    WeaponData.WeaponSize = WeaponsObj.Element("OffHandSize")
                    WeaponData.WieldData = GetWieldData(WeaponData.BaseItem, WeaponData.WeaponSize)
                    WeaponData.Properties = New WeaponProperties(WeaponData, _Character, WeaponProperties.InitMode.Weapons)
                    WeaponData.Bane = WeaponsObj.GetFKGuid("OffHandBane")
                    If WeaponsObj.Element("OffHandImprovisedMelee") = "Yes" Then WeaponData.ImprovisedMelee = True

                    OffHandItem = WeaponData
                    OffHandWield = CType(WeaponsObj.ElementAsInteger("OffHandWield"), Wield)
                End If

                WeaponData.Clear()

                'normal moster offhands
                _OffHandCount = WeaponsObj.ElementAsInteger("OffHandCount")

                For i As Integer = 1 To OffHandCount
                    WeaponData.Item = WeaponsObj.GetFKObject("OffHandItem" + i.ToString)
                    WeaponData.InventoryItem = WeaponsObj.GetFKObject("OffHandInventory" + i.ToString)
                    WeaponData.BaseItem = CommonLogic.GetBaseWeaponOrArmor(WeaponData.Item)
                    WeaponData.Hand = Hand.OffHand
                    If WeaponsObj.Element("OffHandMasterwork" + i.ToString) = "Yes" Then WeaponData.Masterwork = True
                    WeaponData.Enhancement = WeaponsObj.ElementAsInteger("OffHandEnhancement" + i.ToString)
                    WeaponData.Weapons = Me

                    'check for empty string for backwards compatability
                    If WeaponsObj.Element("OffHandSTRMod" + i.ToString) = "" Then
                        WeaponData.OffHandSTRMod = STRBonus.Half
                    Else
                        WeaponData.OffHandSTRMod = CType(WeaponsObj.ElementAsInteger("OffHandSTRMod" + i.ToString), STRBonus)
                    End If

                    WeaponData.WeaponSize = WeaponsObj.Element("OffHandSize" + i.ToString)
                    WeaponData.WieldData = GetWieldData(WeaponData.BaseItem, WeaponData.WeaponSize)

                    WeaponData.Properties = New WeaponProperties(WeaponData, _Character, WeaponProperties.InitMode.Weapons)
                    WeaponData.Bane = WeaponsObj.GetFKGuid("OffHandBane" + i.ToString)
                    If WeaponsObj.Element("OffHandImprovisedMelee" + i.ToString) = "Yes" Then WeaponData.ImprovisedMelee = True
                    WeaponData.AttackNumber = WeaponsObj.ElementAsInteger("OffHand" + i.ToString + "AttackNumber")

                    _OffHandItems.Add(WeaponData)
                    _OffHandWields.Add(CType(WeaponsObj.ElementAsInteger("OffHandWield" + i.ToString), Wield))

                    'OffHandItem = WeaponData
                    'OffHandWield = CType(WeaponsObj.ElementAsInteger("OffHandWield"), Wield)
                    WeaponData.Clear()
                Next

                'buckler
                'If WeaponsObj.Element("Buckler") <> "" Then
                '    WeaponData.Item = WeaponsObj.GetFKObject("Buckler")
                '    WeaponData.InventoryItem = WeaponsObj.GetFKObject("BucklerInventory")
                '    WeaponData.BaseItem = CommonLogic.GetBaseWeaponOrArmor(WeaponData.Item)
                '    WeaponData.Hand = Hand.Buckler
                '    If WeaponsObj.Element("BucklerMasterwork") = "Yes" Then WeaponData.Masterwork = True
                '    WeaponData.Enhancement = WeaponsObj.ElementAsInteger("BucklerEnhancement")
                '    WeaponData.Weapons = Me
                '    WeaponData.WeaponSize = WeaponsObj.Element("BucklerSize")
                '    WeaponData.WieldData = GetWieldData(WeaponData.BaseItem, WeaponData.WeaponSize)
                '    WeaponData.Properties = New WeaponProperties(WeaponData, _Character, WeaponProperties.InitMode.Weapons)
                '    Buckler = WeaponData
                'End If

                '_PrimaryWeapon.Weapons = Me
                '_OffHandItem.Weapons = Me
                ' _Buckler.Weapons = Me

                IsLoading = False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save
        Public Overrides Sub Save()
            Try
                If _WeaponsFolder.Equals(Objects.ObjectKey.Empty) Then Throw New DevelopmentException("Can't save weapons. Folder guid is empty.")

                WeaponsObj.Name = "Weapon Configuration " & Index.ToString

                If WeaponsObj.IsEmpty Then
                    WeaponsObj.ObjectGUID = Objects.ObjectKey.NewGuid(_WeaponsFolder.Database)
                    WeaponsObj.Type = Objects.WeaponConfigType
                    WeaponsObj.ParentGUID = _WeaponsFolder
                End If

                'index
                WeaponsObj.ElementAsInteger("Index") = _Index

                'primary
                If Not _PrimaryWeapon.Item.IsEmpty Then
                    WeaponsObj.FKElement("PrimaryWeapon", _PrimaryWeapon.Item.Name, "Name", _PrimaryWeapon.Item.ObjectGUID)
                    If _PrimaryWeapon.InventoryItem.IsNotEmpty Then WeaponsObj.FKElement("PrimaryInventory", _PrimaryWeapon.InventoryItem.Name, "Name", _PrimaryWeapon.InventoryItem.ObjectGUID) Else WeaponsObj.FKSetNull("PrimaryInventory")
                    WeaponsObj.ElementAsInteger("PrimaryWield") = _PrimaryWield
                    If _PrimaryWeapon.Masterwork Then WeaponsObj.Element("PrimaryMasterwork") = "Yes" Else WeaponsObj.Element("PrimaryMasterwork") = ""
                    WeaponsObj.ElementAsInteger("PrimaryEnhancement") = _PrimaryWeapon.Enhancement
                    WeaponsObj.Element("PrimarySize") = _PrimaryWeapon.WeaponSize
                    WeaponsObj.ElementAsInteger("PrimaryHandSTRMod") = _PrimaryWeapon.PrimaryHandSTRMod
                    If Not _PrimaryWeapon.Bane.Equals(Objects.ObjectKey.Empty) Then
                        Dim Bane As New Objects.ObjectData
                        Bane.Load(_PrimaryWeapon.Bane)
                        WeaponsObj.FKElement("PrimaryBane", Bane.Name, "Name", Bane.ObjectGUID)
                    Else
                        WeaponsObj.FKSetNull("PrimaryBane")
                    End If
                    If _PrimaryWeapon.ImprovisedMelee Then WeaponsObj.Element("PrimaryImprovisedMelee") = "Yes" Else WeaponsObj.Element("PrimaryImprovisedMelee") = ""
                    If _PrimaryWeapon.DisableFlurry = True Then WeaponsObj.Element("DisableFlurry") = "Yes" Else WeaponsObj.Element("DisableFlurry") = ""
                    If _PrimaryWeapon.DisableFinesse = True Then WeaponsObj.Element("DisableFinesse") = "Yes" Else WeaponsObj.Element("DisableFinesse") = ""
                Else
                    WeaponsObj.FKSetNull("PrimaryWeapon")
                    WeaponsObj.FKSetNull("PrimaryInventory")
                    WeaponsObj.Element("PrimaryWield") = ""
                    WeaponsObj.Element("PrimaryMasterwork") = ""
                    WeaponsObj.Element("PrimaryEnhancement") = ""
                    WeaponsObj.Element("PrimarySize") = ""
                    WeaponsObj.FKSetNull("PrimaryBane")
                    WeaponsObj.Element("PrimaryImprovisedMelee") = ""
                    WeaponsObj.Element("DisableFlurry") = ""
                    WeaponsObj.Element("PrimaryHandSTRMod") = ""
                End If

                'offhand - only used in the Primary Double weapon situation
                If Not _OffHandItem.Item.IsEmpty Then
                    WeaponsObj.FKElement("OffHandItem", _OffHandItem.Item.Name, "Name", _OffHandItem.Item.ObjectGUID)
                    If _OffHandItem.InventoryItem.IsNotEmpty Then WeaponsObj.FKElement("OffHandInventory", _OffHandItem.InventoryItem.Name, "Name", _OffHandItem.InventoryItem.ObjectGUID) Else WeaponsObj.FKSetNull("OffHandInventory")
                    WeaponsObj.ElementAsInteger("OffHandWield") = _OffHandWield
                    If _OffHandItem.Masterwork Then WeaponsObj.Element("OffHandMasterwork") = "Yes" Else WeaponsObj.Element("OffHandMasterwork") = ""
                    WeaponsObj.ElementAsInteger("OffHandEnhancement") = _OffHandItem.Enhancement
                    WeaponsObj.Element("OffHandSize") = _OffHandItem.WeaponSize
                    If Not _OffHandItem.Bane.Equals(Objects.ObjectKey.Empty) Then
                        Dim Bane As New Objects.ObjectData
                        Bane.Load(_OffHandItem.Bane)
                        WeaponsObj.FKElement("OffHandBane", Bane.Name, "Name", Bane.ObjectGUID)
                    Else
                        WeaponsObj.FKSetNull("OffHandBane")
                    End If
                    If _OffHandItem.ImprovisedMelee Then WeaponsObj.Element("OffHandImprovisedMelee") = "Yes" Else WeaponsObj.Element("OffHandImprovisedMelee") = ""
                Else
                    WeaponsObj.FKSetNull("OffHandItem")
                    WeaponsObj.FKSetNull("OffHandInventory")
                    WeaponsObj.Element("OffHandWield") = ""
                    WeaponsObj.Element("OffHandMasterwork") = ""
                    WeaponsObj.Element("OffHandEnhancement") = ""
                    WeaponsObj.Element("OffHandSize") = ""
                    WeaponsObj.FKSetNull("OffHandBane")
                    WeaponsObj.Element("OffHandImprovisedMelee") = ""
                End If

                'normal monster offhands
                WeaponsObj.ElementAsInteger("OffHandCount") = _OffHandCount

                For i As Integer = 1 To OffHandCount
                    If Not OffHandItem(i).Item.IsEmpty Then
                        WeaponsObj.FKElement("OffHandItem" + i.ToString, OffHandItem(i).Item.Name, "Name", OffHandItem(i).Item.ObjectGUID)
                        If OffHandItem(i).InventoryItem.IsNotEmpty Then WeaponsObj.FKElement("OffHandInventory" + i.ToString, OffHandItem(i).InventoryItem.Name, "Name", OffHandItem(i).InventoryItem.ObjectGUID) Else WeaponsObj.FKSetNull("OffHandInventory" + i.ToString)
                        WeaponsObj.ElementAsInteger("OffHandWield" + i.ToString) = OffHandWield(i)
                        If OffHandItem(i).Masterwork Then WeaponsObj.Element("OffHandMasterwork" + i.ToString) = "Yes" Else WeaponsObj.Element("OffHandMasterwork" + i.ToString) = ""
                        WeaponsObj.ElementAsInteger("OffHandEnhancement" + i.ToString) = OffHandItem(i).Enhancement
                        WeaponsObj.Element("OffHandSize" + i.ToString) = OffHandItem(i).WeaponSize
                        WeaponsObj.ElementAsInteger("OffHandSTRMod" + i.ToString) = OffHandItem(i).OffHandSTRMod
                        If Not OffHandItem(i).Bane.Equals(Objects.ObjectKey.Empty) Then
                            Dim Bane As New Objects.ObjectData
                            Bane.Load(OffHandItem(i).Bane)
                            WeaponsObj.FKElement("OffHandBane" + i.ToString, Bane.Name, "Name", Bane.ObjectGUID)
                        Else
                            WeaponsObj.FKSetNull("OffHandBane" + i.ToString)
                        End If
                        If OffHandItem(i).ImprovisedMelee Then WeaponsObj.Element("OffHandImprovisedMelee" + i.ToString) = "Yes" Else WeaponsObj.Element("OffHandImprovisedMelee" + i.ToString) = ""
                    Else
                        WeaponsObj.FKSetNull("OffHandItem" + i.ToString)
                        WeaponsObj.FKSetNull("OffHandInventory" + i.ToString)
                        WeaponsObj.Element("OffHandWield" + i.ToString) = ""
                        WeaponsObj.Element("OffHandMasterwork" + i.ToString) = ""
                        WeaponsObj.Element("OffHandEnhancement" + i.ToString) = ""
                        WeaponsObj.Element("OffHandSize" + i.ToString) = ""
                        WeaponsObj.FKSetNull("OffHandBane" + i.ToString)
                        WeaponsObj.Element("OffHandImprovisedMelee" + i.ToString) = ""
                        WeaponsObj.Element("OffHandSTRMod" + i.ToString) = ""
                    End If
                Next

                'buckler
                'If Not _Buckler.Item.IsEmpty Then
                '    WeaponsObj.FKElement("Buckler", _Buckler.Item.Name, "Name", _Buckler.Item.ObjectGUID)
                '    WeaponsObj.FKElement("BucklerInventory", _Buckler.InventoryItem.Name, "Name", _Buckler.InventoryItem.ObjectGUID)
                '    If _Buckler.Masterwork Then WeaponsObj.Element("BucklerMasterwork") = "Yes" Else WeaponsObj.Element("BucklerMasterwork") = ""
                '    WeaponsObj.ElementAsInteger("BucklerEnhancement") = _Buckler.Enhancement
                '    WeaponsObj.Element("BucklerSize") = _Buckler.WeaponSize
                'Else
                '    WeaponsObj.FKSetNull("Buckler")
                '    WeaponsObj.FKSetNull("BucklerInventory")
                '    WeaponsObj.Element("BucklerMasterwork") = ""
                '    WeaponsObj.Element("BucklerEnhancement") = ""
                '    WeaponsObj.Element("BucklerSize") = ""
                'End If

                WeaponsObj.Save()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'reset - do not reset the natural weapons
        Public Overrides Sub Reset()
            Try

                If Not _PrimaryWeapon.IsNatural Then
                    _PrimaryWeapon.Clear()
                    _PrimaryWield = Wield.NotSet

                    _OffHandItem.Clear()
                    _OffHandWield = Wield.NotSet
                End If

                For i As Integer = 1 To _OffHandCount
                    If Not OffHandItem(i).IsNatural Then
                        OffHandItem(i).Clear()
                        OffHandWield(i) = Wield.NotSet
                    End If
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        ''configuration description text
        Public Overrides Function GetConfigurationDisplay() As DisplayDetails
            Dim Display As New DisplayDetails
            Dim ModString As String = ""

            Try
                _Attacks.Weapons = Me

                'reset character
                _Character.Components = _BaseLineComponents.Clone
                _Character.Modifiers.Calculate(True)

                'load any components from the weapons
                If _PrimaryWield <> Wield.NotSet Then _Character.Components.AnalyseArms(Me.PrimaryWeapon.Item)

                For i As Integer = 1 To OffHandCount
                    If OffHandWield(i) <> Weapons.Wield.NotSet Then _Character.Components.AnalyseArms(Me.OffHandItem(i).Item)
                Next

                'If Not _Buckler.Item.IsEmpty Then _Character.Components.AnalyseArms(Me.Buckler.Item)

                'validate them and recalculate
                _Character.Components.CheckConditions_CalculateModifiers(True)

                'init the attacks
                _Attacks.Init(_Character, _WeaponProficiency)

                'main hand
                Select Case _PrimaryWield

                    Case Weapons.Wield.NotSet
                        If WeaponsObj.Element("DisablePrimary") = "Yes" Then
                            Display.Line1 = "No Primary Weapon."
                        Else
                            Display.Line1 = "Primary-hand available."
                        End If

                    Case Weapons.Wield.DoubleWeapon

                        Display.Line1 = Me.DoConfigurationDisplay(_PrimaryWeapon, _Attacks.Attacks, _PrimaryWield)
                        Display.Line1 &= (Environment.NewLine & Me.DoConfigurationDisplay(_OffHandItem, _Attacks.OffHandAttacks, _OffHandWield))
                        Display.Line3 = GetModifierString(_PrimaryWeapon)

                    Case Else
                        Display.Line1 = Me.DoConfigurationDisplay(_PrimaryWeapon, _Attacks.Attacks, _PrimaryWield)
                        Display.Line3 = GetModifierString(_PrimaryWeapon)

                End Select

                'off hands
                For i As Integer = 1 To OffHandCount
                    If Display.Line2 <> "" Then Display.Line2 &= Environment.NewLine

                    Select Case (OffHandWield(i))
                        Case Weapons.Wield.NotSet
                            Display.Line2 &= "Hand available"
                        Case Else
                            Display.Line2 &= Me.DoConfigurationDisplay(OffHandItem(i), _Attacks.OffHandAttacks(i), OffHandWield(i))

                            If Display.Line3 = "" Then
                                Display.Line3 = GetModifierString(OffHandItem(i))
                            Else
                                Display.Line3 &= (Environment.NewLine & GetModifierString(OffHandItem(i)))
                            End If

                    End Select

                Next

                'buckler
                'If Not _Buckler.Item.IsEmpty Then
                '    Display.Line4 = "Wearing buckler."
                'End If

                Return Display
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get attack data - for XML output
        Public Overrides Function InitAndGetAttacks() As Attacks
            Try
                _Attacks.Weapons = Me

                'reset character
                _Character.Components = _BaseLineComponents.Clone
                _Character.Modifiers.Calculate(True)

                'load any components from the weapons
                If _PrimaryWield <> Wield.NotSet Then _Character.Components.AnalyseArms(Me.PrimaryWeapon.Item)
                For i As Integer = 1 To OffHandCount
                    If OffHandWield(i) <> Weapons.Wield.NotSet Then _Character.Components.AnalyseArms(Me.OffHandItem(i).Item)
                Next

                'validate them and recalculate
                _Character.Components.CheckConditions_CalculateModifiers(True)

                'init the attacks
                _Attacks.Init(_Character, _WeaponProficiency)

                Return _Attacks

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'this function does the actual retrieval and formatting of weapon details
        Private Function DoConfigurationDisplay(ByVal WeaponsData As WeaponsData, ByRef Attacks As ArrayList, ByVal Wield As Wield) As String

            Dim Properties As WeaponProperties = WeaponsData.Properties

            'name
            Dim Display As String = WeaponName(WeaponsData)

            'enhancement
            Dim Enhancement As Integer = Properties.Enhancement

            'wield
            If WeaponsData.IsNatural Then
                If WeaponsData.Hand = Weapons.Hand.Primary Then
                    Display &= ", " & "Primary Natural"
                Else
                    Display &= ", " & "Secondary Natural"
                End If
            Else
                If Not (Wield = Wield.Shield Or Wield = Wield.ShieldBash) Then Display &= ", " & GetWieldString(Wield)
            End If

            'improvised melee
            If WeaponsData.ImprovisedMelee Then Display &= " [Improvised Melee]"

            Dim Temp As String
            Dim Damage As String = ""
            Dim Critical As String = ""
            Dim ExtraDamage As String = ""
            Dim Range As String = ""
            Dim Thrown As Boolean

            If Wield <> Wield.Shield Then

                If Attacks Is Nothing Then
                    Display &= " - Cannot make any attacks with this weapon due to nonability score(s)."
                    Return Display
                End If

                'bane
                If Not WeaponsData.Bane.Equals(Objects.ObjectKey.Empty) Then
                    Dim Bane As New Objects.ObjectData
                    Bane.Load(WeaponsData.Bane)
                    Display &= ", Focus: " & Bane.Name
                End If

                'attacks
                Display &= " - Attacks: " & Rules.Formatting.FormatAttacks(Attacks)

                Damage = Properties.BaseDamage
                If Damage <> "" Then

                    'base damage, lethality, damage type
                    Display &= "; Damage: " & Damage & " " & Properties.DamageType

                    'critical and critical damage
                    Critical = Rules.Formatting.FormatCriticalRange(Properties.Critical)
                    Display &= "; Critical: " & Critical
                End If

                'extra damage
                ExtraDamage = Properties.DamageAddition
                If ExtraDamage <> "" Then
                    If Damage = "" Then
                        Display &= "; Damage: " & ExtraDamage
                    Else
                        Display &= "; Extra Damage: " & ExtraDamage
                    End If
                End If

                'range
                Range = Properties.Range
                Thrown = False

                If Range <> "" Then
                    If Properties.Thrown Then Thrown = True
                    Display &= "; Range: " & Range
                End If

                'reach
                Temp = Properties.ReachRange
                If Temp <> "" Then Display &= "; Reach: " & Temp

                'alignment
                Temp = Properties.Alignment
                If Temp <> "" Then Display &= "; Alignment: " & Temp

                'abilities
                Temp = Properties.Abilities
                If Temp <> "" Then Display &= "; Abilities: " & Temp

                'special 
                Temp = Properties.Special
                If Temp <> "" Then Display &= "; Special: " & Temp
            End If

            'spell resistance
            Temp = Properties.SpellResistance
            If Temp <> "0" Then Display &= "; Spell Resistance: " & Temp

            'damage resistance
            Temp = Properties.DamageResistances
            If Temp <> "" Then Display &= "; Damage Resistance: " & Temp

            'modifiers
            'Temp = Properties.Modifiers
            'If Temp <> "" Then Display &= "; Modifiers: " & Temp

            'conditions
            If Properties.Conditions.Count > 0 Then
                For Each Condition As WeaponProperties In Properties.Conditions
                    Display &= "; " & Condition.Condition.Name & " ("
                    Properties = Condition

                    If Wield <> Wield.Shield Then

                        'Conditional Enhancment
                        Dim ConditionEnhancement As Integer = Properties.Enhancement
                        If ConditionEnhancement > 0 And ConditionEnhancement <> Enhancement Then
                            Display &= Rules.Formatting.FormatModifier(ConditionEnhancement) & " Weapon"
                        End If

                        'base damage
                        Temp = Properties.BaseDamage
                        If Temp <> Damage Then
                            If Not Display.EndsWith("(") Then Display &= "; "
                            Display &= "Damage: " & Temp
                        End If

                        'critical and critical damage
                        Temp = Rules.Formatting.FormatCriticalRange(Properties.Critical)
                        If Temp <> Critical Then
                            If Not Display.EndsWith("(") Then Display &= "; "
                            Display &= "Critical: " & Temp
                        End If

                        'extra damage
                        ExtraDamage = Properties.DamageAddition
                        If ExtraDamage <> "" Then
                            If Not Display.EndsWith("(") Then Display &= "; "
                            Display &= "Extra Damage: " & ExtraDamage
                        End If

                        'abilities
                        Temp = Properties.Abilities
                        If Temp <> "" Then
                            If Not Display.EndsWith("(") Then Display &= "; "
                            Display &= "Abilities: " & Temp
                        End If

                        'special 
                        Temp = Properties.Special
                        If Temp <> "" Then
                            If Not Display.EndsWith("(") Then Display &= "; "
                            Display &= "Special: " & Temp
                        End If
                    End If

                    'spell resistance
                    Temp = Properties.SpellResistance
                    If Temp <> "0" Then
                        If Not Display.EndsWith("(") Then Display &= "; "
                        Display &= "Spell Resistance: " & Temp
                    End If

                    'damage resistance
                    Temp = Properties.DamageResistances
                    If Temp <> "" Then
                        If Not Display.EndsWith("(") Then Display &= "; "
                        Display &= "Damage Resistance: " & Temp
                    End If

                    'modifiers
                    'Temp = Properties.Modifiers
                    'If Temp <> "" Then
                    '    If Not Display.EndsWith("(") Then Display &= "; "
                    '    Display &= "Modifiers: " & Temp
                    'End If

                    Display &= ")"
                Next
            End If

            Return Display

        End Function

        'gets the modifer string for a weapon - if string is not empty it containts a newline character at the end
        Private Function GetModifierString(ByVal Weapon As WeaponsData) As String
            Try
                GetModifierString = ""
                For Each Modifier As String In Weapon.Properties.Modifiers
                    GetModifierString &= "Modifier: " & Modifier & " (" & SimpleWeaponName(Weapon) & ")" & Environment.NewLine
                Next
                For Each Condition As WeaponProperties In Weapon.Properties.Conditions
                    For Each Modifier As String In Condition.Modifiers
                        GetModifierString &= "Modifier: " & Modifier & " (" & SimpleWeaponName(Weapon) & ")" & " <" & Condition.Condition.Name & ">" & Environment.NewLine
                    Next
                Next
                Return GetModifierString.TrimEnd(Environment.NewLine.ToCharArray)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function



    End Class

End Namespace