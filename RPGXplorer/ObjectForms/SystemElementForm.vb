Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class SystemElementForm
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
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents AllowModifiersCheck As System.Windows.Forms.CheckBox
    Public WithEvents AllowAbilityModifiersCheck As System.Windows.Forms.CheckBox
    Public WithEvents AllowPositiveAbilityCheck As System.Windows.Forms.CheckBox
    Public WithEvents AllowPercentileCheck As System.Windows.Forms.CheckBox
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents SystemElementTab As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents FocusType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents FocusCheck As System.Windows.Forms.CheckBox
    Public WithEvents DuplicateFocusCheck As System.Windows.Forms.CheckBox
    Public WithEvents AllowDiceCheck As System.Windows.Forms.CheckBox
    Public WithEvents Armor As System.Windows.Forms.CheckBox
    Public WithEvents Weapons As System.Windows.Forms.CheckBox
    Public WithEvents Compatability As System.Windows.Forms.TabPage
    Public WithEvents Shields As System.Windows.Forms.CheckBox
    Public WithEvents Feats As System.Windows.Forms.CheckBox
    Public WithEvents ArmorMagicAbility As System.Windows.Forms.CheckBox
    Public WithEvents MagicArmor As System.Windows.Forms.CheckBox
    Public WithEvents Rings As System.Windows.Forms.CheckBox
    Public WithEvents Rods As System.Windows.Forms.CheckBox
    Public WithEvents Staffs As System.Windows.Forms.CheckBox
    Public WithEvents Features As System.Windows.Forms.CheckBox
    Public WithEvents Artifacts As System.Windows.Forms.CheckBox
    Public WithEvents Wondrous As System.Windows.Forms.CheckBox
    Public WithEvents Synergies As System.Windows.Forms.CheckBox
    Public WithEvents MagicWeapons As System.Windows.Forms.CheckBox
    Public WithEvents WeaponMagicAbility As System.Windows.Forms.CheckBox
    Public WithEvents ShieldMagicAbility As System.Windows.Forms.CheckBox
    Public WithEvents MagicShields As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents MagicAmmo As System.Windows.Forms.CheckBox
    Public WithEvents AllowSetCheck As System.Windows.Forms.CheckBox
    Public WithEvents AllowComplexCheck As System.Windows.Forms.CheckBox
    Public WithEvents Items As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FocusType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.SystemElementTab = New System.Windows.Forms.TabPage
        Me.AllowComplexCheck = New System.Windows.Forms.CheckBox
        Me.AllowSetCheck = New System.Windows.Forms.CheckBox
        Me.AllowDiceCheck = New System.Windows.Forms.CheckBox
        Me.DuplicateFocusCheck = New System.Windows.Forms.CheckBox
        Me.FocusCheck = New System.Windows.Forms.CheckBox
        Me.AllowPercentileCheck = New System.Windows.Forms.CheckBox
        Me.AllowPositiveAbilityCheck = New System.Windows.Forms.CheckBox
        Me.AllowAbilityModifiersCheck = New System.Windows.Forms.CheckBox
        Me.AllowModifiersCheck = New System.Windows.Forms.CheckBox
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Compatability = New System.Windows.Forms.TabPage
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.MagicShields = New System.Windows.Forms.CheckBox
        Me.ShieldMagicAbility = New System.Windows.Forms.CheckBox
        Me.Features = New System.Windows.Forms.CheckBox
        Me.Feats = New System.Windows.Forms.CheckBox
        Me.Shields = New System.Windows.Forms.CheckBox
        Me.Armor = New System.Windows.Forms.CheckBox
        Me.Weapons = New System.Windows.Forms.CheckBox
        Me.ArmorMagicAbility = New System.Windows.Forms.CheckBox
        Me.MagicArmor = New System.Windows.Forms.CheckBox
        Me.MagicWeapons = New System.Windows.Forms.CheckBox
        Me.Rings = New System.Windows.Forms.CheckBox
        Me.Rods = New System.Windows.Forms.CheckBox
        Me.Staffs = New System.Windows.Forms.CheckBox
        Me.Artifacts = New System.Windows.Forms.CheckBox
        Me.Wondrous = New System.Windows.Forms.CheckBox
        Me.Synergies = New System.Windows.Forms.CheckBox
        Me.WeaponMagicAbility = New System.Windows.Forms.CheckBox
        Me.MagicAmmo = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.Items = New System.Windows.Forms.CheckBox
        CType(Me.FocusType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SystemElementTab.SuspendLayout()
        Me.Compatability.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FocusType
        '
        Me.FocusType.Enabled = False
        Me.FocusType.Location = New System.Drawing.Point(160, 295)
        Me.FocusType.Name = "FocusType"
        '
        'FocusType.Properties
        '
        Me.FocusType.Properties.AutoHeight = False
        Me.FocusType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FocusType.Properties.DropDownRows = 10
        Me.FocusType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FocusType.Size = New System.Drawing.Size(200, 21)
        Me.FocusType.TabIndex = 8
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(100, 15)
        Me.ObjectName.Name = "ObjectName"
        '
        'ObjectName.Properties
        '
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(200, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(278, 425)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.SystemElementTab)
        Me.TabControl1.Controls.Add(Me.Compatability)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(14, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 395)
        Me.TabControl1.TabIndex = 1
        '
        'SystemElementTab
        '
        Me.SystemElementTab.Controls.Add(Me.AllowComplexCheck)
        Me.SystemElementTab.Controls.Add(Me.AllowSetCheck)
        Me.SystemElementTab.Controls.Add(Me.AllowDiceCheck)
        Me.SystemElementTab.Controls.Add(Me.DuplicateFocusCheck)
        Me.SystemElementTab.Controls.Add(Me.FocusCheck)
        Me.SystemElementTab.Controls.Add(Me.AllowPercentileCheck)
        Me.SystemElementTab.Controls.Add(Me.AllowPositiveAbilityCheck)
        Me.SystemElementTab.Controls.Add(Me.AllowAbilityModifiersCheck)
        Me.SystemElementTab.Controls.Add(Me.AllowModifiersCheck)
        Me.SystemElementTab.Controls.Add(Me.IndentedLine2)
        Me.SystemElementTab.Controls.Add(Me.IndentedLine1)
        Me.SystemElementTab.Controls.Add(Me.Label3)
        Me.SystemElementTab.Controls.Add(Me.ObjectName)
        Me.SystemElementTab.Controls.Add(Me.FocusType)
        Me.SystemElementTab.Location = New System.Drawing.Point(4, 22)
        Me.SystemElementTab.Name = "SystemElementTab"
        Me.SystemElementTab.Size = New System.Drawing.Size(407, 369)
        Me.SystemElementTab.TabIndex = 2
        Me.SystemElementTab.Text = "System Element"
        '
        'AllowComplexCheck
        '
        Me.AllowComplexCheck.CausesValidation = False
        Me.AllowComplexCheck.Location = New System.Drawing.Point(15, 245)
        Me.AllowComplexCheck.Name = "AllowComplexCheck"
        Me.AllowComplexCheck.Size = New System.Drawing.Size(150, 21)
        Me.AllowComplexCheck.TabIndex = 137
        Me.AllowComplexCheck.Text = " Allow complex modifiers"
        '
        'AllowSetCheck
        '
        Me.AllowSetCheck.CausesValidation = False
        Me.AllowSetCheck.Location = New System.Drawing.Point(15, 65)
        Me.AllowSetCheck.Name = "AllowSetCheck"
        Me.AllowSetCheck.Size = New System.Drawing.Size(130, 21)
        Me.AllowSetCheck.TabIndex = 136
        Me.AllowSetCheck.Text = " Allow value to be set"
        '
        'AllowDiceCheck
        '
        Me.AllowDiceCheck.CausesValidation = False
        Me.AllowDiceCheck.Location = New System.Drawing.Point(15, 215)
        Me.AllowDiceCheck.Name = "AllowDiceCheck"
        Me.AllowDiceCheck.Size = New System.Drawing.Size(160, 21)
        Me.AllowDiceCheck.TabIndex = 5
        Me.AllowDiceCheck.Text = " Allow dice range modifier"
        '
        'DuplicateFocusCheck
        '
        Me.DuplicateFocusCheck.CausesValidation = False
        Me.DuplicateFocusCheck.Enabled = False
        Me.DuplicateFocusCheck.Location = New System.Drawing.Point(15, 325)
        Me.DuplicateFocusCheck.Name = "DuplicateFocusCheck"
        Me.DuplicateFocusCheck.Size = New System.Drawing.Size(250, 21)
        Me.DuplicateFocusCheck.TabIndex = 9
        Me.DuplicateFocusCheck.Text = "Can select same focus more than once"
        '
        'FocusCheck
        '
        Me.FocusCheck.CausesValidation = False
        Me.FocusCheck.Location = New System.Drawing.Point(15, 295)
        Me.FocusCheck.Name = "FocusCheck"
        Me.FocusCheck.Size = New System.Drawing.Size(145, 21)
        Me.FocusCheck.TabIndex = 7
        Me.FocusCheck.Text = "Focus component type"
        '
        'AllowPercentileCheck
        '
        Me.AllowPercentileCheck.CausesValidation = False
        Me.AllowPercentileCheck.Location = New System.Drawing.Point(15, 185)
        Me.AllowPercentileCheck.Name = "AllowPercentileCheck"
        Me.AllowPercentileCheck.Size = New System.Drawing.Size(160, 21)
        Me.AllowPercentileCheck.TabIndex = 4
        Me.AllowPercentileCheck.Text = " Allow percentile modifiers"
        '
        'AllowPositiveAbilityCheck
        '
        Me.AllowPositiveAbilityCheck.CausesValidation = False
        Me.AllowPositiveAbilityCheck.Location = New System.Drawing.Point(15, 155)
        Me.AllowPositiveAbilityCheck.Name = "AllowPositiveAbilityCheck"
        Me.AllowPositiveAbilityCheck.Size = New System.Drawing.Size(240, 21)
        Me.AllowPositiveAbilityCheck.TabIndex = 3
        Me.AllowPositiveAbilityCheck.Text = " Allow ability score to modify (positive only)"
        '
        'AllowAbilityModifiersCheck
        '
        Me.AllowAbilityModifiersCheck.CausesValidation = False
        Me.AllowAbilityModifiersCheck.Location = New System.Drawing.Point(15, 125)
        Me.AllowAbilityModifiersCheck.Name = "AllowAbilityModifiersCheck"
        Me.AllowAbilityModifiersCheck.Size = New System.Drawing.Size(170, 21)
        Me.AllowAbilityModifiersCheck.TabIndex = 2
        Me.AllowAbilityModifiersCheck.Text = " Allow ability score to modify"
        '
        'AllowModifiersCheck
        '
        Me.AllowModifiersCheck.CausesValidation = False
        Me.AllowModifiersCheck.Location = New System.Drawing.Point(15, 95)
        Me.AllowModifiersCheck.Name = "AllowModifiersCheck"
        Me.AllowModifiersCheck.Size = New System.Drawing.Size(105, 21)
        Me.AllowModifiersCheck.TabIndex = 1
        Me.AllowModifiersCheck.Text = " Allow modifiers"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.CausesValidation = False
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 280)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 135
        Me.IndentedLine2.TabStop = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 129
        Me.IndentedLine1.TabStop = False
        '
        'Compatability
        '
        Me.Compatability.Controls.Add(Me.Items)
        Me.Compatability.Controls.Add(Me.IndentedLine3)
        Me.Compatability.Controls.Add(Me.MagicShields)
        Me.Compatability.Controls.Add(Me.ShieldMagicAbility)
        Me.Compatability.Controls.Add(Me.Features)
        Me.Compatability.Controls.Add(Me.Feats)
        Me.Compatability.Controls.Add(Me.Shields)
        Me.Compatability.Controls.Add(Me.Armor)
        Me.Compatability.Controls.Add(Me.Weapons)
        Me.Compatability.Controls.Add(Me.ArmorMagicAbility)
        Me.Compatability.Controls.Add(Me.MagicArmor)
        Me.Compatability.Controls.Add(Me.MagicWeapons)
        Me.Compatability.Controls.Add(Me.Rings)
        Me.Compatability.Controls.Add(Me.Rods)
        Me.Compatability.Controls.Add(Me.Staffs)
        Me.Compatability.Controls.Add(Me.Artifacts)
        Me.Compatability.Controls.Add(Me.Wondrous)
        Me.Compatability.Controls.Add(Me.Synergies)
        Me.Compatability.Controls.Add(Me.WeaponMagicAbility)
        Me.Compatability.Controls.Add(Me.MagicAmmo)
        Me.Compatability.Location = New System.Drawing.Point(4, 22)
        Me.Compatability.Name = "Compatability"
        Me.Compatability.Size = New System.Drawing.Size(407, 369)
        Me.Compatability.TabIndex = 4
        Me.Compatability.Text = "Modifier Compatability"
        '
        'IndentedLine3
        '
        Me.IndentedLine3.CausesValidation = False
        Me.IndentedLine3.Location = New System.Drawing.Point(16, 110)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 130
        Me.IndentedLine3.TabStop = False
        '
        'MagicShields
        '
        Me.MagicShields.CausesValidation = False
        Me.MagicShields.Enabled = False
        Me.MagicShields.Location = New System.Drawing.Point(15, 275)
        Me.MagicShields.Name = "MagicShields"
        Me.MagicShields.Size = New System.Drawing.Size(95, 21)
        Me.MagicShields.TabIndex = 12
        Me.MagicShields.Text = "Magic Shields"
        '
        'ShieldMagicAbility
        '
        Me.ShieldMagicAbility.CausesValidation = False
        Me.ShieldMagicAbility.Enabled = False
        Me.ShieldMagicAbility.Location = New System.Drawing.Point(15, 155)
        Me.ShieldMagicAbility.Name = "ShieldMagicAbility"
        Me.ShieldMagicAbility.Size = New System.Drawing.Size(125, 21)
        Me.ShieldMagicAbility.TabIndex = 8
        Me.ShieldMagicAbility.Text = "Shield Magic Ability"
        '
        'Features
        '
        Me.Features.CausesValidation = False
        Me.Features.Enabled = False
        Me.Features.Location = New System.Drawing.Point(100, 15)
        Me.Features.Name = "Features"
        Me.Features.Size = New System.Drawing.Size(155, 21)
        Me.Features.TabIndex = 3
        Me.Features.Text = "Features, Classes, Races"
        '
        'Feats
        '
        Me.Feats.CausesValidation = False
        Me.Feats.Enabled = False
        Me.Feats.Location = New System.Drawing.Point(15, 75)
        Me.Feats.Name = "Feats"
        Me.Feats.Size = New System.Drawing.Size(60, 21)
        Me.Feats.TabIndex = 2
        Me.Feats.Text = "Feats"
        '
        'Shields
        '
        Me.Shields.CausesValidation = False
        Me.Shields.Enabled = False
        Me.Shields.Location = New System.Drawing.Point(15, 45)
        Me.Shields.Name = "Shields"
        Me.Shields.Size = New System.Drawing.Size(60, 21)
        Me.Shields.TabIndex = 1
        Me.Shields.Text = "Shields"
        '
        'Armor
        '
        Me.Armor.CausesValidation = False
        Me.Armor.Enabled = False
        Me.Armor.Location = New System.Drawing.Point(15, 15)
        Me.Armor.Name = "Armor"
        Me.Armor.Size = New System.Drawing.Size(60, 21)
        Me.Armor.TabIndex = 0
        Me.Armor.Text = "Armor"
        '
        'Weapons
        '
        Me.Weapons.CausesValidation = False
        Me.Weapons.Enabled = False
        Me.Weapons.Location = New System.Drawing.Point(100, 75)
        Me.Weapons.Name = "Weapons"
        Me.Weapons.Size = New System.Drawing.Size(75, 21)
        Me.Weapons.TabIndex = 5
        Me.Weapons.Text = "Weapons"
        '
        'ArmorMagicAbility
        '
        Me.ArmorMagicAbility.CausesValidation = False
        Me.ArmorMagicAbility.Enabled = False
        Me.ArmorMagicAbility.Location = New System.Drawing.Point(15, 125)
        Me.ArmorMagicAbility.Name = "ArmorMagicAbility"
        Me.ArmorMagicAbility.Size = New System.Drawing.Size(125, 21)
        Me.ArmorMagicAbility.TabIndex = 7
        Me.ArmorMagicAbility.Text = "Armor Magic Ability"
        '
        'MagicArmor
        '
        Me.MagicArmor.CausesValidation = False
        Me.MagicArmor.Enabled = False
        Me.MagicArmor.Location = New System.Drawing.Point(15, 245)
        Me.MagicArmor.Name = "MagicArmor"
        Me.MagicArmor.Size = New System.Drawing.Size(90, 21)
        Me.MagicArmor.TabIndex = 11
        Me.MagicArmor.Text = "Magic Armor"
        '
        'MagicWeapons
        '
        Me.MagicWeapons.CausesValidation = False
        Me.MagicWeapons.Enabled = False
        Me.MagicWeapons.Location = New System.Drawing.Point(15, 305)
        Me.MagicWeapons.Name = "MagicWeapons"
        Me.MagicWeapons.Size = New System.Drawing.Size(105, 21)
        Me.MagicWeapons.TabIndex = 13
        Me.MagicWeapons.Text = "Magic Weapons"
        '
        'Rings
        '
        Me.Rings.CausesValidation = False
        Me.Rings.Enabled = False
        Me.Rings.Location = New System.Drawing.Point(160, 125)
        Me.Rings.Name = "Rings"
        Me.Rings.Size = New System.Drawing.Size(55, 21)
        Me.Rings.TabIndex = 14
        Me.Rings.Text = "Rings"
        '
        'Rods
        '
        Me.Rods.CausesValidation = False
        Me.Rods.Enabled = False
        Me.Rods.Location = New System.Drawing.Point(160, 155)
        Me.Rods.Name = "Rods"
        Me.Rods.Size = New System.Drawing.Size(55, 21)
        Me.Rods.TabIndex = 15
        Me.Rods.Text = "Rods"
        '
        'Staffs
        '
        Me.Staffs.CausesValidation = False
        Me.Staffs.Enabled = False
        Me.Staffs.Location = New System.Drawing.Point(160, 185)
        Me.Staffs.Name = "Staffs"
        Me.Staffs.Size = New System.Drawing.Size(55, 21)
        Me.Staffs.TabIndex = 16
        Me.Staffs.Text = "Staffs"
        '
        'Artifacts
        '
        Me.Artifacts.CausesValidation = False
        Me.Artifacts.Enabled = False
        Me.Artifacts.Location = New System.Drawing.Point(15, 185)
        Me.Artifacts.Name = "Artifacts"
        Me.Artifacts.Size = New System.Drawing.Size(65, 21)
        Me.Artifacts.TabIndex = 9
        Me.Artifacts.Text = "Artifacts"
        '
        'Wondrous
        '
        Me.Wondrous.CausesValidation = False
        Me.Wondrous.Enabled = False
        Me.Wondrous.Location = New System.Drawing.Point(160, 245)
        Me.Wondrous.Name = "Wondrous"
        Me.Wondrous.Size = New System.Drawing.Size(105, 21)
        Me.Wondrous.TabIndex = 18
        Me.Wondrous.Text = "Wondrous Items"
        '
        'Synergies
        '
        Me.Synergies.CausesValidation = False
        Me.Synergies.Enabled = False
        Me.Synergies.Location = New System.Drawing.Point(100, 45)
        Me.Synergies.Name = "Synergies"
        Me.Synergies.Size = New System.Drawing.Size(100, 21)
        Me.Synergies.TabIndex = 4
        Me.Synergies.Text = "Skill Synergies"
        '
        'WeaponMagicAbility
        '
        Me.WeaponMagicAbility.CausesValidation = False
        Me.WeaponMagicAbility.Enabled = False
        Me.WeaponMagicAbility.Location = New System.Drawing.Point(160, 215)
        Me.WeaponMagicAbility.Name = "WeaponMagicAbility"
        Me.WeaponMagicAbility.Size = New System.Drawing.Size(135, 21)
        Me.WeaponMagicAbility.TabIndex = 17
        Me.WeaponMagicAbility.Text = "Weapon Magic Ability"
        '
        'MagicAmmo
        '
        Me.MagicAmmo.CausesValidation = False
        Me.MagicAmmo.Enabled = False
        Me.MagicAmmo.Location = New System.Drawing.Point(15, 215)
        Me.MagicAmmo.Name = "MagicAmmo"
        Me.MagicAmmo.Size = New System.Drawing.Size(90, 21)
        Me.MagicAmmo.TabIndex = 10
        Me.MagicAmmo.Text = "Magic Ammo"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 369)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(358, 425)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'Items
        '
        Me.Items.CausesValidation = False
        Me.Items.Enabled = False
        Me.Items.Location = New System.Drawing.Point(235, 75)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(75, 21)
        Me.Items.TabIndex = 6
        Me.Items.Text = "Items"
        '
        'SystemElementForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 463)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SystemElementForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemElement"
        CType(Me.FocusType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.SystemElementTab.ResumeLayout(False)
        Me.Compatability.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'init
    Public Sub Init()
        Try
            'initialise controls
            FocusType.Properties.Items.AddRange(Objects.ObjectTypes.List)
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    ''initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init new object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.SystemComponents)
            mObject.Type = Objects.SystemElementType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add System Element"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit System Element"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = mObject.Name
            If mObject.Element("AllowSet") = "Yes" Then AllowSetCheck.CheckState = CheckState.Checked Else AllowSetCheck.CheckState = CheckState.Unchecked
            If mObject.Element("AllowModifiers") = "Yes" Then AllowModifiersCheck.CheckState = CheckState.Checked Else AllowModifiersCheck.CheckState = CheckState.Unchecked
            If mObject.Element("AllowAbilityModifiers") = "Yes" Then AllowAbilityModifiersCheck.CheckState = CheckState.Checked Else AllowAbilityModifiersCheck.CheckState = CheckState.Unchecked
            If mObject.Element("AllowPositiveAbilityModifier") = "Yes" Then AllowPositiveAbilityCheck.CheckState = CheckState.Checked Else AllowPositiveAbilityCheck.CheckState = CheckState.Unchecked
            If mObject.Element("AllowPercentileModifier") = "Yes" Then AllowPercentileCheck.CheckState = CheckState.Checked Else AllowPercentileCheck.CheckState = CheckState.Unchecked
            If mObject.Element("AllowDiceRange") = "Yes" Then AllowDiceCheck.CheckState = CheckState.Checked Else AllowDiceCheck.CheckState = CheckState.Unchecked
            If mObject.Element("AllowComplex") = "Yes" Then AllowComplexCheck.CheckState = CheckState.Checked Else AllowComplexCheck.CheckState = CheckState.Unchecked
            If mObject.Element("Armor") = "Yes" Then Armor.Checked = True
            If mObject.Element("Shields") = "Yes" Then Shields.Checked = True
            If mObject.Element("Feats") = "Yes" Then Feats.Checked = True
            If mObject.Element("Features") = "Yes" Then Features.Checked = True
            If mObject.Element("Synergies") = "Yes" Then Synergies.Checked = True
            If mObject.Element("Weapons") = "Yes" Then Weapons.Checked = True
            If mObject.Element("Items") = "Yes" Then Items.Checked = True
            If mObject.Element("ArmorMagicAbility") = "Yes" Then ArmorMagicAbility.Checked = True
            If mObject.Element("Artifacts") = "Yes" Then Artifacts.Checked = True
            If mObject.Element("MagicAmmo") = "Yes" Then MagicAmmo.Checked = True
            If mObject.Element("MagicArmor") = "Yes" Then MagicArmor.Checked = True
            If mObject.Element("MagicShields") = "Yes" Then MagicShields.Checked = True
            If mObject.Element("MagicWeapons") = "Yes" Then MagicWeapons.Checked = True
            If mObject.Element("Rings") = "Yes" Then Rings.Checked = True
            If mObject.Element("Rods") = "Yes" Then Rods.Checked = True
            If mObject.Element("ShieldMagicAbility") = "Yes" Then ShieldMagicAbility.Checked = True
            If mObject.Element("Staffs") = "Yes" Then Staffs.Checked = True
            If mObject.Element("WeaponMagicAbility") = "Yes" Then WeaponMagicAbility.Checked = True
            If mObject.Element("Wondrous") = "Yes" Then Wondrous.Checked = True

            If mObject.Element("HasFocus") = "Yes" Then
                FocusCheck.Checked = True
                FocusType.Text = mObject.Element("FocusType")
                If mObject.Element("DuplicateFocusAllowed") = "Yes" Then DuplicateFocusCheck.Checked = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                If AllowSetCheck.CheckState = CheckState.Checked Then mObject.Element("AllowSet") = "Yes" Else mObject.Element("AllowSet") = "No"
                If AllowModifiersCheck.CheckState = CheckState.Checked Then mObject.Element("AllowModifiers") = "Yes" Else mObject.Element("AllowModifiers") = "No"
                If AllowAbilityModifiersCheck.CheckState = CheckState.Checked Then mObject.Element("AllowAbilityModifiers") = "Yes" Else mObject.Element("AllowAbilityModifiers") = "No"
                If AllowPositiveAbilityCheck.CheckState = CheckState.Checked Then mObject.Element("AllowPositiveAbilityModifier") = "Yes" Else mObject.Element("AllowPositiveAbilityModifier") = "No"
                If AllowPercentileCheck.CheckState = CheckState.Checked Then mObject.Element("AllowPercentileModifier") = "Yes" Else mObject.Element("AllowPercentileModifier") = "No"
                If AllowDiceCheck.CheckState = CheckState.Checked Then mObject.Element("AllowDiceRange") = "Yes" Else mObject.Element("AllowDiceRange") = "No"
                If AllowComplexCheck.CheckState = CheckState.Checked Then mObject.Element("AllowComplex") = "Yes" Else mObject.Element("AllowComplex") = "No"

                If Armor.Checked Then mObject.Element("Armor") = "Yes" Else mObject.Element("Armor") = ""
                If Shields.Checked Then mObject.Element("Shields") = "Yes" Else mObject.Element("Shields") = ""
                If Feats.Checked Then mObject.Element("Feats") = "Yes" Else mObject.Element("Feats") = ""
                If Features.Checked Then mObject.Element("Features") = "Yes" Else mObject.Element("Features") = ""
                If Synergies.Checked Then mObject.Element("Synergies") = "Yes" Else mObject.Element("Synergies") = ""
                If Weapons.Checked Then mObject.Element("Weapons") = "Yes" Else mObject.Element("Weapons") = ""
                If Items.Checked Then mObject.Element("Items") = "Yes" Else mObject.Element("Items") = ""
                If ArmorMagicAbility.Checked Then mObject.Element("ArmorMagicAbility") = "Yes" Else mObject.Element("ArmorMagicAbility") = ""
                If Artifacts.Checked Then mObject.Element("Artifacts") = "Yes" Else mObject.Element("Artifacts") = ""
                If MagicAmmo.Checked Then mObject.Element("MagicAmmo") = "Yes" Else mObject.Element("MagicAmmo") = ""
                If MagicArmor.Checked Then mObject.Element("MagicArmor") = "Yes" Else mObject.Element("MagicArmor") = ""
                If MagicShields.Checked Then mObject.Element("MagicShields") = "Yes" Else mObject.Element("MagicShields") = ""
                If MagicWeapons.Checked Then mObject.Element("MagicWeapons") = "Yes" Else mObject.Element("MagicWeapons") = ""
                If Rings.Checked Then mObject.Element("Rings") = "Yes" Else mObject.Element("Rings") = ""
                If Rods.Checked Then mObject.Element("Rods") = "Yes" Else mObject.Element("Rods") = ""
                If Staffs.Checked Then mObject.Element("Staffs") = "Yes" Else mObject.Element("Staffs") = ""
                If ShieldMagicAbility.Checked Then mObject.Element("ShieldMagicAbility") = "Yes" Else mObject.Element("ShieldMagicAbility") = ""
                If WeaponMagicAbility.Checked Then mObject.Element("WeaponMagicAbility") = "Yes" Else mObject.Element("WeaponMagicAbility") = ""
                If Wondrous.Checked Then mObject.Element("Wondrous") = "Yes" Else mObject.Element("Wondrous") = ""

                If FocusCheck.Checked Then mObject.Element("HasFocus") = "Yes" Else mObject.Element("HasFocus") = "No"
                mObject.Element("FocusType") = FocusType.Text
                If DuplicateFocusCheck.Checked Then mObject.Element("DuplicateFocusAllowed") = "Yes" Else mObject.Element("DuplicateFocusAllowed") = "No"
                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)
                Me.DialogResult = DialogResult.OK : Me.Close()

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
    End Sub

    'show
    Public Shadows Sub Show()
        Try
            MyBase.Show()
            If Commands.EditForm Is Nothing Then
                Commands.EditForm = Me
            Else
                OK.Enabled = False : Me.Text = Me.Text.Replace("Edit", "View") : Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_green.ico")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If Commands.EditForm Is Me Then
                Commands.EditForm = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.SystemElementTab.Controls, Errors)

            If Not (AllowModifiersCheck.Checked Or AllowAbilityModifiersCheck.Checked Or AllowPositiveAbilityCheck.Checked Or AllowPercentileCheck.Checked Or AllowDiceCheck.Checked) Then
                Errors.SetError(AllowModifiersCheck, General.ValidationAtLeast1Required)
                Errors.SetError(AllowAbilityModifiersCheck, General.ValidationAtLeast1Required)
                Errors.SetError(AllowPositiveAbilityCheck, General.ValidationAtLeast1Required)
                Errors.SetError(AllowPercentileCheck, General.ValidationAtLeast1Required)
                Errors.SetError(AllowDiceCheck, General.ValidationAtLeast1Required)
                Validate = False
            Else
                Errors.SetError(AllowModifiersCheck, "")
                Errors.SetError(AllowAbilityModifiersCheck, "")
                Errors.SetError(AllowPositiveAbilityCheck, "")
                Errors.SetError(AllowPercentileCheck, "")
                Errors.SetError(AllowDiceCheck, "")
            End If

            If Armor.Enabled Then
                If Not (Armor.Checked Or Shields.Checked Or Feats.Checked Or Features.Checked Or Weapons.Checked Or Items.Checked Or Synergies.Checked Or ArmorMagicAbility.Checked Or ShieldMagicAbility.Checked Or Artifacts.Checked Or MagicArmor.Checked Or MagicShields.Checked Or MagicWeapons.Checked Or Rings.Checked Or Rods.Checked Or Staffs.Checked Or WeaponMagicAbility.Checked Or Wondrous.Checked) Then
                    SetError()
                    Validate = False
                Else
                    ClearError()
                End If
            Else
                ClearError()
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Private Sub SetError()
        Errors.SetError(Armor, General.ValidationAtLeast1Required)
        Errors.SetError(Shields, General.ValidationAtLeast1Required)
        Errors.SetError(Feats, General.ValidationAtLeast1Required)
        Errors.SetError(Features, General.ValidationAtLeast1Required)
        Errors.SetError(Synergies, General.ValidationAtLeast1Required)
        Errors.SetError(Weapons, General.ValidationAtLeast1Required)
        Errors.SetError(Items, General.ValidationAtLeast1Required)
        Errors.SetError(ArmorMagicAbility, General.ValidationAtLeast1Required)
        Errors.SetError(Artifacts, General.ValidationAtLeast1Required)
        Errors.SetError(MagicArmor, General.ValidationAtLeast1Required)
        Errors.SetError(MagicShields, General.ValidationAtLeast1Required)
        Errors.SetError(MagicWeapons, General.ValidationAtLeast1Required)
        Errors.SetError(Rings, General.ValidationAtLeast1Required)
        Errors.SetError(Rods, General.ValidationAtLeast1Required)
        Errors.SetError(Staffs, General.ValidationAtLeast1Required)
        Errors.SetError(ShieldMagicAbility, General.ValidationAtLeast1Required)
        Errors.SetError(WeaponMagicAbility, General.ValidationAtLeast1Required)
        Errors.SetError(Wondrous, General.ValidationAtLeast1Required)
    End Sub

    Private Sub ClearError()
        Errors.SetError(Armor, "")
        Errors.SetError(Shields, "")
        Errors.SetError(Feats, "")
        Errors.SetError(Features, "")
        Errors.SetError(Synergies, "")
        Errors.SetError(Weapons, "")
        Errors.SetError(Items, "")
        Errors.SetError(ArmorMagicAbility, "")
        Errors.SetError(ShieldMagicAbility, "")
        Errors.SetError(Artifacts, "")
        Errors.SetError(MagicArmor, "")
        Errors.SetError(MagicShields, "")
        Errors.SetError(MagicWeapons, "")
        Errors.SetError(Rings, "")
        Errors.SetError(Rods, "")
        Errors.SetError(Staffs, "")
        Errors.SetError(WeaponMagicAbility, "")
        Errors.SetError(Wondrous, "")
    End Sub
