Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

#Region "Structures"

    'spell structure
    Public Structure Spell
        Public SpellGuid As Objects.ObjectKey
        Public SpellName As String

        Public ClassGuid As Objects.ObjectKey
        Public ClassName As String

        Public SourceKey As Objects.ObjectKey
        Public SourceName As String

        Public SpellLevel As Integer

        'internal level holders
        Private _LevelTaken() As Integer
        Private _LevelReplaced() As Integer

        Public IsNew As Boolean
        Public AutoObtained As Boolean
        Public SpellObject As Objects.ObjectData

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

        'true if the character can has this spell at the given level
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

        'true if the spell has been replaced on or before the given level
        Public Function AvailableAtLevel(ByVal level As Integer) As Boolean

            If _LevelReplaced.GetUpperBound(0) < 0 Then Return True

            Dim LastLevelReplaced As Integer = _LevelReplaced(_LevelReplaced.GetUpperBound(0))

            If (LastLevelReplaced > 0) AndAlso level >= LastLevelReplaced Then
                Return True
            Else
                Return False
            End If
        End Function

        'true if this spell was last picked before the given level and has not yet been replaced
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

            Dim SpellLearned As New Objects.ObjectData
            Dim UpperBoundIndex As Integer

            UpperBoundIndex = _LevelTaken.GetUpperBound(0)

            'Make sure we need to make an object for this spell first
            If (UpperBoundIndex > -1) AndAlso (_LevelReplaced(UpperBoundIndex) = 0) Then
                SpellLearned.Name = Me.SpellName
                SpellLearned.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
                SpellLearned.Type = Objects.SpellLearnedType
                SpellLearned.ParentGUID = ParentFolderGuid
                SpellLearned.HTMLGUID = SpellGuid

                SpellLearned.FKElement("Class", ClassName, "Name", ClassGuid)
                SpellLearned.FKElement("Spell", SpellName, "Name", SpellGuid)
                SpellLearned.FKElement("Source", SourceName, "Name", SourceKey)
                SpellLearned.Element("Level") = SpellLevel.ToString
                SpellLearned.Element("CharacterLevel") = _LevelTaken(UpperBoundIndex).ToString

                If AutoObtained Then SpellLearned.Element("AutoObtained") = "Yes"

            End If

            Return SpellLearned

        End Function

        'clone the spell structure
        Public Function Clone() As Spell
            Try
                Dim NewSpell As Spell
                NewSpell = Me

                'clone the arrays
                NewSpell._LevelReplaced = Me._LevelReplaced
                NewSpell._LevelTaken = Me._LevelTaken

                Return NewSpell

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function
    End Structure

    'structure used when viewing available spells during levelling
    Public Structure AvailableSpell
        Public SpellName As String
        Public SpellGuid As Objects.ObjectKey

        Public SourceGuid As Objects.ObjectKey
        Public SourceName As String
        Public SourceType As SpellSourceType

        Public SpellLevel As Integer
        Public SpellSchool As String
        Public Status As AvailableSpellStatus
        Public HTML As String

        Public Overrides Function ToString() As String
            Return SpellName
        End Function

    End Structure

    'spell slot strucutre for use in the spells panel
    Public Structure SpellSlot
        Implements IComparable

        Public CharacterLevel As Integer
        Public MaxSpellLevel As Integer

        'spell taken info
        Public SpellGuid As Objects.ObjectKey
        Public SpellName As String
        Public SpellLevel As Integer
        Public SourceGuid As Objects.ObjectKey

        'spell replaced info
        Public ReplaceGuid As Objects.ObjectKey
        Public ReplaceName As String
        Public ReplaceLevel As Integer
        Public ReplaceSourceGuid As Objects.ObjectKey

        Public SlotType As SpellSlotType
        Public Fixed As Boolean

        Public Sub Clear()
            Try
                CharacterLevel = Nothing
                MaxSpellLevel = Nothing
                SpellGuid = Nothing
                SpellName = Nothing
                SpellLevel = Nothing

                ReplaceGuid = Nothing
                ReplaceName = Nothing
                ReplaceLevel = Nothing

                Fixed = False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Sub SpellClear()
            SpellGuid = Nothing
            SpellName = Nothing
            SpellLevel = Nothing
        End Sub

        Public Sub ReplaceClear()
            ReplaceGuid = Nothing
            ReplaceName = Nothing
            ReplaceLevel = Nothing
        End Sub

        Public Overrides Function ToString() As String
            Try
                Return SpellName
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As SpellSlot
            Try

                Data = DirectCast(obj, SpellSlot)

                If Data.MaxSpellLevel < MaxSpellLevel Then
                    Return 1
                ElseIf Data.MaxSpellLevel > MaxSpellLevel Then
                    Return -1
                ElseIf Data.MaxSpellLevel = MaxSpellLevel Then
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

    'structure used for holding spell lists and at what level they are available
    Public Structure SpellListData

        'the type of the source
        Public SourceName As String

        'spell source key
        Public SourceKey As Objects.ObjectKey

        'the type of the source
        Public SourceType As SpellSourceType

        'the available spell list for the source
        Public SpellList As Objects.ObjectDataCollection

        'how the source is obtained
        Private AquisitionType As AquisitionType

        'for selective aquisition
        Private LevelsAvailable As Hashtable

        'for permanent aquisition
        Private LevelObtained As Integer

        'constructor
        Public Sub New(ByVal Name As String, ByVal Key As Objects.ObjectKey, ByVal SpellList As Objects.ObjectDataCollection, ByVal LevelObtained As Integer, ByVal SourceType As SpellSourceType)
            Try
                Me.SourceName = Name
                Me.SourceKey = Key
                Me.SourceType = SourceType
                Me.LevelObtained = LevelObtained
                Me.AquisitionType = AquisitionType.Permanent
                Me.SpellList = SpellList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'constructor
        Public Sub New(ByVal Name As String, ByVal Key As Objects.ObjectKey, ByVal SpellList As Objects.ObjectDataCollection, ByVal LevelsObtained As ArrayList, ByVal SourceType As SpellSourceType)
            Try
                Me.SourceName = Name
                Me.SourceKey = Key
                Me.SourceType = SourceType
                Me.AquisitionType = AquisitionType.Selective
                Me.SpellList = SpellList
                LevelsAvailable = New Hashtable
                For Each Level As Integer In LevelsObtained
                    LevelsAvailable.Item(Level) = True
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'is this source available at the given level
        Public ReadOnly Property IsAvailable(ByVal Level As Integer) As Boolean
            Get
                Try
                    If AquisitionType = AquisitionType.Selective Then Return CType(LevelsAvailable(Level), Boolean)

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

    Structure SpellSchoolXMLData
        Implements IComparable
        Public Name As String
        Public Description As String
        Public License As String
        Public Tags As String
        Public Sourcebook As String
        Public PageNoRef As String
        Public HelpPage As String

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As SpellSchoolXMLData
            Try
                Data = DirectCast(obj, SpellSchoolXMLData)

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

    'status of the spell in terms of the character
    Public Enum AvailableSpellStatus
        AlreadyHave
        Allowed
        SacrificedSchool
    End Enum

    'Spell slot type
    Public Enum SpellSlotType
        'book type slots can be filles with any spell up to that slots spell level
        Book_Type

        'known type slots have to be filled with a spell of the same level as the slot
        Known_Type

        'these types handle the replace known spell functionality
        Replace_Start_Type
        Replace_In_Progres_Type
    End Enum

    'used for determining when spell sources are available
    Public Enum AquisitionType
        Permanent
        Selective
    End Enum

    'used for determining the origins of an avialable spell
    Public Enum SpellSourceType
        [Class]
        PrestigeClass
        Domain
        PrestigeDomain
        RacialAdditional
        Unknown
    End Enum

#End Region

    Public Class Spells

#Region "Member Variables"

        'private variables
        Private _Character As Rules.Character
        Private _Spells As ObjectHashtable

        'public variables
        Public AvailableSpells As AvailableSpells

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
                _Spells = New ObjectHashtable(5)
                AvailableSpells = New Rules.AvailableSpells(Character)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the collection
        Public Sub Load()
            Try
                _Spells.Clear()

                Dim Spell As Rules.Spell
                For Each ClassSpellFolder As Objects.ObjectData In _Character.MagicFolder.Children()

                    Select Case ClassSpellFolder.Type
                        Case Objects.ClassSpellListFolderType
                            For Each SpellLearned As Objects.ObjectData In ClassSpellFolder.Children
                                If (General.Mode = AppMode.Full) OrElse (SpellLearned.ElementAsInteger("CharacterLevel") < 6) Then

                                    Spell = New Spell
                                    Spell.ClassName = SpellLearned.Element("Class")
                                    Spell.ClassGuid = SpellLearned.GetFKGuid("Class")
                                    Spell.SpellGuid = SpellLearned.GetFKGuid("Spell")
                                    Spell.SpellName = SpellLearned.Element("Spell")
                                    Spell.SpellLevel = SpellLearned.ElementAsInteger("Level")
                                    Spell.SourceName = SpellLearned.Element("Source")
                                    Spell.SourceKey = SpellLearned.GetFKGuid("Source")
                                    Spell.TakeAtLevel(SpellLearned.ElementAsInteger("CharacterLevel"))
                                    Spell.IsNew = False
                                    If SpellLearned.Element("AutoObtained") = "Yes" Then Spell.AutoObtained = True
                                    Spell.SpellObject = SpellLearned

                                    AddSpell(Spell)

                                End If
                            Next

                        Case Objects.SpellLikeAbilityFolderType
                            'load the existing spell like abilities
                            For Each SpellLikeAbility As Objects.ObjectData In ClassSpellFolder.ChildrenOfType(Objects.SpellLikeAbilityTakenType)
                                If (General.Mode = AppMode.Full) OrElse (SpellLikeAbility.ElementAsInteger("CharacterLevel") < 6) Then
                                    _Character.ExistingSpellLikeAbilities.Add(SpellLikeAbility)
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

                'get the spell casters
                Dim SpellCasters As New Hashtable
                Dim ClassKey As Objects.ObjectKey
                Dim ClassInfo As Rules.CharacterClass

                'get racial caster
                If _Character.RaceObject.Element("CasterType") = "Spellcaster" Then
                    ClassKey = _Character.RaceObject.GetFKGuid("CasterSource")
                    If Not ClassKey.IsEmpty Then
                        ClassInfo = _Character.CharacterClasses(ClassKey)
                        If ClassInfo.IsCaster Then SpellCasters.Add(ClassKey, ClassInfo)
                    End If
                End If

                'get class casters
                For Each ClassKey In _Character.CharacterClassKeys
                    ClassInfo = _Character.CharacterClasses(ClassKey)
                    If ClassInfo.IsCaster Then SpellCasters.Item(ClassKey) = ClassInfo
                Next

                If SpellCasters.Count > 0 Then

                    'make sure the magic folder has been made
                    _Character.MagicFolderSave()

                    'create a list and settings folder for each caster class if it does not already exist
                    Dim ClassSpellListFolders As Objects.ObjectDataCollection = _Character.MagicFolder.ChildrenOfType(Objects.ClassSpellListFolderType)
                    Dim ClassSpellSettingFolders As Objects.ObjectDataCollection = _Character.MagicFolder.ChildrenOfType(Objects.ClassSpellSettingsFolderType)

                    Dim NewFolder As New Objects.ObjectData
                    For Each ClassKey In SpellCasters.Keys
                        Dim ClassObject As Objects.ObjectData = DirectCast(SpellCasters.Item(ClassKey), Rules.CharacterClass).ClassObj

                        'list folder
                        If Not ClassSpellListFolders.ContainsFK("Class", ClassKey) Then
                            NewFolder.Clear()
                            NewFolder.Name = ClassObject.Name & " Spell List"
                            NewFolder.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                            NewFolder.Type = Objects.ClassSpellListFolderType
                            NewFolder.ParentGUID = _Character.MagicFolder.ObjectGUID
                            NewFolder.FKElement("Class", ClassObject.Name, "Name", ClassKey)
                            NewFolder.Save()
                            ClassSpellListFolders.Add(NewFolder)
                        End If

                        'settings folder
                        If Not ClassSpellSettingFolders.ContainsFK("Class", ClassKey) Then
                            NewFolder.Clear()
                            NewFolder.Name = ClassObject.Name & " Caster Information"
                            NewFolder.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                            NewFolder.Type = Objects.ClassSpellSettingsFolderType
                            NewFolder.ParentGUID = _Character.MagicFolder.ObjectGUID
                            NewFolder.FKElement("Class", ClassObject.Name, "Name", ClassKey)
                            NewFolder.Save()
                            ClassSpellSettingFolders.Add(NewFolder)
                        End If

                        ClassObject.Clear()
                    Next

                    'spells
                    For Each Item As System.Collections.DictionaryEntry In _Spells

                        'get the class library
                        Dim ClassLibrary As Library = DirectCast(Item.Value, Library)

                        'get the class spell list folder
                        Dim ClassSpellFolder As Objects.ObjectData = ClassSpellListFolders.Item("Class", New Objects.ObjectKey(CStr(Item.Key)))

                        'get the spells
                        For Each Data As Library.LibraryData In ClassLibrary.ItemData()
                            Dim Spell As Rules.Spell = DirectCast(Data.Data, Rules.Spell)

                            'if this spells has been removed - delete the object if it exists
                            If Spell.LevelReplaced > 0 Then
                                If Spell.IsNew = False Then
                                    Spell.IsNew = True
                                    Spell.SpellObject.Delete()
                                    UpdateSpell(Spell)
                                End If
                            Else
                                If Spell.IsNew Then
                                    Spell.IsNew = False
                                    Spell.SpellObject = Spell.CreateObject(_Character, ClassSpellFolder.ObjectGUID)
                                    If Spell.SpellObject.ObjectGUID.IsNotEmpty Then
                                        Spell.SpellObject.Save()
                                    End If
                                    UpdateSpell(Spell)
                                Else
                                    'update existing spell
                                    If Spell.SpellObject.ObjectGUID.IsNotEmpty Then
                                        Spell.SpellObject.Element("CharacterLevel") = Spell.LevelTaken.ToString
                                        Spell.SpellObject.Element("Level") = Spell.SpellLevel.ToString
                                    End If
                                End If
                            End If
                        Next
                    Next

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'takes a spell for the given class at the specifed level
        Public Sub TakeSpell(ByVal SpellKey As Objects.ObjectKey, ByVal SpellName As String, ByVal ClassKey As Objects.ObjectKey, ByVal ClassName As String, ByVal SourceKey As Objects.ObjectKey, ByVal SourceName As String, ByVal SpellLevel As Integer, ByVal CharacterLevel As Integer, Optional ByVal AutoObtained As Boolean = False)
            Try
                If SpellKey.IsEmpty OrElse ClassKey.IsEmpty OrElse SourceKey.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Attempt to add a spell with no Class/Spell/Source Guid")

                'see if we have it already
                If Me.Contains(ClassKey, SpellKey, SourceKey) Then

                    'get the spell structure
                    Dim Spell As Spell = GetSpell(ClassKey, SpellKey, SourceKey)
                    Spell.TakeAtLevel(CharacterLevel)
                    AddSpell(Spell)

                Else
                    'create the new spell
                    Dim NewSpell As New Spell
                    NewSpell.SpellGuid = SpellKey
                    NewSpell.SpellName = SpellName
                    NewSpell.SpellLevel = SpellLevel
                    NewSpell.TakeAtLevel(CharacterLevel)

                    NewSpell.ClassGuid = ClassKey
                    NewSpell.ClassName = ClassName

                    NewSpell.SourceKey = SourceKey
                    NewSpell.SourceName = SourceName

                    NewSpell.IsNew = True

                    If AutoObtained = True Then
                        NewSpell.AutoObtained = True
                    End If

                    'add it to the character
                    AddSpell(NewSpell)
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'updates the spell in this collection with the one given - need because the spell structure is a value type
        Public Sub UpdateSpell(ByVal Spell As Rules.Spell)
            Try
                If Spell.SpellGuid.IsEmpty OrElse Spell.ClassGuid.IsEmpty OrElse Spell.SourceKey.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Attempt to update a spell with no Class/Spell/Source Guid")

                'add it to the character
                AddSpell(Spell)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'updates a character's spells with spells from the given source
        Public Sub TakeSpellsFromSource(ByVal ClassKey As Objects.ObjectKey, ByVal ListSourceKey As Objects.ObjectKey, ByVal AutoObtained As Boolean, ByVal SyncMode As Boolean, Optional ByVal RacialSpellSource As Boolean = False)
            Try
                If ClassKey.IsEmpty Or ListSourceKey.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Attempt to add a spell list with no Class or Source Guid")

                'get source object
                Dim SourceObj As New Objects.ObjectData
                SourceObj.Load(ListSourceKey)

                'get the class obj
                Dim ClassObj As Objects.ObjectData = _Character.CharacterClasses(ClassKey).ClassObj

                'get the spell list
                Dim MaxSpellLevel As Integer = GetMaxSpellLevel(ClassKey, _Character.CharacterLevel)
                Dim SpellInfoTable As ObjectHashtable = RPGXplorer.Rules.SpellList.SpellListInfo(SourceObj.ObjectGUID, 0, MaxSpellLevel)

                Dim Spells(9) As ArrayList
                For i As Integer = 0 To 9
                    Spells(i) = New ArrayList
                Next

                Dim Level As Integer
                For Each SpellInfo As SpellList.SpellInfo In SpellInfoTable.Values
                    Level = SpellInfo.LevelObject.ElementAsInteger("Level")
                    DirectCast(Spells(Level), ArrayList).Add(SpellInfo)
                Next

                'add the new spells
                Dim StartLevel, CurrentSpellLevel, OldSpellLevel As Integer
                Dim SourceObtained As Boolean

                'need to check for first level as GetMaxSpellLevel always includes racial offset
                If SyncMode OrElse _Character.FirstNewLevel = 1 Then
                    OldSpellLevel = -1
                    StartLevel = 1
                Else
                    OldSpellLevel = GetMaxSpellLevel(ClassKey, _Character.FirstNewLevel - 1)
                    StartLevel = _Character.FirstNewLevel
                End If

                For LevelCount As Integer = StartLevel To _Character.CharacterLevel

                    'if its a racial source is available right away
                    If RacialSpellSource Then SourceObtained = True

                    'do we have the source object at this level yet
                    If Not SourceObtained Then
                        Select Case SourceObj.Type

                            Case Objects.ClassType
                                If _Character.LowestClassLevel(SourceObj.ObjectGUID) <= LevelCount Then SourceObtained = True

                            Case Objects.DomainDefinitionType
                                If _Character.Domains.HasDomain(ClassKey, SourceObj.ObjectGUID, LevelCount) Then SourceObtained = True

                        End Select
                    End If

                    If SourceObtained Then
                        CurrentSpellLevel = GetMaxSpellLevel(ClassKey, LevelCount)
                        'if we gained any higher spell levels
                        If CurrentSpellLevel > OldSpellLevel Then

                            'add the spells from the new levels
                            For i As Integer = OldSpellLevel + 1 To CurrentSpellLevel

                                'get the spells at this level
                                For Each SpellInfo As SpellList.SpellInfo In Spells(i)
                                    'add them to the character if required
                                    If Not Contains(ClassKey, SpellInfo.SpellObject.ObjectGUID, ListSourceKey) Then
                                        If AutoObtained Then
                                            TakeSpell(SpellInfo.SpellObject.ObjectGUID, SpellInfo.SpellObject.Name, ClassKey, ClassObj.Name, ListSourceKey, SourceObj.Name, i, LevelCount, True)
                                        Else
                                            TakeSpell(SpellInfo.SpellObject.ObjectGUID, SpellInfo.SpellObject.Name, ClassKey, ClassObj.Name, ListSourceKey, SourceObj.Name, i, LevelCount)
                                        End If

                                    End If
                                Next

                            Next
                        End If
                        OldSpellLevel = CurrentSpellLevel
                    End If
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'check to see if the given class has his spell
        Public Function Contains(ByVal ClassKey As Objects.ObjectKey, ByVal SpellKey As Objects.ObjectKey) As Boolean
            Try

                If ClassKey.IsEmpty Or SpellKey.IsEmpty Then Return False

                'get the class spell library
                Dim ClassLibrary As Library = Me.ClassSpellLibrary(ClassKey)
                If ClassLibrary Is Nothing Then Return False

                'look for the key
                If ClassLibrary.ContainsKey(SpellKey) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'more specfic version of contains
        Public Function Contains(ByVal ClassKey As Objects.ObjectKey, ByVal SpellKey As Objects.ObjectKey, ByVal SourceKey As Objects.ObjectKey) As Boolean
            Try

                If ClassKey.IsEmpty Or SpellKey.IsEmpty Or SourceKey.IsEmpty Then Return False

                'get the class spell library
                Dim ClassLibrary As Library = Me.ClassSpellLibrary(ClassKey)
                If ClassLibrary Is Nothing Then Return False

                'look for the key
                If ClassLibrary.ContainsSubkey(SpellKey, SourceKey) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'calculate the max spell level this character can learn (or cast - if flag set)
        Public Function GetMaxSpellLevel(ByVal ClassKey As Objects.ObjectKey, ByVal CharacterLevel As Integer, Optional ByVal CastableCheck As Boolean = False) As Integer
            Try

                Dim MaxSpellLevel As Integer = -1
                'get the class information
                Dim ClassInfo As CharacterClass = _Character.CharacterClasses(ClassKey)

                If ClassInfo.IsCaster = False Then Return MaxSpellLevel

                'get the effective class level
                Dim EffectiveClassLevel As Integer = _Character.HighestClassLevelAtLevel(ClassKey, CharacterLevel).ClassLevel + PrestigeClassOffset(ClassKey, CharacterLevel) + Character.GetRacialCasterOffset(ClassKey)
                If EffectiveClassLevel < 1 Then Return MaxSpellLevel

                Dim ElementString As String = ""
                Dim SpellAbilityScore As Integer = GetSpellAbilityScore(ClassInfo, CharacterLevel)
                Dim AquisitionType As Rules.CharacterClass.AcquisitionType = ClassInfo.CasterInfo.SpellAquisition

                'if the flag is set for the "castable" spell level then we only need to check spell per day
                If CastableCheck Then
                    If AquisitionType = CharacterClass.AcquisitionType.Known Then AquisitionType = CharacterClass.AcquisitionType.Book
                End If

                Select Case AquisitionType
                    Case CharacterClass.AcquisitionType.Book, CharacterClass.AcquisitionType.List
                        For SpellLevel As Integer = 0 To (SpellAbilityScore - 10)
                            If CanCastSpellOfLevel(ClassInfo, EffectiveClassLevel, SpellLevel, SpellAbilityScore) Then
                                MaxSpellLevel = SpellLevel
                            End If
                        Next

                    Case CharacterClass.AcquisitionType.Known
                        For SpellLevel As Integer = 0 To (SpellAbilityScore - 10)
                            If ClassInfo.SpellsKnownScore(EffectiveClassLevel, SpellLevel) > 0 Then
                                If CanCastSpellOfLevel(ClassInfo, EffectiveClassLevel, SpellLevel, SpellAbilityScore) Then
                                    MaxSpellLevel = SpellLevel
                                End If
                            End If
                        Next
                End Select

                Return MaxSpellLevel

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the spell structure
        Public Function GetSpell(ByVal ClassKey As Objects.ObjectKey, ByVal SpellKey As Objects.ObjectKey, ByVal SourceKey As Objects.ObjectKey) As Spell
            Try

                If ClassKey.IsEmpty Or SpellKey.IsEmpty Or SourceKey.IsEmpty Then Return Nothing

                'get the class spells library
                Dim ClassSpellLibrary As Library = Me.ClassSpellLibrary(ClassKey)

                If ClassSpellLibrary Is Nothing Then Return Nothing

                'find the spell
                If ClassSpellLibrary.ContainsSubkey(SpellKey, SourceKey) Then
                    Return DirectCast(ClassSpellLibrary.ItemData(SpellKey, SourceKey).Data, Spell)
                End If
                Return Nothing

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'gets the class spell library
        Public Function ClassSpellLibrary(ByVal ClassKey As Objects.ObjectKey) As Library
            Try

                If ClassKey.IsEmpty = False Then
                    If _Spells.Contains(ClassKey) Then Return DirectCast(_Spells.Item(ClassKey), Library)
                End If
                Return Nothing

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Gets the score of the Primary Spell Casting Ability
        Public Function GetSpellAbilityScore(ByVal classInfo As CharacterClass, ByVal Level As Integer) As Integer
            Try
                If classInfo.IsCaster Then
                    Select Case classInfo.CasterInfo.SpellAttribute
                        Case "STR"
                            GetSpellAbilityScore = _Character.Levels(Level).STR
                        Case "DEX"
                            GetSpellAbilityScore = _Character.Levels(Level).DEX
                        Case "CON"
                            GetSpellAbilityScore = _Character.Levels(Level).CON
                        Case "INT"
                            GetSpellAbilityScore = _Character.Levels(Level).INT
                        Case "WIS"
                            GetSpellAbilityScore = _Character.Levels(Level).WIS
                        Case "CHA"
                            GetSpellAbilityScore = _Character.Levels(Level).CHA
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
                For Each SpellCasterChoice As Library.LibraryData In _Character.PrestigeSpellcasterChoices.ItemData(ClassKey)
                    If SpellCasterChoice.LevelAcquired <= CharacterLevel Then Offset += 1
                Next
                Return Offset
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'checks if a character could cast spells of the given level from the given class
        Public Function CanCastSpellOfLevel(ByVal ClassInfo As CharacterClass, ByVal ClassLevel As Integer, ByVal SpellLevel As Integer, ByVal SpellAbilityScore As Integer) As Boolean
            Try
                Dim SpellsPerDay As Integer = ClassInfo.SpellsPerDayScore(ClassLevel, SpellLevel)

                If (SpellLevel + 10) > SpellAbilityScore Then Return False

                'if they have no SPD but a high enough ability score, return true
                If ClassInfo.CasterInfo.NoSpellsPerDay = True Then Return True

                'bonus spells per day for high ability score
                Dim BonusSpellsPerDay As Integer = 0
                If ClassInfo.CasterInfo.BonusSpells = True Then
                    BonusSpellsPerDay = SpellSlots.GetBonusSpells(SpellLevel, SpellAbilityScore)
                End If

                If (SpellsPerDay > 0) OrElse (SpellsPerDay = 0 AndAlso (BonusSpellsPerDay > 0)) Then
                    Return True
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'adds new spells to a spell list caster
        Public Sub UpdateSpellListCaster(ByVal ClassKey As Objects.ObjectKey, Optional ByVal AutoObtained As Boolean = True, Optional ByVal SyncMode As Boolean = False)

            'get the class info 
            Dim Classinfo As Rules.CharacterClass = _Character.CharacterClasses(ClassKey)

            If Classinfo.CasterInfo.SpellAquisition <> CharacterClass.AcquisitionType.List Then Exit Sub

            'if we are a racial caster get all the racail spell sources now
            If Character.GetRacialCasterOffset(ClassKey) > 0 Then

                'do the racial caster class itself
                Character.Spells.TakeSpellsFromSource(Classinfo.ClassObj.ObjectGUID, Classinfo.ClassObj.ObjectGUID, AutoObtained, SyncMode, True)

                'add any additional spell sources
                Dim AdditionalSpellSources As Objects.ObjectDataCollection
                AdditionalSpellSources = Character.RaceObject.ChildrenOfType(Objects.SpellorPowerSourceType)
                For Each AdditionalSpellSource As Objects.ObjectData In AdditionalSpellSources
                    Character.Spells.TakeSpellsFromSource(Classinfo.ClassObj.ObjectGUID, AdditionalSpellSource.GetFKGuid("Source"), AutoObtained, SyncMode, True)
                Next

            Else

                'its a spell list caster type - add any spells they are due from this class
                Character.Spells.TakeSpellsFromSource(Classinfo.ClassObj.ObjectGUID, Classinfo.ClassObj.ObjectGUID, AutoObtained, SyncMode)

            End If

            'see if this class has any domains
            For Each Domain As Rules.Domain In Character.Domains.ClassDomains(Classinfo.ClassObj.ObjectGUID, Character.CharacterLevel)
                Character.Spells.TakeSpellsFromSource(Classinfo.ClassObj.ObjectGUID, Domain.DomainObj.GetFKGuid("Domain"), AutoObtained, SyncMode)
            Next

            'any prestige classes with their own spell lists
            For Each SpellCasterChoiceData As Library.LibraryData In Character.PrestigeSpellcasterChoices.ItemData(Classinfo.ClassObj.ObjectGUID)
                Dim SpellCasterChoice As Character.CharacterChoice = DirectCast(SpellCasterChoiceData.Data, Character.CharacterChoice)

                Character.Spells.TakeSpellsFromSource(Classinfo.ClassObj.ObjectGUID, SpellCasterChoice.ClassGuid, AutoObtained, SyncMode)

                'any prestige domains
                For Each Domain As Rules.Domain In Character.Domains.ClassDomains(SpellCasterChoice.ClassGuid, Character.CharacterLevel)
                    Character.Spells.TakeSpellsFromSource(Classinfo.ClassObj.ObjectGUID, Domain.DomainObj.GetFKGuid("Domain"), AutoObtained, SyncMode)
                Next
            Next

        End Sub

        'fills in the two hastables with appropriate data - used in CharacterSheetData
        Public Sub SpellSchoolTable(ByVal Specialist As Hashtable, ByVal Prohibited As Hashtable)
            Try
                'clear existing data
                Specialist.Clear()
                Prohibited.Clear()

                Dim List As ArrayList

                'get school data
                Dim Choice As Rules.Character.CharacterChoice
                For Each ItemData As Library.LibraryData In Character.Choices.ItemData
                    Choice = DirectCast(ItemData.Data, Character.CharacterChoice)
                    Select Case Choice.Type
                        Case Character.ChoiceType.SacrificedSchool
                            If Not Prohibited.ContainsKey(Choice.ClassGuid) Then
                                List = New ArrayList
                                Prohibited.Add(Choice.ClassGuid, List)
                            Else
                                List = DirectCast(Prohibited.Item(Choice.ClassGuid), ArrayList)
                            End If
                            List.Add(Choice.Data)
                        Case Character.ChoiceType.SpecailistSchool
                            If Not Specialist.ContainsKey(Choice.ClassGuid) Then
                                List = New ArrayList
                                Specialist.Add(Choice.ClassGuid, List)
                            Else
                                List = DirectCast(Specialist.Item(Choice.ClassGuid), ArrayList)
                            End If
                            List.Add(Choice.Data)
                    End Select
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'fills in the two hastables with appropriate data - used in CharacterXMLData
        Public Sub SpellSchoolXMLTable(ByVal Specialist As Hashtable, ByVal Prohibited As Hashtable)
            Try
                'clear existing data
                Specialist.Clear()
                Prohibited.Clear()

                Dim List As ArrayList

                'get school data
                Dim Choice As Rules.Character.CharacterChoice
                For Each ItemData As Library.LibraryData In Character.Choices.ItemData
                    Choice = DirectCast(ItemData.Data, Character.CharacterChoice)

                    'get data for XML output
                    Dim SchoolInfo As SpellSchoolXMLData
                    Dim SchoolDef As New Objects.ObjectData
                    SchoolDef.Load(Choice.DataGuid)
                    SchoolInfo.Name = Choice.Data
                    SchoolInfo.Description = SchoolDef.Element("Description")
                    SchoolInfo.License = SchoolDef.Element("License")
                    SchoolInfo.Sourcebook = SchoolDef.Element("Sourcebook")
                    SchoolInfo.PageNoRef = SchoolDef.Element("PageNoRef")
                    SchoolInfo.Tags = SchoolDef.Element("Tags")
                    SchoolInfo.HelpPage = SchoolDef.Element("HTML")

                    Select Case Choice.Type
                        Case Character.ChoiceType.SacrificedSchool
                            If Not Prohibited.ContainsKey(Choice.ClassGuid) Then
                                List = New ArrayList
                                Prohibited.Add(Choice.ClassGuid, List)
                            Else
                                List = DirectCast(Prohibited.Item(Choice.ClassGuid), ArrayList)
                            End If
                            List.Add(SchoolInfo)
                        Case Character.ChoiceType.SpecailistSchool
                            If Not Specialist.ContainsKey(Choice.ClassGuid) Then
                                List = New ArrayList
                                Specialist.Add(Choice.ClassGuid, List)
                            Else
                                List = DirectCast(Specialist.Item(Choice.ClassGuid), ArrayList)
                            End If
                            List.Add(SchoolInfo)
                    End Select
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'clone the class
        Public Function Clone(ByVal Character As Rules.Character) As Rules.Spells
            Try
                Dim NewSpells As New Spells(Character)

                'iterate through the class spell lists
                For Each Item As DictionaryEntry In _Spells
                    Dim OldClassSpellLibrary, NewClassSpellLibrary As Library
                    OldClassSpellLibrary = DirectCast(Item.Value, Library)
                    NewClassSpellLibrary = New Library

                    NewSpells._Spells.Add(New Objects.ObjectKey(CStr(Item.Key)), NewClassSpellLibrary)

                    'iterate through each spell taken
                    For Each LibraryData As Library.LibraryData In OldClassSpellLibrary.ItemData
                        Dim SpellTaken As Spell = DirectCast(LibraryData.Data, Spell).Clone
                        NewClassSpellLibrary.AddItemWithSubkey(SpellTaken.SpellGuid, SpellTaken.SourceKey, SpellTaken, , , True)
                    Next
                Next

                Return NewSpells

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'private - adds a spell to the collection, to do publicly use TakeSpell
        Private Sub AddSpell(ByVal Spell As Rules.Spell)
            Try

                'get the class library
                Dim ClassLibrary As Library = ClassSpellLibrary(Spell.ClassGuid)

                If ClassLibrary Is Nothing Then
                    ClassLibrary = New Library
                    _Spells.Add(Spell.ClassGuid, ClassLibrary)
                End If

                ClassLibrary.AddItemWithSubkey(Spell.SpellGuid, Spell.SourceKey, Spell, , , True)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

    'This class lets us see what spells are available to a character
    Public Class AvailableSpells

#Region "Member Variables"

        'variables
        Private Character As Rules.Character
        Private Levels As New ObjectHashtable
        Private ProhibitedSchools As New ObjectHashtable

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Try
                Me.Character = Character
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the spells and levels collections with the spells for this class
        Public Sub LoadSpells(ByVal ClassInfo As CharacterClass, ByVal Character As Character)
            Try

                'get the max spell level
                Dim MaxSpellLevel As Integer = Character.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, Me.Character.CharacterLevel)

                'get the class spell levels data
                Dim ClassSpellLevels As New AvailableSpellSources(Character, ClassInfo.ClassObj, MaxSpellLevel)
                Levels(ClassInfo.ClassObj.ObjectGUID) = ClassSpellLevels

                'get list of prohibited schools
                ProhibitedSchools.Remove(ClassInfo.ClassObj.ObjectGUID)

                Dim Choice As Rules.Character.CharacterChoice
                For Each Data As Library.LibraryData In Character.Choices.ItemData(ClassInfo.ClassObj.ObjectGUID)
                    Choice = DirectCast(Data.Data, Character.CharacterChoice)
                    Select Case Choice.Type
                        Case Character.ChoiceType.SacrificedSchool
                            If ProhibitedSchools.ContainsKey(ClassInfo.ClassObj.ObjectGUID) Then
                                DirectCast(ProhibitedSchools.Item(ClassInfo.ClassObj.ObjectGUID), Hashtable).Item(Choice.Data) = Choice
                            Else
                                Dim TempTable As New Hashtable
                                TempTable.Item(Choice.Data) = Choice
                                ProhibitedSchools.Add(ClassInfo.ClassObj.ObjectGUID, TempTable)
                            End If
                    End Select
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'Gives a list of available spells for the given slot, and colours them appropriately
        Public Function AvailableSpellsList(ByVal Slot As SpellSlot, ByVal ClassInfo As CharacterClass) As ArrayList
            Try
                General.SetWaitCursor()

                Dim LevelObj As Objects.ObjectData
                Dim SpellList As New ArrayList
                Dim ClassSpellsKnown As Library
                Dim AvailableSpells As New ArrayList

                Dim ClassSpellLevels As AvailableSpellSources

                Select Case Slot.SlotType

                    'spells less than or equal to the slots level
                    Case SpellSlotType.Book_Type

                        ClassSpellLevels = DirectCast(Levels(ClassInfo.ClassObj.ObjectGUID), AvailableSpellSources)
                        For Each SpellListData As SpellListData In ClassSpellLevels.SpellLevelSources(Slot.CharacterLevel)
                            For Each LevelObj In SpellListData.SpellList
                                If LevelObj.ElementAsInteger("Level") <= Slot.MaxSpellLevel Then
                                    AvailableSpells.Add(CreateAvailableSpell(LevelObj.ParentGUID, SpellListData.SourceName, SpellListData.SourceKey, SpellListData.SourceType, LevelObj.ElementAsInteger("Level")))
                                End If
                            Next
                        Next

                        'spells equal to the slots level
                    Case SpellSlotType.Known_Type

                        ClassSpellLevels = DirectCast(Levels(ClassInfo.ClassObj.ObjectGUID), AvailableSpellSources)
                        For Each SpellListData As SpellListData In ClassSpellLevels.SpellLevelSources(Slot.CharacterLevel)
                            For Each LevelObj In SpellListData.SpellList
                                If LevelObj.ElementAsInteger("Level") = Slot.MaxSpellLevel Then
                                    AvailableSpells.Add(CreateAvailableSpell(LevelObj.ParentGUID, SpellListData.SourceName, SpellListData.SourceKey, SpellListData.SourceType, LevelObj.ElementAsInteger("Level")))
                                End If
                            Next
                        Next

                    Case SpellSlotType.Replace_Start_Type
                        'Show the spells the character can replace

                        ClassSpellsKnown = Character.Spells.ClassSpellLibrary(ClassInfo.ClassObj.ObjectGUID)
                        If Not ClassSpellsKnown Is Nothing Then

                            Dim SpellKnown As Spell

                            For Each SpellItemData As Library.LibraryData In ClassSpellsKnown.ItemData()
                                SpellKnown = DirectCast(SpellItemData.Data, Spell)
                                'if its not yet been replaced, and its spell level is less than or equal to the slot level
                                If (SpellKnown.CanBeReplaced(Slot.CharacterLevel)) And (SpellKnown.SpellLevel <= Slot.MaxSpellLevel) Then
                                    AvailableSpells.Add(CreateAvailableSpell(SpellKnown.SpellGuid, SpellKnown.SourceName, SpellKnown.SourceKey, SpellSourceType.Unknown, SpellKnown.SpellLevel))
                                End If
                            Next

                        End If

                    Case SpellSlotType.Replace_In_Progres_Type

                        ClassSpellLevels = DirectCast(Levels(ClassInfo.ClassObj.ObjectGUID), AvailableSpellSources)
                        For Each SpellListData As SpellListData In ClassSpellLevels.SpellLevelSources(Slot.CharacterLevel)
                            For Each LevelObj In SpellListData.SpellList
                                If LevelObj.ElementAsInteger("Level") <= Slot.ReplaceLevel Then
                                    AvailableSpells.Add(CreateAvailableSpell(LevelObj.ParentGUID, SpellListData.SourceName, SpellListData.SourceKey, SpellListData.SourceType, LevelObj.ElementAsInteger("Level")))
                                End If
                            Next
                        Next

                    Case Else
                        General.ShowErrorDialog("This slot type not yet developed")

                End Select

                Dim AvailableSpell As AvailableSpell
                Dim ProhibitedTable As Hashtable = CType(ProhibitedSchools.Item(ClassInfo.ClassObj.ObjectGUID), Hashtable)
                If ProhibitedTable Is Nothing Then ProhibitedTable = New Hashtable

                For Each AvailableSpell In AvailableSpells

                    'Check the spell status
                    AvailableSpell.Status = AvailableSpellStatus.Allowed

                    If Slot.SlotType <> SpellSlotType.Replace_Start_Type Then
                        If Character.Spells.Contains(ClassInfo.ClassObj.ObjectGUID, AvailableSpell.SpellGuid, AvailableSpell.SourceGuid) Then
                            If Not Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, AvailableSpell.SpellGuid, AvailableSpell.SourceGuid).AvailableAtLevel(Slot.CharacterLevel) Then
                                AvailableSpell.Status = AvailableSpellStatus.AlreadyHave
                            End If
                        End If
                    End If

                    'check for prohibited schools
                    If ProhibitedTable.Contains(AvailableSpell.SpellSchool) Then AvailableSpell.Status = AvailableSpellStatus.SacrificedSchool

                    SpellList.Add(AvailableSpell)
                Next

                General.SetNormalCursor()

                Return SpellList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'creates an availablespell structure
        Private Function CreateAvailableSpell(ByVal SpellKey As Objects.ObjectKey, ByVal SourceName As String, ByVal SourceKey As Objects.ObjectKey, ByVal SourceType As SpellSourceType, ByVal SpellLevel As Integer) As AvailableSpell
            Try
                Dim AvailableSpell As AvailableSpell
                Dim SpellObj As Objects.ObjectData = Rules.SpellList.SpellDefinition(SpellKey)

                With AvailableSpell
                    .SpellName = SpellObj.Name
                    .SpellGuid = SpellKey

                    .SourceName = SourceName
                    .SourceGuid = SourceKey
                    .SourceType = SourceType

                    .SpellLevel = SpellLevel
                    .SpellSchool = SpellObj.Element("School")
                    .HTML = SpellObj.HTML
                End With

                Return AvailableSpell

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Is this level a prestige type which has advanced in a previous spellcasting level
        Private Function CheckPrestige(ByVal ClassInfo As Rules.CharacterClass, ByVal Level As Character.Level) As Boolean
            Dim SpellcasterChoice As Rules.Character.CharacterChoice
            Dim ClassChoices As ArrayList

            'If it is a Prestige Class then check for the choice object
            ClassChoices = Character.PrestigeSpellcasterChoices.ItemData(ClassInfo.ClassObj.ObjectGUID)

            For Each TempData As Library.LibraryData In ClassChoices
                SpellcasterChoice = DirectCast(TempData.Data, Rules.Character.CharacterChoice)
                If SpellcasterChoice.LevelAcquired = Level.CharacterLevel Then Return True
            Next

            Return False

        End Function

        'Gets the available spells slots for the given class, make sure you have loaded the given class before calling this
        Public Function AvailableSpellSlots(ByVal ClassInfo As CharacterClass) As ArrayList
            Dim StartLevel As Integer
            Dim FirstClassLevel As Character.Level
            Dim Slot As New SpellSlot
            Dim Slots As New ArrayList
            Dim ExtraFirstLevelSpells As Integer
            Dim MaxSpellLevel As Integer
            'Dim ClassSpells As Hashtable
            'Dim Spell As Rules.Spell

            Dim PrestigeClassOffset As Integer
            Dim RacialOffset As Integer

            Try

                StartLevel = Character.FirstNewLevel
                PrestigeClassOffset = 0
                RacialOffset = Character.GetRacialCasterOffset(ClassInfo.ClassObj.ObjectGUID)

                Select Case ClassInfo.CasterInfo.SpellAquisition

                    Case CharacterClass.AcquisitionType.Book

                        'Find out if the first level is being added in this class, for the bonus initial slots
                        FirstClassLevel = Character.LowestClassLevelInfo(ClassInfo.ClassObj.ObjectGUID)

                        'if this is the first level and we are a racial caster - we need to add the racial spells now
                        If RacialOffset > 0 And StartLevel = 1 Then

                            'Add slots for all the 0-level spells
                            Dim ClassSpellLevels As AvailableSpellSources = DirectCast(Levels(ClassInfo.ClassObj.ObjectGUID), AvailableSpellSources)
                            Dim ProhibitedTable As Hashtable = CType(ProhibitedSchools.Item(ClassInfo.ClassObj.ObjectGUID), Hashtable)
                            If ProhibitedTable Is Nothing Then ProhibitedTable = New Hashtable
                            For Each SpellListData As SpellListData In ClassSpellLevels.SpellLevelSources(1)
                                For Each Level As Objects.ObjectData In SpellListData.SpellList
                                    Dim SpellObj As Objects.ObjectData = Rules.SpellList.SpellDefinition(Level.ParentGUID)
                                    If Not ProhibitedTable.Contains(SpellObj.Element("School")) Then

                                        If Level.ElementAsInteger("Level") = 0 Then
                                            Slot.Clear()
                                            Slot.MaxSpellLevel = 0
                                            Slot.SpellLevel = 0
                                            Slot.CharacterLevel = 1
                                            Slot.SpellGuid = Level.ParentGUID
                                            Slot.SpellName = Rules.SpellList.SpellDefinition(Level.ParentGUID).Name
                                            Slot.SlotType = SpellSlotType.Book_Type
                                            Slot.Fixed = True

                                            'Add slot to collection
                                            Slots.Add(Slot)

                                            'Add the spell to the character
                                            Character.Spells.TakeSpell(Slot.SpellGuid, Slot.SpellName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Slot.SpellLevel, Slot.CharacterLevel)
                                        End If
                                    End If
                                Next
                            Next

                            'add the first level spells
                            ExtraFirstLevelSpells = Rules.AbilityScores.AbilityScore((Character.Spells.GetSpellAbilityScore(ClassInfo, 1))).Modifier
                            If ExtraFirstLevelSpells < 0 Then ExtraFirstLevelSpells = 0
                            For n As Integer = 1 To (ClassInfo.CasterInfo.FirstLevelSpells + ExtraFirstLevelSpells)
                                Slot.Clear()
                                Slot.MaxSpellLevel = 1
                                Slot.CharacterLevel = 1
                                Slot.Fixed = False

                                'Add slot to collection
                                Slot.SlotType = SpellSlotType.Book_Type
                                Slots.Add(Slot)
                            Next

                            'set start level for next slots                        
                            StartLevel = 2

                            'add in the rest of the racial slots
                            Dim SpellAbilityScore As Integer = Character.Spells.GetSpellAbilityScore(ClassInfo, 1)
                            For RacialCasterClassLevel As Integer = StartLevel To RacialOffset

                                MaxSpellLevel = -1
                                For SpellLevel As Integer = 0 To Math.Min((SpellAbilityScore - 10), 9)
                                    If Character.Spells.CanCastSpellOfLevel(ClassInfo, RacialCasterClassLevel, SpellLevel, SpellAbilityScore) Then
                                        MaxSpellLevel = SpellLevel
                                    End If
                                Next

                                If MaxSpellLevel > 0 Then
                                    Slot.Clear()
                                    Slot.MaxSpellLevel = MaxSpellLevel
                                    Slot.CharacterLevel = 1
                                    Slot.Fixed = False
                                    Slot.SlotType = SpellSlotType.Book_Type

                                    'Add slot to collection
                                    For count As Integer = 1 To ClassInfo.CasterInfo.PerLevelSpells
                                        Slots.Add(Slot)
                                    Next
                                End If
                            Next

                            'either not a racial caster or not adding level 1 
                        ElseIf (FirstClassLevel.CharacterLevel >= StartLevel) AndAlso (Not RacialOffset > 0) Then

                            'Add slots for all the 0-level spells
                            Dim ClassSpellLevels As AvailableSpellSources = DirectCast(Levels(ClassInfo.ClassObj.ObjectGUID), AvailableSpellSources)
                            Dim ProhibitedTable As Hashtable = CType(ProhibitedSchools.Item(ClassInfo.ClassObj.ObjectGUID), Hashtable)
                            If ProhibitedTable Is Nothing Then ProhibitedTable = New Hashtable
                            For Each SpellListData As SpellListData In ClassSpellLevels.SpellLevelSources(FirstClassLevel.CharacterLevel)
                                For Each Level As Objects.ObjectData In SpellListData.SpellList
                                    Dim SpellObj As Objects.ObjectData = Rules.SpellList.SpellDefinition(Level.ParentGUID)
                                    If Not ProhibitedTable.Contains(SpellObj.Element("School")) Then

                                        If Level.ElementAsInteger("Level") = 0 Then
                                            Slot.Clear()
                                            Slot.MaxSpellLevel = 0
                                            Slot.SpellLevel = 0
                                            Slot.CharacterLevel = FirstClassLevel.CharacterLevel
                                            Slot.SpellGuid = Level.ParentGUID
                                            Slot.SpellName = Rules.SpellList.SpellDefinition(Level.ParentGUID).Name
                                            Slot.SlotType = SpellSlotType.Book_Type
                                            Slot.Fixed = True

                                            'Add slot to collection
                                            Slots.Add(Slot)

                                            'Add the spell to the character
                                            Character.Spells.TakeSpell(Slot.SpellGuid, Slot.SpellName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Slot.SpellLevel, Slot.CharacterLevel)
                                        End If
                                    End If
                                Next
                            Next

                            'add the first level spells
                            ExtraFirstLevelSpells = Rules.AbilityScores.AbilityScore((Character.Spells.GetSpellAbilityScore(ClassInfo, 1))).Modifier
                            If ExtraFirstLevelSpells < 0 Then ExtraFirstLevelSpells = 0
                            For n As Integer = 1 To (ClassInfo.CasterInfo.FirstLevelSpells + ExtraFirstLevelSpells)
                                Slot.Clear()
                                Slot.MaxSpellLevel = 1
                                Slot.CharacterLevel = FirstClassLevel.CharacterLevel
                                Slot.Fixed = False

                                'Add slot to collection
                                Slot.SlotType = SpellSlotType.Book_Type
                                Slots.Add(Slot)
                            Next

                            StartLevel = FirstClassLevel.CharacterLevel + 1

                        Else

                            'Workout the current offset
                            PrestigeClassOffset = Character.Spells.PrestigeClassOffset(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1)

                        End If

                        'Continue through the levels, adding slots per level
                        Dim TempLevel As Rules.Character.Level
                        Dim PresitgeExistingSpellcasterClass As Boolean

                        For n As Integer = StartLevel To Character.CharacterLevel
                            TempLevel = Character.Levels(n)
                            PresitgeExistingSpellcasterClass = CheckPrestige(ClassInfo, TempLevel)

                            If PresitgeExistingSpellcasterClass Then
                                PrestigeClassOffset += 1
                            End If

                            If (TempLevel.ClassGuid.Equals(ClassInfo.ClassObj.ObjectGUID)) OrElse (PresitgeExistingSpellcasterClass) Then

                                'If they can at least learn a level 1 spell
                                MaxSpellLevel = Character.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, n)
                                If MaxSpellLevel > 0 Then
                                    Slot.Clear()
                                    Slot.MaxSpellLevel = MaxSpellLevel
                                    Slot.CharacterLevel = n
                                    Slot.Fixed = False
                                    Slot.SlotType = SpellSlotType.Book_Type

                                    'Add slot to collection
                                    For count As Integer = 1 To ClassInfo.CasterInfo.PerLevelSpells
                                        Slots.Add(Slot)
                                    Next

                                End If
                            End If
                        Next

                    Case CharacterClass.AcquisitionType.Known
                        'need to check every level - incase of MaxSpellLevel restricting slots

                        Dim PreviousSpellsKnown(9) As Integer
                        Dim CurrentSpellsKnown(9) As Integer

                        '''''''''''''''find starting point for main loop

                        If StartLevel > 1 Then
                            'this is not the first time through the wizard
                            If RacialOffset > 0 Then
                                'this is a racial caster
                                PrestigeClassOffset = Character.Spells.PrestigeClassOffset(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1)
                                PreviousSpellsKnown = GetSpellsKnown(ClassInfo, StartLevel - 1, 0, PrestigeClassOffset, RacialOffset)
                            Else
                                'this is not a racial caster
                                If FirstClassLevel.CharacterLevel >= StartLevel Then
                                    'the first class level taken is not the first new level
                                    StartLevel = FirstClassLevel.CharacterLevel
                                Else
                                    'a caster class level was taken before (as we are not a racial caster -> there must have been a class level -> characterlevel will not be 0)
                                    PrestigeClassOffset = Character.Spells.PrestigeClassOffset(ClassInfo.ClassObj.ObjectGUID, StartLevel - 1)
                                    PreviousSpellsKnown = GetSpellsKnown(ClassInfo, StartLevel - 1, 0, PrestigeClassOffset)
                                End If
                            End If
                        Else
                            'this is first run through wizard
                            If Not RacialOffset > 0 Then
                                'this is not a racial caster
                                If FirstClassLevel.CharacterLevel >= StartLevel Then
                                    'the first class level taken is not the first new level
                                    StartLevel = FirstClassLevel.CharacterLevel
                                End If
                            End If
                        End If

                        ''''''''''''''''''''''''''''''''''''''''''''''''''''

                        'add levels                        
                        Dim TempLevel As Rules.Character.Level
                        Dim PresitgeExistingSpellcasterClass As Boolean

                        'this marker reports the last known CHARACTER level of when this class was chosen
                        Dim LastKnownClassLevel As Integer = 0

                        For n As Integer = StartLevel To Character.CharacterLevel

                            'get the level info
                            TempLevel = Character.Levels(n)

                            'check if this class taken this level is a prestige advancement for this caster type
                            PresitgeExistingSpellcasterClass = CheckPrestige(ClassInfo, TempLevel)
                            If PresitgeExistingSpellcasterClass Then
                                PrestigeClassOffset += 1
                            End If

                            'if the class taken this level is the caster class - update LastKnownClassLevel
                            If Character.Levels(n).ClassGuid.Equals(ClassInfo.ClassObj.ObjectGUID) Then LastKnownClassLevel = n

                            'LastKnownClass is passed by ref
                            CurrentSpellsKnown = GetSpellsKnown(ClassInfo, n, LastKnownClassLevel, PrestigeClassOffset, RacialOffset)


                            For SpellLevel As Integer = 0 To 9
                                Dim NewSlots As Integer

                                NewSlots = CurrentSpellsKnown(SpellLevel) - PreviousSpellsKnown(SpellLevel)

                                For j As Integer = 1 To NewSlots
                                    Slot.Clear()
                                    Slot.MaxSpellLevel = SpellLevel
                                    Slot.CharacterLevel = n
                                    Slot.Fixed = False
                                    Slot.SlotType = SpellSlotType.Known_Type

                                    'Add slot to collection
                                    Slots.Add(Slot)
                                Next
                            Next

                            PreviousSpellsKnown = CurrentSpellsKnown

                            'If the level was one of this class, check for replace spell objects
                            If LastKnownClassLevel = n Then
                                'Add the slots for replacing previous spells
                                Dim ReplaceObj As Objects.ObjectData
                                For Each ReplaceObj In ClassInfo.ClassLevel(n).ChildrenOfType(Objects.ReplaceKnownSpellType)
                                    MaxSpellLevel = Character.Spells.GetMaxSpellLevel(ClassInfo.ClassObj.ObjectGUID, n) - 2
                                    If MaxSpellLevel >= 0 Then
                                        Slot.Clear()
                                        Slot.MaxSpellLevel = MaxSpellLevel
                                        Slot.CharacterLevel = n
                                        Slot.Fixed = False
                                        Slot.SlotType = SpellSlotType.Replace_Start_Type

                                        'Add slot to collection
                                        Slots.Add(Slot)
                                    End If
                                Next
                            End If

                        Next

                End Select

                Return Slots

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Returns an integer array indexed from 0 to 9, each index representing a spell level and contains the number of spells known at this level.
        Private Function GetSpellsKnown(ByVal ClassInfo As CharacterClass, ByVal Level As Integer, Optional ByRef LastKnowClassLevel As Integer = 0, Optional ByVal PrestigeOffset As Integer = 0, Optional ByVal RacialOffset As Integer = 0) As Integer()
            Try
                Dim SpellsKnownObject As Objects.ObjectData
                Dim SpellsPerDayObject As Objects.ObjectData
                Dim ElementString As String
                Dim SpellAbilityScore As Integer
                Dim MaxSpellLevel As Integer
                Dim LevelInfo As Character.Level
                ReDim GetSpellsKnown(9)

                If LastKnowClassLevel = 0 Then
                    LevelInfo = Character.HighestClassLevelAtLevel(ClassInfo.ClassObj.ObjectGUID, Level)
                    LastKnowClassLevel = LevelInfo.CharacterLevel
                Else
                    LevelInfo = Character.Levels(LastKnowClassLevel)
                End If


                If LevelInfo.CharacterLevel = 0 AndAlso PrestigeOffset = 0 AndAlso RacialOffset = 0 Then
                    Return GetSpellsKnown
                End If

                SpellsKnownObject = ClassInfo.SpellsKnownObject(LevelInfo.ClassLevel + PrestigeOffset + RacialOffset)
                SpellsPerDayObject = ClassInfo.SpellsPerDayObject(LevelInfo.ClassLevel + PrestigeOffset + RacialOffset)
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

                            If Character.Spells.CanCastSpellOfLevel(ClassInfo, LevelInfo.ClassLevel + PrestigeOffset + RacialOffset, SpellLevel, SpellAbilityScore) Then
                                GetSpellsKnown.SetValue(SpellsKnownObject.ElementAsInteger(ElementString), SpellLevel)
                            End If

                        End If
                    End If

                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Private Sub AddSpellBookSpells(ByVal Slots As ArrayList, ByVal ClassSpellLevels As AvailableSpellSources, ByVal ClassInfo As CharacterClass, ByVal ProhibitedTable As Hashtable, ByVal CharacterLevel As Integer)

            For Each SpellListData As SpellListData In ClassSpellLevels.SpellLevelSources(CharacterLevel)
                Dim Slot As New SpellSlot

                For Each Level As Objects.ObjectData In SpellListData.SpellList
                    Dim SpellObj As Objects.ObjectData = Rules.SpellList.SpellDefinition(Level.ParentGUID)
                    If Not ProhibitedTable.Contains(SpellObj.Element("School")) Then

                        If Level.ElementAsInteger("Level") = 0 Then
                            Slot.Clear()
                            Slot.MaxSpellLevel = 0
                            Slot.SpellLevel = 0
                            Slot.CharacterLevel = CharacterLevel
                            Slot.SpellGuid = Level.ParentGUID
                            Slot.SpellName = Rules.SpellList.SpellDefinition(Level.ParentGUID).Name
                            Slot.SlotType = SpellSlotType.Book_Type
                            Slot.Fixed = True

                            'Add slot to collection
                            Slots.Add(Slot)

                            'Add the spell to the character
                            Character.Spells.TakeSpell(Slot.SpellGuid, Slot.SpellName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Slot.SpellLevel, Slot.CharacterLevel)
                        End If
                    End If
                Next
            Next

        End Sub


    End Class

    'holds information on all the different spell sources that a specfic class has access to
    Public Class AvailableSpellSources

#Region "Member Variables"

        Private Levels As ArrayList

#End Region

        'constructor
        Public Sub New(ByVal Character As Character, ByVal ClassObject As Objects.ObjectData, ByVal MaxSpellLevel As Integer)
            Try
                Dim SpellListData As SpellListData
                Levels = New ArrayList

                'if this is a racial caster - check for additional spell sources
                If Character.GetRacialCasterOffset(ClassObject.ObjectGUID) > 0 Then
                    Dim AdditionalSpellSources As Objects.ObjectDataCollection
                    AdditionalSpellSources = Character.RaceObject.ChildrenOfType(Objects.SpellorPowerSourceType)
                    For Each AdditionalSpellSource As Objects.ObjectData In AdditionalSpellSources
                        SpellListData = New SpellListData(AdditionalSpellSource.Name, AdditionalSpellSource.GetFKGuid("Source"), Rules.SpellList.SpellList(AdditionalSpellSource.GetFKGuid("Source"), 0, MaxSpellLevel), 1, SpellSourceType.RacialAdditional)
                        Levels.Add(SpellListData)
                    Next

                    'get the class level
                    SpellListData = New SpellListData(ClassObject.Name, ClassObject.ObjectGUID, Rules.SpellList.SpellList(ClassObject.ObjectGUID, 0, MaxSpellLevel), 1, SpellSourceType.Class)
                    Levels.Add(SpellListData)

                Else

                    'get the class level
                    SpellListData = New SpellListData(ClassObject.Name, ClassObject.ObjectGUID, Rules.SpellList.SpellList(ClassObject.ObjectGUID, 0, MaxSpellLevel), Character.LowestClassLevel(ClassObject.ObjectGUID), SpellSourceType.Class)
                    Levels.Add(SpellListData)

                End If

                'get any domian levels
                For Each Domain As Rules.Domain In Character.Domains.ClassDomains(ClassObject.ObjectGUID, Character.CharacterLevel)
                    SpellListData = New SpellListData(Domain.DomainObj.Name, Domain.DomainObj.GetFKGuid("Domain"), Rules.SpellList.SpellList(Domain.DomainObj.GetFKGuid("Domain"), 0, MaxSpellLevel), Domain.DomainObj.ElementAsInteger("LevelAcquired"), SpellSourceType.Domain)
                    Levels.Add(SpellListData)
                Next

                'get all the prestige classes and levels they were taken
                Dim PrestigeCasters As New OneKeyList
                For Each SpellCasterChoiceData As Library.LibraryData In Character.PrestigeSpellcasterChoices.ItemData(ClassObject.ObjectGUID)
                    Dim SpellCasterChoice As Character.CharacterChoice
                    SpellCasterChoice = DirectCast(SpellCasterChoiceData.Data, Character.CharacterChoice)
                    PrestigeCasters.Add(SpellCasterChoice.ClassGuid, SpellCasterChoice.LevelAcquired)
                Next

                For Each PrestigeClassKey As Objects.ObjectKey In PrestigeCasters.Keys
                    Dim PrestigeClassInfo As CharacterClass = Character.CharacterClasses(PrestigeClassKey)
                    Dim ClassLevels As ArrayList = PrestigeCasters.Item(PrestigeClassKey)

                    SpellListData = New SpellListData(PrestigeClassInfo.ClassObj.Name, PrestigeClassKey, Rules.SpellList.SpellList(PrestigeClassKey, 0, MaxSpellLevel), ClassLevels, SpellSourceType.PrestigeClass)
                    Levels.Add(SpellListData)

                    'check for any domains the prestige class may have
                    For Each Domain As Rules.Domain In Character.Domains.ClassDomains(PrestigeClassKey, Character.CharacterLevel)
                        Dim DomainLevels As New ArrayList

                        For Each Level As Integer In ClassLevels
                            If Character.Domains.HasDomain(PrestigeClassKey, Domain.DomainObj.GetFKGuid("Domain"), Level) Then
                                DomainLevels.Add(Level)
                            End If
                        Next

                        SpellListData = New SpellListData(Domain.DomainObj.Name, Domain.DomainObj.GetFKGuid("Domain"), Rules.SpellList.SpellList(Domain.DomainObj.GetFKGuid("Domain"), 0, MaxSpellLevel), DomainLevels, SpellSourceType.PrestigeDomain)
                        Levels.Add(SpellListData)
                    Next
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'returns the SpellListDatas that are available at the given level
        Public Function SpellLevelSources(ByVal CharacterLevel As Integer) As ArrayList
            Try

                Dim SpellListDataItems As New ArrayList

                'see what sources are in the hashtable - and if we have them at the given level
                For Each SpellListData As SpellListData In Levels
                    If SpellListData.IsAvailable(CharacterLevel) Then
                        SpellListDataItems.Add(SpellListData)
                    End If
                Next

                Return SpellListDataItems

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
