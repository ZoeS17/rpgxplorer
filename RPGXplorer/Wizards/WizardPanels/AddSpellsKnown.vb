Option Strict On
Option Explicit On

Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class AddSpellsKnown
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
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents AvailableSpells As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Public WithEvents PutSpellBack As System.Windows.Forms.Button
    Public WithEvents TakeSpell As System.Windows.Forms.Button
    Public WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ClassDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Public WithEvents LegendButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AddSpellsKnown))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableSpells = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.PutSpellBack = New System.Windows.Forms.Button
        Me.TakeSpell = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LegendButton = New System.Windows.Forms.Button
        Me.ClassDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel1.SuspendLayout()
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(440, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 525)
        Me.Panel1.TabIndex = 135
        '
        'Browser
        '
        Me.Browser.BackColor = System.Drawing.Color.White
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.Browser.Enabled = True
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Size = New System.Drawing.Size(493, 523)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(145, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please select your spells"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 375)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 175)
        Me.Panel3.TabIndex = 139
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
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
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Level"
        Me.ColumnHeader7.Width = 57
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Slot Name"
        Me.ColumnHeader1.Width = 123
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Spell Level"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 68
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Spell Taken"
        Me.ColumnHeader3.Width = 138
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableSpells)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 250)
        Me.Panel2.TabIndex = 138
        '
        'AvailableSpells
        '
        Me.AvailableSpells.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSpells.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.AvailableSpells.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSpells.FullRowSelect = True
        Me.AvailableSpells.HideSelection = False
        Me.AvailableSpells.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSpells.MultiSelect = False
        Me.AvailableSpells.Name = "AvailableSpells"
        Me.AvailableSpells.Size = New System.Drawing.Size(408, 248)
        Me.AvailableSpells.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableSpells.TabIndex = 122
        Me.AvailableSpells.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Spell"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Level"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 51
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "School"
        Me.ColumnHeader6.Width = 177
        '
        'PutSpellBack
        '
        Me.PutSpellBack.Location = New System.Drawing.Point(335, 340)
        Me.PutSpellBack.Name = "PutSpellBack"
        Me.PutSpellBack.Size = New System.Drawing.Size(90, 24)
        Me.PutSpellBack.TabIndex = 137
        Me.PutSpellBack.Text = "Put Spell Back"
        '
        'TakeSpell
        '
        Me.TakeSpell.Location = New System.Drawing.Point(240, 340)
        Me.TakeSpell.Name = "TakeSpell"
        Me.TakeSpell.Size = New System.Drawing.Size(90, 24)
        Me.TakeSpell.TabIndex = 136
        Me.TakeSpell.Text = "Take Spell"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "Spellcasting Class"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LegendButton
        '
        Me.LegendButton.Location = New System.Drawing.Point(15, 340)
        Me.LegendButton.Name = "LegendButton"
        Me.LegendButton.Size = New System.Drawing.Size(90, 24)
        Me.LegendButton.TabIndex = 320
        Me.LegendButton.Text = "Spell Legend"
        '
        'ClassDropdown
        '
        Me.ClassDropdown.EditValue = ""
        Me.ClassDropdown.Location = New System.Drawing.Point(120, 45)
        Me.ClassDropdown.Name = "ClassDropdown"
        '
        'ClassDropdown.Properties
        '
        Me.ClassDropdown.Properties.AutoHeight = False
        Me.ClassDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClassDropdown.Properties.DropDownRows = 10
        Me.ClassDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassDropdown.Size = New System.Drawing.Size(200, 21)
        Me.ClassDropdown.TabIndex = 319
        '
        'AddSpellsKnown
        '
        Me.Controls.Add(Me.ClassDropdown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PutSpellBack)
        Me.Controls.Add(Me.TakeSpell)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.LegendButton)
        Me.Name = "AddSpellsKnown"
        Me.Size = New System.Drawing.Size(950, 565)
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private Character As Rules.Character
    Private Spellcasters As ArrayList

    'Private CasterClasses As New Hashtable(5)
    Private ClassInfo As Rules.CharacterClass

    'Hashtable to store the slots for the different classes
    'Key:- ClassGuid, Value:- ArrayList of Rules.SpellSlot
    Private SpellSlots As New Hashtable(5)
    Private SlotCounts As New Hashtable(5)
    Private SpellsTaken As New Hashtable(5)

    Private LastShownSpell As String
    Private PreviousURL As String
    'Private SpellsTaken As Integer
    Private AllowSpell, AllowSlot As Boolean

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As Rules.SpellSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, Rules.SpellSlot)
                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("No slot selected")
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

#End Region

    'initialise the panel
    Public Function Init(ByVal Character As Rules.Character) As Boolean
        IsInitialised = True
        Me.Character = Character

        ClassDropdown.Properties.Items.Clear()
        ClassDropdown.SelectedIndex = -1

        Spellcasters = New ArrayList

        'if the race itself a caster?
        If Me.Character.RaceObject.Element("CasterType") = "Spellcaster" Then
            Dim CasterKey As Objects.ObjectKey = Me.Character.RaceObject.GetFKGuid("CasterSource")

            'if this class is not already in the ChatacterClasses table then add it now
            If Not Character.CharacterClasses.Contains(CasterKey) Then Character.CharacterClasses.Add(CasterKey)
        End If

        'go through the character and find spellcasting classes
        For Each TempClassInfo As Rules.CharacterClass In Character.CharacterClasses.Values
            If TempClassInfo.IsCaster Then

                'store the casters that are going to have to choose spells
                If TempClassInfo.CasterInfo.SpellAquisition = Rules.CharacterClass.AcquisitionType.Book OrElse TempClassInfo.CasterInfo.SpellAquisition = Rules.CharacterClass.AcquisitionType.Known Then
                    If TempClassInfo.CasterInfo.ManualSpells = False Then
                        Spellcasters.Add(TempClassInfo)
                    End If
                Else
                    'update the spell list style caster
                    Me.Character.Spells.UpdateSpellListCaster(TempClassInfo.ClassObj.ObjectGUID)
                End If
            End If
        Next

        If Spellcasters.Count = 0 Then Return False

        Dim ClassSlotCount As Integer
        Dim CopyToArray() As ListViewItem

        'Load the slots for every class
        For Each TempClassInfo As Rules.CharacterClass In Spellcasters
            Character.Spells.AvailableSpells.LoadSpells(TempClassInfo, Character)
            ClassSlotCount = LoadSlots(TempClassInfo)
            Me.ClassInfo = TempClassInfo

            If ClassSlotCount > 0 Then
                SlotCounts.Item(TempClassInfo.ClassObj.ObjectGUID) = ClassSlotCount
                SpellsTaken.Item(TempClassInfo.ClassObj.ObjectGUID) = 0
                ClassDropdown.Properties.Items.Add(New DataListItem(TempClassInfo, TempClassInfo.ClassObj.Name))

                'Copy the slots into an array and store them in a hashtable
                ReDim CopyToArray(AvailableSlots.Items.Count - 1)
                AvailableSlots.Items.CopyTo(CopyToArray, 0)
                SpellSlots(TempClassInfo.ClassObj.ObjectGUID) = CopyToArray
            End If
        Next

        If SpellSlots.Count = 0 Then Return False

        'select the first class
        ClassDropdown.SelectedIndex = 0

        Return True
    End Function

    'Load the slots for the currently selected class
    Private Function LoadSlots(ByVal ClassInfo As Rules.CharacterClass) As Integer
        Dim Slots As ArrayList
        Dim Slot As Rules.SpellSlot
        Dim SlotCount As Integer

        Try
            'Get the slots for the current class
            Slots = Character.Spells.AvailableSpells.AvailableSpellSlots(ClassInfo)
            Slots.Sort()
            Slots.Reverse()

            'Clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()
            SlotCount = 0

            'Add each slot to the listview
            For Each Slot In Slots

                If Slot.SlotType = Rules.SpellSlotType.Known_Type OrElse Slot.SlotType = Rules.SpellSlotType.Book_Type Then
                    If Slot.Fixed = False Then
                        SlotCount += 1
                    End If
                End If

                AvailableSlots.Items.Add(LoadSlot(Slot))
            Next

            AvailableSlots.EndUpdate()

            Return SlotCount

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Generates a ListViewItem from a spell slot
    Private Function LoadSlot(ByVal Slot As Rules.SpellSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            Select Case Slot.SlotType

                Case Rules.SpellSlotType.Book_Type, Rules.SpellSlotType.Known_Type
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Spell Gained")
                    ListViewItem.SubItems.Add(Slot.MaxSpellLevel.ToString)
                    ListViewItem.SubItems.Add(Slot.SpellName)
                    Return ListViewItem

                Case Rules.SpellSlotType.Replace_Start_Type
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Replace Spell")
                    ListViewItem.SubItems.Add(Slot.MaxSpellLevel.ToString)
                    ListViewItem.SubItems.Add(Slot.SpellName)
                    Return ListViewItem

                Case Rules.SpellSlotType.Replace_In_Progres_Type
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Replace " & Slot.ReplaceName)
                    ListViewItem.SubItems.Add(Slot.ReplaceLevel.ToString)
                    ListViewItem.SubItems.Add(Slot.SpellName)
                    Return ListViewItem

            End Select
            Return ListViewItem
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Gets the list of avialable spells based on the current class and the selected slot
    Private Sub UpdateSpellList()
        Dim SpellList As New ArrayList
        Dim SpellInfo As Rules.AvailableSpell

        Try
            AvailableSpells.BeginUpdate()
            AvailableSpells.Items.Clear()

            SpellList = Character.Spells.AvailableSpells.AvailableSpellsList(SelectedSlot, ClassInfo)

            'add the spells to the list
            If SpellList.Count > 0 Then
                Dim ListItems() As ListViewItem
                ReDim ListItems(SpellList.Count - 1)
                Dim ItemIndex As Integer = 0
                For Each SpellInfo In SpellList
                    ListItems(ItemIndex) = LoadSpell(SpellInfo)
                    ItemIndex += 1
                Next
                AvailableSpells.Items.AddRange(ListItems)
            End If

            'show current spell if any
            If LastShownSpell <> "" Then
                For Each Item As ListViewItem In AvailableSpells.Items
                    If Item.Text = LastShownSpell Then
                        Item.Selected = True
                        Item.EnsureVisible()
                        AvailableSpells.EndUpdate()
                        Exit Sub
                    End If
                Next
            End If

            'sort
            AvailableSpells.ListViewItemSorter = New Sorter.ListViewItemComparer(SortType.Numeric, 1, SortOrder.Descending)
            AvailableSpells.Sort()

            'select first item
            If AvailableSpells.Items.Count > 0 Then AvailableSpells.Items(0).Selected = True

            AvailableSpells.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creats a listview item for an available spell
    Private Function LoadSpell(ByVal SpellInfo As Rules.AvailableSpell) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = SpellInfo.SpellName
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, SpellInfo.SpellLevel.ToString))
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, SpellInfo.SpellSchool))

            ListViewItem.Tag = SpellInfo

            Select Case SpellInfo.Status
                Case Rules.AvailableSpellStatus.AlreadyHave
                    ListViewItem.ForeColor = Constants.TakenSpellColor
                Case Rules.AvailableSpellStatus.SacrificedSchool
                    ListViewItem.ForeColor = Constants.RestrictedSpellColor
                Case Rules.AvailableSpellStatus.Allowed
                    Select Case SpellInfo.SourceType
                        Case SpellSourceType.Class
                            ListViewItem.ForeColor = Constants.ClassSpellColor

                        Case Rules.SpellSourceType.Domain
                            ListViewItem.ForeColor = Constants.DomainSpellColor

                        Case Rules.SpellSourceType.PrestigeClass
                            ListViewItem.ForeColor = Constants.PrestigeSpellColor

                        Case Rules.SpellSourceType.PrestigeDomain
                            ListViewItem.ForeColor = Constants.PrestigeDomainSpellColor

                        Case SpellSourceType.RacialAdditional
                            ListViewItem.ForeColor = Constants.RacialAdditional

                    End Select
            End Select

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

