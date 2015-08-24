Option Strict On
Option Explicit On

Namespace Rules

    Public Class Skills

        'this class allows rapid access to skill objects
        'it also contains functions related to skills required during levelling
        'and helper functions related to characters.

#Region "Member Variables"

        Private _Character As Character

        'shared lookup ability mods -  shared for speed
        Private Shared STRMod As Integer
        Private Shared DEXMod As Integer
        Private Shared CONMod As Integer
        Private Shared INTMod As Integer
        Private Shared WISMod As Integer
        Private Shared CHAMod As Integer

#End Region

#Region "Structures"

        'slot for the skills panel
        Public Structure SkillSlot
            Public CharacterLevel As Integer
            Public ClassName As String
            Public ClassGuid As Objects.ObjectKey
            Public PointsRemaining As Integer
            Public PointsSpent As Integer
            Public SkillRanksAssigned As ObjectHashtable
        End Structure

        'Small Structure for keeping track of when points were spent
        Public Structure AssignedPoints
            Public ThisLevel As Double
            Public SoFar As Double
        End Structure

        'for skill display in panel and character sheet
        Public Structure SkillInfo
            Implements IComparable

            Public SkillName As String
            Public Ranks As Double
            Public Modifiers As Integer
            Public CheckPenaltyMultiplier As Integer
            Public Ability As String
            Public TrainedOnly As Boolean

            'XML output data
            Public License As String
            Public Sourcebook As String
            Public Tags As String
            Public PageNoRef As String
            Public HelpPage As String
            Public SkillGuid As Objects.ObjectKey

            Public Function FinalSkillModifier() As String
                If TrainedOnly And Ranks < 1 Then
                    Return "X"
                End If
                Return Rules.Formatting.FormatModifier(CInt(Ranks) + Modifiers)
            End Function

            Public Function CheckPenaltyString() As String
                Select Case CheckPenaltyMultiplier
                    Case 0
                        Return ""
                    Case 1
                        Return "Check Penalty"
                    Case 2
                        Return "2xCheck Penalty"
                End Select
                Return ""
            End Function

            Public Function InfoSummary() As String
                Dim Summary As String = Ranks.ToString & " Ranks, " & Ability
                Dim Penalty As String = CheckPenaltyString()
                If Penalty <> "" Then Summary &= ", " & Penalty
                Return Summary
            End Function

            Public Sub Reset()
                SkillName = Nothing
                Ranks = Nothing
                Modifiers = Nothing
                CheckPenaltyMultiplier = Nothing
                Ability = Nothing
                TrainedOnly = Nothing
                License = Nothing
                Sourcebook = Nothing
                Tags = Nothing
                PageNoRef = Nothing
                HelpPage = Nothing
                SkillGuid = Nothing
            End Sub

            Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
                If DirectCast(obj, SkillInfo).SkillName < SkillName Then
                    Return 1
                ElseIf DirectCast(obj, SkillInfo).SkillName > SkillName Then
                    Return -1
                Else
                    Return 0
                End If
            End Function

        End Structure

