Public Class DeleteLevelsForm
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
    Public WithEvents DeleteLevels As System.Windows.Forms.Button
    Public WithEvents EncumLabel As System.Windows.Forms.Label
    Public WithEvents DeleteAllLevels As System.Windows.Forms.Button
    Public WithEvents LevelsSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Cancel As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteLevelsForm))
        Me.LevelsSpin = New DevExpress.XtraEditors.SpinEdit
        Me.DeleteLevels = New System.Windows.Forms.Button
        Me.EncumLabel = New System.Windows.Forms.Label
        Me.DeleteAllLevels = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Cancel = New System.Windows.Forms.Button
        CType(Me.LevelsSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LevelsSpin
        '
        Me.LevelsSpin.CausesValidation = False
        Me.LevelsSpin.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LevelsSpin.Location = New System.Drawing.Point(170, 15)
        Me.LevelsSpin.Name = "LevelsSpin"
        Me.LevelsSpin.Properties.AutoHeight = False
        Me.LevelsSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LevelsSpin.Properties.IsFloatValue = False
        Me.LevelsSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.LevelsSpin.Properties.Mask.ShowPlaceHolders = False
        Me.LevelsSpin.Properties.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LevelsSpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LevelsSpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.LevelsSpin.Size = New System.Drawing.Size(55, 21)
        Me.LevelsSpin.TabIndex = 0
        '
        'DeleteLevels
        '
        Me.DeleteLevels.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteLevels.Location = New System.Drawing.Point(15, 65)
        Me.DeleteLevels.Name = "DeleteLevels"
        Me.DeleteLevels.Size = New System.Drawing.Size(100, 24)
        Me.DeleteLevels.TabIndex = 1
        Me.DeleteLevels.Text = "Delete Levels"
        '
        'EncumLabel
        '
        Me.EncumLabel.Location = New System.Drawing.Point(15, 15)
        Me.EncumLabel.Name = "EncumLabel"
        Me.EncumLabel.Size = New System.Drawing.Size(150, 21)
        Me.EncumLabel.TabIndex = 193
        Me.EncumLabel.Text = "Number of Levels to Delete"
        Me.EncumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeleteAllLevels
        '
        Me.DeleteAllLevels.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteAllLevels.Location = New System.Drawing.Point(125, 65)
        Me.DeleteAllLevels.Name = "DeleteAllLevels"
        Me.DeleteAllLevels.Size = New System.Drawing.Size(100, 24)
        Me.DeleteAllLevels.TabIndex = 2
        Me.DeleteAllLevels.Text = "Delete All Levels"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(330, 5)
        Me.IndentedLine2.TabIndex = 194
        Me.IndentedLine2.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(275, 65)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 195
        Me.Cancel.Text = "Cancel"
        '
        'DeleteLevelsForm
        '
        Me.AcceptButton = Me.DeleteLevels
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(359, 103)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.DeleteAllLevels)
        Me.Controls.Add(Me.EncumLabel)
        Me.Controls.Add(Me.DeleteLevels)
        Me.Controls.Add(Me.LevelsSpin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteLevelsForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Levels"
        CType(Me.LevelsSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Character As New Objects.ObjectData
    Private HighestLevelNumber As Integer
    Private LevelsCollection As Objects.ObjectDataCollection

    Public Sub Init(ByVal CharacterObject As Objects.ObjectData)
        Character = CharacterObject

        LevelsCollection = Character.FirstChildOfType(Objects.CharacterLevelsFolderType).ChildrenOfType(Objects.CharacterLevelType)

        For Each LevelObject As Objects.ObjectData In LevelsCollection
            If LevelObject.ElementAsInteger("CharacterLevel") > HighestLevelNumber Then
                HighestLevelNumber = LevelObject.ElementAsInteger("CharacterLevel")
            End If
        Next

        LevelsSpin.Properties.MaxValue = HighestLevelNumber

    End Sub

    Private Sub DeleteLevels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteLevels.Click
        If General.ShowQuestionDialog("Are you sure?") = DialogResult.No Then Exit Sub
        General.MainExplorer.Undo.UndoRecord()
        Application.DoEvents()
        General.SetWaitCursor()
        Rules.Character.DeleteLevels(Character, LevelsCollection, HighestLevelNumber, CInt(LevelsSpin.Value))
        General.SetNormalCursor()
        CharacterManager.SetDirty(Character.ObjectGUID, CharacterManager.DirtyStatus.Reload)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub DeleteAllLevels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllLevels.Click
        If General.ShowQuestionDialog("Are you sure?") = DialogResult.No Then Exit Sub
        General.MainExplorer.Undo.UndoRecord()
        Application.DoEvents()
        General.SetWaitCursor()
        Rules.Character.DeleteLevels(Character, LevelsCollection, HighestLevelNumber, HighestLevelNumber)
        General.SetNormalCursor()
        CharacterManager.SetDirty(Character.ObjectGUID, CharacterManager.DirtyStatus.Reload)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
