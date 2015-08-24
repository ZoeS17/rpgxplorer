Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class ExistingSpellcasterProgression
    Inherits RPGXplorer.PanelBase
    Implements IWizardPanel

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents AvailableSpells As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents PutSpellBack As System.Windows.Forms.Button
    Public WithEvents TakeSpell As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableSpells = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.PutSpellBack = New System.Windows.Forms.Button
        Me.TakeSpell = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(325, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please select the classes you wish to advance"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 345)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 175)
        Me.Panel3.TabIndex = 139
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.AvailableSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSlots.FullRowSelect = True
        Me.AvailableSlots.HideSelection = False
        Me.AvailableSlots.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSlots.MultiSelect = False
        Me.AvailableSlots.Name = "AvailableSlots"
        Me.AvailableSlots.Size = New System.Drawing.Size(408, 173)
        Me.AvailableSlots.TabIndex = 123
        Me.AvailableSlots.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Class Name"
        Me.ColumnHeader1.Width = 159
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Class Level"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Class Taken"
        Me.ColumnHeader3.Width = 156
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableSpells)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 250)
        Me.Panel2.TabIndex = 138
        '
        'AvailableSpells
        '
        Me.AvailableSpells.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSpells.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.AvailableSpells.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSpells.FullRowSelect = True
        Me.AvailableSpells.HideSelection = False
        Me.AvailableSpells.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSpells.MultiSelect = False
        Me.AvailableSpells.Name = "AvailableSpells"
        Me.AvailableSpells.Size = New System.Drawing.Size(408, 248)
        Me.AvailableSpells.TabIndex = 122
        Me.AvailableSpells.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Spellcasting/Manifesting Class"
        Me.ColumnHeader4.Width = 392
        '
        'PutSpellBack
        '
        Me.PutSpellBack.Location = New System.Drawing.Point(335, 310)
        Me.PutSpellBack.Name = "PutSpellBack"
        Me.PutSpellBack.Size = New System.Drawing.Size(90, 24)
        Me.PutSpellBack.TabIndex = 137
        Me.PutSpellBack.Text = "Put Class Back"
        '
        'TakeSpell
        '
        Me.TakeSpell.Location = New System.Drawing.Point(240, 310)
        Me.TakeSpell.Name = "TakeSpell"
        Me.TakeSpell.Size = New System.Drawing.Size(90, 24)
        Me.TakeSpell.TabIndex = 136
        Me.TakeSpell.Text = "Take Class"
        '
        'ExistingSpellcasterProgression
        '
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PutSpellBack)
        Me.Controls.Add(Me.TakeSpell)
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "ExistingSpellcasterProgression"
        Me.Size = New System.Drawing.Size(450, 545)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private Character As Rules.Character
    Private ExistingCharacter As Rules.Character

    Private LastShownSpellcaster As String
    Private SpellcastersTaken As Integer
    Private SlotCount As Integer

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As Rules.AvailableSpellcasters.SpellcasterSlot
        Get
            Try

                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableSpellcasters.SpellcasterSlot)
                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("No slot selected")
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

