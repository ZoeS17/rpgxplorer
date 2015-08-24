Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ConstructListDialog
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
    Public WithEvents ListA As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents Caption As System.Windows.Forms.Label
    Public WithEvents ListACaption As System.Windows.Forms.Label
    Public WithEvents ListBCaption As System.Windows.Forms.Label
    Public WithEvents ListB As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents AddButton As System.Windows.Forms.Button
    Public WithEvents RemoveButton As System.Windows.Forms.Button
    Public WithEvents Reset As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConstructListDialog))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.AddButton = New System.Windows.Forms.Button
        Me.ListA = New DevExpress.XtraEditors.ListBoxControl
        Me.Caption = New System.Windows.Forms.Label
        Me.ListACaption = New System.Windows.Forms.Label
        Me.ListBCaption = New System.Windows.Forms.Label
        Me.ListB = New DevExpress.XtraEditors.ListBoxControl
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.Reset = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ListA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(468, 458)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(388, 458)
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
        Me.TabControl1.Size = New System.Drawing.Size(523, 428)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AddButton)
        Me.TabPage1.Controls.Add(Me.ListA)
        Me.TabPage1.Controls.Add(Me.Caption)
        Me.TabPage1.Controls.Add(Me.ListACaption)
        Me.TabPage1.Controls.Add(Me.ListBCaption)
        Me.TabPage1.Controls.Add(Me.ListB)
        Me.TabPage1.Controls.Add(Me.RemoveButton)
        Me.TabPage1.Controls.Add(Me.Reset)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(515, 402)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Caption"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(215, 195)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(85, 24)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add >>"
        '
        'ListA
        '
        Me.ListA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListA.ItemHeight = 15
        Me.ListA.Location = New System.Drawing.Point(15, 70)
        Me.ListA.Name = "ListA"
        Me.ListA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListA.Size = New System.Drawing.Size(185, 315)
        Me.ListA.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ListA.TabIndex = 0
        '
        'Caption
        '
        Me.Caption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caption.Location = New System.Drawing.Point(15, 15)
        Me.Caption.Name = "Caption"
        Me.Caption.Size = New System.Drawing.Size(485, 21)
        Me.Caption.TabIndex = 1
        Me.Caption.Text = "Please choose your..."
        Me.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListACaption
        '
        Me.ListACaption.Location = New System.Drawing.Point(15, 45)
        Me.ListACaption.Name = "ListACaption"
        Me.ListACaption.Size = New System.Drawing.Size(185, 21)
        Me.ListACaption.TabIndex = 1
        Me.ListACaption.Text = "List A Caption"
        Me.ListACaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBCaption
        '
        Me.ListBCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBCaption.Location = New System.Drawing.Point(315, 45)
        Me.ListBCaption.Name = "ListBCaption"
        Me.ListBCaption.Size = New System.Drawing.Size(185, 21)
        Me.ListBCaption.TabIndex = 1
        Me.ListBCaption.Text = "List B Caption"
        Me.ListBCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListB
        '
        Me.ListB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListB.ItemHeight = 15
        Me.ListB.Location = New System.Drawing.Point(315, 70)
        Me.ListB.Name = "ListB"
        Me.ListB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListB.Size = New System.Drawing.Size(185, 315)
        Me.ListB.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ListB.TabIndex = 4
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(215, 230)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(85, 24)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Remove <<"
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(215, 280)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(85, 24)
        Me.Reset.TabIndex = 3
        Me.Reset.Text = "Reset"
        '
        'ConstructListDialog
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(552, 496)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 1024)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 530)
        Me.Name = "ConstructListDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add or Edit Filter"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ListA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'member variables
    Private _IsValidAdd As IsValidAdd

    'return value
    Public ListBFinal As New ArrayList

    'delegate for provide add item rule
    Public Delegate Function IsValidAdd(ByVal ItemsToAdd As ArrayList, ByVal ListBItems As ArrayList) As Boolean

    'init
    Public Sub Init(ByVal Title As String, ByVal TabCaption As String, ByVal Caption As String, ByVal ListACaption As String, ByVal ListBCaption As String, Optional ByVal IsValidAdd As IsValidAdd = Nothing, Optional ByVal RemovalMode As Boolean = False)
        Try
            'initialise controls
            Me.Text = Title
            TabPage1.Text = TabCaption
            Me.Caption.Text = Caption
            Me.ListACaption.Text = ListACaption
            Me.ListBCaption.Text = ListBCaption
            _IsValidAdd = IsValidAdd

            If RemovalMode Then
                AddButton.Text = "Remove >>"
                RemoveButton.Text = "Keep <<"
            End If

        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'init for text lists
    Public Sub InitTextList(ByVal ListAItems As ArrayList, ByVal ListBItems As ArrayList)
        Try
            ListA.Items.Clear()
            ListB.Items.Clear()

            For Each Item As Object In ListBItems
                If ListAItems.Contains(item) Then ListAItems.Remove(item)
            Next

            For Each Item As Object In ListAItems
                ListA.Items.Add(Item)
            Next

            For Each Item As Object In ListBItems
                ListB.Items.Add(item)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            For Each Item As Object In ListB.Items
                ListBFinal.Add(Item)
            Next
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    'add an item from A to B
    Private Sub AddItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListA.DoubleClick, AddButton.Click
        Try
            If ListA.SelectedIndices.Count = 0 Then Exit Sub

            If Not _IsValidAdd Is Nothing Then
                'construct list of items being added
                Dim ItemsToAdd As New ArrayList

                For Each Index As Integer In ListA.SelectedIndices
                    ItemsToAdd.Add(ListA.Items.Item(Index))
                Next

                'construct list of choices
                Dim ListBItems As New ArrayList

                For Each Item As Object In ListB.Items
                    ListBItems.Add(Item)
                Next

                If Not _IsValidAdd(ItemsToAdd, ListBItems) Then Exit Sub
            End If

            Dim RemoveItems As New ArrayList

            For Each Index As Integer In ListA.SelectedIndices
                RemoveItems.Add(ListA.Items.Item(Index))
                ListB.Items.Add(ListA.Items.Item(Index))
            Next

            For Each Item As Object In RemoveItems
                ListA.Items.Remove(Item)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove an item from B and put back in A
    Private Sub RemoveItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListB.DoubleClick, RemoveButton.Click
        Try
            Dim RemoveItems As New ArrayList

            For Each Index As Integer In ListB.SelectedIndices
                RemoveItems.Add(ListB.Items.Item(Index))
                ListA.Items.Add(ListB.Items.Item(Index))
            Next

            For Each Item As Object In RemoveItems
                ListB.Items.Remove(Item)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reset
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Try
            Dim RemoveItems As New ArrayList

            For Each Item As Object In ListB.Items
                RemoveItems.Add(Item)
                ListA.Items.Add(Item)
            Next

            For Each Item As Object In RemoveItems
                ListB.Items.Remove(Item)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class

