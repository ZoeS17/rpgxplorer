Option Strict On
Option Explicit On 

Imports RPGXplorer.General

Public Class SelectPsionicSpecializationPanel
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
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents SpecializationChoices As System.Windows.Forms.ListView
    Public WithEvents PutSpecializationBack As System.Windows.Forms.Button
    Public WithEvents TakeSpecialization As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SelectPsionicSpecializationPanel))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SpecializationChoices = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.PutSpecializationBack = New System.Windows.Forms.Button
        Me.TakeSpecialization = New System.Windows.Forms.Button
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        ''CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 21)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Psionic Specializations"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 21)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Choices available for selected slot"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 225)
        Me.Panel3.TabIndex = 137
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
        Me.AvailableSlots.Size = New System.Drawing.Size(403, 223)
        Me.AvailableSlots.TabIndex = 123
        Me.AvailableSlots.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Level"
        Me.ColumnHeader1.Width = 124
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Bonus Type"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Specialization Taken"
        Me.ColumnHeader3.Width = 155
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SpecializationChoices)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 215)
        Me.Panel2.TabIndex = 136
        '
        'SpecializationChoices
        '
        Me.SpecializationChoices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpecializationChoices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.SpecializationChoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecializationChoices.FullRowSelect = True
        Me.SpecializationChoices.HideSelection = False
        Me.SpecializationChoices.Location = New System.Drawing.Point(1, 1)
        Me.SpecializationChoices.MultiSelect = False
        Me.SpecializationChoices.Name = "SpecializationChoices"
        Me.SpecializationChoices.Size = New System.Drawing.Size(403, 213)
        Me.SpecializationChoices.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.SpecializationChoices.TabIndex = 122
        Me.SpecializationChoices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Psionic Specialization"
        Me.ColumnHeader4.Width = 403
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(435, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 535)
        Me.Panel1.TabIndex = 135
        '
        'Browser
        '        
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.Browser.Enabled = True
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Size = New System.Drawing.Size(498, 533)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'PutSpecializationBack
        '
        Me.PutSpecializationBack.Location = New System.Drawing.Point(285, 290)
        Me.PutSpecializationBack.Name = "PutSpecializationBack"
        Me.PutSpecializationBack.Size = New System.Drawing.Size(135, 24)
        Me.PutSpecializationBack.TabIndex = 133
        Me.PutSpecializationBack.Text = "Put Specialization Back"
        '
        'TakeSpecialization
        '
        Me.TakeSpecialization.Location = New System.Drawing.Point(165, 290)
        Me.TakeSpecialization.Name = "TakeSpecialization"
        Me.TakeSpecialization.Size = New System.Drawing.Size(115, 24)
        Me.TakeSpecialization.TabIndex = 132
        Me.TakeSpecialization.Text = "Take Specialization"
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(230, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please select your psionic specializations"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectPsionicSpecializationPanel
        '
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PutSpecializationBack)
        Me.Controls.Add(Me.TakeSpecialization)
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "SelectPsionicSpecializationPanel"
        Me.Size = New System.Drawing.Size(950, 565)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private Character As Rules.Character
    Private Slots As ArrayList

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As Rules.PsionicSpecialSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, Rules.PsionicSpecialSlot)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

    Private ReadOnly Property SelectedChoice() As Rules.SpecializationChoice
        Get
            Try
                If SpecializationChoices.SelectedItems.Count = 1 Then
                    Return CType(SpecializationChoices.SelectedItems(0).Tag, Rules.SpecializationChoice)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

#End Region

    'initialise this panel
    Public Function Init(ByVal Character As Rules.Character) As Boolean
        Try
            IsInitialised = True
            Me.Character = Character

            LoadSlots()

            If AvailableSlots.Items.Count > 0 Then
                AvailableSlots.Items(0).Selected = True
                AvailableSlots_SelectedIndexChanged(Nothing, Nothing)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'is this panel required?
    Public Function PanelRequired(ByVal Character As Rules.Character) As Boolean
        Try
            Slots = Character.PsionicSpecializations.BonusSpecializationSlots
            If Slots.Count = 0 Then Return False Else Return True
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
            Return 950
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

    'load the slots
    Private Sub LoadSlots()
        Try
            'clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()

            'add each slot to the listview
            For Each Slot As Rules.PsionicSpecialSlot In Slots
                AvailableSlots.Items.Add(SlotListViewItem(Slot))

                'add any specific domains to the character
                If Slot.SlotType = Rules.DomainSlotType.SpecificBonusDomain Then
                    Dim ClassDef As New Objects.ObjectData
                    Dim SpecializationDef As New Objects.ObjectData
                    ClassDef.Load(Character.Levels(Slot.CharacterLevel).ClassGuid)
                    SpecializationDef.Load(Slot.SpecializationTakenKey)
                    Character.PsionicSpecializations.AddSpecialization(SpecializationDef, ClassDef, Slot.CharacterLevel)
                End If
            Next

            AvailableSlots.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'generates a ListViewItem from a slot
    Private Function SlotListViewItem(ByVal Slot As Rules.PsionicSpecialSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = "Level " & Slot.CharacterLevel & " - " & Character.Levels(Slot.CharacterLevel).ClassName & " " & Character.Levels(Slot.CharacterLevel).ClassLevel
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add(Slot.SlotTypeName)
            ListViewItem.SubItems.Add(Slot.SpecializationTakenName)
            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'update domain choice list
    Private Sub UpdateSpecializationChoiceList()
        Try
            'clear list 
            SpecializationChoices.BeginUpdate()
            SpecializationChoices.Items.Clear()

            'get new list
            For Each SpecializationChoice As Rules.SpecializationChoice In Character.PsionicSpecializations.AvailableSpecializationChoices(SelectedSlot)
                SpecializationChoices.Items.Add(SpecializationChoiceListViewItem(SpecializationChoice))
            Next

            SpecializationChoices.EndUpdate()

            If SpecializationChoices.Items.Count > 0 Then
                SpecializationChoices.Items(0).Selected = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load domain choice into list view item
    Private Function SpecializationChoiceListViewItem(ByVal SpecializationChoice As Rules.SpecializationChoice) As ListViewItem
        Try
            Dim ListViewItem As New ListViewItem

            ListViewItem.Text = SpecializationChoice.SpecializationName
            If SpecializationChoice.AlreadyTaken Then
                ListViewItem.ForeColor = Color.DarkGoldenrod
            End If
            ListViewItem.Tag = SpecializationChoice

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'enable/disable next
    Private Sub EnableDisableNext()
        For Each Item As ListViewItem In AvailableSlots.Items
            If Item.SubItems(2).Text = "" Then
                RaiseEvent DisableNext()
                Exit Sub
            End If
        Next

        RaiseEvent EnableNext(False)
    End Sub

    'move to next slot
    Private Sub MoveToNextAvailableSlot()
        For Each Item As ListViewItem In AvailableSlots.Items
            If CType(Item.Tag, Rules.PsionicSpecialSlot).SpecializationTakenName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        Try
            If SelectedSlot.SpecializationTakenName = "" OrElse SelectedSlot.SlotType = Rules.SpecializationSlotType.SpecificBonusSpecialization Then
                Me.PutSpecializationBack.Enabled = False
            Else
                Me.PutSpecializationBack.Enabled = True
                Me.TakeSpecialization.Enabled = False
                Exit Sub
            End If
            If SpecializationChoices.SelectedItems.Count = 0 Then
                Me.TakeSpecialization.Enabled = False
            Else
                If SelectedChoice.AlreadyTaken = True Then
                    Me.TakeSpecialization.Enabled = False
                Else
                    Me.TakeSpecialization.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handlers"

    'handle slot change
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Try
            If AvailableSlots.SelectedItems.Count = 1 Then UpdateSpecializationChoiceList()
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle choice selection
    Private Sub DomainChoices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecializationChoices.SelectedIndexChanged
        Try
            If SpecializationChoices.SelectedItems.Count > 0 Then
                UI.BrowserNavigate(Browser, SelectedChoice.HTML)
            End If

            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle taking a domain
    Private Sub TakeSpecialization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeSpecialization.Click
        Try
            'get the chosen domain and slot
            If (AvailableSlots.SelectedItems.Count + SpecializationChoices.SelectedItems.Count) <> 2 Then Exit Sub

            Dim SpecializationChoice As Rules.SpecializationChoice = SelectedChoice
            Dim Slot As Rules.PsionicSpecialSlot = SelectedSlot

            'update the slot
            Slot.SpecializationTakenName = SpecializationChoice.SpecializationName
            Slot.SpecializationTakenKey = SpecializationChoice.SpecializationKey

            'update the character
            Dim SpecializationDef As New Objects.ObjectData
            SpecializationDef.Load(SpecializationChoice.SpecializationKey)
            Dim ClassDef As New Objects.ObjectData
            ClassDef.Load(Character.Levels(Slot.CharacterLevel).ClassGuid)

            Character.PsionicSpecializations.AddSpecialization(SpecializationDef, ClassDef, Slot.CharacterLevel)

            'update the ui
            AvailableSlots.BeginUpdate()
            Dim SelectedIndex As Integer = AvailableSlots.SelectedItems(0).Index
            AvailableSlots.Items(SelectedIndex) = SlotListViewItem(Slot)
            AvailableSlots.Items(SelectedIndex).Selected = True
            AvailableSlots.Items(SelectedIndex).EnsureVisible()
            AvailableSlots.EndUpdate()
            MoveToNextAvailableSlot()
            EnableDisableButtons()
            EnableDisableNext()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle putting a domain back
    Private Sub PutDomainBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutSpecializationBack.Click
        Try
            If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

            'get the chosen slot and clear it
            Dim Slot As Rules.PsionicSpecialSlot = SelectedSlot

            Dim SpecializationKey As Objects.ObjectKey = Slot.SpecializationTakenKey
            Slot.SpecializationTakenKey = Objects.ObjectKey.Empty
            Slot.SpecializationTakenName = ""

            'update the character
            Character.PsionicSpecializations.RemoveSpecialization(Character.Levels(Slot.CharacterLevel).ClassGuid, SpecializationKey)

            'update the ui
            AvailableSlots.BeginUpdate()
            Dim SelectedIndex As Integer = AvailableSlots.SelectedItems(0).Index
            AvailableSlots.Items(SelectedIndex) = SlotListViewItem(Slot)
            AvailableSlots.Items(SelectedIndex).Selected = True
            AvailableSlots.Items(SelectedIndex).EnsureVisible()
            AvailableSlots.EndUpdate()
            EnableDisableButtons()
            EnableDisableNext()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Paint Events"

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim rect As Rectangle = Panel1.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

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

    Private Sub SpecializationChoices_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpecializationChoices.DoubleClick
        TakeSpecialization_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutDomainBack_Click(Nothing, Nothing)
    End Sub

End Class
