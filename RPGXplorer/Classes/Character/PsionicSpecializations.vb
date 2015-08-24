Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Namespace Rules

#Region "Structures"

    'domain slot for the bonus domain panel
    Public Structure PsionicSpecialSlot
        Public CharacterLevel As Integer
        Public SlotType As SpecializationSlotType
        Public SpecializationTakenKey As Objects.ObjectKey
        Public SpecializationTakenName As String
        Public SpecializationChoices As ArrayList

        Public ReadOnly Property SlotTypeName() As String
            Get
                Select Case SlotType
                    Case SpecializationSlotType.BonusSpecialization
                        Return "Bonus Specialization"
                    Case SpecializationSlotType.ChooseBonusSpecialization
                        Return "Choose Bonus Specialization"
                    Case SpecializationSlotType.SpecificBonusSpecialization
                        Return "Specific Bonus Specialization"
                End Select
                Return ""
            End Get
        End Property

    End Structure

    'domain choice 
    Public Structure SpecializationChoice
        Public SpecializationKey As Objects.ObjectKey
        Public SpecializationName As String
        Public AlreadyTaken As Boolean
        Public HTML As String
    End Structure

#End Region

#Region "Enumerations"

    'domain slot type
    Public Enum SpecializationSlotType
        BonusSpecialization
        ChooseBonusSpecialization
        SpecificBonusSpecialization
    End Enum

#End Region

    'this class handles a collection of psionic specializations attached to a character
    Public Class PsionicSpecializations

#Region "Member Variables"

        Private _PsionicSpecializations As Library
        Private _Character As Rules.Character
        Private _Deleted As New ArrayList
        Private _PsionicSpecializationFolderKey As Objects.ObjectKey

#End Region

