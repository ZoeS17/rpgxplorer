Option Explicit On 
Option Strict On

Imports RPGXplorer.Rules
Imports RPGXplorer.Rules.Components
Imports RPGXplorer.Exceptions

Public Class ModifiersDisplay

    'encapsulates all functionality required to display modifiers

#Region "Enumerations"

    <Flags()> Public Enum DisplayConcept
        Core = 1
        Defence = 2
        Combat = 4
        Skills = 8
        Magic = 16
        Psionic = 32
    End Enum

#End Region

#Region "Structures"

    'modifier display elements
    Public Structure Modifier

        Public Modifier As String
        Public SystemElementName As String
        Public SystemElement As Objects.ObjectKey
        Public ModifierCategory As String
        Public Focus As String
        Public Type As String
        Public Limiter As String
        Public Source As String
        Public Valid As Boolean
        Public UserDisabled As Boolean
        Public DisplayConcept As DisplayConcept
        Public Notes As String
        Public Tag As Object

        Public CalculatedValue As Integer

        'for complex modifiers
        Public BaseNumber As String
        Public PerLevel As String
        Public AbilityMod As String
        Public TagString As String
        Public TagNumber As String

        'standard single string display
        Public Shadows Function ToString() As String
            Return Formatting.ModifierName(Me)
        End Function

        Public Sub Clear()
            Modifier = Nothing
            SystemElementName = Nothing
            Focus = Nothing
            Type = Nothing
            Limiter = Nothing
            Source = Nothing
            Valid = Nothing
            UserDisabled = Nothing
            DisplayConcept = Nothing
            Notes = Nothing

            BaseNumber = Nothing
            PerLevel = Nothing
            AbilityMod = Nothing
            TagString = Nothing
            TagNumber = Nothing
        End Sub
    End Structure

#End Region

#Region "Member Variables"

    'indexes
    Private IndexByDisplayConcept As OneKeyList
    Private IndexByLimitThenSource As TwoKeyList

    'instance
    Private _Components As Components

    'shared
    Private Shared Core As New ArrayList
    Private Shared Defence As New ArrayList
    Private Shared Combat As New ArrayList
    Private Shared Skills As New ArrayList
    Private Shared Magic As New ArrayList
    Private Shared Psionic As New ArrayList
    Private Shared CharacterSheet As New ObjectHashtable


    'status holder
    Private _CurrentConcept As DisplayConcept

#End Region

#Region "Properties"

    'what modifiers have been processed
    Public ReadOnly Property CurrentConcept() As DisplayConcept
        Get
            Return _CurrentConcept
        End Get
    End Property

