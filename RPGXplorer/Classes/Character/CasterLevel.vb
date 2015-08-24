Option Explicit On
Option Strict On

Namespace Rules

    Public Class CasterLevel

        'convert a caster type and class level into its caster level
        Public Shared Function CasterLevel(ByVal CasterEqual As String, ByVal ClassLevel As Integer) As Integer
            Try
                Select Case CasterEqual
                    Case "True"
                        Return ClassLevel
                    Case "False"
                        Return CInt(Math.Floor(ClassLevel / 2))
                    Case Else
                        Return 0
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'convert a manifester type and class level into its manifester level
        Public Shared Function ManifesterLevel(ByVal CasterEqual As String, ByVal ClassLevel As Integer) As Integer
            Try
                Select Case CasterEqual
                    Case "True"
                        Return ClassLevel
                    Case "False"
                        Return Math.Max(ClassLevel - 4, 0)
                    Case Else
                        Return 0
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'used to create the caster level structure for use within a character
        Public Shared Function GetCasterLevel(ByVal Character As Rules.Character, ByVal Level As Rules.Character.Level) As Rules.Character.CasterLevel()

            Dim CasterLevel As New Rules.Character.CasterLevel
            Dim ClassObject As New Objects.ObjectData
            Dim PrestigeClassOffset As Integer
            Dim RacialCasterOffset As Integer

            ReDim GetCasterLevel(-1)
            ClassObject.Load(Level.ClassGuid)
            PrestigeClassOffset = 0
            RacialCasterOffset = 0

            Select Case ClassObject.Element("CasterAbility")

                Case "No"
                    ReDim GetCasterLevel(0)
                    CasterLevel.ClassGuid = Level.ClassGuid
                    CasterLevel.ClassName = Level.ClassName
                    CasterLevel.CasterLevel = 0
                    CasterLevel.Type = Character.CasterLevel.CasterType.None
                    GetCasterLevel.SetValue(CasterLevel, 0)
                    Return GetCasterLevel

                Case "Yes", "Psionic"
                    'Workout the Prestige Offset
                    Dim ClassChoices As ArrayList
                    Dim Choice As Rules.Character.CharacterChoice
                    ClassChoices = Character.PrestigeSpellcasterChoices.ItemData(ClassObject.ObjectGUID)

                    For Each TempData As Library.LibraryData In ClassChoices
                        Choice = DirectCast(TempData.Data, Rules.Character.CharacterChoice)
                        If Choice.Type = Character.ChoiceType.SpellcasterChoice Then
                            If TempData.LevelAcquired < Level.CharacterLevel Then PrestigeClassOffset += 1
                        End If
                    Next

                    'get the racial offset
                    RacialCasterOffset = Character.GetRacialCasterOffset(ClassObject.ObjectGUID)

                    ReDim GetCasterLevel(0)
                    CasterLevel.ClassGuid = Level.ClassGuid
                    CasterLevel.ClassName = Level.ClassName

                    Select Case ClassObject.Element("CasterAbility")
                        Case "Yes"
                            Select Case ClassObject.Element("CasterEqual")
                                Case "True"
                                    CasterLevel.CasterLevel = Level.ClassLevel + PrestigeClassOffset + RacialCasterOffset

                                Case "False"
                                    CasterLevel.CasterLevel = CInt(Math.Floor((Level.ClassLevel + PrestigeClassOffset + RacialCasterOffset) / 2))
                            End Select
                            CasterLevel.Type = Character.CasterLevel.CasterType.Spellcaster

                        Case "Psionic"
                            Select Case ClassObject.Element("ManifesterEqual")
                                Case "True"
                                    CasterLevel.CasterLevel = Level.ClassLevel + PrestigeClassOffset + RacialCasterOffset
                                Case "False"
                                    CasterLevel.CasterLevel = Math.Max((Level.ClassLevel - 4) + PrestigeClassOffset + RacialCasterOffset, 0)
                            End Select
                            CasterLevel.Type = Character.CasterLevel.CasterType.Manifester
                    End Select

                    GetCasterLevel.SetValue(CasterLevel, 0)
                    Return GetCasterLevel

                Case "Prestige Advancement"
                    Dim Choice As Character.CharacterChoice
                    Dim CurrentIndex As Integer = 0
                    Dim ClassLevel As Integer

                    'get the racial offset
                    RacialCasterOffset = Character.GetRacialCasterOffset(ClassObject.ObjectGUID)

                    For Each ItemData As Library.LibraryData In Character.PrestigeSpellcasterChoices.ItemData()
                        Choice = DirectCast(ItemData.Data, Rules.Character.CharacterChoice)
                        PrestigeClassOffset = 0
                        ClassLevel = 0

                        If Choice.LevelAcquired = Level.CharacterLevel Then

                            'Workout the Prestige Spellcaster offset
                            Dim ClassChoices As ArrayList
                            Dim TempChoice As Rules.Character.CharacterChoice
                            ClassChoices = Character.PrestigeSpellcasterChoices.ItemData(Choice.DataGuid)

                            For Each TempData As Library.LibraryData In ClassChoices
                                TempChoice = DirectCast(TempData.Data, Rules.Character.CharacterChoice)
                                If TempChoice.Type = Character.ChoiceType.SpellcasterChoice Then
                                    If TempData.LevelAcquired < Level.CharacterLevel Then PrestigeClassOffset += 1
                                End If
                            Next

                            'Workout the number of class levels
                            ClassLevel = Character.HighestClasslevel(Choice.DataGuid)

                            'Get the Caster Type
                            Dim TargetClass As New Objects.ObjectData
                            TargetClass.Load(Choice.DataGuid)

                            ReDim Preserve GetCasterLevel(CurrentIndex)

                            CasterLevel.ClassGuid = TargetClass.ObjectGUID
                            CasterLevel.ClassName = TargetClass.Name

                            Select Case TargetClass.Element("CasterAbility")
                                Case "Yes"
                                    Select Case TargetClass.Element("CasterEqual")
                                        Case "True"
                                            CasterLevel.CasterLevel = ClassLevel + RacialCasterOffset + PrestigeClassOffset + 1

                                        Case "False"
                                            CasterLevel.CasterLevel = CInt(Math.Floor((ClassLevel + RacialCasterOffset + PrestigeClassOffset + 1) / 2))
                                    End Select
                                    CasterLevel.Type = Character.CasterLevel.CasterType.Spellcaster

                                Case "Psionic"
                                    Select Case TargetClass.Element("ManifesterEqual")
                                        Case "True"
                                            CasterLevel.CasterLevel = ClassLevel + RacialCasterOffset + PrestigeClassOffset + 1
                                        Case "False"
                                            CasterLevel.CasterLevel = Math.Max((Level.ClassLevel - 4) + RacialCasterOffset + PrestigeClassOffset + 1, 0)
                                    End Select
                                    CasterLevel.Type = Character.CasterLevel.CasterType.Manifester
                            End Select

                            'Select Case TargetClass.Element("CasterEqual")
                            '    Case "True"
                            '        CasterLevel.CasterLevel = ClassLevel + PrestigeClassOffset + 1
                            '        GetCasterLevel.SetValue(CasterLevel, CurrentIndex)

                            '    Case "False"
                            '        CasterLevel.CasterLevel = CInt(Math.Floor((ClassLevel + PrestigeClassOffset + 1) / 2))
                            '        GetCasterLevel.SetValue(CasterLevel, CurrentIndex)
                            'End Select

                            GetCasterLevel.SetValue(CasterLevel, CurrentIndex)
                            CurrentIndex += 1

                        End If
                    Next

                    Return GetCasterLevel

            End Select

        End Function

        'used to create the first caster level structure for use within a character which is a racial caster
        Public Shared Function GetRacialCasterLevel(ByVal Character As Rules.Character, ByVal ClassKey As Objects.ObjectKey) As Rules.Character.CasterLevel()

            Dim CasterLevel As New Rules.Character.CasterLevel
            Dim ClassObject As New Objects.ObjectData
            Dim RacialCasterOffset As Integer
            ReDim GetRacialCasterLevel(-1)

            ClassObject.Load(ClassKey)
            RacialCasterOffset = 0

            Select Case ClassObject.Element("CasterAbility")

                Case "Yes", "Psionic"
                    'get the racial offset
                    RacialCasterOffset = Character.GetRacialCasterOffset(ClassObject.ObjectGUID)

                    ReDim GetRacialCasterLevel(0)
                    CasterLevel.ClassGuid = ClassKey
                    CasterLevel.ClassName = ClassObject.Name

                    Select Case ClassObject.Element("CasterAbility")
                        Case "Yes"
                            Select Case ClassObject.Element("CasterEqual")
                                Case "True"
                                    CasterLevel.CasterLevel = RacialCasterOffset

                                Case "False"
                                    CasterLevel.CasterLevel = CInt(Math.Floor((RacialCasterOffset) / 2))
                            End Select
                            CasterLevel.Type = Character.CasterLevel.CasterType.Spellcaster

                        Case "Psionic"
                            Select Case ClassObject.Element("ManifesterEqual")
                                Case "True"
                                    CasterLevel.CasterLevel = RacialCasterOffset
                                Case "False"
                                    CasterLevel.CasterLevel = Math.Max(RacialCasterOffset - 4, 0)
                            End Select
                            CasterLevel.Type = Character.CasterLevel.CasterType.Manifester
                    End Select

                    GetRacialCasterLevel.SetValue(CasterLevel, 0)
                    Return GetRacialCasterLevel

            End Select

        End Function

        'get the lowest level at which this spell can be cast by this class, assumes bonus spells for ability
        Public Shared Function MinimumCasterLevelForSpell(ByVal SpellLevel As Integer, ByVal CasterClass As Objects.ObjectData) As Integer
            Try
                Dim MinLevel As Integer = 999

                'find the lowest level
                For Each SPD As Objects.ObjectData In CasterClass.FirstChildOfType(Objects.ClassLevelsSpellsPerDayFolderType).Children
                    If SPD.Element("Level" & SpellLevel.ToString & "Spells") <> "" Then
                        If SPD.ElementAsInteger("Level") < MinLevel Then
                            MinLevel = SPD.ElementAsInteger("Level")
                        End If
                    End If
                Next

                Return CasterLevel(CasterClass.Element("CasterEqual"), MinLevel)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function


        'get the lowest level at which this power can be manifestred by this class
        Public Shared Function MinimumManifesterLevelForPower(ByVal PowerLevel As Integer, ByVal ManifesterClass As Objects.ObjectData) As Integer
            Try
                Dim MinLevel As Integer = 999

                'find the lowest level
                For Each PowerProgression As Objects.ObjectData In ManifesterClass.FirstChildOfType(Objects.ClassLevelsPowerProgressionFolderType).Children
                    If Sorter.StripLeftNumbers(PowerProgression.Element("MaxPowerLevel")) >= PowerLevel Then
                        If PowerProgression.ElementAsInteger("Level") < MinLevel Then
                            MinLevel = PowerProgression.ElementAsInteger("Level")
                        End If
                    End If
                Next

                Return ManifesterLevel(ManifesterClass.Element("ManifesterEqual"), MinLevel)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

End Namespace
