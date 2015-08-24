Option Explicit On
Option Strict On

Imports RPGXplorer.Rules.Constants
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Imports System.Collections.Generic
Imports System.Threading

Namespace Rules

    Public Class AvailableFeats

        'this class lets us see what feats are available to a character
        'these methods are used in the leveling wizard

#Region "Member Variables"

        Private Character As Rules.Character        

#End Region

#Region "Constants"
        Public Const WarDomain As String = "War Domain"
        Public Const SpecificBonusFeat As String = "Specific Bonus Feat"
        Public Const BonusFeat As String = "Bonus Feat"
        Public Const FighterBonusFeat As String = "Fighter Bonus"
        Public Const SpecificBonusFeatChooseFocus As String = "Specific Bonus Feat"
        Public Const ChooseSpecificBonusFeat As String = "Choose Specific Feat"
        Public Const ChoosePathFeat As String = "Combat Style Starter"
        Public Const PathAutomaticFeat As String = "Combat Style Automatic"
        Public Const UserAdded As String = "User Added Feat"
#End Region

#Region "Structures"

        'structure used when viewing available feats during levelling
        Public Structure AvailableFeat
            Public FeatName As String
            Public FeatGuid As Objects.ObjectKey
            Public FeatType As String
            Public FighterBonus As Boolean
            Public Status As AvailableFeatStatus
            Public FocusType As String
            Public HTML As String

            'for the choose bonus feat form
            Public FocusName As String
            Public FocusGuid As Objects.ObjectKey

            Public IgnorePrerequisites As Boolean

            Public Overrides Function ToString() As String
                Return FeatName
            End Function

            Public Sub Clear()
                Try
                    FeatName = Nothing
                    FeatGuid = Nothing
                    FeatType = Nothing
                    FocusGuid = Nothing
                    FocusName = Nothing
                    FighterBonus = Nothing
                    Status = Nothing
                    FocusType = Nothing
                    HTML = Nothing
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Sub
        End Structure

        'status of the feat in terms of the character
        Public Enum AvailableFeatStatus
            AlreadyHave
            PrerequisitesMet
            PrerequisitesMetSelectFocus
            PrerequisitesMetFocusSelected
            PrerequisitesNotMet
        End Enum

        'different types of feat slot are acquired according to class and level
        Public Structure FeatSlot
            Public CharacterLevel As Integer
            Public SlotType As FeatSlotType

            Public FeatName As String
            Public FeatGuid As Objects.ObjectKey
            Public FeatType As String
            Public Source As FeatSource

            Public FocusGuid As Objects.ObjectKey
            Public FocusName As String

            Public ChooseBonusFeat As Objects.ObjectData

            Public Sub Clear()
                Try
                    CharacterLevel = Nothing
                    SlotType = Nothing
                    FeatName = Nothing
                    FeatGuid = Nothing
                    FeatType = Nothing
                    FocusGuid = Nothing
                    FocusName = Nothing
                    ChooseBonusFeat = Nothing
                    Source = Nothing
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Sub

            Public Sub FeatClear()
                FeatName = Nothing
                FeatGuid = Nothing
                FeatType = Nothing
                FocusGuid = Nothing
                FocusName = Nothing
            End Sub

            Public Overrides Function ToString() As String
                Try
                    If FocusName = "" Then
                        Return FeatName
                    Else
                        Return FeatName & " (" & FocusName & ")"
                    End If
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

        End Structure

        'feat slot type
        Public Enum FeatSlotType
            'General Types
            BonusFeat
            FighterBonusFeat
            SpecificBonusFeat
            SpecificBonusFeatChooseFocus
            ChooseSpecificBonusFeat
            ChoosePathFeat
            PathAutomaticFeat
            ChooseFeatOfType

            'For use in character editing
            UserAdded
            ExistingEdit
        End Enum

        Public Enum FeatSource
            Race
            [Class]
            Core
        End Enum

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Try
                Me.Character = Character
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'get the list of feats available for this character
        Public Function AvailableFeatList(ByVal CharacterLevel As Integer, ByVal Slot As FeatSlot, Optional ByVal IgnorePrereq As Boolean = False, Optional ByVal Filter As WizardFilterBar = Nothing) As ArrayList
            Dim FeatList As New ArrayList
            Dim AvailableFeat As New AvailableFeat
            Dim Feat As New Objects.ObjectData
            Dim Feats As New Objects.ObjectDataCollection
            Dim SlotType As FeatSlotType

            Try
                'get the full list of feats available and flag each one appropriately 
                '(remove existing feats where appropriate)

                Character.Prerequisites.Begin()
                SlotType = Slot.SlotType
                General.SetWaitCursor()

                'get feat list for slot type
                Select Case SlotType
                    Case FeatSlotType.BonusFeat
                        Feats = Caches.FeatsNoSimpleWeapon
                    Case FeatSlotType.FighterBonusFeat
                        Feats = Caches.FighterBonusFeats
                    Case FeatSlotType.SpecificBonusFeatChooseFocus
                        Dim ChooseFocusObject As Objects.ObjectData

                        ChooseFocusObject = Slot.ChooseBonusFeat
                        Feats = New Objects.ObjectDataCollection
                        Feat = New Objects.ObjectData
                        Feat.Load(Slot.ChooseBonusFeat.GetFKGuid("Feat"))

                        'if override prereqs then process now otherwise drop through to prereq checking
                        If ChooseFocusObject.Element("OverridePrerequisites") = "Yes" Then
                            AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus
                            AvailableFeat.IgnorePrerequisites = True
                            AvailableFeat.FeatGuid = Feat.ObjectGUID
                            AvailableFeat.FeatName = Feat.Name
                            AvailableFeat.FeatType = Feat.Element("FeatType")
                            AvailableFeat.FocusType = Feat.Element("FocusType")
                            If Feat.Element("FighterBonusFeat") = "Yes" Then AvailableFeat.FighterBonus = True Else AvailableFeat.FighterBonus = False
                            AvailableFeat.HTML = Feat.HTML
                            FeatList.Add(AvailableFeat)
                            General.SetNormalCursor()
                            Return FeatList
                        Else
                            Feats.Add(Feat)
                        End If

                    Case FeatSlotType.ChooseSpecificBonusFeat

                        Dim ChooseFeatChildren As Objects.ObjectDataCollection
                        Dim ChooseFeatObject As Objects.ObjectData
                        Dim FighterBonus As Boolean

                        ChooseFeatObject = Slot.ChooseBonusFeat

                        'feat type choices
                        If ChooseFeatObject.Element("FighterBonus") = "Yes" Then FighterBonus = True
                        If ChooseFeatObject.Element("OverridePrerequisites") = "Yes" Then IgnorePrereq = True

                        ChooseFeatChildren = ChooseFeatObject.ChildrenOfType(Objects.ChooseBonusFeatOfTypeChoiceType)
                        Dim FeatTypes As New Hashtable

                        For Each Child As Objects.ObjectData In ChooseFeatChildren
                            FeatTypes.Add(Child.Element("FeatType"), Nothing)
                        Next

                        Feats = New Objects.ObjectDataCollection
                        For Each FeatObj As Objects.ObjectData In Caches.FeatsNoSimpleWeapon
                            If FeatTypes.Contains(FeatObj.Element("FeatType")) OrElse (FighterBonus AndAlso FeatObj.Element("FighterBonusFeat") = "Yes") Then
                                Feats.Add(FeatObj)
                            End If
                        Next

                        'loop through each feat for this slot and determine whether prerequisites are met
                        For Each Feat In Feats
                            AvailableFeat.Clear()
                            AvailableFeat.Status = GetAvailableFeatStatus(Feat, CharacterLevel, IgnorePrereq)

                            If AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus Then
                                AvailableFeat.FocusType = Feat.Element("FocusType")
                            End If

                            'add the feat to the list of available feats
                            AvailableFeat.FeatGuid = Feat.ObjectGUID
                            AvailableFeat.FeatName = Feat.Name
                            AvailableFeat.FeatType = Feat.Element("FeatType")
                            If Feat.Element("FighterBonusFeat") = "Yes" Then AvailableFeat.FighterBonus = True Else AvailableFeat.FighterBonus = False
                            AvailableFeat.HTML = Feat.HTML
                            If IgnorePrereq Then AvailableFeat.IgnorePrerequisites = True
                            FeatList.Add(AvailableFeat)
                        Next

                        'the specific feats next
                        ChooseFeatChildren = ChooseFeatObject.ChildrenOfType(Objects.ChooseBonusFeatChoiceType)
                        For Each Child As Objects.ObjectData In ChooseFeatChildren
                            Feat = Caches.Feats.Item(Child.GetFKGuid("Feat"))

                            If (Not FeatTypes.Contains(Feat.Element("FeatType"))) AndAlso ((Not FighterBonus) OrElse Feat.Element("FighterBonusFeat") <> "Yes") Then

                                AvailableFeat.Clear()
                                Dim FocusKey As Objects.ObjectKey = Child.GetFKGuid("Focus")

                                If FocusKey.IsEmpty Then

                                    'check status
                                    If ChooseFeatObject.Element("OverridePrerequisites") = "Yes" Then
                                        If Character.Feats.ContainsKey(Feat.ObjectGUID) And Feat.Element("Stacks") = "" And Feat.Element("HasFocus") = "" Then
                                            AvailableFeat.Status = AvailableFeatStatus.AlreadyHave
                                        ElseIf Feat.Element("FocusType") = "" Then
                                            AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMet
                                        Else
                                            AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus
                                            AvailableFeat.FocusType = Feat.Element("FocusType")
                                        End If
                                        AvailableFeat.IgnorePrerequisites = True
                                    Else
                                        AvailableFeat.Status = GetAvailableFeatStatus(Feat, CharacterLevel, IgnorePrereq)
                                        If AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus Then
                                            AvailableFeat.FocusType = Feat.Element("FocusType")
                                        End If
                                    End If

                                Else

                                    'set focus components
                                    AvailableFeat.FocusGuid = FocusKey
                                    AvailableFeat.FocusName = Child.Element("Focus")

                                    'check status
                                    If ChooseFeatObject.Element("OverridePrerequisites") = "Yes" Then
                                        If Character.Feats.ContainsSubkey(Feat.ObjectGUID, FocusKey) Then
                                            AvailableFeat.Status = AvailableFeatStatus.AlreadyHave
                                        Else
                                            AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetFocusSelected
                                        End If
                                        AvailableFeat.IgnorePrerequisites = True
                                    Else
                                        If Character.Feats.ContainsSubkey(Feat.ObjectGUID, FocusKey) Then
                                            AvailableFeat.Status = AvailableFeatStatus.AlreadyHave
                                        Else
                                            AvailableFeat.Status = GetAvailableFeatStatus(Feat, CharacterLevel, IgnorePrereq)
                                            If AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus Then
                                                AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetFocusSelected
                                            End If
                                        End If
                                    End If

                                End If

                                AvailableFeat.FeatGuid = Feat.ObjectGUID
                                AvailableFeat.FeatName = Feat.Name
                                AvailableFeat.FeatType = Feat.Element("FeatType")
                                AvailableFeat.HTML = Feat.HTML

                                FeatList.Add(AvailableFeat)

                            End If

                        Next

                        General.SetNormalCursor()
                        Return FeatList

                    Case FeatSlotType.ChooseFeatOfType

                        Dim ChooseFeatofTypeObject As Objects.ObjectData
                        Feats = New Objects.ObjectDataCollection
                        ChooseFeatofTypeObject = Slot.ChooseBonusFeat

                        Dim ChooseFeatChildren As Objects.ObjectDataCollection = ChooseFeatofTypeObject.ChildrenOfType(Objects.ChooseBonusFeatOfTypeChoiceType)
                        Dim FeatTypes As New Hashtable
                        Dim FighterBonus As Boolean

                        For Each Child As Objects.ObjectData In ChooseFeatChildren
                            FeatTypes.Add(Child.Element("FeatType"), Nothing)
                        Next

                        If ChooseFeatofTypeObject.Element("FighterBonus") = "Yes" Then FighterBonus = True
                        If ChooseFeatofTypeObject.Element("OverridePrerequisites") = "Yes" Then IgnorePrereq = True

                        Feats = New Objects.ObjectDataCollection

                        For Each FeatObj As Objects.ObjectData In Caches.Feats
                            If Not FeatObj.ObjectGUID.Equals(References.SimpleWeaponProficiency) Then
                                If FeatTypes.Contains(FeatObj.Element("FeatType")) OrElse (FighterBonus AndAlso FeatObj.Element("FighterBonusFeat") = "Yes") Then
                                    Feats.Add(FeatObj)
                                End If
                            End If
                        Next

                    Case FeatSlotType.ChoosePathFeat
                        Dim level As Rules.Character.Level
                        Dim ClassInfo As Rules.CharacterClass
                        Dim ClassLevelObject, CombatStyle As Objects.ObjectData

                        level = Character.Levels(Slot.CharacterLevel)
                        ClassInfo = DirectCast(Character.CharacterClasses(level.ClassGuid), Rules.CharacterClass)
                        ClassLevelObject = ClassInfo.ClassLevel(level.ClassLevel)
                        CombatStyle = ClassLevelObject.FirstChildOfType(Objects.CombatStyleType)

                        If CombatStyle.IsEmpty Then
                            General.ShowErrorDialog("Missing Combat Style definition")
                            Exit Select
                        End If

                        'Add the two feat path options - Add here to skip prerequiste checking
                        Feats = New Objects.ObjectDataCollection
                        Feats.Add(CombatStyle.GetFKObject("FirstFeat1"))
                        Feats.Add(CombatStyle.GetFKObject("FirstFeat2"))

                        For Each Feat In Feats
                            AvailableFeat.Clear()
                            If Character.Feats.ContainsKey(Feat.ObjectGUID) And Feat.Element("Stacks") = "" Then
                                AvailableFeat.Status = AvailableFeatStatus.AlreadyHave
                            Else
                                AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMet
                            End If

                            AvailableFeat.IgnorePrerequisites = True
                            AvailableFeat.FeatGuid = Feat.ObjectGUID
                            AvailableFeat.FeatName = Feat.Name
                            AvailableFeat.FeatType = Feat.Element("FeatType")
                            If Feat.Element("FighterBonusFeat") = "Yes" Then AvailableFeat.FighterBonus = True Else AvailableFeat.FighterBonus = False
                            AvailableFeat.HTML = Feat.HTML
                            FeatList.Add(AvailableFeat)
                        Next

                        General.SetNormalCursor()
                        Return FeatList

                    Case FeatSlotType.UserAdded, FeatSlotType.ExistingEdit
                        Feats = Caches.FeatsNoSimpleWeapon
                    Case Else
                        General.ShowErrorDialog("This slot type not yet developed")
                End Select

                'apply filter if required
                If Not Filter Is Nothing Then
                    Select Case SlotType
                        Case FeatSlotType.BonusFeat, FeatSlotType.FighterBonusFeat
                            Filter.BaseObjects(True) = Feats
                            Feats = Filter.FilteredObjects
                    End Select
                End If

                'loop through each feat for this slot and determine whether prerequisites are met
                For Each Feat In Feats
                    AvailableFeat.Clear()
                    AvailableFeat.Status = GetAvailableFeatStatus(Feat, CharacterLevel, IgnorePrereq)

                    If AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus Then
                        AvailableFeat.FocusType = Feat.Element("FocusType")
                    End If

                    'add the feat to the list of available feats
                    AvailableFeat.FeatGuid = Feat.ObjectGUID
                    AvailableFeat.FeatName = Feat.Name
                    AvailableFeat.FeatType = Feat.Element("FeatType")
                    If Feat.Element("FighterBonusFeat") = "Yes" Then AvailableFeat.FighterBonus = True Else AvailableFeat.FighterBonus = False
                    AvailableFeat.HTML = Feat.HTML
                    If IgnorePrereq Then AvailableFeat.IgnorePrerequisites = True
                    FeatList.Add(AvailableFeat)
                Next

                General.SetNormalCursor()

                Return FeatList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the list of feats available for this character
        Public Sub AvailableFeatListForThread(ByVal CharacterLevel As Integer, ByVal Slot As FeatSlot, Optional ByVal IgnorePrereq As Boolean = False, Optional ByVal Filter As WizardFilterBar = Nothing)
            Dim FeatList As New ArrayList
            Dim AvailableFeat As New AvailableFeat
            Dim Feat As Objects.ObjectData
            Dim Feats As Objects.ObjectDataCollection
            Dim FeatsSorted As ArrayList

            Try
                'get the full list of feats available and flag each one appropriately 
                '(remove existing feats where appropriate)

                Character.Prerequisites.Begin()

                'get feat list
                If Slot.SlotType = FeatSlotType.FighterBonusFeat Then
                    Feats = Caches.FighterBonusFeats
                Else
                    Feats = Caches.FeatsNoSimpleWeapon
                End If

                'apply filter if required
                If Not Filter Is Nothing Then
                    Filter.BaseObjects(True) = Feats
                    Feats = Filter.FilteredObjects
                End If

                FeatsSorted = Feats.ToArrayList
                Try
                    FeatsSorted.Sort()
                Catch ex As Exception
                    'ignore
                End Try

                'buffer
                Dim Temp As New ArrayList

                'loop through each feat for this slot and determine whether prerequisites are met
                For Each Feat In FeatsSorted
                    AvailableFeat.Clear()
                    AvailableFeat.Status = GetAvailableFeatStatus(Feat, CharacterLevel, IgnorePrereq)

                    If AvailableFeat.Status = AvailableFeatStatus.PrerequisitesMetSelectFocus Then
                        AvailableFeat.FocusType = Feat.Element("FocusType")
                    End If

                    'add the feat to the list of available feats
                    AvailableFeat.FeatGuid = Feat.ObjectGUID
                    AvailableFeat.FeatName = Feat.Name
                    AvailableFeat.FeatType = Feat.Element("FeatType")
                    If Feat.Element("FighterBonusFeat") = "Yes" Then AvailableFeat.FighterBonus = True Else AvailableFeat.FighterBonus = False
                    AvailableFeat.HTML = Feat.HTML
                    If IgnorePrereq Then AvailableFeat.IgnorePrerequisites = True
                    Temp.Add(AvailableFeat)
                    If Temp.Count = 10 Then
                        RaiseEvent FeatReady(Temp)
                        Temp = New ArrayList
                    End If
                Next

                If Temp.Count > 0 Then RaiseEvent FeatReady(Temp)

            Catch taex As ThreadAbortException
                Return
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Event FeatReady(ByVal Feats As ArrayList)

        'checks the prerequisites on a feat
        Public Function GetAvailableFeatStatus(ByVal Feat As Objects.ObjectData, ByVal CharacterLevel As Integer, ByVal IgnorePrereq As Boolean) As AvailableFeatStatus
            Try
                Dim PrerequisitesMet As Boolean

                'check to see if they have the feat already
                If Feat.Element("HasFocus") = "" And Feat.Element("Stacks") = "" Then
                    If Character.Feats.ContainsKey(Feat.ObjectGUID) Then
                        Return AvailableFeatStatus.AlreadyHave
                    End If
                End If

                'check prerequisites
                PrerequisitesMet = True

                If Not IgnorePrereq Then
                    For Each Prerequisite As Objects.ObjectData In Caches.FeatPrerequisites.ChildrenFast(Feat.ObjectGUID)
                        If Not Character.Prerequisites.HasPrerequisite(Prerequisite, CharacterLevel, Caches.FeatPrerequisiteChildren.ChildrenFast(Prerequisite.ObjectGUID)) Then
                            PrerequisitesMet = False
                            Exit For
                        End If
                    Next
                End If

                'determine feat slot status
                If PrerequisitesMet Then
                    If Feat.Element("HasFocus") = "Yes" Then
                        Return AvailableFeatStatus.PrerequisitesMetSelectFocus
                    Else
                        Return AvailableFeatStatus.PrerequisitesMet
                    End If
                Else
                    Return AvailableFeatStatus.PrerequisitesNotMet
                End If

            Catch taex As ThreadAbortException
                Throw taex
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the list of feats slots for this character - For use in Character Wizard
        Public Function AvailableFeatSlots(ByVal ExistingCharacter As Rules.Character, ByVal LevelsToAdd As Integer) As ArrayList
            Dim Slots As New ArrayList
            Dim n, m, FeatCount As Integer
            Dim Slot As New FeatSlot
            Dim ChooseFeat, ChooseFeatType, ChooseFocusFeat, SpecificBonusFeat, FighterBonusFeat, CombatStyleFeat, ClassLevel As Objects.ObjectData
            Dim ChooseFocusFeats, SpecificBonusFeats, FighterBonusFeats, ChooseFeats, ChooseFeatsofType As Objects.ObjectDataCollection
            Dim NewFeat As Rules.Character.Feat
            Dim StartHitDice, CurrentHitDice As Integer
            Dim MonsterGenerateFeats As Boolean

            Try
                Dim RacialHitDice As Integer = Math.Max(CInt(ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")), 1)
                Dim Race As Objects.ObjectData = Character.CharacterObject.GetFKObject("Race")

                If Race.Element("GenerateFeats") <> "" Then
                    MonsterGenerateFeats = True
                End If

                'get racial bonus and specific bonus feats at first level
                If ExistingCharacter.CharacterLevel = 0 Then

                    'bonus feats
                    FeatCount = Race.ChildrenOfType(Objects.BonusFeatType).Count
                    If FeatCount > 0 Then
                        Slot.CharacterLevel = 1
                        Slot.SlotType = FeatSlotType.BonusFeat
                        Slot.Source = FeatSource.Race
                        For n = 1 To FeatCount
                            Slots.Add(Slot)
                        Next
                    End If

                    'choose feats from a list
                    ChooseFeats = Race.ChildrenOfType(Objects.ChooseBonusFeatType)
                    For Each ChooseFeat In ChooseFeats
                        Slot.Clear()
                        Slot.CharacterLevel = 1
                        Slot.SlotType = FeatSlotType.ChooseSpecificBonusFeat
                        Slot.ChooseBonusFeat = ChooseFeat
                        Slot.Source = FeatSource.Race
                        Slots.Add(Slot)
                    Next

                    'choose feat of a specific type
                    ChooseFeatsofType = Race.ChildrenOfType(Objects.ChooseBonusFeatOfTypeType)
                    For Each ChooseFeatType In ChooseFeatsofType
                        Slot.Clear()
                        Slot.CharacterLevel = 1
                        Slot.SlotType = FeatSlotType.ChooseFeatOfType
                        Slot.ChooseBonusFeat = ChooseFeatType
                        Slot.Source = FeatSource.Race
                        Slots.Add(Slot)
                    Next

                    'get the specific bonus feats for level where user has to choose a focus
                    ChooseFocusFeats = Race.ChildrenOfType(Objects.SpecificBonusFeatChooseFocusType)
                    For Each ChooseFocusFeat In ChooseFocusFeats
                        Slot.Clear()
                        Slot.CharacterLevel = 1
                        Slot.SlotType = FeatSlotType.SpecificBonusFeatChooseFocus
                        Slot.Source = FeatSource.Race
                        Slot.ChooseBonusFeat = ChooseFocusFeat
                        Slots.Add(Slot)
                    Next

                    'specific bonus feats
                    SpecificBonusFeats = Race.ChildrenOfType(Objects.SpecificBonusFeatType)
                    For Each SpecificBonusFeat In SpecificBonusFeats
                        Dim FocusKey As Objects.ObjectKey = SpecificBonusFeat.GetFKGuid("Focus")
                        Dim FocusName As String = SpecificBonusFeat.Element("Focus")

                        If (FocusKey.IsEmpty AndAlso Character.Feats.ContainsKey(SpecificBonusFeat.GetFKGuid("Feat")) = False) _
                        OrElse ((Not FocusKey.IsEmpty) AndAlso Character.Feats.ContainsSubkey(SpecificBonusFeat.GetFKGuid("Feat"), FocusKey) = False) _
                        OrElse (SpecificBonusFeat.GetFKObject("Feat").Element("Stacks") = "Yes") Then

                            Slot.Clear()
                            Slot.CharacterLevel = 1
                            Slot.SlotType = FeatSlotType.SpecificBonusFeat
                            Slot.Source = FeatSource.Race
                            Slot.FeatGuid = SpecificBonusFeat.GetFKGuid("Feat")
                            Slot.FeatName = SpecificBonusFeat.Element("Feat")
                            Slot.FeatType = SpecificBonusFeat.GetFKObject("Feat").Element("FeatType")
                            If Not FocusKey.IsEmpty Then
                                Slot.FocusGuid = FocusKey
                                Slot.FocusName = FocusName
                            End If
                            Slots.Add(Slot)

                            'add to character
                            NewFeat = New Rules.Character.Feat
                            NewFeat.Clear()
                            NewFeat.FeatGuid = Slot.FeatGuid
                            NewFeat.FeatName = Slot.FeatName
                            NewFeat.FeatType = Slot.FeatType
                            NewFeat.LevelTaken = Slot.CharacterLevel
                            NewFeat.FocusGuid = Slot.FocusGuid
                            If SpecificBonusFeat.Element("OverridePrerequisites") = "Yes" Then NewFeat.IgnorePrerequisites = True Else NewFeat.IgnorePrerequisites = False
                            NewFeat.SourceName = Race.Name
                            NewFeat.SourceGuid = Race.ObjectGUID
                            NewFeat.FeatSlotSource = AvailableFeats.SpecificBonusFeat
                            NewFeat.SourceName = Race.Name
                            NewFeat.SourceGuid = Race.ObjectGUID

                            If NewFeat.FocusGuid.IsEmpty Then
                                NewFeat.FocusName = ""
                                Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                                Character.Components.Feats(NewFeat.FeatGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                            ElseIf NewFeat.FocusGuid.Equals(RPGXplorer.References.CustomFeatFocus) Then
                                NewFeat.FocusName = Slot.FocusName
                                Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusName, NewFeat, NewFeat.LevelTaken)
                                Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                            Else
                                NewFeat.FocusName = Slot.FocusName
                                Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                                Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                            End If

                        End If
                    Next
                End If


                'Check for any War Domain Abilities
                Dim LibraryData As Library.LibraryData

                For Each Item As Library.LibraryData In Character.Components.SystemAbilitiesLibrary.ItemData(References.WarDeityFavoredWeapon)
                    LibraryData = Item
                    If LibraryData.LevelAcquired >= Character.FirstNewLevel Then
                        Dim WeaponObject, FeatObject As New Objects.ObjectData

                        'Get Weapon from the deity
                        If Character.DeityObject.IsEmpty Then Exit For

                        WeaponObject = Character.DeityObject.GetFKObject("FavoredWeapon")
                        If WeaponObject.IsEmpty Then Exit For

                        'See if they have proficency in this Weapon
                        Dim ProfCheck As New Rules.Proficiency(Character)
                        ProfCheck.Calculate(LibraryData.LevelAcquired)

                        If ProfCheck.Proficient(WeaponObject, WeaponObject, LibraryData.LevelAcquired) = Proficiency.ProficiencyLevel.NotProficient Then
                            'Add a Proficiency for this weapon

                            Select Case WeaponObject.Element("Training")
                                Case "Simple"
                                    FeatObject.Load(References.SimpleWeaponProficiency)

                                Case "Martial"
                                    FeatObject.Load(References.MartialWeaponProficiency)

                                Case "Exotic"
                                    FeatObject.Load(References.ExoticWeaponProficiency)
                            End Select

                            Slot.Clear()
                            Slot.CharacterLevel = LibraryData.LevelAcquired
                            Slot.SlotType = FeatSlotType.SpecificBonusFeat
                            Slot.FeatGuid = FeatObject.ObjectGUID
                            Slot.FeatName = FeatObject.Name
                            Slot.FeatType = FeatObject.Element("FeatType")
                            Slot.FocusGuid = WeaponObject.ObjectGUID
                            Slot.FocusName = WeaponObject.Name
                            Slot.Source = FeatSource.Core
                            Slots.Add(Slot)

                            'add to character
                            NewFeat = New Rules.Character.Feat
                            NewFeat.Clear()
                            NewFeat.FeatGuid = Slot.FeatGuid
                            NewFeat.FeatName = Slot.FeatName
                            NewFeat.FeatType = Slot.FeatType
                            NewFeat.LevelTaken = Slot.CharacterLevel
                            NewFeat.FocusGuid = Slot.FocusGuid
                            NewFeat.FocusName = Slot.FocusName
                            NewFeat.FeatSlotSource = AvailableFeats.WarDomain
                            NewFeat.SourceName = Character.DeityObject.Name
                            NewFeat.SourceGuid = Character.DeityObject.ObjectGUID
                            NewFeat.IgnorePrerequisites = True

                            Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                            Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                        End If

                        'See if they have Weapon Focus in this Weapon
                        If Not Character.Feats.ContainsSubkey(References.WeaponFocus, WeaponObject.ObjectGUID, LibraryData.LevelAcquired) Then
                            FeatObject.Load(References.WeaponFocus)

                            Slot.Clear()
                            Slot.CharacterLevel = LibraryData.LevelAcquired
                            Slot.SlotType = FeatSlotType.SpecificBonusFeat
                            Slot.FeatGuid = FeatObject.ObjectGUID
                            Slot.FeatName = FeatObject.Name
                            Slot.FeatType = FeatObject.Element("FeatType")
                            Slot.FocusGuid = WeaponObject.ObjectGUID
                            Slot.FocusName = WeaponObject.Name
                            Slot.Source = FeatSource.Core
                            Slots.Add(Slot)

                            'add to character
                            NewFeat = New Rules.Character.Feat
                            NewFeat.Clear()
                            NewFeat.FeatGuid = Slot.FeatGuid
                            NewFeat.FeatName = Slot.FeatName
                            NewFeat.FeatType = Slot.FeatType
                            NewFeat.LevelTaken = Slot.CharacterLevel
                            NewFeat.FocusGuid = Slot.FocusGuid
                            NewFeat.FocusName = Slot.FocusName
                            NewFeat.FeatSlotSource = AvailableFeats.WarDomain
                            NewFeat.SourceName = Character.DeityObject.Name
                            NewFeat.SourceGuid = Character.DeityObject.ObjectGUID
                            NewFeat.IgnorePrerequisites = True

                            Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                            Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                        End If
                        Exit For
                    End If
                Next

                'if this is a companion get the hitdice starting point
                Select Case Character.CharacterType
                    Case Character.CharacterObjectType.AnimalCompanion, Character.CharacterObjectType.SpecialMount
                        StartHitDice = ExistingCharacter.HitDice

                        'if not hit dice add racial
                        If StartHitDice = 0 Then
                            StartHitDice = Math.Max(CInt(ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")), 1)
                        End If

                        CurrentHitDice = StartHitDice
                End Select

                'get the feats acquired from each level and class level
                For n = 1 To LevelsToAdd

                    'get the classlevel for the remaining slots
                    Dim level As Character.Level = Character.Levels(ExistingCharacter.CharacterLevel + n)
                    Dim ClassInfo As Rules.CharacterClass = DirectCast(Character.CharacterClasses(level.ClassGuid), Rules.CharacterClass)
                    ClassLevel = ClassInfo.ClassLevel(level.ClassLevel)

                    'get the straight bonus feats for level if required
                    Select Case Character.CharacterType
                        Case Character.CharacterObjectType.Familiar
                            'do nothing

                        Case Character.CharacterObjectType.AnimalCompanion, Character.CharacterObjectType.SpecialMount
                            If level.HitDice > 0 Then
                                If level.CharacterLevel <> 1 Then
                                    For Hitdice As Integer = 1 To level.HitDice
                                        CurrentHitDice += 1
                                        If Not Character.NonInt(CurrentHitDice) Then
                                            If Rules.ExperienceAndLevelling.LevelDependentBenefits(CurrentHitDice).Feat Then
                                                Slot.Clear()
                                                Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                                                Slot.SlotType = FeatSlotType.BonusFeat
                                                Slot.Source = FeatSource.Core
                                                Slots.Add(Slot)
                                            End If
                                        End If
                                    Next
                                Else
                                    If level.HitDice > RacialHitDice Then
                                        For Hitdice As Integer = 1 To (level.HitDice - RacialHitDice)
                                            CurrentHitDice += 1
                                            If Not Character.NonInt(CurrentHitDice) Then
                                                If Rules.ExperienceAndLevelling.LevelDependentBenefits(CurrentHitDice).Feat Then
                                                    Slot.Clear()
                                                    Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                                                    Slot.SlotType = FeatSlotType.BonusFeat
                                                    Slot.Source = FeatSource.Core
                                                    Slots.Add(Slot)
                                                End If
                                            End If
                                        Next
                                    End If
                                End If

                            End If

                        Case Rules.Character.CharacterObjectType.Monster

                            'only get bonus feats if we are past the racial hit dice
                            If level.CharacterLevel > RacialHitDice OrElse MonsterGenerateFeats Then
                                If Not Character.NonInt(ExistingCharacter.CharacterLevel + n) Then
                                    If Rules.ExperienceAndLevelling.LevelDependentBenefits(ExistingCharacter.CharacterLevel + n).Feat Then
                                        Slot.Clear()
                                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                                        Slot.SlotType = FeatSlotType.BonusFeat
                                        Slot.Source = FeatSource.Core
                                        Slots.Add(Slot)
                                    End If
                                End If
                            End If

                        Case Else

                            If Not Character.NonInt(ExistingCharacter.CharacterLevel + n) Then
                                If Rules.ExperienceAndLevelling.LevelDependentBenefits(ExistingCharacter.CharacterLevel + n).Feat Then
                                    Slot.Clear()
                                    Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                                    Slot.SlotType = FeatSlotType.BonusFeat
                                    Slot.Source = FeatSource.Core
                                    Slots.Add(Slot)
                                End If
                            End If

                    End Select

                    'get the added bonus feats
                    FeatCount = ClassLevel.ChildrenOfType(Objects.BonusFeatType).Count
                    If FeatCount > 0 Then
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.BonusFeat
                        Slot.Source = FeatSource.Class
                        For m = 1 To FeatCount
                            Slots.Add(Slot)
                        Next
                    End If

                    'get the fighter bonus feats for level
                    FighterBonusFeats = ClassLevel.ChildrenOfType(Objects.FighterBonusFeatType)
                    For Each FighterBonusFeat In FighterBonusFeats
                        Slot.Clear()
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.FighterBonusFeat
                        Slot.Source = FeatSource.Class
                        Slots.Add(Slot)
                    Next

                    'get the ChooseFeats for this level
                    ChooseFeats = ClassLevel.ChildrenOfType(Objects.ChooseBonusFeatType)
                    For Each ChooseFeat In ChooseFeats
                        Slot.Clear()
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.ChooseSpecificBonusFeat
                        Slot.ChooseBonusFeat = ChooseFeat
                        Slot.Source = FeatSource.Class
                        Slots.Add(Slot)
                    Next

                    'choose feat of a specific type
                    ChooseFeatsofType = ClassLevel.ChildrenOfType(Objects.ChooseBonusFeatOfTypeType)
                    For Each ChooseFeatType In ChooseFeatsofType
                        Slot.Clear()
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.ChooseFeatOfType
                        Slot.ChooseBonusFeat = ChooseFeatType
                        Slot.Source = FeatSource.Class
                        Slots.Add(Slot)
                    Next

                    'we dont want to add specific feats from a monster type class, as they are already copied onto the race
                    If (level.CharacterLevel <> 1) OrElse (level.ClassGuid.Database = XML.DBTypes.Classes) Then

                        'get the specific bonus feats for level where user has to choose a focus
                        ChooseFocusFeats = ClassLevel.ChildrenOfType(Objects.SpecificBonusFeatChooseFocusType)
                        For Each ChooseFocusFeat In ChooseFocusFeats
                            Slot.Clear()
                            Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                            Slot.SlotType = FeatSlotType.SpecificBonusFeatChooseFocus
                            Slot.ChooseBonusFeat = ChooseFocusFeat
                            Slot.Source = FeatSource.Class
                            Slots.Add(Slot)
                        Next

                        'get the specific bonus feats for level
                        SpecificBonusFeats = ClassLevel.ChildrenOfType(Objects.SpecificBonusFeatType)
                        For Each SpecificBonusFeat In SpecificBonusFeats
                            Dim FocusKey As Objects.ObjectKey = SpecificBonusFeat.GetFKGuid("Focus")
                            Dim FocusName As String = SpecificBonusFeat.Element("Focus")

                            If (FocusKey.IsEmpty AndAlso Character.Feats.ContainsKey(SpecificBonusFeat.GetFKGuid("Feat")) = False) _
                            OrElse ((Not FocusKey.IsEmpty) AndAlso Character.Feats.ContainsSubkey(SpecificBonusFeat.GetFKGuid("Feat"), FocusKey) = False) _
                            OrElse (SpecificBonusFeat.GetFKObject("Feat").Element("Stacks") = "Yes") Then

                                Slot.Clear()
                                Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                                Slot.FeatGuid = SpecificBonusFeat.GetFKGuid("Feat")
                                Slot.FeatName = SpecificBonusFeat.Element("Feat")
                                Slot.FeatType = SpecificBonusFeat.GetFKObject("Feat").Element("FeatType")
                                If Not FocusKey.IsEmpty Then
                                    Slot.FocusGuid = FocusKey
                                    Slot.FocusName = FocusName
                                End If
                                Slot.SlotType = FeatSlotType.SpecificBonusFeat
                                Slot.Source = FeatSource.Class
                                Slots.Add(Slot)

                                'add to character
                                NewFeat = New Rules.Character.Feat
                                NewFeat.Clear()
                                NewFeat.FeatGuid = Slot.FeatGuid
                                NewFeat.FeatName = Slot.FeatName
                                NewFeat.FeatType = Slot.FeatType
                                NewFeat.LevelTaken = Slot.CharacterLevel
                                NewFeat.FocusGuid = Slot.FocusGuid
                                NewFeat.FeatSlotSource = AvailableFeats.SpecificBonusFeat
                                NewFeat.SourceName = ClassLevel.Name
                                NewFeat.SourceGuid = ClassLevel.ObjectGUID

                                If SpecificBonusFeat.Element("OverridePrerequisites") = "Yes" Then NewFeat.IgnorePrerequisites = True Else NewFeat.IgnorePrerequisites = False
                                If NewFeat.FocusGuid.IsEmpty Then
                                    NewFeat.FocusName = ""
                                    Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                                ElseIf NewFeat.FocusGuid.Equals(RPGXplorer.References.CustomFeatFocus) Then
                                    NewFeat.FocusName = Slot.FocusName
                                    Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusName, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                                Else
                                    NewFeat.FocusName = Slot.FocusName
                                    Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                                End If
                            End If
                        Next

                    End If

                    'get the Combat Style feats for level
                    CombatStyleFeat = ClassLevel.FirstChildOfType(Objects.CombatStyleType)
                    If CombatStyleFeat.ObjectGUID.IsNotEmpty Then
                        Slot.Clear()
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.ChoosePathFeat
                        Slot.Source = FeatSource.Core
                        Slots.Add(Slot)
                    End If

                    'if the Style has previously been chosen, set this feat now
                    CombatStyleFeat = ClassLevel.FirstChildOfType(Objects.CombatStyleImprovedFeatType)
                    If CombatStyleFeat.ObjectGUID.IsNotEmpty Then
                        Slot.Clear()
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.PathAutomaticFeat
                        Slot.Source = FeatSource.Core

                        For Each LibraryItem As Library.LibraryData In Character.Choices.ItemData(ClassInfo.ClassObj.ObjectGUID)
                            Dim Choice As Character.CharacterChoice
                            Choice = DirectCast(LibraryItem.Data, Character.CharacterChoice)
                            If Choice.Type = Character.ChoiceType.CombatStyle Then
                                Dim ChoiceObject As New Objects.ObjectData

                                ChoiceObject.Load(Choice.DataGuid)

                                Select Case Choice.Data
                                    Case "Style1"
                                        Slot.FeatGuid = ChoiceObject.GetFKGuid("SecondFeat1")
                                        Slot.FeatName = ChoiceObject.Element("SecondFeat1")
                                        Slot.FeatType = ChoiceObject.GetFKObject("SecondFeat1").Element("FeatType")

                                    Case "Style2"
                                        Slot.FeatGuid = ChoiceObject.GetFKGuid("SecondFeat2")
                                        Slot.FeatName = ChoiceObject.Element("SecondFeat2")
                                        Slot.FeatType = ChoiceObject.GetFKObject("SecondFeat2").Element("FeatType")
                                End Select

                                'add feat to character
                                NewFeat = New Rules.Character.Feat
                                NewFeat.Clear()
                                NewFeat.FeatGuid = Slot.FeatGuid
                                NewFeat.FeatName = Slot.FeatName
                                NewFeat.FeatType = Slot.FeatType
                                NewFeat.LevelTaken = Slot.CharacterLevel
                                NewFeat.FocusGuid = Slot.FocusGuid
                                NewFeat.FocusName = Slot.FocusName
                                NewFeat.IgnorePrerequisites = True
                                NewFeat.FeatSlotSource = AvailableFeats.PathAutomaticFeat
                                NewFeat.SourceName = Choice.Data
                                NewFeat.SourceGuid = ChoiceObject.ObjectGUID

                                If NewFeat.FocusGuid.IsEmpty Then
                                    NewFeat.FocusName = ""
                                    Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                                Else
                                    NewFeat.FocusName = Slot.FocusName
                                    Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                                End If

                                Exit For
                            End If
                        Next
                        Slots.Add(Slot)
                    End If

                    'if the Style has previously been chosen, set this feat now
                    CombatStyleFeat = ClassLevel.FirstChildOfType(Objects.CombatstyleMasteryFeatType)
                    If CombatStyleFeat.ObjectGUID.IsNotEmpty Then

                        Slot.Clear()
                        Slot.CharacterLevel = ExistingCharacter.CharacterLevel + n
                        Slot.SlotType = FeatSlotType.PathAutomaticFeat
                        Slot.Source = FeatSource.Core

                        For Each LibraryItem As Library.LibraryData In Character.Choices.ItemData(ClassInfo.ClassObj.ObjectGUID)
                            Dim Choice As Character.CharacterChoice
                            Choice = DirectCast(LibraryItem.Data, Character.CharacterChoice)
                            If Choice.Type = Character.ChoiceType.CombatStyle Then
                                Dim ChoiceObject As New Objects.ObjectData

                                ChoiceObject.Load(Choice.DataGuid)

                                Select Case Choice.Data
                                    Case "Style1"
                                        Slot.FeatGuid = ChoiceObject.GetFKGuid("ThirdFeat1")
                                        Slot.FeatName = ChoiceObject.Element("ThirdFeat1")
                                        Slot.FeatType = ChoiceObject.GetFKObject("ThirdFeat1").Element("FeatType")

                                    Case "Style2"
                                        Slot.FeatGuid = ChoiceObject.GetFKGuid("ThirdFeat2")
                                        Slot.FeatName = ChoiceObject.Element("ThirdFeat2")
                                        Slot.FeatType = ChoiceObject.GetFKObject("ThirdFeat2").Element("FeatType")
                                End Select

                                'add feat to character
                                NewFeat = New Rules.Character.Feat
                                NewFeat.Clear()
                                NewFeat.FeatGuid = Slot.FeatGuid
                                NewFeat.FeatName = Slot.FeatName
                                NewFeat.FeatType = Slot.FeatType
                                NewFeat.LevelTaken = Slot.CharacterLevel
                                NewFeat.FocusGuid = Slot.FocusGuid
                                NewFeat.FocusName = Slot.FocusName
                                NewFeat.IgnorePrerequisites = True
                                NewFeat.FeatSlotSource = AvailableFeats.PathAutomaticFeat
                                NewFeat.SourceName = Choice.Data
                                NewFeat.SourceGuid = ChoiceObject.ObjectGUID

                                If NewFeat.FocusGuid.IsEmpty Then
                                    NewFeat.FocusName = ""
                                    Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                                Else
                                    NewFeat.FocusName = Slot.FocusName
                                    Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                                    Character.Components.Feats(NewFeat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                                End If

                                Exit For

                            End If

                        Next

                        Slots.Add(Slot)
                    End If

                Next

                'Get the bonus feats from features
                For Each Item As DictionaryEntry In Character.ExtraFeats
                    Dim Level, Ammount As Integer

                    Level = CInt(Item.Key)
                    Ammount = CInt(Item.Value)

                    For i As Integer = 1 To Ammount
                        Slot.Clear()
                        Slot.CharacterLevel = Level
                        Slot.SlotType = FeatSlotType.BonusFeat
                        Slot.Source = FeatSource.Class
                        Slots.Add(Slot)
                    Next
                Next

                'get bonus feats from domains
                For Each Domain As Domain In Character.Domains.DomainsGainedSinceLevel(Character.FirstNewLevel)
                    For Each Feat As Character.Feat In Character.Domains.AnalyseFeats(Domain)
                        Slot.Clear()
                        Slot.CharacterLevel = Domain.DomainObj.ElementAsInteger("LevelAcquired")
                        Slot.FeatGuid = Feat.FeatGuid
                        Slot.FeatName = Feat.FeatName
                        Slot.FeatType = Feat.FeatType
                        Slot.FocusGuid = Feat.FocusGuid
                        Slot.FocusName = Feat.FocusName
                        Slot.SlotType = FeatSlotType.SpecificBonusFeat
                        Slot.Source = FeatSource.Class
                        Slots.Add(Slot)
                    Next
                Next

                'update the character with any new modifiers
                Character.Components.CheckConditions_CalculateModifiers(False)

                Return Slots

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
