Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Namespace Rules

#Region "Structures"

    'feature taken
    Public Structure Feature
        Public FeatureGuid As Objects.ObjectKey
        Public FeatureName As String
        Public LevelTaken As Integer
        Public ProgressiveFeature As Boolean
        Public Multiples As Boolean

        'Class at level chosen
        Public ClassName As String
        Public ClassGuid As Objects.ObjectKey

        'Source Object and type
        Public ActualSourceName As String
        Public ActualSourceGuid As Objects.ObjectKey
        Public FeatureSlotSource As String

        'Used for progressive features only - determines how this feature stacks/replaces other features
        Public StackingType As StackingType

        'For features chosen from a list
        Public ChoiceName As String
        Public ChoiceKey As Objects.ObjectKey

        'Extra functionality
        Public Disabled As Boolean
        Public IgnorePrerequisites As Boolean

        'create the object
        Public Function CreateObject(ByVal Character As Rules.Character) As Objects.ObjectData
            Dim FeatureGained As New Objects.ObjectData
            Dim FeatureDefinition As New Objects.ObjectData

            FeatureDefinition.Load(FeatureGuid)
            FeatureGained.Name = Me.FeatureName
            FeatureGained.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
            FeatureGained.ParentGUID = Character.CharacterObject.FirstChildOfType(Objects.FeatureFolderType).ObjectGUID
            FeatureGained.HTMLGUID = FeatureGuid
            FeatureGained.Type = Objects.FeatureGainedType
            FeatureGained.FKElement("Feature", FeatureName, "Name", FeatureGuid)
            FeatureGained.FKElement("Class", ClassName, "Name", ClassGuid)
            FeatureGained.Element("CharacterLevel") = LevelTaken.ToString
            FeatureGained.FKElement("FeatureType", FeatureDefinition.Element("FeatureType"), "FeatureType", FeatureGuid)
            FeatureGained.FKElement("Description", FeatureDefinition.Element("Description"), "Description", FeatureGuid)

            If Disabled Then FeatureGained.Element("Disabled") = "Yes" Else FeatureGained.Element("Disabled") = ""
            If IgnorePrerequisites Then FeatureGained.Element("IgnorePrerequisites") = "Yes" Else FeatureGained.Element("IgnorePrerequisites") = ""

            FeatureGained.FKElement("Source", ActualSourceName, "Name", ActualSourceGuid)
            If ChoiceKey.IsEmpty Then
                Select Case ActualSourceGuid.Database
                    Case XML.DBTypes.Classes
                        If ActualSourceGuid.Equals(References.AddedFeatureClass) Then
                            FeatureGained.Element("SourceType") = Rules.Features.FeatureSourceUserAdded
                        Else
                            FeatureGained.Element("SourceType") = Rules.Features.FeatureSourceClassFeature
                        End If
                    Case XML.DBTypes.Races
                        FeatureGained.Element("SourceType") = Rules.Features.FeatureSourceRacialFeature
                    Case XML.DBTypes.Domains
                        FeatureGained.Element("SourceType") = Rules.Features.FeatureSourceDomainFeature
                End Select
            Else
                FeatureGained.Element("SourceType") = Rules.Features.FeatureSourceChosenFeature
            End If
            FeatureGained.FKElement("ChoiceObject", ChoiceName, "Name", ChoiceKey)

            Return FeatureGained
        End Function

        'load the structure 
        Public Sub Load(ByVal FeatureObj As Objects.ObjectData)
            Try
                FeatureName = FeatureObj.Element("Feature")
                FeatureGuid = FeatureObj.GetFKGuid("Feature")
                LevelTaken = FeatureObj.ElementAsInteger("CharacterLevel")
                ClassName = FeatureObj.Element("Class")
                ClassGuid = FeatureObj.GetFKGuid("Class")
                ActualSourceGuid = FeatureObj.GetFKGuid("Source")
                ActualSourceName = FeatureObj.Element("Source")
                FeatureSlotSource = FeatureObj.Element("SourceType")

                'get the stacking type
                If ActualSourceGuid.Equals(RPGXplorer.References.AddedFeatureClass) Then
                    StackingType = StackingType.User
                Else
                    Select Case ActualSourceGuid.Database
                        Case XML.DBTypes.Classes
                            StackingType = StackingType.Class
                        Case XML.DBTypes.Races
                            StackingType = StackingType.Race
                        Case Else
                            StackingType = StackingType.Class
                    End Select
                End If

                ChoiceName = FeatureObj.Element("ChoiceObject")
                ChoiceKey = FeatureObj.GetFKGuid("ChoiceObject")

                If FeatureObj.Element("Disabled") = "Yes" Then Disabled = True Else Disabled = False
                If FeatureObj.Element("IgnorePrerequisites") = "Yes" Then IgnorePrerequisites = True Else IgnorePrerequisites = False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'equals
        Public Overloads Function Equals(ByVal obj As Object) As Boolean
            If TypeOf obj Is Feature Then
                Dim Feature As Feature = DirectCast(obj, Feature)
                If (Feature.FeatureGuid.Equals(Me.FeatureGuid)) And (Feature.ClassGuid.Equals(Me.ClassGuid)) And (Feature.LevelTaken = Me.LevelTaken) Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

    End Structure

    'calculated features for progressive features
    Public Structure CalculatedFeature
        'Link to the ChainData
        Public ChainData As Rules.FeatureChain

        'Class Guid for chains which allow multiples
        Public ClassGuid As Objects.ObjectKey

        'List of Chain positions at character levels
        Public PositionsAtLevel As ArrayList

        Public Function FeatureAtLevel(ByVal Level As Integer) As Objects.ObjectKey
            Dim Position As Integer

            If PositionsAtLevel.Count = 0 Then Return Nothing

            'Return last known position if level asked for is greater than largest recorded
            If Level >= PositionsAtLevel.Count Then
                Position = DirectCast(PositionsAtLevel(PositionsAtLevel.Count - 1), Integer)
                If Position > 0 Then Return ChainData.Item(Position).FeatureGuid
            End If

            'Return position at level requested
            Position = DirectCast(PositionsAtLevel(Level), Integer)
            If Position > 0 Then Return ChainData.Item(Position).FeatureGuid
        End Function

    End Structure

    'a link in a feature progression
    Public Class FeatureLink

        Public FeatureName As String
        Public FeatureGuid As Objects.ObjectKey

        Public Position As Integer
        Public ChainGUID As Objects.ObjectKey

        Public NextFeature As FeatureLink
        Public PreviousFeature As FeatureLink

        Public Sub New(ByVal Name As String, ByVal Key As Objects.ObjectKey)
            FeatureName = Name
            FeatureGuid = Key
        End Sub

    End Class

    'a collection of links which form one entire feature progression
    Public Class FeatureChain
        Public ChainGuid As Objects.ObjectKey
        Public FeatureLinks As ArrayList
        Public ChainType As FeatureChainTypes

        Public Sub New(ByVal Guid As Objects.ObjectKey, ByVal Type As FeatureChainTypes)
            ChainGuid = Guid
            ChainType = Type
            FeatureLinks = New ArrayList
        End Sub

        'Return the Link at the given position - If position is larger than the number of links return the final link
        Public Function Item(ByVal Position As Integer) As FeatureLink

            If Position >= 1 Then

                If Position <= FeatureLinks.Count Then
                    Return DirectCast(FeatureLinks(Position - 1), FeatureLink)
                Else
                    Return DirectCast(FeatureLinks(FeatureLinks.Count - 1), FeatureLink)
                End If

            End If

            Return Nothing

        End Function

    End Class

    'a collection of all defined feature progressions
    Public Class FeatureChainCollection

        'ObjectHashtable of all the individual links - indexed by FeatureGUID
        Private LinkLookUp As ObjectHashtable

        'ObjectHashtable of FeatureChains - indexed by ChainGUID
        Public Chains As ObjectHashtable

        Public Sub New(ByVal Links As ObjectHashtable, ByVal Chains As ObjectHashtable)
            Me.LinkLookUp = Links
            Me.Chains = Chains
        End Sub

        'Is the given Feature part of a chain
        Public Function Contains(ByVal FeatureGuid As Objects.ObjectKey) As Boolean
            Return LinkLookUp.ContainsKey(FeatureGuid)
        End Function

        'Get the link for the given feature
        Public Function Item(ByVal Featureguid As Objects.ObjectKey) As FeatureLink
            Return DirectCast(LinkLookUp(Featureguid), FeatureLink)
        End Function

        'Get the link at the given position in the specifed chain
        Public Function Item(ByVal ChainGUID As Objects.ObjectKey, ByVal Position As Integer) As FeatureLink
            Dim Chain As FeatureChain

            Chain = CType(Chains(ChainGUID), FeatureChain)
            If Chain Is Nothing Then Return Nothing

            Return Chain.Item(Position)

        End Function

        'Return the ChainGuid a feature belongs to
        Public Function ChainGuid(ByVal Featureguid As Objects.ObjectKey) As Objects.ObjectKey
            Return Item(Featureguid).ChainGUID
        End Function

        'Return the number of chains
        Public Function ChainCount() As Integer
            Return Chains.Count
        End Function

        'Get the Chain with the specified Guid
        Public Function Chain(ByVal ChainGuid As Objects.ObjectKey) As FeatureChain
            Return DirectCast(Chains(ChainGuid), FeatureChain)
        End Function
    End Class

    'for choose feature panel
    Public Structure FeatureSlot

        Public CharacterLevel As Integer

        Public FeatureName As String
        Public FeatureGuid As Objects.ObjectKey
        Public FeatureStatus As FeatureStatus

        Public ClassName As String
        Public ClassGuid As Objects.ObjectKey

        Public SlotType As FeatureSlotType
        Public SlotSource As StackingType

        'For Choose Feature Slots - During Character wizard
        'Public ChooseFeatureName As String
        Public ChooseFeatureObject As Objects.ObjectData

    End Structure

    'for choose feature panel
    Public Structure AvailableFeature
        Public FeatureName As String

        Public FeatureGuid As Objects.ObjectKey
        Public Status As FeatureStatus
        Public IgnoringPrereqs As Boolean
        Public HTML As String
    End Structure

#End Region

#Region "Enumerations"

    'Enum of the different type of progressions
    Public Enum FeatureChainTypes
        StackAcrossClasses
        HighestOverall_NoMultiples
        HighestPerClass_Multiples
    End Enum

    'defines how a stackable feature stacks across class, race, user.
    Public Enum StackingType
        Race
        [Class]
        User
    End Enum

    'Status Type for AvialableFeatures
    Public Enum FeatureStatus
        Available
        Taken
        Feat
        PrerequisitesNotMet
    End Enum

    'feat slot type
    Public Enum FeatureSlotType
        ChosenFeature
        UserAdded
        ExistingEdit
    End Enum

#End Region

    Public Class Features

#Region "Member Variables"

        Private _Character As Character
        Private _Features As Library
        Private _CalculatedFeatures As Library
        <CLSCompliant(False)> Public _FeatureProgressions As Rules.FeatureProgressions
        Private _ChooseFeatures As ChooseFeatures

#End Region

#Region "Properties"

        'character's features
        Public ReadOnly Property Features() As Library
            Get
                Return _Features
            End Get
        End Property

        'character's calculated features
        Public ReadOnly Property CalculatedFeatures() As Library
            Get
                Return _CalculatedFeatures
            End Get
        End Property

        'character's feature progressions
        Public ReadOnly Property FeatureProgressions() As FeatureProgressions
            Get
                Return _FeatureProgressions
            End Get
        End Property

        'for choose features panel
        Public ReadOnly Property ChooseFeatures() As ChooseFeatures
            Get
                Return _ChooseFeatures
            End Get
        End Property

