Option Explicit On 
Option Strict On

Imports RPGXplorer.Explorer
Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.XML
Imports RPGXplorer.CentralDisplayForm

Imports System.Xml
Imports System.Drawing
Imports System.IO.Directory
Imports System.Runtime.InteropServices
Imports System.Resources
Imports System.Security.Permissions

Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

'<Assembly: PermissionSetAttribute(SecurityAction.RequestMinimum, Name:="FullTrust")> 

Public Class MainWindow
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

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
	Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
	Public WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Public WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
	Public WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
	Public WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
	Public WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
	Public WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	Public WithEvents Menubar As DevExpress.XtraBars.Bar
	Public WithEvents Toolbar As DevExpress.XtraBars.Bar
	Public WithEvents BarManager As DevExpress.XtraBars.BarManager
	Public WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
	Public WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
	Public WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Public WithEvents Filters As DevExpress.XtraBars.Bar
	Public WithEvents Marketplace As DevExpress.XtraBars.Bar
	Public WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
	Public WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
	Public WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
	Public WithEvents BrowserDockPanel_Container As DevExpress.XtraBars.Docking.ControlContainer
	Public WithEvents FoldersDockPanel_Container As DevExpress.XtraBars.Docking.ControlContainer
	Public WithEvents Panel1 As System.Windows.Forms.Panel
	Public WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
	Public WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
	Public WithEvents BrowserDockPanel As DevExpress.XtraBars.Docking.DockPanel
	Public WithEvents FoldersDockPanel As DevExpress.XtraBars.Docking.DockPanel
	Public WithEvents Browser As System.Windows.Forms.WebBrowser
	Public WithEvents SmallImageList As System.Windows.Forms.ImageList
	Public WithEvents TreeView As System.Windows.Forms.TreeView
	Friend WithEvents BarMdiChildrenListItem As DevExpress.XtraBars.BarMdiChildrenListItem
	Friend WithEvents CloseTab As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents TabsPopupMenu As DevExpress.XtraBars.PopupMenu
	Friend WithEvents CloseAllButThis As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents CloseAllTabs As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents CloseAllFolders As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents CloseAllCreatureTabs As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents CloseAllMyTabs As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents CloseAllExceptNamesTabs As DevExpress.XtraBars.BarButtonItem
	Public WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Menubar = New DevExpress.XtraBars.Bar()
		Me.Toolbar = New DevExpress.XtraBars.Bar()
		Me.Filters = New DevExpress.XtraBars.Bar()
		Me.Marketplace = New DevExpress.XtraBars.Bar()
		Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
		Me.BrowserDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
		Me.BrowserDockPanel_Container = New DevExpress.XtraBars.Docking.ControlContainer()
		Me.Browser = New System.Windows.Forms.WebBrowser()
		Me.FoldersDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
		Me.FoldersDockPanel_Container = New DevExpress.XtraBars.Docking.ControlContainer()
		Me.TreeView = New System.Windows.Forms.TreeView()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
		Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
		Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
		Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.BarMdiChildrenListItem = New DevExpress.XtraBars.BarMdiChildrenListItem()
		Me.CloseTab = New DevExpress.XtraBars.BarButtonItem()
		Me.CloseAllButThis = New DevExpress.XtraBars.BarButtonItem()
		Me.CloseAllTabs = New DevExpress.XtraBars.BarButtonItem()
		Me.CloseAllFolders = New DevExpress.XtraBars.BarButtonItem()
		Me.CloseAllCreatureTabs = New DevExpress.XtraBars.BarButtonItem()
		Me.CloseAllMyTabs = New DevExpress.XtraBars.BarButtonItem()
		Me.CloseAllExceptNamesTabs = New DevExpress.XtraBars.BarButtonItem()
		Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
		Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
		Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
		Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
		Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
		Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
		Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
		Me.TabsPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
		CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BrowserDockPanel.SuspendLayout()
		Me.BrowserDockPanel_Container.SuspendLayout()
		Me.FoldersDockPanel.SuspendLayout()
		Me.FoldersDockPanel_Container.SuspendLayout()
		CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabsPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BarManager
		'
		Me.BarManager.AllowCustomization = False
		Me.BarManager.AllowMoveBarOnToolbar = False
		Me.BarManager.AllowQuickCustomization = False
		Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Menubar, Me.Toolbar, Me.Filters, Me.Marketplace})
		Me.BarManager.Controller = Me.BarAndDockingController1
		Me.BarManager.DockControls.Add(Me.barDockControlTop)
		Me.BarManager.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager.DockControls.Add(Me.barDockControlRight)
		Me.BarManager.DockManager = Me.DockManager1
		Me.BarManager.Form = Me
		Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarButtonItem1, Me.BarMdiChildrenListItem, Me.CloseTab, Me.CloseAllButThis, Me.CloseAllTabs, Me.CloseAllFolders, Me.CloseAllCreatureTabs, Me.CloseAllMyTabs, Me.CloseAllExceptNamesTabs})
		Me.BarManager.MainMenu = Me.Menubar
		Me.BarManager.MaxItemId = 28
		Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemProgressBar1, Me.RepositoryItemProgressBar2, Me.RepositoryItemSpinEdit1})
		Me.BarManager.ShowFullMenus = True
		'
		'Menubar
		'
		Me.Menubar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Menubar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
		Me.Menubar.Appearance.Options.UseFont = True
		Me.Menubar.BarItemHorzIndent = 6
		Me.Menubar.BarItemVertIndent = 3
		Me.Menubar.BarName = "Main Menu"
		Me.Menubar.DockCol = 0
		Me.Menubar.DockRow = 0
		Me.Menubar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
		Me.Menubar.OptionsBar.AllowQuickCustomization = False
		Me.Menubar.OptionsBar.MultiLine = True
		Me.Menubar.OptionsBar.UseWholeRow = True
		Me.Menubar.Text = "Main Menu"
		'
		'Toolbar
		'
		Me.Toolbar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Toolbar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
		Me.Toolbar.Appearance.Options.UseFont = True
		Me.Toolbar.BarItemHorzIndent = 3
		Me.Toolbar.BarItemVertIndent = 3
		Me.Toolbar.BarName = "Toolbar"
		Me.Toolbar.DockCol = 0
		Me.Toolbar.DockRow = 1
		Me.Toolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
		Me.Toolbar.OptionsBar.AllowQuickCustomization = False
		Me.Toolbar.OptionsBar.DisableClose = True
		Me.Toolbar.OptionsBar.DisableCustomization = True
		Me.Toolbar.OptionsBar.MultiLine = True
		Me.Toolbar.Text = "Tools"
		'
		'Filters
		'
		Me.Filters.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Filters.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
		Me.Filters.Appearance.Options.UseFont = True
		Me.Filters.BarItemHorzIndent = 3
		Me.Filters.BarItemVertIndent = 3
		Me.Filters.BarName = "Filters"
		Me.Filters.DockCol = 0
		Me.Filters.DockRow = 2
		Me.Filters.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
		Me.Filters.OptionsBar.AllowQuickCustomization = False
		Me.Filters.OptionsBar.DisableClose = True
		Me.Filters.OptionsBar.DisableCustomization = True
		Me.Filters.OptionsBar.MultiLine = True
		Me.Filters.OptionsBar.RotateWhenVertical = False
		Me.Filters.Text = "Filters"
		'
		'Marketplace
		'
		Me.Marketplace.BarName = "Marketplace"
		Me.Marketplace.DockCol = 1
		Me.Marketplace.DockRow = 2
		Me.Marketplace.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
		Me.Marketplace.OptionsBar.AllowQuickCustomization = False
		Me.Marketplace.Text = "Marketplace"
		'
		'BarAndDockingController1
		'
		Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
		'
		'barDockControlTop
		'
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(778, 75)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 542)
		Me.barDockControlBottom.Size = New System.Drawing.Size(778, 0)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 75)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 467)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(778, 75)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 467)
		'
		'DockManager1
		'
		Me.DockManager1.Controller = Me.BarAndDockingController1
		Me.DockManager1.Form = Me
		Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.BrowserDockPanel, Me.FoldersDockPanel})
		Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
		'
		'BrowserDockPanel
		'
		Me.BrowserDockPanel.Controls.Add(Me.BrowserDockPanel_Container)
		Me.BrowserDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
		Me.BrowserDockPanel.FloatSize = New System.Drawing.Size(300, 400)
		Me.BrowserDockPanel.ID = New System.Guid("b68613b2-ae7b-403b-a8de-3941de164a22")
		Me.BrowserDockPanel.Location = New System.Drawing.Point(578, 75)
		Me.BrowserDockPanel.Name = "BrowserDockPanel"
		Me.BrowserDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
		Me.BrowserDockPanel.Size = New System.Drawing.Size(200, 467)
		Me.BrowserDockPanel.Text = "Browser"
		'
		'BrowserDockPanel_Container
		'
		Me.BrowserDockPanel_Container.Controls.Add(Me.Browser)
		Me.BrowserDockPanel_Container.Location = New System.Drawing.Point(3, 29)
		Me.BrowserDockPanel_Container.Name = "BrowserDockPanel_Container"
		Me.BrowserDockPanel_Container.Size = New System.Drawing.Size(194, 435)
		Me.BrowserDockPanel_Container.TabIndex = 0
		'
		'Browser
		'
		Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Browser.Location = New System.Drawing.Point(0, 0)
		Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
		Me.Browser.Name = "Browser"
		Me.Browser.Size = New System.Drawing.Size(194, 435)
		Me.Browser.TabIndex = 0
		'
		'FoldersDockPanel
		'
		Me.FoldersDockPanel.Controls.Add(Me.FoldersDockPanel_Container)
		Me.FoldersDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
		Me.FoldersDockPanel.FloatSize = New System.Drawing.Size(300, 400)
		Me.FoldersDockPanel.ID = New System.Guid("a1816c85-d733-4cbe-9f8c-b66b2059a0ee")
		Me.FoldersDockPanel.Location = New System.Drawing.Point(0, 75)
		Me.FoldersDockPanel.Name = "FoldersDockPanel"
		Me.FoldersDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
		Me.FoldersDockPanel.Size = New System.Drawing.Size(200, 467)
		Me.FoldersDockPanel.Text = "Folders"
		'
		'FoldersDockPanel_Container
		'
		Me.FoldersDockPanel_Container.Controls.Add(Me.TreeView)
		Me.FoldersDockPanel_Container.Controls.Add(Me.Panel1)
		Me.FoldersDockPanel_Container.Location = New System.Drawing.Point(3, 29)
		Me.FoldersDockPanel_Container.Name = "FoldersDockPanel_Container"
		Me.FoldersDockPanel_Container.Size = New System.Drawing.Size(194, 435)
		Me.FoldersDockPanel_Container.TabIndex = 0
		'
		'TreeView
		'
		Me.TreeView.AllowDrop = True
		Me.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TreeView.Location = New System.Drawing.Point(0, 2)
		Me.TreeView.Name = "TreeView"
		Me.TreeView.Size = New System.Drawing.Size(194, 433)
		Me.TreeView.TabIndex = 29
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(194, 2)
		Me.Panel1.TabIndex = 28
		'
		'BarSubItem1
		'
		Me.BarSubItem1.Caption = "&File"
		Me.BarSubItem1.Id = 0
		Me.BarSubItem1.Name = "BarSubItem1"
		'
		'BarSubItem2
		'
		Me.BarSubItem2.Caption = "&Edit"
		Me.BarSubItem2.Id = 1
		Me.BarSubItem2.Name = "BarSubItem2"
		'
		'BarSubItem3
		'
		Me.BarSubItem3.Caption = "&Tools"
		Me.BarSubItem3.Id = 2
		Me.BarSubItem3.Name = "BarSubItem3"
		'
		'BarSubItem4
		'
		Me.BarSubItem4.Caption = "&Help"
		Me.BarSubItem4.Id = 3
		Me.BarSubItem4.Name = "BarSubItem4"
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "Marketplace"
		Me.BarButtonItem1.Id = 18
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'BarMdiChildrenListItem
		'
		Me.BarMdiChildrenListItem.Caption = "&Window"
		Me.BarMdiChildrenListItem.Id = 20
		Me.BarMdiChildrenListItem.Name = "BarMdiChildrenListItem"
		'
		'CloseTab
		'
		Me.CloseTab.Caption = "Close"
		Me.CloseTab.Id = 21
		Me.CloseTab.Name = "CloseTab"
		'
		'CloseAllButThis
		'
		Me.CloseAllButThis.Caption = "Close All But This"
		Me.CloseAllButThis.Id = 22
		Me.CloseAllButThis.Name = "CloseAllButThis"
		'
		'CloseAllTabs
		'
		Me.CloseAllTabs.Caption = "Close All Tabs"
		Me.CloseAllTabs.Id = 23
		Me.CloseAllTabs.Name = "CloseAllTabs"
		'
		'CloseAllFolders
		'
		Me.CloseAllFolders.Caption = "Close All Rules and Rule Folders"
		Me.CloseAllFolders.Id = 24
		Me.CloseAllFolders.Name = "CloseAllFolders"
		'
		'CloseAllCreatureTabs
		'
		Me.CloseAllCreatureTabs.Caption = "Close All Character/Monster Tabs"
		Me.CloseAllCreatureTabs.Id = 25
		Me.CloseAllCreatureTabs.Name = "CloseAllCreatureTabs"
		'
		'CloseAllMyTabs
		'
		Me.CloseAllMyTabs.Caption = "Close All Name Tabs"
		Me.CloseAllMyTabs.Id = 26
		Me.CloseAllMyTabs.Name = "CloseAllMyTabs"
		'
		'CloseAllExceptNamesTabs
		'
		Me.CloseAllExceptNamesTabs.Caption = "Closs All Except Name's Tabs"
		Me.CloseAllExceptNamesTabs.Id = 27
		Me.CloseAllExceptNamesTabs.Name = "CloseAllExceptNamesTabs"
		'
		'RepositoryItemTextEdit1
		'
		Me.RepositoryItemTextEdit1.AutoHeight = False
		Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
		Me.RepositoryItemTextEdit1.ReadOnly = True
		'
		'RepositoryItemProgressBar1
		'
		Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
		'
		'RepositoryItemProgressBar2
		'
		Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
		Me.RepositoryItemProgressBar2.PercentView = False
		Me.RepositoryItemProgressBar2.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
		Me.RepositoryItemProgressBar2.Step = 1
		'
		'RepositoryItemSpinEdit1
		'
		Me.RepositoryItemSpinEdit1.AutoHeight = False
		Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
		Me.RepositoryItemSpinEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		'
		'SmallImageList
		'
		Me.SmallImageList.ImageStream = CType(resources.GetObject("SmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
		Me.SmallImageList.Images.SetKeyName(0, "WeaponUnarmedStrike.png")
		Me.SmallImageList.Images.SetKeyName(1, "Ability.png")
		Me.SmallImageList.Images.SetKeyName(2, "AnimalCompanion.png")
		Me.SmallImageList.Images.SetKeyName(3, "Armor.png")
		Me.SmallImageList.Images.SetKeyName(4, "ArmorBanded.png")
		Me.SmallImageList.Images.SetKeyName(5, "ArmorBreastplate.png")
		Me.SmallImageList.Images.SetKeyName(6, "ArmorChainmail.png")
		Me.SmallImageList.Images.SetKeyName(7, "ArmorChainShirt.png")
		Me.SmallImageList.Images.SetKeyName(8, "ArmorDefault.png")
		Me.SmallImageList.Images.SetKeyName(9, "ArmorFullPlate.png")
		Me.SmallImageList.Images.SetKeyName(10, "ArmorHalfPlate.png")
		Me.SmallImageList.Images.SetKeyName(11, "ArmorHide.png")
		Me.SmallImageList.Images.SetKeyName(12, "ArmorLeather.png")
		Me.SmallImageList.Images.SetKeyName(13, "ArmorPadded.png")
		Me.SmallImageList.Images.SetKeyName(14, "ArmorScaleMail.png")
		Me.SmallImageList.Images.SetKeyName(15, "ArmorShields.png")
		Me.SmallImageList.Images.SetKeyName(16, "ArmorSplintMail.png")
		Me.SmallImageList.Images.SetKeyName(17, "ArmorStuddedLeather.png")
		Me.SmallImageList.Images.SetKeyName(18, "Bite.png")
		Me.SmallImageList.Images.SetKeyName(19, "book_blue.png")
		Me.SmallImageList.Images.SetKeyName(20, "book_green.png")
		Me.SmallImageList.Images.SetKeyName(21, "book_open2.png")
		Me.SmallImageList.Images.SetKeyName(22, "book_open.png")
		Me.SmallImageList.Images.SetKeyName(23, "book_red.png")
		Me.SmallImageList.Images.SetKeyName(24, "book_yellow.png")
		Me.SmallImageList.Images.SetKeyName(25, "books.png")
		Me.SmallImageList.Images.SetKeyName(26, "CharacterHumanFemale.png")
		Me.SmallImageList.Images.SetKeyName(27, "CharacterHumanMale.png")
		Me.SmallImageList.Images.SetKeyName(28, "Claw.png")
		Me.SmallImageList.Images.SetKeyName(29, "CognizanceCrystal.png")
		Me.SmallImageList.Images.SetKeyName(30, "Dorje.png")
		Me.SmallImageList.Images.SetKeyName(31, "Encounter.png")
		Me.SmallImageList.Images.SetKeyName(32, "EquipmentAdventuringGearSmallItems.png")
		Me.SmallImageList.Images.SetKeyName(33, "EquipmentAlchemyLab.png")
		Me.SmallImageList.Images.SetKeyName(34, "EquipmentBackpack.png")
		Me.SmallImageList.Images.SetKeyName(35, "EquipmentBarrel.png")
		Me.SmallImageList.Images.SetKeyName(36, "EquipmentBasket.png")
		Me.SmallImageList.Images.SetKeyName(37, "EquipmentBedroll.png")
		Me.SmallImageList.Images.SetKeyName(38, "EquipmentBell.png")
		Me.SmallImageList.Images.SetKeyName(39, "EquipmentBlanket.png")
		Me.SmallImageList.Images.SetKeyName(40, "EquipmentBlockAndTackle.png")
		Me.SmallImageList.Images.SetKeyName(41, "EquipmentBoat.png")
		Me.SmallImageList.Images.SetKeyName(42, "EquipmentBottleWine.png")
		Me.SmallImageList.Images.SetKeyName(43, "EquipmentBucket.png")
		Me.SmallImageList.Images.SetKeyName(44, "EquipmentCaltrops.png")
		Me.SmallImageList.Images.SetKeyName(45, "EquipmentCandle.png")
		Me.SmallImageList.Images.SetKeyName(46, "EquipmentCanvas.png")
		Me.SmallImageList.Images.SetKeyName(47, "EquipmentCaseMapOrScroll.png")
		Me.SmallImageList.Images.SetKeyName(48, "EquipmentChain.png")
		Me.SmallImageList.Images.SetKeyName(49, "EquipmentCheese.png")
		Me.SmallImageList.Images.SetKeyName(50, "EquipmentChest.png")
		Me.SmallImageList.Images.SetKeyName(51, "EquipmentClothing.png")
		Me.SmallImageList.Images.SetKeyName(52, "EquipmentCrowbar.png")
		Me.SmallImageList.Images.SetKeyName(53, "EquipmentDefault.png")
		Me.SmallImageList.Images.SetKeyName(54, "EquipmentDog.png")
		Me.SmallImageList.Images.SetKeyName(55, "EquipmentFirewood.png")
		Me.SmallImageList.Images.SetKeyName(56, "EquipmentFishingEquipmentHookNet.png")
		Me.SmallImageList.Images.SetKeyName(57, "EquipmentFlaskFlaskOfOil.png")
		Me.SmallImageList.Images.SetKeyName(58, "EquipmentFlaskHolywaterAcidAntitoxin.png")
		Me.SmallImageList.Images.SetKeyName(59, "EquipmentFlintAndSteel.png")
		Me.SmallImageList.Images.SetKeyName(60, "EquipmentFoodDrinkLodgings.png")
		Me.SmallImageList.Images.SetKeyName(61, "EquipmentGear.png")
		Me.SmallImageList.Images.SetKeyName(62, "EquipmentGrapplingHook.png")
		Me.SmallImageList.Images.SetKeyName(63, "EquipmentHammer.png")
		Me.SmallImageList.Images.SetKeyName(64, "EquipmentHerbsPlantsEtc.png")
		Me.SmallImageList.Images.SetKeyName(65, "EquipmentHolySymbolSilver.png")
		Me.SmallImageList.Images.SetKeyName(66, "EquipmentHolySymbolWooden.png")
		Me.SmallImageList.Images.SetKeyName(67, "EquipmentHourglass.png")
		Me.SmallImageList.Images.SetKeyName(68, "EquipmentLadder.png")
		Me.SmallImageList.Images.SetKeyName(69, "EquipmentLantern.png")
		Me.SmallImageList.Images.SetKeyName(70, "EquipmentLoafOfBread.png")
		Me.SmallImageList.Images.SetKeyName(71, "EquipmentLock.png")
		Me.SmallImageList.Images.SetKeyName(72, "EquipmentMagnifyingGlass.png")
		Me.SmallImageList.Images.SetKeyName(73, "EquipmentManacles.png")
		Me.SmallImageList.Images.SetKeyName(74, "EquipmentMinersPick.png")
		Me.SmallImageList.Images.SetKeyName(75, "EquipmentMirror.png")
		Me.SmallImageList.Images.SetKeyName(76, "EquipmentMoney.png")
		Me.SmallImageList.Images.SetKeyName(77, "EquipmentMounts.png")
		Me.SmallImageList.Images.SetKeyName(78, "EquipmentMusicalInstrument.png")
		Me.SmallImageList.Images.SetKeyName(79, "EquipmentPitcher.png")
		Me.SmallImageList.Images.SetKeyName(80, "EquipmentPiton.png")
		Me.SmallImageList.Images.SetKeyName(81, "EquipmentPole.png")
		Me.SmallImageList.Images.SetKeyName(82, "EquipmentPortableRam.png")
		Me.SmallImageList.Images.SetKeyName(83, "EquipmentPot.png")
		Me.SmallImageList.Images.SetKeyName(84, "EquipmentPouchBelt.png")
		Me.SmallImageList.Images.SetKeyName(85, "EquipmentRations.png")
		Me.SmallImageList.Images.SetKeyName(86, "EquipmentRope.png")
		Me.SmallImageList.Images.SetKeyName(87, "EquipmentSack.png")
		Me.SmallImageList.Images.SetKeyName(88, "EquipmentScales.png")
		Me.SmallImageList.Images.SetKeyName(89, "EquipmentServices.png")
		Me.SmallImageList.Images.SetKeyName(90, "EquipmentSignetRing.png")
		Me.SmallImageList.Images.SetKeyName(91, "EquipmentSledSledge.png")
		Me.SmallImageList.Images.SetKeyName(92, "EquipmentSmokestick.png")
		Me.SmallImageList.Images.SetKeyName(93, "EquipmentSpadeShovel.png")
		Me.SmallImageList.Images.SetKeyName(94, "EquipmentSpellbook.png")
		Me.SmallImageList.Images.SetKeyName(95, "EquipmentSpyglassTelescope.png")
		Me.SmallImageList.Images.SetKeyName(96, "EquipmentStationery.png")
		Me.SmallImageList.Images.SetKeyName(97, "EquipmentSunrod.png")
		Me.SmallImageList.Images.SetKeyName(98, "EquipmentTankardMug.png")
		Me.SmallImageList.Images.SetKeyName(99, "EquipmentTent.png")
		Me.SmallImageList.Images.SetKeyName(100, "EquipmentThievesTools.png")
		Me.SmallImageList.Images.SetKeyName(101, "EquipmentThunderstone.png")
		Me.SmallImageList.Images.SetKeyName(102, "EquipmentTindertwig.png")
		Me.SmallImageList.Images.SetKeyName(103, "EquipmentToolsHealerArtisanEtc.png")
		Me.SmallImageList.Images.SetKeyName(104, "EquipmentTorch.png")
		Me.SmallImageList.Images.SetKeyName(105, "EquipmentTransport.png")
		Me.SmallImageList.Images.SetKeyName(106, "EquipmentWaterClock.png")
		Me.SmallImageList.Images.SetKeyName(107, "EquipmentWaterskin.png")
		Me.SmallImageList.Images.SetKeyName(108, "EquipmentWhetstone.png")
		Me.SmallImageList.Images.SetKeyName(109, "Familiar.png")
		Me.SmallImageList.Images.SetKeyName(110, "Feat.png")
		Me.SmallImageList.Images.SetKeyName(111, "FeatBlank.png")
		Me.SmallImageList.Images.SetKeyName(112, "FeatItemCreation.png")
		Me.SmallImageList.Images.SetKeyName(113, "FeatMetamagic.png")
		Me.SmallImageList.Images.SetKeyName(114, "FeatPsionic.png")
		Me.SmallImageList.Images.SetKeyName(115, "Folder.png")
		Me.SmallImageList.Images.SetKeyName(116, "Gore.png")
		Me.SmallImageList.Images.SetKeyName(117, "Language.png")
		Me.SmallImageList.Images.SetKeyName(118, "MagicItemsAbility.png")
		Me.SmallImageList.Images.SetKeyName(119, "MagicItemsArtifacts.png")
		Me.SmallImageList.Images.SetKeyName(120, "MagicItemsPotion.png")
		Me.SmallImageList.Images.SetKeyName(121, "MagicItemsRings.png")
		Me.SmallImageList.Images.SetKeyName(122, "MagicItemsRods.png")
		Me.SmallImageList.Images.SetKeyName(123, "MagicItemsScrolls.png")
		Me.SmallImageList.Images.SetKeyName(124, "MagicItemsStaffs.png")
		Me.SmallImageList.Images.SetKeyName(125, "MagicItemsWands.png")
		Me.SmallImageList.Images.SetKeyName(126, "MagicItemsWondrous.png")
		Me.SmallImageList.Images.SetKeyName(127, "ModifierNegative.png")
		Me.SmallImageList.Images.SetKeyName(128, "ModifierNegativeAbility.png")
		Me.SmallImageList.Images.SetKeyName(129, "ModifierNegativeArmourClass.png")
		Me.SmallImageList.Images.SetKeyName(130, "ModifierNegativeCombat.png")
		Me.SmallImageList.Images.SetKeyName(131, "ModifierPositive.png")
		Me.SmallImageList.Images.SetKeyName(132, "ModifierPositiveAbility.png")
		Me.SmallImageList.Images.SetKeyName(133, "ModifierPositiveArmourClass.png")
		Me.SmallImageList.Images.SetKeyName(134, "ModiiferPositiveCombat.png")
		Me.SmallImageList.Images.SetKeyName(135, "MonsterFemale.png")
		Me.SmallImageList.Images.SetKeyName(136, "MonsterMale.png")
		Me.SmallImageList.Images.SetKeyName(137, "MountBrown.png")
		Me.SmallImageList.Images.SetKeyName(138, "MountWhite.png")
		Me.SmallImageList.Images.SetKeyName(139, "Power.png")
		Me.SmallImageList.Images.SetKeyName(140, "PowerStone.png")
		Me.SmallImageList.Images.SetKeyName(141, "PsiCrown.png")
		Me.SmallImageList.Images.SetKeyName(142, "PsiCrystal.png")
		Me.SmallImageList.Images.SetKeyName(143, "PsiCrystalCompanion.png")
		Me.SmallImageList.Images.SetKeyName(144, "PsionicAbility.png")
		Me.SmallImageList.Images.SetKeyName(145, "PsionicArtifact.png")
		Me.SmallImageList.Images.SetKeyName(146, "PsionicBlank.png")
		Me.SmallImageList.Images.SetKeyName(147, "refresh.png")
		Me.SmallImageList.Images.SetKeyName(148, "rule_table.png")
		Me.SmallImageList.Images.SetKeyName(149, "RuleObject2.png")
		Me.SmallImageList.Images.SetKeyName(150, "RuleObject.png")
		Me.SmallImageList.Images.SetKeyName(151, "RuleObjectSystem.png")
		Me.SmallImageList.Images.SetKeyName(152, "ShieldsBuckler.png")
		Me.SmallImageList.Images.SetKeyName(153, "ShieldsDefault.png")
		Me.SmallImageList.Images.SetKeyName(154, "ShieldsSteelLarge.png")
		Me.SmallImageList.Images.SetKeyName(155, "ShieldsSteelSmall.png")
		Me.SmallImageList.Images.SetKeyName(156, "ShieldsTower.png")
		Me.SmallImageList.Images.SetKeyName(157, "ShieldsWoodenLarge.png")
		Me.SmallImageList.Images.SetKeyName(158, "ShieldsWoodenSmall.png")
		Me.SmallImageList.Images.SetKeyName(159, "Skill.png")
		Me.SmallImageList.Images.SetKeyName(160, "SkillBlank.png")
		Me.SmallImageList.Images.SetKeyName(161, "SkillCraft.png")
		Me.SmallImageList.Images.SetKeyName(162, "SkillKnowledge.png")
		Me.SmallImageList.Images.SetKeyName(163, "SkillMagic.png")
		Me.SmallImageList.Images.SetKeyName(164, "SkillPerform.png")
		Me.SmallImageList.Images.SetKeyName(165, "SkillPsionic.png")
		Me.SmallImageList.Images.SetKeyName(166, "Slam.png")
		Me.SmallImageList.Images.SetKeyName(167, "Spell.png")
		Me.SmallImageList.Images.SetKeyName(168, "SpellBlank.png")
		Me.SmallImageList.Images.SetKeyName(169, "Stamp.png")
		Me.SmallImageList.Images.SetKeyName(170, "star_green.png")
		Me.SmallImageList.Images.SetKeyName(171, "TailSlap.png")
		Me.SmallImageList.Images.SetKeyName(172, "Talon.png")
		Me.SmallImageList.Images.SetKeyName(173, "Tattoo.png")
		Me.SmallImageList.Images.SetKeyName(174, "Tentacle.png")
		Me.SmallImageList.Images.SetKeyName(175, "UniversalItem.png")
		Me.SmallImageList.Images.SetKeyName(176, "UserDoc.png")
		Me.SmallImageList.Images.SetKeyName(177, "UserDocMap.png")
		Me.SmallImageList.Images.SetKeyName(178, "WeaponBastardSword.png")
		Me.SmallImageList.Images.SetKeyName(179, "WeaponCompositeLongbow.png")
		Me.SmallImageList.Images.SetKeyName(180, "WeaponCrossbowRepeating.png")
		Me.SmallImageList.Images.SetKeyName(181, "WeaponGlaive.png")
		Me.SmallImageList.Images.SetKeyName(182, "WeaponGreatSword.png")
		Me.SmallImageList.Images.SetKeyName(183, "WeaponGuisarme.png")
		Me.SmallImageList.Images.SetKeyName(184, "WeaponHalberd.png")
		Me.SmallImageList.Images.SetKeyName(185, "WeaponLongbow.png")
		Me.SmallImageList.Images.SetKeyName(186, "WeaponRanseur.png")
		Me.SmallImageList.Images.SetKeyName(187, "WeaponSai.png")
		Me.SmallImageList.Images.SetKeyName(188, "WeaponsArrow.png")
		Me.SmallImageList.Images.SetKeyName(189, "WeaponsAxe.png")
		Me.SmallImageList.Images.SetKeyName(190, "WeaponsAxeLarge.png")
		Me.SmallImageList.Images.SetKeyName(191, "WeaponsBolas.png")
		Me.SmallImageList.Images.SetKeyName(192, "WeaponsBolt.png")
		Me.SmallImageList.Images.SetKeyName(193, "WeaponsBow.png")
		Me.SmallImageList.Images.SetKeyName(194, "WeaponsClub.png")
		Me.SmallImageList.Images.SetKeyName(195, "WeaponsCrossbow.png")
		Me.SmallImageList.Images.SetKeyName(196, "WeaponsDagger.png")
		Me.SmallImageList.Images.SetKeyName(197, "WeaponsDaggerPunching.png")
		Me.SmallImageList.Images.SetKeyName(198, "WeaponsDart.png")
		Me.SmallImageList.Images.SetKeyName(199, "WeaponsDefault.png")
		Me.SmallImageList.Images.SetKeyName(200, "WeaponsFalchion.png")
		Me.SmallImageList.Images.SetKeyName(201, "WeaponsGauntlet.png")
		Me.SmallImageList.Images.SetKeyName(202, "WeaponsGauntletSpiked.png")
		Me.SmallImageList.Images.SetKeyName(203, "WeaponsHammer.png")
		Me.SmallImageList.Images.SetKeyName(204, "WeaponsJavelin.png")
		Me.SmallImageList.Images.SetKeyName(205, "WeaponsKama.png")
		Me.SmallImageList.Images.SetKeyName(206, "WeaponsKukri.png")
		Me.SmallImageList.Images.SetKeyName(207, "WeaponsLance.png")
		Me.SmallImageList.Images.SetKeyName(208, "WeaponsMace.png")
		Me.SmallImageList.Images.SetKeyName(209, "WeaponsMorningStar.png")
		Me.SmallImageList.Images.SetKeyName(210, "WeaponsNet.png")
		Me.SmallImageList.Images.SetKeyName(211, "WeaponsNunchaku.png")
		Me.SmallImageList.Images.SetKeyName(212, "WeaponsPick.png")
		Me.SmallImageList.Images.SetKeyName(213, "WeaponsPolearms.png")
		Me.SmallImageList.Images.SetKeyName(214, "WeaponsQuarterstaff.png")
		Me.SmallImageList.Images.SetKeyName(215, "WeaponsRapier.png")
		Me.SmallImageList.Images.SetKeyName(216, "WeaponsSap.png")
		Me.SmallImageList.Images.SetKeyName(217, "WeaponsScimitar.png")
		Me.SmallImageList.Images.SetKeyName(218, "WeaponsScythe.png")
		Me.SmallImageList.Images.SetKeyName(219, "WeaponsShuriken.png")
		Me.SmallImageList.Images.SetKeyName(220, "WeaponsSiangham.png")
		Me.SmallImageList.Images.SetKeyName(221, "WeaponsSickle.png")
		Me.SmallImageList.Images.SetKeyName(222, "WeaponsSling.png")
		Me.SmallImageList.Images.SetKeyName(223, "WeaponsSlingBullet.png")
		Me.SmallImageList.Images.SetKeyName(224, "WeaponsSpear.png")
		Me.SmallImageList.Images.SetKeyName(225, "WeaponsSpikedChain.png")
		Me.SmallImageList.Images.SetKeyName(226, "WeaponsSwordLarge.png")
		Me.SmallImageList.Images.SetKeyName(227, "WeaponsSwordShort.png")
		Me.SmallImageList.Images.SetKeyName(228, "WeaponsWhip.png")
		Me.SmallImageList.Images.SetKeyName(229, "WeaponTrident.png")
		Me.SmallImageList.Images.SetKeyName(230, "WeaponTwo-BladedSword.png")
		'
		'ControlContainer1
		'
		Me.ControlContainer1.Location = New System.Drawing.Point(2, 24)
		Me.ControlContainer1.Name = "ControlContainer1"
		Me.ControlContainer1.Size = New System.Drawing.Size(196, 174)
		Me.ControlContainer1.TabIndex = 0
		'
		'DefaultLookAndFeel1
		'
		Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 60000
		'
		'HelpProvider1
		'
		Me.HelpProvider1.HelpNamespace = "./RPGXplorerHelp.chm"
		'
		'XtraTabbedMdiManager1
		'
		Me.XtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.XtraTabbedMdiManager1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader
		Me.XtraTabbedMdiManager1.Controller = Me.BarAndDockingController1
		Me.XtraTabbedMdiManager1.MdiParent = Me
		'
		'TabsPopupMenu
		'
		Me.TabsPopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CloseTab), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseAllButThis), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseAllFolders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseAllCreatureTabs), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseAllMyTabs), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseAllExceptNamesTabs), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseAllTabs, True)})
		Me.TabsPopupMenu.Manager = Me.BarManager
		Me.TabsPopupMenu.Name = "TabsPopupMenu"
		'
		'MainWindow
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.ControlLight
		Me.ClientSize = New System.Drawing.Size(778, 542)
		Me.Controls.Add(Me.FoldersDockPanel)
		Me.Controls.Add(Me.BrowserDockPanel)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Index)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.KeyPreview = True
		Me.Name = "MainWindow"
		Me.HelpProvider1.SetShowHelp(Me, True)
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.BrowserDockPanel.ResumeLayout(False)
		Me.BrowserDockPanel_Container.ResumeLayout(False)
		Me.FoldersDockPanel.ResumeLayout(False)
		Me.FoldersDockPanel_Container.ResumeLayout(False)
		CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabsPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

