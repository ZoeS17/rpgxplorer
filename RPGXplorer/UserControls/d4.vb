
Public Class d4

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
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Click Handlers"

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

#End Region

End Class
