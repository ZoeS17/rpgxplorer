Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class SelectSchoolSpecialization
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
	Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents SacNumber As RPGXplorer.ReadOnlyTextBox
    Public WithEvents SacrificeSchool As System.Windows.Forms.Button
    Public WithEvents ReturnSchool As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents SchoolsListView As System.Windows.Forms.ListView
    Public WithEvents SpecialistDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents SacrificedListBox As RPGXplorer.ListBox
    Public WithEvents ClassDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SelectSchoolSpecialization))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SacrificeSchool = New System.Windows.Forms.Button
        Me.ReturnSchool = New System.Windows.Forms.Button
        Me.SacNumber = New RPGXplorer.ReadOnlyTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SchoolsListView = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.SacrificedListBox = New RPGXplorer.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.SpecialistDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ClassDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        ''CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialistDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sacrificable Schools"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 288
        Me.Label2.Text = "Specialist School"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SacrificeSchool
        '
        Me.SacrificeSchool.Location = New System.Drawing.Point(15, 260)
        Me.SacrificeSchool.Name = "SacrificeSchool"
        Me.SacrificeSchool.Size = New System.Drawing.Size(100, 24)
        Me.SacrificeSchool.TabIndex = 3
        Me.SacrificeSchool.Text = "Sacrifice School"
        '
        'ReturnSchool
        '
        Me.ReturnSchool.Location = New System.Drawing.Point(125, 260)
        Me.ReturnSchool.Name = "ReturnSchool"
        Me.ReturnSchool.Size = New System.Drawing.Size(90, 24)
        Me.ReturnSchool.TabIndex = 4
        Me.ReturnSchool.Text = "Return School"
        '
        'SacNumber
        '
        Me.SacNumber.BackColor = System.Drawing.Color.White
        Me.SacNumber.Caption = Nothing
        Me.SacNumber.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.SacNumber.DockPadding.All = 1
        Me.SacNumber.ForeColor = System.Drawing.Color.Black
        Me.SacNumber.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.SacNumber.Location = New System.Drawing.Point(185, 155)
        Me.SacNumber.Name = "SacNumber"
        Me.SacNumber.Size = New System.Drawing.Size(30, 21)
        Me.SacNumber.TabIndex = 293
        Me.SacNumber.TabStop = False
        Me.SacNumber.TextColor = System.Drawing.Color.Black
        Me.SacNumber.Vertical = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(15, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 21)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Number of schools to sacrifice"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SchoolsListView)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(15, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 225)
        Me.Panel1.TabIndex = 297
		'
        'SchoolsListView
        '
        Me.SchoolsListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SchoolsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.SchoolsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchoolsListView.FullRowSelect = True
        Me.SchoolsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.SchoolsListView.HideSelection = False
        Me.SchoolsListView.Location = New System.Drawing.Point(1, 1)
        Me.SchoolsListView.MultiSelect = False
        Me.SchoolsListView.Name = "SchoolsListView"
        Me.SchoolsListView.Size = New System.Drawing.Size(198, 223)
        Me.SchoolsListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.SchoolsListView.TabIndex = 0
        Me.SchoolsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 198
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 299
        Me.Label3.Text = "Spellcasting Class"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'SacrificedListBox
        '
        Me.SacrificedListBox.Location = New System.Drawing.Point(15, 180)
        Me.SacrificedListBox.Name = "SacrificedListBox"
        Me.SacrificedListBox.Size = New System.Drawing.Size(200, 70)
        Me.SacrificedListBox.TabIndex = 2
		'
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 21)
        Me.Label4.TabIndex = 322
        Me.Label4.Text = "Optional - Select specialization(s)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Browser)
        Me.Panel2.DockPadding.All = 1
        Me.Panel2.Location = New System.Drawing.Point(230, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 535)
        Me.Panel2.TabIndex = 323
        '
        'Browser
        '        
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.Browser.Enabled = True
        Me.Browser.Location = New System.Drawing.Point(1, 1)
        Me.Browser.Size = New System.Drawing.Size(498, 533)
        Me.Browser.TabIndex = 112
        Me.Browser.TabStop = False
        '
        'SpecialistDropdown
        '
        Me.SpecialistDropdown.EditValue = ""
        Me.SpecialistDropdown.Location = New System.Drawing.Point(15, 125)
        Me.SpecialistDropdown.Name = "SpecialistDropdown"
        '
        'SpecialistDropdown.Properties
        '
        Me.SpecialistDropdown.Properties.AutoHeight = False
        Me.SpecialistDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpecialistDropdown.Properties.DropDownRows = 10
        Me.SpecialistDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpecialistDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SpecialistDropdown.TabIndex = 1
        '
        'ClassDropdown
        '
        Me.ClassDropdown.EditValue = ""
        Me.ClassDropdown.Location = New System.Drawing.Point(15, 70)
        Me.ClassDropdown.Name = "ClassDropdown"
        '
        'ClassDropdown.Properties
        '
        Me.ClassDropdown.Properties.AutoHeight = False
        Me.ClassDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClassDropdown.Properties.DropDownRows = 10
        Me.ClassDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassDropdown.Size = New System.Drawing.Size(200, 21)
        Me.ClassDropdown.TabIndex = 0
        '
        'SelectSchoolSpecialization
        '
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ClassDropdown)
        Me.Controls.Add(Me.SacrificedListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SpecialistDropdown)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SacNumber)
        Me.Controls.Add(Me.ReturnSchool)
        Me.Controls.Add(Me.SacrificeSchool)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.Name = "SelectSchoolSpecialization"
        Me.Size = New System.Drawing.Size(745, 565)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialistDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private SchoolsDatalist As General.DataListItem()

    Private Specialisations As Integer
    Private Spellcasters As ArrayList
    Private SpecialistSchool As Objects.ObjectData

    Private SpecialistSchools As New Hashtable(5)
    Private SacrificedSchools As New Hashtable(5)
    Private Sacrifices As Hashtable
    Private TotalSacrifices As Hashtable

    Private SchoolsToBeSacrificed As Integer

    Private Character As Rules.Character
    Private ClassInfo As Rules.CharacterClass