#Region "Member Variables"

    Private IsLoading As Boolean
    Public TabFocusFlag As Boolean = False
    Public ProgressBar As New ProgressBar
    Public IgnoreSelect As Boolean = False

#End Region

#Region "Enumerations"

    Private Enum NodeState
        expanding
        collapsing
    End Enum

#End Region

    'main
    Public Shared Sub Main()
        Try
			Application.Run(New MainWindow)
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'form load event handler - the first code to run when the form starts up
    Private Sub MainWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim LocalVerify As Boolean

        Try
            IsLoading = True
            Me.Visible = False
            ProgressBar.Caption = "Starting Application"
            ProgressBar.Maximum = 224
            ProgressBar.TopMost = True
            ProgressBar.Show()

            Me.Text = General.Version
            XML.Lock = True

            General.Mode = AppMode.Full

            ProgressBar.Increment()

            'initialise the interface
            Me.SuspendLayout()
            InitApplication(ProgressBar)

            'load dock layout
            Try
                DockManager1.RestoreFromXml(General.BasePath & "XML\DockLayout.xml")
            Catch ex As Exception
                'if the file is not found, do nothing
            End Try

            ProgressBar.Caption = "RPGXplorer - Initializing Interface"
            HelpProvider1.HelpNamespace = General.BasePath & "RPGXplorerHelp.chm"
            ToolbarsAndMenus.BarManager = Me.BarManager
            ToolbarsAndMenus.Menubar = Me.Menubar
            ToolbarsAndMenus.Toolbar = Me.Toolbar
            ToolbarsAndMenus.FilterBar = Me.Filters
            ToolbarsAndMenus.MarketplaceBar = Me.Marketplace
            ToolbarsAndMenus.Initialise()
            ProgressBar.Increment()

            Me.ResumeLayout()
            General.MainExplorer = New Explorer(TreeView, Me, Browser, ProgressBar)
            ToolbarsAndMenus.InitConfig()
            ProgressBar.Close()

            MainExplorer.SuspendEvents = True
            Me.Visible = True
            MainExplorer.SuspendEvents = False

            'pull focus to list view 
            If Not General.MainExplorer.ListView Is Nothing Then
                General.MainExplorer.ListView.Focus()
                General.MainExplorer.ListViewManager.ColourListView()
            ElseIf WindowManager.NoWindowsOpen Then
                TreeView.Focus()
            End If

            'set the timer tick - doing now as its has a chance to run the explorer init and startup patch
            If General.AutosaveInterval = 0 Then
                Timer1.Enabled = False
            Else
                Timer1.Interval = (General.AutosaveInterval * 60000)
            End If

            'news
            If General.ShowNewsOnStartup Then
                Dim NewsInfoFrom As New NewsForm
                NewsInfoFrom.Init()
                NewsInfoFrom.ShowDialog()
            End If

            XML.Lock = False
            IsLoading = False

            AddHandler Application.Idle, AddressOf Application_Idle

        Catch ex As Exception
            If Not LocalVerify Then
                HandleException(ex)
                Application.Exit()
            Else
                HandleException(ex)
            End If
        End Try
    End Sub

