Option Explicit On
Option Strict On

Public Class Modifier

    Public Shadows Event LostFocus()

    Public Overrides Property Text() As String
        Get
            Return ModifierSpin.Text
        End Get
        Set(ByVal Value As String)
            ModifierSpin.Text = Value
        End Set
    End Property

    Public Shadows Property Enabled() As Boolean
        Get
            Return ModifierSpin.Enabled
        End Get
        Set(ByVal Value As Boolean)
            ModifierSpin.Enabled = Value
        End Set
    End Property

    Public Sub SetValue(ByVal Value As Integer)
        Try
            Me.ModifierSpin.EditValue = Value
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Private Sub ModifierSpin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierSpin.EditValueChanged
    '    ModifierSpin.EditValue = Rules.Formatting.FormatModifier(CInt(ModifierSpin.Text))
    'End Sub

    Private Sub ModifierSpin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifierSpin.LostFocus
        RaiseEvent LostFocus()
    End Sub

End Class
