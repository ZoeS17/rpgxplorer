Option Strict On
Option Explicit On

Imports RPGXplorer.General
Imports RPGXplorer.Rules.ExperienceAndLevelling

Public Class LevellingUpWizard
    Implements IWizard

    'this class controls the wizard manager when levelling up

#Region "Member Variables"

    'common vars
    Private StepNo As Panel = Panel.Start
    Private SubstepNo As Integer = 0
    Private Character As Objects.ObjectData
    Private ExistingCharacter, NewCharacter As Rules.Character

    'used by steps to see if anything has changed
    Private OldFeatures, OldChoices, OldDomains, OldPsionicSpecializations, OldExtraClassSkills, OldPrestigeCasterChoices As Library

    'select class and levels vars
    Private CurrentLevel, LevelsToAdd As Integer

    'panels
    Private SelectClass As New SelectClassPanel
    Private AssignAbilityPoints As New AssignAbilityPoints
    Private RollHitPoints As New RollHitDicePanel
    Private PickLanguages As New PickLangaugesPanel
    Private FavoredEnemy As New FavoredEnemyPanel
    Private SchoolSpecial As New SelectSchoolSpecialization
    Private BonusDomains As New SelectBonusDomainsPanel
    Private PsionicSpecializations As New SelectPsionicSpecializationPanel
    Private BonusClassSkills As New SelectBonusClassSkillsPanel
    Private PrestigeSpellcasters As New ExistingSpellcasterProgression
    Private SelectFeatures As New SelectFeaturesPanel
    Private AddSpells As New AddSpellsKnown
    Private AddPowers As New AddPowersKnown
    Private AssignSkills As New AssignSkillPointsPanel
    Private SelectFeats As New SelectFeatsPanel

    'panel constants
    Private Enum Panel
        Start
        SelectClass
        AbilityPoints
        HitPoints
        Languages
        FavoredEnemy
        Specialisation
        BonusDomains
        PsionicSpecializations
        BonusClassSkills
        PrestigeSpellcasters
        Features
        Spells
        Powers
        Skills
        Feats
        Finish
    End Enum

    'flags
    Private AbilityPointsEarned As Boolean = False
    Private HitPointsPicked As Boolean = False
    Private SkillPointsPicked As Boolean = False
    Private SelectFeatureReqd As Boolean = False
    Private SelectBonusDomains As Boolean = False
    Private SelectPsionicSpecializations As Boolean = False
    Private SelectBonusClassSkills As Boolean = False
    Private SelectSpecialisation As Boolean = False
    Private SelectFavoredEnemy As Boolean = False
    Private SelectSpells As Boolean = False
    Private SelectPowers As Boolean = False
    Private SelectLanguages As Boolean = False
    Private SelectFeatsReqd As Boolean = False
    Private SelectPrestige As Boolean = False

    'flag arrays
    Private Const FlagsSize As Integer = 16
    Private ClassesChanged(FlagsSize) As Boolean
    Private AbilityPointsChanged(FlagsSize) As Boolean
    Private FeaturesChanged(FlagsSize) As Boolean
    Private SkillsChanged(FlagsSize) As Boolean
    Private BonusClassSkillsChanged(FlagsSize) As Boolean
    Private BonusDomainsChanged(FlagsSize) As Boolean
    Private PsionicSpecializationsChanged(FlagsSize) As Boolean
    Private SpecialistChanged(FlagsSize) As Boolean
    Private PrestigeCasterChanged(FlagsSize) As Boolean

    Private CharacterChanged As Boolean

    'From SelectClass
    Private CharacterLevelRanges As LevellingUpWizard.LevelRangeCollection

    'From RollHitDice
    Private HitPointRolls As ArrayList

    'From AssignAbilityPoints
    Private AbilityPointAssignments As New Hashtable

    'saving flag
    Private Saving As Boolean

    'flag for skipping class selection for mosnter which are not allowed to be advanced
    Private SmallHitDiceMode As Boolean
    Private HitDiceMultiplier As Double

#End Region

#Region "Structures"

    'structure to contain information on level ranges
    Structure LevelRange
        Public ClassTaken As Objects.ObjectData
        Public StartCharacterLevel As Integer
        Public StartClassLevel As Integer
        Public LevelsAdded As Integer
    End Structure

    'a collection of LevelRange Structures
    Structure LevelRangeCollection
        Public LevelRanges As Collections.ArrayList

        Public Sub Load(ByVal Levels As Collections.ArrayList)
            LevelRanges = Levels
        End Sub

        'Return the LevelRange structure which contains the given level
        Public Function GetLevelRange(ByVal Level As Integer) As LevelRange
            For Each temp As LevelRange In LevelRanges
                If (Level >= temp.StartCharacterLevel) And Level < (temp.StartCharacterLevel + temp.LevelsAdded) Then
                    Return temp
                End If
            Next
            Return Nothing
        End Function

        Public Shadows Function Equals(ByVal Comparison As LevelRangeCollection) As Boolean
            Dim A, B As LevelRange

            If Comparison.LevelRanges Is Nothing Xor LevelRanges Is Nothing Then Return False
            If Comparison.LevelRanges.Count <> LevelRanges.Count Then Return False

            For n As Integer = 0 To Comparison.LevelRanges.Count - 1
                A = DirectCast(Comparison.LevelRanges(n), LevelRange)
                If LevelRanges.Count > n Then B = DirectCast(LevelRanges(n), LevelRange) Else Return False

                'compare
                If Not A.ClassTaken.ObjectGUID.Equals(B.ClassTaken.ObjectGUID) Then Return False
                If Not A.StartCharacterLevel = B.StartCharacterLevel Then Return False
                If Not A.StartClassLevel = B.StartClassLevel Then Return False
                If Not A.LevelsAdded = B.LevelsAdded Then Return False
            Next

            Return True
        End Function

        Public Function Clone() As LevelRangeCollection
            Dim Temp As LevelRangeCollection

            Temp.LevelRanges = DirectCast(Me.LevelRanges.Clone, ArrayList)
            Return Temp
        End Function

    End Structure

    'structure to hold ability point assignment history
    Public Structure PointAssignment
        Public Level As Integer
        Public AbilityRaised As String
    End Structure

#End Region

#Region "Constructor"

    Public Sub New(ByVal Character As Objects.ObjectData)
        Me.Character = Character
        ExistingCharacter = CharacterManager.GetCharacter(Character.ObjectGUID)
        CurrentLevel = ExistingCharacter.CharacterLevel

        If ExistingCharacter.CharacterType = Rules.Character.CharacterObjectType.Monster AndAlso ExistingCharacter.CharacterLevel = 0 Then
            HitDiceMultiplier = ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")
            If HitDiceMultiplier < 1 Then
                Dim MonsterClass As Objects.ObjectData = ExistingCharacter.RaceObject.GetFKObject("MonsterType")
                Dim MonsterClassInfo As Rules.CharacterClass = Caches.GetCharacterClass(MonsterClass.ObjectGUID)

                'make sure we have class levels defined
                If MonsterClassInfo.LevelExists(1) Then
                    SmallHitDiceMode = True
                    StepNo = Panel.SelectClass

                    'construct level ranges manually
                    Dim ShortcutLevelRanges As LevellingUpWizard.LevelRangeCollection
                    Dim LevelRange As LevellingUpWizard.LevelRange

                    'get monster type class
                    LevelRange.ClassTaken = MonsterClass
                    LevelRange.LevelsAdded = 1
                    LevelRange.StartCharacterLevel = 1
                    LevelRange.StartClassLevel = 1

                    ShortcutLevelRanges.LevelRanges = New ArrayList
                    ShortcutLevelRanges.LevelRanges.Add(LevelRange)
                    CharacterLevelRanges = ShortcutLevelRanges
                End If
            End If
        End If

        InitFlagArrays()
    End Sub

#End Region

#Region "IWizard"

#If DEBUG Then
    Private CloneStart As New TimeSpan(DateTime.Now.Ticks)
#End If

    Public Function NextPanel() As IWizardPanel Implements IWizard.NextPanel
#If DEBUG Then
        Debug.WriteLine("LevellingUpWizard.NextStep = " & StepNo.ToString & " : " & New TimeSpan(DateTime.Now.Ticks).Subtract(CloneStart).TotalSeconds.ToString & " seconds.")
        CloneStart = New TimeSpan(DateTime.Now.Ticks)
#End If
        'action the current step and determine the next step
        Select Case StepNo
            Case Panel.Start
                StepNo = Panel.SelectClass
            Case Panel.SelectClass
                ClassesStep()
                StepNo = Panel.AbilityPoints
            Case Panel.AbilityPoints
                AbilityPointStep()
                StepNo = Panel.HitPoints
            Case Panel.HitPoints
                HitPointsStep()
                StepNo = Panel.Features
            Case Panel.Features
                FeaturesStep()
                StepNo = Panel.FavoredEnemy
            Case Panel.FavoredEnemy
                FavoredEnemyStep()
                StepNo = Panel.Specialisation
            Case Panel.Specialisation
                SpecialisationStep()
                StepNo = Panel.BonusDomains
            Case Panel.BonusDomains
                BonusDomainsStep()
                StepNo = Panel.PsionicSpecializations
            Case Panel.PsionicSpecializations
                PsionicSpecializationsStep()
                StepNo = Panel.BonusClassSkills
            Case Panel.BonusClassSkills
                BonusClassSkillsStep()
                StepNo = Panel.PrestigeSpellcasters
            Case Panel.PrestigeSpellcasters
                PrestigeStep()
                StepNo = Panel.Spells
            Case Panel.Spells
                SpellsStep()
                StepNo = Panel.Powers
            Case Panel.Powers
                PowersStep()
                StepNo = Panel.Skills
            Case Panel.Skills
                SkillsStep()
                StepNo = Panel.Languages
            Case Panel.Languages
                LanguagesStep()
                StepNo = Panel.Feats
            Case Panel.Feats
                StepNo = Panel.Finish
                RaiseEvent EnableFinish()
                Return New LevelUpFinishPanel
        End Select

        'recalculate the character if the step requires it
        If NewCharacter IsNot Nothing AndAlso CharacterChanged Then NewCharacter.Calculate()

        'get the next panel
        Select Case StepNo
            Case Panel.SelectClass

                'select class panel
                SelectClass.Init(ExistingCharacter)
                Return SelectClass

            Case Panel.AbilityPoints

                'ability points panel
                If AssignAbilityPoints.PanelRequired(ExistingCharacter, LevelsToAdd, CharacterLevelRanges) Then
                    AbilityPointsEarned = True
                    If Not AssignAbilityPoints.Initialised OrElse ClassesChanged(Panel.AbilityPoints) Then
                        AssignAbilityPoints.Init(ExistingCharacter, LevelsToAdd)
                    End If
                    Return AssignAbilityPoints
                Else
                    If AbilityPointAssignments.Count > 0 Then
                        AbilityPointAssignments = New Hashtable
                        SetFlags(True, AbilityPointsChanged)
                    End If
                    AbilityPointsEarned = False
                    Return NextPanel()
                End If

            Case Panel.HitPoints

                'hit points panel
                If RollHitPoints.PanelRequired(ExistingCharacter, NewCharacter, CharacterLevelRanges) Then
                    HitPointsPicked = True
                    If Not RollHitPoints.Initialised OrElse ClassesChanged(Panel.HitPoints) Then
                        RollHitPoints.Init(NewCharacter, ExistingCharacter, CharacterLevelRanges, LevelsToAdd, SmallHitDiceMode)
                        ClearMyFlags(Panel.HitPoints)
                    Else
                        RollHitPoints.Update()
                    End If
                    Return RollHitPoints
                Else
                    HitPointsPicked = False
                    Return NextPanel()
                End If

            Case Panel.Features

                'features
                OldFeatures = NewCharacter.Features.Features.Clone
                If Not SelectFeatures.Initialised OrElse ClassesChanged(Panel.Features) Then
                    If SelectFeatures.Init(NewCharacter) Then
                        SelectFeatureReqd = True
                        ClearMyFlags(Panel.Features)
                        Return SelectFeatures
                    Else
                        SelectFeatureReqd = False
                        Return NextPanel()
                    End If
                ElseIf SelectFeatureReqd Then
                    Return SelectFeatures
                Else
                    Return NextPanel()
                End If

            Case Panel.FavoredEnemy

                'favored enemy
                If FavoredEnemy.PanelRequired(NewCharacter, ExistingCharacter.CharacterLevel + 1) Then
                    SelectFavoredEnemy = True
                    If (Not FavoredEnemy.Initialised) OrElse ClassesChanged(Panel.FavoredEnemy) OrElse FeaturesChanged(Panel.FavoredEnemy) Then
                        FavoredEnemyReset()
                        FavoredEnemy.Init2(NewCharacter)
                        ClearMyFlags(Panel.FavoredEnemy)
                    End If
                    Return FavoredEnemy
                Else
                    FavoredEnemyReset()
                    SelectFavoredEnemy = False
                    Return NextPanel()
                End If

            Case Panel.Specialisation

                'arcane specialisation 
                OldChoices = NewCharacter.Choices.Clone()
                If SchoolSpecial.PanelRequired(NewCharacter) Then
                    SelectSpecialisation = True
                    If Not SchoolSpecial.Initialised OrElse ClassesChanged(Panel.Specialisation) Then
                        SchoolSpecial.Init(NewCharacter)
                        ClearMyFlags(Panel.Specialisation)
                    End If
                    Return SchoolSpecial
                Else
                    SelectSpecialisation = False
                    Return NextPanel()
                End If

            Case Panel.BonusDomains

                'bonus domains
                OldDomains = NewCharacter.Domains.Domains.Clone
                If BonusDomains.PanelRequired(NewCharacter) Then
                    SelectBonusDomains = True
                    If Not BonusDomains.Initialised Or ClassesChanged(Panel.BonusDomains) Then
                        BonusDomains.Init(NewCharacter)
                        ClearMyFlags(Panel.BonusDomains)
                    End If
                    Return BonusDomains
                Else
                    SelectBonusDomains = False
                    Return NextPanel()
                End If

            Case Panel.PsionicSpecializations

                'psionic specialisations
                OldPsionicSpecializations = NewCharacter.PsionicSpecializations.PsionicSpecializations.Clone
                If PsionicSpecializations.PanelRequired(NewCharacter) Then
                    SelectPsionicSpecializations = True
                    If Not PsionicSpecializations.Initialised Or ClassesChanged(Panel.PsionicSpecializations) Then
                        PsionicSpecializations.Init(NewCharacter)
                        ClearMyFlags(Panel.PsionicSpecializations)
                    End If
                    Return PsionicSpecializations
                Else
                    SelectPsionicSpecializations = False
                    Return NextPanel()
                End If

            Case Panel.BonusClassSkills

                'bonus class skills
                OldExtraClassSkills = NewCharacter.ExtraClassSkills.ExtraClassSkills.Clone
                If BonusClassSkills.PanelRequired(NewCharacter) Then
                    SelectBonusClassSkills = True
                    If Not BonusClassSkills.Initialised OrElse ClassesChanged(Panel.BonusClassSkills) OrElse BonusDomainsChanged(Panel.BonusClassSkills) Then
                        ClassSkillsReset()
                        BonusClassSkills.Init(NewCharacter)
                        ClearMyFlags(Panel.BonusClassSkills)
                    End If
                    Return BonusClassSkills
                Else
                    ClassSkillsReset()
                    SelectBonusClassSkills = False
                    Return NextPanel()
                End If

            Case Panel.PrestigeSpellcasters

                'prestige casters
                OldPrestigeCasterChoices = NewCharacter.PrestigeSpellcasterChoices.Clone
                If Not PrestigeSpellcasters.Initialised OrElse ClassesChanged(Panel.PrestigeSpellcasters) Then
                    If PrestigeSpellcasters.Init(NewCharacter, ExistingCharacter) Then
                        SelectPrestige = True
                        ClearMyFlags(Panel.PrestigeSpellcasters)
                        Return PrestigeSpellcasters
                    Else
                        SelectPrestige = False
                        Return NextPanel()
                    End If
                ElseIf SelectPrestige Then
                    Return PrestigeSpellcasters
                Else
                    Return NextPanel()
                End If

            Case Panel.Spells

                'select spells
                If Not AddSpells.Initialised OrElse ClassesChanged(Panel.Spells) OrElse AbilityPointsChanged(Panel.Spells) OrElse SpecialistChanged(Panel.Spells) OrElse BonusDomainsChanged(Panel.Spells) OrElse PrestigeCasterChanged(Panel.Spells) Then
                    SpellsReset()
                    If AddSpells.Init(NewCharacter) Then
                        SelectSpells = True
                        ClearMyFlags(Panel.Spells)
                        Return AddSpells
                    Else
                        SelectSpells = False
                        Return NextPanel()
                    End If
                Else
                    If SelectSpells Then
                        Return AddSpells
                    Else
                        Return NextPanel()
                    End If
                End If

            Case Panel.Powers

                'select powers
                If Not AddPowers.Initialised OrElse ClassesChanged(Panel.Powers) OrElse AbilityPointsChanged(Panel.Powers) OrElse SpecialistChanged(Panel.Powers) OrElse BonusDomainsChanged(Panel.Powers) OrElse PrestigeCasterChanged(Panel.Powers) Then
                    PowersReset()
                    If AddPowers.Init(NewCharacter) Then
                        SelectPowers = True
                        ClearMyFlags(Panel.Powers)
                        Return AddPowers
                    Else
                        SelectPowers = False
                        Return NextPanel()
                    End If
                Else
                    If SelectPowers Then
                        Return AddPowers
                    Else
                        Return NextPanel()
                    End If
                End If

            Case Panel.Skills

                'skills
                If AssignSkills.PanelRequired(NewCharacter) Then
                    SkillPointsPicked = True
                    If Not AssignSkills.Initialised OrElse ClassesChanged(Panel.Skills) OrElse AbilityPointsChanged(Panel.Skills) OrElse FeaturesChanged(Panel.Skills) OrElse BonusDomainsChanged(Panel.Skills) OrElse BonusClassSkillsChanged(Panel.Skills) Then
                        If ClassesChanged(Panel.Skills) OrElse AbilityPointsChanged(Panel.Skills) OrElse FeaturesChanged(Panel.Skills) OrElse BonusDomainsChanged(Panel.Skills) OrElse BonusClassSkillsChanged(Panel.Skills) Then
                            SkillsReset()
                        End If
                        NewCharacter.UpdateSkillMods()
                        AssignSkills.Init(NewCharacter, ExistingCharacter)
                        ClearMyFlags(Panel.Skills)
                    End If
                    Return AssignSkills
                Else
                    SkillPointsPicked = False
                    Return NextPanel()
                End If

            Case Panel.Languages

                'languages
                If PickLanguages.PanelRequired(NewCharacter, ExistingCharacter, CharacterLevelRanges) Then
                    SelectLanguages = True
                    If Not PickLanguages.Initialised OrElse (NewCharacter.FirstNewLevel = 1 AndAlso AbilityPointsChanged(Panel.Languages)) OrElse ClassesChanged(Panel.Languages) OrElse SkillsChanged(Panel.Languages) Then
                        'reset languages
                        NewCharacter.Languages = DirectCast(ExistingCharacter.Languages.Clone, ObjectHashtable)
                        'init panel
                        PickLanguages.Init2(NewCharacter)
                        ClearMyFlags(Panel.Languages)
                    End If
                    Return PickLanguages
                Else
                    'reset languages
                    NewCharacter.Languages = DirectCast(ExistingCharacter.Languages.Clone, ObjectHashtable)
                    SelectLanguages = False
                    Return NextPanel()
                End If

            Case Panel.Feats

                'feats               
                If Not SelectFeats.Initialised OrElse ClassesChanged(Panel.Feats) OrElse FeaturesChanged(Panel.Feats) OrElse BonusDomainsChanged(Panel.Feats) OrElse AbilityPointsChanged(Panel.Feats) OrElse SkillsChanged(Panel.Feats) Then
                    If ClassesChanged(Panel.Feats) OrElse FeaturesChanged(Panel.Feats) OrElse BonusDomainsChanged(Panel.Feats) OrElse AbilityPointsChanged(Panel.Feats) OrElse SkillsChanged(Panel.Feats) Then
                        FeatsReset()
                    End If
                    If SelectFeats.Init(NewCharacter, ExistingCharacter, LevelsToAdd) Then
                        SelectFeatsReqd = True
                        ClearMyFlags(Panel.Feats)
                        Return SelectFeats
                    Else
                        SelectFeatsReqd = False
                        Return NextPanel()
                    End If
                Else
                    If SelectFeatsReqd Then
                        Return SelectFeats
                    Else
                        Return NextPanel()
                    End If
                End If
        End Select
        Return Nothing
    End Function

    Public Function PreviousPanel() As IWizardPanel Implements IWizard.PreviousPanel

        'recalc character
        If Not NewCharacter Is Nothing Then
            NewCharacter.Calculate()
        End If

        'determine the previous step
        SetPreviousStep()

        'get the previous panel - sometimes clone the character if the panel in question needs to compare against the exitsing character
        Select Case StepNo
            Case Panel.SelectClass
                Return SelectClass
            Case Panel.AbilityPoints
                Return AssignAbilityPoints
            Case Panel.HitPoints
                Return RollHitPoints
            Case Panel.Features
                OldFeatures = NewCharacter.Features.Features.Clone
                Return Me.SelectFeatures
            Case Panel.FavoredEnemy
                Return Me.FavoredEnemy
            Case Panel.Specialisation
                OldChoices = NewCharacter.Choices.Clone
                Return Me.SchoolSpecial
            Case Panel.BonusDomains
                OldDomains = NewCharacter.Domains.Domains.Clone
                Return BonusDomains
            Case Panel.PsionicSpecializations
                OldPsionicSpecializations = NewCharacter.PsionicSpecializations.PsionicSpecializations.Clone
                Return PsionicSpecializations
            Case Panel.BonusClassSkills
                OldExtraClassSkills = NewCharacter.ExtraClassSkills.ExtraClassSkills.Clone
                Return BonusClassSkills
            Case Panel.PrestigeSpellcasters
                OldPrestigeCasterChoices = NewCharacter.PrestigeSpellcasterChoices.Clone
                Return Me.PrestigeSpellcasters
            Case Panel.Spells
                Return Me.AddSpells
            Case Panel.Powers
                Return Me.AddPowers
            Case Panel.Skills
                Return AssignSkills
            Case Panel.Languages
                Return Me.PickLanguages
            Case Panel.Feats
                Return SelectFeats
        End Select
        Return Nothing
    End Function

    ''' <summary>
    ''' Set the step no to the previous step.
    ''' </summary>
    Private Sub SetPreviousStep()
        Select Case StepNo
            Case Panel.AbilityPoints
                StepNo = Panel.SelectClass

            Case Panel.HitPoints
                If AbilityPointsEarned Then StepNo = Panel.AbilityPoints Else StepNo = Panel.SelectClass

            Case Panel.Features
                If HitPointsPicked Then
                    StepNo = Panel.HitPoints
                Else
                    If AbilityPointsEarned Then
                        StepNo = Panel.AbilityPoints
                    Else
                        StepNo = Panel.SelectClass
                    End If
                End If

            Case Panel.FavoredEnemy
                If SelectFeatureReqd Then
                    StepNo = Panel.Features
                Else
                    If HitPointsPicked Then
                        StepNo = Panel.HitPoints
                    Else
                        If AbilityPointsEarned Then
                            StepNo = Panel.AbilityPoints
                        Else
                            StepNo = Panel.SelectClass
                        End If
                    End If
                End If


            Case Panel.Specialisation
                If SelectFavoredEnemy Then
                    StepNo = Panel.FavoredEnemy
                Else
                    If SelectFeatureReqd Then
                        StepNo = Panel.Features
                    Else
                        If HitPointsPicked Then
                            StepNo = Panel.HitPoints
                        Else
                            If AbilityPointsEarned Then
                                StepNo = Panel.AbilityPoints
                            Else
                                StepNo = Panel.SelectClass
                            End If
                        End If
                    End If
                End If

            Case Panel.BonusDomains
                If SelectSpecialisation Then
                    StepNo = Panel.Specialisation
                Else
                    If SelectFavoredEnemy Then
                        StepNo = Panel.FavoredEnemy
                    Else
                        If SelectFeatureReqd Then
                            StepNo = Panel.Features
                        Else
                            If HitPointsPicked Then
                                StepNo = Panel.HitPoints
                            Else
                                If AbilityPointsEarned Then
                                    StepNo = Panel.AbilityPoints
                                Else
                                    StepNo = Panel.SelectClass
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.PsionicSpecializations
                If SelectBonusDomains Then
                    StepNo = Panel.BonusDomains
                Else
                    If SelectSpecialisation Then
                        StepNo = Panel.Specialisation
                    Else
                        If SelectFavoredEnemy Then
                            StepNo = Panel.FavoredEnemy
                        Else
                            If SelectFeatureReqd Then
                                StepNo = Panel.Features
                            Else
                                If HitPointsPicked Then
                                    StepNo = Panel.HitPoints
                                Else
                                    If AbilityPointsEarned Then
                                        StepNo = Panel.AbilityPoints
                                    Else
                                        StepNo = Panel.SelectClass
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.BonusClassSkills
                If SelectPsionicSpecializations Then
                    StepNo = Panel.PsionicSpecializations
                Else
                    If SelectBonusDomains Then
                        StepNo = Panel.BonusDomains
                    Else
                        If SelectSpecialisation Then
                            StepNo = Panel.Specialisation
                        Else
                            If SelectFavoredEnemy Then
                                StepNo = Panel.FavoredEnemy
                            Else
                                If SelectFeatureReqd Then
                                    StepNo = Panel.Features
                                Else
                                    If HitPointsPicked Then
                                        StepNo = Panel.HitPoints
                                    Else
                                        If AbilityPointsEarned Then
                                            StepNo = Panel.AbilityPoints
                                        Else
                                            StepNo = Panel.SelectClass
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.PrestigeSpellcasters
                If SelectBonusClassSkills Then
                    StepNo = Panel.BonusClassSkills
                Else
                    If SelectPsionicSpecializations Then
                        StepNo = Panel.PsionicSpecializations
                    Else
                        If SelectBonusDomains Then
                            StepNo = Panel.BonusDomains
                        Else
                            If SelectSpecialisation Then
                                StepNo = Panel.Specialisation
                            Else
                                If SelectFavoredEnemy Then
                                    StepNo = Panel.FavoredEnemy
                                Else
                                    If SelectFeatureReqd Then
                                        StepNo = Panel.Features
                                    Else
                                        If HitPointsPicked Then
                                            StepNo = Panel.HitPoints
                                        Else
                                            If AbilityPointsEarned Then
                                                StepNo = Panel.AbilityPoints
                                            Else
                                                StepNo = Panel.SelectClass
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.Spells
                If SelectPrestige Then
                    StepNo = Panel.PrestigeSpellcasters
                Else
                    If SelectBonusClassSkills Then
                        StepNo = Panel.BonusClassSkills
                    Else
                        If SelectPsionicSpecializations Then
                            StepNo = Panel.PsionicSpecializations
                        Else
                            If SelectBonusDomains Then
                                StepNo = Panel.BonusDomains
                            Else
                                If SelectSpecialisation Then
                                    StepNo = Panel.Specialisation
                                Else
                                    If SelectFavoredEnemy Then
                                        StepNo = Panel.FavoredEnemy
                                    Else
                                        If SelectFeatureReqd Then
                                            StepNo = Panel.Features
                                        Else
                                            If HitPointsPicked Then
                                                StepNo = Panel.HitPoints
                                            Else
                                                If AbilityPointsEarned Then
                                                    StepNo = Panel.AbilityPoints
                                                Else
                                                    StepNo = Panel.SelectClass
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.Powers
                If SelectSpells Then
                    StepNo = Panel.Spells
                Else
                    If SelectPrestige Then
                        StepNo = Panel.PrestigeSpellcasters
                    Else
                        If SelectBonusClassSkills Then
                            StepNo = Panel.BonusClassSkills
                        Else
                            If SelectPsionicSpecializations Then
                                StepNo = Panel.PsionicSpecializations
                            Else
                                If SelectBonusDomains Then
                                    StepNo = Panel.BonusDomains
                                Else
                                    If SelectSpecialisation Then
                                        StepNo = Panel.Specialisation
                                    Else
                                        If SelectFavoredEnemy Then
                                            StepNo = Panel.FavoredEnemy
                                        Else
                                            If SelectFeatureReqd Then
                                                StepNo = Panel.Features
                                            Else
                                                If HitPointsPicked Then
                                                    StepNo = Panel.HitPoints
                                                Else
                                                    If AbilityPointsEarned Then
                                                        StepNo = Panel.AbilityPoints
                                                    Else
                                                        StepNo = Panel.SelectClass
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.Skills
                If AssignSkills.Changed Then
                    SetFlags(True, SkillsChanged)
                    AssignSkills.Changed = False
                End If

                If SelectPowers Then
                    StepNo = Panel.Powers
                Else
                    If SelectSpells Then
                        StepNo = Panel.Spells
                    Else
                        If SelectPrestige Then
                            StepNo = Panel.PrestigeSpellcasters
                        Else
                            If SelectBonusClassSkills Then
                                StepNo = Panel.BonusClassSkills
                            Else
                                If SelectPsionicSpecializations Then
                                    StepNo = Panel.PsionicSpecializations
                                Else
                                    If SelectBonusDomains Then
                                        StepNo = Panel.BonusDomains
                                    Else
                                        If SelectSpecialisation Then
                                            StepNo = Panel.Specialisation
                                        Else
                                            If SelectFavoredEnemy Then
                                                StepNo = Panel.FavoredEnemy
                                            Else
                                                If SelectFeatureReqd Then
                                                    StepNo = Panel.Features
                                                Else
                                                    If HitPointsPicked Then
                                                        StepNo = Panel.HitPoints
                                                    Else
                                                        If AbilityPointsEarned Then
                                                            StepNo = Panel.AbilityPoints
                                                        Else
                                                            StepNo = Panel.SelectClass
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.Languages
                If SkillPointsPicked Then
                    StepNo = Panel.Skills
                Else
                    If SelectPowers Then
                        StepNo = Panel.Powers
                    Else
                        If SelectSpells Then
                            StepNo = Panel.Spells
                        Else
                            If SelectPrestige Then
                                StepNo = Panel.PrestigeSpellcasters
                            Else
                                If SelectBonusClassSkills Then
                                    StepNo = Panel.BonusClassSkills
                                Else
                                    If SelectPsionicSpecializations Then
                                        StepNo = Panel.PsionicSpecializations
                                    Else
                                        If SelectBonusDomains Then
                                            StepNo = Panel.BonusDomains
                                        Else
                                            If SelectSpecialisation Then
                                                StepNo = Panel.Specialisation
                                            Else
                                                If SelectFavoredEnemy Then
                                                    StepNo = Panel.FavoredEnemy
                                                Else
                                                    If SelectFeatureReqd Then
                                                        StepNo = Panel.Features
                                                    Else
                                                        If HitPointsPicked Then
                                                            StepNo = Panel.HitPoints
                                                        Else
                                                            If AbilityPointsEarned Then
                                                                StepNo = Panel.AbilityPoints
                                                            Else
                                                                StepNo = Panel.SelectClass
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.Feats
                If SelectLanguages Then
                    StepNo = Panel.Languages
                Else
                    If SkillPointsPicked Then
                        StepNo = Panel.Skills
                    Else
                        If SelectPowers Then
                            StepNo = Panel.Powers
                        Else
                            If SelectSpells Then
                                StepNo = Panel.Spells
                            Else
                                If SelectPrestige Then
                                    StepNo = Panel.PrestigeSpellcasters
                                Else
                                    If SelectBonusClassSkills Then
                                        StepNo = Panel.BonusClassSkills
                                    Else
                                        If SelectPsionicSpecializations Then
                                            StepNo = Panel.PsionicSpecializations
                                        Else
                                            If SelectBonusDomains Then
                                                StepNo = Panel.BonusDomains
                                            Else
                                                If SelectSpecialisation Then
                                                    StepNo = Panel.Specialisation
                                                Else
                                                    If SelectFavoredEnemy Then
                                                        StepNo = Panel.FavoredEnemy
                                                    Else
                                                        If SelectFeatureReqd Then
                                                            StepNo = Panel.Features
                                                        Else
                                                            If HitPointsPicked Then
                                                                StepNo = Panel.HitPoints
                                                            Else
                                                                If AbilityPointsEarned Then
                                                                    StepNo = Panel.AbilityPoints
                                                                Else
                                                                    StepNo = Panel.SelectClass
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Panel.Finish
                If SelectFeatsReqd Then
                    StepNo = Panel.Feats
                Else
                    If SelectLanguages Then
                        StepNo = Panel.Languages
                    Else
                        If SkillPointsPicked Then
                            StepNo = Panel.Skills
                        Else
                            If SelectPowers Then
                                StepNo = Panel.Powers
                            Else
                                If SelectSpells Then
                                    StepNo = Panel.Spells
                                Else
                                    If SelectPrestige Then
                                        StepNo = Panel.PrestigeSpellcasters
                                    Else
                                        If SelectBonusClassSkills Then
                                            StepNo = Panel.BonusClassSkills
                                        Else
                                            If SelectPsionicSpecializations Then
                                                StepNo = Panel.PsionicSpecializations
                                            Else
                                                If SelectBonusDomains Then
                                                    StepNo = Panel.BonusDomains
                                                Else
                                                    If SelectSpecialisation Then
                                                        StepNo = Panel.Specialisation
                                                    Else
                                                        If SelectFavoredEnemy Then
                                                            StepNo = Panel.FavoredEnemy
                                                        Else
                                                            If SelectFeatureReqd Then
                                                                StepNo = Panel.Features
                                                            Else
                                                                If HitPointsPicked Then
                                                                    StepNo = Panel.HitPoints
                                                                Else
                                                                    If AbilityPointsEarned Then
                                                                        StepNo = Panel.AbilityPoints
                                                                    Else
                                                                        StepNo = Panel.SelectClass
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Else
                Throw New Exceptions.DevelopmentException("Step No not handled for previous")

        End Select
    End Sub

    Public Sub Finish() Implements IWizard.Finish

        'save the character levels first
        For i As Integer = NewCharacter.FirstNewLevel To NewCharacter.CharacterLevel
            Dim Level As Rules.Character.Level
            Dim LevelObject As Objects.ObjectData

            Level = NewCharacter.Levels(i)
            LevelObject = Level.CreateCharacterLevel
            LevelObject.Save()
        Next        

        'domains
        NewCharacter.Domains.Save()

        'psionics
        NewCharacter.PsionicSpecializations.Save()

        'spells
        NewCharacter.Spells.Save()

        'powers
        NewCharacter.Powers.Save()

        'extra class skills
        NewCharacter.ExtraClassSkills.Save()

        'Skills
        Dim PreviousSkillsCollection As Objects.ObjectDataCollection
        Dim SkillRankObject As Objects.ObjectData

        PreviousSkillsCollection = NewCharacter.CharacterObject.FirstChildOfType(Objects.SkillFolderType).Children
        For Each Tempskill As Rules.Character.SkillRank In NewCharacter.SkillRanks.Values

            If PreviousSkillsCollection.ContainsFK("Skill", Tempskill.SkillGuid) Then
                SkillRankObject = PreviousSkillsCollection.Item("Skill", Tempskill.SkillGuid)

                SkillRankObject.Element("Rank") = (Tempskill.Ranks + Tempskill.NewRanks).ToString
                For Each SkillAssignment As DictionaryEntry In Tempskill.AssignedRanks
                    SkillRankObject.Element("Level" & CType(SkillAssignment.Key, Integer).ToString) = CType(SkillAssignment.Value, Double).ToString
                Next
            Else
                SkillRankObject = Tempskill.CreateObject(NewCharacter.CharacterObject)
                SkillRankObject.Save()
            End If
        Next

        'Choices
        Dim PreviousFavoredEnemyCollection As Objects.ObjectDataCollection
        Dim PreviousFavoredEnemySingleCollection As Objects.ObjectDataCollection

        Dim Choice As Rules.Character.CharacterChoice
        Dim ChoiceObject As Objects.ObjectData
        Dim ChoiceList As ArrayList
        Dim PreviousFound As Boolean

        PreviousFavoredEnemyCollection = NewCharacter.CharacterObject.FirstChildOfType(Objects.CharacterChoiceFolderType).ChildrenOfType(Objects.FavoredEnemyChoice)
        PreviousFavoredEnemySingleCollection = NewCharacter.CharacterObject.FirstChildOfType(Objects.CharacterChoiceFolderType).ChildrenOfType(Objects.FavoredEnemySingleChoice)

        ChoiceList = NewCharacter.Choices.ItemData
        ChoiceList.AddRange(NewCharacter.PrestigeSpellcasterChoices.ItemData)
        For Each LibraryChoiceItem As Library.LibraryData In ChoiceList
            Choice = DirectCast(LibraryChoiceItem.Data, Rules.Character.CharacterChoice)

            If Choice.Type = Rules.Character.ChoiceType.FavoredEnemy Then

                If PreviousFavoredEnemyCollection.ContainsFK("Monster", Choice.DataGuid) Then
                    ChoiceObject = PreviousFavoredEnemyCollection.Item("Monster", Choice.DataGuid)
                    ChoiceObject.Element("Bonus") = Choice.Bonus.ToString

                    For Each BonusAssignment As DictionaryEntry In Choice.LevelsAssigned
                        ChoiceObject.Element("Level" & CType(BonusAssignment.Key, Integer).ToString) = CType(BonusAssignment.Value, Double).ToString
                    Next

                    'update enemy name
                    ChoiceObject.Name = Rules.Formatting.FormatModifier(Choice.Bonus) & " vs. " & Choice.Data
                    ChoiceObject.Save()

                Else
                    ChoiceObject = Choice.CreateObject(NewCharacter)
                    ChoiceObject.Save()
                End If

            ElseIf Choice.Type = Rules.Character.ChoiceType.FavoredEnemySingle Then
                If PreviousFavoredEnemySingleCollection.ContainsFK("Monster", Choice.DataGuid) Then
                    PreviousFound = False
                    For Each TempObj As Objects.ObjectData In PreviousFavoredEnemySingleCollection.Items("Monster", Choice.DataGuid)
                        If TempObj.ElementAsInteger("LevelAcquired") = Choice.LevelAcquired Then
                            PreviousFound = True
                            ChoiceObject = TempObj
                            ChoiceObject.Element("Bonus") = Choice.Bonus.ToString

                            For Each BonusAssignment As DictionaryEntry In Choice.LevelsAssigned
                                ChoiceObject.Element("Level" & CType(BonusAssignment.Key, Integer).ToString) = CType(BonusAssignment.Value, Double).ToString
                            Next

                            'update enemy name
                            ChoiceObject.Name = Rules.Formatting.FormatModifier(Choice.Bonus) & " vs. " & Choice.Data
                            ChoiceObject.Save()
                            Exit For
                        End If
                    Next
                    If PreviousFound = False Then
                        ChoiceObject = Choice.CreateObject(NewCharacter)
                        ChoiceObject.Save()
                    End If
                Else
                    ChoiceObject = Choice.CreateObject(NewCharacter)
                    ChoiceObject.Save()
                End If
            Else
                If LibraryChoiceItem.LevelAcquired >= NewCharacter.FirstNewLevel OrElse (LibraryChoiceItem.LevelAcquired = 0 AndAlso NewCharacter.FirstNewLevel = 1) Then
                    ChoiceObject = Choice.CreateObject(NewCharacter)
                    ChoiceObject.Save()
                End If
            End If
        Next

        'Feats
        Dim NewFeats As New ArrayList
        Dim FeatObject As Objects.ObjectData
        Dim FeatDef As New Objects.ObjectData
        Dim Feat As Rules.Character.Feat

        For Each Item As Library.LibraryItem In NewCharacter.Feats.Index.Values
            Select Case Item.StorageType
                Case Library.StorageType.Stack
                    Dim Added As Boolean = False

                    For Each SubItem As Library.LibraryData In DirectCast(Item.Data, ArrayList)
                        'feats with no focus
                        Feat = DirectCast(SubItem.Data, Rules.Character.Feat)
                        FeatDef.Load(Feat.FeatGuid)

                        If Feat.LevelTaken > ExistingCharacter.CharacterLevel Then
                            'make sure character does not already have this feat in existing class
                            If ExistingCharacter.Feats.ContainsKey(Feat.FeatGuid) And FeatDef.Element("Stacks") = "" Then Exit For

                            'if it doesn't stack then only take once
                            If FeatDef.Element("Stacks") = "" And Added Then Exit For

                            NewFeats.Add(Feat)
                            Added = True
                        End If
                    Next
                Case Library.StorageType.Subkey
                    For Each SubItem As Library.LibraryData In DirectCast(Item.Data, StringKeyHashtable).Values
                        'feats with focus
                        Feat = DirectCast(SubItem.Data, Rules.Character.Feat)

                        'make sure character does not already have this feat in existing class
                        If Feat.FocusGuid.Equals(References.CustomFeatFocus) Then
                            If Not ExistingCharacter.Feats.ContainsSubkey(Feat.FeatGuid, Feat.FocusName) Then NewFeats.Add(Feat)
                        Else
                            If Not ExistingCharacter.Feats.ContainsSubkey(Feat.FeatGuid, Feat.FocusGuid) Then NewFeats.Add(Feat)
                        End If

                    Next
            End Select
        Next

        'write feats to db
        For Each Feat In NewFeats
            FeatObject = Feat.CreateObject(NewCharacter)
            FeatObject.Save()
        Next

        'Features
        Dim FeatureObject As Objects.ObjectData
        Dim PreviousFeatures As Objects.ObjectDataCollection = NewCharacter.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children

        For Each Libtemp As Library.LibraryData In NewCharacter.Features.Features.ItemData
            If Libtemp.LevelAcquired >= NewCharacter.FirstNewLevel Then
                FeatureObject = DirectCast(Libtemp.Data, Rules.Feature).CreateObject(NewCharacter)
                FeatureObject.Save()
            End If
        Next

        'Languages
        Dim PreviousLanguagesCollection As Objects.ObjectDataCollection
        Dim LanguageObject As Objects.ObjectData

        PreviousLanguagesCollection = NewCharacter.CharacterObject.FirstChildOfType(Objects.LanguageFolderType).Children
        For Each TempLanguage As Rules.Character.Language In NewCharacter.Languages.Values
            If Not PreviousLanguagesCollection.ContainsFK("Language", TempLanguage.LanguageGuid) Then
                LanguageObject = TempLanguage.CreateObject(NewCharacter)
                LanguageObject.Save()
            End If
        Next

        'Spell and Psi like abilities
        If NewCharacter.NewSpellLikeAbilities.Count > 0 Then
            NewCharacter.SpellLikeFolderSave()
            For Each Ability As Objects.ObjectData In NewCharacter.NewSpellLikeAbilities
                Ability.Save()
            Next
        End If

        If NewCharacter.NewPsiLikeAbilities.Count > 0 Then
            NewCharacter.PsiLikeFolderSave()
            For Each Ability As Objects.ObjectData In NewCharacter.NewPsiLikeAbilities
                Ability.Save()
            Next
        End If

        'if this character is familiar updates its skill ranks
        If NewCharacter.CharacterType = Rules.Character.CharacterObjectType.Familiar Then
            NewCharacter.UpdateFamiliarSkillRanks()
        End If

        'Update Character Manager
        CharacterManager.UpdateCharacter(NewCharacter)

        'if this character has any familiars update their ranks
        For Each FamiliarKey As Objects.ObjectKey In NewCharacter.Familiars
            CharacterManager.GetCharacter(FamiliarKey).UpdateFamiliarSkillRanks()
            CharacterManager.SetDirty(FamiliarKey)
        Next

        'update its TreeNode
        If General.MainExplorer.TreeNodes.ContainsKey(Character.ObjectGUID) Then
            Dim TreeNode As TreeNode = DirectCast(General.MainExplorer.TreeNodes.Item(Character.ObjectGUID), TreeNode)
            Dim NewTreeNode As TreeNode = General.MainExplorer.CompleteNodeFromObject(Character)
            Dim CurrentSuspend As Boolean = General.MainExplorer.SuspendEvents

            General.MainExplorer.TreeView.BeginUpdate()

            General.MainExplorer.SuspendEvents = True
            TreeNode.Remove()
            General.MainExplorer.SuspendEvents = CurrentSuspend

            General.MainExplorer.InsertNode(DirectCast(General.MainExplorer.TreeNodes(Character.ParentGUID), TreeNode), NewTreeNode)
            General.MainExplorer.TreeView.SelectedNode = NewTreeNode

            General.MainExplorer.TreeView.EndUpdate()
        End If

        'generate the memorized spells components if required
        NewCharacter.GenerateMemorizedSpells()

        'update first new level
        NewCharacter.FirstNewLevel = NewCharacter.CharacterLevel + 1

    End Sub

    Public Sub Cancel() Implements IWizard.Cancel
    End Sub

    Public Sub InitialUpdate() Implements IWizard.InitialUpdate
        'fixes the focus problem on the dice roller when starting on the HitDice Panel
        If Me.SmallHitDiceMode Then
            If RollHitPoints.Initialised And RollHitPoints.Visible Then
                RollHitPoints.DiceRoller.UpdateFocus()
            End If
        End If
    End Sub

    Public Event EnableFinish() Implements IWizard.EnableFinish

    Public Event DisableFinish() Implements IWizard.DisableFinish

#End Region

#Region "Steps"

    'step - process classes - Gets the level range objects for the SelectClass panel
    Private Sub ClassesStep()

        SetFlags(True, ClassesChanged)
        If SmallHitDiceMode Then
            LevelsToAdd = 1
        Else
            If Not CharacterLevelRanges.Equals(SelectClass.CharacterLevelRanges) Then
                CharacterLevelRanges = SelectClass.CharacterLevelRanges.Clone
                LevelsToAdd = SelectClass.LevelsToAdd
            End If
        End If
        NewCharacter = ExistingCharacter.Clone()

    End Sub

    'step - process ability points - This step actualy adds the new levels to the character
    Private Sub AbilityPointStep()
        'check to see if ability point assignments have changed
        Dim Existing, Current As PointAssignment

        For Each Item As DictionaryEntry In AssignAbilityPoints.PointAssignments
            Current = DirectCast(Item.Value, PointAssignment)
            If AbilityPointAssignments.Contains(Current.Level) Then
                Existing = DirectCast(AbilityPointAssignments.Item(Current.Level), PointAssignment)
                If Existing.Level <> Current.Level Then
                    SetFlags(True, AbilityPointsChanged)
                    Exit For
                End If
                If Existing.AbilityRaised <> Current.AbilityRaised Then
                    SetFlags(True, AbilityPointsChanged)
                    Exit For
                End If
            Else
                SetFlags(True, AbilityPointsChanged)
                Exit For
            End If
        Next

        AbilityPointAssignments = AssignAbilityPoints.PointAssignments

        'create character levels (if not already done)
        If ClassesChanged(Panel.AbilityPoints) Then

            'check to see if we've already created class levels, if so remove them
            If NewCharacter.CharacterLevel > ExistingCharacter.CharacterLevel Then
                NewCharacter = ExistingCharacter.Clone()
            End If

            Dim CharacterLevel As Integer
            Dim PointAssignment As LevellingUpWizard.PointAssignment
            Dim LevelNo, ClassStart As Integer
            Dim RangeClass As Objects.ObjectData
            Dim RangeClassInfo As Rules.CharacterClass

            'create the new character levels
            CharacterLevel = NewCharacter.CharacterLevel

            For Each LevelRange As LevelRange In CharacterLevelRanges.LevelRanges
                RangeClass = LevelRange.ClassTaken
                ClassStart = LevelRange.StartClassLevel
                RangeClassInfo = Caches.GetCharacterClass(RangeClass.ObjectGUID)

                'add in a level for each level in the current range
                For LevelNo = LevelRange.StartCharacterLevel To ((LevelRange.StartCharacterLevel + LevelRange.LevelsAdded) - 1)

                    If AssignAbilityPoints.PointAssignments.Contains(LevelNo) Then
                        PointAssignment = DirectCast(AssignAbilityPoints.PointAssignments.Item(LevelNo), LevellingUpWizard.PointAssignment)
                    Else
                        PointAssignment = Nothing
                    End If

                    NewCharacter.AddLevel(PointAssignment, RangeClassInfo, 0, ClassStart)
                    ClassStart += 1
                    CharacterLevel += 1
                Next
            Next

            NewCharacter.CharacterLevel = CharacterLevel
        Else

            'just update ability scores
            Dim PointAssignment As LevellingUpWizard.PointAssignment
            Dim LevelNo As Integer

            'reset ability scores to values at start of wizard then readjust
            For Each LevelRange As LevelRange In CharacterLevelRanges.LevelRanges
                For LevelNo = LevelRange.StartCharacterLevel To ((LevelRange.StartCharacterLevel + LevelRange.LevelsAdded) - 1)

                    'reset ability scores
                    Dim CurrentLevel, PreviousLevel As Rules.Character.Level
                    CurrentLevel = NewCharacter.Levels(levelno)
                    PreviousLevel = NewCharacter.Levels(levelno - 1)
                    CurrentLevel.STR = PreviousLevel.STR(True)
                    CurrentLevel.DEX = PreviousLevel.DEX(True)
                    CurrentLevel.CON = PreviousLevel.CON(True)
                    CurrentLevel.INT = PreviousLevel.INT(True)
                    CurrentLevel.WIS = PreviousLevel.WIS(True)
                    CurrentLevel.CHA = PreviousLevel.CHA(True)

                    'get point assignment
                    If AssignAbilityPoints.PointAssignments.Contains(LevelNo) Then
                        PointAssignment = DirectCast(AssignAbilityPoints.PointAssignments.Item(LevelNo), LevellingUpWizard.PointAssignment)
                        CurrentLevel.AbilityScore(pointassignment.AbilityRaised) = CurrentLevel.AbilityScore(pointassignment.AbilityRaised, True) + 1
                    Else
                        PointAssignment = Nothing
                    End If

                    NewCharacter.Levels(levelno) = CurrentLevel
                Next
            Next
        End If

        'always recalcualte here
        CharacterChanged = True
        ClearMyFlags(Panel.AbilityPoints)
    End Sub

    'step - process hit points - Updates the hit point tolls on the newly created character
    Private Sub HitPointsStep()
        Dim HitPointIndexCounter As Integer

        HitPointRolls = RollHitPoints.HitPointRolls
        HitPointIndexCounter = 0

        'update hit point rolls
        Select Case NewCharacter.CharacterType
            Case Rules.Character.CharacterObjectType.Character, Rules.Character.CharacterObjectType.Monster
                For Each LevelRange As LevelRange In CharacterLevelRanges.LevelRanges
                    For LevelNo As Integer = LevelRange.StartCharacterLevel To ((LevelRange.StartCharacterLevel + LevelRange.LevelsAdded) - 1)

                        'assign or update hit point roll
                        Dim Level As Rules.Character.Level = NewCharacter.Levels(LevelNo)

                        If (Not (HitPointRolls Is Nothing)) AndAlso ((HitPointRolls.Count - 1) >= HitPointIndexCounter) Then
                            If SmallHitDiceMode Then
                                Level.HitPointRoll = Math.Ceiling(DirectCast(HitPointRolls(HitPointIndexCounter), RollHitDicePanel.HPRoll).HPRoll * HitDiceMultiplier)
                            Else
                                Level.HitPointRoll = DirectCast(HitPointRolls(HitPointIndexCounter), RollHitDicePanel.HPRoll).HPRoll
                            End If
                        Else
                            Level.HitPointRoll = 0
                        End If

                        NewCharacter.Levels(LevelNo) = Level
                        HitPointIndexCounter += 1
                    Next
                Next
            Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount

                'reset current rolls
                For LevelNo As Integer = NewCharacter.FirstNewLevel To NewCharacter.CharacterLevel
                    Dim Level As Rules.Character.Level = NewCharacter.Levels(LevelNo)
                    Level.HitDice = 0
                    Level.HitPointRoll = 0

                    NewCharacter.Levels(LevelNo) = Level
                Next

                'add new rolls
                For Each Roll As RollHitDicePanel.HPRoll In HitPointRolls
                    'get the level it applies to
                    Dim Level As Rules.Character.Level = NewCharacter.Levels(Roll.Level)
                    Level.HitDice += 1
                    Level.HitPointRoll += Roll.HPRoll

                    NewCharacter.Levels(Roll.Level) = Level
                Next
        End Select
    End Sub

    'step - process features
    Private Sub FeaturesStep()
        If Not NewCharacter.Features.Features.Equals(OldFeatures) Then
            SetFlags(True, FeaturesChanged)
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - process favored enemy
    Private Sub FavoredEnemyStep()
        CharacterChanged = False
    End Sub

    'step - process specialisation
    Private Sub SpecialisationStep()
        Dim Changed As Boolean = False

        For Each Item As Library.LibraryData In NewCharacter.Choices.ItemData
            Dim Choice As Rules.Character.CharacterChoice = DirectCast(Item.Data, Rules.Character.CharacterChoice)
            If choice.Type = Rules.Character.ChoiceType.SacrificedSchool OrElse choice.Type = Rules.Character.ChoiceType.SpecailistSchool Then
                If Not OldChoices.ContainsSubkey(Choice.ClassGuid, Choice.DataGuid) Then
                    Changed = True
                    Exit For
                End If
            End If
        Next

        For Each Item As Library.LibraryData In OldChoices.ItemData
            Dim Choice As Rules.Character.CharacterChoice = DirectCast(Item.Data, Rules.Character.CharacterChoice)
            If Choice.Type = Rules.Character.ChoiceType.SacrificedSchool OrElse Choice.Type = Rules.Character.ChoiceType.SpecailistSchool Then
                If Not NewCharacter.Choices.ContainsSubkey(Choice.ClassGuid, Choice.DataGuid) Then
                    Changed = True
                    Exit For
                End If
            End If
        Next

        If Changed Then
            SetFlags(True, SpecialistChanged)
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - bonus domains
    Private Sub BonusDomainsStep()
        'check to see if bonus domain selection has changed
        If Not NewCharacter.Domains.Domains.Equals(OldDomains) Then
            SetFlags(True, BonusDomainsChanged)
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - psionic specializations
    Private Sub PsionicSpecializationsStep()
        'check to see if bonus domain selection has changed
        If Not NewCharacter.PsionicSpecializations.PsionicSpecializations.Equals(OldPsionicSpecializations) Then
            SetFlags(True, PsionicSpecializationsChanged)
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - bonus class skills
    Private Sub BonusClassSkillsStep()
        'check to see if bonus class skill selection has changed
        If Not NewCharacter.ExtraClassSkills.ExtraClassSkills.Equals(OldExtraClassSkills) Then
            SetFlags(True, BonusClassSkillsChanged)
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - prestige casters
    Private Sub PrestigeStep()
        'reset caster levels
        Dim TempLevel As Rules.Character.Level
        Dim PreviousLevel As New Rules.Character.Level
        For i As Integer = 1 To NewCharacter.CharacterLevel
            TempLevel = NewCharacter.Levels(i)

            'caster level
            Dim CasterLevelArray As Rules.Character.CasterLevel()

            If TempLevel.CharacterLevel = 1 Then
                TempLevel.CasterLevels = New Hashtable(5)

                'if we have a racial caster class - add this first
                Dim RaceCasterKey As Objects.ObjectKey = NewCharacter.RaceObject.GetFKGuid("CasterSource")
                If RaceCasterKey.IsNotEmpty Then
                    CasterLevelArray = Rules.CasterLevel.GetRacialCasterLevel(NewCharacter, RaceCasterKey)
                    If CasterLevelArray.Length > 0 Then
                        TempLevel.CasterLevels.Item(RaceCasterKey) = CasterLevelArray(0)
                    End If
                End If
            Else
                TempLevel.CasterLevels = DirectCast(PreviousLevel.CasterLevels.Clone, Hashtable) '???
            End If

            CasterLevelArray = Rules.CasterLevel.GetCasterLevel(NewCharacter, TempLevel)

            For Each CasterLevel As Rules.Character.CasterLevel In CasterLevelArray
                If TempLevel.CasterLevels.Contains(CasterLevel.ClassGuid) Then
                    TempLevel.CasterLevels(CasterLevel.ClassGuid) = CasterLevel
                Else
                    TempLevel.CasterLevels.Add(CasterLevel.ClassGuid, CasterLevel)
                End If
            Next

            PreviousLevel = TempLevel.Clone(TempLevel, NewCharacter)
            NewCharacter.Levels(i) = TempLevel
        Next

        If Not NewCharacter.PrestigeSpellcasterChoices.Equals(OldPrestigeCasterChoices) Then
            SetFlags(True, PrestigeCasterChanged)
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - process spells
    Private Sub SpellsStep()
        CharacterChanged = False
    End Sub

    'step - powers
    Private Sub PowersStep()
        CharacterChanged = False
    End Sub

    'step - process skills
    Private Sub SkillsStep()
        If AssignSkills.Changed Then
            SetFlags(True, SkillsChanged)
            AssignSkills.Changed = False
            CharacterChanged = True
        Else
            CharacterChanged = False
        End If
    End Sub

    'step - process languages
    Private Sub LanguagesStep()
        CharacterChanged = False
    End Sub

#End Region

#Region "Character Data Resets"

    'favored enemy
    Private Sub FavoredEnemyReset()
        Try
            'HACK - remove favored enemy choices 
            For Each Key As Objects.ObjectKey In NewCharacter.Choices.Keys
                If NewCharacter.Choices.StorageTypeOfKey(Key) = Library.StorageType.Stack Then
                    NewCharacter.Choices.RemoveItemStack(Key)
                End If
            Next

            'add existing ones
            For Each Key As Objects.ObjectKey In ExistingCharacter.Choices.Keys
                If ExistingCharacter.Choices.StorageTypeOfKey(key) = Library.StorageType.Stack Then
                    'get stack, clone it and add to new character
                    Dim Stack As Library.LibraryItem = DirectCast(ExistingCharacter.Choices.Index.Item(Key), Library.LibraryItem)
                    Dim NewStack As Library.LibraryItem
                    NewStack.StorageType = Library.StorageType.Stack
                    NewStack.Data = DirectCast(Stack.Data, ArrayList).Clone
                    NewCharacter.Choices.Index.Add(key, NewStack)
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'classskills reset
    Private Sub ClassSkillsReset()
        Try
            NewCharacter.ExtraClassSkills = ExistingCharacter.ExtraClassSkills.Clone(NewCharacter)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spells
    Private Sub SpellsReset()
        Try
            NewCharacter.Spells = ExistingCharacter.Spells.Clone(NewCharacter)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spells
    Private Sub PowersReset()
        Try
            NewCharacter.Powers = ExistingCharacter.Powers.Clone(NewCharacter)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'feats 
    Private Sub FeatsReset()
        Try
            NewCharacter.Feats = ExistingCharacter.Feats.Clone
            NewCharacter.Calculate()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'skills
    Private Sub SkillsReset()
        Try
            NewCharacter.SkillRanks = New ObjectHashtable

            For Each Item As DictionaryEntry In ExistingCharacter.SkillRanks
                Dim SkillRank As Rules.Character.SkillRank
                SkillRank = DirectCast(Item.Value, Rules.Character.SkillRank)
                SkillRank.AssignedRanks = DirectCast(SkillRank.AssignedRanks.Clone, Hashtable)
                NewCharacter.SkillRanks.Add(New Objects.ObjectKey(CStr(Item.Key)), SkillRank)
            Next

            NewCharacter.Calculate() 'recalc as we have to remove any old synergies

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Helper Functions"

    'get the con modifiers for added levels
    Private Function GetConModifiers() As Hashtable
        Dim ConMods As Hashtable
        Dim n, CON, ConMod As Integer
        Dim PointAssignment As LevellingUpWizard.PointAssignment

        ConMods = New Hashtable(LevelsToAdd)

        CON = Character.ElementAsInteger("CON")
        ConMod = 0

        'Go throught the new levels
        For n = CurrentLevel + 1 To CurrentLevel + LevelsToAdd

            'If This level has a Constitution AbilityPoint Increase then add 1 to the Constitution score
            If AbilityPointAssignments.Contains(n) Then
                PointAssignment = DirectCast(AbilityPointAssignments(n), LevellingUpWizard.PointAssignment)
                If PointAssignment.AbilityRaised = "CON" Then ConMod += 1
            End If

            'Add the Con Modifier to the HashTable, Key = CharacterLevel, Value = Constitution Modifier
            ConMods.Add(n, Rules.AbilityScores.AbilityScore(CON + ConMod).Modifier)

        Next
        Return ConMods
    End Function

    'init flag arrays
    Private Sub InitFlagArrays()
        SetFlags(False, ClassesChanged)
        SetFlags(False, AbilityPointsChanged)
        SetFlags(False, FeaturesChanged)
        SetFlags(False, SkillsChanged)
        SetFlags(False, BonusDomainsChanged)
        SetFlags(False, BonusClassSkillsChanged)
        SetFlags(False, SpecialistChanged)
        SetFlags(False, PrestigeCasterChanged)
    End Sub

    'set flag array values
    Private Sub SetFlags(ByVal State As Boolean, ByRef Flags() As Boolean)
        Dim n As Integer

        For n = 0 To FlagsSize
            Flags(n) = State
        Next
    End Sub

    'clear flags for a given panel
    Private Sub ClearMyFlags(ByVal StepNo As Integer)
        ClassesChanged(StepNo) = False
        AbilityPointsChanged(StepNo) = False
        FeaturesChanged(StepNo) = False
        SkillsChanged(StepNo) = False
        BonusDomainsChanged(StepNo) = False
        BonusClassSkillsChanged(StepNo) = False
        SpecialistChanged(StepNo) = False
        PrestigeCasterChanged(StepNo) = False
    End Sub

#End Region

End Class