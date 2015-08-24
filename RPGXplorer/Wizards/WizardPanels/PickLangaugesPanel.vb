Option Strict On
Option Explicit On

Public Class PickLangaugesPanel
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
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents AvailableLanguages As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents RemoveLanguage As System.Windows.Forms.Button
    Public WithEvents TakeLanguage As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PickLangaugesPanel))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableLanguages = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.RemoveLanguage = New System.Windows.Forms.Button
        Me.TakeLanguage = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Please select known languages"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(440, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 535)
        Me.Panel1.TabIndex = 313
        '
        'Browser
        '
        Me.Browser.BackColor = System.Drawing.Color.White
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.Browser.Enabled = True
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Size = New System.Drawing.Size(493, 533)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.AvailableLanguages)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 255)
        Me.Panel2.TabIndex = 310
        '
        'AvailableLanguages
        '
        Me.AvailableLanguages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableLanguages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.AvailableLanguages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableLanguages.FullRowSelect = True
        Me.AvailableLanguages.HideSelection = False
        Me.AvailableLanguages.Location = New System.Drawing.Point(1, 1)
        Me.AvailableLanguages.MultiSelect = False
        Me.AvailableLanguages.Name = "AvailableLanguages"
        Me.AvailableLanguages.Size = New System.Drawing.Size(408, 253)
        Me.AvailableLanguages.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableLanguages.TabIndex = 122
        Me.AvailableLanguages.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Available Languages"
        Me.ColumnHeader4.Width = 378
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 185)
        Me.Panel3.TabIndex = 311
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader3})
        Me.AvailableSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableSlots.FullRowSelect = True
        Me.AvailableSlots.HideSelection = False
        Me.AvailableSlots.Location = New System.Drawing.Point(1, 1)
        Me.AvailableSlots.MultiSelect = False
        Me.AvailableSlots.Name = "AvailableSlots"
        Me.AvailableSlots.Size = New System.Drawing.Size(408, 183)
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
        Me.ColumnHeader1.Text = "Slot Type"
        Me.ColumnHeader1.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Language Taken"
        Me.ColumnHeader3.Width = 183
        '
        'RemoveLanguage
        '
        Me.RemoveLanguage.BackColor = System.Drawing.Color.White
        Me.RemoveLanguage.Location = New System.Drawing.Point(300, 330)
        Me.RemoveLanguage.Name = "RemoveLanguage"
        Me.RemoveLanguage.Size = New System.Drawing.Size(125, 24)
        Me.RemoveLanguage.TabIndex = 309
        Me.RemoveLanguage.Text = "Remove Language"
        '
        'TakeLanguage
        '
        Me.TakeLanguage.BackColor = System.Drawing.Color.White
        Me.TakeLanguage.Location = New System.Drawing.Point(165, 330)
        Me.TakeLanguage.Name = "TakeLanguage"
        Me.TakeLanguage.Size = New System.Drawing.Size(125, 24)
        Me.TakeLanguage.TabIndex = 312
        Me.TakeLanguage.Text = "Take Language"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 21)
        Me.Label1.TabIndex = 314
        Me.Label1.Text = "Languages available for selected slot and level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 315
        Me.Label2.Text = "Language slots available"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PickLangaugesPanel
        '
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TakeLanguage)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RemoveLanguage)
        Me.Controls.Add(Me.Label3)
        Me.Name = "PickLangaugesPanel"
        Me.Size = New System.Drawing.Size(950, 565)
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'Panel variables
    Private IsInitialised As Boolean
    Private Character As Rules.Character

    Private AllLanguages As Objects.ObjectDataCollection

    Private ExtraLanguages As Integer
    Private RemoveLanguages As Integer
    Private SpeakLanguage As Integer

    Private AutomaticLanguages As Objects.ObjectDataCollection
    Private BonusLanguages As Objects.ObjectDataCollection

    Private LastShownLanguage, PreviousURL As String
    Private AllowLanguage, AllowSlot As Boolean

#End Region

#Region "Structures"

    Public Enum AvailableLanguageStatus
        Available
        AlreadyKnown
    End Enum

    Public Enum LanguageSlotType
        Automatic
        Bonus
        ClassBonus
        Skillpoint
        RaceBonus
    End Enum

    Public Structure AvailableLanguage
        Public LanguageGuid As Objects.ObjectKey
        Public LanguageName As String
        Public HTML As String
        Public Status As AvailableLanguageStatus

        Public Overrides Function ToString() As String
            Return LanguageName
        End Function
    End Structure

    Public Structure LanguageSlot
        Public CharacterLevel As Integer
        Public LanguageGuid As Objects.ObjectKey
        Public LanguageName As String
        Public SlotType As LanguageSlotType

        Public Sub Clear()
            Try
                CharacterLevel = Nothing
                LanguageGuid = Nothing
                LanguageName = Nothing
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Sub LangaugeClear()
            LanguageGuid = Nothing
            LanguageName = Nothing
        End Sub

        Public Overrides Function ToString() As String
            Try
                Return LanguageName
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function
    End Structure

#End Region

#Region "Properties"

    Private ReadOnly Property SelectedSlot() As LanguageSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, LanguageSlot)
                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("No slot selected")
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

#End Region

    'Initialise the panel
    Public Sub Init2(ByVal Character As Rules.Character)
        Dim RaceObject As Objects.ObjectData
        Dim FirstClass As Objects.ObjectData
        Dim LanguageObject As Objects.ObjectData
        Try

            AllLanguages = Objects.GetAllObjectsOfType(Xml.DBTypes.Languages, Objects.LanguageDefinitionType)
            BonusLanguages = New Objects.ObjectDataCollection

            RaceObject = Character.RaceObject
            FirstClass = CType(Character.CharacterClasses(Character.Levels(1).ClassGuid), Rules.CharacterClass).ClassObj

            'Race Bonus Languages
            For Each TempObject As Objects.ObjectData In RaceObject.ChildrenOfType(Objects.BonusLanguageDefinitionType)
                LanguageObject = TempObject.GetFKObject("Language")
                If Not BonusLanguages.Contains(LanguageObject.ObjectGUID) Then
                    BonusLanguages.Add(LanguageObject)
                End If
            Next

            'Class Bonus Languages
            For Each TempObject As Objects.ObjectData In FirstClass.ChildrenOfType(Objects.BonusLanguageDefinitionType)
                LanguageObject = TempObject.GetFKObject("Language")
                If Not BonusLanguages.Contains(LanguageObject.ObjectGUID) Then
                    BonusLanguages.Add(LanguageObject)
                End If
            Next

            IsInitialised = True
            Me.Character = Character
            LoadSlots()

            MoveToNextAvailableSlot(0)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Generate the list of available languages
    Private Function Available_Languages(ByVal Slot As LanguageSlot) As ArrayList
        Dim Languages As Objects.ObjectDataCollection = Nothing
        Dim LanguageList As New ArrayList
        Dim AvailableLanguage As AvailableLanguage

        Select Case Slot.SlotType

            Case LanguageSlotType.Bonus
                Languages = BonusLanguages

            Case LanguageSlotType.ClassBonus, LanguageSlotType.Skillpoint, LanguageSlotType.RaceBonus
                Languages = AllLanguages

        End Select

        If Languages IsNot Nothing Then
            For Each Language As Objects.ObjectData In Languages
                AvailableLanguage.LanguageGuid = Language.ObjectGUID
                AvailableLanguage.LanguageName = Language.Name
                AvailableLanguage.HTML = Language.HTML

                If Character.Languages.Contains(AvailableLanguage.LanguageGuid) Then
                    AvailableLanguage.Status = AvailableLanguageStatus.AlreadyKnown
                Else
                    AvailableLanguage.Status = AvailableLanguageStatus.Available
                End If

                LanguageList.Add(AvailableLanguage)
            Next
        End If
        Return LanguageList

    End Function

    'Generate the list of available language slots
    Private Function AvailableLanguageSlots() As ArrayList
        Dim Slots As New ArrayList
        Dim Slot As New LanguageSlot
        Dim LanguageObject As Objects.ObjectData
        Dim NewLanguage As Rules.Character.Language

        'Add any Automatic Slots for the characters race
        Dim Race As Objects.ObjectData
        Race = Character.RaceObject


        For Each AutoLanguage As Objects.ObjectData In Race.ChildrenOfType(Objects.AutomaticLanguageDefinitionType)
            LanguageObject = AutoLanguage.GetFKObject("Language")

            If Not Character.Languages.Contains(LanguageObject.ObjectGUID) Then
                Slot.Clear()
                Slot.CharacterLevel = 1 'even if we are not at level 1, it should probably be added at this level anyway
                Slot.SlotType = LanguageSlotType.Automatic
                Slot.LanguageName = LanguageObject.Name
                Slot.LanguageGuid = LanguageObject.ObjectGUID
                Slots.Add(Slot)

                NewLanguage.LanguageGuid = Slot.LanguageGuid
                NewLanguage.LanguageName = Slot.LanguageName
                NewLanguage.LevelGained = Slot.CharacterLevel

                Character.Languages.Add(NewLanguage.LanguageGuid, NewLanguage)
            End If
        Next

        'If this is the first level add the INT mod Bonus slots and Race Bonus language components
        If Character.FirstNewLevel = 1 Then

            'Add the INT mod bonus slots
            If Not Character.CharacterType = Rules.Character.CharacterObjectType.Monster Then
                Dim ExtraLanguages As Integer
                ExtraLanguages = Rules.AbilityScores.AbilityScore(Character.Levels(1).INT).Modifier
                If ExtraLanguages > 0 Then
                    For i As Integer = 1 To ExtraLanguages
                        Slot.Clear()
                        Slot.CharacterLevel = 1
                        Slot.SlotType = LanguageSlotType.Bonus
                        Slots.Add(Slot)
                    Next
                End If
            End If

            'add racial bonus language objects
            Dim RaceBonusLanguages As Integer = Race.ChildrenOfType(Objects.ChooseBonusLanguageType).Count
            If RaceBonusLanguages > 0 Then
                For n As Integer = 1 To RaceBonusLanguages
                    Slot.Clear()
                    Slot.CharacterLevel = 1
                    Slot.SlotType = LanguageSlotType.RaceBonus
                    Slots.Add(Slot)
                Next
            End If

        End If

        'Get Class Bonus & Automatic Language slots
        For i As Integer = Character.FirstNewLevel To Character.CharacterLevel
            'Get the class level object
            Dim Level As Rules.Character.Level = Character.Levels(i)
            Dim ClassInfo As Rules.CharacterClass = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)
            Dim ClassLevel As Objects.ObjectData = ClassInfo.ClassLevel(Level.ClassLevel)
            Dim ClassBonusLanguages As Integer
            Dim ClassAutomaticLanguage As Objects.ObjectData

            'If its a first level in a class check for Automatic Languages
            If Level.ClassLevel = 1 Then
                For Each ClassAutomaticLanguage In ClassInfo.ClassObj.ChildrenOfType(Objects.AutomaticLanguageDefinitionType)
                    LanguageObject = ClassAutomaticLanguage.GetFKObject("Language")

                    If Not Character.Languages.Contains(LanguageObject.ObjectGUID) Then
                        Slot.Clear()
                        Slot.CharacterLevel = i
                        Slot.SlotType = LanguageSlotType.Automatic
                        Slot.LanguageName = LanguageObject.Name
                        Slot.LanguageGuid = LanguageObject.ObjectGUID
                        Slots.Add(Slot)

                        NewLanguage.LanguageGuid = Slot.LanguageGuid
                        NewLanguage.LanguageName = Slot.LanguageName
                        NewLanguage.LevelGained = Slot.CharacterLevel

                        Character.Languages.Add(NewLanguage.LanguageGuid, NewLanguage)
                    End If
                Next
            End If

            'Add slots for any bonus language objects
            ClassBonusLanguages = ClassLevel.ChildrenOfType(Objects.ChooseBonusLanguageType).Count
            If ClassBonusLanguages > 0 Then
                For n As Integer = 1 To ClassBonusLanguages
                    Slot.Clear()
                    Slot.CharacterLevel = Level.CharacterLevel
                    Slot.SlotType = LanguageSlotType.ClassBonus
                    Slots.Add(Slot)
                Next
            End If
        Next

        'Get the Speaklanguage SkillRanks object
        If SpeakLanguage > 0 Then
            Dim SpeakSkill As Rules.Character.SkillRank
            Dim CurrentRanks As Double
            Dim AssignmentLevel As Integer
            Dim AssignmentRanks As Double
            Dim Assignments As New SortedList

            SpeakSkill = Character.Skill(References.SpeakLanguage)
            CurrentRanks = Math.Floor(SpeakSkill.Ranks)

            'Sort the assignments by level order
            For Each Assignment As DictionaryEntry In SpeakSkill.AssignedRanks
                AssignmentLevel = CType(Assignment.Key, Integer)
                AssignmentRanks = CType(Assignment.Value, Double)
                Assignments.Add(AssignmentLevel, AssignmentRanks)
            Next

            For Each Assignment As DictionaryEntry In Assignments
                AssignmentLevel = CType(Assignment.Key, Integer)
                AssignmentRanks = CType(Assignment.Value, Double)

                'Check if we have gained a new langauge
                If Math.Floor(CurrentRanks + AssignmentRanks) > Math.Floor(CurrentRanks) Then
                    For i As Integer = 1 To CInt(Math.Floor(CurrentRanks + AssignmentRanks) - Math.Floor(CurrentRanks))
                        Slot.Clear()
                        Slot.CharacterLevel = AssignmentLevel
                        Slot.SlotType = LanguageSlotType.Skillpoint
                        Slots.Add(Slot)
                    Next
                End If
                CurrentRanks += AssignmentRanks
            Next
        End If

        Return Slots

    End Function

    'Load the slots for the currently selected class
    Private Function LoadSlots() As Integer
        Dim Slots As ArrayList
        Dim Slot As LanguageSlot
        Dim SlotCount As Integer

        Try
            'Get the slots for the current class
            Slots = AvailableLanguageSlots()

            'Clear the current slots
            AvailableSlots.BeginUpdate()
            AvailableSlots.Items.Clear()
            SlotCount = 0

            'Add each slot to the listview
            For Each Slot In Slots

                If Slot.SlotType = LanguageSlotType.Bonus OrElse Slot.SlotType = LanguageSlotType.ClassBonus OrElse Slot.SlotType = LanguageSlotType.Skillpoint OrElse Slot.SlotType = LanguageSlotType.RaceBonus Then
                    SlotCount += 1
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
    Private Function LoadSlot(ByVal Slot As LanguageSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            Select Case Slot.SlotType

                Case LanguageSlotType.Automatic
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Automatic")
                    ListViewItem.SubItems.Add(Slot.LanguageName)

                Case LanguageSlotType.Bonus
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("INT Bonus")
                    ListViewItem.SubItems.Add(Slot.LanguageName)

                Case LanguageSlotType.ClassBonus
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Class Bonus")
                    ListViewItem.SubItems.Add(Slot.LanguageName)

                Case LanguageSlotType.Skillpoint
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Speak Language")
                    ListViewItem.SubItems.Add(Slot.LanguageName)

                Case LanguageSlotType.RaceBonus
                    ListViewItem.Text = "Level " & Slot.CharacterLevel
                    ListViewItem.Tag = Slot
                    ListViewItem.SubItems.Add("Race Bonus")
                    ListViewItem.SubItems.Add(Slot.LanguageName)
            End Select

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Gets the list of available languages based on the current class and the selected slot
    Private Sub UpdateLanguageList()
        Dim LanguageList As New ArrayList
        Dim LanguageInfo As AvailableLanguage
        Dim EnableNext As Boolean

        Try
            AvailableLanguages.BeginUpdate()
            AvailableLanguages.Items.Clear()

            LanguageList = Available_Languages(SelectedSlot)

            'add the spells to the list
            EnableNext = True
            For Each LanguageInfo In LanguageList
                AvailableLanguages.Items.Add(LoadLanguage(LanguageInfo))
                If LanguageInfo.Status = AvailableLanguageStatus.Available Then EnableNext = False
            Next

            If EnableNext Then
                RaiseEvent EnableNext(False)
            End If

            'show current language if any
            If LastShownLanguage <> "" Then
                For Each Item As ListViewItem In AvailableLanguages.Items
                    If Item.Text = LastShownLanguage Then
                        Item.Selected = True
                        Item.EnsureVisible()
                        AvailableLanguages.EndUpdate()
                        Exit Sub
                    End If
                Next
            End If

            If AvailableLanguages.Items.Count > 0 Then
                AvailableLanguages.Items(0).Selected = True
            End If
            AvailableLanguages.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Load a language into the listview 
    Private Function LoadLanguage(ByVal LanguageInfo As AvailableLanguage) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = LanguageInfo.LanguageName
            ListViewItem.Tag = LanguageInfo

            If LanguageInfo.Status = AvailableLanguageStatus.AlreadyKnown Then
                ListViewItem.ForeColor = System.Drawing.Color.DarkGoldenrod
            End If

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'panel required
    Public Function PanelRequired(ByVal Character As Rules.Character, ByVal ExistingCharacter As Rules.Character, ByVal LevelRanges As LevellingUpWizard.LevelRangeCollection) As Boolean

        Select Case Character.CharacterType
            Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                Return False
        End Select

        'skill points spent on speak languages
        Dim Ranks, NewRanks, Fractions As Double
        Ranks = Character.Skill(References.SpeakLanguage).Ranks
        NewRanks = Character.Skill(References.SpeakLanguage).NewRanks
        Fractions = Ranks - Math.Floor(Ranks) + NewRanks - Math.Floor(NewRanks)
        SpeakLanguage = CType(Math.Floor(NewRanks) + Math.Floor(Fractions), Integer)

        Dim Autos As Integer = 0
        Dim BonusLanguageCount As Integer = 0

        'automatic languages gained from new classes
        For Each LevelRange As LevellingUpWizard.LevelRange In LevelRanges.LevelRanges
            Dim ClassObj As Objects.ObjectData = LevelRange.ClassTaken
            For Each AutoLangauge As Objects.ObjectData In ClassObj.ChildrenOfType(Objects.AutomaticLanguageDefinitionType)
                If Not ExistingCharacter.Languages.ContainsKey(AutoLangauge.GetFKGuid("Language")) Then
                    Autos += 1
                End If
            Next
        Next

        'race
        If Character.FirstNewLevel = 1 Then
            BonusLanguageCount += Character.RaceObject.ChildrenOfType(Objects.ChooseBonusLanguageType).Count
            Autos += Character.RaceObject.ChildrenOfType(Objects.AutomaticLanguageDefinitionType).Count
        End If

        'add in any bonus languages gained from class levels
        For n As Integer = Character.FirstNewLevel To Character.CharacterLevel
            Dim Level As Rules.Character.Level = Character.Levels(n)
            Dim ClassInfo As Rules.CharacterClass = Character.CharacterClasses(Level.ClassGuid)
            Dim ClassLevel As Objects.ObjectData = ClassInfo.ClassLevel(Level.ClassLevel)
            BonusLanguageCount += ClassLevel.ChildrenOfType(Objects.ChooseBonusLanguageType).Count
        Next

        'is panel required?
        If SpeakLanguage > 0 Or Autos > 0 Or BonusLanguageCount > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'Enable/disable next
    Private Sub EnableDisableNext2()
        For Each Item As ListViewItem In AvailableSlots.Items
            If Item.SubItems(2).Text = "" Then
                RaiseEvent DisableNext()
                Exit Sub
            End If
        Next

        RaiseEvent EnableNext(False)
    End Sub

    'Move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        For Each Item As ListViewItem In AvailableSlots.Items
            If CType(Item.Tag, LanguageSlot).LanguageName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next

        AvailableSlots.Items(PreviousIndex).Selected = True
        AvailableSlots.EnsureVisible(PreviousIndex)
    End Sub

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
        EnableDisableNext2()
    End Sub

#End Region

#Region "Event Handlers"

    'Add a language to the character
    Private Sub TakeLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeLanguage.Click

        Dim Slot As LanguageSlot
        Dim Language As AvailableLanguage
        Dim NewLanguage As Rules.Character.Language
        Dim SlotIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailableLanguages.SelectedItems.Count) <> 2 Then Exit Sub

        'get the spell and the slot
        Language = CType(AvailableLanguages.SelectedItems(0).Tag, AvailableLanguage)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, LanguageSlot)

        If Not Language.Status = AvailableLanguageStatus.Available Then Exit Sub

        If Slot.LanguageName = "" Then

            Select Case Slot.SlotType

                Case LanguageSlotType.Bonus, LanguageSlotType.ClassBonus, LanguageSlotType.Skillpoint, LanguageSlotType.RaceBonus
                    Slot.LanguageName = Language.LanguageName
                    Slot.LanguageGuid = Language.LanguageGuid

                    AvailableSlots.BeginUpdate()
                    SlotIndex = AvailableSlots.SelectedIndices(0)
                    AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                    NewLanguage.LanguageName = Language.LanguageName
                    NewLanguage.LanguageGuid = Language.LanguageGuid
                    NewLanguage.LevelGained = Slot.CharacterLevel

                    Character.Languages.Add(NewLanguage.LanguageGuid, NewLanguage)

                    AvailableSlots.EndUpdate()

                    LastShownLanguage = Language.LanguageName
                    EnableDisableNext2()
                    MoveToNextAvailableSlot(SlotIndex)
            End Select
        End If

    End Sub

    'Remove a language from the character
    Private Sub RemoveLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveLanguage.Click
        Dim Slot As LanguageSlot
        Dim SlotIndex As Integer
        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub

        Slot = SelectedSlot
        SlotIndex = AvailableSlots.SelectedIndices(0)
        If Slot.LanguageGuid.IsEmpty Then Exit Sub

        AvailableSlots.BeginUpdate()

        Select Case Slot.SlotType

            Case LanguageSlotType.Bonus, LanguageSlotType.ClassBonus, LanguageSlotType.Skillpoint, LanguageSlotType.RaceBonus
                Character.Languages.Remove(Slot.LanguageGuid)
                Slot.LangaugeClear()
                AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)

        End Select

        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()
        EnableDisableNext2()

    End Sub

    'Display the correct browser page
    Private Sub AvailableLanguages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableLanguages.SelectedIndexChanged
        Dim LanguageInfo As AvailableLanguage
        Try
            If AvailableLanguages.SelectedItems.Count > 0 Then
                LanguageInfo = CType(AvailableLanguages.SelectedItems(0).Tag, AvailableLanguage)

                Dim URL As String
                If LanguageInfo.HTML.IndexOf(":\") = 1 And IO.File.Exists(LanguageInfo.HTML) Then
                    URL = "file://" & LanguageInfo.HTML
                Else
                    If IO.File.Exists(General.HelpPath & LanguageInfo.HTML) Then
                        URL = "file://" & General.HelpPath & LanguageInfo.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If

                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL

                Select Case LanguageInfo.Status
                    Case AvailableLanguageStatus.AlreadyKnown
                        AllowLanguage = False
                    Case AvailableLanguageStatus.Available
                        AllowLanguage = True
                End Select

                If AllowSlot And AllowLanguage Then
                    TakeLanguage.Enabled = True
                Else
                    TakeLanguage.Enabled = False
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Load the relelvant languages
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot As LanguageSlot

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then

                Slot = SelectedSlot

                Select Case Slot.SlotType

                    Case LanguageSlotType.Automatic
                        AllowSlot = False
                        RemoveLanguage.Enabled = False
                        AvailableLanguages.Items.Clear()

                    Case LanguageSlotType.Bonus, LanguageSlotType.ClassBonus, LanguageSlotType.Skillpoint, LanguageSlotType.RaceBonus
                        UpdateLanguageList()
                        If Slot.LanguageName = "" Then
                            AllowSlot = True
                            RemoveLanguage.Enabled = False
                        Else
                            AllowSlot = False
                            RemoveLanguage.Enabled = True
                        End If

                End Select

                If AllowSlot And AllowLanguage Then
                    TakeLanguage.Enabled = True
                Else
                    TakeLanguage.Enabled = False
                End If

            End If

            If Slot.LanguageGuid.IsNotEmpty Then
                Dim Language As Objects.ObjectData
                Language = AllLanguages.Item(Slot.LanguageGuid)
                Dim URL As String
                If Language.HTML.IndexOf(":\") = 1 And IO.File.Exists(Language.HTML) Then
                    URL = "file://" & Language.HTML
                Else
                    If IO.File.Exists(General.HelpPath & Language.HTML) Then
                        URL = "file://" & General.HelpPath & Language.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL
            End If

            'Clear last shown feat
            LastShownLanguage = ""

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

    Private Sub AvailableLanguages_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableLanguages.DoubleClick
        TakeLanguage_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        RemoveLanguage_Click(Nothing, Nothing)
    End Sub

End Class