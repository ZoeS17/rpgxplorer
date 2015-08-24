Option Explicit On
Option Strict On

Public Class ChooseWeaponDialog
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
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Items As System.Windows.Forms.ListBox
    Public WithEvents EnhancementBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents WieldDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public Shadows WithEvents Size As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DisableFlurry As System.Windows.Forms.CheckBox
    Public WithEvents DisableFinesse As System.Windows.Forms.CheckBox
    Public WithEvents ImprovisedMelee As System.Windows.Forms.CheckBox
    Public WithEvents InventoryOnly As System.Windows.Forms.RadioButton
    Public WithEvents Ordinary As System.Windows.Forms.RadioButton
    Public WithEvents Masterwork As System.Windows.Forms.RadioButton
    Public WithEvents Enhanced As System.Windows.Forms.RadioButton
    Public WithEvents MagicItems As System.Windows.Forms.RadioButton
    Public WithEvents PsionicItems As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ChooseWeaponDialog))
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Items = New System.Windows.Forms.ListBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DisableFlurry = New System.Windows.Forms.CheckBox
        Me.DisableFinesse = New System.Windows.Forms.CheckBox
        Me.ImprovisedMelee = New System.Windows.Forms.CheckBox
        Me.InventoryOnly = New System.Windows.Forms.RadioButton
        Me.Ordinary = New System.Windows.Forms.RadioButton
        Me.Masterwork = New System.Windows.Forms.RadioButton
        Me.Enhanced = New System.Windows.Forms.RadioButton
        Me.MagicItems = New System.Windows.Forms.RadioButton
        Me.PsionicItems = New System.Windows.Forms.RadioButton
        Me.EnhancementBonus = New DevExpress.XtraEditors.SpinEdit
        Me.WieldDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Size = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WieldDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Size.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(502, 528)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 24)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK.Enabled = False
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(417, 528)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 24)
        Me.OK.TabIndex = 13
        Me.OK.Text = "OK"
        '
        'Items
        '
        Me.Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Items.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Items.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Items.IntegralHeight = False
        Me.Items.ItemHeight = 59
        Me.Items.Location = New System.Drawing.Point(210, 0)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(382, 513)
        Me.Items.TabIndex = 0
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(0, 513)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(592, 5)
        Me.IndentedLine1.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please choose how you want to wield this weapon."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 21)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Show"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Size"
        '
        'DisableFlurry
        '
        Me.DisableFlurry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DisableFlurry.Enabled = False
        Me.DisableFlurry.Location = New System.Drawing.Point(15, 480)
        Me.DisableFlurry.Name = "DisableFlurry"
        Me.DisableFlurry.Size = New System.Drawing.Size(150, 21)
        Me.DisableFlurry.TabIndex = 12
        Me.DisableFlurry.Text = "Disable Flurry of Blows"
        '
        'DisableFinesse
        '
        Me.DisableFinesse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DisableFinesse.Enabled = False
        Me.DisableFinesse.Location = New System.Drawing.Point(15, 450)
        Me.DisableFinesse.Name = "DisableFinesse"
        Me.DisableFinesse.Size = New System.Drawing.Size(150, 21)
        Me.DisableFinesse.TabIndex = 11
        Me.DisableFinesse.Text = "Disable Weapon Finesse"
        '
        'ImprovisedMelee
        '
        Me.ImprovisedMelee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImprovisedMelee.Enabled = False
        Me.ImprovisedMelee.Location = New System.Drawing.Point(15, 420)
        Me.ImprovisedMelee.Name = "ImprovisedMelee"
        Me.ImprovisedMelee.Size = New System.Drawing.Size(165, 21)
        Me.ImprovisedMelee.TabIndex = 10
        Me.ImprovisedMelee.Text = "Use as Improvised Melee"
        '
        'InventoryOnly
        '
        Me.InventoryOnly.Location = New System.Drawing.Point(15, 40)
        Me.InventoryOnly.Name = "InventoryOnly"
        Me.InventoryOnly.Size = New System.Drawing.Size(104, 21)
        Me.InventoryOnly.TabIndex = 1
        Me.InventoryOnly.Text = "Inventory Only"
        '
        'Ordinary
        '
        Me.Ordinary.Location = New System.Drawing.Point(15, 70)
        Me.Ordinary.Name = "Ordinary"
        Me.Ordinary.Size = New System.Drawing.Size(145, 21)
        Me.Ordinary.TabIndex = 2
        Me.Ordinary.Text = "Normal"
        '
        'Masterwork
        '
        Me.Masterwork.Location = New System.Drawing.Point(15, 100)
        Me.Masterwork.Name = "Masterwork"
        Me.Masterwork.Size = New System.Drawing.Size(104, 21)
        Me.Masterwork.TabIndex = 3
        Me.Masterwork.Text = "Masterwork"
        '
        'Enhanced
        '
        Me.Enhanced.Location = New System.Drawing.Point(15, 130)
        Me.Enhanced.Name = "Enhanced"
        Me.Enhanced.Size = New System.Drawing.Size(104, 21)
        Me.Enhanced.TabIndex = 4
        Me.Enhanced.Text = "Enhanced"
        '
        'MagicItems
        '
        Me.MagicItems.Location = New System.Drawing.Point(15, 160)
        Me.MagicItems.Name = "MagicItems"
        Me.MagicItems.Size = New System.Drawing.Size(155, 21)
        Me.MagicItems.TabIndex = 6
        Me.MagicItems.Text = "Magic Weapons/Shields"
        '
        'PsionicItems
        '
        Me.PsionicItems.Location = New System.Drawing.Point(15, 190)
        Me.PsionicItems.Name = "PsionicItems"
        Me.PsionicItems.Size = New System.Drawing.Size(155, 21)
        Me.PsionicItems.TabIndex = 101
        Me.PsionicItems.Text = "Psionic Weapons/Shields"
        '
        'EnhancementBonus
        '
        Me.EnhancementBonus.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Location = New System.Drawing.Point(95, 130)
        Me.EnhancementBonus.Name = "EnhancementBonus"
        '
        'EnhancementBonus.Properties
        '
        Me.EnhancementBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.EnhancementBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EnhancementBonus.Properties.AutoHeight = False
        Me.EnhancementBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.EnhancementBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EnhancementBonus.Properties.IsFloatValue = False
        Me.EnhancementBonus.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.EnhancementBonus.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EnhancementBonus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.EnhancementBonus.Size = New System.Drawing.Size(50, 21)
        Me.EnhancementBonus.TabIndex = 5
        '
        'WieldDropdown
        '
        Me.WieldDropdown.Location = New System.Drawing.Point(15, 265)
        Me.WieldDropdown.Name = "WieldDropdown"
        '
        'WieldDropdown.Properties
        '
        Me.WieldDropdown.Properties.AutoHeight = False
        Me.WieldDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WieldDropdown.Properties.DropDownRows = 10
        Me.WieldDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.WieldDropdown.Size = New System.Drawing.Size(150, 21)
        Me.WieldDropdown.TabIndex = 7
        '
        'Size
        '
        Me.Size.Location = New System.Drawing.Point(15, 320)
        Me.Size.Name = "Size"
        '
        'Size.Properties
        '
        Me.Size.Properties.AutoHeight = False
        Me.Size.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Size.Properties.DropDownRows = 10
        Me.Size.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Size.Size = New System.Drawing.Size(150, 21)
        Me.Size.TabIndex = 8
        '
        'ChooseWeaponDialog
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(592, 566)
        Me.Controls.Add(Me.PsionicItems)
        Me.Controls.Add(Me.InventoryOnly)
        Me.Controls.Add(Me.ImprovisedMelee)
        Me.Controls.Add(Me.DisableFinesse)
        Me.Controls.Add(Me.DisableFlurry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EnhancementBonus)
        Me.Controls.Add(Me.WieldDropdown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.Items)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Size)
        Me.Controls.Add(Me.Ordinary)
        Me.Controls.Add(Me.Masterwork)
        Me.Controls.Add(Me.Enhanced)
        Me.Controls.Add(Me.MagicItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 420)
        Me.Name = "ChooseWeaponDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Wielding Option"
        CType(Me.EnhancementBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WieldDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Size.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Enumerations"

    Public Enum ViewMode
        Inventory
        Ordinary
        Masterwork
        Enhanced
        Magic
        Psionic
    End Enum

#End Region

#Region "Member Variables"

    Private IsLoading As Boolean = True
    Private _Character As Rules.Character
    Private _Monster As Objects.ObjectData
    Private _InventoryFolder As Objects.ObjectKey
    Private _Weapons As New Rules.Weapons
    Private _Mode As ViewMode
    Private _Hand As Rules.Weapons.Hand
    Private _CharacterSize As String
    Public Choice As Rules.Weapons.WeaponsData
    Public Wield As Rules.Weapons.Wield

#End Region

    'init
    Public Sub Init(ByVal Mode As ViewMode, ByVal Hand As Rules.Weapons.Hand, ByVal InventoryFolder As Objects.ObjectKey, ByVal Character As Rules.Character, ByVal Weapons As Rules.Weapons)
        Try
            _Character = Character
            _Weapons = Weapons
            _InventoryFolder = InventoryFolder
            _Mode = Mode
            _Hand = Hand
            _CharacterSize = _Character.Size

            'load size dropdown
            Size.Properties.Items.AddRange(Rules.Lists.Sizes)
            Size.Text = _CharacterSize

            'set the caption
            Select Case _Hand
                Case Rules.Weapons.Hand.Primary
                    Me.Text = "Choose Primary Weapon"
                    If Weapons.FlurryAvailable Then DisableFlurry.Enabled = True
                    If _Character.Components.SystemAbilities(References.WeaponFinesse) Then DisableFinesse.Enabled = True
                Case Rules.Weapons.Hand.OffHand
                    Me.Text = "Choose Off-Hand Weapon/Shield"
                Case Rules.Weapons.Hand.Buckler
                    Me.Text = "Choose Buckler"
            End Select

            'set the corresponding checkbox
            Select Case _Mode
                Case ViewMode.Enhanced
                    Enhanced.Checked = True
                Case ViewMode.Inventory
                    InventoryOnly.Checked = True
                Case ViewMode.Magic
                    MagicItems.Checked = True
                Case ViewMode.Masterwork
                    Masterwork.Checked = True
                Case ViewMode.Ordinary
                    Ordinary.Checked = True
            End Select

            IsLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub LoadList()
        Dim Sorted As New SortedList
        Dim WeaponsData As New Rules.Weapons.WeaponsData
        Dim Add As Boolean

        Try
            Items.BeginUpdate()
            Items.Items.Clear()

            'determine the xpath to use
            Dim ItemList As New Objects.ObjectDataCollection

            Select Case _Mode
                Case ViewMode.Inventory
                    Select Case _Hand
                        Case Rules.Weapons.Hand.Primary, Rules.Weapons.Hand.OffHand
                            ItemList = ObjectQueries.InventoryPrimaryWeapons(_InventoryFolder, _Hand)
                        Case Rules.Weapons.Hand.Buckler
                            ItemList = ObjectQueries.InventoryBucklers(_InventoryFolder)
                    End Select
                Case ViewMode.Magic
                    Select Case _Hand
                        Case Rules.Weapons.Hand.Primary, Rules.Weapons.Hand.OffHand
                            ItemList = ObjectQueries.MagicPrimaryWeapons
                        Case Rules.Weapons.Hand.Buckler
                            ItemList = ObjectQueries.MagicBucklers
                    End Select
                Case ViewMode.Psionic
                    Select Case _Hand
                        Case Rules.Weapons.Hand.Primary, Rules.Weapons.Hand.OffHand
                            ItemList = ObjectQueries.PsionicPrimaryWeapons
                        Case Rules.Weapons.Hand.Buckler
                            ItemList = ObjectQueries.PsionicBucklers
                    End Select
                Case ViewMode.Masterwork
                    Select Case _Hand
                        Case Rules.Weapons.Hand.Primary, Rules.Weapons.Hand.OffHand
                            ItemList = ObjectQueries.WeaponsNoMasterwork
                            ItemList.AddMany(ObjectQueries.ShieldPrimaryWeaponsNoMasterwork)
                        Case Rules.Weapons.Hand.Buckler
                            ItemList = ObjectQueries.BucklersNoMasterwork
                    End Select
                Case ViewMode.Enhanced
                    Select Case _Hand
                        Case Rules.Weapons.Hand.Primary, Rules.Weapons.Hand.OffHand
                            ItemList = ObjectQueries.Weapons
                            ItemList.AddMany(ObjectQueries.ShieldPrimaryWeapons)
                        Case Rules.Weapons.Hand.Buckler
                            ItemList = ObjectQueries.Bucklers
                    End Select
                Case ViewMode.Ordinary
                    Select Case _Hand
                        Case Rules.Weapons.Hand.Primary, Rules.Weapons.Hand.OffHand
                            ItemList = ObjectQueries.Weapons
                            ItemList.AddMany(ObjectQueries.ShieldPrimaryWeapons)
                        Case Rules.Weapons.Hand.Buckler
                            ItemList = ObjectQueries.Bucklers
                    End Select
            End Select

            'load the list
            Sorted = Sorter.LoadSortedList(ItemList, General.SortType.Alphabetic)
            For Each Item As Objects.ObjectData In Sorted.GetValueList

                'init new WeaponsData
                WeaponsData.Clear()
                Add = True

                'set inventory item if required
                If Item.Type = Objects.ItemType Then
                    WeaponsData.InventoryItem = Item
                    Item = Item.GetFKObject("Item")
                End If

                'item/base item
                WeaponsData.Item = Item
                WeaponsData.BaseItem = CommonLogic.GetBaseWeaponOrArmor(Item)
                WeaponsData.Hand = _Hand
                WeaponsData.Weapons = _Weapons

                'size
                If WeaponsData.InventoryItem.Element("Size") <> "" Then
                    WeaponsData.WeaponSize = WeaponsData.InventoryItem.Element("Size")
                Else
                    WeaponsData.WeaponSize = Size.Text
                End If

                'masterwork/enhancement
                If Not WeaponsData.InventoryItem.IsEmpty Then
                    If WeaponsData.InventoryItem.Element("Masterwork") = "Yes" Then WeaponsData.Masterwork = True
                    If WeaponsData.InventoryItem.Element("EnhancementBonus") <> "" Then WeaponsData.Enhancement = WeaponsData.InventoryItem.ElementAsInteger("EnhancementBonus")
                    WeaponsData.Bane = WeaponsData.InventoryItem.GetFKGuid("Bane")
                Else
                    If Masterwork.Checked Then WeaponsData.Masterwork = True
                    If Enhanced.Checked Then WeaponsData.Enhancement = CType(EnhancementBonus.EditValue, Integer)
                End If

                'wield
                If _Hand = Rules.Weapons.Hand.Primary AndAlso _Character.Components.SystemAbilities(References.SimianGrasp) Then
                    WeaponsData.WieldData = Rules.Weapons.GetWieldData(WeaponsData.BaseItem, WeaponsData.WeaponSize, True)
                Else
                    WeaponsData.WieldData = Rules.Weapons.GetWieldData(WeaponsData.BaseItem, WeaponsData.WeaponSize)
                End If

                'properties
                WeaponsData.Properties = New Rules.WeaponProperties(WeaponsData, _Character, Rules.WeaponProperties.InitMode.List, Rules.Weapons.Wield.NotSet)

                'some items need to be excluded at this point
                If _Hand = Rules.Weapons.Hand.OffHand Then
                    Select Case WeaponsData.WieldData.WieldType
                        Case Rules.Weapons.WieldType.Buckler, Rules.Weapons.WieldType.TwoHanded, Rules.Weapons.WieldType.TwoHandedRanged
                            Add = False
                    End Select
                End If

                If Add Then Items.Items.Add(WeaponsData)
            Next

            Items.EndUpdate()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Paint Events"

    Private Sub DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Items.DrawItem
        Dim WeaponsData As Rules.Weapons.WeaponsData
        Dim x, y As Integer
        Dim Icon As Bitmap
        Dim BoldFont As New Font("Arial", 8, FontStyle.Bold)
        Dim RegFont As New Font("Arial", 8, FontStyle.Regular)
        Dim Display As Rules.Weapons.DisplayDetails

        Try
            'get the corresponding weapon
            If e.Index = -1 Then Exit Sub
            WeaponsData = CType(Items.Items(e.Index), Rules.Weapons.WeaponsData)
            Display = _Weapons.GetDialogItemDisplay(WeaponsData)

            'draw the weapon
            x = e.Bounds.Left
            y = e.Bounds.Top

            'background
            e.DrawBackground()
            If WeaponsData.WieldData.WieldType = Rules.Weapons.WieldType.CannotUse Then
                e.Graphics.FillRectangle(Brushes.Salmon, e.Bounds)
            End If

            Icon = New Bitmap(General.BasePath & "Images\LargeImages\" & WeaponsData.Item.ImageFilename)
            e.Graphics.DrawImage(Icon, New Rectangle(x + 4, y + 4, 51, 51))

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
            e.Graphics.DrawString(Display.Line1, BoldFont, Brushes.Black, x + 60, y + 2)
            e.Graphics.DrawString(Display.Line2, RegFont, Brushes.DimGray, x + 60, y + 15)
            e.Graphics.DrawString(Display.Line3, RegFont, Brushes.RosyBrown, x + 60, y + 28)
            e.Graphics.DrawString(Display.Line4, RegFont, Brushes.RoyalBlue, x + 60, y + 41)
            e.DrawFocusRectangle()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ChooseWeaponDialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim rect As New Rectangle(0, 0, 210, Me.Height - (Me.Height - IndentedLine1.Top))
        Dim gradbrush As New Drawing2D.LinearGradientBrush(rect, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)

        Try
            e.Graphics.FillRectangle(gradbrush, rect)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ChooseWeaponDialog_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

#End Region

#Region "Click Handlers"

    'ok
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            'set dialog results
            Choice = CType(Items.SelectedItem, Rules.Weapons.WeaponsData)
            Choice.ImprovisedMelee = ImprovisedMelee.Checked
            Choice.DisableFlurry = DisableFlurry.Checked
            Choice.DisableFinesse = DisableFinesse.Checked
            Choice.Properties = New Rules.WeaponProperties(Choice, Me._Character, Rules.WeaponProperties.InitMode.Weapons, Rules.Weapons.Wield.NotSet)

            'check for bane
            Select Case Choice.Item.Type
                Case Objects.SpecificWeaponDefinitionType, Objects.MagicAmmoDefinitionType, Objects.PsionicWeaponDefinitionType, Objects.PsionicAmmoDefinitionType
                    If Rules.WeaponProperties.HasBaneCondition(Choice.Item) Then
                        If Choice.Bane.Equals(Objects.ObjectKey.Empty) Then
                            Dim BaneKey As Objects.ObjectKey = CommonLogic.SelectBaneFocus(Choice.Item)
                            If BaneKey.Equals(Objects.ObjectKey.Empty) Then
                                General.ShowInfoDialog("No bane selected. Item not chosen.")
                                Exit Sub
                            Else
                                Choice.Bane = BaneKey
                            End If
                        End If
                    End If
            End Select

            'set wield 
            Select Case WieldDropdown.Text
                Case "As Shield"
                    Wield = Rules.Weapons.Wield.Shield
                Case "As Weapon"
                    Wield = Rules.Weapons.Wield.ShieldBash
                Case "One-Handed"
                    Wield = Rules.Weapons.Wield.OneHanded
                Case "Two-Handed"
                    Wield = Rules.Weapons.Wield.TwoHanded
                Case "As Double Weapon"
                    Wield = Rules.Weapons.Wield.DoubleWeapon
                Case "Thrown"
                    Wield = Rules.Weapons.Wield.Thrown
            End Select

            'close dialog
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Try
            Choice = Nothing
            Wield = Rules.Weapons.Wield.NotSet
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Event Handling"

    Private Sub Ordinary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ordinary.CheckedChanged
        Try
            If Ordinary.Checked Then
                OK.Enabled = False
                _Mode = ViewMode.Ordinary
                InventoryOnly.Checked = False
                Masterwork.Checked = False
                Enhanced.Checked = False
                MagicItems.Checked = False
                Size.Properties.Enabled = True
                IsLoading = True
                Size.Text = _CharacterSize
                IsLoading = False
                WieldDropdown.SelectedIndex = -1
                WieldDropdown.Properties.Enabled = False
                LoadList()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub InventoryOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryOnly.CheckedChanged
        Try
            If InventoryOnly.Checked Then
                OK.Enabled = False
                _Mode = ViewMode.Inventory
                Masterwork.Checked = False
                Enhanced.Checked = False
                MagicItems.Checked = False
                Ordinary.Checked = False
                Size.Properties.Enabled = False
                IsLoading = True
                Size.SelectedIndex = -1
                IsLoading = False
                WieldDropdown.SelectedIndex = -1
                WieldDropdown.Properties.Enabled = False
                LoadList()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Masterwork_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Masterwork.CheckedChanged
        Try
            If Masterwork.Checked Then
                OK.Enabled = False
                _Mode = ViewMode.Masterwork
                InventoryOnly.Checked = False
                Enhanced.Checked = False
                MagicItems.Checked = False
                Ordinary.Checked = False
                Size.Properties.Enabled = True
                IsLoading = True
                Size.Text = _CharacterSize
                IsLoading = False
                WieldDropdown.SelectedIndex = -1
                WieldDropdown.Properties.Enabled = False
                LoadList()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Enhanced_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enhanced.CheckedChanged
        Try
            If Enhanced.Checked Then
                OK.Enabled = False
                _Mode = ViewMode.Enhanced
                EnhancementBonus.Properties.Enabled = True
                InventoryOnly.Checked = False
                Masterwork.Checked = False
                MagicItems.Checked = False
                Ordinary.Checked = False
                Size.Properties.Enabled = True
                IsLoading = True
                Size.Text = _CharacterSize
                IsLoading = False
                WieldDropdown.SelectedIndex = -1
                WieldDropdown.Properties.Enabled = False
                LoadList()
            Else
                EnhancementBonus.EditValue = 1
                EnhancementBonus.Properties.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MagicItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagicItems.CheckedChanged
        Try
            If MagicItems.Checked Then
                OK.Enabled = False
                _Mode = ViewMode.Magic
                InventoryOnly.Checked = False
                Masterwork.Checked = False
                Enhanced.Checked = False
                Ordinary.Checked = False
                Size.Properties.Enabled = True
                IsLoading = True
                Size.Text = _CharacterSize
                IsLoading = False
                WieldDropdown.SelectedIndex = -1
                WieldDropdown.Properties.Enabled = False
                LoadList()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Items_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Items.SelectedIndexChanged
        Dim WeaponsData As Rules.Weapons.WeaponsData
        Dim WeaponSize As String
        Dim WieldType As Rules.Weapons.WieldType

        Try
            If IsLoading Then Exit Sub
            If Items.SelectedIndex = -1 Then
                OK.Enabled = False
                Exit Sub
            Else
                OK.Enabled = True
            End If

            WeaponsData = CType(Items.SelectedItem, Rules.Weapons.WeaponsData)

            'check for improvised melee
            If WeaponsData.BaseItem.Element("ImprovisedMelee") = "Yes" Then
                ImprovisedMelee.Enabled = True
            Else
                ImprovisedMelee.Enabled = False
                ImprovisedMelee.Checked = False
            End If

            'off hand weapons can only be wielded one-handed
            If _Hand = Rules.Weapons.Hand.OffHand Then
                Select Case WeaponsData.WieldData.WieldType
                    Case Rules.Weapons.WieldType.LightShield, Rules.Weapons.WieldType.Shield
                        'give option to wield shield as weapon
                        If WeaponsData.BaseItem.Element("DamageType") = "" Then
                            WieldDropdown.Properties.Enabled = False
                            WieldDropdown.Properties.Items.Clear()
                            WieldDropdown.Properties.Items.Add("As Shield")
                            WieldDropdown.SelectedIndex = 0
                            Exit Sub
                        Else
                            WieldDropdown.Properties.Enabled = True
                            WieldDropdown.Properties.Items.Clear()
                            WieldDropdown.Properties.Items.Add("As Shield")
                            WieldDropdown.Properties.Items.Add("As Weapon")
                            WieldDropdown.SelectedIndex = 0
                            Exit Sub
                        End If
                    Case Else
                        WieldDropdown.Properties.Enabled = False
                        WieldDropdown.Properties.Items.Clear()
                        WieldDropdown.Properties.Items.Add("One-Handed")
                        If WeaponsData.Properties.Thrown Then
                            WieldDropdown.Properties.Items.Add("Thrown")
                            WieldDropdown.Properties.Enabled = True
                        End If
                        WieldDropdown.SelectedIndex = 0
                        Exit Sub
                End Select
            End If

            'get weapon size
            Select Case WeaponsData.Item.Type
                Case Objects.ItemType
                    WeaponSize = WeaponsData.Item.Element("Size")
                Case Else
                    WeaponSize = Size.Text
            End Select

            'disable weapon finesse checkbox?
            If WeaponSize = _CharacterSize Then
                If _Character.Components.SystemAbilities(References.WeaponFinesse) Then DisableFinesse.Enabled = True
            Else
                DisableFinesse.Checked = False
                DisableFinesse.Enabled = False
            End If

            'determine wield options for primary
            If _Hand = Rules.Weapons.Hand.Primary AndAlso _Character.Components.SystemAbilities(References.SimianGrasp) Then
                WieldType = Rules.Weapons.GetWieldData(WeaponsData.BaseItem, WeaponsData.WeaponSize, True).WieldType
            Else
                WieldType = Rules.Weapons.GetWieldData(WeaponsData.BaseItem, WeaponsData.WeaponSize).WieldType
            End If

            If WieldType = Rules.Weapons.WieldType.CannotUse Then
                OK.Enabled = False
                WieldDropdown.Text = "Too Large or Small"
                WieldDropdown.Properties.Enabled = False
            Else
                OK.Enabled = True
                WieldDropdown.Text = ""
                WieldDropdown.Properties.Items.Clear()

                Select Case WieldType
                    Case Rules.Weapons.WieldType.Buckler
                        WieldDropdown.SelectedIndex = -1
                    Case Rules.Weapons.WieldType.LightShield, Rules.Weapons.WieldType.Shield
                        WieldDropdown.Properties.Items.Add("As Weapon")
                        WieldDropdown.SelectedIndex = 0
                    Case Rules.Weapons.WieldType.DoubleWeapon, Rules.Weapons.WieldType.DoubleWeaponFinesse
                        WieldDropdown.Properties.Items.Add("One-Handed")
                        WieldDropdown.Properties.Items.Add("Two-Handed")
                        WieldDropdown.Properties.Items.Add("As Double Weapon")
                        If WeaponsData.Properties.Thrown Then WieldDropdown.Properties.Items.Add("Thrown")
                        WieldDropdown.SelectedIndex = 2
                    Case Rules.Weapons.WieldType.LightMelee, Rules.Weapons.WieldType.OneHandedMeleeFinesseRestricted
                        WieldDropdown.Properties.Items.Add("One-Handed")
                        If WeaponsData.Properties.Thrown Then WieldDropdown.Properties.Items.Add("Thrown")
                        WieldDropdown.SelectedIndex = 0
                    Case Rules.Weapons.WieldType.OneHandedRanged
                        WieldDropdown.Properties.Items.Add("One-Handed")
                        If WeaponsData.Properties.Thrown Then
                            WieldDropdown.Properties.Items.Add("Thrown")
                            WieldDropdown.SelectedIndex = 1
                        Else
                            WieldDropdown.SelectedIndex = 0
                        End If
                    Case Rules.Weapons.WieldType.OneHandedMelee, Rules.Weapons.WieldType.OneHandedMeleeFinesse
                        WieldDropdown.Properties.Items.Add("One-Handed")
                        WieldDropdown.Properties.Items.Add("Two-Handed")
                        If WeaponsData.Properties.Thrown Then WieldDropdown.Properties.Items.Add("Thrown")
                        WieldDropdown.SelectedIndex = 0
                    Case Rules.Weapons.WieldType.TwoHandedRangedFireOneHandedHeavy, Rules.Weapons.WieldType.TwoHandedRangedFireOneHandedLight
                        WieldDropdown.Properties.Items.Add("One-Handed")
                        WieldDropdown.Properties.Items.Add("Two-Handed")
                        WieldDropdown.SelectedIndex = 1
                    Case Rules.Weapons.WieldType.TwoHanded, Rules.Weapons.WieldType.TwoHandedMeleeFinesse
                        WieldDropdown.Properties.Items.Add("Two-Handed")
                        If WeaponsData.Properties.Thrown Then WieldDropdown.Properties.Items.Add("Thrown")
                        WieldDropdown.SelectedIndex = 0
                    Case Rules.Weapons.WieldType.TwoHandedRanged
                        WieldDropdown.Properties.Items.Add("Two-Handed")
                        WieldDropdown.SelectedIndex = 0
                End Select

                If WieldDropdown.Properties.Items.Count > 1 Then WieldDropdown.Enabled = True Else WieldDropdown.Enabled = False

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub WieldDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WieldDropdown.SelectedIndexChanged
        Try
            If WieldDropdown.Text = "Thrown" Then
                If ImprovisedMelee.Checked Then ImprovisedMelee.Checked = False
                If DisableFinesse.Checked Then DisableFinesse.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ImprovisedMelee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprovisedMelee.CheckedChanged
        Try
            If ImprovisedMelee.Checked And WieldDropdown.Text = "Thrown" Then
                General.ShowInfoDialog("Change wield to something other than 'Thrown'. Can't set a weapon to 'Thrown' and 'Improvised Melee' at the same time.")
                ImprovisedMelee.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DisableFinesse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableFinesse.CheckedChanged
        Try
            If DisableFinesse.Checked And WieldDropdown.Text = "Thrown" Then
                General.ShowInfoDialog("Change wield to something other than 'Thrown'. Can't set a weapon to 'Thrown' and 'Disable Weapon Finesse' at the same time.")
                DisableFinesse.Checked = False
                Exit Sub
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Size_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Size.SelectedIndexChanged
        Try
            If Size.Text <> "" And Not IsLoading Then
                LoadList()
                Items.Refresh()
                OK.Enabled = False
                ImprovisedMelee.Enabled = False
                ImprovisedMelee.Checked = False

                If Size.Text = _CharacterSize And _Hand = Rules.Weapons.Hand.Primary Then
                    If _Character.Components.SystemAbilities(References.WeaponFinesse) Then DisableFinesse.Enabled = True
                Else
                    DisableFinesse.Checked = False
                    DisableFinesse.Enabled = False
                End If

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EnhancementBonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancementBonus.EditValueChanged
        Try
            If EnhancementBonus.Properties.Enabled And Not IsLoading Then
                OK.Enabled = False
                LoadList()
                Items.Refresh()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region


    Private Sub PsionicItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PsionicItems.CheckedChanged
        If PsionicItems.Checked Then
            OK.Enabled = False
            _Mode = ViewMode.Psionic
            InventoryOnly.Checked = False
            Masterwork.Checked = False
            Enhanced.Checked = False
            Ordinary.Checked = False
            Size.Properties.Enabled = True
            Size.Text = _CharacterSize
            WieldDropdown.SelectedIndex = -1
            WieldDropdown.Properties.Enabled = False
            LoadList()
        End If
    End Sub

End Class