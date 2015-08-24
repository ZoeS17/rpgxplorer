Option Explicit On 
Option Strict On

Imports System.Text

Public Class Exceptions

    'exception - something in the code needs brought up to date
    Public Class DevelopmentException
        Inherits System.ApplicationException

        Public Sub New(ByVal SpecificCause As String)
            MyBase.New(SpecificCause)
        End Sub
    End Class

    'exception - image lists do not contain the same number of icons
    Public Class ImageListLoadException
        Inherits System.ApplicationException
    End Class

    'exception - object not found in db
    Public Class ObjectDataNotFoundException
        Inherits System.ApplicationException
    End Class

    'exception - object referential constraint
    Public Class ObjectReferentialConstraintException
        Inherits System.ApplicationException
    End Class

    'exception - object element not found
    Public Class ObjectElementNotFoundException
        Inherits System.ApplicationException
    End Class

    'exception - object attribue not found
    Public Class ObjectAttributeNotFoundException
        Inherits System.ApplicationException
    End Class

    'exception - something has violated the rules (either d20 or d20 explorer)
    Public Class RulesException
        Inherits System.ApplicationException

        Public Sub New(ByVal RuleViolation As String)
            MyBase.New(RuleViolation)
        End Sub
    End Class

    'exception - the tree view has caused an exception
    Public Class TreeViewException
        Inherits System.ApplicationException

        Public Sub New(ByVal SpecificCause As String)
            MyBase.New(SpecificCause)
        End Sub
    End Class

    'exception - something has violated the xml schema
    Public Class XMLSchemaException
        Inherits System.ApplicationException

        Public Sub New(ByVal Description As String)
            MyBase.New(Description)
        End Sub
    End Class

    'exception handler
    Public Shared Sub HandleException(ByVal ex As Exception)
        If Not General.MainExplorer Is Nothing Then General.SetNormalCursor()

        XML.Lock = True
        XML.SaveRestoreDB()

        If TypeOf ex Is RulesException Then
            General.ShowInfoDialog("Rules Exception")
        ElseIf TypeOf ex Is ObjectReferentialConstraintException Then
            General.ShowInfoDialog("You cannot delete this component because another component is using it.")
        Else
            Dim ErrorDialog As New ErrorForm
            Dim Trace As New ArrayList

            While True
                Trace.Add(ex.TargetSite.DeclaringType.ToString & "->" & ex.TargetSite.ToString())
                If ex.InnerException IsNot Nothing Then ex = ex.InnerException Else Exit While
            End While

            Dim MessageBuilder As New StringBuilder
            Trace.Reverse()
            MessageBuilder.AppendLine("An Error has occured. Please report the following to customer.support@rpgxplorer.com: ")
            MessageBuilder.AppendLine()
            MessageBuilder.AppendLine(ex.Message)
            For Each Entry As String In Trace
                MessageBuilder.AppendLine(Entry)
            Next
            ErrorDialog.ErrorMessage = MessageBuilder.ToString
            ErrorDialog.ShowDialog()
        End If

        XML.Lock = False
    End Sub

    'exception non-fatal handler
    Public Shared Sub HandleNonFatalException(ByVal ex As Exception)
        General.SetNormalCursor()
        XML.Lock = True
        'General.ShowErrorDialog("An Error has occured. Please report the following to customer.support@rpgxplorer.com: " & ex.Message & " - " & ex.Source.ToString & " - " & ex.TargetSite.ToString)
        Dim ErrorDialog As New ErrorForm
        ErrorDialog.ErrorMessage = "An Error has occured. Please report the following to customer.support@rpgxplorer.com: " & ex.Message & " - " & ex.Source.ToString & " - " & ex.TargetSite.ToString
        ErrorDialog.ShowDialog()
        XML.Lock = False
    End Sub

End Class