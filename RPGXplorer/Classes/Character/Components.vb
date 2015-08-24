Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class Components

        'this class provides methods for incrementally updating a characters acquired modifiers, system abilities and other components 
        'it also provides methods for accessing them in a generalised way.

#Region "Structures"

        Public Structure ComponentData
            Public Key As Objects.ObjectKey
            Public FocusGuid As Objects.ObjectKey

            Public SourceName As String
            Public SourceKey As Objects.ObjectKey

            Public ItemSource As Boolean
            Public ValidInfo As ValidData

            Public ComponentType As ComponentType
            Public LevelAcquired As Integer
            Public LevelLost As Integer
            Public UserAdded As Boolean
            Public TransientObject As Objects.ObjectData

            'for Natural AttackType name
            Public ExtraData As String

            Public UserModifierDisabled As Boolean

            Public Function Clone() As ComponentData
                Dim Temp As ComponentData

                Temp.Key = Me.Key
                Temp.FocusGuid = Me.FocusGuid
                Temp.SourceName = Me.SourceName
                Temp.SourceKey = Me.SourceKey
                Temp.ItemSource = Me.ItemSource

                Temp.ValidInfo.Valid = Me.ValidInfo.Valid
                Temp.ValidInfo.Prerequisites = DirectCast(Me.ValidInfo.Prerequisites.Clone, ArrayList)
                Temp.ValidInfo.Preconditions = DirectCast(Me.ValidInfo.Preconditions.Clone, ArrayList)

                Temp.ComponentType = Me.ComponentType
                Temp.LevelAcquired = Me.LevelAcquired
                Temp.LevelLost = Me.LevelLost
                Temp.UserAdded = Me.UserAdded
                Temp.TransientObject = Me.TransientObject
                Temp.ExtraData = Me.ExtraData
                Temp.UserModifierDisabled = Me.UserModifierDisabled

                Return Temp
            End Function

        End Structure

        Public Structure ConditionData
            Public Result As Boolean
            Public Condition As Objects.ObjectData

            'Used for multiple prerequisites with "The Same..." type foci
            Public Focus As Objects.ObjectKey
            Public MultipleFoci As Boolean
        End Structure

        Public Structure ValidData
            Public Prerequisites As ArrayList
            Public Preconditions As ArrayList
            Public Valid As Boolean
        End Structure

#End Region

#Region "Enumeration"

        Public Enum ComponentType
            BonusSpellSlots
            DamageReduction
            DamageResistance
            FavoredEnemy
            Modifier
            SetAbility
            SetValue
            SkillAbilityExchange
            SkillSynergy
            SystemAbility
        End Enum

        Public Enum ArmorBonusType
            Armor
            Shield
        End Enum

#End Region

#Region "Member Variables"

        Private _Character As Character

        'collections
        Public BonusSpellSlots As New ArrayList
        Private DamageReductions As New ArrayList
        Private DamageResistances As New ArrayList

        Public SetAbilities As New Library
        Private SetValues As New Library
        Public Modifiers As New Library
        Private _SystemAbilities As New Library

        'prereqs and preconditions
        Private Prerequisites As New StringKeyHashtable
        Private Preconditions As New StringKeyHashtable

        'Valid Lookup tables
        Public Feats As New StringKeyHashtable
        Public Features As New StringKeyHashtable

        'jump modifier key
        Public JumpModKey As Objects.ObjectKey
        Public JumpMod As ComponentData

        'hide modifer
        Public HideModKey As Objects.ObjectKey
        Public HideMod As ComponentData

        'psionics
        Public PsionicBodyModkey As Objects.ObjectKey
        Public PsionicBodyMod As ComponentData
        Public PsionicTalentModkey As Objects.ObjectKey
        Public PsionicTalentMod As ComponentData

        'monk abilities
        Public MonkACProgressionkey As Objects.ObjectKey
        Public MonkACProgressionMod As ComponentData

        Public MonkSpeedProgressionkey As Objects.ObjectKey
        Public MonkSpeedProgressionMod As ComponentData

        'Skill Ability Exchange Objects
        Public SkillAbilityExchanges As New Library

#End Region

#Region "Properties"

        'spell resistance
        Public ReadOnly Property SpellResistance(ByVal Level As Integer) As Integer
            Get
                Dim Temp As New ArrayList
                Dim Obj As Objects.ObjectData = Nothing
                Dim Component As ComponentData

                'Get the largest SetValue for this
                For Each Item As Library.LibraryData In SetValues.ItemData(References.SpellResistance)
                    Component = DirectCast(Item.Data, ComponentData)
                    If Component.ValidInfo.Valid And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then

                        Obj.Load(Component.Key)
                        Temp.Add(SetValueCalculator(Obj, Level))
                    End If
                Next

                'check for diamond soul ability
                Dim DiamondSoulClasses As New ArrayList
                For Each ItemData As Library.LibraryData In SystemAbilitiesLibrary.ItemData(References.DiamondSoul)
                    'get classes that grant this ability
                    If ItemData.LevelAcquired <= Level Then
                        Dim LevelStructure As Character.Level = Character.Levels(ItemData.LevelAcquired)
                        If Not DiamondSoulClasses.Contains(LevelStructure.ClassGuid) Then
                            DiamondSoulClasses.Add(LevelStructure.ClassGuid)
                        End If
                    End If
                Next

                'calculate and add to temp SR collection
                If DiamondSoulClasses.Count > 0 Then
                    Dim DimamondSoulSR As Integer = 10
                    For Each ClassKey As Objects.ObjectKey In DiamondSoulClasses
                        DimamondSoulSR += Character.HighestClassLevelAtLevel(ClassKey, Level).ClassLevel
                    Next
                    Temp.Add(DimamondSoulSR)
                End If

                Return CommonLogic.HighestInteger(Temp) + _Character.Modifiers.SpellResistance

            End Get
        End Property

        'power resistance
        Public ReadOnly Property PowerResistance(ByVal Level As Integer) As Integer
            Get
                Dim Temp As New ArrayList
                Dim Obj As New Objects.ObjectData
                Dim Component As ComponentData

                'Get the largest SetValue for this
                For Each Item As Library.LibraryData In SetValues.ItemData(References.PowerResistance)
                    Component = DirectCast(Item.Data, ComponentData)
                    If Component.ValidInfo.Valid And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then

                        Obj.Load(Component.Key)
                        Temp.Add(SetValueCalculator(Obj, Level))
                    End If
                Next

                Return CommonLogic.HighestInteger(Temp) + _Character.Modifiers.PowerResistance

            End Get
        End Property

        'damage resistance
        Public ReadOnly Property DamageResistance() As String
            Get
                Dim DmgRes As New DamageResistance
                Dim Obj As New Objects.ObjectData

                For Each Component As ComponentData In DamageResistances
                    If Component.ValidInfo.Valid Then
                        Obj.Load(Component.Key)
                        DmgRes.AddDamageResistance(Obj)
                    End If
                Next

                Return DmgRes.DisplayString
            End Get
        End Property

        'damage Reduction
        Public ReadOnly Property DamageReduction() As String
            Get
                Dim DmgRed As New DamageReduction
                Dim Obj As New Objects.ObjectData

                For Each Component As ComponentData In DamageReductions
                    If Component.ValidInfo.Valid Then
                        Obj.Load(Component.Key)
                        DmgRed.AddDamageReduction(Obj)
                    End If
                Next

                'check for armor material damage reductions
                If _Character.Inventory.ArmorWorn.IsNotEmpty Then
                    Dim Material As Objects.ObjectData
                    Material = _Character.Inventory.ArmorProperties.MaterialObject
                    If Not Material.IsEmpty Then
                        Select Case _Character.Inventory.ArmorProperties.ArmorTraining(True)
                            Case "Light"
                                DmgRed.AddDamageReduction(Material.ElementAsInteger("LightReduction"), Material.Element("DROvercomeByType"), Material.Element("DamageType"))
                            Case "Medium"
                                DmgRed.AddDamageReduction(Material.ElementAsInteger("MediumReduction"), Material.Element("DROvercomeByType"), Material.Element("DamageType"))
                            Case "Heavy"
                                DmgRed.AddDamageReduction(Material.ElementAsInteger("HeavyReduction"), Material.Element("DROvercomeByType"), Material.Element("DamageType"))
                        End Select
                    End If
                End If

                Return DmgRed.DisplayString
            End Get
        End Property

        'check system ability
        Public ReadOnly Property SystemAbilities(ByVal Key As Objects.ObjectKey, Optional ByVal Level As Integer = 1000) As Boolean
            Get
                If _SystemAbilities.ContainsKey(Key) Then
                    Dim Component As ComponentData

                    For Each Item As Library.LibraryData In _SystemAbilities.ItemData(Key)
                        Component = DirectCast(Item.Data, ComponentData)
                        If Component.ValidInfo.Valid And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then Return True
                    Next
                End If

                Return False
            End Get
        End Property

        'count of system abilities
        Public ReadOnly Property SystemAbilityCount(ByVal Key As Objects.ObjectKey, Optional ByVal Level As Integer = 1000) As Integer
            Get
                Dim Count As Integer = 0

                If _SystemAbilities.ContainsKey(Key) Then
                    Dim Components As ArrayList = _SystemAbilities.ItemData(Key)

                    Dim Component As ComponentData
                    For Each Item As Library.LibraryData In Components
                        Component = DirectCast(Item.Data, ComponentData)
                        If Component.ValidInfo.Valid And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then Count += 1
                    Next
                End If

                Return Count
            End Get
        End Property

        'system ability
        Public ReadOnly Property SystemAbilitiesLibrary() As Library
            Get
                Return _SystemAbilities
            End Get
        End Property

        'character
        Public ReadOnly Property Character() As Rules.Character
            Get
                Return _Character
            End Get
        End Property

