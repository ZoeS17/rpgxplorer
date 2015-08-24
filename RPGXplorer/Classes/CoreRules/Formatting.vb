Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class Formatting

#Region "Formatting"

        'format an attacks string 
        Public Shared Function FormatAttacks(ByVal Attacks As ArrayList) As String
            Try
                FormatAttacks = ""
                If Not Attacks Is Nothing Then
                    For Each Attack As Integer In Attacks
                        If FormatAttacks.Length > 0 Then FormatAttacks &= "/"
                        If Attack = 0 Then
                            FormatAttacks &= "+0"
                        Else
                            FormatAttacks &= FormatModifier(Attack)
                        End If
                    Next
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format an attacks string 
        Public Shared Function FormatAttacksClassLevel(ByVal Attacks() As Integer) As String
            Dim RetVal As String = ""

            Try
                For n As Integer = 0 To Attacks.GetUpperBound(0)
                    If n = 0 Then
                        If Attacks(n) = 0 Then
                            RetVal = "+0"
                        Else
                            RetVal = FormatModifier(Attacks(n))
                        End If
                    Else
                        If Attacks(n) > 0 Then
                            RetVal &= "\" & FormatModifier(Attacks(n))
                        End If
                    End If
                Next

                Return RetVal

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format a critical threat rage
        Public Shared Function FormatCriticalRange(ByVal Crit As Rules.WeaponProperties.CriticalRange) As String
            If Crit.Threat = 20 Then
                Return "x" & Crit.Multiplier.ToString
            Else
                Return Crit.Threat.ToString & "-20/x" & Crit.Multiplier.ToString
            End If
        End Function

        'format weapon damage type
        Public Shared Function FormatDamageType(ByVal Lethality As String, ByVal DamageType As String) As String
            Select Case Lethality
                Case ""
                    If DamageType = "" Then
                        Return ""
                    Else
                        Return "Shield Bash (" & DamageType & ")"
                    End If
                Case "Lethal"
                    Return "(" & DamageType & ")"
                Case "Non-Lethal"
                    Return "Non-Lethal (" & DamageType & ")"
                Case "No Damage"
                    Return "No Damage"
                Case Else 'for natural weapons - as Damage element is damage ammount
                    If DamageType <> "" Then
                        Return "(" & DamageType & ")"
                    Else
                        Return ""
                    End If
            End Select
        End Function

        'format str modifier to damage
        Public Shared Function FormatModifierHideZero(ByVal Value As Integer) As String
            If Value = 0 Then
                Return ""
            Else
                Return FormatModifier(Value)
            End If
        End Function

        'format a numeric value as a modifer i.e. -1, +1 etc.
        Public Shared Function FormatModifier(ByVal Value As Integer) As String
            Try
                If Value > 0 Then
                    Return "+" & CStr(Value)
                Else
                    Return CStr(Value)
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format a numeric value as a multiplier i.e. x1, x2, etc.
        Public Shared Function FormatMultiplier(ByVal Value As Integer) As String
            Try
                Return "x" & CStr(Value)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format a number into 1st, 2nd, 3rd etc
        Public Shared Function FormatLevel(ByVal Level As Integer) As String
            Try
                Select Case Level
                    Case 0
                        Return Level & "th"
                    Case 1, 21, 31, 41
                        Return Level & "st"
                    Case 2, 22, 32, 42
                        Return Level & "nd"
                    Case 3, 23, 33, 43
                        Return Level & "rd"
                    Case 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 24, 25, 26, 27, 28, 29, 30, 34, 35, 36, 37, 38, 39, 40, 44, 45, 46, 47, 48, 49, 50
                        Return Level & "th"
                    Case Else
                        Return "System does not support levels beyond 50"
                End Select
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format a number into feet and inches
        Public Shared Function FormatFeetandInches(ByVal Inches As Integer) As String
            Dim Feet As Integer

            Try
                Feet = CType(Math.Floor(Inches / 12), Integer)
                Inches = Inches - (Feet * 12)
                FormatFeetandInches = CStr(Feet) & "ft. " & CStr(Inches)
                FormatFeetandInches &= "in."

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format a number into feet
        Public Shared Function FormatFeet(ByVal Feet As Integer) As String
            Return CStr(Feet) & " ft."
        End Function

        'format a number into feet
        Public Shared Function FormatFeet(ByVal Feet As Double) As String
            Return CStr(Feet) & " ft."
        End Function

        'format a number into feet
        Public Shared Function FormatFeetNull(ByVal Feet As Integer) As String
            If Feet = 0 Then
                Return "-"
            Else
                Return CStr(Feet) & " ft."
            End If
        End Function

        'format a number into stones and lbs
        Public Shared Function FormatPounds(ByVal Pounds As Double) As String
            Dim Fraction As Double
            Dim Integral As Double

            Try
                Integral = Math.Floor(Pounds)
                Fraction = Pounds - Integral

                If Fraction = 0 Then
                    Return CStr(Pounds) & " lb."
                Else
                    Return CStr(Integral) & CStr(Math.Round(Fraction, 4)).TrimStart(New Char() {"0"c}) & " lb."
                End If

            Catch ex As FormatException
                Return "0"
            End Try
        End Function

        'format a number into platinum pieces
        Public Shared Function FormatPP(ByVal PP As Integer) As String
            Return CStr(PP) & " pp"
        End Function

        'format a number into gold pieces
        Public Shared Function FormatGP(ByVal GP As Integer) As String
            Return CStr(GP) & " gp"
        End Function

        'format a number into silver pieces
        Public Shared Function FormatSP(ByVal SP As Integer) As String
            Return CStr(SP) & " sp"
        End Function

        'format a number into copper pieces
        Public Shared Function FormatCP(ByVal CP As Integer) As String
            Return CStr(CP) & " cp"
        End Function

        'format a number into percentage
        Public Shared Function FormatPercent(ByVal Percent As Integer) As String
            Return CStr(Percent) & "%"
        End Function

        'format a number into percentage e.g. -10% +20%
        Public Shared Function FormatPercentModifier(ByVal Percent As Integer) As String
            If Percent > 0 Then
                Return "+" & CStr(Percent) & "%"
            Else
                Return CStr(Percent) & "%"
            End If
        End Function

        'format a number into gold pieces
        Public Shared Function FormatXP(ByVal XP As Integer) As String
            Return CStr(XP) & " XP"
        End Function

        'format a hit points string
        Public Shared Function FormatHP(ByVal BaseHP As Integer, ByVal CurrentHP As Integer, ByVal Subdual As Integer) As String
            Try
                FormatHP = CurrentHP & "/" & BaseHP
                If Subdual > 0 Then FormatHP &= " (" & Subdual & ")"
                Return FormatHP
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'format a spell description block for display on the character sheet
        Public Shared Function FormatSpellCRS(ByVal School As String, ByVal Subschool As String, ByVal Descriptors As String, ByVal Components As String, ByVal CastingTime As String, ByVal Range As String, ByVal TargetAreaEffect As String, ByVal Duration As String, ByVal SavingThrow As String, ByVal SpellResistance As String, ByVal Description As String, ByVal ComponentCost As String, ByVal XPCost As String) As String
            Try
                Dim Temp As String

                Temp = School
                If Subschool <> "" Or Descriptors <> "" Then Temp &= " "
                If Subschool <> "" Then Temp &= "(" & Subschool & ")"
                If Descriptors <> "" Then Temp &= "[" & Descriptors & "]"
                Temp &= ", Components: " & Components
                If ComponentCost <> "" Or XPCost <> "" Then Temp &= " ("
                If ComponentCost <> "" Then Temp &= "Cost = " & ComponentCost
                If ComponentCost <> "" And XPCost <> "" Then Temp &= ", "
                If XPCost <> "" Then Temp &= "XP = " & XPCost
                If ComponentCost <> "" Or XPCost <> "" Then Temp &= ")"
                Temp &= ", Casting Time: " & CastingTime
                Temp &= ", Range: " & Range
                Temp &= ", Target/Area/Effect: " & TargetAreaEffect
                Temp &= ", Duration: " & Duration
                If SavingThrow <> "" Then Temp &= ", Saving Throw: " & SavingThrow
                If SpellResistance <> "" Then Temp &= ", Spell Resistance: " & SpellResistance
                If Description <> "" Then Temp &= ", Description: " & Description

                Return Temp
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Shared Function FormatPowerCRS(ByVal Discipline As String, ByVal Subdiscipline As String, ByVal Descriptors As String, ByVal Display As String, ByVal CastingTime As String, ByVal Range As String, ByVal TargetAreaEffect As String, ByVal Duration As String, ByVal SavingThrow As String, ByVal PowerResistance As String, ByVal Description As String, ByVal XPCost As String, ByVal Points As String, ByVal Augment As String) As String
            Try
                Dim Temp As String

                Temp = Discipline
                If Subdiscipline <> "" Or Descriptors <> "" Then Temp &= " "
                If Subdiscipline <> "" Then Temp &= "(" & Subdiscipline & ")"
                If Descriptors <> "" Then Temp &= "[" & Descriptors & "]"

                Temp &= ", Points: " & Points
                If XPCost <> "" Or Augment <> "" Then Temp &= " ("
                If Augment <> "" Then Temp &= "Augmentable"
                If Augment <> "" And XPCost <> "" Then Temp &= ", XP = " & XPCost
                If XPCost <> "" Or Augment <> "" Then Temp &= ")"

                Temp &= ", Display: " & Display
                Temp &= ", Casting Time: " & CastingTime
                Temp &= ", Range: " & Range
                Temp &= ", Target/Area/Effect: " & TargetAreaEffect
                Temp &= ", Duration: " & Duration

                If SavingThrow <> "" Then Temp &= ", Saving Throw: " & SavingThrow
                If PowerResistance <> "" Then Temp &= ", Power Resistance: " & PowerResistance
                If Description <> "" Then Temp &= ", Description: " & Description

                Return Temp
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

