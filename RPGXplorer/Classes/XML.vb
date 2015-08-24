Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Objects

Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml

Public Class XML

#Region "Database Declarations"
    'database constants
    Public Enum DBTypes As Integer
        Unknown = 0
        Folders = 1
        UserDocs = 2
        Characters = 3
        ArmorAndShields = 4
        Classes = 5
        Deities = 6
        Domains = 7
        Feats = 8
        Features = 9
        Items = 10
        Languages = 11
        ArmorMagicAbilities = 12
        Artifacts = 13
        MagicArmor = 14
        MagicWeapons = 15
        PotionsAndOils = 16
        Rings = 17
        Rods = 18
        Scrolls = 19
        Staffs = 20
        Wands = 21
        WeaponMagicAbilities = 22
        WondrousItems = 23
        ModifierLimiters = 24
        MonsterTypes = 25
        Races = 26
        Skills = 27
        SpellCategoriesAndDescriptors = 28
        SpellSchools = 29
        Spells = 30
        Weapons = 31
        SystemComponents = 32
        ColumnLayouts = 33
        Powers = 34 'psionics
        Materials = 35 'materials
        MonsterRaces = 36 'monsters
        MonsterClasses = 37 'monsters
        NaturalWeapons = 38 'monsters
        Subtypes = 39 'monsters
        Monsters = 40 'monsters
        Count = 40 'Set this to the max databases
    End Enum

    Public Shared DBx(DBTypes.Count + 1) As XmlDocument
