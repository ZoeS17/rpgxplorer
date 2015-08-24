Option Strict On
Option Explicit On 

Public Class RulePagePath

    Public Filename As String
    Public Extension As String
    Public HelpRelativePath As String
    Public FolderPath As String
    Public FullPath As String

    'convert a path into its app relative path if possible
    Public Sub New(ByVal Path As String)
        Try
            Dim LastBackslashIndex As Integer = Path.LastIndexOf("\")

            'get filename inc. extension rule page
            If LastBackslashIndex = -1 Then
                Filename = Path
            Else
                Filename = Path.Substring(LastBackslashIndex + 1)
            End If

            'file extension
            Extension = Filename.Substring(Filename.LastIndexOf("."))

            'remaining data
            If Path.IndexOf(":") = -1 Then
                If LastBackslashIndex = -1 Then
                    HelpRelativePath = ""
                    FolderPath = General.HelpPath
                Else
                    HelpRelativePath = Path.Substring(0, LastBackslashIndex + 1)
                    FolderPath = General.HelpPath & HelpRelativePath
                End If
                FullPath = FolderPath & Filename
            Else
                HelpRelativePath = ""
                FolderPath = Path.Substring(0, LastBackslashIndex + 1)
                FullPath = Path
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
End Class
