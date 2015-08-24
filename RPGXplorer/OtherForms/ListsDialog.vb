Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ListsDialog
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
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents ListACaption As System.Windows.Forms.Label
    Public WithEvents ListBCaption As System.Windows.Forms.Label
    Public WithEvents AddButton As System.Windows.Forms.Button
    Public WithEvents RemoveButton As System.Windows.Forms.Button
    Public WithEvents ListCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents List As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents Value As DevExpress.XtraEditors.TextEdit
    Public WithEvents UpdateButton As System.Windows.Forms.Button
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListsDialog))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Value = New DevExpress.XtraEditors.TextEdit
        Me.ListCombo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.AddButton = New System.Windows.Forms.Button
        Me.List = New DevExpress.XtraEditors.ListBoxControl
        Me.ListACaption = New System.Windows.Forms.Label
        Me.ListBCaption = New System.Windows.Forms.Label
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.UpdateButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(335, 458)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(255, 458)
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
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 428)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Value)
        Me.TabPage1.Controls.Add(Me.ListCombo)
        Me.TabPage1.Controls.Add(Me.AddButton)
        Me.TabPage1.Controls.Add(Me.List)
        Me.TabPage1.Controls.Add(Me.ListACaption)
        Me.TabPage1.Controls.Add(Me.ListBCaption)
        Me.TabPage1.Controls.Add(Me.RemoveButton)
        Me.TabPage1.Controls.Add(Me.UpdateButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(382, 402)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Lists"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(35, 367)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(330, 20)
        Me.Label23.TabIndex = 311
        Me.Label23.Text = "Core system values cannot be altered or removed."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 310
        Me.PictureBox1.TabStop = False
        '
        'Value
        '
        Me.Value.EditValue = ""
        Me.Value.Location = New System.Drawing.Point(215, 80)
        Me.Value.Name = "Value"
        Me.Value.Properties.AutoHeight = False
        Me.Value.Size = New System.Drawing.Size(150, 21)
        Me.Value.TabIndex = 2
        '
        'ListCombo
        '
        Me.ListCombo.EditValue = ""
        Me.ListCombo.Location = New System.Drawing.Point(90, 15)
        Me.ListCombo.Name = "ListCombo"
        Me.ListCombo.Properties.AutoHeight = False
        Me.ListCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ListCombo.Properties.DropDownRows = 20
        Me.ListCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ListCombo.Size = New System.Drawing.Size(230, 21)
        Me.ListCombo.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(215, 115)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(115, 24)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add To List"
        '
        'List
        '
        Me.List.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.List.ItemHeight = 15
        Me.List.Location = New System.Drawing.Point(15, 80)
        Me.List.Name = "List"
        Me.List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.List.Size = New System.Drawing.Size(185, 275)
        Me.List.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.List.TabIndex = 1
        '
        'ListACaption
        '
        Me.ListACaption.Location = New System.Drawing.Point(15, 15)
        Me.ListACaption.Name = "ListACaption"
        Me.ListACaption.Size = New System.Drawing.Size(75, 21)
        Me.ListACaption.TabIndex = 1
        Me.ListACaption.Text = "Choose List"
        Me.ListACaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBCaption
        '
        Me.ListBCaption.Location = New System.Drawing.Point(15, 50)
        Me.ListBCaption.Name = "ListBCaption"
        Me.ListBCaption.Size = New System.Drawing.Size(185, 21)
        Me.ListBCaption.TabIndex = 1
        Me.ListBCaption.Text = "Values"
        Me.ListBCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveButton
        '
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.Location = New System.Drawing.Point(215, 180)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(115, 24)
        Me.RemoveButton.TabIndex = 5
        Me.RemoveButton.Text = "Remove Selected"
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(215, 145)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(115, 24)
        Me.UpdateButton.TabIndex = 4
        Me.UpdateButton.Text = "Update Selected"
        '
        'ListsDialog
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(419, 496)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit a List"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private CurrentList As String
    Private SuspendEvents As Boolean

#End Region

    'init
    Public Sub Init()
        Try
            UserLists.Load()

            'initialise controls
            ListCombo.Properties.Items.Add("Feat Types")
            ListCombo.Properties.Items.Add("Feature Types")
            ListCombo.Properties.Items.Add("Item Categories")
            ListCombo.Properties.Items.Add("Licenses")
            ListCombo.Properties.Items.Add("Monster Types")
            ListCombo.Properties.Items.Add("Natural Attack Types")
            ListCombo.Properties.Items.Add("Sourcebooks")
            ListCombo.Properties.Items.Add("User Tags")

            ListCombo.SelectedIndex = 0

        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            General.MainExplorer.Undo.UndoRecord()
            UserLists.UpdateLists()
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        Try
            Dim Add, Update, Delete As Boolean

            Add = True
            Update = True
            Delete = True

            If ListCombo.SelectedIndex = -1 Then
                Add = False
                Update = False
                Delete = False
            End If

            If List.SelectedIndex = -1 Then
                Update = False
                Delete = False
            End If

            If List.SelectedIndices.Count > 1 Then Update = False

            If List.SelectedIndices.Count > 0 Then
                Select Case ListCombo.Text
                    Case "Feat Types"
                        If General.ArrayStringFind(Rules.Lists.FeatTypesBase, List.SelectedItem.ToString) <> -1 Then
                            Update = False
                            Delete = False
                        End If
                    Case "Feature Types"
                        If General.ArrayStringFind(Rules.Lists.FeatureTypesBase, List.SelectedItem.ToString) <> -1 Then
                            Update = False
                            Delete = False
                        End If
                    Case "Item Categories"
                        If General.ArrayStringFind(Rules.Lists.ItemTypesBase, List.SelectedItem.ToString) <> -1 Then
                            Update = False
                            Delete = False
                        End If
                    Case "Monster Types"
                        If General.ArrayStringFind(Rules.Lists.MonsterTypesBase, List.SelectedItem.ToString) <> -1 Then
                            Update = False
                            Delete = False
                        End If
                    Case "Natural Attack Types"
                        If General.ArrayStringFind(Rules.Lists.NaturalAttackTypesBase, List.SelectedItem.ToString) <> -1 Then
                            Update = False
                            Delete = False
                        End If
                End Select
            End If

            For Each Item As String In List.Items
                If Value.Text = Item Then
                    Add = False
                    Exit For
                End If
            Next

            If Add Then AddButton.Enabled = True Else AddButton.Enabled = False
            If Update Then UpdateButton.Enabled = True Else UpdateButton.Enabled = False
            If Delete Then RemoveButton.Enabled = True Else RemoveButton.Enabled = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handlers"

    Private Sub ListCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListCombo.SelectedIndexChanged
        Try
            Dim Temp As ArrayList = Nothing

            Select Case ListCombo.Text
                Case "Feat Types"
                    Temp = UserLists.FeatTypes
                Case "Feature Types"
                    Temp = UserLists.FeatureTypes
                Case "Item Categories"
                    Temp = UserLists.ItemCategories
                Case "Licenses"
                    Temp = UserLists.Licenses
                Case "Monster Types"
                    Temp = UserLists.MonsterTypes
                Case "Sourcebooks"
                    Temp = UserLists.Sourcebooks
                Case "User Tags"
                    Temp = UserLists.UserTags
                Case "Natural Attack Types"
                    Temp = UserLists.NaturalAttackTypes
            End Select

            List.Items.Clear()

            If Not Temp Is Nothing Then
                For Each Item As String In Temp
                    List.Items.Add(Item)
                Next
            End If

            If List.Items.Count > 0 Then List.SelectedIndex = 0 Else Value.Text = ""

            CurrentList = ListCombo.Text

            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Try
            If Value.Text = "" Then Exit Sub

            If List.Items.IndexOf(Value.Text) = -1 Then
                List.Items.Add(Value.Text)
                Select Case ListCombo.Text
                    Case "Feat Types"
                        UserLists.FeatTypes.Add(Value.Text)
                    Case "Feature Types"
                        UserLists.FeatureTypes.Add(Value.Text)
                    Case "Item Categories"
                        UserLists.ItemCategories.Add(Value.Text)
                    Case "Licenses"
                        UserLists.Licenses.Add(Value.Text)
                    Case "Monster Types"
                        UserLists.MonsterTypes.Add(Value.Text)
                    Case "Sourcebooks"
                        UserLists.Sourcebooks.Add(Value.Text)
                    Case "User Tags"
                        UserLists.UserTags.Add(Value.Text)
                    Case "Natural Attack Types"
                        UserLists.NaturalAttackTypes.Add(Value.Text)
                End Select
                Value.Text = ""
                List.SelectedItem = Value.Text
                Value.Focus()
            Else
                General.ShowInfoDialog("This Item is already in the list.")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Try
            SuspendEvents = True

            Select Case ListCombo.Text
                Case "Feat Types"
                    UserLists.FeatTypes.Remove(List.SelectedItem.ToString)
                    UserLists.FeatTypes.Add(Value.Text)
                Case "Feature Types"
                    UserLists.FeatureTypes.Remove(List.SelectedItem.ToString)
                    UserLists.FeatureTypes.Add(Value.Text)
                Case "Item Categories"
                    UserLists.ItemCategories.Remove(List.SelectedItem.ToString)
                    UserLists.ItemCategories.Add(Value.Text)
                Case "Licenses"
                    UserLists.Licenses.Remove(List.SelectedItem.ToString)
                    UserLists.Licenses.Add(Value.Text)
                Case "Monster Types"
                    UserLists.MonsterTypes.Remove(List.SelectedItem.ToString)
                    UserLists.MonsterTypes.Add(Value.Text)
                Case "Sourcebooks"
                    UserLists.Sourcebooks.Remove(List.SelectedItem.ToString)
                    UserLists.Sourcebooks.Add(Value.Text)
                Case "User Tags"
                    UserLists.UserTags.Remove(List.SelectedItem.ToString)
                    UserLists.UserTags.Add(Value.Text)
                Case "Natural Attack Types"
                    UserLists.NaturalAttackTypes.Remove(List.SelectedItem.ToString)
                    UserLists.NaturalAttackTypes.Add(Value.Text)
            End Select

            List.Items.Remove(List.SelectedItem)
            List.Items.Add(Value.Text)
            List.SelectedItem = Value.Text
            SuspendEvents = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Try
            If List.SelectedIndices.Count = 0 Then Exit Sub

            Dim Deletions As New ArrayList

            For Each Index As Integer In List.SelectedIndices
                Deletions.Add(List.Items(Index))
            Next

0:          For Each Item As Object In Deletions
                List.Items.Remove(Item)

                Select Case ListCombo.Text
                    Case "Feat Types"
                        UserLists.FeatTypes.Remove(Item.ToString)
                    Case "Feature Types"
                        UserLists.FeatureTypes.Remove(Item.ToString)
                    Case "Item Categories"
                        UserLists.ItemCategories.Remove(Item.ToString)
                    Case "Licenses"
                        UserLists.Licenses.Remove(Item.ToString)
                    Case "Monster Types"
                        UserLists.MonsterTypes.Remove(Item.ToString)
                    Case "Sourcebooks"
                        UserLists.Sourcebooks.Remove(Item.ToString)
                    Case "User Tags"
                        UserLists.UserTags.Remove(Item.ToString)
                    Case "Natural Attack Types"
                        UserLists.NaturalAttackTypes.Remove(Item.ToString)
                End Select
            Next

            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub List_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List.SelectedIndexChanged
        Try
            If SuspendEvents Then Exit Sub

            If Not List.SelectedIndex = -1 Then
                If Not List.SelectedItem Is Nothing Then
                    Value.Text = List.SelectedItem.ToString
                End If
            End If

            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Value_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Value.EditValueChanged
        Try
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

