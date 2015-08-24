Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Imports System.Xml
Imports RPGXplorer.General
Imports RPGXplorer.Objects

Namespace Rules

    Public Class Index

        Public Structure IndexEntry
            Implements IComparable

            Public Name As String
            Public ObjectGUID As Objects.ObjectKey

            'return standard compare to range i.e. zero is match, negative is less than, etc.
            Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
                Dim temp As IndexEntry

                Try
                    temp = CType(obj, IndexEntry)
                    If temp.Name = Name Then Return 0
                    If temp.Name < Name Then Return 1
                    If temp.Name > Name Then Return -1

                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

        End Structure

        'get an index for the object type
        Public Shared Function Index(ByVal Database As Integer, ByVal Type As String, Optional ByVal AddBlank As Boolean = False, Optional ByVal RemoveGuid As String = "") As IndexEntry()
            Dim IndexEntry As New IndexEntry
            Dim Nodes As XmlNodeList
            Dim Node As XmlNode
            Dim x As Integer

            Try
                'get the nodes
                Nodes = XML.SelectNodes(Database, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Type & "' and ObjectGUID!='" & RemoveGuid & "']")
                If Nodes.Count = 0 Then
                    ReDim Index(-1)
                    Return Index
                End If

                'size the index 
                If AddBlank = False Then
                    x = 0
                    ReDim Index(Nodes.Count - 1)
                Else
                    x = 1
                    ReDim Index(Nodes.Count)
                End If

                'populate the index
                For Each Node In Nodes
                    IndexEntry.Name = Node.SelectSingleNode("./Name").InnerText
                    IndexEntry.ObjectGUID = New Objects.ObjectKey(Node.SelectSingleNode("./ObjectGUID").InnerText)
                    Index.SetValue(IndexEntry, x)
                    x += 1
                Next

                Array.Sort(Index)

                Return Index

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the index of a given guid
        Public Shared Function GetGuidIndex(ByVal Index As IndexEntry(), ByVal ObjectGUID As Objects.ObjectKey) As Integer
            Dim n As Integer

            Try
                'if there is no guid then return -1
                If ObjectGUID.Equals(Objects.ObjectKey.Empty) Then Return -1

                For n = 0 To Index.GetLength(0) - 1
                    If Index(n).ObjectGUID.Equals(ObjectGUID) Then Return n
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'turns an index into a list of names, useful for populating combos
        Public Shared Function IndexNames(ByVal Index() As IndexEntry) As String()
            Dim temp As String()
            Dim x As Integer

            Try
                ReDim temp(Index.GetUpperBound(0))

                For x = 0 To Index.GetUpperBound(0)
                    If Index(x).Name Is Nothing Then
                        temp(x) = ""
                    Else
                        temp(x) = Index(x).Name
                    End If
                Next

                Return temp

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get alignment list
        Public Shared Function AlignmentDataList() As DataListItem()
            Try
                Dim Alignments() As DataListItem
                ReDim Alignments(8)
                Dim Item As DataListItem

                Item = New DataListItem(Nothing, References.LawfulGood, "Lawful Good")
                Alignments(0) = Item

                Item = New DataListItem(Nothing, References.LawfulNeutral, "Lawful Neutral")
                Alignments(1) = Item

                Item = New DataListItem(Nothing, References.LawfulEvil, "Lawful Evil")
                Alignments(2) = Item

                Item = New DataListItem(Nothing, References.NeutralGood, "Neutral Good")
                Alignments(3) = Item

                Item = New DataListItem(Nothing, References.TrueNeutral, "True Neutral")
                Alignments(4) = Item

                Item = New DataListItem(Nothing, References.NeutralEvil, "Neutral Evil")
                Alignments(5) = Item

                Item = New DataListItem(Nothing, References.ChaoticGood, "Chaotic Good")
                Alignments(6) = Item

                Item = New DataListItem(Nothing, References.ChaoticNeutral, "Chaotic Neutral")
                Alignments(7) = Item

                Item = New DataListItem(Nothing, References.ChaoticEvil, "Chaotic Evil")
                Alignments(8) = Item

                Return Alignments

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects of given type
        Public Shared Function DataList(ByVal Database As Integer, ByVal Type As String, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim DataItem As DataListItem
            Dim obj As ObjectData
            Dim x As Integer

            Dim temp As Objects.ObjectDataCollection

            Try
                temp = GetAllObjectsOfType(Database, Type)

                If temp.Count = 0 Then
                    ReDim DataList(-1)
                    Return DataList
                End If

                'size the index 
                If AddBlank = False Then
                    x = 0
                    ReDim DataList(temp.Count - 1)
                Else
                    x = 1
                    ReDim DataList(temp.Count)
                    DataList.SetValue(New DataListItem(Nothing, ""), 0)
                End If

                For Each obj In temp
                    DataItem = New DataListItem(obj, obj.ObjectGUID, obj.Name)
                    DataList.SetValue(DataItem, x)
                    x += 1
                Next

                Array.Sort(DataList)

                Return DataList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects in the collection
        Public Shared Function DataList(ByVal Objects As Objects.ObjectDataCollection, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim DataItem As DataListItem
            Dim obj As ObjectData
            Dim x As Integer

            Try
                If Objects.Count = 0 Then
                    ReDim DataList(-1)
                    Return DataList
                End If

                'size the index 
                If AddBlank = False Then
                    x = 0
                    ReDim DataList(Objects.Count - 1)
                Else
                    x = 1
                    ReDim DataList(Objects.Count)
                    DataList.SetValue(New DataListItem(Nothing, ""), 0)
                End If

                For Each obj In Objects
                    DataItem = New DataListItem(obj, obj.ObjectGUID, obj.Name)
                    DataList.SetValue(DataItem, x)
                    x += 1
                Next

                Array.Sort(DataList)

                Return DataList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects in the collection
        Public Shared Function DataList(ByVal List As ArrayList, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim x As Integer

            Try
                If List.Count = 0 Then
                    ReDim DataList(-1)
                    Return DataList
                End If

                'size the index 
                If AddBlank = False Then
                    x = 0
                    ReDim DataList(List.Count - 1)
                Else
                    x = 1
                    ReDim DataList(List.Count)
                    DataList.SetValue(New DataListItem(Nothing, ""), 0)
                End If

                For Each DataItem As DataListItem In List
                    DataList.SetValue(DataItem, x)
                    x += 1
                Next

                Array.Sort(DataList)

                Return DataList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects that match the xpath query
        Public Shared Function DataListXPath(ByVal Database As Integer, ByVal Query As String, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim DataItem As DataListItem
            Dim obj As ObjectData
            Dim x As Integer

            Dim temp As Objects.ObjectDataCollection

            Try
                temp = Objects.GetObjectsByXPath(Database, Query)

                If temp.Count = 0 Then
                    ReDim DataListXPath(-1)
                    Return DataListXPath
                End If

                'size the index 
                If AddBlank = False Then
                    x = 0
                    ReDim DataListXPath(temp.Count - 1)
                Else
                    x = 1
                    ReDim DataListXPath(temp.Count)
                    DataListXPath.SetValue(New DataListItem(Nothing, ""), 0)
                End If

                For Each obj In temp
                    DataItem = New DataListItem(obj, obj.ObjectGUID, obj.Name)
                    DataListXPath.SetValue(DataItem, x)
                    x += 1
                Next

                Array.Sort(DataListXPath)

                Return DataListXPath

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects of given type then remove all objects with specified guids
        Public Shared Function DataListExclude(ByVal Database As Integer, ByVal Type As String, ByVal ExcludeList As ArrayList, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim List As DataListItem()
            Dim NewList As DataListItem()
            Dim n, m As Integer

            Try
                List = DataList(Database, Type, AddBlank)
                ReDim NewList(List.GetUpperBound(0))

                m = 0
                For n = 0 To List.GetUpperBound(0)
                    If Not ExcludeList.Contains(List(n).ObjectGUID) Then
                        NewList(m) = List(n)
                        m += 1
                    End If
                Next

                'resize the new list to exclude any empty array entries at the end
                For n = 0 To NewList.GetUpperBound(0)
                    If NewList(n) Is Nothing Then
                        If n = 0 Then Return Nothing
                        ReDim Preserve NewList(n - 1)
                        Exit For
                    End If
                Next

                Return NewList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects that match the xpath query then remove all objects with specified guids
        Public Shared Function DataListXPathExclude(ByVal Database As Integer, ByVal Query As String, ByVal ExcludeList As ArrayList, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim List As DataListItem()
            Dim NewList As DataListItem()
            Dim n, m As Integer

            Try
                List = DataListXPath(Database, Query, AddBlank)
                ReDim NewList(List.GetUpperBound(0))

                m = 0
                For n = 0 To List.GetUpperBound(0)
                    If Not ExcludeList.Contains(List(n).ObjectGUID) Then
                        NewList(m) = List(n)
                        m += 1
                    End If
                Next

                'resize the new list to exclude any empty array entries at the end
                For n = 0 To NewList.GetUpperBound(0)
                    If NewList(n) Is Nothing Then
                        If n = 0 Then Return Nothing
                        ReDim Preserve NewList(n - 1)
                        Exit For
                    End If
                Next

                Return NewList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'make list of all objects of given type then remove all objects with specified guids
        Public Shared Function DataListExclude(ByVal Objects As Objects.ObjectDataCollection, ByVal ExcludeList As ArrayList, Optional ByVal AddBlank As Boolean = False) As DataListItem()
            Dim List As DataListItem()
            Dim NewList As DataListItem()
            Dim n, m As Integer

            Try
                List = DataList(Objects, AddBlank)
                ReDim NewList(List.GetUpperBound(0))

                m = 0
                For n = 0 To List.GetUpperBound(0)
                    If Not ExcludeList.Contains(List(n).ObjectGUID) Then
                        NewList(m) = List(n)
                        m += 1
                    End If
                Next

                'resize the new list to exclude any empty array entries at the end
                For n = 0 To NewList.GetUpperBound(0)
                    If NewList(n) Is Nothing Then
                        If n = 0 Then Return Nothing
                        ReDim Preserve NewList(n - 1)
                        Exit For
                    End If
                Next

                Return NewList

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the index of a given guid (datalistitem)
        Public Shared Function GetGuidIndex(ByVal Item As DataListItem(), ByVal ObjectGUID As Objects.ObjectKey) As Integer
            Dim n As Integer

            Try
                'if there is no guid then return -1
                If ObjectGUID.Equals(Objects.ObjectKey.Empty) Then Return -1

                For n = 0 To Item.GetLength(0) - 1
                    If Item(n).ObjectGUID.Equals(ObjectGUID) Then Return n
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'returns the index of a Datalist Item in an array, based on a search name
        Public Shared Function GetNameIndex(ByVal Item As DataListItem(), ByVal Searchname As String) As Integer
            Dim Searchitem As DataListItem
            Dim Pos As Integer

            Try
                Searchitem = New DataListItem(Nothing, Searchname)
                Pos = Array.BinarySearch(Item, Searchitem)
                If Pos < 0 Then
                    Return -1
                Else
                    Return Pos
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the index of a given object value (datalistitem)
        Public Shared Function GetObjectIndex(ByVal Item As DataListItem(), ByVal Value As Object) As Integer
            Try
                For n As Integer = 0 To Item.GetLength(0) - 1
                    If Item(n).ValueMember.Equals(Value) Then Return n
                Next

                Return -1
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace