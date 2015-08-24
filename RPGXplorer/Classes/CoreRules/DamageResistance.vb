Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class DamageResistance

        'this is a common class for handling the merging of damage resistances gained from multiple sources

#Region "Member Variables"

        Private _Resistances As Hashtable

#End Region

#Region "Structures"

        Structure DamageResistance
            Public ResistanceValue As Integer
            Public Stack As Boolean
        End Structure

#End Region

#Region "Properties"

        'combined resistance string
        'Public ReadOnly Property DisplayString() As String
        '    Get
        '        If _Resistances.Count = 0 Then Return ""

        '        Dim List As New ArrayList

        '        For Each Bucket As DictionaryEntry In _Resistances
        '            List.Add(Bucket.Key.ToString & " " & Bucket.Value.ToString)
        '        Next

        '        List.Sort()
        '        Return CommonLogic.CommaSeparatedList(List)
        '    End Get
        'End Property

        'combined resistance string
        Public ReadOnly Property DisplayString() As String
            Get
                Dim List As New ArrayList
                Dim CurrentLargest, StackedTotal As Integer
                Dim ResistanceArray As ArrayList

                If _Resistances.Count = 0 Then Return ""

                For Each DamageType As String In _Resistances.Keys
                    StackedTotal = 0 : CurrentLargest = 0
                    ResistanceArray = CType(_Resistances.Item(DamageType), ArrayList)
                    For Each Resistance As DamageResistance In ResistanceArray
                        If Resistance.Stack Then
                            StackedTotal += Resistance.ResistanceValue
                        Else
                            If Resistance.ResistanceValue > CurrentLargest Then
                                CurrentLargest = Resistance.ResistanceValue
                            End If
                        End If
                    Next
                    StackedTotal += CurrentLargest
                    List.Add(DamageType & " " & StackedTotal.ToString)
                Next
                List.Sort()
                Return CommonLogic.CommaSeparatedList(List)
            End Get
        End Property

#End Region

        'constructor
        Public Sub New()
            _Resistances = New Hashtable
        End Sub

        'add damage resistance
        Public Sub AddDamageResistance(ByVal Obj As Objects.ObjectData)
            Dim ResistanceArray As ArrayList
            Dim DamageType As String = Obj.Element("DamageType")
            Dim Resistance As DamageResistance

            'create new resistance object
            Resistance.ResistanceValue = Obj.ElementAsInteger("ResistanceReduction")
            If Obj.Element("Stacks") = "Yes" Then Resistance.Stack = True Else Resistance.Stack = False

            If _Resistances.Contains(DamageType) Then
                ResistanceArray = CType(_Resistances.Item(DamageType), ArrayList)
                ResistanceArray.Add(Resistance)
            Else
                ResistanceArray = New ArrayList
                ResistanceArray.Add(Resistance)
                _Resistances.Add(DamageType, ResistanceArray)
            End If

        End Sub

        'clear
        Public Sub Clear()
            _Resistances.Clear()
        End Sub

    End Class

End Namespace