Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class CharacterXMLData

        'this class is responsible for marshalling the data required for the character sheet

#Region "Member Variables"

        Private Character As Rules.Character
        Private Inventory As Rules.Inventory
        Private Proficiency As Rules.Proficiency
        Private data As CharacterXMLDataset
        Private InventoryTemp As ArrayList

        Private CasterClassRows As New Hashtable
        Private ManifesterClassRows As New Hashtable

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

        'data
        Public ReadOnly Property CharacterData() As CharacterXMLDataset
            Get
                Return data
            End Get
        End Property

        'init
        Public Sub Init(ByVal CharObj As Objects.ObjectData, ByVal ProgressBar As ProgressBar)
            ProgressBar.Caption = "Loading Character"
            Character = CharacterManager.GetCharacter(CharObj.ObjectGUID)
            Inventory = Character.Inventory
            Proficiency = New Rules.Proficiency(Character)
            Proficiency.Calculate()

            'get the weapons in sort order - need now to work out progressbar
            Dim WeaponConfigFolder As Objects.ObjectData = Character.CharacterObject.FirstChildOfType(Objects.WeaponConfigFolderType)
            Dim WeaponsListSorted As SortedList = Sorter.LoadSortedList(WeaponConfigFolder.ChildrenOfType(Objects.WeaponConfigType), SortType.NumericSuffix)

            'extend progress bar for each attack config
            ProgressBar.Maximum = 59 + (5 * WeaponsListSorted.Count)

            General.SetWaitCursor()
            data = New CharacterXMLDataset
            Dim row As CharacterXMLDataset.CharacterRow
            row = data.Character.NewCharacterRow
            '''''''''''''''''''''''''''''''''''''''CHARACTER TABLE'''''''''''''''''''''''''''''''
            ProgressBar.Caption = "Generating XML"

            'core
            row.CharacterName = CharObj.Name
            row.PlayerName = CharObj.Element("Player")
            row.Race = Character.RaceObject.Name

            If Character.RaceObject.Element("MonsterType") <> "" Then
                Dim Type, Subtypes As String
                Type = Character.RaceObject.Element("MonsterType")

                If Character.RaceObject.Element("Subtypes") <> "" Then
                    Subtypes = "(" & Character.RaceObject.Element("Subtypes") & ")"
                Else
                    Subtypes = ""
                End If

                row.Type = Type
                row.FullType = Type & Subtypes
            End If

            row.Alignment = CharObj.Element("Alignment")
            row.XP = CharObj.ElementAsInteger("XP").ToString
            ProgressBar.Increment()

            'effective character level
            row.Level = Character.CharacterLevel.ToString
            Dim ECL As Integer = Character.EffectiveCharacterLevel
            If ECL <> Character.CharacterLevel Then row.Level &= " (" & (ECL).ToString & ")"
            ProgressBar.Increment()

            'next level xp
            Dim NextLevelXP As Integer = Character.NextLevelXP
            If NextLevelXP > 0 Then row.NextLevel = NextLevelXP.ToString Else row.NextLevel = "NA"
            ProgressBar.Increment()

            row.Size = Character.Size
            row.Space = Character.Space
            row.Reach = Character.Reach
            row.Speed = Rules.Formatting.FormatFeet(Character.Inventory.Speed)
            If Character.Fly <> "-" Then row.Fly = Character.Fly
            If Character.Swim <> "-" Then row.Swim = Character.Swim
            If Character.Climb <> "-" Then row.Climb = Character.Climb
            If Character.Burrow <> "-" Then row.Burrow = Character.Burrow
            row.RunMultiplier = Inventory.Run.ToString
            row.BaseSpeed = Rules.Formatting.FormatFeet(Character.SpeedBase)
            row.BaseRunMultiplier = Inventory.BaseRun.ToString
            row.Deity = CharObj.Element("Deity")
            ProgressBar.Increment()

            'description
            row.Gender = CharObj.Element("Gender")
            row.Age = CharObj.Element("Age")
            row.Height = Rules.Formatting.FormatFeetandInches(CharObj.ElementAsInteger("Height"))
            row.Weight = Rules.Formatting.FormatPounds(CharObj.ElementAsInteger("Weight"))
            ProgressBar.Increment()

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
            ProgressBar.Increment()

            'ability scores
            Dim CurrentLevel As Rules.Character.Level = Character.CurrentLevel
            row.STR = CurrentLevel.STR.ToString
            If row.STR = "-1" Then row.STR = "-"
            row.STRMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.STR).Modifier)
            row.DEX = CurrentLevel.DEX.ToString
            If row.DEX = "-1" Then row.DEX = "-"
            row.DEXMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.DEX).Modifier)
            row.CON = CurrentLevel.CON.ToString
            If row.CON = "-1" Then row.CON = "-"
            row.CONMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.CON).Modifier)
            row.INT = CurrentLevel.INT.ToString
            If row.INT = "-1" Then row.INT = "-"
            row.INTMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.INT).Modifier)
            row.WIS = CurrentLevel.WIS.ToString
            If row.WIS = "-1" Then row.WIS = "-"
            row.WISMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.WIS).Modifier)
            row.CHA = CurrentLevel.CHA.ToString
            If row.CHA = "-1" Then row.CHA = "-"
            row.CHAMod = Rules.Formatting.FormatModifier(Rules.AbilityScores.AbilityScore(CurrentLevel.CHA).Modifier)
            ProgressBar.Increment()

            'saves
            row.Fortitude = Rules.Formatting.FormatModifier(CurrentLevel.Fortitude)
            If row.Fortitude = "-999" Then row.Fortitude = "-"
            row.Reflex = Rules.Formatting.FormatModifier(CurrentLevel.Reflex)
            If row.Reflex = "-999" Then row.Reflex = "-"
            row.Will = Rules.Formatting.FormatModifier(CurrentLevel.Will)
            ProgressBar.Increment()

            'ac
            Dim AC As New Rules.ArmourClass(Inventory)
            row.AC = AC.AC.ToString
            row.ACTouch = AC.TouchAC.ToString
            row.ACFlatfooted = AC.FlatFootedAC.ToString
            row.ACHelpless = AC.HelplessAC.ToString
            ProgressBar.Increment()

            If Inventory.ArmorWorn.IsNotEmpty Then
                row.Armor = Inventory.ArmorProperties.Name
                If Inventory.ArmorProperties.MaxDex >= 0 And Inventory.ArmorProperties.MaxDex < 999 Then
                    row.ArmorMaxDex = Rules.Formatting.FormatModifier(Inventory.ArmorProperties.MaxDex + Character.Modifiers.MaxDexFromArmor)
                End If
            Else
                row.Armor = "Not wearing any armor"
            End If

            ProgressBar.Increment()

            If Inventory.ShieldWorn.IsNotEmpty Then
                row.Shield = Inventory.ShieldProperties.Name
                If Inventory.ShieldProperties.MaxDex >= 0 And Inventory.ShieldProperties.MaxDex < 999 Then row.ShieldMaxDex = Rules.Formatting.FormatModifier(Inventory.ShieldProperties.MaxDex)
            Else
                row.Shield = "Not carrying a shield"
            End If
            ProgressBar.Increment()

            'spell resistance and damage reduction
            row.SR = Character.Components.SpellResistance(Character.CharacterLevel).ToString
            row.PR = Character.Components.PowerResistance(Character.CharacterLevel).ToString
            row.DR = Character.Components.DamageReduction
            ProgressBar.Increment()

            'hp
            row.HP = Character.HP.ToString
            row.CurrentHP = Character.CharacterObject.Element("CurrentHP")
            ProgressBar.Increment()

            'bab, melee, ranged, grapple, initiative
            Dim BAB As ArrayList = Character.GetBaseAttackBonuses
            row.BAB1 = Rules.Formatting.FormatModifier(CType(BAB.Item(0), Integer))
            If BAB.Count >= 2 Then row.BAB2 = Rules.Formatting.FormatModifier(CType(BAB.Item(1), Integer))
            If BAB.Count >= 3 Then row.BAB3 = Rules.Formatting.FormatModifier(CType(BAB.Item(2), Integer))
            If BAB.Count = 4 Then row.BAB4 = Rules.Formatting.FormatModifier(CType(BAB.Item(3), Integer))
            ProgressBar.Increment()

            row.Melee = Rules.Formatting.FormatModifier(Character.BABMelee(True))
            row.Ranged = Rules.Formatting.FormatModifier(Character.BABRanged(True))
            row.Grapple = Rules.Formatting.FormatModifier(Character.BABGrapple)
            row.Initiative = Rules.Formatting.FormatModifier(Character.Initiative)
            ProgressBar.Increment()

            'skills
            Dim CheckPenalty As String = ""

            'armor check penalty
            If Inventory.ArmorWorn.IsNotEmpty Then
                If Inventory.ArmorProperties.CheckPenalty < 0 Then
                    row.ArmorCheckPenalty = Math.Min(0, Inventory.ArmorProperties.CheckPenalty + Character.Modifiers.CheckPenaltyFromArmor).ToString
                End If
            End If
            ProgressBar.Increment()

            'shield check penalty
            If Inventory.ShieldWorn.IsNotEmpty Then
                If Inventory.ShieldProperties.CheckPenalty < 0 Then
                    row.ShieldCheckPenalty = Inventory.ShieldProperties.CheckPenalty.ToString
                End If
            End If
            ProgressBar.Increment()

            'encumberance check penalty 
            Dim Effects As Encumberance.CarryingLoad
            If Inventory.Load <> "Light" Then
                Effects = Rules.Encumberance.LoadEffects(Inventory.Load)
                If Effects.CheckPenalty < 0 Then
                    row.EncumbranceCheckPenalty = Effects.CheckPenalty.ToString
                End If
            End If
            ProgressBar.Increment()

            'inventory
            row.InventoryWeight = Rules.Formatting.FormatPounds(Inventory.Weight)
            row.Money = Inventory.Money.DisplayString
            ProgressBar.Increment()

            'load
            row.LightLoadInfo = Rules.Encumberance.LightLoad(Character.Size, Inventory.STR, Character.Quadruped)
            row.MediumLoadInfo = Rules.Encumberance.MediumLoad(Character.Size, Inventory.STR, Character.Quadruped)
            row.HeavyLoadInfo = Rules.Encumberance.HeavyLoad(Character.Size, Inventory.STR, Character.Quadruped)
            row.CurrentLoad = Inventory.Load
            ProgressBar.Increment()

            'load effects
            Dim LoadEffects As Rules.Encumberance.CarryingLoad
            LoadEffects = Rules.Encumberance.LoadEffects("Medium")
            row.MediumLoadMaxDex = Rules.Formatting.FormatModifier(LoadEffects.MaxDex)
            row.MediumLoadCheckPenalty = Rules.Formatting.FormatModifier(LoadEffects.CheckPenalty)
            row.MediumLoadSpeed = Rules.Formatting.FormatFeet(Inventory.CalculateSpeedForLoad("Medium"))
            row.MediumLoadRun = "x" & LoadEffects.RunAdjusted(Inventory.BaseRun).ToString
            ProgressBar.Increment()

            LoadEffects = Rules.Encumberance.LoadEffects("Heavy")
            row.HeavyLoadMaxDex = Rules.Formatting.FormatModifier(LoadEffects.MaxDex)
            row.HeavyLoadCheckPenalty = Rules.Formatting.FormatModifier(LoadEffects.CheckPenalty)
            row.HeavyLoadSpeed = Rules.Formatting.FormatFeet(Inventory.CalculateSpeedForLoad("Heavy"))
            row.HeavyLoadRun = "x" & LoadEffects.RunAdjusted(Inventory.BaseRun).ToString
            ProgressBar.Increment()

            'reset character - calculating load effects changes character.components
            Character.Components.CheckConditions_CalculateModifiers(True)

            'assests value
            Dim Money As Money
            Money = Inventory.MoneyAssets
            Money.AddMoney(Inventory.ValueAssets)
            Money = Money.InGold
            row.AssetsValue = Money.DisplayString
            ProgressBar.Increment()

            'coin weight
            If General.CoinWeight > 0 Then
                row.CoinWeight = "100 Coins = " & General.CoinWeight.ToString & " lb."
            Else
                row.CoinWeight = "Coin Weight OFF"
            End If
            ProgressBar.Increment()

            row.SpellFailureArmor = Rules.Formatting.FormatPercent(Inventory.SpellFailureArmor)
            row.SpellFailureShield = Rules.Formatting.FormatPercent(Inventory.SpellFailureShield)
            ProgressBar.Increment()

            row.Notes = Character.CharacterObject.Element("Notes")
            row.Background = Character.CharacterObject.Element("Background")
            data.Character.AddCharacterRow(row)
            ProgressBar.Increment()

            ''''''''''''''''''''''''''''''''''''''CHILD TABLES''''''''''''''''''''''''''''''''''''
            'subtypes
            If Character.RaceObject.Element("Subtypes") <> "" Then
                Dim SubtypeString As String = Character.RaceObject.Element("Subtypes")
                Dim Subtypes As New ArrayList(SubtypeString.Split(",".ToCharArray))

                Dim FinalStrings As New ArrayList
                For Each s As String In Subtypes
                    If s.Trim() <> "" Then
                        FinalStrings.Add(s.Trim)
                    End If
                Next

                If FinalStrings.Count > 0 Then
                    Dim SubtypesRow As CharacterXMLDataset.SubtypesRow = data.Subtypes.NewSubtypesRow
                    SubtypesRow.SetParentRow(row)
                    data.Subtypes.AddSubtypesRow(SubtypesRow)

                    For Each Subtype As String In FinalStrings
                        Dim SubtypeRow As CharacterXMLDataset.SubtypeRow = data.Subtype.NewSubtypeRow
                        SubtypeRow.SetParentRow(SubtypesRow)
                        SubtypeRow.SubtypeName = Subtype
                        data.Subtype.AddSubtypeRow(SubtypeRow)
                    Next
                End If
            End If
            ProgressBar.Increment()


            'languages
            Dim LanguageObjs As SortedList = Sorter.LoadSortedList(Character.CharacterObject.FirstChildOfType(Objects.LanguageFolderType).Children, SortType.Alphabetic)
            If LanguageObjs.Count > 0 Then
                Dim LanguagesRow As CharacterXMLDataset.LanguagesRow = data.Languages.NewLanguagesRow
                LanguagesRow.SetParentRow(row)
                data.Languages.AddLanguagesRow(LanguagesRow)
                For Each Item As DictionaryEntry In LanguageObjs
                    Dim LanguageObj As Objects.ObjectData = CType(Item.Value, Objects.ObjectData)
                    Dim LanguageDef As Objects.ObjectData = LanguageObj.GetFKObject("Language")
                    Dim LanguageRow As CharacterXMLDataset.LanguageRow = data.Language.NewLanguageRow
                    LanguageRow.SetParentRow(LanguagesRow)
                    LanguageRow.LanguageName = LanguageObj.Name
                    If LanguageDef.Element("License") <> "" Then LanguageRow.License = LanguageDef.Element("License")
                    If LanguageDef.Element("Sourcebook") <> "" Then LanguageRow.Sourcebook = LanguageDef.Element("Sourcebook")
                    If LanguageDef.Element("Tags") <> "" Then LanguageRow.Tags = LanguageDef.Element("Tags")
                    If LanguageDef.Element("PageNoRef") <> "" Then LanguageRow.PageNo = LanguageDef.Element("PageNoRef")
                    If LanguageDef.Element("HTML") <> "" Then LanguageRow.HelpPage = General.HelpPath & LanguageDef.Element("HTML")
                    data.Language.AddLanguageRow(LanguageRow)
                Next
            End If
            ProgressBar.Increment()

            'damage resistances
            Dim ResistanceStrings As New ArrayList
            ResistanceStrings.AddRange(SplitDisplayString(Character.Components.DamageResistance))
            If ResistanceStrings.Count > 0 Then
                Dim ResistancesRow As CharacterXMLDataset.ResistancesRow = data.Resistances.NewResistancesRow
                ResistancesRow.SetParentRow(row)
                data.Resistances.AddResistancesRow(ResistancesRow)
                For Each Tempstring As String In ResistanceStrings
                    Dim ResistanceRow As CharacterXMLDataset.ResistanceRow = data.Resistance.NewResistanceRow
                    ResistanceRow.SetParentRow(ResistancesRow)
                    ResistanceRow.ResistanceName = Tempstring
                    data.Resistance.AddResistanceRow(ResistanceRow)
                Next
            End If
            ProgressBar.Increment()

            'classes
            Dim ClassesRow As CharacterXMLDataset.ClassesRow = data.Classes.NewClassesRow
            ClassesRow.SetParentRow(row)
            data.Classes.AddClassesRow(ClassesRow)
            For Each ClassObject As Objects.ObjectData In Character.CharactersClassObjects
                Dim ClassRow As CharacterXMLDataset._ClassRow = data._Class.New_ClassRow
                ClassRow.SetParentRow(ClassesRow)
                ClassRow.ClassName = ClassObject.Name
                ClassRow.ClassLevel = Character.HighestClasslevel(ClassObject.ObjectGUID).ToString
                ClassRow.HitDice = ClassObject.Element("HitDice")
                If ClassObject.Element("License") <> "" Then ClassRow.License = ClassObject.Element("License")
                If ClassObject.Element("Sourcebook") <> "" Then ClassRow.Sourcebook = ClassObject.Element("Sourcebook")
                If ClassObject.Element("Tags") <> "" Then ClassRow.Tags = ClassObject.Element("Tags")
                If ClassObject.Element("PageNoRef") <> "" Then ClassRow.PageNo = ClassObject.Element("PageNoRef")
                If ClassObject.Element("HTML") <> "" Then ClassRow.HelpPage = General.HelpPath & ClassObject.Element("HTML")
                data._Class.Add_ClassRow(ClassRow)
            Next
            ProgressBar.Increment()


            'feats
            Dim Feat As Character.Feat
            Dim FeatsRow As CharacterXMLDataset.FeatsRow = data.Feats.NewFeatsRow
            FeatsRow.SetParentRow(row)
            data.Feats.AddFeatsRow(FeatsRow)

            'sort the feats
            Dim FeatList As New ArrayList
            For Each Item As Library.LibraryData In Character.Feats.ItemData
                Dim ArrayItem As New ArrayItem
                Feat = CType(Item.Data, Character.Feat)
                ArrayItem.Key = Feat.FeatName
                ArrayItem.Value = Feat
                FeatList.Add(ArrayItem)
            Next
            ProgressBar.Increment()

            'prepare for adding feats
            FeatList.Sort()

            'create the XML nodes
            For Each ArrayItem As ArrayItem In FeatList
                Dim FeatRow As CharacterXMLDataset.FeatRow = data.Feat.NewFeatRow
                Dim PrerequisitesMet As Boolean
                Dim FeatDef As Objects.ObjectData
                FeatRow.SetParentRow(FeatsRow)
                Feat = CType(ArrayItem.Value, Character.Feat)
                FeatDef = Caches.Feats.Item(Feat.FeatGuid)
                FeatRow.FeatName = Feat.FeatName
                FeatRow.FocusName = Feat.FocusName
                FeatRow.FeatType = Feat.FeatType
                FeatRow.Disabled = Feat.Disabled.ToString
                FeatRow.IgnoringPrereq = Feat.IgnorePrerequisites.ToString
                FeatRow.Description = FeatDef.Element("Description")
                If Feat.FocusGuid.IsEmpty Then PrerequisitesMet = Character.Components.IsFeatValid(Feat.FeatGuid.ToString) Else PrerequisitesMet = Character.Components.IsFeatValid(Feat.FeatGuid.ToString & Feat.FocusGuid.ToString)
                FeatRow.Valid = PrerequisitesMet.ToString
                If FeatDef.Element("License") <> "" Then FeatRow.License = FeatDef.Element("License")
                If FeatDef.Element("Sourcebook") <> "" Then FeatRow.Sourcebook = FeatDef.Element("Sourcebook")
                If FeatDef.Element("Tags") <> "" Then FeatRow.Tags = FeatDef.Element("Tags")
                If FeatDef.Element("PageNoRef") <> "" Then FeatRow.PageNo = FeatDef.Element("PageNoRef")
                If FeatDef.Element("HTML") <> "" Then FeatRow.HelpPage = General.HelpPath & FeatDef.Element("HTML")
                data.Feat.AddFeatRow(FeatRow)
            Next
            ProgressBar.Increment()

            'features
            Dim FeaturesRow As CharacterXMLDataset.FeaturesRow = data.Features.NewFeaturesRow
            FeaturesRow.SetParentRow(row)
            data.Features.AddFeaturesRow(FeaturesRow)

            Dim FeatureRows As New ArrayList
            Dim Feature As Rules.Feature
            Dim CalcFeature As Rules.CalculatedFeature
            Dim ProgressiveFeatureList As New ArrayList

            'get the normal feature nodes
            For Each Item As Library.LibraryData In Character.Features.Features.ItemData
                Feature = CType(Item.Data, Rules.Feature)
                Dim ArrayItem As ArrayItem
                Dim FeatureDef As Objects.ObjectData = DirectCast(Caches.Features.Item(Feature.FeatureGuid), Objects.ObjectData)

                If Feature.ProgressiveFeature = False Then
                    Dim FeatureRow As CharacterXMLDataset.FeatureRow = data.Feature.NewFeatureRow
                    FeatureRow.SetParentRow(FeaturesRow)
                    FeatureRow.FeatureName = Feature.FeatureName
                    FeatureRow.FeatureType = FeatureDef.Element("FeatureType")
                    FeatureRow.Disabled = Feature.Disabled.ToString
                    FeatureRow.Description = FeatureDef.Element("Description")

                    If Feature.ActualSourceGuid.Equals(RPGXplorer.References.AddedFeatureClass) Then
                        FeatureRow.SourceFlag = "User"
                        FeatureRow.SourceName = Feature.ClassName
                    Else
                        Select Case Feature.ActualSourceGuid.Database
                            Case XML.DBTypes.Classes
                                FeatureRow.SourceFlag = "Class"
                                FeatureRow.SourceName = Feature.ClassName
                            Case XML.DBTypes.MonsterClasses
                                FeatureRow.SourceFlag = "Class"
                                FeatureRow.SourceName = Feature.ClassName
                            Case XML.DBTypes.Races
                                FeatureRow.SourceFlag = "Race"
                                FeatureRow.SourceName = Feature.ActualSourceName
                            Case XML.DBTypes.MonsterRaces
                                FeatureRow.SourceFlag = "Race"
                                FeatureRow.SourceName = Feature.ActualSourceName
                            Case Else
                                'get the source object to determine type
                                Dim TempSourceObj As New Objects.ObjectData
                                TempSourceObj.Load(Feature.ActualSourceGuid)

                                If TempSourceObj.Type = Objects.PsionicSpecializationType Then
                                    FeatureRow.SourceFlag = "Specialization"
                                Else
                                    FeatureRow.SourceFlag = "Domain"
                                End If
                                FeatureRow.SourceName = Feature.ActualSourceName
                        End Select
                    End If

                    If FeatureDef.Element("License") <> "" Then FeatureRow.License = FeatureDef.Element("License")
                    If FeatureDef.Element("Sourcebook") <> "" Then FeatureRow.Sourcebook = FeatureDef.Element("Sourcebook")
                    If FeatureDef.Element("Tags") <> "" Then FeatureRow.Tags = FeatureDef.Element("Tags")
                    If FeatureDef.Element("PageNoRef") <> "" Then FeatureRow.PageNo = FeatureDef.Element("PageNoRef")
                    If FeatureDef.Element("HTML") <> "" Then FeatureRow.HelpPage = General.HelpPath & FeatureDef.Element("HTML")
                    ArrayItem = New ArrayItem
                    ArrayItem.Key = FeatureRow.FeatureName
                    ArrayItem.Value = FeatureRow
                    FeatureRows.Add(ArrayItem)

                Else
                    'store in the progressive feature list
                    ProgressiveFeatureList.Add(Feature)
                End If
            Next
            ProgressBar.Increment()

            'get the calculated feature nodes
            For Each Item As Library.LibraryData In Character.Features.CalculatedFeatures.ItemData
                Dim ArrayItem As ArrayItem
                Dim FeatureRow As CharacterXMLDataset.FeatureRow = data.Feature.NewFeatureRow
                Dim FeatureDef As Objects.ObjectData
                Dim LastlevelUpdated As Integer
                Dim ChainGuid As Objects.ObjectKey

                CalcFeature = CType(Item.Data, Rules.CalculatedFeature)
                FeatureDef = DirectCast(Caches.Features.Item(CalcFeature.FeatureAtLevel(Character.CharacterLevel)), Objects.ObjectData)

                FeatureRow.FeatureName = FeatureDef.Name
                FeatureRow.FeatureType = FeatureDef.Element("FeatureType")
                FeatureRow.Description = FeatureDef.Element("Description")

                'get the last time this feature was taken
                LastlevelUpdated = 1
                For i As Integer = 1 To Character.CharacterLevel
                    If CalcFeature.FeatureAtLevel(i).Equals(FeatureDef.ObjectGUID) Then
                        LastlevelUpdated = i
                        Exit For
                    End If
                Next

                'Get the source information form the feature taken at that level
                ChainGuid = Caches.FeatureChains.ChainGuid(FeatureDef.ObjectGUID)
                For Each TempFeature As Rules.Feature In ProgressiveFeatureList
                    If Caches.FeatureChains.ChainGuid(TempFeature.FeatureGuid).Equals(ChainGuid) And TempFeature.LevelTaken = LastlevelUpdated Then

                        If TempFeature.ActualSourceGuid.Equals(RPGXplorer.References.AddedFeatureClass) Then
                            FeatureRow.SourceFlag = "User"
                            FeatureRow.SourceName = TempFeature.ClassName
                        Else
                            Select Case TempFeature.ActualSourceGuid.Database
                                Case Xml.DBTypes.Classes
                                    FeatureRow.SourceFlag = "Class"
                                    FeatureRow.SourceName = TempFeature.ClassName
                                Case XML.DBTypes.Races
                                    FeatureRow.SourceFlag = "Race"
                                    FeatureRow.SourceName = TempFeature.ActualSourceName
                                Case Else
                                    'get the source object to determine type
                                    Dim TempSourceObj As New Objects.ObjectData
                                    TempSourceObj.Load(TempFeature.ActualSourceGuid)

                                    If TempSourceObj.Type = Objects.PsionicSpecializationType Then
                                        FeatureRow.SourceFlag = "Specialization"
                                    Else
                                        FeatureRow.SourceFlag = "Domain"
                                    End If
                                    FeatureRow.SourceName = TempFeature.ActualSourceName
                            End Select
                        End If
                        Exit For
                    End If
                Next

                If FeatureDef.Element("License") <> "" Then FeatureRow.License = FeatureDef.Element("License")
                If FeatureDef.Element("Sourcebook") <> "" Then FeatureRow.Sourcebook = FeatureDef.Element("Sourcebook")
                If FeatureDef.Element("Tags") <> "" Then FeatureRow.Tags = FeatureDef.Element("Tags")
                If FeatureDef.Element("PageNoRef") <> "" Then FeatureRow.PageNo = FeatureDef.Element("PageNoRef")
                If FeatureDef.Element("HTML") <> "" Then FeatureRow.HelpPage = General.HelpPath & FeatureDef.Element("HTML")

                FeatureRow.SetParentRow(FeaturesRow)
                ArrayItem = New ArrayItem
                ArrayItem.Key = FeatureRow.FeatureName
                ArrayItem.Value = FeatureRow
                FeatureRows.Add(ArrayItem)
            Next
            ProgressBar.Increment()

            'sort the rows
            FeatureRows.Sort()

            'add the feature rows
            For Each ArrayItem As ArrayItem In FeatureRows
                data.Feature.AddFeatureRow(CType(ArrayItem.Value, CharacterXMLDataset.FeatureRow))
            Next
            ProgressBar.Increment()

            'skills
            Dim SkillsRow As CharacterXMLDataset.SkillsRow = data.Skills.NewSkillsRow
            SkillsRow.SetParentRow(row)
            data.Skills.AddSkillsRow(SkillsRow)
            Dim SkillDisplayInfo As ArrayList = Character.Skills.SkillDisplayInfo
            Dim SkillRows As New ArrayList
            ProgressBar.Increment()

            'create the nodes
            For Each SkillInfo As Rules.Skills.SkillInfo In SkillDisplayInfo
                Dim SkillRow As CharacterXMLDataset.SkillRow = data.Skill.NewSkillRow
                Dim ArrayItem As ArrayItem

                SkillRow.SkillName = SkillInfo.SkillName
                SkillRow.SkillRanks = SkillInfo.Ranks.ToString
                SkillRow.TrainedOnly = SkillInfo.TrainedOnly.ToString
                SkillRow.Ability = SkillInfo.Ability
                If SkillInfo.CheckPenaltyMultiplier > 0 Then SkillRow.CheckMultiplier = SkillInfo.CheckPenaltyMultiplier.ToString
                SkillRow.Modifier = SkillInfo.Modifiers.ToString
                SkillRow.Final = SkillInfo.FinalSkillModifier
                If Character.Skills.IsClassSkillAtLevel(SkillInfo.SkillGuid, Character.CharacterLevel) Then
                    SkillRow.ClassSkill = "Yes"
                Else
                    SkillRow.ClassSkill = "No"
                End If
                If SkillInfo.License <> "" Then SkillRow.License = SkillInfo.License
                If SkillInfo.Sourcebook <> "" Then SkillRow.Sourcebook = SkillInfo.Sourcebook
                If SkillInfo.Tags <> "" Then SkillRow.Tags = SkillInfo.Tags
                If SkillInfo.PageNoRef <> "" Then SkillRow.PageNo = SkillInfo.PageNoRef
                If SkillInfo.HelpPage <> "" Then SkillRow.HelpPage = General.HelpPath & SkillInfo.HelpPage

                SkillRow.SetParentRow(SkillsRow)

                'add to collection
                ArrayItem = New ArrayItem
                ArrayItem.Key = SkillRow.SkillName
                ArrayItem.Value = SkillRow
                SkillRows.Add(ArrayItem)
            Next
            ProgressBar.Increment()

            'sort the skills
            SkillRows.Sort()

            'add the skill rows
            For Each ArrayItem As ArrayItem In SkillRows
                data.Skill.AddSkillRow(CType(ArrayItem.Value, CharacterXMLDataset.SkillRow))
            Next

            'spells
            Dim SpellsRow As CharacterXMLDataset.SpellsRow = data.Spells.NewSpellsRow
            SpellsRow.SetParentRow(row)
            data.Spells.AddSpellsRow(SpellsRow)
            ProgressBar.Increment()

            'spellcasterinfo
            Dim SpellCasterInfoRow As CharacterXMLDataset.SpellCasterInfoRow = data.SpellCasterInfo.NewSpellCasterInfoRow
            SpellCasterInfoRow.SetParentRow(row)
            data.SpellCasterInfo.AddSpellCasterInfoRow(SpellCasterInfoRow)

            'sort caster and manifester levels
            Dim CasterLevel As Rules.Character.CasterLevel
            Dim CasterLevels As New SortedList
            Dim ManifesterLevels As New SortedList

            If Character.CurrentLevel.CharacterLevel > 0 Then
                For Each Item As DictionaryEntry In Character.CurrentLevel.CasterLevels
                    CasterLevel = CType(Item.Value, Rules.Character.CasterLevel)
                    If CType(Character.CharacterClasses(CasterLevel.ClassGuid), Rules.CharacterClass).IsCaster Then
                        CasterLevels.Add(CasterLevel.ClassName, CasterLevel)
                    End If

                    If CType(Character.CharacterClasses(CasterLevel.ClassGuid), Rules.CharacterClass).IsPsionic Then
                        ManifesterLevels.Add(CasterLevel.ClassName, CasterLevel)
                    End If
                Next
            End If
            ProgressBar.Increment()

            'load the spell folders
            Dim SpellListFolders As New Hashtable
            Dim SpellSettingFolders As New Hashtable
            Dim SpellLikeAbilityFolder As new Objects.ObjectData
            Dim MemorizedSpellsFolder As New Objects.ObjectData
            Dim MemorizedSpells As New TwoKeyList

            For Each ChildObject As Objects.ObjectData In Character.MagicFolder.Children
                Select Case ChildObject.Type
                    Case Objects.ClassSpellSettingsFolderType
                        SpellSettingFolders.Add(ChildObject.GetFKGuid("Class"), ChildObject)
                    Case Objects.ClassSpellListFolderType
                        SpellListFolders.Add(ChildObject.GetFKGuid("Class"), ChildObject)
                    Case Objects.SpellLikeAbilityFolderType
                        SpellLikeAbilityFolder = ChildObject
                    Case Objects.MemorizedSpellsFolderType
                        MemorizedSpellsFolder = ChildObject
                End Select
            Next
            ProgressBar.Increment()

            'split the memorized spells into class groups
            If MemorizedSpellsFolder.ObjectGUID.IsNotEmpty Then
                For Each MemSpell As Objects.ObjectData In MemorizedSpellsFolder.Children
                    MemorizedSpells.Add(MemSpell.GetFKGuid("Class"), MemSpell.ElementAsInteger("Level"), MemSpell)
                Next
            End If

            'class spells row - class spell per day row
            For Each CasterLevel In CasterLevels.GetValueList

                'caster class row
                Dim CasterClassRow As CharacterXMLDataset.CasterClassRow = data.CasterClass.NewCasterClassRow

                CasterClassRow.SetParentRow(SpellCasterInfoRow)
                CasterClassRow.ClassName = CasterLevel.ClassName
                data.CasterClass.AddCasterClassRow(CasterClassRow)
                CasterClassRows.Add(CasterLevel.ClassGuid, CasterClassRow)

                ''''''CLASS SPELL ROW SECTION
                Dim ClassSpellLevelRows As Hashtable
                ClassSpellLevelRows = New Hashtable

                'get spells
                Dim CasterClass As New Objects.ObjectData
                Dim SpellsFolder As Objects.ObjectData
                Dim SpellSettingsFolder As Objects.ObjectData
                Dim ActualSpellsKnown As Hashtable
                CasterClass.Load(CasterLevel.ClassGuid)

                'get the spell folders
                SpellsFolder = CType(SpellListFolders.Item(CasterLevel.ClassGuid), Objects.ObjectData)
                SpellSettingsFolder = CType(SpellSettingFolders.Item(CasterLevel.ClassGuid), Objects.ObjectData)

                'spell rows
                ActualSpellsKnown = New Hashtable : ClearTable(ActualSpellsKnown)
                For Each Spell As Objects.ObjectData In SpellsFolder.ChildrenOfType(Objects.SpellLearnedType)
                    Dim SpellDef As Objects.ObjectData = Rules.SpellList.SpellDefinition(Spell.GetFKGuid("Spell"))
                    Dim SourceGuid As Objects.ObjectKey = Spell.GetFKGuid("Source")
                    Dim ParentRow As CharacterXMLDataset.ClassSpellsRow

                    'get or make the parent row
                    If ClassSpellLevelRows.Contains(Spell.ElementAsInteger("Level")) Then
                        ParentRow = CType(ClassSpellLevelRows.Item(Spell.ElementAsInteger("Level")), CharacterXMLDataset.ClassSpellsRow)
                    Else
                        ParentRow = data.ClassSpells.NewClassSpellsRow
                        ParentRow.ClassName = CasterClass.Name
                        ParentRow.SpellLevel = Spell.ElementAsInteger("Level").ToString
                        ParentRow.SetParentRow(SpellsRow)
                        data.ClassSpells.AddClassSpellsRow(ParentRow)
                        ClassSpellLevelRows.Add(Spell.ElementAsInteger("Level"), ParentRow)
                    End If

                    Dim SpellRow As CharacterXMLDataset.SpellRow
                    SpellRow = data.Spell.NewSpellRow
                    SpellRow.SetParentRow(ParentRow)
                    SpellRow.SpellName = SpellDef.Name
                    SpellRow.Source = Spell.Element("Source")
                    If SourceGuid.IsNotEmpty Then
                        If SourceGuid.Database = Xml.DBTypes.Domains Then
                            SpellRow.SourceType = "Domain"
                        Else
                            SpellRow.SourceType = "Class"
                        End If
                    End If

                    If SpellDef.Element("SavingThrow") <> "" Then SpellRow.SavingThrow = SpellDef.Element("SavingThrow")
                    If SpellDef.Element("School") <> "" Then SpellRow.School = SpellDef.Element("School")
                    If SpellDef.Element("Subschool") <> "" Then SpellRow.Subschool = SpellDef.Element("Subschool")
                    If SpellDef.Element("SpellResistance") <> "" Then SpellRow.SpellResistance = SpellDef.Element("SpellResistance")
                    If SpellDef.Element("TargetAreaEffect") <> "" Then SpellRow.Target = SpellDef.Element("TargetAreaEffect")
                    If SpellDef.Element("CastingTime") <> "" Then SpellRow.Time = SpellDef.Element("CastingTime")
                    If SpellDef.Element("Range") <> "" Then SpellRow.Range = SpellDef.Element("Range")
                    If SpellDef.Element("Duration") <> "" Then SpellRow.Duration = SpellDef.Element("Duration")
                    If SpellDef.Element("Description") <> "" Then SpellRow.Description = SpellDef.Element("Description")
                    If SpellDef.Element("Descriptors") <> "" Then SpellRow.Descriptors = SpellDef.Element("Descriptors")
                    If SpellDef.Element("Components") <> "" Then SpellRow.Components = SpellDef.Element("Components")
                    If SpellDef.Element("ComponentCost") <> "" Then SpellRow.MaterialCost = SpellDef.Element("ComponentCost")
                    If SpellDef.Element("XPCost") <> "" Then SpellRow.XPCost = SpellDef.Element("XPCost")
                    If SpellDef.Element("License") <> "" Then SpellRow.License = SpellDef.Element("License")
                    If SpellDef.Element("Sourcebook") <> "" Then SpellRow.Sourcebook = SpellDef.Element("Sourcebook")
                    If SpellDef.Element("Tags") <> "" Then SpellRow.Tags = SpellDef.Element("Tags")
                    If SpellDef.Element("PageNoRef") <> "" Then SpellRow.PageNo = SpellDef.Element("PageNoRef")
                    If SpellDef.Element("HTML") <> "" Then SpellRow.HelpPage = General.HelpPath & SpellDef.Element("HTML")
                    data.Spell.AddSpellRow(SpellRow)

                    ActualSpellsKnown.Item(ParentRow.SpellLevel) = CInt(ActualSpellsKnown.Item(ParentRow.SpellLevel)) + 1
                Next

                'spells per day row
                Dim SpellsPerDayRow As CharacterXMLDataset.SpellsPerDayRow = data.SpellsPerDay.NewSpellsPerDayRow
                SpellsPerDayRow.SetParentRow(CasterClassRow)
                data.SpellsPerDay.AddSpellsPerDayRow(SpellsPerDayRow)

                Dim SpellSlots As SpellSlots = New Rules.SpellSlots(Character, CasterLevel.ClassGuid)
                SpellSlots.Load()

                Dim SPDData As DataRow = SpellSlots.GetSPDDatatable.Rows(0)
                Dim DomianData As DataRow = SpellSlots.GetSPDDatatable.Rows(1)
                Dim SpecialistData As DataRow = SpellSlots.GetSPDDatatable.Rows(2)
                Dim DomainRow, SpecialistRow, ClassRow, Spellsknown As Boolean
                DomainRow = False : SpecialistRow = False : ClassRow = False : Spellsknown = False

                'check for class, domain & specialist rows
                For i As Integer = 0 To 9
                    If CInt(SPDData.Item("L" & i.ToString)) > 0 Then ClassRow = True
                    If CInt(DomianData.Item("L" & i.ToString)) > 0 Then DomainRow = True
                    If CInt(SpecialistData.Item("L" & i.ToString)) > 0 Then SpecialistRow = True
                Next
                If ClassSpellLevelRows.Count > 0 Then Spellsknown = True

                'populate the normal class spells per day row
                If ClassRow Then
                    Dim ClassSPDRow As CharacterXMLDataset.ClassSPDRow = data.ClassSPD.NewClassSPDRow
                    ClassSPDRow.SetParentRow(SpellsPerDayRow)
                    ClassSPDRow.SPD0 = SPDData.Item("L0").ToString
                    ClassSPDRow.SPD1 = SPDData.Item("L1").ToString
                    ClassSPDRow.SPD2 = SPDData.Item("L2").ToString
                    ClassSPDRow.SPD3 = SPDData.Item("L3").ToString
                    ClassSPDRow.SPD4 = SPDData.Item("L4").ToString
                    ClassSPDRow.SPD5 = SPDData.Item("L5").ToString
                    ClassSPDRow.SPD6 = SPDData.Item("L6").ToString
                    ClassSPDRow.SPD7 = SPDData.Item("L7").ToString
                    ClassSPDRow.SPD8 = SPDData.Item("L8").ToString
                    ClassSPDRow.SPD9 = SPDData.Item("L9").ToString
                    data.ClassSPD.AddClassSPDRow(ClassSPDRow)
                End If

                If Spellsknown Then
                    Dim SpellsKnownRow As CharacterXMLDataset.SpellsKnownRow = data.SpellsKnown.NewSpellsKnownRow
                    SpellsKnownRow.SetParentRow(CasterClassRow)
                    SpellsKnownRow.SK0 = ActualSpellsKnown.Item("0").ToString
                    SpellsKnownRow.SK1 = ActualSpellsKnown.Item("1").ToString
                    SpellsKnownRow.SK2 = ActualSpellsKnown.Item("2").ToString
                    SpellsKnownRow.SK3 = ActualSpellsKnown.Item("3").ToString
                    SpellsKnownRow.SK4 = ActualSpellsKnown.Item("4").ToString
                    SpellsKnownRow.SK5 = ActualSpellsKnown.Item("5").ToString
                    SpellsKnownRow.SK6 = ActualSpellsKnown.Item("6").ToString
                    SpellsKnownRow.SK7 = ActualSpellsKnown.Item("7").ToString
                    SpellsKnownRow.SK8 = ActualSpellsKnown.Item("8").ToString
                    SpellsKnownRow.SK9 = ActualSpellsKnown.Item("9").ToString
                    data.SpellsKnown.AddSpellsKnownRow(SpellsKnownRow)
                End If

                If DomainRow Then
                    Dim DomainSPDrow As CharacterXMLDataset.DomainSPDRow = data.DomainSPD.NewDomainSPDRow
                    DomainSPDrow.SetParentRow(SpellsPerDayRow)
                    DomainSPDrow.SPD0 = DomianData.Item("L0").ToString
                    DomainSPDrow.SPD1 = DomianData.Item("L1").ToString
                    DomainSPDrow.SPD2 = DomianData.Item("L2").ToString
                    DomainSPDrow.SPD3 = DomianData.Item("L3").ToString
                    DomainSPDrow.SPD4 = DomianData.Item("L4").ToString
                    DomainSPDrow.SPD5 = DomianData.Item("L5").ToString
                    DomainSPDrow.SPD6 = DomianData.Item("L6").ToString
                    DomainSPDrow.SPD7 = DomianData.Item("L7").ToString
                    DomainSPDrow.SPD8 = DomianData.Item("L8").ToString
                    DomainSPDrow.SPD9 = DomianData.Item("L9").ToString
                    data.DomainSPD.AddDomainSPDRow(DomainSPDrow)
                End If

                If SpecialistRow Then
                    Dim SpecialistSPDrow As CharacterXMLDataset.SpecialistSPDRow = data.SpecialistSPD.NewSpecialistSPDRow
                    SpecialistSPDrow.SetParentRow(SpellsPerDayRow)
                    SpecialistSPDrow.SPD0 = SpecialistData.Item("L0").ToString
                    SpecialistSPDrow.SPD1 = SpecialistData.Item("L1").ToString
                    SpecialistSPDrow.SPD2 = SpecialistData.Item("L2").ToString
                    SpecialistSPDrow.SPD3 = SpecialistData.Item("L3").ToString
                    SpecialistSPDrow.SPD4 = SpecialistData.Item("L4").ToString
                    SpecialistSPDrow.SPD5 = SpecialistData.Item("L5").ToString
                    SpecialistSPDrow.SPD6 = SpecialistData.Item("L6").ToString
                    SpecialistSPDrow.SPD7 = SpecialistData.Item("L7").ToString
                    SpecialistSPDrow.SPD8 = SpecialistData.Item("L8").ToString
                    SpecialistSPDrow.SPD9 = SpecialistData.Item("L9").ToString
                    data.SpecialistSPD.AddSpecialistSPDRow(SpecialistSPDrow)
                End If

                'spell DC's
                'get the ability score
                Dim AbilityScore As Integer = Character.Spells.GetSpellAbilityScore(Character.CharacterClasses(CasterLevel.ClassGuid), Character.CharacterLevel)
                Dim AbilityMod As Integer = Rules.AbilityScores.AbilityScore(AbilityScore).Modifier

                Dim SpellDCRow As CharacterXMLDataset.SpellSavesRow = data.SpellSaves.NewSpellSavesRow
                SpellDCRow.SetParentRow(CasterClassRow)
                SpellDCRow.SS0 = (10 + AbilityMod + 0).ToString
                SpellDCRow.SS1 = (10 + AbilityMod + 1).ToString
                SpellDCRow.SS2 = (10 + AbilityMod + 2).ToString
                SpellDCRow.SS3 = (10 + AbilityMod + 3).ToString
                SpellDCRow.SS4 = (10 + AbilityMod + 4).ToString
                SpellDCRow.SS5 = (10 + AbilityMod + 5).ToString
                SpellDCRow.SS6 = (10 + AbilityMod + 6).ToString
                SpellDCRow.SS7 = (10 + AbilityMod + 7).ToString
                SpellDCRow.SS8 = (10 + AbilityMod + 8).ToString
                SpellDCRow.SS9 = (10 + AbilityMod + 9).ToString
                data.SpellSaves.AddSpellSavesRow(SpellDCRow)

                'spell points
                CasterClassRow.SpellPoints = (SpellSlots.SpellPoints + SpellSlots.BonusSpellPoints + SpellSlots.SpellPointsModifier).ToString

                'caster level
                CasterClassRow.CasterLevel = CasterLevel.CasterLevel.ToString

                'caster type
                CasterClassRow.CasterType = CasterClass.Element("SpellAcquisition")

                'spell notes
                CasterClassRow.SpellCasterNotes = SpellSettingsFolder.Element("SpellNotes")

                'memorized spells
                If MemorizedSpells.LowerKeys(CasterClass.ObjectGUID).Count > 0 Then
                    'created a memorized spells row
                    Dim MemorizedSpellList As ArrayList
                    For SpellLevel As Integer = 0 To 9
                        MemorizedSpellList = MemorizedSpells.Item(CasterClass.ObjectGUID, SpellLevel)
                        If MemorizedSpellList.Count > 0 Then

                            Dim MemorizedSpellsRow As CharacterXMLDataset.MemorizedSpellsRow = data.MemorizedSpells.NewMemorizedSpellsRow
                            MemorizedSpellsRow.SetParentRow(CasterClassRow)
                            MemorizedSpellsRow.SlotLevel = SpellLevel.ToString
                            data.MemorizedSpells.AddMemorizedSpellsRow(MemorizedSpellsRow)

                            For Each MemorizedSpellObject As Objects.ObjectData In MemorizedSpellList
                                Dim MemorizedSpellRow As CharacterXMLDataset.MemorizedSpellRow = data.MemorizedSpell.NewMemorizedSpellRow
                                MemorizedSpellRow.SetParentRow(MemorizedSpellsRow)
                                MemorizedSpellRow.SpellName = MemorizedSpellObject.Element("Spell")
                                MemorizedSpellRow.SpellLevel = MemorizedSpellObject.Element("SpellLevel")
                                MemorizedSpellRow.SlotType = MemorizedSpellObject.Element("SlotType")
                                If MemorizedSpellObject.Element("Metamagic") <> "" Then MemorizedSpellRow.MetaTags = MemorizedSpellObject.Element("Metamagic")
                                data.MemorizedSpell.AddMemorizedSpellRow(MemorizedSpellRow)
                            Next

                        End If
                    Next
                End If

            Next
            ProgressBar.Increment()

            'Spell Like Abilities
            Dim SpellLikeAbilities As Objects.ObjectDataCollection = SpellLikeAbilityFolder.Children
            If SpellLikeAbilities.Count > 0 Then

                'make the SpellLikeAbilitiesRow
                Dim SpellLikeAbilitiesRow As CharacterXMLDataset.SpellLikeAbilitiesRow = data.SpellLikeAbilities.NewSpellLikeAbilitiesRow
                SpellLikeAbilitiesRow.SetParentRow(row)
                data.SpellLikeAbilities.AddSpellLikeAbilitiesRow(SpellLikeAbilitiesRow)

                For Each AbilityObj As Objects.ObjectData In SpellLikeAbilities
                    Dim SpellLikeAbilityRow As CharacterXMLDataset.SpellLikeAbilityRow = data.SpellLikeAbility.NewSpellLikeAbilityRow
                    SpellLikeAbilityRow.SetParentRow(SpellLikeAbilitiesRow)
                    SpellLikeAbilityRow.SpellLevel = AbilityObj.Element("SpellLevel")
                    SpellLikeAbilityRow.SpellName = AbilityObj.Element("Spell")
                    SpellLikeAbilityRow.Usage = AbilityObj.Element("Usage")
                    SpellLikeAbilityRow.Notes = AbilityObj.Element("Notes")
                    SpellLikeAbilityRow.DCAbility = AbilityObj.Element("Ability")
                    SpellLikeAbilityRow.ClassName = AbilityObj.Element("Class")
                    SpellLikeAbilityRow.CasterLevel = AbilityObj.Element("CasterLevel")
                    SpellLikeAbilityRow.DC = (10 + AbilityObj.ElementAsInteger("SpellLevel") + Rules.AbilityScores.AbilityScore(Character.AbilityScore(AbilityObj.Element("Ability"))).Modifier).ToString
                    data.SpellLikeAbility.AddSpellLikeAbilityRow(SpellLikeAbilityRow)

                    'do the spell
                    Dim AbilitySpellRow As CharacterXMLDataset.AbilitySpellRow = data.AbilitySpell.NewAbilitySpellRow
                    Dim SpellDef As Objects.ObjectData = Rules.SpellList.SpellDefinition(AbilityObj.GetFKGuid("Spell"))
                    AbilitySpellRow.SetParentRow(SpellLikeAbilityRow)

                    AbilitySpellRow.SpellName = SpellDef.Name
                    If SpellDef.Element("SavingThrow") <> "" Then AbilitySpellRow.SavingThrow = SpellDef.Element("SavingThrow")
                    If SpellDef.Element("School") <> "" Then AbilitySpellRow.School = SpellDef.Element("School")
                    If SpellDef.Element("Subschool") <> "" Then AbilitySpellRow.Subschool = SpellDef.Element("Subschool")
                    If SpellDef.Element("SpellResistance") <> "" Then AbilitySpellRow.SpellResistance = SpellDef.Element("SpellResistance")
                    If SpellDef.Element("TargetAreaEffect") <> "" Then AbilitySpellRow.Target = SpellDef.Element("TargetAreaEffect")
                    If SpellDef.Element("CastingTime") <> "" Then AbilitySpellRow.Time = SpellDef.Element("CastingTime")
                    If SpellDef.Element("Range") <> "" Then AbilitySpellRow.Range = SpellDef.Element("Range")
                    If SpellDef.Element("Duration") <> "" Then AbilitySpellRow.Duration = SpellDef.Element("Duration")
                    If SpellDef.Element("Description") <> "" Then AbilitySpellRow.Description = SpellDef.Element("Description")
                    If SpellDef.Element("Descriptors") <> "" Then AbilitySpellRow.Descriptors = SpellDef.Element("Descriptors")
                    If SpellDef.Element("Components") <> "" Then AbilitySpellRow.Components = SpellDef.Element("Components")
                    If SpellDef.Element("ComponentCost") <> "" Then AbilitySpellRow.MaterialCost = SpellDef.Element("ComponentCost")
                    If SpellDef.Element("XPCost") <> "" Then AbilitySpellRow.XPCost = SpellDef.Element("XPCost")
                    If SpellDef.Element("License") <> "" Then AbilitySpellRow.License = SpellDef.Element("License")
                    If SpellDef.Element("Sourcebook") <> "" Then AbilitySpellRow.Sourcebook = SpellDef.Element("Sourcebook")
                    If SpellDef.Element("Tags") <> "" Then AbilitySpellRow.Tags = SpellDef.Element("Tags")
                    If SpellDef.Element("PageNoRef") <> "" Then AbilitySpellRow.PageNo = SpellDef.Element("PageNoRef")
                    If SpellDef.Element("HTML") <> "" Then AbilitySpellRow.HelpPage = General.HelpPath & SpellDef.Element("HTML")

                    data.AbilitySpell.AddAbilitySpellRow(AbilitySpellRow)
                Next
            End If

            ProgressBar.Increment()
            ''''''''''''''''''''''''''''''''''''''''''''

            'powers
            Dim PowersRow As CharacterXMLDataset.PowersRow = data.Powers.NewPowersRow
            PowersRow.SetParentRow(row)
            data.Powers.AddPowersRow(PowersRow)
            ProgressBar.Increment()

            'manifesterinfo
            Dim PowerPoints As New PowerPoints(Character)
            Dim ManifesterInfoRow As CharacterXMLDataset.ManifesterInfoRow = data.ManifesterInfo.NewManifesterInfoRow
            ManifesterInfoRow.PowerPoints = PowerPoints.PowerPoints.ToString
            ManifesterInfoRow.SetParentRow(row)
            data.ManifesterInfo.AddManifesterInfoRow(ManifesterInfoRow)

            'load the power folders
            Dim PowerListFolders As New Hashtable
            Dim PowerSettingFolders As New Hashtable
            Dim PsiLikeAbilityFolder As New Objects.ObjectData
            For Each ChildObject As Objects.ObjectData In Character.PsionicFolder.Children
                Select Case ChildObject.Type
                    Case Objects.ClassPowerSettingsFolderType
                        PowerSettingFolders.Add(ChildObject.GetFKGuid("Class"), ChildObject)
                    Case Objects.ClassPowerListFolderType
                        PowerListFolders.Add(ChildObject.GetFKGuid("Class"), ChildObject)
                    Case Objects.PsiLikeAbilityFolderType
                        PsiLikeAbilityFolder = ChildObject
                End Select

            Next
            ProgressBar.Increment()

            'class poowers row - class spell per day row
            For Each ManifesterLevel As Rules.Character.CasterLevel In ManifesterLevels.GetValueList

                'manifester class row
                Dim ManifesterClassRow As CharacterXMLDataset.ManifesterClassRow = data.ManifesterClass.NewManifesterClassRow

                ManifesterClassRow.SetParentRow(ManifesterInfoRow)
                ManifesterClassRow.ClassName = ManifesterLevel.ClassName
                data.ManifesterClass.AddManifesterClassRow(ManifesterClassRow)
                ManifesterClassRows.Add(ManifesterLevel.ClassGuid, ManifesterClassRow)

                'CLASS POWER ROW SECTION
                Dim ClassPowerLevelRows As Hashtable
                ClassPowerLevelRows = New Hashtable

                'get Powers
                Dim ManifesterClass As New Objects.ObjectData
                Dim PowersFolder As Objects.ObjectData
                Dim PowerSettingsFolder As Objects.ObjectData

                ManifesterClass.Load(ManifesterLevel.ClassGuid)

                'get the power folders
                PowersFolder = CType(PowerListFolders.Item(ManifesterLevel.ClassGuid), Objects.ObjectData)
                PowerSettingsFolder = CType(PowerSettingFolders.Item(ManifesterLevel.ClassGuid), Objects.ObjectData)

                'power rows
                For Each Power As Objects.ObjectData In PowersFolder.ChildrenOfType(Objects.PowerLearnedType)
                    Dim PowerDef As Objects.ObjectData = PowerList.PowerDefinition(Power.GetFKGuid("Power"))
                    Dim SourceGuid As Objects.ObjectKey = Power.GetFKGuid("Source")
                    Dim ParentRow As CharacterXMLDataset.ClassPowersRow

                    'get or make the parent row
                    If ClassPowerLevelRows.Contains(Power.ElementAsInteger("Level")) Then
                        ParentRow = CType(ClassPowerLevelRows.Item(Power.ElementAsInteger("Level")), CharacterXMLDataset.ClassPowersRow)
                    Else
                        ParentRow = data.ClassPowers.NewClassPowersRow
                        ParentRow.ClassName = ManifesterClass.Name
                        ParentRow.PowerLevel = Power.ElementAsInteger("Level").ToString
                        ParentRow.Points = Rules.PowerList.PowerPoints(Power.ElementAsInteger("Level")).ToString
                        ParentRow.SetParentRow(PowersRow)
                        data.ClassPowers.AddClassPowersRow(ParentRow)
                        ClassPowerLevelRows.Add(Power.ElementAsInteger("Level"), ParentRow)
                    End If

                    Dim PowerRow As CharacterXMLDataset.PowerRow
                    PowerRow = data.Power.NewPowerRow
                    PowerRow.SetParentRow(ParentRow)
                    PowerRow.PowerName = PowerDef.Name
                    PowerRow.Source = Power.Element("Source")
                    If SourceGuid.IsNotEmpty Then
                        If SourceGuid.Database = Xml.DBTypes.Domains Then
                            PowerRow.SourceType = "Specialization"
                        Else
                            PowerRow.SourceType = "Class"
                        End If
                    End If
                    If PowerDef.Element("SavingThrow") <> "" Then PowerRow.SavingThrow = PowerDef.Element("SavingThrow")
                    If PowerDef.Element("Discipline") <> "" Then PowerRow.Discipline = PowerDef.Element("Discipline")
                    If PowerDef.Element("Subdiscipline") <> "" Then PowerRow.Subdiscipline = PowerDef.Element("Subdiscipline")
                    If PowerDef.Element("Descriptors") <> "" Then PowerRow.Descriptors = PowerDef.Element("Descriptors")
                    If PowerDef.Element("Display") <> "" Then PowerRow.Display = PowerDef.Element("Display")
                    If PowerDef.Element("PowerResistance") <> "" Then PowerRow.PowerResistance = PowerDef.Element("PowerResistance")
                    If PowerDef.Element("TargetAreaEffect") <> "" Then PowerRow.Target = PowerDef.Element("TargetAreaEffect")
                    If PowerDef.Element("CastingTime") <> "" Then PowerRow.Time = PowerDef.Element("CastingTime")
                    If PowerDef.Element("Range") <> "" Then PowerRow.Range = PowerDef.Element("Range")
                    If PowerDef.Element("Duration") <> "" Then PowerRow.Duration = PowerDef.Element("Duration")
                    If PowerDef.Element("Description") <> "" Then PowerRow.Description = PowerDef.Element("Description")
                    If PowerDef.Element("XPCost") <> "" Then PowerRow.XPCost = PowerDef.Element("XPCost")
                    If PowerDef.Element("Augment") <> "" Then PowerRow.Augmentable = PowerDef.Element("Augment") Else PowerRow.Augmentable = "False"
                    If PowerDef.Element("License") <> "" Then PowerRow.License = PowerDef.Element("License")
                    If PowerDef.Element("Sourcebook") <> "" Then PowerRow.Sourcebook = PowerDef.Element("Sourcebook")
                    If PowerDef.Element("Tags") <> "" Then PowerRow.Tags = PowerDef.Element("Tags")
                    If PowerDef.Element("PageNoRef") <> "" Then PowerRow.PageNo = PowerDef.Element("PageNoRef")
                    If PowerDef.Element("HTML") <> "" Then PowerRow.HelpPage = General.HelpPath & PowerDef.Element("HTML")

                    data.Power.AddPowerRow(PowerRow)
                Next


                Dim AbilityScore As Integer = Character.Powers.GetPowerAbilityScore(Character.CharacterClasses(ManifesterLevel.ClassGuid), Character.CharacterLevel)
                Dim AbilityMod As Integer = Rules.AbilityScores.AbilityScore(AbilityScore).Modifier

                Dim PowerDCRow As CharacterXMLDataset.PowerSavesRow = data.PowerSaves.NewPowerSavesRow
                PowerDCRow.SetParentRow(ManifesterClassRow)
                PowerDCRow.PS1 = (10 + AbilityMod + 1).ToString
                PowerDCRow.PS2 = (10 + AbilityMod + 2).ToString
                PowerDCRow.PS3 = (10 + AbilityMod + 3).ToString
                PowerDCRow.PS4 = (10 + AbilityMod + 4).ToString
                PowerDCRow.PS5 = (10 + AbilityMod + 5).ToString
                PowerDCRow.PS6 = (10 + AbilityMod + 6).ToString
                PowerDCRow.PS7 = (10 + AbilityMod + 7).ToString
                PowerDCRow.PS8 = (10 + AbilityMod + 8).ToString
                PowerDCRow.PS9 = (10 + AbilityMod + 9).ToString
                data.PowerSaves.AddPowerSavesRow(PowerDCRow)

                'manifester level
                ManifesterClassRow.ManifesterLevel = ManifesterLevel.CasterLevel.ToString

                'spell notes
                ManifesterClassRow.ManifesterNotes = PowerSettingsFolder.Element("PsionicNotes")
            Next
            ProgressBar.Increment()

            'Psi Like Abilities
            Dim PsiLikeAbilities As Objects.ObjectDataCollection = PsiLikeAbilityFolder.Children
            If PsiLikeAbilities.Count > 0 Then

                'make the PsiLikeAbilitiesRow
                Dim PsiLikeAbilitiesRow As CharacterXMLDataset.PsiLikeAbilitiesRow = data.PsiLikeAbilities.NewPsiLikeAbilitiesRow
                PsiLikeAbilitiesRow.SetParentRow(row)
                data.PsiLikeAbilities.AddPsiLikeAbilitiesRow(PsiLikeAbilitiesRow)

                For Each AbilityObj As Objects.ObjectData In PsiLikeAbilities
                    Dim PsiLikeAbilityRow As CharacterXMLDataset.PsiLikeAbilityRow = data.PsiLikeAbility.NewPsiLikeAbilityRow
                    PsiLikeAbilityRow.SetParentRow(PsiLikeAbilitiesRow)
                    PsiLikeAbilityRow.PowerLevel = AbilityObj.Element("PowerLevel")
                    PsiLikeAbilityRow.PowerName = AbilityObj.Element("Power")
                    PsiLikeAbilityRow.Usage = AbilityObj.Element("Usage")
                    PsiLikeAbilityRow.Notes = AbilityObj.Element("Notes")
                    PsiLikeAbilityRow.DCAbility = AbilityObj.Element("Ability")
                    PsiLikeAbilityRow.ClassName = AbilityObj.Element("Class")
                    PsiLikeAbilityRow.ManifesterLevel = AbilityObj.Element("ManifesterLevel")
                    PsiLikeAbilityRow.DC = (10 + AbilityObj.ElementAsInteger("PowerLevel") + Rules.AbilityScores.AbilityScore(Character.AbilityScore(AbilityObj.Element("Ability"))).Modifier).ToString
                    data.PsiLikeAbility.AddPsiLikeAbilityRow(PsiLikeAbilityRow)

                    'do the Psi
                    Dim AbilityPowerRow As CharacterXMLDataset.AbilityPowerRow = data.AbilityPower.NewAbilityPowerRow
                    Dim PowerDef As Objects.ObjectData = Rules.PowerList.PowerDefinition(AbilityObj.GetFKGuid("Power"))
                    AbilityPowerRow.SetParentRow(PsiLikeAbilityRow)

                    AbilityPowerRow.PowerName = PowerDef.Name
                    If PowerDef.Element("SavingThrow") <> "" Then AbilityPowerRow.SavingThrow = PowerDef.Element("SavingThrow")
                    If PowerDef.Element("Discipline") <> "" Then AbilityPowerRow.Discipline = PowerDef.Element("Discipline")
                    If PowerDef.Element("Subdiscipline") <> "" Then AbilityPowerRow.Subdiscipline = PowerDef.Element("Subdiscipline")
                    If PowerDef.Element("Descriptors") <> "" Then AbilityPowerRow.Descriptors = PowerDef.Element("Descriptors")
                    If PowerDef.Element("Display") <> "" Then AbilityPowerRow.Display = PowerDef.Element("Display")
                    If PowerDef.Element("PowerResistance") <> "" Then AbilityPowerRow.PowerResistance = PowerDef.Element("PowerResistance")
                    If PowerDef.Element("TargetAreaEffect") <> "" Then AbilityPowerRow.Target = PowerDef.Element("TargetAreaEffect")
                    If PowerDef.Element("CastingTime") <> "" Then AbilityPowerRow.Time = PowerDef.Element("CastingTime")
                    If PowerDef.Element("Range") <> "" Then AbilityPowerRow.Range = PowerDef.Element("Range")
                    If PowerDef.Element("Duration") <> "" Then AbilityPowerRow.Duration = PowerDef.Element("Duration")
                    If PowerDef.Element("Description") <> "" Then AbilityPowerRow.Description = PowerDef.Element("Description")
                    If PowerDef.Element("XPCost") <> "" Then AbilityPowerRow.XPCost = PowerDef.Element("XPCost")
                    If PowerDef.Element("Augment") <> "" Then AbilityPowerRow.Augmentable = PowerDef.Element("Augment") Else AbilityPowerRow.Augmentable = "False"
                    If PowerDef.Element("License") <> "" Then AbilityPowerRow.License = PowerDef.Element("License")
                    If PowerDef.Element("Sourcebook") <> "" Then AbilityPowerRow.Sourcebook = PowerDef.Element("Sourcebook")
                    If PowerDef.Element("Tags") <> "" Then AbilityPowerRow.Tags = PowerDef.Element("Tags")
                    If PowerDef.Element("PageNoRef") <> "" Then AbilityPowerRow.PageNo = PowerDef.Element("PageNoRef")
                    If PowerDef.Element("HTML") <> "" Then AbilityPowerRow.HelpPage = General.HelpPath & PowerDef.Element("HTML")
                    data.AbilityPower.AddAbilityPowerRow(AbilityPowerRow)
                Next
            End If

            ProgressBar.Increment()


            '''''''''''''''''''''''''''''''''''''''''''''''''''''
            'specializations
            'create specializations row if required
            Dim SpecializationsRow As CharacterXMLDataset.PsionicSpecializationsRow = data.PsionicSpecializations.NewPsionicSpecializationsRow
            If Character.PsionicSpecializations.Count > 0 Then
                SpecializationsRow.SetParentRow(row)
                data.PsionicSpecializations.AddPsionicSpecializationsRow(SpecializationsRow)

                Dim Specialization As PsionicSpecialization
                Dim SpecialObj As Objects.ObjectData
                For Each ItemData As Library.LibraryData In Character.PsionicSpecializations.PsionicSpecializations.ItemData
                    Specialization = CType(ItemData.Data, PsionicSpecialization)
                    SpecialObj = Specialization.SpecializationObj

                    Dim SpecDef As Objects.ObjectData = SpecialObj.GetFKObject("PsionicSpecialization")
                    Dim SpecRow As CharacterXMLDataset.PsionicSpecializationRow = data.PsionicSpecialization.NewPsionicSpecializationRow
                    SpecRow.SetParentRow(SpecializationsRow)
                    SpecRow.PsionicSpecializationName = SpecialObj.Name
                    SpecRow.ClassName = SpecialObj.Element("Class")
                    If SpecDef.Element("License") <> "" Then SpecRow.License = SpecDef.Element("License")
                    If SpecDef.Element("Sourcebook") <> "" Then SpecRow.Sourcebook = SpecDef.Element("Sourcebook")
                    If SpecDef.Element("Tags") <> "" Then SpecRow.Tags = SpecDef.Element("Tags")
                    If SpecDef.Element("PageNoRef") <> "" Then SpecRow.PageNo = SpecDef.Element("PageNoRef")
                    If SpecDef.Element("HTML") <> "" Then SpecRow.HelpPage = General.HelpPath & SpecDef.Element("HTML")
                    data.PsionicSpecialization.AddPsionicSpecializationRow(SpecRow)
                Next
            End If
            ProgressBar.Increment()


            'domains
            Dim Domains As New Hashtable
            Dim List As ArrayList
            Dim Domain As Domain
            For Each ItemData As Library.LibraryData In Character.Domains.Domains.ItemData
                Domain = CType(ItemData.Data, Domain)
                Dim Classkey As Objects.ObjectKey = Domain.DomainObj.GetFKGuid("Class")

                If Not Domains.ContainsKey(Classkey) Then
                    List = New ArrayList
                    Domains.Add(Classkey, List)
                Else
                    List = CType(Domains.Item(Classkey), ArrayList)
                End If
                List.Add(Domain.DomainObj)
            Next

            'create Domains row if required
            Dim DomainsRow As CharacterXMLDataset.DomainsRow = data.Domains.NewDomainsRow
            If Domains.Count > 0 Then
                DomainsRow.SetParentRow(row)
                data.Domains.AddDomainsRow(DomainsRow)
            End If
            ProgressBar.Increment()

            'schools
            Dim Specialist As New Hashtable
            Dim Prohibited As New Hashtable
            Character.Spells.SpellSchoolXMLTable(Specialist, Prohibited)

            'create School rows is required
            Dim SpecialistSchoolsRow As CharacterXMLDataset.SpecialistSchoolsRow = data.SpecialistSchools.NewSpecialistSchoolsRow
            If Specialist.Count > 0 Then
                SpecialistSchoolsRow.SetParentRow(row)
                data.SpecialistSchools.AddSpecialistSchoolsRow(SpecialistSchoolsRow)
            End If

            Dim ProhibitedSchoolsRow As CharacterXMLDataset.ProhibitedSchoolsRow = data.ProhibitedSchools.NewProhibitedSchoolsRow
            If Prohibited.Count > 0 Then
                ProhibitedSchoolsRow.SetParentRow(row)
                data.ProhibitedSchools.AddProhibitedSchoolsRow(ProhibitedSchoolsRow)
            End If
            ProgressBar.Increment()

            'go through all the classes
            Dim SortedClasses As SortedList = Sorter.LoadSortedList(Character.CharactersClassObjects, SortType.Alphabetic)

            For Each ClassObj As Objects.ObjectData In SortedClasses.GetValueList
                Dim Classkey As Objects.ObjectKey = ClassObj.ObjectGUID

                If Domains.ContainsKey(Classkey) Then
                    List = CType(Domains.Item(Classkey), ArrayList)
                    List.Sort()
                    For Each DomainObj As Objects.ObjectData In List
                        Dim DomainDef As Objects.ObjectData = DomainObj.GetFKObject("Domain")
                        Dim DomainRow As CharacterXMLDataset.DomainRow = data.Domain.NewDomainRow
                        DomainRow.SetParentRow(DomainsRow)
                        DomainRow.DomainName = DomainObj.Name
                        DomainRow.Description = DomainDef.Element("Description")
                        DomainRow.ClassName = ClassObj.Name
                        If DomainDef.Element("License") <> "" Then DomainRow.License = DomainDef.Element("License")
                        If DomainDef.Element("Sourcebook") <> "" Then DomainRow.Sourcebook = DomainDef.Element("Sourcebook")
                        If DomainDef.Element("Tags") <> "" Then DomainRow.Tags = DomainDef.Element("Tags")
                        If DomainDef.Element("PageNoRef") <> "" Then DomainRow.PageNo = DomainDef.Element("PageNoRef")
                        If DomainDef.Element("HTML") <> "" Then DomainRow.HelpPage = General.HelpPath & DomainDef.Element("HTML")
                        data.Domain.AddDomainRow(DomainRow)
                    Next
                End If

                If Specialist.ContainsKey(Classkey) Then
                    List = CType(Specialist.Item(Classkey), ArrayList)
                    List.Sort()
                    For Each SpecialistSchool As SpellSchoolXMLData In List
                        Dim SpecialistRow As CharacterXMLDataset.SpecialistSchoolRow = data.SpecialistSchool.NewSpecialistSchoolRow
                        SpecialistRow.SetParentRow(SpecialistSchoolsRow)
                        SpecialistRow.SchoolName = SpecialistSchool.Name
                        SpecialistRow.Description = SpecialistSchool.Description
                        SpecialistRow.ClassName = ClassObj.Name
                        If SpecialistSchool.License <> "" Then SpecialistRow.License = SpecialistSchool.License
                        If SpecialistSchool.Sourcebook <> "" Then SpecialistRow.Sourcebook = SpecialistSchool.Sourcebook
                        If SpecialistSchool.Tags <> "" Then SpecialistRow.Tags = SpecialistSchool.Tags
                        If SpecialistSchool.PageNoRef <> "" Then SpecialistRow.PageNo = SpecialistSchool.PageNoRef
                        If SpecialistSchool.HelpPage <> "" Then SpecialistRow.HelpPage = General.HelpPath & SpecialistSchool.HelpPage
                        data.SpecialistSchool.AddSpecialistSchoolRow(SpecialistRow)
                    Next
                End If

                If Prohibited.ContainsKey(Classkey) Then
                    List = CType(Prohibited.Item(Classkey), ArrayList)
                    List.Sort()
                    For Each ProhibitedSchool As SpellSchoolXMLData In List
                        Dim ProhibitedRow As CharacterXMLDataset.ProhibitedSchoolRow = data.ProhibitedSchool.NewProhibitedSchoolRow
                        ProhibitedRow.SetParentRow(ProhibitedSchoolsRow)
                        ProhibitedRow.SchoolName = ProhibitedSchool.Name
                        ProhibitedRow.Description = ProhibitedSchool.Description
                        ProhibitedRow.ClassName = ClassObj.Name
                        If ProhibitedSchool.License <> "" Then ProhibitedRow.License = ProhibitedSchool.License
                        If ProhibitedSchool.Sourcebook <> "" Then ProhibitedRow.Sourcebook = ProhibitedSchool.Sourcebook
                        If ProhibitedSchool.Tags <> "" Then ProhibitedRow.Tags = ProhibitedSchool.Tags
                        If ProhibitedSchool.PageNoRef <> "" Then ProhibitedRow.PageNo = ProhibitedSchool.PageNoRef
                        If ProhibitedSchool.HelpPage <> "" Then ProhibitedRow.HelpPage = General.HelpPath & ProhibitedSchool.HelpPage
                        data.ProhibitedSchool.AddProhibitedSchoolRow(ProhibitedRow)
                    Next
                End If
            Next
            ProgressBar.Increment()

            'inventory & assests
            Dim InventoryRow As CharacterXMLDataset.InventoryRow = data.Inventory.NewInventoryRow
            InventoryRow.SetParentRow(row)
            data.Inventory.AddInventoryRow(InventoryRow)
            InventoryCalculator(Inventory.InventoryFolder, InventoryRow)
            ProgressBar.Increment()

            ''inventory & assests
            Dim AssetsRow As CharacterXMLDataset.AssetsRow = data.Assets.NewAssetsRow
            AssetsRow.SetParentRow(row)
            data.Assets.AddAssetsRow(AssetsRow)
            Dim AssetsFolder As Objects.ObjectData = Character.CharacterObject.FirstChildOfType(Objects.AssetsFolderType)
            If AssetsFolder.IsNotEmpty Then InventoryCalculator(AssetsFolder, AssetsRow)
            ProgressBar.Increment()

            ''''''''''''''''''''''''''''''''''''''''MODIFIERS'''''''''''''''''''''''''''''''''''''''''
            Dim ModifiersList As New ArrayList
            Dim ModifierDisplay As New RPGXplorer.ModifiersDisplay(Character.Components)
            ModifierDisplay.ProcessAllComponents(False, False, True)

            'core modifiers
            ModifiersList = ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Core)
            If ModifiersList.Count > 0 Then
                Dim CoreModifiers As CharacterXMLDataset.CoreModifiersRow = data.CoreModifiers.NewCoreModifiersRow
                CoreModifiers.SetParentRow(row)
                data.CoreModifiers.AddCoreModifiersRow(CoreModifiers)
                For Each Modifier As ModifiersDisplay.Modifier In ModifiersList
                    Dim ModifierRow As CharacterXMLDataset.CoreModifierRow = data.CoreModifier.NewCoreModifierRow
                    ModifierRow.SetParentRow(CoreModifiers)
                    ModifierRow.ModifierName = Rules.Formatting.ModifierCoreName(Modifier)
                    ModifierRow.ModifierType = Modifier.Type
                    ModifierRow.Source = Modifier.Source
                    ModifierRow.Valid = Modifier.Valid.ToString
                    ModifierRow.Enabled = (Not (Modifier.UserDisabled)).ToString
                    ModifierRow.Condition = Modifier.Limiter
                    ModifierRow.ModifierValue = Modifier.CalculatedValue.ToString
                    ModifierRow.FocusName = Modifier.Focus
                    ModifierRow.SystemElement = Modifier.SystemElementName
                    data.CoreModifier.AddCoreModifierRow(ModifierRow)
                Next
            End If
            ProgressBar.Increment()

            'attack modifers
            ModifiersList = ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Combat)
            If ModifiersList.Count > 0 Then
                Dim AttackModifiersRow As CharacterXMLDataset.AttackModifiersRow = data.AttackModifiers.NewAttackModifiersRow
                AttackModifiersRow.SetParentRow(row)
                data.AttackModifiers.AddAttackModifiersRow(AttackModifiersRow)
                For Each Modifier As ModifiersDisplay.Modifier In ModifiersList
                    Dim ModifierRow As CharacterXMLDataset.AttackModifierRow = data.AttackModifier.NewAttackModifierRow
                    ModifierRow.SetParentRow(AttackModifiersRow)
                    ModifierRow.ModifierName = Rules.Formatting.ModifierCoreName(Modifier)
                    ModifierRow.ModifierType = Modifier.Type
                    ModifierRow.Source = Modifier.Source
                    ModifierRow.Valid = Modifier.Valid.ToString
                    ModifierRow.Enabled = (Not (Modifier.UserDisabled)).ToString
                    ModifierRow.Condition = Modifier.Limiter
                    ModifierRow.ModifierValue = Modifier.CalculatedValue.ToString
                    ModifierRow.FocusName = Modifier.Focus
                    ModifierRow.SystemElement = Modifier.SystemElementName
                    data.AttackModifier.AddAttackModifierRow(ModifierRow)
                Next
            End If
            ProgressBar.Increment()

            'defense modifiers
            ModifiersList = ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Defence)
            If ModifiersList.Count > 0 Then
                Dim DefenseModifiersRow As CharacterXMLDataset.DefenseModifiersRow = data.DefenseModifiers.NewDefenseModifiersRow
                DefenseModifiersRow.SetParentRow(row)
                data.DefenseModifiers.AddDefenseModifiersRow(DefenseModifiersRow)
                For Each Modifier As ModifiersDisplay.Modifier In ModifiersList
                    Dim ModifierRow As CharacterXMLDataset.DefenseModifierRow = data.DefenseModifier.NewDefenseModifierRow
                    ModifierRow.SetParentRow(DefenseModifiersRow)
                    ModifierRow.ModifierName = Rules.Formatting.ModifierCoreName(Modifier)
                    ModifierRow.ModifierType = Modifier.Type
                    ModifierRow.Source = Modifier.Source
                    ModifierRow.Valid = Modifier.Valid.ToString
                    ModifierRow.Enabled = (Not (Modifier.UserDisabled)).ToString
                    ModifierRow.Condition = Modifier.Limiter
                    ModifierRow.ModifierValue = Modifier.CalculatedValue.ToString
                    ModifierRow.FocusName = Modifier.Focus
                    ModifierRow.SystemElement = Modifier.SystemElementName
                    data.DefenseModifier.AddDefenseModifierRow(ModifierRow)
                Next
            End If
            ProgressBar.Increment()

            'skill modifers
            ModifiersList = ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Skills)
            If ModifiersList.Count > 0 Then
                Dim SkillModifiersRow As CharacterXMLDataset.SkillModifiersRow = data.SkillModifiers.NewSkillModifiersRow
                SkillModifiersRow.SetParentRow(row)
                data.SkillModifiers.AddSkillModifiersRow(SkillModifiersRow)
                For Each Modifier As ModifiersDisplay.Modifier In ModifiersList
                    Dim ModifierRow As CharacterXMLDataset.SkillModifierRow = data.SkillModifier.NewSkillModifierRow
                    ModifierRow.SetParentRow(SkillModifiersRow)
                    ModifierRow.ModifierName = Rules.Formatting.ModifierCoreName(Modifier)
                    ModifierRow.ModifierType = Modifier.Type
                    ModifierRow.Source = Modifier.Source
                    ModifierRow.Valid = Modifier.Valid.ToString
                    ModifierRow.Enabled = (Not (Modifier.UserDisabled)).ToString
                    ModifierRow.Condition = Modifier.Limiter
                    ModifierRow.ModifierValue = Modifier.CalculatedValue.ToString
                    ModifierRow.FocusName = Modifier.Focus
                    ModifierRow.SystemElement = Modifier.SystemElementName
                    data.SkillModifier.AddSkillModifierRow(ModifierRow)
                Next
            End If
            ProgressBar.Increment()

            'magic modifers
            ModifiersList = ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Magic)
            If ModifiersList.Count > 0 Then
                Dim magicModifiersRow As CharacterXMLDataset.MagicModifiersRow = data.MagicModifiers.NewMagicModifiersRow
                magicModifiersRow.SetParentRow(row)
                data.MagicModifiers.AddMagicModifiersRow(magicModifiersRow)
                For Each Modifier As ModifiersDisplay.Modifier In ModifiersList
                    Dim ModifierRow As CharacterXMLDataset.MagicModifierRow = data.MagicModifier.NewMagicModifierRow
                    ModifierRow.SetParentRow(magicModifiersRow)
                    ModifierRow.ModifierName = Rules.Formatting.ModifierCoreName(Modifier)
                    ModifierRow.ModifierType = Modifier.Type
                    ModifierRow.Source = Modifier.Source
                    ModifierRow.Valid = Modifier.Valid.ToString
                    ModifierRow.Enabled = (Not (Modifier.UserDisabled)).ToString
                    ModifierRow.Condition = Modifier.Limiter
                    ModifierRow.ModifierValue = Modifier.CalculatedValue.ToString
                    ModifierRow.FocusName = Modifier.Focus
                    ModifierRow.SystemElement = Modifier.SystemElementName
                    data.MagicModifier.AddMagicModifierRow(ModifierRow)
                Next
            End If
            ProgressBar.Increment()

            'psionic modifers
            ModifiersList = ModifierDisplay.GetModifiersByConcept(ModifiersDisplay.DisplayConcept.Psionic)
            If ModifiersList.Count > 0 Then
                Dim psionicModifiersRow As CharacterXMLDataset.PsionicModifiersRow = data.PsionicModifiers.NewPsionicModifiersRow
                psionicModifiersRow.SetParentRow(row)
                data.PsionicModifiers.AddPsionicModifiersRow(psionicModifiersRow)
                For Each Modifier As ModifiersDisplay.Modifier In ModifiersList
                    Dim ModifierRow As CharacterXMLDataset.PsionicModifierRow = data.PsionicModifier.NewPsionicModifierRow
                    ModifierRow.SetParentRow(psionicModifiersRow)
                    ModifierRow.ModifierName = Rules.Formatting.ModifierCoreName(Modifier)
                    ModifierRow.ModifierType = Modifier.Type
                    ModifierRow.Source = Modifier.Source
                    ModifierRow.Valid = Modifier.Valid.ToString
                    ModifierRow.Enabled = (Not (Modifier.UserDisabled)).ToString
                    ModifierRow.Condition = Modifier.Limiter
                    ModifierRow.ModifierValue = Modifier.CalculatedValue.ToString
                    ModifierRow.FocusName = Modifier.Focus
                    ModifierRow.SystemElement = Modifier.SystemElementName
                    data.PsionicModifier.AddPsionicModifierRow(ModifierRow)
                Next
            End If
            ProgressBar.Increment()

            '''''''''''''''''''''''''''''''''''''''ATTACK TABLES'''''''''''''''''''''''''''''''''''''
            'attacks
            Dim AttacksRow As CharacterXMLDataset.AttacksRow = data.Attacks.NewAttacksRow
            AttacksRow.SetParentRow(row)
            data.Attacks.AddAttacksRow(AttacksRow)

            'Dim data As New AttacksDataset
            Dim Attack As New Rules.Attacks
            Attack.Init(Character, Proficiency)
            Dim Baseline As Rules.Components = Character.Components.Clone

            'recalculate without the shield modifiers
            Character.CalculateForWeaponsPanel()
            Dim WeaponBaseline As Rules.Components = Character.Components.Clone

            'init each weapon
            Dim WeaponsObj As Objects.ObjectData
            Dim Weapons As Rules.Weapons
            Dim Attacks As Rules.Attacks

            For Each Item As DictionaryEntry In WeaponsListSorted
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

                'applies the weapon modifer to the character and returns the attacks
                Attacks = Weapons.InitAndGetAttacks

                Dim AttackRow As CharacterXMLDataset.AttackRow = data.Attack.NewAttackRow
                AttackRow.SetParentRow(AttacksRow)
                data.Attack.AddAttackRow(AttackRow)

                'primary
                If Not Weapons.PrimaryWeapon.IsEmpty Then
                    Dim PrimaryRow As CharacterXMLDataset.PrimaryRow = data.Primary.NewPrimaryRow
                    PrimaryRow.SetParentRow(AttackRow)
                    data.Primary.AddPrimaryRow(PrimaryRow)

                    'base info
                    If Weapons.PrimaryWeapon.InventoryItem.IsEmpty Then
                        'if this is a natural weapon?                                    
                        If Weapons.PrimaryWeapon.IsNatural Then
                            If Weapons.PrimaryWeapon.Item.Element("OverrideName") = "True" Then
                                PrimaryRow.BaseName = Weapons.PrimaryWeapon.Item.Name
                            Else
                                PrimaryRow.BaseName = Weapons.PrimaryWeapon.Item.Element("AttackType")
                            End If
                        Else
                            PrimaryRow.BaseName = Weapons.PrimaryWeapon.Item.Name
                        End If
                    Else
                        PrimaryRow.BaseName = Weapons.PrimaryWeapon.InventoryItem.Name
                    End If

                    PrimaryRow.FullName = Weapons.WeaponName(Weapons.PrimaryWeapon)
                    PrimaryRow.Attacks = Rules.Formatting.FormatAttacks(Attacks.Attacks)
                    PrimaryRow.Wield = Weapons.GetWieldString(Weapons.PrimaryWield)
                    PrimaryRow.WeaponType = Weapons.PrimaryWeapon.BaseItem.Element("WeaponType")

                    If Weapons.PrimaryWeapon.Properties.Critical.Threat = 0 Then
                        PrimaryRow.CriticalRange = "-"
                    Else
                        PrimaryRow.CriticalRange = Weapons.PrimaryWeapon.Properties.Critical.Threat.ToString & "-20"
                    End If

                    If Weapons.PrimaryWeapon.Properties.Critical.Multiplier = 0 Then
                        PrimaryRow.CriticalMultiplier = "-"
                    Else
                        PrimaryRow.CriticalMultiplier = Weapons.PrimaryWeapon.Properties.Critical.Multiplier.ToString
                    End If

                    PrimaryRow.BaseDamageType = Weapons.PrimaryWeapon.Properties.DamageType(True)
                    PrimaryRow.BaseDamageLethality = Weapons.PrimaryWeapon.Properties.DamageLethality
                    PrimaryRow.BaseDamage = Weapons.PrimaryWeapon.Properties.BaseDamage
                    If Weapons.PrimaryWeapon.Properties.Enhancement > 0 Then PrimaryRow.Enhancement = Weapons.PrimaryWeapon.Properties.Enhancement.ToString
                    If Weapons.PrimaryWeapon.Properties.Alignment <> "" Then PrimaryRow.Alignment = Weapons.PrimaryWeapon.Properties.Alignment
                    If Weapons.PrimaryWeapon.Properties.Range <> "" Then PrimaryRow.Range = Weapons.PrimaryWeapon.Properties.Range
                    If Weapons.PrimaryWeapon.Properties.Increments > 0 Then PrimaryRow.Increments = Weapons.PrimaryWeapon.Properties.Increments.ToString
                    If Weapons.PrimaryWeapon.Properties.ReachRange <> "" Then PrimaryRow.ReachRange = Weapons.PrimaryWeapon.Properties.ReachRange
                    If Weapons.PrimaryWeapon.IsNatural Then PrimaryRow.IsNatural = "True" Else PrimaryRow.IsNatural = "False"

                    If TypeOf Weapons Is Rules.MonsterWeapons Then
                        If Weapons.PrimaryWeapon.AttackNumber > 1 Then PrimaryRow.AttackNumber = Weapons.PrimaryWeapon.AttackNumber.ToString
                    End If

                    'special abilities / magic abilities
                    Dim StringList As New ArrayList

                    'abilities and special
                    StringList.AddRange(SplitDisplayString(Weapons.PrimaryWeapon.Properties.Abilities))
                    StringList.AddRange(SplitDisplayString(Weapons.PrimaryWeapon.Properties.Special))
                    For Each Tempstring As String In StringList
                        Dim AbilityRow As CharacterXMLDataset.PrimaryAbilityRow = data.PrimaryAbility.NewPrimaryAbilityRow
                        AbilityRow.AbilityName = Tempstring
                        AbilityRow.SetParentRow(PrimaryRow)
                        data.PrimaryAbility.AddPrimaryAbilityRow(AbilityRow)
                    Next

                    'extra Damage
                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.PrimaryWeapon.Properties.DamageAddition))
                    For Each Tempstring As String In StringList
                        Dim ExtraDamageRow As CharacterXMLDataset.PrimaryExtraDamageRow = data.PrimaryExtraDamage.NewPrimaryExtraDamageRow
                        ExtraDamageRow.DamageName = Tempstring
                        ExtraDamageRow.SetParentRow(PrimaryRow)
                        data.PrimaryExtraDamage.AddPrimaryExtraDamageRow(ExtraDamageRow)
                    Next

                    'modifiers
                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.PrimaryWeapon.Properties.ModifierString))
                    For Each Tempstring As String In StringList
                        Dim WeaponModifierRow As CharacterXMLDataset.PrimaryModifierRow = data.PrimaryModifier.NewPrimaryModifierRow
                        WeaponModifierRow.ModifierName = Tempstring
                        WeaponModifierRow.SetParentRow(PrimaryRow)
                        data.PrimaryModifier.AddPrimaryModifierRow(WeaponModifierRow)
                    Next

                    'damage resistance
                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.PrimaryWeapon.Properties.DamageResistances))
                    For Each Tempstring As String In StringList
                        Dim ResistancesRow As CharacterXMLDataset.PrimaryDamageResistanceRow = data.PrimaryDamageResistance.NewPrimaryDamageResistanceRow
                        ResistancesRow.ResistanceName = Tempstring
                        ResistancesRow.SetParentRow(PrimaryRow)
                        data.PrimaryDamageResistance.AddPrimaryDamageResistanceRow(ResistancesRow)
                    Next

                    'conditions
                    For Each WeaponCondition As WeaponProperties In Weapons.PrimaryWeapon.Properties.Conditions
                        Dim ConditionRow As CharacterXMLDataset.PrimaryConditionRow = data.PrimaryCondition.NewPrimaryConditionRow
                        ConditionRow.SetParentRow(PrimaryRow)
                        data.PrimaryCondition.AddPrimaryConditionRow(ConditionRow)

                        'basic condition elements
                        ConditionRow.ConditionName = WeaponCondition.Condition.Name
                        If WeaponCondition.Critical.Threat > Weapons.PrimaryWeapon.Properties.Critical.Threat Then ConditionRow.CriticalRange = WeaponCondition.Critical.Threat.ToString & "-20"
                        If WeaponCondition.Critical.Multiplier > Weapons.PrimaryWeapon.Properties.Critical.Multiplier Then ConditionRow.CriticalMultiplier = WeaponCondition.Critical.Multiplier.ToString
                        If WeaponCondition.BaseDamage <> Weapons.PrimaryWeapon.Properties.BaseDamage Then ConditionRow.BaseDamage = WeaponCondition.BaseDamage
                        If WeaponCondition.Enhancement > Weapons.PrimaryWeapon.Properties.Enhancement Then ConditionRow.Enhancement = WeaponCondition.Enhancement.ToString

                        'conditional abilities and special
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.Abilities))
                        StringList.AddRange(SplitDisplayString(WeaponCondition.Special))
                        For Each Tempstring As String In StringList
                            Dim AbilityRow As CharacterXMLDataset.PrimaryConditionalAbilityRow = data.PrimaryConditionalAbility.NewPrimaryConditionalAbilityRow
                            AbilityRow.AbilityName = Tempstring
                            AbilityRow.SetParentRow(ConditionRow)
                            data.PrimaryConditionalAbility.AddPrimaryConditionalAbilityRow(AbilityRow)
                        Next

                        'conditional extra Damage
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.DamageAddition))
                        For Each Tempstring As String In StringList
                            Dim ExtraDamageRow As CharacterXMLDataset.PrimaryConditionalExtraDamageRow = data.PrimaryConditionalExtraDamage.NewPrimaryConditionalExtraDamageRow
                            ExtraDamageRow.DamageName = Tempstring
                            ExtraDamageRow.SetParentRow(ConditionRow)
                            data.PrimaryConditionalExtraDamage.AddPrimaryConditionalExtraDamageRow(ExtraDamageRow)
                        Next

                        'conditional modifiers
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.ModifierString))
                        For Each Tempstring As String In StringList
                            Dim WeaponModifierRow As CharacterXMLDataset.PrimaryConditionalModifierRow = data.PrimaryConditionalModifier.NewPrimaryConditionalModifierRow
                            WeaponModifierRow.ModifierName = Tempstring
                            WeaponModifierRow.SetParentRow(ConditionRow)
                            data.PrimaryConditionalModifier.AddPrimaryConditionalModifierRow(WeaponModifierRow)
                        Next

                        'conditional damage resistance
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.DamageResistances))
                        For Each Tempstring As String In StringList
                            Dim ResistancesRow As CharacterXMLDataset.PrimaryConditionalDamageResistanceRow = data.PrimaryConditionalDamageResistance.NewPrimaryConditionalDamageResistanceRow
                            ResistancesRow.ResistanceName = Tempstring
                            ResistancesRow.SetParentRow(ConditionRow)
                            data.PrimaryConditionalDamageResistance.AddPrimaryConditionalDamageResistanceRow(ResistancesRow)
                        Next
                    Next
                End If

                'secondary
                If Not Weapons.OffHandItem.IsEmpty Then
                    Dim SecondaryRow As CharacterXMLDataset.SecondaryRow = data.Secondary.NewSecondaryRow
                    SecondaryRow.SetParentRow(AttackRow)
                    data.Secondary.AddSecondaryRow(SecondaryRow)

                    'base info
                    If Weapons.OffHandItem.InventoryItem.IsEmpty Then
                        SecondaryRow.BaseName = Weapons.OffHandItem.Item.Name
                    Else
                        SecondaryRow.BaseName = Weapons.OffHandItem.InventoryItem.Name
                    End If
                    SecondaryRow.FullName = Weapons.WeaponName(Weapons.OffHandItem)
                    If Weapons.OffHandWield <> Weapons.Wield.Shield Then SecondaryRow.Wield = Weapons.GetWieldString(Weapons.OffHandWield)

                    If Weapons.OffHandWield <> Weapons.Wield.Shield Then
                        SecondaryRow.WeaponType = Weapons.OffHandItem.BaseItem.Element("WeaponType")
                        SecondaryRow.Attacks = Rules.Formatting.FormatAttacks(Attacks.OffHandAttacks)

                        If Weapons.OffHandItem.Properties.Critical.Threat = 0 Then
                            SecondaryRow.CriticalRange = "-"
                        Else
                            SecondaryRow.CriticalRange = Weapons.OffHandItem.Properties.Critical.Threat.ToString & "-20"
                        End If

                        If Weapons.OffHandItem.Properties.Critical.Multiplier = 0 Then
                            SecondaryRow.CriticalMultiplier = "-"
                        Else
                            SecondaryRow.CriticalMultiplier = Weapons.OffHandItem.Properties.Critical.Multiplier.ToString
                        End If

                        SecondaryRow.BaseDamageType = Weapons.OffHandItem.Properties.DamageType(True)
                        SecondaryRow.BaseDamageLethality = Weapons.OffHandItem.Properties.DamageLethality
                        SecondaryRow.BaseDamage = Weapons.OffHandItem.Properties.BaseDamage
                    End If


                    If Weapons.OffHandItem.Properties.Enhancement > 0 Then SecondaryRow.Enhancement = Weapons.OffHandItem.Properties.Enhancement.ToString
                    If Weapons.OffHandItem.Properties.Alignment <> "" Then SecondaryRow.Alignment = Weapons.OffHandItem.Properties.Alignment
                    If Weapons.OffHandItem.Properties.Range <> "" Then SecondaryRow.Range = Weapons.OffHandItem.Properties.Range
                    If Weapons.OffHandItem.Properties.Increments > 0 Then SecondaryRow.Increments = Weapons.OffHandItem.Properties.Increments.ToString
                    If Weapons.OffHandItem.Properties.ReachRange <> "" Then SecondaryRow.ReachRange = Weapons.OffHandItem.Properties.ReachRange
                    If Weapons.OffHandItem.IsNatural Then SecondaryRow.IsNatural = "True" Else SecondaryRow.IsNatural = "False"

                    'special abilities / magic abilities
                    Dim StringList As New ArrayList

                    'abilities and special
                    StringList.AddRange(SplitDisplayString(Weapons.OffHandItem.Properties.Abilities))
                    StringList.AddRange(SplitDisplayString(Weapons.OffHandItem.Properties.Special))
                    For Each Tempstring As String In StringList
                        Dim AbilityRow As CharacterXMLDataset.SecondaryAbilityRow = data.SecondaryAbility.NewSecondaryAbilityRow
                        AbilityRow.AbilityName = Tempstring
                        AbilityRow.SetParentRow(SecondaryRow)
                        data.SecondaryAbility.AddSecondaryAbilityRow(AbilityRow)
                    Next

                    'extra Damage
                    If Weapons.OffHandWield <> Weapons.Wield.Shield Then
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(Weapons.OffHandItem.Properties.DamageAddition))
                        For Each Tempstring As String In StringList
                            Dim ExtraDamageRow As CharacterXMLDataset.SecondaryExtraDamageRow = data.SecondaryExtraDamage.NewSecondaryExtraDamageRow
                            ExtraDamageRow.DamageName = Tempstring
                            ExtraDamageRow.SetParentRow(SecondaryRow)
                            data.SecondaryExtraDamage.AddSecondaryExtraDamageRow(ExtraDamageRow)
                        Next
                    End If

                    'modifiers
                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.OffHandItem.Properties.ModifierString))
                    For Each Tempstring As String In StringList
                        Dim WeaponModifierRow As CharacterXMLDataset.SecondaryModifierRow = data.SecondaryModifier.NewSecondaryModifierRow
                        WeaponModifierRow.ModifierName = Tempstring
                        WeaponModifierRow.SetParentRow(SecondaryRow)
                        data.SecondaryModifier.AddSecondaryModifierRow(WeaponModifierRow)
                    Next

                    'damage resistance
                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.OffHandItem.Properties.DamageResistances))
                    For Each Tempstring As String In StringList
                        Dim ResistancesRow As CharacterXMLDataset.SecondaryDamageResistanceRow = data.SecondaryDamageResistance.NewSecondaryDamageResistanceRow
                        ResistancesRow.ResistanceName = Tempstring
                        ResistancesRow.SetParentRow(SecondaryRow)
                        data.SecondaryDamageResistance.AddSecondaryDamageResistanceRow(ResistancesRow)
                    Next

                    'conditions
                    For Each WeaponCondition As WeaponProperties In Weapons.OffHandItem.Properties.Conditions
                        Dim ConditionRow As CharacterXMLDataset.SecondaryConditionRow = data.SecondaryCondition.NewSecondaryConditionRow
                        ConditionRow.SetParentRow(SecondaryRow)
                        data.SecondaryCondition.AddSecondaryConditionRow(ConditionRow)

                        'basic condition elements
                        ConditionRow.ConditionName = WeaponCondition.Condition.Name
                        If WeaponCondition.Critical.Threat > Weapons.OffHandItem.Properties.Critical.Threat Then ConditionRow.CriticalRange = WeaponCondition.Critical.Threat.ToString & "-20"
                        If WeaponCondition.Critical.Multiplier > Weapons.OffHandItem.Properties.Critical.Multiplier Then ConditionRow.CriticalMultiplier = WeaponCondition.Critical.Multiplier.ToString
                        If WeaponCondition.BaseDamage <> Weapons.OffHandItem.Properties.BaseDamage Then ConditionRow.BaseDamage = WeaponCondition.BaseDamage
                        If WeaponCondition.Enhancement > Weapons.OffHandItem.Properties.Enhancement Then ConditionRow.Enhancement = WeaponCondition.Enhancement.ToString

                        'conditional abilities and special
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.Abilities))
                        StringList.AddRange(SplitDisplayString(WeaponCondition.Special))
                        For Each Tempstring As String In StringList
                            Dim AbilityRow As CharacterXMLDataset.SecondaryConditionalAbilityRow = data.SecondaryConditionalAbility.NewSecondaryConditionalAbilityRow
                            AbilityRow.AbilityName = Tempstring
                            AbilityRow.SetParentRow(ConditionRow)
                            data.SecondaryConditionalAbility.AddSecondaryConditionalAbilityRow(AbilityRow)
                        Next

                        'conditional extra Damage
                        If Weapons.OffHandWield <> Weapons.Wield.Shield Then
                            StringList.Clear()
                            StringList.AddRange(SplitDisplayString(WeaponCondition.DamageAddition))
                            For Each Tempstring As String In StringList
                                Dim ExtraDamageRow As CharacterXMLDataset.SecondaryConditionalExtraDamageRow = data.SecondaryConditionalExtraDamage.NewSecondaryConditionalExtraDamageRow
                                ExtraDamageRow.DamageName = Tempstring
                                ExtraDamageRow.SetParentRow(ConditionRow)
                                data.SecondaryConditionalExtraDamage.AddSecondaryConditionalExtraDamageRow(ExtraDamageRow)
                            Next
                        End If

                        'conditional modifiers
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.ModifierString))
                        For Each Tempstring As String In StringList
                            Dim WeaponModifierRow As CharacterXMLDataset.SecondaryConditionalModifierRow = data.SecondaryConditionalModifier.NewSecondaryConditionalModifierRow
                            WeaponModifierRow.ModifierName = Tempstring
                            WeaponModifierRow.SetParentRow(ConditionRow)
                            data.SecondaryConditionalModifier.AddSecondaryConditionalModifierRow(WeaponModifierRow)
                        Next

                        'conditional damage resistance
                        StringList.Clear()
                        StringList.AddRange(SplitDisplayString(WeaponCondition.DamageResistances))
                        For Each Tempstring As String In StringList
                            Dim ResistancesRow As CharacterXMLDataset.SecondaryConditionalDamageResistanceRow = data.SecondaryConditionalDamageResistance.NewSecondaryConditionalDamageResistanceRow
                            ResistancesRow.ResistanceName = Tempstring
                            ResistancesRow.SetParentRow(ConditionRow)
                            data.SecondaryConditionalDamageResistance.AddSecondaryConditionalDamageResistanceRow(ResistancesRow)
                        Next
                    Next
                End If

                'new monster off-hands
                If TypeOf Weapons Is Rules.MonsterWeapons Then
                    Dim MonsterWeapons As Rules.MonsterWeapons = CType(Weapons, Rules.MonsterWeapons)
                    For i As Integer = 1 To MonsterWeapons.OffHandCount

                        If Not MonsterWeapons.OffHandItem(i).IsEmpty Then
                            Dim SecondaryRow As CharacterXMLDataset.SecondaryRow = data.Secondary.NewSecondaryRow
                            SecondaryRow.SetParentRow(AttackRow)
                            data.Secondary.AddSecondaryRow(SecondaryRow)

                            'base info
                            If MonsterWeapons.OffHandItem(i).InventoryItem.IsEmpty Then
                                'if this is a natural weapon?                                    
                                If MonsterWeapons.OffHandItem(i).IsNatural Then

                                    If MonsterWeapons.OffHandItem(i).Item.Element("OverrideName") = "True" Then
                                        SecondaryRow.BaseName = MonsterWeapons.OffHandItem(i).Item.Name
                                    Else
                                        SecondaryRow.BaseName = MonsterWeapons.OffHandItem(i).Item.Element("AttackType")
                                    End If

                                Else
                                    SecondaryRow.BaseName = MonsterWeapons.OffHandItem(i).Item.Name
                                End If
                            Else
                                SecondaryRow.BaseName = MonsterWeapons.OffHandItem(i).InventoryItem.Name
                            End If

                            SecondaryRow.FullName = MonsterWeapons.WeaponName(MonsterWeapons.OffHandItem(i))

                            If MonsterWeapons.OffHandWield(i) <> Weapons.Wield.Shield Then SecondaryRow.Wield = Weapons.GetWieldString(MonsterWeapons.OffHandWield(i))
                            If MonsterWeapons.OffHandWield(i) <> Weapons.Wield.Shield Then
                                SecondaryRow.WeaponType = MonsterWeapons.OffHandItem(i).BaseItem.Element("WeaponType")
                                SecondaryRow.Attacks = Rules.Formatting.FormatAttacks(Attacks.OffHandAttacks(i))

                                If MonsterWeapons.OffHandItem(i).Properties.Critical.Threat = 0 Then
                                    SecondaryRow.CriticalRange = "-"
                                Else
                                    SecondaryRow.CriticalRange = MonsterWeapons.OffHandItem(i).Properties.Critical.Threat.ToString & "-20"
                                End If

                                If MonsterWeapons.OffHandItem(i).Properties.Critical.Multiplier = 0 Then
                                    SecondaryRow.CriticalMultiplier = "-"
                                Else
                                    SecondaryRow.CriticalMultiplier = MonsterWeapons.OffHandItem(i).Properties.Critical.Multiplier.ToString
                                End If

                                SecondaryRow.BaseDamageType = MonsterWeapons.OffHandItem(i).Properties.DamageType(True)
                                SecondaryRow.BaseDamageLethality = MonsterWeapons.OffHandItem(i).Properties.DamageLethality
                                SecondaryRow.BaseDamage = MonsterWeapons.OffHandItem(i).Properties.BaseDamage
                            End If
                            If MonsterWeapons.OffHandItem(i).Properties.Enhancement > 0 Then SecondaryRow.Enhancement = MonsterWeapons.OffHandItem(i).Properties.Enhancement.ToString
                            If MonsterWeapons.OffHandItem(i).Properties.Alignment <> "" Then SecondaryRow.Alignment = MonsterWeapons.OffHandItem(i).Properties.Alignment
                            If MonsterWeapons.OffHandItem(i).Properties.Range <> "" Then SecondaryRow.Range = MonsterWeapons.OffHandItem(i).Properties.Range
                            If MonsterWeapons.OffHandItem(i).Properties.Increments > 0 Then SecondaryRow.Increments = MonsterWeapons.OffHandItem(i).Properties.Increments.ToString
                            If MonsterWeapons.OffHandItem(i).Properties.ReachRange <> "" Then SecondaryRow.ReachRange = MonsterWeapons.OffHandItem(i).Properties.ReachRange
                            If MonsterWeapons.OffHandItem(i).IsNatural Then SecondaryRow.IsNatural = "True" Else SecondaryRow.IsNatural = "False"

                            'new attack number element
                            If MonsterWeapons.OffHandItem(i).AttackNumber > 1 Then SecondaryRow.AttackNumber = MonsterWeapons.OffHandItem(i).AttackNumber.ToString

                            'special abilities / magic abilities
                            Dim StringList As New ArrayList

                            'abilities and special
                            StringList.AddRange(SplitDisplayString(MonsterWeapons.OffHandItem(i).Properties.Abilities))
                            StringList.AddRange(SplitDisplayString(MonsterWeapons.OffHandItem(i).Properties.Special))
                            For Each Tempstring As String In StringList
                                Dim AbilityRow As CharacterXMLDataset.SecondaryAbilityRow = data.SecondaryAbility.NewSecondaryAbilityRow
                                AbilityRow.AbilityName = Tempstring
                                AbilityRow.SetParentRow(SecondaryRow)
                                data.SecondaryAbility.AddSecondaryAbilityRow(AbilityRow)
                            Next

                            'extra Damage
                            If MonsterWeapons.OffHandWield(i) <> Weapons.Wield.Shield Then
                                StringList.Clear()
                                StringList.AddRange(SplitDisplayString(MonsterWeapons.OffHandItem(i).Properties.DamageAddition))
                                For Each Tempstring As String In StringList
                                    Dim ExtraDamageRow As CharacterXMLDataset.SecondaryExtraDamageRow = data.SecondaryExtraDamage.NewSecondaryExtraDamageRow
                                    ExtraDamageRow.DamageName = Tempstring
                                    ExtraDamageRow.SetParentRow(SecondaryRow)
                                    data.SecondaryExtraDamage.AddSecondaryExtraDamageRow(ExtraDamageRow)
                                Next
                            End If

                            'modifiers
                            StringList.Clear()
                            StringList.AddRange(SplitDisplayString(MonsterWeapons.OffHandItem(i).Properties.ModifierString))
                            For Each Tempstring As String In StringList
                                Dim WeaponModifierRow As CharacterXMLDataset.SecondaryModifierRow = data.SecondaryModifier.NewSecondaryModifierRow
                                WeaponModifierRow.ModifierName = Tempstring
                                WeaponModifierRow.SetParentRow(SecondaryRow)
                                data.SecondaryModifier.AddSecondaryModifierRow(WeaponModifierRow)
                            Next

                            'damage resistance
                            StringList.Clear()
                            StringList.AddRange(SplitDisplayString(MonsterWeapons.OffHandItem(i).Properties.DamageResistances))
                            For Each Tempstring As String In StringList
                                Dim ResistancesRow As CharacterXMLDataset.SecondaryDamageResistanceRow = data.SecondaryDamageResistance.NewSecondaryDamageResistanceRow
                                ResistancesRow.ResistanceName = Tempstring
                                ResistancesRow.SetParentRow(SecondaryRow)
                                data.SecondaryDamageResistance.AddSecondaryDamageResistanceRow(ResistancesRow)
                            Next

                            'conditions
                            For Each WeaponCondition As WeaponProperties In MonsterWeapons.OffHandItem(i).Properties.Conditions
                                Dim ConditionRow As CharacterXMLDataset.SecondaryConditionRow = data.SecondaryCondition.NewSecondaryConditionRow
                                ConditionRow.SetParentRow(SecondaryRow)
                                data.SecondaryCondition.AddSecondaryConditionRow(ConditionRow)

                                'basic condition elements
                                ConditionRow.ConditionName = WeaponCondition.Condition.Name
                                If WeaponCondition.Critical.Threat > MonsterWeapons.OffHandItem(i).Properties.Critical.Threat Then ConditionRow.CriticalRange = WeaponCondition.Critical.Threat.ToString & "-20"
                                If WeaponCondition.Critical.Multiplier > MonsterWeapons.OffHandItem(i).Properties.Critical.Multiplier Then ConditionRow.CriticalMultiplier = WeaponCondition.Critical.Multiplier.ToString
                                If WeaponCondition.BaseDamage <> MonsterWeapons.OffHandItem(i).Properties.BaseDamage Then ConditionRow.BaseDamage = WeaponCondition.BaseDamage
                                If WeaponCondition.Enhancement > MonsterWeapons.OffHandItem(i).Properties.Enhancement Then ConditionRow.Enhancement = WeaponCondition.Enhancement.ToString

                                'conditional abilities and special
                                StringList.Clear()
                                StringList.AddRange(SplitDisplayString(WeaponCondition.Abilities))
                                StringList.AddRange(SplitDisplayString(WeaponCondition.Special))
                                For Each Tempstring As String In StringList
                                    Dim AbilityRow As CharacterXMLDataset.SecondaryConditionalAbilityRow = data.SecondaryConditionalAbility.NewSecondaryConditionalAbilityRow
                                    AbilityRow.AbilityName = Tempstring
                                    AbilityRow.SetParentRow(ConditionRow)
                                    data.SecondaryConditionalAbility.AddSecondaryConditionalAbilityRow(AbilityRow)
                                Next

                                'conditional extra Damage
                                If MonsterWeapons.OffHandWield(i) <> Weapons.Wield.Shield Then
                                    StringList.Clear()
                                    StringList.AddRange(SplitDisplayString(WeaponCondition.DamageAddition))
                                    For Each Tempstring As String In StringList
                                        Dim ExtraDamageRow As CharacterXMLDataset.SecondaryConditionalExtraDamageRow = data.SecondaryConditionalExtraDamage.NewSecondaryConditionalExtraDamageRow
                                        ExtraDamageRow.DamageName = Tempstring
                                        ExtraDamageRow.SetParentRow(ConditionRow)
                                        data.SecondaryConditionalExtraDamage.AddSecondaryConditionalExtraDamageRow(ExtraDamageRow)
                                    Next
                                End If

                                'conditional modifiers
                                StringList.Clear()
                                StringList.AddRange(SplitDisplayString(WeaponCondition.ModifierString))
                                For Each Tempstring As String In StringList
                                    Dim WeaponModifierRow As CharacterXMLDataset.SecondaryConditionalModifierRow = data.SecondaryConditionalModifier.NewSecondaryConditionalModifierRow
                                    WeaponModifierRow.ModifierName = Tempstring
                                    WeaponModifierRow.SetParentRow(ConditionRow)
                                    data.SecondaryConditionalModifier.AddSecondaryConditionalModifierRow(WeaponModifierRow)
                                Next

                                'conditional damage resistance
                                StringList.Clear()
                                StringList.AddRange(SplitDisplayString(WeaponCondition.DamageResistances))
                                For Each Tempstring As String In StringList
                                    Dim ResistancesRow As CharacterXMLDataset.SecondaryConditionalDamageResistanceRow = data.SecondaryConditionalDamageResistance.NewSecondaryConditionalDamageResistanceRow
                                    ResistancesRow.ResistanceName = Tempstring
                                    ResistancesRow.SetParentRow(ConditionRow)
                                    data.SecondaryConditionalDamageResistance.AddSecondaryConditionalDamageResistanceRow(ResistancesRow)
                                Next
                            Next
                        End If

                    Next
                End If

                'buckler
                If Weapons.BucklerWielded Then
                    Dim BucklerRow As CharacterXMLDataset.BucklerRow = data.Buckler.NewBucklerRow
                    BucklerRow.SetParentRow(AttackRow)
                    data.Buckler.AddBucklerRow(BucklerRow)

                    'base info
                    If Weapons.Buckler.InventoryItem.IsEmpty Then
                        BucklerRow.BaseName = Weapons.Buckler.Item.Name
                    Else
                        BucklerRow.BaseName = Weapons.Buckler.InventoryItem.Name
                    End If
                    BucklerRow.FullName = Weapons.WeaponName(Weapons.Buckler)
                    If Weapons.Buckler.Properties.Enhancement > 0 Then BucklerRow.Enhancement = Weapons.Buckler.Properties.Enhancement.ToString

                    'special abilities / magic abilities
                    Dim StringList As New ArrayList

                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.Buckler.Properties.Abilities))
                    StringList.AddRange(SplitDisplayString(Weapons.Buckler.Properties.Special))
                    For Each Tempstring As String In StringList
                        Dim AbilityRow As CharacterXMLDataset.BucklerAbilityRow = data.BucklerAbility.NewBucklerAbilityRow
                        AbilityRow.AbilityName = Tempstring
                        AbilityRow.SetParentRow(BucklerRow)
                        data.BucklerAbility.AddBucklerAbilityRow(AbilityRow)
                    Next

                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.Buckler.Properties.ModifierString))
                    For Each Tempstring As String In StringList
                        Dim ResistancesRow As CharacterXMLDataset.BucklerDamageResistanceRow = data.BucklerDamageResistance.NewBucklerDamageResistanceRow
                        ResistancesRow.ResistanceName = Tempstring
                        ResistancesRow.SetParentRow(BucklerRow)
                        data.BucklerDamageResistance.AddBucklerDamageResistanceRow(ResistancesRow)
                    Next

                    StringList.Clear()
                    StringList.AddRange(SplitDisplayString(Weapons.Buckler.Properties.DamageResistances))
                    For Each Tempstring As String In StringList
                        Dim ResistancesRow As CharacterXMLDataset.BucklerDamageResistanceRow = data.BucklerDamageResistance.NewBucklerDamageResistanceRow
                        ResistancesRow.ResistanceName = Tempstring
                        ResistancesRow.SetParentRow(BucklerRow)
                        data.BucklerDamageResistance.AddBucklerDamageResistanceRow(ResistancesRow)
                    Next
                End If
                ProgressBar.Increment(5)
            Next

            'reset character to the previous state
            Character.Components = Baseline
            Character.Modifiers.Calculate(True)

            '''''''''''''''''''''''''''''''''''''''''''''''''Nebular

            'Armor Bonuses

            'get the armor modifer tables
            Dim Armor, MonkArmor As Hashtable
            Armor = Character.Modifiers.GetModifiersByType(References.ArmourClass, Objects.ObjectKey.Empty, 1000)
            MonkArmor = Character.Modifiers.GetModifiersByType(References.ArmorClassMonk, Objects.ObjectKey.Empty, 1000)

            Dim ArmorRow As CharacterXMLDataset.ArmorClassRow = data.ArmorClass.NewArmorClassRow
            ArmorRow.SetParentRow(row)
            For Each ModiferType As String In Rules.Lists.ModifierTypes
                ArmorRow.DexBonus = Character.Inventory.DEXModAC.ToString

                Select Case ModiferType
                    Case "Alchemical"
                        ArmorRow.AlchemicalBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Armor"
                        ArmorRow.ArmorBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Circumstance"
                        ArmorRow.CircumstanceBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Competence"
                        ArmorRow.CompetenceBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Deflection"
                        ArmorRow.DeflectionBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Dodge"
                        ArmorRow.DodgeBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Enhancement"
                        ArmorRow.EnhancementBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Inherent"
                        ArmorRow.InherentBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Insight"
                        ArmorRow.InsightBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Luck"
                        ArmorRow.LuckBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Morale"
                        ArmorRow.MoraleBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Natural Armor"
                        ArmorRow.NaturalArmorBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Profane"
                        ArmorRow.ProfaneBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Racial"
                        ArmorRow.RacialBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Resistance"
                        ArmorRow.ResistanceBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Sacred"
                        ArmorRow.SacredBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Shield"
                        ArmorRow.ShieldBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Size"
                        ArmorRow.SizeBonus = (Size.Size(Character.Size).Modifier + CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                    Case "Undefined"
                        ArmorRow.UndefinedBonus = (CInt(Armor.Item(ModiferType)) + CInt(MonkArmor.Item(ModiferType))).ToString
                End Select
            Next
            data.ArmorClass.AddArmorClassRow(ArmorRow)

            'saving throws
            AddSavingThrows(row)

            'ability scores
            AddAbilityScores(row)

            ProgressBar.Increment()
            General.SetNormalCursor()
        End Sub

#Region "Row Constructors"

        'adds the saving throw rows to the dataset
        Private Sub AddSavingThrows(ByVal ParentRow As DataRow)
            Try
                'get global save modifiers
                Dim GlobalMagicMod, GlobalMiscMod As Integer

                'gets the magic and misc values - returned ByRef
                CalcualteMagicAndMiscModifiers(References.SavingThrow, GlobalMagicMod, GlobalMiscMod)

                'add the savingthrows row to the dataset
                Dim SavingThrowsRow As CharacterXMLDataset.SavingThrowsRow = data.SavingThrows.NewSavingThrowsRow
                SavingThrowsRow.SetParentRow(ParentRow)
                data.SavingThrows.AddSavingThrowsRow(SavingThrowsRow)

                'create saving throw rows
                CreateSavingThrowRow(References.FortitudeSavingThrow, "Fortitude", GlobalMiscMod, GlobalMagicMod, SavingThrowsRow)
                CreateSavingThrowRow(References.ReflexSavingThrow, "Reflex", GlobalMiscMod, GlobalMagicMod, SavingThrowsRow)
                CreateSavingThrowRow(References.WillSavingThrow, "Will", GlobalMiscMod, GlobalMagicMod, SavingThrowsRow)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'create a single saving throw row
        Private Sub CreateSavingThrowRow(ByVal SystemElement As Objects.ObjectKey, ByVal Name As String, ByVal GlobalMiscMod As Integer, ByVal GlobalMagicMod As Integer, ByVal ParentRow As DataRow)

            'get global save modifiers
            Dim Magic, Misc As Integer
            Dim AbilityModifier As Integer

            'gets the magic and misc values - returned ByRef
            CalcualteMagicAndMiscModifiers(SystemElement, Magic, Misc)

            Dim SavingRow As CharacterXMLDataset.SavingThrowRow = data.SavingThrow.NewSavingThrowRow
            SavingRow.SetParentRow(ParentRow)
            SavingRow.Name = Name
            SavingRow.MiscSave = (Misc + GlobalMiscMod).ToString
            SavingRow.MagicSave = (Magic + GlobalMagicMod).ToString

            Select Case Name
                Case "Fortitude"
                    SavingRow.BaseSave = Character.CurrentLevel.FortitudeBase.ToString
                    SavingRow.AbilityModifier = Rules.AbilityScores.AbilityScore(Character.AbilityScore("CON")).Modifier.ToString
                Case "Reflex"
                    SavingRow.BaseSave = Character.CurrentLevel.ReflexBase.ToString

                    'check for system ability
                    AbilityModifier = -999
                    If Character.Components.SystemAbilities(References.IntelligenceReflexSave) Then
                        AbilityModifier = AbilityScores.AbilityScore(Character.AbilityScore("INT")).Modifier
                    End If
                    AbilityModifier = Math.Max(AbilityScores.AbilityScore(Character.AbilityScore("DEX")).Modifier, AbilityModifier)

                    SavingRow.AbilityModifier = AbilityModifier.ToString

                Case "Will"
                    SavingRow.BaseSave = Character.CurrentLevel.WillBase.ToString

                    'check for system ability
                    AbilityModifier = -999
                    If Character.Components.SystemAbilities(References.CharismaWillSave) Then
                        AbilityModifier = AbilityScores.AbilityScore(Character.AbilityScore("CHA")).Modifier
                    End If
                    AbilityModifier = Math.Max(AbilityScores.AbilityScore(Character.AbilityScore("WIS")).Modifier, AbilityModifier)

                    SavingRow.AbilityModifier = AbilityModifier.ToString

            End Select

            data.SavingThrow.AddSavingThrowRow(SavingRow)

        End Sub

        'adds ths ability score rows to the dataset
        Private Sub AddAbilityScores(ByVal ParentRow As DataRow)
            Try

                Dim MagicMod, MiscMod As Integer
                Dim AbilityScoresRow As CharacterXMLDataset.AbilityScoresRow = data.AbilityScores.NewAbilityScoresRow
                AbilityScoresRow.SetParentRow(ParentRow)
                data.AbilityScores.AddAbilityScoresRow(AbilityScoresRow)

                For Each Ability As String In Rules.AbilityScores.Abilities
                    Dim AbilityScoreRow As CharacterXMLDataset.AbilityScoreRow = data.AbilityScore.NewAbilityScoreRow
                    AbilityScoreRow.SetParentRow(AbilityScoresRow)
                    AbilityScoreRow.Name = Ability

                    Select Case Ability
                        Case "STR"
                            AbilityScoreRow.BaseScore = Character.CurrentLevel.STR(True).ToString
                            AbilityScoreRow.RacialMod = Character.RaceObject.ElementAsInteger("STRModifier").ToString
                            CalcualteMagicAndMiscModifiers(References.Strength, MagicMod, MiscMod)

                        Case "DEX"
                            AbilityScoreRow.BaseScore = Character.CurrentLevel.DEX(True).ToString
                            AbilityScoreRow.RacialMod = Character.RaceObject.ElementAsInteger("DEXModifier").ToString
                            CalcualteMagicAndMiscModifiers(References.Dexterity, MagicMod, MiscMod)

                        Case "WIS"
                            AbilityScoreRow.BaseScore = Character.CurrentLevel.WIS(True).ToString
                            AbilityScoreRow.RacialMod = Character.RaceObject.ElementAsInteger("WISModifier").ToString
                            CalcualteMagicAndMiscModifiers(References.Wisdom, MagicMod, MiscMod)

                        Case "CON"
                            AbilityScoreRow.BaseScore = Character.CurrentLevel.CON(True).ToString
                            AbilityScoreRow.RacialMod = Character.RaceObject.ElementAsInteger("CONModifier").ToString
                            CalcualteMagicAndMiscModifiers(References.Constitution, MagicMod, MiscMod)

                        Case "INT"
                            AbilityScoreRow.BaseScore = Character.CurrentLevel.INT(True).ToString
                            AbilityScoreRow.RacialMod = Character.RaceObject.ElementAsInteger("INTModifier").ToString
                            CalcualteMagicAndMiscModifiers(References.Intelligence, MagicMod, MiscMod)

                        Case "CHA"
                            AbilityScoreRow.BaseScore = Character.CurrentLevel.CHA(True).ToString
                            AbilityScoreRow.RacialMod = Character.RaceObject.ElementAsInteger("CHAModifier").ToString
                            CalcualteMagicAndMiscModifiers(References.Charisma, MagicMod, MiscMod)
                    End Select

                    AbilityScoreRow.MagicMod = MagicMod.ToString
                    AbilityScoreRow.MiscMod = MiscMod.ToString
                    data.AbilityScore.AddAbilityScoreRow(AbilityScoreRow)
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'recursive Inventory checker
        Private Function InventoryCalculator(ByVal Item As Objects.ObjectData, ByVal ParentRow As DataRow) As Double
            Try
                'make my item 
                If Not (Item.Type = Objects.InventoryFolderType Or Item.Type = Objects.AssetsFolderType Or Item.Type = Objects.ScrollSpellType) Then
                    Dim Name As String = ""
                    Dim BaseType As String = ""
                    Dim Quantity As String = ""
                    Dim ItemWeight As String = ""
                    Dim Charges As String = ""
                    Dim Itemcost As String = ""
                    Dim ItemCategory As String = ""
                    Dim Active As String = ""
                    Dim Notes As String = ""
                    Dim ItemKey As String = ""
                    Dim ContainerKey As String = ""
                    Dim ContainerName As String = ""
                    Dim ContentsWeight As String = ""
                    Dim License As String = ""
                    Dim Sourcebook As String = ""
                    Dim Tags As String = ""
                    Dim PageNoRef As String = ""
                    Dim HelpPage As String = ""
                    Dim ChildWeight As Double = 0

                    Name = Item.Name
                    ItemKey = Item.ObjectGUID.ToString
                    ContainerKey = Item.ParentGUID.ToString
                    ContainerName = Item.Parent.Name
                    Quantity = Item.Element("Quantity")
                    ItemWeight = Item.Element("Weight")
                    If Item.ElementAsInteger("Charges") > 0 Then Charges = Item.Element("Charges")
                    If Item.Element("Cost") <> "" Then Itemcost = Item.Element("Cost") Else Itemcost = "0 gp"
                    If Item.Element("Active") <> "" Then Active = Item.Element("Active")
                    If Item.Element("Notes") <> "" Then Notes = Item.Element("Notes")
                    If Item.Element("ItemType") <> "" Then BaseType = Item.Element("ItemType")

                    'tags
                    Dim ItemDef As Objects.ObjectData = Item.GetFKObject("Item")
                    If ItemDef.Element("ItemType") <> "" Then ItemCategory = ItemDef.Element("ItemType")
                    If ItemDef.Element("License") <> "" Then License = ItemDef.Element("License")
                    If ItemDef.Element("Sourcebook") <> "" Then Sourcebook = ItemDef.Element("Sourcebook")
                    If ItemDef.Element("Tags") <> "" Then Tags = ItemDef.Element("Tags")
                    If ItemDef.Element("PageNoRef") <> "" Then PageNoRef = ItemDef.Element("PageNoRef")
                    If ItemDef.Element("HTML") <> "" Then HelpPage = General.HelpPath & ItemDef.Element("HTML")

                    For Each child As Objects.ObjectData In Item.Children
                        ChildWeight += InventoryCalculator(child, ParentRow)
                    Next

                    If ChildWeight <> 0 Then ContentsWeight = ChildWeight.ToString & " lb." Else 

                    If TypeOf ParentRow Is CharacterXMLDataset.InventoryRow Then
                        data.InventoryItem.AddInventoryItemRow(Name, ItemKey, BaseType, ItemWeight, ContentsWeight, Itemcost, ItemCategory, Quantity, Charges, Active, Notes, ContainerName, ContainerKey, License, Sourcebook, Tags, PageNoRef, HelpPage, CType(ParentRow, CharacterXMLDataset.InventoryRow))
                    Else
                        data.AssetItem.AddAssetItemRow(Name, ItemKey, BaseType, ItemWeight, ContentsWeight, Itemcost, ItemCategory, Quantity, Charges, Active, Notes, ContainerName, ContainerKey, License, Sourcebook, Tags, PageNoRef, HelpPage, CType(ParentRow, CharacterXMLDataset.AssetsRow))
                    End If

                    If Item.Element("Weight") <> "" Then ChildWeight += CType(Item.Element("Weight").Replace(" lb.", ""), Double)

                    Return ChildWeight
                Else
                    For Each child As Objects.ObjectData In Item.Children
                        InventoryCalculator(child, ParentRow)
                    Next
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

#Region "Helper Functions/Routines"

        'magic and misc values are returned by reference
        Private Sub CalcualteMagicAndMiscModifiers(ByVal SystemElement As Objects.ObjectKey, ByRef Magic As Integer, ByRef Misc As Integer)
            Try

                Dim ModifierComponent As Components.ComponentData
                Dim ModifierDefinition As New Objects.ObjectData

                Magic = 0
                Misc = 0

                For Each Item As Library.LibraryData In Character.Components.Modifiers.ItemData(SystemElement)
                    ModifierComponent = CType(Item.Data, Rules.Components.ComponentData)
                    'valid check
                    If ModifierComponent.ValidInfo.Valid AndAlso (Not ModifierComponent.UserModifierDisabled) Then
                        If ModifierComponent.TransientObject.ObjectGUID.IsNotEmpty Then
                            ModifierDefinition = ModifierComponent.TransientObject
                        Else
                            ModifierDefinition.Load(ModifierComponent.Key)
                        End If
                        If ModifierDefinition.Element("Limiter") = "" Then
                            Select Case ModifierComponent.SourceKey.Database
                                Case XML.DBTypes.ArmorMagicAbilities, XML.DBTypes.WeaponMagicAbilities, XML.DBTypes.WondrousItems, XML.DBTypes.Artifacts, XML.DBTypes.Rings, XML.DBTypes.Rods, XML.DBTypes.Staffs
                                    Magic += ModifierCalculator(ModifierDefinition)
                                Case Else
                                    Misc += ModifierCalculator(ModifierDefinition)
                            End Select
                        End If
                    End If
                Next

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'calculates the value of a modifier
        Private Function ModifierCalculator(ByVal Modifier As Objects.ObjectData) As Integer
            Try
                Dim ModifierNumber As Integer

                'get the modifier
                Select Case Modifier.Element("ModifierCategory")
                    Case "Normal Modifier"
                        ModifierNumber = Modifier.ElementAsInteger("Modifier")

                    Case "Use Ability Modifier", "Use Ability Modifier (positive only)", "Use Ability Modifier (+1 minimum)"
                        ModifierNumber = Rules.AbilityScores.AbilityScore(Character.CurrentLevel.AbilityScore(Modifier.Element("Modifier"))).Modifier

                        If Modifier.Element("ModifierCategory") = "Use Ability Modifier (positive only)" AndAlso ModifierNumber < 0 Then
                            ModifierNumber = 0
                        ElseIf Modifier.Element("ModifierCategory") = "Use Ability Modifier (+1 minimum)" AndAlso ModifierNumber < 1 Then
                            ModifierNumber = 1
                        End If

                    Case "Complex Modifier"
                        ModifierNumber = Character.Components.SetValueCalculator(Modifier, Character.CharacterLevel)
                End Select

                Return ModifierNumber

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'splits a string
        Private Function SplitDisplayString(ByVal Str As String) As ArrayList
            Try
                Dim ReturnList As New ArrayList

                If Str <> "" Then
                    Dim Strings As String()
                    Strings = Str.Split(",".ToCharArray)
                    For Each TempString As String In Strings
                        ReturnList.Add(TempString.Trim)
                    Next
                End If

                Return ReturnList
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'used for the spells known table
        Private Sub ClearTable(ByVal Table As Hashtable)
            Try
                Table.Clear()
                Table.Item("0") = 0
                Table.Item("1") = 0
                Table.Item("2") = 0
                Table.Item("3") = 0
                Table.Item("4") = 0
                Table.Item("5") = 0
                Table.Item("6") = 0
                Table.Item("7") = 0
                Table.Item("8") = 0
                Table.Item("9") = 0
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#End Region

    End Class

End Namespace


