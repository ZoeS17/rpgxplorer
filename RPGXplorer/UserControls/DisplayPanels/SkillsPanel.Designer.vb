<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkillsPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'initialise the list view
        ListView1.SmallImageList = Images.SmallImages
        ListView1.LargeImageList = Images.LargeImages
        ListView1.FullRowSelect = True
        ListView1.Sorting = SortOrder.None
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SkillModifiers = New DevExpress.XtraEditors.ListBoxControl
        Me.ReadOnlyTextBox1 = New RPGXplorer.ReadOnlyTextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Panel1.SuspendLayout()
        CType(Me.SkillModifiers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(1, 398)
        Me.Splitter1.MinSize = 100
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(542, 5)
        Me.Splitter1.TabIndex = 36
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panel1.Controls.Add(Me.SkillModifiers)
        Me.Panel1.Controls.Add(Me.ReadOnlyTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(1, 403)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 100)
        Me.Panel1.TabIndex = 39
        '
        'SkillModifiers
        '
        Me.SkillModifiers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkillModifiers.Appearance.BackColor = System.Drawing.Color.White
        Me.SkillModifiers.Appearance.Options.UseBackColor = True
        Me.SkillModifiers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SkillModifiers.ItemHeight = 15
        Me.SkillModifiers.Location = New System.Drawing.Point(1, 21)
        Me.SkillModifiers.Name = "SkillModifiers"
        Me.SkillModifiers.ShowToolTips = False
        Me.SkillModifiers.Size = New System.Drawing.Size(540, 78)
        Me.SkillModifiers.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.SkillModifiers.TabIndex = 40
        Me.SkillModifiers.TabStop = False
        '
        'ReadOnlyTextBox1
        '
        Me.ReadOnlyTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReadOnlyTextBox1.BackColor = System.Drawing.Color.LightYellow
        Me.ReadOnlyTextBox1.Caption = " Skill Modifiers"
        Me.ReadOnlyTextBox1.CaptionAligment = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReadOnlyTextBox1.DockPadding.All = 1
        Me.ReadOnlyTextBox1.ForeColor = System.Drawing.Color.Black
        Me.ReadOnlyTextBox1.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.ReadOnlyTextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.ReadOnlyTextBox1.Name = "ReadOnlyTextBox1"
        Me.ReadOnlyTextBox1.Size = New System.Drawing.Size(544, 20)
        Me.ReadOnlyTextBox1.TabIndex = 39
        Me.ReadOnlyTextBox1.TabStop = False
        Me.ReadOnlyTextBox1.TextColor = System.Drawing.Color.Black
        Me.ReadOnlyTextBox1.Vertical = False
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(1, 1)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(542, 397)
        Me.ListView1.TabIndex = 40
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'SkillsPanel
        '
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.DockPadding.All = 1
        Me.Name = "SkillsPanel"
        Me.Size = New System.Drawing.Size(544, 504)
        Me.Panel1.ResumeLayout(False)
        CType(Me.SkillModifiers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ReadOnlyTextBox1 As RPGXplorer.ReadOnlyTextBox
    Public WithEvents SkillModifiers As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents ListView1 As System.Windows.Forms.ListView

End Class
