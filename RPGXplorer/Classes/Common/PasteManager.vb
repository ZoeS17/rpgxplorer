Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports System.Xml
Imports System.Collections.Specialized

Public Class PasteManager

    'this class is responsible for managing an object being moved or copied 

#Region "Member Variables"

    Private Shared PasteRules As New Hashtable(100)

#End Region

    'initialise
    Public Shared Sub Init()
        Dim XmlRdr As XmlTextReader
        Dim ObjType As String
        Dim RuleCount As Integer
        Dim Rules As New StringDictionary

        Try
            XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\PasteRules.xml")

            While XmlRdr.Read
                'get the paste rules for an object type
                Select Case XmlRdr.NodeType
                    Case XmlNodeType.Element
                        Select Case XmlRdr.Name
                            Case "PasteRules"
                                'new set of rules
                                ObjType = XmlRdr.GetAttribute("type")
                                RuleCount = CInt(XmlRdr.GetAttribute("rules"))
                                Rules = New StringDictionary
                                PasteRules.Add(ObjType, Rules)
                            Case "Target"
                                Rules.Add(XmlRdr.GetAttribute("name"), XmlRdr.GetAttribute("rule"))
                        End Select
                End Select
            End While

            XmlRdr.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'check to see if the target folder is acceptable for paste
    Private Shared Function CanPaste(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim Rules As StringDictionary
        Dim Rule As String

        Try
            If PasteRules.ContainsKey(Obj.Type) Then
                Rules = DirectCast(PasteRules(Obj.Type), StringDictionary)

                If Rules.ContainsKey(TargetFolder.Type) Then
                    Rule = CStr(Rules(TargetFolder.Type))
                    If Rule = "" Then
                        Return ""
                    Else
                        Return CheckRule(Obj, TargetFolder, Rule)
                    End If
                Else
                    Return General.PasteFailDefault
                End If
            Else
                Return General.PasteFailDefault
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the paste rule is met
    Private Shared Function CheckRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData, ByVal RuleName As String) As String
        Try
            'check the rule and return an error message if rule failed
            Select Case RuleName
                Case "BonusSpells"
                    Return BonusSpellsPasteRule(Obj, TargetFolder)
                Case "Condition"
                    Return ConditionPasteRule(Obj, TargetFolder)
                Case "DamageAddition"
                    Return DamageAdditionPasteRule(Obj, TargetFolder)
                Case "DamageReduction"
                    Return DamageReductionPasteRule(Obj, TargetFolder)
                Case "DamageResistance"
                    Return DamageResistancePasteRule(Obj, TargetFolder)
                Case "Feature"
                    Return FeaturePasteRule(Obj, TargetFolder)
                Case "Item"
                    Return ItemPasteRule(Obj, TargetFolder)
                Case "ModifierDefinition"
                    Return ModifierPasteRule(Obj, TargetFolder)
                Case "Money"
                    Return MoneyPasteRule(Obj, TargetFolder)
                Case "Precondition"
                    Return PreconditionRule(Obj, TargetFolder)
                Case "SpecificBonusFeat"
                    Return SpecificBonusFeatRule(Obj, TargetFolder)
                Case "SpellResistance"
                    Return SpellResistancePasteRule(Obj, TargetFolder)
                Case "Synergy"
                    Return SynergyPasteRule(Obj, TargetFolder)
                Case "SystemAbility"
                    Return SystemAbilityRule(Obj, TargetFolder)
                Case "SystemWeaponAbility"
                    Return SystemWeaponAbilityPasteRule(Obj, TargetFolder)
                Case "Unique"
                    Return UniqueRule(Obj, TargetFolder)
                Case "WeaponEmulation"
                    Return WeaponEmulationPasteRule(Obj, TargetFolder)
            End Select

            'return zero length string if all rules have been passed
            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if this object can be moved, return zero length string if ok otherwise the reason it cannot
    Private Shared Function CanMove(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            'check to see if the object can be deleted
            If Obj.Fixed Then Return General.PasteFailFixed.Replace("[name]", Obj.Name)

            'check to see if the target parent is acceptable
            CanMove = CanPaste(Obj, TargetFolder).Replace("[name]", Obj.Name)
            If CanMove = "" Then CanMove = CheckDatabase(Obj, TargetFolder).Replace("[name]", Obj.Name)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if this object can be copied, return zero length string if ok otherwise the reason it cannot
    Private Shared Function CanCopy(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            'can the object be copied
            If Obj.Fixed Then Return General.PasteFailFixed.Replace("[name]", Obj.Name)

            'check to see if the target parent is acceptable
            CanCopy = CanPaste(Obj, TargetFolder).Replace("[name]", Obj.Name)
            If CanCopy = "" Then CanCopy = CheckDatabase(Obj, TargetFolder).Replace("[name]", Obj.Name)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see that components are being moved or copied within the same database
    Private Shared Function CheckDatabase(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        If Obj.ParentGUID.Database = TargetFolder.ObjectGUID.Database Then
            Return ""
        Else
            If Obj.ParentGUID.Database = XML.DBTypes.Folders And TargetFolder.ObjectGUID.Database = XML.DBTypes.UserDocs Then
                Return ""
            Else
                Return General.PasteFailDatabase
            End If
        End If
    End Function

    'this function handles a request to move objects as a result of a cut and paste
    Public Shared Function MoveObjects(ByVal Objects As Objects.ObjectDataCollection, ByVal TargetFolder As Objects.ObjectData) As ArrayList
        Dim Obj As Objects.ObjectData
        Dim GuidsMoved As New ArrayList
        Dim FailureMessages As New ArrayList
        Dim FailureMessage As String
        Dim FailureDialog As New PasteFailuresForm
        Dim Enumerator As IEnumerator

        Dim CurrentParentCollection As New Objects.ObjectDataCollection

        Try
            'check to see if each object can be moved
            For Each Obj In Objects
                FailureMessage = CanMove(Obj, TargetFolder)
                If FailureMessage = "" Then
                    GuidsMoved.Add(Obj.ObjectGUID)
                Else
                    FailureMessages.Add(FailureMessage)
                End If
            Next

            'if there were failures, ask the use whether we should continue
            If FailureMessages.Count > 0 Then
                FailureDialog.Init(Objects.Count, FailureMessages)
                If FailureDialog.ShowDialog() = DialogResult.Cancel Then Return Nothing
            End If

            'proceed with the move
            General.MainExplorer.TreeView.BeginUpdate()
            Enumerator = GuidsMoved.GetEnumerator
            While Enumerator.MoveNext
                Obj = Objects.Item(DirectCast(Enumerator.Current, Objects.ObjectKey))
                If Not CurrentParentCollection.Contains(Obj.ObjectGUID) Then CurrentParentCollection.Add(Obj.Parent)
                Obj.ParentGUID = TargetFolder.ObjectGUID
                Obj.Save()

                'move the tree nodes
                Dim OldNode, NewNode, TargetNode As TreeNode
                OldNode = DirectCast(General.MainExplorer.TreeNodes(Obj.ObjectGUID), TreeNode)
                If Not OldNode Is Nothing Then
                    NewNode = DirectCast(OldNode.Clone, TreeNode)
                    NewNode.ForeColor = System.Drawing.Color.Black
                    TargetNode = CType(General.MainExplorer.TreeNodes(TargetFolder.ObjectGUID), TreeNode)
                    If Not TargetNode Is Nothing Then
                        OldNode.Remove()
                        General.MainExplorer.InsertNode(TargetNode, NewNode)
                        General.MainExplorer.TreeNodes.Item(Obj.ObjectGUID) = NewNode
                    End If
                End If
            End While

            General.MainExplorer.TreeView.EndUpdate()

            'updated windows
            For Each TempFolder As Objects.ObjectData In CurrentParentCollection
                WindowManager.SetDirty(TempFolder)
            Next
            WindowManager.SetDirty(TargetFolder)

            'return moved guids
            Return GuidsMoved

        Catch ex As Exception
            General.MainExplorer.TreeView.EndUpdate()
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'this function handles a request to copy objects as a result of a copy and paste
    Public Shared Function CopyObjects(ByVal Objs As Objects.ObjectDataCollection, ByVal TargetFolder As Objects.ObjectData) As ArrayList
        Dim Obj As Objects.ObjectData
        Dim Clones As Objects.ObjectDataCollection
        Dim GuidsMoved As New ArrayList
        Dim NewGuids As New ArrayList
        Dim FailureMessages As New ArrayList
        Dim FailureMessage As String
        Dim FailureDialog As New PasteFailuresForm
        Dim Enumerator As IEnumerator

        Dim KeyMap As New ObjectHashtable
        Dim AllClones As New Objects.ObjectDataCollection

        Try
            'check to see if each object can be copied
            For Each Obj In Objs
                FailureMessage = CanCopy(Obj, TargetFolder)
                If FailureMessage = "" Then
                    GuidsMoved.Add(Obj.ObjectGUID)
                Else
                    FailureMessages.Add(FailureMessage)
                End If
            Next

            'if there were failures, ask the use whether we should continue
            If FailureMessages.Count > 0 Then
                FailureDialog.Init(Objs.Count, FailureMessages)
                If FailureDialog.ShowDialog() = DialogResult.Cancel Then Return Nothing
            End If

            'proceed with the copy
            Enumerator = GuidsMoved.GetEnumerator
            General.MainExplorer.TreeView.BeginUpdate()
            While Enumerator.MoveNext
                Obj = Objs.Item(DirectCast(Enumerator.Current, Objects.ObjectKey))
                Dim Temp As Objects.ObjectDataCollection = Obj.CloneWithKeyMap(TargetFolder, KeyMap)
                Clones = New Objects.ObjectDataCollection

                'reset the HTML tag for each item, so that a default rule page is created.
                For Each Clone As Objects.ObjectData In Temp
                    Select Case clone.Type
                        Case Objects.RuleFolderPageType, Objects.RuleFolderType, Objects.RulePageType, Objects.RuleTableType
                            'do not reset HTML
                        Case Else
                            Clone.HTML = ""
                            Clone.Element("HTML") = ""
                    End Select
                    Clones.Add(Clone)
                Next

                'create new tree node where required
                Dim ExistingNode, NewNode, TargetNode As TreeNode
                Dim ObjectTag As Explorer.ObjectTagData

                ExistingNode = CType(General.MainExplorer.TreeNodes(Obj.ObjectGUID), TreeNode)
                If Not ExistingNode Is Nothing Then
                    NewNode = DirectCast(ExistingNode.Clone, TreeNode)
                    ObjectTag = DirectCast(ExistingNode.Tag, Explorer.ObjectTagData)
                    ObjectTag.Name = Clones.Item(0).Name
                    ObjectTag.ObjectGUID = DirectCast(KeyMap(Obj.ObjectGUID), Objects.ObjectKey)
                    NewNode.Tag = ObjectTag
                    TargetNode = CType(General.MainExplorer.TreeNodes(TargetFolder.ObjectGUID), TreeNode)
                    NewNode.Text = ObjectTag.Name
                    If Not TargetNode Is Nothing Then
                        General.MainExplorer.InsertNode(TargetNode, NewNode)
                        General.MainExplorer.TreeNodes.Item(ObjectTag.ObjectGUID) = NewNode
                    End If

                    'update its children
                    For Each TempNode As TreeNode In NewNode.Nodes
                        UpdateChildNode(TempNode, KeyMap)
                    Next

                End If

                AllClones.AddMany(Clones)
                NewGuids.Add(Clones.Item(0).ObjectGUID)
            End While

            General.MainExplorer.TreeView.EndUpdate()
            'update internal foreign keys
            For Each Clone As Objects.ObjectData In AllClones

                'check for feature progressions
                If clone.Type = Objects.FeatureDefinitionType Then
                    Dim ReplaceKey As Objects.ObjectKey = clone.GetFKGuid("Replaces")
                    If ReplaceKey.IsNotEmpty Then
                        'if its not internal - remove reference
                        If Not KeyMap.Contains(ReplaceKey) Then
                            clone.FKSetNull("Replaces")
                            clone.Element("Stacks") = ""
                        End If
                    End If
                End If

                'if this object has any foreign keys
                For Each Element As String In Clone.GetAllFKElements()
                    Dim FK As Objects.ObjectKey

                    'update the old FK with the new one
                    FK = clone.GetFKGuid(Element)
                    If KeyMap.Contains(FK) Then
                        Clone.SetFKGuid(Element, DirectCast(KeyMap.Item(FK), Objects.ObjectKey))
                    End If
                Next
            Next

            AllClones.Save()
            WindowManager.SetDirty(TargetFolder)
            Return NewGuids

        Catch ex As Exception
            General.MainExplorer.TreeView.EndUpdate()
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Public Shared Sub UpdateChildNode(ByVal Node As TreeNode, ByVal KeyMap As ObjectHashtable)
        Try
            If Not Node Is Nothing Then
                Dim Tag As Explorer.ObjectTagData = DirectCast(Node.Tag, Explorer.ObjectTagData)
                Tag.ObjectGUID = DirectCast(KeyMap(Tag.ObjectGUID), Objects.ObjectKey)
                Node.Tag = Tag
                General.MainExplorer.TreeNodes.Item(Tag.ObjectGUID) = Node

                'update its children
                For Each TempNode As TreeNode In Node.Nodes
                    UpdateChildNode(TempNode, KeyMap)
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Rule Methods"

    'check to see if the bonus spells can be added to a folder
    Public Shared Function BonusSpellsPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            For Each Existing As Objects.ObjectData In TargetFolder.ChildrenOfType(Objects.BonusSpellSlotsType)
                If Existing.Element("MagicType") = Obj.Element("MagicType") And Existing.ElementAsInteger("SpellLevel") = Obj.ElementAsInteger("SpellLevel") Then
                    Return General.PasteFailBonusSpells
                End If
            Next

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the condition can be added to a folder
    Public Shared Function ConditionPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            Select Case Obj.Parent.Type
                Case Objects.MagicAmmoDefinitionType
                    If TargetFolder.Type <> Objects.MagicAmmoDefinitionType Then Return General.PasteFailCondition
                Case Objects.SpecificWeaponDefinitionType
                    If TargetFolder.Type <> Objects.SpecificWeaponDefinitionType Then Return General.PasteFailCondition
                Case Objects.WeaponMagicAbilityDefinitionType
                    If TargetFolder.Type = Objects.WeaponMagicAbilityDefinitionType Then
                        If Obj.Parent.Element("WeaponType") <> TargetFolder.Element("WeaponType") Then
                            Return General.PasteFailCondition
                        End If
                    Else
                        Return General.PasteFailCondition
                    End If
                Case Objects.PsionicWeaponDefinitionType
                    If TargetFolder.Type <> Objects.PsionicWeaponDefinitionType Then Return General.PasteFailCondition
                Case Objects.PsionicWeaponAbilityDefinitionType
                    If TargetFolder.Type = Objects.PsionicWeaponAbilityDefinitionType Then
                        If Obj.Parent.Element("WeaponType") <> TargetFolder.Element("WeaponType") Then
                            Return General.PasteFailCondition
                        End If
                    Else
                        Return General.PasteFailCondition
                    End If
                Case Else
                    Return General.PasteFailDefault
            End Select

            'bane is only allowed once
            If Obj.Element("Condition") = Rules.Conditions.Bane Then
                For Each Condition As Objects.ObjectData In TargetFolder.ChildrenOfType(Objects.ConditionType)
                    If Condition.Element("Condition") = Rules.Conditions.Bane Then
                        Return General.PasteFailConditionBane
                    End If
                Next
            End If

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the damage addition can be added to a folder
    Public Shared Function DamageAdditionPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim ExistingObjs As Objects.ObjectDataCollection

        Try
            ExistingObjs = TargetFolder.ChildrenOfType(Objects.DamageAdditionType)

            'if folder is condition check parent is valid
            If TargetFolder.Type = Objects.ConditionType Then
                Select Case TargetFolder.Parent.Type
                    Case Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType
                        'ok
                    Case Else
                        Return General.PasteFailDefault
                End Select
            End If

            'For Each ExistingObj In ExistingObjs
            '    If ExistingObj.Element("DamageType") = Obj.Element("DamageType") Then Return General.PasteFailDamageAddition
            'Next

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the damage reduction can be added to a folder
    Public Shared Function DamageReductionPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim ExistingObjs As Objects.ObjectDataCollection

        Try
            ExistingObjs = TargetFolder.ChildrenOfType(Objects.DamageReductionType)

            If ExistingObjs.Count > 0 Then Return General.PasteFailUnique

            'if folder is condition check parent is valid
            If TargetFolder.Type = Objects.ConditionType Then TargetFolder = TargetFolder.Parent

            Select Case TargetFolder.Type
                Case Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType
                    Dim Armor As Objects.ObjectData

                    Armor = TargetFolder.GetFKObject("Armor")
                    If Armor.Type <> Objects.ArmorDefinitionType Then Return General.PasteFailDefault

                Case Objects.ArmorMagicAbilityDefinitionType, Objects.PsionicArmorAbilityDefinitionType
                    If TargetFolder.Element("ArmorType") <> "Armor" Then Return General.PasteFailDefault

                Case Else
                    Return General.PasteFailDefault
            End Select

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the damage resistance can be added to a folder
    Public Shared Function DamageResistancePasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim ExistingObj, Parent As Objects.ObjectData
        Dim ExistingObjs As Objects.ObjectDataCollection

        Try
            'if folder is condition check parent is valid
            If TargetFolder.Type = Objects.ConditionType Then
                Parent = TargetFolder.Parent
            Else
                Parent = TargetFolder
            End If

            Select Case Parent.Type
                Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType, Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType, Objects.ArmorMagicAbilityDefinitionType, Objects.PsionicArmorAbilityDefinitionType
                    'ok
                Case Objects.FeatDefinitionType, Objects.FeatureDefinitionType
                    'ok
                Case Objects.ClassLevelType, Objects.RaceType
                    'ok
                Case Objects.RingDefinitionType, Objects.RodDefinitionType, Objects.StaffDefinitionType, Objects.PsionicPsicrownDefinitionType
                    'ok
                Case Objects.WeaponMagicAbilityDefinitionType, Objects.PsionicWeaponAbilityDefinitionType
                    'check to see if the ability is not for ammo or thrown
                    Select Case Parent.Element("WeaponType")
                        Case "Melee Weapons Only", "Ranged Weapons Only", "Thrown Weapons Only"
                            'ok
                        Case Else
                            Return General.PasteFailDefault
                    End Select

                Case Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType



                Case Else
                    Return General.PasteFailDefault
            End Select

            ExistingObjs = TargetFolder.ChildrenOfType(Objects.DamageResistanceType)
            For Each ExistingObj In ExistingObjs
                If ExistingObj.Element("DamageType") = Obj.Element("DamageType") Then Return General.PasteFailDamageResistance
            Next

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the feature can be added to a folder
    Public Shared Function FeaturePasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim ExistingObj As Objects.ObjectData
        Dim ExistingObjs As Objects.ObjectDataCollection

        Try
            ExistingObjs = TargetFolder.ChildrenOfType(Objects.FeatureType)

            For Each ExistingObj In ExistingObjs
                If ExistingObj.GetFKGuid("Feature").Equals(Obj.GetFKGuid("Feature")) Then Return General.PasteFailFeature
            Next

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if item is being pasted into container
    Public Shared Function ItemPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim IsContainer As Boolean

        If TargetFolder.Element("IsContainer") = "Yes" Then
            IsContainer = True
        Else
            Dim Container As Objects.ObjectData = TargetFolder.GetFKObject("Item")
            If Container.Element("IsContainer") = "Yes" Then IsContainer = True
        End If

        If IsContainer Then
            If Obj.ObjectGUID.Equals(TargetFolder.ObjectGUID) Then Return General.PasteFailContainer
            If Obj.ObjectGUID.Equals(TargetFolder.ParentGUID) Then Return General.PasteFailContainerParent
        Else
            Return General.PasteFailDefault
        End If

        Return ""
    End Function

    'check to see if the modifier can be added to a folder
    Public Shared Function ModifierPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim ExistingModifier, Parent As Objects.ObjectData
        Dim Modifiers, SystemObjects As Objects.ObjectDataCollection

        Try
            Modifiers = TargetFolder.ChildrenOfType(Objects.ModifierType)

            For Each ExistingModifier In Modifiers
                If ExistingModifier.GetFKGuid("SystemElement").Equals(Obj.GetFKGuid("SystemElement")) Then
                    If ExistingModifier.Element("FocusObject") = "" Then
                        Return General.PasteFailModifier
                    Else
                        If ExistingModifier.GetFKGuid("FocusObject").Equals(Obj.GetFKGuid("FocusObject")) Then Return General.PasteFailModifier
                    End If
                End If
            Next

            If TargetFolder.Type = Objects.ConditionType Then
                Parent = TargetFolder.Parent
            Else
                Parent = TargetFolder
            End If

            SystemObjects = CommonLogic.AppropriateModifiers(Parent)
            If Not SystemObjects.Contains(Obj.GetFKGuid("SystemElement")) Then Return General.PasteFailModifierInappropriate

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if money is being pasted into container
    Public Shared Function MoneyPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim Container As Objects.ObjectData

        If TargetFolder.Element("IsContainer") = "Yes" Then
            Return ""
        End If

        Container = TargetFolder.GetFKObject("Item")
        If Container.Element("IsContainer") = "Yes" Then Return "" Else Return General.PasteFailDefault
    End Function

    'check to see if the folder already contains this precondition
    Public Shared Function PreconditionRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            If TargetFolder.ChildrenOfType(Objects.SystemPreconditionType).ContainsFK("SystemPreconditionDefinition", Obj.GetFKGuid("SystemPreconditionDefinition")) Then
                Return General.PasteFailPrecondition
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the synergy can be added to a folder
    Public Shared Function SynergyPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim ExistingSynergy As Objects.ObjectData
        Dim Synergys As Objects.ObjectDataCollection

        Try
            Synergys = TargetFolder.ChildrenOfType(Objects.SkillSynergyType)

            For Each ExistingSynergy In Synergys
                If ExistingSynergy.GetFKGuid("SystemElement").Equals(Obj.GetFKGuid("SystemElement")) Then
                    If ExistingSynergy.Element("Focus") = "" Then
                        Return General.PasteFailSynergy
                    Else
                        If ExistingSynergy.GetFKGuid("Focus").Equals(Obj.GetFKGuid("Focus")) Then Return General.PasteFailSynergy
                    End If
                End If
            Next

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the spell resistance can be added to a folder
    Public Shared Function SpellResistancePasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim Parent As Objects.ObjectData
        Dim ExistingObjs As Objects.ObjectDataCollection

        Try
            'if folder is condition check parent is valid
            If TargetFolder.Type = Objects.ConditionType Then
                Parent = TargetFolder.Parent
            Else
                Parent = TargetFolder
            End If

            Select Case Parent.Type
                Case Objects.SpecificWeaponDefinitionType, Objects.SpecificArmorDefinitionType, Objects.ArmorMagicAbilityDefinitionType, Objects.PsionicWeaponDefinitionType, Objects.PsionicArmorDefinitionType, Objects.PsionicArmorAbilityDefinitionType
                    'ok
                Case Objects.WeaponMagicAbilityDefinitionType, Objects.PsionicWeaponAbilityDefinitionType
                    'check to see if the ability is not for ammo or thrown
                    Select Case Parent.Element("WeaponType")
                        Case "Melee Weapons Only", "Ranged Weapons Only", "Thrown Weapons Only"
                            'ok
                        Case Else
                            Return General.PasteFailDefault
                    End Select
                Case Else
                    Return General.PasteFailDefault
            End Select

            ExistingObjs = TargetFolder.ChildrenOfType(Objects.SpellResistanceType)
            If ExistingObjs.Count > 0 Then Return General.PasteFailUnique

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if there are any specific bonus feats that are the same
    Public Shared Function SpecificBonusFeatRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Dim OK As Boolean = True
        Try
            For Each BonusFeat As Objects.ObjectData In TargetFolder.ChildrenOfType(Objects.SpecificBonusFeatType)
                If BonusFeat.GetFKGuid("Feat").Equals(Obj.GetFKGuid("Feat")) Then
                    If Obj.Element("Focus") = "" Then

                        'get the FeatDef
                        Dim FeatDef As Objects.ObjectData = BonusFeat.GetFKObject("Feat")
                        If FeatDef.Element("Stacks") <> "Yes" Then
                            OK = False
                        End If

                    ElseIf Obj.GetFKGuid("Focus").Equals(BonusFeat.GetFKGuid("Focus")) Then
                        OK = False
                    End If
                End If
            Next

            If OK Then Return "" Else Return General.PasteFailSpecificBonusFeat

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the folder already contains this system ability
    Public Shared Function SystemAbilityRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            If TargetFolder.ChildrenOfType(Objects.SystemAbilityType).ContainsFK("SystemAbilityDefinition", Obj.GetFKGuid("SystemAbilityDefinition")) Then
                Return General.PasteFailSysAbility
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the folder already contains this system weapon ability
    Public Shared Function SystemWeaponAbilityPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            If TargetFolder.ChildrenOfType(Objects.SystemWeaponAbilityType).ContainsFK("SystemWeaponAbilityDefinition", Obj.GetFKGuid("SystemWeaponAbilityDefinition")) Then
                Return General.PasteFailSysAbility
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if there are any other objects of this type in the folder
    Public Shared Function UniqueRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            If TargetFolder.ChildrenOfType(Obj.Type).Count > 0 Then
                Return General.PasteFailUnique
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'check to see if the folder already contains this weapon emulation
    Public Shared Function WeaponEmulationPasteRule(ByVal Obj As Objects.ObjectData, ByVal TargetFolder As Objects.ObjectData) As String
        Try
            If TargetFolder.ChildrenOfType(Objects.WeaponEmulationType).ContainsFK("WeaponDefinition", Obj.GetFKGuid("WeaponDefinition")) Then
                Return General.PasteFailWeaponEmulation
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

End Class
