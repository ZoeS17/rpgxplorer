Option Explicit On 
Option Strict On

Namespace Rules

    'class to reutrn the number of spells per day a character has
    Public Class SpellSlots

#Region "Member Variables"

        Private _Character As Character
        Private _ClassKey As Objects.ObjectKey

        'unmodified values
        Private _SPD As New ArrayList(10)
        Private _Domain As New ArrayList(10)
        Private _Specialist As New ArrayList(10)
        Private _SpellsKnown As New ArrayList(10)
        Private _ActualSpellsKnown As New ArrayList(10)
        Private _SpellPoints As Integer

        'ability score bonuses
        Private _SPDBonus As New ArrayList(10)
        Private _SpellPointsBonus As Integer

        'user modifiers
        Private _ModifierObject As Objects.ObjectData
        Private _SPDModifiers As New ArrayList(10)
        Private _DomainModifiers As New ArrayList(10)
        Private _SpecialistModifiers As New ArrayList(10)
        Private _SpellPointsModifier As Integer

        'visibility
        Public ShowSpellsPerDay As Boolean
        Public ShowSpellsKnown As Boolean

#End Region

#Region "Structures"

        Structure SpellsPerDayInfo
            Public Standard As ArrayList
            Public Domain As ArrayList
            Public Specialist As ArrayList

            Public Sub New(ByVal Standard As ArrayList, ByVal Domain As ArrayList, ByVal Specialist As ArrayList)
                Me.Standard = Standard
                Me.Domain = Domain
                Me.Specialist = Specialist
            End Sub

        End Structure

#End Region

#Region "Properties"

        'spells per day
        Public ReadOnly Property SpellsPerDay() As ArrayList
            Get
                Return _SPD
            End Get
        End Property

        'bonus spells per day
        Public ReadOnly Property BonusSpellsPerDay() As ArrayList
            Get
                Return _SPDBonus
            End Get
        End Property

        'spells per day user modifiers
        Public ReadOnly Property SpellsPerDayModifiers() As ArrayList
            Get
                Return _SPDModifiers
            End Get
        End Property

        'domain spells per day
        Public ReadOnly Property DomainSPD() As ArrayList
            Get
                Return _Domain
            End Get
        End Property

        'domain spells per day user modifiers
        Public ReadOnly Property DomainSPDModifiers() As ArrayList
            Get
                Return _DomainModifiers
            End Get
        End Property

        'specialist spells per day
        Public ReadOnly Property SpecialistSPD() As ArrayList
            Get
                Return _Specialist
            End Get
        End Property

        'specialist spells per day user modifiers
        Public ReadOnly Property SpecialistSPDModifiers() As ArrayList
            Get
                Return _SpecialistModifiers
            End Get
        End Property

        'allowed spells known
        Public ReadOnly Property SpellsKnown() As ArrayList
            Get
                Return _SpellsKnown
            End Get
        End Property

        'actual spells known
        Public ReadOnly Property ActualSpellsKnown() As ArrayList
            Get
                Return _ActualSpellsKnown
            End Get
        End Property

        'spell points
        Public ReadOnly Property SpellPoints() As Integer
            Get
                Return _SpellPoints
            End Get
        End Property

        'bonus spell points
        Public ReadOnly Property BonusSpellPoints() As Integer
            Get
                Return _SpellPointsBonus
            End Get
        End Property

        'spell points user modifier
        Public Property SpellPointsModifier() As Integer
            Get
                Return _SpellPointsModifier
            End Get
            Set(ByVal Value As Integer)
                _SpellPointsModifier = Value
            End Set
        End Property

        'gets the SPD arrays for calculating the memorized spells
        Public ReadOnly Property FinalSpellsPerDay() As SpellsPerDayInfo
            Get

                Dim Standard As New ArrayList(10)
                Dim Domain As New ArrayList(10)
                Dim Specialist As New ArrayList(10)

                For n As Integer = 0 To 9
                    Standard.Add((CInt(_SPD(n)) + CInt(_SPDBonus(n)) + CInt(_SPDModifiers(n))))
                    Domain.Add((CInt(_Domain(n)) + CInt(_DomainModifiers(n))))
                    Specialist.Add((CInt(_Specialist(n)) + CInt(_SpecialistModifiers(n))))
                Next

                Return New SpellsPerDayInfo(Standard, Domain, Specialist)

            End Get
        End Property

#End Region

        'constructor
        Public Sub New(ByVal Character As Character, ByVal ClassKey As Objects.ObjectKey)
            _Character = Character
            _ClassKey = ClassKey
        End Sub

        'load
        Public Sub Load()
            Try

                'init vars
                RestArraylists()
                ShowSpellsPerDay = False
                ShowSpellsKnown = False

                'get max spell level that this character can cast 
                Dim MaxLevel As Integer = _Character.Spells.GetMaxSpellLevel(_ClassKey, _Character.CharacterLevel, True)
                Dim ClassInfo As Rules.CharacterClass = _Character.CharacterClasses(_ClassKey)
                Dim ClassLevel As Integer = _Character.HighestEffectiveClasslevel(_ClassKey)

                'spells per day
                If Not ClassInfo.CasterInfo.NoSpellsPerDay Then
                    'set flag for spellcaster panel
                    ShowSpellsPerDay = True

                    If MaxLevel > -1 Then
                        'load the spd arraylists
                        LoadSPDArrays(MaxLevel, ClassLevel, ClassInfo)

                        'spell points
                        _SpellPoints = GetSpellPoints(ClassInfo, ClassLevel)
                        _SpellPointsBonus = GetBonusSpellPoints(ClassInfo, ClassLevel, _Character.Spells.GetSpellAbilityScore(ClassInfo, _Character.CharacterLevel))
                    End If

                    'load the mods once the other arrays have been set
                    LoadModifiers()
                End If

                'spells known
                If ClassInfo.CasterInfo.SpellAquisition = CharacterClass.AcquisitionType.Known Then

                    'set flag for spellcaster panel
                    ShowSpellsKnown = True

                    'load the spells known arraylist
                    LoadSpellKnownArray(MaxLevel, ClassLevel, ClassInfo)

                    'get all their spell known objects
                    LoadActualSpellsArray()

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'save 
        Public Sub Save()
            Try

                'save the user modifiers if required
                If ShowSpellsPerDay Then
                    If _ModifierObject.IsEmpty Then
                        Dim ClassInfo As Rules.CharacterClass = _Character.CharacterClasses(_ClassKey)

                        'create new object
                        _ModifierObject.Name = ClassInfo.ClassObj.Name & " spell modifiers"
                        _ModifierObject.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                        _ModifierObject.Type = Objects.ClassSpellModifiersType
                        _ModifierObject.ParentGUID = _Character.CharacterObject.ObjectGUID
                        _ModifierObject.FKElement("Class", ClassInfo.ClassObj.Name, "Name", _ClassKey)
                        _ModifierObject.Save()
                    End If

                    'save modifer data
                    For i As Integer = 0 To 9
                        _ModifierObject.Element("SPD" & i) = _SPDModifiers.Item(i).ToString
                        _ModifierObject.Element("Domain" & i) = _DomainModifiers.Item(i).ToString
                        _ModifierObject.Element("Specialist" & i) = _SpecialistModifiers.Item(i).ToString
                    Next
                    _ModifierObject.Element("SpellPoints") = _SpellPointsModifier.ToString

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'get the datatable for the spd grid
        Public Function GetSPDDatatable() As DataTable
            Try
                Dim Data As New DataTable("SPD")
                Dim SPDRow, DomainRow, SpecialistRow As DataRow

                'init rows
                SPDRow = Data.NewRow
                DomainRow = Data.NewRow
                SpecialistRow = Data.NewRow

                'add columns
                AddColumns(Data)

                'set row names
                SPDRow(0) = "Spells Per Day"
                DomainRow(0) = "Domain Spells"
                SpecialistRow(0) = "Specialist Spells"

                'add data
                For n As Integer = 0 To 9
                    SPDRow(n + 1) = (CInt(_SPD(n)) + CInt(_SPDBonus(n)) + CInt(_SPDModifiers(n))).ToString
                    DomainRow(n + 1) = (CInt(_Domain(n)) + CInt(_DomainModifiers(n))).ToString
                    SpecialistRow(n + 1) = (CInt(_Specialist(n)) + CInt(_SpecialistModifiers(n))).ToString
                Next

                'add to dataset
                Data.Rows.Add(SPDRow)
                Data.Rows.Add(DomainRow)
                Data.Rows.Add(SpecialistRow)

                Return Data

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'get the datatable for the spells known grid
        Public Function GetSKDatatable() As DataTable
            Try

                Dim Data As New DataTable("SpellsKnown")
                Dim SpellsKnown As DataRow

                'init rows
                SpellsKnown = Data.NewRow

                'add columns
                AddColumns(Data)

                'set row names
                SpellsKnown(0) = "Spells Known"

                'add data - offset by +1 due to the first column being "Spells Known"
                For n As Integer = 0 To 9
                    SpellsKnown(n + 1) = CInt(_ActualSpellsKnown(n))
                Next

                'add to dataset
                Data.Rows.Add(SpellsKnown)

                Return Data

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'standard columns
        Public Sub AddColumns(ByVal Data As DataTable)
            Data.Columns.Add("Name")
            Data.Columns.Add("L0")
            Data.Columns.Add("L1")
            Data.Columns.Add("L2")
            Data.Columns.Add("L3")
            Data.Columns.Add("L4")
            Data.Columns.Add("L5")
            Data.Columns.Add("L6")
            Data.Columns.Add("L7")
            Data.Columns.Add("L8")
            Data.Columns.Add("L9")
        End Sub

        'clear & reset array lists
        Private Sub RestArraylists()
            Try
                _SPD.Clear()
                _SPDBonus.Clear()
                _SPDModifiers.Clear()
                _Domain.Clear()
                _DomainModifiers.Clear()
                _Specialist.Clear()
                _SpecialistModifiers.Clear()
                _SpellsKnown.Clear()
                _ActualSpellsKnown.Clear()

                For i As Integer = 0 To 9
                    _SPD.Add(0)
                    _SPDBonus.Add(0)
                    _SPDModifiers.Add(0)
                    _Domain.Add(0)
                    _DomainModifiers.Add(0)
                    _Specialist.Add(0)
                    _SpecialistModifiers.Add(0)
                    _SpellsKnown.Add(0)
                    _ActualSpellsKnown.Add(0)
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'load user modifiers
        Private Sub LoadModifiers()
            Try

                'find the modifier object
                _ModifierObject = _Character.CharacterObject.ChildrenOfType(Objects.ClassSpellModifiersType).Item("Class", _ClassKey)

                If Not _ModifierObject.IsEmpty Then
                    Dim Total As Integer

                    'load the mods
                    For i As Integer = 0 To 9
                        Dim SPDMod, DomainMod, SpecialistMod As Integer

                        'get the mods
                        SPDMod = _ModifierObject.ElementAsInteger("SPD" & i)
                        DomainMod = _ModifierObject.ElementAsInteger("Domain" & i)
                        SpecialistMod = _ModifierObject.ElementAsInteger("Specialist" & i)

                        'spd
                        Total = CInt(_SPD(i)) + CInt(_SPDBonus(i)) + SPDMod
                        If Total < 0 Then
                            SPDMod += Math.Abs(Total)
                            _ModifierObject.Element("SPD" & i) = SPDMod.ToString
                        End If
                        _SPDModifiers.Item(i) = SPDMod

                        'domains
                        Total = CInt(_Domain(i)) + DomainMod
                        If Total < 0 Then
                            DomainMod += Math.Abs(Total)
                            _ModifierObject.Element("Domain" & i) = DomainMod.ToString
                        End If
                        _DomainModifiers.Item(i) = DomainMod

                        '_Specialist
                        Total = CInt(_Specialist(i)) + SpecialistMod
                        If Total < 0 Then
                            SpecialistMod += Math.Abs(Total)
                            _ModifierObject.Element("Specialist" & i) = SpecialistMod.ToString
                        End If
                        _SpecialistModifiers.Item(i) = SpecialistMod
                    Next

                    'spell points
                    Dim SpellPointsMod As Integer = _ModifierObject.ElementAsInteger("SpellPoints")
                    Total = _SpellPoints + _SpellPointsBonus + SpellPointsMod
                    If Total < 0 Then
                        SpellPointsMod += Math.Abs(Total)
                        _ModifierObject.Element("SpellPoints") = SpellPointsMod.ToString
                    End If
                    _SpellPointsModifier = SpellPointsMod

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the spell per day information
        Private Sub LoadSPDArrays(ByVal MaxSpellLevel As Integer, ByVal ClassLevel As Integer, ByVal ClassInfo As Rules.CharacterClass)
            Try

                Dim SpellAbilityScore As Integer = _Character.Spells.GetSpellAbilityScore(ClassInfo, _Character.CharacterLevel)
                Dim SpellsPerDayObject As Objects.ObjectData = ClassInfo.SpellsPerDayObject(ClassLevel)
                Dim BonusSpells As Boolean = ClassInfo.CasterInfo.BonusSpells

                'check if this character gets a bonus domain SPD
                Dim BonusDomainSpell As Integer
                If ClassInfo.CasterInfo.DomainBonusSpells Then
                    If _Character.Domains.ClassDomains(_ClassKey, _Character.CharacterLevel).Count > 0 Then
                        BonusDomainSpell = 1
                    Else
                        'check for any prestige classes which advanced this class and see if they have domains
                        For Each SpellCasterChoiceData As Library.LibraryData In _Character.PrestigeSpellcasterChoices.ItemData(_ClassKey)
                            Dim SpellCasterChoice As Character.CharacterChoice = DirectCast(SpellCasterChoiceData.Data, Character.CharacterChoice)
                            If _Character.Domains.ClassDomains(SpellCasterChoice.ClassGuid, _Character.CharacterLevel).Count > 0 Then
                                BonusDomainSpell = 1
                                Exit For
                            End If
                        Next
                    End If
                End If

                'check if this character gets a bonus specialist school SPD
                Dim BonusSpecialistSpell As Integer
                If ClassInfo.CasterInfo.SchoolBonusSpells Then
                    For Each CharacterChoiceData As Library.LibraryData In _Character.Choices.ItemData(_ClassKey)
                        Dim CharacterChoice As Character.CharacterChoice = DirectCast(CharacterChoiceData.Data, Character.CharacterChoice)
                        If CharacterChoice.Type = Character.ChoiceType.SpecailistSchool Then
                            BonusSpecialistSpell = 1
                            Exit For
                        End If
                    Next
                End If

                For i As Integer = 0 To 9
                    If i <= MaxSpellLevel Then
                        'spd
                        Dim ElementString As String = "Level" & i & "Spells"
                        Dim NumberOfSpells As Integer

                        If SpellsPerDayObject.Element(ElementString) <> "" Then
                            NumberOfSpells = SpellsPerDayObject.ElementAsInteger(ElementString)
                            _SPD.Item(i) = NumberOfSpells
                            If BonusSpells Then
                                _SPDBonus.Item(i) = GetBonusSpells(i, SpellAbilityScore)
                            End If
                        End If

                        'domain
                        _Domain.Item(i) = BonusDomainSpell

                        'specialist
                        _Specialist.Item(i) = BonusSpecialistSpell
                    End If
                Next

                'quick fix for 0-level domain spells
                _Domain(0) = 0

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the spells known information
        Private Sub LoadSpellKnownArray(ByVal MaxSpellLevel As Integer, ByVal ClassLevel As Integer, ByVal ClassInfo As Rules.CharacterClass)
            Try

                'get the spells known
                If (MaxSpellLevel > -1) Then
                    Dim SpellsKnownObject As Objects.ObjectData = ClassInfo.SpellsKnownObject(ClassLevel)

                    For i As Integer = 0 To 9
                        If i <= MaxSpellLevel Then

                            'spells known
                            Dim ElementString As String = "Level" & i & "Spells"
                            Dim NumberOfSpells As Integer
                            If SpellsKnownObject.Element(ElementString) <> "" Then
                                NumberOfSpells = SpellsKnownObject.ElementAsInteger(ElementString)

                                'check if they can actualy cast spells from this level
                                If ClassInfo.CasterInfo.NoSpellsPerDay Then
                                    'if no spd they get the number anyway
                                    _SpellsKnown.Item(i) = NumberOfSpells
                                Else
                                    If CInt(_SPD.Item(i)) > 0 OrElse CInt(_SPDBonus.Item(i)) > 0 Then
                                        _SpellsKnown.Item(i) = NumberOfSpells
                                    End If
                                End If
                            End If

                        End If
                    Next
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        'loads the spell info for the actual spells the character has taken
        Private Sub LoadActualSpellsArray()
            Try
                Dim Found As Boolean = False
                Dim SpellFolder As New Objects.ObjectData

                For Each SpellFolder In _Character.MagicFolder.ChildrenOfType(Objects.ClassSpellListFolderType)
                    If SpellFolder.GetFKGuid("Class").Equals(_ClassKey) Then
                        Found = True
                        Exit For
                    End If
                Next

                If Found = True Then
                    Dim SpellsKnown As Objects.ObjectDataCollection = SpellFolder.Children
                    Dim SpellLevel As Integer

                    For Each Spell As Objects.ObjectData In SpellsKnown
                        'get the spell level
                        SpellLevel = Spell.ElementAsInteger("Level")
                        _ActualSpellsKnown.Item(SpellLevel) = CInt(_ActualSpellsKnown.Item(SpellLevel)) + 1
                    Next
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

