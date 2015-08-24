Imports Desaware.MachineLicense

Public Class RegisterForm
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
    Public WithEvents CodeEntryControl1 As Desaware.MachineLicense.CodeEntryControl
    Public WithEvents RegButton As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents VisualStyleProvider1 As Skybound.VisualStyles.VisualStyleProvider
    Public WithEvents InfoLabel As System.Windows.Forms.Label
    Public WithEvents DemoButton As System.Windows.Forms.Button
    Public WithEvents ExitButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CodeEntryControl1 = New Desaware.MachineLicense.CodeEntryControl
        Me.RegButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.VisualStyleProvider1 = New Skybound.VisualStyles.VisualStyleProvider
        Me.InfoLabel = New System.Windows.Forms.Label
        Me.DemoButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CodeEntryControl1
        '
        Me.CodeEntryControl1.License = Nothing
        Me.CodeEntryControl1.Location = New System.Drawing.Point(90, 15)
        Me.CodeEntryControl1.Name = "CodeEntryControl1"
        Me.CodeEntryControl1.Size = New System.Drawing.Size(353, 20)
        Me.CodeEntryControl1.TabIndex = 0
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.CodeEntryControl1, True)
        '
        'RegButton
        '
        Me.RegButton.Enabled = False
        Me.RegButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegButton.Location = New System.Drawing.Point(455, 15)
        Me.RegButton.Name = "RegButton"
        Me.RegButton.Size = New System.Drawing.Size(75, 24)
        Me.RegButton.TabIndex = 1
        Me.RegButton.Text = "Register"
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.RegButton, True)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "License Key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.Label1, True)
        '
        'InfoLabel
        '
        Me.InfoLabel.Location = New System.Drawing.Point(15, 45)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(430, 55)
        Me.InfoLabel.TabIndex = 4
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.InfoLabel, True)
        '
        'DemoButton
        '
        Me.DemoButton.Location = New System.Drawing.Point(455, 45)
        Me.DemoButton.Name = "DemoButton"
        Me.DemoButton.TabIndex = 6
        Me.DemoButton.Text = "Trial"
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.DemoButton, True)
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(455, 75)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.VisualStyleProvider1.SetVisualStyleSupport(Me.ExitButton, True)
        '
        'RegisterForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DemoButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RegButton)
        Me.Controls.Add(Me.CodeEntryControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPGXplorer Version 1.03 RC1"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private RPGXplorerLicense As Desaware.MachineLicense.ClientLicense
    Private ValidationMessage As Desaware.MachineLicense.ValidationStatus
    Public Results As InstallErrorResults
    Public SuccessfulInstall As Boolean
    Public ExitApplication As Boolean

    Public Sub Init(ByVal License As Desaware.MachineLicense.ClientLicense, ByVal vs As Desaware.MachineLicense.ValidationStatus, ByVal DaysLeft As TimeSpan)
        RPGXplorerLicense = License
        ValidationMessage = vs

        'Set valadation for the CodeEntryControl
        CodeEntryControl1.License = RPGXplorerLicense
        Me.Text = General.Version

        Select Case ValidationMessage
            Case Desaware.MachineLicense.ValidationStatus.DemoExpired
                InfoLabel.Text = "Your trial period has expired"
                DemoButton.Enabled = False
                Exit Sub

            Case ValidationStatus.DemoNoInternetDate
                DemoButton.Enabled = False
                InfoLabel.Text = "Could not connect to date validation web service"
                Exit Sub
        End Select

        'If we are in demo mode dispaly the days remaining
        If RPGXplorerLicense.DemoVersion Then
            InfoLabel.Text = "You are currently running RPGXplorer in trial mode, " & DaysLeft.Days.ToString & " Days remaining"
            DemoButton.Text = "Continue"
            Exit Sub
        End If
    End Sub

    Public Sub Init(ByVal License As Desaware.MachineLicense.ClientLicense)
        RPGXplorerLicense = License

        'Set valadation for the CodeEntryControl
        CodeEntryControl1.License = RPGXplorerLicense
        Me.Text = General.Version

        'If we are in demo mode dispaly the register message
        If RPGXplorerLicense.DemoVersion Then
            InfoLabel.Text = "You are currently running RPGXplorer in trial mode"
            DemoButton.Text = "Continue"
            Exit Sub
        End If
    End Sub

    Private Sub RegButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegButton.Click
        Results = RPGXplorerLicense.InstallLicense(CodeEntryControl1.InstallCode, InstallationModes.SyncAllowDeferred)

        If (Not RPGXplorerLicense.DeferredLicense) AndAlso Results > InstallErrorResults.FatalError Then
            InfoLabel.Text = (RPGXplorerLicense.GetResultDescription(Results))
        Else
            SuccessfulInstall = True
            Me.Close()
        End If

    End Sub

    'Private Sub DemoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemoButton.Click
    '    Select Case DemoButton.Text

    '        Case "Continue"
    '            Me.Close()

    '        Case "Trial"
    '            Results = RPGXplorerLicense.InstallDemo(InstallationModes.SyncActivationRequired)
    '            If Results > InstallErrorResults.FatalError Then
    '                InfoLabel.Text = (RPGXplorerLicense.GetResultDescription(Results))
    '                Exit Sub
    '            End If

    '            If Results = InstallErrorResults.NoLicenseServers Then
    '                InfoLabel.Text = (RPGXplorerLicense.GetResultDescription(Results))
    '            Else
    '                SuccessfulInstall = True
    '                Me.Close()
    '            End If

    '    End Select
    'End Sub

    Private Sub DemoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemoButton.Click
        Me.Close()
    End Sub

    Private Sub CodeEntryControl1_LicenseCodeEntered(ByVal Sender As Object, ByVal e As Desaware.MachineLicense.CodeEntryEventArgs) Handles CodeEntryControl1.LicenseCodeEntered
        RegButton.Enabled = e.IsValid
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Quit the application
        ExitApplication = True
        Application.Exit()
    End Sub

End Class
