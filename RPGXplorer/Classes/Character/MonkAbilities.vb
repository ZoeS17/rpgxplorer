Option Explicit On 
Option Strict On

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class MonkAbilities

        Public Shared Function ImprovedUnarmedDamage(ByVal ClassLevels As Integer, ByVal Size As String) As String
            Try

                Dim Position As Integer = ClassLevels \ 4
                If Position > 5 Then Position = 5

                Select Case Size
                    Case "Small"
                        Select Case Position
                            Case 0
                                Return "1d4"
                            Case 1
                                Return "1d6"
                            Case 2
                                Return "1d8"
                            Case 3
                                Return "1d10"
                            Case 4
                                Return "2d6"
                            Case 5
                                Return "1d8"
                        End Select
                    Case "Medium"
                        Select Case Position
                            Case 0
                                Return "1d6"
                            Case 1
                                Return "1d8"
                            Case 2
                                Return "1d10"
                            Case 3
                                Return "2d6"
                            Case 4
                                Return "2d8"
                            Case 5
                                Return "2d10"
                        End Select
                    Case "Large"
                        Select Case Position
                            Case 0
                                Return "1d8"
                            Case 1
                                Return "2d6"
                            Case 2
                                Return "2d8"
                            Case 3
                                Return "3d6"
                            Case 4
                                Return "3d8"
                            Case 5
                                Return "4d8"
                        End Select
                End Select
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Shared Function MonkACBonus(ByVal ClassLevels As Integer) As Integer
            Try
                Return (ClassLevels \ 5)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Shared Function MonkSpeedBonus(ByVal ClassLevels As Integer) As Integer
            Try
                Return ((ClassLevels \ 3) * 10)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
