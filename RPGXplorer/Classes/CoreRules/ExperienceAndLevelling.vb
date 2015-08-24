Option Explicit On
Option Strict On

Imports RPGXplorer.Rules.Constants
Imports RPGXplorer.Exceptions
Imports RPGXplorer.XML
Imports System.Xml

Namespace Rules

    Public Class ExperienceAndLevelling

        Private Shared _LevelDependentBenefits(MaxLevels) As LevelDependentBenefitsDataItem

        'structure to hold data about each character level
        Public Structure LevelDependentBenefitsDataItem
            Public CharacterLevel As Integer
            Public XP As Int32
            Public ClassSkillMaxRanks As Integer
            Public CrossClassSkillMaxRanks As Single
            Public Feat As Boolean
            Public AbilityIncrease As Boolean
        End Structure

        'property to access level dependent benefits
        Public Shared ReadOnly Property LevelDependentBenefits(ByVal Level As Integer) As LevelDependentBenefitsDataItem
            Get
                Return _LevelDependentBenefits(Level - 1)
            End Get
        End Property

        'load the experience levels data
        Public Shared Sub LoadExperienceLevelsData()
            Dim XmlRdr As XmlTextReader
            Dim Item As LevelDependentBenefitsDataItem

            Try
                XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\ExperienceLevels.xml")

                While XmlRdr.Read
                    Select Case XmlRdr.NodeType
                        Case XmlNodeType.Element
                            Select Case XmlRdr.Name
                                Case "RPGXplorerConfig", "ExperienceLevel"
                                    'do nothing
                                Case "CharacterLevel"
                                    Item.CharacterLevel = CInt(XmlRdr.ReadString)
                                Case "XP"
                                    Item.XP = CInt(XmlRdr.ReadString)
                                Case "ClassSkillMaxRanks"
                                    Item.ClassSkillMaxRanks = CInt(XmlRdr.ReadString)
                                Case "CrossClassSkillMaxRanks"
                                    Item.CrossClassSkillMaxRanks = CType(XmlRdr.ReadString, Single)
                                Case "Feat"
                                    Item.Feat = CBool(XmlRdr.ReadString)
                                Case "AbilityIncrease"
                                    Item.AbilityIncrease = CBool(XmlRdr.ReadString)
                                Case Else
                                    Throw New Exceptions.XMLSchemaException("Unexpected element in the experience levels xml file")
                            End Select
                        Case XmlNodeType.EndElement
                            If XmlRdr.Name = "ExperienceLevel" Then _LevelDependentBenefits(Item.CharacterLevel - 1) = Item
                    End Select
                End While

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'get the levels at which this character will gain an ability point (not inc. existing levels) when adding levels
        Public Shared Function AbilityPointLevels(ByVal Character As Rules.Character, ByVal LevelsToAdd As Integer) As ArrayList

            Dim n, StartLevel As Integer

            Try
                AbilityPointLevels = New ArrayList

                StartLevel = Character.FirstNewLevel

                For n = StartLevel To (StartLevel + LevelsToAdd) - 1
                    If LevelDependentBenefits(n).AbilityIncrease Then
                        AbilityPointLevels.Add(n)
                    End If
                Next

                Return AbilityPointLevels

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the levels at which this character will gain an ability point (not inc. existing levels) when adding levels
        Public Shared Function AbilityPointLevels(ByVal StartLevel As Integer, ByVal HitDiceAdded As Integer) As ArrayList

            Dim n As Integer

            Try
                AbilityPointLevels = New ArrayList

                For n = (StartLevel + 1) To (StartLevel + HitDiceAdded)
                    If LevelDependentBenefits(n).AbilityIncrease Then
                        AbilityPointLevels.Add(n)
                    End If
                Next

                Return AbilityPointLevels

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
