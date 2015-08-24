Option Strict On
Option Explicit On

Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class SpellcasterPanel2
    Inherits DevExpress.XtraEditors.XtraUserControl
    Implements IPanel


#Region "Member Variables"

    Private _CharacterKey As Objects.ObjectKey
    Private SpellSlots As Rules.SpellSlots
    Private Data, KnownData As DataTable
    Private _IsDirty As Boolean
    Private SpellSlotsLoaded As Boolean
    Private Folder As Objects.ObjectData

    'isloading flag
    Private IsLoading As Boolean = True

#End Region

    Public Sub Init(ByVal CharKey As Objects.ObjectKey)
        _CharacterKey = CharKey
    End Sub

#Region "IPanel"

    Public Property IsDirty() As Boolean Implements IPanel.IsDirty
        Get
            Return _IsDirty
        End Get
        Set(ByVal Value As Boolean)
            _IsDirty = Value
        End Set
    End Property

    Public ReadOnly Property ListView() As System.Windows.Forms.ListView Implements IPanel.ListView
        Get
            Return Nothing
        End Get
    End Property

    Public Sub RefreshPanelData() Implements IPanel.RefreshPanelData

        IsLoading = True

        Folder = General.MainExplorer.ObjectSelectedInTree
        Dim ClassKey As Objects.ObjectKey = Folder.GetFKGuid("Class")
        Dim Character As Rules.Character = CharacterManager.GetCharacter(_CharacterKey)

        SpellSlots = New Rules.SpellSlots(Character, ClassKey)
        SpellSlots.Load()

        SpellSlotsLoaded = True
        Me.SuspendLayout()

        'reset panel positions
        TopPanel.Visible = True
        TopPanel.Enabled = True
        MiddlePanel.Visible = True
        MiddlePanel.Enabled = True
        MiddlePanel.Top = 165 '270
        BottomPanel.Top = 240 '385

        'caster information
        CasterLevel.Text = CType(Character.CurrentLevel.CasterLevels.Item(ClassKey), Rules.Character.CasterLevel).CasterLevel.ToString

        'hide panels as appropriate
        If SpellSlots.ShowSpellsPerDay = False And SpellSlots.ShowSpellsKnown Then
            TopPanel.Enabled = False
            TopPanel.Visible = False
            MiddlePanel.Top = TopPanel.Top
            BottomPanel.Top = MiddlePanel.Top + MiddlePanel.Height
        ElseIf SpellSlots.ShowSpellsKnown = False Then
            MiddlePanel.Enabled = False
            MiddlePanel.Visible = False
            BottomPanel.Top = TopPanel.Top + TopPanel.Height
        End If

        Dim Temp As Integer = Me.Height - BottomPanel.Top
        If Temp > 0 Then BottomPanel.Height = Temp Else BottomPanel.Height = 0

        Me.ResumeLayout()

        'bind data sources
        KnownData = SpellSlots.GetSKDatatable
        SpellsKnownGrid.DataSource = KnownData

        Data = SpellSlots.GetSPDDatatable
        SpellsPerDayGrid.DataSource = Data

        'spell points
        SpellPointsSpin.Value = SpellSlots.SpellPoints + SpellSlots.BonusSpellPoints + SpellSlots.SpellPointsModifier
        'SpellPointsToolTip.Text = " " & SpellSlots.SpellPoints & " Spell Points, " & SpellSlots.BonusSpellPoints & " Bonus Spell Points from Ability Score, " & SpellSlots.SpellPointsModifier & " User Added Spell Points"

        'rest gridview focus
        GridView1.FocusedRowHandle = 0
        GridView1.FocusedColumn = GridView1.Columns.Item(1)
        GridView2.FocusedRowHandle = 0
        GridView2.FocusedColumn = GridView2.Columns.Item(1)

        'rest tool tips - incase focus has not changed
        'ShowTooltip()
        'ShowSKTooltip()

        'load the notes
        SpellNotes.Text = Folder.Element("SpellNotes")

        IsLoading = False

    End Sub

    'save any changes made to the panel
    Public Sub Save() Implements IPanel.Save
        Try

            'save modifiers
            SpellSlots.Save()

            'save spell notes
            If Not Folder.IsEmpty Then
                Folder.Element("SpellNotes") = SpellNotes.Text
            End If

            'update memorized spells
            CharacterManager.GetCharacter(_CharacterKey).GenerateMemorizedSpells()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private _ReadOnly As Boolean = False

    'read-only
    Public WriteOnly Property [ReadOnly]() As Boolean Implements IPanel.ReadOnly
        Set(ByVal value As Boolean)
            If value <> _ReadOnly Then
                _ReadOnly = value
                If _ReadOnly Then
                    Me.SpellPointsSpin.Enabled = False
                    Me.SpellsPerDayGrid.Enabled = False
                    Me.SpellsKnownGrid.Enabled = False
                    Me.SpellNotes.Enabled = False
                Else
                    Me.SpellPointsSpin.Enabled = True
                    Me.SpellsPerDayGrid.Enabled = True
                    Me.SpellsKnownGrid.Enabled = True
                    Me.SpellNotes.Enabled = True
                End If
            End If
        End Set
    End Property

