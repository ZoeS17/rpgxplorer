Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.Rules
Imports RPGXplorer.General

Public Class PotionForm
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
    Public WithEvents BaseSpell As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents CasterLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ThreatRangeLabel As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents PotionTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents PotionCheck As System.Windows.Forms.CheckBox
    Public WithEvents OilCheck As System.Windows.Forms.CheckBox
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents Suggest As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.PotionTab = New System.Windows.Forms.TabPage
        Me.Suggest = New System.Windows.Forms.CheckBox
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.OilCheck = New System.Windows.Forms.CheckBox
        Me.PotionCheck = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CasterLevel = New DevExpress.XtraEditors.SpinEdit
        Me.ThreatRangeLabel = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.BaseSpell = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.PotionTab.SuspendLayout()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseSpell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.PotionTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'PotionTab
        '
        Me.PotionTab.Controls.Add(Me.Suggest)
        Me.PotionTab.Controls.Add(Me.MarketPrice)
        Me.PotionTab.Controls.Add(Me.OilCheck)
        Me.PotionTab.Controls.Add(Me.PotionCheck)
        Me.PotionTab.Controls.Add(Me.Label2)
        Me.PotionTab.Controls.Add(Me.CasterLevel)
        Me.PotionTab.Controls.Add(Me.ThreatRangeLabel)
        Me.PotionTab.Controls.Add(Me.ObjectName)
        Me.PotionTab.Controls.Add(Me.Label1)
        Me.PotionTab.Controls.Add(Me.BaseSpell)
        Me.PotionTab.Controls.Add(Me.Label4)
        Me.PotionTab.Location = New System.Drawing.Point(4, 22)
        Me.PotionTab.Name = "PotionTab"
        Me.PotionTab.Size = New System.Drawing.Size(407, 349)
        Me.PotionTab.TabIndex = 0
        Me.PotionTab.Text = "Potion or Oil"
        '
        'Suggest
        '
        Me.Suggest.Checked = True
        Me.Suggest.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Suggest.Location = New System.Drawing.Point(265, 15)
        Me.Suggest.Name = "Suggest"
        Me.Suggest.Size = New System.Drawing.Size(80, 21)
        Me.Suggest.TabIndex = 1
        Me.Suggest.Text = "Suggest"
        '
        'MarketPrice
        '
        Me.MarketPrice.CausesValidation = False
        Me.MarketPrice.Location = New System.Drawing.Point(95, 135)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 6
        '
        'OilCheck
        '
        Me.OilCheck.CausesValidation = False
        Me.OilCheck.Location = New System.Drawing.Point(160, 45)
        Me.OilCheck.Name = "OilCheck"
        Me.OilCheck.Size = New System.Drawing.Size(55, 21)
        Me.OilCheck.TabIndex = 3
        Me.OilCheck.Text = "Oil"
        '
        'PotionCheck
        '
        Me.PotionCheck.CausesValidation = False
        Me.PotionCheck.Checked = True
        Me.PotionCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PotionCheck.Location = New System.Drawing.Point(95, 45)
        Me.PotionCheck.Name = "PotionCheck"
        Me.PotionCheck.Size = New System.Drawing.Size(65, 21)
        Me.PotionCheck.TabIndex = 2
        Me.PotionCheck.Text = "Potion"
        '
        'Label2
        '
        Me.Label2.CausesValidation = False
        Me.Label2.Location = New System.Drawing.Point(15, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Market Price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CasterLevel
        '
        Me.CasterLevel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Location = New System.Drawing.Point(95, 105)
        Me.CasterLevel.Name = "CasterLevel"
        '
        'CasterLevel.Properties
        '
        Me.CasterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CasterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CasterLevel.Properties.AutoHeight = False
        Me.CasterLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CasterLevel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.CasterLevel.Properties.IsFloatValue = False
        Me.CasterLevel.Properties.Mask.BeepOnError = True
        Me.CasterLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CasterLevel.Properties.Mask.ShowPlaceHolders = False
        Me.CasterLevel.Properties.MaxLength = 2
        Me.CasterLevel.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.CasterLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CasterLevel.Size = New System.Drawing.Size(50, 21)
        Me.CasterLevel.TabIndex = 5
        '
        'ThreatRangeLabel
        '
        Me.ThreatRangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ThreatRangeLabel.CausesValidation = False
        Me.ThreatRangeLabel.Location = New System.Drawing.Point(15, 105)
        Me.ThreatRangeLabel.Name = "ThreatRangeLabel"
        Me.ThreatRangeLabel.Size = New System.Drawing.Size(75, 21)
        Me.ThreatRangeLabel.TabIndex = 234
        Me.ThreatRangeLabel.Text = "Caster Level"
        Me.ThreatRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label1
        '
        Me.Label1.CausesValidation = False
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BaseSpell
        '
        Me.BaseSpell.Location = New System.Drawing.Point(95, 75)
        Me.BaseSpell.Name = "BaseSpell"
        '
        'BaseSpell.Properties
        '
        Me.BaseSpell.Properties.AutoHeight = False
        Me.BaseSpell.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BaseSpell.Properties.DropDownRows = 10
        Me.BaseSpell.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BaseSpell.Size = New System.Drawing.Size(150, 21)
        Me.BaseSpell.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.CausesValidation = False
        Me.Label4.Location = New System.Drawing.Point(15, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "Base Spell"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'PotionForm
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
        Me.Name = "PotionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Potion"
        Me.TabControl1.ResumeLayout(False)
        Me.PotionTab.ResumeLayout(False)
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseSpell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private IsLoading As Boolean

    Private SpellsDataList As DataListItem()

    'init
    Public Sub Init()
        Dim Exclusions As New ArrayList

        Try
            'populate ComboBoxEditors
            For Each Spell As Objects.ObjectData In Objects.GetAllObjectsOfType(Xml.DBTypes.Spells, Objects.SpellDefinitionType)
                If Spell.Element("AllowPotion") = "" Then Exclusions.Add(Spell.ObjectGUID)
            Next
            SpellsDataList = Rules.Index.DataListExclude(Xml.DBTypes.Spells, Objects.SpellDefinitionType, Exclusions)
            BaseSpell.Properties.Items.AddRange(SpellsDataList)

            'Custom formatting
            Me.CasterLevel.Properties.DisplayFormat.Format = New LevelFormatter
            Me.CasterLevel.Properties.EditFormat.Format = New LevelFormatter
            MarketPrice.MaxGP = 999999

            'init the PropertiesTab
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
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.PotionsAndOils)
            mObject.Type = Objects.PotionDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Potion or Oil"
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
            Me.Text = "Edit Potion or Oil"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            Suggest.Checked = False
            ObjectName.Text = mObject.Name
            BaseSpell.SelectedIndex = Rules.Index.GetGuidIndex(SpellsDataList, mObject.GetFKGuid("BaseSpell"))
            CasterLevel.Value = mObject.ElementAsInteger("CasterLevel")
            MarketPrice.Value = mObject.Element("MarketPrice")

            IsLoading = True
            If mObject.Element("Potion") = "Yes" Then PotionCheck.CheckState = CheckState.Checked Else PotionCheck.CheckState = CheckState.Unchecked
            If mObject.Element("Oil") = "Yes" Then OilCheck.CheckState = CheckState.Checked Else OilCheck.CheckState = CheckState.Unchecked
            IsLoading = False

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
                mObject.FKElement("BaseSpell", BaseSpell.Text, "Name", CType(BaseSpell.SelectedItem, DataListItem).ObjectGUID)
                mObject.HTMLGUID = mObject.GetFKGuid("BaseSpell")
                mObject.Element("CasterLevel") = CasterLevel.Value.ToString
                mObject.Element("MarketPrice") = MarketPrice.Value
                If PotionCheck.CheckState = CheckState.Checked Then mObject.Element("Potion") = "Yes" Else mObject.Element("Potion") = ""
                If OilCheck.CheckState = CheckState.Checked Then mObject.Element("Oil") = "Yes" Else mObject.Element("Oil") = ""

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
            Validate = General.ValidateForm(PotionTab.Controls, Errors)

            If MarketPrice.ValueInGP = 0 Then
                Errors.SetError(MarketPrice, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(MarketPrice, "")
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

#Region "Event Handlers"

    Private Sub PotionCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PotionCheck.CheckedChanged
        Try
            If IsLoading Then Exit Sub
            If PotionCheck.Checked = True Then OilCheck.Checked = False
            If PotionCheck.Checked = False And OilCheck.Checked = False Then PotionCheck.Checked = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OilCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OilCheck.CheckedChanged
        Try
            If IsLoading Then Exit Sub
            If OilCheck.Checked = True Then PotionCheck.Checked = False
            If OilCheck.Checked = False And PotionCheck.Checked = False Then OilCheck.Checked = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub BaseSpell_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BaseSpell.SelectedIndexChanged
        Try
            If Suggest.Checked Then
                If OilCheck.Checked Then
                    ObjectName.Text = "Oil of " & BaseSpell.Text
                Else
                    ObjectName.Text = "Potion of " & BaseSpell.Text
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
