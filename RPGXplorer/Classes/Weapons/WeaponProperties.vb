Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class WeaponProperties

        'use this class to retrieve weapon abilities, size, wield type etc.

#Region "Enumerations"

        Public Enum InitMode
            List
            Weapons
        End Enum

        Public Enum DoubleWeaponEndType
            Primary
            Secondary
        End Enum

#End Region

#Region "Member Variables"

        Private _Character As Character
        Private _Weapon As Rules.Weapons.WeaponsData
        Private _BaseWeapon As Objects.ObjectData
        Private _WeaponComponents As Components
        Private _Wield As Rules.Weapons.Wield

        'basic properties
        Private _Charge, _DoubleWeapon, _MonkWeapon, _ReachWeapon, _ReachRestricted, _ThrownWeapon, _Shield As Boolean
        Private _Range, _Reach As Integer

        'magic properties
        Private _Alignment As String
        Private _Enhancement As Integer
        Private _EnhancementAdjust As Integer

        'weapon components
        Private _Abilities As ArrayList
        Private _DamageAddition As ArrayList
        Private _DamageResistance As DamageResistance
        Private _Emulations As ArrayList
        Private _Modifiers As ArrayList
        Private _SR As ArrayList

        'material
        Private _Material As Rules.SpecialMaterial

        'system weapon ability flags
        Private Align1, Align2, Cleave, CritDestroys, Critx3, Critx4, CritThreatDoubled, DoubleDamage, HolySR, KiWeapon, Nonlethal, Speed, Throwing, Vicious As Boolean

        'conditions
        Private _Condition As Objects.ObjectData
        Public Conditions As New ArrayList

        'monk
        Public ImprovedUnarmedDamage As Boolean
        'Private DmgSmall, DmgMedium, DmgLarge As Rules.Dice.DiceRange

#End Region

#Region "Structures"

        Public Structure CriticalRange
            Public Threat As Integer
            Public Multiplier As Integer
        End Structure

#End Region

