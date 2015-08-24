Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class DorjeForm
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
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents RangeLabel As System.Windows.Forms.Label
    Public WithEvents PropertiesTabPage As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents Suggest As System.Windows.Forms.CheckBox
    Public WithEvents DorjeTab As System.Windows.Forms.TabPage
    Public WithEvents ManifesterLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents BasePower As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.DorjeTab = New System.Windows.Forms.TabPage
        Me.Suggest = New System.Windows.Forms.CheckBox
        Me.ManifesterLevel = New DevExpress.XtraEditors.SpinEdit
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.RangeLabel = New System.Windows.Forms.Label
        Me.BasePower = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.PropertiesTabPage = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.DorjeTab.SuspendLayout()
        CType(Me.ManifesterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasePower.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropertiesTabPage.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.DorjeTab)
        Me.TabControl1.Controls.Add(Me.PropertiesTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'DorjeTab
        '
        Me.DorjeTab.Controls.Add(Me.Suggest)
        Me.DorjeTab.Controls.Add(Me.ManifesterLevel)
        Me.DorjeTab.Controls.Add(Me.MarketPrice)
        Me.DorjeTab.Controls.Add(Me.IndentedLine2)
        Me.DorjeTab.Controls.Add(Me.Description)
        Me.DorjeTab.Controls.Add(Me.Label21)
        Me.DorjeTab.Controls.Add(Me.RangeLabel)
        Me.DorjeTab.Controls.Add(Me.BasePower)
        Me.DorjeTab.Controls.Add(Me.Label4)
        Me.DorjeTab.Controls.Add(Me.Label1)
        Me.DorjeTab.Controls.Add(Me.ObjectName)
        Me.DorjeTab.Controls.Add(Me.Label2)
        Me.DorjeTab.Location = New System.Drawing.Point(4, 22)
        Me.DorjeTab.Name = "DorjeTab"
        Me.DorjeTab.Size = New System.Drawing.Size(407, 349)
        Me.DorjeTab.TabIndex = 0
        Me.DorjeTab.Text = "Dorje"
        '
        'Suggest
        '
        Me.Suggest.Checked = True
        Me.Suggest.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Suggest.Location = New System.Drawing.Point(315, 15)
        Me.Suggest.Name = "Suggest"
        Me.Suggest.Size = New System.Drawing.Size(80, 21)
        Me.Suggest.TabIndex = 1
        Me.Suggest.Text = "Suggest"
        '
        'ManifesterLevel
        '
        Me.ManifesterLevel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ManifesterLevel.Location = New System.Drawing.Point(105, 150)
        Me.ManifesterLevel.Name = "ManifesterLevel"
        '
        'ManifesterLevel.Properties
        '
        Me.ManifesterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.ManifesterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ManifesterLevel.Properties.AutoHeight = False
        Me.ManifesterLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ManifesterLevel.Properties.IsFloatValue = False
        Me.ManifesterLevel.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ManifesterLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ManifesterLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ManifesterLevel.Size = New System.Drawing.Size(50, 21)
        Me.ManifesterLevel.TabIndex = 4
        '
        'MarketPrice
        '
        Me.MarketPrice.Location = New System.Drawing.Point(105, 180)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 5
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 258
        Me.IndentedLine2.TabStop = False
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
        Me.Description.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 257
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RangeLabel
        '
        Me.RangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.RangeLabel.Location = New System.Drawing.Point(15, 150)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(90, 21)
        Me.RangeLabel.TabIndex = 234
        Me.RangeLabel.Text = "Manifester Level"
        Me.RangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BasePower
        '
        Me.BasePower.Location = New System.Drawing.Point(105, 120)
        Me.BasePower.Name = "BasePower"
        '
        'BasePower.Properties
        '
        Me.BasePower.Properties.AutoHeight = False
        Me.BasePower.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BasePower.Properties.DropDownRows = 10
        Me.BasePower.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BasePower.Size = New System.Drawing.Size(200, 21)
        Me.BasePower.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 232
        Me.Label4.Text = "Base Power"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "Market Price"
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
        Me.ObjectName.Properties.MaxLength = 75
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PropertiesTabPage
        '
        Me.PropertiesTabPage.Controls.Add(Me.PropertiesTab)
        Me.PropertiesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PropertiesTabPage.Name = "PropertiesTabPage"
        Me.PropertiesTabPage.Size = New System.Drawing.Size(407, 349)
        Me.PropertiesTabPage.TabIndex = 1
        Me.PropertiesTabPage.Text = "Properties"
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
        'DorjeForm
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
        Me.Name = "DorjeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WandForm"
        Me.TabControl1.ResumeLayout(False)
        Me.DorjeTab.ResumeLayout(False)
        CType(Me.ManifesterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasePower.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropertiesTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'Lists
    Private PowersIndex As Rules.Index.IndexEntry()
    Private PowersDataList As DataListItem()

    'init
    Public Sub Init()

        Try 'Load List
            PowersIndex = Rules.Index.Index(XML.DBTypes.Powers, Objects.PowerDefinitionType, False)

            'Populate ComboBoxEditors
            BasePower.Properties.Items.AddRange(Rules.Index.IndexNames(PowersIndex))

            'Custom Formatters
            Me.ManifesterLevel.Properties.DisplayFormat.Format = New Rules.LevelFormatter
            Me.ManifesterLevel.Properties.EditFormat.Format = New Rules.LevelFormatter
            MarketPrice.MaxGP = 999999

            'init propertied tab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'int from vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Wands)
            mObject.Type = Objects.PsionicDorjeDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'int form
            Me.Text = "Add Dorje"
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
            Me.Text = "Edit Dorje"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()
            Suggest.Checked = False

            'init controls
            ObjectName.Text = Obj.Name
            Description.Text = mObject.Element("Description")
            BasePower.Text = mObject.Element("Power")
            ManifesterLevel.Value = mObject.ElementAsInteger("ManifesterLevel")
            MarketPrice.Value = mObject.Element("MarketPrice")

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
                mObject.Name = ObjectName.Text
                mObject.HTMLGUID = PowersIndex(BasePower.SelectedIndex).ObjectGUID
                mObject.Element("MarketPrice") = MarketPrice.Value
                mObject.Element("ManifesterLevel") = ManifesterLevel.Value.ToString
                mObject.FKElement("Power", BasePower.Text, "Name", PowersIndex(BasePower.SelectedIndex).ObjectGUID)
                mObject.Element("Description") = Description.Text
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
        Try
            Validate = General.ValidateForm(Me.DorjeTab.Controls, Errors)

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

    Private Sub BaseSpell_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasePower.SelectedIndexChanged
        Try
            If Suggest.Checked Then
                ObjectName.Text = "Dorje of " & BasePower.Text
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
