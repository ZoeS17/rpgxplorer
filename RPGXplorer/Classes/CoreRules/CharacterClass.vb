
Option Strict On
Option Explicit On 

Imports RPGXplorer.General

Namespace Rules

    Public Class CharacterClass

        'this class encapsulates a character class and its levels

#Region "Member Variables"

        Private _ClassObj As Objects.ObjectData
        Private ClassLevels As Hashtable = New Hashtable(Rules.Constants.MaxLevels)
        Private SpellsPerDay As Hashtable = New Hashtable(Rules.Constants.MaxLevels)
        Private SpellsKnown As Hashtable = New Hashtable(Rules.Constants.MaxLevels)
        Private PowerProgressions As Hashtable = New Hashtable(Rules.Constants.MaxLevels)
        Private ClassSkills As New ObjectHashtable()
        Private _HighestClassLevel As Integer
        Private _CasterInfo As CasterInfoStructure
        Private _ClassType As ClassTypes

#End Region

#Region "Properties"

        Public ReadOnly Property ClassObj() As Objects.ObjectData
            Get
                Return _ClassObj
            End Get
        End Property

        Public ReadOnly Property ClassLevel(ByVal Level As Integer) As Objects.ObjectData
            Get
                Return DirectCast(ClassLevels(Level), Objects.ObjectData)
            End Get
        End Property

        Public ReadOnly Property CasterInfo() As CasterInfoStructure
            Get
                Return _CasterInfo
            End Get
        End Property

        Public ReadOnly Property ClassType() As ClassTypes
            Get
                Return _ClassType
            End Get
        End Property

#End Region

#Region "Structures"

        Structure CasterInfoStructure

            Public IsCaster As Boolean
            Public CasterType As String
            Public SpellAttribute As String
            Public BonusSpells As Boolean
            Public BonusPoints As Boolean
            Public DomainBonusSpells As Boolean
            Public SchoolBonusSpells As Boolean
            Public SpellAquisition As AcquisitionType
            Public FirstLevelSpells As Integer
            Public PerLevelSpells As Integer
            Public NoSpellsPerDay As Boolean
            Public ManualSpells As Boolean
            Public SelectSchool As Boolean
            Public DomainNumber As Integer
            Public RestrictDomainSelection As Boolean
            Public MemorizeSpells As Boolean

            'psionics
            Public IsPsionic As Boolean
            Public PowerAttribute As String
            Public ManualPowers As Boolean
            Public BonusPowerPoints As Boolean
            Public RestrictPsionicSpecialization As Boolean

            'clears the structure
            Public Sub Clear()
                IsCaster = Nothing
                CasterType = Nothing
                SpellAttribute = Nothing
                BonusSpells = Nothing
                BonusPoints = Nothing
                DomainBonusSpells = Nothing
                SchoolBonusSpells = Nothing
                SpellAquisition = Nothing
                FirstLevelSpells = Nothing
                PerLevelSpells = Nothing
                NoSpellsPerDay = Nothing
                ManualSpells = Nothing
                SelectSchool = Nothing
                DomainNumber = Nothing
                RestrictDomainSelection = False

                'psionics
                IsPsionic = Nothing
                PowerAttribute = Nothing
                ManualPowers = Nothing
                BonusPowerPoints = Nothing
                RestrictPsionicSpecialization = False
            End Sub

        End Structure

        Public Enum AcquisitionType
            List
            Known
            Book
        End Enum

        Public Enum ClassTypes
            CharacterClass
            MonsterClass
            CompanionClass
            FamiliarClass
            SpecialMountClass
        End Enum

