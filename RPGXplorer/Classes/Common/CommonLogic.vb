Option Explicit On
Option Strict On

Public Class CommonLogic

    'this class contains UI logic common to forms, ui classes etc.

    Public Shared Function AppropriateModifiers(ByVal Obj As Objects.ObjectData) As Objects.ObjectDataCollection
        Try
            AppropriateModifiers = New Objects.ObjectDataCollection

            For Each SysObj As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.SystemComponents, Objects.SystemElementType)
                Select Case Obj.Type
                    Case Objects.ArmorDefinitionType
                        If SysObj.Element("Armor") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.ShieldDefinitionType
                        If SysObj.Element("Shields") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.FeatDefinitionType
                        If SysObj.Element("Feats") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.FeatureDefinitionType, Objects.ClassLevelType, Objects.RaceType, Objects.MonsterClassLevelType, Objects.MonsterRaceDefinitionType, Objects.SubtypeDefinitionType
                        If SysObj.Element("Features") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.WeaponDefinitionType
                        If SysObj.Element("Weapons") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.ItemDefinitionType
                        If SysObj.Element("Items") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.ArmorMagicAbilityDefinitionType
                        Select Case Obj.Element("ArmorType")
                            Case "Armor"
                                If SysObj.Element("ArmorMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                            Case "Shield"
                                If SysObj.Element("ShieldMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                            Case "Armor & Shield"
                                If SysObj.Element("ArmorMagicAbility") = "Yes" And SysObj.Element("ShieldMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                        End Select
                    Case Objects.ArtifactDefinitionType
                        If SysObj.Element("Artifacts") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.MagicAmmoDefinitionType
                        If SysObj.Element("MagicAmmo") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.SkillSynergyType
                        If SysObj.Element("Synergies") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.SpecificArmorDefinitionType
                        Dim Armor As Objects.ObjectData = Obj.GetFKObject("Armor")
                        Select Case Armor.Type
                            Case Objects.ArmorDefinitionType
                                If SysObj.Element("MagicArmor") = "Yes" Then AppropriateModifiers.Add(SysObj)
                            Case Objects.ShieldDefinitionType
                                If SysObj.Element("MagicShields") = "Yes" Then AppropriateModifiers.Add(SysObj)
                        End Select
                    Case Objects.SpecificWeaponDefinitionType
                        If SysObj.Element("MagicWeapons") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.StaffDefinitionType
                        If SysObj.Element("Staffs") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.RingDefinitionType
                        If SysObj.Element("Rings") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.RodDefinitionType
                        If SysObj.Element("Rods") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.WeaponMagicAbilityDefinitionType
                        If SysObj.Element("WeaponMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.WondrousDefinitionType
                        If SysObj.Element("Wondrous") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.ModifierFolderType
                        AppropriateModifiers.Add(SysObj)

                        'psionics
                    Case Objects.PsionicAmmoDefinitionType
                        If SysObj.Element("MagicAmmo") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.PsionicArmorAbilityDefinitionType
                        Select Case Obj.Element("ArmorType")
                            Case "Armor"
                                If SysObj.Element("ArmorMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                            Case "Shield"
                                If SysObj.Element("ShieldMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                            Case "Armor & Shield"
                                If SysObj.Element("ArmorMagicAbility") = "Yes" And SysObj.Element("ShieldMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                        End Select
                    Case Objects.PsionicArmorDefinitionType
                        Dim Armor As Objects.ObjectData = Obj.GetFKObject("Armor")
                        Select Case Armor.Type
                            Case Objects.ArmorDefinitionType
                                If SysObj.Element("MagicArmor") = "Yes" Then AppropriateModifiers.Add(SysObj)
                            Case Objects.ShieldDefinitionType
                                If SysObj.Element("MagicShields") = "Yes" Then AppropriateModifiers.Add(SysObj)
                        End Select
                    Case Objects.PsionicArtifactDefinitionType
                        If SysObj.Element("Artifacts") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.PsionicPsicrownDefinitionType
                        If SysObj.Element("Staffs") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.PsionicWeaponAbilityDefinitionType
                        If SysObj.Element("WeaponMagicAbility") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.PsionicWeaponDefinitionType
                        If SysObj.Element("MagicWeapons") = "Yes" Then AppropriateModifiers.Add(SysObj)
                    Case Objects.UniversalItemDefinitionType
                        If SysObj.Element("Wondrous") = "Yes" Then AppropriateModifiers.Add(SysObj)
                End Select
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'determine if alignment conflicts with alignment axis
    Public Shared Function AlignmentConflict(ByVal Alignment As String, ByVal Axis As String) As Boolean
        Select Case Axis
            Case "Good"
                If Alignment.IndexOf("Evil") <> -1 Then Return True Else Return False
            Case "Lawful"
                If Alignment.IndexOf("Chaotic") <> -1 Then Return True Else Return False
            Case "Evil"
                If Alignment.IndexOf("Good") <> -1 Then Return True Else Return False
            Case "Chaotic"
                If Alignment.IndexOf("Lawful") <> -1 Then Return True Else Return False
        End Select
    End Function

    'pass any item inc. magic to retrieve the base item.
    Public Shared Function GetBaseWeaponOrArmor(ByVal Item As Objects.ObjectData) As Objects.ObjectData
        Try
            'get base item if magic weapon etc.
            Select Case Item.Type
                Case Objects.ItemType
                    Return GetBaseWeaponOrArmor(Item.GetFKObject("Item"))
                Case Objects.SpecificArmorDefinitionType, Objects.PsionicArmorDefinitionType
                    Return Item.GetFKObject("Armor")
                Case Objects.SpecificWeaponDefinitionType, Objects.PsionicWeaponDefinitionType
                    Return Item.GetFKObject("Weapon")
                Case Else
                    Return Item
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'remove os disallowed characters from filename
    Public Shared Function StripNameDisallowedChars(ByVal Text As String) As String
        'Text = Text.Replace("<", "")
        'Text = Text.Replace(">", "")
        Text = Text.Replace("""", "")
        Return Text
    End Function

    'remove os disallowed characters from filename
    Public Shared Function StripDisallowedChars(ByVal Text As String) As String
        Text = Text.Replace("/", "")
        Text = Text.Replace("\", "")
        Text = Text.Replace(":", "")
        Text = Text.Replace("""", "")
        Text = Text.Replace(">", "")
        Text = Text.Replace("<", "")
        Text = Text.Replace("&", "")
        Text = Text.Replace("*", "")
        Text = Text.Replace("?", "")
        Return Text
    End Function

    'get highest number in an arraylist of integers
    Public Shared Function HighestInteger(ByVal List As ArrayList) As Integer
        HighestInteger = 0
        If List.Count > 0 Then
            HighestInteger = Convert.ToInt32(List.Item(0))
            For Each No As Integer In List
                If No > HighestInteger Then HighestInteger = No
            Next
        End If
    End Function

    'produce comma delimited list of arraylist contents
    Public Shared Function CommaSeparatedList(ByVal List As ArrayList) As String
        Dim Temp As String = ""

        For Each Item As String In List
            If Temp <> "" Then Temp &= ", "
            Temp &= Item
        Next

        Return Temp
    End Function

    'produce comma delimited list of arraylist contents
    Public Shared Function CommaSeparatedListNoSpace(ByVal List As ArrayList) As String
        Dim Temp As String = ""

        For Each Item As String In List
            If Temp <> "" Then Temp &= ","
            Temp &= Item
        Next

        Return Temp
    End Function

    'produce delimited list of arraylist contents
    Public Shared Function DelimitedList(ByVal Delimiter As String, ByVal List As ArrayList) As String
        Dim Temp As String = ""

        For Each Item As String In List
            If Temp <> "" Then Temp &= Delimiter
            Temp &= Item
        Next

        Return Temp
    End Function

    'select a bane focus
    Public Shared Function SelectBaneFocus(ByVal Item As Objects.ObjectData) As Objects.ObjectKey
        Dim SelectBane As ObjectSelectorForm

        'check to see if item has a bane condition

        'get all the condition components for this weapon
        Dim Conditions As Objects.ObjectDataCollection = Item.ChildrenOfType(Objects.ConditionType)
        For Each Ability As Objects.ObjectData In Item.ChildrenOfType(Objects.SpecificWeaponAbilityType)
            Conditions.AddMany(Ability.GetFKObject(Ability.GetFirstFKElementName).ChildrenOfType(Objects.ConditionType))
        Next

        'check each condition and action any bane conditions
        For Each Condition As Objects.ObjectData In Conditions
            If Condition.Element("Condition") = Rules.Conditions.Bane Then
                SelectBane = New ObjectSelectorForm
                SelectBane.Init(Objects.MonsterTypeType, "Select Bane for " & Item.Name, "Bane", XML.DBTypes.MonsterTypes)
                If SelectBane.ShowDialog = DialogResult.OK Then
                    Return SelectBane.SelectedGuid
                Else
                    Return Objects.ObjectKey.Empty
                End If
            End If
        Next

        Return Objects.ObjectKey.Empty

    End Function

    'construct an Xpath component
    Public Shared Function ConstructXpathDisjunction(ByVal ObjectElement As String, ByVal List As ArrayList) As String

        If List Is Nothing OrElse List.Count = 0 Then Return ""

        Dim Path As New System.Text.StringBuilder()
        Path.Append(ObjectElement & "='" & List(0).ToString & "'")

        If List.Count > 1 Then
            For i As Integer = 1 To List.Count - 1
                Path.Append(" or " & ObjectElement & "='" & List(i).ToString & "'")
            Next
        End If

        Return Path.ToString

    End Function

#Region "Class Levels"

    'when a class level is modified, update all the class levels' cumulative modifier elements
    Public Shared Sub UpdateCumulativeModifiers(ByVal ClassLevelsFolder As Objects.ObjectData)
        Dim ClassLevel As Objects.ObjectData
        Dim List As SortedList = Nothing
        Dim Attacks() As Integer
        Dim Fort, Will, Reflex As Integer
        Dim Enumerator As IDictionaryEnumerator

        Try

            Select Case ClassLevelsFolder.Type
                Case Objects.ClassLevelsFolderType
                    List = Sorter.LoadSortedList(ClassLevelsFolder.ChildrenOfType(Objects.ClassLevelType), General.SortType.NumericSuffix)
                Case Objects.MonsterClassLevelsFolderType
                    List = Sorter.LoadSortedList(ClassLevelsFolder.ChildrenOfType(Objects.MonsterClassLevelType), General.SortType.NumericSuffix)
            End Select

            If List IsNot Nothing Then
                Enumerator = List.GetEnumerator
                ReDim Attacks(3)
                While Enumerator.MoveNext

                    ClassLevel = DirectCast(Enumerator.Value, Objects.ObjectData)
                    Attacks(0) = Attacks(0) + ClassLevel.ElementAsInteger("BaseAttackBonus")
                    If Attacks(0) - 5 > 0 Then Attacks(1) = Attacks(0) - 5 Else Attacks(1) = 0
                    If Attacks(0) - 10 > 0 Then Attacks(2) = Attacks(0) - 10 Else Attacks(2) = 0
                    If Attacks(0) - 15 > 0 Then Attacks(3) = Attacks(0) - 15 Else Attacks(3) = 0

                    Fort += ClassLevel.ElementAsInteger("FortitudeSaveBonus")
                    Reflex += ClassLevel.ElementAsInteger("ReflexSaveBonus")
                    Will += ClassLevel.ElementAsInteger("WillSaveBonus")

                    ClassLevel.Element("Attacks") = Rules.Formatting.FormatAttacksClassLevel(Attacks)
                    ClassLevel.Element("FortitudeModifier") = Rules.Formatting.FormatModifier(Fort)
                    ClassLevel.Element("ReflexModifier") = Rules.Formatting.FormatModifier(Reflex)
                    ClassLevel.Element("WillModifier") = Rules.Formatting.FormatModifier(Will)


                    ClassLevel.Save()
                End While
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class