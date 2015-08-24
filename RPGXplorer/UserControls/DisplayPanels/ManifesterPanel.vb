Option Strict On
Option Explicit On

Imports DevExpress.XtraGrid

Public Class ManifesterPanel
    Inherits DevExpress.XtraEditors.XtraUserControl
    Implements IPanel

#Region "Member Variables"

    Private _CharacterKey As Objects.ObjectKey
    Private PowerPoints As Rules.PowerPoints
    Private _IsDirty As Boolean
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

        PowerPoints = New Rules.PowerPoints(Character, ClassKey)

        'caster information
        CasterLevel.Text = CType(Character.CurrentLevel.CasterLevels.Item(ClassKey), Rules.Character.CasterLevel).CasterLevel.ToString

        'power points
        PowerPointsSpin.Value = PowerPoints.PowerPoints

        'powers known
        Dim PowersKnown As Integer = PowerPoints.ActualPowersKnown
        PowersKnownBox.Text = PowersKnown.ToString

        ShowPowersKnownTooltip()

        'load the notes
        SpellNotes.Text = Folder.Element("PsionicNotes")

        IsLoading = False
    End Sub

    'save any changes made to the panel
    Public Sub Save() Implements IPanel.Save
        Try

            'save modifiers
            PowerPoints.Save()

            'save spell notes
            If Not Folder.IsEmpty Then
                Folder.Element("PsionicNotes") = SpellNotes.Text
            End If

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
                    Me.PowerPointsSpin.Enabled = False
                    Me.SpellNotes.Enabled = False
                Else
                    Me.PowerPointsSpin.Enabled = True
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


    'PowersKnown tool tip
    Private Sub ShowPowersKnownTooltip()
        Try

            Dim Allowed, Actual, Difference As Integer

            Allowed = PowerPoints.PowersKnown
            Actual = PowerPoints.ActualPowersKnown

            Difference = Actual - Allowed

            Dim DifferenceString As String
            If Difference > 0 Then
                DifferenceString = ", " & Difference & " Extra Powers Known"
                PowersKnownBox.BackColor = Color.FromArgb(192, 255, 192)
            ElseIf Difference < 0 Then
                DifferenceString = ", " & Math.Abs(Difference) & " Missing Powers Known"
                PowersKnownBox.BackColor = Color.MistyRose
            Else
                DifferenceString = ""
                PowersKnownBox.BackColor = Color.White
            End If

            Dim ToolText As String = Allowed & " Class Powers Known" & DifferenceString
            ToolTipController.SetToolTip(PowersKnownBox, ToolText)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'spell points spin edit
    Private Sub PowerPointsSpin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerPointsSpin.EditValueChanged
        Try

            If Not PowerPoints Is Nothing Then
                PowerPoints.UserPowerPointsModifier = CInt(PowerPointsSpin.Value) - PowerPoints.NonUserPowerPoints
                If PowerPoints.UserPowerPointsModifier > 0 Then
                    PowerPointsSpin.BackColor = Color.FromArgb(192, 255, 192)
                ElseIf PowerPoints.UserPowerPointsModifier < 0 Then
                    PowerPointsSpin.BackColor = Color.MistyRose
                Else
                    PowerPointsSpin.BackColor = Color.White
                End If

                Dim ToolText As String = PowerPoints.ClassPowerPoints & " Class Points, " & PowerPoints.AblityScorePowerPoints & " Bonus Ability Points, " & PowerPoints.PowerPointsModifer & " Modifier Points, " & PowerPoints.UserPowerPointsModifier & " User Points"
                ToolTipController.SetToolTip(PowerPointsSpin, ToolText)
                PowerPointsSpin.ToolTip = ToolText
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

    'got focus - for trapping delete key
    Private Sub PanelGotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerPointsSpin.GotFocus, SpellNotes.GotFocus
        General.MainExplorer.CurrentFocus = Explorer.Focus.ListView
    End Sub

#End Region

#Region "Custom Painting"

    Private Sub SpellcasterPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Dim rect As Rectangle

        Try
            'If Me.Width > 0 And Me.Height > 0 Then
            '    rect = New Rectangle(0, 0, Me.Width, Me.Height)
            '    Dim gradbrush As New Drawing2D.LinearGradientBrush(rect, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.ForwardDiagonal)

            '    e.Graphics.FillRectangle(gradbrush, rect)
            'End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SpellcasterPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

#End Region

End Class
