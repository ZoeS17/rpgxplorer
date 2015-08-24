Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class Weapons

        'this class handles weapon configurations and information

#Region "Structures"

        Public Structure AttackDamageModifier
            Public AttackRoll As Integer
            Public DamageRoll As Integer
            Public Description As String
        End Structure

        Public Structure DisplayDetails
            Public Line1 As String
            Public Line2 As String
            Public Line3 As String
            Public Line4 As String

            Public Function IsEmpty() As Boolean
                Try
                    If Line1 = "" And Line2 = "" And Line3 = "" Then Return True Else Return False
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function
        End Structure

        Public Structure WeaponsData
            Public Item As Objects.ObjectData
            Public BaseItem As Objects.ObjectData
            Public InventoryItem As Objects.ObjectData
            Public Hand As Hand
            Public WeaponSize As String
            Public Masterwork As Boolean
            Public Enhancement As Integer
            Public WieldData As WieldData
            Public Properties As WeaponProperties
            Public Weapons As Weapons
            Public Bane As Objects.ObjectKey
            Public ImprovisedMelee As Boolean
            Public DisableFlurry As Boolean
            Public DisableFinesse As Boolean

            'natural weapon variables
            Public AttackNumber As Integer
            Public OffHandSTRMod As STRBonus
            Public PrimaryHandSTRMod As STRBonus


            Public Sub Clear()
                Try
                    Item = Nothing
                    BaseItem = Nothing
                    InventoryItem = Nothing
                    Hand = Hand.NotSet
                    WeaponSize = ""
                    Masterwork = False
                    Enhancement = 0
                    WieldData.WieldType = WieldType.NotSet
                    WieldData.SizePenalty = 0
                    Properties = Nothing
                    Weapons = Nothing
                    Bane = Nothing
                    ImprovisedMelee = False
                    DisableFlurry = False
                    DisableFinesse = False

                    AttackNumber = 0
                    OffHandSTRMod = STRBonus.Full
                    PrimaryHandSTRMod = STRBonus.Full
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Sub

            Public Function IsEmpty() As Boolean
                Try
                    Return BaseItem.IsEmpty
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

            Public Function IsNatural() As Boolean
                Try

                    If Not IsEmpty() Then
                        If BaseItem.ObjectGUID.Database = Xml.DBTypes.NaturalWeapons Then
                            Return True
                        End If
                    End If

                    Return False

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

        End Structure

        Public Structure WieldData
            Public WieldType As WieldType
            Public SizePenalty As Integer
        End Structure

#End Region

#Region "Enumerations"

        Public Enum Hand
            NotSet
            Primary
            OffHand
            Buckler
        End Enum

        Public Enum Wield
            NotSet
            OneHanded
            TwoHanded
            DoubleWeapon
            Thrown
            Shield
            ShieldBash
        End Enum

        Public Enum WieldType
            NotSet
            CannotUse
            LightMelee
            OneHandedMelee
            OneHandedMeleeFinesse
            OneHandedMeleeFinesseRestricted
            TwoHanded
            DoubleWeapon
            OneHandedRanged
            TwoHandedRangedFireOneHandedLight
            TwoHandedRangedFireOneHandedHeavy
            TwoHandedRanged
            Shield
            LightShield
            Buckler
            TwoHandedMeleeFinesse
            DoubleWeaponFinesse
        End Enum

        Public Enum STRBonus
            Full
            Half
            Max
            None
        End Enum

#End Region

#Region "Member Variables"

        <CLSCompliant(False)> Public Shared _Character As Character
        <CLSCompliant(False)> Public Shared _Inventory As Inventory
        <CLSCompliant(False)> Public Shared _BaseLineComponents As Components
        <CLSCompliant(False)> Public Shared _Attacks As Attacks
        <CLSCompliant(False)> Public Shared _WeaponsFolder As Objects.ObjectKey

        <CLSCompliant(False)> Public _PrimaryWeapon, _OffHandItem, _Buckler As WeaponsData
        <CLSCompliant(False)> Public _PrimaryWield, _OffHandWield As Wield
        <CLSCompliant(False)> Public _WeaponProficiency As Rules.Proficiency

        Public Shared IsLoading As Boolean = False
        <CLSCompliant(False)> Public _Index As Integer
        Public WeaponsObj As Objects.ObjectData