#End Region

    Public Function Init(ByVal Character As Rules.Character, ByVal ExistingCharacter As Rules.Character) As Boolean
        IsInitialised = True
        Me.Character = Character
        Me.ExistingCharacter = ExistingCharacter

        Character.AvailableSpellcasters.Init(ExistingCharacter)
        LoadSlots()

        If SlotCount > 0 Then
            AvailableSlots.Items(0).Selected = True
            Return True
        Else
            Return False
        End If

    End Function

    'Load the slots for the currently selected class
    Private Function LoadSlots() As Integer
        Dim Slots As ArrayList
        Dim Slot As Rules.AvailableSpellcasters.SpellcasterSlot

        Try
            'Get the slots for the current class
            Slots = Character.AvailableSpellcasters.AvailableSpellcasterSlots

            'Clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()
            SlotCount = 0
            SpellcastersTaken = 0

            'Add each slot to the listview
            For Each Slot In Slots
                SlotCount += 1
                AvailableSlots.Items.Add(LoadSlot(Slot))
            Next

            AvailableSlots.EndUpdate()

            Return SlotCount

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Generates a ListViewItem from a spell slot
    Private Function LoadSlot(ByVal Slot As Rules.AvailableSpellcasters.SpellcasterSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem
        Try
            ListViewItem.Text = Slot.PrestigeClassName
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add(Character.Levels(Slot.CharacterLevel).ClassLevel.ToString)
            ListViewItem.SubItems.Add(Slot.ExistingSpellcasterName)

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Gets the list of avialable spell casters based on the current class and the selected slot
    Private Sub UpdateSpellcasterList()
        Dim SpellcasterList As New ArrayList
        Dim SpellcasterInfo As Rules.AvailableSpellcasters.AvailableSpellcaster

        Try
            AvailableSpells.BeginUpdate()
            AvailableSpells.Items.Clear()

            SpellcasterList = Character.AvailableSpellcasters.AvailableSpellcastersList(SelectedSlot)

            'add the spells to the list
            For Each SpellcasterInfo In SpellcasterList
                AvailableSpells.Items.Add(LoadSpell(SpellcasterInfo))
            Next

            'show current spell if any
            If LastShownSpellcaster <> "" Then
                For Each Item As ListViewItem In AvailableSpells.Items
                    If Item.Text = LastShownSpellcaster Then
                        Item.Selected = True
                        Item.EnsureVisible()
                        AvailableSpells.EndUpdate()
                        Exit Sub
                    End If
                Next
            End If

            If AvailableSpells.Items.Count > 0 Then
                AvailableSpells.Items(0).Selected = True
            End If
            AvailableSpells.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creats a listviewitem for a spell caster
    Private Function LoadSpell(ByVal SpellInfo As Rules.AvailableSpellcasters.AvailableSpellcaster) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = SpellInfo.SpellcasterName
            ListViewItem.Tag = SpellInfo
            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext
    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised
        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 450
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 650
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel
        EnableDisableNext()
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot As Rules.AvailableSpellcasters.SpellcasterSlot
        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Slot = SelectedSlot()
                UpdateSpellcasterList()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AvailableSpells_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSpells.SelectedIndexChanged
        Try

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub TakeSpellcaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeSpell.Click

        Dim Slot As Rules.AvailableSpellcasters.SpellcasterSlot
        Dim Spellcaster As Rules.AvailableSpellcasters.AvailableSpellcaster
        Dim NewChoice As New Rules.Character.CharacterChoice
        Dim SlotIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailableSpells.SelectedItems.Count) <> 2 Then Exit Sub

        'get the spell and the slot
        Spellcaster = CType(AvailableSpells.SelectedItems(0).Tag, Rules.AvailableSpellcasters.AvailableSpellcaster)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableSpellcasters.SpellcasterSlot)

        If Slot.ExistingSpellcasterName = "" Then

            Slot.ExistingSpellcasterName = Spellcaster.SpellcasterName
            Slot.ExistingSpellcasterGuid = Spellcaster.SpellcasterGuid

            AvailableSlots.BeginUpdate()
            SlotIndex = AvailableSlots.SelectedIndices(0)
            AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

            'Add to character
            NewChoice.ClassName = Slot.PrestigeClassName
            NewChoice.ClassGuid = Slot.PrestigeClassGuid
            NewChoice.LevelAcquired = Slot.CharacterLevel
            NewChoice.Data = Slot.ExistingSpellcasterName
            NewChoice.DataGuid = Slot.ExistingSpellcasterGuid
            NewChoice.Type = Rules.Character.ChoiceType.SpellcasterChoice
            Character.PrestigeSpellcasterChoices.AddItem(NewChoice.DataGuid, NewChoice, Slot.CharacterLevel)
            AvailableSlots.EndUpdate()

            LastShownSpellcaster = Spellcaster.SpellcasterName
            SpellcastersTaken += 1
            EnableDisableNext()
            MoveToNextAvailableSlot(SlotIndex)

        End If

    End Sub

    Private Sub PutSpellcasterBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutSpellBack.Click
        Dim Slot As Rules.AvailableSpellcasters.SpellcasterSlot
        Dim SlotIndex As Integer

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        Slot = SelectedSlot
        If Slot.ExistingSpellcasterName = "" Then Exit Sub

        Character.PrestigeSpellcasterChoices.RemoveItem(Slot.ExistingSpellcasterGuid, Slot.CharacterLevel)
        Slot.ExistingSpellcasterGuid = Nothing
        Slot.ExistingSpellcasterName = Nothing

        SlotIndex = AvailableSlots.SelectedIndices(0)
        AvailableSlots.BeginUpdate()
        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()
        SpellcastersTaken -= 1
        EnableDisableNext()

    End Sub

