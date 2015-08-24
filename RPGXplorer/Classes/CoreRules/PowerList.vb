Option Explicit On 
Option Strict On

Imports RPGXplorer.Objects
Imports System.Xml

Namespace Rules

    Public Class PowerList

#Region "Enumerations"

        Enum PowerListOperationMode
            Character
            Definition
        End Enum

#End Region

#Region "Structures"

        Public Structure PowerInfo
            Public PowerObject As ObjectData
            Public LevelObject As ObjectData
        End Structure

#End Region

#Region "Properties"

        Public Shared ReadOnly Property PowerDefinition(ByVal Key As Objects.ObjectKey) As Objects.ObjectData
            Get
                Return DirectCast(Caches.Powers(Key), Objects.ObjectData)
            End Get
        End Property

#End Region

        'return the power levels for the given power list holder e.g. Class, Discipline Specialization
        Public Shared Function PowerList(ByVal DefinitionKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                'get all the power level objects
                Return Objects.GetObjectsByXPath(XML.DBTypes.Powers, "/RPGXplorerDatabase/RPGXplorerObject[*/@FK='" & DefinitionKey.ToString & "']")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the power levels for the given power list holder e.g. Class, Discipline Specialization and only powers between the given levels
        Public Shared Function PowerList(ByVal DefinitionKey As Objects.ObjectKey, ByVal StartLevel As Integer, ByVal EndLevel As Integer) As Objects.ObjectDataCollection
            Try
                'get all the power level objects
                Return Objects.GetObjectsByXPath(XML.DBTypes.Powers, "/RPGXplorerDatabase/RPGXplorerObject[*/@FK='" & DefinitionKey.ToString & "' and  Level >=" & StartLevel.ToString & " and Level <=" & EndLevel.ToString & "]")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the inherited power levels for the given power list holder e.g. Class, Discipline Specialization, Category
        Public Shared Function InheritedpowerList(ByVal DefinitionKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                'get all the power level objects
                Return Objects.GetObjectsByXPath(XML.DBTypes.Powers, "/RPGXplorerDatabase/RPGXplorerObject[*/@FK='" & DefinitionKey.ToString & "' and Inherited = 'True']")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a collection of power definitions relative for the given power list holder e.g. Class, Discipline Specialization
        Public Shared Function GetpowerDefinitions(ByVal DefinitionKey As Objects.ObjectKey) As Objects.ObjectDataCollection
            Try
                'get the power list
                Dim PowerList As Objects.ObjectDataCollection = Rules.PowerList.PowerList(DefinitionKey)

                'get all the parents of these objects
                Dim PowerDefs As New Objects.ObjectDataCollection
                For Each PowerLevel As Objects.ObjectData In PowerList
                    If Not PowerDefs.Contains(PowerLevel.ParentGUID) Then
                        PowerDefs.Add(PowerDefinition(PowerLevel.ParentGUID))
                    End If
                Next

                Return PowerDefs

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a collection of power definitions relative for the given power list holder e.g. Class, Domain, Category
        Public Shared Function GetPowerDefinitions(ByVal DefinitionKey As Objects.ObjectKey, ByVal StartLevel As Integer, ByVal EndLevel As Integer) As Objects.ObjectDataCollection
            Try

                'get the power list
                Dim PowerList As Objects.ObjectDataCollection = Rules.PowerList.PowerList(DefinitionKey, StartLevel, EndLevel)

                'get all the parents of these objects
                Dim PowerDefs As New Objects.ObjectDataCollection
                For Each PowerLevel As Objects.ObjectData In PowerList
                    If Not PowerDefs.Contains(PowerLevel.ParentGUID) Then
                        PowerDefs.Add(PowerDefinition(PowerLevel.ParentGUID))
                    End If
                Next

                Return PowerDefs

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns power list as a hashtable of power info structures
        Public Shared Function powerListInfo(ByVal DefinitionKey As Objects.ObjectKey) As ObjectHashtable
            Try
                'get all the power level objects
                Dim powerLevels As Objects.ObjectDataCollection = PowerList(DefinitionKey)

                'setup the hashtable
                Dim powersTable As New ObjectHashtable(powerLevels.Count)

                'create the hashtable
                For Each Level As Objects.ObjectData In powerLevels
                    If Not powersTable.Contains(Level.ObjectGUID) Then
                        Dim powerInfo As PowerInfo
                        powerInfo.PowerObject = PowerDefinition(Level.ParentGUID)
                        powerInfo.LevelObject = Level
                        powersTable.Add(Level.ObjectGUID, powerInfo)
                    End If
                Next

                Return powersTable

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns power list as a hashtable of power info structures
        Public Shared Function PowerListInfo(ByVal DefinitionKey As Objects.ObjectKey, ByVal StartLevel As Integer, ByVal EndLevel As Integer) As ObjectHashtable

            Try
                'get all the power level objects
                Dim powerLevels As Objects.ObjectDataCollection = PowerList(DefinitionKey, StartLevel, EndLevel)

                'setup the hashtable
                Dim powersTable As New ObjectHashtable(powerLevels.Count)

                'create the hashtable
                For Each Level As Objects.ObjectData In powerLevels
                    If Not powersTable.Contains(Level.ObjectGUID) Then
                        Dim PowerInfo As PowerInfo
                        PowerInfo.PowerObject = PowerDefinition(Level.ParentGUID)
                        PowerInfo.LevelObject = Level
                        powersTable.Add(Level.ObjectGUID, PowerInfo)
                    End If
                Next

                Return powersTable

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'creates power levels for the given source, updates inherited lists and updates "power List" style casters
        Public Shared Sub CreatePowerLevels(ByVal Source As Objects.ObjectData, ByVal Powers As Objects.ObjectDataCollection, ByVal Level As Integer)
            Try
                If Source.IsEmpty Then Exit Sub

                Dim FKElement As String
                Select Case Source.Type
                    Case Objects.ClassType
                        FKElement = "Class"
                    Case Objects.PsionicSpecializationDefinitionType
                        FKElement = "DisciplineSpecialization"
                    Case Else
                        Throw New RPGXplorer.Exceptions.DevelopmentException("Create Power Levels, Source object not of expected type")
                End Select

                'get any classes that inherit from this 
                Dim InheritingClasses As Objects.ObjectDataCollection = GetInheritingClasses(Source.ObjectGUID)
                Dim FastIndex As ObjectHashtable = FastPowerLevelIndex(InheritingClasses)
                Dim PowerLevel As New Objects.ObjectData

                For Each Power As Objects.ObjectData In Powers
                    'create the power level
                    PowerLevel.Clear()
                    PowerLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Powers)
                    PowerLevel.ParentGUID = Power.ObjectGUID
                    PowerLevel.Type = Objects.PowerLevelType
                    PowerLevel.Element("Level") = Level.ToString
                    PowerLevel.FKElement(FKElement, Source.Name, "Name", Source.ObjectGUID)
                    PowerLevel.Save()

                    'check that this power is not already in an inheriting list, remove if present
                    Dim InheritedLevels As ArrayList = CType(FastIndex.Item(Power.ObjectGUID), ArrayList)
                    If Not InheritedLevels Is Nothing Then
                        For Each InheritedLevel As Objects.ObjectData In InheritedLevels
                            XML.FKLookup.RemoveItem(InheritedLevel.GetFKGuid("Class"), InheritedLevel.ObjectGUID)
                            InheritedLevel.DeleteFast()
                        Next
                    End If

                    'create a level for each one of the inheriting classes
                    For Each ClassDef As Objects.ObjectData In InheritingClasses
                        PowerLevel.Clear()
                        PowerLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Powers)
                        PowerLevel.ParentGUID = Power.ObjectGUID
                        PowerLevel.Type = Objects.PowerLevelType
                        PowerLevel.Element("Level") = Level.ToString
                        PowerLevel.FKElement("Class", ClassDef.Name, "Name", ClassDef.ObjectGUID)
                        PowerLevel.Element("Inherited") = "True"
                        PowerLevel.Save()
                    Next
                Next

                'set dirty any windows showing power lists for inheriting classes
                For Each DirtyFolder As Objects.ObjectData In GetClasspowerListFolders(InheritingClasses)
                    WindowManager.SetDirty(DirtyFolder)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'removes the given powers levels, updates inherited lists
        Public Shared Sub RemovepowerLevels(ByVal powerLevelsToRemove As Objects.ObjectDataCollection, ByVal SourceKey As Objects.ObjectKey)
            Try
                'check for empty collections
                If powerLevelsToRemove Is Nothing OrElse (powerLevelsToRemove.Count < 1) Then Exit Sub

                'get any classes that inherit from this 
                Dim InheritingClasses As Objects.ObjectDataCollection = GetInheritingClasses(SourceKey)
                Dim powerDefs As New Objects.ObjectDataCollection

                'delete power levels
                If InheritingClasses.Count < 1 Then
                    'if there are no inherited classes - just delete
                    General.SetWaitCursor()
                    For Each powerLevel As Objects.ObjectData In powerLevelsToRemove
                        XML.FKLookup.RemoveItem(SourceKey, powerLevel.ObjectGUID)
                        powerLevel.DeleteFast()
                    Next
                    General.SetNormalCursor()
                Else
                    General.SetWaitCursor()
                    Dim FastIndex As ObjectHashtable = FastPowerLevelIndex(InheritingClasses)
                    For Each powerLevel As Objects.ObjectData In powerLevelsToRemove
                        Dim InheritedLevels As ArrayList = CType(FastIndex.Item(powerLevel.ParentGUID), ArrayList)
                        If Not InheritedLevels Is Nothing Then
                            For Each InheritedLevel As Objects.ObjectData In InheritedLevels
                                If InheritedLevel.Element("Inherited") = "True" Then
                                    XML.FKLookup.RemoveItem(InheritedLevel.GetFKGuid("Class"), InheritedLevel.ObjectGUID)
                                    InheritedLevel.DeleteFast()
                                End If
                            Next
                        End If
                        XML.FKLookup.RemoveItem(SourceKey, powerLevel.ObjectGUID)
                        powerLevel.DeleteFast()
                    Next
                    General.SetNormalCursor()
                End If

                'set dirty any windows showing power lists for inheriting classes
                For Each DirtyFolder As Objects.ObjectData In GetClasspowerListFolders(InheritingClasses)
                    WindowManager.SetDirty(DirtyFolder)
                Next

                'refresh current panel
                General.MainExplorer.RefreshPanel()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'copies an existing power list to that of the specified class
        Public Shared Sub InheritpowerList(ByVal SourceKey As Objects.ObjectKey, ByVal InheritingClass As Objects.ObjectData)
            Try

                'retrieve and delete any existing power levels form the inheriting class
                RemovepowerLevels(PowerList(InheritingClass.ObjectGUID), InheritingClass.ObjectGUID)

                'create the new power levels
                Dim LevelsToClone As Objects.ObjectDataCollection = Rules.PowerList.PowerList(SourceKey)
                Dim NewLevel As New Objects.ObjectData
                For Each powerLevel As Objects.ObjectData In LevelsToClone
                    NewLevel.Clear()
                    NewLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Powers)
                    NewLevel.ParentGUID = powerLevel.ParentGUID
                    NewLevel.Type = Objects.PowerLevelType
                    NewLevel.Element("Inherited") = "True"
                    NewLevel.Element("Level") = powerLevel.Element("Level")
                    NewLevel.FKElement("Class", InheritingClass.Name, "Name", InheritingClass.ObjectGUID)
                    NewLevel.Save()
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'gets the source element name (Class/Discipline Specialization) from the given power level
        Public Shared Function GetPowerLevelSourceElement(ByVal PowerLevel As Objects.ObjectData) As String
            Try
                'power levels only have one FK in them so this finds the first one and returns it
                Return PowerLevel.GetFirstFKElementName()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'creates a power display object for use in various panels
        Public Shared Function GeneratePowerListItem(ByVal powerInfo As PowerInfo, ByVal ParentKey As Objects.ObjectKey) As Objects.ObjectData
            Try
                Dim powerListItem As New Objects.ObjectData
                Dim powerDef, powerLevel As Objects.ObjectData
                Dim Level, Points As Integer

                powerDef = powerInfo.PowerObject
                powerLevel = powerInfo.LevelObject
                Level = powerInfo.LevelObject.ElementAsInteger("Level")
                Points = PowerPoints(Level)

                'object basics
                powerListItem.Name = powerDef.Name
                powerListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Folders)
                powerListItem.ParentGUID = ParentKey
                powerListItem.Type = Objects.PowerListItemType
                powerListItem.ImageFilename = powerDef.ImageFilename
                powerListItem.HTML = powerDef.HTML

                'display info - UPDATE ELEMENT TAGS
                powerListItem.Element("Level") = Level.ToString
                powerListItem.Element("Points") = Points.ToString

                powerListItem.Element("Discipline") = powerDef.Element("Discipline")
                powerListItem.Element("Subdiscipline") = powerDef.Element("Subdiscipline")
                powerListItem.Element("Descriptors") = powerDef.Element("Descriptors")
                powerListItem.Element("Display") = powerDef.Element("Display")
                powerListItem.Element("CastingTime") = powerDef.Element("CastingTime")
                powerListItem.Element("Range") = powerDef.Element("Range")
                powerListItem.Element("TargetAreaEffect") = powerDef.Element("TargetAreaEffect")
                powerListItem.Element("Duration") = powerDef.Element("Duration")
                powerListItem.Element("SavingThrow") = powerDef.Element("SavingThrow")
                powerListItem.Element("PowerResistance") = powerDef.Element("PowerResistance")
                powerListItem.Element("XPCost") = powerDef.Element("XPCost")
                powerListItem.Element("Augment") = powerDef.Element("Augment")
                powerListItem.Element("Description") = powerDef.Element("Description")

                powerListItem.Element("License") = powerDef.Element("License")
                powerListItem.Element("Sourcebook") = powerDef.Element("Sourcebook")
                powerListItem.Element("Tags") = powerDef.Element("Tags")
                powerListItem.Element("PageNoRef") = powerDef.Element("PageNoRef")

                'object info
                powerListItem.FKElement("Power", powerDef.Name, "Name", powerDef.ObjectGUID)
                powerListItem.FKElement("PowerLevel", powerLevel.Name, "Name", powerLevel.ObjectGUID)

                Return powerListItem

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the number of power points required to manifest a power of the given level
        Public Shared Function PowerPoints(ByVal PowerLevel As Integer) As Integer
            Try
                If PowerLevel = 1 Then
                    Return 1
                Else
                    Return PowerLevel * 2 - 1
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return a hashtable indexed by power where each bucket contains an arraylist of power levels filtered to the provided class list
        Private Shared Function FastPowerLevelIndex(ByVal Classes As Objects.ObjectDataCollection) As ObjectHashtable
            Try
                Dim PowerLists As New ObjectHashtable

                'load the power levels table
                For Each TempClass As Objects.ObjectData In Classes
                    Dim Levels As ArrayList

                    'load each node
                    For Each Obj As Objects.ObjectData In PowerList(TempClass.ObjectGUID)
                        If PowerLists.Contains(Obj.ParentGUID) Then
                            Levels = DirectCast(PowerLists(Obj.ParentGUID), ArrayList)
                            Levels.Add(Obj)
                        Else
                            Levels = New ArrayList
                            Levels.Add(Obj)
                            PowerLists.Add(Obj.ParentGUID, Levels)
                        End If
                    Next
                Next

                Return PowerLists

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

        'get the class power list folders for the specified classes 
        Private Shared Function GetClasspowerListFolders(ByVal Classes As Objects.ObjectDataCollection) As Objects.ObjectDataCollection
            Try
                Dim Folders As New Objects.ObjectDataCollection

                For Each ClassDef As Objects.ObjectData In Classes
                    Folders.Add(ClassDef.FirstChildOfType(Objects.PowerListFolderType))
                Next

                Return Folders

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace