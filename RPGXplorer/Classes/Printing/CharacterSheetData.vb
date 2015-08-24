Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class CharacterSheetData

        'this class is responsible for marshalling the data required for the character sheet

#Region "Member Variables"

        Private Character As Rules.Character
        Private Inventory As Rules.Inventory
        Private Proficiency As Rules.Proficiency
        Private data As CharacterDataset
        Private InventoryTemp As ArrayList
        Private ModifierDisplay As RPGXplorer.ModifiersDisplay

#End Region

#Region "Structures"

        Private Structure InventoryItem
            Public Name As String
            Public Weight As String
            Public Cost As String
            Public Item As Objects.ObjectData
            Public Charges As String
            Public Active As String
            Public Notes As String
        End Structure

#End Region

        'caster level
        Public ReadOnly Property CasterLevel() As CasterLevelDataset
            Get
                Dim Data As New CasterLevelDataset
                Dim Row As CasterLevelDataset.CasterLevelRow
                Dim CasterLevels As New SortedList
                Dim CL As Rules.Character.CasterLevel

                For Each Item As DictionaryEntry In Character.CurrentLevel.CasterLevels
                    CL = CType(Item.Value, Rules.Character.CasterLevel)
                    If CL.CasterLevel > 0 Then
                        If Character.CharacterClasses(CL.ClassGuid).IsCaster Then CasterLevels.Add(CL.ClassName, CL)
                    End If
                Next

                For Each CL In CasterLevels.GetValueList
                    'get the ability score
                    Dim AbilityScore As Integer = Character.Spells.GetSpellAbilityScore(Character.CharacterClasses(CL.ClassGuid), Character.CharacterLevel)
                    Dim AbilityMod As Integer = Rules.AbilityScores.AbilityScore(AbilityScore).Modifier

                    'get the spell points
                    Dim SpellSlots As Rules.SpellSlots
                    SpellSlots = New SpellSlots(Character, CL.ClassGuid)
                    SpellSlots.Load()

                    'create the row
                    Row = Data.CasterLevel.NewCasterLevelRow
                    Row.ClassName = CL.ClassName
                    Row.Level = CL.CasterLevel.ToString
                    Row.L0 = (10 + AbilityMod + 0).ToString
                    Row.L1 = (10 + AbilityMod + 1).ToString
                    Row.L2 = (10 + AbilityMod + 2).ToString
                    Row.L3 = (10 + AbilityMod + 3).ToString
                    Row.L4 = (10 + AbilityMod + 4).ToString
                    Row.L5 = (10 + AbilityMod + 5).ToString
                    Row.L6 = (10 + AbilityMod + 6).ToString
                    Row.L7 = (10 + AbilityMod + 7).ToString
                    Row.L8 = (10 + AbilityMod + 8).ToString
                    Row.L9 = (10 + AbilityMod + 9).ToString
                    Row.SP = "0"
                    Row.SP = (SpellSlots.SpellPoints + SpellSlots.BonusSpellPoints + SpellSlots.SpellPointsModifier).ToString

                    'add to dataset
                    Data.CasterLevel.AddCasterLevelRow(Row)
                Next

                Return Data

            End Get
        End Property

        'caster level
        Public ReadOnly Property ManifesterLevel() As ManifesterLevelDataset
            Get
                Dim Data As New ManifesterLevelDataset

                Dim Row As ManifesterLevelDataset.ManifesterLevelRow
                Dim CasterLevels As New SortedList
                Dim CL As Rules.Character.CasterLevel

                For Each Item As DictionaryEntry In Character.CurrentLevel.CasterLevels
                    CL = CType(Item.Value, Rules.Character.CasterLevel)
                    If CL.CasterLevel > 0 Then
                        If Character.CharacterClasses(CL.ClassGuid).IsPsionic Then CasterLevels.Add(CL.ClassName, CL)
                    End If
                Next

                For Each CL In CasterLevels.GetValueList
                    'get the ability score
                    Dim AbilityScore As Integer = Character.Powers.GetPowerAbilityScore(Character.CharacterClasses(CL.ClassGuid), Character.CharacterLevel)
                    Dim AbilityMod As Integer = Rules.AbilityScores.AbilityScore(AbilityScore).Modifier

                    'create the row
                    Row = Data.ManifesterLevel.NewManifesterLevelRow
                    Row.ClassName = CL.ClassName
                    Row.Level = CL.CasterLevel.ToString
                    Row.L0 = (10 + AbilityMod + 0).ToString
                    Row.L1 = (10 + AbilityMod + 1).ToString
                    Row.L2 = (10 + AbilityMod + 2).ToString
                    Row.L3 = (10 + AbilityMod + 3).ToString
                    Row.L4 = (10 + AbilityMod + 4).ToString
                    Row.L5 = (10 + AbilityMod + 5).ToString
                    Row.L6 = (10 + AbilityMod + 6).ToString
                    Row.L7 = (10 + AbilityMod + 7).ToString
                    Row.L8 = (10 + AbilityMod + 8).ToString
                    Row.L9 = (10 + AbilityMod + 9).ToString

                    'add to dataset
                    Data.ManifesterLevel.AddManifesterLevelRow(Row)
                Next

                Dim Row2 As ManifesterLevelDataset.PowerPointsRow
                Row2 = Data.PowerPoints.NewPowerPointsRow

                Dim PowerPoints As New Rules.PowerPoints(Character)
                Row2.Points = PowerPoints.PowerPoints.ToString
                Data.PowerPoints.AddPowerPointsRow(Row2)

                Return Data

            End Get
        End Property

        'spellcaster notes
        Public ReadOnly Property SpellNotes() As SpellNotesDataset
            Get
                Dim Data As New SpellNotesDataset
                Dim Notes As New SortedList

                For Each Folder As Objects.ObjectData In Character.MagicFolder.ChildrenOfType(Objects.ClassSpellSettingsFolderType)
                    Notes.Add(Folder.Element("Class"), Folder.Element("SpellNotes"))
                Next

                For Each ClassName As String In Notes.Keys
                    Data.SpellNotes.AddSpellNotesRow(ClassName, CType(Notes.Item(ClassName), String))
                Next

                Return Data
            End Get
        End Property

        'manifester notes
        Public ReadOnly Property PowerNotes() As SpellNotesDataset
            Get
                Dim Data As New SpellNotesDataset
                Dim Notes As New SortedList

                For Each Folder As Objects.ObjectData In Character.PsionicFolder.ChildrenOfType(Objects.ClassPowerSettingsFolderType)
                    Notes.Add(Folder.Element("Class"), Folder.Element("PsionicNotes"))
                Next

                For Each ClassName As String In Notes.Keys
                    Data.SpellNotes.AddSpellNotesRow(ClassName, CType(Notes.Item(ClassName), String))
                Next

                Return Data
            End Get
        End Property

        'domains and specialist/prohibited schools
        Public ReadOnly Property DomainsAndSchools() As DomainsSchoolsDataset
            Get

                Dim Data As New DomainsSchoolsDataset
                Dim Row As DomainsSchoolsDataset.DomainsSchoolsRow

                'load the data
                Dim Domains As New Hashtable
                Dim Specialist As New Hashtable
                Dim Prohibited As New Hashtable
                Dim Domain As Domain
                Dim List As ArrayList

                'domains
                For Each ItemData As Library.LibraryData In Character.Domains.Domains.ItemData
                    Domain = CType(ItemData.Data, Domain)
                    Dim Classkey As Objects.ObjectKey = Domain.DomainObj.GetFKGuid("Class")

                    If Not Domains.ContainsKey(Classkey) Then
                        List = New ArrayList
                        Domains.Add(Classkey, List)
                    Else
                        List = CType(Domains.Item(Classkey), ArrayList)
                    End If
                    List.Add(Domain.DomainObj.Name)
                Next

                'schools
                Character.Spells.SpellSchoolTable(Specialist, Prohibited)

                'go through all the classes
                Dim SortedClasses As SortedList = Sorter.LoadSortedList(Character.CharactersClassObjects, SortType.Alphabetic)

                For Each ClassObj As Objects.ObjectData In SortedClasses.GetValueList
                    Dim Classkey As Objects.ObjectKey = ClassObj.ObjectGUID

                    'if this class had a domain or a school
                    If Domains.ContainsKey(Classkey) OrElse Specialist.ContainsKey(Classkey) OrElse Prohibited.ContainsKey(Classkey) Then
                        Row = Data.DomainsSchools.NewDomainsSchoolsRow
                        Row.ClassName = ClassObj.Name

                        If Domains.ContainsKey(classkey) Then
                            List = CType(Domains.Item(classkey), ArrayList)
                            List.Sort()
                            Row.Domains = CommonLogic.CommaSeparatedList(List)
                        End If

                        If Specialist.ContainsKey(classkey) Then
                            List = CType(Specialist.Item(classkey), ArrayList)
                            List.Sort()
                            Row.Specialist = CommonLogic.CommaSeparatedList(List)
                        End If

                        If Prohibited.ContainsKey(classkey) Then
                            List = CType(Prohibited.Item(classkey), ArrayList)
                            List.Sort()
                            Row.Prohibited = CommonLogic.CommaSeparatedList(List)
                        End If

                        Data.DomainsSchools.AddDomainsSchoolsRow(Row)

                    End If
                Next
                Return Data
            End Get
        End Property

        Public ReadOnly Property PsionicSpecializations() As PsionocSpecializationsDataset
            Get

                Dim Data As New PsionocSpecializationsDataset
                Dim Row As PsionocSpecializationsDataset.PsionicSpecializationsRow

                'go through all the classes
                Dim SortedClasses As SortedList = Sorter.LoadSortedList(Character.CharactersClassObjects, SortType.Alphabetic)
                For Each ClassObj As Objects.ObjectData In SortedClasses.GetValueList
                    Dim Classkey As Objects.ObjectKey = ClassObj.ObjectGUID
                    Dim Templist As ArrayList

                    'if this class has any specializations
                    Dim ClassSpecializations As ArrayList
                    ClassSpecializations = Character.PsionicSpecializations.ClassSpecializations(Classkey, Character.CharacterLevel)
                    If ClassSpecializations.Count > 0 Then
                        Templist = New ArrayList
                        For Each TempSpec As PsionicSpecialization In ClassSpecializations
                            Templist.Add(TempSpec.SpecializationObj.Name)
                        Next
                        Templist.Sort()

                        Row = Data.PsionicSpecializations.NewPsionicSpecializationsRow
                        Row.ClassName = ClassObj.Name
                        Row.Specializations = CommonLogic.CommaSeparatedList(Templist)
                        Data.PsionicSpecializations.AddPsionicSpecializationsRow(Row)
                    End If
                Next
                Return Data

            End Get
        End Property

        'spell modifiers
        Public ReadOnly Property SpellModifiers() As SpellModifiersDataset
            Get

                Dim Data As New SpellModifiersDataset
                Dim ModifiersList As New ArrayList
                Dim ModifierDisplay As New RPGXplorer.ModifiersDisplay(Character.Components)

                ModifierDisplay.ProcessComponentsByConcept(ModifiersDisplay.DisplayConcept.Magic, True)

                For Each Modifier As ModifiersDisplay.Modifier In ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Magic)
                    ModifiersList.Add(Modifier)
                Next

                ModifiersList.Sort(New ModifiersDisplay.LimiterComparer)

                For Each Item As ModifiersDisplay.Modifier In ModifiersList
                    Data.SpellModifiers.AddSpellModifiersRow(Item.Limiter, Rules.Formatting.ModifierCoreName(Item), Item.Type, Item.Source)
                Next

                Return Data

            End Get
        End Property

        'power modifiers
        Public ReadOnly Property PowerModifiers() As SpellModifiersDataset
            Get
                Dim Data As New SpellModifiersDataset
                Dim ModifiersList As New ArrayList
                Dim ModifierDisplay As New RPGXplorer.ModifiersDisplay(Character.Components)

                ModifierDisplay.ProcessComponentsByConcept(ModifiersDisplay.DisplayConcept.Psionic, True)

                For Each Modifier As ModifiersDisplay.Modifier In ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Psionic)
                    ModifiersList.Add(Modifier)
                Next

                ModifiersList.Sort(New ModifiersDisplay.LimiterComparer)

                For Each Item As ModifiersDisplay.Modifier In ModifiersList
                    Data.SpellModifiers.AddSpellModifiersRow(Item.Limiter, Rules.Formatting.ModifierCoreName(Item), Item.Type, Item.Source)
                Next

                Return Data
            End Get
        End Property

        'attacks
        Public ReadOnly Property Attacks() As AttacksDataset
            Get
                Dim data As New AttacksDataset
                Dim Attack As New Rules.Attacks
                Attack.Init(Character, Proficiency)

                'get the weapons in sort order
                Dim WeaponConfigFolder As Objects.ObjectData = Character.CharacterObject.FirstChildOfType(Objects.WeaponConfigFolderType)
                Dim Sorted As SortedList = Sorter.LoadSortedList(WeaponConfigFolder.ChildrenOfType(Objects.WeaponConfigType), SortType.NumericSuffix)

                'store the current character component state
                Dim FullBaseline As Rules.Components = Character.Components.Clone

                'recalculate without the shield modifiers
                Character.CalculateForWeaponsPanel()
                Dim WeaponBaseline As Rules.Components = Character.Components.Clone

                'init each weapon and add to report data source
                Dim WeaponsObj As Objects.ObjectData
                Dim Weapons As Rules.Weapons
                For Each Item As DictionaryEntry In Sorted
                    WeaponsObj = CType(Item.Value, Objects.ObjectData)

                    'is this a normal or monster config?
                    If WeaponsObj.Element("MonsterConfig") = "Yes" Then
                        Weapons = New Rules.MonsterWeapons
                    Else
                        Weapons = New Rules.Weapons
                    End If

                    If WeaponsObj.IsEmpty Then
                        Weapons.Init(Character, Proficiency, Inventory, WeaponConfigFolder.ObjectGUID, WeaponBaseline)
                    Else
                        Weapons.Init(Character, Proficiency, Inventory, WeaponConfigFolder.ObjectGUID, WeaponBaseline)
                        Weapons.Load(WeaponsObj)
                    End If

                    Dim Display As Rules.Weapons.DisplayDetails = Weapons.GetConfigurationDisplay

                    Dim RtfHeader As String
                    RtfHeader = "{\rtf1\ansi\ansicpg1252\deff0\deflang2057{\fonttbl{\f0\fswiss\fcharset0 Arial;}}{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\f0\fs16 "

                    Dim DisplayString As String = Display.Line1 & Environment.NewLine & Display.Line2 & Environment.NewLine & Display.Line3 & Environment.NewLine & Display.Line4
                    DisplayString = DisplayString.Replace(Environment.NewLine, "\par" & Environment.NewLine)
                    data.Attacks.AddAttacksRow("", "", RtfHeader & DisplayString & "}")
                Next

                'reset character to the previous state
                Character.Components = FullBaseline
                Character.Modifiers.Calculate(True)

                Return data
            End Get
        End Property

        '        'skills
        Public ReadOnly Property Skills() As SkillsDataset
            Get
                Character.CalculateInventory()
                Dim data As New SkillsDataset
                Dim SkillDisplayInfo As ArrayList = Character.Skills.SkillDisplayInfo
                Dim x As Integer = 1
                Dim dr As SkillsDataset.SkillsRow = Nothing

                For i As Integer = 0 To SkillDisplayInfo.Count - 1
                    Dim SkillData As Skills.SkillInfo = CType(SkillDisplayInfo(i), Skills.SkillInfo)

                    If ((i + 1) Mod 4) = 1 Then
                        dr = CType(data.Skills.NewRow, SkillsDataset.SkillsRow)
                        x = 1
                    End If

                    dr.SetField("Skill" + x.ToString() + "Name", SkillData.SkillName)
                    dr.SetField("Skill" + x.ToString(), SkillData.FinalSkillModifier)
                    dr.SetField("Skill" + x.ToString() + "Info", SkillData.InfoSummary)
                    If ((i + 1) Mod 4) = 0 Then
                        data.Skills.AddSkillsRow(dr)
                        dr = Nothing
                    End If

                    x += 1
                Next
                If dr IsNot Nothing Then data.Skills.AddSkillsRow(dr)

                Return data

            End Get
        End Property

        'feats
        Public ReadOnly Property Feats() As FeatsDataset
            Get
                Dim data As New FeatsDataset
                Dim FeatList As New SortedList
                Dim FeatName As String
                Dim FeatObj As New Objects.ObjectData
                Dim Feat As Character.Feat
                Dim MultiplesCollection As New Hashtable
                Dim PrerequisitesMet As Boolean

                For Each Item As Library.LibraryData In Character.Feats.ItemData
                    Feat = CType(Item.Data, Character.Feat)

                    If Feat.Disabled = False Then

                        If Feat.FocusGuid.IsEmpty Then
                            PrerequisitesMet = Character.Components.IsFeatValid(Feat.FeatGuid.ToString)
                        Else
                            PrerequisitesMet = Character.Components.IsFeatValid(Feat.FeatGuid.ToString & Feat.FocusGuid.ToString)
                        End If

                        If PrerequisitesMet Or Feat.IgnorePrerequisites Then

                            FeatName = Feat.FeatName

                            'focus
                            If Feat.FocusGuid.IsNotEmpty Then
                                FeatName &= " (" & Feat.FocusName & ")"
                            End If

                            'same feat twice
                            If FeatList.Contains(FeatName) Then
                                RecordMultiple(MultiplesCollection, FeatName)
                            Else
                                FeatObj.Load(Feat.FeatGuid)
                                FeatList.Add(FeatName, FeatObj.Element("Description"))

                            End If

                        End If

                    End If
                Next

                'include the multiples
                AddMultiples(FeatList, MultiplesCollection)

                For Each Item As DictionaryEntry In FeatList
                    data.Feats.AddFeatsRow(Item.Key.ToString, Item.Value.ToString)
                Next

                Return data
            End Get
        End Property

        'features
        Public ReadOnly Property Features() As FeaturesDataset
            Get
                Dim data As New FeaturesDataset
                Dim Feature As Feature
                Dim CalcFeature As CalculatedFeature
                Dim FeatureList As New SortedList
                Dim FeatureObj As New Objects.ObjectData
                Dim MultiplesCollection As New Hashtable

                'non progressed features
                For Each Item As Library.LibraryData In Character.Features.Features.ItemData
                    Feature = CType(Item.Data, Feature)
                    If Feature.ProgressiveFeature = False Then

                        If Feature.Disabled = False Then

                            'same feature twice
                            If FeatureList.Contains(Feature.FeatureName) Then
                                RecordMultiple(MultiplesCollection, Feature.FeatureName)
                            Else
                                FeatureObj.Load(Feature.FeatureGuid)
                                FeatureList.Add(Feature.FeatureName, FeatureObj.Element("Description"))
                            End If
                        End If

                    End If
                Next

                'calculated progressed features
                For Each Item As Library.LibraryData In Character.Features.CalculatedFeatures.ItemData
                    CalcFeature = CType(Item.Data, CalculatedFeature)
                    FeatureObj.Load(CalcFeature.FeatureAtLevel(Character.CharacterLevel))

                    If FeatureList.Contains(FeatureObj.Name) Then
                        RecordMultiple(MultiplesCollection, FeatureObj.Name)
                    Else
                        FeatureList.Add(FeatureObj.Name, FeatureObj.Element("Description"))
                    End If
                Next

                'include the multiples
                AddMultiples(FeatureList, MultiplesCollection)

                For Each Item As DictionaryEntry In FeatureList
                    data.Features.AddFeaturesRow(Item.Key.ToString, Item.Value.ToString)
                Next

                Return data
            End Get
        End Property

        'conditional modifiers
        Public ReadOnly Property ConditionalModifiers() As ConditionalModifiersDataset
            Get
                Dim Data As New ConditionalModifiersDataset
                Dim ModifiersList As New ArrayList

                If ModifierDisplay Is Nothing Then
                    ModifierDisplay = New RPGXplorer.ModifiersDisplay(Character.Components)
                    ModifierDisplay.ProcessAllComponents(True)
                End If

                For Each Modifier As ModifiersDisplay.Modifier In ModifierDisplay.GetModifiersWithLimiters()
                    ModifiersList.Add(Modifier)
                Next

                ModifiersList.Sort(New ModifiersDisplay.LimiterComparer)

                For Each Item As ModifiersDisplay.Modifier In ModifiersList
                    Data.ConditionalModifiers.AddConditionalModifiersRow(Item.Limiter, Rules.Formatting.ModifierCoreName(Item), Item.Type, Item.Source)
                Next

                Return Data
            End Get
        End Property

        'modifiers
        Public ReadOnly Property Modifiers() As ModifiersDataset
            Get
                Dim Data As New ModifiersDataset
                Dim ModifiersList As New ArrayList

                If ModifierDisplay Is Nothing Then
                    ModifierDisplay = New RPGXplorer.ModifiersDisplay(Character.Components)
                    ModifierDisplay.ProcessAllComponents(True)
                End If

                For Each Modifier As ModifiersDisplay.Modifier In ModifierDisplay.GetCharacterSheetModifiers()
                    ModifiersList.Add(Modifier)
                Next

                ModifiersList.Sort(New ModifiersDisplay.ModifierComparer)

                For Each Item As ModifiersDisplay.Modifier In ModifiersList
                    Data.Modifiers.AddModifiersRow(Rules.Formatting.ModifierCoreName(Item), Item.Type, Item.Source)
                Next

                Return Data
            End Get
        End Property

        'used to track multiple feats/features with the same name
        Private Sub RecordMultiple(ByVal Multiples As Hashtable, ByVal Key As String)
            If Multiples.Contains(Key) Then
                Multiples.Item(Key) = (CInt(Multiples(Key)) + 1)
            Else
                Multiples.Add(Key, 2)
            End If
        End Sub

        'adds stored multiples from a hashtable into a sorted list 
        Private Sub AddMultiples(ByVal List As SortedList, ByVal Multiples As Hashtable)
            For Each Item As DictionaryEntry In Multiples
                Dim TempDescription As String
                TempDescription = CStr(List.Item(Item.Key))

                List.Remove(Item.Key)
                List.Add(CStr(Item.Key) & " x" & CStr(Item.Value), TempDescription)
            Next
        End Sub

        'assets
        Public ReadOnly Property AssetsData() As AssetsDataset
            Get
                Dim data As New AssetsDataset

                Dim AssetsFolder As Objects.ObjectData = Character.CharacterObject.FirstChildOfType(Objects.AssetsFolderType)
                If AssetsFolder.IsEmpty Then Return data

                'recurse through inventory
                InventoryTemp = New ArrayList
                InventoryRecurse2(AssetsFolder)

                'add to dataset
                For Each InventoryItem As InventoryItem In InventoryTemp
                    data.Assets.AddAssetsRow(InventoryItem.Name, InventoryItem.Weight, InventoryItem.Cost, InventoryItem.Notes, InventoryItem.Charges)
                Next

                'add blanks
                Dim Blanks As Integer = General.Config.ElementAsInteger("AssetsBlanks")
                Dim Blank As AssetsDataset.AssetsRow
                If Blanks > 0 Then
                    For n As Integer = 1 To Blanks
                        Blank = data.Assets.NewAssetsRow
                        data.Assets.AddAssetsRow(Blank)
                    Next
                End If

                Return data
            End Get
        End Property

        'inventory
        Public ReadOnly Property InventoryData() As InventoryDataset
            Get
                Dim data As New InventoryDataset
                InventoryTemp = New ArrayList

                'recurse through inventory
                InventoryRecurse2(Inventory.InventoryFolder)

                'add to dataset
                For Each Item As InventoryItem In InventoryTemp
                    data.Inventory.AddInventoryRow(Item.Name, Item.Weight, Item.Cost, Item.Notes, Item.Charges, Item.Active)

                Next

                'add blanks
                Dim Blanks As Integer = General.Config.ElementAsInteger("InventoryBlanks")
                Dim Blank As InventoryDataset.InventoryRow
                If Blanks > 0 Then
                    For n As Integer = 1 To Blanks
                        Blank = data.Inventory.NewInventoryRow
                        data.Inventory.AddInventoryRow(Blank)
                    Next
                End If

                Return data
            End Get
        End Property

        'inventory recurse
        Private Sub InventoryRecurse(ByVal Item As Objects.ObjectData)

            'check for children
            Dim Children As Objects.ObjectDataCollection = Item.Children

            If Children.Count > 0 And (Not Item.Element("ItemType") = Objects.ScrollDefinitionType) Then
                Dim InventoryItem As New InventoryItem
                Dim prefix As String

                If Not (Item.Type = Objects.InventoryFolderType Or Item.Type = Objects.AssetsFolderType) Then
                    'add blank ???
                    InventoryTemp.Add(InventoryItem)

                    'add container
                    InventoryItem.Name = Item.Name
                    InventoryItem.Cost = ""
                    InventoryItem.Weight = Rules.Formatting.FormatPounds(ContainerWeight(Item))
                    InventoryItem.Item = Item
                    InventoryTemp.Add(InventoryItem)

                    prefix = "   "
                Else
                    prefix = ""
                End If

                Dim ChildrenSorted As SortedList = Sorter.LoadSortedList(Children, SortType.Alphabetic)
                'add children
                Dim Child As Objects.ObjectData

                For Each SubItem As DictionaryEntry In ChildrenSorted

                    Child = CType(SubItem.Value, Objects.ObjectData)
                    InventoryItem.Name = prefix & Child.Name
                    If Child.ElementAsInteger("Quantity") > 1 Then InventoryItem.Name &= " x" & Child.Element("Quantity")
                    InventoryItem.Cost = Child.Element("Cost")
                    If Child.Element("Weight") = "0 lb." Then
                        InventoryItem.Weight = ""
                    Else
                        InventoryItem.Weight = Child.Element("Weight")
                    End If
                    InventoryItem.Item = Child
                    If Child.ElementAsInteger("Charges") = 0 Then
                        InventoryItem.Charges = ""
                    Else
                        InventoryItem.Charges = Child.Element("Charges")
                    End If
                    InventoryItem.Active = Child.Element("Active")
                    InventoryItem.Notes = Child.Element("Notes")
                    InventoryTemp.Add(InventoryItem)
                Next

                'recurse
                For Each Child In Children
                    InventoryRecurse(Child)
                Next

            End If

        End Sub

        'inventory recurse for a single inventory list
        Private Sub InventoryRecurse2(ByVal Item As Objects.ObjectData, Optional ByVal Prefix As String = "")
            Dim InventoryItem As InventoryItem
            Dim Children As Objects.ObjectDataCollection = Item.Children

            'create the item if required
            If Not (Item.Type = Objects.InventoryFolderType Or Item.Type = Objects.AssetsFolderType) Then
                InventoryItem.Name = Prefix & Item.Name
                InventoryItem.Item = Item
                InventoryItem.Cost = Item.Element("Cost")
                InventoryItem.Active = Item.Element("Active")
                InventoryItem.Notes = Item.Element("Notes")
                If Item.ElementAsInteger("Charges") = 0 Then InventoryItem.Charges = "" Else InventoryItem.Charges = Item.Element("Charges")
                If Item.ElementAsInteger("Quantity") > 1 Then InventoryItem.Name &= " x" & Item.Element("Quantity")
                If Item.Element("Weight") = "0 lb." Then InventoryItem.Weight = "" Else InventoryItem.Weight = Item.Element("Weight")
                If (Children.Count > 0 And (Not Item.Element("ItemType") = Objects.ScrollDefinitionType)) Then
                    If InventoryItem.Weight <> "" Then
                        InventoryItem.Weight = InventoryItem.Weight.Replace(" lb.", "") & "/" & Rules.Formatting.FormatPounds(ContainerWeight(Item))
                    Else
                        InventoryItem.Weight &= "0/" & Rules.Formatting.FormatPounds(ContainerWeight(Item))
                    End If
                End If
                InventoryTemp.Add(InventoryItem)
                Prefix &= "   "
            End If

            If Children.Count > 0 And (Not Item.Element("ItemType") = Objects.ScrollDefinitionType) Then
                Dim ChildrenSorted As SortedList = Sorter.LoadSortedList(Children, SortType.Alphabetic)
                Dim Child As Objects.ObjectData

                For Each SubItem As DictionaryEntry In ChildrenSorted
                    Child = CType(SubItem.Value, Objects.ObjectData)
                    InventoryRecurse2(Child, Prefix)
                Next
            End If
        End Sub

        'get total weight of container
        Private Function ContainerWeight(ByVal Item As Objects.ObjectData) As Double
            Dim Weight As Double
            Dim Children As Objects.ObjectDataCollection = Item.Children

            If Children.Count > 0 Then
                For Each Child As Objects.ObjectData In Children
                    Weight += ContainerWeight(Child)
                Next
            End If

            If Item.Element("Weight") <> "" Then Weight += CType(Item.Element("Weight").Replace(" lb.", ""), Double)

            Return Weight
        End Function

        'spells per day
        Public ReadOnly Property SpellsPerDayData() As SpellsPerDayDataset
            Get
                Dim data As New SpellsPerDayDataset

                If Character.CurrentLevel.CasterLevels Is Nothing Then Return data

                Dim row As SpellsPerDayDataset.SpellsPerDayRow

                'get all the caster classes
                Dim CasterLevel As Rules.Character.CasterLevel

                'sort caster levels
                Dim CasterLevels As New SortedList
                For Each Item As DictionaryEntry In Character.CurrentLevel.CasterLevels
                    CasterLevel = CType(Item.Value, Rules.Character.CasterLevel)
                    If CasterLevel.CasterLevel > 0 Then
                        If Character.CharacterClasses(CasterLevel.ClassGuid).IsCaster Then CasterLevels.Add(CasterLevel.ClassName, CasterLevel)
                    End If
                Next

                For Each CasterLevel In CasterLevels.GetValueList

                    'get the SPD Datasets
                    Dim SpellSlots As SpellSlots = New Rules.SpellSlots(Character, CasterLevel.ClassGuid)
                    SpellSlots.Load()

                    Dim SPDData As DataRow = SpellSlots.GetSPDDatatable.Rows(0)
                    Dim DomianData As DataRow = SpellSlots.GetSPDDatatable.Rows(1)
                    Dim SpecialistData As DataRow = SpellSlots.GetSPDDatatable.Rows(2)
                    Dim DomainRow, SpecialistRow As Boolean
                    DomainRow = False : SpecialistRow = False

                    'filter out zeros
                    For i As Integer = 0 To 9
                        Dim ElementString As String = "L" & i
                        If SPDData.Item(ElementString).ToString = "0" Then
                            SPDData.Item(ElementString) = ""
                        End If
                    Next

                    'populate row
                    row = data.SpellsPerDay.NewSpellsPerDayRow
                    row.ClassName = CasterLevel.ClassName
                    row.SPD0 = SPDData.Item("L0").ToString
                    row.SPD1 = SPDData.Item("L1").ToString
                    row.SPD2 = SPDData.Item("L2").ToString
                    row.SPD3 = SPDData.Item("L3").ToString
                    row.SPD4 = SPDData.Item("L4").ToString
                    row.SPD5 = SPDData.Item("L5").ToString
                    row.SPD6 = SPDData.Item("L6").ToString
                    row.SPD7 = SPDData.Item("L7").ToString
                    row.SPD8 = SPDData.Item("L8").ToString
                    row.SPD9 = SPDData.Item("L9").ToString
                    data.SpellsPerDay.AddSpellsPerDayRow(row)

                    'check for domain & specialist rows
                    For i As Integer = 0 To 9
                        Dim ElementString As String = "L" & i

                        If CInt(DomianData.Item(ElementString)) > 0 Then
                            DomainRow = True
                        Else
                            DomianData.Item(ElementString) = ""
                        End If

                        If CInt(SpecialistData.Item(ElementString)) > 0 Then
                            SpecialistRow = True
                        Else
                            SpecialistData.Item(ElementString) = ""
                        End If
                    Next

                    If DomainRow Then
                        row = data.SpellsPerDay.NewSpellsPerDayRow
                        row.ClassName = "      Domains"
                        row.SPD0 = DomianData.Item("L0").ToString
                        row.SPD1 = DomianData.Item("L1").ToString
                        row.SPD2 = DomianData.Item("L2").ToString
                        row.SPD3 = DomianData.Item("L3").ToString
                        row.SPD4 = DomianData.Item("L4").ToString
                        row.SPD5 = DomianData.Item("L5").ToString
                        row.SPD6 = DomianData.Item("L6").ToString
                        row.SPD7 = DomianData.Item("L7").ToString
                        row.SPD8 = DomianData.Item("L8").ToString
                        row.SPD9 = DomianData.Item("L9").ToString
                        data.SpellsPerDay.AddSpellsPerDayRow(row)
                    End If

                    If SpecialistRow Then
                        row = data.SpellsPerDay.NewSpellsPerDayRow
                        row.ClassName = "      Specialization"
                        row.SPD0 = SpecialistData.Item("L0").ToString
                        row.SPD1 = SpecialistData.Item("L1").ToString
                        row.SPD2 = SpecialistData.Item("L2").ToString
                        row.SPD3 = SpecialistData.Item("L3").ToString
                        row.SPD4 = SpecialistData.Item("L4").ToString
                        row.SPD5 = SpecialistData.Item("L5").ToString
                        row.SPD6 = SpecialistData.Item("L6").ToString
                        row.SPD7 = SpecialistData.Item("L7").ToString
                        row.SPD8 = SpecialistData.Item("L8").ToString
                        row.SPD9 = SpecialistData.Item("L9").ToString
                        data.SpellsPerDay.AddSpellsPerDayRow(row)
                    End If
                Next

                Return data
            End Get
        End Property

        'spells
        Public ReadOnly Property Spells() As SpellbookDataset
            Get
                Dim data As New SpellbookDataset

                If Character.CurrentLevel.CasterLevels Is Nothing Then Return data

                Dim CasterRow As SpellbookDataset.CasterClassRow
                Dim LevelRow As SpellbookDataset.SpellLevelsRow
                Dim SpellRow As SpellbookDataset.SpellsRow

                'sort caster levels
                Dim CasterLevel As Rules.Character.CasterLevel
                Dim CasterLevels As New SortedList

                For Each Item As DictionaryEntry In Character.CurrentLevel.CasterLevels
                    CasterLevel = CType(Item.Value, Rules.Character.CasterLevel)
                    If CasterLevel.CasterLevel > 0 Then
                        If Character.CharacterClasses(CasterLevel.ClassGuid).IsCaster Then CasterLevels.Add(CasterLevel.ClassName, CasterLevel)
                    End If

                Next

                'schools
                Dim Specialist As New Hashtable
                Dim Prohibited As New Hashtable
                Character.Spells.SpellSchoolTable(Specialist, Prohibited)

                'loop through each caster
                For Each CasterLevel In CasterLevels.GetValueList
                    CasterRow = data.CasterClass.NewCasterClassRow
                    CasterRow.ClassName = CasterLevel.ClassName
                    data.CasterClass.AddCasterClassRow(CasterRow)

                    'get spells
                    Dim CasterClass As New Objects.ObjectData
                    CasterClass.Load(CasterLevel.ClassGuid)

                    Dim SpellsFolder As New Objects.ObjectData

                    'find the spells folder
                    For Each SpellFolder As Objects.ObjectData In Character.CharacterObject.FirstChildOfType(Objects.MagicFolderType).ChildrenOfType(Objects.ClassSpellListFolderType)
                        If SpellFolder.GetFKGuid("Class").Equals(CasterClass.ObjectGUID) Then
                            SpellsFolder = SpellFolder
                            Exit For
                        End If
                    Next

                    'get the classes school info
                    Dim SpecialistSchools, ProhibitedSchools As ArrayList

                    'specialist
                    If Specialist.ContainsKey(CasterLevel.ClassGuid) Then
                        SpecialistSchools = CType(Specialist.Item(CasterLevel.ClassGuid), ArrayList)
                    Else
                        SpecialistSchools = New ArrayList
                    End If

                    'prohibited
                    If Prohibited.ContainsKey(CasterLevel.ClassGuid) Then
                        ProhibitedSchools = CType(Prohibited.Item(CasterLevel.ClassGuid), ArrayList)
                    Else
                        ProhibitedSchools = New ArrayList
                    End If

                    Dim SpellDef As Objects.ObjectData
                    Dim Levels As New ArrayList
                    Dim LevelNo As Integer

                    'spells
                    For Each Spell As Objects.ObjectData In SpellsFolder.ChildrenOfType(Objects.SpellLearnedType)
                        SpellDef = Spell.GetFKObject("Spell")

                        'create the spell level if required
                        LevelNo = Spell.ElementAsInteger("Level")
                        If Not Levels.Contains(LevelNo) Then
                            Levels.Add(LevelNo)
                            LevelRow = data.SpellLevels.NewSpellLevelsRow
                            LevelRow.ClassName = CasterClass.Name
                            LevelRow.SpellLevel = CasterClass.Name.ToUpper & " - Level " & LevelNo.ToString & " Spells"
                            data.SpellLevels.AddSpellLevelsRow(LevelRow)
                        End If

                        'create the spell
                        SpellRow = data.Spells.NewSpellsRow
                        SpellRow.SpellName = SpellDef.Name
                        SpellRow.SpellLevel = CasterClass.Name.ToUpper & " - Level " & LevelNo.ToString & " Spells"
                        SpellRow.ClassName = CasterClass.Name
                        SpellRow.Description = Rules.Formatting.FormatSpellCRS(SpellDef.Element("School"), SpellDef.Element("Subschool"), SpellDef.Element("Descriptors"), SpellDef.Element("Components"), SpellDef.Element("CastingTime"), SpellDef.Element("Range"), SpellDef.Element("TargetAreaEffect"), SpellDef.Element("Duration"), SpellDef.Element("SavingThrow"), SpellDef.Element("SpellResistance"), SpellDef.Element("Description"), SpellDef.Element("ComponentCost"), SpellDef.Element("XPCost"))

                        'get any tags
                        Dim TagString As String = ""

                        'if this is a domain Spell
                        If Spell.GetFKGuid("Source").Database = XML.DBTypes.Domains Then
                            '                            SpellRow.SpellName &= " [Domain]"
                            TagString &= "Domain, "
                        End If

                        If ProhibitedSchools.Contains(SpellDef.Element("School")) Then
                            'SpellRow.SpellName &= " [Prohibited]"
                            TagString &= "Prohibited, "
                        End If

                        If SpecialistSchools.Contains(SpellDef.Element("School")) Then
                            'SpellRow.SpellName &= " [Specialist]"
                            TagString &= "Specialist, "
                        End If

                        If TagString <> "" Then
                            TagString = TagString.TrimEnd(New Char() {","c, " "c})
                            TagString = " [" & TagString & "]"
                            SpellRow.SpellName &= TagString
                        End If

                        data.Spells.AddSpellsRow(SpellRow)
                    Next

                Next

                'sort
                Dim Sorted As New SortedList
                Dim SortedSpells As New ArrayList
                Dim ArrayItem As ArrayItem

                For Each SpellRow In data.Spells
                    ArrayItem = New ArrayItem
                    ArrayItem.Key = SpellRow.Item("SpellName").ToString
                    ArrayItem.Value = SpellRow.ItemArray
                    SortedSpells.Add(ArrayItem)
                Next
                data.Spells.Clear()

                For Each LevelRow In data.SpellLevels
                    Sorted.Add(LevelRow.Item("SpellLevel"), LevelRow.ItemArray)
                Next

                data.SpellLevels.Clear()
                For Each Item As DictionaryEntry In Sorted
                    LevelRow = data.SpellLevels.NewSpellLevelsRow()
                    LevelRow.ItemArray = CType(item.Value, Object())
                    data.SpellLevels.AddSpellLevelsRow(LevelRow)
                Next

                SortedSpells.Sort()
                For Each Item As ArrayItem In SortedSpells
                    SpellRow = data.Spells.NewSpellsRow
                    SpellRow.ItemArray = CType(item.Value, Object())
                    data.Spells.AddSpellsRow(SpellRow)
                Next

                Return data
            End Get
        End Property

        'spells
        Public ReadOnly Property Powers() As SpellbookDataset
            Get
                Dim data As New SpellbookDataset

                If Character.CurrentLevel.CasterLevels Is Nothing Then Return data

                Dim CasterRow As SpellbookDataset.CasterClassRow
                Dim LevelRow As SpellbookDataset.SpellLevelsRow
                Dim PowerRow As SpellbookDataset.SpellsRow

                'sort caster levels
                Dim CasterLevel As Rules.Character.CasterLevel
                Dim CasterLevels As New SortedList

                For Each Item As DictionaryEntry In Character.CurrentLevel.CasterLevels
                    CasterLevel = CType(Item.Value, Rules.Character.CasterLevel)
                    If CasterLevel.CasterLevel > 0 Then
                        If Character.CharacterClasses(CasterLevel.ClassGuid).IsPsionic Then CasterLevels.Add(CasterLevel.ClassName, CasterLevel)
                    End If
                Next

                'loop through each caster
                For Each CasterLevel In CasterLevels.GetValueList
                    CasterRow = data.CasterClass.NewCasterClassRow
                    CasterRow.ClassName = CasterLevel.ClassName
                    data.CasterClass.AddCasterClassRow(CasterRow)

                    'get spells
                    Dim CasterClass As New Objects.ObjectData
                    CasterClass.Load(CasterLevel.ClassGuid)

                    Dim PowersFolder As New Objects.ObjectData

                    'find the spells folder
                    For Each PowerFolder As Objects.ObjectData In Character.CharacterObject.FirstChildOfType(Objects.PsionicFolderType).ChildrenOfType(Objects.ClassPowerListFolderType)
                        If PowerFolder.GetFKGuid("Class").Equals(CasterClass.ObjectGUID) Then
                            PowersFolder = PowerFolder
                            Exit For
                        End If
                    Next

                    Dim PowerDef As Objects.ObjectData
                    Dim Levels As New ArrayList
                    Dim LevelNo As Integer

                    'spells
                    For Each Power As Objects.ObjectData In PowersFolder.ChildrenOfType(Objects.PowerLearnedType)
                        PowerDef = Power.GetFKObject("Power")

                        'create the power level if required
                        LevelNo = Power.ElementAsInteger("Level")
                        If Not Levels.Contains(LevelNo) Then
                            Levels.Add(LevelNo)
                            LevelRow = data.SpellLevels.NewSpellLevelsRow
                            LevelRow.ClassName = CasterClass.Name
                            LevelRow.SpellLevel = CasterClass.Name.ToUpper & " - Level " & LevelNo.ToString & " Powers"
                            data.SpellLevels.AddSpellLevelsRow(LevelRow)
                        End If

                        'create the spell
                        PowerRow = data.Spells.NewSpellsRow
                        PowerRow.SpellName = PowerDef.Name
                        PowerRow.SpellLevel = CasterClass.Name.ToUpper & " - Level " & LevelNo.ToString & " Powers"
                        PowerRow.ClassName = CasterClass.Name
                        PowerRow.Description = Rules.Formatting.FormatPowerCRS(PowerDef.Element("Discipline"), PowerDef.Element("Subdiscipline"), PowerDef.Element("Descriptors"), PowerDef.Element("Display"), PowerDef.Element("CastingTime"), PowerDef.Element("Range"), PowerDef.Element("TargetAreaEffect"), PowerDef.Element("Duration"), PowerDef.Element("SavingThrow"), PowerDef.Element("SpellResistance"), PowerDef.Element("Description"), PowerDef.Element("XPCost"), Rules.PowerList.PowerPoints(LevelNo).ToString, PowerDef.Element("Augment"))

                        'get any tags
                        Dim TagString As String = ""

                        'if this is a domain Spell
                        If Power.GetFKGuid("Source").Database = XML.DBTypes.Domains Then
                            TagString &= "Psionic Specialization, "
                        End If

                        If TagString <> "" Then
                            TagString = TagString.TrimEnd(New Char() {","c, " "c})
                            TagString = " [" & TagString & "]"
                            PowerRow.SpellName &= TagString
                        End If

                        data.Spells.AddSpellsRow(PowerRow)
                    Next
                Next

                'sort
                Dim Sorted As New SortedList
                Dim SortedSpells As New ArrayList
                Dim ArrayItem As ArrayItem

                For Each PowerRow In data.Spells
                    ArrayItem = New ArrayItem
                    ArrayItem.Key = PowerRow.Item("SpellName").ToString
                    ArrayItem.Value = PowerRow.ItemArray
                    SortedSpells.Add(ArrayItem)
                Next
                data.Spells.Clear()

                For Each LevelRow In data.SpellLevels
                    Sorted.Add(LevelRow.Item("SpellLevel"), LevelRow.ItemArray)
                Next

                data.SpellLevels.Clear()
                For Each Item As DictionaryEntry In Sorted
                    LevelRow = data.SpellLevels.NewSpellLevelsRow()
                    LevelRow.ItemArray = CType(item.Value, Object())
                    data.SpellLevels.AddSpellLevelsRow(LevelRow)
                Next

                SortedSpells.Sort()
                For Each Item As ArrayItem In SortedSpells
                    PowerRow = data.Spells.NewSpellsRow
                    PowerRow.ItemArray = CType(item.Value, Object())
                    data.Spells.AddSpellsRow(PowerRow)
                Next

                Return data
            End Get
        End Property

        'data
        Public ReadOnly Property CharacterData() As CharacterDataset
            Get
                Return data
            End Get
        End Property

        'init
        Public Sub Init(ByVal CharObj As Objects.ObjectData, ByVal Input As CharacterDataset)
            Character = CharacterManager.GetCharacter(CharObj.ObjectGUID)
            Inventory = Character.Inventory
            Proficiency = New Rules.Proficiency(Character)
            Proficiency.Calculate()

            General.SetWaitCursor()

            'data = New CharacterDataset
            data = Input
            Dim row As CharacterDataset.CharacterRow
            row = data.Character.NewCharacterRow()

            'core
            row.CharacterName = CharObj.Name
            row.Race = Character.RaceObject.Name
            row.Alignment = CharObj.Element("Alignment")
            row.Classes = Character.ClassesStatBlock
            row.XP = CharObj.ElementAsInteger("XP").ToString

            'effective character level
            row.Level = Character.CharacterLevel.ToString
            Dim ECL As Integer = Character.EffectiveCharacterLevel
            If ECL <> Character.CharacterLevel Then row.Level &= " (" & (ECL).ToString & ")"

            'next level xp
            Dim NextLevelXP As Integer = Character.NextLevelXP
            If NextLevelXP > 0 Then row.NextLevel = NextLevelXP.ToString Else row.NextLevel = "NA"

            row.Size = Character.Size
            row.Space = Character.Space
            row.Reach = Character.Reach
            row.Speed = Rules.Formatting.FormatFeet(Character.Inventory.Speed) & "/x" & Inventory.Run.ToString
            row.BaseSpeedRun = Rules.Formatting.FormatFeet(Character.SpeedBase) & "/x" & Inventory.BaseRun.ToString
            row.Deity = CharObj.Element("Deity")
            row.Description = Character.PhysicalSummary

            'portrait
            Dim Path As String = CharObj.Element("Portrait")
            row.Portrait = ""
            If Path <> "" Then
                If Path.IndexOf(General.BasePath & "Images\Portraits\") = -1 Then
                    If Path.IndexOf(":") = -1 Then
                        'relative path
                        Path = General.BasePath & "Images\Portraits\" & Path
                    End If
                End If
                If IO.File.Exists(Path) Then
                    row.Portrait = Path
                End If
            End If

            'ability scores
            Dim CurrentLevel As Rules.Character.Level = Character.CurrentLevel
            row.STR = CurrentLevel.STR.ToString
            row.STRMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.STR).Modifier)
            row.DEX = CurrentLevel.DEX.ToString
            row.DEXMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.DEX).Modifier)
            row.CON = CurrentLevel.CON.ToString
            row.CONMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.CON).Modifier)
            row.INT = CurrentLevel.INT.ToString
            row.INTMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.INT).Modifier)
            row.WIS = CurrentLevel.WIS.ToString
            row.WISMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.WIS).Modifier)
            row.CHA = CurrentLevel.CHA.ToString
            row.CHAMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.CHA).Modifier)

            'saves
            row.Fortitude = Rules.Formatting.FormatModifier(CurrentLevel.Fortitude)
            row.Reflex = Rules.Formatting.FormatModifier(CurrentLevel.Reflex)
            row.Will = Rules.Formatting.FormatModifier(CurrentLevel.Will)

            'ac
            Dim AC As New Rules.ArmourClass(Inventory)
            row.AC = AC.AC.ToString
            row.ACTouch = AC.TouchAC.ToString
            row.ACFlatfooted = AC.FlatFootedAC.ToString
            row.ACHelpless = AC.HelplessAC.ToString

            Dim MaxDex As String = ""
            If Inventory.ArmorWorn.IsNotEmpty Then
                row.Armor = " " & Inventory.ArmorProperties.Name
                If Inventory.ArmorProperties.MaxDex >= 0 And Inventory.ArmorProperties.MaxDex < 999 Then
                    MaxDex = "Armor Max DEX: " & Rules.Formatting.FormatModifier(Inventory.ArmorProperties.MaxDex + Character.Modifiers.MaxDexFromArmor)
                End If
            Else
                row.Armor = " Not wearing any armor"
            End If

            If Inventory.ShieldWorn.IsNotEmpty Then
                row.Shield = " " & Inventory.ShieldProperties.Name
                If Inventory.ShieldProperties.MaxDex >= 0 And Inventory.ShieldProperties.MaxDex < 999 Then
                    If MaxDex <> "" Then MaxDex &= "; "
                    MaxDex &= "Shield Max DEX: " & Rules.Formatting.FormatModifier(Inventory.ShieldProperties.MaxDex)
                End If
            Else
                row.Shield = " Not carrying a shield"
            End If

            If MaxDex <> "" Then row.ArmorMaxDex = MaxDex

            'resistances
            row.SR = Character.Components.SpellResistance(Character.CharacterLevel).ToString
            row.PR = Character.Components.PowerResistance(Character.CharacterLevel).ToString
            row.Resistances = Character.Components.DamageResistance
            row.DR = Character.Components.DamageReduction

            'hp
            row.HP = Character.HP.ToString
            row.CurrentHP = Character.CharacterObject.Element("CurrentHP")

            'bab, melee, ranged, grapple, initiative
            Dim BAB As ArrayList = Character.GetBaseAttackBonuses
            row.BAB1 = Rules.Formatting.FormatModifier(CType(BAB.Item(0), Integer))
            If BAB.Count >= 2 Then row.BAB2 = Rules.Formatting.FormatModifier(CType(BAB.Item(1), Integer))
            If BAB.Count >= 3 Then row.BAB3 = Rules.Formatting.FormatModifier(CType(BAB.Item(2), Integer))
            If BAB.Count = 4 Then row.BAB4 = Rules.Formatting.FormatModifier(CType(BAB.Item(3), Integer))

            row.Melee = Rules.Formatting.FormatModifier(Character.BABMelee(True))
            row.Ranged = Rules.Formatting.FormatModifier(Character.BABRanged(True))
            row.Grapple = Rules.Formatting.FormatModifier(Character.BABGrapple)
            row.Initiative = Rules.Formatting.FormatModifier(Character.Initiative)

            'skills
            Dim CheckPenalty As String = ""

            'armor check penalty
            If Inventory.ArmorWorn.IsNotEmpty Then
                If Inventory.ArmorProperties.CheckPenalty < 0 Then
                    CheckPenalty = "Armor " & Math.Min(0, Inventory.ArmorProperties.CheckPenalty + Character.Modifiers.CheckPenaltyFromArmor)
                End If
            End If

            'shield check penalty
            If Inventory.ShieldWorn.IsNotEmpty Then
                If Inventory.ShieldProperties.CheckPenalty < 0 Then
                    If CheckPenalty <> "" Then CheckPenalty &= ", "
                    CheckPenalty &= "Shield " & Inventory.ShieldProperties.CheckPenalty.ToString
                End If
            End If

            'encumberance check penalty 
            Dim Effects As Encumberance.CarryingLoad

            If Inventory.Load <> "Light" Then
                Effects = Rules.Encumberance.LoadEffects(Inventory.Load)
                If Effects.CheckPenalty < 0 Then
                    If CheckPenalty <> "" Then CheckPenalty &= ", "
                    CheckPenalty &= "Encumberance " & Effects.CheckPenalty.ToString
                End If
            End If

            If CheckPenalty <> "" Then CheckPenalty = "Check Penalties: " & CheckPenalty
            row.ArmorCheckPenalty = CheckPenalty

            'inventory
            row.Weight = Rules.Formatting.FormatPounds(Inventory.Weight)
            row.Money = Inventory.Money.DisplayString
            Dim LoadInfo As String

            LoadInfo = "Light Load: " & Rules.Encumberance.LightLoad(Character.Size, Inventory.STR, Character.Quadruped)
            LoadInfo &= ", Medium Load: " & Rules.Encumberance.MediumLoad(Character.Size, Inventory.STR, Character.Quadruped)
            LoadInfo &= ", Heavy Load:" & Rules.Encumberance.HeavyLoad(Character.Size, Inventory.STR, Character.Quadruped)
            row.LoadInfo = LoadInfo
            row.CurrentLoad = Inventory.Load

            'load effects
            Dim LoadEffects As Rules.Encumberance.CarryingLoad

            LoadEffects = Rules.Encumberance.LoadEffects("Medium")

            row.MediumLoadMaxDex = Rules.Formatting.FormatModifier(LoadEffects.MaxDex)
            row.MediumLoadCheckPenalty = Rules.Formatting.FormatModifier(LoadEffects.CheckPenalty)
            row.MediumLoadSpeed = Rules.Formatting.FormatFeet(Inventory.CalculateSpeedForLoad("Medium"))
            row.MediumLoadRun = "x" & LoadEffects.RunAdjusted(Inventory.BaseRun).ToString

            LoadEffects = Rules.Encumberance.LoadEffects("Heavy")

            row.HeavyLoadMaxDex = Rules.Formatting.FormatModifier(LoadEffects.MaxDex)
            row.HeavyLoadCheckPenalty = Rules.Formatting.FormatModifier(LoadEffects.CheckPenalty)
            row.HeavyLoadSpeed = Rules.Formatting.FormatFeet(Inventory.CalculateSpeedForLoad("Heavy"))
            row.HeavyLoadRun = "x" & LoadEffects.RunAdjusted(Inventory.BaseRun).ToString

            Dim Money As Money
            Money = Inventory.MoneyAssets
            Money.AddMoney(Inventory.ValueAssets)
            Money = Money.InGold
            row.Assets = Money.DisplayString

            If General.CoinWeight > 0 Then
                row.CoinWeight = "100 Coins = " & General.CoinWeight.ToString & " lb."
            Else
                row.CoinWeight = "Coin Weight OFF"
            End If

            'spell failure
            row.SpellFailureArmor = Rules.Formatting.FormatPercent(Inventory.SpellFailureArmor)
            row.SpellFailureShield = Rules.Formatting.FormatPercent(Inventory.SpellFailureShield)

            'languages
            Dim LanguageObjs As SortedList = Sorter.LoadSortedList(Character.CharacterObject.FirstChildOfType(Objects.LanguageFolderType).Children, SortType.Alphabetic)
            Dim Languages As String = ""
            Dim LanguageObj As Objects.ObjectData

            For Each Item As DictionaryEntry In LanguageObjs
                LanguageObj = CType(Item.Value, Objects.ObjectData)
                If Languages <> "" Then Languages &= ", "
                Languages &= LanguageObj.Name
            Next

            row.Languages = Languages
            row.Notes = Character.CharacterObject.Element("Notes")
            row.Background = Character.CharacterObject.Element("Background")

            data.Character.AddCharacterRow(row)

            'ER WHY?
            'recalc the character
            'Character = New Character
            'Character.Load(CharObj, True)
            'Character.CalculateInventory()
            'Inventory = Character.Inventory
        End Sub

    End Class

End Namespace
