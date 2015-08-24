Option Explicit On
Option Strict On

Imports DevExpress.XtraEditors

Imports RPGXplorer.General
Imports RPGXplorer.Exceptions

Public Class CharacterPanel
    Implements IPanel

#Region "Member Variables"

    Private _CharacterKey As Objects.ObjectKey
    Private _IsLoading As Boolean
    Private _IsDirty As Boolean
    Private _Character As Rules.Character
    Private _CharacterObj As Objects.ObjectData
    Private _Inventory As Rules.Inventory

#End Region

    'init
    Public Sub Init(ByVal CharacterKey As Objects.ObjectKey)
        _CharacterKey = CharacterKey
        CType(Me.Parent, CentralDisplayForm).NeedsPanelInit = False
    End Sub

#Region "IPanel"

    'is dirty
    Public Property IsDirty() As Boolean Implements IPanel.IsDirty
        Get
            Return _IsDirty
        End Get
        Set(ByVal Value As Boolean)
            _IsDirty = Value
        End Set
    End Property

    'list view
    Public ReadOnly Property ListView() As System.Windows.Forms.ListView Implements IPanel.ListView
        Get
            Return Nothing
        End Get
    End Property

    'refresh
    Public Sub RefreshPanelData() Implements IPanel.RefreshPanelData
        General.SetWaitCursor()
        Save()
        _IsLoading = True
        _Character = CharacterManager.CurrentCharacter
        _CharacterObj = _Character.CharacterObject

        _Inventory = _Character.Inventory
        Dim ArmorClass As New Rules.ArmourClass(_Inventory)

        Select Case _Character.CharacterType
            Case Rules.Character.CharacterObjectType.AnimalCompanion
                If _CharacterObj.Element("Mount") = "Yes" Then
                    EditCharacter.Text = "Edit Mount"
                Else
                    EditCharacter.Text = "Edit Companion"
                End If
            Case Rules.Character.CharacterObjectType.Character
                EditCharacter.Text = "Edit Character"
            Case Rules.Character.CharacterObjectType.Familiar
                EditCharacter.Text = "Edit Familiar"
            Case Rules.Character.CharacterObjectType.SpecialMount
                EditCharacter.Text = "Edit Mount/Servant"
            Case Rules.Character.CharacterObjectType.Monster
                EditCharacter.Text = "Edit Monster"
        End Select

        'portrait
        Dim Path As String = _CharacterObj.Element("Portrait")
        If Path = "" Then
            Portrait.Image = Nothing
            PortraitLabel.Visible = True
        Else
            If Path.IndexOf(":") = -1 Then
                Path = General.BasePath & "Images\Portraits\" & Path
            End If
            If IO.File.Exists(Path) Then
                Portrait.Image = Image.FromFile(Path)
                PortraitLabel.Visible = False
            Else
                General.ShowErrorDialog("Portrait not found.")
                _CharacterObj.Element("Portrait") = ""
                Portrait.Image = Nothing
                PortraitLabel.Visible = True
            End If
        End If

        'basic details
        Dim RaceObj As Objects.ObjectData = _CharacterObj.GetFKObject("Race")
        Dim SubTypes As String = RaceObj.Element("Subtypes")
        If SubTypes <> "" Then SubTypes = " (" & SubTypes & ")"

        Dim MonsterType As String = RaceObj.Element("MonsterTypeDisplay")
        If MonsterType = "" Then MonsterType = RaceObj.Element("MonsterType")

        RaceSizeType.Text = RaceObj.Name & " - " & _Character.Size & " " & MonsterType & SubTypes
        Alignment.Text = _CharacterObj.Element("Alignment")
        XP.Value = _CharacterObj.ElementAsInteger("XP")
        Level.Text = _Character.CharacterLevel.ToString
        Classes.Text = " " & _Character.ClassesStatBlock
        Description.Text = " " & _Character.PhysicalSummary
        Deity.Text = " " & _CharacterObj.Element("Deity")

        'effective character level
        Dim ECL As Integer = _Character.EffectiveCharacterLevel
        If ECL <> _Character.CharacterLevel Then Level.Text &= " (" & (ECL).ToString & ")"

        'next level xp
        Dim NextLevelXP As Integer = _Character.NextLevelXP
        If NextLevelXP > 0 Then NextLevel.Text = NextLevelXP.ToString Else NextLevel.Text = "NA"

        Dim CurrentLevel As Rules.Character.Level = _Character.CurrentLevel

        'ability scores
        STR.Text = CurrentLevel.STR.ToString
        If STR.Text = "-1" Then STR.Text = "-"
        DEX.Text = CurrentLevel.DEX.ToString
        If DEX.Text = "-1" Then DEX.Text = "-"
        CON.Text = CurrentLevel.CON.ToString
        If CON.Text = "-1" Then CON.Text = "-"
        INT.Text = CurrentLevel.INT.ToString
        If INT.Text = "-1" Then INT.Text = "-"
        WIS.Text = CurrentLevel.WIS.ToString
        CHA.Text = CurrentLevel.CHA.ToString

        SetModifierColour(STR, CurrentLevel.STRFlag)
        SetModifierColour(DEX, CurrentLevel.DEXFlag)
        SetModifierColour(CON, CurrentLevel.CONFlag)
        SetModifierColour(INT, CurrentLevel.INTFlag)
        SetModifierColour(WIS, CurrentLevel.WISFlag)
        SetModifierColour(CHA, CurrentLevel.CHAFlag)

        UpdateModifierColours()

        'saving throws
        Fortitude.Text = Rules.Formatting.FormatModifier(CurrentLevel.Fortitude)
        If Fortitude.Text = "-999" Then Fortitude.Text = "-"

        Reflex.Text = Rules.Formatting.FormatModifier(CurrentLevel.Reflex)
        If Reflex.Text = "-999" Then Reflex.Text = "-"

        Will.Text = Rules.Formatting.FormatModifier(CurrentLevel.Will)
        SetModifierColour(Fortitude, CurrentLevel.FortFlag)
        SetModifierColour(Reflex, CurrentLevel.ReflexFlag)
        SetModifierColour(Will, CurrentLevel.WillFlag)

        'size, speed, run, initiative
        Dim SpeedVal As Integer = _Inventory.Speed
        Speed.Text = Rules.Formatting.FormatFeet(SpeedVal)
        SetModifierColour(Speed, Rules.Modifiers.ModifierFlag(SpeedVal, _Character.SpeedBaseUnmodified))
        Run.Text = "x" & _Inventory.Run
        SetModifierColour(Run, Rules.Modifiers.ModifierFlag(_Inventory.Run, 4))
        Initiative.Text = Rules.Formatting.FormatModifier(_Character.Initiative)
        SetModifierColour(Initiative, _Character.InitFlag)
        Swim.Text = _Character.Swim
        Climb.Text = _Character.Climb
        Burrow.Text = _Character.Burrow
        Fly.Text = _Character.Fly

        'weight and load
        Weight.Text = Rules.Formatting.FormatPounds(_Inventory.Weight) & " (" & _Inventory.Load & ")"

        'armor check penalty
        Dim ArmorCheckPenalty As Integer
        If _Inventory.ArmorWorn.IsNotEmpty Then
            If _Inventory.ArmorProperties.CheckPenalty < 0 Then
                ArmorCheckPenalty = Math.Min(0, _Inventory.ArmorProperties.CheckPenalty + _Character.Modifiers.CheckPenaltyFromArmor)
            End If
        End If
        'shield check penalty
        Dim ShieldCheckPenalty As Integer
        If _Inventory.ShieldWorn.IsNotEmpty Then
            If _Inventory.ShieldProperties.CheckPenalty < 0 Then
                ShieldCheckPenalty = _Inventory.ShieldProperties.CheckPenalty
            End If
        End If
        'encumberance check penalty 
        Dim EncumCheck As Integer
        Dim Effects As Rules.Encumberance.CarryingLoad
        If _Inventory.Load <> "Light" Then
            Effects = Rules.Encumberance.LoadEffects(_Inventory.Load)
            If Effects.CheckPenalty < 0 Then
                EncumCheck = Effects.CheckPenalty
            End If
        End If

        Dim CheckPenalty As Integer = Math.Min(ArmorCheckPenalty, Math.Min(ShieldCheckPenalty, EncumCheck))
        ACP.Text = CheckPenalty.ToString

        If ACP.Text = "-" Then
            ACP.ForeColor = Color.Black
        ElseIf CheckPenalty = 0 Then
            ACP.ForeColor = Color.LimeGreen
        ElseIf CheckPenalty >= -5 Then
            ACP.ForeColor = Color.DarkOrange
        Else
            ACP.ForeColor = Color.Red
        End If

        'hp
        Dim CONMod As Integer = Rules.AbilityScores.AbilityScore(_Character.CurrentLevel.CON).Modifier
        HD.Text = _Character.HitDice.ToString
        MaxHP.Text = _Character.HP.ToString
        HP.Value = _Character.CurrentHP
        NonLethal.Value = _Character.CurrentNonlethalHP


        'bab, melee, ranged, grapple
        BAB.Text = Rules.Formatting.FormatAttacks(_Character.GetBaseAttackBonuses)
        Melee.Text = Rules.Formatting.FormatModifier(_Character.BABMelee(True))
        Ranged.Text = Rules.Formatting.FormatModifier(_Character.BABRanged(True))
        Grapple.Text = Rules.Formatting.FormatModifier(_Character.BABGrapple)

        SetModifierColour(Melee, Rules.Modifiers.ModifierFlag(_Character.Modifiers.AttackRoll, 0))
        SetModifierColour(Ranged, Rules.Modifiers.ModifierFlag(_Character.Modifiers.AttackRoll, 0))
        SetModifierColour(Grapple, Rules.Modifiers.ModifierFlag(_Character.Modifiers.GrappleRoll, 0))

        'ac
        AC.Text = ArmorClass.AC.ToString
        Touch.Text = ArmorClass.TouchAC.ToString
        Flatfooted.Text = ArmorClass.FlatFootedAC.ToString
        Helpless.Text = ArmorClass.HelplessAC.ToString
        If _Inventory.ArmorWorn.IsNotEmpty Then ArmorInfo.Text = " " & _Inventory.ArmorProperties.Name Else ArmorInfo.Text = " Not wearing any armor"
        If _Inventory.ShieldWorn.IsNotEmpty Then ShieldInfo.Text = " " & _Inventory.ShieldProperties.Name Else ShieldInfo.Text = " Not carrying a shield"

        SetModifierColour(AC, ArmorClass.ACFlag)
        SetModifierColour(Touch, ArmorClass.TouchACFlag)
        SetModifierColour(Flatfooted, ArmorClass.FlatfootedFlag)
        SetModifierColour(Helpless, ArmorClass.HelplessFlag)

        'resistances
        SR.Text = _Character.Components.SpellResistance(_Character.CharacterLevel).ToString
        PR.Text = _Character.Components.PowerResistance(_Character.CharacterLevel).ToString()
        Resistances.Text = " " & _Character.Components.DamageResistance
        DR.Text = " " & _Character.Components.DamageReduction

        'space and reach
        If _Character.Space <> "" Then
            Space.Text = _Character.Space
        Else
            Space.Text = "-"
        End If

        If _Character.Reach <> "" Then
            Reach.Text = _Character.Reach
        Else
            Reach.Text = "-"
        End If

        'skills
        _Character.UpdateSkillMods()
        SpotSkill.Text = Rules.Formatting.FormatModifier(GetSkill(References.Spot))
        ListenSkill.Text = Rules.Formatting.FormatModifier(GetSkill(References.Listen))
        MoveSkill.Text = Rules.Formatting.FormatModifier(GetSkill(References.MoveSilently))
        HideSkill.Text = Rules.Formatting.FormatModifier(GetSkill(References.Hide))
        SearchSkill.Text = Rules.Formatting.FormatModifier(GetSkill(References.Search))
        JumpSkill.Text = Rules.Formatting.FormatModifier(GetSkill(References.Jump))

        'notes, background
        Notes.Text = _CharacterObj.Element("Notes")
        Background.Text = _CharacterObj.Element("Background")

        _IsLoading = False
        General.SetNormalCursor()

    End Sub

    'save
    Public Sub Save() Implements IPanel.Save
        If IsDirty Then
            General.MainExplorer.Undo.UndoRecord()
            _CharacterObj.Element("CurrentHP") = HP.Text
            _CharacterObj.Element("CurrentNonlethalHP") = NonLethal.Text
            _CharacterObj.Element("XP") = XP.Text
            _CharacterObj.Element("Notes") = Notes.Text
            _CharacterObj.Element("Background") = Background.Text
            _CharacterObj.Save()
            _IsDirty = False
        End If
    End Sub

    Private _ReadOnly As Boolean = False

    'read-only
    Public WriteOnly Property [ReadOnly]() As Boolean Implements IPanel.ReadOnly
        Set(ByVal value As Boolean)
            If value <> _ReadOnly Then
                _ReadOnly = value
                If _ReadOnly Then
                    Me.EditCharacter.Enabled = False
                    Me.XP.Enabled = False
                    Me.HP.Enabled = False
                    Me.NonLethal.Enabled = False
                Else
                    Me.EditCharacter.Enabled = True
                    Me.XP.Enabled = True
                    Me.HP.Enabled = True
                    Me.NonLethal.Enabled = True
                End If
            End If
        End Set
    End Property

#End Region

#Region "Changed Events"

    'xp, hp and nonlethal changed
    Private Sub Spin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XP.EditValueChanged, HP.EditValueChanged, NonLethal.EditValueChanged
        If Not _IsLoading Then IsDirty = True
    End Sub

    'background changed
    Private Sub Background_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Background.EditValueChanged
        If Not _IsLoading Then IsDirty = True
    End Sub

    'notes changed
    Private Sub Notes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notes.EditValueChanged
        If Not _IsLoading Then IsDirty = True
    End Sub

#End Region

    Private Function GetSkill(ByVal SkillKey As Objects.ObjectKey) As Integer
        'get the skillgained object
        Return CInt(_Character.Skill(SkillKey).Final)
    End Function

    'modifiers colouring
    Private Sub UpdateModifierColours()
        Dim Modifier As Integer

        'strength
        If STR.Text <> "-" Then
            Modifier = Rules.AbilityScores.AbilityScore(CInt(STR.Text)).Modifier
            If Modifier > 0 Then
                STRMod.BackColor = BackColourPositive
                STRMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                STRMod.BackColor = BackColourNegative
                STRMod.Text = Modifier.ToString
            Else
                STRMod.BackColor = BackColourWhite
                STRMod.Text = Modifier.ToString
            End If
        Else
            STRMod.BackColor = BackColourWhite
            STRMod.Text = ""
        End If


        'dexterity
        If DEX.Text <> "-" Then
            Modifier = Rules.AbilityScores.AbilityScore(CInt(DEX.Text)).Modifier
            If Modifier > 0 Then
                DEXMod.BackColor = BackColourPositive
                DEXMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                DEXMod.BackColor = BackColourNegative
                DEXMod.Text = Modifier.ToString
            Else
                DEXMod.BackColor = BackColourWhite
                DEXMod.Text = Modifier.ToString
            End If
        Else
            DEXMod.BackColor = BackColourWhite
            DEXMod.Text = ""
        End If

        'constitution
        If CON.Text <> "-" Then
            Modifier = Rules.AbilityScores.AbilityScore(CInt(CON.Text)).Modifier
            If Modifier > 0 Then
                CONMod.BackColor = BackColourPositive
                CONMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                CONMod.BackColor = BackColourNegative
                CONMod.Text = Modifier.ToString
            Else
                CONMod.BackColor = BackColourWhite
                CONMod.Text = Modifier.ToString
            End If
        Else
            CONMod.BackColor = BackColourWhite
            CONMod.Text = ""
        End If


        'intelligence
        If INT.Text <> "-" Then
            Modifier = Rules.AbilityScores.AbilityScore(CInt(INT.Text)).Modifier
            If Modifier > 0 Then
                INTMod.BackColor = BackColourPositive
                INTMod.Text = "+" & Modifier.ToString
            ElseIf Modifier < 0 Then
                INTMod.BackColor = BackColourNegative
                INTMod.Text = Modifier.ToString
            Else
                INTMod.BackColor = BackColourWhite
                INTMod.Text = Modifier.ToString
            End If
        Else
            INTMod.BackColor = BackColourWhite
            INTMod.Text = ""
        End If

        'wisdom
        Modifier = Rules.AbilityScores.AbilityScore(CInt(WIS.Text)).Modifier
        If Modifier > 0 Then
            WISMod.BackColor = BackColourPositive
            WISMod.Text = "+" & Modifier.ToString
        ElseIf Modifier < 0 Then
            WISMod.BackColor = BackColourNegative
            WISMod.Text = Modifier.ToString
        Else
            WISMod.BackColor = BackColourWhite
            WISMod.Text = Modifier.ToString
        End If

        'charisma
        Modifier = Rules.AbilityScores.AbilityScore(CInt(CHA.Text)).Modifier
        If Modifier > 0 Then
            CHAMod.BackColor = BackColourPositive
            CHAMod.Text = "+" & Modifier.ToString
        ElseIf Modifier < 0 Then
            CHAMod.BackColor = BackColourNegative
            CHAMod.Text = Modifier.ToString
        Else
            CHAMod.BackColor = BackColourWhite
            CHAMod.Text = Modifier.ToString
        End If
    End Sub

    'modifier colouring for text
    Private Sub SetModifierColour(ByVal Control As TextEdit, ByVal Flag As Rules.Modifiers.Modifier)
        Select Case Flag
            Case Rules.Modifiers.Modifier.Negative
                Control.ForeColor = Color.Red
            Case Rules.Modifiers.Modifier.None
                Control.ForeColor = Color.Black
            Case Rules.Modifiers.Modifier.Positive
                Control.ForeColor = Color.MediumBlue
        End Select
    End Sub

    'set portrait
    Private Sub Portrait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Portrait.DoubleClick
        Dim Filename As String = ""
        Dim PathToSave As String = ""

        Try
            OpenFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png"
            OpenFileDialog1.InitialDirectory = General.BasePath & "Images\Portraits\"
            OpenFileDialog1.Multiselect = False
            OpenFileDialog1.RestoreDirectory = True
            OpenFileDialog1.CheckFileExists = False
            OpenFileDialog1.CheckPathExists = False
            OpenFileDialog1.ValidateNames = False

            If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                Filename = OpenFileDialog1.FileName
                If Filename = "" Then
                    Portrait.Image = Nothing
                    PathToSave = ""
                    PortraitLabel.Visible = True
                Else
                    If Filename.IndexOf(General.BasePath & "Images\Portraits\") <> -1 Then
                        PathToSave = Filename.Replace(General.BasePath & "Images\Portraits\", "")
                    Else
                        PathToSave = Filename
                    End If
                    If System.IO.File.Exists(Filename) Then
                        PortraitLabel.Visible = False
                        Portrait.Image = Image.FromFile(Filename)
                    End If
                End If
            End If

            If System.IO.File.Exists(Filename) Then
                _CharacterObj.Element("Portrait") = PathToSave
                IsDirty = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'set portrait
    Private Sub PortraitLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortraitLabel.DoubleClick
        Portrait_Click(Nothing, Nothing)
    End Sub

#Region "Focus"

    Private Sub PanelGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles XP.GotFocus, Portrait.GotFocus, PortraitLabel.GotFocus, HP.GotFocus, NonLethal.GotFocus
        General.MainExplorer.CurrentFocus = Explorer.Focus.ListView
    End Sub

#End Region

    'edit the character
    Private Sub EditCharacter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCharacter.Click
        Select Case _Character.CharacterType
            Case Rules.Character.CharacterObjectType.Monster
                Commands.EditMonster(Nothing, Nothing)
            Case Else
                Commands.EditCharacter(Nothing, Nothing)
        End Select
    End Sub

End Class