#Region "Properties"

        'default item property
        Default Public ReadOnly Property Item(ByVal ClassKey As Objects.ObjectKey, ByVal DomainKey As Objects.ObjectKey) As PsionicSpecialization
            Get
                Return DirectCast(_PsionicSpecializations.ItemData(ClassKey, DomainKey).Data, PsionicSpecialization)
            End Get
        End Property

        'get the specialization folder key
        Public ReadOnly Property PsionicSpecializationFolderKey() As Objects.ObjectKey
            Get
                Return _PsionicSpecializationFolderKey
            End Get
        End Property

        'get the character
        Public ReadOnly Property Character() As Rules.Character
            Get
                Return _Character
            End Get
        End Property

        Public ReadOnly Property PsionicSpecializations() As Library
            Get
                Return _PsionicSpecializations
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Character)
            Try
                _Character = Character
                _PsionicSpecializations = New Library()
                _Deleted = New ArrayList

                'get the domain folder
                Dim SpecializationFolder As Objects.ObjectData = _Character.PsionicFolder.FirstChildOfType(Objects.PsionicSpecializationFolderType)
                If SpecializationFolder.ObjectGUID.IsNotEmpty Then
                    _PsionicSpecializationFolderKey = SpecializationFolder.ObjectGUID
                Else
                    'create a new folder key
                    _PsionicSpecializationFolderKey = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'private constructor for clone
        Private Sub New(ByVal Character As Character, ByVal PsionicSpecializations As Library, ByVal Deleted As ArrayList, ByVal FolderKey As Objects.ObjectKey)
            Try
                _Character = Character
                _PsionicSpecializations = PsionicSpecializations
                _Deleted = Deleted
                _PsionicSpecializationFolderKey = FolderKey
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load
        Public Sub Load()
            Try
                _PsionicSpecializations.Clear()
                _Deleted.Clear()

                'load any specialization objects on this character 
                For Each SpecializationObj As Objects.ObjectData In _Character.CharacterObject.FirstChildOfType(Objects.PsionicFolderType).FirstChildOfType(Objects.PsionicSpecializationFolderType).ChildrenOfType(Objects.PsionicSpecializationType)
                    Dim Specialization As New PsionicSpecialization(_Character)
                    Specialization.IsNew = False
                    Specialization.SpecializationObj = SpecializationObj
                    _PsionicSpecializations.AddItemWithSubkey(Specialization.SpecializationObj.GetFKGuid("Class"), Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), Specialization, SpecializationObj.ElementAsInteger("LevelAcquired"))
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save
        Public Sub Save()
            Try

                'check if I need saved
                Dim PsionicClasses As Boolean

                If Character.IsRacialManifester Then
                    PsionicClasses = True
                End If

                If Not PsionicClasses Then
                    For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                        If Character.CharacterClasses(ClassKey).ClassObj.Element("CasterAbility") = "Psionic" Then
                            PsionicClasses = True
                            Exit For
                        End If
                    Next
                End If

                'delete any removed objects
                For Each SpecializationObj As Objects.ObjectData In _Deleted
                    SpecializationObj.Delete()
                Next
                _Deleted.Clear()

                If _PsionicSpecializations.ItemData.Count > 0 Or PsionicClasses Then

                    'make sure the magic folder is saved
                    _Character.PsionicFolderSave()

                    'make sure our specialization folder has been created
                    If _Character.PsionicFolder.FirstChildOfType(Objects.PsionicSpecializationFolderType).IsEmpty Then
                        Dim PsionicSpecializationFolder As New Objects.ObjectData
                        PsionicSpecializationFolder.Name = "Psionic Specializations"
                        PsionicSpecializationFolder.ObjectGUID = Me.PsionicSpecializationFolderKey
                        PsionicSpecializationFolder.Type = Objects.PsionicSpecializationFolderType
                        PsionicSpecializationFolder.ParentGUID = _Character.PsionicFolder.ObjectGUID
                        PsionicSpecializationFolder.Save()
                    End If

                    'save all remaining objects
                    For Each DataItem As Library.LibraryData In _PsionicSpecializations.ItemData
                        Dim Specialization As PsionicSpecialization = DirectCast(DataItem.Data, Rules.PsionicSpecialization)
                        Specialization.SpecializationObj.Save()
                    Next

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'clone
        Public Function Clone(ByRef CloneCharacter As Character) As PsionicSpecializations
            Try
                Clone = New PsionicSpecializations(CloneCharacter, Me._PsionicSpecializations.Clone, DirectCast(Me._Deleted.Clone, ArrayList), Me._PsionicSpecializationFolderKey)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'count of domains
        Public Function Count() As Integer
            Try
                Return _PsionicSpecializations.ItemData.Count
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add a to the character
        Public Sub AddSpecialization(ByVal SpecializationDef As Objects.ObjectData, ByVal ClassDef As Objects.ObjectData, ByVal CharacterLevel As Integer, Optional ByVal SaveObjects As Boolean = False)
            Try
                Dim Specialization As New PsionicSpecialization(_Character)
                Specialization.CreateObject(SpecializationDef, ClassDef, CharacterLevel)
                Specialization.IsNew = True
                AddSpecialization(Specialization, CharacterLevel, SaveObjects)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'add a domain to the character
        Private Sub AddSpecialization(ByVal Specialization As PsionicSpecialization, ByVal CharacterLevel As Integer, ByVal SaveObjects As Boolean)
            Try
                'add to domains
                _PsionicSpecializations.AddItemWithSubkey(Specialization.SpecializationObj.GetFKGuid("Class"), Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), Specialization, CharacterLevel)

                'if this is outside the wizard - analyse and add the child objects
                If SaveObjects Then
                    SaveChildComponents(Specialization)
                Else
                    'add the features to the character
                    AnalyseFeatures(Specialization)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'analyse a domain for its features
        Private Sub AnalyseFeatures(ByVal Specialization As PsionicSpecialization)
            Try
                Dim SpecializationDef As Objects.ObjectData = Specialization.SpecializationObj.GetFKObject("PsionicSpecialization")

                'get features 
                For Each Feature As Objects.ObjectData In SpecializationDef.ChildrenOfType(Objects.FeatureType)
                    If _Character.Features.CanTakeFeature(Feature.GetFKGuid("Feature"), Specialization.SpecializationObj.GetFKGuid("Class")) Then
                        _Character.Features.AddFeature(Feature.GetFKGuid("Feature"), Specialization.SpecializationObj.Element("Class"), Specialization.SpecializationObj.GetFKGuid("Class"), Specialization.SpecializationObj.ElementAsInteger("LevelAcquired"), Specialization.SpecializationObj.ObjectGUID, Specialization.SpecializationObj.Name)
                    End If
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'analyse a domin for bonus feats - adds them and their child components
        Public Function AnalyseFeats(ByVal Specialization As PsionicSpecialization) As ArrayList
            Try
                Dim ReturnList As New ArrayList
                Dim SpecializationDef As Objects.ObjectData = Specialization.SpecializationObj.GetFKObject("PsionicSpecialization")

                'get feats
                For Each SpecificBonusFeat As Objects.ObjectData In SpecializationDef.ChildrenOfType(Objects.SpecificBonusFeatType)
                    Dim Focus As Objects.ObjectData = SpecificBonusFeat.GetFKObject("Focus")

                    If (Focus.IsEmpty AndAlso Character.Feats.ContainsKey(SpecificBonusFeat.GetFKGuid("Feat")) = False) _
                    OrElse ((Not Focus.IsEmpty) AndAlso Character.Feats.ContainsSubkey(SpecificBonusFeat.GetFKGuid("Feat"), Focus.ObjectGUID) = False) _
                    OrElse (SpecificBonusFeat.GetFKObject("Feat").Element("Stacks") = "Yes") Then

                        'add to character
                        Dim NewFeat As New Rules.Character.Feat
                        NewFeat.Clear()
                        NewFeat.FeatGuid = SpecificBonusFeat.GetFKGuid("Feat")
                        NewFeat.FeatName = SpecificBonusFeat.Element("Feat")
                        NewFeat.FeatType = SpecificBonusFeat.GetFKObject("Feat").Element("FeatType")
                        NewFeat.LevelTaken = Specialization.SpecializationObj.ElementAsInteger("LevelAcquired")
                        NewFeat.FocusGuid = Focus.ObjectGUID
                        NewFeat.FeatSlotSource = Rules.AvailableFeats.SpecificBonusFeat
                        NewFeat.SourceName = SpecializationDef.Name
                        NewFeat.SourceGuid = Specialization.SpecializationObj.ObjectGUID

                        If SpecificBonusFeat.Element("OverridePrerequisites") = "Yes" Then NewFeat.IgnorePrerequisites = True Else NewFeat.IgnorePrerequisites = False
                        If NewFeat.FocusGuid.IsEmpty Then
                            NewFeat.FocusName = ""
                            Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                            Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                        Else
                            NewFeat.FocusName = Focus.Name
                            Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                            Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                        End If

                        ReturnList.Add(NewFeat)

                    End If
                Next

                Return ReturnList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'only called when adding a domain outside wizard
        Private Sub SaveChildComponents(ByVal Specialization As PsionicSpecialization)
            Try
                Dim SpecializationDef As Objects.ObjectData = Specialization.SpecializationObj.GetFKObject("PsionicSpecialization")

                'get features 
                For Each Feature As Objects.ObjectData In SpecializationDef.ChildrenOfType(Objects.FeatureType)
                    If _Character.Features.CanTakeFeature(Feature.GetFKGuid("Feature"), Specialization.SpecializationObj.GetFKGuid("Class")) Then
                        Dim NewFeature As Rules.Feature
                        NewFeature = _Character.Features.CreateFeature(Feature.GetFKGuid("Feature"), Specialization.SpecializationObj.Element("Class"), Specialization.SpecializationObj.GetFKGuid("Class"), Specialization.SpecializationObj.ElementAsInteger("LevelAcquired"), Specialization.SpecializationObj.ObjectGUID, Specialization.SpecializationObj.Name, False)

                        Dim FeatureTaken As Objects.ObjectData
                        FeatureTaken = NewFeature.CreateObject(_Character)
                        FeatureTaken.Save()
                    End If
                Next

                'get feats - tidy up with a CreateFeat later
                For Each SpecificBonusFeat As Objects.ObjectData In SpecializationDef.ChildrenOfType(Objects.SpecificBonusFeatType)
                    Dim Focus As Objects.ObjectData = SpecificBonusFeat.GetFKObject("Focus")

                    If (Focus.IsEmpty AndAlso Character.Feats.ContainsKey(SpecificBonusFeat.GetFKGuid("Feat")) = False) _
                    OrElse ((Not Focus.IsEmpty) AndAlso Character.Feats.ContainsSubkey(SpecificBonusFeat.GetFKGuid("Feat"), Focus.ObjectGUID) = False) _
                    OrElse (SpecificBonusFeat.GetFKObject("Feat").Element("Stacks") = "Yes") Then

                        'add to character
                        Dim NewFeat As New Rules.Character.Feat
                        NewFeat.Clear()
                        NewFeat.FeatGuid = SpecificBonusFeat.GetFKGuid("Feat")
                        NewFeat.FeatName = SpecificBonusFeat.Element("Feat")
                        NewFeat.FeatType = SpecificBonusFeat.GetFKObject("Feat").Element("FeatType")
                        NewFeat.LevelTaken = Specialization.SpecializationObj.ElementAsInteger("LevelAcquired")
                        NewFeat.FocusGuid = Focus.ObjectGUID
                        NewFeat.FeatSlotSource = Rules.AvailableFeats.SpecificBonusFeat
                        NewFeat.SourceName = SpecializationDef.Name
                        NewFeat.SourceGuid = Specialization.SpecializationObj.ObjectGUID
                        If SpecificBonusFeat.Element("OverridePrerequisites") = "Yes" Then NewFeat.IgnorePrerequisites = True Else NewFeat.IgnorePrerequisites = False
                        If NewFeat.FocusGuid.IsEmpty Then NewFeat.FocusName = "" Else NewFeat.FocusName = Focus.Name

                        Dim FeatTaken As Objects.ObjectData
                        FeatTaken = NewFeat.CreateObject(_Character)
                        FeatTaken.Save()
                    End If
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove a domain from the character
        Public Sub RemoveSpecialization(ByVal ClassKey As Objects.ObjectKey, ByVal SpecializationKey As Objects.ObjectKey, Optional ByVal DeleteObjects As Boolean = False)
            Try
                Dim Specialization As PsionicSpecialization = DirectCast(_PsionicSpecializations.ItemData(ClassKey, SpecializationKey).Data, PsionicSpecialization)
                If Not Specialization.IsNew Then _Deleted.Add(Specialization)
                _PsionicSpecializations.RemoveItem(ClassKey, SpecializationKey)

                If DeleteObjects Then
                    DeleteChildComponents(Specialization)
                Else
                    DeanalyseFeatures(Specialization)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove any features that have been added to the character form this domain
        Private Sub DeanalyseFeatures(ByVal Specialization As PsionicSpecialization)
            Try
                'remove features
                For Each DataItem As Library.LibraryData In Character.Features.Features.ItemData
                    Dim Feature As Feature = DirectCast(DataItem.Data, Feature)
                    If Feature.ActualSourceGuid.Equals(Specialization.SpecializationObj.ObjectGUID) AndAlso Feature.ClassGuid.Equals(Specialization.SpecializationObj.GetFKGuid("Class")) AndAlso Feature.LevelTaken = Specialization.SpecializationObj.ElementAsInteger("LevelAcquired") Then
                        Character.Features.RemoveFeature(Feature.FeatureGuid, Feature.ClassGuid, Feature.LevelTaken)
                    End If
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove any components that have been added to the character for this domain
        Private Sub DeleteChildComponents(ByVal Specialization As PsionicSpecialization)
            Try
                Dim CurrentFeatures, CurrentFeats As Objects.ObjectDataCollection

                CurrentFeats = _Character.CharacterObject.FirstChildOfType(Objects.FeatFolderType).Children
                CurrentFeatures = _Character.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children

                'remove features
                For Each DataItem As Library.LibraryData In Character.Features.Features.ItemData
                    Dim Feature As Feature = DirectCast(DataItem.Data, Feature)
                    If Feature.ActualSourceGuid.Equals(Specialization.SpecializationObj.ObjectGUID) AndAlso Feature.ClassGuid.Equals(Specialization.SpecializationObj.GetFKGuid("Class")) AndAlso Feature.LevelTaken = Specialization.SpecializationObj.ElementAsInteger("LevelAcquired") Then
                        For Each FeatureTaken As Objects.ObjectData In CurrentFeatures
                            If FeatureTaken.GetFKGuid("Feature").Equals(Feature.FeatureGuid) AndAlso FeatureTaken.GetFKGuid("Class").Equals(Feature.ClassGuid) Then
                                If FeatureTaken.GetFKGuid("Source").Equals(Feature.ActualSourceGuid) And FeatureTaken.ElementAsInteger("CharacterLevel") = Feature.LevelTaken Then
                                    FeatureTaken.Delete()
                                    CurrentFeatures.Remove(FeatureTaken.ObjectGUID)
                                    Exit For
                                End If
                            End If
                        Next

                    End If
                Next

                'remove feats
                For Each DataItem As Library.LibraryData In _Character.Feats.ItemData
                    Dim Feat As Rules.Character.Feat = DirectCast(DataItem.Data, Rules.Character.Feat)
                    If Feat.SourceGuid.Equals(Specialization.SpecializationObj.ObjectGUID) AndAlso Feat.LevelTaken = Specialization.SpecializationObj.ElementAsInteger("LevelAcquired") Then
                        For Each FeatTaken As Objects.ObjectData In CurrentFeats
                            If FeatTaken.GetFKGuid("Feat").Equals(Feat.FeatGuid) AndAlso FeatTaken.GetFKGuid("Focus").Equals(Feat.FocusGuid) Then
                                If FeatTaken.GetFKGuid("Source").Equals(Feat.SourceGuid) AndAlso FeatTaken.ElementAsInteger("CharacterLevel") = Feat.LevelTaken Then
                                    FeatTaken.Delete()
                                    CurrentFeats.Remove(FeatTaken.ObjectGUID)
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'does the character have this specialization for any class?
        Public Function HasSpecialization(ByVal SpecializationKey As Objects.ObjectKey, Optional ByVal CharacterLevel As Integer = 1000) As Boolean
            Try
                For Each ClassKey As Objects.ObjectKey In _PsionicSpecializations.Keys
                    If _PsionicSpecializations.ContainsSubkey(ClassKey, SpecializationKey, CharacterLevel) Then Return True
                Next

                Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'does the character have this specialization for this class?
        Public Function HasSpecialization(ByVal ClassKey As Objects.ObjectKey, ByVal SpecializationKey As Objects.ObjectKey, Optional ByVal CharacterLevel As Integer = 1000) As Boolean
            Try
                If _PsionicSpecializations.ContainsSubkey(ClassKey, SpecializationKey, CharacterLevel) Then Return True Else Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get deity and/or alignment compatible Psionic Specializations
        Public Function CompatibleSpecializations(ByVal ClassKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                Dim Specializations As New Objects.ObjectDataCollection
                Dim ClassInfo As Rules.CharacterClass = _Character.CharacterClasses(ClassKey)

                If ClassInfo.CasterInfo.RestrictPsionicSpecialization And (Not _Character.DeityObject.IsEmpty) Then
                    Dim DeityChildren As Objects.ObjectDataCollection = _Character.DeityObject.ChildrenOfType(Objects.DeityPsionicSpecializationChildType)
                    For Each DeitySpecialization As Objects.ObjectData In DeityChildren
                        Specializations.Add(DeitySpecialization.GetFKObject("Domain"))
                    Next
                Else
                    Specializations = Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType)
                End If

                Return Specializations

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets compatible domains but excludes any that have already been taken for this class
        Public Function AvailableSpecializations(ByVal ClassKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                Dim Compatible As Objects.ObjectDataCollection = CompatibleSpecializations(ClassKey)
                Dim Available As New Objects.ObjectDataCollection

                For Each Specialization As Objects.ObjectData In Compatible
                    If Not HasSpecialization(ClassKey, Specialization.ObjectGUID) Then Available.Add(Specialization)
                Next

                Return Available

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the domains associated with the specified class
        Public Function ClassSpecializations(ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As ArrayList
            Try
                Dim List As New ArrayList

                If _PsionicSpecializations.ContainsKey(ClassKey) Then
                    For Each DataItem As Library.LibraryData In _PsionicSpecializations.ItemData(ClassKey, CharacterLevel)
                        List.Add(DirectCast(DataItem.Data, PsionicSpecialization))
                    Next
                End If

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the domains gained at a specific level
        Public Function SpecializationsGainedAtLevel(ByVal CharacterLevel As Integer) As ArrayList
            Try
                Dim List As New ArrayList

                For Each LibraryData As Library.LibraryData In _PsionicSpecializations.ItemData()
                    Dim Specialization As PsionicSpecialization = DirectCast(LibraryData.Data, PsionicSpecialization)
                    If LibraryData.LevelAcquired = CharacterLevel Then
                        List.Add(Specialization)
                    End If
                Next

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the domains gained on or after the specifed level
        Public Function SpecializationsGainedSinceLevel(ByVal CharacterLevel As Integer) As ArrayList
            Try
                Dim List As New ArrayList

                For Each LibraryData As Library.LibraryData In _PsionicSpecializations.ItemData()
                    Dim Specialization As PsionicSpecialization = DirectCast(LibraryData.Data, PsionicSpecialization)
                    If LibraryData.LevelAcquired >= CharacterLevel Then
                        List.Add(Specialization)
                    End If
                Next

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'are the librarys equal
        Public Overloads Function Equals(ByVal CompareSpecialization As PsionicSpecializations) As Boolean
            Try
                If _PsionicSpecializations.Equals(CompareSpecialization._PsionicSpecializations) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#Region "Choose Psionic Specializations"

        'get the available psionic specialization slots for this pass of the wizard
        Public Function BonusSpecializationSlots() As ArrayList
            Try
                Dim Slots As New ArrayList

                'go through all the levels gained
                For i As Integer = _Character.FirstNewLevel To _Character.CharacterLevel

                    'get each class level and find any bonus domains 
                    Dim ClassLevel As New Objects.ObjectData
                    ClassLevel.Load(_Character.Levels(i).ClassLevelGuid)

                    Dim NewSlot As New PsionicSpecialSlot
                    NewSlot.CharacterLevel = i

                    'bonus specializations
                    For Each BonusDomain As Objects.ObjectData In ClassLevel.ChildrenOfType(Objects.BonusPsionicSpecializationType)
                        NewSlot.SlotType = SpecializationSlotType.BonusSpecialization
                        Slots.Add(NewSlot)
                    Next

                    'specific or choose bonus specializations
                    For Each SpecificOrChooseBonusSpecialization As Objects.ObjectData In ClassLevel.ChildrenOfType(Objects.BonusPsionicSpecializationChoiceorSpecificType)
                        If SpecificOrChooseBonusSpecialization.Element("ChoiceType") = "Specific" Then
                            NewSlot.SlotType = SpecializationSlotType.SpecificBonusSpecialization
                            NewSlot.SpecializationTakenKey = SpecificOrChooseBonusSpecialization.GetFKGuid("Specific")
                            NewSlot.SpecializationTakenName = SpecificOrChooseBonusSpecialization.Element("Specific")
                        Else
                            NewSlot.SlotType = SpecializationSlotType.ChooseBonusSpecialization
                            NewSlot.SpecializationChoices = New ArrayList

                            For n As Integer = 1 To SpecificOrChooseBonusSpecialization.ElementAsInteger("ChoiceCount")
                                NewSlot.SpecializationChoices.Add(SpecificOrChooseBonusSpecialization.GetFKGuid("Choice" & n.ToString))
                            Next

                        End If

                        Slots.Add(NewSlot)
                    Next
                Next

                Return Slots
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the available domain choices for a slot
        Public Function AvailableSpecializationChoices(ByVal Slot As PsionicSpecialSlot) As ArrayList
            Try
                Dim Specializations As New Objects.ObjectDataCollection

                Select Case Slot.SlotType
                    Case SpecializationSlotType.BonusSpecialization
                        'get deity or alignment compatible domains                        
                        Specializations = CompatibleSpecializations(_Character.Levels(Slot.CharacterLevel).ClassGuid)

                    Case SpecializationSlotType.ChooseBonusSpecialization
                        'get domain choices from slot
                        Specializations = New Objects.ObjectDataCollection
                        For Each SpecializationKey As Objects.ObjectKey In Slot.SpecializationChoices
                            Dim SpecializationDefinition As New Objects.ObjectData
                            SpecializationDefinition.Load(SpecializationKey)
                            Specializations.Add(SpecializationDefinition)
                        Next

                    Case SpecializationSlotType.SpecificBonusSpecialization
                        'return empty list
                        Return New ArrayList
                End Select

                'construct domain choices
                Dim AvailableSpecializations As New ArrayList

                For Each Specialization As Objects.ObjectData In Specializations
                    Dim SpecializationChoice As SpecializationChoice
                    SpecializationChoice.SpecializationName = Specialization.Name
                    SpecializationChoice.SpecializationKey = Specialization.ObjectGUID
                    SpecializationChoice.AlreadyTaken = HasSpecialization(_Character.Levels(Slot.CharacterLevel).ClassGuid, Specialization.ObjectGUID)
                    SpecializationChoice.HTML = Specialization.HTML
                    AvailableSpecializations.Add(SpecializationChoice)
                Next

                Return AvailableSpecializations

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

    End Class

    'this class stores a domain with the Domains collection.
    Public Class PsionicSpecialization

#Region "Member Variables"

        Public IsNew As Boolean
        Private _Character As Character
        Public SpecializationObj As Objects.ObjectData

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
        Public Sub CreateObject(ByVal SpecializationDef As Objects.ObjectData, ByVal ClassDef As Objects.ObjectData, ByVal CharacterLevel As Integer)
            Try
                SpecializationObj.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                SpecializationObj.Type = Objects.PsionicSpecializationType
                SpecializationObj.ParentGUID = _Character.PsionicSpecializations.PsionicSpecializationFolderKey
                SpecializationObj.FKElement("PsionicSpecialization", SpecializationDef.Name, "Name", SpecializationDef.ObjectGUID)
                SpecializationObj.FKElement("Class", ClassDef.Name, "Name", ClassDef.ObjectGUID)
                SpecializationObj.ElementAsInteger("LevelAcquired") = CharacterLevel
                SpecializationObj.HTMLGUID = SpecializationDef.ObjectGUID
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace
