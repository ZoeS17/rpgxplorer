Option Explicit On 
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class Money

    'class to handle money

    Public Platinum As Integer
    Public Gold As Integer
    Public Silver As Integer
    Public Copper As Integer

    'constructor
    Public Sub New()
        Try
            Platinum = 0
            Gold = 0
            Silver = 0
            Copper = 0
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'constructor
    Public Sub New(ByVal Money As String)
        Try
            Platinum = 0
            Gold = 0
            Silver = 0
            Copper = 0
            AddMoney(Money)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add money
    Public Sub AddMoney(ByVal Money As String)
        Dim TempArray As String()
        Dim Temp As String
        Dim n As Integer

        Try
            If Money <> "" And Money <> "-" Then

                Money = Money.Replace("+", "")
                TempArray = Money.Split(",".ToCharArray)

                For n = 0 To TempArray.GetUpperBound(0)
                    Temp = TempArray(n).Trim

                    Select Case Temp.Substring(Temp.Length - 2, 2)
                        Case "pp"
                            Platinum += Sorter.StripLeftNumbers(Temp)
                        Case "gp"
                            Gold += Sorter.StripLeftNumbers(Temp)
                        Case "sp"
                            Silver += Sorter.StripLeftNumbers(Temp)
                        Case "cp"
                            Copper += Sorter.StripLeftNumbers(Temp)
                    End Select
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add money
    Public Sub AddMoney(ByVal Money As Money)
        Try
            Platinum += Money.Platinum
            Gold += Money.Gold
            Silver += Money.Silver
            Copper += Money.Copper
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove money
    Public Function RemoveMoney(ByVal Money As String) As Boolean
        Try
            Return RemoveMoney(New Money(Money))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'remove money
    Public Function RemoveMoney(ByVal Money As Money) As Boolean
        Dim RemoveCopper As Integer

        Try
            RemoveCopper = Money.InCopper
            If RemoveCopper > Me.InCopper Then Return False

            'first pass tries to remove small change first
            If RemoveCopper > 0 Then
                If RemoveCopper > Copper Then
                    RemoveCopper -= Copper
                    Copper = 0
                Else
                    Copper -= RemoveCopper
                    RemoveCopper = 0
                End If
            End If

            If RemoveCopper >= 10 And Silver > 0 Then
                If (RemoveCopper / 10) > Silver Then
                    RemoveCopper -= Silver * 10
                    Silver = 0
                Else
                    Dim RemoveSilver As Integer = CType(Math.Floor(RemoveCopper / 10), Integer)
                    Silver -= RemoveSilver
                    RemoveCopper -= RemoveSilver * 10
                End If
            End If

            If RemoveCopper >= 100 And Gold > 0 Then
                If (RemoveCopper / 100) > Gold Then
                    RemoveCopper -= Gold * 100
                    Gold = 0
                Else
                    Dim RemoveGold As Integer = CType(Math.Floor(RemoveCopper / 100), Integer)
                    Gold -= RemoveGold
                    RemoveCopper -= RemoveGold * 100
                End If
            End If

            If RemoveCopper >= 1000 And Platinum > 0 Then
                If (RemoveCopper / 1000) > Platinum Then
                    RemoveCopper -= Platinum * 1000
                    Platinum = 0
                Else
                    Dim RemovePlatinum As Integer = CType(Math.Floor(RemoveCopper / 1000), Integer)
                    Platinum -= RemovePlatinum
                    RemoveCopper -= RemovePlatinum * 1000
                End If
            End If

            'second pass will break larger coins to get change
            If RemoveCopper > 0 Then
                Dim Change As Money = New Money

                Dim RemoveSilver As Integer = CType(Math.Ceiling(RemoveCopper / 10), Integer)
                If Silver >= RemoveSilver Then
                    Silver -= RemoveSilver
                    Copper += (RemoveSilver * 10) - RemoveCopper
                    Return True
                End If

                Dim RemoveGold As Integer = CType(Math.Ceiling(RemoveCopper / 100), Integer)
                If Gold >= RemoveGold Then
                    Gold -= RemoveGold
                    Change.Copper = (RemoveGold * 100) - RemoveCopper
                    Change = Change.InPlatinum
                    Silver += Change.Silver
                    Copper += Change.Copper
                    Return True
                End If

                Dim RemovePlatinum As Integer = CType(Math.Ceiling(RemoveCopper / 1000), Integer)
                Platinum -= RemovePlatinum
                Change.Copper = (RemovePlatinum * 1000) - RemoveCopper
                Change = Change.InPlatinum
                Gold += Change.Gold
                Silver += Change.Silver
                Copper += Change.Copper
                Return True
            Else
                Return True
            End If





            ''remove platinum
            'If Remove.Platinum <= Platinum Then
            '    Platinum -= Remove.Platinum
            '    Remove.Platinum = 0
            'Else
            '    Remove.Platinum -= Platinum
            '    Platinum = 0
            'End If

            'If Not Remove.Platinum = 0 Then
            '    If (Remove.Platinum * 10) <= Gold Then
            '        Gold -= (Remove.Platinum * 10)
            '        Remove.Platinum = 0
            '    Else
            '        Remove.Platinum -= Gold * 10
            '        Gold = 0
            '    End If
            'End If

            'If Not Remove.Platinum = 0 Then
            '    If (Remove.Platinum * 100) <= Silver Then
            '        Silver -= (Remove.Platinum * 100)
            '        Remove.Platinum = 0
            '    Else
            '        Remove.Platinum -= Silver * 100
            '        Silver = 0
            '    End If
            'End If

            'If Not Remove.Platinum = 0 Then
            '    If (Remove.Platinum * 1000) <= Copper Then
            '        Copper -= (Remove.Platinum * 1000)
            '        Remove.Platinum = 0
            '    Else
            '        Remove.Platinum -= Copper * 1000
            '        Copper = 0
            '    End If
            'End If

            ''remove gold
            'If Remove.Gold / 10 <= Platinum Then
            '    Platinum -= CType(Math.Floor(Remove.Gold / 10), Integer)
            '    Remove.Gold = Remove.Gold - CType(Math.Floor(Remove.Gold / 10), Integer)
            'Else
            '    Remove.Gold -= Platinum * 10
            '    Platinum = 0
            'End If

            'If Not Remove.Gold = 0 Then
            '    If Remove.Gold <= Gold Then
            '        Gold -= Remove.Gold
            '        Remove.Gold = 0
            '    Else
            '        Remove.Gold -= Gold
            '        Gold = 0
            '    End If
            'End If

            'If Not Remove.Gold = 0 Then
            '    If (Remove.Gold * 10) <= Silver Then
            '        Silver -= (Remove.Gold * 10)
            '        Remove.Gold = 0
            '    Else
            '        Remove.Gold -= Silver * 10
            '        Silver = 0
            '    End If
            'End If

            'If Not Remove.Gold = 0 Then
            '    If (Remove.Gold * 100) <= Copper Then
            '        Copper -= (Remove.Gold * 100)
            '        Remove.Gold = 0
            '    Else
            '        Remove.Gold -= Copper * 100
            '        Copper = 0
            '    End If
            'End If

            ''remove silver
            'If Remove.Silver / 100 <= Platinum Then
            '    Platinum -= CType(Math.Floor(Remove.Silver / 100), Integer)
            '    Remove.Silver = Remove.Silver - CType(Math.Floor(Remove.Silver / 100), Integer)
            'Else
            '    Remove.Silver -= Platinum * 100
            '    Platinum = 0
            'End If

            'If Not Remove.Silver = 0 Then
            '    If Remove.Silver / 10 <= Gold Then
            '        Gold -= CType(Math.Floor(Remove.Silver / 10), Integer)
            '        Remove.Silver = Remove.Silver - CType(Math.Floor(Remove.Silver / 10), Integer)
            '    Else
            '        Remove.Silver -= Gold * 10
            '        Gold = 0
            '    End If
            'End If

            'If Not Remove.Silver = 0 Then
            '    If (Remove.Silver) <= Silver Then
            '        Silver -= Remove.Silver
            '        Remove.Silver = 0
            '    Else
            '        Remove.Silver -= Silver
            '        Silver = 0
            '    End If
            'End If

            'If Not Remove.Silver = 0 Then
            '    If (Remove.Silver * 10) <= Copper Then
            '        Copper -= (Remove.Silver * 10)
            '        Remove.Silver = 0
            '    Else
            '        Remove.Silver -= Copper * 10
            '        Copper = 0
            '    End If
            'End If

            ''remove copper
            'If Remove.Copper / 1000 <= Platinum Then
            '    Platinum -= CType(Math.Floor(Remove.Copper / 1000), Integer)
            '    Remove.Copper = Remove.Copper - CType(Math.Floor(Remove.Copper / 1000), Integer)
            'Else
            '    Remove.Copper -= Platinum * 1000
            '    Platinum = 0
            'End If

            'If Not Remove.Copper = 0 Then
            '    If Remove.Copper / 100 <= Gold Then
            '        Gold -= CType(Math.Floor(Remove.Copper / 100), Integer)
            '        Remove.Copper = Remove.Copper - CType(Math.Floor(Remove.Copper / 100), Integer)
            '    Else
            '        Remove.Copper -= Gold * 100
            '        Gold = 0
            '    End If
            'End If

            'If Not Remove.Copper = 0 Then
            '    If Remove.Copper / 10 <= Silver Then
            '        Silver -= CType(Math.Floor(Remove.Copper / 10), Integer)
            '        Remove.Copper = Remove.Copper - CType(Math.Floor(Remove.Copper / 10), Integer)
            '    Else
            '        Remove.Copper -= Silver * 10
            '        Silver = 0
            '    End If
            'End If

            'If Not Remove.Copper = 0 Then
            '    If Remove.Copper <= Copper Then
            '        Copper -= Remove.Copper
            '        Remove.Copper = 0
            '    Else
            '        Remove.Copper -= Copper
            '        Copper = 0
            '    End If
            'End If

            'Return True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'multiply by given factor
    Public Sub Multiply(ByVal Factor As Double)
        Dim Copper As Integer
        Dim Temp As New Money

        Try
            Copper = Me.InCopper
            Copper = CType(Math.Round(Copper * Factor), Integer)
            Temp = FromCopper(Copper)
            Temp = Temp.InGold
            Me.Platinum = Temp.Platinum
            Me.Gold = Temp.Gold
            Me.Silver = Temp.Silver
            Me.Copper = Temp.Copper
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'value as decimal in gold
    Public Function GoldDecimal() As Decimal
        Try
            Return New Decimal((Platinum * 10) + Gold + (Silver / 10) + (Copper / 100))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'value in copper as decimal
    Public Function InCopper() As Integer
        Try
            Return Copper + (Silver * 10) + (Gold * 100) + (Platinum * 1000)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'convert an amount of copper into least no of coins
    Private Function FromCopper(ByVal Copper As Integer) As Money
        Try
            FromCopper = New Money
            FromCopper.Platinum = CType(Math.Floor(Copper / 1000), Integer)
            Copper -= FromCopper.Platinum * 1000
            FromCopper.Gold = CType(Math.Floor(Copper / 100), Integer)
            Copper -= FromCopper.Gold * 100
            FromCopper.Silver = CType(Math.Floor(Copper / 10), Integer)
            Copper -= FromCopper.Silver * 10
            FromCopper.Copper = Copper

            Return FromCopper

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'formatted display string
    Public Function DisplayString() As String
        Dim Temp As String = ""

        Try
            If Platinum > 0 Then
                Temp &= Platinum.ToString & " pp"
            End If

            If Gold > 0 Then
                If Temp <> "" Then Temp &= ", "
                Temp &= Gold.ToString & " gp"
            End If

            If Silver > 0 Then
                If Temp <> "" Then Temp &= ", "
                Temp &= Silver.ToString & " sp"
            End If

            If Copper > 0 Then
                If Temp <> "" Then Temp &= ", "
                Temp &= Copper.ToString & " cp"
            End If

            Return Temp

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'convert money into least no of coins (ignoring platinum)
    Public Function InGold() As Money
        Dim Temp As New Money
        Dim Coppers As Integer

        Try
            Coppers = Me.InCopper
            Temp = FromCopper(Coppers)
            Temp.Gold += Temp.Platinum * 10
            Temp.Platinum = 0
            Return Temp
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'convert money into least no of coins 
    Public Function InPlatinum() As Money
        Dim Temp As New Money
        Dim Coppers As Integer

        Try
            Coppers = Me.InCopper
            Temp = FromCopper(Coppers)
            Return Temp
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'number of coins 
    Public Function CoinCount() As Integer
        Return Copper + Silver + Gold + Platinum
    End Function

    'weight
    Public Function Weight() As Double
        Return Math.Round((CoinCount() / 100) * General.CoinWeight, 2)
    End Function

End Class