#End Region

#Region "Properties"

        'index
        Public Property Index() As Integer
            Get
                Return _Index
            End Get
            Set(ByVal Value As Integer)
                _Index = Value
            End Set
        End Property

        'primary weapon
        Public Property PrimaryWeapon() As WeaponsData
            Get
                Return _PrimaryWeapon
            End Get
            Set(ByVal Value As WeaponsData)
                Try
                    _PrimaryWeapon = Value
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Set
        End Property

        'primary weapon wield
        Public Property PrimaryWield() As Wield
            Get
                Return _PrimaryWield
            End Get
            Set(ByVal Value As Wield)
                Try
                    _PrimaryWield = Value
                    If Not IsLoading Then
                        Select Case Value
                            Case Wield.OneHanded
                                If _OffHandWield = Wield.DoubleWeapon Then
                                    _OffHandWield = Wield.NotSet
                                    _OffHandItem.Clear()
                                End If
                            Case Wield.ShieldBash
                                _OffHandWield = Wield.NotSet
                                _OffHandItem.Clear()
                                If BucklerWielded Then _Buckler = Nothing
                            Case Wield.DoubleWeapon
                                _OffHandWield = Wield.DoubleWeapon
                                _OffHandItem = _PrimaryWeapon
                                _OffHandItem.Hand = Hand.OffHand
                                _OffHandItem.Properties = New Rules.WeaponProperties(_OffHandItem, _Character, WeaponProperties.InitMode.Weapons, Wield.DoubleWeapon)
                            Case Wield.TwoHanded
                                _OffHandWield = Wield.NotSet
                                _OffHandItem.Clear()
                        End Select
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Set
        End Property

        'off hand item
        Public Overridable Property OffHandItem() As WeaponsData
            Get
                Return _OffHandItem
            End Get
            Set(ByVal Value As WeaponsData)
                Try
                    If Value.BaseItem.Type = Objects.ShieldDefinitionType Then
                        _Buckler.Clear()
                    End If
                    _OffHandItem = Value
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Set
        End Property

        'offhand weapon wield
        Public Property OffHandWield() As Wield
            Get
                Return _OffHandWield
            End Get
            Set(ByVal Value As Wield)
                If Not IsLoading Then
                    If Value <> Wield.NotSet And (_PrimaryWield = Wield.DoubleWeapon Or _PrimaryWield = Wield.TwoHanded) Then
                        _PrimaryWeapon.Clear()
                        _PrimaryWield = Wield.NotSet
                    End If

                    If _PrimaryWield = Wield.ShieldBash Then
                        _PrimaryWield = Wield.NotSet
                        _PrimaryWeapon.Clear()
                    End If
                    If BucklerWielded Then _Buckler = Nothing
                End If

                _OffHandWield = Value
            End Set
        End Property

        'buckler
        Public Property Buckler() As WeaponsData
            Get
                Return _Buckler
            End Get
            Set(ByVal Value As WeaponsData)
                Try
                    If _OffHandWield = Wield.Shield Or _OffHandWield = Wield.ShieldBash Then
                        _OffHandWield = Wield.NotSet
                        _OffHandItem.Clear()
                    End If
                    If _PrimaryWield = Wield.ShieldBash Then
                        _PrimaryWield = Wield.NotSet
                        _PrimaryWeapon.Clear()
                    End If
                    _Buckler = Value
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Set
        End Property

        'buckler wield
        Public ReadOnly Property BucklerWielded() As Boolean
            Get
                If _Buckler.IsEmpty Then Return False Else Return True
            End Get
        End Property

        'is a monk attack possible with current configuration?
        Public Overridable ReadOnly Property MonkAttackPossible() As Boolean
            Get
                If Not (_Inventory.Unarmored And _Attacks.FlurryOfBlows) Then Return False
                If _PrimaryWeapon.DisableFlurry Then Return False
                If BucklerWielded Then Return False

                If Not _PrimaryWeapon.IsEmpty Then
                    If Not _PrimaryWeapon.Properties.MonkWeapon Then Return False
                End If

                If Not _OffHandItem.IsEmpty Then
                    If Not _OffHandItem.Properties.MonkWeapon Then Return False
                End If

                Return True
            End Get
        End Property

        'is flurry of blows available
        Public ReadOnly Property FlurryAvailable() As Boolean
            Get
                Return _Attacks.FlurryOfBlows
            End Get
        End Property

        'is the character two weapon fighting?
        Public Overridable ReadOnly Property TwoWeaponFighting() As Boolean
            Get
                Try
                    If _PrimaryWield = Wield.DoubleWeapon Or ((_PrimaryWield = Wield.OneHanded Or _PrimaryWield = Wield.Thrown) And (_OffHandWield = Wield.OneHanded Or _OffHandWield = Wield.ShieldBash Or _OffHandWield = Wield.Thrown)) Then Return True Else Return False
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'is off hand weapon light?
        Public Overridable ReadOnly Property OffHandWeaponLight() As Boolean
            Get
                Try

                    If _PrimaryWield = Wield.DoubleWeapon OrElse (_OffHandWield = Wield.OneHanded AndAlso (_OffHandItem.WieldData.WieldType = WieldType.LightMelee OrElse _Character.Components.SystemAbilities(References.OversizedTwoWeaponFighting))) OrElse (_OffHandWield = Wield.ShieldBash AndAlso _OffHandItem.WieldData.WieldType = WieldType.LightShield) Then
                        Return True
                    Else
                        Return False
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

#End Region

        'init
        Public Overridable Sub Init(ByVal Character As Character, ByRef WeaponProficiency As Rules.Proficiency, ByRef Inventory As Inventory, ByVal WeaponsFolder As Objects.ObjectKey, ByVal BaseLineComponents As Rules.Components)
            Try
                _Character = Character
                _WeaponsFolder = WeaponsFolder
                _Attacks = New Attacks
                _Inventory = Inventory
                _WeaponProficiency = WeaponProficiency
                _BaseLineComponents = BaseLineComponents
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load 
        Public Overridable Sub Load(ByVal Obj As Objects.ObjectData)
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
                    WeaponData.WeaponSize = WeaponsObj.Element("PrimarySize")
                    WeaponData.WieldData = GetWieldData(WeaponData.BaseItem, WeaponData.WeaponSize)
                    If WeaponsObj.Element("DisableFinesse") = "Yes" Then WeaponData.DisableFinesse = True
                    WeaponData.Properties = New WeaponProperties(WeaponData, _Character, WeaponProperties.InitMode.Weapons)
                    WeaponData.Bane = WeaponsObj.GetFKGuid("PrimaryBane")
                    If WeaponsObj.Element("PrimaryImprovisedMelee") = "Yes" Then WeaponData.ImprovisedMelee = True
                    If WeaponsObj.Element("DisableFlurry") = "Yes" Then WeaponData.DisableFlurry = True

                    PrimaryWeapon = WeaponData
                    PrimaryWield = CType(WeaponsObj.ElementAsInteger("PrimaryWield"), Wield)
                End If

                WeaponData.Clear()

                'offhand
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

                'buckler
                If WeaponsObj.Element("Buckler") <> "" Then
                    WeaponData.Item = WeaponsObj.GetFKObject("Buckler")
                    WeaponData.InventoryItem = WeaponsObj.GetFKObject("BucklerInventory")
                    WeaponData.BaseItem = CommonLogic.GetBaseWeaponOrArmor(WeaponData.Item)
                    WeaponData.Hand = Hand.Buckler
                    If WeaponsObj.Element("BucklerMasterwork") = "Yes" Then WeaponData.Masterwork = True
                    WeaponData.Enhancement = WeaponsObj.ElementAsInteger("BucklerEnhancement")
                    WeaponData.Weapons = Me
                    WeaponData.WeaponSize = WeaponsObj.Element("BucklerSize")
                    WeaponData.WieldData = GetWieldData(WeaponData.BaseItem, WeaponData.WeaponSize)
                    WeaponData.Properties = New WeaponProperties(WeaponData, _Character, WeaponProperties.InitMode.Weapons)
                    Buckler = WeaponData
                End If

                _PrimaryWeapon.Weapons = Me
                _OffHandItem.Weapons = Me
                _Buckler.Weapons = Me

                IsLoading = False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save
        Public Overridable Sub Save()
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
                End If

                'offhand
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

                'buckler
                If Not _Buckler.Item.IsEmpty Then
                    WeaponsObj.FKElement("Buckler", _Buckler.Item.Name, "Name", _Buckler.Item.ObjectGUID)
                    If _Buckler.InventoryItem.IsNotEmpty Then WeaponsObj.FKElement("BucklerInventory", _Buckler.InventoryItem.Name, "Name", _Buckler.InventoryItem.ObjectGUID) Else WeaponsObj.FKSetNull("BucklerInventory")
                    If _Buckler.Masterwork Then WeaponsObj.Element("BucklerMasterwork") = "Yes" Else WeaponsObj.Element("BucklerMasterwork") = ""
                    WeaponsObj.ElementAsInteger("BucklerEnhancement") = _Buckler.Enhancement
                    WeaponsObj.Element("BucklerSize") = _Buckler.WeaponSize
                Else
                    WeaponsObj.FKSetNull("Buckler")
                    WeaponsObj.FKSetNull("BucklerInventory")
                    WeaponsObj.Element("BucklerMasterwork") = ""
                    WeaponsObj.Element("BucklerEnhancement") = ""
                    WeaponsObj.Element("BucklerSize") = ""
                End If

                WeaponsObj.Save()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'delete
        Public Sub Delete()
            Try
                If Not WeaponsObj.IsEmpty Then WeaponsObj.Delete()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'reset
        Public Overridable Sub Reset()
            Try
                _PrimaryWeapon.Clear()
                _PrimaryWield = Wield.NotSet
                _OffHandItem.Clear()
                _OffHandWield = Wield.NotSet
                _Buckler.Clear()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#Region "Display"

        'details to be displayed in list when selecting a weapon or shield
        Public Function GetDialogItemDisplay(ByVal WeaponData As WeaponsData) As DisplayDetails
            Dim Display As DisplayDetails
            Try
                Display.Line1 = WeaponName(WeaponData)
                If WeaponData.Bane.IsNotEmpty Then
                    Dim Bane As New Objects.ObjectData
                    Bane.Load(WeaponData.Bane)
                    Display.Line1 &= " (Focus: " & Bane.Name & ")"
                End If

                If WeaponData.WieldData.WieldType = WieldType.CannotUse Then
                    Display.Line2 = GetWieldDataDisplayString(WeaponData.WieldData.WieldType)
                Else
                    If WeaponData.BaseItem.Element("Training") = "Shield" Then
                        Display.Line2 = GetWieldDataDisplayString(WeaponData.WieldData.WieldType)
                    Else
                        Display.Line2 = WeaponData.BaseItem.Element("Training") & ", " & GetWieldDataDisplayString(WeaponData.WieldData.WieldType)
                    End If
                End If

                If WeaponData.Properties.BaseDamageForList = "" Then
                    Display.Line3 = WeaponData.Properties.DamageTypeForList
                Else
                    Display.Line3 = WeaponData.Properties.BaseDamageForList.ToString & " " & WeaponData.Properties.DamageTypeForList
                End If

                Display.Line4 = WeaponData.Properties.BasicProperties

                Return Display

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'configuration description text
        Public Overridable Function GetConfigurationDisplay() As DisplayDetails
            Dim Display As New DisplayDetails
            Dim ModString As String = ""

            Try
                _Attacks.Weapons = Me

                'reset character
                _Character.Components = _BaseLineComponents.Clone
                _Character.Modifiers.Calculate(True)

                'load any components from the weapons
                If _PrimaryWield <> Wield.NotSet Then _Character.Components.AnalyseArms(Me.PrimaryWeapon.Item)
                If _OffHandWield <> Wield.NotSet Then
                    If _OffHandWield <> Wield.DoubleWeapon Then
                        _Character.Components.AnalyseArms(Me.OffHandItem.Item)
                    End If
                End If

                If Not _Buckler.Item.IsEmpty Then _Character.Components.AnalyseArms(Me.Buckler.Item)

                'validate them and recalculate
                _Character.Components.CheckConditions_CalculateModifiers(True)

                'init the attacks
                _Attacks.Init(_Character, _WeaponProficiency)

                'main hand
                If _PrimaryWield = Wield.NotSet Then
                    Display.Line1 = "Primary-hand available."
                Else
                    Display.Line1 = Me.DoConfigurationDisplay(_PrimaryWeapon, _Attacks.Attacks, _PrimaryWield)
                    Display.Line3 = GetModifierString(_PrimaryWeapon)
                End If

                'off hand 
                Select Case _OffHandWield
                    Case Wield.NotSet
                        If _PrimaryWield = Wield.TwoHanded Then
                            Display.Line2 = "Off-hand in use."
                        Else
                            Display.Line2 = "Off-hand available."
                        End If
                    Case Wield.DoubleWeapon
                        Display.Line2 = Me.DoConfigurationDisplay(_OffHandItem, _Attacks.OffHandAttacks, _OffHandWield)
                    Case Else
                        Display.Line2 = Me.DoConfigurationDisplay(_OffHandItem, _Attacks.OffHandAttacks, _OffHandWield)
                        If Display.Line3 = "" Then
                            Display.Line3 = GetModifierString(_OffHandItem)
                        Else
                            Display.Line3 &= (Environment.NewLine & GetModifierString(_OffHandItem))
                        End If
                End Select

                'buckler
                If Not _Buckler.Item.IsEmpty Then
                    Display.Line4 = "Wearing buckler."
                End If

                Return Display
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
            If Not (Wield = Wield.Shield Or Wield = Wield.ShieldBash) Then Display &= ", " & GetWieldString(Wield)

            'improvised melee
            If WeaponsData.ImprovisedMelee Then Display &= " [Improvised Melee]"

            Dim Temp As String
            Dim Damage As String = ""
            Dim Critical As String = ""
            Dim ExtraDamage, Range As String
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

                    'extra damage
                    ExtraDamage = Properties.DamageAddition
                    If ExtraDamage <> "" Then
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

        'weapon name, enhancement, masterwork, size
        Public Function WeaponName(ByVal WeaponData As WeaponsData) As String
            Try

                'if no weapon, return empty string
                If WeaponData.IsEmpty Then Return ""

                'weapon name
                If WeaponData.InventoryItem.IsEmpty Then

                    If WeaponData.IsNatural Then
                        If WeaponData.Item.Element("OverrideName") = "True" Then
                            WeaponName = WeaponData.Item.Name
                        Else
                            WeaponName = WeaponData.Item.Element("AttackType")
                        End If
                    Else
                        WeaponName = WeaponData.Item.Name
                    End If

                    'append enhancement or masterwork
                    If WeaponData.Item.Type <> Objects.ItemType Then
                        If WeaponData.Enhancement > 0 Then
                            WeaponName &= " " & Rules.Formatting.FormatModifier(WeaponData.Enhancement)
                            If WeaponData.Properties.DoubleWeapon Then WeaponName &= "/" & Rules.Formatting.FormatModifier(WeaponData.Enhancement)
                        ElseIf WeaponData.Masterwork Then
                            WeaponName &= ", Masterwork"
                        End If
                    End If

                    'if it has more than one attack, add the attack number
                    If WeaponData.AttackNumber > 1 Then
                        WeaponName &= (" x" & WeaponData.AttackNumber.ToString)
                    End If

                Else
                    WeaponName = WeaponData.InventoryItem.Name
                End If

                If WeaponData.WeaponSize <> _Character.Size Then
                    WeaponName &= ", " & WeaponData.WeaponSize
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'weapon name lite
        Public Function SimpleWeaponName(ByVal WeaponData As WeaponsData) As String
            Try

                'if no weapon, return empty string
                If WeaponData.IsEmpty Then Return ""

                'weapon name
                If WeaponData.InventoryItem.IsEmpty Then
                    SimpleWeaponName = WeaponData.Item.Name
                Else
                    SimpleWeaponName = WeaponData.InventoryItem.Name
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
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

        'get attack data - for XML output
        Public Overridable Function InitAndGetAttacks() As Attacks
            Try
                _Attacks.Weapons = Me

                'reset character
                _Character.Components = _BaseLineComponents.Clone
                _Character.Modifiers.Calculate(True)

                'load any components from the weapons               
                If _PrimaryWield <> Wield.NotSet Then _Character.Components.AnalyseArms(Me.PrimaryWeapon.Item)
                If _OffHandWield <> Wield.NotSet Then
                    If _OffHandWield <> Wield.DoubleWeapon Then
                        _Character.Components.AnalyseArms(Me.OffHandItem.Item)
                    End If
                End If

                If Not _Buckler.Item.IsEmpty Then _Character.Components.AnalyseArms(Me.Buckler.Item)

                'validate them and recalculate
                _Character.Components.CheckConditions_CalculateModifiers(True)

                'init the attacks
                _Attacks.Init(_Character, _WeaponProficiency)

                Return _Attacks

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

