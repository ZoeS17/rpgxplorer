Option Explicit On
Option Strict On

Imports RPGXplorer.Rules

Public Class Caches

#Region "Member Variables"

    Private Shared _Skills As Objects.ObjectDataCollection
    Private Shared _SkillSynergies As Objects.ObjectDataCollection
    Private Shared _SkillsDirty As Boolean = True

    Private Shared _Spells As ObjectHashtable
    Private Shared _SpellsDirty As Boolean = True

    Private Shared _Powers As ObjectHashtable
    Private Shared _PowersDirty As Boolean = True

    Private Shared _Features As ObjectHashtable
    Private Shared _FeatureChains As Rules.FeatureChainCollection
    Private Shared _FeaturePrereqCollection As Objects.ObjectDataCollection
    Private Shared _FeaturePrereqChildCollection As Objects.ObjectDataCollection
    Private Shared _FeaturesDirty As Boolean = True

    Private Shared _Feats As Objects.ObjectDataCollection
    Private Shared _FeatsNoSimpleWeapon As Objects.ObjectDataCollection
    Private Shared _FighterBonusFeats As Objects.ObjectDataCollection
    Private Shared _FeatPrereqCollection As Objects.ObjectDataCollection
    Private Shared _FeatPrereqChildCollection As Objects.ObjectDataCollection
    Private Shared _FeatsDirty As Boolean = True

    Private Shared _CharacterClasses As New ObjectHashtable

#End Region

#Region "Properties"

    'skill definition objects
    Public Shared ReadOnly Property Skills() As Objects.ObjectDataCollection
        Get
            If _SkillsDirty Then LoadSkills()
            Return _Skills
        End Get
    End Property

    'is the skill list loaded and up to date?
    Public Shared ReadOnly Property SkillsCurrent() As Boolean
        Get
            Return _Skills IsNot Nothing And _SkillsDirty = False
        End Get
    End Property

    'skill synergy objects
    Public Shared ReadOnly Property SkillSynergies() As Objects.ObjectDataCollection
        Get
            If _SkillsDirty Then LoadSkills()
            Return _SkillSynergies
        End Get
    End Property

    'is the synergy list loaded and up to date?
    Public Shared ReadOnly Property SkillSynergiesCurrent() As Boolean
        Get
            Return _SkillSynergies IsNot Nothing And _SkillsDirty = False
        End Get
    End Property

    'spell definition objects
    Public Shared ReadOnly Property Spells() As ObjectHashtable
        Get
            If _SpellsDirty Then
                _Spells = Objects.GetAllObjectsOfTypeOH(XML.DBTypes.Spells, Objects.SpellDefinitionType)
                _SpellsDirty = False
            End If
            Return _Spells
        End Get
    End Property

    'power definition objects
    Public Shared ReadOnly Property Powers() As ObjectHashtable
        Get
            If _PowersDirty Then
                _Powers = Objects.GetAllObjectsOfTypeOH(XML.DBTypes.Powers, Objects.PowerDefinitionType)
                _PowersDirty = False
            End If
            Return _Powers
        End Get
    End Property

    'feature definition objects
    Public Shared ReadOnly Property Features() As ObjectHashtable
        Get
            If _FeaturesDirty Then LoadFeatures()
            Return _Features
        End Get
    End Property

    'feature chains
    Public Shared ReadOnly Property FeatureChains() As Rules.FeatureChainCollection
        Get
            If _FeaturesDirty Then LoadFeatures()
            Return _FeatureChains
        End Get
    End Property

    'feature prereq objects
    Public Shared ReadOnly Property FeaturePrerequisites() As Objects.ObjectDataCollection
        Get
            If _FeaturesDirty Then LoadFeatures()
            Return _FeaturePrereqCollection
        End Get
    End Property

    'feature prereq children
    Public Shared ReadOnly Property FeaturePrerequisiteChildren() As Objects.ObjectDataCollection
        Get
            If _FeaturesDirty Then LoadFeatures()
            Return _FeaturePrereqChildCollection
        End Get
    End Property

    'feats
    Public Shared ReadOnly Property Feats() As Objects.ObjectDataCollection
        Get
            If _FeatsDirty Then LoadFeats()
            Return _Feats
        End Get
    End Property

    'feats no simple weapon
    Public Shared ReadOnly Property FeatsNoSimpleWeapon() As Objects.ObjectDataCollection
        Get
            If _FeatsDirty Then LoadFeats()
            Return _FeatsNoSimpleWeapon
        End Get
    End Property

    'fighter bonus feats
    Public Shared ReadOnly Property FighterBonusFeats() As Objects.ObjectDataCollection
        Get
            If _FeatsDirty Then LoadFeats()
            Return _FighterBonusFeats
        End Get
    End Property

    'feat prereq objects
    Public Shared ReadOnly Property FeatPrerequisites() As Objects.ObjectDataCollection
        Get
            If _FeatsDirty Then LoadFeats()
            Return _FeatPrereqCollection
        End Get
    End Property

    'feat prereq children
    Public Shared ReadOnly Property FeatPrerequisiteChildren() As Objects.ObjectDataCollection
        Get
            If _FeatsDirty Then LoadFeats()
            Return _FeatPrereqChildCollection
        End Get
    End Property

