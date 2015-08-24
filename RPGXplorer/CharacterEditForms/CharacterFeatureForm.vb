Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CharacterFeatureForm
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
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents RemoveSlot As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents AddSlot As System.Windows.Forms.Button
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents AvailableSlots As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents TakeFeature As System.Windows.Forms.Button
    Public WithEvents PutFeatureBack As System.Windows.Forms.Button
    Public WithEvents AvailableFeatures As System.Windows.Forms.ListView
    Public WithEvents IgnoreCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CharacterFeatureForm))
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.RemoveSlot = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.AddSlot = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableFeatures = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.Label2 = New System.Windows.Forms.Label
        Me.PutFeatureBack = New System.Windows.Forms.Button
        Me.TakeFeature = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
		Me.ObjLabel = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.IgnoreCheck = New System.Windows.Forms.CheckBox
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 595)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(920, 5)
        Me.IndentedLine2.TabIndex = 287
        Me.IndentedLine2.TabStop = False
        '
        'RemoveSlot
        '
        Me.RemoveSlot.Location = New System.Drawing.Point(110, 330)
        Me.RemoveSlot.Name = "RemoveSlot"
        Me.RemoveSlot.Size = New System.Drawing.Size(90, 24)
        Me.RemoveSlot.TabIndex = 286
        Me.RemoveSlot.Text = "Remove Slot"
        '
        'OK
        '
        Me.OK.Enabled = False
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(785, 610)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 284
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(865, 610)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 285
        Me.Cancel.Text = "Cancel"
        '
        'AddSlot
        '
        Me.AddSlot.Location = New System.Drawing.Point(15, 330)
        Me.AddSlot.Name = "AddSlot"
        Me.AddSlot.Size = New System.Drawing.Size(90, 24)
        Me.AddSlot.TabIndex = 283
        Me.AddSlot.Text = "Add Slot"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableFeatures)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 255)
        Me.Panel2.TabIndex = 278
        '
        'AvailableFeatures
        '
        Me.AvailableFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvailableFeatures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.AvailableFeatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AvailableFeatures.FullRowSelect = True
        Me.AvailableFeatures.HideSelection = False
        Me.AvailableFeatures.Location = New System.Drawing.Point(1, 1)
        Me.AvailableFeatures.MultiSelect = False
        Me.AvailableFeatures.Name = "AvailableFeatures"
        Me.AvailableFeatures.Size = New System.Drawing.Size(408, 253)
        Me.AvailableFeatures.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableFeatures.TabIndex = 122
        Me.AvailableFeatures.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Feature"
        Me.ColumnHeader4.Width = 387
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(440, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 565)
        Me.Panel1.TabIndex = 277
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
        Me.Label2.Size = New System.Drawing.Size(140, 21)
        Me.Label2.TabIndex = 281
        Me.Label2.Text = "Feature slots available"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PutFeatureBack
        '
        Me.PutFeatureBack.Enabled = False
        Me.PutFeatureBack.Location = New System.Drawing.Point(325, 330)
        Me.PutFeatureBack.Name = "PutFeatureBack"
        Me.PutFeatureBack.Size = New System.Drawing.Size(100, 24)
        Me.PutFeatureBack.TabIndex = 275
        Me.PutFeatureBack.Text = "Put Feature Back"
        '
        'TakeFeature
        '
        Me.TakeFeature.Enabled = False
        Me.TakeFeature.Location = New System.Drawing.Point(220, 330)
        Me.TakeFeature.Name = "TakeFeature"
        Me.TakeFeature.Size = New System.Drawing.Size(100, 24)
        Me.TakeFeature.TabIndex = 274
        Me.TakeFeature.Text = "Take Feature"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 21)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Features available"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Feature Taken"
        Me.ColumnHeader3.Width = 321
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(160, 21)
        Me.ObjLabel.TabIndex = 276
        Me.ObjLabel.Text = "Please select your features"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.AvailableSlots)
        Me.Panel3.DockPadding.All = 1
        Me.Panel3.Location = New System.Drawing.Point(15, 395)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 185)
        Me.Panel3.TabIndex = 279
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
        'IgnoreCheck
        '
        Me.IgnoreCheck.Location = New System.Drawing.Point(300, 40)
        Me.IgnoreCheck.Name = "IgnoreCheck"
        Me.IgnoreCheck.Size = New System.Drawing.Size(125, 24)
        Me.IgnoreCheck.TabIndex = 288
        Me.IgnoreCheck.Text = "Ignore Prerequisites"
        '
        'CharacterFeatureForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(957, 651)
        Me.Controls.Add(Me.IgnoreCheck)
        Me.Controls.Add(Me.RemoveSlot)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.AddSlot)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PutFeatureBack)
        Me.Controls.Add(Me.TakeFeature)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ObjLabel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.IndentedLine2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterFeatureForm"
        Me.Text = "CharacterFeatureForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Character As Rules.Character
    Private mMode As FormMode

    Private SlotAllow As Boolean
    Private AllowTakeFeature As Boolean

    Private PreviousURL As String
    Private LastShownFeature As String

    Private NewFeatures As New ArrayList

    'for Edit Mode
    Private ReplaceFeature As Objects.ObjectData
    Private ReplaceSlot As Rules.FeatureSlot

    Private Loading As Boolean

    'returns the selected slot
    Private ReadOnly Property SelectedSlot() As Rules.FeatureSlot
        Get
            Try
                If AvailableSlots.SelectedItems.Count = 1 Then
                    Return CType(AvailableSlots.SelectedItems(0).Tag, Rules.FeatureSlot)
                Else
                    Throw New RPGXplorer.Exceptions.DevelopmentException("No slot selected")
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

    'init
    Public Sub Init()
        'Character.Features.ChooseFeatures.init()
        Loading = True
        If General.Config.Element("IgnoreFeaturePrereqCheck") = "True" Then IgnoreCheck.Checked = True
        Loading = False
    End Sub

    'init for adding extra features to the character
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Dim LevelSelector As New NumericSelector
        Dim NewFeatureSlot As New Rules.FeatureSlot
        Try
            'init form vars
            mMode = FormMode.Add

            'init form
            Me.Text = "Add Features"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            'get the character 
            Character = CharacterManager.CurrentCharacter.Clone()
            Init()

            LevelSelector.Init("Character Level", "Select level gained", 1, Character.CharacterLevel, Character.CharacterLevel)
            If LevelSelector.ShowDialog = DialogResult.OK Then

                NewFeatureSlot.CharacterLevel = LevelSelector.Value
                NewFeatureSlot.SlotType = Rules.FeatureSlotType.UserAdded
                NewFeatureSlot.SlotSource = Rules.StackingType.User

                AvailableSlots.Items.Add(LoadSlot(NewFeatureSlot))
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
    Public Sub InitEdit(ByVal ExistingFeature As Objects.ObjectData)
        Dim ActualSourceGuid As Objects.ObjectKey

        'init form vars
        mMode = FormMode.Edit
        ReplaceFeature = ExistingFeature

        'init form
        Me.Text = "Add or Edit Features"
        Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")

        'get the character - get the character from the panel (in case locked window)
        Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey).Clone()
        Init()

        'Add the edit slot into the list view
        If ExistingFeature.Element("SourceType") = Rules.Features.FeatureSourceChosenFeature Then
            ReplaceSlot.SlotType = Rules.FeatureSlotType.ChosenFeature

            'ReplaceSlot.ChooseFeatureName = ExistingFeature.Element("ChoiceObject")
            ReplaceSlot.ChooseFeatureObject = ExistingFeature.GetFKObject("ChoiceObject")

        Else
            ReplaceSlot.SlotType = Rules.FeatureSlotType.ExistingEdit
        End If

        ReplaceSlot.CharacterLevel = ExistingFeature.ElementAsInteger("CharacterLevel")
        ReplaceSlot.FeatureGuid = ExistingFeature.GetFKGuid("Feature")
        ReplaceSlot.FeatureName = ExistingFeature.Element("Feature")
        ReplaceSlot.ClassGuid = ExistingFeature.GetFKGuid("Class")
        ReplaceSlot.ClassName = ExistingFeature.Element("Class")

        'Find the progressive source type
        ActualSourceGuid = ExistingFeature.GetFKGuid("Source")
        If ActualSourceGuid.Equals(RPGXplorer.References.AddedFeatureClass) Then
            ReplaceSlot.SlotSource = Rules.StackingType.User
        Else
            Select Case ActualSourceGuid.Database
                Case XML.DBTypes.Classes
                    ReplaceSlot.SlotSource = Rules.StackingType.Class
                Case XML.DBTypes.Races
                    ReplaceSlot.SlotSource = Rules.StackingType.Race
                Case Else
                    ReplaceSlot.SlotSource = Rules.StackingType.Class
            End Select
        End If

        AvailableSlots.Items.Add(LoadSlot(ReplaceSlot))

        AvailableSlots.Items(0).Selected = True
        EnableDisableNext()
    End Sub

    'makes a ListView Item for the given slot
    Private Function LoadSlot(ByVal Slot As Rules.FeatureSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        ListViewItem.Text = "Level " & Slot.CharacterLevel.ToString
        ListViewItem.SubItems.Add(New ListViewItem.ListViewSubItem(ListViewItem, Slot.FeatureName))
        ListViewItem.Tag = Slot

        Return ListViewItem
    End Function

    'makes a ListView Item for the given feature
    Private Function LoadFeature(ByVal FeatureInfo As Rules.AvailableFeature) As ListViewItem
        Dim ListViewItem As New ListViewItem
        Try
            ListViewItem.Text = FeatureInfo.FeatureName
            ListViewItem.Tag = FeatureInfo

            Select Case FeatureInfo.Status
                Case Rules.FeatureStatus.Taken
                    ListViewItem.ForeColor = System.Drawing.Color.DarkGoldenrod

                Case Rules.FeatureStatus.PrerequisitesNotMet
                    ListViewItem.ForeColor = Rules.Constants.FailedFeatColor

            End Select

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Enable/disable next
    Private Sub EnableDisableNext()
        For Each Item As ListViewItem In AvailableSlots.Items
            If Item.SubItems(1).Text = "" Then
                OK.Enabled = False
                Exit Sub
            End If
        Next
        OK.Enabled = True
    End Sub

    'move to next slot
    Private Sub MoveToNextAvailableSlot(ByVal PreviousIndex As Integer)
        For Each Item As ListViewItem In AvailableSlots.Items
            If CType(Item.Tag, Rules.FeatureSlot).FeatureName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next

        AvailableSlots.Items(PreviousIndex).Selected = True
        AvailableSlots.EnsureVisible(PreviousIndex)

    End Sub

    'pdate the AvailableFeats
    Private Sub UpdateFeatureList()
        Dim FeatureList As New ArrayList
        Dim FeatureInfo As Rules.AvailableFeature

        Try
            AvailableFeatures.BeginUpdate()
            AvailableFeatures.Items.Clear()

            FeatureList = Character.Features.ChooseFeatures.ChooseAvailableFeatures(SelectedSlot, False, IgnoreCheck.Checked)

            'add the feats to the list
            For Each FeatureInfo In FeatureList
                AvailableFeatures.Items.Add(LoadFeature(FeatureInfo))
            Next

            'show current feature if any
            If LastShownFeature <> "" Then
                For Each Item As ListViewItem In AvailableFeatures.Items
                    If Item.Text = LastShownFeature Then
                        Item.Selected = True
                        Item.EnsureVisible()
                        AvailableFeatures.EndUpdate()
                        Exit Sub
                    End If
                Next
            End If

            If AvailableFeatures.Items.Count > 0 Then
                AvailableFeatures.Items(0).Selected = True
            End If
            AvailableFeatures.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handles"

    'handles clicking the ok button
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Feature As Rules.Feature
        Dim FeatureObject As Objects.ObjectData

        General.MainExplorer.Undo.UndoRecord()

        'If the existing feat has been changed, then delete the object from the character
        If mMode = FormMode.Edit Then
            If Not ReplaceSlot.FeatureGuid.Equals(ReplaceFeature.GetFKGuid("Feature")) Then
                ReplaceFeature.Delete()
            End If
        End If

        'Write feats to db
        For Each Feature In NewFeatures
            FeatureObject = Feature.CreateObject(Character)

            'set fixed for user added feats
            If FeatureObject.Element("SourceType") = Rules.Features.FeatureSourceUserAdded Then
                FeatureObject.Fixed = False
            End If

            FeatureObject.Save()
        Next

        'Update the cached character
        CharacterManager.UpdateCharacter(Character)

        General.MainExplorer.RefreshPanel()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    'handles clicking the cancel button
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'handles the add slot button
    Private Sub AddSlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSlot.Click
        Dim LevelSelector As New NumericSelector
        Dim NewFeatureSlot As New Rules.FeatureSlot

        LevelSelector.Init("Character Level", "Select Level", 1, Character.CharacterLevel, Character.CharacterLevel)

        If LevelSelector.ShowDialog = DialogResult.OK Then
            NewFeatureSlot.CharacterLevel = LevelSelector.Value
            NewFeatureSlot.SlotType = Rules.FeatureSlotType.UserAdded
            NewFeatureSlot.SlotSource = Rules.StackingType.User

            AvailableSlots.Items.Add(LoadSlot(NewFeatureSlot))
        Else
            Exit Sub
        End If

        EnableDisableNext()

    End Sub

    'handles the remove slot button
    Private Sub RemoveSlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSlot.Click
        Dim Slot As Rules.FeatureSlot

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub
        Slot = SelectedSlot

        If AvailableSlots.Items.Count < 2 Then
            General.ShowErrorDialog("Cannot remove last slot.")
            Exit Sub
        End If

        If Not Slot.FeatureGuid.IsEmpty Then
            General.ShowErrorDialog("Can only remove empty slots.")
            Exit Sub
        End If

        If Slot.SlotType <> Rules.FeatureSlotType.UserAdded Then
            General.ShowErrorDialog("Can only remove user added slots.")
            Exit Sub
        End If

        AvailableSlots.Items.Remove(AvailableSlots.SelectedItems(0))
        EnableDisableNext()
    End Sub

    'handles the take feature button
    Private Sub TakeFeature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeFeature.Click
        Dim Slot As Rules.FeatureSlot
        Dim Feature As Rules.AvailableFeature
        Dim NewFeature As New Rules.Feature
        Dim SlotIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailableFeatures.SelectedItems.Count) <> 2 Then Exit Sub

        'get the spell and the slot
        Feature = CType(AvailableFeatures.SelectedItems(0).Tag, Rules.AvailableFeature)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.FeatureSlot)

        If Feature.Status = Rules.FeatureStatus.Taken Then Exit Sub

        If Slot.FeatureName = "" Then
            Dim ProgressionsToUpdate As New ArrayList

            'update current slot
            Slot.FeatureName = Feature.FeatureName
            Slot.FeatureGuid = Feature.FeatureGuid
            Slot.FeatureStatus = Feature.Status

            AvailableSlots.BeginUpdate()
            SlotIndex = AvailableSlots.SelectedIndices(0)
            AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

            'create a new feature
            NewFeature.FeatureName = Slot.FeatureName
            NewFeature.FeatureGuid = Slot.FeatureGuid
            NewFeature.ClassName = Slot.ClassName
            NewFeature.ClassGuid = Slot.ClassGuid
            NewFeature.LevelTaken = Slot.CharacterLevel

            Select Case Slot.SlotType

                Case Rules.FeatureSlotType.ExistingEdit
                    NewFeature.ActualSourceName = ReplaceFeature.Element("Source")
                    NewFeature.ActualSourceGuid = ReplaceFeature.GetFKGuid("Source")
                    NewFeature.StackingType = Slot.SlotSource
                    Dim ReplaceSourceType As String = ReplaceFeature.Element("SourceType")
                    If ReplaceSourceType.EndsWith("(Edited)") OrElse ReplaceSourceType = Rules.Features.FeatureSourceUserAdded Then
                        NewFeature.FeatureSlotSource = ReplaceSourceType
                    Else
                        NewFeature.FeatureSlotSource = ReplaceSourceType & " (Edited)"
                    End If

                    'update the edit slot
                    ReplaceSlot = Slot

                Case Rules.FeatureSlotType.ChosenFeature
                    NewFeature.ActualSourceName = ReplaceFeature.Element("Source")
                    NewFeature.ActualSourceGuid = ReplaceFeature.GetFKGuid("Source")
                    NewFeature.StackingType = Slot.SlotSource
                    NewFeature.FeatureSlotSource = Rules.Features.FeatureSourceChosenFeature
                    NewFeature.ChoiceKey = Slot.ChooseFeatureObject.ObjectGUID
                    NewFeature.ChoiceName = Slot.ChooseFeatureObject.Name

                    'update the edit slot
                    ReplaceSlot = Slot

                Case Rules.FeatureSlotType.UserAdded
                    NewFeature.ActualSourceGuid = RPGXplorer.References.AddedFeatureClass
                    NewFeature.ActualSourceName = "User"
                    NewFeature.StackingType = Rules.StackingType.User
                    NewFeature.FeatureSlotSource = Rules.Features.FeatureSourceUserAdded

            End Select

            If Feature.IgnoringPrereqs Then NewFeature.IgnorePrerequisites = True Else NewFeature.IgnorePrerequisites = False

            'add it to the character
            Character.Features.AddFeature(NewFeature)

            'Add feature to the vlaid lookup table
            Character.Components.Features(NewFeature.FeatureGuid.ToString) = Character.Components.AnalyseComponent(NewFeature.FeatureGuid, NewFeature.LevelTaken)
            Character.Calculate(False)

            'record the fact that this is a new feature
            If Not ((Slot.SlotType = Rules.FeatureSlotType.ChosenFeature OrElse Slot.SlotType = Rules.FeatureSlotType.ExistingEdit) AndAlso NewFeature.FeatureGuid.Equals(ReplaceFeature.GetFKGuid("Feature"))) Then
                NewFeatures.Add(NewFeature)
            End If

            'FeatureIndex = AvailableFeatures.SelectedIndices(0)
            'AvailableSlots.Items(SlotIndex).Selected = True
            'AvailableSlots.SelectedItems(0).EnsureVisible()
            AvailableSlots.EndUpdate()

            'AvailableFeatures.BeginUpdate()
            'UpdateFeatureList()
            'AvailableFeatures.Items(FeatureIndex).Selected = True
            'AvailableFeatures.SelectedItems(0).EnsureVisible()
            'AvailableFeatures.EndUpdate()

            EnableDisableNext()
            MoveToNextAvailableSlot(SlotIndex)
        End If
    End Sub

    'handles the put feature back button
    Private Sub PutFeatureBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutFeatureBack.Click
        Dim Slot As Rules.FeatureSlot
        Dim SlotIndex As Integer

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.FeatureSlot)
        If Slot.FeatureName = "" Then Exit Sub

        'remove feature
        Character.Features.RemoveFeature(Slot.FeatureGuid, Slot.ClassGuid, Slot.CharacterLevel)

        'remove form new features
        For Each TempFeature As Rules.Feature In NewFeatures
            If TempFeature.FeatureGuid.Equals(Slot.FeatureGuid) And TempFeature.LevelTaken = Slot.CharacterLevel Then
                NewFeatures.Remove(TempFeature)
                Exit For
            End If
        Next

        Slot.FeatureName = ""
        Slot.FeatureGuid = Nothing
        Slot.FeatureStatus = Nothing

        SlotIndex = AvailableSlots.SelectedIndices(0)
        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()

        EnableDisableNext()

    End Sub

    'load the new features for the selected slot
    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot As Rules.FeatureSlot

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Slot = SelectedSlot

                UpdateFeatureList()

                If SelectedSlot.FeatureName = "" Then
                    SlotAllow = True
                    PutFeatureBack.Enabled = False
                Else
                    SlotAllow = False
                    PutFeatureBack.Enabled = True
                End If

                If SlotAllow And AllowTakeFeature Then
                    TakeFeature.Enabled = True
                Else
                    TakeFeature.Enabled = False
                End If

            End If

            If Slot.FeatureGuid.IsNotEmpty Then
                Dim Feature As Objects.ObjectData = DirectCast(Caches.Features.Item(SelectedSlot.FeatureGuid), Objects.ObjectData)
                Dim URL As String
                If Feature.HTML.IndexOf(":\") = 1 And IO.File.Exists(Feature.HTML) Then
                    URL = "file://" & Feature.HTML
                Else
                    If IO.File.Exists(General.HelpPath & Feature.HTML) Then
                        URL = "file://" & General.HelpPath & Feature.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL
            End If

            'Clear last shown feature
            LastShownFeature = ""

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'display the help page for the selected feature
    Private Sub AvailableFeatures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableFeatures.SelectedIndexChanged
        Dim FeatureInfo As Rules.AvailableFeature

        Try
            If AvailableFeatures.SelectedItems.Count > 0 Then
                FeatureInfo = CType(AvailableFeatures.SelectedItems(0).Tag, Rules.AvailableFeature)

                Dim URL As String
                If FeatureInfo.HTML.IndexOf(":\") = 1 And IO.File.Exists(FeatureInfo.HTML) Then
                    URL = "file://" & FeatureInfo.HTML
                Else
                    If IO.File.Exists(General.HelpPath & FeatureInfo.HTML) Then
                        URL = "file://" & General.HelpPath & FeatureInfo.HTML
                    Else
                        URL = "file://" & General.HelpPath & "Help\FileNotFound.htm"
                    End If
                End If
                If PreviousURL <> URL Then Browser.Navigate(URL)
                PreviousURL = URL

                Select Case FeatureInfo.Status
                    Case Rules.FeatureStatus.Available
                        AllowTakeFeature = True

                    Case Rules.FeatureStatus.Taken, Rules.FeatureStatus.PrerequisitesNotMet
                        AllowTakeFeature = False
                End Select

                If SlotAllow And AllowTakeFeature Then
                    TakeFeature.Enabled = True
                Else
                    TakeFeature.Enabled = False
                End If

            End If

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

    'ignore feature prerequisites
    Private Sub IgnoreCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreCheck.CheckedChanged
        If Loading Then Exit Sub
        If IgnoreCheck.Checked Then General.Config.Element("IgnoreFeaturePrereqCheck") = "True" Else General.Config.Element("IgnoreFeaturePrereqCheck") = ""
        If AvailableSlots.SelectedItems.Count = 1 Then
            UpdateFeatureList()
        End If
    End Sub

End Class