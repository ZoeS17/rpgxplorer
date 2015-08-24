Option Explicit On 
Option Strict On

Imports RPGXplorer.Rules.Constants
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Imports System.Xml

Namespace Rules

    Public Class Size

        Private Shared Sizes As New Hashtable(9)

        'structure to hold size data item
        Public Structure SizeDataItem
            Public Size As String
            Public Modifier As Integer
            Public Grapple As Integer
            Public Carry As Double

            'new stuff - 1.9
            Public QuadCarry As Double

            Public ItemCostModifier As Double
            Public ItemWeightModifier As Double

        End Structure

        'method to get data for a given size
        Public Shared Function Size(ByVal CharacterSize As String) As SizeDataItem
            Return CType(Sizes(CharacterSize), SizeDataItem)
        End Function

        'load the ability score data
        Public Shared Sub LoadData()
            Dim XmlRdr As XmlTextReader
            Dim Item As New SizeDataItem

            Try
                XmlRdr = GetXMLTextReader(General.BasePath & "XML\SizeModifiers.xml")

                While XmlRdr.Read
                    Select Case XmlRdr.NodeType
                        Case XmlNodeType.Element
                            Select Case XmlRdr.Name
                                Case "RPGXplorerConfig", "SizeData"
                                    'do nothing
                                Case "Size"
                                    Item.Size = XmlRdr.ReadString
                                Case "Modifier"
                                    Item.Modifier = CType(XmlRdr.ReadString, Integer)
                                Case "Grapple"
                                    Item.Grapple = CType(XmlRdr.ReadString, Integer)
                                Case "Carry"
                                    Item.Carry = CType(XmlRdr.ReadString, Double)
                                Case "QuadCarry"
                                    Item.QuadCarry = CType(XmlRdr.ReadString, Double)
                                Case "ItemCostModifier"
                                    Item.ItemCostModifier = CType(XmlRdr.ReadString, Double)
                                Case "ItemWeightModifier"
                                    Item.ItemWeightModifier = CType(XmlRdr.ReadString, Double)
                                Case Else
                                    Throw New Exceptions.XMLSchemaException("Unexpected element in the size modifiers xml file")
                            End Select
                        Case XmlNodeType.EndElement
                            If XmlRdr.Name = "SizeData" Then Sizes.Add(Item.Size, Item)
                    End Select
                End While

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace

