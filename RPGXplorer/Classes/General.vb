Option Explicit On
Option Strict On

Imports System.IO.Directory
Imports DevExpress.XtraBars
Imports RPGXplorer.Exceptions

Public Class General

#Region "Enumerations"

    Public Enum SortType
        Alphabetic
        Numeric
        NumericPrefix
        NumericSuffix
    End Enum

    Public Enum FormMode
        NotSet
        Edit
        Add
    End Enum

    Public Enum AppMode
        Trial
        Full
    End Enum

    Public Enum DragSourceType
        Tree
        List
    End Enum

#End Region

#Region "Constants"

    'guid constants
    Public Const ConfigGuid As String = "001-00000000-0000-0000-0000-000000000003"
    Public Const MDITabsGuid As String = "001-00000000-0000-0000-0000-000000000009"

    'colour constants
    Public Shared ReadOnly ListViewAlternateColourFirst As Color = Color.White
    Public Shared ReadOnly ListViewAlternateColourSecond As Color = Color.FromArgb(235, 235, 235)
    Public Shared ReadOnly BackColourPositive As Color = Color.FromArgb(200, 255, 200)
    Public Shared ReadOnly BackColourNegative As Color = Color.FromArgb(255, 200, 200)
    Public Shared ReadOnly BackColourWhite As Color = Color.White
    Public Shared ReadOnly BackColourPaleYellow As Color = Color.FromArgb(255, 255, 192)
    Public Shared StyleColorBannerColor1 As Color
    Public Shared StyleColorBannerColor2 As Color
    Public Shared StyleColorFiller As Color

    'validation message constants
    Public Const ValidationUniqueName As String = "There is already a component called this."
    Public Const ValidationRequired As String = "This field is required."
    Public Const ValidationAtLeast1Required As String = "At least one of these is required."
    Public Const ValidationAtLeast2Required As String = "At least two of these is required."
    Public Const ValidationRaceModifier1 As String = "Modifier cannot be zero"
    Public Const ValidationRaceModifier2 As String = "Please select a value from this dropdown"
    Public Const ValidationDiceRange As String = "Dice Range incorrect - format is XdY or XdY+Z AND only d2,d3,d4,d6,d8,d10,d12,d20 or d100 allowed."
    Public Const ValidationPositiveWholeNumber As String = "The text must be a positive whole number."
    Public Const ValidationPositiveWholeNumberOrZero As String = "The text must be a positive whole number or zero."
    Public Const ValidationPWNumberOrDiceRange As String = "The text must either be a positive whole number or a dice range."
    Public Const ValidationPWNumberOrDiceRangeOrEmpty As String = "The text must either be blank, a positive whole number or a dice range."
    Public Const ValidationCannotBeZero As String = "Cannot be zero."
    Public Const ValidationNumberRange As String = "This number is not in the range of allowed values."
    Public Const ValidationSequence As String = "This number must be less than the one before it."
    Public Const ValidationSpellLevels As String = "This number cannot be less than previous spell level."
    Public Const ValidationSpellPoints As String = "This number cannot be less than previous spell points."
    Public Const ValidationForm As String = "This component editor has validation errors on some or all tabs. Please check each tab."
    Public Const ValidationBonusSpells As String = "The parent component already contains bonus spells for this level."
    Public Const ValidationCritical As String = "Only a damage dice range can be used with critical multipliers."
    Public Const ValidationSpellFormComponents As String = "At least one of Verbal, Somatic, Material or Other is required. "

    'dialog constants
    Public Const DialogCaption As String = "RPGXplorer"
    Public Const InvalidHTMLPath As String = "The path you select must be in the HelpPages folder."
    Public Const InvalidImagesPath As String = "The path you select must either be in the Images\SmallImages folder or the Images\LargeImages folder."

    'cut and paste constants
    Public Const PasteFailMessage2 As String = "Cannot paste onto multiple folders."
    Public Const PasteFailMessage3 As String = "Nothing to paste."
    Public Const PasteFailDefault As String = "'[name]' cannot be pasted into this folder, this is not permitted."
    Public Const PasteFailPrecondition As String = "'[name]' cannot be pasted as the component already contains this precondition."
    Public Const PasteFailModifier As String = "'[name]' cannot be pasted as this component already contains a modifier of this type."
    Public Const PasteFailModifierInappropriate As String = "'[name]' cannot be pasted as this modifier is inappropriate here."
    Public Const PasteFailFixed As String = "'[name]' cannot be moved or copied as it is fixed."
    Public Const PasteFailSysAbility As String = "'[name]' cannot be pasted as the component already contains this system ability."
    Public Const PasteFailUnique As String = "'[name]' cannot be pasted as the component already contains a component of this type."
    Public Const PasteFailFeature As String = "'[name]' cannot be pasted as the folder already contains this feature."
    Public Const PasteFailSpecificBonusFeat As String = "'[name]' cannot be pasted as the folder already contains this bonus feat."
    Public Const PasteFailSynergy As String = "'[name]' cannot be pasted as this skill already contains this synergy."
    Public Const PasteFailDamageAddition As String = "'[name]' cannot be pasted as the folder already contains extra damage of this damage type."
    Public Const PasteFailDamageResistance As String = "'[name]' cannot be pasted as the folder already contains a resistance to this damage type."
    Public Const PasteFailCondition As String = "'[name]' cannot be pasted, conditions can only be moved or copied from/to the same parent component type."
    Public Const PasteFailConditionBane As String = "'[name]' cannot be pasted, you can only have 1 bane condition per component."
    Public Const PasteFailWeaponEmulation As String = "'[name]' cannot be pasted as the component already contains this weapon emulation."
    Public Const PasteFailBonusSpells As String = "'[name]' cannot be pasted as the component already contains bonus spells of this level and magic type."
    Public Const PasteFailContainer As String = "'[name]' cannot be pasted onto itself."
    Public Const PasteFailContainerParent As String = "'[name]' cannot be pasted into its own child."
    Public Const PasteFailDatabase As String = "'[name]' cannot be pasted into a different database file."

    'paste failure form
    Public Const PasteFailureAll As String = "None of the components on the clipboard can be pasted into this folder."
    Public Const PasteFailureSome As String = "[count] out of [total] components could not be pasted."

    Public Shared Version As String = "RPGXplorer - Characters and Rules - Version " + Application.ProductVersion

#End Region

#Region "Member Variables"

    'the base path of the application
    Public Shared BasePath As String
    Public Shared HelpPath As String    
    Public Shared BrowserCommandLine As String

    'flag for closing
    Public Shared CloseWindowTriggered As Boolean = False

    'main UI
    Private Shared mMainExplorer As Explorer
    Private Shared mRulesViewer As DocumentViewer
    Private Shared mXMLWorkShop As CharacterXMLForm
    Private Shared mToolbar As Bar
    Private Shared mMenubar As Bar

    'config object
    Public Shared Config As Objects.ObjectData
    Public Shared MDITabs As Objects.ObjectData

    'miscellaneous
    Public Shared DataInput As Boolean
    Public Shared DoubleClickEdits As Boolean

    'marketplace
    Public Shared Marketplace As Marketplace

    'settings
    Public Shared UndoSteps As Integer
    Public Shared AutosaveInterval As Integer
    Public Shared CoinWeight As Double
    Public Shared MarketPrices As Integer = 0
    Public Shared ShowNewsOnStartup As Boolean
    Public Shared Mode As AppMode
    Public Shared RTimer As Timer = New Timer
    Public Shared TimeUp As Boolean = False
    Public Shared DragSource As DragSourceType

    'startup fixes
    Public Shared AnimalFix As Boolean
    Public Shared SpellFix As Boolean
    Public Shared DuplicateSystemComponentsFix As Boolean
    Public Shared DuplicateSkillGroupsFix As Boolean
    Public Shared ACBaseFix As Boolean
    Public Shared PsionicPatch As Boolean
    Public Shared MaterialPatch As Boolean
    Public Shared CharacterFolderPatch As Boolean

#End Region

#Region "Data Types"

    'structure to hold data within array lists used as data sources for controls
    Public Class DataListItem
        Implements IComparable

        Private DisplayData As String
        Private GUID As Objects.ObjectKey
        Private ValueData As Object

        Public Sub New(ByVal Value As Object, ByVal Display As String)
            Try
                DisplayData = Display
                ValueData = Value
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Sub New(ByVal Value As Object, ByVal Id As Objects.ObjectKey, ByVal Display As String)
            Try
                DisplayData = Display
                ValueData = Value
                GUID = Id
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Property DisplayMember() As String
            Get
                Return DisplayData
            End Get
            Set(ByVal Value As String)
                DisplayData = Value
            End Set
        End Property

        Public ReadOnly Property ObjectGUID() As Objects.ObjectKey
            Get
                Return GUID
            End Get
        End Property

        Public Property ValueMember() As Object
            Get
                Return ValueData
            End Get
            Set(ByVal Value As Object)
                ValueData = Value
            End Set
        End Property

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim Data As DataListItem

            Try
                Data = CType(obj, DataListItem)
                If Data.DisplayData < DisplayData Then
                    Return 1
                ElseIf Data.DisplayData > DisplayData Then
                    Return -1
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        Public Overrides Function ToString() As String
            Return DisplayData
        End Function

        Public Overloads Function Equals(ByVal obj As DataListItem) As Boolean
            Dim data As DataListItem
            'data = CType(obj, DataListItem)
            data = obj
            If data.DisplayMember = Me.DisplayMember Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Overloads Function Equals(ByVal obj As String) As Boolean
            If Me.DisplayMember = obj.ToString Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            If TypeOf obj Is String Then
                If Me.DisplayMember = obj.ToString Then
                    Return True
                Else
                    Return False
                End If
            End If

            Dim data As DataListItem
            data = CType(obj, DataListItem)
            If data.DisplayMember = Me.DisplayMember Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

    'structure to allow sorting of complex data with arraylist
    Public Class ArrayItem
        Implements IComparable

        Public Key As String
        Public Value As Object

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Try
                Dim Key As String = CType(obj, ArrayItem).Key

                If Key < Me.Key Then
                    Return 1
                ElseIf Key > Me.Key Then
                    Return -1
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

    End Class

#End Region

#Region "Properties"

    'the main explorer interface
    Public Shared Property MainExplorer() As Explorer
        Get
            Return mMainExplorer
        End Get
        Set(ByVal Value As Explorer)
            ListViewManager.LoadListViewColumnDefinitions()
            mMainExplorer = Value
            mMainExplorer.InitExplorer()
        End Set
    End Property

    'the rules viewer
    Public Shared Property RulesViewer() As DocumentViewer
        Get
            Return mRulesViewer
        End Get
        Set(ByVal Value As DocumentViewer)
            mRulesViewer = Value
        End Set
    End Property

    'the XML workshop
    Public Shared Property XMLWorkShop() As CharacterXMLForm
        Get
            Return mXMLWorkShop
        End Get
        Set(ByVal Value As CharacterXMLForm)
            mXMLWorkShop = Value
        End Set
    End Property

#End Region

    'must be called first
    Public Shared Sub InitApplication(ByVal ProgressBar As ProgressBar)
        Try
            Try
                Application.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Catch ex As Exception
            End Try

            InitColors()
            ProgressBar.Increment()

            'set base path
            BasePath = IO.Directory.GetCurrentDirectory
            BasePath = BasePath.Replace("\bin", "")
            BasePath &= "\"
            HelpPath = BasePath & "HTML\HelpPages\"

            'load db and types
            ProgressBar.Caption = "RPGXplorer - Loading Databases"
            XML.LoadDatabaseIndex()
            XML.LoadFolderLookup()
            XML.LoadXMLDB(ProgressBar)
            ProgressBar.Caption = "RPGXplorer - Loading Types"
            Objects.LoadObjectTypeDefinitions()

            'load config object
            Config.Load(New Objects.ObjectKey(ConfigGuid))

            'create FKLookup
            XML.LoadFKLookup(ProgressBar)
            ProgressBar.Increment()

            'load rules data
            ProgressBar.Caption = "RPGXplorer - Loading Rules"
            Rules.AbilityScores.LoadAbilityScoreData()
            Rules.Dice.LoadDiceTypes()
            Rules.Conditions.LoadConditions()
            Rules.ExperienceAndLevelling.LoadExperienceLevelsData()
            Rules.Lists.LoadLists()
            Rules.Size.LoadData()
            Rules.Encumberance.Load()
            Rules.SpecialMaterial.Load()
            ProgressBar.Increment()

            'miscellaneous loading
            PasteManager.Init()

            'load images
            ProgressBar.Caption = "RPGXplorer - Loading Images"
            Images.LoadImages()
            ProgressBar.Increment()

            'config
            ProgressBar.Caption = "RPGXplorer - Initializing Interface"
            MDITabs.Load(New Objects.ObjectKey(MDITabsGuid))
            LoadConfig()
            ProgressBar.Increment()

            'templates
            'Templates.LoadTemplates()

            'trial mode
            RTimer.Interval = 898765
            AddHandler RTimer.Tick, AddressOf TimerTick

            'reset all fixed rule pages
            'Dim Objs As Objects.ObjectDataCollection
            'Dim FixedPaths As New ArrayList

            'FixedPaths.Add("Help\AddEditCharacter.htm")
            'FixedPaths.Add("Help\Assets.htm")
            'FixedPaths.Add("Help\BonusFeat.htm")
            'FixedPaths.Add("Help\BonusFeat2.htm")
            'FixedPaths.Add("Help\BonusLanguage.htm")
            'FixedPaths.Add("Help\BonusSpellSlots.htm")
            'FixedPaths.Add("Help\CharacterClass.htm")
            'FixedPaths.Add("Help\Characters.htm")
            'FixedPaths.Add("Help\CharacterSheet.htm")
            'FixedPaths.Add("Help\Choices.htm")
            'FixedPaths.Add("Help\ChooseBonusFeat.htm")
            'FixedPaths.Add("Help\ChooseFeature.htm")
            'FixedPaths.Add("Help\ClassLevel.htm")
            'FixedPaths.Add("Help\ClassLevelsFolder.htm")
            'FixedPaths.Add("Help\Components.htm")
            'FixedPaths.Add("Help\Condition.htm")
            'FixedPaths.Add("Help\DeityFolder.htm")
            'FixedPaths.Add("Help\Enhancement.htm")
            'FixedPaths.Add("Help\ExtraDamage.htm")
            'FixedPaths.Add("Help\Feats.htm")
            'FixedPaths.Add("Help\Features.htm")
            'FixedPaths.Add("Help\FeaturesFolder.htm")
            'FixedPaths.Add("Help\FighterBonusFeat.htm")
            'FixedPaths.Add("Help\ImprovedUnarmed.htm")
            'FixedPaths.Add("Help\Inventory.htm")
            'FixedPaths.Add("Help\ItemsFolder.htm")
            'FixedPaths.Add("Help\Languages.htm")
            'FixedPaths.Add("Help\LanguagesFolder.htm")
            'FixedPaths.Add("Help\Levels.htm")
            'FixedPaths.Add("Help\MagicArmorAbility.htm")
            'FixedPaths.Add("Help\MagicItems.htm")
            'FixedPaths.Add("Help\MagicWeaponAbility.htm")
            'FixedPaths.Add("Help\Marketplace.htm")
            'FixedPaths.Add("Help\ModifierFolder.htm")
            'FixedPaths.Add("Help\ModifierLimiters.htm")
            'FixedPaths.Add("Help\Modifiers.htm")
            'FixedPaths.Add("Help\MonsterTypes.htm")
            'FixedPaths.Add("Help\Prerequisite.htm")
            'FixedPaths.Add("Help\PrestigeCasterProgression.htm")
            'FixedPaths.Add("Help\Skills.htm")
            'FixedPaths.Add("Help\Spells.htm")
            'FixedPaths.Add("Help\SpellsKnown.htm")
            'FixedPaths.Add("Help\SpellsKnownFolder.htm")
            'FixedPaths.Add("Help\SpellsPerDay.htm")
            'FixedPaths.Add("Help\SpellsPerDayFolder.htm")
            'FixedPaths.Add("Help\SystemAbility.htm")
            'FixedPaths.Add("Help\SystemElement.htm")
            'FixedPaths.Add("Help\SystemPrecondition.htm")
            'FixedPaths.Add("Help\SystemReference.htm")
            'FixedPaths.Add("Help\SystemWeaponAbility.htm")
            'FixedPaths.Add("Help\WeaponEmulation.htm")
            'FixedPaths.Add("Help\Weapons.htm")

            'XML.Lock = True

            'For n As Integer = 1 To 33
            '    Objs = Objects.GetObjectsByXPath(n, "/RPGXplorerDatabase/RPGXplorerObject")
            '    For Each Obj As Objects.ObjectData In Objs
            '        If FixedPaths.Contains(Obj.HTML) Then
            '            Obj.HTML = "Index.htm"
            '            Obj.HTMLGUID = Objects.ObjectKey.Empty
            '        End If
            '        Dim XmlNode As System.Xml.XmlNode

            '        XmlNode = Obj.XMLNode.SelectSingleNode("./URL")
            '        If Not XmlNode Is Nothing Then Obj.XMLNode.RemoveChild(XmlNode)

            '        If Not Obj.ShowOptionalColumns(Obj.Type) Then
            '            XmlNode = Obj.XMLNode.SelectSingleNode("./License")
            '            If Not XmlNode Is Nothing Then Obj.XMLNode.RemoveChild(XmlNode)
            '            XmlNode = Obj.XMLNode.SelectSingleNode("./PageNoRef")
            '            If Not XmlNode Is Nothing Then Obj.XMLNode.RemoveChild(XmlNode)
            '            XmlNode = Obj.XMLNode.SelectSingleNode("./Sourcebook")
            '            If Not XmlNode Is Nothing Then Obj.XMLNode.RemoveChild(XmlNode)
            '            XmlNode = Obj.XMLNode.SelectSingleNode("./Tags")
            '            If Not XmlNode Is Nothing Then Obj.XMLNode.RemoveChild(XmlNode)
            '        End If
            '        Obj.Save(True)
            '    Next
            'Next

            'XML.Lock = False 

            'Visual Basic String Equality
            'Nothing is treated as "". 

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'load all config settings
    Public Shared Sub LoadConfig()
        Try
            UndoSteps = Config.ElementAsInteger("UndoSteps")
            AutosaveInterval = Config.ElementAsInteger("AutosaveInterval")
            DataInput = CBool(General.Config.Element("DataInput"))
            DoubleClickEdits = CBool(General.Config.Element("DoubleClickEdits"))
            BrowserCommandLine = Config.Element("BrowserCommandLine")
            CoinWeight = Config.ElementAsNumber("CoinWeight")
            MarketPrices = Config.ElementAsInteger("MarketPrices")
            UI.SetLookAndFeel(Config.Element("LookAndFeel"))
            If Not General.Config.Element("NewsOnStartup") = "False" Then ShowNewsOnStartup = True

            'fix flags
            If Not General.Config.Element("AnimalPatch") = "True" Then AnimalFix = True
            If Not General.Config.Element("SpellFix") = "True" Then SpellFix = True
            If Not General.Config.Element("DuplicateSystemComponentsFix") = "True" Then DuplicateSystemComponentsFix = True
            If Not General.Config.Element("DuplicateSkillGroupsFix") = "True" Then DuplicateSkillGroupsFix = True
            If Not General.Config.Element("ACBaseFix") = "True" Then ACBaseFix = True
            If Not General.Config.Element("PsionicPatch") = "True" Then PsionicPatch = True
            If Not General.Config.Element("MaterialPatch") = "True" Then MaterialPatch = True
            If Not General.Config.Element("CharacterFolderPatch") = "True" Then CharacterFolderPatch = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save all config settings
    Public Shared Sub SaveConfig()
        Try
            Config.Save()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'set the styles colors
    Public Shared Sub InitColors()
        Dim x, y, r, g, b As Integer
        Dim Primary As Color

        Try
            Select Case Environment.OSVersion.Platform
                Case PlatformID.Win32NT
                    If Environment.OSVersion.Version.Major >= 5 Then
                        y = 25
                        x = 75
                    End If
                Case Else
                    y = 75
                    x = 50
            End Select

            Primary = SystemColors.Highlight

            If Primary.R + y > 255 Then r = 255 Else r = Primary.R + y
            If Primary.G + y > 255 Then g = 255 Else g = Primary.G + y
            If Primary.B + y > 255 Then b = 255 Else b = Primary.B + y

            Primary = Color.FromArgb(r, g, b)

            If Primary.R - x < 0 Then r = 0 Else r = Primary.R - x
            If Primary.G - x < 0 Then g = 0 Else g = Primary.G - x
            If Primary.B - x < 0 Then b = 0 Else b = Primary.B - x

            StyleColorBannerColor1 = Color.FromArgb(Primary.R, Primary.G, Primary.B)
            StyleColorBannerColor2 = Color.FromArgb(r, g, b)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'convert a string into a double or return zero
    Public Shared Function ConvertToDouble(ByVal Value As String) As Double
        Try
            Return Double.Parse(Value)
        Catch ex As System.FormatException
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'convert a string into an integer or return zero
    Public Shared Function ConvertToInteger(ByVal Value As String) As Integer
        Try
            Return Integer.Parse(Value)
        Catch ex As System.FormatException
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'convert a string into a double or return zero
    Public Shared Function ConvertToDouble(ByVal Value As Object) As Double
        Try
            Return Double.Parse(Value.ToString)
        Catch ex As System.FormatException
            Return 0
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'converts a string into an ObjectKey
    Public Shared Function ConvertToObjectKey(ByVal value As String, ByVal Database As Integer) As Objects.ObjectKey
        Try
            'convert string into guid
            Dim i As Integer = value.GetHashCode()
            Dim FocusGuid As New Objects.ObjectKey("0" & Database.ToString & "-" & New Guid(i, 1, 2, New Byte() {1, 2, 3, 4, 5, 6, 7, 8}).ToString)

            Return FocusGuid

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'find a string in a string array
    Public Shared Function ArrayStringFind(ByVal Array() As String, ByVal Value As String) As Integer
        Try
            For n As Integer = 0 To Array.GetUpperBound(0)
                If Array(n) = Value Then Return n
            Next

            Return -1
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'generic validation routine for all forms
    Public Shared Function ValidateForm(ByRef Controls As Control.ControlCollection, ByRef Errors As ErrorProvider) As Boolean
        Dim Obj As Object
        Dim Control As Control
        Dim Validate As Boolean = True

        Try
            For Each Control In Controls

                Obj = CType(Control, Object)

                If Control.CausesValidation Then

                    If TypeOf Control Is DevExpress.XtraEditors.SpinEdit Then
                        'SpinEdit
                        Dim SpinEdit As DevExpress.XtraEditors.SpinEdit = CType(Obj, DevExpress.XtraEditors.SpinEdit)

                        If SpinEdit.Enabled Then

                            Dim Valid As Boolean = True

                            'validate that it is a number within the range specified
                            Try
                                Dim Value As Double = CType(SpinEdit.EditValue, Double)

                                If Value > SpinEdit.Properties.MaxValue Then
                                    Valid = False
                                ElseIf Value < SpinEdit.Properties.MinValue Then
                                    Valid = False
                                End If
                            Catch ex As Exception
                                Valid = False
                            End Try

                            If Valid = False Then
                                Errors.SetError(Control, General.ValidationNumberRange)
                                Validate = False
                            Else
                                Errors.SetError(Control, "")
                            End If
                        End If

                    ElseIf TypeOf Control Is DevExpress.XtraEditors.ComboBoxEdit Then
                        'ComboBox
                        Dim Combo As DevExpress.XtraEditors.ComboBoxEdit = CType(Obj, DevExpress.XtraEditors.ComboBoxEdit)

                        If Combo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor Then
                            If Combo.Properties.Enabled And Combo.SelectedIndex = -1 Then
                                Errors.SetError(Control, General.ValidationRequired)
                                Validate = False
                            Else
                                Errors.SetError(Control, "")
                            End If
                        Else
                            If Combo.Properties.Enabled And Combo.Text = "" Then
                                Errors.SetError(Control, General.ValidationRequired)
                                Validate = False
                            Else
                                Errors.SetError(Control, "")
                            End If
                        End If

                    ElseIf TypeOf Control Is DevExpress.XtraEditors.MemoEdit Then
                        'MemoEdit
                        Dim Memo As DevExpress.XtraEditors.MemoEdit = CType(Obj, DevExpress.XtraEditors.MemoEdit)

                        If Memo.Properties.Enabled And Memo.Text = "" Then
                            Errors.SetError(Control, General.ValidationRequired)
                            Validate = False
                        Else
                            Errors.SetError(Control, "")
                        End If

                    ElseIf TypeOf Control Is DevExpress.XtraEditors.TextEdit Then
                        'TextEdit
                        Dim TextEdit As DevExpress.XtraEditors.TextEdit = CType(Obj, DevExpress.XtraEditors.TextEdit)

                        If TextEdit.Properties.Enabled And TextEdit.Text = "" Then
                            Errors.SetError(Control, General.ValidationRequired)
                            Validate = False
                        Else
                            Errors.SetError(Control, "")
                        End If
                    End If

                End If
            Next

            Return Validate
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'generic validation routine that shows a form validation indicator
    Public Shared Sub ValidateFormIndicator(ByVal Valid As Boolean, ByRef Button As Button, ByRef Errors As ErrorProvider)
        Try
            If Valid Then
                Errors.SetError(Button, "")
            Else
                Errors.SetError(Button, ValidationForm)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Dialogs"

    'show error dialog
    Public Shared Sub ShowErrorDialog(ByVal Message As String)
        Try
            MessageBox.Show(Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'show info dialog
    Public Shared Sub ShowInfoDialog(ByVal Message As String)
        Try
            MessageBox.Show(Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'show question dialog
    Public Shared Function ShowQuestionDialog(ByVal Question As String) As DialogResult
        Try
            Return MessageBox.Show(Question, DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Cursor"

    'set wait cursor
    Public Shared Sub SetWaitCursor(Optional ByRef Form As Form = Nothing)
        If Form Is Nothing Then Form = General.MainExplorer.Form
        Form.Cursor = Cursors.WaitCursor
    End Sub

    'set normal cursor
    Public Shared Sub SetNormalCursor(Optional ByRef Form As Form = Nothing)
        If Form Is Nothing Then Form = General.MainExplorer.Form
        Form.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Trial Mode"

    'trial mode for rules browser
    Private Shared Sub TimerTick(ByVal sender As Object, ByVal e As EventArgs)
        TimeUp = True
        RTimer.Stop()
        If Not General.RulesViewer Is Nothing Then
            General.RulesViewer.Close()
            ShowInfoDialog("You are in trial mode, the rules viewer is time-limited to 15 minutes. Restart the application to get another 15 minutes.")
        End If
    End Sub

#End Region

End Class