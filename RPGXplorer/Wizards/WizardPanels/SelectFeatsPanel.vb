Option Strict On
Option Explicit On

Imports RPGXplorer.General

Imports System.ComponentModel
Imports System.Threading

Public Class SelectFeatsPanel
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
    Public WithEvents TakeFeat As System.Windows.Forms.Button
    Public WithEvents PutFeatBack As System.Windows.Forms.Button
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents AvailableFeats As System.Windows.Forms.ListView
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents FeatLegend As System.Windows.Forms.Button
    Public WithEvents IgnoreCheck As System.Windows.Forms.CheckBox
    Public WithEvents FilterBar As RPGXplorer.WizardFilterBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.TakeFeat = New System.Windows.Forms.Button
        Me.PutFeatBack = New System.Windows.Forms.Button
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableFeats = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.FeatLegend = New System.Windows.Forms.Button
        Me.IgnoreCheck = New System.Windows.Forms.CheckBox
        Me.FilterBar = New RPGXplorer.WizardFilterBar
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(145, 21)
        Me.ObjLabel.TabIndex = 94
        Me.ObjLabel.Text = "Please select your feats"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TakeFeat
        '
        Me.TakeFeat.Enabled = False
        Me.TakeFeat.Location = New System.Drawing.Point(240, 330)
        Me.TakeFeat.Name = "TakeFeat"
        Me.TakeFeat.Size = New System.Drawing.Size(90, 24)
        Me.TakeFeat.TabIndex = 1
        Me.TakeFeat.Text = "Take Feat"
        '
        'PutFeatBack
        '
        Me.PutFeatBack.Enabled = False
        Me.PutFeatBack.Location = New System.Drawing.Point(335, 330)
        Me.PutFeatBack.Name = "PutFeatBack"
        Me.PutFeatBack.Size = New System.Drawing.Size(90, 24)
        Me.PutFeatBack.TabIndex = 2
        Me.PutFeatBack.Text = "Put Feat Back"
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(493, 533)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.Location = New System.Drawing.Point(440, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(495, 535)
        Me.Panel1.TabIndex = 127
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableFeats)
        Me.Panel2.Location = New System.Drawing.Point(15, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(410, 220)
        Me.Panel2.TabIndex = 128
        '
        'AvailableFeats
        '
        Me.AvailableFeats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableFeats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.AvailableFeats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableFeats.FullRowSelect = True
        Me.AvailableFeats.HideSelection = False
        Me.AvailableFeats.Location = New System.Drawing.Point(1, 1)
        Me.AvailableFeats.MultiSelect = False
        Me.AvailableFeats.Name = "AvailableFeats"
        Me.AvailableFeats.Size = New System.Drawing.Size(408, 218)
        Me.AvailableFeats.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableFeats.TabIndex = 122
        Me.AvailableFeats.UseCompatibleStateImageBehavior = False
        Me.AvailableFeats.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Feat"
        Me.ColumnHeader4.Width = 258
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Feat Type"
        Me.ColumnHeader5.Width = 130
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.Location = New System.Drawing.Point(15, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(410, 185)
        Me.Panel3.TabIndex = 129
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
        Me.AvailableSlots.Size = New System.Drawing.Size(408, 183)
        Me.AvailableSlots.TabIndex = 123
        Me.AvailableSlots.UseCompatibleStateImageBehavior = False
        Me.AvailableSlots.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Level"
        Me.ColumnHeader1.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Slot"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Feat Taken"
        Me.ColumnHeader3.Width = 207
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 21)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Feats available for selected slot and level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FeatLegend
        '
        Me.FeatLegend.Location = New System.Drawing.Point(15, 330)
        Me.FeatLegend.Name = "FeatLegend"
        Me.FeatLegend.Size = New System.Drawing.Size(90, 24)
        Me.FeatLegend.TabIndex = 132
        Me.FeatLegend.Text = "Feat Legend"
        '
        'IgnoreCheck
        '
        Me.IgnoreCheck.Location = New System.Drawing.Point(300, 40)
        Me.IgnoreCheck.Name = "IgnoreCheck"
        Me.IgnoreCheck.Size = New System.Drawing.Size(125, 24)
        Me.IgnoreCheck.TabIndex = 141
        Me.IgnoreCheck.Text = "Ignore Prerequisites"
        '
        'FilterBar
        '
        Me.FilterBar.Location = New System.Drawing.Point(15, 70)
        Me.FilterBar.Name = "FilterBar"
        Me.FilterBar.Size = New System.Drawing.Size(410, 25)
        Me.FilterBar.TabIndex = 142
        '
        'SelectFeatsPanel
        '
        Me.Controls.Add(Me.FilterBar)
        Me.Controls.Add(Me.IgnoreCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PutFeatBack)
        Me.Controls.Add(Me.TakeFeat)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.FeatLegend)
        Me.Name = "SelectFeatsPanel"
        Me.Size = New System.Drawing.Size(950, 565)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised, AllowTakeFeat, SlotAllow As Boolean
    Private CurrentLevel, LevelsToAdd As Integer
    Private Character, ExistingCharacter As Rules.Character
    Private SelectedSlot As Rules.AvailableFeats.FeatSlot

    Private LastShownFeat As String
    Private PreviousURL As String
    Private FeatsTaken As Integer
    Private SlotCount As Integer

    Private IsLoading As Boolean

    Private NaturalAttacks As Hashtable