#End Region

        'initialise
        Public Sub Load(ByVal ClassGuid As Objects.ObjectKey)
            Dim ClassLevel, PowerProgression, SpellLevel, Skill As New Objects.ObjectData
            Dim Level As Integer

            Try
                'get the class
                _ClassObj.Load(ClassGuid)

                'clear old data
                _HighestClassLevel = 0
                ClassLevels.Clear()
                ClassSkills.Clear()
                SpellsPerDay.Clear()
                SpellsKnown.Clear()
                _CasterInfo.Clear()

                'get all the class level objects and set the class type
                Dim ClassLevelsCollection As New Objects.ObjectDataCollection
                Select Case _ClassObj.Type
                    Case Objects.ClassType
                        ClassLevelsCollection = ClassObj.FirstChildOfType(Objects.ClassLevelsFolderType).ChildrenOfType(Objects.ClassLevelType)
                        _ClassType = ClassTypes.CharacterClass
                    Case Objects.MonsterClassType
                        ClassLevelsCollection = ClassObj.FirstChildOfType(Objects.MonsterClassLevelsFolderType).ChildrenOfType(Objects.MonsterClassLevelType)
                        Select Case _ClassObj.Element("ClassType")
                            Case "Familiar"
                                _ClassType = ClassTypes.FamiliarClass
                            Case "Animal Companion"
                                _ClassType = ClassTypes.CompanionClass
                            Case "Special Mount"
                                _ClassType = ClassTypes.SpecialMountClass
                            Case Else
                                _ClassType = ClassTypes.MonsterClass
                        End Select
                End Select

                'load the casterinfo if required
                If _ClassObj.Element("CasterAbility") = "Yes" Then
                    With _CasterInfo
                        .IsCaster = True
                        .CasterType = _ClassObj.Element("CasterType")
                        .SpellAttribute = _ClassObj.Element("SpellAttribute")

                        If _ClassObj.Element("BonusSpells") = "True" Then .BonusSpells = True Else .BonusSpells = False
                        If _ClassObj.Element("BonusPoints") = "True" Then .BonusPoints = True Else .BonusPoints = False
                        If _ClassObj.Element("DomainBonus") = "True" Then .DomainBonusSpells = True Else .DomainBonusSpells = False
                        If _ClassObj.Element("SchoolBonus") = "True" Then .SchoolBonusSpells = True Else .SchoolBonusSpells = False

                        .SpellAquisition = DirectCast([Enum].Parse(GetType(AcquisitionType), _ClassObj.Element("SpellAcquisition")), AcquisitionType)
                        If .SpellAquisition = AcquisitionType.Book Then
                            .FirstLevelSpells = _ClassObj.ElementAsInteger("FirstLevelSpells")
                            .PerLevelSpells = _ClassObj.ElementAsInteger("PerLevelSpells")
                        End If
                        If .SpellAquisition = AcquisitionType.Known Then
                            If ClassObj.Element("NoSpellsPerDay") = "True" Then .NoSpellsPerDay = True
                        End If
                        If _ClassObj.Element("ManualSpells") = "True" Then .ManualSpells = True Else .ManualSpells = False
                        If _ClassObj.Element("SelectSchool") = "True" Then .SelectSchool = True Else .SelectSchool = False
                        If _ClassObj.Element("RestrictDomain") = "True" Then .RestrictDomainSelection = True Else .RestrictDomainSelection = False
                        If _ClassObj.Element("MemorizeSpells") = "True" Then .MemorizeSpells = True Else .MemorizeSpells = False
                    End With
                End If

                If _ClassObj.Element("CasterAbility") = "Psionic" Then
                    With _CasterInfo
                        .IsPsionic = True
                        .PowerAttribute = _ClassObj.Element("PowerAttribute")
                        If _ClassObj.Element("BonusPowerPoints") = "True" Then .BonusPowerPoints = True Else .BonusPowerPoints = False
                        If _ClassObj.Element("ManualPowers") = "True" Then .ManualPowers = True
                        If _ClassObj.Element("RestrictSpecialization") = "True" Then .RestrictPsionicSpecialization = True
                    End With
                End If

                For Each ClassLevel In ClassLevelsCollection
                    Level = ClassLevel.ElementAsInteger("Level")
                    ClassLevels.Add(Level, ClassLevel)
                    If Level > _HighestClassLevel Then _HighestClassLevel = Level
                Next

                'determine which spell folders are present 
                Dim spd, sk, psionic As Boolean

                spd = CharacterClass.SPD(_ClassObj)
                sk = CharacterClass.SK(_ClassObj)
                psionic = CharacterClass.Psionic(_ClassObj)

                'get all the spells per day objects if any
                If spd Then
                    For Each SpellLevel In _ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsPerDayFolderType).ChildrenOfType(Objects.SpellsPerDayType)
                        Level = SpellLevel.ElementAsInteger("Level")
                        SpellsPerDay.Add(Level, SpellLevel)
                    Next
                End If

                'get all the spells known objects if any
                If sk Then
                    For Each SpellLevel In _ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsKnownFolderType).ChildrenOfType(Objects.SpellsKnownType)
                        Level = SpellLevel.ElementAsInteger("Level")
                        SpellsKnown.Add(Level, SpellLevel)
                    Next
                End If

                If psionic Then
                    For Each PowerProgression In _ClassObj.FirstChildOfType(Objects.ClassLevelsPowerProgressionFolderType).ChildrenOfType(Objects.PowerProgressionType)
                        Level = PowerProgression.ElementAsInteger("Level")
                        PowerProgressions.Add(Level, PowerProgression)
                    Next
                End If

                'get all the class skills
                For Each Skill In _ClassObj.ChildrenOfType(Objects.ClassSkillType)
                    ClassSkills.Add(Skill.GetFKGuid("Skill"), Skill)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'is this class a caster
        Public Function IsCaster() As Boolean
            Try
                Return _CasterInfo.IsCaster
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this class a caster
        Public Function IsPsionic() As Boolean
            Try
                Return _CasterInfo.IsPsionic
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this skill a class skill?
        Public Function IsClassSkill(ByVal SkillGuid As Objects.ObjectKey) As Boolean
            Try
                If ClassSkills.Contains(SkillGuid) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the highest class level object
        Public Function HighestClassLevel() As Objects.ObjectData
            Try
                Return DirectCast(ClassLevels.Item(_HighestClassLevel), Objects.ObjectData)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the highest spells per day object
        Public Function HighestSpellsPerDay() As Objects.ObjectData
            Try
                Return DirectCast(SpellsPerDay.Item(_HighestClassLevel), Objects.ObjectData)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the spells per day object at the given class level
        Public Function SpellsPerDayObject(ByVal Level As Integer) As Objects.ObjectData
            Try
                Return DirectCast(SpellsPerDay.Item(Level), Objects.ObjectData)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns the number of spells per day this class has at the given level, -1 if they cant cast any
        Public Function SpellsPerDayScore(ByVal ClassLevel As Integer, ByVal SpellLevel As Integer) As Integer
            Try
                Dim SPDObject As Objects.ObjectData
                SPDObject = SpellsPerDayObject(ClassLevel)

                If SPDObject.IsEmpty Then Return -1

                Dim ElementString As String = "Level" & SpellLevel & "Spells"
                If Not SPDObject.Element(ElementString) = "" Then
                    Return SPDObject.ElementAsInteger(ElementString)
                Else
                    Return -1
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the highest spells known object
        Public Function HighestSpellsKnown() As Objects.ObjectData
            Try
                Return DirectCast(SpellsKnown.Item(_HighestClassLevel), Objects.ObjectData)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the spells known object at the given class level
        Public Function SpellsKnownObject(ByVal Level As Integer) As Objects.ObjectData
            Try
                Return DirectCast(SpellsKnown.Item(Level), Objects.ObjectData)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns the number of spells known this class has at the given level
        Public Function SpellsKnownScore(ByVal ClassLevel As Integer, ByVal SpellLevel As Integer) As Integer
            Try
                Dim SKObject As Objects.ObjectData
                SKObject = SpellsKnownObject(ClassLevel)

                If SKObject.IsEmpty Then Return 0

                Dim ElementString As String = "Level" & SpellLevel & "Spells"
                If Not SKObject.Element(ElementString) = "" Then
                    Return SKObject.ElementAsInteger(ElementString)
                Else
                    Return 0
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'Returns True if this class has the level defined
        Public Function LevelExists(ByVal Classlevel As Integer) As Boolean
            Try
                Return ClassLevels.ContainsKey(Classlevel)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function PowerProgressionObject(ByVal Level As Integer) As Objects.ObjectData
            Try
                Return DirectCast(PowerProgressions.Item(Level), Objects.ObjectData)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function PsionicPowersKnown(ByVal Level As Integer) As Integer
            Try
                If Not _CasterInfo.IsPsionic Then Return 0

                Dim PowerProgObject As Objects.ObjectData
                PowerProgObject = PowerProgressionObject(Level)

                If PowerProgObject.IsEmpty Then Return 0

                Return PowerProgObject.ElementAsInteger("PowersKnown")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function PowerPoints(ByVal Level As Integer) As Integer
            Try

                If Not _CasterInfo.IsPsionic Then Return 0

                Dim PowerProgObject As Objects.ObjectData
                PowerProgObject = PowerProgressionObject(Level)

                If PowerProgObject.IsEmpty Then Return 0

                Return PowerProgObject.ElementAsInteger("PowerPoints")

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function MaxPowerLevelKnown(ByVal Level As Integer) As Integer
            Try
                If Not _CasterInfo.IsPsionic Then Return 0

                Dim PowerProgObject As Objects.ObjectData
                PowerProgObject = PowerProgressionObject(Level)

                If PowerProgObject.IsEmpty Then Return 0

                Return Sorter.StripLeftNumbers(PowerProgObject.Element("MaxPowerLevel"))

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#Region "Spells Per Day/Spells Known"

        'spells per day?
        Public Shared Function SPD(ByVal Obj As Objects.ObjectData) As Boolean

            If Obj.Element("CasterAbility") = "Yes" Then
                If Not Obj.Element("NoSpellsPerDay") = "True" Then
                    Return True
                End If
            End If

            Return False

        End Function

        Public Shared Function Psionic(ByVal Obj As Objects.ObjectData) As Boolean
            Try
                If Obj.Element("CasterAbility") = "Psionic" Then
                    Return True
                End If

                Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'spells known?
        Public Shared Function SK(ByVal Obj As Objects.ObjectData) As Boolean

            Select Case Obj.Element("SpellAcquisition")
                Case "Known"
                    Return True

                Case Else
                    Return False
            End Select

        End Function

        'create spell level for spells per day
        Public Shared Sub CreateSpellsPerDay(ByVal Folder As Objects.ObjectKey, ByVal Level As Integer)
            Dim SpellLevel As New Objects.ObjectData

            SpellLevel.Name = "Level " & Level
            SpellLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
            SpellLevel.Type = Objects.SpellsPerDayType
            SpellLevel.ParentGUID = Folder
            SpellLevel.ElementAsInteger("Level") = Level
            SpellLevel.Element("Level0Spells") = ""
            SpellLevel.Element("Level1Spells") = ""
            SpellLevel.Element("Level2Spells") = ""
            SpellLevel.Element("Level3Spells") = ""
            SpellLevel.Element("Level4Spells") = ""
            SpellLevel.Element("Level5Spells") = ""
            SpellLevel.Element("Level6Spells") = ""
            SpellLevel.Element("Level7Spells") = ""
            SpellLevel.Element("Level8Spells") = ""
            SpellLevel.Element("Level9Spells") = ""
            SpellLevel.Save()
        End Sub

        'create spell level for spells known
        Public Shared Sub CreateSpellsKnown(ByVal Folder As Objects.ObjectKey, ByVal Level As Integer)
            Dim SpellLevel As New Objects.ObjectData

            SpellLevel.Name = "Level " & Level
            SpellLevel.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
            SpellLevel.Type = Objects.SpellsKnownType
            SpellLevel.ParentGUID = Folder
            SpellLevel.ElementAsInteger("Level") = Level
            SpellLevel.Element("Level0Spells") = ""
            SpellLevel.Element("Level1Spells") = ""
            SpellLevel.Element("Level2Spells") = ""
            SpellLevel.Element("Level3Spells") = ""
            SpellLevel.Element("Level4Spells") = ""
            SpellLevel.Element("Level5Spells") = ""
            SpellLevel.Element("Level6Spells") = ""
            SpellLevel.Element("Level7Spells") = ""
            SpellLevel.Element("Level8Spells") = ""
            SpellLevel.Element("Level9Spells") = ""
            SpellLevel.Save()
        End Sub

        'create power details for psionic progressions
        Public Shared Sub CreatePowerProgression(ByVal Folder As Objects.ObjectKey, ByVal Level As Integer)
            Dim PowerDetails As New Objects.ObjectData
            PowerDetails.Name = "Level " & Level
            PowerDetails.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
            PowerDetails.Type = Objects.PowerProgressionType
            PowerDetails.ParentGUID = Folder
            PowerDetails.ElementAsInteger("Level") = Level
            PowerDetails.Element("PowerPoints") = ""
            PowerDetails.Element("PowersKnown") = ""
            PowerDetails.Element("MaxPowerLevel") = ""
            PowerDetails.Save()
        End Sub

#End Region

    End Class

End Namespace
