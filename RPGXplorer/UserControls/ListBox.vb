Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ListBox

    Public Event SelectedItemChanged()

    'Private Items As New ArrayList

    'enabled
    Public Shadows Property Enabled() As Boolean
        Get
            Return Me.List.Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me.List.Enabled = Value
            MyBase.Enabled = Value
        End Set
    End Property

    'selected item property
    Public Property SelectedIndex() As Integer
        Get
            Return List.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            Try
                List.SelectedIndex = Value
            Catch ex As Exception

            End Try
        End Set
    End Property

    'add an item to the list box
    Public Sub AddItem(ByVal Text As String, ByVal GUID As Objects.ObjectKey)
        Dim Item As General.DataListItem
        Try
            Item = New General.DataListItem(GUID, GUID, Text)
            List.Items.Add(Item)
            List.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add an item to the list box
    Public Sub AddItem(ByVal Text As String, ByVal Data As Object)
        Dim Item As General.DataListItem

        Try
            Item = New General.DataListItem(Data, Text)
            List.Items.Add(Item)
            List.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add an item to the list box
    Public Sub AddItem(ByVal Data As Object)
        Dim Item As General.DataListItem

        Try
            If TypeOf Data Is Objects.ObjectData Then
                Item = New General.DataListItem(Data, CType(Data, Objects.ObjectData).ObjectGUID, Data.ToString)
            Else
                Item = New General.DataListItem(Data, Data.ToString)
            End If

            List.Items.Add(Item)
            List.Refresh()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add an item to the list box
    Public Sub AddItem(ByVal Data As Objects.ObjectData)
        Dim Item As General.DataListItem
        Try
            Item = New General.DataListItem(Data, Data.ObjectGUID, Data.ToString)
            List.Items.Add(Item)
            List.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Returns the number of items in the control
    Public Function Count() As Integer
        Try
            Return List.Items.Count
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'remove the currently selected item
    Public Sub RemoveSelectedItem()
        Dim Index As Integer

        Try
            Index = Me.SelectedIndex
            RemoveItem(Index)
            If Me.Count > 0 Then
                If Me.Count = 0 Then
                    'do nothing
                ElseIf Index > Me.Count - 1 Then
                    Me.SelectedIndex = Me.Count - 1
                Else
                    Me.SelectedIndex = Index
                End If
            Else
                Me.SelectedIndex = -1
            End If
            List.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove an item
    Public Sub RemoveItem(ByVal Index As Integer)
        Try
            List.Items.RemoveAt(Index)
            List.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove an item
    Public Sub RemoveItem(ByVal Name As String)
        Dim index As Integer

        Try
            Dim TempArray As ArrayList
            TempArray = New ArrayList(List.Items)
            index = TempArray.BinarySearch(New General.DataListItem(Nothing, Name))

            If index > -1 Then
                List.Items.RemoveAt(index)
                List.Refresh()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove an item
    Public Sub RemoveItem(ByVal Guid As Objects.ObjectKey)
        Dim index As Integer = -1

        Try
            For n As Integer = 0 To List.Items.Count - 1
                If CType(List.Items(n), DataListItem).ObjectGUID.Equals(Guid) Then
                    index = n
                End If
            Next

            If index > -1 Then
                List.Items.RemoveAt(index)
                List.Refresh()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the guid of the currently selected item
    Public Function ItemGUID() As Objects.ObjectKey
        Try
            Return CType(List.SelectedItem, DataListItem).ObjectGUID
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the guid of the object at the specified index
    Public Function ItemGUID(ByVal Index As Integer) As Objects.ObjectKey
        Try
            Return CType(List.GetItem(Index), DataListItem).ObjectGUID
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the name of the currently selected item
    Public Function ItemName() As String
        Try
            Return List.GetItemText(List.SelectedIndex)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get the name of the object at the specified index
    Public Function ItemName(ByVal Index As Integer) As String
        Try
            Return List.GetItemText(Index)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'property for the item at the given position
    Public Property ItemObject(ByVal Index As Integer) As Object
        Get
            Try
                Return List.GetItemValue(Index)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
        Set(ByVal Value As Object)
            Try
                Dim Item As General.DataListItem

                Item = CType(List.Items(Index), General.DataListItem)
                Item.DisplayMember = Value.ToString()
                Item.ValueMember = Value
                List.Refresh()
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Set
    End Property

    'property for the currently selected item
    Public ReadOnly Property ItemObject() As Objects.ObjectData
        Get
            Try
                If List.SelectedItem Is Nothing Then
                    Return Nothing
                Else
                    Return CType(CType(List.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

    'check to see if the list already contains this guid
    Public Shadows Function Contains(ByVal GUID As Objects.ObjectKey) As Boolean
        Dim Enumerator As IEnumerator
        Dim Data As General.DataListItem
        Try
            Enumerator = List.Items.GetEnumerator
            Do While Enumerator.MoveNext
                Data = CType(Enumerator.Current, General.DataListItem)
                If Data.ObjectGUID.Equals(GUID) Then Return True
            Loop
            Return False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'add a collection of objects to the list
    Public Sub AddObjects(ByVal Objects As Objects.ObjectDataCollection)
        Dim Obj As Objects.ObjectData

        Try
            For Each Obj In Objects
                AddItem(Obj)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add an arraylist of objects to the list
    Public Sub AddObjects(ByVal Objects As ArrayList)
        Try
            For Each Obj As Objects.ObjectData In Objects
                AddItem(Obj)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get a collection of the objects in the list
    Public Function GetObjects() As Objects.ObjectDataCollection
        Dim DataItem As General.DataListItem
        Try

            GetObjects = New Objects.ObjectDataCollection
            For Each DataItem In List.Items
                GetObjects.Add(CType(DataItem.ValueMember, Objects.ObjectData))
            Next

            Return GetObjects
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'clear the list
    Public Sub Clear()
        Try
            List.Items.Clear()
            List.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get enumerator
    Public Function GetEnumerator() As IEnumerator
        Try
            Return List.Items.GetEnumerator
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get data list
    Public Function GetValues() As ArrayList
        Dim DataItem As General.DataListItem

        Try
            GetValues = New ArrayList(List.Items.Count)
            For Each DataItem In List.Items
                GetValues.Add(DataItem.ValueMember)
            Next

            Return GetValues
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'get names list
    Public Function GetNames() As ArrayList
        Try
            GetNames = New ArrayList(List.Items.Count)
            For Each DataItem As DataListItem In List.Items
                GetNames.Add(DataItem.DisplayMember)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'event
    Private Sub List_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List.SelectedIndexChanged
        RaiseEvent SelectedItemChanged()
    End Sub

End Class