#Region "Event Handlers"

    'displays the spell coloring legend
    Private Sub LegendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LegendButton.Click
        Try
            Dim SpellLegend As New SpellLegendPanel
            SpellLegend.Show()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the available spells for the new slot
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot, TempSlot As Rules.SpellSlot
        Dim SlotIndex As Integer
        ' Dim ListViewItem As ListViewItem

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Slot = SelectedSlot()
                UpdateSpellList()

                SlotIndex = AvailableSlots.SelectedIndices(0)

                'Clear any Replace In Progress Types that have been clicked off of
                For Each Item As ListViewItem In AvailableSlots.Items
                    TempSlot = CType(Item.Tag, Rules.SpellSlot)
                    If TempSlot.SlotType = Rules.SpellSlotType.Replace_In_Progres_Type AndAlso TempSlot.SpellGuid.IsEmpty And (Item.Index <> SlotIndex) Then
                        TempSlot.ReplaceClear()
                        TempSlot.SlotType = Rules.SpellSlotType.Replace_Start_Type
                        AvailableSlots.Items(Item.Index) = LoadSlot(TempSlot)
                    End If
                Next

                Select Case Slot.SlotType

                    Case Rules.SpellSlotType.Known_Type, Rules.SpellSlotType.Book_Type
                        TakeSpell.Text = "Take Spell"
                        If Slot.SpellName = "" Then
                            AllowSlot = True
                            PutSpellBack.Enabled = False
                        Else
                            AllowSlot = False
                            PutSpellBack.Enabled = True
                        End If

                    Case Rules.SpellSlotType.Replace_Start_Type
                        TakeSpell.Text = "Replace Spell"
                        AllowSlot = True
                        PutSpellBack.Enabled = False

                    Case Rules.SpellSlotType.Replace_In_Progres_Type
                        TakeSpell.Text = "Take Spell"
                        If Slot.SpellName = "" Then
                            AllowSlot = True
                            PutSpellBack.Enabled = True
                        Else
                            AllowSlot = False
                            PutSpellBack.Enabled = True
                        End If

                End Select

                If Slot.Fixed Then PutSpellBack.Enabled = False

                If AllowSpell And AllowSlot Then
                    TakeSpell.Enabled = True
                Else
                    TakeSpell.Enabled = False
                End If

            Else
                TakeSpell.Enabled = False
                PutSpellBack.Enabled = True
            End If

            If Slot.SpellGuid.IsNotEmpty Then
                Dim Spell As New Objects.ObjectData
                Spell.Load(Slot.SpellGuid)
                Dim URL As String

                If Spell.HTML.IndexOf(":\") = 1 And IO.File.Exists(Spell.HTML) Then
                    URL = "file://" & Spell.HTML
                Else
                    If IO.File.Exists(General.HelpPath & Spell.HTML) Then
                        URL = "file://" & General.HelpPath & Spell.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display help page for the newly selected spell
    Private Sub AvailableSpells_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSpells.SelectedIndexChanged
        Dim Spell As Rules.AvailableSpell

        Try
            If AvailableSpells.SelectedItems.Count > 0 Then
                Spell = CType(AvailableSpells.SelectedItems(0).Tag, Rules.AvailableSpell)
                Dim URL As String

                If Spell.HTML.IndexOf(":\") = 1 And IO.File.Exists(Spell.HTML) Then
                    URL = "file://" & Spell.HTML
                Else
                    If IO.File.Exists(General.HelpPath & Spell.HTML) Then
                        URL = "file://" & General.HelpPath & Spell.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL


                If Spell.Status = Rules.AvailableSpellStatus.SacrificedSchool Or Spell.Status = Rules.AvailableSpellStatus.AlreadyHave Then
                    AllowSpell = False
                Else
                    AllowSpell = True
                End If

                If AllowSpell And AllowSlot Then
                    TakeSpell.Enabled = True
                Else
                    TakeSpell.Enabled = False
                End If

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'change panel to another spellcasting class
    Private Sub ClassDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassDropdown.SelectedIndexChanged
        Try
            Dim CopyToArray() As ListViewItem

            'Copy the slots into an array and store them in a hashtable
            ReDim CopyToArray(AvailableSlots.Items.Count - 1)
            AvailableSlots.Items.CopyTo(CopyToArray, 0)
            SpellSlots(ClassInfo.ClassObj.ObjectGUID) = CopyToArray

            'Clear the slots and get the new class
            AvailableSlots.Items.Clear()
            ClassInfo = CType(CType(ClassDropdown.SelectedItem, DataListItem).ValueMember, Rules.CharacterClass)

            'Load the slots for the new class
            CopyToArray = CType(SpellSlots(ClassInfo.ClassObj.ObjectGUID), ListViewItem())
            AvailableSlots.Items.AddRange(CopyToArray)

            'Select the first slot
            If AvailableSlots.Items.Count > 0 Then
                AvailableSlots.Items(0).Selected = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'take the selected spell
    Private Sub TakeSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeSpell.Click
        Dim Slot As Rules.SpellSlot
        Dim Spell As Rules.AvailableSpell
        Dim SlotIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailableSpells.SelectedItems.Count) <> 2 Then Exit Sub

        'get the spell and the slot
        Spell = CType(AvailableSpells.SelectedItems(0).Tag, Rules.AvailableSpell)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.SpellSlot)

        If Not Spell.Status = Rules.AvailableSpellStatus.Allowed Then Exit Sub

        If Slot.SpellName = "" Then

            Select Case Slot.SlotType

                Case Rules.SpellSlotType.Known_Type
                    Slot.SpellName = Spell.SpellName
                    Slot.SpellLevel = Spell.SpellLevel
                    Slot.SpellGuid = Spell.SpellGuid
                    Slot.SourceGuid = Spell.SourceGuid

                    AvailableSlots.BeginUpdate()
                    SlotIndex = AvailableSlots.SelectedIndices(0)
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    Character.Spells.TakeSpell(Spell.SpellGuid, Spell.SpellName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Spell.SourceGuid, Spell.SourceName, Spell.SpellLevel, Slot.CharacterLevel)
                    SpellsTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(SpellsTaken(ClassInfo.ClassObj.ObjectGUID)) + 1

                    AvailableSlots.EndUpdate()
                    LastShownSpell = Spell.SpellName

                Case Rules.SpellSlotType.Book_Type
                    Slot.SpellName = Spell.SpellName
                    Slot.SpellLevel = Spell.SpellLevel
                    Slot.SpellGuid = Spell.SpellGuid
                    Slot.SourceGuid = Spell.SourceGuid

                    AvailableSlots.BeginUpdate()
                    SlotIndex = AvailableSlots.SelectedIndices(0)
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    Character.Spells.TakeSpell(Spell.SpellGuid, Spell.SpellName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Spell.SourceGuid, Spell.SourceName, Spell.SpellLevel, Slot.CharacterLevel)
                    SpellsTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(SpellsTaken(ClassInfo.ClassObj.ObjectGUID)) + 1

                    AvailableSlots.EndUpdate()
                    LastShownSpell = Spell.SpellName

                Case Rules.SpellSlotType.Replace_Start_Type
                    Slot.SlotType = Rules.SpellSlotType.Replace_In_Progres_Type
                    Slot.ReplaceName = Spell.SpellName
                    Slot.ReplaceLevel = Spell.SpellLevel
                    Slot.ReplaceGuid = Spell.SpellGuid
                    Slot.ReplaceSourceGuid = Spell.SourceGuid

                    AvailableSlots.BeginUpdate()
                    SlotIndex = AvailableSlots.SelectedIndices(0)
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
                    AvailableSlots.Items(SlotIndex).Selected = True
                    AvailableSlots.EndUpdate()
                    Exit Sub

                Case Rules.SpellSlotType.Replace_In_Progres_Type
                    Slot.SpellName = Spell.SpellName
                    Slot.SpellLevel = Spell.SpellLevel
                    Slot.SpellGuid = Spell.SpellGuid
                    Slot.SourceGuid = Spell.SourceGuid

                    AvailableSlots.BeginUpdate()
                    SlotIndex = AvailableSlots.SelectedIndices(0)
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    'Set a Replace on the old spell
                    Dim ReplaceSpell As Spell = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.ReplaceGuid, Slot.ReplaceSourceGuid)
                    ReplaceSpell.ReplaceAtLevel(Slot.CharacterLevel)
                    Character.Spells.UpdateSpell(ReplaceSpell)

                    'Add the new spell
                    Character.Spells.TakeSpell(Spell.SpellGuid, Spell.SpellName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Spell.SourceGuid, Spell.SourceName, Spell.SpellLevel, Slot.CharacterLevel)

                    AvailableSlots.EndUpdate()
                    LastShownSpell = Spell.SpellName

            End Select

            EnableDisableNext()
            MoveToNextAvailableSlot(SlotIndex)
        End If

    End Sub

    'recursive part of returning a spell that might of been replaced
    Private Sub RemoveSpell_CancelReplace(ByVal Slot As Rules.SpellSlot, ByVal SlotIndex As Integer)
        Dim SpellTaken As Rules.Spell

        'If it has been replaced cancel the replace
        SpellTaken = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.SpellGuid, Slot.SourceGuid)
        Dim LevelReplaced As Integer = SpellTaken.LevelReplaced(Slot.CharacterLevel)
        Dim TempIndex As Integer

        'remove take at level
        SpellTaken.RemoveTakeAtLevel(Slot.CharacterLevel)
        Character.Spells.UpdateSpell(SpellTaken)

        'clear the slot
        Slot.SpellClear()
        Slot.ReplaceClear()
        If Slot.SlotType = SpellSlotType.Replace_In_Progres_Type Then
            Slot.SlotType = Rules.SpellSlotType.Replace_Start_Type
        End If

        AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)

        If LevelReplaced > 0 Then

            Dim TempSlot As Rules.SpellSlot
            Dim ReplacedSlot As New Rules.SpellSlot

            For Each Item As ListViewItem In AvailableSlots.Items
                TempSlot = CType(Item.Tag, Rules.SpellSlot)
                If TempSlot.SlotType = Rules.SpellSlotType.Replace_In_Progres_Type AndAlso TempSlot.CharacterLevel = LevelReplaced AndAlso TempSlot.ReplaceGuid.Equals(SpellTaken.SpellGuid) Then
                    ReplacedSlot = TempSlot
                    TempIndex = Item.Index
                    Exit For
                End If
            Next

            'clear the slot and put back the spell that was taken
            RemoveSpell_CancelReplace(ReplacedSlot, TempIndex)

        End If

    End Sub

    'recursive part of returning a spell that might of been repicked
    Private Sub RemoveSpell_CancelRepick(ByVal Slot As Rules.SpellSlot, ByVal SlotIndex As Integer)
        Dim ReplaceSpell, SpellTaken As Rules.Spell
        Dim TempSlot As Rules.SpellSlot
        Dim NextLevel As Integer
        Dim ReTakenSlot As New Rules.SpellSlot
        Dim ReplacedSlot As New Rules.SpellSlot

        SpellTaken = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.SpellGuid, Slot.SourceGuid)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'If the spell taken has been replaced
        Dim LevelReplaced As Integer = SpellTaken.LevelReplaced(Slot.CharacterLevel)
        Dim TempIndex As Integer
        SpellTaken.RemoveTakeAtLevel(Slot.CharacterLevel)
        Character.Spells.UpdateSpell(SpellTaken)

        If LevelReplaced > 0 Then

            For Each Item As ListViewItem In AvailableSlots.Items
                TempSlot = CType(Item.Tag, Rules.SpellSlot)
                If TempSlot.SlotType = Rules.SpellSlotType.Replace_In_Progres_Type AndAlso TempSlot.CharacterLevel = LevelReplaced AndAlso TempSlot.ReplaceGuid.Equals(SpellTaken.SpellGuid) Then
                    ReplacedSlot = TempSlot
                    TempIndex = Item.Index
                    Exit For
                End If
            Next
            'clear the slot and put back the spell that was taken
            RemoveSpell_CancelReplace(ReplacedSlot, TempIndex)
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'If the Replaced Spell has been repicked
        ReplaceSpell = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.ReplaceGuid, Slot.ReplaceSourceGuid)
        NextLevel = ReplaceSpell.NextLevelTaken(Slot.CharacterLevel)
        While NextLevel <> 0

            'Get the slot at that level
            For Each Item As ListViewItem In AvailableSlots.Items
                TempSlot = CType(Item.Tag, Rules.SpellSlot)
                If TempSlot.CharacterLevel = NextLevel AndAlso TempSlot.SpellGuid.Equals(ReplaceSpell.SpellGuid) Then
                    ReTakenSlot = TempSlot
                    TempIndex = Item.Index
                    Exit For
                End If
            Next

            Select Case ReTakenSlot.SlotType

                Case Rules.SpellSlotType.Known_Type

                    'Clear the Slot
                    ReTakenSlot.SpellClear()
                    AvailableSlots.Items(TempIndex) = LoadSlot(ReTakenSlot)
                    SpellsTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(SpellsTaken(ClassInfo.ClassObj.ObjectGUID)) - 1

                    'If it has been replaced cancel the replace
                    LevelReplaced = (ReplaceSpell.LevelReplaced(ReTakenSlot.CharacterLevel))
                    ReplaceSpell.RemoveTakeAtLevel(ReTakenSlot.CharacterLevel)
                    Character.Spells.UpdateSpell(ReplaceSpell)

                    If LevelReplaced > 0 Then

                        For Each Item As ListViewItem In AvailableSlots.Items
                            TempSlot = CType(Item.Tag, Rules.SpellSlot)
                            If TempSlot.SlotType = Rules.SpellSlotType.Replace_In_Progres_Type AndAlso TempSlot.CharacterLevel = LevelReplaced AndAlso TempSlot.ReplaceGuid.Equals(ReplaceSpell.SpellGuid) Then
                                ReplacedSlot = TempSlot
                                TempIndex = Item.Index
                                Exit For
                            End If
                        Next

                        'clear the slot and put back the spell that was taken
                        RemoveSpell_CancelReplace(ReplacedSlot, TempIndex)

                    End If

                Case Rules.SpellSlotType.Replace_In_Progres_Type
                    'do this all again
                    RemoveSpell_CancelRepick(ReTakenSlot, TempIndex)

            End Select

            ReplaceSpell = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.ReplaceGuid, Slot.ReplaceSourceGuid)
            NextLevel = ReplaceSpell.NextLevelTaken(Slot.CharacterLevel)
        End While

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'replace spell set
        ReplaceSpell = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.ReplaceGuid, Slot.ReplaceSourceGuid)
        ReplaceSpell.RemoveReplaceAtLevel(Slot.CharacterLevel)
        Character.Spells.UpdateSpell(ReplaceSpell)

        'Clear the slot
        Slot.SpellClear()
        Slot.ReplaceClear()
        Slot.SlotType = Rules.SpellSlotType.Replace_Start_Type
        AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)

    End Sub

    'returns the selected spell
    Private Sub PutSpellBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutSpellBack.Click
        Dim Slot As Rules.SpellSlot
        Dim Spell As Rules.Spell
        Dim SlotIndex As Integer

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.SpellSlot)
        If Slot.SpellName = "" Then
            If Slot.SlotType = Rules.SpellSlotType.Replace_In_Progres_Type Then
                SlotIndex = AvailableSlots.SelectedIndices(0)
                Slot.ReplaceClear()
                Slot.SlotType = Rules.SpellSlotType.Replace_Start_Type
                AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)
                AvailableSlots.Items(SlotIndex).Selected = True
            End If
            Exit Sub
        End If

        If Slot.Fixed Then Exit Sub

        Select Case Slot.SlotType

            Case Rules.SpellSlotType.Known_Type

                SlotIndex = AvailableSlots.SelectedIndices(0)
                RemoveSpell_CancelReplace(Slot, SlotIndex)
                SpellsTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(SpellsTaken(ClassInfo.ClassObj.ObjectGUID)) - 1
                AvailableSlots.Items(SlotIndex).Selected = True
                EnableDisableNext()

            Case Rules.SpellSlotType.Replace_In_Progres_Type

                SlotIndex = AvailableSlots.SelectedIndices(0)
                RemoveSpell_CancelRepick(Slot, SlotIndex)
                AvailableSlots.Items(SlotIndex).Selected = True

            Case Rules.SpellSlotType.Book_Type

                Spell = Character.Spells.GetSpell(ClassInfo.ClassObj.ObjectGUID, Slot.SpellGuid, Slot.SourceGuid)

                Slot.SpellClear()
                SlotIndex = AvailableSlots.SelectedIndices(0)
                AvailableSlots.BeginUpdate()
                AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                Spell.RemoveTakeAtLevel(Slot.CharacterLevel)
                Character.Spells.UpdateSpell(Spell)

                AvailableSlots.Items(SlotIndex).Selected = True
                AvailableSlots.EnsureVisible(SlotIndex)
                AvailableSlots.EndUpdate()
                SpellsTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(SpellsTaken(ClassInfo.ClassObj.ObjectGUID)) - 1
                EnableDisableNext()

        End Select

    End Sub

