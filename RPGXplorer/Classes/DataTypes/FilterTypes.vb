Option Explicit On 
Option Strict On

'term type
Public Enum TermType
    MatchList
    Contains
    NumericRange
    NumericLessThan
    NumericGreaterThan
    NoValue
End Enum

'numeric context
Public Enum NumericContext
    None
    Number
    Money
    Weight
End Enum

'term
Public Structure Term
    Public Key As Objects.ObjectKey
    Public Criteria As String
    Public Element As String
    Public TermType As TermType
    Public NumericContext As NumericContext
    Public NotEquals As Boolean
    Private _Values As ArrayList

    Public Property Values() As ArrayList
        Get
            If _Values Is Nothing Then
                _Values = New ArrayList
            End If
            Return _Values
        End Get
        Set(ByVal Value As ArrayList)
            _Values = Value
        End Set
    End Property

    Public ReadOnly Property TermName() As String
        Get
            Select Case TermType
                Case TermType.Contains
                    If Values.Count = 1 Then
                        If NotEquals Then
                            Return Criteria & " doesn't contain '" & Values(0).ToString & "'"
                        Else
                            Return Criteria & " contains '" & Values(0).ToString & "'"
                        End If
                    Else
                        Dim Temp As String

                        If NotEquals Then
                            Temp = Criteria & " doesn't contain '"
                        Else
                            Temp = Criteria & " contains '"
                        End If

                        For Each Value As String In Values
                            Temp &= Value & "' or '"
                        Next
                        Temp = Temp.Substring(0, Temp.Length - 5)
                        Return Temp
                    End If
                Case TermType.MatchList
                    If Values.Count = 1 Then
                        If NotEquals Then
                            Return Criteria & " is not '" & Values(0).ToString & "'"
                        Else
                            Return Criteria & " is '" & Values(0).ToString & "'"
                        End If
                    Else
                        If NotEquals Then
                            Return Criteria & " is not one of '" & CommonLogic.CommaSeparatedList(Values) & "'"
                        Else
                            Return Criteria & " is one of '" & CommonLogic.CommaSeparatedList(Values) & "'"
                        End If
                    End If
                Case TermType.NumericGreaterThan
                    Select Case NumericContext
                        Case NumericContext.Money
                            Return Criteria & " >= " & Values(0).ToString & " gp"
                        Case NumericContext.Number, NumericContext.None
                            Return Criteria & " >= " & Values(0).ToString
                        Case NumericContext.Weight
                            Return Criteria & " >= " & Values(0).ToString & " lb."
                    End Select
                Case TermType.NumericLessThan
                    Select Case NumericContext
                        Case NumericContext.Money
                            Return Criteria & " <= " & Values(1).ToString & " gp"
                        Case NumericContext.Number, NumericContext.None
                            Return Criteria & " <= " & Values(1).ToString
                        Case NumericContext.Weight
                            Return Criteria & " <= " & Values(1).ToString & " lb."
                    End Select
                Case TermType.NumericRange
                    Select Case NumericContext
                        Case NumericContext.Money
                            Return Criteria & " >= " & Values(0).ToString & " gp and <= " & Values(1).ToString & " gp"
                        Case NumericContext.Number, NumericContext.None
                            Return Criteria & " >= " & Values(0).ToString & " and <= " & Values(1).ToString
                        Case NumericContext.Weight
                            Return Criteria & " >= " & Values(0).ToString & " lb. and <= " & Values(1).ToString & " lb."
                    End Select
                Case TermType.NoValue
                    If NotEquals Then
                        Return Criteria & " is not blank/empty."
                    Else
                        Return Criteria & " is blank/empty."
                    End If
            End Select
            Return ""
        End Get
    End Property

    'load term
    Public Sub LoadTerm(ByVal TermObj As Objects.ObjectData)
        Try
            Key = TermObj.ObjectGUID
            Criteria = TermObj.Element("Criteria")
            Element = TermObj.Element("Element")
            TermType = DirectCast(TermObj.ElementAsInteger("TermType"), TermType)
            NumericContext = DirectCast(TermObj.ElementAsInteger("NumericContext"), NumericContext)
            If TermObj.Element("NotEquals") = "True" Then NotEquals = True Else NotEquals = False
            Values() = New ArrayList

            For n As Integer = 1 To TermObj.ElementAsInteger("ValueCount")
                Values.Add(TermObj.Element("Value" & n.ToString))
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save term 
    Public Sub SaveTerm(ByVal ParentKey As Objects.ObjectKey)
        Try
            Dim TermObj As New Objects.ObjectData

            TermObj.Name = TermName
            If Key.IsEmpty Then
                TermObj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.UserDocs)
            Else
                TermObj.ObjectGUID = Key
            End If
            TermObj.Type = Objects.FilterTermType
            TermObj.ParentGUID = ParentKey
            TermObj.Element("Criteria") = Criteria
            TermObj.Element("Element") = Element
            TermObj.ElementAsInteger("TermType") = TermType
            Select Case TermType
                Case TermType.NumericGreaterThan, TermType.NumericLessThan, TermType.NumericRange
                    TermObj.ElementAsInteger("NumericContext") = NumericContext
                Case Else
                    TermObj.ElementAsInteger("NumericContext") = 0
            End Select
            If NotEquals Then TermObj.Element("NotEquals") = "True" Else TermObj.Element("NotEquals") = ""
            If TermType <> TermType.NoValue Then TermObj.ElementAsInteger("ValueCount") = Values.Count

            Dim Index As Integer = 1

            For Each Value As Object In Values
                TermObj.Element("Value" & Index.ToString) = Value.ToString
                Index += 1
            Next

            TermObj.Save()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'clear
    Public Sub Clear()
        Key = Nothing
        Criteria = Nothing
        Element = Nothing
        TermType = Nothing
        NumericContext = Nothing
        _Values = Nothing
    End Sub

End Structure

'filter
Public Structure Filter
    Implements IComparable
    <CLSCompliant(False)> Public _Name As String
    Public Key As Objects.ObjectKey
    Public FolderType As String
    Public Terms As ArrayList

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _Name
    End Function

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        Try
            Dim Filter As Filter = DirectCast(obj, Filter)

            If Filter.Name > Name Then
                Return 1
            ElseIf Filter.Name < Name Then
                Return -1
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function
End Structure