Option Explicit On
Option Strict On

Imports RPGXplorer.Rules

Public Class Templates

    Public Shared Templates As New Hashtable

    'load template dlls
    Public Shared Sub LoadTemplates()
        Try
            'get all the dlls in the template directory
            Dim DllFiles As String() = System.IO.Directory.GetFiles(General.BasePath & "Templates\", "*.dll")

            For Each file As String In DllFiles
                Dim TemplateAssembly As System.Reflection.Assembly
                Try
                    TemplateAssembly = System.Reflection.Assembly.LoadFrom(file)

                    'need to make sure this is a template assembly
                    Dim OutputString As String = ""
                    Dim TemplateTypes As Type() = TemplateAssembly.GetTypes()
                    For Each TempType As Type In TemplateTypes
                        If TempType.IsClass Then
                            If Not TempType.GetInterface("RPGXplorer.ITemplate") Is Nothing Then
                                Dim Constructor As System.Reflection.ConstructorInfo = TempType.GetConstructor(Type.EmptyTypes)
                                If Constructor IsNot Nothing Then
                                    Dim TempTemplate As ITemplate = CType(Constructor.Invoke(Nothing), ITemplate)
                                    Templates.Item(TempTemplate.TemplateGuid) = TempTemplate
                                End If
                            End If
                        End If
                    Next

                Catch ex As FieldAccessException
                    'couldnt load an assembly
                End Try
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
