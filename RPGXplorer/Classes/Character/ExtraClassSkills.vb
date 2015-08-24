Option Explicit On 
Option Strict On

Namespace Rules

#Region "Structures"

    'slot for the bonus class skill panel
    Public Structure BonusClassSkillSlot
        Public CharacterLevel As Integer
        Public SlotType As BonusClassSkillSlotType
        Public SkillTakenKey As Objects.ObjectKey
        Public SkillTakenName As String
        Public SkillChoices As ArrayList
        Public SlotSource As BonusClassSkillSlotSource

        Public ReadOnly Property SlotTypeName() As String
            Get
                Select Case SlotType
                    Case BonusClassSkillSlotType.BonusClassSkill
                        Return "Bonus Class Skill"
                    Case BonusClassSkillSlotType.ChooseBonusClassSkill
                        Return "Choose Bonus Class Skill"
                    Case BonusClassSkillSlotType.SpecificBonusClassSkill
                        Return "Specific Bonus Class Skill"
                End Select
                Return ""
            End Get
        End Property

    End Structure

    'choice 
    Public Structure BonusClassSkillChoice
        Public SkillKey As Objects.ObjectKey
        Public SkillName As String
        Public AlreadyTaken As Boolean
        Public HTML As String
    End Structure

#End Region

#Region "Enumerations"

    'slot type
    Public Enum BonusClassSkillSlotType
        BonusClassSkill
        ChooseBonusClassSkill
        SpecificBonusClassSkill
    End Enum

    'slot type
    Public Enum BonusClassSkillSlotSource
        Race
        [Class]
    End Enum

#End Region

    'this class handles all acquired bonus class skills for the character
    Public Class ExtraClassSkills

#Region "Member Variables"

        Private _ExtraClassSkills As Library
        Private _Character As Rules.Character
        Private _Deleted As New ArrayList

#End Region

