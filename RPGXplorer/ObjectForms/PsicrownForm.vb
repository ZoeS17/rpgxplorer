Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class PsicrownForm
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
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    ' Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    ' Public WithEvents SpellList As RPGXplorer.ListBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents SpellBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents RemoveSpell As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    'Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents SpellList As RPGXplorer.ListBox
    Public WithEvents MarketPrice As RPGXplorer.MoneySpin
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents PsicrownTab As System.Windows.Forms.TabPage
    Public WithEvents PowersTab As System.Windows.Forms.TabPage
    Public WithEvents AddPower As System.Windows.Forms.Button
    Public WithEvents Points As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.PsicrownTab = New System.Windows.Forms.TabPage
        Me.MarketPrice = New RPGXplorer.MoneySpin
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.PowersTab = New System.Windows.Forms.TabPage
        Me.SpellList = New RPGXplorer.ListBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label6 = New System.Windows.Forms.Label
        Me.SpellBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.AddPower = New System.Windows.Forms.Button
        Me.RemoveSpell = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.Label5 = New System.Windows.Forms.Label
        Me.Points = New DevExpress.XtraEditors.SpinEdit
        Me.TabControl1.SuspendLayout()
        Me.PsicrownTab.SuspendLayout()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PowersTab.SuspendLayout()
        CType(Me.SpellBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Points.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.PsicrownTab)
        Me.TabControl1.Controls.Add(Me.PowersTab)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'PsicrownTab
        '
        Me.PsicrownTab.Controls.Add(Me.Points)
        Me.PsicrownTab.Controls.Add(Me.Label5)
        Me.PsicrownTab.Controls.Add(Me.MarketPrice)
        Me.PsicrownTab.Controls.Add(Me.IndentedLine2)
        Me.PsicrownTab.Controls.Add(Me.Description)
        Me.PsicrownTab.Controls.Add(Me.Label21)
        Me.PsicrownTab.Controls.Add(Me.Label4)
        Me.PsicrownTab.Controls.Add(Me.ObjectName)
        Me.PsicrownTab.Controls.Add(Me.Label2)
        Me.PsicrownTab.Location = New System.Drawing.Point(4, 22)
        Me.PsicrownTab.Name = "PsicrownTab"
        Me.PsicrownTab.Size = New System.Drawing.Size(407, 349)
        Me.PsicrownTab.TabIndex = 0
        Me.PsicrownTab.Text = "Psicrown"
        '
        'MarketPrice
        '
        Me.MarketPrice.Location = New System.Drawing.Point(105, 150)
        Me.MarketPrice.Name = "MarketPrice"
        Me.MarketPrice.Size = New System.Drawing.Size(190, 21)
        Me.MarketPrice.TabIndex = 262
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 255
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
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 254
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Market Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PowersTab
        '
        Me.PowersTab.Controls.Add(Me.SpellList)
        Me.PowersTab.Controls.Add(Me.IndentedLine1)
        Me.PowersTab.Controls.Add(Me.Label6)
        Me.PowersTab.Controls.Add(Me.SpellBox)
        Me.PowersTab.Controls.Add(Me.AddPower)
        Me.PowersTab.Controls.Add(Me.RemoveSpell)
        Me.PowersTab.Location = New System.Drawing.Point(4, 22)
        Me.PowersTab.Name = "PowersTab"
        Me.PowersTab.Size = New System.Drawing.Size(407, 349)
        Me.PowersTab.TabIndex = 2
        Me.PowersTab.Text = "Powers"
        '
        'SpellList
        '
        Me.SpellList.Location = New System.Drawing.Point(15, 65)
        Me.SpellList.Name = "SpellList"
        Me.SpellList.Size = New System.Drawing.Size(250, 265)
        Me.SpellList.TabIndex = 261
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(16, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 260
        Me.IndentedLine1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 21)
        Me.Label6.TabIndex = 256
        Me.Label6.Text = "Power"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellBox
        '
        Me.SpellBox.CausesValidation = False
        Me.SpellBox.Location = New System.Drawing.Point(60, 15)
        Me.SpellBox.Name = "SpellBox"
        '
        'SpellBox.Properties
        '
        Me.SpellBox.Properties.AutoHeight = False
        Me.SpellBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpellBox.Properties.DropDownRows = 10
        Me.SpellBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpellBox.Size = New System.Drawing.Size(200, 21)
        Me.SpellBox.TabIndex = 0
        '
        'AddPower
        '
        Me.AddPower.Location = New System.Drawing.Point(280, 65)
        Me.AddPower.Name = "AddPower"
        Me.AddPower.Size = New System.Drawing.Size(100, 24)
        Me.AddPower.TabIndex = 3
        Me.AddPower.Text = "Add Power"
        '
        'RemoveSpell
        '
        Me.RemoveSpell.Location = New System.Drawing.Point(280, 95)
        Me.RemoveSpell.Name = "RemoveSpell"
        Me.RemoveSpell.Size = New System.Drawing.Size(100, 24)
        Me.RemoveSpell.TabIndex = 4
        Me.RemoveSpell.Text = "Remove Power"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PropertiesTab)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(407, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 263
        Me.Label5.Text = "Power Points"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Points
        '
        Me.Points.CausesValidation = False
        Me.Points.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Points.Location = New System.Drawing.Point(105, 120)
        Me.Points.Name = "Points"
        '
        'Points.Properties
        '
        Me.Points.Properties.Appearance.Options.UseTextOptions = True
        Me.Points.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Points.Properties.AutoHeight = False
        Me.Points.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Points.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
        Me.Points.Properties.IsFloatValue = False
        Me.Points.Properties.Mask.EditMask = "d"
        Me.Points.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Points.Size = New System.Drawing.Size(60, 21)
        Me.Points.TabIndex = 264
        '
        'PsicrownForm
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
        Me.Name = "PsicrownForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffForm"
        Me.TabControl1.ResumeLayout(False)
        Me.PsicrownTab.ResumeLayout(False)
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PowersTab.ResumeLayout(False)
        CType(Me.SpellBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Points.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'Lists
    Private PowersIndex As Rules.Index.IndexEntry()

    'Child Objects
    Private ExistingPowers As New Objects.ObjectDataCollection
    Private CurrentPowers As New Objects.ObjectDataCollection

    'init
    Public Sub Init()

        Try
            'load the data lists
            PowersIndex = Rules.Index.Index(XML.DBTypes.Powers, Objects.PowerDefinitionType, False)

            'init controls
            SpellBox.Properties.Items.AddRange(Rules.Index.IndexNames(PowersIndex))
            MarketPrice.MaxGP = 999999

            'init the properties tab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init vars
            mFolder = Folder
            mMode = FormMode.Add
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Staffs)

            'init object
            mObject.Type = Objects.PsionicPsicrownDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Psicrown"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Psicrown"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'init controls
            ObjectName.Text = Obj.Name
            MarketPrice.Value = mObject.Element("MarketPrice")

            ExistingPowers = mObject.ChildrenOfType(Objects.PsicrownSpellType)
            For Each Child In ExistingPowers
                CurrentPowers.Add(Child)
                SpellList.AddItem(Child.Name, Child.ObjectGUID)
            Next

            Points.Value = Obj.ElementAsInteger("PowerPoints")
            Description.Text = Obj.Element("Description")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim obj As Objects.ObjectData

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
                mObject.Element("MarketPrice") = MarketPrice.Value

                For Each obj In ExistingPowers
                    If Not CurrentPowers.Contains(obj.ObjectGUID) Then obj.Delete()
                Next

                For Each obj In CurrentPowers
                    If ExistingPowers.Contains(obj.ObjectGUID) Then CurrentPowers.Remove(obj.ObjectGUID)
                Next
                CurrentPowers.Save()

                mObject.Element("PowerPoints") = Points.Value.ToString
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
            Validate = General.ValidateForm(Me.PsicrownTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.PowersTab.Controls, Errors)

            If MarketPrice.Money.InCopper = 0 Then
                Errors.SetError(MarketPrice, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(MarketPrice, "")
            End If

            If SpellList.Count = 0 Then
                Errors.SetError(SpellList, "Please provide at least 1 Spell.")
                Validate = False
            Else
                Errors.SetError(SpellList, "")
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

#Region "Tab Code"

    'add spell to list box
    Private Sub AddSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPower.Click
        Dim Obj, Spell As New Objects.ObjectData
        Dim ObjGuid As Objects.ObjectKey

        Try
            If SpellBox.SelectedIndex = -1 Then Exit Sub

            'Check if object as already been added
            ObjGuid = PowersIndex(SpellBox.SelectedIndex).ObjectGUID
            If CurrentPowers.ContainsFK("Power", ObjGuid) Then
                General.ShowInfoDialog("This Power has already been added.")
            Else
                Spell.Load(ObjGuid)
                Obj.Name = SpellBox.Text
                Obj.Type = Objects.PsicrownSpellType
                Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Staffs)
                Obj.ParentGUID = mObject.ObjectGUID
                Obj.HTMLGUID = Spell.ObjectGUID
                Obj.FKElement("Power", SpellBox.Text, "Name", ObjGuid)
                SpellList.AddItem(Obj.Name, Obj.ObjectGUID)
                CurrentPowers.Add(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove spell from list box
    Private Sub RemoveSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSpell.Click
        Try
            If SpellList.SelectedIndex = -1 Then Exit Sub
            CurrentPowers.Remove(SpellList.ItemGUID)
            SpellList.RemoveSelectedItem()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
