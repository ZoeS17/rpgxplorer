Option Explicit On 
Option Strict On

Namespace Rules

    Public Class PowerPoints

#Region "Member Variables"

        Public Character As Character
        Public ClassKey As Objects.ObjectKey

        Public ClassPowerPoints As Integer
        Public AblityScorePowerPoints As Integer
        Public PowerPointsModifer As Integer
        Public UserPowerPointsModifier As Integer

        Public PowersKnown As Integer
        Public ActualPowersKnown As Integer

        Public PsionicFolder As Objects.ObjectData

#End Region

#Region "Properties"

        Public ReadOnly Property PowerPoints() As Integer
            Get
                Return ClassPowerPoints + AblityScorePowerPoints + PowerPointsModifer + UserPowerPointsModifier
            End Get
        End Property

        Public ReadOnly Property NonUserPowerPoints() As Integer
            Get
                Return ClassPowerPoints + AblityScorePowerPoints + PowerPointsModifer
            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Character, ByVal ClassKey As Objects.ObjectKey)
            'set the character
            Me.Character = Character
            Me.ClassKey = ClassKey

            'load the power point vaules
            Dim ClassKeys As ArrayList = Character.CharacterClassKeys

            'check for any racial manifester class
            If Character.RaceObject.Element("CasterType") = "Psionic" Then
                Dim RacialClassKey As Objects.ObjectKey
                RacialClassKey = Character.RaceObject.GetFKGuid("CasterSource")
                If RacialClassKey.IsNotEmpty AndAlso (Not (ClassKeys.Contains(RacialClassKey))) Then
                    ClassKeys.Add(RacialClassKey)
                End If
            End If

            For Each TempClassKey As Objects.ObjectKey In ClassKeys
                Dim ClassInfo As CharacterClass
                ClassInfo = Character.CharacterClasses(TempClassKey)

                If ClassInfo.IsPsionic Then
                    ClassPowerPoints += ClassInfo.PowerPoints(Character.HighestEffectiveClasslevel(TempClassKey))
                    If ClassInfo.CasterInfo.BonusPowerPoints = True Then
                        AblityScorePowerPoints += BonusPowerPoints(Character.Powers.GetPowerAbilityScore(ClassInfo, Character.CharacterLevel), Character.HighestEffectiveClasslevel(TempClassKey))
                    End If
                End If
            Next

            'get any modifiers to power points
            PowerPointsModifer = Character.Modifiers.PowerPoints

            'get the user modifer to power points - modifer stored on the psionic folder
            PsionicFolder = Character.PsionicFolder
            If Not PsionicFolder.IsEmpty Then
                UserPowerPointsModifier = PsionicFolder.ElementAsInteger("PowerPointsModifier")
            End If

            'get powers known
            PowersKnown = Character.CharacterClasses(ClassKey).PsionicPowersKnown(Character.HighestEffectiveClasslevel(ClassKey))

            'get actual powers knwon
            Dim Found As Boolean = False
            Dim PowerFolder As Objects.ObjectData

            For Each PowerFolder In Character.PsionicFolder.ChildrenOfType(Objects.ClassPowerListFolderType)
                If PowerFolder.GetFKGuid("Class").Equals(ClassKey) Then
                    ActualPowersKnown = PowerFolder.Children.Count
                    Exit For
                End If
            Next
        End Sub

        'constructor - just for getting the power points
        Public Sub New(ByVal Character As Character)
            'set the character
            Me.Character = Character

            'load the power point vaules
            For Each TempClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim ClassInfo As CharacterClass
                ClassInfo = Character.CharacterClasses(TempClassKey)

                If ClassInfo.IsPsionic Then
                    ClassPowerPoints += ClassInfo.PowerPoints(Character.HighestEffectiveClasslevel(TempClassKey))
                    If ClassInfo.CasterInfo.BonusPowerPoints = True Then
                        AblityScorePowerPoints += BonusPowerPoints(Character.Powers.GetPowerAbilityScore(ClassInfo, Character.CharacterLevel), Character.HighestEffectiveClasslevel(TempClassKey))
                    End If
                End If
            Next

            'get any modifiers to power points
            PowerPointsModifer = Character.Modifiers.PowerPoints

            'get the user modifer to power points - modifer stored on the psionic folder
            PsionicFolder = Character.PsionicFolder
            If Not PsionicFolder.IsEmpty Then
                UserPowerPointsModifier = PsionicFolder.ElementAsInteger("PowerPointsModifier")
            End If

        End Sub

        'get the bonus power points for the given score and class level
        Public Function BonusPowerPoints(ByVal Score As Integer, ByVal ClassLevel As Integer) As Integer
            Try
                Return CInt(Math.Floor((Rules.AbilityScores.AbilityScore(Score).Modifier / 2) * ClassLevel))
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'save - update the user power points modifier
        Public Sub Save()
            Try
                If Not PsionicFolder.IsEmpty Then
                    PsionicFolder.Element("PowerPointsModifier") = UserPowerPointsModifier.ToString
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace

