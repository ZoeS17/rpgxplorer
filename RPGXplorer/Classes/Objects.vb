Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Imports System.Data.OleDb
Imports System.IO.Directory
Imports System.Windows.Forms
Imports System.Xml

Public Class Objects

#Region "Object Types"

#Region "Types"

    'type string constants
    Public Const AbilityPointGainedType As String = "Ability Point Gained"

    Public Const AmmoDefinitionType As String = "Ammunition Definition"

    Public Const ArmorDefinitionType As String = "Armor Definition"
    Public Const ArmorDefinitionFolderType As String = "Armor Definitions Folder"
    Public Const ArmorMagicAbilityDefinitionType As String = "Armor Magic Ability Definition"
    Public Const ArmorMagicAbilityDefinitionFolderType As String = "Armor Magic Ability Definitions Folder"

    Public Const ArtifactDefinitionType As String = "Artifact Definition"
    Public Const ArtifactDefinitionFolderType As String = "Artifact Definitions Folder"

    Public Const AssetsFolderType As String = "Assets Folder"

    Public Const AutomaticLanguageDefinitionType As String = "Automatic Language"

    Public Const BonusFeatType As String = "Bonus Feat"
    Public Const BonusLanguageDefinitionType As String = "Bonus Language"
    Public Const BonusSpellSlotsType As String = "Bonus Spell Slots"

    Public Const CannotUseType As String = "Cannot Use"

    Public Const CharacteristicType As String = "Characteristic"
    Public Const CharacteristicFolderType As String = "Characteristic Folder"
    Public Const CharacteristicDefinitionType As String = "Characteristic Definition"
    Public Const CharacteristicDefinitionFolderType As String = "Characteristic Definition Folder"

    Public Const CharacterFolderType As String = "Character Folder"
    Public Const CharacterType As String = "Character"
    Public Const CharacterLevelType As String = "Character Level"
    Public Const CharacterLevelsFolderType As String = "Character Levels Folder"

    Public Const ChooseBonusFeatType As String = "Choose Bonus Feat"
    Public Const ChooseBonusFeatChoiceType As String = "Choose Bonus Feat Choice"
    Public Const ChooseBonusFeatOfTypeType As String = "Choose Bonus Feat Type"
    Public Const ChooseBonusFeatOfTypeChoiceType As String = "Choose Bonus Feat Type Choice"
    Public Const ChooseBonusLanguageType As String = "Choose Bonus Language"
    Public Const ChooseFeatureType As String = "Choose Feature"
    Public Const ChooseFeatureMemberType As String = "Choose Feature Member"

    Public Const ClassFolderType As String = "Class Folder"
    Public Const ClassLevelsFolderType As String = "Class Levels Folder"
    Public Const ClassLevelsSpellsPerDayFolderType As String = "Spells Per Day Folder"
    Public Const ClassLevelsSpellsKnownFolderType As String = "Spells Known Folder"
    Public Const ClassType As String = "Class"
    Public Const ClassLevelType As String = "Class Level"
    Public Const ClassSkillType As String = "Class Skill"
    Public Const CrossClassSkillType As String = "Cross-class Skill"

    Public Const CombatStyleType As String = "Combat Style"
    Public Const CombatStyleImprovedFeatType As String = "Combat Style Improved Feat"
    Public Const CombatstyleMasteryFeatType As String = "Combat Style Mastery Feat"

    Public Const ColumnLayoutType As String = "Column Layout"

    Public Const ConditionType As String = "Condition"
    Public Const ConditionMemberType As String = "Condition Member"

    Public Const CreatureFeatureFolderType As String = "Creature Feature Folder"
    Public Const CreatureFeatureType As String = "Creature Feature"

    Public Const CurseType As String = "Curse"
    Public Const CurseMemberType As String = "Curse Member"

    Public Const DamageAdditionType As String = "Damage Addition"
    Public Const DamageReductionType As String = "Damage Reduction"
    Public Const DamageResistanceType As String = "Damage Resistance"
    Public Const DamageVulnerabilityType As String = "Damage Vulnerability"

    Public Const DeityDefinitionType As String = "Deity Definition"
    Public Const DeityDefinitionFolderType As String = "Deity Definitions Folder"
    Public Const DeityDomainChildType As String = "Deity Domain"
    Public Const DeityPsionicSpecializationChildType As String = "Deity Psionic Specialization"

    Public Const DomainDefinitionType As String = "Domain Definition"
    Public Const DomainDefinitionFolderType As String = "Domain Definitions Folder"

    Public Const DurationType As String = "Duration"

    Public Const EnhancementBonusType As String = "Enhancement Bonus"
    Public Const ExpiryConditionType As String = "Expiry Condition"

    Public Const FeatDefinitionsFolderType As String = "Feat Definitions Folder"
    Public Const FeatDefinitionType As String = "Feat Definition"
    Public Const FeatFolderType As String = "Feat Folder"
    Public Const FeatTakenType As String = "Feat Taken"
    Public Const FeatType As String = "Feat"
    Public Const FeatureDefinitionFolderType As String = "Feature Definitions Folder"
    Public Const FeatureDefinitionType As String = "Feature Definition"
    Public Const FeatureGainedType As String = "Feature Gained"
    Public Const FeatureFolderType As String = "Feature Folder"
    Public Const FeatureSupercededType As String = "Feature Superceded"
    Public Const FeatureType As String = "Feature"
    Public Const FighterBonusFeatType As String = "Fighter Bonus Feat"
    Public Const FilterType As String = "Filter"
    Public Const FilterTermType As String = "Filter Term"
    Public Const FlurryOfBlowsType As String = "Flurry of Blows"

    Public Const GrantedPowerType As String = "Granted Power"
    Public Const HTMLDocumentType As String = "HTML Document"

    Public Const ImprovedUnarmedDamageType As String = "Improved Unarmed Damage"
    Public Const InventoryFolderType As String = "Inventory Folder"
    Public Const IntelligenceType As String = "Intelligence"
    Public Const IntelligenceMemberType As String = "Intelligence Member"

    Public Const ItemType As String = "Item"
    Public Const ItemDefinitionType As String = "Item Definition"
    Public Const ItemDefinitionFolderType As String = "Item Definitions Folder"

    Public Const LanguageDefinitionFolderType As String = "Language Definitions Folder"
    Public Const LanguageDefinitionType As String = "Language Definition"
    Public Const LanguageType As String = "Language Known"
    Public Const LanguageFolderType As String = "Language Folder"

    Public Const LocationType As String = "Location"
    Public Const LocationsFolderType As String = "Locations Folder"

    Public Const MagicAmmoType As String = "Magic Ammo"
    Public Const MagicAmmoDefinitionType As String = "Magic Ammo Definition"
    Public Const MagicWeaponAbilityConditionalType As String = "Magic Weapon Ability Conditional"

    Public Const ModifierFolderType As String = "Modifier Folder"
    Public Const ModifierReferenceType As String = "Modifier Reference"
    Public Const ModifierType As String = "Modifier"
    Public Const Modifier2Type As String = "Modifier 2"
    Public Const ModifierLimiterType As String = "Modifier Limiter"
    Public Const ModifierLimiterFolderType As String = "Modifier Limiter Folder"

    Public Const MoneyType As String = "Money"

    Public Const MonsterTypeType As String = "Monster Type"
    Public Const MonsterTypeFolderType As String = "Monster Type Folder"

    Public Const PotionDefinitionType As String = "Potion Definition"
    Public Const PotionDefinitionFolderType As String = "Potion Definitions Folder"

    Public Const PrerequisiteChildType As String = "Prerequisite Child"
    Public Const PrerequisiteType As String = "Prerequisite"

    Public Const RaceFolderType As String = "Races Folder"
    Public Const RaceType As String = "Race"
    Public Const RacialAbilitiesFolderType As String = "Racial Abilities Folder"
    Public Const RacialWeaponType As String = "Racial Weapon"

    Public Const RegenerationType As String = "Regeneration"
    Public Const ReplaceKnownSpellType As String = "Replace Known Spell"

    Public Const RingDefinitionType As String = "Ring Definition"
    Public Const RingDefinitionFolderType As String = "Ring Definitions Folder"

    Public Const RodDefinitionType As String = "Rod Definition"
    Public Const RodDefinitionFolderType As String = "Rod Definitions Folder"

    Public Const RPGXplorerConfigurationType As String = "RPGXplorer Configuration"

    Public Const SetValueType As String = "Set Value"
    Public Const SecondaryEffectType As String = "Secondary Effect"

    Public Const ScrollDefinitionType As String = "Scroll Definition"
    Public Const ScrollDefinitionFolderType As String = "Scroll Definitions Folder"
    Public Const ScrollSpellType As String = "Scroll Spell"

    Public Const ShieldDefinitionType As String = "Shield Definition"

    Public Const ShoppingCartType As String = "Shopping Cart"

    Public Const SkillFolderType As String = "Skill Folder"
    Public Const SkillType As String = "Skill"
    Public Const SkillGroupType As String = "Skill Group"

    Public Const SkillDefinitionFolderType As String = "Skill Definitions Folder"
    Public Const SkillDefinitionType As String = "Skill Definition"

    Public Const SkillPointsSpentType As String = "Skill Points Spent"
    Public Const SkillSynergyType As String = "Skill Synergy"

    Public Const SpecificArmorAbilityType As String = "Specific Armor Ability"
    Public Const SpecificArmorDefinitionType As String = "Specific Armor Definition"
    Public Const SpecificArmorDefinitionFolderType As String = "Specific Armor Definitions Folder"

    Public Const SpecificBonusFeatType As String = "Specific Bonus Feat"
    Public Const SpecificBonusFeatChooseFocusType As String = "Specific Bonus Feat Choose Focus"

    Public Const SpecificWeaponAbilityType As String = "Specific Weapon Ability"
    Public Const SpecificWeaponDefinitionType As String = "Specific Weapon Definition"
    Public Const SpecificWeaponDefinitionFolderType As String = "Specific Weapon Definitions Folder"
    Public Const SpecificWeaponDoubleAbilityType As String = "Specific Weapon Double Ability"

    Public Const SpellCategoryDefinitionType As String = "Spell Category Definition"
    Public Const SpellCategoryFolder As String = "Spell Category Definitions Folder"
    Public Const SpellCategoryType As String = "Spell Category"

    Public Const SpellDefinitionType As String = "Spell Definition"
    Public Const SpellDefinitionFolderType As String = "Spell Definitions Folder"
    Public Const SpellDescriptorType As String = "Spell Descriptor"
    Public Const SpellDescriptorDefinitionType As String = "Spell Descriptor Definition"
    Public Const SpellDescriptorDefinitionFolderType As String = "Spell Descriptor Definition Folder"
    Public Const SpellFailureType As String = "Spell Failure"

    Public Const SpellLearnedType As String = "Spell Learned"

    Public Const SpellListFolderType As String = "Spell List Folder"
    Public Const SpellListItemType As String = "Spell List Item"

    Public Const SpellLevelType As String = "Spell Level"
    Public Const SpellResistanceType As String = "Spell Resistance"
    Public Const SpellSchoolType As String = "Spell School"
    Public Const SpellSchoolFolderType As String = "Spell School Folder"
    Public Const SpellsKnownType As String = "Spells Known"
    Public Const SpellsPerDayType As String = "Spells Per Day"
    Public Const SpellSubschoolType As String = "Spell Subschool"
    Public Const SpellSchoolSacrificedType As String = "Spell School Sacrificed"

    Public Const StaffDefinitionType As String = "Staff Definition"
    Public Const StaffDefinitionFolderType As String = "Staff Definitions Folder"
    Public Const StaffSpellType As String = "Staff Spell"

    Public Const SystemAbilityType As String = "System Ability"
    Public Const SystemAbilityDefinitionType As String = "System Ability Definition"
    Public Const SystemAbilityDefinitionFolderType As String = "System Ability Definitions Folder"

    Public Const SystemAlignmentType As String = "System Alignment"
    Public Const SystemAlignmentDefinitionType As String = "System Alignment Definition"
    Public Const SystemAlignmentDefinitionFolderType As String = "System Alignments Definitions Folder"

    Public Const SystemConditionType As String = "System Condition"
    Public Const SystemConditionsFolderType As String = "System Conditions Folder"
    Public Const SystemElementType As String = "System Element"
    Public Const SystemElementFolderType As String = "System Elements Folder"
    Public Const SystemFolderType As String = "System Folder"
    Public Const SystemPreconditionType As String = "System Precondition"
    Public Const SystemPreconditionDefinitionType As String = "System Precondition Definition"
    Public Const SystemPreconditionDefinitionFolderType As String = "System Precondition Definitions Folder"
    Public Const SystemReferenceType As String = "System Reference"
    Public Const SystemReferenceFolderType As String = "System References Folder"
    Public Const SystemRestrictionType As String = "System Restriction"
    Public Const SystemRestrictionDefinitionType As String = "System Restriction Definition"
    Public Const SystemRestrictionDefinitionFolderType As String = "System Restriction Definitions Folder"

    Public Const SystemWeaponAbilityType As String = "System Weapon Ability"
    Public Const SystemWeaponAbilityDefinitionType As String = "System Weapon Ability Definition"
    Public Const SystemWeaponAbilityDefinitionFolderType As String = "System Weapon Ability Definitions Folder"

    Public Const UserDocType As String = "User Document"
    Public Const UserDocMapType As String = "User Map"
    Public Const UserDocRulesType As String = "User Rules"
    Public Const UserFolderType As String = "User Folder"

    Public Const UserListItemType As String = "User List Item"

    Public Const UserPreconditionDefinitionType As String = "User Precondition Definition"
    Public Const UserPreconditionDefinitionFolderType As String = "User Precondition Definitions Folder"
    Public Const UserPreconditionType As String = "User Precondition"

    Public Const WandDefinitionType As String = "Wand Definition"
    Public Const WandDefinitionFolderType As String = "Wand Definitions Folder"

    Public Const WeaponConfigType As String = "Weapon Config"
    Public Const WeaponConfigFolderType As String = "Weapon Configs Folder"

    Public Const WeaponDefinitionType As String = "Weapon Definition"
    Public Const WeaponDefinitionFolderType As String = "Weapon Definitions Folder"
    Public Const WeaponEmulationType As String = "Weapon Emulation"
    Public Const WeaponMagicAbilityBane As String = "Weapon Magic Ability Bane"
    Public Const WeaponMagicAbilityDefinitionType As String = "Weapon Magic Ability Definition"
    Public Const WeaponMagicAbilityDefinitionFolderType As String = "Weapon Magic Ability Definitions Folder"

    Public Const WondrousDefinitionFolderType As String = "Wondrous Definitions Folder"
    Public Const WondrousDefinitionType As String = "Wondrous Definition"

    'RR Added 120505 - Character Wizard Choices
    Public Const CharacterChoiceFolderType As String = "Character Choice Folder"
    Public Const FavoredEnemyChoice As String = "Favored Enemy Choice"
    Public Const FavoredEnemySingleChoice As String = "Favored Enemy Single Choice"
    Public Const SpellSchoolSpecialistChoiceType As String = "Spell School Specialist Choice"
    Public Const SpellSchoolProhibitedChoiceType As String = "Spell School Prohibited Choice"
    Public Const SpellDomainChoiceType As String = "Spell Domain Choice"    'no longer used, old character spell panel
    Public Const CombatStyleChoiceType As String = "Combat Style Choice"

    'Prestige Class Objects
    Public Const PrestigeClassSpellcasterChoice As String = "Spellcaster Choice"
    Public Const ExistingSpellcasterLevel As String = "Existing Spellcaster Level"

    'Version 1.03 Modifer Panel
    Public Const ModifierInfoType As String = "Modifier Info"

    'document viewer
    Public Const RulesRootFolderType As String = "Rules Root Folder"
    Public Const RulePageType As String = "Rule Page"
    Public Const RuleTableType As String = "Rule Table"
    Public Const RuleFolderType As String = "Rule Folder"
    Public Const RuleFolderPageType As String = "Rule Folder Page"

    Public Const FavoriteRuleType As String = "Favorite Rule"
    Public Const FavoriteRuleFolderType As String = "Favorite Rule Folder"

    Public Const RulesTabInfoType As String = "Rules Tab Info"

    'bonus class skill/domain
    Public Const ExtraClassSkillType As String = "Extra Class Skill"
    Public Const BonusClassSkillType As String = "Bonus Class Skill"
    Public Const BonusClassSkillChoiceOrSpecificType As String = "Bonus Class Skill Choice or Specific"
    Public Const BonusDomainType As String = "Bonus Domain"
    Public Const BonusDomainChoiceOrSpecificType As String = "Bonus Domain Choice or Specific"

    'character's domains
    Public Const DomainType As String = "Domain"
    Public Const DomainAndSchoolsFolderType As String = "Domain Folder"

    'new spell stuff
    Public Const MagicFolderType As String = "Magic Folder"
    Public Const ClassSpellListFolderType As String = "Class Spells Folder"
    Public Const ClassSpellSettingsFolderType As String = "Class Spell Settings Folder"
    Public Const ClassSpellModifiersType As String = "Class Spell Modifiers"

    ''''''''''''''''''''psionics
    Public Const PowerDefinitionType As String = "Power Definition"
    Public Const PowerDefinitionFolderType As String = "Power Definitions Folder"
    Public Const PowerLevelType As String = "Power Level"

    Public Const PsionicDisciplineFolderType As String = "Psionic Disciplines Folder"
    Public Const PsionicDisciplineType As String = "Psionic Discipline"
    Public Const PsionicSubdisciplineType As String = "Psionic Subdiscipline"

    Public Const PsionicSpecializationDefinitionType As String = "Psionic Specialization Definition"
    Public Const PsionicSpecializationDefinitionFolderType As String = "Psionic Specialization Definitions Folder"

    Public Const PowerListFolderType As String = "Power List Folder"
    Public Const PowerListItemType As String = "Power List Item"

    Public Const ClassLevelsPowerProgressionFolderType As String = "Power Progression Folder"
    Public Const PowerProgressionType As String = "Power Progression"

    '''''''''''''''''''''psionic character objects
    Public Const PsionicSpecializationType As String = "Psionic Specialization"
    Public Const PsionicSpecializationFolderType As String = "Psionic Specializations Folder"
    Public Const PsionicFolderType As String = "Psionics Folder"
    Public Const PowerLearnedType As String = "Power Learned"
    Public Const ClassPowerListFolderType As String = "Class Powers Folder"
    Public Const ClassPowerSettingsFolderType As String = "Class Power Settings Folder"

    '''''''''''''''''''''psionic character leveling objects
    Public Const BonusPsionicSpecializationType As String = "Bonus Psionic Specialization"
    Public Const BonusPsionicSpecializationChoiceorSpecificType As String = "Bonus Psionic Specialization Choice or Specific"
    Public Const ExistingManifesterLevel As String = "Existing Manifester Level"

    '''''''''''''''''''''psionic item objects
    Public Const PsionicArtifactDefinitionsFolderType As String = "Psionic Artifact Definitions Folder"
    Public Const PsionicArtifactDefinitionType As String = "Psionic Artifact Definition"
    Public Const PsionicAmmoDefinitionType As String = "Psionic Ammo Definition"

    Public Const PsionicArmorAbilityDefinitionsFolderType As String = "Psionic Armor Ability Definitions Folder"
    Public Const PsionicArmorAbilityDefinitionType As String = "Psionic Armor Ability Definition"
    Public Const PsionicArmorAbilityType As String = "Psionic Armor Ability"

    Public Const PsionicArmorDefinitionsFolderType As String = "Psionic Armor Definitions Folder"
    Public Const PsionicArmorDefinitionType As String = "Psionic Armor Definition"

    Public Const PsionicDorjeDefinitionsFolderType As String = "Psionic Dorje Definitions Folder"
    Public Const PsionicDorjeDefinitionType As String = "Psionic Dorje Definition"

    Public Const PsionicPowerStoneDefinitionsFolderType As String = "Psionic Power Stone Definitions Folder"
    Public Const PsionicPowerStoneDefinitionType As String = "Psionic Power Stone Definition"
    Public Const PowerStoneSpellType As String = "Power Stone Spell"

    Public Const PsionicPsicrownDefinitionFolderType As String = "Psionic Psicrown Definitions Folder"
    Public Const PsionicPsicrownDefinitionType As String = "Psionic Psicrown Definition"
    Public Const PsicrownSpellType As String = "Psicrown Spell"

    Public Const PsionicTattooDefinitionsFolderType As String = "Psionic Tattoo Definitions Folder"
    Public Const PsionicTattooDefinitionType As String = "Psionic Tattoo Definition"

    Public Const PsionicWeaponAbilityDefinitionsFolderType As String = "Psionic Weapon Ability Definitions Folder"
    Public Const PsionicWeaponAbilityDefinitionType As String = "Psionic Weapon Ability Definition"
    Public Const PsionicWeaponAbilityType As String = "Psionic Weapon Ability"
    Public Const PsionicWeaponAbilityConditionalType As String = "Psionic Weapon Ability Conditional"
    Public Const PsionicWeaponAbilityDoubleType As String = "Psionic Weapon Ability Double"

    Public Const PsionicWeaponDefinitionsFolderType As String = "Psionic Weapons Definitions Folder"
    Public Const PsionicWeaponDefinitionType As String = "Psionic Weapon Definition"

    Public Const UniversalItemDefinitionFolderType As String = "Universal Item Definitions Folder"
    Public Const UniversalItemDefinitionType As String = "Universal Item Definition"

    Public Const TempFolderType As String = "Temp Folder"
    Public Const TempItemType As String = "Temp Item"

    'special materials
    Public Const SpecialMaterialDefinitionsFolderType As String = "Special Material Definitions Folder"
    Public Const SpecialMaterialDefinitionType As String = "Special Material Definition"

    '''''''''''''''''''''''''Monster Races 1.9.0
    Public Const MonsterRaceDefinitionFolderType As String = "Monster Race Definitions Folder"
    Public Const MonsterRaceDefinitionType As String = "Monster Race Definition"

    Public Const MonsterClassFolderType As String = "Monster Class Folder"
    Public Const MonsterClassType As String = "Monster Class"
    Public Const MonsterClassLevelType As String = "Monster Class Level"
    Public Const MonsterClassLevelsFolderType As String = "Monster Class Levels Folder"

    Public Const SetAbilityType As String = "Set Ability"
    Public Const SkillAbilityExchangeType As String = "Skill Ability Exchange"

    Public Const NaturalWeaponDefinitionsFolderType As String = "Natural Weapon Definitions Folder"
    Public Const NaturalWeaponDefinitionType As String = "Natural Weapon Definition"
    Public Const NaturalWeaponType As String = "Natural Weapon"

    Public Const SubtypeDefinitionsFolderType As String = "Subtype Definitions Folder"
    Public Const SubtypeDefinitionType As String = "Subtype Definition"
    Public Const SubtypeType As String = "Subtype"

    '''''''''''''''''''''''''Monsters 1.9.5

    Public Const MonsterFolderType As String = "Monster Folder"
    Public Const MonsterType As String = "Monster"

    Public Const SpellLikeAbilityType As String = "Spell Like Ability"
    Public Const PsiLikeAbilityType As String = "Psi Like Ability"

    Public Const SpellLikeAbilityTakenType As String = "Spell Like Ability Taken"
    Public Const PsiLikeAbilityTakenType As String = "Psi Like Ability Taken"

    Public Const SpellLikeAbilityFolderType As String = "Spell Like Ability Folder"
    Public Const PsiLikeAbilityFolderType As String = "Psi Like Ability Folder"

    Public Const SpellorPowerSourceType As String = "Spell or Power Source"

    Public Const MemorizedSpellsFolderType As String = "Memorized Spells Folder"
    Public Const MemorizedSpellType As String = "Memorized Spell"

#End Region

    'holds all the object type definitions
    Public Shared ReadOnly ObjectTypes As New ObjectTypeCollection
    Public Shared ReadOnly FocusTypes As New ObjectTypeCollection

    'type safe collection for object types
    Public Class ObjectTypeCollection
        Inherits System.Collections.Specialized.NameObjectCollectionBase

        Public Sub Add(ByVal Item As ObjectType)
            MyBase.BaseAdd(Item.Type, Item)
        End Sub

        Public Function Item(ByVal TypeName As String) As ObjectType
            Dim temp As ObjectType

            temp = DirectCast(MyBase.BaseGet(TypeName), ObjectType)

            If temp.Type Is Nothing Then Throw New DevelopmentException("Type not found")
            Return temp

        End Function

        Public Function List() As String()
            Return MyBase.BaseGetAllKeys
        End Function

        Public Function FriendlyList() As String()
            Dim temp As String()
            Dim n, upper As Integer

            upper = MyBase.Keys.Count - 1
            ReDim temp(upper)

            For n = 0 To upper
                temp(n) = DirectCast(MyBase.BaseGet(n), ObjectType).Friendly
            Next

            Return temp
        End Function

    End Class

    'simple structure used to hold an object type definition
    Public Structure ObjectType
        Public Type As String
        Public ShowInTree As Boolean
        Public ShowInListView As Boolean
        Public Fixed As Boolean
        Public ImageFilename As String
        Public SortType As SortType
        Public SelectLabel As String
        Public Friendly As String
        Public AllowFocus As Boolean
        Public ViewSettings As Char
        'Public AllowDelete As Boolean
        'Public AllowEdit As Boolean
        'Public AllowDrag As Boolean
        'Public AllowCopy As Boolean
        'Public CopyAsType As String

        'function to clear this structure
        Public Sub ClearData()
            Me.Type = Nothing
            Me.ShowInTree = Nothing
            Me.ShowInListView = Nothing
            Me.Fixed = Nothing
            Me.ImageFilename = Nothing
            Me.SortType = Nothing
            Me.SelectLabel = Nothing
            Me.Friendly = Nothing
            Me.ViewSettings = Nothing
        End Sub
    End Structure

    ''load the object type definitons
    'Public Shared Sub LoadObjectTypeDefinitions()
    '    Dim sw As Stopwatch = Stopwatch.StartNew()
    '    Dim ds As New DataSet
    '    Dim dr As DataRow

    '    ds.ReadXml(General.BasePath & "XML\ObjectTypes.xml")

    '    For Each dr In ds.Tables("ObjectType").Rows
    '        Dim ObjectType As New Objects.ObjectType
    '        ObjectType.Type = dr("Type").ToString()
    '        ObjectType.ShowInTree = CBool(dr("ShowInTree").ToString())
    '        ObjectType.ShowInListView = CBool(dr("ShowInListView").ToString())
    '        ObjectType.Fixed = CBool(dr("Fixed").ToString())
    '        ObjectType.ImageFilename = dr("ImageFilename").ToString()
    '        Select Case dr("SortType").ToString()
    '            Case "Alphabetic"
    '                ObjectType.SortType = SortType.Alphabetic
    '            Case "Numeric"
    '                ObjectType.SortType = SortType.Numeric
    '            Case "NumericPrefix"
    '                ObjectType.SortType = SortType.NumericPrefix
    '            Case "NumericSuffix"
    '                ObjectType.SortType = SortType.NumericSuffix
    '        End Select
    '        ObjectType.SelectLabel = dr("SelectLabel").ToString()
    '        ObjectType.Friendly = dr("Friendly").ToString()
    '        ObjectType.AllowFocus = CBool(dr("AllowFocus").ToString())
    '        ObjectType.ViewSettings = CChar(dr("ViewSettings").ToString())
    '        Objects.ObjectTypes.Add(ObjectType)
    '        If ObjectType.AllowFocus Then Objects.FocusTypes.Add(ObjectType)
    '    Next
    '    sw.Stop()
    'End Sub

    'load the object type definitons
    Public Shared Sub LoadObjectTypeDefinitions()
        'Dim sw As Stopwatch = Stopwatch.StartNew()

        Dim XmlRdr As System.Xml.XmlTextReader
        Dim ObjectType As New Objects.ObjectType

        XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\ObjectTypes.xml")

        While XmlRdr.Read
            'get the list view col definition
            Select Case XmlRdr.NodeType
                Case System.Xml.XmlNodeType.Element
                    Select Case XmlRdr.Name
                        Case "ObjectType"
                            ObjectType.ClearData()
                        Case "Type"
                            ObjectType.Type = XmlRdr.ReadString
                        Case "ShowInTree"
                            ObjectType.ShowInTree = CBool(XmlRdr.ReadString)
                        Case "ShowInListView"
                            ObjectType.ShowInListView = CBool(XmlRdr.ReadString)
                        Case "Fixed"
                            ObjectType.Fixed = CBool(XmlRdr.ReadString)
                        Case "ImageFilename"
                            ObjectType.ImageFilename = XmlRdr.ReadString
                        Case "SortType"
                            Select Case XmlRdr.ReadString
                                Case "Alphabetic"
                                    ObjectType.SortType = SortType.Alphabetic
                                Case "Numeric"
                                    ObjectType.SortType = SortType.Numeric
                                Case "NumericPrefix"
                                    ObjectType.SortType = SortType.NumericPrefix
                                Case "NumericSuffix"
                                    ObjectType.SortType = SortType.NumericSuffix
                            End Select
                        Case "SelectLabel"
                            ObjectType.SelectLabel = XmlRdr.ReadString
                        Case "Friendly"
                            ObjectType.Friendly = XmlRdr.ReadString
                        Case "AllowFocus"
                            ObjectType.AllowFocus = CBool(XmlRdr.ReadString)
                        Case "ViewSettings"
                            ObjectType.ViewSettings = CChar(XmlRdr.ReadString)
                    End Select
                Case System.Xml.XmlNodeType.EndElement
                    'write to the database once we have a full column 
                    If XmlRdr.Name = "ObjectType" Then
                        Objects.ObjectTypes.Add(ObjectType)
                        If ObjectType.AllowFocus Then Objects.FocusTypes.Add(ObjectType)
                    End If
            End Select
        End While
        'sw.Stop()
    End Sub

#End Region

#Region "Object Data"

    'object key
    <Serializable()> _
    Public Structure ObjectKey
        Public Database As Integer
        Public ObjectGuid As Guid

        'init
        Public Sub New(ByVal Key As String)
            If Key.Length <> 40 Then Throw New DevelopmentException("Bad Key Length")
            Database = CType(Key.Substring(0, 3), Integer)
            ObjectGuid = New Guid(Key.Substring(4, 36))
        End Sub

        'equals
        Public Shadows Function Equals(ByVal Key As ObjectKey) As Boolean
            Return Key.ObjectGuid.Equals(ObjectGuid)
        End Function

        'empty
        Public Shared Function Empty() As ObjectKey
            Dim Temp As ObjectKey
            Return Temp
        End Function

        'is key empty
        Public Function IsEmpty() As Boolean
            If ObjectGuid.Equals(Guid.Empty) Then Return True Else Return False
        End Function

        'is key not empty
        Public Function IsNotEmpty() As Boolean
            If Not ObjectGuid.Equals(Guid.Empty) Then Return True Else Return False
        End Function

        'new guid
        Public Shared Function NewGuid(ByVal Database As Integer) As ObjectKey
            Dim Temp As ObjectKey

            Temp.Database = Database
            Temp.ObjectGuid = Guid.NewGuid

            Return Temp
        End Function

        'tostring
        Public Shadows Function ToString() As String
            Return XML.PadDBNumber(Database) & "-" & ObjectGuid.ToString
        End Function

    End Structure

    'the core data for an object
    Public Structure ObjectData
        Implements IComparable

#Region "Member Variables"

        Private _XMLNode As System.Xml.XmlNode

        Private NameSet As Boolean
        Private _Name As String
        Private TypeSet As Boolean
        Private _Type As String
        Private KeySet As Boolean
        Private _ObjectGUID As ObjectKey
        Private ParentKeySet As Boolean
        Private _ParentGUID As ObjectKey
        Private HTMLSet As Boolean
        Private _HTML As String
        Private HTMLGUIDSet As Boolean
        Private _HTMLGUID As ObjectKey
        Private FixedSet, FixedOverride As Boolean
        Private _Fixed As Boolean
        Private ImageFilenameSet, ImageFilenameOverride As Boolean
        Private _ImageFilename As String

        Public URL As String

        Private NodeAdded As Boolean

        Private FKsLoaded As Boolean
        Private _FKs As ArrayList

#End Region

        'has the object been loaded?
        Public ReadOnly Property IsEmpty() As Boolean
            Get
                If _ObjectGUID.Equals(ObjectKey.Empty) Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

        'not isempty
        Public ReadOnly Property IsNotEmpty() As Boolean
            Get
                Return Not IsEmpty
            End Get
        End Property

        'the xml node itself
        Public ReadOnly Property XMLNode() As System.Xml.XmlNode
            Get
                If _XMLNode Is Nothing Then
                    'create the node
                    _XMLNode = XML.CreateNode(ObjectGUID.Database, "RPGXplorerObject")

                    If _XMLNode Is Nothing Then
                        'if the node is still nothing there has been a problem - Throw exception or we go into a stack overflow
                        Throw New DevelopmentException("Unexpected Database identifier - ID = " & ObjectGUID.Database.ToString)
                    End If

                    'always create the core elements regardless of whether they have been set yet, so that they appear first in the xml.
                    Element("Name") = ""
                    Element("Type") = ""
                    Element("ObjectGUID") = ""
                    Element("ParentGUID") = ""
                    Element("HTML") = ""
                    Element("HTMLGUID") = ""

                    NodeAdded = False
                End If

                Return _XMLNode
            End Get
        End Property

        'name property
        Public Property Name() As String
            Get
                If Not KeySet Then Return ""
                If Not NameSet Then
                    _Name = XMLNode.SelectSingleNode("./Name").InnerText
                End If

                'certain object types and references have names that are dynamic
                Dim Temp As String
                Dim Obj As New Objects.ObjectData
                Select Case Type
                    Case Objects.AssetsFolderType
                        _Name = "Inventory - Assets"
                    Case Objects.AutomaticLanguageDefinitionType
                        _Name = Me.Element("Language")
                    Case Objects.BonusClassSkillChoiceOrSpecificType
                        If Me.Element("ChoiceType") = "Specific" Then
                            _Name = "Bonus Class Skill: " & Me.Element("Specific")
                        Else
                            _Name = "Choice of Bonus Class Skill"
                        End If
                    Case Objects.BonusDomainChoiceOrSpecificType
                        If Me.Element("ChoiceType") = "Specific" Then
                            _Name = "Bonus Domain: " & Me.Element("Specific")
                        Else
                            _Name = "Choice of Bonus Domain"
                        End If
                    Case Objects.BonusLanguageDefinitionType
                        _Name = Me.Element("Language")
                    Case Objects.BonusPsionicSpecializationChoiceorSpecificType
                        If Me.Element("ChoiceType") = "Specific" Then
                            _Name = "Bonus Psionic Specialization: " & Me.Element("Specific")
                        Else
                            _Name = "Choice of Bonus Psionic Specialization"
                        End If
                    Case Objects.ClassSkillType
                        If Me.Element("Ranks") = "" OrElse Me.Element("Ranks") = "0" Then
                            _Name = Me.Element("Skill")
                        ElseIf Me.Element("Ranks") = "1" Then
                            _Name = Me.Element("Skill") & " (" & Me.Element("Ranks") & " Rank)"
                        Else
                            _Name = Me.Element("Skill") & " (" & Me.Element("Ranks") & " Ranks)"
                        End If
                    Case Objects.ConditionMemberType
                        Temp = Me.GetFirstFKElement
                        If Temp <> "" Then _Name = Temp
                    Case Objects.CrossClassSkillType
                        _Name = Me.Element("Skill")
                    Case Objects.DeityDomainChildType
                        _Name = Me.Element("Domain")
                    Case Objects.DeityPsionicSpecializationChildType
                        _Name = Me.Element("Specialization")
                    Case Objects.DomainType
                        _Name = Me.Element("Domain")
                    Case Objects.ExistingSpellcasterLevel
                        Dim ClassDef As Objects.ObjectData = Me.Parent.Parent.Parent
                        Select Case ClassDef.Element("PrestigeSpellType")
                            Case "Arcane"
                                _Name = "+1 Level of Existing Arcane Spellcasting Class"
                            Case "Divine"
                                _Name = "+1 Level of Existing Divine Spellcasting Class"
                            Case "Both"
                                _Name = "+1 Level each of Existing Arcane and Divine Spellcasting Class"
                            Case "Either"
                                _Name = "+1 Level of Existing Spellcasting Class"
                        End Select
                    Case Objects.ExistingManifesterLevel
                        _Name = "+1 Level of Existing Manifester Class"
                    Case Objects.ExpiryConditionType
                        _Name = "Expiry Condition (" & Me.Element("Condition") & ")"
                    Case Objects.FeatureType
                        Obj.Load(Me.GetFKGuid("Feature"))
                        _Name = Obj.Name
                    Case Objects.FeatType, Objects.FeatTakenType, Objects.SpecificBonusFeatType, Objects.SpecificBonusFeatChooseFocusType, Objects.ChooseBonusFeatChoiceType
                        _Name = Me.Element("Feat")
                        Temp = Me.Element("Focus")
                        If Temp <> "" Then _Name &= " (" & Temp & ")"
                    Case Objects.FlurryOfBlowsType
                        Temp = Me.Element("Penalty")
                        If Temp = "0" Then
                            _Name = "Flurry of Blows +" & Me.Element("BonusAttacks") & " Attack(s), No Penalty"
                        Else
                            _Name = "Flurry of Blows +" & Me.Element("BonusAttacks") & " Attack(s), " & Temp & " on Attack Rolls"
                        End If
                    Case Objects.LanguageType
                        _Name = Me.Element("Language")
                    Case Objects.MagicWeaponAbilityConditionalType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.MemorizedSpellType
                        _Name = Me.Element("Class") & " " & Me.Element("Level")
                        Select Case Me.Element("SlotType")
                            Case "Domain"
                                _Name &= " (D)"
                            Case "Specialist"
                                _Name &= " (S)"
                        End Select
                    Case Objects.ModifierType
                        _Name = Rules.Formatting.ModifierName(Me)
                    Case Objects.NaturalWeaponType
                        _Name = Me.Element("Weapon")
                        'Case Objects.NaturalWeaponDefinitionType
                        '    _Name = Me.Element("AttackType") & " (" & Me.Element("Damage") & ")"
                    Case Objects.PowerLevelType
                        _Name = Me.Element("Class") & Me.Element("DisciplineSpecialization") & " " & Me.Element("Level")
                    Case Objects.PowerStoneSpellType
                        _Name = Me.Element("Power")
                    Case Objects.PsionicArmorAbilityType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.PsionicSpecializationType
                        _Name = Me.Element("PsionicSpecialization")
                    Case Objects.PsionicWeaponAbilityType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.PsionicWeaponAbilityConditionalType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.PsionicWeaponAbilityDoubleType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.PsicrownSpellType
                        _Name = Me.Element("Power")
                    Case Objects.PsiLikeAbilityType
                        _Name = Me.Element("Power") & " - " & Me.Element("Usage")
                    Case Objects.PsiLikeAbilityTakenType
                        _Name = Me.Element("Power") & " - " & Me.Element("Usage")
                    Case Objects.ScrollSpellType
                        _Name = Me.Element("Spell")
                    Case Objects.SetAbilityType
                        _Name = Rules.Formatting.SetAbilityName(Me)
                    Case Objects.SetValueType
                        _Name = Rules.Formatting.SetValueName(Me)
                    Case Objects.SkillAbilityExchangeType
                        _Name = Me.Element("Skill") & " Modified by " & Me.Element("Ability") & " mod"
                    Case Objects.SkillSynergyType
                        _Name = Rules.Formatting.SynergyName(Me)
                    Case Objects.SkillType
                        _Name = Me.Element("Skill")
                    Case Objects.SpellLevelType
                        _Name = Me.Element("Class") & Me.Element("Domain") & Me.Element("Category") & " " & Me.Element("Level")
                    Case Objects.SpellResistanceType
                        _Name = "Spell Resistance " & Me.Element("Number")
                    Case Objects.SpellSchoolSacrificedType
                        _Name = Me.Element("School")
                    Case Objects.SpellDescriptorType
                        _Name = Me.Element("SpellDescriptor")
                    Case Objects.SpellLikeAbilityType
                        _Name = Me.Element("Spell") & " - " & Me.Element("Usage")
                    Case Objects.SpellLikeAbilityTakenType
                        _Name = Me.Element("Spell") & " - " & Me.Element("Usage")
                    Case Objects.SpellorPowerSourceType
                        _Name = Me.Element("Source")
                    Case Objects.SpecificArmorAbilityType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.SpecificWeaponAbilityType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.SpecificWeaponDoubleAbilityType
                        _Name = Me.Element(Me.GetFirstFKElementName)
                    Case Objects.StaffSpellType
                        _Name = Me.Element("Spell")
                    Case Objects.SubtypeType
                        _Name = Me.Element("Subtype")
                    Case Objects.SystemAbilityType
                        _Name = Me.GetFKObject("SystemAbilityDefinition").Name
                End Select

                If Not _Name = "" Then NameSet = True
                Return _Name
            End Get
            Set(ByVal Value As String)
                Value = CommonLogic.StripNameDisallowedChars(Value)
                _Name = Value
                NameSet = True
            End Set
        End Property

        'type property
        Public Property Type() As String
            Get
                If Not KeySet Then Return ""
                If Not TypeSet Then
                    _Type = XMLNode.SelectSingleNode("./Type").InnerText
                    TypeSet = True
                End If
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
                TypeSet = True
            End Set
        End Property

        'object key
        Public Property ObjectGUID() As ObjectKey
            Get
                Return _ObjectGUID
            End Get
            Set(ByVal value As ObjectKey)
                _ObjectGUID = value
                KeySet = True
            End Set
        End Property

        'parent key
        Public Property ParentGUID() As ObjectKey
            Get
                If Not KeySet Then Return Objects.ObjectKey.Empty
                If Not ParentKeySet Then
                    _ParentGUID = New ObjectKey(XMLNode.SelectSingleNode("./ParentGUID").InnerText)
                    ParentKeySet = True
                End If
                Return _ParentGUID
            End Get
            Set(ByVal value As ObjectKey)
                _ParentGUID = value
                ParentKeySet = True
            End Set
        End Property

        'return the parent of this object
        Public Function Parent() As ObjectData
            If ParentGUID.IsNotEmpty Then
                Dim retParent As New ObjectData
                retParent.Load(Me.ParentGUID)
                Return retParent
            End If
            Return Nothing
        End Function

        'html
        Public Property HTML() As String
            Get
                If Not KeySet Then Return ""
                If Not HTMLSet Then
                    _HTML = XMLNode.SelectSingleNode("./HTML").InnerText
                    HTMLSet = True
                End If
                Return _HTML
            End Get
            Set(ByVal value As String)
                _HTML = value
                HTMLSet = True
            End Set
        End Property

        'html guid
        Public Property HTMLGUID() As Objects.ObjectKey
            Get
                If Not KeySet Then Return Objects.ObjectKey.Empty
                If Not HTMLGUIDSet Then
                    Dim Temp As XmlNode = XMLNode.SelectSingleNode("./HTMLGUID")
                    If Temp IsNot Nothing AndAlso Temp.InnerText <> "" Then
                        _HTMLGUID = New Objects.ObjectKey(Temp.InnerText)
                    Else
                        _HTMLGUID = Objects.ObjectKey.Empty
                    End If
                    HTMLGUIDSet = True
                End If
                Return _HTMLGUID
            End Get
            Set(ByVal value As Objects.ObjectKey)
                _HTMLGUID = value
                HTMLGUIDSet = True
            End Set
        End Property

        'fixed property
        Public Property Fixed() As Boolean
            Get
                If Not KeySet Then Return False
                If Not FixedSet Then
                    Dim Temp As XmlNode = XMLNode.SelectSingleNode("./Fixed")
                    If Temp IsNot Nothing Then
                        _Fixed = CBool(Temp.InnerText)
                        FixedOverride = True
                    Else
                        _Fixed = ObjectTypes.Item(Me.Type).Fixed
                    End If
                    FixedSet = True
                End If
                Return _Fixed
            End Get
            Set(ByVal Value As Boolean)
                _Fixed = Value
                FixedSet = True
                FixedOverride = True
            End Set
        End Property

        'image filename property
        Public Property ImageFilename() As String
            Get
                If Not KeySet Then Return ""
                If Not ImageFilenameSet Then
                    Dim Temp As XmlNode = XMLNode.SelectSingleNode("./ImageFilename")
                    If Temp IsNot Nothing Then
                        _ImageFilename = Temp.InnerText
                        If _ImageFilename = "" Then GoTo GetFromType
                        ImageFilenameOverride = True
                    Else
GetFromType:
                        Dim Type As String = Me.Type
                        If Type <> "" Then _ImageFilename = ObjectTypes.Item(Me.Type).ImageFilename Else Return ""
                    End If
                    ImageFilenameSet = True
                End If
                Return _ImageFilename
            End Get
            Set(ByVal Value As String)
                _ImageFilename = Value
                ImageFilenameSet = True
                ImageFilenameOverride = True
            End Set
        End Property

        'ToString
        Public Overrides Function ToString() As String
            Return Name
        End Function

        'load the object from the xml db
        Public Sub Load(ByVal ObjectKey As ObjectKey)
            'Flags
            NameSet = False
            TypeSet = False
            KeySet = True
            ParentKeySet = False
            HTMLSet = False
            HTMLGUIDSet = False
            FixedSet = False
            FixedOverride = False
            ImageFilenameSet = False
            ImageFilenameOverride = False

            'Key and XMLNode
            _ObjectGUID = ObjectKey
            _XMLNode = XML.SelectSingleNode(_ObjectGUID.Database, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='" & _ObjectGUID.ToString & "']")
            If Not _XMLNode Is Nothing Then NodeAdded = True Else Debug.WriteLine("Object Not Found: " & _ObjectGUID.ToString)
        End Sub

        'load the object from an xml node directly (assumes node came from db - don't use any other way)
        Public Sub LoadFromNode(ByVal Node As XmlNode)
            'Flags
            NameSet = False
            TypeSet = False
            KeySet = True
            ParentKeySet = False
            HTMLSet = False
            HTMLGUIDSet = False
            FixedSet = False
            FixedOverride = False
            ImageFilenameSet = False
            ImageFilenameOverride = False

            'XML Node and Key
            _XMLNode = Node
            _ObjectGUID = New ObjectKey(_XMLNode.SelectSingleNode("./ObjectGUID").InnerText)
            NodeAdded = True
        End Sub

        'save the object
        Public Sub Save(Optional ByVal DisableFKUpdates As Boolean = False)
            Element("Name") = Name
            Element("Type") = Type
            Element("ObjectGUID") = ObjectGUID.ToString
            Element("ParentGUID") = ParentGUID.ToString

            Select Case Type
                Case Objects.ColumnLayoutType
                    'finished
                Case Else
                    If HTMLGUID.Equals(ObjectKey.Empty) And HTML = "" Then CreateDefaultRulePage()
                    Element("HTML") = HTML
                    Element("HTMLGUID") = HTMLGUID.ToString
                    Element("ImageFilename") = ImageFilename
                    If FixedOverride Then Element("Fixed") = _Fixed.ToString
            End Select

            If NodeAdded = False Then
                XML.AddNode(ObjectGUID.Database, _XMLNode)
                NodeAdded = True
            End If

            If Not DisableFKUpdates Then
                SaveUpdateFKs()
                UpdateReferringObjects()
            End If
        End Sub

        'show in tree property
        Public ReadOnly Property ShowInTree() As Boolean
            Get
                If Me.Type = Objects.ItemType Then
                    Select Case Me.Element("ItemType")
                        Case Objects.ItemDefinitionType, Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.PsionicArtifactDefinitionType, Objects.UniversalItemDefinitionType
                            Dim Item As Objects.ObjectData

                            Item = Me.GetFKObject("Item")
                            If Item.Element("IsContainer") = "Yes" Then Return True Else Return False
                        Case "User"
                            If Element("IsContainer") = "Yes" Then Return True Else Return False
                        Case Else
                            Return False
                    End Select
                Else
                    Return ObjectTypes.Item(Me.Type).ShowInTree
                End If
            End Get
        End Property

#Region "Foreign Keys"

        'foreign key list
        Private ReadOnly Property FKs() As ArrayList
            Get
                If Not FKsLoaded Then
                    Dim FKNodes As XmlNodeList = _XMLNode.SelectNodes("./*[@FK]")
                    If FKNodes IsNot Nothing Then
                        _FKs = New ArrayList
                        For Each FKNode As XmlNode In FKNodes
                            Dim FK As New Objects.ObjectKey(FKNode.Attributes("FK").Value)
                            _FKs.Add(FK)
                        Next
                    End If
                End If
                FKsLoaded = True
                Return _FKs
            End Get
        End Property

        'update the fk lookup with any foreign keys contained in the object
        Private Sub SaveUpdateFKs()
            Dim FKNodes As XmlNodeList = _XMLNode.SelectNodes("./*[@FK]")
            Dim FK As Objects.ObjectKey
            Dim CurrentFKs As New ArrayList

            'get all the fks
            For Each FKNode As XmlNode In FKNodes
                FK = New Objects.ObjectKey(FKNode.Attributes("FK").Value)
                XML.FKLookup.AddItemWithSubkey(FK, ObjectGUID)

                'keep a note of fks currently present
                CurrentFKs.Add(FK)
            Next

            'remove redundant fks
            If Not FKs Is Nothing Then
                For Each OldFK As Objects.ObjectKey In FKs
                    If Not CurrentFKs.Contains(OldFK) Then XML.FKLookup.RemoveItem(OldFK, Me.ObjectGUID)
                Next
            End If

            'update list
            _FKs = CurrentFKs
        End Sub

        'Create a FK element (a foreign key)
        Public Sub FKElement(ByVal Name As String, ByVal Value As String, ByVal ReferenceElement As String, ByVal FK As ObjectKey)
            Dim Node As System.Xml.XmlNode
            Dim Attr As System.Xml.XmlAttribute

            'check to see if the node exists already
            Node = XMLNode.SelectSingleNode("./" & Name)

            If Node Is Nothing Then
                'create the node
                Node = XML.CreateNode(ObjectGUID.Database, Name)
                XMLNode.AppendChild(Node)
            Else
                Node.Attributes.RemoveAll()
            End If

            'add the FK ObjectKey attribute
            Attr = XML.CreateAttribute(ObjectGUID.Database, "FK")
            Attr.Value = FK.ToString
            Node.Attributes.Append(Attr)

            'add the reference element name attribute
            Attr = XML.CreateAttribute(ObjectGUID.Database, "reference")
            Attr.Value = ReferenceElement
            Node.Attributes.Append(Attr)

            Node.InnerText = Value
        End Sub

        'set a FK to null
        Public Sub FKSetNull(ByVal Name As String)
            Dim Node As System.Xml.XmlNode

            'check to see if the node exists already
            Node = XMLNode.SelectSingleNode("./" & Name)

            If Node Is Nothing Then
                'create the node
                Node = XML.CreateNode(ObjectGUID.Database, Name)
                XMLNode.AppendChild(Node)
            End If

            Node.InnerText = ""
            Node.Attributes.RemoveAll()
        End Sub

        'get the ObjectKey of a FK element
        Public Function GetFKGuid(ByVal ElementName As String) As ObjectKey
            If _XMLNode Is Nothing Then Return ObjectKey.Empty

            'check to see if the node exists already
            Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./" & ElementName)

            If Node Is Nothing Then
                Return ObjectKey.Empty
            Else
                Dim Attr As System.Xml.XmlAttribute = Node.Attributes("FK")
                If Attr Is Nothing Then
                    Return ObjectKey.Empty
                Else
                    Return New ObjectKey(Attr.Value)
                End If
            End If
        End Function

        'get the reference of a FK element
        Public Function GetFKReference(ByVal ElementName As String) As String
            Dim Node As System.Xml.XmlNode
            Dim Attr As System.Xml.XmlAttribute

            'check to see if the node exists already
            Node = XMLNode.SelectSingleNode("./" & ElementName)

            If Node Is Nothing Then
                Return ""
            Else
                Attr = Node.Attributes("reference")
                If Attr Is Nothing Then
                    Return ""
                Else
                    Return Attr.Value
                End If
            End If
        End Function

        'get the object pointed to by a FK Element
        Public Function GetFKObject(ByVal ElementName As String) As ObjectData
            Dim temp As ObjectKey
            Dim retGetFKObject As New ObjectData

            temp = GetFKGuid(ElementName)
            If temp.IsNotEmpty Then
                retGetFKObject.Load(temp)
            End If
            Return retGetFKObject
        End Function

        'update all the foreign keys that refer to this object
        Public Sub UpdateReferringObjects()
            'get all the keys that have FKs to a particular object
            Dim Keys As ObjectHashtable = XML.FKLookup.Subkeys(ObjectGUID)

            If Not Keys Is Nothing Then

                Dim Databases As Boolean()
                ReDim Databases(XML.DBTypes.Count)

                'construct a list of the databases that contain references
                For Each Key As Objects.ObjectKey In Keys.Keys
                    Databases(Key.Database) = True
                Next

                'loop through each db and update all keys
                For DB As Integer = 1 To XML.DBTypes.Count
                    For Each Node As XmlNode In XML.SelectNodes(DB, "//*[@FK='" & ObjectGUID.ToString & "']")
                        Node.InnerText = Element(Node.Attributes("reference").Value)
                    Next
                Next
            End If
        End Sub

        'update any FKs an object has
        Public Sub UpdateForeignKeys()
            If _XMLNode Is Nothing Then Exit Sub

            Dim Attr_Reference As System.Xml.XmlAttribute
            Dim RefNode As System.Xml.XmlNode
            Dim Nodelist As System.Xml.XmlNodeList
            Dim FK As ObjectKey

            Nodelist = _XMLNode.SelectNodes("./*[@FK]")

            If Nodelist.Count > 0 Then
                For Each Node As XmlNode In Nodelist
                    Attr_Reference = Node.Attributes("reference")
                    FK = GetFKGuid(Node.Name)
                    If FK.Database > 0 Then
                        RefNode = XML.SelectSingleNode(FK.Database, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='" & FK.ToString & "']")
                        If Not RefNode Is Nothing Then
                            RefNode = RefNode.SelectSingleNode("./" & Attr_Reference.Value)
                            FKElement(Node.Name, RefNode.InnerText, Attr_Reference.Value, FK)
                        End If
                    End If
                Next
            End If
        End Sub

        'gets the contents of the first FK element in this object
        Public Function GetFirstFKElement() As String
            Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./*[@FK]")

            If Not Node Is Nothing Then
                Return Node.InnerText
            Else
                Return ""
            End If
        End Function

        'gets the name of the first FK element
        Public Function GetFirstFKElementName() As String
            Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./*[@FK]")

            If Not Node Is Nothing Then
                Return Node.Name
            Else
                Return ""
            End If
        End Function

        'gets the FK element names for this object
        Public Function GetAllFKElements() As ArrayList

            GetAllFKElements = New ArrayList

            Dim Nodelist As System.Xml.XmlNodeList
            Nodelist = XMLNode.SelectNodes("./*[@FK]")

            If Nodelist.Count > 0 Then
                For Each Node As XmlNode In Nodelist
                    GetAllFKElements.Add(Node.Name)
                Next
            End If

            Return GetAllFKElements

        End Function

        ''get the ObjectKey of a FK element
        Public Sub SetFKGuid(ByVal ElementName As String, ByVal FK As Objects.ObjectKey)
            If _XMLNode Is Nothing Then Throw New DevelopmentException("Attempt to set a FK on an object with no node.")

            'check to see if the node exists already
            Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./" & ElementName)

            If Node Is Nothing Then
                Throw New DevelopmentException("Attempt to set a FK on an element that does not exist.")
            Else
                Dim Attr As System.Xml.XmlAttribute = Node.Attributes("FK")
                If Attr Is Nothing Then
                    Throw New DevelopmentException("Attempt to set a FK on an element that in not a key.")
                Else
                    Attr.Value = FK.ToString
                End If
            End If
        End Sub

#End Region

#Region "Element Access"

        'access the xml to get or set an element
        Public Property Element(ByVal Name As String) As String
            Get
                If Not KeySet Then Return ""
                Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./" & Name)
                If Not Node Is Nothing Then Return Node.InnerText Else Return ""
            End Get
            Set(ByVal Value As String)
                Dim Node As System.Xml.XmlNode

                Node = XMLNode.SelectSingleNode("./" & Name)
                If Node Is Nothing Then
                    Node = XML.CreateNode(ObjectGUID.Database, Name)
                    Node.InnerText = Value
                    XMLNode.AppendChild(Node)
                Else
                    Node.InnerText = Value
                End If
            End Set
        End Property

        'get an element and convert it to a number
        Public Property ElementAsNumber(ByVal Name As String) As Double
            Get
                If Not KeySet Then Return 0

                Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./" & Name)
                If Not Node Is Nothing Then
                    If Node.InnerText = "" Then
                        Return 0
                    Else
                        Try
                            Return Double.Parse(Node.InnerText)
                        Catch ex As Exception
                            Return 0
                        End Try
                    End If
                Else
                    Return 0
                End If
            End Get
            Set(ByVal Value As Double)
                Dim Node As System.Xml.XmlNode

                Node = XMLNode.SelectSingleNode("./" & Name)
                If Node Is Nothing Then
                    Node = XML.CreateNode(ObjectGUID.Database, Name)
                    Node.InnerText = Value.ToString
                    XMLNode.AppendChild(Node)
                Else
                    Node.InnerText = Value.ToString
                End If
            End Set
        End Property

        'get an element and convert it to a number
        Public Property ElementAsInteger(ByVal Name As String) As Integer
            Get
                If Not KeySet Then Return 0

                Dim Node As System.Xml.XmlNode = XMLNode.SelectSingleNode("./" & Name)

                If Not Node Is Nothing Then
                    If Node.InnerText = "" Then
                        Return 0
                    Else
                        Try
                            Return Integer.Parse(Node.InnerText)
                        Catch ex As Exception
                            Return 0
                        End Try
                    End If
                Else
                    Return 0
                End If
            End Get
            Set(ByVal Value As Integer)
                Dim Node As System.Xml.XmlNode

                Node = XMLNode.SelectSingleNode("./" & Name)
                If Node Is Nothing Then
                    Node = XML.CreateNode(ObjectGUID.Database, Name)
                    Node.InnerText = Value.ToString
                    XMLNode.AppendChild(Node)
                Else
                    Node.InnerText = Value.ToString
                End If
            End Set
        End Property

        'get the existing elements as an arraylist (ordered as stored)
        Public Function ElementsAsList() As ArrayList
            Dim Enumerator As IEnumerator
            Dim XMLNode As XmlNode

            Enumerator = _XMLNode.GetEnumerator
            ElementsAsList = New ArrayList

            While Enumerator.MoveNext
                XMLNode = DirectCast(Enumerator.Current, XmlNode)
                Select Case XMLNode.Name
                    Case "RPGXplorerObject", "Name", "ObjectGUID", "ParentGUID", "HTMLGUID", "Type", "ImageFilename", "URL", "HTML", "SortColumn", "SortDirection", "View"
                        'do nothing
                    Case Else
                        ElementsAsList.Add(XMLNode.Name)
                End Select
            End While
        End Function

        'copy known elements into an array
        'this is performance method for SpellListPanel
        Public Sub GetSpellDefElements(ByRef Elements() As String)
            For Each Node As XmlNode In XMLNode.ChildNodes
                Select Case Node.Name
                    Case "Name"
                        Elements(0) = XML.CleanString(Node.InnerText)
                    Case "ObjectGUID"
                        Elements(1) = XML.CleanString(Node.InnerText)
                    Case "HTML"
                        Elements(2) = XML.CleanString(Node.InnerText)
                    Case "School"
                        Elements(3) = XML.CleanString(Node.InnerText)
                    Case "Subschool"
                        Elements(4) = XML.CleanString(Node.InnerText)
                    Case "Descriptors"
                        Elements(5) = XML.CleanString(Node.InnerText)
                    Case "Components"
                        Elements(6) = XML.CleanString(Node.InnerText)
                    Case "CastingTime"
                        Elements(7) = XML.CleanString(Node.InnerText)
                    Case "Range"
                        Elements(8) = XML.CleanString(Node.InnerText)
                    Case "TargetAreaEffect"
                        Elements(9) = XML.CleanString(Node.InnerText)
                    Case "Duration"
                        Elements(10) = XML.CleanString(Node.InnerText)
                    Case "SavingThrow"
                        Elements(11) = XML.CleanString(Node.InnerText)
                    Case "SpellResistance"
                        Elements(12) = XML.CleanString(Node.InnerText)
                    Case "XPCost"
                        Elements(13) = XML.CleanString(Node.InnerText)
                    Case "ComponentCost"
                        Elements(14) = XML.CleanString(Node.InnerText)
                    Case "Description"
                        Elements(15) = XML.CleanString(Node.InnerText)
                    Case "License"
                        Elements(16) = XML.CleanString(Node.InnerText)
                    Case "Sourcebook"
                        Elements(17) = XML.CleanString(Node.InnerText)
                    Case "Tags"
                        Elements(18) = XML.CleanString(Node.InnerText)
                    Case "PageNoRef"
                        Elements(19) = XML.CleanString(Node.InnerText)
                    Case "ClassLevels"
                        Elements(20) = XML.CleanString(Node.InnerText)
                    Case Else
                        'ignore
                End Select
            Next
        End Sub

#End Region

#Region "Attributes"

        'add an attribute to an element
        Public Property Attribute(ByVal ElementName As String, ByVal AttributeName As String) As String
            Get
                Dim Node As System.Xml.XmlNode
                Dim Attr As System.Xml.XmlAttribute

                'check to see if the node exists already
                Node = XMLNode.SelectSingleNode("./" & ElementName)

                If Node Is Nothing Then
                    Return ""
                Else
                    Attr = Node.Attributes(AttributeName)
                    If Attr Is Nothing Then
                        Return ""
                    Else
                        Return Attr.Value
                    End If
                End If
            End Get
            Set(ByVal Value As String)
                Dim Node As System.Xml.XmlNode
                Dim Attr As System.Xml.XmlAttribute

                'check to see if the node exists already
                Node = XMLNode.SelectSingleNode("./" & ElementName)

                If Node Is Nothing Then
                    'cannot add an attribute
                    Exit Property
                End If

                RemoveAttribute(ElementName, AttributeName)

                'add the attribute
                Attr = XML.CreateAttribute(ObjectGUID.Database, AttributeName)
                Attr.Value = Value
                Node.Attributes.Append(Attr)
            End Set
        End Property

        'remove an attribute from an element
        Public Sub RemoveAttribute(ByVal Element As String, ByVal AttributeName As String)
            Dim Node As System.Xml.XmlNode

            'check to see if the node exists already
            Node = XMLNode.SelectSingleNode("./" & Element)

            If Node Is Nothing Then
                'cannot remove attribute
                Exit Sub
            End If

            Node.Attributes.RemoveNamedItem(AttributeName)
        End Sub

#End Region

#Region "Children"

        'slightly quicker check than just getting children
        Public Function HasChildren() As Boolean
            Dim ChildNodes As XmlNodeList = XML.GetChildNodes(Me)
            If ChildNodes Is Nothing OrElse ChildNodes.Count = 0 Then Return False Else Return True
        End Function

        'return the children of this object
        Public Function Children() As ObjectDataCollection
            Dim Obj As New ObjectData
            Dim Nodes As XmlNodeList
            Dim Node As XmlNode

            Children = New ObjectDataCollection

            'get the nodes that are children of this node
            Nodes = XML.GetChildNodes(Me)

            If Nodes Is Nothing Then Return Children

            For Each Node In Nodes
                Obj.Clear()
                Obj.LoadFromNode(Node)
                Children.Add(Obj)
            Next

            'return the objects (empty collection if there are none)
            Return Children
        End Function

        'return the children of this object and their children etc.
        Public Function ChildrenDeep() As ObjectDataCollection
            Return ChildrenDeep(ObjectGUID)
        End Function

        'return the children of this object and their children etc.
        Public Function ChildrenDeep(ByVal RecurseGuid As ObjectKey) As ObjectDataCollection
            Dim Obj As New ObjectData
            Dim Objects As Objects.ObjectDataCollection
            Dim Nodes As XmlNodeList
            Dim Node As XmlNode

            Objects = New ObjectDataCollection

            'get the nodes that are children of this node
            Nodes = XML.GetChildNodes(RecurseGuid)
            If Nodes Is Nothing Then Return Objects

            For Each Node In Nodes
                Obj.Clear()
                Obj.LoadFromNode(Node)
                Objects.Add(Obj)
                Objects.AddMany(ChildrenDeep(Obj.ObjectGUID))
            Next

            'return the objects (empty collection if there are none)
            Return Objects
        End Function

        'return the children of this object that are visible in the list view
        Public Function ChildrenVisibleInListView() As ObjectDataCollection
            Dim Obj As New ObjectData
            Dim Nodes As XmlNodeList
            Dim Node As XmlNode

            ChildrenVisibleInListView = New ObjectDataCollection

            'get the nodes that are children of this node
            Nodes = XML.GetChildNodes(ObjectGUID)
            If Nodes Is Nothing Then Return ChildrenVisibleInListView

            For Each Node In Nodes
                Obj.Clear()
                Obj.LoadFromNode(Node)
                If Objects.ObjectTypes.Item(Obj.Type).ShowInListView Then ChildrenVisibleInListView.Add(Obj)
            Next

            'return the objects (empty collection if there are none)
            Return ChildrenVisibleInListView
        End Function

        'return the children of this object that are visible in the tree view
        Public Function ChildrenVisibleInTreeView() As ObjectDataCollection
            Dim Obj As New ObjectData
            Dim Nodes As XmlNodeList
            Dim Node As XmlNode

            ChildrenVisibleInTreeView = New ObjectDataCollection

            'get the nodes that are children of this node
            Nodes = XML.GetChildNodes(ObjectGUID)
            If Nodes Is Nothing Then Return ChildrenVisibleInTreeView

            For Each Node In Nodes
                Obj.Clear()
                Obj.LoadFromNode(Node)
                If Obj.ShowInTree Then ChildrenVisibleInTreeView.Add(Obj)
            Next

            'return the objects (empty collection if there are none)
            Return ChildrenVisibleInTreeView
        End Function

        'return the children of this object that are of this type
        Public Function ChildrenOfType(ByVal Type As String) As ObjectDataCollection
            Dim Obj As New ObjectData
            Dim Nodes As XmlNodeList
            Dim Node As XmlNode

            ChildrenOfType = New ObjectDataCollection

            'get the nodes that are children of this node
            Nodes = XML.GetChildNodesOfType(ObjectGUID, Type)
            If Nodes Is Nothing Then Return ChildrenOfType

            For Each Node In Nodes
                Obj.Clear()
                Obj.LoadFromNode(Node)
                ChildrenOfType.Add(Obj)
            Next

            'return the objects (empty collection if there are none)
            Return ChildrenOfType
        End Function

        'return the first child of the specified type
        Public Function FirstChildOfType(ByVal Type As String) As ObjectData
            Dim Obj As New ObjectData
            Dim Nodes As XmlNodeList

            'get the nodes that are children of this node
            Nodes = XML.GetChildNodesOfType(ObjectGUID, Type)
            If Nodes Is Nothing Then Return Obj
            If Nodes.Count = 0 Then Return Obj

            Obj.LoadFromNode(Nodes.Item(0))

            'return the object
            Return Obj
        End Function

#End Region

#Region "Delete"

        'delete the object
        Public Sub Delete()
            If IsDeletable(Me) Then
                DeleteChildren()
                XML.DeleteNode(ObjectGUID)
                If Not FKs Is Nothing Then
                    For Each FK As Objects.ObjectKey In FKs
                        XML.FKLookup.RemoveItem(FK, ObjectGUID)
                    Next
                End If
            Else
                If Not Me.IsEmpty Then
                    General.ShowInfoDialog(Name & " cannot be deleted as it or one of its child components is being used by another component.")
                End If
            End If
        End Sub

        'Recursively delete an objects children
        Private Sub DeleteChildren()
            For Each Child As Objects.ObjectData In Children()
                Child.DeleteChildren()
                XML.DeleteNode(Child.ObjectGUID)
                For Each FK As Objects.ObjectKey In Child.FKs
                    XML.FKLookup.RemoveItem(FK, Child.ObjectGUID)
                Next
            Next
        End Sub

        'fast delete - must rebuild fk lookup after finishing (manually)
        Public Sub DeleteFast()
            DeleteChildrenFast()
            XML.DeleteNode(ObjectGUID)
        End Sub

        'fast delete - recursive part
        Private Sub DeleteChildrenFast()
            For Each Child As Objects.ObjectData In Children()
                Child.DeleteChildren()
                XML.DeleteNode(Child.ObjectGUID)
            Next
        End Sub

        'fast delete for object only (children not deleted)
        Public Sub DeleteFastNoChildren()
            XML.DeleteNode(ObjectGUID)
        End Sub

        'If the object and all its children are not foreign keys, then the object is deletable
        Private Function IsDeletable(ByVal Obj As Objects.ObjectData) As Boolean
            If XML.IsForeignKey(Obj.ObjectGUID) Then Return False

            For Each Child As Objects.ObjectData In Children()
                If Not Child.IsDeletable(Child) Then Return False
            Next

            Return True
        End Function

#End Region

#Region "Clear"

        'clear the structure
        Public Sub Clear()
            'Flags
            NameSet = False
            TypeSet = False
            KeySet = False
            ParentKeySet = False
            HTMLSet = False
            HTMLGUIDSet = False
            FixedSet = False
            FixedOverride = False
            ImageFilenameSet = False
            ImageFilenameOverride = False
            NodeAdded = False

            'Member variables
            _XMLNode = Nothing
            _Name = Nothing
            _Type = Nothing
            _ObjectGUID = Nothing
            _ParentGUID = Nothing
            _HTML = Nothing
            _HTMLGUID = Nothing
            _Fixed = Nothing
            _ImageFilename = Nothing
            _FKs = Nothing
        End Sub

        'clear non core elements
        Public Sub ClearElements()
            Dim Node, Sibling As XmlNode

            Node = XMLNode.FirstChild
            While Not Node Is Nothing
                Sibling = Node.NextSibling
                Dim NodeName As String = Node.Name
                Select Case NodeName
                    Case "ObjectGUID", "ParentGUID", "Type", "Name", "HTML", "HTMLGUID"
                        'do nothing
                    Case Else
                        XMLNode.RemoveChild(Node)
                End Select
                Node = Sibling
            End While
        End Sub

#End Region

#Region "Cloning"

        'create a copy of itself and all its children, put all the objects into one collection
        Public Function Clone(ByVal NewParent As ObjectData) As ObjectDataCollection
            Dim Temp As New ObjectDataCollection

            _Clone(Me, NewParent, Temp, True)
            Return Temp
        End Function

        'same as clone, but update the given hashtable with a Old -> New key map
        Public Function CloneWithKeyMap(ByVal NewParent As ObjectData, ByVal KeyMap As ObjectHashtable) As ObjectDataCollection
            Dim Temp As New ObjectDataCollection

            _Clone(Me, NewParent, Temp, True, KeyMap)
            Return Temp
        End Function

        'recursive portion of deep copy
        Private Sub _Clone(ByVal Obj As ObjectData, ByVal NewParent As ObjectData, ByRef CloneObjects As ObjectDataCollection, Optional ByVal FirstFlag As Boolean = False, Optional ByVal KeyMap As ObjectHashtable = Nothing)
            Dim CloneObj As New ObjectData
            Dim Child As ObjectData
            Dim TargetDB As Integer = XML.GetDatabaseNo(NewParent.ObjectGUID)

            'create a copy of myself
            If FirstFlag Then
                CloneObj.Name = GetCopyName(Obj.Name, NewParent)
            Else
                CloneObj.Name = Obj.Name
            End If
            CloneObj.ObjectGUID = ObjectKey.NewGuid(TargetDB)
            CloneObj.Type = Obj.Type
            CloneObj.ParentGUID = NewParent.ObjectGUID
            CloneObj.HTML = Obj.HTML
            CloneObj.HTMLGUID = Obj.HTMLGUID
            CloneObj.ImageFilename = Obj.ImageFilename
            CloneObj._XMLNode = CloneXMLNode(NewParent, Obj, TargetDB)

            If Not FKs Is Nothing Then
                CloneObj._FKs = DirectCast(_FKs.Clone, ArrayList)
            End If

            CloneObjects.Add(CloneObj)

            If Not KeyMap Is Nothing Then
                KeyMap.Add(Obj.ObjectGUID, CloneObj.ObjectGUID)
            End If

            For Each Child In Obj.Children
                _Clone(Child, CloneObj, CloneObjects, , KeyMap)
            Next
        End Sub

        'create a clone of a single object
        Public Function CloneSingle(ByVal NewParent As ObjectData) As Objects.ObjectData
            Dim retCloneSingle As New Objects.ObjectData
            Dim TargetDB As Integer = XML.GetDatabaseNo(NewParent.ObjectGUID)

            'create a copy of myself
            retCloneSingle.Name = Me.Name
            retCloneSingle.ObjectGUID = ObjectKey.NewGuid(TargetDB)
            retCloneSingle.Type = Me.Type
            retCloneSingle.ParentGUID = NewParent.ObjectGUID
            retCloneSingle.HTML = Me.HTML
            retCloneSingle.HTMLGUID = Me.HTMLGUID
            retCloneSingle.ImageFilename = Me.ImageFilename
            retCloneSingle._XMLNode = CloneXMLNode(NewParent, Me, TargetDB)

            If Not FKs Is Nothing Then
                retCloneSingle._FKs = DirectCast(_FKs.Clone, ArrayList)
                Return retCloneSingle
            Else
                Return Nothing
            End If
        End Function

        'clone the xml node, perhaps moving from one db to another
        Private Function CloneXMLNode(ByVal NewParent As Objects.ObjectData, ByVal Obj As Objects.ObjectData, ByVal TargetDB As Integer) As XmlNode
            If Obj.ObjectGUID.Database = TargetDB Then
                Return Obj._XMLNode.Clone
            Else
                CloneXMLNode = XML.CreateNode(TargetDB, "RPGXplorerObject")
                Dim CloneNode As XmlNode
                Dim Value As String

                For Each Node As XmlNode In Obj._XMLNode
                    Select Case Node.Name
                        Case "ObjectGUID"
                            Value = ObjectKey.NewGuid(TargetDB).ToString
                        Case "ParentGUID"
                            Value = NewParent.ObjectGUID.ToString
                        Case Else
                            Value = Node.InnerText
                    End Select

                    CloneNode = CloneXMLNode.SelectSingleNode("./" & Node.Name)
                    If CloneNode Is Nothing Then
                        CloneNode = XML.CreateNode(TargetDB, Node.Name)
                        CloneNode.InnerText = Value
                        CloneXMLNode.AppendChild(CloneNode)
                    Else
                        CloneNode.InnerText = Value
                    End If

                    If Node.Attributes.Count > 0 Then
                        If CloneNode.Attributes.Count > 0 Then CloneNode.Attributes.RemoveAll()

                        For Each Attribute As System.Xml.XmlAttribute In Node.Attributes
                            Dim CloneAttribute As System.Xml.XmlAttribute
                            CloneAttribute = XML.CreateAttribute(TargetDB, Attribute.Name)
                            CloneAttribute.Value = Attribute.Value
                            CloneNode.Attributes.Append(CloneAttribute)
                        Next
                    End If
                Next
            End If
        End Function

#End Region

#Region "Rule Pages"

        'update the rulepage name (only call from component editors, before save and for edit only)
        Public Sub RenameRulePage()
            If HTMLGUID.IsEmpty Then
                Dim PagePath As String = RulePageManager.Rename(Me, Name)
                If PagePath <> "" Then HTML = PagePath
            End If
        End Sub

        'create default rule page for object (if appropriate)
        Public Sub CreateDefaultRulePage()
            Dim BasePath, TemplatePage, NewPage As String

            If ObjectGUID.IsEmpty Then Exit Sub

            Select Case Type
                Case Objects.AmmoDefinitionType
                    BasePath = "Weapons\"
                    TemplatePage = "TemplateAmmoPage.htm"
                Case Objects.ArmorDefinitionType
                    BasePath = "Armor And Shields\"
                    TemplatePage = "TemplateArmorPage.htm"
                Case Objects.ArmorMagicAbilityDefinitionType
                    BasePath = "Armor Magic Abilities\"
                    TemplatePage = "TemplateArmorMagicAbilityPage.htm"
                Case Objects.ArtifactDefinitionType
                    BasePath = "Artifacts\"
                    TemplatePage = "TemplateArtifactPage.htm"
                Case Objects.ClassType
                    BasePath = "Classes\"
                    TemplatePage = "TemplateClassPage.htm"
                Case Objects.ClassLevelsFolderType
                    HTML = "Index.htm"
                    Exit Sub
                Case Objects.ClassSkillType
                    HTMLGUID = GetFKObject("Skill").ObjectGUID
                    Exit Sub
                Case Objects.DeityDefinitionType
                    BasePath = "Deities\"
                    TemplatePage = "TemplateDeityPage.htm"
                Case Objects.DomainDefinitionType
                    BasePath = "Domains\"
                    TemplatePage = "TemplateDomainPage.htm"
                Case Objects.FeatDefinitionType
                    BasePath = "Feats\"
                    TemplatePage = "TemplateFeatPage.htm"
                Case Objects.FeatureType
                    HTMLGUID = GetFKObject("Feature").ObjectGUID
                    Exit Sub
                Case Objects.FeatureDefinitionType
                    BasePath = "Features\"
                    TemplatePage = "TemplateFeaturePage.htm"
                Case Objects.FilterType, Objects.FilterTermType
                    HTML = ""
                    Exit Sub
                Case Objects.ItemDefinitionType
                    BasePath = "Items\"
                    TemplatePage = "TemplateItemPage.htm"
                Case Objects.LanguageDefinitionType
                    BasePath = "Languages\"
                    TemplatePage = "TemplateLanguagePage.htm"
                Case Objects.MagicAmmoDefinitionType
                    BasePath = "Magic Weapons\"
                    TemplatePage = "TemplateMagicAmmoPage.htm"
                Case Objects.PotionDefinitionType
                    HTMLGUID = GetFKObject("BaseSpell").ObjectGUID
                    Exit Sub
                Case Objects.PsiLikeAbilityType
                    HTMLGUID = GetFKObject("Power").ObjectGUID
                    Exit Sub
                Case Objects.RaceType
                    BasePath = "Races\"
                    TemplatePage = "TemplateRacePage.htm"
                Case Objects.RingDefinitionType
                    BasePath = "Rings\"
                    TemplatePage = "TemplateRingPage.htm"
                Case Objects.RodDefinitionType
                    BasePath = "Rods\"
                    TemplatePage = "TemplateRodPage.htm"
                Case Objects.RuleFolderType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateUserFolder.htm"
                Case Objects.RuleFolderPageType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateUserPage.htm"
                Case Objects.RulePageType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateUserPage.htm"
                Case Objects.RuleTableType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateUserPage.htm"
                Case Objects.ShieldDefinitionType
                    BasePath = "Armor And Shields\"
                    TemplatePage = "TemplateArmorPage.htm"
                Case Objects.SkillDefinitionType
                    BasePath = "Skills\"
                    TemplatePage = "TemplateSkillPage.htm"
                Case Objects.SpecificArmorDefinitionType
                    BasePath = "Magic Armor\"
                    TemplatePage = "TemplateMagicArmorPage.htm"
                Case Objects.SpecificArmorAbilityType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub
                Case Objects.SpecificWeaponAbilityType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub
                Case Objects.SpecificWeaponDoubleAbilityType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub
                Case Objects.SpecificBonusFeatType
                    HTMLGUID = GetFKGuid("Feat")
                    Exit Sub
                Case Objects.SpecificWeaponDefinitionType
                    BasePath = "Magic Weapons\"
                    TemplatePage = "TemplateMagicWeaponPage.htm"
                Case Objects.SpellCategoryDefinitionType
                    BasePath = "Spell Categories\"
                    TemplatePage = "TemplateSpellCategoryPage.htm"
                Case Objects.SpellDefinitionType
                    BasePath = "Spells\"
                    TemplatePage = "TemplateSpellPage.htm"
                Case Objects.SpellDescriptorDefinitionType
                    HTML = "Rules\SpellDescriptors.htm"
                    Exit Sub
                Case Objects.SpellLikeAbilityType
                    HTMLGUID = GetFKGuid("Spell")
                    Exit Sub
                Case Objects.SpellSchoolType
                    BasePath = "Spell Schools\"
                    TemplatePage = "TemplateSpellSchoolPage.htm"
                Case Objects.SpellSubschoolType
                    HTML = ""
                    HTMLGUID = ParentGUID
                    Exit Sub
                Case Objects.StaffDefinitionType
                    BasePath = "Staffs\"
                    TemplatePage = "TemplateStaffPage.htm"
                Case Objects.WeaponDefinitionType
                    BasePath = "Weapons\"
                    TemplatePage = "TemplateWeaponPage.htm"
                Case Objects.WeaponMagicAbilityDefinitionType
                    BasePath = "Weapon Magic Abilities\"
                    TemplatePage = "TemplateWeaponMagicAbilityPage.htm"
                Case Objects.MagicWeaponAbilityConditionalType
                    HTMLGUID = GetFKObject("WeaponMagicAbilityDefinition").ObjectGUID
                    Exit Sub
                Case Objects.WondrousDefinitionType
                    BasePath = "Wondrous Items\"
                    TemplatePage = "TemplateWondrousItemPage.htm"

                    'psionic
                Case PsionicAmmoDefinitionType
                    BasePath = "Psionic Weapons\"
                    TemplatePage = "TemplatePsionicAmmoPage.htm"

                Case PsionicArmorAbilityDefinitionType
                    BasePath = "Psionic Armor Abilities\"
                    TemplatePage = "TemplatePsionicArmorAbilityPage.htm"

                Case PsionicArmorAbilityType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub

                Case PsionicArmorDefinitionType
                    BasePath = "Psionic Armor\"
                    TemplatePage = "TemplatePsionicArmorPage.htm"

                Case PsionicArtifactDefinitionType
                    BasePath = "Psionic Artifacts\"
                    TemplatePage = "TemplatePsionicArtifactPage.htm"

                Case PowerDefinitionType
                    BasePath = "Powers\"
                    TemplatePage = "TemplatePowerPage.htm"

                Case PsionicDisciplineType
                    BasePath = "Psionic Disciplines\"
                    TemplatePage = "TemplatePsionicDiscipline.htm"

                Case PsionicPsicrownDefinitionType
                    BasePath = "Psicrowns\"
                    TemplatePage = "TemplatePsicrownPage.htm"

                Case PsionicSpecializationDefinitionType
                    BasePath = "Psionic Specializations\"
                    TemplatePage = "TemplatePsionicSpecializationPage.htm"

                Case PsionicSubdisciplineType
                    HTML = ""
                    HTMLGUID = ParentGUID
                    Exit Sub

                Case Objects.PsionicWeaponAbilityType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub

                Case Objects.PsionicWeaponAbilityConditionalType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub

                Case Objects.PsionicWeaponAbilityDoubleType
                    HTMLGUID = GetFKGuid(Me.GetFirstFKElementName)
                    Exit Sub

                Case PsionicWeaponAbilityDefinitionType
                    BasePath = "Psionic Weapon Abilities\"
                    TemplatePage = "TemplatePsionicWeaponAbilityPage.htm"

                Case PsionicWeaponDefinitionType
                    BasePath = "Psionic Weapons\"
                    TemplatePage = "TemplatePsionicWeaponPage.htm"

                Case UniversalItemDefinitionType
                    BasePath = "Universal Items\"
                    TemplatePage = "TemplateUniversalItemPage.htm"

                Case MonsterRaceDefinitionType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateMonsterRacePage.htm"

                Case Objects.MonsterClassType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateMonsterClassPage.htm"

                Case Objects.SubtypeDefinitionType
                    BasePath = "UserDocs\"
                    TemplatePage = "TemplateMonsterSubtypePage.htm"

                Case Else
                    HTML = "Index.htm"
                    HTMLGUID = Objects.ObjectKey.Empty
                    Exit Sub

            End Select

            Dim CleanName As String = CommonLogic.StripDisallowedChars(Name)
            Dim DocName As String = CleanName & ".htm"
            Dim PathNoExtension As String = General.HelpPath & BasePath & CleanName
            NewPage = PathNoExtension & ".htm"

            Dim Sequence As Integer = 1
            If System.IO.File.Exists(NewPage) Then
                Select Case General.ShowQuestionDialog(Me.Name & " - Use existing rule page?")
                    Case DialogResult.Yes
                        HTML = BasePath & DocName
                    Case DialogResult.OK
                        HTML = BasePath & DocName
                    Case Else

                        Dim NotFound As Boolean = False
                        NewPage = PathNoExtension & " " & Sequence.ToString & ".htm"
                        Do
                            If System.IO.File.Exists(NewPage) Then
                                Sequence += 1
                                NewPage = PathNoExtension & " " & Sequence.ToString & ".htm"
                                DocName = CleanName & " " & Sequence.ToString & ".htm"
                            Else
                                NotFound = True
                            End If
                        Loop Until NotFound

                        'create a copy of the template page
                        If System.IO.File.Exists(General.HelpPath & "Templates\" & TemplatePage) Then
                            System.IO.File.Copy(General.HelpPath & "Templates\" & TemplatePage, NewPage)
                            HTML = BasePath & DocName
                        Else
                            HTML = "Index.htm"
                        End If
                End Select

            Else
                'create a copy of the template page
                If System.IO.File.Exists(General.HelpPath & "Templates\" & TemplatePage) Then
                    System.IO.File.Copy(General.HelpPath & "Templates\" & TemplatePage, NewPage)
                    HTML = BasePath & DocName
                Else
                    HTML = "Index.htm"
                End If
            End If

        End Sub

#End Region

#Region "Type Specific Properties"

        'sort type property
        Public ReadOnly Property SortType() As SortType
            Get
                Return ObjectTypes.Item(Me.Type).SortType
            End Get
        End Property

        'is system type
        Public Function IsSystemType() As Boolean
            Select Case Type
                Case Objects.SystemAbilityDefinitionType, Objects.SystemElementType, Objects.SystemPreconditionDefinitionType, Objects.SystemReferenceType, Objects.SystemWeaponAbilityDefinitionType, Objects.SkillGroupType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'is primary type
        Public Function IsPrimaryType() As Boolean
            Select Case Type
                'standard
                Case Objects.AmmoDefinitionType, Objects.ArmorDefinitionType, Objects.ArmorMagicAbilityDefinitionType, Objects.ArtifactDefinitionType, Objects.CharacterType, Objects.ClassType, Objects.DeityDefinitionType, Objects.DomainDefinitionType, Objects.FeatDefinitionType, Objects.FeatureDefinitionType, Objects.ItemDefinitionType, Objects.LanguageDefinitionType, Objects.MagicAmmoDefinitionType, Objects.ModifierLimiterType, Objects.MonsterTypeType, Objects.PotionDefinitionType, Objects.RaceType, Objects.RingDefinitionType, Objects.RodDefinitionType, Objects.RodDefinitionType, Objects.RulePageType, Objects.RuleFolderPageType, Objects.RuleTableType, Objects.RuleFolderType, Objects.ScrollDefinitionType, Objects.ShieldDefinitionType, Objects.SkillDefinitionType, Objects.SpecialMaterialDefinitionType, Objects.SpecificArmorDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.SpellCategoryDefinitionType, Objects.SpellDefinitionType, Objects.SpellDescriptorDefinitionType, Objects.SpellSchoolType, Objects.SpellSubschoolType, Objects.StaffDefinitionType, Objects.WandDefinitionType, Objects.WeaponDefinitionType, Objects.WeaponMagicAbilityDefinitionType, Objects.WondrousDefinitionType
                    Return True
                    'psionic components
                Case PowerDefinitionType, PsionicDisciplineType, PsionicSubdisciplineType, PsionicSpecializationDefinitionType, PsionicArtifactDefinitionType, PsionicAmmoDefinitionType, PsionicArmorAbilityDefinitionType, PsionicArmorDefinitionType, PsionicDorjeDefinitionType, PsionicPowerStoneDefinitionType, PsionicPsicrownDefinitionType, PsionicTattooDefinitionType, PsionicWeaponAbilityDefinitionType, PsionicWeaponDefinitionType, UniversalItemDefinitionType
                    Return True
                    'monster stuff
                Case Objects.MonsterClassType, Objects.MonsterRaceDefinitionType, Objects.NaturalWeaponDefinitionType, Objects.SubtypeDefinitionType, Objects.MonsterType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'is folder type
        Public Function IsPrimaryFolderType() As Boolean
            Select Case Type
                Case Objects.ArmorDefinitionFolderType, Objects.ArmorMagicAbilityDefinitionFolderType, Objects.ArtifactDefinitionFolderType, Objects.CharacterFolderType, Objects.ClassFolderType, Objects.DeityDefinitionFolderType, Objects.DomainDefinitionFolderType, Objects.FeatDefinitionsFolderType, Objects.FeatureDefinitionFolderType, Objects.ItemDefinitionFolderType, Objects.LanguageDefinitionFolderType, Objects.ModifierLimiterFolderType, Objects.PotionDefinitionFolderType, Objects.RaceFolderType, Objects.RingDefinitionFolderType, Objects.RodDefinitionFolderType, Objects.ScrollDefinitionFolderType, Objects.SkillDefinitionFolderType, Objects.SpecialMaterialDefinitionsFolderType, Objects.SpecificArmorDefinitionFolderType, Objects.SpecificWeaponDefinitionFolderType, Objects.SpellCategoryFolder, Objects.SpellDefinitionFolderType, Objects.SpellDescriptorDefinitionFolderType, Objects.SpellSchoolFolderType, Objects.StaffDefinitionFolderType, Objects.WandDefinitionFolderType, Objects.WeaponDefinitionFolderType, Objects.WeaponMagicAbilityDefinitionFolderType, Objects.WondrousDefinitionFolderType, Objects.RulesRootFolderType
                    Return True
                Case UniversalItemDefinitionFolderType, PsionicWeaponDefinitionsFolderType, PsionicWeaponAbilityDefinitionsFolderType, PsionicTattooDefinitionsFolderType, PsionicPsicrownDefinitionFolderType, PsionicPowerStoneDefinitionsFolderType, PsionicDorjeDefinitionsFolderType, PsionicArmorDefinitionsFolderType, PsionicArmorAbilityDefinitionsFolderType, PowerDefinitionFolderType, PsionicDisciplineFolderType, PsionicSpecializationDefinitionFolderType, PsionicArtifactDefinitionsFolderType
                    Return True
                    'monster stuff
                Case Objects.MonsterClassFolderType, Objects.MonsterRaceDefinitionFolderType, Objects.NaturalWeaponDefinitionsFolderType, Objects.SubtypeDefinitionsFolderType, Objects.MonsterFolderType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'is secondary folder type
        Public Function IsSecondaryFolderType() As Boolean
            Select Case Type
                Case SpellListFolderType, ConditionType, CharacterLevelsFolderType, ClassLevelsFolderType, ClassLevelsSpellsPerDayFolderType, ClassLevelsSpellsKnownFolderType, PowerListFolderType, ClassLevelsPowerProgressionFolderType, ClassPowerListFolderType, MonsterClassLevelsFolderType, ClassLevelType, MonsterClassLevelType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'sourcebook, license, pageno, tags
        Public Function AllowReferenceProperties() As Boolean
            Return AllowReferenceProperties(Type)
        End Function

        'sourcebook, license, pageno, tags
        Public Shared Function AllowReferenceProperties(ByVal Type As String) As Boolean
            Select Case Type
                Case Objects.AmmoDefinitionType, Objects.ArmorDefinitionType, Objects.ArmorMagicAbilityDefinitionType, Objects.ArtifactDefinitionType, Objects.ClassType, Objects.MonsterClassType, Objects.DeityDefinitionType, Objects.DomainDefinitionType, Objects.FeatDefinitionType, Objects.FeatureDefinitionType, Objects.ItemDefinitionType, Objects.LanguageDefinitionType, Objects.MagicAmmoDefinitionType, Objects.ModifierLimiterType, Objects.MonsterTypeType, Objects.PotionDefinitionType, Objects.RaceType, Objects.RingDefinitionType, Objects.RodDefinitionType, Objects.RodDefinitionType, Objects.SpecialMaterialDefinitionType, Objects.ScrollDefinitionType, Objects.ShieldDefinitionType, Objects.SkillDefinitionType, Objects.SpecificArmorDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.SpellCategoryDefinitionType, Objects.SpellDefinitionType, Objects.SpellDescriptorDefinitionType, Objects.SpellSchoolType, Objects.SpellSubschoolType, Objects.StaffDefinitionType, Objects.WandDefinitionType, Objects.WeaponDefinitionType, Objects.WeaponMagicAbilityDefinitionType, Objects.WondrousDefinitionType
                    Return True
                    'psionic stuff
                Case PowerDefinitionType, PsionicDisciplineType, PsionicSubdisciplineType, PsionicSpecializationDefinitionType, PsionicArtifactDefinitionType, PsionicAmmoDefinitionType, PsionicArmorAbilityDefinitionType, PsionicArmorDefinitionType, PsionicDorjeDefinitionType, PsionicPowerStoneDefinitionType, PsionicPsicrownDefinitionType, PsionicTattooDefinitionType, PsionicWeaponAbilityDefinitionType, PsionicWeaponDefinitionType, UniversalItemDefinitionType
                    Return True
                    'monster stuff
                Case Objects.MonsterClassType, Objects.MonsterRaceDefinitionType, Objects.NaturalWeaponDefinitionType, Objects.SubtypeDefinitionType
                    Return True
                    'character stuff
                Case Objects.CharacterType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'sourcebook, license, pageno, tags (for folder)
        Public Shared Function ShowOptionalColumns(ByVal Type As String) As Boolean
            Select Case Type
                Case Objects.ArmorDefinitionFolderType, Objects.ArmorMagicAbilityDefinitionFolderType, Objects.ArtifactDefinitionFolderType, Objects.ClassFolderType, Objects.MonsterClassFolderType, Objects.ClassSpellListFolderType, Objects.ClassPowerListFolderType, Objects.DeityDefinitionFolderType, Objects.DomainDefinitionFolderType, Objects.FeatDefinitionsFolderType, Objects.FeatureDefinitionFolderType, Objects.ItemDefinitionFolderType, Objects.LanguageDefinitionFolderType, Objects.PotionDefinitionFolderType, Objects.RaceFolderType, Objects.RingDefinitionFolderType, Objects.RodDefinitionFolderType, Objects.SpecialMaterialDefinitionsFolderType, Objects.ScrollDefinitionFolderType, Objects.SkillDefinitionFolderType, Objects.SpecificArmorDefinitionFolderType, Objects.SpecificWeaponDefinitionFolderType, Objects.SpellCategoryFolder, Objects.SpellDefinitionFolderType, Objects.SpellDescriptorDefinitionFolderType, Objects.SpellListFolderType, Objects.SpellSchoolFolderType, Objects.StaffDefinitionFolderType, Objects.WandDefinitionFolderType, Objects.WeaponDefinitionFolderType, Objects.WeaponMagicAbilityDefinitionFolderType, Objects.WondrousDefinitionFolderType
                    Return True
                Case UniversalItemDefinitionFolderType, Objects.PowerListFolderType, PsionicWeaponDefinitionsFolderType, PsionicWeaponAbilityDefinitionsFolderType, PsionicTattooDefinitionsFolderType, PsionicPsicrownDefinitionFolderType, PsionicPowerStoneDefinitionsFolderType, PsionicDorjeDefinitionsFolderType, PsionicArmorDefinitionsFolderType, PsionicArmorAbilityDefinitionsFolderType, PowerDefinitionFolderType, PsionicDisciplineFolderType, PsionicSpecializationDefinitionFolderType, PsionicArtifactDefinitionsFolderType
                    Return True
                Case Objects.MonsterClassFolderType, Objects.MonsterRaceDefinitionFolderType, Objects.NaturalWeaponDefinitionsFolderType, Objects.SubtypeDefinitionsFolderType
                    Return True
                Case Objects.CharacterFolderType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'is rules browser type
        Public Function IsRulesType() As Boolean
            Select Case Type
                Case Objects.RuleFolderPageType, Objects.RuleFolderType, Objects.RulePageType, Objects.RuleTableType, Objects.FavoriteRuleType, Objects.FavoriteRuleFolderType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        'is list or filter type
        Public Function IsListOrFilterType() As Boolean
            Select Case Type
                Case Objects.UserListItemType, Objects.FilterType, Objects.FilterTermType
                    Return True
                Case Else
                    Return False
            End Select
        End Function

#End Region

#Region "Utility"

        'when copying an object to the same folder, get the next "Copy of " name (if any).
        Private Function GetCopyName(ByVal ObjectName As String, ByVal NewParent As Objects.ObjectData) As String
            Dim SearchStr As String
            Dim FoundCopyName As Boolean = False
            Dim CopyNo As Integer = 1
            Dim Child As Objects.ObjectData
            Dim NewChildren As Objects.ObjectDataCollection

            SearchStr = ObjectName
            NewChildren = NewParent.Children
            If NewChildren.Count = 0 Then Return SearchStr

            Do While FoundCopyName = False
                FoundCopyName = True
                For Each Child In NewChildren
                    If Child.Name = SearchStr Then
                        FoundCopyName = False
                        SearchStr = ObjectName & " {COPY " & CopyNo.ToString & "}"
                        CopyNo += 1
                        Exit For
                    End If
                Next
            Loop

            Return SearchStr
        End Function

        'check to see if any ancestor in the tree is of a given type
        Public Function AncestorIsOfType(ByVal Type As String) As Boolean
            Dim TempParent As Objects.ObjectData
            TempParent = Me.Parent

            While Not TempParent.ObjectGUID.IsEmpty
                If TempParent.Type = Type Then Return True
                TempParent = TempParent.Parent
            End While

            Return False

        End Function

        'Works it way through this objects parents - if it is decended from a character return its ObjectGUID
        Public Function GetCharacterKey() As Objects.ObjectKey
            Dim TempParent As Objects.ObjectData

            If Me.Type = Objects.CharacterType OrElse Me.Type = Objects.MonsterType Then Return ObjectGUID

            TempParent = Me.Parent
            While Not TempParent.ObjectGUID.IsEmpty
                If TempParent.Type = Objects.CharacterType OrElse TempParent.Type = Objects.MonsterType Then Return TempParent.ObjectGUID
                TempParent = TempParent.Parent
            End While

            Return Objects.ObjectKey.Empty

        End Function

        'get the full path for this object
        Public Function Path() As String
            Return PathRecurse(Me)
        End Function

        'recursive portion of path
        Private Function PathRecurse(ByVal Obj As Objects.ObjectData) As String
            Dim Parent As Objects.ObjectData = Obj.Parent

            If Not Parent.IsEmpty Then
                Return PathRecurse(Parent) & "\" & Obj.Name
            Else
                Return Obj.Name
            End If
        End Function

        'used by load/save
        Public Sub UpdateStructureFromNode()
            ObjectGUID = New Objects.ObjectKey(Element("ObjectGUID"))
            ParentGUID = New Objects.ObjectKey(Element("ParentGUID"))
            HTMLGUID = New Objects.ObjectKey(Element("HTMLGUID"))
        End Sub

        'used by load/save
        Public Sub UpdateNodeFromStructure()
            Element("Name") = _Name
            Element("Type") = _Type
            Element("ObjectGUID") = _ObjectGUID.ToString
            Element("ParentGUID") = _ParentGUID.ToString
            Element("HTML") = _HTML
            Element("HTMLGUID") = _HTMLGUID.ToString
            Element("ImageFilename") = _ImageFilename
            If FixedOverride Then Element("Fixed") = _Fixed.ToString
        End Sub

#End Region

#Region "Compare"

        'compare to
        Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            Return Name.CompareTo(DirectCast(obj, Objects.ObjectData).Name)
        End Function

        'compare two objects - true if same
        Public Function Compare(ByVal CompareWith As Objects.ObjectData, Optional ByVal IgnoreGUID As Boolean = False) As Boolean
            For Each Node As XmlNode In Me.XMLNode.ChildNodes
                If Node.Attributes.Count = 0 Then
                    Select Case Node.Name
                        Case "Name"
                            If Me.Name <> CompareWith.Name Then Return False
                        Case "HTMLGUID"
                            If Me.HTMLGUID.IsEmpty And (HTML = "" Or HTML = "Index.htm") Then
                                'ignore
                            ElseIf CompareWith.Element(Node.Name) <> "" Then
                                If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                            End If
                        Case "HTML"
                            If HTML = "" Or HTML = "Index.htm" Then
                                'ignore 
                            Else
                                If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                            End If
                        Case "ImageFilename"
                            If ImageFilename <> "" Then
                                If ImageFilename <> CompareWith.ImageFilename Then Return False
                            End If
                        Case "ObjectGUID"
                            If Not IgnoreGUID Then
                                If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                            End If
                        Case "URL", "Filter"
                            'ignore
                        Case Else
                            If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                    End Select
                Else
                    If Node.Attributes("FK").InnerText <> CompareWith.GetFKGuid(Node.Name).ToString Then Return False
                End If
            Next

            Return True
        End Function

        'compare two objects - true if same
        Public Function SpellDefCompare(ByVal CompareWith As Objects.ObjectData) As Boolean
            For Each Node As XmlNode In Me.XMLNode.ChildNodes
                If Node.Attributes.Count = 0 Then
                    Select Case Node.Name
                        Case "Name"
                            If Me.Name <> CompareWith.Name Then Return False
                        Case "HTMLGUID"
                            If Me.HTMLGUID.IsEmpty And (HTML = "" Or HTML = "Index.htm") Then
                                'ignore
                            ElseIf CompareWith.Element(Node.Name) <> "" Then
                                If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                            End If
                        Case "HTML"
                            If HTML = "" Or HTML = "Index.htm" Then
                                'ignore 
                            Else
                                If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                            End If
                        Case "ImageFilename"
                            If ImageFilename <> "" Then
                                If ImageFilename <> CompareWith.ImageFilename Then Return False
                            End If
                        Case "URL", "Filter"
                            'ignore
                        Case "Arcane", "Divine"
                            'ignore these elements as they are set by the spell levels
                        Case Else
                            If Node.InnerText <> CompareWith.Element(Node.Name) Then Return False
                    End Select
                Else
                    If Node.Attributes("FK").InnerText <> CompareWith.GetFKGuid(Node.Name).ToString Then Return False
                End If
            Next

            Return True
        End Function

#End Region

    End Structure

#End Region

#Region "Object Data Collection"

    'structure used within objectdatacollection for creating lists of children contained within collection
    Private Structure ParentChild
        Public ParentKey As Objects.ObjectKey
        Public ObjectKey As Objects.ObjectKey
    End Structure

    'type safe collection for object data
    Public Class ObjectDataCollection
        Inherits System.Collections.Specialized.NameObjectCollectionBase

        Public Sub Add(ByVal Item As ObjectData)
            MyBase.BaseAdd(Item.ObjectGUID.ToString, Item)
        End Sub

        Public Sub AddMany(ByVal Objects As ObjectDataCollection)
            Dim Obj As ObjectData

            For Each Obj In Objects
                MyBase.BaseAdd(Obj.ObjectGUID.ToString, Obj)
            Next
        End Sub

        'empty the collection
        Public Sub Clear()
            MyBase.BaseClear()
        End Sub

        'overloaded - by ObjectKey
        Public Function Item(ByVal ObjectGUID As ObjectKey) As ObjectData
            Return CType(MyBase.BaseGet(ObjectGUID.ToString), Objects.ObjectData)
        End Function

        'overloaded - by index
        Public Function Item(ByVal Index As Integer) As ObjectData
            Return DirectCast(MyBase.BaseGet(Index), ObjectData)
        End Function

        'overloaded - by name
        Public Function Item(ByVal Name As String) As ObjectData
            Dim Obj As ObjectData

            For Each Obj In MyBase.BaseGetAllValues
                If Obj.Name = Name Then Return Obj
            Next
            Return Nothing
        End Function

        'overloaded - by fk element and fk ObjectKey
        Public Function Item(ByVal FKElement As String, ByVal FKGuid As ObjectKey) As ObjectData
            Dim Obj As ObjectData

            For Each Obj In MyBase.BaseGetAllValues
                If Obj.GetFKGuid(FKElement).Equals(FKGuid) Then Return Obj
            Next

            Return Nothing
        End Function

        'all the items with a particular foreign key and value
        Public Function Items(ByVal FKElement As String, ByVal FKGuid As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                Dim Objs As New Objects.ObjectDataCollection

                For Each Obj As Objects.ObjectData In MyBase.BaseGetAllValues
                    If Obj.GetFKGuid(FKElement).Equals(FKGuid) Then Objs.Add(Obj)
                Next

                Return Objs

            Catch ex As Exception
                Throw
            End Try
        End Function

        'contains
        Public Function Contains(ByVal ObjectGUID As ObjectKey) As Boolean
            If MyBase.BaseGet(ObjectGUID.ToString) Is Nothing Then Return False Else Return True
        End Function

        'contains
        Public Function Contains(ByVal Name As String) As Boolean
            Dim Obj As ObjectData

            Contains = False

            For Each Obj In MyBase.BaseGetAllValues
                If Obj.Name = Name Then
                    Contains = True
                    Exit For
                End If
            Next

            Return Contains
        End Function

        'search the collection for an object with a particular FK reference
        Public Function ContainsFK(ByVal FKElement As String, ByVal FKGuid As ObjectKey) As Boolean
            Dim Obj As ObjectData

            If FKGuid.Equals(ObjectKey.Empty) Then Return False

            ContainsFK = False

            For Each Obj In MyBase.BaseGetAllValues
                If Obj.GetFKGuid(FKElement).Equals(FKGuid) Then
                    ContainsFK = True
                    Exit For
                End If
            Next

            Return ContainsFK
        End Function

        'search the collection for an object with a particular type
        Public Function ContainsType(ByVal Type As String) As Boolean
            Dim Obj As ObjectData

            ContainsType = False

            For Each Obj In MyBase.BaseGetAllValues
                If Obj.Type = Type Then
                    ContainsType = True
                    Exit For
                End If
            Next

            Return ContainsType
        End Function

        'return the first child of this type
        Public Function FirstOfType(ByVal Type As String) As ObjectData
            Dim Obj As ObjectData

            For Each Obj In MyBase.BaseGetAllValues
                If Obj.Type = Type Then Return Obj
            Next
            Return Nothing
        End Function

        'returns an arraylist of the types contained in the collection
        Public Function GetTypes() As ArrayList
            Dim Obj As ObjectData

            GetTypes = New ArrayList

            For Each Obj In MyBase.BaseGetAllValues
                If Not GetTypes.Contains(Obj.Type) Then GetTypes.Add(Obj.Type)
            Next

            GetTypes.Sort()

            Return GetTypes
        End Function

        'returns an arraylist of the guids in the collection
        Public Function GetGuidList() As ArrayList
            Dim Key As String

            GetGuidList = New ArrayList

            For Each Key In MyBase.Keys
                GetGuidList.Add(New ObjectKey(Key))
            Next

            Return GetGuidList
        End Function

        'return an arraylist of the names in the collection
        Public Function GetNameList() As ArrayList
            GetNameList = New ArrayList

            For Each Obj As Objects.ObjectData In MyBase.BaseGetAllValues
                GetNameList.Add(Obj.Name)
            Next
        End Function

        'mybase.getenumerator returns an enumerator over the keys and not the values
        Public Shadows Function GetEnumerator() As IEnumerator
            Return MyBase.BaseGetAllValues.GetEnumerator
        End Function

        'replace an object
        Public Sub Replace(ByVal Obj As Objects.ObjectData)
            If Contains(Obj.ObjectGUID) Then Remove(Obj.ObjectGUID)
            Add(Obj)
        End Sub

        'remove a specific object
        Public Sub Remove(ByVal ObjectKey As ObjectKey)
            MyBase.BaseRemove(ObjectKey.ToString)
        End Sub

        'remove all the objects in the provided ICollection
        Public Sub RemoveList(ByVal List As Objects.ObjectDataCollection)
            Dim Enumerator As IEnumerator

            Enumerator = List.GetEnumerator
            While Enumerator.MoveNext
                MyBase.BaseRemove(DirectCast(Enumerator.Current, Objects.ObjectData).ObjectGUID.ToString)
            End While
        End Sub

        'save all the objects in the collection
        Public Sub Save(Optional ByVal DisableFKUpdates As Boolean = False)
            For Each Obj As Objects.ObjectData In MyBase.BaseGetAllValues
                Obj.Save(DisableFKUpdates)
            Next
        End Sub

        'delete all the objects contained within
        Public Sub Delete()
            Dim Obj As ObjectData

            For Each Obj In MyBase.BaseGetAllValues
                Obj.Delete()
            Next
        End Sub

        'get the objects as an array
        Public Function List() As Object()
            List = MyBase.BaseGetAllValues
        End Function

        'get the objects as an arraylist
        Public Function ToArrayList() As ArrayList
            Return New ArrayList(MyBase.BaseGetAllValues)
        End Function

        'get the objects as a sorted arraylist
        Public Function ToArrayListSorted() As ArrayList
            Dim List As New ArrayList(MyBase.BaseGetAllValues)
            List.Sort()
            Return List
        End Function

        'shared var used for Children
        Private Shared ParentKeys As ArrayList
        Private ParentKeysFast As ArrayList

        'construct a list of parent child relationships
        Private Sub ConstructParentChildList()
            'construct a list of parent keys
            ParentKeys = New ArrayList(Me.Count)

            For Each Obj As Objects.ObjectData In MyBase.BaseGetAllValues
                Dim ParentChild As ParentChild

                ParentChild.ObjectKey = Obj.ObjectGUID
                ParentChild.ParentKey = Obj.ParentGUID
                ParentKeys.Add(ParentChild)
            Next
        End Sub

        'construct a list of parent child relationships
        Public Sub ConstructParentChildListFast()
            'construct a list of parent keys
            ParentKeysFast = New ArrayList(Me.Count)

            For Each Obj As Objects.ObjectData In MyBase.BaseGetAllValues
                Dim ParentChild As ParentChild

                ParentChild.ObjectKey = Obj.ObjectGUID
                ParentChild.ParentKey = Obj.ParentGUID
                ParentKeysFast.Add(ParentChild)
            Next
        End Sub

        'return the children of this object (FAST
        Public Function ChildrenFast(ByVal Key As Objects.ObjectKey) As ObjectDataCollection
            Dim Children As New ObjectDataCollection

            For Each ParentChild As ParentChild In ParentKeysFast
                If ParentChild.ParentKey.Equals(Key) Then
                    Children.Add(Me.Item(ParentChild.ObjectKey))
                End If
            Next

            Return Children
        End Function

        'get all the children (deep) of this key
        Public Function ChildrenDeep(ByVal Key As Objects.ObjectKey) As ArrayList
            ConstructParentChildList()
            Return ChildrenDeepRecurse(Key)
        End Function

        'recursive portion of children deep
        Private Function ChildrenDeepRecurse(ByVal Key As Objects.ObjectKey) As ArrayList
            Dim List As New ArrayList

            For Each ParentChild As ParentChild In ParentKeys
                If ParentChild.ParentKey.Equals(Key) Then
                    List.Add(Me.Item(ParentChild.ObjectKey))
                    List.AddRange(ChildrenDeepRecurse(ParentChild.ObjectKey))
                End If
            Next

            Return List
        End Function

        'return the children of this object that are of this type
        Public Function ChildrenOfType(ByVal Key As Objects.ObjectKey, ByVal Type As String) As ObjectDataCollection
            ConstructParentChildList()
            ChildrenOfType = New ObjectDataCollection

            For Each ParentChild As ParentChild In ParentKeys
                If ParentChild.ParentKey.Equals(Key) Then
                    Dim Child As Objects.ObjectData = Me.Item(ParentChild.ObjectKey)
                    If Child.Type = Type Then ChildrenOfType.Add(Child)
                End If
            Next
        End Function

        'clone
        Public Function Clone() As Objects.ObjectDataCollection
            Dim Temp As New Objects.ObjectDataCollection

            For Each obj As Objects.ObjectData In MyBase.BaseGetAllValues
                Temp.Add(obj)
            Next

            Return Temp
        End Function

    End Class

#End Region

    'get a specific set of objects directly from the xml database using xpath
    Public Shared Function GetObjectsByXPath(ByVal Database As Integer, ByVal XPath As String) As ObjectDataCollection
        Dim Obj As New ObjectData
        Dim Node As XmlNode
        Dim NodeList As XmlNodeList

        'NOTE - query should return objects only

        NodeList = XML.SelectNodes(Database, XPath)
        GetObjectsByXPath = New ObjectDataCollection

        For Each Node In NodeList
            Obj.Clear()
            Obj.LoadFromNode(Node)
            GetObjectsByXPath.Add(Obj)
        Next

        Return GetObjectsByXPath
    End Function

    'get a specific set of objects directly from the xml database using xpath
    Public Shared Function GetObjectHashtableByXPath(ByVal Database As Integer, ByVal XPath As String) As ObjectHashtable
        Dim Obj As New ObjectData
        Dim Node As XmlNode
        Dim NodeList As XmlNodeList

        'NOTE - query should return objects only

        NodeList = XML.SelectNodes(Database, XPath)
        GetObjectHashtableByXPath = New ObjectHashtable

        For Each Node In NodeList
            Obj.Clear()
            Obj.LoadFromNode(Node)
            GetObjectHashtableByXPath.Add(Obj.ObjectGUID, Obj)
        Next

        Return GetObjectHashtableByXPath
    End Function

    'get a specific of object directly from the xml database using xpath
    Public Shared Function GetObjectByXPath(ByVal Database As Integer, ByVal XPath As String) As ObjectData
        Dim Obj As New ObjectData
        Dim Node As XmlNode

        Node = XML.SelectSingleNode(Database, XPath)
        If Not Node Is Nothing Then Obj.LoadFromNode(Node)

        Return Obj
    End Function

    'get all the objects of a specific type
    Public Shared Function GetAllObjectsOfType(ByVal Database As Integer, ByVal Type As String) As Objects.ObjectDataCollection
        Return GetObjectsByXPath(Database, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Type & "']")
    End Function

    'get all the objects of a specific type
    Public Shared Function GetAllObjectsOfTypeOH(ByVal Database As Integer, ByVal Type As String) As ObjectHashtable
        Return GetObjectHashtableByXPath(Database, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Type & "']")
    End Function

    'gets all the objects that have no parents (root folders)
    Public Shared Function GetRootFolders() As ObjectDataCollection
        Return GetObjectsByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='001-00000000-0000-0000-0000-000000000000']")
    End Function

    'check to see if an object exists
    Public Shared Function DoesObjectExist(ByVal ObjectGuid As ObjectKey) As Boolean
        Dim Node As XmlNode = XML.SelectSingleNode(ObjectGuid.Database, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='" & ObjectGuid.ToString & "']")

        If Node Is Nothing Then Return False Else Return True
    End Function

    'add a simple object of a given type
    Public Shared Sub AddSimpleObject(ByVal Type As String, ByVal Name As String, ByVal ParentGUID As ObjectKey, ByVal Database As Integer)
        Dim Obj As New ObjectData

        Obj.Name = Name
        Obj.Type = Type
        Obj.ObjectGUID = ObjectKey.NewGuid(Database)
        Obj.ParentGUID = ParentGUID
        Obj.Save()
    End Sub

    'delete objects contained in the list of guids
    Public Shared Function DeleteObjects(ByVal List As ArrayList) As ObjectHashtable
        Dim FailSublist As ArrayList
        Dim References As New ObjectHashtable
        Dim Failures As New ObjectHashtable

        Dim LargeDeleteMode As Boolean

        'get all the child objects' guids and add them to the list
        Dim TempList As ArrayList = New ArrayList

        For Each ObjectKey As Objects.ObjectKey In List
            For Each ChildGuid As Objects.ObjectKey In GetChildGuids(ObjectKey)
                If Not List.Contains(ChildGuid) And Not TempList.Contains(ChildGuid) Then TempList.Add(ChildGuid)
            Next
        Next

        List.AddRange(TempList)

        'get all the guids which contain a reference to a ObjectKey in the list
        For Each ObjectKey As Objects.ObjectKey In List
            Dim Subkeys As ObjectHashtable = XML.FKLookup.Subkeys(ObjectKey)
            If Not Subkeys Is Nothing Then
                References.Add(ObjectKey, Subkeys)
            End If
        Next

        'all the references must be in the list of guids to delete
        'otherwise create a list of outside refs that are stopping the delete
        For Each ReferenceList As DictionaryEntry In References
            For Each RefKey As Objects.ObjectKey In DirectCast(ReferenceList.Value, ObjectHashtable).Keys
                If Not List.Contains(RefKey) Then
                    Dim Key As Objects.ObjectKey = New Objects.ObjectKey(CStr(ReferenceList.Key))
                    If Not Failures.Contains(Key) Then
                        FailSublist = New ArrayList
                        FailSublist.Add(RefKey)
                        Failures.Add(Key, FailSublist)
                    Else
                        FailSublist = DirectCast(Failures(Key), ArrayList)
                        FailSublist.Add(RefKey)
                        Failures(Key) = FailSublist
                    End If
                End If
            Next
        Next

        'if there no failures then delete
        If Failures.Count > 0 Then
            Return Failures
        Else
            XML.Lock = True

            'delete column settings also
            Dim XPath As String
            Dim ColumnSetting As Objects.ObjectData
            Dim ColumnSettingList As New ArrayList

            For Each ObjectKey As Objects.ObjectKey In List
                XPath = "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & ObjectKey.ToString & "']"
                ColumnSetting = GetObjectByXPath(XML.DBTypes.ColumnLayouts, XPath)
                If ColumnSetting.ObjectGUID.IsNotEmpty Then
                    ColumnSettingList.Add(ColumnSetting.ObjectGUID)
                End If
            Next
            List.AddRange(ColumnSettingList)

            Dim ProgressBar As ProgressBar = Nothing

            If List.Count > 20 Then
                General.MainExplorer.Form.Enabled = False
                ProgressBar = New ProgressBar
                ProgressBar.Caption = "Deleting Components"
                ProgressBar.Maximum = List.Count
                ProgressBar.TopMost = True
                ProgressBar.Show()
                LargeDeleteMode = True
            End If

            Dim DatabaseTable As Hashtable
            Dim TempTable As ObjectHashtable
            DatabaseTable = New Hashtable

            'create index of keys to be deleted
            For Each key As Objects.ObjectKey In List
                If DatabaseTable.ContainsKey(key.Database) Then
                    DirectCast(DatabaseTable.Item(key.Database), ObjectHashtable).Add(key, Nothing)
                Else
                    TempTable = New ObjectHashtable
                    TempTable.Add(key, Nothing)
                    DatabaseTable.Add(key.Database, Temptable)
                End If
            Next

            For Each Item As DictionaryEntry In DatabaseTable
                Dim Index As ObjectHashtable = DirectCast(Item.Value, ObjectHashtable)
                Dim DB As Integer = CInt(Item.Key)

                Dim RootNode As XmlNode = XML.SelectSingleNode(DB, "//RPGXplorerDatabase")
                Dim ObjectNodes As XmlNodeList = RootNode.ChildNodes
                Dim NodesToDelete As New ArrayList

                'find nodes to delete
                For Each Node As XmlNode In ObjectNodes
                    Dim KeyNode As XmlNode = Node.ChildNodes.Item(2)
                    Dim Key As New Objects.ObjectKey(KeyNode.InnerText)

                    If Index.Contains(Key) Then
                        NodesToDelete.Add(Node)
                        If LargeDeleteMode Then
                            ProgressBar.Increment()
                            Application.DoEvents()
                        End If
                        XML.FKLookup.RemoveSubkey(Key)
                    End If
                Next

                'delete the nodes
                For Each Node As XmlNode In NodesToDelete
                    RootNode.RemoveChild(Node)
                Next

            Next

            XML.Lock = False

            If LargeDeleteMode Then
                ProgressBar.Close()
                General.MainExplorer.Form.Enabled = True
            End If

            Return Nothing
        End If
    End Function

    'recursively get all the guids that are children of the specified ObjectKey
    Private Shared Function GetChildGuids(ByVal ObjGuid As ObjectKey) As ArrayList
        Dim NodeList As XmlNodeList
        Dim Node As XmlNode
        Dim ChildGuids As New ArrayList
        Dim ChildGuid As ObjectKey

        NodeList = XML.GetChildNodes(ObjGuid)

        If Not NodeList Is Nothing Then
            For Each Node In NodeList
                ChildGuid = New ObjectKey(Node.SelectSingleNode("./ObjectGUID").InnerText)
                ChildGuids.Add(ChildGuid)
                ChildGuids.AddRange(GetChildGuids(ChildGuid))
            Next
        End If

        Return ChildGuids
    End Function

End Class