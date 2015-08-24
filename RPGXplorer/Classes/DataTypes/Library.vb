Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

<Serializable()> _
Public Class Library

    'this class is a custom dictionary which handles items in one of three ways:
    'item is unique and should only be stored once
    'item can have multiple copies (item is identical)
    'item can have multiple copies (items are distinguished by subkey)

#Region "Enumerations"

    Public Enum StorageType
        NotSet
        Stack
        Subkey
    End Enum

#End Region

#Region "Member Variables"

    Public Index As ObjectHashtable

#End Region

#Region "Structures"

    <Serializable()> _
    Public Structure LibraryItem
        Public Key As Objects.ObjectKey
        Public StorageType As StorageType
        Public Data As Object
    End Structure

    <Serializable()> _
    Public Structure LibraryData
        Public LevelAcquired As Integer
        Public LevelLost As Integer
        Public Data As Object
    End Structure

#End Region

    'constructor
    Public Sub New()
        Index = New ObjectHashtable()
    End Sub

    'add item - for items without additional keys e.g. focus keys
    Public Sub AddItem(ByVal Key As Objects.ObjectKey, Optional ByVal Data As Object = Nothing, Optional ByVal LevelAcquired As Integer = 0, Optional ByVal LevelLost As Integer = 1000)
        Dim Item As LibraryItem
        Dim Subitem As LibraryData

        Subitem.LevelAcquired = LevelAcquired
        Subitem.LevelLost = LevelLost
        Subitem.Data = Data

        'if ObjectHashtable does not contain key then create new list in bucket otherwise retrieve existing list
        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            If Item.StorageType <> StorageType.Stack Then Throw New DevelopmentException("Stack addition to library cannot proceed because existing bucket is of the wrong storage type.")
        Else
            Item.Key = Key
            Item.StorageType = StorageType.Stack
            Item.Data = New ArrayList
            Index.Add(Key, Item)
        End If

        'append subitem to existing or new list
        DirectCast(Item.Data, ArrayList).Add(Subitem)
        Index.Item(Key) = Item

    End Sub

    'add item - for items that are differentiated by a subkey
    Public Sub AddItemWithSubkey(ByVal Key As Objects.ObjectKey, ByVal SubKey As Objects.ObjectKey, Optional ByVal Data As Object = Nothing, Optional ByVal LevelAcquired As Integer = 0, Optional ByVal LevelLost As Integer = 1000, Optional ByVal Overwrite As Boolean = False)
        AddItemWithSubkey(Key, SubKey.ToString, Data, LevelAcquired, LevelLost, Overwrite)
    End Sub

    'add item - for items that are differentiated by a subkey
    Public Sub AddItemWithSubkey(ByVal Key As Objects.ObjectKey, ByVal SubKey As String, Optional ByVal Data As Object = Nothing, Optional ByVal LevelAcquired As Integer = 0, Optional ByVal LevelLost As Integer = 1000, Optional ByVal Overwrite As Boolean = False)
        Dim Item As LibraryItem
        Dim Subitem As LibraryData

        'retrieve or create ObjectHashtable at key location
        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            If Item.StorageType <> StorageType.Subkey Then Throw New DevelopmentException("Subkey addition to library cannot proceed because existing bucket is of the wrong storage type.")
        Else
            Item.Key = Key
            Item.StorageType = StorageType.Subkey
            Item.Data = New StringKeyHashtable
            Index.Add(Key, Item)
        End If

        'add subitem to subkey ObjectHashtable
        Subitem.LevelAcquired = LevelAcquired
        Subitem.LevelLost = LevelLost
        Subitem.Data = Data

        If Not DirectCast(Item.Data, StringKeyHashtable).Contains(SubKey) Then
            DirectCast(Item.Data, StringKeyHashtable).Add(SubKey, Subitem)
        Else
            If Overwrite Then
                DirectCast(Item.Data, StringKeyHashtable).Item(SubKey) = Subitem
            End If
        End If
    End Sub

    'set item - only for components in stacks. component key is used to identify
    Public Sub SetItem(ByVal Key As Objects.ObjectKey, ByVal Component As Rules.Components.ComponentData, ByVal Position As Integer)
        Dim TempItem As LibraryData
        Dim List As ArrayList = DirectCast(DirectCast(Index.Item(Key), LibraryItem).Data, ArrayList)

        'Set the Component Data
        TempItem = DirectCast(List(Position), LibraryData)
        TempItem.Data = Component

        'Set it back into the arraylist
        List.Item(Position) = TempItem

        Dim LibItem As New LibraryItem
        LibItem.Key = Key
        LibItem.Data = List
        LibItem.StorageType = StorageType.Stack
        Index.Item(Key) = LibItem
    End Sub

    'set item - for items with subkey only
    Public Sub SetItemWithSubkey(ByVal Key As Objects.ObjectKey, ByVal SubKey As Objects.ObjectKey, ByVal Item As LibraryData)
        SetItemWithSubkey(Key, SubKey.ToString, Item)
    End Sub

    'set item - for items with subkey only
    Public Sub SetItemWithSubkey(ByVal Key As Objects.ObjectKey, ByVal SubKey As String, ByVal Item As LibraryData)
        DirectCast(DirectCast(Index.Item(Key), LibraryItem).Data, StringKeyHashtable).Item(SubKey) = Item
    End Sub

    'remove item gained at a particular level - For StackType
    Public Sub RemoveItem(ByVal Key As Objects.ObjectKey, ByVal LevelAcquired As Integer)
        If Index.Contains(Key) Then
            Dim Item As LibraryItem = DirectCast(Index.Item(Key), LibraryItem)

            If Item.StorageType <> StorageType.Stack Then Throw New DevelopmentException("Remove Item called for Stack but storage type is not stack")

            Dim SubItems As ArrayList = DirectCast(Item.Data, ArrayList)

            For Each Subitem As LibraryData In SubItems
                If Subitem.LevelAcquired = LevelAcquired Then
                    SubItems.Remove(Subitem)
                    Exit For
                End If
            Next

            If SubItems.Count = 0 Then Index.Remove(Key)
        End If
    End Sub

    'Remove an enitre Stack
    Public Sub RemoveItemStack(ByVal Key As Objects.ObjectKey)
        Index.Remove(Key)
    End Sub

    'Remove item gained at a particular level - StackType
    'Need this one for removing features - has it possible to have 2 identical
    'features at the same level - but coming from different classes
    Public Sub RemoveItemObject(ByVal Key As Objects.ObjectKey, ByVal ItemObject As Object)
        If Index.Contains(Key) Then
            Dim Item As LibraryItem = DirectCast(Index.Item(Key), LibraryItem)

            If Item.StorageType <> StorageType.Stack Then Throw New DevelopmentException("Remove Item called for Stack but storage type is not stack")

            Dim SubItems As ArrayList = DirectCast(Item.Data, ArrayList)

            For Each Subitem As LibraryData In SubItems
                If ItemObject.Equals(Subitem.Data) Then
                    SubItems.Remove(Subitem)
                    Exit For
                End If
            Next

            If SubItems.Count = 0 Then Index.Remove(Key)
        End If
    End Sub

    'remove item with subkey - For SubKeyType
    Public Sub RemoveItem(ByVal Key As Objects.ObjectKey, ByVal Subkey As Objects.ObjectKey)
        RemoveItem(Key, Subkey.ToString)
    End Sub

    'remove item with subkey - For SubKeyType
    Public Sub RemoveItem(ByVal Key As Objects.ObjectKey, ByVal Subkey As String)
        If Index.Contains(Key) Then
            If DirectCast(DirectCast(Index.Item(Key), LibraryItem).Data, StringKeyHashtable).Contains(Subkey) Then
                DirectCast(DirectCast(Index.Item(Key), LibraryItem).Data, StringKeyHashtable).Remove(Subkey)
            End If

            'if there is nothing left in this storage bucket, remove the key
            If DirectCast(DirectCast(Index.Item(Key), LibraryItem).Data, StringKeyHashtable).Count = 0 Then
                Index.Remove(Key)
            End If
        End If
    End Sub

    'remove all instances of a particular subkey - For SubKeyType
    Public Sub RemoveSubkey(ByVal Subkey As Objects.ObjectKey)
        RemoveSubkey(Subkey.ToString)
    End Sub

    'remove all instances of a particular subkey - For SubKeyType
    Public Sub RemoveSubkey(ByVal Subkey As String)
        Dim EmptyKeys As New ArrayList

        For Each LibraryItem As LibraryItem In Index.Values
            Dim StringKeyHashtable As StringKeyHashtable = DirectCast(LibraryItem.Data, StringKeyHashtable)
            If StringKeyHashtable.ContainsKey(Subkey) Then StringKeyHashtable.Remove(Subkey)
            If StringKeyHashtable.Count = 0 Then EmptyKeys.Add(LibraryItem.Key)
        Next

        For Each Key As Objects.ObjectKey In EmptyKeys
            Index.Remove(Key)
        Next
    End Sub

    'clear
    Public Sub Clear()
        Index.Clear()
    End Sub

    'contains key
    Public Function ContainsKey(ByVal Key As Objects.ObjectKey, Optional ByVal Level As Integer = 1000) As Boolean
        Dim Item As LibraryItem
        Dim SubItem As LibraryData

        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            Select Case Item.StorageType
                Case StorageType.Stack
                    For Each SubItem In DirectCast(Item.Data, ArrayList)
                        If SubItem.LevelAcquired <= Level And SubItem.LevelLost >= Level Then Return True
                    Next
                    Return False
                Case StorageType.Subkey
                    Dim Data As ICollection = DirectCast(Item.Data, StringKeyHashtable).Values

                    For Each SubItem In Data
                        If SubItem.LevelAcquired <= Level And SubItem.LevelLost >= Level Then Return True
                    Next
                    Return False
                Case Else
                    Return False
            End Select
        Else
            Return False
        End If
    End Function

    'contains key/subkey
    Public Function ContainsSubkey(ByVal Key As Objects.ObjectKey, ByVal Subkey As Objects.ObjectKey, Optional ByVal Level As Integer = 1000) As Boolean
        Return ContainsSubkey(Key, Subkey.ToString, Level)
    End Function

    'contains key/subkey
    Public Function ContainsSubkey(ByVal Key As Objects.ObjectKey, ByVal Subkey As String, Optional ByVal Level As Integer = 1000) As Boolean
        Dim Item As LibraryItem
        Dim Subitem As LibraryData

        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            If Item.StorageType = StorageType.Subkey Then
                If DirectCast(Item.Data, StringKeyHashtable).Contains(Subkey) Then
                    Subitem = DirectCast(DirectCast(Item.Data, StringKeyHashtable).Item(Subkey), LibraryData)
                    If Subitem.LevelAcquired <= Level And Subitem.LevelLost >= Level Then Return True Else Return False
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

    'storage type of key
    Public Function StorageTypeOfKey(ByVal Key As Objects.ObjectKey) As StorageType
        If Index.Contains(Key) Then
            Return DirectCast(Index.Item(Key), LibraryItem).StorageType
        Else
            Return StorageType.NotSet
        End If
    End Function

    'count of stackable items
    Public Function ItemCount(ByVal Key As Objects.ObjectKey) As Integer
        Dim Item As LibraryItem

        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            Select Case Item.StorageType
                Case StorageType.Stack
                    Return DirectCast(Item.Data, ArrayList).Count
                Case StorageType.Subkey
                    Return DirectCast(Item.Data, StringKeyHashtable).Count
            End Select
        Else
            Return -1
        End If
    End Function

    'item data - returns all data
    Public Function ItemData() As ArrayList
        Dim Items As ICollection = Index.Values

        ItemData = New ArrayList
        For Each Item As LibraryItem In Items
            Select Case Item.StorageType
                Case StorageType.Stack
                    For Each SubItem As Object In DirectCast(Item.Data, ArrayList)
                        ItemData.Add(SubItem)
                    Next
                Case StorageType.Subkey
                    ItemData.AddRange(DirectCast(Item.Data, StringKeyHashtable).Values)
            End Select
        Next
    End Function

    'Same as item data, but no level requirement - used in Components.Scanlibrary
    Public Function ItemStack(ByVal Key As Objects.ObjectKey) As ArrayList
        If Index.Contains(Key) Then
            ItemStack = DirectCast(DirectCast(Index.Item(Key), LibraryItem).Data, ArrayList)
        Else
            Return New ArrayList
        End If
    End Function

    'item data - returns an arraylist of all the subitems at the key location
    Public Function ItemData(ByVal Key As Objects.ObjectKey, Optional ByVal Level As Integer = 1000) As ArrayList
        Dim Item As LibraryItem
        Dim ReturnList As ArrayList
        Dim Subitem As LibraryData

        If Index.Contains(Key) Then

            ReturnList = New ArrayList

            Item = DirectCast(Index.Item(Key), LibraryItem)

            Select Case Item.StorageType
                Case StorageType.Stack
                    For Each Subitem In DirectCast(Item.Data, ArrayList)
                        If Subitem.LevelAcquired <= Level And Subitem.LevelLost >= Level Then ReturnList.Add(Subitem)
                    Next
                    Return ReturnList
                Case StorageType.Subkey
                    Dim Data As ICollection = DirectCast(Item.Data, StringKeyHashtable).Values
                    For Each Subitem In Data
                        If Subitem.LevelAcquired <= Level And Subitem.LevelLost >= Level Then ReturnList.Add(Subitem)
                    Next
                    Return ReturnList
            End Select
            Return Nothing
        Else
            Return New ArrayList
        End If
    End Function

    'item data - returns the subitem data at a particular key/subkey location
    Public Function ItemData(ByVal Key As Objects.ObjectKey, ByVal Subkey As Objects.ObjectKey, Optional ByVal Level As Integer = 1000) As LibraryData
        Return ItemData(Key, Subkey.ToString, Level)
    End Function

    'item data - returns the subitem data at a particular key/subkey location
    Public Function ItemData(ByVal Key As Objects.ObjectKey, ByVal Subkey As String, Optional ByVal Level As Integer = 1000) As LibraryData
        Dim Item As LibraryItem

        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            If Item.StorageType = StorageType.Subkey Then
                If DirectCast(Item.Data, StringKeyHashtable).ContainsKey(Subkey) Then
                    Dim Subitem As LibraryData = DirectCast(DirectCast(Item.Data, StringKeyHashtable).Item(Subkey), LibraryData)
                    If Subitem.LevelAcquired <= Level And Subitem.LevelLost >= Level Then Return Subitem Else Return Nothing
                Else
                    Return Nothing
                End If
            Else
                Throw New DevelopmentException("Cannot retrieve item data by subkey as storage type is not subkey.")
            End If
        Else
            Return Nothing
        End If
    End Function

    'all keys
    Public Function Keys() As ArrayList
        Keys = New ArrayList
        For Each Item As Object In Index.Keys
            Keys.Add(DirectCast(Item, Objects.ObjectKey))
        Next
    End Function

    'item subkeys
    Public Function Subkeys(ByVal Key As Objects.ObjectKey) As ArrayList
        Dim Item As LibraryItem

        If Index.Contains(Key) Then
            Item = DirectCast(Index.Item(Key), LibraryItem)
            If Item.StorageType = StorageType.Subkey Then
                Dim Keys As ICollection = DirectCast(Item.Data, StringKeyHashtable).Keys
                Subkeys = New ArrayList

                For Each KeyGuid As Objects.ObjectKey In Keys
                    Subkeys.Add(KeyGuid)
                Next
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    'clone
    Public Function Clone() As Library
        Dim Item, CloneItem As LibraryItem

        Clone = New Library
        Clone.Index = DirectCast(Me.Index.Clone, ObjectHashtable)
        For Each Key As Objects.ObjectKey In Index.Keys
            Item = DirectCast(Index.Item(Key), LibraryItem)
            Select Case Item.StorageType
                Case StorageType.Stack
                    CloneItem.StorageType = StorageType.Stack
                    CloneItem.Data = DirectCast(Item.Data, ArrayList).Clone
                    Clone.Index.Item(Key) = CloneItem
                Case StorageType.Subkey
                    CloneItem.StorageType = StorageType.Subkey
                    CloneItem.Data = DirectCast(Item.Data, StringKeyHashtable).Clone
                    Clone.Index.Item(Key) = CloneItem
            End Select
        Next
    End Function

    'clone library full of component data
    Public Function CloneComponentData() As Library
        Dim Item, CloneItem As LibraryItem

        CloneComponentData = New Library

        For Each Key As Objects.ObjectKey In Index.Keys
            Item = DirectCast(Index.Item(Key), LibraryItem)
            Select Case Item.StorageType
                Case StorageType.Stack
                    CloneItem.Key = Key
                    CloneItem.StorageType = StorageType.Stack
                    Dim Temp As New ArrayList

                    For Each LibraryData As LibraryData In DirectCast(Item.Data, ArrayList)
                        Dim ComponentData As Rules.Components.ComponentData = DirectCast(LibraryData.Data, Rules.Components.ComponentData)
                        Dim NewLibData As LibraryData

                        NewLibData.Data = ComponentData.Clone
                        NewLibData.LevelAcquired = LibraryData.LevelAcquired
                        NewLibData.LevelLost = LibraryData.LevelLost
                        Temp.Add(NewLibData)
                    Next

                    CloneItem.Data = Temp
                    CloneComponentData.Index.Item(Key) = CloneItem
                Case StorageType.Subkey
                    CloneItem.Key = Key
                    CloneItem.StorageType = StorageType.Subkey

                    Dim Temp As New ObjectHashtable

                    For Each LibraryData As LibraryData In DirectCast(Item.Data, StringKeyHashtable).Values
                        Dim ComponentData As Rules.Components.ComponentData = DirectCast(LibraryData.Data, Rules.Components.ComponentData)
                        Dim NewLibData As LibraryData

                        NewLibData.Data = ComponentData.Clone
                        NewLibData.LevelAcquired = LibraryData.LevelAcquired
                        NewLibData.LevelLost = LibraryData.LevelLost

                        Temp.Add(ComponentData.Key, NewLibData)
                    Next

                    CloneItem.Data = Temp
                    CloneComponentData.Index.Item(Key) = CloneItem
            End Select
        Next
    End Function

    'equals
    Public Shadows Function Equals(ByVal CompareTo As Library) As Boolean
        'compare keys
        For Each Key As Objects.ObjectKey In Index.Keys
            If Not CompareTo.ContainsKey(Key) Then
                Return False
            Else
                Dim ItemA As LibraryItem = DirectCast(Index.Item(Key), LibraryItem)
                Dim ItemB As LibraryItem = DirectCast(CompareTo.Index.Item(Key), LibraryItem)

                Select Case ItemA.StorageType
                    Case StorageType.Stack
                        'compare stacks
                        If DirectCast(ItemA.Data, ArrayList).Count <> DirectCast(ItemB.Data, ArrayList).Count Then Return False
                    Case StorageType.Subkey
                        'compare Hashtables
                        For Each SubKey As String In DirectCast(ItemA.Data, StringKeyHashtable).Keys
                            If Not DirectCast(ItemB.Data, StringKeyHashtable).Contains(SubKey) Then Return False
                        Next
                End Select
            End If
        Next

        Return True
    End Function

End Class
