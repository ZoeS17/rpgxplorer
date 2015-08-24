Option Explicit On
Option Strict On

Imports System.Xml
Imports RPGXplorer.General
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Public Class DataIntegrity

    'this class is responsible for handling any dependencies between data and ensuring integrity

    Public Shared Sub IntegritySave(ByVal ObjGuid As Objects.ObjectKey)
        'check each character to make sure that components are valid
    End Sub

    Public Shared Sub IntegrityImport()
        'check ??
    End Sub

#Region "Structures"

    'used in the DataIntegrity CharacterFolder fix for adding in Spell-like and Psi-Like folders
    Public Structure ParentChildType
        Public ParentKey As Objects.ObjectKey
        Public ObjectKey As Objects.ObjectKey
        Public Type As String
    End Structure

    Public Class CharacterFolderInfo
        Public Character As Objects.ObjectData
        Public MagicFolder As Objects.ObjectData
        Public PsionicFolder As Objects.ObjectData
        Public SpellLikeFolder As Objects.ObjectData
        Public PsiLikeFolder As Objects.ObjectData
    End Class

#End Region


#Region "Startup Fixes"

    '1.9.5 folder fixes
    Public Shared Sub CharacterFoldersFix()
        Try

            'grab all the character and folder objects
            Dim CharactersAndFolders As Objects.ObjectDataCollection

            'get all the type we want to get 
            Dim TypesList As New ArrayList
            TypesList.Add(Objects.CharacterType)
            TypesList.Add(Objects.MagicFolderType)
            TypesList.Add(Objects.PsionicFolderType)
            TypesList.Add(Objects.SpellLikeAbilityFolderType)
            TypesList.Add(Objects.PsiLikeAbilityFolderType)

            Dim XpathExpression As String = RPGXplorer.CommonLogic.ConstructXpathDisjunction("Type", TypesList)
            CharactersAndFolders = Objects.GetObjectsByXPath(XML.DBTypes.Characters, "/RPGXplorerDatabase/RPGXplorerObject[" & XpathExpression & "]")


            Dim Characters As New Hashtable
            Dim MagicPsionicFolders As New Hashtable
            Dim CFolder As CharacterFolderInfo

            For Each TempObject As Objects.ObjectData In CharactersAndFolders

                Select Case TempObject.Type

                    Case Objects.CharacterType
                        If Not Characters.ContainsKey(TempObject.ObjectGUID) Then
                            CFolder = New CharacterFolderInfo
                            CFolder.Character = TempObject
                            Characters.Add(TempObject.ObjectGUID, CFolder)
                        Else
                            CFolder = CType(Characters.Item(TempObject.ObjectGUID), CharacterFolderInfo)
                            CFolder.Character = TempObject
                        End If

                    Case Objects.MagicFolderType
                        'is there a cfolder object for this already?
                        If Not Characters.ContainsKey(TempObject.ParentGUID) Then
                            If MagicPsionicFolders.ContainsKey(TempObject.ObjectGUID) Then
                                CFolder = CType(MagicPsionicFolders.Item(TempObject.ObjectGUID), CharacterFolderInfo)
                                CFolder.MagicFolder = TempObject
                                Characters.Add(TempObject.ParentGUID, CFolder)
                            Else
                                CFolder = New CharacterFolderInfo
                                CFolder.MagicFolder = TempObject
                                Characters.Add(TempObject.ParentGUID, CFolder)
                                MagicPsionicFolders.Add(TempObject.ObjectGUID, CFolder)
                            End If

                        Else

                            CFolder = CType(Characters.Item(TempObject.ParentGUID), CharacterFolderInfo)
                            CFolder.MagicFolder = TempObject

                            If MagicPsionicFolders.ContainsKey(TempObject.ObjectGUID) Then
                                Dim Temp As CharacterFolderInfo = CType(MagicPsionicFolders(TempObject.ObjectGUID), CharacterFolderInfo)
                                If Not CFolder Is Temp Then
                                    If CFolder.SpellLikeFolder.IsEmpty Then CFolder.SpellLikeFolder = Temp.SpellLikeFolder
                                    If CFolder.PsiLikeFolder.IsEmpty Then CFolder.PsiLikeFolder = Temp.PsiLikeFolder
                                    MagicPsionicFolders.Item(TempObject.ObjectGUID) = CFolder
                                End If
                            Else
                                MagicPsionicFolders.Add(TempObject.ObjectGUID, CFolder)
                            End If

                        End If

                    Case Objects.PsionicFolderType
                        'is there a cfolder object for this already?
                        If Not Characters.ContainsKey(TempObject.ParentGUID) Then
                            If MagicPsionicFolders.ContainsKey(TempObject.ObjectGUID) Then
                                CFolder = CType(MagicPsionicFolders.Item(TempObject.ObjectGUID), CharacterFolderInfo)
                                CFolder.PsionicFolder = TempObject
                                Characters.Add(TempObject.ParentGUID, CFolder)
                            Else
                                CFolder = New CharacterFolderInfo
                                CFolder.PsionicFolder = TempObject
                                Characters.Add(TempObject.ParentGUID, CFolder)
                                MagicPsionicFolders.Add(TempObject.ObjectGUID, CFolder)
                            End If

                        Else

                            CFolder = CType(Characters.Item(TempObject.ParentGUID), CharacterFolderInfo)
                            CFolder.PsionicFolder = TempObject

                            If MagicPsionicFolders.ContainsKey(TempObject.ObjectGUID) Then
                                Dim Temp As CharacterFolderInfo = CType(MagicPsionicFolders(TempObject.ObjectGUID), CharacterFolderInfo)
                                If Not CFolder Is Temp Then
                                    If CFolder.SpellLikeFolder.IsEmpty Then CFolder.SpellLikeFolder = Temp.SpellLikeFolder
                                    If CFolder.PsiLikeFolder.IsEmpty Then CFolder.PsiLikeFolder = Temp.PsiLikeFolder
                                    MagicPsionicFolders.Item(TempObject.ObjectGUID) = CFolder
                                End If
                            Else
                                MagicPsionicFolders.Add(TempObject.ObjectGUID, CFolder)
                            End If

                        End If

                    Case Objects.SpellLikeAbilityFolderType
                        If Not MagicPsionicFolders.ContainsKey(TempObject.ParentGUID) Then
                            CFolder = New CharacterFolderInfo
                            CFolder.SpellLikeFolder = TempObject
                            MagicPsionicFolders.Add(TempObject.ParentGUID, CFolder)
                        Else
                            CFolder = CType(MagicPsionicFolders.Item(TempObject.ParentGUID), CharacterFolderInfo)
                            CFolder.SpellLikeFolder = TempObject
                        End If

                    Case Objects.PsiLikeAbilityFolderType
                        If Not MagicPsionicFolders.ContainsKey(TempObject.ParentGUID) Then
                            CFolder = New CharacterFolderInfo
                            CFolder.PsiLikeFolder = TempObject
                            MagicPsionicFolders.Add(TempObject.ParentGUID, CFolder)
                        Else
                            CFolder = CType(MagicPsionicFolders.Item(TempObject.ParentGUID), CharacterFolderInfo)
                            CFolder.PsiLikeFolder = TempObject
                        End If

                End Select
            Next

            'now we have made the collection go through and create any missing folders
            Dim TempFolder As New Objects.ObjectData
            For Each CFolder In Characters.Values

                If CFolder.MagicFolder.IsEmpty Then
                    TempFolder.Clear()
                    TempFolder.Name = "Magic"
                    TempFolder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Characters)
                    TempFolder.ParentGUID = CFolder.Character.ObjectGUID
                    TempFolder.Type = Objects.MagicFolderType
                    CFolder.MagicFolder = TempFolder
                    TempFolder.Save()
                End If

                If CFolder.PsionicFolder.IsEmpty Then
                    TempFolder.Clear()
                    TempFolder.Name = "Psionic"
                    TempFolder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Characters)
                    TempFolder.ParentGUID = CFolder.Character.ObjectGUID
                    TempFolder.Type = Objects.PsionicFolderType
                    CFolder.PsionicFolder = TempFolder
                    TempFolder.Save()
                End If

                If CFolder.SpellLikeFolder.IsEmpty Then
                    TempFolder.Clear()
                    TempFolder.Name = "Spell Like Abilities"
                    TempFolder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Characters)
                    TempFolder.ParentGUID = CFolder.MagicFolder.ObjectGUID
                    TempFolder.Type = Objects.SpellLikeAbilityFolderType
                    TempFolder.Save()
                End If

                If CFolder.PsiLikeFolder.IsEmpty Then
                    TempFolder.Clear()
                    TempFolder.Name = "Psi Like Abilities"
                    TempFolder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Characters)
                    TempFolder.ParentGUID = CFolder.PsionicFolder.ObjectGUID
                    TempFolder.Type = Objects.PsiLikeAbilityFolderType
                    TempFolder.Save()
                End If
            Next

            General.Config.Element("CharacterFolderPatch") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Function GetChildren(ByVal ParentKey As Objects.ObjectKey, ByVal ParentChildList As ArrayList) As ArrayList
        Dim List As New ArrayList

        For Each PCItem As ParentChildType In ParentChildList
            If PCItem.ParentKey.Equals(ParentKey) Then
                List.Add(PCItem)
            End If
        Next

        Return List

    End Function

    'fixes the undo steps and autosave interval
    Public Shared Sub AnimalFix()
        Try

            'set the info in the config object
            General.Config.ElementAsInteger("UndoSteps") = 1
            General.MainExplorer.Undo.NewUndoStack(1)

            General.Config.ElementAsInteger("AutosaveInterval") = 5
            General.AutosaveInterval = 5

            'Damage Reductions          
            Dim Obj As New Objects.ObjectData
            Dim DamageReductions As New ArrayList
            For n As Integer = 1 To XML.DBTypes.Count
                For Each Node As XmlNode In XML.SelectNodes(n, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.DamageReductionType & "']")
                    Obj.Clear()
                    Obj.LoadFromNode(Node)
                    DamageReductions.Add(Obj)
                Next
            Next

            Dim ProgressBar As ProgressBar
            General.MainExplorer.Form.Enabled = False
            ProgressBar = New ProgressBar
            ProgressBar.Caption = "Damage Reductions - Validating Damage Types"
            ProgressBar.Maximum = DamageReductions.Count
            ProgressBar.TopMost = True
            ProgressBar.Show()

            For Each Obj In DamageReductions
                Select Case Obj.Element("DROvercomeByType")

                    Case "+1", "+2", "+3", "+4", "+5"
                        Obj.Element("DROvercomeByType") = "Magic"

                    Case "Damage Type"
                        If Obj.Element("DamageType") = "Magic" Then
                            Obj.Element("DROvercomeByType") = "Magic"
                            Obj.Element("DamageType") = ""
                        End If

                End Select

                'update ProgressBar
                ProgressBar.Increment()
                Application.DoEvents()
            Next

            'close ProgressBar
            ProgressBar.Close()
            General.MainExplorer.Form.Enabled = True

            'set flag
            General.Config.Element("AnimalPatch") = "True"

        Catch ex As Exception
            General.MainExplorer.Form.Enabled = True
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'fixes the arcane and divine tags on spell definitions
    Public Shared Sub SpellFix()
        Try
            'cache everything required
            Dim NodeList As XmlNodeList
            Dim Obj As New Objects.ObjectData
            Dim TempList, Spells As ArrayList
            Dim Classes, SpellLevels As Hashtable

            'classes
            NodeList = XML.SelectNodes(XML.DBTypes.Classes, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ClassType & "']")
            Classes = New Hashtable(NodeList.Count)
            For Each Node As XmlNode In NodeList
                Obj.Clear()
                Obj.LoadFromNode(Node)
                Classes.Add(Obj.ObjectGUID, Obj)
            Next

            'spell defs and levels
            NodeList = XML.SelectNodes(XML.DBTypes.Spells, "/RPGXplorerDatabase/RPGXplorerObject")
            Spells = New ArrayList : SpellLevels = New Hashtable
            For Each Node As XmlNode In NodeList
                Obj.Clear()
                Obj.LoadFromNode(Node)
                Select Case Obj.Type
                    Case Objects.SpellDefinitionType
                        Spells.Add(Obj)
                    Case Objects.SpellLevelType
                        If SpellLevels.Contains(Obj.ParentGUID) Then
                            TempList = CType(SpellLevels(Obj.ParentGUID), ArrayList)
                            TempList.Add(Obj)
                        Else
                            TempList = New ArrayList
                            TempList.Add(Obj)
                            SpellLevels.Add(Obj.ParentGUID, TempList)
                        End If
                End Select
            Next

            'set ProgressBar
            Dim ProgressBar As ProgressBar
            General.MainExplorer.Form.Enabled = False
            ProgressBar = New ProgressBar
            ProgressBar.Caption = "Spell Definitions - Validating Caster Data"
            ProgressBar.Maximum = Spells.Count
            ProgressBar.TopMost = True
            ProgressBar.Show()

            'go through each spelldef
            For Each SpellDefinition As Objects.ObjectData In Spells

                Dim Arcane, Divine As Boolean
                Dim ClassObject As Objects.ObjectData

                'reset current tags
                SpellDefinition.Element("Arcane") = "" : Arcane = False
                SpellDefinition.Element("Divine") = "" : Divine = False

                'get the children
                Dim Children As ArrayList = CType(SpellLevels.Item(SpellDefinition.ObjectGUID), ArrayList)
                If Not Children Is Nothing Then
                    For Each SpellLevel As Objects.ObjectData In Children
                        Select Case Rules.SpellList.GetSpellLevelSourceElement(SpellLevel)
                            Case "Class"
                                ClassObject = CType(Classes.Item(SpellLevel.GetFKGuid("Class")), Objects.ObjectData)
                                If Not ClassObject.IsEmpty Then
                                    Select Case ClassObject.Element("CasterType")
                                        Case "Arcane"
                                            SpellDefinition.Element("Arcane") = "Yes"
                                            Arcane = True
                                        Case "Divine"
                                            SpellDefinition.Element("Divine") = "Yes"
                                            Divine = True
                                    End Select
                                End If
                            Case "Domain"
                                SpellDefinition.Element("Divine") = "Yes"
                                Divine = True
                        End Select
                        If Arcane AndAlso Divine Then Exit For
                    Next

                    'update ProgressBar
                    ProgressBar.Increment()
                    Application.DoEvents()
                End If
            Next

            'close ProgressBar
            ProgressBar.Close()
            General.MainExplorer.Form.Enabled = True

            'set flag
            General.Config.Element("SpellFix") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'duplicate system components fix
    Public Shared Sub DuplicateSystemComponentFix()
        Try
            Dim NodeList As XmlNodeList
            Dim Components As Hashtable
            Dim Obj As New Objects.ObjectData

            NodeList = XML.SelectNodes(XML.DBTypes.SystemComponents, "/RPGXplorerDatabase/RPGXplorerObject")
            Components = New Hashtable(NodeList.Count)

            For Each Node As XmlNode In NodeList
                Obj.Clear()
                Obj.LoadFromNode(Node)
                If Components.ContainsKey(Obj.ObjectGUID) Then
                    Obj.DeleteFast()
                Else
                    Components.Add(Obj.ObjectGUID, Obj)
                End If
            Next

            'set flag
            General.Config.Element("DuplicateSystemComponentsFix") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'duplicate skill group components fix
    Public Shared Sub DuplicateSkillGroupComponentFix()
        Try
            Dim NodeList As XmlNodeList
            Dim SkillGroups As Hashtable
            Dim Obj As New Objects.ObjectData

            NodeList = XML.SelectNodes(XML.DBTypes.Skills, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SkillGroupType & "']")
            SkillGroups = New Hashtable(NodeList.Count)

            For Each Node As XmlNode In NodeList
                Obj.Clear()
                Obj.LoadFromNode(Node)
                If SkillGroups.ContainsKey(Obj.ObjectGUID) Then
                    Obj.DeleteFast()
                Else
                    SkillGroups.Add(Obj.ObjectGUID, Obj)
                End If
            Next

            'set flag
            General.Config.Element("DuplicateSkillGroupsFix") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'ac base fix
    Public Shared Sub ACBaseFix()
        Try
            For n As Integer = 2 To XML.DBTypes.Count
                For Each Node As XmlNode In XML.SelectNodes(n, "//*[@FK='" & References.ArmorClassBase.ToString & "']")
                    Node.Attributes("FK").Value = References.ArmourClass.ToString
                    Node.InnerText = "Armor Class"
                Next
            Next

            'set flag
            General.Config.Element("ACBaseFix") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add in the pnew psionic folders
    Public Shared Sub PsionicPatch()
        Try

            'rename the magic item folders
            Dim MagicAbilityFolder As Objects.ObjectData
            MagicAbilityFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponMagicAbilityDefinitionFolderType & "']")
            If Not MagicAbilityFolder.IsEmpty Then
                MagicAbilityFolder.Name = "Magic Weapon Abilities"
                MagicAbilityFolder.Save()
            End If

            'rename the magic item folders
            Dim ArmorAbilityFolder As Objects.ObjectData
            ArmorAbilityFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ArmorMagicAbilityDefinitionFolderType & "']")
            If Not ArmorAbilityFolder.IsEmpty Then
                ArmorAbilityFolder.Name = "Magic Armor Abilities"
                ArmorAbilityFolder.Save()
            End If

            'add the psionic folders if they are not found
            Dim PowerDefinitionsFolder As Objects.ObjectData
            PowerDefinitionsFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PowerDefinitionFolderType & "']")
            If PowerDefinitionsFolder.IsEmpty Then
                PowerDefinitionsFolder.Name = "Psionic Powers"
                PowerDefinitionsFolder.ObjectGUID = New Objects.ObjectKey("001-93682f91-b766-464f-bc74-aC27816e5d86")
                PowerDefinitionsFolder.ParentGUID = New Objects.ObjectKey("001-00000000-0000-0000-0000-000000000001")
                PowerDefinitionsFolder.Type = Objects.PowerDefinitionFolderType
                PowerDefinitionsFolder.Save()
            End If

            Dim PowerDisciplinesFolder As Objects.ObjectData
            PowerDisciplinesFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicDisciplineFolderType & "']")
            If PowerDisciplinesFolder.IsEmpty Then
                PowerDisciplinesFolder.Name = "Psionic Disciplines"
                PowerDisciplinesFolder.ObjectGUID = New Objects.ObjectKey("001-6d8daf2b-9888-4ffa-8d79-5B4adaa998d3")
                PowerDisciplinesFolder.ParentGUID = New Objects.ObjectKey("001-00000000-0000-0000-0000-000000000001")
                PowerDisciplinesFolder.Type = Objects.PsionicDisciplineFolderType
                PowerDisciplinesFolder.Save()
            End If

            Dim PsionicSpecializationFolder As Objects.ObjectData
            PsionicSpecializationFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicSpecializationDefinitionFolderType & "']")
            If PsionicSpecializationFolder.IsEmpty Then
                PsionicSpecializationFolder.Name = "Psionic Specializations"
                PsionicSpecializationFolder.ObjectGUID = New Objects.ObjectKey("001-d3df0d31-7973-4773-a80d-3503b4031a33")
                PsionicSpecializationFolder.ParentGUID = New Objects.ObjectKey("001-00000000-0000-0000-0000-000000000001")
                PsionicSpecializationFolder.Type = Objects.PsionicSpecializationDefinitionFolderType
                PsionicSpecializationFolder.Save()
            End If

            Dim PsionicItemsFolder As Objects.ObjectData
            PsionicItemsFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SystemFolderType & "' and Name = 'Psionic Items']")
            If PsionicItemsFolder.IsEmpty Then
                PsionicItemsFolder.Name = "Psionic Items"
                PsionicItemsFolder.ObjectGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicItemsFolder.ParentGUID = New Objects.ObjectKey("001-00000000-0000-0000-0000-000000000001")
                PsionicItemsFolder.Type = Objects.SystemFolderType
                PsionicItemsFolder.Save()
            End If

            'item folders
            Dim PsionicArtifactsDefinitionFolder As Objects.ObjectData
            PsionicArtifactsDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArtifactDefinitionsFolderType & "']")
            If PsionicArtifactsDefinitionFolder.IsEmpty Then
                PsionicArtifactsDefinitionFolder.Name = "Psionic Artifacts"
                PsionicArtifactsDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-c5858d18-e693-4bfc-8b1a-08574fdb47f9")
                PsionicArtifactsDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicArtifactsDefinitionFolder.Type = Objects.PsionicArtifactDefinitionsFolderType
                PsionicArtifactsDefinitionFolder.Save()
            End If

            Dim PsionicWeaponsDefinitionFolder As Objects.ObjectData
            PsionicWeaponsDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponDefinitionsFolderType & "']")
            If PsionicWeaponsDefinitionFolder.IsEmpty Then
                PsionicWeaponsDefinitionFolder.Name = "Psionic Weapons"
                PsionicWeaponsDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-03d31502-b10b-4933-a562-d6811cdb3de1")
                PsionicWeaponsDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicWeaponsDefinitionFolder.Type = Objects.PsionicWeaponDefinitionsFolderType
                PsionicWeaponsDefinitionFolder.Save()
            End If

            Dim PsionicArmorDefinitionFolder As Objects.ObjectData
            PsionicArmorDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorDefinitionsFolderType & "']")
            If PsionicArmorDefinitionFolder.IsEmpty Then
                PsionicArmorDefinitionFolder.Name = "Psionic Armor"
                PsionicArmorDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-41b049bd-2e66-4d1c-84dd-0e0e8d6cc408")
                PsionicArmorDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicArmorDefinitionFolder.Type = Objects.PsionicArmorDefinitionsFolderType
                PsionicArmorDefinitionFolder.Save()
            End If

            Dim PsionicPsicrownsDefinitionFolder As Objects.ObjectData
            PsionicPsicrownsDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicPsicrownDefinitionFolderType & "']")
            If PsionicPsicrownsDefinitionFolder.IsEmpty Then
                PsionicPsicrownsDefinitionFolder.Name = "Psicrowns"
                PsionicPsicrownsDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-b3081f17-7773-430d-988b-782b4fa7346c")
                PsionicPsicrownsDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicPsicrownsDefinitionFolder.Type = Objects.PsionicPsicrownDefinitionFolderType
                PsionicPsicrownsDefinitionFolder.Save()
            End If

            Dim PsionicDorjesDefinitionFolder As Objects.ObjectData
            PsionicDorjesDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicDorjeDefinitionsFolderType & "']")
            If PsionicDorjesDefinitionFolder.IsEmpty Then
                PsionicDorjesDefinitionFolder.Name = "Dorjes"
                PsionicDorjesDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-79227ee3-0db2-4324-bA40-c4f237dc4554")
                PsionicDorjesDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicDorjesDefinitionFolder.Type = Objects.PsionicDorjeDefinitionsFolderType
                PsionicDorjesDefinitionFolder.Save()
            End If

            Dim PsionicPowerStoneDefinitionFolder As Objects.ObjectData
            PsionicPowerStoneDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicPowerStoneDefinitionsFolderType & "']")
            If PsionicPowerStoneDefinitionFolder.IsEmpty Then
                PsionicPowerStoneDefinitionFolder.Name = "Power Stones"
                PsionicPowerStoneDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-8ddd9e42-49c9-4591-8c95-4649bbe31527")
                PsionicPowerStoneDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicPowerStoneDefinitionFolder.Type = Objects.PsionicPowerStoneDefinitionsFolderType
                PsionicPowerStoneDefinitionFolder.Save()
            End If

            Dim PsionicTattooDefinitionFolder As Objects.ObjectData
            PsionicTattooDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicTattooDefinitionsFolderType & "']")
            If PsionicTattooDefinitionFolder.IsEmpty Then
                PsionicTattooDefinitionFolder.Name = "Tattoos"
                PsionicTattooDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-beadf847-3684-472e-b49d-df64101b9ea3")
                PsionicTattooDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicTattooDefinitionFolder.Type = Objects.PsionicTattooDefinitionsFolderType
                PsionicTattooDefinitionFolder.Save()
            End If

            Dim UniversalItemDefinitionFolderType As Objects.ObjectData
            UniversalItemDefinitionFolderType = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.UniversalItemDefinitionFolderType & "']")
            If UniversalItemDefinitionFolderType.IsEmpty Then
                UniversalItemDefinitionFolderType.Name = "Universal Items"
                UniversalItemDefinitionFolderType.ObjectGUID = New Objects.ObjectKey("001-867460ea-04fd-4937-9fe2-0ca345128337")
                UniversalItemDefinitionFolderType.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                UniversalItemDefinitionFolderType.Type = Objects.UniversalItemDefinitionFolderType
                UniversalItemDefinitionFolderType.Save()
            End If

            'ability folders
            'Dim PsionicWeaponAbilityDefinitionFolder As Objects.ObjectData
            PsionicWeaponsDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponAbilityDefinitionsFolderType & "']")
            If PsionicWeaponsDefinitionFolder.IsEmpty Then
                PsionicWeaponsDefinitionFolder.Name = "Psionic Weapon Abilities"
                PsionicWeaponsDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-0c3ed211-0e88-44f8-ab38-4b58962608f5")
                PsionicWeaponsDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicWeaponsDefinitionFolder.Type = Objects.PsionicWeaponAbilityDefinitionsFolderType
                PsionicWeaponsDefinitionFolder.Save()
            End If

            'Dim PsionicArmorAbilityDefinitionFolder As Objects.ObjectData
            PsionicArmorDefinitionFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorAbilityDefinitionsFolderType & "']")
            If PsionicArmorDefinitionFolder.IsEmpty Then
                PsionicArmorDefinitionFolder.Name = "Psionic Armor Abilities"
                PsionicArmorDefinitionFolder.ObjectGUID = New Objects.ObjectKey("001-b685a3bd-6d86-4c85-8f3a-906b63d28397")
                PsionicArmorDefinitionFolder.ParentGUID = New Objects.ObjectKey("001-0db9eea4-5708-4a29-a42f-dad065f4aae5")
                PsionicArmorDefinitionFolder.Type = Objects.PsionicArmorAbilityDefinitionsFolderType
                PsionicArmorDefinitionFolder.Save()
            End If

            'removal of old rule page nodes
            Dim RulePowersFolder As New Objects.ObjectData
            RulePowersFolder.Load(New Objects.ObjectKey("002-4ad4224a-dbea-47a2-89cd-60bbc8d49516"))
            If Not RulePowersFolder.IsEmpty Then
                RulePowersFolder.DeleteFast()
            End If

            Dim RulePsionicFeatsFolder As New Objects.ObjectData
            Dim MetapsionicKey As New Objects.ObjectKey("002-4a84574c-a7de-4122-b280-6e6d1753ddd5")
            Dim PsionicCreationKey As New Objects.ObjectKey("002-462a4fc4-4e0a-467a-8010-16abe4941215")
            RulePsionicFeatsFolder.Load(New Objects.ObjectKey("002-705c4276-c348-4ffb-9d7c-7a0508712308"))
            If Not RulePsionicFeatsFolder.IsEmpty Then
                For Each FeatObject As Objects.ObjectData In RulePsionicFeatsFolder.Children
                    If Not (FeatObject.ObjectGUID.Equals(MetapsionicKey) OrElse FeatObject.ObjectGUID.Equals(PsionicCreationKey)) Then
                        FeatObject.DeleteFast()
                    End If
                Next
            End If

            'PsionicHelpPatch()

            'set flag
            General.Config.Element("PsionicPatch") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'adds the special materials folder
    Public Shared Sub MaterialsPatch()
        Try
            'add the psionic folders if they are not found
            Dim SpecialMaterialDefinitionsFolder As Objects.ObjectData
            SpecialMaterialDefinitionsFolder = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecialMaterialDefinitionsFolderType & "']")
            If SpecialMaterialDefinitionsFolder.IsEmpty Then
                SpecialMaterialDefinitionsFolder.Name = "Special Materials"
                SpecialMaterialDefinitionsFolder.ObjectGUID = New Objects.ObjectKey("001-cb61d093-b892-4f36-a060-d10abf25df1a")
                SpecialMaterialDefinitionsFolder.ParentGUID = New Objects.ObjectKey("001-00000000-0000-0000-0000-000000000001")
                SpecialMaterialDefinitionsFolder.Type = Objects.SpecialMaterialDefinitionsFolderType
                SpecialMaterialDefinitionsFolder.Save()
            End If

            'set flag
            General.Config.Element("MaterialPatch") = "True"

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub PsionicHelpPatch()
        Try
            'update the nodes without pages
            Dim BaseString As String = General.HelpPath
            Dim RulePageNode As New Objects.ObjectData
            Dim FileName As String, FileInfo As RulePagePath

            ''race
            RulePageNode.Load(New Objects.ObjectKey("002-aa0ef02f-a24a-4403-80d5-9d1e2e439af7"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Races\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Races\" & FileInfo.Filename
                End Try
            Next

            'Classes 	
            RulePageNode.Load(New Objects.ObjectKey("002-909a0893-f810-4e8c-927c-6716f4853dc8"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Classes\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Classes\" & FileInfo.Filename
                End Try
            Next

            'Weapons abilities 	
            RulePageNode.Load(New Objects.ObjectKey("002-baf8b208-eeec-4ee8-b638-1db2a39eeb47"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Psionic Weapon Abilities\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Psionic Weapon Abilities\" & FileInfo.Filename
                End Try
            Next

            'Armor abilities 	
            RulePageNode.Load(New Objects.ObjectKey("002-16d2cabb-f9ac-4ef4-bdae-da69e75bf67f"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Psionic Armor Abilities\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Psionic Armor Abilities\" & FileInfo.Filename
                End Try
            Next

            'Psicrowns			
            RulePageNode.Load(New Objects.ObjectKey("002-26d191d1-7074-40cf-a7f2-9abab383e99d"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Psicrowns\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Psicrowns\" & FileInfo.Filename
                End Try
            Next

            'Universal Items				
            RulePageNode.Load(New Objects.ObjectKey("002-469fc3cf-1a8a-48b8-b175-7bc83862da21"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Universal Items\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Universal Items\" & FileInfo.Filename
                End Try
            Next

            'Artifacts				
            RulePageNode.Load(New Objects.ObjectKey("002-20bd3a5a-aad0-41b4-9d0a-67c100a0f9d9"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Psionic Artifacts\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Psionic Artifacts\" & FileInfo.Filename
                End Try
            Next

            'disciplines			
            RulePageNode.Load(New Objects.ObjectKey("002-22352022-9413-42c0-8ae4-9b9e7cd3a9d2"))
            For Each ChildNode As Objects.ObjectData In RulePageNode.Children
                FileName = BaseString & ChildNode.HTML
                FileInfo = New RulePagePath(FileName)
                Try
                    If Not System.IO.File.Exists(FileName) Then
                        ChildNode.Element("HTML") = "Psionic Disciplines\" & FileInfo.Filename
                    End If
                Catch ex As Exception
                    ChildNode.Element("HTML") = "Psionic Disciplines\" & FileInfo.Filename
                End Try
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class