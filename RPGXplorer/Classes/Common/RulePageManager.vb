Option Strict On
Option Explicit On 

Imports RPGXplorer.Exceptions
Imports RPGXplorer.Objects

'this class handles everything to do with rules pages
Public Class RulePageManager

    'get the full URI of an objects's html page
    Public Shared Function GetURI(ByVal Obj As ObjectData) As String
        Try
            Return "file://" & GetFullPath(Obj)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the full path of an object's html page
    Public Shared Function GetFullPath(ByVal Obj As ObjectData) As String
        Try
            'get help page
            Dim HelpPage As String
            Dim HelpObj As New ObjectData

            If Obj.HTMLGUID.Equals(ObjectKey.Empty) Then
                HelpPage = Obj.HTML
            Else
                HelpObj.Load(Obj.HTMLGUID)
                HelpPage = HelpObj.HTML
            End If

            If IO.File.Exists(HelpPage) Then
                Return HelpPage
            Else
                If IO.File.Exists(General.HelpPath & HelpPage) Then
                    Return General.HelpPath & HelpPage
                Else
                    Return General.HelpPath & "Help\FileNotFound.htm"
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'rename a rule page
    Public Shared Function Rename(ByVal Obj As Objects.ObjectData, ByVal NewName As String) As String
        Try
            'check for references
            Dim RefCount As Integer = ReferenceCountPath(Obj.ObjectGUID, Obj.HTML)

            If RefCount > 0 Then
                General.ShowInfoDialog("Cannot rename rule page as there are components (" & RefCount & ") that reference this page. The existing rule page path will be retained.")
                Return ""
            End If

            'determine new path
            Dim Path As RulePagePath = New RulePagePath(Obj.HTML)
            Dim NewPath As String = Path.FolderPath & CommonLogic.StripDisallowedChars(NewName) & Path.Extension

            'rename the file
            Try
                If Not IO.File.Exists(NewPath) Then
                    IO.File.Move(Path.FullPath, NewPath)
                    If Obj.HTML.IndexOf(":") = -1 Then
                        Return Path.HelpRelativePath & NewName & Path.Extension
                    Else
                        Return Path.FolderPath & NewName & Path.Extension
                    End If
                Else
                    General.ShowInfoDialog("Cannot rename rule page as an existing rule page exists with this name. The existing rule page path will be retained.")
                End If
            Catch ex As Exception
                Exceptions.HandleNonFatalException(ex)
            End Try

            Return ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'delete rule page
    Public Shared Function Delete(ByVal Path As String, ByVal Key As Objects.ObjectKey, Optional ByVal ForceDelete As Boolean = False) As Integer
        Try
            Dim PathData As RulePagePath = New RulePagePath(Path)
            Dim RefCount As Integer = 0

            If Not ForceDelete Then
                RefCount = ReferenceCountPath(Key, Path) + ReferenceCountKey(Key)
            End If

            If RefCount = 0 Or ForceDelete Then
                Try
                    IO.File.Delete(PathData.FullPath)
                Catch ex As Exception
                    Exceptions.HandleNonFatalException(ex)
                    Return -999
                End Try

                Return CType(True, Integer)
            Else
                Return CType(False, Integer)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'determine the number of references to this rule page
    Public Shared Function ReferenceCountPath(ByVal Key As Objects.ObjectKey, ByVal Path As String) As Integer
        Try
            Dim Count As Integer
            Dim Nodes As System.Xml.XmlNodeList

            For db As Integer = 1 To 32
                Nodes = XML.SelectNodes(db, "/RPGXplorerDatabase/RPGXplorerObject[ObjectGUID!='" & Key.ToString & "' and HTML=""" & Path & """]")
                If Not Nodes Is Nothing Then Count += Nodes.Count
            Next

            Return Count

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'determine the number of references to this rule page
    Public Shared Function ReferenceCountKey(ByVal Key As Objects.ObjectKey) As Integer
        Try
            Dim Count As Integer
            Dim Nodes As System.Xml.XmlNodeList

            For db As Integer = 1 To 32
                Nodes = XML.SelectNodes(db, "/RPGXplorerDatabase/RPGXplorerObject[HTMLGUID='" & Key.ToString & "']")
                If Not Nodes Is Nothing Then Count += Nodes.Count
            Next

            Return Count

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

End Class
