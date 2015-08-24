Option Explicit On
Option Strict On

Public Class MoneySpin

    'member vars
    Private mMoney As New Money("")

    Public Property MaxGP() As Integer
        Get
            Return CInt(GP.Properties.MaxValue)
        End Get
        Set(ByVal Value As Integer)

            GP.Properties.MaxValue = Value

            'If Value > 0 Then
            '    Dim Mask As String = ""
            '    Dim count As Integer

            '    count = Value.ToString.Length
            '    For i As Integer = 1 To count
            '        Mask = Mask & "9"
            '    Next

            '    GP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            '    GP.Properties.Mask.ShowPlaceHolders = False
            '    GP.Properties.Mask.EditMask = Mask
            'Else
            '    GP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            '    GP.Properties.Mask.EditMask = ""
            'End If

        End Set
    End Property

    Public Property Value() As String
        Get
            Return mMoney.DisplayString
        End Get
        Set(ByVal Value As String)
            Try
                mMoney = New Money(Value)

                GP.EditValue = mMoney.Gold
                SP.EditValue = mMoney.Silver
                CP.EditValue = mMoney.Copper

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Set
    End Property

    Public Property Money() As Money
        Get
            Return mMoney
        End Get
        Set(ByVal Value As Money)
            mMoney = Value
            GP.EditValue = mMoney.Gold
            SP.EditValue = mMoney.Silver
            CP.EditValue = mMoney.Copper
        End Set
    End Property

    Public ReadOnly Property ValueInGP() As Decimal
        Get
            Return mMoney.GoldDecimal
        End Get
    End Property

    Public Shadows WriteOnly Property Enabled() As Boolean
        Set(ByVal Value As Boolean)
            GP.Properties.Enabled = Value
            SP.Properties.Enabled = Value
            CP.Properties.Enabled = Value
        End Set
    End Property

    Private Sub GP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GP.EditValueChanged
        mMoney.Gold = CType(GP.EditValue, Integer)
    End Sub

    Private Sub SP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SP.EditValueChanged
        mMoney.Silver = CType(SP.EditValue, Integer)
    End Sub

    Private Sub CP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP.EditValueChanged
        mMoney.Copper = CType(CP.EditValue, Integer)
    End Sub

    Private Sub DevXLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GP.LostFocus, SP.LostFocus, CP.LostFocus
        CType(sender, Control).Refresh()
    End Sub

End Class
