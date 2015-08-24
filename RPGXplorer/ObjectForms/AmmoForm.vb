Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports System.xml
Imports RPGXplorer.Rules.Dice

Public Class AmmoForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents CostLabel As System.Windows.Forms.Label
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents NameLabel As System.Windows.Forms.Label
	Public WithEvents TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents WeaponTab As System.Windows.Forms.TabPage
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Weight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Cost As RPGXplorer.MoneySpin
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.WeaponTab = New System.Windows.Forms.TabPage
        Me.Weight = New DevExpress.XtraEditors.SpinEdit
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Cost = New RPGXplorer.MoneySpin
        Me.TabControl1.SuspendLayout()
        Me.WeaponTab.SuspendLayout()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.WeaponTab)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'WeaponTab
        '
        Me.WeaponTab.Controls.Add(Me.Cost)
        Me.WeaponTab.Controls.Add(Me.Weight)
        Me.WeaponTab.Controls.Add(Me.Description)
        Me.WeaponTab.Controls.Add(Me.Label21)
        Me.WeaponTab.Controls.Add(Me.CostLabel)
        Me.WeaponTab.Controls.Add(Me.WeightLabel)
        Me.WeaponTab.Controls.Add(Me.IndentedLine1)
        Me.WeaponTab.Controls.Add(Me.ObjectName)
        Me.WeaponTab.Controls.Add(Me.NameLabel)
        Me.WeaponTab.Location = New System.Drawing.Point(4, 22)
        Me.WeaponTab.Name = "WeaponTab"
        Me.WeaponTab.Size = New System.Drawing.Size(407, 349)
        Me.WeaponTab.TabIndex = 0
        Me.WeaponTab.Text = "Ammunition"
        '
        'Cost
        '
        Me.Cost.Location = New System.Drawing.Point(85, 120)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(180, 21)
        Me.Cost.TabIndex = 3
        '
        'Weight
        '
        Me.Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Weight.Location = New System.Drawing.Point(85, 150)
        Me.Weight.Name = "Weight"
        Me.Weight.Properties.Appearance.Options.UseTextOptions = True
        Me.Weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.Properties.AutoHeight = False
        Me.Weight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Weight.Properties.Mask.EditMask = "f4"
        Me.Weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Weight.Properties.Mask.ShowPlaceHolders = False
        Me.Weight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Weight.Size = New System.Drawing.Size(100, 21)
        Me.Weight.TabIndex = 4
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(304, 46)
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 182
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostLabel
        '
        Me.CostLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CostLabel.Location = New System.Drawing.Point(15, 120)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(60, 21)
        Me.CostLabel.TabIndex = 167
        Me.CostLabel.Text = "Cost (S,M)"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 150)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(60, 21)
        Me.WeightLabel.TabIndex = 166
        Me.WeightLabel.Text = "Weight (M)"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 162
        Me.IndentedLine1.TabStop = False
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(85, 15)
        Me.ObjectName.Name = "ObjectName"
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
        Me.NameLabel.TabIndex = 107
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PropertiesTab)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(407, 349)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
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
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'AmmoForm
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
        Me.Name = "AmmoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AmmoForm"
        Me.TabControl1.ResumeLayout(False)
        Me.WeaponTab.ResumeLayout(False)
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
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
            'Custom Formatters
            Weight.Properties.DisplayFormat.Format = New Rules.WeightFormatter

            Cost.MaxGP = 9999

            'Init the properties tab
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Weapons)

            'init object
            mObject.Type = Objects.AmmoDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Ammunition Definition"
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
            Me.Text = "Edit Ammunition Definition"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = Obj.Name
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
            Description.Text = mObject.Element("Description")

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
                        'do nothing

                    Case FormMode.Edit
                        CharacterManager.SetAllDirty()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
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
                mObject.Element("WeaponType") = "Ammo"
                mObject.Element("Description") = Description.Text

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

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
            Validate = General.ValidateForm(Me.WeaponTab.Controls, Errors)

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

End Class




