Option Explicit On
Option Strict On

<Serializable()> _
Public Class StringKeyHashtable

    Private _Items As New Hashtable

    Public Sub New()
        _Items = New Hashtable
    End Sub

    Private Sub New(ByVal CloneTable As Hashtable)
        _Items = CloneTable
    End Sub

    Public Sub New(ByVal Size As Integer)
        _Items = New Hashtable(Size)
    End Sub

    Public Sub New(ByVal Size As Integer, ByVal Factor As Single)
        _Items = New Hashtable(Size, Factor)
    End Sub

    Public Sub Add(ByVal Key As String, ByVal Value As Object)
        _Items.Add(Key, Value)
    End Sub

    Public Sub Remove(ByVal Key As String)
        _Items.Remove(Key)
    End Sub

    Default Public Property Item(ByVal Key As String) As Object
        Get
            Return _Items(Key)
        End Get
        Set(ByVal value As Object)
            _Items(Key) = value
        End Set
    End Property

    Public Function Contains(ByVal Key As String) As Boolean
        Return _Items.Contains(Key)
    End Function

    Public Function ContainsKey(ByVal Key As String) As Boolean
        Return _Items.ContainsKey(Key)
    End Function

    Public ReadOnly Property Count() As Integer
        Get
            Return _Items.Count
        End Get
    End Property

    Public Function Clone() As Object
        Return New StringKeyHashtable(DirectCast(_Items.Clone, Hashtable))
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
            Return _Items.Keys
        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.IDictionaryEnumerator
        Return _Items.GetEnumerator
    End Function

End Class
