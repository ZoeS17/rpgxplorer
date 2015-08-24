Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.Utils
Imports RPGXplorer.Exceptions

Public Class ToolbarsAndMenus

    'this class encapsulates the construction of bar items, toolbars and the main menu

#Region "Constants"

    Private Const BrowserGroup As Integer = 1

#End Region

#Region "Member Variables"

    Private Shared mBarManager As BarManager
    Private Shared mToolbar, mFilterBar, mMarketplaceBar As Bar
    Private Shared mMenubar As Bar
    Private Shared mPopupMenu As DevExpress.XtraBars.PopupMenu
    Private Shared mXSLMenu As DevExpress.XtraBars.BarSubItem
    'Private Shared mTemplateMenu As DevExpress.XtraBars.BarSubItem
    Private Shared RulesMenu As DevExpress.XtraBars.BarSubItem
    Private Shared CharactersMenu As DevExpress.XtraBars.BarSubItem
    Private Shared CompanionsMenu As DevExpress.XtraBars.BarSubItem
    Private Shared BeginGroup As Boolean
    Private Shared FocusObject, FocusParent As Objects.ObjectData
    Private Shared FocusChildren As Objects.ObjectDataCollection

    'flag for each of the object specific commands
    Private Shared AddAmmoDefinition, AddArmorDefinition, AddArmorMagicAbility, AddArtifact, AddBonusClassSkill, AddBonusDomain, AddBonusFeat, AddBonusLanguage, AddCannotUse, AddCharacter, AddCharacteristic, AddCharacterLevels, AddChooseBonusFeat, AddChooseFeature, AddClass, AddClassLevel, AddClassSkill, AddCondition, AddCombatStyle, AddCurse, AddDamageAddition, AddDamageReduction, AddDamageResistance, AddDamageVulnerability, AddDeityDefinition, AddDomainDefinition, AddEnhancement, AddPrestigeCasterProgression, AddExpiryCondition, AddFeatDefinition, AddFeature, AddFeatureDefinition, AddFighterBonusFeat, AddFlurryOfBlows, AddFolder, AddGrantedPower, AddHTMLDoc, AddIntelligence, AddItem, AddItemDefinition, AddLanguage, AddLocation, AddMagicAmmoDefinition, AddModifier, AddModifierLimiter, AddMoney, AddMonsterType, AddPotionDefinition, AddPrerequisite, AddRace, AddRacialWeapon, AddRegeneration, AddReplaceKnownSpell, AddRingDefinition, AddRodDefinition, AddSpecialMaterialDefinition, AddScrollDefinition, AddSetValue, AddSkillDefinition, AddSkillSynergy, AddSpecialisedSubmenu, AddSpecificBonusFeat, AddSpecificClassSkill, AddSpecificChooseBonusClassSkill, AddSpecificChooseBonusDomain, AddSpecificArmorDefinition, AddSpecificWeaponDefinition, AddSpell, AddSpellCategory, AddSpellDefinition, AddSpellDescriptor, AddSpellFailure, AddSpellsKnown, AddSpellSchool, AddSpellSubschool, AddSpellsPerDay, AddStaff, AddSystemCondition, AddSystemAbility, AddSystemAbilityDefinition, AddSystemAlignment, AddSystemAlignmentDefinition, AddSystemElement, AddSystemPrecondition, AddSystemPreconditionDefinition, AddSystemReference, AddSystemRestriction, AddSystemRestrictionDefinition, AddSystemWeaponAbility, AddSystemWeaponAbilityDefinition, AddUserDoc, AddUserMap, AddUserRule, AddWand, AddWeapon, AddWeaponEmulation, AddWeaponMagicAbility, AddWeaponMagicAbilityDefinition, AddWeaponMagicAbilityBane, AddWondrous As Boolean
    Private Shared EditAmmoDefinition, EditArmorDefinition, EditArmorMagicAbility, EditArtifact, EditCannotUse, EditCharacter, EditCharacteristic, EditChooseBonusFeat, EditChooseBonusFeatOfType, EditChooseFeature, EditClass, EditClassLevel, EditCondition, EditCombatStyle, EditCurse, EditDamageAddition, EditDamageReduction, EditDamageResistance, EditDamageVulnerability, EditDeityDefinition, EditDomainDefinition, EditEnhancement, EditExpiryCondition, EditFeatDefinition, EditFeature, EditFeatureDefinition, EditItem, EditFlurryOfBlows, EditGrantedPower, EditHTMLDoc, EditIntelligence, EditItemDefinition, EditLanguage, EditMagicAmmoDefinition, EditModifier, EditModifierLimiter, EditMoney, EditMonsterType, EditPotionDefinition, EditPrerequisite, EditRace, EditRacialWeapon, EditRegeneration, EditRingDefinition, EditRodDefinition, EditRulePage, EditSpecialMaterialDefinition, EditScrollDefinition, EditSetValue, EditSkillDefinition, EditSkillSynergy, EditSpecificBonusFeat, EditSpecificClassSkill, EditSpecificChooseBonusClassSkill, EditSpecificChooseBonusDomain, EditSpecificArmorDefinition, EditSpecificWeaponDefinition, EditSpellCategory, EditSpellDefinition, EditSpellDescriptor, EditSpellFailure, EditSpellsKnown, EditSpellSchool, EditSpellSubschool, EditSpellsPerDay, EditStaff, EditSystemCondition, EditSystemAbility, EditSystemAbilityDefinition, EditSystemAligment, EditSystemAlignmentDefinition, EditSystemElement, EditSystemPrecondition, EditSystemPreconditionDefinition, EditSystemReference, EditSystemRestriction, EditSystemRestrictionDefinition, EditSystemWeaponAbility, EditSystemWeaponAbilityDefinition, EditUserDoc, EditUserMap, EditUserRule, EditWand, EditWeapon, EditWeaponEmulation, EditWeaponMagicAbility, EditWeaponMagicAbilityDefinition, EditWondrous As Boolean
    Private Shared AddChooseBonusFeatOfType As Boolean

    'cart flags
    Private Shared CartAdd, CartMasterwork, CartPlus1, CartPlus2, CartPlus3, CartPlus4, CartPlus5, CartCustom As Boolean

    'general flags
    Private Shared Cut, Copy, Paste, Rename, Properties, SelectAll As Boolean
    Private Shared Expand, Collapse As Boolean
    Private Shared DeleteCharacterLevel, DeleteObjects As Boolean

    'inventory
    Private Shared Activate, Deactivate As Boolean
    Private Shared Sell, CombineMoney As Boolean
    Private Shared ScribeScroll, EditScroll As Boolean
    Private Shared ImprintStone, EditStone As Boolean

    'char sheet
    Private Shared PrintCharacterSheet As Boolean
    Private Shared ShowCharacterXML As Boolean

    'misc
    Private Shared ClearPortrait As Boolean
    Private Shared CreateClassLevels As Boolean
    Private Shared AddTags, RemoveTags As Boolean

    'add, edit and view toolbar items
    Private Shared CurrentEditView As BarItemLink

    'filter 
    Private Shared FilterCombo As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox

    'panel seletor
    Private Shared PanelCombo As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox

    'marketplace
    Private Shared PricesSpin As New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

    'character Commands
    Private Shared AddFeat, AddCharacterFeature, AddCharacterLanguage, AddDomain, AddSpecialistSchool, AddProhibitedSchool, AddUserModifier, DisableFeat, DisableFeature, DisableUserModifier, EditFeat, EditCharacterFeature, EditCharacterLanguage, EditUserModifier, EnableFeat, EnableFeature, EditCharacterSkill, EnableUserModifier, FeatureEditMode, FeatureViewMode, OverrideFeatPrereq, StopOverrideFeatPrereq As Boolean

    'spell list
    Private Shared DeleteSpellLevel As Boolean
    Private Shared ModifySpellList As Boolean

    'character spell list
    Private Shared CharacterAddSpellFromDomain As Boolean
    Private Shared CharacterAddSpellFromCategory As Boolean
    Private Shared CharacterAddSpell As Boolean
    Private Shared SyncSpells As Boolean

    'psionics
    Private Shared AddDiscipline, AddSubdiscipline, EditDiscipline, EditSubdiscipline As Boolean
    Private Shared AddPower, EditPower As Boolean
    Private Shared AddPowers, RemovePowers As Boolean
    Private Shared AddDisciplineSpecialization, EditDisciplineSpecialization As Boolean
    Private Shared EditPowerProgression As Boolean
    Private Shared AddBonusPsionicSpecialization, AddSpecificOrChooseBonusPsionicSpecialization, EditSpecificOrChooseBonusPsionicSpecialization As Boolean
    Private Shared AddPrestigeManifesterProgression As Boolean
    Private Shared CharacterAddPower, CharacterAddSpecializationPower, CharacterAddDisciplineSpecialization As Boolean
    Private Shared AddPsionicArtifactDefinition, AddDorjeDefinition, AddPowerStoneDefinition, AddPsicrownDefinition, AddUniversalItemDefinition, AddPsionicWeaponDefinition, AddPsionicWeaponAbilityDefinition, AddPsionicAmmoDefinition, AddPsionicArmorDefinition, AddPsionicArmorAbilityDefinition, AddPsionicTattooDefinition As Boolean
    Private Shared EditPsionicArtifactDefinition, EditDorjeDefinition, EditPowerStoneDefinition, EditPsicrownDefinition, EditUniversalItemDefinition, EditPsionicWeaponDefinition, EditPsionicWeaponAbilityDefinition, EditPsionicAmmoDefinition, EditPsionicArmorDefinition, EditPsionicArmorAbilityDefinition, EditPsionicTattooDefinition As Boolean
    Private Shared AddPsionicWeaponAbility As Boolean
    Private Shared EditPsionicWeaponAbility As Boolean

    '1.9 familiars and stuff
    Private Shared AddCompanion, EditCompanion As Boolean
    Private Shared AddMonsterClass, EditMonsterClass As Boolean
    Private Shared AddMonsterRace, EditMonsterRace As Boolean
    Private Shared AddSetAbility, AddSkillExchange, EditSetAbility, EditSkillExchange As Boolean
    Private Shared AddNaturalWeapon, EditNaturalWeapon As Boolean
    Private Shared AddSubtype, EditSubtype As Boolean

    '1.9.5 and stuff
    Private Shared AddMonster, EditMonster As Boolean
    Private Shared SaveComponents As Boolean
    Private Shared AddSpellLikeAbility, EditSpellLikeAbility As Boolean
    Private Shared AddPsiLikeAbility, EditPsiLikeAbility As Boolean

    Private Shared AddPsiLikeAbilityTaken, AddSpellLikeAbilityTaken As Boolean
    Private Shared EditPsiLikeAbilityTaken, EditSpellLikeAbilityTaken As Boolean

    Private Shared UpdateMemorizedSpells As Boolean

#End Region

#Region "Properties"

    'the bar manager
    Public Shared Property BarManager() As BarManager
        Get
            Return mBarManager
        End Get
        Set(ByVal Value As BarManager)
            mBarManager = Value
            mBarManager.Images = Images.Icons
        End Set
    End Property

    'the main toolbar
    Public Shared Property Toolbar() As Bar
        Get
            Return mToolbar
        End Get
        Set(ByVal Value As Bar)
            mToolbar = Value
        End Set
    End Property

    'the filter toolbar
    Public Shared Property FilterBar() As Bar
        Get
            Return mFilterBar
        End Get
        Set(ByVal Value As Bar)
            mFilterBar = Value
        End Set
    End Property

    'the marketplace toolbar
    Public Shared Property MarketplaceBar() As Bar
        Get
            Return mMarketplaceBar
        End Get
        Set(ByVal Value As Bar)
            mMarketplaceBar = Value
        End Set
    End Property

    'the main menubar
    Public Shared Property Menubar() As Bar
        Get
            Return mMenubar
        End Get
        Set(ByVal Value As Bar)
            mMenubar = Value
        End Set
    End Property

    'the main popup menu
    Public Shared Property PopupMenu() As DevExpress.XtraBars.PopupMenu
        Get
            Return mPopupMenu
        End Get
        Set(ByVal Value As DevExpress.XtraBars.PopupMenu)
            mPopupMenu = Value
        End Set
    End Property

    'filter list
    Public Shared Property FilterList() As ArrayList
        Get
            FilterList = New ArrayList

            For Each Item As String In FilterCombo.Items
                FilterList.Add(Item)
            Next
        End Get
        Set(ByVal Value As ArrayList)
            Value.Sort()
            FilterCombo.Items.Clear()
            For Each Item As Object In Value
                FilterCombo.Items.Add(Item)
            Next
        End Set
    End Property

    'filter edit
    Public Shared ReadOnly Property FilterEdit() As BarEditItem
        Get
            Return CType(mBarManager.Items("CurrentFilter"), BarEditItem)
        End Get
    End Property

    'market prices edit
    Public Shared ReadOnly Property MarketPricesEdit() As BarEditItem
        Get
            Return CType(mBarManager.Items("MarketPrices"), BarEditItem)
        End Get
    End Property

    'the folders button
    Public Shared ReadOnly Property FolderButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("Folders"), BarButtonItem)
        End Get
    End Property

    'the browser button
    Public Shared ReadOnly Property BrowserButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("Browser"), BarButtonItem)
        End Get
    End Property

    'the marketplace button
    Public Shared ReadOnly Property MarketplaceButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("Marketplace"), BarButtonItem)
        End Get
    End Property

    'xml workshop button
    Public Shared ReadOnly Property XMLWorkshopButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("XMLWorkshop"), BarButtonItem)
        End Get
    End Property

    'undo button
    Public Shared ReadOnly Property UndoButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("Undo"), BarButtonItem)
        End Get
    End Property

    'data input
    Public Shared ReadOnly Property DataInputButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("DataInput"), BarButtonItem)
        End Get
    End Property

    'double click edits
    Public Shared ReadOnly Property DoubleClickEditsButton() As BarButtonItem
        Get
            Return CType(mBarManager.Items("DoubleClickEdits"), BarButtonItem)
        End Get
    End Property

    'access any button by name
    Public Shared ReadOnly Property Button(ByVal Name As String) As BarButtonItem
        Get
            Return CType(mBarManager.Items(Name), BarButtonItem)
        End Get
    End Property

