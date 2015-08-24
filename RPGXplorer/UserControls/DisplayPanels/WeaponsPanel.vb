Option Explicit On
Option Strict On

Imports RPGXplorer.General

Public Class WeaponsPanel
    Implements IPanel

#Region "Member Variables"

    Private _Dirty As Boolean
    Public IsLoading As Boolean
    Private _InventoryFolder, _WeaponConfigFolder As Objects.ObjectKey
    Private _WeaponProficiency As Rules.Proficiency
    Private BaseLineComponents As Rules.Components
    Private WeaponsList As ArrayList
    Private _FocusedWeaponsConfig As IWeaponConfig
    Private _CharacterKey As Objects.ObjectKey

    Public Character As Rules.Character

#End Region

#Region "Properties"

    Public ReadOnly Property InventoryFolder() As Objects.ObjectKey
        Get
            Return _InventoryFolder
        End Get
    End Property

    Public ReadOnly Property WeaponConfigFolder() As Objects.ObjectKey
        Get
            Return _WeaponConfigFolder
        End Get
    End Property

    Public Property IsDirty() As Boolean Implements IPanel.IsDirty
        Get
            Return _Dirty
        End Get
        Set(ByVal Value As Boolean)
            _Dirty = Value
        End Set
    End Property

#End Region

    'init
    Public Sub Init(ByVal CharacterGuid As Objects.ObjectKey)
        Dim Character As Rules.Character

        Try
            'IsLoading = True
            _CharacterKey = CharacterGuid

            'required for correct drawing when switching between characters
            ConfigsPanel.Controls.Clear()

            'dont save this character as the Panel.Character, as this is just to get the folder info
            Character = CharacterManager.GetCharacter(CharacterGuid)

            _WeaponProficiency = New Rules.Proficiency(Character)
            _WeaponProficiency.Calculate()

            'get folder guids
            _InventoryFolder = Character.CharacterObject.FirstChildOfType(Objects.InventoryFolderType).ObjectGUID
            _WeaponConfigFolder = Character.CharacterObject.FirstChildOfType(Objects.WeaponConfigFolderType).ObjectGUID

            CType(Me.Parent, CentralDisplayForm).NeedsPanelInit = False
            'IsLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load existing WeaponsConfigurations
    Private Sub LoadWeaponsList(ByVal Character As Rules.Character)
        Dim WeaponsConfigFolder As New Objects.ObjectData
        Dim Sorted As SortedList
        Dim Enumerator As IEnumerator

        Try
            'get the WeaponsList in sort order
            WeaponsConfigFolder.Load(_WeaponConfigFolder)
            Sorted = Sorter.LoadSortedList(WeaponsConfigFolder.ChildrenOfType(Objects.WeaponConfigType), SortType.NumericSuffix)

            WeaponsList = New ArrayList

            'get save WeaponsConfigurations
            Enumerator = Sorted.GetEnumerator

            While Enumerator.MoveNext
                AddWeaponsConfiguration(CType(CType(Enumerator.Current, DictionaryEntry).Value, Objects.ObjectData), Character)
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save WeaponsConfigurations
    Public Sub Save() Implements IPanel.Save
        Try
            If _Dirty Then
                General.MainExplorer.Undo.UndoRecord()
                For Each WeaponsConfig As IWeaponConfig In WeaponsList
                    WeaponsConfig.Weapons.Save()
                Next
                _Dirty = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add WeaponsConfiguration 
    Private Sub AddWeaponsConfiguration(ByVal WeaponsObj As Objects.ObjectData, ByVal Character As Rules.Character)
        Dim WeaponsConfig As IWeaponConfig
        Dim Weapons As Rules.Weapons
        Dim Inventory As Rules.Inventory
        Dim Top As Integer
        Try

            Inventory = Character.Inventory
            If WeaponsObj.Element("MonsterConfig") = "Yes" Then
                WeaponsConfig = New MonsterWeaponConfiguration
            Else
                WeaponsConfig = New WeaponConfiguration
            End If

            'get current highest "Top" value
            For Each WC As IWeaponConfig In WeaponsList
                If WC.Top > Top Then Top = WC.Top
            Next
            If ConfigsPanel.Controls.Count > 0 Then Top += WeaponsConfig.Height

            'WeaponsConfig.Top = WeaponsConfig.Height * ConfigsPanel.Controls.Count
            WeaponsConfig.Top = Top
            WeaponsConfig.Left = 0
            WeaponsConfig.Width = ConfigsPanel.ClientRectangle.Width
            WeaponsConfig.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
            WeaponsConfig.TabStop = False
            AddHandler WeaponsConfig.GotFocus, AddressOf HandleFocus
            AddHandler WeaponsConfig.Dirty, AddressOf HandleDirty

            If WeaponsObj.IsEmpty Then
                Weapons = New Rules.Weapons
                Weapons.Init(Character, _WeaponProficiency, Inventory, _WeaponConfigFolder, BaseLineComponents)
            Else
                If WeaponsObj.Element("MonsterConfig") = "Yes" Then
                    Weapons = New Rules.MonsterWeapons
                    Weapons.Init(Character, _WeaponProficiency, Inventory, _WeaponConfigFolder, BaseLineComponents)
                    Weapons.Load(WeaponsObj)
                Else
                    Weapons = New Rules.Weapons
                    Weapons.Init(Character, _WeaponProficiency, Inventory, _WeaponConfigFolder, BaseLineComponents)
                    Weapons.Load(WeaponsObj)
                End If
            End If

            WeaponsConfig.Init(Me, Weapons)
            ConfigsPanel.Controls.Add(CType(WeaponsConfig, Control))
            WeaponsList.Add(WeaponsConfig)
            If WeaponsConfig.Weapons.Index = 0 Then WeaponsConfig.Weapons.Index = ConfigsPanel.Controls.Count

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Click Handlers"

    Private Sub AddMonsterConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMonsterConfig.Click
        Try

            Dim AttackOptions As New CreateAttackDialog
            AttackOptions.Init(Character.RaceObject)
            If AttackOptions.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            End If

            'need to make a weapons obj
            Dim AttackData As CreateAttackDialog.AttackData
            Dim WeaponsObj As New Objects.ObjectData

            WeaponsObj.ObjectGUID = Objects.ObjectKey.NewGuid(Character.CharacterObject.ObjectGUID.Database)
            WeaponsObj.Name = "Weapon Configuration " & (ConfigsPanel.Controls.Count + 1).ToString
            WeaponsObj.Type = Objects.WeaponConfigType
            WeaponsObj.ParentGUID = _WeaponConfigFolder
            WeaponsObj.ElementAsInteger("Index") = ConfigsPanel.Controls.Count + 1
            WeaponsObj.Element("MonsterConfig") = "Yes"

            AttackData = AttackOptions.PrimaryAttackData()

            'if we have a primary attack - add the slot for it
            Select Case AttackData.Type

                Case CreateAttackDialog.AttackType.Manufactured

                Case CreateAttackDialog.AttackType.Natural

                    'check if this is a single or multiple attack (for strength bonus)
                    If AttackData.STRBonus = Rules.Weapons.STRBonus.Max Then
                        WeaponsObj.ElementAsInteger("PrimaryWield") = Rules.Weapons.Wield.TwoHanded
                    Else
                        WeaponsObj.ElementAsInteger("PrimaryWield") = Rules.Weapons.Wield.OneHanded
                    End If

                    WeaponsObj.ElementAsInteger("PrimaryAttackNumber") = AttackData.Number
                    WeaponsObj.FKElement("PrimaryWeapon", AttackData.Weapon.Name, "Name", AttackData.Weapon.ObjectGUID)
                    If AttackData.Enhancement > 0 Then WeaponsObj.ElementAsInteger("PrimaryEnhancement") = AttackData.Enhancement

                    WeaponsObj.Element("PrimarySize") = Character.Size

                    If AttackData.STRBonus = Rules.Weapons.STRBonus.Full Then
                        WeaponsObj.ElementAsInteger("PrimaryHandSTRMod") = Rules.Weapons.STRBonus.Full
                    ElseIf AttackData.STRBonus = Rules.Weapons.STRBonus.Max Then
                        WeaponsObj.ElementAsInteger("PrimaryHandSTRMod") = Rules.Weapons.STRBonus.Max
                    ElseIf AttackData.STRBonus = Rules.Weapons.STRBonus.Half Then
                        WeaponsObj.ElementAsInteger("PrimaryHandSTRMod") = Rules.Weapons.STRBonus.Half
                    Else
                        WeaponsObj.ElementAsInteger("PrimaryHandSTRMod") = Rules.Weapons.STRBonus.None
                    End If

                Case CreateAttackDialog.AttackType.None
                    WeaponsObj.Element("DisablePrimary") = "Yes"

            End Select

            'off hands
            Dim OffhandCount As Integer

            For Each AttackData In AttackOptions.SecondaryAttackData
                OffhandCount += 1

                Select Case AttackData.Type
                    Case CreateAttackDialog.AttackType.Natural

                        WeaponsObj.FKElement("OffHandItem" + OffhandCount.ToString, AttackData.Weapon.Name, "Name", AttackData.Weapon.ObjectGUID)
                        WeaponsObj.ElementAsInteger("OffHand" + OffhandCount.ToString + "AttackNumber") = AttackData.Number
                        If AttackData.Enhancement > 0 Then WeaponsObj.ElementAsInteger("OffHandEnhancement" + OffhandCount.ToString) = AttackData.Enhancement
                        WeaponsObj.ElementAsInteger("OffHandWield" + OffhandCount.ToString) = Rules.Weapons.Wield.OneHanded
                        WeaponsObj.Element("OffHandSize" + OffhandCount.ToString) = Character.Size

                        If AttackData.STRBonus = Rules.Weapons.STRBonus.Full Then
                            WeaponsObj.ElementAsInteger("OffHandSTRMod" + OffhandCount.ToString) = Rules.Weapons.STRBonus.Full
                        ElseIf AttackData.STRBonus = Rules.Weapons.STRBonus.Max Then
                            WeaponsObj.ElementAsInteger("OffHandSTRMod" + OffhandCount.ToString) = Rules.Weapons.STRBonus.Max
                        ElseIf AttackData.STRBonus = Rules.Weapons.STRBonus.Half Then
                            WeaponsObj.ElementAsInteger("OffHandSTRMod" + OffhandCount.ToString) = Rules.Weapons.STRBonus.Half
                        Else
                            WeaponsObj.ElementAsInteger("OffHandSTRMod" + OffhandCount.ToString) = Rules.Weapons.STRBonus.None
                        End If

                    Case CreateAttackDialog.AttackType.Manufactured

                        WeaponsObj.ElementAsInteger("OffHand" + OffhandCount.ToString + "AttackNumber") = AttackData.Number

                End Select
            Next

            WeaponsObj.ElementAsInteger("OffHandCount") = OffhandCount
            AddWeaponsConfiguration(WeaponsObj, Character)

            _Dirty = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddWeaponsConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddWeaponsConfig.Click
        Try

            'if this is a monster - display the monster dialog
            'Select Case Character.CharacterType
            '    Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.Familiar, Rules.Character.CharacterObjectType.SpecialMount
            '        Dim AttackOptions As New CreateAttackDialog
            '        AttackOptions.Init(Character.RaceObject)
            '        If AttackOptions.ShowDialog() = DialogResult.Cancel Then
            '            Exit Sub
            '        End If

            '        'need to make a weapons obj
            '        Dim AttackData As CreateAttackDialog.AttackData
            '        Dim WeaponsObj As Objects.ObjectData

            '        WeaponsObj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Characters)
            '        WeaponsObj.Name = "Weapon Configuration " & (ConfigsPanel.Controls.Count + 1).ToString
            '        WeaponsObj.Type = Objects.WeaponConfigType
            '        WeaponsObj.ParentGUID = _WeaponConfigFolder
            '        WeaponsObj.ElementAsInteger("Index") = ConfigsPanel.Controls.Count + 1
            '        WeaponsObj.Element("MonsterConfig") = "Yes"

            '        AttackData = AttackOptions.PrimaryAttackData()

            '        'if we have a primary attack - add the slot for it
            '        Select Case AttackData.Type

            '            Case CreateAttackDialog.AttackType.Manufactured

            '            Case CreateAttackDialog.AttackType.Natural

            '                'check if this is a single or multiple attack (for strength bonus)
            '                If AttackData.Number = 1 And AttackOptions.SecondaryAttackData.Count = 0 Then
            '                    WeaponsObj.ElementAsInteger("PrimaryWield") = Rules.Weapons.Wield.TwoHanded
            '                Else
            '                    WeaponsObj.ElementAsInteger("PrimaryWield") = Rules.Weapons.Wield.OneHanded
            '                End If

            '                WeaponsObj.ElementAsInteger("PrimaryAttackNumber") = AttackData.Number
            '                WeaponsObj.FKElement("PrimaryWeapon", AttackData.Weapon.Name, "Name", AttackData.Weapon.ObjectGUID)
            '                If AttackData.Enhancement > 0 Then WeaponsObj.ElementAsInteger("PrimaryEnhancement") = AttackData.Enhancement

            '                WeaponsObj.Element("PrimarySize") = Character.Size

            '            Case CreateAttackDialog.AttackType.None
            '                WeaponsObj.Element("DisablePrimary") = "Yes"

            '        End Select

            '        'off hands
            '        Dim OffhandCount As Integer

            '        For Each AttackData In AttackOptions.SecondaryAttackData
            '            OffhandCount += 1

            '            Select Case AttackData.Type
            '                Case CreateAttackDialog.AttackType.Natural

            '                    WeaponsObj.FKElement("OffHandItem" + OffhandCount.ToString, AttackData.Weapon.Name, "Name", AttackData.Weapon.ObjectGUID)
            '                    WeaponsObj.ElementAsInteger("OffHand" + OffhandCount.ToString + "AttackNumber") = AttackData.Number
            '                    If AttackData.Enhancement > 0 Then WeaponsObj.ElementAsInteger("OffHandEnhancement" + OffhandCount.ToString) = AttackData.Enhancement
            '                    WeaponsObj.ElementAsInteger("OffHandWield" + OffhandCount.ToString) = Rules.Weapons.Wield.OneHanded
            '                    WeaponsObj.Element("OffHandSize" + OffhandCount.ToString) = Character.Size

            '                Case CreateAttackDialog.AttackType.Manufactured

            '                    WeaponsObj.ElementAsInteger("OffHand" + OffhandCount.ToString + "AttackNumber") = AttackData.Number

            '            End Select
            '        Next

            '        WeaponsObj.ElementAsInteger("OffHandCount") = OffhandCount
            '        AddWeaponsConfiguration(WeaponsObj, Character)

            '    Case Else
            '        AddWeaponsConfiguration(Nothing, Character)
            'End Select

            AddWeaponsConfiguration(Nothing, Character)

            _Dirty = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim Temp As Control
        Dim Top, Height As Integer

        Try
            If ConfigsPanel.Controls.Count = 0 Then
                General.ShowInfoDialog("No Weapon Configurations available to delete.")
                Exit Sub
            ElseIf _FocusedWeaponsConfig Is Nothing OrElse ConfigsPanel.Controls.IndexOf(CType(_FocusedWeaponsConfig, Control)) < 0 Then
                General.ShowInfoDialog("Please select a Weapon Configuration to delete.")
                Exit Sub
            End If

            General.MainExplorer.Undo.UndoRecord()

            _FocusedWeaponsConfig.Weapons.Delete()
            WeaponsList.Remove(_FocusedWeaponsConfig)
            _Dirty = True
            Temp = ConfigsPanel.Controls(ConfigsPanel.Controls.IndexOf(CType(_FocusedWeaponsConfig, Control)))
            Top = Temp.Top
            Height = Temp.Height
            ConfigsPanel.Controls.Remove(CType(_FocusedWeaponsConfig, Control))

            'shuffle the existing controls
            If ConfigsPanel.Controls.Count > 0 Then
                For Each WeaponsConfig As IWeaponConfig In ConfigsPanel.Controls
                    If WeaponsConfig.Top > Top Then
                        WeaponsConfig.Top -= Height
                        WeaponsConfig.Weapons.Index -= 1
                    End If
                Next
            End If

            _FocusedWeaponsConfig = Nothing

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MoveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveUp.Click
        Dim Index, Height As Integer

        Try
            If Not _FocusedWeaponsConfig Is Nothing Then
                Index = ConfigsPanel.Controls.IndexOf(CType(_FocusedWeaponsConfig, Control))
                If ConfigsPanel.Controls(Index).Top = 0 Then Exit Sub

                Height = ConfigsPanel.Controls(Index).Height
                ConfigsPanel.Controls(Index).Top -= Height
                CType(ConfigsPanel.Controls(Index), IWeaponConfig).Weapons.Index -= 1
                For Each WeaponsConfig As IWeaponConfig In ConfigsPanel.Controls
                    If Not WeaponsConfig Is ConfigsPanel.Controls(Index) And WeaponsConfig.Top = ConfigsPanel.Controls(Index).Top Then
                        WeaponsConfig.Top += Height
                        WeaponsConfig.Weapons.Index += 1
                    End If
                Next
                _Dirty = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MoveDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveDown.Click
        Dim Index, Height As Integer

        Try
            If Not _FocusedWeaponsConfig Is Nothing Then
                Index = ConfigsPanel.Controls.IndexOf(CType(_FocusedWeaponsConfig, Control))
                Height = ConfigsPanel.Controls(Index).Height
                If ConfigsPanel.Controls(Index).Top = (ConfigsPanel.Controls.Count - 1) * Height Then Exit Sub

                ConfigsPanel.Controls(Index).Top += Height
                CType(ConfigsPanel.Controls(Index), IWeaponConfig).Weapons.Index += 1
                For Each WeaponsConfig As IWeaponConfig In ConfigsPanel.Controls
                    If Not WeaponsConfig Is ConfigsPanel.Controls(Index) And WeaponsConfig.Top = ConfigsPanel.Controls(Index).Top Then
                        WeaponsConfig.Top -= Height
                        WeaponsConfig.Weapons.Index -= 1
                    End If
                Next

                _Dirty = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Try
            If ConfigsPanel.Controls.Count = 0 Then
                General.ShowInfoDialog("No Weapon Configurations available to reset.")
                Exit Sub
            ElseIf _FocusedWeaponsConfig Is Nothing Then
                General.ShowInfoDialog("Please select a Weapon Configuration to reset.")
                Exit Sub
            End If

            _FocusedWeaponsConfig.Weapons.Reset()
            _FocusedWeaponsConfig.Reset()
            _Dirty = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Event Handlers"

    Public Sub HandleFocus(ByVal sender As Object, ByVal e As EventArgs)
        Try
            _FocusedWeaponsConfig = CType(sender, IWeaponConfig)

            For Each WeaponsConfig As IWeaponConfig In WeaponsList
                If Not WeaponsConfig Is sender Then WeaponsConfig.SetFocus(False)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub HandleDirty()
        Try
            _Dirty = True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Paint Events"

    'Private Sub ConfigsPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ConfigsPanel.Paint
    '    Dim gradbrush As New Drawing2D.LinearGradientBrush(ConfigsPanel.ClientRectangle, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)
    '    e.Graphics.FillRectangle(gradbrush, ConfigsPanel.ClientRectangle)
    'End Sub

    'Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
    '    Dim gradbrush As New Drawing2D.LinearGradientBrush(Panel2.ClientRectangle, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)
    '    e.Graphics.FillRectangle(gradbrush, Panel2.ClientRectangle)
    'End Sub

    Private Sub WeaponsPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

#End Region

    Public ReadOnly Property ListView() As System.Windows.Forms.ListView Implements IPanel.ListView
        Get
            Return Nothing
        End Get
    End Property

    Public Sub RefreshPanelData() Implements IPanel.RefreshPanelData
        Dim Character As Rules.Character

        'get a character for use in this panel - and save it as Panel.Character
        Character = CharacterManager.GetCharacterForWeaponPanel(_CharacterKey)
        Me.Character = Character

        'show the default weapons button if required
        If General.Config.Element("DefaultWeapons") = "Yes" Then
            DefaultButton.Visible = True
        Else
            DefaultButton.Visible = False
        End If

        'get the baseline components - these should never change as we always work with a clone of this inside each weapon configuration
        BaseLineComponents = Character.Components

        'bab, melee, ranged, grapple
        BAB.Text = Rules.Formatting.FormatAttacks(Character.GetBaseAttackBonuses)
        Melee.Text = Rules.Formatting.FormatModifier(Character.BABMelee)
        Ranged.Text = Rules.Formatting.FormatModifier(Character.BABRanged)
        Grapple.Text = Rules.Formatting.FormatModifier(Character.BABGrapple)

        SetModifierColour(Melee, Rules.Modifiers.ModifierFlag(Character.Modifiers.AttackRoll, 0))
        SetModifierColour(Ranged, Rules.Modifiers.ModifierFlag(Character.Modifiers.AttackRoll, 0))
        SetModifierColour(Grapple, Rules.Modifiers.ModifierFlag(Character.Modifiers.GrappleRoll, 0))

        'weapon configs
        ConfigsPanel.Controls.Clear()
        LoadWeaponsList(Character)

        'modifiers
        Dim DisplayData As New ModifiersDisplay(Character.Components)
        CombatModifiers.Items.Clear()

        DisplayData.ProcessComponentsByConcept(ModifiersDisplay.DisplayConcept.Combat, True)
        For Each ModifierDisplay As ModifiersDisplay.Modifier In DisplayData.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Combat)
            If ModifierDisplay.Valid Then CombatModifiers.Items.Add(" " & ModifierDisplay.ToString & " - " & ModifierDisplay.Source)
        Next
    End Sub

    Private _ReadOnly As Boolean = False

    'read-only
    Public WriteOnly Property [ReadOnly]() As Boolean Implements IPanel.ReadOnly
        Set(ByVal value As Boolean)
            If value <> _ReadOnly Then
                _ReadOnly = value
                If _ReadOnly Then
                    Me.Panel2.Enabled = False
                    Me.ConfigsPanel.Enabled = False
                Else
                    Me.Panel2.Enabled = True
                    Me.ConfigsPanel.Enabled = True
                End If
            End If
        End Set
    End Property

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

    'set default weapons for monster
    Private Sub DefaultButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultButton.Click
        If General.ShowQuestionDialog("This will set the default weapon configurations for this creature's Race. This will overwrite any previous default weapon configurations. Default weapon configurations are automaticaly added to this panel whenever a new character/companion of this race is created. If any of these weapon configurations contain inventory items then this will also set the races default inventory.") = DialogResult.Yes Then
            'make sure we have created all the objects for this panel
            Save()
            Character.CreateDefaultWeapons(True)
        End If
    End Sub

End Class