#End Region

        'constructor
        Public Sub New(ByVal Character As Character)
            Me._Character = Character
        End Sub

        'clone
        Public Function Clone(ByRef CloneCharacter As Character) As Skills
            Return New Skills(CloneCharacter)
        End Function

        'REMEMBER TO REFRESH CACHED MODS IN CALLING CODE - SkillAbilityScoresRefresh()
        'get the modifiers to a skill for a character
        Public Function SkillModifier(ByVal SkillGuid As Objects.ObjectKey, Optional ByVal SkillAbility As String = "") As Integer
            Dim Skill As Objects.ObjectData
            Dim Level As Character.Level
            Dim Modifier As Integer
            Dim AbilityMod As Integer

            Try
                Skill = Caches.Skills.Item(SkillGuid)
                Level = _Character.Levels(_Character.CharacterLevel)

                'if we haven't specified an ability to use, find the best one
                If SkillAbility = "" Then
                    AbilityMod = GetCachedAbilityModifier(SkillModifierAbility(Skill))
                Else
                    AbilityMod = GetCachedAbilityModifier(SkillAbility)
                End If

                'add the final ability mod
                Modifier = AbilityMod

                'add mods
                Modifier += _Character.Modifiers.Skill(SkillGuid)

                Return Modifier

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the best ability to we can use for the given skill
        Public Function SkillModifierAbility(ByVal Skill As Objects.ObjectData) As String
            Try
                Dim Ability, TempAbility As String
                Dim AbilityMod, TempMod As Integer
                Dim NonabilityFlag, TempNonabilityFlag As Boolean

                'get the normal ability modifier
                Ability = Skill.Element("KeyAbility")
                NonabilityFlag = _Character.IsNonability(Ability)
                AbilityMod = GetCachedAbilityModifier(Ability)

                'look for any skill ability exchanges
                Dim SkillAbilityExchanges As ArrayList = _Character.Components.SkillAbilityExchanges.ItemData(Skill.ObjectGUID)
                For Each ItemData As Library.LibraryData In SkillAbilityExchanges
                    Dim Component As Components.ComponentData = DirectCast(ItemData.Data, Components.ComponentData)
                    Dim SkillExchange As Objects.ObjectData = Component.TransientObject

                    TempAbility = SkillExchange.Element("Ability")
                    TempNonabilityFlag = _Character.IsNonability(TempAbility)
                    TempMod = GetCachedAbilityModifier(TempAbility)

                    If (TempMod > AbilityMod) AndAlso (TempNonabilityFlag = False) Then
                        AbilityMod = TempMod
                        NonabilityFlag = TempNonabilityFlag
                        Ability = TempAbility
                    ElseIf TempMod <= AbilityMod AndAlso (TempNonabilityFlag = False) Then
                        'if tempvalue is lower or equal, but Ability is a nonability then we want to update
                        If NonabilityFlag Then
                            NonabilityFlag = TempNonabilityFlag
                            Ability = TempAbility
                        End If
                    End If

                Next

                Return Ability

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'skill points earned at a particular character level
        Public Function SkillPointsEarnedAtLevel(ByVal CharacterLevel As Integer, Optional ByVal FirstLevelMultiply As Boolean = True) As Integer
            Try
                Dim SkillPoints As Integer

                'get skill points at level
                Dim ClassDef As New Objects.ObjectData
                ClassDef.Load(_Character.Levels(CharacterLevel).ClassGuid)
                SkillPoints += ClassDef.ElementAsInteger("SkillPointsPerLevel")

                'get int bonus at this level
                Dim INT As Integer

                'get the base score
                INT = _Character.Levels(CharacterLevel).INT(True)

                'add the racial modifier
                INT += _Character.RaceObject.ElementAsInteger("INTModifier")

                'get the bonus skill points
                SkillPoints += Rules.AbilityScores.AbilityScore(INT).Modifier

                'get at least 1 skill point per level
                If SkillPoints < 1 Then SkillPoints = 1

                'get racial bonus
                SkillPoints += _Character.RaceObject.ElementAsInteger("BonusSkillPoints")

                'if first level then multiply by 4
                If CharacterLevel = 1 And FirstLevelMultiply Then SkillPoints *= 4

                Return SkillPoints

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this a class skill for any level/class up to and including specified character level
        Public Function IsClassSkillAtLevel(ByVal SkillKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As Boolean
            Try
                For Each ClassKey As Objects.ObjectKey In _Character.CharacterClassKeys(CharacterLevel)
                    If IsClassSkillForClassAtLevel(ClassKey, SkillKey, CharacterLevel) Then Return True
                Next

                Return False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this a class skill for this class at the specified level?
        Public Function IsClassSkillForClassAtLevel(ByVal ClassKey As Objects.ObjectKey, ByVal SkillKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As Boolean
            Try
                'straight class skill?
                If DirectCast(_Character.CharacterClasses.Item(ClassKey), CharacterClass).IsClassSkill(SkillKey) Then Return True

                'check for group skills as well from this point
                Dim SkillDef As Objects.ObjectData = Caches.Skills.Item(SkillKey)
                Dim SkillGroup As String = SkillDef.Element("SkillGroup")
                If SkillGroup <> "" Then
                    Select Case SkillGroup
                        Case "Craft"
                            SkillKey = References.Craft
                        Case "Knowledge"
                            SkillKey = References.Knowledge
                        Case "Perform"
                            SkillKey = References.Perform
                        Case "Profession"
                            SkillKey = References.Profession
                    End Select

                    If DirectCast(_Character.CharacterClasses.Item(ClassKey), CharacterClass).IsClassSkill(SkillKey) Then Return True
                End If

                'is this a bonus class skill?
                If _Character.ExtraClassSkills.IsExtraClassSkill(ClassKey, SkillKey, CharacterLevel) Then Return True

                'is this a monster race class skill?
                If ClassKey.Database = XML.DBTypes.MonsterClasses Then
                    Dim ClassSkills As Objects.ObjectDataCollection = _Character.RaceObject.ChildrenOfType(Objects.ClassSkillType)
                    If ClassSkills.ContainsFK("Skill", SkillKey) Then
                        Return True
                    End If
                End If

                Return False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'jump modifier for character size
        Public Function JumpModifier() As Integer
            Try
                'get speed
                Dim Speed As Integer = _Character.Inventory.Speed

                'calc jump mod
                If Speed > 30 Then
                    Return CInt((Speed - 30) / 10) * 4
                ElseIf Speed < 30 Then
                    Return CInt((30 - Speed) / 10) * -6
                Else
                    Return 0
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'hide modifier for character size
        Public Function HideModifier() As Integer
            Try
                Select Case _Character.Size

                    Case "Fine"
                        Return 16

                    Case "Diminutive"
                        Return 12

                    Case "Tiny"
                        Return 8

                    Case "Small"
                        Return 4

                    Case "Large"
                        Return -4

                    Case "Huge"
                        Return -8

                    Case "Gargantuan"
                        Return -12

                    Case "Colossal"
                        Return -16

                    Case Else
                        Return 0
                End Select

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'delegate for checking the addition of skills/groups via choose list dialog
        Public Shared Function IsValidAdd(ByVal ItemsToAdd As ArrayList, ByVal ListBItems As ArrayList) As Boolean
            Try
                Dim sErrMsg As String = "Can't have a skill group and a skill from that group."""
                'can't add a class skill and a group at the same time
                Dim Groups As New ArrayList
                Dim GroupSkills As New ArrayList

                'find out what groups are in the selection
                For Each Item As Objects.ObjectData In ItemsToAdd
                    Select Case Item.Type
                        Case Objects.SkillDefinitionType
                            If Item.Element("SkillGroup") <> "" Then
                                If Not GroupSkills.Contains(Item.Element("SkillGroup")) Then GroupSkills.Add(Item.Element("SkillGroup"))
                            End If
                        Case Objects.SkillGroupType
                            If Not Groups.Contains(Item.Name) Then Groups.Add(Item.Name)
                    End Select
                Next

                'check to see if items to add valid
                Dim bFail As Boolean = False
                For Each Group As String In Groups
                    If GroupSkills.Contains(Group) Then
                        bFail = True
                        Exit For
                    End If
                Next

                If bFail = False Then
                    'can't have a mix of skill groups and skills of that group
                    Dim ExistingGroups As New ArrayList
                    Dim ExistingGroupSkills As New ArrayList

                    For Each Item As Objects.ObjectData In ListBItems
                        Select Case Item.Type
                            Case Objects.SkillDefinitionType
                                If Item.Element("SkillGroup") <> "" Then
                                    If Not ExistingGroupSkills.Contains(Item.Element("SkillGroup")) Then ExistingGroupSkills.Add(Item.Element("SkillGroup"))
                                End If
                            Case Objects.SkillGroupType
                                If Not ExistingGroups.Contains(Item.Name) Then ExistingGroups.Add(Item.Name)
                        End Select
                    Next

                    'check groups
                    For Each Group As String In ExistingGroups
                        If GroupSkills.Contains(Group) Then
                            General.ShowInfoDialog(sErrMsg)
                            Return False
                        End If
                    Next

                    'check group members
                    For Each GroupSkill As String In ExistingGroupSkills
                        General.ShowInfoDialog(sErrMsg)
                        Return False
                    Next

                    Return True
                End If

                General.ShowInfoDialog(sErrMsg)
                Return False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'construct an arraylist of skill info objects for display
        Public Function SkillDisplayInfo() As ArrayList
            Try
                SkillDisplayInfo = New ArrayList

                'flags for groups

                'precalc skill mods
                _Character.Skills.SkillAbilityScoresRefresh()

                Dim CheckPenalty As Integer = _Character.Inventory.CheckPenalty

                'loop through all skills and groups
                Dim SkillDefs As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillDefinitionType)
                SkillDefs.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillGroupType))

                For Each SkillDef As Objects.ObjectData In SkillDefs
                    Dim SkillInfo As New SkillInfo

                    If Not SkillDef.ObjectGUID.Equals(References.SpeakLanguage) Then
                        'core stuff
                        SkillInfo.SkillName = SkillDef.Name
                        SkillInfo.Ability = SkillDef.Element("KeyAbility")
                        If SkillDef.Element("Untrained") = "" Then SkillInfo.TrainedOnly = True

                        'get ranks and modifiers
                        Dim SkillRank As Character.SkillRank

                        If _Character.SkillRanks.ContainsKey(SkillDef.ObjectGUID) Then
                            'normal skill
                            SkillRank = _Character.Skill(SkillDef.ObjectGUID)

                            'set ranks, if group skill with < 1 ranks then skip
                            If SkillDef.Element("SkillGroup") = "" OrElse SkillRank.Ranks >= 1 Then
                                SkillInfo.Ranks = SkillRank.Ranks
                            Else
                                SkillInfo.Reset()
                                Continue For
                            End If

                            'SkillInfo.Modifiers = _Character.Modifiers.Skill(SkillDef.ObjectGUID)
                            Dim SkillAbility As String = _Character.Skills.SkillModifierAbility(SkillDef)
                            SkillInfo.Ability = SkillAbility
                            SkillInfo.Modifiers = _Character.Skills.SkillModifier(SkillDef.ObjectGUID, SkillAbility)
                        Else
                            'skill group
                            SkillInfo.Ranks = 0
                            SkillInfo.Modifiers = _Character.Modifiers.SkillGroupModifier(SkillDef.Name)

                            'ability score modifiers
                            Select Case SkillInfo.Ability
                                Case "STR"
                                    SkillInfo.Modifiers += STRMod
                                Case "DEX"
                                    SkillInfo.Modifiers += DEXMod
                                Case "CON"
                                    SkillInfo.Modifiers += CONMod
                                Case "INT"
                                    SkillInfo.Modifiers += INTMod
                                Case "WIS"
                                    SkillInfo.Modifiers += WISMod
                                Case "CHA"
                                    SkillInfo.Modifiers += CHAMod
                            End Select
                        End If

                        'check penalty multipler
                        If SkillDef.Element("ArmorCheckPenalty") = "Yes" Then
                            If SkillDef.ObjectGUID.Equals(References.Swim) Then
                                SkillInfo.CheckPenaltyMultiplier = 2
                            Else
                                SkillInfo.CheckPenaltyMultiplier = 1
                            End If

                            SkillInfo.Modifiers += (CheckPenalty * SkillInfo.CheckPenaltyMultiplier)
                        End If

                        'data for XML output
                        SkillInfo.License = SkillDef.Element("License")
                        SkillInfo.Sourcebook = SkillDef.Element("Sourcebook")
                        SkillInfo.Tags = SkillDef.Element("Tags")
                        SkillInfo.PageNoRef = SkillDef.Element("PageNoRef")
                        SkillInfo.SkillGuid = SkillDef.ObjectGUID
                        SkillInfo.HelpPage = SkillDef.Element("HTML")

                        'add to resultset
                        SkillDisplayInfo.Add(SkillInfo)
                        SkillInfo.Reset()
                    End If
                Next

                SkillDisplayInfo.Sort()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'refresh the shared ability scores
        Public Sub SkillAbilityScoresRefresh()
            STRMod = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.STR).Modifier
            DEXMod = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.DEX).Modifier
            CONMod = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.CON).Modifier
            INTMod = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.INT).Modifier
            WISMod = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.WIS).Modifier
            CHAMod = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.CHA).Modifier
        End Sub

        'return the cached value
        Private Function GetCachedAbilityModifier(ByVal Ability As String) As Integer
            Select Case Ability
                Case "STR"
                    Return STRMod
                Case "DEX"
                    Return DEXMod
                Case "CON"
                    Return CONMod
                Case "INT"
                    Return INTMod
                Case "WIS"
                    Return WISMod
                Case "CHA"
                    Return CHAMod
            End Select
        End Function

