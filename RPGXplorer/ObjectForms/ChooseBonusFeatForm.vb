Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ChooseBonusFeatForm
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
    Public WithEvents Feats As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ChoiceTab As System.Windows.Forms.TabPage
    Public WithEvents ChoiceList As RPGXplorer.ListBox
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents RemoveChoice As System.Windows.Forms.Button
    Public WithEvents AddChoice As System.Windows.Forms.Button
    Public WithEvents Override As System.Windows.Forms.CheckBox
    Public WithEvents SpecificFocus As System.Windows.Forms.RadioButton
    Public WithEvents FeatFocus As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ChooseFocus As System.Windows.Forms.RadioButton
    Public WithEvents FighterBonus As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents FeatTypes As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TextBox As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ChoiceTab = New System.Windows.Forms.TabPage
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label2 = New System.Windows.Forms.Label
        Me.FeatTypes = New DevExpress.XtraEditors.ComboBoxEdit
        Me.FighterBonus = New System.Windows.Forms.CheckBox
        Me.TextBox = New DevExpress.XtraEditors.TextEdit
        Me.SpecificFocus = New System.Windows.Forms.RadioButton
        Me.FeatFocus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ChooseFocus = New System.Windows.Forms.RadioButton
        Me.Override = New System.Windows.Forms.CheckBox
        Me.ChoiceList = New RPGXplorer.ListBox
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.RemoveChoice = New System.Windows.Forms.Button
        Me.AddChoice = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Feats = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.ChoiceTab.SuspendLayout()
        CType(Me.FeatTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeatFocus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Feats.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ChoiceTab.Controls.Add(Me.IndentedLine1)
        Me.ChoiceTab.Controls.Add(Me.Label2)
        Me.ChoiceTab.Controls.Add(Me.FeatTypes)
        Me.ChoiceTab.Controls.Add(Me.FighterBonus)
        Me.ChoiceTab.Controls.Add(Me.TextBox)
        Me.ChoiceTab.Controls.Add(Me.SpecificFocus)
        Me.ChoiceTab.Controls.Add(Me.FeatFocus)
        Me.ChoiceTab.Controls.Add(Me.ChooseFocus)
        Me.ChoiceTab.Controls.Add(Me.Override)
        Me.ChoiceTab.Controls.Add(Me.ChoiceList)
        Me.ChoiceTab.Controls.Add(Me.IndentedLine2)
        Me.ChoiceTab.Controls.Add(Me.RemoveChoice)
        Me.ChoiceTab.Controls.Add(Me.AddChoice)
        Me.ChoiceTab.Controls.Add(Me.Label1)
        Me.ChoiceTab.Controls.Add(Me.Feats)
        Me.ChoiceTab.Location = New System.Drawing.Point(4, 22)
        Me.ChoiceTab.Name = "ChoiceTab"
        Me.ChoiceTab.Size = New System.Drawing.Size(407, 349)
        Me.ChoiceTab.TabIndex = 2
        Me.ChoiceTab.Text = "Bonus Feat Choices"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(16, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 178
        Me.IndentedLine1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "All Feats of Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FeatTypes
        '
        Me.FeatTypes.Location = New System.Drawing.Point(120, 15)
        Me.FeatTypes.Name = "FeatTypes"
        Me.FeatTypes.Properties.AutoHeight = False
        Me.FeatTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatTypes.Properties.DropDownRows = 10
        Me.FeatTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatTypes.Size = New System.Drawing.Size(200, 21)
        Me.FeatTypes.TabIndex = 176
        '
        'FighterBonus
        '
        Me.FighterBonus.Location = New System.Drawing.Point(165, 155)
        Me.FighterBonus.Name = "FighterBonus"
        Me.FighterBonus.Size = New System.Drawing.Size(235, 21)
        Me.FighterBonus.TabIndex = 175
        Me.FighterBonus.Text = "Include All Fighter Bonus Feats"
        '
        'TextBox
        '
        Me.TextBox.Enabled = False
        Me.TextBox.Location = New System.Drawing.Point(120, 95)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Properties.AutoHeight = False
        Me.TextBox.Properties.MaxLength = 100
        Me.TextBox.Size = New System.Drawing.Size(200, 21)
        Me.TextBox.TabIndex = 174
        Me.TextBox.Visible = False
        '
        'SpecificFocus
        '
        Me.SpecificFocus.Enabled = False
        Me.SpecificFocus.Location = New System.Drawing.Point(15, 95)
        Me.SpecificFocus.Name = "SpecificFocus"
        Me.SpecificFocus.Size = New System.Drawing.Size(104, 21)
        Me.SpecificFocus.TabIndex = 129
        Me.SpecificFocus.Text = "Specific Focus"
        '
        'FeatFocus
        '
        Me.FeatFocus.Enabled = False
        Me.FeatFocus.Location = New System.Drawing.Point(120, 95)
        Me.FeatFocus.Name = "FeatFocus"
        Me.FeatFocus.Properties.AutoHeight = False
        Me.FeatFocus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatFocus.Properties.DropDownRows = 10
        Me.FeatFocus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatFocus.Size = New System.Drawing.Size(200, 21)
        Me.FeatFocus.TabIndex = 130
        '
        'ChooseFocus
        '
        Me.ChooseFocus.Enabled = False
        Me.ChooseFocus.Location = New System.Drawing.Point(15, 125)
        Me.ChooseFocus.Name = "ChooseFocus"
        Me.ChooseFocus.Size = New System.Drawing.Size(104, 21)
        Me.ChooseFocus.TabIndex = 128
        Me.ChooseFocus.Text = "Choose Focus"
        '
        'Override
        '
        Me.Override.Location = New System.Drawing.Point(15, 155)
        Me.Override.Name = "Override"
        Me.Override.Size = New System.Drawing.Size(140, 21)
        Me.Override.TabIndex = 1
        Me.Override.Text = "Override prerequisites"
        '
        'ChoiceList
        '
        Me.ChoiceList.Location = New System.Drawing.Point(15, 205)
        Me.ChoiceList.Name = "ChoiceList"
        Me.ChoiceList.Size = New System.Drawing.Size(250, 130)
        Me.ChoiceList.TabIndex = 4
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 190)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 127
        Me.IndentedLine2.TabStop = False
        '
        'RemoveChoice
        '
        Me.RemoveChoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveChoice.Location = New System.Drawing.Point(280, 235)
        Me.RemoveChoice.Name = "RemoveChoice"
        Me.RemoveChoice.Size = New System.Drawing.Size(110, 24)
        Me.RemoveChoice.TabIndex = 3
        Me.RemoveChoice.Text = "Remove Choice"
        '
        'AddChoice
        '
        Me.AddChoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddChoice.Location = New System.Drawing.Point(280, 205)
        Me.AddChoice.Name = "AddChoice"
        Me.AddChoice.Size = New System.Drawing.Size(110, 24)
        Me.AddChoice.TabIndex = 2
        Me.AddChoice.Text = "Add Choice"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Feat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Feats
        '
        Me.Feats.Location = New System.Drawing.Point(120, 65)
        Me.Feats.Name = "Feats"
        Me.Feats.Properties.AutoHeight = False
        Me.Feats.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Feats.Properties.DropDownRows = 10
        Me.Feats.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Feats.Size = New System.Drawing.Size(200, 21)
        Me.Feats.TabIndex = 0
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
        'ChooseBonusFeatForm
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
        Me.Name = "ChooseBonusFeatForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChooseBonusFeatForm"
        Me.TabControl1.ResumeLayout(False)
        Me.ChoiceTab.ResumeLayout(False)
        CType(Me.FeatTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeatFocus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Feats.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'index    
    Private FeatIndex As DataListItem()
    Private FeatFocusIndex As DataListItem()

    'object collections
    Private ExistingChoices As New Objects.ObjectDataCollection
    Private Choices As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try
            'index
            Dim Exclude As New ArrayList
            Exclude.Add(References.SimpleWeaponsProficiencyFeat)

            FeatIndex = Rules.Index.DataListExclude(Xml.DBTypes.Feats, Objects.FeatDefinitionType, Exclude)

            'types           
            FeatTypes.Properties.Items.AddRange(Rules.Lists.FeatTypes)

            'initialise controls
            Feats.Properties.Items.AddRange(FeatIndex)
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
            mObject.Type = Objects.ChooseBonusFeatType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Choose Bonus Feat"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls

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
            Me.Text = "Edit Choose Bonus Feat"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            If mObject.Element("OverridePrerequisites") = "Yes" Then Override.Checked = True
            If mObject.Element("FighterBonus") = "Yes" Then FighterBonus.Checked = True
            ExistingChoices = mObject.Children
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
            If ChoiceList.Count < 2 Then
                'make sure at least one is a type choice
                For Each TempObj As Objects.ObjectData In Choices
                    If TempObj.Type = Objects.ChooseBonusFeatOfTypeChoiceType Then
                        Errors.SetError(ChoiceList, "")
                        Return True
                    End If
                Next

                Errors.SetError(ChoiceList, General.ValidationAtLeast2Required)
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
        Dim FeatGuid As Objects.ObjectKey
        Dim FocusGuid As Objects.ObjectKey

        Try

            If Feats.SelectedIndex = -1 AndAlso FeatTypes.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a feat or a feat type.")
                Exit Sub
            End If

            If Not Feats.SelectedIndex = -1 Then
                'we are a specific feat

                FeatGuid = CType(Feats.SelectedItem, DataListItem).ObjectGUID

                If SpecificFocus.Checked = True Then
                    If TextBox.Visible = True Then
                        If TextBox.Text = "" Then
                            General.ShowInfoDialog("Please enter a focus.")
                            Exit Sub
                        End If
                        FocusGuid = References.CustomFeatFocus
                    Else
                        If FeatFocus.SelectedIndex = -1 Then
                            General.ShowInfoDialog("Please select a focus.")
                            Exit Sub
                        End If
                        FocusGuid = CType(FeatFocus.SelectedItem, DataListItem).ObjectGUID
                    End If
                End If

                If Choices.ContainsFK("Feat", FeatGuid) Then
                    If ChooseFocus.Checked = True Then
                        General.ShowInfoDialog("This feat is already in the list.")
                        Exit Sub
                    Else

                        'get all the current feats of this type and make sure we have a different focus
                        For Each TempObj As Objects.ObjectData In Choices.Items("Feat", FeatGuid)
                            Dim TempFocus As Objects.ObjectKey = TempObj.GetFKGuid("Focus")
                            If TempFocus.IsEmpty Then
                                General.ShowInfoDialog("This feat is already in the list with an open focus.")
                                Exit Sub
                            Else
                                If TempFocus.Equals(References.CustomFeatFocus) Then
                                    If TempObj.Element("Focus") = TextBox.Text Then
                                        General.ShowInfoDialog("This feat is already in the list with specified focus.")
                                        Exit Sub
                                    End If
                                ElseIf TempFocus.Equals(FocusGuid) Then
                                    General.ShowInfoDialog("This feat is already in the list with specified focus.")
                                    Exit Sub
                                End If
                            End If
                        Next
                    End If
                End If

                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                Obj.Type = Objects.ChooseBonusFeatChoiceType
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.FKElement("Feat", Feats.Text, "Name", FeatGuid)

                If FocusGuid.IsNotEmpty Then
                    If FocusGuid.Equals(References.CustomFeatFocus) Then
                        Obj.FKElement("Focus", TextBox.Text, "Name", FocusGuid)
                    Else
                        Obj.FKElement("Focus", FeatFocus.Text, "Name", FocusGuid)
                    End If
                End If

                ChoiceList.AddItem(Obj.Name, Obj.ObjectGUID)
                Choices.Add(Obj)

            Else
                'make sure its not already in the list
                If Choices.Contains("All Feats of " & CType(FeatTypes.SelectedItem, String) & " Type") Then
                    General.ShowInfoDialog("This feat type is already in the list.")
                    Exit Sub
                End If

                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                Obj.Type = Objects.ChooseBonusFeatOfTypeChoiceType
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.Name = "All Feats of " & CType(FeatTypes.SelectedItem, String) & " Type"
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
                General.ShowInfoDialog("Please select a feat to remove.")
            Else
                Choices.Remove(ChoiceList.ItemGUID)
                ChoiceList.RemoveSelectedItem()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling/Disabling"

    Private Sub Feats_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Feats.SelectedIndexChanged
        Try
            If Feats.Text = "" Then
                TextBox.Visible = False
                SpecificFocus.Enabled = False
                ChooseFocus.Enabled = False
                SpecificFocus.Enabled = False
                ChooseFocus.Checked = False
                SpecificFocus.Checked = False
                Exit Sub
            End If

            'make sure se unselect the type dropdown
            FeatTypes.SelectedIndex = -1

            Dim Obj As New Objects.ObjectData
            Dim CustomFlag As Boolean
            Obj.Load(CType(Feats.SelectedItem, DataListItem).ObjectGUID)

            'determine whether there is a focus component
            If Obj.Element("FocusType") <> "" Then

                'get the exclude lisr for this feat
                Dim ExcludeList As New ArrayList

                Select Case Obj.Element("FocusType")
                    Case "Custom"
                        CustomFlag = True
                    Case "Alignment"
                        FeatFocusIndex = Rules.Index.AlignmentDataList
                    Case "Discipline Specialization"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType, ExcludeList)
                    Case "Domain"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Domains, Objects.DomainDefinitionType, ExcludeList)
                    Case "Power Discipline"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.SpellSchools, Objects.PsionicDisciplineType, ExcludeList)
                    Case "Spell School"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType, ExcludeList)
                    Case "Skill"
                        ExcludeList.Add(References.SpeakLanguage)
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Skills, Objects.SkillDefinitionType, ExcludeList)
                    Case "Any Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.AllWeapons, ExcludeList)
                    Case "Simple Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.SimpleWeapons, ExcludeList)
                    Case "Exotic Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.ExoticWeapons, ExcludeList)
                    Case "Martial Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.MartialWeapons, ExcludeList)
                    Case "Ranged Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.RangedWeapons, ExcludeList)
                    Case "Melee Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.MeleeWeapons, ExcludeList)
                    Case "Crossbow"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.Crossbows, ExcludeList)
                End Select

                If Not CustomFlag Then
                    TextBox.Visible = False
                    FeatFocus.Properties.Items.Clear()
                    If Not FeatFocusIndex Is Nothing Then FeatFocus.Properties.Items.AddRange(FeatFocusIndex)
                Else
                    TextBox.Text = ""
                    TextBox.Visible = True
                End If

                SpecificFocus.Enabled = True
                ChooseFocus.Enabled = True
                FeatFocus.Properties.Enabled = False
                FeatFocus.SelectedIndex = -1
                If mFolder.Type = Objects.DomainDefinitionType Then SpecificFocus.Checked = True Else ChooseFocus.Checked = True
            Else
                TextBox.Visible = False
                SpecificFocus.Enabled = False
                ChooseFocus.Enabled = False
                SpecificFocus.Enabled = False
                ChooseFocus.Checked = False
                SpecificFocus.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub SpecificFocus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecificFocus.CheckedChanged
        Try
            If SpecificFocus.Checked = True Then
                FeatFocus.Properties.Enabled = True
                TextBox.Properties.Enabled = True
            Else
                TextBox.Properties.Enabled = False
                FeatFocus.Properties.Enabled = False
                FeatFocus.SelectedIndex = -1
                TextBox.Text = ""
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    Private Sub FeatTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeatTypes.SelectedIndexChanged
        Try
            If Not FeatTypes.SelectedIndex = -1 Then
                'make sure the Feat dropdown is unselected
                Feats.SelectedIndex = -1


            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

