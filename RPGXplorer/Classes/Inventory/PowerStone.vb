Option Explicit On 
Option Strict On

Namespace Rules

    Public Class PowerStone
        Inherits Rules.Scroll

        'calculate the base price and cost to create for this set of scroll spells
        Public Shadows Sub Calculate(ByVal StonePowers As Objects.ObjectDataCollection)
            Try

                ComponentCosts = 0
                SpellXPCosts = 0
                _BasePrice = New Money

                Dim PowerDef As Objects.ObjectData

                'calculate the base price, xp and component costs from a set of scroll spell objects
                For Each StonePower As Objects.ObjectData In StonePowers

                    Dim SpellLevel As Double = StonePower.ElementAsInteger("PowerLevel")
                    If SpellLevel = 0 Then SpellLevel = 0.5
                    Dim CasterLevel As Integer = StonePower.ElementAsInteger("ManifesterLevel")
                    PowerDef = StonePower.GetFKObject("Power")

                    If Not PowerDef.Element("ComponentCost") = "Varies (see Rules)" Then
                        ComponentCosts += Formatting.ReverseGP(PowerDef.Element("ComponentCost"))
                    End If

                    If Not PowerDef.Element("XPCost") = "Varies (see Rules)" Then
                        SpellXPCosts += PowerDef.ElementAsInteger("XPCost")
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


