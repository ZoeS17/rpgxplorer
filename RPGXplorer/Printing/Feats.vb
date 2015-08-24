Imports DevExpress.XtraReports.UI

Public Class Feats
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
    Public WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents FeatNameCell As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents FeatDescriptionCell As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.FeatNameCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.FeatDescriptionCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 16
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
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
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable1.Size = New System.Drawing.Size(719, 16)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.FeatNameCell, Me.FeatDescriptionCell})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(719, 16)
        '
        'FeatNameCell
        '
        Me.FeatNameCell.BorderColor = System.Drawing.Color.Gray
        Me.FeatNameCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FeatNameCell.Location = New System.Drawing.Point(0, 0)
        Me.FeatNameCell.Name = "FeatNameCell"
        Me.FeatNameCell.ParentStyleUsing.UseBorderColor = False
        Me.FeatNameCell.ParentStyleUsing.UseBorders = False
        Me.FeatNameCell.Size = New System.Drawing.Size(200, 16)
        Me.FeatNameCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FeatDescriptionCell
        '
        Me.FeatDescriptionCell.BorderColor = System.Drawing.Color.Gray
        Me.FeatDescriptionCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FeatDescriptionCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeatDescriptionCell.Location = New System.Drawing.Point(200, 0)
        Me.FeatDescriptionCell.Name = "FeatDescriptionCell"
        Me.FeatDescriptionCell.ParentStyleUsing.UseBorderColor = False
        Me.FeatDescriptionCell.ParentStyleUsing.UseBorders = False
        Me.FeatDescriptionCell.ParentStyleUsing.UseFont = False
        Me.FeatDescriptionCell.Size = New System.Drawing.Size(519, 16)
        Me.FeatDescriptionCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel70})
        Me.PageHeader.Height = 29
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel70
        '
        Me.XrLabel70.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel70.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel70.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel70.ForeColor = System.Drawing.Color.White
        Me.XrLabel70.Location = New System.Drawing.Point(5, 10)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.ParentStyleUsing.UseBackColor = False
        Me.XrLabel70.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel70.ParentStyleUsing.UseBorders = False
        Me.XrLabel70.ParentStyleUsing.UseFont = False
        Me.XrLabel70.ParentStyleUsing.UseForeColor = False
        Me.XrLabel70.Size = New System.Drawing.Size(719, 16)
        Me.XrLabel70.Text = " FEATS"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Feats
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Data As FeatsDataset

    Private Sub Feats_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            FeatNameCell.DataBindings.Add("Text", DataSource, "Feats.FeatName")
            FeatDescriptionCell.DataBindings.Add("Text", DataSource, "Feats.FeatDescription")

            Me.DataSource = Data.Feats
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
