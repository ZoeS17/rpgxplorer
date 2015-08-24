Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class Proficiency

        'this class handles determining whether a character is proficient in the use of an item.

#Region "Enumerations"

        Public Enum ProficiencyLevel
            NotProficient
            Proficient
        End Enum

        Public Enum TwoWeaponFightingProficiency
            None
            TwoWeaponFighting
            ImprovedTwoWeaponFighting
            GreaterTwoWeaponFighting
        End Enum

#End Region

#Region "Member Variables"

        Private _Character As Character
        Private _TwoWeaponFightingSkill As TwoWeaponFightingProficiency

        'system ability flags
        Private SimpleWeapons, MartialWeapons, LightArmor, MediumArmor, HeavyArmor, Shields, TowerShield As Boolean

        'misc
        Public ArmorPenalty, ShieldPenalty As Integer

#End Region

#Region "Properties"

        'two weapon fighting
        Public ReadOnly Property TwoWeaponFightingSkill() As TwoWeaponFightingProficiency
            Get
                Return _TwoWeaponFightingSkill
            End Get
        End Property

#End Region

        'init
        Public Sub New(ByVal Character As Character)
            _Character = Character
        End Sub

        'calculate
        Public Sub Calculate(Optional ByVal Level As Integer = 1000)
            'determine two weapon fighting proficiency
            If _Character.Components.SystemAbilities(References.GreaterTwoWeaponFighting) Then
                _TwoWeaponFightingSkill = TwoWeaponFightingProficiency.GreaterTwoWeaponFighting
            ElseIf _Character.Components.SystemAbilities(References.ImprovedTwoWeaponFighting) Then
                _TwoWeaponFightingSkill = TwoWeaponFightingProficiency.ImprovedTwoWeaponFighting
            ElseIf _Character.Components.SystemAbilities(References.TwoWeaponFighting) Then
                _TwoWeaponFightingSkill = TwoWeaponFightingProficiency.TwoWeaponFighting
            Else
                _TwoWeaponFightingSkill = TwoWeaponFightingProficiency.None
            End If

            'get system abilities
            If _Character.Components.SystemAbilities(References.SimpleWeaponsProficiency, Level) Then SimpleWeapons = True Else SimpleWeapons = False
            If _Character.Components.SystemAbilities(References.MartialWeaponsProficiency, Level) Then MartialWeapons = True Else MartialWeapons = False
            If _Character.Components.SystemAbilities(References.ArmorProficiencyLight, Level) Then LightArmor = True Else LightArmor = False
            If _Character.Components.SystemAbilities(References.ArmorProficiencyMedium, Level) Then MediumArmor = True Else MediumArmor = False
            If _Character.Components.SystemAbilities(References.ArmorProficiencyHeavy, Level) Then HeavyArmor = True Else HeavyArmor = False
            If _Character.Components.SystemAbilities(References.ShieldsProficiency, Level) Then Shields = True Else Shields = False
            If _Character.Components.SystemAbilities(References.TowerShieldProficiency, Level) Then TowerShield = True Else TowerShield = False

            'armor prof. penalty
            If _Character.Inventory.ArmorWorn.IsNotEmpty Then
                If Proficient(_Character.Inventory.ArmorProperties.BaseArmor, _Character.Inventory.ArmorProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then ArmorPenalty = _Character.Inventory.ArmorProperties.CheckPenalty Else ArmorPenalty = 0
            End If

            'shield
            If _Character.Inventory.ShieldWorn.IsNotEmpty Then
                If Proficient(_Character.Inventory.ShieldProperties.BaseArmor, _Character.Inventory.ShieldProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then ShieldPenalty = _Character.Inventory.ShieldProperties.CheckPenalty Else ShieldPenalty = 0
            End If

        End Sub

        'get level of proficiency in weapon
        Public Function Proficient(ByVal BaseItem As Objects.ObjectData, ByVal Item As Objects.ObjectData, Optional ByVal Level As Integer = 1000, Optional ByVal Wield As Weapons.Wield = Weapons.Wield.NotSet) As ProficiencyLevel

            'check for shadows
            If BaseItem.Element("Shadows") <> "" Then
                Dim Key As Objects.ObjectKey = BaseItem.GetFKGuid("Shadows")
                BaseItem.Clear()
                BaseItem.Load(Key)
            End If

            Select Case BaseItem.Type
                Case Objects.WeaponDefinitionType
                    Select Case Item.Type
                        Case Objects.SpecificWeaponDefinitionType
                            'check for weapon emulation
                            Dim Weapon As Objects.ObjectData

                            For Each Emulation As Objects.ObjectData In Item.ChildrenOfType(Objects.WeaponEmulationType)
                                Weapon = Emulation.GetFKObject("WeaponDefinition")
                                If Me.Proficient(Weapon, Weapon, Level) = ProficiencyLevel.Proficient Then Return ProficiencyLevel.Proficient
                            Next

                            GoTo BaseWeapon
                        Case Else
BaseWeapon:
                            Select Case BaseItem.Element("Training")
                                Case "Simple"
                                    'simple weapons
                                    If SimpleWeapons Then
                                        Return ProficiencyLevel.Proficient
                                    Else
                                        If _Character.Feats.ContainsSubkey(References.SimpleWeaponProficiency, BaseItem.ObjectGUID, Level) Then
                                            If DirectCast(_Character.Feats.ItemData(References.SimpleWeaponProficiency, BaseItem.ObjectGUID, Level).Data, Character.Feat).Disabled = False Then
                                                Return ProficiencyLevel.Proficient
                                            End If
                                        End If
                                    End If
                                    Return ProficiencyLevel.NotProficient
                                Case "Martial"
Martial:
                                    'martial weapons
                                    If MartialWeapons Then
                                        Return ProficiencyLevel.Proficient
                                    Else
                                        If _Character.Feats.ContainsSubkey(References.MartialWeaponProficiency, BaseItem.ObjectGUID, Level) Then
                                            If DirectCast(_Character.Feats.ItemData(References.MartialWeaponProficiency, BaseItem.ObjectGUID, Level).Data, Character.Feat).Disabled = False Then
                                                Return ProficiencyLevel.Proficient
                                            End If
                                        End If
                                    End If
                                    Return ProficiencyLevel.NotProficient
                                Case "Exotic"
                                    'exotic weapons

                                    'proficiency
                                    If _Character.Feats.ContainsSubkey(References.ExoticWeaponProficiency, BaseItem.ObjectGUID, Level) Then
                                        If DirectCast(_Character.Feats.ItemData(References.ExoticWeaponProficiency, BaseItem.ObjectGUID, Level).Data, Character.Feat).Disabled = False Then
                                            Return ProficiencyLevel.Proficient
                                        End If
                                    Else
                                        'adjusted to martial?
                                        If BaseItem.Element("MartialOneHanded") = "Yes" And Wield = Weapons.Wield.TwoHanded Then GoTo Martial

                                        'check for racial weapon
                                        Dim RacialWeapons As Objects.ObjectDataCollection = _Character.RaceObject.ChildrenOfType(Objects.RacialWeaponType)
                                        If RacialWeapons.ContainsFK("Weapon", BaseItem.ObjectGUID) Then GoTo Martial

                                        Return ProficiencyLevel.NotProficient

                                    End If
                            End Select
                    End Select
                Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                    Select Case BaseItem.Element("Training")
                        Case "Heavy"
                            'heavy armor
                            If _Character.Components.SystemAbilities(References.ArmorProficiencyHeavy, Level) Then Return ProficiencyLevel.Proficient Else Return ProficiencyLevel.NotProficient
                        Case "Medium"
                            If _Character.Components.SystemAbilities(References.ArmorProficiencyMedium, Level) Then Return ProficiencyLevel.Proficient Else Return ProficiencyLevel.NotProficient
                        Case "Light"
                            If _Character.Components.SystemAbilities(References.ArmorProficiencyLight, Level) Then Return ProficiencyLevel.Proficient Else Return ProficiencyLevel.NotProficient
                        Case "Shield"
                            If BaseItem.Element("TowerShield") = "Yes" Then
                                If _Character.Components.SystemAbilities(References.TowerShieldProficiency) Then Return ProficiencyLevel.Proficient Else Return ProficiencyLevel.NotProficient
                            Else
                                If _Character.Components.SystemAbilities(References.ShieldsProficiency) Then Return ProficiencyLevel.Proficient Else Return ProficiencyLevel.NotProficient
                            End If
                    End Select
                Case Objects.NaturalWeaponDefinitionType
                    Return ProficiencyLevel.Proficient
            End Select
        End Function

    End Class

End Namespace