#Region "Shared Functions"

        'Gets the number of bonus spells of the specified level are availalbe with the given Ability Score
        Public Shared Function GetBonusSpells(ByVal SpellLevel As Integer, ByVal AbilityScore As Integer) As Integer
            Try

                If SpellLevel > 0 And SpellLevel < 10 Then
                    Return Rules.AbilityScores.AbilityScore(AbilityScore).BonusSpells(SpellLevel)
                Else
                    Return 0
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the spell points
        Public Shared Function GetSpellPoints(ByVal ClassInfo As Rules.CharacterClass, ByVal ClassLevel As Integer) As Integer
            Try

                'get the spellsper day object
                Dim SpellsPerDayObject As Objects.ObjectData = ClassInfo.SpellsPerDayObject(ClassLevel)

                If Not SpellsPerDayObject.IsEmpty Then
                    Return SpellsPerDayObject.ElementAsInteger("SpellPoints")
                Else
                    Return 0
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

        'return the bonus spell points
        Public Shared Function GetBonusSpellPoints(ByVal ClassInfo As Rules.CharacterClass, ByVal ClassLevel As Integer, ByVal Abilityscore As Integer) As Integer
            Try

                If ClassInfo.CasterInfo.BonusPoints Then

                    'get the spellsperday object
                    Dim SpellsPerDayObject As Objects.ObjectData = ClassInfo.SpellsPerDayObject(ClassLevel)
                    Dim MaxSpellLevel As Integer = 0

                    'get the max spell level for spell point bonus
                    If Not SpellsPerDayObject.IsEmpty Then
                        For i As Integer = 0 To 9
                            Dim ElementString As String = "Level" & i & "Spells"

                            If SpellsPerDayObject.Element(ElementString) <> "" Then
                                MaxSpellLevel = i
                            End If
                        Next
                    End If

                    Return Rules.AbilityScores.AbilityScore(Abilityscore).BonusSpellPoints(MaxSpellLevel)

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Function

#End Region

    End Class

End Namespace
