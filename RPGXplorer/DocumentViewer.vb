Option Explicit On 
Option Strict On

Imports RPGXplorer.Explorer
Imports RPGXplorer.TreeManager
Imports RPGXplorer.General
Imports RPGXplorer.Exceptions
Imports RPGXplorer.Objects
Imports System.Drawing
Imports System.Xml

Imports DevExpress.XtraTab


Public Class DocumentViewer
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        IsLoading = True

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call        
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents Splitter2 As System.Windows.Forms.Splitter
	Public WithEvents NavBarSplitter As System.Windows.Forms.Splitter
    Public WithEvents TabControl12 As System.Windows.Forms.TabControl
    Public WithEvents Bar1 As DevExpress.XtraBars.Bar
    Public WithEvents Bar2 As DevExpress.XtraBars.Bar
    Public WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Public WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Public WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Public WithEvents CutButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents PasteButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents FolderUpButtomItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents FolderExpandButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents FolderCollapseButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents CloseTabButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents OpenInNewTabButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Public WithEvents RenameButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents PropertiesButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents AddFolderButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents DeleteButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents Splitter3 As System.Windows.Forms.Splitter
    Public WithEvents NewTabButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents ImageList2 As System.Windows.Forms.ImageList
    Public WithEvents AddToFavoritesButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Public WithEvents AddRulePageButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents AddTableButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents AddFolderPageButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Public WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents CopyBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents EditRulePageBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents ResetTreeButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents TreeView1 As System.Windows.Forms.TreeView
    Public WithEvents TreeView2 As System.Windows.Forms.TreeView
    Public WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents LoadComponentsButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents SaveComponentsButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents CloseButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents RefreshButtonItem As DevExpress.XtraBars.BarButtonItem
    Public WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Public WithEvents ContentsDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Public WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Public WithEvents FavoritesDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Public WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Public WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Public WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentViewer))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.LoadComponentsButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.SaveComponentsButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.RefreshButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.CloseButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem
        Me.CutButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.CopyBarButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.PasteButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
        Me.AddFolderButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.AddFolderPageButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.AddRulePageButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.AddTableButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.FolderUpButtomItem = New DevExpress.XtraBars.BarButtonItem
        Me.FolderExpandButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.FolderCollapseButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.AddToFavoritesButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.RenameButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.PropertiesButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.EditRulePageBarButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.DeleteButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.ResetTreeButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.NewTabButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.OpenInNewTabButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.CloseTabButtonItem = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel
        Me.ContentsDockPanel = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.FavoritesDockPanel = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.TabControl12 = New System.Windows.Forms.TabControl
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.NavBarSplitter = New System.Windows.Forms.Splitter
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContainer1.SuspendLayout()
        Me.ContentsDockPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.FavoritesDockPanel.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CutButtonItem, Me.PasteButtonItem, Me.FolderUpButtomItem, Me.FolderExpandButtonItem, Me.FolderCollapseButtonItem, Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.CloseTabButtonItem, Me.OpenInNewTabButtonItem, Me.RenameButtonItem, Me.PropertiesButtonItem, Me.AddFolderButtonItem, Me.DeleteButtonItem, Me.NewTabButtonItem, Me.AddToFavoritesButtonItem, Me.AddRulePageButtonItem, Me.AddTableButtonItem, Me.AddFolderPageButtonItem, Me.BarSubItem4, Me.BarButtonItem1, Me.CopyBarButtonItem, Me.EditRulePageBarButtonItem, Me.ResetTreeButtonItem, Me.BarButtonItem2, Me.LoadComponentsButtonItem, Me.SaveComponentsButtonItem, Me.CloseButtonItem, Me.BarButtonItem3, Me.RefreshButtonItem, Me.BarSubItem5})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 36
        '
        'Bar1
        '
        Me.Bar1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.Appearance.Options.UseFont = True
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&File"
        Me.BarSubItem1.Id = 6
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.LoadComponentsButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.SaveComponentsButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.RefreshButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseButtonItem, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'LoadComponentsButtonItem
        '
        Me.LoadComponentsButtonItem.Caption = "&Load Components"
        Me.LoadComponentsButtonItem.Glyph = CType(resources.GetObject("LoadComponentsButtonItem.Glyph"), System.Drawing.Image)
        Me.LoadComponentsButtonItem.Id = 30
        Me.LoadComponentsButtonItem.Name = "LoadComponentsButtonItem"
        '
        'SaveComponentsButtonItem
        '
        Me.SaveComponentsButtonItem.Caption = "&Save Components"
        Me.SaveComponentsButtonItem.Glyph = CType(resources.GetObject("SaveComponentsButtonItem.Glyph"), System.Drawing.Image)
        Me.SaveComponentsButtonItem.Id = 31
        Me.SaveComponentsButtonItem.Name = "SaveComponentsButtonItem"
        '
        'RefreshButtonItem
        '
        Me.RefreshButtonItem.Caption = "&Refresh"
        Me.RefreshButtonItem.Glyph = CType(resources.GetObject("RefreshButtonItem.Glyph"), System.Drawing.Image)
        Me.RefreshButtonItem.Hint = "Reload the rules viewer so that any newly loaded Rules or Favorites are displayed" & _
            "."
        Me.RefreshButtonItem.Id = 34
        Me.RefreshButtonItem.Name = "RefreshButtonItem"
        '
        'CloseButtonItem
        '
        Me.CloseButtonItem.Caption = "&Close"
        Me.CloseButtonItem.Id = 32
        Me.CloseButtonItem.Name = "CloseButtonItem"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "&Edit"
        Me.BarSubItem4.Id = 21
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CutButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.CopyBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.PasteButtonItem)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'CutButtonItem
        '
        Me.CutButtonItem.Caption = "Cut"
        Me.CutButtonItem.Glyph = CType(resources.GetObject("CutButtonItem.Glyph"), System.Drawing.Image)
        Me.CutButtonItem.Hint = "Put components onto the clipboard for moving"
        Me.CutButtonItem.Id = 0
        Me.CutButtonItem.Name = "CutButtonItem"
        '
        'CopyBarButtonItem
        '
        Me.CopyBarButtonItem.Caption = "Copy"
        Me.CopyBarButtonItem.Glyph = CType(resources.GetObject("CopyBarButtonItem.Glyph"), System.Drawing.Image)
        Me.CopyBarButtonItem.Hint = "Put components onto the clipboard for copying"
        Me.CopyBarButtonItem.Id = 25
        Me.CopyBarButtonItem.Name = "CopyBarButtonItem"
        '
        'PasteButtonItem
        '
        Me.PasteButtonItem.Caption = "Paste"
        Me.PasteButtonItem.Glyph = CType(resources.GetObject("PasteButtonItem.Glyph"), System.Drawing.Image)
        Me.PasteButtonItem.Hint = "Paste copies or move components from the clipboard to the currently selected comp" & _
            "onent or folder"
        Me.PasteButtonItem.Id = 2
        Me.PasteButtonItem.Name = "PasteButtonItem"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "&Component"
        Me.BarSubItem2.Id = 7
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.AddFolderButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.AddFolderPageButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddRulePageButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddTableButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderUpButtomItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderExpandButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderCollapseButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddToFavoritesButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.RenameButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PropertiesButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.EditRulePageBarButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteButtonItem, True)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'AddFolderButtonItem
        '
        Me.AddFolderButtonItem.Caption = "Add Folder"
        Me.AddFolderButtonItem.Glyph = CType(resources.GetObject("AddFolderButtonItem.Glyph"), System.Drawing.Image)
        Me.AddFolderButtonItem.Hint = "Add a folder to the current folder."
        Me.AddFolderButtonItem.Id = 13
        Me.AddFolderButtonItem.Name = "AddFolderButtonItem"
        Me.AddFolderButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        '
        'AddFolderPageButtonItem
        '
        Me.AddFolderPageButtonItem.Caption = "Add Folder Page"
        Me.AddFolderPageButtonItem.Glyph = CType(resources.GetObject("AddFolderPageButtonItem.Glyph"), System.Drawing.Image)
        Me.AddFolderPageButtonItem.Hint = "Add a folder page to the current folder."
        Me.AddFolderPageButtonItem.Id = 20
        Me.AddFolderPageButtonItem.Name = "AddFolderPageButtonItem"
        '
        'AddRulePageButtonItem
        '
        Me.AddRulePageButtonItem.Caption = "Add Rule Page"
        Me.AddRulePageButtonItem.Glyph = CType(resources.GetObject("AddRulePageButtonItem.Glyph"), System.Drawing.Image)
        Me.AddRulePageButtonItem.Hint = "Add a rule page to the current folder."
        Me.AddRulePageButtonItem.Id = 18
        Me.AddRulePageButtonItem.Name = "AddRulePageButtonItem"
        '
        'AddTableButtonItem
        '
        Me.AddTableButtonItem.Caption = "Add Table"
        Me.AddTableButtonItem.Glyph = CType(resources.GetObject("AddTableButtonItem.Glyph"), System.Drawing.Image)
        Me.AddTableButtonItem.Hint = "Add a table to the current folder."
        Me.AddTableButtonItem.Id = 19
        Me.AddTableButtonItem.Name = "AddTableButtonItem"
        '
        'FolderUpButtomItem
        '
        Me.FolderUpButtomItem.Caption = "Folder Up"
        Me.FolderUpButtomItem.Glyph = CType(resources.GetObject("FolderUpButtomItem.Glyph"), System.Drawing.Image)
        Me.FolderUpButtomItem.Hint = "Move up the folder structure one level"
        Me.FolderUpButtomItem.Id = 3
        Me.FolderUpButtomItem.Name = "FolderUpButtomItem"
        '
        'FolderExpandButtonItem
        '
        Me.FolderExpandButtonItem.Caption = "Folder Expand"
        Me.FolderExpandButtonItem.Glyph = CType(resources.GetObject("FolderExpandButtonItem.Glyph"), System.Drawing.Image)
        Me.FolderExpandButtonItem.Hint = "Expand the current folder and all its subfolders"
        Me.FolderExpandButtonItem.Id = 4
        Me.FolderExpandButtonItem.Name = "FolderExpandButtonItem"
        '
        'FolderCollapseButtonItem
        '
        Me.FolderCollapseButtonItem.Caption = "Folder Collapse"
        Me.FolderCollapseButtonItem.Glyph = CType(resources.GetObject("FolderCollapseButtonItem.Glyph"), System.Drawing.Image)
        Me.FolderCollapseButtonItem.Hint = "Collapse the current folder and all its subfolders"
        Me.FolderCollapseButtonItem.Id = 5
        Me.FolderCollapseButtonItem.Name = "FolderCollapseButtonItem"
        '
        'AddToFavoritesButtonItem
        '
        Me.AddToFavoritesButtonItem.Caption = "Add To Favorites"
        Me.AddToFavoritesButtonItem.Glyph = CType(resources.GetObject("AddToFavoritesButtonItem.Glyph"), System.Drawing.Image)
        Me.AddToFavoritesButtonItem.Hint = "Add this page or folder page to your favorites."
        Me.AddToFavoritesButtonItem.Id = 16
        Me.AddToFavoritesButtonItem.Name = "AddToFavoritesButtonItem"
        '
        'RenameButtonItem
        '
        Me.RenameButtonItem.Caption = "&Rename"
        Me.RenameButtonItem.Id = 11
        Me.RenameButtonItem.Name = "RenameButtonItem"
        '
        'PropertiesButtonItem
        '
        Me.PropertiesButtonItem.Caption = "Properties"
        Me.PropertiesButtonItem.Glyph = CType(resources.GetObject("PropertiesButtonItem.Glyph"), System.Drawing.Image)
        Me.PropertiesButtonItem.Id = 12
        Me.PropertiesButtonItem.Name = "PropertiesButtonItem"
        '
        'EditRulePageBarButtonItem
        '
        Me.EditRulePageBarButtonItem.Caption = "Edit Rule Page"
        Me.EditRulePageBarButtonItem.Glyph = CType(resources.GetObject("EditRulePageBarButtonItem.Glyph"), System.Drawing.Image)
        Me.EditRulePageBarButtonItem.Id = 26
        Me.EditRulePageBarButtonItem.Name = "EditRulePageBarButtonItem"
        '
        'DeleteButtonItem
        '
        Me.DeleteButtonItem.Caption = "Delete"
        Me.DeleteButtonItem.Glyph = CType(resources.GetObject("DeleteButtonItem.Glyph"), System.Drawing.Image)
        Me.DeleteButtonItem.Id = 14
        Me.DeleteButtonItem.Name = "DeleteButtonItem"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Toolbar"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(342, 189)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.FolderUpButtomItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderExpandButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ResetTreeButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderCollapseButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddToFavoritesButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CutButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CopyBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.PasteButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddFolderButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.AddFolderPageButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddRulePageButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddTableButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.NewTabButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.OpenInNewTabButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseTabButtonItem, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.Text = "Custom 2"
        '
        'ResetTreeButtonItem
        '
        Me.ResetTreeButtonItem.Caption = "Reset Tree"
        Me.ResetTreeButtonItem.Glyph = CType(resources.GetObject("ResetTreeButtonItem.Glyph"), System.Drawing.Image)
        Me.ResetTreeButtonItem.Hint = "Collapses all folders except the root folder. Very useful."
        Me.ResetTreeButtonItem.Id = 27
        Me.ResetTreeButtonItem.Name = "ResetTreeButtonItem"
        '
        'NewTabButtonItem
        '
        Me.NewTabButtonItem.Caption = "New Tab"
        Me.NewTabButtonItem.Glyph = CType(resources.GetObject("NewTabButtonItem.Glyph"), System.Drawing.Image)
        Me.NewTabButtonItem.Hint = "Open a new blank tab."
        Me.NewTabButtonItem.Id = 15
        Me.NewTabButtonItem.Name = "NewTabButtonItem"
        Me.NewTabButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'OpenInNewTabButtonItem
        '
        Me.OpenInNewTabButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.OpenInNewTabButtonItem.Caption = "Automatic New Tab"
        Me.OpenInNewTabButtonItem.Glyph = CType(resources.GetObject("OpenInNewTabButtonItem.Glyph"), System.Drawing.Image)
        Me.OpenInNewTabButtonItem.Hint = "Open newly selected items in a tab of their own"
        Me.OpenInNewTabButtonItem.Id = 10
        Me.OpenInNewTabButtonItem.Name = "OpenInNewTabButtonItem"
        Me.OpenInNewTabButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'CloseTabButtonItem
        '
        Me.CloseTabButtonItem.Caption = "Close Tab"
        Me.CloseTabButtonItem.Glyph = CType(resources.GetObject("CloseTabButtonItem.Glyph"), System.Drawing.Image)
        Me.CloseTabButtonItem.Hint = "Close the currently selected tab"
        Me.CloseTabButtonItem.Id = 9
        Me.CloseTabButtonItem.Name = "CloseTabButtonItem"
        Me.CloseTabButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barDockControlTop.Appearance.Options.UseFont = True
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
        '
        'panelContainer1
        '
        Me.panelContainer1.Controls.Add(Me.ContentsDockPanel)
        Me.panelContainer1.Controls.Add(Me.FavoritesDockPanel)
        Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.panelContainer1.ID = New System.Guid("afaf8579-c9c2-4619-a746-38dcd83bc499")
        Me.panelContainer1.Location = New System.Drawing.Point(0, 51)
        Me.panelContainer1.Name = "panelContainer1"
        Me.panelContainer1.Size = New System.Drawing.Size(300, 518)
        Me.panelContainer1.Text = "panelContainer1"
        '
        'ContentsDockPanel
        '
        Me.ContentsDockPanel.BackColor = System.Drawing.Color.White
        Me.ContentsDockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.ContentsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.ContentsDockPanel.FloatSize = New System.Drawing.Size(300, 400)
        Me.ContentsDockPanel.FloatVertical = True
        Me.ContentsDockPanel.ID = New System.Guid("cb4a5742-cf8b-4d3f-b4f2-1d320a71cf19")
        Me.ContentsDockPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContentsDockPanel.Name = "ContentsDockPanel"
        Me.ContentsDockPanel.Options.ShowCloseButton = False
        Me.ContentsDockPanel.Size = New System.Drawing.Size(300, 453)
        Me.ContentsDockPanel.Text = "Contents"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.TreeView1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 29)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(294, 421)
        Me.DockPanel1_Container.TabIndex = 0
		'
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.HideSelection = False
        Me.TreeView1.LabelEdit = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(294, 421)
        Me.TreeView1.Sorted = True
        Me.TreeView1.TabIndex = 48
        '
        'FavoritesDockPanel
        '
        Me.FavoritesDockPanel.Controls.Add(Me.DockPanel2_Container)
        Me.FavoritesDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.FavoritesDockPanel.FloatSize = New System.Drawing.Size(300, 400)
        Me.FavoritesDockPanel.ID = New System.Guid("44222a01-4551-47e8-9da1-2f46fec25160")
        Me.FavoritesDockPanel.Location = New System.Drawing.Point(0, 453)
        Me.FavoritesDockPanel.Name = "FavoritesDockPanel"
        Me.FavoritesDockPanel.Options.ShowCloseButton = False
        Me.FavoritesDockPanel.Size = New System.Drawing.Size(300, 65)
        Me.FavoritesDockPanel.Text = "Favorites"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.TreeView2)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 29)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(294, 33)
        Me.DockPanel2_Container.TabIndex = 0
		'
        'TreeView2
        '
        Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView2.HideSelection = False
        Me.TreeView2.Location = New System.Drawing.Point(0, 0)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(294, 33)
        Me.TreeView2.Sorted = True
        Me.TreeView2.TabIndex = 49
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "BarSubItem3"
        Me.BarSubItem3.Id = 8
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 23
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 29
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 33
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "BarSubItem5"
        Me.BarSubItem5.Id = 35
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Enabled = False
        Me.Splitter2.Location = New System.Drawing.Point(300, 51)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(500, 4)
        Me.Splitter2.TabIndex = 41
        Me.Splitter2.TabStop = False
        Me.Splitter2.Visible = False
        '
        'TabControl12
        '
        Me.TabControl12.Location = New System.Drawing.Point(355, 300)
        Me.TabControl12.Multiline = True
        Me.TabControl12.Name = "TabControl12"
        Me.TabControl12.SelectedIndex = 0
        Me.TabControl12.Size = New System.Drawing.Size(397, 244)
        Me.TabControl12.TabIndex = 46
        Me.TabControl12.Visible = False
		'
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        '
        'NavBarSplitter
        '
        Me.NavBarSplitter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NavBarSplitter.Enabled = False
        Me.NavBarSplitter.Location = New System.Drawing.Point(300, 55)
        Me.NavBarSplitter.Name = "NavBarSplitter"
        Me.NavBarSplitter.Size = New System.Drawing.Size(5, 509)
        Me.NavBarSplitter.TabIndex = 45
        Me.NavBarSplitter.TabStop = False
        Me.NavBarSplitter.Visible = False
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CutButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.CopyBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.PasteButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddFolderButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.AddFolderPageButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddRulePageButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddTableButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderExpandButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.FolderCollapseButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.AddToFavoritesButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.RenameButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PropertiesButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.EditRulePageBarButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteButtonItem, True)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Enabled = False
        Me.Splitter1.Location = New System.Drawing.Point(797, 55)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 509)
        Me.Splitter1.TabIndex = 48
        Me.Splitter1.TabStop = False
        Me.Splitter1.Visible = False
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter3.Enabled = False
        Me.Splitter3.Location = New System.Drawing.Point(300, 564)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(500, 5)
        Me.Splitter3.TabIndex = 49
        Me.Splitter3.TabStop = False
        Me.Splitter3.Visible = False
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CloseTabButtonItem)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.TabControl1.Location = New System.Drawing.Point(305, 55)
        Me.TabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(492, 509)
        Me.TabControl1.TabIndex = 51
        Me.TabControl1.Text = "XtraTabControl1"
        '
        'DocumentViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 569)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl12)
        Me.Controls.Add(Me.NavBarSplitter)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Splitter3)
        Me.Controls.Add(Me.panelContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DocumentViewer"
        Me.Text = "Document Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContainer1.ResumeLayout(False)
        Me.ContentsDockPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.FavoritesDockPanel.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private IsLoading As Boolean

    Private TreeManager, FavoritesTreeManager As TreeManager
    Private Tabs As Hashtable
    Private Clipboard As Clipboard
    Private CutTreeView As TreeView 'the tree view that contains items cut onto the clipboard
    Private FavoritesLookup As Hashtable
    Private TabsObject As Objects.ObjectData

    Private _OpenInNewTab As Boolean
    Private _CurrentTreeView As TreeView

#End Region

#Region "Properties"

    'open in new tab
    Public Property OpenInNewTab() As Boolean
        Get
            Return _OpenInNewTab
        End Get
        Set(ByVal Value As Boolean)
            _OpenInNewTab = Value
        End Set
    End Property

    'current tree view
    Public ReadOnly Property CurrentTreeView() As TreeView
        Get
            Return _CurrentTreeView
        End Get
    End Property

    'selected object
    Public ReadOnly Property SelectedObject() As Objects.ObjectData
        Get
            Dim Obj As New Objects.ObjectData
            If CurrentTreeView.SelectedNode Is Nothing Then CurrentTreeView.SelectedNode = CurrentTreeView.Nodes(0)
            Obj.Load(CType(CurrentTreeView.SelectedNode.Tag, TreeManager.TreeNodeTagData).ObjectKey)
            Return Obj
        End Get
    End Property

    'current window
    Public ReadOnly Property CurrentWindow() As BrowserPane
        Get
            If TabControl1.SelectedTabPage Is Nothing Then
                Return Nothing
            Else
                Return CType(TabControl1.SelectedTabPage.Controls(0), BrowserPane)
            End If
        End Get
    End Property
#End Region

    'init
    Public Sub Init()
        Try
            Me.Text = "Rules Viewer"
            LoadTrees()

            IsLoading = True

            'init vars
            Tabs = New Hashtable
            FavoritesLookup = New Hashtable
            Clipboard = New Clipboard

            'add a list of all the links into the lookup table
            For Each ObjectKey As Objects.ObjectKey In FavoritesTreeManager.KeyNodeIndex.Keys
                Dim FavObject As New Objects.ObjectData
                FavObject.Load(ObjectKey)
                FavoritesLookup.Add(FavObject.GetFKGuid("Favorite"), Nothing)
            Next

            'load previous set up
            Dim TempCollection As Objects.ObjectDataCollection
            Dim ElementString As String
            Dim TabsCount As Integer

            TempCollection = Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RulesTabInfoType)
            If TempCollection.Count > 0 Then
                TabsObject = TempCollection.Item(0)
            Else
                'create new object
                TabsObject.Name = "Rules Tab Info"
                TabsObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                TabsObject.Type = Objects.RulesTabInfoType
                TabsObject.ParentGUID = References.GMScreen
            End If

            TabsCount = TabsObject.ElementAsInteger("NumberOfPages")
            If TabsCount > 0 Then
                For i As Integer = 1 To TabsCount
                    ElementString = "TabPage" & i.ToString
                    CreateNewPane(TabsObject.Element(ElementString), TabsObject.Attribute(ElementString, "Caption"))
                Next
            Else
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If

            'load dock layout
            Try
                DockManager1.RestoreFromXml(General.BasePath & "XML\RulesDockLayout.xml")
            Catch ex As Exception
                'if the file is not found, do nothing
            End Try

            IsLoading = False

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'cached tree reload
    Public Sub LoadTrees2()
        Try
            Dim XmlRdr As XmlTextReader

            XmlRdr = New XmlTextReader(General.BasePath & "XML\RulesTreeView.xml")
            XmlRdr.WhitespaceHandling = WhitespaceHandling.None

            IsLoading = True
            General.SetWaitCursor(Me)

            'clear existing trees                 
            TreeView1.BeginUpdate()
            TreeView1.Nodes.Clear()
            TreeView2.Nodes.Clear()

            Dim NodeStack As New Stack
            Dim CurrentNode As TreeNode = Nothing
            Dim ParentNode As TreeNode = Nothing

            'static load part for main tree view
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
                                Dim TempTag As TreeNodeTagData
                                TempTag = CType(CurrentNode.Tag, TreeNodeTagData)
                                TempTag.ObjectName = CurrentNode.Text
                                CurrentNode.Tag = TempTag

                            Case "ObjectGuid"
                                Dim TempTag As TreeNodeTagData
                                TempTag = CType(CurrentNode.Tag, TreeNodeTagData)
                                TempTag.ObjectKey = New Objects.ObjectKey(XmlRdr.ReadString)
                                CurrentNode.Tag = TempTag

                            Case "Type"
                                Dim TempTag As TreeNodeTagData
                                TempTag = CType(CurrentNode.Tag, TreeNodeTagData)
                                TempTag.ObjectType = XmlRdr.ReadString
                                CurrentNode.Tag = TempTag

                            Case "ImageIndex"
                                CurrentNode.SelectedImageIndex = CInt(XmlRdr.ReadString)
                                CurrentNode.ImageIndex = CurrentNode.SelectedImageIndex

                                'Case "ImageKey"
                                '    CurrentNode.SelectedImageKey = XmlRdr.ReadString
                                '    CurrentNode.ImageKey = CurrentNode.SelectedImageKey

                        End Select

                    Case XmlNodeType.EndElement
                        Select Case XmlRdr.Name
                            Case "TreeNode"
                                If Not ParentNode Is Nothing Then
                                    ParentNode.Nodes.Add(CurrentNode)
                                    CurrentNode = CType(NodeStack.Pop, TreeNode)
                                Else
                                    TreeView1.Nodes.Add(CurrentNode)
                                    CurrentNode = Nothing
                                End If

                                If NodeStack.Count > 0 Then
                                    ParentNode = CType(NodeStack.Peek, TreeNode)
                                Else
                                    ParentNode = Nothing
                                End If
                        End Select

                End Select

            End While

            XmlRdr.Close()

            'dynamic part for main tree view
            Dim FolderObjects As New Objects.ObjectDataCollection
            Dim PageObjects As New Objects.ObjectDataCollection

            'folders
            Dim SpellFolder As Objects.ObjectData = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='001-ddb52cd6-1f28-4c7b-8355-96952461b585']")
            SpellFolder.ParentGUID = Objects.ObjectKey.Empty
            SpellFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(SpellFolder)

            Dim FeatsFolder As New Objects.ObjectData
            FeatsFolder.Load(New Objects.ObjectKey("001-5cdddefb-6a3a-4ce3-bcd2-e96aded5a2a0"))
            FeatsFolder.ParentGUID = Objects.ObjectKey.Empty
            FeatsFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(FeatsFolder)

            Dim PowersFolder As New Objects.ObjectData
            PowersFolder.Load(New Objects.ObjectKey("001-93682f91-b766-464f-bc74-ac27816e5d86"))
            PowersFolder.ParentGUID = Objects.ObjectKey.Empty
            PowersFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(PowersFolder)

            Dim ClassFolder As New Objects.ObjectData
            ClassFolder.Load(New Objects.ObjectKey("001-5428f871-04a2-467d-abc3-de34305b6965"))
            ClassFolder.ParentGUID = Objects.ObjectKey.Empty
            ClassFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(ClassFolder)

            Dim RaceFolder As New Objects.ObjectData
            RaceFolder.Load(New Objects.ObjectKey("001-3c55dd52-cf73-4b61-bf21-bbc3fee29bf5"))
            RaceFolder.ParentGUID = Objects.ObjectKey.Empty
            RaceFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(RaceFolder)

            'pages
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Spells, Objects.SpellDefinitionType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Feats, Objects.FeatDefinitionType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Powers, Objects.PowerDefinitionType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Races, Objects.RaceType))

            TreeManager = New TreeManager(TreeView1)
            Dim ProgressBar As New ProgressBar

            If General.RulesViewer Is Nothing Then
                ProgressBar.Caption = "Loading Rules Tree for the first time."
            Else
                ProgressBar.Caption = "Loading Rules Tree"
            End If

            ProgressBar.Maximum = FolderObjects.Count + PageObjects.Count
            ProgressBar.TopMost = True
            ProgressBar.Show()
            TreeManager.LoadTree(FolderObjects, PageObjects, ProgressBar)
            ProgressBar.Close()

            'load the favorites tree
            FolderObjects.Clear()
            FolderObjects.Add(Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='001-00000000-0000-0000-0000-000000000007']"))
            FolderObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.FavoriteRuleFolderType))

            PageObjects.Clear()
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.FavoriteRuleType))

            FavoritesTreeManager = New TreeManager(TreeView2)
            FavoritesTreeManager.LoadTree(FolderObjects, PageObjects)

            'expand root nodes in each
            TreeView1.Nodes(0).Expand()
            TreeView2.Nodes(0).Expand()

            If TreeView1.Nodes.Count > 0 Then TreeView1.SelectedNode = TreeView1.TopNode
            If TreeView2.Nodes.Count > 0 Then TreeView2.SelectedNode = TreeView2.TopNode

            General.SetNormalCursor(Me)
            IsLoading = False

        Catch ex As Exception
            LoadTrees()
        End Try

    End Sub

    'load the trees
    Private Sub LoadTrees()
        Try
            IsLoading = True
            General.SetWaitCursor(Me)

            TreeView1.BeginUpdate()
            TreeView2.BeginUpdate()
            TreeView1.Nodes.Clear()
            TreeView2.Nodes.Clear()

            'load the main tree
            'folders
            Dim FolderObjects As New Objects.ObjectDataCollection

            'static part
            FolderObjects.Add(Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='001-00000000-0000-0000-0000-000000000006']"))
            FolderObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RuleFolderType))
            FolderObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RuleFolderPageType))

            'synch folders - dynamic part
            Dim SpellFolder As Objects.ObjectData = Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='001-ddb52cd6-1f28-4c7b-8355-96952461b585']")
            SpellFolder.ParentGUID = Objects.ObjectKey.Empty
            SpellFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(SpellFolder)

            Dim FeatsFolder As New Objects.ObjectData
            FeatsFolder.Load(New Objects.ObjectKey("001-5cdddefb-6a3a-4ce3-bcd2-e96aded5a2a0"))
            FeatsFolder.ParentGUID = Objects.ObjectKey.Empty
            FeatsFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(FeatsFolder)

            Dim PowersFolder As New Objects.ObjectData
            PowersFolder.Load(New Objects.ObjectKey("001-93682f91-b766-464f-bc74-ac27816e5d86"))
            PowersFolder.ParentGUID = Objects.ObjectKey.Empty
            PowersFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(PowersFolder)

            Dim ClassFolder As New Objects.ObjectData
            ClassFolder.Load(New Objects.ObjectKey("001-5428f871-04a2-467d-abc3-de34305b6965"))
            ClassFolder.ParentGUID = Objects.ObjectKey.Empty
            ClassFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(ClassFolder)

            Dim RaceFolder As New Objects.ObjectData
            RaceFolder.Load(New Objects.ObjectKey("001-3c55dd52-cf73-4b61-bf21-bbc3fee29bf5"))
            RaceFolder.ParentGUID = Objects.ObjectKey.Empty
            RaceFolder.ImageFilename = "refresh.png"
            FolderObjects.Add(RaceFolder)

            'pages
            Dim PageObjects As New Objects.ObjectDataCollection

            'static 
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RulePageType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RuleTableType))

            'dynamic
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Spells, Objects.SpellDefinitionType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Feats, Objects.FeatDefinitionType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Powers, Objects.PowerDefinitionType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassType))
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Races, Objects.RaceType))

            TreeManager = New TreeManager(TreeView1)
            Dim ProgressBar As New ProgressBar

            If General.RulesViewer Is Nothing Then
                ProgressBar.Caption = "Loading Rules Tree for the first time."
            Else
                ProgressBar.Caption = "Loading Rules Tree"
            End If

            ProgressBar.Maximum = FolderObjects.Count + PageObjects.Count
            ProgressBar.TopMost = True
            ProgressBar.Show()
            TreeManager.LoadTree(FolderObjects, PageObjects, ProgressBar)
            ProgressBar.Close()

            'load the favorites tree
            FolderObjects.Clear()
            FolderObjects.Add(Objects.GetObjectByXPath(XML.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID='001-00000000-0000-0000-0000-000000000007']"))
            FolderObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.FavoriteRuleFolderType))

            PageObjects.Clear()
            PageObjects.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.FavoriteRuleType))

            FavoritesTreeManager = New TreeManager(TreeView2)
            FavoritesTreeManager.LoadTree(FolderObjects, PageObjects)

            TreeView1.EndUpdate()
            TreeView2.EndUpdate()

            'expand root nodes in each
            TreeView1.Nodes(0).Expand()
            TreeView2.Nodes(0).Expand()

            If TreeView1.Nodes.Count > 0 Then TreeView1.SelectedNode = TreeView1.TopNode
            If TreeView2.Nodes.Count > 0 Then TreeView2.SelectedNode = TreeView2.TopNode

            General.SetNormalCursor(Me)
            IsLoading = False
        Catch ex As Exception
            TreeView1.EndUpdate()
            TreeView2.EndUpdate()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display the URI in either the current tab or a new tab
    Public Sub ShowURI(ByVal URI As String, Optional ByVal Caption As String = "")
        Try
            'show page in current tab or new tab
            If Tabs.Contains(URI) Then
                TabControl1.SelectedTabPage = CType(Tabs.Item(URI), XtraTabPage)
            Else
                If _OpenInNewTab Or TabControl1.TabPages.Count = 0 Then
                    CreateNewPane(URI, Caption)
                Else
                    TabControl1.SelectedTabPage.Text = Caption
                    Dim BrowserPane As BrowserPane = CType(TabControl1.SelectedTabPage.Controls(0), BrowserPane)
                    Tabs.Remove(BrowserPane.URI)

                    BrowserPane.ApplicationRequest = True
                    BrowserPane.BrowserControl.Navigate(URI)
                    BrowserPane.URI = URI

                    Tabs.Add(URI, TabControl1.SelectedTabPage)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'create a new browser pane
    Private Sub CreateNewPane(ByVal URI As String, ByVal Caption As String)
        Try
            'Dim NewTab As New TabPage
            Dim NewTab As New XtraTabPage
            Dim BrowserPane As New BrowserPane(Me)

            NewTab.Text = Caption
            NewTab.Controls.Add(BrowserPane)
            BrowserPane.Dock = DockStyle.Fill
            TabControl1.TabPages.Add(NewTab)
            'TabControl1.SelectedTab = NewTab
            TabControl1.SelectedTabPage = NewTab
            BrowserPane.ApplicationRequest = True
            BrowserPane.BrowserControl.Navigate(URI)
            BrowserPane.URI = URI

            Tabs.Add(URI, NewTab)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'refresh the current html page
    Private Sub RefreshBrowser()
        Try
            If Not CurrentWindow Is Nothing Then
                CurrentWindow.BrowserControl.Refresh()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "TreeView/NavBar/Tab Events"

    'got focus
    Private Sub Tree_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView1.GotFocus, TreeView2.GotFocus
        _CurrentTreeView = CType(sender, TreeView)

        'if the tree gets focused over the selected node - raise AfterSelect event
        Dim Node As TreeNode = _CurrentTreeView.GetNodeAt(_CurrentTreeView.PointToClient(Control.MousePosition))

        If Not Node Is Nothing Then
            If Not _CurrentTreeView.SelectedNode Is Nothing Then
                If CType(_CurrentTreeView.SelectedNode.Tag, TreeNodeTagData).ObjectKey.Equals(CType(Node.Tag, TreeNodeTagData).ObjectKey) Then
                    Dim TreeEvents As New TreeViewEventArgs(_CurrentTreeView.SelectedNode)
                    TreeView_AfterSelect(sender, TreeEvents)
                End If
            End If
        End If

    End Sub

    'handle tree view node select
    Private Sub TreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect, TreeView2.AfterSelect
        Try
            _CurrentTreeView = CType(sender, TreeView)

            If IsLoading OrElse TreeManager.IsLoading OrElse FavoritesTreeManager.IsLoading Then Exit Sub

            'get the object
            Dim TagData As TreeNodeTagData = CType(e.Node.Tag, TreeNodeTagData)
            Dim Obj As New ObjectData
            Obj.Load(TagData.ObjectKey)

            'show rule page
            Select Case Obj.Type
                Case Objects.SpellDefinitionFolderType, Objects.FeatDefinitionsFolderType
                    'do nothing
                Case Else
                    ShowURI(RulePageManager.GetURI(Obj), Obj.Name)
            End Select

            'update commands
            UpdateCommandVisibility()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'before label edit
    Private Sub TreeView1_BeforeLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeView1.BeforeLabelEdit
        If Not CommonHandlers.BeforeLabelEdit(CType(e.Node.Tag, TreeManager.TreeNodeTagData).ObjectKey) Then e.CancelEdit = True
    End Sub

    'after label edit
    Private Sub TreeView1_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeView1.AfterLabelEdit
        If Not CommonHandlers.AfterLabelEditTreeView(CType(e.Node.Tag, TreeManager.TreeNodeTagData).ObjectKey, e.Label, TreeView1.SelectedNode, False) Then
            e.CancelEdit = True
            Exit Sub
        End If
        'TabControl12.SelectedTab.Text = e.Label
        TabControl1.SelectedTabPage.Text = e.Label
    End Sub

    'display right click menu
    Private Sub TreeView_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseUp, TreeView2.MouseUp
        Try
            _CurrentTreeView = CType(sender, TreeView)

            Dim Node As TreeNode
            Dim Point As System.Drawing.Point

            If e.Button = MouseButtons.Right Then
                'Point = CurrentTreeView.PointToClient(New System.Drawing.Point(CurrentTreeView.MousePosition.X, CurrentTreeView.MousePosition.Y))
                Point = CurrentTreeView.PointToClient(New System.Drawing.Point(Control.MousePosition.X, Control.MousePosition.Y))
                Node = CurrentTreeView.GetNodeAt(Point)
                If Not Node Is Nothing Then CurrentTreeView.SelectedNode = Node

                'PopupMenu1.ShowPopup(New Point(CurrentTreeView.MousePosition.X, CurrentTreeView.MousePosition.Y))
                PopupMenu1.ShowPopup(New Point(Control.MousePosition.X, Control.MousePosition.Y))
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Browser Pane Events"

    'handles a hyperlink being clicked in a tab
    Private Sub HandleNewBrowserTabRequired(ByVal URI As String)
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display right click menu - tab menu
    Private Sub TabControl1_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
        Try
            Dim Point As System.Drawing.Point

            If e.Button = MouseButtons.Right Then
                'Point = TreeView1.PointToClient(New System.Drawing.Point(TreeView1.MousePosition.X, TreeView1.MousePosition.Y))
                Point = TreeView1.PointToClient(New System.Drawing.Point(Control.MousePosition.X, Control.MousePosition.Y))
                'PopupMenu2.ShowPopup(New Point(TreeView1.MousePosition.X, TreeView1.MousePosition.Y))
                PopupMenu2.ShowPopup(New Point(Control.MousePosition.X, Control.MousePosition.Y))
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#Region "Form Events"

    'override close with hide
    Private Sub DocumentViewer_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'save current tab layout
        Dim Count As Integer = 1
        TabsObject.ClearElements()

        For Each Tab As XtraTabPage In TabControl1.TabPages
            Dim BrowserPane As BrowserPane = CType(Tab.Controls(0), BrowserPane)

            TabsObject.Element("TabPage" & Count.ToString) = BrowserPane.URI()
            TabsObject.Attribute("TabPage" & Count.ToString, "Caption") = Tab.Text
            Count += 1
        Next

        TabsObject.Element("NumberOfPages") = (Count - 1).ToString
        TabsObject.Save()

        'save layout
        DockManager1.SaveToXml(General.BasePath & "XML\RulesDockLayout.xml")

        'save tree
        SaveTree()

        If Not General.TimeUp Then
            e.Cancel = True
            Me.Hide()
        End If

    End Sub

