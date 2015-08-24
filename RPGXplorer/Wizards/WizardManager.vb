Option Strict On
Option Explicit On 

Public Class WizardManager
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Public WithEvents PanelHolder As System.Windows.Forms.Panel
    Public WithEvents NextButton As System.Windows.Forms.Button
    Public WithEvents FinishButton As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents BackButton As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WizardManager))
        Me.PanelHolder = New System.Windows.Forms.Panel
        Me.NextButton = New System.Windows.Forms.Button
        Me.FinishButton = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.BackButton = New System.Windows.Forms.Button
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.SuspendLayout()
        '
        'PanelHolder
        '
        Me.PanelHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelHolder.BackColor = System.Drawing.SystemColors.Control
        Me.PanelHolder.Location = New System.Drawing.Point(0, 0)
        Me.PanelHolder.Name = "PanelHolder"
        Me.PanelHolder.Size = New System.Drawing.Size(502, 402)
        Me.PanelHolder.TabIndex = 6
        '
        'NextButton
        '
        Me.NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.BackColor = System.Drawing.SystemColors.Control
        Me.NextButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NextButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NextButton.Location = New System.Drawing.Point(340, 420)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(70, 25)
        Me.NextButton.TabIndex = 8
        Me.NextButton.Text = "Next"
        '
        'FinishButton
        '
        Me.FinishButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinishButton.BackColor = System.Drawing.SystemColors.Control
        Me.FinishButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FinishButton.Enabled = False
        Me.FinishButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FinishButton.Location = New System.Drawing.Point(415, 420)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(70, 25)
        Me.FinishButton.TabIndex = 9
        Me.FinishButton.Text = "Finish"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(190, 420)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 25)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "Cancel"
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.SystemColors.Control
        Me.BackButton.Enabled = False
        Me.BackButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackButton.Location = New System.Drawing.Point(265, 420)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(70, 25)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "Back"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(0, 405)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(500, 5)
        Me.IndentedLine1.TabIndex = 11
        '
        'WizardManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(499, 458)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.FinishButton)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PanelHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WizardManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wizard Manager"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents Wizard As IWizard
    Private WithEvents Panel As IWizardPanel

    'init
    Public Sub Init(ByVal Wizard As IWizard, ByVal Caption As String)
        Try
            UI.SwitchReadOnlyOn()

            'lock xml
            XML.Lock = True

            Me.Wizard = Wizard
            Me.Text = Caption
            Panel = Wizard.NextPanel
            Me.Width = Panel.Width + 5
            Me.Height = Panel.Height
            CenterToScreen()
            Me.PanelHolder.Controls.Add(CType(Panel, Control))
            NextButton.Enabled = False
            BackButton.Enabled = False
            FinishButton.Enabled = False
            Panel.InitPanel()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "IWizard and IWizardPanel Event Handlers"

    'handle the enable next event
    Private Sub HandleEnableNext(ByVal FirstPanel As Boolean) Handles Panel.EnableNext
        Try
            NextButton.Enabled = True
            If Not FirstPanel Then BackButton.Enabled = True
            Me.AcceptButton = NextButton
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the disable next event
    Private Sub HandleDisableNext() Handles Panel.DisableNext
        Try
            NextButton.Enabled = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle the enable finish event
    Private Sub HandleEnableFinish() Handles Wizard.EnableFinish
        Try
            NextButton.Enabled = False
            FinishButton.Enabled = True
            Me.AcceptButton = FinishButton
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle the disable finish event
    Private Sub HandleDisableFinish() Handles Wizard.DisableFinish
        Try
            FinishButton.Enabled = False
            Me.AcceptButton = NextButton
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Visability and Focus Workarounds"

    Public Shadows Sub Show()
        MyBase.Show()
        Wizard.InitialUpdate()
    End Sub

#End Region

#Region "Button Click Handlers"

    'close the wizard
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Try
            If General.ShowQuestionDialog("Are you sure you want to cancel the wizard?") = DialogResult.Yes Then
                General.MainExplorer.Undo.UndoRecordCancel()
                XML.Lock = False
                Me.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared NextHandlerRunning As Boolean

    'handle the next button
    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        If NextHandlerRunning Then Exit Sub

        Try
            NextHandlerRunning = True
            Me.Cursor = Cursors.WaitCursor
            General.SetWaitCursor()
            Panel = Wizard.NextPanel
            Me.Width = Panel.Width + 5
            Me.Height = Panel.Height
            CenterToScreen()
            PanelHolder.Controls.Clear()
            PanelHolder.Controls.Add(CType(Panel, Control))
            PanelHolder.Controls(0).Dock = DockStyle.Fill
            PanelHolder.Controls(0).Focus()
            NextButton.Enabled = False
            BackButton.Enabled = True
            Panel.InitPanel()
            General.SetNormalCursor()
            Me.Cursor = Cursors.Default
            NextHandlerRunning = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared BackHandlerRunning As Boolean

    'handle the back button
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        If BackHandlerRunning Then Exit Sub
        Try
            BackHandlerRunning = True
            General.SetWaitCursor()
            Me.Cursor = Cursors.WaitCursor
            Panel = Wizard.PreviousPanel
            Me.Width = Panel.Width + 5
            Me.Height = Panel.Height
            CenterToScreen()
            PanelHolder.Controls.Clear()
            PanelHolder.Controls.Add(CType(Panel, Control))
            PanelHolder.Controls(0).Dock = DockStyle.Fill
            PanelHolder.Controls(0).Focus()
            If Not Panel.IsFirstTab Then BackButton.Enabled = True Else BackButton.Enabled = False
            NextButton.Enabled = True
            Panel.InitPanel()
            General.SetNormalCursor()
            Me.Cursor = Cursors.Default
            BackHandlerRunning = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Shared FinishHandlerRunning As Boolean

    'handle the finish button
    Private Sub FinishButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FinishButton.Click
        If FinishHandlerRunning Then Exit Sub
        Try
            FinishHandlerRunning = True
            Wizard.Finish()
            XML.Lock = False
            Me.Close()
            FinishHandlerRunning = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'handle closing
    Private Sub WizardManager_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            UI.SwitchReadOnlyOff()
            XML.Lock = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class