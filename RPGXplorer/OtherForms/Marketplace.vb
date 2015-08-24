Imports DevExpress.XtraBars
'Imports DevExpress.XtraNavBar

Public Class Marketplace
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
    Public WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents Splitter2 As System.Windows.Forms.Splitter
    Public WithEvents ArmorView As RPGXplorer.RPGXListView
    Public WithEvents WeaponView As RPGXplorer.RPGXListView
    Public WithEvents ItemView As RPGXplorer.RPGXListView
    Public WithEvents FilterBar As RPGXplorer.FilterBar
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Splitter3 As System.Windows.Forms.Splitter
    Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Public WithEvents BarManager As DevExpress.XtraBars.BarManager
    Public WithEvents Splitter4 As System.Windows.Forms.Splitter
    Public WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Public WithEvents MarketBrowserDockPanel As DevExpress.XtraBars.Docking.DockPanel
    Public WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents Icons As System.Windows.Forms.Button
    Public WithEvents Details As System.Windows.Forms.Button
    Public WithEvents ArmorShieldsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents WeaponsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents ItemsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents MagicArmorPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents MagicWeaponsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents PotionsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents PowerStonesPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents PsionicArmorPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents PsionicWeaponsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents PsionicArtifactsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents RingsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents RodsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents ScrollsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents StaffsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents TattoosPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents UniversalItemsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents WandsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents WondrousItemsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents ArtifactsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents DorjesPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents PsicrownsPage As DevExpress.XtraTab.XtraTabPage
    Public WithEvents ArtifactView As RPGXplorer.RPGXListView
    Public WithEvents DorjeView As RPGXplorer.RPGXListView
    Public WithEvents MagicArmorView As RPGXplorer.RPGXListView
    Public WithEvents MagicWeaponView As RPGXplorer.RPGXListView
    Public WithEvents PotionView As RPGXplorer.RPGXListView
    Public WithEvents PowerStoneView As RPGXplorer.RPGXListView
    Public WithEvents PsicrownView As RPGXplorer.RPGXListView
    Public WithEvents PsionicArtifactView As RPGXplorer.RPGXListView
    Public WithEvents PsionicWeaponView As RPGXplorer.RPGXListView
    Public WithEvents PsionicArmorView As RPGXplorer.RPGXListView
    Public WithEvents RingView As RPGXplorer.RPGXListView
    Public WithEvents RodView As RPGXplorer.RPGXListView
    Public WithEvents ScrollView As RPGXplorer.RPGXListView
    Public WithEvents StaffView As RPGXplorer.RPGXListView
    Public WithEvents TattooView As RPGXplorer.RPGXListView
    Public WithEvents UniversalView As RPGXplorer.RPGXListView
    Public WithEvents WandView As RPGXplorer.RPGXListView
    Public WithEvents WondrousView As RPGXplorer.RPGXListView
    Public WithEvents ShoppingCart As RPGXplorer.ShoppingCartPanel2
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marketplace))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.ArmorShieldsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ArmorView = New RPGXplorer.RPGXListView()
        Me.WeaponsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.WeaponView = New RPGXplorer.RPGXListView()
        Me.ItemsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ItemView = New RPGXplorer.RPGXListView()
        Me.ArtifactsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ArtifactView = New RPGXplorer.RPGXListView()
        Me.MagicArmorPage = New DevExpress.XtraTab.XtraTabPage()
        Me.MagicArmorView = New RPGXplorer.RPGXListView()
        Me.MagicWeaponsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.MagicWeaponView = New RPGXplorer.RPGXListView()
        Me.PotionsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PotionView = New RPGXplorer.RPGXListView()
        Me.RingsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.RingView = New RPGXplorer.RPGXListView()
        Me.RodsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.RodView = New RPGXplorer.RPGXListView()
        Me.ScrollsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ScrollView = New RPGXplorer.RPGXListView()
        Me.StaffsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.StaffView = New RPGXplorer.RPGXListView()
        Me.WandsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.WandView = New RPGXplorer.RPGXListView()
        Me.WondrousItemsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.WondrousView = New RPGXplorer.RPGXListView()
        Me.DorjesPage = New DevExpress.XtraTab.XtraTabPage()
        Me.DorjeView = New RPGXplorer.RPGXListView()
        Me.PowerStonesPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PowerStoneView = New RPGXplorer.RPGXListView()
        Me.PsicrownsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PsicrownView = New RPGXplorer.RPGXListView()
        Me.PsionicArmorPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PsionicArmorView = New RPGXplorer.RPGXListView()
        Me.PsionicArtifactsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PsionicArtifactView = New RPGXplorer.RPGXListView()
        Me.PsionicWeaponsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PsionicWeaponView = New RPGXplorer.RPGXListView()
        Me.TattoosPage = New DevExpress.XtraTab.XtraTabPage()
        Me.TattooView = New RPGXplorer.RPGXListView()
        Me.UniversalItemsPage = New DevExpress.XtraTab.XtraTabPage()
        Me.UniversalView = New RPGXplorer.RPGXListView()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.FilterBar = New RPGXplorer.FilterBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Details = New System.Windows.Forms.Button()
        Me.Icons = New System.Windows.Forms.Button()
        Me.Splitter3 = New System.Windows.Forms.Splitter()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Browser = New System.Windows.Forms.WebBrowser()
        Me.ShoppingCart = New RPGXplorer.ShoppingCartPanel2()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.MarketBrowserDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.Splitter4 = New System.Windows.Forms.Splitter()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.ArmorShieldsPage.SuspendLayout()
        Me.WeaponsPage.SuspendLayout()
        Me.ItemsPage.SuspendLayout()
        Me.ArtifactsPage.SuspendLayout()
        Me.MagicArmorPage.SuspendLayout()
        Me.MagicWeaponsPage.SuspendLayout()
        Me.PotionsPage.SuspendLayout()
        Me.RingsPage.SuspendLayout()
        Me.RodsPage.SuspendLayout()
        Me.ScrollsPage.SuspendLayout()
        Me.StaffsPage.SuspendLayout()
        Me.WandsPage.SuspendLayout()
        Me.WondrousItemsPage.SuspendLayout()
        Me.DorjesPage.SuspendLayout()
        Me.PowerStonesPage.SuspendLayout()
        Me.PsicrownsPage.SuspendLayout()
        Me.PsionicArmorPage.SuspendLayout()
        Me.PsionicArtifactsPage.SuspendLayout()
        Me.PsionicWeaponsPage.SuspendLayout()
        Me.TattoosPage.SuspendLayout()
        Me.UniversalItemsPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MarketBrowserDockPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.Location = New System.Drawing.Point(5, 35)
        Me.XtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.ArmorShieldsPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(707, 386)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.ArmorShieldsPage, Me.WeaponsPage, Me.ItemsPage, Me.ArtifactsPage, Me.MagicArmorPage, Me.MagicWeaponsPage, Me.PotionsPage, Me.RingsPage, Me.RodsPage, Me.ScrollsPage, Me.StaffsPage, Me.WandsPage, Me.WondrousItemsPage, Me.DorjesPage, Me.PowerStonesPage, Me.PsicrownsPage, Me.PsionicArmorPage, Me.PsionicArtifactsPage, Me.PsionicWeaponsPage, Me.TattoosPage, Me.UniversalItemsPage})
        '
        'ArmorShieldsPage
        '
        Me.ArmorShieldsPage.Appearance.Header.Options.UseTextOptions = True
        Me.ArmorShieldsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ArmorShieldsPage.Controls.Add(Me.ArmorView)
        Me.ArmorShieldsPage.Name = "ArmorShieldsPage"
        Me.ArmorShieldsPage.Size = New System.Drawing.Size(700, 313)
        Me.ArmorShieldsPage.Text = "Armor and Shields"
        '
        'ArmorView
        '
        Me.ArmorView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArmorView.Location = New System.Drawing.Point(0, 0)
        Me.ArmorView.Name = "ArmorView"
        Me.ArmorView.Size = New System.Drawing.Size(700, 313)
        Me.ArmorView.TabIndex = 0
        '
        'WeaponsPage
        '
        Me.WeaponsPage.Appearance.Header.Options.UseTextOptions = True
        Me.WeaponsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WeaponsPage.Controls.Add(Me.WeaponView)
        Me.WeaponsPage.Name = "WeaponsPage"
        Me.WeaponsPage.Size = New System.Drawing.Size(700, 313)
        Me.WeaponsPage.Text = "Weapons"
        '
        'WeaponView
        '
        Me.WeaponView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WeaponView.Location = New System.Drawing.Point(0, 0)
        Me.WeaponView.Name = "WeaponView"
        Me.WeaponView.Size = New System.Drawing.Size(700, 313)
        Me.WeaponView.TabIndex = 1
        '
        'ItemsPage
        '
        Me.ItemsPage.Appearance.Header.Options.UseTextOptions = True
        Me.ItemsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ItemsPage.Controls.Add(Me.ItemView)
        Me.ItemsPage.Name = "ItemsPage"
        Me.ItemsPage.Size = New System.Drawing.Size(700, 313)
        Me.ItemsPage.Text = "Items"
        '
        'ItemView
        '
        Me.ItemView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemView.Location = New System.Drawing.Point(0, 0)
        Me.ItemView.Name = "ItemView"
        Me.ItemView.Size = New System.Drawing.Size(700, 313)
        Me.ItemView.TabIndex = 1
        '
        'ArtifactsPage
        '
        Me.ArtifactsPage.Controls.Add(Me.ArtifactView)
        Me.ArtifactsPage.Name = "ArtifactsPage"
        Me.ArtifactsPage.Size = New System.Drawing.Size(700, 313)
        Me.ArtifactsPage.Text = "Artifacts"
        '
        'ArtifactView
        '
        Me.ArtifactView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArtifactView.Location = New System.Drawing.Point(0, 0)
        Me.ArtifactView.Name = "ArtifactView"
        Me.ArtifactView.Size = New System.Drawing.Size(700, 313)
        Me.ArtifactView.TabIndex = 0
        '
        'MagicArmorPage
        '
        Me.MagicArmorPage.Appearance.Header.Options.UseTextOptions = True
        Me.MagicArmorPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MagicArmorPage.Controls.Add(Me.MagicArmorView)
        Me.MagicArmorPage.Name = "MagicArmorPage"
        Me.MagicArmorPage.Size = New System.Drawing.Size(700, 313)
        Me.MagicArmorPage.Text = "Magic Armor"
        '
        'MagicArmorView
        '
        Me.MagicArmorView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MagicArmorView.Location = New System.Drawing.Point(0, 0)
        Me.MagicArmorView.Name = "MagicArmorView"
        Me.MagicArmorView.Size = New System.Drawing.Size(700, 313)
        Me.MagicArmorView.TabIndex = 0
        '
        'MagicWeaponsPage
        '
        Me.MagicWeaponsPage.Appearance.Header.Options.UseTextOptions = True
        Me.MagicWeaponsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MagicWeaponsPage.Controls.Add(Me.MagicWeaponView)
        Me.MagicWeaponsPage.Name = "MagicWeaponsPage"
        Me.MagicWeaponsPage.Size = New System.Drawing.Size(700, 313)
        Me.MagicWeaponsPage.Text = "Magic Weapons"
        '
        'MagicWeaponView
        '
        Me.MagicWeaponView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MagicWeaponView.Location = New System.Drawing.Point(0, 0)
        Me.MagicWeaponView.Name = "MagicWeaponView"
        Me.MagicWeaponView.Size = New System.Drawing.Size(700, 313)
        Me.MagicWeaponView.TabIndex = 0
        '
        'PotionsPage
        '
        Me.PotionsPage.Appearance.Header.Options.UseTextOptions = True
        Me.PotionsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PotionsPage.Controls.Add(Me.PotionView)
        Me.PotionsPage.Name = "PotionsPage"
        Me.PotionsPage.Size = New System.Drawing.Size(700, 313)
        Me.PotionsPage.Text = "Potions"
        '
        'PotionView
        '
        Me.PotionView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PotionView.Location = New System.Drawing.Point(0, 0)
        Me.PotionView.Name = "PotionView"
        Me.PotionView.Size = New System.Drawing.Size(700, 313)
        Me.PotionView.TabIndex = 0
        '
        'RingsPage
        '
        Me.RingsPage.Appearance.Header.Options.UseTextOptions = True
        Me.RingsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RingsPage.Controls.Add(Me.RingView)
        Me.RingsPage.Name = "RingsPage"
        Me.RingsPage.Size = New System.Drawing.Size(700, 313)
        Me.RingsPage.Text = "Rings"
        '
        'RingView
        '
        Me.RingView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RingView.Location = New System.Drawing.Point(0, 0)
        Me.RingView.Name = "RingView"
        Me.RingView.Size = New System.Drawing.Size(700, 313)
        Me.RingView.TabIndex = 0
        '
        'RodsPage
        '
        Me.RodsPage.Appearance.Header.Options.UseTextOptions = True
        Me.RodsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RodsPage.Controls.Add(Me.RodView)
        Me.RodsPage.Name = "RodsPage"
        Me.RodsPage.Size = New System.Drawing.Size(700, 313)
        Me.RodsPage.Text = "Rods"
        '
        'RodView
        '
        Me.RodView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RodView.Location = New System.Drawing.Point(0, 0)
        Me.RodView.Name = "RodView"
        Me.RodView.Size = New System.Drawing.Size(700, 313)
        Me.RodView.TabIndex = 0
        '
        'ScrollsPage
        '
        Me.ScrollsPage.Appearance.Header.Options.UseTextOptions = True
        Me.ScrollsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ScrollsPage.Controls.Add(Me.ScrollView)
        Me.ScrollsPage.Name = "ScrollsPage"
        Me.ScrollsPage.Size = New System.Drawing.Size(700, 313)
        Me.ScrollsPage.Text = "Scrolls"
        '
        'ScrollView
        '
        Me.ScrollView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScrollView.Location = New System.Drawing.Point(0, 0)
        Me.ScrollView.Name = "ScrollView"
        Me.ScrollView.Size = New System.Drawing.Size(700, 313)
        Me.ScrollView.TabIndex = 0
        '
        'StaffsPage
        '
        Me.StaffsPage.Appearance.Header.Options.UseTextOptions = True
        Me.StaffsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StaffsPage.Controls.Add(Me.StaffView)
        Me.StaffsPage.Name = "StaffsPage"
        Me.StaffsPage.Size = New System.Drawing.Size(700, 313)
        Me.StaffsPage.Text = "Staffs"
        '
        'StaffView
        '
        Me.StaffView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffView.Location = New System.Drawing.Point(0, 0)
        Me.StaffView.Name = "StaffView"
        Me.StaffView.Size = New System.Drawing.Size(700, 313)
        Me.StaffView.TabIndex = 0
        '
        'WandsPage
        '
        Me.WandsPage.Appearance.Header.Options.UseTextOptions = True
        Me.WandsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WandsPage.Controls.Add(Me.WandView)
        Me.WandsPage.Name = "WandsPage"
        Me.WandsPage.Size = New System.Drawing.Size(700, 313)
        Me.WandsPage.Text = "Wands"
        '
        'WandView
        '
        Me.WandView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WandView.Location = New System.Drawing.Point(0, 0)
        Me.WandView.Name = "WandView"
        Me.WandView.Size = New System.Drawing.Size(700, 313)
        Me.WandView.TabIndex = 0
        '
        'WondrousItemsPage
        '
        Me.WondrousItemsPage.Appearance.Header.Options.UseTextOptions = True
        Me.WondrousItemsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WondrousItemsPage.Controls.Add(Me.WondrousView)
        Me.WondrousItemsPage.Name = "WondrousItemsPage"
        Me.WondrousItemsPage.Size = New System.Drawing.Size(700, 313)
        Me.WondrousItemsPage.Text = "Wondrous Items"
        '
        'WondrousView
        '
        Me.WondrousView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WondrousView.Location = New System.Drawing.Point(0, 0)
        Me.WondrousView.Name = "WondrousView"
        Me.WondrousView.Size = New System.Drawing.Size(700, 313)
        Me.WondrousView.TabIndex = 0
        '
        'DorjesPage
        '
        Me.DorjesPage.Controls.Add(Me.DorjeView)
        Me.DorjesPage.Name = "DorjesPage"
        Me.DorjesPage.Size = New System.Drawing.Size(700, 313)
        Me.DorjesPage.Text = "Dorjes"
        '
        'DorjeView
        '
        Me.DorjeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DorjeView.Location = New System.Drawing.Point(0, 0)
        Me.DorjeView.Name = "DorjeView"
        Me.DorjeView.Size = New System.Drawing.Size(700, 313)
        Me.DorjeView.TabIndex = 0
        '
        'PowerStonesPage
        '
        Me.PowerStonesPage.Appearance.Header.Options.UseTextOptions = True
        Me.PowerStonesPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PowerStonesPage.Controls.Add(Me.PowerStoneView)
        Me.PowerStonesPage.Name = "PowerStonesPage"
        Me.PowerStonesPage.Size = New System.Drawing.Size(700, 313)
        Me.PowerStonesPage.Text = "Power Stones"
        '
        'PowerStoneView
        '
        Me.PowerStoneView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PowerStoneView.Location = New System.Drawing.Point(0, 0)
        Me.PowerStoneView.Name = "PowerStoneView"
        Me.PowerStoneView.Size = New System.Drawing.Size(700, 313)
        Me.PowerStoneView.TabIndex = 0
        '
        'PsicrownsPage
        '
        Me.PsicrownsPage.Appearance.Header.Options.UseTextOptions = True
        Me.PsicrownsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PsicrownsPage.Controls.Add(Me.PsicrownView)
        Me.PsicrownsPage.Name = "PsicrownsPage"
        Me.PsicrownsPage.Size = New System.Drawing.Size(700, 313)
        Me.PsicrownsPage.Text = "Psicrowns"
        '
        'PsicrownView
        '
        Me.PsicrownView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PsicrownView.Location = New System.Drawing.Point(0, 0)
        Me.PsicrownView.Name = "PsicrownView"
        Me.PsicrownView.Size = New System.Drawing.Size(700, 313)
        Me.PsicrownView.TabIndex = 0
        '
        'PsionicArmorPage
        '
        Me.PsionicArmorPage.Appearance.Header.Options.UseTextOptions = True
        Me.PsionicArmorPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PsionicArmorPage.Controls.Add(Me.PsionicArmorView)
        Me.PsionicArmorPage.Name = "PsionicArmorPage"
        Me.PsionicArmorPage.Size = New System.Drawing.Size(700, 313)
        Me.PsionicArmorPage.Text = "Psionic Armor"
        '
        'PsionicArmorView
        '
        Me.PsionicArmorView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PsionicArmorView.Location = New System.Drawing.Point(0, 0)
        Me.PsionicArmorView.Name = "PsionicArmorView"
        Me.PsionicArmorView.Size = New System.Drawing.Size(700, 313)
        Me.PsionicArmorView.TabIndex = 0
        '
        'PsionicArtifactsPage
        '
        Me.PsionicArtifactsPage.Appearance.Header.Options.UseTextOptions = True
        Me.PsionicArtifactsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PsionicArtifactsPage.Controls.Add(Me.PsionicArtifactView)
        Me.PsionicArtifactsPage.Name = "PsionicArtifactsPage"
        Me.PsionicArtifactsPage.Size = New System.Drawing.Size(700, 313)
        Me.PsionicArtifactsPage.Text = "Psionic Artifacts"
        '
        'PsionicArtifactView
        '
        Me.PsionicArtifactView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PsionicArtifactView.Location = New System.Drawing.Point(0, 0)
        Me.PsionicArtifactView.Name = "PsionicArtifactView"
        Me.PsionicArtifactView.Size = New System.Drawing.Size(700, 313)
        Me.PsionicArtifactView.TabIndex = 0
        '
        'PsionicWeaponsPage
        '
        Me.PsionicWeaponsPage.Appearance.Header.Options.UseTextOptions = True
        Me.PsionicWeaponsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PsionicWeaponsPage.Controls.Add(Me.PsionicWeaponView)
        Me.PsionicWeaponsPage.Name = "PsionicWeaponsPage"
        Me.PsionicWeaponsPage.Size = New System.Drawing.Size(700, 313)
        Me.PsionicWeaponsPage.Text = "Psionic Weapons"
        '
        'PsionicWeaponView
        '
        Me.PsionicWeaponView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PsionicWeaponView.Location = New System.Drawing.Point(0, 0)
        Me.PsionicWeaponView.Name = "PsionicWeaponView"
        Me.PsionicWeaponView.Size = New System.Drawing.Size(700, 313)
        Me.PsionicWeaponView.TabIndex = 0
        '
        'TattoosPage
        '
        Me.TattoosPage.Appearance.Header.Options.UseTextOptions = True
        Me.TattoosPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TattoosPage.Controls.Add(Me.TattooView)
        Me.TattoosPage.Name = "TattoosPage"
        Me.TattoosPage.Size = New System.Drawing.Size(700, 313)
        Me.TattoosPage.Text = "Tattoos"
        '
        'TattooView
        '
        Me.TattooView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TattooView.Location = New System.Drawing.Point(0, 0)
        Me.TattooView.Name = "TattooView"
        Me.TattooView.Size = New System.Drawing.Size(700, 313)
        Me.TattooView.TabIndex = 0
        '
        'UniversalItemsPage
        '
        Me.UniversalItemsPage.Appearance.Header.Options.UseTextOptions = True
        Me.UniversalItemsPage.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.UniversalItemsPage.Controls.Add(Me.UniversalView)
        Me.UniversalItemsPage.Name = "UniversalItemsPage"
        Me.UniversalItemsPage.Size = New System.Drawing.Size(700, 313)
        Me.UniversalItemsPage.Text = "Universal Items"
        '
        'UniversalView
        '
        Me.UniversalView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UniversalView.Location = New System.Drawing.Point(0, 0)
        Me.UniversalView.Name = "UniversalView"
        Me.UniversalView.Size = New System.Drawing.Size(700, 313)
        Me.UniversalView.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(712, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(5, 686)
        Me.Splitter2.TabIndex = 5
        Me.Splitter2.TabStop = False
        '
        'FilterBar
        '
        Me.FilterBar.BaseObjects = Nothing
        Me.FilterBar.Location = New System.Drawing.Point(5, 5)
        Me.FilterBar.Name = "FilterBar"
        Me.FilterBar.Size = New System.Drawing.Size(535, 25)
        Me.FilterBar.TabIndex = 139
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Details)
        Me.Panel1.Controls.Add(Me.Icons)
        Me.Panel1.Controls.Add(Me.FilterBar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 35)
        Me.Panel1.TabIndex = 142
        '
        'Details
        '
        Me.Details.Image = CType(resources.GetObject("Details.Image"), System.Drawing.Image)
        Me.Details.Location = New System.Drawing.Point(580, 5)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(25, 24)
        Me.Details.TabIndex = 143
        '
        'Icons
        '
        Me.Icons.Image = CType(resources.GetObject("Icons.Image"), System.Drawing.Image)
        Me.Icons.Location = New System.Drawing.Point(550, 5)
        Me.Icons.Name = "Icons"
        Me.Icons.Size = New System.Drawing.Size(25, 24)
        Me.Icons.TabIndex = 142
        '
        'Splitter3
        '
        Me.Splitter3.Enabled = False
        Me.Splitter3.Location = New System.Drawing.Point(0, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(5, 686)
        Me.Splitter3.TabIndex = 143
        Me.Splitter3.TabStop = False
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Browser)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(194, 658)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Browser
        '
        Me.Browser.CausesValidation = False
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(0, 0)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(194, 658)
        Me.Browser.TabIndex = 145
        Me.Browser.TabStop = False
        '
        'ShoppingCart
        '
        Me.ShoppingCart.Cart = Nothing
        Me.ShoppingCart.CurrentCharacterKey = CType(resources.GetObject("ShoppingCart.CurrentCharacterKey"), RPGXplorer.Objects.ObjectKey)
        Me.ShoppingCart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ShoppingCart.Location = New System.Drawing.Point(5, 426)
        Me.ShoppingCart.Name = "ShoppingCart"
        Me.ShoppingCart.Padding = New System.Windows.Forms.Padding(1)
        Me.ShoppingCart.Size = New System.Drawing.Size(707, 260)
        Me.ShoppingCart.TabIndex = 146
        '
        'PopupMenu
        '
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'BarManager
        '
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager1
        Me.BarManager.Form = Me
        Me.BarManager.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(917, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 686)
        Me.barDockControlBottom.Size = New System.Drawing.Size(917, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 686)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(917, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 686)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.MarketBrowserDockPanel})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
        '
        'MarketBrowserDockPanel
        '
        Me.MarketBrowserDockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.MarketBrowserDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.MarketBrowserDockPanel.ID = New System.Guid("b9795f89-48f0-49f3-a2ff-6662e062a112")
        Me.MarketBrowserDockPanel.Location = New System.Drawing.Point(717, 0)
        Me.MarketBrowserDockPanel.Name = "MarketBrowserDockPanel"
        Me.MarketBrowserDockPanel.Options.AllowDockBottom = False
        Me.MarketBrowserDockPanel.Options.AllowDockFill = False
        Me.MarketBrowserDockPanel.Options.AllowDockTop = False
        Me.MarketBrowserDockPanel.Options.FloatOnDblClick = False
        Me.MarketBrowserDockPanel.Options.ShowCloseButton = False
        Me.MarketBrowserDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
        Me.MarketBrowserDockPanel.Size = New System.Drawing.Size(200, 686)
        Me.MarketBrowserDockPanel.Text = "Browser"
        '
        'Splitter4
        '
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter4.Location = New System.Drawing.Point(5, 421)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(707, 5)
        Me.Splitter4.TabIndex = 144
        Me.Splitter4.TabStop = False
        '
        'Marketplace
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(917, 686)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Splitter4)
        Me.Controls.Add(Me.ShoppingCart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Splitter3)
        Me.Controls.Add(Me.MarketBrowserDockPanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(925, 720)
        Me.Name = "Marketplace"
        Me.Text = "Marketplace"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ArmorShieldsPage.ResumeLayout(False)
        Me.WeaponsPage.ResumeLayout(False)
        Me.ItemsPage.ResumeLayout(False)
        Me.ArtifactsPage.ResumeLayout(False)
        Me.MagicArmorPage.ResumeLayout(False)
        Me.MagicWeaponsPage.ResumeLayout(False)
        Me.PotionsPage.ResumeLayout(False)
        Me.RingsPage.ResumeLayout(False)
        Me.RodsPage.ResumeLayout(False)
        Me.ScrollsPage.ResumeLayout(False)
        Me.StaffsPage.ResumeLayout(False)
        Me.WandsPage.ResumeLayout(False)
        Me.WondrousItemsPage.ResumeLayout(False)
        Me.DorjesPage.ResumeLayout(False)
        Me.PowerStonesPage.ResumeLayout(False)
        Me.PsicrownsPage.ResumeLayout(False)
        Me.PsionicArmorPage.ResumeLayout(False)
        Me.PsionicArtifactsPage.ResumeLayout(False)
        Me.PsionicWeaponsPage.ResumeLayout(False)
        Me.TattoosPage.ResumeLayout(False)
        Me.UniversalItemsPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MarketBrowserDockPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private BaseWeaponsAmmo As Objects.ObjectDataCollection
    Private ArmorFolder, ArtifactFolder, DorjeFolder, ItemFolder, MagicArmorFolder, MagicWeaponFolder, PotionFolder, PowerStoneFolder, PsicrownFolder, PsionicArmorFolder, PsionicArtifactFolder, PsionicWeaponFolder, RingFolder, RodFolder, ScrollFolder, StaffFolder, TattooFolder, UniversalItemFolder, WandFolder, WeaponFolder, WondrousFolder As Objects.ObjectData
    Private BaseArmor, BaseArtifacts, BaseDorjes, BaseItems, BaseMagicArmor, BaseMagicWeapons, BasePotions, BasePowerStones, BasePsicrowns, BasePsionicArmor, BasePsionicArtifacts, BasePsionicWeapons, BaseRings, BaseRods, BaseScrolls, BaseStaffs, BaseTattoos, BaseUniversalItems, BaseWands, BaseWeapons, BaseWondrousItems As Objects.ObjectDataCollection
    Private TabChanging As Boolean

#End Region

#Region "Properties"

    Public ReadOnly Property CurrentlySelectedObjects() As Objects.ObjectDataCollection
        Get
            Dim SelectedObjects As New Objects.ObjectDataCollection
            If CurrentView() Is Nothing Then Return SelectedObjects

            If CurrentView.ListView.SelectedItems.Count = 0 Then
                Return SelectedObjects
            Else
                Dim Obj As New Objects.ObjectData

                For Each Item As ListViewItem In CurrentView.ListView.SelectedItems
                    If TypeOf Item.Tag Is RPGXplorer.Objects.ObjectKey Then
                        Obj.Load(CType(Item.Tag, Objects.ObjectKey))
                        SelectedObjects.Add(Obj)
                    ElseIf TypeOf Item.Tag Is Objects.ObjectData Then
                        Obj = CType(Item.Tag, Objects.ObjectData)
                        SelectedObjects.Add(Obj)
                    End If
                Next
            End If

            Return SelectedObjects

        End Get
    End Property

#End Region

    'init the marketplace
    Public Sub Init()
        Try
            'init the folders
            ArmorFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ArmorDefinitionFolderType & "']")
            ArtifactFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ArtifactDefinitionFolderType & "']")
            DorjeFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicDorjeDefinitionsFolderType & "']")
            ItemFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ItemDefinitionFolderType & "']")
            MagicArmorFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificArmorDefinitionFolderType & "']")
            MagicWeaponFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificWeaponDefinitionFolderType & "']")
            PotionFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PotionDefinitionFolderType & "']")
            PowerStoneFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicPowerStoneDefinitionsFolderType & "']")
            PsicrownFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicPsicrownDefinitionFolderType & "']")
            PsionicArmorFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorDefinitionsFolderType & "']")
            PsionicArtifactFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArtifactDefinitionsFolderType & "']")
            PsionicWeaponFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponDefinitionsFolderType & "']")
            RingFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.RingDefinitionFolderType & "']")
            RodFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.RodDefinitionFolderType & "']")
            ScrollFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ScrollDefinitionFolderType & "']")
            StaffFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.StaffDefinitionFolderType & "']")
            TattooFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicTattooDefinitionsFolderType & "']")
            UniversalItemFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.UniversalItemDefinitionFolderType & "']")
            WandFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WandDefinitionFolderType & "']")
            WeaponFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionFolderType & "']")
            WondrousFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WondrousDefinitionFolderType & "']")

            'init the armor list view
            ArmorView.Init(Objects.ObjectKey.NewGuid(1), Objects.ArmorDefinitionFolderType, General.SortType.Alphabetic)
            ArmorView.ListView.SmallImageList = Images.SmallImages
            ArmorView.ListView.LargeImageList = Images.LargeImages
            BaseArmor = Objects.GetObjectsByXPath(XML.DBTypes.ArmorAndShields, "/RPGXplorerDatabase/RPGXplorerObject[(Type='" & Objects.ArmorDefinitionType & "' or Type='" & Objects.ShieldDefinitionType & "') and BaseItem!='Yes']")

            'init the artifact view
            ArtifactView.Init(Objects.ObjectKey.NewGuid(1), Objects.ArtifactDefinitionFolderType, General.SortType.Alphabetic)
            ArtifactView.ListView.SmallImageList = Images.SmallImages
            ArtifactView.ListView.LargeImageList = Images.LargeImages
            BaseArtifacts = Objects.GetAllObjectsOfType(Xml.DBTypes.Artifacts, Objects.ArtifactDefinitionType)

            'init the dorje list view
            DorjeView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicDorjeDefinitionsFolderType, General.SortType.Alphabetic)
            DorjeView.ListView.SmallImageList = Images.SmallImages
            DorjeView.ListView.LargeImageList = Images.LargeImages
            BaseDorjes = Objects.GetAllObjectsOfType(XML.DBTypes.Wands, Objects.PsionicDorjeDefinitionType)

            'init the item list view
            ItemView.Init(Objects.ObjectKey.NewGuid(1), Objects.ItemDefinitionFolderType, General.SortType.Alphabetic)
            ItemView.ListView.SmallImageList = Images.SmallImages
            ItemView.ListView.LargeImageList = Images.LargeImages
            BaseItems = Objects.GetAllObjectsOfType(XML.DBTypes.Items, Objects.ItemDefinitionType)

            'init the magic armor list view
            MagicArmorView.Init(Objects.ObjectKey.NewGuid(1), Objects.SpecificArmorDefinitionFolderType, General.SortType.Alphabetic)
            MagicArmorView.ListView.SmallImageList = Images.SmallImages
            MagicArmorView.ListView.LargeImageList = Images.LargeImages
            BaseMagicArmor = Objects.GetAllObjectsOfType(Xml.DBTypes.MagicArmor, Objects.SpecificArmorDefinitionType)

            'init the magic weapon list view
            MagicWeaponView.Init(Objects.ObjectKey.NewGuid(1), Objects.SpecificWeaponDefinitionFolderType, General.SortType.Alphabetic)
            MagicWeaponView.ListView.SmallImageList = Images.SmallImages
            MagicWeaponView.ListView.LargeImageList = Images.LargeImages
            BaseMagicWeapons = Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.SpecificWeaponDefinitionType)
            BaseMagicWeapons.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.MagicWeapons, Objects.MagicAmmoDefinitionType))


            'init the potion list view
            PotionView.Init(Objects.ObjectKey.NewGuid(1), Objects.PotionDefinitionFolderType, General.SortType.Alphabetic)
            PotionView.ListView.SmallImageList = Images.SmallImages
            PotionView.ListView.LargeImageList = Images.LargeImages
            BasePotions = Objects.GetAllObjectsOfType(Xml.DBTypes.PotionsAndOils, Objects.PotionDefinitionType)

            'init the power stone list view
            PowerStoneView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicPowerStoneDefinitionsFolderType, General.SortType.Alphabetic)
            PowerStoneView.ListView.SmallImageList = Images.SmallImages
            PowerStoneView.ListView.LargeImageList = Images.LargeImages
            BasePowerStones = Objects.GetAllObjectsOfType(Xml.DBTypes.Scrolls, Objects.PsionicPowerStoneDefinitionType)

            'init the psicrown list view
            PsicrownView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicPsicrownDefinitionFolderType, General.SortType.Alphabetic)
            PsicrownView.ListView.SmallImageList = Images.SmallImages
            PsicrownView.ListView.LargeImageList = Images.LargeImages
            BasePsicrowns = Objects.GetAllObjectsOfType(Xml.DBTypes.Staffs, Objects.PsionicPsicrownDefinitionType)

            'init the psionic armor view
            PsionicArmorView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicArmorDefinitionsFolderType, General.SortType.Alphabetic)
            PsionicArmorView.ListView.SmallImageList = Images.SmallImages
            PsionicArmorView.ListView.LargeImageList = Images.LargeImages
            BasePsionicArmor = Objects.GetAllObjectsOfType(Xml.DBTypes.MagicArmor, Objects.PsionicArmorDefinitionType)

            'init the psionic artifact view
            PsionicArtifactView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicArtifactDefinitionsFolderType, General.SortType.Alphabetic)
            PsionicArtifactView.ListView.SmallImageList = Images.SmallImages
            PsionicArtifactView.ListView.LargeImageList = Images.LargeImages
            BasePsionicArtifacts = Objects.GetAllObjectsOfType(Xml.DBTypes.Artifacts, Objects.PsionicArtifactDefinitionType)

            'init the psionic weapon view
            PsionicWeaponView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicWeaponDefinitionsFolderType, General.SortType.Alphabetic)
            PsionicWeaponView.ListView.SmallImageList = Images.SmallImages
            PsionicWeaponView.ListView.LargeImageList = Images.LargeImages
            BasePsionicWeapons = Objects.GetAllObjectsOfType(XML.DBTypes.MagicWeapons, Objects.PsionicWeaponDefinitionType)
            BasePsionicWeapons.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.MagicWeapons, Objects.PsionicAmmoDefinitionType))

            'init the ring view
            RingView.Init(Objects.ObjectKey.NewGuid(1), Objects.RingDefinitionFolderType, General.SortType.Alphabetic)
            RingView.ListView.SmallImageList = Images.SmallImages
            RingView.ListView.LargeImageList = Images.LargeImages
            BaseRings = Objects.GetAllObjectsOfType(Xml.DBTypes.Rings, Objects.RingDefinitionType)

            'init the rod view
            RodView.Init(Objects.ObjectKey.NewGuid(1), Objects.RodDefinitionFolderType, General.SortType.Alphabetic)
            RodView.ListView.SmallImageList = Images.SmallImages
            RodView.ListView.LargeImageList = Images.LargeImages
            BaseRods = Objects.GetAllObjectsOfType(Xml.DBTypes.Rods, Objects.RodDefinitionType)

            'init the scroll view
            ScrollView.Init(Objects.ObjectKey.NewGuid(1), Objects.ScrollDefinitionFolderType, General.SortType.Alphabetic)
            ScrollView.ListView.SmallImageList = Images.SmallImages
            ScrollView.ListView.LargeImageList = Images.LargeImages
            BaseScrolls = Objects.GetAllObjectsOfType(Xml.DBTypes.Scrolls, Objects.ScrollDefinitionType)

            'init the staff view
            StaffView.Init(Objects.ObjectKey.NewGuid(1), Objects.StaffDefinitionFolderType, General.SortType.Alphabetic)
            StaffView.ListView.SmallImageList = Images.SmallImages
            StaffView.ListView.LargeImageList = Images.LargeImages
            BaseStaffs = Objects.GetAllObjectsOfType(Xml.DBTypes.Staffs, Objects.StaffDefinitionType)

            'init the tattoo view
            TattooView.Init(Objects.ObjectKey.NewGuid(1), Objects.PsionicTattooDefinitionsFolderType, General.SortType.Alphabetic)
            TattooView.ListView.SmallImageList = Images.SmallImages
            TattooView.ListView.LargeImageList = Images.LargeImages
            BaseTattoos = Objects.GetAllObjectsOfType(Xml.DBTypes.PotionsAndOils, Objects.PsionicTattooDefinitionType)

            'init the universal view
            UniversalView.Init(Objects.ObjectKey.NewGuid(1), Objects.UniversalItemDefinitionFolderType, General.SortType.Alphabetic)
            UniversalView.ListView.SmallImageList = Images.SmallImages
            UniversalView.ListView.LargeImageList = Images.LargeImages
            BaseUniversalItems = Objects.GetAllObjectsOfType(Xml.DBTypes.WondrousItems, Objects.UniversalItemDefinitionType)

            'init the wand view
            WandView.Init(Objects.ObjectKey.NewGuid(1), Objects.WandDefinitionFolderType, General.SortType.Alphabetic)
            WandView.ListView.SmallImageList = Images.SmallImages
            WandView.ListView.LargeImageList = Images.LargeImages
            BaseWands = Objects.GetAllObjectsOfType(Xml.DBTypes.Wands, Objects.WandDefinitionType)

            'init the weapon list view
            WeaponView.Init(Objects.ObjectKey.NewGuid(1), Objects.WeaponDefinitionFolderType, General.SortType.Alphabetic)
            WeaponView.ListView.SmallImageList = Images.SmallImages
            WeaponView.ListView.LargeImageList = Images.LargeImages

            BaseWeaponsAmmo = Objects.GetAllObjectsOfType(Xml.DBTypes.Weapons, Objects.WeaponDefinitionType)
            BaseWeaponsAmmo.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.Weapons, Objects.AmmoDefinitionType))

            'init the wondrous view
            WondrousView.Init(Objects.ObjectKey.NewGuid(1), Objects.WondrousDefinitionFolderType, General.SortType.Alphabetic)
            WondrousView.ListView.SmallImageList = Images.SmallImages
            WondrousView.ListView.LargeImageList = Images.LargeImages
            BaseWondrousItems = Objects.GetAllObjectsOfType(Xml.DBTypes.WondrousItems, Objects.WondrousDefinitionType)

            'init the shopping cart panel
            ShoppingCart.Init()

            'init the filterbar
            FilterBar.Init(ArmorFolder, BaseArmor)

            'init the first listview
            ArmorView.AddRange(FilterBar.FilteredObjects)
            ArmorView.ListView.Refresh()

            'add event handlers for the listviews
            AddHandler ArmorView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler ArtifactView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler DorjeView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler ItemView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler MagicArmorView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler MagicWeaponView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler PotionView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler PowerStoneView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler PsicrownView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler PsionicArmorView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler PsionicArtifactView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler PsionicWeaponView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler RingView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler RodView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler ScrollView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler StaffView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler TattooView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler UniversalView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler WandView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler WeaponView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged
            AddHandler WondrousView.ListView.SelectedIndexChanged, AddressOf SelectedIndexChanged

            AddHandler ArmorView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler ArtifactView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler DorjeView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler ItemView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler MagicArmorView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler MagicWeaponView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler PotionView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler PowerStoneView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler PsicrownView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler PsionicArmorView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler PsionicArtifactView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler PsionicWeaponView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler RingView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler RodView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler ScrollView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler StaffView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler TattooView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler UniversalView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler WandView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler WeaponView.ListView.MouseUp, AddressOf RightMouseUp
            AddHandler WondrousView.ListView.MouseUp, AddressOf RightMouseUp

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reinit
    Public Sub ReInit()
        Try
            'updates the shopping cart panel
            ShoppingCart.ExternalRefresh()

            BaseArmor = Objects.GetObjectsByXPath(XML.DBTypes.ArmorAndShields, "/RPGXplorerDatabase/RPGXplorerObject[(Type='" & Objects.ArmorDefinitionType & "' or Type='" & Objects.ShieldDefinitionType & "') and BaseItem!='Yes']")
            BaseArtifacts = Objects.GetAllObjectsOfType(Xml.DBTypes.Artifacts, Objects.ArtifactDefinitionType)
            BaseDorjes = Objects.GetAllObjectsOfType(Xml.DBTypes.Wands, Objects.PsionicDorjeDefinitionType)
            BaseItems = Objects.GetAllObjectsOfType(XML.DBTypes.Items, Objects.ItemDefinitionType)
            BaseMagicArmor = Objects.GetAllObjectsOfType(Xml.DBTypes.MagicArmor, Objects.SpecificArmorDefinitionType)

            BaseMagicWeapons = Objects.GetAllObjectsOfType(Xml.DBTypes.MagicWeapons, Objects.SpecificWeaponDefinitionType)
            BaseMagicWeapons.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.MagicWeapons, Objects.MagicAmmoDefinitionType))

            BasePotions = Objects.GetAllObjectsOfType(Xml.DBTypes.PotionsAndOils, Objects.PotionDefinitionType)
            BasePowerStones = Objects.GetAllObjectsOfType(Xml.DBTypes.Scrolls, Objects.PsionicPowerStoneDefinitionType)
            BasePsicrowns = Objects.GetAllObjectsOfType(Xml.DBTypes.Staffs, Objects.PsionicPsicrownDefinitionType)
            BasePsionicArmor = Objects.GetAllObjectsOfType(Xml.DBTypes.MagicArmor, Objects.PsionicArmorDefinitionType)
            BasePsionicArtifacts = Objects.GetAllObjectsOfType(Xml.DBTypes.Artifacts, Objects.PsionicArtifactDefinitionType)

            BasePsionicWeapons = Objects.GetAllObjectsOfType(Xml.DBTypes.MagicWeapons, Objects.PsionicWeaponDefinitionType)
            BasePsionicWeapons.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.MagicWeapons, Objects.PsionicAmmoDefinitionType))

            BaseRings = Objects.GetAllObjectsOfType(Xml.DBTypes.Rings, Objects.RingDefinitionType)
            BaseRods = Objects.GetAllObjectsOfType(Xml.DBTypes.Rods, Objects.RodDefinitionType)
            BaseScrolls = Objects.GetAllObjectsOfType(Xml.DBTypes.Scrolls, Objects.ScrollDefinitionType)
            BaseStaffs = Objects.GetAllObjectsOfType(Xml.DBTypes.Staffs, Objects.StaffDefinitionType)
            BaseTattoos = Objects.GetAllObjectsOfType(Xml.DBTypes.PotionsAndOils, Objects.PsionicTattooDefinitionType)
            BaseUniversalItems = Objects.GetAllObjectsOfType(Xml.DBTypes.WondrousItems, Objects.UniversalItemDefinitionType)
            BaseWands = Objects.GetAllObjectsOfType(Xml.DBTypes.Wands, Objects.WandDefinitionType)

            BaseWeaponsAmmo = Objects.GetAllObjectsOfType(Xml.DBTypes.Weapons, Objects.WeaponDefinitionType)
            BaseWeaponsAmmo.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.Weapons, Objects.AmmoDefinitionType))

            BaseWondrousItems = Objects.GetAllObjectsOfType(Xml.DBTypes.WondrousItems, Objects.WondrousDefinitionType)

            'update the current tab display
            XtraTabControl1_SelectedPageChanged(Nothing, Nothing)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'override close with hide
    Private Sub DocumentViewer_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ToolbarsAndMenus.MarketplaceButton.Down = False
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim SelectedListView As ListView = CType(sender, ListView)
            If SelectedListView Is Nothing Then Exit Sub
            If SelectedListView.SelectedItems.Count = 0 Or SelectedListView.SelectedItems.Count > 1 Then Exit Sub

            Dim Tag As Object
            Tag = SelectedListView.SelectedItems(0).Tag

            If TypeOf Tag Is Objects.ObjectData Then
                ShowHelpPage(CType(Tag, Objects.ObjectData))
            ElseIf TypeOf Tag Is Objects.ObjectKey Then
                Dim Obj As New Objects.ObjectData
                Obj.Load(CType(Tag, Objects.ObjectKey))
                ShowHelpPage(Obj)
            ElseIf TypeOf Tag Is String Then
                ShowHelp(Tag.ToString)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display right click menu
    Private Sub RightMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If e.Button = MouseButtons.Right Then

                Dim SelectedObjects As New Objects.ObjectDataCollection
                Dim Obj As New Objects.ObjectData
                Dim Item As ListViewItem

                If CurrentView() Is Nothing Then Exit Sub

                If CurrentView.ListView.SelectedItems.Count = 0 Then
                    Exit Sub
                Else
                    For Each Item In CurrentView.ListView.SelectedItems
                        If TypeOf Item.Tag Is RPGXplorer.Objects.ObjectKey Then
                            Obj.Load(CType(Item.Tag, Objects.ObjectKey))
                            SelectedObjects.Add(Obj)
                        ElseIf TypeOf Item.Tag Is Objects.ObjectData Then
                            Obj = CType(Item.Tag, Objects.ObjectData)
                            SelectedObjects.Add(Obj)
                        End If
                    Next
                End If

                If e.Button = MouseButtons.Right Then
                    ToolbarsAndMenus.BuildMarketplacePopupMenu(SelectedObjects)
                    ToolbarsAndMenus.PopupMenu.ShowPopup(New Point(Control.MousePosition.X, Control.MousePosition.Y))
                End If

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get help page from an ObjectData
    Private Sub ShowHelpPage(ByVal Obj As Objects.ObjectData)
        Dim HelpPage As String
        Dim HelpObj As New Objects.ObjectData

        If Obj.ObjectGUID.IsEmpty Then Exit Sub

        If Obj.HTMLGUID.Equals(Objects.ObjectKey.Empty) Then
            HelpPage = Obj.HTML
        Else
            HelpObj.Load(Obj.HTMLGUID)
            HelpPage = HelpObj.HTML
        End If

        ShowHelp(HelpPage)
    End Sub

    'show a specific help page
    Public Sub ShowHelp(ByVal HelpPage As String)
        If HelpPage.IndexOf(":\") = 1 And IO.File.Exists(HelpPage) Then
            Browser.Navigate("file://" & HelpPage)
        Else
            If IO.File.Exists(General.HelpPath & HelpPage) Then
                Browser.Navigate("file://" & General.HelpPath & HelpPage)
            Else
                Browser.Navigate("file://" & General.HelpPath & "Help\FileNotFound.htm")
            End If
        End If
    End Sub

    'handles the filter being changed
    Private Sub FilterBar_FilterChanged() Handles FilterBar.FilterChanged
        Try
            Dim View As RPGXListView = CurrentView()

            If Not View Is Nothing Then
                View.ClearItems()
                View.AddRange(FilterBar.FilteredObjects)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TabChanging = True
        Dim View As RPGXListView = CurrentView()
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                FilterBar.Init(ArmorFolder, BaseArmor)
            Case 1
                FilterBar.Init(WeaponFolder, BaseWeaponsAmmo)
            Case 2
                FilterBar.Init(ItemFolder, BaseItems)
            Case 3
                FilterBar.Init(ArtifactFolder, BaseArtifacts)
            Case 4
                FilterBar.Init(MagicArmorFolder, BaseMagicArmor)
            Case 5
                FilterBar.Init(MagicWeaponFolder, BaseMagicWeapons)
            Case 6
                FilterBar.Init(PotionFolder, BasePotions)
            Case 7
                FilterBar.Init(RingFolder, BaseRings)
            Case 8
                FilterBar.Init(RodFolder, BaseRods)
            Case 9
                FilterBar.Init(ScrollFolder, BaseScrolls)
            Case 10
                FilterBar.Init(StaffFolder, BaseStaffs)
            Case 11
                FilterBar.Init(WandFolder, BaseWands)
            Case 12
                FilterBar.Init(WondrousFolder, BaseWondrousItems)
            Case 13
                FilterBar.Init(DorjeFolder, BaseDorjes)
            Case 14
                FilterBar.Init(PowerStoneFolder, BasePowerStones)
            Case 15
                FilterBar.Init(PsicrownFolder, BasePsicrowns)
            Case 16
                FilterBar.Init(PsionicArmorFolder, BasePsionicArmor)
            Case 17
                FilterBar.Init(PsionicArtifactFolder, BasePsionicArtifacts)
            Case 18
                FilterBar.Init(PsionicWeaponFolder, BasePsionicWeapons)
            Case 19
                FilterBar.Init(TattooFolder, BaseTattoos)
            Case 20
                FilterBar.Init(UniversalItemFolder, BaseUniversalItems)
        End Select
        View.ClearItems()
        View.AddRange(FilterBar.FilteredObjects)
        TabChanging = False
    End Sub

    'get the currently displayed list view
    Private Function CurrentView() As RPGXListView
        Return CType(XtraTabControl1.TabPages.Item(XtraTabControl1.SelectedTabPageIndex).Controls.Item(0), RPGXListView)
    End Function

    'recolor on init
    Private Sub Marketplace_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Try
            CurrentView.ColorListview()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'icon view
    Private Sub Icons_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Icons.Click
        Dim View As RPGXListView
        View = CurrentView()

        If Not View Is Nothing Then
            View.ListView.View = System.Windows.Forms.View.LargeIcon
            View.ColorListview()
        End If
    End Sub

    'detail biew
    Private Sub Details_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Details.Click
        Dim View As RPGXListView
        View = CurrentView()

        If Not View Is Nothing Then
            View.ListView.View = System.Windows.Forms.View.Details
            View.ColorListview()
        End If
    End Sub

    'refreshes the panel when it is reselected
    Private Sub Marketplace_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        General.Marketplace.ReInit()
    End Sub

End Class
