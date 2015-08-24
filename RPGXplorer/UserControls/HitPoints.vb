Option Explicit On
Option Strict On

Public Class HitPoints

    Private mBaseHP, mSubdual As Integer
    Private SpinMax As Double = 1000

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

    Public Sub SetValue(ByVal HP As Integer, ByVal BaseHP As Integer, ByVal Subdual As Integer)
        Try
            mBaseHP = BaseHP
            mSubdual = Subdual
            Me.ModifierSpin.EditValue = HP
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ModifierSpin_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifierSpin.EditValueChanged
        Try
            SpinDisplay.Text = Rules.Formatting.FormatHP(mBaseHP, CInt(Me.ModifierSpin.EditValue), mSubdual)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