#Region "Reverse Formatting"

        'reverse formatting and retype gold pieces string
        Public Shared Function ReverseGP(ByVal GP As String) As Integer
            If GP = "" Then Return 0 Else Return CType(GP.Replace(" gp", ""), Integer)
        End Function

#End Region

#Region "Name Formatting"

        'construct the name of a modifier
        Public Shared Function ModifierName(ByVal Modifier As ModifiersDisplay.Modifier) As String
            Try
                Dim Name, Temp As String

                Name = ModifierCoreName(Modifier)
                If Name = "" Then Return ""

                Temp = Modifier.Type
                If Temp <> "" Then Name &= " [" & Temp & "]"

                Temp = Modifier.Limiter
                If Temp <> "" Then Name &= " [" & Temp & "]"

                Return Name

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'used to construct the first part of a modifier string
        Public Shared Function ModifierCoreName(ByVal Modifier As ModifiersDisplay.Modifier) As String
            Try
                Dim Name As String = ""
                Dim Temp As String = ""

                Select Case Modifier.ModifierCategory
                    Case "Normal Modifier"
                        Name = Modifier.Modifier & " " & Modifier.SystemElementName
                    Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                        Name = Modifier.Modifier & " modifies " & Modifier.SystemElementName
                    Case "Percentage Modifier"
                        If Not Modifier.Modifier.StartsWith("-") Then
                            Name = Modifier.SystemElementName & " +" & Modifier.Modifier
                        Else
                            Name = Modifier.SystemElementName & " " & Modifier.Modifier
                        End If
                    Case "Dice Range Modifier"
                        Name = Modifier.SystemElementName & " +" & Modifier.Modifier
                    Case "Complex Modifier"

                        Name = "+ " & Modifier.BaseNumber & " " & Modifier.SystemElementName

                        Temp = Modifier.PerLevel
                        If Temp <> "" Then
                            Name &= " + " & Temp & " per Character Level"
                        End If

                        Temp = Modifier.TagString
                        If Temp <> "" Then
                            Name &= " + " & Modifier.TagNumber & " per Class Level with " & Temp & " tag"
                        End If

                        Temp = Modifier.AbilityMod
                        If Temp <> "" Then
                            Name &= " + " & Temp & " Modifier"
                        End If

                End Select

                Temp = Modifier.Focus
                If Temp <> "" Then Name &= " (" & Temp & ")"

                Return Name

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'construct the name of a modifier 
        Public Shared Function ModifierName(ByVal Modifier As Objects.ObjectData) As String
            Try
                Dim Name As String = ""
                Dim Temp As String = ""

                Select Case Modifier.Element("ModifierCategory")
                    Case "Normal Modifier"
                        Name = Modifier.Element("Modifier") & " " & Modifier.Element("SystemElement")
                    Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                        Name = Modifier.Element("Modifier") & " modifies " & Modifier.Element("SystemElement")
                    Case "Percentage Modifier"
                        If Not Modifier.Element("Modifier").StartsWith("-") Then
                            Name = Modifier.Element("SystemElement") & " +" & Modifier.Element("Modifier")
                        Else
                            Name = Modifier.Element("SystemElement") & " " & Modifier.Element("Modifier")
                        End If
                    Case "Dice Range Modifier"
                        Name = Modifier.Element("SystemElement") & " +" & Modifier.Element("Modifier")
                    Case "Complex Modifier"

                        Name = "+ " & Modifier.Element("BaseNumber") & " " & Modifier.Element("SystemElement")

                        Temp = Modifier.Element("PerLevel")
                        If Temp <> "" Then
                            Name &= " + " & Temp & " per Character Level"
                        End If

                        Temp = Modifier.Element("TagString")
                        If Temp <> "" Then
                            Name &= " + " & Modifier.Element("TagNumber") & " per Class Level with " & Temp & " tag"
                        End If

                        Temp = Modifier.Element("AbilityMod")
                        If Temp <> "" Then
                            Name &= " + " & Temp & " Modifier"
                        End If

                    Case Else
                        Return Name
                End Select

                Temp = Modifier.Element("FocusObject")
                If Temp <> "" Then Name &= " (" & Temp & ")"

                Temp = Modifier.Element("ModifierType")
                If Temp <> "Undefined" Then Name &= " [" & Temp & "]"

                Temp = Modifier.Element("Limiter")
                If Temp <> "" Then Name &= " [" & Temp & "]"

                Return Name

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'construct the name of a synergy
        Public Shared Function SynergyName(ByVal Synergy As Objects.ObjectData) As String
            Try
                Dim Name, Temp As String

                Temp = Synergy.Element("Ranks")
                If Temp = "1" Then
                    Name = Temp & " Rank gives "
                Else
                    Name = Temp & " Ranks gives "
                End If
                Name &= ModifierName(Synergy)

                Return Name

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Shared Function SetAbilityName(ByVal SetAbility As Objects.ObjectData) As String
            Dim Name As String

            Name = "Base " & SetAbility.Element("Ability") & " becomes " & SetAbility.Element("Value")

            Return Name

        End Function

        Public Shared Function SetValueName(ByVal SetValue As Objects.ObjectData) As String
            Dim Name, Temp As String

            Name = SetValue.Element("SystemElement") & " equal to " & SetValue.Element("BaseNumber")

            Temp = SetValue.Element("PerLevel")
            If Temp <> "" Then
                Name &= " + " & Temp & " per Character Level"
            End If

            Temp = SetValue.Element("TagString")
            If Temp <> "" Then
                Name &= " + " & SetValue.Element("TagNumber") & " per Class Level with " & Temp & " tag"
            End If

            Temp = SetValue.Element("AbilityMod")
            If Temp <> "" Then
                Name &= " + " & Temp & " Modifier"
            End If

            Return Name

        End Function

