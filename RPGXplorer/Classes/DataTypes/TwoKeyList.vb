Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Public Class TwoKeyList

#Region "Member Variables"

    Private UpperIndex As Hashtable

#End Region

    'constructor
    Public Sub New(Optional ByVal Size As Integer = 100)
        UpperIndex = New Hashtable(Size)
    End Sub

    'add an item to the collection
    Public Sub Add(ByVal UpperKey As Object, ByVal LowerKey As Object, ByVal Item As Object)
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        If UpperIndex.ContainsKey(UpperKey) Then
            LowerIndex = DirectCast(UpperIndex.Item(UpperKey), Hashtable)
        Else
            LowerIndex = New Hashtable
            UpperIndex.Add(UpperKey, LowerIndex)
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
    Public Sub Remove(ByVal UpperKey As Object, ByVal LowerKey As Object, ByVal Item As Object)
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        LowerIndex = CType(UpperIndex.Item(UpperKey), Hashtable)

        If Not LowerIndex Is Nothing Then
            List = CType(LowerIndex.Item(LowerKey), ArrayList)
            If Not List Is Nothing Then List.Remove(Item)
        End If

    End Sub

    'get the arraylist for the given key pair
    Public Function Item(ByVal UpperKey As Object, ByVal LowerKey As Object) As ArrayList
        Dim LowerIndex As Hashtable
        Dim List As ArrayList

        LowerIndex = CType(UpperIndex.Item(UpperKey), Hashtable)

        If Not LowerIndex Is Nothing Then
            List = CType(LowerIndex.Item(LowerKey), ArrayList)
            If Not List Is Nothing Then Return List Else Return New ArrayList
        Else
            Return New ArrayList
        End If

    End Function

    Public Function UpperKeys() As ICollection
        Return UpperIndex.Keys
    End Function

    Public Function LowerKeys(ByVal UpperKey As Object) As ICollection
        Dim LowerIndex As Hashtable
        LowerIndex = CType(UpperIndex.Item(UpperKey), Hashtable)
        If LowerIndex Is Nothing Then
            Return New ArrayList
        Else
            Return LowerIndex.Keys
        End If
    End Function

    'clears the datatype
    Public Sub Clear()
        UpperIndex = New Hashtable
    End Sub

End Class
