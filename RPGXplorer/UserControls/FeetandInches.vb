Option Explicit On
Option Strict On

Imports DevExpress

Public Class FeetandInches

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

    Public ReadOnly Property Inches() As String
        Get
            Return (CInt(Me.ModifierSpin.EditValue)).ToString
        End Get
    End Property

    Public Sub SetValue(ByVal Inches As Integer)
        Try
            Me.ModifierSpin.EditValue = Inches
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ModifierSpin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifierSpin.EditValueChanged
        Try
            SpinDisplay.Text = Rules.Formatting.FormatFeetandInches(CInt(ModifierSpin.EditValue))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FeetandInches_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        ModifierSpin.Focus()
    End Sub

End Class
