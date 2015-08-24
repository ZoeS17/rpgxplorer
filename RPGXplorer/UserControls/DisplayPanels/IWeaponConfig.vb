Option Explicit On 
Option Strict On

Public Interface IWeaponConfig

    ReadOnly Property Weapons() As Rules.Weapons

    Property Top() As Integer

    Property Left() As Integer

    Property Width() As Integer

    Property Height() As Integer

    Property Anchor() As System.Windows.Forms.AnchorStyles

    Property TabStop() As Boolean

    Event GotFocus(ByVal sender As Object, ByVal e As EventArgs)

    Event Dirty()

    Sub Init(ByVal Panel As WeaponsPanel, ByVal Weapons As Rules.Weapons)

    Sub Reset()

    Sub SetFocus(ByVal var As Boolean)



End Interface