#End Region

    'database index
    Public Shared FolderLookup As New Hashtable(50)

    'referential integrity
    Public Shared FKLookup As FKLookupTable

    'misc
    Public Shared Lock As Boolean = False

    'load db index
    Public Shared Sub LoadDatabaseIndex()
        Dim i As Integer

        For i = 1 To DBTypes.Count
            DBx(i) = New XmlDocument
        Next

    End Sub

    'load folder lookup
    Public Shared Sub LoadFolderLookup()
        FolderLookup.Add(Objects.SystemFolderType, DBTypes.Folders)
        FolderLookup.Add(Objects.ArmorDefinitionFolderType, DBTypes.ArmorAndShields)
        FolderLookup.Add(Objects.CharacterFolderType, DBTypes.Characters)
        FolderLookup.Add(Objects.DeityDefinitionFolderType, DBTypes.Deities)
        FolderLookup.Add(Objects.ClassFolderType, DBTypes.Classes)
        FolderLookup.Add(Objects.DomainDefinitionFolderType, DBTypes.Domains)
        FolderLookup.Add(Objects.FeatDefinitionsFolderType, DBTypes.Feats)
        FolderLookup.Add(Objects.FeatureDefinitionFolderType, DBTypes.Features)
        FolderLookup.Add(Objects.ItemDefinitionFolderType, DBTypes.Items)
        FolderLookup.Add(Objects.LanguageDefinitionFolderType, DBTypes.Languages)
        FolderLookup.Add(Objects.ArmorMagicAbilityDefinitionFolderType, DBTypes.ArmorMagicAbilities)
        FolderLookup.Add(Objects.ArtifactDefinitionFolderType, DBTypes.Artifacts)
        FolderLookup.Add(Objects.SpecificArmorDefinitionFolderType, DBTypes.MagicArmor)
        FolderLookup.Add(Objects.SpecificWeaponDefinitionFolderType, DBTypes.MagicWeapons)
        FolderLookup.Add(Objects.PotionDefinitionFolderType, DBTypes.PotionsAndOils)
        FolderLookup.Add(Objects.RingDefinitionFolderType, DBTypes.Rings)
        FolderLookup.Add(Objects.RodDefinitionFolderType, DBTypes.Rods)
        FolderLookup.Add(Objects.ScrollDefinitionFolderType, DBTypes.Scrolls)
        FolderLookup.Add(Objects.StaffDefinitionFolderType, DBTypes.Staffs)
        FolderLookup.Add(Objects.WandDefinitionFolderType, DBTypes.Wands)
        FolderLookup.Add(Objects.WeaponMagicAbilityDefinitionFolderType, DBTypes.WeaponMagicAbilities)
        FolderLookup.Add(Objects.WondrousDefinitionFolderType, DBTypes.WondrousItems)
        FolderLookup.Add(Objects.ModifierLimiterFolderType, DBTypes.ModifierLimiters)
        FolderLookup.Add(Objects.MonsterTypeFolderType, DBTypes.MonsterTypes)
        FolderLookup.Add(Objects.RaceFolderType, DBTypes.Races)
        FolderLookup.Add(Objects.SkillDefinitionFolderType, DBTypes.Skills)
        FolderLookup.Add(Objects.SpellCategoryFolder, DBTypes.SpellCategoriesAndDescriptors)
        FolderLookup.Add(Objects.SpellDescriptorDefinitionFolderType, DBTypes.SpellCategoriesAndDescriptors)
        FolderLookup.Add(Objects.SpellSchoolFolderType, DBTypes.SpellSchools)
        FolderLookup.Add(Objects.SpellDefinitionFolderType, DBTypes.Spells)
        FolderLookup.Add(Objects.WeaponDefinitionFolderType, DBTypes.Weapons)
        FolderLookup.Add(Objects.SystemAbilityDefinitionFolderType, DBTypes.SystemComponents)
        FolderLookup.Add(Objects.SystemElementFolderType, DBTypes.SystemComponents)
        FolderLookup.Add(Objects.SystemPreconditionDefinitionFolderType, DBTypes.SystemComponents)
        FolderLookup.Add(Objects.SystemReferenceFolderType, DBTypes.SystemComponents)
        FolderLookup.Add(Objects.SystemWeaponAbilityDefinitionFolderType, DBTypes.SystemComponents)
        FolderLookup.Add(Objects.RulesRootFolderType, DBTypes.UserDocs)
        FolderLookup.Add(Objects.SpellListItemType, DBTypes.Spells)

        'psionics
        FolderLookup.Add(Objects.PowerDefinitionFolderType, DBTypes.Powers)
        FolderLookup.Add(Objects.PsionicDisciplineFolderType, DBTypes.SpellSchools)
        FolderLookup.Add(Objects.PsionicSpecializationDefinitionFolderType, DBTypes.Domains)
        FolderLookup.Add(Objects.PowerListItemType, DBTypes.Spells)

        'psionic item folders
        FolderLookup.Add(Objects.PsionicArtifactDefinitionsFolderType, DBTypes.Artifacts)
        FolderLookup.Add(Objects.PsionicWeaponDefinitionsFolderType, DBTypes.MagicWeapons)
        FolderLookup.Add(Objects.PsionicArmorDefinitionsFolderType, DBTypes.MagicArmor)
        FolderLookup.Add(Objects.PsionicWeaponAbilityDefinitionsFolderType, DBTypes.WeaponMagicAbilities)
        FolderLookup.Add(Objects.PsionicArmorAbilityDefinitionsFolderType, DBTypes.ArmorMagicAbilities)
        FolderLookup.Add(Objects.PsionicPowerStoneDefinitionsFolderType, DBTypes.Scrolls)
        FolderLookup.Add(Objects.PsionicDorjeDefinitionsFolderType, DBTypes.Wands)
        FolderLookup.Add(Objects.PsionicTattooDefinitionsFolderType, DBTypes.PotionsAndOils)
        FolderLookup.Add(Objects.PsionicPsicrownDefinitionFolderType, DBTypes.Staffs)
        FolderLookup.Add(Objects.UniversalItemDefinitionFolderType, DBTypes.WondrousItems)

        'special material
        FolderLookup.Add(Objects.SpecialMaterialDefinitionsFolderType, DBTypes.Materials)

        'monsters
        FolderLookup.Add(Objects.MonsterRaceDefinitionFolderType, DBTypes.MonsterRaces)
        FolderLookup.Add(Objects.MonsterClassFolderType, DBTypes.MonsterClasses)
        FolderLookup.Add(Objects.NaturalWeaponDefinitionsFolderType, DBTypes.NaturalWeapons)
        FolderLookup.Add(Objects.SubtypeDefinitionsFolderType, DBTypes.Subtypes)

        FolderLookup.Add(Objects.MonsterFolderType, DBTypes.Monsters)
    End Sub

    'get specified database
    Public Shared ReadOnly Property Database(ByVal Number As Integer) As XmlDocument
        Get
            Return CType(DBx(Number), XmlDocument)
        End Get
    End Property

    'get database number that will contain children of parent
    Public Shared Function GetDatabaseNo(ByVal ParentGUID As Objects.ObjectKey) As Integer
        If ParentGUID.Database = 1 Then
            Dim Obj As New Objects.ObjectData

            Obj.Load(ParentGUID)
            Return CType(FolderLookup.Item(Obj.Type), Integer)
        Else
            Return ParentGUID.Database
        End If
    End Function

    'get database number that will contain children of parent
    Public Shared Function GetDatabaseNo(ByVal Parent As Objects.ObjectData) As Integer
        If Parent.ObjectGUID.Database = 1 Then
            Return CType(FolderLookup.Item(Parent.Type), Integer)
        Else
            Return Parent.ObjectGUID.Database
        End If
    End Function

    'pad db number to 3 digits
    Public Shared Function PadDBNumber(ByVal Number As Integer) As String
        PadDBNumber = "000" & Number.ToString
        PadDBNumber = PadDBNumber.Substring(PadDBNumber.Length - 3, 3)
    End Function

    'map type to database
    Public Shared Function MapTypeToDB(ByVal Type As String) As Integer
        Select Case Type
            Case SystemFolderType, ArmorDefinitionFolderType, ArmorMagicAbilityDefinitionFolderType, ArtifactDefinitionFolderType, CharacterFolderType, ClassFolderType, DeityDefinitionFolderType, DomainDefinitionFolderType, FeatDefinitionsFolderType, FeatureDefinitionFolderType, ItemDefinitionFolderType, LanguageDefinitionFolderType, ModifierLimiterFolderType, MonsterTypeFolderType, PotionDefinitionFolderType, RaceFolderType, RingDefinitionFolderType, RodDefinitionFolderType, ScrollDefinitionFolderType, SkillDefinitionFolderType, SpecificArmorDefinitionFolderType, SpecificWeaponDefinitionFolderType, SpellDefinitionFolderType, SpellDescriptorDefinitionFolderType, SpellSchoolFolderType, StaffDefinitionFolderType, SystemAbilityDefinitionFolderType, SystemElementFolderType, SystemPreconditionDefinitionFolderType, SystemReferenceFolderType, SystemWeaponAbilityDefinitionFolderType, WandDefinitionFolderType, WeaponDefinitionFolderType, WeaponMagicAbilityDefinitionFolderType, WondrousDefinitionFolderType
                Return 1
            Case UserDocMapType, UserDocRulesType, UserDocType, UserFolderType
                Return 2
            Case CharacterType, Objects.FeatureFolderType, Objects.SkillFolderType, Objects.WeaponConfigFolderType, Objects.FeatFolderType, Objects.ModifierFolderType, Objects.CharacterLevelsFolderType, Objects.InventoryFolderType
                Return 3
            Case ArmorDefinitionType, ShieldDefinitionType
                Return 4
            Case ClassType, Objects.ClassLevelType, Objects.ClassLevelsFolderType, Objects.ClassLevelsSpellsKnownFolderType, Objects.ClassLevelsSpellsPerDayFolderType, Objects.CombatStyleChoiceType, Objects.CombatStyleImprovedFeatType, Objects.CombatstyleMasteryFeatType
                Return 5
            Case DeityDefinitionType
                Return 6
            Case DomainDefinitionType, PsionicSpecializationType
                Return 7
            Case FeatDefinitionType
                Return 8
            Case FeatureDefinitionType
                Return 9
            Case ItemDefinitionType
                Return 10
            Case LanguageDefinitionType
                Return 11
            Case ArmorMagicAbilityDefinitionType, PsionicArmorAbilityDefinitionType
                Return 12
            Case ArtifactDefinitionType, PsionicArtifactDefinitionType
                Return 13
            Case SpecificArmorDefinitionType, PsionicArmorDefinitionType
                Return 14
            Case SpecificWeaponDefinitionType, PsionicWeaponDefinitionType
                Return 15
            Case PotionDefinitionType, PsionicTattooDefinitionType
                Return 16
            Case RingDefinitionType
                Return 17
            Case RodDefinitionType
                Return 18
            Case ScrollDefinitionType, PsionicPowerStoneDefinitionType
                Return 19
            Case StaffDefinitionType, PsionicPsicrownDefinitionType
                Return 20
            Case WandDefinitionType, PsionicDorjeDefinitionType
                Return 21
            Case WeaponMagicAbilityDefinitionType, PsionicWeaponAbilityDefinitionType
                Return 22
            Case WondrousDefinitionType, UniversalItemDefinitionType
                Return 23
            Case ModifierLimiterType
                Return 24
            Case MonsterTypeType
                Return 25
            Case RaceType
                Return 26
            Case SkillDefinitionType, SkillGroupType
                Return 27
            Case SpellDescriptorDefinitionType, SpellCategoryDefinitionType
                Return 28
            Case SpellSchoolType, Objects.SpellSubschoolType, PsionicDisciplineType, PsionicSubdisciplineType
                Return 29
            Case SpellDefinitionType
                Return 30
            Case WeaponDefinitionType, AmmoDefinitionType, NaturalWeaponDefinitionType
                Return 31
            Case SystemAbilityDefinitionType, SystemElementType, SystemPreconditionDefinitionType, SystemReferenceType, SystemWeaponAbilityDefinitionType
                Return 32
            Case ColumnLayoutType
                Return 33
            Case PowerDefinitionType
                Return 34
            Case SpecialMaterialDefinitionType
                Return 35
            Case MonsterRaceDefinitionType
                Return 36
            Case MonsterClassType, MonsterClassLevelType, MonsterClassLevelsFolderType
                Return 37
            Case NaturalWeaponDefinitionType
                Return 38
            Case SubtypeDefinitionType
                Return 39
            Case MonsterType
                Return 40
            Case Else
                Throw New DevelopmentException("Cannot map type to database")
        End Select
    End Function

    'load foreign key lookup - called when loading and rebuilding - manualy clear library first.
    Public Shared Sub LoadFKLookup(Optional ByVal ProgressBar As ProgressBar = Nothing, Optional ByVal Rebuild As Boolean = False)
        If Rebuild Then
            BuildFromDB(ProgressBar)
            Return
        End If

        If File.Exists(General.BasePath & "XML\FKLookup.dat") Then
            Dim Stream As Stream = Nothing
            Try
                Dim Formatter As IFormatter = New BinaryFormatter
                Stream = New FileStream(General.BasePath & "XML\FKLookup.dat", FileMode.Open, FileAccess.Read, FileShare.Read)
                FKLookup = DirectCast(Formatter.Deserialize(Stream), FKLookupTable)
            Catch ex As Exception
                BuildFromDB(ProgressBar)
                Return
            Finally
                If Stream IsNot Nothing Then Stream.Close()
            End Try
            If Not ProgressBar Is Nothing Then ProgressBar.Increment(DBTypes.Count)
        End If
    End Sub

    Private Shared Sub BuildFromDB(Optional ByVal ProgressBar As ProgressBar = Nothing)

        FKLookup = New FKLookupTable

        Dim i As Integer
        For i = 1 To DBTypes.Count - 1
            'For Each DB As DictionaryEntry In DBIndex

            If Not ProgressBar Is Nothing Then
                ProgressBar.Increment() '1 - 40
            End If

            If Not i = DBTypes.ColumnLayouts Then
                For Each Node As XmlNode In DBx(i).SelectNodes("/RPGXplorerDatabase/RPGXplorerObject")

                    'get object key
                    Dim Key As Objects.ObjectKey = New Objects.ObjectKey(Node.SelectSingleNode("./ObjectGUID").InnerText)

                    'get all FK attributes
                    For Each ChildNode As XmlNode In Node.SelectNodes("./*[@FK]")
                        Dim FK As Objects.ObjectKey = New Objects.ObjectKey(ChildNode.Attributes("FK").Value)
                        FKLookup.AddItemWithSubkey(FK, Key)
                    Next
                Next
            End If
        Next
    End Sub

    'saves the FKLookup
    Public Shared Sub SaveFKLookup()
        Dim Formatter As IFormatter = New BinaryFormatter
        Dim Stream As Stream = New FileStream(General.BasePath & "XML\FKLookup.dat", FileMode.Create, FileAccess.Write, FileShare.None)
        Formatter.Serialize(Stream, XML.FKLookup)
        Stream.Close()
    End Sub

    'test to see if object is a fk
    Public Shared Function IsForeignKey(ByVal Key As Objects.ObjectKey) As Boolean
        If FKLookup.ContainsKey(Key) Then Return True Else Return False
    End Function

    'load the xml database into memory
    Public Shared Sub LoadXMLDB(Optional ByVal ProgressBar As ProgressBar = Nothing)
        Try
            'load the databases
            For DBNo As Integer = 1 To DBTypes.Count
                If Not ProgressBar Is Nothing Then
                    ProgressBar.Increment() '1 - 40
                End If
                DBx(DBNo).Load(BasePath & "XML\Database" & DBNo.ToString & ".xml")
            Next
        Catch ex As Exception
            'one or more databases has failed to load
            Lock = True
            General.ShowErrorDialog("One or more databases failed to load. Attempting recovery.")
            LoadRestoreDB()
        End Try

        Try
            'remove existing backup databases and create new ones
            Dim BackupPath As String

            For DBNo As Integer = 1 To DBTypes.Count
                If Not ProgressBar Is Nothing Then
                    ProgressBar.Increment() '1 - 40
                End If
                BackupPath = BasePath & "XML\Database" & DBNo.ToString & ".backup"
                If IO.File.Exists(BackupPath) Then IO.File.Delete(BackupPath)
                IO.File.Copy(BasePath & "XML\Database" & DBNo.ToString & ".xml", BackupPath)
            Next

            'remove any restore databases
            Dim RestorePath As String

            For DBNo As Integer = 1 To DBTypes.Count
                If Not ProgressBar Is Nothing Then
                    ProgressBar.Increment() '1 - 40
                End If
                RestorePath = BasePath & "XML\Database" & DBNo.ToString & ".restore"
                If IO.File.Exists(RestorePath) Then IO.File.Delete(RestorePath)
            Next
        Catch ex As Exception
            'one or more databases has failed to load
            Lock = True
            General.ShowErrorDialog("One or more databases failed to load. Attempting recovery.")
            LoadRestoreDB()
        End Try
    End Sub

    'load the restore db
    Public Shared Sub LoadRestoreDB()
        Try
            Dim RestorePath As String

            'remove serialized files as they are out of date
            Dim TreeFile As New FileInfo(General.BasePath & "XML\TreeView.xml")
            If TreeFile.Exists Then TreeFile.Delete()
            Dim FKLookupFile As New FileInfo(General.BasePath & "XML\FKLookup.dat")
            If FKLookupFile.Exists Then FKLookupFile.Delete()

            'attempt recovery
            For DBNo As Integer = 1 To DBTypes.Count
                RestorePath = BasePath & "XML\Database" & DBNo.ToString & ".restore"
                If IO.File.Exists(RestorePath) Then DBx(DBNo).Load(RestorePath) Else Throw New Exception
            Next

            General.ShowInfoDialog("Database recovered successfully. Data now back to point of last fatal error.")
            Lock = False

        Catch ex As Exception
            General.ShowErrorDialog("Failed to load recovery database. Attempting rollback to last startup.")
            LoadBackupDB()
        End Try
    End Sub

    'load the backup db
    Public Shared Sub LoadBackupDB()
        Try
            Dim BackupPath As String

            For DBNo As Integer = 1 To DBTypes.Count
                BackupPath = BasePath & "XML\Database" & DBNo.ToString & ".backup"
                If IO.File.Exists(BackupPath) Then DBx(DBNo).Load(BackupPath) Else Throw New Exception
            Next

            General.ShowInfoDialog("Database recovered successfully. Data now back to point of last start up. Rule page changes inc. additions and deletions will still be effective up to the point of failure.")
            Lock = False

        Catch ex As Exception
            General.ShowErrorDialog("Database recovery failed entirely. Please contact customer services.")
            Application.Exit()
        End Try
    End Sub

    'save the xml database
    Public Shared Sub SaveXMLDB()
        If Not Lock Then
            Dim i As Integer
            For i = 1 To DBTypes.Count
                DBx(i).Save(BasePath & "XML\Database" + i.ToString() + ".xml")
            Next

            'save the Tree View as well to keep the database and tree consistant    
            General.MainExplorer.SaveTree()
            SaveFKLookup()
        End If
    End Sub

    'save the restore backup
    Public Shared Sub SaveRestoreDB()
        Try
            Dim RestorePath As String

            For DBNo As Integer = 1 To DBTypes.Count
                RestorePath = BasePath & "XML\Database" & DBNo.ToString & ".restore"
                If IO.File.Exists(RestorePath) Then IO.File.Delete(RestorePath)
                DBx(DBNo).Save(RestorePath)
            Next

            General.ShowInfoDialog("Recovery databases saved successfully.")

        Catch ex As Exception
            General.ShowErrorDialog("Unable to save recovery databases. System will have to roll back to last startup state when you next begin the application.")
        End Try
    End Sub

    'Save objects to an XML Document
    Shared Sub SaveObjectsAsXML(ByVal FocusObjects As Objects.ObjectDataCollection, ByVal Doc As System.Xml.XmlDocument, ByVal RootNode As System.Xml.XmlNode, ByVal FileName As String)
        For Each Obj As Objects.ObjectData In FocusObjects
            AppendChildren(Obj, Doc, RootNode)
            RootNode.AppendChild(Doc.ImportNode(Obj.XMLNode, True))
        Next

        Doc.Save(FileName)
    End Sub

    'Recursively save an objects children
    Shared Sub AppendChildren(ByVal Parent As Objects.ObjectData, ByVal Doc As System.Xml.XmlDocument, ByVal RootNode As System.Xml.XmlNode)
        Dim ChildObjects As New Objects.ObjectDataCollection
        Dim Child As Objects.ObjectData

        ChildObjects = Parent.Children

        For Each Child In ChildObjects
            AppendChildren(Child, Doc, RootNode)
            RootNode.AppendChild(Doc.ImportNode(Child.XMLNode, True))
        Next
    End Sub

    'load an RPGXplorer xml file into the database
    Public Shared Function LoadXML(ByVal Path As String, ByRef Version As String) As Objects.ObjectDataCollection
        Dim XmlRdr As XmlTextReader = Nothing
        Dim Obj As New Objects.ObjectData
        Dim NewObjects As New Objects.ObjectDataCollection
        Dim Name As String = ""
        Dim Type As String = ""

        Try
            XmlRdr = GetXMLTextReader(Path)

            While XmlRdr.Read
                Select Case XmlRdr.NodeType
                    Case XmlNodeType.Element
                        Select Case XmlRdr.Name
                            Case "RPGXplorerObjects", "xml", "RPGXplorerDatabase"
                                'ignore
                            Case "RPGXplorerData"
                                If XmlRdr.MoveToFirstAttribute() Then
                                    Version = XmlRdr.Value
                                    XmlRdr.MoveToElement()
                                End If
                            Case "RPGXplorerObject"
                                'new object
                                Obj.Clear()
                            Case "Name"
                                Name = XmlRdr.ReadString
                            Case "ObjectGUID"
                                Obj.ObjectGUID = New Objects.ObjectKey(XmlRdr.ReadString)
                            Case "Type"
                                Type = XmlRdr.ReadString
                            Case "ParentGUID"
                                Obj.ParentGUID = New Objects.ObjectKey(XmlRdr.ReadString)
                            Case "ImageFilename"
                                Obj.ImageFilename = XmlRdr.ReadString
                            Case "HTML"
                                Obj.HTML = XmlRdr.ReadString
                            Case "HTMLGUID"
                                Obj.HTMLGUID = New Objects.ObjectKey(XmlRdr.ReadString)
                            Case Else
                                If XmlRdr.AttributeCount = 2 Then
                                    Dim fk As Objects.ObjectKey
                                    Dim ref As String = ""

                                    XmlRdr.MoveToFirstAttribute()
                                    If XmlRdr.Name = "FK" Then fk = New Objects.ObjectKey(XmlRdr.Value)

                                    XmlRdr.MoveToNextAttribute()
                                    If XmlRdr.Name = "reference" Then ref = XmlRdr.Value

                                    XmlRdr.MoveToElement()
                                    Obj.FKElement(XmlRdr.Name, XmlRdr.ReadString, ref, fk)
                                Else
                                    Obj.Element(XmlRdr.Name) = XmlRdr.ReadString
                                End If
                        End Select
                    Case XmlNodeType.EndElement
                        Select Case XmlRdr.Name
                            Case "RPGXplorerObject"
                                Obj.Name = Name
                                Obj.Type = Type
                                Name = ""
                                Type = ""
                                If Not NewObjects.Contains(Obj.ObjectGUID) Then
                                    Obj.UpdateNodeFromStructure()
                                    NewObjects.Add(Obj)
                                End If
                        End Select
                End Select
            End While

            XmlRdr.Close()
            Return NewObjects

        Catch ex As Exception
            If XmlRdr IsNot Nothing Then XmlRdr.Close()
            General.ShowInfoDialog("XML file format not known or file corrupt.")
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'USED TO CREATE THE ExperienceLevels.XML
    'Public Shared Sub SaveLevelsXML()
    '    Dim XmlWriter As New XmlTextWriter("C:\Documents and Settings\Ross Robertson\Desktop\Merged\XML\ExperienceLevels2.xml", System.Text.Encoding.UTF8)

    '    XmlWriter.WriteStartDocument(True)
    '    XmlWriter.WriteStartElement("RPGXplorerConfig")

    '    Dim XPCounter As Integer

    '    For i As Integer = 1 To 50
    '        XmlWriter.WriteStartElement("ExperienceLevel")
    '        WriteElementString(XmlWriter, "CharacterLevel", i.ToString)
    '        XPCounter = XPCounter + (1000 * (i - 1))
    '        WriteElementString(XmlWriter, "XP", XPCounter.ToString)
    '        WriteElementString(XmlWriter, "ClassSkillMaxRanks", (i + 3).ToString)
    '        WriteElementString(XmlWriter, "CrossClassSkillMaxRanks", ((i + 3) / 2).ToString)
    '        WriteElementString(XmlWriter, "Feat", (Not (CBool(i Mod 3))).ToString)
    '        WriteElementString(XmlWriter, "AbilityIncrease", (Not (CBool(i Mod 4))).ToString)
    '        XmlWriter.WriteEndElement()    
    '    Next

    '    XmlWriter.WriteEndElement()
    '    XmlWriter.WriteEndDocument()
    '    XmlWriter.Flush()
    '    XmlWriter.Close()

    '    Dim XmlDoc As New XmlDocument
    '    XmlDoc.Load("C:\Documents and Settings\Ross Robertson\Desktop\Merged\XML\ExperienceLevels2.xml")
    '    XmlDoc.Save("C:\Documents and Settings\Ross Robertson\Desktop\Merged\XML\ExperienceLevels2.xml")

    'End Sub

    'save an RPGXplorer xml file to disk
    Public Shared Sub SaveXML(ByVal Objects As Objects.ObjectDataCollection, ByVal Path As String)
        Dim XmlWriter As New XmlTextWriter(Path, System.Text.Encoding.UTF8)

        'get the version tag
        Dim VersionString As String = General.Version

        XmlWriter.Formatting = Formatting.Indented
        XmlWriter.WriteStartDocument(True)
        XmlWriter.WriteStartElement("RPGXplorerData")
        XmlWriter.WriteStartAttribute("Version", Nothing)
        XmlWriter.WriteString(VersionString)
        XmlWriter.WriteEndAttribute()

        Dim ProgressBar As ProgressBar
        UI.Disable()
        ProgressBar = New ProgressBar
        ProgressBar.Caption = "Saving Components"
        ProgressBar.Maximum = Objects.Count
        ProgressBar.TopMost = True
        ProgressBar.Show()

        For Each Obj As Objects.ObjectData In Objects
            XmlWriter.WriteStartElement("RPGXplorerObject")
            WriteElementString(XmlWriter, "Name", Obj.Name)
            WriteElementString(XmlWriter, "Type", Obj.Type)
            WriteElementString(XmlWriter, "ObjectGUID", Obj.ObjectGUID.ToString)
            WriteElementString(XmlWriter, "ParentGUID", Obj.ParentGUID.ToString)
            WriteElementString(XmlWriter, "HTML", Obj.HTML)
            WriteElementString(XmlWriter, "HTMLGUID", Obj.HTMLGUID.ToString())
            WriteElementString(XmlWriter, "ImageFilename", Obj.ImageFilename)

            For Each ChildNode As XmlNode In Obj.XMLNode
                Select Case ChildNode.Name
                    Case "Name", "ObjectGUID", "Type", "ParentGUID", "HTML", "HTMLGUID", "ImageFilename"
                        'do nothing
                    Case Else
                        XmlWriter.WriteStartElement(ChildNode.Name)

                        If Not ChildNode.Attributes.Count = 0 Then
                            XmlWriter.WriteStartAttribute("FK", Nothing)
                            XmlWriter.WriteString(ChildNode.Attributes("FK").InnerText)
                            XmlWriter.WriteEndAttribute()
                            XmlWriter.WriteStartAttribute("reference", Nothing)
                            XmlWriter.WriteString(ChildNode.Attributes("reference").InnerText)
                            XmlWriter.WriteEndAttribute()
                        End If

                        XmlWriter.WriteString(ChildNode.InnerText)
                        XmlWriter.WriteEndElement()
                End Select
            Next

            XmlWriter.WriteEndElement()
            ProgressBar.Increment()
            Application.DoEvents()
        Next

        XmlWriter.WriteEndElement()
        XmlWriter.WriteEndDocument()
        XmlWriter.Flush()
        XmlWriter.Close()

        Dim XmlDoc As New XmlDocument
        XmlDoc.Load(Path)
        XmlDoc.Save(Path)

        ProgressBar.Close()
        UI.Enable()
    End Sub

    'helper function to write a single element
    Private Shared Sub WriteElementString(ByVal XmlWriter As XmlTextWriter, ByVal Name As String, ByVal InnerText As String)
        XmlWriter.WriteStartElement(Name)
        XmlWriter.WriteString(InnerText)
        XmlWriter.WriteEndElement()
    End Sub

    'helper function to open an xmltextreader on a file-based xml document
    Public Shared Function GetXMLTextReader(ByVal Path As String) As System.Xml.XmlTextReader
        Dim XmlRdr As XmlTextReader

        XmlRdr = New XmlTextReader(Path)
        XmlRdr.WhitespaceHandling = WhitespaceHandling.None
        Return XmlRdr
    End Function

    'clean a string for use in xml
    Public Shared Function CleanString(ByVal Str As String, Optional ByVal RemoveWhitespace As Boolean = False) As String
        Str = System.Security.SecurityElement.Escape(Str)
        If RemoveWhitespace Then Str = Str.Replace(" ", "")

        Return Str
    End Function

    'clean a string for use as an element name xml
    Public Shared Function CleanName(ByVal Str As String) As String
        Str = Str.Replace("'", "&apos;")
        Str = Str.Replace("<", "&lt;")
        Str = Str.Replace(">", "&gt;")
        Str = Str.Replace(" ", "")
        Str = Str.Replace("(", "")
        Str = Str.Replace(")", "")
        Str = Str.Replace("/", "")
        If Str.IndexOfAny(New Char() {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}) = 0 Then
            Str = "Name" & Str
        End If

        Return Str
    End Function

