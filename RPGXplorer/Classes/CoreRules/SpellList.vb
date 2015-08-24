Option Explicit On 
Option Strict On

Imports RPGXplorer.Objects
Imports System.Xml

Namespace Rules

    Public Class SpellList

#Region "Enumerations"

        Enum SpellListOperationMode
            Character
            Definition
        End Enum

#End Region

#Region "Structures"

        Public Structure SpellInfo
            Public SpellObject As ObjectData
            Public LevelObject As ObjectData
        End Structure

#End Region

#Region "Properties"

        Public Shared ReadOnly Property SpellDefinition(ByVal Key As Objects.ObjectKey) As Objects.ObjectData
            Get
                Return DirectCast(Caches.Spells.Item(Key), Objects.ObjectData)
            End Get
        End Property

#End Region

        'return the spell levels for the given spell list holder e.g. Class, Domain, Category
        Public Shared Function SpellList(ByVal DefinitionKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                'get all the spell level objects
                Return Objects.GetObjectsByXPath(XML.DBTypes.Spells, "/RPGXplorerDatabase/RPGXplorerObject[*/@FK='" & DefinitionKey.ToString & "']")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the spell levels for the given spell list holder e.g. Class, Domain, Category and only spells between the given levels
        Public Shared Function SpellList(ByVal DefinitionKey As Objects.ObjectKey, ByVal StartLevel As Integer, ByVal EndLevel As Integer) As Objects.ObjectDataCollection
            Try
                'get all the spell level objects
                Return Objects.GetObjectsByXPath(XML.DBTypes.Spells, "/RPGXplorerDatabase/RPGXplorerObject[*/@FK='" & DefinitionKey.ToString & "' and  Level >=" & StartLevel.ToString & " and Level <=" & EndLevel.ToString & "]")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the inherited spell levels for the given spell list holder e.g. Class, Domain, Category
        Public Shared Function InheritedSpellList(ByVal DefinitionKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                'get all the spell level objects
                Return Objects.GetObjectsByXPath(XML.DBTypes.Spells, "/RPGXplorerDatabase/RPGXplorerObject[*/@FK='" & DefinitionKey.ToString & "' and Inherited = 'True']")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a collection of spell definitions relative for the given spell list holder e.g. Class, Domain, Category
        Public Shared Function GetSpellDefinitions(ByVal DefinitionKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try

                'get the spell list
                Dim SpellList As Objects.ObjectDataCollection = Rules.SpellList.SpellList(DefinitionKey)

                'get all the parents of these objects
                Dim SpellDefs As New Objects.ObjectDataCollection
                For Each SpellLevel As Objects.ObjectData In SpellList
                    If Not SpellDefs.Contains(SpellLevel.ParentGUID) Then
                        SpellDefs.Add(SpellDefinition(SpellLevel.ParentGUID))
                    End If
                Next

                Return SpellDefs

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a collection of spell definitions relative for the given spell list holder e.g. Class, Domain, Category
        Public Shared Function GetSpellDefinitions(ByVal DefinitionKey As Objects.ObjectKey, ByVal StartLevel As Integer, ByVal EndLevel As Integer) As Objects.ObjectDataCollection
            Try

                'get the spell list
                Dim SpellList As Objects.ObjectDataCollection = Rules.SpellList.SpellList(DefinitionKey, StartLevel, EndLevel)

                'get all the parents of these objects
                Dim SpellDefs As New Objects.ObjectDataCollection
                For Each SpellLevel As Objects.ObjectData In SpellList
                    If Not SpellDefs.Contains(SpellLevel.ParentGUID) Then
                        SpellDefs.Add(SpellDefinition(SpellLevel.ParentGUID))
                    End If
                Next

                Return SpellDefs

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns spell list as a hashtable of spell info structures
        Public Shared Function SpellListInfo(ByVal DefinitionKey As Objects.ObjectKey) As ObjectHashtable
            Try
                'get all the spell level objects
                Dim SpellLevels As Objects.ObjectDataCollection = SpellList(DefinitionKey)

                'setup the hashtable
                Dim SpellsTable As New ObjectHashtable(SpellLevels.Count)

                'create the hashtable
                For Each Level As Objects.ObjectData In SpellLevels
                    If Not SpellsTable.Contains(Level.ObjectGUID) Then
                        Dim SpellInfo As SpellInfo
                        SpellInfo.SpellObject = SpellDefinition(Level.ParentGUID)
                        SpellInfo.LevelObject = Level
                        SpellsTable.Add(Level.ObjectGUID, SpellInfo)
                    End If
                Next

                Return SpellsTable

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns spell list as a hashtable of spell info structures
        Public Shared Function SpellListInfo(ByVal DefinitionKey As Objects.ObjectKey, ByVal StartLevel As Integer, ByVal EndLevel As Integer) As ObjectHashtable

            Try
                'get all the spell level objects
                Dim SpellLevels As Objects.ObjectDataCollection = SpellList(DefinitionKey, StartLevel, EndLevel)

                'setup the hashtable
                Dim SpellsTable As New ObjectHashtable(SpellLevels.Count)

                'create the hashtable
                For Each Level As Objects.ObjectData In SpellLevels
                    If Not SpellsTable.Contains(Level.ObjectGUID) Then
                        Dim SpellInfo As SpellInfo
                        SpellInfo.SpellObject = SpellDefinition(Level.ParentGUID)
                        SpellInfo.LevelObject = Level
                        SpellsTable.Add(Level.ObjectGUID, SpellInfo)
                    End If
                Next

                Return SpellsTable

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'creates spell levels for the given source, updates inherited lists and updates "Spell List" style casters
        Public Shared Sub CreateSpellLevels(ByVal Source As Objects.ObjectData, ByVal Spells As Objects.ObjectDataCollection, ByVal Level As Integer, Optional ByVal UpdateSpellTags As Boolean = True)
            Try
                If Source.IsEmpty Then Exit Sub

                Dim FKElement As String
                Select Case Source.Type
                    Case Objects.ClassType
                        FKElement = "Class"
                    Case Objects.DomainDefinitionType
                        FKElement = "Domain"
                    Case Objects.SpellCategoryDefinitionType
                        FKElement = "Category"
                    Case Else
                        Throw New RPGXplorer.Exceptions.DevelopmentException("Create Spell Levels, Source object not of expected type")
                End Select

                'get any classes that inherit from this 
                Dim InheritingClasses As Objects.ObjectDataCollection = GetInheritingClasses(Source.ObjectGUID)
                Dim FastIndex As ObjectHashtable = FastSpellLevelIndex(InheritingClasses)
                Dim SpellLevel As New Objects.ObjectData
                Dim Arcane, Divine As Boolean

                'update the spell tags
                If UpdateSpellTags Then
                    Dim TempClass As Objects.ObjectData

                    'get tags from the source
                    Select Case Source.Type
                        Case Objects.ClassType
                            Select Case Source.Element("CasterType")
                                Case "Arcane"
                                    Arcane = True
                                Case "Divine"
                                    Divine = True
                            End Select
                        Case Objects.DomainDefinitionType
                            Divine = True
                    End Select

                    'tags from inherited classes
                    For Each TempClass In InheritingClasses
                        If Arcane And Divine Then Exit For
                        Select Case TempClass.Element("CasterType")
                            Case "Arcane"
                                Arcane = True
                            Case "Divine"
                                Divine = True
                        End Select
                    Next
                End If

                For Each Spell As Objects.ObjectData In Spells
                    'create the spell level
                    SpellLevel.Clear()
                    SpellLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Spells)
                    SpellLevel.ParentGUID = Spell.ObjectGUID
                    SpellLevel.Type = Objects.SpellLevelType
                    SpellLevel.Element("Level") = Level.ToString
                    SpellLevel.FKElement(FKElement, Source.Name, "Name", Source.ObjectGUID)
                    SpellLevel.Save()

                    'check that this spell is not already in an inheriting list, remove if present
                    Dim InheritedLevels As ArrayList = CType(FastIndex.Item(Spell.ObjectGUID), ArrayList)
                    If Not InheritedLevels Is Nothing Then
                        For Each InheritedLevel As Objects.ObjectData In InheritedLevels
                            XML.FKLookup.RemoveItem(InheritedLevel.GetFKGuid("Class"), InheritedLevel.ObjectGUID)
                            InheritedLevel.DeleteFast()
                        Next
                    End If

                    'create a level for each one of the inheriting classes
                    For Each ClassDef As Objects.ObjectData In InheritingClasses
                        SpellLevel.Clear()
                        SpellLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Spells)
                        SpellLevel.ParentGUID = Spell.ObjectGUID
                        SpellLevel.Type = Objects.SpellLevelType
                        SpellLevel.Element("Level") = Level.ToString
                        SpellLevel.FKElement("Class", ClassDef.Name, "Name", ClassDef.ObjectGUID)
                        SpellLevel.Element("Inherited") = "True"
                        SpellLevel.Save()
                    Next

                    'set any new spell tags
                    If Arcane Then
                        Spell.Element("Arcane") = "Yes"
                    End If

                    If Divine Then
                        Spell.Element("Divine") = "Yes"
                    End If
                Next

                'set dirty any windows showing spell lists for inheriting classes
                For Each DirtyFolder As Objects.ObjectData In GetClassSpellListFolders(InheritingClasses)
                    WindowManager.SetDirty(DirtyFolder)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'removes the given spells levels, updates inherited lists
        Public Shared Sub RemoveSpellLevels(ByVal SpellLevelsToRemove As Objects.ObjectDataCollection, ByVal SourceKey As Objects.ObjectKey, Optional ByVal UpdateSpellTags As Boolean = True)
            Try
                'check for empty collections
                If SpellLevelsToRemove Is Nothing OrElse (SpellLevelsToRemove.Count < 1) Then Exit Sub

                'get any classes that inherit from this 
                Dim InheritingClasses As Objects.ObjectDataCollection = GetInheritingClasses(SourceKey)
                Dim SpellDefs As New Objects.ObjectDataCollection

                'delete spell levels
                If InheritingClasses.Count < 1 Then
                    'if there are no inherited classes - just delete
                    General.SetWaitCursor()
                    For Each SpellLevel As Objects.ObjectData In SpellLevelsToRemove
                        If Not spelllevel.IsEmpty Then
                            If UpdateSpellTags Then SpellDefs.Add(SpellDefinition(spelllevel.ParentGUID))
                            XML.FKLookup.RemoveItem(SourceKey, SpellLevel.ObjectGUID)
                            SpellLevel.DeleteFast()
                        End If
                    Next
                    General.SetNormalCursor()
                Else
                    General.SetWaitCursor()
                    Dim FastIndex As ObjectHashtable = FastSpellLevelIndex(InheritingClasses)
                    For Each SpellLevel As Objects.ObjectData In SpellLevelsToRemove
                        Dim InheritedLevels As ArrayList = CType(FastIndex.Item(SpellLevel.ParentGUID), ArrayList)
                        If UpdateSpellTags Then SpellDefs.Add(SpellDefinition(SpellLevel.ParentGUID))

                        If Not InheritedLevels Is Nothing Then
                            For Each InheritedLevel As Objects.ObjectData In InheritedLevels
                                If InheritedLevel.Element("Inherited") = "True" Then
                                    XML.FKLookup.RemoveItem(InheritedLevel.GetFKGuid("Class"), InheritedLevel.ObjectGUID)
                                    InheritedLevel.DeleteFast()
                                End If
                            Next
                        End If
                        XML.FKLookup.RemoveItem(SourceKey, SpellLevel.ObjectGUID)
                        SpellLevel.DeleteFast()
                    Next
                    General.SetNormalCursor()
                End If

                'update spell tags
                General.SetWaitCursor()
                For Each SpellDef As Objects.ObjectData In SpellDefs
                    Dim ClassObj As Objects.ObjectData
                    Dim Arcane, Divine As Boolean

                    SpellDef.Element("Arcane") = "" : Arcane = False
                    SpellDef.Element("Divine") = "" : Divine = False

                    'loop through the remaining children of this object and set tags
                    For Each SpellLevel As Objects.ObjectData In SpellDef.ChildrenOfType(Objects.SpellLevelType)
                        Select Case Rules.SpellList.GetSpellLevelSourceElement(SpellLevel)
                            Case "Class"
                                ClassObj = SpellLevel.GetFKObject("Class")
                                If Not ClassObj.IsEmpty Then
                                    Select Case ClassObj.Element("CasterType")
                                        Case "Arcane"
                                            SpellDef.Element("Arcane") = "Yes"
                                            Arcane = True

                                        Case "Divine"
                                            SpellDef.Element("Divine") = "Yes"
                                            Divine = True
                                    End Select
                                End If

                            Case "Domain"
                                SpellDef.Element("Divine") = "Yes"
                                Divine = True
                        End Select
                        If Arcane AndAlso Divine Then Exit For
                    Next
                Next
                General.SetNormalCursor()

                'set dirty any windows showing spell lists for inheriting classes
                For Each DirtyFolder As Objects.ObjectData In GetClassSpellListFolders(InheritingClasses)
                    WindowManager.SetDirty(DirtyFolder)
                Next

                'refresh current panel
                General.MainExplorer.RefreshPanel()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'copies an existing spell list to that of the specified class
        Public Shared Sub InheritSpellList(ByVal SourceKey As Objects.ObjectKey, ByVal InheritingClass As Objects.ObjectData)
            Try

                'retrieve and delete any existing spell levels form the inheriting class
                RemoveSpellLevels(SpellList(InheritingClass.ObjectGUID), InheritingClass.ObjectGUID)

                'create the new spell levels
                Dim LevelsToClone As Objects.ObjectDataCollection = Rules.SpellList.SpellList(SourceKey)
                Dim NewLevel As New Objects.ObjectData
                For Each SpellLevel As Objects.ObjectData In LevelsToClone
                    NewLevel.Clear()
                    NewLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Spells)
                    NewLevel.ParentGUID = SpellLevel.ParentGUID
                    NewLevel.Type = Objects.SpellLevelType
                    NewLevel.Element("Inherited") = "True"
                    NewLevel.Element("Level") = SpellLevel.Element("Level")
                    NewLevel.FKElement("Class", InheritingClass.Name, "Name", InheritingClass.ObjectGUID)
                    NewLevel.Save()
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'gets the source element name (Class/Domain/Category) from the given spell level
        Public Shared Function GetSpellLevelSourceElement(ByVal SpellLevel As Objects.ObjectData) As String
            Try

                'spell levels only have one FK in them so this finds the first one and returns it
                Return SpellLevel.GetFirstFKElementName

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'creates a spell display object for use in various panels
        Public Shared Function GenerateSpellListItem(ByVal SpellInfo As SpellInfo, ByVal ParentKey As Objects.ObjectKey) As Objects.ObjectData
            Try
                Dim SpellListItem As New Objects.ObjectData
                Dim SpellDef, SpellLevel As Objects.ObjectData
                Dim Level As Integer

                SpellDef = SpellInfo.SpellObject
                SpellLevel = SpellInfo.LevelObject
                Level = SpellInfo.LevelObject.ElementAsInteger("Level")

                'object basics
                SpellListItem.Name = SpellDef.Name
                SpellListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                SpellListItem.ParentGUID = ParentKey
                SpellListItem.Type = Objects.SpellListItemType
                SpellListItem.ImageFilename = SpellDef.ImageFilename
                SpellListItem.HTML = SpellDef.HTML

                'display info
                SpellListItem.Element("Level") = Level.ToString
                SpellListItem.Element("School") = SpellDef.Element("School")
                SpellListItem.Element("Subschool") = SpellDef.Element("Subschool")
                SpellListItem.Element("Descriptors") = SpellDef.Element("Descriptors")
                SpellListItem.Element("Components") = SpellDef.Element("Components")
                SpellListItem.Element("CastingTime") = SpellDef.Element("CastingTime")
                SpellListItem.Element("Range") = SpellDef.Element("Range")
                SpellListItem.Element("TargetAreaEffect") = SpellDef.Element("TargetAreaEffect")
                SpellListItem.Element("Duration") = SpellDef.Element("Duration")
                SpellListItem.Element("SavingThrow") = SpellDef.Element("SavingThrow")
                SpellListItem.Element("SpellResistance") = SpellDef.Element("SpellResistance")
                SpellListItem.Element("XPCost") = SpellDef.Element("XPCost")
                SpellListItem.Element("ComponentCost") = SpellDef.Element("ComponentCost")
                SpellListItem.Element("Description") = SpellDef.Element("Description")

                SpellListItem.Element("License") = SpellDef.Element("License")
                SpellListItem.Element("Sourcebook") = SpellDef.Element("Sourcebook")
                SpellListItem.Element("Tags") = SpellDef.Element("Tags")
                SpellListItem.Element("PageNoRef") = SpellDef.Element("PageNoRef")

                'object info
                SpellListItem.FKElement("Spell", SpellDef.Name, "Name", SpellDef.ObjectGUID)
                SpellListItem.FKElement("SpellLevel", SpellLevel.Name, "Name", SpellLevel.ObjectGUID)

                Return SpellListItem

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a hashtable indexed by spell where each bucket contains an arraylist of spell levels filtered to the provided class list
        Private Shared Function FastSpellLevelIndex(ByVal Classes As Objects.ObjectDataCollection) As ObjectHashtable
            Try
                Dim SpellLists As New ObjectHashtable

                'load the spell levels table
                For Each TempClass As Objects.ObjectData In Classes
                    Dim Levels As ArrayList

                    'load each node
                    For Each Obj As Objects.ObjectData In SpellList(TempClass.ObjectGUID)
                        If SpellLists.Contains(Obj.ParentGUID) Then
                            Levels = DirectCast(SpellLists(Obj.ParentGUID), ArrayList)
                            Levels.Add(Obj)
                        Else
                            Levels = New ArrayList
                            Levels.Add(Obj)
                            SpellLists.Add(Obj.ParentGUID, Levels)
                        End If
                    Next
                Next

                Return SpellLists

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a collection of classes that are inheriting from specified class
        Private Shared Function GetInheritingClasses(ByVal AncestorKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                Dim InheritingClasses As New Objects.ObjectDataCollection

                For Each ClassDef As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassType)
                    If ClassDef.GetFKGuid("InheritSource").Equals(AncestorKey) Then InheritingClasses.Add(ClassDef)
                Next

                Return InheritingClasses
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the class spell list folders for the specified classes 
        Private Shared Function GetClassSpellListFolders(ByVal Classes As Objects.ObjectDataCollection) As Objects.ObjectDataCollection
            Try
                Dim Folders As New Objects.ObjectDataCollection

                For Each ClassDef As Objects.ObjectData In Classes
                    Folders.Add(ClassDef.FirstChildOfType(Objects.SpellListFolderType))
                Next

                Return Folders

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace