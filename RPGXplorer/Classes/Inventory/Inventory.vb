Option Explicit On
Option Strict On

Imports RPGXplorer.General

Namespace Rules

    Public Class Inventory

        'this class handes everything to do with character inventory

#Region "Enumerations"

        Public Enum EncumberanceType
            ByWeight
            ByArmor
        End Enum

        Public Enum WearableItemResult
            Armor
            Shield
            NotWearable
        End Enum

#End Region

#Region "Member Variables"

        Private _Character As Character
        Private _CharacterObj As Objects.ObjectData
        'Private _Inventory As Objects.ObjectDataCollection
        Private _InventoryFolder As Objects.ObjectData
        Private _AssetsFolder As Objects.ObjectData

        Private _EncType As EncumberanceType
        Private _Armor As Objects.ObjectKey
        Private _ArmorProperties As ArmorProperties
        Private _Shield As Objects.ObjectKey
        Private _ShieldProperties As ArmorProperties

        Private _Weight As Double
        Private _Value, _ValueAssets As Money
        Private _Money, _MoneyAssets As Money
        Private _MoneyObjs As ArrayList
        Private _CheckPenalty, _MaxDex, _SpellFailureArmor, _SpellFailureShield, _Run, _BaseRun, _Speed, _BaseSpeed As Integer
        Private _Load As String

        'flags
        Public ReduceSpeed As Boolean
        Public SpeedFlag As Modifiers.Modifier

#End Region

