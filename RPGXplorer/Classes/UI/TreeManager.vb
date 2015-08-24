Option Explicit On 
Option Strict On

Imports System.Windows.Forms
Imports System.Threading

Imports RPGXplorer.General
Imports RPGXplorer.Objects

Public Class TreeManager

    'this class is responsible for loading a single tree view control

#Region "Member Variables"

    Public IsLoading As Boolean

    Private _TreeView As TreeView
    Private _Form As Form 'treeview's parent form

    Private _KeyIndex As ObjectHashtable 'indexed by object key
    'Private _NameIndex As Collections.Specialized. 'indexed by object name

    'threading
    Private UseThread As Boolean
    Private AddToTree As AddToTreeDelegate
    Public Shared Mutex As New Mutex

#End Region

#Region "Properties"

    ReadOnly Property KeyNodeIndex() As ObjectHashtable
        Get
            Return _KeyIndex
        End Get
    End Property

#End Region

#Region "Structures"

    'data held in each tree node's tag
    Public Structure TreeNodeTagData
        Public ObjectName As String
        Public ObjectKey As ObjectKey
        Public ObjectType As String
        Public ChildrenLoaded As Boolean
    End Structure

#End Region

#Region "Delegates"

    'delegate type for tree view loader to talk to main thread 
    Public Delegate Sub AddToTreeDelegate(ByVal Node As TreeNode, ByVal Nodes As TreeNode())

