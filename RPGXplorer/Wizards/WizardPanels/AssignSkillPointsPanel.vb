Option Strict On
Option Explicit On 

Imports RPGXplorer.General

Public Class AssignSkillPointsPanel
    Inherits RPGXplorer.PanelBase
    Implements IWizardPanel

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
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents SkillPointsRemaining As DevExpress.XtraEditors.TextEdit
    Public WithEvents SkillsGrid As DevExpress.XtraGrid.GridControl
    Public WithEvents SkillsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents SkillColumn As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Ranks As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents LevelRanksSpin As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Public WithEvents ClassSkill As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Mods As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents Final As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents MaxClass As DevExpress.XtraEditors.TextEdit
    Public WithEvents MaxCrossClass As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As RPGXInheritedListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents LevelRanks As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents ResetAll As System.Windows.Forms.Button
    Public WithEvents MaxOut As System.Windows.Forms.Button
    Public WithEvents Reset As System.Windows.Forms.Button
    Public WithEvents AutoSlot As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.SkillPointsRemaining = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.SkillsGrid = New DevExpress.XtraGrid.GridControl
        Me.SkillsGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SkillColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ClassSkill = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ranks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Mods = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LevelRanks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LevelRanksSpin = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Final = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.Label1 = New System.Windows.Forms.Label
        Me.MaxClass = New DevExpress.XtraEditors.TextEdit
        Me.MaxCrossClass = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New RPGXplorer.RPGXInheritedListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AutoSlot = New System.Windows.Forms.CheckBox
        Me.ResetAll = New System.Windows.Forms.Button
        Me.MaxOut = New System.Windows.Forms.Button
        Me.Reset = New System.Windows.Forms.Button
        CType(Me.SkillPointsRemaining.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkillsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkillsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelRanksSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MaxClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxCrossClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(175, 21)
        Me.ObjLabel.TabIndex = 94
        Me.ObjLabel.Text = "Please assign your skill points"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkillPointsRemaining
        '
        Me.SkillPointsRemaining.EditValue = "0"
        Me.SkillPointsRemaining.Location = New System.Drawing.Point(75, 45)
        Me.SkillPointsRemaining.Name = "SkillPointsRemaining"
        Me.SkillPointsRemaining.Properties.Appearance.Options.UseTextOptions = True
        Me.SkillPointsRemaining.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SkillPointsRemaining.Properties.AutoHeight = False
        Me.SkillPointsRemaining.Properties.ReadOnly = True
        Me.SkillPointsRemaining.Size = New System.Drawing.Size(40, 21)
        Me.SkillPointsRemaining.TabIndex = 106
        Me.SkillPointsRemaining.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Remaining"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkillsGrid
        '
        Me.SkillsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkillsGrid.EmbeddedNavigator.Name = ""
        Me.SkillsGrid.Location = New System.Drawing.Point(1, 1)
        Me.SkillsGrid.MainView = Me.SkillsGridView
        Me.SkillsGrid.Name = "SkillsGrid"
        Me.SkillsGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LevelRanksSpin})
        Me.SkillsGrid.Size = New System.Drawing.Size(468, 243)
        Me.SkillsGrid.TabIndex = 0
        Me.SkillsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SkillsGridView})
        '
        'SkillsGridView
        '
        Me.SkillsGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SkillsGridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.SkillsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SkillsGridView.ColumnPanelRowHeight = 20
        Me.SkillsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SkillColumn, Me.ClassSkill, Me.Ranks, Me.Mods, Me.LevelRanks, Me.Final})
        Me.SkillsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SkillsGridView.GridControl = Me.SkillsGrid
        Me.SkillsGridView.Name = "SkillsGridView"
        Me.SkillsGridView.OptionsCustomization.AllowColumnMoving = False
        Me.SkillsGridView.OptionsCustomization.AllowFilter = False
        Me.SkillsGridView.OptionsCustomization.AllowGroup = False
        Me.SkillsGridView.OptionsDetail.AllowZoomDetail = False
        Me.SkillsGridView.OptionsDetail.EnableMasterViewMode = False
        Me.SkillsGridView.OptionsDetail.SmartDetailExpand = False
        Me.SkillsGridView.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.SkillsGridView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.SkillsGridView.OptionsLayout.Columns.AddNewColumns = False
        Me.SkillsGridView.OptionsLayout.Columns.RemoveOldColumns = False
        Me.SkillsGridView.OptionsLayout.Columns.StoreLayout = False
        Me.SkillsGridView.OptionsLayout.StoreDataSettings = False
        Me.SkillsGridView.OptionsLayout.StoreVisualOptions = False
        Me.SkillsGridView.OptionsMenu.EnableColumnMenu = False
        Me.SkillsGridView.OptionsMenu.EnableFooterMenu = False
        Me.SkillsGridView.OptionsMenu.EnableGroupPanelMenu = False
        Me.SkillsGridView.OptionsView.ColumnAutoWidth = False
        Me.SkillsGridView.OptionsView.EnableAppearanceEvenRow = True
        Me.SkillsGridView.OptionsView.RowAutoHeight = True
        Me.SkillsGridView.OptionsView.ShowDetailButtons = False
        Me.SkillsGridView.OptionsView.ShowGroupPanel = False
        Me.SkillsGridView.OptionsView.ShowHorzLines = False
        Me.SkillsGridView.OptionsView.ShowIndicator = False
        Me.SkillsGridView.OptionsView.ShowVertLines = False
        Me.SkillsGridView.RowHeight = 20
        Me.SkillsGridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.SkillsGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.SkillColumn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'SkillColumn
        '
        Me.SkillColumn.Caption = "Skill"
        Me.SkillColumn.FieldName = "Skill"
        Me.SkillColumn.Name = "SkillColumn"
        Me.SkillColumn.OptionsColumn.AllowEdit = False
        Me.SkillColumn.OptionsColumn.AllowFocus = False
        Me.SkillColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.SkillColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.SkillColumn.OptionsColumn.ReadOnly = True
        Me.SkillColumn.OptionsColumn.ShowInCustomizationForm = False
        Me.SkillColumn.OptionsFilter.AllowFilter = False
        Me.SkillColumn.Visible = True
        Me.SkillColumn.VisibleIndex = 0
        Me.SkillColumn.Width = 170
        '
        'ClassSkill
        '
        Me.ClassSkill.AppearanceCell.Options.UseTextOptions = True
        Me.ClassSkill.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ClassSkill.AppearanceHeader.Options.UseTextOptions = True
        Me.ClassSkill.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ClassSkill.Caption = "Class Skill"
        Me.ClassSkill.FieldName = "ClassSkill"
        Me.ClassSkill.Name = "ClassSkill"
        Me.ClassSkill.OptionsColumn.AllowEdit = False
        Me.ClassSkill.OptionsColumn.AllowFocus = False
        Me.ClassSkill.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClassSkill.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClassSkill.OptionsColumn.ReadOnly = True
        Me.ClassSkill.OptionsColumn.ShowInCustomizationForm = False
        Me.ClassSkill.OptionsFilter.AllowFilter = False
        Me.ClassSkill.Visible = True
        Me.ClassSkill.VisibleIndex = 1
        Me.ClassSkill.Width = 76
        '
        'Ranks
        '
        Me.Ranks.AppearanceCell.Options.UseTextOptions = True
        Me.Ranks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ranks.AppearanceHeader.Options.UseTextOptions = True
        Me.Ranks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ranks.Caption = "Ranks"
        Me.Ranks.FieldName = "Ranks"
        Me.Ranks.Name = "Ranks"
        Me.Ranks.OptionsColumn.AllowEdit = False
        Me.Ranks.OptionsColumn.AllowFocus = False
        Me.Ranks.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.Ranks.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Ranks.OptionsColumn.ReadOnly = True
        Me.Ranks.OptionsColumn.ShowInCustomizationForm = False
        Me.Ranks.OptionsFilter.AllowFilter = False
        Me.Ranks.Visible = True
        Me.Ranks.VisibleIndex = 2
        Me.Ranks.Width = 43
        '
        'Mods
        '
        Me.Mods.AppearanceCell.Options.UseTextOptions = True
        Me.Mods.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Mods.AppearanceHeader.Options.UseTextOptions = True
        Me.Mods.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Mods.Caption = "Mods"
        Me.Mods.FieldName = "Mods"
        Me.Mods.Name = "Mods"
        Me.Mods.OptionsColumn.AllowEdit = False
        Me.Mods.OptionsColumn.AllowFocus = False
        Me.Mods.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.Mods.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Mods.OptionsColumn.ReadOnly = True
        Me.Mods.OptionsColumn.ShowInCustomizationForm = False
        Me.Mods.OptionsFilter.AllowFilter = False
        Me.Mods.Visible = True
        Me.Mods.VisibleIndex = 3
        Me.Mods.Width = 39
        '
        'LevelRanks
        '
        Me.LevelRanks.AppearanceCell.Options.UseTextOptions = True
        Me.LevelRanks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LevelRanks.AppearanceHeader.Options.UseTextOptions = True
        Me.LevelRanks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LevelRanks.Caption = "Level Ranks"
        Me.LevelRanks.ColumnEdit = Me.LevelRanksSpin
        Me.LevelRanks.FieldName = "LevelRanks"
        Me.LevelRanks.Name = "LevelRanks"
        Me.LevelRanks.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.LevelRanks.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.LevelRanks.OptionsColumn.ShowInCustomizationForm = False
        Me.LevelRanks.OptionsFilter.AllowFilter = False
        Me.LevelRanks.Visible = True
        Me.LevelRanks.VisibleIndex = 4
        Me.LevelRanks.Width = 73
        '
        'LevelRanksSpin
        '
        Me.LevelRanksSpin.AutoHeight = False
        Me.LevelRanksSpin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LevelRanksSpin.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.LevelRanksSpin.Name = "LevelRanksSpin"
        Me.LevelRanksSpin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'Final
        '
        Me.Final.AppearanceCell.Options.UseTextOptions = True
        Me.Final.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Final.AppearanceHeader.Options.UseTextOptions = True
        Me.Final.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Final.Caption = "Final"
        Me.Final.FieldName = "Final"
        Me.Final.Name = "Final"
        Me.Final.OptionsColumn.AllowEdit = False
        Me.Final.OptionsColumn.AllowFocus = False
        Me.Final.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.Final.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Final.OptionsColumn.ReadOnly = True
        Me.Final.OptionsColumn.ShowInCustomizationForm = False
        Me.Final.OptionsFilter.AllowFilter = False
        Me.Final.Visible = True
        Me.Final.VisibleIndex = 5
        Me.Final.Width = 47
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.Location = New System.Drawing.Point(500, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(430, 535)
        Me.Panel1.TabIndex = 128
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(428, 533)
        Me.Browser.TabIndex = 0
        Me.Browser.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(230, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Max Class"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaxClass
        '
        Me.MaxClass.EditValue = "0"
        Me.MaxClass.Location = New System.Drawing.Point(295, 45)
        Me.MaxClass.Name = "MaxClass"
        Me.MaxClass.Properties.Appearance.Options.UseTextOptions = True
        Me.MaxClass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaxClass.Properties.AutoHeight = False
        Me.MaxClass.Properties.ReadOnly = True
        Me.MaxClass.Size = New System.Drawing.Size(40, 21)
        Me.MaxClass.TabIndex = 129
        Me.MaxClass.TabStop = False
        '
        'MaxCrossClass
        '
        Me.MaxCrossClass.EditValue = "0"
        Me.MaxCrossClass.Location = New System.Drawing.Point(445, 45)
        Me.MaxCrossClass.Name = "MaxCrossClass"
        Me.MaxCrossClass.Properties.Appearance.Options.UseTextOptions = True
        Me.MaxCrossClass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaxCrossClass.Properties.AutoHeight = False
        Me.MaxCrossClass.Properties.ReadOnly = True
        Me.MaxCrossClass.Size = New System.Drawing.Size(40, 21)
        Me.MaxCrossClass.TabIndex = 131
        Me.MaxCrossClass.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(350, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Max Cross-Class"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SkillsGrid)
        Me.Panel2.Location = New System.Drawing.Point(15, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(470, 245)
        Me.Panel2.TabIndex = 134
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.Location = New System.Drawing.Point(15, 360)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(470, 190)
        Me.Panel3.TabIndex = 138
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.AvailableSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSlots.FullRowSelect = True
        Me.AvailableSlots.HideSelection = False
        Me.AvailableSlots.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSlots.MultiSelect = False
        Me.AvailableSlots.Name = "AvailableSlots"
        Me.AvailableSlots.Size = New System.Drawing.Size(468, 188)
        Me.AvailableSlots.TabIndex = 0
        Me.AvailableSlots.UseCompatibleStateImageBehavior = False
        Me.AvailableSlots.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Level"
        Me.ColumnHeader1.Width = 243
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Points Remaining"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Points Spent"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 94
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'AutoSlot
        '
        Me.AutoSlot.BackColor = System.Drawing.Color.Transparent
        Me.AutoSlot.Location = New System.Drawing.Point(15, 328)
        Me.AutoSlot.Name = "AutoSlot"
        Me.AutoSlot.Size = New System.Drawing.Size(185, 24)
        Me.AutoSlot.TabIndex = 0
        Me.AutoSlot.Text = "Disable automatic slot selection"
        Me.AutoSlot.UseVisualStyleBackColor = False
        '
        'ResetAll
        '
        Me.ResetAll.Enabled = False
        Me.ResetAll.Location = New System.Drawing.Point(405, 328)
        Me.ResetAll.Name = "ResetAll"
        Me.ResetAll.Size = New System.Drawing.Size(80, 24)
        Me.ResetAll.TabIndex = 3
        Me.ResetAll.Text = "Reset All"
        '
        'MaxOut
        '
        Me.MaxOut.Enabled = False
        Me.MaxOut.Location = New System.Drawing.Point(235, 328)
        Me.MaxOut.Name = "MaxOut"
        Me.MaxOut.Size = New System.Drawing.Size(80, 24)
        Me.MaxOut.TabIndex = 1
        Me.MaxOut.Text = "Max Out"
        '
        'Reset
        '
        Me.Reset.Enabled = False
        Me.Reset.Location = New System.Drawing.Point(320, 328)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(80, 24)
        Me.Reset.TabIndex = 2
        Me.Reset.Text = "Reset"
        '
        'AssignSkillPointsPanel
        '
        Me.Controls.Add(Me.ResetAll)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.MaxOut)
        Me.Controls.Add(Me.AutoSlot)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MaxCrossClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaxClass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SkillPointsRemaining)
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "AssignSkillPointsPanel"
        Me.Size = New System.Drawing.Size(950, 565)
        CType(Me.SkillPointsRemaining.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkillsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkillsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelRanksSpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MaxClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxCrossClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private CurrentLevel, LevelsToAdd As Integer
    Private SkillPoints, PointsUsed, MaxClassRanks, MaxCrossClassRanks As Double
    Private Character, ExistingCharacter As Rules.Character
    Private SkillsData As DataTable
    Private CurrentSlot As Rules.Skills.SkillSlot

    Private MasterSkillSlots As ArrayList

    'flags
    Private CancelEvent As Boolean = False
    Private CancelRowChange As Boolean = False

    Public Changed As Boolean

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As Rules.Skills.SkillSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems.Item(0).Tag, Rules.Skills.SkillSlot)
                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("No slot selected")
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

    Private ReadOnly Property PointsAvailable() As Double
        Get
            Return SkillPoints - PointsUsed
        End Get
    End Property

#End Region

    'initialise this panel
    Public Sub Init(ByVal Character As Rules.Character, ByVal ExistingCharacter As Rules.Character)
        Try
            'init vars
            IsInitialised = True
            Changed = False
            Me.Character = Character
            Me.ExistingCharacter = ExistingCharacter
            PointsUsed = 0

            'load slots
            LoadSlots()

            'set the first item
            CurrentSlot = CType(AvailableSlots.Items(0).Tag, Rules.Skills.SkillSlot)
            AvailableSlots.Items(0).Selected = True

            'load the skills datatable and bind grid
            SkillsData = Character.Skills.GetSkillsDataTable()
            SkillsGrid.DataSource = SkillsData

            'init counters
            SkillPointsRemaining.EditValue = SkillPoints
            If SkillPoints > 0 Then RaiseEvent DisableNext()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'is the panel required
    Public Function PanelRequired(ByVal Character As Rules.Character) As Boolean
        Select Case Character.CharacterType
            Case Rules.Character.CharacterObjectType.Familiar
                Return False
            Case Else
                'if this is an Animal Companion/Special mount and we are adding the first level, then include racial ranks
                If Character.FirstNewLevel = 1 Then
                    Select Case Character.CharacterType
                        Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount, Rules.Character.CharacterObjectType.Monster
                            'get the class skills
                            Dim ClassSkills As Objects.ObjectDataCollection = Character.RaceObject.ChildrenOfType(Objects.ClassSkillType)
                            For Each ClassSkill As Objects.ObjectData In ClassSkills
                                Dim Ranks As Integer
                                Ranks = ClassSkill.ElementAsInteger("Ranks")

                                'if we have ranks, get the skillrank and update
                                If Ranks > 0 Then
                                    Dim SkillRank As Rules.Character.SkillRank
                                    SkillRank = Character.Skill(ClassSkill.GetFKGuid("Skill"))
                                    SkillRank.Ranks = Ranks
                                    SkillRank.AssignedRanks(0) = Ranks
                                    Character.SkillRanks.Item(SkillRank.SkillGuid) = SkillRank

                                End If
                            Next
                    End Select
                End If

                'see if we have any skill points to assign
                Me.Character = Character
                MasterSkillSlots = Character.Skills.GetSkillSlots
                If MasterSkillSlots.Count > 0 Then Return True Else Return False

        End Select
    End Function

    'load the slots for the currently selected class
    Private Sub LoadSlots()
        Dim Slot As Rules.Skills.SkillSlot

        Try
            'clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()
            SkillPoints = 0

            'add each slot to the listview
            For Each Slot In MasterSkillSlots
                AvailableSlots.Items.Add(LoadSlot(Slot))
                SkillPoints += Slot.PointsRemaining
            Next

            AvailableSlots.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'generates a ListViewItem from a skill slot
    Private Function LoadSlot(ByVal Slot As Rules.Skills.SkillSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = "Level " & Slot.CharacterLevel & " - " & Character.Levels(Slot.CharacterLevel).ClassName & " " & Character.Levels(Slot.CharacterLevel).ClassLevel
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add(Slot.PointsRemaining.ToString)
            ListViewItem.SubItems.Add(Slot.PointsSpent.ToString)
            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext

    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised

        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 950
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 650
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel
        'enable next button if required
        If SkillPoints - PointsUsed = 0 Then
            RaiseEvent EnableNext(False)
        Else
            RaiseEvent DisableNext()
        End If
    End Sub

#End Region

#Region "Event Handlers"

    'prevent the spin edit from exceeding the range of allowed values
    Private Sub LevelRanksSpin_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles LevelRanksSpin.EditValueChanging
        Try
            'prevent it from exceeding max value
            If CDec(e.NewValue) > LevelRanksSpin.MaxValue Then e.Cancel = True

            'prevent if from going below 0
            If CDec(e.NewValue) < 0 Then e.Cancel = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle the assignment of a skill point
    Private Sub LevelRanksSpin_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LevelRanksSpin.EditValueChanged
        If SkillsGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then Exit Sub
        If CancelRowChange Then Exit Sub

        Dim Row As DataRow
        Dim OldVal, NewVal, PointsUsedTemp As Double
        Dim SpinEdit As DevExpress.XtraEditors.SpinEdit
        Dim SkillRank As Rules.Character.SkillRank
        Dim SlotIndex As Integer

        Try
            SpinEdit = CType(sender, DevExpress.XtraEditors.SpinEdit)

            'get the change in value
            Row = SkillsGridView.GetDataRow(SkillsGridView.FocusedRowHandle)
            OldVal = ConvertToDouble(Row("LevelRanks").ToString())
            NewVal = ConvertToDouble(SpinEdit.EditValue.ToString)

            'if nothing has changed - quit
            If OldVal = NewVal Then
                Exit Sub
            End If

            'If SpinEdit.Properties.MaxValue = 0 Then
            '    SpinEdit.EditValue = OldVal
            '    Exit Sub
            'End If

            'recalculate the points remaining
            If Row("ClassSkill").ToString = "Class" Then
                PointsUsedTemp = NewVal - OldVal

                'This is to make sure we dont add or remove half point, when dealing with class skills
                If Math.Floor(PointsUsedTemp) <> PointsUsedTemp Then
                    SpinEdit.EditValue = OldVal
                    Exit Sub
                End If

            Else
                PointsUsedTemp = (NewVal - OldVal) * 2
            End If

            'update only if value >= 0 and points left to spend
            Dim slot As Rules.Skills.SkillSlot = SelectedSlot
            If (slot.PointsRemaining - PointsUsedTemp >= 0) Then
                PointsUsed += PointsUsedTemp

                'update the skill rank
                SkillRank = Character.Skill(New Objects.ObjectKey(Row("SkillGuid").ToString))
                SkillRank.NewRanks += (NewVal - OldVal)
                SkillRank.AssignedRanks(slot.CharacterLevel) = NewVal
                Character.SkillRanks.Item(SkillRank.SkillGuid) = SkillRank

                'UpdateSlot
                slot.PointsRemaining -= CInt(PointsUsedTemp)
                slot.PointsSpent += CInt(PointsUsedTemp)
                slot.SkillRanksAssigned(SkillRank.SkillGuid) = NewVal
                CurrentSlot = slot

                CancelEvent = True
                AvailableSlots.BeginUpdate()
                SlotIndex = AvailableSlots.SelectedIndices(0)
                AvailableSlots.Items(SlotIndex) = LoadSlot(slot)
                AvailableSlots.Items(SlotIndex).Selected = True
                AvailableSlots.EnsureVisible(SlotIndex)
                AvailableSlots.EndUpdate()
                CancelEvent = False

                'update the dataset
                Row("Ranks") = ConvertToDouble(Row("Ranks")) + (NewVal - OldVal)
                Row("Final") = Rules.Formatting.FormatModifier(CInt(SkillRank.Final))
                Row("LevelRanks") = CType(slot.SkillRanksAssigned(SkillRank.SkillGuid), Double)

                SkillPointsRemaining.Text = (SkillPoints - PointsUsed).ToString

                'enable/disable next
                If SkillPoints - PointsUsed = 0 Then
                    RaiseEvent EnableNext(False)
                Else
                    RaiseEvent DisableNext()
                End If

                Changed = True

                'If Auto slot is on, see if we need to move to the next slot
                If AutoSlot.CheckState = CheckState.Unchecked Then
                    If slot.PointsRemaining = 0 OrElse SpinEdit.Value = SpinEdit.Properties.MaxValue OrElse (Row("ClassSkill").ToString = "Class" AndAlso ((SpinEdit.Properties.MaxValue - SpinEdit.Value) <= 0.5)) Then
                        If AvailableSlots.SelectedItems(0).Index < AvailableSlots.Items.Count - 1 Then
                            CancelRowChange = True

                            'Find the next slot with points
                            Dim FirstSlot As Rules.Skills.SkillSlot
                            For i As Integer = (SlotIndex + 1) To AvailableSlots.Items.Count - 1
                                FirstSlot = CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot)
                                If FirstSlot.PointsRemaining > 0 Then
                                    AvailableSlots.Items(i).Selected = True
                                    Exit For
                                End If
                            Next
                            SkillsGrid.Enabled = False
                            Timer1.Enabled = True
                        End If
                    End If
                End If

            Else
                SpinEdit.EditValue = OldVal
            End If

            SkillsGridView.UpdateCurrentRow()
            UpdateButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle the row being changed - set max value for the new row, show help
    Private Sub SkillsGridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles SkillsGridView.FocusedRowChanged
        If CancelRowChange Then Exit Sub

        Dim Row As DataRow
        Dim Skill As Objects.ObjectData
        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1

        Try
            If e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then Exit Sub
            Row = SkillsGridView.GetDataRow(e.FocusedRowHandle)
            If Row Is Nothing Then Exit Sub

            'auto slot to the lowest level slot with points still available?
            If AutoSlot.CheckState = CheckState.Unchecked Then
                Dim FirstSlot As Rules.Skills.SkillSlot
                For i As Integer = 0 To MaxIndex
                    FirstSlot = CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot)
                    If FirstSlot.PointsRemaining > 0 Then
                        AvailableSlots.Items(i).Selected = True
                        Exit For
                    End If
                Next
            End If

            'update the max value for the level ranks spin edit
            UpdateLevelRanksMax()

            'update max/clear buttons
            UpdateButtons()

            'show help for selected
            Skill = Caches.Skills.Item(New Objects.ObjectKey(Row("SkillGuid").ToString))

            If Skill.HTML.IndexOf(":\") = 1 And IO.File.Exists(Skill.HTML) Then
                Browser.Navigate("file://" & Skill.HTML)
            Else
                If IO.File.Exists(General.HelpPath & Skill.HTML) Then
                    Browser.Navigate("file://" & General.HelpPath & Skill.HTML)
                Else
                    Browser.Navigate("file://" & General.HelpPath & "Help\FileNotFound.htm")
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle the skill slot being changed
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        If CancelRowChange Then Exit Sub
        If CancelEvent Then Exit Sub

        Dim NewSlot As Rules.Skills.SkillSlot
        Dim Row As DataRow

        If AvailableSlots.SelectedItems.Count = 1 Then

            NewSlot = SelectedSlot()

            'update skill data rows          
            For Each Row In SkillsData.Rows
                'get skill
                Dim SkillKey As Objects.ObjectKey = New Objects.ObjectKey(Row("SkillGuid").ToString)

                'class or cross-class?
                If Character.Skills.IsClassSkillForClassAtLevel(NewSlot.ClassGuid, SkillKey, NewSlot.CharacterLevel) Then
                    Row.Item("ClassSkill") = "Class"
                Else
                    Row.Item("ClassSkill") = "Cross-Class"
                End If

                'delete previous slots values
                If CurrentSlot.SkillRanksAssigned.ContainsKey(SkillKey) Then
                    Row.Item("LevelRanks") = 0
                End If

                'add this slots values
                If NewSlot.SkillRanksAssigned.ContainsKey(SkillKey) Then
                    Row.Item("LevelRanks") = CType(NewSlot.SkillRanksAssigned(SkillKey), Double)
                End If
            Next

            CurrentSlot = NewSlot

            'get max values
            Select Case Character.CharacterType
                Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                    MaxClassRanks = Rules.ExperienceAndLevelling.LevelDependentBenefits(Character.HitDiceAtLevel(NewSlot.CharacterLevel)).ClassSkillMaxRanks
                    MaxCrossClassRanks = Rules.ExperienceAndLevelling.LevelDependentBenefits(Character.HitDiceAtLevel(NewSlot.CharacterLevel)).CrossClassSkillMaxRanks
                Case Else
                    MaxClassRanks = Rules.ExperienceAndLevelling.LevelDependentBenefits(NewSlot.CharacterLevel).ClassSkillMaxRanks
                    MaxCrossClassRanks = Rules.ExperienceAndLevelling.LevelDependentBenefits(NewSlot.CharacterLevel).CrossClassSkillMaxRanks
            End Select

            MaxClass.EditValue = MaxClassRanks
            MaxCrossClass.EditValue = MaxCrossClassRanks

            If CancelEvent Then
                Exit Sub
            End If

            If SkillsGridView.FocusedRowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                UpdateLevelRanksMax()
            End If

        End If

    End Sub

#End Region

    'Assign as many points to this skill as possible
    Private Sub MaxOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxOut.Click
        Try
            'get the current row
            Dim Row As DataRow = SkillsGridView.GetDataRow(SkillsGridView.FocusedRowHandle)
            If Row Is Nothing Then Exit Sub

            'get the skill key
            Dim SkillKey As New Objects.ObjectKey(Row("SkillGuid").ToString)

            'assign available points starting with the first slot
            AvailableSlots.BeginUpdate()

            For n As Integer = 0 To AvailableSlots.Items.Count - 1
                If PointsAvailable > 0 Then
                    'get the slot
                    Dim Slot As Rules.Skills.SkillSlot = CType(AvailableSlots.Items(n).Tag, Rules.Skills.SkillSlot)

                    'how many ranks assigned overall?
                    Dim RanksAssignedOverall As Double
                    Dim RanksAssignedSoFar As Double
                    Dim SkillRank As Rules.Character.SkillRank = Character.Skill(SkillKey)
                    RanksAssignedOverall = SkillRank.RankAtLevel(Character.CharacterLevel)
                    RanksAssignedSoFar = SkillRank.RankAtLevel(Slot.CharacterLevel)

                    'max ranks for current slot
                    Dim MaxRanks As Double = MaxRanksForSlot(SkillKey, Slot.CharacterLevel)
                    Dim MaxRanksOverall As Double = MaxRanksForSlot(SkillKey, Character.CharacterLevel)
                    Dim RanksLeftOverall As Double = MaxRanksOverall - RanksAssignedOverall

                    'get the ranks available for this slot
                    Dim IsClassSkill As Boolean = Character.Skills.IsClassSkillForClassAtLevel(Slot.ClassGuid, SkillKey, Slot.CharacterLevel)
                    Dim RanksAvailableForSlot As Double = Slot.PointsRemaining
                    If RanksAvailableForSlot > 0 And Not IsClassSkill Then RanksAvailableForSlot /= 2

                    'determine max ranks for the slot
                    If RanksAvailableForSlot > RanksLeftOverall Then RanksAvailableForSlot = RanksLeftOverall
                    Dim RanksAssignedInThisSlot As Double = CDbl(Slot.SkillRanksAssigned(SkillKey))
                    If RanksAssignedSoFar + RanksAvailableForSlot > MaxRanks Then RanksAvailableForSlot = MaxRanks - RanksAssignedSoFar

                    If RanksAvailableForSlot > 0 Then
                        'assign as many points as we can 
                        If IsClassSkill Then RanksAvailableForSlot = Math.Floor(RanksAvailableForSlot)
                        Dim PointCostOfRanksAvailable As Double = RanksAvailableForSlot
                        If Not IsClassSkill Then PointCostOfRanksAvailable *= 2
                        Dim PointsToAssign As Double = PointCostOfRanksAvailable
                        If PointsToAssign > Slot.PointsRemaining Then PointsToAssign = Slot.PointsRemaining
                        If PointsToAssign > PointsAvailable Then PointsToAssign = PointsAvailable
                        PointsUsed += PointsToAssign
                        Dim RanksToAssign As Double = PointsToAssign
                        If Not IsClassSkill Then RanksToAssign /= 2

                        'update the skill rank on the character
                        SkillRank.NewRanks += RanksToAssign
                        SkillRank.AssignedRanks(Slot.CharacterLevel) = CDbl(SkillRank.AssignedRanks(Slot.CharacterLevel)) + RanksToAssign
                        Character.SkillRanks.Item(SkillKey) = SkillRank

                        'update the slot
                        Slot.PointsRemaining -= CInt(PointsToAssign)
                        Slot.PointsSpent += CInt(PointsToAssign)
                        Slot.SkillRanksAssigned(SkillKey) = SkillRank.AssignedRanks(Slot.CharacterLevel)
                        AvailableSlots.Items(n) = LoadSlot(Slot)

                        'update the dataset
                        Row("Ranks") = ConvertToDouble(Row("Ranks")) + RanksToAssign
                        Row("Final") = Rules.Formatting.FormatModifier(CInt(SkillRank.Final))
                        Row("LevelRanks") = SkillRank.AssignedRanks(Slot.CharacterLevel)
                    End If
                Else
                    Exit For
                End If
            Next

            'update ui
            AvailableSlots.Items(0).Selected = True
            AvailableSlots.Items(0).EnsureVisible()
            AvailableSlots.EndUpdate()
            SkillPointsRemaining.Text = PointsAvailable.ToString
            If PointsAvailable = 0 Then RaiseEvent EnableNext(False) Else RaiseEvent DisableNext()
            UpdateButtons()
            Changed = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Remove all the assigned points from this skill
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Try
            'get the current row
            Dim Row As DataRow = SkillsGridView.GetDataRow(SkillsGridView.FocusedRowHandle)
            If Row Is Nothing Then Exit Sub

            'get the skill key
            Dim SkillKey As New Objects.ObjectKey(Row("SkillGuid").ToString)

            'assign available points starting with the first slot
            AvailableSlots.BeginUpdate()
            For n As Integer = 0 To AvailableSlots.Items.Count - 1
                If PointsAvailable < SkillPoints Then
                    Dim Slot As Rules.Skills.SkillSlot = CType(AvailableSlots.Items(n).Tag, Rules.Skills.SkillSlot)
                    If Slot.SkillRanksAssigned.ContainsKey(SkillKey) Then
                        Dim IsClassSkill As Boolean = Character.Skills.IsClassSkillForClassAtLevel(Slot.ClassGuid, SkillKey, Slot.CharacterLevel)
                        Dim RanksAssigned As Double = CDbl(Slot.SkillRanksAssigned(SkillKey))
                        Dim PointCostOfRanksAssigned As Double = RanksAssigned
                        If Not IsClassSkill Then PointCostOfRanksAssigned *= 2
                        PointsUsed -= PointCostOfRanksAssigned

                        'update the skill rank on the character
                        Dim SkillRank As Rules.Character.SkillRank = Character.Skill(SkillKey)
                        SkillRank.NewRanks = 0
                        SkillRank.AssignedRanks(Slot.CharacterLevel) = 0
                        Character.SkillRanks.Item(SkillKey) = SkillRank

                        'update the slot
                        Slot.PointsRemaining += CInt(PointCostOfRanksAssigned)
                        Slot.PointsSpent -= CInt(PointCostOfRanksAssigned)
                        Slot.SkillRanksAssigned(SkillKey) = 0
                        AvailableSlots.Items(n) = LoadSlot(Slot)

                        'update the dataset
                        Row("Ranks") = ConvertToDouble(Row("Ranks")) - RanksAssigned
                        Row("Final") = Rules.Formatting.FormatModifier(CInt(SkillRank.Final))
                        Row("LevelRanks") = 0
                    End If
                Else
                    Exit For
                End If
            Next

            'update ui
            AvailableSlots.Items(0).Selected = True
            AvailableSlots.Items(0).EnsureVisible()
            AvailableSlots.EndUpdate()
            SkillPointsRemaining.Text = PointsAvailable.ToString
            If PointsAvailable = 0 Then RaiseEvent EnableNext(False) Else RaiseEvent DisableNext()
            UpdateButtons()
            Changed = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Remove all assigned points
    Private Sub ResetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetAll.Click
        Character.SkillRanks = New ObjectHashtable
        For Each Item As DictionaryEntry In ExistingCharacter.SkillRanks
            Dim SkillRank As Rules.Character.SkillRank
            SkillRank = DirectCast(Item.Value, Rules.Character.SkillRank)
            SkillRank.AssignedRanks = DirectCast(SkillRank.AssignedRanks.Clone, Hashtable)
            Character.SkillRanks.Add(New Objects.ObjectKey(CStr(Item.Key)), SkillRank)
        Next
        Character.Calculate()
        Character.UpdateSkillMods()
        MasterSkillSlots = Character.Skills.GetSkillSlots
        Init(Character, ExistingCharacter)
        UpdateButtons()
    End Sub

    'Determine whether the max out buttons etc. should be enabled or disabled
    Private Sub UpdateButtons()
        Try
            'get the current row
            Dim Row As DataRow = SkillsGridView.GetDataRow(SkillsGridView.FocusedRowHandle)
            If Row Is Nothing Then Exit Sub

            'get the skill key and last slot
            Dim SkillKey As New Objects.ObjectKey(Row("SkillGuid").ToString)
            Dim LastSkillSlot As Rules.Skills.SkillSlot = CType(AvailableSlots.Items(AvailableSlots.Items.Count - 1).Tag, Rules.Skills.SkillSlot)

            'vars
            Dim RanksAssigned As Double = RanksAssignedToSkill(SkillKey)
            Dim MaxRanks As Double = MaxRanksForSlot(SkillKey, LastSkillSlot.CharacterLevel)

            'are there any points left?
            If SkillPoints - PointsUsed > 0 AndAlso RanksAssigned < MaxRanks Then MaxOut.Enabled = True Else MaxOut.Enabled = False

            'has anything been assigned to this skill            
            If RanksAssigned > 0 Then Reset.Enabled = True Else Reset.Enabled = False

            'have any points been assigned
            If PointsUsed > 0 Then ResetAll.Enabled = True Else ResetAll.Enabled = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Determine and set the current max value that should be allowed in the level ranks spin edit.
    Private Sub UpdateLevelRanksMax()
        Dim Row As DataRow = SkillsGridView.GetDataRow(SkillsGridView.FocusedRowHandle)
        If Row Is Nothing Then Exit Sub

        'get the skill key
        Dim SkillKey As New Objects.ObjectKey(Row("SkillGuid").ToString)

        'get the slot
        Dim CurrentSlot As Rules.Skills.SkillSlot = DirectCast(AvailableSlots.Items(AvailableSlots.SelectedIndices(0)).Tag, Rules.Skills.SkillSlot)

        'how many ranks assigned overall?
        Dim RanksAssignedOverall As Double
        Dim RanksAssignedSoFar As Double        
        Dim SkillRank As Rules.Character.SkillRank = Character.Skill(SkillKey)
        RanksAssignedOverall = SkillRank.RankAtLevel(Character.CharacterLevel)
        RanksAssignedSoFar = SkillRank.RankAtLevel(CurrentSlot.CharacterLevel)

        'max ranks for current slot
        Dim MaxRanks As Double = MaxRanksForSlot(SkillKey, CurrentSlot.CharacterLevel)
        Dim MaxRanksOverall As Double = MaxRanksForSlot(SkillKey, Character.CharacterLevel)
        Dim RanksLeftOverall As Double = MaxRanksOverall - RanksAssignedOverall

        'get the ranks available for this slot
        Dim IsClassSkill As Boolean = Character.Skills.IsClassSkillForClassAtLevel(CurrentSlot.ClassGuid, SkillKey, CurrentSlot.CharacterLevel)
        Dim RanksAvailableForSlot As Double = CurrentSlot.PointsRemaining
        If RanksAvailableForSlot > 0 And Not IsClassSkill Then RanksAvailableForSlot /= 2

        'determine max ranks for the slot
        If RanksAvailableForSlot > RanksLeftOverall Then RanksAvailableForSlot = RanksLeftOverall
        Dim RanksAssignedInThisSlot As Double = CDbl(CurrentSlot.SkillRanksAssigned(SkillKey))
        If RanksAssignedSoFar + RanksAvailableForSlot > MaxRanks Then RanksAvailableForSlot = MaxRanks - RanksAssignedSoFar

        'set the editor max value
        LevelRanksSpin.MaxValue = New Decimal(RanksAvailableForSlot + RanksAssignedInThisSlot)
        If IsClassSkill Then LevelRanksSpin.Increment = 1 Else LevelRanksSpin.Increment = 0.5D

        ''determine the new max value for the current skill
        'Select Case Row("ClassSkill").ToString
        '    Case "Class"
        '        LevelRanksSpin.Increment = 1

        '        Dim Slot As Rules.Skills.SkillSlot = SelectedSlot
        '        Dim SlotIndex As Integer = AvailableSlots.SelectedIndices(0)
        '        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1
        '        Dim RanksSoFar, RanksThisLevel As Double
        '        Dim LevelGap, MaxThisLevel As Double
        '        Dim SmallestGap As Double = 1000

        '        'Go through the past slots
        '        For i As Integer = 0 To SlotIndex
        '            RanksThisLevel = CType(CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot).SkillRanksAssigned(New Objects.ObjectKey(Row("SkillGuid").ToString)), Double)
        '            RanksSoFar += RanksThisLevel
        '        Next

        '        Dim SkillRank As Rules.Character.SkillRank = Character.Skill(New Objects.ObjectKey(Row("SkillGuid").ToString))
        '        RanksSoFar += SkillRank.Ranks

        '        Dim PastMAX As Double = (MaxClassRanks - RanksSoFar) + ConvertToDouble(Row("LevelRanks"))

        '        'Check future slots - already is a class skill (maxlevel)  - no need to check for that
        '        If MaxIndex > SlotIndex Then
        '            For i As Integer = (SlotIndex + 1) To MaxIndex
        '                Slot = CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot)
        '                RanksThisLevel = CType(Slot.SkillRanksAssigned(New Objects.ObjectKey(Row("SkillGuid").ToString)), Double)
        '                RanksSoFar += RanksThisLevel
        '                MaxThisLevel = Rules.ExperienceAndLevelling.LevelDependentBenefits(Slot.CharacterLevel).ClassSkillMaxRanks
        '                'Ranks this level needs to include this level and sum of previous
        '                LevelGap = MaxThisLevel - RanksSoFar

        '                If LevelGap < SmallestGap Then SmallestGap = LevelGap
        '            Next
        '        End If

        '        Dim FutureMAX As Double = SmallestGap + ConvertToDouble(Row("LevelRanks"))
        '        LevelRanksSpin.MaxValue = New Decimal(Math.Min(PastMAX, FutureMAX))

        '    Case "Cross-Class"

        '        LevelRanksSpin.Increment = 0.5D

        '        Dim Slot As Rules.Skills.SkillSlot = SelectedSlot
        '        Dim SlotIndex As Integer = AvailableSlots.SelectedIndices(0)
        '        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1
        '        Dim RanksSoFar, RanksThisLevel As Double
        '        Dim LevelGap, MaxThisLevel As Double
        '        Dim SmallestGap As Double = 1000

        '        'Go through the past slots
        '        For i As Integer = 0 To SlotIndex
        '            RanksThisLevel = CType(CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot).SkillRanksAssigned(New Objects.ObjectKey(Row("SkillGuid").ToString)), Double)
        '            RanksSoFar += RanksThisLevel
        '        Next

        '        Dim SkillRank As Rules.Character.SkillRank = Character.Skill(New Objects.ObjectKey(Row("SkillGuid").ToString))
        '        RanksSoFar += SkillRank.Ranks

        '        Dim PastMAX As Double
        '        If Character.Skills.IsClassSkillAtLevel(SkillRank.SkillGuid, Slot.CharacterLevel) Then
        '            PastMAX = (MaxClassRanks - RanksSoFar) + ConvertToDouble(Row("LevelRanks"))
        '        Else
        '            PastMAX = (MaxCrossClassRanks - RanksSoFar) + ConvertToDouble(Row("LevelRanks"))
        '        End If

        '        'Check future slots
        '        If MaxIndex > SlotIndex Then
        '            For i As Integer = (SlotIndex + 1) To MaxIndex
        '                Slot = CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot)
        '                RanksThisLevel = CType(Slot.SkillRanksAssigned(New Objects.ObjectKey(Row("SkillGuid").ToString)), Double)
        '                RanksSoFar += RanksThisLevel
        '                MaxThisLevel = MaxRanksForSlot(SkillRank.SkillGuid, Slot.CharacterLevel)

        '                LevelGap = MaxThisLevel - RanksSoFar

        '                If LevelGap < SmallestGap Then SmallestGap = LevelGap
        '            Next
        '        End If

        '        Dim FutureMAX As Double = SmallestGap + ConvertToDouble(Row("LevelRanks"))
        '        LevelRanksSpin.MaxValue = New Decimal(Math.Min(PastMAX, FutureMAX))

        'End Select
    End Sub

    'Get the 
    Private Function RanksAssignedToSkill(ByVal SkillKey As Objects.ObjectKey) As Double
        Dim Ranks As Double = 0
        For i As Integer = 0 To AvailableSlots.Items.Count - 1
            Ranks += CType(CType(AvailableSlots.Items(i).Tag, Rules.Skills.SkillSlot).SkillRanksAssigned(SkillKey), Double)
        Next
        Return Ranks
    End Function

    'Get the max ranks allowed at a particular slot i.e. character level
    Private Function MaxRanksForSlot(ByVal SkillKey As Objects.ObjectKey, ByVal Level As Integer) As Double
        If Character.Skills.IsClassSkillAtLevel(SkillKey, Level) Then
            Return Rules.ExperienceAndLevelling.LevelDependentBenefits(Level).ClassSkillMaxRanks
        Else
            Return Rules.ExperienceAndLevelling.LevelDependentBenefits(Level).CrossClassSkillMaxRanks
        End If
    End Function

    'hack to update slots list view - avoids spinedit timerstart bug
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        CancelRowChange = False
        SkillsGrid.Enabled = True
        AvailableSlots_SelectedIndexChanged(Nothing, Nothing)
        SkillsGridView.RefreshData()
    End Sub

    'Reload the selected slot when any sorting takes place
    'Private Sub GridView1_ColumnChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.EndSorting
    '    AvailableSlots_SelectedIndexChanged(Nothing, Nothing)
    'End Sub

#Region "Paint Events"

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim rect As Rectangle = Panel1.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Dim rect As Rectangle = Panel2.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        Dim rect As Rectangle = Panel3.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

#End Region

End Class