#Region "Tree Event Handlers"

    'load the children of the currently selected node (if required)
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        If MainExplorer Is Nothing OrElse TreeView.SelectedNode Is Nothing OrElse MainExplorer.SuspendEvents Then Exit Sub
        Try
            If e.Node Is TreeView.SelectedNode Then
                MainExplorer.OpenSelectedFolder()
                MainExplorer.ShowHelpForTreeNode()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'got focus
    Private Sub TreeView1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView.GotFocus
        If MainExplorer Is Nothing OrElse TreeView.SelectedNode Is Nothing OrElse MainExplorer.SuspendEvents Then Exit Sub
        MainExplorer.CurrentFocus = RPGXplorer.Explorer.Focus.TreeView
    End Sub

    'display right click menu
    Private Sub TreeView1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView.MouseUp
        Try
            Dim Node As TreeNode
            Dim Point As Point

            If e.Button = MouseButtons.Right AndAlso Not UI.ReadOnly Then
                Point = TreeView.PointToClient(New Point(TreeView.MousePosition.X, TreeView.MousePosition.Y))
                Node = TreeView.GetNodeAt(Point)
                If Not Node Is Nothing Then TreeView.SelectedNode = Node

                ToolbarsAndMenus.BuildPopupMenu()
                ToolbarsAndMenus.PopupMenu.ShowPopup(New Point(TreeView.MousePosition.X, TreeView.MousePosition.Y))
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'double click   
    Private Sub TreeView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView.DoubleClick
        Try
            General.MainExplorer.HandleItemActivate()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Dim DragBox As Rectangle

    Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView.MouseDown
        If e.Button = MouseButtons.Left And (Not TreeView.GetNodeAt(e.X, e.Y) Is Nothing) Then
            Dim DragSize As Size = SystemInformation.DragSize
            DragBox = New Rectangle(New Point(e.X - (DragSize.Width \ 2), e.Y - (DragSize.Height \ 2)), DragSize)
        End If
    End Sub

    Private Sub TreeView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView.MouseMove
        If e.Button = MouseButtons.Left Then
            If Not (DragBox.Equals(Rectangle.Empty)) AndAlso (Not DragBox.Contains(e.X, e.Y)) Then
                Dim DraggedFolder As New Objects.ObjectData
                Dim DraggedNode As TreeNode = TreeView.GetNodeAt(e.X, e.Y)

                If Not DraggedNode Is Nothing Then
                    DraggedFolder.Load(CType(DraggedNode.Tag, Explorer.ObjectTagData).ObjectGUID)
                End If

                'make sure item is of correct type
                Select Case DraggedFolder.Type
                    Case Objects.ItemType
                        If Not (DraggedFolder.Element("IsContainer") = "Yes" OrElse DraggedFolder.GetFKObject("Item").Element("IsContainer") = "Yes") Then
                            Exit Sub
                        End If
                    Case Else
                        Exit Sub
                End Select

                Dim TreeObjects As Objects.ObjectDataCollection = New Objects.ObjectDataCollection
                TreeObjects.Add(DraggedFolder)
                General.DragSource = DragSourceType.Tree
                TreeView.DoDragDrop(TreeObjects, DragDropEffects.All)
            End If
        End If
    End Sub

    Private Sub TreeView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView.DragOver
        Try
            Dim Selected As Objects.ObjectDataCollection = CType(e.Data.GetData(GetType(Objects.ObjectDataCollection)), Objects.ObjectDataCollection)

            If Not Selected Is Nothing OrElse Selected.Count > 0 Then
                If ModifierKeys = Keys.Control Then
                    e.Effect = DragDropEffects.Copy
                Else
                    e.Effect = DragDropEffects.Move
                End If
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub TreeView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView.DragDrop

        'get the listview target - if none, its the selected tree node
        Dim DragedItems As Objects.ObjectDataCollection = CType(e.Data.GetData(GetType(Objects.ObjectDataCollection)), Objects.ObjectDataCollection)
        Dim TargetFolder As New Objects.ObjectData
        Dim TargetLocation As Point = TreeView.PointToClient(New Point(e.X, e.Y))
        Dim SelectedNode As TreeNode = TreeView.GetNodeAt(TargetLocation.X, TargetLocation.Y)

        If SelectedNode Is Nothing Then
            Exit Sub
        Else
            TargetFolder.Load(CType(SelectedNode.Tag, ObjectTagData).ObjectGUID)
        End If

        'make sure the target is not one of the items being draged
        If DragedItems.Contains(TargetFolder.ObjectGUID) Then
            General.ShowErrorDialog("The destination object is included in the current selection.")
            Exit Sub
        End If

        'make sure the dragged items do not contain the parent of the target item
        If DragedItems.Contains(TargetFolder.ParentGUID) Then
            General.ShowErrorDialog("The destination object's parent is included in the current selection.")
            Exit Sub
        End If

        If Not TargetFolder.IsEmpty Then

            Select Case TargetFolder.Type

                Case Objects.InventoryFolderType, Objects.AssetsFolderType
                    'do nothing
                Case Objects.ItemType
                    If Not (TargetFolder.Element("IsContainer") = "Yes" OrElse TargetFolder.GetFKObject("Item").Element("IsContainer") = "Yes") Then
                        Exit Sub
                    End If
                Case Else
                    Exit Sub
            End Select

            General.MainExplorer.Undo.UndoRecord()

            If e.Effect = DragDropEffects.Copy Then
                Dim TempObjectCollection As New Objects.ObjectDataCollection
                Dim KeyMap As New ObjectHashtable

                General.MainExplorer.TreeView.BeginUpdate()
                General.SetWaitCursor()

                For Each SelectedObject As Objects.ObjectData In DragedItems
                    TempObjectCollection.Clear()
                    TempObjectCollection = SelectedObject.CloneWithKeyMap(TargetFolder, KeyMap)
                    TempObjectCollection.Save()

                    Dim ExistingNode, NewNode, TargetNode As TreeNode
                    Dim ObjectTag As Explorer.ObjectTagData

                    ExistingNode = CType(General.MainExplorer.TreeNodes(SelectedObject.ObjectGUID), TreeNode)
                    If Not ExistingNode Is Nothing Then
                        NewNode = CType(ExistingNode.Clone, TreeNode)
                        ObjectTag = CType(ExistingNode.Tag, Explorer.ObjectTagData)
                        ObjectTag.Name = TempObjectCollection.Item(0).Name
                        ObjectTag.ObjectGUID = CType(KeyMap(SelectedObject.ObjectGUID), Objects.ObjectKey)
                        NewNode.Tag = ObjectTag
                        TargetNode = CType(General.MainExplorer.TreeNodes(TargetFolder.ObjectGUID), TreeNode)
                        NewNode.Text = ObjectTag.Name
                        If Not TargetNode Is Nothing Then
                            General.MainExplorer.InsertNode(TargetNode, NewNode)
                            General.MainExplorer.TreeNodes.Item(ObjectTag.ObjectGUID) = NewNode
                        End If

                        'update its children
                        For Each TempNode As TreeNode In NewNode.Nodes
                            PasteManager.UpdateChildNode(TempNode, KeyMap)
                        Next
                    End If
                Next

            ElseIf e.Effect = DragDropEffects.Move Then

                General.MainExplorer.TreeView.BeginUpdate()
                General.SetWaitCursor()
                For Each SelectedObject As Objects.ObjectData In DragedItems
                    SelectedObject.ParentGUID = TargetFolder.ObjectGUID
                    SelectedObject.Save()

                    'move the tree nodes
                    Dim OldNode, NewNode, TargetNode As TreeNode
                    OldNode = CType(General.MainExplorer.TreeNodes(SelectedObject.ObjectGUID), TreeNode)
                    If Not OldNode Is Nothing Then
                        NewNode = CType(OldNode.Clone, TreeNode)
                        TargetNode = CType(General.MainExplorer.TreeNodes(TargetFolder.ObjectGUID), TreeNode)
                        If Not TargetNode Is Nothing Then
                            OldNode.Remove()
                            General.MainExplorer.InsertNode(TargetNode, NewNode)
                            General.MainExplorer.TreeNodes.Item(SelectedObject.ObjectGUID) = NewNode
                        End If
                    End If
                Next
            End If

            General.MainExplorer.TreeView.EndUpdate()
            General.SetNormalCursor()
            General.MainExplorer.RefreshPanel()
            TreeView.Refresh()
        End If
    End Sub