#End Region

        'init for character
        Public Sub New(ByVal Character As Character)
            _Character = Character
        End Sub

        'load for character
        Public Sub LoadCharacter(Optional ByVal IgnoreShield As Boolean = False)
            'reset  
            BonusSpellSlots.Clear()
            DamageReductions.Clear()
            DamageResistances.Clear()
            Modifiers.Clear()
            SetValues.Clear()
            _SystemAbilities.Clear()
            Prerequisites.Clear()
            Preconditions.Clear()

            'Prereq look ups
            Feats.Clear()
            Features.Clear()

            'User Modifiers
            If _Character.CharacterLevel > 0 Then
                AnalyseComponent(_Character.CharacterObject.FirstChildOfType(Objects.ModifierFolderType).ObjectGUID, , , , True)
            End If

            'feats
            Dim Feat As Character.Feat
            For Each Item As Library.LibraryData In _Character.Feats.ItemData
                Feat = DirectCast(Item.Data, Character.Feat)
                If Not Feat.Disabled Then
                    Dim Override As Boolean = Feat.IgnorePrerequisites
                    If Feat.FocusGuid.Equals(Objects.ObjectKey.Empty) Then
                        Feats.Item(Feat.FeatGuid.ToString) = AnalyseComponent(Feat.FeatGuid, Feat.LevelTaken, , Override)
                    Else
                        Feats.Item(Feat.FeatGuid.ToString & Feat.FocusGuid.ToString) = AnalyseComponent(Feat.FeatGuid, Feat.FocusGuid, Feat.LevelTaken, , Override)
                    End If
                End If
            Next

            'features
            Dim Feature As Feature
            For Each item As Library.LibraryData In _Character.Features.Features.ItemData
                Feature = DirectCast(item.Data, Feature)
                If Not Feature.Disabled Then
                    Dim Override As Boolean = Feature.IgnorePrerequisites
                    If Feature.ProgressiveFeature = False Then
                        'AnalyseComponent(Feature.FeatureGuid, Feature.LevelTaken)
                        Features.Item(Feature.FeatureGuid.ToString) = AnalyseComponent(Feature.FeatureGuid, Feature.LevelTaken, , Override)
                    End If
                End If
            Next

            'calculated features
            Dim CalcFeature As CalculatedFeature
            Dim Position, Acquired, Lost As Integer

            For Each Item As Library.LibraryData In _Character.Features.CalculatedFeatures.ItemData
                CalcFeature = DirectCast(Item.Data, CalculatedFeature)

                For Each FeatureLink As FeatureLink In CalcFeature.ChainData.FeatureLinks

                    Acquired = -1
                    Lost = -1

                    For n As Integer = 0 To _Character.CharacterLevel
                        If CalcFeature.PositionsAtLevel.Count > n Then
                            Position = DirectCast(CalcFeature.PositionsAtLevel(n), Integer)
                            If Position = FeatureLink.Position And Acquired = -1 Then Acquired = n
                            If Position > FeatureLink.Position And Lost = -1 Then Lost = n - 1
                        End If
                    Next

                    If Lost = -1 Then Lost = 1000
                    If Acquired <> -1 Then
                        Features.Item(FeatureLink.FeatureGuid.ToString) = AnalyseComponent(FeatureLink.FeatureGuid, Acquired, Lost)
                    End If
                Next
            Next

            'favored enemies
            Dim EnemiesHashtable As New OneKeyList
            Dim MonsterBonusArray As ArrayList
            Dim Bonus As Integer
            Dim Name As String = ""

            For Each Item As Library.LibraryData In _Character.Choices.ItemData()
                Dim Choice As Character.CharacterChoice = DirectCast(Item.Data, Character.CharacterChoice)
                If Choice.Type = Character.ChoiceType.FavoredEnemy OrElse Choice.Type = Character.ChoiceType.FavoredEnemySingle Then
                    EnemiesHashtable.Add(Choice.DataGuid, Choice)
                End If
            Next

            For Each Key As Objects.ObjectKey In EnemiesHashtable.Keys
                Bonus = 0
                MonsterBonusArray = EnemiesHashtable.Item(Key)
                For Each EnemyChoice As Rules.Character.CharacterChoice In MonsterBonusArray
                    Bonus += EnemyChoice.Bonus
                    Name = EnemyChoice.Data
                Next
                AnalyseFavoredEnemy(Name, Bonus, Key)
            Next

            'calculate synergies
            For Each Synergy As Objects.ObjectData In Caches.SkillSynergies
                'check character has requisite ranks
                Dim Ranks As Integer = Synergy.ElementAsInteger("Ranks")
                Dim SkillKey As Objects.ObjectKey = Synergy.ParentGUID

                If _Character.SkillRanks.Contains(SkillKey) Then
                    If _Character.Skill(SkillKey).RankAtLevel(_Character.CharacterLevel) >= Ranks Then
                        'analyse the synergy itself (contains same elements as modifier)
                        _Character.Components.AnalyseSynergy(Synergy, _Character.CharacterLevel)
                    End If
                End If
            Next

            'race
            AnalyseComponent(_Character.RaceObject.ObjectGUID)

            'Damage Reduction, Damage Resistance & Spell Resistance
            Dim ClassLevel As New Objects.ObjectData
            Dim Level As Character.Level
            For i As Integer = 1 To _Character.CharacterLevel
                Level = _Character.Levels(i)
                ClassLevel.Load(Level.ClassLevelGuid)
                AnalyseComponent(ClassLevel.ObjectGUID, i)
            Next

            'armor worn
            If _Character.Inventory.ArmorWorn.IsNotEmpty Then
                Dim Armor As Objects.ObjectData = _Character.Inventory.ArmorProperties.Armor
                AnalyseArms(Armor)

                'add Armor modifier
                AddArmorShieldModifier(ArmorBonusType.Armor)
            End If

            'shield worn
            If Not IgnoreShield Then
                If _Character.Inventory.ShieldWorn.IsNotEmpty Then

                    Dim Shield As Objects.ObjectData = _Character.Inventory.ShieldProperties.Armor
                    AnalyseArms(Shield)

                    'add Shield Modifier
                    AddArmorShieldModifier(ArmorBonusType.Shield)
                End If
            End If

        End Sub

        'analyse the child components of the component being added
        Public Function AnalyseComponent(ByVal Guid As Objects.ObjectKey, Optional ByVal LevelAcquired As Integer = 0, Optional ByVal LevelLost As Integer = 1000, Optional ByVal Override As Boolean = False, Optional ByVal UserModifier As Boolean = False) As ValidData
            Dim Obj As New Objects.ObjectData
            Obj.Load(Guid)
            Return AnalyseComponent(Obj, Objects.ObjectKey.Empty, LevelAcquired, LevelLost, Override, UserModifier)
        End Function

        'analyse the child components of the component being added
        Public Function AnalyseComponent(ByVal Guid As Objects.ObjectKey, ByVal FocusGuid As Objects.ObjectKey, Optional ByVal LevelAcquired As Integer = 0, Optional ByVal LevelLost As Integer = 1000, Optional ByVal Override As Boolean = False, Optional ByVal UserModifier As Boolean = False) As ValidData
            Dim Obj As New Objects.ObjectData
            Obj.Load(Guid)
            Return AnalyseComponent(Obj, FocusGuid, LevelAcquired, LevelLost, Override, UserModifier)
        End Function

        'analyse the child components of the component being added
        Private Function AnalyseComponent(ByVal Obj As Objects.ObjectData, ByVal FocusGuid As Objects.ObjectKey, Optional ByVal LevelAcquired As Integer = 0, Optional ByVal LevelLost As Integer = 1000, Optional ByVal Override As Boolean = False, Optional ByVal UserModifier As Boolean = False) As ValidData
            Dim Component As New ComponentData
            Dim ReturnInfo As ValidData

            'New arrays for storing perequisites
            Component.ValidInfo.Prerequisites = New ArrayList
            ReturnInfo.Prerequisites = New ArrayList

            'New arrays for storing preconditions
            Component.ValidInfo.Preconditions = New ArrayList
            ReturnInfo.Preconditions = New ArrayList

            'Set to false
            ReturnInfo.Valid = False
            Component.ValidInfo.Valid = False

            'prereqs
            Dim Condition As ConditionData
            Dim PrerequisiteObjects As Objects.ObjectDataCollection = Nothing
            Select Case Obj.Type
                Case Objects.FeatDefinitionType
                    PrerequisiteObjects = Caches.FeatPrerequisites.ChildrenFast(Obj.ObjectGUID)
                Case Objects.FeatureDefinitionType
                    PrerequisiteObjects = Caches.FeaturePrerequisites.ChildrenFast(Obj.ObjectGUID)
            End Select

            If PrerequisiteObjects IsNot Nothing Then
                For Each Prerequisite As Objects.ObjectData In PrerequisiteObjects
                    Condition.MultipleFoci = False
                    Condition.Focus = Nothing

                    Dim PrerequisiteChildObjects As Objects.ObjectDataCollection
                    Select Case Obj.Type
                        Case Objects.FeatDefinitionType
                            PrerequisiteChildObjects = Caches.FeatPrerequisiteChildren.ChildrenFast(Prerequisite.ObjectGUID)
                        Case Objects.FeatureDefinitionType
                            PrerequisiteChildObjects = Caches.FeaturePrerequisiteChildren.ChildrenFast(Prerequisite.ObjectGUID)
                        Case Else
                            PrerequisiteChildObjects = Nothing
                    End Select

                    'Check how to store the prereq
                    If FocusGuid.IsNotEmpty Then
                        'If the prerequisite has a child type of "The Same ...." then we need to store multiple instances of it
                        For Each PrerequisiteChild As Objects.ObjectData In PrerequisiteChildObjects
                            If PrerequisiteChild.Element("PrerequisiteType") = "Feat" AndAlso (PrerequisiteChild.Element("Focus") = "The Same Weapon" OrElse PrerequisiteChild.Element("Focus") = "The Same Skill" OrElse PrerequisiteChild.Element("Focus") = "The Same School" OrElse PrerequisiteChild.Element("Focus") = "The Same Alignment" OrElse PrerequisiteChild.Element("Focus") = "The Same Specialization" OrElse PrerequisiteChild.Element("Focus") = "The Same Domain" OrElse PrerequisiteChild.Element("Focus") = "The Same Discipline") Then
                                Condition.MultipleFoci = True
                                Condition.Focus = FocusGuid
                            End If
                        Next
                    End If

                    'Add the prereq to the the general collection
                    If Condition.MultipleFoci Then
                        Condition.Condition = Prerequisite
                        Condition.Result = False
                        Prerequisites.Add(Prerequisite.ObjectGUID.ToString & FocusGuid.ToString, Condition)

                        If Not Override Then Component.ValidInfo.Prerequisites.Add(Prerequisite.ObjectGUID.ToString & FocusGuid.ToString)

                        'adds the prereq to the list to be returned
                        ReturnInfo.Prerequisites.Add(Prerequisite.ObjectGUID.ToString & FocusGuid.ToString)
                    Else
                        If Not Prerequisites.Contains(Prerequisite.ObjectGUID.ToString) Then
                            Condition.Condition = Prerequisite
                            Condition.Result = False
                            Prerequisites.Add(Prerequisite.ObjectGUID.ToString, Condition)

                        End If

                        'adds the prereq to the component
                        If Not Override Then Component.ValidInfo.Prerequisites.Add(Prerequisite.ObjectGUID.ToString)

                        'adds the prereq to the list to be returned
                        ReturnInfo.Prerequisites.Add(Prerequisite.ObjectGUID.ToString)
                    End If

                Next
            End If

            'system preconditions
            For Each Precondition As Objects.ObjectData In Obj.ChildrenOfType(Objects.SystemPreconditionType)
                If Not Preconditions.Contains(Precondition.ObjectGUID.ToString) Then
                    Condition.Condition = Precondition
                    Condition.Result = False
                    Preconditions.Add(Precondition.ObjectGUID.ToString, Condition)
                End If

                'add to component
                If Not Override Then Component.ValidInfo.Preconditions.Add(Precondition.ObjectGUID.ToString)

                'add to return
                ReturnInfo.Preconditions.Add(Precondition.ObjectGUID.ToString)
            Next

            'set source
            Component.SourceName = Obj.Name
            Component.SourceKey = Obj.ObjectGUID

            'Set user modifier flag
            If UserModifier Then
                Component.UserAdded = True
                Component.SourceName = "User"
            End If

            If Obj.Type = Objects.ItemType Then
                Component.ItemSource = True
            Else
                Component.ItemSource = False
            End If

            'acquired and lost
            Component.LevelAcquired = LevelAcquired
            Component.LevelLost = LevelLost

            'process each child object
            For Each Child As Objects.ObjectData In Obj.Children

                'this check is for the user modifiers folder, where the folder itself is being analysed
                If Child.Element("Disabled") = "Yes" Then
                    Component.UserModifierDisabled = True
                Else
                    Component.UserModifierDisabled = False
                End If

                Component.Key = Child.ObjectGUID

                Select Case Child.Type
                    Case Objects.BonusSpellSlotsType
                        'simple arraylist
                        Component.ComponentType = ComponentType.BonusSpellSlots
                        BonusSpellSlots.Add(Component)

                    Case Objects.DamageReductionType
                        'simple arraylist
                        Component.ComponentType = ComponentType.DamageReduction
                        DamageReductions.Add(Component)

                    Case Objects.DamageResistanceType
                        'damage resistances
                        Component.ComponentType = ComponentType.DamageResistance
                        DamageResistances.Add(Component)

                    Case Objects.ModifierType
                        'key is system element guid, subkey is modifier guid, data is null or focus guid
                        Component.ComponentType = ComponentType.Modifier

                        If Child.Element("FocusObject") = "Feat Focus" Then
                            Component.FocusGuid = FocusGuid

                            'if this is a natural attack type, we need the Attack Type string
                            'If Component.FocusGuid.Equals(References.NaturalAttackFocus) Then
                            '    Component.ExtraData = Obj.Element("Focus")                               
                            'End If

                        Else
                            Component.FocusGuid = Child.GetFKGuid("FocusObject")

                            'if this is a natural attack type, we need the Attack Type string
                            'If Component.FocusGuid.Equals(References.NaturalAttackFocus) Then
                            '    Component.ExtraData = Child.Element("FocusObject")
                            'End If

                        End If

                        Modifiers.AddItem(Child.GetFKGuid("SystemElement"), Component, LevelAcquired, LevelLost)
                        Component.ExtraData = Nothing

                    Case Objects.SkillAbilityExchangeType
                        'Skill Ability Exchange Type
                        Component.ComponentType = ComponentType.SkillAbilityExchange
                        Component.TransientObject = Child

                        'add to collection
                        SkillAbilityExchanges.AddItem(Child.GetFKGuid("Skill"), Component, LevelAcquired, LevelLost)
                        Component.TransientObject = Nothing

                    Case Objects.SetValueType
                        'SetValue Type 
                        Component.ComponentType = ComponentType.SetValue

                        'add to collection
                        SetValues.AddItem(Child.GetFKGuid("SystemElement"), Component, LevelAcquired, LevelLost)

                    Case Objects.SetAbilityType
                        'SetAbility Type
                        Component.ComponentType = ComponentType.SetAbility

                        'add to collection - Key is the ability score.
                        SetAbilities.AddItem(New Objects.ObjectKey(Child.Element("AbilityKey")), Component, LevelAcquired, LevelLost)

                    Case Objects.SystemAbilityType
                        'key is system ability key, data only contains level acquired
                        Component.ComponentType = ComponentType.SystemAbility
                        _SystemAbilities.AddItem(Child.GetFKGuid("SystemAbilityDefinition"), Component, LevelAcquired, LevelLost)

                End Select

            Next

            Return ReturnInfo

        End Function

        'analyse the child components of the component being added
        Public Sub AnalyseSynergy(ByVal Synergy As Objects.ObjectData, Optional ByVal LevelAcquired As Integer = 0)
            Dim Component As New ComponentData

            'if we are just calculating for max character level
            If LevelAcquired = 1000 Then LevelAcquired = 0

            Component.Key = Synergy.ObjectGUID
            Component.SourceName = Synergy.Parent.Name
            Component.ValidInfo.Valid = True
            Component.LevelAcquired = LevelAcquired
            Component.LevelLost = 1000
            Component.FocusGuid = Synergy.GetFKGuid("FocusObject")
            Component.ValidInfo.Prerequisites = New ArrayList
            Component.ValidInfo.Preconditions = New ArrayList
            Component.ComponentType = ComponentType.SkillSynergy

            Modifiers.AddItem(Synergy.GetFKGuid("SystemElement"), Component, LevelAcquired, 1000)
        End Sub

        'analyse the child components of the component being added
        Public Sub AnalyseFavoredEnemy(ByVal Name As String, ByVal Bonus As Integer, ByVal MonsterGuid As Objects.ObjectKey)
            Dim Component As New ComponentData
            Dim Modifier As New Objects.ObjectData
            Dim EnemyName As String
            Dim EnemyBonus As Integer
            Dim SkillObj As New Objects.ObjectData

            EnemyName = Name
            EnemyBonus = Bonus

            'skills that acquire modifiers from favored enemy
            Dim Skills As New ArrayList(5)
            Skills.Add(References.Listen)
            Skills.Add(References.Bluff)
            Skills.Add(References.Survival)
            Skills.Add(References.SenseMotive)
            Skills.Add(References.Spot)

            For Each SkillKey As Objects.ObjectKey In Skills

                SkillObj.Load(SkillKey)
                Modifier.Clear()

                Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                Modifier.Type = Objects.ModifierType
                Modifier.Element("SystemElement") = "Skill"
                Modifier.Element("ModifierType") = "Undefined"
                Modifier.Element("ModifierCategory") = "Normal Modifier"
                Modifier.Element("Modifier") = "+" & EnemyBonus.ToString
                Modifier.FKElement("FocusObject", SkillObj.Name, "Name", SkillObj.ObjectGUID)
                Modifier.Element("Limiter") = "vs. " & EnemyName
                Modifier.CreateDefaultRulePage()

                Component.Key = Modifier.ObjectGUID
                Component.SourceName = "Favored Enemy"
                Component.SourceKey = Objects.ObjectKey.Empty
                Component.ValidInfo.Valid = True
                Component.LevelAcquired = 0 'enemychoice.levelacquired is not accurate
                Component.LevelLost = 1000
                Component.FocusGuid = SkillObj.ObjectGUID
                Component.ValidInfo.Prerequisites = New ArrayList
                Component.ValidInfo.Preconditions = New ArrayList
                Component.ComponentType = ComponentType.FavoredEnemy
                Component.TransientObject = Modifier

                Modifiers.AddItem(References.Skill, Component, 0)
            Next

            'attack bonus
            Modifier.Clear()
            Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
            Modifier.Type = Objects.ModifierType
            Modifier.Element("SystemElement") = "Damage Roll vs. Monster Type"
            Modifier.Element("ModifierType") = "Undefined"
            Modifier.Element("ModifierCategory") = "Normal Modifier"
            Modifier.Element("Modifier") = "+" & EnemyBonus.ToString
            Modifier.FKElement("FocusObject", EnemyName, "Name", MonsterGuid)
            Modifier.Element("Limiter") = ""
            Modifier.CreateDefaultRulePage()

            Component.Key = Modifier.ObjectGUID
            Component.SourceName = "Favored Enemy"
            Component.SourceKey = Objects.ObjectKey.Empty
            Component.ValidInfo.Valid = True
            Component.LevelAcquired = 0 'enemychoice.levelacquired is not accurate
            Component.LevelLost = 1000
            Component.FocusGuid = Nothing
            Component.ValidInfo.Prerequisites = New ArrayList
            Component.ValidInfo.Preconditions = New ArrayList
            Component.ComponentType = ComponentType.FavoredEnemy
            Component.TransientObject = Modifier

            Modifiers.AddItem(References.DamageRollVsMonsterType, Component, 0)
            Modifier.Clear()

        End Sub

        'analyse a weapon, Armor or shield
        Public Sub AnalyseArms(ByVal Item As Objects.ObjectData)
            Select Case Item.Type

                Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                    AnalyseComponent(Item.ObjectGUID)

                Case Objects.SpecificArmorDefinitionType
                    AnalyseComponent(Item.ObjectGUID)
                    AnalyseComponent(Item.GetFKGuid("Armor"))

                    For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.SpecificArmorAbilityType)
                        Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("ArmorMagicAbility")
                        AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                    Next

                Case Objects.WeaponDefinitionType
                    AnalyseComponent(Item.ObjectGUID)

                Case Objects.SpecificWeaponDefinitionType
                    AnalyseComponent(Item.ObjectGUID)
                    AnalyseComponent(Item.GetFKGuid("Weapon"))

                    For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.SpecificWeaponAbilityType)
                        Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("WeaponMagicAbility")
                        AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                    Next

                    For Each Condition As Objects.ObjectData In Item.ChildrenOfType(Objects.ConditionType)
                        If ConditionMet(Condition) Then
                            AnalyseComponent(Condition, Objects.ObjectKey.Empty)
                            For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                                Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("WeaponMagicAbilityDefinition")
                                AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                            Next
                        End If
                    Next

                Case Objects.PsionicArmorDefinitionType
                    AnalyseComponent(Item.ObjectGUID)
                    AnalyseComponent(Item.GetFKGuid("Armor"))

                    For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.SpecificArmorAbilityType)
                        Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("ArmorAbility")
                        AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                    Next

                    For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.PsionicArmorAbilityType)
                        Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("ArmorAbility")
                        AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                    Next

                Case Objects.PsionicWeaponDefinitionType
                    AnalyseComponent(Item.ObjectGUID)
                    AnalyseComponent(Item.GetFKGuid("Weapon"))

                    For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.SpecificWeaponAbilityType)
                        Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("WeaponAbility")
                        AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                    Next

                    For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.PsionicWeaponAbilityType)
                        Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("WeaponAbility")
                        AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                    Next

                    For Each Condition As Objects.ObjectData In Item.ChildrenOfType(Objects.ConditionType)
                        If ConditionMet(Condition) Then
                            AnalyseComponent(Condition, Objects.ObjectKey.Empty)
                            For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                                Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("WeaponMagicAbilityDefinition")
                                AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                            Next
                            For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.PsionicWeaponAbilityConditionalType)
                                Dim AbilityDef As Objects.ObjectData = Ability.GetFKObject("WeaponAbility")
                                AnalyseComponent(AbilityDef, Objects.ObjectKey.Empty)
                            Next
                        End If
                    Next
            End Select
        End Sub

        'add Armor/Shield Mod
        Public Sub AddArmorShieldModifier(ByVal BonusType As ArmorBonusType)
            Dim Component As New ComponentData
            Dim Modifier As New Objects.ObjectData

            Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
            Modifier.Type = Objects.ModifierType
            Modifier.FKElement("SystemElement", "Armor Class", "Name", References.ArmourClass)
            Modifier.Element("ModifierCategory") = "Normal Modifier"

            Select Case BonusType
                Case ArmorBonusType.Armor
                    Modifier.Element("ModifierType") = "Armor"
                    Modifier.Element("Modifier") = "+" & _Character.Inventory.ArmorProperties.AC

                    Component.SourceName = _Character.Inventory.ArmorProperties.Armor.Name
                    Component.SourceKey = _Character.Inventory.ArmorProperties.Armor.ObjectGUID

                Case ArmorBonusType.Shield
                    Modifier.Element("ModifierType") = "Shield"
                    Modifier.Element("Modifier") = "+" & _Character.Inventory.ShieldProperties.AC

                    Component.SourceName = _Character.Inventory.ShieldProperties.Armor.Name
                    Component.SourceKey = _Character.Inventory.ShieldProperties.Armor.ObjectGUID
            End Select

            Modifier.CreateDefaultRulePage()

            Component.Key = Modifier.ObjectGUID
            Component.ValidInfo.Valid = True
            Component.LevelAcquired = 0
            Component.LevelLost = 1000
            Component.FocusGuid = Nothing
            Component.ValidInfo.Prerequisites = New ArrayList
            Component.ValidInfo.Preconditions = New ArrayList
            Component.ComponentType = ComponentType.Modifier
            Component.TransientObject = Modifier

            Modifiers.AddItem(References.ArmourClass, Component)

        End Sub

        'calculate jump modifier
        Public Sub CalculateJumpModifier()
            Try
                'remove existing mod if any
                If JumpModKey.IsNotEmpty Then
                    Modifiers.RemoveItemObject(References.Skill, JumpMod)
                End If

                Dim JumpModifier As Integer = Character.Skills.JumpModifier

                If JumpModifier = 0 Then
                    Exit Sub
                Else
                    'create revised mod
                    Dim Modifier As New Objects.ObjectData
                    Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                    JumpModKey = Modifier.ObjectGUID
                    Modifier.Type = Objects.ModifierType
                    Modifier.FKElement("SystemElement", "Skill", "Name", References.Skill)
                    Modifier.Element("ModifierCategory") = "Normal Modifier"
                    Modifier.Element("ModifierType") = "Undefined"
                    Modifier.Element("Modifier") = Rules.Formatting.FormatModifier(JumpModifier)
                    Dim Jump As New Objects.ObjectData
                    Jump.Load(References.Jump)
                    Modifier.FKElement("FocusObject", Jump.Name, "Name", References.Jump)
                    Modifier.CreateDefaultRulePage()

                    Dim Component As New ComponentData
                    Component.Key = Modifier.ObjectGUID
                    Component.ValidInfo.Valid = True
                    Component.LevelAcquired = 0
                    Component.LevelLost = 1000
                    Component.FocusGuid = References.Jump
                    Component.ValidInfo.Prerequisites = New ArrayList
                    Component.ValidInfo.Preconditions = New ArrayList
                    Component.ComponentType = ComponentType.Modifier
                    Component.TransientObject = Modifier
                    Component.SourceName = "Core Rules"
                    Component.SourceKey = References.Speed

                    Modifiers.AddItem(References.Skill, Component)
                    JumpMod = Component
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'adds the hide modifier if required
        Public Sub AddHideModifier()
            Try
                'remove existing mod if any
                If HideModKey.IsNotEmpty Then
                    Modifiers.RemoveItemObject(References.Skill, HideMod)
                End If

                Dim HideModifier As Integer = Character.Skills.HideModifier

                If HideModifier = 0 Then
                    Exit Sub
                Else

                    'create revised mod
                    Dim Modifier As New Objects.ObjectData
                    Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                    HideModKey = Modifier.ObjectGUID
                    Modifier.Type = Objects.ModifierType
                    Modifier.FKElement("SystemElement", "Skill", "Name", References.Skill)
                    Modifier.Element("ModifierCategory") = "Normal Modifier"
                    Modifier.Element("ModifierType") = "Size"
                    Modifier.Element("Modifier") = Rules.Formatting.FormatModifier(HideModifier)
                    Dim Hide As New Objects.ObjectData
                    Hide.Load(References.Hide)
                    Modifier.FKElement("FocusObject", Hide.Name, "Name", References.Hide)
                    Modifier.CreateDefaultRulePage()

                    Dim Component As New ComponentData
                    Component.Key = Modifier.ObjectGUID
                    Component.ValidInfo.Valid = True
                    Component.LevelAcquired = 0
                    Component.LevelLost = 1000
                    Component.FocusGuid = References.Hide
                    Component.ValidInfo.Prerequisites = New ArrayList
                    Component.ValidInfo.Preconditions = New ArrayList
                    Component.ComponentType = ComponentType.Modifier
                    Component.TransientObject = Modifier
                    Component.SourceName = "Core Rules"
                    Modifiers.AddItem(References.Skill, Component)
                    HideMod = Component
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'adds the hide modifier if required
        Public Sub AddPsionicBodyHitpointsModifier()
            Try
                'remove existing mod if any
                If PsionicBodyModkey.IsNotEmpty Then
                    Modifiers.RemoveItemObject(References.HitPointsBase, PsionicBodyMod)
                End If

                If Not Me.SystemAbilities(References.PsionicBody) Then
                    Exit Sub
                End If

                'count the psionic feats
                Dim PsionicFeats As Integer = 0
                Dim Feat As Character.Feat

                For Each Item As Library.LibraryData In _Character.Feats.ItemData
                    Feat = DirectCast(Item.Data, Character.Feat)
                    If Feat.FeatType = "Psionic" Then
                        PsionicFeats += 1
                    End If
                Next

                If PsionicFeats = 0 Then
                    Exit Sub
                Else
                    'create revised mod
                    Dim Modifier As New Objects.ObjectData
                    Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                    PsionicBodyModkey = Modifier.ObjectGUID
                    Modifier.Type = Objects.ModifierType
                    Modifier.FKElement("SystemElement", "Hit Points (Base)", "Name", References.HitPointsBase)
                    Modifier.Element("ModifierCategory") = "Normal Modifier"
                    Modifier.Element("ModifierType") = "Undefined"
                    Modifier.Element("Modifier") = Rules.Formatting.FormatModifier(PsionicFeats * 2)

                    Dim Component As New ComponentData
                    Component.Key = Modifier.ObjectGUID
                    Component.ValidInfo.Valid = True
                    Component.LevelAcquired = 0
                    Component.LevelLost = 1000
                    Component.ValidInfo.Prerequisites = New ArrayList
                    Component.ValidInfo.Preconditions = New ArrayList
                    Component.ComponentType = ComponentType.Modifier
                    Component.TransientObject = Modifier
                    Component.SourceName = "Psionic Body"
                    Modifiers.AddItem(References.HitPointsBase, Component)
                    PsionicBodyMod = Component
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'adds the psionic talent modifier if required
        Public Sub AddPsionicTalentPowerPointsModifier()
            Try
                'remove existing mod if any
                If PsionicTalentModkey.IsNotEmpty Then
                    Modifiers.RemoveItemObject(References.PowerPoints, PsionicTalentMod)
                End If

                'count the psionic talent components
                Dim PsionicTalents As Integer = 0
                PsionicTalents = Me.SystemAbilityCount(References.PsionicTalent)

                If PsionicTalents = 0 Then
                    Exit Sub
                Else
                    'create revised mod
                    Dim Modifier As New Objects.ObjectData
                    Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                    PsionicTalentModkey = Modifier.ObjectGUID
                    Modifier.Type = Objects.ModifierType
                    Modifier.FKElement("SystemElement", "Power Points", "Name", References.PowerPoints)
                    Modifier.Element("ModifierCategory") = "Normal Modifier"
                    Modifier.Element("ModifierType") = "Undefined"
                    Modifier.Element("Modifier") = Rules.Formatting.FormatModifier(PsionicTalents * (PsionicTalents + 3) \ 2)

                    Dim Component As New ComponentData
                    Component.Key = Modifier.ObjectGUID
                    Component.ValidInfo.Valid = True
                    Component.LevelAcquired = 0
                    Component.LevelLost = 1000
                    Component.ValidInfo.Prerequisites = New ArrayList
                    Component.ValidInfo.Preconditions = New ArrayList
                    Component.ComponentType = ComponentType.Modifier
                    Component.TransientObject = Modifier
                    Component.SourceName = "Psionic Talent"
                    Modifiers.AddItem(References.PowerPoints, Component)
                    PsionicTalentMod = Component
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'adds the monk AC progression modifier if required
        Public Sub AddMonkModifiers(ByVal LookForMonkBelt As Boolean)
            Try
                'remove existing mods if any
                If MonkACProgressionkey.IsNotEmpty Then
                    Modifiers.RemoveItemObject(References.PowerPoints, MonkACProgressionMod)
                End If

                If MonkSpeedProgressionkey.IsNotEmpty Then
                    Modifiers.RemoveItemObject(References.PowerPoints, MonkSpeedProgressionMod)
                End If

                Dim ACProgression, SpeedProgression As Integer
                ACProgression = _Character.ClassLevelCountFromClassesWhichGrantSystemAbility(References.ACBonusProgression)
                SpeedProgression = _Character.ClassLevelCountFromClassesWhichGrantSystemAbility(References.FastmovementProgression)

                'add monk belt bonus if required
                If LookForMonkBelt AndAlso Character.SystemPreconditions.Unarmored AndAlso Character.SystemPreconditions.Unencumbered Then
                    For Each InventoryItem As Objects.ObjectData In Character.Inventory.InventoryFolder.Children()
                        If InventoryItem.GetFKGuid("Item").Equals(References.MonkBelt) AndAlso InventoryItem.Element("Active") = "Yes" Then
                            ACProgression += 5
                        End If
                    Next
                End If

                Dim ACModifier, SpeedModifier, WisModifier As Integer
                If ACProgression > 0 Then
                    WisModifier = Rules.AbilityScores.AbilityScore(Character.CurrentLevel.WIS).Modifier
                End If
                ACModifier = Rules.MonkAbilities.MonkACBonus(ACProgression)
                SpeedModifier = Rules.MonkAbilities.MonkSpeedBonus(SpeedProgression)

                'add wisdom modifier to armor
                If WisModifier > 0 Then ACModifier += WisModifier

                If ACModifier > 0 Then
                    'create ac mod
                    Dim Modifier As New Objects.ObjectData
                    Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                    PsionicTalentModkey = Modifier.ObjectGUID
                    Modifier.Type = Objects.ModifierType
                    Modifier.FKElement("SystemElement", "Armor Class (inc. Touch/Flatfooted)", "Name", References.ArmorClassMonk)
                    Modifier.Element("ModifierCategory") = "Normal Modifier"
                    Modifier.Element("ModifierType") = "Undefined"
                    Modifier.Element("Modifier") = Rules.Formatting.FormatModifier(ACModifier)

                    Dim Component As New ComponentData
                    Component.Key = Modifier.ObjectGUID
                    Component.ValidInfo.Valid = True
                    Component.LevelAcquired = 0
                    Component.LevelLost = 1000
                    Component.ValidInfo.Prerequisites = New ArrayList
                    Component.ValidInfo.Preconditions = New ArrayList
                    Component.ComponentType = ComponentType.Modifier
                    Component.TransientObject = Modifier
                    Component.SourceName = "Monk AC Bonus"
                    Modifiers.AddItem(References.ArmorClassMonk, Component)
                    MonkACProgressionMod = Component
                End If

                If SpeedModifier > 0 Then
                    'create speed mod
                    Dim Modifier As New Objects.ObjectData
                    Modifier.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                    PsionicTalentModkey = Modifier.ObjectGUID
                    Modifier.Type = Objects.ModifierType
                    Modifier.FKElement("SystemElement", "Speed", "Name", References.Speed)
                    Modifier.Element("ModifierCategory") = "Normal Modifier"
                    Modifier.Element("ModifierType") = "Undefined"
                    Modifier.Element("Modifier") = Rules.Formatting.FormatModifier(SpeedModifier)

                    Dim Component As New ComponentData
                    Component.Key = Modifier.ObjectGUID
                    Component.ValidInfo.Valid = True
                    Component.LevelAcquired = 0
                    Component.LevelLost = 1000
                    Component.ValidInfo.Prerequisites = New ArrayList
                    Component.ValidInfo.Preconditions = New ArrayList
                    Component.ComponentType = ComponentType.Modifier
                    Component.TransientObject = Modifier
                    Component.SourceName = "Monk Fast Movement Bonus"
                    Modifiers.AddItem(References.Speed, Component)
                    MonkSpeedProgressionMod = Component
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'checks all the prereqs and preconditions to see if they are valid
        Public Sub CheckConditions_CalculateModifiers(ByVal AnalyseInventoryComponents As Boolean, Optional ByVal FixedLoad As Boolean = False)

            Dim NewComponentsBecameValid As Boolean = False
            Dim Condition As ConditionData

            'prereqs
            Dim Temp As New StringKeyHashtable

            For Each Item As DictionaryEntry In Prerequisites
                Condition = DirectCast(Item.Value, ConditionData)

                Dim PrereqChildren As Objects.ObjectDataCollection
                Select Case Condition.Condition.ObjectGUID.Database
                    Case XML.DBTypes.Feats
                        PrereqChildren = Caches.FeatPrerequisiteChildren.ChildrenFast(Condition.Condition.ObjectGUID)
                    Case XML.DBTypes.Features
                        PrereqChildren = Caches.FeaturePrerequisiteChildren.ChildrenFast(Condition.Condition.ObjectGUID)
                    Case Else
                        Throw New Exception("Condition with prerequisites is not a feat or feature.")
                End Select

                Select Case Condition.MultipleFoci
                    Case True
                        If _Character.Prerequisites.HasPrerequisite(Condition.Condition, _Character.CharacterLevel, PrereqChildren, True, Condition.Focus) Then Condition.Result = True Else Condition.Result = False

                    Case False
                        If _Character.Prerequisites.HasPrerequisite(Condition.Condition, _Character.CharacterLevel, PrereqChildren, True) Then Condition.Result = True Else Condition.Result = False
                End Select

                Temp.Add(CStr(Item.Key), Condition)
            Next

            For Each Item As DictionaryEntry In Temp
                Prerequisites(CStr(Item.Key)) = Item.Value
            Next

            'preconditions
            Temp.Clear()
            For Each Item As DictionaryEntry In Preconditions
                Condition = DirectCast(Item.Value, ConditionData)
                If _Character.SystemPreconditions.PreconditionMet(Condition.Condition) Then
                    Condition.Result = True
                Else
                    Condition.Result = False
                End If
                Temp.Add(CStr(Item.Key), Condition)
            Next

            For Each Item As DictionaryEntry In Temp
                Preconditions(CStr(Item.Key)) = Item.Value
            Next

            'modifiers
            NewComponentsBecameValid = NewComponentsBecameValid Or ScanLibrary(Modifiers)

            'feats
            NewComponentsBecameValid = NewComponentsBecameValid Or ScanTable(Feats)

            'features
            NewComponentsBecameValid = NewComponentsBecameValid Or ScanTable(Features)

            'system abilities
            ScanLibrary(_SystemAbilities)

            'damage resistance
            ScanArrayList(DamageResistances)

            'damage reduction
            ScanArrayList(DamageReductions)

            'set values (Spell Resistance)
            ScanLibrary(SetValues)

            'if something changed then recalculate
            If NewComponentsBecameValid Then

                AddPsionicBodyHitpointsModifier()
                AddPsionicTalentPowerPointsModifier()

                _Character.Modifiers.Calculate(AnalyseInventoryComponents)

                If Not FixedLoad Then
                    _Character.Inventory.Load = Rules.Encumberance.CurrentLoad(_Character.Size, _Character.CurrentLevel.STR, _Character.Inventory.Weight, _Character.Quadruped)
                End If
                CheckConditions_CalculateModifiers(AnalyseInventoryComponents, FixedLoad)
            End If
        End Sub

        'for checking conditions on weapons
        Public Function ConditionMet(ByVal Condition As Objects.ObjectData) As Boolean
            Dim ConditionMembers As Objects.ObjectDataCollection

            Select Case Condition.Element("Condition")
                Case Rules.Conditions.ByClass
                    ConditionMembers = Condition.ChildrenOfType(Objects.ConditionMemberType)

                    For Each ConditionMember As Objects.ObjectData In ConditionMembers
                        If _Character.CharacterClasses.Contains(ConditionMember.GetFKGuid("Class")) Then Return True
                    Next

                    Return False
                Case Rules.Conditions.FeatRequired
                    ConditionMembers = Condition.ChildrenOfType(Objects.ConditionMemberType)

                    For Each ConditionMember As Objects.ObjectData In ConditionMembers
                        If _Character.Feats.ContainsKey(conditionmember.GetFKGuid("Feat")) Then Return True
                    Next

                    Return False
                Case Rules.Conditions.ByRace
                    ConditionMembers = Condition.ChildrenOfType(Objects.ConditionMemberType)

                    For Each ConditionMember As Objects.ObjectData In ConditionMembers
                        If _Character.RaceObject.ObjectGUID.Equals(ConditionMember.GetFKGuid("Race")) Then Return True
                    Next

                    Return False
                Case Else
                    Return False
            End Select
        End Function

