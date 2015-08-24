Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Objects
Imports RPGXplorer.XML

Imports System.Xml
Imports System.Windows.Forms
Imports System.Guid
Imports System.IO
Imports System.IO.Directory
Imports System.Drawing
Imports System.Collections.Specialized
Imports System.Data.OleDb
Imports System.Threading

Imports DevExpress.XtraBars
'Imports DevExpress.XtraNavBar

Public Class Explorer

#Region "Constants and Enumerations"
    'image list constants
    Private Const cImageFilename_SystemFolder As String = "Folder.bmp"

    'ObjectKey constants
    Private Const cGUID_SystemFolder As String = "00000000-0000-0000-0000-000000000001"

    Public Enum Focus
        NotSet
        ListView
        TreeView
    End Enum

    Public Enum PanelType
        NotSet
        AssetsPanel
        BasicListView
        Character
        Inventory
        Modifiers
        Features
        Skills
        Spells
        SpellList
        SpellCaster
        SpellSlots
        Weapons
        Feats
        PowerList
        Manifester
        Memorized
    End Enum

#End Region

#Region "Member Variable Declarations"

    Private _IsLoading As Boolean
    Private _Form As MainWindow
    Private _ListView As ListView
    Private _TreeView As TreeView
    Private _Toolbar As ToolBar
    Private _Browser As WebBrowser
    Private _Focus As Focus = Focus.NotSet
    Private _Clipboard As New Clipboard
    Private _ListViewManager As ListViewManager
    Private _FilterManager As New FilterManager
    Public OGLFolder, CharactersFolder, MonstersFolder As TreeNode

    'flags to fix clicking noises
    Public SuspendBrowser As Boolean = False

    'misc
    Public SuspendEvents As Boolean
    Public TreeNodes As ExplorerTreeNodeHashtable

    Private Const TreeNodeSize As Integer = 10000

    'tabbed mdi
    'Public NewWindow As Boolean

    'undo
    Public Undo As New Undo(General.UndoSteps)
    Public SkipUndo As Boolean = False

    Private _ProgressBar As ProgressBar

#End Region

#Region "Properties"

    'is loading
    Public ReadOnly Property IsLoading() As Boolean
        Get
            Return _IsLoading
        End Get
    End Property

    'set the current focus of the explorer - required by currently selected object
    Public Property CurrentFocus() As Focus
        Get
            Return _Focus
        End Get
        Set(ByVal Focus As Focus)
            _Focus = Focus
        End Set
    End Property

    'the current panel
    Public ReadOnly Property CurrentPanel() As IPanel
        Get
            Return DirectCast(WindowManager.CurrentWindow.MyPanel, IPanel)
        End Get
    End Property

    'the current panel type
    Public ReadOnly Property CurrentPanelType() As PanelType
        Get
            If WindowManager.CurrentWindow IsNot Nothing Then
                Return WindowManager.CurrentWindow.MyPanelType
            Else
                Return PanelType.NotSet
            End If
        End Get
    End Property

    'the number of objects currently selected in the control that has the focus
    Public ReadOnly Property SelectedObjectCount() As Integer
        Get
            Select Case _Focus
                Case Focus.ListView
                    If _ListView Is Nothing Then
                        Return 0 'hack related to shortcut keys/focus issue
                    Else
                        Return _ListView.SelectedItems.Count
                    End If
                Case Focus.NotSet
                    Return 0
                Case Focus.TreeView
                    Return 1
            End Select
        End Get
    End Property

    'returns the currently selected object regardless of focus
    Public ReadOnly Property SelectedObject() As Objects.ObjectData
        Get
            Dim SelectedObjects As Objects.ObjectDataCollection = Me.CurrentSelectedObjects

            If SelectedObjects.Count = 0 Then
                Return Me.ObjectSelectedInTree
            Else
                Return SelectedObjects.Item(0)
            End If
        End Get
    End Property

    'returns a collection of the objects selected in the control that has the focus.
    Public ReadOnly Property CurrentSelectedObjects() As Objects.ObjectDataCollection
        Get
            Dim SelectedObjects As New ObjectDataCollection
            Dim Obj As New Objects.ObjectData
            Dim Item As ListViewItem

            Select Case _Focus
                Case Focus.ListView

                    If _ListView Is Nothing Then Return SelectedObjects 'hack related to shortcut keys/focus issue

                    If _ListView.SelectedItems.Count = 0 Then
                        Return SelectedObjects
                    Else
                        For Each Item In _ListView.SelectedItems
                            If TypeOf Item.Tag Is RPGXplorer.Objects.ObjectKey Then
                                Obj.Load(DirectCast(Item.Tag, ObjectKey))
                                SelectedObjects.Add(Obj)
                            ElseIf TypeOf Item.Tag Is Objects.ObjectData Then
                                Obj = DirectCast(Item.Tag, Objects.ObjectData)
                                SelectedObjects.Add(Obj)
                            End If
                        Next
                    End If
                Case Focus.TreeView

                    If Not _TreeView.SelectedNode Is Nothing Then
                        Obj.Load(DirectCast(_TreeView.SelectedNode.Tag, ObjectTagData).ObjectGUID)
                        SelectedObjects.Add(Obj)
                    End If

            End Select

            Return SelectedObjects
        End Get
    End Property

    'return the object data for the currently selected tree node
    Public ReadOnly Property ObjectSelectedInTree() As ObjectData
        Get
            If _TreeView.SelectedNode Is Nothing Then Return Nothing

            Dim Obj As New Objects.ObjectData
            Obj.Load(DirectCast(_TreeView.SelectedNode.Tag, ObjectTagData).ObjectGUID)

            Return Obj
        End Get
    End Property

    'the form this explorer is attached to
    Public ReadOnly Property Form() As MainWindow
        Get
            Return _Form
        End Get
    End Property

    'the current list view
    Public ReadOnly Property ListView() As ListView
        Get
            Return _ListView
        End Get
    End Property

    'the current list view columns manager
    Public ReadOnly Property ListViewManager() As ListViewManager
        Get
            Return _ListViewManager
        End Get
    End Property

    'the main filter manager
    Public ReadOnly Property FilterManager() As FilterManager
        Get
            Return _FilterManager
        End Get
    End Property

    'the current tree view
    Public ReadOnly Property TreeView() As TreeView
        Get
            Return _TreeView
        End Get
    End Property

    'the browser 
    Public ReadOnly Property Browser() As WebBrowser
        Get
            Return _Browser
        End Get
    End Property

    'the clipboard for this explorer
    Public ReadOnly Property Clipboard() As Clipboard
        Get
            Return _Clipboard
        End Get
    End Property

    'property for the listview view mode
    Public Property ListViewMode() As View
        Get
            If Not _ListView Is Nothing Then
                Return _ListView.View
            End If
        End Get
        Set(ByVal Value As View)
            If Not _ListView Is Nothing Then
                _ListView.View = Value
            End If
        End Set
    End Property

#End Region