#End Region

#Region "Constants"

        Public Const FeatureSourceUserAdded As String = "User Added Feature"
        Public Const FeatureSourceRacialFeature As String = "Racial Feature"
        Public Const FeatureSourceClassFeature As String = "Class Feature"
        Public Const FeatureSourceDomainFeature As String = "Domain Feature"
        Public Const FeatureSourceChosenFeature As String = "Chosen Feature"


#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            _Character = Character
            _Features = New Library()
            _CalculatedFeatures = New Library()
            _ChooseFeatures = New Rules.ChooseFeatures(Character)
            _FeatureProgressions = New FeatureProgressions(Caches.FeatureChains)
        End Sub

        'private constructor for clone
        Private Sub New()
        End Sub

        'load
        Public Sub Load()
            'TODO
        End Sub

        'save
        Public Sub Save()
            'TODO
        End Sub

        'add a feature to a character 
        Public Function AddFeature(ByVal FeatureKey As Objects.ObjectKey, ByVal ClassName As String, ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer, ByVal ActualSourceKey As Objects.ObjectKey, ByVal ActualSourceName As String, Optional ByVal Disabled As Boolean = False) As Feature
            Try
                Dim newFeature As Feature = CreateFeature(FeatureKey, ClassName, ClassKey, CharacterLevel, ActualSourceKey, ActualSourceName, Disabled)
                Me.AddFeature(newFeature)
                Return newFeature
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add a feature to a character 
        Public Function CreateFeature(ByVal FeatureKey As Objects.ObjectKey, ByVal ClassName As String, ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer, ByVal ActualSourceKey As Objects.ObjectKey, ByVal ActualSourceName As String, ByVal Disabled As Boolean) As Feature
            Try
                Dim FeatureDefinition As Objects.ObjectData = DirectCast(Caches.Features.Item(FeatureKey), Objects.ObjectData)

                'create the feature structure
                Dim Feature As New Feature
                Feature.FeatureName = FeatureDefinition.Name
                Feature.FeatureGuid = FeatureKey
                Feature.LevelTaken = CharacterLevel
                Feature.ClassName = ClassName
                Feature.ClassGuid = ClassKey
                Feature.ActualSourceGuid = ActualSourceKey
                Feature.ActualSourceName = ActualSourceName

                'get the stacking type
                If ActualSourceKey.Equals(RPGXplorer.References.AddedFeatureClass) Then
                    Feature.StackingType = StackingType.User
                Else
                    Select Case ActualSourceKey.Database
                        Case XML.DBTypes.Classes
                            Feature.StackingType = StackingType.Class
                        Case XML.DBTypes.Races
                            Feature.StackingType = StackingType.Race
                        Case Else
                            Feature.StackingType = StackingType.Class
                    End Select
                End If

                Feature.Disabled = Disabled

                Return Feature

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'add a feature to a character
        Public Sub AddFeature(ByVal Feature As Feature)
            Try
                Dim FeatureDefinition As Objects.ObjectData = DirectCast(Caches.Features.Item(Feature.FeatureGuid), Objects.ObjectData)
                Dim ProgressionsToUpdate As New ArrayList

                'check to see if this feature is in a chain i.e. progressive
                If Caches.FeatureChains.Contains(Feature.FeatureGuid) And Not Feature.Disabled Then

                    'add to progressions calculator
                    _FeatureProgressions.Add(Feature)
                    Feature.ProgressiveFeature = True

                    Dim ChainKey As Objects.ObjectKey = Caches.FeatureChains.ChainGuid(Feature.FeatureGuid)
                    If Not ProgressionsToUpdate.Contains(ChainKey) Then ProgressionsToUpdate.Add(ChainKey)
                Else
                    Feature.ProgressiveFeature = False
                End If

                'add to the library depending on the type
                If FeatureDefinition.Element("CanBeTakenMultipleTimes") = "Yes" Then
                    Feature.Multiples = True
                    _Features.AddItem(Feature.FeatureGuid, Feature, Feature.LevelTaken)
                Else
                    Feature.Multiples = False
                    _Features.AddItemWithSubkey(Feature.FeatureGuid, Feature.ClassGuid, Feature, Feature.LevelTaken)
                End If

                'update progressions
                For Each ChainKey As Objects.ObjectKey In ProgressionsToUpdate
                    UpdateCalculatedFeatures(ChainKey)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove a feature from a character
        Public Sub RemoveFeature(ByVal FeatureKey As Objects.ObjectKey, ByVal ClassKey As Objects.ObjectKey, ByVal LevelTaken As Integer)
            Try
                Dim Feature As Feature = Nothing

                For Each DataItem As Library.LibraryData In _Features.ItemData(FeatureKey)
                    Feature = DirectCast(DataItem.Data, Rules.Feature)

                    If (Feature.LevelTaken = LevelTaken) AndAlso (Feature.ClassGuid.Equals(ClassKey)) Then
                        If Feature.Multiples Then
                            _Features.RemoveItemObject(Feature.FeatureGuid, Feature)
                        Else
                            _Features.RemoveItem(Feature.FeatureGuid, Feature.ClassGuid)
                        End If
                        Exit For
                    End If
                Next

                'if it was part of a progression, remove and recalculate
                If (Feature.ProgressiveFeature = True) Then
                    _FeatureProgressions.Remove(Feature)
                    UpdateCalculatedFeatures(Caches.FeatureChains.ChainGuid(Feature.FeatureGuid))
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'remove features from a particular source
        Public Sub RemoveFeaturesFromSource(ByVal SourceKey As Objects.ObjectKey)
            Try
                For Each DataItem As Library.LibraryData In _Features.ItemData
                    Dim Feature As Feature = DirectCast(DataItem.Data, Feature)
                    If Feature.ActualSourceGuid.Equals(SourceKey) Then RemoveFeature(Feature.FeatureGuid, Feature.ClassGuid, Feature.LevelTaken)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'can this feature be taken?
        Public Function CanTakeFeature(ByVal FeatureKey As Objects.ObjectKey, ByVal ClassKey As Objects.ObjectKey) As Boolean
            Try
                Dim FeatureDefinition As Objects.ObjectData = DirectCast(Caches.Features.Item(FeatureKey), Objects.ObjectData)

                If (Not _Features.ContainsKey(FeatureKey)) OrElse (FeatureDefinition.Element("CanBeTakenMultipleTimes") = "Yes") OrElse ((Caches.FeatureChains.Contains(FeatureKey) AndAlso (Caches.FeatureChains.Chain(Caches.FeatureChains.ChainGuid(FeatureKey)).ChainType = Rules.FeatureChainTypes.StackAcrossClasses)) And (Not _Features.ContainsSubkey(FeatureKey, ClassKey))) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'does the character have this feature at or before the specified level?
        Public Function HasFeature(ByVal FeatureKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As Boolean
            Try
                If _Features.ContainsKey(FeatureKey, CharacterLevel) Then
                    Return True
                Else
                    'calculated features
                    Dim CalcFeature As CalculatedFeature

                    For Each Item As Library.LibraryData In _CalculatedFeatures.ItemData
                        CalcFeature = DirectCast(Item.Data, CalculatedFeature)

                        For Each FeatureLink As FeatureLink In CalcFeature.ChainData.FeatureLinks
                            If FeatureLink.FeatureGuid.Equals(FeatureKey) Then

                                'get level
                                If CharacterLevel >= (CalcFeature.PositionsAtLevel.Count) Then
                                    CharacterLevel = CalcFeature.PositionsAtLevel.Count - 1
                                End If

                                'check feature
                                If DirectCast(CalcFeature.PositionsAtLevel(CharacterLevel), Integer) >= FeatureLink.Position Then
                                    Return True
                                End If

                            End If
                        Next
                    Next
                End If

                Return False

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'update a calculated feature
        Private Sub UpdateCalculatedFeatures(ByVal ChainKey As Objects.ObjectKey)
            Try
                Dim Chain As Rules.FeatureChain = Caches.FeatureChains.Chain(ChainKey)

                'remove old calculated features
                _CalculatedFeatures.RemoveItemStack(ChainKey)

                'create and add revised calculated feature
                Select Case Chain.ChainType
                    Case Rules.FeatureChainTypes.StackAcrossClasses, Rules.FeatureChainTypes.HighestOverall_NoMultiples
                        Dim CalculatedFeature As CalculatedFeature = FeatureProgressions.CalculatedFeature(ChainKey, _Character.CharacterLevel)
                        CalculatedFeatures.AddItem(ChainKey, CalculatedFeature)

                    Case Rules.FeatureChainTypes.HighestPerClass_Multiples
                        Dim CalculatedFeaturesList As ArrayList = FeatureProgressions.CalculatedFeatures(ChainKey, _Character.CharacterLevel)
                        For Each CalculatedFeature As CalculatedFeature In CalculatedFeaturesList
                            CalculatedFeatures.AddItem(ChainKey, CalculatedFeature)
                        Next
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'are the librarys equal
        Public Overloads Function Equals(ByVal CompareFeatures As Features) As Boolean
            Try
                If _Features.Equals(CompareFeatures._Features) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'clone
        Public Function Clone(ByVal Character As Character) As Features
            Clone = New Features
            Clone._Character = Character
            Clone._Features = Me.Features.Clone
            Clone._CalculatedFeatures = Me.CalculatedFeatures.Clone
            Clone._FeatureProgressions = Me.FeatureProgressions.Clone
            Clone._ChooseFeatures = New Rules.ChooseFeatures(Character)
        End Function

    End Class

    'Collects a characters progressive features - Calculates a characters current progressive features
    Public Class FeatureProgressions

        'Structure to hold position data
        Public Structure PositionInformation
            Public LevelTaken As Integer
            Public Position As Integer
        End Structure

        'The information about the links and chains
        Public ChainData As FeatureChainCollection

        '3-Tier ObjectHashtable - ChainGuid - ClassGuid - FeatureGuid :- Gives the features Position
        Public ChainPositions As ObjectHashtable

        'Abstract Class guid for UserAdded Features
        Public UserAddedClassGuid As Objects.ObjectKey

        Public Sub New(ByVal ChainCollection As FeatureChainCollection)
            ChainData = ChainCollection
            ChainPositions = New ObjectHashtable(ChainData.ChainCount)
        End Sub

        'Clones the positions and returns a new instance of FeatureProgressions
        Public Function Clone() As FeatureProgressions
            Dim NewChainPositions As New ObjectHashtable(ChainPositions.Count)
            Dim NewClassPositions As ObjectHashtable
            Dim NewFeaturePositions As ObjectHashtable

            For Each ChainItem As DictionaryEntry In ChainPositions
                NewChainPositions.Add(New Objects.ObjectKey(CStr(ChainItem.Key)), New ObjectHashtable(DirectCast(ChainItem.Value, ObjectHashtable).Count))
                For Each ClassItem As DictionaryEntry In DirectCast(ChainItem.Value, ObjectHashtable)
                    NewClassPositions = DirectCast(NewChainPositions(New Objects.ObjectKey(CStr(ChainItem.Key))), ObjectHashtable)

                    NewClassPositions.Add(New Objects.ObjectKey(CStr(ClassItem.Key)), New ObjectHashtable(DirectCast(ClassItem.Value, ObjectHashtable).Count))
                    For Each FeatureItem As DictionaryEntry In DirectCast(ClassItem.Value, ObjectHashtable)
                        NewFeaturePositions = DirectCast(NewClassPositions(New Objects.ObjectKey(CStr(ClassItem.Key))), ObjectHashtable)
                        NewFeaturePositions.Add(New Objects.ObjectKey(CStr(FeatureItem.Key)), DirectCast(FeatureItem.Value, ArrayList).Clone)
                    Next
                Next
            Next

            Clone = New FeatureProgressions(ChainData)
            Clone.ChainPositions = NewChainPositions

        End Function

        'Include the given Feature in the working out feature progressions
        Public Sub Add(ByVal Feature As Feature)
            Dim LinkItem As FeatureLink
            Dim ClassPositions, FeaturePositions As ObjectHashtable
            Dim StackingGuid As Objects.ObjectKey
            Dim Position As PositionInformation
            Dim Positions As ArrayList

            If Not ChainData.Contains(Feature.FeatureGuid) Then Exit Sub

            LinkItem = ChainData.Item(Feature.FeatureGuid)
            Position.LevelTaken = Feature.LevelTaken
            Position.Position = LinkItem.Position

            'First Tier - Get the table contain the classes/race which have features in this chain
            If ChainPositions.ContainsKey(LinkItem.ChainGUID) Then
                ClassPositions = DirectCast(ChainPositions(LinkItem.ChainGUID), ObjectHashtable)
            Else
                ClassPositions = New ObjectHashtable()
                ChainPositions.Add(LinkItem.ChainGUID, ClassPositions)
            End If

            'Set StackingGuid to the correct key depending on the feature's source
            Select Case Feature.StackingType
                Case StackingType.Race
                    StackingGuid = Feature.ActualSourceGuid
                Case StackingType.Class
                    StackingGuid = Feature.ClassGuid
                Case StackingType.User
                    StackingGuid = References.AddedFeatureClass
            End Select

            'Second Tier - Get the table containing the features that the class/race has
            If ClassPositions.ContainsKey(StackingGuid) Then
                FeaturePositions = DirectCast(ClassPositions(StackingGuid), ObjectHashtable)
            Else
                FeaturePositions = New ObjectHashtable()
                ClassPositions.Add(StackingGuid, FeaturePositions)
            End If

            'Third Tier - Add the features chain position into the collection
            If FeaturePositions.ContainsKey(Feature.FeatureGuid) Then
                Positions = DirectCast(FeaturePositions(Feature.FeatureGuid), ArrayList)
                Positions.Add(Position)
            Else
                Positions = New ArrayList
                Positions.Add(Position)
                FeaturePositions.Add(Feature.FeatureGuid, Positions)
            End If

        End Sub

        'Remove the given feature from the calculation
        Public Sub Remove(ByVal feature As Feature)
            Dim LinkItem As FeatureLink
            Dim ClassPositions, FeaturePositions As ObjectHashtable
            Dim StackingGuid As Objects.ObjectKey
            Dim position As PositionInformation
            Dim Positions As ArrayList

            If Not ChainData.Contains(feature.FeatureGuid) Then Exit Sub

            LinkItem = ChainData.Item(feature.FeatureGuid)
            position.LevelTaken = feature.LevelTaken
            position.Position = LinkItem.Position

            'Tier 1
            If ChainPositions.ContainsKey(LinkItem.ChainGUID) Then
                ClassPositions = DirectCast(ChainPositions(LinkItem.ChainGUID), ObjectHashtable)
            Else
                MessageBox.Show("Chain Level:- Item not in the collection")
                Exit Sub
            End If

            'Tier 2
            'Set StackingGuid to the correct key depending on the feature's source
            Select Case feature.StackingType
                Case StackingType.Race
                    StackingGuid = feature.ActualSourceGuid
                Case StackingType.Class
                    StackingGuid = feature.ClassGuid
                Case StackingType.User
                    StackingGuid = References.AddedFeatureClass
            End Select

            If ClassPositions.ContainsKey(StackingGuid) Then
                FeaturePositions = DirectCast(ClassPositions(StackingGuid), ObjectHashtable)
            Else
                MessageBox.Show("Class Level:- Item not in the collection")
                Exit Sub
            End If

            'Tier 3
            If FeaturePositions.ContainsKey(feature.FeatureGuid) Then
                Positions = DirectCast(FeaturePositions(feature.FeatureGuid), ArrayList)
                If Positions.Contains(position) Then
                    Positions.Remove(position)
                Else
                    MessageBox.Show("Feature Level:- Item not in the collection")
                End If

                'Remove the tables that are no longer required
                If Positions.Count < 1 Then
                    FeaturePositions.Remove(feature.FeatureGuid)

                    If FeaturePositions.Count < 1 Then
                        ClassPositions.Remove(feature.ClassGuid)

                        If ClassPositions.Count < 1 Then
                            ChainPositions.Remove(LinkItem.ChainGUID)
                        End If

                    End If

                End If

            Else
                MessageBox.Show("Feature Level:- Item not in the collection")
            End If

        End Sub

        'Returns a CalcualtedFeature - for stacks and non multiples
        Public Function CalculatedFeature(ByVal ChainGuid As Objects.ObjectKey, ByVal MaxLevel As Integer) As CalculatedFeature
            Dim retCalculatedFeature As New CalculatedFeature
            Dim ClassPositionTable As ObjectHashtable
            Dim FeaturePositionTable As ObjectHashtable

            Dim LevelTotal(MaxLevel) As Integer
            Dim ClassTotal(MaxLevel) As Integer

            Dim Position As Rules.FeatureProgressions.PositionInformation

            Dim Chain As FeatureChain

            'Get the Chain
            Chain = ChainData.Chain(ChainGuid)

            If (Not Chain Is Nothing) And ChainPositions.ContainsKey(ChainGuid) Then

                'Get the Chain Type
                Select Case Chain.ChainType
                    Case FeatureChainTypes.StackAcrossClasses
                        ClassPositionTable = DirectCast(ChainPositions(ChainGuid), ObjectHashtable)
                        Array.Clear(LevelTotal, 0, MaxLevel + 1)
                        For Each FeaturePositionTable In ClassPositionTable.Values
                            Array.Clear(ClassTotal, 0, MaxLevel + 1)

                            For Each List As ArrayList In FeaturePositionTable.Values
                                For Each Position In List

                                    For i As Integer = Position.LevelTaken To MaxLevel
                                        If Position.Position >= ClassTotal(i) Then ClassTotal(i) = Position.Position
                                    Next
                                Next
                            Next

                            For i As Integer = 0 To MaxLevel
                                LevelTotal(i) = LevelTotal(i) + ClassTotal(i)
                            Next
                        Next

                        'Make the object
                        retCalculatedFeature.ChainData = ChainData.Chain(ChainGuid)
                        retCalculatedFeature.PositionsAtLevel = New ArrayList(LevelTotal)
                        Return retCalculatedFeature
                    Case FeatureChainTypes.HighestOverall_NoMultiples
                        ClassPositionTable = DirectCast(ChainPositions(ChainGuid), ObjectHashtable)
                        Array.Clear(LevelTotal, 0, MaxLevel + 1)

                        For Each FeaturePositionTable In ClassPositionTable.Values
                            Array.Clear(ClassTotal, 0, MaxLevel + 1)

                            For Each List As ArrayList In FeaturePositionTable.Values
                                For Each Position In List
                                    For i As Integer = Position.LevelTaken To MaxLevel
                                        If Position.Position >= ClassTotal(i) Then ClassTotal(i) = Position.Position
                                    Next
                                Next
                            Next

                            For i As Integer = 0 To MaxLevel
                                If LevelTotal(i) <= ClassTotal(i) Then LevelTotal(i) = ClassTotal(i)
                            Next
                        Next

                        'Make the object
                        retCalculatedFeature.ChainData = ChainData.Chain(ChainGuid)
                        retCalculatedFeature.PositionsAtLevel = New ArrayList(LevelTotal)

                        Return retCalculatedFeature
                End Select

            End If
            Return retCalculatedFeature
        End Function

        'For Chains which allow multiples
        Public Function CalculatedFeatures(ByVal ChainGuid As Objects.ObjectKey, ByVal MaxLevel As Integer) As ArrayList

            CalculatedFeatures = New ArrayList
            Dim ClassPositionTable As ObjectHashtable
            Dim FeaturePositionTable As ObjectHashtable

            'Hastable - indexed by classguid
            Dim OverallTotals As New ObjectHashtable
            Dim ClassTotal(MaxLevel, 0) As Integer
            Dim Position As Rules.FeatureProgressions.PositionInformation
            Dim Chain As FeatureChain

            'Get the Chain
            Chain = ChainData.Chain(ChainGuid)

            If (Not Chain Is Nothing) And ChainPositions.ContainsKey(ChainGuid) Then
                'Get the Chain Type
                Select Case Chain.ChainType
                    Case FeatureChainTypes.HighestPerClass_Multiples
                        Dim PermutationIndex As Integer

                        ClassPositionTable = DirectCast(ChainPositions(ChainGuid), ObjectHashtable)

                        For Each ClassTableItem As DictionaryEntry In ClassPositionTable
                            FeaturePositionTable = DirectCast(ClassTableItem.Value, ObjectHashtable)
                            ReDim ClassTotal(MaxLevel, 0)

                            For Each List As ArrayList In FeaturePositionTable.Values
                                PermutationIndex = 0
                                For Each Position In List
                                    If ClassTotal.GetUpperBound(1) < PermutationIndex Then
                                        ReDim Preserve ClassTotal(MaxLevel, PermutationIndex)
                                    End If

                                    For i As Integer = Position.LevelTaken To MaxLevel
                                        If Position.Position >= ClassTotal(i, PermutationIndex) Then
                                            ClassTotal(i, PermutationIndex) = Position.Position
                                        End If
                                    Next

                                    PermutationIndex += 1
                                Next

                            Next
                            OverallTotals.Add(New Objects.ObjectKey(CStr(ClassTableItem.Key)), ClassTotal)
                        Next

                        For Each DataEntry As DictionaryEntry In OverallTotals
                            Dim ClassGuid As Objects.ObjectKey = DirectCast(DataEntry.Key, Objects.ObjectKey)
                            Dim Values(,) As Integer = DirectCast(DataEntry.Value, Integer(,))

                            For PermutationIndex = 0 To Values.GetUpperBound(1)
                                Dim CalculatedFeature As Rules.CalculatedFeature
                                Dim Positions(Values.GetUpperBound(0)) As Integer

                                For i As Integer = 0 To Values.GetUpperBound(0)
                                    Positions(i) = Values(i, PermutationIndex)
                                Next

                                CalculatedFeature.ChainData = ChainData.Chain(ChainGuid)
                                CalculatedFeature.PositionsAtLevel = New ArrayList(Positions)
                                CalculatedFeature.ClassGuid = ClassGuid

                                CalculatedFeatures.Add(CalculatedFeature)
                            Next
                        Next

                        Return CalculatedFeatures
                End Select
            End If
        End Function

    End Class

    'Class to work out FeatureSlots and AvailableFeatures for the Choose Feature panel
    Public Class ChooseFeatures

        'The character to which this class applies
        Private Character As Rules.Character
        Private ChooseFeatureObjects As New Objects.ObjectDataCollection
        Private ChooseFeatureMemberObjects As New Objects.ObjectDataCollection

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Me.Character = Character
        End Sub

        'get all the choose feature slots for this pass of the wizard
        Public Function ChooseFeatureSlots() As ArrayList
            Try
                Dim Slots As New ArrayList

                'racial slots
                If Character.FirstNewLevel = 1 Then
                    Dim Level As Rules.Character.Level = Character.Levels(1)
                    Dim ClassInfo As Rules.CharacterClass = DirectCast(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)

                    'build the slot
                    For Each ChooseFeatureObject As Objects.ObjectData In Character.RaceObject.ChildrenOfType(Objects.ChooseFeatureType)
                        Dim NewSlot As New FeatureSlot
                        NewSlot.CharacterLevel = Level.CharacterLevel
                        NewSlot.ChooseFeatureObject = ChooseFeatureObject
                        NewSlot.ClassGuid = ClassInfo.ClassObj.ObjectGUID
                        NewSlot.ClassName = ClassInfo.ClassObj.Name
                        newslot.SlotSource = StackingType.Race
                        NewSlot.SlotType = FeatureSlotType.ChosenFeature
                        Slots.Add(NewSlot)
                    Next
                End If

                'class levels and domains
                For i As Integer = Character.FirstNewLevel To Character.CharacterLevel

                    'class level
                    Dim Level As Rules.Character.Level = Character.Levels(i)
                    Dim ClassInfo As Rules.CharacterClass = DirectCast(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)

                    'build the slot
                    For Each ChooseFeatureObject As Objects.ObjectData In ClassInfo.ClassLevel(Level.ClassLevel).ChildrenOfType(Objects.ChooseFeatureType)
                        Dim NewSlot As New FeatureSlot
                        NewSlot.CharacterLevel = Level.CharacterLevel
                        NewSlot.ChooseFeatureObject = ChooseFeatureObject
                        NewSlot.ClassGuid = ClassInfo.ClassObj.ObjectGUID
                        NewSlot.ClassName = ClassInfo.ClassObj.Name
                        newslot.SlotSource = StackingType.Class
                        NewSlot.SlotType = FeatureSlotType.ChosenFeature
                        Slots.Add(NewSlot)
                    Next

                    'domains
                    For Each Domain As Domain In Character.Domains.DomainsGainedAtLevel(i)
                        For Each ChooseFeatureObject As Objects.ObjectData In Domain.DomainObj.GetFKObject("Domain").ChildrenOfType(Objects.ChooseFeatureType)
                            Dim NewSlot As New FeatureSlot
                            NewSlot.CharacterLevel = Level.CharacterLevel
                            NewSlot.ChooseFeatureObject = ChooseFeatureObject
                            NewSlot.ClassGuid = ClassInfo.ClassObj.ObjectGUID
                            NewSlot.ClassName = ClassInfo.ClassObj.Name
                            newslot.SlotSource = StackingType.Class
                            NewSlot.SlotType = FeatureSlotType.ChosenFeature
                            Slots.Add(NewSlot)
                        Next
                    Next
                Next

                Return Slots

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Get the list of AvailableFeature objects for the given slot
        Public Function ChooseAvailableFeatures(ByVal Slot As FeatureSlot, Optional ByVal IncludeFeatOptions As Boolean = True, Optional ByVal PanelOverride As Boolean = False) As ArrayList

            Dim ChooseFeatureObject As Objects.ObjectData
            Dim NewFeature As AvailableFeature
            Dim FeatureList As New ArrayList
            Dim FeatureDefinition As Objects.ObjectData

            Select Case Slot.SlotType

                Case FeatureSlotType.ChosenFeature

                    ChooseFeatureObject = Slot.ChooseFeatureObject

                    'Make the New Feature
                    For Each Child As Objects.ObjectData In ChooseFeatureObject.Children
                        NewFeature.FeatureGuid = Child.GetFKGuid("Feature")
                        NewFeature.FeatureName = Child.Element("Feature")

                        FeatureDefinition = DirectCast(Caches.Features.Item(NewFeature.FeatureGuid), Objects.ObjectData)
                        NewFeature.HTML = FeatureDefinition.HTML
                        NewFeature.Status = GetAvailableFeatureStatus(FeatureDefinition, Slot)
                        NewFeature.IgnoringPrereqs = False

                        If NewFeature.Status = FeatureStatus.PrerequisitesNotMet Then
                            If ChooseFeatureObject.Element("OverridePrerequisites") = "Yes" OrElse PanelOverride = True Then
                                NewFeature.Status = FeatureStatus.Available
                                NewFeature.IgnoringPrereqs = True
                            End If
                        End If
0:
                        FeatureList.Add(NewFeature)
                    Next

                    If IncludeFeatOptions Then
                        If ChooseFeatureObject.Element("BonusFeatOption") = "Yes" Then
                            NewFeature.FeatureGuid = Objects.ObjectKey.Empty
                            NewFeature.FeatureName = "Bonus Feat"
                            NewFeature.HTML = ""
                            NewFeature.Status = FeatureStatus.Feat
                            FeatureList.Add(NewFeature)
                        End If
                    End If

                Case FeatureSlotType.UserAdded, FeatureSlotType.ExistingEdit
                    For Each FeatureDefinition In Caches.Features.Values
                        NewFeature.FeatureGuid = FeatureDefinition.ObjectGUID
                        NewFeature.FeatureName = FeatureDefinition.Name
                        NewFeature.HTML = FeatureDefinition.HTML
                        NewFeature.IgnoringPrereqs = False
                        NewFeature.Status = GetAvailableFeatureStatus(FeatureDefinition, Slot)
                        If NewFeature.Status = FeatureStatus.PrerequisitesNotMet Then
                            If PanelOverride = True Then
                                NewFeature.Status = FeatureStatus.Available
                                NewFeature.IgnoringPrereqs = True
                            End If
                        End If

                        FeatureList.Add(NewFeature)
                    Next

            End Select

            Return FeatureList

        End Function

        'checks the prerequisites on a feature
        Public Function GetAvailableFeatureStatus(ByVal Feature As Objects.ObjectData, ByVal Slot As Rules.FeatureSlot, Optional ByVal IgnorePrereq As Boolean = False) As FeatureStatus
            Try
                Dim PrerequisitesMet As Boolean
                Dim CharacterLevel As Integer = Slot.CharacterLevel

                'do they have the feature already?
                If Not Character.Features.CanTakeFeature(Feature.ObjectGUID, Slot.ClassGuid) Then
                    Return FeatureStatus.Taken
                End If

                'check prerequisites
                PrerequisitesMet = True

                If Not IgnorePrereq Then
                    For Each Prerequisite As Objects.ObjectData In Caches.FeaturePrerequisites.ChildrenFast(Feature.ObjectGUID)
                        If Not Character.Prerequisites.HasPrerequisite(Prerequisite, CharacterLevel, Caches.FeaturePrerequisiteChildren.ChildrenFast(Prerequisite.ObjectGUID)) Then
                            PrerequisitesMet = False
                            Exit For
                        End If
                    Next
                End If

                'determine feature slot status
                If PrerequisitesMet Then
                    Return FeatureStatus.Available
                Else
                    Return FeatureStatus.PrerequisitesNotMet
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace

