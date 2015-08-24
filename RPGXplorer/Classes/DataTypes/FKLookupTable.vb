Option Explicit On
Option Strict On

Imports System.Collections.Generic

<Serializable()> _
Public Class FKLookupTable

    Private _Table As ObjectHashtable

    'constructor
    Public Sub New()
        _Table = New ObjectHashtable()
    End Sub

    'constructor for clone
    Private Sub New(ByVal CloneTable As ObjectHashtable)
        _Table = CloneTable
    End Sub

    'add item
    Public Sub AddItemWithSubkey(ByVal Key As Objects.ObjectKey, ByVal Subkey As Objects.ObjectKey)
        If _Table.ContainsKey(Key) Then
            If Not DirectCast(_Table(Key), ObjectHashtable).ContainsKey(Subkey) Then DirectCast(_Table(Key), ObjectHashtable).Add(Subkey, Nothing)
        Else
            Dim SubkeyList As New ObjectHashtable
            SubkeyList.Add(Subkey, Nothing)
            _Table.Add(Key, SubkeyList)
        End If
    End Sub

    'contains key
    Public Function ContainsKey(ByVal Key As Objects.ObjectKey) As Boolean
        Return _Table.ContainsKey(Key)
    End Function

    'remove item
    Public Sub RemoveItem(ByVal Key As Objects.ObjectKey, ByVal Subkey As Objects.ObjectKey)
        If _Table.ContainsKey(Key) Then
            Dim Subtable As ObjectHashtable = DirectCast(_Table(Key), ObjectHashtable)
            If Subtable.ContainsKey(Subkey) Then Subtable.Remove(Subkey)
            If Subtable.Count = 0 Then _Table.Remove(Key)
        End If
    End Sub

    'remove subkey
    Public Sub RemoveSubkey(ByVal Subkey As Objects.ObjectKey)
        Dim ToRemove As New ArrayList
        For Each Entry As DictionaryEntry In _Table
            Dim Subtable As ObjectHashtable = DirectCast(Entry.Value, ObjectHashtable)
            If Subtable.ContainsKey(Subkey) Then Subtable.Remove(Subkey)
            If Subtable.Count = 0 Then ToRemove.Add(Entry.Key)
        Next
        For Each Key As String In ToRemove
            _Table.Remove(New Objects.ObjectKey(Key))
        Next
    End Sub

    'subkeys
    Public Function Subkeys(ByVal Key As Objects.ObjectKey) As ObjectHashtable
        If _Table.ContainsKey(Key) Then Return DirectCast(_Table(Key), ObjectHashtable) Else Return Nothing
    End Function

    'clear
    Public Sub Clear()
        _Table.Clear()
    End Sub

    'clone
    Public Function Clone() As FKLookupTable
        Dim CloneTable As New ObjectHashtable
        CloneTable = DirectCast(_Table.Clone(), ObjectHashtable)
        Return New FKLookupTable(CloneTable)
    End Function

End Class
