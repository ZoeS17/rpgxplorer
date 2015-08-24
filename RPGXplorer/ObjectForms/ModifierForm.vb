Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ModifierForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents ModifierType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SystemElement As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents FocusObject As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Modifier As RPGXplorer.Modifier
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ObjectTypeLabel As System.Windows.Forms.Label
    Public WithEvents Limiter As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents ModifierCategory As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Ability As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Percentage As DevExpress.XtraEditors.SpinEdit
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents ModifierTab As System.Windows.Forms.TabPage
    Public WithEvents DiceRange As DevExpress.XtraEditors.TextEdit
    Public WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Public WithEvents NotesLabel As System.Windows.Forms.Label
    Public WithEvents Complex As RPGXplorer.SetValue
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Cancel = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ModifierTab = New System.Windows.Forms.TabPage
        Me.Notes = New DevExpress.XtraEditors.MemoEdit
        Me.NotesLabel = New System.Windows.Forms.Label
        Me.DiceRange = New DevExpress.XtraEditors.TextEdit
        Me.Percentage = New DevExpress.XtraEditors.SpinEdit
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Ability = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.ModifierCategory = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Limiter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Modifier = New RPGXplorer.Modifier
        Me.Label4 = New System.Windows.Forms.Label
        Me.ObjectTypeLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ModifierType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.SystemElement = New DevExpress.XtraEditors.ComboBoxEdit
        Me.FocusObject = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Complex = New RPGXplorer.SetValue
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ModifierTab.SuspendLayout()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiceRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifierCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Limiter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifierType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemElement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FocusObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 435)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 435)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.ModifierTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 405)
        Me.TabControl1.TabIndex = 0
        '
        'ModifierTab
        '
        Me.ModifierTab.Controls.Add(Me.Notes)
        Me.ModifierTab.Controls.Add(Me.NotesLabel)
        Me.ModifierTab.Controls.Add(Me.DiceRange)
        Me.ModifierTab.Controls.Add(Me.Percentage)
        Me.ModifierTab.Controls.Add(Me.IndentedLine1)
        Me.ModifierTab.Controls.Add(Me.Ability)
        Me.ModifierTab.Controls.Add(Me.Label5)
        Me.ModifierTab.Controls.Add(Me.ModifierCategory)
        Me.ModifierTab.Controls.Add(Me.Limiter)
        Me.ModifierTab.Controls.Add(Me.Label3)
        Me.ModifierTab.Controls.Add(Me.Modifier)
        Me.ModifierTab.Controls.Add(Me.Label4)
        Me.ModifierTab.Controls.Add(Me.ObjectTypeLabel)
        Me.ModifierTab.Controls.Add(Me.Label1)
        Me.ModifierTab.Controls.Add(Me.ModifierType)
        Me.ModifierTab.Controls.Add(Me.Label2)
        Me.ModifierTab.Controls.Add(Me.SystemElement)
        Me.ModifierTab.Controls.Add(Me.FocusObject)
        Me.ModifierTab.Controls.Add(Me.Complex)
        Me.ModifierTab.Location = New System.Drawing.Point(4, 22)
        Me.ModifierTab.Name = "ModifierTab"
        Me.ModifierTab.Size = New System.Drawing.Size(407, 379)
        Me.ModifierTab.TabIndex = 2
        Me.ModifierTab.Text = "Modifier"
        '
        'Notes
        '
        Me.Notes.CausesValidation = False
        Me.Notes.EditValue = ""
        Me.Notes.Location = New System.Drawing.Point(95, 215)
        Me.Notes.Name = "Notes"
        Me.Notes.Properties.MaxLength = 200
        Me.Notes.Size = New System.Drawing.Size(295, 46)
        Me.Notes.TabIndex = 7
        Me.Notes.Visible = False
        '
        'NotesLabel
        '
        Me.NotesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.NotesLabel.Location = New System.Drawing.Point(16, 215)
        Me.NotesLabel.Name = "NotesLabel"
        Me.NotesLabel.Size = New System.Drawing.Size(65, 21)
        Me.NotesLabel.TabIndex = 188
        Me.NotesLabel.Text = "Notes"
        Me.NotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NotesLabel.Visible = False
        '
        'DiceRange
        '
        Me.DiceRange.Enabled = False
        Me.DiceRange.Location = New System.Drawing.Point(95, 125)
        Me.DiceRange.Name = "DiceRange"
        Me.DiceRange.Properties.Appearance.Options.UseTextOptions = True
        Me.DiceRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DiceRange.Properties.AutoHeight = False
        Me.DiceRange.Properties.MaxLength = 50
        Me.DiceRange.Size = New System.Drawing.Size(65, 21)
        Me.DiceRange.TabIndex = 4
        '
        'Percentage
        '
        Me.Percentage.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Percentage.Enabled = False
        Me.Percentage.Location = New System.Drawing.Point(95, 125)
        Me.Percentage.Name = "Percentage"
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
        Me.Percentage.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.Percentage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Percentage.Size = New System.Drawing.Size(65, 21)
        Me.Percentage.TabIndex = 4
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 130
        Me.IndentedLine1.TabStop = False
        '
        'Ability
        '
        Me.Ability.Enabled = False
        Me.Ability.Location = New System.Drawing.Point(95, 125)
        Me.Ability.Name = "Ability"
        Me.Ability.Properties.AutoHeight = False
        Me.Ability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ability.Properties.DropDownRows = 10
        Me.Ability.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Ability.Size = New System.Drawing.Size(65, 21)
        Me.Ability.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.CausesValidation = False
        Me.Label5.Location = New System.Drawing.Point(15, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Category"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModifierCategory
        '
        Me.ModifierCategory.Enabled = False
        Me.ModifierCategory.Location = New System.Drawing.Point(95, 95)
        Me.ModifierCategory.Name = "ModifierCategory"
        Me.ModifierCategory.Properties.AutoHeight = False
        Me.ModifierCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifierCategory.Properties.DropDownRows = 10
        Me.ModifierCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ModifierCategory.Size = New System.Drawing.Size(200, 21)
        Me.ModifierCategory.TabIndex = 2
        '
        'Limiter
        '
        Me.Limiter.CausesValidation = False
        Me.Limiter.Location = New System.Drawing.Point(95, 185)
        Me.Limiter.Name = "Limiter"
        Me.Limiter.Properties.AutoHeight = False
        Me.Limiter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Limiter.Properties.DropDownRows = 10
        Me.Limiter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Limiter.Size = New System.Drawing.Size(200, 21)
        Me.Limiter.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(15, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Limiter"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Modifier
        '
        Me.Modifier.Enabled = False
        Me.Modifier.Location = New System.Drawing.Point(95, 125)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(65, 21)
        Me.Modifier.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Applies To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectTypeLabel
        '
        Me.ObjectTypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjectTypeLabel.CausesValidation = False
        Me.ObjectTypeLabel.Location = New System.Drawing.Point(15, 45)
        Me.ObjectTypeLabel.Name = "ObjectTypeLabel"
        Me.ObjectTypeLabel.Size = New System.Drawing.Size(75, 21)
        Me.ObjectTypeLabel.TabIndex = 112
        Me.ObjectTypeLabel.Text = "[Object Type]"
        Me.ObjectTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ObjectTypeLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Modifier Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModifierType
        '
        Me.ModifierType.EditValue = "Undefined"
        Me.ModifierType.Location = New System.Drawing.Point(95, 155)
        Me.ModifierType.Name = "ModifierType"
        Me.ModifierType.Properties.AutoHeight = False
        Me.ModifierType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifierType.Properties.DropDownRows = 10
        Me.ModifierType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ModifierType.Size = New System.Drawing.Size(200, 21)
        Me.ModifierType.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Modifier"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SystemElement
        '
        Me.SystemElement.Location = New System.Drawing.Point(95, 15)
        Me.SystemElement.Name = "SystemElement"
        Me.SystemElement.Properties.AutoHeight = False
        Me.SystemElement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SystemElement.Properties.DropDownRows = 10
        Me.SystemElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SystemElement.Size = New System.Drawing.Size(200, 21)
        Me.SystemElement.TabIndex = 0
        '
        'FocusObject
        '
        Me.FocusObject.Enabled = False
        Me.FocusObject.Location = New System.Drawing.Point(95, 45)
        Me.FocusObject.Name = "FocusObject"
        Me.FocusObject.Properties.AutoHeight = False
        Me.FocusObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FocusObject.Properties.DropDownRows = 10
        Me.FocusObject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FocusObject.Size = New System.Drawing.Size(200, 21)
        Me.FocusObject.TabIndex = 1
        Me.FocusObject.Visible = False
        '
        'Complex
        '
        Me.Complex.AbilityMod = ""
        Me.Complex.BackColor = System.Drawing.SystemColors.Control
        Me.Complex.BaseNumber = 1
        Me.Complex.Location = New System.Drawing.Point(15, 125)
        Me.Complex.Name = "Complex"
        Me.Complex.PerLevelNumber = 0
        Me.Complex.Size = New System.Drawing.Size(390, 115)
        Me.Complex.TabIndex = 3
        Me.Complex.TagNumber = 0
        Me.Complex.TagString = ""
        Me.Complex.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 379)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'ModifierForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 473)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ModifierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifierForm"
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ModifierTab.ResumeLayout(False)
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiceRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Percentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifierCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Limiter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifierType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemElement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FocusObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private SaveNotes As Boolean = False

    Private UpdatePosition As Boolean = False
    Private ComplexSelected As Boolean = False

    'init
    Public Sub Init(Optional ByVal UserAdded As Boolean = False)
        Dim Existing As New Objects.ObjectDataCollection
        Dim Filtered As Objects.ObjectDataCollection
        Dim ExcludeList As New ArrayList
        Dim Parent As Objects.ObjectData

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
            Filtered = CommonLogic.AppropriateModifiers(Parent)

            'remove any system elements that already have a modifier in this folder
            'except if modifier has a focus then just add focus to list of excluded foci
            'or if there is a limiter.

            'If Not UserAdded Then
            '    Existing = mObject.Parent.ChildrenOfType(Objects.ModifierType)
            '    If Existing.Contains(mObject.ObjectGUID) Then Existing.Remove(mObject.ObjectGUID)

            '    For Each Obj In Existing
            '        If Obj.Element("FocusObject") = "" Then
            '            If Obj.Element("Limiter") = "" Then ExcludeList.Add(Obj.GetFKGuid("SystemElement"))
            '            'Else
            '            '    ExcludedFoci.Add(Obj.GetFKGuid("FocusObject"))
            '        End If
            '    Next
            'End If

            'always exclude speak language
            ExcludedFoci.Add(References.SpeakLanguage)

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
            Modifier.ModifierSpin.Properties.MinValue = -100
            Limiter.Properties.Items.AddRange(LimiterIndex)
            Complex.Init()

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
    Public Function InitAdd(ByVal Folder As Objects.ObjectData, Optional ByVal UserAdded As Boolean = False) As Boolean
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.ModifierType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Modifier"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init(UserAdded)

            'initialise controls
            NotesLabel.Visible = True
            Notes.Visible = True
            SaveNotes = True

            Return mInitOK

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData, Optional ByVal UserAdded As Boolean = False)
        Dim temp As String = ""

        Try
            'init form vars
            mObject = Obj
            mFolder = Obj.Parent
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Modifier"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init(UserAdded)

            'initialise controls
            SystemElement.SelectedIndex = Rules.Index.GetGuidIndex(SystemElementIndex, mObject.GetFKGuid("SystemElement"))
            If FocusObject.Properties.Enabled = True Then
                If mObject.Element("FocusObject") = "Feat Focus" Then
                    If mFolder.Element("FocusType") = "" Then
                        'modifier may have been pasted from a feat with a focus to a feat without.
                        FocusObject.SelectedIndex = -1
                    Else
                        FocusObject.SelectedIndex = 0
                    End If
                Else
                    FocusObject.SelectedIndex = Rules.Index.GetGuidIndex(FocusIndex, mObject.GetFKGuid("FocusObject"))
                    'Dim FocusListItem As New DataListItem(Nothing, mObject.GetFKGuid("FocusObject"), mObject.Element("FocusObject"))
                    'FocusObject.SelectedItem = FocusListItem
                End If
            End If

            ModifierCategory.Text = mObject.Element("ModifierCategory")

            Select Case ModifierCategory.Text
                Case "Normal Modifier"
                    Modifier.Text = mObject.Element("Modifier")
                Case "Use Ability Modifier", "Use Ability Modifier (positive only)"
                    Ability.Text = mObject.Element("Modifier")
                Case "Use Ability Modifier (+1 minimum)"
                    Ability.Text = mObject.Element("Modifier")
                Case "Percentage Modifier"
                    Percentage.Text = mObject.Element("Modifier").TrimEnd("%".ToCharArray)
                Case "Dice Range Modifier"
                    DiceRange.Text = mObject.Element("Modifier")
                Case "Complex Modifier"
                    Dim TempInt As Integer
                    Dim TempStr As String
                    Complex.BaseNumber = mObject.ElementAsInteger("BaseNumber")
                    TempInt = mObject.ElementAsInteger("PerLevel")
                    If TempInt > 0 Then
                        Complex.LevelCheck.CheckState = CheckState.Checked
                        Complex.PerLevelNumber = TempInt
                    End If
                    TempStr = mObject.Element("AbilityMod")
                    If TempStr <> "" Then
                        Complex.AbilityCheck.CheckState = CheckState.Checked
                        Complex.AbilityMod = TempStr
                    End If
                    TempStr = mObject.Element("TagString")
                    If TempStr <> "" Then
                        Complex.TagCheck.CheckState = CheckState.Checked
                        Complex.TagString = TempStr
                        Complex.TagNumber = mObject.ElementAsInteger("TagNumber")
                    End If
            End Select

            ModifierType.Text = mObject.Element("ModifierType")
            Limiter.SelectedIndex = Rules.Index.GetGuidIndex(LimiterIndex, mObject.GetFKGuid("Limiter"))

            NotesLabel.Visible = True
            Notes.Visible = True
            Notes.Text = mObject.Element("Notes")
            SaveNotes = True

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
                mObject.FKElement("SystemElement", SystemElement.Text, "Name", SystemElementIndex(SystemElement.SelectedIndex).ObjectGUID)

                If FocusObject.Properties.Enabled Then
                    If FocusObject.Text = "Feat Focus" Then
                        mObject.FKSetNull("FocusObject")
                        mObject.Element("FocusObject") = "Feat Focus"
                    Else
                        mObject.FKElement("FocusObject", FocusObject.Text, "Name", CType(FocusObject.SelectedItem, DataListItem).ObjectGUID)
                    End If
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
                    Case "Complex Modifier"
                        mObject.ElementAsInteger("BaseNumber") = Complex.BaseNumber
                        If Complex.PerLevelNumber > 0 Then mObject.ElementAsInteger("PerLevel") = Complex.PerLevelNumber
                        mObject.Element("AbilityMod") = Complex.AbilityMod
                        If Complex.TagCheck.CheckState = CheckState.Checked Then
                            mObject.ElementAsInteger("TagNumber") = Complex.TagNumber
                            mObject.Element("TagString") = Complex.TagString
                        End If

                End Select
                mObject.Element("ModifierType") = ModifierType.Text
                If Limiter.Text <> "" Then mObject.FKElement("Limiter", Limiter.Text, "Name", CType(Limiter.SelectedItem, DataListItem).ObjectGUID) Else mObject.FKSetNull("Limiter")

                If SaveNotes Then
                    mObject.Element("Notes") = Notes.Text
                End If

                mObject = PropertiesTab.UpdateObject(mObject)

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
        Dim Existing As Boolean = False

        Try
            Validate = General.ValidateForm(ModifierTab.Controls, Errors)

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

            'make sure its not a +0 modifier from a complex control
            If ComplexSelected AndAlso Complex.BaseNumber < 1 Then
                If Complex.PerLevelNumber < 1 And Complex.AbilityMod = "" And Complex.TagString = "" Then
                    Errors.SetError(Complex, General.ValidationRaceModifier1)
                    Validate = False
                Else
                    Errors.SetError(Complex, "")
                End If
            Else
                Errors.SetError(Complex, "")
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
        Dim ShowFeatFocus As Boolean

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

                ShowFeatFocus = False

                If mFolder.Type = Objects.FeatDefinitionType And mFolder.Element("FocusType") <> "" Then
                    Select Case mFolder.Element("FocusType")
                        Case "Alignment"
                            'do nothing
                        Case "Custom"
                            'do nothing
                        Case "Discipline Specialization"
                            If Obj.Element("FocusType") = Objects.PsionicSpecializationDefinitionType Then ShowFeatFocus = True
                        Case "Domain"
                            If Obj.Element("FocusType") = Objects.DomainDefinitionType Then ShowFeatFocus = True
                        Case "Power Discipline"
                            If Obj.Element("FocusType") = Objects.PsionicDisciplineType Then ShowFeatFocus = True
                        Case "Spell School"
                            If Obj.Element("FocusType") = Objects.SpellSchoolType Then ShowFeatFocus = True
                        Case "Skill"
                            If Obj.Element("FocusType") = Objects.SkillDefinitionType Then ShowFeatFocus = True
                        Case "Spell"
                            If Obj.Element("FocusType") = Objects.SpellDefinitionType Then ShowFeatFocus = True
                        Case "Power"
                            If Obj.Element("FocusType") = Objects.PowerDefinitionType Then ShowFeatFocus = True
                        Case Else
                            If Obj.Element("FocusType") = Objects.WeaponDefinitionType Then ShowFeatFocus = True
                    End Select
                End If

                If ShowFeatFocus Then
                    FocusObject.Properties.Items.Add("Feat Focus")
                    FocusObject.SelectedIndex = 0
                Else

                    Select Case Obj.Element("FocusType")

                        'Case "Spell School"
                        '    FocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType, ExcludedFoci)
                        'Case "Skill"
                        '    FocusIndex = Rules.Index.DataListExclude(Xml.DBTypes.Skills, Objects.SkillDefinitionType, ExcludedFoci)
                        'Case "Any Weapon", Objects.WeaponDefinitionType
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='']", ExcludedFoci)
                        'Case "Simple Weapon"
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Simple']", ExcludedFoci)
                        'Case "Exotic Weapon"
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Exotic']", ExcludedFoci)
                        'Case "Martial Weapon"
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='Martial']", ExcludedFoci)
                        'Case "Ranged Weapon"
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Ranged']", ExcludedFoci)
                        'Case "Melee Weapon"
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Melee']", ExcludedFoci)
                        'Case "Crossbow"
                        '    FocusIndex = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and WeaponType='Ranged']", ExcludedFoci)
                        'Case "Any Weapon"
                        '        Dim WeaponList As DataListItem() = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "']", ExcludedFoci)
                        '        Dim NaturalList As DataListItem() = Rules.Index.DataListXPathExclude(Xml.DBTypes.NaturalWeapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.NaturalWeaponDefinitionType & "']", ExcludedFoci)

                        '        'load the Focus Index
                        '        ReDim FocusIndex((WeaponList.GetLength(0) + NaturalList.GetLength(0)) - 1)
                        '        WeaponList.CopyTo(FocusIndex, 0)
                        '        NaturalList.CopyTo(FocusIndex, WeaponList.GetLength(0))

                        '        'sort
                        '        Array.Sort(FocusIndex)

                        Case Objects.WeaponDefinitionType
                            Dim WeaponList As DataListItem() = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "']", ExcludedFoci)

                            Dim NaturalList As DataListItem()
                            Dim TempList As New ArrayList
                            For Each NaturalAttack As String In Rules.Lists.NaturalAttackTypes

                                'create dummy datalist object
                                Dim DataListItem As DataListItem
                                'DataListItem = New DataListItem(Nothing, References.NaturalAttackFocus, NaturalAttack)
                                DataListItem = New DataListItem(Nothing, General.ConvertToObjectKey(NaturalAttack, Xml.DBTypes.NaturalWeapons), NaturalAttack)
                                TempList.Add(DataListItem)
                            Next
                            'ReDim NaturalList(TempList.Count - 1)
                            NaturalList = CType(TempList.ToArray(GetType(DataListItem)), DataListItem())

                            'load the Focus Index
                            ReDim FocusIndex((WeaponList.GetLength(0) + NaturalList.GetLength(0)) - 1)
                            WeaponList.CopyTo(FocusIndex, 0)
                            NaturalList.CopyTo(FocusIndex, WeaponList.GetLength(0))

                            'sort
                            Array.Sort(FocusIndex)

                        Case Else
                            Dim FocusType As String = Obj.Element("FocusType")
                            FocusIndex = Rules.Index.DataListExclude(XML.MapTypeToDB(FocusType), FocusType, ExcludedFoci)

                    End Select

                    FocusObject.Properties.Items.AddRange(FocusIndex)
                End If

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
            If Obj.Element("AllowPositiveAbilityModifier") = "No" Then
                Categories.Remove(Rules.Lists.ModifierCategories(2))
                Categories.Remove(Rules.Lists.ModifierCategories(3))
            End If
            If Obj.Element("AllowPercentileModifier") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(4))
            If Obj.Element("AllowDiceRange") = "No" Then Categories.Remove(Rules.Lists.ModifierCategories(5))

            'new addition, done this way to avoid having to reset all the system elements
            If Not (Obj.Element("AllowComplex") = "Yes") Then Categories.Remove(Rules.Lists.ModifierCategories(6))

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

            'if the complex control is up - reset it
            If ComplexSelected Then
                UpdatePosition = True
                Complex.LevelCheck.CheckState = CheckState.Unchecked
                Complex.AbilityCheck.CheckState = CheckState.Unchecked
                Complex.BaseNumber = 1
                Complex.Visible = False
                ComplexSelected = False
            End If

            Select Case ModifierCategory.Text
                Case "Normal Modifier"
                    Modifier.Enabled = True
                    Modifier.BringToFront()
                    Ability.Properties.Enabled = False
                    Ability.SelectedIndex = -1
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 0
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Use Ability Modifier"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = True
                    Ability.BringToFront()
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 0
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Use Ability Modifier (positive only)"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = True
                    Ability.BringToFront()
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 0
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                Case "Use Ability Modifier (+1 minimum)"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = True
                    Ability.BringToFront()
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 0
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
                    Percentage.EditValue = 0
                    DiceRange.Properties.Enabled = True
                    DiceRange.BringToFront()
                Case "Complex Modifier"
                    Modifier.Enabled = False
                    Modifier.SetValue(1)
                    Ability.Properties.Enabled = False
                    Ability.SelectedIndex = -1
                    Percentage.Properties.Enabled = False
                    Percentage.EditValue = 0
                    DiceRange.Enabled = False
                    DiceRange.Text = ""
                    Complex.BringToFront()
                    Complex.Visible = True

                    'set flags
                    ComplexSelected = True
                    UpdatePosition = True
            End Select

            If UpdatePosition Then ComplexUpdatePositions()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ComplexUpdatePositions()
        Dim Value As Integer
        Dim TempLocation As System.Drawing.Point

        UpdatePosition = False
        If ComplexSelected = True Then Value = 90 Else Value = -90

        'label1
        TempLocation = Label1.Location()
        TempLocation.Y = TempLocation.Y + Value
        Label1.Location = TempLocation

        'modifier type
        TempLocation = ModifierType.Location()
        TempLocation.Y = TempLocation.Y + Value
        ModifierType.Location = TempLocation

        'label3
        TempLocation = Label3.Location()
        TempLocation.Y = TempLocation.Y + Value
        Label3.Location = TempLocation

        'limiter
        TempLocation = Limiter.Location()
        TempLocation.Y = TempLocation.Y + Value
        Limiter.Location = TempLocation

        'notesLabel
        TempLocation = NotesLabel.Location()
        TempLocation.Y = TempLocation.Y + Value
        NotesLabel.Location = TempLocation

        'notes
        TempLocation = Notes.Location()
        TempLocation.Y = TempLocation.Y + Value
        Notes.Location = TempLocation
    End Sub

#End Region

End Class