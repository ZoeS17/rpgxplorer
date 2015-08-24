Imports DevExpress.XtraReports.UI

Public Class SpellsPerDay
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
    Public WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Public WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ClassName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD0 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD1 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD2 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD3 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD4 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD5 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD6 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD7 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD8 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SPD9 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.ClassName = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD0 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell
        Me.SPD9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
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
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ClassName, Me.SPD0, Me.XrTableCell24, Me.SPD1, Me.XrTableCell26, Me.SPD2, Me.XrTableCell28, Me.SPD3, Me.XrTableCell30, Me.SPD4, Me.XrTableCell32, Me.SPD5, Me.XrTableCell34, Me.SPD6, Me.XrTableCell36, Me.SPD7, Me.XrTableCell38, Me.SPD8, Me.XrTableCell40, Me.SPD9, Me.XrTableCell42})
        Me.XrTableRow2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.ParentStyleUsing.UseFont = False
        Me.XrTableRow2.Size = New System.Drawing.Size(719, 17)
        Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ClassName
        '
        Me.ClassName.Location = New System.Drawing.Point(0, 0)
        Me.ClassName.Name = "ClassName"
        Me.ClassName.Size = New System.Drawing.Size(120, 17)
        Me.ClassName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SPD0
        '
        Me.SPD0.Location = New System.Drawing.Point(120, 0)
        Me.SPD0.Name = "SPD0"
        Me.SPD0.Size = New System.Drawing.Size(29, 17)
        Me.SPD0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Location = New System.Drawing.Point(149, 0)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD1
        '
        Me.SPD1.Location = New System.Drawing.Point(180, 0)
        Me.SPD1.Name = "SPD1"
        Me.SPD1.Size = New System.Drawing.Size(29, 17)
        Me.SPD1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Location = New System.Drawing.Point(209, 0)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD2
        '
        Me.SPD2.Location = New System.Drawing.Point(240, 0)
        Me.SPD2.Name = "SPD2"
        Me.SPD2.Size = New System.Drawing.Size(29, 17)
        Me.SPD2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Location = New System.Drawing.Point(269, 0)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD3
        '
        Me.SPD3.Location = New System.Drawing.Point(300, 0)
        Me.SPD3.Name = "SPD3"
        Me.SPD3.Size = New System.Drawing.Size(29, 17)
        Me.SPD3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Location = New System.Drawing.Point(329, 0)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD4
        '
        Me.SPD4.Location = New System.Drawing.Point(360, 0)
        Me.SPD4.Name = "SPD4"
        Me.SPD4.Size = New System.Drawing.Size(29, 17)
        Me.SPD4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Location = New System.Drawing.Point(389, 0)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD5
        '
        Me.SPD5.Location = New System.Drawing.Point(420, 0)
        Me.SPD5.Name = "SPD5"
        Me.SPD5.Size = New System.Drawing.Size(29, 17)
        Me.SPD5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Location = New System.Drawing.Point(449, 0)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD6
        '
        Me.SPD6.Location = New System.Drawing.Point(480, 0)
        Me.SPD6.Name = "SPD6"
        Me.SPD6.Size = New System.Drawing.Size(29, 17)
        Me.SPD6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Location = New System.Drawing.Point(509, 0)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD7
        '
        Me.SPD7.Location = New System.Drawing.Point(540, 0)
        Me.SPD7.Name = "SPD7"
        Me.SPD7.Size = New System.Drawing.Size(29, 17)
        Me.SPD7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Location = New System.Drawing.Point(569, 0)
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD8
        '
        Me.SPD8.Location = New System.Drawing.Point(600, 0)
        Me.SPD8.Name = "SPD8"
        Me.SPD8.Size = New System.Drawing.Size(29, 17)
        Me.SPD8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Location = New System.Drawing.Point(629, 0)
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SPD9
        '
        Me.SPD9.Location = New System.Drawing.Point(660, 0)
        Me.SPD9.Name = "SPD9"
        Me.SPD9.Size = New System.Drawing.Size(29, 17)
        Me.SPD9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Location = New System.Drawing.Point(689, 0)
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Size = New System.Drawing.Size(30, 17)
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell15, Me.XrTableCell14, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell13, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell18, Me.XrTableCell21, Me.XrTableCell12})
        Me.XrTableRow1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.ParentStyleUsing.UseFont = False
        Me.XrTableRow1.Size = New System.Drawing.Size(719, 17)
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(120, 17)
        Me.XrTableCell1.Text = "Caster Class"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(120, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell2.Text = "0th"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(149, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(180, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell4.Text = "1st"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(209, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(240, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell6.Text = "2nd"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(269, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(300, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell8.Text = "3rd"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(329, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(360, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell10.Text = "4th"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Location = New System.Drawing.Point(389, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Size = New System.Drawing.Size(31, 17)
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Location = New System.Drawing.Point(420, 0)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell15.Text = "5th"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Location = New System.Drawing.Point(449, 0)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Size = New System.Drawing.Size(31, 17)
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Location = New System.Drawing.Point(480, 0)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell16.Text = "6th"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Location = New System.Drawing.Point(509, 0)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Size = New System.Drawing.Size(31, 17)
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Location = New System.Drawing.Point(540, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell13.Text = "7th"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Location = New System.Drawing.Point(569, 0)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Size = New System.Drawing.Size(31, 17)
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Location = New System.Drawing.Point(600, 0)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell20.Text = "8th"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Location = New System.Drawing.Point(629, 0)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Size = New System.Drawing.Size(31, 17)
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Location = New System.Drawing.Point(660, 0)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Size = New System.Drawing.Size(29, 17)
        Me.XrTableCell21.Text = "9th"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Location = New System.Drawing.Point(689, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Size = New System.Drawing.Size(30, 17)
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrLabel24.Text = " SPELLS PER DAY"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SpellsPerDay
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Data As SpellsPerDayDataset

    Private Sub SpellsPerDay_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            Me.ClassName.DataBindings.Add("Text", DataSource, "SpellsPerDay.ClassName")
            Me.SPD0.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD0")
            Me.SPD1.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD1")
            Me.SPD2.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD2")
            Me.SPD3.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD3")
            Me.SPD4.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD4")
            Me.SPD5.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD5")
            Me.SPD6.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD6")
            Me.SPD7.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD7")
            Me.SPD8.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD8")
            Me.SPD9.DataBindings.Add("Text", DataSource, "SpellsPerDay.SPD9")

            Me.DataSource = Data.SpellsPerDay

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
End Class