#Region "Constructor and Initialisation"

    'constructor
    Public Sub New(ByRef TreeView As TreeView, ByRef Form As MainWindow, ByRef Browser As WebBrowser, ByVal Progressbar As ProgressBar)

        'initialise the tree view
        _TreeView = TreeView
        _TreeView.HotTracking = False
        _TreeView.HideSelection = False
        _TreeView.ShowLines = True
        _TreeView.ShowPlusMinus = True
        _TreeView.ShowRootLines = True
        _TreeView.Sorted = False
        _TreeView.ImageList = Images.SmallImages
        _ProgressBar = Progressbar

        'initialise browser components
        _Browser = Browser

        'bind the form
        _Form = Form
    End Sub

    'initialise the explorer view
    Public Sub InitExplorer()

        _IsLoading = True
        General.SetWaitCursor()
        Application.DoEvents()

        'do any folder data patches
        If PsionicPatch Then DataIntegrity.PsionicPatch()
        If MaterialPatch Then DataIntegrity.MaterialsPatch()
        If CharacterFolderPatch Then DataIntegrity.CharacterFoldersFix()

        'load the tree - unset progressbar after load as it is no longer required
        _ProgressBar.Caption = "RPGXplorer - Loading Tree"
        LoadTreeFromXml(Objects.ObjectKey.Empty)
        '_ProgressBar = Nothing

        'restore display
        WindowManager.RestoreSavedDisplay(_ProgressBar)

        'run required fixes
        If AnimalFix Then DataIntegrity.AnimalFix()
        If SpellFix Then DataIntegrity.SpellFix()
        If DuplicateSystemComponentsFix Then DataIntegrity.DuplicateSystemComponentFix()
        If DuplicateSkillGroupsFix Then DataIntegrity.DuplicateSkillGroupComponentFix()
        If ACBaseFix Then DataIntegrity.ACBaseFix()

        General.SetNormalCursor()
        _IsLoading = False

        'Uncomment me to check integrity on startup
        'Commands.FixIntegrity()

    End Sub

    'load the tree
    Public Function LoadTree(ByVal Remember As Objects.ObjectKey) As TreeNode
        Try
            'vars
            Dim Node As TreeNode
            TreeNodes = New ExplorerTreeNodeHashtable

            'create the root levels nodes
            If Not _ProgressBar Is Nothing Then _ProgressBar.Caption = "RPGXplorer - Loading Tree"
            Dim RootFolders As Objects.ObjectDataCollection = GetRootFolders()
            For Each RootFolder As Objects.ObjectData In RootFolders
                Node = NodeFromObject(RootFolder)
                If RootFolder.ObjectGUID.Equals(References.CharactersFolderKey) Then
                    CharactersFolder = Node
                    TreeNodes.Add(References.CharactersFolderKey, CharactersFolder)
                ElseIf RootFolder.ObjectGUID.Equals(References.OGLFolderKey) Then
                    OGLFolder = Node
                    TreeNodes.Add(References.OGLFolderKey, OGLFolder)
                ElseIf RootFolder.ObjectGUID.Equals(References.MonstersFolderKey) Then
                    MonstersFolder = Node
                    TreeNodes.Add(References.MonstersFolderKey, MonstersFolder)
                End If
            Next

            _TreeView.Nodes.Add(CharactersFolder)
            _TreeView.Nodes.Add(MonstersFolder)
            _TreeView.Nodes.Add(OGLFolder)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '8

            Dim OGLFolderObjects As New Objects.ObjectDataCollection

            'ogl subfolders
            OGLFolderObjects = Objects.GetObjectsByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type!='" & Objects.RulesRootFolderType & "' and Type!='RPGXplorer Configuration' and Type!='User Folder']")
            OGLFolderObjects.Remove(References.CharactersFolderKey)
            OGLFolderObjects.Remove(References.OGLFolderKey)
            OGLFolderObjects.Remove(References.MonstersFolderKey)

            'magic items, monsters and psionics folders
            Dim MagicItemsFolder, MonsterRulesFolder, PsionicItemsFolder As TreeNode
            MagicItemsFolder = NodeFromObject(OGLFolderObjects.Item(References.MagicItemsFolderKey))
            MonsterRulesFolder = NodeFromObject(OGLFolderObjects.Item(References.MonstersRulesFolderKey))
            PsionicItemsFolder = NodeFromObject(OGLFolderObjects.Item(References.PsionicItemsFolderKey))
            TreeNodes.Add(References.MagicItemsFolderKey, MagicItemsFolder)
            TreeNodes.Add(References.MonstersRulesFolderKey, MonsterRulesFolder)
            TreeNodes.Add(References.PsionicItemsFolderKey, PsionicItemsFolder)

            'remaining ogl folders
            Dim OGLFolders As ArrayList = OGLFolderObjects.ToArrayListSorted

            For Each OGLFolder As Objects.ObjectData In OGLFolders
                If Not TreeNodes.ContainsKey(OGLFolder.ObjectGUID) Then
                    Node = NodeFromObject(OGLFolder)
                    TreeNodes.Add(OGLFolder.ObjectGUID, Node)
                Else
                    Node = DirectCast(TreeNodes.Item(OGLFolder.ObjectGUID), TreeNode)
                End If
                DirectCast(TreeNodes.Item(OGLFolder.ParentGUID), TreeNode).Nodes.Add(Node)
            Next

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '9

            'characters
            For Each Character As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Characters, Objects.CharacterType).ToArrayListSorted
                Node = NodeFromObject(Character)
                CharactersFolder.Nodes.Add(Node)
                TreeNodes.Add(Character.ObjectGUID, Node)
            Next

            'character folders
            AddPageObjects(Objects.GetObjectsByXPath(XML.DBTypes.Characters, "/RPGXplorerDatabase/RPGXplorerObject[Type[contains(.,'Folder')]]").ToArrayList)

            'monsters
            For Each Monster As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Monsters, Objects.MonsterType).ToArrayListSorted
                Node = NodeFromObject(Monster)
                MonstersFolder.Nodes.Add(Node)
                TreeNodes.Add(Monster.ObjectGUID, Node)
            Next

            'monster folders
            AddPageObjects(Objects.GetObjectsByXPath(XML.DBTypes.Monsters, "/RPGXplorerDatabase/RPGXplorerObject[Type[contains(.,'Folder')]]").ToArrayList)

            Dim ParentFolder As TreeNode

            'classes
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '10
            ParentFolder = DirectCast(TreeNodes.Item(References.ClassesFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'class levels folders
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '11
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassLevelsFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'class spells known
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '12
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassLevelsSpellsKnownFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'class spells per day
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '13
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassLevelsSpellsPerDayFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'class power progression
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '14
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassLevelsPowerProgressionFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'class spell list
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '15
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.SpellListFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'class power list
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '16
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.PowerListFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'monster classes
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '17
            ParentFolder = DirectCast(TreeNodes.Item(References.MonsterClassesFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MonsterClasses, Objects.MonsterClassType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'monster class levels folder
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '18
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MonsterClasses, Objects.MonsterClassLevelsFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'domains
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '19
            ParentFolder = DirectCast(TreeNodes.Item(References.DomainsFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.DomainDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'psionic domains
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '20
            ParentFolder = DirectCast(TreeNodes.Item(References.PsionicSpecializationsFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'domain spell list folders
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '21
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.SpellListFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'domain power list folders
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '22
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.PowerListFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'spell categories
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '23
            ParentFolder = DirectCast(TreeNodes.Item(References.SpellCategoryFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellCategoryDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'spell category spell lists
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '24
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellListFolderType)
                Node = NodeFromObject(Folder)
                DirectCast(TreeNodes.Item(Folder.ParentGUID), TreeNode).Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'weapon magic abilities
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '25
            ParentFolder = DirectCast(TreeNodes.Item(References.WeaponMagicAbilitiesFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.WeaponMagicAbilities, Objects.WeaponMagicAbilityDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'magic weapons
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '26
            ParentFolder = DirectCast(TreeNodes.Item(References.SpecificMagicWeaponFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.SpecificWeaponDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'magic ammo
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '27
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.MagicAmmoDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'psionic weapon abilities
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '28
            ParentFolder = DirectCast(TreeNodes.Item(References.PsionicWeaponAbilitiesFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.WeaponMagicAbilities, Objects.PsionicWeaponAbilityDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'psionic weapons
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '29
            ParentFolder = DirectCast(TreeNodes.Item(References.PsionicWeaponsFolderKey), TreeNode)
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.PsionicWeaponDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            'psionic ammo
            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '30
            For Each Folder As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.PsionicAmmoDefinitionType).ToArrayListSorted
                Node = NodeFromObject(Folder)
                ParentFolder.Nodes.Add(Node)
                TreeNodes.Add(Folder.ObjectGUID, Node)
            Next

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '31          

            'item containers 
            Dim Items As ArrayList = Objects.GetAllObjectsOfType(XML.DBTypes.Characters, Objects.ItemType).ToArrayList
            Items.AddRange(Objects.GetAllObjectsOfType(XML.DBTypes.Monsters, Objects.ItemType).ToArrayList)
            Dim ItemContainers As New ArrayList
            For Each Item As Objects.ObjectData In Items
                If Item.ShowInTree Then ItemContainers.Add(Item)
            Next

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '32

            AddPageObjects(ItemContainers)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '33

            'armor and shields
            ParentFolder = DirectCast(TreeNodes.Item(References.ArmorAndShieldsFolderKey), TreeNode)
            Dim ArmorAndShields As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(XML.DBTypes.ArmorAndShields, Objects.ArmorDefinitionType)
            ArmorAndShields.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.ArmorAndShields, Objects.ShieldDefinitionType))
            Dim Nodes As New List(Of TreeNode)
            For Each Obj As Objects.ObjectData In ArmorAndShields.ToArrayListSorted
                Node = NodeFromObject(Obj)
                Nodes.Add(Node)
                TreeNodes.Add(Obj.ObjectGUID, Node)
            Next
            ParentFolder.Nodes.AddRange(Nodes.ToArray)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '34

            'armor magic abilities
            AddPageObjects(References.ArmorMagicAbilitiesFolderKey, XML.DBTypes.ArmorMagicAbilities, Objects.ArmorMagicAbilityDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '35

            'artifacts
            AddPageObjects(References.ArtifactFolderKey, XML.DBTypes.Artifacts, Objects.ArtifactDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '36

            'feats
            AddPageObjects(References.FeatsFolderKey, XML.DBTypes.Feats, Objects.FeatDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '37

            'features
            AddPageObjects(References.FeaturesFolderKey, XML.DBTypes.Features, Objects.FeatureDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '38

            'item defs
            AddPageObjects(References.ItemsFolderKey, XML.DBTypes.Items, Objects.ItemDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '39

            'magic armor
            AddPageObjects(References.SpecificMagicArmorFolderKey, XML.DBTypes.MagicArmor, Objects.SpecificArmorDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '40

            'magic weapon conditions
            AddPageObjects(Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.ConditionType).ToArrayList)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '41

            'natural weapon definitions
            AddPageObjects(References.NaturalWeaponsFolderKey, XML.DBTypes.Weapons, Objects.NaturalWeaponDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '42

            'races
            AddPageObjects(References.RaceFolderKey, XML.DBTypes.Races, Objects.RaceType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '43

            'monster races
            AddPageObjects(References.MonsterRacesFolderKey, XML.DBTypes.MonsterRaces, Objects.MonsterRaceDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '44

            'rings
            AddPageObjects(References.RingFolderKey, XML.DBTypes.Rings, Objects.RingDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '45

            'rods
            AddPageObjects(References.RodsFolderKey, XML.DBTypes.Rods, Objects.RodDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '46

            'scrolls
            AddPageObjects(References.ScrollsFolderKey, XML.DBTypes.Scrolls, Objects.ScrollDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '47

            'skills
            AddPageObjects(References.SkillsFolderKey, XML.DBTypes.Skills, Objects.SkillDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '48

            'spell schools
            AddPageObjects(References.SpellSchoolsFolderKey, XML.DBTypes.SpellSchools, Objects.SpellSchoolType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '49

            'staffs
            AddPageObjects(References.StaffsFolderKey, XML.DBTypes.Staffs, Objects.StaffDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '50

            'monster subtype
            AddPageObjects(References.SubtypesFolderKey, XML.DBTypes.Subtypes, Objects.SubtypeDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '51

            'weapon magic ability conditions
            AddPageObjects(Objects.GetAllObjectsOfType(XML.DBTypes.WeaponMagicAbilities, Objects.ConditionType).ToArrayList)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '52

            'weapons and ammo
            ParentFolder = DirectCast(TreeNodes.Item(References.WeaponsFolderKey), TreeNode)
            Dim WeaponsAndAmmo As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(XML.DBTypes.Weapons, Objects.AmmoDefinitionType)
            WeaponsAndAmmo.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Weapons, Objects.WeaponDefinitionType))
            Nodes = New List(Of TreeNode)
            For Each Obj As Objects.ObjectData In WeaponsAndAmmo.ToArrayListSorted
                Node = NodeFromObject(Obj)
                Nodes.Add(Node)
                TreeNodes.Add(Obj.ObjectGUID, Node)
            Next
            ParentFolder.Nodes.AddRange(Nodes.ToArray)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '53

            'wondrous items
            AddPageObjects(References.WondrousItemsFolderKey, XML.DBTypes.WondrousItems, Objects.WondrousDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '54

            'psionic armor abilities
            AddPageObjects(References.PsionicArmorAbilitiesFolderKey, XML.DBTypes.ArmorMagicAbilities, Objects.PsionicArmorAbilityDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '55

            'psionic disciplines
            AddPageObjects(References.PsionicDisciplinesFolderKey, XML.DBTypes.SpellSchools, Objects.PsionicDisciplineType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '56

            'psionic armor
            AddPageObjects(References.PsionicArmorFolderKey, XML.DBTypes.MagicArmor, Objects.PsionicArmorDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '57

            'universal items
            AddPageObjects(References.PsionicUniversalItemsFolderKey, XML.DBTypes.WondrousItems, Objects.UniversalItemDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '58

            'power stones
            AddPageObjects(References.PsionicPowerStonesFolderKey, XML.DBTypes.Scrolls, Objects.PsionicPowerStoneDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '59

            'psicrowns
            AddPageObjects(References.PsicrownsFolderKey, XML.DBTypes.Staffs, Objects.PsionicPsicrownDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '60

            'tattoos
            AddPageObjects(References.PsionicTattoosFolderKey, XML.DBTypes.PotionsAndOils, Objects.PsionicTattooDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '61

            'psionic artifacts
            AddPageObjects(References.PsionicArtifactsFolderKey, XML.DBTypes.Artifacts, Objects.PsionicArtifactDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '62

            'special materials
            AddPageObjects(References.SpecialMaterialsFolderKey, XML.DBTypes.Items, Objects.SpecialMaterialDefinitionType)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '63

            'class levels
            AddPageObjects(Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassLevelType).ToArrayList, False)

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment() '64

            'monster class levels
            AddPageObjects(Objects.GetAllObjectsOfType(XML.DBTypes.MonsterClasses, Objects.MonsterClassLevelType).ToArrayList, False)

            'update all windows with their node references
            WindowManager.RefreshTreeNodes()

            'expand root nodes
            CharactersFolder.Expand()
            OGLFolder.Expand()
            MonstersFolder.Expand()

            'get remembered node if any
            If Remember.IsNotEmpty AndAlso TreeNodes.ContainsKey(Remember) Then Return TreeNodes.Item(Remember) Else Return Nothing

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'add the specified page objects of this type to the folder
    Private Sub AddPageObjects(ByVal FolderKey As Objects.ObjectKey, ByVal DB As Integer, ByVal Type As String)
        Dim ParentFolder As TreeNode = DirectCast(TreeNodes.Item(FolderKey), TreeNode)
        Dim Nodes As New List(Of TreeNode)
        Dim Node As TreeNode
        For Each Obj As Objects.ObjectData In Objects.GetAllObjectsOfType(DB, Type).ToArrayListSorted
            Node = NodeFromObject(Obj)
            Nodes.Add(Node)
            TreeNodes.Add(Obj.ObjectGUID, Node)
        Next
        ParentFolder.Nodes.AddRange(Nodes.ToArray)
    End Sub

    'add the provided objects to the tree where the parent may be in the list
    Private Sub AddPageObjects(ByVal PageObjects As ArrayList, Optional ByVal Sort As Boolean = True)
        If Sort Then PageObjects.Sort()

        If PageObjects.Count > 0 Then
            Dim LeftToProcess As Integer = PageObjects.Count
            Dim Flags() As Boolean
            ReDim Flags(PageObjects.Count)
            Dim Node As TreeNode

            While LeftToProcess > 0
                For n As Integer = 0 To PageObjects.Count - 1
                    If Not Flags(n) Then
                        Dim ItemContainer As Objects.ObjectData = DirectCast(PageObjects(n), Objects.ObjectData)
                        If TreeNodes.ContainsKey(ItemContainer.ParentGUID) Then
                            Node = NodeFromObject(ItemContainer)
                            DirectCast(TreeNodes.Item(ItemContainer.ParentGUID), TreeNode).Nodes.Add(Node)
                            TreeNodes.Add(ItemContainer.ObjectGUID, Node)
                            LeftToProcess -= 1
                            Flags(n) = True
                        End If
                    End If
                Next
            End While
        End If
    End Sub

    'cached tree reload
    Public Function LoadTreeFromXml(ByVal Remember As Objects.ObjectKey) As TreeNode
        Try
            Dim XmlRdr As XmlTextReader

            XmlRdr = New XmlTextReader(General.BasePath & "XML\TreeView.xml")
            XmlRdr.WhitespaceHandling = WhitespaceHandling.None

            'optional mechanism to hold onto a selected node reference
            Dim NodeStack As New Stack
            Dim CurrentNode As TreeNode = Nothing
            Dim ParentNode As TreeNode = Nothing

            TreeNodes = New ExplorerTreeNodeHashtable

            While XmlRdr.Read
                Select Case XmlRdr.NodeType
                    Case XmlNodeType.Element
                        Select Case XmlRdr.Name
                            Case "RPGXplorerConfig"
                                'ignore
                            Case "TreeNode"
                                If Not CurrentNode Is Nothing Then
                                    ParentNode = CurrentNode
                                    NodeStack.Push(ParentNode)
                                End If
                                CurrentNode = New TreeNode
                            Case "Name"
                                CurrentNode.Text = XmlRdr.ReadString
                                Dim TempTag As New ObjectTagData
                                'TempTag = DirectCast(CurrentNode.Tag, ObjectTagData)
                                TempTag.Name = CurrentNode.Text
                                CurrentNode.Tag = TempTag
                            Case "ObjectGuid"
                                Dim TempTag As ObjectTagData
                                TempTag = DirectCast(CurrentNode.Tag, ObjectTagData)
                                TempTag.ObjectGUID = New Objects.ObjectKey(XmlRdr.ReadString)
                                CurrentNode.Tag = TempTag
                            Case "Type"
                                Dim TempTag As ObjectTagData
                                TempTag = DirectCast(CurrentNode.Tag, ObjectTagData)
                                TempTag.Type = XmlRdr.ReadString
                                CurrentNode.Tag = TempTag
                            Case "ImageIndex"
                                CurrentNode.SelectedImageIndex = CInt(XmlRdr.ReadString)
                                CurrentNode.ImageIndex = CurrentNode.SelectedImageIndex
                            Case "ImageKey"
                                CurrentNode.SelectedImageKey = XmlRdr.ReadString
                                CurrentNode.ImageKey = CurrentNode.SelectedImageKey
                        End Select
                    Case XmlNodeType.EndElement
                        Select Case XmlRdr.Name
                            Case "TreeNode"
                                TreeNodes.Item(DirectCast(CurrentNode.Tag, ObjectTagData).ObjectGUID) = CurrentNode
                                If Not ParentNode Is Nothing Then
                                    ParentNode.Nodes.Add(CurrentNode)
                                    CurrentNode = DirectCast(NodeStack.Pop, TreeNode)
                                Else
                                    _TreeView.Nodes.Add(CurrentNode)
                                    CurrentNode = Nothing
                                End If
                                If NodeStack.Count > 0 Then
                                    ParentNode = DirectCast(NodeStack.Peek, TreeNode)
                                Else
                                    ParentNode = Nothing
                                End If
                        End Select
                End Select
            End While

            XmlRdr.Close()

            'expand root nodes
            For Each Node As TreeNode In _TreeView.Nodes
                Node.Expand()
            Next

            If Not _ProgressBar Is Nothing Then _ProgressBar.Increment(64)

            'get remembered node if any
            If Remember.IsNotEmpty AndAlso TreeNodes.ContainsKey(Remember) Then Return TreeNodes.Item(Remember) Else Return Nothing

        Catch ex As Exception
            If Not _ProgressBar Is Nothing Then _ProgressBar.Caption = "RPGXplorer - Reloading Tree from Database"
            'clear in case I got half way through
            _TreeView.Nodes.Clear()
            Return LoadTree(Remember)
        End Try

    End Function

    'load the tree node with its children (recursive)
    Public Sub LoadTreeNode(ByRef Node As TreeNode)
        Dim RememberedNode As TreeNode
        SuspendEvents = True
        _TreeView.BeginUpdate()
        _TreeView.Nodes.Clear()

        If Node Is Nothing Then
            LoadTree(Objects.ObjectKey.Empty)
            SuspendEvents = False
        Else
            RememberedNode = LoadTree(DirectCast(Node.Tag, ObjectTagData).ObjectGUID)
            If RememberedNode Is Nothing Then
                SuspendEvents = False
            Else
                RememberedNode.Expand()
                SuspendEvents = False
                _TreeView.SelectedNode = RememberedNode
                _TreeView.SelectedNode.EnsureVisible()
            End If
        End If

        _TreeView.EndUpdate()
    End Sub

#End Region

    'structure to maintain a subset of object data in a treenode
    Public Structure ObjectTagData
        Public Name As String
        Public ObjectGUID As ObjectKey
        Public Type As String
    End Structure

    'handles the list view AfterSelect event
    Public Sub OpenSelectedFolder()

        'if character folder or character then set current character
        Dim CharKey As Objects.ObjectKey
        If DirectCast(_TreeView.SelectedNode.Tag, ObjectTagData).Type = Objects.CharacterType OrElse AncestorIsOfType(_TreeView.SelectedNode, Objects.CharacterType) Then
            CharKey = Me.AncestorOfType(_TreeView.SelectedNode, Objects.CharacterType)
        ElseIf DirectCast(_TreeView.SelectedNode.Tag, ObjectTagData).Type = Objects.MonsterType OrElse AncestorIsOfType(_TreeView.SelectedNode, Objects.MonsterType) Then
            CharKey = Me.AncestorOfType(_TreeView.SelectedNode, Objects.MonsterType)
        End If
        If CharKey.IsNotEmpty Then CharacterManager.CurrentCharacterKey = CharKey

        'save current panel
        SaveCurrentPanel()

        'init vars
        Dim Node As TreeNode = _TreeView.SelectedNode

        'determine the panel to be displayed in the main view
        Dim FolderTagData As ObjectTagData = DirectCast(Node.Tag, ObjectTagData)
        Dim Folder As New Objects.ObjectData
        Folder.Load(FolderTagData.ObjectGUID)

        'get the window
        Dim CurrentWindow As CentralDisplayForm
        If WindowManager.IsWindowOpen(FolderTagData.ObjectGUID) Then
            CurrentWindow = WindowManager.GetWindow(FolderTagData.ObjectGUID)
        Else
            CurrentWindow = WindowManager.CreateWindow(FolderTagData.ObjectGUID, CharKey)
        End If

        'set the current window 
        WindowManager.SetCurrentWindow(CurrentWindow)

        'set filters
        FilterManager.EnableDisable(FolderTagData.Type)
        If ToolbarsAndMenus.FilterEdit.Enabled Then FilterManager.InitFolder(Folder)

        'initialise the panel if needed
        If WindowManager.IsDirty Then
            General.SetWaitCursor()

            Select Case CurrentWindow.MyPanelType
                Case PanelType.BasicListView, PanelType.Inventory, PanelType.AssetsPanel
                    ListView.BeginUpdate()
                    ListView.Clear()
                    ListViewManager.SetListViewColumns()
                    LoadListViewItems()
                    ListViewManager.SortListView()
                    ListView.EndUpdate()

                    'panel specific 
                    Select Case CurrentPanelType
                        Case PanelType.AssetsPanel

                            'hack for assests - removes magic column
                            If CurrentPanelType = PanelType.AssetsPanel Then
                                For Each Column As ColumnHeader In _ListView.Columns
                                    If Column.Text = "Active" Then
                                        _ListView.Columns.Remove(Column)
                                        Exit For
                                    End If
                                Next
                            End If

                            If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, AssetsPanel).Init(CharKey)
                        Case PanelType.Inventory
                            If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, InventoryPanel).Init(CharKey)
                    End Select

                Case PanelType.Character
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, CharacterPanel).Init(CharKey)
                Case PanelType.Modifiers
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, ModifiersPanel).Init(CharKey)
                Case PanelType.Features
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, FeaturesPanel).Init(CharKey)
                Case PanelType.Skills
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, SkillsPanel).Init(CharKey)
                    'Case PanelType.Spells
                    '    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, SpellsPanel).Init(CharKey)
                Case PanelType.SpellCaster
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, SpellcasterPanel2).Init(CharKey)
                Case PanelType.Manifester
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, ManifesterPanel).Init(CharKey)
                Case PanelType.Weapons
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, WeaponsPanel).Init(CharKey)
                Case PanelType.Feats
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, FeatPanel).Init(CharKey)
                Case PanelType.Memorized
                    If CurrentWindow.NeedsPanelInit Then DirectCast(CurrentWindow.MyPanel, MemorizedPanel).Init(CharKey)
            End Select

            'refresh panel data
            CurrentWindow.RefreshPanel()
            WindowManager.RemoveDirty(CurrentWindow)

            General.SetNormalCursor()
        End If

        'show the window
        CurrentWindow.Show()
        CurrentWindow.Focus()

        'recolor listview 
        If Not ListView Is Nothing Then ListViewManager.ColourListView()

        'focus
        _Focus = Focus.TreeView

    End Sub

    'sets the explorer's list view to that of the currently visible window/panel
    Public Sub SetListView(ByVal PanelType As PanelType)
        Try
            Select Case PanelType
                Case PanelType.Character, PanelType.Weapons, PanelType.SpellCaster, PanelType.Manifester, PanelType.NotSet
                    _ListView = Nothing
                    _ListViewManager = Nothing
                Case Else

                    _ListView = DirectCast(WindowManager.CurrentWindow.MyPanel, IPanel).ListView

                    'get the object from the current window
                    Dim CurrentlySelectedObject As Objects.ObjectData
                    Dim SortType As General.SortType
                    Dim FolderType As String

                    CurrentlySelectedObject = WindowManager.CurrentWindow.Folder

                    If CurrentlySelectedObject.ObjectGUID.IsNotEmpty Then
                        SortType = CurrentlySelectedObject.SortType
                        FolderType = CurrentlySelectedObject.Type
                    Else
                        SortType = SortType.Alphabetic
                        FolderType = ""
                    End If

                    _ListViewManager = New ListViewManager(_ListView, CurrentlySelectedObject.ObjectGUID, FolderType, SortType)

            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the panel type based on the object type
    Public Function GetPanelType(ByVal FolderType As String, ByVal Node As TreeNode) As PanelType
        Try
            Dim NewPanelType As PanelType

            Select Case FolderType
                Case Objects.AssetsFolderType
                    NewPanelType = PanelType.AssetsPanel
                Case Objects.CharacterType, Objects.MonsterType
                    NewPanelType = PanelType.Character
                Case Objects.InventoryFolderType
                    NewPanelType = PanelType.Inventory
                Case Objects.ItemType
                    If AncestorIsOfType(Node, Objects.InventoryFolderType) Then
                        NewPanelType = PanelType.Inventory
                    Else
                        NewPanelType = PanelType.AssetsPanel
                    End If
                Case Objects.ModifierFolderType
                    NewPanelType = PanelType.Modifiers
                Case Objects.FeatureFolderType
                    NewPanelType = PanelType.Features
                Case Objects.SkillFolderType
                    NewPanelType = PanelType.Skills
                Case Objects.SpellListFolderType
                    NewPanelType = PanelType.SpellList
                Case Objects.ClassSpellListFolderType
                    NewPanelType = PanelType.SpellList
                Case Objects.ClassSpellSettingsFolderType
                    NewPanelType = PanelType.SpellCaster
                Case Objects.WeaponConfigFolderType
                    NewPanelType = PanelType.Weapons
                Case Objects.FeatFolderType
                    NewPanelType = PanelType.Feats

                    'psionics
                Case Objects.PowerListFolderType
                    NewPanelType = PanelType.PowerList
                Case Objects.ClassPowerListFolderType
                    NewPanelType = PanelType.PowerList
                Case Objects.ClassPowerSettingsFolderType
                    NewPanelType = PanelType.Manifester

                    'memorized spells
                Case Objects.MemorizedSpellsFolderType
                    NewPanelType = PanelType.Memorized

                Case Else
                    NewPanelType = PanelType.BasicListView
            End Select

            Return NewPanelType

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'handles a list view item being selected
    Public Sub HandleListViewItemSelect()
        _Focus = Focus.ListView

        'if character then set current character
        If Me.SelectedObjectCount = 1 AndAlso (Me.SelectedObject.Type = Objects.CharacterType OrElse Me.SelectedObject.Type = Objects.MonsterType) Then
            CharacterManager.CurrentCharacterKey = Me.SelectedObject.ObjectGUID
        End If

        'browser
        If Not Me.SuspendBrowser Then ShowHelpForSelected()

    End Sub

    'handles the list view ItemActivate event
    Public Sub HandleItemActivate()
        Dim Obj As ObjectData
        Dim Node As TreeNode
        Dim Open As Boolean = True

        If _ListView Is Nothing Then Exit Sub
        If _ListView.SelectedItems.Count > 1 Or _ListView.SelectedItems.Count = 0 Then Exit Sub

        If Not UI.ReadOnly AndAlso General.DoubleClickEdits Then
            If Commands.ShiftEnter(True) Then Open = False
        End If

        If Open Then
            'if the currently selected list view item has children then this action will open the item and make it selected in the tree view (if it is displayed there)
            Obj = CurrentSelectedObjects.Item(0)
            If Obj.ShowInTree = True Then
                'object should be visible in the tree therefore making the tree node selected will suffice
                For Each Node In _TreeView.SelectedNode.Nodes
                    If DirectCast(Node.Tag, ObjectTagData).ObjectGUID.Equals(Obj.ObjectGUID) Then
                        _TreeView.SelectedNode = Node
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    'reposition a node whose name has changed
    Private Function ResortRenamedNode(ByVal Node As TreeNode) As TreeNode
        Try
            Dim ParentNode As TreeNode = Node.Parent

            If Node.IsSelected Then
                Dim CurrentSuspend As Boolean = MainExplorer.SuspendEvents
                'remove the node
                MainExplorer.SuspendEvents = True
                ParentNode.Nodes.Remove(Node)
                MainExplorer.SuspendEvents = CurrentSuspend

                'replace the node
                InsertNode(ParentNode, Node)
                General.MainExplorer.TreeView.SelectedNode = Node
                Return Node

            Else
                'remove the node               
                ParentNode.Nodes.Remove(Node)

                'replace the node
                InsertNode(ParentNode, Node)
                Return Node
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'inserts a node at the correct point under its parent
    Public Sub InsertNode(ByVal ParentNode As TreeNode, ByVal Node As TreeNode, Optional ByVal IgnoreSort As Boolean = False)
        Try

            If IgnoreSort Then
                ParentNode.Nodes.Add(Node)
            Else
                Dim Currentnode As TreeNode = ParentNode.FirstNode
                Dim Inserted As Boolean = False

                While Not Currentnode Is Nothing
                    If Node.Text.CompareTo(Currentnode.Text) < 0 Then
                        ParentNode.Nodes.Insert(Currentnode.Index, Node)
                        Inserted = True
                        Exit While
                    End If
                    Currentnode = Currentnode.NextNode
                End While

                'if not inserted then insert at end
                If Not Inserted Then ParentNode.Nodes.Add(Node)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reload the currently selected node itself
    Private Sub ReloadSelectedNode()
        Dim Data As ObjectTagData
        Dim Obj As New Objects.ObjectData
        Dim ImageIndex As Integer

        'If the node has a specified image, refresh with the new image
        'Otherwise load the type default
        Data = DirectCast(_TreeView.SelectedNode.Tag, ObjectTagData)
        Obj.Load(Data.ObjectGUID)
        ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)

        'clipboard colouring
        If _Clipboard.ClipboardGuids.Contains(Obj.ObjectGUID) And _Clipboard.Mode = Clipboard.CutCopy.Cut Then
            _TreeView.SelectedNode.ForeColor = System.Drawing.Color.DimGray
        Else
            _TreeView.SelectedNode.ForeColor = System.Drawing.Color.Black
        End If

        _TreeView.SelectedNode.Text = Me.ObjectSelectedInTree.Name
        _TreeView.SelectedNode.ImageIndex = ImageIndex
        _TreeView.SelectedNode.SelectedImageIndex = ImageIndex

    End Sub

    'remove a list of objects from the tree
    Public Sub RemoveObjectsFromTree(ByVal ObjGuids As ArrayList, Optional ByRef CheckNode As TreeNode = Nothing)
        Dim Node As TreeNode
        Dim TagData As ObjectTagData

        'recursive
        If CheckNode Is Nothing Then

            _TreeView.BeginUpdate()

            For Each Node In _TreeView.Nodes
                RemoveObjectsFromTree(ObjGuids, Node)
            Next
        Else
            TagData = DirectCast(CheckNode.Tag, ObjectTagData)
            If ObjGuids.Contains(TagData.ObjectGUID) Then
                CheckNode.Remove()
            Else
                Dim RemoveNodes As New ArrayList
                Dim RecurseNodes As New ArrayList

                For Each Node In CheckNode.Nodes
                    TagData = DirectCast(Node.Tag, ObjectTagData)
                    If ObjGuids.Contains(TagData.ObjectGUID) Then
                        RemoveNodes.Add(Node)
                    Else
                        RecurseNodes.Add(Node)
                    End If
                Next

                For Each Node In RemoveNodes
                    Node.Remove()
                Next

                For Each Node In RecurseNodes
                    RemoveObjectsFromTree(ObjGuids, Node)
                Next

            End If
        End If

        _TreeView.EndUpdate()
    End Sub

    'load the list view items (i.e. the children) of the currently selected tree node
    Private Sub LoadListViewItems()
        Dim ListViewItem As ListViewItem
        Dim Cut As Boolean
        Dim ObjType, Element As String
        Dim ObjectList As Objects.ObjectDataCollection
        Dim ColumnCount, ItemNo As Integer
        Dim Items() As ListViewItem

        'get current folder
        Dim FolderObj As Objects.ObjectData = WindowManager.CurrentWindow.Folder

        'init
        ObjType = FolderObj.Type

        ColumnCount = _ListView.Columns.Count - 1

        'get the objects to be displayed and filter if required
        ObjectList = FolderObj.ChildrenVisibleInListView
        If FilterManager.CurrentFilter <> "" Then ObjectList = FilterManager.ProcessFilter(ObjectList)

        'are there any objects?
        If ObjectList.Count = 0 Then
            Exit Sub
        Else
            ReDim Items(ObjectList.Count - 1)
        End If

        'display them
        ItemNo = 0
        For Each Obj As Objects.ObjectData In ObjectList

            'check to see if the object is currently on the clipboard as a "Cut"
            If _Clipboard.Mode = Clipboard.CutCopy.Cut Then
                If _Clipboard.Contains(Obj.ObjectGUID) Then Cut = True Else Cut = False
            End If

            'create a new list view item
            ListViewItem = New ListViewItem(Obj.Name)
            If Cut Then ListViewItem.ForeColor = System.Drawing.Color.DimGray
            ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)
            ListViewItem.Tag = Obj.ObjectGUID

            'add subitems
            If ColumnCount > 0 Then
                For x As Integer = 0 To ColumnCount - 1
                    Element = ListViewManager.ListViewColumnDefs.Item(ObjType).Elements(x)
                    If Element = "Type" Then
                        ListViewItem.SubItems.Add(Objects.ObjectTypes.Item(Obj.Type).Friendly)
                    Else
                        ListViewItem.SubItems.Add(Obj.Element(Element))
                    End If
                Next
            End If

            'add to list view
            Items(ItemNo) = ListViewItem
            ItemNo += 1
        Next

        _ListView.BeginUpdate()
        _ListView.Items.AddRange(Items)
        _ListView.EndUpdate()
    End Sub

    'update the help viewer
    Public Sub ShowHelpForSelected()
        Dim Obj As New Objects.ObjectData
        Dim Tag As Object

        If SuspendBrowser Then Exit Sub
        'If _ListView Is Nothing Then Exit Sub
        If _ListView Is Nothing OrElse _ListView.SelectedItems.Count = 0 OrElse _ListView.SelectedItems.Count > 1 Then
            ShowHelpForTreeNode()
            Exit Sub
        End If

        Tag = _ListView.SelectedItems(0).Tag

        If TypeOf Tag Is Objects.ObjectData Then
            ShowHelpPage(DirectCast(Tag, Objects.ObjectData))
        ElseIf TypeOf Tag Is Objects.ObjectKey Then
            Obj.Load(DirectCast(Tag, Objects.ObjectKey))
            ShowHelpPage(Obj)
        ElseIf TypeOf Tag Is String Then
            ShowHelp(Tag.ToString)
        Else                            'should never get called
            Obj = SelectedObject()
            ShowHelpPage(Obj)
        End If

    End Sub

    'show help for selected tree node
    Public Sub ShowHelpForTreeNode()
        If SuspendBrowser Or SuspendEvents Then Exit Sub

        Dim Obj As Objects.ObjectData = Me.ObjectSelectedInTree
        ShowHelpPage(Obj)
    End Sub

    'get help page
    Private Sub ShowHelpPage(ByVal Obj As Objects.ObjectData)
        Dim HelpPage As String
        Dim HelpObj As New Objects.ObjectData

        If Obj.ObjectGUID.IsEmpty Then Exit Sub

        If Obj.HTMLGUID.Equals(ObjectKey.Empty) And (Obj.HTML = "") Then
            Obj.CreateDefaultRulePage()
            Obj.Save()
        End If

        If Obj.HTMLGUID.Equals(ObjectKey.Empty) Then
            HelpPage = Obj.HTML
        Else
            HelpObj.Load(Obj.HTMLGUID)
            HelpPage = HelpObj.HTML
        End If

        ShowHelp(HelpPage)
    End Sub

    'show a specific help page
    Public Sub ShowHelp(ByVal HelpPage As String)
        If SuspendBrowser Then Exit Sub

        Try
            If HelpPage.IndexOf(":\") = 1 And IO.File.Exists(HelpPage) Then
                General.MainExplorer.Browser.Navigate("file://" & HelpPage)
            Else
                If IO.File.Exists(General.HelpPath & HelpPage) Then
                    General.MainExplorer.Browser.Navigate("file://" & General.HelpPath & HelpPage)
                Else
                    General.MainExplorer.Browser.Navigate("file://" & General.HelpPath & "Help\FileNotFound.htm")
                End If
            End If
        Catch ex As System.Reflection.TargetInvocationException
            'do nothing
        End Try

    End Sub

    'saves thes TreeView structure to XML
    Public Sub SaveTree()

        Dim XmlWriter As New XmlTextWriter(General.BasePath & "XML\TreeView.xml", System.Text.Encoding.UTF8)
        XmlWriter.Formatting = Formatting.Indented

        XmlWriter.WriteStartDocument(True)
        XmlWriter.WriteStartElement("RPGXplorerConfig")

        For Each Node As TreeNode In TreeView.Nodes
            'save the node recusivly
            SaveNode(Node, XmlWriter)
        Next

        XmlWriter.WriteEndElement()
        XmlWriter.WriteEndDocument()
        XmlWriter.Flush()
        XmlWriter.Close()

    End Sub

    'recursive part of TreeView saving
    Private Sub SaveNode(ByVal Node As TreeNode, ByVal XmlWriter As XmlTextWriter)
        Dim TagData As ObjectTagData = DirectCast(Node.Tag, ObjectTagData)

        'save myself
        XmlWriter.WriteStartElement("TreeNode")

        XmlWriter.WriteElementString("Name", Node.Text)
        XmlWriter.WriteElementString("ObjectGuid", TagData.ObjectGUID.ToString)
        XmlWriter.WriteElementString("Type", TagData.Type)
        XmlWriter.WriteElementString("ImageIndex", Node.ImageIndex.ToString)
        XmlWriter.WriteElementString("ImageKey", Node.ImageKey)

        'save my children
        For Each ChildNode As TreeNode In Node.Nodes
            SaveNode(ChildNode, XmlWriter)
        Next

        XmlWriter.WriteEndElement()

    End Sub

#Region "External Requests to Update"

    'refresh everything
    Public Sub Refresh()
        'save column layout
        If Not WindowManager.CurrentWindow Is Nothing Then
            WindowManager.CurrentWindow.SaveLayout()
        End If

        'reload tree
        LoadTreeNode(_TreeView.SelectedNode)

        'refresh document names
        WindowManager.RefreshTabNames()
    End Sub

    'refresh panel only
    Public Sub RefreshPanel()
        If Not WindowManager.CurrentWindow Is Nothing Then
            WindowManager.CurrentWindow.SaveLayout()

            Select Case General.MainExplorer.CurrentPanelType
                Case PanelType.BasicListView
                    ListView.BeginUpdate()
                    ListView.Clear()
                    ListViewManager.SetListViewColumns()
                    LoadListViewItems()
                    ListViewManager.SortListView()
                    ListView.EndUpdate()
                    ListViewManager.ColourListView()
                Case PanelType.AssetsPanel, PanelType.Inventory
                    CurrentPanel.RefreshPanelData()
                    ListView.BeginUpdate()
                    ListView.Clear()
                    ListViewManager.SetListViewColumns()
                    LoadListViewItems()
                    ListViewManager.SortListView()
                    ListView.EndUpdate()
                    ListViewManager.ColourListView()
                Case PanelType.Weapons
                    CurrentPanel.RefreshPanelData()
                Case Else
                    CurrentPanel.RefreshPanelData()
                    If Not General.MainExplorer.ListViewManager Is Nothing Then General.MainExplorer.ListViewManager.ColourListView()
            End Select
            WindowManager.RemoveDirty(WindowManager.CurrentWindow)
        End If
    End Sub

    'refresh renamed node
    Public Sub RefreshRenamedNode(ByVal Key As Objects.ObjectKey, ByVal NewName As String)
        Dim Node As TreeNode = DirectCast(General.MainExplorer.TreeNodes(Key), TreeNode)
        If Not Node Is Nothing Then
            Node.Text = NewName
            ResortRenamedNode(Node)
        End If
        WindowManager.RefreshTabNames()
    End Sub

    'select a specific item
    Public Sub SelectItemByGuid(ByVal ObjectKey As ObjectKey)
        Try
            If Not _ListView Is Nothing Then

                Dim ListViewItem As ListViewItem
                Dim Key As Objects.ObjectKey = ObjectKey

                SuspendBrowser = True
                For i As Integer = 1 To 2

                    For Each ListViewItem In _ListView.Items
                        If TypeOf ListViewItem.Tag Is RPGXplorer.Objects.ObjectKey Then
                            If DirectCast(ListViewItem.Tag, ObjectKey).Equals(Key) Then
                                _ListView.BeginUpdate()
                                _ListView.SelectedItems.Clear()
                                ListViewItem.Selected = True
                                ListViewItem.EnsureVisible()
                                _ListView.LabelEdit = True
                                ListViewItem.BeginEdit()
                                _ListView.LabelEdit = False
                                _ListView.EndUpdate()
                                SuspendBrowser = False
                                ShowHelpForSelected()
                                _ListView.LabelEdit = True
                                Exit Sub
                            End If
                        End If
                    Next

                    'if not found, select parent
                    Dim TempObj As New Objects.ObjectData
                    TempObj.Load(Key)
                    Key = TempObj.ParentGUID
                Next
                SuspendBrowser = False

            End If

            'if we havent found anything yet, look on the tree view
            If Not General.DataInput Then
                If General.MainExplorer.CurrentFocus = Focus.TreeView Then
                    Dim Node As TreeNode = DirectCast(General.MainExplorer.TreeNodes(ObjectKey), TreeNode)
                    If Not Node Is Nothing Then
                        General.MainExplorer.TreeView.SelectedNode = Node
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            SuspendBrowser = False
        End Try
    End Sub

    'select a specific item
    Public Sub SelectItemByIndex(ByVal Index As Integer)

        If _ListView Is Nothing Then Exit Sub

        Dim ListViewItem As ListViewItem
        Dim Maxindex As Integer

        SuspendBrowser = True
        Maxindex = _ListView.Items.Count - 1

        If Index >= 0 And Index <= Maxindex Then
            ListViewItem = _ListView.Items(Index)

            _ListView.BeginUpdate()
            _ListView.SelectedItems.Clear()

            ListViewItem.Selected = True
            ListViewItem.EnsureVisible()

            _ListView.LabelEdit = True
            ListViewItem.BeginEdit()
            _ListView.LabelEdit = False
            _ListView.EndUpdate()
            SuspendBrowser = False
            ShowHelpForSelected()
            _ListView.LabelEdit = True
            Exit Sub
        End If
        SuspendBrowser = False

    End Sub

    'select a specific item in the tree
    Public Sub SelectOGLFolderByGuid(ByVal ObjectKey As ObjectKey, ByVal FirstNode As TreeNode)
        Dim Node As TreeNode
        Dim Flag As Boolean

        Flag = True
        Node = FirstNode

        While Flag
            If DirectCast(Node.Tag, ObjectTagData).ObjectGUID.Equals(ObjectKey) Then
                _TreeView.SelectedNode = Node
                Node.EnsureVisible()
                Node.Expand()
                Exit While
            Else
                If Node.Nodes.Count > 0 Then SelectOGLFolderByGuid(ObjectKey, Node.FirstNode)
            End If

            Node = Node.NextNode
            If Node Is Nothing Then Flag = False
        End While
    End Sub

    'select a group of items
    Public Sub SelectGroup(ByVal Guids As ArrayList)
        If _ListView Is Nothing Then Exit Sub

        Dim ListViewItem As ListViewItem
        Dim HighestIndex As Integer = 0

        For Each ListViewItem In _ListView.Items

            If TypeOf ListViewItem.Tag Is RPGXplorer.Objects.ObjectKey Then
                If Guids.Contains(DirectCast(ListViewItem.Tag, ObjectKey)) Then
                    ListViewItem.Selected = True
                    If ListViewItem.Index > HighestIndex Then HighestIndex = ListViewItem.Index
                End If
            End If
        Next

        If HighestIndex > 0 Then
            _ListView.Focus()
            _ListView.Items(HighestIndex).EnsureVisible()
        Else
            ShowHelpForTreeNode()
        End If
    End Sub

    'save current panel
    Public Sub SaveCurrentPanel()
        If WindowManager.CurrentWindow Is Nothing OrElse WindowManager.CurrentWindow.MyPanel Is Nothing Then Exit Sub

        'ask the old panel to save
        Dim Panel As IPanel = DirectCast(WindowManager.CurrentWindow.MyPanel, IPanel)

        If Panel.IsDirty Then
            Panel.Save()
            Panel.IsDirty = False
        End If

        'save column layout
        WindowManager.CurrentWindow.SaveLayout()
    End Sub

    'collapse folder
    Public Sub Collapse()
        Try
            _TreeView.BeginUpdate()
            CollapseRecurse(_TreeView.SelectedNode)
            _TreeView.EndUpdate()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'collapse recurse
    Public Shared Sub CollapseRecurse(ByVal Node As TreeNode)
        Try
            If Node Is Nothing Then Exit Sub

            Node.Collapse()
            For Each Child As TreeNode In Node.Nodes
                CollapseRecurse(Child)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'expand folder
    Public Sub Expand()
        Try
            If _TreeView.SelectedNode Is Nothing Then Exit Sub

            _TreeView.BeginUpdate()
            _TreeView.SelectedNode.ExpandAll()
            _TreeView.EndUpdate()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Helper Functions"

    'get ancestor in the tree of a given type
    Public Function AncestorOfType(ByVal Node As TreeNode, ByVal Type As String) As ObjectKey
        AncestorOfType = Nothing
        While Not Node Is Nothing
            If DirectCast(Node.Tag, ObjectTagData).Type = Type Then
                AncestorOfType = DirectCast(Node.Tag, ObjectTagData).ObjectGUID
                Exit While
            End If
            Node = Node.Parent
        End While

        Return AncestorOfType
    End Function

    'get ancestor in the tree of a given name
    Public Function AncestorOfName(ByVal Node As TreeNode, ByVal Name As String) As ObjectKey
        AncestorOfName = Nothing
        While Not Node Is Nothing
            If DirectCast(Node.Tag, ObjectTagData).Name = Name Then
                AncestorOfName = DirectCast(Node.Tag, ObjectTagData).ObjectGUID
                Exit While
            End If
            Node = Node.Parent
        End While

        Return AncestorOfName
    End Function

    'check to see if any ancestor in the tree is of a given type
    Public Function AncestorIsOfType(ByVal Node As TreeNode, ByVal Type As String) As Boolean
        While Not Node Is Nothing
            If DirectCast(Node.Tag, ObjectTagData).Type = Type Then Return True
            Node = Node.Parent
        End While

        Return False
    End Function

    'helper function that converts an object data structure into a tree node
    Public Function NodeFromObject(ByVal Obj As ObjectData) As TreeNode
        Dim Node As New TreeNode
        Dim ImageIndex As Integer
        Dim TagData As ObjectTagData

        Node.Text = Obj.Name
        TagData.Name = Obj.Name
        TagData.ObjectGUID = Obj.ObjectGUID
        TagData.Type = Obj.Type
        Node.Tag = TagData
        ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)
        Node.ImageIndex = ImageIndex
        Node.ImageKey = Obj.ImageFilename
        Node.SelectedImageIndex = ImageIndex
        Node.SelectedImageKey = Obj.ImageFilename

        'check to see if the object is currently on the clipboard as a "Cut"
        If _Clipboard.Mode = Clipboard.CutCopy.Cut Then
            If _Clipboard.Contains(Obj.ObjectGUID) Then Node.ForeColor = System.Drawing.Color.DimGray
        End If

        Return Node
    End Function

    'helper function that converts an object data structure into a tree node - children and all and updates the treenodes hastable
    Public Function CompleteNodeFromObject(ByVal Obj As ObjectData) As TreeNode
        Dim Node As TreeNode = NodeFromObject(Obj)

        For Each TempObj As Objects.ObjectData In Obj.Children

            If TempObj.ShowInTree Then
                Dim ChildNode As TreeNode = CompleteNodeFromObject(TempObj)

                Select Case Obj.Type
                    Case Objects.ClassLevelsFolderType, Objects.MonsterClassLevelsFolderType
                        Node.Nodes.Add(ChildNode)
                    Case Else
                        Dim ExistingChildNode As TreeNode = Node.FirstNode
                        Dim Inserted As Boolean = False

                        'look for the position to insert so that sort is maintained
                        While Not ExistingChildNode Is Nothing
                            If ChildNode.Text.CompareTo(ExistingChildNode.Text) < 0 Then
                                Node.Nodes.Insert(ExistingChildNode.Index, ChildNode)
                                Inserted = True
                                Exit While
                            End If
                            ExistingChildNode = ExistingChildNode.NextNode
                        End While

                        'if not inserted then insert at end
                        If Not Inserted Then Node.Nodes.Add(ChildNode)
                End Select

            End If
        Next

        TreeNodes.Item(Obj.ObjectGUID) = Node
        Return Node

    End Function

    'helper function that retrieves the object represented by a tree node
    Private Function ObjectFromNode(ByVal Node As TreeNode) As Objects.ObjectData
        Dim Obj As New Objects.ObjectData

        If Node Is Nothing Then Return Obj
        Obj.Load(DirectCast(Node.Tag, ObjectTagData).ObjectGUID)
        Return Obj
    End Function

#End Region

End Class
