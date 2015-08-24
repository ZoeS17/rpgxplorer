Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class SelectFeaturesPanel
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
    Public WithEvents PutFeatBack As System.Windows.Forms.Button
    Public WithEvents TakeFeature As System.Windows.Forms.Button
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents AvailableFeatures As System.Windows.Forms.ListView
    Public WithEvents IgnoreCheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SelectFeaturesPanel))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AvailableSlots = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AvailableFeatures = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.PutFeatBack = New System.Windows.Forms.Button
        Me.TakeFeature = New System.Windows.Forms.Button
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.IgnoreCheck = New System.Windows.Forms.CheckBox
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
        Me.Label2.Text = "Choose Features gained"
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
        Me.Label1.Text = "Features available for selected slot"
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
        Me.ColumnHeader2.Text = "Selection"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Feature Taken"
        Me.ColumnHeader3.Width = 155
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AvailableFeatures)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(15, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 215)
        Me.Panel2.TabIndex = 136
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
        Me.AvailableFeatures.Size = New System.Drawing.Size(403, 213)
        Me.AvailableFeatures.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableFeatures.TabIndex = 122
        Me.AvailableFeatures.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Feature"
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
        'PutFeatBack
        '
        Me.PutFeatBack.Location = New System.Drawing.Point(320, 290)
        Me.PutFeatBack.Name = "PutFeatBack"
        Me.PutFeatBack.Size = New System.Drawing.Size(100, 24)
        Me.PutFeatBack.TabIndex = 133
        Me.PutFeatBack.Text = "Put Feature Back"
        '
        'TakeFeature
        '
        Me.TakeFeature.Location = New System.Drawing.Point(210, 290)
        Me.TakeFeature.Name = "TakeFeature"
        Me.TakeFeature.Size = New System.Drawing.Size(100, 24)
        Me.TakeFeature.TabIndex = 132
        Me.TakeFeature.Text = "Take Feature"
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(205, 21)
        Me.ObjLabel.TabIndex = 134
        Me.ObjLabel.Text = "Please make your feature choices"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IgnoreCheck
        '
        Me.IgnoreCheck.Location = New System.Drawing.Point(295, 40)
        Me.IgnoreCheck.Name = "IgnoreCheck"
        Me.IgnoreCheck.Size = New System.Drawing.Size(125, 24)
        Me.IgnoreCheck.TabIndex = 142
        Me.IgnoreCheck.Text = "Ignore Prerequisites"
        '
        'SelectFeaturesPanel
        '
        Me.Controls.Add(Me.IgnoreCheck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PutFeatBack)
        Me.Controls.Add(Me.TakeFeature)
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "SelectFeaturesPanel"
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
    Private ChoicesMade As Integer

    Private Loading As Boolean

#End Region

#Region "Properties"

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

#End Region

    'initialise this panel
    Public Function Init(ByVal Character As Rules.Character) As Boolean
        Try
            IsInitialised = True
            ChoicesMade = 0
            Me.Character = Character

            Loading = True
            If General.Config.Element("WizardIgnoreFeaturePrereqCheck") = "True" Then IgnoreCheck.Checked = True
            Loading = False

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

    'Load the slots for the currently selected class
    Private Sub LoadSlots()
        Dim Slots As ArrayList
        Dim Slot As Rules.FeatureSlot

        Try
            'Get the slots for the current class
            Slots = Character.Features.ChooseFeatures.ChooseFeatureSlots

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
    Private Function LoadSlot(ByVal Slot As Rules.FeatureSlot) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try

            ListViewItem.Text = "Level " & Slot.CharacterLevel & " - " & Character.Levels(Slot.CharacterLevel).ClassName & " " & Character.Levels(Slot.CharacterLevel).ClassLevel
            ListViewItem.Tag = Slot
            ListViewItem.SubItems.Add(Slot.ChooseFeatureObject.Name)
            ListViewItem.SubItems.Add(Slot.FeatureName)
            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'update features list
    Private Sub UpdateFeaturesList()
        Dim FeatureList As New ArrayList
        Dim FeatureInfo As Rules.AvailableFeature

        Try
            AvailableFeatures.BeginUpdate()
            AvailableFeatures.Items.Clear()

            FeatureList = Character.Features.ChooseFeatures.ChooseAvailableFeatures(SelectedSlot, , IgnoreCheck.Checked)

            'add the spells to the list
            For Each FeatureInfo In FeatureList
                AvailableFeatures.Items.Add(LoadFeature(FeatureInfo))
            Next

            AvailableFeatures.EndUpdate()

            If AvailableFeatures.Items.Count > 0 Then
                AvailableFeatures.Items(0).Selected = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load feature
    Private Function LoadFeatureOld(ByVal FeatureInfo As Rules.AvailableFeature) As ListViewItem
        Dim ListViewItem As New ListViewItem

        Try
            ListViewItem.Text = FeatureInfo.FeatureName
            ListViewItem.Tag = FeatureInfo

            Select Case FeatureInfo.Status
                Case Rules.FeatureStatus.Taken
                    ListViewItem.ForeColor = System.Drawing.Color.DarkGoldenrod

            End Select

            Return ListViewItem

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'create a listview item for an available feat
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

    'enable/disable next
    Private Sub EnableDisableNext()
        If ChoicesMade = AvailableSlots.Items.Count Then
            RaiseEvent EnableNext(False)
        Else
            RaiseEvent DisableNext()
        End If
    End Sub

    'move to next slot
    Private Sub MoveToNextAvailableSlot()
        For Each Item As ListViewItem In AvailableSlots.Items
            If CType(Item.Tag, Rules.FeatureSlot).FeatureName = "" Then
                Item.Selected = True
                AvailableSlots.EnsureVisible(Item.Index)
                Exit Sub
            End If
        Next
    End Sub