#Region "Collection Scanning Functions"

        'scan table
        Private Function ScanTable(ByRef Table As StringKeyHashtable) As Boolean
            Dim Change As Boolean = False
            Dim ValidResult As Boolean
            Dim Value As ValidData
            Dim Keys(Table.Count - 1) As Object

            Table.Keys.CopyTo(Keys, 0)
            For Each Key As Object In Keys

                Value = DirectCast(Table.Item(Key.ToString), ValidData)

                ValidResult = ScanConditions(Value)
                If Value.Valid <> ValidResult Then
                    Value.Valid = ValidResult
                    Table(Key.ToString) = Value
                    Change = True
                End If
            Next

            Return Change

        End Function

        'scan library
        Private Function ScanLibrary(ByRef Library As Library) As Boolean
            Dim Component As ComponentData
            Dim ValidResult As Boolean
            Dim Change As Boolean = False

            Dim TempList As ArrayList
            For Each Key As Objects.ObjectKey In Library.Keys
                TempList = Library.ItemStack(Key)
                For i As Integer = 0 To TempList.Count - 1
                    Component = DirectCast(DirectCast(TempList(i), Library.LibraryData).Data, ComponentData)
                    ValidResult = ScanConditions(Component.ValidInfo)

                    If Component.ValidInfo.Valid <> ValidResult Then
                        Component.ValidInfo.Valid = ValidResult
                        Library.SetItem(Key, Component, i)
                        Change = True
                    End If
                Next
            Next

            Return Change

        End Function

        'scan arraylist
        Private Function ScanArrayList(ByRef List As ArrayList) As Boolean
            Dim Component As ComponentData
            Dim ValidResult As Boolean
            Dim Change As Boolean = False

            If List.Count > 0 Then
                For n As Integer = 0 To List.Count - 1
                    Component = DirectCast(List.Item(n), ComponentData)
                    ValidResult = ScanConditions(Component.ValidInfo)

                    If Component.ValidInfo.Valid <> ValidResult Then
                        Component.ValidInfo.Valid = ValidResult
                        List.Item(n) = Component
                        Change = True
                    End If
                Next
            End If

            Return Change

        End Function

        'scan prereqs and precons
        Private Function ScanConditions(ByVal ValidData As ValidData) As Boolean
            Dim Valid As Boolean = True

            'scan prereqs
            For Each Prereq As String In ValidData.Prerequisites
                If DirectCast(Prerequisites.Item(Prereq), ConditionData).Result = False Then
                    Valid = False
                    Exit For
                End If
            Next

            'scan precons
            If Valid Then
                For Each Precon As String In ValidData.Preconditions
                    If DirectCast(Preconditions(Precon), ConditionData).Result = False Then
                        Valid = False
                        Exit For
                    End If
                Next
            End If

            Return Valid
        End Function

