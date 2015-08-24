Imports DevExpress.XtraReports.UI

Public Class SpellNotes
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
    Public WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ClassName As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Notes As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.ClassName = New DevExpress.XtraReports.UI.XRTableCell
        Me.Notes = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrTable1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ClassName, Me.Notes})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(719, 16)
        '
        'ClassName
        '
        Me.ClassName.BorderColor = System.Drawing.Color.Gray
        Me.ClassName.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ClassName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassName.Location = New System.Drawing.Point(0, 0)
        Me.ClassName.Name = "ClassName"
        Me.ClassName.ParentStyleUsing.UseBorderColor = False
        Me.ClassName.ParentStyleUsing.UseBorders = False
        Me.ClassName.ParentStyleUsing.UseFont = False
        Me.ClassName.Size = New System.Drawing.Size(120, 16)
        '
        'Notes
        '
        Me.Notes.BorderColor = System.Drawing.Color.Gray
        Me.Notes.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Notes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notes.Location = New System.Drawing.Point(120, 0)
        Me.Notes.Multiline = True
        Me.Notes.Name = "Notes"
        Me.Notes.ParentStyleUsing.UseBorderColor = False
        Me.Notes.ParentStyleUsing.UseBorders = False
        Me.Notes.ParentStyleUsing.UseFont = False
        Me.Notes.Size = New System.Drawing.Size(599, 16)
        Me.Notes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrLabel70})
        Me.PageHeader.Height = 38
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.DimGray
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable2.Location = New System.Drawing.Point(5, 21)
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
        Me.XrTableCell4.Text = "Notes"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel70
        '
        Me.XrLabel70.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel70.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel70.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel70.ForeColor = System.Drawing.Color.White
        Me.XrLabel70.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.ParentStyleUsing.UseBackColor = False
        Me.XrLabel70.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel70.ParentStyleUsing.UseBorders = False
        Me.XrLabel70.ParentStyleUsing.UseFont = False
        Me.XrLabel70.ParentStyleUsing.UseForeColor = False
        Me.XrLabel70.Size = New System.Drawing.Size(719, 16)
        Me.XrLabel70.Text = " SPELLCASTING NOTES"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SpellNotes
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public data As SpellNotesDataset

    Private Sub SpellNotes_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            ClassName.DataBindings.Add("Text", DataSource, "SpellNotes.ClassName")
            Notes.DataBindings.Add("Text", DataSource, "SpellNotes.Notes")

            Me.DataSource = data.SpellNotes

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