#Region "Properties"

        'magic abilities
        Public ReadOnly Property Abilities() As String
            Get
                If _Abilities.Count = 0 Then Return ""

                _Abilities.Sort()
                Dim Temp As String = ""

                For Each Item As String In _Abilities
                    If Temp <> "" Then Temp &= ", "
                    Temp &= Item
                Next

                Return Temp
            End Get
        End Property

        'alignment and wield penalty
        Public ReadOnly Property Alignment() As String
            Get
                Dim Axis As String = _Weapon.Item.Element("Alignment")

                If Axis = "" Then Return ""

                Dim Conflict As Boolean = CommonLogic.AlignmentConflict(_Alignment, Axis)

                If Align2 And Conflict Then
                    Return Axis & " (2 Negative Levels)"
                ElseIf Align1 And Conflict Then
                    Return Axis & " (1 Negative Level)"
                Else
                    Return Axis
                End If
            End Get
        End Property

        'enhancement
        Public ReadOnly Property Enhancement() As Integer
            Get
                Dim EnhancementMod As Integer = _EnhancementAdjust + _Enhancement
                Return EnhancementBase + EnhancementMod
            End Get
        End Property

        'enhancement
        Private ReadOnly Property EnhancementBase() As Integer
            Get
                If _Weapon.Hand = Weapons.Hand.OffHand And _Weapon.Weapons.PrimaryWield = Weapons.Wield.DoubleWeapon Then
                    Select Case _Weapon.Item.Type
                        Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                            Return _Weapon.Item.ElementAsInteger("DEnhancementBonus")
                        Case Else
                            Return _Weapon.Enhancement
                    End Select
                Else
                    Select Case _Weapon.Item.Type
                        Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                            Return _Weapon.Item.ElementAsInteger("EnhancementBonus")
                        Case Else
                            Return _Weapon.Enhancement
                    End Select
                End If
            End Get
        End Property

        'base damage
        Public ReadOnly Property BaseDamage() As String
            Get
                Dim Flag As Boolean = True

                'determine which damage to return
                Select Case _Weapon.Hand
                    Case Weapons.Hand.Primary
                        Flag = True
                    Case Weapons.Hand.OffHand
                        If _Weapon.Weapons.OffHandWield = Weapons.Wield.DoubleWeapon Then
                            Flag = False
                        Else
                            Flag = True
                        End If
                End Select

                Dim DamageString As String = ""
                Dim Damage As Rules.Dice.DiceRange

                'get damage
                If _Character.ImprovedUnarmedDamage <> "" And _Weapon.BaseItem.ObjectGUID.Equals(References.UnarmedStrike) Then
                    DamageString = _Character.ImprovedUnarmedDamage
                ElseIf _Weapon.BaseItem.Type = Objects.NaturalWeaponDefinitionType Then
                    DamageString = _BaseWeapon.Element("Damage")
                ElseIf Flag Then
                    Select Case _Weapon.WieldData.WieldType
                        Case Weapons.WieldType.LightShield, Weapons.WieldType.Shield
                            Select Case _Weapon.WeaponSize
                                Case "Fine"
                                    DamageString = _BaseWeapon.Element("DamageFine")
                                Case "Diminutive"
                                    DamageString = _BaseWeapon.Element("DamageTiny")
                                Case "Tiny"
                                    DamageString = _BaseWeapon.Element("DamageDiminutive")
                                Case "Small"
                                    DamageString = _BaseWeapon.Element("DamageSmall")
                                Case "Medium"
                                    DamageString = _BaseWeapon.Element("DamageMedium")
                                Case "Large"
                                    DamageString = _BaseWeapon.Element("DamageLarge")
                                Case "Huge"
                                    DamageString = _BaseWeapon.Element("DamageHuge")
                                Case "Gargantuan"
                                    DamageString = _BaseWeapon.Element("DamageGargantuan")
                                Case "Colossal"
                                    DamageString = _BaseWeapon.Element("DamageColossal")
                            End Select
                        Case Else
                            Select Case _Weapon.WeaponSize
                                Case "Fine"
                                    DamageString = _BaseWeapon.Element("FDamage")
                                Case "Diminutive"
                                    DamageString = _BaseWeapon.Element("DDamage")
                                Case "Tiny"
                                    DamageString = _BaseWeapon.Element("TDamage")
                                Case "Small"
                                    DamageString = _BaseWeapon.Element("SDamage")
                                Case "Medium"
                                    DamageString = _BaseWeapon.Element("MDamage")
                                Case "Large"
                                    DamageString = _BaseWeapon.Element("LDamage")
                                Case "Huge"
                                    DamageString = _BaseWeapon.Element("HDamage")
                                Case "Gargantuan"
                                    DamageString = _BaseWeapon.Element("GDamage")
                                Case "Colossal"
                                    DamageString = _BaseWeapon.Element("CDamage")
                            End Select
                    End Select
                Else
                    Select Case _Weapon.WeaponSize
                        Case "Fine"
                            DamageString = _BaseWeapon.Element("DFDamage")
                        Case "Diminutive"
                            DamageString = _BaseWeapon.Element("DDDamage")
                        Case "Tiny"
                            DamageString = _BaseWeapon.Element("DTDamage")
                        Case "Small"
                            DamageString = _BaseWeapon.Element("DSDamage")
                        Case "Medium"
                            DamageString = _BaseWeapon.Element("DMDamage")
                        Case "Large"
                            DamageString = _BaseWeapon.Element("DLDamage")
                        Case "Huge"
                            DamageString = _BaseWeapon.Element("DHDamage")
                        Case "Gargantuan"
                            DamageString = _BaseWeapon.Element("DGDamage")
                        Case "Colossal"
                            DamageString = _BaseWeapon.Element("DCDamage")
                    End Select
                End If

                'check for no damage
                If DamageString = "" OrElse DamageString = "0" Then Return ""

                'convert to dice range
                If Rules.Dice.ValidDiceRange(DamageString) Then
                    Damage = Rules.Dice.GetDiceRange(DamageString)
                Else
                    Damage.Dice = Dice.Dice.NotSet
                    Damage.Modifier = CType(DamageString, Integer)
                End If

                'adjust for double damage
                If DoubleDamage Then
                    If Rules.Dice.ValidDiceRange(DamageString) Then
                        Damage.DiceCount = Damage.DiceCount * 2
                        Damage.Modifier = Damage.Modifier * 2
                    Else
                        Damage.Modifier = Damage.Modifier * 2
                    End If
                End If

                'adjust for modifiers
                Damage.Modifier += _Character.Modifiers.DamageRoll()
                Damage.Modifier += _Character.Modifiers.DamageRollSpecificWeapon(_BaseWeapon.ObjectGUID)

                'adjust for material modifiers
                Dim MaterialDamageEnhancement As Integer
                Dim TempEnhancement As Integer = Enhancement

                If Not Shield Then
                    If Not Material Is Nothing Then
                        MaterialDamageEnhancement = Material.DamageEnhancementAdjustment
                    End If

                    If MaterialDamageEnhancement > 0 Then
                        If MaterialDamageEnhancement > TempEnhancement Then
                            TempEnhancement = MaterialDamageEnhancement
                        End If
                    Else
                        TempEnhancement += MaterialDamageEnhancement
                    End If
                Else
                    TempEnhancement = 0
                End If

                'adjust damage for str, enhancement
                If Rules.Dice.ValidDiceRange(DamageString) Then
                    Damage.Modifier += StrengthModifier() + TempEnhancement
                    BaseDamage = Damage.ToString
                Else
                    Dim Final As Integer = Damage.Modifier + StrengthModifier() + TempEnhancement
                    If Final < 1 Then Final = 1
                    BaseDamage = Final.ToString
                End If
            End Get
        End Property

        'base damage for display in pick list
        Public ReadOnly Property BaseDamageForList() As String
            Get
                Select Case _Weapon.WeaponSize

                    Case "Fine"
                        Return _BaseWeapon.Element("DamageFine")
                    Case "Diminutive"
                        Return _BaseWeapon.Element("DamageDiminutive")
                    Case "Tiny"
                        Return _BaseWeapon.Element("DamageTiny")

                    Case "Small"
                        Return _BaseWeapon.Element("DamageSmall")
                    Case "Medium"
                        Return _BaseWeapon.Element("DamageMedium")
                    Case "Large"
                        Return _BaseWeapon.Element("DamageLarge")

                    Case "Huge"
                        Return _BaseWeapon.Element("DamageHuge")
                    Case "Gargantuan"
                        Return _BaseWeapon.Element("DamageGargantuan")
                    Case "Colossal"
                        Return _BaseWeapon.Element("DamageColossal")
                End Select
                Return ""
            End Get
        End Property

        'condition object
        Public ReadOnly Property Condition() As Objects.ObjectData
            Get
                Return _Condition
            End Get
        End Property

        'critcal threat range and multiplier
        Public ReadOnly Property Critical() As CriticalRange
            Get
                Select Case _Weapon.Hand
                    Case Weapons.Hand.Primary
                        If _BaseWeapon.Type = Objects.ShieldDefinitionType Then
                            Critical.Threat = 20
                            Critical.Multiplier = 2
                        Else
                            Critical.Threat = _BaseWeapon.ElementAsInteger("ThreatRange")
                            Critical.Multiplier = _BaseWeapon.ElementAsInteger("Multiplier")
                        End If
                    Case Weapons.Hand.OffHand
                        If _Weapon.Weapons.OffHandWield = Weapons.Wield.DoubleWeapon Then
                            Critical.Threat = _BaseWeapon.ElementAsInteger("ThreatRange")
                            Critical.Multiplier = _BaseWeapon.ElementAsInteger("DMultiplier")
                        Else
                            If _BaseWeapon.Type = Objects.ShieldDefinitionType Then
                                Critical.Threat = 20
                                Critical.Multiplier = 2
                            Else
                                Critical.Threat = _BaseWeapon.ElementAsInteger("ThreatRange")
                                Critical.Multiplier = _BaseWeapon.ElementAsInteger("Multiplier")
                            End If
                        End If
                End Select

                'apply system weapon abilities
                If Critx4 Then
                    If Critical.Multiplier < 4 Then Critical.Multiplier = 4
                ElseIf Critx3 Then
                    If Critical.Multiplier < 3 Then Critical.Multiplier = 3
                End If

                If CritThreatDoubled Then
                    Select Case Critical.Threat
                        Case 20
                            Critical.Threat = 19
                        Case 19
                            Critical.Threat = 17
                        Case 18
                            Critical.Threat = 15
                    End Select
                End If
            End Get
        End Property

        'buckler penalty
        Public ReadOnly Property BucklerPenalty() As Boolean
            Get
                If _BaseWeapon.Element("BucklerPenalty") = "Yes" Then Return True Else Return False
            End Get
        End Property

        'damage addition string
        Public ReadOnly Property DamageAddition() As String
            Get
                If _DamageAddition.Count = 0 Then Return ""

                _DamageAddition.Sort()
                Dim Temp As String = ""

                For Each Item As String In _DamageAddition
                    If Temp <> "" Then Temp &= ", "
                    Temp &= Item
                Next

                Return Temp
            End Get
        End Property

        'damage resistances
        Public ReadOnly Property DamageResistances() As String
            Get
                Return _DamageResistance.DisplayString
            End Get
        End Property

        'damage type
        Public ReadOnly Property DamageType(Optional ByVal TypeOnly As Boolean = False) As String
            Get
                Dim DmgType As String = _BaseWeapon.Element("DamageType")

                Select Case _Weapon.Hand
                    Case Weapons.Hand.Primary
                        If DmgType.IndexOf("/") <> -1 Then
                            DmgType = DmgType.Substring(0, DmgType.IndexOf("/"))
                        End If
                    Case Weapons.Hand.OffHand
                        If DmgType.IndexOf("/") <> -1 Then
                            DmgType = DmgType.Substring(DmgType.IndexOf("/") + 1, DmgType.Length - DmgType.IndexOf("/") - 1)
                        End If
                End Select

                If TypeOnly Then Return DmgType
                Return Rules.Formatting.FormatDamageType(_BaseWeapon.Element("Damage"), DmgType)
            End Get
        End Property

        'damage type
        Public ReadOnly Property DamageTypeForList() As String
            Get
                Return Rules.Formatting.FormatDamageType(_BaseWeapon.Element("Damage"), _BaseWeapon.Element("DamageType"))
            End Get
        End Property

        'damage lethality - seperate
        Public ReadOnly Property DamageLethality() As String
            Get
                Return _BaseWeapon.Element("Damage")
            End Get
        End Property

        'dex modifier
        Public ReadOnly Property DEXMod() As Integer
            Get
                Return AbilityScores.AbilityScore(_Character.CurrentLevel.DEX).Modifier
            End Get
        End Property

        'double weapon
        Public ReadOnly Property DoubleWeapon() As Boolean
            Get
                Return _DoubleWeapon
            End Get
        End Property

        'shield
        Public ReadOnly Property Shield() As Boolean
            Get
                Return _Shield
            End Get
        End Property

        'end of double weapon being wielded
        Public ReadOnly Property DoubleWeaponEnd() As DoubleWeaponEndType
            Get
                If _Weapon.Hand = Weapons.Hand.OffHand And _Weapon.Weapons.PrimaryWield = Weapons.Wield.DoubleWeapon Then
                    Return DoubleWeaponEndType.Secondary
                Else
                    Return DoubleWeaponEndType.Primary
                End If
            End Get
        End Property

        'finesse weapon
        Public ReadOnly Property UseWeaponFinesse() As Boolean
            Get
                If _Weapon.DisableFinesse Then Return False

                If _Weapon.WeaponSize = _Character.Size Then

                    Select Case _Weapon.WieldData.WieldType
                        Case Weapons.WieldType.OneHandedMeleeFinesse, Weapons.WieldType.LightMelee, Weapons.WieldType.DoubleWeaponFinesse, Weapons.WieldType.TwoHandedMeleeFinesse
                            Return True
                        Case Weapons.WieldType.OneHandedMeleeFinesseRestricted
                            Select Case _Wield
                                Case Weapons.Wield.NotSet, Weapons.Wield.OneHanded
                                    Return True
                                Case Else
                                    Return False
                            End Select
                        Case Weapons.WieldType.DoubleWeapon
                            Select Case _Weapon.Hand
                                Case Weapons.Hand.OffHand
                                    Return True
                                Case Else
                                    Return False
                            End Select
                    End Select
                Else
                    Return False
                End If
            End Get
        End Property

        'fire 2-handed ranged weapon 1-handed penalty
        Public ReadOnly Property FiringPenaltyOneHanded() As Integer
            Get
                Return _BaseWeapon.ElementAsInteger("FireOneHandedPenalty")
            End Get
        End Property

        'material
        Public ReadOnly Property Material() As Rules.SpecialMaterial
            Get
                Return _Material
            End Get
        End Property

        'modifier string
        Public ReadOnly Property ModifierString() As String
            Get
                If _Modifiers.Count = 0 Then Return ""

                _Modifiers.Sort()
                Dim Temp As String = ""

                For Each Item As String In _Modifiers
                    If Temp <> "" Then Temp &= ", "
                    Temp &= Item
                Next

                Return Temp
            End Get
        End Property

        'modfiers
        Public ReadOnly Property Modifiers() As ArrayList
            Get
                Return _Modifiers
            End Get
        End Property

        'monk weapon
        Public ReadOnly Property MonkWeapon() As Boolean
            Get
                Return _MonkWeapon
            End Get
        End Property

        'range
        Public ReadOnly Property Range() As String
            Get
                Range = _Weapon.BaseItem.Element("RangeIncrement")
                If Range = "-" Or Range = "" Then
                    If Throwing Then
                        Range = Rules.Formatting.FormatFeet(10)
                    Else
                        Range = ""
                    End If
                Else
                    Range = Rules.Formatting.FormatFeet(CType(Range, Integer))
                End If
            End Get
        End Property

        Public ReadOnly Property Increments() As Integer
            Get

                If _Weapon.IsNatural Then
                    Return _Weapon.BaseItem.ElementAsInteger("Increments")
                Else

                    'thorwn weapons have an increment of 5
                    If Thrown Then
                        Return 5
                    Else
                        'if it is a ranged weapon then it has an increment of 10
                        If _Weapon.BaseItem.Element("WeaponType") = "Ranged" Then
                            Return 10
                        Else
                            Return 0
                        End If
                    End If

                End If

            End Get
        End Property

        'reach 
        Public ReadOnly Property ReachRange() As String
            Get
                If _Weapon.BaseItem.Element("Reach") = "Yes" Then
                    Dim TopRange As String = _Weapon.BaseItem.Element("ReachRange")
                    If _Weapon.BaseItem.Element("ReachRestricted") = "Yes" Then
                        Return "exactly " & TopRange
                    Else
                        Return "up to " & TopRange
                    End If
                Else
                    Return ""
                End If
            End Get
        End Property

        'special notes
        Public ReadOnly Property Special() As String
            Get
                Special = ""
                If Cleave Then
                    Special = "Grants Cleave Feat"
                End If

                If CritDestroys Then
                    If Special <> "" Then Special &= ", "
                    Special &= "Critical Hit Destroys Target"
                End If

                If KiWeapon Then
                    If Special <> "" Then Special &= ", "
                    Special &= "Ki Weapon"
                End If

                If Nonlethal Then
                    If Special <> "" Then Special &= ", "
                    Special &= "All Damage Non-Lethal"
                End If

                If Vicious Then
                    If Special <> "" Then Special &= ", "
                    Special &= "1d6 Damage To Wielder on Hit"
                End If
            End Get
        End Property

        'speed weapon
        Public ReadOnly Property SpeedWeapon() As Boolean
            Get
                Return Speed
            End Get
        End Property

        'spell resistance
        Public ReadOnly Property SpellResistance() As String
            Get
                If Not HolySR Then
                    Return CommonLogic.HighestInteger(_SR).ToString
                Else
                    Dim SR As Integer = CommonLogic.HighestInteger(_SR)
                    Dim PaladinLevel As Integer

                    PaladinLevel = _Character.CurrentClassLevel(References.Paladin)

                    If PaladinLevel = 0 Then
                        Return "0"
                    Else
                        Return (5 + PaladinLevel).ToString
                    End If
                End If
            End Get
        End Property

        'strength modifier
        Public ReadOnly Property STRMod() As Integer
            Get
                Return AbilityScores.AbilityScore(_Character.CurrentLevel.STR).Modifier
            End Get
        End Property

        'str rating of weapon (ranged only)
        Public ReadOnly Property StrengthRating() As Integer
            Get
                Dim Rating As String

                Try
                    Rating = _BaseWeapon.Element("MaxStrengthBonus")
                    If Rating = "" Then
                        Return 0
                    Else
                        Return CType(Rating, Integer)
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'thrown weapon
        Public ReadOnly Property Thrown() As Boolean
            Get
                If _Weapon.BaseItem.Element("Thrown") = "Yes" Or Throwing Then Return True Else Return False
            End Get
        End Property

#End Region

        'init
        Public Sub New(ByVal Weapon As Rules.Weapons.WeaponsData, ByVal Character As Character, ByVal Mode As InitMode, Optional ByVal Wield As Rules.Weapons.Wield = Weapons.Wield.NotSet)
            Try
                _Character = Character
                _Weapon = Weapon
                _BaseWeapon = Weapon.BaseItem
                _Alignment = Character.CharacterObject.Element("Alignment")

                'check for materials
                Dim ElementString As String = ""
                If DoubleWeaponEnd = DoubleWeaponEndType.Primary Then
                    ElementString = "Material"
                Else
                    ElementString = "DMaterial"
                End If

                If Weapon.InventoryItem.Element(ElementString) = "" Then
                    If Weapon.Item.Element(ElementString) = "" Then
                        'no material
                    Else
                        _Material = CType(Rules.SpecialMaterial.Materials(Weapon.Item.GetFKGuid(ElementString)), Rules.SpecialMaterial)
                    End If
                Else
                    _Material = CType(Rules.SpecialMaterial.Materials(Weapon.InventoryItem.GetFKGuid(ElementString)), Rules.SpecialMaterial)
                End If

                'check for improved critical
                Dim WeaponKey As Objects.ObjectKey
                If Weapon.BaseItem.Element("Shadows") = "" Then WeaponKey = Weapon.BaseItem.ObjectGUID Else WeaponKey = Weapon.BaseItem.GetFKGuid("Shadows")
                If Character.Feats.ContainsSubkey(References.ImprovedCritical, WeaponKey) Then CritThreatDoubled = True

                'base properties
                Select Case Mode
                    Case InitMode.List
                        GetBasicProperties()
                    Case InitMode.Weapons
                        GetBasicProperties()
                        GetAdvProperties()
                End Select

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'init for conditions
        Public Sub New(ByVal Weapon As Rules.Weapons.WeaponsData, ByVal Character As Character, ByVal Wield As Rules.Weapons.Wield, ByVal Condition As Objects.ObjectData, ByVal EnhancementAdjust As Integer)
            Try
                _Character = Character
                _Weapon = Weapon
                _BaseWeapon = Weapon.BaseItem
                _Condition = Condition
                _EnhancementAdjust = EnhancementAdjust

                'check for improved critical
                Dim WeaponKey As Objects.ObjectKey
                If Weapon.BaseItem.Element("Shadows") = "" Then WeaponKey = Weapon.BaseItem.ObjectGUID Else WeaponKey = Weapon.BaseItem.GetFKGuid("Shadows")
                If Character.Feats.ContainsSubkey(References.ImprovedCritical, WeaponKey) Then CritThreatDoubled = True

                GetConditionProperties()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'get strength modifier to damage 
        Public Function StrengthModifier() As Integer
            Dim STRMod, STRMod2Handed, STRModHalved As Integer
            Try

                'shortcut out if no modifier
                STRMod = Me.STRMod
                If STRMod = 0 Then Return 0

                'precalc adjust mods
                If STRMod > 0 Then
                    STRMod2Handed = STRMod + CType(Math.Floor(STRMod / 2), Integer)
                    STRModHalved = CType(Math.Floor(STRMod / 2), Integer)
                Else
                    STRMod2Handed = STRMod
                    STRModHalved = STRMod
                End If

                'different behaviour for natural weapons
                If _Weapon.IsNatural Then

                    Select Case _Weapon.Hand

                        Case Weapons.Hand.Primary
                            Select Case _Weapon.PrimaryHandSTRMod
                                Case Weapons.STRBonus.Full
                                    Return STRMod
                                Case Weapons.STRBonus.Half
                                    Return STRModHalved
                                Case Weapons.STRBonus.Max
                                    Return STRMod2Handed
                                Case Weapons.STRBonus.None
                                    Return 0
                                Case Else
                                    'just in case
                                    Return STRMod
                            End Select

                        Case Weapons.Hand.OffHand
                            Select Case _Weapon.OffHandSTRMod
                                Case Weapons.STRBonus.Full
                                    Return STRMod
                                Case Weapons.STRBonus.Half
                                    Return STRModHalved
                                Case Weapons.STRBonus.Max
                                    Return STRMod2Handed
                                Case Weapons.STRBonus.None
                                    Return 0
                                Case Else
                                    'just in case
                                    Return STRModHalved
                            End Select

                    End Select

                Else

                    'check the weapon to see if str mod is allowed - ranged weapons
                    Select Case _Weapon.WieldData.WieldType
                        Case Weapons.WieldType.OneHandedRanged, Weapons.WieldType.TwoHandedRanged, Weapons.WieldType.TwoHandedRangedFireOneHandedHeavy, Weapons.WieldType.TwoHandedRangedFireOneHandedLight

                            'not strong enough?
                            If _BaseWeapon.Element("ApplyPenalty") = "Yes" And STRMod < 0 Then
                                Return STRMod
                            End If

                            'strength rating
                            If _BaseWeapon.Element("ApplyBonus") = "Yes" Then
                                If _BaseWeapon.Element("MaxStrengthBonus") = "" Then
                                    Return STRMod
                                Else
                                    If STRMod > _BaseWeapon.ElementAsInteger("MaxStrengthBonus") Then
                                        Return _BaseWeapon.ElementAsInteger("MaxStrengthBonus")
                                    Else
                                        Return STRMod
                                    End If
                                End If
                            Else
                                Return 0
                            End If

                    End Select

                    'determine which mod to use
                    Select Case _Weapon.Hand

                        Case Weapons.Hand.Primary
                            Select Case _Weapon.Weapons.PrimaryWield
                                Case Weapons.Wield.OneHanded, Weapons.Wield.DoubleWeapon, Weapons.Wield.ShieldBash, Weapons.Wield.Thrown
                                    Return STRMod
                                Case Weapons.Wield.TwoHanded
                                    Return STRMod2Handed
                            End Select

                            'four possible outcomes - normaly should be halved
                        Case Weapons.Hand.OffHand
                            Select Case _Weapon.OffHandSTRMod
                                Case Weapons.STRBonus.Full
                                    Return STRMod
                                Case Weapons.STRBonus.Half
                                    Return STRModHalved
                                Case Weapons.STRBonus.Max
                                    Return STRMod2Handed
                                Case Weapons.STRBonus.None
                                    Return 0
                                Case Else
                                    'just in case
                                    Return STRModHalved
                            End Select

                    End Select

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'basic properties display string
        Public Function BasicProperties() As String
            Dim Display As String = ""

            Try
                If _Charge Then Display = "Set Against Charge"

                If _MonkWeapon Then
                    If Display.Length > 0 Then Display &= ", "
                    Display &= "Monk"
                End If

                If _ReachWeapon Then
                    If Display.Length > 0 Then Display &= ", "
                    Display &= "Reach " & Rules.Formatting.FormatFeet(_Reach)
                End If

                If _ThrownWeapon Then
                    If Display.Length > 0 Then Display &= ", "
                    Display &= "Thrown " & Rules.Formatting.FormatFeet(_Range)
                ElseIf _Range > 0 Then
                    If Display.Length > 0 Then Display &= ", "
                    Display &= "Range " & Rules.Formatting.FormatFeet(_Range)
                End If

                Return Display

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'check basic weapon properties
        Private Sub GetBasicProperties()
            Try
                If _BaseWeapon.IsEmpty Then Exit Sub

                If _BaseWeapon.Element("Double") = "Yes" Then _DoubleWeapon = True
                If _BaseWeapon.Element("Monk") = "Yes" Then _MonkWeapon = True
                If _BaseWeapon.Element("WeaponType") = "Ranged" Then _Range = _BaseWeapon.ElementAsInteger("RangeIncrement")
                If _BaseWeapon.Element("Reach") = "Yes" Then
                    _ReachWeapon = True
                    If _BaseWeapon.Element("ReachRestricted") = "Yes" Then _ReachRestricted = True
                    _Reach = CType(_BaseWeapon.Element("ReachRange").Replace("ft.", ""), Integer)
                End If
                If _BaseWeapon.Element("Charge") = "Yes" Then _Charge = True
                If _BaseWeapon.Element("Thrown") = "Yes" Then
                    _ThrownWeapon = True
                    _Range = _BaseWeapon.ElementAsInteger("RangeIncrement")
                End If
                If _BaseWeapon.Type = Objects.ShieldDefinitionType Then _Shield = True
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'get advanced properties
        Private Sub GetAdvProperties()
            'reset
            _Abilities = New ArrayList
            _DamageAddition = New ArrayList
            _DamageResistance = New DamageResistance
            _Emulations = New ArrayList
            _Modifiers = New ArrayList
            _SR = New ArrayList

            'add the extra damage string if the weapon is a natural one
            If Me._Weapon.IsNatural Then
                Dim ExtraDamage As String
                ExtraDamage = _Weapon.Item.Element("ExtraDamage")

                If ExtraDamage <> "" Then
                    _DamageAddition.Add(ExtraDamage)
                End If
            End If

            If DoubleWeapon Then
                Select Case DoubleWeaponEnd
                    Case DoubleWeaponEndType.Primary
                        ProcessComponents(_Weapon.Item, _Weapon.Item.ChildrenOfType(Objects.SpecificWeaponAbilityType))
                        ProcessAbilities(_Weapon.Item.ChildrenOfType(Objects.PsionicWeaponAbilityType))
                    Case DoubleWeaponEndType.Secondary
                        ProcessComponents(_Weapon.Item, _Weapon.Item.ChildrenOfType(Objects.SpecificWeaponDoubleAbilityType))
                        ProcessAbilities(_Weapon.Item.ChildrenOfType(Objects.PsionicWeaponAbilityDoubleType))
                End Select
            Else
                ProcessComponents(_Weapon.Item, _Weapon.Item.ChildrenOfType(Objects.SpecificWeaponAbilityType))
                ProcessAbilities(_Weapon.Item.ChildrenOfType(Objects.PsionicWeaponAbilityType))
            End If

            'analyse the base item if its different
            If Not (_Weapon.Item.ObjectGUID.Equals(_Weapon.BaseItem.ObjectGUID)) Then
                ProcessComponents(_Weapon.BaseItem, New Objects.ObjectDataCollection)
            End If

        End Sub

        'get condition properties
        Private Sub GetConditionProperties()
            'reset
            _Abilities = New ArrayList
            _DamageAddition = New ArrayList
            _DamageResistance = New DamageResistance
            _Modifiers = New ArrayList
            _SR = New ArrayList

            ProcessComponents(_Condition, _Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType))
            ProcessAbilities(_Condition.ChildrenOfType(Objects.PsionicWeaponAbilityConditionalType))
        End Sub

        'process components
        Private Sub ProcessComponents(ByVal Component As Objects.ObjectData, ByRef AbilityComponents As Objects.ObjectDataCollection)

            'directly attached components
            For Each Subcomponent As Objects.ObjectData In Component.Children
                AnalyseComponent(Subcomponent)
            Next

            'abilities
            Dim AbilityDef As Objects.ObjectData

            For Each Obj As Objects.ObjectData In AbilityComponents

                Select Case Obj.Type

                    Case Objects.MagicWeaponAbilityConditionalType
                        AbilityDef = Obj.GetFKObject("WeaponMagicAbilityDefinition")

                    Case Objects.PsionicWeaponAbilityConditionalType
                        AbilityDef = Obj.GetFKObject("WeaponAbility")

                    Case Else
                        AbilityDef = Obj.GetFKObject("WeaponMagicAbility")
                        If AbilityDef.IsEmpty Then AbilityDef = Obj.GetFKObject("WeaponAbility")

                End Select

                _Abilities.Add(AbilityDef.Name)

                For Each Subcomponent As Objects.ObjectData In AbilityDef.Children
                    AnalyseComponent(Subcomponent)
                Next
            Next

        End Sub

        'process an ability list
        Private Sub ProcessAbilities(ByVal AbilityComponents As Objects.ObjectDataCollection)
            Dim AbilityDef As Objects.ObjectData
            For Each Obj As Objects.ObjectData In AbilityComponents

                Select Case Obj.Type

                    Case Objects.MagicWeaponAbilityConditionalType
                        AbilityDef = Obj.GetFKObject("WeaponMagicAbilityDefinition")

                    Case Objects.PsionicWeaponAbilityConditionalType
                        AbilityDef = Obj.GetFKObject("WeaponAbility")

                    Case Else
                        AbilityDef = Obj.GetFKObject("WeaponMagicAbility")
                        If AbilityDef.IsEmpty Then AbilityDef = Obj.GetFKObject("WeaponAbility")

                End Select
                _Abilities.Add(AbilityDef.Name)
                For Each Subcomponent As Objects.ObjectData In AbilityDef.Children
                    AnalyseComponent(Subcomponent)
                Next
            Next

        End Sub

        'analyse component for weapons
        Private Sub AnalyseComponent(ByVal Component As Objects.ObjectData)
            Dim Temp, Temp2 As String

            Select Case Component.Type
                Case Objects.ConditionType
                    If _Character.Components.ConditionMet(Component) Then
                        ProcessComponents(Component, Component.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType))
                    Else
                        Dim Condition As New WeaponProperties(_Weapon, _Character, _Wield, Component, _Enhancement)
                        Conditions.Add(Condition)
                    End If
                Case Objects.DamageAdditionType
                    If Component.Element("OnCritical") = "" Then
                        Temp = Component.Name.Replace("Extra ", "")
                        Temp = Temp.Replace(" Damage", "")
                        Temp = "+" & Temp
                        _DamageAddition.Add(Temp)
                    Else
                        If Component.Element("CriticalMultiplier") = "Yes" Then
                            Dim Dice As Rules.Dice.DiceRange = Rules.Dice.GetDiceRange(Component.Element("Damage"))
                            Dim Crit As CriticalRange = Me.Critical

                            Dice.DiceCount += Crit.Multiplier - 2
                            Temp = "+" & Dice.ToString & " "
                            Temp2 = Component.Element("DamageType")
                            If Temp2 = "" Then
                                Temp &= "on Critical"
                            Else
                                Temp &= Temp2 & " on Critical"
                            End If

                            _DamageAddition.Add(Temp)
                        Else
                            Temp = "+" & Component.Element("Damage") & " "
                            Temp2 = Component.Element("DamageType")
                            If Temp2 = "" Then
                                Temp &= "on Critical"
                            Else
                                Temp &= Temp2 & " on Critical"
                            End If

                            _DamageAddition.Add(Temp)
                        End If
                    End If
                Case Objects.DamageResistanceType
                    _DamageResistance.AddDamageResistance(Component)
                Case Objects.EnhancementBonusType
                    _Enhancement = Component.ElementAsInteger("Enhancement")
                Case Objects.ModifierType
                    _Modifiers.Add(Component.Name)
                Case Objects.SpellResistanceType
                    _SR.Add(Component.ElementAsInteger("Number"))
                Case Objects.SystemWeaponAbilityType
                    HandleSystemWeaponAbility(Component.GetFKGuid("SystemWeaponAbilityDefinition"))
                Case Objects.WeaponEmulationType
                    _Emulations.Add(Component.GetFKGuid("WeaponDefinition"))
            End Select
        End Sub

        'specific handling for system weapon abilities
        Private Sub HandleSystemWeaponAbility(ByVal Key As Objects.ObjectKey)
            Select Case Key.ToString
                Case References.AlignmentPenalty1.ToString
                    Align1 = True
                Case References.AlignmentPenalty2.ToString
                    Align2 = True
                Case References.Cleave.ToString
                    Cleave = True
                Case References.CriticalDestroys.ToString
                    CritDestroys = True
                Case References.CriticalIncreasedTox3.ToString
                    Critx3 = True
                Case References.CriticalIncreasedTox4.ToString
                    Critx4 = True
                Case References.DoubleDamage.ToString
                    DoubleDamage = True
                Case References.HolyAvengerSpellResistance.ToString
                    HolySR = True
                Case References.Keen.ToString
                    CritThreatDoubled = True
                Case References.KiWeapon.ToString
                    KiWeapon = True
                Case References.NonlethalWeapon.ToString
                    Nonlethal = True
                Case References.SpeedWeapon.ToString
                    Speed = True
                Case References.Throwing.ToString
                    Throwing = True
                Case References.Vicious.ToString
                    Vicious = True
            End Select
        End Sub

        'shared function used by marketplace and choose weapon to determine whether bane focus required
        Public Shared Function HasBaneCondition(ByVal Item As Objects.ObjectData) As Boolean

            'get abilities
            Dim Abilities As Objects.ObjectDataCollection = Item.ChildrenOfType(Objects.SpecificWeaponAbilityType)
            Abilities.AddMany(Item.ChildrenOfType(Objects.SpecificWeaponDoubleAbilityType))

            'get conditions and attached abilities
            Dim Conditions As Objects.ObjectDataCollection = Item.ChildrenOfType(Objects.ConditionType)
            For Each Condition As Objects.ObjectData In Conditions
                Abilities.AddMany(Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType))
            Next

            'get conditions attached to ability definitions
            Dim AbilityDef As Objects.ObjectData
            For Each Ability As Objects.ObjectData In Abilities
                AbilityDef = Ability.GetFKObject(Ability.GetFirstFKElementName)
                Conditions.AddMany(AbilityDef.ChildrenOfType(Objects.ConditionType))
            Next

            'check for bane
            For Each Condition As Objects.ObjectData In Conditions
                If Condition.Element("Condition") = Rules.Conditions.Bane Then Return True
            Next

            Return False

        End Function

    End Class

End Namespace