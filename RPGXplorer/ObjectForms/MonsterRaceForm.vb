Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules.Dice

Public Class MonsterRaceForm
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
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents RaceSize As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Basics As System.Windows.Forms.TabPage
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents RaceTabControl As System.Windows.Forms.TabControl
    Public WithEvents Speed As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents NA As RPGXplorer.Modifier
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents ManeuverDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Climb As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Burrow As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Swim As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Fly As DevExpress.XtraEditors.SpinEdit
    Public WithEvents CON As DevExpress.XtraEditors.SpinEdit
    Public WithEvents CHA As DevExpress.XtraEditors.SpinEdit
    Public WithEvents WIS As DevExpress.XtraEditors.SpinEdit
    Public WithEvents STR As DevExpress.XtraEditors.SpinEdit
    Public WithEvents DEX As DevExpress.XtraEditors.SpinEdit
    Public WithEvents INT As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SkillsTab As System.Windows.Forms.TabPage
    Public WithEvents TypeLabel As System.Windows.Forms.Label
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents LevelListBox As RPGXplorer.ListBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents SkillDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Ranks As DevExpress.XtraEditors.SpinEdit
    Public WithEvents RemoveSkill As System.Windows.Forms.Button
    Public WithEvents AddSkill As System.Windows.Forms.Button
    Public WithEvents CompanionTab As System.Windows.Forms.TabPage
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents HD As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MountDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents CompanionDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents MountCheck As System.Windows.Forms.CheckBox
    Public WithEvents CompanionCheck As System.Windows.Forms.CheckBox
    Public WithEvents FamiliarCheck As System.Windows.Forms.CheckBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents FamiliarDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Reach As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Space As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents TypeTab As System.Windows.Forms.TabPage
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents SubtypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SubtypeList As RPGXplorer.ListBox
    Public WithEvents RemoveSubtype As System.Windows.Forms.Button
    Public WithEvents AddSubtype As System.Windows.Forms.Button
    Public WithEvents TypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents WeaponsTab As System.Windows.Forms.TabPage
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents WeaponDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents WeaponsList As RPGXplorer.ListBox
    Public WithEvents RemoveWeapon As System.Windows.Forms.Button
    Public WithEvents AddWeapon As System.Windows.Forms.Button
    Public WithEvents ChaoticEvil As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticNeutral As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticGood As System.Windows.Forms.CheckBox
    Public WithEvents NeutralEvil As System.Windows.Forms.CheckBox
    Public WithEvents TrueNeutral As System.Windows.Forms.CheckBox
    Public WithEvents NeutralGood As System.Windows.Forms.CheckBox
    Public WithEvents LawfulEvil As System.Windows.Forms.CheckBox
    Public WithEvents LawfulNeutral As System.Windows.Forms.CheckBox
    Public WithEvents LawfulGood As System.Windows.Forms.CheckBox
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents IndentedLine7 As RPGXplorer.IndentedLine
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents IndentedLine6 As RPGXplorer.IndentedLine
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents QuadCheck As System.Windows.Forms.CheckBox
    Public WithEvents NonhumanoidCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine10 As RPGXplorer.IndentedLine
    Public WithEvents CR As DevExpress.XtraEditors.SpinEdit
    Public WithEvents LA As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Advancement As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Treasure As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Organization As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents NormalMountCheck As System.Windows.Forms.CheckBox
    Public WithEvents CasterTab As System.Windows.Forms.TabPage
    Public WithEvents CasterType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents CasterLabel As System.Windows.Forms.Label
    Public WithEvents SourceBox As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents CasterLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents RemoveSource As System.Windows.Forms.Button
    Public WithEvents AddSource As System.Windows.Forms.Button
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents SpellSourceDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SourcesList As RPGXplorer.ListBox
    Public WithEvents IndentedLine8 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine9 As RPGXplorer.IndentedLine
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents LanguageTab As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine11 As RPGXplorer.IndentedLine
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents RemoveBonus As System.Windows.Forms.Button
    Public WithEvents AddBonus As System.Windows.Forms.Button
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents RemoveAutomatic As System.Windows.Forms.Button
    Public WithEvents AddAutomatic As System.Windows.Forms.Button
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Languages As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents BonusLanguages As RPGXplorer.ListBox
    Public WithEvents AutomaticLanguages As RPGXplorer.ListBox
    Public WithEvents FeatCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine12 As RPGXplorer.IndentedLine
    Public WithEvents Environment As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Speed = New DevExpress.XtraEditors.SpinEdit
        Me.OK = New System.Windows.Forms.Button
        Me.Climb = New DevExpress.XtraEditors.SpinEdit
        Me.Burrow = New DevExpress.XtraEditors.SpinEdit
        Me.Swim = New DevExpress.XtraEditors.SpinEdit
        Me.Fly = New DevExpress.XtraEditors.SpinEdit
        Me.HD = New DevExpress.XtraEditors.SpinEdit
        Me.Reach = New DevExpress.XtraEditors.SpinEdit
        Me.Space = New DevExpress.XtraEditors.SpinEdit
        Me.CR = New DevExpress.XtraEditors.SpinEdit
        Me.LA = New DevExpress.XtraEditors.SpinEdit
        Me.Cancel = New System.Windows.Forms.Button
        Me.RaceTabControl = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.IndentedLine7 = New RPGXplorer.IndentedLine
        Me.ChaoticEvil = New System.Windows.Forms.CheckBox
        Me.ChaoticNeutral = New System.Windows.Forms.CheckBox
        Me.ChaoticGood = New System.Windows.Forms.CheckBox
        Me.NeutralEvil = New System.Windows.Forms.CheckBox
        Me.TrueNeutral = New System.Windows.Forms.CheckBox
        Me.NeutralGood = New System.Windows.Forms.CheckBox
        Me.LawfulEvil = New System.Windows.Forms.CheckBox
        Me.LawfulNeutral = New System.Windows.Forms.CheckBox
        Me.LawfulGood = New System.Windows.Forms.CheckBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label15 = New System.Windows.Forms.Label
        Me.CON = New DevExpress.XtraEditors.SpinEdit
        Me.CHA = New DevExpress.XtraEditors.SpinEdit
        Me.WIS = New DevExpress.XtraEditors.SpinEdit
        Me.STR = New DevExpress.XtraEditors.SpinEdit
        Me.DEX = New DevExpress.XtraEditors.SpinEdit
        Me.INT = New DevExpress.XtraEditors.SpinEdit
        Me.ManeuverDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NA = New RPGXplorer.Modifier
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.RaceSize = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.ObjectName = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.TypeTab = New System.Windows.Forms.TabPage
        Me.FeatCheck = New System.Windows.Forms.CheckBox
        Me.IndentedLine12 = New RPGXplorer.IndentedLine
        Me.QuadCheck = New System.Windows.Forms.CheckBox
        Me.NonhumanoidCheck = New System.Windows.Forms.CheckBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Advancement = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Treasure = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.Organization = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.Environment = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SubtypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.RemoveSubtype = New System.Windows.Forms.Button
        Me.AddSubtype = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.TypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine10 = New RPGXplorer.IndentedLine
        Me.IndentedLine6 = New RPGXplorer.IndentedLine
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.SubtypeList = New RPGXplorer.ListBox
        Me.WeaponsTab = New System.Windows.Forms.TabPage
        Me.WeaponDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.RemoveWeapon = New System.Windows.Forms.Button
        Me.AddWeapon = New System.Windows.Forms.Button
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.WeaponsList = New RPGXplorer.ListBox
        Me.SkillsTab = New System.Windows.Forms.TabPage
        Me.TypeLabel = New System.Windows.Forms.Label
        Me.SkillDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Ranks = New DevExpress.XtraEditors.SpinEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.RemoveSkill = New System.Windows.Forms.Button
        Me.AddSkill = New System.Windows.Forms.Button
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.LevelListBox = New RPGXplorer.ListBox
        Me.LanguageTab = New System.Windows.Forms.TabPage
        Me.IndentedLine11 = New RPGXplorer.IndentedLine
        Me.Label35 = New System.Windows.Forms.Label
        Me.RemoveBonus = New System.Windows.Forms.Button
        Me.AddBonus = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.RemoveAutomatic = New System.Windows.Forms.Button
        Me.AddAutomatic = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.Languages = New DevExpress.XtraEditors.ComboBoxEdit
        Me.BonusLanguages = New RPGXplorer.ListBox
        Me.AutomaticLanguages = New RPGXplorer.ListBox
        Me.CasterTab = New System.Windows.Forms.TabPage
        Me.Label33 = New System.Windows.Forms.Label
        Me.RemoveSource = New System.Windows.Forms.Button
        Me.AddSource = New System.Windows.Forms.Button
        Me.Label34 = New System.Windows.Forms.Label
        Me.SpellSourceDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CasterLevel = New DevExpress.XtraEditors.SpinEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.SourceBox = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.CasterType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CasterLabel = New System.Windows.Forms.Label
        Me.IndentedLine8 = New RPGXplorer.IndentedLine
        Me.IndentedLine9 = New RPGXplorer.IndentedLine
        Me.SourcesList = New RPGXplorer.ListBox
        Me.CompanionTab = New System.Windows.Forms.TabPage
        Me.NormalMountCheck = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.FamiliarDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.MountDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.CompanionDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.MountCheck = New System.Windows.Forms.CheckBox
        Me.CompanionCheck = New System.Windows.Forms.CheckBox
        Me.FamiliarCheck = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Speed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Climb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Burrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Swim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Space.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RaceTabControl.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.CON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManeuverDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaceSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TypeTab.SuspendLayout()
        CType(Me.Advancement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Treasure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Organization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Environment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubtypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WeaponsTab.SuspendLayout()
        CType(Me.WeaponDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SkillsTab.SuspendLayout()
        CType(Me.SkillDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ranks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LanguageTab.SuspendLayout()
        CType(Me.Languages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CasterTab.SuspendLayout()
        CType(Me.SpellSourceDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasterType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanionTab.SuspendLayout()
        CType(Me.FamiliarDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MountDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanionDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'Speed
        '
        Me.Speed.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Speed, 20)
        Me.Speed.Location = New System.Drawing.Point(60, 75)
        Me.Speed.Name = "Speed"
        Me.Speed.Properties.Appearance.Options.UseTextOptions = True
        Me.Speed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Speed.Properties.AutoHeight = False
        Me.Speed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Speed.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Speed.Properties.IsFloatValue = False
        Me.Speed.Properties.Mask.EditMask = "999"
        Me.Speed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Speed.Properties.Mask.ShowPlaceHolders = False
        Me.Speed.Properties.MaxValue = New Decimal(New Integer() {995, 0, 0, 0})
        Me.Speed.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Speed.Size = New System.Drawing.Size(55, 21)
        Me.Speed.TabIndex = 4
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 560)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Climb
        '
        Me.Climb.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Climb, 20)
        Me.Climb.Location = New System.Drawing.Point(185, 75)
        Me.Climb.Name = "Climb"
        Me.Climb.Properties.Appearance.Options.UseTextOptions = True
        Me.Climb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Climb.Properties.AutoHeight = False
        Me.Climb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Climb.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Climb.Properties.IsFloatValue = False
        Me.Climb.Properties.Mask.EditMask = "999"
        Me.Climb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Climb.Properties.Mask.ShowPlaceHolders = False
        Me.Climb.Properties.MaxValue = New Decimal(New Integer() {995, 0, 0, 0})
        Me.Climb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Climb.Size = New System.Drawing.Size(55, 21)
        Me.Climb.TabIndex = 5
        '
        'Burrow
        '
        Me.Burrow.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Burrow, 20)
        Me.Burrow.Location = New System.Drawing.Point(185, 105)
        Me.Burrow.Name = "Burrow"
        Me.Burrow.Properties.Appearance.Options.UseTextOptions = True
        Me.Burrow.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Burrow.Properties.AutoHeight = False
        Me.Burrow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Burrow.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Burrow.Properties.IsFloatValue = False
        Me.Burrow.Properties.Mask.EditMask = "999"
        Me.Burrow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Burrow.Properties.Mask.ShowPlaceHolders = False
        Me.Burrow.Properties.MaxValue = New Decimal(New Integer() {995, 0, 0, 0})
        Me.Burrow.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Burrow.Size = New System.Drawing.Size(55, 21)
        Me.Burrow.TabIndex = 7
        '
        'Swim
        '
        Me.Swim.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Swim, 20)
        Me.Swim.Location = New System.Drawing.Point(60, 105)
        Me.Swim.Name = "Swim"
        Me.Swim.Properties.Appearance.Options.UseTextOptions = True
        Me.Swim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Swim.Properties.AutoHeight = False
        Me.Swim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Swim.Properties.EditFormat.FormatString = "# ft;-# ft;-"
        Me.Swim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Swim.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Swim.Properties.IsFloatValue = False
        Me.Swim.Properties.Mask.EditMask = "999"
        Me.Swim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Swim.Properties.Mask.ShowPlaceHolders = False
        Me.Swim.Properties.MaxValue = New Decimal(New Integer() {995, 0, 0, 0})
        Me.Swim.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Swim.Size = New System.Drawing.Size(55, 21)
        Me.Swim.TabIndex = 6
        '
        'Fly
        '
        Me.Fly.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Fly, 20)
        Me.Fly.Location = New System.Drawing.Point(60, 135)
        Me.Fly.Name = "Fly"
        Me.Fly.Properties.Appearance.Options.UseTextOptions = True
        Me.Fly.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Fly.Properties.AutoHeight = False
        Me.Fly.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Fly.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Fly.Properties.IsFloatValue = False
        Me.Fly.Properties.Mask.EditMask = "999"
        Me.Fly.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Fly.Properties.Mask.ShowPlaceHolders = False
        Me.Fly.Properties.MaxValue = New Decimal(New Integer() {995, 0, 0, 0})
        Me.Fly.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Fly.Size = New System.Drawing.Size(55, 21)
        Me.Fly.TabIndex = 8
        '
        'HD
        '
        Me.HD.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.HD, 20)
        Me.HD.Location = New System.Drawing.Point(95, 185)
        Me.HD.Name = "HD"
        Me.HD.Properties.Appearance.Options.UseTextOptions = True
        Me.HD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.HD.Properties.AutoHeight = False
        Me.HD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HD.Properties.Mask.EditMask = "999"
        Me.HD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.HD.Properties.Mask.ShowPlaceHolders = False
        Me.HD.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.HD.Size = New System.Drawing.Size(55, 21)
        Me.HD.TabIndex = 10
        '
        'Reach
        '
        Me.Reach.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Reach, 20)
        Me.Reach.Location = New System.Drawing.Point(325, 45)
        Me.Reach.Name = "Reach"
        Me.Reach.Properties.Appearance.Options.UseTextOptions = True
        Me.Reach.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Reach.Properties.AutoHeight = False
        Me.Reach.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Reach.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Reach.Properties.IsFloatValue = False
        Me.Reach.Properties.Mask.EditMask = "999"
        Me.Reach.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Reach.Properties.Mask.ShowPlaceHolders = False
        Me.Reach.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Reach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Reach.Size = New System.Drawing.Size(55, 21)
        Me.Reach.TabIndex = 3
        '
        'Space
        '
        Me.Space.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Space, 20)
        Me.Space.Location = New System.Drawing.Point(210, 45)
        Me.Space.Name = "Space"
        Me.Space.Properties.Appearance.Options.UseTextOptions = True
        Me.Space.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Space.Properties.AutoHeight = False
        Me.Space.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Space.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Space.Properties.Mask.EditMask = "999"
        Me.Space.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Space.Properties.Mask.ShowPlaceHolders = False
        Me.Space.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Space.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.Space.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Space.Size = New System.Drawing.Size(55, 21)
        Me.Space.TabIndex = 2
        '
        'CR
        '
        Me.CR.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.CR, 20)
        Me.CR.Location = New System.Drawing.Point(280, 185)
        Me.CR.Name = "CR"
        Me.CR.Properties.Appearance.Options.UseTextOptions = True
        Me.CR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CR.Properties.AutoHeight = False
        Me.CR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CR.Properties.Mask.EditMask = "999"
        Me.CR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CR.Properties.Mask.ShowPlaceHolders = False
        Me.CR.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.CR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CR.Size = New System.Drawing.Size(55, 21)
        Me.CR.TabIndex = 176
        '
        'LA
        '
        Me.LA.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.LA, 20)
        Me.LA.Location = New System.Drawing.Point(280, 215)
        Me.LA.Name = "LA"
        Me.LA.Properties.Appearance.Options.UseTextOptions = True
        Me.LA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LA.Properties.AutoHeight = False
        Me.LA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LA.Properties.DisplayFormat.FormatString = "+#;-#;-"
        Me.LA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LA.Properties.EditFormat.FormatString = "+#;-#;-"
        Me.LA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LA.Properties.Mask.EditMask = "999"
        Me.LA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.LA.Properties.Mask.ShowPlaceHolders = False
        Me.LA.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.LA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.LA.Size = New System.Drawing.Size(55, 21)
        Me.LA.TabIndex = 178
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 560)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'RaceTabControl
        '
        Me.RaceTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RaceTabControl.Controls.Add(Me.Basics)
        Me.RaceTabControl.Controls.Add(Me.TypeTab)
        Me.RaceTabControl.Controls.Add(Me.WeaponsTab)
        Me.RaceTabControl.Controls.Add(Me.SkillsTab)
        Me.RaceTabControl.Controls.Add(Me.LanguageTab)
        Me.RaceTabControl.Controls.Add(Me.CasterTab)
        Me.RaceTabControl.Controls.Add(Me.CompanionTab)
        Me.RaceTabControl.Controls.Add(Me.TabPage1)
        Me.RaceTabControl.Location = New System.Drawing.Point(15, 15)
        Me.RaceTabControl.Name = "RaceTabControl"
        Me.RaceTabControl.SelectedIndex = 0
        Me.RaceTabControl.Size = New System.Drawing.Size(415, 530)
        Me.RaceTabControl.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.LA)
        Me.Basics.Controls.Add(Me.Label30)
        Me.Basics.Controls.Add(Me.CR)
        Me.Basics.Controls.Add(Me.Label29)
        Me.Basics.Controls.Add(Me.IndentedLine7)
        Me.Basics.Controls.Add(Me.ChaoticEvil)
        Me.Basics.Controls.Add(Me.ChaoticNeutral)
        Me.Basics.Controls.Add(Me.ChaoticGood)
        Me.Basics.Controls.Add(Me.NeutralEvil)
        Me.Basics.Controls.Add(Me.TrueNeutral)
        Me.Basics.Controls.Add(Me.NeutralGood)
        Me.Basics.Controls.Add(Me.LawfulEvil)
        Me.Basics.Controls.Add(Me.LawfulNeutral)
        Me.Basics.Controls.Add(Me.LawfulGood)
        Me.Basics.Controls.Add(Me.Label27)
        Me.Basics.Controls.Add(Me.Reach)
        Me.Basics.Controls.Add(Me.Label62)
        Me.Basics.Controls.Add(Me.Space)
        Me.Basics.Controls.Add(Me.Label63)
        Me.Basics.Controls.Add(Me.HD)
        Me.Basics.Controls.Add(Me.IndentedLine2)
        Me.Basics.Controls.Add(Me.Label15)
        Me.Basics.Controls.Add(Me.CON)
        Me.Basics.Controls.Add(Me.CHA)
        Me.Basics.Controls.Add(Me.WIS)
        Me.Basics.Controls.Add(Me.STR)
        Me.Basics.Controls.Add(Me.DEX)
        Me.Basics.Controls.Add(Me.INT)
        Me.Basics.Controls.Add(Me.ManeuverDropdown)
        Me.Basics.Controls.Add(Me.Fly)
        Me.Basics.Controls.Add(Me.Label17)
        Me.Basics.Controls.Add(Me.Swim)
        Me.Basics.Controls.Add(Me.Label16)
        Me.Basics.Controls.Add(Me.Burrow)
        Me.Basics.Controls.Add(Me.Label12)
        Me.Basics.Controls.Add(Me.Climb)
        Me.Basics.Controls.Add(Me.Label1)
        Me.Basics.Controls.Add(Me.NA)
        Me.Basics.Controls.Add(Me.Label21)
        Me.Basics.Controls.Add(Me.Speed)
        Me.Basics.Controls.Add(Me.Label10)
        Me.Basics.Controls.Add(Me.IndentedLine1)
        Me.Basics.Controls.Add(Me.Label6)
        Me.Basics.Controls.Add(Me.Label7)
        Me.Basics.Controls.Add(Me.Label9)
        Me.Basics.Controls.Add(Me.Label8)
        Me.Basics.Controls.Add(Me.Label4)
        Me.Basics.Controls.Add(Me.Label5)
        Me.Basics.Controls.Add(Me.Label3)
        Me.Basics.Controls.Add(Me.RaceSize)
        Me.Basics.Controls.Add(Me.Label11)
        Me.Basics.Controls.Add(Me.ObjectName)
        Me.Basics.Controls.Add(Me.Label2)
        Me.Basics.Location = New System.Drawing.Point(4, 22)
        Me.Basics.Name = "Basics"
        Me.Basics.Size = New System.Drawing.Size(407, 504)
        Me.Basics.TabIndex = 0
        Me.Basics.Text = "Race"
        Me.Basics.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Location = New System.Drawing.Point(180, 215)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 21)
        Me.Label30.TabIndex = 179
        Me.Label30.Text = "Level Adjustment"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Location = New System.Drawing.Point(180, 185)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(95, 21)
        Me.Label29.TabIndex = 177
        Me.Label29.Text = "Challenge Rating"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine7
        '
        Me.IndentedLine7.Location = New System.Drawing.Point(15, 360)
        Me.IndentedLine7.Name = "IndentedLine7"
        Me.IndentedLine7.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine7.TabIndex = 175
        Me.IndentedLine7.TabStop = False
        '
        'ChaoticEvil
        '
        Me.ChaoticEvil.CausesValidation = False
        Me.ChaoticEvil.Location = New System.Drawing.Point(225, 465)
        Me.ChaoticEvil.Name = "ChaoticEvil"
        Me.ChaoticEvil.Size = New System.Drawing.Size(100, 21)
        Me.ChaoticEvil.TabIndex = 173
        Me.ChaoticEvil.Text = "Chaotic Evil"
        '
        'ChaoticNeutral
        '
        Me.ChaoticNeutral.CausesValidation = False
        Me.ChaoticNeutral.Location = New System.Drawing.Point(115, 465)
        Me.ChaoticNeutral.Name = "ChaoticNeutral"
        Me.ChaoticNeutral.Size = New System.Drawing.Size(105, 21)
        Me.ChaoticNeutral.TabIndex = 172
        Me.ChaoticNeutral.Text = "Chaotic Neutral"
        '
        'ChaoticGood
        '
        Me.ChaoticGood.CausesValidation = False
        Me.ChaoticGood.Location = New System.Drawing.Point(15, 465)
        Me.ChaoticGood.Name = "ChaoticGood"
        Me.ChaoticGood.Size = New System.Drawing.Size(95, 21)
        Me.ChaoticGood.TabIndex = 171
        Me.ChaoticGood.Text = "Chaotic Good"
        '
        'NeutralEvil
        '
        Me.NeutralEvil.CausesValidation = False
        Me.NeutralEvil.Location = New System.Drawing.Point(225, 435)
        Me.NeutralEvil.Name = "NeutralEvil"
        Me.NeutralEvil.Size = New System.Drawing.Size(100, 21)
        Me.NeutralEvil.TabIndex = 170
        Me.NeutralEvil.Text = "Neutral Evil"
        '
        'TrueNeutral
        '
        Me.TrueNeutral.CausesValidation = False
        Me.TrueNeutral.Location = New System.Drawing.Point(115, 435)
        Me.TrueNeutral.Name = "TrueNeutral"
        Me.TrueNeutral.Size = New System.Drawing.Size(100, 21)
        Me.TrueNeutral.TabIndex = 169
        Me.TrueNeutral.Text = "True Neutral"
        '
        'NeutralGood
        '
        Me.NeutralGood.CausesValidation = False
        Me.NeutralGood.Location = New System.Drawing.Point(15, 435)
        Me.NeutralGood.Name = "NeutralGood"
        Me.NeutralGood.Size = New System.Drawing.Size(90, 21)
        Me.NeutralGood.TabIndex = 168
        Me.NeutralGood.Text = "Neutral Good"
        '
        'LawfulEvil
        '
        Me.LawfulEvil.CausesValidation = False
        Me.LawfulEvil.Location = New System.Drawing.Point(225, 405)
        Me.LawfulEvil.Name = "LawfulEvil"
        Me.LawfulEvil.Size = New System.Drawing.Size(100, 21)
        Me.LawfulEvil.TabIndex = 167
        Me.LawfulEvil.Text = "Lawful Evil"
        '
        'LawfulNeutral
        '
        Me.LawfulNeutral.CausesValidation = False
        Me.LawfulNeutral.Location = New System.Drawing.Point(115, 405)
        Me.LawfulNeutral.Name = "LawfulNeutral"
        Me.LawfulNeutral.Size = New System.Drawing.Size(100, 21)
        Me.LawfulNeutral.TabIndex = 166
        Me.LawfulNeutral.Text = "Lawful Neutral"
        '
        'LawfulGood
        '
        Me.LawfulGood.CausesValidation = False
        Me.LawfulGood.Location = New System.Drawing.Point(15, 405)
        Me.LawfulGood.Name = "LawfulGood"
        Me.LawfulGood.Size = New System.Drawing.Size(90, 21)
        Me.LawfulGood.TabIndex = 165
        Me.LawfulGood.Text = "Lawful Good"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Location = New System.Drawing.Point(15, 375)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(110, 21)
        Me.Label27.TabIndex = 174
        Me.Label27.Text = "Alignments"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.SystemColors.Control
        Me.Label62.Location = New System.Drawing.Point(280, 45)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(45, 21)
        Me.Label62.TabIndex = 164
        Me.Label62.Text = "Reach"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.SystemColors.Control
        Me.Label63.Location = New System.Drawing.Point(165, 45)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(45, 21)
        Me.Label63.TabIndex = 162
        Me.Label63.Text = "Space"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(16, 170)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 146
        Me.IndentedLine2.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(15, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 21)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Hit Dice #"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CON
        '
        Me.CON.AllowDrop = True
        Me.CON.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CON.Location = New System.Drawing.Point(265, 295)
        Me.CON.Name = "CON"
        Me.CON.Properties.Appearance.Options.UseTextOptions = True
        Me.CON.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CON.Properties.AutoHeight = False
        Me.CON.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CON.Properties.DisplayFormat.FormatString = "#;-#;-"
        Me.CON.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CON.Properties.EditFormat.FormatString = "#;-#;-"
        Me.CON.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CON.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.CON.Properties.IsFloatValue = False
        Me.CON.Properties.Mask.EditMask = "d"
        Me.CON.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CON.Properties.Mask.SaveLiteral = False
        Me.CON.Properties.Mask.ShowPlaceHolders = False
        Me.CON.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.CON.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CON.Size = New System.Drawing.Size(50, 21)
        Me.CON.TabIndex = 16
        '
        'CHA
        '
        Me.CHA.AllowDrop = True
        Me.CHA.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.CHA.Location = New System.Drawing.Point(265, 325)
        Me.CHA.Name = "CHA"
        Me.CHA.Properties.Appearance.Options.UseTextOptions = True
        Me.CHA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CHA.Properties.AutoHeight = False
        Me.CHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CHA.Properties.DisplayFormat.FormatString = "#;-#;-"
        Me.CHA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CHA.Properties.EditFormat.FormatString = "#;-#;-"
        Me.CHA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CHA.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.CHA.Properties.IsFloatValue = False
        Me.CHA.Properties.Mask.EditMask = "d"
        Me.CHA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CHA.Properties.Mask.SaveLiteral = False
        Me.CHA.Properties.Mask.ShowPlaceHolders = False
        Me.CHA.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.CHA.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CHA.Size = New System.Drawing.Size(50, 21)
        Me.CHA.TabIndex = 19
        '
        'WIS
        '
        Me.WIS.AllowDrop = True
        Me.WIS.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.WIS.Location = New System.Drawing.Point(160, 325)
        Me.WIS.Name = "WIS"
        Me.WIS.Properties.Appearance.Options.UseTextOptions = True
        Me.WIS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WIS.Properties.AutoHeight = False
        Me.WIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.WIS.Properties.DisplayFormat.FormatString = "#;-#;-"
        Me.WIS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.WIS.Properties.EditFormat.FormatString = "#;-#;-"
        Me.WIS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.WIS.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.WIS.Properties.IsFloatValue = False
        Me.WIS.Properties.Mask.EditMask = "d"
        Me.WIS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.WIS.Properties.Mask.SaveLiteral = False
        Me.WIS.Properties.Mask.ShowPlaceHolders = False
        Me.WIS.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.WIS.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WIS.Size = New System.Drawing.Size(50, 21)
        Me.WIS.TabIndex = 18
        '
        'STR
        '
        Me.STR.AllowDrop = True
        Me.STR.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.STR.Location = New System.Drawing.Point(55, 295)
        Me.STR.Name = "STR"
        Me.STR.Properties.Appearance.Options.UseTextOptions = True
        Me.STR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.STR.Properties.AutoHeight = False
        Me.STR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.STR.Properties.DisplayFormat.FormatString = "#;-#;-"
        Me.STR.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.STR.Properties.EditFormat.FormatString = "#;-#;-"
        Me.STR.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.STR.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.STR.Properties.IsFloatValue = False
        Me.STR.Properties.Mask.EditMask = "d"
        Me.STR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.STR.Properties.Mask.SaveLiteral = False
        Me.STR.Properties.Mask.ShowPlaceHolders = False
        Me.STR.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.STR.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.STR.Size = New System.Drawing.Size(50, 21)
        Me.STR.TabIndex = 14
        '
        'DEX
        '
        Me.DEX.AllowDrop = True
        Me.DEX.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DEX.Location = New System.Drawing.Point(160, 295)
        Me.DEX.Name = "DEX"
        Me.DEX.Properties.Appearance.Options.UseTextOptions = True
        Me.DEX.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DEX.Properties.AutoHeight = False
        Me.DEX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DEX.Properties.DisplayFormat.FormatString = "#;-#;-"
        Me.DEX.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DEX.Properties.EditFormat.FormatString = "#;-#;-"
        Me.DEX.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DEX.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DEX.Properties.IsFloatValue = False
        Me.DEX.Properties.Mask.EditMask = "d"
        Me.DEX.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.DEX.Properties.Mask.SaveLiteral = False
        Me.DEX.Properties.Mask.ShowPlaceHolders = False
        Me.DEX.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.DEX.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DEX.Size = New System.Drawing.Size(50, 21)
        Me.DEX.TabIndex = 15
        '
        'INT
        '
        Me.INT.AllowDrop = True
        Me.INT.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.INT.Location = New System.Drawing.Point(55, 325)
        Me.INT.Name = "INT"
        Me.INT.Properties.Appearance.Options.UseTextOptions = True
        Me.INT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.INT.Properties.AutoHeight = False
        Me.INT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.INT.Properties.DisplayFormat.FormatString = "#;-#;-"
        Me.INT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.INT.Properties.EditFormat.FormatString = "#;-#;-"
        Me.INT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.INT.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.INT.Properties.IsFloatValue = False
        Me.INT.Properties.Mask.EditMask = "d"
        Me.INT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.INT.Properties.Mask.SaveLiteral = False
        Me.INT.Properties.Mask.ShowPlaceHolders = False
        Me.INT.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.INT.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.INT.Size = New System.Drawing.Size(50, 21)
        Me.INT.TabIndex = 17
        '
        'ManeuverDropdown
        '
        Me.ManeuverDropdown.Enabled = False
        Me.ManeuverDropdown.Location = New System.Drawing.Point(125, 135)
        Me.ManeuverDropdown.Name = "ManeuverDropdown"
        Me.ManeuverDropdown.Properties.AutoHeight = False
        Me.ManeuverDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ManeuverDropdown.Properties.DropDownRows = 10
        Me.ManeuverDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ManeuverDropdown.Size = New System.Drawing.Size(135, 21)
        Me.ManeuverDropdown.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(15, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 21)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "Fly"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(15, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 21)
        Me.Label16.TabIndex = 134
        Me.Label16.Text = "Swim"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(130, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 21)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Burrow"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(130, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Climb"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NA
        '
        Me.NA.Location = New System.Drawing.Point(95, 215)
        Me.NA.Name = "NA"
        Me.NA.Size = New System.Drawing.Size(55, 21)
        Me.NA.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 215)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 21)
        Me.Label21.TabIndex = 128
        Me.Label21.Text = "Natural Armor"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 21)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Ability Scores"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 250)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 119
        Me.IndentedLine1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(15, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 21)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "INT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(120, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 21)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "WIS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(225, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 21)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "CHA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 21)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "STR"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(120, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 21)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "DEX"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(225, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "CON"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Size"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RaceSize
        '
        Me.RaceSize.Location = New System.Drawing.Point(60, 45)
        Me.RaceSize.Name = "RaceSize"
        Me.RaceSize.Properties.AutoHeight = False
        Me.RaceSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RaceSize.Properties.DropDownRows = 10
        Me.RaceSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RaceSize.Size = New System.Drawing.Size(100, 21)
        Me.RaceSize.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Speed"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(60, 15)
        Me.ObjectName.Name = "ObjectName"
        Me.ObjectName.Properties.AutoHeight = False
        Me.ObjectName.Properties.MaxLength = 100
        Me.ObjectName.Size = New System.Drawing.Size(135, 21)
        Me.ObjectName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TypeTab
        '
        Me.TypeTab.Controls.Add(Me.FeatCheck)
        Me.TypeTab.Controls.Add(Me.IndentedLine12)
        Me.TypeTab.Controls.Add(Me.QuadCheck)
        Me.TypeTab.Controls.Add(Me.NonhumanoidCheck)
        Me.TypeTab.Controls.Add(Me.Label28)
        Me.TypeTab.Controls.Add(Me.Advancement)
        Me.TypeTab.Controls.Add(Me.Label24)
        Me.TypeTab.Controls.Add(Me.Treasure)
        Me.TypeTab.Controls.Add(Me.Label25)
        Me.TypeTab.Controls.Add(Me.Organization)
        Me.TypeTab.Controls.Add(Me.Label26)
        Me.TypeTab.Controls.Add(Me.Environment)
        Me.TypeTab.Controls.Add(Me.SubtypeDropdown)
        Me.TypeTab.Controls.Add(Me.Label22)
        Me.TypeTab.Controls.Add(Me.RemoveSubtype)
        Me.TypeTab.Controls.Add(Me.AddSubtype)
        Me.TypeTab.Controls.Add(Me.Label20)
        Me.TypeTab.Controls.Add(Me.TypeDropdown)
        Me.TypeTab.Controls.Add(Me.IndentedLine10)
        Me.TypeTab.Controls.Add(Me.IndentedLine6)
        Me.TypeTab.Controls.Add(Me.IndentedLine4)
        Me.TypeTab.Controls.Add(Me.SubtypeList)
        Me.TypeTab.Location = New System.Drawing.Point(4, 22)
        Me.TypeTab.Name = "TypeTab"
        Me.TypeTab.Size = New System.Drawing.Size(407, 504)
        Me.TypeTab.TabIndex = 12
        Me.TypeTab.Text = "Race 2"
        Me.TypeTab.UseVisualStyleBackColor = True
        '
        'FeatCheck
        '
        Me.FeatCheck.CausesValidation = False
        Me.FeatCheck.Location = New System.Drawing.Point(15, 395)
        Me.FeatCheck.Name = "FeatCheck"
        Me.FeatCheck.Size = New System.Drawing.Size(310, 21)
        Me.FeatCheck.TabIndex = 220
        Me.FeatCheck.Text = "Generate Feat Slots"
        '
        'IndentedLine12
        '
        Me.IndentedLine12.CausesValidation = False
        Me.IndentedLine12.Location = New System.Drawing.Point(16, 385)
        Me.IndentedLine12.Name = "IndentedLine12"
        Me.IndentedLine12.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine12.TabIndex = 219
        Me.IndentedLine12.TabStop = False
		'
        'QuadCheck
        '
        Me.QuadCheck.CausesValidation = False
        Me.QuadCheck.Enabled = False
        Me.QuadCheck.Location = New System.Drawing.Point(35, 465)
        Me.QuadCheck.Name = "QuadCheck"
        Me.QuadCheck.Size = New System.Drawing.Size(145, 21)
        Me.QuadCheck.TabIndex = 218
        Me.QuadCheck.Text = "Quadruped (or greater)"
        '
        'NonhumanoidCheck
        '
        Me.NonhumanoidCheck.CausesValidation = False
        Me.NonhumanoidCheck.Location = New System.Drawing.Point(15, 435)
        Me.NonhumanoidCheck.Name = "NonhumanoidCheck"
        Me.NonhumanoidCheck.Size = New System.Drawing.Size(100, 21)
        Me.NonhumanoidCheck.TabIndex = 217
        Me.NonhumanoidCheck.Text = "Nonhumanoid"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.CausesValidation = False
        Me.Label28.Location = New System.Drawing.Point(15, 350)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 21)
        Me.Label28.TabIndex = 215
        Me.Label28.Text = "Advancement"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Advancement
        '
        Me.Advancement.CausesValidation = False
        Me.Advancement.EditValue = ""
        Me.Advancement.Location = New System.Drawing.Point(115, 350)
        Me.Advancement.Name = "Advancement"
        Me.Advancement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Advancement.Properties.DropDownRows = 20
        Me.Advancement.Size = New System.Drawing.Size(270, 20)
        Me.Advancement.TabIndex = 214
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.CausesValidation = False
        Me.Label24.Location = New System.Drawing.Point(15, 320)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 21)
        Me.Label24.TabIndex = 212
        Me.Label24.Text = "Treasure"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Treasure
        '
        Me.Treasure.CausesValidation = False
        Me.Treasure.EditValue = ""
        Me.Treasure.Location = New System.Drawing.Point(115, 320)
        Me.Treasure.Name = "Treasure"
        Me.Treasure.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Treasure.Properties.DropDownRows = 20
        Me.Treasure.Size = New System.Drawing.Size(270, 20)
        Me.Treasure.TabIndex = 209
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.CausesValidation = False
        Me.Label25.Location = New System.Drawing.Point(15, 290)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 21)
        Me.Label25.TabIndex = 211
        Me.Label25.Text = "Organization"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Organization
        '
        Me.Organization.CausesValidation = False
        Me.Organization.EditValue = ""
        Me.Organization.Location = New System.Drawing.Point(115, 290)
        Me.Organization.Name = "Organization"
        Me.Organization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Organization.Properties.DropDownRows = 20
        Me.Organization.Size = New System.Drawing.Size(270, 20)
        Me.Organization.TabIndex = 208
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.CausesValidation = False
        Me.Label26.Location = New System.Drawing.Point(15, 260)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 21)
        Me.Label26.TabIndex = 210
        Me.Label26.Text = "Environment"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Environment
        '
        Me.Environment.CausesValidation = False
        Me.Environment.EditValue = ""
        Me.Environment.Location = New System.Drawing.Point(115, 260)
        Me.Environment.Name = "Environment"
        Me.Environment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Environment.Properties.DropDownRows = 20
        Me.Environment.Size = New System.Drawing.Size(270, 20)
        Me.Environment.TabIndex = 207
        '
        'SubtypeDropdown
        '
        Me.SubtypeDropdown.CausesValidation = False
        Me.SubtypeDropdown.Location = New System.Drawing.Point(65, 45)
        Me.SubtypeDropdown.Name = "SubtypeDropdown"
        Me.SubtypeDropdown.Properties.AutoHeight = False
        Me.SubtypeDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubtypeDropdown.Properties.DropDownRows = 10
        Me.SubtypeDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SubtypeDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SubtypeDropdown.TabIndex = 149
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.CausesValidation = False
        Me.Label22.Location = New System.Drawing.Point(15, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 21)
        Me.Label22.TabIndex = 156
        Me.Label22.Text = "Subtype"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveSubtype
        '
        Me.RemoveSubtype.CausesValidation = False
        Me.RemoveSubtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSubtype.Location = New System.Drawing.Point(280, 125)
        Me.RemoveSubtype.Name = "RemoveSubtype"
        Me.RemoveSubtype.Size = New System.Drawing.Size(110, 24)
        Me.RemoveSubtype.TabIndex = 153
        Me.RemoveSubtype.Text = "Remove Subtype"
        '
        'AddSubtype
        '
        Me.AddSubtype.CausesValidation = False
        Me.AddSubtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubtype.Location = New System.Drawing.Point(280, 95)
        Me.AddSubtype.Name = "AddSubtype"
        Me.AddSubtype.Size = New System.Drawing.Size(110, 24)
        Me.AddSubtype.TabIndex = 152
        Me.AddSubtype.Text = "Add Subtype"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(15, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 21)
        Me.Label20.TabIndex = 110
        Me.Label20.Text = "Type"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TypeDropdown
        '
        Me.TypeDropdown.Location = New System.Drawing.Point(65, 15)
        Me.TypeDropdown.Name = "TypeDropdown"
        Me.TypeDropdown.Properties.AutoHeight = False
        Me.TypeDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeDropdown.Properties.DropDownRows = 10
        Me.TypeDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TypeDropdown.Size = New System.Drawing.Size(200, 21)
        Me.TypeDropdown.TabIndex = 109
        '
        'IndentedLine10
        '
        Me.IndentedLine10.CausesValidation = False
        Me.IndentedLine10.Location = New System.Drawing.Point(15, 425)
        Me.IndentedLine10.Name = "IndentedLine10"
        Me.IndentedLine10.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine10.TabIndex = 216
        Me.IndentedLine10.TabStop = False
        '
        'IndentedLine6
        '
        Me.IndentedLine6.CausesValidation = False
        Me.IndentedLine6.Location = New System.Drawing.Point(15, 245)
        Me.IndentedLine6.Name = "IndentedLine6"
        Me.IndentedLine6.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine6.TabIndex = 213
        Me.IndentedLine6.TabStop = False
        '
        'IndentedLine4
        '
        Me.IndentedLine4.CausesValidation = False
        Me.IndentedLine4.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 155
        Me.IndentedLine4.TabStop = False
        '
        'SubtypeList
        '
        Me.SubtypeList.CausesValidation = False
        Me.SubtypeList.Location = New System.Drawing.Point(15, 95)
        Me.SubtypeList.Name = "SubtypeList"
        Me.SubtypeList.Size = New System.Drawing.Size(250, 140)
        Me.SubtypeList.TabIndex = 151
        '
        'WeaponsTab
        '
        Me.WeaponsTab.Controls.Add(Me.WeaponDropdown)
        Me.WeaponsTab.Controls.Add(Me.Label23)
        Me.WeaponsTab.Controls.Add(Me.RemoveWeapon)
        Me.WeaponsTab.Controls.Add(Me.AddWeapon)
        Me.WeaponsTab.Controls.Add(Me.IndentedLine5)
        Me.WeaponsTab.Controls.Add(Me.WeaponsList)
        Me.WeaponsTab.Location = New System.Drawing.Point(4, 22)
        Me.WeaponsTab.Name = "WeaponsTab"
        Me.WeaponsTab.Size = New System.Drawing.Size(407, 504)
        Me.WeaponsTab.TabIndex = 13
        Me.WeaponsTab.Text = "Weapons"
        Me.WeaponsTab.UseVisualStyleBackColor = True
        '
        'WeaponDropdown
        '
        Me.WeaponDropdown.CausesValidation = False
        Me.WeaponDropdown.Location = New System.Drawing.Point(65, 15)
        Me.WeaponDropdown.Name = "WeaponDropdown"
        Me.WeaponDropdown.Properties.AutoHeight = False
        Me.WeaponDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeaponDropdown.Properties.DropDownRows = 10
        Me.WeaponDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.WeaponDropdown.Size = New System.Drawing.Size(200, 21)
        Me.WeaponDropdown.TabIndex = 157
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.CausesValidation = False
        Me.Label23.Location = New System.Drawing.Point(15, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 21)
        Me.Label23.TabIndex = 162
        Me.Label23.Text = "Weapon"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveWeapon
        '
        Me.RemoveWeapon.CausesValidation = False
        Me.RemoveWeapon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveWeapon.Location = New System.Drawing.Point(280, 95)
        Me.RemoveWeapon.Name = "RemoveWeapon"
        Me.RemoveWeapon.Size = New System.Drawing.Size(110, 24)
        Me.RemoveWeapon.TabIndex = 160
        Me.RemoveWeapon.Text = "Remove Weapon"
        '
        'AddWeapon
        '
        Me.AddWeapon.CausesValidation = False
        Me.AddWeapon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddWeapon.Location = New System.Drawing.Point(280, 65)
        Me.AddWeapon.Name = "AddWeapon"
        Me.AddWeapon.Size = New System.Drawing.Size(110, 24)
        Me.AddWeapon.TabIndex = 159
        Me.AddWeapon.Text = "Add Weapon"
        '
        'IndentedLine5
        '
        Me.IndentedLine5.CausesValidation = False
        Me.IndentedLine5.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 161
        Me.IndentedLine5.TabStop = False
        '
        'WeaponsList
        '
        Me.WeaponsList.CausesValidation = False
        Me.WeaponsList.Location = New System.Drawing.Point(15, 65)
        Me.WeaponsList.Name = "WeaponsList"
        Me.WeaponsList.Size = New System.Drawing.Size(250, 420)
        Me.WeaponsList.TabIndex = 158
        '
        'SkillsTab
        '
        Me.SkillsTab.Controls.Add(Me.TypeLabel)
        Me.SkillsTab.Controls.Add(Me.SkillDropdown)
        Me.SkillsTab.Controls.Add(Me.Ranks)
        Me.SkillsTab.Controls.Add(Me.Label18)
        Me.SkillsTab.Controls.Add(Me.RemoveSkill)
        Me.SkillsTab.Controls.Add(Me.AddSkill)
        Me.SkillsTab.Controls.Add(Me.IndentedLine3)
        Me.SkillsTab.Controls.Add(Me.LevelListBox)
        Me.SkillsTab.Location = New System.Drawing.Point(4, 22)
        Me.SkillsTab.Name = "SkillsTab"
        Me.SkillsTab.Size = New System.Drawing.Size(407, 504)
        Me.SkillsTab.TabIndex = 10
        Me.SkillsTab.Text = "Class Skills"
        Me.SkillsTab.UseVisualStyleBackColor = True
        '
        'TypeLabel
        '
        Me.TypeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TypeLabel.CausesValidation = False
        Me.TypeLabel.Location = New System.Drawing.Point(15, 15)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(50, 21)
        Me.TypeLabel.TabIndex = 148
        Me.TypeLabel.Text = "Skill"
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkillDropdown
        '
        Me.SkillDropdown.CausesValidation = False
        Me.SkillDropdown.Location = New System.Drawing.Point(65, 15)
        Me.SkillDropdown.Name = "SkillDropdown"
        Me.SkillDropdown.Properties.AutoHeight = False
        Me.SkillDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SkillDropdown.Properties.DropDownRows = 10
        Me.SkillDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SkillDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SkillDropdown.TabIndex = 0
        '
        'Ranks
        '
        Me.Ranks.CausesValidation = False
        Me.Ranks.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ranks.Location = New System.Drawing.Point(65, 45)
        Me.Ranks.Name = "Ranks"
        Me.Ranks.Properties.Appearance.Options.UseTextOptions = True
        Me.Ranks.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ranks.Properties.AutoHeight = False
        Me.Ranks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Ranks.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Ranks.Properties.IsFloatValue = False
        Me.Ranks.Properties.Mask.EditMask = "N00"
        Me.Ranks.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Ranks.Size = New System.Drawing.Size(50, 21)
        Me.Ranks.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.CausesValidation = False
        Me.Label18.Location = New System.Drawing.Point(15, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 21)
        Me.Label18.TabIndex = 146
        Me.Label18.Text = "Ranks"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveSkill
        '
        Me.RemoveSkill.CausesValidation = False
        Me.RemoveSkill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSkill.Location = New System.Drawing.Point(280, 125)
        Me.RemoveSkill.Name = "RemoveSkill"
        Me.RemoveSkill.Size = New System.Drawing.Size(110, 24)
        Me.RemoveSkill.TabIndex = 4
        Me.RemoveSkill.Text = "Remove Skilll"
        '
        'AddSkill
        '
        Me.AddSkill.CausesValidation = False
        Me.AddSkill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSkill.Location = New System.Drawing.Point(280, 95)
        Me.AddSkill.Name = "AddSkill"
        Me.AddSkill.Size = New System.Drawing.Size(110, 24)
        Me.AddSkill.TabIndex = 3
        Me.AddSkill.Text = "Add Skill"
        '
        'IndentedLine3
        '
        Me.IndentedLine3.CausesValidation = False
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 147
        Me.IndentedLine3.TabStop = False
        '
        'LevelListBox
        '
        Me.LevelListBox.CausesValidation = False
        Me.LevelListBox.Location = New System.Drawing.Point(15, 95)
        Me.LevelListBox.Name = "LevelListBox"
        Me.LevelListBox.Size = New System.Drawing.Size(250, 385)
        Me.LevelListBox.TabIndex = 2
        '
        'LanguageTab
        '
        Me.LanguageTab.Controls.Add(Me.IndentedLine11)
        Me.LanguageTab.Controls.Add(Me.Label35)
        Me.LanguageTab.Controls.Add(Me.RemoveBonus)
        Me.LanguageTab.Controls.Add(Me.AddBonus)
        Me.LanguageTab.Controls.Add(Me.Label36)
        Me.LanguageTab.Controls.Add(Me.RemoveAutomatic)
        Me.LanguageTab.Controls.Add(Me.AddAutomatic)
        Me.LanguageTab.Controls.Add(Me.Label37)
        Me.LanguageTab.Controls.Add(Me.Languages)
        Me.LanguageTab.Controls.Add(Me.BonusLanguages)
        Me.LanguageTab.Controls.Add(Me.AutomaticLanguages)
        Me.LanguageTab.Location = New System.Drawing.Point(4, 22)
        Me.LanguageTab.Name = "LanguageTab"
        Me.LanguageTab.Size = New System.Drawing.Size(407, 504)
        Me.LanguageTab.TabIndex = 15
        Me.LanguageTab.Text = "Languages"
        Me.LanguageTab.UseVisualStyleBackColor = True
        '
        'IndentedLine11
        '
        Me.IndentedLine11.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine11.Name = "IndentedLine11"
        Me.IndentedLine11.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine11.TabIndex = 198
        Me.IndentedLine11.TabStop = False
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Location = New System.Drawing.Point(15, 285)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(135, 21)
        Me.Label35.TabIndex = 197
        Me.Label35.Text = "Bonus Languages"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveBonus
        '
        Me.RemoveBonus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBonus.Location = New System.Drawing.Point(270, 345)
        Me.RemoveBonus.Name = "RemoveBonus"
        Me.RemoveBonus.Size = New System.Drawing.Size(120, 24)
        Me.RemoveBonus.TabIndex = 194
        Me.RemoveBonus.Text = "Remove Bonus"
        '
        'AddBonus
        '
        Me.AddBonus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBonus.Location = New System.Drawing.Point(270, 315)
        Me.AddBonus.Name = "AddBonus"
        Me.AddBonus.Size = New System.Drawing.Size(120, 24)
        Me.AddBonus.TabIndex = 193
        Me.AddBonus.Text = "Add Bonus"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Location = New System.Drawing.Point(15, 65)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(135, 21)
        Me.Label36.TabIndex = 196
        Me.Label36.Text = "Automatic Languages"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveAutomatic
        '
        Me.RemoveAutomatic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAutomatic.Location = New System.Drawing.Point(270, 125)
        Me.RemoveAutomatic.Name = "RemoveAutomatic"
        Me.RemoveAutomatic.Size = New System.Drawing.Size(120, 24)
        Me.RemoveAutomatic.TabIndex = 191
        Me.RemoveAutomatic.Text = "Remove Automatic"
        '
        'AddAutomatic
        '
        Me.AddAutomatic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAutomatic.Location = New System.Drawing.Point(270, 95)
        Me.AddAutomatic.Name = "AddAutomatic"
        Me.AddAutomatic.Size = New System.Drawing.Size(120, 24)
        Me.AddAutomatic.TabIndex = 190
        Me.AddAutomatic.Text = "Add Automatic"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Location = New System.Drawing.Point(15, 15)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(60, 21)
        Me.Label37.TabIndex = 195
        Me.Label37.Text = "Language"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Languages
        '
        Me.Languages.CausesValidation = False
        Me.Languages.Location = New System.Drawing.Point(75, 15)
        Me.Languages.Name = "Languages"
        Me.Languages.Properties.AutoHeight = False
        Me.Languages.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Languages.Properties.DropDownRows = 10
        Me.Languages.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Languages.Size = New System.Drawing.Size(180, 21)
        Me.Languages.TabIndex = 188
        '
        'BonusLanguages
        '
        Me.BonusLanguages.Location = New System.Drawing.Point(15, 315)
        Me.BonusLanguages.Name = "BonusLanguages"
        Me.BonusLanguages.Size = New System.Drawing.Size(240, 170)
        Me.BonusLanguages.TabIndex = 192
        '
        'AutomaticLanguages
        '
        Me.AutomaticLanguages.Location = New System.Drawing.Point(15, 95)
        Me.AutomaticLanguages.Name = "AutomaticLanguages"
        Me.AutomaticLanguages.Size = New System.Drawing.Size(240, 170)
        Me.AutomaticLanguages.TabIndex = 189
		'
        'CasterTab
        '
        Me.CasterTab.BackColor = System.Drawing.Color.Transparent
        Me.CasterTab.Controls.Add(Me.Label33)
        Me.CasterTab.Controls.Add(Me.RemoveSource)
        Me.CasterTab.Controls.Add(Me.AddSource)
        Me.CasterTab.Controls.Add(Me.Label34)
        Me.CasterTab.Controls.Add(Me.SpellSourceDropdown)
        Me.CasterTab.Controls.Add(Me.CasterLevel)
        Me.CasterTab.Controls.Add(Me.Label32)
        Me.CasterTab.Controls.Add(Me.SourceBox)
        Me.CasterTab.Controls.Add(Me.Label31)
        Me.CasterTab.Controls.Add(Me.CasterType)
        Me.CasterTab.Controls.Add(Me.CasterLabel)
        Me.CasterTab.Controls.Add(Me.IndentedLine8)
        Me.CasterTab.Controls.Add(Me.IndentedLine9)
        Me.CasterTab.Controls.Add(Me.SourcesList)
        Me.CasterTab.Location = New System.Drawing.Point(4, 22)
        Me.CasterTab.Name = "CasterTab"
        Me.CasterTab.Size = New System.Drawing.Size(407, 504)
        Me.CasterTab.TabIndex = 14
        Me.CasterTab.Text = "Caster/Manifester"
        Me.CasterTab.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Location = New System.Drawing.Point(15, 125)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(165, 21)
        Me.Label33.TabIndex = 186
        Me.Label33.Text = "Additional Spell/Power Sources"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveSource
        '
        Me.RemoveSource.CausesValidation = False
        Me.RemoveSource.Enabled = False
        Me.RemoveSource.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSource.Location = New System.Drawing.Point(280, 230)
        Me.RemoveSource.Name = "RemoveSource"
        Me.RemoveSource.Size = New System.Drawing.Size(110, 24)
        Me.RemoveSource.TabIndex = 183
        Me.RemoveSource.Text = "Remove Source"
        '
        'AddSource
        '
        Me.AddSource.CausesValidation = False
        Me.AddSource.Enabled = False
        Me.AddSource.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSource.Location = New System.Drawing.Point(280, 200)
        Me.AddSource.Name = "AddSource"
        Me.AddSource.Size = New System.Drawing.Size(110, 24)
        Me.AddSource.TabIndex = 182
        Me.AddSource.Text = "Add Source"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Location = New System.Drawing.Point(15, 152)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 21)
        Me.Label34.TabIndex = 179
        Me.Label34.Text = "Source"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpellSourceDropdown
        '
        Me.SpellSourceDropdown.CausesValidation = False
        Me.SpellSourceDropdown.Enabled = False
        Me.SpellSourceDropdown.Location = New System.Drawing.Point(65, 152)
        Me.SpellSourceDropdown.Name = "SpellSourceDropdown"
        Me.SpellSourceDropdown.Properties.AutoHeight = False
        Me.SpellSourceDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpellSourceDropdown.Properties.DropDownRows = 10
        Me.SpellSourceDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SpellSourceDropdown.Size = New System.Drawing.Size(200, 21)
        Me.SpellSourceDropdown.TabIndex = 178
        '
        'CasterLevel
        '
        Me.CasterLevel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Enabled = False
        Me.CasterLevel.Location = New System.Drawing.Point(180, 75)
        Me.CasterLevel.Name = "CasterLevel"
        Me.CasterLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.CasterLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CasterLevel.Properties.AutoHeight = False
        Me.CasterLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CasterLevel.Properties.IsFloatValue = False
        Me.CasterLevel.Properties.Mask.BeepOnError = True
        Me.CasterLevel.Properties.Mask.EditMask = "d"
        Me.CasterLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.CasterLevel.Properties.Mask.ShowPlaceHolders = False
        Me.CasterLevel.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.CasterLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CasterLevel.Size = New System.Drawing.Size(50, 21)
        Me.CasterLevel.TabIndex = 176
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Location = New System.Drawing.Point(15, 75)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(165, 21)
        Me.Label32.TabIndex = 175
        Me.Label32.Text = "Caster/Manifester Class Levels"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SourceBox
        '
        Me.SourceBox.EditValue = ""
        Me.SourceBox.Enabled = False
        Me.SourceBox.Location = New System.Drawing.Point(65, 45)
        Me.SourceBox.Name = "SourceBox"
        Me.SourceBox.Properties.AutoHeight = False
        Me.SourceBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SourceBox.Properties.DropDownRows = 10
        Me.SourceBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.SourceBox.Size = New System.Drawing.Size(200, 21)
        Me.SourceBox.TabIndex = 170
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Location = New System.Drawing.Point(15, 45)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 21)
        Me.Label31.TabIndex = 171
        Me.Label31.Text = "Class"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CasterType
        '
        Me.CasterType.EditValue = ""
        Me.CasterType.Location = New System.Drawing.Point(65, 15)
        Me.CasterType.Name = "CasterType"
        Me.CasterType.Properties.AutoHeight = False
        Me.CasterType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CasterType.Properties.DropDownRows = 10
        Me.CasterType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CasterType.Size = New System.Drawing.Size(200, 21)
        Me.CasterType.TabIndex = 159
        '
        'CasterLabel
        '
        Me.CasterLabel.BackColor = System.Drawing.SystemColors.Control
        Me.CasterLabel.Location = New System.Drawing.Point(15, 15)
        Me.CasterLabel.Name = "CasterLabel"
        Me.CasterLabel.Size = New System.Drawing.Size(50, 21)
        Me.CasterLabel.TabIndex = 160
        Me.CasterLabel.Text = "Type"
        Me.CasterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine8
        '
        Me.IndentedLine8.CausesValidation = False
        Me.IndentedLine8.Location = New System.Drawing.Point(16, 110)
        Me.IndentedLine8.Name = "IndentedLine8"
        Me.IndentedLine8.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine8.TabIndex = 185
        Me.IndentedLine8.TabStop = False
        '
        'IndentedLine9
        '
        Me.IndentedLine9.CausesValidation = False
        Me.IndentedLine9.Location = New System.Drawing.Point(15, 185)
        Me.IndentedLine9.Name = "IndentedLine9"
        Me.IndentedLine9.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine9.TabIndex = 184
        Me.IndentedLine9.TabStop = False
		'
        'SourcesList
        '
        Me.SourcesList.CausesValidation = False
        Me.SourcesList.Enabled = False
        Me.SourcesList.Location = New System.Drawing.Point(15, 200)
        Me.SourcesList.Name = "SourcesList"
        Me.SourcesList.Size = New System.Drawing.Size(250, 285)
        Me.SourcesList.TabIndex = 181
        '
        'CompanionTab
        '
        Me.CompanionTab.Controls.Add(Me.NormalMountCheck)
        Me.CompanionTab.Controls.Add(Me.Label19)
        Me.CompanionTab.Controls.Add(Me.FamiliarDropdown)
        Me.CompanionTab.Controls.Add(Me.Label14)
        Me.CompanionTab.Controls.Add(Me.MountDropdown)
        Me.CompanionTab.Controls.Add(Me.Label13)
        Me.CompanionTab.Controls.Add(Me.CompanionDropdown)
        Me.CompanionTab.Controls.Add(Me.MountCheck)
        Me.CompanionTab.Controls.Add(Me.CompanionCheck)
        Me.CompanionTab.Controls.Add(Me.FamiliarCheck)
        Me.CompanionTab.Location = New System.Drawing.Point(4, 22)
        Me.CompanionTab.Name = "CompanionTab"
        Me.CompanionTab.Size = New System.Drawing.Size(407, 504)
        Me.CompanionTab.TabIndex = 11
        Me.CompanionTab.Text = "Companion"
        Me.CompanionTab.UseVisualStyleBackColor = True
        '
        'NormalMountCheck
        '
        Me.NormalMountCheck.CausesValidation = False
        Me.NormalMountCheck.Location = New System.Drawing.Point(15, 195)
        Me.NormalMountCheck.Name = "NormalMountCheck"
        Me.NormalMountCheck.Size = New System.Drawing.Size(75, 21)
        Me.NormalMountCheck.TabIndex = 109
        Me.NormalMountCheck.Text = "Mount"
		'
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(35, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 21)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "Class"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FamiliarDropdown
        '
        Me.FamiliarDropdown.Enabled = False
        Me.FamiliarDropdown.Location = New System.Drawing.Point(85, 45)
        Me.FamiliarDropdown.Name = "FamiliarDropdown"
        Me.FamiliarDropdown.Properties.AutoHeight = False
        Me.FamiliarDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FamiliarDropdown.Properties.DropDownRows = 10
        Me.FamiliarDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FamiliarDropdown.Size = New System.Drawing.Size(200, 21)
        Me.FamiliarDropdown.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(35, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 21)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Class"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MountDropdown
        '
        Me.MountDropdown.Enabled = False
        Me.MountDropdown.Location = New System.Drawing.Point(85, 165)
        Me.MountDropdown.Name = "MountDropdown"
        Me.MountDropdown.Properties.AutoHeight = False
        Me.MountDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MountDropdown.Properties.DropDownRows = 10
        Me.MountDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MountDropdown.Size = New System.Drawing.Size(200, 21)
        Me.MountDropdown.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(35, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 21)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Class"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompanionDropdown
        '
        Me.CompanionDropdown.Enabled = False
        Me.CompanionDropdown.Location = New System.Drawing.Point(85, 105)
        Me.CompanionDropdown.Name = "CompanionDropdown"
        Me.CompanionDropdown.Properties.AutoHeight = False
        Me.CompanionDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanionDropdown.Properties.DropDownRows = 10
        Me.CompanionDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CompanionDropdown.Size = New System.Drawing.Size(200, 21)
        Me.CompanionDropdown.TabIndex = 3
        '
        'MountCheck
        '
        Me.MountCheck.CausesValidation = False
        Me.MountCheck.Location = New System.Drawing.Point(15, 135)
        Me.MountCheck.Name = "MountCheck"
        Me.MountCheck.Size = New System.Drawing.Size(205, 21)
        Me.MountCheck.TabIndex = 4
        Me.MountCheck.Text = "Special Mount / Fiendish Servant"
        '
        'CompanionCheck
        '
        Me.CompanionCheck.CausesValidation = False
        Me.CompanionCheck.Location = New System.Drawing.Point(15, 75)
        Me.CompanionCheck.Name = "CompanionCheck"
        Me.CompanionCheck.Size = New System.Drawing.Size(175, 21)
        Me.CompanionCheck.TabIndex = 2
        Me.CompanionCheck.Text = "Animal Companion"
        '
        'FamiliarCheck
        '
        Me.FamiliarCheck.CausesValidation = False
        Me.FamiliarCheck.Location = New System.Drawing.Point(15, 15)
        Me.FamiliarCheck.Name = "FamiliarCheck"
        Me.FamiliarCheck.Size = New System.Drawing.Size(185, 21)
        Me.FamiliarCheck.TabIndex = 0
        Me.FamiliarCheck.Text = "Familiar / Psicrystal"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 504)
        Me.TabPage1.TabIndex = 9
        Me.TabPage1.Text = "Properties"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
        '
        'MonsterRaceForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 598)
        Me.Controls.Add(Me.RaceTabControl)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MonsterRaceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonsterRaceForm"
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Speed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Climb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Burrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Swim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Space.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RaceTabControl.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.CON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManeuverDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaceSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TypeTab.ResumeLayout(False)
        CType(Me.Advancement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Treasure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Organization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Environment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubtypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WeaponsTab.ResumeLayout(False)
        CType(Me.WeaponDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SkillsTab.ResumeLayout(False)
        CType(Me.SkillDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ranks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LanguageTab.ResumeLayout(False)
        CType(Me.Languages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CasterTab.ResumeLayout(False)
        CType(Me.SpellSourceDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasterLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasterType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanionTab.ResumeLayout(False)
        CType(Me.FamiliarDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MountDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanionDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'indexes
    Private LanguageIndex As Rules.Index.IndexEntry()

    'datalists
    Private SkillsDatalist As DataListItem()
    Private NaturalDatalist As DataListItem()

    Private Familiars As DataListItem()
    Private Companions As DataListItem()
    Private Mounts As DataListItem()

    Private MonsterTypes As DataListItem()
    Private SubtypesDatalist As DataListItem()
    Private NaturalWeaponsDatalist As DataListItem()

    'object collections
    Private AutomaticLanguageObjs As New Objects.ObjectDataCollection
    Private BonusLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingAutoLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingBonusLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingClassSkills As New Objects.ObjectDataCollection
    Private ClassSkills As New Objects.ObjectDataCollection
    Private ExistingNaturalWeapons As New Objects.ObjectDataCollection
    Private NaturalWeapons As New Objects.ObjectDataCollection

    Private ExistingSubtypes As New Objects.ObjectDataCollection
    Private Subtypes As New Objects.ObjectDataCollection

    Private ExistingSpellPowerSources As New Objects.ObjectDataCollection
    Private SpellPowerSources As New Objects.ObjectDataCollection

    Private isLoading As Boolean

    'Collection for inherited components
    Private CurrentComponents As New Objects.ObjectDataCollection
    Private ExistingComponents As New Objects.ObjectDataCollection
    Private OldType As Objects.ObjectKey

    'setting the ability spins
    Private GlobalFlags As NonabilityFlags
    Private TypeFlags As NonabilityFlags

    'monster casters
    Private Spellcasters As New Objects.ObjectDataCollection
    Private SpellcastersList As DataListItem()

    Private Manifesters As New Objects.ObjectDataCollection
    Private ManifestersList As DataListItem()

    Private CasterLevels As New Hashtable

    Private SpellSourcesList As DataListItem()
    Private PowerSourcesList As DataListItem()

    Structure NonabilityFlags
        Dim Strength As Integer
        Dim Dexterity As Integer
        Dim Constitution As Integer
        Dim Intelligence As Integer
    End Structure

    'init
    Public Sub Init()
        Try

            'indexes            
            LanguageIndex = Rules.Index.Index(XML.DBTypes.Languages, Objects.LanguageDefinitionType)

            'datalists
            SkillsDatalist = Rules.Index.DataList(XML.DBTypes.Skills, Objects.SkillDefinitionType)
            NaturalDatalist = Rules.Index.DataList(XML.DBTypes.NaturalWeapons, Objects.NaturalWeaponDefinitionType)
            SubtypesDatalist = Rules.Index.DataList(XML.DBTypes.Subtypes, Objects.SubtypeDefinitionType)
            NaturalWeaponsDatalist = Rules.Index.DataList(XML.DBTypes.NaturalWeapons, Objects.NaturalWeaponDefinitionType)

            'class lists    
            Dim FamiliarList As New Objects.ObjectDataCollection
            Dim MountList As New Objects.ObjectDataCollection
            Dim CompanionList As New Objects.ObjectDataCollection
            Dim MonsterList As New Objects.ObjectDataCollection

            For Each ClassObj As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MonsterClasses, Objects.MonsterClassType)
                Select Case ClassObj.Element("ClassType")
                    Case "Familiar"
                        FamiliarList.Add(ClassObj)
                    Case "Animal Companion"
                        CompanionList.Add(ClassObj)
                    Case "Special Mount"
                        MountList.Add(ClassObj)
                    Case "Monster Type"
                        MonsterList.Add(ClassObj)
                End Select
            Next

            Dim SpellSourceOptions As New Objects.ObjectDataCollection
            Dim PowerSourceOptions As New Objects.ObjectDataCollection
            Dim ExcludeList As ArrayList

            For Each ClassObj As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassType)
                'we only want the sorcerer types
                Select Case ClassObj.Element("CasterType")
                    Case "", "Prestige"
                        'do nothing
                    Case "Psionic"
                        Manifesters.Add(ClassObj)
                        CasterLevels.Add(ClassObj.ObjectGUID, ClassObj.FirstChildOfType(Objects.ClassLevelsFolderType).Children.Count())
                        PowerSourceOptions.Add(ClassObj)
                    Case Else
                        'arcane or divine normaly
                        SpellSourceOptions.Add(ClassObj)

                        'If ClassObj.Element("SpellAcquisition") <> "Book" Then
                        '    Spellcasters.Add(ClassObj)
                        '    CasterLevels.Add(ClassObj.ObjectGUID, ClassObj.FirstChildOfType(Objects.ClassLevelsFolderType).Children.Count())
                        'End If

                        Spellcasters.Add(ClassObj)
                        CasterLevels.Add(ClassObj.ObjectGUID, ClassObj.FirstChildOfType(Objects.ClassLevelsFolderType).Children.Count())

                End Select
            Next

            SpellcastersList = Rules.Index.DataList(Spellcasters)
            ManifestersList = Rules.Index.DataList(Manifesters)

            'Spell Source list
            ExcludeList = New ArrayList
            For Each TempObj As Objects.ObjectData In SpellSourceOptions
                If TempObj.Element("InheritSpells") = "True" Then ExcludeList.Add(TempObj.ObjectGUID)
            Next

            'add domains and spell categories
            SpellSourceOptions.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.DomainDefinitionType))
            SpellSourceOptions.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellCategoryDefinitionType))
            SpellSourcesList = Rules.Index.DataListExclude(SpellSourceOptions, ExcludeList)

            'Power Source list
            ExcludeList = New ArrayList
            For Each TempObj As Objects.ObjectData In PowerSourceOptions
                If TempObj.Element("InheritPowers") = "True" Then ExcludeList.Add(TempObj.ObjectGUID)
            Next

            'add psionic specializations
            PowerSourceOptions.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Domains, Objects.PsionicSpecializationDefinitionType))
            PowerSourcesList = Rules.Index.DataListExclude(PowerSourceOptions, ExcludeList)

            'make datalists
            Familiars = Rules.Index.DataList(FamiliarList)
            Companions = Rules.Index.DataList(CompanionList)
            Mounts = Rules.Index.DataList(MountList)
            MonsterTypes = Rules.Index.DataList(MonsterList)

            'add items to the dropdowns
            FamiliarDropdown.Properties.Items.AddRange(Familiars)
            CompanionDropdown.Properties.Items.AddRange(Companions)
            MountDropdown.Properties.Items.AddRange(Mounts)
            TypeDropdown.Properties.Items.AddRange(MonsterTypes)
            SubtypeDropdown.Properties.Items.AddRange(SubtypesDatalist)
            WeaponDropdown.Properties.Items.AddRange(NaturalWeaponsDatalist)

            CasterType.Properties.Items.AddRange(Rules.Lists.MonsterCasterTypes)

            Environment.Properties.Items.AddRange(GetExistingValues("Environment").ToArray)
            Advancement.Properties.Items.AddRange(GetExistingValues("Advancement").ToArray)
            Treasure.Properties.Items.AddRange(GetExistingValues("Treasure").ToArray)
            Organization.Properties.Items.AddRange(GetExistingValues("Organization").ToArray)

            'clear collections
            AutomaticLanguageObjs.Clear()
            BonusLanguageObjs.Clear()

            'Race tab
            RaceSize.Properties.Items.AddRange(Rules.Lists.Sizes)
            ManeuverDropdown.Properties.Items.AddRange(Rules.Lists.FlyingManeuverability)

            NA.ModifierSpin.Properties.MinValue = 0
            NA.ModifierSpin.Properties.MaxValue = 50

            'class skills tab
            SkillDropdown.Properties.Items.AddRange(SkillsDatalist)

            'language tab
            Languages.Properties.Items.AddRange(Rules.Index.IndexNames(LanguageIndex))
            AutomaticLanguages.List.Items.Clear()
            BonusLanguages.List.Items.Clear()

            'init Formatters
            Space.Properties.DisplayFormat.Format = New Rules.DoubleFeetFormatter
            Space.Properties.EditFormat.Format = New Rules.DoubleFeetFormatter

            Reach.Properties.DisplayFormat.Format = New Rules.FeetFormatter
            Reach.Properties.EditFormat.Format = New Rules.FeetFormatter

            Speed.Properties.DisplayFormat.Format = New Rules.FeetFormatter
            Speed.Properties.EditFormat.Format = New Rules.FeetFormatter

            Climb.Properties.DisplayFormat.Format = New Rules.FeetWithNullFormatter
            Climb.Properties.EditFormat.Format = New Rules.FeetWithNullFormatter

            Burrow.Properties.DisplayFormat.Format = New Rules.FeetWithNullFormatter
            Burrow.Properties.EditFormat.Format = New Rules.FeetWithNullFormatter

            Fly.Properties.DisplayFormat.Format = New Rules.FeetWithNullFormatter
            Fly.Properties.EditFormat.Format = New Rules.FeetWithNullFormatter

            Swim.Properties.DisplayFormat.Format = New Rules.FeetWithNullFormatter
            Swim.Properties.EditFormat.Format = New Rules.FeetWithNullFormatter

            CR.Properties.DisplayFormat.Format = New Rules.FractionFormatter
            CR.Properties.EditFormat.Format = New Rules.FractionFormatter

            HD.Properties.DisplayFormat.Format = New Rules.FractionFormatter
            HD.Properties.EditFormat.Format = New Rules.FractionFormatter

            Space.Properties.DisplayFormat.Format = New Rules.FractionFormatter
            Space.Properties.EditFormat.Format = New Rules.FractionFormatter

            LA.Value = 0
            CasterType.SelectedIndex = 0

            'init propertiestab
            PropertiesTab.Init(mObject, mMode)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            isLoading = True

            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MonsterRaces)
            mObject.Type = Objects.MonsterRaceDefinitionType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form vars
            Me.Text = "Add Monster Race"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            'initialise controls
            Init()

            'set caster dropdown to no by default
            CasterType.SelectedIndex = 0

            isLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData
        Try
            isLoading = True

            mObject = Obj
            mMode = FormMode.Edit
            Me.Text = "Edit Monster Race"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls

            'basics tab
            ObjectName.Text = Obj.Name

            Speed.EditValue = CType(Obj.Element("Speed").Replace("ft.", ""), Integer)

            Climb.EditValue = Obj.Element("Climb").Replace("ft.", "")
            Burrow.EditValue = Obj.Element("Burrow").Replace("ft.", "")
            Fly.EditValue = Obj.Element("Fly").Replace("ft.", "")
            ManeuverDropdown.Text = Obj.Element("FlyManueverability")
            Swim.EditValue = Obj.Element("Swim").Replace("ft.", "")

            RaceSize.Text = Obj.Element("Size")
            Space.EditValue = Obj.Element("Space").Replace("ft.", "")
            Reach.EditValue = Obj.Element("Reach").Replace("ft.", "")

            HD.Value = CDec(mObject.ElementAsNumber("DiceNumber"))
            CR.Value = CDec(mObject.ElementAsNumber("ChallengeRating"))
            NA.ModifierSpin.EditValue = mObject.ElementAsInteger("NaturalArmor")
            LA.EditValue = mObject.Element("LevelAdjustment")

            If Obj.Element("LawfulGood") = "True" Then LawfulGood.CheckState = CheckState.Checked Else LawfulGood.Checked = False
            If Obj.Element("NeutralGood") = "True" Then NeutralGood.CheckState = CheckState.Checked Else NeutralGood.Checked = False
            If Obj.Element("ChaoticGood") = "True" Then ChaoticGood.CheckState = CheckState.Checked Else ChaoticGood.Checked = False
            If Obj.Element("LawfulNeutral") = "True" Then LawfulNeutral.CheckState = CheckState.Checked Else LawfulNeutral.Checked = False
            If Obj.Element("TrueNeutral") = "True" Then TrueNeutral.CheckState = CheckState.Checked Else TrueNeutral.Checked = False
            If Obj.Element("ChaoticNeutral") = "True" Then ChaoticNeutral.CheckState = CheckState.Checked Else ChaoticNeutral.Checked = False
            If Obj.Element("LawfulEvil") = "True" Then LawfulEvil.CheckState = CheckState.Checked Else LawfulEvil.Checked = False
            If Obj.Element("NeutralEvil") = "True" Then NeutralEvil.CheckState = CheckState.Checked Else NeutralEvil.Checked = False
            If Obj.Element("ChaoticEvil") = "True" Then ChaoticEvil.CheckState = CheckState.Checked Else ChaoticEvil.Checked = False

            STR.EditValue = mObject.ElementAsInteger("STRModifier")
            DEX.EditValue = mObject.ElementAsInteger("DEXModifier")
            CON.EditValue = mObject.ElementAsInteger("CONModifier")
            INT.EditValue = mObject.ElementAsInteger("INTModifier")
            WIS.EditValue = mObject.ElementAsInteger("WISModifier")
            CHA.EditValue = mObject.ElementAsInteger("CHAModifier")

            Environment.Text = Obj.Element("Environment")
            Treasure.Text = Obj.Element("Treasure")
            Organization.Text = Obj.Element("Organization")
            Advancement.Text = Obj.Element("Advancement")

            If mObject.Element("Nonhumanoid") <> "" Then
                NonhumanoidCheck.Checked = True
                If mObject.Element("Quadruped") <> "" Then QuadCheck.Checked = True
            End If

            If mObject.Element("GenerateFeats") <> "" Then
                FeatCheck.Checked = True
            End If

            'companion tab
            If mObject.Element("FamiliarClass") <> "" Then
                FamiliarCheck.Checked = True
                FamiliarDropdown.SelectedIndex = Rules.Index.GetGuidIndex(Familiars, mObject.GetFKGuid("FamiliarClass"))
            End If

            If mObject.Element("CompanionClass") <> "" Then
                CompanionCheck.Checked = True
                CompanionDropdown.SelectedIndex = Rules.Index.GetGuidIndex(Companions, mObject.GetFKGuid("CompanionClass"))
            End If

            If mObject.Element("MountClass") <> "" Then
                MountCheck.Checked = True
                MountDropdown.SelectedIndex = Rules.Index.GetGuidIndex(Mounts, mObject.GetFKGuid("MountClass"))
            End If

            If mObject.Element("NormalMount") = "Yes" Then
                NormalMountCheck.Checked = True
            End If

            'caster tab
            CasterType.Text = Obj.Element("CasterType")
            If CasterType.SelectedIndex > 0 Then
                Select Case CasterType.SelectedIndex
                    Case 1 'caster
                        SourceBox.SelectedIndex = Rules.Index.GetGuidIndex(SpellcastersList, mObject.GetFKGuid("CasterSource"))
                    Case 2 'manifester
                        SourceBox.SelectedIndex = Rules.Index.GetGuidIndex(ManifestersList, mObject.GetFKGuid("CasterSource"))
                End Select
                CasterLevel.Value = mObject.ElementAsInteger("CasterLevel")
            Else
                CasterType.SelectedIndex = 0
            End If

            'automatic languages
            ExistingAutoLanguageObjs = mObject.ChildrenOfType(Objects.AutomaticLanguageDefinitionType)
            For Each Child In mObject.ChildrenOfType(Objects.AutomaticLanguageDefinitionType)
                AutomaticLanguages.AddItem(Child.Name, Child.ObjectGUID)
                AutomaticLanguageObjs.Add(Child)
            Next

            'bonus languages
            ExistingBonusLanguageObjs = mObject.ChildrenOfType(Objects.BonusLanguageDefinitionType)
            For Each Child In mObject.ChildrenOfType(Objects.BonusLanguageDefinitionType)
                BonusLanguages.AddItem(Child.Name, Child.ObjectGUID)
                BonusLanguageObjs.Add(Child)
            Next

            'Type Tab
            OldType = mObject.GetFKGuid("MonsterType")
            TypeDropdown.SelectedIndex = Rules.Index.GetGuidIndex(MonsterTypes, OldType)

            'go through all children adding them to the appropriate collections
            Dim ChildCollection As Objects.ObjectDataCollection = mObject.Children

            For Each Child In ChildCollection

                Select Case Child.Type

                    Case Objects.ClassSkillType
                        ExistingClassSkills.Add(Child)

                    Case Objects.SubtypeType
                        ExistingSubtypes.Add(Child)

                    Case Objects.NaturalWeaponType
                        ExistingNaturalWeapons.Add(Child)

                    Case Objects.SpellorPowerSourceType
                        ExistingSpellPowerSources.Add(Child)

                    Case Objects.AutomaticLanguageDefinitionType
                        AutomaticLanguageObjs.Add(Child)

                    Case Objects.AutomaticLanguageDefinitionType
                        BonusLanguageObjs.Add(Child)

                    Case Else

                        'is this an inherited component from a subtype?
                        If Child.Element("Source") <> "" Then
                            ExistingComponents.Add(Child)
                            UpdateNonabilityFlags(Child, TypeFlags)
                        Else
                            UpdateNonabilityFlags(Child, GlobalFlags)
                        End If

                End Select
            Next

            'enable disable spin edits as required
            UpdateAbilitySpins()

            'get class skills           
            For Each Child In ExistingClassSkills
                ClassSkills.Add(Child)
                LevelListBox.AddItem(Child.Name, Child.ObjectGUID)
            Next

            'get natural weapons
            For Each Child In ExistingNaturalWeapons
                NaturalWeapons.Add(Child)
                WeaponsList.AddItem(Child.Name, Child.ObjectGUID)
            Next

            'get existing subtypes            
            For Each Child In ExistingSubtypes
                Subtypes.Add(Child)
                SubtypeList.AddItem(Child.Name, Child.ObjectGUID)
            Next

            'get existing inherited components  
            For Each Child In ExistingComponents
                CurrentComponents.Add(Child)
            Next

            'get existing spell sources
            For Each Child In ExistingSpellPowerSources
                SpellPowerSources.Add(Child)
                SourcesList.AddItem(Child)
            Next

            isLoading = False

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As Objects.ObjectData

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                mObject.Name = ObjectName.Text
                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                        mObject.ClearElements()
                End Select

                'basics tab
                mObject.Element("Speed") = Speed.Text
                mObject.Element("Swim") = Swim.Text
                mObject.Element("Burrow") = Burrow.Text
                mObject.Element("Climb") = Climb.Text
                mObject.Element("Fly") = Fly.Text
                mObject.Element("FlyManueverability") = Me.ManeuverDropdown.Text

                mObject.Element("Size") = RaceSize.Text
                mObject.Element("Space") = Space.Text
                mObject.Element("Reach") = Reach.Text

                mObject.Element("NaturalArmor") = NA.Text

                mObject.ElementAsNumber("DiceNumber") = HD.Value
                mObject.Element("DNDisplay") = HD.Text

                mObject.Element("LevelAdjustment") = LA.Text
                mObject.ElementAsNumber("ChallengeRating") = CR.Value
                mObject.Element("CRDisplay") = CR.Text

                Dim AlignmentString As String = ""
                Dim AllTrue As Boolean = True

                If LawfulGood.CheckState = CheckState.Checked Then
                    mObject.Element("LawfulGood") = "True"
                    AlignmentString &= "LG, "
                Else
                    mObject.Element("LawfulGood") = "False"
                    AllTrue = False
                End If

                If NeutralGood.CheckState = CheckState.Checked Then
                    mObject.Element("NeutralGood") = "True"
                    AlignmentString &= "NG, "
                Else
                    mObject.Element("NeutralGood") = "False"
                    AllTrue = False
                End If

                If ChaoticGood.CheckState = CheckState.Checked Then
                    mObject.Element("ChaoticGood") = "True"
                    AlignmentString &= "CG, "
                Else
                    mObject.Element("ChaoticGood") = "False"
                    AllTrue = False
                End If

                If LawfulNeutral.CheckState = CheckState.Checked Then
                    AlignmentString &= "LN, "
                    mObject.Element("LawfulNeutral") = "True"
                Else
                    mObject.Element("LawfulNeutral") = "False"
                    AllTrue = False
                End If

                If TrueNeutral.CheckState = CheckState.Checked Then
                    AlignmentString &= "N, "
                    mObject.Element("TrueNeutral") = "True"
                Else
                    mObject.Element("TrueNeutral") = "False"
                    AllTrue = False
                End If

                If ChaoticNeutral.CheckState = CheckState.Checked Then
                    AlignmentString &= "CN, "
                    mObject.Element("ChaoticNeutral") = "True"
                Else
                    mObject.Element("ChaoticNeutral") = "False"
                    AllTrue = False
                End If

                If LawfulEvil.CheckState = CheckState.Checked Then
                    AlignmentString &= "LE, "
                    mObject.Element("LawfulEvil") = "True"
                Else
                    mObject.Element("LawfulEvil") = "False"
                    AllTrue = False
                End If

                If NeutralEvil.CheckState = CheckState.Checked Then
                    AlignmentString &= "NE, "
                    mObject.Element("NeutralEvil") = "True"
                Else
                    mObject.Element("NeutralEvil") = "False"
                    AllTrue = False
                End If

                If ChaoticEvil.CheckState = CheckState.Checked Then
                    AlignmentString &= "CE, "
                    mObject.Element("ChaoticEvil") = "True"
                Else
                    mObject.Element("ChaoticEvil") = "False"
                    AllTrue = False
                End If

                If AllTrue Then
                    mObject.Element("AlignmentDisplay") = "Any"
                Else
                    AlignmentString = AlignmentString.TrimEnd(" ,".ToCharArray)
                    mObject.Element("AlignmentDisplay") = AlignmentString
                End If

                mObject.Element("STRModifier") = STR.Text
                mObject.Element("DEXModifier") = DEX.Text
                mObject.Element("CONModifier") = CON.Text
                mObject.Element("INTModifier") = INT.Text
                mObject.Element("WISModifier") = WIS.Text
                mObject.Element("CHAModifier") = CHA.Text

                mObject.Element("Environment") = Environment.Text
                mObject.Element("Treasure") = Treasure.Text
                mObject.Element("Organization") = Organization.Text
                mObject.Element("Advancement") = Advancement.Text

                If NonhumanoidCheck.Checked Then
                    mObject.Element("Nonhumanoid") = "Yes"
                    If QuadCheck.Checked Then mObject.Element("Quadruped") = "Yes"
                End If

                If FeatCheck.Checked Then
                    mObject.Element("GenerateFeats") = "Yes"
                End If

                'caster tab
                If CasterType.SelectedIndex > 0 Then
                    mObject.Element("CasterType") = CasterType.Text
                    mObject.FKElement("CasterSource", SourceBox.Text, "Name", CType(SourceBox.SelectedItem, DataListItem).ObjectGUID)
                    mObject.ElementAsInteger("CasterLevel") = CInt(CasterLevel.Value)
                End If

                'companion tab
                If FamiliarCheck.Checked Then
                    mObject.FKElement("FamiliarClass", FamiliarDropdown.Text, "Name", CType(FamiliarDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                If CompanionCheck.Checked Then
                    mObject.FKElement("CompanionClass", CompanionDropdown.Text, "Name", CType(CompanionDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                If MountCheck.Checked Then
                    mObject.FKElement("MountClass", MountDropdown.Text, "Name", CType(MountDropdown.SelectedItem, DataListItem).ObjectGUID)
                End If

                If NormalMountCheck.Checked Then
                    mObject.Element("NormalMount") = "Yes"
                End If

                'Type Tab
                Dim MonsterClass As Objects.ObjectData = CType(CType(TypeDropdown.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
                mObject.FKElement("MonsterType", TypeDropdown.Text, "Name", CType(TypeDropdown.SelectedItem, DataListItem).ObjectGUID)
                mObject.FKElement("MonsterTypeDisplay", MonsterClass.Element("Abbreviation"), "Abbreviation", CType(TypeDropdown.SelectedItem, DataListItem).ObjectGUID)

                'save the automatic language objects

                'delete the objects no longer required
                For Each Obj In ExistingAutoLanguageObjs
                    If Not AutomaticLanguageObjs.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                'save the new objects
                For Each Obj In AutomaticLanguageObjs
                    If ExistingAutoLanguageObjs.Contains(Obj.ObjectGUID) Then
                        AutomaticLanguageObjs.Remove(Obj.ObjectGUID)
                    End If
                Next
                AutomaticLanguageObjs.Save()

                'save the bonus language objects

                'delete the objects no longer required
                For Each Obj In ExistingBonusLanguageObjs
                    If Not BonusLanguageObjs.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                'save the new objects
                For Each Obj In BonusLanguageObjs
                    If ExistingBonusLanguageObjs.Contains(Obj.ObjectGUID) Then
                        BonusLanguageObjs.Remove(Obj.ObjectGUID)
                    End If
                Next
                BonusLanguageObjs.Save()

                'class skills
                For Each Obj In ExistingClassSkills
                    If Not ClassSkills.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                For Each Obj In ClassSkills
                    If ExistingClassSkills.Contains(Obj.ObjectGUID) Then
                        ClassSkills.Remove(Obj.ObjectGUID)
                    End If
                Next
                ClassSkills.Save()

                'natural weapons
                For Each Obj In ExistingNaturalWeapons
                    If Not NaturalWeapons.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                For Each Obj In NaturalWeapons
                    If ExistingNaturalWeapons.Contains(Obj.ObjectGUID) Then
                        NaturalWeapons.Remove(Obj.ObjectGUID)
                    End If
                Next
                NaturalWeapons.Save()

                'subtypes
                For Each Obj In ExistingSubtypes
                    If Not Subtypes.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                Dim SubTypeString As String = ""

                For Each Obj In Subtypes
                    SubTypeString &= (Obj.Name & ", ")
                    If ExistingSubtypes.Contains(Obj.ObjectGUID) Then
                        Subtypes.Remove(Obj.ObjectGUID)
                    End If
                Next
                Subtypes.Save()
                SubTypeString = SubTypeString.TrimEnd(", ".ToCharArray)
                mObject.Element("Subtypes") = SubTypeString

                'components
                For Each Obj In ExistingComponents
                    If Not CurrentComponents.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                For Each Obj In CurrentComponents
                    If ExistingComponents.Contains(Obj.ObjectGUID) Then
                        CurrentComponents.Remove(Obj.ObjectGUID)
                    End If
                Next
                CurrentComponents.Save()

                'additional caster sources
                For Each Obj In ExistingSpellPowerSources
                    If Not SpellPowerSources.Contains(Obj.ObjectGUID) Then
                        Obj.Delete()
                    End If
                Next

                For Each Obj In SpellPowerSources
                    If ExistingSpellPowerSources.Contains(Obj.ObjectGUID) Then
                        SpellPowerSources.Remove(Obj.ObjectGUID)
                    End If
                Next
                SpellPowerSources.Save()

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

    'updates the ability spin edits as required
    Private Sub UpdateAbilitySpins()
        Try

            'strength
            If GlobalFlags.Strength > 0 OrElse TypeFlags.Strength > 0 Then
                STR.Value = 0
                STR.Enabled = False
            Else
                If STR.Enabled = False Then
                    STR.Enabled = True
                    STR.Value = 10
                Else
                    If STR.Value = 0 Then STR.Value = 10
                End If
            End If

            'dexterity
            If GlobalFlags.Dexterity > 0 OrElse TypeFlags.Dexterity > 0 Then
                DEX.Value = 0
                DEX.Enabled = False
            Else
                If DEX.Enabled = False Then
                    DEX.Enabled = True
                    DEX.Value = 10
                Else
                    If DEX.Value = 0 Then DEX.Value = 10
                End If
            End If

            'constitution
            If GlobalFlags.Constitution > 0 OrElse TypeFlags.Constitution > 0 Then
                CON.Value = 0
                CON.Enabled = False
            Else
                If CON.Enabled = False Then
                    CON.Enabled = True
                    CON.Value = 10
                Else
                    If CON.Value = 0 Then CON.Value = 10
                End If
            End If

            'intelligence
            If GlobalFlags.Intelligence > 0 OrElse TypeFlags.Intelligence > 0 Then
                INT.Value = 0
                INT.Enabled = False
            Else
                If INT.Enabled = False Then
                    INT.Enabled = True
                    INT.Value = 10
                Else
                    If INT.Value = 0 Then INT.Value = 10
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the TypeFlags structure for recording the nonabilities
    Private Sub UpdateNonabilityFlags(ByVal ChildObj As Objects.ObjectData, ByRef FlagCollection As NonabilityFlags, Optional ByVal Value As Integer = 1)
        Try
            Dim DefinitionObject As Objects.ObjectData

            'get the definition
            Select Case ChildObj.Type

                Case Objects.FeatureType
                    DefinitionObject = ChildObj.GetFKObject("Feature")

                Case Else
                    DefinitionObject = ChildObj

            End Select


            For Each AbilityChild As Objects.ObjectData In DefinitionObject.ChildrenOfType(Objects.SystemAbilityType)
                Select Case AbilityChild.GetFKGuid("SystemAbilityDefinition").ToString

                    Case References.StrengthNonability.ToString
                        FlagCollection.Strength += Value

                    Case References.DexterityNonability.ToString
                        FlagCollection.Dexterity += Value

                    Case References.ConstitutionNonability.ToString
                        FlagCollection.Constitution += Value

                    Case References.IntelligenceNonability.ToString
                        FlagCollection.Intelligence += Value

                End Select
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Validation"

    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Basics.Controls, Errors)
            Validate = Validate And General.ValidateForm(CompanionTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(TypeTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(CasterTab.Controls, Errors)

            'alignment validation
            If LawfulGood.Checked = False And LawfulNeutral.Checked = False And LawfulEvil.Checked = False And NeutralGood.Checked = False And TrueNeutral.Checked = False And NeutralEvil.Checked = False And ChaoticGood.Checked = False And ChaoticNeutral.Checked = False And ChaoticEvil.Checked = False Then
                Errors.SetError(NeutralEvil, General.ValidationAtLeast1Required)
                Validate = False
            Else
                Errors.SetError(NeutralEvil, "")
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

#Region "Language Tab"

    'add an automatic language
    Private Sub AddAutomatic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAutomatic.Click
        Dim Obj As Objects.ObjectData
        Try
            If Languages.SelectedIndex <> -1 Then
                Obj = AutomaticLanguageObjs.Item("Language", LanguageIndex(Languages.SelectedIndex).ObjectGUID)

                If Not Obj.IsEmpty Then
                    General.ShowInfoDialog("This is already an automatic language")
                Else
                    Obj = BonusLanguageObjs.Item("Language", LanguageIndex(Languages.SelectedIndex).ObjectGUID)
                    If Not Obj.IsEmpty Then
                        General.ShowInfoDialog("This is a bonus Language. It can't be an automatic language as well")
                    Else
                        Obj = ExistingAutoLanguageObjs.Item("Language", LanguageIndex(Languages.SelectedIndex).ObjectGUID)

                        If Obj.IsEmpty Then
                            'create the object
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            Obj.Name = Languages.Text
                            Obj.Type = Objects.AutomaticLanguageDefinitionType
                            Obj.ParentGUID = mObject.ObjectGUID
                            Obj.FKElement("Language", Languages.Text, "Name", LanguageIndex(Languages.SelectedIndex).ObjectGUID)
                        End If

                        AutomaticLanguageObjs.Add(Obj)
                        AutomaticLanguages.AddItem(Languages.Text, Obj.ObjectGUID)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove and automatic language
    Private Sub RemoveAutomatic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAutomatic.Click
        Try
            If AutomaticLanguages.List.SelectedItem Is Nothing Then Exit Sub
            AutomaticLanguageObjs.Remove(AutomaticLanguages.ItemGUID)
            AutomaticLanguages.RemoveSelectedItem()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'add a bonus language
    Private Sub AddBonus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBonus.Click
        Dim Obj As Objects.ObjectData
        Try
            If Languages.SelectedIndex <> -1 Then
                Obj = BonusLanguageObjs.Item("Language", LanguageIndex(Languages.SelectedIndex).ObjectGUID)

                If Not Obj.IsEmpty Then
                    General.ShowInfoDialog("This is already a bonus language")
                Else
                    Obj = AutomaticLanguageObjs.Item("Language", LanguageIndex(Languages.SelectedIndex).ObjectGUID)
                    If Not Obj.IsEmpty Then
                        General.ShowInfoDialog("This is an automatic Language. It can't be a bonus language as well")
                    Else
                        Obj = ExistingBonusLanguageObjs.Item("Language", LanguageIndex(Languages.SelectedIndex).ObjectGUID)

                        If Obj.IsEmpty Then
                            'create the object
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
                            Obj.Name = Languages.Text
                            Obj.Type = Objects.BonusLanguageDefinitionType
                            Obj.ParentGUID = mObject.ObjectGUID
                            Obj.FKElement("Language", Languages.Text, "Name", LanguageIndex(Languages.SelectedIndex).ObjectGUID)
                        End If

                        BonusLanguageObjs.Add(Obj)
                        BonusLanguages.AddItem(Languages.Text, Obj.ObjectGUID)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove a bonus language
    Private Sub RemoveBonus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBonus.Click
        Try
            If BonusLanguages.List.SelectedItem Is Nothing Then Exit Sub
            BonusLanguageObjs.Remove(BonusLanguages.ItemGUID)
            BonusLanguages.RemoveSelectedItem()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Monster Race Tab"

    'Fly spinedit
    Private Sub SpinEdit4_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fly.EditValueChanged
        If Fly.Value = 0 Then
            ManeuverDropdown.Enabled = False
            ManeuverDropdown.SelectedIndex = -1
        Else
            ManeuverDropdown.Enabled = True
        End If
    End Sub

    'parse input - formating for the movement speed editors
    Private Sub ParseInput(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles Swim.ParseEditValue, Fly.ParseEditValue, Climb.ParseEditValue, Burrow.ParseEditValue, LA.ParseEditValue
        If TypeOf e.Value Is String Then
            If CStr(e.Value) = "-" Then
                e.Value = 0
                e.Handled = True
            Else
                e.Value = CInt(e.Value)
            End If
        End If
    End Sub

    'fractional hitdice override for the Hitdice spin edit - works with Fractional Formatter
    Private Sub HD_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles HD.EditValueChanging
        If Not isLoading Then
            If CInt(e.OldValue) = 1 AndAlso CInt(e.NewValue) = 0 Then
                e.NewValue = 0.5D
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.5 Then
                If CDec(e.NewValue) = 1.5 Then e.NewValue = 1
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.25
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.25 Then
                If CDec(e.NewValue) = 1.25 Then e.NewValue = 0.5
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.125
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.125 Then
                If CDec(e.NewValue) = 1.125 Then e.NewValue = 0.25
            End If

            If CDec(e.NewValue) = 0 Then e.Cancel = True
        End If
    End Sub

    'fractional hitdice override for the Hitdice spin edit - works with Fractional Formatter
    Private Sub CR_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles CR.EditValueChanging

        If Not isLoading Then

            If CInt(e.OldValue) = 1 AndAlso CInt(e.NewValue) = 0 Then
                e.NewValue = 0.5D
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.5 Then
                If CDec(e.NewValue) = 1.5 Then e.NewValue = 1
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.33
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.33 Then
                If CDec(e.NewValue) = 1.33 Then e.NewValue = 0.5
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.25
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.25 Then
                If CDec(e.NewValue) = 1.25 Then e.NewValue = 0.33
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.2
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.2 Then
                If CDec(e.NewValue) = 1.2 Then e.NewValue = 0.25
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.167
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.167 Then
                If CDec(e.NewValue) = 1.167 Then e.NewValue = 0.2
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.143
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.143 Then
                If CDec(e.NewValue) = 1.143 Then e.NewValue = 0.167
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.125
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.125 Then
                If CDec(e.NewValue) = 1.125 Then e.NewValue = 0.143
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.11
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.11 Then
                If CDec(e.NewValue) = 1.11 Then e.NewValue = 0.125
                If CDec(e.NewValue) = 0 Then e.NewValue = 0.1
                Exit Sub
            End If

            If CDec(e.OldValue) = 0.1 Then
                If CDec(e.NewValue) = 1.1 Then e.NewValue = 0.11
            End If

            If CDec(e.NewValue) = 0 Then e.Cancel = True

        End If


    End Sub

    'fractional hitdice override for the Hitdice spin edit - works with Fractional Formatter
    Private Sub Space_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles Space.EditValueChanging
        Try
            If Not isLoading Then
                If CDec(e.OldValue) = 5 AndAlso CDec(e.NewValue) = 0.5 Then
                    e.NewValue = 2.5
                    Exit Sub
                End If

                If CDec(e.OldValue) = 2.5 Then
                    If CDec(e.NewValue) = 0.5 Then e.NewValue = 1
                    If CDec(e.NewValue) = 7.5 Then e.NewValue = 5
                    Exit Sub
                End If

                If CDec(e.OldValue) = 1 Then
                    If CDec(e.NewValue) = 0.5 Then e.NewValue = 0.5
                    If CDec(e.NewValue) = 6 Then e.NewValue = 2.5
                    Exit Sub
                End If

                If CDec(e.OldValue) = 0.5 Then
                    If CDec(e.NewValue) = 5.5 Then e.NewValue = 1
                End If

                If CDec(e.NewValue) = 0 Then e.Cancel = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'sets the default space and reach if required
    Private Sub RaceSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RaceSize.SelectedIndexChanged
        Try
            Dim ExistingFlag As Boolean = isLoading

            isLoading = True
            If mMode = FormMode.Add Then
                Select Case RaceSize.Text
                    Case "Fine"
                        Space.Value = 0.5D
                        Reach.Value = 0
                    Case "Diminutive"
                        Space.Value = 1
                        Reach.Value = 0
                    Case "Tiny"
                        Space.Value = 2.5D
                        Reach.Value = 0
                    Case "Small"
                        Space.Value = 5
                        Reach.Value = 5
                    Case "Medium"
                        Space.Value = 5
                        Reach.Value = 5
                    Case "Large"
                        If NonhumanoidCheck.Checked Then
                            Space.Value = 10
                            Reach.Value = 5
                        Else
                            Space.Value = 10
                            Reach.Value = 10
                        End If
                    Case "Huge"
                        If NonhumanoidCheck.Checked Then
                            Space.Value = 15
                            Reach.Value = 10
                        Else
                            Space.Value = 15
                            Reach.Value = 15
                        End If
                    Case "Gargantuan"
                        If NonhumanoidCheck.Checked Then
                            Space.Value = 20
                            Reach.Value = 15
                        Else
                            Space.Value = 20
                            Reach.Value = 20
                        End If
                    Case "Colossal"
                        If NonhumanoidCheck.Checked Then
                            Space.Value = 30
                            Reach.Value = 20
                        Else
                            Space.Value = 30
                            Reach.Value = 30
                        End If
                End Select
            End If
            isLoading = ExistingFlag

        Catch ex As Exception
            isLoading = False
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get a list of existing values in use for the element
    Private Function GetExistingValues(ByVal ElementName As String) As ArrayList
        Try
            Dim Values As New ArrayList
            Dim Nodes As System.Xml.XmlNodeList = XML.SelectNodes(XML.DBTypes.MonsterRaces, "/RPGXplorerDatabase/RPGXplorerObject/" & ElementName)

            For Each Node As System.Xml.XmlNode In Nodes
                If Not Values.Contains(Node.InnerText) Then Values.Add(Node.InnerText)
            Next

            Values.Sort()
            Return Values

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Companion Tab"

    Private Sub FamiliarCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamiliarCheck.CheckedChanged
        If FamiliarCheck.Checked Then
            FamiliarDropdown.Enabled = True
        Else
            FamiliarDropdown.SelectedIndex = -1
            FamiliarDropdown.Enabled = False
        End If
    End Sub

    Private Sub CompanionCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanionCheck.CheckedChanged
        If CompanionCheck.Checked Then
            CompanionDropdown.Enabled = True
        Else
            CompanionDropdown.SelectedIndex = -1
            CompanionDropdown.Enabled = False
        End If
    End Sub

    Private Sub MountCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MountCheck.CheckedChanged
        If MountCheck.Checked Then
            MountDropdown.Enabled = True
        Else
            MountDropdown.SelectedIndex = -1
            MountDropdown.Enabled = False
        End If
    End Sub

#End Region

#Region "Type Tab"

    'changes the creatures type - also adds the features from the first level of the type class
    Private Sub TypeDropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeDropdown.SelectedIndexChanged
        Try

            If TypeDropdown.Text <> "" Then

                Dim TypeObj As New Objects.ObjectData
                TypeObj.Load(CType(TypeDropdown.SelectedItem, DataListItem).ObjectGUID)

                If isLoading = True Then Exit Sub

                'delete previous components                
                Dim DeleteObjectList As New Objects.ObjectDataCollection
                For Each TempObj As Objects.ObjectData In CurrentComponents
                    If TempObj.GetFKGuid("Source").Equals(OldType) Then
                        DeleteObjectList.Add(TempObj)

                        'if it has any system ability children - update the nonability flags
                        UpdateNonabilityFlags(TempObj, TypeFlags, -1)

                    End If
                Next
                CurrentComponents.RemoveList(DeleteObjectList)

                'add new components                                            
                Dim TypeLevelsFolder As Objects.ObjectData = TypeObj.FirstChildOfType(Objects.MonsterClassLevelsFolderType)
                If Not TypeLevelsFolder.IsEmpty Then
                    'find the first class level
                    Dim ClassLevels As Objects.ObjectDataCollection = TypeLevelsFolder.Children
                    Dim FirstClassLevel As New Objects.ObjectData

                    For Each TempObj As Objects.ObjectData In ClassLevels
                        If TempObj.Element("Level") = "1" Then
                            FirstClassLevel = TempObj
                            Exit For
                        End If
                    Next

                    If Not FirstClassLevel.IsEmpty Then
                        For Each Child As Objects.ObjectData In FirstClassLevel.Children

                            Select Case Child.Type
                                Case Objects.FeatureType, Objects.SpecificBonusFeatType, Objects.SpecificBonusFeatChooseFocusType
                                    Dim ClonedChildAndChildren As Objects.ObjectDataCollection = Child.Clone(mObject)
                                    For Each TempObj As Objects.ObjectData In ClonedChildAndChildren
                                        TempObj.FKElement("Source", TypeDropdown.Text, "Name", TypeObj.ObjectGUID)
                                        UpdateNonabilityFlags(TempObj, TypeFlags)
                                        CurrentComponents.Add(TempObj)
                                    Next
                            End Select

                        Next
                    End If

                End If

                'reset oldtype
                OldType = TypeObj.ObjectGUID

            Else

                'delete previous components
                Dim DeleteObjectList As New Objects.ObjectDataCollection
                For Each TempObj As Objects.ObjectData In CurrentComponents
                    If TempObj.GetFKGuid("Source").Equals(OldType) Then
                        DeleteObjectList.Add(TempObj)
                        'if it has any system ability children - update the nonability flags
                        UpdateNonabilityFlags(TempObj, TypeFlags, -1)
                    End If
                Next
                CurrentComponents.RemoveList(DeleteObjectList)

                'reset oldtype
                OldType = Objects.ObjectKey.Empty

            End If

            'update the ability spins
            UpdateAbilitySpins()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'adds a subtype to the creature
    Private Sub AddSubtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubtype.Click
        Try

            Dim Obj As New Objects.ObjectData
            Dim ObjGuid As Objects.ObjectKey

            If SubtypeDropdown.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select something to add.")
                Exit Sub
            End If

            ObjGuid = CType(SubtypeDropdown.SelectedItem, DataListItem).ObjectGUID
            If Subtypes.ContainsFK("Subtype", ObjGuid) Then
                General.ShowInfoDialog("This Subtype has already been added.")
                Exit Sub
            End If

            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
            Obj.ParentGUID = mObject.ObjectGUID
            Obj.Type = Objects.SubtypeType
            Obj.FKElement("Subtype", SubtypeDropdown.Text, "Name", ObjGuid)

            'add the extra components to the race?
            Dim SubTypeObj As New Objects.ObjectData
            SubTypeObj.Load(ObjGuid)
            For Each Child As Objects.ObjectData In SubTypeObj.Children
                Dim ClonedChildAndChildren As Objects.ObjectDataCollection = Child.Clone(mObject)
                For Each TempObj As Objects.ObjectData In ClonedChildAndChildren
                    TempObj.FKElement("Source", SubtypeDropdown.Text, "Name", ObjGuid)
                    'if it has any system ability children - update the nonability flags
                    UpdateNonabilityFlags(TempObj, TypeFlags)
                    CurrentComponents.Add(TempObj)
                Next
            Next

            SubtypeList.AddItem(Obj.Name, Obj.ObjectGUID)
            Subtypes.Add(Obj)

            'update the ability spins
            UpdateAbilitySpins()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'removes a subtype from the creature
    Private Sub RemoveSubtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSubtype.Click
        Try
            If SubtypeList.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a subtype to remove.")
                Exit Sub
            Else
                'get subtype object
                Dim SubTypeObj As Objects.ObjectData
                SubTypeObj = Subtypes.Item(SubtypeList.ItemGUID()).GetFKObject("Subtype")

                'remove all components from current list with a FK to this source
                Dim DeleteObjectList As New Objects.ObjectDataCollection
                For Each TempObj As Objects.ObjectData In CurrentComponents
                    If TempObj.GetFKGuid("Source").Equals(SubTypeObj.ObjectGUID) Then
                        DeleteObjectList.Add(TempObj)
                        'if it has any system ability children - update the nonability flags
                        UpdateNonabilityFlags(TempObj, TypeFlags, -1)
                    End If
                Next
                CurrentComponents.RemoveList(DeleteObjectList)

                Subtypes.Remove(SubtypeList.ItemGUID())
                SubtypeList.RemoveSelectedItem()

                'update the ability spins
                UpdateAbilitySpins()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'enables the quadruped optipn
    Private Sub NonhumanoidCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NonhumanoidCheck.CheckedChanged
        Try
            If NonhumanoidCheck.Checked Then
                QuadCheck.Enabled = True
            Else
                QuadCheck.Enabled = False
                QuadCheck.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Weapon Tab"

    Private Sub AddWeapon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddWeapon.Click
        Try

            Dim Obj As New Objects.ObjectData
            Dim ObjGuid As Objects.ObjectKey

            If WeaponDropdown.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select something to add.")
                Exit Sub
            End If

            ObjGuid = CType(WeaponDropdown.SelectedItem, DataListItem).ObjectGUID
            If NaturalWeapons.ContainsFK("Weapon", ObjGuid) Then
                General.ShowInfoDialog("This Weapon has already been added.")
                Exit Sub
            End If

            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
            Obj.ParentGUID = mObject.ObjectGUID
            Obj.Type = Objects.NaturalWeaponType
            Obj.FKElement("Weapon", WeaponDropdown.Text, "Name", ObjGuid)

            WeaponsList.AddItem(Obj.Name, Obj.ObjectGUID)
            NaturalWeapons.Add(Obj)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveWeapon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveWeapon.Click
        Try
            If WeaponsList.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a weapon to remove.")
                Exit Sub
            Else
                NaturalWeapons.Remove(WeaponsList.ItemGUID())
                WeaponsList.RemoveSelectedItem()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Skills Tab"

    'add a class skill to the monster
    Private Sub AddSkill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSkill.Click
        Try
            Dim Obj As New Objects.ObjectData
            Dim ObjGuid As Objects.ObjectKey

            If SkillDropdown.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select something to add.")
                Exit Sub
            End If

            ObjGuid = CType(SkillDropdown.SelectedItem, DataListItem).ObjectGUID
            If ClassSkills.ContainsFK("Skill", ObjGuid) Then
                General.ShowInfoDialog("This Skill has already been added.")
                Exit Sub
            End If

            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(mObject.ObjectGUID.Database)
            Obj.ParentGUID = mObject.ObjectGUID
            Obj.Type = Objects.ClassSkillType
            Obj.Element("Ranks") = Ranks.EditValue.ToString
            Obj.FKElement("Skill", SkillDropdown.Text, "Name", ObjGuid)

            LevelListBox.AddItem(Obj.Name, Obj.ObjectGUID)
            ClassSkills.Add(Obj)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'remove a class skill from the monster
    Private Sub RemoveSkill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSkill.Click
        Try
            If LevelListBox.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a skill to remove.")
                Exit Sub
            Else
                ClassSkills.Remove(LevelListBox.ItemGUID())
                LevelListBox.RemoveSelectedItem()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Caster Tab"

    Private Sub CasterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasterType.SelectedIndexChanged
        Try

            SourceBox.Properties.Items.Clear()
            SourceBox.SelectedIndex = -1

            SpellSourceDropdown.Properties.Items.Clear()
            SpellSourceDropdown.SelectedIndex = -1

            SourcesList.Clear()
            SpellPowerSources.Clear()

            If CasterType.SelectedIndex > 0 Then

                SourceBox.Enabled = True
                CasterLevel.Enabled = True
                SpellSourceDropdown.Enabled = True
                AddSource.Enabled = True
                RemoveSource.Enabled = True
                SourcesList.Enabled = True

                If CasterType.SelectedIndex = 1 Then
                    'add (spells known) spellcasters                  
                    SourceBox.Properties.Items.AddRange(SpellcastersList)
                    SpellSourceDropdown.Properties.Items.AddRange(SpellSourcesList)
                Else
                    'add manifesters
                    SourceBox.Properties.Items.AddRange(ManifestersList)
                    SpellSourceDropdown.Properties.Items.AddRange(PowerSourcesList)
                End If
            Else
                SourceBox.Enabled = False
                CasterLevel.Enabled = False
                SpellSourceDropdown.Enabled = False
                AddSource.Enabled = False
                RemoveSource.Enabled = False
                SourcesList.Enabled = False

                CasterLevel.Value = 1
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    Private Sub SourceBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceBox.SelectedIndexChanged
        Try

            If SourceBox.SelectedIndex <> -1 Then

                'get the class guid
                Dim ClassGuid As Objects.ObjectKey = CType(SourceBox.SelectedItem, DataListItem).ObjectGUID

                'get the caster level
                Dim CL As Integer = CInt(CasterLevels.Item(ClassGuid))
                CasterLevel.Properties.MaxValue = CL

                SpellSourceDropdown.Properties.Items.Clear()

                Select Case CasterType.SelectedIndex
                    Case 1 'caster
                        SpellSourceDropdown.Properties.Items.AddRange(SpellSourcesList)

                    Case 2 'manifester
                        SpellSourceDropdown.Properties.Items.AddRange(PowerSourcesList)
                End Select

                'updates the souce dropdown
                If SpellSourceDropdown.Properties.Items.Contains(SourceBox.SelectedItem) Then
                    SpellSourceDropdown.Properties.Items.Remove(SourceBox.SelectedItem)
                End If

                'updates the dropdown if required
                If SpellSourceDropdown.SelectedIndex = -1 Then SpellSourceDropdown.SelectedIndex = -1

                'check for and remove self from sourceslist
                For Each SourceObj As Objects.ObjectData In SourcesList.GetObjects()
                    If SourceObj.GetFKGuid("Source").Equals(ClassGuid) Then
                        SourcesList.RemoveItem(SourceObj.ObjectGUID)
                        SpellPowerSources.Remove(SourceObj.ObjectGUID)
                        Exit For
                    End If
                Next

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AddSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSource.Click
        Try
            Dim Obj As Objects.ObjectData
            Dim SourceGuid As Objects.ObjectKey

            If SpellSourceDropdown.SelectedIndex <> -1 Then

                SourceGuid = CType(SpellSourceDropdown.SelectedItem, DataListItem).ObjectGUID

                Select Case CasterType.SelectedIndex

                    Case 1 'spellcaster

                        Obj = SpellPowerSources.Item("Source", SourceGuid)
                        If Not Obj.IsEmpty Then
                            General.ShowInfoDialog("This spell source is already added")
                            Exit Sub
                        Else
                            Obj = ExistingSpellPowerSources.Item("Source", SourceGuid)
                        End If

                    Case 2 'manifester

                        Obj = SpellPowerSources.Item("Source", SourceGuid)
                        If Not Obj.IsEmpty Then
                            General.ShowInfoDialog("This power source is already added")
                            Exit Sub
                        Else
                            Obj = ExistingSpellPowerSources.Item("Source", SourceGuid)
                        End If

                    Case Else
                        Exit Sub

                End Select

                If Obj.IsEmpty Then
                    'create the object
                    Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.MonsterRaces)
                    Obj.Name = SpellSourceDropdown.Text
                    Obj.Type = Objects.SpellorPowerSourceType
                    Obj.ParentGUID = mObject.ObjectGUID

                    Obj.FKElement("Source", SpellSourceDropdown.Text, "Name", SourceGuid)
                End If

                SpellPowerSources.Add(Obj)
                SourcesList.AddItem(Obj)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSource.Click
        Try

            If SourcesList.SelectedIndex = -1 Then
                General.ShowInfoDialog("Please select a source to remove.")
                Exit Sub
            Else
                SpellPowerSources.Remove(SourcesList.ItemGUID())
                SourcesList.RemoveSelectedItem()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class