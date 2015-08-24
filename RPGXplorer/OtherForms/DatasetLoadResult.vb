Option Explicit On 
Option Strict On

Public Class DatasetLoadResult
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
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents ContinueButton As System.Windows.Forms.Button
    Public WithEvents NewComponents As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Public WithEvents OverwrittenView As System.Windows.Forms.ListView
    Public WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents Path As System.Windows.Forms.ColumnHeader
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents Analyse As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatasetLoadResult))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.ContinueButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.OverwrittenView = New System.Windows.Forms.ListView
        Me.Path = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Analyse = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NewComponents = New DevExpress.XtraEditors.ListBoxControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NewComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 30)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(635, 335)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 24)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(0, 317)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(790, 5)
        Me.IndentedLine1.TabIndex = 5
        '
        'ContinueButton
        '
        Me.ContinueButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContinueButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ContinueButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueButton.Location = New System.Drawing.Point(525, 335)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(100, 24)
        Me.ContinueButton.TabIndex = 3
        Me.ContinueButton.Text = "Continue"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(35, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "This dataset contains the following new components and characters."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "The dataset contains the following changed components. Checked items will overwri" & _
            "te matching components."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(10, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 30)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.OverwrittenView)
        Me.PanelControl1.Location = New System.Drawing.Point(10, 50)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(725, 255)
        Me.PanelControl1.TabIndex = 9
        '
        'OverwrittenView
        '
        Me.OverwrittenView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OverwrittenView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverwrittenView.CheckBoxes = True
        Me.OverwrittenView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Path})
        Me.OverwrittenView.FullRowSelect = True
        Me.OverwrittenView.Location = New System.Drawing.Point(2, 2)
        Me.OverwrittenView.Name = "OverwrittenView"
        Me.OverwrittenView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OverwrittenView.Size = New System.Drawing.Size(721, 251)
        Me.OverwrittenView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.OverwrittenView.TabIndex = 0
        Me.OverwrittenView.UseCompatibleStateImageBehavior = False
        Me.OverwrittenView.View = System.Windows.Forms.View.Details
        '
        'Path
        '
        Me.Path.Text = "Changed Component (check to overwrite existing)"
        Me.Path.Width = 704
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(455, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select All"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(540, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Deselect All"
        '
        'Analyse
        '
        Me.Analyse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Analyse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Analyse.Location = New System.Drawing.Point(625, 15)
        Me.Analyse.Name = "Analyse"
        Me.Analyse.Size = New System.Drawing.Size(110, 24)
        Me.Analyse.TabIndex = 2
        Me.Analyse.Text = "Show Changes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.NewComponents)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 281)
        Me.Panel1.TabIndex = 14
        '
        'NewComponents
        '
        Me.NewComponents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewComponents.ItemHeight = 15
        Me.NewComponents.Location = New System.Drawing.Point(10, 45)
        Me.NewComponents.Name = "NewComponents"
        Me.NewComponents.Size = New System.Drawing.Size(725, 225)
        Me.NewComponents.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.NewComponents.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Cancel)
        Me.Panel2.Controls.Add(Me.IndentedLine1)
        Me.Panel2.Controls.Add(Me.ContinueButton)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PanelControl1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Analyse)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 286)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(747, 370)
        Me.Panel2.TabIndex = 16
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 281)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(747, 5)
        Me.Splitter1.TabIndex = 15
        Me.Splitter1.TabStop = False
        '
        'DatasetLoadResult
        '
        Me.AcceptButton = Me.ContinueButton
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(747, 656)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "DatasetLoadResult"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dataset Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.NewComponents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'overwrite existing?
    Public OverwriteExisting As Boolean = False
    Public OverwriteKeys As ObjectHashtable
    Public CancelCheckChangeEvent As Boolean
    Public ExistingLevelLookupTable As ObjectHashtable
    Public DataSet As Objects.ObjectDataCollection


    'init
    Public Sub Init(ByVal NewAndCharacters As Objects.ObjectDataCollection, ByVal Overwrites As Objects.ObjectDataCollection, ByVal Failures As ArrayList, ByVal ExistingLevelLookupTable As ObjectHashtable, ByVal Loadobjs As Objects.ObjectDataCollection)
        Try
            Me.ExistingLevelLookupTable = ExistingLevelLookupTable
            Me.DataSet = Loadobjs

            'init lists
            NewComponents.SelectionMode = SelectionMode.None
            NewComponents.SelectedIndex = -1
            Application.DoEvents()

            'load lists
            For Each Obj As Objects.ObjectData In NewAndCharacters
                Select Case Obj.Type
                    Case Objects.UserListItemType
                        NewComponents.Items.Add(Obj.Type & " - " & Obj.Path & " (" & Obj.Element("ListName") & ")")
                    Case Objects.RuleFolderPageType, Objects.RuleFolderType, Objects.RulePageType, Objects.RulesRootFolderType, Objects.RuleTableType
                        'Path won't work here since the root parent of a branch is not guaranteed to exist in the database already.
                        NewComponents.Items.Add(Obj.Type & " - " & Obj.Name)
                    Case Else
                        NewComponents.Items.Add(Obj.Type & " - " & Obj.Path)
                End Select
            Next

            'create list view items
            Dim Item As ListViewItem
            For Each Obj As Objects.ObjectData In Overwrites
                Item = New ListViewItem
                Item.Text = Obj.Type & " - " & Obj.Path
                Item.Tag = Obj
                OverwrittenView.Items.Add(Item)
            Next

            OverwriteKeys = New ObjectHashtable(Overwrites.Count + 1)

            'enable disable continue
            EnableDisableContinue()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueButton.Click
        For Each Item As ListViewItem In OverwrittenView.Items
            If Item.Checked Then
                OverwriteKeys.Add(CType(Item.Tag, Objects.ObjectData).ObjectGUID, Item.Tag)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub EnableDisableContinue(Optional ByVal Index As Integer = -99)
        If NewComponents.ItemCount > 0 Then
            ContinueButton.Enabled = True
            Exit Sub
        End If

        'skip the one that has just been disabled
        For Each Item As ListViewItem In OverwrittenView.Items
            If Item.Index <> Index Then
                If Item.Checked Then
                    ContinueButton.Enabled = True
                    Exit Sub
                End If
            End If
        Next

        ContinueButton.Enabled = False

    End Sub

    Private Sub DatasetLoadResult_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        OverwrittenView.Columns.Item(0).Width = OverwrittenView.Width - 17
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CancelCheckChangeEvent = True
        For Each Item As ListViewItem In OverwrittenView.Items
            Item.Checked = True
        Next

        CancelCheckChangeEvent = False
        EnableDisableContinue()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CancelCheckChangeEvent = True
        For Each Item As ListViewItem In OverwrittenView.Items
            Item.Checked = False
        Next
        CancelCheckChangeEvent = False
        EnableDisableContinue()
    End Sub

    Private Sub OverwrittenView_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles OverwrittenView.ItemCheck
        If Not CancelCheckChangeEvent Then
            If e.NewValue = CheckState.Checked Then
                ContinueButton.Enabled = True
            Else
                EnableDisableContinue(e.Index)
            End If
        End If
    End Sub

    Private Sub Analyse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Analyse.Click
        If OverwrittenView.SelectedItems.Count = 1 Then
            Dim CompareForm As New CompareForm
            Dim SelectedObject As Objects.ObjectData = CType(OverwrittenView.SelectedItems.Item(0).Tag, Objects.ObjectData)

            Dim ExistingObject As New Objects.ObjectData
            Select Case SelectedObject.Type

                Case Objects.SpellLevelType, Objects.PowerLevelType
                    ExistingObject = CType(ExistingLevelLookupTable(SelectedObject.ObjectGUID), Objects.ObjectData)
                Case Else
                    ExistingObject.Load(SelectedObject.ObjectGUID)
            End Select

            Dim NewObjectCollection As New Objects.ObjectDataCollection
            NewObjectCollection.Add(SelectedObject)
            For Each Obj As Objects.ObjectData In DataSet.ChildrenDeep(SelectedObject.ObjectGUID)
                NewObjectCollection.Add(Obj)
            Next

            Dim ExistingObjectCollection As Objects.ObjectDataCollection
            ExistingObjectCollection = ExistingObject.ChildrenDeep
            ExistingObjectCollection.Add(ExistingObject)

            CompareForm.Init(NewObjectCollection, ExistingObjectCollection)
            CompareForm.Show()
        Else
            General.ShowInfoDialog("Please select a changed component.")
        End If
    End Sub

End Class
