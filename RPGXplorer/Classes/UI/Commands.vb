Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Objects
Imports RPGXplorer.XML

Imports System.Windows.Forms

Imports DevExpress.XtraBars

Public Class Commands

    'member variables 
    Public Shared EditForm As Object
    Private Shared DataInputModePanelRedisplay As Boolean

    'this class is responsible for handling all the command buttons from toolbars, popup menus etc.

    'helper for handler that adds an object to a folder
    Private Shared Function GetFolder() As Objects.ObjectData
        Try
            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    If General.MainExplorer.SelectedObjectCount = 0 Then
                        Return General.MainExplorer.ObjectSelectedInTree
                    Else
                        Return General.MainExplorer.CurrentSelectedObjects.Item(0)
                    End If
                Case Explorer.Focus.TreeView
                    Return General.MainExplorer.ObjectSelectedInTree
                Case Explorer.Focus.NotSet
                    Throw New DevelopmentException("Focus not set")
            End Select
            Return Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'helper for handler that adds an object to a folder
    Private Shared Function GetEditObject() As Objects.ObjectData
        Try
            Select Case General.MainExplorer.CurrentFocus

                Case Explorer.Focus.ListView

                    Dim TempObjCollection As Objects.ObjectDataCollection
                    TempObjCollection = General.MainExplorer.CurrentSelectedObjects

                    If TempObjCollection.Count = 0 Then
                        Return General.MainExplorer.ObjectSelectedInTree
                    Else
                        Return TempObjCollection.Item(0)
                    End If

                Case Explorer.Focus.TreeView
                    Return General.MainExplorer.ObjectSelectedInTree

                Case Else
                    Throw New DevelopmentException("Focus incorrect")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'select the folder's tab if open otherwise open in new tab
    Public Shared Function SelectCorrectFolder(ByVal e As DevExpress.XtraBars.ItemClickEventArgs) As Objects.ObjectData
        'if the command is being called manually the link will be nothing
        If e Is Nothing Then Return GetFolder()

        'if we are selecting the command from the pop-menu, we are already on the correct folder
        If e.Link.OwnerItem Is Nothing Then Return GetFolder()

        'if its from the component menu we are also on the correct folder
        If e.Link.OwnerItem.Name = "Component" Then Return GetFolder()

        Dim Folder As New Objects.ObjectData

        Select Case e.Item.Name
            Case "AddAmmunitionDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionFolderType & "']")
            Case "AddArmororShieldDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ArmorDefinitionFolderType & "']")
            Case "AddCharacter", "AddNewCharacter", "AddNewCompanion"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.CharacterFolderType & "']")
            Case "AddNewMonsterCharacter", "AddNewMonsterCompanion"
                Folder.Load(References.MonstersFolderKey)
            Case "AddClass"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ClassFolderType & "']")
            Case "AddDeityDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.DeityDefinitionFolderType & "']")
            Case "AddDomainDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.DomainDefinitionFolderType & "']")
            Case "AddFeatDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatDefinitionsFolderType & "']")
            Case "AddFeatureDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatureDefinitionFolderType & "']")
            Case "AddItemDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ItemDefinitionFolderType & "']")
            Case "AddLanguage"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.LanguageDefinitionFolderType & "']")
            Case "AddModifierLimiter"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ModifierLimiterFolderType & "']")
            Case "AddMonsterType"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.MonsterTypeFolderType & "']")
            Case "AddNaturalWeaponDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionFolderType & "']")
            Case "AddPowerDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PowerDefinitionFolderType & "']")
            Case "AddPsionicDiscipline"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicDisciplineFolderType & "']")
            Case "AddPsionicSpecialization"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicSpecializationDefinitionFolderType & "']")
            Case "AddRace"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.RaceFolderType & "']")
            Case "AddSkillDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SkillDefinitionFolderType & "']")
            Case "AddSpellCategory"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellCategoryFolder & "']")
            Case "AddSpellDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellDefinitionFolderType & "']")
            Case "AddSpellDescriptor"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellDescriptorDefinitionFolderType & "']")
            Case "AddSpellSchool"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellSchoolFolderType & "']")
            Case "AddWeaponDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionFolderType & "']")
            Case "AddArmorMagicAbilityDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ArmorMagicAbilityDefinitionFolderType & "']")
            Case "AddArtifactDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ArtifactDefinitionFolderType & "']")
            Case "AddMagicAmmoDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificWeaponDefinitionFolderType & "']")
            Case "AddMagicArmorDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificArmorDefinitionFolderType & "']")
            Case "AddMagicWeaponDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificWeaponDefinitionFolderType & "']")
            Case "AddPotionDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PotionDefinitionFolderType & "']")
            Case "AddRingDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.RingDefinitionFolderType & "']")
            Case "AddRodDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.RodDefinitionFolderType & "']")
            Case "AddScrollDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ScrollDefinitionFolderType & "']")
            Case "AddStaffDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.StaffDefinitionFolderType & "']")
            Case "AddWandDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WandDefinitionFolderType & "']")
            Case "AddWeaponMagicAbilityDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponMagicAbilityDefinitionFolderType & "']")
            Case "AddWondrousItemDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WondrousDefinitionFolderType & "']")
            Case "AddDorjeDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicDorjeDefinitionsFolderType & "']")
            Case "AddPowerStoneDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicPowerStoneDefinitionsFolderType & "']")
            Case "AddPsicrownDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicPsicrownDefinitionFolderType & "']")
            Case "AddPsionicAmmoDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponDefinitionsFolderType & "']")
            Case "AddPsionicArmorAbilityDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorAbilityDefinitionsFolderType & "']")
            Case "AddPsionicArmorDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorDefinitionsFolderType & "']")
            Case "AddPsionicArtifactDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArtifactDefinitionsFolderType & "']")
            Case "AddPsionicTattooDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicTattooDefinitionsFolderType & "']")
            Case "AddPsionicWeaponAbilityDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponAbilityDefinitionsFolderType & "']")
            Case "AddPsionicWeaponDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponDefinitionsFolderType & "']")
            Case "AddUniversalItemDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.UniversalItemDefinitionFolderType & "']")
            Case "AddMonsterClass"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.MonsterClassFolderType & "']")
            Case "AddMonsterRace"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.MonsterRaceDefinitionFolderType & "']")
            Case "AddNaturalWeaponDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.NaturalWeaponDefinitionsFolderType & "']")
            Case "AddSubtypeDefinition"
                Folder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SubtypeDefinitionsFolderType & "']")
        End Select

        'select the folder or open it
        General.MainExplorer.TreeView.SelectedNode = DirectCast(General.MainExplorer.TreeNodes(Folder.ObjectGUID), TreeNode)

        Return Folder
    End Function

    'handles the Show Help command
    Public Shared Sub ShowHelp(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim Obj, HelpObj As Objects.ObjectData
        'Dim HelpPage As String
        '???
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "File Menu Commands"

    'create a new database
    Public Shared Sub CreateDatabase(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'open a different database
    Public Shared Sub OpenDatabase(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Load Objects command
    Public Shared Sub LoadObjects(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            SaveLoad.LoadComponents(General.MainExplorer.Form)
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Save Objects command
    Public Shared Sub SaveObjects(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            SaveLoad.SaveComponents(General.MainExplorer.Form, General.MainExplorer.CurrentSelectedObjects)
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Export Lists command
    Public Shared Sub ExportLists(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim Objs As New Objects.ObjectDataCollection

            Objs.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.UserListItemType))

            SaveLoad.SaveComponents(General.MainExplorer.Form, Objs, False)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Export Filters command
    Public Shared Sub ExportFilters(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim Objs As New Objects.ObjectDataCollection

            Objs.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.FilterType))

            SaveLoad.SaveComponents(General.MainExplorer.Form, Objs, False)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Exit command
    Public Shared Sub ExitApplication(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.SaveConfig()

            'save tab layout
            WindowManager.SaveTabs()
            WindowManager.SuspendEvents = True

            'save currently visible panels
            General.MainExplorer.SaveCurrentPanel()

            'save the rules browser
            If Not General.RulesViewer Is Nothing Then
                If General.RulesViewer.Visible Then
                    General.RulesViewer.Close()
                End If
            End If

            'save db - this also saves the TreeView
            XML.SaveXMLDB()

            'save main window layout
            General.MainExplorer.Form.DockManager1.SaveToXml(General.BasePath & "XML\DockLayout.xml")

            'save FKLookup Table
            'XML.SaveFKLookup() - Reverted to old method

            'if the exit did not come directly from the close window button then exit manually
            If TypeOf sender Is RPGXplorer.MainWindow Then
                Application.ExitThread()
                Application.Exit()
            Else
                Application.ExitThread()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Save Database command
    Public Shared Sub SaveDatabase(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            XML.SaveXMLDB()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Add Object Commands"

    'handles the Add Ammo Definition command
    Public Shared Sub AddAmmoDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New AmmoForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)

            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Commands.AddAmmoDefinition(Nothing, Nothing)
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Armor Definition command
    Public Shared Sub AddArmorDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ArmorForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)

            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Armor Magic Ability Definition command
    Public Shared Sub AddArmorMagicAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ArmorMagicAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)

            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Artifact Definition command
    Public Shared Sub AddArtifactDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ArtifactForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)

            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Bonus Class Skill command
    Public Shared Sub AddBonusClassSkill(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.BonusClassSkillType, "Bonus Class Skill", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Bonus Domain command
    Public Shared Sub AddBonusDomain(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.BonusDomainType, "Bonus Domain", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Bonus Feat command
    Public Shared Sub AddBonusFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.BonusFeatType, "Bonus Feat", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Bonus Language command
    Public Shared Sub AddBonusLanguage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.ChooseBonusLanguageType, "Bonus Language", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Bonus Psionic Specialization command
    Public Shared Sub AddBonusPsionicSpecialization(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.BonusPsionicSpecializationType, "Bonus Psionic Specialization", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Character command
    Public Shared Sub AddCharacter(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CharacterForm
        Dim CharacterFolder As Objects.ObjectData

        Try
            CharacterFolder = SelectCorrectFolder(e)
            AddForm.InitAdd(CharacterFolder)
            AddForm.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Character Level Object command
    Public Shared Sub AddCharacterLevel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Undo.UndoRecord()
            AddCharacterLevel(CharacterManager.CurrentCharacter.CharacterObject)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'required for Add Character Level and Character Form
    Public Shared Sub AddCharacterLevel(ByVal Character As Objects.ObjectData)
        Try
            Dim WizardMgr As New WizardManager
            Dim Wizard As LevellingUpWizard

            'init the wizard and manager            
            Wizard = New LevellingUpWizard(Character)
            WizardMgr.Init(Wizard, "Add Levels Wizard")
            WizardMgr.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Choose Bonus Feat command
    Public Shared Sub AddChooseBonusFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ChooseBonusFeatForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Choose Bonus Feat command
    Public Shared Sub AddChooseBonusFeatType(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ChooseBonusFeatOfTypeForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Choose Feature command
    Public Shared Sub AddChooseFeature(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ChooseFeatureForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Class command
    Public Shared Sub AddClass(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ClassForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            If Folder.Type <> Objects.ClassFolderType Then Throw New DevelopmentException("Folder type incorrect")
            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Class Level command
    Public Shared Sub AddClassLevel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            'check to see if max levels has been exceeded (+ command only)
            If sender Is Nothing Then
                Select Case Folder.Type
                    Case Objects.ClassLevelsFolderType
                        If Folder.ChildrenOfType(Objects.ClassLevelType).Count = Rules.Constants.MaxLevels Then
                            General.ShowInfoDialog("You cannot add another level to this class, it already has " & Rules.Constants.MaxLevels.ToString & " levels.")
                            Exit Sub
                        End If
                    Case Objects.MonsterClassLevelsFolderType
                        If Folder.ChildrenOfType(Objects.MonsterClassLevelType).Count = Rules.Constants.MaxLevels Then
                            General.ShowInfoDialog("You cannot add another level to this class, it already has " & Rules.Constants.MaxLevels.ToString & " levels.")
                            Exit Sub
                        End If
                End Select

            End If

            Dim AddForm As New ClassLevelForm
            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Class Skill command - NOT IN USE?
    Public Shared Sub AddClassSkill(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SkillDefinitionType, Objects.ClassSkillType, "Class Skill", "Skill")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Companion command
    Public Shared Sub AddCompanion(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New FamiliarForm
        Dim CharacterFolder As Objects.ObjectData

        Try
            CharacterFolder = SelectCorrectFolder(e)
            AddForm.InitAdd(CharacterFolder)
            AddForm.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Condition command
    Public Shared Sub AddCondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ConditionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()
            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Combat Style command
    Public Shared Sub AddCombatStyle(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CombatStyleForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            If AddForm.InitAdd(Folder) Then AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Damage Addition command
    Public Shared Sub AddDamageAddition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New DamageAdditionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Damage Reduction command
    Public Shared Sub AddDamageReduction(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New DamageReductionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Damage Resistance command
    Public Shared Sub AddDamageResistance(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New DamageResistanceForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            If AddForm.InitAdd(Folder) Then AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Deity Definition command
    Public Shared Sub AddDeityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New DeityForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Domain Definition command
    Public Shared Sub AddDomainDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New DomainForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Dorje Definition command
    Public Shared Sub AddDorjeDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New DorjeForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Enhancment command
    Public Shared Sub AddEnhancement(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New EnhancementForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Expiry Condition command - NOT IN USE
    Public Shared Sub AddExpiryCondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim AddForm As New ExpiryConditionForm
        'Dim Folder As Objects.ObjectData

        'Try
        '    'retrieve the folder that we are adding an object to
        '    Folder = GetFolder()
        '    AddForm.InitAdd(Folder)
        '    AddForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Add Feat Definition command
    Public Shared Sub AddFeatDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New FeatForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feature command
    Public Shared Sub AddFeature(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder, Feature As Objects.ObjectData
        Dim ExcludeGuidList As New ArrayList
        Dim ExistingFeatures As Objects.ObjectDataCollection

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            'get a list of features to exclude from the list of those available to add
            If Folder.Type <> Objects.RaceType AndAlso Folder.Type <> Objects.MonsterRaceDefinitionType AndAlso Folder.Type <> Objects.MonsterClassLevelType AndAlso Folder.Type <> Objects.SubtypeDefinitionType Then
                ExcludeGuidList.AddRange(Objects.GetObjectsByXPath(Xml.DBTypes.Features, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatureDefinitionType & "' and FeatureType='Natural']").GetGuidList)
            End If

            ExistingFeatures = Folder.ChildrenOfType(Objects.FeatureType)
            For Each Feature In ExistingFeatures
                If Feature.Element("CanBeTakenMultipleTimes") = "" Then
                    ExcludeGuidList.Add(Feature.GetFKGuid("Feature"))
                End If
            Next

            AddForm.InitAdd(Folder, Objects.FeatureDefinitionType, Objects.FeatureType, "Feature", "Feature", ExcludeGuidList)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feature Definition command
    Public Shared Sub AddFeatureDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New FeatureForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Fighter Bonus Feat command
    Public Shared Sub AddFighterBonusFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.FighterBonusFeatType, "Fighter Bonus Feat", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Flurry of Blows command
    Public Shared Sub AddFlurryOfBlows(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New FlurryOfBlowsForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Folder command - NOT USED ANYWHERE
    Public Shared Sub AddFolder(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As New Objects.ObjectData
        Dim ParentFolder As Objects.ObjectData

        Try
            'retrieve the locations folder that we are adding a location to
            ParentFolder = GetFolder()
            Folder.Name = "New Folder"
            Folder.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.UserDocs)
            Folder.Type = Objects.UserFolderType
            Folder.Fixed = False
            Folder.ParentGUID = ParentFolder.ObjectGUID
            Folder.Save()

            General.MainExplorer.Refresh()
            General.MainExplorer.SelectItemByGuid(Folder.ObjectGUID)

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Granted Power command
    Public Shared Sub AddGrantedPower(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.FeatureDefinitionType, Objects.GrantedPowerType, "Feature", "Feature")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add HTML Doc command - NOT IN USE
    Public Shared Sub AddHTMLDoc(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim HTMLDoc, Folder As Objects.ObjectData
        'Dim HTMLDocForm As New HTMLDocumentForm

        'Try
        '    'retrieve the folder
        '    Folder = GetFolder()
        '    If Folder.IsEmpty Then Throw New DevelopmentException("Folder IsEmpty = True")

        '    'initialise and open the form
        '    HTMLDocForm.Init(Objects.AddHTMLDoc(Folder))
        '    General.MainExplorer.Refresh()
        '    HTMLDocForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Add Improved Unarmed Damage command
    Public Shared Sub AddImprovedUnarmedDamage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ImprovedUnarmedDamageForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Intelligence command - NOT IN USE
    Public Shared Sub AddIntelligence(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim AddForm As New IntelForm
        'Dim Folder As Objects.ObjectData

        'Try
        '    'retrieve the folder that we are adding an object to
        '    Folder = GetFolder()
        '    AddForm.InitAdd(Folder)
        '    AddForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Add Item Definition command
    Public Shared Sub AddItemDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ItemForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            If Folder.Type <> Objects.ItemDefinitionFolderType Then Throw New DevelopmentException("Folder type incorrect")
            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Item command
    Public Shared Sub AddItem(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CustomItemForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Language command
    Public Shared Sub AddLanguage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder, Objects.LanguageDefinitionType, "Language", XML.DBTypes.Languages)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Location command - NOT IN USE
    Public Shared Sub AddLocation(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim Location, LocationFolder As Objects.ObjectData

        Try
            'retrieve the locations folder that we are adding a location to
            'LocationFolder = GetFolder()

            'If LocationFolder.Type <> Objects.LocationsFolderType And LocationFolder.Type <> Objects.LocationType Then Throw New DevelopmentException("Container Object should be either a Locations Folder or a Location")

            ''initialise and open the form
            'Objects.AddLocation(LocationFolder)
            'General.MainExplorer.Refresh()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Magic Ammo Definition command
    Public Shared Sub AddMagicAmmoDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New MagicAmmoForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Modifier command
    Public Shared Sub AddModifier(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ModifierForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()
            If AddForm.InitAdd(Folder) Then AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Modifier Limiter command
    Public Shared Sub AddModifierLimiter(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder, Objects.ModifierLimiterType, "Limiter", XML.DBTypes.ModifierLimiters)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Character command
    Public Shared Sub AddMonster(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New MonsterForm
        Dim MonsterFolder As Objects.ObjectData

        Try
            MonsterFolder = SelectCorrectFolder(e)
            AddForm.InitAdd(MonsterFolder)
            AddForm.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'adds a character to the monster folder
    Public Shared Sub AddMonsterCharacter(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CharacterForm
        Dim MonsterFolder As Objects.ObjectData

        Try
            MonsterFolder = SelectCorrectFolder(e)
            AddForm.InitAdd(MonsterFolder)
            AddForm.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Monster Companion command
    Public Shared Sub AddMonsterCompanion(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New FamiliarForm
        Dim MonsterFolder As Objects.ObjectData

        Try
            MonsterFolder = SelectCorrectFolder(e)
            AddForm.InitAdd(MonsterFolder)
            AddForm.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Monster Class command
    Public Shared Sub AddMonsterClass(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New MonsterClassForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            If Folder.Type <> Objects.MonsterClassFolderType Then Throw New DevelopmentException("Folder type incorrect")
            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'required for Add Character Level and Character Form
    Public Shared Sub AddMonsterLevels(ByVal Monster As Objects.ObjectData)
        Try
            Dim WizardMgr As New WizardManager
            Dim Wizard As LevellingUpWizard

            'init the wizard and manager            
            Wizard = New LevellingUpWizard(Monster)
            WizardMgr.Init(Wizard, "Adding Monster Levels")
            WizardMgr.ShowDialog()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Class command
    Public Shared Sub AddMonsterRace(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New MonsterRaceForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            If Folder.Type <> Objects.MonsterRaceDefinitionFolderType Then Throw New DevelopmentException("Folder type incorrect")
            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Monster Type command
    Public Shared Sub AddMonsterType(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New MonsterTypeForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Weapon Definition command
    Public Shared Sub AddNaturalWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New NaturalWeaponForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Potion Definition command
    Public Shared Sub AddPotionDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PotionForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Power Definition Command
    Public Shared Sub AddPowerDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PowerForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Handles the Add Scroll Definition Command
    Public Shared Sub AddPowerStoneDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PowerStoneForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Prerequisite command
    Public Shared Sub AddPrerequisite(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PrerequisiteForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Prestige Spellcasting Class command
    Public Shared Sub AddPrestigeSpellcastingClass(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.ExistingSpellcasterLevel, "Prestige Caster Progression", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Prestige Manifesting Class command
    Public Shared Sub AddPrestigeManifestingClass(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.ExistingManifesterLevel, "Prestige Manifester Progression", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Like Ability  command
    Public Shared Sub AddPsiLikeAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsiLikeAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Ammo Definition command
    Public Shared Sub AddPsionicAmmoDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicAmmoForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Commands.AddPsionicAmmoDefinition(Nothing, Nothing)
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Armor Ability Definition command
    Public Shared Sub AddPsionicArmorAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicArmorAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Armor Definition command
    Public Shared Sub AddPsionicArmorDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicArmorForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Artifact Definition command
    Public Shared Sub AddPsionicArtifactDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicArtifactForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)

            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psicrown command
    Public Shared Sub AddPsicrownDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsicrownForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Discipline Command
    Public Shared Sub AddPsionicDisciplineDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PowerDisciplineForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Discipline Specialization command
    Public Shared Sub AddPsionicSpecializationDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicSpecializationForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Subdiscipline command
    Public Shared Sub AddPsionicSubdisciple(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.PsionicSubdisciplineType, "Subdiscipline", Xml.DBTypes.SpellSchools)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Tattoo Definition command
    Public Shared Sub AddPsionicTattooDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicTattooForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Weapon Ability command
    Public Shared Sub AddPsionicWeaponAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder, MagicWeapon As Objects.ObjectData
        Dim Exclusions As New ArrayList
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            'build exclusion list
            If Folder.Type = Objects.ConditionType Then MagicWeapon = Folder.Parent Else MagicWeapon = Folder

            For Each Ability As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.PsionicWeaponAbilityType)
                Exclusions.Add(Ability.GetFKGuid("WeaponAbility"))
            Next

            For Each Ability As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.PsionicWeaponAbilityDoubleType)
                Exclusions.Add(Ability.GetFKGuid("WeaponAbility"))
            Next

            For Each Condition As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.ConditionType)
                For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.PsionicWeaponAbilityConditionalType)
                    Exclusions.Add(Ability.GetFKGuid("WeaponAbility"))
                Next
            Next

            AddForm.InitAdd(Folder, Objects.PsionicWeaponAbilityDefinitionType, Objects.PsionicWeaponAbilityConditionalType, "Ability", "WeaponAbility", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Weapon Ability Definition command
    Public Shared Sub AddPsionicWeaponAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicWeaponAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Weapon Definition command
    Public Shared Sub AddPsionicWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsionicWeaponForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Race command
    Public Shared Sub AddRace(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New RaceForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Racial Weapon command
    Public Shared Sub AddRacialWeapon(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            Exclusions.AddRange(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.NonExoticWeapons).GetGuidList)
            Exclusions.AddRange(Folder.ChildrenOfType(Objects.RacialWeaponType).GetGuidList)

            AddForm.InitAdd(Folder, Objects.WeaponDefinitionType, Objects.RacialWeaponType, "Weapon", "Weapon", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Regeneration command
    Public Shared Sub AddRegeneration(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New RegenerationForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Replace Known Spell command
    Public Shared Sub AddReplaceKnownSpell(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()
            Folder = GetFolder()
            Objects.AddSimpleObject(Objects.ReplaceKnownSpellType, "Replace Known Spell", Folder.ObjectGUID, Folder.ObjectGUID.Database)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Ring Definition command
    Public Shared Sub AddRingDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New RingForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Rod Definition command
    Public Shared Sub AddRodDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New RodForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Special Material Definition command
    Public Shared Sub AddSpecialMaterialDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpecialMaterialForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Handles the Add Scroll Definition Command
    Public Shared Sub AddScrollDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ScrollForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Handles the Add Set Ability Command
    Public Shared Sub AddSetAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SetAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Handles the Set Value Command
    Public Shared Sub AddSetValue(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SetValueForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Handles the Add Skill Ability Command
    Public Shared Sub AddSkillAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SkillAbilityExchnageForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Skill Definition command
    Public Shared Sub AddSkillDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SkillForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Skill Synergy command
    Public Shared Sub AddSkillSynergy(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SkillSynergyForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specific Armor Definition command
    Public Shared Sub AddSpecificArmorDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpecificArmorForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specific Bonus Feat command
    Public Shared Sub AddSpecificBonusFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpecificBonusFeatForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specific/Choose Bonus Class Skill command
    Public Shared Sub AddSpecificOrChooseBonusClassSkill(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New GenericChooseBonusForm

        Try
            Dim Skills As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.Skills, Objects.SkillDefinitionType)
            Skills.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.Skills, Objects.SkillGroupType))
            Form.InitAdd(GetFolder(), Objects.BonusClassSkillChoiceOrSpecificType, Skills, "Bonus Class Skill", AddressOf Rules.Skills.IsValidAdd)
            Form.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specific/Choose Bonus Domain command
    Public Shared Sub AddSpecificOrChooseBonusDomain(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New GenericChooseBonusForm

        Try
            Form.InitAdd(GetFolder(), Objects.BonusDomainChoiceOrSpecificType, Objects.GetAllObjectsOfType(Xml.DBTypes.Domains, Objects.DomainDefinitionType), "Bonus Domain")
            Form.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specific/Choose Bonus Psionic Specialization command
    Public Shared Sub AddSpecificOrChooseBonusPsionicSpecialization(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New GenericChooseBonusForm

        Try
            Form.InitAdd(GetFolder(), Objects.BonusPsionicSpecializationChoiceorSpecificType, Objects.GetAllObjectsOfType(Xml.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType), "Bonus Psionic Specialization")
            Form.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specific Weapon Definition command
    Public Shared Sub AddSpecificWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpecificWeaponForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Descriptor command
    Public Shared Sub AddSpellCategory(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder, Objects.SpellCategoryDefinitionType, "Category", XML.DBTypes.SpellCategoriesAndDescriptors)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Definition Command
    Public Shared Sub AddSpellDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Descriptor command
    Public Shared Sub AddSpellDescriptor(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder, Objects.SpellDescriptorDefinitionType, "Descriptor", XML.DBTypes.SpellCategoriesAndDescriptors)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Failure command
    Public Shared Sub AddSpellFailure(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellFailureForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Like Ability  command
    Public Shared Sub AddSpellLikeAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellLikeAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spells Known command - NOT IN USE
    Public Shared Sub AddSpellsKnown(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellLevelsForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SpellsKnownType)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Resistance command
    Public Shared Sub AddSpellResistance(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleNumericalForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SpellResistanceType, "Spell Resistance", 1, 100)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell School command
    Public Shared Sub AddSpellSchool(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellSchoolForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell Subschool command
    Public Shared Sub AddSpellSubschool(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()
            AddForm.InitAdd(Folder, Objects.SpellSubschoolType, "Subschool", Xml.DBTypes.SpellSchools)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spells Per Day command - NOT IN USE
    Public Shared Sub AddSpellsPerDay(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellLevelsForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SpellsPerDayType)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Staff command
    Public Shared Sub AddStaffDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New StaffForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Subtype
    Public Shared Sub AddSubtypeDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SubtypeForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Ability command
    Public Shared Sub AddSystemAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            For Each Ability As Objects.ObjectData In Folder.ChildrenOfType(Objects.SystemAbilityType)
                Exclusions.Add(Ability.GetFKGuid("SystemAbilityDefinition"))
            Next

            AddForm.InitAdd(Folder, Objects.SystemAbilityDefinitionType, Objects.SystemAbilityType, "Ability", "SystemAbilityDefinition", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Ability Definition command
    Public Shared Sub AddSystemAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SystemAbilityDefinitionType, XML.DBTypes.SystemComponents, "Ability")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Alignment Definition command
    Public Shared Sub AddSystemAlignmentDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim AddForm As New SimpleForm
        'Dim Folder As Objects.ObjectData

        'Try
        '    'retrieve the folder that we are adding an object to
        '    Folder = GetFolder()

        '    AddForm.InitAdd(Folder, Objects.SystemAlignmentDefinitionType, "Alignment")
        '    AddForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Add System Condition command
    Public Shared Sub AddSystemCondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SystemConditionType, XML.DBTypes.SystemComponents, "Condition")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Element command
    Public Shared Sub AddSystemElement(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SystemElementForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Precondition command
    Public Shared Sub AddSystemPrecondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            For Each Precondition As Objects.ObjectData In Folder.ChildrenOfType(Objects.SystemPreconditionType)
                Exclusions.Add(Precondition.GetFKGuid("SystemPreconditionDefinition"))
            Next

            AddForm.InitAdd(Folder, Objects.SystemPreconditionDefinitionType, Objects.SystemPreconditionType, "Precondition", "SystemPreconditionDefinition", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Precondition Definition command
    Public Shared Sub AddSystemPreconditionDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SystemPreconditionDefinitionType, "Precondition", XML.DBTypes.SystemComponents)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Reference
    Public Shared Sub AddSystemReference(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SystemReferenceForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Restriction command
    Public Shared Sub AddSystemRestriction(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SystemRestrictionDefinitionType, Objects.SystemRestrictionType, "Restriction", "SystemRestrictionDefinition")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Restriction Definition command
    Public Shared Sub AddSystemRestrictionDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SystemRestrictionDefinitionType, XML.DBTypes.SystemComponents, "Restriction")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Weapon Ability command
    Public Shared Sub AddSystemWeaponAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder, MagicWeapon As Objects.ObjectData
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            'build exclusion list
            If Folder.Type = Objects.ConditionType Then MagicWeapon = Folder.Parent Else MagicWeapon = Folder

            For Each Ability As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.SystemWeaponAbilityType)
                Exclusions.Add(Ability.GetFKGuid("SystemWeaponAbilityDefinition"))
            Next

            For Each Condition As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.ConditionType)
                For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.SystemWeaponAbilityType)
                    Exclusions.Add(Ability.GetFKGuid("SystemWeaponAbilityDefinition"))
                Next
            Next

            AddForm.InitAdd(Folder, Objects.SystemWeaponAbilityDefinitionType, Objects.SystemWeaponAbilityType, "Ability", "SystemWeaponAbilityDefinition", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add System Weapon Ability Definition command
    Public Shared Sub AddSystemWeaponAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.SystemWeaponAbilityDefinitionType, XML.DBTypes.SystemComponents, "Ability")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Wondrous Item command
    Public Shared Sub AddUniversalDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New UniversalItemForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add User Document command
    Public Shared Sub AddUserDocument(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.UserDocType, Xml.DBTypes.UserDocs, "Document")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add User Map command
    Public Shared Sub AddUserMap(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.UserDocMapType, Xml.DBTypes.UserDocs, "Map")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add User Rule Page command
    Public Shared Sub AddUserRulePage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New GenericDescriptionForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, Objects.UserDocRulesType, Xml.DBTypes.UserDocs, "Rule Page")
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Wand Definition command
    Public Shared Sub AddWandDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New WandForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Weapon Definition command
    Public Shared Sub AddWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New WeaponForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Weapon Emulation command
    Public Shared Sub AddWeaponEmulation(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder As Objects.ObjectData
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            For Each Emulation As Objects.ObjectData In Folder.ChildrenOfType(Objects.WeaponEmulationType)
                Exclusions.Add(Emulation.GetFKGuid("WeaponDefinition"))
            Next
            Exclusions.AddRange(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and (Shadows!='' or BaseItem!='')]").GetGuidList)

            AddForm.InitAdd(Folder, Objects.WeaponDefinitionType, Objects.WeaponEmulationType, "Weapon", "WeaponDefinition", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Weapon Magic Ability command
    Public Shared Sub AddWeaponMagicAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SimpleSelectorForm
        Dim Folder, Weapon As Objects.ObjectData
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            'build exclusion list
            If Folder.Type = Objects.ConditionType Then Weapon = Folder.Parent Else Weapon = Folder

            Select Case Weapon.Type
                Case Objects.SpecificWeaponDefinitionType
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.SpecificWeaponAbilityType)
                        Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbility"))
                    Next
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.SpecificWeaponDoubleAbilityType)
                        Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbility"))
                    Next
                    For Each Condition As Objects.ObjectData In Weapon.ChildrenOfType(Objects.ConditionType)
                        For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                            Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbilityDefinition"))
                        Next
                    Next

                    'psionic and magic weapons abilities directly on a psionic weapon are all off the psionicweaponability(double)type
                Case Objects.PsionicWeaponDefinitionType
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.PsionicWeaponAbilityType)
                        Exclusions.Add(Ability.GetFKGuid("WeaponAbility"))
                    Next
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.PsionicWeaponAbilityDoubleType)
                        Exclusions.Add(Ability.GetFKGuid("WeaponAbility"))
                    Next
                    For Each Condition As Objects.ObjectData In Weapon.ChildrenOfType(Objects.ConditionType)
                        For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                            Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbilityDefinition"))
                        Next
                    Next
            End Select

            AddForm.InitAdd(Folder, Objects.WeaponMagicAbilityDefinitionType, Objects.MagicWeaponAbilityConditionalType, "Ability", "WeaponMagicAbilityDefinition", Exclusions)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Weapon Magic Ability Definition command
    Public Shared Sub AddWeaponMagicAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New WeaponMagicAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Wondrous Item command
    Public Shared Sub AddWondrousDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New WondrousItemForm
        Dim Folder As Objects.ObjectData
        Try
            If Not Commands.EditForm Is Nothing Then Exit Sub

            'retrieve the folder that we are adding an object to
            Folder = SelectCorrectFolder(e)
            If Folder.IsEmpty Then Throw New RPGXplorer.Exceptions.DevelopmentException("Rule definition folder could not be found.")

            AddForm.InitAdd(Folder)
            If General.DataInput Then
                If AddForm.ShowDialog() = DialogResult.OK Then Plus()
            Else
                AddForm.Show()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Delete Object Commands"

    'handles the Delete Character Level command
    Public Shared Sub DeleteCharacterLevel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Character As ObjectData
        Dim DeleteForm As New DeleteLevelsForm

        Try
            General.MainExplorer.Undo.BeginAtomicAction()

            Character = CharacterManager.CurrentCharacter.CharacterObject
            DeleteForm.Init(Character)
            If DeleteForm.ShowDialog() = DialogResult.OK Then
                'we deleted something - so regen memorized spells if required
                CharacterManager.GetCharacter(Character.ObjectGUID).GenerateMemorizedSpells()
                General.MainExplorer.Refresh()
            End If

            General.MainExplorer.Undo.EndAtomicAction()

        Catch ex As Exception
            General.MainExplorer.Undo.EndAtomicAction()
            HandleException(ex)
        End Try
    End Sub

    'handles the Delete Object command
    Public Shared Sub DeleteObjects(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Obj As Objects.ObjectData
        Dim Objs As Objects.ObjectDataCollection
        Dim TopLevelObjects As New Objects.ObjectDataCollection
        Dim RelatedGuids As New ArrayList
        Dim CharacterDeleted As Boolean

        'messageflags
        Dim SyncFlag As Boolean

        Try

            If (General.MainExplorer.ObjectSelectedInTree.Type = Objects.CharacterType OrElse General.MainExplorer.ObjectSelectedInTree.Type = Objects.ClassSpellSettingsFolderType OrElse General.MainExplorer.ObjectSelectedInTree.Type = Objects.ClassPowerSettingsFolderType) AndAlso General.MainExplorer.CurrentFocus <> Explorer.Focus.TreeView Then Exit Sub

            Objs = General.MainExplorer.CurrentSelectedObjects()

            If Objs.Count = 0 Then
                General.ShowInfoDialog("Please select components to delete.")
                Exit Sub
            Else
                For Each Obj In Objs
                    If Obj.Fixed Then
                        General.ShowInfoDialog("Selection contains fixed objects that cannot be deleted.")
                        Exit Sub
                    End If
                Next
                If General.ShowQuestionDialog("Are you sure you want to delete these components?") = DialogResult.No Then Exit Sub
            End If

            General.SetWaitCursor()

            'get the highest index of the items selected in the list view
            Dim HighestIndex As Integer = -1
            If General.MainExplorer.CurrentFocus = Explorer.Focus.ListView And Not General.MainExplorer.ListView Is Nothing Then
                For Each Index As Integer In General.MainExplorer.ListView.SelectedIndices
                    If Index > HighestIndex Then HighestIndex = Index
                Next
            End If

            'set the undo record - unfortunately this is wasted if the operation fails
            General.MainExplorer.Undo.UndoRecord()

            'keep a record of classes affected
            Dim ClassKeys As New ObjectHashtable

            'check for behaviours
            For Each Obj In Objs
                TopLevelObjects.Add(Obj)

                'when deleting an object it may be necessary to delete other objects representing relationships (children are handled by DeleteObjects)
                'or take some other action e.g notify the character manager that the current character is dirty
                Select Case Obj.Type
                    Case Objects.ClassType
                        'get the spell list and add to the collection of objects to delete
                        For Each SpellLevel As Objects.ObjectData In Rules.SpellList.SpellList(Obj.ObjectGUID)
                            TopLevelObjects.Add(SpellLevel)
                        Next

                        'get the power list and add to the collection of objects to delete
                        For Each PowerLevel As Objects.ObjectData In Rules.PowerList.PowerList(Obj.ObjectGUID)
                            TopLevelObjects.Add(PowerLevel)
                        Next

                        'note the class
                        If Not ClassKeys.ContainsKey(Obj.ObjectGUID) Then ClassKeys.Add(Obj.ObjectGUID, Nothing)
                    Case Objects.ClassLevelType
                        Dim CharacterClass As Rules.CharacterClass = Caches.GetCharacterClass(Obj.Parent.ParentGUID)
                        Dim HighestClassLevel As Objects.ObjectData

                        'only allow last class level or all class levels to be deleted
                        HighestClassLevel = CharacterClass.HighestClassLevel

                        If (Objs.Count = 1 And Not Obj.ObjectGUID.Equals(HighestClassLevel.ObjectGUID)) And Objs.Count <> HighestClassLevel.ElementAsInteger("Level") Then
                            General.SetNormalCursor()
                            General.ShowInfoDialog("You can only delete the highest class level OR all class levels.")
                            Exit Sub
                        End If

                        'determine which object require deletion are required
                        Dim spd, sk, pp As Boolean

                        spd = Rules.CharacterClass.SPD(CharacterClass.ClassObj)
                        sk = Rules.CharacterClass.SK(CharacterClass.ClassObj)
                        pp = Rules.CharacterClass.Psionic(CharacterClass.ClassObj)

                        Dim SpellObj As New Objects.ObjectData

                        If spd Then
                            SpellObj = CharacterClass.SpellsPerDayObject(Obj.ElementAsInteger("Level"))
                            RelatedGuids.Add(SpellObj.ObjectGUID)
                            TopLevelObjects.Add(SpellObj)
                        End If

                        If sk Then
                            SpellObj.Clear()
                            SpellObj = CharacterClass.SpellsKnownObject(Obj.ElementAsInteger("Level"))
                            RelatedGuids.Add(SpellObj.ObjectGUID)
                            TopLevelObjects.Add(SpellObj)
                        End If

                        If pp Then
                            SpellObj.Clear()
                            SpellObj = CharacterClass.PowerProgressionObject(Obj.ElementAsInteger("Level"))
                            RelatedGuids.Add(SpellObj.ObjectGUID)
                            TopLevelObjects.Add(SpellObj)
                        End If

                        'note the class
                        If Not ClassKeys.ContainsKey(Obj.ObjectGUID) Then ClassKeys.Add(Obj.ObjectGUID, Nothing)
                    Case Objects.CombatStyleType
                        'add the starter, improved and master objects to the list
                        Dim StyleObj As Objects.ObjectData

                        StyleObj = Obj.GetFKObject("ImprovedObject")
                        If Not RelatedGuids.Contains(StyleObj.ObjectGUID) Then
                            RelatedGuids.Add(StyleObj.ObjectGUID)
                            TopLevelObjects.Add(StyleObj)
                        End If

                        StyleObj = Obj.GetFKObject("MasteryObject")
                        If Not RelatedGuids.Contains(StyleObj.ObjectGUID) Then
                            RelatedGuids.Add(StyleObj.ObjectGUID)
                            TopLevelObjects.Add(StyleObj)
                        End If
                    Case Objects.DomainType
                        Dim ClassDef As Objects.ObjectData = Obj.GetFKObject("Class")
                        If ClassDef.Element("SpellAcquisition") = "List" Then SyncFlag = True
                        CharacterManager.CurrentCharacter.Domains.RemoveDomain(Obj.GetFKGuid("Class"), Obj.GetFKGuid("Domain"), True)
                        CharacterManager.SetDirty(CharacterManager.CurrentCharacter.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)

                    Case Objects.PsionicSpecializationType
                        CharacterManager.CurrentCharacter.PsionicSpecializations.RemoveSpecialization(Obj.GetFKGuid("Class"), Obj.GetFKGuid("PsionicSpecialization"), True)
                        CharacterManager.SetDirty(CharacterManager.CurrentCharacter.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
                    Case Objects.FeatTakenType, Objects.FeatureGainedType
                        CharacterManager.SetDirty(Obj.Parent.ParentGUID, CharacterManager.DirtyStatus.Reload)
                    Case Objects.SpellLikeAbilityTakenType, Objects.PsiLikeAbilityTakenType
                        CharacterManager.SetDirty(Obj.Parent.ParentGUID, CharacterManager.DirtyStatus.Reload)
                    Case Objects.SpellDefinitionType
                        'get all the character spellstaken with FK's to me
                        For Each TempObj As Objects.ObjectData In Objects.GetObjectHashtableByXPath(Xml.DBTypes.Characters, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellLearnedType & "' and */@FK='" & Obj.ObjectGUID.ToString & "']")
                            TopLevelObjects.Add(TempObj)
                        Next
                        For Each TempObj As Objects.ObjectData In Objects.GetObjectHashtableByXPath(Xml.DBTypes.Monsters, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellLearnedType & "' and */@FK='" & Obj.ObjectGUID.ToString & "']")
                            TopLevelObjects.Add(TempObj)
                        Next
                        Caches.RemoveSpell(Obj.ObjectGUID)
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                    Case Objects.PowerDefinitionType
                        'get all the character spellstaken with FK's to me
                        For Each TempObj As Objects.ObjectData In Objects.GetObjectHashtableByXPath(Xml.DBTypes.Characters, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PowerLearnedType & "' and */@FK='" & Obj.ObjectGUID.ToString & "']")
                            TopLevelObjects.Add(TempObj)
                        Next
                        For Each TempObj As Objects.ObjectData In Objects.GetObjectHashtableByXPath(Xml.DBTypes.Monsters, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PowerLearnedType & "' and */@FK='" & Obj.ObjectGUID.ToString & "']")
                            TopLevelObjects.Add(TempObj)
                        Next
                        Caches.RemovePower(Obj.ObjectGUID)
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                    Case Objects.PrerequisiteType
                        Select Case Obj.Parent.Type
                            Case Objects.FeatDefinitionType
                                Caches.RemoveFeatPrerequisite(Obj.ObjectGUID)
                            Case Objects.FeatureDefinitionType
                                Caches.RemoveFeaturePrerequisite(Obj.ObjectGUID)
                        End Select
                    Case Objects.SkillDefinitionType
                        'get all the character skillranks with FK's to me
                        For Each TempObj As Objects.ObjectData In Objects.GetObjectHashtableByXPath(Xml.DBTypes.Characters, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SkillPointsSpentType & "' and */@FK='" & Obj.ObjectGUID.ToString & "']")
                            TopLevelObjects.Add(TempObj)
                        Next
                        For Each TempObj As Objects.ObjectData In Objects.GetObjectHashtableByXPath(Xml.DBTypes.Monsters, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SkillPointsSpentType & "' and */@FK='" & Obj.ObjectGUID.ToString & "']")
                            TopLevelObjects.Add(TempObj)
                        Next
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                        Caches.SetSkillsDirty()
                    Case Objects.SkillSynergyType
                        Caches.SetSkillsDirty()
                    Case Objects.CharacterType, Objects.MonsterType
                        'close the market place to prevert premature refreshing before delete has finished
                        If Not General.Marketplace Is Nothing Then
                            General.Marketplace.Close()
                        End If

                    Case Else
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                End Select
            Next

            'handle dirty classes
            For Each ClassKey As Objects.ObjectKey In ClassKeys.Keys
                Caches.RemoveCharacterClass(ClassKey)
            Next

            'delete the objects
            Dim ObjGuids As ArrayList
            ObjGuids = TopLevelObjects.GetGuidList

            'this call updates the ObjGuids variable
            Dim Failures As ObjectHashtable = Objects.DeleteObjects(ObjGuids)

            'finish up
            If Not Failures Is Nothing Then
                'if there are failures then nothing has been deleted, report reasons to user
                Dim FailureForm As New DeleteFailuresForm

                General.SetNormalCursor()
                FailureForm.Init(Failures)
                FailureForm.Show()
            Else
                'remove deleted characters from the character manager and remove nodes from the treeview
                Dim TreeNode As TreeNode
                General.MainExplorer.TreeView.BeginUpdate()
                For Each DeletedObj As Objects.ObjectData In TopLevelObjects
                    If DeletedObj.Type = Objects.CharacterType OrElse DeletedObj.Type = Objects.MonsterType Then
                        CharacterManager.RemoveCharacter(DeletedObj.ObjectGUID)
                        CharacterDeleted = True
                    End If
                    TreeNode = CType(General.MainExplorer.TreeNodes(DeletedObj.ObjectGUID), TreeNode)
                    If Not TreeNode Is Nothing Then
                        TreeNode.Remove()
                        General.MainExplorer.TreeNodes.Remove(DeletedObj.ObjectGUID)
                    End If
                Next
                General.MainExplorer.TreeView.EndUpdate()

                'display any messages
                If SyncFlag = True Then General.ShowInfoDialog("If you wish to synchronize this class's spells list, do so from the appropriate spell folder.")

                'updates if characters have been deleted
                If CharacterDeleted Then
                    'resync XMLWorkShop
                    If General.XMLWorkShop IsNot Nothing Then General.XMLWorkShop.ReInit()

                    If General.Marketplace IsNot Nothing AndAlso General.Marketplace.ShoppingCart.Cart IsNot Nothing Then
                        Dim CartKey As Objects.ObjectKey = General.Marketplace.ShoppingCart.Cart.Character.ObjectGUID
                        'if we have deleted the currently selected character - reset the shoppingcart panel
                        If ObjGuids.Contains(CartKey) Then
                            General.Marketplace.ShoppingCart.ResetCart()
                        End If
                    End If
                End If

                'update window manager and marketplace
                WindowManager.RemoveAndUpdate(TopLevelObjects, ObjGuids)

                'refresh
                General.SetNormalCursor()
                General.MainExplorer.RefreshPanel()

                'select the item in the list view nearest the deleted items
                If HighestIndex > -1 Then
                    If General.MainExplorer.ListView.Items.Count > HighestIndex Then
                        General.MainExplorer.SelectItemByIndex(HighestIndex)
                    Else
                        If General.MainExplorer.ListView.Items.Count > 0 Then
                            General.MainExplorer.SelectItemByIndex(General.MainExplorer.ListView.Items.Count - 1)
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Edit Object Commands"

    'handles the Edit Ammo Definition command
    Public Shared Sub EditAmmoDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New AmmoForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Armor Definition command
    Public Shared Sub EditArmorDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ArmorForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Armor Magic Ability Definition command
    Public Shared Sub EditArmorMagicAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ArmorMagicAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Artifact Definition
    Public Shared Sub EditArtifactDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ArtifactForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Cannot User command
    Public Shared Sub EditCannotUse(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim EditObj As Objects.ObjectData
        'Dim EditForm As New CannotUseForm

        'Try
        '    'retrieve the folder
        '    EditObj = GetEditObject()

        '    If EditObj.Type <> Objects.CannotUseType Then Throw New DevelopmentException("Object type incorrect OR empty")

        '    'initialise and open the form
        '    EditForm.InitEdit(EditObj)
        '    EditForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Edit Character command
    Public Shared Sub EditCharacter(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.CharacterType AndAlso EditObj.Type <> Objects.MonsterType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'need to check the character type element as it may be a familiar, etc
            Select Case EditObj.Element("CharacterType")
                Case "Familiar", "Animal Companion", "Special Mount"
                    Dim EditForm As New FamiliarForm

                    'initialise and open the form
                    EditForm.InitEdit(EditObj)
                    EditForm.Show()

                Case Else
                    Dim EditForm As New CharacterForm

                    'initialise and open the form
                    EditForm.InitEdit(EditObj)
                    EditForm.Show()
            End Select



        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Characteristic command - NOT IN USE
    Public Shared Sub EditCharacteristic(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.CharacteristicDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.CharacteristicDefinitionType, "Characteristic")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Choose Bonus Feat command
    Public Shared Sub EditChooseBonusFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ChooseBonusFeatForm

        Try
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Choose Bonus Feat command
    Public Shared Sub EditChooseBonusFeatType(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ChooseBonusFeatOfTypeForm

        Try
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Choose Feature command
    Public Shared Sub EditChooseFeature(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ChooseFeatureForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Class command
    Public Shared Sub EditClass(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData

        Try
            'retrieve the folder
            EditObj = GetEditObject()
            If EditObj.Type <> Objects.ClassType Then Throw New DevelopmentException("Object type incorrect OR empty")

            Dim EditForm As New ClassForm

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Class Level command
    Public Shared Sub EditClassLevel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ClassLevelForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ClassLevelType AndAlso EditObj.Type <> Objects.MonsterClassLevelType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Class Skill command
    Public Shared Sub EditClassSkill(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ClassLevelType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SkillDefinitionType, Objects.ClassSkillType, "Class Skill", "Skill")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Condition command
    Public Shared Sub EditCondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ConditionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ConditionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Combat Style command
    Public Shared Sub EditCombatStyle(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New CombatStyleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.CombatStyleType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Curse command
    Public Shared Sub EditCurse(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim EditObj As Objects.ObjectData
        'Dim EditForm As New CurseForm

        'Try
        '    'retrieve the folder
        '    EditObj = GetEditObject()

        '    If EditObj.Type <> Objects.CurseType Then Throw New DevelopmentException("Object type incorrect OR empty")

        '    'initialise and open the form
        '    EditForm.InitEdit(EditObj)
        '    EditForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Edit Damage Reduction/Resistance command
    Public Shared Sub EditDamageAddition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New DamageAdditionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.DamageAdditionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Damage Reduction command
    Public Shared Sub EditDamageReduction(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New DamageReductionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Damage Resistance command
    Public Shared Sub EditDamageResistance(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New DamageResistanceForm

        Try
            'retrieve the object
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Damage Vulnerability command
    Public Shared Sub EditDamageVulnerability(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim EditObj As Objects.ObjectData
        'Dim EditForm As New DamageVulnerabilityForm

        'Try
        '    'retrieve the folder
        '    EditObj = GetEditObject()

        '    'initialise and open the form
        '    EditForm.InitEdit(EditObj)
        '    EditForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Edit Domain Definition command
    Public Shared Sub EditDeityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New DeityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.DeityDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Domain Definition command
    Public Shared Sub EditDomainDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New DomainForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.DomainDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Dorje Definition command
    Public Shared Sub EditDorjeDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New DorjeForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicDorjeDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Visible = True


        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Enhancement command
    Public Shared Sub EditEnhancement(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New EnhancementForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Expiry Condition command - NOT IN USE
    Public Shared Sub EditExpiryCondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim EditObj As Objects.ObjectData
        'Dim EditForm As New ExpiryConditionForm

        'Try
        '    'retrieve the folder
        '    EditObj = GetEditObject()

        '    If EditObj.Type <> Objects.ExpiryConditionType Then Throw New DevelopmentException("Object type incorrect OR empty")

        '    'initialise and open the form
        '    EditForm.InitEdit(EditObj)
        '    EditForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Edit Feat Definition command
    Public Shared Sub EditFeatDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New FeatForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.FeatDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feature command
    Public Shared Sub EditFeature(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'get a list of features to exclude from the list of those available to add
            If EditObj.Parent.Type <> Objects.RaceType Then
                Exclusions.AddRange(Objects.GetObjectsByXPath(Xml.DBTypes.Features, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatureDefinitionType & "' and FeatureType='Natural']").GetGuidList)
            End If

            For Each Feature As Objects.ObjectData In EditObj.Parent.ChildrenOfType(Objects.FeatureType)
                If Feature.Element("CanBeTakenMultipleTimes") = "" Then
                    Exclusions.Add(Feature.GetFKGuid("Feature"))
                End If
            Next

            'edit the object
            EditForm.InitEdit(EditObj, Objects.FeatureDefinitionType, Objects.FeatureType, "Feature", "Feature", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feature Definition command
    Public Shared Sub EditFeatureDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New FeatureForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Flurry of Blows command
    Public Shared Sub EditFlurryOfBlows(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New FlurryOfBlowsForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Granted Power command
    Public Shared Sub EditGrantedPower(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.GrantedPowerType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj, Objects.FeatureDefinitionType, Objects.GrantedPowerType, "Ability", "Ability")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit HTML Doc command
    Public Shared Sub EditHTMLDoc(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim HTMLDoc As Objects.ObjectData
        'Dim HTMLDocForm As New HTMLDocumentForm

        'Try
        '    'retrieve the folder
        '    HTMLDoc = GetEditObject()

        '    If HTMLDoc.Type <> Objects.HTMLDocumentType Then Throw New DevelopmentException("Object type incorrect OR empty")

        '    'initialise and open the form
        '    HTMLDocForm.Init(HTMLDoc)
        '    HTMLDocForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Edit Improved Unarmed Damage command
    Public Shared Sub EditImprovedUnarmedDamage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ImprovedUnarmedDamageForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Intelligence command
    Public Shared Sub EditIntelligence(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'Dim EditObj As Objects.ObjectData
        'Dim EditForm As New IntelForm

        'Try
        '    'retrieve the folder
        '    EditObj = GetEditObject()

        '    If EditObj.Type <> Objects.IntelligenceType Then Throw New DevelopmentException("Object type incorrect OR empty")

        '    'initialise and open the form
        '    EditForm.InitEdit(EditObj)
        '    EditForm.Show()

        'Catch ex As Exception
        '    HandleException(ex)
        'End Try
    End Sub

    'handles the Edit Item Definition command
    Public Shared Sub EditItemDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ItemForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ItemDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Item command
    Public Shared Sub EditItem(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New CustomItemForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Language command
    Public Shared Sub EditLanguage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.LanguageDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj, Objects.LanguageDefinitionType, "Language")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Magic Ammo Definition command
    Public Shared Sub EditMagicAmmoDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New MagicAmmoForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Modifier command
    Public Shared Sub EditModifier(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ModifierForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ModifierType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Modifier Limiter command
    Public Shared Sub EditModifierLimiter(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ModifierLimiterType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj, Objects.ModifierLimiterType, "Limiter")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Monster command
    Public Shared Sub EditMonster(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.MonsterType Then Throw New DevelopmentException("Object type incorrect OR empty")

            Dim EditForm As New MonsterForm

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Class command
    Public Shared Sub EditMonsterClass(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData

        Try
            'retrieve the folder
            EditObj = GetEditObject()
            If EditObj.Type <> Objects.MonsterClassType Then Throw New DevelopmentException("Object type incorrect OR empty")

            Dim EditForm As New MonsterClassForm

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Class command
    Public Shared Sub EditMonsterRace(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData

        Try
            'retrieve the folder
            EditObj = GetEditObject()
            If EditObj.Type <> Objects.MonsterRaceDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            Dim EditForm As New MonsterRaceForm

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Monster Type command
    Public Shared Sub EditMonsterType(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New MonsterTypeForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.MonsterTypeType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Weapon Definition command
    Public Shared Sub EditNaturalWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New NaturalWeaponForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.NaturalWeaponDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Potion Definition command
    Public Shared Sub EditPotionDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PotionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PotionDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Definition Command
    Public Shared Sub EditPowerDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PowerForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PowerDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spells Per Day command
    Public Shared Sub EditPowerProgression(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PowerProgressionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PowerProgressionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Scroll Definition command
    Public Shared Sub EditPowerStoneDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PowerStoneForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicPowerStoneDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Prerequisite command
    Public Shared Sub EditPrerequisite(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PrerequisiteForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PrerequisiteType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Like Ability command
    Public Shared Sub EditPsiLikeAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsiLikeAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()
            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Ammo Definition command
    Public Shared Sub EditPsionicAmmoDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicAmmoForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Armor Ability Definition command
    Public Shared Sub EditPsionicArmorAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicArmorAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicArmorAbilityDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Armor Definition command
    Public Shared Sub EditPsionicArmorDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicArmorForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicArmorDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Artifact Definition
    Public Shared Sub EditPsionicArtifactDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicArtifactForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Staff Definition command
    Public Shared Sub EditPsicrownDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsicrownForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicPsicrownDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Discipline Command
    Public Shared Sub EditPsionicDisciplineDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PowerDisciplineForm
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicDisciplineType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Tattoo Definition command
    Public Shared Sub EditPsionicTattooDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicTattooForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicTattooDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Discipline Specialization Command
    Public Shared Sub EditPsionicSpecializationDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicSpecializationForm
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicSpecializationDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Subdiscipline command
    Public Shared Sub EditPsionicSubdiscip(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj, Objects.PsionicSubdisciplineType, "Subdiscipline")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Weapon Ability command
    Public Shared Sub EditPsionicWeaponAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj, MagicWeapon As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'build exclusion list
            If EditObj.Parent.Type = Objects.ConditionType Then MagicWeapon = EditObj.Parent.Parent Else MagicWeapon = EditObj.Parent

            For Each Ability As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.PsionicWeaponAbilityType)
                Exclusions.Add(ability.GetFKGuid("WeaponAbility"))
            Next

            For Each Ability As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.PsionicWeaponAbilityDoubleType)
                Exclusions.Add(ability.GetFKGuid("WeaponAbility"))
            Next

            For Each Condition As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.ConditionType)
                For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.PsionicWeaponAbilityConditionalType)
                    Exclusions.Add(Ability.GetFKGuid("WeaponAbility"))
                Next
            Next

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.PsionicWeaponAbilityDefinitionType, Objects.PsionicWeaponAbilityConditionalType, "Ability", "WeaponAbility", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Weapon Ability Definition command
    Public Shared Sub EditPsionicWeaponAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicWeaponAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicWeaponAbilityDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psionic Armor Definition command
    Public Shared Sub EditPsionicWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsionicWeaponForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.PsionicWeaponDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Race command
    Public Shared Sub EditRace(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New RaceForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.RaceType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Racial Weapon command
    Public Shared Sub EditRacialWeapon(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            Exclusions.Add(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.MartialWeapons).GetGuidList)
            Exclusions.Add(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.SimpleWeapons).GetGuidList)
            Exclusions.Add(EditObj.Parent.ChildrenOfType(Objects.RacialWeaponType).GetGuidList)

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.WeaponDefinitionType, Objects.RacialWeaponType, "Weapon", "Weapon", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Regeneration command
    Public Shared Sub EditRegeneration(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New RegenerationForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.RegenerationType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Ring Definition command
    Public Shared Sub EditRingDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New RingForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.RingDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Rod Definition command
    Public Shared Sub EditRodDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New RodForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.RodDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'edit rule page
    Public Shared Sub EditRulePage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj, HelpObj As New Objects.ObjectData
        Dim Proc As New System.Diagnostics.Process
        Dim PageToEdit As Boolean = True
        Dim HelpPage As String

        Try

            EditObj = GetEditObject()

            If General.Config.Element("HTMLEditorCommandLine") = "" Then
                General.ShowInfoDialog("Please go to Tools, Options and specify your HTML editor.")
            Else
                Proc.StartInfo.FileName = General.Config.Element("HTMLEditorCommandLine")
                If EditObj.HTMLGUID.Equals(Objects.ObjectKey.Empty) Then
                    HelpPage = EditObj.HTML
                Else
                    HelpObj.Load(EditObj.HTMLGUID)
                    HelpPage = HelpObj.HTML
                End If

                If HelpPage = "" Then
                    General.ShowInfoDialog("No help or rule page to edit.")
                Else
                    If HelpPage.IndexOf(General.BasePath & "HTML\HelpPages\") = -1 Then
                        HelpPage = General.BasePath & "HTML\HelpPages\" & HelpPage
                    End If

                    If IO.File.Exists(HelpPage) Then
                        Proc.StartInfo.Arguments = """" & HelpPage & """"
                        Application.DoEvents()
                        Proc.Start()
                        Proc.WaitForExit()
                        General.MainExplorer.Form.Focus()
                        General.MainExplorer.SelectItemByGuid(EditObj.ObjectGUID)
                    Else
                        General.ShowInfoDialog("Help or rule page not found.")
                    End If
                End If
            End If
        Catch ex As Exception
            General.ShowInfoDialog("Please go to Tools, Options and specify your HTML editor.")
        End Try
    End Sub

    'handles the Edit Special Material  Definition command
    Public Shared Sub EditSpecialMaterialDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpecialMaterialForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpecialMaterialDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Scroll Definition command
    Public Shared Sub EditScrollDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ScrollForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.ScrollDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Set Ability command
    Public Shared Sub EditSetAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SetAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SetAbilityType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Set Value command
    Public Shared Sub EditSetValue(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SetValueForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SetValueType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Skill Ability command
    Public Shared Sub EditSkillAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SkillAbilityExchnageForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SkillAbilityExchangeType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Skill Definition command
    Public Shared Sub EditSkillDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SkillForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SkillDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Skill Synergy command
    Public Shared Sub EditSkillSynergy(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SkillSynergyForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SkillSynergyType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Specific Armor Definition command
    Public Shared Sub EditSpecificArmorDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpecificArmorForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpecificArmorDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Specific Bonus Feat command
    Public Shared Sub EditSpecificBonusFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpecificBonusFeatForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Specific or Choose Bonus Class Skill command
    Public Shared Sub EditSpecificOrChooseBonusClassSkill(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericChooseBonusForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            Dim Skills As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.Skills, Objects.SkillDefinitionType)
            Skills.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.Skills, Objects.SkillGroupType))
            EditForm.InitEdit(EditObj, Objects.BonusClassSkillChoiceOrSpecificType, Skills, "Bonus Class Skill", AddressOf Rules.Skills.IsValidAdd)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Specific or Choose Bonus Domain command
    Public Shared Sub EditSpecificOrChooseBonusDomain(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericChooseBonusForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.BonusDomainChoiceOrSpecificType, Objects.GetAllObjectsOfType(Xml.DBTypes.Domains, Objects.DomainDefinitionType), "Bonus Domain")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Specific or Choose Bonus Psionic Specialization command
    Public Shared Sub EditSpecificOrChooseBonusPsionicSpecialization(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericChooseBonusForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.BonusPsionicSpecializationChoiceorSpecificType, Objects.GetAllObjectsOfType(Xml.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType), "Bonus Psionic Specialization")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Specific Armor Definition command
    Public Shared Sub EditSpecificWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpecificWeaponForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpecificWeaponDefinitionType Then Throw (New DevelopmentException("Object type incorrect OR empty"))

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Category command
    Public Shared Sub EditSpellCategory(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj, Objects.SpellCategoryDefinitionType, "Category")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Definition Command
    Public Shared Sub EditSpellDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpellDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Descriptor command
    Public Shared Sub EditSpellDescriptor(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj, Objects.SpellDescriptorDefinitionType, "Descriptor")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Failure command
    Public Shared Sub EditSpellFailure(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellFailureForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpellFailureType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Like Ability command
    Public Shared Sub EditSpellLikeAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellLikeAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Resistance command
    Public Shared Sub EditSpellResistance(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleNumericalForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpellResistanceType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SpellResistanceType, "Spell Resistance", 1, 100)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell School command
    Public Shared Sub EditSpellSchool(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellSchoolForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpellSchoolType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Subschool command
    Public Shared Sub EditSpellSubschool(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj, Objects.SpellSubschoolType, "Subschool")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spells Known command
    Public Shared Sub EditSpellsKnown(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellLevelsForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpellsKnownType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spells Per Day command
    Public Shared Sub EditSpellsPerDay(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellLevelsForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SpellsPerDayType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Staff Definition command
    Public Shared Sub EditStaffDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New StaffForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.StaffDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Subtype command
    Public Shared Sub EditSubtypeDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SubtypeForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SubtypeDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Ability command
    Public Shared Sub EditSystemAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            For Each Ability As Objects.ObjectData In EditObj.Parent.ChildrenOfType(Objects.SystemAbilityType)
                Exclusions.Add(Ability.GetFKGuid("SystemAbilityDefinition"))
            Next

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemAbilityDefinitionType, Objects.SystemAbilityType, "Ability", "SystemAbilityDefinition", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Ability Definition command
    Public Shared Sub EditSystemAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemAbilityDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemAbilityDefinitionType, "Ability")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Alignment Definition command
    Public Shared Sub EditSystemAlignmentDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemAlignmentDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemPreconditionDefinitionType, "Precondition")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Condition command
    Public Shared Sub EditSystemCondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemConditionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemConditionType, "Condition")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Element command
    Public Shared Sub EditSystemElement(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SystemElementForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemElementType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Precondition command
    Public Shared Sub EditSystemPrecondition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            For Each Precondition As Objects.ObjectData In EditObj.Parent.ChildrenOfType(Objects.SystemPreconditionType)
                Exclusions.Add(Precondition.GetFKGuid("SystemPreconditionDefinition"))
            Next

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemPreconditionDefinitionType, Objects.SystemPreconditionType, "Precondition", "SystemPreconditionDefinition", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Precondition Definition command
    Public Shared Sub EditSystemPreconditionDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemPreconditionDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemPreconditionDefinitionType, "Precondition")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Reference command
    Public Shared Sub EditSystemReference(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SystemReferenceForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemReferenceType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Restriction command
    Public Shared Sub EditSystemRestriction(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemRestrictionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemRestrictionDefinitionType, Objects.SystemRestrictionType, "Restriction", "SystemRestrictionDefinition")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Restriction Definition command
    Public Shared Sub EditSystemRestrictionDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.SystemRestrictionDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemRestrictionDefinitionType, "Restriction")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Weapon Ability command
    Public Shared Sub EditSystemWeaponAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj, MagicWeapon As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'build exclusion list
            If EditObj.Parent.Type = Objects.ConditionType Then MagicWeapon = EditObj.Parent.Parent Else MagicWeapon = EditObj.Parent

            For Each Ability As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.SystemWeaponAbilityType)
                Exclusions.Add(Ability.GetFKGuid("SystemWeaponAbilityDefinition"))
            Next

            For Each Condition As Objects.ObjectData In MagicWeapon.ChildrenOfType(Objects.ConditionType)
                For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.SystemWeaponAbilityType)
                    Exclusions.Add(Ability.GetFKGuid("SystemWeaponAbilityDefinition"))
                Next
            Next

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemWeaponAbilityDefinitionType, Objects.SystemWeaponAbilityType, "Ability", "SystemWeaponAbilityDefinition", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit System Weapon Ability Definition command
    Public Shared Sub EditSystemWeaponAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.SystemWeaponAbilityDefinitionType, "Ability")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit User Document command
    Public Shared Sub EditUserDocument(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.UserDocType, "Document")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit User Map command
    Public Shared Sub EditUserMap(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.UserDocMapType, "Map")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Universal Definition command
    Public Shared Sub EditUniversalDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New UniversalItemForm
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit User Rule Page command
    Public Shared Sub EditUserRulePage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New GenericDescriptionForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.UserDocRulesType, "Rule Page")
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Wand Definition command
    Public Shared Sub EditWandDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New WandForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.WandDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            'EditForm.Show()
            EditForm.Visible = True

            'EditForm.InitEdit(EditObj, Objects.WeaponDefinitionType, "Weapon")
            'EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Weapon Definition command
    Public Shared Sub EditWeaponDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New WeaponForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.WeaponDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Weapon Emulation command
    Public Shared Sub EditWeaponEmulation(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            For Each Emulation As Objects.ObjectData In EditObj.Parent.ChildrenOfType(Objects.WeaponEmulationType)
                Exclusions.Add(Emulation.GetFKGuid("WeaponDefinition"))
            Next
            Exclusions.AddRange(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and (Shadows!='' or BaseItem!='')]").GetGuidList)

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.WeaponDefinitionType, Objects.WeaponEmulationType, "Weapon", "WeaponDefinition", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Weapon Magic Ability command
    Public Shared Sub EditWeaponMagicAbility(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj, Weapon As Objects.ObjectData
        Dim EditForm As New SimpleSelectorForm
        Dim Exclusions As New ArrayList
        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'build exclusion list
            If EditObj.Parent.Type = Objects.ConditionType Then Weapon = EditObj.Parent.Parent Else Weapon = EditObj.Parent

            Select Case Weapon.Type
                Case Objects.SpecificWeaponDefinitionType
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.SpecificWeaponAbilityType)
                        Exclusions.Add(ability.GetFKGuid("WeaponMagicAbility"))
                    Next
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.SpecificWeaponDoubleAbilityType)
                        Exclusions.Add(ability.GetFKGuid("WeaponMagicAbility"))
                    Next
                    For Each Condition As Objects.ObjectData In Weapon.ChildrenOfType(Objects.ConditionType)
                        For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                            Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbilityDefinition"))
                        Next
                    Next

                    'psionic and magic weapons abilities directly on a psionic weapon are all off the psionicweaponability(double)type
                Case Objects.PsionicWeaponDefinitionType
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.PsionicWeaponAbilityType)
                        Exclusions.Add(ability.GetFKGuid("WeaponAbility"))
                    Next
                    For Each Ability As Objects.ObjectData In Weapon.ChildrenOfType(Objects.PsionicWeaponAbilityDoubleType)
                        Exclusions.Add(ability.GetFKGuid("WeaponAbility"))
                    Next
                    For Each Condition As Objects.ObjectData In Weapon.ChildrenOfType(Objects.ConditionType)
                        For Each Ability As Objects.ObjectData In Condition.ChildrenOfType(Objects.MagicWeaponAbilityConditionalType)
                            Exclusions.Add(Ability.GetFKGuid("WeaponMagicAbilityDefinition"))
                        Next
                    Next
            End Select

            'initialise and open the form
            EditForm.InitEdit(EditObj, Objects.WeaponMagicAbilityDefinitionType, Objects.MagicWeaponAbilityConditionalType, "Ability", "WeaponMagicAbilityDefinition", Exclusions)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Weapon Magic Ability Definition command
    Public Shared Sub EditWeaponMagicAbilityDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New WeaponMagicAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            If EditObj.Type <> Objects.WeaponMagicAbilityDefinitionType Then Throw New DevelopmentException("Object type incorrect OR empty")

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Wondrous Definition command
    Public Shared Sub EditWondrousDefinition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New WondrousItemForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Cut, Copy, Paste, Select All"

    Public Shared Sub SelectAll(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If (Not General.MainExplorer.ListView Is Nothing) AndAlso General.MainExplorer.ListView.MultiSelect Then
                General.MainExplorer.ListView.Select()
                For Each Item As ListViewItem In General.MainExplorer.ListView.Items
                    Item.Selected = True
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the cut command
    Public Shared Sub Cut(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try

            'undo any previous node colour changes
            General.MainExplorer.TreeView.BeginUpdate()
            For Each TempGuid As Objects.ObjectKey In General.MainExplorer.Clipboard.ClipboardGuids
                Dim TempNode As TreeNode
                TempNode = CType(General.MainExplorer.TreeNodes(TempGuid), TreeNode)
                If Not TempNode Is Nothing Then
                    TempNode.ForeColor = System.Drawing.Color.Black
                End If
            Next

            If Not General.MainExplorer.Clipboard.FolderObject.IsEmpty Then
                WindowManager.SetDirty(General.MainExplorer.Clipboard.FolderObject)
            End If

            General.MainExplorer.Clipboard.Cut(General.MainExplorer.CurrentSelectedObjects)

            For Each TempObj As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                Dim TempNode As TreeNode
                TempNode = CType(General.MainExplorer.TreeNodes(TempObj.ObjectGUID), TreeNode)
                If Not TempNode Is Nothing Then
                    TempNode.ForeColor = System.Drawing.Color.DimGray
                End If
            Next
            General.MainExplorer.TreeView.EndUpdate()
            General.MainExplorer.TreeView.Refresh()
            WindowManager.SetDirty(General.MainExplorer.ObjectSelectedInTree)
            General.MainExplorer.RefreshPanel()
            General.MainExplorer.SelectGroup(General.MainExplorer.Clipboard.ClipboardGuids)
        Catch ex As Exception
            General.MainExplorer.TreeView.EndUpdate()
            HandleException(ex)
        End Try
    End Sub

    'handles the Copy command
    Public Shared Sub Copy(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try

            'undo any previous node colour changes
            General.MainExplorer.TreeView.BeginUpdate()
            For Each TempGuid As Objects.ObjectKey In General.MainExplorer.Clipboard.ClipboardGuids
                Dim TempNode As TreeNode
                TempNode = CType(General.MainExplorer.TreeNodes(TempGuid), TreeNode)
                If Not TempNode Is Nothing Then
                    TempNode.ForeColor = System.Drawing.Color.Black
                End If
            Next
            General.MainExplorer.TreeView.EndUpdate()

            If Not General.MainExplorer.Clipboard.FolderObject.IsEmpty Then
                WindowManager.SetDirty(General.MainExplorer.Clipboard.FolderObject)
            End If

            General.MainExplorer.Clipboard.Copy(General.MainExplorer.CurrentSelectedObjects)
            General.MainExplorer.RefreshPanel()
            General.MainExplorer.SelectGroup(General.MainExplorer.Clipboard.ClipboardGuids)

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Paste command
    Public Shared Sub Paste(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim TargetFolder As Objects.ObjectData
        Try
            'check for invalid conditions
            If General.MainExplorer.SelectedObjectCount > 1 Then
                General.ShowInfoDialog(General.PasteFailMessage2)
                Exit Sub
            End If

            'set the undo record
            General.MainExplorer.Undo.UndoRecord()

            General.SetWaitCursor()

            'paste
            TargetFolder = General.MainExplorer.SelectedObject()
            Dim GuidsMoved As ArrayList = General.MainExplorer.Clipboard.Paste(TargetFolder)

            'refresh explorer and select objects moved/copied
            Dim Nodes As New ArrayList

            If Not GuidsMoved Is Nothing Then
                If General.MainExplorer.Clipboard.Mode = Clipboard.CutCopy.Cut Then
                    General.MainExplorer.Clipboard.Clear()
                End If
                WindowManager.SetDirty(General.MainExplorer.ObjectSelectedInTree)

                'update other global lists if required
                Select Case TargetFolder.Type
                    Case Objects.SpellDefinitionFolderType
                        Caches.SetSpellsDirty()
                    Case Objects.PowerDefinitionFolderType
                        Caches.SetPowersDirty()
                    Case Else
                        Caches.SetAllDirty()
                End Select

                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectGroup(GuidsMoved)
            End If

            General.SetNormalCursor()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Clear Clipboard command
    Public Shared Sub ClearClipboard(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'undo the node colour changes
            General.MainExplorer.TreeView.BeginUpdate()
            For Each TempGuid As Objects.ObjectKey In General.MainExplorer.Clipboard.ClipboardGuids
                Dim TempNode As TreeNode
                TempNode = CType(General.MainExplorer.TreeNodes(TempGuid), TreeNode)
                If Not TempNode Is Nothing Then
                    TempNode.ForeColor = System.Drawing.Color.Black
                End If
            Next

            If Not General.MainExplorer.Clipboard.FolderObject.IsEmpty Then
                WindowManager.SetDirty(General.MainExplorer.Clipboard.FolderObject)
            End If

            General.MainExplorer.TreeView.EndUpdate()
            General.MainExplorer.Clipboard.Clear()
            General.MainExplorer.RefreshPanel()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Undo"

    'handles the Undo command
    Public Shared Sub Undo(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Undo.Undo()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "List View Mode Commands"

    'handles the List View Mode = Small Icons command
    Public Shared Sub ListViewModeSmallIcons(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.ListViewMode = View.SmallIcon
            If Not General.MainExplorer.ListViewManager Is Nothing Then
                General.MainExplorer.ListViewManager.ColourListView()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the List View Mode = Large Icons command
    Public Shared Sub ListViewModeLargeIcons(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.ListViewMode = View.LargeIcon
            If Not General.MainExplorer.ListViewManager Is Nothing Then
                General.MainExplorer.ListViewManager.ColourListView()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the List View Mode = Details command
    Public Shared Sub ListViewModeDetails(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.ListViewMode = View.Details
            If Not General.MainExplorer.ListViewManager Is Nothing Then
                General.MainExplorer.ListViewManager.ColourListView()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the List View Mode = List command
    Public Shared Sub ListViewModeList(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.ListViewMode = View.List
            If Not General.MainExplorer.ListViewManager Is Nothing Then
                General.MainExplorer.ListViewManager.ColourListView()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Browser, Tabs, XML Workshop and Document Viewer Commands"

    'handles the Show Tree View command
    Public Shared Sub ShowTreeView(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim BarButtonItem As BarButtonItem

        Try
            BarButtonItem = CType(e.Link.Item, BarButtonItem)

            If BarButtonItem.Down Then
                General.MainExplorer.Form.FoldersDockPanel.Show()
            Else
                General.MainExplorer.Form.FoldersDockPanel.Close()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Show Browser command
    Public Shared Sub ShowBrowser(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim BarButtonItem As BarButtonItem

        Try
            BarButtonItem = CType(e.Link.Item, BarButtonItem)

            If BarButtonItem.Down Then
                General.MainExplorer.Form.BrowserDockPanel.Show()
            Else
                General.MainExplorer.Form.BrowserDockPanel.Close()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Show Rules Viewer command
    Public Shared Sub ShowRulesViewer(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If General.RulesViewer Is Nothing Then
                If Not General.TimeUp Then

                    Dim Form As New DocumentViewer

                    General.SetWaitCursor()
                    Form.Init()
                    Form.Show()
                    General.RulesViewer = Form
                    General.SetNormalCursor()
                    If General.Mode = AppMode.Trial Then
                        General.RTimer.Start()
                    End If
                End If
            Else
                If Not General.TimeUp Then
                    General.RulesViewer.Show()
                    If General.RulesViewer.WindowState = FormWindowState.Minimized Then General.RulesViewer.WindowState = FormWindowState.Maximized
                Else
                    General.ShowInfoDialog("You are in trial mode, the rules viewer is time-limited to 15 minutes. Restart the application to get another 15 minutes.")
                End If
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'show XML for the currently selected character
    Public Shared Sub ShowCharacterXML(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try

            'load or bring to front
            If General.XMLWorkShop Is Nothing Then
                Dim Form As New CharacterXMLForm
                General.SetWaitCursor()
                Form.Init()
                Form.Show()
                General.XMLWorkShop = Form
                General.SetNormalCursor()
            Else
                If General.XMLWorkShop.WindowState = FormWindowState.Minimized Then General.XMLWorkShop.WindowState = FormWindowState.Normal
                General.XMLWorkShop.Show()
                General.XMLWorkShop.BringToFront()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Filter Commands"

    'edit filters
    Public Shared Sub Filters(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim FilterForm As New FiltersForm

            FilterForm.Init(General.MainExplorer.FilterManager)
            FilterForm.ShowDialog()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'change filter
    Public Shared Sub FilterChange(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Not General.MainExplorer.FilterManager.SuppressEvents Then
                General.MainExplorer.FilterManager.CurrentFilter = ToolbarsAndMenus.FilterEdit.EditValue.ToString
                WindowManager.CurrentWindow.Filter = General.MainExplorer.FilterManager.CurrentFilter
                WindowManager.CurrentWindow.RefreshTabName()
                General.MainExplorer.RefreshPanel()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'clear filters
    Public Shared Sub FilterClear(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If WindowManager.CurrentWindow.Filter = "" Then
                WindowManager.CurrentWindow.RefreshTabName()
            Else
                WindowManager.CurrentWindow.Filter = ""
                ToolbarsAndMenus.FilterEdit.EditValue = ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Character Commands"

    'handles the Add Power command
    Public Shared Sub CharacterAddPower(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PowerListForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Power from Specialization
    Public Shared Sub CharacterAddPowerFromSpecialization(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PowerListSpecificForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder, PowerListSpecificForm.SourceType.PsionicSpecialization)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell from Category command
    Public Shared Sub CharacterAddSpellFromCategory(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellListSpecificForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder, SpellListSpecificForm.SourceType.Category)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell from Category command
    Public Shared Sub CharacterAddSpellFromDomain(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellListSpecificForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder, SpellListSpecificForm.SourceType.Domain)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Spell command
    Public Shared Sub CharacterAddSpell(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellListForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Synce Spells command
    Public Shared Sub SyncSpells(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData
        Try

            Folder = GetFolder()
            General.MainExplorer.Undo.UndoRecord()

            Dim Character As Rules.Character = CharacterManager.GetCharacter(Folder.GetCharacterKey)

            For Each SpellLearned As Objects.ObjectData In Folder.ChildrenOfType(Objects.SpellLearnedType)
                If SpellLearned.Element("AutoObtained") = "Yes" Then
                    SpellLearned.Delete()
                End If
            Next
            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)

            Character = CharacterManager.GetCharacter(Folder.GetCharacterKey)
            Character.Spells.UpdateSpellListCaster(Folder.GetFKGuid("Class"), True, True)
            Character.Spells.Save()

            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feat command
    Public Shared Sub AddFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CharacterFeatForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            If AddForm.InitAdd(Folder) Then AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feature command
    Public Shared Sub AddCharacterFeature(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CharacterFeatureForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            If AddForm.InitAdd(Folder) Then AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Language command
    Public Shared Sub AddCharacterLanguage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New CharacterLanguageForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feat command
    Public Shared Sub AddUserModifier(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New ModifierForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder, True)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Domain command
    Public Shared Sub AddDomain(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim AddForm As New AddDomainOrSchoolFrom

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    If AddForm.Init(CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey), Objects.DomainType) Then
                        AddForm.ShowDialog()
                    End If
                Case Explorer.Focus.TreeView
                    If AddForm.Init(CharacterManager.CurrentCharacter, Objects.DomainType) Then
                        AddForm.ShowDialog()
                    End If
            End Select

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Specialist School command
    Public Shared Sub AddSpecialistSchool(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim AddForm As New AddDomainOrSchoolFrom

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    If AddForm.Init(CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey), Objects.SpellSchoolSpecialistChoiceType) Then
                        AddForm.ShowDialog()
                    End If
                Case Explorer.Focus.TreeView
                    If AddForm.Init(CharacterManager.CurrentCharacter, Objects.SpellSchoolSpecialistChoiceType) Then
                        AddForm.ShowDialog()
                    End If
            End Select

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Prohibited School command
    Public Shared Sub AddProhibitedSchool(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim AddForm As New AddDomainOrSchoolFrom

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    If AddForm.Init(CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey), Objects.SpellSchoolProhibitedChoiceType) Then
                        AddForm.ShowDialog()
                    End If
                Case Explorer.Focus.TreeView
                    If AddForm.Init(CharacterManager.CurrentCharacter, Objects.SpellSchoolProhibitedChoiceType) Then
                        AddForm.ShowDialog()
                    End If
            End Select
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Psionic Specialization command
    Public Shared Sub AddPsionicSpecialization(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim AddForm As New AddDomainOrSchoolFrom

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    If AddForm.Init(CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey), Objects.PsionicSpecializationType) Then
                        AddForm.ShowDialog()
                    End If
                Case Explorer.Focus.TreeView
                    If AddForm.Init(CharacterManager.CurrentCharacter, Objects.PsionicSpecializationType) Then
                        AddForm.ShowDialog()
                    End If
            End Select

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Disable Command
    Public Shared Sub DisableObject(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim TempObjCollection As New Objects.ObjectDataCollection
        Dim EditObj As Objects.ObjectData
        Try
            General.MainExplorer.Undo.UndoRecord()

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    TempObjCollection = General.MainExplorer.CurrentSelectedObjects
                    If TempObjCollection.Count = 0 Then
                        EditObj = General.MainExplorer.ObjectSelectedInTree
                        TempObjCollection.Add(EditObj)
                    End If
                Case Explorer.Focus.TreeView
                    EditObj = General.MainExplorer.ObjectSelectedInTree
                    TempObjCollection.Add(EditObj)
            End Select

            'get the character - get the character from the panel (in case locked window)
            Dim Character As Rules.Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey)

            For Each EditObj In TempObjCollection
                EditObj.Element("Disabled") = "Yes"
            Next

            'set the character to dirty
            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feat command
    Public Shared Sub EditFeat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New CharacterFeatForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feat command
    Public Shared Sub EditCharacterFeature(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New CharacterFeatureForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feat command
    Public Shared Sub EditCharacterLanguage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New CharacterLanguageForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feat command
    Public Shared Sub EditSkillRanks(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New CharacterSkillForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            If EditForm.Init(EditObj) Then
                EditForm.ShowDialog()
            Else
                General.ShowInfoDialog("Cannot adjust ranks for a character with no levels.")
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Feat command
    Public Shared Sub EditUserModifier(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ModifierForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, True)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Enable Command
    Public Shared Sub EnableObject(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim TempObjCollection As New Objects.ObjectDataCollection
        Dim EditObj As Objects.ObjectData
        Try
            General.MainExplorer.Undo.UndoRecord()

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    TempObjCollection = General.MainExplorer.CurrentSelectedObjects
                    If TempObjCollection.Count = 0 Then
                        EditObj = General.MainExplorer.ObjectSelectedInTree
                        TempObjCollection.Add(EditObj)
                    End If
                Case Explorer.Focus.TreeView
                    EditObj = General.MainExplorer.ObjectSelectedInTree
                    TempObjCollection.Add(EditObj)
            End Select

            'get the character - get the character from the panel (in case locked window)
            Dim Character As Rules.Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey)

            For Each EditObj In TempObjCollection
                EditObj.Element("Disabled") = ""
            Next

            'set the character to dirty
            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Feature Panel Edit Mode
    Public Shared Sub FeatureEditMode(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            CType(General.MainExplorer.CurrentPanel, FeaturesPanel).PanelMode = FeaturesPanel.FeaturePanelMode.EditMode
            General.MainExplorer.RefreshPanel()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'Feature Panel View Mode
    Public Shared Sub FeatureViewMode(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            CType(General.MainExplorer.CurrentPanel, FeaturesPanel).PanelMode = FeaturesPanel.FeaturePanelMode.ViewMode
            General.MainExplorer.RefreshPanel()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Override Prerequisites command
    Public Shared Sub OverrideFeatPrereq(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim TempObjCollection As New Objects.ObjectDataCollection
        Dim EditObj As New Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()

            'get the character - get the character from the panel (in case locked window)
            Dim Character As Rules.Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey)

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    TempObjCollection = General.MainExplorer.CurrentSelectedObjects
                    If TempObjCollection.Count = 0 Then EditObj = General.MainExplorer.ObjectSelectedInTree
                Case Explorer.Focus.TreeView
                    EditObj = General.MainExplorer.ObjectSelectedInTree
            End Select

            'Change the Enabled Setting
            If TempObjCollection.Count > 0 Then
                For Each EditObj In TempObjCollection
                    'Change setting on object
                    EditObj.Element("IgnorePrerequisites") = "Yes"
                Next
            Else
                'Change setting on object
                EditObj.Element("IgnorePrerequisites") = "Yes"
            End If

            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Stop Overriding Prerequisites command
    Public Shared Sub StopOverrideFeatPrereq(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim TempObjCollection As New Objects.ObjectDataCollection
        Dim EditObj As New Objects.ObjectData
        Try
            General.MainExplorer.Undo.UndoRecord()

            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    TempObjCollection = General.MainExplorer.CurrentSelectedObjects
                    If TempObjCollection.Count = 0 Then EditObj = General.MainExplorer.ObjectSelectedInTree
                Case Explorer.Focus.TreeView
                    EditObj = General.MainExplorer.ObjectSelectedInTree
            End Select

            'get the character - get the character from the panel (in case locked window)
            Dim Character As Rules.Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey)

            'Change the override Setting
            If TempObjCollection.Count > 0 Then
                For Each EditObj In TempObjCollection
                    'Change setting on the object
                    EditObj.Element("IgnorePrerequisites") = ""
                Next
            Else
                'Change setting on the object
                EditObj.Element("IgnorePrerequisites") = ""
            End If

            CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feat command
    Public Shared Sub AddSpellLikeTaken(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellLikeAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            If AddForm.InitAdd(Folder) Then AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Add Feat command
    Public Shared Sub AddPsiLikeTaken(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PsiLikeAbilityForm
        Dim Folder As Objects.ObjectData
        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            If AddForm.InitAdd(Folder) Then AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Spell Like Taken command
    Public Shared Sub EditSpellLikeTaken(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New SpellLikeAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Psi Like Taken command
    Public Shared Sub EditPsiLikeTaken(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PsiLikeAbilityForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Update Memorized Spells command
    Public Shared Sub UpdateMemorizedSpells(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditForm As New MemorizedSpellsForm
        Try

            EditForm.Init()
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'applys the given template
    Public Shared Sub ApplyTemplate(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim BarManager As DevExpress.XtraBars.BarManager = CType(sender, DevExpress.XtraBars.BarManager)
            Dim Template As ITemplate = DirectCast(e.Item.Tag, ITemplate)

            'get the template and the character and run the template
            General.MainExplorer.Undo.BeginAtomicAction()
            Template.ApplyTemplate(CharacterManager.CurrentCharacter)
            General.MainExplorer.Undo.EndAtomicAction()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Tools Commands"

    'handles the Data Input command
    Public Shared Sub DataInput(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim BarButtonItem As BarButtonItem

        Try
            BarButtonItem = CType(e.Link.Item, BarButtonItem)
            If BarButtonItem.Down Then
                If Not Commands.EditForm Is Nothing Then
                    BarButtonItem.Down = False
                    General.ShowInfoDialog("Please close current edit form before data input.")
                    'ElseIf General.ShoppingCart Then
                    '    BarButtonItem.Down = False
                    '    General.ShowInfoDialog("Please exit marketplace first.")
                Else
                    General.DataInput = True
                    General.Config.Element("DataInput") = "True"
                End If
            Else
                General.DataInput = False
                General.Config.Element("DataInput") = "False"
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Double Click Edits command
    Public Shared Sub DoubleClickEdits(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim BarButtonItem As BarButtonItem

        Try
            BarButtonItem = CType(e.Link.Item, BarButtonItem)
            If BarButtonItem.Down Then
                General.DoubleClickEdits = True
                General.Config.Element("DoubleClickEdits") = "True"
            Else
                General.DoubleClickEdits = False
                General.Config.Element("DoubleClickEdits") = "False"
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Options command
    Public Shared Sub Options(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New OptionsForm

        Try
            Form.Init()
            Form.ShowDialog()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Lists commands
    Public Shared Sub Lists(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim Form As New ListsDialog

            Form.Init()
            Form.ShowDialog()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Help Commands"

    'handles the Help Index command
    Public Shared Sub HelpIndex(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim Proc As New System.Diagnostics.Process
            Proc.StartInfo.FileName = General.BasePath & "RPGXplorerHelp.chm"
            Application.DoEvents()
            Proc.Start()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the OGL command
    Public Shared Sub OGL(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Form.BrowserDockPanel.Show()
            ToolbarsAndMenus.BrowserButton.Down = True
            General.MainExplorer.ShowHelp("OGL.htm")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the OpenClosed command
    Public Shared Sub OpenClosed(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Form.BrowserDockPanel.Show()
            ToolbarsAndMenus.BrowserButton.Down = True
            General.MainExplorer.ShowHelp("EULA.htm")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the About command
    Public Shared Sub About(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New AboutForm
        Try
            Form.init()
            Form.ShowDialog()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the News command
    Public Shared Sub News(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New NewsForm
        Try
            Form.Init()
            Form.ShowDialog()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Marketplace and Shopping Cart"

    'handles the Shopping Cart command
    Public Shared Sub ShoppingCart(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim BarButtonItem As BarButtonItem

        Try
            BarButtonItem = CType(e.Link.Item, BarButtonItem)
            If BarButtonItem.Down Then
                If General.Marketplace Is Nothing Then
                    General.Marketplace = New Marketplace
                    General.Marketplace.Init()
                End If
                General.Marketplace.Show()
            Else
                If General.Marketplace.WindowState = FormWindowState.Minimized Then
                    General.Marketplace.WindowState = FormWindowState.Normal
                    BarButtonItem.Down = True
                Else
                    General.Marketplace.Visible = False
                End If
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'change prices
    Public Shared Sub PricesChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim Item As BarEditItem = CType(sender, BarEditItem)
            Config.Element("MarketPrices") = Item.EditValue.ToString
            General.MarketPrices = CType(Item.EditValue, Integer)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add to Cart command
    Public Shared Sub CartAdd(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddManyToCart(General.MainExplorer.CurrentSelectedObjects)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddManyToCart(General.Marketplace.CurrentlySelectedObjects)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Masterwork to Cart command
    Public Shared Sub CartMasterwork(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddToCart(General.MainExplorer.CurrentSelectedObjects.Item(0), True)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddToCart(General.Marketplace.CurrentlySelectedObjects.Item(0), True)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Plus 1 to Cart command
    Public Shared Sub CartPlusOne(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddToCart(General.MainExplorer.CurrentSelectedObjects.Item(0), True, 1)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddToCart(General.Marketplace.CurrentlySelectedObjects.Item(0), True, 1)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Plus 2 to Cart command
    Public Shared Sub CartPlusTwo(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddToCart(General.MainExplorer.CurrentSelectedObjects.Item(0), True, 2)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddToCart(General.Marketplace.CurrentlySelectedObjects.Item(0), True, 2)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Plus 3 to Cart command
    Public Shared Sub CartPlusThree(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddToCart(General.MainExplorer.CurrentSelectedObjects.Item(0), True, 3)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddToCart(General.Marketplace.CurrentlySelectedObjects.Item(0), True, 3)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Plus 4 to Cart command
    Public Shared Sub CartPlusFour(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddToCart(General.MainExplorer.CurrentSelectedObjects.Item(0), True, 4)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddToCart(General.Marketplace.CurrentlySelectedObjects.Item(0), True, 4)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Plus 5 to Cart command
    Public Shared Sub CartPlusFive(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'General.MainExplorer.Undo.UndoRecord()
            'General.ShoppingCartPanel.Cart.AddToCart(General.MainExplorer.CurrentSelectedObjects.Item(0), True, 5)
            'General.ShoppingCartPanel.UpdateDisplays()
            'General.ShoppingCartPanel.LoadListView()

            General.MainExplorer.Undo.UndoRecord()
            General.Marketplace.ShoppingCart.Cart.AddToCart(General.Marketplace.CurrentlySelectedObjects.Item(0), True, 5)
            General.Marketplace.ShoppingCart.UpdateDisplays()
            General.Marketplace.ShoppingCart.LoadListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Add Custom Item to Cart command
    Public Shared Sub CartCustom(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'Dim Form As New CustomCartItemForm
            'Form.Init(General.MainExplorer.CurrentSelectedObjects.Item(0), General.ShoppingCartPanel.Cart.BuySize, General.ShoppingCartPanel.Cart.CartObject.ObjectGUID)
            'If Form.ShowDialog = DialogResult.OK Then
            '    General.MainExplorer.Undo.UndoRecord()
            '    General.ShoppingCartPanel.Cart.AddInventoryItemToCart(Form.InventoryItem)
            '    General.ShoppingCartPanel.UpdateDisplays()
            '    General.ShoppingCartPanel.LoadListView()
            'End If


            Dim Form As New CustomCartItemForm
            Form.Init(General.Marketplace.CurrentlySelectedObjects.Item(0), General.Marketplace.ShoppingCart.Cart.BuySize, General.Marketplace.ShoppingCart.Cart.CartObject.ObjectGUID)
            If Form.ShowDialog = DialogResult.OK Then
                General.MainExplorer.Undo.UndoRecord()
                General.Marketplace.ShoppingCart.Cart.AddInventoryItemToCart(Form.InventoryItem)
                General.Marketplace.ShoppingCart.UpdateDisplays()
                General.Marketplace.ShoppingCart.LoadListView()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Inventory"

    'handles the Add Money command
    Public Shared Sub AddMoney(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New MoneyForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.InitAdd(Folder)
            AddForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Edit Money command
    Public Shared Sub EditMoney(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New MoneyForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'edit the object
            EditForm.InitEdit(EditObj)
            EditForm.Show()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Activate command
    Public Shared Sub Activate(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Item As Objects.ObjectData

        Try
            General.MainExplorer.Undo.UndoRecord()

            'get the magic item
            Item = GetEditObject()
            Item.Element("Active") = "Yes"
            Item.Save()
            CharacterManager.SetDirty(CharacterManager.CurrentCharacter.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Deactivate command
    Public Shared Sub Deactivate(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Item As Objects.ObjectData
        Try
            General.MainExplorer.Undo.UndoRecord()

            'get the magic item
            Item = GetEditObject()
            Item.Element("Active") = "No"
            Item.Save()
            CharacterManager.SetDirty(CharacterManager.CurrentCharacter.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
            General.MainExplorer.RefreshPanel()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Sell Items command
    Public Shared Sub Sell(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim SellItemsForm As New SellItems

            If SellItemsForm.Init() Then SellItemsForm.ShowDialog()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Combine Money command
    Public Shared Sub CombineMoney(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Undo.UndoRecord()

            Dim Monies As Objects.ObjectDataCollection = General.MainExplorer.CurrentSelectedObjects
            Dim NewMoney As New Money

            For Each MoneyObj As Objects.ObjectData In Monies
                NewMoney.AddMoney(MoneyObj.Name)
                MoneyObj.Delete()
            Next

            'create the money obj to save
            Dim NewMoneyObj As New Objects.ObjectData

            NewMoneyObj.Name = NewMoney.DisplayString
            NewMoneyObj.ObjectGUID = Objects.ObjectKey.NewGuid(General.MainExplorer.ObjectSelectedInTree.ObjectGUID.Database)
            NewMoneyObj.Type = Objects.MoneyType
            NewMoneyObj.ParentGUID = General.MainExplorer.ObjectSelectedInTree.ObjectGUID
            NewMoneyObj.Element("Cost") = NewMoneyObj.Name
            NewMoneyObj.Element("Weight") = Rules.Formatting.FormatPounds(NewMoney.Weight)
            NewMoneyObj.Save()

            'refresh
            General.MainExplorer.RefreshPanel()
            General.MainExplorer.SelectItemByGuid(NewMoneyObj.ObjectGUID)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Scribe Scroll command
    Public Shared Sub ScribeScroll(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim ScrollForm As New ScrollForm

            ScrollForm.InitScribeScroll(GetFolder, CharacterManager.CurrentCharacter)
            ScrollForm.ShowDialog()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Edit Scroll command
    Public Shared Sub EditScroll(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New ScrollForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, CharacterManager.CurrentCharacter)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Imprint Power Stone command
    Public Shared Sub ImprintPowerStone(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim StoneForm As New PowerStoneForm

            StoneForm.InitImprintStone(GetFolder, CharacterManager.CurrentCharacter)
            StoneForm.ShowDialog()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Edit Power Stone command
    Public Shared Sub EditPowerStone(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim EditObj As Objects.ObjectData
        Dim EditForm As New PowerStoneForm

        Try
            'retrieve the folder
            EditObj = GetEditObject()

            'initialise and open the form
            EditForm.InitEdit(EditObj, CharacterManager.CurrentCharacter)
            EditForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Printing"

    'show print preview for the currently selected character
    Public Shared Sub PrintCharacterSheet(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Obj As Objects.ObjectData
        Dim Report As New CharacterSheet
        Dim Data As New Rules.CharacterSheetData

        Try
            General.MainExplorer.SaveCurrentPanel()
            Obj = GetEditObject()

            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Find, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendMht, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXls, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Watermark, DevExpress.XtraPrinting.CommandVisibility.None)
            Report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground, DevExpress.XtraPrinting.CommandVisibility.None)

            General.SetWaitCursor()
            Data.Init(Obj, Report.CharacterDataset1)
            Report.CharacterData = Data
            System.Threading.Thread.Sleep(0)
            Report.ShowPreview()
            General.SetNormalCursor()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'create and transform the xml for the character
    Public Shared Sub CharacterXSLOutput(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim BarManager As DevExpress.XtraBars.BarManager = CType(sender, DevExpress.XtraBars.BarManager)
            Dim FileName As String = General.BasePath & "XSLT\" & BarManager.PressedLink.Caption
            Dim CharacterObj As Objects.ObjectData = GetEditObject()

            'load or bring to front
            If General.XMLWorkShop Is Nothing Then
                Dim Form As New CharacterXMLForm
                General.SetWaitCursor()
                Form.Init()
                Form.Show()
                General.XMLWorkShop = Form
                General.SetNormalCursor()
            Else
                If General.XMLWorkShop.WindowState = FormWindowState.Minimized Then General.XMLWorkShop.WindowState = FormWindowState.Normal
                General.XMLWorkShop.Show()
                General.XMLWorkShop.BringToFront()
            End If

            'select the correct character
            For Each Item As DataListItem In General.XMLWorkShop.CharacterComboBox.Items()
                If Item.ObjectGUID.Equals(CharacterObj.ObjectGUID) Then
                    General.XMLWorkShop.CharacterEditItem.EditValue = Item
                End If
            Next

            'generate the xml
            General.XMLWorkShop.ExternalGenerateCharacterXML()

            'set the transform
            General.XMLWorkShop.ExternalSetTransformation(FileName)

            'transform
            General.XMLWorkShop.ExternalTransform()

            'set broweser display
            General.XMLWorkShop.XtraTabControl1.SelectedTabPageIndex = 2

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Spell/Power List"

    'handles the Create Power List command
    Public Shared Sub AddPowers(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New PowerListForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Create Spell List command
    Public Shared Sub AddSpells(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim AddForm As New SpellListForm
        Dim Folder As Objects.ObjectData

        Try
            'retrieve the folder that we are adding an object to
            Folder = GetFolder()

            AddForm.Init(Folder)
            AddForm.ShowDialog()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Remove Powers command
    Public Shared Sub RemovePowers(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If General.MainExplorer.CurrentPanelType <> Explorer.PanelType.PowerList Then Exit Sub

            'get the selected items
            Dim PowerListItems As Objects.ObjectDataCollection
            PowerListItems = General.MainExplorer.CurrentSelectedObjects
            If PowerListItems.Count < 1 Then Exit Sub

            General.MainExplorer.Undo.UndoRecord()

            'get the panel mode
            Select Case CType(General.MainExplorer.CurrentPanel, PowerListPanel).PanelMode

                Case Rules.PowerList.PowerListOperationMode.Definition
                    Dim PowerLevelSource As Objects.ObjectData
                    Dim PowerLevelObject As Objects.ObjectData
                    Dim PowerLevels As New Objects.ObjectDataCollection

                    'get the Level Source
                    PowerLevelSource = PowerListItems.Item(0).Parent.Parent

                    Select Case PowerListItems.Count
                        Case Is < 15
                            For Each Item As Objects.ObjectData In PowerListItems
                                PowerLevelObject = Item.GetFKObject("PowerLevel")
                                PowerLevels.Add(PowerLevelObject)
                            Next

                        Case Else
                            Dim AllLevels As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.Powers, Objects.PowerLevelType)
                            For Each Item As Objects.ObjectData In PowerListItems
                                PowerLevelObject = AllLevels.Item(Item.GetFKGuid("SpellLevel"))
                                PowerLevels.Add(PowerLevelObject)
                            Next
                    End Select

                    Rules.PowerList.RemovepowerLevels(PowerLevels, PowerLevelSource.ObjectGUID)

            End Select

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Remove Spell command
    Public Shared Sub RemoveSpell(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If General.MainExplorer.CurrentPanelType <> Explorer.PanelType.SpellList Then Exit Sub

            'get the selected items
            Dim SpellListItems As Objects.ObjectDataCollection
            SpellListItems = General.MainExplorer.CurrentSelectedObjects
            If SpellListItems.Count < 1 Then Exit Sub

            General.MainExplorer.Undo.UndoRecord()

            'get the panel mode
            Select Case CType(General.MainExplorer.CurrentPanel, SpellListPanel).PanelMode

                Case Rules.SpellList.SpellListOperationMode.Definition
                    Dim SpellLevelSource As Objects.ObjectData
                    Dim SpellLevelObject As Objects.ObjectData
                    Dim SpellLevels As New Objects.ObjectDataCollection

                    'get the Level Source
                    SpellLevelSource = SpellListItems.Item(0).Parent.Parent

                    Select Case SpellListItems.Count
                        Case Is < 15
                            For Each Item As Objects.ObjectData In SpellListItems
                                SpellLevelObject = Item.GetFKObject("SpellLevel")
                                SpellLevels.Add(SpellLevelObject)
                            Next

                        Case Else
                            Dim AllLevels As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.Spells, Objects.SpellLevelType)
                            For Each Item As Objects.ObjectData In SpellListItems
                                SpellLevelObject = AllLevels.Item(Item.GetFKGuid("SpellLevel"))
                                SpellLevels.Add(SpellLevelObject)
                            Next
                    End Select

                    Rules.SpellList.RemoveSpellLevels(SpellLevels, SpellLevelSource.ObjectGUID)

                Case Rules.SpellList.SpellListOperationMode.Character
                    Commands.DeleteObjects(Nothing, Nothing)
            End Select

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Miscellaneous"

    'handles the Properties command
    Public Shared Sub Properties(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Form As New PropertiesForm

        Try
            Form.Init(General.MainExplorer.CurrentSelectedObjects)
            Form.Show()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Folder Up command
    Public Shared Sub FolderUp(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'if sent from main key trap and focus is tree view then ignore, tree view handles already
            If sender Is Nothing And General.MainExplorer.CurrentFocus = Explorer.Focus.TreeView Then Exit Sub

            General.MainExplorer.TreeView.Focus()
            If Not General.MainExplorer.ObjectSelectedInTree.ParentGUID.Equals(Objects.ObjectKey.Empty) Then
                General.MainExplorer.TreeView.SelectedNode = General.MainExplorer.TreeView.SelectedNode.Parent
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Folder Expand command
    Public Shared Sub FolderExpand(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Expand()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Folder Collapse command
    Public Shared Sub FolderCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Collapse()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Reset Tree command
    Public Shared Sub ResetTree(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim TreeView As TreeView = General.MainExplorer.TreeView

            If Not TreeView Is Nothing Then
                Dim Selected As TreeNode = TreeView.SelectedNode
                TreeView.CollapseAll()
                For Each Node As TreeNode In TreeView.Nodes
                    Node.Expand()
                Next
                If Not Selected Is Nothing Then
                    TreeView.SelectedNode = Selected
                    Selected.EnsureVisible()
                End If
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the manual refresh command
    Public Shared Sub RefreshTree(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            General.MainExplorer.Refresh()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Save command
    Public Shared Sub Save(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            'save the database
            XML.SaveXMLDB()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles the Shift Enter command
    Public Shared Function ShiftEnter(Optional ByVal RetVal As Boolean = False) As Boolean
        Dim EditObj As Objects.ObjectData

        Try
            'retrieve the obj
            If General.MainExplorer.SelectedObjectCount > 1 Then
                Properties(Nothing, Nothing)
                Return False
            Else
                EditObj = GetEditObject()
            End If

            Select Case EditObj.Type
                Case Objects.AmmoDefinitionType
                    EditAmmoDefinition(Nothing, Nothing)
                Case Objects.ArmorDefinitionType
                    EditArmorDefinition(Nothing, Nothing)
                Case Objects.ArmorMagicAbilityDefinitionType
                    Commands.EditArmorMagicAbilityDefinition(Nothing, Nothing)
                Case Objects.ArtifactDefinitionType
                    Commands.EditArtifactDefinition(Nothing, Nothing)
                Case Objects.CharacterType
                    Commands.EditCharacter(Nothing, Nothing)
                Case Objects.ChooseBonusFeatType
                    Commands.EditChooseBonusFeat(Nothing, Nothing)
                Case Objects.ChooseFeatureType
                    Commands.EditChooseFeature(Nothing, Nothing)
                Case Objects.ClassLevelType
                    Commands.EditClassLevel(Nothing, Nothing)
                Case Objects.ClassType
                    Commands.EditClass(Nothing, Nothing)
                Case Objects.CurseType
                    Commands.EditCurse(Nothing, Nothing)
                Case Objects.ChooseFeatureType
                    Commands.EditChooseFeature(Nothing, Nothing)
                Case Objects.ConditionType
                    Commands.EditCondition(Nothing, Nothing)
                Case Objects.DamageAdditionType
                    Commands.EditDamageAddition(Nothing, Nothing)
                Case Objects.DamageReductionType
                    Commands.EditDamageReduction(Nothing, Nothing)
                Case Objects.DamageResistanceType
                    Commands.EditDamageResistance(Nothing, Nothing)
                Case Objects.DamageVulnerabilityType
                    Commands.EditDamageVulnerability(Nothing, Nothing)
                Case Objects.DeityDefinitionType
                    Commands.EditDeityDefinition(Nothing, Nothing)
                Case Objects.DomainDefinitionType
                    Commands.EditDomainDefinition(Nothing, Nothing)
                Case Objects.EnhancementBonusType
                    Commands.EditEnhancement(Nothing, Nothing)
                Case Objects.FeatDefinitionType
                    Commands.EditFeatDefinition(Nothing, Nothing)
                Case Objects.FeatureType
                    Commands.EditFeature(Nothing, Nothing)
                Case Objects.FeatureDefinitionType
                    Commands.EditFeatureDefinition(Nothing, Nothing)
                Case Objects.FlurryOfBlowsType
                    Commands.EditFlurryOfBlows(Nothing, Nothing)
                Case Objects.GrantedPowerType
                    Commands.EditGrantedPower(Nothing, Nothing)
                Case Objects.ImprovedUnarmedDamageType
                    Commands.EditImprovedUnarmedDamage(Nothing, Nothing)
                Case Objects.IntelligenceType
                    Commands.EditIntelligence(Nothing, Nothing)
                Case Objects.ItemDefinitionType
                    Commands.EditItemDefinition(Nothing, Nothing)
                Case Objects.LanguageDefinitionType
                    Commands.EditLanguage(Nothing, Nothing)
                Case Objects.MagicAmmoDefinitionType
                    Commands.EditMagicAmmoDefinition(Nothing, Nothing)
                Case Objects.ModifierLimiterType
                    Commands.EditModifierLimiter(Nothing, Nothing)
                Case Objects.ModifierType
                    Commands.EditModifier(Nothing, Nothing)
                Case Objects.MonsterTypeType
                    Commands.EditMonsterType(Nothing, Nothing)
                Case Objects.PotionDefinitionType
                    Commands.EditPotionDefinition(Nothing, Nothing)
                Case Objects.PowerDefinitionType
                    Commands.EditPowerDefinition(Nothing, Nothing)
                Case Objects.PrerequisiteType
                    Commands.EditPrerequisite(Nothing, Nothing)
                Case Objects.PsiLikeAbilityType
                    Commands.EditPsiLikeAbility(Nothing, Nothing)
                Case Objects.RaceType
                    Commands.EditRace(Nothing, Nothing)
                Case Objects.RegenerationType
                    Commands.EditRegeneration(Nothing, Nothing)
                Case Objects.RingDefinitionType
                    Commands.EditRingDefinition(Nothing, Nothing)
                Case Objects.RodDefinitionType
                    Commands.EditRodDefinition(Nothing, Nothing)
                Case Objects.SpecialMaterialDefinitionType
                    Commands.EditSpecialMaterialDefinition(Nothing, Nothing)
                Case Objects.ScrollDefinitionType
                    Commands.EditScrollDefinition(Nothing, Nothing)
                Case Objects.ShieldDefinitionType
                    Commands.EditArmorDefinition(Nothing, Nothing)
                Case Objects.SkillDefinitionType
                    Commands.EditSkillDefinition(Nothing, Nothing)
                Case Objects.SkillSynergyType
                    Commands.EditSkillSynergy(Nothing, Nothing)
                Case Objects.SpecificArmorDefinitionType
                    Commands.EditSpecificArmorDefinition(Nothing, Nothing)
                Case Objects.SpecificBonusFeatType
                    Commands.EditSpecificBonusFeat(Nothing, Nothing)
                Case Objects.SpecificWeaponDefinitionType
                    Commands.EditSpecificWeaponDefinition(Nothing, Nothing)
                Case Objects.SpellDefinitionType
                    Commands.EditSpellDefinition(Nothing, Nothing)
                Case Objects.SpellDescriptorDefinitionType
                    Commands.EditSpellDescriptor(Nothing, Nothing)
                Case Objects.SpellLikeAbilityType
                    Commands.EditSpellLikeAbility(Nothing, Nothing)
                Case Objects.SpellResistanceType
                    Commands.EditSpellResistance(Nothing, Nothing)
                Case Objects.SpellSchoolType
                    Commands.EditSpellSchool(Nothing, Nothing)
                Case Objects.SpellSubschoolType
                    Commands.EditSpellSubschool(Nothing, Nothing)
                Case Objects.SpellsKnownType
                    Commands.EditSpellsKnown(Nothing, Nothing)
                Case Objects.SpellsPerDayType
                    Commands.EditSpellsPerDay(Nothing, Nothing)
                Case Objects.StaffDefinitionType
                    Commands.EditStaffDefinition(Nothing, Nothing)
#If CompileMode = "Tools" Then
                Case Objects.SystemAbilityDefinitionType
                    Commands.EditSystemAbilityDefinition(Nothing, Nothing)
                Case Objects.SystemElementType
                    Commands.EditSystemElement(Nothing, Nothing)
                Case Objects.SystemPreconditionDefinitionType
                    Commands.EditSystemPreconditionDefinition(Nothing, Nothing)
                Case Objects.SystemReferenceType
                    Commands.EditSystemReference(Nothing, Nothing)
                Case Objects.SystemWeaponAbilityDefinitionType
                    Commands.EditSystemWeaponAbilityDefinition(Nothing, Nothing)
#End If
                Case Objects.WandDefinitionType
                    Commands.EditWandDefinition(Nothing, Nothing)
                Case Objects.WeaponDefinitionType
                    Commands.EditWeaponDefinition(Nothing, Nothing)
                Case Objects.WeaponMagicAbilityDefinitionType
                    Commands.EditWeaponMagicAbilityDefinition(Nothing, Nothing)
                Case Objects.WondrousDefinitionType
                    Commands.EditWondrousDefinition(Nothing, Nothing)

                Case Objects.PsionicArtifactDefinitionType
                    Commands.EditPsionicArtifactDefinition(Nothing, Nothing)
                Case Objects.PsionicAmmoDefinitionType
                    Commands.EditPsionicAmmoDefinition(Nothing, Nothing)
                Case Objects.PsionicArmorAbilityDefinitionType
                    Commands.EditPsionicArmorAbilityDefinition(Nothing, Nothing)
                Case Objects.PsionicArmorDefinitionType
                    Commands.EditPsionicArmorDefinition(Nothing, Nothing)
                Case Objects.PsionicDisciplineType
                    Commands.EditPsionicDisciplineDefinition(Nothing, Nothing)
                Case Objects.PsionicDorjeDefinitionType
                    Commands.EditDorjeDefinition(Nothing, Nothing)
                Case Objects.PsionicPowerStoneDefinitionType
                    Commands.EditPowerStoneDefinition(Nothing, Nothing)
                Case Objects.PsionicPsicrownDefinitionType
                    Commands.EditPsicrownDefinition(Nothing, Nothing)
                Case Objects.PsionicSpecializationDefinitionType
                    Commands.EditPsionicSpecializationDefinition(Nothing, Nothing)
                Case Objects.PsionicSubdisciplineType
                    Commands.EditPsionicSubdiscip(Nothing, Nothing)
                Case Objects.PsionicTattooDefinitionType
                    Commands.EditPsionicTattooDefinition(Nothing, Nothing)
                Case Objects.PsionicWeaponAbilityDefinitionType
                    Commands.EditPsionicWeaponAbilityDefinition(Nothing, Nothing)
                Case Objects.PsionicWeaponDefinitionType
                    Commands.EditPsionicWeaponDefinition(Nothing, Nothing)
                Case Objects.UniversalItemDefinitionType
                    Commands.EditUniversalDefinition(Nothing, Nothing)

                Case Objects.PowerProgressionType
                    Commands.EditPowerProgression(Nothing, Nothing)
                Case Objects.ItemType
                    Commands.EditItem(Nothing, Nothing)
                Case Objects.MoneyType
                    Commands.EditMoney(Nothing, Nothing)
                Case Objects.SpellCategoryDefinitionType
                    Commands.EditSpellCategory(Nothing, Nothing)

                    'monsters
                Case Objects.MonsterRaceDefinitionType
                    Commands.EditMonsterRace(Nothing, Nothing)
                Case Objects.MonsterClassType
                    Commands.EditMonsterClass(Nothing, Nothing)
                Case Objects.MonsterClassLevelType
                    Commands.EditClassLevel(Nothing, Nothing)
                Case Objects.NaturalWeaponDefinitionType
                    Commands.EditNaturalWeaponDefinition(Nothing, Nothing)
                Case Objects.SubtypeDefinitionType
                    Commands.EditSubtypeDefinition(Nothing, Nothing)

                Case Else
                    If RetVal Then
                        Return False
                    Else
                        General.ShowInfoDialog("Shift-Enter not defined for this component type.")
                    End If
            End Select

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'handles the Plus key command
    Public Shared Sub Plus()
        Dim Folder As Objects.ObjectData

        Try

            Folder = GetFolder()

            Select Case Folder.Type
                Case Objects.ArmorDefinitionFolderType
                    Commands.AddArmorDefinition(Nothing, Nothing)
                Case Objects.ArmorMagicAbilityDefinitionFolderType
                    Commands.AddArmorMagicAbilityDefinition(Nothing, Nothing)
                Case Objects.ArtifactDefinitionFolderType
                    Commands.AddArtifactDefinition(Nothing, Nothing)
                Case Objects.CharacterFolderType, Objects.CharacterType, Objects.AssetsFolderType, Objects.CharacterChoiceFolderType, Objects.FeatFolderType, Objects.FeatureFolderType, Objects.CharacterLevelsFolderType, Objects.CharacterLevelType, Objects.MagicFolderType, Objects.InventoryFolderType, Objects.SkillFolderType, Objects.WeaponConfigFolderType, Objects.ClassSpellListFolderType, Objects.ClassSpellSettingsFolderType, Objects.ModifierFolderType, Objects.LanguageFolderType, Objects.MonsterFolderType, Objects.MonsterType
                    Exit Sub
                Case Objects.ClassFolderType
                    Commands.AddClass(Nothing, Nothing)
                Case Objects.ClassLevelsFolderType
                    Commands.AddClassLevel(Nothing, Nothing)
                Case Objects.ClassLevelsSpellsKnownFolderType
                    Commands.AddSpellsKnown(Nothing, Nothing)
                Case Objects.ClassLevelsSpellsPerDayFolderType
                    Commands.AddSpellsPerDay(Nothing, Nothing)
                Case Objects.DeityDefinitionFolderType
                    Commands.AddDeityDefinition(Nothing, Nothing)
                Case Objects.DomainDefinitionFolderType
                    Commands.AddDomainDefinition(Nothing, Nothing)
                Case Objects.FeatDefinitionsFolderType
                    Commands.AddFeatDefinition(Nothing, Nothing)
                Case Objects.FeatureDefinitionFolderType
                    Commands.AddFeatureDefinition(Nothing, Nothing)
                Case Objects.ItemDefinitionFolderType
                    Commands.AddItemDefinition(Nothing, Nothing)
                Case Objects.LanguageDefinitionFolderType
                    Commands.AddLanguage(Nothing, Nothing)
                Case Objects.ModifierLimiterFolderType
                    Commands.AddModifierLimiter(Nothing, Nothing)
                Case Objects.MonsterTypeFolderType
                    Commands.AddMonsterType(Nothing, Nothing)
                Case Objects.PotionDefinitionFolderType
                    Commands.AddPotionDefinition(Nothing, Nothing)
                Case Objects.PowerDefinitionFolderType
                    Commands.AddPowerDefinition(Nothing, Nothing)
                Case Objects.RaceFolderType
                    Commands.AddRace(Nothing, Nothing)
                Case Objects.RingDefinitionFolderType
                    Commands.AddRingDefinition(Nothing, Nothing)
                Case Objects.RodDefinitionFolderType
                    Commands.AddRodDefinition(Nothing, Nothing)
                Case Objects.SpecialMaterialDefinitionsFolderType
                    Commands.AddSpecialMaterialDefinition(Nothing, Nothing)
                Case Objects.ScrollDefinitionFolderType
                    Commands.AddScrollDefinition(Nothing, Nothing)
                Case Objects.SkillDefinitionFolderType
                    Commands.AddSkillDefinition(Nothing, Nothing)
                Case Objects.SpecificArmorDefinitionFolderType
                    Commands.AddSpecificArmorDefinition(Nothing, Nothing)
                Case Objects.SpecificWeaponDefinitionFolderType
                    Commands.AddSpecificWeaponDefinition(Nothing, Nothing)
                Case Objects.SpellDefinitionFolderType
                    Commands.AddSpellDefinition(Nothing, Nothing)
                Case Objects.SpellDescriptorDefinitionFolderType
                    Commands.AddSpellDescriptor(Nothing, Nothing)
                Case Objects.SpellSchoolFolderType
                    Commands.AddSpellSchool(Nothing, Nothing)
                Case Objects.StaffDefinitionFolderType
                    Commands.AddStaffDefinition(Nothing, Nothing)
                Case Objects.SystemAbilityDefinitionFolderType
                    Commands.AddSystemAbilityDefinition(Nothing, Nothing)
                Case Objects.SystemElementFolderType
                    Commands.AddSystemElement(Nothing, Nothing)
                Case Objects.SystemPreconditionDefinitionFolderType
                    Commands.AddSystemPreconditionDefinition(Nothing, Nothing)
                Case Objects.SystemWeaponAbilityDefinitionFolderType
                    Commands.AddSystemWeaponAbilityDefinition(Nothing, Nothing)
                Case Objects.WandDefinitionFolderType
                    Commands.AddWandDefinition(Nothing, Nothing)
                Case Objects.WeaponDefinitionFolderType
                    Commands.AddWeaponDefinition(Nothing, Nothing)
                Case Objects.WeaponMagicAbilityDefinitionFolderType
                    Commands.AddWeaponMagicAbilityDefinition(Nothing, Nothing)
                Case Objects.WondrousDefinitionFolderType
                    Commands.AddWondrousDefinition(Nothing, Nothing)
                Case Objects.PsionicArtifactDefinitionsFolderType
                    Commands.AddPsionicArtifactDefinition(Nothing, Nothing)
                Case Objects.PsionicArmorAbilityDefinitionsFolderType
                    Commands.AddPsionicArmorAbilityDefinition(Nothing, Nothing)
                Case Objects.PsionicArmorAbilityDefinitionsFolderType
                    Commands.AddPsionicArmorDefinition(Nothing, Nothing)
                Case Objects.PsionicDisciplineFolderType
                    Commands.AddPsionicDisciplineDefinition(Nothing, Nothing)
                Case Objects.PsionicDorjeDefinitionsFolderType
                    Commands.AddDorjeDefinition(Nothing, Nothing)
                Case Objects.PsionicPowerStoneDefinitionsFolderType
                    Commands.AddPowerStoneDefinition(Nothing, Nothing)
                Case Objects.PsionicPsicrownDefinitionFolderType
                    Commands.AddPsicrownDefinition(Nothing, Nothing)
                Case Objects.PsionicSpecializationDefinitionFolderType
                    Commands.AddPsionicSpecializationDefinition(Nothing, Nothing)
                Case Objects.PsionicTattooDefinitionsFolderType
                    Commands.AddPsionicTattooDefinition(Nothing, Nothing)
                Case Objects.PsionicWeaponAbilityDefinitionsFolderType
                    Commands.AddPsionicWeaponAbilityDefinition(Nothing, Nothing)
                Case Objects.PsionicWeaponDefinitionsFolderType
                    Commands.AddPsionicWeaponDefinition(Nothing, Nothing)
                Case Objects.UniversalItemDefinitionFolderType
                    Commands.AddUniversalDefinition(Nothing, Nothing)
                Case Objects.SpellCategoryFolder
                    Commands.AddSpellCategory(Nothing, Nothing)

                    'monsters
                Case Objects.MonsterRaceDefinitionFolderType
                    Commands.AddMonsterRace(Nothing, Nothing)
                Case Objects.MonsterClassFolderType
                    Commands.AddMonsterClass(Nothing, Nothing)
                Case Objects.MonsterClassLevelsFolderType
                    Commands.AddClassLevel(Nothing, Nothing)
                Case Objects.NaturalWeaponDefinitionsFolderType
                    Commands.AddNaturalWeaponDefinition(Nothing, Nothing)
                Case Objects.SubtypeDefinitionsFolderType
                    Commands.AddSubtypeDefinition(Nothing, Nothing)

                Case Else
                    If Not Folder.ObjectGUID.Equals(General.MainExplorer.ObjectSelectedInTree.ObjectGUID) Then
                        General.MainExplorer.CurrentFocus = Explorer.Focus.TreeView
                        Plus()
                    Else
                        General.ShowInfoDialog("Add Definition cannot determine which component to add.")
                    End If

            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'clear portrait
    Public Shared Sub ClearPortrait(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        General.MainExplorer.Undo.UndoRecord()
        Dim Character As Objects.ObjectData = GetEditObject()

        Character.Element("Portrait") = ""
        Character.Save()
        General.MainExplorer.RefreshPanel()
    End Sub

    'create class levels
    Public Shared Sub CreateClassLevels(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim Folder As Objects.ObjectData

        'get class levels folder
        Folder = GetFolder()
        CreateClassLevels(Folder)
    End Sub

    'create class levels
    Public Shared Sub CreateClassLevels(ByVal Folder As Objects.ObjectData)
        Dim ClassLevelsFolder As New Objects.ObjectData

        Select Case Folder.Type
            Case Objects.ClassType
                ClassLevelsFolder = Folder.FirstChildOfType(Objects.ClassLevelsFolderType)
            Case Objects.ClassLevelsFolderType
                ClassLevelsFolder = Folder
            Case Objects.MonsterClassType
                ClassLevelsFolder = Folder.FirstChildOfType(Objects.MonsterClassLevelsFolderType)
            Case Objects.MonsterClassLevelsFolderType
                ClassLevelsFolder = Folder
        End Select

        'show form
        Dim Form As New CreateClassLevelsForm

        Form.Init(ClassLevelsFolder)
        Form.Show()
    End Sub

    'create monster class levels
    Public Shared Sub CreateMonsterClassLevels(ByVal Folder As Objects.ObjectData)
        Dim ClassLevelsFolder As New Objects.ObjectData

        Select Case Folder.Type
            Case Objects.MonsterClassType
                ClassLevelsFolder = Folder.FirstChildOfType(Objects.MonsterClassLevelsFolderType)
            Case Objects.MonsterClassLevelsFolderType
                ClassLevelsFolder = Folder
        End Select

        'show form
        Dim Form As New CreateClassLevelsForm

        Form.Init(ClassLevelsFolder)
        Form.Show()
    End Sub

    'rename
    Public Shared Sub Rename(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Select Case General.MainExplorer.CurrentFocus
                Case Explorer.Focus.ListView
                    General.MainExplorer.ListView.SelectedItems(0).BeginEdit()
                Case Explorer.Focus.TreeView
                    General.MainExplorer.TreeView.SelectedNode.BeginEdit()
            End Select
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'add a tag to a group of objects
    Public Shared Sub AddTags(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If Rules.Lists.UserTags Is Nothing Then
                General.ShowInfoDialog("Please define some Tags first via Tools -> Edit a List.")
                Exit Sub
            End If

            Dim Form As New ConstructListDialog

            Form.Init("Choose Tags to Add", "Tags", "Add Tags", "Tags", "Tags to Add")
            Form.InitTextList(New ArrayList(Rules.Lists.UserTags), New ArrayList)

            If Form.ShowDialog() = DialogResult.OK Then
                Dim AddTags As ArrayList = Form.ListBFinal
                For Each Obj As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                    Dim Tags As ArrayList = New ArrayList(Obj.Element("Tags").Split(New Char() {";"c}))
                    For Each Tag As String In AddTags
                        If Not Tags.Contains(Tag) Then Tags.Add(Tag)
                    Next

                    Obj.Element("Tags") = CommonLogic.DelimitedList(";", Tags)
                    Obj.Save()
                Next

                General.MainExplorer.RefreshPanel()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'remove a tag from a group of objects
    Public Shared Sub RemoveTags(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If Rules.Lists.UserTags Is Nothing Then
                General.ShowInfoDialog("Please define some Tags first via Tools -> Edit a List.")
                Exit Sub
            End If

            Dim Form As New ConstructListDialog

            Form.Init("Choose Tags to Remove", "Tags", "Remove Tags", "Tags", "Tags to Remove")
            Form.InitTextList(New ArrayList(Rules.Lists.UserTags), New ArrayList)

            If Form.ShowDialog() = DialogResult.OK Then
                Dim RemoveTags As ArrayList = Form.ListBFinal
                For Each Obj As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                    Dim Tags As ArrayList = New ArrayList(Obj.Element("Tags").Split(New Char() {";"c}))
                    For Each Tag As String In RemoveTags
                        If Tags.Contains(Tag) Then Tags.Remove(Tag)
                    Next

                    Obj.Element("Tags") = CommonLogic.DelimitedList(";", Tags)
                    Obj.Save()
                Next

                General.MainExplorer.RefreshPanel()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Test Only"

    'fixes objects with the wrong htmlGUID database numbers
    'Public Shared Sub FixIntegrity()
    '    Dim Filename As String
    '    Dim Objs As Objects.ObjectDataCollection
    '    Dim HTMLGUID As Guid
    '    Dim HMTLDatabase As Integer
    '    Dim FKGuid As Objects.ObjectKey
    '    Dim FKElements As ArrayList
    '    Dim mismatches As Integer = 0

    '    Dim RealObject As Objects.ObjectData

    '    'iterate through the databases
    '    For i As Integer = 1 To 33
    '        Filename = BasePath & "XML\Database" & i.ToString & ".xml"
    '        Objs = XML.LoadXML(Filename)

    '        For Each TempObject As Objects.ObjectData In Objs
    '            'get the current htmlGUID info
    '            RealObject.Clear()
    '            RealObject.Load(TempObject.ObjectGUID)

    '            HTMLGUID = RealObject.HTMLGUID.ObjectGuid
    '            HMTLDatabase = RealObject.HTMLGUID.Database

    '            'check this against any FK elements the object has
    '            FKElements = RealObject.GetAllFKElements
    '            For Each Element As String In FKElements
    '                FKGuid = RealObject.GetFKGuid(Element)
    '                If HTMLGUID.Equals(FKGuid.ObjectGuid) Then

    '                    'if the keys match but the database numbers are wrong, then update the htmlGUID
    '                    If Not HMTLDatabase = FKGuid.Database Then
    '                        mismatches += 1
    '                        RealObject.Element("HTMLGUID") = XML.PadDBNumber(FKGuid.Database) & "-" & HTMLGUID.ToString
    '                    End If
    '                End If

    '            Next
    '        Next
    '    Next

    '    'display mismatches
    '    MessageBox.Show(mismatches.ToString)

    'End Sub

#End Region

End Class