#Region "Properties"

        'armor worn
        Public Property ArmorWorn() As Objects.ObjectKey
            Get
                Return _Armor
            End Get
            Set(ByVal Value As Objects.ObjectKey)
                _Armor = Value
                If _Armor.IsNotEmpty Then
                    Dim Armor As New Objects.ObjectData
                    Armor.Load(_Armor)
                    _CharacterObj.FKElement("ArmorWorn", Armor.Name, "Name", _Armor)
                    Dim Masterwork As Boolean
                    Dim Enhancement As Integer
                    Dim Material As Objects.ObjectData
                    If Armor.Element("Masterwork") = "Yes" Then Masterwork = True
                    Enhancement = Armor.ElementAsInteger("EnhancementBonus")
                    Material = Armor.GetFKObject("Material")
                    If Material.IsEmpty Then
                        _ArmorProperties = New Rules.ArmorProperties(Armor.GetFKObject("Item"), Masterwork, Enhancement)
                    Else
                        _ArmorProperties = New Rules.ArmorProperties(Armor.GetFKObject("Item"), Material, Masterwork, Enhancement)
                    End If
                Else
                    _CharacterObj.FKSetNull("ArmorWorn")
                End If
                _CharacterObj.Save()
            End Set
        End Property

        'armor properties 
        Public Property ArmorProperties() As ArmorProperties
            Get
                Return _ArmorProperties
            End Get
            Set(ByVal Value As ArmorProperties)
                _ArmorProperties = Value
            End Set
        End Property

        'shield worn
        Public Property ShieldWorn() As Objects.ObjectKey
            Get
                Return _Shield
            End Get
            Set(ByVal Value As Objects.ObjectKey)
                _Shield = Value
                If _Shield.IsNotEmpty Then
                    Dim Shield As New Objects.ObjectData
                    Shield.Load(_Shield)
                    _CharacterObj.FKElement("ShieldWorn", Shield.Name, "Name", _Shield)
                    Dim Masterwork As Boolean
                    Dim Enhancement As Integer
                    If Shield.Element("Masterwork") = "Yes" Then Masterwork = True
                    Enhancement = Shield.ElementAsInteger("EnhancementBonus")
                    _ShieldProperties = New Rules.ArmorProperties(Shield.GetFKObject("Item"), Masterwork, Enhancement)
                Else
                    _CharacterObj.FKSetNull("ShieldWorn")
                End If
                _CharacterObj.Save()
            End Set
        End Property

        'shield properties 
        Public Property ShieldProperties() As ArmorProperties
            Get
                Return _ShieldProperties
            End Get
            Set(ByVal Value As ArmorProperties)
                _ShieldProperties = Value
            End Set
        End Property

        'character
        Public ReadOnly Property Character() As Character
            Get
                Return _Character
            End Get
        End Property

        'encumberance type
        Public Property Encumberance() As EncumberanceType
            Get
                Return _EncType
            End Get
            Set(ByVal Value As EncumberanceType)
                _EncType = Value
            End Set
        End Property

        'load
        Public Property Load() As String
            Get
                Return _Load
            End Get
            Set(ByVal Value As String)
                _Load = Value
            End Set
        End Property

        'funds
        Public ReadOnly Property Funds() As Money
            Get
                'how much money the character is carrying
                Return _Money
            End Get
        End Property

        'inventory
        'Public ReadOnly Property Inventory() As Objects.ObjectDataCollection
        '    Get
        '        Return _Inventory
        '    End Get
        'End Property

        'inventory folder
        Public Property InventoryFolder() As Objects.ObjectData
            Get
                Return _InventoryFolder
            End Get
            Set(ByVal Value As Objects.ObjectData)
                _InventoryFolder = Value
            End Set
        End Property

        'value of inventory
        Public ReadOnly Property Value() As Money
            Get
                Return _Value
            End Get
        End Property

        'value of assets
        Public ReadOnly Property ValueAssets() As Money
            Get
                Return _ValueAssets
            End Get
        End Property

        'weight
        Public ReadOnly Property Weight() As Double
            Get
                Return _Weight
            End Get
        End Property

        'money
        Public ReadOnly Property Money() As Money
            Get
                Return _Money
            End Get
        End Property

        'money (assets)
        Public ReadOnly Property MoneyAssets() As Money
            Get
                Return _MoneyAssets
            End Get
        End Property

        'check penalty
        Public ReadOnly Property CheckPenalty() As Integer
            Get
                Return _CheckPenalty
            End Get
        End Property

        'max dex
        Public ReadOnly Property MaxDEX() As Integer
            Get
                Return _MaxDex
            End Get
        End Property

        'spell failure 
        Public ReadOnly Property SpellFailure() As Integer
            Get
                Return SpellFailureArmor + SpellFailureShield
            End Get
        End Property

        'spell failure (armor)
        Public ReadOnly Property SpellFailureArmor() As Integer
            Get
                Return _SpellFailureArmor
            End Get
        End Property

        'spell failure (shield)
        Public ReadOnly Property SpellFailureShield() As Integer
            Get
                Return _SpellFailureShield
            End Get
        End Property

        'base speed
        Public ReadOnly Property BaseSpeed() As Integer
            Get
                Return _BaseSpeed
            End Get
        End Property

        'adjusted speed
        Public ReadOnly Property Speed() As Integer
            Get
                If _Speed = 0 Then
                    SpeedFlag = Modifiers.Modifier.Negative
                    Return 0
                Else
                    Dim Modifier As Integer = _Character.Modifiers.Speed
                    If Modifier > 0 Then
                        SpeedFlag = Rules.Modifiers.Modifier.Positive
                    ElseIf Modifier < 0 Then
                        SpeedFlag = Rules.Modifiers.Modifier.Negative
                    Else
                        SpeedFlag = Rules.Modifiers.Modifier.None
                    End If
                    Return _Speed + Modifier
                End If
            End Get
        End Property

        'base run speed
        Public ReadOnly Property BaseRun() As Integer
            Get
                Return _BaseRun
            End Get
        End Property

        'run speed
        Public ReadOnly Property Run() As Integer
            Get
                Return _Run
            End Get
        End Property

        'STR
        Public ReadOnly Property STR() As Integer
            Get
                'get load
                Return _Character.CurrentLevel.STR
            End Get
        End Property

        'dex mod
        Public ReadOnly Property DEXMod() As Integer
            Get
                Return Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.DEX).Modifier
            End Get
        End Property

        'dex modifier to ac
        Public ReadOnly Property DEXModAC() As Integer
            Get
                If DEXMod > MaxDEX Then
                    Return MaxDEX
                Else
                    Return DEXMod
                End If
            End Get
        End Property

        'unarmored
        Public ReadOnly Property Unarmored() As Boolean
            Get
                If _Armor.IsEmpty Then Return True Else Return False
            End Get
        End Property

        'does the inventory contain a specific active item
        Public ReadOnly Property ActiveInventoryItem(ByVal ItemKey As Objects.ObjectKey) As Boolean
            Get

            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Rules.Character)
            _Character = Character
            _CharacterObj = _Character.CharacterObject
            _InventoryFolder = Character.CharacterObject.FirstChildOfType(Objects.InventoryFolderType)
            _AssetsFolder = Character.CharacterObject.FirstChildOfType(Objects.AssetsFolderType)

            'get encumberance type
            Select Case _CharacterObj.Element("EncumberanceType")
                Case "", EncumberanceType.ByWeight.ToString
                    _EncType = EncumberanceType.ByWeight
                Case Else
                    _EncType = EncumberanceType.ByArmor
            End Select

            'get armor worn
            ArmorWorn = _CharacterObj.GetFKGuid("ArmorWorn")
            ShieldWorn = _CharacterObj.GetFKGuid("ShieldWorn")
        End Sub

        'save 
        Public Sub Save()
            _CharacterObj.Element("EncumberanceType") = _EncType.ToString
            _CharacterObj.Save()
        End Sub

        'add cart items to inventory
        Public Sub AddCartItems(ByVal Items As Objects.ObjectDataCollection)
            Dim NewItem As Objects.ObjectData

            General.MainExplorer.TreeView.BeginUpdate()
            For Each Item As Objects.ObjectData In Items
                Select Case Item.Element("ItemType")
                    Case Objects.ScrollDefinitionType
                        Dim ScrollItem As Objects.ObjectData
                        Dim ScrollDef As Objects.ObjectData

                        'make the new scroll item
                        ScrollItem = Item.CloneSingle(InventoryFolder)
                        ScrollItem.Save()

                        'get the scroll definition
                        ScrollDef = Item.GetFKObject("Item")

                        'clone the scroll spells and add them to the new scroll item
                        For Each ScrollSpell As Objects.ObjectData In ScrollDef.ChildrenOfType(Objects.ScrollSpellType)
                            NewItem = ScrollSpell.CloneSingle(ScrollItem)
                            NewItem.Save()
                        Next

                    Case Else
                        NewItem = Item.CloneSingle(InventoryFolder)
                        NewItem.Save()

                        'if it is a container item - we will need to add new TreeNodes
                        If NewItem.ShowInTree Then
                            General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(InventoryFolder.ObjectGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(NewItem))
                        End If

                End Select
            Next
            General.MainExplorer.TreeView.EndUpdate()

        End Sub

        'remove money spent
        Public Sub RemoveMoneySpent(ByVal TotalCost As Money)
            'remove money from the character
            Dim CopperSpent As Integer = TotalCost.InCopper

            For Each MoneyObj As Objects.ObjectData In _MoneyObjs
                Dim Money As Money = New Money(MoneyObj.Name)

                If Money.InCopper <= CopperSpent Then
                    CopperSpent -= Money.InCopper
                    MoneyObj.Delete()
                Else
                    Money.RemoveMoney(CopperSpent.ToString & "cp")
                    MoneyObj.Name = Money.DisplayString
                    MoneyObj.Element("Weight") = Rules.Formatting.FormatPounds(Money.Weight)
                    MoneyObj.Element("Cost") = Money.DisplayString
                    MoneyObj.Save()
                    Exit For
                End If
            Next
        End Sub

        'calculate weight, money and value of items currently carried
        Public Sub Calculate(ByVal AnalyseInventoryComponents As Boolean, Optional ByVal LoadComponents As Boolean = True, Optional ByVal IgnoreShield As Boolean = False)

            'remove armor and shield if we are not analysing the inventory
            If Not AnalyseInventoryComponents Then
                _Armor = Objects.ObjectKey.Empty
                _Shield = Objects.ObjectKey.Empty
            End If

            If LoadComponents Then
                If AnalyseInventoryComponents Then
                    Character.ComponentsState = Character.ComponentsLoaded.CharacterAndInventory
                Else
                    Character.ComponentsState = Character.ComponentsLoaded.Character
                End If

                'Load the character components if required
                _Character.Components.LoadCharacter(IgnoreShield)
            End If

            'weight and cost
            _Weight = 0
            _Value = New Money
            _Money = New Money
            _MoneyObjs = New ArrayList
            CalculateRecurse(_InventoryFolder, False, AnalyseInventoryComponents, LoadComponents)
            CalculateAssets()

            _Load = Rules.Encumberance.CurrentLoad(_Character.Size, STR, _Weight, _Character.Quadruped)

            'recursive check and recalculate of all conditions and modifers
            _Character.Components.CheckConditions_CalculateModifiers(AnalyseInventoryComponents)

            'monk stuff
            _Character.Components.AddMonkModifiers(AnalyseInventoryComponents)
            _Character.Modifiers.CalculateModifiers(References.ArmorClassMonk, 1000)
            _Character.Modifiers.CalculateModifiers(References.Speed, 1000)

            _CheckPenalty = 0
            _SpellFailureArmor = 0
            _SpellFailureShield = 0

            If _Load = "Too Heavy" And _EncType = EncumberanceType.ByWeight Then
                'too heavy
                _MaxDex = 0
            Else
                _MaxDex = 999

                'run system ability, ignore encumberance
                Dim Run As Boolean = _Character.Components.SystemAbilities(References.Run)
                Dim IgnoreEncumberance As Boolean = _Character.Components.SystemAbilities(References.IgnoreEncumberance)

                'get armor penalties
                If _Armor.IsNotEmpty Then

                    _CheckPenalty = ArmorProperties.CheckPenalty
                    If _CheckPenalty < 0 Then _CheckPenalty = Math.Min(0, _CheckPenalty + Character.Modifiers.CheckPenaltyFromArmor)

                    _MaxDex = ArmorProperties.MaxDex
                    If _MaxDex <> 999 Then _MaxDex = _MaxDex + Character.Modifiers.MaxDexFromArmor

                    _SpellFailureArmor = ArmorProperties.SpellFailure
                End If

                'get shield penalties
                If _Shield.IsNotEmpty Then
                    _CheckPenalty += ShieldProperties.CheckPenalty
                    If ShieldProperties.MaxDex < _MaxDex And ShieldProperties.MaxDex <> 999 Then
                        _MaxDex = ShieldProperties.MaxDex
                    End If
                    _SpellFailureShield = ShieldProperties.SpellFailure
                End If

                'get load penalties
                Dim Effects As Encumberance.CarryingLoad

                If _EncType = EncumberanceType.ByWeight And _Load <> "Light" Then
                    Effects = Rules.Encumberance.LoadEffects(_Load)

                    If Effects.CheckPenalty < _CheckPenalty Then _CheckPenalty = Effects.CheckPenalty
                    If Effects.MaxDex < _MaxDex Then _MaxDex = Effects.MaxDex
                End If

                'speed
                _BaseSpeed = _Character.SpeedBase
                _Speed = _BaseSpeed
                If Run Then _BaseRun = 5 Else _BaseRun = 4
                _Run = _BaseRun
                Dim ReduceRun As Boolean = False

                'speed from armor
                If _Armor.IsNotEmpty Then
                    ReduceSpeed = False

                    Select Case ArmorProperties.ArmorTraining
                        Case "Light"
                        Case "Medium"
                            ReduceSpeed = True
                        Case "Heavy"
                            ReduceRun = True
                            ReduceSpeed = True
                    End Select

                    If ReduceSpeed And Not IgnoreEncumberance Then
                        Select Case _BaseSpeed
                            Case 20
                                _Speed = Rules.Encumberance.LoadEffects("Medium").Speed20ft
                            Case 30
                                _Speed = Rules.Encumberance.LoadEffects("Medium").Speed30ft
                            Case 40
                                _Speed = Rules.Encumberance.LoadEffects("Medium").Speed40ft
                            Case 50
                                _Speed = Rules.Encumberance.LoadEffects("Medium").Speed50ft
                        End Select
                    End If
                End If

                'speed from weight carried
                If _EncType = EncumberanceType.ByWeight And _Load <> "Light" And Not IgnoreEncumberance Then
                    Select Case _BaseSpeed
                        Case 20
                            If Effects.Speed20ft < _Speed Then _Speed = Effects.Speed20ft
                        Case 30
                            If Effects.Speed30ft < _Speed Then _Speed = Effects.Speed30ft
                        Case 40
                            If Effects.Speed40ft < _Speed Then _Speed = Effects.Speed40ft
                        Case 50
                            If Effects.Speed50ft < _Speed Then _Speed = Effects.Speed50ft
                    End Select

                    If Effects.Run < 4 Then ReduceRun = True
                End If

                'reduce run?
                If ReduceRun Then _Run -= 1

            End If

            'skills
            _Character.Components.CalculateJumpModifier()
            _Character.Components.AddHideModifier()
            _Character.Modifiers.CalculateSkills()

        End Sub

        'recursive part of weight, money and value calculation
        Private Sub CalculateRecurse(ByVal Item As Objects.ObjectData, ByVal Weightless As Boolean, ByVal AnalyseInventoryComponents As Boolean, ByVal LoadComponents As Boolean)


            Select Case Item.Type
                Case Objects.ItemType, Objects.MoneyType
                    'add weight to running total
                    If Not Weightless Then _Weight += CType(Item.Element("Weight").Replace(" lb.", ""), Double)

                    'cost and money
                    Select Case Item.Type
                        Case Objects.ItemType
                            If Item.Element("Cost") <> "" Then _Value.AddMoney(Item.Element("Cost"))

                            'components
                            If AnalyseInventoryComponents And LoadComponents Then
                                If Item.Element("Active") = "Yes" Then
                                    _Character.Components.AnalyseComponent(Item.GetFKGuid("Item"))
                                End If
                            End If

                        Case Objects.MoneyType
                            _Money.AddMoney(Item.Name)
                            Dim CoinCount As Integer = New Money(Item.Name).CoinCount
                            _MoneyObjs.Add(Item)
                            Exit Sub
                    End Select

                    'check for bag of holding etc.
                    If Not Weightless Then
                        Dim Container As Objects.ObjectData = Item.GetFKObject("Item")
                        If Container.Element("NonDimensionalContainer") = "Yes" Then Weightless = True
                    End If
            End Select

            'recurse
            For Each Child As Objects.ObjectData In Item.Children
                CalculateRecurse(Child, Weightless, AnalyseInventoryComponents, LoadComponents)
            Next
        End Sub

        'calculate speed at particular load level taking modifiers e.g. base speed into account
        Public Function CalculateSpeedForLoad(ByVal Load As String) As Integer

            'set load
            _Load = Load

            'components and modifiers
            _Character.Prerequisites.Begin()
            _Character.Components.CheckConditions_CalculateModifiers(True, True)

            'ignore encumberance
            Dim IgnoreEncumberance As Boolean = _Character.Components.SystemAbilities(References.IgnoreEncumberance)

            'get load penalties
            Dim Effects As Encumberance.CarryingLoad = Rules.Encumberance.LoadEffects(_Load)

            'speed
            _BaseSpeed = _Character.SpeedBase
            _Speed = _BaseSpeed

            'speed from weight carried
            If _Load <> "Light" And Not IgnoreEncumberance Then
                Select Case _BaseSpeed
                    Case 20
                        If Effects.Speed20ft < _Speed Then Return Effects.Speed20ft
                    Case 30
                        If Effects.Speed30ft < _Speed Then Return Effects.Speed30ft
                    Case 40
                        If Effects.Speed40ft < _Speed Then Return Effects.Speed40ft
                    Case 50
                        If Effects.Speed50ft < _Speed Then Return Effects.Speed50ft
                End Select
            Else
                Return _BaseSpeed
            End If
        End Function

        'calculate money and value of assets
        Public Sub CalculateAssets()
            _ValueAssets = New Money
            _MoneyAssets = New Money
            If _AssetsFolder.IsNotEmpty Then CalculateRecurseAssets(_AssetsFolder)
        End Sub

        'recursive part of money and value calculation for assets
        Private Sub CalculateRecurseAssets(ByVal Item As Objects.ObjectData)

            If Item.Type <> Objects.AssetsFolderType Then

                'cost and money
                Select Case Item.Type
                    Case Objects.ItemType
                        If Item.Element("Cost") <> "" Then _ValueAssets.AddMoney(Item.Element("Cost"))
                    Case Objects.MoneyType
                        _MoneyAssets.AddMoney(Item.Name)
                        Exit Sub
                End Select

            End If

            'recurse
            For Each Child As Objects.ObjectData In Item.Children
                CalculateRecurseAssets(Child)
            Next
        End Sub

        'get all the armor items currently eligible to be worn
        Public Function EligibleArmor() As DataListItem()
            Dim Armor As New Objects.ObjectDataCollection

            'loop through top level of inventory looking for armor
            For Each Item As Objects.ObjectData In _InventoryFolder.Children
                Select Case Item.Element("ItemType")
                    Case Objects.ArmorDefinitionType
                        Armor.Add(Item)
                    Case Objects.SpecificArmorDefinitionType
                        Dim MagicArmor As Objects.ObjectData

                        MagicArmor = Item.GetFKObject("Item")
                        If MagicArmor.Element("ArmorType") = Objects.ArmorDefinitionType Then
                            Armor.Add(Item)
                        End If
                    Case Objects.PsionicArmorDefinitionType
                        Dim PsionicArmor As Objects.ObjectData

                        PsionicArmor = Item.GetFKObject("Item")
                        If PsionicArmor.Element("ArmorType") = Objects.ArmorDefinitionType Then
                            Armor.Add(Item)
                        End If
                End Select
            Next

            Return Index.DataList(Armor, True)
        End Function

        'get all the shield items currently eligible to be worn
        Public Function EligibleShields() As DataListItem()
            Dim Shields As New Objects.ObjectDataCollection

            'loop through top level of inventory looking for shields
            For Each Item As Objects.ObjectData In _InventoryFolder.Children
                Select Case Item.Element("ItemType")
                    Case Objects.ShieldDefinitionType
                        Shields.Add(Item)
                    Case Objects.SpecificArmorDefinitionType
                        Dim MagicArmor As Objects.ObjectData

                        MagicArmor = Item.GetFKObject("Item")
                        If MagicArmor.Element("ArmorType") = Objects.ShieldDefinitionType Then
                            Shields.Add(Item)
                        End If
                    Case Objects.PsionicArmorDefinitionType
                        Dim PsionicArmor As Objects.ObjectData

                        PsionicArmor = Item.GetFKObject("Item")
                        If PsionicArmor.Element("ArmorType") = Objects.ShieldDefinitionType Then
                            Shields.Add(Item)
                        End If
                End Select
            Next

            Return Index.DataList(Shields, True)
        End Function

        'get quantity
        Public Shared Function GetQuantity(ByVal ItemGuid As Objects.ObjectKey) As Integer
            Dim Item As New Objects.ObjectData
            Item.Load(ItemGuid)
            Return Item.ElementAsInteger("Quantity")
        End Function

        'adjust quantity of an inventory item
        Public Shared Function AdjustQuantity(ByVal ItemGuid As Objects.ObjectKey, ByVal Quantity As Integer) As Objects.ObjectData
            Dim Item As New Objects.ObjectData
            Item.Load(ItemGuid)
            Return AdjustQuantity(Item, Quantity)
        End Function

        'adjust quantity of an inventory item
        Public Shared Function AdjustQuantity(ByVal Item As Objects.ObjectData, ByVal Quantity As Integer) As Objects.ObjectData
            Dim Cost As Money
            Dim Weight As Double

            Cost = New Money(Item.Element("BaseCost"))
            Cost.Multiply(CType(Quantity, Double))

            Weight = Double.Parse(Item.Element("BaseWeight").Replace(" lb.", ""))
            Weight *= Quantity

            Item.Element("Cost") = Cost.DisplayString
            Item.Element("Quantity") = Quantity.ToString
            Item.Element("Weight") = Rules.Formatting.FormatPounds(Weight)
            Return Item
        End Function

        'get charges
        Public Shared Function GetCharges(ByVal ItemGuid As Objects.ObjectKey) As Integer
            Dim Item As New Objects.ObjectData
            Item.Load(ItemGuid)
            Return Item.ElementAsInteger("Charges")
        End Function

        'load an individual inventory item into a list view item
        Public Shared Sub MapInventoryItemToListViewItem(ByVal Item As Objects.ObjectData, ByVal ListViewItem As ListViewItem)
            ListViewItem.ImageIndex = Images.SmallImageIndex(Item.ImageFilename)
            ListViewItem.Tag = Item.ObjectGUID
            ListViewItem.SubItems.Clear()
            ListViewItem.Text = Item.Name
            ListViewItem.SubItems.Add(Item.Element("Quantity"))
            ListViewItem.SubItems.Add(Item.Element("Weight"))
            ListViewItem.SubItems.Add(Item.Element("Cost"))
            ListViewItem.SubItems.Add(Item.Element("Active"))
            ListViewItem.SubItems.Add(Item.Element("Charges"))
        End Sub

        'load an individual asset item into a list view item
        Public Shared Sub MapAssetItemToListViewItem(ByVal Item As Objects.ObjectData, ByRef ListViewItem As ListViewItem)
            ListViewItem.ImageIndex = Images.SmallImageIndex(Item.ImageFilename)
            ListViewItem.Tag = Item.ObjectGUID
            ListViewItem.SubItems.Clear()
            ListViewItem.Text = Item.Name
            ListViewItem.SubItems.Add(Item.Element("Quantity"))
            ListViewItem.SubItems.Add(Item.Element("Weight"))
            ListViewItem.SubItems.Add(Item.Element("Cost"))
            ListViewItem.SubItems.Add(Item.Element("Charges"))
        End Sub

        'returns a flag stating if the given item is either Armor or a Shield
        Public Shared Function IsArmorOrShield(ByVal Item As Objects.ObjectData) As WearableItemResult
            If Item.IsEmpty Then Return WearableItemResult.NotWearable

            Select Case Item.Element("ItemType")

                Case Objects.ArmorDefinitionType
                    Return WearableItemResult.Armor

                Case Objects.ShieldDefinitionType
                    Return WearableItemResult.Shield

                Case Objects.SpecificArmorDefinitionType
                    Dim MagicArmor As Objects.ObjectData = Item.GetFKObject("Item")

                    Select Case MagicArmor.Element("ArmorType")
                        Case Objects.ArmorDefinitionFolderType
                            Return WearableItemResult.Armor
                        Case Objects.ShieldDefinitionType
                            Return WearableItemResult.Shield
                        Case Else
                            Return WearableItemResult.NotWearable
                    End Select

                Case Objects.PsionicArmorDefinitionType
                    Dim PsionicArmor As Objects.ObjectData = Item.GetFKObject("Item")

                    Select Case PsionicArmor.Element("ArmorType")
                        Case Objects.ArmorDefinitionFolderType
                            Return WearableItemResult.Armor
                        Case Objects.ShieldDefinitionType
                            Return WearableItemResult.Shield
                        Case Else
                            Return WearableItemResult.NotWearable
                    End Select

                Case Else
                    Return WearableItemResult.NotWearable

            End Select

        End Function

    End Class

End Namespace
