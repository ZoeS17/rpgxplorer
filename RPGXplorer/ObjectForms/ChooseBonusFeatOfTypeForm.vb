Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ChooseBonusFeatOfTypeForm
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
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents ChoiceTab As System.Windows.Forms.TabPage
    Public WithEvents ChoiceList As RPGXplorer.ListBox
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents RemoveChoice As System.Windows.Forms.Button
    Public WithEvents AddChoice As System.Windows.Forms.Button
    Public WithEvents Override As System.Windows.Forms.CheckBox
    Public WithEvents FeatTypes As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents FighterBonus As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ChoiceTab = New System.Windows.Forms.TabPage
        Me.Override = New System.Windows.Forms.CheckBox
        Me.ChoiceList = New RPGXplorer.ListBox
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.RemoveChoice = New System.Windows.Forms.Button
        Me.AddChoice = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.FeatTypes = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.FighterBonus = New System.Windows.Forms.CheckBox
        Me.TabControl1.SuspendLayout()
        Me.ChoiceTab.SuspendLayout()
        CType(Me.FeatTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.ChoiceTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ChoiceTab
        '
        Me.ChoiceTab.Controls.Add(Me.FighterBonus)
        Me.ChoiceTab.Controls.Add(Me.Override)
        Me.ChoiceTab.Controls.Add(Me.ChoiceList)
        Me.ChoiceTab.Controls.Add(Me.IndentedLine2)
        Me.ChoiceTab.Controls.Add(Me.RemoveChoice)
        Me.ChoiceTab.Controls.Add(Me.AddChoice)
        Me.ChoiceTab.Controls.Add(Me.Label1)
        Me.ChoiceTab.Controls.Add(Me.FeatTypes)
        Me.ChoiceTab.Location = New System.Drawing.Point(4, 22)
        Me.ChoiceTab.Name = "ChoiceTab"
        Me.ChoiceTab.Size = New System.Drawing.Size(407, 349)
        Me.ChoiceTab.TabIndex = 2
        Me.ChoiceTab.Text = "Bonus Feat Type Choices"
        '
        'Override
        '
        Me.Override.Location = New System.Drawing.Point(15, 75)
        Me.Override.Name = "Override"
        Me.Override.Size = New System.Drawing.Size(140, 21)
        Me.Override.TabIndex = 1
        Me.Override.Text = "Override prerequisites"
        '
        'ChoiceList
        '
        Me.ChoiceList.Location = New System.Drawing.Point(15, 125)
        Me.ChoiceList.Name = "ChoiceList"
        Me.ChoiceList.Size = New System.Drawing.Size(250, 210)
        Me.ChoiceList.TabIndex = 4
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 127
        Me.IndentedLine2.TabStop = False
        '
        'RemoveChoice
        '
        Me.RemoveChoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveChoice.Location = New System.Drawing.Point(280, 155)
        Me.RemoveChoice.Name = "RemoveChoice"
        Me.RemoveChoice.Size = New System.Drawing.Size(110, 24)
        Me.RemoveChoice.TabIndex = 3
        Me.RemoveChoice.Text = "Remove Choice"
        '
        'AddChoice
        '
        Me.AddChoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddChoice.Location = New System.Drawing.Point(280, 125)
        Me.AddChoice.Name = "AddChoice"
        Me.AddChoice.Size = New System.Drawing.Size(110, 24)
        Me.AddChoice.TabIndex = 2
        Me.AddChoice.Text = "Add Choice"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Feat Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FeatTypes
        '
        Me.FeatTypes.Location = New System.Drawing.Point(85, 15)
        Me.FeatTypes.Name = "FeatTypes"
        '
        'FeatTypes.Properties
        '
        Me.FeatTypes.Properties.AutoHeight = False
        Me.FeatTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatTypes.Properties.DropDownRows = 10
        Me.FeatTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatTypes.Size = New System.Drawing.Size(200, 21)
        Me.FeatTypes.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'FighterBonus
        '
        Me.FighterBonus.Location = New System.Drawing.Point(15, 45)
        Me.FighterBonus.Name = "FighterBonus"
        Me.FighterBonus.Size = New System.Drawing.Size(170, 21)
        Me.FighterBonus.TabIndex = 128
        Me.FighterBonus.Text = "Include Fighter Bonus Feats"
        '
        'ChooseBonusFeatOfTypeForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ChooseBonusFeatOfTypeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChooseBonusFeatOfTypeForm"
        Me.TabControl1.ResumeLayout(False)
        Me.ChoiceTab.ResumeLayout(False)
        CType(Me.FeatTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'object collections
    Private ExistingChoices As New Objects.ObjectDataCollection
    Private Choices As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try
            'initialise controls
            FeatTypes.Properties.Items.AddRange(Rules.Lists.FeatTypes)

            PropertiesTab.Init(mObject, mMode)
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
            mObject.Name = "Choose Bonus Feat"
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.ChooseBonusFeatOfTypeType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Choose Bonus Feat of Type"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Choice As Objects.ObjectData

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Choose Bonus Feat of Type"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            If mObject.Element("OverridePrerequisites") = "Yes" Then Override.Checked = True
            If mObject.Element("FighterBonus") = "Yes" Then FighterBonus.Checked = True
            ExistingChoices = mObject.ChildrenOfType(Objects.ChooseBonusFeatOfTypeChoiceType)
            For Each Choice In ExistingChoices
                Choices.Add(Choice)
                ChoiceList.AddItem(Choice.Name, Choice.ObjectGUID)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As Objects.ObjectData

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
                If Override.Checked Then mObject.Element("OverridePrerequisites") = "Yes" Else mObject.Element("OverridePrerequisites") = "No"
                If FighterBonus.Checked Then mObject.Element("FighterBonus") = "Yes" Else mObject.Element("FighterBonus") = "No"

                'remove choices no longer required
                For Each Obj In ExistingChoices
                    If Not Choices.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                'save required choices
                For Each Obj In Choices
                    If Not ExistingChoices.Contains(Obj.ObjectGUID) Then Obj.Save()
                Next

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                General.MainExplorer.RefreshPanel()
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
            If ChoiceList.Count < 1 Then
                Errors.SetError(ChoiceList, General.ValidationAtLeast1Required)
                Return False
            Else
                Errors.SetError(ChoiceList, "")
                Return True
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Buttons"

    Private Sub AddChoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddChoice.Click
        Dim Obj As New Objects.ObjectData
        Try

            If FeatTypes.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a feat type.")
            Else

                'make sure its not already in the list
                If Choices.Contains(CType(FeatTypes.SelectedItem, String)) Then
                    General.ShowInfoDialog("This feat type is already in the list.")
                    Exit Sub
                End If

                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                Obj.Type = Objects.ChooseBonusFeatOfTypeChoiceType
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.Name = CType(FeatTypes.SelectedItem, String)
                Obj.Element("FeatType") = CType(FeatTypes.SelectedItem, String)
                ChoiceList.AddItem(Obj.Name, Obj.ObjectGUID)
                Choices.Add(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveChoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveChoice.Click
        Try
            If ChoiceList.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a feat type to remove.")
            Else
                Choices.Remove(ChoiceList.ItemGUID)
                ChoiceList.RemoveSelectedItem()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

