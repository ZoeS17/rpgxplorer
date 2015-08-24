Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Public Class CommonHandlers

    'this class contains common event handling or related code

    'before label edit for name changes - false if not allowed
    Public Shared Function BeforeLabelEdit(ByVal Key As Objects.ObjectKey) As Boolean
        Try
            Dim Obj As New Objects.ObjectData

            Obj.Load(Key)
            BeforeLabelEdit = True

            If Obj.Fixed Then BeforeLabelEdit = False
            If Not Obj.IsPrimaryType Then
                Select Case Obj.Type
                    Case Objects.ItemType, Objects.PrerequisiteType, Objects.ChooseFeatureType
                        'do nothing
                    Case Else
                        BeforeLabelEdit = False
                End Select
            Else
                Select Case Obj.Type
                    Case Objects.MonsterTypeType
                        BeforeLabelEdit = False
                End Select
            End If

        Catch ex As Exception
            Exceptions.HandleNonFatalException(ex)
        End Try
    End Function

    'after label edit for name changes (LIST VIEW)
    Public Shared Function AfterLabelEditListView(ByVal Key As Objects.ObjectKey, ByRef NewName As String, ByVal ListViewItem As ListViewItem, Optional ByVal EnforceUnique As Boolean = True) As Boolean
        Try
            If NewName = "" Then Return False

            Dim CleanName As String
            CleanName = CommonLogic.StripNameDisallowedChars(NewName)

            If CleanName <> NewName Then
                NewName = CleanName
            End If

            Dim Obj As New Objects.ObjectData

            Obj.Load(Key)

            If EnforceUnique Then
                If XML.ObjectExists2(Obj.ObjectGUID, NewName, Obj.Type, Obj.ObjectGUID.Database) Then
                    General.ShowInfoDialog("Name already being used.")
                    ListViewItem.Text = Obj.Name
                    Return False
                End If
            End If

            General.MainExplorer.Undo.UndoRecord()
            Obj.Name = NewName
            If Obj.HTMLGUID.IsEmpty And Obj.HTML <> "Index.htm" Then
                Dim PagePath As String = RulePageManager.Rename(Obj, NewName)
                If PagePath <> "" Then Obj.HTML = PagePath
            End If
            Obj.Save()

            'check for character type update market place
            If Obj.Type = Objects.CharacterType Then
                'resync XMLworkshop
                If Not (General.XMLWorkShop Is Nothing) Then
                    General.XMLWorkShop.ReInit()
                End If
            End If

            ListViewItem.Text = NewName

            'update caches - bit quick and dirty this, should be refined.
            Select Case Obj.Type
                Case Objects.CharacterType, Objects.MonsterType
                    CharacterManager.SetDirty(Obj.ObjectGUID)
                Case Objects.FeatDefinitionType
                    Caches.SetFeatsDirty()
                Case Objects.FeatureDefinitionType
                    Caches.SetFeaturesDirty()
                Case Objects.ClassType
                    Caches.SetClassesDirty()
                Case Objects.SpellDefinitionType
                    Caches.SetSpellsDirty()
                Case Objects.PowerDefinitionType
                    Caches.SetPowersDirty()
                Case Objects.SkillDefinitionType
                    Caches.SetSkillsDirty()
            End Select
            WindowManager.RefreshTabNames()

            Return True

        Catch ex As Exception
            Exceptions.HandleNonFatalException(ex)
        End Try
    End Function

    'after label edit for name changes (TREE VIEW)
    Public Shared Function AfterLabelEditTreeView(ByVal Key As Objects.ObjectKey, ByVal NewName As String, ByVal TreeNode As TreeNode, Optional ByVal EnforceUnique As Boolean = True) As Boolean
        Try
            If NewName = "" Then Return False

            NewName = CommonLogic.StripNameDisallowedChars(NewName)

            Dim Obj As New Objects.ObjectData

            Obj.Load(Key)

            If EnforceUnique Then
                If XML.ObjectExists2(Obj.ObjectGUID, NewName, Obj.Type, Obj.ObjectGUID.Database) Then
                    General.ShowInfoDialog("Name already being used.")
                    TreeNode.Text = Obj.Name
                    Return False
                End If
            End If

            General.MainExplorer.Undo.UndoRecord()
            Obj.Name = NewName
            If Obj.HTMLGUID.IsEmpty Then
                Dim PagePath As String = RulePageManager.Rename(Obj, NewName)
                If PagePath <> "" Then Obj.HTML = PagePath
            End If
            Obj.Save()

            'update caches - bit quick and dirty this, should be refined.
            Select Case Obj.Type
                Case Objects.CharacterType, Objects.MonsterType
                    CharacterManager.SetDirty(Obj.ObjectGUID)
                Case Objects.FeatDefinitionType
                    Caches.SetFeatsDirty()
                Case Objects.FeatureDefinitionType
                    Caches.SetFeaturesDirty()
                Case Objects.ClassType
                    Caches.SetClassesDirty()
                Case Objects.SpellDefinitionType
                    Caches.SetSpellsDirty()
                Case Objects.PowerDefinitionType
                    Caches.SetPowersDirty()
                Case Objects.SkillDefinitionType
                    Caches.SetSkillsDirty()
            End Select
            WindowManager.RefreshTabNames()

            Return True
        Catch ex As Exception
            Exceptions.HandleNonFatalException(ex)
        End Try
    End Function

End Class
