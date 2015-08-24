Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Public Class Clipboard

    'this class is responsible for maintaining an object clipboard

#Region "Enumerations"

    Public Enum CutCopy
        Empty
        Cut
        Copy
    End Enum

#End Region

#Region "Member Variables"

    Private mClipboard As New Objects.ObjectDataCollection
    Private mNodes As TreeNodeCollection
    Private mMode As CutCopy
    Public FolderObject As Objects.ObjectData

#End Region

#Region "Properties"

    Public ReadOnly Property ClipboardGuids() As ArrayList
        Get
            Return mClipboard.GetGuidList
        End Get
    End Property

#End Region

    'constructor
    Public Sub New()
        Try
            mMode = CutCopy.Empty
            FolderObject = Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'current mode
    Public ReadOnly Property Mode() As CutCopy
        Get
            Return mMode
        End Get
    End Property

    'is the clipboard empty
    Public Function ClipboardNotEmpty() As Boolean
        Try
            If mClipboard.Count = 0 Then Return False Else Return True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'overwrite existing clipboard with whatever is selected in the list or tree view
    Public Sub Copy(ByVal Objects As Objects.ObjectDataCollection)
        Try
            mClipboard.Clear()
            mClipboard.AddMany(Objects)
            mMode = CutCopy.Copy

            If Objects.Count > 0 Then
                FolderObject = Objects.Item(0).Parent
            Else
                FolderObject = Nothing
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'overwrite existing clipboard with whatever is selected in the list or tree view
    Public Sub Cut(ByVal Objects As Objects.ObjectDataCollection)
        Try
            mClipboard.Clear()
            mClipboard.AddMany(Objects)
            mMode = CutCopy.Cut

            If Objects.Count > 0 Then
                FolderObject = Objects.Item(0).Parent
            Else
                FolderObject = Nothing
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'paste the contents of the clipboard onto the current focus
    Public Function Paste(ByVal TargetFolder As Objects.ObjectData) As ArrayList
        Try
            Dim GuidsMoved As ArrayList

            If mClipboard.Count = 0 Then
                General.ShowInfoDialog(General.PasteFailMessage3)
                Return Nothing
            End If

            'move or copy
            Select Case mMode
                Case CutCopy.Copy
                    GuidsMoved = PasteManager.CopyObjects(mClipboard, TargetFolder)
                Case CutCopy.Cut
                    GuidsMoved = PasteManager.MoveObjects(mClipboard, TargetFolder)
                Case Else
                    GuidsMoved = New ArrayList
            End Select

            Return GuidsMoved

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'clear the clipboard
    Public Sub Clear()
        Try
            mMode = CutCopy.Empty
            mClipboard.Clear()
            FolderObject = Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'check to see if the clipboard contains the object
    Public Function Contains(ByVal ObjectGUID As Objects.ObjectKey) As Boolean
        Try
            Return mClipboard.Contains(ObjectGUID)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

End Class
