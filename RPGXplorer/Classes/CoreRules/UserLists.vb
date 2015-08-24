Option Explicit On 
Option Strict On

Public Class UserLists

    'handles the loading, saving and updating of user list entries

    Public Shared ExistingObjs As Objects.ObjectDataCollection
    Public Shared FeatTypes As New ArrayList
    Public Shared FeatureTypes As New ArrayList
    Public Shared ItemCategories As New ArrayList
    Public Shared Licenses As New ArrayList
    Public Shared MonsterTypes As New ArrayList
    Public Shared Sourcebooks As New ArrayList
    Public Shared UserTags As New ArrayList
    Public Shared NaturalAttackTypes As New ArrayList

    'loading existing values
    Public Shared Sub Load()
        Try
            FeatTypes.Clear()
            FeatureTypes.Clear()
            ItemCategories.Clear()
            Licenses.Clear()
            MonsterTypes.Clear()
            Sourcebooks.Clear()
            UserTags.Clear()
            NaturalAttackTypes.Clear()

            'load lists
            ExistingObjs = Objects.GetAllObjectsOfType(XML.DBTypes.UserDocs, Objects.UserListItemType)

            For Each Obj As Objects.ObjectData In ExistingObjs
                Select Case Obj.Element("ListName")
                    Case "Feat Types"
                        FeatTypes.Add(Obj.Name)
                    Case "Feature Types"
                        FeatureTypes.Add(Obj.Name)
                    Case "Item Categories"
                        ItemCategories.Add(Obj.Name)
                    Case "Licenses"
                        Licenses.Add(Obj.Name)
                    Case "Monster Types"
                        MonsterTypes.Add(Obj.Name)
                    Case "Sourcebooks"
                        Sourcebooks.Add(Obj.Name)
                    Case "User Tags"
                        UserTags.Add(Obj.Name)
                    Case "Natural Attack Types"
                        NaturalAttackTypes.Add(Obj.Name)
                End Select
            Next

            'add in base values
            FeatTypes.AddRange(Rules.Lists.FeatTypesBase)
            FeatureTypes.AddRange(Rules.Lists.FeatureTypesBase)
            ItemCategories.AddRange(Rules.Lists.ItemTypesBase)
            MonsterTypes.AddRange(Rules.Lists.MonsterTypesBase)
            NaturalAttackTypes.AddRange(Rules.Lists.NaturalAttackTypesBase)

        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'update the lists with the current user values, optionally save these values also
    Public Shared Sub UpdateLists(Optional ByVal SaveToDB As Boolean = True)
        Try
            'remove existing
            If SaveToDB Then
                For Each Obj As Objects.ObjectData In ExistingObjs
                    Obj.DeleteFast()
                Next
            End If

            Dim ListItem As New Objects.ObjectData

            'feat types
            If SaveToDB Then
                For Each Value As String In FeatTypes
                    If General.ArrayStringFind(Rules.Lists.FeatTypesBase, Value) = -1 Then
                        ListItem.Name = Value
                        ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                        ListItem.ParentGUID = Objects.ObjectKey.Empty
                        ListItem.Type = Objects.UserListItemType
                        ListItem.Element("ListName") = "Feat Types"
                        ListItem.Save()
                        ListItem.Clear()
                    End If
                Next
            End If

            'redim feat types array and add values
            Dim Count As Integer = FeatTypes.Count
            ReDim Rules.Lists.FeatTypes(Count - 1)

            FeatTypes.Sort()

            For n As Integer = 0 To Count - 1
                Rules.Lists.FeatTypes(n) = FeatTypes(n).ToString
            Next

            'Feature types
            If SaveToDB Then
                For Each Value As String In FeatureTypes
                    If General.ArrayStringFind(Rules.Lists.FeatureTypesBase, Value) = -1 Then
                        ListItem.Name = Value
                        ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                        ListItem.ParentGUID = Objects.ObjectKey.Empty
                        ListItem.Type = Objects.UserListItemType
                        ListItem.Element("ListName") = "Feature Types"
                        ListItem.Save()
                        ListItem.Clear()
                    End If
                Next
            End If

            'redim Featureure types array and add values
            Count = FeatureTypes.Count
            ReDim Rules.Lists.FeatureTypes(Count - 1)

            FeatureTypes.Sort()

            For n As Integer = 0 To Count - 1
                Rules.Lists.FeatureTypes(n) = FeatureTypes(n).ToString
            Next

            'item categories
            If SaveToDB Then
                For Each Value As String In ItemCategories
                    If General.ArrayStringFind(Rules.Lists.ItemTypesBase, Value) = -1 Then
                        ListItem.Name = Value
                        ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                        ListItem.ParentGUID = Objects.ObjectKey.Empty
                        ListItem.Type = Objects.UserListItemType
                        ListItem.Element("ListName") = "Item Categories"
                        ListItem.Save()
                        ListItem.Clear()
                    End If
                Next
            End If

            'redim item type array and add values
            Count = ItemCategories.Count
            ReDim Rules.Lists.ItemTypes(Count - 1)

            ItemCategories.Sort()

            For n As Integer = 0 To Count - 1
                Rules.Lists.ItemTypes(n) = ItemCategories(n).ToString
            Next

            'licenses
            If SaveToDB Then
                For Each Value As String In Licenses
                    ListItem.Name = Value
                    ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                    ListItem.ParentGUID = Objects.ObjectKey.Empty
                    ListItem.Type = Objects.UserListItemType
                    ListItem.Element("ListName") = "Licenses"
                    ListItem.Save()
                    ListItem.Clear()
                Next
            End If

            'redim array
            Count = Licenses.Count
            If Count > 0 Then
                ReDim Rules.Lists.Licenses(Count - 1)
                Licenses.Sort()

                For n As Integer = 0 To Count - 1
                    Rules.Lists.Licenses(n) = Licenses(n).ToString
                Next
            Else
                Rules.Lists.Licenses = Nothing
            End If

            'monster types
            If SaveToDB Then
                For Each Value As String In MonsterTypes
                    If General.ArrayStringFind(Rules.Lists.MonsterTypesBase, Value) = -1 Then
                        ListItem.Name = Value
                        ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                        ListItem.ParentGUID = Objects.ObjectKey.Empty
                        ListItem.Type = Objects.UserListItemType
                        ListItem.Element("ListName") = "Monster Types"
                        ListItem.Save()
                        ListItem.Clear()
                    End If
                Next
            End If

            'redim feat types array and add values
            Count = MonsterTypes.Count
            ReDim Rules.Lists.MonsterDefinitionTypes(Count - 1)

            MonsterTypes.Sort()

            For n As Integer = 0 To Count - 1
                Rules.Lists.MonsterDefinitionTypes(n) = MonsterTypes(n).ToString
            Next

            'natural attack  types
            If SaveToDB Then
                For Each Value As String In NaturalAttackTypes
                    If General.ArrayStringFind(Rules.Lists.NaturalAttackTypesBase, Value) = -1 Then
                        ListItem.Name = Value
                        ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                        ListItem.ParentGUID = Objects.ObjectKey.Empty
                        ListItem.Type = Objects.UserListItemType
                        ListItem.Element("ListName") = "Natural Attack Types"
                        ListItem.Save()
                        ListItem.Clear()
                    End If
                Next
            End If

            'redim feat types array and add values
            Count = NaturalAttackTypes.Count
            ReDim Rules.Lists.NaturalAttackTypes(Count - 1)

            NaturalAttackTypes.Sort()

            For n As Integer = 0 To Count - 1
                Rules.Lists.NaturalAttackTypes(n) = NaturalAttackTypes(n).ToString
            Next

            'sourcebooks
            If SaveToDB Then
                For Each Value As String In Sourcebooks
                    ListItem.Name = Value
                    ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                    ListItem.ParentGUID = Objects.ObjectKey.Empty
                    ListItem.Type = Objects.UserListItemType
                    ListItem.Element("ListName") = "Sourcebooks"
                    ListItem.Save()
                    ListItem.Clear()
                Next
            End If

            'redim array
            Count = Sourcebooks.Count
            If Count > 0 Then
                ReDim Rules.Lists.Sourcebooks(Count - 1)
                Sourcebooks.Sort()

                For n As Integer = 0 To Count - 1
                    Rules.Lists.Sourcebooks(n) = Sourcebooks(n).ToString
                Next
            Else
                Rules.Lists.Sourcebooks = Nothing
            End If

            'user tags
            If SaveToDB Then
                For Each Value As String In UserTags
                    ListItem.Name = Value
                    ListItem.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
                    ListItem.ParentGUID = Objects.ObjectKey.Empty
                    ListItem.Type = Objects.UserListItemType
                    ListItem.Element("ListName") = "User Tags"
                    ListItem.Save()
                    ListItem.Clear()
                Next
            End If

            'redim array
            Count = UserTags.Count
            If Count > 0 Then
                ReDim Rules.Lists.UserTags(Count - 1)
                UserTags.Sort()

                For n As Integer = 0 To Count - 1
                    Rules.Lists.UserTags(n) = UserTags(n).ToString
                Next
            Else
                Rules.Lists.UserTags = Nothing
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