#End Region

#Region "Event Handlers"

    'spd
    Private Column, Row As Integer

    'spells known
    Private SKColumn As Integer

    ''spd tooltip
    'Private Sub ShowTooltip()
    'Try
    '    Select Case Row
    '        Case 0
    '            'spd
    '            Dim ClassSPD, BonusSPD, Modifer As Integer

    '            ClassSPD = CInt(SpellSlots.SpellsPerDay.Item(Column - 1))
    '            BonusSPD = CInt(SpellSlots.BonusSpellsPerDay.Item(Column - 1))
    '            Modifer = CInt(SpellSlots.SpellsPerDayModifiers.Item(Column - 1))

    '            'string data
    '            Dim ClassPlural, BonusPlural, ModiferPlural As String
    '            If ClassSPD = 1 Then ClassPlural = "" Else ClassPlural = "s"
    '            If BonusSPD = 1 Then BonusPlural = "" Else BonusPlural = "s"
    '            If Modifer = 1 Then ModiferPlural = "" Else ModiferPlural = "s"

    '            SPDToolTip.Caption = " " & ClassSPD & " Class Spell" & ClassPlural & ", " & BonusSPD & " Bonus Spell" & BonusPlural & " from Ability Score, " & Modifer & " User Added Spell" & ModiferPlural

    '        Case 1
    '            'domains
    '            Dim DomainSPD, Modifer As Integer

    '            DomainSPD = CInt(SpellSlots.DomainSPD.Item(Column - 1))
    '            Modifer = CInt(SpellSlots.DomainSPDModifiers.Item(Column - 1))

    '            'string data
    '            Dim DomainPlural, ModiferPlural As String
    '            If DomainSPD = 1 Then DomainPlural = "" Else DomainPlural = "s"
    '            If Modifer = 1 Then ModiferPlural = "" Else ModiferPlural = "s"

    '            SPDToolTip.Caption = " " & DomainSPD & " Domain spell" & DomainPlural & ", " & Modifer & " User Added Spell" & ModiferPlural

    '        Case 2
    '            'specialist
    '            Dim SpecialistSPD, Modifer As Integer

    '            SpecialistSPD = CInt(SpellSlots.SpecialistSPD.Item(Column - 1))
    '            Modifer = CInt(SpellSlots.SpecialistSPDModifiers.Item(Column - 1))

    '            'string data
    '            Dim SpecialistPlural, ModiferPlural As String
    '            If SpecialistSPD = 1 Then SpecialistPlural = "" Else SpecialistPlural = "s"
    '            If Modifer = 1 Then ModiferPlural = "" Else ModiferPlural = "s"

    '            SPDToolTip.Caption = " " & SpecialistSPD & " Specialist Spell" & SpecialistPlural & ", " & Modifer & " User Added Spell" & ModiferPlural
    '    End Select
    'Catch ex As Exception
    '    Throw New Exception(ex.Message, ex)
    'End Try
    'End Sub

    'spellsknown tool tip
    'Private Sub ShowSKTooltip()
    'Try

    '    Dim Allowed, Actual, Difference As Integer

    '    Allowed = CInt(SpellSlots.SpellsKnown.Item(SKColumn - 1))
    '    Actual = CInt(SpellSlots.ActualSpellsKnown.Item(SKColumn - 1))
    '    Difference = Actual - Allowed

    '    Dim DifferenceString As String

    '    If Difference > 0 Then
    '        DifferenceString = ", " & Difference & " Extra Spells Known"
    '    ElseIf Difference < 0 Then
    '        DifferenceString = ", " & Math.Abs(Difference) & " Missing Spells Known"
    '    Else
    '        DifferenceString = ""
    '    End If

    '    SpellsKnownToolTip.Caption = " " & Allowed & " Class Spells Known" & DifferenceString

    'Catch ex As Exception
    '    Throw New Exception(ex.Message, ex)
    'End Try
    'End Sub

    'spellsperday spin edit
    Private Sub SPDSpin_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SPDSpin.EditValueChanged
        Try
            Dim SpinEdit As DevExpress.XtraEditors.SpinEdit
            SpinEdit = CType(sender, DevExpress.XtraEditors.SpinEdit)

            Select Case Row

                Case 0
                    'spd
                    Dim ClassSPD, BonusSPD As Integer
                    ClassSPD = CInt(SpellSlots.SpellsPerDay.Item(Column - 1))
                    BonusSPD = CInt(SpellSlots.BonusSpellsPerDay.Item(Column - 1))
                    SpellSlots.SpellsPerDayModifiers.Item(Column - 1) = ((CInt(SpinEdit.Value) - ClassSPD - BonusSPD))

                Case 1
                    'domains
                    Dim DomainSPD As Integer
                    DomainSPD = CInt(SpellSlots.DomainSPD.Item(Column - 1))
                    SpellSlots.DomainSPDModifiers.Item(Column - 1) = ((CInt(SpinEdit.Value) - DomainSPD))

                Case 2
                    'specialist
                    Dim SpecialistSPD As Integer
                    SpecialistSPD = CInt(SpellSlots.SpecialistSPD.Item(Column - 1))
                    SpellSlots.SpecialistSPDModifiers.Item(Column - 1) = ((CInt(SpinEdit.Value) - SpecialistSPD))

            End Select

            _IsDirty = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spell points spin edit
    Private Sub SpellPointsSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellPointsSpin.EditValueChanged
        Try

            If SpellSlotsLoaded Then
                SpellSlots.SpellPointsModifier = CInt(SpellPointsSpin.Value) - SpellSlots.SpellPoints - SpellSlots.BonusSpellPoints
                If SpellSlots.SpellPointsModifier > 0 Then
                    SpellPointsSpin.BackColor = Color.FromArgb(192, 255, 192)
                ElseIf SpellSlots.SpellPointsModifier < 0 Then
                    SpellPointsSpin.BackColor = Color.MistyRose
                Else
                    SpellPointsSpin.BackColor = Color.White
                End If

                SpellPointsSpin.ToolTip = SpellSlots.SpellPoints & " Spell Points, " & SpellSlots.BonusSpellPoints & " Bonus Spell Points from Ability Score, " & SpellSlots.SpellPointsModifier & " User Added Spell Points"
                'SpellPointsToolTip.Caption = SpellSlots.SpellPoints & " + " & SpellSlots.BonusSpellPoints & " Bonus Spell Points + " & SpellSlots.SpellPointsModifier & " User Spell Points"
                'SpellPointsToolTip.Text = " " & SpellSlots.SpellPoints & " Spell Points, " & SpellSlots.BonusSpellPoints & " Bonus Spell Points from Ability Score, " & SpellSlots.SpellPointsModifier & " User Added Spell Points"
            End If

            If Not IsLoading Then
                _IsDirty = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'notes updated
    Private Sub SpellNotes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellNotes.EditValueChanged
        Try
            If Not IsLoading Then
                _IsDirty = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spellsperday column change
    Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        Try
            Column = e.FocusedColumn.VisibleIndex
            'ShowTooltip()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spellsperday row change
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            Row = e.FocusedRowHandle
            'ShowTooltip()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spellsknown column change
    Private Sub GridView2_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView2.FocusedColumnChanged
        Try
            SKColumn = e.FocusedColumn.VisibleIndex
            'ShowSKTooltip()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'got focus - for trapping delete key