#Region "Properties"

        'default item property
        Default Public ReadOnly Property Item(ByVal ClassKey As Objects.ObjectKey, ByVal SkillKey As Objects.ObjectKey) As ExtraClassSkill
            Get
                Return CType(_ExtraClassSkills.ItemData(ClassKey, SkillKey).Data, ExtraClassSkill)
            End Get
        End Property

        'the underlying library
        Public ReadOnly Property ExtraClassSkills() As Library
            Get
                Return _ExtraClassSkills
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Character)
            Try
                _Character = Character
                _ExtraClassSkills = New Library()
                _Deleted = New ArrayList
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load
        Public Sub Load()
            Try
                _ExtraClassSkills.Clear()
                _Deleted.Clear()

                'load any extra class skill objects on this character 
                For Each ExtraSkillObj As Objects.ObjectData In _Character.CharacterObject.ChildrenOfType(Objects.ExtraClassSkillType)
                    Dim ExtraClassSkill As New ExtraClassSkill(_Character)
                    ExtraClassSkill.IsNew = False
                    ExtraClassSkill.ExtraClassSkillObj = ExtraSkillObj
                    AddExtraClassSkill(ExtraClassSkill, ExtraSkillObj.ElementAsInteger("CharacterLevel"))
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save
        Public Sub Save()
            Try
                'delete any removed objects
                For Each ExtraSkillObj As Objects.ObjectData In _Deleted
                    ExtraSkillObj.Delete()
                Next
                _Deleted.Clear()

                'save all remaining objects
                For Each DataItem As Library.LibraryData In _ExtraClassSkills.ItemData
                    CType(DataItem.Data, ExtraClassSkill).ExtraClassSkillObj.Save()
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'clone
        Public Function Clone(ByRef CloneCharacter As Character) As ExtraClassSkills
            Try

                Clone = New ExtraClassSkills(CloneCharacter)
                Clone._ExtraClassSkills = Me._ExtraClassSkills.Clone
                Clone._Deleted = CType(Me._Deleted.Clone, ArrayList)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'count
        Public Function Count() As Integer
            Try
                Return _ExtraClassSkills.ItemData.Count
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add to the character
        Public Sub AddExtraClassSkill(ByVal SkillDef As Objects.ObjectData, ByVal ClassDef As Objects.ObjectData, ByVal CharacterLevel As Integer)
            Try
                Dim ExtraClassSkill As New ExtraClassSkill(_Character)
                ExtraClassSkill.CreateObject(SkillDef, ClassDef, CharacterLevel)
                ExtraClassSkill.IsNew = True
                AddExtraClassSkill(ExtraClassSkill, CharacterLevel)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'add to the character
        Private Sub AddExtraClassSkill(ByVal ExtraClassSkill As ExtraClassSkill, ByVal CharacterLevel As Integer)
            Try
                'add to library
                _ExtraClassSkills.AddItemWithSubkey(ExtraClassSkill.ExtraClassSkillObj.GetFKGuid("Class"), ExtraClassSkill.ExtraClassSkillObj.GetFKGuid("Skill"), ExtraClassSkill, CharacterLevel)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove from the character
        Public Sub RemoveExtraClassSkill(ByVal ClassKey As Objects.ObjectKey, ByVal SkillKey As Objects.ObjectKey)
            Try
                Dim ExtraClassSkill As ExtraClassSkill = CType(_ExtraClassSkills.ItemData(ClassKey, SkillKey).Data, ExtraClassSkill)

                If Not ExtraClassSkill.IsNew Then _Deleted.Add(ExtraClassSkill)
                _ExtraClassSkills.RemoveItem(ClassKey, SkillKey)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'is this a class skill at the specified class level?
        Public Function IsExtraClassSkill(ByVal ClassKey As Objects.ObjectKey, ByVal SkillKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As Boolean
            Try

                'does this library contain a race key
                For Each Key As Objects.ObjectKey In _ExtraClassSkills.Keys
                    If Key.Database = XML.DBTypes.Races OrElse Key.Database = XML.DBTypes.MonsterRaces Then
                        For Each Subkey As Objects.ObjectKey In _ExtraClassSkills.Subkeys(Key)
                            If Subkey.Equals(SkillKey) Then
                                Return True
                            End If
                        Next
                        Exit For
                    End If
                Next

                'else just look for the class key
                Return _ExtraClassSkills.ContainsSubkey(ClassKey, SkillKey, CharacterLevel)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this equal
        Public Overloads Function Equals(ByVal Temp As ExtraClassSkills) As Boolean
            Try
                If Me._ExtraClassSkills.Equals(Temp._ExtraClassSkills) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#Region "Choose Bonus Class Skills"

        'get the available bonus class skill slots for this pass of the wizard
        Public Function BonusClassSkillSlots() As ArrayList
            Try
                Dim Slots As New ArrayList

                'go through all the levels gained
                For i As Integer = _Character.FirstNewLevel To _Character.CharacterLevel

                    'get each class level and find any bonus class skills
                    Dim ClassLevel As New Objects.ObjectData
                    ClassLevel.Load(_Character.Levels(i).ClassLevelGuid)

                    Dim NewSlot As New BonusClassSkillSlot
                    NewSlot.CharacterLevel = i

                    Dim BonusClassSkills As Objects.ObjectDataCollection

                    'get the race objects
                    If i = 1 Then
                        NewSlot.SlotSource = BonusClassSkillSlotSource.Race
                        BonusClassSkills = New Objects.ObjectDataCollection

                        BonusClassSkills.AddMany(_Character.RaceObject.ChildrenOfType(Objects.BonusClassSkillType))
                        BonusClassSkills.AddMany(_Character.RaceObject.ChildrenOfType(Objects.BonusClassSkillChoiceOrSpecificType))

                        ProcessClassSkillSlot(BonusClassSkills, Slots, NewSlot)
                    End If

                    NewSlot.SlotSource = BonusClassSkillSlotSource.Class
                    BonusClassSkills = New Objects.ObjectDataCollection

                    'get the class level objects
                    BonusClassSkills.AddMany(ClassLevel.ChildrenOfType(Objects.BonusClassSkillType))
                    BonusClassSkills.AddMany(ClassLevel.ChildrenOfType(Objects.BonusClassSkillChoiceOrSpecificType))

                    'get any domain objects
                    For Each Domain As Domain In _Character.Domains.DomainsGainedAtLevel(i)
                        Dim DomainDef As Objects.ObjectData = Domain.DomainObj.GetFKObject("Domain")
                        BonusClassSkills.AddMany(DomainDef.ChildrenOfType(Objects.BonusClassSkillChoiceOrSpecificType))
                    Next

                    'get any psionic specialization objects
                    For Each PsionicSpecialization As PsionicSpecialization In _Character.PsionicSpecializations.SpecializationsGainedAtLevel(i)
                        Dim SpecDef As Objects.ObjectData = PsionicSpecialization.SpecializationObj.GetFKObject("PsionicSpecialization")
                        BonusClassSkills.AddMany(SpecDef.ChildrenOfType(Objects.BonusClassSkillChoiceOrSpecificType))
                    Next

                    'process them all
                    ProcessClassSkillSlot(BonusClassSkills, Slots, NewSlot)
                Next

                Return Slots

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'process a collection of extra skill slots
        Private Sub ProcessClassSkillSlot(ByVal BonusClassSkills As Objects.ObjectDataCollection, ByVal Slots As ArrayList, ByVal NewSlot As BonusClassSkillSlot)

            'process them all
            For Each BonusClassSkill As Objects.ObjectData In BonusClassSkills
                Select Case BonusClassSkill.Type
                    Case Objects.BonusClassSkillType
                        'straight bonus slots
                        NewSlot.SkillTakenKey = Nothing
                        NewSlot.SkillTakenName = Nothing
                        NewSlot.SlotType = BonusClassSkillSlotType.BonusClassSkill
                        NewSlot.SkillChoices = Nothing
                        Slots.Add(NewSlot)
                    Case Objects.BonusClassSkillChoiceOrSpecificType
                        'specifics and choose from list
                        Select Case BonusClassSkill.Element("ChoiceType")
                            Case "Specific"
                                NewSlot.SkillTakenKey = BonusClassSkill.GetFKGuid("Specific")
                                NewSlot.SkillTakenName = BonusClassSkill.Element("Specific")
                                NewSlot.SlotType = BonusClassSkillSlotType.SpecificBonusClassSkill
                                NewSlot.SkillChoices = Nothing
                                Slots.Add(NewSlot)
                            Case "Choice"
                                NewSlot.SkillTakenKey = Nothing
                                NewSlot.SkillTakenName = Nothing
                                NewSlot.SlotType = BonusClassSkillSlotType.ChooseBonusClassSkill
                                NewSlot.SkillChoices = New ArrayList

                                For n As Integer = 1 To BonusClassSkill.ElementAsInteger("ChoiceCount")
                                    NewSlot.SkillChoices.Add(BonusClassSkill.GetFKGuid("Choice" & n.ToString))
                                Next
                                Slots.Add(NewSlot)
                        End Select
                End Select
            Next

        End Sub

        'get the available bonus class skill choices for a slot
        Public Function AvailableChoices(ByVal Slot As BonusClassSkillSlot) As ArrayList
            Try
                Dim SkillChoices As New Objects.ObjectDataCollection

                'first pass
                Select Case Slot.SlotType
                    Case BonusClassSkillSlotType.BonusClassSkill
                        'construct the base list of choices, by removing any group skills and replacing them with the group.
                        For Each SkillDef As Objects.ObjectData In Caches.Skills
                            If SkillDef.Element("SkillGroup") = "" Then SkillChoices.Add(SkillDef)
                        Next
                        SkillChoices.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillGroupType))
                    Case BonusClassSkillSlotType.ChooseBonusClassSkill
                        'construct temp combined list of skills and groups
                        Dim Temp As Objects.ObjectDataCollection = Caches.Skills
                        Temp.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillGroupType))

                        'choices already defined
                        For Each SkillKey As Objects.ObjectKey In Slot.SkillChoices
                            SkillChoices.Add(Temp.Item(SkillKey))
                        Next
                    Case BonusClassSkillSlotType.SpecificBonusClassSkill
                        'no choices -> exit
                        Return New ArrayList
                End Select

                Dim CrossClassSkills As New Objects.ObjectDataCollection

                'second pass
                Select Case Slot.SlotType
                    Case BonusClassSkillSlotType.BonusClassSkill
                        'calculate cross class skills at this level
                        For Each SkillDef As Objects.ObjectData In SkillChoices
                            If Not _Character.Skills.IsClassSkillForClassAtLevel(_Character.Levels(Slot.CharacterLevel).ClassGuid, SkillDef.ObjectGUID, Slot.CharacterLevel) Then CrossClassSkills.Add(SkillDef)
                        Next
                    Case BonusClassSkillSlotType.ChooseBonusClassSkill
                        'get choices removing any that are already class skills
                        For Each SkillDef As Objects.ObjectData In SkillChoices
                            If Not _Character.Skills.IsClassSkillForClassAtLevel(_Character.Levels(Slot.CharacterLevel).ClassGuid, SkillDef.ObjectGUID, Slot.CharacterLevel) Then
                                CrossClassSkills.Add(SkillDef)
                            End If
                        Next
                End Select

                'construct choices
                Dim Choices As New ArrayList

                For Each SkillDef As Objects.ObjectData In CrossClassSkills
                    Dim Choice As BonusClassSkillChoice

                    Choice.HTML = SkillDef.HTML
                    Choice.SkillKey = SkillDef.ObjectGUID
                    Choice.SkillName = SkillDef.Name

                    Choices.Add(Choice)
                Next

                Return Choices

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

    End Class

    'this class stores an extra class skill
    Public Class ExtraClassSkill

#Region "Member Variables"

        Public IsNew As Boolean
        Private _Character As Character
        Public ExtraClassSkillObj As Objects.ObjectData

#End Region

        'constructor
        Public Sub New(ByVal Character As Character)
            Try
                _Character = Character
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'create object
        Public Sub CreateObject(ByVal SkillDef As Objects.ObjectData, ByVal ClassDef As Objects.ObjectData, ByVal CharacterLevel As Integer)
            Try
                ExtraClassSkillObj.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                ExtraClassSkillObj.Type = Objects.ExtraClassSkillType
                ExtraClassSkillObj.ParentGUID = _Character.CharacterObject.ObjectGUID
                ExtraClassSkillObj.FKElement("Skill", SkillDef.Name, "Name", SkillDef.ObjectGUID)
                ExtraClassSkillObj.FKElement("Class", ClassDef.Name, "Name", ClassDef.ObjectGUID)
                'required for domains if this is ever put in 
                'ExtraClassSkillObj.FKElement("Source", SourceDef.Name, "Name", SourceDef.ObjectGUID)
                ExtraClassSkillObj.ElementAsInteger("CharacterLevel") = CharacterLevel
                ExtraClassSkillObj.HTMLGUID = SkillDef.ObjectGUID
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace

