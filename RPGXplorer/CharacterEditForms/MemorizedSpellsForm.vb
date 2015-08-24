Option Strict On
Option Explicit On

Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class MemorizedSpellsForm
    Inherits Windows.Forms.Form

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
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents AvailableSpells As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Public WithEvents PutSpellBack As System.Windows.Forms.Button
    Public WithEvents TakeSpell As System.Windows.Forms.Button
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Private WithEvents MetaButton As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableSpells = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.PutSpellBack = New System.Windows.Forms.Button
        Me.TakeSpell = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.MetaButton = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MetaButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.Location = New System.Drawing.Point(440, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(495, 565)
        Me.Panel1.TabIndex = 135
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(493, 563)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(325, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please select your memorized spells"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.Location = New System.Drawing.Point(15, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(410, 215)
        Me.Panel3.TabIndex = 139
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.AvailableSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSlots.FullRowSelect = True
        Me.AvailableSlots.HideSelection = False
        Me.AvailableSlots.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSlots.MultiSelect = False
        Me.AvailableSlots.Name = "AvailableSlots"
        Me.AvailableSlots.Size = New System.Drawing.Size(408, 213)
        Me.AvailableSlots.TabIndex = 123
        Me.AvailableSlots.UseCompatibleStateImageBehavior = False
        Me.AvailableSlots.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Slot Name"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Spell Taken"
        Me.ColumnHeader1.Width = 151
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Metamagic"
        Me.ColumnHeader2.Width = 140
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableSpells)
        Me.Panel2.Location = New System.Drawing.Point(15, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(410, 275)
        Me.Panel2.TabIndex = 138
        '
        'AvailableSpells
        '
        Me.AvailableSpells.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSpells.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.AvailableSpells.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSpells.FullRowSelect = True
        Me.AvailableSpells.HideSelection = False
        Me.AvailableSpells.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSpells.MultiSelect = False
        Me.AvailableSpells.Name = "AvailableSpells"
        Me.AvailableSpells.Size = New System.Drawing.Size(408, 273)
        Me.AvailableSpells.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableSpells.TabIndex = 122
        Me.AvailableSpells.UseCompatibleStateImageBehavior = False
        Me.AvailableSpells.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Spell"
        Me.ColumnHeader4.Width = 339
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Level"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 51
        '
        'PutSpellBack
        '
        Me.PutSpellBack.Location = New System.Drawing.Point(335, 330)
        Me.PutSpellBack.Name = "PutSpellBack"
        Me.PutSpellBack.Size = New System.Drawing.Size(90, 24)
        Me.PutSpellBack.TabIndex = 137
        Me.PutSpellBack.Text = "Put Spell Back"
        '
        'TakeSpell
        '
        Me.TakeSpell.Location = New System.Drawing.Point(240, 330)
        Me.TakeSpell.Name = "TakeSpell"
        Me.TakeSpell.Size = New System.Drawing.Size(90, 24)
        Me.TakeSpell.TabIndex = 136
        Me.TakeSpell.Text = "Take Spell"
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(785, 610)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 274
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(865, 610)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 275
        Me.Cancel.Text = "Cancel"
        '
        'MetaButton
        '
        Me.MetaButton.EditValue = ""
        Me.MetaButton.Location = New System.Drawing.Point(75, 332)
        Me.MetaButton.Name = "MetaButton"
        Me.MetaButton.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.MetaButton.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MetaButton.Size = New System.Drawing.Size(140, 20)
        Me.MetaButton.TabIndex = 277
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(15, 332)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 20)
        Me.LabelControl1.TabIndex = 278
        Me.LabelControl1.Text = "Metamagic"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 595)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(920, 5)
        Me.IndentedLine2.TabIndex = 276
        Me.IndentedLine2.TabStop = False
        '
        'MemorizedSpellsForm
        '
        Me.AcceptButton = Me.OK
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.MetaButton)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PutSpellBack)
        Me.Controls.Add(Me.TakeSpell)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ObjLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MemorizedSpellsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memorized Spells"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.MetaButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Enumerations"

    'Spell slot type
    Public Enum MemorizedSpellSlotType
        Standard
        Domain
        Specialist
    End Enum

#End Region