#Region "Wield"

        Private Shared Function ConvertSizeToValue(ByVal size As String) As Integer
            Try
                Select Case size
                    Case "Fine"
                        Return 1
                    Case "Diminutive"
                        Return 2
                    Case "Tiny"
                        Return 3
                    Case "Small"
                        Return 4
                    Case "Medium"
                        Return 5
                    Case "Large"
                        Return 6
                    Case "Huge"
                        Return 7
                    Case "Gargantuan"
                        Return 8
                    Case "Colossal"
                        Return 9
                End Select

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function


        'get details about the weapon relating to wielding
        Public Shared Function GetWieldData(ByVal Item As Objects.ObjectData, ByVal WeaponSize As String, Optional ByVal SimianGrasp As Boolean = False) As WieldData
            Dim WieldData As WieldData

            Try
                If Item.IsEmpty Then
                    WieldData.WieldType = WieldType.NotSet
                    Return WieldData
                End If

                Item = CommonLogic.GetBaseWeaponOrArmor(Item)

                If Item.Type = Objects.ShieldDefinitionType Then
                    'shields
                    If Item.Element("WieldWeapon") = "Yes" Then
                        WieldData.WieldType = WieldType.Buckler
                    ElseIf Item.Element("HoldItem") = "Yes" Then
                        WieldData.WieldType = WieldType.LightShield
                    Else
                        WieldData.WieldType = WieldType.Shield
                    End If
                ElseIf Item.Type = Objects.NaturalWeaponDefinitionType Then

                    'check if it is a ranged or melee natural attack
                    If Item.Element("NaturalRanged") = "True" Then
                        WieldData.WieldType = WieldType.OneHandedRanged
                    Else
                        WieldData.WieldType = WieldType.OneHandedMeleeFinesse
                    End If

                    Return WieldData

                Else
                    'weapons
                    Select Case Item.Element("Encumbrance")
                        Case "Light"
                            'light melee
                            WieldData.WieldType = WieldType.LightMelee
                        Case "One-Handed"
                            'one handed melee or ranged
                            If Item.Element("WeaponType") = "Melee" Then
                                If Item.Element("Finesse") = "Yes" Then
                                    If Item.Element("FinesseTwoHanded") = "Yes" Then
                                        WieldData.WieldType = WieldType.OneHandedMeleeFinesse
                                    Else
                                        WieldData.WieldType = WieldType.OneHandedMeleeFinesseRestricted
                                    End If
                                Else
                                    WieldData.WieldType = WieldType.OneHandedMelee
                                End If
                            Else
                                WieldData.WieldType = WieldType.OneHandedRanged
                            End If
                        Case "Two-Handed"
                            'two-handed melee
                            If Item.Element("Double") = "Yes" Then
                                If Item.Element("Finesse") = "Yes" Then
                                    WieldData.WieldType = WieldType.DoubleWeaponFinesse
                                Else
                                    WieldData.WieldType = WieldType.DoubleWeapon
                                End If
                            Else
                                If Item.Element("Finesse") = "Yes" Then
                                    WieldData.WieldType = WieldType.TwoHandedMeleeFinesse
                                Else
                                    WieldData.WieldType = WieldType.TwoHanded
                                End If
                            End If
                        Case "Two-Handed (Light for 1 Hand Fire)"
                            WieldData.WieldType = WieldType.TwoHandedRangedFireOneHandedLight
                        Case "Two-Handed (Heavy for 1 Hand Fire)"
                            WieldData.WieldType = WieldType.TwoHandedRangedFireOneHandedHeavy
                        Case "Two-Handed Only"
                            WieldData.WieldType = WieldType.TwoHandedRanged
                    End Select
                End If

                'natural weapons are always the size of the creature - so we return before here
                Dim SizeDifference As Integer = ConvertSizeToValue(_Character.Size) - ConvertSizeToValue(WeaponSize)
                Select Case SizeDifference
                    Case -2 'Two sizes bigger
                        Select Case WieldData.WieldType
                            Case WieldType.LightMelee
                                WieldData.WieldType = WieldType.TwoHanded
                                WieldData.SizePenalty = -4
                            Case Else
                                WieldData.WieldType = WieldType.CannotUse
                        End Select
                    Case -1 'One size bigger
                        If SimianGrasp Then
                            WieldData.SizePenalty = -2
                        Else
                            Select Case WieldData.WieldType
                                Case WieldType.LightMelee
                                    WieldData.WieldType = WieldType.OneHandedMelee
                                    WieldData.SizePenalty = -2
                                Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                                    WieldData.WieldType = WieldType.TwoHanded
                                    WieldData.SizePenalty = -2
                                Case WieldType.OneHandedRanged
                                    WieldData.WieldType = WieldType.TwoHandedRanged
                                    WieldData.SizePenalty = -2
                                Case Else
                                    WieldData.WieldType = WieldType.CannotUse
                            End Select
                        End If
                    Case 0
                        'do nothing - correct weapon size
                    Case 1 'One size smaller
                        Select Case WieldData.WieldType
                            Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                                WieldData.WieldType = WieldType.LightMelee
                                WieldData.SizePenalty = -2
                            Case WieldType.OneHandedRanged
                                WieldData.SizePenalty = -2
                            Case WieldType.DoubleWeapon, WieldType.TwoHanded, WieldType.DoubleWeaponFinesse, WieldType.TwoHandedMeleeFinesse
                                WieldData.WieldType = WieldType.OneHandedMelee
                                WieldData.SizePenalty = -2
                            Case Else
                                WieldData.WieldType = WieldType.CannotUse
                        End Select
                    Case 2 'Two sizes smaller
                        Select Case WieldData.WieldType
                            Case WieldType.TwoHanded, WieldType.DoubleWeapon, WieldType.TwoHandedMeleeFinesse, WieldType.DoubleWeaponFinesse
                                WieldData.WieldType = WieldType.LightMelee
                                WieldData.SizePenalty = -4
                            Case Else
                                WieldData.WieldType = WieldType.CannotUse
                        End Select
                    Case Else
                        WieldData.WieldType = WieldType.CannotUse
                End Select

                'adjust for weapon and character size
                'If SimianGrasp Then
                '    Select Case _Character.Size
                '        Case "Small"
                '            Select Case WeaponSize
                '                Case "Medium"
                '                    WieldData.SizePenalty = -2
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.LightMelee
                '                            WieldData.WieldType = WieldType.TwoHanded
                '                            WieldData.SizePenalty = -4
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '            End Select
                '        Case "Medium"
                '            Select Case WeaponSize
                '                Case "Small"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                '                            WieldData.WieldType = WieldType.LightMelee
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedRanged
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.DoubleWeapon, WieldType.TwoHanded, WieldType.DoubleWeaponFinesse, WieldType.TwoHandedMeleeFinesse
                '                            WieldData.WieldType = WieldType.OneHandedMelee
                '                            WieldData.SizePenalty = -2
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '                Case "Large"
                '                    WieldData.SizePenalty = -2
                '            End Select

                '        Case "Large"
                '            Select Case WeaponSize
                '                Case "Small"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.TwoHanded, WieldType.DoubleWeapon, WieldType.TwoHandedMeleeFinesse, WieldType.DoubleWeaponFinesse
                '                            WieldData.WieldType = WieldType.LightMelee
                '                            WieldData.SizePenalty = -4
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '                Case "Medium"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                '                            WieldData.WieldType = WieldType.LightMelee
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedRanged
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.TwoHanded, WieldType.DoubleWeapon, WieldType.DoubleWeaponFinesse, WieldType.TwoHandedMeleeFinesse
                '                            WieldData.WieldType = WieldType.OneHandedMelee
                '                            WieldData.SizePenalty = -2
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '            End Select
                '        Case Else
                '            WieldData.WieldType = WieldType.NotSet
                '    End Select

                'Else

                '    Select Case _Character.Size
                '        Case "Small"
                '            Select Case WeaponSize
                '                Case "Medium"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.LightMelee
                '                            WieldData.WieldType = WieldType.OneHandedMelee
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                '                            WieldData.WieldType = WieldType.TwoHanded
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedRanged
                '                            WieldData.WieldType = WieldType.TwoHandedRanged
                '                            WieldData.SizePenalty = -2
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '                Case "Large"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.LightMelee
                '                            WieldData.WieldType = WieldType.TwoHanded
                '                            WieldData.SizePenalty = -4
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '            End Select
                '        Case "Medium"
                '            Select Case WeaponSize
                '                Case "Small"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                '                            WieldData.WieldType = WieldType.LightMelee
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedRanged
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.DoubleWeapon, WieldType.TwoHanded, WieldType.DoubleWeaponFinesse, WieldType.TwoHandedMeleeFinesse
                '                            WieldData.WieldType = WieldType.OneHandedMelee
                '                            WieldData.SizePenalty = -2
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '                Case "Large"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.LightMelee
                '                            WieldData.WieldType = WieldType.OneHandedMelee
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                '                            WieldData.WieldType = WieldType.TwoHanded
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedRanged
                '                            WieldData.WieldType = WieldType.TwoHandedRanged
                '                            WieldData.SizePenalty = -2
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '            End Select

                '        Case "Large"
                '            Select Case WeaponSize
                '                Case "Small"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.TwoHanded, WieldType.DoubleWeapon, WieldType.TwoHandedMeleeFinesse, WieldType.DoubleWeaponFinesse
                '                            WieldData.WieldType = WieldType.LightMelee
                '                            WieldData.SizePenalty = -4
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '                Case "Medium"
                '                    Select Case WieldData.WieldType
                '                        Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                '                            WieldData.WieldType = WieldType.LightMelee
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.OneHandedRanged
                '                            WieldData.SizePenalty = -2
                '                        Case WieldType.TwoHanded, WieldType.DoubleWeapon, WieldType.DoubleWeaponFinesse, WieldType.TwoHandedMeleeFinesse
                '                            WieldData.WieldType = WieldType.OneHandedMelee
                '                            WieldData.SizePenalty = -2
                '                        Case Else
                '                            WieldData.WieldType = WieldType.CannotUse
                '                    End Select
                '            End Select
                '        Case Else
                '            WieldData.WieldType = WieldType.NotSet
                '    End Select
                'End If

                Return WieldData

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'convert wield type into display string
        Public Shared Function GetWieldDataDisplayString(ByVal WieldType As WieldType) As String
            Try
                Select Case WieldType
                    Case WieldType.Buckler
                        Return "Buckler"
                    Case WieldType.CannotUse
                        Return "Cannot Use, Too Large or Small"
                    Case WieldType.DoubleWeapon
                        Return "Double Melee Weapon"
                    Case WieldType.LightMelee
                        Return "Light Melee Weapon"
                    Case WieldType.LightShield
                        Return "Light Shield"
                    Case WieldType.NotSet
                        Return "Not Set"
                    Case WieldType.OneHandedMelee, WieldType.OneHandedMeleeFinesse, WieldType.OneHandedMeleeFinesseRestricted
                        Return "One-Handed Melee Weapon"
                    Case WieldType.OneHandedRanged
                        Return "One-Handed Ranged Weapon"
                    Case WieldType.Shield
                        Return "Heavy Shield"
                    Case WieldType.TwoHanded
                        Return "Two-Handed Melee Weapon"
                    Case WieldType.TwoHandedRanged, WieldType.TwoHandedRangedFireOneHandedHeavy, WieldType.TwoHandedRangedFireOneHandedLight
                        Return "Two-Handed Ranged Weapon"
                End Select
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'convert wield to string
        Public Shared Function GetWieldString(ByVal Wield As Wield) As String
            Select Case Wield
                Case Wield.DoubleWeapon
                    Return "as Double Weapon"
                Case Wield.OneHanded, Wield.ShieldBash
                    Return "One-Handed"
                Case Wield.TwoHanded
                    Return "Two-Handed"
                Case Wield.Shield
                    Return ""
                Case Wield.Thrown
                    Return "Thrown"
            End Select
            Return ""
        End Function

#End Region

    End Class

End Namespace