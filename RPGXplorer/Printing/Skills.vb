Imports DevExpress.XtraReports.UI

Public Class Skills
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
    Public WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox
    Public WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill1Name As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Circle2 As RPGXplorer.Circle
    Public WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Circle3 As RPGXplorer.Circle
    Public WithEvents WinControlContainer3 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Skill2Name As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill3Name As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Circle4 As RPGXplorer.Circle
    Public WithEvents WinControlContainer4 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Skill4Name As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill1Info As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrCheckBox3 As DevExpress.XtraReports.UI.XRCheckBox
    Public WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill4 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill2Info As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrCheckBox4 As DevExpress.XtraReports.UI.XRCheckBox
    Public WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill4Info As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Skill3Info As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Circle1 As RPGXplorer.Circle
    Public WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents CheckPenalty As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.Skill1 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Circle1 = New RPGXplorer.Circle
        Me.Skill3Info = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill4Info = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill2Info = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill1Info = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill4Name = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer4 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Circle4 = New RPGXplorer.Circle
        Me.Skill3Name = New DevExpress.XtraReports.UI.XRLabel
        Me.Skill2Name = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer3 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Circle3 = New RPGXplorer.Circle
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Circle2 = New RPGXplorer.Circle
        Me.Skill1Name = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.CheckPenalty = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrCheckBox3 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrCheckBox4 = New DevExpress.XtraReports.UI.XRCheckBox
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLine3, Me.XrLine2, Me.XrLine1, Me.Skill1, Me.WinControlContainer1, Me.Skill3Info, Me.Skill4Info, Me.Skill2Info, Me.Skill4, Me.Skill3, Me.Skill2, Me.Skill1Info, Me.Skill4Name, Me.WinControlContainer4, Me.Skill3Name, Me.Skill2Name, Me.WinControlContainer3, Me.WinControlContainer2, Me.Skill1Name})
        Me.Detail.Height = 47
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'XrLine4
        '
        Me.XrLine4.ForeColor = System.Drawing.Color.Gray
        Me.XrLine4.LineWidth = 3
        Me.XrLine4.Location = New System.Drawing.Point(550, 19)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.ParentStyleUsing.UseForeColor = False
        Me.XrLine4.Size = New System.Drawing.Size(131, 5)
        '
        'XrLine3
        '
        Me.XrLine3.ForeColor = System.Drawing.Color.Gray
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.Location = New System.Drawing.Point(369, 19)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.ParentStyleUsing.UseForeColor = False
        Me.XrLine3.Size = New System.Drawing.Size(131, 5)
        '
        'XrLine2
        '
        Me.XrLine2.ForeColor = System.Drawing.Color.Gray
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.Location = New System.Drawing.Point(188, 19)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.ParentStyleUsing.UseForeColor = False
        Me.XrLine2.Size = New System.Drawing.Size(131, 5)
        '
        'XrLine1
        '
        Me.XrLine1.ForeColor = System.Drawing.Color.Gray
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.Location = New System.Drawing.Point(5, 19)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.ParentStyleUsing.UseForeColor = False
        Me.XrLine1.Size = New System.Drawing.Size(131, 5)
        '
        'Skill1
        '
        Me.Skill1.BorderColor = System.Drawing.Color.DimGray
        Me.Skill1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Skill1.ForeColor = System.Drawing.Color.Black
        Me.Skill1.Location = New System.Drawing.Point(135, 0)
        Me.Skill1.Name = "Skill1"
        Me.Skill1.ParentStyleUsing.UseBackColor = False
        Me.Skill1.ParentStyleUsing.UseBorderColor = False
        Me.Skill1.ParentStyleUsing.UseBorders = False
        Me.Skill1.ParentStyleUsing.UseFont = False
        Me.Skill1.ParentStyleUsing.UseForeColor = False
        Me.Skill1.Size = New System.Drawing.Size(42, 42)
        Me.Skill1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer1.Location = New System.Drawing.Point(135, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(47, 47)
        Me.WinControlContainer1.WinControl = Me.Circle1
        '
        'Circle1
        '
        Me.Circle1.BackColor = System.Drawing.Color.White
        Me.Circle1.Location = New System.Drawing.Point(0, 0)
        Me.Circle1.Name = "Circle1"
        Me.Circle1.Size = New System.Drawing.Size(45, 45)
        Me.Circle1.TabIndex = 0
        '
        'Skill3Info
        '
        Me.Skill3Info.CanGrow = False
        Me.Skill3Info.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill3Info.ForeColor = System.Drawing.Color.Gray
        Me.Skill3Info.Location = New System.Drawing.Point(368, 21)
        Me.Skill3Info.Name = "Skill3Info"
        Me.Skill3Info.ParentStyleUsing.UseFont = False
        Me.Skill3Info.ParentStyleUsing.UseForeColor = False
        Me.Skill3Info.Size = New System.Drawing.Size(172, 21)
        Me.Skill3Info.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Skill4Info
        '
        Me.Skill4Info.CanGrow = False
        Me.Skill4Info.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill4Info.ForeColor = System.Drawing.Color.Gray
        Me.Skill4Info.Location = New System.Drawing.Point(550, 21)
        Me.Skill4Info.Name = "Skill4Info"
        Me.Skill4Info.ParentStyleUsing.UseFont = False
        Me.Skill4Info.ParentStyleUsing.UseForeColor = False
        Me.Skill4Info.Size = New System.Drawing.Size(172, 21)
        Me.Skill4Info.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Skill2Info
        '
        Me.Skill2Info.CanGrow = False
        Me.Skill2Info.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill2Info.ForeColor = System.Drawing.Color.Gray
        Me.Skill2Info.Location = New System.Drawing.Point(186, 21)
        Me.Skill2Info.Name = "Skill2Info"
        Me.Skill2Info.ParentStyleUsing.UseFont = False
        Me.Skill2Info.ParentStyleUsing.UseForeColor = False
        Me.Skill2Info.Size = New System.Drawing.Size(172, 21)
        Me.Skill2Info.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Skill4
        '
        Me.Skill4.BorderColor = System.Drawing.Color.DimGray
        Me.Skill4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Skill4.ForeColor = System.Drawing.Color.Black
        Me.Skill4.Location = New System.Drawing.Point(679, 0)
        Me.Skill4.Name = "Skill4"
        Me.Skill4.ParentStyleUsing.UseBackColor = False
        Me.Skill4.ParentStyleUsing.UseBorderColor = False
        Me.Skill4.ParentStyleUsing.UseBorders = False
        Me.Skill4.ParentStyleUsing.UseFont = False
        Me.Skill4.ParentStyleUsing.UseForeColor = False
        Me.Skill4.Size = New System.Drawing.Size(42, 42)
        Me.Skill4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Skill3
        '
        Me.Skill3.BorderColor = System.Drawing.Color.DimGray
        Me.Skill3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Skill3.ForeColor = System.Drawing.Color.Black
        Me.Skill3.Location = New System.Drawing.Point(498, 0)
        Me.Skill3.Name = "Skill3"
        Me.Skill3.ParentStyleUsing.UseBackColor = False
        Me.Skill3.ParentStyleUsing.UseBorderColor = False
        Me.Skill3.ParentStyleUsing.UseBorders = False
        Me.Skill3.ParentStyleUsing.UseFont = False
        Me.Skill3.ParentStyleUsing.UseForeColor = False
        Me.Skill3.Size = New System.Drawing.Size(42, 42)
        Me.Skill3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Skill2
        '
        Me.Skill2.BorderColor = System.Drawing.Color.DimGray
        Me.Skill2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Skill2.ForeColor = System.Drawing.Color.Black
        Me.Skill2.Location = New System.Drawing.Point(317, 0)
        Me.Skill2.Name = "Skill2"
        Me.Skill2.ParentStyleUsing.UseBackColor = False
        Me.Skill2.ParentStyleUsing.UseBorderColor = False
        Me.Skill2.ParentStyleUsing.UseBorders = False
        Me.Skill2.ParentStyleUsing.UseFont = False
        Me.Skill2.ParentStyleUsing.UseForeColor = False
        Me.Skill2.Size = New System.Drawing.Size(42, 42)
        Me.Skill2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Skill1Info
        '
        Me.Skill1Info.CanGrow = False
        Me.Skill1Info.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill1Info.ForeColor = System.Drawing.Color.Gray
        Me.Skill1Info.Location = New System.Drawing.Point(5, 21)
        Me.Skill1Info.Name = "Skill1Info"
        Me.Skill1Info.ParentStyleUsing.UseFont = False
        Me.Skill1Info.ParentStyleUsing.UseForeColor = False
        Me.Skill1Info.Size = New System.Drawing.Size(172, 21)
        Me.Skill1Info.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Skill4Name
        '
        Me.Skill4Name.BackColor = System.Drawing.Color.White
        Me.Skill4Name.BorderColor = System.Drawing.Color.White
        Me.Skill4Name.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.Skill4Name.CanGrow = False
        Me.Skill4Name.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Skill4Name.ForeColor = System.Drawing.Color.Black
        Me.Skill4Name.Location = New System.Drawing.Point(549, 0)
        Me.Skill4Name.Name = "Skill4Name"
        Me.Skill4Name.ParentStyleUsing.UseBackColor = False
        Me.Skill4Name.ParentStyleUsing.UseBorderColor = False
        Me.Skill4Name.ParentStyleUsing.UseBorders = False
        Me.Skill4Name.ParentStyleUsing.UseFont = False
        Me.Skill4Name.ParentStyleUsing.UseForeColor = False
        Me.Skill4Name.Size = New System.Drawing.Size(125, 21)
        Me.Skill4Name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Skill4Name.WordWrap = False
        '
        'WinControlContainer4
        '
        Me.WinControlContainer4.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer4.Location = New System.Drawing.Point(679, 0)
        Me.WinControlContainer4.Name = "WinControlContainer4"
        Me.WinControlContainer4.Size = New System.Drawing.Size(47, 47)
        Me.WinControlContainer4.WinControl = Me.Circle4
        '
        'Circle4
        '
        Me.Circle4.BackColor = System.Drawing.Color.White
        Me.Circle4.Location = New System.Drawing.Point(0, 0)
        Me.Circle4.Name = "Circle4"
        Me.Circle4.Size = New System.Drawing.Size(45, 45)
        Me.Circle4.TabIndex = 3
        '
        'Skill3Name
        '
        Me.Skill3Name.BackColor = System.Drawing.Color.White
        Me.Skill3Name.BorderColor = System.Drawing.Color.White
        Me.Skill3Name.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.Skill3Name.CanGrow = False
        Me.Skill3Name.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Skill3Name.ForeColor = System.Drawing.Color.Black
        Me.Skill3Name.Location = New System.Drawing.Point(368, 0)
        Me.Skill3Name.Name = "Skill3Name"
        Me.Skill3Name.ParentStyleUsing.UseBackColor = False
        Me.Skill3Name.ParentStyleUsing.UseBorderColor = False
        Me.Skill3Name.ParentStyleUsing.UseBorders = False
        Me.Skill3Name.ParentStyleUsing.UseFont = False
        Me.Skill3Name.ParentStyleUsing.UseForeColor = False
        Me.Skill3Name.Size = New System.Drawing.Size(125, 21)
        Me.Skill3Name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Skill3Name.WordWrap = False
        '
        'Skill2Name
        '
        Me.Skill2Name.BackColor = System.Drawing.Color.White
        Me.Skill2Name.BorderColor = System.Drawing.Color.White
        Me.Skill2Name.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.Skill2Name.CanGrow = False
        Me.Skill2Name.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Skill2Name.ForeColor = System.Drawing.Color.Black
        Me.Skill2Name.Location = New System.Drawing.Point(186, 0)
        Me.Skill2Name.Name = "Skill2Name"
        Me.Skill2Name.ParentStyleUsing.UseBackColor = False
        Me.Skill2Name.ParentStyleUsing.UseBorderColor = False
        Me.Skill2Name.ParentStyleUsing.UseBorders = False
        Me.Skill2Name.ParentStyleUsing.UseFont = False
        Me.Skill2Name.ParentStyleUsing.UseForeColor = False
        Me.Skill2Name.Size = New System.Drawing.Size(125, 21)
        Me.Skill2Name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Skill2Name.WordWrap = False
        '
        'WinControlContainer3
        '
        Me.WinControlContainer3.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer3.Location = New System.Drawing.Point(498, 0)
        Me.WinControlContainer3.Name = "WinControlContainer3"
        Me.WinControlContainer3.Size = New System.Drawing.Size(47, 47)
        Me.WinControlContainer3.WinControl = Me.Circle3
        '
        'Circle3
        '
        Me.Circle3.BackColor = System.Drawing.Color.White
        Me.Circle3.Location = New System.Drawing.Point(0, 0)
        Me.Circle3.Name = "Circle3"
        Me.Circle3.Size = New System.Drawing.Size(45, 45)
        Me.Circle3.TabIndex = 2
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer2.Location = New System.Drawing.Point(317, 0)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(47, 47)
        Me.WinControlContainer2.WinControl = Me.Circle2
        '
        'Circle2
        '
        Me.Circle2.BackColor = System.Drawing.Color.White
        Me.Circle2.Location = New System.Drawing.Point(0, 0)
        Me.Circle2.Name = "Circle2"
        Me.Circle2.Size = New System.Drawing.Size(45, 45)
        Me.Circle2.TabIndex = 1
        '
        'Skill1Name
        '
        Me.Skill1Name.BackColor = System.Drawing.Color.White
        Me.Skill1Name.BorderColor = System.Drawing.Color.White
        Me.Skill1Name.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.Skill1Name.CanGrow = False
        Me.Skill1Name.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill1Name.ForeColor = System.Drawing.Color.Black
        Me.Skill1Name.Location = New System.Drawing.Point(5, 0)
        Me.Skill1Name.Name = "Skill1Name"
        Me.Skill1Name.ParentStyleUsing.UseBackColor = False
        Me.Skill1Name.ParentStyleUsing.UseBorderColor = False
        Me.Skill1Name.ParentStyleUsing.UseBorders = False
        Me.Skill1Name.ParentStyleUsing.UseFont = False
        Me.Skill1Name.ParentStyleUsing.UseForeColor = False
        Me.Skill1Name.Size = New System.Drawing.Size(125, 21)
        Me.Skill1Name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Skill1Name.WordWrap = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.CheckPenalty, Me.XrLabel80})
        Me.PageHeader.Height = 31
        Me.PageHeader.KeepTogether = True
        Me.PageHeader.Name = "PageHeader"
        '
        'CheckPenalty
        '
        Me.CheckPenalty.BorderColor = System.Drawing.Color.Transparent
        Me.CheckPenalty.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPenalty.ForeColor = System.Drawing.Color.White
        Me.CheckPenalty.Location = New System.Drawing.Point(75, 10)
        Me.CheckPenalty.Name = "CheckPenalty"
        Me.CheckPenalty.ParentStyleUsing.UseBackColor = False
        Me.CheckPenalty.ParentStyleUsing.UseBorderColor = False
        Me.CheckPenalty.ParentStyleUsing.UseBorders = False
        Me.CheckPenalty.ParentStyleUsing.UseFont = False
        Me.CheckPenalty.ParentStyleUsing.UseForeColor = False
        Me.CheckPenalty.Size = New System.Drawing.Size(646, 15)
        Me.CheckPenalty.Text = " SKILLS"
        Me.CheckPenalty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel80
        '
        Me.XrLabel80.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel80.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel80.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel80.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel80.ForeColor = System.Drawing.Color.White
        Me.XrLabel80.Location = New System.Drawing.Point(5, 10)
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.ParentStyleUsing.UseBackColor = False
        Me.XrLabel80.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel80.ParentStyleUsing.UseBorders = False
        Me.XrLabel80.ParentStyleUsing.UseFont = False
        Me.XrLabel80.ParentStyleUsing.UseForeColor = False
        Me.XrLabel80.Size = New System.Drawing.Size(719, 16)
        Me.XrLabel80.Text = " SKILLS"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.White
        Me.XrLabel1.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseBackColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(172, 21)
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox2
        '
        Me.XrCheckBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrCheckBox2.Location = New System.Drawing.Point(109, 26)
        Me.XrCheckBox2.Name = "XrCheckBox2"
        Me.XrCheckBox2.ParentStyleUsing.UseFont = False
        Me.XrCheckBox2.Size = New System.Drawing.Size(41, 21)
        Me.XrCheckBox2.Text = "CP"
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.Location = New System.Drawing.Point(182, 5)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseBackColor = False
        Me.XrLabel2.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.ParentStyleUsing.UseForeColor = False
        Me.XrLabel2.Size = New System.Drawing.Size(42, 42)
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.White
        Me.XrLabel4.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseBackColor = False
        Me.XrLabel4.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.ParentStyleUsing.UseForeColor = False
        Me.XrLabel4.Size = New System.Drawing.Size(172, 21)
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox3
        '
        Me.XrCheckBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrCheckBox3.Location = New System.Drawing.Point(109, 26)
        Me.XrCheckBox3.Name = "XrCheckBox3"
        Me.XrCheckBox3.ParentStyleUsing.UseFont = False
        Me.XrCheckBox3.Size = New System.Drawing.Size(41, 21)
        Me.XrCheckBox3.Text = "CP"
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.Location = New System.Drawing.Point(182, 5)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.ParentStyleUsing.UseBackColor = False
        Me.XrLabel7.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel7.ParentStyleUsing.UseBorders = False
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.ParentStyleUsing.UseForeColor = False
        Me.XrLabel7.Size = New System.Drawing.Size(42, 42)
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.White
        Me.XrLabel5.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseBackColor = False
        Me.XrLabel5.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.ParentStyleUsing.UseForeColor = False
        Me.XrLabel5.Size = New System.Drawing.Size(172, 21)
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox4
        '
        Me.XrCheckBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrCheckBox4.Location = New System.Drawing.Point(109, 26)
        Me.XrCheckBox4.Name = "XrCheckBox4"
        Me.XrCheckBox4.ParentStyleUsing.UseFont = False
        Me.XrCheckBox4.Size = New System.Drawing.Size(41, 21)
        Me.XrCheckBox4.Text = "CP"
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.Location = New System.Drawing.Point(182, 5)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseBackColor = False
        Me.XrLabel6.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.ParentStyleUsing.UseForeColor = False
        Me.XrLabel6.Size = New System.Drawing.Size(42, 42)
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Skills
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Data As SkillsDataset
    Public CheckPenaltyString As String

    Private Sub Skills_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            Skill1Name.DataBindings.Add("Text", DataSource, "Skills.Skill1Name")
            Skill1.DataBindings.Add("Text", DataSource, "Skills.Skill1")
            Skill2Name.DataBindings.Add("Text", DataSource, "Skills.Skill2Name")
            Skill2.DataBindings.Add("Text", DataSource, "Skills.Skill2")
            Skill3Name.DataBindings.Add("Text", DataSource, "Skills.Skill3Name")
            Skill3.DataBindings.Add("Text", DataSource, "Skills.Skill3")
            Skill4Name.DataBindings.Add("Text", DataSource, "Skills.Skill4Name")
            Skill4.DataBindings.Add("Text", DataSource, "Skills.Skill4")
            Skill1Info.DataBindings.Add("Text", DataSource, "Skills.Skill1Info")
            Skill2Info.DataBindings.Add("Text", DataSource, "Skills.Skill2Info")
            Skill3Info.DataBindings.Add("Text", DataSource, "Skills.Skill3Info")
            Skill4Info.DataBindings.Add("Text", DataSource, "Skills.Skill4Info")
            CheckPenalty.Text = CheckPenaltyString

            Me.DataSource = Data.Skills
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