#End Region

#Region "Control Enabling and Disabling"

    Private Sub FocusCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FocusCheck.CheckedChanged
        Try
            If FocusCheck.Checked Then
                FocusType.Properties.Enabled = True
                DuplicateFocusCheck.Enabled = True
            Else
                FocusType.Properties.Enabled = False
                FocusType.SelectedIndex = -1
                DuplicateFocusCheck.Enabled = False
                DuplicateFocusCheck.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Modifiers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllowModifiersCheck.CheckedChanged, AllowDiceCheck.CheckedChanged, AllowAbilityModifiersCheck.CheckedChanged, AllowPercentileCheck.CheckedChanged, AllowPositiveAbilityCheck.CheckedChanged
        Try
            If Me.AllowAbilityModifiersCheck.Checked Or Me.AllowDiceCheck.Checked Or Me.AllowModifiersCheck.Checked Or Me.AllowPercentileCheck.Checked Or Me.AllowPositiveAbilityCheck.Checked Then
                Armor.Enabled = True
                Shields.Enabled = True
                Feats.Enabled = True
                Features.Enabled = True
                Synergies.Enabled = True
                Weapons.Enabled = True
                Items.Enabled = True
                ArmorMagicAbility.Enabled = True
                ShieldMagicAbility.Enabled = True
                Artifacts.Enabled = True
                MagicAmmo.Enabled = True
                MagicArmor.Enabled = True
                MagicShields.Enabled = True
                MagicWeapons.Enabled = True
                Rings.Enabled = True
                Rods.Enabled = True
                Staffs.Enabled = True
                WeaponMagicAbility.Enabled = True
                Wondrous.Enabled = True
            Else
                Armor.Enabled = False
                Shields.Enabled = False
                Feats.Enabled = False
                Features.Enabled = False
                Synergies.Enabled = False
                Weapons.Enabled = False
                Items.Enabled = False
                ArmorMagicAbility.Enabled = False
                Artifacts.Enabled = False
                MagicAmmo.Enabled = False
                MagicArmor.Enabled = False
                MagicShields.Enabled = False
                MagicWeapons.Enabled = False
                Rings.Enabled = False
                Rods.Enabled = False
                Staffs.Enabled = False
                ShieldMagicAbility.Enabled = False
                WeaponMagicAbility.Enabled = False
                Wondrous.Enabled = False
                Armor.Checked = False
                Shields.Checked = False
                Feats.Checked = False
                Features.Checked = False
                Synergies.Checked = False
                Weapons.Checked = False
                Items.Checked = False
                ArmorMagicAbility.Checked = False
                Artifacts.Checked = False
                MagicAmmo.Checked = False
                MagicArmor.Checked = False
                MagicShields.Checked = False
                MagicWeapons.Checked = False
                Rings.Checked = False
                Rods.Checked = False
                Staffs.Checked = False
                ShieldMagicAbility.Checked = False
                WeaponMagicAbility.Checked = False
                Wondrous.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
