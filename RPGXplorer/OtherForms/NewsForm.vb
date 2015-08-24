Option Explicit On 
Option Strict On

Public Class NewsForm
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
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents StartCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NewsForm))
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.StartCheck = New System.Windows.Forms.CheckBox
        ''CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Browser
        '
        Me.Browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browser.CausesValidation = False
        'Me.Browser.Enabled = True
        Me.Browser.Location = New System.Drawing.Point(0, 0)
        Me.Browser.Size = New System.Drawing.Size(688, 480)
        Me.Browser.TabIndex = 4
        Me.Browser.TabStop = False
        '
        'StartCheck
        '
        Me.StartCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartCheck.Location = New System.Drawing.Point(15, 495)
        Me.StartCheck.Name = "StartCheck"
        Me.StartCheck.Size = New System.Drawing.Size(235, 24)
        Me.StartCheck.TabIndex = 5
        Me.StartCheck.Text = "Display news and information on start up"
        '
        'NewsForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(687, 531)
        Me.Controls.Add(Me.StartCheck)
        Me.Controls.Add(Me.Browser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Latest News and Info"
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ErrorHandled As Boolean

    Public Sub Init()
        Try
            'init check
            If Not General.Config.Element("NewsOnStartup") = "False" Then StartCheck.Checked = True

            'init browser
            ErrorHandled = False
            Browser.Navigate("http://www.rpgxplorer.com/newsfeed.htm")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub StartCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartCheck.CheckedChanged
        Try
            If StartCheck.Checked = True Then
                General.Config.Element("NewsOnStartup") = "True"
            Else
                General.Config.Element("NewsOnStartup") = "False"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub Browser_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Browser.DocumentCompleted
        If Not ErrorHandled Then
            If Browser.DocumentType = "File" Then
                Browser.Navigate(General.HelpPath & "newsfeed404.htm")
            End If
            ErrorHandled = True
        End If
    End Sub

    'if the webpage cannot be found
    'Private Sub Browser_NavigateError(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent) Handles Browser.NavigateError
    '    Try
    '        If Not ErrorHandled Then
    '            Browser.Navigate(General.HelpPath & "newsfeed404.htm")
    '        End If
    '        ErrorHandled = True
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

End Class