#Region "New Code"

    'execute an xpath query against a particular database
    Public Shared Function SelectSingleNode(ByVal Database As Integer, ByVal XPath As String) As XmlNode
        Dim DB As XmlDocument = DBx(Database)
        If Not DB Is Nothing Then
            Return DB.SelectSingleNode(XPath)
        Else
            Return Nothing
        End If
    End Function

    'execute an xpath query against a particular database
    Public Shared Function SelectNodes(ByVal Database As Integer, ByVal XPath As String) As XmlNodeList
        Dim DB As XmlDocument = DBx(Database)
        If Not DB Is Nothing Then
            Return DB.SelectNodes(XPath)
        Else
            Return Nothing
        End If
    End Function

    'create node
    Public Shared Function CreateNode(ByVal Database As Integer, ByVal Name As String) As XmlNode
        Dim DB As XmlDocument = DBx(Database)
        If Not DB Is Nothing Then
            Return DB.CreateNode(System.Xml.XmlNodeType.Element, Name, "")
        Else
            Return Nothing
        End If
    End Function

    'add an xml node (create node must have been used to get the node)
    Public Shared Sub AddNode(ByVal Database As Integer, ByVal Node As XmlNode)
        Dim RootNode As XmlNode
        Dim DB As XmlDocument = DBx(Database)

        RootNode = DB.SelectSingleNode("//RPGXplorerDatabase")
        RootNode.AppendChild(Node)
    End Sub

    'delete an xml node
    Public Shared Sub DeleteNode(ByVal Key As ObjectKey)
        If Key.Database > 0 Then
            Dim ChildNode As System.Xml.XmlNode = SelectSingleNode(Key.Database, "//RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='" & Key.ToString & "']")

            If Not ChildNode Is Nothing Then
                Dim RootNode As XmlNode = SelectSingleNode(Key.Database, "//RPGXplorerDatabase")
                RootNode.RemoveChild(ChildNode)
            End If
        End If
    End Sub

    'create an xml attribute
    Public Shared Function CreateAttribute(ByVal Database As Integer, ByVal Name As String) As System.Xml.XmlAttribute
        Dim DB As XmlDocument = DBx(Database)
        Return DB.CreateAttribute(Name, "")
    End Function

    'find all the objects in the xml db whose parentGUID is as given
    Public Shared Function GetChildNodes(ByVal ParentGuid As Objects.ObjectKey) As System.Xml.XmlNodeList
        If ParentGuid.Equals(Objects.ObjectKey.Empty) Then Return Nothing
        Dim Database As Integer = GetDatabaseNo(ParentGuid)
        If Database = 0 Then Return Nothing
        Dim DB As XmlDocument = DBx(Database)

        Return DB.SelectNodes("/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & ParentGuid.ToString & "']")
    End Function

    'find all the objects in the xml db whose parent object is as given
    Public Shared Function GetChildNodes(ByVal ParentObject As Objects.ObjectData) As System.Xml.XmlNodeList
        If ParentObject.ObjectGUID.Equals(Objects.ObjectKey.Empty) Then Return Nothing

        Dim Database As Integer = GetDatabaseNo(ParentObject)
        If Database = 0 Then Return Nothing
        Dim DB As XmlDocument = DBx(Database)

        Return DB.SelectNodes("/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & ParentObject.ObjectGUID.ToString & "']")
    End Function

    'find all the objects in the xml db whose parentGUID is as given
    Public Shared Function GetChildNodesOfType(ByVal ParentGuid As Objects.ObjectKey, ByVal Type As String) As System.Xml.XmlNodeList
        If ParentGuid.Equals(Objects.ObjectKey.Empty) Then Return Nothing
        Dim Database As Integer = GetDatabaseNo(ParentGuid)
        If Database = 0 Then Return Nothing
        Dim DB As XmlDocument = DBx(Database)

        Return DB.SelectNodes("/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & ParentGuid.ToString & "' and Type = '" & Type & "']")
    End Function

    'check to see if an object with this key exists
    Public Shared Function ObjectExists(ByVal Key As Objects.ObjectKey) As Boolean
        Dim DB As XmlDocument = DBx(Key.Database)
        Dim Node As XmlNode = DB.SelectSingleNode("/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='" & Key.ToString & "']")
        If Node Is Nothing Then Return False Else Return True
    End Function

    'check to see if an object with this name and type exists
    Public Shared Function ObjectExists(ByVal Name As String, ByVal Type As String, ByVal Database As Integer) As Boolean
        If Name Is Nothing Or Name = "" Then Return False
        Name = CleanString(Name)
        Select Case Type
            Case Objects.RuleFolderPageType, Objects.RuleFolderType, Objects.RulePageType, Objects.RuleTableType
                Return False

            Case Else

                Dim DB As XmlDocument = DBx(Database)
                Dim XpathString As String = "/RPGXplorerDatabase/RPGXplorerObject[Name=""" & _
                Name & _
                """ and Type='" & _
                Type & _
                "']"

                Dim Node As XmlNode = DB.SelectSingleNode(XpathString)
                If Node Is Nothing Then Return False Else Return True

        End Select
    End Function

    'check to see if an object with this name and type exists
    Public Shared Function UserListItemExists(ByVal Name As String, ByVal ListType As String) As Boolean
        If Name Is Nothing Or Name = "" Then Return False
        Name = CleanString(Name)

        Dim DB As XmlDocument = DBx(XML.DBTypes.UserDocs)
        Dim XpathString As String = "/RPGXplorerDatabase/RPGXplorerObject[Name=""" & Name & """ and ListName='" & ListType & "']"

        Dim Node As XmlNode = DB.SelectSingleNode(XpathString)
        If Node Is Nothing Then Return False Else Return True

    End Function

    'check to see if an object with this name and type exists excluding the object itself
    Public Shared Function ObjectExists2(ByVal Key As Objects.ObjectKey, ByVal Name As String, ByVal Type As String, ByVal Database As Integer) As Boolean
        If Name Is Nothing Or Name = "" Then Return False
        Name = CleanString(Name)
        Select Case Type
            Case Objects.UserDocMapType, Objects.UserDocRulesType, Objects.UserDocType, Objects.UserFolderType
                Return False
            Case Else

                Dim DB As XmlDocument = DBx(Database)
                Dim XpathString As String = "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID!='" & Key.ToString & "' and Name=""" & _
                Name & _
                """ and Type='" & _
                Type & _
                "']"

                Dim Node As XmlNode = DB.SelectSingleNode(XpathString)
                If Node Is Nothing Then Return False Else Return True
        End Select
    End Function

    'check to see if an object with this name and type exists excluding the object itself - return said object
    Public Shared Function ExistingObject(ByVal Key As Objects.ObjectKey, ByVal Name As String, ByVal Type As String, ByVal Database As Integer) As Objects.ObjectData
        If Name Is Nothing Or Name = "" Then Return Nothing
        Name = CleanString(Name)

        Dim DB As XmlDocument = DBx(Database)
        Dim XpathString As String = "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID!='" & Key.ToString & "' and Name=""" & _
             Name & """ and Type='" & Type & "']"

        Dim Node As XmlNode = DB.SelectSingleNode(XpathString)

        If Node Is Nothing Then
            Return Nothing
        Else
            Dim eo As New Objects.ObjectData
            eo.LoadFromNode(Node)
            Return eo
        End If
    End Function

    'check to see if an object with this name and type exists
    Public Shared Function ChildObjectExists(ByVal Name As String, ByVal Type As String, ByVal Database As Integer, ByVal ParentKey As Objects.ObjectKey) As Boolean
        If Name Is Nothing Or Name = "" Then Return False
        Name = CleanString(Name)
        Select Case Type
            Case Objects.UserDocMapType, Objects.UserDocRulesType, Objects.UserDocType, Objects.UserFolderType
                Return False
            Case Else
                Dim DB As XmlDocument = DBx(Database)

                Dim XpathString As String = "/RPGXplorerDatabase/RPGXplorerObject[Name=""" & _
                Name & _
                """ and Type='" & _
                Type & _
                "' and ParentGUID='" & ParentKey.ToString & "']"

                Dim Node As XmlNode = DB.SelectSingleNode(XpathString)
                If Node Is Nothing Then Return False Else Return True
        End Select
    End Function

    'rebuild fklookup
    Public Shared Sub RebuildFKLookup()
        FKLookup.Clear()
        LoadFKLookup(Rebuild:=True)
    End Sub

#End Region

End Class