Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class SpellListSpecificForm
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
    Public WithEvents RpgxListView As RPGXplorer.RPGXListView
    Public WithEvents CloseButton As System.Windows.Forms.Button
    Public WithEvents AddSpellsButton As System.Windows.Forms.Button
    Public WithEvents SourceLabel As System.Windows.Forms.Label
    Public WithEvents SourceDropdown As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button
        Me.AddSpellsButton = New System.Windows.Forms.Button
        Me.RpgxListView = New RPGXplorer.RPGXListView
        Me.SourceLabel = New System.Windows.Forms.Label
        Me.SourceDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.SourceDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(625, 430)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(85, 24)
        Me.CloseButton.TabIndex = 129
        Me.CloseButton.Text = "Close"
        '
        'AddSpellsButton
        '
        Me.AddSpellsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSpellsButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSpellsButton.Location = New System.Drawing.Point(455, 430)
        Me.AddSpellsButton.Name = "AddSpellsButton"
        Me.AddSpellsButton.Size = New System.Drawing.Size(160, 24)
        Me.AddSpellsButton.TabIndex = 137
        Me.AddSpellsButton.Text = "Add Selection to Spell List"
        '
        'RpgxListView
        '
        Me.RpgxListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RpgxListView.Location = New System.Drawing.Point(15, 50)
        Me.RpgxListView.Name = "RpgxListView"
        Me.RpgxListView.Size = New System.Drawing.Size(693, 365)
        Me.RpgxListView.TabIndex = 139
        '
        'SourceLabel
        '
        Me.SourceLabel.BackColor = System.Drawing.SystemColors.Control
        Me.SourceLabel.Location = New System.Drawing.Point(15, 15)
        Me.SourceLabel.Name = "SourceLabel"
        Me.SourceLabel.Size = New System.Drawing.Size(60, 21)
        Me.SourceLabel.TabIndex = 140
        Me.SourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SourceDropdown
        '
        Me.SourceDropdown.CausesValidation = False
        Me.SourceDropdown.Location = New System.Drawing.Point(85, 15)
        Me.SourceDropdown.Name = "SourceDropdown"
        '
        'SourceDropdown.Properties
        '
        Me.SourceDropdown.Properties.AutoHeight = False
        Me.SourceDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SourceDropdown.Properties.DropDownRows = 20
        Me.SourceDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SourceDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SourceDropdown.TabIndex = 141
        '
        'SpellListSpecificForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 471)
        Me.Controls.Add(Me.SourceDropdown)
        Me.Controls.Add(Me.SourceLabel)
        Me.Controls.Add(Me.RpgxListView)
        Me.Controls.Add(Me.AddSpellsButton)
        Me.Controls.Add(Me.CloseButton)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "SpellListSpecificForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SourceDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private SpellDefinitionsFolder As Objects.ObjectData
    Private ClassSpellFolder As Objects.ObjectData
    Private SpellListFormKey As New Objects.ObjectKey("001-d0ae1bcc-4b9a-4340-8c15-dc3d83501ad6")

    'Objectdatacollections, keyed by spell source
    Private KnownSpells As Hashtable

#End Region

#Region "Eunmerations"

    Public Enum SourceType
        Domain
        Category
    End Enum

