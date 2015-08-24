Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Objects

Public Class CharacterManager

#Region "Members"

    Private Shared _CurrentCharacterKey As Objects.ObjectKey
    Private Shared _CharacterCache As New ObjectHashtable
    Private Shared _CharacterCacheForWeaponsPanel As New ObjectHashtable
    Private Shared IsDirtyTable As New ObjectHashtable
    Private Shared IsDirtyTableForWeaponsPanel As New ObjectHashtable

#End Region

#Region "Enumerations"

    Enum DirtyStatus
        Recalculate
        Reload
    End Enum

#End Region

#Region "Properties"

    Public Shared Property CurrentCharacterKey() As Objects.ObjectKey
        Get
            Return _CurrentCharacterKey
        End Get
        Set(ByVal value As Objects.ObjectKey)
            _CurrentCharacterKey = value
            If General.Marketplace IsNot Nothing Then General.Marketplace.ShoppingCart.SwitchCharacter(_CurrentCharacterKey)
        End Set
    End Property

    Public Shared ReadOnly Property CurrentCharacter() As Rules.Character
        Get
            If _CurrentCharacterKey.IsEmpty Then Return Nothing Else Return GetCharacter(_CurrentCharacterKey)
        End Get
    End Property

    Public Shared ReadOnly Property GetCharacter(ByVal CharKey As Objects.ObjectKey) As Rules.Character
        Get
            Dim ReturnCharacter As Rules.Character

            If _CharacterCache.ContainsKey(CharKey) Then
                ReturnCharacter = DirectCast(_CharacterCache(CharKey), Rules.Character)

                'if the character is dirty reload
                If IsDirtyTable.Contains(CharKey) Then
                    Dim Status As DirtyStatus
                    Status = DirectCast(IsDirtyTable(CharKey), DirtyStatus)

                    Select Case Status

                        Case DirtyStatus.Recalculate
                            ReturnCharacter.CalculateInventory()

                        Case DirtyStatus.Reload

                            'Update Current Character
                            ReturnCharacter = New Rules.Character
                            ReturnCharacter.Load(CharKey)
                            ReturnCharacter.CalculateInventory()

                            'Update Cache
                            _CharacterCache(CharKey) = ReturnCharacter

                    End Select

                    IsDirtyTable.Remove(CharKey)
                End If
            Else
                'load and calculate a character
                ReturnCharacter = New Rules.Character
                ReturnCharacter.Load(CharKey)
                ReturnCharacter.CalculateInventory()

                'Save it in the cache
                _CharacterCache.Item(CharKey) = ReturnCharacter
            End If

            Return ReturnCharacter

        End Get
    End Property

    Public Shared ReadOnly Property GetCharacterForWeaponPanel(ByVal CharKey As Objects.ObjectKey) As Rules.Character
        Get
            Dim ReturnCharacter As Rules.Character

            If _CharacterCacheForWeaponsPanel.ContainsKey(CharKey) Then
                ReturnCharacter = DirectCast(_CharacterCacheForWeaponsPanel(CharKey), Rules.Character)

                'if the character is dirty reload
                If IsDirtyTableForWeaponsPanel.Contains(CharKey) Then
                    Dim Status As DirtyStatus
                    Status = DirectCast(IsDirtyTableForWeaponsPanel(CharKey), DirtyStatus)

                    Select Case Status

                        Case DirtyStatus.Recalculate
                            ReturnCharacter.CalculateForWeaponsPanel()

                        Case DirtyStatus.Reload

                            'Update Current Character
                            ReturnCharacter = New Rules.Character
                            ReturnCharacter.Load(CharKey)
                            ReturnCharacter.CalculateForWeaponsPanel()

                            'Update Cache
                            _CharacterCacheForWeaponsPanel(CharKey) = ReturnCharacter

                    End Select

                    IsDirtyTableForWeaponsPanel.Remove(CharKey)
                End If
            Else
                'load and calculate a character
                ReturnCharacter = New Rules.Character
                ReturnCharacter.Load(CharKey)
                ReturnCharacter.CalculateForWeaponsPanel()

                'Save it in the cache
                _CharacterCacheForWeaponsPanel.Item(CharKey) = ReturnCharacter
            End If

            Return ReturnCharacter
        End Get
    End Property

#End Region

    'if a cloned character has been updated
    Public Shared Sub UpdateCharacter(ByVal Character As Rules.Character)
        'If the character does not have its inventory components loaded - do so now
        If Not Character.ComponentsState = Rules.Character.ComponentsLoaded.CharacterAndInventory Then
            Character.CalculateInventory()
        End If

        'Update the cache
        _CharacterCache(Character.CharacterObject.ObjectGUID) = Character

        'set any windows for this character to be refreshed
        WindowManager.SetDirty(Character.CharacterObject.ObjectGUID)
    End Sub

    'remove a character from the cache because it has been deleted
    Public Shared Sub RemoveCharacter(ByVal CharacterKey As Objects.ObjectKey)
        If _CharacterCache.Contains(CharacterKey) Then _CharacterCache.Remove(CharacterKey)
        If IsDirtyTable.Contains(CharacterKey) Then IsDirtyTable.Remove(CharacterKey)
    End Sub

    'set dirty
    Public Shared Sub SetDirty(ByVal CharacterKey As Objects.ObjectKey, Optional ByVal Level As DirtyStatus = DirtyStatus.Recalculate, Optional ByVal RefreshFamiliarSkills As Boolean = False)
        Dim Status As DirtyStatus

        'Update if its in the table already, else add a new entry
        If IsDirtyTable.ContainsKey(CharacterKey) Then
            Status = DirectCast(IsDirtyTable.Item(CharacterKey), DirtyStatus)

            'Dont override a reload with a recalculate
            If Level > Status Then IsDirtyTable.Item(CharacterKey) = Level
        Else
            IsDirtyTable.Add(CharacterKey, Level)
        End If
        If IsDirtyTableForWeaponsPanel.ContainsKey(CharacterKey) Then
            Status = DirectCast(IsDirtyTableForWeaponsPanel.Item(CharacterKey), DirtyStatus)

            'Dont override a reload with a recalculate
            If Level > Status Then IsDirtyTableForWeaponsPanel.Item(CharacterKey) = Level
        Else
            IsDirtyTableForWeaponsPanel.Add(CharacterKey, Level)
        End If

        'set any familiars as dirty also
        Dim Familiars As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(CharacterKey.Database, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.CharacterType & "' and Master/@FK='" & CharacterKey.ToString & "']")

        If Familiars.Count > 0 Then
            For Each Familiar As Objects.ObjectData In Familiars
                If RefreshFamiliarSkills Then
                    GetCharacter(Familiar.ObjectGUID).UpdateFamiliarSkillRanks()
                End If
                SetDirty(Familiar.ObjectGUID)
                WindowManager.SetDirty(Familiar.ObjectGUID)
            Next
        End If

        WindowManager.SetDirty(CharacterKey)

    End Sub

    'set all dirty
    Public Shared Sub SetAllDirty(Optional ByVal Level As DirtyStatus = DirtyStatus.Recalculate)
        For Each Key As Objects.ObjectKey In _CharacterCache.Keys
            SetDirty(Key, Level)
        Next
    End Sub

End Class
