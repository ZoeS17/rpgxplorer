Option Explicit On 
Option Strict On

Namespace Rules

    Public Class Conditions

        Public Const ByClass As String = "Class Condition (Any from list)"
        'Public Const NotByClass As String = "Classes Restricted"
        Public Const ByRace As String = "Race Condition (Any from list)"
        'Public Const NotByRace As String = "Races Restricted"
        Public Const AgainstAlignment As String = "Versus Alignment(s)"
        Public Const AgainstType As String = "Versus Monster Type(s)"
        Public Const NotCritImmune As String = "Versus Creatures Not Immune to Critical Hits"
        Public Const UserDefined As String = "User Defined"
        Public Const FeatRequired As String = "Feat Condition (Any from list)"
        Public Const AgainstSubtype As String = "Versus Monster Subtype(s)"
        Public Const Bane As String = "Bane (Select focus at purchase)"

        'Hashtable with Condition as key, Object Type as Value
        Public Shared ConditionTypes As String()

        Public Shared Sub LoadConditions()
            Try
                ReDim ConditionTypes(8)
                ConditionTypes(0) = ByClass
                ConditionTypes(1) = ByRace
                ConditionTypes(2) = AgainstAlignment
                ConditionTypes(3) = AgainstType
                ConditionTypes(4) = NotCritImmune
                ConditionTypes(5) = UserDefined
                ConditionTypes(6) = FeatRequired
                ConditionTypes(7) = AgainstSubtype
                ConditionTypes(8) = Bane

                Array.Sort(ConditionTypes)
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

    End Class

End Namespace