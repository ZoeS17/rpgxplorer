Option Strict On
Option Explicit On 

Imports RPGXplorer.General

Public Class SelectDomainsPanel
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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ReturnDomain As System.Windows.Forms.Button
    Public WithEvents SelectDomain As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents DomainsListBox As RPGXplorer.ListBox
    Public WithEvents ChosenListBox As RPGXplorer.ListBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents ClassDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SelectDomainsPanel))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ReturnDomain = New System.Windows.Forms.Button
        Me.SelectDomain = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DomainsListBox = New RPGXplorer.ListBox
        Me.ChosenListBox = New RPGXplorer.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.ClassDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel1.SuspendLayout()
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Please select your domains"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Available Domains"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReturnDomain
        '
        Me.ReturnDomain.Location = New System.Drawing.Point(120, 190)
        Me.ReturnDomain.Name = "ReturnDomain"
        Me.ReturnDomain.Size = New System.Drawing.Size(95, 24)
        Me.ReturnDomain.TabIndex = 3
        Me.ReturnDomain.Text = "Return Domain"
        '
        'SelectDomain
        '
        Me.SelectDomain.Location = New System.Drawing.Point(15, 190)
        Me.SelectDomain.Name = "SelectDomain"
        Me.SelectDomain.Size = New System.Drawing.Size(95, 24)
        Me.SelectDomain.TabIndex = 2
        Me.SelectDomain.Text = "Select Domain"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 302
        Me.Label2.Text = "Spellcasting Class"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DomainsListBox
        '
        Me.DomainsListBox.Location = New System.Drawing.Point(15, 255)
        Me.DomainsListBox.Name = "DomainsListBox"
        Me.DomainsListBox.Size = New System.Drawing.Size(200, 295)
        Me.DomainsListBox.TabIndex = 4
        '
        'ChosenListBox
        '
        Me.ChosenListBox.Location = New System.Drawing.Point(15, 130)
        Me.ChosenListBox.Name = "ChosenListBox"
        Me.ChosenListBox.Size = New System.Drawing.Size(200, 45)
        Me.ChosenListBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 305
        Me.Label4.Text = "Chosen Domains"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser)
        Me.Panel1.DockPadding.All = 1
        Me.Panel1.Location = New System.Drawing.Point(230, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 535)
        Me.Panel1.TabIndex = 321
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
        'SelectDomainsPanel
        '
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ClassDropdown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChosenListBox)
        Me.Controls.Add(Me.DomainsListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReturnDomain)
        Me.Controls.Add(Me.SelectDomain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SelectDomainsPanel"
        Me.Size = New System.Drawing.Size(745, 565)
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Browser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private IsLoading As Boolean

    Private Spellcasters As ArrayList
    Private ChosenDomains As New Hashtable(4)
    Private DomainCount As Integer
    Private Character As Rules.Character
    Private ClassInfo As Rules.CharacterClass
    Private Deity As Objects.ObjectData

#End Region

    'initialise this panel
    Public Sub Init(ByVal Character As Rules.Character)
        Try
            IsInitialised = True
            IsLoading = True
            DomainCount = 0

            Me.Character = Character
            Deity = Character.DeityObject

            ClassDropdown.Properties.Items.Clear()
            For Each TempClassInfo As Rules.CharacterClass In Spellcasters
                ClassDropdown.Properties.Items.Add(New DataListItem(TempClassInfo, TempClassInfo.ClassObj.Name))
            Next

            Me.ClassInfo = CType(Spellcasters(0), Rules.CharacterClass)
            Filterdomains()

            ClassDropdown.SelectedIndex = 0
            IsLoading = False

            'show help page
            If ChosenListBox.Count > 0 Then
                ChosenListBox.SelectedIndex = 0
                ChosenListBox_SelectedItemChanged()
            Else
                DomainsListBox.SelectedIndex = 0
                DomainsListBox_SelectedItemChanged()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'panel required
    Public Function PanelRequired(ByVal NewCharacter As Rules.Character) As Boolean
        Spellcasters = New ArrayList

        'TODO - DOMAINS

        'go through the character and find the cleric classes
        For Each CharClass As Rules.CharacterClass In NewCharacter.CharacterClasses.Values
            If NewCharacter.LowestClassLevel(CharClass.ClassObj.ObjectGUID) >= NewCharacter.FirstNewLevel Then
                Select Case CharClass.ClassObj.Element("CasterType")
                    Case "Divine (Cleric)"
                        Spellcasters.Add(CharClass)
                End Select
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

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub SelectDomain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectDomain.Click
        Try
            If (DomainsListBox.SelectedIndex = -1) Or (ChosenListBox.Count = 2) Then Exit Sub

            If ChosenListBox.Contains(DomainsListBox.ItemGUID) Then
                General.ShowInfoDialog("This Domain has already been added.")
                Exit Sub
            End If

            IsLoading = True

            ChosenListBox.AddItem(CType(DomainsListBox.ItemObject, Objects.ObjectData))
            Character.Domains.AddDomain(CType(DomainsListBox.ItemObject, Objects.ObjectData), ClassInfo.ClassObj, Character.LowestClassLevel(ClassInfo.ClassObj.ObjectGUID))

            DomainCount += 1

            EnableDisableNext()
            EnableDisableButtons()
            ChosenListBox_SelectedItemChanged()

            IsLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ReturnDomain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnDomain.Click
        Try
            If (ChosenListBox.SelectedIndex = -1) Then
                General.ShowInfoDialog("Please select a domain to remove.")
                Exit Sub
            End If

            'remove domain from character
            Character.Domains.RemoveDomain(ClassInfo.ClassObj.ObjectGUID, ChosenListBox.ItemGUID)

            'remove from list of chosen domains
            ChosenListBox.RemoveSelectedItem()

            DomainCount -= 1

            RaiseEvent DisableNext()
            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ChosenListBox_SelectedItemChanged() Handles ChosenListBox.SelectedItemChanged
        If IsLoading Then Exit Sub

        Dim Obj As Objects.ObjectData = CType(ChosenListBox.ItemObject, Objects.ObjectData)

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

    Private Sub DomainsListBox_SelectedItemChanged() Handles DomainsListBox.SelectedItemChanged
        If IsLoading Then Exit Sub

        Dim Obj As Objects.ObjectData = DomainsListBox.ItemObject

        If Obj.ObjectGUID.IsNotEmpty Then
            'If IO.File.Exists(Obj.HTML) Then
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
        Try

            'Save current domains
            ChosenDomains(ClassInfo.ClassObj.ObjectGUID) = ChosenListBox.GetObjects

            'Clear the listbox and set new class
            ChosenListBox.Clear()

            ClassInfo = CType(CType(ClassDropdown.SelectedItem, DataListItem).ValueMember, Rules.CharacterClass)

            'Load the new domains
            If ChosenDomains.ContainsKey(ClassInfo.ClassObj.ObjectGUID) Then
                ChosenListBox.AddObjects(CType(ChosenDomains(ClassInfo.ClassObj.ObjectGUID), Objects.ObjectDataCollection))
            End If

            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

#End Region

    'filter domains
    Private Sub Filterdomains()
        Try
            DomainsListBox.Clear()
            DomainsListBox.AddObjects(Character.Domains.CompatibleDomains(ClassInfo.ClassObj.ObjectGUID))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'if domains selected = classes x 2 then enable otherwise disable
    Private Sub EnableDisableNext()
        If DomainCount = ClassDropdown.Properties.Items.Count * 2 Then
            RaiseEvent EnableNext(False)
        Else
            RaiseEvent DisableNext()
        End If
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        Select Case ChosenListBox.Count
            Case 0
                SelectDomain.Enabled = True
                ReturnDomain.Enabled = False
            Case 1
                SelectDomain.Enabled = True
                ReturnDomain.Enabled = True
            Case Else
                SelectDomain.Enabled = False
                ReturnDomain.Enabled = True
        End Select
    End Sub

#Region "Paint Events"

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim rect As Rectangle = Panel1.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1
        e.Graphics.DrawRectangle(New System.Drawing.Pen(Color.LightGray, 1), rect)
    End Sub

#End Region

    Private Sub DomainsListBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DomainsListBox.DoubleClick
        SelectDomain_Click(Nothing, Nothing)
    End Sub

    Private Sub ChosenListBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChosenListBox.DoubleClick
        ReturnDomain_Click(Nothing, Nothing)
    End Sub

End Class