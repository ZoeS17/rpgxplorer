Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports System.Threading

Namespace Rules

    Public Class Dice

        'array of dyce type strings e.g. d2, d3 etc.
        Public Shared DiceTypes As String()

        'dice types enumeration
        Public Enum Dice As Byte
            NotSet = 1
            d2 = 2
            d3 = 3
            d4 = 4
            d6 = 6
            d8 = 8
            d10 = 10
            d12 = 12
            d20 = 20
            d100 = 100
        End Enum

        'a structure that holds a dice range e.g. 2d6 + 1, 4d8 etc.
        Public Structure DiceRange
            Public Dice As Dice
            Public DiceCount As Integer
            Public Modifier As Integer

            Public Overrides Function ToString() As String
                Try
                    If Modifier = 0 Then
                        Return DiceCount.ToString & Dice.ToString
                    Else
                        Return DiceCount.ToString & Dice.ToString & Rules.Formatting.FormatModifier(Modifier)
                    End If
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

            Public Function ValidDice() As Boolean
                Try
                    Select Case Dice
                        Case Dice.d2, Dice.d3, Dice.d4, Dice.d6, Dice.d8, Dice.d10, Dice.d12, Dice.d20, Dice.d100
                            Return True
                        Case Else
                            Return False
                    End Select
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

            Public Function IsEmpty() As Boolean
                Try
                    If DiceCount = 0 Then Return True Else Return False
                Catch ex As Exception
                    Throw New Exception(ex.Message, ex)
                End Try
            End Function

            Public Function GreaterThan(ByVal Range As DiceRange) As Boolean
                If AverageHP(Range) > AverageHP(Me) Then Return True Else Return False
            End Function

        End Structure

        'load the dice types array
        Public Shared Sub LoadDiceTypes()
            Try
                ReDim DiceTypes(6)
                DiceTypes(0) = "d2"
                DiceTypes(1) = "d3"
                DiceTypes(2) = "d4"
                DiceTypes(3) = "d6"
                DiceTypes(4) = "d8"
                DiceTypes(5) = "d10"
                DiceTypes(6) = "d12"
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'convert a string into a dice range or throw an exception
        Public Shared Function GetDiceRange(ByVal Text As String) As DiceRange
            Dim DdPos, PlusPos, MinusPos As Integer
            Dim tempStr As String
            Dim temp As DiceRange
            Dim OK As Boolean = True

            Try
                DdPos = Text.IndexOfAny("d".ToCharArray)
                If DdPos = -1 Then Throw New RulesException("Dice Range format incorrect")
                tempStr = Text.Substring(0, DdPos)

                'cannot have leading positive or negative symbol
                If tempStr.IndexOfAny("+-".ToCharArray) <> -1 Then Throw New RulesException("Dice Range format incorrect")

                Try
                    tempStr = CStr(Math.Round(CDbl(tempStr)))
                Catch ex As System.InvalidCastException
                    Throw New RulesException("Dice Range format incorrect")
                End Try

                temp.DiceCount = CShort(tempStr)
                If temp.DiceCount < 1 Then Throw New RulesException("Dice Range format incorrect")

                PlusPos = Text.IndexOf("+")
                MinusPos = Text.IndexOf("-")

                If PlusPos > 0 Then
                    tempStr = Text.Substring(DdPos + 1, PlusPos - DdPos - 1)

                    Try
                        tempStr = CStr(Math.Round(CDbl(tempStr)))
                    Catch ex As System.InvalidCastException
                        Throw New RulesException("Dice Range format incorrect")
                    End Try

                    temp.Dice = CType(tempStr, Dice)
                    If temp.Dice < 1 Then Throw New RulesException("Dice Range format incorrect")

                    tempStr = Text.Substring(PlusPos + 1, Text.Length - PlusPos - 1)

                    Try
                        tempStr = CStr(Math.Round(CDbl(tempStr)))
                    Catch ex As System.InvalidCastException
                        Throw New RulesException("Dice Range format incorrect")
                    End Try

                    temp.Modifier = CShort(tempStr)
                    If temp.Modifier < 1 Then Throw New RulesException("Dice Range format incorrect")

                ElseIf MinusPos > 0 Then

                    tempStr = Text.Substring(DdPos + 1, MinusPos - DdPos - 1)

                    Try
                        tempStr = CStr(Math.Round(CDbl(tempStr)))
                    Catch ex As System.InvalidCastException
                        Throw New RulesException("Dice Range format incorrect")
                    End Try

                    temp.Dice = CType(tempStr, Dice)
                    If temp.Dice < 1 Then Throw New RulesException("Dice Range format incorrect")

                    tempStr = Text.Substring(PlusPos + 1, Text.Length - MinusPos - 1)

                    Try
                        tempStr = CStr(Math.Round(CDbl(tempStr)))
                    Catch ex As System.InvalidCastException
                        Throw New RulesException("Dice Range format incorrect")
                    End Try

                    temp.Modifier = CShort(tempStr)
                    If temp.Modifier < 1 Then Throw New RulesException("Dice Range format incorrect")
                Else

                    tempStr = Text.Substring(DdPos + 1, Text.Length - DdPos - 1)

                    Try
                        tempStr = CStr(Math.Round(CDbl(tempStr)))
                    Catch ex As System.InvalidCastException
                        Throw New RulesException("Dice Range format incorrect")
                    End Try

                    temp.Dice = CType(tempStr, Dice)
                    If temp.Dice < 1 Then Throw New RulesException("Dice Range format incorrect")
                End If

                'check to make sure that the assigned dice number relates to the "dice" enum i.e. a real dice type
                If Not temp.ValidDice Then Throw New RulesException("Dice Type not valid")

                Return temp
            Catch rex As RulesException
                Throw rex
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'convert a string into a dice 
        Public Shared Function GetDice(ByVal Text As String) As Rules.Dice.Dice
            Try
                Return CType(Text.Remove(0, 1), Rules.Dice.Dice)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the max value of a dice
        Public Shared Function GetDiceMax(ByVal Dice As Dice) As Integer
            Try
                Return CInt(Dice.ToString.Remove(0, 1))
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Shared Function GetDiceAverage(ByVal dice As Dice) As Double
            Try
                Select Case dice
                    Case Rules.Dice.Dice.d2
                        Return 1.5
                    Case Rules.Dice.Dice.d3
                        Return 2
                    Case Rules.Dice.Dice.d4
                        Return 2.5
                    Case Rules.Dice.Dice.d6
                        Return 3.5
                    Case Rules.Dice.Dice.d8
                        Return 4.5
                    Case Rules.Dice.Dice.d10
                        Return 5.5
                    Case Rules.Dice.Dice.d12
                        Return 6.5
                    Case Rules.Dice.Dice.d20
                        Return 10.5
                    Case Rules.Dice.Dice.d100
                        Return 50.5
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this string a valid dice range?
        Public Shared Function ValidDiceRange(ByVal Text As String) As Boolean
            Try
                GetDiceRange(Text)
                Return True
            Catch ex As RulesException
                Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this string a valid dice range?
        Shared Function ValidDiceRange(ByVal box As DevExpress.XtraEditors.TextEdit) As Boolean
            Dim HD As Rules.Dice.DiceRange
            Try
                HD = Rules.Dice.GetDiceRange(box.Text)
                Return True
            Catch ex As RulesException
                Return False
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this string a valid dice range or number?
        Shared Function ValidNumberDiceRange(ByVal box As DevExpress.XtraEditors.TextEdit, Optional ByVal AllowZero As Boolean = False) As Boolean
            Dim temp As Double
            Try
                If box.Text = "" Then Return False

                If Microsoft.VisualBasic.IsNumeric(box.Text) Then
                    temp = Math.Round(CDbl(box.Text))

                    If AllowZero AndAlso temp = 0 Then Return True
                    If temp < 1 Then Return False

                    box.Text = CStr(temp)
                    Return True
                Else
                    Return ValidDiceRange(box)
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this string a positive whole number?
        Shared Function ValidNumber(ByVal box As DevExpress.XtraEditors.TextEdit) As Boolean
            Dim temp As Double
            Try
                Try
                    temp = Math.Round(CDbl(box.Text))
                    If temp < 1 Then
                        Return False
                    End If
                    box.Text = CStr(temp)
                    Return True
                Catch ex As System.InvalidCastException
                    Return False
                End Try
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'is this string a positive whole number inc. zero?
        Shared Function ValidNumberIncZero(ByVal box As DevExpress.XtraEditors.TextEdit) As Boolean
            Dim temp As Double
            Try
                Try
                    temp = Math.Round(CDbl(box.Text))
                    If temp < 1 And Not temp = 0 Then
                        Return False
                    End If
                    box.Text = CStr(temp)
                    Return True
                Catch ex As System.InvalidCastException
                    Return False
                End Try
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        ''return the average hit points for this dice range
        Public Shared Function AverageHP(ByVal HD As DiceRange) As Double
            Try
                Return Math.Floor(HD.DiceCount * ((HD.Dice / 2) + 0.5)) + HD.Modifier
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'roll them dice
        Public Shared Function RollDiceRange(ByVal Dice As DiceRange) As Integer
            Dim x As Integer
            Dim temp As Integer
            Dim Rnd As New Random

            Try
                For x = 1 To Dice.DiceCount
                    Thread.Sleep(25)
                    temp += Rnd.Next(1, Dice.Dice + 1)
                Next
                temp += Dice.Modifier

                Return temp

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'roll a dice range but discard the lowest dice
        Public Shared Function RollDiceRangeDiscardLowest(ByVal Dice As DiceRange) As Integer
            Dim x, temp, temp2, lowest As Integer
            Dim Rnd As New Random

            Try
                For x = 1 To Dice.DiceCount
                    Thread.Sleep(25)
                    temp2 = Rnd.Next(1, Dice.Dice + 1)
                    If temp2 < lowest Or lowest = 0 Then lowest = temp2
                    temp += temp2
                Next
                temp += Dice.Modifier
                temp -= lowest

                Return temp

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'roll a dice range but discard the lowest dice - 5d6
        Public Shared Function RollDiceRangeDiscardLowestTwo(ByVal Dice As DiceRange) As Integer
            Dim x, temp, temp2, lowest1, Lowest2 As Integer
            Dim Rnd As New Random

            Try
                For x = 1 To Dice.DiceCount
                    Thread.Sleep(25)
                    temp2 = Rnd.Next(1, Dice.Dice + 1)
                    If temp2 < lowest1 Or lowest1 = 0 Then
                        lowest1 = temp2
                    ElseIf temp2 < Lowest2 Or Lowest2 = 0 Then
                        Lowest2 = temp2
                    End If

                    temp += temp2
                Next
                temp += Dice.Modifier
                temp -= lowest1
                temp -= Lowest2

                Return temp

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
