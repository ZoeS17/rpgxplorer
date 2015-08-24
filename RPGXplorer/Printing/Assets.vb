Imports DevExpress.XtraReports.UI

Public Class Assets
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
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Title As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents ItemName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ItemWeight As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ItemCost As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ItemCharges As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ItemNotes As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.ItemName = New DevExpress.XtraReports.UI.XRTableCell
        Me.ItemWeight = New DevExpress.XtraReports.UI.XRTableCell
        Me.ItemCost = New DevExpress.XtraReports.UI.XRTableCell
        Me.ItemCharges = New DevExpress.XtraReports.UI.XRTableCell
        Me.ItemNotes = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Title = New DevExpress.XtraReports.UI.XRLabel
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
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(719, 16)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ItemName, Me.ItemWeight, Me.ItemCost, Me.ItemCharges, Me.ItemNotes})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(719, 16)
        '
        'ItemName
        '
        Me.ItemName.BorderColor = System.Drawing.Color.Gray
        Me.ItemName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ItemName.Location = New System.Drawing.Point(0, 0)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ParentStyleUsing.UseBorderColor = False
        Me.ItemName.ParentStyleUsing.UseBorders = False
        Me.ItemName.Size = New System.Drawing.Size(206, 16)
        Me.ItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ItemWeight
        '
        Me.ItemWeight.BorderColor = System.Drawing.Color.Gray
        Me.ItemWeight.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ItemWeight.Location = New System.Drawing.Point(206, 0)
        Me.ItemWeight.Name = "ItemWeight"
        Me.ItemWeight.ParentStyleUsing.UseBorderColor = False
        Me.ItemWeight.ParentStyleUsing.UseBorders = False
        Me.ItemWeight.Size = New System.Drawing.Size(76, 16)
        Me.ItemWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ItemCost
        '
        Me.ItemCost.BorderColor = System.Drawing.Color.Gray
        Me.ItemCost.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ItemCost.Location = New System.Drawing.Point(282, 0)
        Me.ItemCost.Name = "ItemCost"
        Me.ItemCost.ParentStyleUsing.UseBorderColor = False
        Me.ItemCost.ParentStyleUsing.UseBorders = False
        Me.ItemCost.Size = New System.Drawing.Size(94, 16)
        Me.ItemCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ItemCharges
        '
        Me.ItemCharges.BorderColor = System.Drawing.Color.Gray
        Me.ItemCharges.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ItemCharges.CanGrow = False
        Me.ItemCharges.Location = New System.Drawing.Point(376, 0)
        Me.ItemCharges.Name = "ItemCharges"
        Me.ItemCharges.ParentStyleUsing.UseBorderColor = False
        Me.ItemCharges.ParentStyleUsing.UseBorders = False
        Me.ItemCharges.Size = New System.Drawing.Size(46, 16)
        Me.ItemCharges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ItemNotes
        '
        Me.ItemNotes.BorderColor = System.Drawing.Color.Gray
        Me.ItemNotes.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ItemNotes.Location = New System.Drawing.Point(422, 0)
        Me.ItemNotes.Name = "ItemNotes"
        Me.ItemNotes.ParentStyleUsing.UseBorderColor = False
        Me.ItemNotes.ParentStyleUsing.UseBorders = False
        Me.ItemNotes.Size = New System.Drawing.Size(297, 16)
        Me.ItemNotes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.Title})
        Me.PageHeader.Height = 29
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.White
        Me.XrLabel4.Location = New System.Drawing.Point(431, 9)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.ParentStyleUsing.UseForeColor = False
        Me.XrLabel4.Size = New System.Drawing.Size(47, 15)
        Me.XrLabel4.Text = "Notes"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.White
        Me.XrLabel3.Location = New System.Drawing.Point(368, 9)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.ParentStyleUsing.UseForeColor = False
        Me.XrLabel3.Size = New System.Drawing.Size(73, 15)
        Me.XrLabel3.Text = "Chgs/Uses"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.Location = New System.Drawing.Point(290, 9)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.ParentStyleUsing.UseForeColor = False
        Me.XrLabel2.Size = New System.Drawing.Size(88, 15)
        Me.XrLabel2.Text = "Cost"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.Location = New System.Drawing.Point(211, 9)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(73, 15)
        Me.XrLabel1.Text = "Weight"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.DimGray
        Me.Title.BorderColor = System.Drawing.Color.DimGray
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.Title.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(5, 10)
        Me.Title.Name = "Title"
        Me.Title.ParentStyleUsing.UseBackColor = False
        Me.Title.ParentStyleUsing.UseBorderColor = False
        Me.Title.ParentStyleUsing.UseBorders = False
        Me.Title.ParentStyleUsing.UseFont = False
        Me.Title.ParentStyleUsing.UseForeColor = False
        Me.Title.Size = New System.Drawing.Size(719, 16)
        Me.Title.Text = " ASSETS"
        Me.Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Assets
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Data As AssetsDataset

    Public WriteOnly Property ReportTitle() As String
        Set(ByVal Value As String)
            Title.Text = Value
        End Set
    End Property

    Private Sub Inventory_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            ItemName.DataBindings.Add("Text", DataSource, "Inventory.ItemName")
            ItemWeight.DataBindings.Add("Text", DataSource, "Inventory.ItemWeight")
            ItemCost.DataBindings.Add("Text", DataSource, "Inventory.ItemCost")
            ItemCharges.DataBindings.Add("Text", DataSource, "Inventory.ItemCharges")
            ItemNotes.DataBindings.Add("Text", DataSource, "Inventory.ItemNotes")

            Me.DataSource = Data.Assets

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