#End Region

#Region "Commands"

    'command visibility
    Private Sub UpdateCommandVisibility()
        Try
            'default setting for command visability
            'add commands
            AddFolderButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            AddFolderPageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            AddRulePageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            AddTableButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            'edit commands
            CutButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            CopyBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PasteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            EditRulePageBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DeleteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            'folder commands
            FolderExpandButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            FolderCollapseButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            'misc commands
            RenameButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            AddToFavoritesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PropertiesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            If CurrentTreeView.SelectedNode Is Nothing Then Exit Sub

            'set commands based on object type
            Select Case CType(CurrentTreeView.SelectedNode.Tag, TreeNodeTagData).ObjectType

                Case Objects.RulesRootFolderType
                    If CurrentTreeView Is TreeView1 Then
                        AddFolderButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        AddFolderPageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        AddRulePageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        AddTableButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        PropertiesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        PasteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    End If
                    FolderExpandButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    FolderCollapseButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    DeleteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case Objects.RuleFolderType
                    AddFolderButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddFolderPageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddRulePageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddTableButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    CutButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    CopyBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PasteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    EditRulePageBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    FolderExpandButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    FolderCollapseButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    RenameButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PropertiesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Case Objects.RuleFolderPageType
                    AddFolderButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddFolderPageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddRulePageButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddTableButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    CutButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    CopyBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PasteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    EditRulePageBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    FolderExpandButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    FolderCollapseButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    RenameButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddToFavoritesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PropertiesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Case Objects.RulePageType
                    CutButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    CopyBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PasteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    EditRulePageBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    RenameButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddToFavoritesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PropertiesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Case Objects.RuleTableType
                    CutButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    CopyBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PasteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    EditRulePageBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    RenameButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    AddToFavoritesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    PropertiesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Case Objects.FavoriteRuleType

                Case Objects.SpellDefinitionType, Objects.FeatDefinitionType, Objects.PowerDefinitionType, Objects.RaceType, Objects.ClassType
                    AddToFavoritesButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    DeleteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Case Objects.SpellDefinitionFolderType, Objects.FeatDefinitionsFolderType, Objects.PowerDefinitionFolderType, Objects.RaceFolderType, Objects.ClassFolderType
                    DeleteButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add folder
    Private Sub AddFolderButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddFolderButtonItem.ItemClick
        Try
            'create the folder
            Dim Folder As New Objects.ObjectData
            Folder.Name = "New Folder"
            Folder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
            Folder.Type = Objects.RuleFolderType
            Folder.Fixed = False
            Folder.ParentGUID = CType(TreeView1.SelectedNode.Tag, TreeNodeTagData).ObjectKey
            Folder.Save()

            'add it to the tree
            TreeView1.SelectedNode.Nodes.Add(Me.TreeManager.TreeNodeFromObject(Folder))

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'add folder page
    Private Sub AddFolderPageButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddFolderPageButtonItem.ItemClick
        Try
            'create the folder
            Dim FolderPage As New Objects.ObjectData
            FolderPage.Name = "New Folder Page"
            FolderPage.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
            FolderPage.Type = Objects.RuleFolderPageType
            FolderPage.Fixed = False
            FolderPage.ParentGUID = CType(TreeView1.SelectedNode.Tag, TreeNodeTagData).ObjectKey
            FolderPage.Save()

            'add it to the tree
            TreeView1.SelectedNode.Nodes.Add(Me.TreeManager.TreeNodeFromObject(FolderPage))

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'add rule page
    Private Sub AddRulePageButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddRulePageButtonItem.ItemClick
        Try
            'create the folder
            Dim RulePage As New Objects.ObjectData
            RulePage.Name = "New Rule Page"
            RulePage.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
            RulePage.Type = Objects.RulePageType
            RulePage.Fixed = False
            RulePage.ParentGUID = CType(TreeView1.SelectedNode.Tag, TreeNodeTagData).ObjectKey
            RulePage.Save()

            'add it to the tree
            TreeView1.SelectedNode.Nodes.Add(Me.TreeManager.TreeNodeFromObject(RulePage))

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'add table
    Private Sub AddTableButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddTableButtonItem.ItemClick
        Try
            'create the folder
            Dim RuleTable As New Objects.ObjectData
            RuleTable.Name = "New Table"
            RuleTable.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
            RuleTable.Type = Objects.RuleTableType
            RuleTable.Fixed = False
            RuleTable.ParentGUID = CType(TreeView1.SelectedNode.Tag, TreeNodeTagData).ObjectKey
            RuleTable.Save()

            'add it to the tree
            TreeView1.SelectedNode.Nodes.Add(Me.TreeManager.TreeNodeFromObject(RuleTable))

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'add to favorites
    Private Sub AddToFavoritesButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddToFavoritesButtonItem.ItemClick
        Try
            Try
                Dim FavouriteClone As Objects.ObjectData
                Dim CurrentObject As Objects.ObjectData
                Dim GMScreenFavorites As New Objects.ObjectData

                GMScreenFavorites.Load(References.GMScreenFavorites)
                CurrentObject = SelectedObject

                'see if this object is already in the favourites list
                If FavoritesLookup.ContainsKey(CurrentObject.ObjectGUID) Then
                    General.ShowErrorDialog("This page has already been added to favorites.")
                    Exit Sub
                End If

                'copy and modify the new object
                FavouriteClone = CurrentObject.CloneSingle(GMScreenFavorites)
                FavouriteClone.Type = Objects.FavoriteRuleType
                FavouriteClone.FKElement("Favorite", CurrentObject.Name, "Name", CurrentObject.ObjectGUID)

                'change any images required
                Select Case CurrentObject.Type
                    Case Objects.RulePageType
                        FavouriteClone.ImageFilename = "book_green.png"
                    Case Else
                        'do nothing
                End Select

                'save and add to the tree
                FavouriteClone.Save()
                TreeView2.Nodes(0).Nodes.Add(Me.TreeManager.TreeNodeFromObject(FavouriteClone))
                TreeView2.TopNode.Expand()
                FavoritesLookup.Add(CurrentObject.ObjectGUID, Nothing)

            Catch ex As Exception
                HandleException(ex)
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'close the window
    Private Sub CloseButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseButtonItem.ItemClick
        Me.Hide()
    End Sub

    'close the currently selected tab
    Private Sub CloseTabButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseTabButtonItem.ItemClick
        Try
            If Not TabControl1.SelectedTabPage Is Nothing Then
                Tabs.Remove(CType(TabControl1.SelectedTabPage.Controls(0), BrowserPane).URI)
                TabControl1.TabPages.Remove(TabControl1.SelectedTabPage)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'delete
    Private Sub DeleteButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteButtonItem.ItemClick
        Try
            Dim HTMLKey As Objects.ObjectKey

            'quit if nothing is selected
            If CurrentTreeView.SelectedNode Is Nothing Then
                Exit Sub
            End If

            If General.ShowQuestionDialog("Are you sure you want to delete these components?") = DialogResult.No Then Exit Sub
            Me.Cursor = Cursors.WaitCursor

            'get URI information
            Dim URIList As ArrayList
            URIList = GetURIList(CurrentTreeView.SelectedNode)

            Dim List As New ArrayList(1)
            List.Add(CType(CurrentTreeView.SelectedNode.Tag, TreeNodeTagData).ObjectKey)

            'if we are deleting a favorite store the lookup guid
            If CurrentTreeView Is TreeView2 Then
                HTMLKey = SelectedObject.GetFKGuid("HTML")
            End If

            'delete the objects
            Dim Failures As ObjectHashtable = Objects.DeleteObjects(List)
            Me.Cursor = Cursors.Default

            'if there are failures then nothing has been deleted, report reasons to user
            If Not Failures Is Nothing Then
                Dim FailureForm As New DeleteFailuresForm

                FailureForm.Init(Failures)
                FailureForm.Show()
            Else
                RemoveTabs(URIList)
                CurrentTreeView.SelectedNode.Remove()
                FavoritesLookup.Remove(HTMLKey)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'edit rule page
    Private Sub EditRulePageBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditRulePageBarButtonItem.ItemClick
        Dim EditObj As Objects.ObjectData
        Dim HelpObj As New Objects.ObjectData
        Dim Proc As New System.Diagnostics.Process
        Dim PageToEdit As Boolean = True
        Dim HelpPage As String
        Try
            EditObj = SelectedObject

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
                        RefreshBrowser()
                    Else
                        General.ShowInfoDialog("Help or rule page not found.")
                    End If
                End If
            End If
        Catch ex As Exception
            General.ShowInfoDialog("Please go to Tools, Options and specify your HTML editor.")
        End Try
    End Sub

    'folder up
    Private Sub FolderUpButtomItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles FolderUpButtomItem.ItemClick
        Try
            If CurrentTreeView.SelectedNode Is Nothing Then Exit Sub
            If CurrentTreeView.SelectedNode.Parent Is Nothing Then Exit Sub

            CurrentTreeView.SelectedNode = CurrentTreeView.SelectedNode.Parent

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'folder expand
    Private Sub FolderExpandButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles FolderExpandButtonItem.ItemClick
        Try
            If Not CurrentTreeView.SelectedNode Is Nothing Then
                CurrentTreeView.SelectedNode.ExpandAll()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'folder collapse
    Private Sub FolderCollapseButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles FolderCollapseButtonItem.ItemClick
        Try
            If Not CurrentTreeView.SelectedNode Is Nothing Then
                Explorer.CollapseRecurse(CurrentTreeView.SelectedNode)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load components
    Private Sub LoadComponentsButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles LoadComponentsButtonItem.ItemClick
        Try
            SaveLoad.LoadComponents(Me)
            General.ShowInfoDialog("If you have finished loading new or changed Rules and/or Favorites then please refresh the rules viewer via File -> Refresh, new or changed items will not be visible until you do this.")
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'new tab
    Private Sub NewTabButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewTabButtonItem.ItemClick
        Try
            _OpenInNewTab = True
            ShowURI("file://" & General.HelpPath & "Index.htm", "New Tab")
            _OpenInNewTab = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'toggle for open in new tab
    Private Sub OpenInNewTabButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenInNewTabButtonItem.ItemClick
        Try
            If OpenInNewTabButtonItem.Down Then
                _OpenInNewTab = True
            Else
                _OpenInNewTab = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'properties
    Private Sub PropertiesButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PropertiesButtonItem.ItemClick
        Try
            Dim Form As New PropertiesFormDV
            Dim Obj As New Objects.ObjectData

            Obj.Load(CType(TreeView1.SelectedNode.Tag, TreeNodeTagData).ObjectKey)
            Form.Init(Obj)
            Form.ShowDialog()

            'reload obj and refresh current tab
            Obj.Load(Obj.ObjectGUID)
            ShowURI(RulePageManager.GetURI(Obj), Obj.Name)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'refresh
    Private Sub RefreshButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RefreshButtonItem.ItemClick
        Try
            LoadTrees()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'rename
    Private Sub RenameButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RenameButtonItem.ItemClick
        Try
            CurrentTreeView.SelectedNode.BeginEdit()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reset tree
    Private Sub ResetTreeButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ResetTreeButtonItem.ItemClick
        Try
            Dim TreeView As TreeView = CurrentTreeView

            If Not TreeView Is Nothing Then
                TreeView.CollapseAll()
                For Each Node As TreeNode In TreeView.Nodes
                    If CType(Node.Tag, TreeNodeTagData).ObjectType = Objects.RulesRootFolderType Then Node.Expand()
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save components
    Private Sub SaveComponentsButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SaveComponentsButtonItem.ItemClick
        Try
            Dim SelectedObjects As New Objects.ObjectDataCollection
            SelectedObjects.Add(SelectedObject)
            SaveLoad.SaveComponents(Me, SelectedObjects)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Clipboard Commands"

    'copy
    Private Sub CopyButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CopyBarButtonItem.ItemClick
        Try
            Dim Temp As New Objects.ObjectDataCollection
            Temp.Add(SelectedObject)
            Clipboard.Copy(Temp)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cut
    Private Sub CutButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CutButtonItem.ItemClick
        Try
            Dim Temp As New Objects.ObjectDataCollection
            Temp.Add(SelectedObject)
            Clipboard.Cut(Temp)
            CutTreeView = CurrentTreeView
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'paste
    Private Sub PasteButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PasteButtonItem.ItemClick
        Try
            'paste
            Dim GuidsMoved As ArrayList = Clipboard.Paste(SelectedObject)

            If Not GuidsMoved Is Nothing Then
                If Clipboard.Mode = Clipboard.CutCopy.Cut Then
                    GetTreeManager(CutTreeView).RemoveObjectsFromTree(GuidsMoved)
                    Clipboard.Clear()
                End If

                'reload the target node
                GetTreeManager(CurrentTreeView).ReloadNodeChildren(CurrentTreeView.SelectedNode)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Helper Functions"

    'relate a treeview to a tree manager
    Private Function GetTreeManager(ByVal TreeView As TreeView) As TreeManager
        Try
            If TreeView.Equals(TreeView1) Then
                Return TreeManager
            ElseIf TreeView.Equals(TreeView2) Then
                Return FavoritesTreeManager
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'recursively get the URI's for the selected node and its children
    Private Function GetURIList(ByVal Node As TreeNode) As ArrayList
        Dim TagData As TreeNodeTagData
        Dim Obj As New ObjectData

        Dim ReturnList As New ArrayList

        TagData = CType(Node.Tag, TreeNodeTagData)
        Obj.Load(TagData.ObjectKey)

        ReturnList.Add(RulePageManager.GetURI(Obj))

        'do the same for its children
        For Each ChildNode As TreeNode In Node.Nodes
            ReturnList.AddRange(GetURIList(ChildNode))
        Next

        Return ReturnList

    End Function

    'remove a collection of URI's
    Private Sub RemoveTabs(ByVal List As ArrayList)
        For Each URI As String In List
            If Tabs.Contains(URI) Then
                TabControl1.TabPages.Remove(CType(Tabs.Item(URI), XtraTabPage))
                Tabs.Remove(URI)
            End If
        Next
    End Sub

    'saves thes TreeView structure to XML
    Private Sub SaveTree()

        Dim XmlWriter As New XmlTextWriter(General.BasePath & "XML\RulesTreeView.xml", System.Text.Encoding.UTF8)
        XmlWriter.Formatting = Formatting.Indented

        XmlWriter.WriteStartDocument(True)
        XmlWriter.WriteStartElement("RPGXplorerConfig")

        'save the rule node recusivly
        Dim RootKey As New Objects.ObjectKey("001-00000000-0000-0000-0000-000000000006")
        For Each Node As TreeNode In TreeView1.Nodes
            If CType(Node.Tag, RPGXplorer.TreeManager.TreeNodeTagData).ObjectKey.Equals(RootKey) Then
                SaveNode(Node, XmlWriter)
                Exit For
            End If
        Next

        XmlWriter.WriteEndElement()
        XmlWriter.WriteEndDocument()
        XmlWriter.Flush()
        XmlWriter.Close()

    End Sub

    'recursive part of TreeView saving
    Private Sub SaveNode(ByVal Node As TreeNode, ByVal XmlWriter As XmlTextWriter)
        Dim TagData As RPGXplorer.TreeManager.TreeNodeTagData = CType(Node.Tag, RPGXplorer.TreeManager.TreeNodeTagData)

        'save myself
        XmlWriter.WriteStartElement("TreeNode")

        XmlWriter.WriteElementString("Name", Node.Text)
        XmlWriter.WriteElementString("ObjectGuid", TagData.ObjectKey.ToString)
        XmlWriter.WriteElementString("Type", TagData.ObjectType)
        XmlWriter.WriteElementString("ImageIndex", Node.ImageIndex.ToString)

        'save my children
        For Each ChildNode As TreeNode In Node.Nodes
            SaveNode(ChildNode, XmlWriter)
        Next

        XmlWriter.WriteEndElement()

    End Sub

