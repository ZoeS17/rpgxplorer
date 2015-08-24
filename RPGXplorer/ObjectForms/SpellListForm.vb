Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class SpellListForm
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
    Public WithEvents CurrentLabel As System.Windows.Forms.Label
    Public WithEvents Level As DevExpress.XtraEditors.SpinEdit
    Public WithEvents FilterBar As RPGXplorer.FilterBar
    Public WithEvents RpgxListView As RPGXplorer.RPGXListView
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents CloseButton As System.Windows.Forms.Button
    Public WithEvents AddSpellsButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button
        Me.AddSpellsButton = New System.Windows.Forms.Button
        Me.CurrentLabel = New System.Windows.Forms.Label
        Me.Level = New DevExpress.XtraEditors.SpinEdit
        Me.FilterBar = New RPGXplorer.FilterBar
        Me.RpgxListView = New RPGXplorer.RPGXListView
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CurrentLabel
        '
        Me.CurrentLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrentLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CurrentLabel.Location = New System.Drawing.Point(20, 430)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(135, 21)
        Me.CurrentLabel.TabIndex = 131
        Me.CurrentLabel.Text = "Add to Spell List as Level"
        Me.CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Level
        '
        Me.Level.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Level.CausesValidation = False
        Me.Level.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Level.Location = New System.Drawing.Point(155, 430)
        Me.Level.Name = "Level"
        '
        'Level.Properties
        '
        Me.Level.Properties.Appearance.Options.UseTextOptions = True
        Me.Level.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level.Properties.AutoHeight = False
        Me.Level.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level.Properties.IsFloatValue = False
        Me.Level.Properties.Mask.BeepOnError = True
        Me.Level.Properties.Mask.EditMask = "d"
        Me.Level.Properties.Mask.ShowPlaceHolders = False
        Me.Level.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.Level.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Level.Size = New System.Drawing.Size(55, 21)
        Me.Level.TabIndex = 133
        '
        'FilterBar
        '
        Me.FilterBar.Location = New System.Drawing.Point(15, 15)
        Me.FilterBar.Name = "FilterBar"
        Me.FilterBar.Size = New System.Drawing.Size(535, 25)
        Me.FilterBar.TabIndex = 138
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(215, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 21)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Spell"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellListForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 471)
        Me.Controls.Add(Me.RpgxListView)
        Me.Controls.Add(Me.FilterBar)
        Me.Controls.Add(Me.AddSpellsButton)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.CurrentLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "SpellListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Spells"
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private SpellDefinitionsFolder As Objects.ObjectData
    Private SpellListFolder As Objects.ObjectData
    Private BaseSpells As Objects.ObjectDataCollection
    Private CurrentSpells As Objects.ObjectDataCollection
    Private SpellListFormKey As New Objects.ObjectKey("001-cb694cf7-9709-463f-b763-52e080a48da5")

#End Region

    'init
    Public Sub Init(ByVal SpellListFolder As Objects.ObjectData)
        Try
            'init form
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            'ini form vars
            Me.SpellListFolder = SpellListFolder
            SpellDefinitionsFolder = Objects.GetObjectByXPath(Xml.DBTypes.Folders, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.SpellDefinitionFolderType & "']")
            If SpellDefinitionsFolder.IsEmpty Then Throw New Exception("Cannot find Spell Definition Folder")

            'get the current spells
            Select Case SpellListFolder.Type
                Case Objects.SpellListFolderType
                    'need to filter out the spells from the current spell list
                    CurrentSpells = Rules.SpellList.GetSpellDefinitions(SpellListFolder.Parent.ObjectGUID)

                Case Objects.ClassSpellListFolderType
                    'get the class key for this folder
                    Dim ClassKey As Objects.ObjectKey = SpellListFolder.GetFKGuid("Class")
                    CurrentSpells = New Objects.ObjectDataCollection
                    'need to get all the spell definitions that have <class> as their source
                    For Each SpellTaken As Objects.ObjectData In SpellListFolder.Children
                        If SpellTaken.GetFKGuid("Source").Equals(ClassKey) Then
                            CurrentSpells.Add(Rules.SpellList.SpellDefinition(SpellTaken.GetFKGuid("Spell")))
                        End If
                    Next
            End Select

            'get the base spells
            BaseSpells = New Objects.ObjectDataCollection
            For Each Spell As Objects.ObjectData In Caches.Spells.Values
                If Not CurrentSpells.Contains(Spell.ObjectGUID) Then
                    BaseSpells.Add(Spell)
                End If
            Next

            'init controls
            RpgxListView.Init(SpellListFormKey, Objects.SpellDefinitionFolderType, SortType.Alphabetic)
            FilterBar.Init(SpellDefinitionsFolder, BaseSpells)

            'populate listview
            RpgxListView.AddRange(FilterBar.FilteredObjects)

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

            General.MainExplorer.Undo.UndoRecord()

            Select Case SpellListFolder.Type
                Case Objects.SpellListFolderType
                    'create spell levels
                    Rules.SpellList.CreateSpellLevels(SpellListFolder.Parent, SelectedObjects, CInt(Level.Value))

                Case Objects.ClassSpellListFolderType
                    'create the new spell taken objects
                    Dim CharKey As Objects.ObjectKey = SpellListFolder.GetCharacterKey()
                    If CharKey.IsNotEmpty Then
                        Dim Character As Rules.Character = CharacterManager.GetCharacter(CharKey)
                        For Each SpellDefinition As Objects.ObjectData In SelectedObjects
                            Character.Spells.TakeSpell(SpellDefinition.ObjectGUID, SpellDefinition.Name, SpellListFolder.GetFKGuid("Class"), SpellListFolder.Element("Class"), SpellListFolder.GetFKGuid("Class"), SpellListFolder.Element("Class"), CInt(Level.Value), Character.CharacterLevel)
                        Next
                        Character.Spells.Save()
                        CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
                    Else
                        Exit Sub
                    End If
            End Select

            'update BaseSpells
            BaseSpells.RemoveList(SelectedObjects)

            'refresh the list view
            FilterBar.BaseObjects = BaseSpells

            'reresh current panel
            General.MainExplorer.RefreshPanel()

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

    'handles the filter being changed
    Private Sub FilterBar_FilterChanged() Handles FilterBar.FilterChanged
        Try
            'populate listview
            RpgxListView.ClearItems()
            RpgxListView.AddRange(FilterBar.FilteredObjects)
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
End Class

