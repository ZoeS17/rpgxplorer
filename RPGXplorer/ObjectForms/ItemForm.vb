Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ItemForm
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
    Public WithEvents CostLabel As System.Windows.Forms.Label
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents NameLabel As System.Windows.Forms.Label
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents TypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents ItemTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Cost As RPGXplorer.MoneySpin
    Public WithEvents Weight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IsContainer As System.Windows.Forms.CheckBox
    Public WithEvents AdjustForSize As System.Windows.Forms.CheckBox
    Public WithEvents DefaultUses As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ItemTab = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.DefaultUses = New DevExpress.XtraEditors.SpinEdit
        Me.AdjustForSize = New System.Windows.Forms.CheckBox
        Me.IsContainer = New System.Windows.Forms.CheckBox
        Me.Cost = New RPGXplorer.MoneySpin
        Me.Weight = New DevExpress.XtraEditors.SpinEdit
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.TypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ItemTab.SuspendLayout()
        CType(Me.DefaultUses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.ItemTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.Label2)
        Me.ItemTab.Controls.Add(Me.DefaultUses)
        Me.ItemTab.Controls.Add(Me.AdjustForSize)
        Me.ItemTab.Controls.Add(Me.IsContainer)
        Me.ItemTab.Controls.Add(Me.Cost)
        Me.ItemTab.Controls.Add(Me.Weight)
        Me.ItemTab.Controls.Add(Me.IndentedLine3)
        Me.ItemTab.Controls.Add(Me.Description)
        Me.ItemTab.Controls.Add(Me.Label3)
        Me.ItemTab.Controls.Add(Me.CostLabel)
        Me.ItemTab.Controls.Add(Me.WeightLabel)
        Me.ItemTab.Controls.Add(Me.TypeDropdown)
        Me.ItemTab.Controls.Add(Me.Label1)
        Me.ItemTab.Controls.Add(Me.ObjectName)
        Me.ItemTab.Controls.Add(Me.NameLabel)
        Me.ItemTab.Location = New System.Drawing.Point(4, 22)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(407, 349)
        Me.ItemTab.TabIndex = 0
        Me.ItemTab.Text = "Item"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Uses"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DefaultUses
        '
        Me.DefaultUses.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DefaultUses.Location = New System.Drawing.Point(85, 275)
        Me.DefaultUses.Name = "DefaultUses"
        '
        'DefaultUses.Properties
        '
        Me.DefaultUses.Properties.Appearance.Options.UseTextOptions = True
        Me.DefaultUses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DefaultUses.Properties.AutoHeight = False
        Me.DefaultUses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DefaultUses.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.DefaultUses.Properties.IsFloatValue = False
        Me.DefaultUses.Properties.Mask.BeepOnError = True
        Me.DefaultUses.Properties.Mask.EditMask = "d"
        Me.DefaultUses.Properties.Mask.ShowPlaceHolders = False
        Me.DefaultUses.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.DefaultUses.Size = New System.Drawing.Size(70, 21)
        Me.DefaultUses.TabIndex = 183
        '
        'AdjustForSize
        '
        Me.AdjustForSize.Location = New System.Drawing.Point(15, 240)
        Me.AdjustForSize.Name = "AdjustForSize"
        Me.AdjustForSize.Size = New System.Drawing.Size(140, 21)
        Me.AdjustForSize.TabIndex = 6
        Me.AdjustForSize.Text = "Adjust Weight for Size"
        '
        'IsContainer
        '
        Me.IsContainer.Location = New System.Drawing.Point(15, 210)
        Me.IsContainer.Name = "IsContainer"
        Me.IsContainer.Size = New System.Drawing.Size(104, 21)
        Me.IsContainer.TabIndex = 5
        Me.IsContainer.Text = "Is Container"
        '
        'Cost
        '
        Me.Cost.Location = New System.Drawing.Point(85, 150)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(180, 21)
        Me.Cost.TabIndex = 3
        '
        'Weight
        '
        Me.Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Weight.Location = New System.Drawing.Point(85, 180)
        Me.Weight.Name = "Weight"
        '
        'Weight.Properties
        '
        Me.Weight.Properties.Appearance.Options.UseTextOptions = True
        Me.Weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.Properties.AutoHeight = False
        Me.Weight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Weight.Properties.Mask.BeepOnError = True
        Me.Weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Weight.Properties.Mask.ShowPlaceHolders = False
        Me.Weight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Weight.Size = New System.Drawing.Size(70, 21)
        Me.Weight.TabIndex = 4
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(16, 105)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 182
        Me.IndentedLine3.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(295, 46)
        Me.Description.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostLabel
        '
        Me.CostLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CostLabel.Location = New System.Drawing.Point(15, 150)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(65, 21)
        Me.CostLabel.TabIndex = 176
        Me.CostLabel.Text = "Cost"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 180)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(65, 21)
        Me.WeightLabel.TabIndex = 175
        Me.WeightLabel.Text = "Weight"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TypeDropdown
        '
        Me.TypeDropdown.EditValue = ""
        Me.TypeDropdown.Location = New System.Drawing.Point(85, 120)
        Me.TypeDropdown.Name = "TypeDropdown"
        '
        'TypeDropdown.Properties
        '
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
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(85, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(150, 21)
        Me.ObjectName.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.NameLabel.Location = New System.Drawing.Point(15, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 21)
        Me.NameLabel.TabIndex = 172
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ItemForm
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
        Me.Name = "ItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.TabControl1.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        CType(Me.DefaultUses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()

        Try
            'populate ComboBoxEditors
            TypeDropdown.Properties.Items.AddRange(Rules.Lists.ItemTypes)

            'Custom Formatting
            Weight.Properties.DisplayFormat.Format = New Rules.WeightFormatter
            Cost.MaxGP = 99999

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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Items)
            mObject.Type = Objects.ItemDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Item"
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
            Me.Text = "Edit Item"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init Controls
            ObjectName.Text = Obj.Name
            Description.Text = Obj.Element("Description")
            If mObject.Element("IsContainer") = "Yes" Then IsContainer.Checked = True Else IsContainer.Checked = False
            TypeDropdown.Text = Obj.Element("ItemType")
            If mObject.Element("Weight") = "-" Then
                Weight.Value = 0
            Else
                Weight.Value = CDec(mObject.Element("Weight").Replace(" lb.", ""))
            End If
            If mObject.Element("Cost") = "-" Then
                Cost.Value = ""
            Else
                Cost.Value = Obj.Element("Cost")
            End If
            If mObject.Element("AdjustForSize") = "Yes" Then AdjustForSize.Checked = True
            If DefaultUses.Enabled Then DefaultUses.EditValue = mObject.ElementAsInteger("DefaultUses")

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
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject.Element("Description") = Description.Text
                If IsContainer.Checked Then mObject.Element("IsContainer") = "Yes" Else mObject.Element("IsContainer") = ""
                mObject.Element("ItemType") = TypeDropdown.Text
                If Weight.Value = 0 Then
                    mObject.Element("Weight") = "-"
                Else
                    mObject.Element("Weight") = Weight.Value.ToString & " lb."
                End If
                If Cost.Value Is Nothing Then
                    mObject.Element("Cost") = "-"
                Else
                    mObject.Element("Cost") = Cost.Value
                End If
                If AdjustForSize.Checked Then mObject.Element("AdjustForSize") = "Yes" Else mObject.Element("AdjustForSize") = ""
                If CInt(DefaultUses.EditValue) = 0 Then mObject.Element("DefaultUses") = "" Else mObject.Element("DefaultUses") = DefaultUses.Text

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
            Validate = General.ValidateForm(Me.ItemTab.Controls, Errors)

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

#Region "Event Handlers"

    Private Sub IsContainer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsContainer.CheckedChanged
        If IsContainer.Checked Then
            DefaultUses.Enabled = False
            DefaultUses.EditValue = 0
        Else
            DefaultUses.Enabled = True
        End If
    End Sub

#End Region

End Class
