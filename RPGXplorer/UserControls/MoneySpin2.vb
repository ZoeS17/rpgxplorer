Option Explicit On
Option Strict On

Public Class MoneySpin2

    'event
    Public Event ValueChanged()

    'member vars
    Private mMoney As New Money("")

    Public Property Value() As String
        Get
            Return mMoney.DisplayString
        End Get
        Set(ByVal Value As String)
            Try
                mMoney = New Money(Value)

                PP.EditValue = mMoney.Platinum
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
            PP.EditValue = mMoney.Platinum
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
            PP.Properties.Enabled = Value
            GP.Properties.Enabled = Value
            SP.Properties.Enabled = Value
            CP.Properties.Enabled = Value
        End Set
    End Property

    Public Shadows Sub Refresh()
        PP.EditValue = Money.Platinum
        GP.EditValue = Money.Gold
        SP.EditValue = Money.Silver
        CP.EditValue = Money.Copper
    End Sub

    Private Sub PP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP.EditValueChanged
        mMoney.Platinum = CType(PP.EditValue, Integer)
        RaiseEvent ValueChanged()
    End Sub

    Private Sub GP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GP.EditValueChanged
        mMoney.Gold = CType(GP.EditValue, Integer)
        RaiseEvent ValueChanged()
    End Sub

    Private Sub SP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SP.EditValueChanged
        mMoney.Silver = CType(SP.EditValue, Integer)
        RaiseEvent ValueChanged()
    End Sub

    Private Sub CP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP.EditValueChanged
        mMoney.Copper = CType(CP.EditValue, Integer)
        RaiseEvent ValueChanged()
    End Sub

End Class
