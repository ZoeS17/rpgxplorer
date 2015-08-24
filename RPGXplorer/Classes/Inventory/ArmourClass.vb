Option Explicit On
Option Strict On

Imports RPGXplorer.Rules.Constants
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Namespace Rules

    Public Class ArmourClass

#Region "Member Variables"

        Private _Inventory As Inventory
        Public ACFlag, TouchACFlag, FlatfootedFlag, HelplessFlag As Modifiers.Modifier

#End Region

#Region "Properties"

        'ac
        Public ReadOnly Property AC() As Integer
            Get
                AC = 10

                'base ac modifiers
                AC += _Inventory.Character.Modifiers.ArmorClass
                AC += _Inventory.Character.Modifiers.ArmorClassMonk

                'size
                AC += Size.Size(_Inventory.Character.Size).Modifier

                'racial natural armor
                AC += _Inventory.Character.RaceNaturalArmor

                'dex mod
                Dim AbilityMod As Integer = _Inventory.DEXModAC
                If _Inventory.Character.Components.SystemAbilities(References.ConArmorClass) Then
                    Dim TempMod As Integer
                    If _Inventory.Character.NonCon Then
                        TempMod = -5
                    Else
                        TempMod = Math.Min(_Inventory.MaxDEX(), Rules.AbilityScores.AbilityScore(_Inventory.Character.CurrentLevel.CON).Modifier)
                    End If
                    If TempMod > AbilityMod Then AbilityMod = TempMod
                End If

                AC += AbilityMod

            End Get
        End Property

        'touch ac
        Public ReadOnly Property TouchAC() As Integer
            Get
                TouchAC = 10

                'modifiers
                TouchAC += _Inventory.Character.Modifiers.ArmorClassMonk
                TouchAC += _Inventory.Character.Modifiers.TouchACModifier

                'size
                TouchAC += Size.Size(_Inventory.Character.Size).Modifier

                'dex mod
                Dim AbilityMod As Integer = _Inventory.DEXModAC
                If _Inventory.Character.Components.SystemAbilities(References.ConArmorClass) Then
                    'Dim TempMod As Integer = Math.Min(_Inventory.MaxDEX(), Rules.AbilityScores.AbilityScore(_Inventory.Character.CurrentLevel.CON).Modifier)
                    'If TempMod > AbilityMod Then AbilityMod = TempMod
                    Dim TempMod As Integer
                    If _Inventory.Character.NonCon Then
                        TempMod = -5
                    Else
                        TempMod = Math.Min(_Inventory.MaxDEX(), Rules.AbilityScores.AbilityScore(_Inventory.Character.CurrentLevel.CON).Modifier)
                    End If
                    If TempMod > AbilityMod Then AbilityMod = TempMod
                End If
                TouchAC += AbilityMod

                'elude touch
                If _Inventory.Character.Components.SystemAbilities(References.EludeTouch) Then
                    Dim ChaMod As Integer = Rules.AbilityScores.AbilityScore(_Inventory.Character.CurrentLevel.CHA).Modifier
                    If ChaMod > 0 Then
                        Dim NormalAC As Integer = AC
                        If (TouchAC + ChaMod) > NormalAC Then
                            TouchAC = NormalAC
                        Else
                            TouchAC += ChaMod
                        End If
                    End If
                End If

            End Get
        End Property

        'flat-footed ac
        Public ReadOnly Property FlatFootedAC() As Integer
            Get
                FlatFootedAC = 10

                'base FlatFootedAC modifiers
                FlatFootedAC += _Inventory.Character.Modifiers.FlatFootedACModifier
                FlatFootedAC += _Inventory.Character.Modifiers.ArmorClassMonk

                'size
                FlatFootedAC += Size.Size(_Inventory.Character.Size).Modifier

                'racial natural armor
                FlatFootedAC += _Inventory.Character.RaceNaturalArmor

                'get dex modifier
                Dim DexMod As Integer = _Inventory.DEXModAC
                If _Inventory.Character.Components.SystemAbilities(References.ConArmorClass) Then
                    'Dim TempMod As Integer = Math.Min(_Inventory.MaxDEX(), Rules.AbilityScores.AbilityScore(_Inventory.Character.CurrentLevel.CON).Modifier)
                    'If TempMod > DexMod Then DexMod = TempMod
                    Dim TempMod As Integer
                    If _Inventory.Character.NonCon Then
                        TempMod = -5
                    Else
                        TempMod = Math.Min(_Inventory.MaxDEX(), Rules.AbilityScores.AbilityScore(_Inventory.Character.CurrentLevel.CON).Modifier)
                    End If
                    If TempMod > DexMod Then DexMod = TempMod
                End If

                'apply penalty
                If DexMod < 0 Then
                    FlatFootedAC += DexMod
                Else
                    'apply bonus if allowed - uncanny dodge only
                    If _Inventory.Character.Components.SystemAbilities(References.UncannyDodge) Then
                        FlatFootedAC += DexMod
                    End If
                End If

            End Get
        End Property

        'helpless
        Public ReadOnly Property HelplessAC() As Integer
            Get
                HelplessAC = 10

                'modifiers
                HelplessAC += _Inventory.Character.Modifiers.HelplessACModifier

                'size
                HelplessAC += Size.Size(_Inventory.Character.Size).Modifier

                'racial natural armor
                HelplessAC += _Inventory.Character.RaceNaturalArmor

                'dex mod - effective Dexterity of zero
                HelplessAC -= 5

            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Inventory As Inventory)
            _Inventory = Inventory
        End Sub

    End Class

End Namespace
