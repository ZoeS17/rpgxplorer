Option Explicit On
Option Strict On

Namespace Rules

    'this class is reasponsible for getting the modifiers to a particular element
    'modifiers are calculated as required, once calculated they are stored and subsequent calls will retrieve the stored modifier (unless Init has been called and the whole instance is reset).

    Public Class Modifiers

#Region "Enumerations"

        Public Enum Modifier
            None
            Positive
            Negative
        End Enum

#End Region

#Region "Member Variables"

        Private _Character As Character
        Private Modifiers As Hashtable

        Private _SkillModifiers As ObjectHashtable
        Private _SkillGroupModifiers As ObjectHashtable
        Private FocusModifiers As Library
        Private _TouchACMod, _FlatFootedACMod, _HelplessACModifier As Integer
        Private _IncludeItems As Boolean

        'favored enemies
        Private _MonsterTypes As ObjectHashtable

#End Region

#Region "Properties"

        Public ReadOnly Property Character() As Rules.Character
            Get
                Return _Character
            End Get
        End Property

        Public ReadOnly Property TouchACModifier() As Integer
            Get
                Return _TouchACMod
            End Get
        End Property

        Public ReadOnly Property FlatFootedACModifier() As Integer
            Get
                Return _FlatFootedACMod
            End Get
        End Property

        Public ReadOnly Property HelplessACModifier() As Integer
            Get
                Return _HelplessACModifier
            End Get
        End Property

        Public ReadOnly Property MonsterTypes() As ObjectHashtable
            Get
                Return _MonsterTypes
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Character)
            _Character = Character
            Modifiers = New Hashtable
        End Sub

        ''calculates all the modifiers on the character
        Public Sub Calculate(ByVal IncludeItems As Boolean, Optional ByVal Level As Integer = 1000)
            _IncludeItems = IncludeItems
            Modifiers = New Hashtable
            FocusModifiers = New Library
            _TouchACMod = 0
            _FlatFootedACMod = 0

            'calculate all modifiers
            CalculateModifiers(References.Strength, Level)
            CalculateModifiers(References.Dexterity, Level)
            CalculateModifiers(References.Constitution, Level)
            CalculateModifiers(References.Intelligence, Level)
            CalculateModifiers(References.Wisdom, Level)
            CalculateModifiers(References.Charisma, Level)

            CalculateModifiers(References.HitPointsBase, Level)
            CalculateModifiers(References.ReflexSavingThrow, Level)
            CalculateModifiers(References.FortitudeSavingThrow, Level)
            CalculateModifiers(References.WillSavingThrow, Level)

            CalculateModifiers(References.Speed, Level)
            CalculateModifiers(References.SpellResistance, Level)
            CalculateModifiers(References.PowerResistance, Level)
            CalculateModifiers(References.SpeedBase, Level)

            'CalculateModifiers(References.ArmorClassBase, Level)
            CalculateModifiers(References.ArmorClassMonk, Level)
            CalculateModifiers(References.ArmourClass, Level)
            CalculateModifiers(References.MaxDexFromArmor, Level)
            CalculateModifiers(References.CheckPenaltyFromArmor, Level)

            CalculateModifiers(References.AttackRoll, Level)
            CalculateModifiers(References.AttackRollThrownWeapons, Level)
            CalculateModifiers(References.DamageRoll, Level)
            CalculateModifiers(References.GrappleRoll, Level)
            CalculateModifiers(References.InitiativeRoll, Level)

            CalculateModifiers(References.PowerPoints, Level)
        End Sub

        'skill
        Public Sub CalculateSkills(Optional ByVal Level As Integer = 1000)
            _SkillModifiers = New ObjectHashtable
            _SkillGroupModifiers = New ObjectHashtable(4)
            GetSkillModifiers(Level)
            GetSkillGroupModifiers(Level)
        End Sub

        'get modifier
        Private Function GetModifierInteger(ByVal Key As Objects.ObjectKey, ByVal Level As Integer) As Integer

            'get modifier
            If Modifiers.ContainsKey(Key) Then
                Return DirectCast(Modifiers.Item(Key), Integer)
            Else
                Return 0
            End If

        End Function

