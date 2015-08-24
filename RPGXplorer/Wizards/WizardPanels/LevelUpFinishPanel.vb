Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class LevelUpFinishPanel
    Inherits RPGXplorer.PanelBase
    Implements IWizardPanel

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
    Public WithEvents ObjLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(250, 21)
        Me.ObjLabel.TabIndex = 94
        Me.ObjLabel.Text = "Click on Finish to update your character"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelUpFinishPanel
        '
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "LevelUpFinishPanel"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private IsInitialised As Boolean


#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext
    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised
        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 480
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 520
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel

    End Sub

#End Region

    'initialise this panel
    'Public Sub Init(Optional ByVal PreviousPanel As IWizardPanel = Nothing) Implements IWizardPanel.Init
    '    Try

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

    ''finish
    'Public Sub Finish() Implements IWizardPanelFinish.Finish
    '    Dim CharacterLevel, ClassLevel, HighestLevelInClassObj, SkillPointsSpent, Skill, AbilityFolder, Ability, ClassAbility, AbilityGained, Feat, FeatDef, FeatTakenObj, Focus, FeatFolder As Objects.ObjectData
    '    Dim Skills As Objects.ObjectDataCollection
    '    Dim HighestLevelInClass, NewCharacterLevel As Integer
    '    Dim PointsSpent, RanksGained As Double
    '    Dim Row As DataRow
    '    Dim FeatTaken As SelectFeatsPanel.FeatTaken

    '    Try


    '        'get all the skill objects
    '        Skills = mData.Character.FirstChildOfType(Objects.SkillFolderType).Children

    '        'add the skill points spent objects
    '        For Each Row In mData.SkillData.Rows
    '            RanksGained = ConvertToDouble(Row("Points").ToString)
    '            If RanksGained > 0 Then
    '                If Row("ClassSkill").ToString = "Class" Then
    '                    PointsSpent = RanksGained
    '                Else
    '                    PointsSpent = RanksGained * 2
    '                End If

    '                SkillPointsSpent.Name = Row("Skill").ToString & " (+" & RanksGained.ToString & " Ranks)"
    '                SkillPointsSpent.ObjectGUID = Guid.NewGuid
    '                SkillPointsSpent.Type = Objects.SkillPointsSpentType
    '                SkillPointsSpent.ParentGUID = CharacterLevel.ObjectGUID
    '                SkillPointsSpent.FKElement("Skill", Row("Skill").ToString, "Name", New Guid(Row("SkillGuid").ToString))
    '                SkillPointsSpent.Element("PointsSpent") = PointsSpent.ToString
    '                SkillPointsSpent.Element("RanksGained") = RanksGained.ToString
    '                SkillPointsSpent.Save()
    '                SkillPointsSpent.Clear()

    '                'now update the corresponding skill object
    '                Skill = Skills.Item("Skill", New Guid(Row("SkillGuid").ToString))
    '                Skill.Element("Ranks") = (ConvertToDouble(Skill.Element("Ranks")) + RanksGained).ToString
    '                Skill.Save()
    '                Skill.Clear()
    '            End If
    '        Next
    '        Rules.Skills.RecalculateSkillModifiers(mData.Character)

    '        'add the ability and ability gained objects
    '        AbilityFolder = mData.Character.FirstChildOfType(Objects.FeatureFolderType)
    '        For Each ClassAbility In ClassLevel.ChildrenOfType(Objects.FeatureType)
    '            Ability.Name = ClassAbility.Name
    '            Ability.ObjectGUID = Guid.NewGuid
    '            Ability.Type = Objects.FeatureType
    '            Ability.ParentGUID = AbilityFolder.ObjectGUID
    '            Ability.FKElement("Ability", ClassAbility.Name, "Name", ClassAbility.GetFKGuid("Ability"))
    '            Ability.Save()

    '            AbilityGained.Name = Ability.Name
    '            AbilityGained.ObjectGUID = Guid.NewGuid
    '            AbilityGained.Type = Objects.FeatureGainedType
    '            AbilityGained.ParentGUID = CharacterLevel.ObjectGUID
    '            AbilityGained.FKElement("Ability", Ability.Name, "Name", Ability.ObjectGUID)
    '            AbilityGained.Save()

    '            Ability.Clear()
    '            AbilityGained.Clear()
    '        Next

    '        'add the feat and feat taken objects
    '        FeatFolder = mData.Character.FirstChildOfType(Objects.FeatFolderType)
    '        For Each FeatTaken In mData.FeatsTakenData
    '            FeatDef.Load(FeatTaken.FeatGuid)

    '            Feat.ObjectGUID = Guid.NewGuid
    '            Feat.Type = Objects.FeatType
    '            Feat.ParentGUID = FeatFolder.ObjectGUID
    '            Feat.FKElement("Feat", FeatDef.Name, "Name", FeatDef.ObjectGUID)
    '            If FeatTaken.Focus.Equals(Guid.Empty) Then
    '                Feat.Element("Focus") = ""
    '            Else
    '                Feat.FKElement("Focus", Focus.Name, "Name", Focus.ObjectGUID)
    '            End If
    '            Feat.Element("OverridePrerequisites") = ""
    '            Feat.Save()

    '            FeatTakenObj.ObjectGUID = Guid.NewGuid
    '            FeatTakenObj.Type = Objects.FeatTakenType
    '            FeatTakenObj.ParentGUID = CharacterLevel.ObjectGUID
    '            FeatTakenObj.FKElement("Feat", Feat.Name, "Name", Feat.ObjectGUID)
    '            FeatTakenObj.Save()

    '            Feat.Clear()
    '            FeatTakenObj.Clear()
    '        Next

    '        'miscellaneous
    '        mData.Character.ElementAsInteger("CurrentHP") += mData.HPRolled + Rules.AbilityScores.AbilityScoreData(mData.Character.ElementAsInteger("CON")).Modifier
    '        mData.Character.Save()

    '        RaiseEvent Finished()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message, ex)
    '    End Try
    'End Sub

End Class