#End Region

        'clone
        Public Function Clone() As Components
            Dim Temp As New Components(_Character)

            Temp.BonusSpellSlots = CloneComponentDataArray(Me.BonusSpellSlots)
            Temp.DamageReductions = CloneComponentDataArray(Me.DamageReductions)
            Temp.DamageResistances = CloneComponentDataArray(Me.DamageResistances)
            Temp.Modifiers = DirectCast(Me.Modifiers.CloneComponentData, Library)
            Temp.SetValues = DirectCast(Me.SetValues.CloneComponentData, Library)
            Temp._SystemAbilities = DirectCast(Me._SystemAbilities.CloneComponentData, Library)
            Temp.Preconditions = DirectCast(Me.Preconditions.Clone, StringKeyHashtable)
            Temp.Prerequisites = DirectCast(Me.Prerequisites.Clone, StringKeyHashtable)

            Return Temp
        End Function

        'clone arraylist of component data
        Private Function CloneComponentDataArray(ByVal ComponentArray As ArrayList) As ArrayList
            Dim Temp As New ArrayList

            For Each ComponentData As ComponentData In ComponentArray
                Temp.Add(ComponentData.Clone)
            Next

            Return Temp
        End Function

        'feat validation table
        Public Function IsFeatValid(ByVal Key As String) As Boolean
            Dim ValidInfo As ValidData

            If Feats.ContainsKey(Key) Then
                ValidInfo = DirectCast(Feats(Key), ValidData)
                Return ValidInfo.Valid
            Else
                Debug.WriteLine("Not in table")
                Return False
            End If

        End Function

        'feature validation table
        Public Function IsFeatureValid(ByVal Key As String) As Boolean
            Dim ValidInfo As ValidData

            If Features.ContainsKey(Key) Then
                ValidInfo = DirectCast(Features(Key), ValidData)
                Return ValidInfo.Valid
            Else
                Return False
            End If
        End Function

        'calculates the value of a setvalue/complex modifier type object
        Public Function SetValueCalculator(ByVal Obj As Objects.ObjectData, ByVal Level As Integer) As Integer
            Try
                Dim AbilityScoreMod As Integer = 0
                Dim ClassLevelMod As Integer = 0

                If Obj.Type <> Objects.SetValueType And Obj.Type <> Objects.ModifierType Then
                    Throw New DevelopmentException("Not a SetValue/Modifier Object.")
                End If

                'Get AbilityScore Modifier
                If Obj.Element("AbilityMod") <> "" Then
                    AbilityScoreMod = Rules.AbilityScores.AbilityScore(_Character.AbilityScore(Obj.Element("AbilityMod"), Level)).Modifier
                End If

                'Get Class with the tag
                Dim TagString As String = Obj.Element("TagString")
                If TagString <> "" Then
                    For Each ClassObj As Objects.ObjectData In Character.CharactersClassObjects
                        If ClassObj.Element("Tags").IndexOf(TagString) >= 0 Then
                            ClassLevelMod += Character.HighestClassLevelAtLevel(ClassObj.ObjectGUID, Level).ClassLevel
                        End If
                    Next
                End If

                Return Obj.ElementAsInteger("BaseNumber") + (Obj.ElementAsInteger("PerLevel") * Level) + AbilityScoreMod + (ClassLevelMod * Obj.ElementAsInteger("TagNumber"))

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'for prerequisites
        Public Function HasInnateDamageReduction(ByVal Level As Integer) As Boolean

            For Each Component As ComponentData In DamageReductions
                If Component.ValidInfo.Valid AndAlso Component.LevelAcquired <= Level AndAlso Component.LevelLost > Level Then
                    Select Case Component.SourceKey.Database
                        Case XML.DBTypes.Classes, XML.DBTypes.Races, XML.DBTypes.Features, XML.DBTypes.Feats
                            Return True
                    End Select
                End If
            Next

            Return False

        End Function

    End Class

End Namespace