Option Explicit On 
Option Strict On

Imports System.Xml
Imports RPGXplorer.General
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Public Class SaveLoad

    'this class is responsible for all saving and loading inc. common command code

#Region "Common Command Code"

    'handles the Load Components command
    Public Shared Sub LoadComponents(ByVal Sender As Form)
        Dim Ofd As New OpenFileDialog
        Dim Objs As Objects.ObjectDataCollection

        Ofd.InitialDirectory = BasePath & "XML\"
        Ofd.Filter = "XML Files (*.xml)|*.xml"

        If Ofd.ShowDialog() = DialogResult.OK Then
            Dim Version As String = ""
            General.SetWaitCursor(Sender)

            Try
                Objs = XML.LoadXML(Ofd.FileName, Version)
            Catch ex As Exception
                General.SetNormalCursor(Sender)
                Exit Sub
            End Try            

            If Objs.Count > 0 Then
                XML.Lock = True
                LoadObjects(Objs, Version)
                XML.Lock = False

                'update windows and caches
                WindowManager.SetAllDirty()
                CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                Caches.SetAllDirty()
                General.MainExplorer.Refresh()
            Else
                General.ShowInfoDialog("No components in this file.")
            End If

            General.SetNormalCursor(Sender)
        End If
    End Sub

    'handles the Save Components command
    Public Shared Sub SaveComponents(ByVal Sender As Form, ByVal SelectedObjects As Objects.ObjectDataCollection, Optional ByVal SaveRulePages As Boolean = True)
        Dim Sfd As New SaveFileDialog

        'check to see that they are all primary
        Dim Primary As Boolean = True

        For Each Obj As Objects.ObjectData In SelectedObjects
            If Not (Obj.IsPrimaryType Or Obj.IsPrimaryFolderType Or Obj.IsRulesType Or Obj.IsListOrFilterType) Then
                Primary = False
                Exit For
            End If
        Next

        If Not Primary Then
            General.ShowInfoDialog("You can only save primary components e.g. Classes, Feats, Features. You cannot save system components OR sub components directly e.g. Modifiers, Bonus Feat, Damage Resistance etc.")
            Exit Sub
        End If

        'show file dialog
        Sfd.InitialDirectory = BasePath & "XML\"
        Sfd.Filter = "XML Files (*.xml)|*.xml"
        Sfd.OverwritePrompt = True

        If Sfd.ShowDialog() = DialogResult.OK Then

            Application.DoEvents()

            General.SetWaitCursor(Sender)

            XML.Lock = True

            Dim Objs As Objects.ObjectDataCollection = SaveObjects(SelectedObjects)

            'save the objects
            XML.SaveXML(Objs, Sfd.FileName)

            XML.Lock = False

            General.SetNormalCursor(Sender)

            'scan the objects to get the list of licenses being used.
            Dim Licenses As New ArrayList

            For Each Obj As Objects.ObjectData In Objs
                If Obj.Element("License") <> "" Then
                    If Not Licenses.Contains(Obj.Element("License")) Then Licenses.Add(Obj.Element("License"))
                End If
            Next

            If Licenses.Count = 0 Then
                General.ShowInfoDialog("The saves components contained no licenses.")
            Else
                General.ShowInfoDialog("The saved components contain the following licenses: " & CommonLogic.CommaSeparatedList(Licenses))
            End If

            'rule pages
            If SaveRulePages Then
                If General.ShowQuestionDialog("Do you want to create an export of all the associated rule pages?") = DialogResult.Yes Then
                    RPGXplorer.SaveLoad.SaveRulePages(Objs)
                End If
            End If

        End If
    End Sub

#End Region

