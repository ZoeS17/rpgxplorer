<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeaponConfiguration
    Inherits DevExpress.XtraEditors.XtraUserControl

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
        Me.components = New System.ComponentModel.Container
        'Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WeaponConfiguration))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Primary = New System.Windows.Forms.PictureBox
        Me.OffHand = New System.Windows.Forms.PictureBox
        Me.Buckler = New System.Windows.Forms.PictureBox
        Me.ReadOnlyTextBox1 = New RPGXplorer.ReadOnlyTextBox
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(51, 51)
        'Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Empty
        '
        'Primary
        '
        Me.Primary.BackColor = System.Drawing.Color.Transparent
        Me.Primary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Primary.Image = My.Resources.Primary
        Me.Primary.Location = New System.Drawing.Point(12, 5)
        Me.Primary.Name = "Primary"
        Me.Primary.Size = New System.Drawing.Size(53, 50)
        Me.Primary.TabIndex = 18
        Me.Primary.TabStop = False
        '
        'OffHand
        '
        Me.OffHand.BackColor = System.Drawing.Color.Transparent
        Me.OffHand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OffHand.Image = My.Resources.Offhand
        Me.OffHand.Location = New System.Drawing.Point(67, 5)
        Me.OffHand.Name = "OffHand"
        Me.OffHand.Size = New System.Drawing.Size(53, 50)
        Me.OffHand.TabIndex = 19
        Me.OffHand.TabStop = False
        '
        'Buckler
        '
        Me.Buckler.BackColor = System.Drawing.Color.Transparent
        Me.Buckler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buckler.Image = My.Resources.Buckler
        Me.Buckler.Location = New System.Drawing.Point(122, 5)
        Me.Buckler.Name = "Buckler"
        Me.Buckler.Size = New System.Drawing.Size(53, 50)
        Me.Buckler.TabIndex = 20
        Me.Buckler.TabStop = False
        '
        'ReadOnlyTextBox1
        '
        Me.ReadOnlyTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReadOnlyTextBox1.BackColor = System.Drawing.Color.White
        Me.ReadOnlyTextBox1.Caption = Nothing
        Me.ReadOnlyTextBox1.DockPadding.All = 1
        Me.ReadOnlyTextBox1.ForeColor = System.Drawing.Color.Black
        Me.ReadOnlyTextBox1.LineColor = System.Drawing.Color.LightGray
        Me.ReadOnlyTextBox1.Location = New System.Drawing.Point(185, 1)
        Me.ReadOnlyTextBox1.Name = "ReadOnlyTextBox1"
        Me.ReadOnlyTextBox1.Size = New System.Drawing.Size(478, 58)
        Me.ReadOnlyTextBox1.TabIndex = 21
        Me.ReadOnlyTextBox1.TextColor = System.Drawing.Color.Black
        Me.ReadOnlyTextBox1.Vertical = False
        '
        'Description
        '
        Me.Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(190, 3)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Description.Properties.Appearance.Options.UseBackColor = True
        Me.Description.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Description.Properties.ReadOnly = True
        Me.Description.Size = New System.Drawing.Size(474, 55)
        Me.Description.TabIndex = 3
        Me.Description.TabStop = False
        '
        'WeaponConfiguration
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Primary)
        Me.Controls.Add(Me.OffHand)
        Me.Controls.Add(Me.Buckler)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.ReadOnlyTextBox1)
        Me.Name = "WeaponConfiguration"
        Me.Size = New System.Drawing.Size(664, 60)
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Primary As System.Windows.Forms.PictureBox
    Public WithEvents OffHand As System.Windows.Forms.PictureBox
    Public WithEvents Buckler As System.Windows.Forms.PictureBox
    Public WithEvents ReadOnlyTextBox1 As RPGXplorer.ReadOnlyTextBox

End Class
