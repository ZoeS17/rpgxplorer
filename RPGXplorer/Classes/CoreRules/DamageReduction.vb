Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Namespace Rules

    Public Class DamageReduction

        'this is a common class for handling the merging of damage reductions gained from multiple sources

#Region "Member Variables"

        Private _Reductions As Hashtable

#End Region

#Region "Properties"

        'combined resistance string
        Public ReadOnly Property DisplayString() As String
            Get
                If _Reductions.Count = 0 Then Return ""

                Dim List As New ArrayList

                For Each Bucket As DictionaryEntry In _Reductions
                    List.Add(Bucket.Value.ToString & "/" & Bucket.Key.ToString)
                Next

                List.Sort()
                Return CommonLogic.CommaSeparatedList(List)
            End Get
        End Property

#End Region

        'constructor
        Public Sub New()
            _Reductions = New Hashtable
        End Sub

        'add damage reduction
        Public Sub AddDamageReduction(ByVal Obj As Objects.ObjectData)

            Dim DamageType As String

            If Obj.Element("DROvercomeByType") = "Damage Type" Then
                DamageType = Obj.Element("DamageType")
            Else
                DamageType = Obj.Element("DROvercomeByType")
            End If

            If Obj.Element("Junction") <> "" Then
                DamageType &= (" " & Obj.Element("Junction") & " ")
                If Obj.Element("DROvercomeByType2") = "Damage Type" Then
                    DamageType &= Obj.Element("DamageType2")
                Else
                    DamageType &= Obj.Element("DROvercomeByType2")
                End If
            End If

            If _Reductions.Contains(DamageType) Then
                Dim Temp As Integer = Obj.ElementAsInteger("Reduction")
                Dim Existing As Integer = CType(_Reductions.Item(DamageType), Integer)

                If Temp > Existing Then
                    _Reductions.Item(DamageType) = Temp
                End If
            Else
                _Reductions.Add(DamageType, Obj.ElementAsInteger("Reduction"))
            End If

        End Sub

        Public Sub AddDamageReduction(ByVal Reduction As Integer, ByVal OvercomeType As String, ByVal DamageType As String)
            Dim ActualDamageType As String
            If Reduction > 0 Then
                If OvercomeType = "Damage Type" Then
                    ActualDamageType = DamageType
                Else
                    ActualDamageType = OvercomeType
                End If

                If _Reductions.Contains(ActualDamageType) Then
                    Dim Temp As Integer = Reduction
                    Dim Existing As Integer = CType(_Reductions.Item(DamageType), Integer)

                    If Temp > Existing Then
                        _Reductions.Item(ActualDamageType) = Temp
                    End If
                Else
                    _Reductions.Add(ActualDamageType, Reduction)
                End If
            End If
        End Sub

        'clear
        Public Sub Clear()
            _Reductions.Clear()
        End Sub

    End Class

End Namespace