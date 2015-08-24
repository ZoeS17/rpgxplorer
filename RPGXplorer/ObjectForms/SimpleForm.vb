Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SimpleForm
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
    Public WithEvents ItemTab As System.Windows.Forms.TabPage
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ItemTab = New System.Windows.Forms.TabPage
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.ItemTab.SuspendLayout()
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
        Me.ItemTab.Controls.Add(Me.ObjectName)
        Me.ItemTab.Controls.Add(Me.ObjLabel)
        Me.ItemTab.Location = New System.Drawing.Point(4, 22)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(407, 349)
        Me.ItemTab.TabIndex = 0
        Me.ItemTab.Text = "Item"
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(90, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 200
        Me.ObjectName.Size = New System.Drawing.Size(295, 21)
        Me.ObjectName.TabIndex = 93
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(80, 21)
        Me.ObjLabel.TabIndex = 94
        Me.ObjLabel.Text = "Label"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 349)
        Me.PropertiesTab.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'SimpleForm
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
        Me.Name = "SimpleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.TabControl1.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode
    Private mType As String

    'init
    Public Sub Init()
        Try
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData, ByVal Type As String, ByVal ShortFriendly As String, ByVal Database As Integer)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add
            mType = Type

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Database)
            mObject.Type = mType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add " & Objects.ObjectTypes.Item(Type).Friendly
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls
            ObjLabel.Text = ShortFriendly
            ItemTab.Text = ShortFriendly

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData, ByVal Type As String, ByVal ShortFriendly As String)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit
            mType = Type

            'init form
            Me.Text = "Edit " & Objects.ObjectTypes.Item(Type).Friendly
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjLabel.Text = ShortFriendly
            ItemTab.Text = ShortFriendly

            ObjectName.Text = Obj.Name

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

                        'if this is a spell category - we have extra to do
                        If mObject.Type = Objects.SpellCategoryDefinitionType Then
                            Dim FolderSpellList As New Objects.ObjectData
                            FolderSpellList.Name = "Spell List"
                            FolderSpellList.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.SpellCategoriesAndDescriptors)
                            FolderSpellList.Type = Objects.SpellListFolderType
                            FolderSpellList.ParentGUID = mObject.ObjectGUID
                            FolderSpellList.Save()
                        End If

                        CharacterManager.SetAllDirty()

                    Case FormMode.Edit

                        If mObject.Type = Objects.SpellCategoryDefinitionType Then
                            If mObject.ChildrenOfType(Objects.SpellListFolderType).Count = 0 Then
                                'add Spell List Folder
                                Dim FolderSpellList As New Objects.ObjectData
                                FolderSpellList.Name = "Spell List"
                                FolderSpellList.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.SpellCategoriesAndDescriptors)
                                FolderSpellList.Type = Objects.SpellListFolderType
                                FolderSpellList.ParentGUID = mObject.ObjectGUID
                                FolderSpellList.Save()
                            End If
                        End If

                        CharacterManager.SetAllDirty()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                General.MainExplorer.RefreshPanel()

                If Objects.ObjectTypes.Item(mType).ShowInTree Then
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
            Validate = General.ValidateForm(Me.Controls, Errors)

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