#End Region

    'initialise this panel
    Public Sub Init(ByVal Character As Rules.Character)
        Dim TempItem As General.DataListItem

        Try
            IsInitialised = True
            Specialisations = 0
            TotalSacrifices = New Hashtable
            Sacrifices = New Hashtable
            Me.Character = Character
            AddHandler SacrificedListBox.List.DoubleClick, AddressOf SacrificedListBox_DoubleClick

            ClassDropdown.Properties.Items.Clear()
            SpecialistDropdown.Properties.Items.Clear()
            SacrificedListBox.Clear()
            SchoolsListView.Items.Clear()

            SchoolsDatalist = Rules.Index.DataList(XML.DBTypes.SpellSchools, Objects.SpellSchoolType)
            SpecialistDropdown.Properties.Items.Add(New DataListItem(Nothing, ""))

            For Each TempClassInfo As Rules.CharacterClass In Spellcasters
                ClassDropdown.Properties.Items.Add(New DataListItem(TempClassInfo, TempClassInfo.ClassObj.Name))
            Next

            Me.ClassInfo = CType(Spellcasters(0), Rules.CharacterClass)

            'load dropdown and list view
            For Each TempItem In SchoolsDatalist
                If CType(TempItem.ValueMember, Objects.ObjectData).Element("CanBeSpecialist") = "Yes" Then
                    SpecialistDropdown.Properties.Items.Add(TempItem)
                End If

                If CType(TempItem.ValueMember, Objects.ObjectData).Element("CanBeSacrificed") = "Yes" Then
                    Dim ListItem As New ListViewItem
                    ListItem.Text = TempItem.ToString
                    ListItem.Tag = TempItem
                    SchoolsListView.Items.Add(ListItem)
                End If
            Next

            SpecialistDropdown.SelectedIndex = 0
            ClassDropdown.SelectedIndex = 0

            EnableDisableNext()
            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'panel required
    Public Function PanelRequired(ByVal NewCharacter As Rules.Character) As Boolean
        Spellcasters = New ArrayList
        Dim CharClass As Rules.CharacterClass
        Dim RaceCasterKey As Objects.ObjectKey

        'is this a racial wizard caster above first level?
        RaceCasterKey = NewCharacter.RaceObject.GetFKGuid("CasterSource")

        If NewCharacter.FirstNewLevel = 1 Then
            If RaceCasterKey.IsNotEmpty Then
                CharClass = Caches.GetCharacterClass(RaceCasterKey)
                If CharClass.CasterInfo.SelectSchool = True Then
                    Spellcasters.Add(CharClass)
                End If
            End If
        End If

        'go through the character and find the wizard type classes
        For Each CharClass In NewCharacter.CharacterClasses.Values
            If NewCharacter.LowestClassLevel(CharClass.ClassObj.ObjectGUID) >= NewCharacter.FirstNewLevel Then
                If CharClass.CasterInfo.SelectSchool = True Then
                    If Not CharClass.ClassObj.ObjectGUID.Equals(RaceCasterKey) Then
                        Spellcasters.Add(CharClass)
                    End If
                End If
            End If
        Next

        If Spellcasters.Count > 0 Then
            Return True
        Else
            Return False
        End If

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
            Return 745
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 650
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel
        Try

            IsInitialised = True
            RaiseEvent EnableNext(True)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub SacrificeSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SacrificeSchool.Click
        Dim TempItem As DataListItem
        Dim School As New Rules.Character.CharacterChoice

        Try
            If (SchoolsListView.SelectedItems.Count < 1) OrElse (SchoolsListView.SelectedItems(0).ForeColor.Equals(Color.Silver)) OrElse (SchoolsToBeSacrificed < 1) Then Exit Sub

            TempItem = CType(SchoolsListView.SelectedItems(0).Tag, DataListItem)

            If SacrificedListBox.Contains(TempItem.ObjectGUID) Then
                General.ShowInfoDialog("This School has already been added.")
                Exit Sub
            End If

            'update display
            SchoolsToBeSacrificed -= 1
            SacNumber.Text = SchoolsToBeSacrificed.ToString

            'Add to ListBox
            SacrificedListBox.AddItem(TempItem.ValueMember)

            'Add to Character
            School.ClassName = ClassInfo.ClassObj.Name
            School.ClassGuid = ClassInfo.ClassObj.ObjectGUID
            School.DataGuid = TempItem.ObjectGUID
            School.Data = TempItem.DisplayMember
            School.Type = Rules.Character.ChoiceType.SacrificedSchool
            School.LevelAcquired = Character.LowestClassLevel(School.ClassGuid)
            Character.Choices.AddItemWithSubkey(School.ClassGuid, School.DataGuid, School, School.LevelAcquired)

            'update counter
            Sacrifices.Item(ClassInfo.ClassObj.ObjectGUID) = CType(Sacrifices.Item(ClassInfo.ClassObj.ObjectGUID), Integer) + 1

            EnableDisableNext()
            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ReturnSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnSchool.Click
        Try
            If SacrificedListBox.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a school to remove.")
                Exit Sub
            End If

            'Remove from character
            Character.Choices.RemoveItem(ClassInfo.ClassObj.ObjectGUID, SacrificedListBox.ItemGUID)

            'Remove from box
            SacrificedListBox.RemoveSelectedItem()

            SchoolsToBeSacrificed += 1
            SacNumber.Text = SchoolsToBeSacrificed.ToString

            'update counter
            Sacrifices.Item(ClassInfo.ClassObj.ObjectGUID) = CType(Sacrifices.Item(ClassInfo.ClassObj.ObjectGUID), Integer) - 1

            RaiseEvent DisableNext()
            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SpecialistDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialistDropdown.SelectedIndexChanged
        Try
            If SpecialistDropdown.SelectedIndex = -1 Then Exit Sub

            Dim SacrificedSchools As Objects.ObjectDataCollection
            Dim School As Objects.ObjectData
            Dim Choice As New Rules.Character.CharacterChoice

            School = CType(CType(SpecialistDropdown.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)

            'delete any previous choice from the character
            If Character.Choices.ContainsKey(ClassInfo.ClassObj.ObjectGUID) Then
                For Each ChoiceData As Library.LibraryData In Character.Choices.ItemData(ClassInfo.ClassObj.ObjectGUID)
                    Choice = CType(ChoiceData.Data, Rules.Character.CharacterChoice)
                    If Choice.Type = Rules.Character.ChoiceType.SpecailistSchool Then
                        Character.Choices.RemoveItem(ClassInfo.ClassObj.ObjectGUID, Choice.DataGuid)
                        Exit For
                    End If
                Next
            End If

            'remove the sacrificed schools from the character
            If Character.Choices.ContainsKey(ClassInfo.ClassObj.ObjectGUID) Then
                For Each TempObject As Objects.ObjectData In SacrificedListBox.GetObjects
                    Character.Choices.RemoveItem(ClassInfo.ClassObj.ObjectGUID, TempObject.ObjectGUID)
                Next
            End If

            'remove previous specialisation from hashtable
            If SpecialistSchools.Contains(ClassInfo.ClassObj.ObjectGUID) Then
                SpecialistSchools.Remove(ClassInfo.ClassObj.ObjectGUID)
            End If

            'add new choice
            If School.ObjectGUID.IsNotEmpty Then
                Choice.ClassName = ClassInfo.ClassObj.Name
                Choice.ClassGuid = ClassInfo.ClassObj.ObjectGUID
                Choice.DataGuid = School.ObjectGUID
                Choice.Data = School.Name
                Choice.Type = Rules.Character.ChoiceType.SpecailistSchool
                Choice.LevelAcquired = Character.LowestClassLevel(Choice.ClassGuid)
                Character.Choices.AddItemWithSubkey(Choice.ClassGuid, Choice.DataGuid, Choice, Choice.LevelAcquired)
            End If

            SacrificedListBox.Clear()

            SacrificedSchools = School.ChildrenOfType(Objects.SpellSchoolSacrificedType)
            SacNumber.Text = School.Element("ProhibitedSchools")
            SchoolsToBeSacrificed = School.ElementAsInteger("ProhibitedSchools")

            'maintain a list of sacrifice counters for each class
            If School.ObjectGUID.IsNotEmpty Then
                If Not Sacrifices.Contains(ClassInfo.ClassObj.ObjectGUID) Then
                    Sacrifices.Add(ClassInfo.ClassObj.ObjectGUID, 0)
                    TotalSacrifices.Add(ClassInfo.ClassObj.ObjectGUID, School.ElementAsInteger("ProhibitedSchools"))
                Else
                    Sacrifices.Item(ClassInfo.ClassObj.ObjectGUID) = School.ElementAsInteger("ProhibitedSchools") - SchoolsToBeSacrificed
                    TotalSacrifices.Item(ClassInfo.ClassObj.ObjectGUID) = School.ElementAsInteger("ProhibitedSchools")
                End If
            Else
                If Sacrifices.Contains(ClassInfo.ClassObj.ObjectGUID) Then
                    Sacrifices.Remove(ClassInfo.ClassObj.ObjectGUID)
                    TotalSacrifices.Remove(ClassInfo.ClassObj.ObjectGUID)
                End If
            End If

            For Each TempListViewItem As ListViewItem In SchoolsListView.Items
                'If this school is in the list of schools which can be prohibited, make it black, else make it gray
                If SacrificedSchools.ContainsFK("School", CType(TempListViewItem.Tag, General.DataListItem).ObjectGUID) Then
                    TempListViewItem.ForeColor = Color.Black
                Else
                    TempListViewItem.ForeColor = Color.Silver
                End If
            Next

            EnableDisableNext()
            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SchoolsListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolsListView.SelectedIndexChanged
        If SchoolsListView.SelectedItems.Count = 0 Then Exit Sub
        Dim Obj As Objects.ObjectData = CType(CType(SchoolsListView.SelectedItems(0).Tag, DataListItem).ValueMember, Objects.ObjectData)

        If Obj.ObjectGUID.IsNotEmpty Then
            If Obj.HTML.IndexOf(":\") = 1 And IO.File.Exists(Obj.HTML) Then
                Browser.Navigate("file://" & Obj.HTML)
            Else
                If IO.File.Exists(General.HelpPath & Obj.HTML) Then
                    Browser.Navigate("file://" & General.HelpPath & Obj.HTML)
                Else
                    Browser.Navigate("file://" & General.HelpPath & "Help\FileNotFound.htm")
                End If
            End If
        End If
    End Sub

    Private Sub ClassDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassDropdown.SelectedIndexChanged

        'Save current domains
        If SpecialistDropdown.SelectedIndex > 0 Then
            SacrificedSchools(ClassInfo.ClassObj.ObjectGUID) = SacrificedListBox.GetObjects
            SpecialistSchools(ClassInfo.ClassObj.ObjectGUID) = SpecialistDropdown.SelectedItem
        End If

        SacrificedListBox.Clear()

        'Load the new data
        ClassInfo = CType(CType(ClassDropdown.SelectedItem, DataListItem).ValueMember, Rules.CharacterClass)
        If SpecialistSchools.ContainsKey(ClassInfo.ClassObj.ObjectGUID) Then
            SpecialistDropdown.SelectedItem = SpecialistSchools(ClassInfo.ClassObj.ObjectGUID)
            SacrificedListBox.AddObjects(CType(SacrificedSchools(ClassInfo.ClassObj.ObjectGUID), Objects.ObjectDataCollection))
            Dim School As Objects.ObjectData
            School = CType(CType(SpecialistDropdown.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
            SchoolsToBeSacrificed = School.ElementAsInteger("ProhibitedSchools") - SacrificedListBox.Count
            Sacrifices.Item(ClassInfo.ClassObj.ObjectGUID) = SacrificedListBox.Count
            SacNumber.Text = SchoolsToBeSacrificed.ToString
        Else
            SpecialistDropdown.SelectedIndex = 0
        End If

        EnableDisableNext()
        EnableDisableButtons()

    End Sub

#End Region

    'if correct number of schools sacrificed then enable otherwise disable
    Private Sub EnableDisableNext()
        Dim Sacrificed, Required As Integer

        For Each Item As DictionaryEntry In Sacrifices
            Sacrificed += CType(Item.Value, Integer)
        Next

        For Each item As DictionaryEntry In TotalSacrifices
            Required += CType(item.Value, Integer)
        Next

        If Sacrificed = Required Or Required = 0 Then
            RaiseEvent EnableNext(False)
        Else
            RaiseEvent DisableNext()
        End If
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        If SchoolsToBeSacrificed > 0 Then
            SacrificeSchool.Enabled = True
        Else
            SacrificeSchool.Enabled = False
        End If
        If SacrificedListBox.Count = 0 Then
            ReturnSchool.Enabled = False
        Else
            ReturnSchool.Enabled = True
        End If
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

#End Region

    Private Sub SchoolsListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SchoolsListView.DoubleClick
        SacrificeSchool_Click(Nothing, Nothing)
    End Sub

    Private Sub SacrificedListBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        ReturnSchool_Click(Nothing, Nothing)
    End Sub


End Class
