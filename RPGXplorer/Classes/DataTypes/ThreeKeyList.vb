Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Public Class ThreeKeyList

#Region "Member Variables"

    Private UpperIndex As ObjectHashtable

#End Region

    'constructor
    Public Sub New(Optional ByVal Size As Integer = 100)
        UpperIndex = New ObjectHashtable(Size)
    End Sub

    'add an item to the collection
    Public Sub Add(ByVal UpperKey As Objects.ObjectKey, ByVal MiddleKey As Object, ByVal LowerKey As Object, ByVal Item As Object)
        Dim MiddleIndex As Hashtable
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        If UpperIndex.ContainsKey(UpperKey) Then
            MiddleIndex = DirectCast(UpperIndex.Item(UpperKey), Hashtable)
        Else
            MiddleIndex = New Hashtable
            UpperIndex.Add(UpperKey, MiddleIndex)
        End If

        If MiddleIndex.ContainsKey(MiddleKey) Then
            LowerIndex = DirectCast(MiddleIndex.Item(MiddleKey), Hashtable)
        Else
            LowerIndex = New Hashtable
            MiddleIndex.Add(MiddleKey, LowerIndex)
        End If

        If LowerIndex.ContainsKey(LowerKey) Then
            List = DirectCast(LowerIndex.Item(LowerKey), ArrayList)
        Else
            List = New ArrayList
            LowerIndex.Add(LowerKey, List)
        End If

        List.Add(Item)
    End Sub

    'remove item from the collection
    Public Sub Remove(ByVal UpperKey As Objects.ObjectKey, ByVal MiddleKey As Object, ByVal LowerKey As Object, ByVal Item As Object)
        Dim MiddleIndex As Hashtable
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        MiddleIndex = CType(UpperIndex.Item(UpperKey), Hashtable)

        If Not MiddleIndex Is Nothing Then
            LowerIndex = CType(MiddleIndex.Item(MiddleKey), Hashtable)
            If Not LowerIndex Is Nothing Then
                List = CType(LowerIndex.Item(LowerKey), ArrayList)
                If Not List Is Nothing Then List.Remove(Item)
            End If
        End If

    End Sub

    'get the arraylist for the given key group
    Public Function Item(ByVal UpperKey As Objects.ObjectKey, ByVal MiddleKey As Object, ByVal LowerKey As Object) As ArrayList
        Dim MiddleIndex As Hashtable
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        MiddleIndex = CType(UpperIndex.Item(UpperKey), Hashtable)

        If Not MiddleIndex Is Nothing Then

            LowerIndex = CType(MiddleIndex.Item(MiddleKey), Hashtable)
            If Not LowerIndex Is Nothing Then
                List = CType(LowerIndex.Item(LowerKey), ArrayList)
                If Not List Is Nothing Then Return List Else Return New ArrayList
            Else
                Return New ArrayList
            End If

        Else
            Return New ArrayList
        End If
    End Function

    'concatenate all arraylists accessible from this key
    Public Function Item(ByVal UpperKey As Objects.ObjectKey) As ArrayList
        Dim MiddleIndex As Hashtable
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        Dim ReturnList As New ArrayList

        MiddleIndex = CType(UpperIndex.Item(UpperKey), Hashtable)

        If Not MiddleIndex Is Nothing Then
            'go through all the lowerindex tables
            For Each LowerIndex In MiddleIndex.Values
                For Each List In LowerIndex.Values
                    ReturnList.AddRange(List)
                Next
            Next
        End If

        Return ReturnList

    End Function

    'concatenate all arraylists accessible from this key pair
    Public Function Item(ByVal UpperKey As Objects.ObjectKey, ByVal MiddleKey As Object) As ArrayList
        Dim MiddleIndex As Hashtable
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        Dim ReturnList As New ArrayList

        MiddleIndex = CType(UpperIndex.Item(UpperKey), Hashtable)

        If Not MiddleIndex Is Nothing Then
            LowerIndex = CType(MiddleIndex.Item(MiddleKey), Hashtable)
            If Not LowerIndex Is Nothing Then
                For Each List In LowerIndex.Values
                    ReturnList.AddRange(List)
                Next
            End If
        End If

        Return ReturnList

    End Function

    Public Function UpperKeys() As ICollection
        Return UpperIndex.Keys
    End Function

    Public Function MiddleKeys(ByVal UpperKey As Objects.ObjectKey) As ICollection
        Dim MiddleIndex As Hashtable
        MiddleIndex = CType(UpperIndex.Item(UpperKey), Hashtable)
        If MiddleIndex Is Nothing Then
            Return New ArrayList
        Else
            Return MiddleIndex.Keys()
        End If
    End Function

    Public Function LowerKeys(ByVal UpperKey As Objects.ObjectKey, ByVal MiddleKey As Object) As ICollection
        Dim MiddleIndex As Hashtable
        MiddleIndex = CType(UpperIndex.Item(UpperKey), Hashtable)
        If Not MiddleIndex Is Nothing Then
            Dim LowerIndex As Hashtable
            LowerIndex = CType(MiddleIndex.Item(MiddleKey), Hashtable)
            If Not LowerIndex Is Nothing Then
                Return LowerIndex.Keys
            End If
        End If

        Return New ArrayList

    End Function

    'clears the datatype
    Public Sub Clear()
        UpperIndex = New ObjectHashtable
    End Sub

End Class
