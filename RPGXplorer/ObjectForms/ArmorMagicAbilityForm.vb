Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class ArmorMagicAbilityForm
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
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents PriceBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PriceDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ArmorType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents MagicTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PriceSpecific As RPGXplorer.MoneySpin
    Public WithEvents Plus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MagicTab = New System.Windows.Forms.TabPage
        Me.Plus = New System.Windows.Forms.Label
        Me.PriceSpecific = New RPGXplorer.MoneySpin
        Me.ArmorType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.PriceDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.PriceBonus = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.MagicTab.SuspendLayout()
        CType(Me.ArmorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.MagicTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'MagicTab
        '
        Me.MagicTab.Controls.Add(Me.Plus)
        Me.MagicTab.Controls.Add(Me.PriceSpecific)
        Me.MagicTab.Controls.Add(Me.ArmorType)
        Me.MagicTab.Controls.Add(Me.Label3)
        Me.MagicTab.Controls.Add(Me.PriceDropdown)
        Me.MagicTab.Controls.Add(Me.IndentedLine2)
        Me.MagicTab.Controls.Add(Me.Description)
        Me.MagicTab.Controls.Add(Me.Label4)
        Me.MagicTab.Controls.Add(Me.PriceBonus)
        Me.MagicTab.Controls.Add(Me.Label1)
        Me.MagicTab.Controls.Add(Me.ObjectName)
        Me.MagicTab.Controls.Add(Me.Label2)
        Me.MagicTab.Location = New System.Drawing.Point(4, 22)
        Me.MagicTab.Name = "MagicTab"
        Me.MagicTab.Size = New System.Drawing.Size(407, 349)
        Me.MagicTab.TabIndex = 0
        Me.MagicTab.Text = "Magic Ability"
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(80, 180)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(10, 21)
        Me.Plus.TabIndex = 263
        Me.Plus.Text = "+"
        Me.Plus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Plus.Visible = False
        '
        'PriceSpecific
        '
        Me.PriceSpecific.Location = New System.Drawing.Point(95, 180)
        Me.PriceSpecific.Name = "PriceSpecific"
        Me.PriceSpecific.Size = New System.Drawing.Size(190, 21)
        Me.PriceSpecific.TabIndex = 262
        '
        'ArmorType
        '
        Me.ArmorType.Location = New System.Drawing.Point(95, 120)
        Me.ArmorType.Name = "ArmorType"
        '
        'ArmorType.Properties
        '
        Me.ArmorType.Properties.AutoHeight = False
        Me.ArmorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ArmorType.Properties.DropDownRows = 10
        Me.ArmorType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ArmorType.Size = New System.Drawing.Size(150, 21)
        Me.ArmorType.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "Applies To"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriceDropdown
        '
        Me.PriceDropdown.Location = New System.Drawing.Point(95, 150)
        Me.PriceDropdown.Name = "PriceDropdown"
        '
        'PriceDropdown.Properties
        '
        Me.PriceDropdown.Properties.AutoHeight = False
        Me.PriceDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PriceDropdown.Properties.DropDownRows = 10
        Me.PriceDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PriceDropdown.Size = New System.Drawing.Size(100, 21)
        Me.PriceDropdown.TabIndex = 6
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 218
        Me.IndentedLine2.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.Location = New System.Drawing.Point(95, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(295, 46)
        Me.Description.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriceBonus
        '
        Me.PriceBonus.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PriceBonus.Location = New System.Drawing.Point(205, 150)
        Me.PriceBonus.Name = "PriceBonus"
        '
        'PriceBonus.Properties
        '
        Me.PriceBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.PriceBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PriceBonus.Properties.AutoHeight = False
        Me.PriceBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.PriceBonus.Properties.DisplayFormat.FormatString = "+0;-0;0"
        Me.PriceBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceBonus.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.PriceBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriceBonus.Properties.IsFloatValue = False
        Me.PriceBonus.Properties.Mask.EditMask = "d"
        Me.PriceBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.PriceBonus.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
        Me.PriceBonus.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PriceBonus.Size = New System.Drawing.Size(50, 21)
        Me.PriceBonus.TabIndex = 8
        Me.PriceBonus.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Price Modifier"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(95, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(150, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'ArmorMagicAbilityForm
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
        Me.Name = "ArmorMagicAbilityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArmorMagicAbilityForm"
        Me.TabControl1.ResumeLayout(False)
        Me.MagicTab.ResumeLayout(False)
        CType(Me.ArmorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'DataLists
    Private SchoolDataList() As DataListItem

    'init
    Public Sub Init()
        Try
            'load the data lists
            SchoolDataList = Rules.Index.DataList(Xml.DBTypes.SpellSchools, Objects.SpellSchoolType)

            'populate ComboBoxEditers
            PriceDropdown.Properties.Items.AddRange(Rules.Lists.PriceTypes)
            ArmorType.Properties.Items.AddRange(Rules.Lists.ArmorTypes)

            'Custom Formatting
            PriceSpecific.MaxGP = 999999
            PriceDropdown.SelectedIndex = 0

            'init propertiestab
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.ArmorMagicAbilities)
            mObject.Type = Objects.ArmorMagicAbilityDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Armor Ability"
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
            Me.Text = "Edit Armor Ability"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            ObjectName.Text = Obj.Name
            ArmorType.Text = mObject.Element("ArmorType")
            PriceDropdown.Text = mObject.Element("PriceType")

            Select Case mObject.Element("PriceType")
                Case "Bonus"
                    PriceBonus.Value = mObject.ElementAsInteger("Price")
                Case "Specific"
                    PriceSpecific.Value = mObject.Element("Price").Replace("+", "")
            End Select

            Description.Text = Obj.Element("Description")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim obj As New Objects.ObjectData
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
                mObject.Name = ObjectName.Text
                mObject.Element("ArmorType") = ArmorType.Text

                Select Case PriceDropdown.Text
                    Case "Bonus"
                        mObject.Element("PriceType") = PriceDropdown.Text
                        mObject.Element("Price") = PriceBonus.Text
                    Case "Specific"
                        mObject.Element("PriceType") = PriceDropdown.Text
                        mObject.Element("Price") = "+" & PriceSpecific.Value
                End Select

                mObject.Element("Description") = Description.Text

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
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
            Validate = True

            Validate = Validate And General.ValidateForm(Me.MagicTab.Controls, Errors)

            If PriceSpecific.Visible = True And PriceSpecific.ValueInGP = 0 Then
                Errors.SetError(PriceSpecific, General.ValidationRequired)
                Validate = False
            Else
                Errors.SetError(PriceSpecific, "")
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Control Enabling and Disabling"

    'change between bonus and extra price tpyes of ability
    Private Sub PriceDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceDropdown.SelectedIndexChanged
        Try
            Select Case PriceDropdown.Text
                Case "Bonus"
                    PriceBonus.Value = 1
                    PriceBonus.Visible = True
                    PriceSpecific.Visible = False
                    Plus.Visible = False
                Case "Specific"
                    PriceSpecific.Text = ""
                    PriceSpecific.Visible = True
                    PriceBonus.Visible = False
                    Plus.Visible = True
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class





