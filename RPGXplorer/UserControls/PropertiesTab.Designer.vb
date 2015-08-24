<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ChooseFile = New System.Windows.Forms.Button
        Me.HelpPage = New DevExpress.XtraEditors.TextEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ChooseImage = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DeletePage = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.EditTags = New System.Windows.Forms.Button
        Me.Clear = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ImageFilename = New DevExpress.XtraEditors.TextEdit
        Me.UniqueID = New DevExpress.XtraEditors.TextEdit
        Me.ObjName = New DevExpress.XtraEditors.TextEdit
        Me.Type = New DevExpress.XtraEditors.TextEdit
        Me.License = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Sourcebook = New DevExpress.XtraEditors.ComboBoxEdit
        Me.UserTags = New DevExpress.XtraEditors.TextEdit
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PageNoRef = New DevExpress.XtraEditors.TextEdit
        CType(Me.HelpPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniqueID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.License.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sourcebook.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTags.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChooseFile
        '
        Me.ChooseFile.Location = New System.Drawing.Point(310, 265)
        Me.ChooseFile.Name = "ChooseFile"
        Me.ChooseFile.Size = New System.Drawing.Size(23, 21)
        Me.ChooseFile.TabIndex = 4
        Me.ChooseFile.Text = "..."
        '
        'HelpPage
        '
        Me.HelpPage.Location = New System.Drawing.Point(105, 265)
        Me.HelpPage.Name = "HelpPage"
        Me.HelpPage.Properties.AutoHeight = False
        Me.HelpPage.Properties.MaxLength = 1000
        Me.HelpPage.Properties.ReadOnly = True
        Me.HelpPage.Size = New System.Drawing.Size(200, 21)
        Me.HelpPage.TabIndex = 5
        Me.HelpPage.TabStop = False
        '
        'ChooseImage
        '
        Me.ChooseImage.Location = New System.Drawing.Point(310, 295)
        Me.ChooseImage.Name = "ChooseImage"
        Me.ChooseImage.Size = New System.Drawing.Size(23, 21)
        Me.ChooseImage.TabIndex = 7
        Me.ChooseImage.Text = "..."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Image Filename"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 140
        Me.IndentedLine1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Unique ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 21)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "Rule/Help Page"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(15, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 21)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeletePage
        '
        Me.DeletePage.Image = Global.RPGXplorer.My.Resources.Resources.document_delete
        Me.DeletePage.Location = New System.Drawing.Point(340, 265)
        Me.DeletePage.Name = "DeletePage"
        Me.DeletePage.Size = New System.Drawing.Size(25, 21)
        Me.DeletePage.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DeletePage, "Delete this rule page. Confirmation required.")
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 250)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 140
        Me.IndentedLine2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "License"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Sourcebook"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Tags"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EditTags
        '
        Me.EditTags.Location = New System.Drawing.Point(335, 185)
        Me.EditTags.Name = "EditTags"
        Me.EditTags.Size = New System.Drawing.Size(23, 21)
        Me.EditTags.TabIndex = 2
        Me.EditTags.Text = "..."
        '
        'Clear
        '
        Me.Clear.Image = Global.RPGXplorer.My.Resources.Resources.document_new
        Me.Clear.Location = New System.Drawing.Point(370, 265)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(25, 21)
        Me.Clear.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Clear, "Create default rule page if one does not already exist.")
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Page No./Ref"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageFilename
        '
        Me.ImageFilename.Location = New System.Drawing.Point(105, 295)
        Me.ImageFilename.Name = "ImageFilename"
        Me.ImageFilename.Properties.AutoHeight = False
        Me.ImageFilename.Properties.MaxLength = 50
        Me.ImageFilename.Properties.ReadOnly = True
        Me.ImageFilename.Size = New System.Drawing.Size(200, 21)
        Me.ImageFilename.TabIndex = 9
        Me.ImageFilename.TabStop = False
        '
        'UniqueID
        '
        Me.UniqueID.CausesValidation = False
        Me.UniqueID.Location = New System.Drawing.Point(105, 75)
        Me.UniqueID.Name = "UniqueID"
        Me.UniqueID.Properties.AllowFocused = False
        Me.UniqueID.Properties.Appearance.BackColor = System.Drawing.Color.Silver
        Me.UniqueID.Properties.Appearance.Options.UseBackColor = True
        Me.UniqueID.Properties.AutoHeight = False
        Me.UniqueID.Properties.MaxLength = 50
        Me.UniqueID.Properties.ReadOnly = True
        Me.UniqueID.Size = New System.Drawing.Size(225, 21)
        Me.UniqueID.TabIndex = 2
        Me.UniqueID.TabStop = False
        '
        'ObjName
        '
        Me.ObjName.CausesValidation = False
        Me.ObjName.Location = New System.Drawing.Point(105, 15)
        Me.ObjName.Name = "ObjName"
        Me.ObjName.Properties.AllowFocused = False
        Me.ObjName.Properties.Appearance.BackColor = System.Drawing.Color.Silver
        Me.ObjName.Properties.Appearance.Options.UseBackColor = True
        Me.ObjName.Properties.AutoHeight = False
        Me.ObjName.Properties.MaxLength = 1000
        Me.ObjName.Properties.ReadOnly = True
        Me.ObjName.Size = New System.Drawing.Size(225, 21)
        Me.ObjName.TabIndex = 0
        Me.ObjName.TabStop = False
        '
        'Type
        '
        Me.Type.CausesValidation = False
        Me.Type.Location = New System.Drawing.Point(105, 45)
        Me.Type.Name = "Type"
        Me.Type.Properties.AllowFocused = False
        Me.Type.Properties.Appearance.BackColor = System.Drawing.Color.Silver
        Me.Type.Properties.Appearance.Options.UseBackColor = True
        Me.Type.Properties.AutoHeight = False
        Me.Type.Properties.MaxLength = 1000
        Me.Type.Properties.ReadOnly = True
        Me.Type.Size = New System.Drawing.Size(225, 21)
        Me.Type.TabIndex = 1
        Me.Type.TabStop = False
        '
        'License
        '
        Me.License.EditValue = ""
        Me.License.Location = New System.Drawing.Point(105, 125)
        Me.License.Name = "License"
        Me.License.Properties.AutoHeight = False
        Me.License.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.License.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.License.Size = New System.Drawing.Size(225, 21)
        Me.License.TabIndex = 0
        '
        'Sourcebook
        '
        Me.Sourcebook.EditValue = ""
        Me.Sourcebook.Location = New System.Drawing.Point(105, 155)
        Me.Sourcebook.Name = "Sourcebook"
        Me.Sourcebook.Properties.AutoHeight = False
        Me.Sourcebook.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Sourcebook.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Sourcebook.Size = New System.Drawing.Size(225, 21)
        Me.Sourcebook.TabIndex = 1
        '
        'UserTags
        '
        Me.UserTags.CausesValidation = False
        Me.UserTags.Location = New System.Drawing.Point(105, 185)
        Me.UserTags.Name = "UserTags"
        Me.UserTags.Properties.AllowFocused = False
        Me.UserTags.Properties.AutoHeight = False
        Me.UserTags.Properties.MaxLength = 50
        Me.UserTags.Properties.ReadOnly = True
        Me.UserTags.Size = New System.Drawing.Size(225, 21)
        Me.UserTags.TabIndex = 9
        Me.UserTags.TabStop = False
        '
        'PageNoRef
        '
        Me.PageNoRef.CausesValidation = False
        Me.PageNoRef.Location = New System.Drawing.Point(105, 215)
        Me.PageNoRef.Name = "PageNoRef"
        Me.PageNoRef.Properties.AllowFocused = False
        Me.PageNoRef.Properties.AutoHeight = False
        Me.PageNoRef.Properties.MaxLength = 255
        Me.PageNoRef.Size = New System.Drawing.Size(225, 21)
        Me.PageNoRef.TabIndex = 3
        '
        'PropertiesTab
        '
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PageNoRef)
        Me.Controls.Add(Me.UserTags)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.License)
        Me.Controls.Add(Me.DeletePage)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UniqueID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ObjName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChooseImage)
        Me.Controls.Add(Me.ImageFilename)
        Me.Controls.Add(Me.ChooseFile)
        Me.Controls.Add(Me.HelpPage)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sourcebook)
        Me.Controls.Add(Me.EditTags)
        Me.Controls.Add(Me.Clear)
        Me.Name = "PropertiesTab"
        Me.Size = New System.Drawing.Size(405, 370)
        CType(Me.HelpPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniqueID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.License.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sourcebook.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTags.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ChooseFile As System.Windows.Forms.Button
    Public WithEvents HelpPage As DevExpress.XtraEditors.TextEdit
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents ChooseImage As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents UniqueID As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents ObjName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Type As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents ImageFilename As DevExpress.XtraEditors.TextEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents License As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Sourcebook As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents EditTags As System.Windows.Forms.Button
    Public WithEvents UserTags As DevExpress.XtraEditors.TextEdit
    Public WithEvents DeletePage As System.Windows.Forms.Button
    Public WithEvents Clear As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents PageNoRef As DevExpress.XtraEditors.TextEdit

End Class
