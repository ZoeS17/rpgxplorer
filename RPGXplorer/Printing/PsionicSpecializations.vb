Imports DevExpress.XtraReports.UI

Public Class PsionicSpecializations
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(Me)
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
    Public WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Public WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents ClassName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Specializations As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.ClassName = New DevExpress.XtraReports.UI.XRTableCell
        Me.Specializations = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 17
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.Location = New System.Drawing.Point(5, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.ParentStyleUsing.UseBorderColor = False
        Me.XrTable1.ParentStyleUsing.UseBorders = False
        Me.XrTable1.ParentStyleUsing.UseFont = False
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable1.Size = New System.Drawing.Size(719, 17)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ClassName, Me.Specializations})
        Me.XrTableRow2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.ParentStyleUsing.UseFont = False
        Me.XrTableRow2.Size = New System.Drawing.Size(719, 17)
        '
        'ClassName
        '
        Me.ClassName.Location = New System.Drawing.Point(0, 0)
        Me.ClassName.Name = "ClassName"
        Me.ClassName.Size = New System.Drawing.Size(120, 17)
        Me.ClassName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Specializations
        '
        Me.Specializations.Location = New System.Drawing.Point(120, 0)
        Me.Specializations.Name = "Specializations"
        Me.Specializations.Size = New System.Drawing.Size(599, 17)
        Me.Specializations.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.PageHeader.Height = 39
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrLabel24})
        Me.XrPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.Size = New System.Drawing.Size(729, 39)
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable2.Location = New System.Drawing.Point(5, 22)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.ParentStyleUsing.UseBorderColor = False
        Me.XrTable2.ParentStyleUsing.UseBorders = False
        Me.XrTable2.ParentStyleUsing.UseFont = False
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable2.Size = New System.Drawing.Size(719, 17)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell4})
        Me.XrTableRow1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.ParentStyleUsing.UseFont = False
        Me.XrTableRow1.Size = New System.Drawing.Size(719, 17)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(120, 17)
        Me.XrTableCell1.Text = "Class"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(120, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(599, 17)
        Me.XrTableCell4.Text = "Specializations"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel24.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel24.ForeColor = System.Drawing.Color.White
        Me.XrLabel24.Location = New System.Drawing.Point(5, 6)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.ParentStyleUsing.UseBackColor = False
        Me.XrLabel24.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel24.ParentStyleUsing.UseBorders = False
        Me.XrLabel24.ParentStyleUsing.UseFont = False
        Me.XrLabel24.ParentStyleUsing.UseForeColor = False
        Me.XrLabel24.Size = New System.Drawing.Size(719, 16)
        Me.XrLabel24.Text = " PSIONIC SPECIALIZATIONS"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PsionicSpecializations
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public data As PsionocSpecializationsDataset

    Private Sub DomainsSchools_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            Me.ClassName.DataBindings.Add("Text", DataSource, "PsionicSpecializations.ClassName")
            Me.Specializations.DataBindings.Add("Text", DataSource, "PsionicSpecializations.Specializations")

            Me.DataSource = data.PsionicSpecializations
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
End Class

