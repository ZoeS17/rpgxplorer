Option Strict On
Option Explicit On

Imports System.Collections.Generic

Namespace Rules

    Public Class Prerequisites

        'this class contains all the code for checking prerequisites 

#Region "Member Variables"

        Private Character As Rules.Character
        Private Prerequisite, PrerequisiteChild As Objects.ObjectData
        Private CharacterLevel As Integer
        Private Level As Character.Level

        'feats with foci
        Private _FeatFocusChoices As Intersection
        Private _FocusFinal As Intersection

        'Group Matches
        Private SkillGroup As Hashtable
        Private FeatGroup As Hashtable

        'Feat Prerequisites with a focus
        Private FeatFocusGUID As Objects.ObjectKey

#End Region

#Region "Properties"

        Public ReadOnly Property FeatFocusChoices(ByVal FeatGuid As Objects.ObjectKey) As ArrayList
            Get
                If _FocusFinal.ContainsItem(FeatGuid) Then
                    Return _FocusFinal.Intersection(FeatGuid)
                Else
                    Return Nothing
                End If
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Me.Character = Character
        End Sub

        ''check to see if a character has the prerequisite
        'Public Function HasPrerequisite(ByVal Prerequisite As Objects.ObjectData, ByVal CharacterLevel As Integer, Optional ByVal CheckingExisting As Boolean = False, Optional ByVal FocusGuid As Object = Nothing) As Boolean

        '    Dim Result As Boolean
        '    Dim Count As Integer

        '    'set vars
        '    Me.Prerequisite = Prerequisite
        '    Me.CharacterLevel = CharacterLevel
        '    Level = Character.Levels(CharacterLevel)
        '    Count = 0

        '    SkillGroup = New Hashtable
        '    FeatGroup = New Hashtable

        '    'Focus of parent feat
        '    If Not FocusGuid Is Nothing Then FeatFocusGUID = DirectCast(FocusGuid, Objects.ObjectKey)

        '    'loop through each prereq
        '    For Each PrerequisiteChild In Prerequisite.ChildrenOfType(Objects.PrerequisiteChildType)

        '        'call the correct function to get the result
        '        Result = GetResult(PrerequisiteChild, CheckingExisting)

        '        If Result = False And Prerequisite.Element("Criteria") = "AllRequired" Then
        '            Return False
        '        Else
        '            If Result = True Then Count += 1
        '        End If
        '    Next

        '    'return result
        '    Dim Parent As Objects.ObjectData

        '    If Prerequisite.Element("Criteria") = "AllRequired" Then

        '        If Not CheckingExisting Then
        '            'if for feat with focus then update focus choices
        '            Parent.Load(Prerequisite.ParentGUID)
        '            If Parent.Type = Objects.FeatDefinitionType And Parent.Element("HasFocus") = "Yes" Then
        '                For Each Focus As Objects.ObjectKey In _FeatFocusChoices.Intersection(Parent.ObjectGUID)
        '                    _FocusFinal.AddItem(Parent.ObjectGUID, Prerequisite.ObjectGUID, Focus)
        '                Next
        '                _FeatFocusChoices.RemoveItem(Parent.ObjectGUID)
        '            End If
        '        End If

        '        Return True
        '    Else
        '        If Count >= Prerequisite.ElementAsInteger("CriteriaNo") Then

        '            If Not CheckingExisting Then
        '                'if for feat with focus then update focus choices
        '                Parent.Load(Prerequisite.ParentGUID)
        '                If Parent.Type = Objects.FeatDefinitionType And Parent.Element("HasFocus") = "Yes" Then
        '                    For Each Focus As Objects.ObjectKey In _FeatFocusChoices.Superset(Parent.ObjectGUID)
        '                        _FocusFinal.AddItem(Parent.ObjectGUID, Prerequisite.ObjectGUID, Focus)
        '                    Next
        '                    _FeatFocusChoices.RemoveItem(Parent.ObjectGUID)
        '                End If
        '            End If
        '            Return True
        '        Else
        '            Return False
        '        End If
        '    End If
        'End Function

        'check to see if a character has the prerequisite - provided children version
        Public Function HasPrerequisite(ByVal Prerequisite As Objects.ObjectData, ByVal CharacterLevel As Integer, ByVal Children As Objects.ObjectDataCollection, Optional ByVal CheckingExisting As Boolean = False, Optional ByVal FocusGuid As Object = Nothing) As Boolean

            Dim Result As Boolean
            Dim Count As Integer

            'set vars
            Me.Prerequisite = Prerequisite
            Me.CharacterLevel = CharacterLevel
            Level = Character.Levels(CharacterLevel)
            Count = 0

            SkillGroup = New Hashtable
            FeatGroup = New Hashtable

            'Focus of parent feat
            If Not FocusGuid Is Nothing Then FeatFocusGUID = DirectCast(FocusGuid, Objects.ObjectKey)

            'loop through each prereq
            For Each PrerequisiteChild In Children
                Result = GetResult(PrerequisiteChild, CheckingExisting)

                If Result = False And Prerequisite.Element("Criteria") = "AllRequired" Then
                    Return False
                Else
                    If Result = True Then Count += 1
                End If
            Next

            'return result
            Dim Parent As New Objects.ObjectData

            If Prerequisite.Element("Criteria") = "AllRequired" Then
                If Not CheckingExisting Then
                    'if for feat with focus then update focus choices
                    Parent.Load(Prerequisite.ParentGUID)
                    If Parent.Type = Objects.FeatDefinitionType And Parent.Element("HasFocus") = "Yes" Then
                        For Each Focus As Objects.ObjectKey In _FeatFocusChoices.Intersection(Parent.ObjectGUID)
                            _FocusFinal.AddItem(Parent.ObjectGUID, Prerequisite.ObjectGUID, Focus)
                        Next
                        _FeatFocusChoices.RemoveItem(Parent.ObjectGUID)
                    End If
                End If

                Return True
            Else
                If Count >= Prerequisite.ElementAsInteger("CriteriaNo") Then
                    If Not CheckingExisting Then
                        'if for feat with focus then update focus choices
                        Parent.Load(Prerequisite.ParentGUID)
                        If Parent.Type = Objects.FeatDefinitionType And Parent.Element("HasFocus") = "Yes" Then
                            For Each Focus As Objects.ObjectKey In _FeatFocusChoices.Superset(Parent.ObjectGUID)
                                _FocusFinal.AddItem(Parent.ObjectGUID, Prerequisite.ObjectGUID, Focus)
                            Next
                            _FeatFocusChoices.RemoveItem(Parent.ObjectGUID)
                        End If
                    End If
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

        'calls the correct function to calculate the result of a prerequisite
        Private Function GetResult(ByVal PrerequisiteChild As Objects.ObjectData, ByVal CheckingExisting As Boolean) As Boolean
            Dim Result As Boolean

            'check the prerequisite
            Select Case PrerequisiteChild.Element("PrerequisiteType")
                Case "Alignment"
                    Result = HasAlignment()
                Case "Ability Score"
                    Result = HasAbilityScore()
                Case "Base Attack Bonus"
                    Result = HasBAB()
                Case "Caster Level"
                    Result = HasCasterLevel()
                Case "Cast Specific Spell"
                    Result = CanCastSpecificSpell()
                Case "Cast Magic of Level"
                    Result = CanCastMagicOfLevel()
                Case "Character Level"
                    Result = HasCharacterLevel()
                Case "Class Level"
                    Result = HasClassLevel()
                Case "Damage Reduction (Racial/Class)"
                    Result = HasDamageReduction()
                Case "Deity"
                    Result = HasDeity()
                Case "Domain"
                    Result = HasDomain()
                Case "Feat"
                    If CheckingExisting Then
                        Result = HasFeat_CheckingExistingFeat()
                    Else
                        Result = HasFeat_SelectingNewFeat()
                    End If
                Case "Feature"
                    Result = HasFeature()
                Case "Feat of Type"
                    Result = HasFeatOfType()
                Case "First Level Only"
                    If CheckingExisting Then
                        Result = True
                    Else
                        Result = (CharacterLevel = 1)
                    End If
                Case "Flurry of Blows Ability"
                    Result = HasFlurry()
                Case "Fly Speed"
                    Result = CanFly()
                Case "Gender"
                    Result = IsOfGender()
                Case "Language"
                    Result = HasLanguage()
                Case "Manifester Level"
                    Result = HasManifesterLevel()
                Case "Manifest Power of Level"
                    Result = CanManifestPowerOfLevel()
                Case "Manifest Specific Power"
                    Result = CanManifestSpecificPower()
                Case "Power Point Reserve"
                    Result = HasPowerPointReserve()
                Case "Psionic Specialization"
                    Result = HasPsionicSpecialization()
                Case "Psi-Like Ability of Manifester Level"
                    Result = HasPsiLikeofManifesterLevel()
                Case "Race"
                    Result = IsOfRace()
                Case "Saving Throw"
                    Result = HasSavingThrow()
                Case "Saving Throw (Base)"
                    Result = HasSavingThrowBase()
                Case "Size"
                    Result = IsOfSize()
                Case "Skill"
                    Result = HasSkillRanks()
                Case "Skill Group"
                    Result = HasSkillGroupRanks()
                Case "Spell Resistance"
                    Result = HasSpellResistance()
                Case "Spell-Like Ability of Caster Level"
                    Result = HasSpellLikeofCasterLevel()
                Case "Cast Spells from School"
                    Result = CanCastSpellsFromSchool()
                Case "Cast Spells from Subschool"
                    Result = CanCastSpellsFromSubSchool()
                Case "Cast Spells with Descriptor"
                    Result = CanCastSpellsWithDescriptor()
                Case "Manifest Powers from Discipline"
                    Result = CanManifestPowersFromDiscipline()
                Case "Manifest Powers from Subdiscipline"
                    Result = CanManifestPowersFromSubDiscipline()
                Case "Manifest Powers with Descriptor"
                    Result = CanManifestPowersWithDescriptor()
                Case Else
                    Throw New Exceptions.DevelopmentException("Prerequisite type not defined")
            End Select

            Return Result

        End Function

        'ability score
        Private Function HasAbilityScore() As Boolean
            Dim Ability As String
            Dim AbilityScore As Integer

            Ability = PrerequisiteChild.Element("Prerequisite")
            AbilityScore = PrerequisiteChild.ElementAsInteger("Of")

            Select Case Ability
                Case "STR"
                    If Level.STR >= AbilityScore Then Return True Else Return False
                Case "DEX"
                    If Level.DEX >= AbilityScore Then Return True Else Return False
                Case "CON"
                    If Level.CON >= AbilityScore Then Return True Else Return False
                Case "INT"
                    If Level.INT >= AbilityScore Then Return True Else Return False
                Case "WIS"
                    If Level.WIS >= AbilityScore Then Return True Else Return False
                Case "CHA"
                    If Level.CHA >= AbilityScore Then Return True Else Return False
            End Select

        End Function

        'alignment
        Private Function HasAlignment() As Boolean
            If PrerequisiteChild.Element("Prerequisite") = Character.CharacterObject.Element("Alignment") Then
                Return True
            Else
                Return False
            End If
        End Function

        'bab
        Private Function HasBAB() As Boolean
            If Level.BAB >= PrerequisiteChild.ElementAsInteger("Of") Then
                Return True
            Else
                Return False
            End If
        End Function

        'caster level
        Private Function HasCasterLevel() As Boolean
            Dim Enumerator As IDictionaryEnumerator
            Dim CasterLevel As Rules.Character.CasterLevel
            If Not Level.CasterLevels Is Nothing Then
                Enumerator = Level.CasterLevels.GetEnumerator
                While Enumerator.MoveNext
                    CasterLevel = DirectCast(Enumerator.Value, Rules.Character.CasterLevel)
                    If CasterLevel.Type = Character.CasterLevel.CasterType.Spellcaster Then
                        If CasterLevel.CasterLevel >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
                    End If
                End While
            End If
            Return False
        End Function

        'manifester level
        Private Function HasManifesterLevel() As Boolean
            Dim Enumerator As IDictionaryEnumerator
            Dim CasterLevel As Rules.Character.CasterLevel
            If Not Level.CasterLevels Is Nothing Then
                Enumerator = Level.CasterLevels.GetEnumerator
                While Enumerator.MoveNext
                    CasterLevel = DirectCast(Enumerator.Value, Rules.Character.CasterLevel)
                    If CasterLevel.Type = Character.CasterLevel.CasterType.Manifester Then
                        If CasterLevel.CasterLevel >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
                    End If
                End While
            End If
            Return False
        End Function

        'cast specific spell
        Private Function CanCastSpecificSpell() As Boolean
            Dim SpellKey As Objects.ObjectKey = PrerequisiteChild.GetFKGuid("Prerequisite")
            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                If Character.Spells.Contains(ClassKey, SpellKey) Then Return True
            Next
            Return False
        End Function

        'cast magic of level
        Private Function CanCastMagicOfLevel() As Boolean
            Dim ClassInfo As Rules.CharacterClass
            Dim ClassObject As Objects.ObjectData

            For Each ClassInfo In Character.CharacterClasses.Values

                ClassObject = ClassInfo.ClassObj

                Select Case PrerequisiteChild.Element("Prerequisite")
                    Case "Arcane"
                        If ClassObject.Element("CasterType").StartsWith("Arcane") Then
                            If Character.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, Level.CharacterLevel, True) >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
                        End If
                    Case "Divine"
                        If ClassObject.Element("CasterType").StartsWith("Divine") Then
                            If Character.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, Level.CharacterLevel, True) >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
                        End If
                End Select

            Next

            Return False

        End Function

        'can manifest power of level
        Private Function CanManifestPowerOfLevel() As Boolean
            Dim ClassInfo As Rules.CharacterClass
            For Each ClassInfo In Character.CharacterClasses.Values
                If ClassInfo.IsPsionic Then
                    If Character.Powers.GetMaxPowerLevel(ClassInfo, Level.CharacterLevel) >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
                End If
            Next
            Return False
        End Function

        'cast specific spell
        Private Function CanManifestSpecificPower() As Boolean
            Dim PowerKey As Objects.ObjectKey = PrerequisiteChild.GetFKGuid("Prerequisite")
            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                If Character.Powers.Contains(ClassKey, PowerKey) Then Return True
            Next
            Return False
        End Function

        'can manifest power of level
        Private Function HasPowerPointReserve() As Boolean
            Dim PowerPoints As New PowerPoints(Character)
            If PowerPoints.PowerPoints >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
            Return False
        End Function

        'character level
        Private Function HasCharacterLevel() As Boolean
            If Level.CharacterLevel >= PrerequisiteChild.ElementAsInteger("Of") Then Return True Else Return False
        End Function

        'class level
        Private Function HasClassLevel() As Boolean
            Dim ClassLevel As Rules.Character.Level

            For n As Integer = 1 To CharacterLevel
                ClassLevel = Character.Levels(n)
                If ClassLevel.ClassGuid.Equals(PrerequisiteChild.GetFKGuid("Prerequisite")) And ClassLevel.ClassLevel >= PrerequisiteChild.ElementAsInteger("Of") Then Return True
            Next

            Return False

        End Function

        'deity
        Private Function HasDeity() As Boolean
            If Character.CharacterObject.GetFKGuid("Deity").Equals(PrerequisiteChild.GetFKGuid("Prerequisite")) Then
                Return True
            Else
                Return False
            End If
        End Function

        'domain
        Private Function HasDomain() As Boolean
            Return Character.Domains.HasDomain(PrerequisiteChild.GetFKGuid("Prerequisite"), CharacterLevel)
        End Function

        'psionic specialization
        Private Function HasPsionicSpecialization() As Boolean
            Return Character.PsionicSpecializations.HasSpecialization(PrerequisiteChild.GetFKGuid("Prerequisite"), CharacterLevel)
        End Function

        'Psi-like ability of manifester level
        Private Function HasPsiLikeofManifesterLevel() As Boolean
            Dim RequiredLevel As Integer = PrerequisiteChild.ElementAsInteger("Of")

            For Each PsiLike As Objects.ObjectData In Character.ExistingPsiLikeAbilities
                If PsiLike.ElementAsInteger("CasterLevel") >= RequiredLevel AndAlso PsiLike.ElementAsInteger("CharacterLevel") <= CharacterLevel Then
                    Return True
                End If
            Next

            For Each PsiLike As Objects.ObjectData In Character.NewPsiLikeAbilities
                If PsiLike.ElementAsInteger("CasterLevel") >= RequiredLevel AndAlso PsiLike.ElementAsInteger("CharacterLevel") <= CharacterLevel Then
                    Return True
                End If
            Next

            Return False

        End Function

        'feat
        Private Function HasFeat_CheckingExistingFeat() As Boolean
            Dim PrereqFeat As Objects.ObjectData
            Dim ParentFeat As Objects.ObjectData
            Dim TempFeat As Rules.Character.Feat

            PrereqFeat = PrerequisiteChild.GetFKObject("Prerequisite")
            ParentFeat = Prerequisite.Parent

            'see if character has the feat
            If Character.Feats.ContainsKey(PrereqFeat.ObjectGUID) Then

                If PrerequisiteChild.Element("Focus") = "" Then
                    For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat.ObjectGUID)
                        TempFeat = DirectCast(Item.Data, Rules.Character.Feat)
                        If (Not TempFeat.Disabled) AndAlso (Character.Components.IsFeatValid(PrereqFeat.ObjectGUID.ToString) OrElse TempFeat.IgnorePrerequisites) Then Return True
                    Next
                Else

                    Select Case PrerequisiteChild.Element("Focus")

                        Case "Any Weapon", "Any Skill", "Any School", "Any Domain", "Any Alignment", "Any Discipline", "Any Specialization", "Any Focus"
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat.ObjectGUID)
                                TempFeat = DirectCast(Item.Data, Rules.Character.Feat)
                                If (Not TempFeat.Disabled) Then Return True
                            Next

                        Case "The Same Weapon", "The Same Skill", "The Same School", "The Same Domain", "The Same Alignment", "The Same Discipline", "The Same Specialization"
                            'see if we have a feat that matches the focus of the parent
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat.ObjectGUID)
                                TempFeat = DirectCast(Item.Data, Rules.Character.Feat)
                                If TempFeat.FocusGuid.Equals(FeatFocusGUID) AndAlso (Not TempFeat.Disabled) Then Return True
                            Next

                        Case "Any Bludgeoning", "Any Piercing", "Any Slashing"

                            Dim DamageType As String = PrerequisiteChild.Element("Focus").Substring(4)

                            'see if we have a feat with a focus that matches the weapon type
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat.ObjectGUID)
                                TempFeat = DirectCast(Item.Data, Rules.Character.Feat)
                                If Not TempFeat.Disabled Then
                                    'get the focus object
                                    Dim Weapon As New Objects.ObjectData
                                    Weapon.Load(TempFeat.FocusGuid)

                                    If Weapon.ObjectGUID.IsNotEmpty Then
                                        If (Weapon.Element("DamageType").IndexOf(DamageType) >= 0) Then Return True
                                    End If

                                End If
                            Next

                        Case Else
                            'see if we have a feat that matches the focus of the prerequisite
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat.ObjectGUID)
                                TempFeat = DirectCast(Item.Data, Rules.Character.Feat)
                                If TempFeat.FocusGuid.Equals(PrerequisiteChild.GetFKGuid("Focus")) AndAlso (Not TempFeat.Disabled) Then Return True
                            Next

                    End Select

                End If
            End If

            'check System Abilites
            Select Case PrereqFeat.ObjectGUID.ToString

                Case References.MartialWeaponProficiency.ToString

                    If Character.Components.SystemAbilities(References.MartialWeaponsProficiency) Then
                        Return True
                    End If

                    If PrerequisiteChild.Element("Focus") = "The Same Weapon" Then
                        Select Case ParentFeat.Element("FocusType")
                            Case "Any Weapon", "Natural Weapon"
                                If FeatFocusGUID.Database = XML.DBTypes.NaturalWeapons Then Return True
                        End Select
                    End If

                Case References.SimpleWeaponProficiency.ToString

                    If Character.Components.SystemAbilities(References.SimpleWeaponsProficiency) Then
                        Return True
                    End If

                    If PrerequisiteChild.Element("Focus") = "The Same Weapon" Then
                        Select Case ParentFeat.Element("FocusType")
                            Case "Any Weapon", "Natural Weapon"
                                If FeatFocusGUID.Database = XML.DBTypes.NaturalWeapons Then Return True
                        End Select
                    End If

                Case References.ExoticWeaponProficiency.ToString

                    If PrerequisiteChild.Element("Focus") = "The Same Weapon" Then
                        Select Case ParentFeat.Element("FocusType")
                            Case "Any Weapon", "Natural Weapon"
                                If FeatFocusGUID.Database = XML.DBTypes.NaturalWeapons Then Return True
                        End Select
                    End If

            End Select

        End Function

        'feat - selecting new feat
        Private Function HasFeat_SelectingNewFeat() As Boolean
            Dim Feat As Rules.Character.Feat

            Dim ParentFeat As Objects.ObjectData
            Dim PrereqFeat As Objects.ObjectKey
            Dim Success As Boolean

            PrereqFeat = PrerequisiteChild.GetFKGuid("Prerequisite")
            ParentFeat = Prerequisite.Parent

            'check against each feat the character has at or below the required level
            Success = False

            If Character.Feats.ContainsKey(PrereqFeat) Then

                If PrerequisiteChild.Element("Focus") = "" Then

                    For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                        Feat = DirectCast(Item.Data, Rules.Character.Feat)
                        If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                            If Character.Components.IsFeatValid(PrereqFeat.ToString) OrElse Feat.IgnorePrerequisites Then
                                Return True
                            End If
                        End If
                    Next

                Else
                    Select Case PrerequisiteChild.Element("Focus")

                        Case "Any Weapon", "Any Skill", "Any School", "Any Domain", "Any Alignment", "Any Discipline", "Any Specialization", "Any Focus"
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                                Feat = DirectCast(Item.Data, Rules.Character.Feat)
                                If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                                    If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then
                                        Return True
                                    End If
                                End If
                            Next

                        Case "Any Bludgeoning", "Any Piercing", "Any Slashing"

                            Dim DamageType As String = PrerequisiteChild.Element("Focus").Substring(4)

                            'see if we have a feat with a focus that matches the weapon type
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                                Feat = DirectCast(Item.Data, Rules.Character.Feat)
                                If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                                    If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then

                                        'get the focus object
                                        Dim Weapon As New Objects.ObjectData
                                        Weapon.Load(Feat.FocusGuid)

                                        If Weapon.ObjectGUID.IsNotEmpty Then
                                            If (Weapon.Element("DamageType").IndexOf(DamageType) >= 0) Then Return True
                                        End If

                                    End If
                                End If
                            Next

                        Case "The Same Weapon"
                            Select Case ParentFeat.Element("FocusType")
                                Case "Any Weapon", "Simple Weapon", "Martial Weapon", "Exotic Weapon", "Ranged Weapon", "Melee Weapon", "Crossbow", "Natural Weapon"

                                    For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                                        Feat = DirectCast(Item.Data, Rules.Character.Feat)
                                        If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                                            If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then

                                                If Feat.FocusGuid.IsNotEmpty Then
                                                    Dim CorrectType As Boolean
                                                    CorrectType = False

                                                    'check that it is of the correct weapon type
                                                    If Feat.FocusGuid.Database = XML.DBTypes.NaturalWeapons Then
                                                        Select Case ParentFeat.Element("FocusType")
                                                            Case "Any Weapon"
                                                                CorrectType = True
                                                            Case "Natural Weapon"
                                                                CorrectType = True
                                                        End Select
                                                    Else
                                                        Dim FocusObject As New Objects.ObjectData
                                                        FocusObject.Load(Feat.FocusGuid)
                                                        Select Case ParentFeat.Element("FocusType")
                                                            Case "Any Weapon"
                                                                CorrectType = True
                                                            Case "Simple Weapon"
                                                                If FocusObject.Element("Training") = "Simple" Then CorrectType = True
                                                            Case "Martial Weapon"
                                                                If FocusObject.Element("Training") = "Martial" Then CorrectType = True
                                                            Case "Exotic Weapon"
                                                                If FocusObject.Element("Training") = "Exotic" Then CorrectType = True
                                                            Case "Melee Weapon"
                                                                If FocusObject.Element("WeaponType") = "Melee" Then CorrectType = True
                                                            Case "Ranged Weapon", "Crossbow"
                                                                If FocusObject.Element("WeaponType") = "Ranged" Then CorrectType = True
                                                        End Select
                                                    End If

                                                    'check to see that this focus has not already been used to match this particular prerequisite child
                                                    If CorrectType = True Then
                                                        If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid) Then
                                                            _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid)
                                                        End If

                                                        'continue looping through feats to build list of available foci.
                                                        Success = True
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Next
                            End Select

                        Case "The Same Skill"

                            If ParentFeat.Element("FocusType") = "Skill" Then
                                For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                                    Feat = DirectCast(Item.Data, Rules.Character.Feat)
                                    If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                                        If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then
                                            If Feat.FocusGuid.IsNotEmpty Then
                                                If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid) Then
                                                    _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid)
                                                End If
                                                Success = True
                                            End If
                                        End If
                                    End If
                                Next
                            End If

                        Case "The Same School"

                            If ParentFeat.Element("FocusType") = "Spell School" Then
                                For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                                    Feat = DirectCast(Item.Data, Rules.Character.Feat)
                                    If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                                        If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then
                                            If Feat.FocusGuid.IsNotEmpty Then
                                                If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid) Then
                                                    _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid)
                                                End If
                                                Success = True
                                            End If
                                        End If
                                    End If
                                Next
                            End If

                        Case "The Same Domain"
                            If ParentFeat.Element("FocusType") = "Domain" Then
                                Success = CheckFeatFocus(PrereqFeat, ParentFeat)
                            End If

                        Case "The Same Alignment"
                            If ParentFeat.Element("FocusType") = "Alignment" Then
                                Success = CheckFeatFocus(PrereqFeat, ParentFeat)
                            End If

                        Case "The Same Discipline"
                            If ParentFeat.Element("FocusType") = "Power Discipline" Then
                                Success = CheckFeatFocus(PrereqFeat, ParentFeat)
                            End If

                        Case "The Same Specialization"
                            If ParentFeat.Element("FocusType") = "Discipline Specialization" Then
                                Success = CheckFeatFocus(PrereqFeat, ParentFeat)
                            End If

                        Case Else
                            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                                Feat = DirectCast(Item.Data, Rules.Character.Feat)
                                If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                                    If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then
                                        If Feat.FocusGuid.Equals(PrerequisiteChild.GetFKGuid("Focus")) Then Return True
                                    End If
                                End If
                            Next

                    End Select
                End If
            End If

            'check system abilites also
            Select Case PrereqFeat.ToString
                Case References.MartialWeaponProficiency.ToString
                    If Character.Components.SystemAbilities(References.MartialWeaponsProficiency, CharacterLevel) Then
                        Select Case PrerequisiteChild.Element("Focus")
                            Case "The Same Weapon"

                                'character has martial weapons proficiency therefore add all martial weapons to list of available foci
                                Dim Weapons As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.Weapons, XPathQueries.MartialWeapons)

                                For Each Weapon As Objects.ObjectData In Weapons
                                    If AllowedWeaponType(ParentFeat, Weapon) Then
                                        If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Weapon.ObjectGUID) Then
                                            _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Weapon.ObjectGUID)
                                        End If
                                    End If
                                Next

                                'add racial weapons to the list also
                                For Each RacialWeapon As Objects.ObjectData In Character.RaceObject.ChildrenOfType(Objects.RacialWeaponType)
                                    If AllowedWeaponType(ParentFeat, RacialWeapon.GetFKObject("Weapon")) Then
                                        If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, RacialWeapon.GetFKGuid("Weapon")) Then
                                            _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, RacialWeapon.GetFKGuid("Weapon"))
                                        End If
                                    End If
                                Next

                                'add martial two-handed
                                For Each MartiaTwoHanded As Objects.ObjectData In Objects.GetObjectsByXPath(XML.DBTypes.Weapons, XPathQueries.MartialTwoHanded)
                                    If AllowedWeaponType(ParentFeat, MartiaTwoHanded) Then
                                        If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, MartiaTwoHanded.ObjectGUID) Then
                                            _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, MartiaTwoHanded.ObjectGUID)
                                        End If
                                    End If
                                Next

                                Success = True
                        End Select
                    End If

                Case References.SimpleWeaponProficiency.ToString

                    If Character.Components.SystemAbilities(References.SimpleWeaponsProficiency, CharacterLevel) Then
                        Select Case PrerequisiteChild.Element("Focus")
                            Case "The Same Weapon"
                                'character has simple weapons proficiency therefore add all simple weapons to list of available foci
                                Dim Weapons As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.Weapons, XPathQueries.SimpleWeapons)

                                For Each Weapon As Objects.ObjectData In Weapons
                                    If AllowedWeaponType(ParentFeat, Weapon) Then
                                        If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Weapon.ObjectGUID) Then
                                            _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Weapon.ObjectGUID)
                                        End If
                                    End If
                                Next

                                Success = True
                        End Select
                    End If

            End Select

            'add natural weapons if this is a proficiencey prerequisite
            Select Case PrereqFeat.ToString
                Case References.SimpleWeaponProficiency.ToString, References.MartialWeaponProficiency.ToString, References.ExoticWeaponProficiency.ToString
                    Select Case PrerequisiteChild.Element("Focus")
                        Case "The Same Weapon"
                            Select Case ParentFeat.Element("FocusType")
                                Case "Any Weapon", "Natural Weapon"
                                    For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
                                        'create weapon guid
                                        Dim WeaponKey As Objects.ObjectKey = General.ConvertToObjectKey(NaturalAttack, XML.DBTypes.NaturalWeapons)
                                        If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, WeaponKey) Then
                                            _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, WeaponKey)
                                            Success = True
                                        End If
                                    Next
                            End Select
                    End Select
            End Select

            If Success Then
                'at least one matching feat found, list of available foci produced.
                'user must select focus from this list.
                Return True
            Else
                Return False
            End If

        End Function

        'check that the character has a given feat, if found add its focus to the list of available options
        Private Function CheckFeatFocus(ByVal PrereqFeat As Objects.ObjectKey, ByVal ParentFeat As Objects.ObjectData) As Boolean
            Dim Success As Boolean
            Dim Feat As Rules.Character.Feat

            For Each Item As Library.LibraryData In Character.Feats.ItemData(PrereqFeat)
                Feat = DirectCast(Item.Data, Rules.Character.Feat)
                If Feat.LevelTaken <= CharacterLevel AndAlso Feat.Disabled = False Then
                    If Character.Components.IsFeatValid(PrereqFeat.ToString & Feat.FocusGuid.ToString) OrElse Feat.IgnorePrerequisites Then
                        If Feat.FocusGuid.IsNotEmpty Then
                            If Not _FeatFocusChoices.ContainsItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid) Then
                                _FeatFocusChoices.AddItem(ParentFeat.ObjectGUID, PrerequisiteChild.ObjectGUID, Feat.FocusGuid)
                            End If
                            Success = True
                        End If
                    End If
                End If
            Next

            Return Success

        End Function

        'helper function for feat prerequisites
        Private Function AllowedWeaponType(ByVal ParentFeat As Objects.ObjectData, ByVal WeaponObject As Objects.ObjectData) As Boolean
            Select Case ParentFeat.Element("FocusType")
                Case "Any Weapon"
                    Return True
                Case "Simple Weapon"
                    If WeaponObject.Element("Training") = "Simple" Then Return True
                Case "Martial Weapon"
                    If WeaponObject.Element("Training") = "Martial" Then Return True
                Case "Exotic Weapon"
                    If WeaponObject.Element("Training") = "Exotic" Then Return True
                Case "Melee Weapon"
                    If WeaponObject.Element("WeaponType") = "Melee" Then Return True
                Case "Ranged Weapon", "Crossbow"
                    If WeaponObject.Element("WeaponType") = "Ranged" Then Return True
            End Select
        End Function

        'damage reduction
        Private Function HasDamageReduction() As Boolean
            Return Character.Components.HasInnateDamageReduction(CharacterLevel)
        End Function

        'feature
        Private Function HasFeature() As Boolean
            Dim FeatureKey As Objects.ObjectKey = PrerequisiteChild.GetFKGuid("Prerequisite")

            If Character.Features.HasFeature(FeatureKey, CharacterLevel) Then
                If Character.Features.Features.ContainsKey(FeatureKey, CharacterLevel) Then
                    For Each item As Library.LibraryData In Character.Features.Features.ItemData(FeatureKey)
                        Dim TempFeature As Feature = DirectCast(item.Data, Feature)
                        If Not TempFeature.Disabled AndAlso (Character.Components.IsFeatureValid(FeatureKey.ToString) OrElse TempFeature.IgnorePrerequisites) Then
                            Return True
                        End If
                    Next
                Else
                    'its a calculated feature - dont check prereqs on these
                    Return True
                End If
            End If

            Return False

        End Function

        'feat of type
        Private Function HasFeatOfType() As Boolean
            Dim Feat As Character.Feat
            Dim FeatType As String = PrerequisiteChild.Element("Prerequisite")

            For Each Item As Library.LibraryData In Character.Feats.ItemData
                Feat = DirectCast(Item.Data, Character.Feat)
                If Feat.FeatType = FeatType And Feat.LevelTaken <= CharacterLevel Then
                    If Not FeatGroup.ContainsKey(Feat.FeatGuid) Then
                        FeatGroup.Add(Feat.FeatGuid, Nothing)
                        Return True
                    End If
                End If
            Next

            Return False

        End Function

        'flurry of blows
        Private Function HasFlurry() As Boolean
            Dim ClassLevel As New Objects.ObjectData
            Dim Flurry As Objects.ObjectData

            For Each ClassGuid As Objects.ObjectKey In Character.CharacterClasses.Keys
                ClassLevel.Load(Character.HighestClassLevelAtLevel(ClassGuid, CharacterLevel).ClassLevelGuid)
                If Not ClassLevel.IsEmpty Then
                    Flurry = ClassLevel.FirstChildOfType(Objects.FlurryOfBlowsType)
                    If Not Flurry.IsEmpty Then
                        Return True
                    End If
                End If
            Next

            Return False

        End Function

        'fly speed
        Private Function CanFly() As Boolean
            If Character.Fly <> "-" Then
                Return True
            Else
                Return False
            End If
        End Function

        'gender
        Private Function IsOfGender() As Boolean
            If Character.CharacterObject.Element("Gender") = PrerequisiteChild.Element("Prerequisite") Then
                Return True
            Else
                Return False
            End If
        End Function

        'language
        Private Function HasLanguage() As Boolean
            If Character.Languages.Contains(PrerequisiteChild.GetFKGuid("Prerequisite")) Then
                Return True
            Else
                Return False
            End If
        End Function

        'race
        Private Function IsOfRace() As Boolean

            If Character.CharacterObject.GetFKGuid("Race").Equals(PrerequisiteChild.GetFKGuid("Prerequisite")) Then
                Return True
            Else
                Dim RaceObject As Objects.ObjectData = Character.CharacterObject.GetFKObject("Race")
                If RaceObject.GetFKGuid("Equivalent").Equals(PrerequisiteChild.GetFKGuid("Prerequisite")) Then
                    Return True
                Else
                    Return False
                End If
            End If

        End Function

        'saving throw
        Private Function HasSavingThrow() As Boolean
            Select Case PrerequisiteChild.Element("Prerequisite")
                Case "Reflex"
                    If Level.Reflex >= PrerequisiteChild.ElementAsInteger("Of") Then
                        Return True
                    Else
                        Return False
                    End If
                Case "Fortitude"
                    If Level.Fortitude >= PrerequisiteChild.ElementAsInteger("Of") Then
                        Return True
                    Else
                        Return False
                    End If
                Case "Will"
                    If Level.Will >= PrerequisiteChild.ElementAsInteger("Of") Then
                        Return True
                    Else
                        Return False
                    End If
            End Select
        End Function

        'saving throw
        Private Function HasSavingThrowBase() As Boolean
            Select Case PrerequisiteChild.Element("Prerequisite")
                Case "Reflex"
                    If Level.ReflexBase >= PrerequisiteChild.ElementAsInteger("Of") Then
                        Return True
                    Else
                        Return False
                    End If
                Case "Fortitude"
                    If Level.FortitudeBase >= PrerequisiteChild.ElementAsInteger("Of") Then
                        Return True
                    Else
                        Return False
                    End If
                Case "Will"
                    If Level.WillBase >= PrerequisiteChild.ElementAsInteger("Of") Then
                        Return True
                    Else
                        Return False
                    End If
            End Select
        End Function

        'size
        Private Function IsOfSize() As Boolean
            If Character.Size = PrerequisiteChild.Element("Prerequisite") Then
                Return True
            Else
                Return False
            End If
        End Function

        'skill
        Private Function HasSkillRanks() As Boolean
            Dim Enumerator As IDictionaryEnumerator
            Dim SkillRank As Character.SkillRank
            Dim SkillGuid As Objects.ObjectKey = PrerequisiteChild.GetFKGuid("Prerequisite")

            Enumerator = Character.SkillRanks.GetEnumerator

            While Enumerator.MoveNext
                SkillRank = DirectCast(Enumerator.Value, Rules.Character.SkillRank)
                If SkillGuid.Equals(SkillRank.SkillGuid) Then
                    If PrerequisiteChild.ElementAsInteger("Of") <= SkillRank.RankAtLevel(CharacterLevel) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End While

            Return False

        End Function

        'skill group
        Private Function HasSkillGroupRanks() As Boolean
            Dim Enumerator As IDictionaryEnumerator
            Dim SkillRank As Rules.Character.SkillRank
            Dim SkillGroup As String = PrerequisiteChild.Element("Prerequisite")

            Enumerator = Character.SkillRanks.GetEnumerator

            While Enumerator.MoveNext
                SkillRank = DirectCast(Enumerator.Value, Rules.Character.SkillRank)
                If SkillGroup = SkillRank.SkillGroup Then
                    If PrerequisiteChild.ElementAsInteger("Of") <= SkillRank.RankAtLevel(CharacterLevel) Then
                        If Not Me.SkillGroup.ContainsKey(SkillRank.SkillGuid) Then
                            Me.SkillGroup.Add(SkillRank.SkillGuid, Nothing)
                            Return True
                        End If
                    End If
                End If

            End While

            Return False

        End Function

        'spell resistance
        Private Function HasSpellResistance() As Boolean
            If Character.Components.SpellResistance(CharacterLevel) >= PrerequisiteChild.ElementAsInteger("Of") Then
                Return True
            Else
                Return False
            End If
        End Function

        'spell-like ability of caster level
        Private Function HasSpellLikeofCasterLevel() As Boolean
            Dim RequiredLevel As Integer = PrerequisiteChild.ElementAsInteger("Of")

            For Each SpellLike As Objects.ObjectData In Character.ExistingSpellLikeAbilities
                If SpellLike.ElementAsInteger("CasterLevel") >= RequiredLevel AndAlso SpellLike.ElementAsInteger("CharacterLevel") <= CharacterLevel Then
                    Return True
                End If
            Next

            For Each SpellLike As Objects.ObjectData In Character.NewSpellLikeAbilities
                If SpellLike.ElementAsInteger("CasterLevel") >= RequiredLevel AndAlso SpellLike.ElementAsInteger("CharacterLevel") <= CharacterLevel Then
                    Return True
                End If
            Next

            Return False

        End Function

        'can cast
        Private Function CanCastSpellsFromSchool() As Boolean

            Dim CurrentCount As Integer = 0
            Dim RequiredCount As Integer = PrerequisiteChild.ElementAsInteger("Of")

            Dim SpellSchoolKey As Objects.ObjectKey
            SpellSchoolKey = PrerequisiteChild.GetFKGuid("Prerequisite")

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassLibrary As Library = Character.Spells.ClassSpellLibrary(ClassKey)
                If Not ClassLibrary Is Nothing Then
                    For Each ItemData As Library.LibraryData In ClassLibrary.ItemData
                        Dim Spell As Rules.Spell = DirectCast(ItemData.Data, Rules.Spell)

                        'do we have the spell at the required level
                        If Spell.CastableAtLevel(CharacterLevel) Then
                            If Rules.SpellList.SpellDefinition(Spell.SpellGuid).GetFKGuid("School").Equals(SpellSchoolKey) Then
                                CurrentCount += 1
                                If CurrentCount >= RequiredCount Then Return True
                            End If
                        End If

                    Next
                End If
            Next

            Return False

        End Function

        Private Function CanCastSpellsFromSubSchool() As Boolean

            Dim CurrentCount As Integer = 0
            Dim RequiredCount As Integer = PrerequisiteChild.ElementAsInteger("Of")

            Dim SpellSubschoolKey As Objects.ObjectKey
            SpellSubschoolKey = PrerequisiteChild.GetFKGuid("Prerequisite")

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassLibrary As Library = Character.Spells.ClassSpellLibrary(ClassKey)
                If Not ClassLibrary Is Nothing Then
                    For Each ItemData As Library.LibraryData In ClassLibrary.ItemData
                        Dim Spell As Rules.Spell = DirectCast(ItemData.Data, Rules.Spell)

                        'do we have the spell at the required level
                        If Spell.CastableAtLevel(CharacterLevel) Then
                            If Rules.SpellList.SpellDefinition(Spell.SpellGuid).GetFKGuid("Subschool").Equals(SpellSubschoolKey) Then
                                CurrentCount += 1
                                If CurrentCount >= RequiredCount Then Return True
                            End If
                        End If

                    Next
                End If
            Next

            Return False

        End Function

        Private Function CanCastSpellsWithDescriptor() As Boolean

            Dim CurrentCount As Integer = 0
            Dim RequiredCount As Integer = PrerequisiteChild.ElementAsInteger("Of")
            Dim Descriptor As String = PrerequisiteChild.Element("Prerequisite")

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassLibrary As Library = Character.Spells.ClassSpellLibrary(ClassKey)
                If Not ClassLibrary Is Nothing Then
                    For Each ItemData As Library.LibraryData In ClassLibrary.ItemData
                        Dim Spell As Rules.Spell = DirectCast(ItemData.Data, Rules.Spell)

                        'do we have the spell at the required level
                        If Spell.CastableAtLevel(CharacterLevel) Then

                            If Rules.SpellList.SpellDefinition(Spell.SpellGuid).Element("Descriptors").IndexOf(Descriptor) >= 0 Then
                                CurrentCount += 1
                                If CurrentCount >= RequiredCount Then Return True
                            End If

                        End If
                    Next
                End If
            Next

            Return False

        End Function

        'can manifest
        Private Function CanManifestPowersFromDiscipline() As Boolean

            Dim CurrentCount As Integer = 0
            Dim RequiredCount As Integer = PrerequisiteChild.ElementAsInteger("Of")

            Dim PowerDisciplineKey As Objects.ObjectKey
            PowerDisciplineKey = PrerequisiteChild.GetFKGuid("Prerequisite")

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassLibrary As Library = Character.Powers.ClassPowerLibrary(ClassKey)
                If Not ClassLibrary Is Nothing Then
                    For Each ItemData As Library.LibraryData In ClassLibrary.ItemData
                        Dim Power As Rules.Power = DirectCast(ItemData.Data, Rules.Power)

                        'do we have the spell at the required level
                        If Power.CastableAtLevel(CharacterLevel) Then
                            If Rules.PowerList.PowerDefinition(Power.PowerGuid).GetFKGuid("Discipline").Equals(PowerDisciplineKey) Then
                                CurrentCount += 1
                                If CurrentCount >= RequiredCount Then Return True
                            End If
                        End If

                    Next
                End If
            Next

            Return False

        End Function

        Private Function CanManifestPowersFromSubDiscipline() As Boolean

            Dim CurrentCount As Integer = 0
            Dim RequiredCount As Integer = PrerequisiteChild.ElementAsInteger("Of")

            Dim PowerSubDisciplineKey As Objects.ObjectKey
            PowerSubDisciplineKey = PrerequisiteChild.GetFKGuid("Prerequisite")

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassLibrary As Library = Character.Powers.ClassPowerLibrary(ClassKey)
                If Not ClassLibrary Is Nothing Then
                    For Each ItemData As Library.LibraryData In ClassLibrary.ItemData
                        Dim Power As Rules.Power = DirectCast(ItemData.Data, Rules.Power)

                        'do we have the spell at the required level
                        If Power.CastableAtLevel(CharacterLevel) Then
                            If Rules.PowerList.PowerDefinition(Power.PowerGuid).GetFKGuid("Subdiscipline").Equals(PowerSubDisciplineKey) Then
                                CurrentCount += 1
                                If CurrentCount >= RequiredCount Then Return True
                            End If
                        End If

                    Next
                End If
            Next

            Return False

        End Function

        Private Function CanManifestPowersWithDescriptor() As Boolean

            Dim CurrentCount As Integer = 0
            Dim RequiredCount As Integer = PrerequisiteChild.ElementAsInteger("Of")
            Dim Descriptor As String = PrerequisiteChild.Element("Prerequisite")

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassLibrary As Library = Character.Powers.ClassPowerLibrary(ClassKey)
                If Not ClassLibrary Is Nothing Then
                    For Each ItemData As Library.LibraryData In ClassLibrary.ItemData
                        Dim Power As Rules.Power = DirectCast(ItemData.Data, Rules.Power)

                        'do we have the spell at the required level
                        If Power.CastableAtLevel(CharacterLevel) Then
                            If Rules.PowerList.PowerDefinition(Power.PowerGuid).Element("Descriptors").IndexOf(Descriptor) >= 0 Then
                                CurrentCount += 1
                                If CurrentCount >= RequiredCount Then Return True
                            End If

                        End If
                    Next
                End If
            Next

            Return False

        End Function


#Region "Feat Same Focus"

        'call at the start of each feat selection process
        Public Sub Begin()
            _FeatFocusChoices = New Intersection
            _FocusFinal = New Intersection
        End Sub

        'call at the start of checking each individual feat
        'Public Sub BeginFeat(ByVal FeatGuid As Objects.ObjectKey)
        '    _FeatFocusChoices.RemoveItem(FeatGuid)
        'End Sub

#End Region

    End Class

End Namespace