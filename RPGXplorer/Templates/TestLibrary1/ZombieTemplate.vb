Option Strict On
Option Explicit On

Imports RPGXplorer
Imports RPGXplorer.Rules

Public Class ZombieTemplate
    Implements RPGXplorer.ITemplate

    Private _TemplateName As String = "Zombie"
    Private _TemplateGuid As New Guid("1AE97536-4C66-4f7e-941E-B8EC4266109A")

    'applies the template to the given character
    Public Function ApplyTemplate(ByVal Creature As Character) As Boolean Implements RPGXplorer.ITemplate.ApplyTemplate

        'type changing - creature type becomes undead

        'get the undead type
        'Dim SubtypeCollection As Objects.ObjectDataCollection = Objects.GetAllObjectsOfType(XML.Subtypes, Objects.SubtypeDefinitionType)
        'Dim UndeadSubtype As Objects.ObjectKey
        'Dim Subtypes As General.DataListItem




        'Creature.CreatureType

        'want to set the creatures AquiredTemplate FK



        'if the creature is not already undead, we need to change its type. 

        'selection dialogue for removal of subtypes

        'need to find all the class levels and remove them, or if we only have class levels remove all but 1
        'For Each Level As RPGXplorer.Rules.Character.Level In Character
        'Next

        'double the remaining levels

        'convert all hitdice to d12

        're-roll or average hitdice somehow

        'selection dialogue for removal and addition for features

        'remove feats and gain Toughness - need to bascially add a feat to the character

        'remove skills
        'Dim UndeadType As Objects.ObjectData
        'UndeadType.Load(RPGXplorer.References.Undead)

        'type changing - creature type becomes undead
        'Character.CreatureType = UndeadType

        'selection dialogue for removal of subtypes - if we have any
        'Dim CurrentSubtypes As ArrayList = Character.CreatureSubtypes
        'If CurrentSubtypes.Count > 0 Then
        '    Dim SubTypeChooser As New ConstructListDialog

        '    SubTypeChooser.Init("Select any subtypes to be removed", "Subtypes", "Caption", "Current Subtypes", "Removed Subtypes", Nothing, True)
        '    SubTypeChooser.InitTextList(CurrentSubtypes, New ArrayList)
        '    SubTypeChooser.ShowDialog()

        '    Dim RemovedSubtypes As ArrayList = SubTypeChooser.ListBFinal

        '    'if we have removed any subtypes
        '    If RemovedSubtypes.Count > 0 Then

        '        'update the current list
        '        For Each Subtype As String In RemovedSubtypes
        '            CurrentSubtypes.Remove(Subtype)
        '        Next

        '        'apply update to the creature
        '        Character.CreatureSubtypes = CurrentSubtypes

        '    End If

        'End If

        ''find the first class level and remove everything after
        'Dim FirstClassLevel As Integer
        'For Each Level As Rules.Character.Level In Character.Levels
        '    If Level.ClassGuid.Database = XML.Classes Then
        '        'we found a class level
        '        FirstClassLevel = Level.CharacterLevel
        '        Exit For
        '    End If
        'Next

        ''if we did find a class level, we have to remove everything after
        'If FirstClassLevel > 0 Then

        'End If


        'need to find all the class levels and remove them, or if we only have class levels remove all but 1

        'go through the levels collection
        'stop when we find a level with a class key
        'remove everything from then on

        'For Each Level As RPGXplorer.Rules.Character.Level In Character
        'Next

        'double the remaining levels

        'convert all hitdice to d12

        're-roll or average hitdice somehow

        'selection dialogue for removal and addition for features

        'remove feats and gain Toughness - need to bascially add a feat to the character

        'remove skills - set new element

        Return True
    End Function


    'can the given creature aquire this template?
    Public Function CanAquire(ByVal Creature As Character) As Boolean Implements RPGXplorer.ITemplate.CanAquire
        If Creature.RaceObject.Element("MonsterTypeDisplay") = "Undead" Then
            Return False
        Else
            Return True
        End If
    End Function

    'returns the name of the template
    Public ReadOnly Property TemplateName() As String Implements RPGXplorer.ITemplate.TemplateName
        Get
            Return _TemplateName
        End Get
    End Property

    'returns the guid of the template
    Public ReadOnly Property TemplateGuid() As Guid Implements RPGXplorer.ITemplate.TemplateGuid
        Get
            Return _TemplateGuid
        End Get
    End Property

End Class
