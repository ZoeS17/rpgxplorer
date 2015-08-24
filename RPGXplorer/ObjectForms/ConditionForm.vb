Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules.Conditions

Public Class ConditionForm
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
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ConditionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TargetList As RPGXplorer.ListBox
    Public WithEvents TargetLabel As System.Windows.Forms.Label
    Public WithEvents TargetBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents AddButton As System.Windows.Forms.Button
    Public WithEvents RemoveButton As System.Windows.Forms.Button
    Public WithEvents ConditionTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ConditionTab = New System.Windows.Forms.TabPage
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.ConditionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.TargetList = New RPGXplorer.ListBox
        Me.TargetLabel = New System.Windows.Forms.Label
        Me.TargetBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.AddButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ConditionTab.SuspendLayout()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
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
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 405)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ConditionTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ConditionTab
        '
        Me.ConditionTab.Controls.Add(Me.ObjectName)
        Me.ConditionTab.Controls.Add(Me.Label2)
        Me.ConditionTab.Controls.Add(Me.IndentedLine1)
        Me.ConditionTab.Controls.Add(Me.ConditionDropdown)
        Me.ConditionTab.Controls.Add(Me.Label1)
        Me.ConditionTab.Controls.Add(Me.TargetList)
        Me.ConditionTab.Controls.Add(Me.TargetLabel)
        Me.ConditionTab.Controls.Add(Me.TargetBox)
        Me.ConditionTab.Controls.Add(Me.AddButton)
        Me.ConditionTab.Controls.Add(Me.RemoveButton)
        Me.ConditionTab.Location = New System.Drawing.Point(4, 22)
        Me.ConditionTab.Name = "ConditionTab"
        Me.ConditionTab.Size = New System.Drawing.Size(407, 349)
        Me.ConditionTab.TabIndex = 0
        Me.ConditionTab.Text = "Condition"
        '
        'ObjectName
        '
        Me.ObjectName.Enabled = False
        Me.ObjectName.Location = New System.Drawing.Point(75, 45)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 177
        Me.IndentedLine1.TabStop = False
        '
        'ConditionDropdown
        '
        Me.ConditionDropdown.EditValue = ""
        Me.ConditionDropdown.Location = New System.Drawing.Point(75, 15)
        Me.ConditionDropdown.Name = "ConditionDropdown"
        '
        'ConditionDropdown.Properties
        '
        Me.ConditionDropdown.Properties.AutoHeight = False
        Me.ConditionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConditionDropdown.Properties.DropDownRows = 10
        Me.ConditionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ConditionDropdown.Size = New System.Drawing.Size(200, 21)
        Me.ConditionDropdown.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Condition"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetList
        '
        Me.TargetList.Enabled = False
        Me.TargetList.Location = New System.Drawing.Point(75, 125)
        Me.TargetList.Name = "TargetList"
        Me.TargetList.Size = New System.Drawing.Size(200, 210)
        Me.TargetList.TabIndex = 5
        '
        'TargetLabel
        '
        Me.TargetLabel.Location = New System.Drawing.Point(15, 95)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(60, 21)
        Me.TargetLabel.TabIndex = 174
        Me.TargetLabel.Text = "Matches"
        Me.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetBox
        '
        Me.TargetBox.CausesValidation = False
        Me.TargetBox.Enabled = False
        Me.TargetBox.Location = New System.Drawing.Point(75, 95)
        Me.TargetBox.Name = "TargetBox"
        '
        'TargetBox.Properties
        '
        Me.TargetBox.Properties.AutoHeight = False
        Me.TargetBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TargetBox.Properties.DropDownRows = 10
        Me.TargetBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TargetBox.Size = New System.Drawing.Size(200, 21)
        Me.TargetBox.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(290, 95)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 24)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add"
        '
        'RemoveButton
        '
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.Location = New System.Drawing.Point(290, 125)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(100, 24)
        Me.RemoveButton.TabIndex = 4
        Me.RemoveButton.Text = "Remove"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Enabled = False
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'ConditionForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ConditionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condition"
        Me.TabControl1.ResumeLayout(False)
        Me.ConditionTab.ResumeLayout(False)
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private TargetIndex As Rules.Index.IndexEntry()

    Private Current As New Objects.ObjectDataCollection
    Private Existing As New Objects.ObjectDataCollection

    Private ConditionTarget As String

    'init
    Public Sub Init()
        Dim Parent As Objects.ObjectData
        Dim ConditionTypes As ArrayList

        Try
            'populate ComboBoxEditors
            Parent = mObject.Parent
            ConditionTypes = New ArrayList(Rules.Conditions.ConditionTypes)
            For Each Condition As Objects.ObjectData In Parent.ChildrenOfType(Objects.ConditionType)
                If Condition.Element("Condition") = Rules.Conditions.Bane Then
                    If Not Condition.ObjectGUID.Equals(mObject.ObjectGUID) Then
                        ConditionTypes.Remove(Rules.Conditions.Bane)
                    End If
                    Exit For
                End If
            Next

            ConditionDropdown.Properties.Items.AddRange(ConditionTypes.ToArray)
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

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.ConditionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Condition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim child As Objects.ObjectData
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Condition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init Controls
            ConditionTarget = mObject.Element("ConditionTarget")
            ConditionDropdown.SelectedItem = mObject.Element("Condition")
            ObjectName.Text = mObject.Name

            Existing = mObject.ChildrenOfType(Objects.ConditionMemberType)
            For Each child In Existing
                TargetList.AddItem(child.Name, child.ObjectGUID)
                Current.Add(child)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As Objects.ObjectData
        Dim OutputString As String = ""
        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        'do nothing yet
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("Condition") = ConditionDropdown.Text
                mObject.Element("ConditionTarget") = ConditionTarget

                For Each Obj In Existing
                    If Not Current.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                For Each Obj In Current
                    If Existing.Contains(Obj.ObjectGUID) Then
                        Current.Remove(Obj.ObjectGUID)
                    End If
                Next
                Current.Save()

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                'General.MainExplorer.Refresh()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.RefreshRenamedNode(mObject.ObjectGUID, mObject.Name)
                End If

                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)
                Me.DialogResult = DialogResult.OK : Me.Close()

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

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.ConditionTab.Controls, Errors)

            If TargetList.Enabled And TargetList.Count = 0 Then
                Errors.SetError(TargetList, General.ValidationAtLeast1Required)
                Validate = False
            Else
                Errors.SetError(TargetList, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Tab Code"

    'Add Item to Target List
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim Obj As Objects.ObjectData
        Dim [Continue] As Boolean = True

        Try
            If TargetBox.SelectedIndex = -1 Then Exit Sub

            If ConditionTarget = "Alignment" Or ConditionTarget = "Subtype" Then
                If Current.Contains(TargetBox.Text) Then
                    General.ShowInfoDialog("This item is already in the list.")
                    [Continue] = False
                End If
            Else
                If Current.ContainsFK(ConditionTarget, TargetIndex(TargetBox.SelectedIndex).ObjectGUID) Then
                    General.ShowInfoDialog("This item is already in the list.")
                    [Continue] = False
                End If
            End If

            If [Continue] Then
                If ConditionTarget = "Alignment" Or ConditionTarget = "Subtype" Then
                    Obj = Existing.Item(TargetBox.Text)
                Else
                    Obj = Existing.Item(ConditionTarget, TargetIndex(TargetBox.SelectedIndex).ObjectGUID)
                End If

                If Obj.IsEmpty Then
                    Obj.Name = TargetBox.Text
                    Obj.Type = Objects.ConditionMemberType
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                    Obj.ParentGUID = mObject.ObjectGUID
                    If ConditionTarget <> "Alignment" And ConditionTarget <> "Subtype" Then
                        Obj.FKElement(ConditionTarget, TargetBox.Text, "Name", TargetIndex(TargetBox.SelectedIndex).ObjectGUID)
                    End If
                End If

                TargetList.AddItem(Obj.Name, Obj.ObjectGUID)
                Current.Add(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Remove Item from Target List
    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Try
            If TargetList.SelectedIndex = -1 Then Exit Sub
            Current.Remove(TargetList.ItemGUID)
            TargetList.RemoveSelectedItem()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

    'Enable Radios and load Target ComboEditBox with appropriate items
    Private Sub ConditionDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConditionDropdown.SelectedIndexChanged
        Try
            If ConditionDropdown.Text <> "" Then

                TargetBox.Properties.Items.Clear()
                TargetBox.SelectedIndex = -1
                Current.Clear()
                TargetList.Clear()
                ObjectName.Enabled = True
                ObjectName.Text = ""

                Select Case ConditionDropdown.SelectedItem.ToString
                    Case Bane
                        EnableDisableList(False)
                    Case ByClass
                        EnableDisableList(True)
                        TargetIndex = Rules.Index.Index(XML.DBTypes.Classes, Objects.ClassType)
                        TargetBox.Properties.Items.AddRange(Rules.Index.IndexNames(TargetIndex))
                        ConditionTarget = "Class"
                    Case ByRace
                        EnableDisableList(True)
                        TargetIndex = Rules.Index.Index(XML.DBTypes.Races, Objects.RaceType)
                        TargetBox.Properties.Items.AddRange(Rules.Index.IndexNames(TargetIndex))
                        ConditionTarget = "Race"
                    Case AgainstAlignment
                        EnableDisableList(True)
                        TargetBox.Properties.Items.AddRange(Rules.Lists.AlignmentTypes)
                        ConditionTarget = "Alignment"
                    Case AgainstType
                        EnableDisableList(True)
                        TargetIndex = Rules.Index.Index(XML.DBTypes.MonsterTypes, Objects.MonsterTypeType)
                        TargetBox.Properties.Items.AddRange(Rules.Index.IndexNames(TargetIndex))
                        ConditionTarget = "MonsterType"
                    Case FeatRequired
                        EnableDisableList(True)
                        TargetIndex = Rules.Index.Index(XML.DBTypes.Feats, Objects.FeatDefinitionType)
                        TargetBox.Properties.Items.AddRange(Rules.Index.IndexNames(TargetIndex))
                        ConditionTarget = "Feat"
                    Case AgainstSubtype
                        EnableDisableList(True)
                        TargetBox.Properties.Items.AddRange(Rules.Lists.MonsterSubtypes)
                        ConditionTarget = "Subtype"
                    Case NotCritImmune
                        ObjectName.Enabled = False
                        ObjectName.Text = ConditionDropdown.Text
                        EnableDisableList(False)
                    Case UserDefined
                        EnableDisableList(False)
                End Select

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable controls for list
    Private Sub EnableDisableList(ByVal Value As Boolean)
        Try
            TargetLabel.Enabled = Value
            TargetBox.Properties.Enabled = Value
            AddButton.Enabled = Value
            RemoveButton.Enabled = Value
            TargetList.Enabled = Value
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
