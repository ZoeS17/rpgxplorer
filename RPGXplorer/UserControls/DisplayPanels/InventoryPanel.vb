Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
'Imports System.DrawingPublic

Public Class InventoryPanel
    Implements IPanel

#Region "Member Variables"

    Private IsLoading As Boolean
    Private _IsDirty As Boolean
    Private _CharacterKey As Objects.ObjectKey
    Private InitialCalculate As Boolean
    Private InventoryFolder As Objects.ObjectData

#End Region

    Dim Counter As Double

#Region "Properties"

    'character key
    Public ReadOnly Property CharacterKey() As Objects.ObjectKey
        Get
            Return _CharacterKey
        End Get
    End Property

    'character
    'Public ReadOnly Property Character() As Rules.Character
    '    Get
    '        Return CharacterManager.GetCharacter(_CharacterKey)
    '    End Get
    'End Property

#End Region

    'init
    Public Sub Init(ByVal CharacterKey As Objects.ObjectKey)
        IsLoading = True
        InitialCalculate = True

        _CharacterKey = CharacterKey

        'set encumberance type
        Select Case CharacterManager.GetCharacter(CharacterKey).Inventory.Encumberance
            Case Rules.Inventory.EncumberanceType.ByArmor
                ByArmor.Checked = True
            Case Rules.Inventory.EncumberanceType.ByWeight
                ByWeight.Checked = True
        End Select

        CType(Me.Parent, CentralDisplayForm).NeedsPanelInit = False
        InventoryFolder = CType(Me.Parent, CentralDisplayForm).Folder

        IsLoading = False
    End Sub

