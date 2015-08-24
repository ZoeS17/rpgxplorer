Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Public Class OneKeyList

#Region "Member Variables"

    Private Index As Hashtable

#End Region

    'constructor
    Public Sub New(Optional ByVal Size As Integer = 100)
        Try
            Index = New Hashtable(Size)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add an item to the collection
    Public Sub Add(ByVal Key As Object, ByVal Item As Object)
        Try
            Dim List As ArrayList

            If Index.ContainsKey(Key) Then
                List = DirectCast(Index.Item(Key), ArrayList)
            Else
                List = New ArrayList
                Index(Key) = List
            End If

            List.Add(Item)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove item from the collection
    Public Sub Remove(ByVal Key As Object, ByVal Item As Object)
        Try
            Dim List As ArrayList

            List = DirectCast(Index.Item(Key), ArrayList)

            If Not List Is Nothing Then
                List.Remove(Item)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the arraylist for the given key
    Public Function Item(ByVal Key As Object) As ArrayList
        Try
            Dim List As ArrayList

            List = DirectCast(Index.Item(Key), ArrayList)
            If List Is Nothing Then Return New ArrayList Else Return List
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    'clears the datatype
    Public Sub Clear()
        Try
            Index = New Hashtable
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'returns the key collection
    Public Function Keys() As System.Collections.ICollection
        Try
            Return Index.Keys
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

End Class
