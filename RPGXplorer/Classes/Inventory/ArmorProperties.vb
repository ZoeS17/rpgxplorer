Option Explicit On
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class ArmorProperties

        'use this class to retrieve armor attributes, abilities etc.

#Region "Member Variables"

        Private _Item, _BaseItem, _Material As Objects.ObjectData
        Private _Enhancement As Integer
        Private _Masterwork, DisplayMasterwork, DisplayEnhancement As Boolean
        Private _CheckPenalty As Integer
        Private _MaxDex As Integer
        Private _SpellFailure As Integer
        Private _AC As Integer

#End Region

#Region "Properties"

        'name
        Public ReadOnly Property Name() As String
            Get
                Name = Rules.Formatting.FormatModifier(_AC) & " ("
                Name &= _Item.Name
                If DisplayEnhancement Then Name &= " " & Rules.Formatting.FormatModifier(_Enhancement)
                If DisplayMasterwork Then Name &= ", Masterwork"
                Name &= ")"
            End Get
        End Property

        'armor/shield
        Public ReadOnly Property Armor() As Objects.ObjectData
            Get
                Return _Item
            End Get
        End Property

        'base armor/shield
        Public ReadOnly Property BaseArmor() As Objects.ObjectData
            Get
                Return _BaseItem
            End Get
        End Property

        'armor weight category
        Public ReadOnly Property ArmorTraining(Optional ByVal BaseTraining As Boolean = False) As String
            Get
                If BaseTraining Then
                    Return _BaseItem.Element("Training")
                Else
                    If MaterialObject.IsEmpty Then
                        Return _BaseItem.Element("Training")
                    Else
                        If MaterialObject.Element("ReduceArmorTraining") = "Yes" Then
                            Select Case _BaseItem.Element("Training")
                                Case "Light"
                                    Return "Light"

                                Case "Medium"
                                    Return "Light"

                                Case "Heavy"
                                    Return "Medium"

                                Case Else
                                    Return _BaseItem.Element("Training")
                            End Select
                        End If
                    End If
                End If
                Return ""
            End Get
        End Property

        'check penalty
        Public ReadOnly Property CheckPenalty(Optional ByVal base As Boolean = False) As Integer
            Get
                If base Then
                    Return _CheckPenalty
                Else
                    If MaterialObject.IsEmpty Then
                        Return _CheckPenalty
                    Else
                        Return Math.Min(_CheckPenalty + MaterialObject.ElementAsInteger("ArmorCheckBonus"), 0)
                    End If
                End If
            End Get
        End Property

        'max dex
        Public ReadOnly Property MaxDex(Optional ByVal Base As Boolean = False) As Integer
            Get
                If Base Then
                    Return _MaxDex
                Else
                    If MaterialObject.IsEmpty Then
                        Return _MaxDex
                    Else
                        Return _MaxDex + MaterialObject.ElementAsInteger("MaxDexModifier")
                    End If
                End If
            End Get
        End Property

        'spell failure 
        Public ReadOnly Property SpellFailure(Optional ByVal base As Boolean = False) As Integer
            Get
                If base Then
                    Return _SpellFailure
                Else
                    If MaterialObject.IsEmpty Then
                        Return _SpellFailure
                    Else
                        Return Math.Max(_SpellFailure - MaterialObject.ElementAsInteger("SpellFailureBonus"), 0)
                    End If
                End If
            End Get
        End Property

        'ac
        Public ReadOnly Property AC() As Integer
            Get
                Return _AC
            End Get
        End Property

        'material
        Public ReadOnly Property MaterialObject() As Objects.ObjectData
            Get
                Return _Material
            End Get
        End Property

        Public ReadOnly Property Material() As Rules.SpecialMaterial
            Get
                Return CType(Rules.SpecialMaterial.Materials(_Material.ObjectGUID), Rules.SpecialMaterial)
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Armor As Objects.ObjectData, Optional ByVal Masterwork As Boolean = False, Optional ByVal Enhancement As Integer = 0)
            Try
                _Item = Armor
                _BaseItem = CommonLogic.GetBaseWeaponOrArmor(Armor)
                _AC = _BaseItem.ElementAsInteger("ArmorBonus")
                _Material = _Item.GetFKObject("Material")

                'masterwork
                DisplayMasterwork = False
                Select Case Armor.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                        If _BaseItem.Element("Masterwork") = "Yes" Then
                            _Masterwork = True
                        Else
                            _Masterwork = Masterwork
                            DisplayMasterwork = _Masterwork
                        End If
                    Case Objects.SpecificArmorDefinitionType
                        _Masterwork = True
                End Select

                'enhancement
                DisplayEnhancement = False
                Select Case Armor.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                        _Enhancement = Enhancement
                        If Enhancement > 0 Then DisplayEnhancement = True
                    Case Objects.SpecificArmorDefinitionType
                        _Enhancement = Armor.ElementAsInteger("EnhancementBonus")
                End Select

                'magic items are automatically masterwork
                If _Enhancement > 0 Then _Masterwork = True

                'check penalty
                If _Masterwork Then
                    _CheckPenalty = _BaseItem.ElementAsInteger("ArmorCheck")
                    If _CheckPenalty < 0 Then _CheckPenalty += 1
                Else
                    _CheckPenalty = _BaseItem.ElementAsInteger("ArmorCheck")
                End If

                'Dont display Masterwork if we are displaying the enhancement bonus
                If DisplayMasterwork = True And DisplayEnhancement = True Then
                    DisplayMasterwork = False
                End If

                _AC += _Enhancement

                'max dex
                If _BaseItem.Element("MaxDexBonus") = "-" Then
                    _MaxDex = 999
                Else
                    _MaxDex = _BaseItem.ElementAsInteger("MaxDexBonus")
                End If

                'spell failure
                _SpellFailure = CType(_BaseItem.Element("SpellFailure").Replace("%", ""), Integer)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'constructor
        Public Sub New(ByVal Armor As Objects.ObjectData, ByVal Material As Objects.ObjectData, Optional ByVal Masterwork As Boolean = False, Optional ByVal Enhancement As Integer = 0)
            Try
                _Item = Armor
                _BaseItem = CommonLogic.GetBaseWeaponOrArmor(Armor)
                _AC = _BaseItem.ElementAsInteger("ArmorBonus")
                _Material = Material

                'masterwork
                DisplayMasterwork = False
                Select Case Armor.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                        If _BaseItem.Element("Masterwork") = "Yes" Then
                            _Masterwork = True
                        Else
                            _Masterwork = Masterwork
                            DisplayMasterwork = _Masterwork
                        End If
                    Case Objects.SpecificArmorDefinitionType
                        _Masterwork = True
                End Select

                'enhancement
                DisplayEnhancement = False
                Select Case Armor.Type
                    Case Objects.ArmorDefinitionType, Objects.ShieldDefinitionType
                        _Enhancement = Enhancement
                        If Enhancement > 0 Then DisplayEnhancement = True
                    Case Objects.SpecificArmorDefinitionType
                        _Enhancement = Armor.ElementAsInteger("EnhancementBonus")
                End Select

                'magic items are automatically masterwork
                If _Enhancement > 0 Then _Masterwork = True

                'check penalty
                If _Masterwork Then
                    _CheckPenalty = _BaseItem.ElementAsInteger("ArmorCheck")
                    If _CheckPenalty < 0 Then _CheckPenalty += 1
                Else
                    _CheckPenalty = _BaseItem.ElementAsInteger("ArmorCheck")
                End If

                'Dont display Masterwork if we are displaying the enhancement bonus
                If DisplayMasterwork = True And DisplayEnhancement = True Then
                    DisplayMasterwork = False
                End If

                _AC += _Enhancement

                'max dex
                If _BaseItem.Element("MaxDexBonus") = "-" Then
                    _MaxDex = 999
                Else
                    _MaxDex = _BaseItem.ElementAsInteger("MaxDexBonus")
                End If

                'spell failure
                _SpellFailure = CType(_BaseItem.Element("SpellFailure").Replace("%", ""), Integer)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace
