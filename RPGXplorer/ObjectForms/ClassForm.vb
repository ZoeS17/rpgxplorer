Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ClassForm
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
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents ObjectName As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents SkillPoints As DevExpress.XtraEditors.SpinEdit
    Public WithEvents HitDice As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents ClassTabControl As System.Windows.Forms.TabControl
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Abbreviation As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents LawfulGood As System.Windows.Forms.CheckBox
    Public WithEvents LawfulNeutral As System.Windows.Forms.CheckBox
    Public WithEvents LawfulEvil As System.Windows.Forms.CheckBox
    Public WithEvents NeutralEvil As System.Windows.Forms.CheckBox
    Public WithEvents TrueNeutral As System.Windows.Forms.CheckBox
    Public WithEvents NeutralGood As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticEvil As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticNeutral As System.Windows.Forms.CheckBox
    Public WithEvents ChaoticGood As System.Windows.Forms.CheckBox
    Public WithEvents RestrictMulticlass As System.Windows.Forms.CheckBox
    Public WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents ClassTab As System.Windows.Forms.TabPage
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents LanguageTab As System.Windows.Forms.TabPage
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents RemoveBonus As System.Windows.Forms.Button
    Public WithEvents AddBonus As System.Windows.Forms.Button
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents RemoveAutomatic As System.Windows.Forms.Button
    Public WithEvents AddAutomatic As System.Windows.Forms.Button
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Languages As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents BonusLanguages As RPGXplorer.ListBox
    Public WithEvents AutomaticLanguages As RPGXplorer.ListBox
    Public WithEvents IndentedLine4 As RPGXplorer.IndentedLine
    Public WithEvents PrestigeTab As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents SpellLevel As DevExpress.XtraEditors.SpinEdit
    Public WithEvents SpellLevelLabel As System.Windows.Forms.Label
    Public WithEvents SpellLevelCheck As System.Windows.Forms.CheckBox
    Public WithEvents ArcaneCheck As System.Windows.Forms.RadioButton
    Public WithEvents DivineCheck As System.Windows.Forms.RadioButton
    Public WithEvents EitherCheck As System.Windows.Forms.RadioButton
    Public WithEvents BothCheck As System.Windows.Forms.RadioButton
    Public WithEvents CasterTab As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine5 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine6 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine7 As RPGXplorer.IndentedLine
    Public WithEvents CasterType As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents CasterLabel As System.Windows.Forms.Label
    Public WithEvents BonusLabel As System.Windows.Forms.Label
    Public WithEvents CasterLevelLabel As System.Windows.Forms.Label
    Public WithEvents CasterLevelHalfRadio As System.Windows.Forms.RadioButton
    Public WithEvents CasterLevelEqualRadio As System.Windows.Forms.RadioButton
    Public WithEvents AcquisitionLabel As System.Windows.Forms.Label
    Public WithEvents SpellListRadio As System.Windows.Forms.RadioButton
    Public WithEvents SpellsKnownRadio As System.Windows.Forms.RadioButton
    Public WithEvents PlusBonusLabel As System.Windows.Forms.Label
    Public WithEvents PerLevelSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents PerLevelLabel As System.Windows.Forms.Label
    Public WithEvents FirstSpin As DevExpress.XtraEditors.SpinEdit
    Public WithEvents FirstLabel As System.Windows.Forms.Label
    Public WithEvents SpellBookRadio As System.Windows.Forms.RadioButton
    Public WithEvents ManualSpellsCheck As System.Windows.Forms.CheckBox
    Public WithEvents NoSPDCheck As System.Windows.Forms.CheckBox
    Public WithEvents SpecialCheck As System.Windows.Forms.CheckBox
    Public WithEvents InheritDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents InheritCheck As System.Windows.Forms.CheckBox
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents CasterAbility As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SpellAttribute As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents BonusSpellsCheck As System.Windows.Forms.CheckBox
    Public WithEvents EditChoicesButton As System.Windows.Forms.Button
    Public WithEvents CrossClassList As RPGXplorer.ListBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents ClassSkillChoiceList As DevExpress.XtraEditors.ListBoxControl
    Public WithEvents DomainBonus As System.Windows.Forms.CheckBox
    Public WithEvents SchoolBonus As System.Windows.Forms.CheckBox
    Public WithEvents BonusPointsCheck As System.Windows.Forms.CheckBox
    Public WithEvents RestrictAlignment As System.Windows.Forms.CheckBox
    Public WithEvents PsionicTab As System.Windows.Forms.TabPage
    Public WithEvents IndentedLine8 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine10 As RPGXplorer.IndentedLine
    Public WithEvents InheritPowerDropdown As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents InheritPowerCheck As System.Windows.Forms.CheckBox
    Public WithEvents DisciplineSpecialization As System.Windows.Forms.CheckBox
    Public WithEvents PowerManually As System.Windows.Forms.CheckBox
    Public WithEvents PowerAttribute As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents PrestigePsionic As System.Windows.Forms.CheckBox
    Public WithEvents PrestigeCaster As System.Windows.Forms.CheckBox
    Public WithEvents PowerAbilityLabel As System.Windows.Forms.Label
    Public WithEvents ManifesterMinus As System.Windows.Forms.RadioButton
    Public WithEvents ManifesterEqual As System.Windows.Forms.RadioButton
    Public WithEvents ManifesterLabel As System.Windows.Forms.Label
    Public WithEvents BonusPowerPointsCheck As System.Windows.Forms.CheckBox
	Public WithEvents MemCheck As System.Windows.Forms.CheckBox
	Public WithEvents RestrictDomains As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ClassTabControl = New System.Windows.Forms.TabControl()
		Me.ClassTab = New System.Windows.Forms.TabPage()
		Me.RestrictAlignment = New System.Windows.Forms.CheckBox()
		Me.RestrictMulticlass = New System.Windows.Forms.CheckBox()
		Me.ChaoticEvil = New System.Windows.Forms.CheckBox()
		Me.ChaoticNeutral = New System.Windows.Forms.CheckBox()
		Me.ChaoticGood = New System.Windows.Forms.CheckBox()
		Me.NeutralEvil = New System.Windows.Forms.CheckBox()
		Me.TrueNeutral = New System.Windows.Forms.CheckBox()
		Me.NeutralGood = New System.Windows.Forms.CheckBox()
		Me.LawfulEvil = New System.Windows.Forms.CheckBox()
		Me.LawfulNeutral = New System.Windows.Forms.CheckBox()
		Me.LawfulGood = New System.Windows.Forms.CheckBox()
		Me.Abbreviation = New DevExpress.XtraEditors.TextEdit()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.CasterAbility = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.SkillPoints = New DevExpress.XtraEditors.SpinEdit()
		Me.IndentedLine3 = New RPGXplorer.IndentedLine()
		Me.IndentedLine1 = New RPGXplorer.IndentedLine()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.HitDice = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.ObjectName = New DevExpress.XtraEditors.TextEdit()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.ClassSkillChoiceList = New DevExpress.XtraEditors.ListBoxControl()
		Me.EditChoicesButton = New System.Windows.Forms.Button()
		Me.CrossClassList = New RPGXplorer.ListBox()
		Me.LanguageTab = New System.Windows.Forms.TabPage()
		Me.IndentedLine4 = New RPGXplorer.IndentedLine()
		Me.BonusLanguages = New RPGXplorer.ListBox()
		Me.AutomaticLanguages = New RPGXplorer.ListBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.RemoveBonus = New System.Windows.Forms.Button()
		Me.AddBonus = New System.Windows.Forms.Button()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.RemoveAutomatic = New System.Windows.Forms.Button()
		Me.AddAutomatic = New System.Windows.Forms.Button()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Languages = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.CasterTab = New System.Windows.Forms.TabPage()
		Me.MemCheck = New System.Windows.Forms.CheckBox()
		Me.RestrictDomains = New System.Windows.Forms.CheckBox()
		Me.BonusPointsCheck = New System.Windows.Forms.CheckBox()
		Me.SchoolBonus = New System.Windows.Forms.CheckBox()
		Me.BonusSpellsCheck = New System.Windows.Forms.CheckBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.SpellsKnownRadio = New System.Windows.Forms.RadioButton()
		Me.SpellListRadio = New System.Windows.Forms.RadioButton()
		Me.PlusBonusLabel = New System.Windows.Forms.Label()
		Me.PerLevelSpin = New DevExpress.XtraEditors.SpinEdit()
		Me.PerLevelLabel = New System.Windows.Forms.Label()
		Me.FirstSpin = New DevExpress.XtraEditors.SpinEdit()
		Me.FirstLabel = New System.Windows.Forms.Label()
		Me.SpellBookRadio = New System.Windows.Forms.RadioButton()
		Me.AcquisitionLabel = New System.Windows.Forms.Label()
		Me.NoSPDCheck = New System.Windows.Forms.CheckBox()
		Me.InheritDropdown = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.InheritCheck = New System.Windows.Forms.CheckBox()
		Me.SpecialCheck = New System.Windows.Forms.CheckBox()
		Me.ManualSpellsCheck = New System.Windows.Forms.CheckBox()
		Me.CasterLevelHalfRadio = New System.Windows.Forms.RadioButton()
		Me.CasterLevelEqualRadio = New System.Windows.Forms.RadioButton()
		Me.CasterLevelLabel = New System.Windows.Forms.Label()
		Me.SpellAttribute = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.BonusLabel = New System.Windows.Forms.Label()
		Me.CasterType = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.CasterLabel = New System.Windows.Forms.Label()
		Me.DomainBonus = New System.Windows.Forms.CheckBox()
		Me.IndentedLine7 = New RPGXplorer.IndentedLine()
		Me.IndentedLine6 = New RPGXplorer.IndentedLine()
		Me.IndentedLine5 = New RPGXplorer.IndentedLine()
		Me.PsionicTab = New System.Windows.Forms.TabPage()
		Me.BonusPowerPointsCheck = New System.Windows.Forms.CheckBox()
		Me.ManifesterMinus = New System.Windows.Forms.RadioButton()
		Me.ManifesterEqual = New System.Windows.Forms.RadioButton()
		Me.ManifesterLabel = New System.Windows.Forms.Label()
		Me.InheritPowerDropdown = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.InheritPowerCheck = New System.Windows.Forms.CheckBox()
		Me.DisciplineSpecialization = New System.Windows.Forms.CheckBox()
		Me.PowerManually = New System.Windows.Forms.CheckBox()
		Me.PowerAttribute = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.PowerAbilityLabel = New System.Windows.Forms.Label()
		Me.IndentedLine8 = New RPGXplorer.IndentedLine()
		Me.IndentedLine10 = New RPGXplorer.IndentedLine()
		Me.PrestigeTab = New System.Windows.Forms.TabPage()
		Me.PrestigeCaster = New System.Windows.Forms.CheckBox()
		Me.PrestigePsionic = New System.Windows.Forms.CheckBox()
		Me.BothCheck = New System.Windows.Forms.RadioButton()
		Me.EitherCheck = New System.Windows.Forms.RadioButton()
		Me.DivineCheck = New System.Windows.Forms.RadioButton()
		Me.ArcaneCheck = New System.Windows.Forms.RadioButton()
		Me.SpellLevel = New DevExpress.XtraEditors.SpinEdit()
		Me.SpellLevelLabel = New System.Windows.Forms.Label()
		Me.SpellLevelCheck = New System.Windows.Forms.CheckBox()
		Me.IndentedLine2 = New RPGXplorer.IndentedLine()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.PropertiesTab = New RPGXplorer.PropertiesTab()
		Me.Cancel = New System.Windows.Forms.Button()
		Me.OK = New System.Windows.Forms.Button()
		Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ClassTabControl.SuspendLayout()
		Me.ClassTab.SuspendLayout()
		CType(Me.Abbreviation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CasterAbility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SkillPoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.HitDice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage1.SuspendLayout()
		CType(Me.ClassSkillChoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LanguageTab.SuspendLayout()
		CType(Me.Languages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.CasterTab.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.PerLevelSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FirstSpin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.InheritDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SpellAttribute.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CasterType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PsionicTab.SuspendLayout()
		CType(Me.InheritPowerDropdown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PowerAttribute.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PrestigeTab.SuspendLayout()
		CType(Me.SpellLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage3.SuspendLayout()
		CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ClassTabControl
		'
		Me.ClassTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ClassTabControl.Controls.Add(Me.ClassTab)
		Me.ClassTabControl.Controls.Add(Me.TabPage1)
		Me.ClassTabControl.Controls.Add(Me.LanguageTab)
		Me.ClassTabControl.Controls.Add(Me.CasterTab)
		Me.ClassTabControl.Controls.Add(Me.PsionicTab)
		Me.ClassTabControl.Controls.Add(Me.PrestigeTab)
		Me.ClassTabControl.Controls.Add(Me.TabPage3)
		Me.ClassTabControl.Location = New System.Drawing.Point(15, 15)
		Me.ClassTabControl.Name = "ClassTabControl"
		Me.ClassTabControl.SelectedIndex = 0
		Me.ClassTabControl.Size = New System.Drawing.Size(415, 651)
		Me.ClassTabControl.TabIndex = 0
		'
		'ClassTab
		'
		Me.ClassTab.Controls.Add(Me.RestrictAlignment)
		Me.ClassTab.Controls.Add(Me.RestrictMulticlass)
		Me.ClassTab.Controls.Add(Me.ChaoticEvil)
		Me.ClassTab.Controls.Add(Me.ChaoticNeutral)
		Me.ClassTab.Controls.Add(Me.ChaoticGood)
		Me.ClassTab.Controls.Add(Me.NeutralEvil)
		Me.ClassTab.Controls.Add(Me.TrueNeutral)
		Me.ClassTab.Controls.Add(Me.NeutralGood)
		Me.ClassTab.Controls.Add(Me.LawfulEvil)
		Me.ClassTab.Controls.Add(Me.LawfulNeutral)
		Me.ClassTab.Controls.Add(Me.LawfulGood)
		Me.ClassTab.Controls.Add(Me.Abbreviation)
		Me.ClassTab.Controls.Add(Me.Label7)
		Me.ClassTab.Controls.Add(Me.CasterAbility)
		Me.ClassTab.Controls.Add(Me.Label10)
		Me.ClassTab.Controls.Add(Me.SkillPoints)
		Me.ClassTab.Controls.Add(Me.IndentedLine3)
		Me.ClassTab.Controls.Add(Me.IndentedLine1)
		Me.ClassTab.Controls.Add(Me.Label3)
		Me.ClassTab.Controls.Add(Me.HitDice)
		Me.ClassTab.Controls.Add(Me.Label1)
		Me.ClassTab.Controls.Add(Me.Label11)
		Me.ClassTab.Controls.Add(Me.ObjectName)
		Me.ClassTab.Controls.Add(Me.Label2)
		Me.ClassTab.Location = New System.Drawing.Point(4, 22)
		Me.ClassTab.Name = "ClassTab"
		Me.ClassTab.Size = New System.Drawing.Size(407, 625)
		Me.ClassTab.TabIndex = 0
		Me.ClassTab.Text = "Class"
		'
		'RestrictAlignment
		'
		Me.RestrictAlignment.CausesValidation = False
		Me.RestrictAlignment.Location = New System.Drawing.Point(15, 480)
		Me.RestrictAlignment.Name = "RestrictAlignment"
		Me.RestrictAlignment.Size = New System.Drawing.Size(365, 21)
		Me.RestrictAlignment.TabIndex = 132
		Me.RestrictAlignment.Text = "Character's alignment must be allowed by their deity"
		'
		'RestrictMulticlass
		'
		Me.RestrictMulticlass.CausesValidation = False
		Me.RestrictMulticlass.Location = New System.Drawing.Point(15, 510)
		Me.RestrictMulticlass.Name = "RestrictMulticlass"
		Me.RestrictMulticlass.Size = New System.Drawing.Size(365, 21)
		Me.RestrictMulticlass.TabIndex = 15
		Me.RestrictMulticlass.Text = "Cannot progress this class further upon multiclassing"
		'
		'ChaoticEvil
		'
		Me.ChaoticEvil.CausesValidation = False
		Me.ChaoticEvil.Checked = True
		Me.ChaoticEvil.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChaoticEvil.Location = New System.Drawing.Point(15, 430)
		Me.ChaoticEvil.Name = "ChaoticEvil"
		Me.ChaoticEvil.Size = New System.Drawing.Size(100, 21)
		Me.ChaoticEvil.TabIndex = 14
		Me.ChaoticEvil.Text = "Chaotic Evil"
		'
		'ChaoticNeutral
		'
		Me.ChaoticNeutral.CausesValidation = False
		Me.ChaoticNeutral.Checked = True
		Me.ChaoticNeutral.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChaoticNeutral.Location = New System.Drawing.Point(15, 400)
		Me.ChaoticNeutral.Name = "ChaoticNeutral"
		Me.ChaoticNeutral.Size = New System.Drawing.Size(105, 21)
		Me.ChaoticNeutral.TabIndex = 13
		Me.ChaoticNeutral.Text = "Chaotic Neutral"
		'
		'ChaoticGood
		'
		Me.ChaoticGood.CausesValidation = False
		Me.ChaoticGood.Checked = True
		Me.ChaoticGood.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChaoticGood.Location = New System.Drawing.Point(15, 370)
		Me.ChaoticGood.Name = "ChaoticGood"
		Me.ChaoticGood.Size = New System.Drawing.Size(95, 21)
		Me.ChaoticGood.TabIndex = 12
		Me.ChaoticGood.Text = "Chaotic Good"
		'
		'NeutralEvil
		'
		Me.NeutralEvil.CausesValidation = False
		Me.NeutralEvil.Checked = True
		Me.NeutralEvil.CheckState = System.Windows.Forms.CheckState.Checked
		Me.NeutralEvil.Location = New System.Drawing.Point(15, 340)
		Me.NeutralEvil.Name = "NeutralEvil"
		Me.NeutralEvil.Size = New System.Drawing.Size(100, 21)
		Me.NeutralEvil.TabIndex = 11
		Me.NeutralEvil.Text = "Neutral Evil"
		'
		'TrueNeutral
		'
		Me.TrueNeutral.CausesValidation = False
		Me.TrueNeutral.Checked = True
		Me.TrueNeutral.CheckState = System.Windows.Forms.CheckState.Checked
		Me.TrueNeutral.Location = New System.Drawing.Point(15, 310)
		Me.TrueNeutral.Name = "TrueNeutral"
		Me.TrueNeutral.Size = New System.Drawing.Size(100, 21)
		Me.TrueNeutral.TabIndex = 10
		Me.TrueNeutral.Text = "True Neutral"
		'
		'NeutralGood
		'
		Me.NeutralGood.CausesValidation = False
		Me.NeutralGood.Checked = True
		Me.NeutralGood.CheckState = System.Windows.Forms.CheckState.Checked
		Me.NeutralGood.Location = New System.Drawing.Point(15, 280)
		Me.NeutralGood.Name = "NeutralGood"
		Me.NeutralGood.Size = New System.Drawing.Size(90, 21)
		Me.NeutralGood.TabIndex = 9
		Me.NeutralGood.Text = "Neutral Good"
		'
		'LawfulEvil
		'
		Me.LawfulEvil.CausesValidation = False
		Me.LawfulEvil.Checked = True
		Me.LawfulEvil.CheckState = System.Windows.Forms.CheckState.Checked
		Me.LawfulEvil.Location = New System.Drawing.Point(15, 250)
		Me.LawfulEvil.Name = "LawfulEvil"
		Me.LawfulEvil.Size = New System.Drawing.Size(100, 21)
		Me.LawfulEvil.TabIndex = 8
		Me.LawfulEvil.Text = "Lawful Evil"
		'
		'LawfulNeutral
		'
		Me.LawfulNeutral.CausesValidation = False
		Me.LawfulNeutral.Checked = True
		Me.LawfulNeutral.CheckState = System.Windows.Forms.CheckState.Checked
		Me.LawfulNeutral.Location = New System.Drawing.Point(15, 220)
		Me.LawfulNeutral.Name = "LawfulNeutral"
		Me.LawfulNeutral.Size = New System.Drawing.Size(100, 21)
		Me.LawfulNeutral.TabIndex = 7
		Me.LawfulNeutral.Text = "Lawful Neutral"
		'
		'LawfulGood
		'
		Me.LawfulGood.CausesValidation = False
		Me.LawfulGood.Checked = True
		Me.LawfulGood.CheckState = System.Windows.Forms.CheckState.Checked
		Me.LawfulGood.Location = New System.Drawing.Point(15, 190)
		Me.LawfulGood.Name = "LawfulGood"
		Me.LawfulGood.Size = New System.Drawing.Size(90, 21)
		Me.LawfulGood.TabIndex = 6
		Me.LawfulGood.Text = "Lawful Good"
		'
		'Abbreviation
		'
		Me.Abbreviation.CausesValidation = False
		Me.Abbreviation.Location = New System.Drawing.Point(310, 15)
		Me.Abbreviation.Name = "Abbreviation"
		Me.Abbreviation.Properties.AutoHeight = False
		Me.Abbreviation.Properties.MaxLength = 3
		Me.Abbreviation.Size = New System.Drawing.Size(50, 21)
		Me.Abbreviation.TabIndex = 1
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Location = New System.Drawing.Point(235, 15)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(70, 21)
		Me.Label7.TabIndex = 131
		Me.Label7.Text = "Abbreviation"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'CasterAbility
		'
		Me.CasterAbility.EditValue = ""
		Me.CasterAbility.Location = New System.Drawing.Point(130, 105)
		Me.CasterAbility.Name = "CasterAbility"
		Me.CasterAbility.Properties.AutoHeight = False
		Me.CasterAbility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.CasterAbility.Properties.DropDownRows = 10
		Me.CasterAbility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.CasterAbility.Size = New System.Drawing.Size(150, 21)
		Me.CasterAbility.TabIndex = 4
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Location = New System.Drawing.Point(15, 155)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(110, 21)
		Me.Label10.TabIndex = 126
		Me.Label10.Text = "Allowed Alignments"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SkillPoints
		'
		Me.SkillPoints.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.SkillPoints.Location = New System.Drawing.Point(130, 45)
		Me.SkillPoints.Name = "SkillPoints"
		Me.SkillPoints.Properties.Appearance.Options.UseTextOptions = True
		Me.SkillPoints.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.SkillPoints.Properties.AutoHeight = False
		Me.SkillPoints.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.SkillPoints.Properties.IsFloatValue = False
		Me.SkillPoints.Properties.Mask.BeepOnError = True
		Me.SkillPoints.Properties.Mask.EditMask = "d"
		Me.SkillPoints.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.SkillPoints.Properties.Mask.ShowPlaceHolders = False
		Me.SkillPoints.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
		Me.SkillPoints.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.SkillPoints.Size = New System.Drawing.Size(50, 21)
		Me.SkillPoints.TabIndex = 2
		'
		'IndentedLine3
		'
		Me.IndentedLine3.CausesValidation = False
		Me.IndentedLine3.Location = New System.Drawing.Point(15, 465)
		Me.IndentedLine3.Name = "IndentedLine3"
		Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine3.TabIndex = 122
		Me.IndentedLine3.TabStop = False
		'
		'IndentedLine1
		'
		Me.IndentedLine1.CausesValidation = False
		Me.IndentedLine1.Location = New System.Drawing.Point(15, 140)
		Me.IndentedLine1.Name = "IndentedLine1"
		Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine1.TabIndex = 119
		Me.IndentedLine1.TabStop = False
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Location = New System.Drawing.Point(15, 75)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(45, 21)
		Me.Label3.TabIndex = 106
		Me.Label3.Text = "Hit Dice"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'HitDice
		'
		Me.HitDice.Location = New System.Drawing.Point(130, 75)
		Me.HitDice.Name = "HitDice"
		Me.HitDice.Properties.AutoHeight = False
		Me.HitDice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.HitDice.Properties.DropDownRows = 10
		Me.HitDice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.HitDice.Size = New System.Drawing.Size(50, 21)
		Me.HitDice.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Location = New System.Drawing.Point(15, 105)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(115, 21)
		Me.Label1.TabIndex = 105
		Me.Label1.Text = "Spellcasting / Psionic"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Location = New System.Drawing.Point(15, 45)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(115, 21)
		Me.Label11.TabIndex = 104
		Me.Label11.Text = "Skill Points per Level"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ObjectName
		'
		Me.ObjectName.Location = New System.Drawing.Point(65, 15)
		Me.ObjectName.Name = "ObjectName"
		Me.ObjectName.Properties.AutoHeight = False
		Me.ObjectName.Properties.MaxLength = 100
		Me.ObjectName.Size = New System.Drawing.Size(150, 21)
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
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.Label5)
		Me.TabPage1.Controls.Add(Me.Label4)
		Me.TabPage1.Controls.Add(Me.ClassSkillChoiceList)
		Me.TabPage1.Controls.Add(Me.EditChoicesButton)
		Me.TabPage1.Controls.Add(Me.CrossClassList)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(407, 625)
		Me.TabPage1.TabIndex = 1
		Me.TabPage1.Text = "Class Skills"
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Location = New System.Drawing.Point(15, 325)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(105, 21)
		Me.Label5.TabIndex = 131
		Me.Label5.Text = "Cross-Class Skills"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Location = New System.Drawing.Point(15, 15)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(70, 21)
		Me.Label4.TabIndex = 130
		Me.Label4.Text = "Class Skills"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ClassSkillChoiceList
		'
		Me.ClassSkillChoiceList.Location = New System.Drawing.Point(15, 40)
		Me.ClassSkillChoiceList.Name = "ClassSkillChoiceList"
		Me.ClassSkillChoiceList.Size = New System.Drawing.Size(225, 260)
		Me.ClassSkillChoiceList.SortOrder = System.Windows.Forms.SortOrder.Ascending
		Me.ClassSkillChoiceList.TabIndex = 128
		Me.ClassSkillChoiceList.TabStop = False
		'
		'EditChoicesButton
		'
		Me.EditChoicesButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditChoicesButton.Location = New System.Drawing.Point(255, 40)
		Me.EditChoicesButton.Name = "EditChoicesButton"
		Me.EditChoicesButton.Size = New System.Drawing.Size(110, 24)
		Me.EditChoicesButton.TabIndex = 127
		Me.EditChoicesButton.Text = "Edit Class Skills"
		'
		'CrossClassList
		'
		Me.CrossClassList.Location = New System.Drawing.Point(15, 350)
		Me.CrossClassList.Name = "CrossClassList"
		Me.CrossClassList.SelectedIndex = -1
		Me.CrossClassList.Size = New System.Drawing.Size(225, 255)
		Me.CrossClassList.TabIndex = 129
		'
		'LanguageTab
		'
		Me.LanguageTab.Controls.Add(Me.IndentedLine4)
		Me.LanguageTab.Controls.Add(Me.BonusLanguages)
		Me.LanguageTab.Controls.Add(Me.AutomaticLanguages)
		Me.LanguageTab.Controls.Add(Me.Label15)
		Me.LanguageTab.Controls.Add(Me.RemoveBonus)
		Me.LanguageTab.Controls.Add(Me.AddBonus)
		Me.LanguageTab.Controls.Add(Me.Label14)
		Me.LanguageTab.Controls.Add(Me.RemoveAutomatic)
		Me.LanguageTab.Controls.Add(Me.AddAutomatic)
		Me.LanguageTab.Controls.Add(Me.Label13)
		Me.LanguageTab.Controls.Add(Me.Languages)
		Me.LanguageTab.Location = New System.Drawing.Point(4, 22)
		Me.LanguageTab.Name = "LanguageTab"
		Me.LanguageTab.Size = New System.Drawing.Size(407, 625)
		Me.LanguageTab.TabIndex = 4
		Me.LanguageTab.Text = "Languages"
		'
		'IndentedLine4
		'
		Me.IndentedLine4.Location = New System.Drawing.Point(15, 50)
		Me.IndentedLine4.Name = "IndentedLine4"
		Me.IndentedLine4.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine4.TabIndex = 128
		Me.IndentedLine4.TabStop = False
		'
		'BonusLanguages
		'
		Me.BonusLanguages.Location = New System.Drawing.Point(15, 235)
		Me.BonusLanguages.Name = "BonusLanguages"
		Me.BonusLanguages.SelectedIndex = -1
		Me.BonusLanguages.Size = New System.Drawing.Size(240, 100)
		Me.BonusLanguages.TabIndex = 127
		'
		'AutomaticLanguages
		'
		Me.AutomaticLanguages.Location = New System.Drawing.Point(15, 95)
		Me.AutomaticLanguages.Name = "AutomaticLanguages"
		Me.AutomaticLanguages.SelectedIndex = -1
		Me.AutomaticLanguages.Size = New System.Drawing.Size(240, 95)
		Me.AutomaticLanguages.TabIndex = 126
		'
		'Label15
		'
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.Location = New System.Drawing.Point(15, 205)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(115, 21)
		Me.Label15.TabIndex = 125
		Me.Label15.Text = "Bonus Languages"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'RemoveBonus
		'
		Me.RemoveBonus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RemoveBonus.Location = New System.Drawing.Point(270, 265)
		Me.RemoveBonus.Name = "RemoveBonus"
		Me.RemoveBonus.Size = New System.Drawing.Size(120, 24)
		Me.RemoveBonus.TabIndex = 121
		Me.RemoveBonus.Text = "Remove Bonus"
		'
		'AddBonus
		'
		Me.AddBonus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddBonus.Location = New System.Drawing.Point(270, 235)
		Me.AddBonus.Name = "AddBonus"
		Me.AddBonus.Size = New System.Drawing.Size(120, 24)
		Me.AddBonus.TabIndex = 120
		Me.AddBonus.Text = "Add Bonus"
		'
		'Label14
		'
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.Location = New System.Drawing.Point(15, 65)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(115, 21)
		Me.Label14.TabIndex = 124
		Me.Label14.Text = "Automatic Languages"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'RemoveAutomatic
		'
		Me.RemoveAutomatic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RemoveAutomatic.Location = New System.Drawing.Point(270, 125)
		Me.RemoveAutomatic.Name = "RemoveAutomatic"
		Me.RemoveAutomatic.Size = New System.Drawing.Size(120, 24)
		Me.RemoveAutomatic.TabIndex = 118
		Me.RemoveAutomatic.Text = "Remove Automatic"
		'
		'AddAutomatic
		'
		Me.AddAutomatic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddAutomatic.Location = New System.Drawing.Point(270, 95)
		Me.AddAutomatic.Name = "AddAutomatic"
		Me.AddAutomatic.Size = New System.Drawing.Size(120, 24)
		Me.AddAutomatic.TabIndex = 117
		Me.AddAutomatic.Text = "Add Automatic"
		'
		'Label13
		'
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.Location = New System.Drawing.Point(15, 15)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(60, 21)
		Me.Label13.TabIndex = 123
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
		Me.Languages.Size = New System.Drawing.Size(150, 21)
		Me.Languages.TabIndex = 116
		'
		'CasterTab
		'
		Me.CasterTab.Controls.Add(Me.MemCheck)
		Me.CasterTab.Controls.Add(Me.RestrictDomains)
		Me.CasterTab.Controls.Add(Me.BonusPointsCheck)
		Me.CasterTab.Controls.Add(Me.SchoolBonus)
		Me.CasterTab.Controls.Add(Me.BonusSpellsCheck)
		Me.CasterTab.Controls.Add(Me.Panel1)
		Me.CasterTab.Controls.Add(Me.InheritDropdown)
		Me.CasterTab.Controls.Add(Me.InheritCheck)
		Me.CasterTab.Controls.Add(Me.SpecialCheck)
		Me.CasterTab.Controls.Add(Me.ManualSpellsCheck)
		Me.CasterTab.Controls.Add(Me.CasterLevelHalfRadio)
		Me.CasterTab.Controls.Add(Me.CasterLevelEqualRadio)
		Me.CasterTab.Controls.Add(Me.CasterLevelLabel)
		Me.CasterTab.Controls.Add(Me.SpellAttribute)
		Me.CasterTab.Controls.Add(Me.BonusLabel)
		Me.CasterTab.Controls.Add(Me.CasterType)
		Me.CasterTab.Controls.Add(Me.CasterLabel)
		Me.CasterTab.Controls.Add(Me.DomainBonus)
		Me.CasterTab.Controls.Add(Me.IndentedLine7)
		Me.CasterTab.Controls.Add(Me.IndentedLine6)
		Me.CasterTab.Controls.Add(Me.IndentedLine5)
		Me.CasterTab.Location = New System.Drawing.Point(4, 22)
		Me.CasterTab.Name = "CasterTab"
		Me.CasterTab.Size = New System.Drawing.Size(407, 625)
		Me.CasterTab.TabIndex = 6
		Me.CasterTab.Text = "Caster"
		'
		'MemCheck
		'
		Me.MemCheck.CausesValidation = False
		Me.MemCheck.Location = New System.Drawing.Point(15, 430)
		Me.MemCheck.Name = "MemCheck"
		Me.MemCheck.Size = New System.Drawing.Size(125, 21)
		Me.MemCheck.TabIndex = 173
		Me.MemCheck.Text = "Memorize Spells"
		'
		'RestrictDomains
		'
		Me.RestrictDomains.CausesValidation = False
		Me.RestrictDomains.Location = New System.Drawing.Point(15, 510)
		Me.RestrictDomains.Name = "RestrictDomains"
		Me.RestrictDomains.Size = New System.Drawing.Size(310, 21)
		Me.RestrictDomains.TabIndex = 171
		Me.RestrictDomains.Text = "Restrict Domain Options by Deity"
		'
		'BonusPointsCheck
		'
		Me.BonusPointsCheck.CausesValidation = False
		Me.BonusPointsCheck.Checked = True
		Me.BonusPointsCheck.CheckState = System.Windows.Forms.CheckState.Checked
		Me.BonusPointsCheck.Enabled = False
		Me.BonusPointsCheck.Location = New System.Drawing.Point(200, 75)
		Me.BonusPointsCheck.Name = "BonusPointsCheck"
		Me.BonusPointsCheck.Size = New System.Drawing.Size(165, 21)
		Me.BonusPointsCheck.TabIndex = 158
		Me.BonusPointsCheck.Text = "Bonus Spell Points"
		'
		'SchoolBonus
		'
		Me.SchoolBonus.CausesValidation = False
		Me.SchoolBonus.Enabled = False
		Me.SchoolBonus.Location = New System.Drawing.Point(200, 135)
		Me.SchoolBonus.Name = "SchoolBonus"
		Me.SchoolBonus.Size = New System.Drawing.Size(200, 21)
		Me.SchoolBonus.TabIndex = 157
		Me.SchoolBonus.Text = "Bonus Spells on Specialist Access"
		'
		'BonusSpellsCheck
		'
		Me.BonusSpellsCheck.CausesValidation = False
		Me.BonusSpellsCheck.Checked = True
		Me.BonusSpellsCheck.CheckState = System.Windows.Forms.CheckState.Checked
		Me.BonusSpellsCheck.Enabled = False
		Me.BonusSpellsCheck.Location = New System.Drawing.Point(200, 45)
		Me.BonusSpellsCheck.Name = "BonusSpellsCheck"
		Me.BonusSpellsCheck.Size = New System.Drawing.Size(165, 21)
		Me.BonusSpellsCheck.TabIndex = 156
		Me.BonusSpellsCheck.Text = "Bonus Spells per Day"
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.SpellsKnownRadio)
		Me.Panel1.Controls.Add(Me.SpellListRadio)
		Me.Panel1.Controls.Add(Me.PlusBonusLabel)
		Me.Panel1.Controls.Add(Me.PerLevelSpin)
		Me.Panel1.Controls.Add(Me.PerLevelLabel)
		Me.Panel1.Controls.Add(Me.FirstSpin)
		Me.Panel1.Controls.Add(Me.FirstLabel)
		Me.Panel1.Controls.Add(Me.SpellBookRadio)
		Me.Panel1.Controls.Add(Me.AcquisitionLabel)
		Me.Panel1.Controls.Add(Me.NoSPDCheck)
		Me.Panel1.Location = New System.Drawing.Point(15, 180)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(380, 215)
		Me.Panel1.TabIndex = 155
		'
		'SpellsKnownRadio
		'
		Me.SpellsKnownRadio.Location = New System.Drawing.Point(15, 65)
		Me.SpellsKnownRadio.Name = "SpellsKnownRadio"
		Me.SpellsKnownRadio.Size = New System.Drawing.Size(125, 24)
		Me.SpellsKnownRadio.TabIndex = 145
		Me.SpellsKnownRadio.Text = "Spells Known"
		'
		'SpellListRadio
		'
		Me.SpellListRadio.Checked = True
		Me.SpellListRadio.Location = New System.Drawing.Point(15, 35)
		Me.SpellListRadio.Name = "SpellListRadio"
		Me.SpellListRadio.Size = New System.Drawing.Size(125, 24)
		Me.SpellListRadio.TabIndex = 144
		Me.SpellListRadio.TabStop = True
		Me.SpellListRadio.Text = "Spell List"
		'
		'PlusBonusLabel
		'
		Me.PlusBonusLabel.BackColor = System.Drawing.SystemColors.Control
		Me.PlusBonusLabel.Enabled = False
		Me.PlusBonusLabel.Location = New System.Drawing.Point(200, 155)
		Me.PlusBonusLabel.Name = "PlusBonusLabel"
		Me.PlusBonusLabel.Size = New System.Drawing.Size(160, 21)
		Me.PlusBonusLabel.TabIndex = 143
		Me.PlusBonusLabel.Text = "+ Spell Ability Score Modifier"
		Me.PlusBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PerLevelSpin
		'
		Me.PerLevelSpin.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
		Me.PerLevelSpin.Enabled = False
		Me.PerLevelSpin.Location = New System.Drawing.Point(140, 185)
		Me.PerLevelSpin.Name = "PerLevelSpin"
		Me.PerLevelSpin.Properties.Appearance.Options.UseTextOptions = True
		Me.PerLevelSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.PerLevelSpin.Properties.AutoHeight = False
		Me.PerLevelSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.PerLevelSpin.Properties.IsFloatValue = False
		Me.PerLevelSpin.Properties.Mask.BeepOnError = True
		Me.PerLevelSpin.Properties.Mask.EditMask = "d"
		Me.PerLevelSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.PerLevelSpin.Properties.Mask.ShowPlaceHolders = False
		Me.PerLevelSpin.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
		Me.PerLevelSpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.PerLevelSpin.Size = New System.Drawing.Size(50, 21)
		Me.PerLevelSpin.TabIndex = 141
		'
		'PerLevelLabel
		'
		Me.PerLevelLabel.BackColor = System.Drawing.SystemColors.Control
		Me.PerLevelLabel.Enabled = False
		Me.PerLevelLabel.Location = New System.Drawing.Point(30, 185)
		Me.PerLevelLabel.Name = "PerLevelLabel"
		Me.PerLevelLabel.Size = New System.Drawing.Size(115, 21)
		Me.PerLevelLabel.TabIndex = 142
		Me.PerLevelLabel.Text = "Spells per Level"
		Me.PerLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FirstSpin
		'
		Me.FirstSpin.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
		Me.FirstSpin.Enabled = False
		Me.FirstSpin.Location = New System.Drawing.Point(140, 155)
		Me.FirstSpin.Name = "FirstSpin"
		Me.FirstSpin.Properties.Appearance.Options.UseTextOptions = True
		Me.FirstSpin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.FirstSpin.Properties.AutoHeight = False
		Me.FirstSpin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.FirstSpin.Properties.IsFloatValue = False
		Me.FirstSpin.Properties.Mask.BeepOnError = True
		Me.FirstSpin.Properties.Mask.EditMask = "d"
		Me.FirstSpin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.FirstSpin.Properties.Mask.ShowPlaceHolders = False
		Me.FirstSpin.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
		Me.FirstSpin.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.FirstSpin.Size = New System.Drawing.Size(50, 21)
		Me.FirstSpin.TabIndex = 139
		'
		'FirstLabel
		'
		Me.FirstLabel.BackColor = System.Drawing.SystemColors.Control
		Me.FirstLabel.Enabled = False
		Me.FirstLabel.Location = New System.Drawing.Point(30, 155)
		Me.FirstLabel.Name = "FirstLabel"
		Me.FirstLabel.Size = New System.Drawing.Size(115, 21)
		Me.FirstLabel.TabIndex = 140
		Me.FirstLabel.Text = "First Level Spells"
		Me.FirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SpellBookRadio
		'
		Me.SpellBookRadio.Location = New System.Drawing.Point(15, 125)
		Me.SpellBookRadio.Name = "SpellBookRadio"
		Me.SpellBookRadio.Size = New System.Drawing.Size(125, 24)
		Me.SpellBookRadio.TabIndex = 138
		Me.SpellBookRadio.Text = "Spellbook"
		'
		'AcquisitionLabel
		'
		Me.AcquisitionLabel.Location = New System.Drawing.Point(0, 5)
		Me.AcquisitionLabel.Name = "AcquisitionLabel"
		Me.AcquisitionLabel.Size = New System.Drawing.Size(155, 23)
		Me.AcquisitionLabel.TabIndex = 137
		Me.AcquisitionLabel.Text = "Spell Acquisition"
		Me.AcquisitionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'NoSPDCheck
		'
		Me.NoSPDCheck.CausesValidation = False
		Me.NoSPDCheck.Enabled = False
		Me.NoSPDCheck.Location = New System.Drawing.Point(30, 95)
		Me.NoSPDCheck.Name = "NoSPDCheck"
		Me.NoSPDCheck.Size = New System.Drawing.Size(155, 21)
		Me.NoSPDCheck.TabIndex = 146
		Me.NoSPDCheck.Text = "No Spells per Day"
		'
		'InheritDropdown
		'
		Me.InheritDropdown.EditValue = ""
		Me.InheritDropdown.Enabled = False
		Me.InheritDropdown.Location = New System.Drawing.Point(30, 590)
		Me.InheritDropdown.Name = "InheritDropdown"
		Me.InheritDropdown.Properties.AutoHeight = False
		Me.InheritDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.InheritDropdown.Properties.DropDownRows = 10
		Me.InheritDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.InheritDropdown.Size = New System.Drawing.Size(200, 21)
		Me.InheritDropdown.TabIndex = 154
		'
		'InheritCheck
		'
		Me.InheritCheck.CausesValidation = False
		Me.InheritCheck.Location = New System.Drawing.Point(15, 560)
		Me.InheritCheck.Name = "InheritCheck"
		Me.InheritCheck.Size = New System.Drawing.Size(155, 21)
		Me.InheritCheck.TabIndex = 153
		Me.InheritCheck.Text = "Inherit Spell List"
		'
		'SpecialCheck
		'
		Me.SpecialCheck.CausesValidation = False
		Me.SpecialCheck.Location = New System.Drawing.Point(15, 480)
		Me.SpecialCheck.Name = "SpecialCheck"
		Me.SpecialCheck.Size = New System.Drawing.Size(195, 21)
		Me.SpecialCheck.TabIndex = 151
		Me.SpecialCheck.Text = "Can Choose Specialist School"
		'
		'ManualSpellsCheck
		'
		Me.ManualSpellsCheck.CausesValidation = False
		Me.ManualSpellsCheck.Location = New System.Drawing.Point(15, 400)
		Me.ManualSpellsCheck.Name = "ManualSpellsCheck"
		Me.ManualSpellsCheck.Size = New System.Drawing.Size(330, 21)
		Me.ManualSpellsCheck.TabIndex = 147
		Me.ManualSpellsCheck.Text = "Take Spells Manually (skip spell selection during wizard)"
		'
		'CasterLevelHalfRadio
		'
		Me.CasterLevelHalfRadio.Location = New System.Drawing.Point(30, 135)
		Me.CasterLevelHalfRadio.Name = "CasterLevelHalfRadio"
		Me.CasterLevelHalfRadio.Size = New System.Drawing.Size(150, 24)
		Me.CasterLevelHalfRadio.TabIndex = 136
		Me.CasterLevelHalfRadio.Text = "Equal to half class level"
		'
		'CasterLevelEqualRadio
		'
		Me.CasterLevelEqualRadio.Checked = True
		Me.CasterLevelEqualRadio.Location = New System.Drawing.Point(30, 105)
		Me.CasterLevelEqualRadio.Name = "CasterLevelEqualRadio"
		Me.CasterLevelEqualRadio.Size = New System.Drawing.Size(125, 24)
		Me.CasterLevelEqualRadio.TabIndex = 135
		Me.CasterLevelEqualRadio.TabStop = True
		Me.CasterLevelEqualRadio.Text = "Equal to class level"
		'
		'CasterLevelLabel
		'
		Me.CasterLevelLabel.Location = New System.Drawing.Point(15, 75)
		Me.CasterLevelLabel.Name = "CasterLevelLabel"
		Me.CasterLevelLabel.Size = New System.Drawing.Size(155, 23)
		Me.CasterLevelLabel.TabIndex = 134
		Me.CasterLevelLabel.Text = "Caster Level"
		Me.CasterLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SpellAttribute
		'
		Me.SpellAttribute.Location = New System.Drawing.Point(125, 45)
		Me.SpellAttribute.Name = "SpellAttribute"
		Me.SpellAttribute.Properties.AutoHeight = False
		Me.SpellAttribute.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.SpellAttribute.Properties.DropDownRows = 10
		Me.SpellAttribute.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.SpellAttribute.Size = New System.Drawing.Size(50, 21)
		Me.SpellAttribute.TabIndex = 130
		'
		'BonusLabel
		'
		Me.BonusLabel.BackColor = System.Drawing.SystemColors.Control
		Me.BonusLabel.Location = New System.Drawing.Point(15, 45)
		Me.BonusLabel.Name = "BonusLabel"
		Me.BonusLabel.Size = New System.Drawing.Size(115, 21)
		Me.BonusLabel.TabIndex = 131
		Me.BonusLabel.Text = "Spell Ability Score"
		Me.BonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'CasterType
		'
		Me.CasterType.EditValue = ""
		Me.CasterType.Location = New System.Drawing.Point(90, 15)
		Me.CasterType.Name = "CasterType"
		Me.CasterType.Properties.AutoHeight = False
		Me.CasterType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.CasterType.Properties.DropDownRows = 10
		Me.CasterType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.CasterType.Size = New System.Drawing.Size(150, 21)
		Me.CasterType.TabIndex = 106
		'
		'CasterLabel
		'
		Me.CasterLabel.BackColor = System.Drawing.SystemColors.Control
		Me.CasterLabel.Location = New System.Drawing.Point(15, 15)
		Me.CasterLabel.Name = "CasterLabel"
		Me.CasterLabel.Size = New System.Drawing.Size(70, 21)
		Me.CasterLabel.TabIndex = 107
		Me.CasterLabel.Text = "Caster Type"
		Me.CasterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'DomainBonus
		'
		Me.DomainBonus.CausesValidation = False
		Me.DomainBonus.Enabled = False
		Me.DomainBonus.Location = New System.Drawing.Point(200, 105)
		Me.DomainBonus.Name = "DomainBonus"
		Me.DomainBonus.Size = New System.Drawing.Size(190, 21)
		Me.DomainBonus.TabIndex = 147
		Me.DomainBonus.Text = "Bonus Spells on Domain Access"
		'
		'IndentedLine7
		'
		Me.IndentedLine7.CausesValidation = False
		Me.IndentedLine7.Location = New System.Drawing.Point(16, 545)
		Me.IndentedLine7.Name = "IndentedLine7"
		Me.IndentedLine7.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine7.TabIndex = 152
		Me.IndentedLine7.TabStop = False
		'
		'IndentedLine6
		'
		Me.IndentedLine6.CausesValidation = False
		Me.IndentedLine6.Location = New System.Drawing.Point(16, 465)
		Me.IndentedLine6.Name = "IndentedLine6"
		Me.IndentedLine6.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine6.TabIndex = 148
		Me.IndentedLine6.TabStop = False
		'
		'IndentedLine5
		'
		Me.IndentedLine5.CausesValidation = False
		Me.IndentedLine5.Location = New System.Drawing.Point(16, 170)
		Me.IndentedLine5.Name = "IndentedLine5"
		Me.IndentedLine5.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine5.TabIndex = 132
		Me.IndentedLine5.TabStop = False
		'
		'PsionicTab
		'
		Me.PsionicTab.Controls.Add(Me.BonusPowerPointsCheck)
		Me.PsionicTab.Controls.Add(Me.ManifesterMinus)
		Me.PsionicTab.Controls.Add(Me.ManifesterEqual)
		Me.PsionicTab.Controls.Add(Me.ManifesterLabel)
		Me.PsionicTab.Controls.Add(Me.InheritPowerDropdown)
		Me.PsionicTab.Controls.Add(Me.InheritPowerCheck)
		Me.PsionicTab.Controls.Add(Me.DisciplineSpecialization)
		Me.PsionicTab.Controls.Add(Me.PowerManually)
		Me.PsionicTab.Controls.Add(Me.PowerAttribute)
		Me.PsionicTab.Controls.Add(Me.PowerAbilityLabel)
		Me.PsionicTab.Controls.Add(Me.IndentedLine8)
		Me.PsionicTab.Controls.Add(Me.IndentedLine10)
		Me.PsionicTab.Location = New System.Drawing.Point(4, 22)
		Me.PsionicTab.Name = "PsionicTab"
		Me.PsionicTab.Size = New System.Drawing.Size(407, 625)
		Me.PsionicTab.TabIndex = 7
		Me.PsionicTab.Text = "Psionic"
		'
		'BonusPowerPointsCheck
		'
		Me.BonusPowerPointsCheck.CausesValidation = False
		Me.BonusPowerPointsCheck.Checked = True
		Me.BonusPowerPointsCheck.CheckState = System.Windows.Forms.CheckState.Checked
		Me.BonusPowerPointsCheck.Location = New System.Drawing.Point(200, 15)
		Me.BonusPowerPointsCheck.Name = "BonusPowerPointsCheck"
		Me.BonusPowerPointsCheck.Size = New System.Drawing.Size(155, 21)
		Me.BonusPowerPointsCheck.TabIndex = 181
		Me.BonusPowerPointsCheck.Text = "Bonus Power Points"
		'
		'ManifesterMinus
		'
		Me.ManifesterMinus.Location = New System.Drawing.Point(30, 105)
		Me.ManifesterMinus.Name = "ManifesterMinus"
		Me.ManifesterMinus.Size = New System.Drawing.Size(200, 24)
		Me.ManifesterMinus.TabIndex = 180
		Me.ManifesterMinus.Text = "Equal to class level minus four"
		'
		'ManifesterEqual
		'
		Me.ManifesterEqual.Checked = True
		Me.ManifesterEqual.Location = New System.Drawing.Point(30, 75)
		Me.ManifesterEqual.Name = "ManifesterEqual"
		Me.ManifesterEqual.Size = New System.Drawing.Size(125, 24)
		Me.ManifesterEqual.TabIndex = 179
		Me.ManifesterEqual.TabStop = True
		Me.ManifesterEqual.Text = "Equal to class level"
		'
		'ManifesterLabel
		'
		Me.ManifesterLabel.Location = New System.Drawing.Point(15, 45)
		Me.ManifesterLabel.Name = "ManifesterLabel"
		Me.ManifesterLabel.Size = New System.Drawing.Size(155, 23)
		Me.ManifesterLabel.TabIndex = 178
		Me.ManifesterLabel.Text = "Manifester Level"
		Me.ManifesterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'InheritPowerDropdown
		'
		Me.InheritPowerDropdown.EditValue = ""
		Me.InheritPowerDropdown.Enabled = False
		Me.InheritPowerDropdown.Location = New System.Drawing.Point(30, 265)
		Me.InheritPowerDropdown.Name = "InheritPowerDropdown"
		Me.InheritPowerDropdown.Properties.AutoHeight = False
		Me.InheritPowerDropdown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.InheritPowerDropdown.Properties.DropDownRows = 10
		Me.InheritPowerDropdown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.InheritPowerDropdown.Size = New System.Drawing.Size(200, 21)
		Me.InheritPowerDropdown.TabIndex = 173
		'
		'InheritPowerCheck
		'
		Me.InheritPowerCheck.CausesValidation = False
		Me.InheritPowerCheck.Location = New System.Drawing.Point(15, 235)
		Me.InheritPowerCheck.Name = "InheritPowerCheck"
		Me.InheritPowerCheck.Size = New System.Drawing.Size(155, 21)
		Me.InheritPowerCheck.TabIndex = 172
		Me.InheritPowerCheck.Text = "Inherit Power List"
		'
		'DisciplineSpecialization
		'
		Me.DisciplineSpecialization.CausesValidation = False
		Me.DisciplineSpecialization.Location = New System.Drawing.Point(15, 185)
		Me.DisciplineSpecialization.Name = "DisciplineSpecialization"
		Me.DisciplineSpecialization.Size = New System.Drawing.Size(310, 21)
		Me.DisciplineSpecialization.TabIndex = 170
		Me.DisciplineSpecialization.Text = "Restrict Psionic Specialization Options by Deity"
		'
		'PowerManually
		'
		Me.PowerManually.CausesValidation = False
		Me.PowerManually.Location = New System.Drawing.Point(15, 155)
		Me.PowerManually.Name = "PowerManually"
		Me.PowerManually.Size = New System.Drawing.Size(330, 21)
		Me.PowerManually.TabIndex = 168
		Me.PowerManually.Text = "Take Powers Manually (skip power selection during wizard)"
		'
		'PowerAttribute
		'
		Me.PowerAttribute.Location = New System.Drawing.Point(125, 15)
		Me.PowerAttribute.Name = "PowerAttribute"
		Me.PowerAttribute.Properties.AutoHeight = False
		Me.PowerAttribute.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.PowerAttribute.Properties.DropDownRows = 10
		Me.PowerAttribute.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.PowerAttribute.Size = New System.Drawing.Size(50, 21)
		Me.PowerAttribute.TabIndex = 161
		'
		'PowerAbilityLabel
		'
		Me.PowerAbilityLabel.BackColor = System.Drawing.SystemColors.Control
		Me.PowerAbilityLabel.Location = New System.Drawing.Point(15, 15)
		Me.PowerAbilityLabel.Name = "PowerAbilityLabel"
		Me.PowerAbilityLabel.Size = New System.Drawing.Size(115, 21)
		Me.PowerAbilityLabel.TabIndex = 162
		Me.PowerAbilityLabel.Text = "Power Ability Score"
		Me.PowerAbilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'IndentedLine8
		'
		Me.IndentedLine8.CausesValidation = False
		Me.IndentedLine8.Location = New System.Drawing.Point(15, 220)
		Me.IndentedLine8.Name = "IndentedLine8"
		Me.IndentedLine8.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine8.TabIndex = 171
		Me.IndentedLine8.TabStop = False
		'
		'IndentedLine10
		'
		Me.IndentedLine10.CausesValidation = False
		Me.IndentedLine10.Location = New System.Drawing.Point(15, 140)
		Me.IndentedLine10.Name = "IndentedLine10"
		Me.IndentedLine10.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine10.TabIndex = 163
		Me.IndentedLine10.TabStop = False
		'
		'PrestigeTab
		'
		Me.PrestigeTab.Controls.Add(Me.PrestigeCaster)
		Me.PrestigeTab.Controls.Add(Me.PrestigePsionic)
		Me.PrestigeTab.Controls.Add(Me.BothCheck)
		Me.PrestigeTab.Controls.Add(Me.EitherCheck)
		Me.PrestigeTab.Controls.Add(Me.DivineCheck)
		Me.PrestigeTab.Controls.Add(Me.ArcaneCheck)
		Me.PrestigeTab.Controls.Add(Me.SpellLevel)
		Me.PrestigeTab.Controls.Add(Me.SpellLevelLabel)
		Me.PrestigeTab.Controls.Add(Me.SpellLevelCheck)
		Me.PrestigeTab.Controls.Add(Me.IndentedLine2)
		Me.PrestigeTab.Location = New System.Drawing.Point(4, 22)
		Me.PrestigeTab.Name = "PrestigeTab"
		Me.PrestigeTab.Size = New System.Drawing.Size(407, 625)
		Me.PrestigeTab.TabIndex = 5
		Me.PrestigeTab.Text = "Prestige"
		'
		'PrestigeCaster
		'
		Me.PrestigeCaster.Enabled = False
		Me.PrestigeCaster.Location = New System.Drawing.Point(15, 15)
		Me.PrestigeCaster.Name = "PrestigeCaster"
		Me.PrestigeCaster.Size = New System.Drawing.Size(205, 24)
		Me.PrestigeCaster.TabIndex = 133
		Me.PrestigeCaster.Text = "Advance previous caster class"
		'
		'PrestigePsionic
		'
		Me.PrestigePsionic.Enabled = False
		Me.PrestigePsionic.Location = New System.Drawing.Point(15, 165)
		Me.PrestigePsionic.Name = "PrestigePsionic"
		Me.PrestigePsionic.Size = New System.Drawing.Size(205, 24)
		Me.PrestigePsionic.TabIndex = 132
		Me.PrestigePsionic.Text = "Advance previous manifester class"
		'
		'BothCheck
		'
		Me.BothCheck.Enabled = False
		Me.BothCheck.Location = New System.Drawing.Point(30, 135)
		Me.BothCheck.Name = "BothCheck"
		Me.BothCheck.Size = New System.Drawing.Size(104, 24)
		Me.BothCheck.TabIndex = 3
		Me.BothCheck.Text = "Both"
		'
		'EitherCheck
		'
		Me.EitherCheck.Checked = True
		Me.EitherCheck.Enabled = False
		Me.EitherCheck.Location = New System.Drawing.Point(30, 105)
		Me.EitherCheck.Name = "EitherCheck"
		Me.EitherCheck.Size = New System.Drawing.Size(104, 24)
		Me.EitherCheck.TabIndex = 2
		Me.EitherCheck.TabStop = True
		Me.EitherCheck.Text = "Either"
		'
		'DivineCheck
		'
		Me.DivineCheck.Enabled = False
		Me.DivineCheck.Location = New System.Drawing.Point(30, 75)
		Me.DivineCheck.Name = "DivineCheck"
		Me.DivineCheck.Size = New System.Drawing.Size(104, 24)
		Me.DivineCheck.TabIndex = 1
		Me.DivineCheck.Text = "Divine"
		'
		'ArcaneCheck
		'
		Me.ArcaneCheck.Enabled = False
		Me.ArcaneCheck.Location = New System.Drawing.Point(30, 45)
		Me.ArcaneCheck.Name = "ArcaneCheck"
		Me.ArcaneCheck.Size = New System.Drawing.Size(104, 24)
		Me.ArcaneCheck.TabIndex = 0
		Me.ArcaneCheck.Text = "Arcane"
		'
		'SpellLevel
		'
		Me.SpellLevel.CausesValidation = False
		Me.SpellLevel.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.SpellLevel.Enabled = False
		Me.SpellLevel.Location = New System.Drawing.Point(75, 245)
		Me.SpellLevel.Name = "SpellLevel"
		Me.SpellLevel.Properties.Appearance.Options.UseTextOptions = True
		Me.SpellLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.SpellLevel.Properties.AutoHeight = False
		Me.SpellLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.SpellLevel.Properties.IsFloatValue = False
		Me.SpellLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
		Me.SpellLevel.Properties.MaxValue = New Decimal(New Integer() {9, 0, 0, 0})
		Me.SpellLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		Me.SpellLevel.Size = New System.Drawing.Size(50, 21)
		Me.SpellLevel.TabIndex = 5
		'
		'SpellLevelLabel
		'
		Me.SpellLevelLabel.BackColor = System.Drawing.SystemColors.Control
		Me.SpellLevelLabel.CausesValidation = False
		Me.SpellLevelLabel.Enabled = False
		Me.SpellLevelLabel.Location = New System.Drawing.Point(30, 245)
		Me.SpellLevelLabel.Name = "SpellLevelLabel"
		Me.SpellLevelLabel.Size = New System.Drawing.Size(45, 21)
		Me.SpellLevelLabel.TabIndex = 131
		Me.SpellLevelLabel.Text = "Level"
		Me.SpellLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SpellLevelCheck
		'
		Me.SpellLevelCheck.Enabled = False
		Me.SpellLevelCheck.Location = New System.Drawing.Point(15, 215)
		Me.SpellLevelCheck.Name = "SpellLevelCheck"
		Me.SpellLevelCheck.Size = New System.Drawing.Size(335, 24)
		Me.SpellLevelCheck.TabIndex = 4
		Me.SpellLevelCheck.Text = "Must be able to cast spells of level to advance previous class"
		'
		'IndentedLine2
		'
		Me.IndentedLine2.CausesValidation = False
		Me.IndentedLine2.Location = New System.Drawing.Point(15, 200)
		Me.IndentedLine2.Name = "IndentedLine2"
		Me.IndentedLine2.Size = New System.Drawing.Size(375, 5)
		Me.IndentedLine2.TabIndex = 120
		Me.IndentedLine2.TabStop = False
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.PropertiesTab)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(407, 625)
		Me.TabPage3.TabIndex = 3
		Me.TabPage3.Text = "Properties"
		'
		'PropertiesTab
		'
		Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
		Me.PropertiesTab.Name = "PropertiesTab"
		Me.PropertiesTab.Size = New System.Drawing.Size(407, 625)
		Me.PropertiesTab.TabIndex = 1
		'
		'Cancel
		'
		Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Cancel.Location = New System.Drawing.Point(360, 681)
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
		Me.OK.Location = New System.Drawing.Point(280, 681)
		Me.OK.Name = "OK"
		Me.OK.Size = New System.Drawing.Size(70, 24)
		Me.OK.TabIndex = 1
		Me.OK.Text = "OK"
		'
		'Errors
		'
		Me.Errors.ContainerControl = Me
		'
		'ClassForm
		'
		Me.AcceptButton = Me.OK
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.CancelButton = Me.Cancel
		Me.ClientSize = New System.Drawing.Size(444, 719)
		Me.Controls.Add(Me.Cancel)
		Me.Controls.Add(Me.OK)
		Me.Controls.Add(Me.ClassTabControl)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "ClassForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.ClassTabControl.ResumeLayout(False)
		Me.ClassTab.ResumeLayout(False)
		CType(Me.Abbreviation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CasterAbility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SkillPoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.HitDice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ObjectName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage1.ResumeLayout(False)
		CType(Me.ClassSkillChoiceList, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LanguageTab.ResumeLayout(False)
		CType(Me.Languages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.CasterTab.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		CType(Me.PerLevelSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FirstSpin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.InheritDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SpellAttribute.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CasterType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PsionicTab.ResumeLayout(False)
		CType(Me.InheritPowerDropdown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PowerAttribute.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PrestigeTab.ResumeLayout(False)
		CType(Me.SpellLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage3.ResumeLayout(False)
		CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    'reference
    Private SkillDefs As Objects.ObjectDataCollection
    Private SkillGroups As Objects.ObjectDataCollection

    'indexes
    Private LanguageIndex As Rules.Index.IndexEntry()

    'datalists
    Private InheritItemsDataList As DataListItem()
    Private PsionicInheritDataList As DataListItem()

    'object collections
    Private ExistingClassSkills As New Objects.ObjectDataCollection
    Private ClassSkills As New Objects.ObjectDataCollection
    Private ToDelete As New Objects.ObjectDataCollection

    'language object collections
    Private AutomaticLanguageObjs As New Objects.ObjectDataCollection
    Private BonusLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingAutoLanguageObjs As New Objects.ObjectDataCollection
    Private ExistingBonusLanguageObjs As New Objects.ObjectDataCollection

    'edit info
    Private PreviousInheritSource As Objects.ObjectData

    'init
    Public Sub Init()
        Try
            'ref
            SkillDefs = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillDefinitionType)
            SkillGroups = Objects.GetAllObjectsOfType(XML.DBTypes.Skills, Objects.SkillGroupType)

            'indexes
            LanguageIndex = Rules.Index.Index(XML.DBTypes.Languages, Objects.LanguageDefinitionType)

            'remove the small dice
            Dim DiceArray(Rules.Dice.DiceTypes.GetUpperBound(0) - 2) As String
            Array.Copy(Rules.Dice.DiceTypes, 2, DiceArray, 0, Rules.Dice.DiceTypes.Length - 2)

            HitDice.Properties.Items.AddRange(DiceArray)
            CasterAbility.Properties.Items.AddRange(Rules.Lists.SpellCastingAbility)
            CasterType.Properties.Items.AddRange(Rules.Lists.SpellcasterTypes)
            SpellAttribute.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
            PowerAttribute.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
            Languages.Properties.Items.AddRange(Rules.Index.IndexNames(LanguageIndex))
            PropertiesTab.Init(mObject, mMode)

            'inheritance dropdown lists
            Dim ExcludeList As ArrayList
            Dim InheritOptions As New Objects.ObjectDataCollection

            InheritOptions.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.Classes, Objects.ClassType))

            'psionic
            ExcludeList = New ArrayList
            For Each TempObj As Objects.ObjectData In InheritOptions
                If TempObj.Element("InheritPowers") = "True" OrElse TempObj.ObjectGUID.Equals(mObject.ObjectGUID) Then
                    ExcludeList.Add(TempObj.ObjectGUID)
                ElseIf TempObj.Element("CasterAbility") <> "Psionic" Then
                    If Not (TempObj.Element("AdvanceManifester") = "True") Then
                        ExcludeList.Add(TempObj.ObjectGUID)
                    End If
                End If
            Next

            PsionicInheritDataList = Rules.Index.DataListExclude(InheritOptions, ExcludeList)
            If Not PsionicInheritDataList Is Nothing Then
                InheritPowerDropdown.Properties.Items.AddRange(PsionicInheritDataList)
            End If

            'spellcaster
            ExcludeList = New ArrayList
            For Each TempObj As Objects.ObjectData In InheritOptions
                If TempObj.Element("InheritSpells") = "True" OrElse (TempObj.Element("CasterAbility") <> "Yes" AndAlso TempObj.Element("CasterAbility") <> "Prestige Advancement") OrElse TempObj.ObjectGUID.Equals(mObject.ObjectGUID) Then ExcludeList.Add(TempObj.ObjectGUID)
            Next

            For Each TempObj As Objects.ObjectData In InheritOptions
                If TempObj.Element("InheritPowers") = "True" OrElse TempObj.ObjectGUID.Equals(mObject.ObjectGUID) Then
                    ExcludeList.Add(TempObj.ObjectGUID)
                ElseIf TempObj.Element("CasterAbility") <> "Yes" Then
                    If TempObj.Element("PrestigeSpellType") = "" Then
                        ExcludeList.Add(TempObj.ObjectGUID)
                    End If
                End If
            Next

            'add the categories
            InheritOptions.AddMany(Objects.GetAllObjectsOfType(XML.DBTypes.SpellCategoriesAndDescriptors, Objects.SpellCategoryDefinitionType))

            'populate the dropdown
            InheritItemsDataList = Rules.Index.DataListExclude(InheritOptions, ExcludeList)
            If Not InheritItemsDataList Is Nothing Then
                InheritDropdown.Properties.Items.AddRange(InheritItemsDataList)
            End If

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

            'init new object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
            mObject.Type = Objects.ClassType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Class"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")
            Init()
            RecalcCrossClassSkills()

            CasterAbility.SelectedIndex = 0

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Dim Child As Objects.ObjectData

        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Class"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ObjectName.Text = Obj.Name
            If Obj.Element("Abbreviation") <> Obj.Name Then
                Abbreviation.Text = Obj.Element("Abbreviation")
            End If
            SkillPoints.Text = Obj.Element("SkillPointsPerLevel")
            HitDice.Text = Obj.Element("HitDice")

            CasterAbility.Text = CasterString(Obj.Element("CasterAbility"))

            If Obj.Element("LawfulGood") = "True" Then LawfulGood.CheckState = CheckState.Checked Else LawfulGood.Checked = False
            If Obj.Element("NeutralGood") = "True" Then NeutralGood.CheckState = CheckState.Checked Else NeutralGood.Checked = False
            If Obj.Element("ChaoticGood") = "True" Then ChaoticGood.CheckState = CheckState.Checked Else ChaoticGood.Checked = False
            If Obj.Element("LawfulNeutral") = "True" Then LawfulNeutral.CheckState = CheckState.Checked Else LawfulNeutral.Checked = False
            If Obj.Element("TrueNeutral") = "True" Then TrueNeutral.CheckState = CheckState.Checked Else TrueNeutral.Checked = False
            If Obj.Element("ChaoticNeutral") = "True" Then ChaoticNeutral.CheckState = CheckState.Checked Else ChaoticNeutral.Checked = False
            If Obj.Element("LawfulEvil") = "True" Then LawfulEvil.CheckState = CheckState.Checked Else LawfulEvil.Checked = False
            If Obj.Element("NeutralEvil") = "True" Then NeutralEvil.CheckState = CheckState.Checked Else NeutralEvil.Checked = False
            If Obj.Element("ChaoticEvil") = "True" Then ChaoticEvil.CheckState = CheckState.Checked Else ChaoticEvil.Checked = False

            If Obj.Element("RestrictMulticlass") = "True" Then RestrictMulticlass.CheckState = CheckState.Checked
            If Obj.Element("RestrictAlignment") = "True" Then RestrictAlignment.CheckState = CheckState.Checked

            If CasterAbility.Text = "Spellcaster" Then
                Dim SpellAcquisition As String

                CasterType.Text = Obj.Element("CasterType")
                SpellAttribute.Text = Obj.Element("SpellAttribute")

                If mObject.Element("BonusSpells") = "True" Then BonusSpellsCheck.Checked = True Else BonusSpellsCheck.Checked = False
                If mObject.Element("BonusPoints") = "True" Then BonusPointsCheck.Checked = True Else BonusPointsCheck.Checked = False

                If Obj.Element("DomainBonus") = "True" Then DomainBonus.CheckState = CheckState.Checked Else DomainBonus.Checked = False
                If Obj.Element("SchoolBonus") = "True" Then SchoolBonus.CheckState = CheckState.Checked Else SchoolBonus.Checked = False
                If mObject.Element("CasterEqual") = "True" Then CasterLevelEqualRadio.Checked = True Else CasterLevelHalfRadio.Checked = True

                SpellAcquisition = Obj.Element("SpellAcquisition")
                Select Case SpellAcquisition
                    Case "Book"
                        SpellBookRadio.Checked = True
                        FirstSpin.Value = Obj.ElementAsInteger("FirstLevelSpells")
                        PerLevelSpin.Value = Obj.ElementAsInteger("PerLevelSpells")

                    Case "List"
                        SpellListRadio.Checked = True

                    Case "Known"
                        SpellsKnownRadio.Checked = True
                        If Obj.Element("NoSpellsPerDay") = "True" Then NoSPDCheck.Checked = True Else NoSPDCheck.Checked = False

                End Select

                If Obj.Element("MemorizeSpells") = "True" Then MemCheck.Checked = True Else MemCheck.Checked = False
                If Obj.Element("ManualSpells") = "True" Then ManualSpellsCheck.Checked = True Else ManualSpellsCheck.Checked = False
                If Obj.Element("SelectSchool") = "True" Then SpecialCheck.Checked = True Else SpecialCheck.Checked = False
                If Obj.Element("RestrictDomain") = "True" Then RestrictDomains.Checked = True Else RestrictDomains.Checked = False

                If Obj.Element("InheritSpells") = "True" Then
                    InheritCheck.Checked = True
                    PreviousInheritSource = Obj.GetFKObject("InheritSource")
                    InheritDropdown.SelectedIndex = Rules.Index.GetGuidIndex(InheritItemsDataList, Obj.GetFKGuid("InheritSource"))
                End If
            End If

            'psionic tab
            If CasterAbility.Text = "Psionic" Then
                PowerAttribute.Text = mObject.Element("PowerAttribute")
                If mObject.Element("ManualPowers") = "True" Then PowerManually.Checked = True Else PowerManually.Checked = False
                If mObject.Element("RestrictSpecialization") = "True" Then DisciplineSpecialization.Checked = True Else DisciplineSpecialization.Checked = False
                If mObject.Element("ManifesterEqual") = "True" Then ManifesterEqual.Checked = True Else ManifesterMinus.Checked = True
                If mObject.Element("BonusPowerPoints") = "True" Then BonusPowerPointsCheck.Checked = True Else BonusPowerPointsCheck.Checked = True

                If Obj.Element("InheritPowers") = "True" Then
                    InheritPowerCheck.Checked = True
                    PreviousInheritSource = Obj.GetFKObject("InheritPowerSource")
                    InheritPowerDropdown.SelectedIndex = Rules.Index.GetGuidIndex(PsionicInheritDataList, Obj.GetFKGuid("InheritPowerSource"))
                End If

            End If

            If CasterAbility.Text = "Prestige Advancement" Then
                Dim SpellType As String = mObject.Element("PrestigeSpellType")
                Select Case SpellType
                    Case "Arcane"
                        ArcaneCheck.Checked = True
                        PrestigeCaster.Checked = True
                    Case "Divine"
                        DivineCheck.Checked = True
                        PrestigeCaster.Checked = True
                    Case "Either"
                        EitherCheck.Checked = True
                        PrestigeCaster.Checked = True
                    Case "Both"
                        BothCheck.Checked = True
                        PrestigeCaster.Checked = True
                End Select

                If mObject.Element("PrestigeRestriction") = "True" Then
                    SpellLevelCheck.CheckState = CheckState.Checked
                    SpellLevel.Value = mObject.ElementAsInteger("PrestigeSpellLevel")
                End If

                If mObject.Element("AdvanceManifester") = "True" Then
                    PrestigePsionic.Checked = True
                End If

            End If

            ExistingClassSkills = mObject.ChildrenOfType(Objects.ClassSkillType)
            For Each Child In ExistingClassSkills
                ClassSkills.Add(Child)
                ClassSkillChoiceList.Items.Add(Child)
            Next
            RecalcCrossClassSkills()

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

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Obj As New Objects.ObjectData
        Dim Folder As New Objects.ObjectData
        Dim FolderSPD As New Objects.ObjectData
        Dim FolderSK As New Objects.ObjectData
        Dim FolderSpellList As New Objects.ObjectData
        Dim FolderPowerList As New Objects.ObjectData
        Dim FolderPowerProg As New Objects.ObjectData
        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                mObject.Name = ObjectName.Text

                Select Case mMode
                    Case FormMode.Add
                        'create the class levels folder
                        Folder.Name = "Levels"
                        Folder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                        Folder.Type = Objects.ClassLevelsFolderType
                        Folder.ParentGUID = mObject.ObjectGUID
                        Folder.Save()

                    Case FormMode.Edit
                        If mObject.ChildrenOfType(Objects.ClassLevelsFolderType).Count = 0 Then
                            Folder.Name = "Levels"
                            Folder.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                            Folder.Type = Objects.ClassLevelsFolderType
                            Folder.ParentGUID = mObject.ObjectGUID
                            Folder.Save()
                        Else
                            Folder = mObject.FirstChildOfType(Objects.ClassLevelsFolderType)
                        End If

                        mObject.ClearElements()
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)

                End Select

                'updates common to add and edit
                If Abbreviation.Text = "" Then
                    mObject.Element("Abbreviation") = mObject.Name
                Else
                    mObject.Element("Abbreviation") = Abbreviation.Text
                End If

                mObject.Element("SkillPointsPerLevel") = SkillPoints.Text
                mObject.Element("HitDice") = HitDice.Text
                mObject.Element("CasterAbility") = CasterString(CasterAbility.Text)

                If LawfulGood.CheckState = CheckState.Checked Then mObject.Element("LawfulGood") = "True" Else mObject.Element("LawfulGood") = "False"
                If NeutralGood.CheckState = CheckState.Checked Then mObject.Element("NeutralGood") = "True" Else mObject.Element("NeutralGood") = "False"
                If ChaoticGood.CheckState = CheckState.Checked Then mObject.Element("ChaoticGood") = "True" Else mObject.Element("ChaoticGood") = "False"
                If LawfulNeutral.CheckState = CheckState.Checked Then mObject.Element("LawfulNeutral") = "True" Else mObject.Element("LawfulNeutral") = "False"
                If TrueNeutral.CheckState = CheckState.Checked Then mObject.Element("TrueNeutral") = "True" Else mObject.Element("TrueNeutral") = "False"
                If ChaoticNeutral.CheckState = CheckState.Checked Then mObject.Element("ChaoticNeutral") = "True" Else mObject.Element("ChaoticNeutral") = "False"
                If LawfulEvil.CheckState = CheckState.Checked Then mObject.Element("LawfulEvil") = "True" Else mObject.Element("LawfulEvil") = "False"
                If NeutralEvil.CheckState = CheckState.Checked Then mObject.Element("NeutralEvil") = "True" Else mObject.Element("NeutralEvil") = "False"
                If ChaoticEvil.CheckState = CheckState.Checked Then mObject.Element("ChaoticEvil") = "True" Else mObject.Element("ChaoticEvil") = "False"

                If RestrictMulticlass.CheckState = CheckState.Checked Then mObject.Element("RestrictMulticlass") = "True" Else mObject.Element("RestrictMulticlass") = "False"
                If RestrictAlignment.CheckState = CheckState.Checked Then mObject.Element("RestrictAlignment") = "True" Else mObject.Element("RestrictAlignment") = "False"

                If CasterAbility.Text = "Spellcaster" Then
                    mObject.Element("CasterType") = CasterType.Text
                    mObject.Element("SpellAttribute") = SpellAttribute.Text

                    If BonusSpellsCheck.Checked = True Then mObject.Element("BonusSpells") = "True" Else mObject.Element("BonusSpells") = "False"
                    If BonusPointsCheck.Checked = True Then mObject.Element("BonusPoints") = "True" Else mObject.Element("BonusPoints") = "False"
                    If DomainBonus.Checked = True Then mObject.Element("DomainBonus") = "True" Else mObject.Element("DomainBonus") = "False"
                    If SchoolBonus.Checked = True Then mObject.Element("SchoolBonus") = "True" Else mObject.Element("SchoolBonus") = "False"

                    If CasterLevelEqualRadio.Checked = True Then mObject.Element("CasterEqual") = "True" Else mObject.Element("CasterEqual") = "False"

                    If SpellListRadio.Checked = True Then
                        mObject.Element("SpellAcquisition") = "List"
                    Else
                        If SpellsKnownRadio.Checked = True Then
                            mObject.Element("SpellAcquisition") = "Known"
                            If NoSPDCheck.CheckState = CheckState.Checked Then mObject.Element("NoSpellsPerDay") = "True" Else mObject.Element("NoSpellsPerDay") = "False"
                        Else
                            mObject.Element("SpellAcquisition") = "Book"
                            mObject.Element("FirstLevelSpells") = FirstSpin.Value.ToString
                            mObject.Element("PerLevelSpells") = PerLevelSpin.Value.ToString
                        End If
                    End If

                    If MemCheck.CheckState = CheckState.Checked Then mObject.Element("MemorizeSpells") = "True" Else mObject.Element("MemorizeSpells") = "False"
                    If ManualSpellsCheck.CheckState = CheckState.Checked Then mObject.Element("ManualSpells") = "True" Else mObject.Element("ManualSpells") = "False"
                    If SpecialCheck.CheckState = CheckState.Checked Then mObject.Element("SelectSchool") = "True" Else mObject.Element("SelectSchool") = "False"
                    If RestrictDomains.CheckState = CheckState.Checked Then mObject.Element("RestrictDomain") = "True" Else mObject.Element("RestrictDomain") = "False"

                    If InheritCheck.CheckState = CheckState.Checked Then

                        'get the inherit source
                        Dim NewInheritSource As Objects.ObjectData = CType(CType(InheritDropdown.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
                        Rules.SpellList.InheritSpellList(NewInheritSource.ObjectGUID, mObject)
                        mObject.Element("InheritSpells") = "True"
                        mObject.FKElement("InheritSource", NewInheritSource.Name, "Name", NewInheritSource.ObjectGUID)

                    Else
                        'if there are inherited levels then 
                        mObject.Element("InheritSpells") = "False"

                        General.SetWaitCursor()
                        'get the spells inherited already and remove them
                        For Each SpellLevel As Objects.ObjectData In Rules.SpellList.InheritedSpellList(mObject.ObjectGUID)
                            XML.FKLookup.RemoveItem(mObject.ObjectGUID, SpellLevel.ObjectGUID)
                            SpellLevel.DeleteFast()
                        Next
                        General.SetNormalCursor()
                    End If

                ElseIf CasterAbility.Text = "Psionic" Then

                    mObject.Element("CasterType") = "Psionic"
                    mObject.Element("PowerAttribute") = PowerAttribute.Text
                    If PowerManually.CheckState = CheckState.Checked Then mObject.Element("ManualPowers") = "True" Else mObject.Element("ManualPowers") = "False"
                    If ManifesterEqual.Checked = True Then mObject.Element("ManifesterEqual") = "True" Else mObject.Element("ManifesterEqual") = "False"
                    If BonusPowerPointsCheck.Checked = True Then mObject.Element("BonusPowerPoints") = "True" Else mObject.Element("BonusPowerPoints") = "False"

                    If DisciplineSpecialization.CheckState = CheckState.Checked Then mObject.Element("RestrictSpecialization") = "True" Else mObject.Element("RestrictSpecialization") = "False"

                    If InheritPowerCheck.CheckState = CheckState.Checked Then
                        'get the inherit source
                        Dim NewInheritSource As Objects.ObjectData = CType(CType(InheritPowerDropdown.SelectedItem, DataListItem).ValueMember, Objects.ObjectData)
                        Rules.PowerList.InheritpowerList(NewInheritSource.ObjectGUID, mObject)
                        mObject.Element("InheritPowers") = "True"
                        mObject.FKElement("InheritPowerSource", NewInheritSource.Name, "Name", NewInheritSource.ObjectGUID)
                    Else
                        'if there are inherited levels then 
                        mObject.Element("InheritPowers") = "False"

                        General.SetWaitCursor()
                        'get the spells inherited already and remove them
                        For Each PowerLevel As Objects.ObjectData In Rules.PowerList.InheritedpowerList(mObject.ObjectGUID)
                            XML.FKLookup.RemoveItem(mObject.ObjectGUID, PowerLevel.ObjectGUID)
                            PowerLevel.DeleteFast()
                        Next
                        General.SetNormalCursor()
                    End If

                ElseIf CasterAbility.Text = "Prestige Advancement" Then

                    mObject.Element("CasterType") = "Prestige"

                    If PrestigeCaster.Checked = True Then
                        If ArcaneCheck.Checked = True Then mObject.Element("PrestigeSpellType") = "Arcane"
                        If DivineCheck.Checked = True Then mObject.Element("PrestigeSpellType") = "Divine"
                        If EitherCheck.Checked = True Then mObject.Element("PrestigeSpellType") = "Either"
                        If BothCheck.Checked = True Then mObject.Element("PrestigeSpellType") = "Both"
                        If SpellLevelCheck.CheckState = CheckState.Checked Then
                            mObject.Element("PrestigeRestriction") = "True"
                            mObject.Element("PrestigeSpellLevel") = SpellLevel.Value.ToString
                        End If
                    End If

                    If PrestigePsionic.Checked = True Then
                        mObject.Element("AdvanceManifester") = "True"
                    End If
                Else

                    mObject.Element("CasterType") = ""
                End If

                'save the class skills
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

                'determine which spell folders are required
                Dim spd, sk, prestige, spelllist, powerlist, powerpoints As Boolean

                Select Case CasterAbility.Text
                    Case "No"
                        spd = False
                        sk = False
                        spelllist = False
                        prestige = False
                        powerlist = False
                        powerpoints = False

                    Case "Spellcaster"
                        spd = False
                        sk = False
                        spelllist = True
                        prestige = False
                        powerlist = False
                        powerpoints = False

                        If NoSPDCheck.Checked = False Then spd = True
                        If SpellsKnownRadio.Checked = True Then sk = True

                    Case "Psionic"
                        spd = False
                        sk = False
                        spelllist = False
                        prestige = False
                        powerpoints = True
                        powerlist = True

                    Case "Prestige Advancement"
                        spd = False
                        sk = False
                        spelllist = False
                        prestige = True
                        powerlist = False
                        powerpoints = False

                        If PrestigeCaster.Checked Then
                            spelllist = True
                        End If

                        If PrestigePsionic.Checked Then
                            powerlist = True
                        End If

                End Select

                'create or remove the spell list folder
                If mObject.ChildrenOfType(Objects.SpellListFolderType).Count = 0 Then
                    If spelllist Then
                        FolderSpellList.Name = "Spell List"
                        FolderSpellList.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                        FolderSpellList.Type = Objects.SpellListFolderType
                        FolderSpellList.ParentGUID = mObject.ObjectGUID
                        FolderSpellList.Save()
                    End If
                Else
                    If Not spelllist Then
                        mObject.FirstChildOfType(Objects.SpellListFolderType).Delete()

                        'remove any exsisting spells
                        Rules.SpellList.RemoveSpellLevels(Rules.SpellList.SpellList(mObject.ObjectGUID), mObject.ObjectGUID)
                    End If
                End If

                'create or remove the psionic folders
                If mObject.ChildrenOfType(Objects.PowerListFolderType).Count = 0 Then
                    If powerlist Then
                        FolderPowerList.Name = "Power List"
                        FolderPowerList.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                        FolderPowerList.Type = Objects.PowerListFolderType
                        FolderPowerList.ParentGUID = mObject.ObjectGUID
                        FolderPowerList.Save()
                    End If
                Else
                    If Not powerlist Then
                        mObject.FirstChildOfType(Objects.PowerListFolderType).Delete()

                        'remove any exsisting spells
                        Rules.PowerList.RemovepowerLevels(Rules.PowerList.PowerList(mObject.ObjectGUID), mObject.ObjectGUID)
                    End If
                End If

                If mObject.ChildrenOfType(Objects.ClassLevelsPowerProgressionFolderType).Count = 0 Then
                    If powerpoints Then
                        FolderPowerProg.Name = "Power Progression"
                        FolderPowerProg.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                        FolderPowerProg.Type = Objects.ClassLevelsPowerProgressionFolderType
                        FolderPowerProg.ParentGUID = mObject.ObjectGUID
                        FolderPowerProg.Save()

                        'Add in empty objects for each level previously defined
                        For LevelCounter As Integer = 1 To Folder.ChildrenOfType(Objects.ClassLevelType).Count
                            Obj.Clear()
                            Obj.Name = "Level " & LevelCounter
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                            Obj.Type = Objects.PowerProgressionType
                            Obj.ParentGUID = FolderPowerProg.ObjectGUID
                            Obj.ElementAsInteger("Level") = LevelCounter
                            Obj.Element("PowerPoints") = ""
                            Obj.Element("PowersKnown") = ""
                            Obj.Element("MaxPowerLevel") = ""
                            Obj.Save()
                        Next

                    End If
                Else
                    If Not powerpoints Then
                        mObject.FirstChildOfType(Objects.ClassLevelsPowerProgressionFolderType).Delete()
                    End If
                End If

                'create or remove the spells per day folder
                If mObject.ChildrenOfType(Objects.ClassLevelsSpellsPerDayFolderType).Count = 0 Then
                    If spd Then
                        FolderSPD.Name = "Spells Per Day"
                        FolderSPD.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                        FolderSPD.Type = Objects.ClassLevelsSpellsPerDayFolderType
                        FolderSPD.ParentGUID = mObject.ObjectGUID
                        FolderSPD.Save()

                        'Add in empty objects for each level previously defined
                        For LevelCounter As Integer = 1 To Folder.ChildrenOfType(Objects.ClassLevelType).Count
                            Obj.Clear()
                            Obj.Name = "Level " & LevelCounter
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                            Obj.Type = Objects.SpellsPerDayType
                            Obj.ParentGUID = FolderSPD.ObjectGUID
                            Obj.ElementAsInteger("Level") = LevelCounter
                            Obj.Element("Level0Spells") = ""
                            Obj.Element("Level1Spells") = ""
                            Obj.Element("Level2Spells") = ""
                            Obj.Element("Level3Spells") = ""
                            Obj.Element("Level4Spells") = ""
                            Obj.Element("Level5Spells") = ""
                            Obj.Element("Level6Spells") = ""
                            Obj.Element("Level7Spells") = ""
                            Obj.Element("Level8Spells") = ""
                            Obj.Element("Level9Spells") = ""
                            Obj.Save()
                        Next
                    End If
                Else
                    If Not spd Then
                        mObject.FirstChildOfType(Objects.ClassLevelsSpellsPerDayFolderType).Delete()
                    End If
                End If

                'create or remove the spells known folder
                If mObject.ChildrenOfType(Objects.ClassLevelsSpellsKnownFolderType).Count = 0 Then
                    If sk Then
                        FolderSK.Name = "Spells Known"
                        FolderSK.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                        FolderSK.Type = Objects.ClassLevelsSpellsKnownFolderType
                        FolderSK.ParentGUID = mObject.ObjectGUID
                        FolderSK.Save()

                        'Add in empty objects for each level previously defined
                        For LevelCounter As Integer = 1 To Folder.ChildrenOfType(Objects.ClassLevelType).Count
                            Obj.Clear()
                            Obj.Name = "Level " & LevelCounter
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
                            Obj.Type = Objects.SpellsKnownType
                            Obj.ParentGUID = FolderSK.ObjectGUID
                            Obj.ElementAsInteger("Level") = LevelCounter
                            Obj.Element("Level0Spells") = ""
                            Obj.Element("Level1Spells") = ""
                            Obj.Element("Level2Spells") = ""
                            Obj.Element("Level3Spells") = ""
                            Obj.Element("Level4Spells") = ""
                            Obj.Element("Level5Spells") = ""
                            Obj.Element("Level6Spells") = ""
                            Obj.Element("Level7Spells") = ""
                            Obj.Element("Level8Spells") = ""
                            Obj.Element("Level9Spells") = ""
                            Obj.Save()
                        Next
                    End If
                Else
                    If Not sk Then
                        mObject.FirstChildOfType(Objects.ClassLevelsSpellsKnownFolderType).Delete()
                    End If
                End If

                'remove any Existing spellcaster level advandvements if they are no longer required
                'remove any ReplaceKnown Spells if they are no longer required
                Dim ClassLevels As Objects.ObjectDataCollection = mObject.FirstChildOfType(Objects.ClassLevelsFolderType).ChildrenOfType(Objects.ClassLevelType)
                If ClassLevels.Count > 0 Then
                    For Each TempClassLevel As Objects.ObjectData In ClassLevels
                        If spelllist = False Then
                            Dim PrestigeObj As Objects.ObjectData = TempClassLevel.FirstChildOfType(Objects.ExistingSpellcasterLevel)
                            If Not PrestigeObj.IsEmpty Then PrestigeObj.DeleteFast()
                        End If
                        If powerlist = False Then
                            Dim PrestigeObj As Objects.ObjectData = TempClassLevel.FirstChildOfType(Objects.ExistingManifesterLevel)
                            If Not PrestigeObj.IsEmpty Then PrestigeObj.DeleteFast()
                        End If
                        If sk = False Then
                            Dim ReplaceObj As Objects.ObjectData = TempClassLevel.FirstChildOfType(Objects.ReplaceKnownSpellType)
                            If Not ReplaceObj.IsEmpty Then ReplaceObj.DeleteFast()
                        End If
                    Next
                End If

                'save, refresh explorer and close
                mObject = PropertiesTab.UpdateObject(mObject)
                mObject.Save()

                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject))
                ElseIf mMode = FormMode.Edit Then
                    Caches.RemoveCharacterClass(mObject.ObjectGUID)
                    General.MainExplorer.TreeView.BeginUpdate()

                    Dim CurrentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ObjectGUID), TreeNode)
                    If Not CurrentNode Is Nothing Then CurrentNode.Remove()
                    Dim ParentNode As TreeNode = CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode)
                    Dim NewNode As TreeNode = General.MainExplorer.CompleteNodeFromObject(mObject)
                    General.MainExplorer.InsertNode(ParentNode, NewNode)

                    General.MainExplorer.TreeView.EndUpdate()
                End If

                'refresh explorer and close
                WindowManager.SetDirty(mObject.Parent)
                WindowManager.RefreshTreeNodes()
                WindowManager.RefreshTabNames()
                General.MainExplorer.RefreshPanel()
                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)

                Me.DialogResult = DialogResult.OK : Me.Close()

                'begin
                If mMode = FormMode.Add Then
                    Commands.CreateClassLevels(Folder)
                End If

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

    'map "Yes" to "Spellcaster" for pre-psionic backwards compatibility
    Private Function CasterString(ByVal Input As String) As String
        Try
            Select Case Input

                Case "Yes"
                    Return "Spellcaster"
                Case "Spellcaster"
                    Return "Yes"

                Case ""
                    Return "No"

                Case Else
                    Return Input

            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = General.ValidateForm(Me.ClassTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.CasterTab.Controls, Errors)
            Validate = Validate And General.ValidateForm(Me.PsionicTab.Controls, Errors)

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

            If CasterAbility.Text = "Prestige Advancement" Then
                If PrestigeCaster.Checked = False AndAlso PrestigePsionic.Checked = False Then
                    Errors.SetError(PrestigePsionic, "This class must either advance a previous spellcaster or manifester class.")
                    Validate = False
                Else
                    Errors.SetError(PrestigePsionic, "")
                End If
            Else
                Errors.SetError(PrestigePsionic, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Class Skills"

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
                        NewClassSkill.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
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
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
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
                            Obj.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.Classes)
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

#Region "Control Enabling and Disabling"

    'handles the casterabilty dropdown
    Private Sub CasterAbility_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasterAbility.SelectedIndexChanged
        Try

            If CasterAbility.Text = "Spellcaster" Then
                EnableSpellCasterControls()
            Else
                DiableSpellCasterControls()
            End If

            If CasterAbility.Text = "Psionic" Then
                PowerAbilityLabel.Enabled = True
                PowerAttribute.Enabled = True
                PowerManually.Enabled = True
                DisciplineSpecialization.Enabled = True
                InheritPowerCheck.Enabled = True
                BonusPowerPointsCheck.Enabled = True
                ManifesterLabel.Enabled = True
                ManifesterEqual.Enabled = True
                ManifesterMinus.Enabled = True

            Else
                InheritPowerCheck.Checked = False
                ManifesterEqual.Checked = True
                BonusPowerPointsCheck.Checked = True

                BonusPowerPointsCheck.Enabled = False
                PowerAbilityLabel.Enabled = False
                PowerAttribute.Enabled = False
                PowerManually.Enabled = False
                DisciplineSpecialization.Enabled = False
                InheritPowerCheck.Enabled = False
                ManifesterLabel.Enabled = False
                ManifesterEqual.Enabled = False
                ManifesterMinus.Enabled = False
            End If

            If CasterAbility.Text = "Prestige Advancement" Then
                PrestigeCaster.Enabled = True
                PrestigePsionic.Enabled = True
            Else
                PrestigeCaster.Enabled = False
                PrestigePsionic.Enabled = False
                PrestigeCaster.Checked = False
                PrestigePsionic.Checked = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the SpellList radio control
    Private Sub SpellListRadio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpellListRadio.CheckedChanged
        Try
            If SpellListRadio.Checked Then
                ManualSpellsCheck.Checked = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Spellbook radio control
    Private Sub SpellBookRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellBookRadio.CheckedChanged
        Try
            'reset
            FirstSpin.Value = 3
            PerLevelSpin.Value = 1

            'enable/disable
            If SpellBookRadio.Checked Then
                FirstLabel.Enabled = True
                PerLevelLabel.Enabled = True
                PlusBonusLabel.Enabled = True
                FirstSpin.Enabled = True
                PerLevelSpin.Enabled = True
                ManualSpellsCheck.Enabled = True
            Else
                FirstLabel.Enabled = False
                PerLevelLabel.Enabled = False
                PlusBonusLabel.Enabled = False
                FirstSpin.Enabled = False
                PerLevelSpin.Enabled = False
                ManualSpellsCheck.Enabled = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Spellsknown radio control
    Private Sub SpellsKnownRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellsKnownRadio.CheckedChanged
        Try

            'enable/disable
            If SpellsKnownRadio.Checked Then
                NoSPDCheck.Enabled = True
                ManualSpellsCheck.Enabled = True
            Else
                NoSPDCheck.Checked = False
                NoSPDCheck.Enabled = False
                ManualSpellsCheck.Enabled = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the Inherits checkbox control
    Private Sub InheritCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InheritCheck.CheckedChanged
        Try
            'reset
            InheritDropdown.SelectedIndex = -1

            If InheritCheck.Checked Then
                InheritDropdown.Enabled = True
            Else
                InheritDropdown.Enabled = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the prestige spell level check box
    Private Sub SpellLevelCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpellLevelCheck.CheckedChanged
        SpellLevel.Value = 0
        If SpellLevelCheck.CheckState = CheckState.Checked Then
            SpellLevel.Properties.Enabled = True
        Else
            SpellLevel.Properties.Enabled = False
        End If
    End Sub

    'disables the controls on the caster tab 
    Private Sub DiableSpellCasterControls()
        Try

            'reset
            InheritDropdown.SelectedIndex = -1
            FirstSpin.Value = 3
            PerLevelSpin.Value = 1

            SpecialCheck.Checked = False
            RestrictDomains.Checked = False
            InheritCheck.Checked = False
            NoSPDCheck.Checked = False
            ManualSpellsCheck.Checked = False
            CasterLevelEqualRadio.Checked = True
            SpellListRadio.Checked = True
            MemCheck.Checked = False

            'disable
            CasterLabel.Enabled = False
            CasterType.Enabled = False
            BonusLabel.Enabled = False
            SpellAttribute.Enabled = False
            BonusSpellsCheck.Enabled = False
            BonusPointsCheck.Enabled = False
            DomainBonus.Enabled = False
            SchoolBonus.Enabled = False
            CasterLevelLabel.Enabled = False
            CasterLevelEqualRadio.Enabled = False
            CasterLevelHalfRadio.Enabled = False
            AcquisitionLabel.Enabled = False
            SpellListRadio.Enabled = False
            SpellsKnownRadio.Enabled = False
            SpellBookRadio.Enabled = False
            ManualSpellsCheck.Enabled = False
            SpecialCheck.Enabled = False
            RestrictDomains.Enabled = False
            InheritCheck.Enabled = False
            MemCheck.Enabled = False

        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    'enables the controls on the caster tab
    Private Sub EnableSpellCasterControls()

        'enable
        CasterLabel.Enabled = True
        CasterType.Enabled = True
        BonusLabel.Enabled = True
        SpellAttribute.Enabled = True
        BonusSpellsCheck.Enabled = True
        BonusPointsCheck.Enabled = True
        DomainBonus.Enabled = True
        SchoolBonus.Enabled = True
        CasterLevelLabel.Enabled = True
        CasterLevelEqualRadio.Enabled = True
        CasterLevelHalfRadio.Enabled = True
        AcquisitionLabel.Enabled = True
        SpellListRadio.Enabled = True
        SpellsKnownRadio.Enabled = True
        SpellBookRadio.Enabled = True
        SpecialCheck.Enabled = True
        RestrictDomains.Enabled = True
        InheritCheck.Enabled = True
        MemCheck.Enabled = True

    End Sub

    'handles the NoSPDCheck control
    Private Sub NoSPDCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoSPDCheck.CheckedChanged
        Try
            If NoSPDCheck.Checked = True Then
                BonusSpellsCheck.Checked = False
                DomainBonus.Checked = False
                SchoolBonus.Checked = False
                BonusPointsCheck.Checked = False
                MemCheck.Checked = False

                BonusSpellsCheck.Enabled = False
                DomainBonus.Enabled = False
                SchoolBonus.Enabled = False
                BonusPointsCheck.Enabled = False
                MemCheck.Enabled = False
            Else
                BonusSpellsCheck.Enabled = True
                DomainBonus.Enabled = True
                SchoolBonus.Enabled = True
                BonusPointsCheck.Enabled = True
                MemCheck.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

    Private Sub PrestigeCaster_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrestigeCaster.CheckedChanged
        Try
            If PrestigeCaster.Checked = True Then
                ArcaneCheck.Enabled = True
                DivineCheck.Enabled = True
                BothCheck.Enabled = True
                EitherCheck.Enabled = True
                SpellLevelLabel.Enabled = True
                SpellLevelCheck.Enabled = True
            Else
                ArcaneCheck.Enabled = False
                DivineCheck.Enabled = False
                BothCheck.Enabled = False
                EitherCheck.Enabled = False
                SpellLevelLabel.Enabled = False
                SpellLevelCheck.Enabled = False
                SpellLevel.Properties.Enabled = False
                SpellLevel.Value = 0
                SpellLevelCheck.CheckState = CheckState.Unchecked
                EitherCheck.Checked = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub InheritPowerCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InheritPowerCheck.CheckedChanged
        Try
            If InheritPowerCheck.Checked = True Then
                InheritPowerDropdown.Enabled = True
            Else
                InheritPowerDropdown.SelectedItem = Nothing
                InheritPowerDropdown.Enabled = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class


