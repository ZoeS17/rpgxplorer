Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class PsionicArtifactForm
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
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents IsContainer As System.Windows.Forms.CheckBox
    Public WithEvents Weight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents NonDimensional As System.Windows.Forms.CheckBox
    Public WithEvents ArtifactTab As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ArtifactTab = New System.Windows.Forms.TabPage
        Me.IsContainer = New System.Windows.Forms.CheckBox
        Me.Weight = New DevExpress.XtraEditors.SpinEdit
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.NonDimensional = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ArtifactTab.SuspendLayout()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.ArtifactTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ArtifactTab
        '
        Me.ArtifactTab.Controls.Add(Me.IsContainer)
        Me.ArtifactTab.Controls.Add(Me.Weight)
        Me.ArtifactTab.Controls.Add(Me.WeightLabel)
        Me.ArtifactTab.Controls.Add(Me.IndentedLine3)
        Me.ArtifactTab.Controls.Add(Me.Description)
        Me.ArtifactTab.Controls.Add(Me.Label21)
        Me.ArtifactTab.Controls.Add(Me.ObjectName)
        Me.ArtifactTab.Controls.Add(Me.Label2)
        Me.ArtifactTab.Controls.Add(Me.NonDimensional)
        Me.ArtifactTab.Location = New System.Drawing.Point(4, 22)
        Me.ArtifactTab.Name = "ArtifactTab"
        Me.ArtifactTab.Size = New System.Drawing.Size(407, 349)
        Me.ArtifactTab.TabIndex = 0
        Me.ArtifactTab.Text = "Psionic Artifact"
        '
        'IsContainer
        '
        Me.IsContainer.Location = New System.Drawing.Point(15, 150)
        Me.IsContainer.Name = "IsContainer"
        Me.IsContainer.Size = New System.Drawing.Size(104, 21)
        Me.IsContainer.TabIndex = 4
        Me.IsContainer.Text = "Is Container"
        '
        'Weight
        '
        Me.Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Weight.Location = New System.Drawing.Point(95, 120)
        Me.Weight.Name = "Weight"
        '
        'Weight.Properties
        '
        Me.Weight.Properties.Appearance.Options.UseTextOptions = True
        Me.Weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.Properties.AutoHeight = False
        Me.Weight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Weight.Properties.Mask.BeepOnError = True
        Me.Weight.Properties.Mask.EditMask = "F4"
        Me.Weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Weight.Properties.Mask.ShowPlaceHolders = False
        Me.Weight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Weight.Size = New System.Drawing.Size(100, 21)
        Me.Weight.TabIndex = 3
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 120)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(65, 21)
        Me.WeightLabel.TabIndex = 263
        Me.WeightLabel.Text = "Weight"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(16, 105)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 238
        Me.IndentedLine3.TabStop = False
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(95, 45)
        Me.Description.Name = "Description"
        '
        'Description.Properties
        '
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(295, 46)
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 237
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NonDimensional
        '
        Me.NonDimensional.Enabled = False
        Me.NonDimensional.Location = New System.Drawing.Point(30, 180)
        Me.NonDimensional.Name = "NonDimensional"
        Me.NonDimensional.Size = New System.Drawing.Size(195, 21)
        Me.NonDimensional.TabIndex = 5
        Me.NonDimensional.Text = "Contained Items Have No Weight"
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
        'PsionicArtifactForm
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
        Me.Name = "PsionicArtifactForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArtifactDefinition"
        Me.TabControl1.ResumeLayout(False)
        Me.ArtifactTab.ResumeLayout(False)
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        'Custom Formatting
        Weight.Properties.DisplayFormat.Format = New Rules.WeightFormatter

        'init the properties tab
        PropertiesTab.Init(mObject, mMode)
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        'init form vars
        mFolder = Folder
        mMode = FormMode.Add

        'init object
        mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Artifacts)
        mObject.Type = Objects.PsionicArtifactDefinitionType
        mObject.ParentGUID = mFolder.ObjectGUID

        'init form
        Me.Text = "Add Psionic Artifact"
        Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
        Init()
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        'init form vars
        mObject = Obj
        mMode = FormMode.Edit

        'init form
        Me.Text = "Edit Psionic Artifact"
        Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
        Init()

        'init controls
        ObjectName.Text = Obj.Name
        Description.Text = mObject.Element("Description")
        If mObject.Element("Weight") = "-" Then
            Weight.Value = 0
        Else
            Weight.Value = CDec(mObject.Element("Weight").Replace(" lb.", ""))
        End If
        If mObject.Element("IsContainer") = "Yes" Then
            IsContainer.Checked = True
            If mObject.Element("NonDimensionalContainer") = "Yes" Then NonDimensional.Checked = True
        End If

    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Me.Validate Then

            General.MainExplorer.Undo.UndoRecord()

            Select Case mMode
                Case FormMode.Add
                    'do nothing yet
                Case FormMode.Edit
                    CharacterManager.SetAllDirty()
            End Select

            'updates common to add and edit
            mObject.Name = ObjectName.Text
            mObject.Element("Description") = Description.Text
            If Weight.Value = 0 Then
                mObject.Element("Weight") = "-"
            Else
                mObject.Element("Weight") = Weight.Value.ToString & " lb."
            End If
            If IsContainer.Checked Then
                mObject.Element("IsContainer") = "Yes"
                If NonDimensional.Checked Then
                    mObject.Element("NonDimensionalContainer") = "Yes"
                Else
                    mObject.Element("NonDimensionalContainer") = ""
                End If
            Else
                mObject.Element("IsContainer") = ""
                mObject.Element("NonDimensionalContainer") = ""
            End If

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
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
    End Sub

    'show
    Public Shadows Sub Show()
        MyBase.Show()
        If Commands.EditForm Is Nothing Then
            Commands.EditForm = Me
        Else
            OK.Enabled = False : Me.Text = Me.Text.Replace("Edit", "View") : Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_green.ico")
        End If
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Commands.EditForm Is Me Then
            Commands.EditForm = Nothing
        End If
    End Sub

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Validate = General.ValidateForm(Me.ArtifactTab.Controls, Errors)

        If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
            If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                Errors.SetError(ObjectName, General.ValidationUniqueName)
                Validate = False
            Else
                Errors.SetError(ObjectName, "")
            End If
        End If

        General.ValidateFormIndicator(Validate, OK, Errors)

    End Function

#End Region

#Region "Control Enabling and Disabling"

    Private Sub IsContainer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsContainer.CheckedChanged
        If IsContainer.Checked Then
            NonDimensional.Enabled = True
        Else
            NonDimensional.Enabled = False
            NonDimensional.Checked = False
        End If
    End Sub

#End Region

End Class



