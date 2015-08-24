Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Imports System.Collections.Specialized
Imports System.Xml

Namespace Rules

    Public Class Lists

        Public Shared ActionTypes As String()
        Public Shared AgeRollTypes As String()
        Public Shared AlignmentTypes As String()
        Public Shared CannotUseTypes As String()
        Public Shared CharacterStates As String()
        Public Shared ClassSkillTypes As String()
        Public Shared DamageTypesDR As String()
        Public Shared DamageTypesResistance As String()
        Public Shared DamageTypesWeapon As String()
        Public Shared DROvercomeType As String()
        Public Shared DurationTypes As String()
        Public Shared FeatTypes As String()
        Public Shared FeatTypesBase As String()
        Public Shared FeatureTypes As String()
        Public Shared FeatureTypesBase As String()
        Public Shared GenderTypes As String()
        Public Shared Licenses As String()
        Public Shared ModifierCategories As String()
        Public Shared ModifierTypes As String()
        Public Shared MonsterDefinitionTypes As String()
        Public Shared MonsterTypesBase As String()
        Public Shared MonsterSubtypes As String()
        Public Shared NaturalAttackTypes As String()
        Public Shared NaturalAttackTypesBase As String()
        Public Shared PrerequisiteTypes As String()
        Public Shared SavingThrows As String()
        Public Shared Sizes As String()
        Public Shared SkillGroups As String()
        Public Shared Sourcebooks As String()
        Public Shared SpellcasterTypes As String()
        Public Shared SystemElementTypes As String()
        Public Shared UserTags As String()
        Public Shared UsesTypes As String()

        'Added
        'WeaponForm
        Public Shared EncumbranceTypes As String()
        Public Shared MissileEncumberanceTypes As String()
        Public Shared WeaponDamageTypes As String()
        Public Shared JunctionTypes As String()
        Public Shared TrainingTypes As String()
        'ArmorForm
        Public Shared ArmorTrainingTypes As String()
        Public Shared DonActionTypes As String()
        'MagicAbilityForms
        Public Shared AuraStrengths As String()
        Public Shared PriceTypes As String()
        Public Shared ArmorTypes As String()
        Public Shared WeaponTypes As String()
        'ScrollForm
        Public Shared ScrollSpellTypes As String()
        'Intelligent Items
        Public Shared IntelOptions As String()
        Public Shared IntelLesserPowers As String()
        Public Shared IntelGreaterPowers As String()
        Public Shared IntelSpecialPurpose As String()
        Public Shared IntelDedicatedPowers As String()
        'Cursed Items
        Public Shared CursedCurses As String()
        Public Shared CursedFunctioning As String()
        Public Shared CursedSituations As String()
        Public Shared CursedRequirements As String()
        Public Shared CursedDrawbacks As String()
        'Items
        Public Shared ItemTypes As String()
        Public Shared ItemTypesBase As String()
        'Domians
        Public Shared AlignmentAxis As String()
        'FeatForm
        Public Shared FocusFilters As String()
        'SpellLists
        Public Shared SpellFilterOptions As String()
        Public Shared SpellCastingAbility As String() 'class form
        'SpellForm
        Public Shared SpellLevelTypes As String()
        'PowerForm
        Public Shared PowerLevelTypes As String()
        'For matching aligment psedo-keys with names
        Public Shared AlignmentLookupTable As ObjectHashtable
        'roll methods
        Public Shared RollMethods As String()
        'Monster Class Types
        Public Shared MonsterClassTypes As String()
        Public Shared CompanionTypes As String()
        'Fly Speed Maneuverability
        Public Shared FlyingManeuverability As String()
        'monster casters
        Public Shared MonsterCasterTypes As String()

        'load all the string arrays (lists)
        Public Shared Sub LoadLists()
            Try
                'load user additions
                Dim UserFeatTypes As New ArrayList
                Dim UserFeatureTypes As New ArrayList
                Dim UserItemTypes As New ArrayList
                Dim LicenseTemp As New ArrayList
                Dim UserMonsterTypes As New ArrayList
                Dim SourcebookTemp As New ArrayList
                Dim UserTagTemp As New ArrayList
                Dim UserNaturalAttacks As New ArrayList

                Dim Objs As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.UserListItemType)

                For Each Obj As Objects.ObjectData In Objs
                    Select Case Obj.Element("ListName")
                        Case "Feat Types"
                            UserFeatTypes.Add(Obj.Name)
                        Case "Feature Types"
                            UserFeatureTypes.Add(Obj.Name)
                        Case "Item Categories"
                            UserItemTypes.Add(Obj.Name)
                        Case "Licenses"
                            LicenseTemp.Add(Obj.Name)
                        Case "Monster Types"
                            UserMonsterTypes.Add(Obj.Name)
                        Case "Sourcebooks"
                            SourcebookTemp.Add(Obj.Name)
                        Case "User Tags"
                            UserTagTemp.Add(Obj.Name)
                        Case "Natural Attack Types"
                            UserNaturalAttacks.Add(Obj.Name)
                    End Select
                Next

                'licenses
                If LicenseTemp.Count > 0 Then
                    ReDim Licenses(LicenseTemp.Count - 1)
                    For n As Integer = 0 To LicenseTemp.Count - 1
                        Licenses(n) = LicenseTemp(n).ToString
                    Next
                End If
                If Not Licenses Is Nothing Then
                    Array.Sort(Licenses)
                End If


                'sourcebooks
                If SourcebookTemp.Count > 0 Then
                    ReDim Sourcebooks(SourcebookTemp.Count - 1)
                    For n As Integer = 0 To SourcebookTemp.Count - 1
                        Sourcebooks(n) = SourcebookTemp(n).ToString
                    Next
                End If
                If Not Sourcebooks Is Nothing Then
                    Array.Sort(Sourcebooks)
                End If


                'user tags
                If UserTagTemp.Count > 0 Then
                    ReDim UserTags(UserTagTemp.Count - 1)
                    For n As Integer = 0 To UserTagTemp.Count - 1
                        UserTags(n) = UserTagTemp(n).ToString
                    Next
                End If
                If Not UserTags Is Nothing Then
                    Array.Sort(UserTags)
                End If

                'load arrays from xml
                Sizes = LoadList("Sizes.xml", "Size")
                ActionTypes = LoadList("ActionTypes.xml", "ActionType")
                AgeRollTypes = LoadList("AgeRollTypes.xml", "AgeRollType")
                AlignmentTypes = LoadList("AlignmentTypes.xml", "AlignmentType")
                CannotUseTypes = LoadList("CannotUseTypes.xml", "ObjectType")
                CharacterStates = LoadList("CharacterStates.xml", "CharacterState")
                DamageTypesDR = LoadList("DamageTypesDR.xml", "DamageType")
                DamageTypesResistance = LoadList("DamageTypesResistance.xml", "DamageType")
                DamageTypesWeapon = LoadList("DamageTypesWeapon.xml", "DamageType")
                DROvercomeType = LoadList("DROvercomeTypes.xml", "OvercomeType")
                DurationTypes = LoadList("DurationTypes.xml", "DurationType")
                FeatTypes = LoadList("FeatTypes.xml", "FeatType")
                FeatTypesBase = FeatTypes
                FeatureTypes = LoadList("FeatureTypes.xml", "FeatureType")
                FeatureTypesBase = FeatureTypes
                GenderTypes = LoadList("GenderTypes.xml", "GenderType")
                ModifierCategories = LoadList("ModifierCategories.xml", "ModifierCategory")
                ModifierTypes = LoadList("ModifierTypes.xml", "ModifierType")
                MonsterDefinitionTypes = LoadList("MonsterTypes.xml", "MonsterType")
                MonsterTypesBase = MonsterDefinitionTypes
                MonsterSubtypes = LoadList("MonsterSubtypes.xml", "MonsterSubtype")

                NaturalAttackTypes = LoadList("NaturalAttackTypes.xml", "NaturalAttackType")
                NaturalAttackTypesBase = NaturalAttackTypes

                PrerequisiteTypes = LoadList("PrerequisiteTypes.xml", "PrerequisiteType")
                SkillGroups = LoadList("SkillGroups.xml", "SkillGroup")
                SpellcasterTypes = LoadList("SpellcasterTypes.xml", "SpellcasterType")
                UsesTypes = LoadList("UsesTypes.xml", "UsesType")

                'feat types
                UserFeatTypes.AddRange(FeatTypes)
                UserFeatTypes.Sort()
                ReDim FeatTypes(UserFeatTypes.Count - 1)
                For n As Integer = 0 To UserFeatTypes.Count - 1
                    FeatTypes(n) = UserFeatTypes(n).ToString
                Next

                'Feature types
                UserFeatureTypes.AddRange(FeatureTypes)
                UserFeatureTypes.Sort()
                ReDim FeatureTypes(UserFeatureTypes.Count - 1)
                For n As Integer = 0 To UserFeatureTypes.Count - 1
                    FeatureTypes(n) = UserFeatureTypes(n).ToString
                Next

                'monster types
                UserMonsterTypes.AddRange(MonsterDefinitionTypes)
                UserMonsterTypes.Sort()
                ReDim MonsterDefinitionTypes(UserMonsterTypes.Count - 1)
                For n As Integer = 0 To UserMonsterTypes.Count - 1
                    MonsterDefinitionTypes(n) = UserMonsterTypes(n).ToString
                Next

                'Natural Attack Types
                UserNaturalAttacks.AddRange(NaturalAttackTypes)
                UserNaturalAttacks.Sort()
                ReDim NaturalAttackTypes(UserNaturalAttacks.Count - 1)
                For n As Integer = 0 To UserNaturalAttacks.Count - 1
                    NaturalAttackTypes(n) = UserNaturalAttacks(n).ToString
                Next

                ReDim SavingThrows(2)
                SavingThrows(0) = "Fortitude"
                SavingThrows(1) = "Reflex"
                SavingThrows(2) = "Will"

                ReDim ClassSkillTypes(1)
                ClassSkillTypes(0) = "Class"
                ClassSkillTypes(1) = "Cross-Class"

                ReDim WeaponDamageTypes(2)
                WeaponDamageTypes(0) = "Bludgeoning"
                WeaponDamageTypes(1) = "Piercing"
                WeaponDamageTypes(2) = "Slashing"

                ReDim JunctionTypes(2)
                JunctionTypes(0) = ""
                JunctionTypes(1) = "And"
                JunctionTypes(2) = "Or"

                ReDim TrainingTypes(2)
                TrainingTypes(0) = "Simple"
                TrainingTypes(1) = "Martial"
                TrainingTypes(2) = "Exotic"

                ReDim EncumbranceTypes(2)
                EncumbranceTypes(0) = "Light"
                EncumbranceTypes(1) = "One-Handed"
                EncumbranceTypes(2) = "Two-Handed"

                ReDim MissileEncumberanceTypes(3)
                MissileEncumberanceTypes(0) = "One-Handed"
                MissileEncumberanceTypes(1) = "Two-Handed (Light for 1 Hand Fire)"
                MissileEncumberanceTypes(2) = "Two-Handed (Heavy for 1 Hand Fire)"
                MissileEncumberanceTypes(3) = "Two-Handed Only"

                ReDim ArmorTrainingTypes(3)
                ArmorTrainingTypes(0) = "Light"
                ArmorTrainingTypes(1) = "Medium"
                ArmorTrainingTypes(2) = "Heavy"
                ArmorTrainingTypes(3) = "Shield"

                ReDim DonActionTypes(2)
                DonActionTypes(0) = "Move Action(s)"
                DonActionTypes(1) = "Minute(s)"
                DonActionTypes(2) = "Round(s)"

                ReDim AuraStrengths(2)
                AuraStrengths(0) = "Faint"
                AuraStrengths(1) = "Moderate"
                AuraStrengths(2) = "Strong"

                ReDim PriceTypes(1)
                PriceTypes(0) = "Bonus"
                PriceTypes(1) = "Specific"

                ReDim ArmorTypes(2)
                ArmorTypes(0) = "Armor"
                ArmorTypes(1) = "Armor & Shield"
                ArmorTypes(2) = "Shield"

                ReDim WeaponTypes(5)
                WeaponTypes(0) = "All Weapons and Ammunition"
                WeaponTypes(1) = "Ammunition Only"
                WeaponTypes(2) = "Melee Weapons Only"
                WeaponTypes(3) = "Melee, Thrown and Ammo Only"
                WeaponTypes(4) = "Ranged Weapons Only"
                WeaponTypes(5) = "Thrown Weapons Only"

                ReDim ScrollSpellTypes(1)
                ScrollSpellTypes(0) = "Arcane"
                ScrollSpellTypes(1) = "Divine"

                ReDim IntelOptions(1)
                IntelOptions(0) = "Lesser Powers"
                IntelOptions(1) = "Greater Powers"

                'ReDim IntelLesserPowers(21)
                'IntelLesserPowers(0) = "Item can bless its allies 3/day"
                'IntelLesserPowers(1) = "Item can use faerie 3/day"
                'IntelLesserPowers(2) = "Item can cast minor image 1/day"
                'IntelLesserPowers(3) = "Item has deathwatch continually active"
                'IntelLesserPowers(4) = "Item can use detect magic at will"""
                'IntelLesserPowers(5) = "Item has 10 ranks in Intimidate"
                'IntelLesserPowers(6) = "Item has 10 ranks in Decipher Script"
                'IntelLesserPowers(7) = "Item has 10 ranks in Knowledge"
                'IntelLesserPowers(8) = "Item has 10 ranks in Search"
                'IntelLesserPowers(9) = "Item has 10 ranks in Spot"
                'IntelLesserPowers(10) = "Item has 10 ranks in Listen"
                'IntelLesserPowers(11) = "Item has 10 ranks in Spellcraft"
                'IntelLesserPowers(12) = "Item has 10 ranks in Sense Motive"
                'IntelLesserPowers(13) = "Item has 10 ranks in Bluff"
                'IntelLesserPowers(14) = "Item has 10 ranks in Diplomacy"
                'IntelLesserPowers(15) = "Item can cast major image 1/day"
                'IntelLesserPowers(16) = "Item can cast darkness 3/day"
                'IntelLesserPowers(17) = "Item can use hold person on an enemy 3/day"
                'IntelLesserPowers(18) = "Item can activate zone of truth 3/day"
                'IntelLesserPowers(19) = "Item can use daze monster 3/day"
                'IntelLesserPowers(20) = "Item can use locate object 3/day"
                'IntelLesserPowers(21) = "Item can use cure moderate wounds (2d8+3) on wielder 3/day"

                'ReDim IntelGreaterPowers(21)
                'IntelGreaterPowers(0) = "Item can detect opposing alignment at will"
                'IntelGreaterPowers(1) = "Item can detect undead at will"
                'IntelGreaterPowers(2) = "Item can cause fear in an enemy at will"
                'IntelGreaterPowers(3) = "Item can use dimensional anchor on a foe 1/day"
                'IntelGreaterPowers(4) = "Item can use dismissal on a foe 1/day"
                'IntelGreaterPowers(5) = "Item can use lesser globe of invulnerability 1/day"
                'IntelGreaterPowers(6) = "Item can use arcane eye 1/day"
                'IntelGreaterPowers(7) = "Item has continuous detect scrying effect"
                'IntelGreaterPowers(8) = "Item creates wall of fire in a ring with the wielder at the center 1/day"
                'IntelGreaterPowers(9) = "Item can use quench on fires 3/day"
                'IntelGreaterPowers(10) = "Item has status effect, usable at will"
                'IntelGreaterPowers(11) = "Item can use gust of wind 3/day"
                'IntelGreaterPowers(12) = "Item can use clairvoyance 3/day"
                'IntelGreaterPowers(13) = "Item can create magic circle against opposing alignment at will"
                'IntelGreaterPowers(14) = "Item can use haste on its owner 3/day"
                'IntelGreaterPowers(15) = "Item can create daylight 3/day"
                'IntelGreaterPowers(16) = "Item can create deeper darkness 3/day"
                'IntelGreaterPowers(17) = "Item can use invisiblity purge (30 ft. range) 3/day"
                'IntelGreaterPowers(18) = "Item can use slow on its enemies 3/day"
                'IntelGreaterPowers(19) = "Item can locate creature 3/day"
                'IntelGreaterPowers(20) = "Item can use fear against foes 3/day"
                'IntelGreaterPowers(21) = "Item can use detect thoughts at will"

                'ReDim IntelSpecialPurpose(10)
                'IntelSpecialPurpose(0) = "Defeat/slay diametrically opposed alignment"
                'IntelSpecialPurpose(1) = "Defeat/slay arcane spellcasters (including spellcasting monsters and those that use spell-like abilities)"
                'IntelSpecialPurpose(2) = "Defeat/slay divine spellcasters (including divine entities and servitors"
                'IntelSpecialPurpose(3) = "Defeat/slay nonspellcasters"
                'IntelSpecialPurpose(4) = "Defeat/slay a particular creature type"
                'IntelSpecialPurpose(5) = "Defeat/slay a particular race or kind of creature"
                'IntelSpecialPurpose(6) = "Defend a particular race or kind of creature"
                'IntelSpecialPurpose(7) = "Defeat/slay the servants and interests of a specific deity"
                'IntelSpecialPurpose(8) = "Defend the servants and interests of a specific deity"
                'IntelSpecialPurpose(9) = "Defeat/slay all (other than the item and the wielder)"
                'IntelSpecialPurpose(10) = "DM's or characters choice"

                'ReDim IntelDedicatedPowers(16)
                'IntelDedicatedPowers(0) = "Item can use ice storm"
                'IntelDedicatedPowers(1) = "Item can use confusion"
                'IntelDedicatedPowers(2) = "Item can use phantasmal killer"
                'IntelDedicatedPowers(3) = "Item can use cruching despair"
                'IntelDedicatedPowers(4) = "Item can use dimension door on itself and wielder"
                'IntelDedicatedPowers(5) = "Item can use contagion (heightend to 4th level) as touch attack"
                'IntelDedicatedPowers(6) = "Item can use poison (heightend to 4th level) as touch attack"
                'IntelDedicatedPowers(7) = "Item can use rusting grasp as touch attack"
                'IntelDedicatedPowers(8) = "Item can cast 10d6 lightning bolt"
                'IntelDedicatedPowers(9) = "Item can cast 10d6 fireball"
                'IntelDedicatedPowers(10) = "Wielder gets +2 luck bonus in attacks, saves and checks"
                'IntelDedicatedPowers(11) = "Item can use mass inflict light wounds"
                'IntelDedicatedPowers(12) = "Item can use song of discord"
                'IntelDedicatedPowers(13) = "Item can use prying eyes"
                'IntelDedicatedPowers(14) = "Item can cast 15d6 greater shout 3/day"
                'IntelDedicatedPowers(15) = "Item can use waves of exhaustion"
                'IntelDedicatedPowers(16) = "Item can use true resurrection on wielder, once per month"

                'ReDim CursedCurses(5)
                'CursedCurses(0) = "Delusion"
                'CursedCurses(1) = "Opposite effect or target"
                'CursedCurses(2) = "Intermittent functioning"
                'CursedCurses(3) = "Requirement"
                'CursedCurses(4) = "Drawback"
                'CursedCurses(5) = "Completely different effect"

                'ReDim CursedFunctioning(2)
                'CursedFunctioning(0) = "Unreliable"
                'CursedFunctioning(1) = "Dependent"
                'CursedFunctioning(2) = "Uncontrolled"

                'ReDim CursedSituations(19)
                'CursedSituations(0) = "Temperature below freezing"
                'CursedSituations(1) = "Temperature above freezing"
                'CursedSituations(2) = "During the day"
                'CursedSituations(3) = "During the night"
                'CursedSituations(4) = "In direct sunlight"
                'CursedSituations(5) = "Out of direct sunlight"
                'CursedSituations(6) = "Underwater"
                'CursedSituations(7) = "Out of water"
                'CursedSituations(8) = "Underground"
                'CursedSituations(9) = "Aboveground"
                'CursedSituations(10) = "Within 10 feet of a random creature type"
                'CursedSituations(11) = "Within 10 feet of a random race or kind of creature"
                'CursedSituations(12) = "Within 10 feet of an arcane spellcaster"
                'CursedSituations(13) = "Within 10 feet of a divine spellcaster"
                'CursedSituations(14) = "In the hands of a nonspellcaster"
                'CursedSituations(15) = "In the hands of a spellcaster"
                'CursedSituations(16) = "In the hands of a creature of a particular allignment"
                'CursedSituations(17) = "In the hands of a creature of particular agenda"
                'CursedSituations(18) = "On nonholy days or during particular astrological events"
                'CursedSituations(19) = "More than 100 miles from a particular site"

                'ReDim CursedRequirements(17)
                'CursedRequirements(0) = "Character must eat twice as much as normal"
                'CursedRequirements(1) = "Character must sleep twice as much as normal"
                'CursedRequirements(2) = "Character must undergo a specific quest (one time only, and the item functions normally thereafter)"
                'CursedRequirements(3) = "Character must sacrifice (destroy) 100gp worth of valuables per day"
                'CursedRequirements(4) = "Character must sacrifice (destroy) 2000gp worth of magic items each week"
                'CursedRequirements(5) = "Character must swear fealty to a particular noble or his family"
                'CursedRequirements(6) = "Character must discard all other magic items"
                'CursedRequirements(7) = "Character must worship a particular deity"
                'CursedRequirements(8) = "Character must change there name to a specific name (The item only works for characters of that name)"
                'CursedRequirements(9) = "Character must add a specific class at the next opportunity if not of that class already"
                'CursedRequirements(10) = "Character must have a minimum number of ranks in a particular skill"
                'CursedRequirements(11) = "Character must sacrifice 2 points of constitution one time. If the character gets the points back (such as from a restoration spell), the item ceases functioning"
                'CursedRequirements(12) = "Item must be cleansed with holy water each day"
                'CursedRequirements(13) = "Item must be used to kill a living creature each day"
                'CursedRequirements(14) = "Item must be bathed in volcanic lave once per month"
                'CursedRequirements(15) = "Item must be used at least once per day, or it won't function again for its current possessor"
                'CursedRequirements(16) = "Item must draw bolld when wielded (weapons only). It can't be put away or exchanged until it has scored a hit"
                'CursedRequirements(17) = "Item must have a particular spell cast upon it each day"

                'ReDim CursedDrawbacks(30)
                'CursedDrawbacks(0) = "Character's hair grows 1 inch longer. Only happens once"
                'CursedDrawbacks(1) = "Character shrinks 1/2 inch. Only happens once"
                'CursedDrawbacks(2) = "Character grows 1/2 inch. Only happens once"
                'CursedDrawbacks(3) = "Temperature around item is 10°F cooler than normal"
                'CursedDrawbacks(4) = "Temperature around item is 10°F warmer than normal"
                'CursedDrawbacks(5) = "Character's hair changes color"
                'CursedDrawbacks(6) = "Character's skin changes color"
                'CursedDrawbacks(7) = "Character now bears some identifying mark"
                'CursedDrawbacks(8) = "Character's gender changes"
                'CursedDrawbacks(9) = "Character's race or kind changes"
                'CursedDrawbacks(10) = "Character is afflicated with a random disease that cannot be cured"
                'CursedDrawbacks(11) = "Item continually emits a disturbing sound"
                'CursedDrawbacks(12) = "Item looks ridiculous"
                'CursedDrawbacks(13) = "Character becomes selfishly possessive about the item"
                'CursedDrawbacks(14) = "Character becomes paranoid about losing the item and afraid of damage occurring to it"
                'CursedDrawbacks(15) = "Character's alignment changes"
                'CursedDrawbacks(16) = "Character must attack nearest creature (5% chance each day)"
                'CursedDrawbacks(17) = "Character is stunned for 1d4 once the item function is finished (or randomly, 1/day)"
                'CursedDrawbacks(18) = "Character's vision is blurry"
                'CursedDrawbacks(19) = "Character gains one negative level"
                'CursedDrawbacks(20) = "Character gains teo negative levels"
                'CursedDrawbacks(21) = "Character must make a Will save each day or take 1 point of Intelligence damage"
                'CursedDrawbacks(22) = "Character must make a Will save each day or take 1 point of Wisdom damage"
                'CursedDrawbacks(23) = "Character must make a Will save each day or take 1 point of Charisma damage"
                'CursedDrawbacks(24) = "Character must make a Will save each day or take 1 point of Constitution damage"
                'CursedDrawbacks(25) = "Character must make a Will save each day or take 1 point of Strength damage"
                'CursedDrawbacks(26) = "Character must make a Will save each day or take 1 point of Dexterity damage"
                'CursedDrawbacks(27) = "Character is polymorphed into a specific creature (5% chance each day)"
                'CursedDrawbacks(28) = "Character cannot cast arcane spells"
                'CursedDrawbacks(29) = "Character cannot cast divine spells"
                'CursedDrawbacks(30) = "Character cannot cast any spells"

                ReDim ItemTypes(7)
                ItemTypes(0) = "Adventuring Gear"
                ItemTypes(1) = "Special Substances and Items"
                ItemTypes(2) = "Tools and Skill Kits"
                ItemTypes(3) = "Clothing"
                ItemTypes(4) = "Food, Drink and Lodging"
                ItemTypes(5) = "Mounts and Related Gear"
                ItemTypes(6) = "Transport"
                ItemTypes(7) = "Spellcasting and Services"
                ItemTypesBase = ItemTypes

                UserItemTypes.AddRange(ItemTypes)
                UserItemTypes.Sort()
                ReDim ItemTypes(UserItemTypes.Count - 1)
                For n As Integer = 0 To UserItemTypes.Count - 1
                    ItemTypes(n) = UserItemTypes(n).ToString
                Next

                ReDim SystemElementTypes(2)
                SystemElementTypes(0) = "Character"
                SystemElementTypes(1) = "Weapon"
                SystemElementTypes(2) = "Armor"

                ReDim AlignmentAxis(3)
                AlignmentAxis(0) = "Lawful"
                AlignmentAxis(1) = "Chaotic"
                AlignmentAxis(2) = "Good"
                AlignmentAxis(3) = "Evil"

                ReDim FocusFilters(16)
                FocusFilters(0) = "Alignment"
                FocusFilters(1) = "Discipline Specialization"
                FocusFilters(2) = "Domain"
                FocusFilters(3) = "Power"
                FocusFilters(4) = "Power Discipline"
                FocusFilters(5) = "Spell School"
                FocusFilters(6) = "Skill"
                FocusFilters(7) = "Spell"
                FocusFilters(8) = "Any Weapon"
                FocusFilters(9) = "Natural Weapon"
                FocusFilters(10) = "Simple Weapon"
                FocusFilters(11) = "Martial Weapon"
                FocusFilters(12) = "Exotic Weapon"
                FocusFilters(13) = "Ranged Weapon"
                FocusFilters(14) = "Melee Weapon"
                FocusFilters(15) = "Crossbow"
                FocusFilters(16) = "Custom"

                ReDim SpellFilterOptions(3)
                SpellFilterOptions(0) = "Class"
                SpellFilterOptions(1) = "Domain"
                SpellFilterOptions(2) = "School"
                SpellFilterOptions(3) = "Descriptor"

                ReDim SpellLevelTypes(2)
                SpellLevelTypes(0) = "Class"
                SpellLevelTypes(1) = "Domain"
                SpellLevelTypes(2) = "Category"

                ReDim PowerLevelTypes(1)
                PowerLevelTypes(0) = "Class"
                PowerLevelTypes(1) = "Discipline Specialization"

                ReDim SpellCastingAbility(3)
                SpellCastingAbility(0) = "No"
                SpellCastingAbility(1) = "Spellcaster"
                SpellCastingAbility(2) = "Psionic"
                SpellCastingAbility(3) = "Prestige Advancement"

                'alignment lookup table
                AlignmentLookupTable = New ObjectHashtable(9)
                AlignmentLookupTable.Add(References.LawfulGood, "Lawful Good")
                AlignmentLookupTable.Add(References.LawfulNeutral, "Lawful Neutral")
                AlignmentLookupTable.Add(References.LawfulEvil, "Lawful Evil")
                AlignmentLookupTable.Add(References.NeutralGood, "Neutral Good")
                AlignmentLookupTable.Add(References.TrueNeutral, "True Neutral")
                AlignmentLookupTable.Add(References.NeutralEvil, "Neutral Evil")
                AlignmentLookupTable.Add(References.ChaoticGood, "Chaotic Good")
                AlignmentLookupTable.Add(References.ChaoticNeutral, "Chaotic Neutral")
                AlignmentLookupTable.Add(References.ChaoticEvil, "Chaotic Evil")

                ReDim RollMethods(4)
                RollMethods(0) = "4d6"
                RollMethods(1) = "5d6"
                RollMethods(2) = "3d6"
                RollMethods(3) = "Point Buy"
                RollMethods(4) = "Point Array"


                ReDim MonsterClassTypes(3)
                MonsterClassTypes(0) = "Animal Companion"
                MonsterClassTypes(1) = "Familiar"
                MonsterClassTypes(2) = "Monster Type"
                MonsterClassTypes(3) = "Special Mount"

                ReDim FlyingManeuverability(4)
                FlyingManeuverability(0) = "Clumsy"
                FlyingManeuverability(1) = "Poor"
                FlyingManeuverability(2) = "Average"
                FlyingManeuverability(3) = "Good"
                FlyingManeuverability(4) = "Perfect"

                ReDim CompanionTypes(3)
                CompanionTypes(0) = "Animal Companion"
                CompanionTypes(1) = "Familiar or Psicrystal"
                CompanionTypes(2) = "Mount"
                CompanionTypes(3) = "Special Mount or Fiendish Servant"

                ReDim MonsterCasterTypes(2)
                MonsterCasterTypes(0) = "No"
                MonsterCasterTypes(1) = "Spellcaster"
                MonsterCasterTypes(2) = "Psionic"

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'generic routine to load an array will values from an xml config file
        Private Shared Function LoadList(ByVal XMLFile As String, ByVal NodeName As String) As String()
            Dim XmlRdr As XmlTextReader
            Dim temp As New StringCollection
            Dim List As String()
            Dim x As Integer = 0

            Try
                XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\" & XMLFile)

                While XmlRdr.Read
                    Select Case XmlRdr.NodeType
                        Case XmlNodeType.Element
                            Select Case XmlRdr.Name
                                Case "RPGXplorerConfig", "RPGXplorerConfig"
                                    'do nothing
                                Case NodeName
                                    temp.Add(XmlRdr.ReadString)
                                Case Else
                                    Throw New Exceptions.XMLSchemaException("Unexpected element in the " & XMLFile & " config file")
                            End Select
                        Case XmlNodeType.EndElement
                            'do nothing
                    End Select
                End While

                'load the string array
                ReDim List(temp.Count - 1)
                For x = 0 To temp.Count - 1
                    List(x) = temp.Item(x)
                Next

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace

