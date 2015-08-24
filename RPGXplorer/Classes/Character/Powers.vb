Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Namespace Rules

#Region "Structures"

    'Power structure
    Public Structure Power
        Public PowerGuid As Objects.ObjectKey
        Public PowerName As String

        Public ClassGuid As Objects.ObjectKey
        Public ClassName As String

        Public SourceKey As Objects.ObjectKey
        Public SourceName As String

        Public PowerLevel As Integer

        'internal level holders
        Private _LevelTaken() As Integer
        Private _LevelReplaced() As Integer

        Public IsNew As Boolean
        Public AutoObtained As Boolean
        Public PowerObject As Objects.ObjectData

        'returns the last level taken
        Public ReadOnly Property LevelTaken() As Integer
            Get
                If _LevelTaken.GetUpperBound(0) < 0 Then Return 0
                Return _LevelTaken(_LevelTaken.GetUpperBound(0))
            End Get
        End Property

        'returns the last level replaced - 0 if it has not been replaced (i.e still on the character)
        Public ReadOnly Property LevelReplaced() As Integer
            Get
                If _LevelTaken.GetUpperBound(0) < 0 Then Return 0
                Return _LevelReplaced(_LevelTaken.GetUpperBound(0))
            End Get
        End Property

        'returns the first level replaced after the given level - otherwise 0
        Public ReadOnly Property LevelReplaced(ByVal LevelTaken As Integer) As Integer
            Get
                If _LevelTaken.GetUpperBound(0) < 0 Then Return 0

                For i As Integer = 0 To _LevelTaken.GetUpperBound(0)
                    If _LevelTaken(i) = LevelTaken Then
                        Return _LevelReplaced(i)
                    End If
                Next
            End Get
        End Property

        'returns the next level taken after the specified level - 0 if not found
        Public Function NextLevelTaken(ByVal Level As Integer) As Integer
            For i As Integer = 0 To _LevelTaken.GetUpperBound(0)
                If _LevelTaken(i) >= Level Then
                    Return _LevelTaken(i)
                End If
            Next
        End Function

        'sets the last level taken to the given value
        Public Sub TakeAtLevel(ByVal Value As Integer)

            'If this is the first level added, initialise the arrays
            If _LevelTaken Is Nothing Then
                ReDim _LevelTaken(0)
                ReDim _LevelReplaced(0)
                _LevelTaken(0) = Value
            Else
                Dim OldBound As Integer = _LevelTaken.GetUpperBound(0)
                ReDim Preserve _LevelTaken(OldBound + 1)
                ReDim Preserve _LevelReplaced(OldBound + 1)
                _LevelTaken(OldBound + 1) = Value
            End If
        End Sub

        'removes both the level taken and level replaced information at the given level
        Public Sub RemoveTakeAtLevel(ByVal Value As Integer)
            Dim CurrentIndex, NewSize As Integer

            'Make a new set of arrays one size smaller
            CurrentIndex = 0
            NewSize = _LevelTaken.GetUpperBound(0) - 1

            Dim NewLevelTaken(NewSize) As Integer
            Dim NewLevelReplaced(NewSize) As Integer

            'If we have removed the last level picked just exit
            If NewSize < 0 Then
                _LevelTaken = NewLevelTaken
                _LevelReplaced = NewLevelReplaced
                Exit Sub
            End If

            'Otherwise add in any other level ranges
            For i As Integer = 0 To _LevelTaken.GetUpperBound(0)
                If _LevelTaken(i) <> Value Then
                    NewLevelTaken(CurrentIndex) = _LevelTaken(i)
                    NewLevelReplaced(CurrentIndex) = _LevelReplaced(i)
                    CurrentIndex += 1
                End If
            Next
            _LevelTaken = NewLevelTaken
            _LevelReplaced = NewLevelReplaced
        End Sub

        'sets the last level replaced to the given value
        Public Sub ReplaceAtLevel(ByVal level As Integer)
            _LevelReplaced(_LevelReplaced.GetUpperBound(0)) = level
        End Sub

        'removes the level replaced information at the given level
        Public Sub RemoveReplaceAtLevel(ByVal Value As Integer)
            For i As Integer = 0 To _LevelReplaced.GetUpperBound(0)
                If _LevelReplaced(i) = Value Then
                    _LevelReplaced(i) = 0

                    ReDim Preserve _LevelTaken(i)
                    ReDim Preserve _LevelReplaced(i)

                    Exit For
                End If
            Next
        End Sub

        'true if the character can has this Power at the given level
        Public Function CastableAtLevel(ByVal level As Integer) As Boolean
            For i As Integer = 0 To _LevelTaken.GetUpperBound(0)

                If level >= _LevelTaken(i) Then
                    If (_LevelReplaced(i) = 0) Or (level < _LevelReplaced(i)) Then
                        Return True
                    End If
                End If
            Next
            Return False
        End Function

        'true if the Power has been replaced on or before the given level
        Public Function AvailableAtLevel(ByVal level As Integer) As Boolean

            If _LevelReplaced.GetUpperBound(0) < 0 Then Return True

            Dim LastLevelReplaced As Integer = _LevelReplaced(_LevelReplaced.GetUpperBound(0))

            If (LastLevelReplaced > 0) AndAlso level >= LastLevelReplaced Then
                Return True
            Else
                Return False
            End If
        End Function

        'true if this Power was last picked before the given level and has not yet been replaced
        Public Function CanBeReplaced(ByVal level As Integer) As Boolean
            Dim UpperBoundIndex As Integer = _LevelTaken.GetUpperBound(0)

            If UpperBoundIndex < 0 Then Return False

            If (_LevelTaken(UpperBoundIndex) < level) And _LevelReplaced(UpperBoundIndex) = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'turn this structure into an ObjectData
        Public Function CreateObject(ByVal Character As Rules.Character, ByVal ParentFolderGuid As Objects.ObjectKey) As Objects.ObjectData

            Dim PowerLearned As New Objects.ObjectData
            Dim UpperBoundIndex As Integer

            UpperBoundIndex = _LevelTaken.GetUpperBound(0)

            'Make sure we need to make an object for this Power first
            If (UpperBoundIndex > -1) AndAlso (_LevelReplaced(UpperBoundIndex) = 0) Then
                PowerLearned.Name = Me.PowerName
                PowerLearned.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                PowerLearned.Type = Objects.PowerLearnedType
                PowerLearned.ParentGUID = ParentFolderGuid
                PowerLearned.HTMLGUID = PowerGuid

                PowerLearned.FKElement("Class", ClassName, "Name", ClassGuid)
                PowerLearned.FKElement("Power", PowerName, "Name", PowerGuid)
                PowerLearned.FKElement("Source", SourceName, "Name", SourceKey)
                PowerLearned.Element("Level") = PowerLevel.ToString
                PowerLearned.Element("CharacterLevel") = _LevelTaken(UpperBoundIndex).ToString

                If AutoObtained Then PowerLearned.Element("AutoObtained") = "Yes"

            End If

            Return PowerLearned

        End Function

        'clone the Power structure
        Public Function Clone() As Power
            Try
                Dim NewPower As Power
                NewPower = Me

                'clone the arrays
                NewPower._LevelReplaced = Me._LevelReplaced
                NewPower._LevelTaken = Me._LevelTaken

                Return NewPower

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function
    End Structure

    'structure used when viewing available Powers during levelling
    Public Structure AvailablePower
        Public PowerName As String
        Public PowerGuid As Objects.ObjectKey

        Public SourceGuid As Objects.ObjectKey
        Public SourceName As String
        Public SourceType As PowerSourceType

        Public PowerLevel As Integer
        Public PowerSchool As String
        Public Status As AvailablePowerStatus
        Public HTML As String

        Public Overrides Function ToString() As String
            Return PowerName
        End Function

    End Structure

    'Power slot strucutre for use in the Powers panel
    Public Structure PowerSlot
        Implements IComparable

        Public CharacterLevel As Integer
        Public MaxPowerLevel As Integer

        'Power taken info
        Public PowerGuid As Objects.ObjectKey
        Public PowerName As String
        Public PowerLevel As Integer
        Public SourceGuid As Objects.ObjectKey

        'Power replaced info
        Public ReplaceGuid As Objects.ObjectKey
        Public ReplaceName As String
        Public ReplaceLevel As Integer
        Public ReplaceSourceGuid As Objects.ObjectKey

        Public SlotType As PowerSlotType
        Public Fixed As Boolean

        Public Sub Clear()
            Try
                CharacterLevel = Nothing
                MaxPowerLevel = Nothing
                PowerGuid = Nothing
                PowerName = Nothing
                PowerLevel = Nothing

                ReplaceGuid = Nothing
                ReplaceName = Nothing
                ReplaceLevel = Nothing

                Fixed = False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Sub PowerClear()
            PowerGuid = Nothing
            PowerName = Nothing
            PowerLevel = Nothing
        End Sub

        Public Sub ReplaceClear()
            ReplaceGuid = Nothing
            ReplaceName = Nothing
            ReplaceLevel = Nothing
        End Sub

        Public Overrides Function ToString() As String
            Try
                Return PowerName
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As PowerSlot
            Try

                Data = DirectCast(obj, PowerSlot)

                If Data.MaxPowerLevel < MaxPowerLevel Then
                    Return 1
                ElseIf Data.MaxPowerLevel > MaxPowerLevel Then
                    Return -1
                ElseIf Data.MaxPowerLevel = MaxPowerLevel Then
                    If Data.CharacterLevel < CharacterLevel Then
                        Return 1
                    ElseIf Data.CharacterLevel > CharacterLevel Then
                        Return -1
                    Else
                        Return 0
                    End If
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Structure

    'structure used for holding Power lists and at what level they are available
    Public Structure PowerListData

        'the type of the source
        Public SourceName As String

        'Power source key
        Public SourceKey As Objects.ObjectKey

        'the type of the source
        Public SourceType As PowerSourceType

        'the available Power list for the source
        Public PowerList As Objects.ObjectDataCollection

        'how the source is obtained
        Private AquisitionType As AquisitionType

        'for selective aquisition
        Private LevelsAvailable As Hashtable

        'for permanent aquisition
        Private LevelObtained As Integer

        'constructor
        Public Sub New(ByVal Name As String, ByVal Key As Objects.ObjectKey, ByVal PowerList As Objects.ObjectDataCollection, ByVal LevelObtained As Integer, ByVal SourceType As PowerSourceType)
            Try
                Me.SourceName = Name
                Me.SourceKey = Key
                Me.SourceType = SourceType
                Me.LevelObtained = LevelObtained
                Me.AquisitionType = AquisitionType.Permanent
                Me.PowerList = PowerList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'constructor
        Public Sub New(ByVal Name As String, ByVal Key As Objects.ObjectKey, ByVal PowerList As Objects.ObjectDataCollection, ByVal LevelsObtained As ArrayList, ByVal SourceType As PowerSourceType)
            Try
                Me.SourceName = Name
                Me.SourceKey = Key
                Me.SourceType = SourceType
                Me.AquisitionType = AquisitionType.Selective
                Me.PowerList = PowerList
                LevelsAvailable = New Hashtable
                For Each Level As Integer In LevelsObtained
                    LevelsAvailable.Add(Level, True)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'is this source available at the given level
        Public ReadOnly Property IsAvailable(ByVal Level As Integer) As Boolean
            Get
                Try
                    If AquisitionType = AquisitionType.Selective Then Return DirectCast(LevelsAvailable(Level), Boolean)

                    If AquisitionType = AquisitionType.Permanent Then
                        If Level >= LevelObtained Then
                            Return True
                        Else
                            Return False
                        End If
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

    End Structure

    Structure PowerSchoolXMLData
        Implements IComparable
        Public Name As String
        Public License As String
        Public Tags As String
        Public Sourcebook As String
        Public PageNoRef As String

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As PowerSchoolXMLData
            Try
                Data = DirectCast(obj, PowerSchoolXMLData)

                If Data.Name < Name Then
                    Return 1
                ElseIf Data.Name > Name Then
                    Return -1
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function
    End Structure

#End Region

#Region "Enumerations"

    'status of the Power in terms of the character
    Public Enum AvailablePowerStatus
        AlreadyHave
        Allowed
        SacrificedSchool
    End Enum

    'Power slot type
    Public Enum PowerSlotType

        'book type slots can be filled with any Power up to that slots Power level
        Normal

    End Enum

    'used for determining the origins of an avialable Power
    Public Enum PowerSourceType
        [Class]
        PrestigeClass
        PsionicSpecialization
        PrestigePsionicSpecialization
        RacialAddition
        Unknown
    End Enum

#End Region

    Public Class Powers

#Region "Member Variables"

        'private variables
        Private _Character As Rules.Character
        Private _Powers As ObjectHashtable

        'public variables
        Public AvailablePowers As AvailablePowers

#End Region

        Public ReadOnly Property Character() As Rules.Character
            Get
                Return _Character
            End Get
        End Property

        'constructor 
        Public Sub New(ByVal Character As Rules.Character)
            Try
                _Character = Character
                _Powers = New ObjectHashtable(5)
                AvailablePowers = New Rules.AvailablePowers(Character)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the collection
        Public Sub Load()
            Try
                _Powers.Clear()

                Dim Power As Rules.Power
                For Each ClassPowerFolder As Objects.ObjectData In _Character.PsionicFolder.Children()

                    Select Case ClassPowerFolder.Type
                        Case Objects.ClassPowerListFolderType
                            For Each PowerLearned As Objects.ObjectData In ClassPowerFolder.Children
                                If (General.Mode = AppMode.Full) OrElse (PowerLearned.ElementAsInteger("CharacterLevel") < 6) Then
                                    Power = New Power
                                    Power.ClassName = PowerLearned.Element("Class")
                                    Power.ClassGuid = PowerLearned.GetFKGuid("Class")
                                    Power.PowerGuid = PowerLearned.GetFKGuid("Power")
                                    Power.PowerName = PowerLearned.Element("Power")
                                    Power.PowerLevel = PowerLearned.ElementAsInteger("Level")
                                    Power.SourceName = PowerLearned.Element("Source")
                                    Power.SourceKey = PowerLearned.GetFKGuid("Source")
                                    Power.TakeAtLevel(PowerLearned.ElementAsInteger("CharacterLevel"))
                                    Power.IsNew = False
                                    If PowerLearned.Element("AutoObtained") = "Yes" Then Power.AutoObtained = True
                                    Power.PowerObject = PowerLearned
                                    AddPower(Power)
                                End If
                            Next

                        Case Objects.PsiLikeAbilityFolderType
                            'load the existing psi like abilities
                            For Each PsiLikeAbility As Objects.ObjectData In ClassPowerFolder.ChildrenOfType(Objects.PsiLikeAbilityTakenType)
                                If (General.Mode = AppMode.Full) OrElse (PsiLikeAbility.ElementAsInteger("CharacterLevel") < 6) Then
                                    _Character.ExistingPsiLikeAbilities.Add(PsiLikeAbility)
                                End If
                            Next

                        Case Else
                            'do nothing

                    End Select
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try

        End Sub

        'saves the collection
        Public Sub Save()
            Try

                'get the Power casters
                Dim PowerCasters As New ObjectHashtable
                Dim ClassKey As Objects.ObjectKey
                Dim ClassInfo As Rules.CharacterClass

                'get racial caster
                If _Character.RaceObject.Element("CasterType") = "Psionic" Then
                    ClassKey = _Character.RaceObject.GetFKGuid("CasterSource")
                    If Not ClassKey.IsEmpty Then
                        ClassInfo = _Character.CharacterClasses(ClassKey)
                        If ClassInfo.IsPsionic Then PowerCasters.Add(ClassKey, ClassInfo)
                    End If
                End If

                'get class casters
                For Each ClassKey In _Character.CharacterClassKeys
                    ClassInfo = _Character.CharacterClasses(ClassKey)
                    If ClassInfo.IsPsionic Then PowerCasters.Item(ClassKey) = ClassInfo
                Next

                If PowerCasters.Count > 0 Then

                    'make sure the magic folder has been made
                    _Character.PsionicFolderSave()

                    'create a list and settings folder for each caster class if it does not already exist
                    Dim ClassPowerListFolders As Objects.ObjectDataCollection = _Character.PsionicFolder.ChildrenOfType(Objects.ClassPowerListFolderType)
                    Dim ClassPowerSettingFolders As Objects.ObjectDataCollection = _Character.PsionicFolder.ChildrenOfType(Objects.ClassPowerSettingsFolderType)

                    For Each ClassKey In PowerCasters.Keys
                        Dim NewFolder As New Objects.ObjectData
                        Dim ClassObject As Objects.ObjectData = DirectCast(PowerCasters.Item(ClassKey), Rules.CharacterClass).ClassObj

                        'list folder
                        If Not ClassPowerListFolders.ContainsFK("Class", ClassKey) Then
                            NewFolder.Clear()
                            NewFolder.Name = ClassObject.Name & " Power List"
                            NewFolder.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                            NewFolder.Type = Objects.ClassPowerListFolderType
                            NewFolder.ParentGUID = _Character.PsionicFolder.ObjectGUID
                            NewFolder.FKElement("Class", ClassObject.Name, "Name", ClassKey)
                            NewFolder.Save()
                            ClassPowerListFolders.Add(NewFolder)
                        End If

                        'settings folder
                        If Not ClassPowerSettingFolders.ContainsFK("Class", ClassKey) Then
                            NewFolder.Clear()
                            NewFolder.Name = ClassObject.Name & " Manifester Information"
                            NewFolder.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                            NewFolder.Type = Objects.ClassPowerSettingsFolderType
                            NewFolder.ParentGUID = _Character.PsionicFolder.ObjectGUID
                            NewFolder.FKElement("Class", ClassObject.Name, "Name", ClassKey)
                            NewFolder.Save()
                            ClassPowerSettingFolders.Add(NewFolder)
                        End If

                        ClassObject.Clear()
                    Next

                    'Powers
                    For Each Item As System.Collections.DictionaryEntry In _Powers

                        'get the class library
                        Dim ClassLibrary As Library = DirectCast(Item.Value, Library)

                        'get the class Power list folder
                        Dim ClassPowerFolder As Objects.ObjectData = ClassPowerListFolders.Item("Class", New Objects.ObjectKey(CStr(Item.Key)))

                        'get the Powers
                        For Each Data As Library.LibraryData In ClassLibrary.ItemData()
                            Dim Power As Rules.Power = DirectCast(Data.Data, Rules.Power)

                            'if this Powers has been removed - delete the object if it exists
                            If Power.LevelReplaced > 0 Then
                                If Power.IsNew = False Then
                                    Power.IsNew = True
                                    Power.PowerObject.Delete()
                                    UpdatePower(Power)
                                End If
                            Else
                                If Power.IsNew Then
                                    Power.IsNew = False
                                    Power.PowerObject = Power.CreateObject(_Character, ClassPowerFolder.ObjectGUID)
                                    Power.PowerObject.Save()
                                    UpdatePower(Power)
                                Else
                                    'update existing Power
                                    Power.PowerObject.Element("CharacterLevel") = Power.LevelTaken.ToString
                                    Power.PowerObject.Element("Level") = Power.PowerLevel.ToString
                                End If
                            End If
                        Next
                    Next

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'takes a Power for the given class at the specifed level
        Public Sub TakePower(ByVal PowerKey As Objects.ObjectKey, ByVal PowerName As String, ByVal ClassKey As Objects.ObjectKey, ByVal ClassName As String, ByVal SourceKey As Objects.ObjectKey, ByVal SourceName As String, ByVal PowerLevel As Integer, ByVal CharacterLevel As Integer, Optional ByVal AutoObtained As Boolean = False)
            Try
                If PowerKey.IsEmpty OrElse ClassKey.IsEmpty OrElse SourceKey.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Attempt to add a Power with no Class/Power/Source Guid")

                'see if we have it already
                If Me.Contains(ClassKey, PowerKey, SourceKey) Then

                    'get the Power structure
                    Dim Power As Power = GetPower(ClassKey, PowerKey, SourceKey)
                    Power.TakeAtLevel(CharacterLevel)
                    AddPower(Power)

                Else
                    'create the new Power
                    Dim NewPower As New Power
                    NewPower.PowerGuid = PowerKey
                    NewPower.PowerName = PowerName
                    NewPower.PowerLevel = PowerLevel
                    NewPower.TakeAtLevel(CharacterLevel)

                    NewPower.ClassGuid = ClassKey
                    NewPower.ClassName = ClassName

                    NewPower.SourceKey = SourceKey
                    NewPower.SourceName = SourceName

                    NewPower.IsNew = True

                    If AutoObtained = True Then
                        NewPower.AutoObtained = True
                    End If

                    'add it to the character
                    AddPower(NewPower)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'updates the Power in this collection with the one given - need because the Power structure is a value type
        Public Sub UpdatePower(ByVal Power As Rules.Power)
            Try
                If Power.PowerGuid.IsEmpty OrElse Power.ClassGuid.IsEmpty OrElse Power.SourceKey.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Attempt to update a Power with no Class/Power/Source Guid")

                'add it to the character
                AddPower(Power)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'check to see if the given class has his Power
        Public Function Contains(ByVal ClassKey As Objects.ObjectKey, ByVal PowerKey As Objects.ObjectKey) As Boolean
            Try

                If ClassKey.IsEmpty Or PowerKey.IsEmpty Then Return False

                'get the class Power library
                Dim ClassLibrary As Library = Me.ClassPowerLibrary(ClassKey)
                If ClassLibrary Is Nothing Then Return False

                'look for the key
                If ClassLibrary.ContainsKey(PowerKey) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'more specfic version of contains
        Public Function Contains(ByVal ClassKey As Objects.ObjectKey, ByVal PowerKey As Objects.ObjectKey, ByVal SourceKey As Objects.ObjectKey) As Boolean
            Try

                If ClassKey.IsEmpty Or PowerKey.IsEmpty Or SourceKey.IsEmpty Then Return False

                'get the class Power library
                Dim ClassLibrary As Library = Me.ClassPowerLibrary(ClassKey)
                If ClassLibrary Is Nothing Then Return False

                'look for the key
                If ClassLibrary.ContainsSubkey(PowerKey, SourceKey) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculate the max Power level this character can manifest, base only is used for getting raw scores, just base on a given manifester level
        Public Function GetMaxPowerLevel(ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As Integer
            Try

                Dim MaxPowerLevel As Integer = -1

                'get the class information
                Dim ClassInfo As CharacterClass = CType(_Character.CharacterClasses(ClassKey), CharacterClass)

                If ClassInfo.IsPsionic = False Then Return MaxPowerLevel

                'get the effective class level
                Dim EffectiveClassLevel As Integer = _Character.HighestClassLevelAtLevel(ClassKey, CharacterLevel).ClassLevel + PrestigeClassOffset(ClassKey, CharacterLevel) + Character.GetRacialCasterOffset(ClassKey)
                If EffectiveClassLevel < 1 Then Return MaxPowerLevel

                Dim PowerAbilityScore As Integer = GetPowerAbilityScore(ClassInfo, CharacterLevel)

                For PowerLevel As Integer = 0 To (PowerAbilityScore - 10)
                    If CanManifestpowerOfLevel(ClassInfo, EffectiveClassLevel, PowerLevel, PowerAbilityScore) Then
                        MaxPowerLevel = PowerLevel
                    End If
                Next

                Return MaxPowerLevel

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculate the max Power level this character can manifest, use explicit classlevel given
        Public Function GetMaxPowerLevel(ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer, ByVal EffectiveClassLevel As Integer) As Integer
            Try
                Dim MaxPowerLevel As Integer = -1

                'get the class information
                Dim ClassInfo As CharacterClass = CType(_Character.CharacterClasses(ClassKey), CharacterClass)

                If ClassInfo.IsPsionic = False Then Return MaxPowerLevel

                'get the effective class level                 
                If EffectiveClassLevel < 1 Then Return MaxPowerLevel

                Dim PowerAbilityScore As Integer = GetPowerAbilityScore(ClassInfo, CharacterLevel)

                For PowerLevel As Integer = 0 To (PowerAbilityScore - 10)
                    If CanManifestpowerOfLevel(ClassInfo, EffectiveClassLevel, PowerLevel, PowerAbilityScore) Then
                        MaxPowerLevel = PowerLevel
                    End If
                Next

                Return MaxPowerLevel

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculate the max Power level this character can manifest - quicker version used in prerequiste checking
        Public Function GetMaxPowerLevel(ByVal ClassInfo As CharacterClass, ByVal CharacterLevel As Integer) As Integer
            Try

                Dim MaxPowerLevel As Integer = -1
                Dim ClassKey As Objects.ObjectKey = ClassInfo.ClassObj.ObjectGUID

                'get the effective class level
                Dim EffectiveClassLevel As Integer = _Character.HighestClassLevelAtLevel(ClassKey, CharacterLevel).ClassLevel + PrestigeClassOffset(ClassKey, CharacterLevel) + Character.GetRacialCasterOffset(ClassKey)
                If EffectiveClassLevel < 1 Then Return MaxPowerLevel

                Dim PowerAbilityScore As Integer = GetPowerAbilityScore(ClassInfo, CharacterLevel)

                For PowerLevel As Integer = 0 To (PowerAbilityScore - 10)
                    If CanManifestpowerOfLevel(ClassInfo, EffectiveClassLevel, PowerLevel, PowerAbilityScore) Then
                        MaxPowerLevel = PowerLevel
                    End If
                Next

                Return MaxPowerLevel

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the Power structure
        Public Function GetPower(ByVal ClassKey As Objects.ObjectKey, ByVal PowerKey As Objects.ObjectKey, ByVal SourceKey As Objects.ObjectKey) As Power
            Try

                If ClassKey.IsEmpty Or PowerKey.IsEmpty Or SourceKey.IsEmpty Then Return Nothing

                'get the class Powers library
                Dim ClassPowerLibrary As Library = Me.ClassPowerLibrary(ClassKey)

                If ClassPowerLibrary Is Nothing Then Return Nothing

                'find the Power
                If ClassPowerLibrary.ContainsSubkey(PowerKey, SourceKey) Then
                    Return DirectCast(ClassPowerLibrary.ItemData(PowerKey, SourceKey).Data, Power)
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the class Power library
        Public Function ClassPowerLibrary(ByVal ClassKey As Objects.ObjectKey) As Library
            Try

                If ClassKey.IsEmpty Then Return Nothing
                If _Powers.Contains(ClassKey) Then
                    Return DirectCast(_Powers.Item(ClassKey), Library)
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Gets the score of the Primary Power Casting Ability
        Public Function GetPowerAbilityScore(ByVal classInfo As CharacterClass, ByVal Level As Integer) As Integer
            Try
                If classInfo.IsPsionic Then
                    Select Case classInfo.CasterInfo.PowerAttribute
                        Case "STR"
                            GetPowerAbilityScore = _Character.Levels(Level).STR
                        Case "DEX"
                            GetPowerAbilityScore = _Character.Levels(Level).DEX
                        Case "CON"
                            GetPowerAbilityScore = _Character.Levels(Level).CON
                        Case "INT"
                            GetPowerAbilityScore = _Character.Levels(Level).INT
                        Case "WIS"
                            GetPowerAbilityScore = _Character.Levels(Level).WIS
                        Case "CHA"
                            GetPowerAbilityScore = _Character.Levels(Level).CHA
                    End Select
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculate the PrestigeClass offest value for the given class and level
        Public Function PrestigeClassOffset(ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer) As Integer
            Try
                Dim Offset As Integer = 0
                For Each PowerCasterChoice As Library.LibraryData In _Character.PrestigeSpellcasterChoices.ItemData(ClassKey)
                    If PowerCasterChoice.LevelAcquired <= CharacterLevel Then Offset += 1
                Next
                Return Offset
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'checks if a character could manifest powers of the given level from the given class
        Public Function CanManifestpowerOfLevel(ByVal ClassInfo As CharacterClass, ByVal ClassLevel As Integer, ByVal PowerLevel As Integer, ByVal PowerAbilityScore As Integer) As Boolean
            Try
                Dim MaxPowerLevel As Integer = ClassInfo.MaxPowerLevelKnown(ClassLevel)
                If MaxPowerLevel < PowerLevel Then Return False
                If (PowerLevel + 10) > PowerAbilityScore Then Return False

                Return True

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'clone the class
        Public Function Clone(ByVal Character As Rules.Character) As Rules.Powers
            Try
                Dim NewPowers As New Powers(Character)

                'iterate through the class Power lists
                For Each Item As DictionaryEntry In _Powers
                    Dim OldClassPowerLibrary, NewClassPowerLibrary As Library
                    OldClassPowerLibrary = DirectCast(Item.Value, Library)
                    NewClassPowerLibrary = New Library
                    NewPowers._Powers.Add(New Objects.ObjectKey(CStr(Item.Key)), NewClassPowerLibrary)

                    'iterate through each Power taken
                    For Each LibraryData As Library.LibraryData In OldClassPowerLibrary.ItemData
                        Dim PowerTaken As Power = DirectCast(LibraryData.Data, Power).Clone
                        NewClassPowerLibrary.AddItemWithSubkey(PowerTaken.PowerGuid, PowerTaken.SourceKey, PowerTaken, , , True)
                    Next
                Next

                Return NewPowers

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'private - adds a Power to the collection, to do publicly use TakePower
        Private Sub AddPower(ByVal Power As Rules.Power)
            Try

                'get the class library
                Dim ClassLibrary As Library = ClassPowerLibrary(Power.ClassGuid)

                If ClassLibrary Is Nothing Then
                    ClassLibrary = New Library
                    _Powers.Add(Power.ClassGuid, ClassLibrary)
                End If

                ClassLibrary.AddItemWithSubkey(Power.PowerGuid, Power.SourceKey, Power, , , True)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

    'This class lets us see what Powers are available to a character
    Public Class AvailablePowers

#Region "Member Variables"

        'variables
        Private Character As Rules.Character
        Private Levels As New ObjectHashtable

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Try
                Me.Character = Character
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the Powers and levels collections with the Powers for this class
        Public Sub LoadPowers(ByVal ClassInfo As CharacterClass, ByVal Character As Character)
            Try

                'get the max Power level
                Dim MaxPowerLevel As Integer = Character.Powers.GetMaxPowerLevel(ClassInfo.ClassObj.ObjectGUID, Me.Character.CharacterLevel)

                'get the class Power levels data
                Dim ClassPowerLevels As New AvailablePowerSources(Character, ClassInfo.ClassObj, MaxPowerLevel)
                Levels(ClassInfo.ClassObj.ObjectGUID) = ClassPowerLevels

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'Gives a list of available Powers for the given slot, and colours them appropriately
        Public Function AvailablePowersList(ByVal Slot As PowerSlot, ByVal ClassInfo As CharacterClass) As ArrayList
            Try
                General.SetWaitCursor()

                Dim LevelObj As Objects.ObjectData
                Dim PowerList As New ArrayList
                Dim AvailablePowers As New ArrayList

                Dim ClassPowerLevels As AvailablePowerSources

                Select Case Slot.SlotType

                    Case PowerSlotType.Normal
                        ClassPowerLevels = DirectCast(Levels(ClassInfo.ClassObj.ObjectGUID), AvailablePowerSources)
                        For Each PowerListData As PowerListData In ClassPowerLevels.PowerLevelSources(Slot.CharacterLevel)
                            For Each LevelObj In PowerListData.PowerList
                                If LevelObj.ElementAsInteger("Level") <= Slot.MaxPowerLevel Then
                                    AvailablePowers.Add(CreateAvailablePower(LevelObj.ParentGUID, PowerListData.SourceName, PowerListData.SourceKey, PowerListData.SourceType, LevelObj.ElementAsInteger("Level")))
                                End If
                            Next
                        Next

                    Case Else
                        General.ShowErrorDialog("This slot type not yet developed")

                End Select

                Dim AvailablePower As AvailablePower


                For Each AvailablePower In AvailablePowers

                    'Check the Power status
                    AvailablePower.Status = AvailablePowerStatus.Allowed

                    If Character.Powers.Contains(ClassInfo.ClassObj.ObjectGUID, AvailablePower.PowerGuid, AvailablePower.SourceGuid) Then
                        If Not Character.Powers.GetPower(ClassInfo.ClassObj.ObjectGUID, AvailablePower.PowerGuid, AvailablePower.SourceGuid).AvailableAtLevel(Slot.CharacterLevel) Then
                            AvailablePower.Status = AvailablePowerStatus.AlreadyHave
                        End If
                    End If
                    PowerList.Add(AvailablePower)
                Next

                General.SetNormalCursor()

                Return PowerList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'creates an availablePower structure
        Private Function CreateAvailablePower(ByVal PowerKey As Objects.ObjectKey, ByVal SourceName As String, ByVal SourceKey As Objects.ObjectKey, ByVal SourceType As PowerSourceType, ByVal PowerLevel As Integer) As AvailablePower
            Try
                Dim AvailablePower As AvailablePower
                Dim PowerObj As Objects.ObjectData = Rules.PowerList.PowerDefinition(PowerKey)

                With AvailablePower
                    .PowerName = PowerObj.Name
                    .PowerGuid = PowerKey

                    .SourceName = SourceName
                    .SourceGuid = SourceKey
                    .SourceType = SourceType

                    .PowerLevel = PowerLevel
                    .PowerSchool = PowerObj.Element("School")
                    .HTML = PowerObj.HTML
                End With

                Return AvailablePower

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Is this level a prestige type which has advanced in a previous Powercasting level
        Private Function CheckPrestige(ByVal ClassInfo As Rules.CharacterClass, ByVal Level As Character.Level) As Boolean
            Dim PowercasterChoice As Rules.Character.CharacterChoice
            Dim ClassChoices As ArrayList

            'If it is a Prestige Class then check for the choice object
            ClassChoices = Character.PrestigeSpellcasterChoices.ItemData(ClassInfo.ClassObj.ObjectGUID)

            For Each TempData As Library.LibraryData In ClassChoices
                PowercasterChoice = DirectCast(TempData.Data, Rules.Character.CharacterChoice)
                If PowercasterChoice.LevelAcquired = Level.CharacterLevel Then Return True
            Next

            Return False

        End Function

        'Returns an integer array indexed from 0 to 9, each index representing a spell level and contains the number of spells known at this level.
        Public Function GetPowersKnown(ByVal ClassInfo As CharacterClass, ByVal Level As Integer, Optional ByRef LastKnowClassLevel As Integer = 0, Optional ByVal PrestigeOffset As Integer = 0) As Integer()
            Try
                Dim SpellsKnownObject As Objects.ObjectData
                Dim SpellsPerDayObject As Objects.ObjectData
                Dim ElementString As String
                Dim SpellAbilityScore As Integer
                Dim MaxSpellLevel As Integer
                Dim LevelInfo As Character.Level

                ReDim GetPowersKnown(9)

                If LastKnowClassLevel = 0 Then
                    LevelInfo = Character.HighestClassLevelAtLevel(ClassInfo.ClassObj.ObjectGUID, Level)
                    LastKnowClassLevel = LevelInfo.CharacterLevel
                Else
                    LevelInfo = Character.Levels(LastKnowClassLevel)
                End If

                If LevelInfo.CharacterLevel = 0 Then
                    Return GetPowersKnown
                End If

                SpellsKnownObject = ClassInfo.SpellsKnownObject(LevelInfo.ClassLevel + PrestigeOffset)
                SpellsPerDayObject = ClassInfo.SpellsPerDayObject(LevelInfo.ClassLevel + PrestigeOffset)
                SpellAbilityScore = Character.Spells.GetSpellAbilityScore(ClassInfo, Level)

                'Shortcuts by only checking the number of spells known for spells that are actually castable
                If SpellAbilityScore > 19 Then
                    MaxSpellLevel = 9
                Else
                    MaxSpellLevel = SpellAbilityScore - 10
                End If

                For SpellLevel As Integer = 0 To MaxSpellLevel

                    ElementString = "Level" & SpellLevel & "Spells"

                    If Not SpellsKnownObject.Element(ElementString) = "" Then

                        'check they can actualy cast spells of this level
                        If SpellsKnownObject.ElementAsInteger(ElementString) > 0 Then

                            If Character.Spells.CanCastSpellOfLevel(ClassInfo, LevelInfo.ClassLevel + PrestigeOffset, SpellLevel, SpellAbilityScore) Then
                                GetPowersKnown.SetValue(SpellsKnownObject.ElementAsInteger(ElementString), SpellLevel)
                            End If

                        End If
                    End If

                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Gets the available Powers slots for the given class, make sure you have loaded the given class before calling this
        Public Function AvailablePowerSlots(ByVal ClassInfo As CharacterClass) As ArrayList
            Dim StartLevel As Integer
            Dim FirstClassLevel As Character.Level
            Dim Slots As New ArrayList
            'Dim ClassPowers As Hashtable
            Dim PrestigeClassOffset, RacialOffset As Integer
            Dim TempLevel As Character.Level
            Dim PresitgeExistingPowercasterClass As Boolean
            Dim PreviousPowersKnown As Integer
            Dim PreviousEffectiveClassLevel, EffectiveClassLevel As Integer

            Try
                StartLevel = Character.FirstNewLevel
                FirstClassLevel = Character.LowestClassLevelInfo(ClassInfo.ClassObj.ObjectGUID)
                RacialOffset = Character.GetRacialCasterOffset(ClassInfo.ClassObj.ObjectGUID)

                If RacialOffset > 0 Then

                    If StartLevel > 1 Then
                        PrestigeClassOffset = Character.Powers.PrestigeClassOffset(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1)
                        EffectiveClassLevel = Character.HighestClassLevelAtLevel(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1).ClassLevel + PrestigeClassOffset + RacialOffset
                        PreviousEffectiveClassLevel = EffectiveClassLevel
                        PreviousPowersKnown = ClassInfo.PsionicPowersKnown(EffectiveClassLevel)
                    Else
                        PreviousPowersKnown = 0
                        EffectiveClassLevel = 0
                        PreviousEffectiveClassLevel = 0
                        PrestigeClassOffset = 0
                    End If

                Else

                    'if the first level of this class has been added this session
                    If FirstClassLevel.CharacterLevel >= StartLevel Then
                        StartLevel = FirstClassLevel.CharacterLevel
                        PreviousPowersKnown = 0
                        EffectiveClassLevel = 0
                        PreviousEffectiveClassLevel = 0
                        PrestigeClassOffset = 0
                    Else
                        'else get the previous powers known
                        PrestigeClassOffset = Character.Powers.PrestigeClassOffset(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1)
                        EffectiveClassLevel = Character.HighestClassLevelAtLevel(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1).ClassLevel + PrestigeClassOffset + RacialOffset
                        PreviousEffectiveClassLevel = EffectiveClassLevel
                        PreviousPowersKnown = ClassInfo.PsionicPowersKnown(EffectiveClassLevel)
                    End If

                End If

                For n As Integer = StartLevel To Character.CharacterLevel
                    TempLevel = Character.Levels(n)
                    PresitgeExistingPowercasterClass = CheckPrestige(ClassInfo, TempLevel)

                    If n = 1 AndAlso RacialOffset > 0 Then
                        EffectiveClassLevel = RacialOffset
                        CreatePowerSlots(Slots, ClassInfo, PreviousPowersKnown, EffectiveClassLevel, PreviousEffectiveClassLevel, n)
                    End If

                    If (TempLevel.ClassGuid.Equals(ClassInfo.ClassObj.ObjectGUID)) OrElse (PresitgeExistingPowercasterClass) Then
                        EffectiveClassLevel += 1
                        CreatePowerSlots(Slots, ClassInfo, PreviousPowersKnown, EffectiveClassLevel, PreviousEffectiveClassLevel, n)
                    End If

                    PreviousEffectiveClassLevel = EffectiveClassLevel

                Next

                Return Slots

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Creates new power slots - previous powers known is passed by reference
        Private Sub CreatePowerSlots(ByVal Slots As ArrayList, ByVal ClassInfo As Rules.CharacterClass, ByRef PreviousPowersKnown As Integer, ByVal EffectiveClassLevel As Integer, ByVal PreviousEffectiveClassLevel As Integer, ByVal CharacterLevel As Integer)
            Try
                Dim PowersKnown, MaxPowerLevel As Integer

                For i As Integer = (PreviousEffectiveClassLevel + 1) To EffectiveClassLevel

                    PowersKnown = ClassInfo.PsionicPowersKnown(i)
                    If PowersKnown > PreviousPowersKnown Then

                        'If they can at least learn a level 1 Power
                        MaxPowerLevel = Character.Powers.GetMaxPowerLevel(ClassInfo.ClassObj.ObjectGUID, CharacterLevel, i)
                        If MaxPowerLevel > 0 Then
                            Dim Slot As New PowerSlot
                            Slot.Clear()
                            Slot.MaxPowerLevel = MaxPowerLevel
                            Slot.CharacterLevel = CharacterLevel
                            Slot.Fixed = False

                            'Add slot to collection
                            For count As Integer = 1 To (PowersKnown - PreviousPowersKnown)
                                Slots.Add(Slot)
                            Next

                            PreviousPowersKnown = PowersKnown
                        End If

                    End If

                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class


    'holds information on all the different Power sources that a specfic class has access to
    Public Class AvailablePowerSources

#Region "Member Variables"

        Private Levels As ArrayList

#End Region

        'constructor
        Public Sub New(ByVal Character As Character, ByVal ClassObject As Objects.ObjectData, ByVal MaxPowerLevel As Integer)
            Try
                Dim PowerListData As PowerListData
                Levels = New ArrayList

                'if this is a racial caster - check for additional power sources
                If Character.GetRacialCasterOffset(ClassObject.ObjectGUID) > 0 Then
                    Dim AdditionalPowerSources As Objects.ObjectDataCollection
                    AdditionalPowerSources = Character.RaceObject.ChildrenOfType(Objects.SpellorPowerSourceType)
                    For Each AdditionalPowerSource As Objects.ObjectData In AdditionalPowerSources
                        PowerListData = New PowerListData(AdditionalPowerSource.Name, AdditionalPowerSource.GetFKGuid("Source"), Rules.PowerList.PowerList(AdditionalPowerSource.GetFKGuid("Source"), 0, MaxPowerLevel), 1, PowerSourceType.RacialAddition)
                        Levels.Add(PowerListData)
                    Next

                    'get the class level
                    PowerListData = New PowerListData(ClassObject.Name, ClassObject.ObjectGUID, Rules.PowerList.PowerList(ClassObject.ObjectGUID, 0, MaxPowerLevel), 1, PowerSourceType.Class)
                    Levels.Add(PowerListData)

                Else

                    'get the class level
                    PowerListData = New PowerListData(ClassObject.Name, ClassObject.ObjectGUID, Rules.PowerList.PowerList(ClassObject.ObjectGUID, 0, MaxPowerLevel), Character.LowestClassLevel(ClassObject.ObjectGUID), PowerSourceType.Class)
                    Levels.Add(PowerListData)

                End If

                'get any psionic specialization levels
                For Each Specialization As Rules.PsionicSpecialization In Character.PsionicSpecializations.ClassSpecializations(ClassObject.ObjectGUID, Character.CharacterLevel)
                    PowerListData = New PowerListData(Specialization.SpecializationObj.Name, Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), Rules.PowerList.PowerList(Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), 0, MaxPowerLevel), Specialization.SpecializationObj.ElementAsInteger("LevelAcquired"), PowerSourceType.PsionicSpecialization)
                    Levels.Add(PowerListData)
                Next

                'get all the prestige classes and levels they were taken
                Dim PrestigeCasters As New OneKeyList
                For Each PowerCasterChoiceData As Library.LibraryData In Character.PrestigeSpellcasterChoices.ItemData(ClassObject.ObjectGUID)
                    Dim PowerCasterChoice As Character.CharacterChoice
                    PowerCasterChoice = DirectCast(PowerCasterChoiceData.Data, Character.CharacterChoice)
                    PrestigeCasters.Add(PowerCasterChoice.ClassGuid, PowerCasterChoice.LevelAcquired)
                Next

                For Each PrestigeClassKey As Objects.ObjectKey In PrestigeCasters.Keys
                    Dim PrestigeClassInfo As CharacterClass = Character.CharacterClasses(PrestigeClassKey)
                    Dim ClassLevels As ArrayList = PrestigeCasters.Item(PrestigeClassKey)

                    PowerListData = New PowerListData(PrestigeClassInfo.ClassObj.Name, PrestigeClassKey, Rules.PowerList.PowerList(PrestigeClassKey, 0, MaxPowerLevel), ClassLevels, PowerSourceType.PrestigeClass)
                    Levels.Add(PowerListData)

                    'check for any domains the prestige class may have
                    For Each Specialization As Rules.PsionicSpecialization In Character.PsionicSpecializations.ClassSpecializations(PrestigeClassKey, Character.CharacterLevel)
                        Dim SpecializationLevels As New ArrayList

                        For Each Level As Integer In ClassLevels
                            If Character.PsionicSpecializations.HasSpecialization(PrestigeClassKey, Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), Level) Then
                                SpecializationLevels.Add(Level)
                            End If
                        Next

                        PowerListData = New PowerListData(Specialization.SpecializationObj.Name, Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), Rules.PowerList.PowerList(Specialization.SpecializationObj.GetFKGuid("PsionicSpecialization"), 0, MaxPowerLevel), SpecializationLevels, PowerSourceType.PrestigePsionicSpecialization)
                        Levels.Add(PowerListData)
                    Next
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'returns the PowerListDatas that are available at the given level
        Public Function PowerLevelSources(ByVal CharacterLevel As Integer) As ArrayList
            Try

                Dim PowerListDataItems As New ArrayList

                'see what sources are in the hashtable - and if we have them at the given level
                For Each PowerListData As PowerListData In Levels
                    If PowerListData.IsAvailable(CharacterLevel) Then
                        PowerListDataItems.Add(PowerListData)
                    End If
                Next

                Return PowerListDataItems

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
