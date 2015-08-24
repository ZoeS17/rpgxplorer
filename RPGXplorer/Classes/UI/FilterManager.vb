Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Public Class FilterManager

    'this class is responsible for handling and applying filters

#Region "Member Variables"

    Public CurrentFilter As String
    Public CurrentFolder As Objects.ObjectData
    Public FolderFilters As New Objects.ObjectDataCollection

    'misc
    Public SuppressEvents As Boolean

#End Region

    'init folder filter
    Public Sub InitFolder(ByVal Folder As Objects.ObjectData)
        Try
            SuppressEvents = True
            CurrentFolder = Folder

            'get filters
            FolderFilters.Clear()
            FolderFilters = Objects.GetObjectsByXPath(XML.DBTypes.UserDocs, "/RPGXplorerDatabase/RPGXplorerObject[Type='Filter' and FolderType='" & Folder.Type & "']")

            'populate combo
            Dim Temp As ArrayList = New ArrayList
            Temp.Add("")
            Temp.AddRange(FolderFilters.GetNameList)
            ToolbarsAndMenus.FilterList = Temp

            'get the current filter 
            CurrentFilter = WindowManager.CurrentWindow.Filter
            If Not CurrentFilter = "" AndAlso ToolbarsAndMenus.FilterList.Contains(CurrentFilter) Then ToolbarsAndMenus.FilterEdit.EditValue = CurrentFilter Else ToolbarsAndMenus.FilterEdit.EditValue = ""

            SuppressEvents = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reinit filter after change from filters form
    Public Sub ReInit()
        Try
            'get filters
            FolderFilters.Clear()
            FolderFilters = Objects.GetObjectsByXPath(XML.DBTypes.UserDocs, "/RPGXplorerDatabase/RPGXplorerObject[Type='Filter' and FolderType='" & CurrentFolder.Type & "']")

            'populate combo
            Dim Temp As New ArrayList
            Temp.Add("")
            Temp.AddRange(FolderFilters.GetNameList)
            ToolbarsAndMenus.FilterList = Temp

            'enable or disable filter
            If Not CurrentFilter = "" AndAlso ToolbarsAndMenus.FilterList.Contains(CurrentFilter) Then
                ToolbarsAndMenus.FilterEdit.EditValue = CurrentFilter
                General.MainExplorer.RefreshPanel()
            Else
                ToolbarsAndMenus.FilterEdit.EditValue = ""
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reinit filter after change from filters form
    Public Sub ReInitForFilterBar(ByVal CurrentFolder As Objects.ObjectData, ByVal FilterCombo As DevExpress.XtraEditors.ComboBoxEdit)
        Try
            'get filters
            FolderFilters.Clear()
            FolderFilters = Objects.GetObjectsByXPath(XML.DBTypes.UserDocs, "/RPGXplorerDatabase/RPGXplorerObject[Type='Filter' and FolderType='" & CurrentFolder.Type & "']")

            'populate combo
            Dim Temp As New ArrayList
            Temp.Add("")
            Temp.AddRange(FolderFilters.GetNameList)
            Temp.Sort()
            FilterCombo.Properties.Items.Clear()
            For Each Item As Object In Temp
                FilterCombo.Properties.Items.Add(Item)
            Next

            'enable or disable filter
            If Not CurrentFilter = "" AndAlso FilterCombo.Properties.Items.Contains(CurrentFilter) Then
                FilterCombo.EditValue = CurrentFilter
            Else
                FilterCombo.EditValue = ""
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'filter the folder's objects
    Public Function ProcessFilter(ByVal Objects As Objects.ObjectDataCollection) As Objects.ObjectDataCollection
        Try
            'get selected filter
            Dim Filter As New Filter

            For Each FilterObj As Objects.ObjectData In FolderFilters
                If FilterObj.Name = CurrentFilter Then
                    Filter.Name = FilterObj.Name
                    Filter.FolderType = FilterObj.Element("FolderType")
                    Filter.Terms = New ArrayList

                    For Each TermObj As Objects.ObjectData In FilterObj.Children
                        Dim Term As New Term

                        Term.LoadTerm(TermObj)
                        Filter.Terms.Add(Term)
                    Next
                    Exit For
                End If
            Next

            'apply the filter
            Return DoProcessFilter(Filter, Objects)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'shared code for process filter
    Private Function DoProcessFilter(ByVal Filter As Filter, ByVal Objects As Objects.ObjectDataCollection) As Objects.ObjectDataCollection
        Try
            If Filter.Name = "" Then Return Objects

            'apply the filter
            Dim FilteredObjects As New Objects.ObjectDataCollection

            For Each Obj As Objects.ObjectData In Objects

                'each term must be met
                Dim Match As Boolean = True

                For Each Term As Term In Filter.Terms
                    Select Case Term.TermType
                        Case TermType.MatchList
                            'match list
                            If Term.NotEquals Then
                                If Term.Values.Contains(Obj.Element(Term.Element)) Then
                                    Match = False
                                    Exit For
                                End If
                            Else
                                If Not Term.Values.Contains(Obj.Element(Term.Element)) Then
                                    Match = False
                                    Exit For
                                End If
                            End If
                        Case TermType.Contains
                            'contains
                            Dim ElementValue As String = Obj.Element(Term.Element)
                            Dim Contains As Boolean = False

                            For Each Value As String In Term.Values
                                If ElementValue.IndexOf(Value) <> -1 Then Contains = True
                            Next

                            If Term.NotEquals Then
                                If Contains Then
                                    Match = False
                                    Exit For
                                End If
                            Else
                                If Not Contains Then
                                    Match = False
                                    Exit For
                                End If
                            End If

                        Case TermType.NumericGreaterThan
                            'numeric greater than
                            Dim ElementValue As String = Obj.Element(Term.Element)

                            Select Case Term.NumericContext
                                Case NumericContext.Money
                                    Dim MoneyVal As Money
                                    Dim TestVal As Money = New Money(Term.Values(0).ToString & "gp")

                                    Try
                                        MoneyVal = New Money(ElementValue)
                                    Catch ex As Exception
                                        MoneyVal = New Money
                                    End Try

                                    If MoneyVal.GoldDecimal < TestVal.GoldDecimal Then
                                        Match = False
                                        Exit For
                                    End If

                                Case NumericContext.None, NumericContext.Number
                                    Dim Val As Decimal
                                    Dim TestVal As Decimal = CType(Term.Values(0), Decimal)

                                    Try
                                        Val = CType(ElementValue, Decimal)
                                    Catch ex As InvalidCastException
                                        Val = 0
                                    End Try

                                    If Val < TestVal Then
                                        Match = False
                                        Exit For
                                    End If

                                Case NumericContext.Weight
                                    Dim Weight As Decimal
                                    Dim TestWeight As Decimal = CType(Term.Values(0), Decimal)

                                    Try
                                        Weight = CType(ElementValue.Replace("lb.", ""), Decimal)
                                    Catch ex As InvalidCastException
                                        Weight = 0
                                    End Try

                                    If Weight < TestWeight Then
                                        Match = False
                                        Exit For
                                    End If
                            End Select
                        Case TermType.NumericLessThan
                            'numeric less than
                            Dim ElementValue As String = Obj.Element(Term.Element)

                            Select Case Term.NumericContext
                                Case NumericContext.Money
                                    Dim MoneyVal As Money
                                    Dim TestVal As Money = New Money(Term.Values(1).ToString & "gp")

                                    Try
                                        MoneyVal = New Money(ElementValue)
                                    Catch ex As Exception
                                        MoneyVal = New Money
                                    End Try

                                    If MoneyVal.GoldDecimal > TestVal.GoldDecimal Then
                                        Match = False
                                        Exit For
                                    End If

                                Case NumericContext.None, NumericContext.Number
                                    Dim Val As Decimal
                                    Dim TestVal As Decimal = CType(Term.Values(1), Decimal)

                                    Try
                                        Val = CType(ElementValue, Decimal)
                                    Catch ex As InvalidCastException
                                        Val = 0
                                    End Try

                                    If Val > TestVal Then
                                        Match = False
                                        Exit For
                                    End If

                                Case NumericContext.Weight
                                    Dim Weight As Decimal
                                    Dim TestWeight As Decimal = CType(Term.Values(1), Decimal)

                                    Try
                                        Weight = CType(ElementValue.Replace("lb.", ""), Decimal)
                                    Catch ex As InvalidCastException
                                        Weight = 0
                                    End Try

                                    If Weight > TestWeight Then
                                        Match = False
                                        Exit For
                                    End If
                            End Select
                        Case TermType.NumericRange
                            'numeric range
                            Dim ElementValue As String = Obj.Element(Term.Element)

                            Select Case Term.NumericContext
                                Case NumericContext.Money
                                    Dim MoneyVal As Money
                                    Dim TestVal1 As Money = New Money(Term.Values(0).ToString & "gp")
                                    Dim TestVal2 As Money = New Money(Term.Values(1).ToString & "gp")

                                    Try
                                        MoneyVal = New Money(ElementValue)
                                    Catch ex As Exception
                                        MoneyVal = New Money
                                    End Try

                                    If MoneyVal.GoldDecimal < TestVal1.GoldDecimal Or MoneyVal.GoldDecimal > TestVal2.GoldDecimal Then
                                        Match = False
                                        Exit For
                                    End If

                                Case NumericContext.None, NumericContext.Number
                                    Dim Val As Decimal
                                    Dim TestVal1 As Decimal = CType(Term.Values(0), Decimal)
                                    Dim TestVal2 As Decimal = CType(Term.Values(1), Decimal)

                                    Try
                                        Val = CType(ElementValue, Decimal)
                                    Catch ex As InvalidCastException
                                        Val = 0
                                    End Try

                                    If Val < TestVal1 Or Val > TestVal2 Then
                                        Match = False
                                        Exit For
                                    End If

                                Case NumericContext.Weight
                                    Dim Weight As Decimal
                                    Dim TestWeight1 As Decimal = CType(Term.Values(0), Decimal)
                                    Dim TestWeight2 As Decimal = CType(Term.Values(1), Decimal)

                                    Try
                                        Weight = CType(ElementValue.Replace("lb.", ""), Decimal)
                                    Catch ex As InvalidCastException
                                        Weight = 0
                                    End Try

                                    If Weight < TestWeight1 Or Weight > TestWeight2 Then
                                        Match = False
                                        Exit For
                                    End If
                            End Select
                        Case TermType.NoValue
                            'is null
                            If Term.NotEquals Then
                                If Obj.Element(Term.Element) = "" Then
                                    Match = False
                                    Exit For
                                End If
                            Else
                                If Obj.Element(Term.Element) <> "" Then
                                    Match = False
                                    Exit For
                                End If
                            End If
                    End Select
                Next

                If Match Then FilteredObjects.Add(Obj)
            Next

            Return FilteredObjects
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'save current filter
    Public Sub SaveFilter()
        Try
            If Not CurrentFolder.IsEmpty Then
                Dim Key As Objects.ObjectKey = CurrentFolder.ObjectGUID
                CurrentFolder.Clear()
                CurrentFolder.Load(Key)
                If Not CurrentFolder.IsEmpty Then
                    CurrentFolder.Element("Filter") = ToolbarsAndMenus.FilterEdit.EditValue.ToString
                    CurrentFolder.Save()
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable disable
    Public Sub EnableDisable(ByVal FolderType As String)
        Try
            CurrentFilter = ""
            CurrentFolder = Nothing
            SuppressEvents = True
            If WindowManager.CurrentWindow Is Nothing Then
                EnableFolder(False)
            Else
                Select Case FolderType
                    Case Objects.CharacterType, Objects.AssetsFolderType, Objects.CharacterChoiceFolderType, Objects.ModifierFolderType, Objects.FeatFolderType, Objects.WeaponConfigFolderType, Objects.FeatureFolderType, Objects.ClassSpellSettingsFolderType, Objects.InventoryFolderType, Objects.ItemType, Objects.LanguageFolderType, Objects.CharacterLevelsFolderType, Objects.MagicFolderType, Objects.PsionicFolderType, Objects.PsiLikeAbilityFolderType, Objects.SpellLikeAbilityFolderType, Objects.ClassPowerSettingsFolderType, Objects.DomainAndSchoolsFolderType, Objects.PsionicSpecializationFolderType, ""
                        EnableFolder(False)
                    Case Else
                        EnableFolder(True)
                End Select
            End If
            SuppressEvents = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EnableFolder(ByVal bEnable As Boolean)
        If bEnable Then
            ToolbarsAndMenus.FilterEdit.Enabled = True
            For n As Integer = 0 To ToolbarsAndMenus.FilterBar.ItemLinks.Count - 1
                ToolbarsAndMenus.FilterBar.ItemLinks(n).Item.Enabled = True
            Next
        Else
            If Not ToolbarsAndMenus.FilterEdit Is Nothing Then
                ToolbarsAndMenus.FilterEdit.EditValue = Nothing
                ToolbarsAndMenus.FilterEdit.Enabled = False
                For n As Integer = 0 To ToolbarsAndMenus.FilterBar.ItemLinks.Count - 1
                    ToolbarsAndMenus.FilterBar.ItemLinks(n).Item.Enabled = False
                Next
            End If
        End If
    End Sub

End Class
