Public Class RPGXInheritedListView

    Public Shadows ReadOnly Property SelectedItems() As List(Of ListViewItem)
        Get
            Dim ReturnCollection As New List(Of ListViewItem)

            For Each item As ListViewItem In Me.Items
                If item.Selected = True Then
                    ReturnCollection.Add(item)
                End If
            Next

            Return ReturnCollection

        End Get
    End Property

    Public Shadows ReadOnly Property SelectedIndices() As List(Of Integer)
        Get
            Dim ReturnCollection As New List(Of Integer)

            For i As Integer = 0 To Me.Items.Count - 1
                Dim item As ListViewItem = Me.Items(i)
                If item.Selected = True Then
                    ReturnCollection.Add(i)
                End If
            Next

            Return ReturnCollection
        End Get
    End Property

End Class
