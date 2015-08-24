Option Explicit On 
Option Strict On

Public Class Sound

    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name _
       As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
    ' name specifies the sound file when the SND_FILENAME flag is set.
    ' hmod specifies an executable file handle.
    ' hmod must be Nothing if the SND_RESOURCE flag is not set.
    ' flags specifies which flags are set. 

    ' The PlaySound documentation lists all valid flags.
    Private Const SND_ASYNC As Integer = &H1        ' play asynchronously
    Private Const SND_FILENAME As Integer = &H20000 ' name is file name

    ' Plays a sound from filename.
    Public Shared Sub PlaySoundFile(ByVal filename As String)
        Try
            PlaySound(filename, Nothing, SND_FILENAME Or SND_ASYNC)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