#Region "IPanel"

    'is dirty
    Public Property IsDirty() As Boolean Implements IPanel.IsDirty
        Get
            Return _IsDirty
        End Get
        Set(ByVal Value As Boolean)
            _IsDirty = Value
        End Set
    End Property

    'list view
    Public ReadOnly Property ListView() As System.Windows.Forms.ListView Implements IPanel.ListView
        Get
            Return ListView1
        End Get
    End Property

    'refresh
    Public Sub RefreshPanelData() Implements IPanel.RefreshPanelData
        IsLoading = True

        Dim Character As Rules.Character
        Dim Inventory As Rules.Inventory

        'show the default  button if required
        If General.Config.Element("DefaultWeapons") = "Yes" Then
            DefaultButton.Visible = True
        Else
            DefaultButton.Visible = False
        End If

        'Character = CharacterManager.GetCharacter(_CharacterKey)
        Character = CharacterManager.CurrentCharacter()
        Inventory = Character.Inventory

        'check to see armor is still in top level of inventory
        If Inventory.ArmorWorn.IsNotEmpty Then
            If Not Inventory.InventoryFolder.Children.Contains(Inventory.ArmorWorn) Then Inventory.ArmorWorn = Objects.ObjectKey.Empty
        End If

        'populate armor list and select current item if any
        Dim ArmorList As DataListItem() = Inventory.EligibleArmor

        Armor.Properties.Items.Clear()
        If Not ArmorList Is Nothing Then
            Armor.Properties.Items.AddRange(ArmorList)
            Armor.SelectedIndex = Rules.Index.GetGuidIndex(ArmorList, Inventory.ArmorWorn)
        End If

        'check to see shield is still in top level of inventory
        If Inventory.ShieldWorn.IsNotEmpty Then
            If Not Inventory.InventoryFolder.Children.Contains(Inventory.ShieldWorn) Then Inventory.ShieldWorn = Objects.ObjectKey.Empty
        End If

        'populate shield list and select current item if any
        Dim ShieldList As DataListItem() = Inventory.EligibleShields

        Shield.Properties.Items.Clear()
        If Not ShieldList Is Nothing Then
            Shield.Properties.Items.AddRange(ShieldList)
            Shield.SelectedIndex = Rules.Index.GetGuidIndex(ShieldList, Inventory.ShieldWorn)
        End If

        'recalc
        'If InitialCalculate Then
        '    InitialCalculate = False
        'Else
        '    Inventory.Calculate(True)
        'End If

        'weight
        Select Case Inventory.Load
            Case "Light"
                Weight.BackColor = General.BackColourPositive
            Case "Medium"
                Weight.BackColor = General.BackColourPaleYellow
            Case "Heavy"
                Weight.BackColor = General.BackColourNegative
            Case "Too Heavy"
                Weight.BackColor = Color.Red
        End Select
        Weight.Text = " " & Rules.Formatting.FormatPounds(Inventory.Weight) & " (" & Inventory.Load & ")"

        If Inventory.Load = "Too Heavy" And Inventory.Encumberance = Rules.Inventory.EncumberanceType.ByWeight Then
            MaxDEX.Text = "0"
            CheckPenalty.Text = "NA"
            SpellFailure.Text = "NA"
            Speed.Text = "0"
            Run.Text = "x0"
            MaxDEX.ForeColor = Color.Red
            CheckPenalty.ForeColor = Color.Red
            SpellFailure.ForeColor = Color.Red
            Speed.ForeColor = Color.Red
            Run.ForeColor = Color.Red
        Else
            'max dex
            If Inventory.MaxDEX = 999 Then
                MaxDEX.Text = "-"
            Else
                MaxDEX.Text = Rules.Formatting.FormatModifier(Inventory.MaxDEX)
            End If

            If Inventory.MaxDEX = 999 Then
                MaxDEX.ForeColor = Color.Black
            ElseIf Inventory.MaxDEX = 0 Then
                MaxDEX.ForeColor = Color.Red
            ElseIf Inventory.MaxDEX < Inventory.DEXMod Then
                MaxDEX.ForeColor = Color.DarkOrange
            Else
                MaxDEX.ForeColor = Color.LimeGreen
            End If

            'check penalty
            CheckPenalty.Text = Rules.Formatting.FormatModifier(Inventory.CheckPenalty)
            If CheckPenalty.Text = "-" Then
                CheckPenalty.ForeColor = Color.Black
            ElseIf Inventory.CheckPenalty = 0 Then
                CheckPenalty.ForeColor = Color.LimeGreen
            ElseIf Inventory.CheckPenalty >= -5 Then
                CheckPenalty.ForeColor = Color.DarkOrange
            Else
                CheckPenalty.ForeColor = Color.Red
            End If

            'spell failure
            If Inventory.SpellFailure = 0 Then
                SpellFailure.Text = "-"
                SpellFailure.ForeColor = Color.Black
            Else
                SpellFailure.Text = Inventory.SpellFailure.ToString & "%"
                SpellFailure.ForeColor = Color.Red
            End If

            'speed, run
            Dim SpeedVal As Integer = Inventory.Speed
            Speed.Text = Rules.Formatting.FormatFeet(SpeedVal)
            SetModifierColour(Speed, Rules.Modifiers.ModifierFlag(SpeedVal, Inventory.Character.SpeedBaseUnmodified))
            Run.Text = "x" & Inventory.Run
            SetModifierColour(Run, Rules.Modifiers.ModifierFlag(Inventory.Run, 4))

        End If

        'money, value
        Money.Text = " " & Inventory.Money.DisplayString
        ItemsValue.Text = " " & Inventory.Value.DisplayString

        'encumberance ranges        
        CarryingCapacities.Text = "Light Load: " & Rules.Encumberance.LightLoad(Inventory.Character.Size, Inventory.STR, Inventory.Character.Quadruped) & ", " & "Medium Load: " & Rules.Encumberance.MediumLoad(Inventory.Character.Size, Inventory.STR, Inventory.Character.Quadruped) & ", " & "Heavy Load:" & Rules.Encumberance.HeavyLoad(Inventory.Character.Size, Inventory.STR, Inventory.Character.Quadruped)

        If ListView1.SelectedItems.Count = 0 Then
            Quantity.Properties.Enabled = False
            Quantity.EditValue = 1
            Charges.Properties.Enabled = False
            Charges.Value = 0
        End If

        WindowManager.RemoveDirty(CType(Me.Parent, CentralDisplayForm))
        IsLoading = False
    End Sub

    'save
    Public Sub Save() Implements IPanel.Save
        If IsDirty Then
            General.MainExplorer.Undo.UndoRecord()
            Dim Character As Rules.Character
            Dim Inventory As Rules.Inventory

            Character = CharacterManager.GetCharacter(_CharacterKey)
            Inventory = Character.Inventory

            Inventory.Save()
        End If
    End Sub

    Private _ReadOnly As Boolean = False

    'read-only
    Public WriteOnly Property [ReadOnly]() As Boolean Implements IPanel.ReadOnly
        Set(ByVal value As Boolean)
            If value <> _ReadOnly Then
                _ReadOnly = value
                If _ReadOnly Then
                    Me.ByArmor.Enabled = False
                    Me.ByWeight.Enabled = False
                    Me.DefaultButton.Enabled = False
                    Me.Armor.Enabled = False
                    Me.Shield.Enabled = False
                    Me.Quantity.Enabled = False
                    Me.Charges.Enabled = False
                    Me.AddMoney.Enabled = False
                    Me.ListView.AllowDrop = False
                Else
                    Me.ByArmor.Enabled = True
                    Me.ByWeight.Enabled = True
                    Me.DefaultButton.Enabled = True
                    Me.Armor.Enabled = True
                    Me.Shield.Enabled = True
                    Me.Quantity.Enabled = True
                    Me.Charges.Enabled = True
                    Me.AddMoney.Enabled = True
                    Me.ListView.AllowDrop = True
                End If
            End If
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
        If Not CommonHandlers.AfterLabelEditListView(CType(ListView1.Items(e.Item).Tag, Objects.ObjectKey), e.Label, ListView1.Items(e.Item), False) Then
            e.CancelEdit = True
            Exit Sub
        Else
            General.MainExplorer.RefreshRenamedNode(CType(ListView1.Items(e.Item).Tag, Objects.ObjectKey), e.Label)
        End If
    End Sub

    'display the right-click menu
    Private Sub ListView1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseUp
        Try
            DragBox = Rectangle.Empty
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

        General.MainExplorer.HandleListViewItemSelect()

        IsLoading = True

        'handle quantity and charges
        If ListView1.SelectedItems.Count = 1 Then
            Dim ItemKey As Objects.ObjectKey = CType(ListView1.SelectedItems(0).Tag, Objects.ObjectKey)
            Dim Item As New Objects.ObjectData
            Dim BaseItem As Objects.ObjectData
            Item.Load(ItemKey)
            BaseItem = Item.GetFKObject("Item")
            Dim Qty As Boolean = False
            Dim Charge As Boolean = False

            If BaseItem.IsEmpty Then
                Select Case Item.Type
                    Case Objects.MoneyType, Objects.ScrollSpellType
                        'qty and charge remain false
                    Case Else
                        Charge = True
                        Qty = True
                End Select
            Else
                Select Case BaseItem.Type
                    Case Objects.ItemDefinitionType
                        If Not BaseItem.Element("IsContainer") = "Yes" Then
                            Charge = True
                            Qty = True
                        End If
                    Case Objects.RodDefinitionType, Objects.RingDefinitionType, Objects.WondrousDefinitionType, Objects.ArtifactDefinitionType, Objects.StaffDefinitionType, Objects.WandDefinitionType, Objects.SpecificWeaponDefinitionType, Objects.UniversalItemDefinitionType, Objects.PsionicPsicrownDefinitionType, Objects.PsionicDorjeDefinitionType, Objects.PsionicArtifactDefinitionType
                        Charge = True
                    Case Objects.PotionDefinitionType, Objects.MagicAmmoDefinitionType, Objects.AmmoDefinitionType, Objects.WeaponDefinitionType
                        Qty = True
                End Select
            End If

            If Qty Then
                IsLoading = False
                Quantity.Properties.Enabled = True
                Quantity.EditValue = Rules.Inventory.GetQuantity(ItemKey)
            Else
                Quantity.Properties.Enabled = False
                Quantity.EditValue = 1
            End If

            If Charge Then
                IsLoading = False
                Charges.Properties.Enabled = True
                Charges.Value = Rules.Inventory.GetCharges(ItemKey)
            Else
                Charges.Properties.Enabled = False
                Charges.Value = 0
            End If
        Else
            Quantity.Properties.Enabled = False
            Quantity.EditValue = 1
            Charges.Properties.Enabled = False
            Charges.Value = 0
        End If

        IsLoading = False
    End Sub