#End Region

    'DEV ONLY
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim ObjectCollection As Objects.ObjectDataCollection

        Dim count As Integer = 0

        'rules and tables
        'ObjectCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.UserDocRulesType)
        'For Each obj As Objects.ObjectData In ObjectCollection

        ''correct type
        'Select Case obj.ImageFilename

        '    Case "book_blue.png"
        '        obj.Type = Objects.RulePageType

        '    Case "rule_table.png"
        '        obj.Type = Objects.RuleTableType

        'End Select

        '    If obj.HTML.EndsWith(".html") Then
        '        'Dim FullPath As String = RulePageManager.GetFullPath(obj)

        '        'IO.File.Delete(FullPath.Replace(".html", ".htm"))
        '        'IO.File.Move(FullPath, FullPath.Replace(".html", ".htm"))
        '        'obj.HTML = obj.HTML.Replace(".html", ".htm")
        '    End If

        '    obj.Save()

        'Next

        'folders and folder pages
        'ObjectCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.UserFolderType)
        'For Each obj As Objects.ObjectData In ObjectCollection

        '    ''correct type
        '    'Select Case obj.ImageFilename
        '    '    Case "Folder.png"
        '    '        obj.Type = Objects.RuleFolderType
        '    '    Case "books.png"
        '    '        obj.Type = Objects.RuleFolderPageType
        '    'End Select

        '    If obj.HTML.EndsWith(".html") Then
        '        'Dim FullPath As String = RulePageManager.GetFullPath(obj)

        '        'IO.File.Delete(FullPath.Replace(".html", ".htm"))
        '        'IO.File.Move(FullPath, FullPath.Replace(".html", ".htm"))
        '        'obj.HTML = obj.HTML.Replace(".html", ".htm")
        '    End If

        '    obj.Save()

        'Next

        ObjectCollection = Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RuleFolderPageType)
        ObjectCollection.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RuleFolderType))
        ObjectCollection.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RulePageType))
        ObjectCollection.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.RuleTableType))

        For Each Obj As Objects.ObjectData In ObjectCollection
            Dim FullPath As String = RulePageManager.GetFullPath(Obj)
            If Not IO.File.Exists(FullPath) Then count += 1
        Next

        'ObjectCollection = Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.RuleTableType)

        'For Each obj As Objects.ObjectData In ObjectCollection
        '    If obj.Name.StartsWith("Table") And (obj.Name.StartsWith("Table:") = False) Then
        '        obj.Name = obj.Name.Replace("Table", "Table:")

        '        If General.ShowQuestionDialog(obj.Name) = DialogResult.Yes Then
        '            obj.Save()
        '        End If
        '    End If
        'Next

        'For Each Obj As Objects.ObjectData In ObjectCollection
        '    If Obj.HTML.EndsWith(".html") Then
        '        count += 1
        '        MessageBox.Show(Obj.Name)
        '    End If
        'Next

        'Dim Pages As New Hashtable(2000)

        'For Each Obj As Objects.ObjectData In ObjectCollection
        '    Dim FullPath As String = RulePageManager.GetFullPath(Obj)
        '    If Not Pages.Contains(FullPath) Then Pages.Add(FullPath, Nothing)
        'Next

        'Dim Directory As IO.Directory
        'Dim Files As String()

        'Files = Directory.GetFiles(General.HelpPath & "UserDocs\", "*.html")

        'MessageBox.Show(".html files = " & Files.GetUpperBound(0).ToString)

        'For n As Integer = 0 To Files.GetUpperBound(0)
        '    Dim File As String = Files(n)

        '    IO.File.Delete(file)
        'Next

        'Files = Directory.GetFiles(General.HelpPath & "UserDocs\", "*.htm")

        'For n As Integer = 0 To Files.GetUpperBound(0)
        '    Dim File As String = Files(n)

        '    'If Not Pages.Contains(Files(n)) Then count += 1
        '    If Not Pages.Contains(Files(n)) Then IO.File.Delete(file)
        'Next

        MessageBox.Show("Orphans = " & count.ToString)

        XML.SaveXMLDB()
    End Sub

End Class