#End Region

    ''Method to check all the spell slots and update where appropraite
    'Private Sub ReInit()

    '    'Check through the spellslots hastable - validating each classes slots
    '    For Each Key As Objects.ObjectKey In SpellSlots.Keys

    '        Dim ClassObj As Objects.ObjectData
    '        '  ClassObj = CType(CasterClasses(Key), Rules.CharacterClass).ClassObj
    '        ClassObj = CType(Character.CharacterClasses(Key), Rules.CharacterClass).ClassObj

    '        Select Case ClassObj.Element("CasterType")

    '            Case "Arcane (Wizard)"
    '                Dim CheckedLevels As New Hashtable(20)
    '                Dim SlotListViewItem As ListViewItem
    '                Dim Slot As Rules.SpellSlot
    '                Dim MaxSpellLevel As Integer

    '                For Each SlotListViewItem In CType(SpellSlots(Key), ListViewItem())

    '                    'get the slot from the ListViewItemTag
    '                    Slot = CType(SlotListViewItem.Tag, Rules.SpellSlot)

    '                    'check that at the characterlevel this slot was gained, the maxspell level is the same
    '                    If CheckedLevels.ContainsKey(Slot.CharacterLevel) Then
    '                        MaxSpellLevel = CInt(CheckedLevels(Slot.CharacterLevel))
    '                    Else
    '                        MaxSpellLevel = Character.Spells.AvailableSpells.GetMaxSpellLevelAtCharacterLevel(CType(Character.CharacterClasses(Key), Rules.CharacterClass), Slot.CharacterLevel)
    '                        CheckedLevels(Slot.CharacterLevel) = MaxSpellLevel
    '                    End If

    '                    Select Case MaxSpellLevel - Slot.MaxSpellLevel

    '                        Case 0
    '                            'Levels are the same - do nothing

    '                        Case Is < 0
    '                            'Spell level has been reduced
    '                            Slot.MaxSpellLevel = MaxSpellLevel

    '                            'if the spell is to high for the slot - have to return the spell
    '                            If Slot.SpellName <> "" Then
    '                                If (Slot.SpellLevel < Slot.MaxSpellLevel) And (Slot.Fixed <> True) Then

    '                                    Dim LearnedSpell As Rules.Spell
    '                                    Dim ClassSpells As Hashtable

    '                                    ClassSpells = CType(Character.Spells(ClassInfo.ClassObj.ObjectGUID), Hashtable)
    '                                    LearnedSpell = CType(ClassSpells(Slot.SpellGuid), Rules.Spell)

    '                                    LearnedSpell.RemoveTakeAtLevel(Slot.CharacterLevel)

    '                                    Slot.SpellClear()

    '                                    SlotListViewItem.Tag = Slot
    '                                End If
    '                            End If

    '                        Case Is > 0
    '                            'Spell level has been increased

    '                            'Increase the slot spell level
    '                            Slot.MaxSpellLevel = MaxSpellLevel
    '                            SlotListViewItem.Tag = Slot
    '                    End Select
    '                Next

    '            Case "Arcane (Sorceror)"

    '        End Select

    '    Next

    'End Sub

    'move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        Dim Slot As Rules.SpellSlot

        For Each Item As ListViewItem In AvailableSlots.Items
            Slot = CType(Item.Tag, Rules.SpellSlot)
            If Slot.SpellName = "" And Slot.SlotType <> Rules.SpellSlotType.Replace_Start_Type Then
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
        For Each Item As DictionaryEntry In SpellsTaken
            Dim Taken, Slots As Integer
            Taken = CInt(Item.Value)
            Slots = CInt(SlotCounts(Item.Key))

            If Taken <> Slots Then
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

    Private Sub AvailablePowers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSpells.DoubleClick
        TakeSpell_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutSpellBack_Click(Nothing, Nothing)
    End Sub

End Class