#End Region

#Region "Dock Event Handlers"

    'handles closing the treeview dock panel
    Private Sub FoldersDockPanel_ClosedPanel(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs) Handles FoldersDockPanel.ClosedPanel
        Try
            ToolbarsAndMenus.FolderButton.Down = False
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles closing the browser dock panel
    Private Sub BrowserDockPanel_ClosedPanel(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs) Handles BrowserDockPanel.ClosedPanel
        Try
            ToolbarsAndMenus.BrowserButton.Down = False
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

    'save the database
    Private Sub MainWindow_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            General.MainExplorer.SuspendBrowser = True
            Commands.ExitApplication(Me, Nothing)
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'update status of buttons
    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)

        'browser
        If Me.BrowserDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            ToolbarsAndMenus.BrowserButton.Down = True
        Else
            ToolbarsAndMenus.BrowserButton.Down = False
        End If

        'folders
        If Me.FoldersDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            ToolbarsAndMenus.FolderButton.Down = True
        Else
            ToolbarsAndMenus.FolderButton.Down = False
        End If

        'undo
        If UI.ReadOnly OrElse General.UndoSteps = 0 OrElse General.MainExplorer.Undo.UndoStepsCached = 0 Then
            ToolbarsAndMenus.UndoButton.Enabled = False
        Else
            ToolbarsAndMenus.UndoButton.Enabled = True
        End If

        'clipboard - paste
        If Not UI.ReadOnly AndAlso General.MainExplorer.Clipboard.ClipboardNotEmpty Then
            ToolbarsAndMenus.Button("ClearClipboard").Enabled = True
            Select Case General.MainExplorer.CurrentPanelType
                Case PanelType.Inventory, PanelType.AssetsPanel, PanelType.BasicListView
                    ToolbarsAndMenus.Button("Paste").Enabled = True
                Case Else
                    ToolbarsAndMenus.Button("Paste").Enabled = False
            End Select
        Else
            ToolbarsAndMenus.Button("ClearClipboard").Enabled = False
            ToolbarsAndMenus.Button("Paste").Enabled = False
        End If

        'clipboard - cut/copy
        If Not UI.ReadOnly AndAlso General.MainExplorer.SelectedObjectCount > 0 Then
            ToolbarsAndMenus.Button("Cut").Enabled = True
            ToolbarsAndMenus.Button("Copy").Enabled = True
        Else
            ToolbarsAndMenus.Button("Cut").Enabled = False
            ToolbarsAndMenus.Button("Copy").Enabled = False
        End If

        'folders
        If TreeView.SelectedNode IsNot Nothing AndAlso TreeView.SelectedNode.Parent IsNot Nothing Then
            ToolbarsAndMenus.Button("FolderUp").Enabled = True
        Else
            ToolbarsAndMenus.Button("FolderUp").Enabled = False
        End If
        If TreeView.SelectedNode IsNot Nothing AndAlso Not TreeView.SelectedNode.IsExpanded AndAlso TreeView.SelectedNode.Nodes.Count > 0 Then
            ToolbarsAndMenus.Button("FolderExpand").Enabled = True
        Else
            ToolbarsAndMenus.Button("FolderExpand").Enabled = False
        End If
        If TreeView.SelectedNode IsNot Nothing AndAlso TreeView.SelectedNode.IsExpanded AndAlso TreeView.SelectedNode.Nodes.Count > 0 Then
            ToolbarsAndMenus.Button("FolderCollapse").Enabled = True
        Else
            ToolbarsAndMenus.Button("FolderCollapse").Enabled = False
        End If

        'icons and details
        If General.MainExplorer.ListView IsNot Nothing Then
            ToolbarsAndMenus.Button("Icons").Enabled = True
            ToolbarsAndMenus.Button("Details").Enabled = True
        Else
            ToolbarsAndMenus.Button("Icons").Enabled = False
            ToolbarsAndMenus.Button("Details").Enabled = False
        End If

        'data input/double click edits
        ToolbarsAndMenus.DataInputButton.Down = General.DataInput
        ToolbarsAndMenus.DataInputButton.Enabled = Not UI.ReadOnly
        ToolbarsAndMenus.DoubleClickEditsButton.Down = General.DoubleClickEdits
        ToolbarsAndMenus.DoubleClickEditsButton.Enabled = Not UI.ReadOnly
        ToolbarsAndMenus.XMLWorkshopButton.Enabled = Not UI.ReadOnly

        'windows
        For Each Window As CentralDisplayForm In WindowManager.Windows
            DirectCast(Window.MyPanel, IPanel).ReadOnly = UI.ReadOnly
        Next
        Me.TreeView.AllowDrop = Not UI.ReadOnly

    End Sub

    'periodically save the database
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            XML.SaveXMLDB()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'trap keyboard input
    Private Sub MainWindow_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Try
            Select Case e.KeyCode.ToString()
                Case "Tab"
                    TabFocusFlag = True
                    'Case "Back"
                    '        Commands.FolderUp(Nothing, Nothing)
                    'hack related to shortcut keys/focus issue
                Case "Delete"
                    If General.MainExplorer.ListView Is Nothing Then Exit Sub

                    If General.MainExplorer.CurrentPanelType = PanelType.SpellList Then
                        Commands.RemoveSpell(Me, Nothing)
                    ElseIf General.MainExplorer.CurrentPanelType = PanelType.PowerList Then
                        Commands.RemovePowers(Me, Nothing)
                    Else
                        Commands.DeleteObjects(Me, Nothing)
                    End If

                Case "Enter"
                    If e.Shift Then
                        Commands.ShiftEnter()
                    End If
                Case "Oemplus", "Add"
                    Commands.Plus()
                Case "c", "C"
                    If e.Control Then
                        Commands.Copy(Nothing, Nothing)
                    End If
                Case "x", "X"
                    If e.Control Then
                        Commands.Cut(Nothing, Nothing)
                    End If
                Case "v", "V"
                    If e.Control Then
                        Commands.Paste(Nothing, Nothing)
                    End If
                Case "Apps"
                    ToolbarsAndMenus.BuildPopupMenu()
                    ToolbarsAndMenus.PopupMenu.ShowPopup(New Point(MousePosition.X, MousePosition.Y))
                Case "a", "A"
                    If e.Control Then
                        Commands.SelectAll(Nothing, Nothing)
                    End If
            End Select
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'command key
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Try
            If keyData.ToString = "Tab" Then
                TabFocusFlag = True
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Function

    'build component menu
    Private Sub BarManager_HighlightedLinkChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.HighlightedLinkChangedEventArgs) Handles BarManager.HighlightedLinkChanged
        Try
            If e.Link Is Nothing Then
                Exit Sub
            ElseIf e.Link.Item.Name = "Component" Then
                ToolbarsAndMenus.BuildComponentMenu()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'current window has changed
    Public Sub XtraTabbedMdiManager1_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XtraTabbedMdiManager1.SelectedPageChanged
        If IsLoading OrElse XtraTabbedMdiManager1.SelectedPage Is Nothing OrElse WindowManager.SuspendEvents OrElse MainExplorer.SuspendEvents Then Exit Sub

        Try
            MainExplorer.SuspendBrowser = True
            TreeView.SelectedNode = DirectCast(XtraTabbedMdiManager1.SelectedPage.MdiChild, CentralDisplayForm).TreeNode
            If MainExplorer.ListView IsNot Nothing Then MainExplorer.CurrentFocus = Explorer.Focus.ListView
            MainExplorer.SuspendBrowser = False
            MainExplorer.ShowHelpForSelected()

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'handles removing a tab from the interface
    Private Sub XtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        Try
            MainExplorer.SaveCurrentPanel()

            General.MainExplorer.SuspendEvents = True
            Dim CentralDisplayForm As CentralDisplayForm = CType(e.Page.MdiChild, CentralDisplayForm)
            WindowManager.RemoveWindow(CentralDisplayForm)

            'if all the pages have been removed
            If XtraTabbedMdiManager1.Pages.Count < 1 Then
                TreeView.Focus()
                TreeView.SelectedNode = Nothing
                General.MainExplorer.ShowHelp("Index.htm")
                General.MainExplorer.FilterManager.EnableDisable(Nothing)
            End If

            General.MainExplorer.SuspendEvents = False

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#Region "Tabbed MDI Context Menu"

    Private CurrentTab As XtraMdiTabPage

    Private Sub XtraTabbedMdiManager1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles XtraTabbedMdiManager1.MouseUp
        Dim info As BaseTabHitInfo = XtraTabbedMdiManager1.CalcHitInfo(e.Location)
        If e.Button <> MouseButtons.Right OrElse info.HitTest <> XtraTabHitTest.PageHeader Then Exit Sub
        CurrentTab = DirectCast(info.Page, XtraMdiTabPage)
        If DirectCast(CurrentTab.MdiChild, CentralDisplayForm).CharacterKey.IsNotEmpty Then
            Dim Name As String = CharacterManager.GetCharacter(DirectCast(CurrentTab.MdiChild, CentralDisplayForm).CharacterKey).CharacterObject.Name
            CloseAllMyTabs.Caption = "Close " & Name & "'s Tabs"
            CloseAllExceptNamesTabs.Caption = "Close All Except " & Name & "'s Tabs"
            CloseAllMyTabs.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            CloseAllMyTabs.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        TabsPopupMenu.ShowPopup(MousePosition)
    End Sub

    Private Sub CloseTab_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseTab.ItemClick
        CurrentTab.MdiChild.Close()
    End Sub

    Private Sub CloseAllButThis_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseAllButThis.ItemClick
        Dim TabsToClose As New ArrayList
        For Each Tab As XtraMdiTabPage In XtraTabbedMdiManager1.Pages
            If Tab IsNot CurrentTab Then TabsToClose.Add(Tab)
        Next
        For Each Tab As XtraMdiTabPage In TabsToClose
            Tab.MdiChild.Close()
        Next
    End Sub

    Private Sub CloseAllTabs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseAllTabs.ItemClick
        Dim TabsToClose As New ArrayList(XtraTabbedMdiManager1.Pages)
        For Each Tab As XtraMdiTabPage In TabsToClose
            Tab.MdiChild.Close()
        Next
        MainExplorer.SuspendEvents = True
        MainExplorer.TreeView.SelectedNode = Nothing
        MainExplorer.SuspendEvents = False
    End Sub

    Private Sub CloseAllFolders_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseAllFolders.ItemClick
        Dim TabsToClose As New ArrayList
        For Each Tab As XtraMdiTabPage In XtraTabbedMdiManager1.Pages
            Dim FolderObj As Objects.ObjectData = DirectCast(Tab.MdiChild, CentralDisplayForm).Folder
            If FolderObj.IsPrimaryFolderType OrElse (FolderObj.IsPrimaryType And Not FolderObj.Type = Objects.CharacterType) OrElse FolderObj.IsSecondaryFolderType OrElse FolderObj.Type = Objects.SystemFolderType Then TabsToClose.Add(Tab)
        Next
        For Each Tab As XtraMdiTabPage In TabsToClose
            Tab.MdiChild.Close()
        Next
    End Sub

    Private Sub CloseAllCreatureTabs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseAllCreatureTabs.ItemClick
        Dim TabsToClose As New ArrayList
        For Each Tab As XtraMdiTabPage In XtraTabbedMdiManager1.Pages
            If DirectCast(Tab.MdiChild, CentralDisplayForm).CharacterKey.IsNotEmpty Then TabsToClose.Add(Tab)
        Next
        For Each Tab As XtraMdiTabPage In TabsToClose
            Tab.MdiChild.Close()
        Next
    End Sub

    Private Sub CloseAllMyTabs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseAllMyTabs.ItemClick
        Dim TabsToClose As New ArrayList
        For Each Tab As XtraMdiTabPage In XtraTabbedMdiManager1.Pages
            If DirectCast(Tab.MdiChild, CentralDisplayForm).CharacterKey.Equals(CharacterManager.CurrentCharacterKey) Then TabsToClose.Add(Tab)
        Next
        For Each Tab As XtraMdiTabPage In TabsToClose
            Tab.MdiChild.Close()
        Next
    End Sub

    Private Sub CloseAllExceptNamesTabs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseAllExceptNamesTabs.ItemClick
        Dim TabsToClose As New ArrayList
        For Each Tab As XtraMdiTabPage In XtraTabbedMdiManager1.Pages
            If Not DirectCast(Tab.MdiChild, CentralDisplayForm).CharacterKey.Equals(CharacterManager.CurrentCharacterKey) Then TabsToClose.Add(Tab)
        Next
        For Each Tab As XtraMdiTabPage In TabsToClose
            Tab.MdiChild.Close()
        Next
    End Sub

#End Region

End Class