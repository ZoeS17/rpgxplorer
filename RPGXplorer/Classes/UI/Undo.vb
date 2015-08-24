Option Explicit On
Option Strict On

Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml

Public Class Undo

    'this class is responsible for managing undo

#Region "Member Variables"

    Private UndoRecords As FixedSizeStack

    Private AtomicActionInProgress As Boolean = False
    Private ActionStarted As Boolean = False

#End Region

#Region "Properties"

    'undo steps cached
    Public ReadOnly Property UndoStepsCached() As Integer
        Get
            Return UndoRecords.Count
        End Get
    End Property

#End Region

    'constructor
    Public Sub New(ByVal Size As Integer)
        UndoRecords = New FixedSizeStack(Size)
    End Sub

    'make a new undo stack
    Public Sub NewUndoStack(ByVal size As Integer)
        UndoRecords = New FixedSizeStack(size)
    End Sub

    'record an undo step
    Public Sub UndoRecord()
        Try
            If General.UndoSteps > 0 Then

                'check for atomic actions
                If AtomicActionInProgress Then
                    If ActionStarted Then
                        Exit Sub
                    Else
                        ActionStarted = True
                    End If
                End If

                Dim UndoData As New ArrayList(XML.DBTypes.Count)

                For n As Integer = 1 To XML.DBTypes.Count
                    UndoData.Add(XML.DBx(n).Clone)
                Next

                UndoRecords.Push(UndoData)

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'for starting and ending atomic actions which we only want to save one undo step for.
#Region "Atomic Actions"

    ''' <summary>
    ''' must be called BEFORE the action starts
    ''' </summary>    
    Public Sub BeginAtomicAction()
        AtomicActionInProgress = True
        ActionStarted = False
    End Sub

    Public Sub EndAtomicAction()
        AtomicActionInProgress = False
    End Sub

#End Region

    Public Sub UndoRecordCancel()
        UndoRecords.Pop()
    End Sub

    Public Sub Undo()
        Try
            If UndoRecords.Count = 0 Then Exit Sub

            XML.Lock = True

            General.SetWaitCursor()

            Dim UndoData As ArrayList = DirectCast(UndoRecords.Pop, ArrayList)
            Dim i As Integer

            For i = 0 To XML.DBTypes.Count - 1
                XML.DBx(i) = DirectCast(UndoData(i), XmlDocument)
            Next

            XML.LoadDatabaseIndex()
            XML.RebuildFKLookup()

            'refresh
            General.Config.Load(General.Config.ObjectGUID)
            General.MDITabs.Load(General.MDITabs.ObjectGUID)
            CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
            WindowManager.SetAllDirty()
            Caches.SetAllDirty()

            UserLists.Load()
            UserLists.UpdateLists(False)
            General.LoadConfig()
            ToolbarsAndMenus.InitConfig()

            General.MainExplorer.Refresh()
            General.SetNormalCursor()

            XML.Lock = False
        Catch ex As Exception
            XML.Lock = False
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
