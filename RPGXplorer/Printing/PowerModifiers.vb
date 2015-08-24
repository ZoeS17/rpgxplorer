Imports DevExpress.XtraReports.UI

Public Class PowerModifiers
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
    Public WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Public WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents TypeCell As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents SourceCell As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ModifierCell As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents ConditionCell As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.ModifierCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.ConditionCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.TypeCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.SourceCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
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
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ModifierCell, Me.ConditionCell, Me.TypeCell, Me.SourceCell})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(719, 16)
        '
        'ModifierCell
        '
        Me.ModifierCell.BorderColor = System.Drawing.Color.Gray
        Me.ModifierCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ModifierCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifierCell.Location = New System.Drawing.Point(0, 0)
        Me.ModifierCell.Name = "ModifierCell"
        Me.ModifierCell.ParentStyleUsing.UseBorderColor = False
        Me.ModifierCell.ParentStyleUsing.UseBorders = False
        Me.ModifierCell.ParentStyleUsing.UseFont = False
        Me.ModifierCell.Size = New System.Drawing.Size(271, 16)
        Me.ModifierCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ConditionCell
        '
        Me.ConditionCell.BorderColor = System.Drawing.Color.Gray
        Me.ConditionCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ConditionCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConditionCell.Location = New System.Drawing.Point(271, 0)
        Me.ConditionCell.Name = "ConditionCell"
        Me.ConditionCell.ParentStyleUsing.UseBorderColor = False
        Me.ConditionCell.ParentStyleUsing.UseBorders = False
        Me.ConditionCell.ParentStyleUsing.UseFont = False
        Me.ConditionCell.Size = New System.Drawing.Size(211, 16)
        Me.ConditionCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TypeCell
        '
        Me.TypeCell.BorderColor = System.Drawing.Color.Gray
        Me.TypeCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.TypeCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeCell.Location = New System.Drawing.Point(482, 0)
        Me.TypeCell.Name = "TypeCell"
        Me.TypeCell.ParentStyleUsing.UseBorderColor = False
        Me.TypeCell.ParentStyleUsing.UseBorders = False
        Me.TypeCell.ParentStyleUsing.UseFont = False
        Me.TypeCell.Size = New System.Drawing.Size(80, 16)
        Me.TypeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SourceCell
        '
        Me.SourceCell.BorderColor = System.Drawing.Color.Gray
        Me.SourceCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.SourceCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceCell.Location = New System.Drawing.Point(562, 0)
        Me.SourceCell.Name = "SourceCell"
        Me.SourceCell.ParentStyleUsing.UseBorderColor = False
        Me.SourceCell.ParentStyleUsing.UseBorders = False
        Me.SourceCell.ParentStyleUsing.UseFont = False
        Me.SourceCell.Size = New System.Drawing.Size(157, 16)
        Me.SourceCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrLabel70})
        Me.PageHeader.Height = 21
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.Location = New System.Drawing.Point(562, 5)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.ParentStyleUsing.UseForeColor = False
        Me.XrLabel2.Size = New System.Drawing.Size(162, 15)
        Me.XrLabel2.Text = "Source"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.Location = New System.Drawing.Point(484, 5)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(84, 15)
        Me.XrLabel1.Text = "Type"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrLabel70.Text = " MANIFESTING MODIFIERS"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PowerModifiers
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public data As SpellModifiersDataset

    Private Sub SpellModifiers_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            ConditionCell.DataBindings.Add("Text", DataSource, "SpellModifiers.Condition")
            ModifierCell.DataBindings.Add("Text", DataSource, "SpellModifiers.Modifier")
            TypeCell.DataBindings.Add("Text", DataSource, "SpellModifiers.Type")
            SourceCell.DataBindings.Add("Text", DataSource, "SpellModifiers.Source")

            Me.DataSource = data.SpellModifiers
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

