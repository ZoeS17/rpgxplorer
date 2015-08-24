Option Explicit On 
Option Strict On

Namespace Rules

    Public Class Constants

        Public Shared MaxAbilityScore As Byte = 50
        Public Const MaxLevels As Byte = 50

        'String Conditions

        'colour constants - shared as colors cant be declared with const

        'spell
        Public Shared ClassSpellColor As System.Drawing.Color = System.Drawing.Color.Black
        Public Shared DomainSpellColor As System.Drawing.Color = System.Drawing.Color.CornflowerBlue
        Public Shared PrestigeSpellColor As System.Drawing.Color = System.Drawing.Color.LimeGreen
        Public Shared PrestigeDomainSpellColor As System.Drawing.Color = System.Drawing.Color.DarkViolet
        Public Shared TakenSpellColor As System.Drawing.Color = System.Drawing.Color.DarkGoldenrod
        Public Shared RestrictedSpellColor As System.Drawing.Color = System.Drawing.Color.Red
        Public Shared RacialAdditional As System.Drawing.Color = System.Drawing.Color.DimGray

        'feat
        Public Shared NormalFeatColor As System.Drawing.Color = System.Drawing.Color.Black
        Public Shared FighterBonusFeatColor As System.Drawing.Color = System.Drawing.Color.DarkBlue
        Public Shared TakenFeatColor As System.Drawing.Color = System.Drawing.Color.DarkGoldenrod
        Public Shared FailedFeatColor As System.Drawing.Color = System.Drawing.Color.Silver

    End Class

End Namespace
