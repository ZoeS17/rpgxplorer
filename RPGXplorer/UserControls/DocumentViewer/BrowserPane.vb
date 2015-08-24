Option Explicit On
Option Strict On

Public Class BrowserPane

#Region "Member Variables"

    Private _ApplicationRequest As Boolean
    Private _DocViewer As DocumentViewer
    Private _URI As String

#End Region

#Region "Properties"

    'notify browser that request to navigate is coming from the application
    Public WriteOnly Property ApplicationRequest() As Boolean
        Set(ByVal Value As Boolean)
            _ApplicationRequest = Value
        End Set
    End Property

    'the browser
    Public ReadOnly Property BrowserControl() As System.Windows.Forms.WebBrowser
        Get
            Return Me.AxWebBrowser1
        End Get
    End Property

    'the currently displayed URI
    Public Property URI() As String

        Get
            Return _URI
        End Get

        Set(ByVal Value As String)
            _URI = Value
        End Set

    End Property

#End Region

    ''trap the navigation and cancel if request is from the user
    'Private Sub AxWebBrowser1_BeforeNavigate2(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_BeforeNavigate2Event) Handles AxWebBrowser1.Navigating
    '    Try
    '        Dim URI As String = "file://" & CType(e.uRL, String)

    '        If _ApplicationRequest Then
    '            _ApplicationRequest = False
    '        Else
    '            e.cancel = True
    '            _DocViewer.ShowURI(URI)
    '        End If

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    Private Sub AxWebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles AxWebBrowser1.Navigating
        Try
            Dim URI As String = e.Url.ToString

            If _ApplicationRequest Then
                _ApplicationRequest = False
            Else
                e.Cancel = True
                _DocViewer.ShowURI(URI)

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
