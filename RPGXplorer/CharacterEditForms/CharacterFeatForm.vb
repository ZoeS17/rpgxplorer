Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Imports System.Threading

Public Class CharacterFeatForm
    Inherits System.Windows.Forms.Form

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
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents AvailableFeats As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents PutFeatBack As System.Windows.Forms.Button
    Public WithEvents TakeFeat As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents IgnoreCheck As System.Windows.Forms.CheckBox
    Public WithEvents AddSlot As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents RemoveSlot As System.Windows.Forms.Button
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CharacterFeatForm))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableFeats = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.Label2 = New System.Windows.Forms.Label
        Me.PutFeatBack = New System.Windows.Forms.Button
        Me.TakeFeat = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.IgnoreCheck = New System.Windows.Forms.CheckBox
        Me.AddSlot = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.RemoveSlot = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 395)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 185)
        Me.Panel3.TabIndex = 137
        '
        'AvailableSlots
        '
        Me.AvailableSlots.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableSlots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
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
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Level"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Feat Taken"
        Me.ColumnHeader3.Width = 319
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Feat Type"
        Me.ColumnHeader5.Width = 130
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableFeats)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 255)
        Me.Panel2.TabIndex = 136
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
        Me.AvailableFeats.Size = New System.Drawing.Size(408, 253)
        Me.AvailableFeats.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableFeats.TabIndex = 122
        Me.AvailableFeats.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Feat"
        Me.ColumnHeader4.Width = 258
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(440, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 565)
        Me.Panel1.TabIndex = 135
        '
        'Browser
        '        
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.Browser.Enabled = True
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Size = New System.Drawing.Size(493, 563)
        Me.Browser.TabIndex = 110
        Me.Browser.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Feat slots available"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PutFeatBack
        '
        Me.PutFeatBack.Enabled = False
        Me.PutFeatBack.Location = New System.Drawing.Point(335, 330)
        Me.PutFeatBack.Name = "PutFeatBack"
        Me.PutFeatBack.Size = New System.Drawing.Size(90, 24)
        Me.PutFeatBack.TabIndex = 133
        Me.PutFeatBack.Text = "Put Feat Back"
        '
        'TakeFeat
        '
        Me.TakeFeat.Enabled = False
        Me.TakeFeat.Location = New System.Drawing.Point(240, 330)
        Me.TakeFeat.Name = "TakeFeat"
        Me.TakeFeat.Size = New System.Drawing.Size(90, 24)
        Me.TakeFeat.TabIndex = 132
        Me.TakeFeat.Text = "Take Feat"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 21)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Feats available for selected slot and level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(145, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please select your feats"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IgnoreCheck
        '
        Me.IgnoreCheck.Location = New System.Drawing.Point(300, 40)
        Me.IgnoreCheck.Name = "IgnoreCheck"
        Me.IgnoreCheck.Size = New System.Drawing.Size(125, 24)
        Me.IgnoreCheck.TabIndex = 140
        Me.IgnoreCheck.Text = "Ignore Prerequisites"
        '
        'AddSlot
        '
        Me.AddSlot.Location = New System.Drawing.Point(15, 330)
        Me.AddSlot.Name = "AddSlot"
        Me.AddSlot.Size = New System.Drawing.Size(90, 24)
        Me.AddSlot.TabIndex = 141
        Me.AddSlot.Text = "Add Slot"
        '
        'OK
        '
        Me.OK.Enabled = False
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(785, 610)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 142
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(865, 610)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 143
        Me.Cancel.Text = "Cancel"
        '
        'RemoveSlot
        '
        Me.RemoveSlot.Location = New System.Drawing.Point(110, 330)
        Me.RemoveSlot.Name = "RemoveSlot"
        Me.RemoveSlot.Size = New System.Drawing.Size(90, 24)
        Me.RemoveSlot.TabIndex = 144
        Me.RemoveSlot.Text = "Remove Slot"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 595)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(920, 5)
        Me.IndentedLine2.TabIndex = 273
        Me.IndentedLine2.TabStop = False
        '
        'CharacterFeatForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.RemoveSlot)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.AddSlot)
        Me.Controls.Add(Me.IgnoreCheck)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PutFeatBack)
        Me.Controls.Add(Me.TakeFeat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterFeatForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CharacterFeatForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Character As Rules.Character
    Private mMode As FormMode

    Private SlotAllow As Boolean
    Private AllowTakeFeat As Boolean

    Private PreviousURL As String
    Private LastShownFeat As String

    Private NewFeats As New ArrayList

    'for Edit Mode
    Private ReplaceFeat As Objects.ObjectData
    Private ReplaceSlot As Rules.AvailableFeats.FeatSlot

    'for Edit Mode with combat styles
    Private CombatStyleObject, CombatStyleChoiceObject, CombatStyleClassObject As Objects.ObjectData
    Private AutomaticImprovedFeat, AutomaticMasteryFeat As Objects.ObjectData
    Private AutomaticImprovedSlot, AutomaticMasteryslot As Rules.AvailableFeats.FeatSlot
    Private CombatStyleChoice As Rules.Character.CharacterChoice

    Private loading As Boolean

    'NaturalAttackLookup
    Private NaturalAttacks As Hashtable

    Private SelectedSlot As Rules.AvailableFeats.FeatSlot

    'init
    Public Sub Init()
        loading = True
        If General.Config.Element("IgnoreFeatPrereqCheck") = "True" Then IgnoreCheck.Checked = True
        loading = False
    End Sub

    'Init for adding extra feats to the character
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Dim LevelSelector As New NumericSelector
        Dim NewFeatSlot As New Rules.AvailableFeats.FeatSlot
        Try
            'init form vars
            mMode = FormMode.Add

            'init form
            Me.Text = "Add Feats"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            'get the character
            Character = CharacterManager.CurrentCharacter.Clone()
            Init()

            LevelSelector.Init("Character Level", "Select level gained", 1, Character.CharacterLevel, Character.CharacterLevel)
            If LevelSelector.ShowDialog = DialogResult.OK Then
                NewFeatSlot.CharacterLevel = LevelSelector.Value
                NewFeatSlot.SlotType = Rules.AvailableFeats.FeatSlotType.UserAdded
                AvailableSlots.Items.Add(LoadSlot(NewFeatSlot))

                AvailableSlots.Items(0).Selected = True
                EnableDisableNext()

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'init for editng a character feat
    Public Sub InitEdit(ByVal ExistingFeat As Objects.ObjectData)

        'init form vars
        mMode = FormMode.Edit
        ReplaceFeat = ExistingFeat

        'init form
        Me.Text = "Add or Edit Feats"
        Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")

        'get the character - get the character from the panel (in case locked window)
        Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey).Clone()
        Init()

        'Add the edit slot into the list view
        If ExistingFeat.Element("SourceType") = Rules.AvailableFeats.ChoosePathFeat Then
            ReplaceSlot.SlotType = Rules.AvailableFeats.FeatSlotType.ChoosePathFeat
        Else
            ReplaceSlot.SlotType = Rules.AvailableFeats.FeatSlotType.ExistingEdit
        End If

        ReplaceSlot.CharacterLevel = ExistingFeat.ElementAsInteger("CharacterLevel")
        ReplaceSlot.FeatGuid = ExistingFeat.GetFKGuid("Feat")
        ReplaceSlot.FeatName = ExistingFeat.Element("Feat")
        ReplaceSlot.FocusGuid = ExistingFeat.GetFKGuid("Focus")
        ReplaceSlot.FocusName = ExistingFeat.Element("Focus")
        ReplaceSlot.FeatType = ExistingFeat.Element("FeatType")
        AvailableSlots.Items.Add(LoadSlot(ReplaceSlot))

        'If it is a Combat Style Starter, add in the automatic slots if present
        If ReplaceSlot.SlotType = Rules.AvailableFeats.FeatSlotType.ChoosePathFeat Then

            'Get the Existing Objects
            Dim ClassObject As Objects.ObjectData
            CombatStyleObject = ExistingFeat.GetFKObject("Source")

            If CombatStyleObject.Type = Objects.CombatStyleType Then
                ClassObject = CombatStyleObject.Parent.Parent.Parent

                'Get the Choice Object
                For Each ChoiceObject As Objects.ObjectData In Character.CharacterObject.FirstChildOfType(Objects.CharacterChoiceFolderType).Children
                    If ChoiceObject.Type = Objects.CombatStyleChoiceType Then
                        If ChoiceObject.GetFKGuid("Class").Equals(ClassObject.ObjectGUID) Then
                            CombatStyleChoiceObject = ChoiceObject
                            Exit For
                        End If
                    End If
                Next
            End If

            'Load the continuation slots
            For Each FeatTaken As Objects.ObjectData In Character.CharacterObject.FirstChildOfType(Objects.FeatFolderType).Children
                If FeatTaken.GetFKGuid("Source").Equals(CombatStyleObject.ObjectGUID) And (Not FeatTaken.GetFKGuid("Feat").Equals(ReplaceSlot.FeatGuid)) Then
                    If AutomaticImprovedFeat.IsEmpty Then
                        AutomaticImprovedFeat = FeatTaken
                    Else
                        If FeatTaken.ElementAsInteger("CharacterLevel") > AutomaticImprovedFeat.ElementAsInteger("CharacterLevel") Then
                            AutomaticMasteryFeat = FeatTaken
                        Else
                            AutomaticMasteryFeat = AutomaticImprovedFeat
                            AutomaticImprovedFeat = FeatTaken
                        End If
                    End If
                End If
                If (Not AutomaticImprovedFeat.IsEmpty) And (Not AutomaticMasteryFeat.IsEmpty) Then Exit For
            Next

            'Add the improved slot to the list view if required
            If (Not AutomaticImprovedFeat.IsEmpty) Then
                AutomaticImprovedSlot.SlotType = Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat
                AutomaticImprovedSlot.CharacterLevel = AutomaticImprovedFeat.ElementAsInteger("CharacterLevel")
                AutomaticImprovedSlot.FeatGuid = AutomaticImprovedFeat.GetFKGuid("Feat")
                AutomaticImprovedSlot.FeatName = AutomaticImprovedFeat.Element("Feat")
                AutomaticImprovedSlot.FocusGuid = AutomaticImprovedFeat.GetFKGuid("Focus")
                AutomaticImprovedSlot.FocusName = AutomaticImprovedFeat.Element("Focus")
                AutomaticImprovedSlot.FeatType = AutomaticImprovedFeat.Element("FeatType")
                AvailableSlots.Items.Add(LoadSlot(AutomaticImprovedSlot))
            End If

            'Add the mastery slot to the list view if required
            If (Not AutomaticMasteryFeat.IsEmpty) Then
                AutomaticMasteryslot.SlotType = Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat
                AutomaticMasteryslot.CharacterLevel = AutomaticMasteryFeat.ElementAsInteger("CharacterLevel")
                AutomaticMasteryslot.FeatGuid = AutomaticMasteryFeat.GetFKGuid("Feat")
                AutomaticMasteryslot.FeatName = AutomaticMasteryFeat.Element("Feat")
                AutomaticMasteryslot.FocusGuid = AutomaticMasteryFeat.GetFKGuid("Focus")
                AutomaticMasteryslot.FocusName = AutomaticMasteryFeat.Element("Focus")
                AutomaticMasteryslot.FeatType = AutomaticMasteryFeat.Element("FeatType")
                AvailableSlots.Items.Add(LoadSlot(AutomaticMasteryslot))
            End If

        End If

        AvailableSlots.Items(0).Selected = True
        EnableDisableNext()
    End Sub

    Private UpdateFeatsThread As Thread

    'thread work method
    Private Sub ThreadUpdateFeats()
        AddHandler Character.AvailableFeats.FeatReady, AddressOf UpdateFeatThread_FeatsReady
        Character.AvailableFeats.AvailableFeatListForThread(SelectedSlot.CharacterLevel, SelectedSlot, IgnoreCheck.Checked)
    End Sub

    'thread event handler to process a feat when the prereqs have been checked.
    Private Sub UpdateFeatThread_FeatsReady(ByVal Feats As ArrayList)
        Dim Items As New List(Of ListViewItem)
        For Each Feat As Rules.AvailableFeats.AvailableFeat In Feats
            Items.Add(LoadFeat(Feat))
        Next
        Try
            If Me.InvokeRequired Then Me.Invoke(AddFeats, New Object() {Items})
        Catch ex As Exception
            'ignore
        End Try
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

            FeatList = Character.AvailableFeats.AvailableFeatList(SelectedSlot.CharacterLevel, SelectedSlot, IgnoreCheck.Checked)

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

    ''update the AvailableFeats
    'Private Sub UpdateFeatList()
    '    Dim FeatList As New ArrayList
    '    Dim FeatInfo As Rules.AvailableFeats.AvailableFeat
    '    Dim ListViewItem As ListViewItem

    '    Try
    '        AvailableFeats.BeginUpdate()
    '        AvailableFeats.Items.Clear()

    '        FeatList = Character.AvailableFeats.AvailableFeatList(SelectedSlot.CharacterLevel, SelectedSlot, IgnoreCheck.Checked)

    '        'add the feats to the list
    '        For Each FeatInfo In FeatList
    '            AvailableFeats.Items.Add(LoadFeat(FeatInfo))
    '        Next

    '        'show current feat if any
    '        If LastShownFeat <> "" Then
    '            For Each Item As ListViewItem In AvailableFeats.Items
    '                If Item.Text = LastShownFeat Then
    '                    Item.Selected = True
    '                    Item.EnsureVisible()
    '                    AvailableFeats.EndUpdate()
    '                    Exit Sub
    '                End If
    '            Next
    '        End If

    '        If AvailableFeats.Items.Count > 0 Then
    '            AvailableFeats.Items(0).Selected = True
    '        End If
    '        AvailableFeats.EndUpdate()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

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
                    ListViewItem.ForeColor = System.Drawing.Color.DarkGoldenrod
                Case Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesMet, Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesMetSelectFocus
                    If FeatInfo.FighterBonus Then
                        ListViewItem.ForeColor = System.Drawing.Color.DarkBlue
                    Else
                        ListViewItem.ForeColor = System.Drawing.Color.Black
                    End If
                Case Rules.AvailableFeats.AvailableFeatStatus.PrerequisitesNotMet
                    ListViewItem.ForeColor = System.Drawing.Color.Silver
            End Select

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'create a listview item for a feat slot
    Private Function LoadSlot(ByVal Slot As Rules.AvailableFeats.FeatSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        ListViewItem.Text = "Level " & Slot.CharacterLevel.ToString
        ListViewItem.Tag = Slot

        If Slot.FocusName = "" Then
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, Slot.FeatName))
        Else
            ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, Slot.FeatName & " (" & Slot.FocusName & ")"))
        End If

        Return ListViewItem
    End Function

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
            If Item.SubItems(1).Text = "" Then
                OK.Enabled = False
                Exit Sub
            End If
        Next

        OK.Enabled = True
    End Sub

#Region "Event Handlers"

    'handles the add slot button
    Private Sub AddSlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSlot.Click
        Dim LevelSelector As New NumericSelector
        Dim NewFeatSlot As New Rules.AvailableFeats.FeatSlot

        LevelSelector.Init("Character Level", "Select Level", 1, Character.CharacterLevel, Character.CharacterLevel)

        If LevelSelector.ShowDialog = DialogResult.OK Then
            NewFeatSlot.CharacterLevel = LevelSelector.Value
            NewFeatSlot.SlotType = Rules.AvailableFeats.FeatSlotType.UserAdded
            AvailableSlots.Items.Add(LoadSlot(NewFeatSlot))
        Else
            Exit Sub
        End If

        EnableDisableNext()

    End Sub

    'update the list of available feats
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Try
            StopUpdateFeatWorker()

            If AvailableSlots.SelectedItems.Count = 1 Then
                SelectedSlot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableFeats.FeatSlot)

                Select Case SelectedSlot.SlotType

                    Case Rules.AvailableFeats.FeatSlotType.ChoosePathFeat, Rules.AvailableFeats.FeatSlotType.UserAdded, Rules.AvailableFeats.FeatSlotType.ExistingEdit
                        UpdateFeatList()
                        If SelectedSlot.FeatName = "" Then
                            SlotAllow = True
                            PutFeatBack.Enabled = False
                        Else
                            SlotAllow = False
                            PutFeatBack.Enabled = True
                        End If

                    Case Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat
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
                Dim Feat As Objects.ObjectData = Caches.Feats.Item(SelectedSlot.FeatGuid)
                Dim URL As String
                'If IO.File.Exists(Feat.HTML) Then
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

    'ignore feat prerequisites
    Private Sub IgnoreCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreCheck.CheckedChanged
        If loading Then Exit Sub
        If IgnoreCheck.Checked Then General.Config.Element("IgnoreFeatPrereqCheck") = "True" Else General.Config.Element("IgnoreFeatPrereqCheck") = ""
        If AvailableSlots.SelectedItems.Count = 1 Then
            UpdateFeatList()
        End If
    End Sub

    'show help for the selected feat
    Private Sub AvailableFeats_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableFeats.SelectedIndexChanged
        Dim FeatInfo As Rules.AvailableFeats.AvailableFeat

        Try
            If AvailableFeats.SelectedItems.Count > 0 Then
                FeatInfo = CType(AvailableFeats.SelectedItems(0).Tag, Rules.AvailableFeats.AvailableFeat)

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

    'handles the take feat button
    Private Sub TakeFeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeFeat.Click
        Dim Slot, TempSlot As Rules.AvailableFeats.FeatSlot
        Dim Feat As Rules.AvailableFeats.AvailableFeat
        Dim NewFeat As New Rules.Character.Feat
        Dim SlotIndex As Integer
        Dim MaxIndex As Integer = AvailableSlots.Items.Count - 1

        Try
            If (AvailableSlots.SelectedItems.Count + AvailableFeats.SelectedItems.Count) <> 2 Then Exit Sub

            'get the feat and the slot
            Feat = CType(AvailableFeats.SelectedItems(0).Tag, Rules.AvailableFeats.AvailableFeat)
            Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.AvailableFeats.FeatSlot)

            If Slot.FeatGuid.IsEmpty Then

                Select Case Slot.SlotType

                    Case Rules.AvailableFeats.FeatSlotType.UserAdded, Rules.AvailableFeats.FeatSlotType.ExistingEdit
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
                            Dim Item As DataListItem = Nothing
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
                                        Items = Rules.Index.DataList(XML.DBTypes.Domains, Objects.DomainDefinitionType)
                                    Case "Discipline Specialization"
                                        Items = Rules.Index.DataList(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType)
                                    Case "Power Discipline"
                                        Items = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.PsionicDisciplineType)
                                    Case "Spell School"
                                        Items = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.SpellSchoolType)
                                    Case "Spell"
                                        Items = Rules.Index.DataList(XML.DBTypes.Spells, Objects.SpellDefinitionType)
                                    Case "Power"
                                        Items = Rules.Index.DataList(XML.DBTypes.Powers, Objects.PowerDefinitionType)
                                    Case "Skill"
                                        Dim Exclusions As New ArrayList
                                        Exclusions.Add(References.SpeakLanguage)
                                        Items = Rules.Index.DataListExclude(XML.DBTypes.Skills, Objects.SkillDefinitionType, Exclusions)
                                    Case "Any Weapon"
                                        Dim Weapons As Objects.ObjectDataCollection

                                        Weapons = Objects.GetObjectsByXPath(XML.DBTypes.Weapons, XPathQueries.AllWeapons)
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

                                        'add the natural attack types
                                        For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
                                            Dim NA As New Objects.ObjectData
                                            NA.ObjectGUID = General.ConvertToObjectKey(NaturalAttack, XML.DBTypes.NaturalWeapons)
                                            NA.Name = NaturalAttack
                                            weapons.Add(NA)
                                        Next

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Natural Weapon"

                                        'add the natural attack types
                                        Dim Weapons As New Objects.ObjectDataCollection
                                        For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
                                            Dim NA As New Objects.ObjectData
                                            NA.ObjectGUID = General.ConvertToObjectKey(NaturalAttack, 38)
                                            NA.Name = NaturalAttack
                                            weapons.Add(NA)
                                        Next

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Simple Weapon"
                                        Items = Rules.Index.DataListXPath(XML.DBTypes.Weapons, XPathQueries.SimpleWeapons)
                                    Case "Martial Weapon"
                                        Dim Weapons As Objects.ObjectDataCollection

                                        Weapons = Objects.GetObjectsByXPath(XML.DBTypes.Weapons, XPathQueries.MartialWeapons)
                                        'add in any racial weapons
                                        For Each RacialWeapon As Objects.ObjectData In Character.RaceObject.ChildrenOfType(Objects.RacialWeaponType)
                                            Weapons.Add(RacialWeapon.GetFKObject("Weapon"))
                                        Next

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Exotic Weapon"
                                        Dim Weapons As Objects.ObjectDataCollection

                                        Weapons = Objects.GetObjectsByXPath(XML.DBTypes.Weapons, XPathQueries.ExoticWeapons)
                                        'remove any racial weapons
                                        For Each RacialWeapon As Objects.ObjectData In Character.RaceObject.ChildrenOfType(Objects.RacialWeaponType)
                                            Weapons.Remove(RacialWeapon.GetFKGuid("Weapon"))
                                        Next

                                        Items = Rules.Index.DataList(Weapons)

                                    Case "Ranged Weapon"
                                        Items = Rules.Index.DataListXPath(XML.DBTypes.Weapons, XPathQueries.RangedWeapons)
                                    Case "Melee Weapon"
                                        Items = Rules.Index.DataListXPath(XML.DBTypes.Weapons, XPathQueries.MeleeWeapons)
                                    Case "Crossbow"
                                        Items = Rules.Index.DataListXPath(XML.DBTypes.Weapons, XPathQueries.Crossbows)
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

                                        If Key.Database = XML.DBTypes.NaturalWeapons Then
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

                            Case Rules.AvailableFeats.FeatSlotType.UserAdded
                                NewFeat.SourceName = "User"
                                NewFeat.SourceGuid = Objects.ObjectKey.Empty
                                NewFeat.FeatSlotSource = RPGXplorer.Rules.AvailableFeats.UserAdded

                            Case Rules.AvailableFeats.FeatSlotType.ExistingEdit
                                NewFeat.SourceName = ReplaceFeat.Element("Source")
                                NewFeat.SourceGuid = ReplaceFeat.GetFKGuid("Source")

                                Dim ReplaceSourceType As String = ReplaceFeat.Element("SourceType")
                                If ReplaceSourceType.EndsWith("(Edited)") OrElse ReplaceSourceType = RPGXplorer.Rules.AvailableFeats.UserAdded Then
                                    NewFeat.FeatSlotSource = ReplaceSourceType
                                Else
                                    NewFeat.FeatSlotSource = ReplaceSourceType & " (Edited)"
                                End If

                                ReplaceSlot = Slot
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

                            'Add feat to valid lookuptable
                            Character.Components.Feats(Feat.FeatGuid.ToString & FocusGuid.ToString) = Character.Components.AnalyseComponent(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat.LevelTaken)
                            Character.Calculate(False)
                        End If

                        'add it to NewFeats collection if required
                        If Not (Slot.SlotType = Rules.AvailableFeats.FeatSlotType.ExistingEdit AndAlso NewFeat.FeatGuid.Equals(ReplaceFeat.GetFKGuid("Feat")) AndAlso NewFeat.FocusGuid.Equals(ReplaceFeat.GetFKGuid("Focus"))) Then
                            NewFeats.Add(NewFeat)
                        End If

                        AvailableSlots.EndUpdate()

                    Case Rules.AvailableFeats.FeatSlotType.ChoosePathFeat

                        'update the slot
                        Slot.FeatGuid = Feat.FeatGuid
                        Slot.FeatName = Feat.FeatName
                        Slot.FeatType = Feat.FeatType

                        AvailableSlots.BeginUpdate()
                        SlotIndex = AvailableSlots.SelectedIndices(0)
                        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

                        'Save the current Slot
                        ReplaceSlot = Slot

                        'Save the Combat Style choice object
                        Dim StyleChoice As New Rules.Character.CharacterChoice
                        StyleChoice.Type = Rules.Character.ChoiceType.CombatStyle
                        StyleChoice.ClassName = CombatStyleClassObject.Name
                        StyleChoice.ClassGuid = CombatStyleClassObject.ObjectGUID
                        StyleChoice.LevelAcquired = Slot.CharacterLevel
                        StyleChoice.DataGuid = CombatStyleObject.ObjectGUID

                        If Slot.FeatGuid.Equals(CombatStyleObject.GetFKGuid("FirstFeat1")) Then
                            StyleChoice.Data = "Style1"
                        ElseIf Slot.FeatGuid.Equals(CombatStyleObject.GetFKGuid("FirstFeat2")) Then
                            StyleChoice.Data = "Style2"
                        Else
                            MessageBox.Show("Could not match feat to combat style")
                        End If

                        Character.Choices.AddItemWithSubkey(StyleChoice.ClassGuid, StyleChoice.DataGuid, StyleChoice, Slot.CharacterLevel)
                        CombatStyleChoice = StyleChoice

                        'Save the new feat
                        NewFeat.Clear()
                        NewFeat.FeatGuid = Slot.FeatGuid
                        NewFeat.FeatName = Slot.FeatName
                        NewFeat.FeatType = Slot.FeatType
                        NewFeat.LevelTaken = Slot.CharacterLevel
                        NewFeat.FocusGuid = Slot.FocusGuid
                        NewFeat.FocusName = Slot.FocusName
                        NewFeat.IgnorePrerequisites = True
                        NewFeat.FeatSlotSource = Rules.AvailableFeats.ChoosePathFeat
                        NewFeat.SourceName = StyleChoice.Data
                        NewFeat.SourceGuid = CombatStyleObject.ObjectGUID
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

                        'add it to NewFeats collection if required
                        If Not (NewFeat.FeatGuid.Equals(ReplaceFeat.GetFKGuid("Feat")) AndAlso NewFeat.FocusGuid.Equals(ReplaceFeat.GetFKGuid("Focus"))) Then
                            NewFeats.Add(NewFeat)
                        End If

                        'Update any continuation feats
                        Dim Updated As Boolean = False
                        If MaxIndex > SlotIndex Then

                            Dim Reselect As Boolean
                            For i As Integer = SlotIndex + 1 To MaxIndex
                                Reselect = False
                                TempSlot = CType(AvailableSlots.Items(i).Tag, Rules.AvailableFeats.FeatSlot)

                                'If its a continuation feat slot, make sure its from the same class
                                If TempSlot.SlotType = Rules.AvailableFeats.FeatSlotType.PathAutomaticFeat Then

                                    'Remove any old feat
                                    If TempSlot.FeatGuid.IsNotEmpty Then
                                        If TempSlot.FocusGuid.IsEmpty Then
                                            Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.CharacterLevel)
                                        Else
                                            Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.FocusGuid)
                                        End If

                                        'Remove form NewFeats
                                        For Each TempFeat As Rules.Character.Feat In NewFeats
                                            If TempFeat.FeatGuid.Equals(TempSlot.FeatGuid) And TempFeat.FocusGuid.Equals(TempSlot.FocusGuid) Then
                                                NewFeats.Remove(TempFeat)
                                                Exit For
                                            End If
                                        Next

                                        'Clear the old feat from the slot
                                        TempSlot.FeatClear()
                                    End If

                                    'Add the new feat
                                    Select Case TempSlot.CharacterLevel

                                        Case AutomaticImprovedSlot.CharacterLevel

                                            Select Case StyleChoice.Data
                                                Case "Style1"
                                                    TempSlot.FeatGuid = CombatStyleObject.GetFKGuid("SecondFeat1")
                                                    TempSlot.FeatName = CombatStyleObject.Element("SecondFeat1")
                                                    TempSlot.FeatType = CombatStyleObject.GetFKObject("SecondFeat1").Element("FeatType")
                                                    AutomaticImprovedSlot = TempSlot

                                                Case "Style2"
                                                    TempSlot.FeatGuid = CombatStyleObject.GetFKGuid("SecondFeat2")
                                                    TempSlot.FeatName = CombatStyleObject.Element("SecondFeat2")
                                                    TempSlot.FeatType = CombatStyleObject.GetFKObject("SecondFeat2").Element("FeatType")
                                                    AutomaticImprovedSlot = TempSlot
                                            End Select

                                            If TempSlot.FeatGuid.Equals(AutomaticImprovedFeat.GetFKGuid("Feat")) AndAlso TempSlot.FocusGuid.Equals(AutomaticImprovedFeat.GetFKGuid("Focus")) Then
                                                Reselect = True
                                            End If

                                        Case AutomaticMasteryslot.CharacterLevel

                                            Select Case StyleChoice.Data
                                                Case "Style1"
                                                    TempSlot.FeatGuid = CombatStyleObject.GetFKGuid("ThirdFeat1")
                                                    TempSlot.FeatName = CombatStyleObject.Element("ThirdFeat1")
                                                    TempSlot.FeatType = CombatStyleObject.GetFKObject("ThirdFeat1").Element("FeatType")
                                                    AutomaticMasteryslot = TempSlot

                                                Case "Style2"
                                                    TempSlot.FeatGuid = CombatStyleObject.GetFKGuid("ThirdFeat2")
                                                    TempSlot.FeatName = CombatStyleObject.Element("ThirdFeat2")
                                                    TempSlot.FeatType = CombatStyleObject.GetFKObject("ThirdFeat2").Element("FeatType")
                                                    AutomaticMasteryslot = TempSlot
                                            End Select

                                            If TempSlot.FeatGuid.Equals(AutomaticMasteryFeat.GetFKGuid("Feat")) AndAlso TempSlot.FocusGuid.Equals(AutomaticMasteryFeat.GetFKGuid("Focus")) Then
                                                Reselect = True
                                            End If

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
                                        NewFeat.FeatSlotSource = Rules.AvailableFeats.PathAutomaticFeat
                                        NewFeat.SourceName = StyleChoice.Data
                                        NewFeat.SourceGuid = CombatStyleObject.ObjectGUID

                                        If NewFeat.FocusGuid.IsEmpty Then
                                            NewFeat.FocusName = ""
                                            Character.Feats.AddItem(NewFeat.FeatGuid, NewFeat, NewFeat.LevelTaken)
                                        Else
                                            NewFeat.FocusName = Slot.FocusName
                                            Character.Feats.AddItemWithSubkey(NewFeat.FeatGuid, NewFeat.FocusGuid, NewFeat, NewFeat.LevelTaken)
                                        End If

                                        'add to new feats if required
                                        If Not Reselect Then NewFeats.Add(NewFeat)

                                    End If

                                End If

                            Next

                            'Reload & Refresh components and update the character
                            Character.Calculate(True)
                            Updated = True

                        End If

                        'Refresh components if we haven already
                        If Not Updated Then Character.Calculate(False)

                        'update the available feat list if required                    
                        AvailableSlots.EndUpdate()

                End Select

            End If
            MoveToNextAvailableSlot(SlotIndex)
            EnableDisableNext()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the ok button
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Feat As Rules.Character.Feat
        Dim FeatObject As Objects.ObjectData

        General.MainExplorer.Undo.UndoRecord()

        'if the existing feat has been changed, then delete the object from the character
        If mMode = FormMode.Edit Then
            If Not (ReplaceSlot.FeatGuid.Equals(ReplaceFeat.GetFKGuid("Feat")) And ReplaceSlot.FocusGuid.Equals(ReplaceFeat.GetFKGuid("Focus"))) Then

                Select Case ReplaceSlot.SlotType
                    Case Rules.AvailableFeats.FeatSlotType.ExistingEdit
                        ReplaceFeat.Delete()

                    Case Rules.AvailableFeats.FeatSlotType.ChoosePathFeat
                        'delete the starter feat
                        ReplaceFeat.Delete()

                        'delete the any old path automatics
                        If Not AutomaticImprovedSlot.FeatGuid.Equals(AutomaticImprovedFeat.ObjectGUID) Then
                            AutomaticImprovedFeat.Delete()
                        End If

                        If Not AutomaticMasteryslot.FeatGuid.Equals(AutomaticMasteryFeat.ObjectGUID) Then
                            AutomaticMasteryFeat.Delete()
                        End If

                        'update the character choice object
                        If CombatStyleChoice.DataGuid.IsNotEmpty Then
                            CombatStyleChoiceObject.Delete()
                            CombatStyleChoice.CreateObject(Character).Save()
                        End If

                End Select
            End If
        End If

        'Write feats to db
        For Each Feat In NewFeats
            FeatObject = Feat.CreateObject(Character)

            'set fixed for user added feats
            If FeatObject.Element("SourceType") = Rules.AvailableFeats.UserAdded Then
                FeatObject.Fixed = False
            End If

            FeatObject.Save()
        Next

        'Update the cached character
        CharacterManager.UpdateCharacter(Character)

        General.MainExplorer.RefreshPanel()
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    'handles the put feat back button
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

                'Remove form NewFeats
                For Each TempFeat As Rules.Character.Feat In NewFeats
                    If TempFeat.FeatGuid.Equals(Slot.FeatGuid) And TempFeat.FocusGuid.Equals(Slot.FocusGuid) And (tempfeat.LevelTaken = Slot.CharacterLevel) Then
                        NewFeats.Remove(TempFeat)
                        Exit For
                    End If
                Next

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

                                    'Remove form NewFeats
                                    For Each TempFeat As Rules.Character.Feat In NewFeats
                                        If TempFeat.FeatGuid.Equals(TempSlot.FeatGuid) And TempFeat.FocusGuid.Equals(TempSlot.FocusGuid) And (tempfeat.LevelTaken = TempSlot.CharacterLevel) Then
                                            NewFeats.Remove(TempFeat)
                                            Exit For
                                        End If
                                    Next

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
                        CombatStyleChoice = Nothing
                        Exit For
                    End If
                Next

                'Update the character
                Character.Calculate()

            Case Else
                'Remove Feat from character
                If Slot.FocusGuid.IsEmpty Then
                    Character.Feats.RemoveItem(Slot.FeatGuid, Slot.CharacterLevel)
                Else
                    Character.Feats.RemoveItem(Slot.FeatGuid, Slot.FocusGuid)
                End If

                'Remove form NewFeats
                For Each TempFeat As Rules.Character.Feat In NewFeats
                    If TempFeat.FeatGuid.Equals(Slot.FeatGuid) And TempFeat.FocusGuid.Equals(Slot.FocusGuid) Then
                        NewFeats.Remove(TempFeat)
                        Exit For
                    End If
                Next

                'Clear the slot
                Slot.FeatClear()
                AvailableSlots.Items(SlotIndex) = LoadSlot(Slot)

                'Update the character
                Character.Calculate()

        End Select

        'Remove broken feats
        If Not IgnoreCheck.Checked Then
            Dim PrerequisitesMet As Boolean
            Dim SomethingRemoved As Boolean = True

            While SomethingRemoved
                SomethingRemoved = False

                For i As Integer = 0 To MaxIndex
                    TempSlot = CType(AvailableSlots.Items(i).Tag, Rules.AvailableFeats.FeatSlot)
                    PrerequisitesMet = True

                    For Each Prerequisite As Objects.ObjectData In Caches.FeatPrerequisites.ChildrenFast(TempSlot.FeatGuid)
                        If Not Character.Prerequisites.HasPrerequisite(Prerequisite, TempSlot.CharacterLevel, Caches.FeatPrerequisiteChildren.ChildrenFast(Prerequisite.ObjectGUID)) Then
                            PrerequisitesMet = False
                            Exit For
                        End If
                    Next

                    If PrerequisitesMet = False Then

                        'Remove feat from character
                        If TempSlot.FocusGuid.IsEmpty Then
                            Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.CharacterLevel)
                        Else
                            Character.Feats.RemoveItem(TempSlot.FeatGuid, TempSlot.FocusGuid)
                        End If

                        'Remove form NewFeats
                        For Each TempFeat As Rules.Character.Feat In NewFeats
                            If TempFeat.FeatGuid.Equals(TempSlot.FeatGuid) And TempFeat.FocusGuid.Equals(TempSlot.FocusGuid) Then
                                NewFeats.Remove(TempFeat)
                                Exit For
                            End If
                        Next

                        'Clear the slot
                        TempSlot.FeatClear()
                        AvailableSlots.Items(i) = LoadSlot(TempSlot)

                        'Update the character
                        Character.Calculate()

                        SomethingRemoved = True
                    End If

                Next

            End While
        End If

        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()

        MoveToNextAvailableSlot(SlotIndex)
        EnableDisableNext()

    End Sub

    'handles the remove slot button
    Private Sub RemoveSlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSlot.Click
        Dim Slot As Rules.AvailableFeats.FeatSlot

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub
        Slot = SelectedSlot

        If AvailableSlots.Items.Count < 2 Then
            General.ShowErrorDialog("Cannot remove last slot.")
            Exit Sub
        End If

        If Not Slot.FeatGuid.IsEmpty Then
            General.ShowErrorDialog("Can only remove empty slots.")
            Exit Sub
        End If

        If Slot.SlotType <> Rules.AvailableFeats.FeatSlotType.UserAdded Then
            General.ShowErrorDialog("Can only remove user added slots.")
            Exit Sub
        End If

        AvailableSlots.Items.Remove(AvailableSlots.SelectedItems(0))
        EnableDisableNext()

    End Sub

    'handles the cancel button
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
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
            NaturalAttacks.Add(General.ConvertToObjectKey(NaturalAttack, XML.DBTypes.NaturalWeapons), NaturalAttack)
        Next
    End Sub

    'stop worker thread
    Private Sub CharacterFeatForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        StopUpdateFeatWorker()
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

End Class