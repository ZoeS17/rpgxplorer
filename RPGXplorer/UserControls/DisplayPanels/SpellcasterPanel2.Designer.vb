<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpellcasterPanel2
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BottomPanel = New System.Windows.Forms.Panel
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.SpellNotes = New DevExpress.XtraEditors.MemoEdit
        Me.TopPanel = New System.Windows.Forms.Panel
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.SpellsPerDayGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Spells = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level0 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SPDSpin = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Level1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Level9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SpellPointsSpin = New DevExpress.XtraEditors.SpinEdit
        Me.MiddlePanel = New System.Windows.Forms.Panel
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.SpellsKnownGrid = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.PanelControl36 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.CasterLevel = New DevExpress.XtraEditors.TextEdit
        Me.BottomPanel.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.SpellNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SpellsPerDayGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPDSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SpellPointsSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiddlePanel.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.SpellsKnownGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl36, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl36.SuspendLayout()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BottomPanel
        '
        Me.BottomPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomPanel.BackColor = System.Drawing.Color.Transparent
        Me.BottomPanel.Controls.Add(Me.GroupControl3)
        Me.BottomPanel.Location = New System.Drawing.Point(15, 240)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(675, 295)
        Me.ToolTipController.SetSuperTip(Me.BottomPanel, Nothing)
        Me.BottomPanel.TabIndex = 246
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SpellNotes)
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(558, 200)
        Me.ToolTipController.SetSuperTip(Me.GroupControl3, Nothing)
        Me.GroupControl3.TabIndex = 8
        Me.GroupControl3.Text = "Notes"
        '
        'SpellNotes
        '
        Me.SpellNotes.CausesValidation = False
        Me.SpellNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpellNotes.EditValue = ""
        Me.SpellNotes.Location = New System.Drawing.Point(2, 20)
        Me.SpellNotes.Name = "SpellNotes"
        Me.SpellNotes.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SpellNotes.Properties.Appearance.Options.UseBackColor = True
        Me.SpellNotes.Size = New System.Drawing.Size(554, 178)
        Me.SpellNotes.TabIndex = 2
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopPanel.Controls.Add(Me.GroupControl1)
        Me.TopPanel.Location = New System.Drawing.Point(15, 50)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(615, 115)
        Me.ToolTipController.SetSuperTip(Me.TopPanel, Nothing)
        Me.TopPanel.TabIndex = 243
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SpellsPerDayGrid)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(558, 106)
        Me.ToolTipController.SetSuperTip(Me.GroupControl1, Nothing)
        Me.GroupControl1.TabIndex = 578
        Me.GroupControl1.Text = "Spells Per Day"
        '
        'SpellsPerDayGrid
        '
        Me.SpellsPerDayGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpellsPerDayGrid.EmbeddedNavigator.Name = ""
        Me.SpellsPerDayGrid.Location = New System.Drawing.Point(2, 20)
        Me.SpellsPerDayGrid.MainView = Me.GridView1
        Me.SpellsPerDayGrid.Name = "SpellsPerDayGrid"
        Me.SpellsPerDayGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SPDSpin})
        Me.SpellsPerDayGrid.Size = New System.Drawing.Size(554, 84)
        Me.SpellsPerDayGrid.TabIndex = 1
        Me.SpellsPerDayGrid.ToolTipController = Me.ToolTipController
        Me.SpellsPerDayGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.BorderColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.ForeColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.Empty.Options.UseBorderColor = True
        Me.GridView1.Appearance.Empty.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Spells, Me.Level0, Me.Level1, Me.Level2, Me.Level3, Me.Level4, Me.Level5, Me.Level6, Me.Level7, Me.Level8, Me.Level9})
        Me.GridView1.GridControl = Me.SpellsPerDayGrid
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsHint.ShowCellHints = False
        Me.GridView1.OptionsLayout.Columns.StoreLayout = False
        Me.GridView1.OptionsLayout.StoreDataSettings = False
        Me.GridView1.OptionsLayout.StoreVisualOptions = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'Spells
        '
        Me.Spells.AppearanceCell.Options.UseTextOptions = True
        Me.Spells.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.Spells.AppearanceHeader.Options.UseTextOptions = True
        Me.Spells.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Spells.Caption = "Spells"
        Me.Spells.FieldName = "Name"
        Me.Spells.Name = "Spells"
        Me.Spells.OptionsColumn.AllowEdit = False
        Me.Spells.OptionsColumn.AllowFocus = False
        Me.Spells.OptionsColumn.FixedWidth = True
        Me.Spells.OptionsColumn.ReadOnly = True
        Me.Spells.Visible = True
        Me.Spells.VisibleIndex = 0
        Me.Spells.Width = 100
        '
        'Level0
        '
        Me.Level0.AppearanceCell.Options.UseTextOptions = True
        Me.Level0.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level0.AppearanceHeader.Options.UseTextOptions = True
        Me.Level0.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level0.Caption = "0th"
        Me.Level0.ColumnEdit = Me.SPDSpin
        Me.Level0.FieldName = "L0"
        Me.Level0.Name = "Level0"
        Me.Level0.ToolTip = "0th Level Spells per Day"
        Me.Level0.Visible = True
        Me.Level0.VisibleIndex = 1
        Me.Level0.Width = 45
        '
        'SPDSpin
        '
        Me.SPDSpin.Appearance.Options.UseTextOptions = True
        Me.SPDSpin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SPDSpin.AutoHeight = False
        Me.SPDSpin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SPDSpin.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.SPDSpin.IsFloatValue = False
        Me.SPDSpin.Mask.EditMask = "N00"
        Me.SPDSpin.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.SPDSpin.Name = "SPDSpin"
        Me.SPDSpin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'Level1
        '
        Me.Level1.AppearanceCell.Options.UseTextOptions = True
        Me.Level1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level1.AppearanceHeader.Options.UseTextOptions = True
        Me.Level1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level1.Caption = "1st"
        Me.Level1.ColumnEdit = Me.SPDSpin
        Me.Level1.FieldName = "L1"
        Me.Level1.Name = "Level1"
        Me.Level1.ToolTip = "1st Level Spells per Day"
        Me.Level1.Visible = True
        Me.Level1.VisibleIndex = 2
        Me.Level1.Width = 45
        '
        'Level2
        '
        Me.Level2.AppearanceCell.Options.UseTextOptions = True
        Me.Level2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level2.AppearanceHeader.Options.UseTextOptions = True
        Me.Level2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level2.Caption = "2nd"
        Me.Level2.ColumnEdit = Me.SPDSpin
        Me.Level2.FieldName = "L2"
        Me.Level2.Name = "Level2"
        Me.Level2.ToolTip = "2nd Level Spells per Day"
        Me.Level2.Visible = True
        Me.Level2.VisibleIndex = 3
        Me.Level2.Width = 45
        '
        'Level3
        '
        Me.Level3.AppearanceCell.Options.UseTextOptions = True
        Me.Level3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level3.AppearanceHeader.Options.UseTextOptions = True
        Me.Level3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level3.Caption = "3rd"
        Me.Level3.ColumnEdit = Me.SPDSpin
        Me.Level3.FieldName = "L3"
        Me.Level3.Name = "Level3"
        Me.Level3.ToolTip = "3rd Level Spells per Day"
        Me.Level3.Visible = True
        Me.Level3.VisibleIndex = 4
        Me.Level3.Width = 45
        '
        'Level4
        '
        Me.Level4.AppearanceCell.Options.UseTextOptions = True
        Me.Level4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level4.AppearanceHeader.Options.UseTextOptions = True
        Me.Level4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level4.Caption = "4th"
        Me.Level4.ColumnEdit = Me.SPDSpin
        Me.Level4.FieldName = "L4"
        Me.Level4.Name = "Level4"
        Me.Level4.ToolTip = "4th Level Spells per Day"
        Me.Level4.Visible = True
        Me.Level4.VisibleIndex = 5
        Me.Level4.Width = 45
        '
        'Level5
        '
        Me.Level5.AppearanceCell.Options.UseTextOptions = True
        Me.Level5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level5.AppearanceHeader.Options.UseTextOptions = True
        Me.Level5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level5.Caption = "5th"
        Me.Level5.ColumnEdit = Me.SPDSpin
        Me.Level5.FieldName = "L5"
        Me.Level5.Name = "Level5"
        Me.Level5.ToolTip = "5th Level Spells per Day"
        Me.Level5.Visible = True
        Me.Level5.VisibleIndex = 6
        Me.Level5.Width = 45
        '
        'Level6
        '
        Me.Level6.AppearanceCell.Options.UseTextOptions = True
        Me.Level6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level6.AppearanceHeader.Options.UseTextOptions = True
        Me.Level6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level6.Caption = "6th"
        Me.Level6.ColumnEdit = Me.SPDSpin
        Me.Level6.FieldName = "L6"
        Me.Level6.Name = "Level6"
        Me.Level6.ToolTip = "6th Level Spells per Day"
        Me.Level6.Visible = True
        Me.Level6.VisibleIndex = 7
        Me.Level6.Width = 45
        '
        'Level7
        '
        Me.Level7.AppearanceCell.Options.UseTextOptions = True
        Me.Level7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level7.AppearanceHeader.Options.UseTextOptions = True
        Me.Level7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level7.Caption = "7th"
        Me.Level7.ColumnEdit = Me.SPDSpin
        Me.Level7.FieldName = "L7"
        Me.Level7.Name = "Level7"
        Me.Level7.ToolTip = "7th Level Spells per Day"
        Me.Level7.Visible = True
        Me.Level7.VisibleIndex = 8
        Me.Level7.Width = 45
        '
        'Level8
        '
        Me.Level8.AppearanceCell.Options.UseTextOptions = True
        Me.Level8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level8.AppearanceHeader.Options.UseTextOptions = True
        Me.Level8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level8.Caption = "8th"
        Me.Level8.ColumnEdit = Me.SPDSpin
        Me.Level8.FieldName = "L8"
        Me.Level8.Name = "Level8"
        Me.Level8.ToolTip = "8th Level Spells per Day"
        Me.Level8.Visible = True
        Me.Level8.VisibleIndex = 9
        Me.Level8.Width = 45
        '
        'Level9
        '
        Me.Level9.AppearanceCell.Options.UseTextOptions = True
        Me.Level9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level9.AppearanceHeader.Options.UseTextOptions = True
        Me.Level9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level9.Caption = "9th"
        Me.Level9.ColumnEdit = Me.SPDSpin
        Me.Level9.FieldName = "L9"
        Me.Level9.Name = "Level9"
        Me.Level9.ToolTip = "9th Level Spells per Day"
        Me.Level9.Visible = True
        Me.Level9.VisibleIndex = 10
        Me.Level9.Width = 45
        '
        'ToolTipController
        '
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.SpellPointsSpin)
        Me.PanelControl1.Location = New System.Drawing.Point(145, 15)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(137, 24)
        Me.ToolTipController.SetSuperTip(Me.PanelControl1, Nothing)
        Me.PanelControl1.TabIndex = 654
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 20)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Spell Points"
        '
        'SpellPointsSpin
        '
        Me.SpellPointsSpin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpellPointsSpin.Location = New System.Drawing.Point(75, 2)
        Me.SpellPointsSpin.Name = "SpellPointsSpin"
        Me.SpellPointsSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.SpellPointsSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpellPointsSpin.Properties.AutoHeight = False
        Me.SpellPointsSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpellPointsSpin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.SpellPointsSpin.Properties.IsFloatValue = False
        Me.SpellPointsSpin.Properties.Mask.BeepOnError = True
        Me.SpellPointsSpin.Properties.Mask.EditMask = "d"
        Me.SpellPointsSpin.Properties.Mask.ShowPlaceHolders = False
        Me.SpellPointsSpin.Properties.MaxLength = 3
        Me.SpellPointsSpin.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.SpellPointsSpin.Size = New System.Drawing.Size(60, 20)
        Me.SpellPointsSpin.TabIndex = 1
        '
        'MiddlePanel
        '
        Me.MiddlePanel.BackColor = System.Drawing.Color.Transparent
        Me.MiddlePanel.Controls.Add(Me.GroupControl2)
        Me.MiddlePanel.Location = New System.Drawing.Point(15, 165)
        Me.MiddlePanel.Name = "MiddlePanel"
        Me.MiddlePanel.Size = New System.Drawing.Size(615, 75)
        Me.ToolTipController.SetSuperTip(Me.MiddlePanel, Nothing)
        Me.MiddlePanel.TabIndex = 244
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SpellsKnownGrid)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(558, 65)
        Me.ToolTipController.SetSuperTip(Me.GroupControl2, Nothing)
        Me.GroupControl2.TabIndex = 578
        Me.GroupControl2.Text = "Spells Known"
        '
        'SpellsKnownGrid
        '
        Me.SpellsKnownGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpellsKnownGrid.EmbeddedNavigator.Name = ""
        Me.SpellsKnownGrid.Location = New System.Drawing.Point(2, 20)
        Me.SpellsKnownGrid.MainView = Me.GridView2
        Me.SpellsKnownGrid.Name = "SpellsKnownGrid"
        Me.SpellsKnownGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit2, Me.RepositoryItemTextEdit1})
        Me.SpellsKnownGrid.Size = New System.Drawing.Size(554, 43)
        Me.SpellsKnownGrid.TabIndex = 0
        Me.SpellsKnownGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.Empty.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.Empty.ForeColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.Empty.Options.UseBorderColor = True
        Me.GridView2.Appearance.Empty.Options.UseForeColor = True
        Me.GridView2.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GridView2.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.GridView2.GridControl = Me.SpellsKnownGrid
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowColumnResizing = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.EnableMasterViewMode = False
        Me.GridView2.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView2.OptionsFilter.AllowMRUFilterList = False
        Me.GridView2.OptionsLayout.Columns.StoreLayout = False
        Me.GridView2.OptionsLayout.StoreDataSettings = False
        Me.GridView2.OptionsLayout.StoreVisualOptions = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView2.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Spells"
        Me.GridColumn1.FieldName = "Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "0th"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn2.FieldName = "L0"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.ToolTip = "0th Level Spells Known"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 45
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "1st"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn3.FieldName = "L1"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.ToolTip = "1st Level Spells Known"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 45
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "2nd"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn12.FieldName = "L2"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.ToolTip = "2nd Level Spells Known"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        Me.GridColumn12.Width = 45
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "3rd"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn13.FieldName = "L3"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.ToolTip = "3rd Level Spells Known"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 45
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "4th"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn14.FieldName = "L4"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.ToolTip = "4th Level Spells Known"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.GridColumn14.Width = 45
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "5th"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn15.FieldName = "L5"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.ToolTip = "5th Level Spells Known"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.GridColumn15.Width = 45
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "6th"
        Me.GridColumn16.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn16.FieldName = "L6"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.ToolTip = "6th Level Spells Known"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 7
        Me.GridColumn16.Width = 45
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "7th"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn17.FieldName = "L7"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.ToolTip = "7th Level Spells Known"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 8
        Me.GridColumn17.Width = 45
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "8th"
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn18.FieldName = "L8"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.ToolTip = "8th Level Spells Known"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 9
        Me.GridColumn18.Width = 45
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "9th"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn19.FieldName = "L9"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.ToolTip = "9th Level Spells Known"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 10
        Me.GridColumn19.Width = 45
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemSpinEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit2.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemSpinEdit2.IsFloatValue = False
        Me.RepositoryItemSpinEdit2.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        Me.RepositoryItemSpinEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'PanelControl36
        '
        Me.PanelControl36.Controls.Add(Me.LabelControl29)
        Me.PanelControl36.Controls.Add(Me.CasterLevel)
        Me.PanelControl36.Location = New System.Drawing.Point(15, 15)
        Me.PanelControl36.Name = "PanelControl36"
        Me.PanelControl36.Size = New System.Drawing.Size(126, 24)
        Me.ToolTipController.SetSuperTip(Me.PanelControl36, Nothing)
        Me.PanelControl36.TabIndex = 654
        '
        'LabelControl29
        '
        Me.LabelControl29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseTextOptions = True
        Me.LabelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl29.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl29.Location = New System.Drawing.Point(1, 2)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(74, 20)
        Me.LabelControl29.TabIndex = 34
        Me.LabelControl29.Text = "Caster Level"
        '
        'CasterLevel
        '
        Me.CasterLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CasterLevel.EditValue = "-"
        Me.CasterLevel.Location = New System.Drawing.Point(80, 2)
        Me.CasterLevel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.CasterLevel.Name = "CasterLevel"
        Me.CasterLevel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.CasterLevel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CasterLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CasterLevel.Properties.Appearance.Options.UseBackColor = True
        Me.CasterLevel.Properties.Appearance.Options.UseFont = True
        Me.CasterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CasterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CasterLevel.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CasterLevel.Properties.AutoHeight = False
        Me.CasterLevel.Properties.ReadOnly = True
        Me.CasterLevel.Size = New System.Drawing.Size(44, 20)
        Me.CasterLevel.TabIndex = 13
        Me.CasterLevel.TabStop = False
        '
        'SpellcasterPanel2
        '
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl36)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MiddlePanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Name = "SpellcasterPanel2"
        Me.Size = New System.Drawing.Size(705, 685)
        Me.ToolTipController.SetSuperTip(Me, Nothing)
        Me.BottomPanel.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.SpellNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.SpellsPerDayGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPDSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SpellPointsSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiddlePanel.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.SpellsKnownGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl36, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl36.ResumeLayout(False)
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Public WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents BottomPanel As System.Windows.Forms.Panel
    Public WithEvents SpellNotes As DevExpress.XtraEditors.MemoEdit
    Public WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents TopPanel As System.Windows.Forms.Panel
    Public WithEvents SpellPointsSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MiddlePanel As System.Windows.Forms.Panel
    Public WithEvents SpellsKnownGrid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Public WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Public WithEvents PanelControl36 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Private WithEvents CasterLevel As DevExpress.XtraEditors.TextEdit
    Public WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents SpellsPerDayGrid As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents Spells As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level0 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents SPDSpin As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Public WithEvents Level1 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level2 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level3 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level4 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level5 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level6 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level7 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level8 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Level9 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Public WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl

End Class