#End Region

    'init
    Public Sub Init(ByVal ClassSpellFolder As Objects.ObjectData, ByVal Type As SourceType)
        Try
            'init form
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            'ini form vars
            Me.ClassSpellFolder = ClassSpellFolder
            SpellDefinitionsFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellDefinitionFolderType & "']")
            If SpellDefinitionsFolder.IsEmpty Then Throw New Exception("Cannot find Spell Definition Folder")

            'get the known spells
            KnownSpells = New Hashtable
            For Each SpellTaken As Objects.ObjectData In ClassSpellFolder.Children
                Dim TempCollection As Objects.ObjectDataCollection
                Dim SourceKey As Objects.ObjectKey = SpellTaken.GetFKGuid("Source")

                If KnownSpells.Contains(SourceKey) Then
                    TempCollection = CType(KnownSpells.Item(SourceKey), Objects.ObjectDataCollection)
                Else
                    TempCollection = New Objects.ObjectDataCollection
                    KnownSpells.Add(SourceKey, TempCollection)
                End If

                TempCollection.Add(Rules.SpellList.SpellDefinition(SpellTaken.GetFKGuid("Spell")))
            Next

            'populate dropdown
            Dim SpellSources As DataListItem()
            Select Case Type
                Case SourceType.Category
                    'get a list of all the categories
                    SpellSources = Rules.Index.DataList(Xml.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellCategoryDefinitionType)
                    SourceLabel.Text = "Category"
                    Me.Text = "Add Category Spells"
                Case SourceType.Domain
                    'get a list of all the domains
                    SpellSources = Rules.Index.DataList(Xml.DBTypes.Domains, Objects.DomainDefinitionType)
                    SourceLabel.Text = "Domain"
                    Me.Text = "Add Domain Spells"
                Case Else
                    SpellSources = Nothing
            End Select
            SourceDropdown.Properties.Items.AddRange(SpellSources)

            'init controls
            RpgxListView.Init(SpellListFormKey, Objects.SpellListFolderType, SortType.Alphabetic)
            SourceDropdown.SelectedIndex = 0

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub AddSpells_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSpellsButton.Click
        Dim SelectedObjects As Objects.ObjectDataCollection
        Try

            'get the selected object
            SelectedObjects = RpgxListView.SelectedObjects
            If SelectedObjects.Count = 0 Then Exit Sub

            'set undo
            General.MainExplorer.Undo.UndoRecord()

            Dim SourceKey As Objects.ObjectKey = CType(SourceDropdown.SelectedItem, DataListItem).ObjectGUID

            'Dim Character As Rules.Character = CharacterManager.CurrentCharacter
            Dim CharKey As Objects.ObjectKey = ClassSpellFolder.GetCharacterKey()
            If CharKey.IsNotEmpty Then
                Dim Character As Rules.Character = CharacterManager.GetCharacter(CharKey)
                Dim CurrentSpells As Objects.ObjectDataCollection = CType(KnownSpells.Item(SourceKey), Objects.ObjectDataCollection)
                If CurrentSpells Is Nothing Then
                    CurrentSpells = New Objects.ObjectDataCollection
                    KnownSpells.Add(SourceKey, CurrentSpells)
                End If

                'add the spell to the character & known spells collection
                For Each SpellListItem As Objects.ObjectData In SelectedObjects
                    Dim SpellDefinition As Objects.ObjectData = Rules.SpellList.SpellDefinition(SpellListItem.GetFKGuid("Spell"))
                    Character.Spells.TakeSpell(SpellDefinition.ObjectGUID, SpellListItem.Name, ClassSpellFolder.GetFKGuid("Class"), ClassSpellFolder.Element("Class"), SourceKey, CType(SourceDropdown.SelectedItem, DataListItem).DisplayMember, SpellListItem.ElementAsInteger("Level"), Character.CharacterLevel)
                    CurrentSpells.Add(SpellDefinition)
                Next

                'save the character
                Character.Spells.Save()
                CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)

                'reresh current panel
                General.MainExplorer.RefreshPanel()

                'reload the listview
                SourceDropdown_SelectedIndexChanged(Nothing, Nothing)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the close button
    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            'save the column layout
            RpgxListView.SaveColumnLayout()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'colors the list view correctly when its first initialised
    Private Sub SpellListForm_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Try
            RpgxListView.ColorListview()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add spells from the selected source to the listview
    Private Sub SourceDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceDropdown.SelectedIndexChanged
        Try
            RpgxListView.ClearItems()
            If SourceDropdown.SelectedIndex < 0 Then Exit Sub

            'get any known spells from this source
            Dim SourceKey As Objects.ObjectKey = CType(SourceDropdown.SelectedItem, DataListItem).ObjectGUID
            Dim CurrentSpells As Objects.ObjectDataCollection = CType(KnownSpells.Item(SourceKey), Objects.ObjectDataCollection)
            If CurrentSpells Is Nothing Then CurrentSpells = New Objects.ObjectDataCollection

            'get the spells
            Dim SpellsTable As ObjectHashtable = Rules.SpellList.SpellListInfo(SourceKey)

            'gererate the object list
            Dim TempObject As Objects.ObjectData
            Dim ObjectList As New Objects.ObjectDataCollection
            For Each SpellInfo As Rules.SpellList.SpellInfo In SpellsTable.Values
                If Not CurrentSpells.Contains(SpellInfo.SpellObject.ObjectGUID) Then
                    TempObject = Rules.SpellList.GenerateSpellListItem(SpellInfo, ClassSpellFolder.ObjectGUID)
                    ObjectList.Add(TempObject)
                End If
            Next

            RpgxListView.AddRange(ObjectList, True)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

