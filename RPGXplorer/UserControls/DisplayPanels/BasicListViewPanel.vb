Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions

Public Class BasicListViewPanel
    Implements IPanel

#Region "IPanel"

    Public Property IsDirty() As Boolean Implements IPanel.IsDirty
        Get

        End Get
        Set(ByVal Value As Boolean)

        End Set
    End Property

    Public ReadOnly Property ListView() As System.Windows.Forms.ListView Implements IPanel.ListView
        Get
            Return ListView1
        End Get
    End Property

    Public Sub Save() Implements IPanel.Save

    End Sub

    Public Overridable Sub RefreshPanelData() Implements IPanel.RefreshPanelData

    End Sub

    'read-only
    Public WriteOnly Property [ReadOnly]() As Boolean Implements IPanel.ReadOnly
        Set(ByVal value As Boolean)
            'do nothing
        End Set
    End Property

#End Region

#Region "List View Handlers"

    'before label edit
    Private Sub ListView1_BeforeLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles ListView1.BeforeLabelEdit
        If Not CommonHandlers.BeforeLabelEdit(CType(General.MainExplorer.ListView.Items(e.Item).Tag, Objects.ObjectKey)) Then e.CancelEdit = True
    End Sub

    'after label edit
    Private Sub ListView1_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles ListView1.AfterLabelEdit
        If Not CommonHandlers.AfterLabelEditListView(CType(ListView1.Items(e.Item).Tag, Objects.ObjectKey), e.Label, ListView1.Items(e.Item)) Then
            e.CancelEdit = True
            Exit Sub
        Else
            General.MainExplorer.RefreshRenamedNode(CType(ListView1.Items(e.Item).Tag, Objects.ObjectKey), CommonLogic.StripNameDisallowedChars(e.Label))
            e.CancelEdit = True
        End If
    End Sub

    'display the right-click menu
    Private Sub ListView1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseUp
        Try
            If e.Button = MouseButtons.Right AndAlso Not UI.ReadOnly Then
                ToolbarsAndMenus.BuildPopupMenu()
                ToolbarsAndMenus.PopupMenu.ShowPopup(New Point(Control.MousePosition.X, Control.MousePosition.Y))
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'active the currently selected list view item
    Private Sub ListView1_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.ItemActivate
        Try
            General.MainExplorer.HandleItemActivate()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'got focus
    Private Sub ListView1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.GotFocus
        Try
            General.MainExplorer.CurrentFocus = RPGXplorer.Explorer.Focus.ListView

            If ListView1.SelectedItems.Count = 0 And ListView1.Items.Count > 0 Then
                ListView1.Items(0).Selected = True
            ElseIf ListView1.SelectedItems.Count > 0 Then
                General.MainExplorer.HandleListViewItemSelect()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'item selected
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            General.MainExplorer.HandleListViewItemSelect()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
