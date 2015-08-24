Option Explicit On
Option Strict On

Imports RPGXplorer.Rules.Constants
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Namespace Rules

    Public Class AvailableSpellcasters

#Region "Structures"


        'structure used when viewing available spells during levelling
        Public Structure AvailableSpellcaster
            Public SpellcasterName As String
            Public SpellcasterGuid As Objects.ObjectKey

            Public Overrides Function ToString() As String
                Return SpellcasterName
            End Function
        End Structure

        Public Structure SpellcasterSlot
            Public CharacterLevel As Integer
            Public PrestigeClassName As String
            Public PrestigeClassGuid As Objects.ObjectKey

            Public ExistingSpellcasterName As String
            Public ExistingSpellcasterGuid As Objects.ObjectKey

            Public Type As SpellcasterSlotType
            Public SpellLevelRestriction As Boolean
            Public MinSpellLevel As Integer

            Public Sub Clear()
                CharacterLevel = Nothing
                CharacterLevel = Nothing
                PrestigeClassName = Nothing
                PrestigeClassGuid = Nothing
                ExistingSpellcasterName = Nothing
                ExistingSpellcasterGuid = Nothing
                Type = Nothing
                SpellLevelRestriction = False
                MinSpellLevel = 0
            End Sub
        End Structure

        Public Enum SpellcasterSlotType
            Arcane
            Divine
            Either
            Both
            Psionic
        End Enum

#End Region

