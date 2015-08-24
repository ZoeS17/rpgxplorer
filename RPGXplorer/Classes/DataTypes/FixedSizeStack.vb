Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Public Class FixedSizeStack

    Private Stack As ArrayList
    Private _Count As Integer
    Private _Size As Integer

    Public ReadOnly Property Count() As Integer
        Get
            Return _Count
        End Get
    End Property

    Public ReadOnly Property Size() As Integer
        Get
            Return _Size
        End Get
    End Property

    Public Sub New(ByVal Size As Integer)
        'If Size < 2 Then Throw New DevelopmentException("Stack must have size of at least 2")
        _Size = Size
        Stack = New ArrayList(Size)
    End Sub

    Public Function Pop() As Object
        Try
            If Count = 0 Then
                Return Nothing
            Else
                Dim Obj As Object = Stack(_Count - 1)
                Stack.RemoveAt(_Count - 1)
                _Count -= 1
                Return Obj
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Public Sub Push(ByVal Obj As Object)
        Try
            If _Count = _Size Then
                For n As Integer = 1 To _Size - 1
                    Stack(n - 1) = Stack(n)
                Next
                Stack.RemoveAt(_Size - 1)
            End If

            If _Count < _Size Then _Count += 1
            Stack.Add(Obj)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