#Region "DragDrop"

    Dim DragBox As Rectangle

    Private Sub ListView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDown
        Try
            If e.Button = MouseButtons.Left And (Not ListView1.GetItemAt(e.X, e.Y) Is Nothing) Then
                Dim DragSize As Size = SystemInformation.DragSize
                DragBox = New Rectangle(New Point(e.X - (DragSize.Width \ 2), e.Y - (DragSize.Height \ 2)), DragSize)
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub ListView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseMove
        Try
            If e.Button = MouseButtons.Left Then
                If Not (DragBox.Equals(Rectangle.Empty)) AndAlso (Not DragBox.Contains(e.X, e.Y)) Then
                    Dim Objects As Objects.ObjectDataCollection = General.MainExplorer.CurrentSelectedObjects()
                    General.DragSource = DragSourceType.List
                    ListView1.DoDragDrop(Objects, DragDropEffects.All)
                End If
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub ListView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragEnter
        Try
            Dim Selected As Objects.ObjectDataCollection = CType(e.Data.GetData(GetType(Objects.ObjectDataCollection)), Objects.ObjectDataCollection)

            If Not Selected Is Nothing OrElse Selected.Count > 0 Then
                If Control.ModifierKeys = Keys.ControlKey Then
                    e.Effect = DragDropEffects.Copy
                Else
                    e.Effect = DragDropEffects.Move
                End If
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub ListView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragOver
        Try
            Dim Selected As Objects.ObjectDataCollection = CType(e.Data.GetData(GetType(Objects.ObjectDataCollection)), Objects.ObjectDataCollection)

            If Not Selected Is Nothing OrElse Selected.Count > 0 Then
                If Control.ModifierKeys = Keys.Control Then
                    e.Effect = DragDropEffects.Copy
                Else
                    e.Effect = DragDropEffects.Move
                End If
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub ListView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop
        Try

            'get the listview target - if none, its the selected tree node
            Dim Selected As Objects.ObjectDataCollection = CType(e.Data.GetData(GetType(Objects.ObjectDataCollection)), Objects.ObjectDataCollection)
            Dim TargetFolder As New Objects.ObjectData
            Dim TargetLocation As Point = ListView1.PointToClient(New Point(e.X, e.Y))
            Dim SelectedItem As ListViewItem = ListView1.GetItemAt(TargetLocation.X, TargetLocation.Y)

            If SelectedItem Is Nothing Then
                TargetFolder = General.MainExplorer.ObjectSelectedInTree
            Else
                If TypeOf SelectedItem.Tag Is RPGXplorer.Objects.ObjectKey Then
                    TargetFolder.Load(CType(SelectedItem.Tag, Objects.ObjectKey))
                ElseIf TypeOf SelectedItem.Tag Is Objects.ObjectData Then
                    TargetFolder = CType(SelectedItem.Tag, Objects.ObjectData)
                End If
            End If

            If Selected.Contains(TargetFolder.ObjectGUID) Then
                General.ShowErrorDialog("The destination object is included in the current selection.")
                Exit Sub
            End If

            'make sure the dragged items do not contain the parent of the target item
            If Selected.Contains(TargetFolder.ParentGUID) Then
                General.ShowErrorDialog("The destination object's parent is included in the current selection.")
                Exit Sub
            End If

            If Not TargetFolder.IsEmpty Then

                General.MainExplorer.Undo.UndoRecord()

                If e.Effect = DragDropEffects.Copy Then
                    Dim TempObjectCollection As New Objects.ObjectDataCollection
                    Dim KeyMap As New ObjectHashtable

                    General.MainExplorer.TreeView.BeginUpdate()
                    For Each SelectedObject As Objects.ObjectData In Selected
                        TempObjectCollection.Clear()
                        TempObjectCollection = SelectedObject.CloneWithKeyMap(TargetFolder, KeyMap)
                        TempObjectCollection.Save()

                        Dim ExistingNode, NewNode, TargetNode As TreeNode
                        Dim ObjectTag As Explorer.ObjectTagData

                        ExistingNode = CType(General.MainExplorer.TreeNodes(SelectedObject.ObjectGUID), TreeNode)
                        If Not ExistingNode Is Nothing Then
                            NewNode = CType(ExistingNode.Clone, TreeNode)
                            ObjectTag = CType(ExistingNode.Tag, Explorer.ObjectTagData)
                            ObjectTag.Name = TempObjectCollection.Item(0).Name
                            ObjectTag.ObjectGUID = CType(KeyMap(SelectedObject.ObjectGUID), Objects.ObjectKey)
                            NewNode.Tag = ObjectTag
                            TargetNode = CType(General.MainExplorer.TreeNodes(TargetFolder.ObjectGUID), TreeNode)
                            NewNode.Text = ObjectTag.Name
                            If Not TargetNode Is Nothing Then
                                General.MainExplorer.InsertNode(TargetNode, NewNode)
                                General.MainExplorer.TreeNodes.Item(ObjectTag.ObjectGUID) = NewNode
                            End If

                            'update its children
                            For Each TempNode As TreeNode In NewNode.Nodes
                                PasteManager.UpdateChildNode(TempNode, KeyMap)
                            Next

                        End If
                    Next

                    General.MainExplorer.TreeView.EndUpdate()
                    General.SetNormalCursor()
                    General.MainExplorer.RefreshPanel()

                ElseIf e.Effect = DragDropEffects.Move Then

                    'if we are moving items within a folder - just quit
                    If TargetFolder.ObjectGUID.Equals(General.MainExplorer.ObjectSelectedInTree.ObjectGUID) Then
                        If General.DragSource = DragSourceType.List Then
                            Exit Sub
                        End If
                    End If

                    If TargetFolder.Element("IsContainer") = "Yes" OrElse TargetFolder.GetFKObject("Item").Element("IsContainer") = "Yes" OrElse TargetFolder.Type = Objects.InventoryFolderType OrElse TargetFolder.Type = Objects.AssetsFolderType Then
                        General.SetWaitCursor()

                        General.MainExplorer.TreeView.BeginUpdate()
                        For Each SelectedObject As Objects.ObjectData In Selected
                            SelectedObject.ParentGUID = TargetFolder.ObjectGUID
                            SelectedObject.Save()

                            'move the tree nodes
                            Dim OldNode, NewNode, TargetNode As TreeNode
                            OldNode = CType(General.MainExplorer.TreeNodes(SelectedObject.ObjectGUID), TreeNode)
                            If Not OldNode Is Nothing Then
                                NewNode = CType(OldNode.Clone, TreeNode)
                                TargetNode = CType(General.MainExplorer.TreeNodes(TargetFolder.ObjectGUID), TreeNode)
                                If Not TargetNode Is Nothing Then
                                    OldNode.Remove()
                                    General.MainExplorer.InsertNode(TargetNode, NewNode)
                                    General.MainExplorer.TreeNodes.Item(SelectedObject.ObjectGUID) = NewNode
                                End If
                            End If
                        Next
                        General.MainExplorer.TreeView.EndUpdate()
                        General.SetNormalCursor()
                        General.MainExplorer.RefreshPanel()
                    End If
                End If
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

