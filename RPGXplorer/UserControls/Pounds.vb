Option Explicit On
Option Strict On

Public Class Pounds

    Private SpinValue As Double
    Private SpinMax As Double = 1200

    Public Property MaxValue() As Double
        Get
            Return SpinMax
        End Get
        Set(ByVal Value As Double)
            SpinMax = Value
        End Set
    End Property

    Public Shadows WriteOnly Property Enabled() As Boolean
        Set(ByVal Value As Boolean)
            If Value = False Then
                SpinDisplay.Enabled = False
                ModifierSpin.Enabled = False
            Else
                SpinDisplay.Enabled = True
                ModifierSpin.Enabled = True
            End If
        End Set
    End Property

    Public Shadows ReadOnly Property Text() As String
        Get
            Return Me.SpinDisplay.Text
        End Get
    End Property

    Public Sub SetValue(ByVal Pounds As Integer)
        Try
            Me.ModifierSpin.EditValue = Pounds
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public ReadOnly Property Pounds() As String
        Get
            Return Me.ModifierSpin.EditValue.ToString
        End Get
    End Property

    Private Sub ModifierSpin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifierSpin.EditValueChanged
        Try
            SpinDisplay.Text = Rules.Formatting.FormatPounds(CInt(ModifierSpin.EditValue))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