#Region "Modifier Retrieval Functions"

        'get modifiers to the specified ability score up to and including specified level
        Public Function AbilityScore(ByVal Ability As String, Optional ByVal Level As Integer = 1000) As Integer
            Select Case Ability
                Case "STR"
                    Return GetModifierInteger(References.Strength, Level)
                Case "DEX"
                    Return GetModifierInteger(References.Dexterity, Level)
                Case "CON"
                    Return GetModifierInteger(References.Constitution, Level)
                Case "INT"
                    Return GetModifierInteger(References.Intelligence, Level)
                Case "WIS"
                    Return GetModifierInteger(References.Wisdom, Level)
                Case "CHA"
                    Return GetModifierInteger(References.Charisma, Level)
            End Select
        End Function

        'hit points
        Public Function HitPoints() As Integer
            Return GetModifierInteger(References.HitPointsBase, 1000)
        End Function

        'power points
        Public Function PowerPoints() As Integer
            Return GetModifierInteger(References.PowerPoints, 1000)
        End Function

        'get saving throw with modifiers included
        Public Function FortitudeSavingThrow(Optional ByVal Level As Integer = 1000) As Integer
            Return GetModifierInteger(References.FortitudeSavingThrow, Level) + GetModifierInteger(References.SavingThrow, Level)
        End Function

        'get saving throw with modifiers included
        Public Function ReflexSavingThrow(Optional ByVal Level As Integer = 1000) As Integer
            Return GetModifierInteger(References.ReflexSavingThrow, Level) + GetModifierInteger(References.SavingThrow, Level)
        End Function

        'get saving throw with modifiers included
        Public Function WillSavingThrow(Optional ByVal Level As Integer = 1000) As Integer
            Return GetModifierInteger(References.WillSavingThrow, Level)
        End Function

        'base speed
        Public Function BaseSpeed() As Integer
            Return GetModifierInteger(References.SpeedBase, 1000)
        End Function

        'speed
        Public Function Speed() As Integer
            Return GetModifierInteger(References.Speed, 1000)
        End Function

        Public Function SpellResistance() As Integer
            Return GetModifierInteger(References.SpellResistance, 1000)
        End Function

        Public Function PowerResistance() As Integer
            Return GetModifierInteger(References.PowerResistance, 1000)
        End Function

        'initiative
        Public Function Initiative(Optional ByVal Level As Integer = 1000) As Integer
            Return GetModifierInteger(References.InitiativeRoll, Level)
        End Function

        'ac
        Public Function ArmorClass() As Integer
            Return GetModifierInteger(References.ArmourClass, 1000)
        End Function

        'ac base
        'Public Function ArmorClassBase() As Integer
        '    Return GetModifierInteger(References.ArmorClassBase, 1000)
        'End Function

        'ac monk
        Public Function ArmorClassMonk() As Integer
            Return GetModifierInteger(References.ArmorClassMonk, 1000)
        End Function

        'modifier to max dex
        Public Function MaxDexFromArmor() As Integer
            Return GetModifierInteger(References.MaxDexFromArmor, 1000)
        End Function

        'modifier to armor check
        Public Function CheckPenaltyFromArmor() As Integer
            Return GetModifierInteger(References.CheckPenaltyFromArmor, 1000)
        End Function

        'attack roll
        Public Function AttackRoll() As Integer
            Return GetModifierInteger(References.AttackRoll, 1000)
        End Function

        'attack roll specific weapon
        Public Function AttackRollSpecificWeapon(ByVal WeaponGuid As Objects.ObjectKey) As Integer
            Dim BaseWeapon As New Objects.ObjectData

            BaseWeapon.Load(WeaponGuid)

            'is this the same as another base weapon
            If BaseWeapon.Element("Shadows") <> "" Then
                WeaponGuid = BaseWeapon.GetFKGuid("Shadows")
            End If

            'is this a natural attack?
            If BaseWeapon.Type = Objects.NaturalWeaponDefinitionType Then
                WeaponGuid = General.ConvertToObjectKey(BaseWeapon.Element("AttackType"), XML.DBTypes.NaturalWeapons)
            End If

            Return CalculateModifiers(References.AttackRollSpecificWeapon, 1000, WeaponGuid)

        End Function

        'attack roll thrown weapons
        Public Function AttackRollThrownWeapons() As Integer
            Return GetModifierInteger(References.AttackRollThrownWeapons, 1000)
        End Function

        'damage roll 
        Public Function DamageRoll() As Integer
            Return GetModifierInteger(References.DamageRoll, 1000)
        End Function

        'damage roll specific weapon
        Public Function DamageRollSpecificWeapon(ByVal WeaponGuid As Objects.ObjectKey) As Integer
            Dim BaseWeapon As New Objects.ObjectData

            BaseWeapon.Load(WeaponGuid)
            If BaseWeapon.Element("Shadows") <> "" Then
                WeaponGuid = BaseWeapon.GetFKGuid("Shadows")
            End If

            'is this a natural attack?
            If BaseWeapon.Type = Objects.NaturalWeaponDefinitionType Then
                WeaponGuid = General.ConvertToObjectKey(BaseWeapon.Element("AttackType"), XML.DBTypes.NaturalWeapons)
            End If

            Return CalculateModifiers(References.DamageRollSpecificWeapon, 1000, WeaponGuid)

        End Function

        'grapple roll
        Public Function GrappleRoll() As Integer
            Return GetModifierInteger(References.GrappleRoll, 1000) + AttackRollSpecificWeapon(References.Grapple)
        End Function

        'skill - does not include ability modifier - should only used by Skills.SkillModifier
        Public Function Skill(ByVal SkillKey As Objects.ObjectKey) As Integer
            If _SkillModifiers Is Nothing Then Return 0

            'get skill def
            Dim SkillDef As Objects.ObjectData = Caches.Skills.Item(SkillKey)

            'determine if group skill mods required.
            Dim GroupMod As Integer = 0
            Dim SkillGroup As String = SkillDef.Element("SkillGroup")
            If SkillGroup <> "" Then GroupMod = SkillGroupModifier(SkillGroup)

            'get skill mod + group mod OR just group mod if no existing mods for this skill
            If _SkillModifiers.Contains(SkillKey) Then
                Return CInt(_SkillModifiers.Item(SkillKey)) + GroupMod
            ElseIf GroupMod > 0 Then
                Return GroupMod
            Else
                Return 0
            End If
        End Function

        'skill group modifiers
        Public Function SkillGroupModifier(ByVal SkillGroup As String) As Integer
            Select Case SkillGroup
                Case "Craft"
                    Return CInt(_SkillGroupModifiers.Item(References.Craft))
                Case "Knowledge"
                    Return CInt(_SkillGroupModifiers.Item(References.Knowledge))
                Case "Perform"
                    Return CInt(_SkillGroupModifiers.Item(References.Perform))
                Case "Profession"
                    Return CInt(_SkillGroupModifiers.Item(References.Profession))
            End Select
        End Function

#End Region

#Region "Calculate Modifiers"

        'get the modifiers (without limiters) for a given system element
        Public Sub CalculateModifiers(ByVal SystemElementGuid As Objects.ObjectKey, ByVal Level As Integer)
            'get modifier according to type
            Dim Modifiers As Hashtable = GetModifiersByType(SystemElementGuid, Objects.ObjectKey.Empty, Level)

            'get modifiers to AC
            If SystemElementGuid.Equals(References.ArmourClass) And Modifiers.Count > 0 Then
                Dim Modifier As Integer
                _TouchACMod = 0
                _FlatFootedACMod = 0
                _HelplessACModifier = 0

                If Modifiers.Contains("Armor") Then
                    Modifier = DirectCast(Modifiers.Item("Armor"), Integer)
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Competence") Then
                    Modifier = DirectCast(Modifiers.Item("Competence"), Integer)
                    _TouchACMod += Modifier
                End If
                If Modifiers.Contains("Deflection") Then
                    Modifier = DirectCast(Modifiers.Item("Deflection"), Integer)
                    _TouchACMod += Modifier
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Dodge") Then
                    _TouchACMod += DirectCast(Modifiers.Item("Dodge"), Integer)
                End If
                If Modifiers.Contains("Enhancement") Then
                    Modifier = DirectCast(Modifiers.Item("Enhancement"), Integer)
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Insight") Then
                    Modifier = DirectCast(Modifiers.Item("Insight"), Integer)
                    _TouchACMod += Modifier
                End If
                If Modifiers.Contains("Luck") Then
                    Modifier = DirectCast(Modifiers.Item("Luck"), Integer)
                    _TouchACMod += Modifier
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Morale") Then
                    Modifier = DirectCast(Modifiers.Item("Morale"), Integer)
                    _TouchACMod += Modifier
                End If
                If Modifiers.Contains("Natural Armor") Then
                    Modifier = DirectCast(Modifiers.Item("Natural Armor"), Integer)
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Natural Armor (Base)") Then
                    Modifier = DirectCast(Modifiers.Item("Natural Armor (Base)"), Integer)
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Profane") Then
                    Modifier = DirectCast(Modifiers.Item("Profane"), Integer)
                    _TouchACMod += Modifier
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Resistance") Then
                    Modifier = DirectCast(Modifiers.Item("Resistance"), Integer)
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Sacred") Then
                    Modifier = DirectCast(Modifiers.Item("Sacred"), Integer)
                    _TouchACMod += Modifier
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Shield") Then
                    Modifier = DirectCast(Modifiers.Item("Shield"), Integer)
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
                If Modifiers.Contains("Size") Then
                    Modifier = DirectCast(Modifiers.Item("Size"), Integer)
                    _TouchACMod += Modifier
                    _FlatFootedACMod += Modifier
                    _HelplessACModifier += Modifier
                End If
            End If

            'add them all up
            If Modifiers.Count > 0 Then
                Dim ModifierList As ICollection = Modifiers.Values
                Dim ModifierTotal As Integer

                For Each ModifierValue As Integer In ModifierList
                    ModifierTotal += ModifierValue
                Next

                Me.Modifiers.Item(SystemElementGuid) = ModifierTotal
            End If
        End Sub

        'get the modifiers (without limiters) for a given system element and focus guid
        Private Function CalculateModifiers(ByVal SystemElementGuid As Objects.ObjectKey, ByVal Level As Integer, ByVal FocusGuid As Objects.ObjectKey) As Integer
            'get modifier according to type
            Dim Modifiers As Hashtable = GetModifiersByType(SystemElementGuid, FocusGuid, Level)

            'add them all up
            Dim ModifierList As ICollection = Modifiers.Values
            Dim ModifierTotal As Integer

            For Each ModifierValue As Integer In ModifierList
                ModifierTotal += ModifierValue
            Next

            Return ModifierTotal

        End Function

        'get the modifiers (without limiters) for each modifier type for given system element and optionally a focus
        Public Function GetModifiersByType(ByVal SystemElementGuid As Objects.ObjectKey, ByVal FocusGuid As Objects.ObjectKey, ByVal Level As Integer) As Hashtable
            Dim Modifiers As New Hashtable
            Dim Modifier As New Objects.ObjectData
            Dim ModifierType As String
            Dim Flag As Boolean
            Dim ModifierNumber, CurrentModifier As Integer
            Dim Component As Components.ComponentData

            Dim Components As ArrayList = _Character.Components.Modifiers.ItemData(SystemElementGuid, Level)

            If SystemElementGuid.Equals(References.ReflexSavingThrow) OrElse SystemElementGuid.Equals(References.WillSavingThrow) OrElse SystemElementGuid.Equals(References.FortitudeSavingThrow) Then
                Components.AddRange(_Character.Components.Modifiers.ItemData(References.SavingThrow, Level))
            End If

            If Components.Count = 0 Then Return Modifiers

            For Each Item As Library.LibraryData In Components

                'get the component record
                Component = DirectCast(Item.Data, Components.ComponentData)

                If Component.ValidInfo.Valid And ((Component.ItemSource And _IncludeItems) Or (Component.ItemSource = False)) And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then

                    'load or get from transient object
                    If Component.TransientObject.ObjectGUID.IsNotEmpty Then
                        Modifier = Component.TransientObject
                    Else
                        Modifier.Load(Component.Key)
                    End If

                    Flag = True

                    'ignore modifiers with limiters
                    If Modifier.Element("Limiter") <> "" Then Flag = False

                    If Not FocusGuid.Equals(Component.FocusGuid) Then Flag = False

                    'check to see its not a user added modifier which as been disalbed
                    If Component.UserModifierDisabled = True Then Flag = False

                    'ignore morale modifiers if non intelligent
                    If Modifier.Element("ModifierType") = "Morale" AndAlso Character.NonInt Then Flag = False

                    'process the modifier
                    If Flag Then

                        'get the modifier
                        ModifierType = Modifier.Element("ModifierType")
                        Select Case Modifier.Element("ModifierCategory")
                            Case "Normal Modifier"
                                ModifierNumber = Modifier.ElementAsInteger("Modifier")

                            Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                                If Level > _Character.CharacterLevel Then
                                    ModifierNumber = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.AbilityScore(Modifier.Element("Modifier"))).Modifier
                                Else
                                    ModifierNumber = Rules.AbilityScores.AbilityScore(_Character.Levels(Level).AbilityScore(Modifier.Element("Modifier"))).Modifier
                                End If

                                If Modifier.Element("ModifierCategory") = "Use Ability Modifier (positive only)" AndAlso ModifierNumber < 0 Then
                                    ModifierNumber = 0
                                ElseIf Modifier.Element("ModifierCategory") = "Use Ability Modifier (+1 minimum)" AndAlso ModifierNumber < 1 Then
                                    ModifierNumber = 1
                                End If

                            Case "Complex Modifier"
                                If Level > _Character.CharacterLevel Then
                                    ModifierNumber = _Character.Components.SetValueCalculator(Modifier, _Character.CharacterLevel)
                                Else
                                    ModifierNumber = _Character.Components.SetValueCalculator(Modifier, Level)
                                End If

                            Case Else
                                Flag = False
                        End Select

                        'stack
                        If Flag Then
                            If Modifiers.Contains(ModifierType) Then

                                CurrentModifier = DirectCast(Modifiers.Item(ModifierType), Integer)

                                If ModifierType = "Dodge" Or ModifierType = "Undefined" Then
                                    Modifiers.Item(ModifierType) = CurrentModifier + ModifierNumber
                                Else
                                    If ModifierNumber > CurrentModifier Then
                                        Modifiers.Item(ModifierType) = ModifierNumber
                                    End If
                                End If
                            Else
                                Modifiers.Add(ModifierType, ModifierNumber)
                            End If
                        End If


                    End If
                End If
            Next

            Return Modifiers

        End Function

        'retrieve skill modifiers
        Private Sub GetSkillModifiers(ByVal Level As Integer)
            Dim Skills As New ObjectHashtable
            Dim Modifiers As Hashtable
            Dim Modifier As New Objects.ObjectData
            Dim ModifierType As String
            Dim Flag As Boolean
            Dim ModifierNumber, CurrentModifier As Integer
            Dim Component As Components.ComponentData

            Dim Components As ArrayList = _Character.Components.Modifiers.ItemData(References.Skill, Level)
            If Components.Count = 0 Then Exit Sub

            For Each Item As Library.LibraryData In Components

                'get the component record
                Component = DirectCast(Item.Data, Components.ComponentData)

                If Component.ValidInfo.Valid And ((Component.ItemSource And _IncludeItems) Or (Component.ItemSource = False)) And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then

                    'load or get from transient object
                    If Component.TransientObject.ObjectGUID.IsNotEmpty Then
                        Modifier = Component.TransientObject
                    Else
                        Modifier.Load(Component.Key)
                    End If

                    Flag = True

                    'ignore modifiers with limiters
                    If Modifier.Element("Limiter") <> "" Then Flag = False

                    'process the modifier
                    If Flag Then

                        'get the modifier
                        ModifierType = Modifier.Element("ModifierType")
                        Select Case Modifier.Element("ModifierCategory")
                            Case "Normal Modifier"
                                ModifierNumber = Modifier.ElementAsInteger("Modifier")
                            Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                                If Level > _Character.CharacterLevel Then
                                    ModifierNumber = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.AbilityScore(Modifier.Element("Modifier"))).Modifier
                                Else
                                    ModifierNumber = Rules.AbilityScores.AbilityScore(_Character.Levels(Level).AbilityScore(Modifier.Element("Modifier"))).Modifier
                                End If

                                If Modifier.Element("ModifierCategory") = "Use Ability Modifier (positive only)" AndAlso ModifierNumber < 0 Then
                                    ModifierNumber = 0
                                ElseIf Modifier.Element("ModifierCategory") = "Use Ability Modifier (+1 minimum)" AndAlso ModifierNumber < 1 Then
                                    ModifierNumber = 1
                                End If

                            Case "Complex Modifier"
                                If Level > _Character.CharacterLevel Then
                                    ModifierNumber = _Character.Components.SetValueCalculator(Modifier, _Character.CharacterLevel)
                                Else
                                    ModifierNumber = _Character.Components.SetValueCalculator(Modifier, Level)
                                End If
                        End Select

                        'stack
                        If Skills.Contains(Component.FocusGuid) Then
                            Modifiers = DirectCast(Skills.Item(Component.FocusGuid), Hashtable)
                        Else
                            Modifiers = New Hashtable
                            Skills.Add(Component.FocusGuid, Modifiers)
                        End If
                        If Modifiers.Contains(ModifierType) Then
                            CurrentModifier = DirectCast(Modifiers.Item(ModifierType), Integer)
                            If ModifierType = "Dodge" Or ModifierType = "Undefined" Then
                                Modifiers.Item(ModifierType) = CurrentModifier + ModifierNumber
                            Else
                                If ModifierNumber > CurrentModifier Then
                                    Modifiers.Item(ModifierType) = ModifierNumber
                                End If
                            End If
                        Else
                            Modifiers.Add(ModifierType, ModifierNumber)
                        End If

                        Skills.Item(Component.FocusGuid) = Modifiers
                    End If
                End If
            Next

            'total up modifiers for each skills
            Dim TotalModifier As Integer
            _SkillModifiers = New ObjectHashtable

            For Each Skill As DictionaryEntry In Skills

                TotalModifier = 0

                For Each SkillModifier As DictionaryEntry In DirectCast(Skill.Value, Hashtable)
                    TotalModifier += DirectCast(SkillModifier.Value, Integer)
                Next

                _SkillModifiers.Add(New Objects.ObjectKey(CStr(Skill.Key)), TotalModifier)
            Next

        End Sub

        'retrieve skill group modifiers
        Private Sub GetSkillGroupModifiers(ByVal Level As Integer)
            Dim Modifiers As Hashtable
            Dim Components As ArrayList = _Character.Components.Modifiers.ItemData(References.SkillGroup, Level)
            If Components.Count = 0 Then Exit Sub

            Dim SkillGroups As New ObjectHashtable

            For Each Item As Library.LibraryData In Components

                'get the component record
                Dim Component As Components.ComponentData = DirectCast(Item.Data, Components.ComponentData)

                If Component.ValidInfo.Valid And ((Component.ItemSource And _IncludeItems) Or (Component.ItemSource = False)) And Component.LevelAcquired <= Level And Component.LevelLost >= Level Then

                    'load or get from transient object
                    Dim Modifier As New Objects.ObjectData
                    If Component.TransientObject.ObjectGUID.IsNotEmpty Then
                        Modifier = Component.TransientObject
                    Else
                        Modifier.Load(Component.Key)
                    End If

                    Dim Flag As Boolean = True

                    'ignore modifiers with limiters
                    If Modifier.Element("Limiter") <> "" Then Flag = False

                    'process the modifier
                    If Flag Then

                        'get the modifier
                        Dim ModifierType As String = Modifier.Element("ModifierType")
                        Dim ModifierNumber As Integer
                        Select Case Modifier.Element("ModifierCategory")
                            Case "Normal Modifier"
                                ModifierNumber = Modifier.ElementAsInteger("Modifier")
                            Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                                If Level > _Character.CharacterLevel Then
                                    ModifierNumber = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.AbilityScore(Modifier.Element("Modifier"))).Modifier
                                Else
                                    ModifierNumber = Rules.AbilityScores.AbilityScore(_Character.Levels(Level).AbilityScore(Modifier.Element("Modifier"))).Modifier
                                End If

                                If Modifier.Element("ModifierCategory") = "Use Ability Modifier (positive only)" AndAlso ModifierNumber < 0 Then
                                    ModifierNumber = 0
                                ElseIf Modifier.Element("ModifierCategory") = "Use Ability Modifier (+1 minimum)" AndAlso ModifierNumber < 1 Then
                                    ModifierNumber = 1
                                End If

                            Case "Complex Modifier"
                                If Level > _Character.CharacterLevel Then
                                    ModifierNumber = _Character.Components.SetValueCalculator(Modifier, _Character.CharacterLevel)
                                Else
                                    ModifierNumber = _Character.Components.SetValueCalculator(Modifier, Level)
                                End If
                        End Select

                        'stack
                        If SkillGroups.Contains(Component.FocusGuid) Then
                            Modifiers = DirectCast(SkillGroups.Item(Component.FocusGuid), Hashtable)
                        Else
                            Modifiers = New Hashtable
                            SkillGroups.Add(Component.FocusGuid, Modifiers)
                        End If

                        If Modifiers.Contains(ModifierType) Then

                            Dim CurrentModifier As Integer = DirectCast(Modifiers.Item(ModifierType), Integer)

                            If ModifierType = "Dodge" Or ModifierType = "Undefined" Then
                                Modifiers.Item(ModifierType) = CurrentModifier + ModifierNumber
                            Else
                                If ModifierNumber > CurrentModifier Then
                                    Modifiers.Item(ModifierType) = ModifierNumber
                                End If
                            End If
                        Else
                            Modifiers.Add(ModifierType, ModifierNumber)
                        End If

                        SkillGroups.Item(Component.FocusGuid) = Modifiers
                    End If
                End If
            Next

            'total up modifiers for each skills
            Dim TotalModifier As Integer
            _SkillGroupModifiers = New ObjectHashtable

            For Each SkillGroup As DictionaryEntry In SkillGroups

                TotalModifier = 0

                For Each SkillModifier As DictionaryEntry In DirectCast(SkillGroup.Value, Hashtable)
                    TotalModifier += DirectCast(SkillModifier.Value, Integer)
                Next

                _SkillGroupModifiers.Add(New Objects.ObjectKey(CStr(SkillGroup.Key)), TotalModifier)
            Next

        End Sub

#End Region

#Region "Display"

        'modifier flag
        Public Shared Function ModifierFlag(ByVal Current As Integer, ByVal Base As Integer) As Modifiers.Modifier
            If Current > Base Then
                Return Modifier.Positive
            ElseIf Current < Base Then
                Return Modifier.Negative
            Else
                Return Modifier.None
            End If
        End Function

#End Region

    End Class

End Namespace