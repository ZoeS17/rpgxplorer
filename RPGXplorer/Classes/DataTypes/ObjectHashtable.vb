Option Explicit On
Option Strict On

<Serializable()> _
Public Class ObjectHashtable
    'Implements IEnumerable

    Private _Items As New Hashtable

    Public Sub New()
        _Items = New Hashtable
    End Sub

    Private Sub New(ByVal _CloneItems As Hashtable)
        _Items = _CloneItems
    End Sub

    Public Sub New(ByVal Size As Integer)
        _Items = New Hashtable(Size)
    End Sub

    Public Sub New(ByVal Size As Integer, ByVal Factor As Single)
        _Items = New Hashtable(Size, Factor)
    End Sub

    Public Sub Add(ByVal Key As Objects.ObjectKey, ByVal Value As Object)
        _Items.Add(Key.ToString(), Value)
    End Sub

    Public Sub Remove(ByVal Key As Objects.ObjectKey)
        _Items.Remove(Key.ToString())
    End Sub

    Default Public Property Item(ByVal Key As Objects.ObjectKey) As Object
        Get
            Return _Items(Key.ToString())
        End Get
        Set(ByVal value As Object)
            _Items(Key.ToString()) = value
        End Set
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
        Return New ObjectHashtable(DirectCast(_Items.Clone, Hashtable))
    End Function

    Public Sub Clear()
        _Items.Clear()
    End Sub

    Public ReadOnly Property Values() As ICollection
        Get
            Return _Items.Values
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
