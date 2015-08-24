Option Explicit On 
Option Strict On

Namespace Rules

    Public Class Scroll

#Region "Member Variables"

        Public ComponentCosts As Integer 'gold
        Public SpellXPCosts As Integer
        <CLSCompliant(False)> Public _BasePrice As Money

#End Region

#Region "Properties"

        'the base price of a scroll
        Public ReadOnly Property BasePrice() As Money
            Get
                Return _BasePrice
            End Get
        End Property

        'the raw material cost to create scroll
        Public ReadOnly Property MaterialsCost() As Money
            Get
                Dim Cost As New Money
                Cost.AddMoney(_BasePrice)
                Cost.Multiply(0.5)

                Return Cost
            End Get
        End Property

        'the xp cost to create scroll
        Public ReadOnly Property XPCost() As Integer
            Get
                Try
                    Dim XP As Integer = CType(Math.Round(_BasePrice.Gold / 25), Integer)
                    XP += SpellXPCosts
                    If XP = 0 Then XP = 1
                    Return XP
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Get
        End Property

#End Region

        'calculate the base price and cost to create for this set of scroll spells
        Public Sub Calculate(ByVal ScrollSpells As Objects.ObjectDataCollection)
            Try
                ComponentCosts = 0
                SpellXPCosts = 0
                _BasePrice = New Money

                Dim SpellDef As Objects.ObjectData

                'calculate the base price, xp and component costs from a set of scroll spell objects
                For Each ScrollSpell As Objects.ObjectData In ScrollSpells
                    Dim SpellLevel As Double = ScrollSpell.ElementAsInteger("SpellLevel")
                    If SpellLevel = 0 Then SpellLevel = 0.5
                    Dim CasterLevel As Integer = ScrollSpell.ElementAsInteger("CasterLevel")
                    SpellDef = ScrollSpell.GetFKObject("Spell")
                    If Not SpellDef.Element("ComponentCost") = "Varies (see Rules)" Then
                        ComponentCosts += Formatting.ReverseGP(SpellDef.Element("ComponentCost"))
                    End If
                    If Not SpellDef.Element("XPCost") = "Varies (see Rules)" Then
                        SpellXPCosts += SpellDef.ElementAsInteger("XPCost")
                    End If
                    _BasePrice.Copper += CType(Math.Round(SpellLevel * CasterLevel * 2500), Integer)
                Next

                _BasePrice.Gold += ComponentCosts
                _BasePrice = _BasePrice.InGold

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace
