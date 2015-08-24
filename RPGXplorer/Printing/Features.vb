Imports DevExpress.XtraReports.UI

Public Class Features
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
    Public WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents FeatureName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents FeatureDescription As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.FeatureName = New DevExpress.XtraReports.UI.XRTableCell
        Me.FeatureDescription = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel
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
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable1.Size = New System.Drawing.Size(719, 16)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.FeatureName, Me.FeatureDescription})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(719, 16)
        '
        'FeatureName
        '
        Me.FeatureName.BorderColor = System.Drawing.Color.Gray
        Me.FeatureName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FeatureName.Location = New System.Drawing.Point(0, 0)
        Me.FeatureName.Name = "FeatureName"
        Me.FeatureName.ParentStyleUsing.UseBorderColor = False
        Me.FeatureName.ParentStyleUsing.UseBorders = False
        Me.FeatureName.Size = New System.Drawing.Size(200, 16)
        Me.FeatureName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FeatureDescription
        '
        Me.FeatureDescription.BorderColor = System.Drawing.Color.Gray
        Me.FeatureDescription.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FeatureDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeatureDescription.Location = New System.Drawing.Point(200, 0)
        Me.FeatureDescription.Name = "FeatureDescription"
        Me.FeatureDescription.ParentStyleUsing.UseBorderColor = False
        Me.FeatureDescription.ParentStyleUsing.UseBorders = False
        Me.FeatureDescription.ParentStyleUsing.UseFont = False
        Me.FeatureDescription.Size = New System.Drawing.Size(519, 16)
        Me.FeatureDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel73})
        Me.PageHeader.Height = 29
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel73
        '
        Me.XrLabel73.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel73.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel73.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel73.ForeColor = System.Drawing.Color.White
        Me.XrLabel73.Location = New System.Drawing.Point(5, 10)
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.ParentStyleUsing.UseBackColor = False
        Me.XrLabel73.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel73.ParentStyleUsing.UseBorders = False
        Me.XrLabel73.ParentStyleUsing.UseFont = False
        Me.XrLabel73.ParentStyleUsing.UseForeColor = False
        Me.XrLabel73.Size = New System.Drawing.Size(719, 16)
        Me.XrLabel73.Text = " FEATURES"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Features
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Data As FeaturesDataset

    Private Sub Features_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            FeatureName.DataBindings.Add("Text", DataSource, "Features.FeatureName")
            FeatureDescription.DataBindings.Add("Text", DataSource, "Features.FeatureDescription")

            Me.DataSource = Data.Features
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
End Class