#End Region

    'move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        Dim Slot As Rules.AvailableSpellcasters.SpellcasterSlot

        For Each Item As ListViewItem In AvailableSlots.Items
            Slot = CType(Item.Tag, Rules.AvailableSpellcasters.SpellcasterSlot)
            If Slot.ExistingSpellcasterName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next

        AvailableSlots.Items(PreviousIndex).Selected = True
        AvailableSlots.EnsureVisible(PreviousIndex)

    End Sub

    'enable/disable next
    Private Sub EnableDisableNext()
        If SpellcastersTaken = SlotCount Then
            RaiseEvent EnableNext(False)
        Else
            RaiseEvent DisableNext()
        End If
    End Sub

#Region "Paint Events"

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Dim rect As Rectangle = Panel2.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        Dim rect As Rectangle = Panel3.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

#End Region

#Region "Column Sorting"

    'vars
    Private SortColumn As Integer
    Private SortDirection As Windows.Forms.SortOrder

    'sort columns
    Private Sub AvailableSpells_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles AvailableSpells.ColumnClick
        Dim SortType As General.SortType

        HandleSortToggle(e.Column)

        Select Case e.Column
            Case 0
                SortType = SortType.Alphabetic
            Case 1
                SortType = SortType.Numeric
            Case 2
                SortType = SortType.Alphabetic
        End Select

        AvailableSpells.ListViewItemSorter = New Sorter.ListViewItemComparer(SortType, e.Column, SortDirection)
        AvailableSpells.Sort()
    End Sub

    'sort columns
    Private Sub AvailableSlots_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles AvailableSlots.ColumnClick
        Dim SortType As General.SortType

        HandleSortToggle(e.Column)

        Select Case e.Column
            Case 0
                SortType = SortType.NumericSuffix
            Case 1
                SortType = SortType.Alphabetic
            Case 2
                SortType = SortType.Numeric
            Case 3
                SortType = SortType.Alphabetic
        End Select

        AvailableSlots.ListViewItemSorter = New Sorter.ListViewItemComparer(SortType, e.Column, SortDirection)
        AvailableSlots.Sort()
    End Sub

    'handle sort direction toggling
    Private Sub HandleSortToggle(ByVal ColumnIndex As Integer)
        If SortColumn = ColumnIndex Then
            Select Case SortDirection
                Case SortOrder.None
                    SortDirection = SortOrder.Ascending
                Case SortOrder.Ascending
                    SortDirection = SortOrder.Descending
                Case SortOrder.Descending
                    SortDirection = SortOrder.Ascending
            End Select
        End If
        SortColumn = ColumnIndex
    End Sub

#End Region

    'double click code
    Private Sub AvailableSpells_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSpells.DoubleClick
        TakeSpellcaster_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutSpellcasterBack_Click(Nothing, Nothing)
    End Sub

End Class