#If Not Debug Then
    Private Sub PanelGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpellNotes.GotFocus, GridView2.GotFocus, SpellPointsSpin.GotFocus
        General.MainExplorer.CurrentFocus = Explorer.Focus.ListView
    End Sub
#End If

#End Region

#Region "Custom Painting"

    Private Sub GridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        Try

            'get the column & row numbers
            Dim Column, Row, UserMod As Integer
            Column = e.Column.VisibleIndex : Row = e.RowHandle

            'check to see if this has any user mods
            If Column > 0 Then
                Select Case Row
                    Case 0
                        'spd
                        UserMod = CInt(SpellSlots.SpellsPerDayModifiers.Item(Column - 1))
                    Case 1
                        'domains
                        UserMod = CInt(SpellSlots.DomainSPDModifiers.Item(Column - 1))
                    Case 2
                        'specilaist
                        UserMod = CInt(SpellSlots.SpecialistSPDModifiers.Item(Column - 1))
                End Select
            End If

            'custom painting
            If UserMod > 0 Then
                e.Appearance.BackColor = Color.FromArgb(192, 255, 192)
            ElseIf UserMod < 0 Then
                e.Appearance.BackColor = Color.MistyRose
            End If

            'white font color for zero values
            If Column > 0 AndAlso CType(e.CellValue, Integer) = 0 Then e.Appearance.ForeColor = Color.White

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub GridView2_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView2.CustomDrawCell
        Try

            'get the column & row numbers
            Dim Column, Row, Difference As Integer
            Column = e.Column.VisibleIndex : Row = e.RowHandle

            'check to see if this has any user mods
            If Column > 0 Then
                Difference = CInt(SpellSlots.ActualSpellsKnown.Item(Column - 1)) - CInt(SpellSlots.SpellsKnown.Item(Column - 1))
            End If

            'custom painting
            'If GridView2.IsFocusedView And Column = SKColumn Then
            '    e.Appearance.BackColor = Color.White
            'Else
            If Difference > 0 Then
                e.Appearance.BackColor = Color.FromArgb(192, 255, 192)
            ElseIf Difference < 0 Then
                e.Appearance.BackColor = Color.MistyRose
            End If
            'End If

            'white font color for zero values
            If Column > 0 AndAlso CType(e.CellValue, Integer) = 0 Then e.Appearance.ForeColor = Color.White

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub SpellcasterPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

