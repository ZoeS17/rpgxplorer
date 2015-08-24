Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class MonsterClassForm
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
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents ClassTabControl As System.Windows.Forms.TabControl
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents ClassTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SkillPoints As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents HitDice As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DisplayName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ClassTabControl = New System.Windows.Forms.TabControl
        Me.ClassTab = New System.Windows.Forms.TabPage
        Me.DisplayName = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.SkillPoints = New DevExpress.XtraEditors.SpinEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.HitDice = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.TypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ClassTabControl.SuspendLayout()
        Me.ClassTab.SuspendLayout()
        CType(Me.DisplayName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkillPoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitDice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassTabControl
        '
        Me.ClassTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassTabControl.Controls.Add(Me.ClassTab)
        Me.ClassTabControl.Controls.Add(Me.TabPage3)
        Me.ClassTabControl.Location = New System.Drawing.Point(15, 15)
        Me.ClassTabControl.Name = "ClassTabControl"
        Me.ClassTabControl.SelectedIndex = 0
        Me.ClassTabControl.Size = New System.Drawing.Size(415, 375)
        Me.ClassTabControl.TabIndex = 0
        '
        'ClassTab
        '
        Me.ClassTab.Controls.Add(Me.DisplayName)
        Me.ClassTab.Controls.Add(Me.Label4)
        Me.ClassTab.Controls.Add(Me.SkillPoints)
        Me.ClassTab.Controls.Add(Me.Label3)
        Me.ClassTab.Controls.Add(Me.HitDice)
        Me.ClassTab.Controls.Add(Me.Label11)
        Me.ClassTab.Controls.Add(Me.TypeDropdown)
        Me.ClassTab.Controls.Add(Me.Label1)
        Me.ClassTab.Controls.Add(Me.ObjectName)
        Me.ClassTab.Controls.Add(Me.Label2)
        Me.ClassTab.Location = New System.Drawing.Point(4, 22)
        Me.ClassTab.Name = "ClassTab"
        Me.ClassTab.Size = New System.Drawing.Size(407, 349)
        Me.ClassTab.TabIndex = 0
        Me.ClassTab.Text = "Class"
        '
        'DisplayName
        '
        Me.DisplayName.Location = New System.Drawing.Point(95, 45)
        Me.DisplayName.Name = "DisplayName"
        Me.DisplayName.Properties.AutoHeight = False
        Me.DisplayName.Properties.MaxLength = 100
        Me.DisplayName.Size = New System.Drawing.Size(200, 21)
        Me.DisplayName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Display Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkillPoints
        '
        Me.SkillPoints.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SkillPoints.Location = New System.Drawing.Point(130, 105)
        Me.SkillPoints.Name = "SkillPoints"
        Me.SkillPoints.Properties.Appearance.Options.UseTextOptions = True
        Me.SkillPoints.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SkillPoints.Properties.AutoHeight = False
        Me.SkillPoints.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SkillPoints.Properties.IsFloatValue = False
        Me.SkillPoints.Properties.Mask.BeepOnError = True
        Me.SkillPoints.Properties.Mask.EditMask = "d"
        Me.SkillPoints.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SkillPoints.Properties.Mask.ShowPlaceHolders = False
        Me.SkillPoints.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SkillPoints.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SkillPoints.Size = New System.Drawing.Size(50, 21)
        Me.SkillPoints.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Hit Dice"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HitDice
        '
        Me.HitDice.Location = New System.Drawing.Point(130, 135)
        Me.HitDice.Name = "HitDice"
        Me.HitDice.Properties.AutoHeight = False
        Me.HitDice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HitDice.Properties.DropDownRows = 10
        Me.HitDice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.HitDice.Size = New System.Drawing.Size(50, 21)
        Me.HitDice.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 21)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "Skill Points per HD"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TypeDropdown
        '
        Me.TypeDropdown.EditValue = ""
        Me.TypeDropdown.Location = New System.Drawing.Point(95, 75)
        Me.TypeDropdown.Name = "TypeDropdown"
        Me.TypeDropdown.Properties.AutoHeight = False
        Me.TypeDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeDropdown.Properties.DropDownRows = 10
        Me.TypeDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TypeDropdown.Size = New System.Drawing.Size(150, 21)
        Me.TypeDropdown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(95, 15)
        Me.ObjectName.Name = "ObjectName"
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PropertiesTab)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(407, 349)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 349)
        Me.PropertiesTab.TabIndex = 1
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 405)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 405)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'MonsterClassForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.ClassTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MonsterClassForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CompanionClass"
        Me.ClassTabControl.ResumeLayout(False)
        Me.ClassTab.ResumeLayout(False)
        CType(Me.DisplayName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkillPoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitDice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()
        Try

            'load the typedropdown
            TypeDropdown.Properties.Items.AddRange(RPGXplorer.Rules.Lists.MonsterClassTypes)
            PropertiesTab.Init(mObject, mMode)

            'remove the small dice
            Dim DiceArray(Rules.Dice.DiceTypes.GetUpperBound(0) - 2) As String
            Array.Copy(Rules.Dice.DiceTypes, 2, DiceArray, 0, Rules.Dice.DiceTypes.Length - 2)

            HitDice.Properties.Items.AddRange(DiceArray)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init new object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MonsterClasses)
            mObject.Type = Objects.MonsterClassType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Monster Class"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Monster Class"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            DisplayName.Text = mObject.Element("Abbreviation")
            TypeDropdown.Text = mObject.Element("ClassType")
            SkillPoints.Text = Obj.Element("SkillPointsPerLevel")
            HitDice.Text = Obj.Element("HitDice")

            ObjectName.Text = Obj.Name

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Folder As New Objects.ObjectData
        Dim ClearBonusHitpoints As Boolean = False

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                mObject.Name = ObjectName.Text

                Select Case mMode
                    Case FormMode.Add
                        'create the class levels folder
                        Folder.Name = "Levels"
                        Folder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MonsterClasses)
                        Folder.Type = Objects.MonsterClassLevelsFolderType
                        Folder.ParentGUID = mObject.ObjectGUID
                        Folder.Save()

                    Case FormMode.Edit
                        If mObject.ChildrenOfType(Objects.MonsterClassLevelsFolderType).Count = 0 Then
                            Folder.Name = "Levels"
                            Folder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MonsterClasses)
                            Folder.Type = Objects.MonsterClassLevelsFolderType
                            Folder.ParentGUID = mObject.ObjectGUID
                            Folder.Save()
                        Else
                            Folder = mObject.FirstChildOfType(Objects.MonsterClassLevelsFolderType)
                        End If

                        Select Case mObject.Element("ClassType")
                            Case "Animal Companion", "Special Mount"
                                Select Case TypeDropdown.Text
                                    Case "Familiar", "Monster Type"
                                        ClearBonusHitpoints = True
                                End Select
                        End Select

                        mObject.ClearElements()
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                End Select

                'save
                mObject.Element("Abbreviation") = DisplayName.Text
                mObject.Element("ClassType") = TypeDropdown.Text
                mObject.Element("SkillPointsPerLevel") = SkillPoints.Text
                mObject.Element("HitDice") = HitDice.Text

                'clear hit point elements from any existing class levels
                If ClearBonusHitpoints Then
                    Dim ClassLevels As Objects.ObjectDataCollection = mObject.FirstChildOfType(Objects.MonsterClassLevelsFolderType).ChildrenOfType(Objects.MonsterClassLevelType)
                    If ClassLevels.Count > 0 Then
                        For Each TempClassLevel As Objects.ObjectData In ClassLevels
                            TempClassLevel.Element("HitDice") = ""
                        Next
                    End If
                End If

                mObject = PropertiesTab.UpdateObject(mObject)
                mObject.Save()

                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    Caches.RemoveCharacterClass(mObject.ObjectGUID)
                    General.MainExplorer.TreeView.BeginUpdate()

                    Dim CurrentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ObjectGUID), TreeNode)
                    If Not CurrentNode Is Nothing Then CurrentNode.Remove()
                    Dim ParentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode)
                    Dim NewNode As TreeNode = General.MainExplorer.CompleteNodeFromObject(mObject)
                    General.MainExplorer.InsertNode(ParentNode, NewNode)

                    General.MainExplorer.TreeView.EndUpdate()
                End If

                'refresh explorer and close
                WindowManager.SetDirty(mObject.Parent)
                WindowManager.RefreshTreeNodes()
                WindowManager.RefreshTabNames()
                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)

                Me.DialogResult = DialogResult.OK : Me.Close()

                'begin
                If mMode = FormMode.Add Then
                    Commands.CreateClassLevels(Folder)
                End If

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
    End Sub

    'show
    Public Shadows Sub Show()
        Try
            MyBase.Show()
            If Commands.EditForm Is Nothing Then
                Commands.EditForm = Me
            Else
                OK.Enabled = False : Me.Text = Me.Text.Replace("Edit", "View") : Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_green.ico")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If Commands.EditForm Is Me Then
                Commands.EditForm = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'map "Yes" to "Spellcaster" for pre-psionic backwards compatibility
    Private Function CasterString(ByVal Input As String) As String
        Try
            Select Case Input

                Case "Yes"
                    Return "Spellcaster"
                Case "Spellcaster"
                    Return "Yes"

                Case ""
                    Return "No"

                Case Else
                    Return Input

            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.ClassTab.Controls, Errors)
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

    ''handles the type dropdown being changed
    Private Sub TypeDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeDropdown.SelectedIndexChanged
        If TypeDropdown.SelectedIndex <> -1 Then

            If TypeDropdown.Text = "Familiar" Then
                SkillPoints.Value = 0
                HitDice.SelectedIndex = -1
                SkillPoints.Enabled = False
                HitDice.Enabled = False
            Else
                If SkillPoints.Value = 0 Then SkillPoints.Value = 1
                SkillPoints.Enabled = True
                HitDice.Enabled = True
            End If

        End If
    End Sub

End Class


