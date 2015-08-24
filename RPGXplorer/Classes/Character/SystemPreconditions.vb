Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class SystemPreconditions

        'this class is responsible for checking that a character has a particular system precondition

#Region "Member Variables"

        Private Character As Rules.Character

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            Me.Character = Character
        End Sub

        Public Function PreconditionMet(ByVal Precondition As Objects.ObjectData) As Boolean
            Select Case Precondition.GetFKGuid("SystemPreconditionDefinition").ToString
                Case References.Unarmored.ToString
                    Return Unarmored()
                Case References.Unencumbered.ToString
                    Return Unencumbered()
                Case References.WearingLightArmorOrLess.ToString
                    Return WearingLightArmorOrLess()
                Case References.WearingMediumArmorOrLess.ToString
                    Return WearingMediumArmorOrLess()
                Case References.NotCarryingAHeavyLoad.ToString
                    Return NotCarryingAHeavyLoad()
                Case References.NotWearingAShield.ToString
                    Return NotWearingAShield()
            End Select
        End Function

        'not carrying a heavy load
        Public Function NotCarryingAHeavyLoad() As Boolean
            If Character.Inventory.Load <> "Heavy" Then Return True Else Return False
        End Function

        'unarmored
        Public Function Unarmored() As Boolean
            If Character.Inventory.ArmorWorn.IsEmpty Then Return True Else Return False
        End Function

        'unencumbered
        Public Function Unencumbered() As Boolean
            If Character.Inventory.Load = "Light" Then Return True Else Return False
        End Function

        'wearing light armor or less
        Public Function WearingLightArmorOrLess() As Boolean
            If Character.Inventory.ArmorWorn.IsEmpty Then
                Return True
            Else
                If Character.Inventory.ArmorProperties.ArmorTraining = "Light" Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

        'wearing medium armor or less
        Public Function WearingMediumArmorOrLess() As Boolean
            If Character.Inventory.ArmorWorn.IsEmpty Then
                Return True
            Else
                Select Case Character.Inventory.ArmorProperties.ArmorTraining
                    Case "Light", "Medium"
                        Return True
                    Case Else
                        Return False
                End Select
            End If
        End Function

        'not wearing a shield
        Public Function NotWearingAShield() As Boolean
            If Character.Inventory.ShieldWorn.IsEmpty Then Return True Else Return False
        End Function

    End Class

End Namespace