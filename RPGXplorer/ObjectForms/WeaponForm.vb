Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports System.xml
Imports RPGXplorer.Rules.Dice

Public Class WeaponForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents TrainingDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents JunctionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageDropdown2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DamageDropdown1 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Multiplier As DevExpress.XtraEditors.SpinEdit
    Public WithEvents ThreatRange As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents MDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents CostLabel As System.Windows.Forms.Label
    Public WithEvents WeightLabel As System.Windows.Forms.Label
    Public WithEvents NameLabel As System.Windows.Forms.Label
    Public WithEvents SDamageLabel As System.Windows.Forms.Label
    Public WithEvents MDamageLabel As System.Windows.Forms.Label
    Public WithEvents TripCheck As System.Windows.Forms.CheckBox
    Public WithEvents ChargeCheck As System.Windows.Forms.CheckBox
    Public WithEvents TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents ApplyPenaltyCheck As System.Windows.Forms.CheckBox
    Public WithEvents ApplyBonusCheck As System.Windows.Forms.CheckBox
    Public WithEvents ThrownCheck As System.Windows.Forms.CheckBox
    Public WithEvents DoubleCheck As System.Windows.Forms.CheckBox
    Public WithEvents ReachCheck As System.Windows.Forms.CheckBox
    Public WithEvents StrengthBonus As DevExpress.XtraEditors.SpinEdit
    Public WithEvents EncumLabel As System.Windows.Forms.Label
    Public WithEvents EncumDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents RangeLabel As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents FinesseCheck As System.Windows.Forms.CheckBox
    Public WithEvents MonkCheck As System.Windows.Forms.CheckBox
    Public WithEvents WeaponTab As System.Windows.Forms.TabPage
    Public WithEvents DetailsTab As System.Windows.Forms.TabPage
    Public WithEvents DamageTab As System.Windows.Forms.TabPage
    Public WithEvents AdvancedTab As System.Windows.Forms.TabPage
    Public WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Public WithEvents Weight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents RangeSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Cost As RPGXplorer.MoneySpin
    Public WithEvents ShadowsCheck As System.Windows.Forms.CheckBox
    Public WithEvents ShadowsDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DSDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DMDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DSDamageLabel As System.Windows.Forms.Label
    Public WithEvents DivideLabel As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents DMultiplier As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents DDamageDropdown2 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents DDamageDropdown1 As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents DJunctionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Masterwork As System.Windows.Forms.CheckBox
    Public WithEvents BaseItem As System.Windows.Forms.CheckBox
    Public WithEvents MartialOneHanded As System.Windows.Forms.CheckBox
    Public WithEvents RangedRadio As System.Windows.Forms.RadioButton
    Public WithEvents MeleeRadio As System.Windows.Forms.RadioButton
    Public WithEvents ReachOnly As System.Windows.Forms.CheckBox
    Public WithEvents Reach As DevExpress.XtraEditors.SpinEdit
    Public WithEvents NonLethalRadio As System.Windows.Forms.RadioButton
    Public WithEvents LethalRadio As System.Windows.Forms.RadioButton
    Public WithEvents NoDamageRadio As System.Windows.Forms.RadioButton
    Public WithEvents StrengthRating As System.Windows.Forms.CheckBox
    Public WithEvents FireOneHanded As System.Windows.Forms.CheckBox
    Public WithEvents OneHandedPenalty As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PenaltyLabel As System.Windows.Forms.Label
    Public WithEvents FinesseStrength As System.Windows.Forms.CheckBox
    Public WithEvents BucklerPenalty As System.Windows.Forms.CheckBox
    Public WithEvents LDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DLDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents LDamageLabel As System.Windows.Forms.Label
    Public WithEvents AmmoCheck As System.Windows.Forms.CheckBox
    Public WithEvents ImprovisedMelee As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents FDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents TDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents HDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents GDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents CDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DFDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DDDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DTDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DHDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DGDamage As DevExpress.XtraEditors.TextEdit
    Public WithEvents DCDamage As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cost = New RPGXplorer.MoneySpin
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.WeaponTab = New System.Windows.Forms.TabPage
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.BaseItem = New System.Windows.Forms.CheckBox
        Me.Masterwork = New System.Windows.Forms.CheckBox
        Me.Weight = New DevExpress.XtraEditors.SpinEdit
        Me.Description = New DevExpress.XtraEditors.MemoEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.TrainingDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.NameLabel = New System.Windows.Forms.Label
        Me.DetailsTab = New System.Windows.Forms.TabPage
        Me.AmmoCheck = New System.Windows.Forms.CheckBox
        Me.BucklerPenalty = New System.Windows.Forms.CheckBox
        Me.FireOneHanded = New System.Windows.Forms.CheckBox
        Me.StrengthRating = New System.Windows.Forms.CheckBox
        Me.Reach = New DevExpress.XtraEditors.SpinEdit
        Me.ReachOnly = New System.Windows.Forms.CheckBox
        Me.MartialOneHanded = New System.Windows.Forms.CheckBox
        Me.RangeSpin = New DevExpress.XtraEditors.SpinEdit
        Me.RangeLabel = New System.Windows.Forms.Label
        Me.ApplyPenaltyCheck = New System.Windows.Forms.CheckBox
        Me.ApplyBonusCheck = New System.Windows.Forms.CheckBox
        Me.ThrownCheck = New System.Windows.Forms.CheckBox
        Me.DoubleCheck = New System.Windows.Forms.CheckBox
        Me.ReachCheck = New System.Windows.Forms.CheckBox
        Me.RangedRadio = New System.Windows.Forms.RadioButton
        Me.StrengthBonus = New DevExpress.XtraEditors.SpinEdit
        Me.EncumLabel = New System.Windows.Forms.Label
        Me.EncumDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.MeleeRadio = New System.Windows.Forms.RadioButton
        Me.OneHandedPenalty = New DevExpress.XtraEditors.SpinEdit
        Me.PenaltyLabel = New System.Windows.Forms.Label
        Me.ImprovisedMelee = New System.Windows.Forms.CheckBox
        Me.DamageTab = New System.Windows.Forms.TabPage
        Me.NoDamageRadio = New System.Windows.Forms.RadioButton
        Me.NonLethalRadio = New System.Windows.Forms.RadioButton
        Me.LethalRadio = New System.Windows.Forms.RadioButton
        Me.DJunctionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DDamageDropdown2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DDamageDropdown1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DMultiplier = New DevExpress.XtraEditors.SpinEdit
        Me.DSDamage = New DevExpress.XtraEditors.TextEdit
        Me.DMDamage = New DevExpress.XtraEditors.TextEdit
        Me.DSDamageLabel = New System.Windows.Forms.Label
        Me.SDamage = New DevExpress.XtraEditors.TextEdit
        Me.MDamage = New DevExpress.XtraEditors.TextEdit
        Me.ThreatRange = New DevExpress.XtraEditors.SpinEdit
        Me.JunctionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageDropdown2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.DamageDropdown1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SDamageLabel = New System.Windows.Forms.Label
        Me.MDamageLabel = New System.Windows.Forms.Label
        Me.Multiplier = New DevExpress.XtraEditors.SpinEdit
        Me.DivideLabel = New System.Windows.Forms.Label
        Me.LDamageLabel = New System.Windows.Forms.Label
        Me.LDamage = New DevExpress.XtraEditors.TextEdit
        Me.DLDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.FDamage = New DevExpress.XtraEditors.TextEdit
        Me.DDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.TDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.HDamage = New DevExpress.XtraEditors.TextEdit
        Me.GDamage = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CDamage = New DevExpress.XtraEditors.TextEdit
        Me.DFDamage = New DevExpress.XtraEditors.TextEdit
        Me.DDDamage = New DevExpress.XtraEditors.TextEdit
        Me.DTDamage = New DevExpress.XtraEditors.TextEdit
        Me.DHDamage = New DevExpress.XtraEditors.TextEdit
        Me.DGDamage = New DevExpress.XtraEditors.TextEdit
        Me.DCDamage = New DevExpress.XtraEditors.TextEdit
        Me.AdvancedTab = New System.Windows.Forms.TabPage
        Me.ShadowsDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.MonkCheck = New System.Windows.Forms.CheckBox
        Me.FinesseCheck = New System.Windows.Forms.CheckBox
        Me.ShadowsCheck = New System.Windows.Forms.CheckBox
        Me.ChargeCheck = New System.Windows.Forms.CheckBox
        Me.TripCheck = New System.Windows.Forms.CheckBox
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.FinesseStrength = New System.Windows.Forms.CheckBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.WeaponTab.SuspendLayout()
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsTab.SuspendLayout()
        CType(Me.Reach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StrengthBonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncumDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneHandedPenalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DamageTab.SuspendLayout()
        CType(Me.DJunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDamageDropdown2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDamageDropdown1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMultiplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThreatRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageDropdown2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageDropdown1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Multiplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DFDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DHDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DCDamage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdvancedTab.SuspendLayout()
        CType(Me.ShadowsDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.WeaponTab)
        Me.TabControl1.Controls.Add(Me.DetailsTab)
        Me.TabControl1.Controls.Add(Me.DamageTab)
        Me.TabControl1.Controls.Add(Me.AdvancedTab)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 515)
        Me.TabControl1.TabIndex = 0
        '
        'WeaponTab
        '
        Me.WeaponTab.Controls.Add(Me.IndentedLine4)
        Me.WeaponTab.Controls.Add(Me.BaseItem)
        Me.WeaponTab.Controls.Add(Me.Masterwork)
        Me.WeaponTab.Controls.Add(Me.Cost)
        Me.WeaponTab.Controls.Add(Me.Weight)
        Me.WeaponTab.Controls.Add(Me.Description)
        Me.WeaponTab.Controls.Add(Me.Label21)
        Me.WeaponTab.Controls.Add(Me.CostLabel)
        Me.WeaponTab.Controls.Add(Me.WeightLabel)
        Me.WeaponTab.Controls.Add(Me.IndentedLine1)
        Me.WeaponTab.Controls.Add(Me.TrainingDropdown)
        Me.WeaponTab.Controls.Add(Me.Label1)
        Me.WeaponTab.Controls.Add(Me.ObjectName)
        Me.WeaponTab.Controls.Add(Me.NameLabel)
        Me.WeaponTab.Location = New System.Drawing.Point(4, 22)
        Me.WeaponTab.Name = "WeaponTab"
        Me.WeaponTab.Size = New System.Drawing.Size(407, 489)
        Me.WeaponTab.TabIndex = 0
        Me.WeaponTab.Text = "Weapon"
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Location = New System.Drawing.Point(16, 215)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 184
        Me.IndentedLine4.TabStop = False
        '
        'BaseItem
        '
        Me.BaseItem.Location = New System.Drawing.Point(15, 260)
        Me.BaseItem.Name = "BaseItem"
        Me.BaseItem.Size = New System.Drawing.Size(205, 24)
        Me.BaseItem.TabIndex = 6
        Me.BaseItem.Text = "Base for Magic Weapon only"
        '
        'Masterwork
        '
        Me.Masterwork.Location = New System.Drawing.Point(15, 230)
        Me.Masterwork.Name = "Masterwork"
        Me.Masterwork.Size = New System.Drawing.Size(104, 24)
        Me.Masterwork.TabIndex = 5
        Me.Masterwork.Text = "Masterwork"
        '
        'Cost
        '
        Me.Cost.Location = New System.Drawing.Point(85, 150)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(180, 21)
        Me.Cost.TabIndex = 3
        '
        'Weight
        '
        Me.Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Weight.Location = New System.Drawing.Point(85, 180)
        Me.Weight.Name = "Weight"
        Me.Weight.Properties.Appearance.Options.UseTextOptions = True
        Me.Weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Weight.Properties.AutoHeight = False
        Me.Weight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Weight.Properties.Mask.ShowPlaceHolders = False
        Me.Weight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Weight.Size = New System.Drawing.Size(70, 21)
        Me.Weight.TabIndex = 4
        '
        'Description
        '
        Me.Description.CausesValidation = False
        Me.Description.EditValue = ""
        Me.Description.Location = New System.Drawing.Point(85, 45)
        Me.Description.Name = "Description"
        Me.Description.Properties.MaxLength = 200
        Me.Description.Size = New System.Drawing.Size(304, 46)
        Me.Description.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 21)
        Me.Label21.TabIndex = 182
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostLabel
        '
        Me.CostLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CostLabel.Location = New System.Drawing.Point(15, 150)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(60, 21)
        Me.CostLabel.TabIndex = 167
        Me.CostLabel.Text = "Cost (S,M)"
        Me.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WeightLabel
        '
        Me.WeightLabel.BackColor = System.Drawing.SystemColors.Control
        Me.WeightLabel.Location = New System.Drawing.Point(15, 180)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(60, 21)
        Me.WeightLabel.TabIndex = 166
        Me.WeightLabel.Text = "Weight (M)"
        Me.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 105)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 162
        Me.IndentedLine1.TabStop = False
        '
        'TrainingDropdown
        '
        Me.TrainingDropdown.EditValue = ""
        Me.TrainingDropdown.Location = New System.Drawing.Point(85, 120)
        Me.TrainingDropdown.Name = "TrainingDropdown"
        Me.TrainingDropdown.Properties.AutoHeight = False
        Me.TrainingDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TrainingDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TrainingDropdown.Size = New System.Drawing.Size(150, 21)
        Me.TrainingDropdown.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Training"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(85, 15)
        Me.ObjectName.Name = "ObjectName"
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(150, 21)
        Me.ObjectName.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.NameLabel.Location = New System.Drawing.Point(15, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 21)
        Me.NameLabel.TabIndex = 107
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DetailsTab
        '
        Me.DetailsTab.Controls.Add(Me.AmmoCheck)
        Me.DetailsTab.Controls.Add(Me.BucklerPenalty)
        Me.DetailsTab.Controls.Add(Me.FireOneHanded)
        Me.DetailsTab.Controls.Add(Me.StrengthRating)
        Me.DetailsTab.Controls.Add(Me.Reach)
        Me.DetailsTab.Controls.Add(Me.ReachOnly)
        Me.DetailsTab.Controls.Add(Me.MartialOneHanded)
        Me.DetailsTab.Controls.Add(Me.RangeSpin)
        Me.DetailsTab.Controls.Add(Me.RangeLabel)
        Me.DetailsTab.Controls.Add(Me.ApplyPenaltyCheck)
        Me.DetailsTab.Controls.Add(Me.ApplyBonusCheck)
        Me.DetailsTab.Controls.Add(Me.ThrownCheck)
        Me.DetailsTab.Controls.Add(Me.DoubleCheck)
        Me.DetailsTab.Controls.Add(Me.ReachCheck)
        Me.DetailsTab.Controls.Add(Me.RangedRadio)
        Me.DetailsTab.Controls.Add(Me.StrengthBonus)
        Me.DetailsTab.Controls.Add(Me.EncumLabel)
        Me.DetailsTab.Controls.Add(Me.EncumDropdown)
        Me.DetailsTab.Controls.Add(Me.MeleeRadio)
        Me.DetailsTab.Controls.Add(Me.OneHandedPenalty)
        Me.DetailsTab.Controls.Add(Me.PenaltyLabel)
        Me.DetailsTab.Controls.Add(Me.ImprovisedMelee)
        Me.DetailsTab.Location = New System.Drawing.Point(4, 22)
        Me.DetailsTab.Name = "DetailsTab"
        Me.DetailsTab.Size = New System.Drawing.Size(407, 489)
        Me.DetailsTab.TabIndex = 5
        Me.DetailsTab.Text = "Details"
        '
        'AmmoCheck
        '
        Me.AmmoCheck.Enabled = False
        Me.AmmoCheck.Location = New System.Drawing.Point(15, 345)
        Me.AmmoCheck.Name = "AmmoCheck"
        Me.AmmoCheck.Size = New System.Drawing.Size(215, 25)
        Me.AmmoCheck.TabIndex = 19
        Me.AmmoCheck.Text = "Treat as Ammunition for Magic Pricing"
        '
        'BucklerPenalty
        '
        Me.BucklerPenalty.Location = New System.Drawing.Point(15, 285)
        Me.BucklerPenalty.Name = "BucklerPenalty"
        Me.BucklerPenalty.Size = New System.Drawing.Size(190, 21)
        Me.BucklerPenalty.TabIndex = 16
        Me.BucklerPenalty.Text = "-1 Attack Roll If Wearing Buckler"
        '
        'FireOneHanded
        '
        Me.FireOneHanded.Enabled = False
        Me.FireOneHanded.Location = New System.Drawing.Point(15, 255)
        Me.FireOneHanded.Name = "FireOneHanded"
        Me.FireOneHanded.Size = New System.Drawing.Size(160, 21)
        Me.FireOneHanded.TabIndex = 13
        Me.FireOneHanded.Text = "Can Be Fired One Handed"
        '
        'StrengthRating
        '
        Me.StrengthRating.Enabled = False
        Me.StrengthRating.Location = New System.Drawing.Point(245, 195)
        Me.StrengthRating.Name = "StrengthRating"
        Me.StrengthRating.Size = New System.Drawing.Size(85, 21)
        Me.StrengthRating.TabIndex = 10
        Me.StrengthRating.Text = "STR Rating"
        '
        'Reach
        '
        Me.Reach.CausesValidation = False
        Me.Reach.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Reach.Enabled = False
        Me.Reach.Location = New System.Drawing.Point(120, 75)
        Me.Reach.Name = "Reach"
        Me.Reach.Properties.Appearance.Options.UseTextOptions = True
        Me.Reach.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Reach.Properties.AutoHeight = False
        Me.Reach.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Reach.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Reach.Properties.IsFloatValue = False
        Me.Reach.Properties.Mask.BeepOnError = True
        Me.Reach.Properties.Mask.EditMask = "999"
        Me.Reach.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Reach.Properties.Mask.ShowPlaceHolders = False
        Me.Reach.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Reach.Properties.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Reach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Reach.Size = New System.Drawing.Size(55, 21)
        Me.Reach.TabIndex = 4
        '
        'ReachOnly
        '
        Me.ReachOnly.Enabled = False
        Me.ReachOnly.Location = New System.Drawing.Point(195, 75)
        Me.ReachOnly.Name = "ReachOnly"
        Me.ReachOnly.Size = New System.Drawing.Size(205, 21)
        Me.ReachOnly.TabIndex = 5
        Me.ReachOnly.Text = "Can Only Attack at Specified Reach"
        '
        'MartialOneHanded
        '
        Me.MartialOneHanded.Enabled = False
        Me.MartialOneHanded.Location = New System.Drawing.Point(15, 135)
        Me.MartialOneHanded.Name = "MartialOneHanded"
        Me.MartialOneHanded.Size = New System.Drawing.Size(170, 21)
        Me.MartialOneHanded.TabIndex = 7
        Me.MartialOneHanded.Text = "Martial Two-Handed Weapon"
        '
        'RangeSpin
        '
        Me.RangeSpin.CausesValidation = False
        Me.RangeSpin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RangeSpin.Enabled = False
        Me.RangeSpin.Location = New System.Drawing.Point(115, 315)
        Me.RangeSpin.Name = "RangeSpin"
        Me.RangeSpin.Properties.Appearance.Options.UseTextOptions = True
        Me.RangeSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RangeSpin.Properties.AutoHeight = False
        Me.RangeSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RangeSpin.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.RangeSpin.Properties.IsFloatValue = False
        Me.RangeSpin.Properties.Mask.BeepOnError = True
        Me.RangeSpin.Properties.Mask.EditMask = "999"
        Me.RangeSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RangeSpin.Properties.Mask.ShowPlaceHolders = False
        Me.RangeSpin.Properties.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.RangeSpin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RangeSpin.Size = New System.Drawing.Size(55, 21)
        Me.RangeSpin.TabIndex = 18
        '
        'RangeLabel
        '
        Me.RangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.RangeLabel.Enabled = False
        Me.RangeLabel.Location = New System.Drawing.Point(15, 315)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(100, 21)
        Me.RangeLabel.TabIndex = 17
        Me.RangeLabel.Text = "Range Increment"
        Me.RangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ApplyPenaltyCheck
        '
        Me.ApplyPenaltyCheck.Location = New System.Drawing.Point(15, 225)
        Me.ApplyPenaltyCheck.Name = "ApplyPenaltyCheck"
        Me.ApplyPenaltyCheck.Size = New System.Drawing.Size(225, 21)
        Me.ApplyPenaltyCheck.TabIndex = 12
        Me.ApplyPenaltyCheck.Text = "Apply Strength Penalty to Damage Rolls"
        '
        'ApplyBonusCheck
        '
        Me.ApplyBonusCheck.Location = New System.Drawing.Point(15, 195)
        Me.ApplyBonusCheck.Name = "ApplyBonusCheck"
        Me.ApplyBonusCheck.Size = New System.Drawing.Size(220, 21)
        Me.ApplyBonusCheck.TabIndex = 9
        Me.ApplyBonusCheck.Text = "Apply Strength Bonus to Damage Rolls"
        '
        'ThrownCheck
        '
        Me.ThrownCheck.Location = New System.Drawing.Point(15, 165)
        Me.ThrownCheck.Name = "ThrownCheck"
        Me.ThrownCheck.Size = New System.Drawing.Size(110, 21)
        Me.ThrownCheck.TabIndex = 8
        Me.ThrownCheck.Text = "Thrown Weapon"
        '
        'DoubleCheck
        '
        Me.DoubleCheck.Enabled = False
        Me.DoubleCheck.Location = New System.Drawing.Point(15, 105)
        Me.DoubleCheck.Name = "DoubleCheck"
        Me.DoubleCheck.Size = New System.Drawing.Size(104, 21)
        Me.DoubleCheck.TabIndex = 6
        Me.DoubleCheck.Text = "Double Weapon"
        '
        'ReachCheck
        '
        Me.ReachCheck.Location = New System.Drawing.Point(15, 75)
        Me.ReachCheck.Name = "ReachCheck"
        Me.ReachCheck.Size = New System.Drawing.Size(104, 21)
        Me.ReachCheck.TabIndex = 3
        Me.ReachCheck.Text = "Reach Weapon"
        '
        'RangedRadio
        '
        Me.RangedRadio.Location = New System.Drawing.Point(85, 15)
        Me.RangedRadio.Name = "RangedRadio"
        Me.RangedRadio.Size = New System.Drawing.Size(70, 21)
        Me.RangedRadio.TabIndex = 1
        Me.RangedRadio.TabStop = True
        Me.RangedRadio.Text = "Ranged"
        '
        'StrengthBonus
        '
        Me.StrengthBonus.CausesValidation = False
        Me.StrengthBonus.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StrengthBonus.Enabled = False
        Me.StrengthBonus.Location = New System.Drawing.Point(330, 195)
        Me.StrengthBonus.Name = "StrengthBonus"
        Me.StrengthBonus.Properties.Appearance.Options.UseTextOptions = True
        Me.StrengthBonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StrengthBonus.Properties.AutoHeight = False
        Me.StrengthBonus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.StrengthBonus.Properties.DisplayFormat.FormatString = "+0;0;0"
        Me.StrengthBonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.StrengthBonus.Properties.EditFormat.FormatString = "+0;0;0"
        Me.StrengthBonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.StrengthBonus.Properties.IsFloatValue = False
        Me.StrengthBonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.StrengthBonus.Properties.Mask.ShowPlaceHolders = False
        Me.StrengthBonus.Properties.MaxValue = New Decimal(New Integer() {25, 0, 0, 0})
        Me.StrengthBonus.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StrengthBonus.Size = New System.Drawing.Size(55, 21)
        Me.StrengthBonus.TabIndex = 11
        '
        'EncumLabel
        '
        Me.EncumLabel.Location = New System.Drawing.Point(15, 45)
        Me.EncumLabel.Name = "EncumLabel"
        Me.EncumLabel.Size = New System.Drawing.Size(75, 21)
        Me.EncumLabel.TabIndex = 192
        Me.EncumLabel.Text = "Encumbrance"
        Me.EncumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EncumDropdown
        '
        Me.EncumDropdown.Location = New System.Drawing.Point(100, 45)
        Me.EncumDropdown.Name = "EncumDropdown"
        Me.EncumDropdown.Properties.AutoHeight = False
        Me.EncumDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EncumDropdown.Properties.DropDownRows = 10
        Me.EncumDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.EncumDropdown.Size = New System.Drawing.Size(225, 21)
        Me.EncumDropdown.TabIndex = 2
        '
        'MeleeRadio
        '
        Me.MeleeRadio.Checked = True
        Me.MeleeRadio.Location = New System.Drawing.Point(15, 15)
        Me.MeleeRadio.Name = "MeleeRadio"
        Me.MeleeRadio.Size = New System.Drawing.Size(60, 21)
        Me.MeleeRadio.TabIndex = 0
        Me.MeleeRadio.TabStop = True
        Me.MeleeRadio.Text = "Melee"
        '
        'OneHandedPenalty
        '
        Me.OneHandedPenalty.CausesValidation = False
        Me.OneHandedPenalty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OneHandedPenalty.Enabled = False
        Me.OneHandedPenalty.Location = New System.Drawing.Point(230, 255)
        Me.OneHandedPenalty.Name = "OneHandedPenalty"
        Me.OneHandedPenalty.Properties.Appearance.Options.UseTextOptions = True
        Me.OneHandedPenalty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OneHandedPenalty.Properties.AutoHeight = False
        Me.OneHandedPenalty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.OneHandedPenalty.Properties.DisplayFormat.FormatString = "+0;-0;0"
        Me.OneHandedPenalty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OneHandedPenalty.Properties.EditFormat.FormatString = "+0;-0;0"
        Me.OneHandedPenalty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OneHandedPenalty.Properties.IsFloatValue = False
        Me.OneHandedPenalty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.OneHandedPenalty.Properties.Mask.ShowPlaceHolders = False
        Me.OneHandedPenalty.Properties.MinValue = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.OneHandedPenalty.Size = New System.Drawing.Size(55, 21)
        Me.OneHandedPenalty.TabIndex = 15
        '
        'PenaltyLabel
        '
        Me.PenaltyLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PenaltyLabel.Enabled = False
        Me.PenaltyLabel.Location = New System.Drawing.Point(180, 254)
        Me.PenaltyLabel.Name = "PenaltyLabel"
        Me.PenaltyLabel.Size = New System.Drawing.Size(45, 21)
        Me.PenaltyLabel.TabIndex = 14
        Me.PenaltyLabel.Text = "Penalty"
        Me.PenaltyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImprovisedMelee
        '
        Me.ImprovisedMelee.Enabled = False
        Me.ImprovisedMelee.Location = New System.Drawing.Point(15, 375)
        Me.ImprovisedMelee.Name = "ImprovisedMelee"
        Me.ImprovisedMelee.Size = New System.Drawing.Size(245, 25)
        Me.ImprovisedMelee.TabIndex = 19
        Me.ImprovisedMelee.Text = "Improvised Melee Weapon at -4 Attack Roll"
        '
        'DamageTab
        '
        Me.DamageTab.Controls.Add(Me.NoDamageRadio)
        Me.DamageTab.Controls.Add(Me.NonLethalRadio)
        Me.DamageTab.Controls.Add(Me.LethalRadio)
        Me.DamageTab.Controls.Add(Me.DJunctionDropdown)
        Me.DamageTab.Controls.Add(Me.DDamageDropdown2)
        Me.DamageTab.Controls.Add(Me.DDamageDropdown1)
        Me.DamageTab.Controls.Add(Me.Label4)
        Me.DamageTab.Controls.Add(Me.IndentedLine5)
        Me.DamageTab.Controls.Add(Me.Label3)
        Me.DamageTab.Controls.Add(Me.Label2)
        Me.DamageTab.Controls.Add(Me.DMultiplier)
        Me.DamageTab.Controls.Add(Me.DSDamage)
        Me.DamageTab.Controls.Add(Me.DMDamage)
        Me.DamageTab.Controls.Add(Me.DSDamageLabel)
        Me.DamageTab.Controls.Add(Me.SDamage)
        Me.DamageTab.Controls.Add(Me.MDamage)
        Me.DamageTab.Controls.Add(Me.ThreatRange)
        Me.DamageTab.Controls.Add(Me.JunctionDropdown)
        Me.DamageTab.Controls.Add(Me.DamageDropdown2)
        Me.DamageTab.Controls.Add(Me.DamageDropdown1)
        Me.DamageTab.Controls.Add(Me.SDamageLabel)
        Me.DamageTab.Controls.Add(Me.MDamageLabel)
        Me.DamageTab.Controls.Add(Me.Multiplier)
        Me.DamageTab.Controls.Add(Me.DivideLabel)
        Me.DamageTab.Controls.Add(Me.LDamageLabel)
        Me.DamageTab.Controls.Add(Me.LDamage)
        Me.DamageTab.Controls.Add(Me.DLDamage)
        Me.DamageTab.Controls.Add(Me.Label5)
        Me.DamageTab.Controls.Add(Me.FDamage)
        Me.DamageTab.Controls.Add(Me.DDamage)
        Me.DamageTab.Controls.Add(Me.Label6)
        Me.DamageTab.Controls.Add(Me.TDamage)
        Me.DamageTab.Controls.Add(Me.Label7)
        Me.DamageTab.Controls.Add(Me.Label8)
        Me.DamageTab.Controls.Add(Me.Label9)
        Me.DamageTab.Controls.Add(Me.HDamage)
        Me.DamageTab.Controls.Add(Me.GDamage)
        Me.DamageTab.Controls.Add(Me.Label10)
        Me.DamageTab.Controls.Add(Me.Label11)
        Me.DamageTab.Controls.Add(Me.CDamage)
        Me.DamageTab.Controls.Add(Me.DFDamage)
        Me.DamageTab.Controls.Add(Me.DDDamage)
        Me.DamageTab.Controls.Add(Me.DTDamage)
        Me.DamageTab.Controls.Add(Me.DHDamage)
        Me.DamageTab.Controls.Add(Me.DGDamage)
        Me.DamageTab.Controls.Add(Me.DCDamage)
        Me.DamageTab.Location = New System.Drawing.Point(4, 22)
        Me.DamageTab.Name = "DamageTab"
        Me.DamageTab.Size = New System.Drawing.Size(407, 489)
        Me.DamageTab.TabIndex = 1
        Me.DamageTab.Text = "Damage"
        '
        'NoDamageRadio
        '
        Me.NoDamageRadio.Location = New System.Drawing.Point(175, 15)
        Me.NoDamageRadio.Name = "NoDamageRadio"
        Me.NoDamageRadio.Size = New System.Drawing.Size(85, 21)
        Me.NoDamageRadio.TabIndex = 2
        Me.NoDamageRadio.TabStop = True
        Me.NoDamageRadio.Text = "No Damage"
        '
        'NonLethalRadio
        '
        Me.NonLethalRadio.Location = New System.Drawing.Point(85, 15)
        Me.NonLethalRadio.Name = "NonLethalRadio"
        Me.NonLethalRadio.Size = New System.Drawing.Size(80, 21)
        Me.NonLethalRadio.TabIndex = 1
        Me.NonLethalRadio.TabStop = True
        Me.NonLethalRadio.Text = "Non-Lethal"
        '
        'LethalRadio
        '
        Me.LethalRadio.Checked = True
        Me.LethalRadio.Location = New System.Drawing.Point(15, 15)
        Me.LethalRadio.Name = "LethalRadio"
        Me.LethalRadio.Size = New System.Drawing.Size(60, 21)
        Me.LethalRadio.TabIndex = 0
        Me.LethalRadio.TabStop = True
        Me.LethalRadio.Text = "Lethal"
        '
        'DJunctionDropdown
        '
        Me.DJunctionDropdown.CausesValidation = False
        Me.DJunctionDropdown.Enabled = False
        Me.DJunctionDropdown.Location = New System.Drawing.Point(290, 420)
        Me.DJunctionDropdown.Name = "DJunctionDropdown"
        Me.DJunctionDropdown.Properties.AutoHeight = False
        Me.DJunctionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DJunctionDropdown.Properties.DropDownRows = 10
        Me.DJunctionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DJunctionDropdown.Size = New System.Drawing.Size(50, 21)
        Me.DJunctionDropdown.TabIndex = 28
        '
        'DDamageDropdown2
        '
        Me.DDamageDropdown2.Enabled = False
        Me.DDamageDropdown2.Location = New System.Drawing.Point(265, 450)
        Me.DDamageDropdown2.Name = "DDamageDropdown2"
        Me.DDamageDropdown2.Properties.AutoHeight = False
        Me.DDamageDropdown2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DDamageDropdown2.Properties.DropDownRows = 10
        Me.DDamageDropdown2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DDamageDropdown2.Size = New System.Drawing.Size(100, 21)
        Me.DDamageDropdown2.TabIndex = 29
        '
        'DDamageDropdown1
        '
        Me.DDamageDropdown1.Enabled = False
        Me.DDamageDropdown1.Location = New System.Drawing.Point(265, 390)
        Me.DDamageDropdown1.Name = "DDamageDropdown1"
        Me.DDamageDropdown1.Properties.AutoHeight = False
        Me.DDamageDropdown1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DDamageDropdown1.Properties.DropDownRows = 10
        Me.DDamageDropdown1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DDamageDropdown1.Size = New System.Drawing.Size(100, 21)
        Me.DDamageDropdown1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 21)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Damage Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine5
        '
        Me.IndentedLine5.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 232
        Me.IndentedLine5.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "Double Weapon"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Critical Hits"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DMultiplier
        '
        Me.DMultiplier.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.DMultiplier.Enabled = False
        Me.DMultiplier.Location = New System.Drawing.Point(290, 360)
        Me.DMultiplier.Name = "DMultiplier"
        Me.DMultiplier.Properties.Appearance.Options.UseTextOptions = True
        Me.DMultiplier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DMultiplier.Properties.AutoHeight = False
        Me.DMultiplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DMultiplier.Properties.DisplayFormat.FormatString = "x#;"
        Me.DMultiplier.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DMultiplier.Properties.EditFormat.FormatString = "x#;"
        Me.DMultiplier.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DMultiplier.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.DMultiplier.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.DMultiplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DMultiplier.Size = New System.Drawing.Size(50, 21)
        Me.DMultiplier.TabIndex = 26
        '
        'DSDamage
        '
        Me.DSDamage.Enabled = False
        Me.DSDamage.Location = New System.Drawing.Point(290, 180)
        Me.DSDamage.Name = "DSDamage"
        Me.DSDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DSDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DSDamage.Properties.AutoHeight = False
        Me.DSDamage.Size = New System.Drawing.Size(50, 21)
        Me.DSDamage.TabIndex = 20
        '
        'DMDamage
        '
        Me.DMDamage.Enabled = False
        Me.DMDamage.Location = New System.Drawing.Point(290, 210)
        Me.DMDamage.Name = "DMDamage"
        Me.DMDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DMDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DMDamage.Properties.AutoHeight = False
        Me.DMDamage.Size = New System.Drawing.Size(50, 21)
        Me.DMDamage.TabIndex = 21
        '
        'DSDamageLabel
        '
        Me.DSDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DSDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DSDamageLabel.Location = New System.Drawing.Point(15, 180)
        Me.DSDamageLabel.Name = "DSDamageLabel"
        Me.DSDamageLabel.Size = New System.Drawing.Size(70, 21)
        Me.DSDamageLabel.TabIndex = 228
        Me.DSDamageLabel.Text = "Small"
        Me.DSDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SDamage
        '
        Me.SDamage.Location = New System.Drawing.Point(145, 180)
        Me.SDamage.Name = "SDamage"
        Me.SDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.SDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SDamage.Properties.AutoHeight = False
        Me.SDamage.Size = New System.Drawing.Size(50, 21)
        Me.SDamage.TabIndex = 6
        '
        'MDamage
        '
        Me.MDamage.Location = New System.Drawing.Point(145, 210)
        Me.MDamage.Name = "MDamage"
        Me.MDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.MDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MDamage.Properties.AutoHeight = False
        Me.MDamage.Size = New System.Drawing.Size(50, 21)
        Me.MDamage.TabIndex = 7
        '
        'ThreatRange
        '
        Me.ThreatRange.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ThreatRange.Location = New System.Drawing.Point(110, 360)
        Me.ThreatRange.Name = "ThreatRange"
        Me.ThreatRange.Properties.Appearance.Options.UseTextOptions = True
        Me.ThreatRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ThreatRange.Properties.AutoHeight = False
        Me.ThreatRange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ThreatRange.Properties.DisplayFormat.FormatString = "#-2\0"
        Me.ThreatRange.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ThreatRange.Properties.EditFormat.FormatString = "#-2\0"
        Me.ThreatRange.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ThreatRange.Properties.IsFloatValue = False
        Me.ThreatRange.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ThreatRange.Properties.MinValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.ThreatRange.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ThreatRange.Size = New System.Drawing.Size(55, 21)
        Me.ThreatRange.TabIndex = 12
        '
        'JunctionDropdown
        '
        Me.JunctionDropdown.CausesValidation = False
        Me.JunctionDropdown.Enabled = False
        Me.JunctionDropdown.Location = New System.Drawing.Point(145, 420)
        Me.JunctionDropdown.Name = "JunctionDropdown"
        Me.JunctionDropdown.Properties.AutoHeight = False
        Me.JunctionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JunctionDropdown.Properties.DropDownRows = 10
        Me.JunctionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.JunctionDropdown.Size = New System.Drawing.Size(50, 21)
        Me.JunctionDropdown.TabIndex = 15
        '
        'DamageDropdown2
        '
        Me.DamageDropdown2.Enabled = False
        Me.DamageDropdown2.Location = New System.Drawing.Point(120, 450)
        Me.DamageDropdown2.Name = "DamageDropdown2"
        Me.DamageDropdown2.Properties.AutoHeight = False
        Me.DamageDropdown2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageDropdown2.Properties.DropDownRows = 10
        Me.DamageDropdown2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageDropdown2.Size = New System.Drawing.Size(100, 21)
        Me.DamageDropdown2.TabIndex = 16
        '
        'DamageDropdown1
        '
        Me.DamageDropdown1.Location = New System.Drawing.Point(120, 390)
        Me.DamageDropdown1.Name = "DamageDropdown1"
        Me.DamageDropdown1.Properties.AutoHeight = False
        Me.DamageDropdown1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DamageDropdown1.Properties.DropDownRows = 10
        Me.DamageDropdown1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DamageDropdown1.Size = New System.Drawing.Size(100, 21)
        Me.DamageDropdown1.TabIndex = 14
        '
        'SDamageLabel
        '
        Me.SDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.SDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDamageLabel.Location = New System.Drawing.Point(110, 65)
        Me.SDamageLabel.Name = "SDamageLabel"
        Me.SDamageLabel.Size = New System.Drawing.Size(125, 21)
        Me.SDamageLabel.TabIndex = 183
        Me.SDamageLabel.Text = "Primary"
        Me.SDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MDamageLabel
        '
        Me.MDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.MDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MDamageLabel.Location = New System.Drawing.Point(15, 210)
        Me.MDamageLabel.Name = "MDamageLabel"
        Me.MDamageLabel.Size = New System.Drawing.Size(70, 21)
        Me.MDamageLabel.TabIndex = 181
        Me.MDamageLabel.Text = "Medium"
        Me.MDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Multiplier
        '
        Me.Multiplier.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Multiplier.Location = New System.Drawing.Point(180, 360)
        Me.Multiplier.Name = "Multiplier"
        Me.Multiplier.Properties.Appearance.Options.UseTextOptions = True
        Me.Multiplier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Multiplier.Properties.AutoHeight = False
        Me.Multiplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Multiplier.Properties.DisplayFormat.FormatString = "x#;#;0"
        Me.Multiplier.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Multiplier.Properties.EditFormat.FormatString = "x#;#;0"
        Me.Multiplier.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Multiplier.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Multiplier.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Multiplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Multiplier.Size = New System.Drawing.Size(50, 21)
        Me.Multiplier.TabIndex = 13
        '
        'DivideLabel
        '
        Me.DivideLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DivideLabel.Location = New System.Drawing.Point(165, 360)
        Me.DivideLabel.Name = "DivideLabel"
        Me.DivideLabel.Size = New System.Drawing.Size(15, 21)
        Me.DivideLabel.TabIndex = 178
        Me.DivideLabel.Text = "/"
        Me.DivideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LDamageLabel
        '
        Me.LDamageLabel.BackColor = System.Drawing.SystemColors.Control
        Me.LDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDamageLabel.Location = New System.Drawing.Point(15, 240)
        Me.LDamageLabel.Name = "LDamageLabel"
        Me.LDamageLabel.Size = New System.Drawing.Size(70, 21)
        Me.LDamageLabel.TabIndex = 181
        Me.LDamageLabel.Text = "Large"
        Me.LDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LDamage
        '
        Me.LDamage.Location = New System.Drawing.Point(145, 240)
        Me.LDamage.Name = "LDamage"
        Me.LDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.LDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LDamage.Properties.AutoHeight = False
        Me.LDamage.Size = New System.Drawing.Size(50, 21)
        Me.LDamage.TabIndex = 8
        '
        'DLDamage
        '
        Me.DLDamage.Enabled = False
        Me.DLDamage.Location = New System.Drawing.Point(290, 240)
        Me.DLDamage.Name = "DLDamage"
        Me.DLDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DLDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DLDamage.Properties.AutoHeight = False
        Me.DLDamage.Size = New System.Drawing.Size(50, 21)
        Me.DLDamage.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Damage"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FDamage
        '
        Me.FDamage.CausesValidation = False
        Me.FDamage.Location = New System.Drawing.Point(145, 90)
        Me.FDamage.Name = "FDamage"
        Me.FDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.FDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FDamage.Properties.AutoHeight = False
        Me.FDamage.Size = New System.Drawing.Size(50, 21)
        Me.FDamage.TabIndex = 3
        '
        'DDamage
        '
        Me.DDamage.CausesValidation = False
        Me.DDamage.Location = New System.Drawing.Point(145, 120)
        Me.DDamage.Name = "DDamage"
        Me.DDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDamage.Properties.AutoHeight = False
        Me.DDamage.Size = New System.Drawing.Size(50, 21)
        Me.DDamage.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "Tiny"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TDamage
        '
        Me.TDamage.CausesValidation = False
        Me.TDamage.Location = New System.Drawing.Point(145, 150)
        Me.TDamage.Name = "TDamage"
        Me.TDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.TDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TDamage.Properties.AutoHeight = False
        Me.TDamage.Size = New System.Drawing.Size(50, 21)
        Me.TDamage.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Fine"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 21)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Diminutive"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(15, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 21)
        Me.Label9.TabIndex = 228
        Me.Label9.Text = "Huge"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HDamage
        '
        Me.HDamage.CausesValidation = False
        Me.HDamage.Location = New System.Drawing.Point(145, 270)
        Me.HDamage.Name = "HDamage"
        Me.HDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.HDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.HDamage.Properties.AutoHeight = False
        Me.HDamage.Size = New System.Drawing.Size(50, 21)
        Me.HDamage.TabIndex = 9
        '
        'GDamage
        '
        Me.GDamage.CausesValidation = False
        Me.GDamage.Location = New System.Drawing.Point(145, 300)
        Me.GDamage.Name = "GDamage"
        Me.GDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.GDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDamage.Properties.AutoHeight = False
        Me.GDamage.Size = New System.Drawing.Size(50, 21)
        Me.GDamage.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 21)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "Gargantuan"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 21)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Colossal"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CDamage
        '
        Me.CDamage.CausesValidation = False
        Me.CDamage.Location = New System.Drawing.Point(145, 330)
        Me.CDamage.Name = "CDamage"
        Me.CDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.CDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CDamage.Properties.AutoHeight = False
        Me.CDamage.Size = New System.Drawing.Size(50, 21)
        Me.CDamage.TabIndex = 11
        '
        'DFDamage
        '
        Me.DFDamage.CausesValidation = False
        Me.DFDamage.Enabled = False
        Me.DFDamage.Location = New System.Drawing.Point(290, 90)
        Me.DFDamage.Name = "DFDamage"
        Me.DFDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DFDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DFDamage.Properties.AutoHeight = False
        Me.DFDamage.Size = New System.Drawing.Size(50, 21)
        Me.DFDamage.TabIndex = 17
        '
        'DDDamage
        '
        Me.DDDamage.CausesValidation = False
        Me.DDDamage.Enabled = False
        Me.DDDamage.Location = New System.Drawing.Point(290, 120)
        Me.DDDamage.Name = "DDDamage"
        Me.DDDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DDDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDDamage.Properties.AutoHeight = False
        Me.DDDamage.Size = New System.Drawing.Size(50, 21)
        Me.DDDamage.TabIndex = 18
        '
        'DTDamage
        '
        Me.DTDamage.CausesValidation = False
        Me.DTDamage.Enabled = False
        Me.DTDamage.Location = New System.Drawing.Point(290, 150)
        Me.DTDamage.Name = "DTDamage"
        Me.DTDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DTDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DTDamage.Properties.AutoHeight = False
        Me.DTDamage.Size = New System.Drawing.Size(50, 21)
        Me.DTDamage.TabIndex = 19
        '
        'DHDamage
        '
        Me.DHDamage.CausesValidation = False
        Me.DHDamage.Enabled = False
        Me.DHDamage.Location = New System.Drawing.Point(290, 270)
        Me.DHDamage.Name = "DHDamage"
        Me.DHDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DHDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DHDamage.Properties.AutoHeight = False
        Me.DHDamage.Size = New System.Drawing.Size(50, 21)
        Me.DHDamage.TabIndex = 23
        '
        'DGDamage
        '
        Me.DGDamage.CausesValidation = False
        Me.DGDamage.Enabled = False
        Me.DGDamage.Location = New System.Drawing.Point(290, 300)
        Me.DGDamage.Name = "DGDamage"
        Me.DGDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DGDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DGDamage.Properties.AutoHeight = False
        Me.DGDamage.Size = New System.Drawing.Size(50, 21)
        Me.DGDamage.TabIndex = 24
        '
        'DCDamage
        '
        Me.DCDamage.CausesValidation = False
        Me.DCDamage.Enabled = False
        Me.DCDamage.Location = New System.Drawing.Point(290, 330)
        Me.DCDamage.Name = "DCDamage"
        Me.DCDamage.Properties.Appearance.Options.UseTextOptions = True
        Me.DCDamage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DCDamage.Properties.AutoHeight = False
        Me.DCDamage.Size = New System.Drawing.Size(50, 21)
        Me.DCDamage.TabIndex = 25
        '
        'AdvancedTab
        '
        Me.AdvancedTab.Controls.Add(Me.ShadowsDropdown)
        Me.AdvancedTab.Controls.Add(Me.MonkCheck)
        Me.AdvancedTab.Controls.Add(Me.FinesseCheck)
        Me.AdvancedTab.Controls.Add(Me.ShadowsCheck)
        Me.AdvancedTab.Controls.Add(Me.ChargeCheck)
        Me.AdvancedTab.Controls.Add(Me.TripCheck)
        Me.AdvancedTab.Controls.Add(Me.IndentedLine3)
        Me.AdvancedTab.Controls.Add(Me.FinesseStrength)
        Me.AdvancedTab.Location = New System.Drawing.Point(4, 22)
        Me.AdvancedTab.Name = "AdvancedTab"
        Me.AdvancedTab.Size = New System.Drawing.Size(407, 489)
        Me.AdvancedTab.TabIndex = 2
        Me.AdvancedTab.Text = "Miscellaneous"
        '
        'ShadowsDropdown
        '
        Me.ShadowsDropdown.Enabled = False
        Me.ShadowsDropdown.Location = New System.Drawing.Point(15, 215)
        Me.ShadowsDropdown.Name = "ShadowsDropdown"
        Me.ShadowsDropdown.Properties.AutoHeight = False
        Me.ShadowsDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShadowsDropdown.Properties.DropDownRows = 10
        Me.ShadowsDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ShadowsDropdown.Size = New System.Drawing.Size(200, 21)
        Me.ShadowsDropdown.TabIndex = 7
        '
        'MonkCheck
        '
        Me.MonkCheck.Location = New System.Drawing.Point(15, 75)
        Me.MonkCheck.Name = "MonkCheck"
        Me.MonkCheck.Size = New System.Drawing.Size(290, 21)
        Me.MonkCheck.TabIndex = 2
        Me.MonkCheck.Text = "Special Monk Weapon"
        '
        'FinesseCheck
        '
        Me.FinesseCheck.Enabled = False
        Me.FinesseCheck.Location = New System.Drawing.Point(15, 15)
        Me.FinesseCheck.Name = "FinesseCheck"
        Me.FinesseCheck.Size = New System.Drawing.Size(335, 21)
        Me.FinesseCheck.TabIndex = 0
        Me.FinesseCheck.Text = "Can Use Dexterity Modifier on Attack Rolls (Weapon Finesse)"
        '
        'ShadowsCheck
        '
        Me.ShadowsCheck.Enabled = False
        Me.ShadowsCheck.Location = New System.Drawing.Point(15, 185)
        Me.ShadowsCheck.Name = "ShadowsCheck"
        Me.ShadowsCheck.Size = New System.Drawing.Size(320, 21)
        Me.ShadowsCheck.TabIndex = 6
        Me.ShadowsCheck.Text = "Treat as this Weapon for Proficiency, Focus, Specialization"
        '
        'ChargeCheck
        '
        Me.ChargeCheck.Location = New System.Drawing.Point(15, 135)
        Me.ChargeCheck.Name = "ChargeCheck"
        Me.ChargeCheck.Size = New System.Drawing.Size(265, 21)
        Me.ChargeCheck.TabIndex = 4
        Me.ChargeCheck.Text = "Can Be Set Against a Charge (Double Damage)"
        '
        'TripCheck
        '
        Me.TripCheck.Location = New System.Drawing.Point(15, 105)
        Me.TripCheck.Name = "TripCheck"
        Me.TripCheck.Size = New System.Drawing.Size(260, 21)
        Me.TripCheck.TabIndex = 3
        Me.TripCheck.Text = "Can Make Trip Attacks or Ranged Trip Attacks"
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 170)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 130
        Me.IndentedLine3.TabStop = False
        '
        'FinesseStrength
        '
        Me.FinesseStrength.Enabled = False
        Me.FinesseStrength.Location = New System.Drawing.Point(35, 45)
        Me.FinesseStrength.Name = "FinesseStrength"
        Me.FinesseStrength.Size = New System.Drawing.Size(345, 21)
        Me.FinesseStrength.TabIndex = 1
        Me.FinesseStrength.Text = "1½ x Strength Bonus When Wielded Two-Handed"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PropertiesTab)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(407, 489)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 1
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 545)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 545)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'WeaponForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 583)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "WeaponForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WeaponForm"
        Me.TabControl1.ResumeLayout(False)
        Me.WeaponTab.ResumeLayout(False)
        CType(Me.Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsTab.ResumeLayout(False)
        CType(Me.Reach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StrengthBonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncumDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneHandedPenalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DamageTab.ResumeLayout(False)
        CType(Me.DJunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDamageDropdown2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDamageDropdown1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMultiplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThreatRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunctionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageDropdown2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageDropdown1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Multiplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DFDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DHDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DCDamage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdvancedTab.ResumeLayout(False)
        CType(Me.ShadowsDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'DataLists
    Private RaceDataList() As DataListItem
    Private WeaponsList() As DataListItem

    'init
    Public Sub Init()

        Try
            'Load DataLists
            RaceDataList = Rules.Index.DataList(Xml.DBTypes.Races, Objects.RaceType, True)

            'populate ComboBoxEditers
            TrainingDropdown.Properties.Items.AddRange(Rules.Lists.TrainingTypes)
            DamageDropdown1.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)
            DamageDropdown2.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)
            DDamageDropdown1.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)
            DDamageDropdown2.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)
            JunctionDropdown.Properties.Items.AddRange(Rules.Lists.JunctionTypes)
            DJunctionDropdown.Properties.Items.AddRange(Rules.Lists.JunctionTypes)

            'Custom Formatters
            Weight.Properties.DisplayFormat.Format = New Rules.WeightFormatter
            RangeSpin.Properties.DisplayFormat.Format = New Rules.FeetFormatter
            RangeSpin.Properties.EditFormat.Format = New Rules.FeetFormatter
            Reach.Properties.DisplayFormat.Format = New Rules.FeetFormatter
            Reach.Properties.EditFormat.Format = New Rules.FeetFormatter

            Cost.MaxGP = 9999

            'Init the properties tab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Weapons)

            'init object
            mObject.Type = Objects.WeaponDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Weapon"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            MeleeRadio.Checked = True
            Init()

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
            Me.Text = "Edit Weapon"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = Obj.Name
            If mObject.Element("Weight") = "-" Then
                Weight.Value = 0
            Else
                Weight.Value = CType(mObject.Element("Weight").Replace(" lb.", ""), Decimal)
            End If
            If mObject.Element("Cost") = "-" Then
                Cost.Value = ""
            Else
                Cost.Value = Obj.Element("Cost")
            End If
            TrainingDropdown.Text = Obj.Element("Training")
            If mObject.Element("Masterwork") = "Yes" Then Masterwork.Checked = True
            If mObject.Element("BaseItem") = "Yes" Then BaseItem.Checked = True

            If Obj.Element("WeaponType") = "Melee" Then
                MeleeRadio.Checked = True
                EncumDropdown.Text = mObject.Element("Encumbrance")
                If Obj.Element("Reach") = "Yes" Then
                    ReachCheck.CheckState = CheckState.Checked
                    'TODO - if statement dev only
                    If mObject.Element("ReachRange") <> "" Then
                        Reach.EditValue = CType(mObject.Element("ReachRange").Replace(" ft.", ""), Integer)
                    End If

                    If mObject.Element("ReachRestricted") = "Yes" Then ReachOnly.Checked = True
                End If

                If Obj.Element("Double") = "Yes" Then DoubleCheck.CheckState = CheckState.Checked
                If Obj.Element("MartialOneHanded") = "Yes" Then MartialOneHanded.Checked = True
            End If

            If Obj.Element("WeaponType") = "Ranged" Then
                RangedRadio.Checked = True
                EncumDropdown.Text = mObject.Element("Encumbrance")
                If Obj.Element("ApplyBonus") = "Yes" Then ApplyBonusCheck.CheckState = CheckState.Checked
                If mObject.Element("MaxStrengthBonus") <> "" Then
                    StrengthRating.Checked = True
                    StrengthBonus.Value = mObject.ElementAsInteger("MaxStrengthBonus")
                End If
                If Obj.Element("ApplyPenalty") = "Yes" Then ApplyPenaltyCheck.CheckState = CheckState.Checked
                If Obj.Element("Ammo") = "Yes" Then AmmoCheck.CheckState = CheckState.Checked
                If Obj.Element("FireOneHanded") = "Yes" Then
                    FireOneHanded.Checked = True
                    OneHandedPenalty.EditValue = Obj.ElementAsInteger("FireOneHandedPenalty")
                End If
                If Obj.Element("ImprovisedMelee") = "Yes" Then ImprovisedMelee.Checked = True Else ImprovisedMelee.Checked = False
            End If

            If Obj.Element("Thrown") = "Yes" Then ThrownCheck.CheckState = CheckState.Checked
            If Obj.Element("BucklerPenalty") = "Yes" Then BucklerPenalty.Checked = True

            If mObject.Element("RangeIncrement") = "-" Then
                RangeSpin.Value = 0
            Else
                RangeSpin.Value = mObject.ElementAsInteger("RangeIncrement")
            End If

            Dim LoadDamage As Boolean = True
            Select Case Obj.Element("Damage")
                Case "No Damage"
                    NoDamageRadio.Checked = True
                    LoadDamage = False
                Case "Non-Lethal"
                    NonLethalRadio.Checked = True
                Case "Lethal"
                    LethalRadio.Checked = True
            End Select

            If LoadDamage Then

                FDamage.Text = mObject.Element("FDamage")
                DDamage.Text = mObject.Element("DDamage")
                TDamage.Text = mObject.Element("TDamage")

                SDamage.Text = mObject.Element("SDamage")
                MDamage.Text = mObject.Element("MDamage")
                LDamage.Text = mObject.Element("LDamage")

                HDamage.Text = mObject.Element("HDamage")
                GDamage.Text = mObject.Element("GDamage")
                CDamage.Text = mObject.Element("CDamage")

                ThreatRange.Value = mObject.ElementAsInteger("ThreatRange")
                If ThreatRange.Value < ThreatRange.Properties.MinValue Then
                    ThreatRange.Value = ThreatRange.Properties.MaxValue
                End If

                Multiplier.Value = mObject.ElementAsInteger("Multiplier")
                If Multiplier.Value < Multiplier.Properties.MinValue Then
                    Multiplier.Value = Multiplier.Properties.MinValue
                End If

                DamageDropdown1.Text = mObject.Element("DamageType1")
                JunctionDropdown.Text = mObject.Element("Junction")
                DamageDropdown2.Text = mObject.Element("DamageType2")

                If DoubleCheck.Checked Then
                    DMultiplier.Value = mObject.ElementAsInteger("DMultiplier")
                    DFDamage.Text = mObject.Element("DFDamage")
                    DDDamage.Text = mObject.Element("DDDamage")
                    DTDamage.Text = mObject.Element("DTDamage")

                    DSDamage.Text = mObject.Element("DSDamage")
                    DMDamage.Text = mObject.Element("DMDamage")
                    DLDamage.Text = mObject.Element("DLDamage")

                    DHDamage.Text = mObject.Element("DHDamage")
                    DGDamage.Text = mObject.Element("DGDamage")
                    DCDamage.Text = mObject.Element("DCDamage")
                    DDamageDropdown1.Text = mObject.Element("DDamageType1")
                    DJunctionDropdown.Text = mObject.Element("DJunction")
                    DDamageDropdown2.Text = mObject.Element("DDamageType2")
                End If

            End If

            If Obj.Element("Trip") = "Yes" Then TripCheck.CheckState = CheckState.Checked
            If Obj.Element("Charge") = "Yes" Then ChargeCheck.CheckState = CheckState.Checked
            If Obj.Element("Finesse") = "Yes" Then FinesseCheck.CheckState = CheckState.Checked
            If Obj.Element("FinesseTwoHanded") = "Yes" Then FinesseStrength.Checked = True
            If Obj.Element("Monk") = "Yes" Then MonkCheck.CheckState = CheckState.Checked

            If Obj.Element("Shadows") <> "" Then
                ShadowsCheck.Checked = True
                ShadowsDropdown.SelectedIndex = Rules.Index.GetGuidIndex(WeaponsList, Obj.GetFKGuid("Shadows"))
            End If

            Description.Text = mObject.Element("Description")

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
                        'TODO - DEV ONLY
                        CharacterManager.SetAllDirty()
                        mObject.ClearElements()
                End Select

                'updates common to add and edit
                mObject.Name = ObjectName.Text
                If Weight.Value = 0 Then
                    mObject.Element("Weight") = "-"
                Else
                    mObject.Element("Weight") = Weight.Value.ToString & " lb."
                End If
                If Cost.Value Is Nothing Then
                    mObject.Element("Cost") = "-"
                Else
                    mObject.Element("Cost") = Cost.Value
                End If
                mObject.Element("Training") = TrainingDropdown.Text
                If RangeSpin.Value = 0 Then
                    mObject.Element("RangeIncrement") = "-"
                Else
                    mObject.Element("RangeIncrement") = RangeSpin.Value.ToString
                End If

                If Masterwork.Checked Then mObject.Element("Masterwork") = "Yes" Else mObject.Element("Masterwork") = ""
                If BaseItem.Checked Then mObject.Element("BaseItem") = "Yes" Else mObject.Element("BaseItem") = ""

                If MeleeRadio.Checked = True Then
                    mObject.Element("WeaponType") = "Melee"
                    mObject.Element("Encumbrance") = EncumDropdown.Text
                    If ReachCheck.CheckState = CheckState.Checked Then
                        mObject.Element("Reach") = "Yes"
                        mObject.Element("ReachRange") = Reach.Text
                        If ReachOnly.Checked Then mObject.Element("ReachRestricted") = "Yes" Else mObject.Element("ReachRestricted") = ""
                    Else
                        mObject.Element("Reach") = ""
                        mObject.Element("ReachRange") = ""
                        mObject.Element("ReachRestricted") = ""
                    End If

                    If DoubleCheck.CheckState = CheckState.Checked Then mObject.Element("Double") = "Yes" Else mObject.Element("Double") = ""
                    If MartialOneHanded.Checked Then mObject.Element("MartialOneHanded") = "Yes" Else mObject.Element("MartialOneHanded") = ""
                End If

                If RangedRadio.Checked = True Then
                    mObject.Element("WeaponType") = "Ranged"
                    mObject.Element("Encumbrance") = EncumDropdown.Text
                    If StrengthBonus.Properties.Enabled Then mObject.Element("MaxStrengthBonus") = StrengthBonus.Text Else mObject.Element("MaxStrengthBonus") = ""
                    If ApplyBonusCheck.CheckState = CheckState.Checked Then mObject.Element("ApplyBonus") = "Yes" Else mObject.Element("ApplyBonus") = ""
                    If ApplyPenaltyCheck.CheckState = CheckState.Checked Then mObject.Element("ApplyPenalty") = "Yes" Else mObject.Element("ApplyPenalty") = ""
                    If AmmoCheck.CheckState = CheckState.Checked Then mObject.Element("Ammo") = "Yes" Else mObject.Element("Ammo") = ""
                    If FireOneHanded.Checked Then
                        mObject.Element("FireOneHanded") = "Yes"
                        mObject.Element("FireOneHandedPenalty") = OneHandedPenalty.Text
                    Else
                        mObject.Element("FireOneHanded") = ""
                        mObject.Element("FireOneHandedPenalty") = "0"
                    End If
                    If ImprovisedMelee.Checked Then mObject.Element("ImprovisedMelee") = "Yes" Else mObject.Element("ImprovisedMelee") = ""
                End If

                If ThrownCheck.CheckState = CheckState.Checked Then mObject.Element("Thrown") = "Yes" Else mObject.Element("Thrown") = ""
                If BucklerPenalty.Checked Then mObject.Element("BucklerPenalty") = "Yes" Else mObject.Element("BucklerPenalty") = ""

                If Not NoDamageRadio.Checked Then
                    If LethalRadio.Checked Then
                        mObject.Element("Damage") = "Lethal"
                    Else
                        mObject.Element("Damage") = "Non-Lethal"
                    End If
                    mObject.Element("FDamage") = FDamage.Text
                    mObject.Element("DDamage") = DDamage.Text
                    mObject.Element("TDamage") = TDamage.Text

                    mObject.Element("MDamage") = MDamage.Text
                    mObject.Element("SDamage") = SDamage.Text
                    mObject.Element("LDamage") = LDamage.Text

                    mObject.Element("HDamage") = HDamage.Text
                    mObject.Element("GDamage") = GDamage.Text
                    mObject.Element("CDamage") = CDamage.Text

                    mObject.Element("ThreatRange") = ThreatRange.Value.ToString
                    mObject.Element("Multiplier") = Multiplier.Value.ToString

                    mObject.Element("DamageType1") = DamageDropdown1.Text

                    If DamageDropdown2.Text <> "" Then
                        mObject.Element("Junction") = JunctionDropdown.Text
                        mObject.Element("DamageType2") = DamageDropdown2.Text
                        mObject.Element("DamageType") = DamageDropdown1.Text & " " & JunctionDropdown.Text & " " & DamageDropdown2.Text
                    Else
                        mObject.Element("Junction") = ""
                        mObject.Element("DamageType2") = ""
                        mObject.Element("DamageType") = DamageDropdown1.Text
                    End If

                    mObject.Element("DFDamage") = DFDamage.Text
                    mObject.Element("DDDamage") = DDDamage.Text
                    mObject.Element("DTDamage") = DTDamage.Text

                    mObject.Element("DMDamage") = DMDamage.Text
                    mObject.Element("DSDamage") = DSDamage.Text
                    mObject.Element("DLDamage") = DLDamage.Text

                    mObject.Element("DHDamage") = DHDamage.Text
                    mObject.Element("DGDamage") = DGDamage.Text
                    mObject.Element("DCDamage") = DCDamage.Text

                    mObject.Element("DDamageType1") = DDamageDropdown1.Text

                    If DDamageDropdown2.Text <> "" Then
                        mObject.Element("DJunction") = DJunctionDropdown.Text
                        mObject.Element("DDamageType2") = DDamageDropdown2.Text
                        mObject.Element("DamageType") &= "/" & DDamageDropdown1.Text & " " & DJunctionDropdown.Text & " " & DDamageDropdown2.Text
                    Else
                        mObject.Element("DJunction") = ""
                        mObject.Element("DDamageType2") = ""
                        If DoubleCheck.Checked Then mObject.Element("DamageType") &= "/" & DDamageDropdown1.Text
                    End If

                    'combined crit string
                    If ThreatRange.Value = 20 Then
                        mObject.Element("Critical") = "x" & Multiplier.Value.ToString
                    Else
                        mObject.Element("Critical") = ThreatRange.Value.ToString & "-20/x" & Multiplier.Value.ToString
                    End If

                    'second head multiplier
                    If DMultiplier.Properties.Enabled = True Then
                        mObject.Element("DMultiplier") = DMultiplier.Value.ToString
                        mObject.Element("Critical") &= "/x" & DMultiplier.Value.ToString
                    End If

                    'combined damage
                    If DFDamage.Text = "" Then
                        mObject.Element("DamageFine") = FDamage.Text
                    Else
                        mObject.Element("DamageFine") = FDamage.Text & "/" & DFDamage.Text
                    End If

                    If DDDamage.Text = "" Then
                        mObject.Element("DamageDiminutive") = DDamage.Text
                    Else
                        mObject.Element("DamageDiminutive") = DDamage.Text & "/" & DDDamage.Text
                    End If

                    If DTDamage.Text = "" Then
                        mObject.Element("DamageTiny") = TDamage.Text
                    Else
                        mObject.Element("DamageTiny") = TDamage.Text & "/" & DTDamage.Text
                    End If

                    If DSDamage.Text = "" Then
                        mObject.Element("DamageSmall") = SDamage.Text
                    Else
                        mObject.Element("DamageSmall") = SDamage.Text & "/" & DSDamage.Text
                    End If

                    If DMDamage.Text = "" Then
                        mObject.Element("DamageMedium") = MDamage.Text
                    Else
                        mObject.Element("DamageMedium") = MDamage.Text & "/" & DMDamage.Text
                    End If

                    If DLDamage.Text = "" Then
                        mObject.Element("DamageLarge") = LDamage.Text
                    Else
                        mObject.Element("DamageLarge") = LDamage.Text & "/" & DLDamage.Text
                    End If

                    If DHDamage.Text = "" Then
                        mObject.Element("DamageHuge") = HDamage.Text
                    Else
                        mObject.Element("DamageHuge") = HDamage.Text & "/" & DHDamage.Text
                    End If

                    If DGDamage.Text = "" Then
                        mObject.Element("DamageGargantuan") = GDamage.Text
                    Else
                        mObject.Element("DamageGargantuan") = GDamage.Text & "/" & DGDamage.Text
                    End If

                    If DCDamage.Text = "" Then
                        mObject.Element("DamageColossal") = CDamage.Text
                    Else
                        mObject.Element("DamageColossal") = CDamage.Text & "/" & DCDamage.Text
                    End If

                Else
                    mObject.Element("Damage") = "No Damage"
                End If

                'misc
                If TripCheck.CheckState = CheckState.Checked Then mObject.Element("Trip") = "Yes" Else mObject.Element("Trip") = ""
                If ChargeCheck.CheckState = CheckState.Checked Then mObject.Element("Charge") = "Yes" Else mObject.Element("Charge") = ""
                If FinesseCheck.CheckState = CheckState.Checked Then mObject.Element("Finesse") = "Yes" Else mObject.Element("Finesse") = ""
                If FinesseStrength.Checked Then mObject.Element("FinesseTwoHanded") = "Yes" Else mObject.Element("FinesseTwoHanded") = ""
                If MonkCheck.CheckState = CheckState.Checked Then mObject.Element("Monk") = "Yes" Else mObject.Element("Monk") = ""

                If ShadowsCheck.Checked Then
                    mObject.FKElement("Shadows", ShadowsDropdown.Text, "Name", CType(ShadowsDropdown.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.FKSetNull("Shadows")
                End If

                mObject.Element("Description") = Description.Text
                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)

                General.MainExplorer.RefreshPanel()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    General.MainExplorer.RefreshRenamedNode(mObject.ObjectGUID, mObject.Name)
                End If

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
            Validate = General.ValidateForm(Me.WeaponTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.DetailsTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.DamageTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.AdvancedTab.Controls, Errors)

            If RangeSpin.Properties.Enabled AndAlso (RangeSpin.Value = 0) Then
                Errors.SetError(RangeSpin, General.ValidationPositiveWholeNumber)
                Validate = False
            Else
                Errors.SetError(RangeSpin, "")
            End If


            If FDamage.Text <> "" Then
                If ValidNumberDiceRange(FDamage) Then
                    Errors.SetError(FDamage, "")
                Else
                    Errors.SetError(FDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DFDamage.Text <> "" Then
                    Errors.SetError(FDamage, ValidationRequired)
                    Validate = False
                Else
                    Errors.SetError(FDamage, "")
                End If
            End If

            If DDamage.Text <> "" Then
                If ValidNumberDiceRange(DDamage) Then
                    Errors.SetError(DDamage, "")
                Else
                    Errors.SetError(DDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DDDamage.Text <> "" Then
                    Errors.SetError(DDamage, ValidationRequired)
                    Validate = False
                Else
                    Errors.SetError(DDamage, "")
                End If
            End If

            If TDamage.Text <> "" Then
                If ValidNumberDiceRange(TDamage) Then
                    Errors.SetError(TDamage, "")
                Else
                    Errors.SetError(TDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DTDamage.Text <> "" Then
                    Errors.SetError(TDamage, ValidationRequired)
                    Validate = False
                Else
                    Errors.SetError(TDamage, "")
                End If
            End If


            'If (TDamage.Text <> "" AndAlso ValidNumberDiceRange(TDamage)) OrElse (TDamage.Text = "" AndAlso DTDamage.Text = "") Then
            '    Errors.SetError(TDamage, "")
            'Else
            '    Errors.SetError(TDamage, ValidationPWNumberOrDiceRangeOrEmpty)
            '    Validate = False
            'End If


            If (LDamage.Properties.Enabled = False) OrElse ((LDamage.Text <> "") AndAlso ValidNumberDiceRange(LDamage)) Then
                Errors.SetError(LDamage, "")
            Else
                Errors.SetError(LDamage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If

            If (MDamage.Properties.Enabled = False) OrElse ((MDamage.Text <> "") AndAlso ValidNumberDiceRange(MDamage)) Then
                Errors.SetError(MDamage, "")
            Else
                Errors.SetError(MDamage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If

            If (SDamage.Properties.Enabled = False) OrElse ((SDamage.Text <> "") AndAlso ValidNumberDiceRange(SDamage)) Then
                Errors.SetError(SDamage, "")
            Else
                Errors.SetError(SDamage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If


            If HDamage.Text <> "" Then
                If ValidNumberDiceRange(HDamage) Then
                    Errors.SetError(HDamage, "")
                Else
                    Errors.SetError(HDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DHDamage.Text <> "" Then
                    Errors.SetError(HDamage, ValidationRequired)
                    Validate = False
                Else
                    Errors.SetError(HDamage, "")
                End If
            End If

            If GDamage.Text <> "" Then
                If ValidNumberDiceRange(GDamage) Then
                    Errors.SetError(GDamage, "")
                Else
                    Errors.SetError(GDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DGDamage.Text <> "" Then
                    Errors.SetError(GDamage, ValidationRequired)
                    Validate = False
                Else
                    Errors.SetError(GDamage, "")
                End If
            End If

            If CDamage.Text <> "" Then
                If ValidNumberDiceRange(CDamage) Then
                    Errors.SetError(CDamage, "")
                Else
                    Errors.SetError(CDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DCDamage.Text <> "" Then
                    Errors.SetError(CDamage, ValidationRequired)
                    Validate = False
                Else
                    Errors.SetError(CDamage, "")
                End If
            End If

            ' Double Weapon
            If DFDamage.Text <> "" Then
                If ValidNumberDiceRange(DFDamage) Then
                    Errors.SetError(DFDamage, "")
                Else
                    Errors.SetError(DFDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DFDamage.Enabled = True Then
                    If FDamage.Text <> "" Then
                        Errors.SetError(DFDamage, ValidationRequired)
                        Validate = False
                    Else
                        Errors.SetError(DFDamage, "")
                    End If
                Else
                    Errors.SetError(DFDamage, "")
                End If
            End If

            If DDDamage.Text <> "" Then
                If ValidNumberDiceRange(DDDamage) Then
                    Errors.SetError(DDDamage, "")
                Else
                    Errors.SetError(DDDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DDDamage.Enabled = True Then
                    If DDamage.Text <> "" Then
                        Errors.SetError(DDDamage, ValidationRequired)
                        Validate = False
                    Else
                        Errors.SetError(DDDamage, "")
                    End If
                Else
                    Errors.SetError(DDDamage, "")
                End If
            End If

            If DTDamage.Text <> "" Then
                If ValidNumberDiceRange(DTDamage) Then
                    Errors.SetError(DTDamage, "")
                Else
                    Errors.SetError(DTDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DTDamage.Enabled = True Then
                    If TDamage.Text <> "" Then
                        Errors.SetError(DTDamage, ValidationRequired)
                        Validate = False
                    Else
                        Errors.SetError(DTDamage, "")
                    End If
                Else
                    Errors.SetError(DTDamage, "")
                End If
            End If


            If (DLDamage.Properties.Enabled = False) OrElse ((DLDamage.Text <> "") AndAlso ValidNumberDiceRange(DLDamage)) Then
                Errors.SetError(DLDamage, "")
            Else
                Errors.SetError(DLDamage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If

            If (DMDamage.Properties.Enabled = False) OrElse ((DMDamage.Text <> "") AndAlso ValidNumberDiceRange(DMDamage)) Then
                Errors.SetError(DMDamage, "")
            Else
                Errors.SetError(DMDamage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If

            If (DSDamage.Properties.Enabled = False) OrElse ((DSDamage.Text <> "") AndAlso ValidNumberDiceRange(DSDamage)) Then
                Errors.SetError(DSDamage, "")
            Else
                Errors.SetError(DSDamage, ValidationPWNumberOrDiceRange)
                Validate = False
            End If


            If DHDamage.Text <> "" Then
                If ValidNumberDiceRange(DHDamage) Then
                    Errors.SetError(DHDamage, "")
                Else
                    Errors.SetError(DHDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DHDamage.Enabled = True Then
                    If HDamage.Text <> "" Then
                        Errors.SetError(DHDamage, ValidationRequired)
                        Validate = False
                    Else
                        Errors.SetError(DHDamage, "")
                    End If
                Else
                    Errors.SetError(DHDamage, "")
                End If
            End If

            If DGDamage.Text <> "" Then
                If ValidNumberDiceRange(DGDamage) Then
                    Errors.SetError(DGDamage, "")
                Else
                    Errors.SetError(DGDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DGDamage.Enabled = True Then
                    If GDamage.Text <> "" Then
                        Errors.SetError(DGDamage, ValidationRequired)
                        Validate = False
                    Else
                        Errors.SetError(DGDamage, "")
                    End If
                Else
                    Errors.SetError(DGDamage, "")
                End If
            End If

            If DCDamage.Text <> "" Then
                If ValidNumberDiceRange(DCDamage) Then
                    Errors.SetError(DCDamage, "")
                Else
                    Errors.SetError(DCDamage, ValidationPWNumberOrDiceRangeOrEmpty)
                    Validate = False
                End If
            Else
                If DCDamage.Enabled = True Then
                    If CDamage.Text <> "" Then
                        Errors.SetError(DCDamage, ValidationRequired)
                        Validate = False
                    Else
                        Errors.SetError(DCDamage, "")
                    End If
                Else
                    Errors.SetError(DCDamage, "")
                End If
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

#End Region

#Region "Control Enabling and Disabling"

    'enable/disable the racial weapons controls (i.e Dwarven Hammers)
    Private Sub TrainingDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingDropdown.SelectedIndexChanged
        Dim Exclusions As New ArrayList

        Try
            'bastard swords et al
            If EncumDropdown.Text = "One-Handed" And TrainingDropdown.Text = "Exotic" Then
                MartialOneHanded.Enabled = True
            Else
                MartialOneHanded.Enabled = False
                MartialOneHanded.Checked = False
            End If

            'shadows
            ShadowsCheck.Enabled = True
            ShadowsDropdown.SelectedIndex = -1
            ShadowsDropdown.Properties.Items.Clear()
            Exclusions.Add(mObject.ObjectGUID)
            WeaponsList = Rules.Index.DataListXPathExclude(Xml.DBTypes.Weapons, "/RPGXplorerDatabase/RPGXplorerObject[Type='" & Objects.WeaponDefinitionType & "' and Shadows='' and BaseItem='' and Training='" & TrainingDropdown.Text & "']", Exclusions)
            If Not WeaponsList Is Nothing Then ShadowsDropdown.Properties.Items.AddRange(WeaponsList)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable range controls if weapon is thrown
    Private Sub ThrownCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThrownCheck.CheckedChanged
        Try
            If MeleeRadio.Checked Then
                RangeSpin.Value = 0
                If ThrownCheck.CheckState = CheckState.Checked Then
                    RangeLabel.Enabled = True
                    RangeSpin.Properties.Enabled = True
                Else
                    RangeLabel.Enabled = False
                    RangeSpin.Properties.Enabled = False
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable the double weapon damage options
    Private Sub DoubleCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoubleCheck.CheckedChanged
        Try
            If DoubleCheck.CheckState = CheckState.Checked Then
                EnableDoubleWeaponControls(True)
            Else
                EnableDoubleWeaponControls(False)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable the melee weapon controls
    Private Sub MeleeRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeleeRadio.CheckedChanged
        Try
            If MeleeRadio.Checked = True Then
                EnableRangedControls(False)
                EnableMeleeControls(True)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable the ranged weapon controls
    Private Sub RangedRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangedRadio.CheckedChanged
        Try
            If RangedRadio.Checked = True Then
                EnableMeleeControls(False)
                EnableRangedControls(True)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable the JunctionDropdown control once a damage type is selected
    Private Sub DamageDropdown1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageDropdown1.SelectedIndexChanged
        Try
            DamageDropdown2.Properties.Items.Clear()
            DamageDropdown2.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)

            If DamageDropdown1.Text <> "" And DamageDropdown1.Text <> DamageDropdown2.Text Then
                JunctionDropdown.Properties.Enabled = True
                DamageDropdown2.Properties.Items.Remove(DamageDropdown1.SelectedItem)
            ElseIf DamageDropdown1.Text = DamageDropdown2.Text And Not DamageDropdown1.SelectedIndex = -1 Then
                JunctionDropdown.Properties.Enabled = True
                JunctionDropdown.SelectedIndex = -1
                DamageDropdown2.Properties.Items.Remove(DamageDropdown1.SelectedItem)
            Else
                JunctionDropdown.Properties.Enabled = False
                JunctionDropdown.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable the DamageDropdown2 control if a non-null option is selected
    Private Sub JunctionDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JunctionDropdown.SelectedIndexChanged
        Try
            If JunctionDropdown.Text <> "" Then
                DamageDropdown2.Properties.Enabled = True
            Else
                DamageDropdown2.Properties.Enabled = False
                DamageDropdown2.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable the DJunctionDropdown control once a damage type is selected
    Private Sub DDamageDropdown1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDamageDropdown1.SelectedIndexChanged
        Try
            DDamageDropdown2.Properties.Items.Clear()
            DDamageDropdown2.Properties.Items.AddRange(Rules.Lists.WeaponDamageTypes)

            If DDamageDropdown1.Text <> "" And DDamageDropdown1.Text <> DDamageDropdown2.Text Then
                DJunctionDropdown.Properties.Enabled = True
                DDamageDropdown2.Properties.Items.Remove(DDamageDropdown1.SelectedItem)
            ElseIf DDamageDropdown1.Text = DDamageDropdown2.Text And Not DDamageDropdown1.SelectedIndex = -1 Then
                DJunctionDropdown.Properties.Enabled = True
                DJunctionDropdown.SelectedIndex = -1
                DDamageDropdown2.Properties.Items.Remove(DDamageDropdown1.SelectedItem)
            Else
                DJunctionDropdown.Properties.Enabled = False
                DJunctionDropdown.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable the DDamageDropdown2 control if a non-null option is selected
    Private Sub DJunctionDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DJunctionDropdown.SelectedIndexChanged
        Try
            If DJunctionDropdown.Text <> "" Then
                DDamageDropdown2.Properties.Enabled = True
            Else
                DDamageDropdown2.Properties.Enabled = False
                DDamageDropdown2.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable the Strength bonus SpinEdit for Ranged Weapons
    Private Sub ApplyBonusCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyBonusCheck.CheckedChanged
        Try
            StrengthRating.Checked = False
            If ApplyBonusCheck.CheckState = CheckState.Checked Then
                StrengthRating.Enabled = True
            Else
                StrengthRating.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'called by RangedRadio_CheckedChanged and MeleeRadio_CheckedChanged to enable or disable melee controls
    Private Sub EnableMeleeControls(ByVal value As Boolean)
        Try
            'Reset Controls
            EncumDropdown.Properties.Items.Clear()
            EncumDropdown.SelectedIndex = -1
            EncumDropdown.Properties.Items.AddRange(Rules.Lists.EncumbranceTypes)
            ReachCheck.CheckState = CheckState.Unchecked
            DoubleCheck.CheckState = CheckState.Unchecked
            'ThrownCheck.CheckState = CheckState.Unchecked
            FinesseCheck.Checked = False
            ChargeCheck.Checked = False

            'Enable/Disable controls
            ReachCheck.Enabled = value
            If value = False Then DoubleCheck.Enabled = value
            FinesseCheck.Enabled = False
            'ThrownCheck.Enabled = value
            ChargeCheck.Enabled = value
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'called by RangedRadio_CheckedChanged and MeleeRadio_CheckedChanged to enable or disable ranged controls
    Private Sub EnableRangedControls(ByVal value As Boolean)
        Try
            EncumDropdown.Properties.Items.Clear()
            EncumDropdown.SelectedIndex = -1
            EncumDropdown.Properties.Items.AddRange(Rules.Lists.MissileEncumberanceTypes)

            'Enable/Disable controls        
            RangeLabel.Enabled = value
            RangeSpin.Properties.Enabled = value
            ApplyBonusCheck.Enabled = value
            ApplyPenaltyCheck.Enabled = value
            AmmoCheck.Enabled = value
            ImprovisedMelee.Enabled = value

            FireOneHanded.Enabled = False
            OneHandedPenalty.Enabled = False

            'Reset Controls
            ApplyBonusCheck.CheckState = CheckState.Unchecked
            ApplyPenaltyCheck.CheckState = CheckState.Unchecked
            AmmoCheck.CheckState = CheckState.Unchecked
            RangeSpin.Value = 0
            OneHandedPenalty.Value = 0
            FireOneHanded.Checked = False
            ImprovisedMelee.Checked = False
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enable/disable damage controls
    Private Sub EnableDamageControls(ByVal value As Boolean)
        Try
            FDamage.Properties.Enabled = value
            DDamage.Properties.Enabled = value
            TDamage.Properties.Enabled = value

            LDamage.Properties.Enabled = value
            MDamage.Properties.Enabled = value
            SDamage.Properties.Enabled = value

            HDamage.Properties.Enabled = value
            GDamage.Properties.Enabled = value
            CDamage.Properties.Enabled = value

            DivideLabel.Enabled = value
            ThreatRange.Properties.Enabled = value
            Multiplier.Properties.Enabled = value
            DamageDropdown1.Properties.Enabled = value

            FDamage.Text = ""
            DDamage.Text = ""
            TDamage.Text = ""

            LDamage.Text = ""
            MDamage.Text = ""
            SDamage.Text = ""

            HDamage.Text = ""
            GDamage.Text = ""
            CDamage.Text = ""

            Multiplier.Value = 2
            DamageDropdown1.SelectedIndex = -1
            JunctionDropdown.SelectedIndex = -1
            DamageDropdown2.SelectedIndex = -1

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'called by DoubleCheck_CheckedChanged to enable or disable Double controls
    Private Sub EnableDoubleWeaponControls(ByVal value As Boolean)
        Try
            Label3.Enabled = value

            DFDamage.Properties.Enabled = value
            DDDamage.Properties.Enabled = value
            DTDamage.Properties.Enabled = value

            DLDamage.Properties.Enabled = value
            DMDamage.Properties.Enabled = value
            DSDamage.Properties.Enabled = value

            DHDamage.Properties.Enabled = value
            DGDamage.Properties.Enabled = value
            DCDamage.Properties.Enabled = value

            DMultiplier.Properties.Enabled = value
            DDamageDropdown1.Properties.Enabled = value

            DFDamage.Text = ""
            DDDamage.Text = ""
            DTDamage.Text = ""

            DLDamage.Text = ""
            DMDamage.Text = ""
            DSDamage.Text = ""

            DHDamage.Text = ""
            DGDamage.Text = ""
            DCDamage.Text = ""

            DMultiplier.Value = 2
            DDamageDropdown1.SelectedIndex = -1
            DJunctionDropdown.SelectedIndex = -1
            DDamageDropdown2.SelectedIndex = -1
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ShadowsCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShadowsCheck.CheckedChanged
        Dim Exclusions As New ArrayList

        Try
            If ShadowsCheck.Checked Then
                ShadowsDropdown.Properties.Enabled = True
            Else
                ShadowsDropdown.Properties.Enabled = False
                ShadowsDropdown.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ReachCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReachCheck.CheckedChanged
        Try
            If ReachCheck.Checked Then
                ReachOnly.Enabled = True
                Reach.Properties.Enabled = True
            Else
                ReachOnly.Enabled = False
                ReachOnly.Checked = False
                Reach.Properties.Enabled = False
                Reach.EditValue = 10
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub EncumDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncumDropdown.SelectedIndexChanged
        Try
            If MeleeRadio.Checked Then
                If EncumDropdown.Text = "One-Handed" And TrainingDropdown.Text = "Exotic" Then
                    MartialOneHanded.Enabled = True
                Else
                    MartialOneHanded.Enabled = False
                    MartialOneHanded.Checked = False
                End If

                If EncumDropdown.Text = "Two-Handed" Then
                    FinesseStrength.Enabled = False
                    FinesseStrength.Checked = False
                    DoubleCheck.Enabled = True
                Else
                    DoubleCheck.Enabled = False
                    DoubleCheck.Checked = False
                End If

                If EncumDropdown.Text = "One-Handed" Or EncumDropdown.Text = "Two-Handed" Then
                    FinesseCheck.Enabled = True

                    If EncumDropdown.Text = "One-Handed" And FinesseCheck.Checked = True Then
                        FinesseStrength.Enabled = True
                    End If
                Else
                    FinesseCheck.Enabled = False
                    FinesseCheck.Checked = False
                End If

                ThrownCheck.Enabled = True

            Else

                Select Case EncumDropdown.Text
                    Case "One-Handed", "Two-Handed Only"
                        FireOneHanded.Enabled = False
                        FireOneHanded.Checked = False
                        PenaltyLabel.Enabled = False
                        OneHandedPenalty.Properties.Enabled = False
                        OneHandedPenalty.EditValue = 0
                        ApplyBonusCheck.Enabled = True
                        ApplyPenaltyCheck.Enabled = True
                        ThrownCheck.Enabled = True
                    Case Else
                        FireOneHanded.Enabled = True
                        FireOneHanded.Checked = True
                        PenaltyLabel.Enabled = True
                        OneHandedPenalty.Properties.Enabled = True
                        ThrownCheck.CheckState = CheckState.Unchecked
                        ThrownCheck.Enabled = False
                End Select

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DamageTypeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LethalRadio.CheckedChanged, NonLethalRadio.CheckedChanged, NoDamageRadio.CheckedChanged
        Try
            If LethalRadio.Checked Or NonLethalRadio.Checked Then
                EnableDamageControls(True)
                If DoubleCheck.Checked Then EnableDoubleWeaponControls(True)
            Else
                EnableDamageControls(False)
                EnableDoubleWeaponControls(False)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub StrengthRating_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrengthRating.CheckedChanged
        Try
            If StrengthRating.Checked Then
                StrengthBonus.Properties.Enabled = True
            Else
                StrengthBonus.Properties.Enabled = False
                StrengthBonus.EditValue = 1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FinesseCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinesseCheck.CheckedChanged
        Try
            If FinesseCheck.Checked Then
                If EncumDropdown.Text = "One-Handed" Then
                    FinesseStrength.Enabled = True
                End If
            Else
                FinesseStrength.Enabled = False
                FinesseStrength.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub FireOneHanded_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FireOneHanded.CheckedChanged
        Try

            If FireOneHanded.Enabled And FireOneHanded.Checked = False Then
                FireOneHanded.Checked = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Formatting"

    'overrides the formatting on the ThreatRange control when value is 20
    Private Sub ThreatRange_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreatRange.EditValueChanged
        Try
            If ThreatRange.Value = 20 Then
                ThreatRange.Text = "20"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class