#End Region

    'initialise all toolbars and menus
    Public Shared Sub Initialise()
        Try
            'init popupmenu
            mPopupMenu = New DevExpress.XtraBars.PopupMenu
            mPopupMenu.Manager = mBarManager

            'init XSL menu
            mXSLMenu = New DevExpress.XtraBars.BarSubItem
            mXSLMenu.Manager = mBarManager
            mXSLMenu.Caption = "Custom Outputs"
            mXSLMenu.Name = "CustomOutputs"
            mXSLMenu.Width = 100
            mBarManager.Items.Add(mXSLMenu)

            'init Template menu
            'mTemplateMenu = New DevExpress.XtraBars.BarSubItem
            'mTemplateMenu.Manager = mBarManager
            'mTemplateMenu.Caption = "Apply Template"
            'mTemplateMenu.Name = "ApplyTemplate"
            'mTemplateMenu.Width = 100
            'mBarManager.Items.Add(mTemplateMenu)

            'init rules sub items
            RulesMenu = New DevExpress.XtraBars.BarSubItem
            RulesMenu.Manager = mBarManager
            RulesMenu.Caption = "Add Rules"
            RulesMenu.Name = "AddRules"
            RulesMenu.Glyph = System.Drawing.Image.FromFile(General.BasePath & "Icons\" & "row_add.png")
            mBarManager.Items.Add(RulesMenu)

            AddBarSubItem("Add Psionic Items")
            AddBarSubItem("Add Magic Items")

            'init characters menu
            CharactersMenu = New DevExpress.XtraBars.BarSubItem
            CharactersMenu.Manager = mBarManager
            CharactersMenu.Caption = "Add Characters"
            CharactersMenu.Name = "AddCharacters"
            CharactersMenu.Glyph = System.Drawing.Image.FromFile(General.BasePath & "Icons\" & "row_add.png")
            mBarManager.Items.Add(CharactersMenu)

            'init companions menu
            CompanionsMenu = New DevExpress.XtraBars.BarSubItem
            CompanionsMenu.Manager = mBarManager
            CompanionsMenu.Caption = "Add Companions"
            CompanionsMenu.Name = "AddCompanions"
            CompanionsMenu.Glyph = System.Drawing.Image.FromFile(General.BasePath & "Icons\" & "row_add.png")
            mBarManager.Items.Add(CompanionsMenu)

            'create bar button items for each XSL in the directory
            Try
                Dim XSLTFiles As String() = System.IO.Directory.GetFiles(General.BasePath & "XSLT\", "*.xsl")
                For Each File As String In XSLTFiles
                    Dim FileName As String = File.Replace(General.BasePath & "XSLT\", "")
                    AddXSLItem(FileName, AddressOf Commands.CharacterXSLOutput)
                Next
            Catch ex As Exception
            End Try

            'create bar button items for the templates
            'For Each Template As ITemplate In Templates.Templates.Values
            '    Dim TemplateItem As BarButtonItem = CreateTemplateItem(Template, AddressOf Commands.ApplyTemplate)
            '    mTemplateMenu.AddItem(TemplateItem)
            'Next

            'add the first level subitems for the menu
            AddBarSubItem("&File")
            AddBarSubItem("&Edit")
            AddBarSubItem("&Component")
            AddBarSubItem("&View")
            AddBarSubItem("&Tools")

            Dim WindowMenu As New BarMdiChildrenListItem
            WindowMenu.Name = "Window"
            WindowMenu.Caption = "&Window"
            WindowMenu.Manager = mBarManager
            WindowMenu.Width = 100
            mBarManager.Items.Add(WindowMenu)

            AddBarSubItem("&Help")

            'ui
            AddCheckBarButtonItem("Folders", "Show the folders window.", "folders.png", AddressOf Commands.ShowTreeView)
            AddCheckBarButtonItem("Browser", "Show the browser.", "earth.png", AddressOf Commands.ShowBrowser)

            'file menu
            AddBarButtonItem("&Create Database", "", "data_new.png", AddressOf Commands.CreateDatabase)
            AddBarButtonItem("&Open Database", "", "data_replace.png", AddressOf Commands.OpenDatabase)
            AddBarButtonItem("&Load Components", "", "data_into.png", AddressOf Commands.LoadObjects)
            AddBarButtonItem("&Save Components", "", "data_disk.png", AddressOf Commands.SaveObjects)
            AddBarButtonItem("Export &Filters", "", "data_disk.png", AddressOf Commands.ExportFilters)
            AddBarButtonItem("Export L&ists", "", "data_disk.png", AddressOf Commands.ExportLists)
            AddBarButtonItem("E&xit Application", "", "exit.png", AddressOf Commands.ExitApplication)
            AddBarButtonItem("Save &Database", "", "data_disk.png", AddressOf Commands.SaveDatabase)
            AddBarButtonItem("&Refresh Tree", "", "refresh.png", AddressOf Commands.RefreshTree)

            'view menu
            AddBarButtonItem("&Icons", "Large icon view", "ViewModeLargeIcons.ico", AddressOf Commands.ListViewModeLargeIcons)
            AddBarButtonItem("&Details", "Detailed view", "ViewModeDetails.ico", AddressOf Commands.ListViewModeDetails)

            'tools menu
            AddCheckBarButtonItem("Data &Input", "When data input is on, every time you finish adding a primary component (Class, Feat, Feature etc.), you will automatically begin adding another.", "table_add.png", AddressOf Commands.DataInput)
            AddCheckBarButtonItem("&Double Click Edits", "Double-click a component to edit it. Normally double-click will open the component as a folder if possible", "note_edit.png", AddressOf Commands.DoubleClickEdits)
            AddBarButtonItem("&Options", "", "preferences.png", AddressOf Commands.Options)
            AddBarButtonItem("Edit a &List", "", "tables.png", AddressOf Commands.Lists)

            'help menu
            AddBarButtonItem("&Help Contents", "Show Help Start Page", "help2.png", AddressOf Commands.HelpIndex)
            AddBarButtonItem("&News and Info", "Show News and Information", "messages.png", AddressOf Commands.News)
            AddBarButtonItem("&Open Gaming License", "Show Open Gaming License", "document_info.png", AddressOf Commands.OGL)
            AddBarButtonItem("&End User License Agreement", "", "document_info.png", AddressOf Commands.OpenClosed)
            AddBarButtonItem("&About", "", "about.png", AddressOf Commands.About)

            'cut, copy and paste commands
            AddBarButtonItem("Cut", "Put components onto the clipboard for moving", "cut.png", AddressOf Commands.Cut)
            AddBarButtonItem("Copy", "Put components onto the clipboard for copying", "copy.png", AddressOf Commands.Copy)
            AddBarButtonItem("Paste", "Paste copies or move components from the clipboard to the currently selected component or folder", "paste.png", AddressOf Commands.Paste)
            AddBarButtonItem("Clear Clip&board", "Remove all components from the clipboard. Original components are unaffected", "clipboard_empty.png", AddressOf Commands.ClearClipboard)
            AddBarButtonItem("Select All", "Select all the components in the current list view", "selection.png", AddressOf Commands.SelectAll)

            'undo
            AddBarButtonItem("&Undo", "Undo the last undoable operation.", "undo.png", AddressOf Commands.Undo)

            'folders
            AddBarButtonItem("Folder Up", "Move up the folder structure one level", "arrow_up_blue.png", AddressOf Commands.FolderUp)
            AddBarButtonItem("Folder Expand", "Expand the current folder and all its subfolders", "navigate_plus.png", AddressOf Commands.FolderExpand)
            AddBarButtonItem("Folder Collapse", "Collapse the current folder and all its subfolders", "navigate_minus.png", AddressOf Commands.FolderCollapse)
            AddBarButtonItem("Reset Tree", "Collapses all folders except the root folders.", "navigate_up2.png", AddressOf Commands.ResetTree)

            'properties command
            AddBarButtonItem("Properties", "", "form_blue.png", AddressOf Commands.Properties)

            'delete commands
            AddBarButtonItem("&Delete", "Delete the component(s) selected in the tree OR list view.", "row_delete.png", AddressOf Commands.DeleteObjects)

            'filter commands
            AddBarButtonItem("Filters", "Add or Edit Filters", "funnel_edit.png", AddressOf Commands.Filters)
            AddComboBox(FilterCombo, "CurrentFilter", "Current Filter", 250, "The Currently Selected Filter.", "funnel.png", AddressOf Commands.FilterChange)
            AddBarButtonItem("Clear Filter", "Remove Current Filter", "funnel_delete.png", AddressOf Commands.FilterClear)

            'marketplace and cart commands
            AddCheckBarButtonItem("Marketplace", "Switch the marketplace on.", "shoppingbasket_full.png", AddressOf Commands.ShoppingCart)
            PricesSpin = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            PricesSpin.Name = "PricesComboBox"
            PricesSpin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            PricesSpin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            PricesSpin.EditFormat.Format = New Rules.MarketPricesFormatter
            PricesSpin.DisplayFormat.Format = New Rules.MarketPricesFormatter
            PricesSpin.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default

            Dim BarEditItem As New BarEditItem
            BarEditItem.Name = "MarketPrices"
            BarEditItem.Caption = "Prices"
            BarEditItem.Edit = PricesSpin
            BarEditItem.PaintStyle = BarItemPaintStyle.CaptionGlyph
            BarEditItem.Width = 75
            BarEditItem.Manager = mBarManager
            BarEditItem.Hint = "Use this to adjust market prices from -99% to +1000%"
            BarEditItem.Glyph = Image.FromFile(General.BasePath & "Icons\money.png")
            AddHandler BarEditItem.EditValueChanged, AddressOf Commands.PricesChanged
            mBarManager.Items.Add(BarEditItem)

            AddBarButtonItem("Add <Item> (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartAdd)
            AddBarButtonItem("Add Masterwork <Item> (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartMasterwork)
            AddBarButtonItem("Add <Item> +1 (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartPlusOne)
            AddBarButtonItem("Add <Item> +2 (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartPlusTwo)
            AddBarButtonItem("Add <Item> +3 (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartPlusThree)
            AddBarButtonItem("Add <Item> +4 (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartPlusFour)
            AddBarButtonItem("Add <Item> +5 (<Price>) To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartPlusFive)
            AddBarButtonItem("Add Custom <Item> To Basket", "", "shoppingbasket_add.png", AddressOf Commands.CartCustom)

            'inventory
            AddBarButtonItem("Activate", "", "gear_run.png", AddressOf Commands.Activate)
            AddBarButtonItem("Deactivate", "", "gear_stop.png", AddressOf Commands.Deactivate)
            AddBarButtonItem("Sell", "", "goldbars.png", AddressOf Commands.Sell)
            AddBarButtonItem("Combine Money", "", "goldbars.png", AddressOf Commands.CombineMoney)
            AddBarButtonItem("Scribe Scroll", "", "scroll_add.png", AddressOf Commands.ScribeScroll)
            AddBarButtonItem("Edit Scroll", "", "scroll_view.png", AddressOf Commands.EditScroll)
            AddBarButtonItem("Imprint Stone", "", "scroll_add.png", AddressOf Commands.ImprintPowerStone)
            AddBarButtonItem("Edit Stone", "", "scroll_view.png", AddressOf Commands.EditPowerStone)

            'printing
            AddBarButtonItem("Character Sheet", "", "document_view.png", AddressOf Commands.PrintCharacterSheet)
            AddBarButtonItem("Character XML", "", "document_view.png", AddressOf Commands.ShowCharacterXML)

            'misc
            AddBarButtonItem("Clear Portrait", "", "businessman_delete.png", AddressOf Commands.ClearPortrait)
            AddBarButtonItem("Create Class Levels", "", "row_add.png", AddressOf Commands.CreateClassLevels)
            AddBarButtonItem("&Rename", AddressOf Commands.Rename)
            AddBarButtonItem("Add Tags", "", "index_add.png", AddressOf Commands.AddTags)
            AddBarButtonItem("Remove Tags", "", "index_delete.png", AddressOf Commands.RemoveTags)

            'document viewer
            AddBarButtonItem("Rules Viewer", "RPGXplorer's very own electronic System Reference Document i.e. the 3.5 rules.", "book_blue.png", AddressOf Commands.ShowRulesViewer)

            'XML viewer
            AddBarButtonItem("XML Workshop", "View and apply transformations to XML outputs of your characters.", "hammer.png", AddressOf Commands.ShowCharacterXML)

            'add Character
            AddBarButtonItem("AddNewCharacter", "Add Character", "Create a new character.", "CharacterHumanMale.png", AddressOf Commands.AddCharacter)
            AddBarButtonItem("AddNewMonsterCharacter", "Add Monster Character", "Create a new character in the monsters folder.", "CharacterHumanMale.png", AddressOf Commands.AddMonsterCharacter)

            '---------------------------------------- Character Commands -----------------------------------------
            'add
            AddBarButtonItem("Add Feat(s)", "", "row_add.png", AddressOf Commands.AddFeat)
            AddBarButtonItem("Add Feature(s)", "", "row_add.png", AddressOf Commands.AddCharacterFeature)
            AddBarButtonItem("AddLanguageCharacter", "Add Language", "", "row_add.png", AddressOf Commands.AddCharacterLanguage)
            AddBarButtonItem("Add Domain", "", "row_add.png", AddressOf Commands.AddDomain)
            AddBarButtonItem("Add Specialist School", "", "row_add.png", AddressOf Commands.AddSpecialistSchool)
            AddBarButtonItem("Add Prohibited School", "", "row_add.png", AddressOf Commands.AddProhibitedSchool)
            AddBarButtonItem("Add User Modifier", "", "row_add.png", AddressOf Commands.AddUserModifier)

            AddBarButtonItem("Add Spell", "", "row_add.png", AddressOf Commands.CharacterAddSpell)
            AddBarButtonItem("Add Category Spell", "", "row_add.png", AddressOf Commands.CharacterAddSpellFromCategory)
            AddBarButtonItem("Add Domain Spell", "", "row_add.png", AddressOf Commands.CharacterAddSpellFromDomain)
            AddBarButtonItem("Synchronize Spell List", "", "refresh.png", AddressOf Commands.SyncSpells)

            AddBarButtonItem("AddSpellLikeTaken", "Add Spell Like Ability", "", "row_add.png", AddressOf Commands.AddSpellLikeTaken)
            AddBarButtonItem("AddPsiLikeTaken", "Add Psi Like Ability", "", "row_add.png", AddressOf Commands.AddPsiLikeTaken)

            'edit
            AddBarButtonItem("Edit Feat(s)", "", "form_blue.png", AddressOf Commands.EditFeat)
            AddBarButtonItem("Edit Feature(s)", "", "form_blue.png", AddressOf Commands.EditCharacterFeature)
            AddBarButtonItem("EditLanguageCharacter", "Edit Language", "", "form_blue.png", AddressOf Commands.EditCharacterLanguage)
            AddBarButtonItem("Edit Skill Ranks", "", "form_blue.png", AddressOf Commands.EditSkillRanks)
            AddBarButtonItem("Edit User Modifier", "", "form_blue.png", AddressOf Commands.EditUserModifier)

            AddBarButtonItem("EditSpellLikeTaken", "Edit Spell Like Ability", "", "form_blue.png", AddressOf Commands.EditSpellLikeTaken)
            AddBarButtonItem("EditPsiLikeTaken", "Edit Psi Like Ability", "", "form_blue.png", AddressOf Commands.EditPsiLikeTaken)

            'Delete
            AddBarButtonItem("Delete Level(s)", "", "row_delete.png", AddressOf Commands.DeleteCharacterLevel)

            'Enable
            AddBarButtonItem("Enable Feat(s)", "", "gear_run.png", AddressOf Commands.EnableObject)
            AddBarButtonItem("Enable Feature(s)", "", "gear_run.png", AddressOf Commands.EnableObject)
            AddBarButtonItem("Enable User Modifier(s)", "", "gear_run.png", AddressOf Commands.EnableObject)

            'Disable
            AddBarButtonItem("Disable Feat(s)", "", "gear_stop.png", AddressOf Commands.DisableObject)
            AddBarButtonItem("Disable Feature(s)", "", "gear_stop.png", AddressOf Commands.DisableObject)
            AddBarButtonItem("Disable User Modifier(s)", "", "gear_stop.png", AddressOf Commands.DisableObject)

            'Other
            AddBarButtonItem("Override Prerequisites", "", "gears_preferences.png", AddressOf Commands.OverrideFeatPrereq)
            AddBarButtonItem("Feature Edit Mode", "", "gears_preferences.png", AddressOf Commands.FeatureEditMode)
            AddBarButtonItem("Feature View Mode", "", "gears.png", AddressOf Commands.FeatureViewMode)
            AddBarButtonItem("Stop Overriding Prerequisites", "", "gears.png", AddressOf Commands.StopOverrideFeatPrereq)

            AddBarButtonItem("Update Memorized Spells", "", "memspell.png", AddressOf Commands.UpdateMemorizedSpells)

            '--------------------------------------- End Character Commands -----------------------------------------

            'spell list commands
            AddBarButtonItem("Add Spells", "", "row_add.png", AddressOf Commands.AddSpells)
            AddBarButtonItem("Remove Spell(s)", "", "row_delete.png", AddressOf Commands.RemoveSpell)

            'object specific commands
            'A, B, C, D, E

            'Add
            AddBarButtonItem("Add Ammunition Definition", "", "row_add.png", AddressOf Commands.AddAmmoDefinition)
            AddBarButtonItem("Add Armor or Shield Definition", "", "row_add.png", AddressOf Commands.AddArmorDefinition)
            AddBarButtonItem("Add Armor Magic Ability Definition", "", "row_add.png", AddressOf Commands.AddArmorMagicAbilityDefinition)
            AddBarButtonItem("Add Artifact Definition", "", "row_add.png", AddressOf Commands.AddArtifactDefinition)
            AddBarButtonItem("Add Bonus Class Skill", "", "row_add.png", AddressOf Commands.AddBonusClassSkill)
            AddBarButtonItem("Add Bonus Domain", "", "row_add.png", AddressOf Commands.AddBonusDomain)
            AddBarButtonItem("Add Bonus Feat", "", "row_add.png", AddressOf Commands.AddBonusFeat)
            AddBarButtonItem("Add Bonus Language", "", "row_add.png", AddressOf Commands.AddBonusLanguage)
            AddBarButtonItem("Add Character", "", "row_add.png", AddressOf Commands.AddCharacter)
            AddBarButtonItem("Add Level(s)", "", "magic-wand.png", AddressOf Commands.AddCharacterLevel)
            AddBarButtonItem("Add Choose Bonus Feat", "", "row_add.png", AddressOf Commands.AddChooseBonusFeat)
            AddBarButtonItem("Add Choose Bonus Feat of Type", "", "row_add.png", AddressOf Commands.AddChooseBonusFeatType)
            AddBarButtonItem("Add Choose Feature", "", "row_add.png", AddressOf Commands.AddChooseFeature)
            AddBarButtonItem("Add Class", "", "row_add.png", AddressOf Commands.AddClass)
            AddBarButtonItem("Add Class Level", "", "row_add.png", AddressOf Commands.AddClassLevel)
            AddBarButtonItem("Add Class Skill", "", "row_add.png", AddressOf Commands.AddClassSkill)
            AddBarButtonItem("Add Condition", "", "row_add.png", AddressOf Commands.AddCondition)
            AddBarButtonItem("Add Combat Style", "", "row_add.png", AddressOf Commands.AddCombatStyle)
            AddBarButtonItem("Add Damage Reduction", "", "row_add.png", AddressOf Commands.AddDamageReduction)
            AddBarButtonItem("Add Damage Resistance", "", "row_add.png", AddressOf Commands.AddDamageResistance)
            AddBarButtonItem("Add Deity Definition", "", "row_add.png", AddressOf Commands.AddDeityDefinition)
            AddBarButtonItem("Add Domain Definition", "", "row_add.png", AddressOf Commands.AddDomainDefinition)
            AddBarButtonItem("Add Enhancement Bonus", "", "row_add.png", AddressOf Commands.AddEnhancement)
            AddBarButtonItem("Add Expiry Condition", "", "row_add.png", AddressOf Commands.AddExpiryCondition)
            AddBarButtonItem("Add Extra Damage", "", "row_add.png", AddressOf Commands.AddDamageAddition)

            'Edit
            AddBarButtonItem("Edit Ammunition Definition", "", "form_blue.png", AddressOf Commands.EditAmmoDefinition)
            AddBarButtonItem("Edit Armor or Shield Definition", "", "form_blue.png", AddressOf Commands.EditArmorDefinition)
            AddBarButtonItem("Edit Armor Magic Ability Definition", "", "form_blue.png", AddressOf Commands.EditArmorMagicAbilityDefinition)
            AddBarButtonItem("Edit Artifact Definition", "", "form_blue.png", AddressOf Commands.EditArtifactDefinition)
            AddBarButtonItem("Edit Cannot Use", "", "form_blue.png", AddressOf Commands.EditCannotUse)
            AddBarButtonItem("Edit Character", "", "form_blue.png", AddressOf Commands.EditCharacter)
            AddBarButtonItem("Edit Choose Bonus Feat", "", "form_blue.png", AddressOf Commands.EditChooseBonusFeat)
            AddBarButtonItem("Edit Choose Bonus Feat of Type", "", "form_blue.png", AddressOf Commands.EditChooseBonusFeatType)
            AddBarButtonItem("Edit Choose Feature", "", "form_blue.png", AddressOf Commands.EditChooseFeature)
            AddBarButtonItem("Edit Class", "", "form_blue.png", AddressOf Commands.EditClass)
            AddBarButtonItem("Edit Class Level", "", "form_blue.png", AddressOf Commands.EditClassLevel)
            AddBarButtonItem("Edit Condition", "", "form_blue.png", AddressOf Commands.EditCondition)
            AddBarButtonItem("Edit Combat Style", "", "form_blue.png", AddressOf Commands.EditCombatStyle)
            AddBarButtonItem("Edit Curse", "", "form_blue.png", AddressOf Commands.EditCurse)
            AddBarButtonItem("Edit Damage Reduction", "", "form_blue.png", AddressOf Commands.EditDamageReduction)
            AddBarButtonItem("Edit Damage Resistance", "", "form_blue.png", AddressOf Commands.EditDamageResistance)
            AddBarButtonItem("Edit Damage Vulnerability", "", "form_blue.png", AddressOf Commands.EditDamageVulnerability)
            AddBarButtonItem("Edit Deity Definition", "", "form_blue.png", AddressOf Commands.EditDeityDefinition)
            AddBarButtonItem("Edit Domain Definition", "", "form_blue.png", AddressOf Commands.EditDomainDefinition)
            AddBarButtonItem("Edit Enhancement Bonus", "", "row_add.png", AddressOf Commands.EditEnhancement)
            AddBarButtonItem("Edit Expiry Condition", "", "form_blue.png", AddressOf Commands.EditExpiryCondition)
            AddBarButtonItem("Edit Extra Damage", "", "row_add.png", AddressOf Commands.EditDamageAddition)

            'object specific commands
            'F, G, H, I, J

            'Add
            AddBarButtonItem("Add Document", "", "row_add.png", AddressOf Commands.AddHTMLDoc)
            AddBarButtonItem("Add Feat Definition", "", "row_add.png", AddressOf Commands.AddFeatDefinition)
            AddBarButtonItem("Add Feature", "", "row_add.png", AddressOf Commands.AddFeature)
            AddBarButtonItem("Add Feature Definition", "", "row_add.png", AddressOf Commands.AddFeatureDefinition)
            AddBarButtonItem("Add Fighter Bonus Feat", "", "row_add.png", AddressOf Commands.AddFighterBonusFeat)
            AddBarButtonItem("Add Flurry of Blows", "", "row_add.png", AddressOf Commands.AddFlurryOfBlows)
            AddBarButtonItem("Add Folder", "", "folder_add.png", AddressOf Commands.AddFolder)
            AddBarButtonItem("Add Granted Power", "", "row_add.png", AddressOf Commands.AddGrantedPower)
            AddBarButtonItem("Add Intelligence", "", "row_add.png", AddressOf Commands.AddIntelligence)
            AddBarButtonItem("Add Item", "", "row_add.png", AddressOf Commands.AddItem)
            AddBarButtonItem("Add Item Definition", "", "row_add.png", AddressOf Commands.AddItemDefinition)

            'Edit
            AddBarButtonItem("Edit Document", "", "form_blue.png", AddressOf Commands.EditHTMLDoc)
            AddBarButtonItem("Edit Feat Definition", "", "form_blue.png", AddressOf Commands.EditFeatDefinition)
            AddBarButtonItem("Edit Feature", "", "form_blue.png", AddressOf Commands.EditFeature)
            AddBarButtonItem("Edit Feature Definition", "", "form_blue.png", AddressOf Commands.EditFeatureDefinition)
            AddBarButtonItem("Edit Flurry of Blows", "", "form_blue.png", AddressOf Commands.EditFlurryOfBlows)
            AddBarButtonItem("Edit Granted Power", "", "form_blue.png", AddressOf Commands.EditGrantedPower)
            AddBarButtonItem("Edit Intelligence", "", "form_blue.png", AddressOf Commands.EditIntelligence)
            AddBarButtonItem("Edit Item", "", "form_blue.png", AddressOf Commands.EditItem)
            AddBarButtonItem("Edit Item Definition", "", "form_blue.png", AddressOf Commands.EditItemDefinition)

            'object specific commands
            'K, L, M, N, O

            'Add
            AddBarButtonItem("Add Language", "", "row_add.png", AddressOf Commands.AddLanguage)
            AddBarButtonItem("Add Magic Ammo Definition", "", "row_add.png", AddressOf Commands.AddMagicAmmoDefinition)
            AddBarButtonItem("Add Modifier", "", "row_add.png", AddressOf Commands.AddModifier)
            AddBarButtonItem("Add Modifier Limiter", "", "row_add.png", AddressOf Commands.AddModifierLimiter)
            AddBarButtonItem("Add Money", "", "goldbar.png", AddressOf Commands.AddMoney)
            AddBarButtonItem("Add Monster Type", "", "row_add.png", AddressOf Commands.AddMonsterType)

            'Edit
            AddBarButtonItem("Edit Language", "", "form_blue.png", AddressOf Commands.EditLanguage)
            AddBarButtonItem("Edit Magic Ammo Definition", "", "form_blue.png", AddressOf Commands.EditMagicAmmoDefinition)
            AddBarButtonItem("Edit Modifier", "", "form_blue.png", AddressOf Commands.EditModifier)
            AddBarButtonItem("Edit Modifier Limiter", "", "form_blue.png", AddressOf Commands.EditModifierLimiter)
            AddBarButtonItem("Edit Money", "", "goldbar.png", AddressOf Commands.EditMoney)
            AddBarButtonItem("Edit Monster Type", "", "form_blue.png", AddressOf Commands.EditMonsterType)

            'object specific commands
            'P, Q, R

            'Add
            AddBarButtonItem("Add Potion Definition", "", "row_add.png", AddressOf Commands.AddPotionDefinition)
            AddBarButtonItem("Add Prerequisite", "", "row_add.png", AddressOf Commands.AddPrerequisite)
            AddBarButtonItem("Add Prestige Caster Progression", "", "row_add.png", AddressOf Commands.AddPrestigeSpellcastingClass)
            AddBarButtonItem("Add Race", "", "row_add.png", AddressOf Commands.AddRace)
            AddBarButtonItem("Add Racial Weapon", "", "row_add.png", AddressOf Commands.AddRacialWeapon)
            AddBarButtonItem("Add Regeneration", "", "row_add.png", AddressOf Commands.AddRegeneration)
            AddBarButtonItem("Add Replace Known Spell", "", "row_add.png", AddressOf Commands.AddReplaceKnownSpell)
            AddBarButtonItem("Add Ring Definition", "", "row_add.png", AddressOf Commands.AddRingDefinition)
            AddBarButtonItem("Add Rod Definition", "", "row_add.png", AddressOf Commands.AddRodDefinition)

            'Edit
            AddBarButtonItem("Edit Potion Definition", "", "form_blue.png", AddressOf Commands.EditPotionDefinition)
            AddBarButtonItem("Edit Prerequisite", "", "form_blue.png", AddressOf Commands.EditPrerequisite)
            AddBarButtonItem("Edit Race", "", "form_blue.png", AddressOf Commands.EditRace)
            AddBarButtonItem("Edit Racial Weapon", "", "form_blue.png", AddressOf Commands.EditRacialWeapon)
            AddBarButtonItem("Edit Regeneration", "", "form_blue.png", AddressOf Commands.EditRegeneration)
            AddBarButtonItem("Edit Ring Definition", "", "form_blue.png", AddressOf Commands.EditRingDefinition)
            AddBarButtonItem("Edit Rod Definition", "", "form_blue.png", AddressOf Commands.EditRodDefinition)
            AddBarButtonItem("Edit Rule Page", "", "document_edit.png", AddressOf Commands.EditRulePage)

            'object specific commands
            'Sa to Sp

            'Add 
            AddBarButtonItem("Add Scroll Definition", "", "row_add.png", AddressOf Commands.AddScrollDefinition)
            AddBarButtonItem("Add Set Value", "", "row_add.png", AddressOf Commands.AddSetValue)
            AddBarButtonItem("Add Skill Definition", "", "row_add.png", AddressOf Commands.AddSkillDefinition)
            AddBarButtonItem("Add Skill Synergy", "", "row_add.png", AddressOf Commands.AddSkillSynergy)
            AddBarButtonItem("Add Magic Armor Definition", "", "row_add.png", AddressOf Commands.AddSpecificArmorDefinition)
            AddBarButtonItem("Add Special Material Definition", "", "row_add.png", AddressOf Commands.AddSpecialMaterialDefinition)
            AddBarButtonItem("Add Specific Bonus Feat", "", "row_add.png", AddressOf Commands.AddSpecificBonusFeat)
            AddBarButtonItem("Add Specific Class Skill", "", "row_add.png", AddressOf Commands.AddSpecificOrChooseBonusClassSkill)
            AddBarButtonItem("Add Specific or Choose Bonus Class Skill", "", "row_add.png", AddressOf Commands.AddSpecificOrChooseBonusClassSkill)
            AddBarButtonItem("Add Specific or Choose Bonus Domain", "", "row_add.png", AddressOf Commands.AddSpecificOrChooseBonusDomain)
            AddBarButtonItem("Add Magic Weapon Definition", "", "row_add.png", AddressOf Commands.AddSpecificWeaponDefinition)
            AddBarButtonItem("Add Spell Category", "", "row_add.png", AddressOf Commands.AddSpellCategory)
            AddBarButtonItem("Add Spell Definition", "", "row_add.png", AddressOf Commands.AddSpellDefinition)
            AddBarButtonItem("Add Spell Descriptor", "", "row_add.png", AddressOf Commands.AddSpellDescriptor)
            AddBarButtonItem("Add Spell Failure", "", "row_add.png", AddressOf Commands.AddSpellFailure)
            AddBarButtonItem("Add Spell Resistance", "", "row_add.png", AddressOf Commands.AddSpellResistance)
            AddBarButtonItem("Add Spell School", "", "row_add.png", AddressOf Commands.AddSpellSchool)
            AddBarButtonItem("Add Spell Subschool", "", "row_add.png", AddressOf Commands.AddSpellSubschool)
            AddBarButtonItem("Add Spells Known", "", "row_add.png", AddressOf Commands.AddSpellsKnown)
            AddBarButtonItem("Add Spells Per Day", "", "row_add.png", AddressOf Commands.AddSpellsPerDay)

            'Edit
            AddBarButtonItem("Edit Scroll Definition", "", "form_blue.png", AddressOf Commands.EditScrollDefinition)
            AddBarButtonItem("Edit Set Value", "", "form_blue.png", AddressOf Commands.EditSetValue)
            AddBarButtonItem("Edit Skill Definition", "", "form_blue.png", AddressOf Commands.EditSkillDefinition)
            AddBarButtonItem("Edit Skill Synergy", "", "form_blue.png", AddressOf Commands.EditSkillSynergy)
            AddBarButtonItem("Edit Magic Armor Definition", "", "form_blue.png", AddressOf Commands.EditSpecificArmorDefinition)
            AddBarButtonItem("Edit Special Material Definition", "", "form_blue.png", AddressOf Commands.EditSpecialMaterialDefinition)
            AddBarButtonItem("Edit Specific Bonus Feat", "", "form_blue.png", AddressOf Commands.EditSpecificBonusFeat)
            AddBarButtonItem("Edit Specific Class Skill", "", "form_blue.png", AddressOf Commands.EditSpecificOrChooseBonusClassSkill)
            AddBarButtonItem("Edit Specific or Choose Bonus Class Skill", "", "form_blue.png", AddressOf Commands.EditSpecificOrChooseBonusClassSkill)
            AddBarButtonItem("Edit Specific or Choose Bonus Domain", "", "form_blue.png", AddressOf Commands.EditSpecificOrChooseBonusDomain)
            AddBarButtonItem("Edit Magic Weapon Definition", "", "form_blue.png", AddressOf Commands.EditSpecificWeaponDefinition)
            AddBarButtonItem("Edit Spell Category", "", "row_add.png", AddressOf Commands.EditSpellCategory)
            AddBarButtonItem("Edit Spell Definition", "", "row_add.png", AddressOf Commands.EditSpellDefinition)
            AddBarButtonItem("Edit Spell Descriptor", "", "row_add.png", AddressOf Commands.EditSpellDescriptor)
            AddBarButtonItem("Edit Spell Failure", "", "form_blue.png", AddressOf Commands.EditSpellFailure)
            AddBarButtonItem("Edit Spell Resistance", "", "form_blue.png", AddressOf Commands.EditSpellResistance)
            AddBarButtonItem("Edit Spell School", "", "form_blue.png", AddressOf Commands.EditSpellSchool)
            AddBarButtonItem("Edit Spell Subschool", "", "form_blue.png", AddressOf Commands.EditSpellSubschool)
            AddBarButtonItem("Edit Spells Known", "", "form_blue.png", AddressOf Commands.EditSpellsKnown)
            AddBarButtonItem("Edit Spells Per Day", "", "form_blue.png", AddressOf Commands.EditSpellsPerDay)

            'object specific commands
            'Sq to Sz

            'Add
            AddBarButtonItem("Add Staff Definition", "", "row_add.png", AddressOf Commands.AddStaffDefinition)
            AddBarButtonItem("Add System Ability", "", "row_add.png", AddressOf Commands.AddSystemAbility)
            AddBarButtonItem("Add System Ability Definition", "", "row_add.png", AddressOf Commands.AddSystemAbilityDefinition)
            AddBarButtonItem("Add System Alignment Definition", "", "row_add.png", AddressOf Commands.AddSystemAlignmentDefinition)
            AddBarButtonItem("Add System Condition", "", "row_add.png", AddressOf Commands.AddSystemCondition)
            AddBarButtonItem("Add System Element", "", "row_add.png", AddressOf Commands.AddSystemElement)
            AddBarButtonItem("Add System Precondition", "", "row_add.png", AddressOf Commands.AddSystemPrecondition)
            AddBarButtonItem("Add System Precondition Definition", "", "row_add.png", AddressOf Commands.AddSystemPreconditionDefinition)
            AddBarButtonItem("Add System Reference", "", "row_add.png", AddressOf Commands.AddSystemReference)
            AddBarButtonItem("Add System Restriction", "", "row_add.png", AddressOf Commands.AddSystemRestriction)
            AddBarButtonItem("Add System Restriction Definition", "", "row_add.png", AddressOf Commands.AddSystemRestrictionDefinition)
            AddBarButtonItem("Add System Weapon Ability", "", "row_add.png", AddressOf Commands.AddSystemWeaponAbility)
            AddBarButtonItem("Add System Weapon Ability Definition", "", "row_add.png", AddressOf Commands.AddSystemWeaponAbilityDefinition)

            'Edit
            AddBarButtonItem("Edit Staff Definition", "", "form_blue.png", AddressOf Commands.EditStaffDefinition)
            AddBarButtonItem("Edit System Ability", "", "form_blue.png", AddressOf Commands.EditSystemAbility)
            AddBarButtonItem("Edit System Ability Definition", "", "form_blue.png", AddressOf Commands.EditSystemAbilityDefinition)
            AddBarButtonItem("Edit System Alignment Definition", "", "form_blue.png", AddressOf Commands.EditSystemAlignmentDefinition)
            AddBarButtonItem("Edit System Condition", "", "form_blue.png", AddressOf Commands.EditSystemCondition)
            AddBarButtonItem("Edit System Element", "", "form_blue.png", AddressOf Commands.EditSystemElement)
            AddBarButtonItem("Edit System Precondition", "", "form_blue.png", AddressOf Commands.EditSystemPrecondition)
            AddBarButtonItem("Edit System Precondition Definition", "", "form_blue.png", AddressOf Commands.EditSystemPreconditionDefinition)
            AddBarButtonItem("Edit System Reference", "", "form_blue.png", AddressOf Commands.EditSystemReference)
            AddBarButtonItem("Edit System Restriction", "", "form_blue.png", AddressOf Commands.EditSystemRestriction)
            AddBarButtonItem("Edit System Restriction Definition", "", "form_blue.png", AddressOf Commands.EditSystemRestrictionDefinition)
            AddBarButtonItem("Edit System Weapon Ability", "", "form_blue.png", AddressOf Commands.EditSystemWeaponAbility)
            AddBarButtonItem("Edit System Weapon Ability Definition", "", "form_blue.png", AddressOf Commands.EditSystemWeaponAbilityDefinition)

            'object specific commands
            'T, U, V, W, X, Y, Z

            'Add
            AddBarButtonItem("Add Document Component", "", "document_add.png", AddressOf Commands.AddUserDocument)
            AddBarButtonItem("Add Map Component", "", "document_add.png", AddressOf Commands.AddUserMap)
            AddBarButtonItem("Add Rule Page Component", "", "document_add.png", AddressOf Commands.AddUserRulePage)
            AddBarButtonItem("Add Wand Definition", "", "row_add.png", AddressOf Commands.AddWandDefinition)
            AddBarButtonItem("Add Weapon Definition", "", "row_add.png", AddressOf Commands.AddWeaponDefinition)
            AddBarButtonItem("Add Weapon Emulation", "", "row_add.png", AddressOf Commands.AddWeaponEmulation)
            AddBarButtonItem("Add Weapon Magic Ability", "", "row_add.png", AddressOf Commands.AddWeaponMagicAbility)
            AddBarButtonItem("Add Weapon Magic Ability Definition", "", "row_add.png", AddressOf Commands.AddWeaponMagicAbilityDefinition)
            AddBarButtonItem("Add Wondrous Item Definition", "", "row_add.png", AddressOf Commands.AddWondrousDefinition)

            'Edit
            AddBarButtonItem("Edit Document Component", "", "document.png", AddressOf Commands.EditUserDocument)
            AddBarButtonItem("Edit Map Component", "", "document.png", AddressOf Commands.EditUserMap)
            AddBarButtonItem("Edit Rule Page Component", "", "document.png", AddressOf Commands.EditUserRulePage)
            AddBarButtonItem("Edit Wand Definition", "", "form_blue.png", AddressOf Commands.EditWandDefinition)
            AddBarButtonItem("Edit Weapon Definition", "", "form_blue.png", AddressOf Commands.EditWeaponDefinition)
            AddBarButtonItem("Edit Weapon Emulation", "", "form_blue.png", AddressOf Commands.EditWeaponEmulation)
            AddBarButtonItem("Edit Weapon Magic Ability", "", "row_add.png", AddressOf Commands.EditWeaponMagicAbility)
            AddBarButtonItem("Edit Weapon Magic Ability Definition", "", "row_add.png", AddressOf Commands.EditWeaponMagicAbilityDefinition)
            AddBarButtonItem("Edit Wondrous Item Definition", "", "form_blue.png", AddressOf Commands.EditWondrousDefinition)

            '------------------------------------------PSIONIC COMMANDS-------------------------------------------

            'Add
            AddBarButtonItem("Add Power Definition", "", "row_add.png", AddressOf Commands.AddPowerDefinition)
            AddBarButtonItem("Add Psionic Discipline", "", "row_add.png", AddressOf Commands.AddPsionicDisciplineDefinition)
            AddBarButtonItem("Add Psionic Subdiscipline", "", "row_add.png", AddressOf Commands.AddPsionicSubdisciple)
            AddBarButtonItem("Add Psionic Specialization", "", "row_add.png", AddressOf Commands.AddPsionicSpecializationDefinition)
            AddBarButtonItem("Add Prestige Manifester Progression", "", "row_add.png", AddressOf Commands.AddPrestigeManifestingClass)

            AddBarButtonItem("AddPsionicSpecializationCharacter", "Add Psionic Specialization", "", "row_add.png", AddressOf Commands.AddPsionicSpecialization)
            AddBarButtonItem("Add Power", "", "row_add.png", AddressOf Commands.CharacterAddPower)
            AddBarButtonItem("Add Specialization Power", "", "row_add.png", AddressOf Commands.CharacterAddPowerFromSpecialization)

            AddBarButtonItem("Add Dorje Definition", "", "row_add.png", AddressOf Commands.AddDorjeDefinition)
            AddBarButtonItem("Add Power Stone Definition", "", "row_add.png", AddressOf Commands.AddPowerStoneDefinition)
            AddBarButtonItem("Add Psicrown Definition", "", "row_add.png", AddressOf Commands.AddPsicrownDefinition)
            AddBarButtonItem("Add Universal Item Definition", "", "row_add.png", AddressOf Commands.AddUniversalDefinition)
            AddBarButtonItem("Add Psionic Weapon Definition", "", "row_add.png", AddressOf Commands.AddPsionicWeaponDefinition)
            AddBarButtonItem("Add Psionic Armor Definition", "", "row_add.png", AddressOf Commands.AddPsionicArmorDefinition)
            AddBarButtonItem("Add Psionic Weapon Ability  Definition", "", "row_add.png", AddressOf Commands.AddPsionicWeaponAbilityDefinition)
            AddBarButtonItem("Add Psionic Armor Ability Definition", "", "row_add.png", AddressOf Commands.AddPsionicArmorAbilityDefinition)

            AddBarButtonItem("Add Psionic Weapon Ability", "", "row_add.png", AddressOf Commands.AddPsionicWeaponAbility)
            AddBarButtonItem("Add Psionic Ammo Definition", "", "row_add.png", AddressOf Commands.AddPsionicAmmoDefinition)
            AddBarButtonItem("Add Psionic Tattoo Definition", "", "row_add.png", AddressOf Commands.AddPsionicTattooDefinition)
            AddBarButtonItem("Add Psionic Artifact Definition", "", "row_add.png", AddressOf Commands.AddPsionicArtifactDefinition)

            'Edit
            AddBarButtonItem("Edit Power Definition", "", "row_add.png", AddressOf Commands.EditPowerDefinition)
            AddBarButtonItem("Edit Psionic Discipline", "", "row_add.png", AddressOf Commands.EditPsionicDisciplineDefinition)
            AddBarButtonItem("Edit Psionic Subdiscipline", "", "row_add.png", AddressOf Commands.EditPsionicSubdiscip)
            AddBarButtonItem("Edit Psionic Specialization", "", "row_add.png", AddressOf Commands.EditPsionicSpecializationDefinition)
            AddBarButtonItem("Edit Power Progression", "", "row_add.png", AddressOf Commands.EditPowerProgression)

            AddBarButtonItem("Edit Dorje Definition", "", "row_add.png", AddressOf Commands.EditDorjeDefinition)
            AddBarButtonItem("Edit Power Stone Definition", "", "row_add.png", AddressOf Commands.EditPowerStoneDefinition)
            AddBarButtonItem("Edit Psicrown Definition", "", "row_add.png", AddressOf Commands.EditPsicrownDefinition)
            AddBarButtonItem("Edit Universal Item Definition", "", "row_add.png", AddressOf Commands.EditUniversalDefinition)
            AddBarButtonItem("Edit Psionic Weapon Definition", "", "row_add.png", AddressOf Commands.EditPsionicWeaponDefinition)
            AddBarButtonItem("Edit Psionic Armor Definition", "", "row_add.png", AddressOf Commands.EditPsionicArmorDefinition)
            AddBarButtonItem("Edit Psionic Weapon Ability  Definition", "", "row_add.png", AddressOf Commands.EditPsionicWeaponAbilityDefinition)
            AddBarButtonItem("Edit Psionic Armor Ability Definition", "", "row_add.png", AddressOf Commands.EditPsionicArmorAbilityDefinition)

            AddBarButtonItem("Edit Psionic Weapon Ability", "", "row_add.png", AddressOf Commands.EditPsionicWeaponAbility)
            AddBarButtonItem("Edit Psionic Ammo Definition", "", "row_add.png", AddressOf Commands.EditPsionicAmmoDefinition)
            AddBarButtonItem("Edit Psionic Tattoo Definition", "", "row_add.png", AddressOf Commands.EditPsionicTattooDefinition)
            AddBarButtonItem("Edit Psionic Artifact Definition", "", "row_add.png", AddressOf Commands.EditPsionicArtifactDefinition)


            'power list commands
            AddBarButtonItem("Add Powers", "", "row_add.png", AddressOf Commands.AddPowers)
            AddBarButtonItem("Remove Power(s)", "", "row_delete.png", AddressOf Commands.RemovePowers)

            AddBarButtonItem("Add Bonus Psionic Specialization", "", "row_add.png", AddressOf Commands.AddBonusPsionicSpecialization)
            AddBarButtonItem("Add Specific or Choose Bonus Psionic Specialization", "", "row_add.png", AddressOf Commands.AddSpecificOrChooseBonusPsionicSpecialization)
            AddBarButtonItem("Edit Specific or Choose Bonus Psionic Specialization", "", "form_blue.png", AddressOf Commands.EditSpecificOrChooseBonusPsionicSpecialization)
            '----------------------------------------END PSIONIC COMMANDS-----------------------------------------

            '1.9 familiar and stuff commands
            AddBarButtonItem("Add Companion", "", "row_add.png", AddressOf Commands.AddCompanion)
            AddBarButtonItem("Edit Companion", "", "form_blue.png", AddressOf Commands.EditCharacter)
            AddBarButtonItem("Add Monster Class", "", "row_add.png", AddressOf Commands.AddMonsterClass)
            AddBarButtonItem("Edit Monster Class", "", "form_blue.png", AddressOf Commands.EditMonsterClass)
            AddBarButtonItem("Add Monster Race", "", "row_add.png", AddressOf Commands.AddMonsterRace)
            AddBarButtonItem("Edit Monster Race", "", "form_blue.png", AddressOf Commands.EditMonsterRace)
            AddBarButtonItem("Add Set Ability", "", "row_add.png", AddressOf Commands.AddSetAbility)
            AddBarButtonItem("Edit Set Ability", "", "form_blue.png", AddressOf Commands.EditSetAbility)

            AddBarButtonItem("Add Skill Ability Exchange", "", "row_add.png", AddressOf Commands.AddSkillAbility)
            AddBarButtonItem("Edit Skill Ability Exchange", "", "form_blue.png", AddressOf Commands.EditSkillAbility)

            AddBarButtonItem("Add Natural Weapon Definition", "", "row_add.png", AddressOf Commands.AddNaturalWeaponDefinition)
            AddBarButtonItem("Edit Natural Weapon Definition", "", "form_blue.png", AddressOf Commands.EditNaturalWeaponDefinition)

            AddBarButtonItem("Add Subtype Definition", "", "row_add.png", AddressOf Commands.AddSubtypeDefinition)
            AddBarButtonItem("Edit Subtype Definition", "", "form_blue.png", AddressOf Commands.EditSubtypeDefinition)

            'add Companion button
            AddBarButtonItem("AddNewCompanion", "Add Companion", "Create a new animal companion, familiar, psicrystal, mount, special mount or fiendish servant.", "AnimalCompanion.png", AddressOf Commands.AddCompanion)
            AddBarButtonItem("AddNewMonsterCompanion", "Add Monster Companion", "Create a new animal companion, familiar, psicrystal, mount, special mount or fiendish servant.", "AnimalCompanion.png", AddressOf Commands.AddMonsterCompanion)

            '1.9.5 monster stuff
            AddBarButtonItem("Add Monster", "", "row_add.png", AddressOf Commands.AddMonster)
            AddBarButtonItem("Edit Monster", "", "form_blue.png", AddressOf Commands.EditMonster)

            AddBarButtonItem("Add Spell Like Ability", "", "row_add.png", AddressOf Commands.AddSpellLikeAbility)
            AddBarButtonItem("Edit Spell Like Ability", "", "form_blue.png", AddressOf Commands.EditSpellLikeAbility)

            AddBarButtonItem("Add Psi Like Ability", "", "row_add.png", AddressOf Commands.AddPsiLikeAbility)
            AddBarButtonItem("Edit Psi Like Ability", "", "form_blue.png", AddressOf Commands.EditPsiLikeAbility)

            '----------------------------------------END COMMANDS-----------------------------------------

            'build the menu
            BuildMainMenu()
            BuildToolbars()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update bar items according to config
    Public Shared Sub InitConfig()
        Dim BarButtonItem As BarButtonItem

        Try
            'data input
            'If General.DataInput Then
            '    BarButtonItem = CType(mBarManager.Items("DataInput"), BarButtonItem)
            '    BarButtonItem.Down = True
            'End If

            ''double click edits
            'If General.DoubleClickEdits Then
            '    BarButtonItem = CType(mBarManager.Items("DoubleClickEdits"), BarButtonItem)
            '    BarButtonItem.Down = True
            'End If

            'UI options            
            BarButtonItem = CType(mBarManager.Items("Folders"), BarButtonItem)
            'BarButtonItem.Down = True

            BarButtonItem = CType(mBarManager.Items("Browser"), BarButtonItem)
            'BarButtonItem.Down = True

            'marketprices
            CType(mBarManager.Items("MarketPrices"), BarEditItem).EditValue = General.MarketPrices

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'construct the main menu bar
    Private Shared Sub BuildMainMenu()
        Try
            mMenubar.ClearLinks()

            'add subitems to the menubar
            mMenubar.ItemLinks.Add(mBarManager.Items("File"))
            mMenubar.ItemLinks.Add(mBarManager.Items("Edit"))
            mMenubar.ItemLinks.Add(mBarManager.Items("Component"))
            mMenubar.ItemLinks.Add(mBarManager.Items("View"))
            mMenubar.ItemLinks.Add(mBarManager.Items("Tools"))
            mMenubar.ItemLinks.Add(mBarManager.Items("Window"))
            mMenubar.ItemLinks.Add(mBarManager.Items("Help"))

            'file menu
            AddLinkToMenu("File", "SaveDatabase")
            BeginGroup = True
            AddLinkToMenu("File", "LoadComponents")
            AddLinkToMenu("File", "SaveComponents")
            BeginGroup = True
            AddLinkToMenu("File", "ExportFilters")
            AddLinkToMenu("File", "ExportLists")
            BeginGroup = True
            AddLinkToMenu("File", "RefreshTree")
            BeginGroup = True
            AddLinkToMenu("File", "ExitApplication")

            'edit menu
            AddLinkToMenu("Edit", "Undo")
            BeginGroup = True
            AddLinkToMenu("Edit", "Cut")
            AddLinkToMenu("Edit", "Copy")
            AddLinkToMenu("Edit", "Paste")
            BeginGroup = True
            AddLinkToMenu("Edit", "SelectAll")
            BeginGroup = True
            AddLinkToMenu("Edit", "ClearClipboard")
            BeginGroup = True
            AddLinkToMenu("Edit", "Delete")

            'view menu
            AddLinkToMenu("View", "Icons")
            AddLinkToMenu("View", "Details")

            'tools menu
            AddLinkToMenu("Tools", "DataInput")
            AddLinkToMenu("Tools", "DoubleClickEdits")
            BeginGroup = True
            AddLinkToMenu("Tools", "Options")
            AddLinkToMenu("Tools", "EditaList")
            BeginGroup = True
            AddLinkToMenu("Tools", "RulesViewer")
            AddLinkToMenu("Tools", "XMLWorkshop")

            'help menu
            AddLinkToMenu("Help", "HelpContents")
            AddLinkToMenu("Help", "NewsandInfo")
            BeginGroup = True
            AddLinkToMenu("Help", "OpenGamingLicense")
            AddLinkToMenu("Help", "EndUserLicenseAgreement")
            BeginGroup = True
            AddLinkToMenu("Help", "About")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'construct the toolbars
    Private Shared Sub BuildToolbars()
        Try
            mToolbar.ClearLinks()

            'main
            AddBarItemToToolbar(mToolbar, "Folders", BarItemPaintStyle.CaptionGlyph)
            AddBarItemToToolbar(mToolbar, "Browser", BarItemPaintStyle.CaptionGlyph)
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "FolderUp")
            AddBarItemToToolbar(mToolbar, "FolderExpand")
            AddBarItemToToolbar(mToolbar, "ResetTree")
            AddBarItemToToolbar(mToolbar, "FolderCollapse")
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "Undo")
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "Cut")
            AddBarItemToToolbar(mToolbar, "Copy")
            AddBarItemToToolbar(mToolbar, "Paste")
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "ClearClipboard")
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "Delete")
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "Icons")
            AddBarItemToToolbar(mToolbar, "Details")
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "DataInput", BarItemPaintStyle.CaptionGlyph)
            AddBarItemToToolbar(mToolbar, "DoubleClickEdits", BarItemPaintStyle.CaptionGlyph)
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "RulesViewer", BarItemPaintStyle.CaptionGlyph)
            BeginGroup = True
            AddBarItemToToolbar(mToolbar, "XMLWorkshop", BarItemPaintStyle.CaptionGlyph)

            'filter bar
            mFilterBar.ClearLinks()
            AddBarItemToToolbar(mFilterBar, "CurrentFilter", BarItemPaintStyle.CaptionInMenu)
            AddBarItemToToolbar(mFilterBar, "ClearFilter", BarItemPaintStyle.Caption)
            BeginGroup = True
            AddBarItemToToolbar(mFilterBar, "Filters", BarItemPaintStyle.CaptionGlyph)

            'command bars
            AddBarItemToToolbar(mMarketplaceBar, "AddRules", BarItemPaintStyle.CaptionGlyph)
            BeginGroup = True
            AddBarItemToToolbar(mMarketplaceBar, "AddCharacters", BarItemPaintStyle.CaptionGlyph)
            'AddBarItemToToolbar(mMarketplaceBar, "AddNewCharacter", BarItemPaintStyle.CaptionGlyph)
            BeginGroup = True
            AddBarItemToToolbar(mMarketplaceBar, "AddCompanions", BarItemPaintStyle.CaptionGlyph)
            'AddBarItemToToolbar(mMarketplaceBar, "AddNewCompanion", BarItemPaintStyle.CaptionGlyph)

            'other bars
            BeginGroup = True
            AddBarItemToToolbar(mMarketplaceBar, "Marketplace", BarItemPaintStyle.CaptionGlyph)
            BeginGroup = True
            AddBarItemToToolbar(mMarketplaceBar, "MarketPrices", BarItemPaintStyle.CaptionGlyph)

            'charaters
            AddLinkToSubItem("AddCharacters", "AddNewCharacter")
            AddLinkToSubItem("AddCharacters", "AddNewMonsterCharacter")

            'companions
            AddLinkToSubItem("AddCompanions", "AddNewCompanion")
            AddLinkToSubItem("AddCompanions", "AddNewMonsterCompanion")

            'rulesbar
            AddLinkToSubItem("AddRules", "AddAmmunitionDefinition")
            AddLinkToSubItem("AddRules", "AddArmororShieldDefinition")
            AddLinkToSubItem("AddRules", "AddClass")
            AddLinkToSubItem("AddRules", "AddDeityDefinition")
            AddLinkToSubItem("AddRules", "AddDomainDefinition")
            AddLinkToSubItem("AddRules", "AddFeatDefinition")
            AddLinkToSubItem("AddRules", "AddFeatureDefinition")
            AddLinkToSubItem("AddRules", "AddItemDefinition")
            AddLinkToSubItem("AddRules", "AddLanguage")
            AddLinkToSubItem("AddRules", "AddMagicItems")
            AddLinkToSubItem("AddRules", "AddModifierLimiter")
            AddLinkToSubItem("AddRules", "AddMonsterClass")
            AddLinkToSubItem("AddRules", "AddMonsterRace")
            AddLinkToSubItem("AddRules", "AddNaturalWeaponDefinition")
            AddLinkToSubItem("AddRules", "AddPowerDefinition")
            AddLinkToSubItem("AddRules", "AddPsionicDiscipline")
            AddLinkToSubItem("AddRules", "AddPsionicItems")
            AddLinkToSubItem("AddRules", "AddPsionicSpecialization")
            AddLinkToSubItem("AddRules", "AddRace")
            AddLinkToSubItem("AddRules", "AddSkillDefinition")
            AddLinkToSubItem("AddRules", "AddSpellCategory")
            AddLinkToSubItem("AddRules", "AddSpellDefinition")
            AddLinkToSubItem("AddRules", "AddSpellDescriptor")
            AddLinkToSubItem("AddRules", "AddSpellSchool")
            AddLinkToSubItem("AddRules", "AddSubtypeDefinition")
            AddLinkToSubItem("AddRules", "AddWeaponDefinition")

            'magicbar
            AddLinkToSubItem("AddMagicItems", "AddArmorMagicAbilityDefinition")
            AddLinkToSubItem("AddMagicItems", "AddArtifactDefinition")
            AddLinkToSubItem("AddMagicItems", "AddMagicAmmoDefinition")
            AddLinkToSubItem("AddMagicItems", "AddMagicArmorDefinition")
            AddLinkToSubItem("AddMagicItems", "AddMagicWeaponDefinition")
            AddLinkToSubItem("AddMagicItems", "AddPotionDefinition")
            AddLinkToSubItem("AddMagicItems", "AddRingDefinition")
            AddLinkToSubItem("AddMagicItems", "AddRodDefinition")
            AddLinkToSubItem("AddMagicItems", "AddScrollDefinition")
            AddLinkToSubItem("AddMagicItems", "AddStaffDefinition")
            AddLinkToSubItem("AddMagicItems", "AddWandDefinition")
            AddLinkToSubItem("AddMagicItems", "AddWeaponMagicAbilityDefinition")
            AddLinkToSubItem("AddMagicItems", "AddWondrousItemDefinition")

            'psionicbar
            AddLinkToSubItem("AddPsionicItems", "AddDorjeDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPowerStoneDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsicrownDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicAmmoDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicArmorAbilityDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicArmorDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicArtifactDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicTattooDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicWeaponAbilityDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddPsionicWeaponDefinition")
            AddLinkToSubItem("AddPsionicItems", "AddUniversalItemDefinition")

        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'build the popup menu
    Public Shared Sub BuildComponentMenu()
        Dim BarSubItem As BarSubItem

        Try
            BarSubItem = CType(mBarManager.Items("Component"), BarSubItem)
            BarSubItem.ClearLinks()

            Dim Selected As Objects.ObjectDataCollection = General.MainExplorer.CurrentSelectedObjects

            'if selection contains all manufactured objects then don't show component menu
            If Selected.Count = 0 And General.MainExplorer.SelectedObjectCount > 0 Then Exit Sub

            'component commands
            BuildCommands(General.MainExplorer.CurrentSelectedObjects)

            BeginGroup = True

            'printing
            If PrintCharacterSheet Then
                AddLinkToMenu("Component", "CharacterSheet")
                AddLinkToMenu("Component", "CustomOutputs")
            End If

            If ShowCharacterXML Then AddLinkToMenu("Component", "CharacterXML")

            'inventory specific
            If Activate Then AddLinkToMenu("Component", "Activate")
            If Deactivate Then AddLinkToMenu("Component", "Deactivate")

            BeginGroup = True

            If Sell Then AddLinkToMenu("Component", "Sell")
            If CombineMoney Then AddLinkToMenu("Component", "CombineMoney")

            BeginGroup = True

            If ScribeScroll Then AddLinkToMenu("Component", "ScribeScroll")
            If EditScroll Then AddLinkToMenu("Component", "EditScroll")
            If ImprintStone Then AddLinkToMenu("Component", "ImprintStone")
            If EditStone Then AddLinkToMenu("Component", "EditStone")

            BeginGroup = True

            'edit buttons
            If EditAmmoDefinition Then AddLinkToMenu("Component", "EditAmmunitionDefinition")
            If EditArmorDefinition Then AddLinkToMenu("Component", "EditArmororShieldDefinition")
            If EditArmorMagicAbility Then AddLinkToMenu("Component", "EditArmorMagicAbilityDefinition")
            If EditArtifact Then AddLinkToMenu("Component", "EditArtifactDefinition")
            If EditCannotUse Then AddLinkToMenu("Component", "EditCannot Use")
            If EditCharacter Then AddLinkToMenu("Component", "EditCharacter")
            If EditCharacteristic Then AddLinkToMenu("Component", "EditCharacteristic")
            If EditChooseBonusFeat Then AddLinkToMenu("Component", "EditChooseBonusFeat")
            If EditChooseBonusFeatOfType Then AddLinkToMenu("Component", "EditChooseBonusFeatofType")
            If EditChooseFeature Then AddLinkToMenu("Component", "EditChooseFeature")
            If EditClass Then AddLinkToMenu("Component", "EditClass")
            If EditClassLevel Then AddLinkToMenu("Component", "EditClassLevel")
            If EditCondition Then AddLinkToMenu("Component", "EditCondition")
            If EditCombatStyle Then AddLinkToMenu("Component", "EditCombatStyle")
            If EditCurse Then AddLinkToMenu("Component", "EditCurse")
            If EditDamageAddition Then AddLinkToMenu("Component", "EditExtraDamage")
            If EditDamageReduction Then AddLinkToMenu("Component", "EditDamageReduction")
            If EditDamageResistance Then AddLinkToMenu("Component", "EditDamageResistance")
            If EditDamageVulnerability Then AddLinkToMenu("Component", "EditDamageVulnerability")
            If EditDeityDefinition Then AddLinkToMenu("Component", "EditDeityDefinition")
            If EditDiscipline Then AddLinkToMenu("Component", "EditPsionicDisciplineDefinition")
            If EditDisciplineSpecialization Then AddLinkToMenu("Component", "EditPsionicSpecialization")
            If EditDomainDefinition Then AddLinkToMenu("Component", "EditDomainDefinition")
            If EditDorjeDefinition Then AddLinkToMenu("Component", "EditDorjeDefinition")
            If EditEnhancement Then AddLinkToMenu("Component", "EditEnhancementBonus")
            If EditExpiryCondition Then AddLinkToMenu("Component", "EditExpiryCondition")
            If EditCompanion Then AddLinkToMenu("Component", "EditCompanion")
            If EditFeatDefinition Then AddLinkToMenu("Component", "EditFeatDefinition")
            If EditFeature Then AddLinkToMenu("Component", "EditFeature")
            If EditFeatureDefinition Then AddLinkToMenu("Component", "EditFeatureDefinition")
            If EditFlurryOfBlows Then AddLinkToMenu("Component", "EditFlurryofBlows")
            If EditGrantedPower Then AddLinkToMenu("Component", "EditGrantedPower")
            If EditHTMLDoc Then AddLinkToMenu("Component", "EditDocument")
            If EditIntelligence Then AddLinkToMenu("Component", "EditIntelligence")
            If EditItem Then AddLinkToMenu("Component", "EditItem")
            If EditItemDefinition Then AddLinkToMenu("Component", "EditItemDefinition")
            If EditLanguage Then AddLinkToMenu("Component", "EditLanguage")
            If EditMagicAmmoDefinition Then AddLinkToMenu("Component", "EditMagicAmmoDefinition")
            If EditModifier Then AddLinkToMenu("Component", "EditModifier")
            If EditModifierLimiter Then AddLinkToMenu("Component", "EditModifierLimiter")
            If EditMoney Then AddLinkToMenu("Component", "EditMoney")
            If EditMonster Then AddLinkToMenu("Component", "EditMonster")
            If EditMonsterClass Then AddLinkToMenu("Component", "EditMonsterClass")
            If EditMonsterRace Then AddLinkToMenu("Component", "EditMonsterRace")
            If EditMonsterType Then AddLinkToMenu("Component", "EditMonsterType")
            If EditNaturalWeapon Then AddLinkToMenu("Component", "EditNaturalWeaponDefinition")
            If EditPotionDefinition Then AddLinkToMenu("Component", "EditPotionDefinition")
            If EditPower Then AddLinkToMenu("Component", "EditPowerDefinition")
            If EditPowerProgression Then AddLinkToMenu("Component", "EditPowerProgression")
            If EditPowerStoneDefinition Then AddLinkToMenu("Component", "EditPowerStoneDefinition")
            If EditPrerequisite Then AddLinkToMenu("Component", "EditPrerequisite")
            If EditPsicrownDefinition Then AddLinkToMenu("Component", "EditPsicrownDefinition")
            If EditPsiLikeAbility Then AddLinkToMenu("Component", "EditPsiLikeAbility")
            If EditPsiLikeAbilityTaken Then AddLinkToMenu("Component", "EditPsiLikeTaken")
            If EditPsionicAmmoDefinition Then AddLinkToMenu("Component", "EditPsionicAmmoDefinition")
            If EditPsionicArmorAbilityDefinition Then AddLinkToMenu("Component", "EditPsionicArmorAbilityDefinition")
            If EditPsionicArmorDefinition Then AddLinkToMenu("Component", "EditPsionicArmorDefinition")
            If EditPsionicArtifactDefinition Then AddLinkToMenu("Component", "EditPsionicArtifactDefinition")
            If EditPsionicTattooDefinition Then AddLinkToMenu("Component", "EditPsionicTattooDefinition")
            If EditPsionicWeaponAbility Then AddLinkToMenu("Component", "EditPsionicWeaponAbility")
            If EditPsionicWeaponAbilityDefinition Then AddLinkToMenu("Component", "EditPsionicWeaponAbilityDefinition")
            If EditPsionicWeaponDefinition Then AddLinkToMenu("Component", "EditPsionicWeaponDefinition")
            If EditRace Then AddLinkToMenu("Component", "EditRace")
            If EditRacialWeapon Then AddLinkToMenu("Component", "EditRacialWeapon")
            If EditRegeneration Then AddLinkToMenu("Component", "EditRegeneration")
            If EditRingDefinition Then AddLinkToMenu("Component", "EditRingDefinition")
            If EditRodDefinition Then AddLinkToMenu("Component", "EditRodDefinition")
            If EditScrollDefinition Then AddLinkToMenu("Component", "EditScrollDefinition")
            If EditSetAbility Then AddLinkToMenu("Component", "EditSetAbility")
            If EditSetValue Then AddLinkToMenu("Component", "EditSetValue")
            If EditSkillDefinition Then AddLinkToMenu("Component", "EditSkillDefinition")
            If EditSkillExchange Then AddLinkToMenu("Component", "EditSkillAbilityExchange")
            If EditSkillSynergy Then AddLinkToMenu("Component", "EditSkillSynergy")
            If EditSpecialMaterialDefinition Then AddLinkToMenu("Component", "EditSpecialMaterialDefinition")
            If EditSpecificArmorDefinition Then AddLinkToMenu("Component", "EditMagicArmorDefinition")
            If EditSpecificBonusFeat Then AddLinkToMenu("Component", "EditSpecificBonusFeat")
            If EditSpecificClassSkill Then AddLinkToMenu("Component", "EditSpecificClassSkill")
            If EditSpecificChooseBonusClassSkill Then AddLinkToMenu("Component", "EditSpecificorChooseBonusClassSkill")
            If EditSpecificChooseBonusDomain Then AddLinkToMenu("Component", "EditSpecificorChooseBonusDomain")
            If EditSpecificOrChooseBonusPsionicSpecialization Then AddLinkToMenu("Component", "EditSpecificorChooseBonusPsionicSpecialization")
            If EditSpecificWeaponDefinition Then AddLinkToMenu("Component", "EditMagicWeaponDefinition")
            If EditSpellDefinition Then AddLinkToMenu("Component", "EditSpellDefinition")
            If EditSpellDescriptor Then AddLinkToMenu("Component", "EditSpellDescriptor")
            If EditSpellFailure Then AddLinkToMenu("Component", "EditSpellFailure")
            If EditSpellLikeAbility Then AddLinkToMenu("Component", "EditSpellLikeAbility")
            If EditSpellLikeAbilityTaken Then AddLinkToMenu("Component", "EditSpellLikeTaken")
            If EditSpellsKnown Then AddLinkToMenu("Component", "EditSpellsKnown")
            If EditSpellSchool Then AddLinkToMenu("Component", "EditSpellSchool")
            If EditSpellSubschool Then AddLinkToMenu("Component", "EditSpellSubschool")
            If EditSpellsPerDay Then AddLinkToMenu("Component", "EditSpellsPerDay")
            If EditStaff Then AddLinkToMenu("Component", "EditStaffDefinition")
            If EditSubdiscipline Then AddLinkToMenu("Component", "EditPsionicSubdiscipline")
            If EditSubtype Then AddLinkToMenu("Component", "EditSubtypeDefinition")
            If EditSystemAbility Then AddLinkToMenu("Component", "EditSystemAbility")
            If EditSystemAbilityDefinition Then AddLinkToMenu("Component", "EditSystemAbilityDefinition")
            If EditSystemAlignmentDefinition Then AddLinkToMenu("Component", "EditSystemAlignmentDefinition")
            If EditSystemCondition Then AddLinkToMenu("Component", "EditSystemCondition")
            If EditSystemElement Then AddLinkToMenu("Component", "EditSystemElement")
            If EditSystemPrecondition Then AddLinkToMenu("Component", "EditSystemPrecondition")
            If EditSystemPreconditionDefinition Then AddLinkToMenu("Component", "EditSystemPreconditionDefinition")
            If EditSystemReference Then AddLinkToMenu("Component", "EditSystemReference")
            If EditSystemRestriction Then AddLinkToMenu("Component", "EditSystemRestriction")
            If EditSystemRestrictionDefinition Then AddLinkToMenu("Component", "EditSystemRestrictionDefinition")
            If EditSystemWeaponAbility Then AddLinkToMenu("Component", "EditSystemWeaponAbility")
            If EditSystemWeaponAbilityDefinition Then AddLinkToMenu("Component", "EditSystemWeaponAbilityDefinition")
            If EditUniversalItemDefinition Then AddLinkToMenu("Component", "EditUniversalItemDefinition")
            If EditUserDoc Then AddLinkToMenu("Component", "EditDocumentComponent")
            If EditUserMap Then AddLinkToMenu("Component", "EditMapComponent")
            If EditUserRule Then AddLinkToMenu("Component", "EditRulePageComponent")
            If EditWand Then AddLinkToMenu("Component", "EditWandDefinition")
            If EditWeapon Then AddLinkToMenu("Component", "EditWeaponDefinition")
            If EditWeaponEmulation Then AddLinkToMenu("Component", "EditWeaponEmulation")
            If EditWeaponMagicAbility Then AddLinkToMenu("Component", "EditWeaponMagicAbility")
            If EditWeaponMagicAbilityDefinition Then AddLinkToMenu("Component", "EditWeaponMagicAbilityDefinition")
            If EditWondrous Then AddLinkToMenu("Component", "EditWondrousItemDefinition")

            BeginGroup = True

            'AddLinkToMenu("Component", "ApplyTemplate")

            BeginGroup = True

            'add buttons
            If Commands.EditForm Is Nothing Then

                If CreateClassLevels Then AddLinkToMenu("Component", "CreateClassLevels")

                BeginGroup = True

                If AddAmmoDefinition Then AddLinkToMenu("Component", "AddAmmunitionDefinition")
                If AddArmorDefinition Then AddLinkToMenu("Component", "AddArmororShieldDefinition")
                If AddArmorMagicAbility Then AddLinkToMenu("Component", "AddArmorMagicAbilityDefinition")
                If AddArtifact Then AddLinkToMenu("Component", "AddArtifactDefinition")
                If AddBonusClassSkill Then AddLinkToMenu("Component", "AddBonusClassSkill")
                If AddBonusDomain Then AddLinkToMenu("Component", "AddBonusDomain")
                If AddBonusFeat Then AddLinkToMenu("Component", "AddBonusFeat")
                If AddBonusLanguage Then AddLinkToMenu("Component", "AddBonusLanguage")
                If AddBonusPsionicSpecialization Then AddLinkToMenu("Component", "AddBonusPsionicSpecialization")
                If AddCannotUse Then AddLinkToMenu("Component", "AddCannotUse")
                If AddCharacter Then AddLinkToMenu("Component", "AddCharacter")
                If AddCharacteristic Then AddLinkToMenu("Component", "AddCharacteristic")
                If AddCharacterLevels Then AddLinkToMenu("Component", "AddLevel(s)")
                If AddChooseBonusFeat Then AddLinkToMenu("Component", "AddChooseBonusFeat")
                If AddChooseBonusFeatOfType Then AddLinkToMenu("Component", "AddChooseBonusFeatofType")
                If AddChooseFeature Then AddLinkToMenu("Component", "AddChooseFeature")
                If AddClass Then AddLinkToMenu("Component", "AddClass")
                If AddClassLevel Then AddLinkToMenu("Component", "AddClassLevel")
                If AddClassSkill Then AddLinkToMenu("Component", "AddClassSkill")
                If AddCondition Then AddLinkToMenu("Component", "AddCondition")
                If AddCombatStyle Then AddLinkToMenu("Component", "AddCombatStyle")
                If AddCurse Then AddLinkToMenu("Component", "AddCurse")
                If AddDamageAddition Then AddLinkToMenu("Component", "AddExtraDamage")
                If AddDamageReduction Then AddLinkToMenu("Component", "AddDamageReduction")
                If AddDamageResistance Then AddLinkToMenu("Component", "AddDamageResistance")
                If AddDamageVulnerability Then AddLinkToMenu("Component", "AddDamageVulnerability")
                If AddDeityDefinition Then AddLinkToMenu("Component", "AddDeityDefinition")
                If AddDiscipline Then AddLinkToMenu("Component", "AddPsionicDiscipline")
                If AddDisciplineSpecialization Then AddLinkToMenu("Component", "AddPsionicSpecialization")
                If AddDomainDefinition Then AddLinkToMenu("Component", "AddDomainDefinition")
                If AddDorjeDefinition Then AddLinkToMenu("Component", "AddDorjeDefinition")
                If AddEnhancement Then AddLinkToMenu("Component", "AddEnhancementBonus")
                If AddPrestigeCasterProgression Then AddLinkToMenu("Component", "AddPrestigeCasterProgression")
                If AddPrestigeManifesterProgression Then AddLinkToMenu("Component", "AddPrestigeManifesterProgression")
                If AddExpiryCondition Then AddLinkToMenu("Component", "AddExpiryCondition")
                If AddCompanion Then AddLinkToMenu("Component", "AddCompanion")
                If AddFeatDefinition Then AddLinkToMenu("Component", "AddFeatDefinition")
                If AddFeature Then AddLinkToMenu("Component", "AddFeature")
                If AddFeatureDefinition Then AddLinkToMenu("Component", "AddFeatureDefinition")
                If AddFighterBonusFeat Then AddLinkToMenu("Component", "AddFighterBonusFeat")
                If AddFlurryOfBlows Then AddLinkToMenu("Component", "AddFlurryofBlows")
                If AddFolder Then AddLinkToMenu("Component", "AddFolder")
                If AddGrantedPower Then AddLinkToMenu("Component", "AddGrantedPower")
                If AddHTMLDoc Then AddLinkToMenu("Component", "AddDocument")
                If AddIntelligence Then AddLinkToMenu("Component", "AddIntelligence")
                If AddItem Then AddLinkToMenu("Component", "AddItem")
                If AddItemDefinition Then AddLinkToMenu("Component", "AddItemDefinition")
                If AddLanguage Then AddLinkToMenu("Component", "AddLanguage")
                If AddLocation Then AddLinkToMenu("Component", "AddLocation")
                If AddMagicAmmoDefinition Then AddLinkToMenu("Component", "AddMagicAmmoDefinition")
                If AddModifier Then AddLinkToMenu("Component", "AddModifier")
                If AddModifierLimiter Then AddLinkToMenu("Component", "AddModifierLimiter")
                If AddMoney Then AddLinkToMenu("Component", "AddMoney")
                If AddMonster Then AddLinkToMenu("Component", "AddMonster")
                If AddMonsterClass Then AddLinkToMenu("Component", "AddMonsterClass")
                If AddMonsterRace Then AddLinkToMenu("Component", "AddMonsterRace")
                If AddMonsterType Then AddLinkToMenu("Component", "AddMonsterType")
                If AddNaturalWeapon Then AddLinkToMenu("Component", "AddNaturalWeaponDefinition")
                If AddPotionDefinition Then AddLinkToMenu("Component", "AddPotionDefinition")
                If AddPower Then AddLinkToMenu("Component", "AddPowerDefinition")
                If AddPowerStoneDefinition Then AddLinkToMenu("Component", "AddPowerStoneDefinition")
                If AddPrerequisite Then AddLinkToMenu("Component", "AddPrerequisite")
                If AddPsicrownDefinition Then AddLinkToMenu("Component", "AddPsicrownDefinition")
                If AddPsiLikeAbility Then AddLinkToMenu("Component", "AddPsiLikeAbility")
                If AddPsiLikeAbilityTaken Then AddLinkToMenu("Component", "AddPsiLikeTaken")
                If AddPsionicAmmoDefinition Then AddLinkToMenu("Component", "AddPsionicAmmoDefinition")
                If AddPsionicArmorAbilityDefinition Then AddLinkToMenu("Component", "AddPsionicArmorAbilityDefinition")
                If AddPsionicArmorDefinition Then AddLinkToMenu("Component", "AddPsionicArmorDefinition")
                If AddPsionicArtifactDefinition Then AddLinkToMenu("Component", "AddPsionicArtifactDefinition")
                If AddPsionicTattooDefinition Then AddLinkToMenu("Component", "AddPsionicTattooDefinition")
                If AddPsionicWeaponAbility Then AddLinkToMenu("Component", "AddPsionicWeaponAbility")
                If AddPsionicWeaponAbilityDefinition Then AddLinkToMenu("Component", "AddPsionicWeaponAbilityDefinition")
                If AddPsionicWeaponDefinition Then AddLinkToMenu("Component", "AddPsionicWeaponDefinition")
                If AddRace Then AddLinkToMenu("Component", "AddRace")
                If AddRacialWeapon Then AddLinkToMenu("Component", "AddRacialWeapon")
                If AddRegeneration Then AddLinkToMenu("Component", "AddRegeneration")
                If AddReplaceKnownSpell Then AddLinkToMenu("Component", "AddReplaceKnownSpell")
                If AddRingDefinition Then AddLinkToMenu("Component", "AddRingDefinition")
                If AddRodDefinition Then AddLinkToMenu("Component", "AddRodDefinition")
                If AddScrollDefinition Then AddLinkToMenu("Component", "AddScrollDefinition")
                If AddSetAbility Then AddLinkToMenu("Component", "AddSetAbility")
                If AddSetValue Then AddLinkToMenu("Component", "AddSetValue")
                If AddSkillDefinition Then AddLinkToMenu("Component", "AddSkillDefinition")
                If AddSkillExchange Then AddLinkToMenu("Component", "AddSkillAbilityExchange")
                If AddSkillSynergy Then AddLinkToMenu("Component", "AddSkillSynergy")
                If AddSpecialMaterialDefinition Then AddLinkToMenu("Component", "AddSpecialMaterialDefinition")
                If AddSpecificBonusFeat Then AddLinkToMenu("Component", "AddSpecificBonusFeat")
                If AddSpecificClassSkill Then AddLinkToMenu("Component", "AddSpecificClassSkill")
                If AddSpecificChooseBonusClassSkill Then AddLinkToMenu("Component", "AddSpecificorChooseBonusClassSkill")
                If AddSpecificChooseBonusDomain Then AddLinkToMenu("Component", "AddSpecificorChooseBonusDomain")
                If AddSpecificOrChooseBonusPsionicSpecialization Then AddLinkToMenu("Component", "AddSpecificorChooseBonusPsionicSpecialization")
                If AddSpecificArmorDefinition Then AddLinkToMenu("Component", "AddMagicArmorDefinition")
                If AddSpecificWeaponDefinition Then AddLinkToMenu("Component", "AddMagicWeaponDefinition")
                If AddSpellCategory Then AddLinkToMenu("Component", "AddSpellDefinition")
                If AddSpellDefinition Then AddLinkToMenu("Component", "AddSpellDefinition")
                If AddSpellDescriptor Then AddLinkToMenu("Component", "AddSpellDescriptor")
                If AddSpellFailure Then AddLinkToMenu("Component", "AddSpellFailure")
                If AddSpellLikeAbility Then AddLinkToMenu("Component", "AddSpellLikeAbility")
                If AddSpellLikeAbilityTaken Then AddLinkToMenu("Component", "AddSpellLikeTaken")
                If AddSpellsKnown Then AddLinkToMenu("Component", "AddSpellsKnown")
                If AddSpellSchool Then AddLinkToMenu("Component", "AddSpellSchool")
                If AddSpellSubschool Then AddLinkToMenu("Component", "AddSpellSubschool")
                If AddSpellsPerDay Then AddLinkToMenu("Component", "AddSpellsPerDay")
                If AddStaff Then AddLinkToMenu("Component", "AddStaffDefinition")
                If AddSubdiscipline Then AddLinkToMenu("Component", "AddPsionicSubdiscipline")
                If AddSubtype Then AddLinkToMenu("Component", "AddSubtypeDefinition")
                If AddSystemAbility Then AddLinkToMenu("Component", "AddSystemAbility")
                If AddSystemAbilityDefinition Then AddLinkToMenu("Component", "AddSystemAbilityDefinition")
                If AddSystemAlignmentDefinition Then AddLinkToMenu("Component", "AddSystemAlignmentDefinition")
                If AddSystemCondition Then AddLinkToMenu("Component", "AddSystemCondition")
                If AddSystemElement Then AddLinkToMenu("Component", "AddSystemElement")
                If AddSystemPrecondition Then AddLinkToMenu("Component", "AddSystemPrecondition")
                If AddSystemPreconditionDefinition Then AddLinkToMenu("Component", "AddSystemPreconditionDefinition")
                If AddSystemReference Then AddLinkToMenu("Component", "AddSystemReference")
                If AddSystemRestriction Then AddLinkToMenu("Component", "AddSystemRestriction")
                If AddSystemRestrictionDefinition Then AddLinkToMenu("Component", "AddSystemRestrictionDefinition")
                If AddSystemWeaponAbility Then AddLinkToMenu("Component", "AddSystemWeaponAbility")
                If AddSystemWeaponAbilityDefinition Then AddLinkToMenu("Component", "AddSystemWeaponAbilityDefinition")
                If AddUniversalItemDefinition Then AddLinkToMenu("Component", "AddUniversalItemDefinition")
                If AddUserDoc Then AddLinkToMenu("Component", "AddDocumentComponent")
                If AddUserMap Then AddLinkToMenu("Component", "AddMapComponent")
                If AddUserRule Then AddLinkToMenu("Component", "AddRulePageComponent")
                If AddWand Then AddLinkToMenu("Component", "AddWandDefinition")
                If AddWeapon Then AddLinkToMenu("Component", "AddWeaponDefinition")
                If AddWeaponEmulation Then AddLinkToMenu("Component", "AddWeaponEmulation")
                If AddWeaponMagicAbility Then AddLinkToMenu("Component", "AddWeaponMagicAbility")
                If AddWeaponMagicAbilityDefinition Then AddLinkToMenu("Component", "AddWeaponMagicAbilityDefinition")
                If AddWondrous Then AddLinkToMenu("Component", "AddWondrousItemDefinition")

            End If

            BeginGroup = True

            'character commands
            If AddFeat Then AddLinkToMenu("Component", "AddFeat(s)")
            If AddCharacterFeature Then AddLinkToMenu("Component", "AddFeature(s)")
            If AddCharacterLanguage Then AddLinkToMenu("Component", "AddLanguageCharacter")
            If AddDomain Then AddLinkToMenu("Component", "AddDomain")
            If AddSpecialistSchool Then AddLinkToMenu("Component", "AddSpecialistSchool")
            If AddProhibitedSchool Then AddLinkToMenu("Component", "AddProhibitedSchool")
            If AddUserModifier Then AddLinkToMenu("Component", "AddUserModifier")

            If CharacterAddPower Then AddLinkToMenu("Component", "AddPower")
            If CharacterAddSpecializationPower Then AddLinkToMenu("Component", "AddSpecializationPower")
            If CharacterAddDisciplineSpecialization Then AddLinkToMenu("Component", "AddPsionicSpecializationCharacter")

            If CharacterAddSpell Then AddLinkToMenu("Component", "AddSpell")
            If CharacterAddSpellFromCategory Then AddLinkToMenu("Component", "AddCategorySpell")
            If CharacterAddSpellFromDomain Then AddLinkToMenu("Component", "AddDomainSpell")
            If SyncSpells Then AddLinkToMenu("Component", "SynchronizeSpellList")

            If EditFeat Then AddLinkToMenu("Component", "EditFeat(s)")
            If EditCharacterFeature Then AddLinkToMenu("Component", "EditFeature(s)")
            If EditCharacterLanguage Then AddLinkToMenu("Component", "EditLanguageCharacter")
            If EditCharacterSkill Then AddLinkToMenu("Component", "EditSkillRanks")
            If EditUserModifier Then AddLinkToMenu("Component", "EditUserModifier")

            If EnableFeat Then AddLinkToMenu("Component", "EnableFeat(s)")
            If EnableFeature Then AddLinkToMenu("Component", "EnableFeature(s)")
            If EnableUserModifier Then AddLinkToMenu("Component", "EnableUserModifier(s)")

            If DisableFeat Then AddLinkToMenu("Component", "DisableFeat(s)")
            If DisableFeature Then AddLinkToMenu("Component", "DisableFeature(s)")
            If DisableUserModifier Then AddLinkToMenu("Component", "DisableUserModifier(s)")

            If FeatureEditMode Then AddLinkToMenu("Component", "FeatureEditMode")
            If FeatureViewMode Then AddLinkToMenu("Component", "FeatureViewMode")
            If OverrideFeatPrereq Then AddLinkToMenu("Component", "OverridePrerequisites")
            If StopOverrideFeatPrereq Then AddLinkToMenu("Component", "StopOverridingPrerequisites")

            If UpdateMemorizedSpells Then AddLinkToMenu("Component", "UpdateMemorizedSpells")


            BeginGroup = True

            If ModifySpellList Then AddLinkToMenu("Component", "AddSpells")
            If AddPowers Then AddLinkToMenu("Component", "AddPowers")

            BeginGroup = True

            If EditRulePage Then AddLinkToMenu("Component", "EditRulePage")
            If ClearPortrait Then AddLinkToMenu("Component", "ClearPortrait")
            If Properties Then AddLinkToMenu("Component", "Properties")
            If AddTags Then AddLinkToMenu("Component", "AddTags")
            If RemoveTags Then AddLinkToMenu("Component", "RemoveTags")

            If Rename Then
                BeginGroup = True
                AddLinkToPopupMenu("Rename")
            End If

            BeginGroup = True

            If DeleteObjects Then AddLinkToMenu("Component", "Delete")
            If DeleteCharacterLevel Then AddLinkToMenu("Component", "DeleteLevel(s)")
            If DeleteSpellLevel Then AddLinkToMenu("Component", "RemoveSpell(s)")
            If RemovePowers Then AddLinkToMenu("Component", "RemovePower(s)")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'hide the edit command
    Public Shared Sub HideEditCommand()
        'If mToolbar.ItemLinks(5).Caption.StartsWith("Edit") Then
        '    mToolbar.RemoveLink(mToolbar.ItemLinks(5))
        'End If
    End Sub

    'build the popup menu
    Public Shared Sub BuildPopupMenu()
        Try
            mPopupMenu.ItemLinks.Clear()

            Dim Selected As Objects.ObjectDataCollection = General.MainExplorer.CurrentSelectedObjects

            'if selection contains all manufactured objects then don't show context menu
            If Selected.Count = 0 And General.MainExplorer.SelectedObjectCount > 0 Then Exit Sub

            BeginGroup = True

            'component commands
            BuildCommands(Selected)

            BeginGroup = True

            'cut, copy and paste
            If Cut Then AddLinkToPopupMenu("Cut")
            If Copy Then AddLinkToPopupMenu("Copy")
            If Paste Then AddLinkToPopupMenu("Paste")

            BeginGroup = True

            If SaveComponents Then AddLinkToPopupMenu("SaveComponents")

            BeginGroup = True

            'printing
            If PrintCharacterSheet Then
                AddLinkToPopupMenu("CharacterSheet")
                AddLinkToPopupMenu("CustomOutputs")
            End If

            If ShowCharacterXML Then AddLinkToPopupMenu("CharacterXML")

            'inventory specific
            If Activate Then AddLinkToPopupMenu("Activate")
            If Deactivate Then AddLinkToPopupMenu("Deactivate")

            BeginGroup = True

            If Sell Then AddLinkToPopupMenu("Sell")
            If CombineMoney Then AddLinkToPopupMenu("CombineMoney")

            BeginGroup = True

            If ScribeScroll Then AddLinkToPopupMenu("ScribeScroll")
            If EditScroll Then AddLinkToPopupMenu("EditScroll")
            If ImprintStone Then AddLinkToPopupMenu("ImprintStone")
            If EditStone Then AddLinkToPopupMenu("EditStone")

            BeginGroup = True

            'edit buttons
            If EditAmmoDefinition Then AddLinkToPopupMenu("EditAmmunitionDefinition")
            If EditArmorDefinition Then AddLinkToPopupMenu("EditArmororShieldDefinition")
            If EditArmorMagicAbility Then AddLinkToPopupMenu("EditArmorMagicAbilityDefinition")
            If EditArtifact Then AddLinkToPopupMenu("EditArtifactDefinition")
            If EditCannotUse Then AddLinkToPopupMenu("EditCannotUse")
            If EditCharacter Then AddLinkToPopupMenu("EditCharacter")
            If EditCharacteristic Then AddLinkToPopupMenu("EditCharacteristic")
            If EditChooseBonusFeat Then AddLinkToPopupMenu("EditChooseBonusFeat")
            If EditChooseBonusFeatOfType Then AddLinkToPopupMenu("EditChooseBonusFeatofType")
            If EditChooseFeature Then AddLinkToPopupMenu("EditChooseFeature")
            If EditClass Then AddLinkToPopupMenu("EditClass")
            If EditClassLevel Then AddLinkToPopupMenu("EditClassLevel")
            If EditCondition Then AddLinkToPopupMenu("EditCondition")
            If EditCombatStyle Then AddLinkToPopupMenu("EditCombatStyle")
            If EditCurse Then AddLinkToPopupMenu("EditCurse")
            If EditDamageAddition Then AddLinkToPopupMenu("EditExtraDamage")
            If EditDamageReduction Then AddLinkToPopupMenu("EditDamageReduction")
            If EditDamageResistance Then AddLinkToPopupMenu("EditDamageResistance")
            If EditDamageVulnerability Then AddLinkToPopupMenu("EditDamageVulnerability")
            If EditDeityDefinition Then AddLinkToPopupMenu("EditDeityDefinition")
            If EditDiscipline Then AddLinkToPopupMenu("EditPsionicDiscipline")
            If EditDisciplineSpecialization Then AddLinkToPopupMenu("EditPsionicSpecialization")
            If EditDomainDefinition Then AddLinkToPopupMenu("EditDomainDefinition")
            If EditDorjeDefinition Then AddLinkToPopupMenu("EditDorjeDefinition")
            If EditEnhancement Then AddLinkToPopupMenu("EditEnhancementBonus")
            If EditExpiryCondition Then AddLinkToPopupMenu("EditExpiryCondition")
            If EditCompanion Then AddLinkToPopupMenu("EditCompanion")
            If EditFeatDefinition Then AddLinkToPopupMenu("EditFeatDefinition")
            If EditFeature Then AddLinkToPopupMenu("EditFeature")
            If EditFeatureDefinition Then AddLinkToPopupMenu("EditFeatureDefinition")
            If EditFlurryOfBlows Then AddLinkToPopupMenu("EditFlurryofBlows")
            If EditGrantedPower Then AddLinkToPopupMenu("EditGrantedPower")
            If EditHTMLDoc Then AddLinkToPopupMenu("EditDocument")
            If EditIntelligence Then AddLinkToPopupMenu("EditIntelligence")
            If EditItem Then AddLinkToPopupMenu("EditItem")
            If EditItemDefinition Then AddLinkToPopupMenu("EditItemDefinition")
            If EditLanguage Then AddLinkToPopupMenu("EditLanguage")
            If EditMagicAmmoDefinition Then AddLinkToPopupMenu("EditMagicAmmoDefinition")
            If EditModifier Then AddLinkToPopupMenu("EditModifier")
            If EditModifierLimiter Then AddLinkToPopupMenu("EditModifierLimiter")
            If EditMoney Then AddLinkToPopupMenu("EditMoney")
            If EditMonster Then AddLinkToPopupMenu("EditMonster")
            If EditMonsterClass Then AddLinkToPopupMenu("EditMonsterClass")
            If EditMonsterRace Then AddLinkToPopupMenu("EditMonsterRace")
            If EditMonsterType Then AddLinkToPopupMenu("EditMonsterType")
            If EditNaturalWeapon Then AddLinkToPopupMenu("EditNaturalWeaponDefinition")
            If EditPotionDefinition Then AddLinkToPopupMenu("EditPotionDefinition")
            If EditPower Then AddLinkToPopupMenu("EditPowerDefinition")
            If EditPowerProgression Then AddLinkToPopupMenu("EditPowerProgression")
            If EditPowerStoneDefinition Then AddLinkToPopupMenu("EditPowerStoneDefinition")
            If EditPrerequisite Then AddLinkToPopupMenu("EditPrerequisite")
            If EditPsicrownDefinition Then AddLinkToPopupMenu("EditPsicrownDefinition")
            If EditPsiLikeAbility Then AddLinkToPopupMenu("EditPsiLikeAbility")
            If EditPsiLikeAbilityTaken Then AddLinkToPopupMenu("EditPsiLikeTaken")
            If EditPsionicAmmoDefinition Then AddLinkToPopupMenu("EditPsionicAmmoDefinition")
            If EditPsionicArmorAbilityDefinition Then AddLinkToPopupMenu("EditPsionicArmorAbilityDefinition")
            If EditPsionicArmorDefinition Then AddLinkToPopupMenu("EditPsionicArmorDefinition")
            If EditPsionicArtifactDefinition Then AddLinkToPopupMenu("EditPsionicArtifactDefinition")
            If EditPsionicTattooDefinition Then AddLinkToPopupMenu("EditPsionicTattooDefinition")
            If EditPsionicWeaponAbility Then AddLinkToPopupMenu("EditPsionicWeaponAbility")
            If EditPsionicWeaponAbilityDefinition Then AddLinkToPopupMenu("EditPsionicWeaponAbilityDefinition")
            If EditPsionicWeaponDefinition Then AddLinkToPopupMenu("EditPsionicWeaponDefinition")
            If EditRace Then AddLinkToPopupMenu("EditRace")
            If EditRacialWeapon Then AddLinkToPopupMenu("EditRacialWeapon")
            If EditRegeneration Then AddLinkToPopupMenu("EditRegeneration")
            If EditRingDefinition Then AddLinkToPopupMenu("EditRingDefinition")
            If EditRodDefinition Then AddLinkToPopupMenu("EditRodDefinition")
            If EditScrollDefinition Then AddLinkToPopupMenu("EditScrollDefinition")
            If EditSetAbility Then AddLinkToPopupMenu("EditSetAbility")
            If EditSetValue Then AddLinkToPopupMenu("EditSetValue")
            If EditSkillDefinition Then AddLinkToPopupMenu("EditSkillDefinition")
            If EditSkillExchange Then AddLinkToPopupMenu("EditSkillAbilityExchange")
            If EditSkillSynergy Then AddLinkToPopupMenu("EditSkillSynergy")
            If EditSpecialMaterialDefinition Then AddLinkToPopupMenu("EditSpecialMaterialDefinition")
            If EditSpecificArmorDefinition Then AddLinkToPopupMenu("EditMagicArmorDefinition")
            If EditSpecificBonusFeat Then AddLinkToPopupMenu("EditSpecificBonusFeat")
            If EditSpecificClassSkill Then AddLinkToPopupMenu("EditSpecificClassSkill")
            If EditSpecificChooseBonusClassSkill Then AddLinkToPopupMenu("EditSpecificorChooseBonusClassSkill")
            If EditSpecificChooseBonusDomain Then AddLinkToPopupMenu("EditSpecificorChooseBonusDomain")
            If EditSpecificOrChooseBonusPsionicSpecialization Then AddLinkToPopupMenu("EditSpecificorChooseBonusPsionicSpecialization")
            If EditSpecificWeaponDefinition Then AddLinkToPopupMenu("EditMagicWeaponDefinition")
            If EditSpellCategory Then AddLinkToPopupMenu("EditSpellCategory")
            If EditSpellDefinition Then AddLinkToPopupMenu("EditSpellDefinition")
            If EditSpellDescriptor Then AddLinkToPopupMenu("EditSpellDescriptor")
            If EditSpellFailure Then AddLinkToPopupMenu("EditSpellFailure")
            If EditSpellLikeAbility Then AddLinkToPopupMenu("EditSpellLikeAbility")
            If EditSpellLikeAbilityTaken Then AddLinkToPopupMenu("EditSpellLikeTaken")
            If EditSpellsKnown Then AddLinkToPopupMenu("EditSpellsKnown")
            If EditSpellSchool Then AddLinkToPopupMenu("EditSpellSchool")
            If EditSpellSubschool Then AddLinkToPopupMenu("EditSpellSubschool")
            If EditSpellsPerDay Then AddLinkToPopupMenu("EditSpellsPerDay")
            If EditStaff Then AddLinkToPopupMenu("EditStaffDefinition")
            If EditSubdiscipline Then AddLinkToPopupMenu("EditPsionicSubdiscipline")
            If EditSubtype Then AddLinkToPopupMenu("EditSubtypeDefinition")
            If EditSystemAbility Then AddLinkToPopupMenu("EditSystemAbility")
            If EditSystemAbilityDefinition Then AddLinkToPopupMenu("EditSystemAbilityDefinition")
            If EditSystemAlignmentDefinition Then AddLinkToPopupMenu("EditSystemAlignmentDefinition")
            If EditSystemCondition Then AddLinkToPopupMenu("EditSystemCondition")
            If EditSystemElement Then AddLinkToPopupMenu("EditSystemElement")
            If EditSystemPrecondition Then AddLinkToPopupMenu("EditSystemPrecondition")
            If EditSystemPreconditionDefinition Then AddLinkToPopupMenu("EditSystemPreconditionDefinition")
            If EditSystemReference Then AddLinkToPopupMenu("EditSystemReference")
            If EditSystemRestriction Then AddLinkToPopupMenu("EditSystemRestriction")
            If EditSystemRestrictionDefinition Then AddLinkToPopupMenu("EditSystemRestrictionDefinition")
            If EditSystemWeaponAbility Then AddLinkToPopupMenu("EditSystemWeaponAbility")
            If EditSystemWeaponAbilityDefinition Then AddLinkToPopupMenu("EditSystemWeaponAbilityDefinition")
            If EditUniversalItemDefinition Then AddLinkToPopupMenu("EditUniversalItemDefinition")
            If EditUserDoc Then AddLinkToPopupMenu("EditDocumentComponent")
            If EditUserMap Then AddLinkToPopupMenu("EditMapComponent")
            If EditUserRule Then AddLinkToPopupMenu("EditRulePageComponent")
            If EditWand Then AddLinkToPopupMenu("EditWandDefinition")
            If EditWeapon Then AddLinkToPopupMenu("EditWeaponDefinition")
            If EditWeaponEmulation Then AddLinkToPopupMenu("EditWeaponEmulation")
            If EditWeaponMagicAbility Then AddLinkToPopupMenu("EditWeaponMagicAbility")
            If EditWeaponMagicAbilityDefinition Then AddLinkToPopupMenu("EditWeaponMagicAbilityDefinition")
            If EditWondrous Then AddLinkToPopupMenu("EditWondrousItemDefinition")

            BeginGroup = True

            'AddLinkToPopupMenu("ApplyTemplate")

            BeginGroup = True

            'add buttons
            If Commands.EditForm Is Nothing Then

                If CreateClassLevels Then AddLinkToPopupMenu("CreateClassLevels")

                BeginGroup = True

                If AddAmmoDefinition Then AddLinkToPopupMenu("AddAmmunitionDefinition")
                If AddArmorDefinition Then AddLinkToPopupMenu("AddArmororShieldDefinition")
                If AddArmorMagicAbility Then AddLinkToPopupMenu("AddArmorMagicAbilityDefinition")
                If AddArtifact Then AddLinkToPopupMenu("AddArtifactDefinition")
                If AddBonusClassSkill Then AddLinkToPopupMenu("AddBonusClassSkill")
                If AddBonusDomain Then AddLinkToPopupMenu("AddBonusDomain")
                If AddBonusFeat Then AddLinkToPopupMenu("AddBonusFeat")
                If AddBonusLanguage Then AddLinkToPopupMenu("AddBonusLanguage")
                If AddBonusPsionicSpecialization Then AddLinkToPopupMenu("AddBonusPsionicSpecialization")
                If AddCannotUse Then AddLinkToPopupMenu("AddCannotUse")
                If AddCharacter Then AddLinkToPopupMenu("AddCharacter")
                If AddCharacteristic Then AddLinkToPopupMenu("AddCharacteristic")
                If AddCharacterLevels Then AddLinkToPopupMenu("AddLevel(s)")
                If AddChooseBonusFeat Then AddLinkToPopupMenu("AddChooseBonusFeat")
                If AddChooseBonusFeatOfType Then AddLinkToPopupMenu("AddChooseBonusFeatofType")
                If AddChooseFeature Then AddLinkToPopupMenu("AddChooseFeature")
                If AddClass Then AddLinkToPopupMenu("AddClass")
                If AddClassLevel Then AddLinkToPopupMenu("AddClassLevel")
                If AddClassSkill Then AddLinkToPopupMenu("AddClassSkill")
                If AddCondition Then AddLinkToPopupMenu("AddCondition")
                If AddCombatStyle Then AddLinkToPopupMenu("AddCombatStyle")
                If AddCurse Then AddLinkToPopupMenu("AddCurse")
                If AddDamageAddition Then AddLinkToPopupMenu("AddExtraDamage")
                If AddDamageReduction Then AddLinkToPopupMenu("AddDamageReduction")
                If AddDamageResistance Then AddLinkToPopupMenu("AddDamageResistance")
                If AddDamageVulnerability Then AddLinkToPopupMenu("AddDamageVulnerability")
                If AddDeityDefinition Then AddLinkToPopupMenu("AddDeityDefinition")
                If AddDiscipline Then AddLinkToPopupMenu("AddPsionicDiscipline")
                If AddDisciplineSpecialization Then AddLinkToPopupMenu("AddPsionicSpecialization")
                If AddDomainDefinition Then AddLinkToPopupMenu("AddDomainDefinition")
                If AddDorjeDefinition Then AddLinkToPopupMenu("AddDorjeDefinition")
                If AddEnhancement Then AddLinkToPopupMenu("AddEnhancementBonus")
                If AddPrestigeCasterProgression Then AddLinkToPopupMenu("AddPrestigeCasterProgression")
                If AddPrestigeManifesterProgression Then AddLinkToPopupMenu("AddPrestigeManifesterProgression")
                If AddExpiryCondition Then AddLinkToPopupMenu("AddExpiryCondition")
                If AddCompanion Then AddLinkToPopupMenu("AddCompanion")
                If AddFeatDefinition Then AddLinkToPopupMenu("AddFeatDefinition")
                If AddFeature Then AddLinkToPopupMenu("AddFeature")
                If AddFeatureDefinition Then AddLinkToPopupMenu("AddFeatureDefinition")
                If AddFighterBonusFeat Then AddLinkToPopupMenu("AddFighterBonusFeat")
                If AddFlurryOfBlows Then AddLinkToPopupMenu("AddFlurryofBlows")
                If AddFolder Then AddLinkToPopupMenu("AddFolder")
                If AddGrantedPower Then AddLinkToPopupMenu("AddGrantedPower")
                If AddHTMLDoc Then AddLinkToPopupMenu("AddDocument")
                If AddIntelligence Then AddLinkToPopupMenu("AddIntelligence")
                If AddItem Then AddLinkToPopupMenu("AddItem")
                If AddItemDefinition Then AddLinkToPopupMenu("AddItemDefinition")
                If AddLanguage Then AddLinkToPopupMenu("AddLanguage")
                If AddLocation Then AddLinkToPopupMenu("AddLocation")
                If AddMagicAmmoDefinition Then AddLinkToPopupMenu("AddMagicAmmoDefinition")
                If AddModifier Then AddLinkToPopupMenu("AddModifier")
                If AddModifierLimiter Then AddLinkToPopupMenu("AddModifierLimiter")
                If AddMoney Then AddLinkToPopupMenu("AddMoney")
                If AddMonster Then AddLinkToPopupMenu("AddMonster")
                If AddMonsterClass Then AddLinkToPopupMenu("AddMonsterClass")
                If AddMonsterRace Then AddLinkToPopupMenu("AddMonsterRace")
                If AddMonsterType Then AddLinkToPopupMenu("AddMonsterType")
                If AddNaturalWeapon Then AddLinkToPopupMenu("AddNaturalWeaponDefinition")
                If AddPotionDefinition Then AddLinkToPopupMenu("AddPotionDefinition")
                If AddPower Then AddLinkToPopupMenu("AddPowerDefinition")
                If AddPowerStoneDefinition Then AddLinkToPopupMenu("AddPowerStoneDefinition")
                If AddPrerequisite Then AddLinkToPopupMenu("AddPrerequisite")
                If AddPsicrownDefinition Then AddLinkToPopupMenu("AddPsicrownDefinition")
                If AddPsiLikeAbility Then AddLinkToPopupMenu("AddPsiLikeAbility")
                If AddPsiLikeAbilityTaken Then AddLinkToPopupMenu("AddPsiLikeTaken")
                If AddPsionicAmmoDefinition Then AddLinkToPopupMenu("AddPsionicAmmoDefinition")
                If AddPsionicArmorAbilityDefinition Then AddLinkToPopupMenu("AddPsionicArmorAbilityDefinition")
                If AddPsionicArmorDefinition Then AddLinkToPopupMenu("AddPsionicArmorDefinition")
                If AddPsionicArtifactDefinition Then AddLinkToPopupMenu("AddPsionicArtifactDefinition")
                If AddPsionicTattooDefinition Then AddLinkToPopupMenu("AddPsionicTattooDefinition")
                If AddPsionicWeaponAbility Then AddLinkToPopupMenu("AddPsionicWeaponAbility")
                If AddPsionicWeaponAbilityDefinition Then AddLinkToPopupMenu("AddPsionicWeaponAbilityDefinition")
                If AddPsionicWeaponDefinition Then AddLinkToPopupMenu("AddPsionicWeaponDefinition")
                If AddRace Then AddLinkToPopupMenu("AddRace")
                If AddRacialWeapon Then AddLinkToPopupMenu("AddRacialWeapon")
                If AddRegeneration Then AddLinkToPopupMenu("AddRegeneration")
                If AddReplaceKnownSpell Then AddLinkToPopupMenu("AddReplaceKnownSpell")
                If AddRingDefinition Then AddLinkToPopupMenu("AddRingDefinition")
                If AddRodDefinition Then AddLinkToPopupMenu("AddRodDefinition")
                If AddScrollDefinition Then AddLinkToPopupMenu("AddScrollDefinition")
                If AddSetAbility Then AddLinkToPopupMenu("AddSetAbility")
                If AddSetValue Then AddLinkToPopupMenu("AddSetValue")
                If AddSkillDefinition Then AddLinkToPopupMenu("AddSkillDefinition")
                If AddSkillExchange Then AddLinkToPopupMenu("AddSkillAbilityExchange")
                If AddSkillSynergy Then AddLinkToPopupMenu("AddSkillSynergy")
                If AddSpecialMaterialDefinition Then AddLinkToPopupMenu("AddSpecialMaterialDefinition")
                If AddSpecificArmorDefinition Then AddLinkToPopupMenu("AddMagicArmorDefinition")
                If AddSpecificBonusFeat Then AddLinkToPopupMenu("AddSpecificBonusFeat")
                If AddSpecificClassSkill Then AddLinkToPopupMenu("AddSpecificClassSkill")
                If AddSpecificChooseBonusClassSkill Then AddLinkToPopupMenu("AddSpecificorChooseBonusClassSkill")
                If AddSpecificChooseBonusDomain Then AddLinkToPopupMenu("AddSpecificorChooseBonusDomain")
                If AddSpecificOrChooseBonusPsionicSpecialization Then AddLinkToPopupMenu("AddSpecificorChooseBonusPsionicSpecialization")
                If AddSpecificWeaponDefinition Then AddLinkToPopupMenu("AddMagicWeaponDefinition")
                If AddSpellCategory Then AddLinkToPopupMenu("AddSpellCategory")
                If AddSpellDefinition Then AddLinkToPopupMenu("AddSpellDefinition")
                If AddSpellDescriptor Then AddLinkToPopupMenu("AddSpellDescriptor")
                If AddSpellFailure Then AddLinkToPopupMenu("AddSpellFailure")
                If AddSpellLikeAbility Then AddLinkToPopupMenu("AddSpellLikeAbility")
                If AddSpellLikeAbilityTaken Then AddLinkToPopupMenu("AddSpellLikeTaken")
                If AddSpellsKnown Then AddLinkToPopupMenu("AddSpellsKnown")
                If AddSpellSchool Then AddLinkToPopupMenu("AddSpellSchool")
                If AddSpellSubschool Then AddLinkToPopupMenu("AddSpellSubschool")
                If AddSpellsPerDay Then AddLinkToPopupMenu("AddSpellsPerDay")
                If AddStaff Then AddLinkToPopupMenu("AddStaffDefinition")
                If AddSubdiscipline Then AddLinkToPopupMenu("AddPsionicSubdiscipline")
                If AddSubtype Then AddLinkToPopupMenu("AddSubtypeDefinition")
                If AddSystemAbility Then AddLinkToPopupMenu("AddSystemAbility")
                If AddSystemAbilityDefinition Then AddLinkToPopupMenu("AddSystemAbilityDefinition")
                If AddSystemAlignmentDefinition Then AddLinkToPopupMenu("AddSystemAlignmentDefinition")
                If AddSystemCondition Then AddLinkToPopupMenu("AddSystemCondition")
                If AddSystemElement Then AddLinkToPopupMenu("AddSystemElement")
                If AddSystemPrecondition Then AddLinkToPopupMenu("AddSystemPrecondition")
                If AddSystemPreconditionDefinition Then AddLinkToPopupMenu("AddSystemPreconditionDefinition")
                If AddSystemReference Then AddLinkToPopupMenu("AddSystemReference")
                If AddSystemRestriction Then AddLinkToPopupMenu("AddSystemRestriction")
                If AddSystemRestrictionDefinition Then AddLinkToPopupMenu("AddSystemRestrictionDefinition")
                If AddSystemWeaponAbility Then AddLinkToPopupMenu("AddSystemWeaponAbility")
                If AddSystemWeaponAbilityDefinition Then AddLinkToPopupMenu("AddSystemWeaponAbilityDefinition")
                If AddUniversalItemDefinition Then AddLinkToPopupMenu("AddUniversalItemDefinition")
                If AddUserDoc Then AddLinkToPopupMenu("AddDocumentComponent")
                If AddUserMap Then AddLinkToPopupMenu("AddMapComponent")
                If AddUserRule Then AddLinkToPopupMenu("AddRulePageComponent")
                If AddWand Then AddLinkToPopupMenu("AddWandDefinition")
                If AddWeapon Then AddLinkToPopupMenu("AddWeaponDefinition")
                If AddWeaponEmulation Then AddLinkToPopupMenu("AddWeaponEmulation")
                If AddWeaponMagicAbility Then AddLinkToPopupMenu("AddWeaponMagicAbility")
                If AddWeaponMagicAbilityDefinition Then AddLinkToPopupMenu("AddWeaponMagicAbilityDefinition")
                If AddWondrous Then AddLinkToPopupMenu("AddWondrousItemDefinition")

            End If

            BeginGroup = True

            'character commands
            If AddFeat Then AddLinkToPopupMenu("AddFeat(s)")
            If AddCharacterFeature Then AddLinkToPopupMenu("AddFeature(s)")
            If AddCharacterLanguage Then AddLinkToPopupMenu("AddLanguageCharacter")
            If AddDomain Then AddLinkToPopupMenu("AddDomain")
            If AddSpecialistSchool Then AddLinkToPopupMenu("AddSpecialistSchool")
            If AddProhibitedSchool Then AddLinkToPopupMenu("AddProhibitedSchool")
            If AddUserModifier Then AddLinkToPopupMenu("AddUserModifier")

            If CharacterAddPower Then AddLinkToPopupMenu("AddPower")
            If CharacterAddSpecializationPower Then AddLinkToPopupMenu("AddSpecializationPower")
            If CharacterAddDisciplineSpecialization Then AddLinkToPopupMenu("AddPsionicSpecializationCharacter")

            If CharacterAddSpell Then AddLinkToPopupMenu("AddSpell")
            If CharacterAddSpellFromCategory Then AddLinkToPopupMenu("AddCategorySpell")
            If CharacterAddSpellFromDomain Then AddLinkToPopupMenu("AddDomainSpell")

            If EditFeat Then AddLinkToPopupMenu("EditFeat(s)")
            If EditCharacterFeature Then AddLinkToPopupMenu("EditFeature(s)")
            If EditCharacterLanguage Then AddLinkToPopupMenu("EditLanguageCharacter")
            If EditCharacterSkill Then AddLinkToPopupMenu("EditSkillRanks")
            If EditUserModifier Then AddLinkToPopupMenu("EditUserModifier")

            If EnableFeat Then AddLinkToPopupMenu("EnableFeat(s)")
            If EnableFeature Then AddLinkToPopupMenu("EnableFeature(s)")
            If EnableUserModifier Then AddLinkToPopupMenu("EnableUserModifier(s)")
            If DisableFeat Then AddLinkToPopupMenu("DisableFeat(s)")
            If DisableFeature Then AddLinkToPopupMenu("DisableFeature(s)")
            If DisableUserModifier Then AddLinkToPopupMenu("DisableUserModifier(s)")
            If FeatureEditMode Then AddLinkToPopupMenu("FeatureEditMode")
            If FeatureViewMode Then AddLinkToPopupMenu("FeatureViewMode")
            If OverrideFeatPrereq Then AddLinkToPopupMenu("OverridePrerequisites")
            If StopOverrideFeatPrereq Then AddLinkToPopupMenu("StopOverridingPrerequisites")

            If UpdateMemorizedSpells Then AddLinkToPopupMenu("UpdateMemorizedSpells")

            BeginGroup = True

            If SyncSpells Then AddLinkToPopupMenu("SynchronizeSpellList")

            BeginGroup = True

            If ModifySpellList Then AddLinkToPopupMenu("AddSpells")
            If AddPowers Then AddLinkToPopupMenu("AddPowers")

            BeginGroup = True

            If EditRulePage Then AddLinkToPopupMenu("EditRulePage")
            If Properties Then AddLinkToPopupMenu("Properties")
            If AddTags Then AddLinkToPopupMenu("AddTags")
            If RemoveTags Then AddLinkToPopupMenu("RemoveTags")

            BeginGroup = True

            'rename
            If Rename Then AddLinkToPopupMenu("Rename")

            BeginGroup = True

            'expand/collapse
            If Expand Then AddLinkToPopupMenu("FolderExpand")
            If Collapse Then AddLinkToPopupMenu("FolderCollapse")

            BeginGroup = True

            If DeleteObjects Then AddLinkToPopupMenu("Delete")
            If DeleteCharacterLevel Then AddLinkToPopupMenu("DeleteLevel(s)")
            If DeleteSpellLevel Then AddLinkToPopupMenu("RemoveSpell(s)")
            If RemovePowers Then AddLinkToPopupMenu("RemovePower(s)")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'build the popup menu - for the marketplace popupmenu
    Public Shared Sub BuildMarketplacePopupMenu(ByVal Selected As Objects.ObjectDataCollection)
        Dim Item As New Objects.ObjectData

        Try
            mPopupMenu.ItemLinks.Clear()

            'if selection contains all manufactured objects then don't show context menu
            If Selected.Count = 0 Then Exit Sub

            'shopping cart commands
            If General.Marketplace.ShoppingCart.NoCharacterSelected Then
                General.ShowInfoDialog("Please select a character in the shopping cart.")
                Exit Sub
            End If

            If BuildShoppingCommands(Selected) Then
                If Selected.Count < 2 Then Item = Selected.Item(0)

                Dim Humanoid As Boolean = True
                If CharacterManager.GetCharacter(General.Marketplace.ShoppingCart.CurrentCharacterKey).RaceObject.Element("Nonhumanoid") = "Yes" Then
                    Humanoid = False
                End If

                'determine the price of the item so it can be displayed in the menu then add to menu
                If Item.IsEmpty Then
                    If CartAdd Then AddCartLinkToPopupMenu("Add<Item>(<Price>)ToBasket", "Items", Rules.Items.TotalPrice(Selected, General.Marketplace.ShoppingCart.Cart.BuySize, Humanoid).DisplayString)
                Else

                    If Item.Element("BaseItem") = "" Then AddCartLinkToPopupMenu("Add<Item>(<Price>)ToBasket", Item.Name, Rules.Items.ItemCost(Item, General.Marketplace.ShoppingCart.Cart.BuySize, Humanoid).DisplayString)

                    If Item.Element("BaseItem") = "" And Item.Type <> Objects.ItemDefinitionType Then
                        If CartMasterwork Then AddCartLinkToPopupMenu("AddMasterwork<Item>(<Price>)ToBasket", Item.Name, Rules.Items.EnhancedPrice(Item, General.Marketplace.ShoppingCart.Cart.BuySize, , Humanoid).DisplayString)
                        If CartPlus1 Then AddCartLinkToPopupMenu("Add<Item>+1(<Price>)ToBasket", Item.Name, Rules.Items.EnhancedPrice(Item, General.Marketplace.ShoppingCart.Cart.BuySize, 1, Humanoid).DisplayString)
                        If CartPlus2 Then AddCartLinkToPopupMenu("Add<Item>+2(<Price>)ToBasket", Item.Name, Rules.Items.EnhancedPrice(Item, General.Marketplace.ShoppingCart.Cart.BuySize, 2, Humanoid).DisplayString)
                        If CartPlus3 Then AddCartLinkToPopupMenu("Add<Item>+3(<Price>)ToBasket", Item.Name, Rules.Items.EnhancedPrice(Item, General.Marketplace.ShoppingCart.Cart.BuySize, 3, Humanoid).DisplayString)
                        If CartPlus4 Then AddCartLinkToPopupMenu("Add<Item>+4(<Price>)ToBasket", Item.Name, Rules.Items.EnhancedPrice(Item, General.Marketplace.ShoppingCart.Cart.BuySize, 4, Humanoid).DisplayString)
                        If CartPlus5 Then AddCartLinkToPopupMenu("Add<Item>+5(<Price>)ToBasket", Item.Name, Rules.Items.EnhancedPrice(Item, General.Marketplace.ShoppingCart.Cart.BuySize, 5, Humanoid).DisplayString)
                        If CartCustom Then AddCartLinkToPopupMenu("AddCustom<Item>ToBasket", Item.Name, "")
                    End If
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'determine the current set of enabled bar items
    Public Shared Sub BuildCommands(ByVal FocusObjects As Objects.ObjectDataCollection)
        Dim AllFixed As Boolean = True

        Try
            ResetFlags()

            Select Case FocusObjects.Count
                Case 0
                    'use the object selected in the tree view
                    FocusObject = General.MainExplorer.ObjectSelectedInTree

                    If FocusObject.IsEmpty Then Exit Sub

                Case 1

                    'Multiple Components Check - For Panels with manufactured objects
                    If General.MainExplorer.CurrentFocus = Explorer.Focus.ListView Then
                        If General.MainExplorer.ListView.SelectedItems.Count > 1 Then
                            GoTo MultipleObjects
                        End If
                    End If

                    'there is only one object selected
                    FocusObject = FocusObjects.Item(0)

                    Select Case FocusObject.Type
                        Case Objects.SystemFolderType
                            Properties = True
                        Case Objects.MoneyType
                            'nothing
                        Case Else
                            If Not FocusObject.Fixed Then EditRulePage = True
                    End Select

                    'rename
                    If (FocusObject.Fixed = False) And (FocusObject.IsPrimaryType) Then
                        If General.MainExplorer.CurrentFocus = Explorer.Focus.ListView Then
                            Rename = True
                        End If
                    Else
                        Select Case FocusObject.Type
                            Case Objects.ItemType, Objects.PrerequisiteType, Objects.ChooseFeatureType
                                If General.MainExplorer.CurrentFocus = Explorer.Focus.ListView Then
                                    Rename = True
                                End If
                        End Select
                    End If

                Case Else
MultipleObjects:
                    'multiple items are selected
                    Cut = True
                    Copy = True
                    DeleteObjects = True
                    Properties = True

                    If General.MainExplorer.ObjectSelectedInTree.IsPrimaryFolderType Then
                        SaveComponents = True
                    End If

                    'add/remove tags
                    If Objects.ObjectData.ShowOptionalColumns(General.MainExplorer.ObjectSelectedInTree.Type) Then
                        AddTags = True
                        RemoveTags = True
                    End If

                    'sometimes multiple components have additional commands
                    Select Case General.MainExplorer.CurrentPanelType
                        Case Explorer.PanelType.AssetsPanel, Explorer.PanelType.Inventory

                            'combine money and sell
                            Sell = True
                            CombineMoney = True

                            For Each Item As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                                If Item.Type = Objects.MoneyType Then
                                    Sell = False
                                Else
                                    CombineMoney = False
                                End If
                            Next

                        Case Explorer.PanelType.Modifiers

                            Cut = False
                            Copy = False
                            Properties = False

                            'Check for manufactured objects
                            If General.MainExplorer.ListView.SelectedItems.Count > FocusObjects.Count Then
                                DeleteObjects = False
                                Exit Select
                            Else
                                For Each item As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                                    If Not EnableUserModifier Then If item.Element("Disabled") = "Yes" Then EnableUserModifier = True
                                    If Not DisableUserModifier Then If item.Element("Disabled") = "" Then DisableUserModifier = True
                                Next
                            End If

                        Case Explorer.PanelType.SpellList
                            Cut = False
                            Copy = False
                            Properties = False
                            If CType(General.MainExplorer.CurrentPanel, SpellListPanel).PanelMode = Rules.SpellList.SpellListOperationMode.Definition Then
                                DeleteObjects = False
                                DeleteSpellLevel = True
                            End If

                        Case Explorer.PanelType.PowerList
                            Cut = False
                            Copy = False
                            Properties = False
                            If CType(General.MainExplorer.CurrentPanel, PowerListPanel).PanelMode = Rules.PowerList.PowerListOperationMode.Definition Then
                                DeleteObjects = False
                                RemovePowers = True
                            End If

                        Case Explorer.PanelType.Feats
                            Cut = False
                            Copy = False
                            Properties = False
                            For Each Item As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                                If Not EnableFeat Then If Item.Element("Disabled") = "Yes" Then EnableFeat = True
                                If Not DisableFeat Then If Item.Element("Disabled") = "" Then DisableFeat = True
                                If Not StopOverrideFeatPrereq Then If Item.Element("Overrides") = "Yes" Then StopOverrideFeatPrereq = True
                                If Not OverrideFeatPrereq Then If Item.Element("Overrides") = "No" Then OverrideFeatPrereq = True
                                If Item.Element("Source") <> "User" Then DeleteObjects = False
                                If EnableFeat And DisableFeat And StopOverrideFeatPrereq And OverrideFeatPrereq And (Not DeleteObjects) Then Exit For
                            Next

                        Case Explorer.PanelType.Features
                            Cut = False
                            Copy = False
                            Properties = False
                            If CType(General.MainExplorer.CurrentPanel, FeaturesPanel).PanelMode = FeaturesPanel.FeaturePanelMode.EditMode Then
                                For Each Item As Objects.ObjectData In General.MainExplorer.CurrentSelectedObjects
                                    If Not EnableFeature Then If Item.Element("Disabled") = "Yes" Then EnableFeature = True
                                    If Not DisableFeature Then If Item.Element("Disabled") = "" Then DisableFeature = True
                                    If Item.Element("Source") <> "User" Then DeleteObjects = False
                                    If EnableFeature And DisableFeature And (Not DeleteObjects) Then Exit For
                                Next
                                FeatureViewMode = True
                            Else
                                DeleteObjects = False
                                FeatureEditMode = True
                            End If

                        Case Explorer.PanelType.BasicListView
                            Select Case General.MainExplorer.ObjectSelectedInTree.Type
                                Case Objects.LanguageFolderType, Objects.DomainAndSchoolsFolderType, Objects.PsionicSpecializationFolderType
                                    Cut = False
                                    Copy = False
                                    Properties = False
                                Case Objects.SpecialMaterialDefinitionsFolderType
                                    Cut = False
                                    Copy = False
                                    DeleteObjects = False
                            End Select

                    End Select
                    Exit Sub
            End Select

            'cut, copy and paste
            If Not FocusObject.Fixed Then
                Cut = True
                Copy = True
                DeleteObjects = True
            Else
                Cut = False
                Copy = False
                DeleteObjects = False
            End If

            If FocusObject.IsPrimaryFolderType OrElse FocusObject.IsPrimaryType Then
                SaveComponents = True
            End If

            If General.MainExplorer.Clipboard.ClipboardNotEmpty Then Paste = True

            'prefetch rule vars
            FocusChildren = FocusObject.Children
            FocusParent = FocusObject.Parent

            'expand collapse
            If FocusChildren.Count > 0 And General.MainExplorer.CurrentFocus = Explorer.Focus.TreeView Then
                Expand = True
                Collapse = True
            End If

            'determine which bar items are specifically visible for this object
            Select Case FocusObject.Type

                '##############
                ' A, B, C, D, E
                Case Objects.AmmoDefinitionType
                    EditAmmoDefinition = True

                Case Objects.ArmorDefinitionFolderType
                    AddArmorDefinition = True
                    Properties = True

                Case Objects.ArmorDefinitionType
                    AddModifier = True
                    RuleAddDamageReduction()
                    EditArmorDefinition = True

                Case Objects.ArmorMagicAbilityDefinitionFolderType
                    AddArmorMagicAbility = True
                    Properties = True

                Case Objects.ArmorMagicAbilityDefinitionType
                    AddModifier = True
                    AddSetValue = True
                    RuleAddDamageReduction()
                    AddDamageResistance = True
                    EditArmorMagicAbility = True

                Case Objects.ArtifactDefinitionFolderType
                    AddArtifact = True
                    Properties = True

                Case Objects.ArtifactDefinitionType
                    AddSetValue = True
                    AddDamageResistance = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddModifier = True
                    EditArtifact = True

                Case Objects.AssetsFolderType
                    AddItem = True
                    ScribeScroll = True
                    ImprintStone = True
                    AddMoney = True

                Case Objects.BonusClassSkillChoiceOrSpecificType
                    Select Case FocusParent.Type
                        Case Objects.DomainDefinitionType, Objects.PsionicSpecializationDefinitionType
                            EditSpecificClassSkill = True
                        Case Else
                            EditSpecificChooseBonusClassSkill = True
                    End Select

                Case Objects.BonusDomainChoiceOrSpecificType
                    EditSpecificChooseBonusDomain = True

                Case Objects.BonusPsionicSpecializationChoiceorSpecificType
                    EditSpecificOrChooseBonusPsionicSpecialization = True

                Case Objects.CharacterFolderType
                    AddCharacter = True
                    AddCompanion = True
                    Properties = True

                Case Objects.CharacterLevelsFolderType
                    RuleAddDeleteCharacterLevel()
                    'Properties = True

                Case Objects.CharacterType
                    RuleAddDeleteCharacterLevel()
                    RuleShowCharacterSheet()
                    ClearPortrait = True
                    RuleCharacterEditCommand()
                    RuleApplyTemplate()

                Case Objects.ChooseBonusFeatType
                    EditChooseBonusFeat = True

                Case Objects.ChooseBonusFeatOfTypeType
                    EditChooseBonusFeatOfType = True

                Case Objects.ChooseFeatureType
                    EditChooseFeature = True

                Case Objects.ClassFolderType
                    AddClass = True
                    Properties = True

                Case Objects.ClassType
                    AddPrerequisite = True
                    RuleCreateClassLevels()
                    EditClass = True

                Case Objects.ClassLevelsFolderType
                    RuleAddClassLevel()
                    RuleCreateClassLevels()
                    Properties = True

                Case Objects.ClassLevelsSpellsKnownFolderType
                    Paste = False
                    Properties = True

                Case Objects.ClassLevelsSpellsPerDayFolderType
                    Paste = False
                    Properties = True

                Case Objects.ClassLevelType
                    AddSpecificChooseBonusClassSkill = True
                    RuleAddBonusDomain(AddSpecificChooseBonusDomain)
                    AddBonusClassSkill = True
                    RuleAddBonusDomain(AddBonusDomain)
                    AddBonusLanguage = True
                    AddModifier = True
                    RuleAddUnique(AddCombatStyle, Objects.CombatStyleType)
                    AddFeature = True
                    AddChooseFeature = True
                    AddBonusFeat = True
                    AddChooseBonusFeat = True
                    AddChooseBonusFeatOfType = True
                    RuleAddDamageReduction()
                    AddDamageResistance = True
                    AddFighterBonusFeat = True
                    RuleAddUnique(AddFlurryOfBlows, Objects.FlurryOfBlowsType)
                    AddSetValue = True
                    AddSkillExchange = True
                    AddSpecificBonusFeat = True
                    AddSpellLikeAbility = True
                    AddPsiLikeAbility = True
                    RuleAddBonusPsionicSpecialization(AddBonusPsionicSpecialization)
                    RuleAddBonusPsionicSpecialization(AddSpecificOrChooseBonusPsionicSpecialization)

                    Dim CharacterClass As Rules.CharacterClass = Caches.GetCharacterClass(FocusObject.Parent.ParentGUID)

                    If CharacterClass.IsCaster Then
                        If CharacterClass.CasterInfo.SpellAquisition = Rules.CharacterClass.AcquisitionType.Known Then
                            AddReplaceKnownSpell = True
                        End If
                    End If

                    If CharacterClass.ClassObj.Element("CasterAbility") = "Prestige Advancement" Then
                        If CharacterClass.ClassObj.Element("PrestigeSpellType") <> "" Then
                            AddPrestigeCasterProgression = True
                        End If

                        If CharacterClass.ClassObj.Element("AdvanceManifester") = "True" Then
                            AddPrestigeManifesterProgression = True
                        End If
                    End If

                    'RuleDelete()
                    If FocusObject.ObjectGUID.Equals(CharacterClass.HighestClassLevel.ObjectGUID) Then DeleteObjects = True Else DeleteObjects = False

                    EditClassLevel = True

                Case Objects.ClassPowerListFolderType
                    Paste = False
                    CharacterAddPower = True
                    CharacterAddSpecializationPower = True

                Case Objects.ClassSpellListFolderType
                    Paste = False
                    CharacterAddSpell = True
                    CharacterAddSpellFromDomain = True
                    CharacterAddSpellFromCategory = True
                    RuleAddSyncSpells()

                Case Objects.CombatStyleType
                    EditCombatStyle = True

                Case Objects.CombatStyleImprovedFeatType, Objects.CombatstyleMasteryFeatType
                    Paste = False

                Case Objects.ConditionType
                    RuleAddModifier()
                    RuleAddDamageReduction()
                    RuleAddDamageResistance()
                    RuleAddUnique(AddEnhancement, Objects.EnhancementBonusType)
                    RuleAddDamageAddition()
                    RuleAddWeaponMagicAbility()
                    RuleAddPsionicWeaponAbility()
                    RuleAddSystemWeaponAbility()
                    EditCondition = True

                Case Objects.DamageAdditionType
                    EditDamageAddition = True

                Case Objects.DamageReductionType
                    EditDamageReduction = True

                Case Objects.DamageResistanceType
                    EditDamageResistance = True

                Case Objects.DamageVulnerabilityType
                    EditDamageVulnerability = True

                Case Objects.DeityDefinitionFolderType
                    AddDeityDefinition = True
                    Properties = True

                Case Objects.DeityDefinitionType
                    EditDeityDefinition = True

                Case Objects.DomainAndSchoolsFolderType
                    Paste = False
                    RuleAddDomainsAndSchools()

                Case Objects.DomainDefinitionFolderType
                    AddDomainDefinition = True
                    Properties = True

                Case Objects.DomainDefinitionType
                    AddSpecificClassSkill = True
                    AddFeature = True
                    AddSpecificBonusFeat = True
                    EditDomainDefinition = True

                Case Objects.DomainType
                    Cut = False
                    Copy = False
                    EditRulePage = False
                    Rename = False
                    DeleteObjects = True

                Case Objects.EnhancementBonusType
                    EditEnhancement = True

                Case Objects.ExistingSpellcasterLevel


                    '##########
                    'F, G, H, I

                Case Objects.FeatDefinitionType
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddDamageResistance = True
                    AddModifier = True
                    AddPrerequisite = True
                    AddSystemAbility = True
                    AddSystemPrecondition = True
                    EditFeatDefinition = True

                Case Objects.FeatDefinitionsFolderType
                    AddFeatDefinition = True
                    Properties = True

                Case Objects.FeatFolderType
                    If FocusParent.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                        AddFeat = True
                    End If
                    Paste = False

                Case Objects.FeatTakenType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    RulesCharacterFeats()

                Case Objects.FeatureType
                    EditFeature = True

                Case Objects.FeatureDefinitionType
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddDamageResistance = True
                    AddModifier = True
                    AddPrerequisite = True
                    AddSystemAbility = True
                    AddSystemPrecondition = True
                    EditFeatureDefinition = True

                Case Objects.FeatureDefinitionFolderType
                    AddFeatureDefinition = True
                    Properties = True

                Case Objects.FeatureFolderType
                    If FocusParent.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                        AddCharacterFeature = True
                    End If
                    RuleCharacterFeatureMode()
                    Paste = False

                Case Objects.FeatureGainedType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    RuleCharacterFeatures()

                Case Objects.FlurryOfBlowsType
                    EditFlurryOfBlows = True

                Case Objects.InventoryFolderType
                    AddItem = True
                    AddMoney = True
                    ScribeScroll = True
                    ImprintStone = True

                Case Objects.IntelligenceType
                    EditIntelligence = True

                Case Objects.ItemType
                    If FocusParent.Type <> Objects.MonsterRaceDefinitionType AndAlso FocusParent.Type <> Objects.RaceType Then
                        RuleAddMoney()
                        RuleActivateDeactivate()
                        RuleScribeScroll()
                        RuleAddItem()
                        EditItem = True
                        Sell = True
                    Else
                        Cut = False
                        Copy = False
                        Rename = False
                        EditRulePage = False
                    End If

                Case Objects.ItemDefinitionFolderType
                    AddItemDefinition = True
                    Properties = True

                Case Objects.ItemDefinitionType
                    AddModifier = True
                    EditItemDefinition = True

                    '###########
                    ' J, K, L, M

                Case Objects.LanguageDefinitionType
                    EditLanguage = True

                Case Objects.LanguageDefinitionFolderType
                    AddLanguage = True
                    Properties = True

                Case Objects.LanguageFolderType
                    If FocusParent.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                        AddCharacterLanguage = True
                    End If
                    Paste = False

                Case Objects.LanguageType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    EditCharacterLanguage = True
                    DeleteObjects = True

                Case Objects.MagicAmmoDefinitionType
                    AddCondition = True
                    AddDamageAddition = True
                    EditMagicAmmoDefinition = True

                Case Objects.MagicWeaponAbilityConditionalType
                    EditWeaponMagicAbility = True

                Case Objects.MemorizedSpellsFolderType
                    RuleUpdateMemorizedSpells()

                Case Objects.MemorizedSpellType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    DeleteObjects = False
                    RuleUpdateMemorizedSpells()

                Case Objects.ModifierLimiterType
                    EditModifierLimiter = True

                Case Objects.ModifierLimiterFolderType
                    AddModifierLimiter = True
                    Properties = True

                Case Objects.ModifierType
                    Rename = False
                    EditRulePage = False
                    RuleModifiers()

                Case Objects.ModifierFolderType
                    Paste = False
                    If CharacterManager.CurrentCharacter.CharacterLevel > 0 Then
                        AddUserModifier = True
                    End If

                Case Objects.MoneyType
                    If FocusParent.Type <> Objects.MonsterRaceDefinitionType AndAlso FocusParent.Type <> Objects.RaceType Then
                        EditMoney = True
                    Else
                        Cut = False
                        Copy = False
                    End If

                Case Objects.MonsterType
                    RuleAddDeleteCharacterLevel()
                    RuleShowCharacterSheet()
                    ClearPortrait = True
                    RuleCharacterEditCommand()
                    RuleApplyTemplate()

                Case Objects.MonsterClassType
                    EditMonsterClass = True

                Case Objects.MonsterClassFolderType
                    AddMonsterClass = True

                Case Objects.MonsterClassLevelsFolderType
                    Properties = True
                    RuleAddClassLevel()

                Case Objects.MonsterClassLevelType
                    'AddSpecificChooseBonusClassSkill = True
                    'RuleAddBonusDomain(AddSpecificChooseBonusDomain)
                    'AddBonusClassSkill = True
                    'RuleAddBonusDomain(AddBonusDomain)
                    AddBonusLanguage = True
                    AddModifier = True
                    'RuleAddUnique(AddCombatStyle, Objects.CombatStyleType)
                    AddFeature = True
                    AddChooseFeature = True
                    AddBonusFeat = True
                    AddChooseBonusFeat = True
                    AddChooseBonusFeatOfType = True
                    RuleAddDamageReduction()
                    AddDamageResistance = True
                    'AddFighterBonusFeat = True
                    'RuleAddUnique(AddFlurryOfBlows, Objects.FlurryOfBlowsType)
                    AddSetValue = True
                    AddSetAbility = True
                    AddSkillExchange = True
                    AddSpecificBonusFeat = True
                    AddSpellLikeAbility = True
                    AddPsiLikeAbility = True
                    'RuleAddBonusPsionicSpecialization(AddBonusPsionicSpecialization)
                    'RuleAddBonusPsionicSpecialization(AddSpecificOrChooseBonusPsionicSpecialization)

                    Dim CharacterClass As Rules.CharacterClass = caches.GetCharacterClass(FocusObject.Parent.ParentGUID)

                    If FocusObject.ObjectGUID.Equals(CharacterClass.HighestClassLevel.ObjectGUID) Then DeleteObjects = True Else DeleteObjects = False

                    EditClassLevel = True

                Case Objects.MonsterFolderType
                    AddMonster = True
                    AddCharacter = True
                    AddCompanion = True
                    Properties = True

                Case Objects.MonsterRaceDefinitionFolderType
                    AddMonsterRace = True

                Case Objects.MonsterRaceDefinitionType
                    AddFeature = True
                    AddSpecificBonusFeat = True
                    AddBonusLanguage = True
                    AddChooseFeature = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddDamageResistance = True
                    AddModifier = True
                    AddSetValue = True
                    AddSpecificChooseBonusClassSkill = True
                    AddBonusClassSkill = True
                    AddSkillExchange = True
                    AddSpellLikeAbility = True
                    AddPsiLikeAbility = True
                    EditMonsterRace = True
                    AddBonusFeat = True
                    AddChooseBonusFeat = True

                Case Objects.MonsterTypeFolderType
                    Rename = False
                    AddMonsterType = True
                    Properties = True

                Case Objects.MonsterTypeType
                    Rename = False
                    EditMonsterType = True

                    '##############
                    ' N, O, P, Q, R

                Case Objects.NaturalWeaponDefinitionsFolderType
                    AddNaturalWeapon = True

                Case Objects.NaturalWeaponDefinitionType
                    EditNaturalWeapon = True

                Case Objects.PotionDefinitionFolderType
                    AddPotionDefinition = True
                    Properties = True

                Case Objects.PotionDefinitionType
                    EditPotionDefinition = True

                Case Objects.PowerDefinitionFolderType
                    AddPower = True
                    Properties = True

                Case Objects.PowerDefinitionType
                    EditPower = True

                Case Objects.PowerLearnedType
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = True
                    EditRulePage = False

                Case Objects.PowerListFolderType
                    AddPowers = True

                Case Objects.PowerListItemType
                    RemovePowers = True

                Case Objects.PowerProgressionType
                    EditPowerProgression = True

                Case Objects.PrerequisiteType
                    EditPrerequisite = True

                Case Objects.PsiLikeAbilityFolderType
                    RuleAddPsilLike()

                Case Objects.PsiLikeAbilityTakenType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    EditPsiLikeAbilityTaken = True

                Case Objects.PsiLikeAbilityType
                    EditPsiLikeAbility = True
                    EditRulePage = False

                Case Objects.PsionicAmmoDefinitionType
                    AddCondition = True
                    AddDamageAddition = True
                    EditPsionicAmmoDefinition = True

                Case Objects.PsionicArmorAbilityDefinitionsFolderType
                    AddPsionicArmorAbilityDefinition = True
                    Properties = True

                Case Objects.PsionicArmorAbilityDefinitionType
                    AddModifier = True
                    AddSetValue = True
                    RuleAddDamageReduction()
                    AddDamageResistance = True
                    EditPsionicArmorAbilityDefinition = True

                Case Objects.PsionicArmorDefinitionsFolderType
                    AddPsionicArmorDefinition = True
                    Properties = True

                Case Objects.PsionicArmorDefinitionType
                    AddModifier = True
                    AddSetValue = True
                    RuleAddDamageReduction()
                    AddDamageResistance = True
                    EditPsionicArmorDefinition = True

                Case Objects.PsionicArtifactDefinitionsFolderType
                    AddPsionicArtifactDefinition = True
                    Properties = True

                Case Objects.PsionicArtifactDefinitionType
                    AddSetValue = True
                    AddDamageResistance = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddModifier = True
                    EditPsionicArtifactDefinition = True

                Case Objects.PsionicDorjeDefinitionsFolderType
                    AddDorjeDefinition = True
                    Properties = True

                Case Objects.PsionicDorjeDefinitionType
                    EditDorjeDefinition = True

                Case Objects.PsionicPowerStoneDefinitionsFolderType
                    AddPowerStoneDefinition = True
                    Properties = True

                Case Objects.PsionicPowerStoneDefinitionType
                    EditPowerStoneDefinition = True

                Case Objects.PsionicPsicrownDefinitionFolderType
                    AddPsicrownDefinition = True
                    Properties = True

                Case Objects.PsionicPsicrownDefinitionType
                    EditPsicrownDefinition = True
                    AddDamageResistance = True
                    AddModifier = True

                Case Objects.PsicrownSpellType
                    Cut = False
                    Copy = False
                    Paste = False

                Case Objects.PsionicTattooDefinitionsFolderType
                    AddPsionicTattooDefinition = True
                    Properties = True

                Case Objects.PsionicTattooDefinitionType
                    EditPsionicTattooDefinition = True

                Case Objects.PsionicWeaponAbilityConditionalType
                    EditPsionicWeaponAbility = True

                Case Objects.PsionicWeaponAbilityDefinitionsFolderType
                    AddPsionicWeaponAbilityDefinition = True
                    Properties = True

                Case Objects.PsionicWeaponAbilityDefinitionType
                    AddCondition = True
                    AddModifier = True
                    AddDamageAddition = True
                    RuleAddDamageResistance()
                    AddSystemWeaponAbility = True
                    EditPsionicWeaponAbilityDefinition = True

                Case Objects.PsionicWeaponDefinitionsFolderType
                    AddPsionicAmmoDefinition = True
                    AddPsionicWeaponDefinition = True
                    Properties = True

                Case Objects.PsionicWeaponDefinitionType
                    AddModifier = True
                    AddCondition = True
                    AddDamageAddition = True
                    AddSystemWeaponAbility = True
                    RuleAddDamageResistance()
                    AddWeaponEmulation = True
                    EditPsionicWeaponDefinition = True

                Case Objects.PsionicDisciplineFolderType
                    AddDiscipline = True
                    Properties = True

                Case Objects.PsionicDisciplineType
                    AddSubdiscipline = True
                    EditDiscipline = True

                Case Objects.PsionicSpecializationFolderType
                    Paste = False
                    RuleAddPsionicSpecialization()

                Case Objects.PsionicSpecializationType
                    Cut = False
                    Copy = False
                    EditRulePage = False
                    Rename = False
                    DeleteObjects = True

                Case Objects.PsionicSubdisciplineType
                    EditSubdiscipline = True

                Case Objects.PsionicSpecializationDefinitionFolderType
                    AddDisciplineSpecialization = True
                    Properties = True

                Case Objects.PsionicSpecializationDefinitionType
                    EditDisciplineSpecialization = True
                    AddSpecificClassSkill = True
                    AddFeature = True
                    AddSpecificBonusFeat = True

                Case Objects.RaceFolderType
                    AddRace = True
                    Properties = True

                Case Objects.RaceType
                    AddSpecificChooseBonusClassSkill = True
                    AddBonusClassSkill = True
                    AddFeature = True
                    AddBonusFeat = True
                    AddSpecificBonusFeat = True
                    AddChooseBonusFeat = True
                    AddChooseBonusFeatOfType = True
                    AddChooseFeature = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddDamageResistance = True
                    AddModifier = True
                    AddRacialWeapon = True
                    EditRace = True
                    AddSetValue = True
                    AddSkillExchange = True
                    AddSpellLikeAbility = True
                    AddPsiLikeAbility = True

                Case Objects.RacialWeaponType
                    EditRacialWeapon = True

                Case Objects.RingDefinitionFolderType
                    AddRingDefinition = True
                    Properties = True

                Case Objects.RingDefinitionType
                    AddDamageResistance = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddModifier = True
                    AddSetValue = True
                    EditRingDefinition = True

                Case Objects.RodDefinitionFolderType
                    AddRodDefinition = True
                    Properties = True

                Case Objects.RodDefinitionType
                    AddDamageResistance = True
                    AddModifier = True
                    AddSetValue = True
                    EditRodDefinition = True

                    '###########
                    ' S, T

                Case Objects.ScrollDefinitionFolderType
                    AddScrollDefinition = True
                    Properties = True

                Case Objects.ScrollDefinitionType
                    EditScrollDefinition = True

                Case Objects.SetAbilityType
                    EditSetAbility = True

                Case Objects.SetValueType
                    EditSetValue = True

                Case Objects.ShieldDefinitionType
                    AddModifier = True
                    EditArmorDefinition = True

                Case Objects.SkillDefinitionFolderType
                    AddSkillDefinition = True
                    Properties = True

                Case Objects.SkillDefinitionType
                    AddSkillSynergy = True
                    EditSkillDefinition = True

                Case Objects.SkillAbilityExchangeType
                    EditSkillExchange = True

                Case Objects.SkillPointsSpentType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    EditCharacterSkill = True

                Case Objects.SkillSynergyType
                    EditSkillSynergy = True

                Case Objects.SpecialMaterialDefinitionsFolderType
                    'AddSpecialMaterialDefinition = True
                    Properties = True

                Case Objects.SpecialMaterialDefinitionType
                    'EditSpecialMaterialDefinition = True
                    'Properties = True
                    Cut = False
                    Copy = False
                    DeleteObjects = False

                Case Objects.SpecificArmorAbilityType
                    Paste = False

                Case Objects.SpecificArmorDefinitionFolderType
                    AddSpecificArmorDefinition = True
                    Properties = True

                Case Objects.SpecificArmorDefinitionType
                    AddModifier = True
                    AddSetValue = True
                    RuleAddDamageReduction()
                    AddDamageResistance = True
                    EditSpecificArmorDefinition = True

                Case Objects.SpecificBonusFeatType, Objects.SpecificBonusFeatChooseFocusType
                    EditSpecificBonusFeat = True

                Case Objects.SpecificWeaponDefinitionFolderType
                    AddSpecificWeaponDefinition = True
                    AddMagicAmmoDefinition = True
                    Properties = True

                Case Objects.SpecificWeaponDefinitionType
                    AddModifier = True
                    AddCondition = True
                    AddDamageAddition = True
                    AddSystemWeaponAbility = True
                    RuleAddDamageResistance()
                    AddWeaponEmulation = True
                    EditSpecificWeaponDefinition = True

                Case Objects.SpellCategoryDefinitionType
                    EditSpellCategory = True

                Case Objects.SpellCategoryFolder
                    AddSpellCategory = True

                Case Objects.SpellDescriptorDefinitionFolderType
                    AddSpellDescriptor = True
                    Properties = True

                Case Objects.SpellDescriptorDefinitionType
                    EditSpellDescriptor = True

                Case Objects.SpellDefinitionFolderType
                    AddSpellDefinition = True
                    Properties = True

                Case Objects.SpellDefinitionType
                    EditSpellDefinition = True

                Case Objects.SpellLearnedType
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = True
                    EditRulePage = False

                Case Objects.SpellLikeAbilityFolderType
                    RuleAddSpellLike()

                Case Objects.SpellLikeAbilityTakenType
                    Cut = False
                    Copy = False
                    Rename = False
                    EditRulePage = False
                    EditSpellLikeAbilityTaken = True

                Case Objects.SpellLikeAbilityType
                    EditSpellLikeAbility = True
                    EditRulePage = False

                Case Objects.SpellListFolderType
                    ModifySpellList = True

                Case Objects.SpellListItemType
                    DeleteSpellLevel = True

                Case Objects.SpellSchoolFolderType
                    AddSpellSchool = True
                    Properties = True

                Case Objects.SpellSchoolType
                    AddSpellSubschool = True
                    EditSpellSchool = True

                Case Objects.SpellSchoolProhibitedChoiceType
                    Cut = False
                    Copy = False
                    EditRulePage = False
                    Rename = False
                    DeleteObjects = True

                Case Objects.SpellSchoolSpecialistChoiceType
                    Cut = False
                    Copy = False
                    EditRulePage = False
                    Rename = False
                    DeleteObjects = True

                Case Objects.SpellSubschoolType
                    EditSpellSubschool = True

                Case Objects.SpellsKnownType
                    Paste = False
                    EditSpellsKnown = True

                Case Objects.SpellsPerDayType
                    Paste = False
                    EditSpellsPerDay = True

                Case Objects.StaffDefinitionFolderType
                    AddStaff = True
                    Properties = True

                Case Objects.StaffDefinitionType
                    AddDamageResistance = True
                    AddModifier = True
                    EditStaff = True

                Case Objects.StaffSpellType
                    Cut = False
                    Copy = False
                    Paste = False

                Case Objects.SubtypeDefinitionsFolderType
                    AddSubtype = True
                    Properties = True

                Case Objects.SubtypeDefinitionType
                    EditSubtype = True
                    AddFeature = True
                    AddChooseFeature = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddDamageResistance = True
                    AddModifier = True
                    AddSetValue = True

                Case Objects.SystemAbilityType
                    EditSystemAbility = True

                Case Objects.SystemAbilityDefinitionType
#If CompileMode = "Tools" Then
                    EditSystemAbilityDefinition = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemAbilityDefinitionFolderType
#If CompileMode = "Tools" Then
                    AddSystemAbilityDefinition = True
                    Properties = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemAlignmentDefinitionFolderType
                    AddSystemAlignmentDefinition = True

                Case Objects.SystemAlignmentDefinitionType
                    EditSystemAlignmentDefinition = True

                    'Case Objects.SystemConditionType
                    '    AddCannotUse = True
                    '    AddDamageReduction = True
                    '    AddDamageResistance = True
                    '    AddDamageVulnerability = True
                    '    AddModifier = True
                    '    AddRegeneration = True
                    '    AddSpellFailure = True
                    '    AddSpellResistance = True
                    '    AddSystemAbility = True
                    '    AddSystemRestriction = True
                    '    EditSystemCondition = True

                Case Objects.SystemConditionsFolderType
                    AddSystemCondition = True

                Case Objects.SystemElementFolderType
#If CompileMode = "Tools" Then
                    AddSystemElement = True
                    Properties = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemElementType
#If CompileMode = "Tools" Then
                    EditSystemElement = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemFolderType
                    Properties = True

                Case Objects.SystemPreconditionType
                    EditSystemPrecondition = True

                Case Objects.SystemPreconditionDefinitionType
#If CompileMode = "Tools" Then
                    EditSystemPreconditionDefinition = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemPreconditionDefinitionFolderType
#If CompileMode = "Tools" Then
                    AddSystemPreconditionDefinition = True
                    Properties = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemReferenceFolderType
#If CompileMode = "Tools" Then
                    AddSystemReference = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemReferenceType
#If CompileMode = "Tools" Then
                    EditSystemReference = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemRestrictionDefinitionFolderType
                    AddSystemRestrictionDefinition = True
                    Properties = True

                Case Objects.SystemWeaponAbilityType
                    EditSystemWeaponAbility = True

                Case Objects.SystemWeaponAbilityDefinitionType
#If CompileMode = "Tools" Then
                    EditSystemWeaponAbilityDefinition = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                Case Objects.SystemWeaponAbilityDefinitionFolderType
#If CompileMode = "Tools" Then
                    AddSystemWeaponAbilityDefinition = True
                    Properties = True
#Else
                    Cut = False
                    Copy = False
                    Paste = False
                    DeleteObjects = False
                    EditRulePage = False
#End If

                    '##############
                    ' U, V, W, X, Y, Z

                    'Case Objects.UserDocType
                    '    AddFolder = True
                    '    AddUserDoc = True
                    '    AddUserMap = True
                    '    AddUserRule = True
                    '    EditUserDoc = True

                    'Case Objects.UserFolderType
                    '    AddFolder = True
                    '    AddUserDoc = True
                    '    AddUserMap = True
                    '    AddUserRule = True
                    '    Properties = True

                    'Case Objects.UserDocMapType
                    '    AddFolder = True
                    '    AddUserDoc = True
                    '    AddUserMap = True
                    '    AddUserRule = True
                    '    EditUserMap = True

                    'Case Objects.UserDocRulesType
                    '    AddFolder = True
                    '    AddUserDoc = True
                    '    AddUserMap = True
                    '    AddUserRule = True
                    '    EditUserRule = True

                Case Objects.UniversalItemDefinitionFolderType
                    AddUniversalItemDefinition = True
                    Properties = True

                Case Objects.UniversalItemDefinitionType
                    AddDamageResistance = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddModifier = True
                    AddSetValue = True
                    EditUniversalItemDefinition = True

                Case Objects.WandDefinitionFolderType
                    AddWand = True
                    Properties = True

                Case Objects.WandDefinitionType
                    EditWand = True

                Case Objects.WeaponConfigType
                    Cut = False
                    Copy = False
                    Paste = False
                    EditRulePage = False
                    DeleteObjects = True

                Case Objects.WeaponDefinitionType
                    AddModifier = True
                    EditWeapon = True

                Case Objects.WeaponDefinitionFolderType
                    AddAmmoDefinition = True
                    AddWeapon = True
                    Properties = True

                Case Objects.WeaponEmulationType
                    EditWeaponEmulation = True

                Case Objects.WeaponMagicAbilityDefinitionFolderType
                    AddWeaponMagicAbilityDefinition = True
                    Properties = True

                Case Objects.WeaponMagicAbilityDefinitionType
                    AddCondition = True
                    AddModifier = True
                    AddDamageAddition = True
                    RuleAddDamageResistance()
                    AddSystemWeaponAbility = True
                    EditWeaponMagicAbilityDefinition = True

                Case Objects.WondrousDefinitionFolderType
                    AddWondrous = True
                    Properties = True

                Case Objects.WondrousDefinitionType
                    AddDamageResistance = True
                    RuleAddUnique(AddDamageReduction, Objects.DamageReductionType)
                    AddModifier = True
                    AddSetValue = True
                    EditWondrous = True

            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'determine the current set of enabled bar items
    Public Shared Function BuildShoppingCommands(ByVal FocusObjects As Objects.ObjectDataCollection) As Boolean
        Dim FocusObject As Objects.ObjectData
        Dim Enhanceable As Boolean = False

        Try
            ResetFlags()

            Select Case FocusObjects.Count
                Case 0
                    'use the object selected in the tree view
                    FocusObject = General.MainExplorer.ObjectSelectedInTree
                Case 1
                    'there is only one object selected
                    FocusObject = FocusObjects.Item(0)
                Case Else
                    'multiple items selected
                    CartAdd = True
                    For Each Item As Objects.ObjectData In FocusObjects
                        Select Case Item.Type
                            Case Objects.AmmoDefinitionType, Objects.ArmorDefinitionType, Objects.ItemDefinitionType, Objects.MagicAmmoDefinitionType, Objects.PotionDefinitionType, Objects.RingDefinitionType, Objects.RodDefinitionType, Objects.ScrollDefinitionType, Objects.ShieldDefinitionType, Objects.SpecificArmorDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.StaffDefinitionType, Objects.ArtifactDefinitionType, Objects.WondrousDefinitionType, Objects.WandDefinitionType, Objects.WeaponDefinitionType
                                'ok
                            Case Else
                                CartAdd = False
                        End Select
                    Next

                    If CartAdd Then Return True Else Return False

            End Select

            'determine which bar items are specifically visible for this object
            Select Case FocusObject.Type

                Case Objects.AmmoDefinitionType
                    CartAdd = True
                    CartMasterwork = True
                    Enhanceable = True
                    EditAmmoDefinition = True

                Case Objects.ArmorDefinitionType
                    CartAdd = True
                    CartMasterwork = True
                    Enhanceable = True
                    EditArmorDefinition = True

                Case Objects.ArtifactDefinitionType
                    CartAdd = True
                    EditArtifact = True

                Case Objects.ItemDefinitionType
                    CartAdd = True
                    EditItemDefinition = True

                Case Objects.MagicAmmoDefinitionType
                    CartAdd = True
                    EditMagicAmmoDefinition = True

                Case Objects.PotionDefinitionType
                    CartAdd = True
                    EditPotionDefinition = True

                Case Objects.PsionicArmorDefinitionType
                    CartAdd = True
                    EditPsionicArmorDefinition = True

                Case Objects.PsionicArtifactDefinitionType
                    CartAdd = True
                    EditPsionicArtifactDefinition = True

                Case Objects.PsionicPsicrownDefinitionType
                    CartAdd = True
                    EditPsicrownDefinition = True

                Case Objects.PsionicDorjeDefinitionType
                    CartAdd = True
                    EditDorjeDefinition = True

                Case Objects.PsionicPowerStoneDefinitionType
                    CartAdd = True
                    EditPowerStoneDefinition = True

                Case Objects.PsionicTattooDefinitionType
                    CartAdd = True
                    EditPsionicTattooDefinition = True

                Case Objects.PsionicWeaponDefinitionType
                    CartAdd = True
                    EditPsionicWeaponDefinition = True

                Case Objects.RingDefinitionType
                    CartAdd = True
                    EditRingDefinition = True

                Case Objects.RodDefinitionType
                    CartAdd = True
                    EditRodDefinition = True

                Case Objects.ScrollDefinitionType
                    CartAdd = True
                    EditScrollDefinition = True

                Case Objects.ShieldDefinitionType
                    CartAdd = True
                    CartMasterwork = True
                    Enhanceable = True
                    EditArmorDefinition = True

                Case Objects.SpecificArmorDefinitionType
                    CartAdd = True
                    EditSpecificArmorDefinition = True

                Case Objects.SpecificWeaponDefinitionType
                    CartAdd = True
                    EditSpecificWeaponDefinition = True

                Case Objects.StaffDefinitionType
                    CartAdd = True
                    EditStaff = True

                Case Objects.UniversalItemDefinitionType
                    CartAdd = True
                    EditUniversalItemDefinition = True

                Case Objects.WandDefinitionType
                    CartAdd = True
                    EditWand = True

                Case Objects.WeaponDefinitionType
                    CartAdd = True
                    CartMasterwork = True
                    Enhanceable = True
                    EditWeapon = True

                Case Objects.WondrousDefinitionType
                    CartAdd = True
                    EditWondrous = True

                Case Else
                    Return False

            End Select

            'set flags
            If Enhanceable Then
                CartPlus1 = True
                CartPlus2 = True
                CartPlus3 = True
                CartPlus4 = True
                CartPlus5 = True
                CartCustom = True
            End If

            'existing item might already be masterwork
            If CartMasterwork Then
                If FocusObject.Element("Masterwork") = "Yes" Then CartMasterwork = False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'reset object specific flags
    Private Shared Sub ResetFlags()
        Try
            'general flags
            Cut = False
            Copy = False
            Paste = False
            DeleteObjects = False
            Rename = False
            Properties = False
            DeleteCharacterLevel = False
            DeleteSpellLevel = False
            Expand = False
            Collapse = False
            ModifySpellList = False
            AddPowers = False
            RemovePowers = False
            SaveComponents = False

            'cart flags
            CartAdd = False
            CartMasterwork = False
            CartPlus1 = False
            CartPlus2 = False
            CartPlus3 = False
            CartPlus4 = False
            CartPlus5 = False
            CartCustom = False

            'inventory
            Activate = False
            Deactivate = False
            Sell = False
            CombineMoney = False
            ScribeScroll = False
            EditScroll = False
            ImprintStone = False
            EditStone = False

            'printing
            PrintCharacterSheet = False
            ShowCharacterXML = False

            'misc 
            ClearPortrait = False
            CreateClassLevels = False

            'add flags
            AddAmmoDefinition = False
            AddArmorDefinition = False
            AddArmorMagicAbility = False
            AddArtifact = False
            AddBonusClassSkill = False
            AddBonusDomain = False
            AddBonusFeat = False
            AddBonusLanguage = False
            AddBonusPsionicSpecialization = False
            AddCannotUse = False
            AddCharacter = False
            AddCharacteristic = False
            AddCharacterLevels = False
            AddChooseBonusFeat = False
            AddChooseBonusFeatOfType = False
            AddChooseFeature = False
            AddClass = False
            AddClassLevel = False
            AddClassSkill = False
            AddCondition = False
            AddCombatStyle = False
            AddCurse = False
            AddDamageAddition = False
            AddDamageReduction = False
            AddDamageResistance = False
            AddDamageVulnerability = False
            AddDeityDefinition = False
            AddDiscipline = False
            AddDisciplineSpecialization = False
            AddDomainDefinition = False
            AddEnhancement = False
            AddExpiryCondition = False
            AddCompanion = False
            AddFeatDefinition = False
            AddFeature = False
            AddFeatureDefinition = False
            AddFighterBonusFeat = False
            AddFlurryOfBlows = False
            AddFolder = False
            AddGrantedPower = False
            AddHTMLDoc = False
            AddIntelligence = False
            AddItem = False
            AddItemDefinition = False
            AddLanguage = False
            AddLocation = False
            AddMagicAmmoDefinition = False
            AddModifier = False
            AddModifierLimiter = False
            AddMoney = False
            AddMonster = False
            AddMonsterClass = False
            AddMonsterRace = False
            AddMonsterType = False
            AddNaturalWeapon = False
            AddPotionDefinition = False
            AddPower = False
            AddPrerequisite = False
            AddPrestigeCasterProgression = False
            AddPrestigeManifesterProgression = False
            AddPsiLikeAbility = False
            AddPsiLikeAbilityTaken = False
            AddRace = False
            AddRacialWeapon = False
            AddRegeneration = False
            AddReplaceKnownSpell = False
            AddRingDefinition = False
            AddRodDefinition = False
            AddScrollDefinition = False
            AddSetAbility = False
            AddSetValue = False
            AddSkillDefinition = False
            AddSkillExchange = False
            AddSkillSynergy = False
            AddSpecialisedSubmenu = False
            AddSpecialMaterialDefinition = False
            AddSpecificClassSkill = False
            AddSpecificChooseBonusClassSkill = False
            AddSpecificChooseBonusDomain = False
            AddSpecificOrChooseBonusPsionicSpecialization = False
            AddSpecificBonusFeat = False
            AddSpecificArmorDefinition = False
            AddSpecificWeaponDefinition = False
            AddSpell = False
            AddSpellCategory = False
            AddSpellDefinition = False
            AddSpellDescriptor = False
            AddSpellFailure = False
            AddSpellLikeAbility = False
            AddSpellLikeAbilityTaken = False
            AddSpellsKnown = False
            AddSpellSchool = False
            AddSpellSubschool = False
            AddSpellsPerDay = False
            AddStaff = False
            AddSubtype = False
            AddSubdiscipline = False
            AddSystemCondition = False
            AddSystemAbility = False
            AddSystemAbilityDefinition = False
            AddSystemAlignment = False
            AddSystemAlignmentDefinition = False
            AddSystemElement = False
            AddSystemPrecondition = False
            AddSystemPreconditionDefinition = False
            AddSystemReference = False
            AddSystemRestriction = False
            AddSystemRestrictionDefinition = False
            AddSystemWeaponAbility = False
            AddSystemWeaponAbilityDefinition = False
            AddUserDoc = False
            AddUserMap = False
            AddUserRule = False
            AddWand = False
            AddWeapon = False
            AddWeaponEmulation = False
            AddWeaponMagicAbility = False
            AddWeaponMagicAbilityDefinition = False
            AddWeaponMagicAbilityBane = False
            AddWondrous = False

            EditAmmoDefinition = False
            EditArmorDefinition = False
            EditArmorMagicAbility = False
            EditArtifact = False
            EditCannotUse = False
            EditCharacter = False
            EditCharacteristic = False
            EditChooseBonusFeat = False
            EditChooseBonusFeatOfType = False
            EditClass = False
            EditClassLevel = False
            EditCondition = False
            EditCombatStyle = False
            EditCurse = False
            EditDamageAddition = False
            EditDamageReduction = False
            EditDamageResistance = False
            EditDamageVulnerability = False
            EditDeityDefinition = False
            EditDiscipline = False
            EditDisciplineSpecialization = False
            EditDomainDefinition = False
            EditEnhancement = False
            EditExpiryCondition = False
            EditCompanion = False
            EditFeatDefinition = False
            EditFeature = False
            EditFeatureDefinition = False
            EditChooseFeature = False
            EditFlurryOfBlows = False
            EditGrantedPower = False
            EditHTMLDoc = False
            EditIntelligence = False
            EditItem = False
            EditItemDefinition = False
            EditLanguage = False
            EditMagicAmmoDefinition = False
            EditModifier = False
            EditModifierLimiter = False
            EditMoney = False
            EditMonster = False
            EditMonsterClass = False
            EditMonsterRace = False
            EditMonsterType = False
            EditNaturalWeapon = False
            EditPotionDefinition = False
            EditPower = False
            EditPowerProgression = False
            EditPrerequisite = False
            EditPsiLikeAbility = False
            EditPsiLikeAbilityTaken = False
            EditRace = False
            EditRacialWeapon = False
            EditRegeneration = False
            EditRingDefinition = False
            EditRodDefinition = False
            EditRulePage = False
            EditScrollDefinition = False
            EditSetAbility = False
            EditSetValue = False
            EditSkillDefinition = False
            EditSkillExchange = False
            EditSkillSynergy = False
            EditSpecialMaterialDefinition = False
            EditSpecificBonusFeat = False
            EditSpecificClassSkill = False
            EditSpecificChooseBonusClassSkill = False
            EditSpecificChooseBonusDomain = False
            EditSpecificOrChooseBonusPsionicSpecialization = False
            EditSpecificArmorDefinition = False
            EditSpecificWeaponDefinition = False
            EditSpellCategory = False
            EditSpellDefinition = False
            EditSpellDescriptor = False
            EditSpellFailure = False
            EditSpellLikeAbility = False
            EditSpellLikeAbilityTaken = False
            EditSpellsKnown = False
            EditSpellSchool = False
            EditSpellSubschool = False
            EditSpellsPerDay = False
            EditStaff = False
            EditSubdiscipline = False
            EditSubtype = False
            EditSystemCondition = False
            EditSystemAbility = False
            EditSystemAbilityDefinition = False
            EditSystemAligment = False
            EditSystemAlignmentDefinition = False
            EditSystemElement = False
            EditSystemPrecondition = False
            EditSystemPreconditionDefinition = False
            EditSystemReference = False
            EditSystemRestriction = False
            EditSystemRestrictionDefinition = False
            EditSystemWeaponAbility = False
            EditSystemWeaponAbilityDefinition = False
            EditUserDoc = False
            EditUserMap = False
            EditUserRule = False
            EditWand = False
            EditWeapon = False
            EditWeaponEmulation = False
            EditWeaponMagicAbility = False
            EditWeaponMagicAbilityDefinition = False
            EditWondrous = False

            'character commands 
            AddCharacterFeature = False
            AddFeat = False
            AddCharacterLanguage = False
            AddDomain = False
            AddSpecialistSchool = False
            AddProhibitedSchool = False
            AddUserModifier = False

            CharacterAddPower = False
            CharacterAddSpecializationPower = False
            CharacterAddDisciplineSpecialization = False
            CharacterAddSpell = False
            CharacterAddSpellFromDomain = False
            CharacterAddSpellFromCategory = False
            SyncSpells = False

            DisableFeat = False
            DisableFeature = False
            DisableUserModifier = False

            EditCharacterFeature = False
            EditFeat = False
            EditCharacterLanguage = False
            EditCharacterSkill = False
            EditUserModifier = False

            EnableFeat = False
            EnableFeature = False
            EnableUserModifier = False

            OverrideFeatPrereq = False
            FeatureViewMode = False
            FeatureEditMode = False
            StopOverrideFeatPrereq = False

            AddTags = False
            RemoveTags = False

            UpdateMemorizedSpells = False

            'unsorted psionic commands
            AddDorjeDefinition = False
            AddPsionicArtifactDefinition = False
            AddPowerStoneDefinition = False
            AddPsicrownDefinition = False
            AddUniversalItemDefinition = False
            AddPsionicWeaponDefinition = False
            AddPsionicWeaponAbilityDefinition = False
            AddPsionicArmorDefinition = False
            AddPsionicArmorAbilityDefinition = False
            AddPsionicWeaponAbility = False
            AddPsionicAmmoDefinition = False
            AddPsionicTattooDefinition = False

            EditDorjeDefinition = False
            EditPsionicArtifactDefinition = False
            EditPowerStoneDefinition = False
            EditPsicrownDefinition = False
            EditUniversalItemDefinition = False
            EditPsionicWeaponDefinition = False
            EditPsionicWeaponAbilityDefinition = False
            EditPsionicArmorDefinition = False
            EditPsionicArmorAbilityDefinition = False
            EditPsionicWeaponAbility = False
            EditPsionicAmmoDefinition = False
            EditPsionicTattooDefinition = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Helper Functions"

    'add link to menu
    Private Shared Sub AddLinkToMenu(ByVal MenuName As String, ByVal BarItemName As String)
        Dim BarItemLink As BarItemLink
        Dim BarSubItem As BarSubItem
        Try
            BarSubItem = CType(mBarManager.Items(MenuName), BarSubItem)
            BarItemLink = BarSubItem.ItemLinks.Add(mBarManager.Items(BarItemName))

            If Not BarItemLink.Caption = "Edit Rule Page" And (BarItemLink.Caption.StartsWith("Edit")) Then
                If Commands.EditForm Is Nothing Then
                    BarItemLink.Item.Glyph = Image.FromFile(General.BasePath & "Icons\form_blue.png")
                Else
                    BarItemLink.Caption = BarItemLink.Caption.Replace("Edit", "View")
                    BarItemLink.Item.Glyph = Image.FromFile(General.BasePath & "Icons\form_green.png")
                End If
            End If

            If BeginGroup Then
                BarItemLink.BeginGroup = True
                BeginGroup = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add link to a sub item
    Private Shared Sub AddLinkToSubItem(ByVal SubItem As String, ByVal BarItemName As String)
        Dim BarItemLink As BarItemLink
        Dim BarSubItem As BarSubItem
        Try
            BarSubItem = CType(mBarManager.Items(SubItem), BarSubItem)

            BarItemLink = BarSubItem.ItemLinks.Add(mBarManager.Items(BarItemName))
            BarItemLink.UserPaintStyle = BarItemPaintStyle.Caption

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''add a bar button item to the manager
    'Private Shared Sub AddBarButtonItem(ByVal Caption As String, ByVal Hint As String, ByVal IconFilename As String, ByVal ItemClickHandler As ItemClickEventHandler)
    '    Dim BarButtonItem As New BarButtonItem

    '    Try
    '        BarButtonItem.Manager = mBarManager
    '        BarButtonItem.Caption = Caption
    '        BarButtonItem.Hint = Hint
    '        Caption = Caption.Replace(" ", "")
    '        Caption = Caption.Replace("&", "")
    '        BarButtonItem.Name = Caption
    '        If IconFilename <> "" Then BarButtonItem.Glyph = BarButtonItem.Glyph.FromFile(General.BasePath & "Icons\" & IconFilename)
    '        AddHandler BarButtonItem.ItemClick, ItemClickHandler
    '        'Handlers.Add(Caption, ItemClickHandler)
    '        mBarManager.Items.Add(BarButtonItem)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    'add link to menu
    'Private Shared Sub AddLinkToMenu(ByVal MenuName As String, ByVal BarItemName As String, ByVal test As Integer)
    '    Dim BarItemLink As BarItemLink
    '    Dim BarSubItem As BarSubItem
    '    Dim Testme As BarButtonItem

    '    Try
    '        BarSubItem = CType(mBarManager.Items(MenuName), BarSubItem)
    '        BarItemLink = BarSubItem.ItemLinks.Add(mBarManager.Items(BarItemName))

    '        For Each Item As BarItem In mBarManager.Items
    '            Item.Tag = True
    '        Next

    '        If Not BarItemLink.Caption = "Edit Rule Page" And (BarItemLink.Caption.StartsWith("Edit")) Then
    '            If Commands.EditForm Is Nothing Then
    '                BarItemLink.Item.Glyph = BarItemLink.Item.Glyph.FromFile(General.BasePath & "Icons\form_blue.png")
    '            Else
    '                BarItemLink.Caption = BarItemLink.Caption.Replace("Edit", "View")
    '                BarItemLink.Item.Glyph = BarItemLink.Item.Glyph.FromFile(General.BasePath & "Icons\form_green.png")
    '            End If
    '        End If

    '        If BeginGroup Then
    '            BarItemLink.BeginGroup = True
    '            BeginGroup = False
    '        End If

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub
    'add link to menu

    Private Shared Sub AddCartLinkToMenu(ByVal BarItemName As String, ByVal ItemName As String, ByVal Price As String)
        Dim BarItemLink As BarItemLink
        Dim BarSubItem As BarSubItem

        Try
            BarSubItem = CType(mBarManager.Items("Component"), BarSubItem)
            BarItemLink = BarSubItem.ItemLinks.Add(mBarManager.Items(BarItemName))

            'put the item name in
            BarItemLink.Caption = BarItemLink.Caption.Replace("<Item>", ItemName)

            'put the price in 
            If BarItemLink.Caption.IndexOf("<Price>") <> -1 Then
                If Price = "" Then
                    BarItemLink.Caption = BarItemLink.Caption.Replace("(<Price>) ", "")
                Else
                    BarItemLink.Caption = BarItemLink.Caption.Replace("<Price>", Price)
                End If
            End If

            If BeginGroup Then
                BarItemLink.BeginGroup = True
                BeginGroup = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add link to popupmenu
    Private Shared Sub AddLinkToPopupMenu(ByVal BarItemName As String)
        Dim BarItemLink As BarItemLink

        Try
            BarItemLink = mPopupMenu.AddItem(mBarManager.Items(BarItemName))

            'If Not BarItemLink.Caption = "Edit Rule Page" And (BarItemLink.Caption.StartsWith("Edit") Or General.ShoppingCart) Then
            If BarItemLink.Caption.StartsWith("Edit") And Not BarItemLink.Caption.StartsWith("Edit Rule Page") Then
                If Commands.EditForm Is Nothing Then
                    BarItemLink.Item.Glyph = Image.FromFile(General.BasePath & "Icons\form_blue.png")
                Else
                    BarItemLink.Caption = BarItemLink.Caption.Replace("Edit", "View")
                    BarItemLink.Item.Glyph = Image.FromFile(General.BasePath & "Icons\form_green.png")
                End If
            End If

            If BeginGroup Then
                BarItemLink.BeginGroup = True
                BeginGroup = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add link to popupmenu
    Private Shared Sub AddCartLinkToPopupMenu(ByVal BarItemName As String, ByVal ItemName As String, ByVal Price As String)
        Dim BarItemLink As BarItemLink

        Try
            BarItemLink = mPopupMenu.AddItem(mBarManager.Items(BarItemName))

            'put the item name in
            BarItemLink.Caption = BarItemLink.Caption.Replace("<Item>", ItemName)

            'put the price in 
            If BarItemLink.Caption.IndexOf("<Price>") <> -1 Then
                If Price = "" Then
                    BarItemLink.Caption = BarItemLink.Caption.Replace("(<Price>) ", "")
                Else
                    BarItemLink.Caption = BarItemLink.Caption.Replace("<Price>", Price)
                End If
            End If

            If BeginGroup Then
                BarItemLink.BeginGroup = True
                BeginGroup = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bar sub item to the manager
    Private Shared Sub AddBarSubItem(ByVal Caption As String)
        Dim BarSubItem As New BarSubItem
        Try
            BarSubItem.Manager = mBarManager
            BarSubItem.Caption = Caption
            BarSubItem.Width = 100
            Caption = Caption.Replace(" ", "")
            Caption = Caption.Replace("&", "")
            BarSubItem.Name = Caption
            mBarManager.Items.Add(BarSubItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bar button item to the manager
    Private Shared Sub AddBarButtonItem(ByVal Caption As String, ByVal ItemClickHandler As ItemClickEventHandler)
        Dim BarButtonItem As New BarButtonItem

        Try
            BarButtonItem.Manager = mBarManager
            BarButtonItem.Caption = Caption
            Caption = Caption.Replace(" ", "")
            Caption = Caption.Replace("&", "")
            BarButtonItem.Name = Caption
            AddHandler BarButtonItem.ItemClick, ItemClickHandler
            'Handlers.Add(Caption, ItemClickHandler)
            mBarManager.Items.Add(BarButtonItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bar button item to the manager
    Private Shared Sub AddBarButtonItem(ByVal Caption As String, ByVal Hint As String, ByVal IconFilename As String, ByVal ItemClickHandler As ItemClickEventHandler)
        Dim BarButtonItem As New BarButtonItem

        Try
            BarButtonItem.Manager = mBarManager
            BarButtonItem.Caption = Caption
            BarButtonItem.Hint = Hint
            Caption = Caption.Replace(" ", "")
            Caption = Caption.Replace("&", "")
            BarButtonItem.Name = Caption
            If IconFilename <> "" Then BarButtonItem.Glyph = Image.FromFile(General.BasePath & "Icons\" & IconFilename)
            AddHandler BarButtonItem.ItemClick, ItemClickHandler
            'Handlers.Add(Caption, ItemClickHandler)
            mBarManager.Items.Add(BarButtonItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bar button item to the manager
    Private Shared Sub AddBarButtonItem(ByVal Name As String, ByVal Caption As String, ByVal Hint As String, ByVal IconFilename As String, ByVal ItemClickHandler As ItemClickEventHandler)
        Dim BarButtonItem As New BarButtonItem

        Try
            BarButtonItem.Manager = mBarManager
            BarButtonItem.Caption = Caption
            BarButtonItem.Hint = Hint
            BarButtonItem.Name = Name
            If IconFilename <> "" Then BarButtonItem.Glyph = Image.FromFile(General.BasePath & "Icons\" & IconFilename)
            AddHandler BarButtonItem.ItemClick, ItemClickHandler
            'Handlers.Add(Caption, ItemClickHandler)
            mBarManager.Items.Add(BarButtonItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creates baritems for the XSL Transformations
    Private Shared Sub AddXSLItem(ByVal Caption As String, ByVal ItemClickHandler As ItemClickEventHandler, Optional ByVal IconFilename As String = "")
        Dim BarButtonItem As New BarButtonItem
        Dim BarItemLink As BarItemLink
        Try
            BarButtonItem.Manager = mBarManager
            BarButtonItem.Caption = Caption
            Caption = Caption.Replace(" ", "")
            Caption = Caption.Replace("&", "")
            BarButtonItem.Name = Caption
            If IconFilename <> "" Then BarButtonItem.Glyph = Image.FromFile(General.BasePath & "Icons\" & IconFilename)
            AddHandler BarButtonItem.ItemClick, ItemClickHandler
            mBarManager.Items.Add(BarButtonItem)
            BarItemLink = mXSLMenu.AddItem(BarButtonItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creates baritems for the templates submenu
    Private Shared Function CreateTemplateItem(ByVal Template As ITemplate, ByVal ItemClickHandler As ItemClickEventHandler, Optional ByVal IconFilename As String = "") As BarButtonItem
        Dim BarButtonItem As New BarButtonItem

        Try
            BarButtonItem.Manager = mBarManager
            BarButtonItem.Caption = Template.TemplateName
            BarButtonItem.Tag = Template
            AddHandler BarButtonItem.ItemClick, ItemClickHandler
            mBarManager.Items.Add(BarButtonItem)

            Return BarButtonItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'add a checkable bar button item to the manager
    Private Shared Sub AddCheckBarButtonItem(ByVal Caption As String, ByVal Hint As String, ByVal IconFilename As String, ByVal ItemClickHandler As ItemClickEventHandler, Optional ByVal GroupIndex As Integer = 0)
        Dim BarButtonItem As New BarButtonItem

        Try
            BarButtonItem.ButtonStyle = BarButtonStyle.Check
            BarButtonItem.GroupIndex = GroupIndex
            BarButtonItem.Manager = mBarManager
            BarButtonItem.Caption = Caption
            BarButtonItem.Hint = Hint
            Caption = Caption.Replace(" ", "")
            Caption = Caption.Replace("&", "")
            BarButtonItem.Name = Caption
            BarButtonItem.Glyph = Image.FromFile(General.BasePath & "Icons\" & IconFilename)
            AddHandler BarButtonItem.ItemClick, ItemClickHandler
            'Handlers.Add(Caption, ItemClickHandler)
            mBarManager.Items.Add(BarButtonItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a combobox edit  to the manager
    Private Shared Sub AddComboBox(ByVal ComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox, ByVal Name As String, ByVal Caption As String, ByVal Width As Integer, ByVal Hint As String, ByVal IconFilename As String, ByVal ValueChangedHandler As EventHandler)
        Dim BarEditItem As New BarEditItem
        Try
            ComboBox.Name = Name & "ComboBox"
            ComboBox.DropDownRows = 30
            ComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            BarEditItem.Name = Name
            BarEditItem.Caption = Caption
            BarEditItem.Edit = ComboBox
            BarEditItem.PaintStyle = BarItemPaintStyle.CaptionGlyph
            BarEditItem.Width = Width
            BarEditItem.Manager = mBarManager
            BarEditItem.Hint = Hint
            BarEditItem.Glyph = Image.FromFile(General.BasePath & "Icons\" & IconFilename)
            AddHandler BarEditItem.EditValueChanged, ValueChangedHandler
            'Handlers.Add(Name, ValueChangedHandler)
            mBarManager.Items.Add(BarEditItem)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bar item to the toolbar
    Private Shared Sub AddBarItemToToolbar(ByVal Toolbar As Bar, ByVal Name As String, Optional ByVal Style As BarItemPaintStyle = BarItemPaintStyle.Standard)
        Dim BarItem As BarItem
        Dim BarItemLink As BarItemLink

        Try
            BarItem = mBarManager.Items(Name)
            BarItemLink = Toolbar.ItemLinks.Add(BarItem)
            BarItemLink.UserPaintStyle = Style
            If BeginGroup Then
                BarItemLink.BeginGroup = True
                BeginGroup = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bar item to the toolbar at the specified position
    Private Shared Sub AddBarItemToToolbar(ByVal Position As Integer, ByVal Name As String, Optional ByVal Style As BarItemPaintStyle = BarItemPaintStyle.Standard)
        Dim BarItem As BarItem
        Dim BarItemLink As BarItemLink

        Try
            BarItem = mBarManager.Items(Name)
            BarItemLink = mToolbar.ItemLinks.Insert(Position, BarItem)
            BarItemLink.UserPaintStyle = Style

            If BarItemLink.Caption.StartsWith("Edit") And Not BarItemLink.Caption.StartsWith("Edit Rule Page") Then
                If Commands.EditForm Is Nothing Then
                    BarItemLink.Item.Glyph = Image.FromFile(General.BasePath & "Icons\form_blue.png")
                Else
                    BarItemLink.Caption = BarItemLink.Caption.Replace("Edit", "View")
                    BarItemLink.Item.Glyph = Image.FromFile(General.BasePath & "Icons\form_green.png")
                End If
            End If

            If BeginGroup Then
                BarItemLink.BeginGroup = True
                BeginGroup = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the bar item
    Public Shared Function GetBarItem(ByVal Name As String) As BarItem
        Try
            Return mBarManager.Items(Name)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Rules"

    Private Shared Sub RuleActivateDeactivate()
        Dim BaseItem As Objects.ObjectData = FocusObject.GetFKObject("Item")
        If BaseItem.IsEmpty Then Exit Sub

        Select Case BaseItem.Type
            Case Objects.ItemDefinitionType, Objects.ArtifactDefinitionType, Objects.WondrousDefinitionType, Objects.RingDefinitionType, Objects.StaffDefinitionType, Objects.RodDefinitionType, Objects.UniversalItemDefinitionType, Objects.PsionicArtifactDefinitionType, Objects.PsionicPsicrownDefinitionType
                If FocusObject.Element("Active") = "Yes" Then
                    Deactivate = True
                ElseIf FocusObject.Element("Active") = "No" Then
                    Activate = True
                Else
                    If BaseItem.HasChildren Then Activate = True
                End If
        End Select
    End Sub

    Private Shared Sub RuleAddSyncSpells()
        Try
            'if this is a spell folder for a spell list style caster
            If FocusObject.GetFKObject("Class").Element("SpellAcquisition") = "List" Then
                SyncSpells = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddUnique(ByRef Flag As Boolean, ByRef Type As String)
        Try
            If Not FocusChildren.ContainsType(Type) Then Flag = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddDamageAddition()
        Dim Temp As String

        Try
            If FocusObject.Type = Objects.ConditionType Then Temp = FocusParent.Type Else Temp = FocusObject.Type

            Select Case Temp
                Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                    AddDamageAddition = True
                Case Objects.WeaponMagicAbilityDefinitionType, Objects.PsionicWeaponAbilityDefinitionType
                    AddDamageAddition = True
                Case Objects.MagicAmmoDefinitionType, Objects.PsionicAmmoDefinitionType
                    AddDamageAddition = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddDeleteCharacterLevel()
        Dim Character As Rules.Character
        Dim CharacterLevelsFolder As New Objects.ObjectData

        Try
            Character = CharacterManager.CurrentCharacter
            If Not Character Is Nothing Then

                'get the levels folder
                Select Case FocusObject.Type
                    Case Objects.CharacterType, Objects.MonsterType
                        CharacterLevelsFolder = FocusObject.FirstChildOfType(Objects.CharacterLevelsFolderType)
                    Case Objects.CharacterLevelsFolderType
                        CharacterLevelsFolder = FocusObject
                End Select

                'set delete command
                If CharacterLevelsFolder.Children.Count > 0 Then DeleteCharacterLevel = True

                'if its a mount with levels already then exit
                If Character.CharacterObject.Element("Mount") = "Yes" AndAlso CharacterManager.CurrentCharacter.CharacterLevel > 0 Then
                    Exit Sub
                End If

                'if it is a monster with a level already and it has less than 1 racial hitdice then exit
                If Character.CharacterType = Rules.Character.CharacterObjectType.Monster AndAlso Character.CharacterLevel > 0 Then
                    Dim HitDiceMultiplier As Double = Character.RaceObject.ElementAsNumber("DiceNumber")
                    If HitDiceMultiplier < 1 Then
                        Exit Sub
                    End If
                End If

                Select Case General.Mode

                    Case General.AppMode.Full
                        If CharacterManager.CurrentCharacter.EffectiveCharacterLevel < Rules.Constants.MaxLevels Then AddCharacterLevels = True

                    Case General.AppMode.Trial
                        If CharacterManager.CurrentCharacter.CharacterLevel < 5 Then AddCharacterLevels = True
                End Select

            End If

            'Select Case General.Mode

            '    Case General.AppMode.Full
            '        Select Case FocusObject.Type
            '            Case Objects.CharacterType, Objects.MonsterType

            '                If CharacterManager.CurrentCharacter.CharacterObject.Element("Mount") = "Yes" AndAlso CharacterManager.CurrentCharacter.CharacterLevel > 0 Then
            '                    'do nothing
            '                Else
            '                    If CharacterManager.CurrentCharacter.EffectiveCharacterLevel < Rules.Constants.MaxLevels Then AddCharacterLevels = True
            '                End If

            '                If FocusObject.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then DeleteCharacterLevel = True

            '            Case Objects.CharacterLevelsFolderType
            '                If CharacterManager.CurrentCharacter.CharacterObject.Element("Mount") = "Yes" AndAlso CharacterManager.CurrentCharacter.CharacterLevel > 0 Then
            '                    'do nothing
            '                Else
            '                    If CharacterManager.CurrentCharacter.EffectiveCharacterLevel < Rules.Constants.MaxLevels Then AddCharacterLevels = True
            '                End If
            '                If FocusObject.Parent.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then DeleteCharacterLevel = True
            '        End Select

            '    Case General.AppMode.Trial
            '        Select Case FocusObject.Type
            '            Case Objects.CharacterType, Objects.MonsterType
            '                If CharacterManager.CurrentCharacter.CharacterObject.Element("Mount") = "Yes" AndAlso CharacterManager.CurrentCharacter.CharacterLevel > 0 Then
            '                    'do nothing
            '                Else
            '                    If CharacterManager.CurrentCharacter.CharacterLevel < 5 Then AddCharacterLevels = True
            '                End If

            '                If FocusObject.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then DeleteCharacterLevel = True

            '            Case Objects.CharacterLevelsFolderType
            '                If CharacterManager.CurrentCharacter.CharacterObject.Element("Mount") = "Yes" AndAlso CharacterManager.CurrentCharacter.CharacterLevel > 0 Then
            '                    'do nothing
            '                Else
            '                    If CharacterManager.CurrentCharacter.CharacterLevel < 5 Then AddCharacterLevels = True
            '                End If
            '                If FocusObject.Parent.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then DeleteCharacterLevel = True
            '        End Select

            'End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleCharacterEditCommand()
        Try
            Select Case CharacterManager.CurrentCharacter.CharacterType
                Case Rules.Character.CharacterObjectType.Familiar, Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                    EditCompanion = True
                Case Rules.Character.CharacterObjectType.Character
                    EditCharacter = True
                Case Rules.Character.CharacterObjectType.Monster
                    EditMonster = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleApplyTemplate()
        '    Try
        '        For Each TemplateItem As BarButtonItemLink In mTemplateMenu.ItemLinks
        '            Dim Template As ITemplate = DirectCast(TemplateItem.Item.Tag, ITemplate)
        '            If Template.CanAquire(CharacterManager.CurrentCharacter) Then
        '                TemplateItem.Item.Enabled = True
        '            Else
        '                TemplateItem.Item.Enabled = False
        '            End If
        '        Next
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message, ex)
        '    End Try
    End Sub

    Private Shared Sub RuleClassEditCommand()
        Try
            Select Case FocusObject.Element("ClassType")
                Case "Companion"
                    EditMonsterClass = True
                Case Else
                    EditClass = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleShowCharacterSheet()
        Try
            If FocusObject.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                PrintCharacterSheet = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddClassLevel()
        Try
            Select Case FocusObject.Type
                Case Objects.ClassLevelsFolderType
                    If FocusObject.ChildrenOfType(Objects.ClassLevelType).Count < Rules.Constants.MaxLevels Then AddClassLevel = True
                Case Objects.MonsterClassLevelsFolderType
                    If FocusObject.ChildrenOfType(Objects.MonsterClassLevelType).Count < Rules.Constants.MaxLevels Then AddClassLevel = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleCreateClassLevels()
        Try
            Select Case FocusObject.Type
                Case Objects.ClassLevelsFolderType
                    If FocusObject.ChildrenOfType(Objects.ClassLevelType).Count = 0 Then CreateClassLevels = True
                Case Objects.ClassType
                    If FocusObject.FirstChildOfType(Objects.ClassLevelsFolderType).ChildrenOfType(Objects.ClassLevelType).Count = 0 Then CreateClassLevels = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleModifiers()

        If FocusParent.Type = Objects.ModifierFolderType Then
            Cut = False
            Copy = False
            If FocusObject.Element("Disabled") = "Yes" Then EnableUserModifier = True Else DisableUserModifier = True
            EditUserModifier = True
        Else
            EditModifier = True
        End If

    End Sub

    Private Shared Sub RulesCharacterFeats()
        'Enable/Disable
        If FocusObject.Element("Disabled") = "Yes" Then EnableFeat = True Else DisableFeat = True

        'Prereq - 3 states "Yes", "No", ""
        If FocusObject.Element("Overrides") = "Yes" Then StopOverrideFeatPrereq = True
        If FocusObject.Element("Overrides") = "No" Then OverrideFeatPrereq = True

        'Deleteing
        If FocusObject.Element("Source") = "User" Then DeleteObjects = True Else DeleteObjects = False

        'Editing
        If Not FocusObject.Element("SourceType") = Rules.AvailableFeats.PathAutomaticFeat Then EditFeat = True

    End Sub

    Private Shared Sub RuleCharacterFeatureMode()
        Dim WindowObject As Objects.ObjectData = WindowManager.CurrentWindow.Folder
        If CType(General.MainExplorer.TreeView.SelectedNode.Tag, Explorer.ObjectTagData).ObjectGUID.Equals(WindowObject.ObjectGUID) Then
            If CType(General.MainExplorer.CurrentPanel, FeaturesPanel).PanelMode = FeaturesPanel.FeaturePanelMode.EditMode Then
                FeatureViewMode = True
            Else
                FeatureEditMode = True
            End If
        End If
    End Sub

    Private Shared Sub RuleCharacterFeatures()
        If CType(General.MainExplorer.CurrentPanel, FeaturesPanel).PanelMode = FeaturesPanel.FeaturePanelMode.EditMode Then
            FeatureViewMode = True
            EditCharacterFeature = True
            If FocusObject.Element("Disabled") = "Yes" Then EnableFeature = True Else DisableFeature = True
            If FocusObject.Element("Source") = "User" Then DeleteObjects = True Else DeleteObjects = False

            'Prereq - 3 states "Yes", "No", ""
            If FocusObject.Element("Overrides") = "Yes" Then StopOverrideFeatPrereq = True
            If FocusObject.Element("Overrides") = "No" Then OverrideFeatPrereq = True

        Else
            FeatureEditMode = True
            DeleteObjects = False
        End If
    End Sub

    Private Shared Sub RuleAddBonusDomain(ByRef Flag As Boolean)
        If FocusParent.Parent.Element("CasterAbility") = "Yes" OrElse (FocusParent.Parent.Element("CasterAbility") = "Prestige Advancement" AndAlso FocusParent.Parent.Element("PrestigeSpellType") <> "") Then
            Flag = True
        End If
    End Sub

    Private Shared Sub RuleAddBonusPsionicSpecialization(ByRef Flag As Boolean)
        If FocusParent.Parent.Element("CasterAbility") = "Psionic" OrElse (FocusParent.Parent.Element("CasterAbility") = "Prestige Advancement" AndAlso FocusParent.Parent.Element("AdvanceManifester") = "True") Then
            Flag = True
        End If
    End Sub

    Private Shared Sub RuleAddDomainsAndSchools()

        'if we have any spellcasters
        Dim Character As Rules.Character = CharacterManager.CurrentCharacter

        'check for racial caster ability
        If Character.IsRacialCaster Then

            AddDomain = True
            AddSpecialistSchool = True
            AddProhibitedSchool = True

        Else

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim CharacterClass As Rules.CharacterClass = Caches.GetCharacterClass(ClassKey)

                Select Case CharacterClass.ClassObj.Element("CasterAbility")
                    Case "Yes"
                        AddDomain = True
                        AddSpecialistSchool = True
                        AddProhibitedSchool = True

                    Case "Prestige Advancement"
                        If CharacterClass.ClassObj.Element("PrestigeSpellType") <> "" Then
                            AddDomain = True
                        End If
                End Select

                If AddDomain And AddSpecialistSchool Then Exit For
            Next

        End If

    End Sub

    Private Shared Sub RuleAddPsionicSpecialization()

        'if we have any manifesters
        Dim Character As Rules.Character = CharacterManager.CurrentCharacter

        If Character.IsRacialManifester Then

            CharacterAddDisciplineSpecialization = True

        Else

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim CharacterClass As Rules.CharacterClass = caches.GetCharacterClass(ClassKey)

                Select Case CharacterClass.ClassObj.Element("CasterAbility")
                    Case "Psionic"
                        CharacterAddDisciplineSpecialization = True

                    Case "Prestige Advancement"
                        If CharacterClass.ClassObj.Element("AdvanceManifester") = "True" Then
                            CharacterAddDisciplineSpecialization = True
                        End If
                End Select

                If CharacterAddDisciplineSpecialization Then Exit For
            Next

        End If

    End Sub

    Private Shared Sub RuleAddDamageReduction()
        Try
            Select Case FocusObject.Type
                Case Objects.ArmorMagicAbilityDefinitionType
                    If Not FocusChildren.ContainsType(Objects.DamageReductionType) Then AddDamageReduction = True
                Case Objects.ConditionType
                    If FocusParent.Type = Objects.SpecificArmorDefinitionType Then
                        If Not FocusChildren.ContainsType(Objects.DamageReductionType) Then AddDamageReduction = True
                    End If
                Case Objects.SpecificArmorDefinitionType
                    If Not FocusChildren.ContainsType(Objects.DamageReductionType) Then AddDamageReduction = True
                Case Else
                    If Not FocusChildren.ContainsType(Objects.DamageReductionType) Then AddDamageReduction = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddDamageResistance()
        Dim RealFocus As Objects.ObjectData

        Try
            If FocusObject.Type = Objects.ConditionType Then RealFocus = FocusObject.Parent Else RealFocus = FocusObject

            Select Case RealFocus.Type
                Case Objects.SpecificWeaponDefinitionType, Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType, Objects.PsionicWeaponDefinitionType, Objects.ArmorMagicAbilityDefinitionType, Objects.PsionicArmorAbilityDefinitionType
                    AddDamageResistance = True
                Case Objects.WeaponMagicAbilityDefinitionType, Objects.PsionicWeaponAbilityDefinitionType
                    Select Case RealFocus.Element("WeaponType")
                        Case "Melee Weapons Only", "Ranged Weapons Only", "Thrown Weapons Only"
                            AddDamageResistance = True
                    End Select
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddItem()
        If FocusObject.Element("IsContainer") = "Yes" Then
            AddItem = True
        Else
            Dim Container As Objects.ObjectData = FocusObject.GetFKObject("Item")
            If Container.IsEmpty Then Exit Sub
            If Container.Element("IsContainer") = "Yes" Then AddItem = True
        End If
    End Sub

    Private Shared Sub RuleAddMoney()
        If FocusObject.Element("IsContainer") = "Yes" Then
            AddMoney = True
            Exit Sub
        End If

        Dim Container As Objects.ObjectData = FocusObject.GetFKObject("Item")
        If Container.IsEmpty Then Exit Sub
        If Container.Element("IsContainer") = "Yes" Or Container.Type = Objects.InventoryFolderType Or Container.Type = Objects.AssetsFolderType Then AddMoney = True
    End Sub

    Private Shared Sub RuleAddModifier()
        Try
            Select Case FocusObject.Type
                Case Objects.ConditionType
                    'modifiers cannot be added to ammo
                    Select Case FocusParent.Type
                        Case Objects.MagicAmmoDefinitionType

                        Case Objects.WeaponMagicAbilityDefinitionType, Objects.PsionicWeaponAbilityDefinitionType
                            If FocusParent.Element("WeaponType") = "Melee Weapons Only" Or FocusParent.Element("WeaponType") = "Ranged Weapons Only" Then
                                AddModifier = True
                            End If
                        Case Else
                            AddModifier = True
                    End Select
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddSystemWeaponAbility()
        Dim Temp As String

        Try
            If FocusObject.Type = Objects.ConditionType Then Temp = FocusParent.Type Else Temp = FocusObject.Type

            Select Case Temp
                Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                    AddSystemWeaponAbility = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddWeaponMagicAbility()
        Dim Temp As String

        Try
            If FocusObject.Type = Objects.ConditionType Then Temp = FocusParent.Type Else Temp = FocusObject.Type

            Select Case Temp
                Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                    AddWeaponMagicAbility = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddPsionicWeaponAbility()
        Dim Temp As String

        Try
            If FocusObject.Type = Objects.ConditionType Then Temp = FocusParent.Type Else Temp = FocusObject.Type

            Select Case Temp
                Case Objects.PsionicWeaponDefinitionType
                    AddPsionicWeaponAbility = True
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleDelete()
        Try
            Select Case FocusObject.Type
                Case Objects.ClassLevelType
                    Dim CharacterClass As Rules.CharacterClass = caches.GetCharacterClass(FocusObject.Parent.ParentGUID)
                    If FocusObject.ObjectGUID.Equals(CharacterClass.HighestClassLevel.ObjectGUID) Then DeleteObjects = True Else DeleteObjects = False
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleScribeScroll()
        Try
            If FocusObject.Type = Objects.InventoryFolderType Then
                ScribeScroll = True
                ImprintStone = True
            Else
                If FocusObject.Element("Item") <> "" Then
                    Dim Container As Objects.ObjectData = FocusObject.GetFKObject("Item")
                    If Container.Element("IsContainer") = "Yes" Then
                        ScribeScroll = True
                        ImprintStone = True
                    End If
                Else
                    If FocusObject.Element("IsContainer") = "Yes" Then
                        ScribeScroll = True
                        ImprintStone = True
                    End If
                End If
            End If

            If FocusObject.Element("ItemType") = Objects.ScrollDefinitionType Then EditScroll = True
            If FocusObject.Element("ItemType") = Objects.PsionicPowerStoneDefinitionType Then EditStone = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddPsilLike()
        Try
            If CharacterManager.CurrentCharacter.CharacterObject.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                AddPsiLikeAbilityTaken = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleAddSpellLike()
        Try
            If CharacterManager.CurrentCharacter.CharacterObject.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                AddSpellLikeAbilityTaken = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared Sub RuleUpdateMemorizedSpells()
        Try
            'only allow command if there is at least one memorized spell component
            Select Case FocusObject.Type
                Case Objects.MemorizedSpellType
                    UpdateMemorizedSpells = True
                Case Objects.MemorizedSpellsFolderType
                    If FocusChildren.Count > 0 Then
                        UpdateMemorizedSpells = True
                    End If
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