#End Region

    'initialise this panel
    Public Function Init(ByVal Character As Rules.Character, ByVal ExistingCharacter As Rules.Character, ByVal LevelsToAdd As Integer) As Boolean
        Try
            IsLoading = True
            IsInitialised = True
            If Me.Character IsNot Nothing Then StopUpdateFeatWorker()

            Me.Character = Character
            If General.Config.Element("WizardIgnoreFeatPrereqCheck") = "True" Then IgnoreCheck.Checked = True
            Character.Prerequisites.Begin()
            Me.ExistingCharacter = ExistingCharacter
            Me.LevelsToAdd = LevelsToAdd
            CurrentLevel = ExistingCharacter.CharacterLevel
            FeatsTaken = 0

            'filterbar
            FilterBar.Init(Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FeatDefinitionsFolderType & "']"), Nothing)

            LoadSlots()

            IsLoading = False

            If AvailableSlots.Items.Count > 0 Then
                MoveToNextAvailableSlot(0)
                Return True
            Else
                Return False
            End If

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
        IsInitialised = True
    End Sub

#End Region

#Region "Functions"

    Private UpdateFeatsThread As Thread

    'thread work method
    Private Sub ThreadUpdateFeats()
        AddHandler Character.AvailableFeats.FeatReady, AddressOf UpdateFeatThread_FeatsReady
        Character.AvailableFeats.AvailableFeatListForThread(SelectedSlot.CharacterLevel, SelectedSlot, IgnoreCheck.Checked, FilterBar)
    End Sub

    'thread event handler to process a feat when the prereqs have been checked.
    Private Sub UpdateFeatThread_FeatsReady(ByVal Feats As ArrayList)
        Dim Items As New List(Of ListViewItem)
        For Each Feat As Rules.AvailableFeats.AvailableFeat In Feats
            Items.Add(LoadFeat(Feat))
        Next
        Me.Invoke(AddFeats, New Object() {Items})
    End Sub

    'add the feat provided by the thread to the list view (occurs in main thread)
    Private Sub UpdateFeatThread_AddFeats(ByVal Items As List(Of ListViewItem))
        AvailableFeats.BeginUpdate()
        AvailableFeats.Items.AddRange(Items.ToArray)
        AvailableFeats.EndUpdate()
    End Sub

    'delegate and pointer for callback to main thread (for listview ops)
    Private Delegate Sub AddFeatPointer(ByVal Items As List(Of ListViewItem))
    Private AddFeats As AddFeatPointer

    'stop the worker thread
    Private Sub StopUpdateFeatWorker()
        RemoveHandler Character.AvailableFeats.FeatReady, AddressOf UpdateFeatThread_FeatsReady
        If UpdateFeatsThread IsNot Nothing AndAlso UpdateFeatsThread.IsAlive Then
            UpdateFeatsThread.Abort()
            Do While UpdateFeatsThread.IsAlive
                Thread.Sleep(50)
            Loop
        End If
    End Sub

    'update the list of available feats (thread)
    Private Sub UpdateFeatListUsingThread()
        'disable sorting
        AvailableFeats.Sorting = SortOrder.None

        'clear list view
        AvailableFeats.Items.Clear()

        'set pointer to main thread sub for adding items to listview
        AddFeats = New AddFeatPointer(AddressOf UpdateFeatThread_AddFeats)

        'start thread 
        UpdateFeatsThread = New Thread(AddressOf ThreadUpdateFeats)
        UpdateFeatsThread.Start()
    End Sub

    'update the list of available feats
    Private Sub UpdateFeatList()
        Dim FeatList As New ArrayList
        Dim FeatInfo As Rules.AvailableFeats.AvailableFeat

        Try
            'wait for previous thread to finish
            StopUpdateFeatWorker()

            Select Case SelectedSlot.SlotType
                Case Rules.AvailableFeats.FeatSlotType.BonusFeat, Rules.AvailableFeats.FeatSlotType.ExistingEdit, Rules.AvailableFeats.FeatSlotType.UserAdded, Rules.AvailableFeats.FeatSlotType.FighterBonusFeat
                    'load by thread
                    UpdateFeatListUsingThread()
                    Exit Sub
                Case Else
                    'normal loading 
            End Select

            AvailableFeats.BeginUpdate()
            AvailableFeats.Sorting = SortOrder.Ascending
            AvailableFeats.Items.Clear()

            FeatList = Character.AvailableFeats.AvailableFeatList(SelectedSlot.CharacterLevel, SelectedSlot, IgnoreCheck.Checked, FilterBar)

            'add the feats to the list
            For Each FeatInfo In FeatList
                AvailableFeats.Items.Add(LoadFeat(FeatInfo))
            Next

            'show current feat if any
            If LastShownFeat <> "" Then
                For Each Item As ListViewItem In AvailableFeats.Items
                    If Item.Text = LastShownFeat Then
                        Item.Selected = True
                        Item.EnsureVisible()
                        AvailableFeats.EndUpdate()
                        Exit Sub
                    End If
                Next
            End If

            If AvailableFeats.Items.Count > 0 Then
                AvailableFeats.Items(0).Selected = True
            End If
            AvailableFeats.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'create a listview item for an available feat
    Private Function LoadFeat(ByVal FeatInfo As Rules.AvailableFeats.AvailableFeat) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            If FeatInfo.FocusGuid.IsNotEmpty Then
                ListViewItem.Text = FeatInfo.FeatName & " (" & FeatInfo.FocusName & ")"
            Else
                ListViewItem.Text = FeatInfo.FeatName
            End If

            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, FeatInfo.FeatType))
            ListViewItem.Tag = FeatInfo

            Select Case FeatInfo.Status
                Case Rules.AvailableFeats.AvailableFeatStatus.AlreadyHave
                    ListViewItem.ForeColor = Rules.Constants.TakenFeatColor
                Case Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesMet, Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesMetSelectFocus
                    If FeatInfo.FighterBonus Then
                        ListViewItem.ForeColor = Rules.Constants.FighterBonusFeatColor
                    Else
                        ListViewItem.ForeColor = Rules.Constants.NormalFeatColor
                    End If
                Case Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesNotMet
                    ListViewItem.ForeColor = Rules.Constants.FailedFeatColor
            End Select

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'load the feat slots
    Private Sub LoadSlots()
        Dim Slots As ArrayList
        Dim Slot As Rules.AvailableFeats.FeatSlot

        Try
            Slots = Character.AvailableFeats.AvailableFeatSlots(ExistingCharacter, LevelsToAdd)

            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()

            'add the slots to the list
            For Each Slot In Slots
                AvailableSlots.Items.Add(LoadSlot(Slot))
            Next

            AvailableSlots.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'create a listview item for a feat slot
    Private Function LoadSlot(ByVal Slot As Rules.AvailableFeats.FeatSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = "Level " & Slot.CharacterLevel.ToString
            ListViewItem.Tag = Slot

            Select Case Slot.SlotType
                Case Rules.AvailableFeats.FeatSlotType.BonusFeat
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Bonus Feat"))
                Case Rules.AvailableFeats.FeatSlotType.FighterBonusFeat
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Fighter Bonus Feat"))
                Case Rules.AvailableFeats.FeatSlotType.SpecificBonusFeatChooseFocus
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Choose Focus for Specific Feat"))
                Case Rules.AvailableFeats.FeatSlotType.SpecificBonusFeat
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Specific Bonus Feat"))
                Case Rules.AvailableFeats.FeatSlotType.ChoosePathFeat
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Combat Style Feat"))
                Case Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Choose Feat"))
                Case Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Combat Style Continuation"))
                Case Rules.AvailableFeats.FeatSlotType.ChooseFeatOfType
                    ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, "Choose Feat of Type"))
            End Select

            If Slot.FocusName = "" Then
                ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, Slot.FeatName))
            Else
                ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, Slot.FeatName & " (" & Slot.FocusName & ")"))
            End If

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'find the available feat's list view item
    Private Function GetAvailableFeat(ByVal FeatGuid As Objects.ObjectKey) As ListViewItem
        Dim ListViewItem As ListViewItem

        Try
            For Each ListViewItem In AvailableFeats.Items
                If CType(ListViewItem.Tag, Rules.AvailableFeats.AvailableFeat).FeatGuid.Equals(FeatGuid) Then
                    Return ListViewItem
                End If
            Next

            Return Nothing

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Event Handlers"

    'show help for the selected feat
    Private Sub AvailableFeats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableFeats.SelectedIndexChanged
        Dim FeatInfo As Rules.AvailableFeats.AvailableFeat

        Try
            If AvailableFeats.SelectedItems.Count > 0 Then
                FeatInfo = CType(AvailableFeats.SelectedItems(0).Tag, Rules.AvailableFeats.AvailableFeat)

                'If FeatInfo.FeatName <> LastFeatShown Then
                '    If FeatInfo.HTML.StartsWith("http:\\") Then
                '        Browser.Navigate(FeatInfo.HTML)
                '    Else
                '        Browser.Navigate("file://" & General.HelpPath & FeatInfo.HTML)
                '    End If
                '    LastFeatShown = FeatInfo.FeatName
                'End If

                Dim URL As String
                If FeatInfo.HTML.IndexOf(":\") = 1 And IO.File.Exists(FeatInfo.HTML) Then
                    URL = "file://" & FeatInfo.HTML
                Else
                    If IO.File.Exists(General.HelpPath & FeatInfo.HTML) Then
                        URL = "file://" & General.HelpPath & FeatInfo.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL

                Select Case FeatInfo.Status
                    Case Rules.AvailableFeats.AvailableFeatStatus.AlreadyHave, Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesNotMet
                        AllowTakeFeat = False
                    Case Else
                        AllowTakeFeat = True
                End Select

                If SlotAllow And AllowTakeFeat Then
                    TakeFeat.Enabled = True
                Else
                    TakeFeat.Enabled = False
                End If

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the new list of feats for the selected slot
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Try
            StopUpdateFeatWorker()

            If AvailableSlots.SelectedItems.Count = 1 Then
                SelectedSlot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableFeats.FeatSlot)

                Select Case SelectedSlot.SlotType
                    Case Rules.AvailableFeats.FeatSlotType.BonusFeat, Rules.AvailableFeats.FeatSlotType.FighterBonusFeat, Rules.AvailableFeats.FeatSlotType.ChoosePathFeat, Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat, Rules.AvailableFeats.FeatSlotType.SpecificBonusFeatChooseFocus, Rules.AvailableFeats.FeatSlotType.ChooseFeatOfType

                        UpdateFeatList()
                        If SelectedSlot.FeatName = "" Then
                            SlotAllow = True
                            PutFeatBack.Enabled = False
                        Else
                            SlotAllow = False
                            PutFeatBack.Enabled = True
                        End If

                    Case Rules.AvailableFeats.FeatSlotType.SpecificBonusFeat, Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat
                        SlotAllow = False
                        PutFeatBack.Enabled = False
                        AvailableFeats.Items.Clear()
                End Select

                If SlotAllow And AllowTakeFeat Then
                    TakeFeat.Enabled = True
                Else
                    TakeFeat.Enabled = False
                End If

            End If

            If SelectedSlot.FeatGuid.IsNotEmpty Then
                Dim Feat As Objects.ObjectData
                Feat = Caches.Feats.Item(SelectedSlot.FeatGuid)
                Dim URL As String
                If Feat.HTML.IndexOf(":\") = 1 And IO.File.Exists(Feat.HTML) Then
                    URL = "file://" & Feat.HTML
                Else
                    If IO.File.Exists(General.HelpPath & Feat.HTML) Then
                        URL = "file://" & General.HelpPath & Feat.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL
            End If

            'Clear last shown feat
            LastShownFeat = ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add this feat to the list of feats taken
    Private Sub TakeFeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeFeat.Click
        Dim Slot, TempSlot As Rules.AvailableFeats.FeatSlot
        Dim Feat As Rules.AvailableFeats.AvailableFeat
        Dim NewFeat As New Rules.Character.Feat
        Dim SlotIndex As Integer
        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1

        Try
            If TakeFeat.Enabled = False Then Exit Sub

            If (AvailableSlots.SelectedItems.Count + AvailableFeats.SelectedItems.Count) <> 2 Then Exit Sub

            'get the feat and the slot
            Feat = CType(AvailableFeats.SelectedItems(0).Tag, Rules.AvailableFeats.AvailableFeat)
            Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableFeats.FeatSlot)

            Select Case Slot.SlotType
                Case Rules.AvailableFeats.FeatSlotType.BonusFeat, Rules.AvailableFeats.FeatSlotType.FighterBonusFeat, Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat, Rules.AvailableFeats.FeatSlotType.SpecificBonusFeatChooseFocus, Rules.AvailableFeats.FeatSlotType.ChooseFeatOfType

                    If Slot.FeatGuid.IsEmpty Then

                        'let the user pick the focus item for the feat (if any)
                        Dim FocusGuid As Objects.ObjectKey
                        Dim FocusName As String = ""

                        If Feat.Status = Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesMetFocusSelected Then
                            FocusGuid = Feat.FocusGuid
                            FocusName = Feat.FocusName
                        End If

                        If Feat.Status = Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesMetSelectFocus Then
                            Dim Dialog As New SimpleSelectorDialog
                            Dim List As New ArrayList
                            Dim Obj As New Objects.ObjectData
                            Dim Item As DataListItem
                            Dim Items As DataListItem() = Nothing
                            Dim CustomFlag As Boolean

                            'get available foci
                            Dim Choices As ArrayList = Character.Prerequisites.FeatFocusChoices(Feat.FeatGuid)

                            If Choices Is Nothing Then
                                Select Case Feat.FocusType
                                    Case "Custom"
                                        CustomFlag = True
                                    Case "Alignment"
                                        Items = Rules.Index.AlignmentDataList
                                    Case "Domain"
                                        Items = Rules.Index.DataList(Xml.DBTypes.Domains, Objects.DomainDefinitionType)
                                    Case "Discipline Specialization"
                                        Items = Rules.Index.DataList(Xml.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType)
                                    Case "Power Discipline"
                                        Items = Rules.Index.DataList(Xml.DBTypes.SpellSchools, Objects.PsionicDisciplineType)
                                    Case "Spell School"
                                        Items = Rules.Index.DataList(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType)
                                    Case "Spell"
                                        Items = Rules.Index.DataList(Xml.DBTypes.Spells, Objects.SpellDefinitionType)
                                    Case "Power"
                                        Items = Rules.Index.DataList(Xml.DBTypes.Powers, Objects.PowerDefinitionType)
                                    Case "Skill"
                                        Dim Exclusions As New ArrayList
                                        Exclusions.Add(References.SpeakLanguage)
                                        Items = Rules.Index.DataListExclude(Xml.DBTypes.Skills, Objects.SkillDefinitionType, Exclusions)
                                    Case "Any Weapon"
                                        Dim Weapons As Objects.ObjectDataCollection

                                        Weapons = Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.AllWeapons)
                                        Dim FeatDef As New Objects.ObjectData
                                        FeatDef.Load(Feat.FeatGuid)

                                        If FeatDef.Element("IncludeGrapple") = "Yes" Then
                                            Dim Grapple As New Objects.ObjectData
                                            Grapple.ObjectGUID = References.Grapple
                                            Grapple.Name = "Grapple"
                                            Weapons.Add(Grapple)
                                        End If
                                        If FeatDef.Element("IncludeRay") = "Yes" Then
                                            Dim Ray As New Objects.ObjectData
                                            Ray.ObjectGUID = References.Ray
                                            Ray.Name = "Ray"
                                            Weapons.Add(Ray)
                                        End If
                                        If FeatDef.Element("IncludeRanged") = "Yes" Then
                                            Dim Ranged As New Objects.ObjectData
                                            Ranged.ObjectGUID = References.RangedSpell
                                            Ranged.Name = "Ranged Spell"
                                            Weapons.Add(Ranged)
                                        End If
                                        If FeatDef.Element("IncludeTouch") = "Yes" Then
                                            Dim Touch As New Objects.ObjectData
                                            Touch.ObjectGUID = References.TouchSpell
                                            Touch.Name = "Touch Spell"
                                            Weapons.Add(Touch)
                                        End If

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Natural Weapon"

                                        'add the natural attack types
                                        Dim Weapons As New Objects.ObjectDataCollection
                                        For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
                                            Dim NA As New Objects.ObjectData
                                            NA.ObjectGUID = General.ConvertToObjectKey(NaturalAttack, 38)
                                            NA.Name = NaturalAttack
                                            Weapons.Add(NA)
                                        Next

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Simple Weapon"
                                        Items = Rules.Index.DataListXPath(Xml.DBTypes.Weapons, XPathQueries.SimpleWeapons)
                                    Case "Martial Weapon"
                                        Dim Weapons As Objects.ObjectDataCollection

                                        Weapons = Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.MartialWeapons)
                                        'add in any racial weapons
                                        For Each RacialWeapon As Objects.ObjectData In Character.RaceObject.ChildrenOfType(Objects.RacialWeaponType)
                                            Weapons.Add(RacialWeapon.GetFKObject("Weapon"))
                                        Next

                                        'add in any martial two-handed weapons
                                        Weapons.AddMany(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.MartialTwoHanded))

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Exotic Weapon"
                                        Dim Weapons As Objects.ObjectDataCollection

                                        Weapons = Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.ExoticWeapons)
                                        'remove any racial weapons
                                        For Each RacialWeapon As Objects.ObjectData In Character.RaceObject.ChildrenOfType(Objects.RacialWeaponType)
                                            Weapons.Remove(RacialWeapon.GetFKGuid("Weapon"))
                                        Next

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Ranged Weapon"
                                        Items = Rules.Index.DataListXPath(Xml.DBTypes.Weapons, XPathQueries.RangedWeapons)
                                    Case "Melee Weapon"
                                        Items = Rules.Index.DataListXPath(Xml.DBTypes.Weapons, XPathQueries.MeleeWeapons)
                                    Case "Crossbow"
                                        Items = Rules.Index.DataListXPath(Xml.DBTypes.Weapons, XPathQueries.Crossbows)
                                End Select
                            Else
                                Dim FeatDef As New Objects.ObjectData
                                FeatDef.Load(Feat.FeatGuid)

                                If FeatDef.Element("IncludeGrapple") = "Yes" Then
                                    Item = New DataListItem(Nothing, References.Grapple, "Grapple")
                                    List.Add(Item)
                                End If
                                If FeatDef.Element("IncludeRay") = "Yes" Then
                                    Item = New DataListItem(Nothing, References.Ray, "Ray")
                                    List.Add(Item)
                                End If
                                If FeatDef.Element("IncludeRanged") = "Yes" Then
                                    Item = New DataListItem(Nothing, References.RangedSpell, "Ranged Spell")
                                    List.Add(Item)
                                End If
                                If FeatDef.Element("IncludeTouch") = "Yes" Then
                                    Item = New DataListItem(Nothing, References.TouchSpell, "Touch Spell")
                                    List.Add(Item)
                                End If

                                If Feat.FocusType = "Alignment" Then
                                    Dim Alignments As ObjectHashtable
                                    Alignments = Rules.Lists.AlignmentLookupTable
                                    For Each key As Objects.ObjectKey In Choices
                                        If Alignments.Contains(key) Then
                                            Item = New DataListItem(Nothing, key, CType(Alignments(key), String))
                                            List.Add(Item)
                                        End If
                                    Next
                                Else

                                    For Each Key As Objects.ObjectKey In Choices

                                        If Key.Database = Xml.DBTypes.NaturalWeapons Then
                                            List.Add(GetNaturalDataListItem(Key))
                                        Else
                                            Obj.Load(Key)
                                            Item = New DataListItem(Nothing, Obj.ObjectGUID, Obj.Name)
                                            List.Add(Item)
                                        End If

                                    Next

                                End If

                                Items = Rules.Index.DataList(List)
                            End If

                            If Not CustomFlag Then
                                'construct new filtered list to remove any foci that have already been taken
                                Dim Temp As ArrayList = New ArrayList(Items)
                                Dim FilteredItems As New ArrayList
                                Dim ExistingFoci As New ArrayList

                                For Each LibraryData As Library.LibraryData In Character.Feats.ItemData(Feat.FeatGuid)
                                    ExistingFoci.Add(CType(LibraryData.Data, Rules.Character.Feat).FocusGuid)
                                Next

                                For Each DataListItem As DataListItem In Temp
                                    If Not ExistingFoci.Contains(DataListItem.ObjectGUID) Then
                                        FilteredItems.Add(DataListItem)
                                    End If
                                Next

                                If FilteredItems.Count > 0 Then
                                    ReDim Items(FilteredItems.Count - 1)

                                    For n As Integer = 0 To FilteredItems.Count - 1
                                        Items(n) = CType(FilteredItems.Item(n), DataListItem)
                                    Next
                                Else
                                    'we have no items!
                                    ReDim Items(-1)
                                End If

                                'select
                                Dialog.Init("Focus", "Please select Feat Focus", Items)
                                If Dialog.ShowDialog = DialogResult.OK Then
                                    FocusGuid = Dialog.SelectedValue
                                    FocusName = Dialog.SelectedText
                                Else
                                    Exit Sub
                                End If
                            Else
                                Dim CustomBox As New SimpleTextForm
                                CustomBox.Init("Focus", "Custom Feat Focus")
                                If CustomBox.ShowDialog = DialogResult.OK Then
                                    If Not Character.Feats.ContainsSubkey(Feat.FeatGuid, CustomBox.TextValue) Then
                                        FocusName = CustomBox.TextValue
                                        FocusGuid = RPGXplorer.References.CustomFeatFocus
                                    Else
                                        General.ShowErrorDialog("This focus already exists for the selected feat.")
                                        Exit Sub
                                    End If
                                Else
                                    Exit Sub
                                End If
                            End If
                        End If

                        'update the slot
                        Slot.FeatGuid = Feat.FeatGuid
                        Slot.FeatName = Feat.FeatName
                        Slot.FeatType = Feat.FeatType
                        Slot.FocusGuid = FocusGuid
                        Slot.FocusName = FocusName

                        AvailableSlots.BeginUpdate()
                        SlotIndex = AvailableSlots.SelectedIndices(0)
                        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                        'add the feat to the character
                        NewFeat.FeatGuid = Feat.FeatGuid
                        NewFeat.FeatName = Feat.FeatName
                        NewFeat.FeatType = Feat.FeatType
                        NewFeat.LevelTaken = Slot.CharacterLevel
                        NewFeat.FocusGuid = FocusGuid
                        NewFeat.FocusName = FocusName
                        NewFeat.IgnorePrerequisites = Feat.IgnorePrerequisites
                        Select Case Slot.SlotType
                            Case Rules.AvailableFeats.FeatSlotType.BonusFeat
                                NewFeat.FeatSlotSource = Rules.AvailableFeats.BonusFeat
                            Case Rules.AvailableFeats.FeatSlotType.FighterBonusFeat
                                NewFeat.FeatSlotSource = Rules.AvailableFeats.FighterBonusFeat
                            Case Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat
                                NewFeat.FeatSlotSource = Rules.AvailableFeats.ChooseSpecificBonusFeat
                            Case Rules.AvailableFeats.FeatSlotType.SpecificBonusFeatChooseFocus
                                NewFeat.FeatSlotSource = Rules.AvailableFeats.SpecificBonusFeatChooseFocus
                        End Select

                        Select Case Slot.Source
                            Case Rules.AvailableFeats.FeatSource.Race
                                NewFeat.SourceName = Character.RaceObject.Name
                                NewFeat.SourceGuid = Character.RaceObject.ObjectGUID

                            Case Rules.AvailableFeats.FeatSource.Class
                                Dim Level As Rules.Character.Level = Character.Levels(Slot.CharacterLevel)
                                Dim ClassInfo As Rules.CharacterClass = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)
                                Dim ClassLevelObject As Objects.ObjectData = ClassInfo.ClassLevel(Level.ClassLevel)

                                NewFeat.SourceName = ClassLevelObject.Name
                                NewFeat.SourceGuid = ClassLevelObject.ObjectGUID

                            Case Rules.AvailableFeats.FeatSource.Core
                                NewFeat.SourceName = "Core Rules"
                                NewFeat.SourceGuid = Objects.ObjectKey.Empty

                        End Select
                        LastShownFeat = NewFeat.FeatName

                        If FocusGuid.Equals(Objects.ObjectKey.Empty) Then
                            'Add feat to the character
                            Character.Feats.AddItem(Feat.FeatGuid, NewFeat, NewFeat.LevelTaken)

                            'Add feat to valid lookuptable
                            Character.Components.Feats(Feat.FeatGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                            Character.Calculate(False)

                        ElseIf FocusGuid.Equals(RPGXplorer.References.CustomFeatFocus) Then
                            'Add feat to the character
                            Character.Feats.AddItemWithSubkey(Feat.FeatGuid, FocusName, NewFeat, NewFeat.LevelTaken)

                            'Add feat to valid lookuptable
                            Character.Components.Feats(Feat.FeatGuid.ToString & FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                            Character.Calculate(False)

                        Else
                            'Add feat to the character
                            Character.Feats.AddItemWithSubkey(Feat.FeatGuid, FocusGuid, NewFeat, NewFeat.LevelTaken)

                            'Add feat to the vlaid lookup table
                            Character.Components.Feats(Feat.FeatGuid.ToString & FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                            Character.Calculate(False)
                        End If

                        AvailableSlots.EndUpdate()
                    End If

                Case Rules.AvailableFeats.FeatSlotType.ChoosePathFeat

                    If Slot.FeatGuid.IsEmpty Then

                        'update the slot
                        Slot.FeatGuid = Feat.FeatGuid
                        Slot.FeatName = Feat.FeatName
                        Slot.FeatType = Feat.FeatType

                        AvailableSlots.BeginUpdate()
                        SlotIndex = AvailableSlots.SelectedIndices(0)
                        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                        'Get the Combat Style Object
                        Dim Level As Rules.Character.Level = Character.Levels(Slot.CharacterLevel)
                        Dim ClassInfo As Rules.CharacterClass = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)
                        Dim ClassLevelObject As Objects.ObjectData = ClassInfo.ClassLevel(Level.ClassLevel)
                        Dim StyleObject As Objects.ObjectData = ClassLevelObject.FirstChildOfType(Objects.CombatStyleType)

                        'Save the Combat Style choice object
                        Dim StyleChoice As New Rules.Character.CharacterChoice
                        StyleChoice.Type = Rules.Character.ChoiceType.CombatStyle
                        StyleChoice.ClassName = ClassInfo.ClassObj.Name
                        StyleChoice.ClassGuid = ClassInfo.ClassObj.ObjectGUID
                        StyleChoice.LevelAcquired = Slot.CharacterLevel
                        StyleChoice.DataGuid = StyleObject.ObjectGUID

                        If Slot.FeatGuid.Equals(StyleObject.GetFKGuid("FirstFeat1")) Then
                            StyleChoice.Data = "Style1"
                        ElseIf Slot.FeatGuid.Equals(StyleObject.GetFKGuid("FirstFeat2")) Then
                            StyleChoice.Data = "Style2"
                        Else
                            MessageBox.Show("Could not match feat to combat style")
                        End If

                        Character.Choices.AddItemWithSubkey(StyleChoice.ClassGuid, StyleChoice.DataGuid, StyleChoice, Slot.CharacterLevel)

                        'Save the new feat
                        NewFeat.Clear()
                        NewFeat.FeatGuid = Slot.FeatGuid
                        NewFeat.FeatName = Slot.FeatName
                        NewFeat.FeatType = Slot.FeatType
                        NewFeat.LevelTaken = Slot.CharacterLevel
                        NewFeat.FocusGuid = Slot.FocusGuid
                        NewFeat.FocusName = Slot.FocusName
                        NewFeat.IgnorePrerequisites = True
                        NewFeat.FeatSlotSource = "Combat Style Starter"
                        NewFeat.SourceName = StyleChoice.Data
                        NewFeat.SourceGuid = StyleObject.ObjectGUID

                        LastShownFeat = NewFeat.FeatName

                        If NewFeat.FocusGuid.IsEmpty Then
                            NewFeat.FocusName = ""
                            Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                            Character.Components.Feats(Feat.FeatGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.LevelTaken)
                        Else
                            NewFeat.FocusName = Slot.FocusName
                            Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                            Character.Components.Feats(Feat.FeatGuid.ToString & NewFeat.FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                        End If

                        'Update any continuation feats
                        Dim Updated As Boolean = False
                        If MaxIndex > SlotIndex Then

                            For i As Integer = SlotIndex + 1 To MaxIndex
                                TempSlot = CType(AvailableSlots.Items(i).Tag, Rules.AvailableFeats.FeatSlot)

                                'If its a continuation feat slot, make sure its from the same class
                                If TempSlot.SlotType = Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat Then
                                    Level = Character.Levels(TempSlot.CharacterLevel)
                                    ClassInfo = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)
                                    If ClassInfo.ClassObj.ObjectGUID.Equals(StyleChoice.ClassGuid) Then

                                        'Remove any old feat
                                        If TempSlot.FeatGuid.IsNotEmpty Then

                                            If TempSlot.FocusGuid.IsEmpty Then
                                                Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.CharacterLevel)
                                            Else
                                                Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.FocusGuid)
                                            End If

                                            'Clear the old feat from the slot
                                            TempSlot.FeatClear()

                                        End If

                                        'Add the new feat
                                        Select Case Level.ClassLevel

                                            Case StyleObject.ElementAsInteger("SecondLevel")

                                                Select Case StyleChoice.Data
                                                    Case "Style1"
                                                        TempSlot.FeatGuid = StyleObject.GetFKGuid("SecondFeat1")
                                                        TempSlot.FeatName = StyleObject.Element("SecondFeat1")
                                                        TempSlot.FeatType = StyleObject.GetFKObject("SecondFeat1").Element("FeatType")

                                                    Case "Style2"
                                                        TempSlot.FeatGuid = StyleObject.GetFKGuid("SecondFeat2")
                                                        TempSlot.FeatName = StyleObject.Element("SecondFeat2")
                                                        TempSlot.FeatType = StyleObject.GetFKObject("SecondFeat2").Element("FeatType")
                                                End Select

                                            Case StyleObject.ElementAsInteger("ThirdLevel")

                                                Select Case StyleChoice.Data
                                                    Case "Style1"
                                                        TempSlot.FeatGuid = StyleObject.GetFKGuid("ThirdFeat1")
                                                        TempSlot.FeatName = StyleObject.Element("ThirdFeat1")
                                                        TempSlot.FeatType = StyleObject.GetFKObject("ThirdFeat1").Element("FeatType")

                                                    Case "Style2"
                                                        TempSlot.FeatGuid = StyleObject.GetFKGuid("ThirdFeat2")
                                                        TempSlot.FeatName = StyleObject.Element("ThirdFeat2")
                                                        TempSlot.FeatType = StyleObject.GetFKObject("ThirdFeat2").Element("FeatType")
                                                End Select

                                        End Select

                                        If TempSlot.FeatGuid.IsNotEmpty Then

                                            AvailableSlots.Items(i) = LoadSlot(TempSlot)

                                            'add feat to character
                                            NewFeat.Clear()
                                            NewFeat.FeatGuid = TempSlot.FeatGuid
                                            NewFeat.FeatName = TempSlot.FeatName
                                            NewFeat.FeatType = TempSlot.FeatType
                                            NewFeat.LevelTaken = TempSlot.CharacterLevel
                                            NewFeat.FocusGuid = TempSlot.FocusGuid
                                            NewFeat.FocusName = TempSlot.FocusName
                                            NewFeat.IgnorePrerequisites = True
                                            NewFeat.FeatSlotSource = "Combat Style Automatic"
                                            NewFeat.SourceName = StyleChoice.Data
                                            NewFeat.SourceGuid = StyleObject.ObjectGUID

                                            If NewFeat.FocusGuid.IsEmpty Then
                                                NewFeat.FocusName = ""
                                                Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                                            Else
                                                NewFeat.FocusName = Slot.FocusName
                                                Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                                            End If

                                        End If

                                    End If

                                End If
                            Next

                            'Update the character
                            Character.Calculate(True)
                            Updated = True

                        End If

                        'Update if not  done so already
                        If Not Updated Then Character.Calculate(False)

                        'update the available feat list if required                    
                        AvailableSlots.EndUpdate()

                    End If

            End Select

            FeatsTaken += 1
            EnableDisableNext()
            MoveToNextAvailableSlot(SlotIndex)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove feat from list of feats taken
    Private Sub PutFeatBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutFeatBack.Click
        Dim Slot, TempSlot As Rules.AvailableFeats.FeatSlot
        Dim SlotIndex As Integer
        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableFeats.FeatSlot)
        SlotIndex = AvailableSlots.SelectedIndices(0)
        If Slot.FeatGuid.IsEmpty Then Exit Sub

        StopUpdateFeatWorker()
        AvailableSlots.BeginUpdate()

        Select Case Slot.SlotType

            Case Rules.AvailableFeats.FeatSlotType.ChoosePathFeat

                'Remove Feat from character
                If Slot.FocusGuid.IsEmpty Then
                    Character.Feats.RemoveItem(Slot.FeatGuid, Slot.CharacterLevel)
                Else
                    Character.Feats.RemoveItem(Slot.FeatGuid, Slot.FocusGuid)
                End If

                Slot.FeatClear()
                AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)

                Dim Level As Rules.Character.Level = Character.Levels(Slot.CharacterLevel)
                Dim StyleClassGUID As Objects.ObjectKey = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass).ClassObj.ObjectGUID

                'Find and remove any continuation feats
                If MaxIndex > SlotIndex Then
                    For i As Integer = SlotIndex + 1 To MaxIndex
                        TempSlot = CType(AvailableSlots.Items(i).Tag, Rules.AvailableFeats.FeatSlot)
                        'If its a continuation feat slot, make sure its from the same class
                        If TempSlot.SlotType = Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat Then
                            Level = Character.Levels(TempSlot.CharacterLevel)
                            Dim SlotClassGUID As Objects.ObjectKey = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass).ClassObj.ObjectGUID
                            'If this continuation feat is from the same class as the starter feat
                            If StyleClassGUID.Equals(SlotClassGUID) Then
                                'Remove any old feat
                                If TempSlot.FeatGuid.IsNotEmpty Then

                                    If TempSlot.FocusGuid.IsEmpty Then
                                        Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.CharacterLevel)
                                    Else
                                        Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.FocusGuid)
                                    End If
                                    TempSlot.FeatClear()
                                    AvailableSlots.Items(i) = LoadSlot(TempSlot)
                                End If
                            End If
                        End If
                    Next
                End If

                'Remove Choice Object from the character
                For Each LibraryItem As Library.LibraryData In Character.Choices.ItemData(StyleClassGUID)
                    Dim Choice As Rules.Character.CharacterChoice
                    Choice = CType(LibraryItem.Data, Rules.Character.CharacterChoice)
                    If Choice.Type = Rules.Character.ChoiceType.CombatStyle Then
                        Character.Choices.RemoveItem(Choice.ClassGuid, Choice.DataGuid)
                        Exit For
                    End If
                Next

                'Update the character
                Character.Calculate()

            Case Rules.AvailableFeats.FeatSlotType.BonusFeat, Rules.AvailableFeats.FeatSlotType.FighterBonusFeat, Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat, Rules.AvailableFeats.FeatSlotType.SpecificBonusFeatChooseFocus, Rules.AvailableFeats.FeatSlotType.ChooseFeatOfType

                'Remove Feat from character
                If Slot.FocusGuid.IsEmpty Then
                    Character.Feats.RemoveItem(Slot.FeatGuid, Slot.CharacterLevel)
                Else
                    Character.Feats.RemoveItem(Slot.FeatGuid, Slot.FocusGuid)
                End If

                'Update the character
                Character.Calculate()

                'Remove broken feats
                If MaxIndex > SlotIndex Then
                    Dim PrerequisitesMet As Boolean
                    Dim SomethingRemoved As Boolean = True

                    While SomethingRemoved
                        SomethingRemoved = False

                        For i As Integer = SlotIndex + 1 To MaxIndex
                            TempSlot = CType(AvailableSlots.Items(i).Tag, Rules.AvailableFeats.FeatSlot)
                            If TempSlot.FeatName = "" Then Continue For
                            Select Case TempSlot.SlotType
                                Case Rules.AvailableFeats.FeatSlotType.BonusFeat, Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat, Rules.AvailableFeats.FeatSlotType.FighterBonusFeat
                                    PrerequisitesMet = True

                                    If (TempSlot.SlotType <> Rules.AvailableFeats.FeatSlotType.ChooseSpecificBonusFeat) OrElse (TempSlot.ChooseBonusFeat.Element("OverridePrerequisites") <> "Yes") Then
                                        For Each Prerequisite As Objects.ObjectData In Caches.FeatPrerequisites.ChildrenFast(TempSlot.FeatGuid)
                                            If Not Character.Prerequisites.HasPrerequisite(Prerequisite, TempSlot.CharacterLevel, Caches.FeaturePrerequisiteChildren.ChildrenFast(Prerequisite.ObjectGUID)) Then
                                                PrerequisitesMet = False
                                                Exit For
                                            End If
                                        Next
                                    End If

                                    If PrerequisitesMet = False Then
                                        'Remove feat from character
                                        If TempSlot.FocusGuid.IsEmpty Then
                                            Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.CharacterLevel)
                                        Else
                                            Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.FocusGuid)
                                        End If

                                        'Clear the slot
                                        TempSlot.FeatClear()
                                        AvailableSlots.Items(i) = LoadSlot(TempSlot)

                                        'Update the character
                                        Character.Calculate()

                                        SomethingRemoved = True
                                    End If
                            End Select
                        Next

                    End While
                End If

                'Clear the slot
                Slot.FeatClear()
                AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)

        End Select

        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()
        FeatsTaken -= 1
        EnableDisableNext()

    End Sub

    'displays the feat coloring legend
    Private Sub FeatLegend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeatLegend.Click
        Try
            Dim FeatLegend As New FeatLegendPanel
            FeatLegend.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'ignore feat prerequisites
    Private Sub IgnoreCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreCheck.CheckedChanged
        If IsLoading Then Exit Sub
        If IgnoreCheck.Checked Then General.Config.Element("WizardIgnoreFeatPrereqCheck") = "True" Else General.Config.Element("WizardIgnoreFeatPrereqCheck") = ""
        If AvailableSlots.SelectedItems.Count = 1 Then
            UpdateFeatList()
        End If
    End Sub

    Private Sub AvailableFeats_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableFeats.DoubleClick
        TakeFeat_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutFeatBack_Click(Nothing, Nothing)
    End Sub

    Private Sub FilterBar_FilterChanged() Handles FilterBar.FilterChanged
        UpdateFeatList()
    End Sub

