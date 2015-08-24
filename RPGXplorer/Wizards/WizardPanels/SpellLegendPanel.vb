Imports RPGXplorer.Rules.Constants

Public Class SpellLegendPanel
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        ClassBlock.BackColor = ClassSpellColor
        DomainBlock.BackColor = DomainSpellColor
        PrestigeBlock.BackColor = PrestigeSpellColor
        PrestigeDomainBlock.BackColor = PrestigeDomainSpellColor
        TakenBlock.BackColor = TakenSpellColor
        RestrictedBlock.BackColor = RestrictedSpellColor
        Racial.BackColor = RacialAdditional
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents ClassBlock As System.Windows.Forms.Panel
    Public WithEvents DomainBlock As System.Windows.Forms.Panel
    Public WithEvents PrestigeBlock As System.Windows.Forms.Panel
    Public WithEvents PrestigeDomainBlock As System.Windows.Forms.Panel
    Public WithEvents TakenBlock As System.Windows.Forms.Panel
    Public WithEvents RestrictedBlock As System.Windows.Forms.Panel
    Public WithEvents NormalLabel As System.Windows.Forms.Label
    Public WithEvents DomainLabel As System.Windows.Forms.Label
    Public WithEvents PrestigeLabel As System.Windows.Forms.Label
    Public WithEvents PrestigeDomainLabel As System.Windows.Forms.Label
    Public WithEvents TakenLabel As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Racial As System.Windows.Forms.Panel
    Public WithEvents RestrictedLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ClassBlock = New System.Windows.Forms.Panel
        Me.NormalLabel = New System.Windows.Forms.Label
        Me.DomainLabel = New System.Windows.Forms.Label
        Me.DomainBlock = New System.Windows.Forms.Panel
        Me.PrestigeLabel = New System.Windows.Forms.Label
        Me.PrestigeBlock = New System.Windows.Forms.Panel
        Me.PrestigeDomainLabel = New System.Windows.Forms.Label
        Me.PrestigeDomainBlock = New System.Windows.Forms.Panel
        Me.TakenLabel = New System.Windows.Forms.Label
        Me.TakenBlock = New System.Windows.Forms.Panel
        Me.RestrictedLabel = New System.Windows.Forms.Label
        Me.RestrictedBlock = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Racial = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'ClassBlock
        '
        Me.ClassBlock.BackColor = System.Drawing.SystemColors.Control
        Me.ClassBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClassBlock.Location = New System.Drawing.Point(15, 15)
        Me.ClassBlock.Name = "ClassBlock"
        Me.ClassBlock.Size = New System.Drawing.Size(25, 25)
        Me.ClassBlock.TabIndex = 0
        '
        'NormalLabel
        '
        Me.NormalLabel.Location = New System.Drawing.Point(55, 15)
        Me.NormalLabel.Name = "NormalLabel"
        Me.NormalLabel.Size = New System.Drawing.Size(115, 21)
        Me.NormalLabel.TabIndex = 1
        Me.NormalLabel.Text = "Class Spell"
        Me.NormalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DomainLabel
        '
        Me.DomainLabel.Location = New System.Drawing.Point(55, 50)
        Me.DomainLabel.Name = "DomainLabel"
        Me.DomainLabel.Size = New System.Drawing.Size(115, 21)
        Me.DomainLabel.TabIndex = 3
        Me.DomainLabel.Text = "Domain Spell"
        Me.DomainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DomainBlock
        '
        Me.DomainBlock.BackColor = System.Drawing.SystemColors.Control
        Me.DomainBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DomainBlock.Location = New System.Drawing.Point(15, 50)
        Me.DomainBlock.Name = "DomainBlock"
        Me.DomainBlock.Size = New System.Drawing.Size(25, 25)
        Me.DomainBlock.TabIndex = 2
        '
        'PrestigeLabel
        '
        Me.PrestigeLabel.Location = New System.Drawing.Point(55, 85)
        Me.PrestigeLabel.Name = "PrestigeLabel"
        Me.PrestigeLabel.Size = New System.Drawing.Size(115, 21)
        Me.PrestigeLabel.TabIndex = 5
        Me.PrestigeLabel.Text = "Prestige Spell"
        Me.PrestigeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrestigeBlock
        '
        Me.PrestigeBlock.BackColor = System.Drawing.SystemColors.Control
        Me.PrestigeBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrestigeBlock.Location = New System.Drawing.Point(15, 85)
        Me.PrestigeBlock.Name = "PrestigeBlock"
        Me.PrestigeBlock.Size = New System.Drawing.Size(25, 25)
        Me.PrestigeBlock.TabIndex = 4
        '
        'PrestigeDomainLabel
        '
        Me.PrestigeDomainLabel.Location = New System.Drawing.Point(215, 15)
        Me.PrestigeDomainLabel.Name = "PrestigeDomainLabel"
        Me.PrestigeDomainLabel.Size = New System.Drawing.Size(140, 21)
        Me.PrestigeDomainLabel.TabIndex = 7
        Me.PrestigeDomainLabel.Text = "Prestige Domain Spell"
        Me.PrestigeDomainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrestigeDomainBlock
        '
        Me.PrestigeDomainBlock.BackColor = System.Drawing.SystemColors.Control
        Me.PrestigeDomainBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrestigeDomainBlock.Location = New System.Drawing.Point(175, 15)
        Me.PrestigeDomainBlock.Name = "PrestigeDomainBlock"
        Me.PrestigeDomainBlock.Size = New System.Drawing.Size(25, 25)
        Me.PrestigeDomainBlock.TabIndex = 6
        '
        'TakenLabel
        '
        Me.TakenLabel.Location = New System.Drawing.Point(215, 85)
        Me.TakenLabel.Name = "TakenLabel"
        Me.TakenLabel.Size = New System.Drawing.Size(140, 21)
        Me.TakenLabel.TabIndex = 9
        Me.TakenLabel.Text = "Already Taken"
        Me.TakenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TakenBlock
        '
        Me.TakenBlock.BackColor = System.Drawing.SystemColors.Control
        Me.TakenBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TakenBlock.Location = New System.Drawing.Point(175, 85)
        Me.TakenBlock.Name = "TakenBlock"
        Me.TakenBlock.Size = New System.Drawing.Size(25, 25)
        Me.TakenBlock.TabIndex = 8
        '
        'RestrictedLabel
        '
        Me.RestrictedLabel.Location = New System.Drawing.Point(55, 120)
        Me.RestrictedLabel.Name = "RestrictedLabel"
        Me.RestrictedLabel.Size = New System.Drawing.Size(115, 21)
        Me.RestrictedLabel.TabIndex = 11
        Me.RestrictedLabel.Text = "School Restricted"
        Me.RestrictedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RestrictedBlock
        '
        Me.RestrictedBlock.BackColor = System.Drawing.SystemColors.Control
        Me.RestrictedBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RestrictedBlock.Location = New System.Drawing.Point(15, 120)
        Me.RestrictedBlock.Name = "RestrictedBlock"
        Me.RestrictedBlock.Size = New System.Drawing.Size(25, 25)
        Me.RestrictedBlock.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(215, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Racial Addition"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Racial
        '
        Me.Racial.BackColor = System.Drawing.SystemColors.Control
        Me.Racial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Racial.Location = New System.Drawing.Point(175, 50)
        Me.Racial.Name = "Racial"
        Me.Racial.Size = New System.Drawing.Size(25, 25)
        Me.Racial.TabIndex = 12
        '
        'SpellLegendPanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(363, 153)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Racial)
        Me.Controls.Add(Me.RestrictedLabel)
        Me.Controls.Add(Me.RestrictedBlock)
        Me.Controls.Add(Me.TakenLabel)
        Me.Controls.Add(Me.TakenBlock)
        Me.Controls.Add(Me.PrestigeDomainLabel)
        Me.Controls.Add(Me.PrestigeDomainBlock)
        Me.Controls.Add(Me.PrestigeLabel)
        Me.Controls.Add(Me.PrestigeBlock)
        Me.Controls.Add(Me.DomainLabel)
        Me.Controls.Add(Me.DomainBlock)
        Me.Controls.Add(Me.NormalLabel)
        Me.Controls.Add(Me.ClassBlock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SpellLegendPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Spell Legend"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub SetPowerMode()
        NormalLabel.Text = "Class Power"
        DomainLabel.Text = "Specialization Power"
        PrestigeLabel.Text = "Prestige Power"
        PrestigeDomainLabel.Text = "Prestige Specialization Power"
        TakenLabel.Text = "Already Taken"
        RestrictedLabel.Visible = False
        RestrictedBlock.Visible = False
        Me.Text = "Available Power Legend"
    End Sub

    Private Sub PanelBase_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If Me.Width > 0 And Me.Height > 0 Then
            Dim g As Graphics = e.Graphics
            Dim gradbrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, Color.White, SystemColors.ControlLight, Drawing2D.LinearGradientMode.ForwardDiagonal)

            g.FillRectangle(gradbrush, Me.DisplayRectangle)
        End If
    End Sub

    Private Sub PanelBase_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

End Class
