Option Explicit On 
Option Strict On

Imports DevExpress.XtraBars

Public Class UI

    'code common to any UI window, command etc.

    'disable all main windows
    Public Shared Sub Disable()
        General.MainExplorer.Form.Enabled = False
        If Not General.RulesViewer Is Nothing Then General.RulesViewer.Enabled = False
        If Not General.XMLWorkShop Is Nothing Then General.XMLWorkShop.Enabled = False
        If Not General.Marketplace Is Nothing Then General.Marketplace.Enabled = False
    End Sub

    'enable all main windows
    Public Shared Sub Enable()
        General.MainExplorer.Form.Enabled = True
        If Not General.RulesViewer Is Nothing Then General.RulesViewer.Enabled = True
        If Not General.XMLWorkShop Is Nothing Then General.XMLWorkShop.Enabled = True
        If Not General.Marketplace Is Nothing Then General.Marketplace.Enabled = True
    End Sub

    Private Shared _ReadOnly As Boolean = False

    'is the ui currently enabled for editing data
    Public Shared ReadOnly Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
    End Property

    'disable all menus and commands that can be used to edit data
    Public Shared Sub SwitchReadOnlyOn()
        _ReadOnly = True

        'disable menus
        For Each Link As BarItemLink In General.MainExplorer.Form.Menubar.ItemLinks
            Select Case Link.Item.Name
                Case "View", "Window", "Help"
                    'do nothing
                Case Else
                    Link.Item.Enabled = False
            End Select
        Next

        'disable marketplace toolbar
        For Each Link As BarItemLink In General.MainExplorer.Form.Marketplace.ItemLinks
            Link.Item.Enabled = False
        Next

        'close marketplace and workshop
        If General.Marketplace IsNot Nothing AndAlso General.Marketplace.Visible = True Then General.Marketplace.Close()
        If General.XMLWorkShop IsNot Nothing AndAlso General.XMLWorkShop.Visible = True Then General.XMLWorkShop.Close()
    End Sub

    'enable all menus and commands
    Public Shared Sub SwitchReadOnlyOff()
        _ReadOnly = False

        'enable menus
        For Each Link As DevExpress.XtraBars.BarItemLink In General.MainExplorer.Form.Menubar.ItemLinks
            Link.Item.Enabled = True
        Next

        'enable marketplace toolbar
        For Each Link As BarItemLink In General.MainExplorer.Form.Marketplace.ItemLinks
            Link.Item.Enabled = True
        Next
    End Sub

    'set the look and feel
    Public Shared Sub SetLookAndFeel(ByVal Style As String)
        Try
            Select Case Style
                Case "Flat"
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetFlatStyle()
                Case "UltraFlat"
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetUltraFlatStyle()
                Case "Office2003"
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetOffice2003Style()
                Case Else
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Style)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'common code for html navigation 
    Public Shared Sub BrowserNavigate(ByVal Browser As System.Windows.Forms.WebBrowser, ByVal HTML As String)
        Try
            If HTML.IndexOf(":\") = 1 And IO.File.Exists(HTML) Then
                Browser.Navigate("file://" & HTML)
            Else
                If IO.File.Exists(General.HelpPath & HTML) Then
                    Browser.Navigate("file://" & General.HelpPath & HTML)
                Else
                    Browser.Navigate("file://" & General.HelpPath & "Help\FileNotFound.htm")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
