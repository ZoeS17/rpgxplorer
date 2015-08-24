Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class CustomItemForm
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
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents NameLabel As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ItemTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Weight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IsContainer As System.Windows.Forms.CheckBox
    Public WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Charges As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Quantity As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents CostLabel As System.Windows.Forms.Label
    Public WithEvents Cost As RPGXplorer.MoneySpin
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents BaseItemName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomItemForm))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ItemTab = New System.Windows.Forms.TabPage
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BaseItemName = New DevExpress.XtraEditors.TextEdit
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Charges = New DevExpress.XtraEditors.SpinEdit
        Me.Quantity = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.IsContainer = New System.Windows.Forms.CheckBox
        Me.Cost = New RPGXplorer.MoneySpin
        Me.Weight = New DevExpress.XtraEditors.SpinEdit
        Me.Notes = New DevExpress.XtraEditors.MemoEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ItemTab.SuspendLayout()
        CType(Me.BaseItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charges.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 385)
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
        Me.OK.Location = New System.Drawing.Point(280, 385)
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
        Me.TabControl1.Controls.Add(Me.ItemTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 355)
        Me.TabControl1.TabIndex = 0
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.Label23)
        Me.ItemTab.Controls.Add(Me.PictureBox1)
        Me.ItemTab.Controls.Add(Me.Label4)
        Me.ItemTab.Controls.Add(Me.BaseItemName)
        Me.ItemTab.Controls.Add(Me.IndentedLine1)
        Me.ItemTab.Controls.Add(Me.Charges)
        Me.ItemTab.Controls.Add(Me.Quantity)
        Me.ItemTab.Controls.Add(Me.Label2)
        Me.ItemTab.Controls.Add(Me.Label1)
        Me.ItemTab.Controls.Add(Me.IsContainer)
        Me.ItemTab.Controls.Add(Me.Cost)
        Me.ItemTab.Controls.Add(Me.Weight)
        Me.ItemTab.Controls.Add(Me.Notes)
        Me.ItemTab.Controls.Add(Me.Label3)
        Me.ItemTab.Controls.Add(Me.CostLabel)
        Me.ItemTab.Controls.Add(Me.WeightLabel)
        Me.ItemTab.Controls.Add(Me.ObjectName)
        Me.ItemTab.Controls.Add(Me.NameLabel)
        Me.ItemTab.Location = New System.Drawing.Point(4, 22)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(407, 329)
        Me.ItemTab.TabIndex = 0
        Me.ItemTab.Text = "Item"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(220, 125)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(175, 100)
        Me.Label23.TabIndex = 660
        Me.Label23.Text = "This form is not for equipping your character. It is for rapidly adding miscellan" & _
        "eous/unidentified items during play or character maintenance, or adjusting an it" & _
        "em to note changes e.g. breakage, used charges etc."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 659
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 658
        Me.Label4.Text = "Base Item"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseItemName
        '
        Me.BaseItemName.Enabled = False
        Me.BaseItemName.Location = New System.Drawing.Point(95, 45)
        Me.BaseItemName.Name = "BaseItemName"
        '
        'BaseItemName.Properties
        '
        Me.BaseItemName.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.BaseItemName.Properties.Appearance.Options.UseBackColor = True
        Me.BaseItemName.Properties.AutoHeight = False
        Me.BaseItemName.Properties.MaxLength = 100
        Me.BaseItemName.Size = New System.Drawing.Size(195, 21)
        Me.BaseItemName.TabIndex = 657
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 240)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 656
        Me.IndentedLine1.TabStop = False
        '
        'Charges
        '
        Me.Charges.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Charges.Location = New System.Drawing.Point(95, 205)
        Me.Charges.Name = "Charges"
        '
        'Charges.Properties
        '
        Me.Charges.Properties.Appearance.Options.UseTextOptions = True
        Me.Charges.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Charges.Properties.AutoHeight = False
        Me.Charges.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Charges.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Charges.Properties.IsFloatValue = False
        Me.Charges.Properties.Mask.EditMask = "d"
        Me.Charges.Properties.Mask.ShowPlaceHolders = False
        Me.Charges.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Charges.Size = New System.Drawing.Size(50, 21)
        Me.Charges.TabIndex = 5
        '
        'Quantity
        '
        Me.Quantity.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Location = New System.Drawing.Point(95, 175)
        Me.Quantity.Name = "Quantity"
        '
        'Quantity.Properties
        '
        Me.Quantity.Properties.Appearance.Options.UseTextOptions = True
        Me.Quantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Quantity.Properties.AutoHeight = False
        Me.Quantity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Quantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Quantity.Properties.IsFloatValue = False
        Me.Quantity.Properties.Mask.EditMask = "d"
        Me.Quantity.Properties.Mask.ShowPlaceHolders = False
        Me.Quantity.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Quantity.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Size = New System.Drawing.Size(50, 21)
        Me.Quantity.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Charges/Uses"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Quantity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IsContainer
        '
        Me.IsContainer.Location = New System.Drawing.Point(95, 140)
        Me.IsContainer.Name = "IsContainer"
        Me.IsContainer.Size = New System.Drawing.Size(104, 21)
        Me.IsContainer.TabIndex = 3
        Me.IsContainer.Text = "Is Container"
        '
        'Cost
        '
        Me.Cost.Location = New System.Drawing.Point(95, 75)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(195, 21)
        Me.Cost.TabIndex = 1
        '
        'Weight
        '
        Me.Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Weight.Location = New System.Drawing.Point(95, 105)
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
        Me.Weight.Size = New System.Drawing.Size(85, 21)
        Me.Weight.TabIndex = 2
        '
        'Notes
        '
        Me.Notes.CausesValidation = False
        Me.Notes.Location = New System.Drawing.Point(95, 255)
        Me.Notes.Name = "Notes"
        '
        'Notes.Properties
        '
        Me.Notes.Properties.MaxLength = 200
        Me.Notes.Size = New System.Drawing.Size(295, 46)
        Me.Notes.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Notes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostLabel
        '
        Me.CostLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CostLabel.Location = New System.Drawing.Point(15, 75)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(65, 21)
        Me.CostLabel.TabIndex = 176
        Me.CostLabel.Text = "Unit Cost"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 105)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(65, 21)
        Me.WeightLabel.TabIndex = 175
        Me.WeightLabel.Text = "Unit Weight"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ObjectName.Size = New System.Drawing.Size(195, 21)
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
        Me.TabPage1.Size = New System.Drawing.Size(407, 329)
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
        'CustomItemForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.TabControl1.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        CType(Me.BaseItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charges.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private Character As Rules.Character

    'init
    Public Sub Init()

        Try
            'Custom Formatting
            Weight.Properties.DisplayFormat.Format = New Rules.WeightFormatter
            Cost.MaxGP = 9999999

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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.ItemType
            mObject.ParentGUID = mFolder.ObjectGUID
            mObject.Element("ItemType") = "User"

            'init form
            Me.Text = "Add Custom Item"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Character = CharacterManager.GetCharacter(Folder.GetCharacterKey)
            Init()

            'init controls
            BaseItemName.Text = "User-Entered Item"

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
            Character = CharacterManager.GetCharacter(Obj.GetCharacterKey)
            Init()

            'init Controls
            Dim BaseItem As Objects.ObjectData = Obj.GetFKObject("Item")
            If BaseItem.IsEmpty And Not mObject.Element("ItemType") = Objects.ScrollDefinitionType Then
                BaseItemName.Text = "User-Entered Item"
                If Obj.Element("IsContainer") = "Yes" Then IsContainer.Checked = True
            Else
                BaseItemName.Text = BaseItem.Name
                Weight.Enabled = False
                Cost.Enabled = False
                IsContainer.Enabled = False
                Select Case BaseItem.Type
                    Case Objects.ItemDefinitionType
                        If BaseItem.Element("IsContainer") = "Yes" Then
                            IsContainer.Checked = True
                            Quantity.Enabled = False
                            Charges.Enabled = False
                        Else
                            IsContainer.Checked = False
                            Quantity.Enabled = True
                            Charges.Enabled = True
                        End If
                    Case Objects.RodDefinitionType, Objects.RingDefinitionType, Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.StaffDefinitionType, Objects.WandDefinitionType, Objects.SpecificWeaponDefinitionType
                        Charges.Enabled = True
                        Quantity.Enabled = False
                    Case Objects.PotionDefinitionType, Objects.MagicAmmoDefinitionType, Objects.AmmoDefinitionType, Objects.WeaponDefinitionType
                        Charges.Enabled = False
                        Quantity.Enabled = True
                    Case Else
                        Charges.Enabled = False
                        Quantity.Enabled = False
                End Select
            End If

            ObjectName.Text = Obj.Name

            Weight.Value = CDec(mObject.Element("BaseWeight").Replace(" lb.", ""))
            Cost.Value = Obj.Element("BaseCost")

            If Quantity.Enabled Then Quantity.EditValue = mObject.ElementAsInteger("Quantity")
            If Charges.Enabled Then Charges.EditValue = mObject.ElementAsInteger("Charges")
            Notes.Text = Obj.Element("Notes")

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
                If Weight.Enabled Then
                    mObject.Element("BaseWeight") = Rules.Formatting.FormatPounds(CDbl(Weight.EditValue))
                    mObject.Element("BaseCost") = Cost.Money.DisplayString
                End If
                mObject = Rules.Inventory.AdjustQuantity(mObject, CInt(Quantity.EditValue))
                mObject.Name = ObjectName.Text

                If IsContainer.Enabled Then
                    If IsContainer.Checked Then
                        mObject.Element("IsContainer") = "Yes"
                    Else
                        mObject.Element("IsContainer") = ""
                    End If
                End If
                mObject.ElementAsInteger("Quantity") = CInt(Quantity.EditValue)
                If CInt(Charges.EditValue) = 0 Then
                    mObject.Element("Charges") = ""
                Else
                    mObject.ElementAsInteger("Charges") = CInt(Charges.EditValue)
                End If
                mObject.Element("Notes") = Notes.Text

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
                If IsContainer.Checked Then
                    If mMode = FormMode.Add Then
                        General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                    ElseIf mMode = FormMode.Edit Then
                        General.MainExplorer.RefreshRenamedNode(mObject.ObjectGUID, mObject.Name)
                    End If
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
            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

    Private Sub IsContainer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsContainer.CheckedChanged
        Try
            If IsContainer.Enabled Then
                If IsContainer.Checked Then
                    Quantity.Enabled = False
                    Quantity.EditValue = 1
                    Charges.Enabled = False
                    Charges.EditValue = 0
                Else
                    If mMode = FormMode.Edit Then
                        If mObject.HasChildren Then
                            General.ShowInfoDialog("The container is not empty. Please move or remove items within it first.")
                            IsContainer.Checked = True
                            Exit Sub
                        End If
                    End If
                    Quantity.Enabled = True
                    Charges.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Quantity_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quantity.EditValueChanged
        Try
            If Charges.Enabled Then
                If CInt(Charges.EditValue) > 0 Then
                    Charges.EditValue = 0
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Charges_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Charges.EditValueChanged
        Try
            If Quantity.Enabled Then
                If CInt(Quantity.EditValue) > 1 Then
                    Quantity.EditValue = 1
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