#End Region

#Region "Methods"

    'set all dirty
    Public Shared Sub SetAllDirty()
        _SkillsDirty = True
        _SpellsDirty = True
        _PowersDirty = True
        _FeaturesDirty = True
        _FeatsDirty = True
        _CharacterClasses = New ObjectHashtable
    End Sub

    'set spells dirty
    Public Shared Sub SetSpellsDirty()
        _SpellsDirty = True
    End Sub

    'set powers dirty
    Public Shared Sub SetPowersDirty()
        _PowersDirty = True
    End Sub

    'set feats dirty
    Public Shared Sub SetFeatsDirty()
        _FeatsDirty = True
    End Sub

    'set features dirty
    Public Shared Sub SetFeaturesDirty()
        _FeaturesDirty = True
    End Sub

    'set skills dirty
    Public Shared Sub SetSkillsDirty()
        _SkillsDirty = True
    End Sub

    'set classes dirty
    Public Shared Sub SetClassesDirty()
        _CharacterClasses = New ObjectHashtable
    End Sub

    'load skills
    Private Shared Sub LoadSkills()
        _Skills = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillDefinitionType)
        _SkillSynergies = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillSynergyType)
        _SkillsDirty = False
    End Sub

    'add a spell
    Public Shared Sub AddSpell(ByVal Spell As Objects.ObjectData)
        If _Spells IsNot Nothing AndAlso Not _SpellsDirty Then _Spells.Add(Spell.ObjectGUID, Spell)
    End Sub

    'replace a spell
    Public Shared Sub ReplaceSpell(ByVal Spell As Objects.ObjectData)
        If _Spells IsNot Nothing AndAlso Not _SpellsDirty Then _Spells.Item(Spell.ObjectGUID) = Spell
    End Sub

    'remove a spell
    Public Shared Sub RemoveSpell(ByVal Key As Objects.ObjectKey)
        If _Spells IsNot Nothing AndAlso Not _SpellsDirty Then _Spells.Remove(Key)
    End Sub

    'remove a power
    Public Shared Sub AddPower(ByVal Power As Objects.ObjectData)
        If _Powers IsNot Nothing AndAlso Not _PowersDirty Then _Powers.Add(Power.ObjectGUID, Power)
    End Sub

    'replace a power
    Public Shared Sub ReplacePower(ByVal Power As Objects.ObjectData)
        If _Powers IsNot Nothing AndAlso Not _PowersDirty Then _Powers.Item(Power.ObjectGUID) = Power
    End Sub

    'remove a power
    Public Shared Sub RemovePower(ByVal Key As Objects.ObjectKey)
        If _Powers IsNot Nothing AndAlso Not _PowersDirty Then _Powers.Remove(Key)
    End Sub

    'load all feat caches
    Private Shared Sub LoadFeats()
        _Feats = Objects.GetAllObjectsOfType(XML.DBTypes.Feats, Objects.FeatDefinitionType)
        _FeatsNoSimpleWeapon = _Feats.Clone
        _FeatsNoSimpleWeapon.Remove(References.SimpleWeaponProficiency)
        _FighterBonusFeats = Objects.GetObjectsByXPath(XML.DBTypes.Feats, "//RPGXplorerDatabase/RPGXplorerObject[Type='Feat Definition' and FighterBonusFeat='Yes']")
        _FighterBonusFeats.Remove(References.SimpleWeaponProficiency)
        _FeatPrereqCollection = Objects.GetObjectsByXPath(XML.DBTypes.Feats, "//RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PrerequisiteType & "']")
        _FeatPrereqCollection.ConstructParentChildListFast()
        _FeatPrereqChildCollection = Objects.GetObjectsByXPath(XML.DBTypes.Feats, "//RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PrerequisiteChildType & "']")
        _FeatPrereqChildCollection.ConstructParentChildListFast()
        _FeatsDirty = False
    End Sub

    'load features and work out the chains of progressive features
    Private Shared Sub LoadFeatures()
        Dim Links As New ObjectHashtable
        Dim Chains As New ObjectHashtable
        Dim FeatureObject As Objects.ObjectData
        Dim LinkItem, PreviousItem As FeatureLink

        _Features = Objects.GetAllObjectsOfTypeOH(XML.DBTypes.Features, Objects.FeatureDefinitionType)

        'prereqs
        _FeaturePrereqCollection = Objects.GetObjectsByXPath(XML.DBTypes.Features, "//RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PrerequisiteType & "']")
        _FeaturePrereqCollection.ConstructParentChildListFast()
        _FeaturePrereqChildCollection = Objects.GetObjectsByXPath(XML.DBTypes.Features, "//RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PrerequisiteChildType & "']")
        _FeaturePrereqChildCollection.ConstructParentChildListFast()

        'Generate all the links
        For Each FeatureObject In _Features.Values

            'Check to see if this feature replaces another
            If FeatureObject.Element("Replaces") <> "" Then

                'Get or create a link for this feature
                LinkItem = DirectCast(Links(FeatureObject.ObjectGUID), FeatureLink)
                If LinkItem Is Nothing Then
                    LinkItem = New FeatureLink(FeatureObject.Name, FeatureObject.ObjectGUID)
                    Links(LinkItem.FeatureGuid) = LinkItem
                End If

                'Get or create a link for the replaced feature
                PreviousItem = DirectCast(Links(FeatureObject.GetFKGuid("Replaces")), FeatureLink)
                If PreviousItem Is Nothing Then
                    PreviousItem = New FeatureLink(FeatureObject.Element("Replaces"), FeatureObject.GetFKGuid("Replaces"))
                    Links(PreviousItem.FeatureGuid) = PreviousItem
                End If

                'Update the links between them
                LinkItem.PreviousFeature = PreviousItem
                PreviousItem.NextFeature = LinkItem

            End If
        Next

        'Find the Start links and follow the chains setting the positions
        For Each LinkItem In Links.Values

            'If the link has no previous, it starts a chain
            If LinkItem.PreviousFeature Is Nothing Then

                Dim NextItem As FeatureLink
                Dim PositionCounter As Integer = 1
                Dim ChainGuid As Objects.ObjectKey = Objects.ObjectKey.NewGuid(0)
                Dim TempObject As Objects.ObjectData
                Dim Chain As FeatureChain

                'Set the first object
                LinkItem.Position = PositionCounter
                LinkItem.ChainGUID = ChainGuid
                TempObject = DirectCast(_Features.Item(LinkItem.FeatureGuid), Objects.ObjectData)

                'Set the Chain
                If TempObject.Element("Stacks") = "Yes" Then
                    Chain = New FeatureChain(ChainGuid, FeatureChainTypes.StackAcrossClasses)
                ElseIf TempObject.Element("CanBeTakenMultipleTimes") = "Yes" Then
                    Chain = New FeatureChain(ChainGuid, FeatureChainTypes.HighestPerClass_Multiples)
                Else
                    Chain = New FeatureChain(ChainGuid, FeatureChainTypes.HighestOverall_NoMultiples)
                End If

                Chain.FeatureLinks.Add(LinkItem)

                'Add the rest of the chain
                NextItem = LinkItem.NextFeature
                While Not NextItem Is Nothing
                    PositionCounter += 1
                    NextItem.Position = PositionCounter
                    NextItem.ChainGUID = ChainGuid
                    Chain.FeatureLinks.Add(NextItem)

                    NextItem = NextItem.NextFeature

                End While

                Chains.Add(Chain.ChainGuid, Chain)

            End If
        Next

        _FeatureChains = New FeatureChainCollection(Links, Chains)
        _FeaturesDirty = False

    End Sub

    'remove a feat prereq and its children
    Public Shared Sub RemoveFeatPrerequisite(ByVal Key As Objects.ObjectKey)
        If _FeatPrereqCollection IsNot Nothing AndAlso Not _FeatsDirty Then
            _FeatPrereqCollection.Remove(Key)
            _FeatPrereqChildCollection.RemoveList(_FeatPrereqChildCollection.ChildrenFast(Key))
        End If
    End Sub

    'remove a feature prereq and its children
    Public Shared Sub RemoveFeaturePrerequisite(ByVal Key As Objects.ObjectKey)
        If _FeaturePrereqCollection IsNot Nothing AndAlso Not _FeaturesDirty Then
            _FeaturePrereqCollection.Remove(Key)
            _FeaturePrereqChildCollection.RemoveList(_FeaturePrereqChildCollection.ChildrenFast(Key))
        End If
    End Sub

    'add a class to the class list
    Public Shared Sub SetCharacterClass(ByVal CharacterClass As CharacterClass)
        If Not _CharacterClasses.ContainsKey(CharacterClass.ClassObj.ObjectGUID) Then _CharacterClasses.Add(CharacterClass.ClassObj.ObjectGUID, CharacterClass)
    End Sub

    'get a class
    Public Shared Function GetCharacterClass(ByVal Key As Objects.ObjectKey) As CharacterClass
        If Not _CharacterClasses.ContainsKey(Key) Then
            Dim CharacterClass As New CharacterClass()
            CharacterClass.Load(Key)
            _CharacterClasses.Add(CharacterClass.ClassObj.ObjectGUID, CharacterClass)
        End If
        Return DirectCast(_CharacterClasses.Item(Key), CharacterClass)
    End Function

    'contains this class?
    Public Shared Function ContainsCharacterClass(ByVal ClassKey As Objects.ObjectKey) As Boolean
        Return _CharacterClasses.ContainsKey(ClassKey)
    End Function

    'remove a class
    Public Shared Sub RemoveCharacterClass(ByVal Key As Objects.ObjectKey)
        If _CharacterClasses.ContainsKey(Key) Then _CharacterClasses.Remove(Key)
    End Sub

#End Region

End Class