Option Strict On
Option Explicit On

Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class AddPowersKnown
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
    Public WithEvents AvailablePowers As System.Windows.Forms.ListView
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AddPowersKnown))
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
        Me.AvailablePowers = New System.Windows.Forms.ListView
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
        Me.ObjLabel.Text = "Please select your powers"
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
        Me.ColumnHeader2.Text = "Power Level"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 75
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Power Taken"
        Me.ColumnHeader3.Width = 138
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailablePowers)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 250)
        Me.Panel2.TabIndex = 138
        '
        'AvailablePowers
        '
        Me.AvailablePowers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailablePowers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.AvailablePowers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailablePowers.FullRowSelect = True
        Me.AvailablePowers.HideSelection = False
        Me.AvailablePowers.Location = New System.Drawing.Point(1, 1)
        Me.AvailablePowers.MultiSelect = False
        Me.AvailablePowers.Name = "AvailablePowers"
        Me.AvailablePowers.Size = New System.Drawing.Size(408, 248)
        Me.AvailablePowers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailablePowers.TabIndex = 122
        Me.AvailablePowers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Powers"
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
        Me.ColumnHeader6.Text = "Dscipline"
        Me.ColumnHeader6.Width = 177
        '
        'PutSpellBack
        '
        Me.PutSpellBack.Location = New System.Drawing.Point(335, 340)
        Me.PutSpellBack.Name = "PutSpellBack"
        Me.PutSpellBack.Size = New System.Drawing.Size(90, 24)
        Me.PutSpellBack.TabIndex = 137
        Me.PutSpellBack.Text = "PutPower Back"
        '
        'TakeSpell
        '
        Me.TakeSpell.Location = New System.Drawing.Point(240, 340)
        Me.TakeSpell.Name = "TakeSpell"
        Me.TakeSpell.Size = New System.Drawing.Size(90, 24)
        Me.TakeSpell.TabIndex = 136
        Me.TakeSpell.Text = "Take Power"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "Manifesting Class"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LegendButton
        '
        Me.LegendButton.Location = New System.Drawing.Point(15, 340)
        Me.LegendButton.Name = "LegendButton"
        Me.LegendButton.Size = New System.Drawing.Size(90, 24)
        Me.LegendButton.TabIndex = 320
        Me.LegendButton.Text = "Power Legend"
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
        'AddPowersKnown
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
        Me.Name = "AddPowersKnown"
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
    Private Manifesters As ArrayList

    'Private CasterClasses As New Hashtable(5)
    Private ClassInfo As Rules.CharacterClass

    'Hashtable to store the slots for the different classes
    'Key:- ClassGuid, Value:- ArrayList of Rules.PowerSlot
    Private PowerSlots As New Hashtable(5)
    Private SlotCounts As New Hashtable(5)
    Private PowersTaken As New Hashtable(5)

    Private LastShownSpell As String
    Private PreviousURL As String
    'Private PowersTaken As Integer
    Private AllowSpell, AllowSlot As Boolean

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As Rules.PowerSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, Rules.PowerSlot)
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

        Manifesters = New ArrayList

        'if the race itself a caster?
        If Me.Character.RaceObject.Element("CasterType") = "Psionic" Then
            Dim CasterKey As Objects.ObjectKey = Me.Character.RaceObject.GetFKGuid("CasterSource")

            'if this class is not already in the ChatacterClasses table then add it now
            If Not Character.CharacterClasses.Contains(CasterKey) Then Character.CharacterClasses.Add(CasterKey)
        End If

        'go through the character and find spellcasting classes
        For Each TempClassInfo As Rules.CharacterClass In Character.CharacterClasses.Values
            If TempClassInfo.IsPsionic Then

                'store the manifesters that are going to have to choose powers
                If TempClassInfo.CasterInfo.ManualPowers = False Then
                    Manifesters.Add(TempClassInfo)
                End If

            End If
        Next

        If Manifesters.Count = 0 Then Return False

        Dim ClassSlotCount As Integer
        Dim CopyToArray() As ListViewItem

        'Load the slots for every class
        For Each TempClassInfo As Rules.CharacterClass In Manifesters

            Character.Powers.AvailablePowers.LoadPowers(TempClassInfo, Character)
            ClassSlotCount = LoadSlots(TempClassInfo)
            Me.ClassInfo = TempClassInfo

            If ClassSlotCount > 0 Then
                SlotCounts.Item(TempClassInfo.ClassObj.ObjectGUID) = ClassSlotCount
                PowersTaken.Item(TempClassInfo.ClassObj.ObjectGUID) = 0
                ClassDropdown.Properties.Items.Add(New DataListItem(TempClassInfo, TempClassInfo.ClassObj.Name))

                'Copy the slots into an array and store them in a hashtable
                ReDim CopyToArray(AvailableSlots.Items.Count - 1)
                AvailableSlots.Items.CopyTo(CopyToArray, 0)
                PowerSlots(TempClassInfo.ClassObj.ObjectGUID) = CopyToArray
            End If
        Next

        If PowerSlots.Count = 0 Then Return False

        ClassDropdown.SelectedIndex = 0

        Return True

    End Function

    'Load the slots for the currently selected class
    Private Function LoadSlots(ByVal ClassInfo As Rules.CharacterClass) As Integer
        Dim Slots As ArrayList
        Dim Slot As Rules.PowerSlot
        Dim SlotCount As Integer

        Try
            'Get the slots for the current class
            Slots = Character.Powers.AvailablePowers.AvailablePowerSlots(ClassInfo)
            Slots.Sort()
            Slots.Reverse()

            'Clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()
            SlotCount = 0

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
    Private Function LoadSlot(ByVal Slot As Rules.PowerSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = "Level " & Slot.CharacterLevel
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add("Power Gained")
            ListViewItem.SubItems.Add(Slot.MaxPowerLevel.ToString)
            ListViewItem.SubItems.Add(Slot.PowerName)
            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Gets the list of avialable spells based on the current class and the selected slot
    Private Sub UpdateSpellList()
        Dim SpellList As New ArrayList
        Dim SpellInfo As Rules.AvailablePower

        Try
            AvailablePowers.BeginUpdate()
            AvailablePowers.Items.Clear()

            SpellList = Character.Powers.AvailablePowers.AvailablePowersList(SelectedSlot, ClassInfo)

            'add the spells to the list
            For Each SpellInfo In SpellList
                AvailablePowers.Items.Add(LoadSpell(SpellInfo))
            Next

            'show current spell if any
            If LastShownSpell <> "" Then
                For Each Item As ListViewItem In AvailablePowers.Items
                    If Item.Text = LastShownSpell Then
                        Item.Selected = True
                        Item.EnsureVisible()
                        AvailablePowers.EndUpdate()
                        Exit Sub
                    End If
                Next
            End If

            'sort
            AvailablePowers.ListViewItemSorter = New Sorter.ListViewItemComparer(SortType.Numeric, 1, SortOrder.Descending)
            AvailablePowers.Sort()

            'select first item
            If AvailablePowers.Items.Count > 0 Then AvailablePowers.Items(0).Selected = True

            AvailablePowers.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creats a listview item for an available spell
    Private Function LoadSpell(ByVal PowerInfo As Rules.AvailablePower) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = PowerInfo.PowerName
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, PowerInfo.PowerLevel.ToString))
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, PowerInfo.PowerSchool))

            ListViewItem.Tag = PowerInfo

            Select Case PowerInfo.Status
                Case Rules.AvailablePowerStatus.AlreadyHave
                    ListViewItem.ForeColor = Constants.TakenSpellColor
                Case Rules.AvailablePowerStatus.SacrificedSchool
                    ListViewItem.ForeColor = Constants.RestrictedSpellColor
                Case Rules.AvailablePowerStatus.Allowed
                    Select Case PowerInfo.SourceType

                        Case PowerSourceType.Class
                            ListViewItem.ForeColor = Constants.ClassSpellColor

                        Case PowerSourceType.PsionicSpecialization
                            ListViewItem.ForeColor = Constants.DomainSpellColor

                        Case PowerSourceType.PrestigeClass
                            ListViewItem.ForeColor = Constants.PrestigeSpellColor

                        Case PowerSourceType.PrestigePsionicSpecialization
                            ListViewItem.ForeColor = Constants.PrestigeDomainSpellColor

                        Case PowerSourceType.RacialAddition
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
            Dim PowerLegend As New SpellLegendPanel
            PowerLegend.SetPowerMode()
            PowerLegend.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the available spells for the new slot
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot, TempSlot As Rules.PowerSlot
        Dim SlotIndex As Integer
        ' Dim ListViewItem As ListViewItem

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Slot = SelectedSlot()
                UpdateSpellList()

                SlotIndex = AvailableSlots.SelectedIndices(0)

                'Clear any Replace In Progress Types that have been clicked off of
                For Each Item As ListViewItem In AvailableSlots.Items
                    TempSlot = CType(Item.Tag, Rules.PowerSlot)
                Next

                Select Case Slot.SlotType

                    Case PowerSlotType.Normal
                        TakeSpell.Text = "Take Power"
                        If Slot.PowerName = "" Then
                            AllowSlot = True
                            PutSpellBack.Enabled = False
                        Else
                            AllowSlot = False
                            PutSpellBack.Enabled = True
                        End If

                End Select

                If AllowSpell And AllowSlot Then
                    TakeSpell.Enabled = True
                Else
                    TakeSpell.Enabled = False
                End If

            Else
                TakeSpell.Enabled = False
                PutSpellBack.Enabled = True
            End If

            If Slot.PowerGuid.IsNotEmpty Then
                Dim Spell As New Objects.ObjectData
                Spell.Load(Slot.PowerGuid)
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
    Private Sub AvailablePowers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailablePowers.SelectedIndexChanged
        Dim Spell As Rules.AvailablePower

        Try
            If AvailablePowers.SelectedItems.Count > 0 Then
                Spell = CType(AvailablePowers.SelectedItems(0).Tag, Rules.AvailablePower)
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


                If Spell.Status = Rules.AvailablePowerStatus.SacrificedSchool Or Spell.Status = Rules.AvailablePowerStatus.AlreadyHave Then
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
            PowerSlots(ClassInfo.ClassObj.ObjectGUID) = CopyToArray

            'Clear the slots and get the new class
            AvailableSlots.Items.Clear()
            ClassInfo = CType(CType(ClassDropdown.SelectedItem, DataListItem).ValueMember, Rules.CharacterClass)

            'Load the slots for the new class
            CopyToArray = CType(PowerSlots(ClassInfo.ClassObj.ObjectGUID), ListViewItem())
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
    Private Sub TakePower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeSpell.Click
        Dim Slot As Rules.PowerSlot
        Dim Power As Rules.AvailablePower
        Dim SlotIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailablePowers.SelectedItems.Count) <> 2 Then Exit Sub

        'get the spell and the slot
        Power = CType(AvailablePowers.SelectedItems(0).Tag, Rules.AvailablePower)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.PowerSlot)

        If Not Power.Status = Rules.AvailablePowerStatus.Allowed Then Exit Sub

        If Slot.PowerName = "" Then

            Select Case Slot.SlotType

                Case Rules.PowerSlotType.Normal
                    Slot.PowerName = Power.PowerName
                    Slot.PowerLevel = Power.PowerLevel
                    Slot.PowerGuid = Power.PowerGuid
                    Slot.SourceGuid = Power.SourceGuid

                    AvailableSlots.BeginUpdate()
                    SlotIndex = AvailableSlots.SelectedIndices(0)
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    Character.Powers.TakePower(Power.PowerGuid, Power.PowerName, ClassInfo.ClassObj.ObjectGUID, ClassInfo.ClassObj.Name, Power.SourceGuid, Power.SourceName, Power.PowerLevel, Slot.CharacterLevel)
                    PowersTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(PowersTaken(ClassInfo.ClassObj.ObjectGUID)) + 1

                    AvailableSlots.EndUpdate()
                    LastShownSpell = Power.PowerName

            End Select

            EnableDisableNext()
            MoveToNextAvailableSlot(SlotIndex)
        End If

    End Sub


    'returns the selected spell
    Private Sub PutSpellBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutSpellBack.Click
        Dim Slot As Rules.PowerSlot
        Dim Power As Rules.Power
        Dim SlotIndex As Integer

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.PowerSlot)
        If Slot.PowerName = "" Then
            Exit Sub
        End If

        Select Case Slot.SlotType

            Case Rules.PowerSlotType.Normal
                Power = Character.Powers.GetPower(ClassInfo.ClassObj.ObjectGUID, Slot.PowerGuid, Slot.SourceGuid)
                Slot.PowerClear()
                SlotIndex = AvailableSlots.SelectedIndices(0)
                AvailableSlots.BeginUpdate()
                AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                Power.RemoveTakeAtLevel(Slot.CharacterLevel)
                Character.Powers.UpdatePower(Power)

                AvailableSlots.Items(SlotIndex).Selected = True
                AvailableSlots.EnsureVisible(SlotIndex)
                AvailableSlots.EndUpdate()
                PowersTaken(ClassInfo.ClassObj.ObjectGUID) = CInt(PowersTaken(ClassInfo.ClassObj.ObjectGUID)) - 1
                EnableDisableNext()

        End Select

    End Sub

#End Region

    '
    'move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        Dim Slot As Rules.PowerSlot

        For Each Item As ListViewItem In AvailableSlots.Items
            Slot = CType(Item.Tag, Rules.PowerSlot)
            If Slot.PowerName = "" Then
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
        For Each Item As DictionaryEntry In PowersTaken
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
    Private Sub AvailablePowers_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles AvailablePowers.ColumnClick
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

        AvailablePowers.ListViewItemSorter = New Sorter.ListViewItemComparer(SortType, e.Column, SortDirection)
        AvailablePowers.Sort()
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

    Private Sub AvailablePowers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailablePowers.DoubleClick
        TakePower_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutSpellBack_Click(Nothing, Nothing)
    End Sub

End Class