#End Region

    'move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        For Each Item As ListViewItem In AvailableSlots.Items
            If CType(Item.Tag, Rules.AvailableFeats.FeatSlot).FeatName = "" Then
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
        For Each Item As ListViewItem In AvailableSlots.Items
            If Item.SubItems(2).Text = "" Then
                RaiseEvent DisableNext()
                Exit Sub
            End If
        Next

        RaiseEvent EnableNext(False)
    End Sub

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

    'generates a datalist item for a natural attack key
    Private Function GetNaturalDataListItem(ByVal Key As Objects.ObjectKey) As DataListItem
        Dim DataListItem As DataListItem

        If NaturalAttacks Is Nothing Then
            GenerateAttackTable()
        End If

        Try
            DataListItem = New DataListItem(Nothing, Key, CStr(NaturalAttacks(Key)))
        Catch ex As Exception
            DataListItem = New DataListItem(Nothing, Key, "Unknown")
        End Try

        Return DataListItem

    End Function

    'makes a table maping natrual attack keys to the names
    Private Sub GenerateAttackTable()
        NaturalAttacks = New Hashtable(Rules.Lists.NaturalAttackTypes.Length)
        For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
            NaturalAttacks.Add(General.ConvertToObjectKey(NaturalAttack, Xml.DBTypes.NaturalWeapons), NaturalAttack)
        Next
    End Sub

    'stop worker thread
    Private Sub SelectFeatsPanel_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        StopUpdateFeatWorker()
    End Sub

End Class