#End Region

    'constructor
    Public Sub New(ByVal Components As Components)
        Try
            _Components = Components
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Processors"

    'construct modifiers data structures for all modifiers
    Public Sub ProcessAllComponents(Optional ByVal OnlyValid As Boolean = False, Optional ByVal OnlyEnabled As Boolean = True, Optional ByVal CalculateValue As Boolean = False)
        Try
            IndexByDisplayConcept = New OneKeyList
            IndexByLimitThenSource = New TwoKeyList

            ProcessComponents(DisplayConcept.Combat, OnlyValid, OnlyEnabled, CalculateValue)
            ProcessComponents(DisplayConcept.Core, OnlyValid, OnlyEnabled, CalculateValue)
            ProcessComponents(DisplayConcept.Defence, OnlyValid, OnlyEnabled, CalculateValue)
            ProcessComponents(DisplayConcept.Magic, OnlyValid, OnlyEnabled, CalculateValue)
            ProcessComponents(DisplayConcept.Skills, OnlyValid, OnlyEnabled, CalculateValue)
            ProcessComponents(DisplayConcept.Psionic, OnlyValid, OnlyEnabled, CalculateValue)

            _CurrentConcept = DisplayConcept.Combat Or DisplayConcept.Core Or DisplayConcept.Defence Or DisplayConcept.Magic Or DisplayConcept.Skills Or DisplayConcept.Psionic

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'construct modifiers data structures by concept
    Public Sub ProcessComponentsByConcept(ByVal Concept As DisplayConcept, Optional ByVal OnlyValid As Boolean = False, Optional ByVal OnlyEnabled As Boolean = True, Optional ByVal CalculateValue As Boolean = False)

        Try
            IndexByDisplayConcept = New OneKeyList
            IndexByLimitThenSource = New TwoKeyList
            _CurrentConcept = 0

            'combat
            If (Concept And DisplayConcept.Combat) > 0 Then
                ProcessComponents(DisplayConcept.Combat, OnlyValid, OnlyEnabled, CalculateValue)
                _CurrentConcept = _CurrentConcept Or DisplayConcept.Combat
            End If

            'core
            If (Concept And DisplayConcept.Core) > 0 Then
                ProcessComponents(DisplayConcept.Core, OnlyValid, OnlyEnabled, CalculateValue)
                _CurrentConcept = _CurrentConcept Or DisplayConcept.Core
            End If

            'defence
            If (Concept And DisplayConcept.Defence) > 0 Then
                ProcessComponents(DisplayConcept.Defence, OnlyValid, OnlyEnabled, CalculateValue)
                _CurrentConcept = _CurrentConcept Or DisplayConcept.Defence
            End If

            'magic
            If (Concept And DisplayConcept.Magic) > 0 Then
                ProcessComponents(DisplayConcept.Magic, OnlyValid, OnlyEnabled, CalculateValue)
                _CurrentConcept = _CurrentConcept Or DisplayConcept.Magic
            End If

            'skills
            If (Concept And DisplayConcept.Skills) > 0 Then
                ProcessComponents(DisplayConcept.Skills, OnlyValid, OnlyEnabled, CalculateValue)
                _CurrentConcept = _CurrentConcept Or DisplayConcept.Skills
            End If

            'psionic
            If (Concept And DisplayConcept.Psionic) > 0 Then
                ProcessComponents(DisplayConcept.Psionic, OnlyValid, OnlyEnabled, CalculateValue)
                _CurrentConcept = _CurrentConcept Or DisplayConcept.Psionic
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'get all the modifiers
    Public Function GetAllModifiers() As ArrayList
        Try
            Dim ReturnList As New ArrayList

            ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Combat))
            ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Core))
            ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Defence))
            ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Magic))
            ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Skills))
            ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Psionic))

            Return ReturnList
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the skill modifiers
    Public Function GetModifiersByConcept(ByVal Concept As DisplayConcept) As ArrayList
        Try
            Dim ReturnList As New ArrayList

            'combat
            If (Concept And DisplayConcept.Combat) > 0 Then
                If (_CurrentConcept And DisplayConcept.Combat) > 0 Then
                    ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Combat))
                Else
                    Throw New DevelopmentException("Attempting to retrieve modifier data on an unprocessed concept.")
                End If
            End If

            'core
            If (Concept And DisplayConcept.Core) > 0 Then
                If (_CurrentConcept And DisplayConcept.Core) > 0 Then
                    ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Core))
                Else
                    Throw New DevelopmentException("Attempting to retrieve modifier data on an unprocessed concept.")
                End If
            End If

            'defence
            If (Concept And DisplayConcept.Defence) > 0 Then
                If (_CurrentConcept And DisplayConcept.Defence) > 0 Then
                    ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Defence))
                Else
                    Throw New DevelopmentException("Attempting to retrieve modifier data on an unprocessed concept.")
                End If
            End If

            'magic
            If (Concept And DisplayConcept.Magic) > 0 Then
                If (_CurrentConcept And DisplayConcept.Magic) > 0 Then
                    ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Magic))
                Else
                    Throw New DevelopmentException("Attempting to retrieve modifier data on an unprocessed concept.")
                End If
            End If

            'skills
            If (Concept And DisplayConcept.Skills) > 0 Then
                If (_CurrentConcept And DisplayConcept.Skills) > 0 Then
                    ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Skills))
                Else
                    Throw New DevelopmentException("Attempting to retrieve modifier data on an unprocessed concept.")
                End If
            End If

            'psionic
            If (Concept And DisplayConcept.Psionic) > 0 Then
                If (_CurrentConcept And DisplayConcept.Psionic) > 0 Then
                    ReturnList.AddRange(IndexByDisplayConcept.Item(DisplayConcept.Psionic))
                Else
                    Throw New DevelopmentException("Attempting to retrieve modifier data on an unprocessed concept.")
                End If
            End If

            Return ReturnList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the modifiers with conditions
    Public Function GetModifiersWithLimiters() As ArrayList
        Try
            Dim Limit, Source As String
            Dim ReturnList As New ArrayList

            For Each Limit In IndexByLimitThenSource.UpperKeys
                For Each Source In IndexByLimitThenSource.LowerKeys(Limit)
                    ReturnList.AddRange(IndexByLimitThenSource.Item(Limit, Source))
                Next
            Next

            Return ReturnList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'display string for charactersheet
    Public Function GetModifiersWithLimits() As String
        Try
            Dim Limit, Source As String
            Dim Modifiers As ArrayList
            Dim Modifier As ModifiersDisplay.Modifier

            Dim Output As String = ""

            For Each Limit In IndexByLimitThenSource.UpperKeys
                Output &= "[" & Limit & "]: "
                For Each Source In IndexByLimitThenSource.LowerKeys(Limit)
                    Modifiers = IndexByLimitThenSource.Item(Limit, Source)

                    For Each Modifier In Modifiers

                        Dim Temp As String
                        Output &= RPGXplorer.Rules.Formatting.ModifierCoreName(Modifier)

                        Temp = Modifier.Type
                        If Temp <> "" Then Output &= " [" & Temp & "]"

                        Output &= ", "

                    Next

                    Output = Output.TrimEnd(", ".ToCharArray)
                    Output &= " <" & Source & ">, "
                Next
            Next

            Output = Output.TrimEnd(", ".ToCharArray)
            Return Output

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the dicerange & percentage modifiers
    Public Function GetCharacterSheetModifiers() As ArrayList
        Try
            Dim ReturnList As New ArrayList
            Dim Templist As New ArrayList

            'go through each arraylist - getting all the dice range and percentage modifiers
            For Each Key As Object In IndexByDisplayConcept.Keys()
                Templist = IndexByDisplayConcept.Item(Key)

                For Each Modifier As Modifier In Templist
                    If Modifier.Limiter = "" Then
                        If CharacterSheet.ContainsKey(Modifier.SystemElement) Then
                            ReturnList.Add(Modifier)
                        Else
                            If Modifier.ModifierCategory = "Percentage Modifier" OrElse Modifier.ModifierCategory = "Dice Range Modifier" Then
                                ReturnList.Add(Modifier)
                            End If
                        End If
                    End If
                Next
            Next

            Return ReturnList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function