#Region "Main Save/Load Code"

    'temp var used by save
    Private Shared SaveObjs As Objects.ObjectDataCollection
    Private Shared ProgressBar As ProgressBar
    Private Shared Counter As Integer
    Private Shared PsuedoKeyTable As ObjectHashtable

    'get the objects to save to disk then save them
    Public Shared Function SaveObjects(ByVal Selected As Objects.ObjectDataCollection) As Objects.ObjectDataCollection

        Try
            General.MainExplorer.Form.Enabled = False
            ProgressBar = New ProgressBar
            ProgressBar.Caption = "Analyzing Components (Working)"
            ProgressBar.Maximum = 1
            ProgressBar.TopMost = True
            ProgressBar.Show()
            Application.DoEvents()

            If PsuedoKeyTable Is Nothing Then
                PsuedoKeyTable = New ObjectHashtable(12)
                PsuedoKeyTable.Add(References.Ray, Nothing)
                PsuedoKeyTable.Add(References.Grapple, Nothing)
                PsuedoKeyTable.Add(References.TouchSpell, Nothing)
                PsuedoKeyTable.Add(References.RangedSpell, Nothing)
                PsuedoKeyTable.Add(References.CustomFeatFocus, Nothing)
                PsuedoKeyTable.Add(References.ChaoticEvil, Nothing)
                PsuedoKeyTable.Add(References.ChaoticGood, Nothing)
                PsuedoKeyTable.Add(References.ChaoticNeutral, Nothing)
                PsuedoKeyTable.Add(References.NeutralEvil, Nothing)
                PsuedoKeyTable.Add(References.NeutralGood, Nothing)
                PsuedoKeyTable.Add(References.TrueNeutral, Nothing)
                PsuedoKeyTable.Add(References.LawfulEvil, Nothing)
                PsuedoKeyTable.Add(References.LawfulGood, Nothing)
                PsuedoKeyTable.Add(References.LawfulNeutral, Nothing)

                'add the natural weapon keys
                For Each AttackString As String In RPGXplorer.Rules.Lists.NaturalAttackTypes
                    PsuedoKeyTable.Add(General.ConvertToObjectKey(AttackString, Xml.DBTypes.NaturalWeapons), Nothing)
                Next

            End If

            SaveObjs = New Objects.ObjectDataCollection
            Counter = 0
            GetSaveObjects(Selected, True)

            ProgressBar.Increment()
            Threading.Thread.Sleep(250)
            ProgressBar.Close()
            General.MainExplorer.Form.Enabled = True

            Return SaveObjs
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get all the objects to be saved inc. children and references (recursive)
    Private Shared Sub GetSaveObjects(ByVal Objs As Objects.ObjectDataCollection, Optional ByVal UpdateProgress As Boolean = False)

        If Objs.Count = 0 Then Exit Sub

        Dim FKObjects As Objects.ObjectDataCollection

        For Each Obj As Objects.ObjectData In Objs

            'add the objects to the list
            If Not SaveObjs.Contains(Obj.ObjectGUID) And Not Obj.IsPrimaryFolderType And Not Obj.IsSystemType Then
                SaveObjs.Add(Obj)
                Counter += 1

                'get all the foreign key references, we dont get foreign keys from spell/power levels.
                If Obj.Type <> Objects.SpellLevelType AndAlso Obj.Type <> Objects.PowerLevelType Then
                    FKObjects = GetFKObjects(Obj)
                Else
                    FKObjects = New Objects.ObjectDataCollection
                End If

                'progress bar
                If UpdateProgress Then
                    ProgressBar.Caption = "Analyzing Components (" & Counter.ToString & ")"
                    Application.DoEvents()
                End If

                If FKObjects.Count > 0 Then GetSaveObjects(FKObjects, True)
            End If

            'get all the children
            If Obj.Type = Objects.SpellListFolderType Then

                'spell list folder fix
                Dim Parent As Objects.ObjectData = Obj.Parent
                Dim SpellLevels As Objects.ObjectDataCollection = Rules.SpellList.SpellList(Parent.ObjectGUID)

                'get spell definitions
                For Each SpellLevel As Objects.ObjectData In SpellLevels
                    'add the spell level
                    If Not SaveObjs.Contains(SpellLevel.ObjectGUID) Then
                        SaveObjs.Add(SpellLevel)
                        Counter += 1
                    End If


                    'spell def
                    Dim SpellDef As Objects.ObjectData = SpellLevel.Parent
                    If Not SaveObjs.Contains(SpellDef.ObjectGUID) Then
                        Counter += 1
                        SaveObjs.Add(SpellDef)

                        'descriptors
                        Dim Descriptors As Objects.ObjectDataCollection = SpellDef.ChildrenOfType(Objects.SpellDescriptorType)
                        If Descriptors.Count > 0 Then GetSaveObjects(Descriptors)

                        'spell def fks
                        Dim SpellFKObjs As Objects.ObjectDataCollection = GetFKObjects(SpellDef)
                        If SpellFKObjs.Count > 0 Then GetSaveObjects(SpellFKObjs, True)
                    End If


                    'progress bar
                    If UpdateProgress Then
                        ProgressBar.Caption = "Analyzing Components (" & Counter.ToString & ")"
                        Application.DoEvents()
                    End If
                Next

            ElseIf Obj.Type = Objects.PowerListFolderType Then

                'power list folder fix
                Dim Parent As Objects.ObjectData = Obj.Parent
                Dim PowerLevels As Objects.ObjectDataCollection = Rules.PowerList.PowerList(Parent.ObjectGUID)

                'get spell definitions
                For Each PowerLevel As Objects.ObjectData In PowerLevels
                    'add the spell level
                    If Not SaveObjs.Contains(PowerLevel.ObjectGUID) Then
                        SaveObjs.Add(PowerLevel)
                        Counter += 1
                    End If

                    'power def
                    Dim PowerDef As Objects.ObjectData = PowerLevel.Parent
                    If Not SaveObjs.Contains(PowerDef.ObjectGUID) Then
                        Counter += 1
                        SaveObjs.Add(PowerDef)

                        'descriptors
                        Dim Descriptors As Objects.ObjectDataCollection = PowerDef.ChildrenOfType(Objects.SpellDescriptorType)
                        If Descriptors.Count > 0 Then GetSaveObjects(Descriptors)

                        'spell def fks
                        Dim PowerFKObjs As Objects.ObjectDataCollection = GetFKObjects(PowerDef)
                        If PowerFKObjs.Count > 0 Then GetSaveObjects(PowerFKObjs, True)
                    End If

                    'progress bar
                    If UpdateProgress Then
                        ProgressBar.Caption = "Analyzing Components (" & Counter.ToString & ")"
                        Application.DoEvents()
                    End If
                Next

            Else
                GetSaveObjects(Obj.Children)
            End If
        Next

    End Sub

    'get foreign key objects relating to this object
    Private Shared Function GetFKObjects(ByVal Obj As Objects.ObjectData) As Objects.ObjectDataCollection
        Dim FKObjects As Objects.ObjectDataCollection = New Objects.ObjectDataCollection

        Dim Node As XmlNode = Obj.XMLNode
        Dim FKObj As New Objects.ObjectData
        Dim FK As Objects.ObjectKey

        If Node.ChildNodes.Count > 6 Then

            For Each ChildNode As XmlNode In Node.ChildNodes
                If ChildNode.Attributes.Count > 0 Then
                    FK = New Objects.ObjectKey(ChildNode.Attributes("FK").InnerText)
                    If Not FK.IsEmpty Then
                        If Not SaveObjs.Contains(FK) Then
                            If Not (FK.Database = XML.DBTypes.Weapons OrElse FK.Database = Xml.DBTypes.NaturalWeapons) Then
                                FKObj.Load(FK)
                                If Not FKObj.ObjectGUID.Database = 0 Then
                                    FKObjects.Add(FKObj)
                                End If
                            Else
                                If Not PsuedoKeyTable.ContainsKey(FK) Then
                                    FKObj.Load(FK)
                                    If Not FKObj.ObjectGUID.Database = 0 Then
                                        FKObjects.Add(FKObj)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        Return FKObjects

    End Function

    'imports objects from an xml file
    Public Shared Sub LoadObjects(ByVal LoadObjs As Objects.ObjectDataCollection, ByVal Version As String)
        Try
            Dim Characters As New Objects.ObjectDataCollection
            Dim NewObjects As New Objects.ObjectDataCollection
            Dim ExistingObjects As New Objects.ObjectDataCollection
            Dim ChangedObjects As New Objects.ObjectDataCollection
            Dim IgnoreObjects As New Objects.ObjectDataCollection
            Dim Conflicts As New ArrayList
            Dim SpellsLoaded, NewUserlistItem As Boolean

            Dim SpellAndPowerLevelObjects As New Objects.ObjectDataCollection
            Dim ExistingLevelLookupTable As New ObjectHashtable

            'preparse
            UI.Disable()
            Dim PreparseProgressBar As ProgressBar
            PreparseProgressBar = New ProgressBar
            PreparseProgressBar.Caption = "Preparsing Dataset - Generating Key Map"
            PreparseProgressBar.Maximum = LoadObjs.Count
            PreparseProgressBar.TopMost = True
            PreparseProgressBar.Show()

            Dim ExistingObject As Objects.ObjectData
            Dim KeyMap As New ObjectHashtable(LoadObjs.Count)

            'first pass - generate the key mapping
            For Each Obj As Objects.ObjectData In LoadObjs
                If Obj.IsPrimaryType AndAlso Not Obj.IsRulesType Then
                    ExistingObject = XML.ExistingObject(Obj.ObjectGUID, Obj.Name, Obj.Type, Obj.ObjectGUID.Database)

                    If Not ExistingObject.IsEmpty Then
                        KeyMap.Add(Obj.ObjectGUID, ExistingObject.ObjectGUID)
                    End If
                End If
                PreparseProgressBar.Increment()
            Next

            If KeyMap.Count > 0 Then
                PreparseProgressBar.Caption = "Preparsing Dataset - Updating Keys"
                PreparseProgressBar.Reset()
                PreparseProgressBar.Maximum = LoadObjs.Count

                'second pass - update keys

                Dim UpdatedCollection As New Objects.ObjectDataCollection
                For Each Obj As Objects.ObjectData In LoadObjs
                    For Each Key As DictionaryEntry In KeyMap
                        Obj.XMLNode.InnerXml = Obj.XMLNode.InnerXml.Replace(CStr(Key.Key), DirectCast(Key.Value, Objects.ObjectKey).ToString)
                    Next
                    Obj.UpdateStructureFromNode()
                    UpdatedCollection.Add(Obj)
                    PreparseProgressBar.Increment()
                Next
                LoadObjs = UpdatedCollection
            End If
            PreparseProgressBar.Close()

            'progress bar
            Dim ProgressBar As ProgressBar
            ProgressBar = New ProgressBar
            ProgressBar.Caption = "Load Components - Analyzing"
            ProgressBar.Maximum = LoadObjs.Count
            ProgressBar.TopMost = True
            ProgressBar.Show()

            'scan the objects being loaded to determine what the primary components are
            For Each Obj As Objects.ObjectData In LoadObjs
                If Obj.Type = Objects.CharacterType Then
                    Characters.Add(Obj)
                    NewObjects.Add(Obj)
                ElseIf Obj.IsPrimaryFolderType Then
                    'ignore
                    IgnoreObjects.Add(Obj)
                ElseIf Obj.IsSystemType Then
                    If XML.ObjectExists(Obj.ObjectGUID) Then
                        IgnoreObjects.Add(Obj)
                    Else
                        NewObjects.Add(Obj)
                    End If
                ElseIf Obj.IsListOrFilterType Then
                    If Obj.Type = Objects.UserListItemType Then
                        If XML.UserListItemExists(Obj.Name, Obj.Element("ListName")) Then
                            'ignore
                            IgnoreObjects.Add(Obj)
                        Else
                            NewObjects.Add(Obj)
                            NewUserlistItem = True
                        End If
                    Else
                        If XML.ObjectExists(Obj.ObjectGUID) Then
                            ExistingObjects.Add(Obj)
                        Else
                            NewObjects.Add(Obj)
                        End If
                    End If
                ElseIf Obj.IsPrimaryType Or Obj.IsRulesType Then
                    If XML.ObjectExists(Obj.ObjectGUID) Then
                        ExistingObjects.Add(Obj)
                    Else
                        'if name is in use then object cannot be loaded - should never happen now due to key mapping
                        If XML.ObjectExists(Obj.Name, Obj.Type, Obj.ObjectGUID.Database) Then
                            Conflicts.Add(Obj.Name & "(" & Obj.Type & ") has same name as existing component of this type.")
                        Else
                            NewObjects.Add(Obj)
                        End If
                    End If
                    If Obj.Type = Objects.SpellDefinitionType Then SpellsLoaded = True
                    'get the spell/power levels
                ElseIf Obj.Type = Objects.SpellLevelType Then
                    SpellAndPowerLevelObjects.Add(Obj)
                    SpellsLoaded = True
                ElseIf Obj.Type = Objects.PowerLevelType Then
                    SpellAndPowerLevelObjects.Add(Obj)
                End If
                ProgressBar.Increment()
            Next

            'remove objects to ignore from save set
            LoadObjs.RemoveList(IgnoreObjects)

            'progress bar
            ProgressBar.Caption = "Load Components - Checking for Differences"
            ProgressBar.Reset()
            ProgressBar.Maximum = ExistingObjects.Count + SpellAndPowerLevelObjects.Count

            'check existing components to see if they have changed
            For Each Obj As Objects.ObjectData In ExistingObjects
                Select Case Obj.Type
                    Case Objects.SpellDefinitionType, Objects.PowerDefinitionType
                        'specific behaviour for spells and powers
                        If ExistingSpellDifferent(Obj, LoadObjs) Then
                            ChangedObjects.Add(Obj)
                        End If
                    Case Objects.SpellSchoolType
                        If ExistingSpellSchoolDifferent(Obj, LoadObjs) Then
                            ChangedObjects.Add(Obj)
                        End If
                    Case Else
                        If ExistingComponentDifferent(Obj, LoadObjs) Then
                            ChangedObjects.Add(Obj)
                        End If
                End Select

                ProgressBar.Increment()
            Next

            'check for existing spell levels with same class/domain/category
            For Each LevelObj As Objects.ObjectData In SpellAndPowerLevelObjects
                Dim ExistingDef As Objects.ObjectData = LevelObj.Parent
                Dim Element As String = ""

                Select Case LevelObj.Type
                    Case Objects.SpellLevelType
                        Element = Rules.SpellList.GetSpellLevelSourceElement(LevelObj)
                    Case Objects.PowerLevelType
                        Element = Rules.PowerList.GetPowerLevelSourceElement(LevelObj)
                End Select

                Dim SourceObject As Objects.ObjectData = LevelObj.GetFKObject(Element)

                If SourceExists(LevelObj, Element) Or NewObjects.Contains(LevelObj.GetFKGuid(Element)) Then
                    If ExistingObjects.Contains(ExistingDef.ObjectGUID) Then
                        Dim ExistingLevel As New Objects.ObjectData

                        Select Case LevelObj.Type
                            Case Objects.SpellLevelType
                                ExistingLevel = Objects.GetObjectByXPath(Xml.DBTypes.Spells, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & ExistingDef.ObjectGUID.ToString & "' and Type='Spell Level' and " & Element & "/@FK='" & LevelObj.GetFKGuid(Element).ToString & "']")
                            Case Objects.PowerLevelType
                                ExistingLevel = Objects.GetObjectByXPath(Xml.DBTypes.Powers, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & ExistingDef.ObjectGUID.ToString & "' and Type='Power Level' and " & Element & "/@FK='" & LevelObj.GetFKGuid(Element).ToString & "']")
                        End Select

                        'if this is a new spelllevel
                        If ExistingLevel.IsEmpty Then
                            'its a new spell level (i.e it has a different source form any existing spell levels)
                            NewObjects.Add(LevelObj)
                        Else
                            'if it exits already and is identical(apart from GUID) then we dont need to load it
                            If LevelObj.Compare(ExistingLevel, True) = True Then
                                LoadObjs.Remove(LevelObj.ObjectGUID)
                            Else
                                ChangedObjects.Add(LevelObj)
                                ExistingObjects.Add(LevelObj)
                                ExistingLevelLookupTable.Add(LevelObj.ObjectGUID, ExistingLevel)
                            End If
                        End If

                    End If
                Else
                    'if the source does not exist already and we are not adding it, then dont load the spell level
                    LoadObjs.Remove(LevelObj.ObjectGUID)
                End If
                ProgressBar.Increment()
            Next

            'display results
            ProgressBar.Hide()
            Dim LoadResult As New DatasetLoadResult

            LoadResult.Init(NewObjects, ChangedObjects, Conflicts, ExistingLevelLookupTable, LoadObjs)

            If NewObjects.Count + ChangedObjects.Count + Conflicts.Count = 0 Then
                General.ShowInfoDialog("This dataset contains no new or changed components.")
                UI.Enable()
                ProgressBar.Close()
                Exit Sub
            End If

            'check for out of date characters
            If Characters.Count > 0 Then
                'check for character version
                If (Version.IndexOf("RPGXplorer Version 1.03") = -1) AndAlso (Version.IndexOf("RPGXplorer Version 1.04") = -1) AndAlso (Version.IndexOf("RPGXplorer Version 1.05") = -1) AndAlso (Version.IndexOf("RPGXplorer Version 1.6") = -1) AndAlso (Version.IndexOf("RPGXplorer Version 1.7") = -1) AndAlso (Version.IndexOf("Version 1.8") = -1) AndAlso (Version.IndexOf("Version 1.9") = -1) AndAlso Version.IndexOf("Version 2.0") = -1 Then
                    General.ShowInfoDialog("This dataset contains incompatible characters or monsters created with a previous version of RPGXplorer.")
                    UI.Enable()
                    ProgressBar.Close()
                    Exit Sub
                Else
                    'resync XMLWorkshop
                    If Not (General.XMLWorkShop Is Nothing) Then
                        General.XMLWorkShop.ReInit()
                    End If
                End If
            End If

            If LoadResult.ShowDialog = DialogResult.OK Then
                General.MainExplorer.Undo.UndoRecord()
                Dim Overwrite As Boolean = LoadResult.OverwriteExisting
                Dim OverwriteKeys As ObjectHashtable = LoadResult.OverwriteKeys

                'save characters (delete existing first)
                ProgressBar.Show()
                ProgressBar.Caption = "Load Components - Removing Characters To Be Updated"
                ProgressBar.Reset()
                ProgressBar.Maximum = Characters.Count
                Application.DoEvents()
                For Each Character As Objects.ObjectData In Characters
                    Dim ExistingCharacter As New Objects.ObjectData
                    ExistingCharacter.Load(Character.ObjectGUID)
                    If Not ExistingCharacter.IsEmpty Then ExistingCharacter.DeleteFast()
                    ProgressBar.Increment()
                Next

                'if overwrite existing then remove existing components
                If OverwriteKeys.Count > 0 Then
                    ProgressBar.Caption = "Load Components - Removing Components To Be Overwritten"
                    ProgressBar.Reset()
                    ProgressBar.Maximum = OverwriteKeys.Count
                    Application.DoEvents()

                    For Each Obj As Objects.ObjectData In OverwriteKeys.Values
                        Dim ExistingObj As New Objects.ObjectData
                        ExistingObj.Load(Obj.ObjectGUID)

                        'specific behaviour for spells/powers/spelllevels/powerlevels
                        Select Case Obj.Type

                            Case Objects.SpellLevelType, Objects.PowerLevelType
                                Dim ExistingLevel As Objects.ObjectData = DirectCast(ExistingLevelLookupTable.Item(Obj.ObjectGUID), Objects.ObjectData)
                                If Not ExistingLevel.IsEmpty Then ExistingLevel.DeleteFastNoChildren()

                            Case Objects.SpellDefinitionType, Objects.PowerDefinitionType
                                ExistingObj.DeleteFastNoChildren()
                                For Each Descriptor As Objects.ObjectData In ExistingObj.ChildrenOfType(Objects.SpellDescriptorType)
                                    Descriptor.DeleteFastNoChildren()
                                Next

                            Case Objects.SpellSchoolType
                                ExistingObj.DeleteFastNoChildren()
                                For Each SacrificedSchool As Objects.ObjectData In ExistingObj.ChildrenOfType(Objects.SpellSchoolSacrificedType)
                                    SacrificedSchool.DeleteFastNoChildren()
                                Next

                            Case Else
                                ExistingObj.DeleteFast()

                        End Select
                        ProgressBar.Increment()

                    Next
                End If

                'remove components and their children from the loadset if they are not to be imported
                ProgressBar.Show()
                ProgressBar.Caption = "Load Components - Filtering Existing Components"
                ProgressBar.Reset()
                ProgressBar.Maximum = ExistingObjects.Count
                Application.DoEvents()
                For Each Obj As Objects.ObjectData In ExistingObjects
                    Dim Remove As Boolean = True

                    If OverwriteKeys.Contains(Obj.ObjectGUID) Then Remove = False

                    If Remove Then
                        LoadObjs.Remove(Obj.ObjectGUID)

                        Select Case Obj.Type
                            Case Objects.SpellDefinitionType, Objects.PowerDefinitionType
                                'spell/power specific behaviour
                                For Each Descriptor As Objects.ObjectData In LoadObjs.ChildrenOfType(Obj.ObjectGUID, Objects.SpellDescriptorType)
                                    LoadObjs.Remove(Descriptor.ObjectGUID)
                                Next

                            Case Objects.SpellSchoolType
                                For Each SacrificedSchool As Objects.ObjectData In LoadObjs.ChildrenOfType(Obj.ObjectGUID, Objects.SpellSchoolSacrificedType)
                                    LoadObjs.Remove(SacrificedSchool.ObjectGUID)
                                Next

                            Case Else
                                For Each Child As Objects.ObjectData In LoadObjs.ChildrenDeep(Obj.ObjectGUID)
                                    If Not NewObjects.Contains(Child.ObjectGUID) Then
                                        LoadObjs.Remove(Child.ObjectGUID)
                                    End If
                                Next
                        End Select

                    End If
                    ProgressBar.Increment()
                Next

                'save
                ProgressBar.Show()
                ProgressBar.Caption = "Load Components - Saving Imported Components"
                ProgressBar.Reset()
                ProgressBar.Maximum = 0
                Application.DoEvents()
                LoadObjs.Save(True)

                'data fixes
                ProgressBar.Show()
                ProgressBar.Caption = "Load Components - Validating Imported Components"
                ProgressBar.Reset()
                ProgressBar.Maximum = 0
                Application.DoEvents()

                'ac (base) fix
                DataIntegrity.ACBaseFix()

                'reset spell tags
                If SpellsLoaded Then DataIntegrity.SpellFix()

                'add spell-like and psi-like ability folders
                If Characters.Count > 0 Then DataIntegrity.CharacterFoldersFix()

                'reload the user lists
                If NewUserlistItem Then
                    UserLists.Load()
                    UserLists.UpdateLists(False)
                End If

                'rebuild fk lookup
                ProgressBar.Caption = "Load Components - Updating Foreign Keys"
                ProgressBar.Reset()
                ProgressBar.Maximum = LoadObjs.Count
                Application.DoEvents()
                XML.RebuildFKLookup()

                'update fk's
                For Each Obj As Objects.ObjectData In LoadObjs
                    Obj.UpdateReferringObjects()
                    Obj.UpdateForeignKeys()

                    ProgressBar.Increment()
                Next
                ProgressBar.Close()
                UI.Enable()
                General.ShowInfoDialog("Components Loaded.")
            Else
                ProgressBar.Close()
                UI.Enable()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'check to see if the object being loaded differs from its existing version
    Private Shared Function ExistingComponentDifferent(ByVal Obj As Objects.ObjectData, ByVal LoadObjs As Objects.ObjectDataCollection) As Boolean
        Try
            'check the primary object
            Dim Existing As New Objects.ObjectData

            Existing.Load(Obj.ObjectGUID)
            If Obj.Compare(Existing) = False Then
                Return True
            End If

            'get children and existing children
            Dim ExistingChildren As Objects.ObjectDataCollection = Existing.ChildrenDeep
            Dim Children As ArrayList = LoadObjs.ChildrenDeep(Obj.ObjectGUID)

            'if count of children differs then component is different
            If ExistingChildren.Count <> Children.Count Then
                Return True
            End If

            'same number of children - check each one to see if they are the same
            For Each Child As Objects.ObjectData In Children

                Existing = ExistingChildren.Item(Child.ObjectGUID)
                If Existing.IsEmpty Then
                    Return True
                Else
                    If Child.Compare(Existing) = False Then
                        Return True
                    End If
                End If
            Next

            Return False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the spell being loaded differs from its existing version
    Private Shared Function ExistingSpellDifferent(ByVal Obj As Objects.ObjectData, ByVal LoadObjs As Objects.ObjectDataCollection) As Boolean
        Try
            'check the primary object
            Dim Existing As New Objects.ObjectData

            Existing.Load(Obj.ObjectGUID)
            If Obj.SpellDefCompare(Existing) = False Then
                Return True
            End If

            'get children and existing children
            Dim ExistingChildren As Objects.ObjectDataCollection = Existing.ChildrenOfType(Objects.SpellDescriptorType)
            Dim Children As Objects.ObjectDataCollection = LoadObjs.ChildrenOfType(Obj.ObjectGUID, Objects.SpellDescriptorType)

            'if count of children differs then component is different
            If ExistingChildren.Count <> Children.Count Then
                Return True
            End If

            'same number of children - check each one to see if they are the same
            For Each Child As Objects.ObjectData In Children
                Existing = ExistingChildren.Item(Child.ObjectGUID)
                If Existing.IsEmpty Then
                    Return True
                Else
                    If Child.Compare(Existing) = False Then
                        Return True
                    End If
                End If
            Next

            Return False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the spell being loaded differs from its existing version
    Private Shared Function ExistingSpellSchoolDifferent(ByVal Obj As Objects.ObjectData, ByVal LoadObjs As Objects.ObjectDataCollection) As Boolean
        Try
            'check the primary object
            Dim Existing As New Objects.ObjectData

            Existing.Load(Obj.ObjectGUID)
            If Obj.Compare(Existing) = False Then
                Return True
            End If

            'get children and existing children
            Dim ExistingChildren As Objects.ObjectDataCollection = Existing.ChildrenOfType(Objects.SpellSchoolSacrificedType)
            Dim Children As Objects.ObjectDataCollection = LoadObjs.ChildrenOfType(Obj.ObjectGUID, Objects.SpellSchoolSacrificedType)

            'if count of children differs then component is different
            If ExistingChildren.Count <> Children.Count Then
                Return True
            End If

            'same number of children - check each one to see if they are the same
            For Each Child As Objects.ObjectData In Children
                Existing = ExistingChildren.Item(Child.ObjectGUID)
                If Existing.IsEmpty Then
                    Return True
                Else
                    If Child.Compare(Existing) = False Then
                        Return True
                    End If
                End If
            Next

            Return False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check if a spell/power source object exists in the database - SIDE EFFECT updates object to point to new source
    Private Shared Function SourceExists(ByVal LevelObject As Objects.ObjectData, ByVal Element As String) As Boolean
        Try

            'if the objects exists then return true
            Dim Source As Objects.ObjectData = LevelObject.GetFKObject(Element)
            If Not Source.IsEmpty Then Return True

            'otherwise try to match the name and type
            Dim XpathString As String
            XpathString = "/RPGXplorerDatabase/RPGXplorerObject[Name=""" & LevelObject.Element(Element) & """]"

            Source = Objects.GetObjectByXPath(LevelObject.GetFKGuid(Element).Database, XpathString)

            If Not Source.IsEmpty Then
                'if its a class - make sure its a spellcaster
                If Element = "Class" Then

                    Select Case LevelObject.Type

                        Case Objects.SpellLevelType
                            If Source.Element("CasterAbility") = "Yes" OrElse (Source.Element("CasterAbility") = "Prestige Advancement" And Source.Element("PrestigeSpellType") <> "") Then
                                LevelObject.SetFKGuid(Element, Source.ObjectGUID)
                                Return True
                            End If

                        Case Objects.PowerLevelType
                            If Source.Element("CasterAbility") = "Psionic" OrElse (Source.Element("CasterAbility") = "Prestige Advancement" And Source.Element("AdvanceManifester") = "True") Then
                                LevelObject.SetFKGuid(Element, Source.ObjectGUID)
                                Return True
                            End If

                    End Select

                Else
                    LevelObject.SetFKGuid(Element, Source.ObjectGUID)
                    Return True
                End If
            End If

            Return False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Function

#End Region

#Region "Rule Pages"

    'based on the saved components construct a folder of related rule pages
    Private Shared Sub SaveRulePages(ByVal SaveObjects As Objects.ObjectDataCollection)
        Try
            'get the target folder
            Dim Fbd As New FolderBrowserDialog

            Fbd.RootFolder = Environment.SpecialFolder.MyComputer
            Fbd.Description = "Please select an empty folder to export the rule pages to."

            Dim TargetFolder As String = Fbd.SelectedPath

            Dim bFolderOk As Boolean = False
            While bFolderOk = False
                If Fbd.ShowDialog() = DialogResult.OK Then
                    Dim Folders As New ArrayList(IO.Directory.GetDirectories(TargetFolder))
                    Dim Files As New ArrayList(IO.Directory.GetFiles(TargetFolder))

                    If Folders.Count + Files.Count > 1 Then
                        General.ShowErrorDialog("Please select an empty folder. Click ok to continue.")
                    Else
                        bFolderOk = True
                    End If
                Else
                    bFolderOk = True
                End If
            End While

            If bFolderOk Then
                'copy all the rule pages
                For Each Obj As Objects.ObjectData In SaveObjects
                    If Obj.IsPrimaryType Then

                        If Obj.HTMLGUID.IsEmpty Then
                            Dim SourcePath As New RulePagePath(Obj.HTML)
                            Dim CopyPath As RulePagePath

                            If Obj.HTML.IndexOf(":") <> -1 Then
                                CopyPath = New RulePagePath(TargetFolder & "\" & Obj.HTML)
                            Else
                                CopyPath = New RulePagePath(TargetFolder & "\" & SourcePath.HelpRelativePath & SourcePath.Filename)
                            End If

                            'create the directory and copy the file, ignore errors
                            Try
                                IO.Directory.CreateDirectory(CopyPath.FolderPath)
                            Catch ex As Exception

                            End Try
                            Try
                                IO.File.Copy(SourcePath.FullPath, CopyPath.FullPath)
                            Catch ex As Exception

                            End Try
                        End If
                    End If
                Next

                General.ShowInfoDialog("Rule Pages exported successfully.")
            Else
                General.ShowInfoDialog("Rule Pages not exported.")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

