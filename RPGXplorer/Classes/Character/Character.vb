Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class Character

        'this class allows us to load an existing character, add levels to idd (via the wizard)
        'and check prerequisites at each level. It also allows a character to be updated completely if
        'changes are made elsewhere e.g. to a class.

#Region "Member Variables"

        'detailed data for checking prerequisites at each level
        Private _Inventory As Inventory
        Private Character As Objects.ObjectData
        Private Race As Objects.ObjectData
        Private Deity As Objects.ObjectData

        'folders
        Private _MagicFolder As Objects.ObjectData
        Private _PsionicFolder As Objects.ObjectData
        Private _SpellLikeFolder As Objects.ObjectData
        Private _PsiLikeFolder As Objects.ObjectData
        Private _MemorizedSpellsFolder As Objects.ObjectData

        Public Prerequisites As Rules.Prerequisites
        Public SystemPreconditions As Rules.SystemPreconditions
        Public Components As Rules.Components

        Public AvailableFeats As Rules.AvailableFeats
        Public AvailableSpellcasters As Rules.AvailableSpellcasters

        Public Modifiers As Modifiers
        Public ExtraFeats As Hashtable

        Private Level0 As Level
        Private _Levels As New ArrayList(Rules.Constants.MaxLevels)

        Public BAB1 As Integer
        Public Fortitude As Integer
        Public Will As Integer
        Public Reflex As Integer

        Public CharacterLevel As Integer
        Public FirstNewLevel As Integer

        'this is the sum of the hitdice, does not include con modifier
        Public RawHitPoints As Double

        'indexed by item Objects.ObjectKey
        Public Skills As Skills
        Public SkillRanks As New ObjectHashtable

        Public Languages As New ObjectHashtable
        Public Feats As New Library
        Public Choices As New Library

        Public PrestigeSpellcasterChoices As New Library

        Public Spells As Spells
        Public Powers As Powers
        Public Features As Features

        Public ComponentsState As ComponentsLoaded
        Public CalculateState As CalculateType

        'flags for modifiers
        Public SpeedBaseFlag, SpeedFlag, InitFlag As Modifiers.Modifier

        'improved unarmed damage
        <CLSCompliant(False)> Public _ImprovedUnarmedDamage As String

        'loading Flags & Data
        'This flag loads the characters previous skill point assignments, this means that the Skill.RankAtLevel function has to work differently
        'Public NeedPreviousSkillRanks As Boolean

        'this flag causes the CharacterClasses hashtable to loaded with the CharacterClass data for each class the character has taken a level in
        Public CharacterClasses As CharacterClassCollection

        'domains and specializations
        Public Domains As Domains
        Public PsionicSpecializations As PsionicSpecializations

        'extra class skills
        Public ExtraClassSkills As ExtraClassSkills

        'type variable for polymorphic character type
        Private _CharacterType As CharacterObjectType

        'new familiar stuff
        Public Familiars As New ArrayList
        <CLSCompliant(False)> Public _Master As Objects.ObjectKey

        '1.9 flags
        Private _Quadruped As Boolean

        '1.9.5 - The Existing arrays are loaded in Spells and Powers
        Public ExistingSpellLikeAbilities As New ArrayList
        Public ExistingPsiLikeAbilities As New ArrayList

        Public NewSpellLikeAbilities As New ArrayList
        Public NewPsiLikeAbilities As New ArrayList

        'private var for holding the racial caster/manifester class - acesss through property
        Private _RacialCasterClass As Objects.ObjectData

#End Region

