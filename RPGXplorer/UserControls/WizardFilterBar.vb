Option Explicit On
Option Strict On

Public Class WizardFilterBar

    'variables
    Private _FilterManager As New FilterManager
    Private CurrentFilter As Objects.ObjectData
    Private FolderFilters As Objects.ObjectDataCollection
    Private _Folder As Objects.ObjectData

    Private _BaseObjects As Objects.ObjectDataCollection
    Private _FilteredObjects As Objects.ObjectDataCollection

    'events
    Public Event FilterChanged()

    'event flags
    Private IsLoading As Boolean

#Region "Properties"

    'get the collection of filtered objects
    Public ReadOnly Property FilteredObjects() As Objects.ObjectDataCollection
        Get
            Return _FilteredObjects
        End Get
    End Property

    'get or set the base objects
    Public Property BaseObjects(Optional ByVal SuppressEvents As Boolean = False) As Objects.ObjectDataCollection
        Get
            Return _BaseObjects
        End Get
        Set(ByVal Value As Objects.ObjectDataCollection)
            'update the base objects and reprocess
            _BaseObjects = Value
            _FilteredObjects = _FilterManager.ProcessFilter(_BaseObjects)

            'raise event to update 
            If Not SuppressEvents Then RaiseEvent FilterChanged()
        End Set
    End Property

#End Region

    'init
    Public Sub Init(ByVal Folder As Objects.ObjectData, ByVal BaseObjects As Objects.ObjectDataCollection)
        IsLoading = True

        Dim Temp As New ArrayList

        'get filters
        _Folder = Folder
        FolderFilters = Objects.GetObjectsByXPath(Xml.DBTypes.UserDocs, "/RPGXplorerDatabase/RPGXplorerObject[Type='Filter' and FolderType='" & _Folder.Type & "']")
        _FilterManager.FolderFilters = FolderFilters

        'set baseobjects
        If BaseObjects IsNot Nothing Then
            Me._BaseObjects = BaseObjects
        Else
            Me._BaseObjects = New Objects.ObjectDataCollection
        End If

        'populate combo
        Temp.Add("")
        Temp.AddRange(FolderFilters.GetNameList)
        Temp.Sort()
        FilterDropdown.Properties.Items.Clear()
        FilterDropdown.Properties.Items.AddRange(Temp)
        FilterDropdown.SelectedIndex = 0

        'init filtered list
        _FilteredObjects = BaseObjects

        IsLoading = False
    End Sub

#Region "Events"

    'handle the filter being changed
    Private Sub FilterDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterDropdown.SelectedIndexChanged
        If Not IsLoading Then
            'update list of objects
            _FilterManager.CurrentFilter = FilterDropdown.EditValue.ToString
            _FilteredObjects = _FilterManager.ProcessFilter(BaseObjects)

            'raise event
            RaiseEvent FilterChanged()
        End If
    End Sub

    'handle the filter clear button
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Try
            'reset the dropdown
            FilterDropdown.SelectedIndex = 0

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handle the filter button
    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Try
            Dim FilterForm As New FiltersForm
            Dim Temp As New ArrayList

            FilterForm.InitForFilterBar(_FilterManager, _Folder, Me.FilterDropdown)
            If FilterForm.ShowDialog() = DialogResult.OK Then
                _FilteredObjects = _FilterManager.ProcessFilter(BaseObjects)
                RaiseEvent FilterChanged()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