#Region "Member Variables"

        'The character to which this class applies
        Private NewCharacter As Rules.Character
        Private ExistingCharacter As Rules.Character

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Me.NewCharacter = Character
        End Sub

        Public Sub Init(ByVal EC As Rules.Character)
            Me.ExistingCharacter = EC
        End Sub

        'Gives a list of available Spellcasters for the given slot
        Public Function AvailableSpellcastersList(ByVal Slot As SpellcasterSlot) As ArrayList
            Dim SpellcasterList As New ArrayList
            Dim AvailableSpellcaster As AvailableSpellcaster
            Dim ClassInfo As Rules.CharacterClass
            Dim ClassObject As Objects.ObjectData
            Dim AddCaster, TakenAlready As Boolean

            For Each ClassInfo In NewCharacter.CharacterClasses.Values
                If NewCharacter.LowestClassLevel(ClassInfo.ClassObj.ObjectGUID) < Slot.CharacterLevel Then

                    'make sure we havent already taken this class for this level
                    TakenAlready = False
                    For Each ItemData As Library.LibraryData In NewCharacter.PrestigeSpellcasterChoices.ItemData(ClassInfo.ClassObj.ObjectGUID)
                        If DirectCast(ItemData.Data, Rules.Character.CharacterChoice).LevelAcquired = Slot.CharacterLevel Then
                            TakenAlready = True
                            Exit For
                        End If
                    Next

                    If Not TakenAlready Then
                        AddCaster = False
                        ClassObject = ClassInfo.ClassObj
                        Select Case Slot.Type
                            Case SpellcasterSlotType.Arcane
                                If ClassObject.Element("CasterType").StartsWith("Arcane") Then
                                    If Slot.SpellLevelRestriction = True Then
                                        If NewCharacter.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, Slot.CharacterLevel) >= Slot.MinSpellLevel Then AddCaster = True
                                    Else
                                        AddCaster = True
                                    End If
                                End If
                            Case SpellcasterSlotType.Divine
                                If ClassObject.Element("CasterType").StartsWith("Divine") Then
                                    If Slot.SpellLevelRestriction = True Then
                                        If NewCharacter.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, Slot.CharacterLevel) >= Slot.MinSpellLevel Then AddCaster = True
                                    Else
                                        AddCaster = True
                                    End If
                                End If
                            Case SpellcasterSlotType.Either
                                If (ClassObject.Element("CasterType").StartsWith("Arcane")) OrElse (ClassObject.Element("CasterType").StartsWith("Divine")) Then
                                    If Slot.SpellLevelRestriction = True Then
                                        If NewCharacter.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, Slot.CharacterLevel) >= Slot.MinSpellLevel Then AddCaster = True
                                    Else
                                        AddCaster = True
                                    End If
                                End If
                            Case SpellcasterSlotType.Psionic
                                If ClassObject.Element("CasterAbility") = "Psionic" Then
                                    AddCaster = True
                                End If
                        End Select

                        If AddCaster Then
                            AvailableSpellcaster.SpellcasterName = ClassObject.Name
                            AvailableSpellcaster.SpellcasterGuid = ClassObject.ObjectGUID
                            SpellcasterList.Add(AvailableSpellcaster)
                        End If

                    End If
                End If
            Next

            Return SpellcasterList

        End Function

        'Gets the available spells slots for the given class, make sure you have loaded the given class before calling this
        Public Function AvailableSpellcasterSlots() As ArrayList
            Dim StartLevel, NumberOfChildren As Integer
            Dim Slot As New SpellcasterSlot
            Dim Slots As New ArrayList
            Dim ClassInfo As Rules.CharacterClass
            Dim ClassObject As Objects.ObjectData
            Dim ClassLevelObject As Objects.ObjectData

            'Get all the Prestige Class Caster Types added this session
            StartLevel = NewCharacter.FirstNewLevel

            For i As Integer = StartLevel To NewCharacter.CharacterLevel
                ClassInfo = DirectCast(NewCharacter.CharacterClasses(NewCharacter.Levels(i).ClassGuid), Rules.CharacterClass)
                ClassObject = ClassInfo.ClassObj

                If ClassObject.Element("CasterAbility") = "Prestige Advancement" Then
                    ClassLevelObject = ClassInfo.ClassLevel(NewCharacter.Levels(i).ClassLevel)

                    NumberOfChildren = ClassLevelObject.ChildrenOfType(Objects.ExistingSpellcasterLevel).Count
                    If NumberOfChildren > 0 Then

                        Dim TempSlotType As SpellcasterSlotType = DirectCast([Enum].Parse(GetType(SpellcasterSlotType), ClassObject.Element("PrestigeSpellType")), SpellcasterSlotType)
                        Select Case TempSlotType

                            Case SpellcasterSlotType.Arcane, SpellcasterSlotType.Divine, SpellcasterSlotType.Either
                                For n As Integer = 1 To NumberOfChildren
                                    Slot.Clear()
                                    Slot.CharacterLevel = i
                                    Slot.PrestigeClassGuid = ClassObject.ObjectGUID
                                    Slot.PrestigeClassName = ClassObject.Name
                                    Slot.Type = TempSlotType
                                    If ClassObject.Element("PrestigeRestriction") = "True" Then
                                        Slot.SpellLevelRestriction = True
                                        Slot.MinSpellLevel = ClassObject.ElementAsInteger("PrestigeSpellLevel")
                                    End If
                                    Slots.Add(Slot)
                                Next

                                'Add two slots in for the "Both" type
                            Case SpellcasterSlotType.Both
                                For n As Integer = 1 To NumberOfChildren
                                    Slot.Clear()
                                    Slot.CharacterLevel = i
                                    Slot.PrestigeClassGuid = ClassObject.ObjectGUID
                                    Slot.PrestigeClassName = ClassObject.Name
                                    Slot.Type = SpellcasterSlotType.Arcane
                                    If ClassObject.Element("PrestigeRestriction") = "True" Then
                                        Slot.SpellLevelRestriction = True
                                        Slot.MinSpellLevel = ClassObject.ElementAsInteger("PrestigeSpellLevel")
                                    End If
                                    Slots.Add(Slot)

                                    Slot.Clear()
                                    Slot.CharacterLevel = i
                                    Slot.PrestigeClassGuid = ClassObject.ObjectGUID
                                    Slot.PrestigeClassName = ClassObject.Name
                                    Slot.Type = SpellcasterSlotType.Divine
                                    If ClassObject.Element("PrestigeRestriction") = "True" Then
                                        Slot.SpellLevelRestriction = True
                                        Slot.MinSpellLevel = ClassObject.ElementAsInteger("PrestigeSpellLevel")
                                    End If
                                    Slots.Add(Slot)
                                Next
                        End Select
                    End If

                    NumberOfChildren = ClassLevelObject.ChildrenOfType(Objects.ExistingManifesterLevel).Count
                    If NumberOfChildren > 0 Then
                        For n As Integer = 1 To NumberOfChildren
                            Slot.Clear()
                            Slot.CharacterLevel = i
                            Slot.PrestigeClassGuid = ClassObject.ObjectGUID
                            Slot.PrestigeClassName = ClassObject.Name
                            Slot.Type = SpellcasterSlotType.Psionic
                            Slots.Add(Slot)
                        Next
                    End If
                End If
            Next

            Return Slots

        End Function

    End Class

End Namespace