#Region "Structures"

        'level
        Public Structure Level
            Private _STR As Integer
            Private _DEX As Integer
            Private _CON As Integer
            Private _INT As Integer
            Private _WIS As Integer
            Private _CHA As Integer

            Public BAB As Integer
            Private _Fortitude As Integer
            Private _Will As Integer
            Private _Reflex As Integer

            <CLSCompliant(False)> Public _Character As Character

            Public CharacterLevel As Integer
            Public CharacterLevelGuid As Objects.ObjectKey

            Public ClassName As String
            Public ClassGuid As Objects.ObjectKey
            Public ClassLevel As Integer
            Public ClassLevelGuid As Objects.ObjectKey

            Public CasterLevels As Hashtable
            Public HitPointRoll As Double
            Public HitDice As Integer

            'flags for modification 
            Public STRFlag, DEXFlag, CONFlag, WISFlag, INTFlag, CHAFlag, FortFlag, WillFlag, ReflexFlag As Rules.Modifiers.Modifier

            Public Property STR(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    If _Character.NonStr(Me.CharacterLevel) Then Return -1

                    Dim ReturnSTR As Integer = _STR

                    Dim SetAbilities As ArrayList = _Character.Components.SetAbilities.ItemData(RPGXplorer.References.Strength, Me.CharacterLevel)
                    If SetAbilities.Count <> 0 Then
                        ReturnSTR = Math.Max(_STR, _Character.HighestSetAbility(SetAbilities) - _Character.Race.ElementAsInteger("STRModifier"))
                    End If

                    If GetBase Then
                        Return ReturnSTR
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.AbilityScore("STR", CharacterLevel)
                        If Modifier > 0 Then
                            STRFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            STRFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            STRFlag = Rules.Modifiers.Modifier.None
                        End If

                        Dim ReturnValue As Integer = ReturnSTR + Modifier + _Character.Race.ElementAsInteger("STRModifier")
                        If ReturnValue < 0 Then Return 0 Else Return ReturnValue
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _STR = Value
                End Set
            End Property

            Public Property DEX(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    If _Character.NonDex(Me.CharacterLevel) Then Return -1

                    Dim ReturnDEX As Integer = _DEX

                    'check for any set ability components - 
                    Dim SetAbilities As ArrayList = _Character.Components.SetAbilities.ItemData(RPGXplorer.References.Dexterity, Me.CharacterLevel)
                    If SetAbilities.Count <> 0 Then
                        ReturnDEX = Math.Max(_DEX, _Character.HighestSetAbility(SetAbilities) - _Character.Race.ElementAsInteger("DEXModifier"))
                    End If

                    If GetBase Then
                        Return ReturnDEX
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.AbilityScore("DEX", CharacterLevel)
                        If Modifier > 0 Then
                            DEXFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            DEXFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            DEXFlag = Rules.Modifiers.Modifier.None
                        End If

                        Dim ReturnValue As Integer = ReturnDEX + Modifier + _Character.Race.ElementAsInteger("DEXModifier")
                        If ReturnValue < 0 Then Return 0 Else Return ReturnValue
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _DEX = Value
                End Set
            End Property

            Public Property CON(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    If _Character.NonCon(Me.CharacterLevel) Then Return -1

                    Dim ReturnCON As Integer = _CON

                    'check for any set ability components - 
                    Dim SetAbilities As ArrayList = _Character.Components.SetAbilities.ItemData(RPGXplorer.References.Constitution, Me.CharacterLevel)
                    If SetAbilities.Count <> 0 Then
                        ReturnCON = Math.Max(_CON, _Character.HighestSetAbility(SetAbilities) - _Character.Race.ElementAsInteger("CONModifier"))
                    End If

                    If GetBase Then
                        Return ReturnCON
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.AbilityScore("CON", CharacterLevel)
                        If Modifier > 0 Then
                            CONFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            CONFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            CONFlag = Rules.Modifiers.Modifier.None
                        End If

                        Dim ReturnValue As Integer = ReturnCON + Modifier + _Character.Race.ElementAsInteger("CONModifier")
                        If ReturnValue < 0 Then Return 0 Else Return ReturnValue
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _CON = Value
                End Set
            End Property

            Public Property INT(Optional ByVal GetBase As Boolean = False) As Integer
                Get

                    If _Character.NonInt(Me.CharacterLevel) Then Return -1

                    Dim ReturnINT As Integer = _INT

                    'check for any set ability components - 
                    Dim SetAbilities As ArrayList = _Character.Components.SetAbilities.ItemData(RPGXplorer.References.Intelligence, Me.CharacterLevel)
                    If SetAbilities.Count <> 0 Then
                        ReturnINT = Math.Max(_INT, _Character.HighestSetAbility(SetAbilities) - _Character.Race.ElementAsInteger("INTModifier"))
                    End If

                    If GetBase Then
                        Return ReturnINT
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.AbilityScore("INT", CharacterLevel)
                        If Modifier > 0 Then
                            INTFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            INTFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            INTFlag = Rules.Modifiers.Modifier.None
                        End If

                        Dim ReturnValue As Integer = ReturnINT + Modifier + _Character.Race.ElementAsInteger("INTModifier")
                        If ReturnValue < 0 Then Return 0 Else Return ReturnValue
                    End If

                End Get
                Set(ByVal Value As Integer)
                    _INT = Value
                End Set
            End Property

            Public Property WIS(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    Dim ReturnWIS As Integer = _WIS

                    'check for any set ability components - 
                    Dim SetAbilities As ArrayList = _Character.Components.SetAbilities.ItemData(RPGXplorer.References.Wisdom, Me.CharacterLevel)
                    If SetAbilities.Count <> 0 Then
                        ReturnWIS = Math.Max(_WIS, _Character.HighestSetAbility(SetAbilities) - _Character.Race.ElementAsInteger("WISModifier"))
                    End If

                    If GetBase Then
                        Return ReturnWIS
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.AbilityScore("WIS", CharacterLevel)
                        If Modifier > 0 Then
                            WISFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            WISFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            WISFlag = Rules.Modifiers.Modifier.None
                        End If

                        Dim ReturnValue As Integer = ReturnWIS + Modifier + _Character.Race.ElementAsInteger("WISModifier")
                        If ReturnValue < 0 Then Return 0 Else Return ReturnValue
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _WIS = Value
                End Set
            End Property

            Public Property CHA(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    Dim ReturnCHA As Integer = _CHA

                    'check for any set ability components - 
                    Dim SetAbilities As ArrayList = _Character.Components.SetAbilities.ItemData(RPGXplorer.References.Charisma, Me.CharacterLevel)
                    If SetAbilities.Count <> 0 Then
                        ReturnCHA = Math.Max(_CHA, _Character.HighestSetAbility(SetAbilities) - _Character.Race.ElementAsInteger("CHAModifier"))
                    End If

                    If GetBase Then
                        Return ReturnCHA
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.AbilityScore("CHA", CharacterLevel)
                        If Modifier > 0 Then
                            CHAFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            CHAFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            CHAFlag = Rules.Modifiers.Modifier.None
                        End If

                        Dim ReturnValue As Integer = ReturnCHA + Modifier + _Character.Race.ElementAsInteger("CHAModifier")
                        If ReturnValue < 0 Then Return 0 Else Return ReturnValue
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _CHA = Value
                End Set
            End Property

            Public Property AbilityScore(ByVal Name As String, Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    Select Case Name
                        Case "STR"
                            Return Me.STR(GetBase)
                        Case "DEX"
                            Return Me.DEX(GetBase)
                        Case "CON"
                            Return Me.CON(GetBase)
                        Case "INT"
                            Return Me.INT(GetBase)
                        Case "WIS"
                            Return Me.WIS(GetBase)
                        Case "CHA"
                            Return Me.CHA(GetBase)
                    End Select
                End Get
                Set(ByVal Value As Integer)
                    Select Case Name
                        Case "STR"
                            STR = Value
                        Case "DEX"
                            DEX = Value
                        Case "CON"
                            CON = Value
                        Case "INT"
                            INT = Value
                        Case "WIS"
                            WIS = Value
                        Case "CHA"
                            CHA = Value
                    End Select
                End Set
            End Property

            Public Property Fortitude(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    Dim Fort As Integer
                    Select Case _Character.CharacterType
                        Case CharacterObjectType.Familiar, CharacterObjectType.SpecialMount
                            Fort = Math.Max(_Fortitude, _Character.Master.CurrentLevel._Fortitude)
                        Case Else
                            Fort = _Fortitude
                    End Select

                    'if no con we are immune to effects which require a fortitude save
                    If _Character.NonCon Then
                        Return -999
                    End If

                    If GetBase Then
                        Return Fort + AbilityScores.AbilityScore(CON).Modifier
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.FortitudeSavingThrow(CharacterLevel)
                        If Modifier > 0 Then
                            FortFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            FortFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            FortFlag = Rules.Modifiers.Modifier.None
                        End If
                        Return Fort + AbilityScores.AbilityScore(CON).Modifier + Modifier
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _Fortitude = Value
                End Set
            End Property

            Public ReadOnly Property FortitudeBase() As Integer
                Get
                    Select Case _Character.CharacterType
                        Case CharacterObjectType.Familiar, CharacterObjectType.SpecialMount
                            Return Math.Max(_Fortitude, _Character.Master.CurrentLevel._Fortitude)
                        Case Else
                            Return _Fortitude
                    End Select
                End Get
            End Property

            Public Property Will(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    Dim AbilityModifier As Integer = -999
                    Dim BaseWill As Integer

                    Select Case _Character.CharacterType
                        Case CharacterObjectType.Familiar, CharacterObjectType.SpecialMount
                            BaseWill = Math.Max(_Will, _Character.Master.CurrentLevel._Will)
                        Case Else
                            BaseWill = _Will
                    End Select

                    'check for system ability
                    If Me._Character.Components.SystemAbilities(References.CharismaWillSave, Me.CharacterLevel) Then
                        AbilityModifier = AbilityScores.AbilityScore(CHA).Modifier
                    End If

                    AbilityModifier = Math.Max(AbilityScores.AbilityScore(WIS).Modifier, AbilityModifier)

                    If GetBase Then
                        Return BaseWill + AbilityModifier
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.WillSavingThrow(CharacterLevel)
                        If Modifier > 0 Then
                            WillFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            WillFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            WillFlag = Rules.Modifiers.Modifier.None
                        End If
                        Return BaseWill + AbilityModifier + Modifier
                    End If

                End Get
                Set(ByVal Value As Integer)
                    _Will = Value
                End Set
            End Property

            Public ReadOnly Property WillBase() As Integer
                Get
                    Select Case _Character.CharacterType
                        Case CharacterObjectType.Familiar, CharacterObjectType.SpecialMount
                            Return Math.Max(_Will, _Character.Master.CurrentLevel._Will)
                        Case Else
                            Return _Will
                    End Select
                End Get
            End Property

            Public Property Reflex(Optional ByVal GetBase As Boolean = False) As Integer
                Get
                    Dim AbilityModifier As Integer = -999
                    Dim BaseReflex As Integer

                    Select Case _Character.CharacterType
                        Case CharacterObjectType.Familiar, CharacterObjectType.SpecialMount
                            BaseReflex = Math.Max(_Reflex, _Character.Master.CurrentLevel._Reflex)
                        Case Else
                            BaseReflex = _Reflex
                    End Select

                    'check for system ability
                    If Me._Character.Components.SystemAbilities(References.IntelligenceReflexSave, Me.CharacterLevel) Then
                        AbilityModifier = AbilityScores.AbilityScore(INT).Modifier
                    End If

                    'if we do have a dex - get the biggest modifier
                    If Not _Character.NonDex Then
                        AbilityModifier = Math.Max(AbilityScores.AbilityScore(DEX).Modifier, AbilityModifier)
                    End If

                    'if the modifier is still -999 then we dont have a dex or an intell reflex save
                    If AbilityModifier = -999 Then
                        'we automaticaly fail all reflex saves
                        Return -999
                    End If

                    If GetBase Then
                        Return BaseReflex + AbilityModifier
                    Else
                        Dim Modifier As Integer = _Character.Modifiers.ReflexSavingThrow(CharacterLevel)
                        If Modifier > 0 Then
                            ReflexFlag = Rules.Modifiers.Modifier.Positive
                        ElseIf Modifier < 0 Then
                            ReflexFlag = Rules.Modifiers.Modifier.Negative
                        Else
                            ReflexFlag = Rules.Modifiers.Modifier.None
                        End If
                        Return BaseReflex + AbilityModifier + Modifier
                    End If
                End Get
                Set(ByVal Value As Integer)
                    _Reflex = Value
                End Set
            End Property

            Public ReadOnly Property ReflexBase() As Integer
                Get
                    Select Case _Character.CharacterType
                        Case CharacterObjectType.Familiar, CharacterObjectType.SpecialMount
                            Return Math.Max(_Reflex, _Character.Master.CurrentLevel._Reflex)
                        Case Else
                            Return _Reflex
                    End Select
                End Get
            End Property

            Public Function Clone(ByVal Level As Level, ByVal NewChar As Character) As Level
                Dim _Clone As Level

                Try
                    _Clone = Level
                    _Clone.CasterLevels = DirectCast(Level.CasterLevels.Clone, Hashtable)
                    _Clone._Character = NewChar

                    Return _Clone
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

            Public Function CreateCharacterLevel() As Objects.ObjectData
                Dim CharacterLevelObject As New Objects.ObjectData
                Try

                    CharacterLevelObject.Name = "Level " & CharacterLevel
                    CharacterLevelObject.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                    CharacterLevelObject.Type = Objects.CharacterLevelType
                    CharacterLevelObject.ParentGUID = _Character.CharacterObject.FirstChildOfType(Objects.CharacterLevelsFolderType).ObjectGUID

                    CharacterLevelObject.Element("CharacterLevel") = CharacterLevel.ToString
                    CharacterLevelObject.FKElement("Class", ClassName, "Name", ClassGuid)
                    CharacterLevelObject.FKElement("ClassLevel", ClassLevel.ToString, "Level", ClassLevelGuid)
                    CharacterLevelObject.Element("HitPointRoll") = HitPointRoll.ToString()
                    CharacterLevelObject.Element("HitDice") = HitDice.ToString

                    CharacterLevelObject.Element("STR") = _STR.ToString
                    CharacterLevelObject.Element("DEX") = _DEX.ToString
                    CharacterLevelObject.Element("CON") = _CON.ToString
                    CharacterLevelObject.Element("INT") = _INT.ToString
                    CharacterLevelObject.Element("WIS") = _WIS.ToString
                    CharacterLevelObject.Element("CHA") = _CHA.ToString

                    Return CharacterLevelObject

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

        End Structure

        'skill ranks
        Public Structure SkillRank
            Public SkillGuid As Objects.ObjectKey
            Public SkillName As String
            Public SkillGroup As String
            Public Ranks As Double
            Public NewRanks As Double
            Public Mods As Integer

            'things requiring cloning behaviour
            Public AssignedRanks As Hashtable

            Public ReadOnly Property Final() As Double
                Get
                    Return Math.Floor((Ranks + NewRanks + Mods))
                End Get
            End Property

            Public Function RankAtLevel(ByVal Level As Integer) As Double
                Dim AssignmentLevel As Integer
                Dim AssignmentRanks As Double
                Dim RanksSoFar As Double = 0

                For Each Assignment As DictionaryEntry In AssignedRanks
                    AssignmentLevel = CType(Assignment.Key, Integer)
                    AssignmentRanks = CType(Assignment.Value, Double)

                    If AssignmentLevel <= Level Then
                        RanksSoFar += AssignmentRanks
                    End If
                Next

                Return RanksSoFar

            End Function

            Public Function CreateObject(ByVal CharacterObject As Objects.ObjectData) As Objects.ObjectData
                Dim SkillRankObject As New Objects.ObjectData

                SkillRankObject.Name = SkillName
                SkillRankObject.ObjectGUID = Objects.ObjectKey.NewGuid(CharacterObject.ObjectGUID.Database)
                SkillRankObject.Type = Objects.SkillPointsSpentType
                SkillRankObject.ParentGUID = CharacterObject.FirstChildOfType(Objects.SkillFolderType).ObjectGUID
                SkillRankObject.HTMLGUID = SkillGuid

                SkillRankObject.FKElement("Skill", SkillName, "Name", SkillGuid)
                SkillRankObject.Element("Rank") = (Ranks + NewRanks).ToString

                For Each SkillAssignment As DictionaryEntry In AssignedRanks
                    SkillRankObject.Element("Level" & CType(SkillAssignment.Key, Integer).ToString) = CType(SkillAssignment.Value, Double).ToString
                Next

                Return SkillRankObject

            End Function
        End Structure

        'feats
        Public Structure Feat
            Public FeatGuid As Objects.ObjectKey
            Public FeatName As String
            Public FeatType As String
            Public FocusGuid As Objects.ObjectKey
            Public FocusName As String
            Public LevelTaken As Integer
            Public IgnorePrerequisites As Boolean
            Public Disabled As Boolean

            'Extra Column Info
            Public SourceName As String
            Public SourceGuid As Objects.ObjectKey
            Public FeatSlotSource As String

            Public Sub Clear()
                FeatGuid = Nothing
                FeatName = Nothing
                FeatType = Nothing
                FocusGuid = Nothing
                FocusName = Nothing
                LevelTaken = Nothing
                IgnorePrerequisites = False
                Disabled = False
                SourceName = Nothing
                SourceGuid = Nothing
                FeatSlotSource = Nothing
            End Sub

            Public Function CreateObject(ByVal Character As Rules.Character) As Objects.ObjectData
                Dim FeatTakenObject As New Objects.ObjectData
                Dim FeatDefinition As New Objects.ObjectData
                Dim ClassDefinition As Objects.ObjectData

                FeatDefinition.Load(FeatGuid)

                FeatTakenObject.Name = FeatName
                FeatTakenObject.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                FeatTakenObject.Type = Objects.FeatTakenType
                FeatTakenObject.ParentGUID = Character.CharacterObject.FirstChildOfType(Objects.FeatFolderType).ObjectGUID
                FeatTakenObject.HTMLGUID = FeatGuid

                FeatTakenObject.FKElement("Feat", FeatName, "Name", FeatGuid)
                FeatTakenObject.Element("CharacterLevel") = LevelTaken.ToString
                FeatTakenObject.Element("SourceType") = FeatSlotSource

                Select Case FeatSlotSource
                    Case Rules.AvailableFeats.PathAutomaticFeat, Rules.AvailableFeats.ChoosePathFeat
                        'get the name of the style
                        Dim CombatStyle As New Objects.ObjectData
                        Dim StyleName As String

                        CombatStyle.Load(SourceGuid)
                        StyleName = CombatStyle.Element(SourceName)
                        FeatTakenObject.FKElement("Source", StyleName, SourceName, SourceGuid)
                    Case Else
                        FeatTakenObject.FKElement("Source", SourceName, "Name", SourceGuid)
                End Select

                FeatTakenObject.Element("FeatType") = FeatType
                FeatTakenObject.FKElement("Description", FeatDefinition.Element("Description"), "Description", FeatGuid)

                If Disabled Then FeatTakenObject.Element("Disabled") = "Yes" Else FeatTakenObject.Element("Disabled") = ""
                If IgnorePrerequisites Then FeatTakenObject.Element("IgnorePrerequisites") = "Yes" Else FeatTakenObject.Element("IgnorePrerequisites") = ""

                If FocusGuid.IsNotEmpty Then
                    FeatTakenObject.FKElement("Focus", FocusName, "Name", FocusGuid)
                End If

                'Get the class
                If Not Character.CharacterClasses Is Nothing Then
                    ClassDefinition = DirectCast(Character.CharacterClasses(Character.Levels(Me.LevelTaken).ClassGuid), Rules.CharacterClass).ClassObj
                    FeatTakenObject.FKElement("Class", ClassDefinition.Name, "Name", ClassDefinition.ObjectGUID)
                End If

                Return FeatTakenObject

            End Function

        End Structure

        'enum for determining what state the character is currently in - used by character manager
        Public Enum CalculateType
            NotCalulated
            Character
            CharacterAndInventory
        End Enum

        'enum for determining what state the character is currently in - used by character manager
        Public Enum ComponentsLoaded
            NoneLoaded
            Character
            CharacterAndInventory
        End Enum

        'enum for determining what kind of character this is
        Public Enum CharacterObjectType
            Character
            Familiar
            AnimalCompanion
            SpecialMount
            Monster
        End Enum

        'choices
        Public Structure CharacterChoice
            Public ClassName As String
            Public ClassGuid As Objects.ObjectKey
            Public Type As ChoiceType
            Public Data As String
            Public DataGuid As Objects.ObjectKey
            Public LevelAcquired As Integer

            'For the Favored Enemy choice
            Public LevelsAssigned As Hashtable
            Public Bonus As Integer

            Public Sub Clear()
                ClassName = Nothing
                ClassGuid = Nothing
                Type = Nothing
                Data = Nothing
                DataGuid = Nothing
                Bonus = Nothing
                LevelAcquired = Nothing
            End Sub

            Public Function CreateObject(ByVal Character As Rules.Character) As Objects.ObjectData
                Dim ChoiceTakenObject As New Objects.ObjectData

                ChoiceTakenObject.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                ChoiceTakenObject.ParentGUID = Character.CharacterObject.FirstChildOfType(Objects.CharacterChoiceFolderType).ObjectGUID
                ChoiceTakenObject.FKElement("Class", ClassName, "Name", ClassGuid)

                Select Case Type
                    Case ChoiceType.CombatStyle
                        Dim CombatStyle As New Objects.ObjectData
                        Dim StyleName As String

                        'get the name of the style
                        CombatStyle.Load(DataGuid)
                        StyleName = CombatStyle.Element(Data)

                        'Data here is the name of the style choice either "Style1" or "Style2"
                        ChoiceTakenObject.Name = StyleName
                        ChoiceTakenObject.Type = Objects.CombatStyleChoiceType
                        ChoiceTakenObject.FKElement("CombatStyle", StyleName, Data, DataGuid)
                        ChoiceTakenObject.Element("LevelAcquired") = LevelAcquired.ToString

                    Case ChoiceType.SacrificedSchool
                        ChoiceTakenObject.Name = Data
                        ChoiceTakenObject.ParentGUID = Character.MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType).ObjectGUID
                        ChoiceTakenObject.Type = Objects.SpellSchoolProhibitedChoiceType
                        ChoiceTakenObject.FKElement("School", Data, "Name", DataGuid)
                        ChoiceTakenObject.Element("LevelAcquired") = LevelAcquired.ToString
                        ChoiceTakenObject.HTMLGUID = DataGuid

                    Case ChoiceType.SpecailistSchool
                        ChoiceTakenObject.Name = Data
                        ChoiceTakenObject.ParentGUID = Character.MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType).ObjectGUID
                        ChoiceTakenObject.Type = Objects.SpellSchoolSpecialistChoiceType
                        ChoiceTakenObject.FKElement("School", Data, "Name", DataGuid)
                        ChoiceTakenObject.Element("LevelAcquired") = LevelAcquired.ToString
                        ChoiceTakenObject.HTMLGUID = DataGuid

                    Case ChoiceType.FavoredEnemy
                        ChoiceTakenObject.Name = Rules.Formatting.FormatModifier(Bonus) & " vs. " & Data
                        ChoiceTakenObject.Type = Objects.FavoredEnemyChoice
                        ChoiceTakenObject.FKElement("Monster", Data, "Name", DataGuid)
                        ChoiceTakenObject.Element("Bonus") = Bonus.ToString
                        ChoiceTakenObject.Element("LevelAcquired") = LevelAcquired.ToString
                        ChoiceTakenObject.HTMLGUID = DataGuid

                        For Each BonusAssignment As DictionaryEntry In LevelsAssigned
                            ChoiceTakenObject.Element("Level" & CType(BonusAssignment.Key, Integer).ToString) = CType(BonusAssignment.Value, Double).ToString
                        Next

                    Case ChoiceType.FavoredEnemySingle
                        ChoiceTakenObject.Name = Rules.Formatting.FormatModifier(Bonus) & " vs. " & Data
                        ChoiceTakenObject.Type = Objects.FavoredEnemySingleChoice
                        ChoiceTakenObject.FKElement("Monster", Data, "Name", DataGuid)
                        ChoiceTakenObject.Element("Bonus") = Bonus.ToString
                        ChoiceTakenObject.Element("LevelAcquired") = LevelAcquired.ToString
                        ChoiceTakenObject.HTMLGUID = DataGuid

                        For Each BonusAssignment As DictionaryEntry In LevelsAssigned
                            ChoiceTakenObject.Element("Level" & CType(BonusAssignment.Key, Integer).ToString) = CType(BonusAssignment.Value, Double).ToString
                        Next

                    Case ChoiceType.SpellcasterChoice
                        ChoiceTakenObject.Name = Data
                        ChoiceTakenObject.Type = Objects.PrestigeClassSpellcasterChoice
                        ChoiceTakenObject.FKElement("SpellcasterClass", Data, "Name", DataGuid)
                        ChoiceTakenObject.Element("LevelAcquired") = LevelAcquired.ToString
                        ChoiceTakenObject.HTMLGUID = DataGuid
                End Select

                Return ChoiceTakenObject

            End Function
        End Structure

        'choice Types
        Public Enum ChoiceType
            SpecailistSchool
            SacrificedSchool
            CombatStyle
            FavoredEnemy
            SpellcasterChoice
            FavoredEnemySingle
        End Enum

        'languages
        Public Structure Language
            Public LanguageName As String
            Public LanguageGuid As Objects.ObjectKey
            Public LevelGained As Integer

            Public Function CreateObject(ByVal Character As Rules.Character) As Objects.ObjectData
                Dim LanguageTakenObject As New Objects.ObjectData

                LanguageTakenObject.Name = LanguageName
                LanguageTakenObject.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                LanguageTakenObject.Type = Objects.LanguageType
                LanguageTakenObject.ParentGUID = Character.CharacterObject.FirstChildOfType(Objects.LanguageFolderType).ObjectGUID
                LanguageTakenObject.HTMLGUID = LanguageGuid

                LanguageTakenObject.Element("LevelAcquired") = LevelGained.ToString
                LanguageTakenObject.FKElement("Language", LanguageName, "Name", LanguageGuid)

                Return LanguageTakenObject

            End Function

        End Structure

        'caster levels
        Public Structure CasterLevel
            Public ClassGuid As Objects.ObjectKey
            Public ClassName As String
            Public CasterLevel As Integer
            Public Type As CasterType

            Enum CasterType
                Spellcaster
                Manifester
                None
            End Enum

        End Structure

#End Region

#Region "Properties"

        'get the number of HitDice this Companion has
        Public ReadOnly Property HitDice() As Integer
            Get
                HitDice = 1
                Select Case CharacterType
                    Case CharacterObjectType.Character
                        Return Me.CharacterLevel
                    Case CharacterObjectType.Monster
                        Return Me.CharacterLevel
                    Case CharacterObjectType.Familiar
                        Return Me.CharacterLevel
                    Case CharacterObjectType.SpecialMount, CharacterObjectType.AnimalCompanion

                        'add class hitdice
                        For Each Level As Rules.Character.Level In Me._Levels
                            HitDice += Level.HitDice
                        Next

                        Return HitDice

                End Select
            End Get
        End Property

        'get the number of HitDice this Companion has at the given level
        Public ReadOnly Property HitDiceAtLevel(ByVal level As Integer) As Integer
            Get
                HitDiceAtLevel = 1
                Select Case CharacterType
                    Case CharacterObjectType.Character
                        Return Me.CharacterLevel
                    Case CharacterObjectType.Monster
                        Return Me.CharacterLevel
                    Case CharacterObjectType.Familiar
                        Return Me.CharacterLevel
                    Case CharacterObjectType.SpecialMount, CharacterObjectType.AnimalCompanion

                        'add class hitdice
                        For Each CharacterLevel As Rules.Character.Level In Me._Levels
                            If CharacterLevel.CharacterLevel <= level Then
                                HitDiceAtLevel += CharacterLevel.HitDice
                            End If
                        Next

                        Return HitDiceAtLevel

                End Select
            End Get
        End Property

        'get the character type
        Public ReadOnly Property CharacterType() As CharacterObjectType
            Get
                Return _CharacterType
            End Get
        End Property

        ''get the monster type
        'Public ReadOnly Property MonsterType() As String
        '    '???
        '    Get
        '        If Me.CharacterLevel > 0 Then
        '            For n As Integer = Me.CharacterLevel To 1 Step -1

        '            Next
        '        End If
        '    End Get
        'End Property

        ''get the monster subtype
        'Public ReadOnly Property MonsterSubType() As String
        '    '???
        '    Get

        '    End Get
        'End Property

        'current ability score
        Public ReadOnly Property AbilityScore(ByVal Ability As String) As Integer
            Get

                If CharacterLevel = 0 Then
                    Return Nothing
                Else
                    Return AbilityScore(Ability, Me.CharacterLevel)
                End If

            End Get
        End Property

        'ability score at a given level
        Public ReadOnly Property AbilityScore(ByVal Ability As String, ByVal Level As Integer) As Integer
            Get
                If CharacterLevel = 0 Then Return Nothing

                Dim RequiredLevel As Character.Level
                RequiredLevel = Me.Levels(Level)

                Select Case Ability
                    Case "STR"
                        Return RequiredLevel.STR
                    Case "DEX"
                        Return RequiredLevel.DEX
                    Case "CON"
                        Return RequiredLevel.CON
                    Case "INT"
                        Return RequiredLevel.INT
                    Case "WIS"
                        Return RequiredLevel.WIS
                    Case "CHA"
                        Return RequiredLevel.CHA
                End Select
            End Get
        End Property

        'returns the ObjectData from this character
        Public Property CharacterObject() As Objects.ObjectData
            Get
                Return Me.Character
            End Get
            Set(ByVal Value As Objects.ObjectData)
                Me.Character = Value
            End Set
        End Property

        'class level in the given class
        Public ReadOnly Property CurrentClassLevel(ByVal ClassKey As Objects.ObjectKey) As Integer
            Get
                If Me._Levels Is Nothing Then Return 0

                Dim ClassLevel As Level
                Dim Max As Integer = 0

                'get the current highest level in this class
                For Each ClassLevel In _Levels
                    If ClassLevel.ClassGuid.Equals(ClassKey) Then
                        If ClassLevel.ClassLevel > Max Then Max = ClassLevel.ClassLevel
                    End If
                Next

                Return Max
            End Get
        End Property

        'hit points (current)
        Public ReadOnly Property CurrentHP() As Integer
            Get
                Dim HitPoints As Integer = Character.ElementAsInteger("CurrentHP")
                Return HitPoints
            End Get
        End Property

        'non lethal (current)
        Public ReadOnly Property CurrentNonlethalHP() As Integer
            Get
                Dim HitPoints As Integer = Character.ElementAsInteger("CurrentNonlethalHP")
                Return HitPoints
            End Get
        End Property

        'current level
        Public ReadOnly Property CurrentLevel() As Level
            Get
                If CharacterLevel = 0 Then
                    Return Level0
                Else
                    Return Levels(CharacterLevel)
                End If
            End Get
        End Property

        'deity ObjectData
        Public ReadOnly Property DeityObject() As Objects.ObjectData
            Get
                Return Me.Deity
            End Get
        End Property

        'effective character level
        Public ReadOnly Property EffectiveCharacterLevel() As Integer
            Get
                Return CharacterLevel + RaceObject.ElementAsInteger("LA")
            End Get
        End Property

        'hit points (base)
        Public ReadOnly Property HP() As Integer
            Get
                Select Case CharacterType
                    Case CharacterObjectType.Familiar
                        HP = (Master.HP \ 2)
                    Case Else
                        Dim CONMod As Integer
                        Dim TotalHP, Temp As Double
                        CONMod = Rules.AbilityScores.AbilityScore(Me.CurrentLevel.CON).Modifier

                        For Each Level As Level In _Levels
                            If Not Level.HitPointRoll = 0 Then
                                Dim ConMulti As Integer
                                ConMulti = Math.Max(Level.HitDice, 1)
                                Temp = Level.HitPointRoll + (CONMod * ConMulti)
                                If Temp < 1 Then Temp = 1
                                TotalHP += Temp
                            End If
                        Next
                        HP = CInt(Math.Floor(TotalHP))
                End Select

                HP += Modifiers.HitPoints
            End Get
        End Property

        'initiative
        Public ReadOnly Property Initiative() As Integer
            Get

                Dim Modifier As Integer = Modifiers.Initiative
                If Modifier > 0 Then
                    InitFlag = Rules.Modifiers.Modifier.Positive
                ElseIf Modifier < 0 Then
                    InitFlag = Rules.Modifiers.Modifier.Negative
                Else
                    InitFlag = Rules.Modifiers.Modifier.None
                End If

                If NonDex Then
                    Return AbilityScores.AbilityScore(CurrentLevel.INT).Modifier + Modifier
                Else
                    Return AbilityScores.AbilityScore(CurrentLevel.DEX).Modifier + Modifier
                End If

            End Get
        End Property

        'the inventory object
        Public Property Inventory() As Inventory
            Get
                Return _Inventory
            End Get
            Set(ByVal Value As Inventory)
                _Inventory = Value
            End Set
        End Property

        'level structure for given character level
        Public Property Levels(ByVal CharacterLevel As Integer) As Level
            Get
                If CharacterLevel = 0 Then
                    Return Me.Level0
                Else

                    If CharacterLevel > Me.CharacterLevel Then
                        CharacterLevel = Me.CharacterLevel
                    End If

                    Return DirectCast(_Levels.Item(CharacterLevel - 1), Character.Level)
                End If
            End Get
            Set(ByVal Value As Level)
                _Levels.Item(CharacterLevel - 1) = Value
            End Set
        End Property

        'get the magic folder
        Public ReadOnly Property MagicFolder() As Objects.ObjectData
            Get
                'see if we have loaded the folder yet
                If _MagicFolder.IsEmpty Then

                    'see if it already exists
                    _MagicFolder = Me.CharacterObject.FirstChildOfType(Objects.MagicFolderType)

                    'if not generate a new object
                    If _MagicFolder.IsEmpty Then
                        _MagicFolder.Name = "Magic"
                        _MagicFolder.ObjectGUID = Objects.ObjectKey.NewGuid(Me.CharacterObject.ObjectGUID.Database)
                        _MagicFolder.Type = Objects.MagicFolderType
                        _MagicFolder.ParentGUID = Me.CharacterObject.ObjectGUID
                        Return _MagicFolder
                    Else
                        Return _MagicFolder
                    End If
                Else
                    Return _MagicFolder
                End If
            End Get
        End Property

        'get the psionic folder
        Public ReadOnly Property PsionicFolder() As Objects.ObjectData
            Get
                'see if we have loaded the folder yet
                If _PsionicFolder.IsEmpty Then

                    'see if it already exists
                    _PsionicFolder = Me.CharacterObject.FirstChildOfType(Objects.PsionicFolderType)

                    'if not generate a new object
                    If _PsionicFolder.IsEmpty Then
                        _PsionicFolder.Name = "Psionic"
                        _PsionicFolder.ObjectGUID = Objects.ObjectKey.NewGuid(Me.CharacterObject.ObjectGUID.Database)
                        _PsionicFolder.Type = Objects.PsionicFolderType
                        _PsionicFolder.ParentGUID = Me.CharacterObject.ObjectGUID
                        Return _PsionicFolder
                    Else
                        Return _PsionicFolder
                    End If
                Else
                    Return _PsionicFolder
                End If
            End Get
        End Property

        'get the spell like ability folder
        Public ReadOnly Property SpellLikeAbilityFolder() As Objects.ObjectData
            Get
                If _SpellLikeFolder.IsEmpty Then
                    'see if it already exists
                    _SpellLikeFolder = Me.MagicFolder.FirstChildOfType(Objects.SpellLikeAbilityFolderType)

                    If _SpellLikeFolder.IsEmpty Then
                        _SpellLikeFolder.Name = "Spell Like Abilities"
                        _SpellLikeFolder.ObjectGUID = Objects.ObjectKey.NewGuid(Me.CharacterObject.ObjectGUID.Database)
                        _SpellLikeFolder.Type = Objects.SpellLikeAbilityFolderType
                        _SpellLikeFolder.ParentGUID = Me.MagicFolder.ObjectGUID
                        Return _SpellLikeFolder
                    Else
                        Return _SpellLikeFolder
                    End If
                Else
                    Return _SpellLikeFolder
                End If
            End Get
        End Property

        'get the psi like ability folder
        Public ReadOnly Property PsiLikeAbilityFolder() As Objects.ObjectData
            Get
                If _PsiLikeFolder.IsEmpty Then
                    'see if it already exists
                    _PsiLikeFolder = Me.PsionicFolder.FirstChildOfType(Objects.PsiLikeAbilityFolderType)

                    If _PsiLikeFolder.IsEmpty Then
                        _PsiLikeFolder.Name = "Psi Like Abilities"
                        _PsiLikeFolder.ObjectGUID = Objects.ObjectKey.NewGuid(Me.CharacterObject.ObjectGUID.Database)
                        _PsiLikeFolder.Type = Objects.PsiLikeAbilityFolderType
                        _PsiLikeFolder.ParentGUID = Me.PsionicFolder.ObjectGUID
                        Return _PsiLikeFolder
                    Else
                        Return _PsiLikeFolder
                    End If
                Else
                    Return _PsiLikeFolder
                End If
            End Get
        End Property

        'get the memorized spells folder
        Public ReadOnly Property MemorizedSpellsFolder() As Objects.ObjectData
            Get
                If _MemorizedSpellsFolder.IsEmpty Then
                    'see if it already exists
                    _MemorizedSpellsFolder = Me.MagicFolder.FirstChildOfType(Objects.MemorizedSpellsFolderType)

                    If _MemorizedSpellsFolder.IsEmpty Then
                        _MemorizedSpellsFolder.Name = "Memorized Spells"
                        _MemorizedSpellsFolder.ObjectGUID = Objects.ObjectKey.NewGuid(Me.CharacterObject.ObjectGUID.Database)
                        _MemorizedSpellsFolder.Type = Objects.MemorizedSpellsFolderType
                        _MemorizedSpellsFolder.ParentGUID = Me.MagicFolder.ObjectGUID
                    End If
                End If
                Return _MemorizedSpellsFolder
            End Get
        End Property

        'next level XP
        Public ReadOnly Property NextLevelXP() As Integer
            Get
                If Me.EffectiveCharacterLevel < Rules.Constants.MaxLevels And CharacterLevel > 0 Then
                    Return Rules.ExperienceAndLevelling.LevelDependentBenefits(EffectiveCharacterLevel + 1).XP
                Else
                    Return -1
                End If
            End Get
        End Property

        'race ObjectData
        Public ReadOnly Property RaceObject() As Objects.ObjectData
            Get
                Return Me.Race
            End Get
        End Property

        'size
        Public ReadOnly Property Size() As String
            Get
                If Character.Element("Size") = "" Then
                    Return Race.Element("Size")
                Else
                    Return Character.Element("Size")
                End If
            End Get
        End Property

        'space
        Public ReadOnly Property Space() As String
            Get
                Return Race.Element("Space")
            End Get
        End Property

        'reach
        Public ReadOnly Property Reach() As String
            Get
                Return Race.Element("Reach")
            End Get
        End Property

        'quadruped?
        Public ReadOnly Property Quadruped() As Boolean
            Get
                Return _Quadruped
            End Get
        End Property

        'returns the SkillRank for the given guid
        Public ReadOnly Property Skill(ByVal SkillGuid As Objects.ObjectKey) As SkillRank
            Get
                Return DirectCast(SkillRanks.Item(SkillGuid), SkillRank)
            End Get
        End Property

        'speed, base
        Public ReadOnly Property SpeedBase() As Integer
            Get
                Dim Modifier As Integer = Modifiers.BaseSpeed
                If Modifier > 0 Then
                    SpeedBaseFlag = Rules.Modifiers.Modifier.Positive
                ElseIf Modifier < 0 Then
                    SpeedBaseFlag = Rules.Modifiers.Modifier.Negative
                Else
                    SpeedBaseFlag = Rules.Modifiers.Modifier.None
                End If
                Return CInt(RaceObject.Element("Speed").Replace(" ft.", "")) + Modifier
            End Get
        End Property

        'swim speed
        Public ReadOnly Property Swim() As String
            Get
                Dim ReturnString As String = RaceObject.Element("Swim")

                If ReturnString = "" Then
                    Return "-"
                Else
                    Return ReturnString
                End If
            End Get
        End Property

        'climbing speed
        Public ReadOnly Property Climb() As String
            Get
                Dim ReturnString As String = RaceObject.Element("Climb")

                If ReturnString = "" Then
                    Return "-"
                Else
                    Return ReturnString
                End If
            End Get
        End Property

        'burrowing speed
        Public ReadOnly Property Burrow() As String
            Get
                Dim ReturnString As String = RaceObject.Element("Burrow")

                If ReturnString = "" Then
                    Return "-"
                Else
                    Return ReturnString
                End If
            End Get
        End Property

        'flying speed and type
        Public ReadOnly Property Fly() As String
            Get
                Dim ReturnString As String = RaceObject.Element("Fly")

                If ReturnString = "" OrElse ReturnString = "-" Then
                    Return "-"
                Else
                    Return ReturnString & "(" & RaceObject.Element("FlyManueverability") & ")"
                End If
            End Get
        End Property

        'speed, base
        Public ReadOnly Property SpeedBaseUnmodified() As Integer
            Get
                Return CInt(RaceObject.Element("Speed").Replace(" ft.", ""))
            End Get
        End Property

        'does this character have any levels in spellcasting classes?
        Public ReadOnly Property IsCaster() As Boolean
            Get
                For Each ClassKey As Objects.ObjectKey In CharacterClassKeys()
                    Dim CharacterClass As CharacterClass = DirectCast(CharacterClasses.Item(ClassKey), CharacterClass)
                    If CharacterClass.IsCaster Then Return True
                Next
                Return False
            End Get
        End Property

        'the creatures have a natural armor (before modifiers)
        Public ReadOnly Property RaceNaturalArmor() As Integer
            Get
                Return RaceObject.ElementAsInteger("NaturalArmor")
            End Get
        End Property

        'returns this animals linked character
        Public ReadOnly Property Master() As Character
            Get
                If _Master.IsNotEmpty Then
                    Return CharacterManager.GetCharacter(_Master)
                Else
                    Return Nothing
                End If
            End Get
        End Property

        'does this character have a Constitution Nonability?
        Public ReadOnly Property NonCon(Optional ByVal Level As Integer = 1000) As Boolean
            Get
                Return Components.SystemAbilities(References.ConstitutionNonability, Level)
            End Get
        End Property

        'does this character have a Dexterity Nonability?
        Public ReadOnly Property NonDex(Optional ByVal Level As Integer = 1000) As Boolean
            Get
                Return Components.SystemAbilities(References.DexterityNonability, Level)
            End Get
        End Property

        'does this character have a Intelligence Nonability?
        Public ReadOnly Property NonInt(Optional ByVal Level As Integer = 1000) As Boolean
            Get
                Return Components.SystemAbilities(References.IntelligenceNonability, Level)
            End Get
        End Property

        'does this character have a Strength Nonability?
        Public ReadOnly Property NonStr(Optional ByVal Level As Integer = 1000) As Boolean
            Get
                Return Components.SystemAbilities(References.StrengthNonability, Level)
            End Get
        End Property

        'is the given ability a nonability?
        Public ReadOnly Property IsNonability(ByVal Ability As String) As Boolean
            Get
                Select Case Ability

                    Case "STR"
                        Return NonStr
                    Case "INT"
                        Return NonInt
                    Case "DEX"
                        Return NonDex
                    Case "CON"
                        Return NonCon
                    Case Else
                        Return False
                End Select
            End Get
        End Property

        'get a collection of the specialist schools for the given class
        Public ReadOnly Property SpecialistSchools(ByVal ClassKey As Objects.ObjectKey) As Hashtable
            Get
                Dim Schools As New Hashtable

                Dim Choice As Rules.Character.CharacterChoice
                For Each Data As Library.LibraryData In Choices.ItemData(ClassKey)
                    Choice = DirectCast(Data.Data, Character.CharacterChoice)
                    Select Case Choice.Type
                        Case ChoiceType.SpecailistSchool
                            Schools.Item(Choice.DataGuid) = Nothing
                    End Select
                Next

                Return Schools

            End Get
        End Property

        'is this a racial caster
        Public ReadOnly Property IsRacialCaster() As Boolean
            Get
                If RaceObject.GetFKGuid("CasterSource").IsNotEmpty Then
                    Dim CasterObject As Objects.ObjectData = RacialCasterClass
                    If CasterObject.Element("CasterAbility") = "Yes" Then
                        Return True
                    End If
                End If

                Return False

            End Get
        End Property

        'is this a racial manifester
        Public ReadOnly Property IsRacialManifester() As Boolean
            Get
                If RaceObject.GetFKGuid("CasterSource").IsNotEmpty Then
                    Dim CasterObject As Objects.ObjectData = RacialCasterClass
                    If CasterObject.Element("CasterAbility") = "Psionic" Then
                        Return True
                    End If
                End If

                Return False

            End Get
        End Property

        'returns the racial caster class object
        Public ReadOnly Property RacialCasterClass() As Objects.ObjectData
            Get
                If _RacialCasterClass.IsEmpty Then
                    _RacialCasterClass = RaceObject.GetFKObject("CasterSource")
                End If

                Return _RacialCasterClass

            End Get
        End Property

#End Region

#Region "Combat Properties"

        'base attack bonus
        Public ReadOnly Property BAB() As Integer
            Get
                Select Case CharacterType
                    Case CharacterObjectType.Familiar
                        If Me.Components.SystemAbilities(References.UnlinkBAB) Then
                            Return CurrentLevel.BAB
                        Else
                            Dim MyBAB As Integer = CurrentLevel.BAB
                            Dim MasterBAB As Integer = Master.BAB

                            Return Math.Max(MyBAB, MasterBAB)
                        End If
                    Case Else
                        Return CurrentLevel.BAB
                End Select
            End Get
        End Property

        'strength modifier
        Public ReadOnly Property StrengthModifier() As Integer
            Get
                Return Rules.AbilityScores.AbilityScore(CurrentLevel.STR).Modifier
            End Get
        End Property

        'dex modifier
        Public ReadOnly Property DexterityModifier() As Integer
            Get
                Return Rules.AbilityScores.AbilityScore(CurrentLevel.DEX).Modifier
            End Get
        End Property

        'combat size modifier
        Public ReadOnly Property SizeModifier() As Integer
            Get
                Return Rules.Size.Size(Size).Modifier
            End Get
        End Property

        'get the melee attack modifier for this character 
        Public ReadOnly Property BABMelee(Optional ByVal IncludeShieldProf As Boolean = False) As Integer
            Get
                Dim MeleeModifier As Integer = 0

                'ability modifier
                If Me.NonStr Then
                    If Me.NonDex Then
                        'cannot make any attacks
                        Return -1
                    Else
                        MeleeModifier += DexterityModifier

                        'if wearing a shield - include shield check penalty
                        If IncludeShieldProf Then
                            If _Inventory.ShieldWorn.IsNotEmpty Then
                                MeleeModifier += _Inventory.ShieldProperties.CheckPenalty
                            End If
                        End If

                    End If
                Else
                    MeleeModifier += StrengthModifier
                End If

                'size
                MeleeModifier += SizeModifier

                'proficencies
                Dim Proficiency As New RPGXplorer.Rules.Proficiency(Me)

                If Not _Inventory Is Nothing Then

                    If _Inventory.ArmorWorn.IsNotEmpty Then
                        If Proficiency.Proficient(_Inventory.ArmorProperties.BaseArmor, _Inventory.ArmorProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then
                            MeleeModifier += _Inventory.ArmorProperties.CheckPenalty
                        End If
                    End If

                    If IncludeShieldProf Then
                        If _Inventory.ShieldWorn.IsNotEmpty Then
                            If Proficiency.Proficient(_Inventory.ShieldProperties.BaseArmor, _Inventory.ShieldProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then
                                MeleeModifier += _Inventory.ShieldProperties.CheckPenalty
                            End If
                        End If
                    End If

                End If

                'modifiers
                MeleeModifier += Modifiers.AttackRoll

                'BAB
                MeleeModifier += BAB

                Return MeleeModifier

            End Get
        End Property

        'get the ranged attack modifier for this character
        Public ReadOnly Property BABRanged(Optional ByVal IncludeShieldProf As Boolean = False) As Integer
            Get
                Dim RangedModifier As Integer = 0
                Dim WisMod As Integer

                'ability modifier
                If Components.SystemAbilities(References.WisdomRangedAttack) Then
                    WisMod = AbilityScores.AbilityScore(CurrentLevel.WIS).Modifier
                Else
                    WisMod = -999
                End If

                If NonDex Then
                    RangedModifier = Math.Max(-999, WisMod)
                Else
                    RangedModifier = Math.Max(DexterityModifier, WisMod)
                End If

                'if no dex and no possibility of zen archery then cannot make a ranged attack
                If RangedModifier = -999 Then Return -1

                'size
                RangedModifier += SizeModifier

                'proficencies
                Dim Proficiency As New RPGXplorer.Rules.Proficiency(Me)

                If Not _Inventory Is Nothing Then

                    If _Inventory.ArmorWorn.IsNotEmpty Then
                        If Proficiency.Proficient(_Inventory.ArmorProperties.BaseArmor, _Inventory.ArmorProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then
                            RangedModifier += _Inventory.ArmorProperties.CheckPenalty
                        End If
                    End If

                    If IncludeShieldProf Then
                        If _Inventory.ShieldWorn.IsNotEmpty Then
                            If Proficiency.Proficient(_Inventory.ShieldProperties.BaseArmor, _Inventory.ShieldProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then
                                RangedModifier += _Inventory.ShieldProperties.CheckPenalty
                            End If
                        End If
                    End If

                End If

                'modifiers
                RangedModifier += Modifiers.AttackRoll

                'BAB
                RangedModifier += BAB

                Return RangedModifier

            End Get
        End Property

        'melee base attack bonus
        'Public ReadOnly Property BABMelee(Optional ByVal IncludeShieldProf As Boolean = False) As Integer
        '    Get
        '        Dim CheckPenalty As Integer = 0

        '        If IncludeShieldProf Then
        '            If Not _Inventory Is Nothing Then
        '                If _Inventory.ShieldWorn.IsNotEmpty Then
        '                    Dim Proficiency As New RPGXplorer.Rules.Proficiency(Me)
        '                    If Proficiency.Proficient(_Inventory.ShieldProperties.BaseArmor, _Inventory.ShieldProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then
        '                        CheckPenalty = _Inventory.ShieldProperties.CheckPenalty
        '                    End If
        '                End If
        '            End If
        '        End If

        '        Return CurrentLevel.BAB + StrengthModifier + SizeModifier + Modifiers.AttackRoll + CheckPenalty

        '    End Get
        'End Property

        'ranged base attack bonus
        'Public ReadOnly Property BABRanged(Optional ByVal IncludeShieldProf As Boolean = False) As Integer
        '    Get
        '        Dim CheckPenalty As Integer = 0

        '        If IncludeShieldProf Then
        '            If Not _Inventory Is Nothing Then
        '                If _Inventory.ShieldWorn.IsNotEmpty Then
        '                    Dim Proficiency As New RPGXplorer.Rules.Proficiency(Me)
        '                    If Proficiency.Proficient(_Inventory.ShieldProperties.BaseArmor, _Inventory.ShieldProperties.Armor) = Proficiency.ProficiencyLevel.NotProficient Then
        '                        CheckPenalty = _Inventory.ShieldProperties.CheckPenalty
        '                    End If
        '                End If
        '            End If
        '        End If

        '        Return CurrentLevel.BAB + DexterityModifier + SizeModifier + Modifiers.AttackRoll + CheckPenalty

        '    End Get
        'End Property

        'grapple base attack bonus
        Public ReadOnly Property BABGrapple() As Integer
            Get
                Return CurrentLevel.BAB + StrengthModifier + Rules.Size.Size(Size).Grapple + Modifiers.GrappleRoll
            End Get
        End Property

        'unarmed damage (only returns a value if there is improved damage)
        Public ReadOnly Property ImprovedUnarmedDamage() As String
            Get
                Return _ImprovedUnarmedDamage
            End Get
        End Property

#End Region

#Region "Load"

        'overload
        Public Sub Load(ByVal CharacterKey As Objects.ObjectKey)
            Character.Load(CharacterKey)
            Load()
        End Sub

        'overload
        Public Sub Load(ByVal Character As Objects.ObjectData)
            Me.Character = Character
            Load()
        End Sub

        'load the class with data
        Private Sub Load()
            Dim CharacterLevel, ClassLevel As Objects.ObjectData
            'Dim CharacterLevels As Objects.ObjectDataCollection
            Dim SortedList As SortedList
            Dim Level As New Level
            Dim PreviousLevel As New Level
            Dim CasterLevel As CasterLevel
            Try

                XML.Lock = True

                'set the characterType
                Select Case Character.Element("CharacterType")
                    Case "Familiar"
                        _CharacterType = CharacterObjectType.Familiar
                        _Master = Character.GetFKGuid("Master")
                    Case "Animal Companion"
                        _CharacterType = CharacterObjectType.AnimalCompanion
                        _Master = Character.GetFKGuid("Master")
                    Case "Special Mount"
                        _CharacterType = CharacterObjectType.SpecialMount
                        _Master = Character.GetFKGuid("Master")
                    Case "Monster"
                        _CharacterType = CharacterObjectType.Monster
                    Case Else
                        _CharacterType = CharacterObjectType.Character
                End Select

                'update the skills & features
                Me.Skills = New Skills(Me)
                Me.Spells = New Spells(Me)
                Me.Powers = New Powers(Me)
                Me.Features = New Features(Me)
                Me.Domains = New Domains(Me)
                Me.PsionicSpecializations = New PsionicSpecializations(Me)

                Me.Domains.Load()
                Me.PsionicSpecializations.Load()

                Me.ExtraClassSkills = New ExtraClassSkills(Me)
                Me.ExtraClassSkills.Load()

                'Me.NeedPreviousSkillRanks = NeedPreviousSkillRanks

                CharacterClasses = New CharacterClassCollection
                Me.Race = Character.GetFKObject("Race")
                Me.Deity = Character.GetFKObject("Deity")
                Me.Prerequisites = New Rules.Prerequisites(Me)
                Me.SystemPreconditions = New Rules.SystemPreconditions(Me)

                Me.AvailableFeats = New Rules.AvailableFeats(Me)
                Me.AvailableSpellcasters = New Rules.AvailableSpellcasters(Me)

                Me.Modifiers = New Rules.Modifiers(Me)
                Me.Components = New Rules.Components(Me)
                Me.ExtraFeats = New Hashtable

                Me.ComponentsState = ComponentsLoaded.NoneLoaded
                Me.CalculateState = CalculateType.NotCalulated

                If Race.Element("Quadruped") = "Yes" Then
                    _Quadruped = True
                Else
                    _Quadruped = False
                End If

                'load level 0 
                Level0._Character = Me
                Level0.CHA = Character.ElementAsInteger("CHA")
                Level0.CON = Character.ElementAsInteger("CON")
                Level0.DEX = Character.ElementAsInteger("DEX")
                Level0.INT = Character.ElementAsInteger("INT")
                Level0.STR = Character.ElementAsInteger("STR")
                Level0.WIS = Character.ElementAsInteger("WIS")

                'hp
                RawHitPoints = 0

                'load existing character levels
                SortedList = Sorter.LoadSortedList(Character.FirstChildOfType(Objects.CharacterLevelsFolderType).ChildrenOfType(Objects.CharacterLevelType), SortType.NumericSuffix)

                'school choice - saved in a different location
                Dim Choice As New CharacterChoice
                For Each ChoiceMade As Objects.ObjectData In Me.MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType).Children

                    If (General.Mode = AppMode.Full) OrElse (ChoiceMade.ElementAsInteger("LevelAcquired") < 6) Then
                        Select Case ChoiceMade.Type
                            Case "Spell School Specialist Choice"
                                Choice.Clear()
                                Choice.ClassName = ChoiceMade.Element("Class")
                                Choice.ClassGuid = ChoiceMade.GetFKGuid("Class")
                                Choice.Type = ChoiceType.SpecailistSchool
                                Choice.Data = ChoiceMade.Element("School")
                                Choice.DataGuid = ChoiceMade.GetFKGuid("School")
                                Choice.LevelAcquired = ChoiceMade.ElementAsInteger("LevelAcquired")
                                Me.Choices.AddItemWithSubkey(Choice.ClassGuid, Choice.DataGuid, Choice)

                            Case "Spell School Prohibited Choice"
                                Choice.Clear()
                                Choice.ClassName = ChoiceMade.Element("Class")
                                Choice.ClassGuid = ChoiceMade.GetFKGuid("Class")
                                Choice.Type = ChoiceType.SacrificedSchool
                                Choice.Data = ChoiceMade.Element("School")
                                Choice.DataGuid = ChoiceMade.GetFKGuid("School")
                                Choice.LevelAcquired = ChoiceMade.ElementAsInteger("LevelAcquired")
                                Me.Choices.AddItemWithSubkey(Choice.ClassGuid, Choice.DataGuid, Choice)
                        End Select
                    End If
                Next

                'choices
                For Each ChoiceMade As Objects.ObjectData In Me.CharacterObject.FirstChildOfType(Objects.CharacterChoiceFolderType).Children
                    Choice.Clear()

                    If (General.Mode = AppMode.Full) OrElse (ChoiceMade.ElementAsInteger("LevelAcquired") < 6) Then
                        Select Case ChoiceMade.Type
                            Case "Combat Style Choice"
                                Choice.ClassName = ChoiceMade.Element("Class")
                                Choice.ClassGuid = ChoiceMade.GetFKGuid("Class")
                                Choice.Type = ChoiceType.CombatStyle
                                Choice.LevelAcquired = ChoiceMade.ElementAsInteger("LevelAcquired")

                                'want Data to equal the reference element of the FK - not the data
                                Choice.Data = ChoiceMade.GetFKReference("CombatStyle")

                                Choice.DataGuid = ChoiceMade.GetFKGuid("CombatStyle")
                                Me.Choices.AddItemWithSubkey(Choice.ClassGuid, Choice.DataGuid, Choice)

                            Case "Favored Enemy Choice"
                                Choice.Type = ChoiceType.FavoredEnemy
                                Choice.Data = ChoiceMade.Element("Monster")
                                Choice.DataGuid = ChoiceMade.GetFKGuid("Monster")
                                Choice.Bonus = ChoiceMade.ElementAsInteger("Bonus")
                                Choice.LevelAcquired = ChoiceMade.ElementAsInteger("LevelAcquired")
                                Choice.LevelsAssigned = New Hashtable
                                Me.Choices.AddItem(Choice.DataGuid, Choice)

                            Case "Favored Enemy Single Choice"
                                Choice.Type = ChoiceType.FavoredEnemySingle
                                Choice.Data = ChoiceMade.Element("Monster")
                                Choice.DataGuid = ChoiceMade.GetFKGuid("Monster")
                                Choice.Bonus = ChoiceMade.ElementAsInteger("Bonus")
                                Choice.LevelAcquired = ChoiceMade.ElementAsInteger("LevelAcquired")
                                Choice.LevelsAssigned = New Hashtable
                                Me.Choices.AddItem(Choice.DataGuid, Choice)

                            Case "Spellcaster Choice"
                                Choice.Type = ChoiceType.SpellcasterChoice
                                Choice.ClassName = ChoiceMade.Element("Class")
                                Choice.ClassGuid = ChoiceMade.GetFKGuid("Class")
                                Choice.Data = ChoiceMade.Element("SpellcasterClass")
                                Choice.DataGuid = ChoiceMade.GetFKGuid("SpellcasterClass")
                                Choice.LevelAcquired = ChoiceMade.ElementAsInteger("LevelAcquired")
                                Me.PrestigeSpellcasterChoices.AddItem(Choice.DataGuid, Choice, Choice.LevelAcquired)
                        End Select
                    End If
                Next

                'Character levels
                For Each myDE As DictionaryEntry In SortedList
                    CharacterLevel = DirectCast(myDE.Value, Objects.ObjectData)

                    If (General.Mode = AppMode.Full) OrElse (CharacterLevel.ElementAsInteger("CharacterLevel") < 6) Then
                        'ability scores
                        Level.STR = CharacterLevel.ElementAsInteger("STR")
                        Level.DEX = CharacterLevel.ElementAsInteger("DEX")
                        Level.CON = CharacterLevel.ElementAsInteger("CON")
                        Level.INT = CharacterLevel.ElementAsInteger("INT")
                        Level.WIS = CharacterLevel.ElementAsInteger("WIS")
                        Level.CHA = CharacterLevel.ElementAsInteger("CHA")

                        'character level
                        Level.CharacterLevel = CharacterLevel.ElementAsInteger("CharacterLevel")
                        Level.CharacterLevelGuid = CharacterLevel.ObjectGUID

                        'as we are looping through a sorted list, the last character level is the highest
                        Me.CharacterLevel = Level.CharacterLevel
                        Level.ClassName = CharacterLevel.Element("Class")
                        Level.ClassGuid = CharacterLevel.GetFKGuid("Class")
                        Level.ClassLevel = CharacterLevel.ElementAsInteger("ClassLevel")
                        Level.ClassLevelGuid = CharacterLevel.GetFKGuid("ClassLevel")

                        'keep a record of which classes character has
                        If Not CharacterClasses.Contains(Level.ClassGuid) Then CharacterClasses.Add(Level.ClassGuid)

                        'hitPoints
                        Level.HitPointRoll = CharacterLevel.ElementAsNumber("HitPointRoll")
                        Level.HitDice = CharacterLevel.ElementAsInteger("HitDice")
                        RawHitPoints += Level.HitPointRoll

                        'saving throws and BAB
                        ClassLevel = CharacterLevel.GetFKObject("ClassLevel")

                        Fortitude += ClassLevel.ElementAsInteger("FortitudeSaveBonus")
                        Reflex += ClassLevel.ElementAsInteger("ReflexSaveBonus")
                        Will += ClassLevel.ElementAsInteger("WillSaveBonus")
                        BAB1 += ClassLevel.ElementAsInteger("BaseAttackBonus")

                        Level.BAB = BAB1
                        Level.Fortitude = Fortitude
                        Level.Reflex = Reflex
                        Level.Will = Will

                        'caster level
                        Dim CasterLevelArray As CasterLevel()

                        If Level.CharacterLevel = 1 Then
                            Level.CasterLevels = New Hashtable(5)
                            'add any racial caster/manifester class
                            Dim RaceCasterKey As Objects.ObjectKey = RaceObject.GetFKGuid("CasterSource")
                            If RaceCasterKey.IsNotEmpty Then
                                CasterLevelArray = Rules.CasterLevel.GetRacialCasterLevel(Me, RaceCasterKey)
                                If CasterLevelArray.Length > 0 Then
                                    Level.CasterLevels.Item(RaceCasterKey) = CasterLevelArray(0)
                                End If

                                'add the racial caster class 
                                If Not CharacterClasses.Contains(RaceCasterKey) Then CharacterClasses.Add(RaceCasterKey)
                            End If
                        Else
                            Level.CasterLevels = DirectCast(PreviousLevel.CasterLevels.Clone, Hashtable)
                        End If

                        CasterLevelArray = Rules.CasterLevel.GetCasterLevel(Me, Level)
                        For Each CasterLevel In CasterLevelArray
                            If Level.CasterLevels.Contains(CasterLevel.ClassGuid) Then
                                Level.CasterLevels.Item(CasterLevel.ClassGuid) = CasterLevel
                            Else
                                Level.CasterLevels.Add(CasterLevel.ClassGuid, CasterLevel)
                            End If
                        Next

                        Level._Character = Me
                        _Levels.Add(Level)
                        PreviousLevel = Level.Clone(Level, Me)
                    End If
                Next

                'set the first new level variable - this is very important for the levelling wizard. It is updated again at the very end of the wizard.
                FirstNewLevel = _Levels.Count + 1

                'feats 
                Dim Feat As New Feat
                For Each FeatTaken As Objects.ObjectData In Me.CharacterObject.FirstChildOfType(Objects.FeatFolderType).Children
                    If (General.Mode = AppMode.Full) OrElse (FeatTaken.ElementAsInteger("CharacterLevel") < 6) Then
                        Dim FocusName As String = ""
                        Dim FocusKey As Objects.ObjectKey
                        FocusKey = FeatTaken.GetFKGuid("Focus")

                        'grapple and ray 
                        If FocusKey.IsNotEmpty Then
                            Select Case FocusKey.ToString
                                Case References.Grapple.ToString
                                    FocusName = "Grapple"
                                Case References.Ray.ToString
                                    FocusName = "Ray"
                                Case References.RangedSpell.ToString
                                    FocusName = "Ranged Spell"
                                Case References.TouchSpell.ToString
                                    FocusName = "Touch Spell"
                                Case References.LawfulGood.ToString
                                    FocusName = "Lawful Good"
                                Case References.LawfulNeutral.ToString
                                    FocusName = "Lawful Neutral"
                                Case References.LawfulEvil.ToString
                                    FocusName = "Lawful Evil"
                                Case References.NeutralGood.ToString
                                    FocusName = "Neutral Good"
                                Case References.TrueNeutral.ToString
                                    FocusName = "True Neutral"
                                Case References.NeutralEvil.ToString
                                    FocusName = "Neutral Evil"
                                Case References.ChaoticGood.ToString
                                    FocusName = "Chaotic Good"
                                Case References.ChaoticNeutral.ToString
                                    FocusName = "Chaotic Neutral"
                                Case References.ChaoticEvil.ToString
                                    FocusName = "Chaotic Evil"
                                Case Else
                                    FocusName = FeatTaken.Element("Focus")
                            End Select
                        End If

                        If (FocusKey.IsEmpty AndAlso Feats.ContainsKey(FeatTaken.GetFKGuid("Feat")) = False) OrElse ((FocusKey.IsNotEmpty) AndAlso Feats.ContainsSubkey(FeatTaken.GetFKGuid("Feat"), FocusKey) = False) OrElse (FeatTaken.GetFKObject("Feat").Element("Stacks") = "Yes") Then
                            Feat.Clear()
                            Feat.FeatGuid = FeatTaken.GetFKGuid("Feat")
                            Feat.FeatName = FeatTaken.Element("Feat")
                            Feat.FeatType = FeatTaken.Element("FeatType")
                            Feat.LevelTaken = FeatTaken.ElementAsInteger("CharacterLevel")
                            If FeatTaken.Element("IgnorePrerequisites") = "Yes" Then Feat.IgnorePrerequisites = True Else Feat.IgnorePrerequisites = False
                            If FeatTaken.Element("Disabled") = "Yes" Then Feat.Disabled = True Else Feat.Disabled = False
                            Feat.FeatSlotSource = FeatTaken.Element("SourceType")
                            Feat.SourceGuid = FeatTaken.GetFKGuid("Source")
                            Feat.SourceName = FeatTaken.Element("Source")
                            If FocusKey.IsEmpty Then
                                Feats.AddItem(Feat.FeatGuid, Feat, Feat.LevelTaken)
                            ElseIf FocusKey.Equals(RPGXplorer.References.CustomFeatFocus) Then
                                Feat.FocusGuid = FocusKey
                                Feat.FocusName = FocusName
                                Feats.AddItemWithSubkey(Feat.FeatGuid, FocusName, Feat, Feat.LevelTaken)
                            Else
                                Feat.FocusGuid = FocusKey
                                Feat.FocusName = FocusName
                                Feats.AddItemWithSubkey(Feat.FeatGuid, Feat.FocusGuid, Feat, Feat.LevelTaken)
                            End If
                        End If
                    End If
                Next

                'arcane Spells
                Spells.Load()

                'powers
                Powers.Load()

                'defined skills
                Dim SkillGuid As Objects.ObjectKey
                Dim SkillRank As Rules.Character.SkillRank

                For Each Skill As Objects.ObjectData In Caches.Skills
                    SkillRank.SkillGuid = Skill.ObjectGUID
                    SkillRank.SkillName = Skill.Name
                    SkillRank.SkillGroup = Skill.Element("SkillGroup")
                    SkillRank.Ranks = 0
                    SkillRank.Mods = 0
                    SkillRank.AssignedRanks = New Hashtable
                    SkillRanks.Add(Skill.ObjectGUID, SkillRank)
                Next

                'skill Points spent
                For Each Skill As Objects.ObjectData In Me.CharacterObject.FirstChildOfType(Objects.SkillFolderType).Children

                    SkillGuid = Skill.GetFKGuid("Skill")
                    SkillRank = DirectCast(SkillRanks(SkillGuid), SkillRank)

                    If General.Mode = AppMode.Full Then

                        SkillRank.Ranks = Skill.ElementAsNumber("Rank")

                        'add in level rank assingments if required
                        Dim ElementString As String
                        Dim LevelRanks As Double
                        For i As Integer = 0 To Rules.Constants.MaxLevels
                            ElementString = "Level" & i.ToString
                            LevelRanks = Skill.ElementAsNumber(ElementString)
                            If LevelRanks > 0 Then
                                SkillRank.AssignedRanks.Add(i, LevelRanks)
                            End If
                        Next
                    Else
                        Dim ElementString As String
                        Dim LevelRanks As Double
                        Dim TotalRestricted As Double = 0
                        For i As Integer = 1 To 5
                            ElementString = "Level" & i.ToString
                            LevelRanks = Skill.ElementAsNumber(ElementString)
                            If LevelRanks > 0 Then
                                TotalRestricted += LevelRanks
                                SkillRank.AssignedRanks.Add(i, LevelRanks)
                            End If
                        Next
                        SkillRank.Ranks = TotalRestricted

                    End If

                    SkillRanks.Item(SkillGuid) = SkillRank
                Next

                'languages
                Dim Language As Language
                For Each LanguageKnown As Objects.ObjectData In Me.CharacterObject.FirstChildOfType(Objects.LanguageFolderType).Children
                    If (General.Mode = AppMode.Full) OrElse (LanguageKnown.ElementAsInteger("CharacterLevel") < 6) Then
                        Language.LanguageName = LanguageKnown.Name
                        Language.LanguageGuid = LanguageKnown.GetFKGuid("Language")
                        Language.LevelGained = LanguageKnown.ElementAsInteger("LevelAcquired")
                        Me.Languages.Item(Language.LanguageGuid) = Language
                    End If
                Next

                'add features 
                For Each FeatureGained As Objects.ObjectData In Me.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children
                    If (General.Mode = AppMode.Full) OrElse (FeatureGained.ElementAsInteger("CharacterLevel") < 6) Then

                        'get the feature structure
                        Dim Feature As New Feature
                        Feature.Load(FeatureGained)

                        'add the feature
                        If Features.CanTakeFeature(Feature.FeatureGuid, Feature.ClassGuid) Then
                            Features.AddFeature(Feature)
                        End If
                    End If
                Next

                'add any pets this character has      
                Select Case Me.CharacterObject.ObjectGUID.Database
                    Case XML.DBTypes.Monsters
                        For Each CharacterObject As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Monsters, Objects.MonsterType)
                            If CharacterObject.GetFKGuid("Master").Equals(Me.CharacterObject.ObjectGUID) Then
                                If CharacterObject.Element("CharacterType") = "Familiar" Then
                                    Familiars.Add(CharacterObject.ObjectGUID)
                                End If
                            End If
                        Next
                    Case XML.DBTypes.Characters
                        For Each CharacterObject As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Characters, Objects.CharacterType)
                            If CharacterObject.GetFKGuid("Master").Equals(Me.CharacterObject.ObjectGUID) Then
                                If CharacterObject.Element("CharacterType") = "Familiar" Then
                                    Familiars.Add(CharacterObject.ObjectGUID)
                                End If
                            End If
                        Next
                End Select

                XML.Lock = False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#End Region

#Region "Character Commands"

        'add a level
        Public Sub AddLevel(ByVal PointAssignment As LevellingUpWizard.PointAssignment, ByVal CharacterClass As CharacterClass, ByVal HitPointRoll As Integer, ByVal ClassLevel As Integer)
            Dim Level As New Character.Level
            Dim CasterLevel As Character.CasterLevel
            Dim ClassLevelObj As Objects.ObjectData

            Try
                Level._Character = Me

                ClassLevelObj = CharacterClass.ClassLevel(ClassLevel)

                'set the ability scores
                If Me.CharacterLevel = 0 Then
                    Level.CharacterLevel = 1
                    Level.STR = Me.CharacterObject.ElementAsInteger("STR")
                    Level.DEX = Me.CharacterObject.ElementAsInteger("DEX")
                    Level.CON = Me.CharacterObject.ElementAsInteger("CON")
                    Level.INT = Me.CharacterObject.ElementAsInteger("INT")
                    Level.WIS = Me.CharacterObject.ElementAsInteger("WIS")
                    Level.CHA = Me.CharacterObject.ElementAsInteger("CHA")
                    Level.CasterLevels = New Hashtable(20)
                Else
                    Level = Me.Levels(Me.CharacterLevel)
                    Level.CharacterLevel += 1
                    Select Case PointAssignment.AbilityRaised
                        Case "STR"
                            Level.STR = Level.STR(True) + 1
                        Case "DEX"
                            Level.DEX = Level.DEX(True) + 1
                        Case "CON"
                            Level.CON = Level.CON(True) + 1
                        Case "INT"
                            Level.INT = Level.INT(True) + 1
                        Case "WIS"
                            Level.WIS = Level.WIS(True) + 1
                        Case "CHA"
                            Level.CHA = Level.CHA(True) + 1
                    End Select
                End If

                Me.CharacterLevel += 1

                'character level and BAB 
                BAB1 += ClassLevelObj.ElementAsInteger("BaseAttackBonus")

                Fortitude += ClassLevelObj.ElementAsInteger("FortitudeSaveBonus")
                Reflex += ClassLevelObj.ElementAsInteger("ReflexSaveBonus")
                Will += ClassLevelObj.ElementAsInteger("WillSaveBonus")

                Level.BAB = BAB1
                Level.Fortitude = Fortitude
                Level.Reflex = Reflex
                Level.Will = Will

                'set the class level
                Level.ClassGuid = CharacterClass.ClassObj.ObjectGUID
                Level.ClassLevel = ClassLevel
                Level.ClassName = CharacterClass.ClassObj.Name
                Level.ClassLevelGuid = ClassLevelObj.ObjectGUID

                'set the caster level
                Dim CasterLevelArray As CasterLevel()

                If Level.CharacterLevel = 1 Then
                    'add any racial caster/manifester class
                    Dim RaceCasterKey As Objects.ObjectKey = RaceObject.GetFKGuid("CasterSource")
                    If RaceCasterKey.IsNotEmpty Then
                        CasterLevelArray = Rules.CasterLevel.GetRacialCasterLevel(Me, RaceCasterKey)
                        If CasterLevelArray.Length > 0 Then
                            Level.CasterLevels.Item(RaceCasterKey) = CasterLevelArray(0)
                        End If

                        'add the racial caster class 
                        If Not CharacterClasses.Contains(RaceCasterKey) Then CharacterClasses.Add(RaceCasterKey)
                    End If
                Else
                    Level.CasterLevels = DirectCast(Level.CasterLevels.Clone, Hashtable)
                End If

                CasterLevelArray = Rules.CasterLevel.GetCasterLevel(Me, Level)
                For Each CasterLevel In CasterLevelArray
                    If Level.CasterLevels.Contains(CasterLevel.ClassGuid) Then
                        Level.CasterLevels(CasterLevel.ClassGuid) = CasterLevel
                    Else
                        Level.CasterLevels.Add(CasterLevel.ClassGuid, CasterLevel)
                    End If
                Next

                'Hit points
                Level.HitPointRoll = HitPointRoll

                'add racial features and abilities
                If Me.CharacterLevel = 1 Then

                    Dim TempClone As Objects.ObjectData
                    For Each Child As Objects.ObjectData In RaceObject.Children
                        Select Case Child.Type
                            Case Objects.FeatureType
                                If Features.CanTakeFeature(Child.GetFKGuid("Feature"), Level.ClassGuid) Then
                                    Features.AddFeature(Child.GetFKGuid("Feature"), Level.ClassName, Level.ClassGuid, 1, RaceObject.ObjectGUID, RaceObject.Name)
                                End If
                            Case Objects.SpellLikeAbilityType
                                TempClone = Child.CloneSingle(Me.SpellLikeAbilityFolder)
                                TempClone.Type = Objects.SpellLikeAbilityTakenType
                                TempClone.FKElement("Source", RaceObject.Name, "Name", RaceObject.ObjectGUID)
                                TempClone.ElementAsInteger("CharacterLevel") = 1
                                NewSpellLikeAbilities.Add(TempClone)
                            Case Objects.PsiLikeAbilityType
                                TempClone = Child.CloneSingle(Me.PsiLikeAbilityFolder)
                                TempClone.Type = Objects.PsiLikeAbilityTakenType
                                TempClone.FKElement("Source", RaceObject.Name, "Name", RaceObject.ObjectGUID)
                                TempClone.ElementAsInteger("CharacterLevel") = 1
                                NewPsiLikeAbilities.Add(TempClone)
                        End Select
                    Next

                    'if it is a normal class - not a monster class then add first level class features. If it is a companion, then it is not taking Monster Type class levels so this does not apply
                    If ClassLevelObj.ObjectGUID.Database = XML.DBTypes.Classes OrElse (Me.CharacterType <> CharacterObjectType.Character AndAlso Me.CharacterType <> CharacterObjectType.Monster) Then

                        For Each Child As Objects.ObjectData In ClassLevelObj.Children
                            Select Case Child.Type
                                Case Objects.FeatureType
                                    If ClassLevelObj.ObjectGUID.Database = XML.DBTypes.Classes OrElse (Me.CharacterType <> CharacterObjectType.Character AndAlso Me.CharacterType <> CharacterObjectType.Monster) Then
                                        If Features.CanTakeFeature(Child.GetFKGuid("Feature"), Level.ClassGuid) Then
                                            Features.AddFeature(Child.GetFKGuid("Feature"), Level.ClassName, Level.ClassGuid, Level.CharacterLevel, ClassLevelObj.ObjectGUID, ClassLevelObj.Name)
                                        End If
                                    End If
                                Case Objects.SpellLikeAbilityType
                                    TempClone = Child.CloneSingle(Me.SpellLikeAbilityFolder)
                                    TempClone.FKElement("Source", ClassLevelObj.Name, "Name", ClassLevelObj.ObjectGUID)
                                    TempClone.ElementAsInteger("CharacterLevel") = 1
                                    NewSpellLikeAbilities.Add(TempClone)
                                Case Objects.PsiLikeAbilityType
                                    TempClone = Child.CloneSingle(Me.PsiLikeAbilityFolder)
                                    TempClone.FKElement("Source", ClassLevelObj.Name, "Name", ClassLevelObj.ObjectGUID)
                                    TempClone.ElementAsInteger("CharacterLevel") = 1
                                    NewPsiLikeAbilities.Add(TempClone)
                            End Select
                        Next
                    Else
                        For Each Child As Objects.ObjectData In ClassLevelObj.Children
                            Select Case Child.Type
                                Case Objects.SpellLikeAbilityType
                                    TempClone = Child.CloneSingle(Me.SpellLikeAbilityFolder)
                                    TempClone.FKElement("Source", ClassLevelObj.Name, "Name", ClassLevelObj.ObjectGUID)
                                    TempClone.ElementAsInteger("CharacterLevel") = 1
                                    NewSpellLikeAbilities.Add(TempClone)
                                Case Objects.PsiLikeAbilityType
                                    TempClone = Child.CloneSingle(Me.PsiLikeAbilityFolder)
                                    TempClone.FKElement("Source", ClassLevelObj.Name, "Name", ClassLevelObj.ObjectGUID)
                                    TempClone.ElementAsInteger("CharacterLevel") = 1
                                    NewPsiLikeAbilities.Add(TempClone)
                            End Select
                        Next
                    End If
                Else
                    'if it is any other level, just add the class features 
                    Dim TempClone As Objects.ObjectData
                    For Each Child As Objects.ObjectData In ClassLevelObj.Children
                        Select Case Child.Type
                            Case Objects.FeatureType
                                If ClassLevelObj.ObjectGUID.Database = XML.DBTypes.Classes OrElse (Me.CharacterType <> CharacterObjectType.Character AndAlso Me.CharacterType <> CharacterObjectType.Monster) Then
                                    If Features.CanTakeFeature(Child.GetFKGuid("Feature"), Level.ClassGuid) Then
                                        Features.AddFeature(Child.GetFKGuid("Feature"), Level.ClassName, Level.ClassGuid, Level.CharacterLevel, ClassLevelObj.ObjectGUID, ClassLevelObj.Name)
                                    End If
                                End If
                            Case Objects.SpellLikeAbilityType
                                TempClone = Child.CloneSingle(Me.SpellLikeAbilityFolder)
                                TempClone.FKElement("Source", ClassLevelObj.Name, "Name", ClassLevelObj.ObjectGUID)
                                TempClone.ElementAsInteger("CharacterLevel") = Me.CharacterLevel
                                NewSpellLikeAbilities.Add(TempClone)
                            Case Objects.PsiLikeAbilityType
                                TempClone = Child.CloneSingle(Me.PsiLikeAbilityFolder)
                                TempClone.FKElement("Source", ClassLevelObj.Name, "Name", ClassLevelObj.ObjectGUID)
                                TempClone.ElementAsInteger("CharacterLevel") = Me.CharacterLevel
                                NewPsiLikeAbilities.Add(TempClone)
                        End Select
                    Next

                End If

                'Add the level
                Me._Levels.Add(Level)
                If Not CharacterClasses.Contains(Level.ClassGuid) Then CharacterClasses.Add(Level.ClassGuid)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'deletes character levels
        Public Shared Sub DeleteLevels(ByVal CharacterObject As Objects.ObjectData, ByVal Levels As Objects.ObjectDataCollection, ByVal HighestLevelNumber As Integer, ByVal NumberOfLevelsToDelete As Integer)
            Dim TempObject As Objects.ObjectData
            Dim LevelNumber As Integer
            Dim DeletedClasses As New Objects.ObjectDataCollection
            Dim DeletedFolderGuids As New ArrayList

            'delete anything higher than this level
            LevelNumber = HighestLevelNumber - NumberOfLevelsToDelete

            'feats
            For Each TempObject In CharacterObject.FirstChildOfType(Objects.FeatFolderType).Children
                If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then
                    TempObject.Delete()
                End If
            Next

            'features
            For Each TempObject In CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children
                If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then
                    TempObject.Delete()
                End If
            Next

            'languages
            For Each TempObject In CharacterObject.FirstChildOfType(Objects.LanguageFolderType).Children
                If TempObject.ElementAsInteger("LevelAcquired") > LevelNumber Then
                    TempObject.Delete()
                End If
            Next

            'choices
            For Each TempObject In CharacterObject.FirstChildOfType(Objects.CharacterChoiceFolderType).Children
                If TempObject.ElementAsInteger("LevelAcquired") > LevelNumber Then
                    TempObject.Delete()
                Else
                    'check for Favored Enemy bonus point assignments
                    For i As Integer = LevelNumber + 1 To HighestLevelNumber
                        If TempObject.ElementAsInteger("Level" & i.ToString) > 0 Then
                            Dim CurrentBonus As Integer = TempObject.ElementAsInteger("Bonus")
                            CurrentBonus -= TempObject.ElementAsInteger("Level" & i.ToString)
                            TempObject.Element("Bonus") = CurrentBonus.ToString
                            TempObject.Element("Level" & i.ToString) = "0"
                            TempObject.Element("Name") = Rules.Formatting.FormatModifier(CurrentBonus) & " vs. " & TempObject.Element("Monster")
                        End If
                    Next
                End If
            Next

            'skills
            For Each TempObject In CharacterObject.FirstChildOfType(Objects.SkillFolderType).Children
                For i As Integer = LevelNumber + 1 To HighestLevelNumber
                    If TempObject.ElementAsNumber("Level" & i.ToString) > 0 Then
                        Dim CurrentRank As Double = TempObject.ElementAsNumber("Rank")
                        CurrentRank -= TempObject.ElementAsNumber("Level" & i.ToString)
                        TempObject.Element("Rank") = CurrentRank.ToString
                        TempObject.Element("Level" & i.ToString) = "0"
                    End If
                Next
            Next

            'levels
            Dim RaceObject As Objects.ObjectData = CharacterObject.GetFKObject("Race")
            For Each TempObject In Levels
                If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then

                    'store the Class Object if this class has been fully removed from the character
                    If TempObject.ElementAsInteger("ClassLevel") = 1 Then
                        Dim ClassObject As Objects.ObjectData
                        ClassObject = TempObject.GetFKObject("Class")

                        Dim RacialOffset As Integer = 0
                        If ClassObject.ObjectGUID.Equals(RaceObject.GetFKGuid("CasterSource")) Then
                            RacialOffset = RaceObject.ElementAsInteger("CasterLevel")
                        End If

                        If LevelNumber = 0 OrElse RacialOffset = 0 Then
                            DeletedClasses.Add(ClassObject)
                        End If

                    End If
                    TempObject.Delete()
                End If
            Next

            'if we have deleted all the levels, make sure we have added the racial caster class
            If LevelNumber = 0 Then
                Dim ClassObject As Objects.ObjectData = RaceObject.GetFKObject("CasterSource")
                If ClassObject.ObjectGUID.IsNotEmpty Then
                    If Not DeletedClasses.Contains(ClassObject.ObjectGUID) Then
                        DeletedClasses.Add(ClassObject)
                    End If
                End If
            End If

            Dim MagicFolder As Objects.ObjectData = CharacterObject.FirstChildOfType(Objects.MagicFolderType)
            If MagicFolder.ObjectGUID.IsNotEmpty Then

                'Spells
                Dim SpellFolders As Objects.ObjectDataCollection = MagicFolder.ChildrenOfType(Objects.ClassSpellListFolderType)
                For Each ClassSpellListFolder As Objects.ObjectData In SpellFolders
                    For Each TempObject In ClassSpellListFolder.Children
                        If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then
                            TempObject.Delete()
                        End If
                    Next
                Next

                'Spell Like Abilities
                Dim SpellLikeFolder As Objects.ObjectData = MagicFolder.FirstChildOfType(Objects.SpellLikeAbilityFolderType)
                If SpellLikeFolder.ObjectGUID.IsNotEmpty Then
                    For Each TempObject In SpellLikeFolder.Children
                        If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then
                            TempObject.Delete()
                        End If
                    Next
                End If

                'delete spell folders for any removed classes
                Dim RemainingMemorizedCaster As Boolean = False
                For Each TempSpellFolder As Objects.ObjectData In MagicFolder.Children
                    If DeletedClasses.Contains(TempSpellFolder.GetFKGuid("Class")) Then
                        DeletedFolderGuids.Add(TempSpellFolder.ObjectGUID)
                        TempSpellFolder.Delete()
                    Else
                        'if this class is a memorized caster then at least one remains and we keep the folder
                        Dim ClassObj As Objects.ObjectData = TempSpellFolder.GetFKObject("Class")
                        If ClassObj.Element("MemorizeSpells") = "True" Then
                            RemainingMemorizedCaster = True
                        End If
                    End If
                Next

                'delete the memorized folder if its not required
                If Not RemainingMemorizedCaster Then
                    Dim Memfolder As Objects.ObjectData = MagicFolder.FirstChildOfType(Objects.MemorizedSpellsFolderType)
                    If Memfolder.ObjectGUID.IsNotEmpty Then
                        DeletedFolderGuids.Add(Memfolder.ObjectGUID)
                        Memfolder.Delete()
                    End If
                End If

                'domains and schools
                Dim DomainFolder As Objects.ObjectData = MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType)
                If DomainFolder.ObjectGUID.IsNotEmpty Then
                    'delete the folder if no longer required
                    If LevelNumber < 1 Or MagicFolder.Children.Count = 1 Then
                        DomainFolder.Delete()
                        DeletedFolderGuids.Add(DomainFolder.ObjectGUID)
                    Else
                        For Each TempObject In DomainFolder.Children
                            If TempObject.ElementAsInteger("LevelAcquired") > LevelNumber Then
                                TempObject.Delete()
                            End If
                        Next
                    End If
                End If

            End If

            ''''''''''psionics
            Dim PsionicFolder As Objects.ObjectData = CharacterObject.FirstChildOfType(Objects.PsionicFolderType)
            If PsionicFolder.ObjectGUID.IsNotEmpty Then

                'Powers
                Dim PowerFolders As Objects.ObjectDataCollection = PsionicFolder.ChildrenOfType(Objects.ClassPowerListFolderType)
                For Each ClassPowerListFolder As Objects.ObjectData In PowerFolders
                    For Each TempObject In ClassPowerListFolder.Children
                        If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then
                            TempObject.Delete()
                        End If
                    Next
                Next

                'Psi Like Abilities
                Dim PsiLikeFolder As Objects.ObjectData = PsionicFolder.FirstChildOfType(Objects.PsiLikeAbilityFolderType)
                If PsiLikeFolder.ObjectGUID.IsNotEmpty Then
                    For Each TempObject In PsiLikeFolder.Children
                        If TempObject.ElementAsInteger("CharacterLevel") > LevelNumber Then
                            TempObject.Delete()
                        End If
                    Next
                End If

                'psionic specializations
                Dim SpecializationFolder As Objects.ObjectData = PsionicFolder.FirstChildOfType(Objects.PsionicSpecializationFolderType)
                If SpecializationFolder.ObjectGUID.IsNotEmpty Then
                    For Each TempObject In SpecializationFolder.Children
                        If TempObject.ElementAsInteger("LevelAcquired") > LevelNumber Then
                            TempObject.Delete()
                        End If
                    Next

                    'delete the folder if no longer required
                    If LevelNumber < 1 Then
                        SpecializationFolder.Delete()
                        DeletedFolderGuids.Add(SpecializationFolder.ObjectGUID)
                    End If
                End If

                'delete power folders for any removed classes
                For Each TempObject In DeletedClasses
                    If TempObject.Element("CasterAbility") = "Psionic" Then

                        'delete the Power List/Settings folders for this class
                        For Each TempPowerFolder As Objects.ObjectData In PsionicFolder.Children
                            If TempPowerFolder.GetFKGuid("Class").Equals(TempObject.ObjectGUID) Then
                                DeletedFolderGuids.Add(TempPowerFolder.ObjectGUID)
                                TempPowerFolder.Delete()
                            End If
                        Next
                    End If
                Next
            End If

            'remove deleted treenodes
            Dim TreeNode As TreeNode
            General.MainExplorer.TreeView.BeginUpdate()
            For Each DeletedFolderGuid As Objects.ObjectKey In DeletedFolderGuids
                TreeNode = DirectCast(General.MainExplorer.TreeNodes(DeletedFolderGuid), TreeNode)
                If Not TreeNode Is Nothing Then
                    TreeNode.Remove()
                    General.MainExplorer.TreeNodes.Remove(DeletedFolderGuid)
                End If
            Next
            General.MainExplorer.TreeView.EndUpdate()

            'remove folders from MDI
            WindowManager.RemoveAndUpdate(Nothing, DeletedFolderGuids)

        End Sub

        'update the character in the database
        Public Sub UpdateSavedLevel(ByVal Level As Rules.Character.Level)
            Dim Levels As Objects.ObjectDataCollection

            'Find and replace the level object
            Levels = Character.FirstChildOfType(Objects.CharacterLevelsFolderType).Children()

            For Each TempObj As Objects.ObjectData In Levels
                If TempObj.ElementAsInteger("CharacterLevel") = Level.CharacterLevel Then
                    TempObj.Delete()
                    Level.CreateCharacterLevel().Save()
                    Exit For
                End If
            Next
        End Sub

        'update skill mods
        Public Sub UpdateSkillMods()
            Dim SkillRank As SkillRank
            Dim TempTable As New ObjectHashtable()

            'refresh cached mods
            Skills.SkillAbilityScoresRefresh()

            For Each Item As DictionaryEntry In SkillRanks
                SkillRank = DirectCast(Item.Value, SkillRank)
                SkillRank.Mods = Skills.SkillModifier(SkillRank.SkillGuid)
                TempTable.Add(SkillRank.SkillGuid, SkillRank)
            Next

            For Each SkillRank In TempTable.Values
                SkillRanks.Item(SkillRank.SkillGuid) = SkillRank
            Next

        End Sub

        'save the characters magic folder
        Public Sub MagicFolderSave()
            Try
                _MagicFolder.Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save the characters psionic folder
        Public Sub PsionicFolderSave()
            Try
                _PsionicFolder.Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save the characters spell like folder
        Public Sub SpellLikeFolderSave()
            Try
                _MagicFolder.Save()
                _SpellLikeFolder.Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save the characters psi like folder
        Public Sub PsiLikeFolderSave()
            Try
                _PsionicFolder.Save()
                _PsiLikeFolder.Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save the Memorized Spells folder
        Public Sub MemorizedSpellsFolderSave()
            Try
                _MagicFolder.Save()
                _MemorizedSpellsFolder.Save()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'updates the skill ranks of this character if it is a familiar
        Public Sub UpdateFamiliarSkillRanks()

            If Me.CharacterType = CharacterObjectType.Familiar Then

                'get Classskills from race        
                Dim ClassSkills As Objects.ObjectDataCollection = RaceObject.ChildrenOfType(Objects.ClassSkillType)
                Dim MyRanksTable As New ObjectHashtable(ClassSkills.Count)

                'load them into lookup table
                For Each ClassSkill As Objects.ObjectData In ClassSkills
                    MyRanksTable.Item(ClassSkill.GetFKGuid("Skill")) = ClassSkill.ElementAsInteger("Ranks")
                Next

                'load Master character
                Dim Master As New Character
                Master = CharacterManager.GetCharacter(Me.CharacterObject.GetFKGuid("Master"))

                For Each TempObject As Objects.ObjectData In CharacterObject.FirstChildOfType(Objects.SkillFolderType).Children
                    'get the current level 0 rank
                    Dim CurrentLevel0Rank As Double = TempObject.ElementAsNumber("Level0")

                    Dim MasterSkillRank As SkillRank
                    Dim MasterRanks, MyRanks, BiggestRanks As Double

                    'get the master skill rank and own racial ranks
                    MasterSkillRank = Master.Skill(TempObject.GetFKGuid("Skill"))
                    MasterRanks = MasterSkillRank.Ranks
                    MyRanks = CDbl(MyRanksTable.Item(TempObject.GetFKGuid("Skill")))

                    'get the largest
                    BiggestRanks = Math.Max(MyRanks, MasterRanks)

                    'find the difference
                    Dim Difference As Double = BiggestRanks - CurrentLevel0Rank

                    TempObject.ElementAsNumber("Level0") = BiggestRanks
                    TempObject.ElementAsNumber("Rank") = TempObject.ElementAsNumber("Rank") + Difference
                Next
            End If

        End Sub

        'generate memorized spells
        Public Sub GenerateMemorizedSpells()
            Try
                Dim ClassKey As Objects.ObjectKey
                Dim ClassInfo As Rules.CharacterClass

                '''''''get all the existing memorized spell objects
                Dim ExistingMemorizedSpells As New ThreeKeyList
                Dim ExistingObjects As Objects.ObjectDataCollection = MemorizedSpellsFolder.Children

                '''''''find all the required casters
                Dim SpellCasters As New ObjectHashtable

                'get racial caster
                If RaceObject.Element("CasterType") = "Spellcaster" Then
                    ClassKey = RaceObject.GetFKGuid("CasterSource")
                    If Not ClassKey.IsEmpty Then
                        ClassInfo = CharacterClasses(ClassKey)
                        If ClassInfo.CasterInfo.MemorizeSpells Then SpellCasters.Add(ClassKey, ClassInfo)
                    End If
                End If

                'get class casters
                For Each ClassKey In CharacterClassKeys()
                    ClassInfo = CharacterClasses(ClassKey)
                    If ClassInfo.CasterInfo.MemorizeSpells Then SpellCasters.Item(ClassKey) = ClassInfo
                Next

                ''''''update/generate new memorized spells or delete existing ones
                If SpellCasters.Count > 0 Then

                    'make sure the memorized spells folder is there
                    MemorizedSpellsFolderSave()

                    'make sure I have a tree node
                    If General.MainExplorer.TreeNodes(Me.MagicFolder.ObjectGUID) Is Nothing Then
                        'create magic folder
                        General.MainExplorer.InsertNode(DirectCast(General.MainExplorer.TreeNodes(Me.CharacterObject.ObjectGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(MagicFolder))
                    ElseIf General.MainExplorer.TreeNodes(Me.MemorizedSpellsFolder.ObjectGUID) Is Nothing Then
                        General.MainExplorer.InsertNode(DirectCast(General.MainExplorer.TreeNodes(Me.MagicFolder.ObjectGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(MemorizedSpellsFolder))
                    End If

                    'organize any existing memorized spell objects
                    If ExistingObjects.Count > 0 Then
                        Dim LevelKey As Integer
                        Dim SlotType As String

                        For Each MemorizedSpell As Objects.ObjectData In ExistingObjects
                            ClassKey = MemorizedSpell.GetFKGuid("Class")
                            LevelKey = MemorizedSpell.ElementAsInteger("Level")
                            SlotType = MemorizedSpell.Element("SlotType")
                            ExistingMemorizedSpells.Add(ClassKey, LevelKey, SlotType, MemorizedSpell)
                        Next
                    End If

                    'cycle through each of the casting classes
                    For Each ClassInfo In SpellCasters.Values
                        ClassKey = ClassInfo.ClassObj.ObjectGUID

                        'get the spells per day info for this caster class
                        Dim SpellSlots As New SpellSlots(Me, ClassKey)
                        SpellSlots.Load()

                        Dim SpellPerDayInfo As SpellSlots.SpellsPerDayInfo = SpellSlots.FinalSpellsPerDay

                        'cylce through each spell level
                        For SpellLevel As Integer = 0 To 9
                            Dim ExistingMemorizedList As ArrayList
                            Dim NewSlotCount As Integer

                            'do the existing standard spells for this level
                            ExistingMemorizedList = ExistingMemorizedSpells.Item(ClassKey, SpellLevel, "Standard")
                            NewSlotCount = CInt(SpellPerDayInfo.Standard(SpellLevel))
                            AddRemoveMemorizedSpells(ClassInfo, SpellLevel, ExistingMemorizedList, NewSlotCount, "Standard")

                            'do the existing domain spells for this level
                            ExistingMemorizedList = ExistingMemorizedSpells.Item(ClassKey, SpellLevel, "Domain")
                            NewSlotCount = CInt(SpellPerDayInfo.Domain(SpellLevel))
                            AddRemoveMemorizedSpells(ClassInfo, SpellLevel, ExistingMemorizedList, NewSlotCount, "Domain")

                            'do the existing specialist spells for this level
                            ExistingMemorizedList = ExistingMemorizedSpells.Item(ClassKey, SpellLevel, "Specialist")
                            NewSlotCount = CInt(SpellPerDayInfo.Specialist(SpellLevel))
                            AddRemoveMemorizedSpells(ClassInfo, SpellLevel, ExistingMemorizedList, NewSlotCount, "Specialist")
                        Next
                    Next

                    'remove memorized spells from any classes that no longer memorize spells
                    For Each ClassKey In ExistingMemorizedSpells.UpperKeys
                        If Not SpellCasters.ContainsKey(ClassKey) Then
                            'iterate through and delete all the objects in this table
                            For Each TempObject As Objects.ObjectData In ExistingMemorizedSpells.Item(ClassKey)
                                TempObject.Delete()
                            Next
                        End If
                    Next

                Else
                    'delete all existing objects
                    ExistingObjects.Delete()
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'adds or removes memorized spell components for the given class and level
        Private Sub AddRemoveMemorizedSpells(ByVal ClassInfo As Rules.CharacterClass, ByVal SpellLevel As Integer, ByVal ExistingMemorizedList As ArrayList, ByVal NewSlotCount As Integer, ByVal SlotType As String)
            Try
                Dim ExistingSlotCount As Integer = ExistingMemorizedList.Count

                If NewSlotCount > ExistingSlotCount Then
                    'add new slots
                    For i As Integer = 1 To (NewSlotCount - ExistingSlotCount)
                        Dim NewMemorizedSpell As New Objects.ObjectData
                        NewMemorizedSpell.Clear()
                        NewMemorizedSpell.ObjectGUID = Objects.ObjectKey.NewGuid(MemorizedSpellsFolder.ObjectGUID.Database)
                        NewMemorizedSpell.ParentGUID = MemorizedSpellsFolder.ObjectGUID
                        NewMemorizedSpell.Type = Objects.MemorizedSpellType
                        NewMemorizedSpell.FKElement("Class", ClassInfo.ClassObj.Name, "Name", ClassInfo.ClassObj.ObjectGUID)
                        NewMemorizedSpell.ElementAsInteger("Level") = SpellLevel
                        NewMemorizedSpell.Element("SlotType") = SlotType
                        NewMemorizedSpell.Save()
                    Next

                ElseIf NewSlotCount < ExistingSlotCount Then
                    'we need to delete some slots
                    If NewSlotCount = 0 Then
                        For Each TempObject As Objects.ObjectData In ExistingMemorizedList
                            TempObject.Delete()
                        Next

                    Else

                        'try to delete empty slots first
                        Dim SemiSortedList As New ArrayList(ExistingSlotCount)

                        'first add all the empty slots
                        For Each TempObject As Objects.ObjectData In ExistingMemorizedList
                            If TempObject.GetFKGuid("Spell").IsEmpty Then
                                SemiSortedList.Add(TempObject)
                            End If
                        Next

                        'then add all the others
                        For Each TempObject As Objects.ObjectData In ExistingMemorizedList
                            If TempObject.GetFKGuid("Spell").IsNotEmpty Then
                                SemiSortedList.Add(TempObject)
                            End If
                        Next

                        'delete as many as required
                        For i As Integer = 1 To (ExistingSlotCount - NewSlotCount)
                            DirectCast(SemiSortedList(i - 1), Objects.ObjectData).Delete()
                        Next

                    End If
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'clone the character
        Public Function Clone(Optional ByVal AnalyseInventory As Boolean = False) As Character
            Dim Temp As Character
            Dim ChoiceList As New ArrayList
            Dim Choice As Rules.Character.CharacterChoice

#If DEBUG Then
            Dim CloneStart As New TimeSpan(DateTime.Now.Ticks)
#End If

            Try
                'Clone the basic vairables
                Temp = DirectCast(MyBase.MemberwiseClone, Character)
                Temp.CharacterClasses = DirectCast(Me.CharacterClasses.Clone, CharacterClassCollection)

                'Levels
                Temp._Levels = New ArrayList
                For Each TempLevel As Level In Me._Levels
                    TempLevel = TempLevel.Clone(TempLevel, Temp)
                    Temp._Levels.Add(TempLevel)
                Next

                'Skills
                For Each TempSkill As SkillRank In Temp.SkillRanks.Values
                    TempSkill.AssignedRanks = DirectCast(TempSkill.AssignedRanks.Clone, Hashtable)
                Next
                Temp.Skills = Me.Skills.Clone(Temp)
                Temp.ExtraClassSkills = Me.ExtraClassSkills.Clone(Temp)

                'Favored Enemies, Combat Styles, Spell School & Domain choices Prestige Spellcasters
                Temp.AvailableSpellcasters = New AvailableSpellcasters(Temp)
                Temp.Choices = Me.Choices.Clone

                ChoiceList = Temp.Choices.ItemData
                For Each LibraryChoiceItem As Library.LibraryData In ChoiceList
                    Choice = DirectCast(LibraryChoiceItem.Data, Rules.Character.CharacterChoice)
                    If Choice.Type = Rules.Character.ChoiceType.FavoredEnemy Then
                        Choice.LevelsAssigned = DirectCast(Choice.LevelsAssigned.Clone, Hashtable)
                    End If
                Next

                'Features
                Temp.Features = Me.Features.Clone(Temp)

                'Feats
                Temp.Feats = Me.Feats.Clone
                Temp.AvailableFeats = New AvailableFeats(Temp)
                Temp.ExtraFeats = DirectCast(Me.ExtraFeats.Clone, Hashtable)

                'domains
                Temp.Domains = Me.Domains.Clone(Temp)

                'psionic specializations
                Temp.PsionicSpecializations = Me.PsionicSpecializations.Clone(Temp)

                'Spells
                Temp.Spells = Me.Spells.Clone(Temp)

                'Powers
                Temp.Powers = Me.Powers.Clone(Temp)

                'System & Modifiers
                Temp.Prerequisites = New Prerequisites(Temp)
                Temp.Modifiers = New Modifiers(Temp)
                Temp.Components = New Components(Temp)
                Temp.SystemPreconditions = New SystemPreconditions(Temp)

                'Update the character
                If AnalyseInventory Then
                    Temp.CalculateInventory()
                Else
                    Temp.Calculate()
                End If

#If DEBUG Then
                Debug.WriteLine("Character.Clone : " & New TimeSpan(DateTime.Now.Ticks).Subtract(CloneStart).TotalSeconds.ToString & " seconds.")
#End If

                Return Temp

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function CreateDefaultInventory(ByVal CalledFirst As Boolean) As ObjectHashtable
            Try

                Dim DoWeapons As Boolean = False
                Dim KeyMap As New ObjectHashtable

                Dim ExistingWeaponConfigs As New ObjectHashtable
                Dim ItemsToDelete As New Objects.ObjectDataCollection

                For Each InventoryItem As Objects.ObjectData In Race.Children

                    Select Case InventoryItem.Type
                        Case Objects.ItemType
                            ItemsToDelete.Add(InventoryItem)
                        Case Objects.MoneyType
                            ItemsToDelete.Add(InventoryItem)
                        Case Objects.WeaponConfigType
                            ExistingWeaponConfigs.Item(InventoryItem.ObjectGUID) = InventoryItem
                    End Select

                Next

                'go through all the existing inventory items
                For Each InventoryItem As Objects.ObjectData In ItemsToDelete

                    'delete any existing Weapon Config objects that have FK to the existing inventory item
                    If XML.FKLookup.ContainsKey(InventoryItem.ObjectGUID) Then
                        For Each FK As Objects.ObjectKey In XML.FKLookup.Subkeys(InventoryItem.ObjectGUID)
                            If ExistingWeaponConfigs.ContainsKey(FK) Then
                                DirectCast(ExistingWeaponConfigs.Item(FK), Objects.ObjectData).Delete()
                            End If
                        Next
                    End If

                    'delete the inventory item
                    InventoryItem.Delete()
                Next

                'clone new items
                For Each InventoryItem As Objects.ObjectData In Inventory.InventoryFolder.Children

                    'is this item a FK in a weapon config?
                    If Not DoWeapons Then
                        If XML.IsForeignKey(InventoryItem.ObjectGUID) Then
                            DoWeapons = True
                        End If
                    End If

                    Select Case InventoryItem.Type
                        Case Objects.ItemType
                            Dim NewInventoryObjects As Objects.ObjectDataCollection
                            NewInventoryObjects = InventoryItem.CloneWithKeyMap(Race, KeyMap)
                            NewInventoryObjects.Save()

                        Case Objects.MoneyType
                            Dim NewInventoryObject As Objects.ObjectData
                            NewInventoryObject = InventoryItem.CloneSingle(Race)
                            NewInventoryObject.Save()
                    End Select

                Next

                'do we need to update the weapons?
                If CalledFirst AndAlso DoWeapons Then
                    Dim WeaponConfigs As New Objects.ObjectDataCollection
                    WeaponConfigs = CreateDefaultWeapons(False)

                    'update forigen keys
                    If WeaponConfigs.Count > 0 Then
                        UpdateDefaultKeys(WeaponConfigs, KeyMap)
                    End If
                End If

                Return KeyMap

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function CreateDefaultWeapons(ByVal CalledFirst As Boolean) As Objects.ObjectDataCollection
            Try

                'delete any existing weapons configs
                For Each WeaponConfigObject As Objects.ObjectData In Race.ChildrenOfType(Objects.WeaponConfigType)
                    WeaponConfigObject.Delete()
                Next

                'add the currents configs
                Dim DoInventory As Boolean
                Dim NewWeaponConfigs As New Objects.ObjectDataCollection

                'clone and copy the weapon configs
                For Each WeaponConfigObject As Objects.ObjectData In Me.CharacterObject.FirstChildOfType(Objects.WeaponConfigFolderType).ChildrenOfType(Objects.WeaponConfigType)

                    'find out if we need to create the default inventory too
                    If Not DoInventory Then
                        For Each Element As String In WeaponConfigObject.GetAllFKElements
                            If Element.Contains("Inventory") Then
                                If WeaponConfigObject.GetFKGuid(Element).IsNotEmpty Then
                                    DoInventory = True
                                    Exit For
                                End If
                            End If
                        Next
                    End If

                    Dim NewWeaponConfigObject As Objects.ObjectData
                    NewWeaponConfigObject = WeaponConfigObject.CloneSingle(Race)
                    NewWeaponConfigObject.Save()
                    NewWeaponConfigs.Add(NewWeaponConfigObject)

                Next

                'if required we need to do the inventroy clone as well
                If CalledFirst AndAlso DoInventory Then
                    'clone the inventory
                    Dim KeyMap As ObjectHashtable
                    KeyMap = CreateDefaultInventory(False)

                    'update forigen keys
                    If NewWeaponConfigs.Count > 0 Then
                        UpdateDefaultKeys(NewWeaponConfigs, KeyMap)
                    End If

                End If

                'return this in case we need it for default inventory
                Return NewWeaponConfigs

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Private Sub UpdateDefaultKeys(ByVal WeaponConfigs As Objects.ObjectDataCollection, ByVal KeyMap As ObjectHashtable)
            Try
                For Each WeaponConfig As Objects.ObjectData In WeaponConfigs
                    For Each Element As String In WeaponConfig.GetAllFKElements
                        Dim FK As Objects.ObjectKey

                        'update any old FK's with new ones
                        FK = WeaponConfig.GetFKGuid(Element)
                        If KeyMap.ContainsKey(FK) Then
                            WeaponConfig.SetFKGuid(Element, DirectCast(KeyMap.Item(FK), Objects.ObjectKey))
                        End If
                    Next

                    'save the weapon config again to update the FKLookup with the new key
                    WeaponConfig.Save()
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#End Region

#Region "Calculate"

        'calculate (no inventory)
        Public Sub Calculate(Optional ByVal ReloadComponents As Boolean = True)
#If DEBUG Then
            Dim Start As New TimeSpan(DateTime.Now.Ticks)
#End If
            _Inventory = New Inventory(Me)
            _Inventory.Calculate(False, ReloadComponents)
            CalculateState = CalculateType.Character
#If DEBUG Then
            Debug.WriteLine("Character.Calculate : " & New TimeSpan(DateTime.Now.Ticks).Subtract(Start).TotalSeconds.ToString & " seconds.")
#End If
        End Sub

        'calculate (inc. inventory)
        Public Sub CalculateInventory(Optional ByVal ReloadComponents As Boolean = True)
            _Inventory = New Inventory(Me)
            _Inventory.Calculate(True, ReloadComponents)
            CalculateMiscellaneous()
            CalculateState = CalculateType.CharacterAndInventory
        End Sub

        Public Sub CalculateForWeaponsPanel()
            _Inventory = New Inventory(Me)
            _Inventory.Calculate(True, True, True)
            CalculateMiscellaneous()
            CalculateState = CalculateType.CharacterAndInventory
        End Sub

        'calculate miscellaneous
        Private Sub CalculateMiscellaneous()
            Dim ImprovedDamageProgression As Integer
            If Me.CharacterLevel > 0 Then
                ImprovedDamageProgression = Me.ClassLevelCountFromClassesWhichGrantSystemAbility(References.ImprovedUnarmedDamage)

                'add monk belt bonus if required
                For Each InventoryItem As Objects.ObjectData In Me.Inventory.InventoryFolder.Children()
                    If InventoryItem.GetFKGuid("Item").Equals(References.MonkBelt) AndAlso InventoryItem.Element("Active") = "Yes" Then
                        ImprovedDamageProgression += 5
                    End If
                Next

                If ImprovedDamageProgression > 0 Then
                    _ImprovedUnarmedDamage = Rules.MonkAbilities.ImprovedUnarmedDamage(ImprovedDamageProgression, Me.Size)
                Else
                    _ImprovedUnarmedDamage = ""
                End If

            End If
        End Sub

#End Region

#Region "Helper Functions"

        'counts the class levels form all the classes that grant a given system ability - used to the monk modifer progressions
        Public Function ClassLevelCountFromClassesWhichGrantSystemAbility(ByVal SystemAbility As Objects.ObjectKey) As Integer
            Try

                Dim ClassLevels As Integer = 0
                Dim Classes As New ObjectHashtable
                Dim ClassKey As Objects.ObjectKey
                Dim SystemAbilities As Library = Me.Components.SystemAbilitiesLibrary

                If SystemAbilities.ContainsKey(SystemAbility) Then
                    Dim Components As ArrayList = SystemAbilities.ItemData(SystemAbility)
                    Dim Component As Rules.Components.ComponentData

                    For Each Item As Library.LibraryData In Components
                        Component = DirectCast(Item.Data, Rules.Components.ComponentData)
                        If Component.ValidInfo.Valid Then
                            'get the level it was aquired and thus the class that aquired it
                            ClassKey = Me.Levels(Component.LevelAcquired).ClassGuid
                            If ClassKey.IsNotEmpty Then
                                If Not Classes.ContainsKey(ClassKey) Then
                                    Classes.Add(ClassKey, Nothing)
                                    ClassLevels += HighestClasslevel(ClassKey)
                                End If
                            End If
                        End If
                    Next
                End If

                Return ClassLevels

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get HighestLevel in a class
        Public Function HighestClassLevelInfo(ByVal ClassGuid As Objects.ObjectKey) As Character.Level
            Dim retHighestClassLevelInfo As Character.Level = Level0
            Dim HighestLevel As Integer = 0
            Dim TempLevel As Level
            Try
                For Each TempLevel In Me._Levels
                    If TempLevel.ClassGuid.Equals(ClassGuid) Then
                        If TempLevel.ClassLevel > HighestLevel Then
                            HighestLevel = TempLevel.ClassLevel
                            retHighestClassLevelInfo = TempLevel
                        End If
                    End If
                Next
                Return retHighestClassLevelInfo
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'find the first Character Level a class was taken
        Public Function LowestClassLevelInfo(ByVal ClassGuid As Objects.ObjectKey) As Character.Level
            Dim retLowestClassLevelInfo As Character.Level = Nothing

            For Each level As Character.Level In Me._Levels
                If level.ClassGuid.Equals(ClassGuid) Then retLowestClassLevelInfo = level
            Next
            Return retLowestClassLevelInfo
        End Function

        'find the first Character Level a class was taken
        Public Function LowestClassLevel(ByVal ClassGuid As Objects.ObjectKey) As Integer

            For Each level As Character.Level In Me._Levels
                If level.ClassGuid.Equals(ClassGuid) Then Return level.CharacterLevel
            Next

        End Function

        'return all the class objects of classes in which this character has levels
        Public Function CharactersClassObjects() As Objects.ObjectDataCollection
            Dim TempLevel As Level
            Dim TempObject As New Objects.ObjectData

            CharactersClassObjects = New Objects.ObjectDataCollection

            For Each TempLevel In _Levels
                If Not CharactersClassObjects.Contains(TempLevel.ClassGuid) Then

                    'get the object
                    If Me.CharacterClasses.Contains(TempLevel.ClassGuid) Then
                        TempObject = Me.CharacterClasses.Item(TempLevel.ClassGuid).ClassObj
                    Else
                        TempObject.Load(TempLevel.ClassGuid)
                    End If

                    CharactersClassObjects.Add(TempObject)
                    TempObject.Clear()
                End If
            Next

            Return CharactersClassObjects

        End Function

        'return a list of distinct character class keys in which this character has levels
        Public Function CharacterClassKeys() As ArrayList
            CharacterClassKeys = New ArrayList

            For Each Level As Level In _Levels
                If Not CharacterClassKeys.Contains(Level.ClassGuid) Then CharacterClassKeys.Add(Level.ClassGuid)
            Next
        End Function

        'return a list of distinct character class keys in which this character has levels up to and including the specified level
        Public Function CharacterClassKeys(ByVal CharacterLevel As Integer) As ArrayList
            CharacterClassKeys = New ArrayList

            For Each Level As Level In _Levels
                If Level.CharacterLevel <= CharacterLevel AndAlso Not CharacterClassKeys.Contains(Level.ClassGuid) Then CharacterClassKeys.Add(Level.ClassGuid)
            Next
        End Function

        'retrive the highest class level of this class for this character
        Public Function HighestClasslevel(ByVal CharacterClass As Objects.ObjectKey) As Integer
            Dim TempLevel As Level = Level0
            Dim HighestLevel As Integer

            HighestLevel = 0

            For Each TempLevel In _Levels
                If TempLevel.ClassGuid.Equals(CharacterClass) Then
                    If TempLevel.ClassLevel > HighestLevel Then
                        HighestLevel = TempLevel.ClassLevel
                    End If
                End If
            Next

            Return HighestLevel

        End Function

        'retrive the highest class level of this class for this character, includes prestige offset
        Public Function HighestEffectiveClasslevel(ByVal ClassKey As Objects.ObjectKey) As Integer
            Dim TempLevel As Level
            Dim HighestLevel As Integer
            Dim PrestigeOffset As Integer
            Dim RacialOffset As Integer

            RacialOffset = 0
            PrestigeOffset = 0
            HighestLevel = 0

            'Workout the current offsets
            Dim ClassChoices As ArrayList
            ClassChoices = PrestigeSpellcasterChoices.ItemData(ClassKey)
            PrestigeOffset = ClassChoices.Count

            'if the race is a spellcaster and the class key matches return the offset
            RacialOffset = GetRacialCasterOffset(ClassKey)

            For Each TempLevel In _Levels
                If TempLevel.ClassGuid.Equals(ClassKey) Then
                    If TempLevel.ClassLevel > HighestLevel Then
                        HighestLevel = TempLevel.ClassLevel
                    End If
                End If
            Next

            Return HighestLevel + PrestigeOffset + RacialOffset

        End Function

        'returns the racial caster offset for the given class
        Public Function GetRacialCasterOffset(ByVal ClassKey As Objects.ObjectKey) As Integer
            If ClassKey.IsEmpty Then Return 0

            If ClassKey.Equals(RaceObject.GetFKGuid("CasterSource")) Then
                Return RaceObject.ElementAsInteger("CasterLevel")
            End If

            'if not found return 0
            Return 0

        End Function

        'Finds the highest level in the given class, on or before the given level
        Public Function HighestClassLevelAtLevel(ByVal ClassKey As Objects.ObjectKey, ByVal Level As Integer) As Character.Level
            Try
                Dim LevelInfo As Character.Level = Level0

                If Level < 1 Then Return Level0
                If Level > CharacterLevel Then Level = CharacterLevel

                For i As Integer = Level To 1 Step -1
                    If Levels(i).ClassGuid.Equals(ClassKey) Then
                        LevelInfo = Levels(i)
                        Exit For
                    End If
                Next

                Return LevelInfo

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'retrieve the highest class level object of this class for this Character
        Public Function HighestClasslevelObject(ByVal CharacterClass As Objects.ObjectData) As Objects.ObjectData
            Dim TempLevel As Level
            Dim HighestLevel As Integer
            Dim ClassLevelObject As New Objects.ObjectData

            HighestLevel = 0

            For Each TempLevel In _Levels
                If TempLevel.ClassGuid.Equals(CharacterClass.ObjectGUID) Then
                    If TempLevel.ClassLevel > HighestLevel Then
                        HighestLevel = TempLevel.ClassLevel
                        ClassLevelObject.Load(TempLevel.ClassLevelGuid)
                    End If
                End If
            Next

            Return ClassLevelObject

        End Function

        'retrieve the highest Character Level object for this Character - ONLY RETURNS LEVELS THAT HAVE BEEN SAVED
        Public Function HighestCharacterLevelObject() As Objects.ObjectData
            Dim CharacterLevel As New Objects.ObjectData

            If FirstNewLevel > 1 Then
                CharacterLevel.Load(Levels(FirstNewLevel - 1).CharacterLevelGuid)
            End If

            Return CharacterLevel

        End Function

        'returns an arraylist of character level numbers which relate to levels in this class
        Public Function LevelsInClass(ByVal ClassKey As Objects.ObjectKey) As ArrayList
            Try
                Dim Levels As New ArrayList

                For Each Level As Level In _Levels
                    If Level.ClassGuid.Equals(ClassKey) Then Levels.Add(Level.CharacterLevel)
                Next

                Return Levels
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns the value of largest setability score in the given collection
        Public Function HighestSetAbility(ByVal List As ArrayList) As Integer
            Try
                Dim HighestValue As Integer = -999
                Dim Obj As New Objects.ObjectData
                Dim Component As RPGXplorer.Rules.Components.ComponentData

                For Each Item As Library.LibraryData In List
                    Component = DirectCast(Item.Data, RPGXplorer.Rules.Components.ComponentData)
                    Obj.Load(Component.Key)
                    If Obj.ObjectGUID.Database <> 0 Then
                        If Obj.ElementAsInteger("Value") > HighestValue Then
                            HighestValue = Obj.ElementAsInteger("Value")
                        End If
                    End If
                Next

                Return HighestValue

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

#Region "Display Functions"

        'construct a string of abbreviations/levels for current character
        Public Function ClassesStatBlock() As String
            If CharacterLevel = 0 Then Return "No Class Levels"

            'get the set of classes for this character
            ClassesStatBlock = ""
            For Each CharacterClass As Objects.ObjectData In CharactersClassObjects()
                If ClassesStatBlock.Length <> 0 Then ClassesStatBlock &= "/"
                ClassesStatBlock &= CharacterClass.Element("Abbreviation") & " " & HighestClasslevel(CharacterClass.ObjectGUID)
            Next
        End Function

        'construct a character summary string (Race, Age, Height, Weight)
        Public Function PhysicalSummary() As String
            Select Case CharacterType
                Case CharacterObjectType.Familiar, CharacterObjectType.AnimalCompanion, CharacterObjectType.SpecialMount, CharacterObjectType.Monster
                    Return Character.Element("Description")
                Case Else
                    Return Character.Element("Gender") & ", " & Character.Element("Age") & " yrs. old" & ", " & Rules.Formatting.FormatFeetandInches(Character.ElementAsInteger("Height")) & ", " & Rules.Formatting.FormatPounds(Character.ElementAsInteger("Weight"))
            End Select

        End Function

        'get the class derived attacks
        Public Function GetBaseAttackBonuses() As ArrayList
            Dim BaseAttacks As ArrayList

            BaseAttacks = New ArrayList(New Integer(3) {0, 0, 0, 0})

            BaseAttacks(0) = Me.BAB
            If DirectCast(BaseAttacks(0), Integer) - 5 > 0 Then BaseAttacks(1) = DirectCast(BaseAttacks(0), Integer) - 5 Else BaseAttacks(1) = 0
            If DirectCast(BaseAttacks(0), Integer) - 10 > 0 Then BaseAttacks(2) = DirectCast(BaseAttacks(0), Integer) - 10 Else BaseAttacks(2) = 0
            If DirectCast(BaseAttacks(0), Integer) - 15 > 0 Then BaseAttacks(3) = DirectCast(BaseAttacks(0), Integer) - 15 Else BaseAttacks(3) = 0

            For n As Integer = 3 To 1 Step -1
                If DirectCast(BaseAttacks(n), Integer) = 0 Then BaseAttacks.RemoveAt(n)
            Next

            Return BaseAttacks
        End Function

#End Region

    End Class

End Namespace