#End Region

    End Class

#Region "Formatter Classes"

    'formatter class for the custom formatting of level spin controls
    Class LevelFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatLevel(CInt(arg))
        End Function
    End Class

    'formatter class for the custom formatting of level control on the power progression form
    Class PsionicFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            If CInt(arg) = 0 Then
                Format = "-"
            Else
                Format = Formatting.FormatLevel(CInt(arg))
            End If
        End Function
    End Class

    'formatter class for the custom formatting of weight spin controls
    Class WeightFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatPounds(CDbl(arg))
        End Function
    End Class

    'formatter class for the custom formatting of gold piece spin controls
    Class GoldFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            ' If TypeOf arg Is Decimal Then
            Format = Formatting.FormatGP(CInt(arg))
            ' End If
        End Function
    End Class

    'formatter class for the custom formatting of feet (no inches) spin controls
    Class FeetFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatFeet(CInt(arg))
        End Function

    End Class

    'formatter class for the custom formatting of fraction spin controls
    Class FractionFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Dim Number As Double = CDbl(arg)

            Select Case Number
                Case 0.5
                    Return "1/2"
                Case 0.33
                    Return "1/3"
                Case 0.25
                    Return "1/4"
                Case 0.2
                    Return "1/5"
                Case 0.167
                    Return "1/6"
                Case 0.143
                    Return "1/7"
                Case 0.125
                    Return "1/8"
                Case 0.11
                    Return "1/9"
                Case 0.1
                    Return "1/10"
                Case Else
                    Return Number.ToString
            End Select

        End Function

    End Class

    'formatter class for the custom formatting of feet (no inches) spin controls
    Class DoubleFeetFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatFeet(CDbl(arg))
        End Function

    End Class

    'formatter class for the custom formatting of feet (no inches) spin controls
    Class FeetWithNullFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatFeetNull(CInt(arg))
        End Function

    End Class

    'formatter class for the custom formatting of hieght (feet & inches) spin controls
    Class HeightFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatFeetandInches(CInt(arg))
        End Function

    End Class

    'formatter class for the custom formatting of percentage spin controls
    Class PercentFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatPercent(CInt(arg))
        End Function

    End Class

    'formatter class for the custom formatting of the market price spin control
    Class MarketPricesFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            If CInt(arg) = 0 Then
                Format = "Normal"
            Else
                Format = Formatting.FormatPercentModifier(CInt(arg))
            End If
        End Function

    End Class

    'formatter class for the custom formatting of Experience points spin controls
    Class XPFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            ' If TypeOf arg Is Decimal Then
            Format = Formatting.FormatXP(CInt(arg))
            ' End If
        End Function
    End Class

    'formatter class for the custom formatting of money spin controls
    Class PPFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatPP(CInt(arg))
        End Function
    End Class

    'formatter class for the custom formatting of money spin controls
    Class GPFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatGP(CInt(arg))
        End Function
    End Class

    'formatter class for the custom formatting of money spin controls
    Class SPFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatSP(CInt(arg))
        End Function
    End Class

    'formatter class for the custom formatting of money spin controls
    Class CPFormatter : Implements IFormatProvider, ICustomFormatter

        'implementing the GetFormat method of the IFormatProvider interface
        Public Function GetFormat(ByVal type As Type) As Object Implements IFormatProvider.GetFormat
            Return Me
        End Function

        'implementing the Format method of the ILevelFormatter interface
        Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Format = Formatting.FormatCP(CInt(arg))
        End Function
    End Class

#End Region

End Namespace