Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SpecificBonusFeatForm
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
    Public WithEvents FeatFocus As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Feat As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Override As System.Windows.Forms.CheckBox
    Public WithEvents SpecificBonsuFeatTab As System.Windows.Forms.TabPage
    Public WithEvents SpecificFocus As System.Windows.Forms.RadioButton
    Public WithEvents ChooseFocus As System.Windows.Forms.RadioButton
    Public WithEvents TextBox As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SpecificBonsuFeatTab = New System.Windows.Forms.TabPage
        Me.TextBox = New DevExpress.XtraEditors.TextEdit
        Me.SpecificFocus = New System.Windows.Forms.RadioButton
        Me.Override = New System.Windows.Forms.CheckBox
        Me.FeatFocus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Feat = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ChooseFocus = New System.Windows.Forms.RadioButton
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.SpecificBonsuFeatTab.SuspendLayout()
        CType(Me.TextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeatFocus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Feat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.SpecificBonsuFeatTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'SpecificBonsuFeatTab
        '
        Me.SpecificBonsuFeatTab.Controls.Add(Me.TextBox)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.SpecificFocus)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Override)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.FeatFocus)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Label12)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.Feat)
        Me.SpecificBonsuFeatTab.Controls.Add(Me.ChooseFocus)
        Me.SpecificBonsuFeatTab.Location = New System.Drawing.Point(4, 22)
        Me.SpecificBonsuFeatTab.Name = "SpecificBonsuFeatTab"
        Me.SpecificBonsuFeatTab.Size = New System.Drawing.Size(407, 349)
        Me.SpecificBonsuFeatTab.TabIndex = 2
        Me.SpecificBonsuFeatTab.Text = "Specific Bonus Feat"
        '
        'TextBox
        '
        Me.TextBox.Enabled = False
        Me.TextBox.Location = New System.Drawing.Point(120, 45)
        Me.TextBox.Name = "TextBox"
        '
        'TextBox.Properties
        '
        Me.TextBox.Properties.AutoHeight = False
        Me.TextBox.Properties.MaxLength = 100
        Me.TextBox.Size = New System.Drawing.Size(200, 21)
        Me.TextBox.TabIndex = 173
        Me.TextBox.Visible = False
        '
        'SpecificFocus
        '
        Me.SpecificFocus.Enabled = False
        Me.SpecificFocus.Location = New System.Drawing.Point(15, 45)
        Me.SpecificFocus.Name = "SpecificFocus"
        Me.SpecificFocus.Size = New System.Drawing.Size(104, 21)
        Me.SpecificFocus.TabIndex = 2
        Me.SpecificFocus.Text = "Specific Focus"
        '
        'Override
        '
        Me.Override.Location = New System.Drawing.Point(15, 115)
        Me.Override.Name = "Override"
        Me.Override.Size = New System.Drawing.Size(140, 21)
        Me.Override.TabIndex = 4
        Me.Override.Text = "Override prerequisites"
        '
        'FeatFocus
        '
        Me.FeatFocus.Enabled = False
        Me.FeatFocus.Location = New System.Drawing.Point(120, 45)
        Me.FeatFocus.Name = "FeatFocus"
        '
        'FeatFocus.Properties
        '
        Me.FeatFocus.Properties.AutoHeight = False
        Me.FeatFocus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FeatFocus.Properties.DropDownRows = 10
        Me.FeatFocus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FeatFocus.Size = New System.Drawing.Size(200, 21)
        Me.FeatFocus.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(15, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 21)
        Me.Label12.TabIndex = 172
        Me.Label12.Text = "Feat"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Feat
        '
        Me.Feat.Location = New System.Drawing.Point(120, 15)
        Me.Feat.Name = "Feat"
        '
        'Feat.Properties
        '
        Me.Feat.Properties.AutoHeight = False
        Me.Feat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Feat.Properties.DropDownRows = 10
        Me.Feat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Feat.Size = New System.Drawing.Size(200, 21)
        Me.Feat.TabIndex = 0
        '
        'ChooseFocus
        '
        Me.ChooseFocus.Enabled = False
        Me.ChooseFocus.Location = New System.Drawing.Point(15, 75)
        Me.ChooseFocus.Name = "ChooseFocus"
        Me.ChooseFocus.Size = New System.Drawing.Size(104, 21)
        Me.ChooseFocus.TabIndex = 1
        Me.ChooseFocus.Text = "Choose Focus"
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
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 349)
        Me.PropertiesTab.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'SpecificBonusFeatForm
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
        Me.Name = "SpecificBonusFeatForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpecificBonusFeatForm"
        Me.TabControl1.ResumeLayout(False)
        Me.SpecificBonsuFeatTab.ResumeLayout(False)
        CType(Me.TextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeatFocus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Feat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mInitOK As Boolean = True

    'index
    Private FeatIndex As DataListItem()
    Private FeatFocusIndex As DataListItem()

    'exclusion for foci
    Private ExistingFocusType As String = ""
    Private ExcludedFoci As New ArrayList

    'init
    Public Sub Init()
        Dim Existing As Objects.ObjectDataCollection
        Dim ExcludeList As New ArrayList
        Dim Obj As Objects.ObjectData

        Try
            'index
            FeatIndex = Rules.Index.DataList(Xml.DBTypes.Feats, Objects.FeatDefinitionType)

            'remove any system elements that already have a modifier in this folder
            'except if modifier has a focus then just add focus to list of excluded foci
            Existing = mObject.Parent.ChildrenOfType(Objects.SpecificBonusFeatType)
            If Existing.Contains(mObject.ObjectGUID) Then Existing.Remove(mObject.ObjectGUID)

            For Each Obj In Existing
                If (Obj.Element("Focus") = "") Then

                    'lookup Feat
                    Dim FeatDef As Objects.ObjectData = Obj.GetFKObject("Feat")
                    If FeatDef.Element("Stacks") <> "Yes" Then
                        ExcludeList.Add(Obj.GetFKGuid("Feat"))
                    End If

                End If
            Next

            'add speak language
            ExcludedFoci.Add(References.SpeakLanguage)

            FeatIndex = Rules.Index.DataListExclude(Xml.DBTypes.Feats, Objects.FeatDefinitionType, ExcludeList)

            If FeatIndex Is Nothing Then
                General.ShowInfoDialog("This component already has all possible specific bonus feats.")
                mInitOK = False
                Exit Sub
            End If

            'initialise controls
            Feat.Properties.Items.AddRange(FeatIndex)
            PropertiesTab.Init(mObject, mMode)

            Select Case mFolder.Type
                Case Objects.DomainDefinitionType, Objects.PsionicSpecializationDefinitionType
                    ChooseFocus.Visible = False
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''initialise the form for add
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Specific Bonus Feat"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls
            Return mInitOK

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mFolder = Obj.Parent
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Specific Bonus Feat"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            Feat.SelectedIndex = Rules.Index.GetGuidIndex(FeatIndex, mObject.GetFKGuid("Feat"))

            If mObject.Element("Focus") <> "Choose Focus" And mObject.Element("Focus") <> "" Then
                If mObject.GetFKGuid("Focus").Equals(RPGXplorer.References.CustomFeatFocus) Then
                    TextBox.Visible = True
                    TextBox.Text = mObject.Element("Focus")
                Else
                    FeatFocus.SelectedIndex = Rules.Index.GetGuidIndex(FeatFocusIndex, mObject.GetFKGuid("Focus"))
                End If
                SpecificFocus.Checked = True
            End If

            If mObject.Element("OverridePrerequisites") = "Yes" Then Override.CheckState = CheckState.Checked Else Override.CheckState = CheckState.Unchecked

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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
                mObject.FKElement("Feat", Feat.Text, "Name", CType(Feat.SelectedItem, DataListItem).ObjectGUID)
                mObject.HTMLGUID = mObject.GetFKGuid("Feat")

                'If ChooseFocus.Enabled And ChooseFocus.Checked Then
                '    mObject.Type = Objects.SpecificBonusFeatChooseFocusType
                '    mObject.FKSetNull("Focus")
                '    mObject.Element("Focus") = "Choose Focus"
                'ElseIf FeatFocus.Properties.Enabled Then
                '    If TextBox.Visible = True Then
                '        mObject.Type = Objects.SpecificBonusFeatType
                '        mObject.FKElement("Focus", TextBox.Text, "Name", RPGXplorer.References.CustomFeatFocus)
                '    Else
                '        mObject.Type = Objects.SpecificBonusFeatType
                '        mObject.FKElement("Focus", FeatFocus.Text, "Name", CType(FeatFocus.SelectedItem, DataListItem).ObjectGUID)
                '    End If
                'Else
                '    mObject.Type = Objects.SpecificBonusFeatType
                '    mObject.FKSetNull("Focus")
                'End If


                If ChooseFocus.Enabled And ChooseFocus.Checked Then
                    mObject.Type = Objects.SpecificBonusFeatChooseFocusType
                    mObject.FKSetNull("Focus")
                    mObject.Element("Focus") = "Choose Focus"
                ElseIf SpecificFocus.Enabled AndAlso SpecificFocus.Checked Then
                    If TextBox.Visible = True Then
                        mObject.Type = Objects.SpecificBonusFeatType
                        mObject.FKElement("Focus", TextBox.Text, "Name", RPGXplorer.References.CustomFeatFocus)
                    Else
                        mObject.Type = Objects.SpecificBonusFeatType
                        mObject.FKElement("Focus", FeatFocus.Text, "Name", CType(FeatFocus.SelectedItem, DataListItem).ObjectGUID)
                    End If
                Else
                    mObject.Type = Objects.SpecificBonusFeatType
                    mObject.FKSetNull("Focus")
                End If

                If Override.CheckState = CheckState.Checked Then mObject.Element("OverridePrerequisites") = "Yes" Else mObject.Element("OverridePrerequisites") = ""
                PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                General.MainExplorer.RefreshPanel()
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
            Validate = General.ValidateForm(SpecificBonsuFeatTab.Controls, Errors)
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

    'check to if it has a focus
    Private Sub Feat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Feat.SelectedIndexChanged
        Try
            If Feat.Text = "" Then Exit Sub

            Dim Obj As New Objects.ObjectData
            Dim CustomFlag As Boolean
            Obj.Load(CType(Feat.SelectedItem, DataListItem).ObjectGUID)

            'determine whether there is a focus component
            If Obj.Element("FocusType") <> "" Then

                Select Case Obj.Element("FocusType")
                    Case "Custom"
                        CustomFlag = True
                    Case "Alignment"
                        FeatFocusIndex = Rules.Index.AlignmentDataList
                    Case "Discipline Specialization"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType, ExcludedFoci)
                    Case "Domain"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Domains, Objects.DomainDefinitionType, ExcludedFoci)
                    Case "Power Discipline"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.SpellSchools, Objects.PsionicDisciplineType, ExcludedFoci)
                    Case "Spell School"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType, ExcludedFoci)
                    Case "Skill"
                        FeatFocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Skills, Objects.SkillDefinitionType, ExcludedFoci)
                    Case "Simple Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.SimpleWeapons, ExcludedFoci)
                    Case "Exotic Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.ExoticWeapons, ExcludedFoci)
                    Case "Martial Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.MartialWeapons, ExcludedFoci)
                    Case "Ranged Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.RangedWeapons, ExcludedFoci)
                    Case "Melee Weapon"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.MeleeWeapons, ExcludedFoci)
                    Case "Crossbow"
                        FeatFocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, XPathQueries.Crossbows, ExcludedFoci)
                    Case "Any Weapon"
                        'get the normal weapons
                        Dim Weapons As New Objects.ObjectDataCollection
                        Weapons.AddMany(Objects.GetObjectsByXPath(Xml.DBTypes.Weapons, XPathQueries.AllWeapons))

                        'add the natural attack types
                        For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
                            Dim NA As New Objects.ObjectData
                            NA.ObjectGUID = General.ConvertToObjectKey(NaturalAttack, Xml.DBTypes.NaturalWeapons)
                            NA.Name = NaturalAttack
                            Weapons.Add(NA)
                        Next

                        FeatFocusIndex = Rules.Index.DataListExclude(Weapons, ExcludedFoci)

                    Case "Natural Weapon"
                        Dim Weapons As New Objects.ObjectDataCollection

                        'add the natural attack types
                        For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes
                            Dim NA As New Objects.ObjectData
                            NA.ObjectGUID = General.ConvertToObjectKey(NaturalAttack, Xml.DBTypes.NaturalWeapons)
                            NA.Name = NaturalAttack
                            Weapons.Add(NA)
                        Next

                        FeatFocusIndex = Rules.Index.DataListExclude(Weapons, ExcludedFoci)
                End Select

                If Not CustomFlag Then
                    TextBox.Visible = False
                    TextBox.Enabled = False
                    FeatFocus.Properties.Items.Clear()
                    If Not FeatFocusIndex Is Nothing Then FeatFocus.Properties.Items.AddRange(FeatFocusIndex)
                Else
                    TextBox.Text = ""
                    TextBox.Visible = True
                    If SpecificFocus.Checked = True Then
                        TextBox.Enabled = True
                    Else
                        TextBox.Enabled = False
                    End If
                End If

                SpecificFocus.Enabled = True
                ChooseFocus.Enabled = True
                FeatFocus.Properties.Enabled = False
                FeatFocus.SelectedIndex = -1
                If mFolder.Type = Objects.DomainDefinitionType Then SpecificFocus.Checked = True Else ChooseFocus.Checked = True
            Else
                TextBox.Visible = False
                TextBox.Enabled = False
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

                If TextBox.Text <> "" Then
                    TextBox.Properties.Enabled = True
                    Exit Sub
                End If

                If TextBox.Visible Then
                    TextBox.Properties.Enabled = True
                Else
                    FeatFocus.Properties.Enabled = True
                End If

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

End Class