#End Region

    Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController.GetActiveObjectInfo

        'Get the view at the current mouse position
        Dim View As GridView = Nothing

        If e.SelectedControl Is SpellsPerDayGrid Then
            View = DirectCast(Me.SpellsPerDayGrid.GetViewAt(e.ControlMousePosition), GridView)
        ElseIf e.SelectedControl Is SpellsKnownGrid Then
            View = DirectCast(Me.SpellsKnownGrid.GetViewAt(e.ControlMousePosition), GridView)
        End If
        If View Is Nothing Then Exit Sub

        'Determine the tooltip and set it
        Dim Info As ToolTipControlInfo = Nothing
        Dim HitInfo As GridHitInfo = View.CalcHitInfo(e.ControlMousePosition)

        If HitInfo.Column Is Nothing Then Exit Sub
        If HitInfo.Column.AbsoluteIndex = 0 Then Exit Sub

        Dim Tooltip As String = ""
        If HitInfo.HitTest = GridHitTest.RowCell Then
            If e.SelectedControl Is SpellsPerDayGrid Then
                Select Case HitInfo.RowHandle
                    Case 0
                        'spd
                        Dim ClassSPD, BonusSPD, Modifer As Integer

                        ClassSPD = CInt(SpellSlots.SpellsPerDay.Item(HitInfo.Column.AbsoluteIndex - 1))
                        BonusSPD = CInt(SpellSlots.BonusSpellsPerDay.Item(HitInfo.Column.AbsoluteIndex - 1))
                        Modifer = CInt(SpellSlots.SpellsPerDayModifiers.Item(HitInfo.Column.AbsoluteIndex - 1))

                        'string data
                        Dim ClassPlural, BonusPlural, ModiferPlural As String
                        If ClassSPD = 1 Then ClassPlural = "" Else ClassPlural = "s"
                        If BonusSPD = 1 Then BonusPlural = "" Else BonusPlural = "s"
                        If Modifer = 1 Then ModiferPlural = "" Else ModiferPlural = "s"

                        Tooltip = ClassSPD & " Class Spell" & ClassPlural & ", " & BonusSPD & " Bonus Spell" & BonusPlural & " from Ability Score, " & Modifer & " User Added Spell" & ModiferPlural
                    Case 1
                        'domains
                        Dim DomainSPD, Modifer As Integer

                        DomainSPD = CInt(SpellSlots.DomainSPD.Item(HitInfo.Column.AbsoluteIndex - 1))
                        Modifer = CInt(SpellSlots.DomainSPDModifiers.Item(HitInfo.Column.AbsoluteIndex - 1))

                        'string data
                        Dim DomainPlural, ModiferPlural As String
                        If DomainSPD = 1 Then DomainPlural = "" Else DomainPlural = "s"
                        If Modifer = 1 Then ModiferPlural = "" Else ModiferPlural = "s"

                        Tooltip = DomainSPD & " Domain spell" & DomainPlural & ", " & Modifer & " User Added Spell" & ModiferPlural

                    Case 2
                        'specialist
                        Dim SpecialistSPD, Modifer As Integer

                        SpecialistSPD = CInt(SpellSlots.SpecialistSPD.Item(HitInfo.Column.AbsoluteIndex - 1))
                        Modifer = CInt(SpellSlots.SpecialistSPDModifiers.Item(HitInfo.Column.AbsoluteIndex - 1))

                        'string data
                        Dim SpecialistPlural, ModiferPlural As String
                        If SpecialistSPD = 1 Then SpecialistPlural = "" Else SpecialistPlural = "s"
                        If Modifer = 1 Then ModiferPlural = "" Else ModiferPlural = "s"

                        Tooltip = SpecialistSPD & " Specialist Spell" & SpecialistPlural & ", " & Modifer & " User Added Spell" & ModiferPlural
                End Select
            End If

            Info = New ToolTipControlInfo(HitInfo.Column, Tooltip)
        End If

        'Supply tooltip information
        e.Info = Info
    End Sub

End Class
