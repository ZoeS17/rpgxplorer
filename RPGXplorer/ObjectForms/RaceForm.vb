Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules.Dice

Public Class RaceForm
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
    Public WithEvents FavouredClass As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents RaceSize As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Basics As System.Windows.Forms.TabPage
    Public WithEvents CHA As RPGXplorer.Modifier
    Public WithEvents WIS As RPGXplorer.Modifier
    Public WithEvents INT As RPGXplorer.Modifier
    Public WithEvents CON As RPGXplorer.Modifier
    Public WithEvents DEX As RPGXplorer.Modifier
    Public WithEvents STR As RPGXplorer.Modifier
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents LanguageTab As System.Windows.Forms.TabPage
    Public WithEvents Languages As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents RemoveBonus As System.Windows.Forms.Button
    Public WithEvents AddBonus As System.Windows.Forms.Button
    Public WithEvents BonusLanguages As RPGXplorer.ListBox
    Public WithEvents RemoveAutomatic As System.Windows.Forms.Button
    Public WithEvents AddAutomatic As System.Windows.Forms.Button
    Public WithEvents AutomaticLanguages As RPGXplorer.ListBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents RaceTabControl As System.Windows.Forms.TabControl
    Public WithEvents HeightAndWeightTab As System.Windows.Forms.TabPage
    Public WithEvents MaleHeightRange As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents FemaleHeightRange As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents FemaleWeightMultiplier As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents MaleWeightMultiplier As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Speed As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents BonusSkillPoints As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents FavouredClassCheck As System.Windows.Forms.CheckBox
    Public WithEvents MaleWeight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MaleHeightBase As DevExpress.XtraEditors.SpinEdit
    Public WithEvents FemaleWeight As DevExpress.XtraEditors.SpinEdit
    Public WithEvents FemaleHeightBase As DevExpress.XtraEditors.SpinEdit
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents EquivDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents LA As RPGXplorer.Modifier
    Public WithEvents IndentedLine6 As RPGXplorer.IndentedLine
    Public WithEvents ManeuverDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Fly As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Swim As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Burrow As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Climb As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents IndentedLine7 As RPGXplorer.IndentedLine
    Public WithEvents NA As RPGXplorer.Modifier
    Public WithEvents Label56 As System.Windows.Forms.Label
    Public WithEvents MonsterTab As System.Windows.Forms.TabPage
    Public WithEvents Label60 As System.Windows.Forms.Label
    Public WithEvents Label61 As System.Windows.Forms.Label
    Public WithEvents CrossClassList As RPGXplorer.ListBox
    Public WithEvents ClassSkillChoiceList As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents EditChoicesButton As System.Windows.Forms.Button
    Public WithEvents Reach As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Space As DevExpress.XtraEditors.SpinEdit
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents IndentedLine9 As RPGXplorer.IndentedLine
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents Label52 As System.Windows.Forms.Label
    Public WithEvents Label58 As System.Windows.Forms.Label
    Public WithEvents StartAge3 As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents Label57 As System.Windows.Forms.Label
    Public WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents StartAge2 As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label53 As System.Windows.Forms.Label
    Public WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents StartAge1 As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents MaximumAge As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Venerable As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents OldAge As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents MiddleAge As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Adulthood As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents TypeTab As System.Windows.Forms.TabPage
    Public WithEvents MonsterClass As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SubtypeDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents IndentedLine8 As RPGXplorer.IndentedLine
    Public WithEvents SubtypeList As RPGXplorer.ListBox
    Public WithEvents RemoveSubtype As System.Windows.Forms.Button
    Public WithEvents AddSubtype As System.Windows.Forms.Button
    Public WithEvents Label64 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents Label67 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents QuadCheck As System.Windows.Forms.CheckBox
    Public WithEvents NonhumanoidCheck As System.Windows.Forms.CheckBox
    Public WithEvents IndentedLine10 As RPGXplorer.IndentedLine
    Public WithEvents StartingLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents MonsterLAbel As System.Windows.Forms.Label
    Public WithEvents MonsterCheck As System.Windows.Forms.CheckBox
    Public WithEvents WeaponsTab As System.Windows.Forms.TabPage
    Public WithEvents WeaponDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents WeaponsList As RPGXplorer.ListBox
    Public WithEvents RemoveWeapon As System.Windows.Forms.Button
    Public WithEvents AddWeapon As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RaceForm))
        Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FemaleHeightRange = New DevExpress.XtraEditors.TextEdit
        Me.MaleWeightMultiplier = New DevExpress.XtraEditors.TextEdit
        Me.FemaleWeightMultiplier = New DevExpress.XtraEditors.TextEdit
        Me.MaleHeightRange = New DevExpress.XtraEditors.TextEdit
        Me.Speed = New DevExpress.XtraEditors.SpinEdit
        Me.OK = New System.Windows.Forms.Button
        Me.Fly = New DevExpress.XtraEditors.SpinEdit
        Me.Swim = New DevExpress.XtraEditors.SpinEdit
        Me.Burrow = New DevExpress.XtraEditors.SpinEdit
        Me.Climb = New DevExpress.XtraEditors.SpinEdit
        Me.Reach = New DevExpress.XtraEditors.SpinEdit
        Me.Space = New DevExpress.XtraEditors.SpinEdit
        Me.StartAge3 = New DevExpress.XtraEditors.TextEdit
        Me.StartAge2 = New DevExpress.XtraEditors.TextEdit
        Me.StartAge1 = New DevExpress.XtraEditors.TextEdit
        Me.MaximumAge = New DevExpress.XtraEditors.TextEdit
        Me.Venerable = New DevExpress.XtraEditors.TextEdit
        Me.OldAge = New DevExpress.XtraEditors.TextEdit
        Me.MiddleAge = New DevExpress.XtraEditors.TextEdit
        Me.Adulthood = New DevExpress.XtraEditors.TextEdit
        Me.Cancel = New System.Windows.Forms.Button
        Me.RaceTabControl = New System.Windows.Forms.TabControl
        Me.Basics = New System.Windows.Forms.TabPage
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.FavouredClass = New DevExpress.XtraEditors.ComboBoxEdit
        Me.NA = New RPGXplorer.Modifier
        Me.Label56 = New System.Windows.Forms.Label
        Me.IndentedLine7 = New RPGXplorer.IndentedLine
        Me.ManeuverDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.IndentedLine6 = New RPGXplorer.IndentedLine
        Me.LA = New RPGXplorer.Modifier
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.EquivDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.FavouredClassCheck = New System.Windows.Forms.CheckBox
        Me.BonusSkillPoints = New DevExpress.XtraEditors.SpinEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.Label10 = New System.Windows.Forms.Label
        Me.CHA = New RPGXplorer.Modifier
        Me.WIS = New RPGXplorer.Modifier
        Me.INT = New RPGXplorer.Modifier
        Me.CON = New RPGXplorer.Modifier
        Me.DEX = New RPGXplorer.Modifier
        Me.STR = New RPGXplorer.Modifier
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
        Me.WeaponsTab = New System.Windows.Forms.TabPage
        Me.WeaponDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label65 = New System.Windows.Forms.Label
        Me.RemoveWeapon = New System.Windows.Forms.Button
        Me.AddWeapon = New System.Windows.Forms.Button
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.WeaponsList = New RPGXplorer.ListBox
        Me.TypeTab = New System.Windows.Forms.TabPage
        Me.StartingLevel = New DevExpress.XtraEditors.SpinEdit
        Me.MonsterLAbel = New System.Windows.Forms.Label
        Me.MonsterCheck = New System.Windows.Forms.CheckBox
        Me.QuadCheck = New System.Windows.Forms.CheckBox
        Me.NonhumanoidCheck = New System.Windows.Forms.CheckBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.SubtypeDropdown = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label54 = New System.Windows.Forms.Label
        Me.RemoveSubtype = New System.Windows.Forms.Button
        Me.AddSubtype = New System.Windows.Forms.Button
        Me.MonsterClass = New DevExpress.XtraEditors.ComboBoxEdit
        Me.IndentedLine10 = New RPGXplorer.IndentedLine
        Me.IndentedLine8 = New RPGXplorer.IndentedLine
        Me.SubtypeList = New RPGXplorer.ListBox
        Me.MonsterTab = New System.Windows.Forms.TabPage
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.ClassSkillChoiceList = New DevExpress.XtraEditors.ListBoxControl
        Me.EditChoicesButton = New System.Windows.Forms.Button
        Me.CrossClassList = New RPGXplorer.ListBox
        Me.HeightAndWeightTab = New System.Windows.Forms.TabPage
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.FemaleWeight = New DevExpress.XtraEditors.SpinEdit
        Me.FemaleHeightBase = New DevExpress.XtraEditors.SpinEdit
        Me.MaleWeight = New DevExpress.XtraEditors.SpinEdit
        Me.MaleHeightBase = New DevExpress.XtraEditors.SpinEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.IndentedLine4 = New RPGXplorer.IndentedLine
        Me.IndentedLine9 = New RPGXplorer.IndentedLine
        Me.IndentedLine5 = New RPGXplorer.IndentedLine
        Me.LanguageTab = New System.Windows.Forms.TabPage
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label15 = New System.Windows.Forms.Label
        Me.RemoveBonus = New System.Windows.Forms.Button
        Me.AddBonus = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.RemoveAutomatic = New System.Windows.Forms.Button
        Me.AddAutomatic = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Languages = New DevExpress.XtraEditors.ComboBoxEdit
        Me.BonusLanguages = New RPGXplorer.ListBox
        Me.AutomaticLanguages = New RPGXplorer.ListBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FemaleHeightRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaleWeightMultiplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FemaleWeightMultiplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaleHeightRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Speed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Swim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Burrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Climb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Space.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartAge3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartAge2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartAge1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximumAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venerable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OldAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiddleAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Adulthood.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RaceTabControl.SuspendLayout()
        Me.Basics.SuspendLayout()
        CType(Me.FavouredClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManeuverDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquivDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonusSkillPoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaceSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WeaponsTab.SuspendLayout()
        CType(Me.WeaponDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TypeTab.SuspendLayout()
        CType(Me.StartingLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubtypeDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonsterClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MonsterTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassSkillChoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeightAndWeightTab.SuspendLayout()
        CType(Me.FemaleWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FemaleHeightBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaleWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaleHeightBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LanguageTab.SuspendLayout()
        CType(Me.Languages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'FemaleHeightRange
        '
        Me.FemaleHeightRange.CausesValidation = False
        Me.Errors.SetIconPadding(Me.FemaleHeightRange, 40)
        Me.FemaleHeightRange.Location = New System.Drawing.Point(160, 45)
        Me.FemaleHeightRange.Name = "FemaleHeightRange"
        Me.FemaleHeightRange.Properties.Appearance.Options.UseTextOptions = True
        Me.FemaleHeightRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FemaleHeightRange.Properties.AutoHeight = False
        Me.FemaleHeightRange.Properties.MaxLength = 50
        Me.FemaleHeightRange.Size = New System.Drawing.Size(50, 21)
        Me.FemaleHeightRange.TabIndex = 1
        '
        'MaleWeightMultiplier
        '
        Me.MaleWeightMultiplier.CausesValidation = False
        Me.Errors.SetIconPadding(Me.MaleWeightMultiplier, 25)
        Me.MaleWeightMultiplier.Location = New System.Drawing.Point(230, 185)
        Me.MaleWeightMultiplier.Name = "MaleWeightMultiplier"
        Me.MaleWeightMultiplier.Properties.Appearance.Options.UseTextOptions = True
        Me.MaleWeightMultiplier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaleWeightMultiplier.Properties.AutoHeight = False
        Me.MaleWeightMultiplier.Properties.MaxLength = 50
        Me.MaleWeightMultiplier.Size = New System.Drawing.Size(50, 21)
        Me.MaleWeightMultiplier.TabIndex = 7
        '
        'FemaleWeightMultiplier
        '
        Me.FemaleWeightMultiplier.CausesValidation = False
        Me.Errors.SetIconPadding(Me.FemaleWeightMultiplier, 25)
        Me.FemaleWeightMultiplier.Location = New System.Drawing.Point(230, 75)
        Me.FemaleWeightMultiplier.Name = "FemaleWeightMultiplier"
        Me.FemaleWeightMultiplier.Properties.Appearance.Options.UseTextOptions = True
        Me.FemaleWeightMultiplier.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FemaleWeightMultiplier.Properties.AutoHeight = False
        Me.FemaleWeightMultiplier.Properties.MaxLength = 50
        Me.FemaleWeightMultiplier.Size = New System.Drawing.Size(50, 21)
        Me.FemaleWeightMultiplier.TabIndex = 3
        '
        'MaleHeightRange
        '
        Me.MaleHeightRange.CausesValidation = False
        Me.Errors.SetIconPadding(Me.MaleHeightRange, 40)
        Me.MaleHeightRange.Location = New System.Drawing.Point(160, 155)
        Me.MaleHeightRange.Name = "MaleHeightRange"
        Me.MaleHeightRange.Properties.Appearance.Options.UseTextOptions = True
        Me.MaleHeightRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaleHeightRange.Properties.AutoHeight = False
        Me.MaleHeightRange.Properties.MaxLength = 50
        Me.MaleHeightRange.Size = New System.Drawing.Size(50, 21)
        Me.MaleHeightRange.TabIndex = 5
        '
        'Speed
        '
        Me.Speed.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Speed, 20)
        Me.Speed.Location = New System.Drawing.Point(60, 235)
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
        Me.Speed.TabIndex = 11
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(280, 595)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'Fly
        '
        Me.Fly.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Fly, 20)
        Me.Fly.Location = New System.Drawing.Point(60, 295)
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
        Me.Fly.TabIndex = 15
        '
        'Swim
        '
        Me.Swim.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Swim, 20)
        Me.Swim.Location = New System.Drawing.Point(60, 265)
        Me.Swim.Name = "Swim"
        Me.Swim.Properties.Appearance.Options.UseTextOptions = True
        Me.Swim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Swim.Properties.AutoHeight = False
        Me.Swim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Swim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Swim.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Swim.Properties.IsFloatValue = False
        Me.Swim.Properties.Mask.EditMask = "999"
        Me.Swim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Swim.Properties.Mask.ShowPlaceHolders = False
        Me.Swim.Properties.MaxValue = New Decimal(New Integer() {995, 0, 0, 0})
        Me.Swim.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Swim.Size = New System.Drawing.Size(55, 21)
        Me.Swim.TabIndex = 13
        '
        'Burrow
        '
        Me.Burrow.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Burrow, 20)
        Me.Burrow.Location = New System.Drawing.Point(185, 265)
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
        Me.Burrow.TabIndex = 14
        '
        'Climb
        '
        Me.Climb.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Climb, 20)
        Me.Climb.Location = New System.Drawing.Point(185, 235)
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
        Me.Climb.TabIndex = 12
        '
        'Reach
        '
        Me.Reach.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Reach, 20)
        Me.Reach.Location = New System.Drawing.Point(335, 205)
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
        Me.Reach.TabIndex = 10
        '
        'Space
        '
        Me.Space.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Errors.SetIconPadding(Me.Space, 20)
        Me.Space.Location = New System.Drawing.Point(220, 205)
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
        Me.Space.TabIndex = 9
        '
        'StartAge3
        '
        Me.StartAge3.CausesValidation = False
        Me.Errors.SetIconPadding(Me.StartAge3, 25)
        Me.StartAge3.Location = New System.Drawing.Point(210, 355)
        Me.StartAge3.Name = "StartAge3"
        Me.StartAge3.Properties.Appearance.Options.UseTextOptions = True
        Me.StartAge3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartAge3.Properties.AutoHeight = False
        Me.StartAge3.Properties.MaxLength = 5
        Me.StartAge3.Size = New System.Drawing.Size(50, 21)
        Me.StartAge3.TabIndex = 11
        '
        'StartAge2
        '
        Me.StartAge2.CausesValidation = False
        Me.Errors.SetIconPadding(Me.StartAge2, 25)
        Me.StartAge2.Location = New System.Drawing.Point(210, 325)
        Me.StartAge2.Name = "StartAge2"
        Me.StartAge2.Properties.Appearance.Options.UseTextOptions = True
        Me.StartAge2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartAge2.Properties.AutoHeight = False
        Me.StartAge2.Properties.MaxLength = 5
        Me.StartAge2.Size = New System.Drawing.Size(50, 21)
        Me.StartAge2.TabIndex = 10
        '
        'StartAge1
        '
        Me.StartAge1.CausesValidation = False
        Me.Errors.SetIconPadding(Me.StartAge1, 25)
        Me.StartAge1.Location = New System.Drawing.Point(210, 295)
        Me.StartAge1.Name = "StartAge1"
        Me.StartAge1.Properties.Appearance.Options.UseTextOptions = True
        Me.StartAge1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartAge1.Properties.AutoHeight = False
        Me.StartAge1.Properties.MaxLength = 5
        Me.StartAge1.Size = New System.Drawing.Size(50, 21)
        Me.StartAge1.TabIndex = 9
        '
        'MaximumAge
        '
        Me.MaximumAge.CausesValidation = False
        Me.Errors.SetIconPadding(Me.MaximumAge, 25)
        Me.MaximumAge.Location = New System.Drawing.Point(90, 500)
        Me.MaximumAge.Name = "MaximumAge"
        Me.MaximumAge.Properties.Appearance.Options.UseTextOptions = True
        Me.MaximumAge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaximumAge.Properties.AutoHeight = False
        Me.MaximumAge.Properties.MaxLength = 6
        Me.MaximumAge.Size = New System.Drawing.Size(50, 21)
        Me.MaximumAge.TabIndex = 15
        '
        'Venerable
        '
        Me.Venerable.CausesValidation = False
        Me.Errors.SetIconPadding(Me.Venerable, 25)
        Me.Venerable.Location = New System.Drawing.Point(90, 470)
        Me.Venerable.Name = "Venerable"
        Me.Venerable.Properties.Appearance.Options.UseTextOptions = True
        Me.Venerable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Venerable.Properties.AutoHeight = False
        Me.Venerable.Properties.MaxLength = 5
        Me.Venerable.Size = New System.Drawing.Size(50, 21)
        Me.Venerable.TabIndex = 14
        '
        'OldAge
        '
        Me.OldAge.CausesValidation = False
        Me.Errors.SetIconPadding(Me.OldAge, 25)
        Me.OldAge.Location = New System.Drawing.Point(90, 440)
        Me.OldAge.Name = "OldAge"
        Me.OldAge.Properties.Appearance.Options.UseTextOptions = True
        Me.OldAge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OldAge.Properties.AutoHeight = False
        Me.OldAge.Properties.MaxLength = 5
        Me.OldAge.Size = New System.Drawing.Size(50, 21)
        Me.OldAge.TabIndex = 13
        '
        'MiddleAge
        '
        Me.MiddleAge.CausesValidation = False
        Me.Errors.SetIconPadding(Me.MiddleAge, 25)
        Me.MiddleAge.Location = New System.Drawing.Point(90, 410)
        Me.MiddleAge.Name = "MiddleAge"
        Me.MiddleAge.Properties.Appearance.Options.UseTextOptions = True
        Me.MiddleAge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MiddleAge.Properties.AutoHeight = False
        Me.MiddleAge.Properties.MaxLength = 5
        Me.MiddleAge.Size = New System.Drawing.Size(50, 21)
        Me.MiddleAge.TabIndex = 12
        '
        'Adulthood
        '
        Me.Adulthood.CausesValidation = False
        Me.Errors.SetIconPadding(Me.Adulthood, 25)
        Me.Adulthood.Location = New System.Drawing.Point(80, 265)
        Me.Adulthood.Name = "Adulthood"
        Me.Adulthood.Properties.Appearance.Options.UseTextOptions = True
        Me.Adulthood.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Adulthood.Properties.AutoHeight = False
        Me.Adulthood.Properties.MaxLength = 5
        Me.Adulthood.Size = New System.Drawing.Size(50, 21)
        Me.Adulthood.TabIndex = 8
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 595)
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
        Me.RaceTabControl.Controls.Add(Me.WeaponsTab)
        Me.RaceTabControl.Controls.Add(Me.TypeTab)
        Me.RaceTabControl.Controls.Add(Me.MonsterTab)
        Me.RaceTabControl.Controls.Add(Me.HeightAndWeightTab)
        Me.RaceTabControl.Controls.Add(Me.LanguageTab)
        Me.RaceTabControl.Controls.Add(Me.TabPage1)
        Me.RaceTabControl.Location = New System.Drawing.Point(15, 15)
        Me.RaceTabControl.Name = "RaceTabControl"
        Me.RaceTabControl.SelectedIndex = 0
        Me.RaceTabControl.Size = New System.Drawing.Size(415, 565)
        Me.RaceTabControl.TabIndex = 0
        '
        'Basics
        '
        Me.Basics.Controls.Add(Me.Reach)
        Me.Basics.Controls.Add(Me.Label62)
        Me.Basics.Controls.Add(Me.Space)
        Me.Basics.Controls.Add(Me.Label63)
        Me.Basics.Controls.Add(Me.FavouredClass)
        Me.Basics.Controls.Add(Me.NA)
        Me.Basics.Controls.Add(Me.Label56)
        Me.Basics.Controls.Add(Me.IndentedLine7)
        Me.Basics.Controls.Add(Me.ManeuverDropdown)
        Me.Basics.Controls.Add(Me.Fly)
        Me.Basics.Controls.Add(Me.Label30)
        Me.Basics.Controls.Add(Me.Swim)
        Me.Basics.Controls.Add(Me.Label31)
        Me.Basics.Controls.Add(Me.Burrow)
        Me.Basics.Controls.Add(Me.Label34)
        Me.Basics.Controls.Add(Me.Climb)
        Me.Basics.Controls.Add(Me.Label35)
        Me.Basics.Controls.Add(Me.IndentedLine6)
        Me.Basics.Controls.Add(Me.LA)
        Me.Basics.Controls.Add(Me.Label21)
        Me.Basics.Controls.Add(Me.Label20)
        Me.Basics.Controls.Add(Me.EquivDropdown)
        Me.Basics.Controls.Add(Me.Label19)
        Me.Basics.Controls.Add(Me.FavouredClassCheck)
        Me.Basics.Controls.Add(Me.BonusSkillPoints)
        Me.Basics.Controls.Add(Me.Speed)
        Me.Basics.Controls.Add(Me.Label16)
        Me.Basics.Controls.Add(Me.Label12)
        Me.Basics.Controls.Add(Me.IndentedLine3)
        Me.Basics.Controls.Add(Me.Label10)
        Me.Basics.Controls.Add(Me.CHA)
        Me.Basics.Controls.Add(Me.WIS)
        Me.Basics.Controls.Add(Me.INT)
        Me.Basics.Controls.Add(Me.CON)
        Me.Basics.Controls.Add(Me.DEX)
        Me.Basics.Controls.Add(Me.STR)
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
        Me.Basics.Size = New System.Drawing.Size(407, 539)
        Me.Basics.TabIndex = 0
        Me.Basics.Text = "Race"
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.SystemColors.Control
        Me.Label62.Location = New System.Drawing.Point(290, 205)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(45, 21)
        Me.Label62.TabIndex = 160
        Me.Label62.Text = "Reach"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.SystemColors.Control
        Me.Label63.Location = New System.Drawing.Point(175, 205)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(45, 21)
        Me.Label63.TabIndex = 158
        Me.Label63.Text = "Space"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FavouredClass
        '
        Me.FavouredClass.Enabled = False
        Me.FavouredClass.Location = New System.Drawing.Point(115, 375)
        Me.FavouredClass.Name = "FavouredClass"
        Me.FavouredClass.Properties.AutoHeight = False
        Me.FavouredClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FavouredClass.Properties.DropDownRows = 10
        Me.FavouredClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FavouredClass.Size = New System.Drawing.Size(135, 21)
        Me.FavouredClass.TabIndex = 19
        '
        'NA
        '
        Me.NA.Location = New System.Drawing.Point(115, 435)
        Me.NA.Name = "NA"
        Me.NA.Size = New System.Drawing.Size(55, 21)
        Me.NA.TabIndex = 21
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.Control
        Me.Label56.Location = New System.Drawing.Point(15, 435)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(95, 21)
        Me.Label56.TabIndex = 154
        Me.Label56.Text = "Natural Armor"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine7
        '
        Me.IndentedLine7.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine7.Name = "IndentedLine7"
        Me.IndentedLine7.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine7.TabIndex = 151
        Me.IndentedLine7.TabStop = False
        '
        'ManeuverDropdown
        '
        Me.ManeuverDropdown.Enabled = False
        Me.ManeuverDropdown.Location = New System.Drawing.Point(125, 295)
        Me.ManeuverDropdown.Name = "ManeuverDropdown"
        Me.ManeuverDropdown.Properties.AutoHeight = False
        Me.ManeuverDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ManeuverDropdown.Properties.DropDownRows = 10
        Me.ManeuverDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ManeuverDropdown.Size = New System.Drawing.Size(135, 21)
        Me.ManeuverDropdown.TabIndex = 16
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Location = New System.Drawing.Point(15, 295)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(45, 21)
        Me.Label30.TabIndex = 145
        Me.Label30.Text = "Fly"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Location = New System.Drawing.Point(15, 265)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 21)
        Me.Label31.TabIndex = 143
        Me.Label31.Text = "Swim"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Location = New System.Drawing.Point(130, 265)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 21)
        Me.Label34.TabIndex = 141
        Me.Label34.Text = "Burrow"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Location = New System.Drawing.Point(130, 235)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 21)
        Me.Label35.TabIndex = 139
        Me.Label35.Text = "Climb"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine6
        '
        Me.IndentedLine6.Location = New System.Drawing.Point(15, 330)
        Me.IndentedLine6.Name = "IndentedLine6"
        Me.IndentedLine6.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine6.TabIndex = 129
        Me.IndentedLine6.TabStop = False
        '
        'LA
        '
        Me.LA.Location = New System.Drawing.Point(115, 405)
        Me.LA.Name = "LA"
        Me.LA.Size = New System.Drawing.Size(55, 21)
        Me.LA.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(15, 405)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 21)
        Me.Label21.TabIndex = 128
        Me.Label21.Text = "Level Adjustment"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(235, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(125, 21)
        Me.Label20.TabIndex = 127
        Me.Label20.Text = "for Race Prerequisites"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EquivDropdown
        '
        Me.EquivDropdown.CausesValidation = False
        Me.EquivDropdown.Location = New System.Drawing.Point(90, 45)
        Me.EquivDropdown.Name = "EquivDropdown"
        Me.EquivDropdown.Properties.AutoHeight = False
        Me.EquivDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EquivDropdown.Properties.DropDownRows = 10
        Me.EquivDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.EquivDropdown.Size = New System.Drawing.Size(135, 21)
        Me.EquivDropdown.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(15, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 21)
        Me.Label19.TabIndex = 125
        Me.Label19.Text = "Equivalent to"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FavouredClassCheck
        '
        Me.FavouredClassCheck.Location = New System.Drawing.Point(15, 375)
        Me.FavouredClassCheck.Name = "FavouredClassCheck"
        Me.FavouredClassCheck.Size = New System.Drawing.Size(104, 21)
        Me.FavouredClassCheck.TabIndex = 18
        Me.FavouredClassCheck.Text = " Favored Class"
        '
        'BonusSkillPoints
        '
        Me.BonusSkillPoints.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BonusSkillPoints.Location = New System.Drawing.Point(175, 345)
        Me.BonusSkillPoints.Name = "BonusSkillPoints"
        Me.BonusSkillPoints.Properties.Appearance.Options.UseTextOptions = True
        Me.BonusSkillPoints.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BonusSkillPoints.Properties.AutoHeight = False
        Me.BonusSkillPoints.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.BonusSkillPoints.Properties.IsFloatValue = False
        Me.BonusSkillPoints.Properties.Mask.BeepOnError = True
        Me.BonusSkillPoints.Properties.Mask.EditMask = "99"
        Me.BonusSkillPoints.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.BonusSkillPoints.Properties.Mask.ShowPlaceHolders = False
        Me.BonusSkillPoints.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.BonusSkillPoints.Size = New System.Drawing.Size(50, 21)
        Me.BonusSkillPoints.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(235, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 21)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "(x4 at Level 1)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(15, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 21)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Bonus Skill Points (each level)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 190)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 122
        Me.IndentedLine3.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(15, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 21)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Ability Score Modifiers"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CHA
        '
        Me.CHA.Location = New System.Drawing.Point(265, 155)
        Me.CHA.Name = "CHA"
        Me.CHA.Size = New System.Drawing.Size(50, 21)
        Me.CHA.TabIndex = 7
        '
        'WIS
        '
        Me.WIS.Location = New System.Drawing.Point(160, 155)
        Me.WIS.Name = "WIS"
        Me.WIS.Size = New System.Drawing.Size(50, 21)
        Me.WIS.TabIndex = 6
        '
        'INT
        '
        Me.INT.Location = New System.Drawing.Point(160, 125)
        Me.INT.Name = "INT"
        Me.INT.Size = New System.Drawing.Size(50, 21)
        Me.INT.TabIndex = 3
        '
        'CON
        '
        Me.CON.Location = New System.Drawing.Point(55, 155)
        Me.CON.Name = "CON"
        Me.CON.Size = New System.Drawing.Size(50, 21)
        Me.CON.TabIndex = 5
        '
        'DEX
        '
        Me.DEX.Location = New System.Drawing.Point(265, 125)
        Me.DEX.Name = "DEX"
        Me.DEX.Size = New System.Drawing.Size(50, 21)
        Me.DEX.TabIndex = 4
        '
        'STR
        '
        Me.STR.Location = New System.Drawing.Point(55, 125)
        Me.STR.Name = "STR"
        Me.STR.Size = New System.Drawing.Size(50, 21)
        Me.STR.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(120, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 21)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "INT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(120, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 21)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "WIS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(225, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 21)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "CHA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(15, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 21)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "STR"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(225, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 21)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "DEX"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(15, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "CON"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Size"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RaceSize
        '
        Me.RaceSize.Location = New System.Drawing.Point(60, 205)
        Me.RaceSize.Name = "RaceSize"
        Me.RaceSize.Properties.AutoHeight = False
        Me.RaceSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RaceSize.Properties.DropDownRows = 10
        Me.RaceSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RaceSize.Size = New System.Drawing.Size(100, 21)
        Me.RaceSize.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Speed"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObjectName
        '
        Me.ObjectName.Location = New System.Drawing.Point(90, 15)
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
        'WeaponsTab
        '
        Me.WeaponsTab.Controls.Add(Me.WeaponDropdown)
        Me.WeaponsTab.Controls.Add(Me.Label65)
        Me.WeaponsTab.Controls.Add(Me.RemoveWeapon)
        Me.WeaponsTab.Controls.Add(Me.AddWeapon)
        Me.WeaponsTab.Controls.Add(Me.IndentedLine1)
        Me.WeaponsTab.Controls.Add(Me.WeaponsList)
        Me.WeaponsTab.Location = New System.Drawing.Point(4, 22)
        Me.WeaponsTab.Name = "WeaponsTab"
        Me.WeaponsTab.Size = New System.Drawing.Size(407, 539)
        Me.WeaponsTab.TabIndex = 12
        Me.WeaponsTab.Text = "Natural Weapons"
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
        Me.WeaponDropdown.Size = New System.Drawing.Size(190, 21)
        Me.WeaponDropdown.TabIndex = 0
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.SystemColors.Control
        Me.Label65.CausesValidation = False
        Me.Label65.Location = New System.Drawing.Point(15, 15)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(50, 21)
        Me.Label65.TabIndex = 168
        Me.Label65.Text = "Weapon"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveWeapon
        '
        Me.RemoveWeapon.CausesValidation = False
        Me.RemoveWeapon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveWeapon.Location = New System.Drawing.Point(275, 95)
        Me.RemoveWeapon.Name = "RemoveWeapon"
        Me.RemoveWeapon.Size = New System.Drawing.Size(110, 24)
        Me.RemoveWeapon.TabIndex = 3
        Me.RemoveWeapon.Text = "Remove Weapon"
        '
        'AddWeapon
        '
        Me.AddWeapon.CausesValidation = False
        Me.AddWeapon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddWeapon.Location = New System.Drawing.Point(275, 65)
        Me.AddWeapon.Name = "AddWeapon"
        Me.AddWeapon.Size = New System.Drawing.Size(110, 24)
        Me.AddWeapon.TabIndex = 2
        Me.AddWeapon.Text = "Add Weapon"
        '
        'IndentedLine1
        '
        Me.IndentedLine1.CausesValidation = False
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 167
        Me.IndentedLine1.TabStop = False
        '
        'WeaponsList
        '
        Me.WeaponsList.CausesValidation = False
        Me.WeaponsList.Location = New System.Drawing.Point(15, 65)
        Me.WeaponsList.Name = "WeaponsList"
        Me.WeaponsList.Size = New System.Drawing.Size(240, 450)
        Me.WeaponsList.TabIndex = 1
        '
        'TypeTab
        '
        Me.TypeTab.Controls.Add(Me.StartingLevel)
        Me.TypeTab.Controls.Add(Me.MonsterLAbel)
        Me.TypeTab.Controls.Add(Me.MonsterCheck)
        Me.TypeTab.Controls.Add(Me.QuadCheck)
        Me.TypeTab.Controls.Add(Me.NonhumanoidCheck)
        Me.TypeTab.Controls.Add(Me.Label64)
        Me.TypeTab.Controls.Add(Me.SubtypeDropdown)
        Me.TypeTab.Controls.Add(Me.Label54)
        Me.TypeTab.Controls.Add(Me.RemoveSubtype)
        Me.TypeTab.Controls.Add(Me.AddSubtype)
        Me.TypeTab.Controls.Add(Me.MonsterClass)
        Me.TypeTab.Controls.Add(Me.IndentedLine10)
        Me.TypeTab.Controls.Add(Me.IndentedLine8)
        Me.TypeTab.Controls.Add(Me.SubtypeList)
        Me.TypeTab.Location = New System.Drawing.Point(4, 22)
        Me.TypeTab.Name = "TypeTab"
        Me.TypeTab.Size = New System.Drawing.Size(407, 539)
        Me.TypeTab.TabIndex = 11
        Me.TypeTab.Text = "Type"
        '
        'StartingLevel
        '
        Me.StartingLevel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StartingLevel.Enabled = False
        Me.StartingLevel.Location = New System.Drawing.Point(100, 435)
        Me.StartingLevel.Name = "StartingLevel"
        Me.StartingLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.StartingLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartingLevel.Properties.AutoHeight = False
        Me.StartingLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.StartingLevel.Properties.IsFloatValue = False
        Me.StartingLevel.Properties.Mask.BeepOnError = True
        Me.StartingLevel.Properties.Mask.EditMask = "99"
        Me.StartingLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.StartingLevel.Properties.Mask.ShowPlaceHolders = False
        Me.StartingLevel.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.StartingLevel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StartingLevel.Size = New System.Drawing.Size(50, 21)
        Me.StartingLevel.TabIndex = 6
        '
        'MonsterLAbel
        '
        Me.MonsterLAbel.BackColor = System.Drawing.SystemColors.Control
        Me.MonsterLAbel.Enabled = False
        Me.MonsterLAbel.Location = New System.Drawing.Point(155, 435)
        Me.MonsterLAbel.Name = "MonsterLAbel"
        Me.MonsterLAbel.Size = New System.Drawing.Size(240, 21)
        Me.MonsterLAbel.TabIndex = 169
        Me.MonsterLAbel.Text = "levels of ..."
        Me.MonsterLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonsterCheck
        '
        Me.MonsterCheck.Enabled = False
        Me.MonsterCheck.Location = New System.Drawing.Point(20, 435)
        Me.MonsterCheck.Name = "MonsterCheck"
        Me.MonsterCheck.Size = New System.Drawing.Size(100, 21)
        Me.MonsterCheck.TabIndex = 5
        Me.MonsterCheck.Text = "Begins with"
        '
        'QuadCheck
        '
        Me.QuadCheck.CausesValidation = False
        Me.QuadCheck.Enabled = False
        Me.QuadCheck.Location = New System.Drawing.Point(40, 495)
        Me.QuadCheck.Name = "QuadCheck"
        Me.QuadCheck.Size = New System.Drawing.Size(100, 21)
        Me.QuadCheck.TabIndex = 8
        Me.QuadCheck.Text = "Quadruped"
        '
        'NonhumanoidCheck
        '
        Me.NonhumanoidCheck.CausesValidation = False
        Me.NonhumanoidCheck.Location = New System.Drawing.Point(20, 465)
        Me.NonhumanoidCheck.Name = "NonhumanoidCheck"
        Me.NonhumanoidCheck.Size = New System.Drawing.Size(100, 21)
        Me.NonhumanoidCheck.TabIndex = 7
        Me.NonhumanoidCheck.Text = "Nonhumanoid"
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.SystemColors.Control
        Me.Label64.CausesValidation = False
        Me.Label64.Location = New System.Drawing.Point(15, 15)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(50, 21)
        Me.Label64.TabIndex = 163
        Me.Label64.Text = "Type"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.SubtypeDropdown.Size = New System.Drawing.Size(190, 21)
        Me.SubtypeDropdown.TabIndex = 1
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.Control
        Me.Label54.CausesValidation = False
        Me.Label54.Location = New System.Drawing.Point(15, 45)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(50, 21)
        Me.Label54.TabIndex = 162
        Me.Label54.Text = "Subtype"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveSubtype
        '
        Me.RemoveSubtype.CausesValidation = False
        Me.RemoveSubtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSubtype.Location = New System.Drawing.Point(275, 125)
        Me.RemoveSubtype.Name = "RemoveSubtype"
        Me.RemoveSubtype.Size = New System.Drawing.Size(110, 24)
        Me.RemoveSubtype.TabIndex = 4
        Me.RemoveSubtype.Text = "Remove Subtype"
        '
        'AddSubtype
        '
        Me.AddSubtype.CausesValidation = False
        Me.AddSubtype.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubtype.Location = New System.Drawing.Point(275, 95)
        Me.AddSubtype.Name = "AddSubtype"
        Me.AddSubtype.Size = New System.Drawing.Size(110, 24)
        Me.AddSubtype.TabIndex = 3
        Me.AddSubtype.Text = "Add Subtype"
        '
        'MonsterClass
        '
        Me.MonsterClass.CausesValidation = False
        Me.MonsterClass.Location = New System.Drawing.Point(65, 15)
        Me.MonsterClass.Name = "MonsterClass"
        Me.MonsterClass.Properties.AutoHeight = False
        Me.MonsterClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MonsterClass.Properties.DropDownRows = 10
        Me.MonsterClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MonsterClass.Size = New System.Drawing.Size(190, 21)
        Me.MonsterClass.TabIndex = 0
        '
        'IndentedLine10
        '
        Me.IndentedLine10.CausesValidation = False
        Me.IndentedLine10.Location = New System.Drawing.Point(16, 420)
        Me.IndentedLine10.Name = "IndentedLine10"
        Me.IndentedLine10.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine10.TabIndex = 166
        Me.IndentedLine10.TabStop = False
        '
        'IndentedLine8
        '
        Me.IndentedLine8.CausesValidation = False
        Me.IndentedLine8.Location = New System.Drawing.Point(15, 80)
        Me.IndentedLine8.Name = "IndentedLine8"
        Me.IndentedLine8.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine8.TabIndex = 161
        Me.IndentedLine8.TabStop = False
        '
        'SubtypeList
        '
        Me.SubtypeList.CausesValidation = False
        Me.SubtypeList.Location = New System.Drawing.Point(15, 95)
        Me.SubtypeList.Name = "SubtypeList"
        Me.SubtypeList.Size = New System.Drawing.Size(240, 310)
        Me.SubtypeList.TabIndex = 2
        '
        'MonsterTab
        '
        Me.MonsterTab.Controls.Add(Me.Label66)
        Me.MonsterTab.Controls.Add(Me.Label67)
        Me.MonsterTab.Controls.Add(Me.PictureBox1)
        Me.MonsterTab.Controls.Add(Me.Label60)
        Me.MonsterTab.Controls.Add(Me.Label61)
        Me.MonsterTab.Controls.Add(Me.ClassSkillChoiceList)
        Me.MonsterTab.Controls.Add(Me.EditChoicesButton)
        Me.MonsterTab.Controls.Add(Me.CrossClassList)
        Me.MonsterTab.Location = New System.Drawing.Point(4, 22)
        Me.MonsterTab.Name = "MonsterTab"
        Me.MonsterTab.Size = New System.Drawing.Size(407, 539)
        Me.MonsterTab.TabIndex = 10
        Me.MonsterTab.Text = "Monster Skills"
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(45, 15)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(310, 15)
        Me.Label66.TabIndex = 314
        Me.Label66.Text = "This tab allows you to sepecify the class skills for this race's"
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(45, 30)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(310, 15)
        Me.Label67.TabIndex = 313
        Me.Label67.Text = "monster class levels."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(15, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 311
        Me.PictureBox1.TabStop = False
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.SystemColors.Control
        Me.Label60.Location = New System.Drawing.Point(15, 285)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(105, 21)
        Me.Label60.TabIndex = 136
        Me.Label60.Text = "Cross-Class Skills"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.Control
        Me.Label61.Location = New System.Drawing.Point(15, 55)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(70, 21)
        Me.Label61.TabIndex = 135
        Me.Label61.Text = "Class Skills"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClassSkillChoiceList
        '
        Me.ClassSkillChoiceList.Location = New System.Drawing.Point(15, 80)
        Me.ClassSkillChoiceList.Name = "ClassSkillChoiceList"
        Me.ClassSkillChoiceList.Size = New System.Drawing.Size(240, 190)
        Me.ClassSkillChoiceList.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ClassSkillChoiceList.TabIndex = 0
        Me.ClassSkillChoiceList.TabStop = False
        '
        'EditChoicesButton
        '
        Me.EditChoicesButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditChoicesButton.Location = New System.Drawing.Point(270, 80)
        Me.EditChoicesButton.Name = "EditChoicesButton"
        Me.EditChoicesButton.Size = New System.Drawing.Size(110, 24)
        Me.EditChoicesButton.TabIndex = 1
        Me.EditChoicesButton.Text = "Edit Class Skills"
        '
        'CrossClassList
        '
        Me.CrossClassList.Location = New System.Drawing.Point(15, 320)
        Me.CrossClassList.Name = "CrossClassList"
        Me.CrossClassList.Size = New System.Drawing.Size(240, 195)
        Me.CrossClassList.TabIndex = 2
        '
        'HeightAndWeightTab
        '
        Me.HeightAndWeightTab.Controls.Add(Me.Label18)
        Me.HeightAndWeightTab.Controls.Add(Me.Label52)
        Me.HeightAndWeightTab.Controls.Add(Me.Label58)
        Me.HeightAndWeightTab.Controls.Add(Me.StartAge3)
        Me.HeightAndWeightTab.Controls.Add(Me.Label59)
        Me.HeightAndWeightTab.Controls.Add(Me.Label57)
        Me.HeightAndWeightTab.Controls.Add(Me.Label47)
        Me.HeightAndWeightTab.Controls.Add(Me.Label51)
        Me.HeightAndWeightTab.Controls.Add(Me.StartAge2)
        Me.HeightAndWeightTab.Controls.Add(Me.Label53)
        Me.HeightAndWeightTab.Controls.Add(Me.Label50)
        Me.HeightAndWeightTab.Controls.Add(Me.Label48)
        Me.HeightAndWeightTab.Controls.Add(Me.StartAge1)
        Me.HeightAndWeightTab.Controls.Add(Me.Label45)
        Me.HeightAndWeightTab.Controls.Add(Me.Label46)
        Me.HeightAndWeightTab.Controls.Add(Me.MaximumAge)
        Me.HeightAndWeightTab.Controls.Add(Me.Label43)
        Me.HeightAndWeightTab.Controls.Add(Me.Label44)
        Me.HeightAndWeightTab.Controls.Add(Me.Venerable)
        Me.HeightAndWeightTab.Controls.Add(Me.Label41)
        Me.HeightAndWeightTab.Controls.Add(Me.Label42)
        Me.HeightAndWeightTab.Controls.Add(Me.OldAge)
        Me.HeightAndWeightTab.Controls.Add(Me.Label39)
        Me.HeightAndWeightTab.Controls.Add(Me.Label40)
        Me.HeightAndWeightTab.Controls.Add(Me.MiddleAge)
        Me.HeightAndWeightTab.Controls.Add(Me.Label38)
        Me.HeightAndWeightTab.Controls.Add(Me.Label37)
        Me.HeightAndWeightTab.Controls.Add(Me.Adulthood)
        Me.HeightAndWeightTab.Controls.Add(Me.Label49)
        Me.HeightAndWeightTab.Controls.Add(Me.FemaleWeight)
        Me.HeightAndWeightTab.Controls.Add(Me.FemaleHeightBase)
        Me.HeightAndWeightTab.Controls.Add(Me.MaleWeight)
        Me.HeightAndWeightTab.Controls.Add(Me.MaleHeightBase)
        Me.HeightAndWeightTab.Controls.Add(Me.Label17)
        Me.HeightAndWeightTab.Controls.Add(Me.Label1)
        Me.HeightAndWeightTab.Controls.Add(Me.Label55)
        Me.HeightAndWeightTab.Controls.Add(Me.Label33)
        Me.HeightAndWeightTab.Controls.Add(Me.MaleWeightMultiplier)
        Me.HeightAndWeightTab.Controls.Add(Me.Label36)
        Me.HeightAndWeightTab.Controls.Add(Me.Label32)
        Me.HeightAndWeightTab.Controls.Add(Me.FemaleWeightMultiplier)
        Me.HeightAndWeightTab.Controls.Add(Me.Label29)
        Me.HeightAndWeightTab.Controls.Add(Me.Label26)
        Me.HeightAndWeightTab.Controls.Add(Me.Label27)
        Me.HeightAndWeightTab.Controls.Add(Me.FemaleHeightRange)
        Me.HeightAndWeightTab.Controls.Add(Me.Label28)
        Me.HeightAndWeightTab.Controls.Add(Me.Label25)
        Me.HeightAndWeightTab.Controls.Add(Me.Label24)
        Me.HeightAndWeightTab.Controls.Add(Me.Label23)
        Me.HeightAndWeightTab.Controls.Add(Me.MaleHeightRange)
        Me.HeightAndWeightTab.Controls.Add(Me.Label22)
        Me.HeightAndWeightTab.Controls.Add(Me.IndentedLine4)
        Me.HeightAndWeightTab.Controls.Add(Me.IndentedLine9)
        Me.HeightAndWeightTab.Controls.Add(Me.IndentedLine5)
        Me.HeightAndWeightTab.Location = New System.Drawing.Point(4, 22)
        Me.HeightAndWeightTab.Name = "HeightAndWeightTab"
        Me.HeightAndWeightTab.Size = New System.Drawing.Size(407, 539)
        Me.HeightAndWeightTab.TabIndex = 7
        Me.HeightAndWeightTab.Text = "Physical"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(75, 500)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 21)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "+"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Location = New System.Drawing.Point(35, 355)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(160, 21)
        Me.Label52.TabIndex = 247
        Me.Label52.Text = "Cleric, Druid, Monk, Wizard"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.SystemColors.Control
        Me.Label58.Location = New System.Drawing.Point(195, 355)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(14, 21)
        Me.Label58.TabIndex = 225
        Me.Label58.Text = "+"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Location = New System.Drawing.Point(265, 355)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(25, 21)
        Me.Label59.TabIndex = 246
        Me.Label59.Text = "yrs"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.Control
        Me.Label57.Location = New System.Drawing.Point(35, 325)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(160, 21)
        Me.Label57.TabIndex = 245
        Me.Label57.Text = "Bard, Fighter, Paladin, Ranger"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Location = New System.Drawing.Point(35, 295)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(155, 21)
        Me.Label47.TabIndex = 244
        Me.Label47.Text = "Barbarian, Rogue, Sorceror"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.Control
        Me.Label51.Location = New System.Drawing.Point(195, 325)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(14, 21)
        Me.Label51.TabIndex = 224
        Me.Label51.Text = "+"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.Control
        Me.Label53.Location = New System.Drawing.Point(265, 325)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(25, 21)
        Me.Label53.TabIndex = 243
        Me.Label53.Text = "yrs"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.Location = New System.Drawing.Point(15, 235)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(85, 21)
        Me.Label50.TabIndex = 242
        Me.Label50.Text = "Starting Age"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Location = New System.Drawing.Point(195, 295)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(14, 21)
        Me.Label48.TabIndex = 221
        Me.Label48.Text = "+"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Location = New System.Drawing.Point(145, 500)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(40, 21)
        Me.Label45.TabIndex = 241
        Me.Label45.Text = "yrs"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.Control
        Me.Label46.Location = New System.Drawing.Point(15, 500)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(65, 21)
        Me.Label46.TabIndex = 240
        Me.Label46.Text = "Maximum"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.Location = New System.Drawing.Point(145, 470)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(40, 21)
        Me.Label43.TabIndex = 239
        Me.Label43.Text = "yrs"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.Control
        Me.Label44.Location = New System.Drawing.Point(15, 470)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(65, 21)
        Me.Label44.TabIndex = 238
        Me.Label44.Text = "Venerable"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.Control
        Me.Label41.Location = New System.Drawing.Point(145, 440)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 21)
        Me.Label41.TabIndex = 237
        Me.Label41.Text = "yrs"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.Control
        Me.Label42.Location = New System.Drawing.Point(15, 440)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(65, 21)
        Me.Label42.TabIndex = 236
        Me.Label42.Text = "Old"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Location = New System.Drawing.Point(145, 410)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(40, 21)
        Me.Label39.TabIndex = 234
        Me.Label39.Text = "yrs"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.Location = New System.Drawing.Point(15, 410)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(65, 21)
        Me.Label40.TabIndex = 233
        Me.Label40.Text = "Middle Age"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Location = New System.Drawing.Point(135, 265)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 21)
        Me.Label38.TabIndex = 232
        Me.Label38.Text = "yrs"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Location = New System.Drawing.Point(15, 265)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(60, 21)
        Me.Label37.TabIndex = 231
        Me.Label37.Text = "Adulthood"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Location = New System.Drawing.Point(265, 295)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(25, 21)
        Me.Label49.TabIndex = 235
        Me.Label49.Text = "yrs"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FemaleWeight
        '
        Me.FemaleWeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FemaleWeight.Location = New System.Drawing.Point(65, 75)
        Me.FemaleWeight.Name = "FemaleWeight"
        Me.FemaleWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.FemaleWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FemaleWeight.Properties.AutoHeight = False
        Me.FemaleWeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FemaleWeight.Properties.Mask.BeepOnError = True
        Me.FemaleWeight.Properties.Mask.EditMask = "9999"
        Me.FemaleWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.FemaleWeight.Properties.Mask.ShowPlaceHolders = False
        Me.FemaleWeight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.FemaleWeight.Size = New System.Drawing.Size(75, 21)
        Me.FemaleWeight.TabIndex = 2
        '
        'FemaleHeightBase
        '
        Me.FemaleHeightBase.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FemaleHeightBase.Location = New System.Drawing.Point(65, 45)
        Me.FemaleHeightBase.Name = "FemaleHeightBase"
        Me.FemaleHeightBase.Properties.Appearance.Options.UseTextOptions = True
        Me.FemaleHeightBase.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FemaleHeightBase.Properties.AutoHeight = False
        Me.FemaleHeightBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FemaleHeightBase.Properties.Mask.BeepOnError = True
        Me.FemaleHeightBase.Properties.Mask.EditMask = "9999"
        Me.FemaleHeightBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.FemaleHeightBase.Properties.Mask.ShowPlaceHolders = False
        Me.FemaleHeightBase.Properties.MaxValue = New Decimal(New Integer() {2400, 0, 0, 0})
        Me.FemaleHeightBase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.FemaleHeightBase.Size = New System.Drawing.Size(75, 21)
        Me.FemaleHeightBase.TabIndex = 0
        '
        'MaleWeight
        '
        Me.MaleWeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MaleWeight.Location = New System.Drawing.Point(65, 185)
        Me.MaleWeight.Name = "MaleWeight"
        Me.MaleWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.MaleWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaleWeight.Properties.AutoHeight = False
        Me.MaleWeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MaleWeight.Properties.Mask.BeepOnError = True
        Me.MaleWeight.Properties.Mask.EditMask = "9999"
        Me.MaleWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.MaleWeight.Properties.Mask.ShowPlaceHolders = False
        Me.MaleWeight.Properties.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.MaleWeight.Size = New System.Drawing.Size(75, 21)
        Me.MaleWeight.TabIndex = 6
        '
        'MaleHeightBase
        '
        Me.MaleHeightBase.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MaleHeightBase.Location = New System.Drawing.Point(65, 155)
        Me.MaleHeightBase.Name = "MaleHeightBase"
        Me.MaleHeightBase.Properties.Appearance.Options.UseTextOptions = True
        Me.MaleHeightBase.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MaleHeightBase.Properties.AutoHeight = False
        Me.MaleHeightBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MaleHeightBase.Properties.Mask.BeepOnError = True
        Me.MaleHeightBase.Properties.Mask.EditMask = "9999"
        Me.MaleHeightBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.MaleHeightBase.Properties.Mask.ShowPlaceHolders = False
        Me.MaleHeightBase.Properties.MaxValue = New Decimal(New Integer() {2400, 0, 0, 0})
        Me.MaleHeightBase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MaleHeightBase.Size = New System.Drawing.Size(75, 21)
        Me.MaleHeightBase.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(15, 125)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 21)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = "Male"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(145, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "+  Height Roll  ×"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Location = New System.Drawing.Point(145, 75)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(85, 21)
        Me.Label55.TabIndex = 136
        Me.Label55.Text = "+  Height Roll  ×"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Location = New System.Drawing.Point(285, 185)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(25, 21)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "lb."
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Location = New System.Drawing.Point(15, 185)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(45, 21)
        Me.Label36.TabIndex = 130
        Me.Label36.Text = "Weight"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Location = New System.Drawing.Point(285, 75)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 21)
        Me.Label32.TabIndex = 128
        Me.Label32.Text = "lb."
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Location = New System.Drawing.Point(15, 75)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 21)
        Me.Label29.TabIndex = 123
        Me.Label29.Text = "Weight"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Location = New System.Drawing.Point(215, 45)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 21)
        Me.Label26.TabIndex = 121
        Me.Label26.Text = "inches"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Location = New System.Drawing.Point(145, 45)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 21)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "+"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Location = New System.Drawing.Point(15, 45)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 21)
        Me.Label28.TabIndex = 118
        Me.Label28.Text = "Height"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Location = New System.Drawing.Point(15, 15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 21)
        Me.Label25.TabIndex = 116
        Me.Label25.Text = "Female"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(215, 155)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 21)
        Me.Label24.TabIndex = 114
        Me.Label24.Text = "inches"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(145, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 21)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "+"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(15, 155)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 21)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Height"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine4
        '
        Me.IndentedLine4.Location = New System.Drawing.Point(15, 395)
        Me.IndentedLine4.Name = "IndentedLine4"
        Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine4.TabIndex = 248
        Me.IndentedLine4.TabStop = False
        '
        'IndentedLine9
        '
        Me.IndentedLine9.Location = New System.Drawing.Point(16, 220)
        Me.IndentedLine9.Name = "IndentedLine9"
        Me.IndentedLine9.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine9.TabIndex = 219
        Me.IndentedLine9.TabStop = False
        '
        'IndentedLine5
        '
        Me.IndentedLine5.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine5.Name = "IndentedLine5"
        Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine5.TabIndex = 188
        Me.IndentedLine5.TabStop = False
        '
        'LanguageTab
        '
        Me.LanguageTab.Controls.Add(Me.IndentedLine2)
        Me.LanguageTab.Controls.Add(Me.Label15)
        Me.LanguageTab.Controls.Add(Me.RemoveBonus)
        Me.LanguageTab.Controls.Add(Me.AddBonus)
        Me.LanguageTab.Controls.Add(Me.Label14)
        Me.LanguageTab.Controls.Add(Me.RemoveAutomatic)
        Me.LanguageTab.Controls.Add(Me.AddAutomatic)
        Me.LanguageTab.Controls.Add(Me.Label13)
        Me.LanguageTab.Controls.Add(Me.Languages)
        Me.LanguageTab.Controls.Add(Me.BonusLanguages)
        Me.LanguageTab.Controls.Add(Me.AutomaticLanguages)
        Me.LanguageTab.Location = New System.Drawing.Point(4, 22)
        Me.LanguageTab.Name = "LanguageTab"
        Me.LanguageTab.Size = New System.Drawing.Size(407, 539)
        Me.LanguageTab.TabIndex = 2
        Me.LanguageTab.Text = "Languages"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(16, 50)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine2.TabIndex = 187
        Me.IndentedLine2.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(15, 295)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 21)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Bonus Languages"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveBonus
        '
        Me.RemoveBonus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBonus.Location = New System.Drawing.Point(270, 355)
        Me.RemoveBonus.Name = "RemoveBonus"
        Me.RemoveBonus.Size = New System.Drawing.Size(120, 24)
        Me.RemoveBonus.TabIndex = 6
        Me.RemoveBonus.Text = "Remove Bonus"
        '
        'AddBonus
        '
        Me.AddBonus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBonus.Location = New System.Drawing.Point(270, 325)
        Me.AddBonus.Name = "AddBonus"
        Me.AddBonus.Size = New System.Drawing.Size(120, 24)
        Me.AddBonus.TabIndex = 5
        Me.AddBonus.Text = "Add Bonus"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(15, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 21)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Automatic Languages"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveAutomatic
        '
        Me.RemoveAutomatic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAutomatic.Location = New System.Drawing.Point(270, 125)
        Me.RemoveAutomatic.Name = "RemoveAutomatic"
        Me.RemoveAutomatic.Size = New System.Drawing.Size(120, 24)
        Me.RemoveAutomatic.TabIndex = 3
        Me.RemoveAutomatic.Text = "Remove Automatic"
        '
        'AddAutomatic
        '
        Me.AddAutomatic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAutomatic.Location = New System.Drawing.Point(270, 95)
        Me.AddAutomatic.Name = "AddAutomatic"
        Me.AddAutomatic.Size = New System.Drawing.Size(120, 24)
        Me.AddAutomatic.TabIndex = 2
        Me.AddAutomatic.Text = "Add Automatic"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(15, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 21)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Language"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Languages.TabIndex = 0
        '
        'BonusLanguages
        '
        Me.BonusLanguages.Location = New System.Drawing.Point(15, 325)
        Me.BonusLanguages.Name = "BonusLanguages"
        Me.BonusLanguages.Size = New System.Drawing.Size(240, 190)
        Me.BonusLanguages.TabIndex = 4
        '
        'AutomaticLanguages
        '
        Me.AutomaticLanguages.Location = New System.Drawing.Point(15, 95)
        Me.AutomaticLanguages.Name = "AutomaticLanguages"
        Me.AutomaticLanguages.Size = New System.Drawing.Size(240, 185)
        Me.AutomaticLanguages.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 539)
        Me.TabPage1.TabIndex = 9
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(405, 370)
        Me.PropertiesTab.TabIndex = 0
        '
        'RaceForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 633)
        Me.Controls.Add(Me.RaceTabControl)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "RaceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RaceForm"
        CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FemaleHeightRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaleWeightMultiplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FemaleWeightMultiplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaleHeightRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Speed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Swim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Burrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Climb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Space.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartAge3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartAge2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartAge1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximumAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venerable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OldAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiddleAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Adulthood.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RaceTabControl.ResumeLayout(False)
        Me.Basics.ResumeLayout(False)
        CType(Me.FavouredClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManeuverDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquivDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonusSkillPoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaceSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WeaponsTab.ResumeLayout(False)
        CType(Me.WeaponDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TypeTab.ResumeLayout(False)
        CType(Me.StartingLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubtypeDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonsterClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MonsterTab.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassSkillChoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeightAndWeightTab.ResumeLayout(False)
        CType(Me.FemaleWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FemaleHeightBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaleWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaleHeightBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LanguageTab.ResumeLayout(False)
        CType(Me.Languages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'indexes
    Private ClassIndex As Rules.Index.IndexEntry()
    Private LanguageIndex As Rules.Index.IndexEntry()
    Private RaceIndex As Rules.Index.IndexEntry()

    'datalists
    Private MonsterClasses As DataListItem()
    Private SubtypesDatalist As DataListItem()
    Private NaturalWeaponsDatalist As DataListItem()

    'object collections
    Private AutomaticLanguageObjs As New Objects.ObjectDataCollection
    Private BonusLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingAutoLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingBonusLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingNaturalWeapons As New Objects.ObjectDataCollection
    Private NaturalWeapons As New Objects.ObjectDataCollection

    'skills
    Private SkillDefs As Objects.ObjectDataCollection
    Private SkillGroups As Objects.ObjectDataCollection

    Private ExistingClassSkills As New Objects.ObjectDataCollection
    Private ClassSkills As New Objects.ObjectDataCollection

    Private isLoading As Boolean

    'Subtype and Type variables
    Private OldType As Objects.ObjectKey

    Private ExistingSubtypes As New Objects.ObjectDataCollection
    Private Subtypes As New Objects.ObjectDataCollection

    Private CurrentComponents As New Objects.ObjectDataCollection
    Private ExistingComponents As New Objects.ObjectDataCollection

    'init
    Public Sub Init()
        Try
            'ref
            SkillDefs = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillDefinitionType)
            SkillGroups = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillGroupType)

            'indexes
            ClassIndex = Rules.Index.Index(XML.DBTypes.Classes, Objects.ClassType)
            LanguageIndex = Rules.Index.Index(XML.DBTypes.Languages, Objects.LanguageDefinitionType)
            RaceIndex = Rules.Index.Index(XML.DBTypes.Races, Objects.RaceType, True, mObject.ObjectGUID.ToString)
            SubtypesDatalist = Rules.Index.DataList(XML.DBTypes.Subtypes, Objects.SubtypeDefinitionType)
            NaturalWeaponsDatalist = Rules.Index.DataList(XML.DBTypes.NaturalWeapons, Objects.NaturalWeaponDefinitionType)

            'get the monster classes
            Dim ClassList As New Objects.ObjectDataCollection
            For Each ClassObj As Objects.ObjectData In Objects.GetAllObjectsOfType(XML.DBTypes.MonsterClasses, Objects.MonsterClassType)
                Select Case ClassObj.Element("ClassType")
                    Case "Monster Type"
                        ClassList.Add(ClassObj)
                End Select
            Next

            'make datalists
            MonsterClasses = Rules.Index.DataList(ClassList, True)

            'add items to the dropdowns
            MonsterClass.Properties.Items.AddRange(MonsterClasses)
            SubtypeDropdown.Properties.Items.AddRange(SubtypesDatalist)
            WeaponDropdown.Properties.Items.AddRange(NaturalWeaponsDatalist)

            'clear collections
            AutomaticLanguageObjs.Clear()
            BonusLanguageObjs.Clear()

            'Race tab
            RaceSize.Properties.Items.AddRange(Rules.Lists.Sizes)
            ManeuverDropdown.Properties.Items.AddRange(Rules.Lists.FlyingManeuverability)
            FavouredClass.Properties.Items.AddRange(Rules.Index.IndexNames(ClassIndex))
            EquivDropdown.Properties.Items.AddRange(Rules.Index.IndexNames(RaceIndex))
            STR.ModifierSpin.Properties.MinValue = -20
            STR.ModifierSpin.Properties.MaxValue = 20
            DEX.ModifierSpin.Properties.MinValue = -20
            DEX.ModifierSpin.Properties.MaxValue = 20
            CON.ModifierSpin.Properties.MinValue = -20
            CON.ModifierSpin.Properties.MaxValue = 20
            INT.ModifierSpin.Properties.MinValue = -20
            INT.ModifierSpin.Properties.MaxValue = 20
            WIS.ModifierSpin.Properties.MinValue = -20
            WIS.ModifierSpin.Properties.MaxValue = 20
            CHA.ModifierSpin.Properties.MinValue = -20
            CHA.ModifierSpin.Properties.MaxValue = 20

            LA.ModifierSpin.Properties.MinValue = 0
            LA.ModifierSpin.Properties.MaxValue = 9

            'skills tab            
            RaceTabControl.TabPages.Remove(MonsterTab)
            RaceTabControl.SelectedIndex = 0

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

            'init propertiestab
            PropertiesTab.Init(mObject, mMode)

            FemaleHeightBase.Properties.DisplayFormat.Format = New Rules.HeightFormatter
            FemaleHeightBase.Properties.EditFormat.Format = New Rules.HeightFormatter
            MaleHeightBase.Properties.DisplayFormat.Format = New Rules.HeightFormatter
            MaleHeightBase.Properties.EditFormat.Format = New Rules.HeightFormatter

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

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Races)
            mObject.Type = Objects.RaceType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form vars
            Me.Text = "Add Race"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()

            'initialise controls

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim temp As String
        Dim Child As Objects.ObjectData

        Try
            isLoading = True

            mObject = Obj
            mMode = FormMode.Edit
            Me.Text = "Edit Race"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls

            'basics tab
            ObjectName.Text = Obj.Name
            EquivDropdown.Text = mObject.Element("Equivalent")

            Speed.EditValue = CType(Obj.Element("Speed").Replace("ft.", ""), Integer)
            Climb.EditValue = Obj.Element("Climb").Replace("ft.", "")
            Burrow.EditValue = Obj.Element("Burrow").Replace("ft.", "")
            Fly.EditValue = Obj.Element("Fly").Replace("ft.", "")
            ManeuverDropdown.Text = Obj.Element("FlyManueverability")
            Swim.EditValue = Obj.Element("Swim").Replace("ft.", "")

            RaceSize.Text = Obj.Element("Size")
            Space.EditValue = Obj.Element("Space").Replace("ft.", "")
            Reach.EditValue = Obj.Element("Reach").Replace("ft.", "")

            temp = mObject.Element("FavouredClass")
            If temp <> "" Then
                FavouredClassCheck.CheckState = CheckState.Checked
                FavouredClass.Text = temp
            End If

            temp = mObject.Element("MonsterType")
            If temp <> "" Then
                OldType = mObject.GetFKGuid("MonsterType")
                MonsterClass.SelectedIndex = Rules.Index.GetGuidIndex(MonsterClasses, OldType)
            End If

            If mObject.Element("Monster") = "Yes" Then
                MonsterCheck.Enabled = True
                MonsterCheck.Checked = True
                StartingLevel.Value = Obj.ElementAsInteger("StartLevels")
            End If

            LA.ModifierSpin.EditValue = mObject.ElementAsInteger("LA")
            NA.ModifierSpin.EditValue = mObject.ElementAsInteger("NaturalArmor")

            STR.ModifierSpin.EditValue = mObject.ElementAsInteger("STRModifier")
            DEX.ModifierSpin.EditValue = mObject.ElementAsInteger("DEXModifier")
            CON.ModifierSpin.EditValue = mObject.ElementAsInteger("CONModifier")
            INT.ModifierSpin.EditValue = mObject.ElementAsInteger("INTModifier")
            WIS.ModifierSpin.EditValue = mObject.ElementAsInteger("WISModifier")
            CHA.ModifierSpin.EditValue = mObject.ElementAsInteger("CHAModifier")

            BonusSkillPoints.Text = mObject.Element("BonusSkillPoints")

            If mObject.Element("Nonhumanoid") <> "" Then
                NonhumanoidCheck.Checked = True
                If mObject.Element("Quadruped") <> "" Then QuadCheck.Checked = True
            End If

            'go through all children adding them to the appropriate collections
            Dim ChildCollection As Objects.ObjectDataCollection = mObject.Children

            For Each Child In ChildCollection

                Select Case Child.Type

                    Case Objects.AutomaticLanguageDefinitionType
                        ExistingAutoLanguageObjs.Add(Child)

                    Case Objects.BonusLanguageDefinitionType
                        ExistingBonusLanguageObjs.Add(Child)

                    Case Objects.ClassSkillType
                        ExistingClassSkills.Add(Child)

                    Case Objects.SubtypeType
                        ExistingSubtypes.Add(Child)

                    Case Objects.NaturalWeaponType
                        ExistingNaturalWeapons.Add(Child)

                    Case Else

                        'is this an inherited component from a subtype?
                        If Child.Element("Source") <> "" Then
                            ExistingComponents.Add(Child)
                        End If

                End Select
            Next

            'get class skills           
            For Each Child In ExistingClassSkills
                ClassSkills.Add(Child)
                ClassSkillChoiceList.Items.Add(Child)
            Next
            RecalcCrossClassSkills()

            'get existing subtypes            
            For Each Child In ExistingSubtypes
                Subtypes.Add(Child)
                SubtypeList.AddItem(Child.Name, Child.ObjectGUID)
            Next

            'get existing inherited components  
            For Each Child In ExistingComponents
                CurrentComponents.Add(Child)
            Next

            'automatic languages
            For Each Child In ExistingAutoLanguageObjs
                AutomaticLanguages.AddItem(Child.Name, Child.ObjectGUID)
                AutomaticLanguageObjs.Add(Child)
            Next

            'bonus languages
            For Each Child In ExistingBonusLanguageObjs
                BonusLanguages.AddItem(Child.Name, Child.ObjectGUID)
                BonusLanguageObjs.Add(Child)
            Next

            'bonus languages
            For Each Child In ExistingNaturalWeapons
                WeaponsList.AddItem(Child.Name, Child.ObjectGUID)
                NaturalWeapons.Add(Child)
            Next

            'height and weight
            FemaleHeightBase.EditValue = (mObject.ElementAsInteger("FemaleBaseHeight"))
            FemaleHeightRange.Text = mObject.Element("FemaleHeightRange")
            FemaleWeight.EditValue = (CInt(mObject.Element("FemaleBaseWeight")))
            FemaleWeightMultiplier.Text = mObject.Element("FemaleWeightMultiplier")
            MaleHeightBase.EditValue = (mObject.ElementAsInteger("MaleBaseHeight"))
            MaleHeightRange.Text = mObject.Element("MaleHeightRange")
            MaleWeight.EditValue = (CInt(mObject.Element("MaleBaseWeight")))
            MaleWeightMultiplier.Text = mObject.Element("MaleWeightMultiplier")

            'age
            Adulthood.Text = mObject.Element("Adulthood")
            StartAge1.Text = mObject.Element("StartingAgeRangeType1")
            StartAge2.Text = mObject.Element("StartingAgeRangeType2")
            StartAge3.Text = mObject.Element("StartingAgeRangeType3")
            MiddleAge.Text = mObject.Element("MiddleAge")
            OldAge.Text = mObject.Element("OldAge")
            Venerable.Text = mObject.Element("Venerable")
            MaximumAge.Text = mObject.Element("MaximumAge")

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
                End Select

                'updates common to add and edit

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

                If EquivDropdown.Text <> "" Then mObject.FKElement("Equivalent", EquivDropdown.Text, "Name", RaceIndex(EquivDropdown.SelectedIndex).ObjectGUID) Else mObject.FKSetNull("Equivalent")
                If FavouredClassCheck.CheckState = CheckState.Checked Then mObject.FKElement("FavouredClass", FavouredClass.Text, "Name", ClassIndex(FavouredClass.SelectedIndex).ObjectGUID) Else mObject.FKSetNull("FavouredClass")

                mObject.Element("BonusSkillPoints") = BonusSkillPoints.Text
                If LA.Text <> "0" Then mObject.Element("LA") = LA.Text Else mObject.Element("LA") = ""
                mObject.Element("NaturalArmor") = NA.Text

                If STR.Text <> "0" Then mObject.Element("STRModifier") = STR.Text Else mObject.Element("STRModifier") = ""
                If DEX.Text <> "0" Then mObject.Element("DEXModifier") = DEX.Text Else mObject.Element("DEXModifier") = ""
                If CON.Text <> "0" Then mObject.Element("CONModifier") = CON.Text Else mObject.Element("CONModifier") = ""
                If INT.Text <> "0" Then mObject.Element("INTModifier") = INT.Text Else mObject.Element("INTModifier") = ""
                If WIS.Text <> "0" Then mObject.Element("WISModifier") = WIS.Text Else mObject.Element("WISModifier") = ""
                If CHA.Text <> "0" Then mObject.Element("CHAModifier") = CHA.Text Else mObject.Element("CHAModifier") = ""

                If MonsterClass.Text <> "" Then
                    Dim MonsterClassObj As Objects.ObjectData = CType(CType(MonsterClass.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
                    mObject.FKElement("MonsterType", MonsterClass.Text, "Name", MonsterClasses(MonsterClass.SelectedIndex).ObjectGUID)
                    mObject.FKElement("MonsterTypeDisplay", MonsterClassObj.Element("Abbreviation"), "Abbreviation", CType(MonsterClass.SelectedItem, DataListItem).ObjectGUID)
                Else
                    mObject.FKSetNull("MonsterType")
                    mObject.FKSetNull("MonsterTypeDisplay")
                End If

                If MonsterCheck.Checked Then
                    mObject.Element("Monster") = "Yes"
                    mObject.ElementAsInteger("StartLevels") = CInt(StartingLevel.Value)
                Else
                    mObject.Element("Monster") = ""
                    mObject.Element("StartLevels") = ""
                End If

                If NonhumanoidCheck.Checked Then
                    mObject.Element("Nonhumanoid") = "Yes"
                    If QuadCheck.Checked Then mObject.Element("Quadruped") = "Yes"
                Else
                    mObject.Element("Nonhumanoid") = ""
                    mObject.Element("Quadruped") = ""
                End If

                'height and weight
                mObject.Element("FemaleBaseHeight") = (CInt(FemaleHeightBase.EditValue)).ToString
                mObject.Element("FemaleHeightRange") = FemaleHeightRange.Text
                mObject.Element("FemaleBaseWeight") = FemaleWeight.EditValue.ToString
                mObject.Element("FemaleWeightMultiplier") = FemaleWeightMultiplier.Text
                mObject.Element("MaleBaseHeight") = (CInt(MaleHeightBase.EditValue)).ToString
                mObject.Element("MaleHeightRange") = MaleHeightRange.Text
                mObject.Element("MaleBaseWeight") = MaleWeight.EditValue.ToString
                mObject.Element("MaleWeightMultiplier") = MaleWeightMultiplier.Text

                'ages
                mObject.Element("Adulthood") = Adulthood.Text
                mObject.Element("StartingAgeRangeType1") = StartAge1.Text
                mObject.Element("StartingAgeRangeType2") = StartAge2.Text
                mObject.Element("StartingAgeRangeType3") = StartAge3.Text
                mObject.Element("MiddleAge") = MiddleAge.Text
                mObject.Element("OldAge") = OldAge.Text
                mObject.Element("Venerable") = Venerable.Text
                mObject.Element("MaximumAge") = MaximumAge.Text

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

                'save the monster class skills
                If MonsterCheck.Checked Then
                    'delete the objects no longer required
                    For Each Obj In ExistingClassSkills
                        If Not ClassSkills.Contains(Obj.ObjectGUID) Then
                            Obj.Delete()
                        End If
                    Next

                    'save the new objects
                    For Each Obj In ClassSkills
                        If ExistingClassSkills.ContainsFK("Skill", Obj.GetFKGuid("Skill")) Then
                            ClassSkills.Remove(Obj.ObjectGUID)
                        End If
                    Next
                    ClassSkills.Save()
                Else
                    'delete the objects no longer required
                    For Each Obj In ExistingClassSkills
                        Obj.Delete()
                    Next
                End If

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

    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Basics.Controls, Errors)
            Validate = Validate And General.ValidateForm(LanguageTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(HeightAndWeightTab.Controls, Errors)

            If (MaleHeightRange.Text <> "") AndAlso (ValidDiceRange(MaleHeightRange) = False) Then
                Validate = False
                Errors.SetError(MaleHeightRange, ValidationDiceRange)
            Else
                Errors.SetError(MaleHeightRange, "")
            End If

            If (FemaleHeightRange.Text <> "") AndAlso (ValidDiceRange(FemaleHeightRange) = False) Then
                Validate = False
                Errors.SetError(FemaleHeightRange, ValidationDiceRange)
            Else
                Errors.SetError(FemaleHeightRange, "")
            End If

            If (MaleWeightMultiplier.Text <> "") AndAlso (ValidNumberDiceRange(MaleWeightMultiplier) = False) Then
                Validate = False
                Errors.SetError(MaleWeightMultiplier, ValidationPWNumberOrDiceRange)
            Else
                Errors.SetError(MaleWeightMultiplier, "")
            End If

            If (FemaleWeightMultiplier.Text <> "") AndAlso (ValidNumberDiceRange(FemaleWeightMultiplier) = False) Then
                Validate = False
                Errors.SetError(FemaleWeightMultiplier, ValidationPWNumberOrDiceRange)
            Else
                Errors.SetError(FemaleWeightMultiplier, "")
            End If

            If Adulthood.Text <> "" AndAlso (ValidNumberIncZero(Adulthood) = False) Then
                Validate = False
                Errors.SetError(Adulthood, ValidationPositiveWholeNumberOrZero)
            Else
                Errors.SetError(Adulthood, "")
            End If

            If (StartAge1.Text <> "") And (ValidDiceRange(StartAge1) = False) Then
                Validate = False
                Errors.SetError(StartAge1, ValidationDiceRange)
            Else
                Errors.SetError(StartAge1, "")
            End If

            If (StartAge2.Text <> "") And (ValidDiceRange(StartAge2) = False) Then
                Validate = False
                Errors.SetError(StartAge2, ValidationDiceRange)
            Else
                Errors.SetError(StartAge2, "")
            End If

            If (StartAge3.Text <> "") And (ValidDiceRange(StartAge3) = False) Then
                Validate = False
                Errors.SetError(StartAge3, ValidationDiceRange)
            Else
                Errors.SetError(StartAge3, "")
            End If

            If (MiddleAge.Text <> "") And (ValidNumber(MiddleAge) = False) Then
                Validate = False
                Errors.SetError(MiddleAge, ValidationPositiveWholeNumber)
            Else
                Errors.SetError(MiddleAge, "")
            End If

            If (OldAge.Text <> "") And (ValidNumber(OldAge) = False) Then
                Validate = False
                Errors.SetError(OldAge, ValidationPositiveWholeNumber)
            Else
                Errors.SetError(OldAge, "")
            End If

            If (Venerable.Text <> "") And (ValidNumber(Venerable) = False) Then
                Validate = False
                Errors.SetError(Venerable, ValidationPositiveWholeNumber)
            Else
                Errors.SetError(Venerable, "")
            End If

            If (MaximumAge.Text <> "") And (ValidDiceRange(MaximumAge) = False) Then
                Validate = False
                Errors.SetError(MaximumAge, ValidationDiceRange)
            Else
                Errors.SetError(MaximumAge, "")
            End If

            If ObjectName.Text <> "" And ObjectName.Text <> mObject.Name Then
                If XML.ObjectExists(ObjectName.Text, mObject.Type, mObject.ObjectGUID.Database) Then
                    Errors.SetError(ObjectName, General.ValidationUniqueName)
                    Validate = False
                Else
                    Errors.SetError(ObjectName, "")
                End If
            End If

            'make sure if we have subtypes we also have a type
            If SubtypeList.Count > 0 AndAlso MonsterClass.Text = "" Then
                Errors.SetError(MonsterClass, "A Type must be specified.")
                Validate = False
            Else
                Errors.SetError(MonsterClass, "")
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
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Races)
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

#Region "Race Tab"

    'enables and disables the Maneuver dropdown as required
    Private Sub Fly_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fly.EditValueChanged
        If Fly.Value = 0 Then
            ManeuverDropdown.Enabled = False
            ManeuverDropdown.SelectedIndex = -1
        Else
            ManeuverDropdown.Enabled = True
        End If
    End Sub

#End Region

#Region "Skills"

    Private Sub EditChoicesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditChoicesButton.Click
        Try
            Dim EditChoiceForm As New ConstructListDialog

            EditChoiceForm.Init("Edit Class Skills", "Select Class Skills", "Select Class Skills for this class.", "Skills", "Class Skills", AddressOf Rules.Skills.IsValidAdd)

            'get the skill definitions
            Dim ListA As New Objects.ObjectDataCollection
            ListA.AddMany(SkillDefs)
            ListA.AddMany(SkillGroups)
            Dim ListB As New Objects.ObjectDataCollection

            'remove existing choices
            For Each ClassSkill As Objects.ObjectData In ClassSkills
                Dim SkillKey As Objects.ObjectKey = ClassSkill.GetFKGuid("Skill")
                Dim SkillDef As Objects.ObjectData = ListA.Item(SkillKey)
                ListB.Add(ListA.Item(SkillKey))
                ListA.Remove(SkillKey)
            Next

            EditChoiceForm.InitTextList(ListA.ToArrayList, ListB.ToArrayList)
            If EditChoiceForm.ShowDialog() = DialogResult.OK Then
                'construct new class skills
                ClassSkills.Clear()
                For Each ClassSkill As Objects.ObjectData In EditChoiceForm.ListBFinal
                    Dim NewClassSkill As Objects.ObjectData = ExistingClassSkills.Item("Skill", ClassSkill.ObjectGUID)
                    If NewClassSkill.IsEmpty Then
                        NewClassSkill.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.Races)
                        NewClassSkill.ParentGUID = mObject.ObjectGUID
                        NewClassSkill.Type = Objects.ClassSkillType
                        NewClassSkill.FKElement("Skill", ClassSkill.Name, "Name", ClassSkill.ObjectGUID)
                        If ClassSkill.Type = Objects.SkillGroupType Then
                            NewClassSkill.Element("SkillGroup") = "Yes"
                        End If
                    End If
                    ClassSkills.Add(NewClassSkill)
                Next

                'refresh lists
                ClassSkillChoiceList.Items.Clear()
                ClassSkillChoiceList.Items.AddRange(ClassSkills.ToArrayList.ToArray)
                RecalcCrossClassSkills()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RecalcCrossClassSkills()
        Try
            CrossClassList.Clear()

            'get class skill groups
            Dim GroupSkills As New ArrayList
            For Each ClassSkill As Objects.ObjectData In ClassSkills
                If ClassSkill.Element("SkillGroup") = "Yes" Then GroupSkills.Add(ClassSkill.Name)
            Next

            'construct list
            For Each SkillDef As Objects.ObjectData In SkillDefs
                Dim SkillGroup As String = SkillDef.Element("SkillGroup")
                If SkillGroup = "" Then
                    If Not ClassSkills.ContainsFK("Skill", SkillDef.ObjectGUID) Then CrossClassList.AddItem(SkillDef.Name, Nothing)
                Else
                    If Not (GroupSkills.Contains(SkillGroup) Or ClassSkills.ContainsFK("Skill", SkillDef.ObjectGUID)) Then CrossClassList.AddItem(SkillDef.Name, Nothing)
                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Control Enabling and Disabling"

    'Enable Favoured class ComboBoxEditer
    Private Sub FavouredClassCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavouredClassCheck.CheckedChanged
        Try
            If FavouredClassCheck.CheckState = CheckState.Checked Then
                FavouredClass.Properties.Enabled = True
                FavouredClass.SelectedIndex = -1
            Else
                FavouredClass.Properties.Enabled = False
                FavouredClass.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    'fractional override for the space spin edit
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


#Region "Type Tab"

    Private Sub MonsterClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonsterClass.SelectedIndexChanged
        Try

            If MonsterClass.Text <> "" Then

                Dim TypeObj As New Objects.ObjectData
                TypeObj.Load(CType(MonsterClass.SelectedItem, DataListItem).ObjectGUID)

                MonsterLAbel.Text = "levels of " & MonsterClass.Text
                MonsterLAbel.Enabled = True
                MonsterCheck.Enabled = True

                If isLoading = True Then Exit Sub

                'delete previous components                
                Dim DeleteObjectList As New Objects.ObjectDataCollection
                For Each TempObj As Objects.ObjectData In CurrentComponents
                    If TempObj.GetFKGuid("Source").Equals(OldType) Then
                        DeleteObjectList.Add(TempObj)
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
                        If tempobj.Element("Level") = "1" Then
                            FirstClassLevel = tempobj
                            Exit For
                        End If
                    Next

                    'copy features and feats to the race.
                    If Not FirstClassLevel.IsEmpty Then
                        For Each Child As Objects.ObjectData In FirstClassLevel.Children
                            Select Case Child.Type

                                Case Objects.FeatureType, Objects.SpecificBonusFeatType, Objects.SpecificBonusFeatChooseFocusType
                                    Dim ClonedChildAndChildren As Objects.ObjectDataCollection = Child.Clone(mObject)
                                    For Each TempObj As Objects.ObjectData In ClonedChildAndChildren
                                        TempObj.FKElement("Source", MonsterClass.Text, "Name", TypeObj.ObjectGUID)
                                        CurrentComponents.Add(TempObj)
                                    Next

                            End Select
                        Next
                    End If

                End If

                'reset oldtype
                OldType = TypeObj.ObjectGUID

            Else

                MonsterLAbel.Enabled = False
                MonsterLAbel.Text = "levels of ..."
                MonsterCheck.Enabled = False
                MonsterCheck.Checked = False

                'delete previous components
                Dim DeleteObjectList As New Objects.ObjectDataCollection
                For Each TempObj As Objects.ObjectData In CurrentComponents
                    If TempObj.GetFKGuid("Source").Equals(OldType) Then
                        DeleteObjectList.Add(TempObj)
                    End If
                Next
                CurrentComponents.RemoveList(DeleteObjectList)

                'reset oldtype
                OldType = Objects.ObjectKey.Empty

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

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
                    CurrentComponents.Add(TempObj)
                Next
            Next

            SubtypeList.AddItem(Obj.Name, Obj.ObjectGUID)
            Subtypes.Add(Obj)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

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
                    End If
                Next
                CurrentComponents.RemoveList(DeleteObjectList)

                Subtypes.Remove(SubtypeList.ItemGUID())
                SubtypeList.RemoveSelectedItem()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub MonsterCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonsterCheck.CheckedChanged
        Try
            Dim AddTypeTab As Boolean = False
            Dim AddWeaponsTab As Boolean = False

            If MonsterCheck.Checked Then
                StartingLevel.Enabled = True

                Select Case RaceTabControl.SelectedIndex
                    Case 0
                        RaceTabControl.TabPages.Remove(WeaponsTab)
                        AddWeaponsTab = True

                        RaceTabControl.TabPages.Remove(TypeTab)
                        AddTypeTab = True
                    Case 1
                        RaceTabControl.TabPages.Remove(TypeTab)
                        AddTypeTab = True
                End Select

                RaceTabControl.TabPages.Remove(LanguageTab)
                RaceTabControl.TabPages.Remove(HeightAndWeightTab)
                RaceTabControl.TabPages.Remove(TabPage1)

                If AddWeaponsTab Then RaceTabControl.TabPages.Add(WeaponsTab)
                If AddTypeTab Then RaceTabControl.TabPages.Add(TypeTab)
                RaceTabControl.TabPages.Add(MonsterTab)
                RaceTabControl.TabPages.Add(LanguageTab)
                RaceTabControl.TabPages.Add(HeightAndWeightTab)
                RaceTabControl.TabPages.Add(TabPage1)
            Else
                StartingLevel.Value = 1
                StartingLevel.Enabled = False

                RaceTabControl.TabPages.Remove(MonsterTab)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

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

End Class
