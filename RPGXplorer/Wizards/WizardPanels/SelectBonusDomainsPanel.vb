Option Strict On
Option Explicit On 

Imports RPGXplorer.General

Public Class SelectBonusDomainsPanel
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
    Public WithEvents PutDomainBack As System.Windows.Forms.Button
    Public WithEvents TakeDomain As System.Windows.Forms.Button
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents DomainChoices As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SelectBonusDomainsPanel))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DomainChoices = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.PutDomainBack = New System.Windows.Forms.Button
        Me.TakeDomain = New System.Windows.Forms.Button
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Text = "Bonus Domains"
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
        Me.Label1.Text = "Domain choices available for selected slot"
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
        Me.ColumnHeader3.Text = "Domain Taken"
        Me.ColumnHeader3.Width = 155
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DomainChoices)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 215)
        Me.Panel2.TabIndex = 136
        '
        'DomainChoices
        '
        Me.DomainChoices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DomainChoices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.DomainChoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DomainChoices.FullRowSelect = True
        Me.DomainChoices.HideSelection = False
        Me.DomainChoices.Location = New System.Drawing.Point(1, 1)
        Me.DomainChoices.MultiSelect = False
        Me.DomainChoices.Name = "DomainChoices"
        Me.DomainChoices.Size = New System.Drawing.Size(403, 213)
        Me.DomainChoices.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.DomainChoices.TabIndex = 122
        Me.DomainChoices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Domain"
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
        'PutDomainBack
        '
        Me.PutDomainBack.Location = New System.Drawing.Point(320, 290)
        Me.PutDomainBack.Name = "PutDomainBack"
        Me.PutDomainBack.Size = New System.Drawing.Size(100, 24)
        Me.PutDomainBack.TabIndex = 133
        Me.PutDomainBack.Text = "Put Domain Back"
        '
        'TakeDomain
        '
        Me.TakeDomain.Location = New System.Drawing.Point(210, 290)
        Me.TakeDomain.Name = "TakeDomain"
        Me.TakeDomain.Size = New System.Drawing.Size(100, 24)
        Me.TakeDomain.TabIndex = 132
        Me.TakeDomain.Text = "Take Domain"
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(205, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please select your bonus domains"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectBonusDomainsPanel
        '
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PutDomainBack)
        Me.Controls.Add(Me.TakeDomain)
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "SelectBonusDomainsPanel"
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

    Private ReadOnly Property SelectedSlot() As Rules.DomainSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, Rules.DomainSlot)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

    Private ReadOnly Property SelectedChoice() As Rules.DomainChoice
        Get
            Try
                If DomainChoices.SelectedItems.Count = 1 Then
                    Return CType(DomainChoices.SelectedItems(0).Tag, Rules.DomainChoice)
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
            Slots = Character.Domains.BonusDomainSlots()
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
            For Each Slot As Rules.DomainSlot In Slots
                AvailableSlots.Items.Add(SlotListViewItem(Slot))

                'add any specific domains to the character
                If Slot.SlotType = Rules.DomainSlotType.SpecificBonusDomain Then
                    Dim ClassDef As New Objects.ObjectData
                    Dim DomainDef As New Objects.ObjectData

                    ClassDef.Load(Character.Levels(Slot.CharacterLevel).ClassGuid)
                    DomainDef.Load(Slot.DomainTakenKey)
                    Character.Domains.AddDomain(DomainDef, ClassDef, Slot.CharacterLevel)
                End If
            Next

            AvailableSlots.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'generates a ListViewItem from a slot
    Private Function SlotListViewItem(ByVal Slot As Rules.DomainSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = "Level " & Slot.CharacterLevel & " - " & Character.Levels(Slot.CharacterLevel).ClassName & " " & Character.Levels(Slot.CharacterLevel).ClassLevel
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add(Slot.SlotTypeName)
            ListViewItem.SubItems.Add(Slot.DomainTakenName)
            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'update domain choice list
    Private Sub UpdateDomainChoiceList()
        Try
            'clear list 
            DomainChoices.BeginUpdate()
            DomainChoices.Items.Clear()

            'get new list
            For Each DomainChoice As Rules.DomainChoice In Character.Domains.AvailableDomainChoices(SelectedSlot)
                DomainChoices.Items.Add(DomainChoiceListViewItem(DomainChoice))
            Next

            DomainChoices.EndUpdate()

            If DomainChoices.Items.Count > 0 Then
                DomainChoices.Items(0).Selected = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load domain choice into list view item
    Private Function DomainChoiceListViewItem(ByVal DomainChoice As Rules.DomainChoice) As ListViewItem
        Try
            Dim ListViewItem As New ListViewItem

            ListViewItem.Text = DomainChoice.DomainName
            If DomainChoice.AlreadyTaken Then
                ListViewItem.ForeColor = Color.DarkGoldenrod
            End If
            ListViewItem.Tag = DomainChoice

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
            If CType(Item.Tag, Rules.DomainSlot).DomainTakenName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        Try
            If SelectedSlot.DomainTakenName = "" OrElse SelectedSlot.SlotType = Rules.DomainSlotType.SpecificBonusDomain Then
                Me.PutDomainBack.Enabled = False
            Else
                Me.PutDomainBack.Enabled = True
                Me.TakeDomain.Enabled = False
                Exit Sub
            End If
            If DomainChoices.SelectedItems.Count = 0 Then
                Me.TakeDomain.Enabled = False
            Else
                If SelectedChoice.AlreadyTaken = True Then
                    Me.TakeDomain.Enabled = False
                Else
                    Me.TakeDomain.Enabled = True
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
            If AvailableSlots.SelectedItems.Count = 1 Then UpdateDomainChoiceList()
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle choice selection
    Private Sub DomainChoices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainChoices.SelectedIndexChanged
        Try
            If DomainChoices.SelectedItems.Count > 0 Then
                UI.BrowserNavigate(Browser, SelectedChoice.HTML)
            End If

            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle taking a domain
    Private Sub TakeDomain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeDomain.Click
        Try

            If (AvailableSlots.SelectedItems.Count + DomainChoices.SelectedItems.Count) <> 2 Then Exit Sub

            'get the chosen domain and slot
            Dim DomainChoice As Rules.DomainChoice = SelectedChoice
            Dim Slot As Rules.DomainSlot = SelectedSlot

            If DomainChoice.AlreadyTaken Then Exit Sub

            If Slot.DomainTakenName = "" Then
                'update the slot
                Slot.DomainTakenName = DomainChoice.DomainName
                Slot.DomainTakenKey = DomainChoice.DomainKey

                'update the character
                Dim DomainDef As New Objects.ObjectData
                DomainDef.Load(DomainChoice.DomainKey)
                Dim ClassDef As New Objects.ObjectData
                ClassDef.Load(Character.Levels(Slot.CharacterLevel).ClassGuid)
                Character.Domains.AddDomain(DomainDef, ClassDef, Slot.CharacterLevel)

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
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle putting a domain back
    Private Sub PutDomainBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutDomainBack.Click
        Try

            If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

            'get the chosen slot and clear it
            Dim Slot As Rules.DomainSlot = SelectedSlot
            If Slot.DomainTakenKey.IsEmpty Then Exit Sub

            Dim DomainKey As Objects.ObjectKey = Slot.DomainTakenKey
            Slot.DomainTakenKey = Objects.ObjectKey.Empty
            Slot.DomainTakenName = ""

            'update the character
            Character.Domains.RemoveDomain(Character.Levels(Slot.CharacterLevel).ClassGuid, DomainKey)

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

    Private Sub DomainChoices_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DomainChoices.DoubleClick
        TakeDomain_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutDomainBack_Click(Nothing, Nothing)
    End Sub

End Class
