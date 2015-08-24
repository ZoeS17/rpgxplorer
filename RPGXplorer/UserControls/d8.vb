Public Class d8

    Public Event ValueChanged()

    Public DieValue As Integer = 0

    'set the die value
    Public Sub SetDie(ByVal DieValue As Integer)
        Try
            Me.DieValue = DieValue

            Select Case DieValue
                Case 1
                    Value1.Focus()
                Case 2
                    Value2.Focus()
                Case 3
                    Value3.Focus()
                Case 4
                    Value4.Focus()
                Case 5
                    Value5.Focus()
                Case 6
                    Value6.Focus()
                Case 7
                    Value7.Focus()
                Case 8
                    Value8.Focus()
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Focus Handlers"

    Private Sub Value1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value1.Click
        Try
            DieValue = 1
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub


    Private Sub Value2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value2.Click
        Try
            DieValue = 2
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value3.Click
        Try
            DieValue = 3
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value4.Click
        Try
            DieValue = 4
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value5.Click
        Try
            DieValue = 5
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value6.Click
        Try
            DieValue = 6
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value7.Click
        Try
            DieValue = 7
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value8.Click
        Try
            DieValue = 8
            RaiseEvent ValueChanged()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
