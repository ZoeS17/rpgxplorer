Option Explicit On
Option Strict On

Public Class RPGXListView

    'variables
    Private ListViewManager As ListViewManager

    'events

    'init
    Public Sub Init(ByVal FolderKey As Objects.ObjectKey, ByVal FolderType As String, ByVal SortType As General.SortType)
        Try

            'reset the current view
            ListView.Clear()

            'set the ListViewManager an add the column headers
            ListViewManager = New ListViewManager(Me.ListView, FolderKey, FolderType, SortType)
            ListViewManager.SetListViewColumns()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add the given objects into the Listview
    Public Sub AddRange(ByVal ObjectList As Objects.ObjectDataCollection, Optional ByVal VirtualObjects As Boolean = False)
        Try
            If ObjectList Is Nothing Then Exit Sub

            If ObjectList.Count > 0 Then

                ListView.BeginUpdate()
                ListViewManager.LoadListViewItems(ObjectList, VirtualObjects)
                ListViewManager.SortListView()
                ListView.EndUpdate()
                ListViewManager.ColourListView()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add the object into the ListView
    Public Sub Add(ByVal Obj As Objects.ObjectData, Optional ByVal VirtualObjects As Boolean = False)
        Try
            If Obj.ObjectGUID.IsNotEmpty Then
                Dim TempCollection As New Objects.ObjectDataCollection
                TempCollection.Add(Obj)
                ListView.BeginUpdate()
                ListViewManager.LoadListViewItems(TempCollection, VirtualObjects)
                ListViewManager.SortListView()
                ListView.EndUpdate()
                ListViewManager.ColourListView()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable
    Public Shadows Property Enabled() As Boolean
        Get
            Return Me.ListView.Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me.ListView.Enabled = Value
            MyBase.Enabled = Value
        End Set
    End Property

    'save the current layout
    Public Sub SaveColumnLayout()
        Try
            ListViewManager.SaveColumnLayout()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'returns an ObjectDataCollection with all the objects currently selected
    Public Function SelectedObjects() As Objects.ObjectDataCollection
        Try
            Dim ReturnCollection As New Objects.ObjectDataCollection

            If ListView.SelectedItems.Count > 0 Then
                Dim TempKey As Objects.ObjectKey
                Dim TempObject As New Objects.ObjectData

                For Each Item As ListViewItem In ListView.SelectedItems
                    If TypeOf Item.Tag Is Objects.ObjectKey Then
                        TempKey = CType(Item.Tag, Objects.ObjectKey)
                        If TempKey.IsNotEmpty AndAlso Not ReturnCollection.Contains(TempKey) Then
                            TempObject.Clear()
                            TempObject.Load(TempKey)
                            ReturnCollection.Add(TempObject)
                        End If
                    ElseIf TypeOf Item.Tag Is Objects.ObjectData Then
                        TempObject = CType(Item.Tag, Objects.ObjectData)
                        If TempObject.ObjectGUID.IsNotEmpty AndAlso (Not ReturnCollection.Contains(TempObject.ObjectGUID)) Then
                            ReturnCollection.Add(TempObject)
                        End If
                    End If
                Next
            End If

            Return ReturnCollection

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Function

    'clear the items
    Public Sub ClearItems()
        Try
            ListView.Items.Clear()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'item count
    Public Function Count() As Integer
        Try
            Return ListView.Items.Count
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'colors the list view - can be called from a UserControls/Forms VisableChanged event - to make sure correct coloring is in place
    Public Sub ColorListview()
        Try
            ListViewManager.ColourListView()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
