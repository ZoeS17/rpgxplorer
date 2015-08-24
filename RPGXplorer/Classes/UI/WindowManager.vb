Option Explicit On 
Option Strict On

Public Class WindowManager

    'this class manages all the windows in the main MDI interface

#Region "Member Variables"

    Private Shared IsDirtyTable As New Hashtable
    Private Shared _Windows As New ObjectHashtable
    Private Shared _CurrentWindow As CentralDisplayForm

    Public Shared SuspendEvents As Boolean

#End Region

#Region "Properties"

    'gets the current window
    Public Shared ReadOnly Property CurrentWindow() As CentralDisplayForm
        Get
            Return _CurrentWindow
        End Get
    End Property

    'returns a list of all the windows currently open for the given object
    Public Shared ReadOnly Property WindowByFolderGuid(ByVal FolderGUID As Objects.ObjectKey) As ArrayList
        Get
            Dim TempFolder As Objects.ObjectData
            Dim Window As CentralDisplayForm
            Dim Returnlist As New ArrayList

            For Each Window In _Windows.Values
                TempFolder = Window.Folder
                If TempFolder.ObjectGUID.Equals(FolderGUID) Then
                    Returnlist.Add(Window)
                End If
            Next

            Return Returnlist

        End Get
    End Property

    'a list of all the windows
    Public Shared ReadOnly Property Windows() As ArrayList
        Get
            Return New ArrayList(_Windows.Values)
        End Get
    End Property

    'no windows open?
    Public Shared ReadOnly Property NoWindowsOpen() As Boolean
        Get
            Return _Windows.Count = 0
        End Get
    End Property

#End Region

    'makes a hastable of arraylists of windows - Index by Folder.objectGUID
    Public Shared Function CreateWindowLookupTable() As Hashtable
        Try

            Dim ReturnTable As New Hashtable(_Windows.Count)

            For Each Window As CentralDisplayForm In _Windows.Values
                Dim TempFolder As Objects.ObjectData
                Dim TempList As ArrayList

                TempFolder = Window.Folder

                If Not ReturnTable.Contains(TempFolder.ObjectGUID) Then
                    TempList = New ArrayList
                    TempList.Add(Window)
                    ReturnTable.Add(TempFolder.ObjectGUID, TempList)
                Else
                    TempList = CType(ReturnTable(TempFolder.ObjectGUID), ArrayList)
                    TempList.Add(Window)
                End If
            Next

            Return ReturnTable

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)

        End Try
    End Function

    'refreshes all the tree nodes on the windows - needs called everytime the TreeView is loaded
    Public Shared Sub RefreshTreeNodes()
        Try
            For Each Item As DictionaryEntry In _Windows
                Dim Window As CentralDisplayForm
                Dim Folder As Objects.ObjectData

                Window = CType(Item.Value, CentralDisplayForm)
                Folder = Window.Folder
                Window.TreeNode = CType(General.MainExplorer.TreeNodes(Folder.ObjectGUID), TreeNode)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'restores the saved MDI Tabs from the previous run
    Public Shared Sub RestoreSavedDisplay(ByVal ProgressBar As ProgressBar)
        Try
            'load tab pages
            Dim MDITabsConfig As Objects.ObjectData = General.MDITabs

            If MDITabsConfig.ElementAsInteger("NumberOfPages") > 0 Then
                Dim Window As CentralDisplayForm = Nothing
                Dim TabsCount As Integer = MDITabsConfig.ElementAsInteger("NumberOfPages")

                ProgressBar.Maximum = TabsCount
                ProgressBar.Reset()
                ProgressBar.Caption = "RPGXplorer - Loading Tabs"

                WindowManager.SuspendEvents = True

                For i As Integer = 1 To TabsCount
                    'get window details and create
                    Dim ElementString As String = "TabPage" & i.ToString
                    Dim FolderKey As New Objects.ObjectKey(MDITabsConfig.Element(ElementString))
                    If _Windows.ContainsKey(FolderKey) Then Continue For
                    Dim CreatureKey As New Objects.ObjectKey(MDITabsConfig.Attribute(ElementString, "CharKey"))
                    Dim Filter As String = MDITabsConfig.Attribute(ElementString, "Filter")
                    Window = CreateWindow(FolderKey, CreatureKey, Filter)

                    'display window
                    Window.Show()

                    'progress
                    ProgressBar.Increment()
                Next

                WindowManager.SuspendEvents = False

                If TabsCount > 0 Then
                    General.MainExplorer.TreeView.SelectedNode = Window.TreeNode
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'create a new window
    Public Shared Function CreateWindow(ByVal FolderKey As Objects.ObjectKey, ByVal CreatureKey As Objects.ObjectKey, Optional ByVal Filter As String = "") As CentralDisplayForm
        Dim Window As New CentralDisplayForm
        Dim Folder As New Objects.ObjectData
        Folder.Load(FolderKey)
        Dim TreeNode As TreeNode = DirectCast(General.MainExplorer.TreeNodes(FolderKey), TreeNode)
        Window.Filter = Filter
        Window.Initialise(TreeNode, Folder, General.MainExplorer.GetPanelType(Folder.Type, TreeNode), CreatureKey)
        Window.NeedsPanelInit = True
        _Windows.Add(Window.FolderKey, Window)
        IsDirtyTable.Add(Window.FolderKey, Nothing)
        Return Window
    End Function

    'is the window already open?
    Public Shared Function IsWindowOpen(ByVal FolderKey As Objects.ObjectKey) As Boolean
        Return _Windows.Contains(FolderKey)
    End Function

    'get a specific window
    Public Shared Function GetWindow(ByVal FolderKey As Objects.ObjectKey) As CentralDisplayForm
        Return DirectCast(_Windows.Item(FolderKey), CentralDisplayForm)
    End Function

    'set the current window
    Public Shared Sub SetCurrentWindow(ByVal Window As CentralDisplayForm)
        Try
            If _Windows.Contains(Window.FolderKey) Then
                _CurrentWindow = CType(_Windows(Window.FolderKey), CentralDisplayForm)
                General.MainExplorer.FilterManager.CurrentFilter = _CurrentWindow.Filter
                General.MainExplorer.SetListView(_CurrentWindow.MyPanelType)
            Else
                Throw New Exceptions.DevelopmentException("SetCurrentWindow called but window has not yet been added.")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'removes the given window from the collection
    Public Shared Sub RemoveWindow(ByVal Window As CentralDisplayForm)
        Try
            If Not Window Is Nothing Then
                _Windows.Remove(Window.FolderKey)
                RemoveDirty(Window)
                If Not _CurrentWindow Is Nothing Then If _CurrentWindow.Equals(Window) Then _CurrentWindow = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove tabs for any objects we have just deleted
    Public Shared Sub RemoveAndUpdate(ByVal FoldersToRefresh As Objects.ObjectDataCollection, ByVal FolderGuidsToRemove As ArrayList)
        Try
            If _CurrentWindow Is Nothing Then Exit Sub

            Dim WindowLookup As Hashtable = CreateWindowLookupTable()

            'set the windows to be refreshed to dirty
            If Not FoldersToRefresh Is Nothing Then
                For Each TempObject As Objects.ObjectData In FoldersToRefresh
                    If WindowLookup.Contains(TempObject.ParentGUID) Then
                        WindowManager.SetDirty(TempObject.Parent)
                    End If
                Next
            End If

            'close any panels which have folder.objectGUID that equal one of deleted objects
            If Not FolderGuidsToRemove Is Nothing Then
                Dim CurrentFolder As Objects.ObjectData
                Dim CurrentDeleted As Boolean = False

                CurrentFolder = _CurrentWindow.Folder

                For Each TempGUID As Objects.ObjectKey In FolderGuidsToRemove
                    If WindowLookup.Contains(TempGUID) Then
                        Dim Windows As ArrayList

                        Windows = CType(WindowLookup.Item(TempGUID), ArrayList)

                        WindowManager.SuspendEvents = True
                        For Each Window As CentralDisplayForm In Windows
                            Window.Close()
                        Next
                        WindowManager.SuspendEvents = False

                    End If

                    If CurrentFolder.ObjectGUID.Equals(TempGUID) Then
                        CurrentDeleted = True
                    End If
                Next

                'select a new window
                If CurrentDeleted Then
                    If General.MainExplorer.Form.XtraTabbedMdiManager1.Pages.Count > 0 Then

                        Dim Window As CentralDisplayForm

                        WindowManager.SuspendEvents = True
                        General.MainExplorer.Form.XtraTabbedMdiManager1.SelectedPage = General.MainExplorer.Form.XtraTabbedMdiManager1.Pages.Item(0)
                        WindowManager.SuspendEvents = False

                        Window = CType(General.MainExplorer.Form.XtraTabbedMdiManager1.SelectedPage.MdiChild, CentralDisplayForm)
                        WindowManager.SetCurrentWindow(window)

                        General.MainExplorer.SuspendEvents = True
                        General.MainExplorer.TreeView.SelectedNode = window.TreeNode
                        General.MainExplorer.SuspendEvents = False

                    Else
                        'Commands.NewTab(Nothing, Nothing)
                        General.MainExplorer.TreeView.SelectedNode = General.MainExplorer.OGLFolder
                    End If
                End If

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save tab layout
    Public Shared Sub SaveTabs()
        Try
            General.MDITabs.ClearElements()

            For i As Integer = 1 To General.MainExplorer.Form.XtraTabbedMdiManager1.Pages.Count
                Dim TabPage As DevExpress.XtraTabbedMdi.XtraMdiTabPage
                Dim Form As CentralDisplayForm

                TabPage = General.MainExplorer.Form.XtraTabbedMdiManager1.Pages.Item(i - 1)
                Form = CType(TabPage.MdiChild, CentralDisplayForm)

                Dim Folder As Objects.ObjectData = Form.Folder
                Dim CharKey As Objects.ObjectKey = Form.CharacterKey

                General.MDITabs.Element("TabPage" & i.ToString) = Folder.ObjectGUID.ToString
                General.MDITabs.Attribute("TabPage" & i.ToString, "CharKey") = CharKey.ToString
                General.MDITabs.Attribute("TabPage" & i.ToString, "Filter") = Form.Filter
            Next

            General.MDITabs.Element("NumberOfPages") = (General.MainExplorer.Form.XtraTabbedMdiManager1.Pages.Count).ToString
            General.MDITabs.Save()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'refresh tab names
    Public Shared Sub RefreshTabNames()
        For Each Form As CentralDisplayForm In _Windows.Values
            Form.RefreshTabName()
        Next
    End Sub

#Region "Dirty"

    'checks if the given window requires updating
    Public Shared Function IsDirty() As Boolean
        Try
            If IsDirtyTable.Contains(_CurrentWindow.FolderKey) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'checks if the given window requires updating
    Public Shared Function IsDirty(ByVal Panel As CentralDisplayForm) As Boolean
        Try
            If IsDirtyTable.Contains(Panel.FolderKey) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'set all the windows to refresh
    Public Shared Sub SetAllDirty()
        Try
            For Each Key As Objects.ObjectKey In _Windows.Keys
                If Not IsDirtyTable.Contains(Key) Then
                    IsDirtyTable.Add(Key, Nothing)
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'sets all windows linked to this character to be refreshed
    Public Shared Sub SetDirty(ByVal CharKey As Objects.ObjectKey)
        Try
            Dim Window As CentralDisplayForm
            Dim CharacterKey As Objects.ObjectKey

            For Each Item As DictionaryEntry In _Windows
                Window = CType(Item.Value, CentralDisplayForm)
                CharacterKey = Window.CharacterKey

                If CharacterKey.Equals(CharKey) Then
                    If Not IsDirtyTable.Contains(Window.FolderKey) Then
                        IsDirtyTable.Add(Window.FolderKey, Nothing)
                    End If
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'sets all windows displaying this folder to be refreshed when next selected
    Public Shared Sub SetDirty(ByVal Folder As Objects.ObjectData)
        Try
            Dim Window As CentralDisplayForm
            Dim TempFolder As Objects.ObjectData
            Dim WindowID As Objects.ObjectKey
            Dim CharacterKey As Objects.ObjectKey
            Dim CharacterFolder As Boolean

            'if this is a character panel
            Select Case Folder.Type
                Case Objects.CharacterType, Objects.AssetsFolderType, Objects.CharacterChoiceFolderType, Objects.InventoryFolderType, _
                Objects.ItemType, Objects.ModifierFolderType, Objects.FeatureFolderType, Objects.SkillFolderType, Objects.ClassSpellListFolderType, _
                Objects.ClassSpellSettingsFolderType, Objects.WeaponConfigFolderType, Objects.FeatFolderType

                    CharacterFolder = True
                    CharacterKey = Folder.GetCharacterKey

            End Select

            'sets panel to dirty if it shares the same folder
            For Each Item As DictionaryEntry In _Windows
                Window = CType(Item.Value, CentralDisplayForm)
                WindowID = Window.FolderKey

                TempFolder = Window.Folder

                If (TempFolder.ObjectGUID.Equals(Folder.ObjectGUID)) OrElse (CharacterFolder AndAlso Window.CharacterFolder AndAlso TempFolder.GetCharacterKey.Equals(CharacterKey)) Then
                    If Not IsDirtyTable.Contains(Window.FolderKey) Then
                        IsDirtyTable.Add(Window.FolderKey, Nothing)
                    End If
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'sets a window to be refreshed when its next selected
    Public Shared Sub SetDirty(ByVal Window As CentralDisplayForm)
        Try
            If Not IsDirtyTable.Contains(Window.FolderKey) Then
                IsDirtyTable.Add(Window.FolderKey, Window)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'sets all windows displaying a certain panel type to dirty
    Public Shared Sub SetDirty(ByVal PanelType As Explorer.PanelType)
        Try
            Dim Window As CentralDisplayForm

            For Each Item As DictionaryEntry In _Windows
                Window = CType(Item.Value, CentralDisplayForm)

                If Window.MyPanelType = PanelType Then
                    If Not IsDirtyTable.Contains(Window.FolderKey) Then
                        IsDirtyTable.Add(Window.FolderKey, Nothing)
                    End If
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'removes a window from the dirty collection
    Public Shared Sub RemoveDirty(ByVal Window As CentralDisplayForm)
        Try

            If IsDirtyTable.Contains(Window.FolderKey) Then
                IsDirtyTable.Remove(Window.FolderKey)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
