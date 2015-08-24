Imports DevExpress.XtraReports.UI

Public Class CasterLevelSpellSave
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ClassName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level0 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level1 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level2 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level3 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level4 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level5 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level6 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level7 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level8 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level9 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SpellPoints As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Level As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents CasterLevelDataset1 As RPGXplorer.CasterLevelDataset
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.ClassName = New DevExpress.XtraReports.UI.XRTableCell
        Me.CasterLevelDataset1 = New RPGXplorer.CasterLevelDataset
        Me.Level = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level0 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Level9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SpellPoints = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasterLevelDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Height = 17
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.Gray
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTable2.Location = New System.Drawing.Point(5, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.ParentStyleUsing.UseBorderColor = False
        Me.XrTable2.ParentStyleUsing.UseBorders = False
        Me.XrTable2.ParentStyleUsing.UseFont = False
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(719, 17)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ClassName, Me.Level, Me.Level0, Me.Level1, Me.Level2, Me.Level3, Me.Level4, Me.Level5, Me.Level6, Me.Level7, Me.Level8, Me.Level9, Me.XrTableCell18, Me.SpellPoints})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(719, 17)
        '
        'ClassName
        '
        Me.ClassName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.ClassName", "")})
        Me.ClassName.Location = New System.Drawing.Point(0, 0)
        Me.ClassName.Name = "ClassName"
        Me.ClassName.Size = New System.Drawing.Size(120, 17)
        Me.ClassName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CasterLevelDataset1
        '
        Me.CasterLevelDataset1.DataSetName = "CasterLevelDataset"
        Me.CasterLevelDataset1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Level
        '
        Me.Level.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.CasterLevel", "")})
        Me.Level.Location = New System.Drawing.Point(120, 0)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(47, 17)
        Me.Level.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level0
        '
        Me.Level0.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level0", "")})
        Me.Level0.Location = New System.Drawing.Point(167, 0)
        Me.Level0.Name = "Level0"
        Me.Level0.Size = New System.Drawing.Size(36, 17)
        Me.Level0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level1
        '
        Me.Level1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level1", "")})
        Me.Level1.Location = New System.Drawing.Point(203, 0)
        Me.Level1.Name = "Level1"
        Me.Level1.Size = New System.Drawing.Size(37, 17)
        Me.Level1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level2
        '
        Me.Level2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level2", "")})
        Me.Level2.Location = New System.Drawing.Point(240, 0)
        Me.Level2.Name = "Level2"
        Me.Level2.Size = New System.Drawing.Size(36, 17)
        Me.Level2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level3
        '
        Me.Level3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level3", "")})
        Me.Level3.Location = New System.Drawing.Point(276, 0)
        Me.Level3.Name = "Level3"
        Me.Level3.Size = New System.Drawing.Size(35, 17)
        Me.Level3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level4
        '
        Me.Level4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level4", "")})
        Me.Level4.Location = New System.Drawing.Point(311, 0)
        Me.Level4.Name = "Level4"
        Me.Level4.Size = New System.Drawing.Size(37, 17)
        Me.Level4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level5
        '
        Me.Level5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level5", "")})
        Me.Level5.Location = New System.Drawing.Point(348, 0)
        Me.Level5.Name = "Level5"
        Me.Level5.Size = New System.Drawing.Size(34, 17)
        Me.Level5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level6
        '
        Me.Level6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level6", "")})
        Me.Level6.Location = New System.Drawing.Point(382, 0)
        Me.Level6.Name = "Level6"
        Me.Level6.Size = New System.Drawing.Size(37, 17)
        Me.Level6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level7
        '
        Me.Level7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level7", "")})
        Me.Level7.Location = New System.Drawing.Point(419, 0)
        Me.Level7.Name = "Level7"
        Me.Level7.Size = New System.Drawing.Size(36, 17)
        Me.Level7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level8
        '
        Me.Level8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level8", "")})
        Me.Level8.Location = New System.Drawing.Point(455, 0)
        Me.Level8.Name = "Level8"
        Me.Level8.Size = New System.Drawing.Size(37, 17)
        Me.Level8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Level9
        '
        Me.Level9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.Level9", "")})
        Me.Level9.Location = New System.Drawing.Point(492, 0)
        Me.Level9.Name = "Level9"
        Me.Level9.Size = New System.Drawing.Size(36, 17)
        Me.Level9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Location = New System.Drawing.Point(528, 0)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.ParentStyleUsing.UseBorders = False
        Me.XrTableCell18.Size = New System.Drawing.Size(11, 17)
        '
        'SpellPoints
        '
        Me.SpellPoints.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.SpellPoints.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CasterLevelDataset1, "CasterLevel.SpellPoints", "")})
        Me.SpellPoints.Location = New System.Drawing.Point(539, 0)
        Me.SpellPoints.Name = "SpellPoints"
        Me.SpellPoints.ParentStyleUsing.UseBorders = False
        Me.SpellPoints.Size = New System.Drawing.Size(180, 17)
        Me.SpellPoints.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrTable1})
        Me.PageHeader.Height = 55
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel2.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.Location = New System.Drawing.Point(544, 5)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseBackColor = False
        Me.XrLabel2.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.ParentStyleUsing.UseForeColor = False
        Me.XrLabel2.Size = New System.Drawing.Size(180, 16)
        Me.XrLabel2.Text = " SPELL POINTS"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel1.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseBackColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(528, 16)
        Me.XrLabel1.Text = " CASTER LEVEL and SPELL SAVE DC"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable1
        '
        Me.XrTable1.BorderColor = System.Drawing.Color.Gray
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.Location = New System.Drawing.Point(5, 21)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.ParentStyleUsing.UseBorderColor = False
        Me.XrTable1.ParentStyleUsing.UseBorders = False
        Me.XrTable1.ParentStyleUsing.UseFont = False
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4})
        Me.XrTable1.Size = New System.Drawing.Size(719, 34)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell35, Me.XrTableCell45, Me.XrTableCell43})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(719, 17)
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.ParentStyleUsing.UseBorders = False
        Me.XrTableCell27.Size = New System.Drawing.Size(120, 17)
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.Location = New System.Drawing.Point(120, 0)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.ParentStyleUsing.UseBorders = False
        Me.XrTableCell28.Size = New System.Drawing.Size(47, 17)
        Me.XrTableCell28.Text = "Caster"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Location = New System.Drawing.Point(167, 0)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Size = New System.Drawing.Size(361, 17)
        Me.XrTableCell35.Text = "Spell Save DC"
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell45
        '
        Me.XrTableCell45.Location = New System.Drawing.Point(528, 0)
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.ParentStyleUsing.UseBorders = False
        Me.XrTableCell45.Size = New System.Drawing.Size(11, 17)
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell43.Location = New System.Drawing.Point(539, 0)
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.ParentStyleUsing.UseBorders = False
        Me.XrTableCell43.Size = New System.Drawing.Size(180, 17)
        Me.XrTableCell43.Text = "Spell"
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell36, Me.XrTableCell38, Me.XrTableCell34, Me.XrTableCell37, Me.XrTableCell33, Me.XrTableCell29, Me.XrTableCell41, Me.XrTableCell40, Me.XrTableCell39, Me.XrTableCell42, Me.XrTableCell46, Me.XrTableCell44})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(719, 17)
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Size = New System.Drawing.Size(120, 17)
        Me.XrTableCell30.Text = "Class"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Location = New System.Drawing.Point(120, 0)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Size = New System.Drawing.Size(47, 17)
        Me.XrTableCell31.Text = "Level"
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Location = New System.Drawing.Point(167, 0)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Size = New System.Drawing.Size(36, 17)
        Me.XrTableCell36.Text = "0th"
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Location = New System.Drawing.Point(203, 0)
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Size = New System.Drawing.Size(37, 17)
        Me.XrTableCell38.Text = "1st"
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Location = New System.Drawing.Point(240, 0)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Size = New System.Drawing.Size(36, 17)
        Me.XrTableCell34.Text = "2nd"
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Location = New System.Drawing.Point(276, 0)
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Size = New System.Drawing.Size(35, 17)
        Me.XrTableCell37.Text = "3rd"
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Location = New System.Drawing.Point(311, 0)
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Size = New System.Drawing.Size(37, 17)
        Me.XrTableCell33.Text = "4th"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Location = New System.Drawing.Point(348, 0)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Size = New System.Drawing.Size(34, 17)
        Me.XrTableCell29.Text = "5th"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Location = New System.Drawing.Point(382, 0)
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Size = New System.Drawing.Size(37, 17)
        Me.XrTableCell41.Text = "6th"
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Location = New System.Drawing.Point(419, 0)
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Size = New System.Drawing.Size(36, 17)
        Me.XrTableCell40.Text = "7th"
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Location = New System.Drawing.Point(455, 0)
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Size = New System.Drawing.Size(37, 17)
        Me.XrTableCell39.Text = "8th"
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Location = New System.Drawing.Point(492, 0)
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Size = New System.Drawing.Size(36, 17)
        Me.XrTableCell42.Text = "9th"
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell46
        '
        Me.XrTableCell46.Location = New System.Drawing.Point(528, 0)
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.ParentStyleUsing.UseBorders = False
        Me.XrTableCell46.Size = New System.Drawing.Size(11, 17)
        '
        'XrTableCell44
        '
        Me.XrTableCell44.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell44.Location = New System.Drawing.Point(539, 0)
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.ParentStyleUsing.UseBorders = False
        Me.XrTableCell44.Size = New System.Drawing.Size(180, 17)
        Me.XrTableCell44.Text = "Points"
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'CasterLevelSpellSave
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.DataMember = "CasterLevel"
        Me.DataSource = Me.CasterLevelDataset1
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasterLevelDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public data As CasterLevelDataset

    Private Sub CasterLevelSpellSave_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            ClassName.DataBindings.Add("Text", DataSource, "CasterLevel.ClassName")
            Level.DataBindings.Add("Text", DataSource, "CasterLevel.Level")
            Level0.DataBindings.Add("Text", DataSource, "CasterLevel.L0")
            Level1.DataBindings.Add("Text", DataSource, "CasterLevel.L1")
            Level2.DataBindings.Add("Text", DataSource, "CasterLevel.L2")
            Level3.DataBindings.Add("Text", DataSource, "CasterLevel.L3")
            Level4.DataBindings.Add("Text", DataSource, "CasterLevel.L4")
            Level5.DataBindings.Add("Text", DataSource, "CasterLevel.L5")
            Level6.DataBindings.Add("Text", DataSource, "CasterLevel.L6")
            Level7.DataBindings.Add("Text", DataSource, "CasterLevel.L7")
            Level8.DataBindings.Add("Text", DataSource, "CasterLevel.L8")
            Level9.DataBindings.Add("Text", DataSource, "CasterLevel.L9")
            SpellPoints.DataBindings.Add("Text", DataSource, "CasterLevel.SP")

            Me.DataSource = data
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

