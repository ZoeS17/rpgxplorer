Imports DevExpress.XtraReports.UI

Public Class PowerBook
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
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

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    Public WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Public WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Public WithEvents SpellbookDataset1 As RPGXplorer.SpellbookDataset
    Public WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Public WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents SpellLevel As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents SpellName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SpellDescription As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.SpellbookDataset1 = New RPGXplorer.SpellbookDataset
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand
        Me.SpellLevel = New DevExpress.XtraReports.UI.XRLabel
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.SpellName = New DevExpress.XtraReports.UI.XRTableCell
        Me.SpellDescription = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.SpellbookDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.Detail.Height = 2
        Me.Detail.Name = "Detail"
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SpellbookDataset1, "CasterClass.ClassName", "")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseBackColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(719, 2)
        Me.XrLabel1.Text = " SPELLS"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel1.WordWrap = False
        '
        'SpellbookDataset1
        '
        Me.SpellbookDataset1.DataSetName = "SpellbookDataset"
        Me.SpellbookDataset1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0
        Me.PageHeader.Name = "PageHeader"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.DetailReport1})
        Me.DetailReport.DataMember = "CasterClass.CasterClassSpellLevels"
        Me.DetailReport.DataSource = Me.SpellbookDataset1
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SpellLevel})
        Me.Detail1.Height = 26
        Me.Detail1.Name = "Detail1"
        '
        'SpellLevel
        '
        Me.SpellLevel.BackColor = System.Drawing.Color.DimGray
        Me.SpellLevel.BorderColor = System.Drawing.Color.DimGray
        Me.SpellLevel.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.SpellLevel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SpellbookDataset1, "CasterClass.CasterClassSpellLevels.SpellLevel", "")})
        Me.SpellLevel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.SpellLevel.ForeColor = System.Drawing.Color.White
        Me.SpellLevel.Location = New System.Drawing.Point(5, 10)
        Me.SpellLevel.Name = "SpellLevel"
        Me.SpellLevel.ParentStyleUsing.UseBackColor = False
        Me.SpellLevel.ParentStyleUsing.UseBorderColor = False
        Me.SpellLevel.ParentStyleUsing.UseBorders = False
        Me.SpellLevel.ParentStyleUsing.UseFont = False
        Me.SpellLevel.ParentStyleUsing.UseForeColor = False
        Me.SpellLevel.Size = New System.Drawing.Size(719, 16)
        Me.SpellLevel.Text = " SPELLS"
        Me.SpellLevel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2})
        Me.DetailReport1.DataMember = "CasterClass.CasterClassSpellLevels.SpellLevelsSpell"
        Me.DetailReport1.DataSource = Me.SpellbookDataset1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail2.Height = 16
        Me.Detail2.Name = "Detail2"
        '
        'XrTable1
        '
        Me.XrTable1.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.Location = New System.Drawing.Point(5, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.ParentStyleUsing.UseBorderColor = False
        Me.XrTable1.ParentStyleUsing.UseBorders = False
        Me.XrTable1.ParentStyleUsing.UseFont = False
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(719, 16)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.SpellName, Me.SpellDescription})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(719, 16)
        '
        'SpellName
        '
        Me.SpellName.BorderColor = System.Drawing.Color.Gray
        Me.SpellName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.SpellName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SpellbookDataset1, "CasterClass.CasterClassSpellLevels.SpellLevelsSpell.SpellName", "")})
        Me.SpellName.Location = New System.Drawing.Point(0, 0)
        Me.SpellName.Name = "SpellName"
        Me.SpellName.ParentStyleUsing.UseBorderColor = False
        Me.SpellName.ParentStyleUsing.UseBorders = False
        Me.SpellName.Size = New System.Drawing.Size(146, 16)
        Me.SpellName.Text = "SpellName"
        '
        'SpellDescription
        '
        Me.SpellDescription.BorderColor = System.Drawing.Color.Gray
        Me.SpellDescription.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.SpellDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SpellbookDataset1, "CasterClass.CasterClassSpellLevels.SpellLevelsSpell.Description", "")})
        Me.SpellDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpellDescription.Location = New System.Drawing.Point(146, 0)
        Me.SpellDescription.Name = "SpellDescription"
        Me.SpellDescription.ParentStyleUsing.UseBorderColor = False
        Me.SpellDescription.ParentStyleUsing.UseBorders = False
        Me.SpellDescription.ParentStyleUsing.UseFont = False
        Me.SpellDescription.Size = New System.Drawing.Size(573, 16)
        Me.SpellDescription.Text = "SpellDescription"
        Me.SpellDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PowerBook
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.DetailReport})
        Me.DataMember = "CasterClass"
        Me.DataSource = Me.SpellbookDataset1
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.SpellbookDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Data As SpellbookDataset

    Private Sub SpellBook_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            Me.DetailReport.DataMember = "CasterClass.CasterClassSpellLevels"
            Me.DetailReport1.DataMember = "CasterClass.CasterClassSpellLevels.SpellLevelsSpell"
            Me.SpellDescription.DataBindings.Add("Text", DataSource, "CasterClass.CasterClassSpellLevels.SpellLevel")
            Me.SpellName.DataBindings.Add("Text", DataSource, "CasterClass.CasterClassSpellLevels.SpellLevelsSpell.SpellName")
            Me.SpellDescription.DataBindings.Add("Text", DataSource, "CasterClass.CasterClassSpellLevels.SpellLevelsSpell.Description")

            Me.DataSource = Data
            Me.DetailReport.DataSource = Data
            Me.DetailReport1.DataSource = Data

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
