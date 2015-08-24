Public Class Dice

    'member variables
    Private CurrentDie As Rules.Dice.Dice

    'events
    Public Event DiceClicked()

    'updates the focus - used for fixing a problem when in SmallHitdiceMode
    Public Sub UpdateFocus()
        Select Case CurrentDie
            Case Rules.Dice.Dice.d4
                Select Case D4.DieValue
                    Case 1
                        D4.Value1.Focus()
                    Case 2
                        D4.Value2.Focus()
                    Case 3
                        D4.Value3.Focus()
                    Case 4
                        D4.Value4.Focus()
                End Select
            Case Rules.Dice.Dice.d6
                Select Case D6.DieValue
                    Case 1
                        D6.Value1.Focus()
                    Case 2
                        D6.Value2.Focus()
                    Case 3
                        D6.Value3.Focus()
                    Case 4
                        D6.Value4.Focus()
                    Case 5
                        D6.Value5.Focus()
                    Case 6
                        D6.Value6.Focus()
                End Select
            Case Rules.Dice.Dice.d8
                Select Case D8.DieValue
                    Case 1
                        D8.Value1.Focus()
                    Case 2
                        D8.Value2.Focus()
                    Case 3
                        D8.Value3.Focus()
                    Case 4
                        D8.Value4.Focus()
                    Case 5
                        D8.Value5.Focus()
                    Case 6
                        D8.Value6.Focus()
                    Case 7
                        D8.Value7.Focus()
                    Case 8
                        D8.Value8.Focus()
                End Select
            Case Rules.Dice.Dice.d10
                Select Case D10.DieValue
                    Case 1
                        d10.Value1.Focus()
                    Case 2
                        D10.Value2.Focus()
                    Case 3
                        d10.Value3.Focus()
                    Case 4
                        d10.Value4.Focus()
                    Case 5
                        D10.Value5.Focus()
                    Case 6
                        d10.Value6.Focus()
                    Case 7
                        D10.Value7.Focus()
                    Case 8
                        D10.Value8.Focus()
                    Case 9
                        D10.Value9.Focus()
                    Case 10
                        D10.Value10.Focus()
                End Select
            Case Rules.Dice.Dice.d12
                Select Case D12.DieValue
                    Case 1
                        d12.Value1.Focus()
                    Case 2
                        D12.Value2.Focus()
                    Case 3
                        d12.Value3.Focus()
                    Case 4
                        d12.Value4.Focus()
                    Case 5
                        D12.Value5.Focus()
                    Case 6
                        d12.Value6.Focus()
                    Case 7
                        D12.Value7.Focus()
                    Case 8
                        d12.Value8.Focus()
                    Case 9
                        D12.Value9.Focus()
                    Case 10
                        D12.Value10.Focus()
                    Case 11
                        D12.Value11.Focus()
                    Case 12
                        D12.Value12.Focus()
                End Select
        End Select
    End Sub

    'set the value of the visible die
    Public Sub SetDie(ByVal DieValue As Integer)
        Try
            Select Case CurrentDie
                Case Rules.Dice.Dice.d4
                    D4.SetDie(DieValue)
                Case Rules.Dice.Dice.d6
                    D6.SetDie(DieValue)
                Case Rules.Dice.Dice.d8
                    D8.SetDie(DieValue)
                Case Rules.Dice.Dice.d10
                    D10.SetDie(DieValue)
                Case Rules.Dice.Dice.d12
                    D12.SetDie(DieValue)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'set the dice to max
    Public Sub SetMax()
        Try
            Select Case CurrentDie
                Case Rules.Dice.Dice.d4
                    D4.SetDie(4)
                Case Rules.Dice.Dice.d6
                    D6.SetDie(6)
                Case Rules.Dice.Dice.d8
                    D8.SetDie(8)
                Case Rules.Dice.Dice.d10
                    D10.SetDie(10)
                Case Rules.Dice.Dice.d12
                    D12.SetDie(12)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the value of the visible die
    Public Function GetDieValue() As Rules.Dice.Dice
        Try
            'If D4.Visible Then
            '    Return CType(D4.DieValue, Rules.Dice.Dice)
            'ElseIf D6.Visible Then
            '    Return CType(D6.DieValue, Rules.Dice.Dice)
            'ElseIf D8.Visible Then
            '    Return CType(D8.DieValue, Rules.Dice.Dice)
            'ElseIf D10.Visible Then
            '    Return CType(D10.DieValue, Rules.Dice.Dice)
            'ElseIf D12.Visible Then
            '    Return CType(D12.DieValue, Rules.Dice.Dice)
            'End If

            Select Case CurrentDie
                Case Rules.Dice.Dice.d4
                    Return CType(D4.DieValue, Rules.Dice.Dice)
                Case Rules.Dice.Dice.d6
                    Return CType(D6.DieValue, Rules.Dice.Dice)
                Case Rules.Dice.Dice.d8
                    Return CType(D8.DieValue, Rules.Dice.Dice)
                Case Rules.Dice.Dice.d10
                    Return CType(D10.DieValue, Rules.Dice.Dice)
                Case Rules.Dice.Dice.d12
                    Return CType(D12.DieValue, Rules.Dice.Dice)
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'init
    Public Sub Init(ByVal DiceType As Rules.Dice.Dice)
        Try
            Select Case DiceType
                Case Rules.Dice.Dice.d4
                    CurrentDie = Rules.Dice.Dice.d4
                    D4.Visible = True
                    D6.Visible = False
                    D8.Visible = False
                    D10.Visible = False
                    D12.Visible = False
                Case Rules.Dice.Dice.d6
                    CurrentDie = Rules.Dice.Dice.d6
                    D4.Visible = False
                    D6.Visible = True
                    D8.Visible = False
                    D10.Visible = False
                    D12.Visible = False
                Case Rules.Dice.Dice.d8
                    CurrentDie = Rules.Dice.Dice.d8
                    D4.Visible = False
                    D6.Visible = False
                    D8.Visible = True
                    D10.Visible = False
                    D12.Visible = False
                Case Rules.Dice.Dice.d10
                    CurrentDie = Rules.Dice.Dice.d10
                    D4.Visible = False
                    D6.Visible = False
                    D8.Visible = False
                    D10.Visible = True
                    D12.Visible = False
                Case Rules.Dice.Dice.d12
                    CurrentDie = Rules.Dice.Dice.d12
                    D4.Visible = False
                    D6.Visible = False
                    D8.Visible = False
                    D10.Visible = False
                    D12.Visible = True
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'die control width
    Public ReadOnly Property DieWidth() As Integer
        Get
            'If D4.Visible Then
            '    Return D4.Width
            'ElseIf D6.Visible Then
            '    Return D6.Width
            'ElseIf D8.Visible Then
            '    Return D8.Width
            'ElseIf D10.Visible Then
            '    Return D10.Width
            'ElseIf D12.Visible Then
            '    Return D12.Width
            'End If

            Select Case CurrentDie
                Case Rules.Dice.Dice.d4
                    Return D4.Width
                Case Rules.Dice.Dice.d6
                    Return D6.Width
                Case Rules.Dice.Dice.d8
                    Return D8.Width
                Case Rules.Dice.Dice.d10
                    Return D10.Width
                Case Rules.Dice.Dice.d12
                    Return D12.Width
            End Select

        End Get
    End Property

#Region "Changed Events"

    Private Sub D4_ValueChanged() Handles D4.ValueChanged
        Try
            RaiseEvent DiceClicked()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub D6_ValueChanged() Handles D6.ValueChanged
        Try
            RaiseEvent DiceClicked()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub D8_ValueChanged() Handles D8.ValueChanged
        Try
            RaiseEvent DiceClicked()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub D10_ValueChanged() Handles D10.ValueChanged
        Try
            RaiseEvent DiceClicked()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub D12_ValueChanged() Handles D12.ValueChanged
        Try
            RaiseEvent DiceClicked()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
