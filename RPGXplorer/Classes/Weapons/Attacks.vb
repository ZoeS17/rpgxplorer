Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class Attacks

        'this class determines the attacks for a character

#Region "Member Variables"

        Private _Character As Character
        Private _Proficiency As Proficiency
        Private _Weapons As Weapons
        Private _BaseAttacks, _Attacks, _OffHandAttacks As ArrayList

        'monk
        Public FlurryOfBlows As Boolean
        Private FlurryExtraAttacks, FlurryPenalty As Integer

        Private STRMod, DEXMod As Integer

#End Region

#Region "Properties"

        Public Property Weapons() As Weapons
            Get
                Return _Weapons
            End Get
            Set(ByVal Value As Weapons)
                _Weapons = Value
            End Set
        End Property

        'base attack array
        Public ReadOnly Property BaseAttacks() As ArrayList
            Get
                Return _BaseAttacks
            End Get
        End Property

        'primary attacks
        Public ReadOnly Property Attacks() As ArrayList
            Get
                Dim Modifier As Integer
                Dim TempPenalty, MaxArmorPenalty As Integer

                Try
                    'check for weapon
                    If _Weapons.PrimaryWield = Rules.Weapons.Wield.NotSet Then Return Nothing

                    If _Weapons.PrimaryWeapon.IsNatural Then
                        _Attacks = New ArrayList(1)
                        _Attacks.Add(_BaseAttacks(0))
                    Else
                        _Attacks = New ArrayList(_BaseAttacks)
                    End If

                    'proficiencies
                    Modifier += Proficiency_PrimaryModifier()
                    Modifier += _Proficiency.ArmorPenalty

                    TempPenalty = 0 : MaxArmorPenalty = 0

                    'primary shield check
                    If _Weapons.PrimaryWield = Weapons.Wield.ShieldBash OrElse _Weapons.PrimaryWield = Weapons.Wield.Shield Then
                        If _Proficiency.Proficient(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                            Dim ArmorProperties As New ArmorProperties(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Masterwork, _Weapons.PrimaryWeapon.Enhancement)
                            TempPenalty = ArmorProperties.CheckPenalty
                            If TempPenalty < MaxArmorPenalty Then
                                MaxArmorPenalty = TempPenalty
                            End If
                        End If
                    End If

                    'offhand shield checks
                    If TypeOf _Weapons Is Rules.MonsterWeapons Then

                        'go through all the offhands for shields
                        Dim MonsterWeapons As Rules.MonsterWeapons = CType(_Weapons, Rules.MonsterWeapons)

                        'offhands
                        For i As Integer = 1 To MonsterWeapons.OffHandCount
                            If MonsterWeapons.OffHandWield(i) = Weapons.Wield.ShieldBash Or MonsterWeapons.OffHandWield(i) = Weapons.Wield.Shield Then
                                If _Proficiency.Proficient(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                    Dim ArmorProperties As New ArmorProperties(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Masterwork, MonsterWeapons.OffHandItem(i).Enhancement)
                                    TempPenalty = ArmorProperties.CheckPenalty
                                    If TempPenalty < MaxArmorPenalty Then
                                        MaxArmorPenalty = TempPenalty
                                    End If
                                End If
                            End If
                        Next

                        'buckler
                        If _Weapons.BucklerWielded Then
                            If _Proficiency.Proficient(Weapons.Buckler.BaseItem, Weapons.Buckler.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                Dim ShieldProperties As New ArmorProperties(Weapons.Buckler.Item)
                                TempPenalty = ShieldProperties.CheckPenalty
                                If TempPenalty < MaxArmorPenalty Then
                                    MaxArmorPenalty = TempPenalty
                                End If
                            End If
                        End If

                    Else

                        'offhand or buckler
                        If _Weapons.OffHandWield = Weapons.Wield.ShieldBash Or _Weapons.OffHandWield = Weapons.Wield.Shield Then
                            If _Proficiency.Proficient(Weapons.OffHandItem.BaseItem, Weapons.OffHandItem.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                Dim ArmorProperties As New ArmorProperties(_Weapons.OffHandItem.BaseItem, _Weapons.OffHandItem.Masterwork, _Weapons.OffHandItem.Enhancement)
                                TempPenalty = ArmorProperties.CheckPenalty
                                If TempPenalty < MaxArmorPenalty Then
                                    MaxArmorPenalty = TempPenalty
                                End If
                            End If
                        ElseIf _Weapons.BucklerWielded Then
                            If _Proficiency.Proficient(Weapons.Buckler.BaseItem, Weapons.Buckler.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                Dim ShieldProperties As New ArmorProperties(Weapons.Buckler.Item)
                                TempPenalty = ShieldProperties.CheckPenalty
                                If TempPenalty < MaxArmorPenalty Then
                                    MaxArmorPenalty = TempPenalty
                                End If
                            End If
                        End If

                    End If

                    'add any shield penalty on
                    Modifier += MaxArmorPenalty

                    'size
                    Modifier += Rules.Size.Size(_Character.Size).Modifier

                    'enhancement bonus or masterwork (if its not a shield)
                    Dim Enhancement As Integer
                    If Not _Weapons.PrimaryWeapon.Properties.Shield Then
                        Enhancement = _Weapons.PrimaryWeapon.Properties.Enhancement

                        'check material enhancement bonus
                        Dim MaterialAttackEnhancement As Integer
                        If Not _Weapons.PrimaryWeapon.Properties.Material Is Nothing Then
                            MaterialAttackEnhancement = _Weapons.PrimaryWeapon.Properties.Material.AttackEnhancementAdjustment
                        End If

                        If MaterialAttackEnhancement > 0 Then
                            If MaterialAttackEnhancement > Enhancement Then Enhancement = MaterialAttackEnhancement
                        Else
                            Modifier -= MaterialAttackEnhancement
                        End If

                        If Enhancement > 0 Then
                            Modifier += Enhancement
                        ElseIf _Weapons.PrimaryWeapon.Masterwork Then
                            Modifier += 1
                        End If
                    End If

                    'if speed weapon then 1 extra attack
                    If _Weapons.PrimaryWeapon.Properties.SpeedWeapon Then
                        ExtraAttackAtBAB(_Attacks)
                    End If

                    'check for flurry of blows
                    If _Weapons.MonkAttackPossible Then
                        For n As Integer = 1 To FlurryExtraAttacks
                            ExtraAttackAtBAB(_Attacks)
                        Next
                        Modifier += FlurryPenalty
                    End If

                    'if two-weapon fighting
                    If _Weapons.TwoWeaponFighting Then
                        Modifier += TwoWeaponFighting_PrimaryPenalty()
                    End If

                    'penalty for firing 2-handed ranged weapon 1-handed 
                    If (_Weapons.PrimaryWeapon.WieldData.WieldType = Weapons.WieldType.TwoHandedRangedFireOneHandedHeavy Or Weapons.PrimaryWeapon.WieldData.WieldType = Weapons.WieldType.TwoHandedRangedFireOneHandedLight) And Weapons.PrimaryWield = Weapons.Wield.OneHanded Then
                        Modifier += _Weapons.PrimaryWeapon.Properties.FiringPenaltyOneHanded
                    End If

                    'using finesse/ranged or strength? check ranged weapon str rating also
                    If (_Weapons.PrimaryWeapon.BaseItem.Element("WeaponType") = "Melee" And Not _Weapons.PrimaryWield = Weapons.Wield.Thrown) Or _Weapons.PrimaryWeapon.BaseItem.Type = Objects.ShieldDefinitionType Then
ImprovisedMelee:
                        'we are doing a melee attack - if we have no strength add dex like weapon finesse
                        If _Character.NonStr Then

                            'we have no str ability score
                            If _Character.NonDex Then
                                'we have no str or dex
                                Return Nothing
                            Else
                                'we only have a dex ability acore
                                Modifier += (DEXMod + ArmorAttackPenalty())
                            End If

                        Else

                            'we have at least a str ability score
                            If _Character.NonDex Then
                                'we only have a str ability score
                                Modifier += STRMod
                            Else

                                'we have both a str and a dex ability score
                                If STRMod < DEXMod And _Weapons.PrimaryWeapon.Properties.UseWeaponFinesse And _Character.Components.SystemAbilities(References.WeaponFinesse) Then
                                    'we are finessing - check for the bigger mod (including shield armor check)
                                    Dim FinesseArmorPenalty As Integer = ArmorAttackPenalty()

                                    If (DEXMod + FinesseArmorPenalty) > STRMod Then
                                        Modifier += (DEXMod + FinesseArmorPenalty)
                                    Else
                                        Modifier += STRMod
                                    End If
                                Else
                                    'we arent finessing - just add str
                                    Modifier += STRMod
                                End If

                            End If

                        End If

                    Else 'Ranged/Thrown Weapon section

                        'improvised melee weapon for javelin
                        If _Weapons.PrimaryWeapon.ImprovisedMelee Then
                            Modifier -= 4
                            GoTo ImprovisedMelee
                        End If

                        Dim RangedAttackModifier As Integer = RangedAttackMod(_Weapons.PrimaryWield)
                        If RangedAttackModifier = -999 Then
                            'if we hace no ranges bonus we cant fire a ranged weapon
                            Return Nothing
                        Else
                            Modifier += RangedAttackModifier
                        End If

                        'strength rating penalty
                        Dim Rating As Integer = _Weapons.PrimaryWeapon.Properties.StrengthRating
                        If Rating > 0 Then
                            If _Character.NonStr Then
                                Return Nothing
                            Else
                                If STRMod < Rating Then Modifier -= 2
                            End If
                        End If

                    End If

                    'get attack roll modifiers
                    Modifier += _Character.Modifiers.AttackRoll
                    Modifier += _Character.Modifiers.AttackRollSpecificWeapon(_Weapons.PrimaryWeapon.BaseItem.ObjectGUID)

                    If _Weapons.PrimaryWield = Weapons.Wield.Thrown Then Modifier += _Character.Modifiers.AttackRollThrownWeapons

                    'buckler penalty for primary attack (only applies if two-handed wield)
                    If _Weapons.BucklerWielded Then
                        If _Weapons.PrimaryWield = Weapons.Wield.TwoHanded Or _Weapons.PrimaryWield = Weapons.Wield.DoubleWeapon Then
                            If _Weapons.PrimaryWeapon.Properties.BucklerPenalty Then Modifier -= 1
                        End If
                    End If

                    'size difference Modifier
                    Modifier += _Weapons.PrimaryWeapon.WieldData.SizePenalty

                    'add Modifier/bonus to all attacks
                    AdjustAttacks(_Attacks, Modifier)
                    Return _Attacks

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'offhand attacks
        Public ReadOnly Property OffHandAttacks() As ArrayList
            Get
                Dim Modifier As Integer
                Dim TempPenalty, MaxArmorPenalty As Integer

                Try
                    'check for weapon
                    If _Weapons.OffHandWield = Rules.Weapons.Wield.NotSet Or _Weapons.OffHandWield = Weapons.Wield.Shield Then Return Nothing

                    _OffHandAttacks = New ArrayList(1)
                    _OffHandAttacks.Add(_BaseAttacks(0))

                    'proficiency
                    Modifier += _Proficiency.ArmorPenalty
                    Modifier += Proficiency_OffHandModifier()

                    'check for shield check penalties
                    TempPenalty = 0 : MaxArmorPenalty = 0

                    'primary shield?
                    If _Weapons.PrimaryWield = Weapons.Wield.ShieldBash OrElse _Weapons.PrimaryWield = Weapons.Wield.Shield Then
                        If _Proficiency.Proficient(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                            Dim ArmorProperties As New ArmorProperties(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Masterwork, _Weapons.PrimaryWeapon.Enhancement)
                            TempPenalty = ArmorProperties.CheckPenalty
                            If TempPenalty < MaxArmorPenalty Then
                                MaxArmorPenalty = TempPenalty
                            End If
                        End If
                    End If

                    'Offhand shields?
                    If TypeOf _Weapons Is Rules.MonsterWeapons Then

                        'if its a monster type this offhand will only ever contain a double weapon
                        Dim MonsterWeapons As Rules.MonsterWeapons = CType(_Weapons, Rules.MonsterWeapons)

                        For i As Integer = 1 To MonsterWeapons.OffHandCount
                            If MonsterWeapons.OffHandWield(i) = Weapons.Wield.ShieldBash Or MonsterWeapons.OffHandWield(i) = Weapons.Wield.Shield Then
                                If _Proficiency.Proficient(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                    Dim ArmorProperties As New ArmorProperties(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Masterwork, MonsterWeapons.OffHandItem(i).Enhancement)
                                    TempPenalty = ArmorProperties.CheckPenalty
                                    If TempPenalty < MaxArmorPenalty Then
                                        MaxArmorPenalty = TempPenalty
                                    End If
                                End If
                            End If
                        Next

                    Else

                        'check myself
                        If _Weapons.OffHandWield = Weapons.Wield.ShieldBash Or _Weapons.OffHandWield = Weapons.Wield.Shield Then
                            If _Proficiency.Proficient(Weapons.OffHandItem.BaseItem, Weapons.OffHandItem.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                Dim ArmorProperties As New ArmorProperties(_Weapons.OffHandItem.BaseItem, _Weapons.OffHandItem.Masterwork, _Weapons.OffHandItem.Enhancement)
                                TempPenalty = ArmorProperties.CheckPenalty
                                If TempPenalty < MaxArmorPenalty Then
                                    MaxArmorPenalty = TempPenalty
                                End If
                            End If
                        End If

                    End If

                    If _Weapons.BucklerWielded Then
                        If _Proficiency.Proficient(Weapons.Buckler.BaseItem, Weapons.Buckler.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                            Dim ShieldProperties As New ArmorProperties(Weapons.Buckler.Item)
                            Modifier += ShieldProperties.CheckPenalty
                            TempPenalty = ShieldProperties.CheckPenalty
                            If TempPenalty < MaxArmorPenalty Then
                                MaxArmorPenalty = TempPenalty
                            End If
                        End If
                    End If

                    Modifier += MaxArmorPenalty

                    'size
                    Modifier += Rules.Size.Size(_Character.Size).Modifier

                    'enhancement bonus or masterwork (if its not a shield)
                    Dim Enhancement As Integer
                    If Not _Weapons.OffHandItem.Properties.Shield Then
                        Enhancement = _Weapons.OffHandItem.Properties.Enhancement

                        'check material enhancement bonus
                        Dim MaterialAttackEnhancement As Integer
                        If Not _Weapons.OffHandItem.Properties.Material Is Nothing Then
                            MaterialAttackEnhancement = _Weapons.OffHandItem.Properties.Material.AttackEnhancementAdjustment
                        End If

                        If MaterialAttackEnhancement > 0 Then
                            If MaterialAttackEnhancement > Enhancement Then Enhancement = MaterialAttackEnhancement
                        Else
                            Modifier -= MaterialAttackEnhancement
                        End If

                        If Enhancement > 0 Then
                            Modifier += Enhancement
                        ElseIf _Weapons.OffHandItem.Masterwork Then
                            Modifier += 1
                        End If
                    End If

                    'if speed weapon then 1 extra attack
                    If _Weapons.OffHandItem.Properties.SpeedWeapon Then
                        ExtraAttackAtBAB(_OffHandAttacks)
                    End If

                    'check for flurry of blows penalty
                    If _Weapons.MonkAttackPossible Then
                        Modifier += FlurryPenalty
                    End If

                    'if two-weapon fighting
                    If _Weapons.TwoWeaponFighting Then
                        Modifier += TwoWeaponFighting_OffHandPenalty()
                        TwoWeaponFighting_GetExtraOffHandAttacks()
                    End If

                    'penalty for firing 2-handed ranged weapon 1-handed 
                    If (_Weapons.OffHandItem.WieldData.WieldType = Weapons.WieldType.TwoHandedRangedFireOneHandedHeavy Or Weapons.OffHandItem.WieldData.WieldType = Weapons.WieldType.TwoHandedRangedFireOneHandedLight) And Weapons.OffHandWield = Weapons.Wield.OneHanded Then
                        Modifier += _Weapons.OffHandItem.Properties.FiringPenaltyOneHanded
                    End If

                    'using finesse/ranged or strength? check ranged weapon str rating also
                    If (_Weapons.OffHandItem.BaseItem.Element("WeaponType") = "Melee" And Not _Weapons.OffHandWield = Weapons.Wield.Thrown) Or _Weapons.OffHandItem.BaseItem.Type = Objects.ShieldDefinitionType Then
ImprovisedMelee:
                        'we are doing a melee attack - if we have no strength add dex like weapon finesse
                        If _Character.NonStr Then

                            'we have no str ability score
                            If _Character.NonDex Then
                                'we have no str or dex
                                Return Nothing
                            Else
                                'we only have a dex ability acore
                                Modifier += (DEXMod + ArmorAttackPenalty(True))
                            End If

                        Else

                            'we have at least a str ability score
                            If _Character.NonDex Then
                                'we only have a str ability score
                                Modifier += STRMod
                            Else

                                'we have both a str and a dex ability score
                                If STRMod < DEXMod And _Weapons.OffHandItem.Properties.UseWeaponFinesse And _Character.Components.SystemAbilities(References.WeaponFinesse) Then
                                    'we are finessing - check for the bigger mod (including shield armor check)
                                    Dim FinesseArmorPenalty As Integer = ArmorAttackPenalty(True)

                                    If (DEXMod + FinesseArmorPenalty) > STRMod Then
                                        Modifier += (DEXMod + FinesseArmorPenalty)
                                    Else
                                        Modifier += STRMod
                                    End If
                                Else
                                    'we arent finessing - just add str
                                    Modifier += STRMod
                                End If

                            End If

                        End If

                    Else 'Ranged/Thrown Weapon section

                        'improvised melee weapon for javelin
                        If _Weapons.OffHandItem.ImprovisedMelee Then
                            Modifier -= 4
                            GoTo ImprovisedMelee
                        End If

                        Dim RangedAttackModifier As Integer = RangedAttackMod(_Weapons.OffHandWield)
                        If RangedAttackModifier = -999 Then
                            'if we hace no ranges bonus we cant fire a ranged weapon
                            Return Nothing
                        Else
                            Modifier += RangedAttackModifier
                        End If

                        'strength rating penalty
                        Dim Rating As Integer = _Weapons.OffHandItem.Properties.StrengthRating
                        If Rating > 0 Then
                            If _Character.NonStr Then
                                Return Nothing
                            Else
                                If STRMod < Rating Then Modifier -= 2
                            End If
                        End If

                    End If


                    '                    'using finesse/ranged or strength? check ranged weapon str rating also
                    '                    If (_Weapons.OffHandItem.BaseItem.Element("WeaponType") = "Melee" And Not _Weapons.OffHandWield = Weapons.Wield.Thrown) Or _Weapons.OffHandItem.BaseItem.Type = Objects.ShieldDefinitionType Then
                    'ImprovisedMelee:
                    '                        If STRMod < DEXMod And _Weapons.OffHandItem.Properties.UseWeaponFinesse And _Character.Components.SystemAbilities(References.WeaponFinesse) Then

                    '                            If TypeOf _Weapons Is Rules.MonsterWeapons Then

                    '                                'go through all the hands for shields
                    '                                Dim MonsterWeapons As Rules.MonsterWeapons = CType(_Weapons, Rules.MonsterWeapons)
                    '                                TempPenalty = 0 : MaxArmorPenalty = 0

                    '                                If _Weapons.PrimaryWield = Weapons.Wield.ShieldBash OrElse _Weapons.PrimaryWield = Weapons.Wield.Shield Then
                    '                                    Dim ArmorProperties As New ArmorProperties(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Masterwork, _Weapons.PrimaryWeapon.Enhancement)
                    '                                    TempPenalty = ArmorProperties.CheckPenalty
                    '                                    If TempPenalty < MaxArmorPenalty Then
                    '                                        MaxArmorPenalty = TempPenalty
                    '                                    End If
                    '                                End If

                    '                                For i As Integer = 1 To MonsterWeapons.OffHandCount
                    '                                    If MonsterWeapons.OffHandWield(i) = Weapons.Wield.Shield OrElse MonsterWeapons.OffHandWield(i) = Weapons.Wield.ShieldBash Then
                    '                                        Dim ArmorProperties As New ArmorProperties(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Masterwork, MonsterWeapons.OffHandItem(i).Enhancement)
                    '                                        TempPenalty = ArmorProperties.CheckPenalty
                    '                                        If TempPenalty < MaxArmorPenalty Then
                    '                                            MaxArmorPenalty = TempPenalty
                    '                                        End If
                    '                                    End If
                    '                                Next

                    '                                If DEXMod + MaxArmorPenalty > STRMod Then
                    '                                    Modifier += DEXMod + MaxArmorPenalty
                    '                                Else
                    '                                    Modifier += STRMod
                    '                                End If

                    '                            Else
                    '                                Modifier += DEXMod
                    '                            End If

                    '                        Else
                    '                            Modifier += STRMod
                    '                        End If

                    '                    Else

                    '                        'improvised melee weapon for javelin
                    '                        If _Weapons.OffHandItem.ImprovisedMelee Then
                    '                            Modifier -= 4
                    '                            GoTo ImprovisedMelee
                    '                        End If

                    '                        'strength rating penalty
                    '                        Dim Rating As Integer = _Weapons.OffHandItem.Properties.StrengthRating

                    '                        If Rating > 0 And STRMod < Rating Then
                    '                            Modifier -= 2
                    '                        End If

                    '                        Modifier += RangedAttackMod(_Weapons.OffHandWield)

                    '                    End If


                    'get attack roll modifiers
                    Modifier += _Character.Modifiers.AttackRoll
                    Modifier += _Character.Modifiers.AttackRollSpecificWeapon(_Weapons.OffHandItem.BaseItem.ObjectGUID)
                    If _Weapons.OffHandWield = Weapons.Wield.Thrown Then Modifier += _Character.Modifiers.AttackRollThrownWeapons

                    'buckler modifier
                    If _Weapons.BucklerWielded Then
                        Select Case _Weapons.PrimaryWield
                            Case Weapons.Wield.TwoHanded
                                If _Weapons.PrimaryWeapon.Properties.BucklerPenalty Then Modifier -= 1
                            Case Else
                                If _Weapons.OffHandItem.Properties.BucklerPenalty Then Modifier -= 1
                        End Select
                    End If

                    'size difference Modifier
                    Modifier += _Weapons.OffHandItem.WieldData.SizePenalty

                    'add penalty/bonus to all attacks
                    AdjustAttacks(_OffHandAttacks, Modifier)
                    Return _OffHandAttacks

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'only get called if we are a Monster Attack
        Public ReadOnly Property OffHandAttacks(ByVal index As Integer) As ArrayList
            Get
                Dim Modifier As Integer
                Dim TempPenalty, MaxArmorPenalty As Integer
                Dim MonsterWeapons As Rules.MonsterWeapons = CType(_Weapons, Rules.MonsterWeapons)

                Try
                    'check for weapon
                    If MonsterWeapons.OffHandWield(index) = Rules.Weapons.Wield.NotSet Or MonsterWeapons.OffHandWield(index) = Weapons.Wield.Shield Then Return Nothing

                    _OffHandAttacks = New ArrayList(1)
                    _OffHandAttacks.Add(_BaseAttacks(0))

                    'proficiency
                    Modifier += _Proficiency.ArmorPenalty

                    'get any shield prof penalty
                    TempPenalty = 0 : MaxArmorPenalty = 0

                    'primary shield?
                    If _Weapons.PrimaryWield = Weapons.Wield.ShieldBash OrElse _Weapons.PrimaryWield = Weapons.Wield.Shield Then
                        If _Proficiency.Proficient(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                            Dim ArmorProperties As New ArmorProperties(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Masterwork, _Weapons.PrimaryWeapon.Enhancement)
                            TempPenalty = ArmorProperties.CheckPenalty
                            If TempPenalty < MaxArmorPenalty Then
                                MaxArmorPenalty = TempPenalty
                            End If
                        End If
                    End If

                    For i As Integer = 1 To MonsterWeapons.OffHandCount
                        If MonsterWeapons.OffHandWield(i) = Weapons.Wield.ShieldBash Or MonsterWeapons.OffHandWield(i) = Weapons.Wield.Shield Then
                            If _Proficiency.Proficient(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Item) = Proficiency.ProficiencyLevel.NotProficient Then
                                Dim ArmorProperties As New ArmorProperties(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Masterwork, MonsterWeapons.OffHandItem(i).Enhancement)
                                TempPenalty = ArmorProperties.CheckPenalty
                                If TempPenalty < MaxArmorPenalty Then
                                    MaxArmorPenalty = TempPenalty
                                End If
                            End If
                        End If
                    Next

                    If _Weapons.BucklerWielded Then
                        If _Proficiency.Proficient(Weapons.Buckler.BaseItem, Weapons.Buckler.Item) = Proficiency.ProficiencyLevel.NotProficient Then
                            Dim ShieldProperties As New ArmorProperties(Weapons.Buckler.Item)
                            Modifier += ShieldProperties.CheckPenalty
                            TempPenalty = ShieldProperties.CheckPenalty
                            If TempPenalty < MaxArmorPenalty Then
                                MaxArmorPenalty = TempPenalty
                            End If
                        End If
                    End If

                    Modifier += MaxArmorPenalty

                    If Not MonsterWeapons.OffHandWield(index) = Weapons.Wield.ShieldBash Then
                        Modifier += Proficiency_OffHandModifier(index)
                    End If

                    'size
                    Modifier += Rules.Size.Size(_Character.Size).Modifier

                    'enhancement bonus or masterwork (if its not a shield)
                    Dim Enhancement As Integer
                    If Not MonsterWeapons.OffHandItem(index).Properties.Shield Then
                        Enhancement = MonsterWeapons.OffHandItem(index).Properties.Enhancement

                        'check material enhancement bonus
                        Dim MaterialAttackEnhancement As Integer
                        If Not MonsterWeapons.OffHandItem(index).Properties.Material Is Nothing Then
                            MaterialAttackEnhancement = MonsterWeapons.OffHandItem(index).Properties.Material.AttackEnhancementAdjustment
                        End If

                        If MaterialAttackEnhancement > 0 Then
                            If MaterialAttackEnhancement > Enhancement Then Enhancement = MaterialAttackEnhancement
                        Else
                            Modifier -= MaterialAttackEnhancement
                        End If

                        If Enhancement > 0 Then
                            Modifier += Enhancement
                        ElseIf MonsterWeapons.OffHandItem(index).Masterwork Then
                            Modifier += 1
                        End If
                    End If

                    'if speed weapon then 1 extra attack
                    If MonsterWeapons.OffHandItem(index).Properties.SpeedWeapon Then
                        ExtraAttackAtBAB(_OffHandAttacks)
                    End If

                    'check for flurry of blows penalty
                    If _Weapons.MonkAttackPossible Then
                        Modifier += FlurryPenalty
                    End If

                    'if two-weapon fighting
                    If Not MonsterWeapons.OffHandItem(index).IsNatural Then
                        If _Weapons.TwoWeaponFighting Then
                            Modifier += TwoWeaponFighting_OffHandPenalty()
                            TwoWeaponFighting_GetExtraOffHandAttacks()
                        End If
                    End If

                    'penalty for firing 2-handed ranged weapon 1-handed 
                    If (MonsterWeapons.OffHandItem(index).WieldData.WieldType = Weapons.WieldType.TwoHandedRangedFireOneHandedHeavy Or MonsterWeapons.OffHandItem(index).WieldData.WieldType = Weapons.WieldType.TwoHandedRangedFireOneHandedLight) And MonsterWeapons.OffHandWield(index) = Weapons.Wield.OneHanded Then
                        Modifier += MonsterWeapons.OffHandItem(index).Properties.FiringPenaltyOneHanded
                    End If

                    'using finesse/ranged or strength? check ranged weapon str rating also
                    If (MonsterWeapons.OffHandItem(index).BaseItem.Element("WeaponType") = "Melee" And Not MonsterWeapons.OffHandWield(index) = Weapons.Wield.Thrown) Or MonsterWeapons.OffHandItem(index).BaseItem.Type = Objects.ShieldDefinitionType Then
ImprovisedMelee:
                        'we are doing a melee attack - if we have no strength add dex like weapon finesse
                        If _Character.NonStr Then

                            'we have no str ability score
                            If _Character.NonDex Then
                                'we have no str or dex
                                Return Nothing
                            Else
                                'we only have a dex ability acore
                                Modifier += (DEXMod + ArmorAttackPenalty(True))
                            End If

                        Else

                            'we have at least a str ability score
                            If _Character.NonDex Then
                                'we only have a str ability score
                                Modifier += STRMod
                            Else

                                'we have both a str and a dex ability score
                                If STRMod < DEXMod And MonsterWeapons.OffHandItem(index).Properties.UseWeaponFinesse And _Character.Components.SystemAbilities(References.WeaponFinesse) Then
                                    'we are finessing - check for the bigger mod (including shield armor check)
                                    Dim FinesseArmorPenalty As Integer = ArmorAttackPenalty(True)

                                    If (DEXMod + FinesseArmorPenalty) > STRMod Then
                                        Modifier += (DEXMod + FinesseArmorPenalty)
                                    Else
                                        Modifier += STRMod
                                    End If
                                Else
                                    'we arent finessing - just add str
                                    Modifier += STRMod
                                End If

                            End If

                        End If

                    Else 'Ranged/Thrown Weapon section

                        'improvised melee weapon for javelin
                        If MonsterWeapons.OffHandItem(index).ImprovisedMelee Then
                            Modifier -= 4
                            GoTo ImprovisedMelee
                        End If

                        Dim RangedAttackModifier As Integer = RangedAttackMod(MonsterWeapons.OffHandWield(index))
                        If RangedAttackModifier = -999 Then
                            'if we hace no ranges bonus we cant fire a ranged weapon
                            Return Nothing
                        Else
                            Modifier += RangedAttackModifier
                        End If

                        'strength rating penalty
                        Dim Rating As Integer = MonsterWeapons.OffHandItem(index).Properties.StrengthRating
                        If Rating > 0 Then
                            If _Character.NonStr Then
                                Return Nothing
                            Else
                                If STRMod < Rating Then Modifier -= 2
                            End If
                        End If

                    End If

                    'natural attacks
                    If MonsterWeapons.OffHandItem(index).IsNatural Then
                        If _Character.Components.SystemAbilities(References.MultiAttack) Then
                            Modifier -= 2
                        Else
                            Modifier -= 5
                        End If
                    End If

                    'get attack roll modifiers
                    Modifier += _Character.Modifiers.AttackRoll
                    Modifier += _Character.Modifiers.AttackRollSpecificWeapon(MonsterWeapons.OffHandItem(index).BaseItem.ObjectGUID)
                    If MonsterWeapons.OffHandWield(index) = Weapons.Wield.Thrown Then Modifier += _Character.Modifiers.AttackRollThrownWeapons

                    'buckler modifier
                    'If _Weapons.BucklerWielded Then
                    '    Select Case _Weapons.PrimaryWield
                    '        Case Weapons.Wield.TwoHanded
                    '            If _Weapons.PrimaryWeapon.Properties.BucklerPenalty Then Modifier -= 1
                    '        Case Else
                    '            If _Weapons.OffHandItem.Properties.BucklerPenalty Then Modifier -= 1
                    '    End Select
                    'End If

                    'size difference Modifier
                    Modifier += MonsterWeapons.OffHandItem(index).WieldData.SizePenalty

                    'add penalty/bonus to all attacks
                    AdjustAttacks(_OffHandAttacks, Modifier)
                    Return _OffHandAttacks

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

        'replacement ability system abilities
        Public ReadOnly Property RangedAttackMod(ByVal Wield As Rules.Weapons.Wield) As Integer
            Get
                Dim WISMod, STRMod As Integer

                If _Character.Components.SystemAbilities(References.WisdomRangedAttack) Then
                    WISMod = AbilityScores.AbilityScore(_Character.CurrentLevel.WIS).Modifier
                Else
                    WISMod = -999
                End If

                'ranged or thrown attack?
                Select Case Wield

                    Case Weapons.Wield.Thrown

                        If _Character.Components.SystemAbilities(References.StrengthThrownAttack) Then
                            If _Character.NonStr Then
                                STRMod = -999
                            Else
                                STRMod = AbilityScores.AbilityScore(_Character.CurrentLevel.STR).Modifier
                            End If
                        Else
                            STRMod = -999
                        End If

                        If _Character.NonDex Then
                            Return Math.Max(-999, Math.Max(WISMod, STRMod))
                        Else
                            Return Math.Max(DEXMod, Math.Max(WISMod, STRMod))
                        End If

                    Case Else

                        If _Character.NonDex Then
                            Return Math.Max(-999, WISMod)
                        Else
                            Return Math.Max(DEXMod, WISMod)
                        End If

                End Select

            End Get
        End Property

#End Region

        'init
        Public Sub Init(ByVal Character As Character, ByRef WeaponProficiency As Proficiency)
            Try
                _Character = Character
                _Proficiency = WeaponProficiency
                _BaseAttacks = _Character.GetBaseAttackBonuses()

                DEXMod = AbilityScores.AbilityScore(Character.CurrentLevel.DEX).Modifier
                STRMod = AbilityScores.AbilityScore(Character.CurrentLevel.STR).Modifier

                Dim ClassLevel As New Objects.ObjectData
                Dim Flurry As Objects.ObjectData
                Dim BestFlurry As New Objects.ObjectData

                'check for flurry of blows and improved unarmed damage
                For Each ClassGuid As Objects.ObjectKey In _Character.CharacterClasses.Keys
                    ClassLevel.Load(_Character.HighestClassLevelInfo(ClassGuid).ClassLevelGuid)
                    Flurry = ClassLevel.FirstChildOfType(Objects.FlurryOfBlowsType)
                    If Not Flurry.IsEmpty Then
                        If BestFlurry.IsEmpty Then
                            BestFlurry = Flurry
                        Else
                            If Flurry.ElementAsInteger("BonusAttacks") > BestFlurry.ElementAsInteger("BonusAttacks") Then
                                BestFlurry = Flurry
                            ElseIf Flurry.ElementAsInteger("BonusAttacks") = BestFlurry.ElementAsInteger("BonusAttacks") Then
                                If Flurry.ElementAsInteger("Penalty") > BestFlurry.ElementAsInteger("BonusAttacks") Then
                                    BestFlurry = Flurry
                                End If
                            End If
                        End If
                    End If
                Next

                'flurry
                If BestFlurry.IsEmpty Then
                    FlurryOfBlows = False
                Else
                    FlurryOfBlows = True
                    FlurryExtraAttacks = BestFlurry.ElementAsInteger("BonusAttacks")
                    FlurryPenalty = BestFlurry.ElementAsInteger("Penalty")
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#Region "Proficiency Penalty"

        'primary hand attack penalty or bonus
        Private Function Proficiency_PrimaryModifier() As Integer
            If _Proficiency.Proficient(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Item, 1000, _Weapons.PrimaryWield) = Proficiency.ProficiencyLevel.NotProficient Then Return -4 Else Return 0
        End Function

        'off hand attack penalty or bonus
        Private Function Proficiency_OffHandModifier() As Integer
            If _Proficiency.Proficient(_Weapons.OffHandItem.BaseItem, _Weapons.OffHandItem.Item, 1000, _Weapons.OffHandWield) = Proficiency.ProficiencyLevel.NotProficient Then Return -4 Else Return 0
        End Function

        'off hand attack penalty or bonus
        Private Function Proficiency_OffHandModifier(ByVal index As Integer) As Integer
            If _Proficiency.Proficient(CType(_Weapons, Rules.MonsterWeapons).OffHandItem(index).BaseItem, CType(_Weapons, Rules.MonsterWeapons).OffHandItem(index).Item, 1000, CType(_Weapons, Rules.MonsterWeapons).OffHandWield(index)) = Proficiency.ProficiencyLevel.NotProficient Then Return -4 Else Return 0
        End Function

#End Region

#Region "Two-Weapon Fighting"

        'primary hand penalty
        Private Function TwoWeaponFighting_PrimaryPenalty() As Integer
            Try

                Dim Penalty As Integer

                If _Weapons.OffHandWeaponLight And _Proficiency.TwoWeaponFightingSkill >= Proficiency.TwoWeaponFightingProficiency.TwoWeaponFighting Then
                    Penalty = -2
                ElseIf _Weapons.OffHandWeaponLight Then
                    Penalty = -4
                ElseIf _Proficiency.TwoWeaponFightingSkill >= Proficiency.TwoWeaponFightingProficiency.TwoWeaponFighting Then
                    Penalty = -4
                Else
                    Penalty = -6
                End If

                If _Character.Components.SystemAbilities(References.ReduceTwoWeaponFighting2) Then
                    Penalty += 2
                ElseIf _Character.Components.SystemAbilities(References.ReduceTwoWeaponFighting1) Then
                    Penalty += 1
                End If

                Return Penalty

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'off hand penalty
        Private Function TwoWeaponFighting_OffHandPenalty() As Integer
            Try

                Dim Penalty As Integer

                If _Weapons.OffHandWeaponLight And _Proficiency.TwoWeaponFightingSkill >= Proficiency.TwoWeaponFightingProficiency.TwoWeaponFighting Then
                    Penalty = -2
                ElseIf _Weapons.OffHandWeaponLight Then
                    Penalty = -8
                ElseIf _Proficiency.TwoWeaponFightingSkill >= Proficiency.TwoWeaponFightingProficiency.TwoWeaponFighting Then
                    Penalty = -4
                Else
                    Penalty = -10
                End If

                If _Character.Components.SystemAbilities(References.ReduceTwoWeaponFighting2) Then
                    Penalty += 2
                ElseIf _Character.Components.SystemAbilities(References.ReduceTwoWeaponFighting1) Then
                    Penalty += 1
                End If

                Return Penalty

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'determine additional off hand attacks
        Private Sub TwoWeaponFighting_GetExtraOffHandAttacks()
            Try
                Select Case _Proficiency.TwoWeaponFightingSkill
                    Case Proficiency.TwoWeaponFightingProficiency.ImprovedTwoWeaponFighting
                        _OffHandAttacks.Add(CType(_BaseAttacks(0), Integer) - 5)
                    Case Proficiency.TwoWeaponFightingProficiency.GreaterTwoWeaponFighting
                        _OffHandAttacks.Add(CType(_BaseAttacks(0), Integer) - 5)
                        _OffHandAttacks.Add(CType(_BaseAttacks(0), Integer) - 10)
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#End Region

#Region "Helper Functions"

        Private Sub AdjustAttacks(ByRef Attacks As ArrayList, ByVal Modifier As Integer)
            Try
                For n As Integer = 0 To Attacks.Count - 1
                    Attacks(n) = CType(Attacks.Item(n), Integer) + Modifier
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Private Sub ExtraAttackAtBAB(ByRef Attacks As ArrayList)
            Try
                Attacks.Insert(1, Attacks(0))
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'Gets the armor check penalty from equiped shields to the DEX modifier when using weapon finesse
        Private Function ArmorAttackPenalty(Optional ByVal IncludePrimary As Boolean = False) As Integer

            If TypeOf _Weapons Is Rules.MonsterWeapons Then

                Dim TempPenalty, MaxArmorPenalty As Integer

                Dim MonsterWeapons As Rules.MonsterWeapons = CType(_Weapons, Rules.MonsterWeapons)
                TempPenalty = 0 : MaxArmorPenalty = 0

                If IncludePrimary Then
                    If _Weapons.PrimaryWield = Weapons.Wield.ShieldBash OrElse _Weapons.PrimaryWield = Weapons.Wield.Shield Then
                        Dim ArmorProperties As New ArmorProperties(_Weapons.PrimaryWeapon.BaseItem, _Weapons.PrimaryWeapon.Masterwork, _Weapons.PrimaryWeapon.Enhancement)
                        TempPenalty = ArmorProperties.CheckPenalty
                        If TempPenalty < MaxArmorPenalty Then
                            MaxArmorPenalty = TempPenalty
                        End If
                    End If
                End If

                For i As Integer = 1 To MonsterWeapons.OffHandCount
                    If MonsterWeapons.OffHandWield(i) = Weapons.Wield.Shield OrElse MonsterWeapons.OffHandWield(i) = Weapons.Wield.ShieldBash Then
                        Dim ArmorProperties As New ArmorProperties(MonsterWeapons.OffHandItem(i).BaseItem, MonsterWeapons.OffHandItem(i).Masterwork, MonsterWeapons.OffHandItem(i).Enhancement)
                        TempPenalty = ArmorProperties.CheckPenalty
                        If TempPenalty < MaxArmorPenalty Then
                            MaxArmorPenalty = TempPenalty
                        End If
                    End If
                Next

                Return MaxArmorPenalty

            Else

                If _Weapons.OffHandWield = Weapons.Wield.Shield OrElse _Weapons.OffHandWield = Weapons.Wield.ShieldBash Then
                    Dim ArmorProperties As New ArmorProperties(_Weapons.OffHandItem.BaseItem, _Weapons.OffHandItem.Masterwork, _Weapons.OffHandItem.Enhancement)
                    Return ArmorProperties.CheckPenalty
                Else
                    Return 0
                End If

            End If

        End Function

#End Region

    End Class

End Namespace