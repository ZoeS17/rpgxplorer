Option Explicit On 
Option Strict On

Imports RPGXplorer.Rules.Constants
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML

Imports System.Xml
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace Rules

    Public Class AbilityScores

        Public Shared Abilities As String()
        'Private Shared AbilityScoreData As AbilityScoreDataItem()
        Private Shared AbilityScoreData As New ObservableCollection(Of AbilityScoreDataItem)

        'structure to hold ability score data item
        Public Structure AbilityScoreDataItem
            Public AbilityScore As Integer
            Public Modifier As Int16
            Public BonusLevel1Spells As Byte
            Public BonusLevel2Spells As Byte
            Public BonusLevel3Spells As Byte
            Public BonusLevel4Spells As Byte
            Public BonusLevel5Spells As Byte
            Public BonusLevel6Spells As Byte
            Public BonusLevel7Spells As Byte
            Public BonusLevel8Spells As Byte
            Public BonusLevel9Spells As Byte

            Public BonusSpellPointsMaxLevel1 As Integer
            Public BonusSpellPointsMaxLevel2 As Integer
            Public BonusSpellPointsMaxLevel3 As Integer
            Public BonusSpellPointsMaxLevel4 As Integer
            Public BonusSpellPointsMaxLevel5 As Integer
            Public BonusSpellPointsMaxLevel6 As Integer
            Public BonusSpellPointsMaxLevel7 As Integer
            Public BonusSpellPointsMaxLevel8 As Integer
            Public BonusSpellPointsMaxLevel9 As Integer

            Public PointCost As Integer

            Public Function BonusSpells(ByVal Level As Integer) As Integer
                Select Case Level
                    Case 1
                        Return Me.BonusLevel1Spells
                    Case 2
                        Return Me.BonusLevel2Spells
                    Case 3
                        Return Me.BonusLevel3Spells
                    Case 4
                        Return Me.BonusLevel4Spells
                    Case 5
                        Return Me.BonusLevel5Spells
                    Case 6
                        Return Me.BonusLevel6Spells
                    Case 7
                        Return Me.BonusLevel7Spells
                    Case 8
                        Return Me.BonusLevel8Spells
                    Case 9
                        Return Me.BonusLevel9Spells
                End Select
            End Function

            Public Function BonusSpellPoints(ByVal MaxSpellLevel As Integer) As Integer
                Select Case MaxSpellLevel
                    Case 0
                        Return 0
                    Case 1
                        Return Me.BonusSpellPointsMaxLevel1
                    Case 2
                        Return Me.BonusSpellPointsMaxLevel2
                    Case 3
                        Return Me.BonusSpellPointsMaxLevel3
                    Case 4
                        Return Me.BonusSpellPointsMaxLevel4
                    Case 5
                        Return Me.BonusSpellPointsMaxLevel5
                    Case 6
                        Return Me.BonusSpellPointsMaxLevel6
                    Case 7
                        Return Me.BonusSpellPointsMaxLevel7
                    Case 8
                        Return Me.BonusSpellPointsMaxLevel8
                    Case 9
                        Return Me.BonusSpellPointsMaxLevel9
                End Select
            End Function

        End Structure

        'method to get data for a given ability score
        Public Shared Function AbilityScore(ByVal Score As Integer) As AbilityScoreDataItem
            If Score > MaxAbilityScore Then

                'Return AbilityScoreData(MaxAbilityScore + 1)

                Dim AbScore As AbilityScoreDataItem
                AbScore.AbilityScore = Score
                AbScore.BonusLevel1Spells = CByte((Score - 4) \ 8)
                AbScore.BonusLevel2Spells = CByte((Score - 6) \ 8)
                AbScore.BonusLevel3Spells = CByte((Score - 8) \ 8)
                AbScore.BonusLevel4Spells = CByte((Score - 10) \ 8)
                AbScore.BonusLevel5Spells = CByte((Score - 12) \ 8)
                AbScore.BonusLevel6Spells = CByte((Score - 14) \ 8)
                AbScore.BonusLevel7Spells = CByte((Score - 16) \ 8)
                AbScore.BonusLevel8Spells = CByte((Score - 18) \ 8)
                AbScore.BonusLevel9Spells = CByte((Score - 20) \ 8)

                AbScore.BonusSpellPointsMaxLevel1 = 5
                AbScore.BonusSpellPointsMaxLevel2 = 20
                AbScore.BonusSpellPointsMaxLevel3 = 45
                AbScore.BonusSpellPointsMaxLevel4 = 80
                AbScore.BonusSpellPointsMaxLevel5 = 116
                AbScore.BonusSpellPointsMaxLevel6 = 160
                AbScore.BonusSpellPointsMaxLevel7 = 212
                AbScore.BonusSpellPointsMaxLevel8 = 272
                AbScore.BonusSpellPointsMaxLevel9 = 323

                AbScore.Modifier = CByte((Score - 10) \ 2)
                AbScore.PointCost = 0

                Return AbScore

            End If

            Return AbilityScoreData(Score + 1)

        End Function

        'load the ability score data
        Public Shared Sub LoadAbilityScoreData()
            Dim XmlRdr As XmlTextReader
            Dim Item As AbilityScoreDataItem

            Try
                ReDim Abilities(5)
                Abilities(0) = "STR"
                Abilities(1) = "DEX"
                Abilities(2) = "CON"
                Abilities(3) = "INT"
                Abilities(4) = "WIS"
                Abilities(5) = "CHA"

                AbilityScoreData.Clear()

                XmlRdr = GetXMLTextReader(General.BasePath & "XML\AbilityScores.xml")

                While XmlRdr.Read
                    Select Case XmlRdr.NodeType
                        Case XmlNodeType.Element
                            Select Case XmlRdr.Name
                                Case "RPGXplorerConfig", "AbilityScoreDataItem"
                                    'do nothing
                                Case "AbilityScore"
                                    Item.AbilityScore = CType(XmlRdr.ReadString, Integer)
                                Case "Modifier"
                                    Item.Modifier = CType(XmlRdr.ReadString, Int16)

                                Case "BonusLevel1Spells"
                                    Item.BonusLevel1Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel2Spells"
                                    Item.BonusLevel2Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel3Spells"
                                    Item.BonusLevel3Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel4Spells"
                                    Item.BonusLevel4Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel5Spells"
                                    Item.BonusLevel5Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel6Spells"
                                    Item.BonusLevel6Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel7Spells"
                                    Item.BonusLevel7Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel8Spells"
                                    Item.BonusLevel8Spells = CType(XmlRdr.ReadString, Byte)
                                Case "BonusLevel9Spells"
                                    Item.BonusLevel9Spells = CType(XmlRdr.ReadString, Byte)

                                Case "BonusLevel1SpellPoints"
                                    Item.BonusSpellPointsMaxLevel1 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel2SpellPoints"
                                    Item.BonusSpellPointsMaxLevel2 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel3SpellPoints"
                                    Item.BonusSpellPointsMaxLevel3 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel4SpellPoints"
                                    Item.BonusSpellPointsMaxLevel4 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel5SpellPoints"
                                    Item.BonusSpellPointsMaxLevel5 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel6SpellPoints"
                                    Item.BonusSpellPointsMaxLevel6 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel7SpellPoints"
                                    Item.BonusSpellPointsMaxLevel7 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel8SpellPoints"
                                    Item.BonusSpellPointsMaxLevel8 = CType(XmlRdr.ReadString, Integer)
                                Case "BonusLevel9SpellPoints"
                                    Item.BonusSpellPointsMaxLevel9 = CType(XmlRdr.ReadString, Integer)

                                Case "PointCost"
                                    Item.PointCost = CType(XmlRdr.ReadString, Integer)

                                Case Else
                                    Throw New Exceptions.XMLSchemaException("Unexpected element in the ability scores xml file")
                            End Select
                        Case XmlNodeType.EndElement
                            If XmlRdr.Name = "AbilityScoreDataItem" Then AbilityScoreData.Add(Item)
                    End Select
                End While

                MaxAbilityScore = CByte(AbilityScoreData.Count - 2)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace

