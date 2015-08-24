Option Explicit On 
Option Strict On

'common operations that result in a collection of objects.
Public Class ObjectQueries

    'natural weapons
    Public Shared Function NaturalWeapons() As Objects.ObjectDataCollection
        Try
            'natural weapons
            Dim ItemList As Objects.ObjectDataCollection
            ItemList = Objects.GetObjectsByXPath(XML.DBTypes.NaturalWeapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.NaturalWeaponDefinitionType & "']")

            Return ItemList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'magic weapons and shields that can be used as primary hand weapon
    Public Shared Function MagicPrimaryWeapons() As Objects.ObjectDataCollection
        Try
            'magic weapons
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.MagicWeapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificWeaponDefinitionType & "']")
            ItemList.AddMany(MagicShieldPrimaryWeapons)

            Return ItemList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'psionic weapons and shields that can be used as primary hand weapon
    Public Shared Function PsionicPrimaryWeapons() As Objects.ObjectDataCollection
        Try
            'magic weapons
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.MagicWeapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicWeaponDefinitionType & "']")
            ItemList.AddMany(PsionicShieldPrimaryWeapons)

            Return ItemList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'magic shields that can be used as primary hand weapon
    Public Shared Function MagicShieldPrimaryWeapons() As Objects.ObjectDataCollection
        Try
            Dim TempList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.MagicArmor, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificArmorDefinitionType & "' and ArmorType='" & Objects.ShieldDefinitionType & "']")
            Dim ItemList As New Objects.ObjectDataCollection

            For Each MagicArmor As Objects.ObjectData In TempList
                Dim BaseItem As Objects.ObjectData = MagicArmor.GetFKObject("Armor")
                If BaseItem.Element("DamageType") <> "" Then ItemList.Add(MagicArmor)
            Next

            Return ItemList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'psionic shields that can be used as primary hand weapon
    Public Shared Function PsionicShieldPrimaryWeapons() As Objects.ObjectDataCollection
        Try
            Dim TempList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.MagicArmor, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorDefinitionType & "' and ArmorType='" & Objects.ShieldDefinitionType & "']")
            Dim ItemList As New Objects.ObjectDataCollection

            For Each MagicArmor As Objects.ObjectData In TempList
                Dim BaseItem As Objects.ObjectData = MagicArmor.GetFKObject("Armor")
                If BaseItem.Element("DamageType") <> "" Then ItemList.Add(MagicArmor)
            Next

            Return ItemList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'inventory items that can be used as primary hand weapon
    Public Shared Function InventoryPrimaryWeapons(ByVal InventoryFolderKey As Objects.ObjectKey, ByVal Hand As Rules.Weapons.Hand) As Objects.ObjectDataCollection
        Try
            Dim TempList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(InventoryFolderKey.Database, "/RPGXplorerDatabase/RPGXplorerObject[(ItemType='" & Objects.WeaponDefinitionType & "' or ItemType='" & Objects.SpecificWeaponDefinitionType & "' or ItemType='" & Objects.PsionicWeaponDefinitionType & "' or ItemType='" & Objects.ShieldDefinitionType & "' or ItemType='" & Objects.SpecificArmorDefinitionType & "' or ItemType='" & Objects.PsionicArmorDefinitionType & "') and ParentGUID='" & InventoryFolderKey.ToString & "']")

            Dim FilteredList As New Objects.ObjectDataCollection

            For Each Item As Objects.ObjectData In TempList

                Select Case Item.Element("ItemType")
                    Case Objects.ShieldDefinitionType
                        Dim BaseItem As Objects.ObjectData = Item.GetFKObject("Item")

                        If Hand = Rules.Weapons.Hand.Primary Then
                            If BaseItem.Element("DamageType") <> "" Then FilteredList.Add(Item)
                        Else
                            FilteredList.Add(Item)
                        End If

                    Case Objects.SpecificArmorDefinitionType
                        Dim MagicArmor As Objects.ObjectData = Item.GetFKObject("Item")
                        Dim BaseItem As Objects.ObjectData = MagicArmor.GetFKObject("Armor")

                        If Hand = Rules.Weapons.Hand.Primary Then
                            If BaseItem.Element("DamageType") <> "" Then FilteredList.Add(Item)
                        Else
                            FilteredList.Add(Item)
                        End If

                    Case Else
                        FilteredList.Add(Item)

                End Select
            Next

            Return FilteredList
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'inventory items that are bucklers
    Public Shared Function InventoryBucklers(ByVal InventoryFolderKey As Objects.ObjectKey) As Objects.ObjectDataCollection
        Try
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(InventoryFolderKey.Database, "/RPGXplorerDatabase/RPGXplorerObject[ItemType='" & Objects.ShieldDefinitionType & "' or ItemType='" & Objects.SpecificArmorDefinitionType & "' or ItemType='" & Objects.PsionicArmorDefinitionType & "' and ParentGUID='" & InventoryFolderKey.ToString & "']")

            Dim FilteredList As New Objects.ObjectDataCollection

            'construct buckler list
            For Each Item As Objects.ObjectData In ItemList
                Select Case Item.Element("ItemType")
                    Case Objects.ShieldDefinitionType
                        Dim BaseItem As Objects.ObjectData = Item.GetFKObject("Item")
                        If BaseItem.Element("WieldWeapon") = "Yes" Then FilteredList.Add(Item)
                    Case Objects.SpecificArmorDefinitionType
                        Dim MagicArmor As Objects.ObjectData = Item.GetFKObject("Item")
                        Dim BaseItem As Objects.ObjectData = MagicArmor.GetFKObject("Armor")
                        If BaseItem.Element("WieldWeapon") = "Yes" Then FilteredList.Add(Item)
                End Select
            Next

            Return FilteredList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'all weapons (not inc. shields)
    Public Shared Function Weapons() As Objects.ObjectDataCollection
        Try
            Return Objects.GetObjectsByXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and BaseItem='']")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'all weapons (not inc. shields or masterwork)
    Public Shared Function WeaponsNoMasterwork() As Objects.ObjectDataCollection
        Try
            Return Objects.GetObjectsByXPath(XML.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and BaseItem='' and Masterwork='']")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'shields that can be used as primary weapons
    Public Shared Function ShieldPrimaryWeapons() As Objects.ObjectDataCollection
        Try
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.ArmorAndShields, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ShieldDefinitionType & "' and BaseItem='']")

            Dim FilteredList As New Objects.ObjectDataCollection

            For Each Item As Objects.ObjectData In ItemList
                If Item.Element("DamageType") <> "" Then FilteredList.Add(Item)
            Next

            Return FilteredList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'shields that can be used as primary weapons (no masterwork)
    Public Shared Function ShieldPrimaryWeaponsNoMasterwork() As Objects.ObjectDataCollection
        Try
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.ArmorAndShields, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ShieldDefinitionType & "' and BaseItem='' and Masterwork='']")

            Dim FilteredList As New Objects.ObjectDataCollection

            For Each Item As Objects.ObjectData In ItemList
                If Item.Element("DamageType") <> "" Then FilteredList.Add(Item)
            Next

            Return FilteredList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'non-magical bucklers
    Public Shared Function Bucklers() As Objects.ObjectDataCollection
        Try
            Return Objects.GetObjectsByXPath(XML.DBTypes.ArmorAndShields, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ShieldDefinitionType & "' and WieldWeapon='Yes' and BaseItem='']")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'non-magical bucklers (no masterwork)
    Public Shared Function BucklersNoMasterwork() As Objects.ObjectDataCollection
        Try
            Return Objects.GetObjectsByXPath(XML.DBTypes.ArmorAndShields, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.ShieldDefinitionType & "' and WieldWeapon='Yes' and BaseItem='' and Masterwork='']")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'all magic bucklers
    Public Shared Function MagicBucklers() As Objects.ObjectDataCollection
        Try
            'get magic shields
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.MagicArmor, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpecificArmorDefinitionType & "' and ArmorType='" & Objects.ShieldDefinitionType & "']")

            Dim FilteredList As New Objects.ObjectDataCollection

            'filter to bucklers only
            For Each MagicArmor As Objects.ObjectData In ItemList
                Dim BaseItem As Objects.ObjectData = MagicArmor.GetFKObject("Armor")
                If BaseItem.Element("WieldWeapon") = "Yes" Then FilteredList.Add(MagicArmor)
            Next

            Return FilteredList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'all psionic bucklers
    Public Shared Function PsionicBucklers() As Objects.ObjectDataCollection
        Try
            'get psionic shields
            Dim ItemList As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.MagicArmor, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.PsionicArmorDefinitionType & "' and ArmorType='" & Objects.ShieldDefinitionType & "']")

            Dim FilteredList As New Objects.ObjectDataCollection

            'filter to bucklers only
            For Each MagicArmor As Objects.ObjectData In ItemList
                Dim BaseItem As Objects.ObjectData = MagicArmor.GetFKObject("Armor")
                If BaseItem.Element("WieldWeapon") = "Yes" Then FilteredList.Add(MagicArmor)
            Next

            Return FilteredList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

End Class