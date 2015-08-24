Option Explicit On
Option Strict On

Imports System.Xml

Namespace Rules

    Public Class Encumberance

        'this class handles basis rules relating to movement

#Region "Structures"

        Public Structure CarryingCapacity
            Public STR As Integer
            Public MediumLoad As Double
            Public HeavyLoad As Double
            Public MaxLoad As Double

            Public Sub AdjustForSize(ByVal Size As String, ByVal Quadruped As Boolean)
                Dim Factor As Double

                If Quadruped Then
                    Factor = Rules.Size.Size(Size).QuadCarry
                Else
                    Factor = Rules.Size.Size(Size).Carry
                End If

                MediumLoad = Math.Round(MediumLoad * Factor)
                HeavyLoad = Math.Round(HeavyLoad * Factor)
                MaxLoad = Math.Round(MaxLoad * Factor)

            End Sub
        End Structure

        Public Structure CarryingLoad
            Public Load As String
            Public MaxDex As Integer
            Public CheckPenalty As Integer
            Public Speed20ft As Integer
            Public Speed30ft As Integer
            Public Speed40ft As Integer
            Public Speed50ft As Integer
            Public Run As Integer

            Public Function Speed(ByVal BaseSpeed As Integer) As Integer
                Select Case BaseSpeed
                    Case 20
                        Return Speed20ft
                    Case 30
                        Return Speed30ft
                    Case 40
                        Return Speed40ft
                    Case 50
                        Return Speed50ft
                End Select
            End Function

            Public Function RunAdjusted(ByVal BaseRun As Integer) As Integer
                If Run = 3 Then Return BaseRun - 1 Else Return BaseRun
            End Function

        End Structure

#End Region

#Region "Member Variables"

        Private Shared CarryingCapacities As New Hashtable(29)
        Private Shared CarryingLoads As New Hashtable(2)

#End Region

        'get the load for the given STR and weight carried
        Public Shared Function CurrentLoad(ByVal Size As String, ByVal STR As Integer, ByVal WeightCarried As Double, ByVal Quaruped As Boolean) As String
            Dim RefData As CarryingCapacity

            'STR nonability return 
            If STR = -1 Then Return "Light"

            'get loads
            RefData = GetLoads(STR)
            RefData.AdjustForSize(Size, Quaruped)

            If WeightCarried < RefData.MediumLoad Then
                Return "Light"
            ElseIf WeightCarried < RefData.HeavyLoad Then
                Return "Medium"
            ElseIf WeightCarried <= RefData.MaxLoad Then
                Return "Heavy"
            Else
                Return "Too Heavy"
            End If
        End Function

        'light
        Public Shared Function LightLoad(ByVal Size As String, ByVal STR As Integer, ByVal Quaruped As Boolean) As String
            Dim RefData As CarryingCapacity = GetLoads(STR)
            RefData.AdjustForSize(Size, Quaruped)
            Return "0 to " & Formatting.FormatPounds(RefData.MediumLoad - 1)
        End Function

        'medium
        Public Shared Function MediumLoad(ByVal Size As String, ByVal STR As Integer, ByVal Quaruped As Boolean) As String
            Dim RefData As CarryingCapacity = GetLoads(STR)
            RefData.AdjustForSize(Size, Quaruped)
            Return RefData.MediumLoad & " to " & Formatting.FormatPounds(RefData.HeavyLoad - 1)
        End Function

        'heavy
        Public Shared Function HeavyLoad(ByVal Size As String, ByVal STR As Integer, ByVal Quaruped As Boolean) As String
            Dim RefData As CarryingCapacity = GetLoads(STR)
            RefData.AdjustForSize(Size, Quaruped)
            Return RefData.HeavyLoad & " to " & Formatting.FormatPounds(RefData.MaxLoad)
        End Function

        'max
        Public Shared Function MaxLoad(ByVal Size As String, ByVal STR As Integer, ByVal Quaruped As Boolean) As String
            Dim RefData As CarryingCapacity = GetLoads(STR)
            RefData.AdjustForSize(Size, Quaruped)
            Return Formatting.FormatPounds(RefData.MaxLoad)
        End Function

        'get the effects of current load
        Public Shared Function LoadEffects(ByVal Load As String) As CarryingLoad
            Return DirectCast(CarryingLoads(Load), CarryingLoad)
        End Function

        'load
        Public Shared Sub Load()
            LoadCarryingCapacities()
            LoadCarryingLoads()
        End Sub

        'load the carrying capacities
        Private Shared Sub LoadCarryingCapacities()
            Dim XmlRdr As XmlTextReader
            Dim Item As CarryingCapacity

            XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\CarryingCapacities.xml")

            While XmlRdr.Read
                Select Case XmlRdr.NodeType
                    Case XmlNodeType.Element
                        Select Case XmlRdr.Name
                            Case "STR"
                                Item.STR = CType(XmlRdr.ReadString, Integer)
                            Case "Medium"
                                Item.MediumLoad = CType(XmlRdr.ReadString, Double)
                            Case "Heavy"
                                Item.HeavyLoad = CType(XmlRdr.ReadString, Double)
                            Case "Max"
                                Item.MaxLoad = CType(XmlRdr.ReadString, Double)
                        End Select
                    Case XmlNodeType.EndElement
                        If XmlRdr.Name = "CarryingCapacity" Then CarryingCapacities.Add(Item.STR, Item)
                End Select
            End While
        End Sub

        'load the carrying loads
        Private Shared Sub LoadCarryingLoads()
            Dim XmlRdr As XmlTextReader
            Dim Item As New CarryingLoad

            XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\CarryingLoads.xml")

            While XmlRdr.Read
                Select Case XmlRdr.NodeType
                    Case XmlNodeType.Element
                        Select Case XmlRdr.Name
                            Case "Load"
                                Item.Load = XmlRdr.ReadString
                            Case "CheckPenalty"
                                Item.CheckPenalty = CType(XmlRdr.ReadString, Integer)
                            Case "MaxDex"
                                Item.MaxDex = CType(XmlRdr.ReadString, Integer)
                            Case "Speed20ft"
                                Item.Speed20ft = CType(XmlRdr.ReadString, Integer)
                            Case "Speed30ft"
                                Item.Speed30ft = CType(XmlRdr.ReadString, Integer)
                            Case "Speed40ft"
                                Item.Speed40ft = CType(XmlRdr.ReadString, Integer)
                            Case "Speed50ft"
                                Item.Speed50ft = CType(XmlRdr.ReadString, Integer)
                            Case "Run"
                                Item.Run = CType(XmlRdr.ReadString, Integer)
                        End Select
                    Case XmlNodeType.EndElement
                        If XmlRdr.Name = "CarryingLoad" Then CarryingLoads.Add(Item.Load, Item)
                End Select
            End While
        End Sub

        Private Shared Function GetLoads(ByVal STR As Integer) As CarryingCapacity
            Dim RefData As CarryingCapacity

            If STR > (CarryingCapacities.Count - 2) Then
                Dim Base As Integer
                Dim Factor As Integer
                Try

                    Base = (STR Mod 10) + 20
                    Factor = CInt(4 ^ ((STR \ 10) - 2))
                    RefData = DirectCast(CarryingCapacities.Item(Base), CarryingCapacity)
                    RefData.HeavyLoad = (RefData.HeavyLoad * Factor) - 2
                    RefData.MaxLoad = RefData.MaxLoad * Factor
                    RefData.MediumLoad = (RefData.MediumLoad * Factor) - 2

                Catch ex As Exception
                    RefData = DirectCast(CarryingCapacities.Item(CarryingCapacities.Count), CarryingCapacity)
                End Try
            Else
                RefData = DirectCast(CarryingCapacities.Item(STR), CarryingCapacity)
            End If

            Return RefData

        End Function

    End Class

End Namespace
