Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Public Class XPathQueries

    'this class contains xpath queries as string constants, all xpath queries should be here.

#Region "Weapons"

    Public Const AllWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='']"
    Public Const SimpleWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Simple']"
    Public Const ExoticWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Exotic']"
    Public Const MartialWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Martial']"
    Public Const RangedWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Ranged']"
    Public Const MeleeWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Melee']"
    'TODO - just brings back ranged weapons, needs flag on weapon
    Public Const Crossbows As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Ranged']"

    Public Const NonExoticWeapons As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and ((Training='Martial' or Training='Simple') or (Training='Exotic' and (Shadows!='' or BaseItem!='')))]"

    Public Const MartialTwoHanded As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Exotic' and MartialOneHanded='Yes']"

#End Region

#Region "Feats"

    Public Const FeatsWithoutFocus As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatDefinitionType & "' and HasFocus='']"
    Public Const MetamagicFeats As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatDefinitionType & "' and FeatType='Metamagic']"

#End Region

#Region "Character"

    Public Const Characters As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.CharacterType & "']"
    Public Const CharacterLevels As String = "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.CharacterLevelType & "']"

#End Region

End Class