Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Public Class Sorter

    'generic comparer
    MustInherit Class Comparer
        Implements IComparer

        Protected mSortType As SortType

        Public ReadOnly Property SortType() As SortType
            Get
                Return mSortType
            End Get
        End Property

        'IComparer.Compare - respond for each of the sort types
        Public MustOverride Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare

    End Class

    Class ListViewItemComparer
        Inherits Comparer

        Private _ColumnIndex As Integer
        Private _Direction As Windows.Forms.SortOrder

        Public Sub New(ByVal pSortType As SortType, ByVal ColumnIndex As Integer, ByVal Direction As Windows.Forms.SortOrder)
            MyBase.mSortType = pSortType
            _ColumnIndex = ColumnIndex
            _Direction = Direction
        End Sub

        Public Overrides Function Compare(ByVal x As Object, ByVal y As Object) As Integer
            Dim a, b As String
            Dim Greater, Less, Equal, Temp As Integer

            Try
                Equal = 0
                If _Direction = SortOrder.Ascending Then
                    Greater = 1
                    Less = -1
                Else
                    Greater = -1
                    Less = 1
                End If

                If _ColumnIndex >= CType(x, ListViewItem).SubItems.Count Then
                    a = CType(x, ListViewItem).Text
                    b = CType(y, ListViewItem).Text
                Else
                    a = CType(x, ListViewItem).SubItems(_ColumnIndex).Text
                    b = CType(y, ListViewItem).SubItems(_ColumnIndex).Text
                End If

                Select Case MyBase.SortType
                    Case SortType.Alphabetic
                        Temp = [String].Compare(a, b)
                        If _Direction = SortOrder.Descending Then
                            If Temp = 1 Then Temp = -1 Else Temp = 1
                        End If
                        If _ColumnIndex = 0 Then
                            Return Temp
                        Else
                            If Temp <> 0 Then Return Temp
                        End If
                    Case SortType.Numeric
                        If CType(a, Integer) > CType(b, Integer) Then Return Greater
                        If CType(a, Integer) < CType(b, Integer) Then Return Less
                    Case SortType.NumericPrefix
                        If StripLeftNumbers(a) > StripLeftNumbers(b) Then Return Greater
                        If StripLeftNumbers(a) < StripLeftNumbers(b) Then Return Less
                    Case SortType.NumericSuffix
                        If StripRightNumbers(a) > StripRightNumbers(b) Then Return Greater
                        If StripRightNumbers(a) < StripRightNumbers(b) Then Return Less
                End Select

                If _ColumnIndex > 0 Then
                    Dim Secondary As New ListViewItemComparer(SortType.Alphabetic, 0, SortOrder.Ascending)
                    Return Secondary.Compare(x, y)
                Else
                    Return Equal
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

    Class ObjectDataComparer
        Inherits Comparer

        Public Sub New(ByVal pSortType As SortType)
            MyBase.mSortType = pSortType
        End Sub

        Public Overrides Function Compare(ByVal x As Object, ByVal y As Object) As Integer
            Dim a, b As String

            Try
                a = x.ToString
                b = y.ToString

                Select Case MyBase.SortType
                    Case SortType.Alphabetic
                        Return [String].Compare(a, b)
                    Case SortType.Numeric
                        If CType(a, Integer) > CType(b, Integer) Then Return 1
                        If CType(a, Integer) < CType(b, Integer) Then Return -1
                        Return 0
                    Case SortType.NumericPrefix
                        If StripLeftNumbers(a) > StripLeftNumbers(b) Then Return 1
                        If StripLeftNumbers(a) < StripLeftNumbers(b) Then Return -1
                        Return 0
                    Case SortType.NumericSuffix
                        If StripRightNumbers(a) > StripRightNumbers(b) Then Return 1
                        If StripRightNumbers(a) < StripRightNumbers(b) Then Return -1
                        Return 0
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

    'load a sorted list from an object collection
    Public Shared Function LoadSortedList(ByVal Objects As Objects.ObjectDataCollection, ByVal SortType As SortType) As SortedList
        Dim Obj As Objects.ObjectData
        Dim Key As String
        Dim List As SortedList

        Try
            List = New SortedList(New ObjectDataComparer(SortType), Objects.Count)

            For Each Obj In Objects
                If SortType = SortType.Alphabetic Then
                    Key = Obj.Name & Obj.ObjectGUID.ToString
                    'Key = Key.Replace(" ", "")
                    'Key = Key.Replace("-", "")
                Else
                    Key = Obj.Name
                End If
                'List.Add(Key, Obj)
                List.Item(Key) = Obj
            Next

            Return List

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'load a sorted list from an arraylist of tag data
    'Public Shared Function LoadSortedArrayList(ByVal ObjTagData As ArrayList, ByVal SortType As SortType) As SortedList
    '    Dim ObjData As Explorer.ObjectTagData
    '    Dim Key As String
    '    Dim List As SortedList

    '    Try
    '        List = New SortedList(New ObjectDataComparer(SortType), ObjTagData.Count)

    '        For Each ObjData In ObjTagData
    '            If SortType = SortType.Alphabetic Then
    '                Key = ObjData.Name & ObjData.ObjectGUID.ToString
    '                Key = Key.Replace(" ", "")
    '                Key = Key.Replace("-", "")
    '            Else
    '                Key = ObjData.Name
    '            End If

    '            List.Add(Key, ObjData)
    '        Next

    '        Return List

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Function

    'strip the leftmost numbers from a string up to the first non-numeric char
    Public Shared Function StripLeftNumbers(ByVal Str As String) As Integer
        Dim c As Char
        Dim pos As Integer
        Dim num As String = ""

        Try
            pos = 0

            While pos < Str.Length
                c = Str.Chars(pos)
                If [Char].IsDigit(c) Then
                    num = num & c.ToString
                Else
                    Exit While
                End If
                pos += 1
            End While

            If num.Length = 0 Then
                Return 0
            Else
                Return CType(num, Integer)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'strip the rightmost numbers from a string up to the first non-numeric char
    Public Shared Function StripRightNumbers(ByVal Str As String) As Integer
        Dim c As Char
        Dim pos As Integer
        Dim num As String = ""

        Try
            pos = Str.Length - 1

            While pos <= Str.Length - 1 And pos >= 0
                c = Str.Chars(pos)
                If [Char].IsNumber(c) Then
                    num = c.ToString & num
                Else
                    Exit While
                End If
                pos -= 1
            End While

            If num.Length = 0 Then
                Return 0
            Else
                Return CType(num, Integer)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'function to flip a string so that 1st char becomes last etc.
    Public Shared Sub FlipString(ByRef inStr As String)
        Dim inTemp As String = ""
        Dim pos As Integer

        Try
            If inStr.Length < 2 Then Exit Sub
            pos = inStr.Length - 1
            While pos >= 0
                inTemp += inStr.Chars(pos)
                pos -= 1
            End While
            inStr = inTemp
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