#Region "Structures"

    'spell slot strucutre for use in the spells panel
    Private Structure MemorizedSpellSlot
        Implements IComparable

        Public MaxSpellLevel As Integer
        Public ClassGuid As Objects.ObjectKey
        Public ClassName As String

        'spell taken info
        Public SpellGuid As Objects.ObjectKey
        Public SpellName As String
        Public SpellLevel As Integer

        'Metamagic Info
        Public MetaMagic As ArrayList

        Public SlotType As MemorizedSpellSlotType

        Public Sub Clear()
            Try
                MaxSpellLevel = Nothing
                ClassGuid = Nothing
                ClassName = Nothing
                SpellGuid = Nothing
                SpellName = Nothing
                MetaMagic = Nothing
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Sub SpellClear()
            SpellGuid = Nothing
            SpellName = Nothing
            SpellLevel = Nothing
            MetaMagic = New ArrayList
        End Sub

        Public Overrides Function ToString() As String
            Try
                Return SpellName
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As MemorizedSpellSlot
            Try

                Data = CType(obj, MemorizedSpellSlot)

                If Data.ClassName < ClassName Then
                    Return 1
                ElseIf Data.ClassName > ClassName Then
                    Return -1
                Else
                    If Data.MaxSpellLevel < MaxSpellLevel Then
                        Return 1
                    ElseIf Data.MaxSpellLevel > MaxSpellLevel Then
                        Return -1
                    Else
                        If Data.SlotType > SlotType Then
                            Return 1
                        ElseIf Data.SlotType < SlotType Then
                            Return -1
                        Else
                            Return 0
                        End If
                    End If
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Structure

    Private Structure SpellListFlags
        Public ClassKey As Objects.ObjectKey
        Public DomainListRequired As Boolean
        Public SpecialistListRequired As Boolean
        Public StandardListRequired As Boolean
    End Structure

    Private Structure SpellListCollection
        Public ClassKey As Objects.ObjectKey
        'lists as indexed by spell level for quick look up
        Public DomainList As OneKeyList
        Public StandardList As OneKeyList
        Public SpecialistList As OneKeyList

        Public SpecialistSchools As Hashtable
    End Structure

#End Region

#Region "Member Variables"

    ''panel variables
    'Private IsInitialised As Boolean

    'Private Spellcasters As ArrayList

    ''Private CasterClasses As New Hashtable(5)
    'Private ClassInfo As Rules.CharacterClass

    ''Hashtable to store the slots for the different classes
    ''Key:- ClassGuid, Value:- ArrayList of Rules.SpellSlot
    'Private SpellSlots As New Hashtable(5)
    'Private SlotCounts As New Hashtable(5)
    'Private SpellsTaken As New Hashtable(5)

    Private LastShownSpell As String
    Private PreviousURL As String
    Private AllowSpell, AllowSlot As Boolean

    Private Character As Rules.Character
    Private ExistingMemorizedSpells As Objects.ObjectDataCollection
    Private ClassSpellListFlags As New Hashtable
    Private ClassSpellLists As New Hashtable
    Private ClassSpellFolders As New Hashtable

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As MemorizedSpellSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, MemorizedSpellSlot)
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
    Public Function Init() As Boolean
        Try

            'get the memorized spell components
            Me.Character = CharacterManager.CurrentCharacter
            Me.ExistingMemorizedSpells = Character.MemorizedSpellsFolder.Children
            LoadSlots(ExistingMemorizedSpells)

            'get all the characters spell folders         
            For Each Folder As Objects.ObjectData In Character.MagicFolder.ChildrenOfType(Objects.ClassSpellListFolderType)
                ClassSpellFolders.Item(Folder.GetFKGuid("Class")) = Folder
            Next

            'get all the SpellLearned objects form the character's classes required
            Dim ClassKeys As New ArrayList(ClassSpellListFlags.Keys)
            Dim Path As New System.Text.StringBuilder("/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellLearnedType & "' and (")

            Path.Append("(ParentGUID='")
            Path.Append(CType(ClassSpellFolders(ClassKeys(0)), Objects.ObjectData).ObjectGUID.ToString)
            Path.Append("')")

            If ClassKeys.Count > 1 Then
                For i As Integer = 1 To ClassKeys.Count - 1
                    Path.Append(" or ")
                    Path.Append("(ParentGUID='")
                    Path.Append(CType(ClassSpellFolders(ClassKeys(i)), Objects.ObjectData).ObjectGUID.ToString)
                    Path.Append("')")
                Next
            End If

            Path.Append(")]")

            Dim AllSpellsLearn As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(Character.CharacterObject.ObjectGUID.Database, Path.ToString)

            'process each spell Taken - adding it to appropriate spell lists
            For Each SpellLearned As Objects.ObjectData In AllSpellsLearn

                Dim ClassKey As Objects.ObjectKey = SpellLearned.GetFKGuid("Class")
                Dim SourceKey As Objects.ObjectKey = SpellLearned.GetFKGuid("Source")

                'get the flags for this class
                Dim Flags As SpellListFlags = CType(ClassSpellListFlags.Item(ClassKey), SpellListFlags)

                'get the list collection for this class
                Dim ListCollection As SpellListCollection
                ListCollection = CType(ClassSpellLists(ClassKey), SpellListCollection)

                'create list collection if required
                If ListCollection.ClassKey.IsEmpty Then
                    'check the flags and make the spell lists required
                    ListCollection.ClassKey = ClassKey
                    If Flags.DomainListRequired Then ListCollection.DomainList = New OneKeyList(10)
                    If Flags.StandardListRequired Then ListCollection.StandardList = New OneKeyList(10)
                    If Flags.SpecialistListRequired Then
                        ListCollection.SpecialistList = New OneKeyList(10)
                        ListCollection.SpecialistSchools = Character.SpecialistSchools(ClassKey)
                    End If
                    ClassSpellLists.Item(ClassKey) = ListCollection
                End If

                Select Case SourceKey.Database
                    Case XML.DBTypes.Domains
                        If Flags.DomainListRequired Then
                            ListCollection.DomainList.Add(SpellLearned.ElementAsInteger("Level"), SpellLearned)
                        End If
                    Case XML.DBTypes.Classes, XML.DBTypes.SpellCategoriesAndDescriptors
                        If Flags.StandardListRequired Then
                            ListCollection.StandardList.Add(SpellLearned.ElementAsInteger("Level"), SpellLearned)
                        End If
                        If Flags.SpecialistListRequired Then
                            'if spell is of required school add it to the list
                            Dim SpellDef As Objects.ObjectData = Rules.SpellList.SpellDefinition(SpellLearned.GetFKGuid("Spell"))
                            If Not SpellDef.IsEmpty Then
                                If ListCollection.SpecialistSchools.ContainsKey(SpellDef.GetFKGuid("School")) Then
                                    ListCollection.SpecialistList.Add(SpellLearned.ElementAsInteger("Level"), SpellLearned)
                                End If
                            End If
                        End If
                    Case Else
                        Throw New Exceptions.RulesException("Found spell: " & SpellLearned.Name & " - which unexpected source database: " & SourceKey.Database.ToString & " - cannot continue")
                End Select
            Next

            'load the metabutton
            Dim MetaFeats As New Objects.ObjectDataCollection
            MetaFeats = Objects.GetObjectsByXPath(XML.DBTypes.Feats, RPGXplorer.XPathQueries.MetamagicFeats)

            Dim FeatList As DataListItem()
            FeatList = Rules.Index.DataList(MetaFeats)

            MetaButton.Properties.Items.AddRange(FeatList)

            'select the first slot
            AvailableSlots.Items(0).Selected = True

        Catch ex As Exceptions.RulesException
            Dim Box As New RPGXplorer.ErrorForm
            Box.ErrorMessage = ex.Message
            Box.ShowDialog()
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Load the slots for the currently selected class
    Private Sub LoadSlots(ByVal MemorizedSpells As Objects.ObjectDataCollection)
        Dim Slots As New ArrayList
        Dim Slot As New MemorizedSpellSlot

        Dim TempClasses As New Hashtable

        'flag tables for generating spell lists
        Dim SpecialistClasses As New Hashtable
        Dim DomainClasses As New Hashtable
        Dim StandardClasses As New Hashtable
        Dim Flags As SpellListFlags

        Try

            'Get the slots for the current class
            For Each MemorizedSpell As Objects.ObjectData In MemorizedSpells
                Slot.Clear()

                Slot.ClassName = MemorizedSpell.Element("Class")
                Slot.ClassGuid = MemorizedSpell.GetFKGuid("Class")
                Slot.MaxSpellLevel = MemorizedSpell.ElementAsInteger("Level")
                Select Case MemorizedSpell.Element("SlotType")
                    Case "Standard"
                        Slot.SlotType = MemorizedSpellSlotType.Standard
                        StandardClasses.Item(Slot.ClassGuid) = Nothing
                    Case "Domain"
                        Slot.SlotType = MemorizedSpellSlotType.Domain
                        DomainClasses.Item(Slot.ClassGuid) = Nothing
                    Case "Specialist"
                        Slot.SlotType = MemorizedSpellSlotType.Specialist
                        SpecialistClasses.Item(Slot.ClassGuid) = Nothing
                End Select

                If MemorizedSpell.GetFKGuid("Spell").IsNotEmpty Then
                    Slot.SpellGuid = MemorizedSpell.GetFKGuid("Spell")
                    Slot.SpellName = MemorizedSpell.Element("Spell")
                End If

                Slot.MetaMagic = New ArrayList
                If MemorizedSpell.Element("Metamagic") <> "" Then
                    Dim SplitStrings As String()
                    SplitStrings = MemorizedSpell.Element("Metamagic").Split(",".ToCharArray)
                    For Each MetaTag As String In SplitStrings
                        Slot.MetaMagic.Add(MetaTag.Trim)
                    Next
                End If

                'keep a note of all the classes we have come accross
                TempClasses.Item(Slot.ClassGuid) = Nothing
                Slots.Add(Slot)
            Next

            'record information required for generating spelllists
            For Each ClassKey As Objects.ObjectKey In TempClasses.Keys
                Flags = New SpellListFlags
                Flags.ClassKey = ClassKey
                If DomainClasses.ContainsKey(ClassKey) Then Flags.DomainListRequired = True
                If SpecialistClasses.ContainsKey(ClassKey) Then Flags.SpecialistListRequired = True
                If StandardClasses.ContainsKey(ClassKey) Then Flags.StandardListRequired = True
                ClassSpellListFlags.Item(ClassKey) = Flags
            Next

            Slots.Sort()
            Slots.Reverse()

            'Clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()

            'Add each slot to the listview
            For Each Slot In Slots
                AvailableSlots.Items.Add(LoadSlot(Slot))
            Next

            AvailableSlots.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Generates a ListViewItem from a spell slot
    Private Function LoadSlot(ByVal Slot As MemorizedSpellSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem
        Try
            ListViewItem.Text = Slot.ClassName & " " & Slot.MaxSpellLevel
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add(Slot.SpellName)

            Slot.MetaMagic.Sort()
            ListViewItem.SubItems.Add(RPGXplorer.CommonLogic.CommaSeparatedList(Slot.MetaMagic))

            Select Case Slot.SlotType
                Case MemorizedSpellSlotType.Domain
                    ListViewItem.Text &= " (D)"
                Case MemorizedSpellSlotType.Specialist
                    ListViewItem.Text &= " (S)"
            End Select

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Gets the list of avialable spells based on the current class and the selected slot
    Private Sub UpdateSpellList()
        Dim SpellList As New ArrayList
        Dim SpellLearned As Objects.ObjectData

        Try
            AvailableSpells.BeginUpdate()
            AvailableSpells.Items.Clear()

            'get the spell list for the selectedslot
            SpellList = GetSpellList(SelectedSlot.ClassGuid, SelectedSlot.SlotType, SelectedSlot.MaxSpellLevel)

            'add the spells to the list
            For Each SpellLearned In SpellList
                AvailableSpells.Items.Add(LoadSpell(SpellLearned))
            Next

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

            If AvailableSpells.Items.Count > 0 Then
                AvailableSpells.Items(0).Selected = True
            End If
            AvailableSpells.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Function GetSpellList(ByVal ClassKey As Objects.ObjectKey, ByVal Type As MemorizedSpellSlotType, ByVal SpellLevel As Integer) As ArrayList
        Try

            Dim ReturnList As New ArrayList

            'get the correct Spell List Collection
            Dim SpellCollection As SpellListCollection
            SpellCollection = CType(Me.ClassSpellLists(ClassKey), SpellListCollection)

            'get the correct sepll hastable
            Dim SpellList As OneKeyList = Nothing
            Select Case Type
                Case MemorizedSpellSlotType.Domain
                    SpellList = SpellCollection.DomainList
                Case MemorizedSpellSlotType.Specialist
                    SpellList = SpellCollection.SpecialistList
                Case MemorizedSpellSlotType.Standard
                    SpellList = SpellCollection.StandardList
            End Select

            'SpellList is indexed by spellLevel, so combine the lists up until the given spell level
            If Not SpellList Is Nothing Then
                For i As Integer = 0 To SpellLevel
                    Dim LevelList As ArrayList
                    LevelList = SpellList.Item(i)
                    ReturnList.AddRange(LevelList)
                Next
            End If

            Return ReturnList

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'creates a listviewitem from a spellearned object
    Private Function LoadSpell(ByVal SpellLearned As Objects.ObjectData) As ListViewItem
        Dim ListViewItem As New ListViewItem
        Try
            ListViewItem.Text = SpellLearned.Name
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, SpellLearned.Element("Level")))
            ListViewItem.Tag = SpellLearned
            Return ListViewItem
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#Region "Event Handlers"

    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot As MemorizedSpellSlot
        Dim SlotIndex As Integer

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Slot = SelectedSlot()
                UpdateSpellList()

                SlotIndex = AvailableSlots.SelectedIndices(0)

                If Slot.SpellName = "" Then
                    AllowSlot = True
                    PutSpellBack.Enabled = False
                Else
                    AllowSlot = False
                    PutSpellBack.Enabled = True
                End If

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
        Dim Spell As Objects.ObjectData

        Try
            If AvailableSpells.SelectedItems.Count > 0 Then

                Spell = Rules.SpellList.SpellDefinition(CType(AvailableSpells.SelectedItems(0).Tag, Objects.ObjectData).GetFKGuid("Spell"))
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

                AllowSpell = True

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

    'take the selected spell
    Private Sub TakeSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeSpell.Click
        Dim Slot As MemorizedSpellSlot
        Dim SpellLearned As Objects.ObjectData
        Dim SlotIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailableSpells.SelectedItems.Count) <> 2 Then Exit Sub

        'get the spell and the slot
        SpellLearned = CType(AvailableSpells.SelectedItems(0).Tag, Objects.ObjectData)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, MemorizedSpellSlot)

        If Slot.SpellName = "" Then

            Slot.SpellName = SpellLearned.Name
            Slot.SpellGuid = SpellLearned.GetFKGuid("Spell")
            Slot.SpellLevel = SpellLearned.ElementAsInteger("Level")

            AvailableSlots.BeginUpdate()
            SlotIndex = AvailableSlots.SelectedIndices(0)
            AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

            AvailableSlots.EndUpdate()
            LastShownSpell = SpellLearned.Name

            MoveToNextAvailableSlot(SlotIndex)
        End If

    End Sub

    'ok the form and set the memorized spells
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim Slot As MemorizedSpellSlot
            Dim NewMemorizedSpells As New Objects.ObjectDataCollection

            'generate new memorized spell objects
            ExistingMemorizedSpells.Delete()

            For Each Item As ListViewItem In AvailableSlots.Items
                Slot = CType(Item.Tag, MemorizedSpellSlot)
                NewMemorizedSpells.Add(CreateMemorizedSpell(Slot))
            Next

            NewMemorizedSpells.Save()
            General.MainExplorer.RefreshPanel()
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'creates a memorized spell object from a slot
    Private Function CreateMemorizedSpell(ByVal Slot As MemorizedSpellSlot) As Objects.ObjectData
        Try
            Dim MemorizedSpell As New Objects.ObjectData

            MemorizedSpell.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
            MemorizedSpell.Type = Objects.MemorizedSpellType
            MemorizedSpell.ParentGUID = Character.MemorizedSpellsFolder.ObjectGUID

            MemorizedSpell.FKElement("Class", Slot.ClassName, "Name", Slot.ClassGuid)
            MemorizedSpell.ElementAsInteger("Level") = Slot.MaxSpellLevel
            MemorizedSpell.Element("Metamagic") = RPGXplorer.CommonLogic.CommaSeparatedList(Slot.MetaMagic)
            Select Case Slot.SlotType
                Case MemorizedSpellSlotType.Domain
                    MemorizedSpell.Element("SlotType") = "Domain"
                Case MemorizedSpellSlotType.Specialist
                    MemorizedSpell.Element("SlotType") = "Specialist"
                Case MemorizedSpellSlotType.Standard
                    MemorizedSpell.Element("SlotType") = "Standard"
            End Select

            If Slot.SpellGuid.IsNotEmpty Then
                Dim SpellDef As Objects.ObjectData = Rules.SpellList.SpellDefinition(Slot.SpellGuid)
                If Not SpellDef.IsEmpty Then
                    MemorizedSpell.FKElement("Spell", Slot.SpellName, "Name", Slot.SpellGuid)
                    MemorizedSpell.ElementAsInteger("SpellLevel") = Slot.SpellLevel

                    'add the optional columns                    
                    MemorizedSpell.Element("School") = SpellDef.Element("School")
                    MemorizedSpell.Element("Subschool") = SpellDef.Element("Subschool")
                    MemorizedSpell.Element("Descriptors") = SpellDef.Element("Descriptors")
                    MemorizedSpell.Element("Components") = SpellDef.Element("Components")
                    MemorizedSpell.Element("CastingTime") = SpellDef.Element("CastingTime")
                    MemorizedSpell.Element("Range") = SpellDef.Element("Range")
                    MemorizedSpell.Element("TargetAreaEffect") = SpellDef.Element("TargetAreaEffect")
                    MemorizedSpell.Element("Duration") = SpellDef.Element("Duration")
                    MemorizedSpell.Element("SavingThrow") = SpellDef.Element("SavingThrow")
                    MemorizedSpell.Element("SpellResistance") = SpellDef.Element("SpellResistance")
                    MemorizedSpell.Element("XPCost") = SpellDef.Element("XPCost")
                    MemorizedSpell.Element("ComponentCost") = SpellDef.Element("ComponentCost")
                    MemorizedSpell.Element("Description") = SpellDef.Element("Description")

                    MemorizedSpell.Element("License") = SpellDef.Element("License")
                    MemorizedSpell.Element("Sourcebook") = SpellDef.Element("Sourcebook")
                    MemorizedSpell.Element("Tags") = SpellDef.Element("Tags")
                    MemorizedSpell.Element("PageNoRef") = SpellDef.Element("PageNoRef")
                    MemorizedSpell.HTMLGUID = SpellDef.ObjectGUID
                End If
            End If

            Return MemorizedSpell

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'returns the selected spell
    Private Sub PutSpellBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutSpellBack.Click
        Dim Slot As MemorizedSpellSlot
        Dim SlotIndex As Integer

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        Slot = CType(AvailableSlots.SelectedItems(0).Tag, MemorizedSpellSlot)

        Slot.SpellClear()
        SlotIndex = AvailableSlots.SelectedIndices(0)
        AvailableSlots.BeginUpdate()
        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()
    End Sub

    'shows help page for the selected meta magic feat
    Private Sub MetaButton_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetaButton.SelectedIndexChanged
        Try

            If MetaButton.SelectedIndex <> -1 Then
                Dim FeatObj As Objects.ObjectData
                FeatObj = CType(CType(MetaButton.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)

                If Not FeatObj.IsEmpty Then

                    Dim URL As String

                    If FeatObj.HTML.IndexOf(":\") = 1 And IO.File.Exists(FeatObj.HTML) Then
                        URL = "file://" & FeatObj.HTML
                    Else
                        If IO.File.Exists(General.HelpPath & FeatObj.HTML) Then
                            URL = "file://" & General.HelpPath & FeatObj.HTML
                        Else
                            URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                        End If
                    End If
                    If PreviousURL <> URL Then Browser.Navigate(URL)
                    PreviousURL = URL
                End If

            End If

            AvailableSlots.Refresh()


        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add or removes meta tags to the current spell slot
    Private Sub MetaButton_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles MetaButton.ButtonClick
        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Dim Slot As MemorizedSpellSlot = SelectedSlot
                Select Case e.Button.Kind
                    Case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus
                        'add metamagic to slot
                        Slot.MetaMagic.Add(MetaButton.Text)

                    Case DevExpress.XtraEditors.Controls.ButtonPredefines.Minus
                        If Slot.MetaMagic.Contains(MetaButton.Text) Then
                            Slot.MetaMagic.Remove(MetaButton.Text)
                        End If

                    Case Else
                        Exit Sub
                End Select

                AvailableSlots.BeginUpdate()
                Dim SlotIndex As Integer = AvailableSlots.SelectedIndices(0)
                AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
                AvailableSlots.Items(SlotIndex).Selected = True
                AvailableSlots.EndUpdate()

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'double click handler for selecting spell
    Private Sub AvailablePowers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSpells.DoubleClick
        TakeSpell_Click(Nothing, Nothing)
    End Sub

    'double click handler for removing a spell
    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutSpellBack_Click(Nothing, Nothing)
    End Sub

#End Region

    'move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        Dim Slot As MemorizedSpellSlot

        For Each Item As ListViewItem In AvailableSlots.Items
            Slot = CType(Item.Tag, MemorizedSpellSlot)
            If Slot.SpellName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next

        AvailableSlots.Items(PreviousIndex).Selected = True
        AvailableSlots.EnsureVisible(PreviousIndex)

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
                SortType = SortType.Alphabetic
            Case 1
                SortType = SortType.Alphabetic
            Case 2
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

End Class