#Region "Levelling Wizard"

        'construct the skill slot arraylist for the wizard panel
        Public Function GetSkillSlots() As ArrayList
            Try
                Dim Slots As New ArrayList

                Select Case _Character.CharacterType

                    Case Character.CharacterObjectType.AnimalCompanion, Character.CharacterObjectType.SpecialMount
                        For i As Integer = _Character.FirstNewLevel To _Character.CharacterLevel

                            'as soon as we have lost our int - we stop getting skill points
                            If _Character.NonInt(i) Then Exit For

                            Dim Level As Character.Level
                            Dim NewSlot As SkillSlot

                            Level = _Character.Levels(i)

                            If level.HitDice > 0 Then

                                If level.CharacterLevel <> 1 Then
                                    NewSlot.CharacterLevel = Level.CharacterLevel
                                    NewSlot.ClassGuid = Level.ClassGuid
                                    NewSlot.ClassName = Level.ClassName
                                    NewSlot.PointsRemaining = (SkillPointsEarnedAtLevel(i)) * level.HitDice
                                    NewSlot.SkillRanksAssigned = New ObjectHashtable
                                    Slots.Add(NewSlot)
                                Else
                                    Dim RacialHitdice As Integer = CInt(Math.Max(_Character.RaceObject.ElementAsNumber("DiceNumber"), 1))
                                    If level.HitDice > RacialHitdice Then
                                        NewSlot.CharacterLevel = Level.CharacterLevel
                                        NewSlot.ClassGuid = Level.ClassGuid
                                        NewSlot.ClassName = Level.ClassName
                                        NewSlot.PointsRemaining = (SkillPointsEarnedAtLevel(i, False)) * (Level.HitDice - RacialHitdice)
                                        NewSlot.SkillRanksAssigned = New ObjectHashtable
                                        Slots.Add(NewSlot)
                                    End If
                                End If

                            End If
                        Next

                    Case Character.CharacterObjectType.Monster

                        'dont count initial monster levels
                        Dim StartLevel As Integer
                        If _Character.FirstNewLevel = 1 Then
                            'get the monster level number
                            StartLevel = Math.Max(CInt(_Character.RaceObject.ElementAsNumber("DiceNumber")), 1) + 1
                        Else
                            StartLevel = _Character.FirstNewLevel
                        End If

                        For i As Integer = StartLevel To _Character.CharacterLevel

                            'as soon as we have lost our int - we spot getting skill points
                            If _Character.NonInt(i) Then Exit For

                            Dim Level As Character.Level
                            Dim NewSlot As SkillSlot

                            Level = _Character.Levels(i)
                            NewSlot.CharacterLevel = Level.CharacterLevel
                            NewSlot.ClassGuid = Level.ClassGuid
                            NewSlot.ClassName = Level.ClassName
                            NewSlot.PointsRemaining = SkillPointsEarnedAtLevel(i)
                            NewSlot.SkillRanksAssigned = New ObjectHashtable
                            Slots.Add(NewSlot)
                        Next

                    Case Else

                        For i As Integer = _Character.FirstNewLevel To _Character.CharacterLevel

                            'as soon as we have lost our int - we spot getting skill points
                            If _Character.NonInt(i) Then Exit For

                            Dim Level As Character.Level
                            Dim NewSlot As SkillSlot

                            Level = _Character.Levels(i)
                            NewSlot.CharacterLevel = Level.CharacterLevel
                            NewSlot.ClassGuid = Level.ClassGuid
                            NewSlot.ClassName = Level.ClassName
                            NewSlot.PointsRemaining = SkillPointsEarnedAtLevel(i)
                            NewSlot.SkillRanksAssigned = New ObjectHashtable
                            Slots.Add(NewSlot)
                        Next

                End Select

                Return Slots
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the skills data for this character in a dataset for display in levelling wizard
        Public Function GetSkillsDataTable() As DataTable
            Dim Skill As Objects.ObjectData
            Dim SkillData As DataTable
            Dim SkillRank As Character.SkillRank
            Dim Row As DataRow

            Try
                'build data table
                SkillData = New DataTable
                SkillData.Columns.Add("Skill")
                SkillData.Columns.Add("ClassSkill")
                SkillData.Columns.Add("Ranks")
                SkillData.Columns.Add("Mods")
                SkillData.Columns.Add("LevelRanks")
                SkillData.Columns.Add("Final")
                SkillData.Columns.Add("SkillGuid")

                For Each Skill In Caches.Skills
                    Row = SkillData.NewRow
                    Row("Skill") = Skill.Name
                    If _Character.Skills.IsClassSkillForClassAtLevel(_Character.Levels(_Character.FirstNewLevel).ClassGuid, Skill.ObjectGUID, _Character.FirstNewLevel) Then Row("ClassSkill") = "Class" Else Row("ClassSkill") = "Cross-Class"
                    SkillRank = _Character.Skill(Skill.ObjectGUID)
                    Row("Ranks") = SkillRank.Ranks + SkillRank.NewRanks
                    Row("Mods") = Rules.Formatting.FormatModifier(SkillRank.Mods)
                    Row("LevelRanks") = 0
                    Row("Final") = Rules.Formatting.FormatModifier(CInt(SkillRank.Final))
                    Row("SkillGuid") = Skill.ObjectGUID.ToString
                    SkillData.Rows.Add(Row)
                Next

                Return SkillData

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

    End Class

End Namespace