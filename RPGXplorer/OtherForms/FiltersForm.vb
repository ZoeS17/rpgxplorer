Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class FiltersForm
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
    Public WithEvents Basics As System.Windows.Forms.TabPage
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents FilterList As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents AddFilter As System.Windows.Forms.Button
    Public WithEvents EditFilter As System.Windows.Forms.Button
    Public WithEvents DeleteFilter As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FiltersForm))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.AddFilter = New System.Windows.Forms.Button
        Me.FilterList = New DevExpress.XtraEditors.ListBoxControl
        Me.EditFilter = New System.Windows.Forms.Button
        Me.DeleteFilter = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.FilterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(483, 493)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(403, 493)
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
        Me.TabControl1.Controls.Add(Me.Basics)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(538, 463)
        Me.TabControl1.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.AddFilter)
        Me.Basics.Controls.Add(Me.FilterList)
        Me.Basics.Controls.Add(Me.EditFilter)
        Me.Basics.Controls.Add(Me.DeleteFilter)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(530, 437)
        Me.Basics.TabIndex = 2
        Me.Basics.Text = "Filters"
        '
        'AddFilter
        '
        Me.AddFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddFilter.Location = New System.Drawing.Point(325, 395)
        Me.AddFilter.Name = "AddFilter"
        Me.AddFilter.Size = New System.Drawing.Size(90, 24)
        Me.AddFilter.TabIndex = 107
        Me.AddFilter.Text = "Add Filter"
        '
        'FilterList
        '
        Me.FilterList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilterList.ItemHeight = 15
        Me.FilterList.Location = New System.Drawing.Point(15, 15)
        Me.FilterList.Name = "FilterList"
        Me.FilterList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.FilterList.Size = New System.Drawing.Size(500, 365)
        Me.FilterList.SortOrder = System.Windows.Forms.SortOrder.Descending
        Me.FilterList.TabIndex = 106
        '
        'EditFilter
        '
        Me.EditFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditFilter.Location = New System.Drawing.Point(425, 395)
        Me.EditFilter.Name = "EditFilter"
        Me.EditFilter.Size = New System.Drawing.Size(90, 24)
        Me.EditFilter.TabIndex = 107
        Me.EditFilter.Text = "Edit Filter"
        '
        'DeleteFilter
        '
        Me.DeleteFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteFilter.Location = New System.Drawing.Point(15, 395)
        Me.DeleteFilter.Name = "DeleteFilter"
        Me.DeleteFilter.Size = New System.Drawing.Size(90, 24)
        Me.DeleteFilter.TabIndex = 107
        Me.DeleteFilter.Text = "Delete Filter"
        '
        'FiltersForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(567, 531)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 250)
        Me.Name = "FiltersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filters"
        Me.TabControl1.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.FilterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private _FilterManager As FilterManager
    Private Filters As New Hashtable
    Private FolderType As String
    Private IsForFilterBarControl As Boolean
    Private _FilterBarFolder As Objects.ObjectData
    Private _FilterCombo As DevExpress.XtraEditors.ComboBoxEdit

#End Region

#Region "Properties"

    'names of filters in list
    Public ReadOnly Property FilterNames() As ArrayList
        Get
            FilterNames = New ArrayList

            For Each Item As Filter In FilterList.Items
                FilterNames.Add(Item.Name)
            Next
        End Get
    End Property

#End Region

    'init
    Public Sub Init(ByVal FilterManager As FilterManager)
        Try
            _FilterManager = FilterManager
            DoInit(FilterManager.CurrentFolder)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'init
    Public Sub InitForFilterBar(ByVal FilterManager As FilterManager, ByVal Folder As Objects.ObjectData, ByVal FilterCombo As DevExpress.XtraEditors.ComboBoxEdit)
        Try
            IsForFilterBarControl = True
            _FilterManager = FilterManager
            _FilterBarFolder = Folder
            _FilterCombo = FilterCombo
            DoInit(Folder)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'does the actual init
    Private Sub DoInit(ByVal Folder As Objects.ObjectData)
        Try
            'load existing filters
            FolderType = Folder.Type
            Dim FilterObjs As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.UserDocs, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FilterType & "' and FolderType='" & FolderType & "']")

            For Each FilterObj As Objects.ObjectData In FilterObjs
                Dim Filter As New Filter

                Filter.Name = FilterObj.Name
                Filter.Key = FilterObj.ObjectGUID
                Filter.FolderType = FolderType
                Filter.Terms = New ArrayList

                For Each TermObj As Objects.ObjectData In FilterObj.Children
                    Dim Term As New Term
                    Term.LoadTerm(TermObj)
                    Filter.Terms.Add(Term)
                Next

                Filters.Add(Filter.Key, Filter)
                FilterList.Items.Add(Filter)
            Next

            If FilterList.Items.Count > 0 Then FilterList.SelectedIndex = 0

            'initialise controls
            EnableDisableButtons()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Not IsForFilterBarControl Then General.MainExplorer.Undo.UndoRecord()
            General.SetWaitCursor()

            'delete existing filters for this folder type
            Dim FilterObjs As Objects.ObjectDataCollection = Objects.GetObjectsByXPath(XML.DBTypes.UserDocs, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.FilterType & "' and FolderType='" & FolderType & "']")
            For Each Obj As Objects.ObjectData In FilterObjs
                Obj.DeleteFast()
            Next

            'create new objects and save
            For Each Item As DictionaryEntry In Filters
                Dim Filter As Filter = CType(Item.Value, Filter)

                'filter
                Dim FilterObj As New Objects.ObjectData

                FilterObj.Name = Filter.Name
                If Filter.Key.IsEmpty Then
                    FilterObj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.UserDocs)
                Else
                    FilterObj.ObjectGUID = Filter.Key
                End If
                FilterObj.ParentGUID = Objects.ObjectKey.Empty
                FilterObj.Type = Objects.FilterType
                FilterObj.Element("FolderType") = FolderType
                FilterObj.Save()

                'terms
                For Each Term As Term In Filter.Terms
                    Term.SaveTerm(FilterObj.ObjectGUID)
                Next

                FilterObj.Clear()
            Next

            'reinit filter manager
            If IsForFilterBarControl Then _FilterManager.ReInitForFilterBar(_FilterBarFolder, _FilterCombo) Else _FilterManager.ReInit()

            General.SetNormalCursor()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'enable/disable buttons
    Private Sub EnableDisableButtons()
        Try
            Dim Edit, Delete As Boolean

            Edit = True
            Delete = True

            If FilterList.SelectedIndex = -1 Or FilterList.Items.Count = 0 Then
                Edit = False
                Delete = False
            End If

            'button state
            If Edit Then EditFilter.Enabled = True Else EditFilter.Enabled = False
            If Delete Then DeleteFilter.Enabled = True Else DeleteFilter.Enabled = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Event Handlers"

    Private Sub AddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFilter.Click
        Try
            Dim FilterForm As New FilterForm

            FilterForm.InitAdd(_FilterManager, Me, FolderType)
            If FilterForm.ShowDialog() = DialogResult.OK Then
                Dim Filter As Filter = FilterForm.Filter
                Filters.Add(Filter.Key, Filter)
                FilterList.Items.Add(Filter)
                FilterList.SelectedItem = Filter
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EditFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFilter.Click
        Try
            If FilterList.SelectedIndices.Count > 1 Then
                General.ShowInfoDialog("You can only edit 1 filter at a time.")
                Exit Sub
            End If

            Dim FilterForm As New FilterForm

            FilterForm.InitEdit(_FilterManager, Me, CType(Filters.Item(CType(FilterList.SelectedItem, Filter).Key), Filter), FolderType)
            If FilterForm.ShowDialog = DialogResult.OK Then
                Dim Filter As Filter = FilterForm.Filter
                Filters.Remove(CType(FilterList.SelectedItem, Filter).Key)
                FilterList.Items.Remove(FilterList.SelectedItem)
                Filters.Add(Filter.Key, Filter)
                FilterList.Items.Add(Filter)
                FilterList.SelectedItem = Filter
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DeleteFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFilter.Click
        Try
            If General.ShowQuestionDialog("Are you sure you want to delete?") = DialogResult.Yes Then
                Dim Deletions As New ArrayList

                For Each Index As Integer In FilterList.SelectedIndices
                    Filters.Remove(CType(FilterList.Items(Index), Filter).Key)
                    Deletions.Add(FilterList.Items(Index))
                Next

                For Each Filter As Filter In Deletions
                    FilterList.Items.Remove(Filter)
                Next

                EnableDisableButtons()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FilterList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterList.SelectedIndexChanged
        Try
            EnableDisableButtons()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class