#End Region

#Region "Paint Events"

    'Private Sub InventoryPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    '    Dim rect As Rectangle

    '    Try
    '        If Me.Width > 0 And Me.Height > 0 Then
    '            rect = New Rectangle(0, 0, Me.Width, 144)
    '            Dim gradbrush As New Drawing2D.LinearGradientBrush(rect, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)

    '            e.Graphics.FillRectangle(gradbrush, rect)
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    Private Sub InventoryPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub Armor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Armor.SelectedIndexChanged
        Dim Character As Rules.Character
        Dim Inventory As Rules.Inventory

        Character = CharacterManager.GetCharacter(_CharacterKey)
        Inventory = Character.Inventory

        If Armor.SelectedIndex <= 0 Then
            Inventory.ArmorWorn = Objects.ObjectKey.Empty
        Else
            Inventory.ArmorWorn = CType(Armor.SelectedItem, DataListItem).ObjectGUID
        End If

        If IsLoading Then Exit Sub

        CharacterManager.SetDirty(_CharacterKey, CharacterManager.DirtyStatus.Recalculate)
        RefreshPanelData()

        _IsDirty = True
    End Sub

    Private Sub Shield_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shield.SelectedIndexChanged
        Dim Character As Rules.Character
        Dim Inventory As Rules.Inventory

        Character = CharacterManager.GetCharacter(_CharacterKey)
        Inventory = Character.Inventory

        If Shield.SelectedIndex <= 0 Then
            Inventory.ShieldWorn = Objects.ObjectKey.Empty
        Else
            Inventory.ShieldWorn = CType(Shield.SelectedItem, DataListItem).ObjectGUID
        End If

        If IsLoading Then Exit Sub

        CharacterManager.SetDirty(_CharacterKey, CharacterManager.DirtyStatus.Recalculate)
        RefreshPanelData()

        _IsDirty = True
    End Sub

    Private Sub ByWeight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByWeight.CheckedChanged
        Dim Character As Rules.Character
        Dim Inventory As Rules.Inventory

        Character = CharacterManager.GetCharacter(_CharacterKey)
        Inventory = Character.Inventory

        If ByWeight.Checked Then Inventory.Encumberance = Rules.Inventory.EncumberanceType.ByWeight

        'update the xml
        Inventory.Save()

        If IsLoading Then Exit Sub
        RefreshPanelData()
        _IsDirty = True
    End Sub

    Private Sub ByArmor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByArmor.CheckedChanged
        Dim Inventory As Rules.Inventory = CharacterManager.GetCharacter(_CharacterKey).Inventory
        If ByArmor.Checked Then Inventory.Encumberance = Rules.Inventory.EncumberanceType.ByArmor

        'update the xml
        Inventory.Save()

        If IsLoading Then Exit Sub
        RefreshPanelData()
        _IsDirty = True
    End Sub

    Private Sub Quantity_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quantity.EditValueChanged
        If ListView1.Items.Count = 0 Or ListView1.SelectedItems.Count = 0 Or Quantity.Properties.Enabled = False Or IsLoading Then
            Quantity.Properties.Enabled = False
            Quantity.EditValue = 1
            Exit Sub
        End If

        'check that the item is not money
        Dim Item As New Objects.ObjectData
        Item.Load(CType(ListView1.SelectedItems(0).Tag, Objects.ObjectKey))
        If Item.Type <> Objects.ItemType Then Exit Sub

        'if charges enabled then reset to zero
        If Charges.Enabled AndAlso CInt(Quantity.EditValue) > 1 Then
            IsLoading = True
            Charges.EditValue = 0
            Item.Element("Charges") = ""
            IsLoading = False
        End If

        'adjust qty and update list view item
        Item = Rules.Inventory.AdjustQuantity(Item.ObjectGUID, CType(Quantity.EditValue, Integer))
        ListView1.BeginUpdate()
        Rules.Inventory.MapInventoryItemToListViewItem(Item, ListView1.SelectedItems(0))
        ListView1.EndUpdate()        
        _IsDirty = True
    End Sub

    Private Sub Quantity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Quantity.Leave
        CharacterManager.SetDirty(_CharacterKey, CharacterManager.DirtyStatus.Recalculate)
        Me.RefreshPanelData()
    End Sub

    Private Sub Charges_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Charges.EditValueChanged
        If ListView1.Items.Count = 0 Or ListView1.SelectedItems.Count = 0 Or Charges.Properties.Enabled = False Or IsLoading Then
            Charges.Properties.Enabled = False
            Charges.EditValue = 0
            Exit Sub
        End If

        'check that the item is not money
        Dim Item As New Objects.ObjectData
        Item.Load(CType(ListView1.SelectedItems(0).Tag, Objects.ObjectKey))
        If Item.Type <> Objects.ItemType Then Exit Sub

        'if quantity enabled then reset to 1
        If Quantity.Enabled AndAlso CInt(Quantity.EditValue) > 1 Then
            IsLoading = True
            Quantity.EditValue = 1
            Item = Rules.Inventory.AdjustQuantity(Item.ObjectGUID, 1)
            IsLoading = False
        End If

        'adjust charges and update list view item
        If CInt(Charges.EditValue) = 0 Then
            Item.Element("Charges") = ""
        Else
            Item.ElementAsInteger("Charges") = CInt(Charges.EditValue)
        End If

        ListView1.BeginUpdate()
        Rules.Inventory.MapInventoryItemToListViewItem(Item, ListView1.SelectedItems(0))
        ListView1.EndUpdate()
        _IsDirty = True
    End Sub

#End Region

    'modifier colouring for text
    Private Sub SetModifierColour(ByVal Control As DevExpress.XtraEditors.TextEdit, ByVal Flag As Rules.Modifiers.Modifier)
        Select Case Flag
            Case Rules.Modifiers.Modifier.Negative
                Control.ForeColor = Color.Red
            Case Rules.Modifiers.Modifier.None
                Control.ForeColor = Color.Black
            Case Rules.Modifiers.Modifier.Positive
                Control.ForeColor = Color.MediumBlue
        End Select
    End Sub

    Private Sub AddMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMoney.Click
        Dim AddForm As New MoneyForm
        Try
            If RPGXplorer.Commands.EditForm Is Nothing Then
                AddForm.InitAdd(InventoryFolder)
                AddForm.ShowDialog()
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub InventoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultButton.Click
        If General.ShowQuestionDialog("This will set the default inventory for this creature's Race. This will overwrite any previous default inventory. Default inventory items are automaticaly added to this panel whenever a new character/companion of this race is created.") = DialogResult.Yes Then
            CharacterManager.CurrentCharacter.CreateDefaultInventory(True)
        End If
    End Sub

End Class