#End Region

    'constructor
    Public Sub New(ByVal TreeView As TreeView)
        Try
            _TreeView = TreeView
            _TreeView.ImageList = Images.SmallImages
            _Form = TreeView.FindForm
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load the tree
    Public Sub LoadTree(ByVal FolderObjects As Objects.ObjectDataCollection, ByVal PageObjects As Objects.ObjectDataCollection, Optional ByVal ProgressBar As ProgressBar = Nothing)
        Try
            _TreeView.BeginUpdate()

            _KeyIndex = New ObjectHashtable()
            Dim TreeNodes As New ExplorerTreeNodeHashtable

            'folders
            Dim SomethingAdded As Boolean
            Dim Hits As Integer = FolderObjects.Count
            Dim Node As TreeNode

            While Hits > 0
                SomethingAdded = False
                For Each FolderObj As Objects.ObjectData In FolderObjects
                    If Not TreeNodes.Contains(FolderObj.ObjectGUID) Then
                        If FolderObj.ParentGUID.Equals(Objects.ObjectKey.Empty) Then
                            Node = TreeNodeFromObject(FolderObj)
                            _TreeView.Nodes.Add(Node)
                            TreeNodes.Add(FolderObj.ObjectGUID, Node)
                            UpdateIndex(Node)
                            Hits -= 1
                            SomethingAdded = True
                            If Not ProgressBar Is Nothing Then ProgressBar.Increment()
                        ElseIf TreeNodes.Contains(FolderObj.ParentGUID) Then
                            Node = TreeNodeFromObject(FolderObj)
                            CType(TreeNodes.Item(FolderObj.ParentGUID), TreeNode).Nodes.Add(Node)
                            TreeNodes.Add(FolderObj.ObjectGUID, Node)
                            UpdateIndex(Node)
                            Hits -= 1
                            SomethingAdded = True
                            If Not ProgressBar Is Nothing Then ProgressBar.Increment()
                        End If
                    End If
                Next
                If Not SomethingAdded Then
                    'there has been a problem - some folder is missing
                    If Not ProgressBar Is Nothing Then ProgressBar.Increment(Hits)
                    Exit While
                End If
            End While

            'pages
            Dim ParentNode As TreeNode
            For Each PageObj As Objects.ObjectData In PageObjects
                Node = TreeNodeFromObject(PageObj)

                'get the parent node and add the child
                ParentNode = CType(TreeNodes.Item(PageObj.ParentGUID), TreeNode)
                If Not ParentNode Is Nothing Then
                    ParentNode.Nodes.Add(Node)
                    UpdateIndex(Node)
                End If

                If Not ProgressBar Is Nothing Then ProgressBar.Increment()
            Next

            _TreeView.EndUpdate()

            IsLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'helper function that converts an object data structure into a tree node
    Public Function TreeNodeFromObject(ByVal Obj As ObjectData) As TreeNode
        Dim Node As New TreeNode
        Dim ImageIndex As Integer
        Dim TagData As TreeNodeTagData

        Node.Text = Obj.Name
        TagData.ObjectName = Obj.Name
        TagData.ObjectKey = Obj.ObjectGUID
        TagData.ObjectType = Obj.Type
        Node.Tag = TagData
        ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)
        Node.ImageIndex = ImageIndex
        Node.SelectedImageIndex = ImageIndex

        Return Node
    End Function

    'helper that updates the indexes for a node
    Private Sub UpdateIndex(ByVal Node As TreeNode)
        Dim TagData As TreeNodeTagData = CType(Node.Tag, TreeNodeTagData)

        If _KeyIndex.Contains(TagData.ObjectKey) Then _KeyIndex.Remove(TagData.ObjectKey)
        _KeyIndex.Add(TagData.ObjectKey, Node)

        'NAME INDEX REQUIRES A NEW DATA TYPE THAT SUPPORTS MULTIPLE ENTRIES PER KEY
        'If _NameIndex.Contains(TagData.ObjectName) Then _NameIndex.Remove(TagData.ObjectKey)
        '_NameIndex.Add(TagData.ObjectName, Nodes(n))
    End Sub

    'helper that updates the indexes with a set of nodes
    Private Sub UpdateIndexes(ByVal Nodes As TreeNode())
        Try
            For n As Integer = 0 To Nodes.GetUpperBound(0)
                Dim TagData As TreeNodeTagData = CType(Nodes(n).Tag, TreeNodeTagData)

                If _KeyIndex.Contains(TagData.ObjectKey) Then _KeyIndex.Remove(TagData.ObjectKey)
                _KeyIndex.Add(TagData.ObjectKey, Nodes(n))

                'NAME INDEX REQUIRES A NEW DATA TYPE THAT SUPPORTS MULTIPLE ENTRIES PER KEY
                'If _NameIndex.Contains(TagData.ObjectName) Then _NameIndex.Remove(TagData.ObjectKey)
                '_NameIndex.Add(TagData.ObjectName, Nodes(n))
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creates a sorted list of tree nodes from a set of objects
    Private Function CreateNodeArray(ByVal Objects As ObjectDataCollection) As TreeNode()
        Try
            Dim SortedList As SortedList = Sorter.LoadSortedList(Objects, SortType.Alphabetic)
            Dim Enumerator As IDictionaryEnumerator = SortedList.GetEnumerator
            Dim Obj As ObjectData
            Dim TreeNode As TreeNode
            Dim TreeNodes As New ArrayList

            Do While Enumerator.MoveNext
                Obj = CType(Enumerator.Value, ObjectData)
                If Obj.ShowInTree Then
                    TreeNode = TreeNodeFromObject(Obj)
                    TreeNodes.Add(TreeNode)
                End If
            Loop

            Dim Array As TreeNode()
            ReDim Array(TreeNodes.Count - 1)
            For n As Integer = 0 To Array.GetUpperBound(0)
                Array(n) = CType(TreeNodes(n), TreeNode)
            Next

            Return Array

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'recursive portion of the tree loader
    Public Sub LoadNodes(ByVal FirstNode As TreeNode)
        Try
            Dim Node As TreeNode
            Dim Flag As Boolean

            Flag = True
            Node = FirstNode

            'step through each node at the current level
            While Flag

                'load the children of the current node
                LoadChildNodes(Node)

                'recurse
                If Not Node.FirstNode Is Nothing Then LoadNodes(Node.FirstNode)

                'step through sibling nodes
                Node = Node.NextNode
                If Node Is Nothing Then Flag = False
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load the child folders of the tree node
    Private Sub LoadChildNodes(ByVal Node As TreeNode)
        Try
            Dim Obj As New ObjectData
            Dim ChildObjects As ObjectDataCollection
            Dim ChildNodes As TreeNode()

            Node.Nodes.Clear()
            Obj.Load(CType(Node.Tag, TreeNodeTagData).ObjectKey)
            ChildObjects = Obj.Children
            ChildNodes = CreateNodeArray(ChildObjects)

            Node.Nodes.AddRange(ChildNodes)
            Dim TagData As TreeNodeTagData = CType(Node.Tag, TreeNodeTagData)
            TagData.ChildrenLoaded = True
            Node.Tag = TagData

            'update the indexes
            If ChildObjects.Count > 0 Then UpdateIndexes(ChildNodes)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reload single node's children and children's children recursively.
    Public Sub ReloadNodeChildren(ByVal Node As TreeNode)
        Try
            LoadChildNodes(Node)
            If Node.Nodes.Count > 0 Then LoadNodes(Node.Nodes(0))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove a list of objects from the tree (ties in with Clipboard.Paste for Cut)
    Public Sub RemoveObjectsFromTree(ByVal ObjGuids As ArrayList, Optional ByVal CheckNode As TreeNode = Nothing)
        Dim Node As TreeNode
        Dim TagData As TreeNodeTagData

        'recursive
        If CheckNode Is Nothing Then
            For Each Node In _TreeView.Nodes
                RemoveObjectsFromTree(ObjGuids, Node)
            Next
        Else
            TagData = CType(CheckNode.Tag, TreeNodeTagData)
            If ObjGuids.Contains(TagData.ObjectKey) Then
                CheckNode.Remove()
            Else
                Dim RemoveNodes As New ArrayList
                Dim RecurseNodes As New ArrayList

                For Each Node In CheckNode.Nodes
                    TagData = CType(Node.Tag, TreeNodeTagData)
                    If ObjGuids.Contains(TagData.ObjectKey) Then
                        RemoveNodes.Add(Node)
                    Else
                        RecurseNodes.Add(Node)
                    End If
                Next

                For Each Node In RemoveNodes
                    Node.Remove()
                Next

                For Each Node In RecurseNodes
                    RemoveObjectsFromTree(ObjGuids, Node)
                Next

            End If
        End If
    End Sub

End Class
