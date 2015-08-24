Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SkillSynergyForm
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
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Bonus As System.Windows.Forms.TabPage
    Public WithEvents Ranks As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents DiceRange As DevExpress.XtraEditors.TextEdit
    Public WithEvents Percentage As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Ability As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents ModifierCategory As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Limiter As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Modifier As RPGXplorer.Modifier
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents ObjectTypeLabel As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents ModifierType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents SystemElement As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents FocusObject As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Bonus = New System.Windows.Forms.TabPage
        Me.DiceRange = New DevExpress.XtraEditors.TextEdit
        Me.Percentage = New DevExpress.XtraEditors.SpinEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Ability = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.ModifierCategory = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Limiter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Modifier = New RPGXplorer.Modifier
        Me.Label4 = New System.Windows.Forms.Label
        Me.ObjectTypeLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ModifierType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.SystemElement = New DevExpress.XtraEditors.ComboBoxEdit
        Me.FocusObject = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label6 = New System.Windows.Forms.Label
        Me.Ranks = New DevExpress.XtraEditors.SpinEdit
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.Bonus.SuspendLayout()
        CType(Me.DiceRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifierCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Limiter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifierType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemElement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FocusObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ranks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.Bonus)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'Bonus
        '
        Me.Bonus.Controls.Add(Me.DiceRange)
        Me.Bonus.Controls.Add(Me.Percentage)
        Me.Bonus.Controls.Add(Me.IndentedLine2)
        Me.Bonus.Controls.Add(Me.Ability)
        Me.Bonus.Controls.Add(Me.Label5)
        Me.Bonus.Controls.Add(Me.ModifierCategory)
        Me.Bonus.Controls.Add(Me.Limiter)
        Me.Bonus.Controls.Add(Me.Label3)
        Me.Bonus.Controls.Add(Me.Modifier)
        Me.Bonus.Controls.Add(Me.Label4)
        Me.Bonus.Controls.Add(Me.ObjectTypeLabel)
        Me.Bonus.Controls.Add(Me.Label2)
        Me.Bonus.Controls.Add(Me.ModifierType)
        Me.Bonus.Controls.Add(Me.Label7)
        Me.Bonus.Controls.Add(Me.SystemElement)
        Me.Bonus.Controls.Add(Me.FocusObject)
        Me.Bonus.Controls.Add(Me.Label1)
        Me.Bonus.Controls.Add(Me.IndentedLine1)
        Me.Bonus.Controls.Add(Me.Label6)
        Me.Bonus.Controls.Add(Me.Ranks)
        Me.Bonus.Location = New System.Drawing.Point(4, 22)
        Me.Bonus.Name = "Bonus"
        Me.Bonus.Size = New System.Drawing.Size(407, 349)
        Me.Bonus.TabIndex = 2
        Me.Bonus.Text = "Skill Synergy"
        '
        'DiceRange
        '
        Me.DiceRange.Enabled = False
        Me.DiceRange.Location = New System.Drawing.Point(95, 205)
        Me.DiceRange.Name = "DiceRange"
        '
        'DiceRange.Properties
        '
        Me.DiceRange.Properties.Appearance.Options.UseTextOptions = True
        Me.DiceRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DiceRange.Properties.AutoHeight = False
        Me.DiceRange.Properties.MaxLength = 50
        Me.DiceRange.Size = New System.Drawing.Size(65, 21)
        Me.DiceRange.TabIndex = 153
        '
        'Percentage
        '
        Me.Percentage.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Percentage.Enabled = False
        Me.Percentage.Location = New System.Drawing.Point(95, 205)
        Me.Percentage.Name = "Percentage"
        '
        'Percentage.Properties
        '
        Me.Percentage.Properties.Appearance.Options.UseTextOptions = True
        Me.Percentage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Percentage.Properties.AutoHeight = False
        Me.Percentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Percentage.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Percentage.Properties.IsFloatValue = False
        Me.Percentage.Properties.Mask.BeepOnError = True
        Me.Percentage.Properties.Mask.EditMask = "9999%"
        Me.Percentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Percentage.Properties.Mask.ShowPlaceHolders = False
        Me.Percentage.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Percentage.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Percentage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Percentage.Size = New System.Drawing.Size(65, 21)
        Me.Percentage.TabIndex = 152
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 160)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 163
        Me.IndentedLine2.TabStop = False
        '
        'Ability
        '
        Me.Ability.Enabled = False
        Me.Ability.Location = New System.Drawing.Point(95, 205)
        Me.Ability.Name = "Ability"
        '
        'Ability.Properties
        '
        Me.Ability.Properties.AutoHeight = False
        Me.Ability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ability.Properties.DropDownRows = 10
        Me.Ability.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Ability.Size = New System.Drawing.Size(65, 21)
        Me.Ability.TabIndex = 154
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.CausesValidation = False
        Me.Label5.Location = New System.Drawing.Point(15, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Category"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModifierCategory
        '
        Me.ModifierCategory.Enabled = False
        Me.ModifierCategory.Location = New System.Drawing.Point(95, 175)
        Me.ModifierCategory.Name = "ModifierCategory"
        '
        'ModifierCategory.Properties
        '
        Me.ModifierCategory.Properties.AutoHeight = False
        Me.ModifierCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifierCategory.Properties.DropDownRows = 10
        Me.ModifierCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ModifierCategory.Size = New System.Drawing.Size(200, 21)
        Me.ModifierCategory.TabIndex = 150
        '
        'Limiter
        '
        Me.Limiter.CausesValidation = False
        Me.Limiter.Location = New System.Drawing.Point(95, 265)
        Me.Limiter.Name = "Limiter"
        '
        'Limiter.Properties
        '
        Me.Limiter.Properties.AutoHeight = False
        Me.Limiter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Limiter.Properties.DropDownRows = 10
        Me.Limiter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Limiter.Size = New System.Drawing.Size(200, 21)
        Me.Limiter.TabIndex = 156
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Limiter"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Modifier
        '
        Me.Modifier.Enabled = False
        Me.Modifier.Location = New System.Drawing.Point(95, 205)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(65, 21)
        Me.Modifier.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Applies To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectTypeLabel
        '
        Me.ObjectTypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjectTypeLabel.CausesValidation = False
        Me.ObjectTypeLabel.Location = New System.Drawing.Point(15, 125)
        Me.ObjectTypeLabel.Name = "ObjectTypeLabel"
        Me.ObjectTypeLabel.Size = New System.Drawing.Size(75, 21)
        Me.ObjectTypeLabel.TabIndex = 159
        Me.ObjectTypeLabel.Text = "[Object Type]"
        Me.ObjectTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ObjectTypeLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Modifier Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModifierType
        '
        Me.ModifierType.EditValue = "Undefined"
        Me.ModifierType.Location = New System.Drawing.Point(95, 235)
        Me.ModifierType.Name = "ModifierType"
        '
        'ModifierType.Properties
        '
        Me.ModifierType.Properties.AutoHeight = False
        Me.ModifierType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifierType.Properties.DropDownRows = 10
        Me.ModifierType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ModifierType.Size = New System.Drawing.Size(200, 21)
        Me.ModifierType.TabIndex = 155
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.CausesValidation = False
        Me.Label7.Location = New System.Drawing.Point(15, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Modifier"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SystemElement
        '
        Me.SystemElement.Location = New System.Drawing.Point(95, 95)
        Me.SystemElement.Name = "SystemElement"
        '
        'SystemElement.Properties
        '
        Me.SystemElement.Properties.AutoHeight = False
        Me.SystemElement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SystemElement.Properties.DropDownRows = 10
        Me.SystemElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SystemElement.Size = New System.Drawing.Size(200, 21)
        Me.SystemElement.TabIndex = 148
        '
        'FocusObject
        '
        Me.FocusObject.Location = New System.Drawing.Point(95, 125)
        Me.FocusObject.Name = "FocusObject"
        '
        'FocusObject.Properties
        '
        Me.FocusObject.Properties.AutoHeight = False
        Me.FocusObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FocusObject.Properties.DropDownRows = 10
        Me.FocusObject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FocusObject.Size = New System.Drawing.Size(200, 21)
        Me.FocusObject.TabIndex = 149
        Me.FocusObject.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Synergy Bonus"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 146
        Me.IndentedLine1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Ranks Required"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ranks
        '
        Me.Ranks.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ranks.Location = New System.Drawing.Point(110, 15)
        Me.Ranks.Name = "Ranks"
        '
        'Ranks.Properties
        '
        Me.Ranks.Properties.Appearance.Options.UseTextOptions = True
        Me.Ranks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ranks.Properties.AutoHeight = False
        Me.Ranks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Ranks.Properties.IsFloatValue = False
        Me.Ranks.Properties.Mask.BeepOnError = True
        Me.Ranks.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Ranks.Properties.Mask.ShowPlaceHolders = False
        Me.Ranks.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Ranks.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ranks.Size = New System.Drawing.Size(50, 21)
        Me.Ranks.TabIndex = 0
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
        'SkillSynergyForm
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
        Me.Name = "SkillSynergyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SkillSynergyForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Bonus.ResumeLayout(False)
        CType(Me.DiceRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifierCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Limiter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifierType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemElement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FocusObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ranks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mInitOK As Boolean = True
    Public ExcludeNotForWeapons As Boolean = False

    'index
    Private SystemElementIndex As DataListItem()
    Private FocusIndex As DataListItem()
    Private LimiterIndex As DataListItem()

    'exclusion for foci
    Private ExistingFocusType As String = ""
    Private ExcludedFoci As New ArrayList

    'init
    Public Sub Init()
        Dim Existing, Filtered As Objects.ObjectDataCollection
        Dim ExcludeList As New ArrayList
        Dim Obj, Parent As Objects.ObjectData

        Try
            General.SetWaitCursor()

            'index
            LimiterIndex = Rules.Index.DataList(Xml.DBTypes.ModifierLimiters, Objects.ModifierLimiterType, True)

            'get the parent of the modifier (ignoring conditions)
            If mObject.Parent.Type = Objects.ConditionType Then
                Parent = mObject.Parent.Parent
            Else
                Parent = mObject.Parent
            End If

            'create a list of relevant system objects 
            Filtered = CommonLogic.AppropriateModifiers(mObject)

            'remove any system elements that already have a modifier in this folder
            'except if modifier has a focus then just add focus to list of excluded foci
            'or if there is a limiter.
            Existing = mObject.Parent.ChildrenOfType(Objects.ModifierType)
            If Existing.Contains(mObject.ObjectGUID) Then Existing.Remove(mObject.ObjectGUID)

            For Each Obj In Existing
                If Obj.Element("FocusObject") = "" Then
                    If Obj.Element("Limiter") = "" Then ExcludeList.Add(Obj.GetFKGuid("SystemElement"))
                Else
                    ExcludedFoci.Add(Obj.GetFKGuid("FocusObject"))
                End If
            Next

            SystemElementIndex = Rules.Index.DataListExclude(Filtered, ExcludeList)

            If SystemElementIndex Is Nothing Then
                General.ShowInfoDialog("This component already has a modifier for each system element.")
                mInitOK = False
                Exit Sub
            End If

            'initialise controls
            ModifierType.Properties.Items.AddRange(Rules.Lists.ModifierTypes)
            Ability.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
            SystemElement.Properties.Items.AddRange(SystemElementIndex)
            ObjectTypeLabel.Text = ""
            Modifier.SetValue(1)
            Modifier.ModifierSpin.Properties.MaxValue = 100
            Modifier.ModifierSpin.Properties.MinValue = 1
            Limiter.Properties.Items.AddRange(LimiterIndex)

            'Custom Formatters
            Percentage.Properties.DisplayFormat.Format = New Rules.PercentFormatter
            Percentage.Properties.EditFormat.Format = New Rules.PercentFormatter

            PropertiesTab.Init(mObject, mMode)

            General.SetNormalCursor()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Function InitAdd(ByVal Folder As Objects.ObjectData) As Boolean
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.SkillSynergyType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Skill Synergy"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

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
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Skill Synergy"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            Ranks.Text = mObject.Element("Ranks")
            SystemElement.SelectedIndex = Rules.Index.GetGuidIndex(SystemElementIndex, mObject.GetFKGuid("SystemElement"))
            If FocusObject.Properties.Enabled = True Then
                FocusObject.SelectedIndex = Rules.Index.GetGuidIndex(FocusIndex, mObject.GetFKGuid("FocusObject"))
            End If

            ModifierCategory.Text = mObject.Element("ModifierCategory")

            Select Case ModifierCategory.Text
                Case "Normal Modifier"
                    Modifier.Text = mObject.Element("Modifier")
                Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                    Ability.Text = mObject.Element("Modifier")
                Case "Percentage Modifier"
                    Percentage.Text = mObject.Element("Modifier")
                Case "Dice Range Modifier"
                    DiceRange.Text = mObject.Element("Modifier")
            End Select

            ModifierType.Text = mObject.Element("ModifierType")
            Limiter.SelectedIndex = Rules.Index.GetGuidIndex(LimiterIndex, mObject.GetFKGuid("Limiter"))

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
                        CharacterManager.SetAllDirty()
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Element("Ranks") = Ranks.Text
                mObject.FKElement("SystemElement", SystemElement.Text, "Name", SystemElementIndex(SystemElement.SelectedIndex).ObjectGUID)
                If FocusObject.Properties.Enabled Then
                    mObject.FKElement("FocusObject", FocusObject.Text, "Name", CType(FocusObject.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.FKSetNull("FocusObject")
                End If

                mObject.Element("ModifierCategory") = ModifierCategory.Text
                Select Case ModifierCategory.Text
                    Case "Normal Modifier"
                        mObject.Element("Modifier") = Modifier.Text
                    Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                        mObject.Element("Modifier") = Ability.Text
                    Case "Percentage Modifier"
                        mObject.Element("Modifier") = Percentage.Text
                    Case "Dice Range Modifier"
                        mObject.Element("Modifier") = DiceRange.Text
                End Select
                mObject.Element("ModifierType") = ModifierType.Text
                If Limiter.Text <> "" Then mObject.FKElement("Limiter", Limiter.Text, "Name", CType(Limiter.SelectedItem, DataListItem).ObjectGUID) Else mObject.FKSetNull("Limiter")

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                Select Case mMode
                    Case FormMode.Add
                        If Caches.SkillSynergiesCurrent Then Caches.SkillSynergies.Add(mObject)
                    Case FormMode.Edit
                        If Caches.SkillSynergiesCurrent Then Caches.SkillSynergies.Replace(mObject)
                End Select
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
        Dim Existing As Boolean = False

        Try
            Validate = General.ValidateForm(Me.Bonus.Controls, Errors)

            If Modifier.Enabled = True And Modifier.Text = "0" Then
                Errors.SetError(Modifier, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(Modifier, "")
            End If

            If Percentage.Properties.Enabled = True And Percentage.Text = "0%" Then
                Errors.SetError(Percentage, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(Percentage, "")
            End If

            If DiceRange.Properties.Enabled = True Then
                If Rules.Dice.ValidDiceRange(DiceRange) Then
                    Errors.SetError(DiceRange, "")
                Else
                    Errors.SetError(DiceRange, General.ValidationDiceRange)
                    Validate = False
                End If
            End If

            'check to see if there are any existing modifiers of this type
            If Not SystemElement.SelectedIndex = -1 And FocusObject.Enabled = False Then
                If Limiter.SelectedIndex = -1 Then
                    For Each Obj As Objects.ObjectData In mObject.Parent.ChildrenOfType(Objects.ModifierType)
                        If Not Obj.ObjectGUID.Equals(mObject.ObjectGUID) Then
                            If Obj.GetFKGuid("SystemElement").Equals(CType(SystemElement.SelectedItem, DataListItem).ObjectGUID) Then
                                Existing = True
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If

            If Existing Then
                Errors.SetError(Limiter, General.ValidationRequired)
                Validate = False
            Else
                Errors.SetError(Limiter, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control enabling and disabling"

    'load/hide the applies to object dropdown for this system element and filter categories
    Private Sub SystemElement_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SystemElement.SelectedIndexChanged
        Dim Obj As New Objects.ObjectData
        Dim Categories As New ArrayList

        Try
            'load applies to dropdown
            Obj.Load(SystemElementIndex(SystemElement.SelectedIndex).ObjectGUID)

            'determine whether there is a focus component
            If Obj.Element("HasFocus") = "Yes" Then
                'load the focus dropdown
                ObjectTypeLabel.Visible = True
                ObjectTypeLabel.Text = Objects.ObjectTypes.Item(Obj.Element("FocusType")).SelectLabel
                FocusObject.Visible = True
                FocusObject.Properties.Items.Clear()
                FocusObject.Properties.Enabled = True
                FocusObject.Text = ""

                'this line is different from modifier itself (exclude the parent skill)
                ExcludedFoci.Add(mObject.Parent.ObjectGUID)

                If Obj.Element("FocusType") = Objects.WeaponDefinitionType Then
                    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and (Shadows='' or BaseItem='')]", ExcludedFoci)
                Else
                    Dim FocusType As String = Obj.Element("FocusType")
                    FocusIndex = Rules.Index.DataListExclude(XML.MapTypeToDB(FocusType), FocusType, ExcludedFoci)
                End If
                If Not FocusIndex Is Nothing Then FocusObject.Properties.Items.AddRange(FocusIndex)
            Else
                'no focus
                FocusObject.Visible = False
                FocusObject.SelectedIndex = -1
                FocusObject.Properties.Enabled = False
                FocusObject.Text = ""
                ObjectTypeLabel.Visible = False
                ObjectTypeLabel.Text = ""
            End If

            'filter categories
            Categories.AddRange(Rules.Lists.ModifierCategories)
            If Obj.Element("AllowModifiers") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(0))
            If Obj.Element("AllowAbilityModifiers") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(1))
            If Obj.Element("AllowPositiveAbilityModifier") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(2))
            If Obj.Element("AllowPercentileModifier") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(3))
            If Obj.Element("AllowDiceRange") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(4))
            Categories.Remove(Rules.Lists.ModifierCategories(5))

            'new addition, done this way to avoid having to reset all the system elements
            If Not (Obj.Element("AllowComplex") = "Yes") Then Categories.Remove(Rules.Lists.ModifierCategories(5))

            ModifierCategory.Properties.Enabled = True
            ModifierCategory.Properties.Items.Clear()
            ModifierCategory.Properties.Items.AddRange(Categories.ToArray)
            If ModifierCategory.Properties.Items.Count = 1 Then ModifierCategory.SelectedIndex = 0

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ModifierCategory_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModifierCategory.EditValueChanged
        Try
            Select Case ModifierCategory.Text
                Case "Normal Modifier"
                    Modifier.Enabled = True
                    Modifier.BringToFront()
                    Ability.Properties.Enabled = False
                    Ability.SelectedIndex = -1
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 1
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Use Ability Modifier"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = True
                    Ability.BringToFront()
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 1
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Use Ability Modifier (positive only)"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = True
                    Ability.BringToFront()
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 1
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Use Ability Modifier (+1 minimum)"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = True
                    Ability.BringToFront()
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 1
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Percentage Modifier"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = False
                    Ability.SelectedIndex = -1
                    Percentage.Properties.Enabled = True
                    Percentage.BringToFront()
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Dice Range Modifier"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = False
                    Ability.SelectedIndex = -1
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 1
                    DiceRange.Properties.Enabled = True
                    DiceRange.BringToFront()
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

