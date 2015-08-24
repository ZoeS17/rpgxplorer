Option Explicit On
Option Strict On

Public Class ExplorerTreeNodeHashtable

    Private _Items As New Hashtable

    Public Sub Add(ByVal Key As Objects.ObjectKey, ByVal TreeNode As TreeNode)
        _Items.Add(Key.ToString(), TreeNode)
    End Sub

    Public Sub Remove(ByVal Key As Objects.ObjectKey)
        _Items.Remove(Key.ToString())
    End Sub

    Default Public Property Item(ByVal Key As Objects.ObjectKey) As TreeNode
        Get
            Return DirectCast(_Items(Key.ToString()), TreeNode)
        End Get
        Set(ByVal value As TreeNode)
            _Items(Key.ToString()) = value
        End Set
    End Property

    Public Function Contains(ByVal Key As Objects.ObjectKey) As Boolean
        Return _Items.ContainsKey(Key.ToString())
    End Function

    Public Function ContainsKey(ByVal Key As Objects.ObjectKey) As Boolean
        Return _Items.ContainsKey(Key.ToString())
    End Function

End Class
