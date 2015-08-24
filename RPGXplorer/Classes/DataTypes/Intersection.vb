Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Public Class Intersection

    'this class provides a way of storing a 3 tier tree of distinct lists of guids.
    'at the top level there can be multiple root nodes
    'purpose of datatype is to provide an intersection set of the bottom level keys for a given root.

#Region "Member Variables"

    Private Level1 As ObjectHashtable

#End Region

    'constructor
    Public Sub New()
        Level1 = New ObjectHashtable
    End Sub

    'add
    Public Sub AddItem(ByVal Key1 As Objects.ObjectKey, ByVal Key2 As Objects.ObjectKey, ByVal Key3 As Objects.ObjectKey)
        Dim Level2, Level3 As ObjectHashtable

        If Key3.Database = 0 Then General.ShowInfoDialog("DB0")

        'level 1
        If Not Level1.Contains(Key1) Then
            Level2 = New ObjectHashtable
            Level1.Add(Key1, Level2)
        Else
            Level2 = DirectCast(Level1.Item(Key1), ObjectHashtable)
        End If

        'level2
        If Not Level2.Contains(Key2) Then
            Level3 = New ObjectHashtable
            Level2.Add(Key2, Level3)
        Else
            Level3 = DirectCast(Level2.Item(Key2), ObjectHashtable)
        End If

        'level3
        If Not Level3.Contains(Key3) Then
            Level3.Add(Key3, Nothing)
        End If
    End Sub

    'remove
    Public Sub RemoveItem(ByVal Key As Objects.ObjectKey)
        If Level1.Contains(Key) Then
            Level1.Remove(Key)
        End If
    End Sub

    'contains
    Public Function ContainsItem(ByVal Key1 As Objects.ObjectKey, ByVal Key2 As Objects.ObjectKey, ByVal Key3 As Objects.ObjectKey) As Boolean
        If Level1.Contains(Key1) Then
            If DirectCast(Level1.Item(Key1), ObjectHashtable).Contains(Key2) Then
                If DirectCast(DirectCast(Level1.Item(Key1), ObjectHashtable).Item(Key2), ObjectHashtable).Contains(Key3) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    'contains
    Public Function ContainsItem(ByVal Key1 As Objects.ObjectKey) As Boolean
        If Level1.Contains(Key1) Then
            Return True
        Else
            Return False
        End If
    End Function

    'get the intersection for a given level 1 key
    Public Function Intersection(ByVal Key As Objects.ObjectKey) As ArrayList
        If Level1.Contains(Key) Then
            Dim Level2 As ICollection = DirectCast(Level1.Item(Key), ObjectHashtable).Values
            Dim Level3Keys As ICollection
            Dim Interim As New ObjectHashtable
            Dim Count As Integer

            'count the number of cross matches between the level 3 key sets
            For Each Level3 As ObjectHashtable In Level2
                Level3Keys = Level3.Keys
                For Each Key2 As Objects.ObjectKey In Level3Keys
                    If Interim.Contains(Key2) Then
                        Count = DirectCast(Interim.Item(Key2), Integer)
                        Interim.Item(Key2) = Count + 1
                    Else
                        Interim.Add(Key2, 1)
                    End If
                Next
            Next

            'only return those keys whose count matches the number of level 2 keys
            'i.e. only those level 3 keys that appear in each level 2 set.
            Intersection = New ArrayList
            For Each Key3 As Objects.ObjectKey In Interim.Keys
                If DirectCast(Interim.Item(Key3), Integer) = Level2.Count Then Intersection.Add(Key3)
            Next

            Return Intersection
        Else
            Return New ArrayList
        End If
    End Function

    'get the superset for a given level 1 key
    Public Function Superset(ByVal Key As Objects.ObjectKey) As ArrayList
        If Level1.Contains(Key) Then
            Superset = New ArrayList

            For Each Level2Item As DictionaryEntry In DirectCast(Level1.Item(Key), ObjectHashtable)
                For Each Level3Item As DictionaryEntry In DirectCast(Level2Item.Value, ObjectHashtable)
                    Superset.Add(New Objects.ObjectKey(CStr(Level3Item.Key)))
                Next
            Next
        Else
            Return New ArrayList
        End If
    End Function

End Class
