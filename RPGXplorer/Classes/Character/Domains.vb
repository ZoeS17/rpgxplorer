Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

#Region "Structures"

    'domain slot for the bonus domain panel
    Public Structure DomainSlot
        Public CharacterLevel As Integer
        Public SlotType As DomainSlotType
        Public DomainTakenKey As Objects.ObjectKey
        Public DomainTakenName As String
        Public DomainChoices As ArrayList

        Public ReadOnly Property SlotTypeName() As String
            Get
                Select Case SlotType
                    Case DomainSlotType.BonusDomain
                        Return "Bonus Domain"
                    Case DomainSlotType.ChooseBonusDomain
                        Return "Choose Bonus Domain"
                    Case DomainSlotType.SpecificBonusDomain
                        Return "Specific Bonus Domain"
                End Select
                Return ""
            End Get
        End Property

    End Structure

    'domain choice 
    Public Structure DomainChoice
        Public DomainKey As Objects.ObjectKey
        Public DomainName As String
        Public AlreadyTaken As Boolean
        Public HTML As String
    End Structure

#End Region

#Region "Enumerations"

    'domain slot type
    Public Enum DomainSlotType
        BonusDomain
        ChooseBonusDomain
        SpecificBonusDomain
    End Enum

#End Region

    'this class handles a collection of domains attached to a character
    Public Class Domains

#Region "Member Variables"

        Private _Domains As Library
        Private _Character As Rules.Character
        Private _Deleted As New ArrayList
        Private _DomainFolderKey As Objects.ObjectKey

#End Region