#Region "Event Handlers"

    Private Sub AvailableSlots_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableSlots.SelectedIndexChanged
        Dim Slot As Rules.FeatureSlot

        Try
            If AvailableSlots.SelectedItems.Count = 1 Then
                Slot = SelectedSlot()
                UpdateFeaturesList()
                If Slot.FeatureName = "" Then
                    Me.PutFeatBack.Enabled = False
                Else
                    Me.PutFeatBack.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AvailableFeatures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailableFeatures.SelectedIndexChanged
        Dim FeatureInfo As Rules.AvailableFeature

        Try
            If AvailableFeatures.SelectedItems.Count > 0 Then
                FeatureInfo = CType(AvailableFeatures.SelectedItems(0).Tag, Rules.AvailableFeature)
                If FeatureInfo.FeatureName = "Bonus Feat" Then FeatureInfo.HTML = "Help\BonusFeat2.htm"

                If FeatureInfo.HTML.IndexOf(":\") = 1 And IO.File.Exists(FeatureInfo.HTML) Then
                    Browser.Navigate("file://" & FeatureInfo.HTML)
                Else
                    If IO.File.Exists(General.HelpPath & FeatureInfo.HTML) Then
                        Browser.Navigate("file://" & General.HelpPath & FeatureInfo.HTML)
                    Else
                        Browser.Navigate("file://" & General.HelpPath & "Help\FileNotFound.htm")
                    End If
                End If

                Select Case FeatureInfo.Status
                    Case Rules.FeatureStatus.Taken, Rules.FeatureStatus.PrerequisitesNotMet
                        Me.TakeFeature.Enabled = False
                    Case Else
                        Me.TakeFeature.Enabled = True
                End Select

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub TakeFeature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeFeature.Click
        Dim Slot As Rules.FeatureSlot
        Dim Feature As Rules.AvailableFeature
        Dim NewFeature As New Rules.Feature
        Dim SlotIndex, FeatureIndex As Integer

        If (AvailableSlots.SelectedItems.Count + AvailableFeatures.SelectedItems.Count) <> 2 Then Exit Sub

        If TakeFeature.Enabled = False Then Exit Sub

        'get the spell and the slot
        Feature = CType(AvailableFeatures.SelectedItems(0).Tag, Rules.AvailableFeature)
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.FeatureSlot)

        If Feature.Status = Rules.FeatureStatus.Taken Then Exit Sub

        If Slot.FeatureName = "" Then

            Slot.FeatureName = Feature.FeatureName
            Slot.FeatureGuid = Feature.FeatureGuid
            Slot.FeatureStatus = Feature.Status

            AvailableSlots.BeginUpdate()
            SlotIndex = AvailableSlots.SelectedIndices(0)
            AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)

            Select Case Feature.Status
                Case Rules.FeatureStatus.Available

                    'construct the feature
                    NewFeature.FeatureName = Slot.FeatureName
                    NewFeature.FeatureGuid = Slot.FeatureGuid
                    NewFeature.ClassName = Slot.ClassName
                    NewFeature.ClassGuid = Slot.ClassGuid
                    NewFeature.LevelTaken = Slot.CharacterLevel
                    NewFeature.ChoiceName = Slot.ChooseFeatureObject.Name
                    NewFeature.ChoiceKey = Slot.ChooseFeatureObject.ObjectGUID

                    Select Case Slot.SlotSource
                        Case Rules.StackingType.Class
                            Dim Level As Rules.Character.Level
                            Dim ClassInfo As Rules.CharacterClass
                            Dim ClassLevelObject As Objects.ObjectData

                            Level = Character.Levels(Slot.CharacterLevel)
                            ClassInfo = CType(Character.CharacterClasses(Level.ClassGuid), Rules.CharacterClass)
                            ClassLevelObject = ClassInfo.ClassLevel(Level.ClassLevel)

                            NewFeature.ActualSourceGuid = ClassLevelObject.ObjectGUID
                            NewFeature.ActualSourceName = ClassLevelObject.Name
                            NewFeature.FeatureSlotSource = Rules.Features.FeatureSourceChosenFeature
                            NewFeature.StackingType = Rules.StackingType.Class

                        Case Rules.StackingType.Race
                            NewFeature.ActualSourceGuid = Character.RaceObject.ObjectGUID
                            NewFeature.ActualSourceName = Character.RaceObject.Name
                            NewFeature.FeatureSlotSource = Rules.Features.FeatureSourceChosenFeature
                            NewFeature.StackingType = Rules.StackingType.Race
                    End Select

                    If Feature.IgnoringPrereqs Then NewFeature.IgnorePrerequisites = True Else NewFeature.IgnorePrerequisites = False

                    'add the feature to the character
                    Character.Features.AddFeature(NewFeature)

                    'recalc and add to valid
                    'Add feature to the vlaid lookup table
                    Character.Components.Features(NewFeature.FeatureGuid.ToString) = Character.Components.AnalyseComponent(NewFeature.FeatureGuid, NewFeature.LevelTaken)
                    Character.Calculate(False)

                Case Rules.FeatureStatus.Feat

                    'add an extra feat marker to the character
                    Dim CurrentExtraFeats As Integer
                    CurrentExtraFeats = CInt(Character.ExtraFeats(Slot.CharacterLevel))
                    CurrentExtraFeats += 1
                    Character.ExtraFeats(Slot.CharacterLevel) = CurrentExtraFeats

            End Select

            FeatureIndex = AvailableFeatures.SelectedIndices(0)
            AvailableSlots.Items(SlotIndex).Selected = True
            AvailableSlots.EnsureVisible(SlotIndex)
            AvailableSlots.EndUpdate()

            AvailableFeatures.BeginUpdate()
            UpdateFeaturesList()
            AvailableFeatures.Items(FeatureIndex).Selected = True
            AvailableFeatures.EnsureVisible(FeatureIndex)
            AvailableFeatures.EndUpdate()

            ChoicesMade += 1
            EnableDisableNext()
            MoveToNextAvailableSlot()
        End If
    End Sub

    Private Sub PutFeatureBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutFeatBack.Click
        Dim Slot As Rules.FeatureSlot
        Dim SlotIndex As Integer

        If AvailableSlots.SelectedItems.Count <> 1 Then Exit Sub
        Slot = CType(AvailableSlots.SelectedItems(0).Tag, Rules.FeatureSlot)
        If Slot.FeatureName = "" Then Exit Sub

        Select Case Slot.FeatureStatus
            Case Rules.FeatureStatus.Available
                Character.Features.RemoveFeature(Slot.FeatureGuid, Slot.ClassGuid, Slot.CharacterLevel)
            Case Rules.FeatureStatus.Feat
                'Remove a extra feat marker
                Dim CurrentExtraFeats As Integer
                CurrentExtraFeats = CInt(Character.ExtraFeats(Slot.CharacterLevel))
                CurrentExtraFeats -= 1
                Character.ExtraFeats(Slot.CharacterLevel) = CurrentExtraFeats
        End Select

        Slot.FeatureName = ""
        Slot.FeatureGuid = Nothing
        Slot.FeatureStatus = Nothing
        SlotIndex = AvailableSlots.SelectedIndices(0)
        AvailableSlots.Items(AvailableSlots.SelectedItems(0).Index) = LoadSlot(Slot)
        AvailableSlots.Items(SlotIndex).Selected = True
        AvailableSlots.EnsureVisible(SlotIndex)
        AvailableSlots.EndUpdate()

        ChoicesMade -= 1

        RaiseEvent DisableNext()
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

    Private Sub AvailableFeatures_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableFeatures.DoubleClick
        TakeFeature_Click(Nothing, Nothing)
    End Sub

    Private Sub AvailableSlots_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvailableSlots.DoubleClick
        PutFeatureBack_Click(Nothing, Nothing)
    End Sub
    'ignore feat prerequisites
    Private Sub IgnoreCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreCheck.CheckedChanged
        If Loading Then Exit Sub
        If IgnoreCheck.Checked Then General.Config.Element("WizardIgnoreFeaturePrereqCheck") = "True" Else General.Config.Element("WizardIgnoreFeaturePrereqCheck") = ""
        If AvailableSlots.SelectedItems.Count = 1 Then
            UpdateFeaturesList()
        End If
    End Sub

End Class
