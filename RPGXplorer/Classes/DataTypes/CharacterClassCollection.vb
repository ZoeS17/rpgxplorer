Option Explicit On
Option Strict On

Imports RPGXplorer.Rules

Public Class CharacterClassCollection

    Private _Items As New Hashtable

    Public Sub New()
        _Items = New Hashtable
    End Sub

    Private Sub New(ByVal _CloneItems As Hashtable)
        _Items = _CloneItems
    End Sub

    Public Sub Add(ByVal Key As Objects.ObjectKey)
        _Items.Add(Key.ToString(), Nothing)
    End Sub

    Public Sub Remove(ByVal Key As Objects.ObjectKey)
        _Items.Remove(Key.ToString())
    End Sub

    Default Public ReadOnly Property Item(ByVal Key As Objects.ObjectKey) As CharacterClass
        Get
            If _Items.ContainsKey(Key.ToString) Then Return Caches.GetCharacterClass(Key) Else Return Nothing
        End Get
    End Property

    Public Function Contains(ByVal Key As Objects.ObjectKey) As Boolean
        Return _Items.Contains(Key.ToString())
    End Function

    Public Function ContainsKey(ByVal Key As Objects.ObjectKey) As Boolean
        Return _Items.ContainsKey(Key.ToString())
    End Function

    Public ReadOnly Property Count() As Integer
        Get
            Return _Items.Count
        End Get
    End Property

    Public Function Clone() As Object
        Return New CharacterClassCollection(DirectCast(_Items.Clone, Hashtable))
    End Function

    Public Sub Clear()
        _Items.Clear()
    End Sub

    Public ReadOnly Property Values() As List(Of CharacterClass)
        Get
            Dim List As New List(Of CharacterClass)
            For Each Key As String In _Items.Keys
                List.Add(Caches.GetCharacterClass(New Objects.ObjectKey(Key)))
            Next
            Return List
        End Get
    End Property

    Public ReadOnly Property Keys() As ICollection
        Get
            Dim _Keys As New ArrayList
            For Each Key As String In _Items.Keys
                _Keys.Add(New Objects.ObjectKey(Key))
            Next
            Return _Keys
        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.IDictionaryEnumerator
        Return _Items.GetEnumerator
    End Function

End Class
