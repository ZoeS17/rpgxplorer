Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CharacterLanguageForm
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
	Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents ThreatRangeLabel As System.Windows.Forms.Label
    Public WithEvents Level As DevExpress.XtraEditors.SpinEdit
    Public WithEvents LanguageDropdown As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label7 = New System.Windows.Forms.Label
        Me.ThreatRangeLabel = New System.Windows.Forms.Label
        Me.LanguageDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Level = New DevExpress.XtraEditors.SpinEdit
        CType(Me.LanguageDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(135, 95)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 288
        Me.OK.Text = "OK"
		'
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(215, 95)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 289
        Me.Cancel.Text = "Cancel"
		'
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(270, 5)
        Me.IndentedLine2.TabIndex = 290
        Me.IndentedLine2.TabStop = False
		'
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 294
        Me.Label7.Text = "Language"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'ThreatRangeLabel
        '
        Me.ThreatRangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ThreatRangeLabel.Location = New System.Drawing.Point(15, 15)
        Me.ThreatRangeLabel.Name = "ThreatRangeLabel"
        Me.ThreatRangeLabel.Size = New System.Drawing.Size(70, 21)
        Me.ThreatRangeLabel.TabIndex = 293
        Me.ThreatRangeLabel.Text = "Level"
        Me.ThreatRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'LanguageDropdown
        '
        Me.LanguageDropdown.CausesValidation = False
        Me.LanguageDropdown.Location = New System.Drawing.Point(85, 45)
        Me.LanguageDropdown.Name = "LanguageDropdown"
        '
        'LanguageDropdown.Properties
        '
        Me.LanguageDropdown.Properties.AutoHeight = False
        Me.LanguageDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LanguageDropdown.Properties.DropDownRows = 10
        Me.LanguageDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.LanguageDropdown.Size = New System.Drawing.Size(200, 21)
        Me.LanguageDropdown.TabIndex = 291
        '
        'Level
        '
        Me.Level.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Level.Location = New System.Drawing.Point(85, 15)
        Me.Level.Name = "Level"
        '
        'Level.Properties
        '
        Me.Level.Properties.Appearance.Options.UseTextOptions = True
        Me.Level.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level.Properties.AutoHeight = False
        Me.Level.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level.Properties.IsFloatValue = False
        Me.Level.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Level.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Level.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Level.Size = New System.Drawing.Size(50, 21)
        Me.Level.TabIndex = 292
        '
        'CharacterLanguageForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(299, 133)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LanguageDropdown)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.ThreatRangeLabel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterLanguageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CharacterLanguageForm"
        CType(Me.LanguageDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Vairables"

    Private Character As Rules.Character
    Private mMode As FormMode
    Private mFolder As Objects.ObjectData

    Private LanguageDataList As DataListItem()

    Private EditLanguage As Objects.ObjectData
    Private SelectedLanguage As Rules.Character.Language

#End Region

    'init for adding a language
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean

        'init form vars
        mMode = FormMode.Add

        'init form
        Me.Text = "Add Language"
        Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

        'get the character
        Character = CharacterManager.CurrentCharacter.Clone()

        Init()

        Return True
    End Function

    'init for editng a language
    Public Sub InitEdit(ByVal ExistingLanguage As Objects.ObjectData)

        'init form vars
        mMode = FormMode.Edit
        EditLanguage = ExistingLanguage

        'init form
        Me.Text = "Edit Language"
        Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")

        'get the character - get the character from the panel (in case locked window)
        Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey).Clone()

        Init()

        Level.EditValue = ExistingLanguage.ElementAsInteger("LevelAcquired")
        LanguageDropdown.SelectedIndex = Rules.Index.GetGuidIndex(LanguageDataList, EditLanguage.GetFKGuid("Language"))

    End Sub

    'init
    Private Sub Init()
        Dim Languages As Objects.ObjectDataCollection

        mFolder = Character.CharacterObject.FirstChildOfType(Objects.LanguageFolderType)
        Languages = Objects.GetAllObjectsOfType(XML.DBTypes.Languages, Objects.LanguageDefinitionType)

        'init Controls
        Level.Properties.MinValue = 1
        Level.Properties.MaxValue = Character.CharacterLevel

        'build exclusions
        Dim Exclusions As New ArrayList
        For Each Obj As Objects.ObjectData In mFolder.Children
            Exclusions.Add(Obj.GetFKGuid("Language"))
        Next

        'remove edit if required
        If mMode = FormMode.Edit Then
            Exclusions.Remove(EditLanguage.GetFKGuid("Language"))
        End If

        LanguageDataList = Rules.Index.DataListExclude(Languages, Exclusions)
        LanguageDropdown.Properties.Items.AddRange(LanguageDataList)

    End Sub

#Region "Event Handlers"

    'handles the ok button
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim LanguageObject As Objects.ObjectData

        General.MainExplorer.Undo.UndoRecord()

        'If an existing language has been changed, then delete the object from the character
        If mMode = FormMode.Edit Then
            If Not (SelectedLanguage.LanguageGuid.Equals(EditLanguage.GetFKGuid("Language")) And SelectedLanguage.LevelGained = EditLanguage.ElementAsInteger("LevelAcquired")) Then
                EditLanguage.Delete()
            Else
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Exit Sub
            End If
        End If

        'Write language to db
        LanguageObject = SelectedLanguage.CreateObject(Character)
        LanguageObject.Save()

        'Update the cached character
        CharacterManager.UpdateCharacter(Character)

        General.MainExplorer.RefreshPanel()
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    'handles the cancel button
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'updates the current languge with the new one selected
    Private Sub LanguageDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageDropdown.SelectedIndexChanged
        SelectedLanguage.LevelGained = CInt(Level.Value)
        SelectedLanguage.LanguageName = LanguageDropdown.Text
        SelectedLanguage.LanguageGuid = LanguageDataList(LanguageDropdown.SelectedIndex).ObjectGUID
    End Sub

    'updates the current language with the new level selected
    Private Sub Level_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level.EditValueChanged
        SelectedLanguage.LevelGained = CInt(Level.Value)
    End Sub

#End Region

End Class