#Region "Private Functions"

    'construct modifier data structures for a subset of modifiers and place them in appropriate indexes
    Private Sub ProcessComponents(ByVal DisplayConcept As DisplayConcept, ByVal OnlyValid As Boolean, ByVal OnlyEnabled As Boolean, ByVal CalculateValue As Boolean)
        Try
            Dim SystemElements As ArrayList = GetSystemElements(DisplayConcept)
            Dim Level As Integer = _Components.Character.CharacterLevel
            Dim ModifierDefinition As New Objects.ObjectData
            Dim Modifier As New Modifier
            Dim ModifierNumber As Integer
            Dim Component As ComponentData

            For Each SystemElementKey As Objects.ObjectKey In SystemElements
                For Each Item As Library.LibraryData In _Components.Modifiers.ItemData(SystemElementKey)
                    Component = DirectCast(Item.Data, ComponentData)

                    'valid check
                    If (Not OnlyValid) OrElse (Component.ValidInfo.Valid) Then

                        'if the component is between the appropriate levels and is enabled
                        If Level <= Component.LevelLost And Level >= Component.LevelAcquired And (Not (OnlyEnabled And Component.UserModifierDisabled)) Then

                            If Component.TransientObject.ObjectGUID.IsNotEmpty Then
                                ModifierDefinition = Component.TransientObject
                            Else
                                ModifierDefinition.Load(Component.Key)
                            End If

                            'create the modififer display object
                            Modifier.Clear()
                            Modifier.DisplayConcept = DisplayConcept
                            Modifier.Limiter = ModifierDefinition.Element("Limiter")
                            Modifier.Modifier = ModifierDefinition.Element("Modifier")
                            Modifier.Notes = ModifierDefinition.Element("Notes")
                            Modifier.SystemElementName = ModifierDefinition.Element("SystemElement")
                            Modifier.SystemElement = ModifierDefinition.GetFKGuid("SystemElement")
                            Modifier.ModifierCategory = ModifierDefinition.Element("ModifierCategory")
                            Modifier.Valid = Component.ValidInfo.Valid
                            Modifier.BaseNumber = ModifierDefinition.Element("BaseNumber")
                            Modifier.AbilityMod = ModifierDefinition.Element("AbilityMod")
                            Modifier.PerLevel = ModifierDefinition.Element("PerLevel")
                            Modifier.TagString = ModifierDefinition.Element("TagString")
                            Modifier.TagNumber = ModifierDefinition.Element("TagNumber")

                            If CalculateValue Then
                                Select Case ModifierDefinition.Element("ModifierCategory")
                                    Case "Normal Modifier"
                                        ModifierNumber = ModifierDefinition.ElementAsInteger("Modifier")
                                    Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                                        ModifierNumber = Rules.AbilityScores.AbilityScore(_Components.Character.CurrentLevel.AbilityScore(ModifierDefinition.Element("Modifier"))).Modifier

                                        If ModifierDefinition.Element("ModifierCategory") = "Use Ability Modifier (positive only)" AndAlso ModifierNumber < 0 Then
                                            ModifierNumber = 0
                                        ElseIf ModifierDefinition.Element("ModifierCategory") = "Use Ability Modifier (+1 minimum)" AndAlso ModifierNumber < 1 Then
                                            ModifierNumber = 1
                                        End If

                                    Case "Complex Modifier"
                                        ModifierNumber = _Components.Character.Components.SetValueCalculator(ModifierDefinition, _Components.Character.CharacterLevel)
                                    Case Else
                                        ModifierNumber = 0
                                End Select
                                Modifier.CalculatedValue = ModifierNumber
                            Else
                                Modifier.CalculatedValue = 0
                            End If

                            If Component.UserModifierDisabled Then Modifier.UserDisabled = True
                            'set the type name
                            Modifier.Type = ModifierDefinition.Element("ModifierType")
                            If Modifier.Type = "Undefined" Then Modifier.Type = ""

                            'change the source name if this is a synergy
                            If Component.ComponentType = ComponentType.SkillSynergy Then
                                Modifier.Source = Component.SourceName & " Synergy"
                            Else
                                Modifier.Source = Component.SourceName
                            End If

                            'handle modifiers with a focus object of Feat Focus
                            If Component.FocusGuid.IsNotEmpty And ModifierDefinition.Element("FocusObject") = "Feat Focus" Then
                                Dim Focus As New Objects.ObjectData
                                Select Case Component.FocusGuid.ToString
                                    Case References.Grapple.ToString
                                        Modifier.Focus = "Grapple"
                                    Case References.Ray.ToString
                                        Modifier.Focus = "Ray"
                                    Case References.TouchSpell.ToString
                                        Modifier.Focus = "Touch Spell"
                                    Case References.RangedSpell.ToString
                                        Modifier.Focus = "Ranged Spell"
                                    Case Else
                                        Focus.Load(Component.FocusGuid)
                                        Modifier.Focus = Focus.Name
                                End Select
                            Else
                                Modifier.Focus = ModifierDefinition.Element("FocusObject")
                            End If

                            'key the modifier definition key if this is a user added modifer
                            If Component.UserAdded Then Modifier.Tag = ModifierDefinition.ObjectGUID

                            'add to appropriate indexes
                            If Modifier.Limiter <> "" Then
                                IndexByLimitThenSource.Add(Modifier.Limiter, Modifier.Source, Modifier)
                            Else
                                If SystemElementKey.Equals(References.DamageRollVsMonsterType) OrElse SystemElementKey.Equals(References.AttackRollVsMonsterType) Then
                                    Modifier.Limiter = "vs. " & Modifier.Focus
                                    Modifier.Focus = ""
                                    IndexByLimitThenSource.Add(Modifier.Limiter, Modifier.Source, Modifier)
                                End If
                            End If

                            IndexByDisplayConcept.Add(Modifier.DisplayConcept, Modifier)

                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'factory method to get the correct list of system elements
    Private Function GetSystemElements(ByVal DisplayConcept As DisplayConcept) As ArrayList
        Try

            Select Case DisplayConcept
                Case DisplayConcept.Combat
                    Return ModifiersDisplay.Combat
                Case DisplayConcept.Core
                    Return ModifiersDisplay.Core
                Case DisplayConcept.Defence
                    Return ModifiersDisplay.Defence
                Case DisplayConcept.Magic
                    Return ModifiersDisplay.Magic
                Case DisplayConcept.Skills
                    Return ModifiersDisplay.Skills
                Case DisplayConcept.Psionic
                    Return ModifiersDisplay.Psionic
            End Select
            Return New ArrayList
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Shared Functionality"

    'shared constructor
    Shared Sub New()
        Try
            DefineSystemElementToDisplayConceptMappings()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'defines the relationship between a system element and an organising concept e.g. combat
    Private Shared Sub DefineSystemElementToDisplayConceptMappings()
        Try
            'core
            Core.Add(References.Strength)
            Core.Add(References.Dexterity)
            Core.Add(References.Constitution)
            Core.Add(References.Intelligence)
            Core.Add(References.Wisdom)
            Core.Add(References.Charisma)
            Core.Add(References.FortitudeSavingThrow)
            Core.Add(References.ReflexSavingThrow)
            Core.Add(References.WillSavingThrow)
            Core.Add(References.SpeedBase)
            Core.Add(References.Speed)
            Core.Add(References.SpellResistance)
            Core.Add(References.PowerResistance)
            Core.Add(References.StrengthCheck)
            Core.Add(References.DexterityCheck)
            Core.Add(References.ConstitutionCheck)
            Core.Add(References.IntelligenceCheck)
            Core.Add(References.WisdomCheck)
            Core.Add(References.CharismaCheck)
            Core.Add(References.Leadership)
            Core.Add(References.BardicKnowledgeCheck)
            Core.Add(References.TurnAttemptsPerDay)
            Core.Add(References.TurnCheck)
            Core.Add(References.TurnLevel)
            Core.Add(References.TurningDamage)
            Core.Add(References.WildEmpathyCheck)
            Core.Add(References.SavingThrow)
            Core.Add(References.HitPointsBase)

            'defence
            'Defence.Add(References.ArmorClassBase)
            Defence.Add(References.ArmorClassMonk)
            Defence.Add(References.ArmourClass)
            Defence.Add(References.ACvsMonsterType)
            Defence.Add(References.MaxDexFromArmor)
            Defence.Add(References.CheckPenaltyFromArmor)

            'combat
            Combat.Add(References.AttackRoll)
            Combat.Add(References.AttackRollThrownWeapons)
            Combat.Add(References.AttackRollSpecificWeapon)
            Combat.Add(References.AttackvsMonsterType)
            Combat.Add(References.AttacksofOpportunity)
            Combat.Add(References.BullRushCheck)
            Combat.Add(References.CleaveAttempts)
            Combat.Add(References.DamageRoll)
            Combat.Add(References.DamageRollSpecificWeapon)
            Combat.Add(References.DamageRollVsMonsterType)
            Combat.Add(References.DisarmCheck)
            Combat.Add(References.GrappleRoll)
            Combat.Add(References.GrappleDamage)
            Combat.Add(References.InitiativeRoll)
            Combat.Add(References.MissileRangeProjectile)
            Combat.Add(References.MissileRangeThrown)
            Combat.Add(References.OverrunCheck)
            Combat.Add(References.SunderCheck)
            Combat.Add(References.TripCheck)

            'skills
            Skills.Add(References.Skill)
            Skills.Add(References.SkillGroup)

            'magic
            Magic.Add(References.CasterLevelCheck)
            Magic.Add(References.CasterLevelforDescriptor)
            Magic.Add(References.CasterLevelforSubschool)
            Magic.Add(References.SpellDCForDescriptor)
            Magic.Add(References.SpellDCForSpecificSchool)
            Magic.Add(References.SpellDCForSubschool)
            Magic.Add(References.CasterLevelforSchool)

            'psionic
            Psionic.Add(References.PowerPoints)
            Psionic.Add(References.PowerDCforDescriptor)
            Psionic.Add(References.PowerDCforSpecificDiscipline)
            Psionic.Add(References.PowerDCforSubdiscipline)
            Psionic.Add(References.ManifesterLevelCheck)

            'character sheet - System Elements not directly displayed on the character sheet
            CharacterSheet.Add(References.AttackRollThrownWeapons, Nothing)
            CharacterSheet.Add(References.AttackRollSpecificWeapon, Nothing)
            CharacterSheet.Add(References.AttackvsMonsterType, Nothing)
            CharacterSheet.Add(References.AttacksofOpportunity, Nothing)
            CharacterSheet.Add(References.BullRushCheck, Nothing)
            CharacterSheet.Add(References.CleaveAttempts, Nothing)
            CharacterSheet.Add(References.DamageRollSpecificWeapon, Nothing)
            CharacterSheet.Add(References.DamageRollVsMonsterType, Nothing)
            CharacterSheet.Add(References.DisarmCheck, Nothing)
            CharacterSheet.Add(References.GrappleDamage, Nothing)
            CharacterSheet.Add(References.MissileRangeProjectile, Nothing)
            CharacterSheet.Add(References.MissileRangeThrown, Nothing)
            CharacterSheet.Add(References.OverrunCheck, Nothing)
            CharacterSheet.Add(References.SunderCheck, Nothing)
            CharacterSheet.Add(References.TripCheck, Nothing)
            CharacterSheet.Add(References.ACvsMonsterType, Nothing)
            CharacterSheet.Add(References.Leadership, Nothing)
            CharacterSheet.Add(References.BardicKnowledgeCheck, Nothing)
            CharacterSheet.Add(References.TurnAttemptsPerDay, Nothing)
            CharacterSheet.Add(References.TurnCheck, Nothing)
            CharacterSheet.Add(References.TurningDamage, Nothing)
            CharacterSheet.Add(References.WildEmpathyCheck, Nothing)
            CharacterSheet.Add(References.StrengthCheck, Nothing)
            CharacterSheet.Add(References.WisdomCheck, Nothing)
            CharacterSheet.Add(References.IntelligenceCheck, Nothing)
            CharacterSheet.Add(References.CharismaCheck, Nothing)
            CharacterSheet.Add(References.DexterityCheck, Nothing)
            CharacterSheet.Add(References.ConstitutionCheck, Nothing)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'IComparer for sorting
    Public Class LimiterComparer
        Implements System.Collections.IComparer

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim Modifier_X, Modifier_Y As Modifier

            Modifier_X = DirectCast(x, Modifier)
            Modifier_Y = DirectCast(y, Modifier)

            If Modifier_X.Limiter > Modifier_Y.Limiter Then
                Return 1
            Else
                If Modifier_X.Limiter < Modifier_Y.Limiter Then
                    Return -1
                Else
                    Return 0
                End If
            End If
        End Function

    End Class

    'IComparer for sorting
    Public Class ModifierComparer
        Implements System.Collections.IComparer

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim Modifier_X, Modifier_Y As Modifier

            Modifier_X = DirectCast(x, Modifier)
            Modifier_Y = DirectCast(y, Modifier)

            If Modifier_X.Modifier > Modifier_Y.Modifier Then
                Return 1
            Else
                If Modifier_X.Modifier < Modifier_Y.Modifier Then
                    Return -1
                Else
                    Return 0
                End If
            End If
        End Function

    End Class

End Class


