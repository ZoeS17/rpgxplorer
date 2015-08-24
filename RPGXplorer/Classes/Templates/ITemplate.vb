Option Explicit On
Option Strict On

Imports RPGXplorer.Rules

Public Interface ITemplate

    ReadOnly Property TemplateName() As String

    ReadOnly Property TemplateGuid() As Guid

    Function ApplyTemplate(ByVal Character As Character) As Boolean

    Function CanAquire(ByVal Character As Character) As Boolean

End Interface