#Region "Properties"

        'default item property
        Default Public ReadOnly Property Item(ByVal ClassKey As Objects.ObjectKey, ByVal DomainKey As Objects.ObjectKey) As Domain
            Get
                Return DirectCast(_Domains.ItemData(ClassKey, DomainKey).Data, Domain)
            End Get
        End Property

        'get the domain folder key
        Public ReadOnly Property DomainFolderKey() As Objects.ObjectKey
            Get
                Return _DomainFolderKey
            End Get
        End Property

        'get the character
        Public ReadOnly Property Character() As Rules.Character
            Get
                Return _Character
            End Get
        End Property

        Public ReadOnly Property Domains() As Library
            Get
                Return _Domains
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Character)
            Try
                _Character = Character
                _Domains = New Library()
                _Deleted = New ArrayList

                'get the domain folder
                Dim DomainFolder As Objects.ObjectData = _Character.MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType)
                If DomainFolder.ObjectGUID.IsNotEmpty Then
                    _DomainFolderKey = DomainFolder.ObjectGUID
                Else
                    'create a new folder key
                    _DomainFolderKey = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'private constructor for clone
        Private Sub New(ByVal Character As Character, ByVal Domains As Library, ByVal Deleted As ArrayList, ByVal DomainFolderKey As Objects.ObjectKey)
            Try
                _Character = Character
                _Domains = Domains
                _Deleted = Deleted
                _DomainFolderKey = DomainFolderKey
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load
        Public Sub Load()
            Try
                _Domains.Clear()
                _Deleted.Clear()

                'load any domain objects on this character 
                For Each DomainObj As Objects.ObjectData In _Character.CharacterObject.FirstChildOfType(Objects.MagicFolderType).FirstChildOfType(Objects.DomainAndSchoolsFolderType).ChildrenOfType(Objects.DomainType)
                    Dim Domain As New Domain(_Character)
                    Domain.IsNew = False
                    Domain.DomainObj = DomainObj
                    _Domains.AddItemWithSubkey(Domain.DomainObj.GetFKGuid("Class"), Domain.DomainObj.GetFKGuid("Domain"), Domain, DomainObj.ElementAsInteger("LevelAcquired"))
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save
        Public Sub Save()
            Try

                Dim CasterClasses As Boolean

                'check if I need saved
                If Character.IsRacialCaster Then
                    CasterClasses = True
                End If

                If Not CasterClasses Then
                    For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                        If Character.CharacterClasses(ClassKey).ClassObj.Element("CasterAbility") = "Yes" OrElse (Character.CharacterClasses(ClassKey).ClassObj.Element("CasterAbility") = "Prestige Advancement" And True) Then
                            CasterClasses = True
                            Exit For
                        End If
                    Next
                End If

                'delete any removed objects
                For Each DomainObj As Objects.ObjectData In _Deleted
                    DomainObj.Delete()
                Next
                _Deleted.Clear()

                If _Domains.ItemData.Count > 0 Or CasterClasses Then

                    'make sure the magic folder is saved
                    _Character.MagicFolderSave()

                    'make sure our domain folder has been created
                    If _Character.MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType).IsEmpty Then
                        Dim DomainsSchoolsFolder As New Objects.ObjectData
                        DomainsSchoolsFolder.Name = "Domains and Schools"
                        DomainsSchoolsFolder.ObjectGUID = Me.DomainFolderKey
                        DomainsSchoolsFolder.Type = Objects.DomainAndSchoolsFolderType
                        DomainsSchoolsFolder.ParentGUID = _Character.MagicFolder.ObjectGUID
                        DomainsSchoolsFolder.Save()
                    End If

                    'save all remaining objects
                    For Each DataItem As Library.LibraryData In _Domains.ItemData
                        Dim Domain As Domain = DirectCast(DataItem.Data, Rules.Domain)
                        Domain.DomainObj.Save()
                    Next

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'clone
        Public Function Clone(ByRef CloneCharacter As Character) As Domains
            Try
                Clone = New Domains(CloneCharacter, Me._Domains.Clone, DirectCast(Me._Deleted.Clone, ArrayList), Me._DomainFolderKey)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'count of domains
        Public Function Count() As Integer
            Try
                Return _Domains.ItemData.Count
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add a to the character
        Public Sub AddDomain(ByVal DomainDef As Objects.ObjectData, ByVal ClassDef As Objects.ObjectData, ByVal CharacterLevel As Integer, Optional ByVal SaveObjects As Boolean = False)
            Try
                Dim Domain As New Domain(_Character)
                Domain.CreateObject(DomainDef, ClassDef, CharacterLevel)
                Domain.IsNew = True
                AddDomain(Domain, CharacterLevel, SaveObjects)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'add a domain to the character
        Private Sub AddDomain(ByVal Domain As Domain, ByVal CharacterLevel As Integer, ByVal SaveObjects As Boolean)
            Try
                'add to domains
                _Domains.AddItemWithSubkey(Domain.DomainObj.GetFKGuid("Class"), Domain.DomainObj.GetFKGuid("Domain"), Domain, CharacterLevel)

                'if this is outside the wizard - analyse and add the child objects
                If SaveObjects Then
                    SaveChildComponents(Domain)
                Else
                    'add the features to the character
                    AnalyseFeatures(Domain)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'analyse a domain for its features
        Private Sub AnalyseFeatures(ByVal Domain As Domain)
            Try
                Dim DomainDef As Objects.ObjectData = Domain.DomainObj.GetFKObject("Domain")

                'get features 
                For Each Feature As Objects.ObjectData In DomainDef.ChildrenOfType(Objects.FeatureType)
                    If _Character.Features.CanTakeFeature(Feature.GetFKGuid("Feature"), Domain.DomainObj.GetFKGuid("Class")) Then
                        _Character.Features.AddFeature(Feature.GetFKGuid("Feature"), Domain.DomainObj.Element("Class"), Domain.DomainObj.GetFKGuid("Class"), Domain.DomainObj.ElementAsInteger("LevelAcquired"), Domain.DomainObj.ObjectGUID, Domain.DomainObj.Name)
                    End If
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'analyse a domin for bonus feats - adds them and their child components
        Public Function AnalyseFeats(ByVal Domain As Domain) As ArrayList
            Try
                Dim ReturnList As New ArrayList
                Dim DomainDef As Objects.ObjectData = Domain.DomainObj.GetFKObject("Domain")

                'get feats
                For Each SpecificBonusFeat As Objects.ObjectData In DomainDef.ChildrenOfType(Objects.SpecificBonusFeatType)
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
                        NewFeat.LevelTaken = Domain.DomainObj.ElementAsInteger("LevelAcquired")
                        NewFeat.FocusGuid = Focus.ObjectGUID
                        NewFeat.FeatSlotSource = Rules.AvailableFeats.SpecificBonusFeat
                        NewFeat.SourceName = DomainDef.Name
                        NewFeat.SourceGuid = Domain.DomainObj.ObjectGUID

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
        Private Sub SaveChildComponents(ByVal Domain As Domain)
            Try
                Dim DomainDef As Objects.ObjectData = Domain.DomainObj.GetFKObject("Domain")

                'get features 
                For Each Feature As Objects.ObjectData In DomainDef.ChildrenOfType(Objects.FeatureType)
                    If _Character.Features.CanTakeFeature(Feature.GetFKGuid("Feature"), Domain.DomainObj.GetFKGuid("Class")) Then
                        Dim NewFeature As Rules.Feature
                        NewFeature = _Character.Features.CreateFeature(Feature.GetFKGuid("Feature"), Domain.DomainObj.Element("Class"), Domain.DomainObj.GetFKGuid("Class"), Domain.DomainObj.ElementAsInteger("LevelAcquired"), Domain.DomainObj.ObjectGUID, Domain.DomainObj.Name, False)

                        Dim FeatureTaken As Objects.ObjectData
                        FeatureTaken = NewFeature.CreateObject(_Character)
                        FeatureTaken.Save()
                    End If
                Next

                'get feats - tidy up with a CreateFeat later
                For Each SpecificBonusFeat As Objects.ObjectData In DomainDef.ChildrenOfType(Objects.SpecificBonusFeatType)
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
                        NewFeat.LevelTaken = Domain.DomainObj.ElementAsInteger("LevelAcquired")
                        NewFeat.FocusGuid = Focus.ObjectGUID
                        NewFeat.FeatSlotSource = Rules.AvailableFeats.SpecificBonusFeat
                        NewFeat.SourceName = DomainDef.Name
                        NewFeat.SourceGuid = Domain.DomainObj.ObjectGUID
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
        Public Sub RemoveDomain(ByVal ClassKey As Objects.ObjectKey, ByVal DomainKey As Objects.ObjectKey, Optional ByVal DeleteObjects As Boolean = False)
            Try
                Dim Domain As Domain = DirectCast(_Domains.ItemData(ClassKey, DomainKey).Data, Domain)
                If Not Domain.IsNew Then _Deleted.Add(Domain)
                _Domains.RemoveItem(ClassKey, DomainKey)

                If DeleteObjects Then
                    DeleteChildComponents(Domain)
                Else
                    DeanalyseFeatures(Domain)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove any features that have been added to the character form this domain
        Private Sub DeanalyseFeatures(ByVal Domain As Domain)
            Try
                'remove features
                For Each DataItem As Library.LibraryData In Character.Features.Features.ItemData
                    Dim Feature As Feature = DirectCast(DataItem.Data, Feature)
                    If Feature.ActualSourceGuid.Equals(Domain.DomainObj.ObjectGUID) AndAlso Feature.ClassGuid.Equals(Domain.DomainObj.GetFKGuid("Class")) AndAlso Feature.LevelTaken = Domain.DomainObj.ElementAsInteger("LevelAcquired") Then
                        Character.Features.RemoveFeature(Feature.FeatureGuid, Feature.ClassGuid, Feature.LevelTaken)
                    End If
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove any components that have been added to the character for this domain
        Private Sub DeleteChildComponents(ByVal Domain As Domain)
            Try
                Dim CurrentFeatures, CurrentFeats As Objects.ObjectDataCollection

                CurrentFeats = _Character.CharacterObject.FirstChildOfType(Objects.FeatFolderType).Children
                CurrentFeatures = _Character.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).Children

                'remove features
                For Each DataItem As Library.LibraryData In Character.Features.Features.ItemData
                    Dim Feature As Feature = DirectCast(DataItem.Data, Feature)
                    If Feature.ActualSourceGuid.Equals(Domain.DomainObj.ObjectGUID) AndAlso Feature.ClassGuid.Equals(Domain.DomainObj.GetFKGuid("Class")) AndAlso Feature.LevelTaken = Domain.DomainObj.ElementAsInteger("LevelAcquired") Then
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
                    If Feat.SourceGuid.Equals(Domain.DomainObj.ObjectGUID) AndAlso Feat.LevelTaken = Domain.DomainObj.ElementAsInteger("LevelAcquired") Then
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

        'does the character have this domain for any class?
        Public Function HasDomain(ByVal DomainKey As Objects.ObjectKey, Optional ByVal CharacterLevel As Integer = 1000) As Boolean
            Try
                For Each ClassKey As Objects.ObjectKey In _Domains.Keys
                    If _Domains.ContainsSubkey(ClassKey, DomainKey, CharacterLevel) Then Return True
                Next

                Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'does the character have this domain for this class?
        Public Function HasDomain(ByVal ClassKey As Objects.ObjectKey, ByVal DomainKey As Objects.ObjectKey, Optional ByVal CharacterLevel As Integer = 1000) As Boolean
            Try
                If _Domains.ContainsSubkey(ClassKey, DomainKey, CharacterLevel) Then Return True Else Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get deity and/or alignment compatible domains
        Public Function CompatibleDomains(ByVal ClassKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                Dim Domains As New Objects.ObjectDataCollection
                Dim ClassInfo As Rules.CharacterClass = _Character.CharacterClasses(ClassKey)

                If ClassInfo.CasterInfo.RestrictDomainSelection And (Not _Character.DeityObject.IsEmpty) Then
                    Dim DeityChildren As Objects.ObjectDataCollection = _Character.DeityObject.ChildrenOfType(Objects.DeityDomainChildType)

                    For Each DeityDomain As Objects.ObjectData In DeityChildren
                        Domains.Add(DeityDomain.GetFKObject("Domain"))
                    Next
                Else
                    Domains = Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.DomainDefinitionType)
                End If

                'remove incompatible alignment domains
                Dim Incompatible As New Objects.ObjectDataCollection

                For Each Domain As Objects.ObjectData In Domains
                    If Domain.Element("Alignment") <> "" Then
                        If _Character.CharacterObject.Element("Alignment").IndexOf(Domain.Element("Alignment")) = -1 Then Incompatible.Add(Domain)
                    End If
                Next

                Domains.RemoveList(Incompatible)

                Return Domains

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets compatible domains but excludes any that have already been taken for this class
        Public Function AvailableDomains(ByVal ClassKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                Dim Compatible As Objects.ObjectDataCollection = CompatibleDomains(ClassKey)
                Dim Available As New Objects.ObjectDataCollection

                For Each Domain As Objects.ObjectData In Compatible
                    If Not HasDomain(ClassKey, Domain.ObjectGUID) Then Available.Add(Domain)
                Next

                Return Available

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the domains associated with the specified class
        Public Function ClassDomains(ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As ArrayList
            Try
                Dim List As New ArrayList

                If _Domains.ContainsKey(ClassKey) Then
                    For Each DataItem As Library.LibraryData In _Domains.ItemData(ClassKey, CharacterLevel)
                        List.Add(DirectCast(DataItem.Data, Domain))
                    Next
                End If

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the domains gained at a specific level
        Public Function DomainsGainedAtLevel(ByVal CharacterLevel As Integer) As ArrayList
            Try
                Dim List As New ArrayList

                For Each LibraryData As Library.LibraryData In _Domains.ItemData()
                    Dim Domain As Domain = DirectCast(LibraryData.Data, Domain)
                    If LibraryData.LevelAcquired = CharacterLevel Then
                        List.Add(Domain)
                    End If
                Next

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the domains gained on or after the specifed level
        Public Function DomainsGainedSinceLevel(ByVal CharacterLevel As Integer) As ArrayList
            Try
                Dim List As New ArrayList

                For Each LibraryData As Library.LibraryData In _Domains.ItemData()
                    Dim Domain As Domain = DirectCast(LibraryData.Data, Domain)
                    If LibraryData.LevelAcquired >= CharacterLevel Then
                        List.Add(Domain)
                    End If
                Next

                Return List

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'are the librarys equal
        Public Overloads Function Equals(ByVal CompareDomian As Domains) As Boolean
            Try
                If _Domains.Equals(CompareDomian._Domains) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#Region "Choose Bonus Domains"

        'get the available bonus domain slots for this pass of the wizard
        Public Function BonusDomainSlots() As ArrayList
            Try
                Dim Slots As New ArrayList

                'go through all the levels gained
                For i As Integer = _Character.FirstNewLevel To _Character.CharacterLevel

                    'get each class level and find any bonus domains 
                    Dim ClassLevel As New Objects.ObjectData
                    ClassLevel.Load(_Character.Levels(i).ClassLevelGuid)

                    Dim NewSlot As New DomainSlot
                    NewSlot.CharacterLevel = i

                    'bonus domains
                    For Each BonusDomain As Objects.ObjectData In ClassLevel.ChildrenOfType(Objects.BonusDomainType)
                        NewSlot.SlotType = DomainSlotType.BonusDomain
                        Slots.Add(NewSlot)
                    Next

                    'specific or choose bonus domain
                    For Each SpecificOrChooseBonusDomain As Objects.ObjectData In ClassLevel.ChildrenOfType(Objects.BonusDomainChoiceOrSpecificType)
                        If SpecificOrChooseBonusDomain.Element("ChoiceType") = "Specific" Then
                            NewSlot.SlotType = DomainSlotType.SpecificBonusDomain
                            NewSlot.DomainTakenKey = SpecificOrChooseBonusDomain.GetFKGuid("Specific")
                            NewSlot.DomainTakenName = SpecificOrChooseBonusDomain.Element("Specific")
                        Else
                            NewSlot.SlotType = DomainSlotType.ChooseBonusDomain
                            NewSlot.DomainChoices = New ArrayList

                            For n As Integer = 1 To SpecificOrChooseBonusDomain.ElementAsInteger("ChoiceCount")
                                NewSlot.DomainChoices.Add(SpecificOrChooseBonusDomain.GetFKGuid("Choice" & n.ToString))
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
        Public Function AvailableDomainChoices(ByVal Slot As DomainSlot) As ArrayList
            Try
                Dim Domains As New Objects.ObjectDataCollection

                Select Case Slot.SlotType
                    Case DomainSlotType.BonusDomain
                        'get deity or alignment compatible domains                        
                        Domains = CompatibleDomains(_Character.Levels(Slot.CharacterLevel).ClassGuid)

                    Case DomainSlotType.ChooseBonusDomain
                        'get domain choices from slot
                        Domains = New Objects.ObjectDataCollection
                        For Each DomainKey As Objects.ObjectKey In Slot.DomainChoices
                            Dim DomainDefinition As New Objects.ObjectData

                            DomainDefinition.Load(DomainKey)
                            Domains.Add(DomainDefinition)
                        Next

                    Case DomainSlotType.SpecificBonusDomain
                        'return empty list
                        Return New ArrayList

                End Select

                'construct domain choices
                Dim AvailableDomains As New ArrayList

                For Each Domain As Objects.ObjectData In Domains
                    Dim DomainChoice As DomainChoice
                    DomainChoice.DomainName = Domain.Name
                    DomainChoice.DomainKey = Domain.ObjectGUID
                    DomainChoice.AlreadyTaken = HasDomain(_Character.Levels(Slot.CharacterLevel).ClassGuid, Domain.ObjectGUID)
                    DomainChoice.HTML = Domain.HTML
                    AvailableDomains.Add(DomainChoice)
                Next

                Return AvailableDomains

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

    End Class

    'this class stores a domain with the Domains collection.
    Public Class Domain

#Region "Member Variables"

        Public IsNew As Boolean
        Private _Character As Character
        Public DomainObj As Objects.ObjectData

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
        Public Sub CreateObject(ByVal DomainDef As Objects.ObjectData, ByVal ClassDef As Objects.ObjectData, ByVal CharacterLevel As Integer)
            Try
                DomainObj.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                DomainObj.Type = Objects.DomainType
                DomainObj.ParentGUID = _Character.Domains.DomainFolderKey
                DomainObj.FKElement("Domain", DomainDef.Name, "Name", DomainDef.ObjectGUID)
                DomainObj.FKElement("Class", ClassDef.Name, "Name", ClassDef.ObjectGUID)
                DomainObj.ElementAsInteger("LevelAcquired") = CharacterLevel
                DomainObj.HTMLGUID = DomainDef.ObjectGUID
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace
