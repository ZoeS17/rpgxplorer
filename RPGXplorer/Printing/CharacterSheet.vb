Imports DevExpress.XtraReports.UI

Public Class CharacterSheet
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents Detail As DevExpress.XtraReports.UI.DetailBand

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    Public WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel101 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel102 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel103 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel192 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel193 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel194 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel195 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel196 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel197 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents CHAMod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents WISMod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents INTMod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents CONMod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents DEXMod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents STRMod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Portrait As DevExpress.XtraReports.UI.XRPictureBox
    Public WithEvents Alignment As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XP As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Race As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Classes As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents NextLevel As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents CharacterName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents CharacterDataset1 As RPGXplorer.CharacterDataset
    Public WithEvents Level As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Attacks1 As RPGXplorer.AttacksSubreport
    Private WithEvents Feats1 As RPGXplorer.Feats
    Private WithEvents Skills1 As RPGXplorer.Skills
    Private WithEvents Features1 As RPGXplorer.Features
    Private WithEvents Inventory1 As RPGXplorer.Inventory
    Private WithEvents SpellsPerDay1 As RPGXplorer.SpellsPerDay
    Public WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Attacks As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents Skills As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Feats As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents Features As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents Inventory As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Assets As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Public WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Public WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Public WithEvents SpellsPerDay As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents Spells As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents ArmorSpellFailureBox As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents ArmorSpellFailureLabel As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents ShieldSpellFailureBox As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents ShieldSpellFailureLabel As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents SpellFailure As DevExpress.XtraReports.UI.XRPanel
    Public WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel68 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel76 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel86 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel93 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel94 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel95 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel96 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel98 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents SpellcastingModifiers As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents Domains As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents SpellcastingNotes As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents CasterLevel As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Public WithEvents Modifiers As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents ConditionalModifiers As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents ManifesterLevels As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents ManifestingModifiers As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents ManifesterBreak As DevExpress.XtraReports.UI.XRPageBreak
    Public WithEvents ManifestingNotes As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents Powers As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents PsionicSpecializations As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents WinControlContainer25 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents STR As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents DEX As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer33 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents HP As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer32 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents PR As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer31 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents CON As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer30 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents INT As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer29 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents ACFlatFooted As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer28 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents ACHelpless As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer27 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents SR As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer26 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Will As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer23 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Reflex As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer22 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Fortitude As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer5 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents CHA As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents WIS As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer39 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Initiative As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer38 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Ranged As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer37 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents ACTouch As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer36 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Melee As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer35 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents Grapple As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer34 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents BAB3 As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer9 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents BAB1 As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer8 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents BAB2 As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer7 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents BAB4 As RPGXplorer.AttributeCircle
    Public WithEvents WinControlContainer6 As DevExpress.XtraReports.UI.WinControlContainer
    Public WithEvents AC As RPGXplorer.AttributeCircle
    Public WithEvents CasterBreak As DevExpress.XtraReports.UI.XRPageBreak

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.Level = New DevExpress.XtraReports.UI.XRLabel
        Me.Classes = New DevExpress.XtraReports.UI.XRLabel
        Me.XP = New DevExpress.XtraReports.UI.XRLabel
        Me.NextLevel = New DevExpress.XtraReports.UI.XRLabel
        Me.Alignment = New DevExpress.XtraReports.UI.XRLabel
        Me.Race = New DevExpress.XtraReports.UI.XRLabel
        Me.CharacterName = New DevExpress.XtraReports.UI.XRLabel
        Me.PsionicSpecializations = New DevExpress.XtraReports.UI.XRSubreport
        Me.Powers = New DevExpress.XtraReports.UI.XRSubreport
        Me.ManifestingNotes = New DevExpress.XtraReports.UI.XRSubreport
        Me.ManifesterBreak = New DevExpress.XtraReports.UI.XRPageBreak
        Me.ManifestingModifiers = New DevExpress.XtraReports.UI.XRSubreport
        Me.ManifesterLevels = New DevExpress.XtraReports.UI.XRSubreport
        Me.Modifiers = New DevExpress.XtraReports.UI.XRSubreport
        Me.CasterLevel = New DevExpress.XtraReports.UI.XRSubreport
        Me.SpellcastingNotes = New DevExpress.XtraReports.UI.XRSubreport
        Me.Domains = New DevExpress.XtraReports.UI.XRSubreport
        Me.SpellcastingModifiers = New DevExpress.XtraReports.UI.XRSubreport
        Me.CasterBreak = New DevExpress.XtraReports.UI.XRPageBreak
        Me.ConditionalModifiers = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrLabel98 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel68 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.SpellFailure = New DevExpress.XtraReports.UI.XRPanel
        Me.ShieldSpellFailureBox = New DevExpress.XtraReports.UI.XRLabel
        Me.ArmorSpellFailureBox = New DevExpress.XtraReports.UI.XRLabel
        Me.ShieldSpellFailureLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.ArmorSpellFailureLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.Spells = New DevExpress.XtraReports.UI.XRSubreport
        Me.SpellsPerDay = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel96 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel93 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel95 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel94 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.Assets = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.Inventory = New DevExpress.XtraReports.UI.XRSubreport
        Me.Features = New DevExpress.XtraReports.UI.XRSubreport
        Me.Feats = New DevExpress.XtraReports.UI.XRSubreport
        Me.Skills = New DevExpress.XtraReports.UI.XRSubreport
        Me.Attacks = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel
        Me.CHAMod = New DevExpress.XtraReports.UI.XRLabel
        Me.WISMod = New DevExpress.XtraReports.UI.XRLabel
        Me.INTMod = New DevExpress.XtraReports.UI.XRLabel
        Me.CONMod = New DevExpress.XtraReports.UI.XRLabel
        Me.DEXMod = New DevExpress.XtraReports.UI.XRLabel
        Me.STRMod = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel
        Me.Portrait = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel197 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel196 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel195 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel194 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel193 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel192 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.CharacterDataset1 = New RPGXplorer.CharacterDataset
        Me.XrLabel101 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel102 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel103 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.WinControlContainer39 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Initiative = New RPGXplorer.AttributeCircle
        Me.WinControlContainer38 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Ranged = New RPGXplorer.AttributeCircle
        Me.WinControlContainer37 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.ACTouch = New RPGXplorer.AttributeCircle
        Me.WinControlContainer36 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Melee = New RPGXplorer.AttributeCircle
        Me.WinControlContainer35 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Grapple = New RPGXplorer.AttributeCircle
        Me.WinControlContainer34 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.BAB3 = New RPGXplorer.AttributeCircle
        Me.WinControlContainer9 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.BAB1 = New RPGXplorer.AttributeCircle
        Me.WinControlContainer8 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.BAB2 = New RPGXplorer.AttributeCircle
        Me.WinControlContainer7 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.BAB4 = New RPGXplorer.AttributeCircle
        Me.WinControlContainer6 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.AC = New RPGXplorer.AttributeCircle
        Me.WinControlContainer33 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.HP = New RPGXplorer.AttributeCircle
        Me.WinControlContainer32 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.PR = New RPGXplorer.AttributeCircle
        Me.WinControlContainer31 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.CON = New RPGXplorer.AttributeCircle
        Me.WinControlContainer30 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.INT = New RPGXplorer.AttributeCircle
        Me.WinControlContainer29 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.ACFlatFooted = New RPGXplorer.AttributeCircle
        Me.WinControlContainer28 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.ACHelpless = New RPGXplorer.AttributeCircle
        Me.WinControlContainer27 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.SR = New RPGXplorer.AttributeCircle
        Me.WinControlContainer26 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Will = New RPGXplorer.AttributeCircle
        Me.WinControlContainer23 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Reflex = New RPGXplorer.AttributeCircle
        Me.WinControlContainer22 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Fortitude = New RPGXplorer.AttributeCircle
        Me.WinControlContainer5 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.CHA = New RPGXplorer.AttributeCircle
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.WIS = New RPGXplorer.AttributeCircle
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.DEX = New RPGXplorer.AttributeCircle
        Me.WinControlContainer25 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.STR = New RPGXplorer.AttributeCircle
        CType(Me.CharacterDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BorderColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer39, Me.WinControlContainer38, Me.WinControlContainer37, Me.WinControlContainer36, Me.WinControlContainer35, Me.WinControlContainer34, Me.WinControlContainer9, Me.WinControlContainer8, Me.WinControlContainer7, Me.WinControlContainer6, Me.WinControlContainer33, Me.WinControlContainer32, Me.WinControlContainer31, Me.WinControlContainer30, Me.WinControlContainer29, Me.WinControlContainer28, Me.WinControlContainer27, Me.WinControlContainer26, Me.WinControlContainer23, Me.WinControlContainer22, Me.WinControlContainer5, Me.WinControlContainer2, Me.WinControlContainer1, Me.WinControlContainer25, Me.XrLabel33, Me.XrLabel78, Me.XrLabel69, Me.XrLabel72, Me.XrLabel57, Me.XrLabel56, Me.XrLabel4, Me.XrLabel64, Me.XrLabel59, Me.XrLabel65, Me.XrLabel1, Me.XrLabel31, Me.Level, Me.Classes, Me.XP, Me.NextLevel, Me.Alignment, Me.Race, Me.CharacterName, Me.PsionicSpecializations, Me.Powers, Me.ManifestingNotes, Me.ManifesterBreak, Me.ManifestingModifiers, Me.ManifesterLevels, Me.Modifiers, Me.CasterLevel, Me.SpellcastingNotes, Me.Domains, Me.SpellcastingModifiers, Me.CasterBreak, Me.ConditionalModifiers, Me.XrLabel98, Me.XrLabel68, Me.XrLabel61, Me.XrLabel20, Me.SpellFailure, Me.Spells, Me.SpellsPerDay, Me.XrPanel3, Me.XrPanel2, Me.XrPanel1, Me.XrLabel34, Me.Assets, Me.XrLabel28, Me.XrLabel27, Me.XrLabel6, Me.XrLabel5, Me.Inventory, Me.Features, Me.Feats, Me.Skills, Me.Attacks, Me.XrLabel49, Me.XrLabel58, Me.XrLabel79, Me.XrLabel22, Me.XrLabel21, Me.XrLabel77, Me.XrLabel71, Me.XrLabel70, Me.XrLabel8, Me.XrLabel54, Me.XrLabel52, Me.XrLabel37, Me.XrLabel30, Me.XrLabel25, Me.XrLabel45, Me.CHAMod, Me.WISMod, Me.INTMod, Me.CONMod, Me.DEXMod, Me.STRMod, Me.XrLabel75, Me.XrLabel55, Me.XrLabel53, Me.Portrait, Me.XrLabel51, Me.XrLabel48, Me.XrLabel47, Me.XrLabel44, Me.XrLabel36, Me.XrLabel35, Me.XrLabel32, Me.XrLabel197, Me.XrLabel196, Me.XrLabel195, Me.XrLabel194, Me.XrLabel193, Me.XrLabel192, Me.XrLabel12, Me.XrLabel2})
        Me.Detail.Height = 1424
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.BackColor = System.Drawing.Color.White
        Me.XrLabel33.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel33.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.CanGrow = False
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Assets", "")})
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel33.ForeColor = System.Drawing.Color.Black
        Me.XrLabel33.Location = New System.Drawing.Point(57, 818)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.Size = New System.Drawing.Size(667, 21)
        Me.XrLabel33.Text = "XrLabel23"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel33.WordWrap = False
        '
        'XrLabel78
        '
        Me.XrLabel78.BackColor = System.Drawing.Color.White
        Me.XrLabel78.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel78.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.CurrentHP", "")})
        Me.XrLabel78.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel78.ForeColor = System.Drawing.Color.Black
        Me.XrLabel78.Location = New System.Drawing.Point(526, 255)
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel78.Size = New System.Drawing.Size(198, 21)
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel69
        '
        Me.XrLabel69.BackColor = System.Drawing.Color.White
        Me.XrLabel69.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel69.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel69.CanGrow = False
        Me.XrLabel69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Resistances", "")})
        Me.XrLabel69.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel69.ForeColor = System.Drawing.Color.Black
        Me.XrLabel69.Location = New System.Drawing.Point(193, 275)
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel69.Size = New System.Drawing.Size(229, 21)
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel69.WordWrap = False
        '
        'XrLabel72
        '
        Me.XrLabel72.BackColor = System.Drawing.Color.White
        Me.XrLabel72.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel72.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel72.CanGrow = False
        Me.XrLabel72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.DR", "")})
        Me.XrLabel72.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel72.ForeColor = System.Drawing.Color.Black
        Me.XrLabel72.Location = New System.Drawing.Point(193, 255)
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.Size = New System.Drawing.Size(229, 21)
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel72.WordWrap = False
        '
        'XrLabel57
        '
        Me.XrLabel57.BackColor = System.Drawing.Color.White
        Me.XrLabel57.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel57.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel57.CanGrow = False
        Me.XrLabel57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Shield", "")})
        Me.XrLabel57.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel57.ForeColor = System.Drawing.Color.Black
        Me.XrLabel57.Location = New System.Drawing.Point(490, 218)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.Size = New System.Drawing.Size(234, 21)
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel57.WordWrap = False
        '
        'XrLabel56
        '
        Me.XrLabel56.BackColor = System.Drawing.Color.White
        Me.XrLabel56.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel56.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.CanGrow = False
        Me.XrLabel56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Armor", "")})
        Me.XrLabel56.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel56.ForeColor = System.Drawing.Color.Black
        Me.XrLabel56.Location = New System.Drawing.Point(490, 198)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.Size = New System.Drawing.Size(234, 21)
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel56.WordWrap = False
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.White
        Me.XrLabel4.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.ArmorMaxDex", "")})
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel4.Location = New System.Drawing.Point(453, 180)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(270, 17)
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel64
        '
        Me.XrLabel64.BackColor = System.Drawing.Color.White
        Me.XrLabel64.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel64.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Speed", "")})
        Me.XrLabel64.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel64.ForeColor = System.Drawing.Color.Black
        Me.XrLabel64.Location = New System.Drawing.Point(490, 89)
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.Size = New System.Drawing.Size(67, 21)
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel64.WordWrap = False
        '
        'XrLabel59
        '
        Me.XrLabel59.BackColor = System.Drawing.Color.White
        Me.XrLabel59.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel59.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.BaseSpeedRun", "")})
        Me.XrLabel59.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel59.ForeColor = System.Drawing.Color.Black
        Me.XrLabel59.Location = New System.Drawing.Point(656, 89)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.Size = New System.Drawing.Size(67, 21)
        Me.XrLabel59.Text = "XrLabel59"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel59.WordWrap = False
        '
        'XrLabel65
        '
        Me.XrLabel65.BackColor = System.Drawing.Color.White
        Me.XrLabel65.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel65.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel65.CanGrow = False
        Me.XrLabel65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Deity", "")})
        Me.XrLabel65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel65.ForeColor = System.Drawing.Color.Black
        Me.XrLabel65.Location = New System.Drawing.Point(562, 57)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.Size = New System.Drawing.Size(162, 21)
        Me.XrLabel65.Text = "XrLabel9"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel65.WordWrap = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.White
        Me.XrLabel1.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Size", "")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.Location = New System.Drawing.Point(443, 57)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(68, 21)
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel1.WordWrap = False
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.White
        Me.XrLabel31.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel31.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Description", "")})
        Me.XrLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel31.ForeColor = System.Drawing.Color.Black
        Me.XrLabel31.Location = New System.Drawing.Point(182, 57)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.Size = New System.Drawing.Size(214, 21)
        Me.XrLabel31.Text = "XrLabel9"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel31.WordWrap = False
        '
        'Level
        '
        Me.Level.BackColor = System.Drawing.Color.White
        Me.Level.BorderColor = System.Drawing.Color.DimGray
        Me.Level.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Level.CanGrow = False
        Me.Level.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Level", "")})
        Me.Level.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level.ForeColor = System.Drawing.Color.Black
        Me.Level.Location = New System.Drawing.Point(167, 31)
        Me.Level.Name = "Level"
        Me.Level.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Level.Size = New System.Drawing.Size(57, 21)
        Me.Level.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Level.WordWrap = False
        '
        'Classes
        '
        Me.Classes.BackColor = System.Drawing.Color.White
        Me.Classes.BorderColor = System.Drawing.Color.DimGray
        Me.Classes.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Classes.CanGrow = False
        Me.Classes.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Classes", "")})
        Me.Classes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Classes.ForeColor = System.Drawing.Color.Black
        Me.Classes.Location = New System.Drawing.Point(286, 31)
        Me.Classes.Name = "Classes"
        Me.Classes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Classes.Size = New System.Drawing.Size(198, 21)
        Me.Classes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Classes.WordWrap = False
        '
        'XP
        '
        Me.XP.BackColor = System.Drawing.Color.White
        Me.XP.BorderColor = System.Drawing.Color.DimGray
        Me.XP.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XP.CanGrow = False
        Me.XP.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.XP", "")})
        Me.XP.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XP.ForeColor = System.Drawing.Color.Black
        Me.XP.Location = New System.Drawing.Point(526, 31)
        Me.XP.Name = "XP"
        Me.XP.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XP.Size = New System.Drawing.Size(63, 21)
        Me.XP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XP.WordWrap = False
        '
        'NextLevel
        '
        Me.NextLevel.BackColor = System.Drawing.Color.White
        Me.NextLevel.BorderColor = System.Drawing.Color.DimGray
        Me.NextLevel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.NextLevel.CanGrow = False
        Me.NextLevel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.NextLevel", "")})
        Me.NextLevel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.NextLevel.ForeColor = System.Drawing.Color.Black
        Me.NextLevel.Location = New System.Drawing.Point(661, 31)
        Me.NextLevel.Name = "NextLevel"
        Me.NextLevel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NextLevel.Size = New System.Drawing.Size(63, 21)
        Me.NextLevel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.NextLevel.WordWrap = False
        '
        'Alignment
        '
        Me.Alignment.BackColor = System.Drawing.Color.White
        Me.Alignment.BorderColor = System.Drawing.Color.DimGray
        Me.Alignment.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Alignment.CanGrow = False
        Me.Alignment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Alignment", "")})
        Me.Alignment.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alignment.ForeColor = System.Drawing.Color.Black
        Me.Alignment.Location = New System.Drawing.Point(620, 5)
        Me.Alignment.Name = "Alignment"
        Me.Alignment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Alignment.Size = New System.Drawing.Size(104, 21)
        Me.Alignment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Alignment.WordWrap = False
        '
        'Race
        '
        Me.Race.BackColor = System.Drawing.Color.White
        Me.Race.BorderColor = System.Drawing.Color.DimGray
        Me.Race.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Race.CanGrow = False
        Me.Race.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Race", "")})
        Me.Race.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Race.ForeColor = System.Drawing.Color.Black
        Me.Race.Location = New System.Drawing.Point(417, 5)
        Me.Race.Name = "Race"
        Me.Race.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Race.Size = New System.Drawing.Size(125, 21)
        Me.Race.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Race.WordWrap = False
        '
        'CharacterName
        '
        Me.CharacterName.BackColor = System.Drawing.Color.White
        Me.CharacterName.BorderColor = System.Drawing.Color.DimGray
        Me.CharacterName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.CharacterName.CanGrow = False
        Me.CharacterName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.CharacterName", "")})
        Me.CharacterName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterName.ForeColor = System.Drawing.Color.Black
        Me.CharacterName.Location = New System.Drawing.Point(167, 5)
        Me.CharacterName.Name = "CharacterName"
        Me.CharacterName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CharacterName.Size = New System.Drawing.Size(198, 21)
        Me.CharacterName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.CharacterName.WordWrap = False
        '
        'PsionicSpecializations
        '
        Me.PsionicSpecializations.Location = New System.Drawing.Point(0, 1302)
        Me.PsionicSpecializations.Name = "PsionicSpecializations"
        '
        'Powers
        '
        Me.Powers.Location = New System.Drawing.Point(0, 1385)
        Me.Powers.Name = "Powers"
        '
        'ManifestingNotes
        '
        Me.ManifestingNotes.Location = New System.Drawing.Point(0, 1344)
        Me.ManifestingNotes.Name = "ManifestingNotes"
        '
        'ManifesterBreak
        '
        Me.ManifesterBreak.Location = New System.Drawing.Point(0, 1214)
        Me.ManifesterBreak.Name = "ManifesterBreak"
        '
        'ManifestingModifiers
        '
        Me.ManifestingModifiers.Location = New System.Drawing.Point(0, 1260)
        Me.ManifestingModifiers.Name = "ManifestingModifiers"
        '
        'ManifesterLevels
        '
        Me.ManifesterLevels.Location = New System.Drawing.Point(0, 1219)
        Me.ManifesterLevels.Name = "ManifesterLevels"
        '
        'Modifiers
        '
        Me.Modifiers.Location = New System.Drawing.Point(0, 526)
        Me.Modifiers.Name = "Modifiers"
        '
        'CasterLevel
        '
        Me.CasterLevel.Location = New System.Drawing.Point(0, 969)
        Me.CasterLevel.Name = "CasterLevel"
        '
        'SpellcastingNotes
        '
        Me.SpellcastingNotes.Location = New System.Drawing.Point(0, 1135)
        Me.SpellcastingNotes.Name = "SpellcastingNotes"
        '
        'Domains
        '
        Me.Domains.Location = New System.Drawing.Point(0, 1094)
        Me.Domains.Name = "Domains"
        '
        'SpellcastingModifiers
        '
        Me.SpellcastingModifiers.Location = New System.Drawing.Point(0, 1010)
        Me.SpellcastingModifiers.Name = "SpellcastingModifiers"
        '
        'CasterBreak
        '
        Me.CasterBreak.Location = New System.Drawing.Point(0, 927)
        Me.CasterBreak.Name = "CasterBreak"
        '
        'ConditionalModifiers
        '
        Me.ConditionalModifiers.Location = New System.Drawing.Point(0, 490)
        Me.ConditionalModifiers.Name = "ConditionalModifiers"
        '
        'XrLabel98
        '
        Me.XrLabel98.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel98.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel98.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel98.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel98.ForeColor = System.Drawing.Color.White
        Me.XrLabel98.Location = New System.Drawing.Point(562, 89)
        Me.XrLabel98.Name = "XrLabel98"
        Me.XrLabel98.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel98.Size = New System.Drawing.Size(94, 21)
        Me.XrLabel98.Text = "Base Spd/Run"
        Me.XrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel68
        '
        Me.XrLabel68.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel68.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel68.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel68.ForeColor = System.Drawing.Color.White
        Me.XrLabel68.Location = New System.Drawing.Point(516, 57)
        Me.XrLabel68.Name = "XrLabel68"
        Me.XrLabel68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel68.Size = New System.Drawing.Size(46, 21)
        Me.XrLabel68.Text = "Deity"
        Me.XrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel61
        '
        Me.XrLabel61.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel61.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel61.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel61.ForeColor = System.Drawing.Color.White
        Me.XrLabel61.Location = New System.Drawing.Point(120, 57)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.Size = New System.Drawing.Size(63, 21)
        Me.XrLabel61.Text = "Physical"
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.BackColor = System.Drawing.Color.White
        Me.XrLabel20.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel20.ForeColor = System.Drawing.Color.Black
        Me.XrLabel20.Location = New System.Drawing.Point(526, 275)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.Size = New System.Drawing.Size(198, 21)
        Me.XrLabel20.Text = "Subdual:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SpellFailure
        '
        Me.SpellFailure.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ShieldSpellFailureBox, Me.ArmorSpellFailureBox, Me.ShieldSpellFailureLabel, Me.ArmorSpellFailureLabel})
        Me.SpellFailure.Location = New System.Drawing.Point(0, 932)
        Me.SpellFailure.Name = "SpellFailure"
        Me.SpellFailure.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.SpellFailure.Size = New System.Drawing.Size(729, 32)
        '
        'ShieldSpellFailureBox
        '
        Me.ShieldSpellFailureBox.BackColor = System.Drawing.Color.White
        Me.ShieldSpellFailureBox.BorderColor = System.Drawing.Color.DimGray
        Me.ShieldSpellFailureBox.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ShieldSpellFailureBox.CanGrow = False
        Me.ShieldSpellFailureBox.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.SpellFailureShield", "")})
        Me.ShieldSpellFailureBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ShieldSpellFailureBox.ForeColor = System.Drawing.Color.Black
        Me.ShieldSpellFailureBox.Location = New System.Drawing.Point(292, 5)
        Me.ShieldSpellFailureBox.Name = "ShieldSpellFailureBox"
        Me.ShieldSpellFailureBox.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ShieldSpellFailureBox.Size = New System.Drawing.Size(37, 21)
        Me.ShieldSpellFailureBox.Text = "XrLabel9"
        Me.ShieldSpellFailureBox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.ShieldSpellFailureBox.WordWrap = False
        '
        'ArmorSpellFailureBox
        '
        Me.ArmorSpellFailureBox.BackColor = System.Drawing.Color.White
        Me.ArmorSpellFailureBox.BorderColor = System.Drawing.Color.DimGray
        Me.ArmorSpellFailureBox.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ArmorSpellFailureBox.CanGrow = False
        Me.ArmorSpellFailureBox.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.SpellFailureArmor", "")})
        Me.ArmorSpellFailureBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArmorSpellFailureBox.ForeColor = System.Drawing.Color.Black
        Me.ArmorSpellFailureBox.Location = New System.Drawing.Point(125, 5)
        Me.ArmorSpellFailureBox.Name = "ArmorSpellFailureBox"
        Me.ArmorSpellFailureBox.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ArmorSpellFailureBox.Size = New System.Drawing.Size(37, 21)
        Me.ArmorSpellFailureBox.Text = "ArmorSpellFailureBox"
        Me.ArmorSpellFailureBox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.ArmorSpellFailureBox.WordWrap = False
        '
        'ShieldSpellFailureLabel
        '
        Me.ShieldSpellFailureLabel.BackColor = System.Drawing.Color.DimGray
        Me.ShieldSpellFailureLabel.BorderColor = System.Drawing.Color.DimGray
        Me.ShieldSpellFailureLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ShieldSpellFailureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ShieldSpellFailureLabel.ForeColor = System.Drawing.Color.White
        Me.ShieldSpellFailureLabel.Location = New System.Drawing.Point(172, 5)
        Me.ShieldSpellFailureLabel.Name = "ShieldSpellFailureLabel"
        Me.ShieldSpellFailureLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ShieldSpellFailureLabel.Size = New System.Drawing.Size(120, 21)
        Me.ShieldSpellFailureLabel.Text = "Shield Spell Failure"
        Me.ShieldSpellFailureLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ArmorSpellFailureLabel
        '
        Me.ArmorSpellFailureLabel.BackColor = System.Drawing.Color.DimGray
        Me.ArmorSpellFailureLabel.BorderColor = System.Drawing.Color.DimGray
        Me.ArmorSpellFailureLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ArmorSpellFailureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArmorSpellFailureLabel.ForeColor = System.Drawing.Color.White
        Me.ArmorSpellFailureLabel.Location = New System.Drawing.Point(5, 5)
        Me.ArmorSpellFailureLabel.Name = "ArmorSpellFailureLabel"
        Me.ArmorSpellFailureLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ArmorSpellFailureLabel.Size = New System.Drawing.Size(120, 21)
        Me.ArmorSpellFailureLabel.Text = "Armor Spell Failure"
        Me.ArmorSpellFailureLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Spells
        '
        Me.Spells.Location = New System.Drawing.Point(0, 1177)
        Me.Spells.Name = "Spells"
        '
        'SpellsPerDay
        '
        Me.SpellsPerDay.Location = New System.Drawing.Point(0, 1052)
        Me.SpellsPerDay.Name = "SpellsPerDay"
        '
        'XrPanel3
        '
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel23, Me.XrLabel96, Me.XrLabel92, Me.XrLabel88, Me.XrLabel89, Me.XrLabel87, Me.XrLabel93, Me.XrLabel86, Me.XrLabel90, Me.XrLabel85, Me.XrLabel24, Me.XrLabel95, Me.XrLabel15, Me.XrLabel94, Me.XrLabel82, Me.XrLabel91, Me.XrLabel84, Me.XrLabel83, Me.XrLabel80, Me.XrLabel76, Me.XrLabel13, Me.XrLabel19})
        Me.XrPanel3.Location = New System.Drawing.Point(0, 672)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPanel3.Size = New System.Drawing.Size(729, 105)
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.White
        Me.XrLabel23.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel23.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Money", "")})
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel23.ForeColor = System.Drawing.Color.Black
        Me.XrLabel23.Location = New System.Drawing.Point(57, 77)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.Size = New System.Drawing.Size(578, 22)
        Me.XrLabel23.Text = "XrLabel23"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel23.WordWrap = False
        '
        'XrLabel96
        '
        Me.XrLabel96.BackColor = System.Drawing.Color.White
        Me.XrLabel96.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel96.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel96.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.CoinWeight", "")})
        Me.XrLabel96.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.XrLabel96.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel96.Location = New System.Drawing.Point(635, 77)
        Me.XrLabel96.Name = "XrLabel96"
        Me.XrLabel96.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel96.Size = New System.Drawing.Size(89, 22)
        Me.XrLabel96.Text = "100 Coins = 2 lb."
        Me.XrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel92
        '
        Me.XrLabel92.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel92.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel92.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel92.CanGrow = False
        Me.XrLabel92.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.HeavyLoadRun", "")})
        Me.XrLabel92.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel92.ForeColor = System.Drawing.Color.Black
        Me.XrLabel92.Location = New System.Drawing.Point(661, 46)
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.Size = New System.Drawing.Size(62, 21)
        Me.XrLabel92.Text = "XrLabel86"
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel88
        '
        Me.XrLabel88.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel88.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel88.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel88.CanGrow = False
        Me.XrLabel88.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.MediumLoadRun", "")})
        Me.XrLabel88.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel88.ForeColor = System.Drawing.Color.Black
        Me.XrLabel88.Location = New System.Drawing.Point(661, 26)
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel88.Size = New System.Drawing.Size(62, 20)
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.Text = "XrLabel86"
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel89
        '
        Me.XrLabel89.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel89.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel89.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel89.CanGrow = False
        Me.XrLabel89.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.HeavyLoadSpeed", "")})
        Me.XrLabel89.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel89.ForeColor = System.Drawing.Color.Black
        Me.XrLabel89.Location = New System.Drawing.Point(600, 46)
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel89.Size = New System.Drawing.Size(62, 21)
        Me.XrLabel89.Text = "XrLabel86"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel87
        '
        Me.XrLabel87.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel87.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel87.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel87.CanGrow = False
        Me.XrLabel87.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.MediumLoadSpeed", "")})
        Me.XrLabel87.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel87.ForeColor = System.Drawing.Color.Black
        Me.XrLabel87.Location = New System.Drawing.Point(600, 26)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.Size = New System.Drawing.Size(62, 20)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.Text = "XrLabel86"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel93
        '
        Me.XrLabel93.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel93.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel93.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel93.CanGrow = False
        Me.XrLabel93.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.HeavyLoadCheckPenalty", "")})
        Me.XrLabel93.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel93.ForeColor = System.Drawing.Color.Black
        Me.XrLabel93.Location = New System.Drawing.Point(525, 46)
        Me.XrLabel93.Name = "XrLabel93"
        Me.XrLabel93.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel93.Size = New System.Drawing.Size(76, 21)
        Me.XrLabel93.Text = "XrLabel86"
        Me.XrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel86
        '
        Me.XrLabel86.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel86.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel86.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel86.CanGrow = False
        Me.XrLabel86.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.MediumLoadCheckPenalty", "")})
        Me.XrLabel86.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel86.ForeColor = System.Drawing.Color.Black
        Me.XrLabel86.Location = New System.Drawing.Point(525, 26)
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel86.Size = New System.Drawing.Size(76, 20)
        Me.XrLabel86.StylePriority.UseBorders = False
        Me.XrLabel86.Text = "XrLabel86"
        Me.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel90
        '
        Me.XrLabel90.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel90.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel90.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel90.CanGrow = False
        Me.XrLabel90.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.HeavyLoadMaxDex", "")})
        Me.XrLabel90.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel90.ForeColor = System.Drawing.Color.Black
        Me.XrLabel90.Location = New System.Drawing.Point(464, 46)
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.Size = New System.Drawing.Size(62, 21)
        Me.XrLabel90.Text = "XrLabel90"
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel85
        '
        Me.XrLabel85.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel85.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel85.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel85.CanGrow = False
        Me.XrLabel85.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.MediumLoadMaxDex", "")})
        Me.XrLabel85.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel85.ForeColor = System.Drawing.Color.Black
        Me.XrLabel85.Location = New System.Drawing.Point(464, 26)
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.Size = New System.Drawing.Size(62, 20)
        Me.XrLabel85.StylePriority.UseBorders = False
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.BackColor = System.Drawing.Color.White
        Me.XrLabel24.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel24.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.LoadInfo", "")})
        Me.XrLabel24.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel24.Location = New System.Drawing.Point(10, 3)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.Size = New System.Drawing.Size(448, 16)
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel95
        '
        Me.XrLabel95.BackColor = System.Drawing.Color.White
        Me.XrLabel95.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel95.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel95.CanGrow = False
        Me.XrLabel95.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.CurrentLoad", "")})
        Me.XrLabel95.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel95.ForeColor = System.Drawing.Color.Black
        Me.XrLabel95.Location = New System.Drawing.Point(57, 46)
        Me.XrLabel95.Name = "XrLabel95"
        Me.XrLabel95.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel95.Size = New System.Drawing.Size(313, 21)
        Me.XrLabel95.Text = "XrLabel95"
        Me.XrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel95.WordWrap = False
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.White
        Me.XrLabel15.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Weight", "")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.Location = New System.Drawing.Point(57, 26)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(313, 21)
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel15.WordWrap = False
        '
        'XrLabel94
        '
        Me.XrLabel94.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel94.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel94.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel94.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel94.ForeColor = System.Drawing.Color.White
        Me.XrLabel94.Location = New System.Drawing.Point(5, 46)
        Me.XrLabel94.Name = "XrLabel94"
        Me.XrLabel94.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel94.Size = New System.Drawing.Size(52, 21)
        Me.XrLabel94.Text = "Load"
        Me.XrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel82.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel82.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel82.CanGrow = False
        Me.XrLabel82.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel82.ForeColor = System.Drawing.Color.Black
        Me.XrLabel82.Location = New System.Drawing.Point(525, 8)
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.Size = New System.Drawing.Size(76, 21)
        Me.XrLabel82.Text = "Check Penalty"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel91
        '
        Me.XrLabel91.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel91.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel91.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel91.CanGrow = False
        Me.XrLabel91.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel91.ForeColor = System.Drawing.Color.Black
        Me.XrLabel91.Location = New System.Drawing.Point(381, 46)
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel91.Size = New System.Drawing.Size(85, 21)
        Me.XrLabel91.Text = "Heavy Load"
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel84
        '
        Me.XrLabel84.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel84.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel84.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel84.CanGrow = False
        Me.XrLabel84.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel84.ForeColor = System.Drawing.Color.Black
        Me.XrLabel84.Location = New System.Drawing.Point(661, 8)
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.Size = New System.Drawing.Size(62, 21)
        Me.XrLabel84.Text = "Run"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel83
        '
        Me.XrLabel83.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel83.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel83.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel83.CanGrow = False
        Me.XrLabel83.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel83.ForeColor = System.Drawing.Color.Black
        Me.XrLabel83.Location = New System.Drawing.Point(599, 8)
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.Size = New System.Drawing.Size(63, 21)
        Me.XrLabel83.Text = "Speed"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel80
        '
        Me.XrLabel80.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel80.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel80.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel80.CanGrow = False
        Me.XrLabel80.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel80.ForeColor = System.Drawing.Color.Black
        Me.XrLabel80.Location = New System.Drawing.Point(464, 8)
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.Size = New System.Drawing.Size(62, 21)
        Me.XrLabel80.Text = "Max DEX"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel76
        '
        Me.XrLabel76.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel76.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel76.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel76.CanGrow = False
        Me.XrLabel76.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel76.ForeColor = System.Drawing.Color.Black
        Me.XrLabel76.Location = New System.Drawing.Point(381, 26)
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel76.Size = New System.Drawing.Size(85, 21)
        Me.XrLabel76.Text = "Medium Load"
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel13.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel13.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel13.ForeColor = System.Drawing.Color.White
        Me.XrLabel13.Location = New System.Drawing.Point(5, 77)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(52, 22)
        Me.XrLabel13.Text = "Money"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel19.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel19.ForeColor = System.Drawing.Color.White
        Me.XrLabel19.Location = New System.Drawing.Point(5, 26)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.Size = New System.Drawing.Size(52, 21)
        Me.XrLabel19.Text = "Weight"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel2
        '
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel43, Me.XrLabel41})
        Me.XrPanel2.Location = New System.Drawing.Point(0, 885)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPanel2.Size = New System.Drawing.Size(729, 37)
        '
        'XrLabel43
        '
        Me.XrLabel43.BackColor = System.Drawing.Color.White
        Me.XrLabel43.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel43.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Background", "")})
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel43.ForeColor = System.Drawing.Color.Black
        Me.XrLabel43.Location = New System.Drawing.Point(5, 20)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.Size = New System.Drawing.Size(719, 15)
        Me.XrLabel43.Text = "XrLabel38"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel41
        '
        Me.XrLabel41.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel41.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel41.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel41.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel41.ForeColor = System.Drawing.Color.White
        Me.XrLabel41.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.Size = New System.Drawing.Size(719, 15)
        Me.XrLabel41.Text = " BACKGROUND"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel38, Me.XrLabel39})
        Me.XrPanel1.Location = New System.Drawing.Point(0, 844)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPanel1.Size = New System.Drawing.Size(729, 41)
        '
        'XrLabel38
        '
        Me.XrLabel38.BackColor = System.Drawing.Color.White
        Me.XrLabel38.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel38.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Notes", "")})
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel38.ForeColor = System.Drawing.Color.Black
        Me.XrLabel38.Location = New System.Drawing.Point(5, 20)
        Me.XrLabel38.Multiline = True
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.Size = New System.Drawing.Size(719, 15)
        Me.XrLabel38.Text = "XrLabel38"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel39.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel39.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel39.ForeColor = System.Drawing.Color.White
        Me.XrLabel39.Location = New System.Drawing.Point(5, 5)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.Size = New System.Drawing.Size(719, 15)
        Me.XrLabel39.Text = " NOTES"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel34.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel34.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel34.ForeColor = System.Drawing.Color.White
        Me.XrLabel34.Location = New System.Drawing.Point(5, 818)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.Size = New System.Drawing.Size(52, 21)
        Me.XrLabel34.Text = "Assets"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Assets
        '
        Me.Assets.Location = New System.Drawing.Point(0, 776)
        Me.Assets.Name = "Assets"
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel28.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel28.ForeColor = System.Drawing.Color.White
        Me.XrLabel28.Location = New System.Drawing.Point(5, 464)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.Size = New System.Drawing.Size(78, 21)
        Me.XrLabel28.Text = "Languages"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.BackColor = System.Drawing.Color.White
        Me.XrLabel27.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel27.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.Languages", "")})
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel27.ForeColor = System.Drawing.Color.Black
        Me.XrLabel27.Location = New System.Drawing.Point(83, 464)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.Size = New System.Drawing.Size(641, 21)
        Me.XrLabel27.Text = "XrLabel23"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel27.WordWrap = False
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.White
        Me.XrLabel6.BorderColor = System.Drawing.Color.Silver
        Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.Location = New System.Drawing.Point(57, 399)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(667, 21)
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel5.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.White
        Me.XrLabel5.Location = New System.Drawing.Point(5, 399)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(47, 21)
        Me.XrLabel5.Text = "Ammo"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Inventory
        '
        Me.Inventory.Location = New System.Drawing.Point(0, 635)
        Me.Inventory.Name = "Inventory"
        '
        'Features
        '
        Me.Features.Location = New System.Drawing.Point(0, 599)
        Me.Features.Name = "Features"
        '
        'Feats
        '
        Me.Feats.Location = New System.Drawing.Point(0, 562)
        Me.Feats.Name = "Feats"
        '
        'Skills
        '
        Me.Skills.Location = New System.Drawing.Point(0, 422)
        Me.Skills.Name = "Skills"
        '
        'Attacks
        '
        Me.Attacks.Location = New System.Drawing.Point(0, 365)
        Me.Attacks.Name = "Attacks"
        '
        'XrLabel49
        '
        Me.XrLabel49.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel49.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel49.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel49.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel49.ForeColor = System.Drawing.Color.White
        Me.XrLabel49.Location = New System.Drawing.Point(312, 208)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.Size = New System.Drawing.Size(63, 21)
        Me.XrLabel49.Text = "Helpless"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel58
        '
        Me.XrLabel58.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel58.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel58.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel58.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel58.ForeColor = System.Drawing.Color.White
        Me.XrLabel58.Location = New System.Drawing.Point(401, 57)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.Size = New System.Drawing.Size(43, 21)
        Me.XrLabel58.Text = "Size"
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel79
        '
        Me.XrLabel79.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel79.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel79.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel79.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel79.ForeColor = System.Drawing.Color.White
        Me.XrLabel79.Location = New System.Drawing.Point(411, 89)
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.Size = New System.Drawing.Size(79, 21)
        Me.XrLabel79.Text = "Speed/Run"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel22.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel22.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel22.ForeColor = System.Drawing.Color.White
        Me.XrLabel22.Location = New System.Drawing.Point(635, 135)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.Size = New System.Drawing.Size(42, 21)
        Me.XrLabel22.Text = "Will"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel21.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel21.ForeColor = System.Drawing.Color.White
        Me.XrLabel21.Location = New System.Drawing.Point(526, 135)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.Size = New System.Drawing.Size(57, 21)
        Me.XrLabel21.Text = "Reflex"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel77
        '
        Me.XrLabel77.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel77.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel77.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel77.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel77.ForeColor = System.Drawing.Color.White
        Me.XrLabel77.Location = New System.Drawing.Point(437, 266)
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel77.Size = New System.Drawing.Size(37, 21)
        Me.XrLabel77.Text = "HP"
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel71
        '
        Me.XrLabel71.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel71.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel71.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel71.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel71.ForeColor = System.Drawing.Color.White
        Me.XrLabel71.Location = New System.Drawing.Point(146, 275)
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel71.Size = New System.Drawing.Size(47, 21)
        Me.XrLabel71.Text = "Resist"
        Me.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel70
        '
        Me.XrLabel70.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel70.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel70.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel70.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel70.ForeColor = System.Drawing.Color.White
        Me.XrLabel70.Location = New System.Drawing.Point(146, 255)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.Size = New System.Drawing.Size(47, 21)
        Me.XrLabel70.Text = "DR"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel8.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.White
        Me.XrLabel8.Location = New System.Drawing.Point(5, 266)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(37, 21)
        Me.XrLabel8.Text = "SR/PR"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel54
        '
        Me.XrLabel54.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel54.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel54.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel54.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel54.ForeColor = System.Drawing.Color.White
        Me.XrLabel54.Location = New System.Drawing.Point(437, 218)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.Size = New System.Drawing.Size(54, 21)
        Me.XrLabel54.Text = "Shield"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel52
        '
        Me.XrLabel52.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel52.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel52.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel52.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel52.ForeColor = System.Drawing.Color.White
        Me.XrLabel52.Location = New System.Drawing.Point(437, 198)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.Size = New System.Drawing.Size(54, 21)
        Me.XrLabel52.Text = "Armor"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel37
        '
        Me.XrLabel37.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel37.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel37.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel37.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel37.ForeColor = System.Drawing.Color.White
        Me.XrLabel37.Location = New System.Drawing.Point(193, 208)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.Size = New System.Drawing.Size(68, 21)
        Me.XrLabel37.Text = "Flatfooted"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel30.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel30.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel30.ForeColor = System.Drawing.Color.White
        Me.XrLabel30.Location = New System.Drawing.Point(94, 208)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.Size = New System.Drawing.Size(47, 21)
        Me.XrLabel30.Text = "Touch"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel25.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel25.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel25.ForeColor = System.Drawing.Color.White
        Me.XrLabel25.Location = New System.Drawing.Point(5, 208)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.Size = New System.Drawing.Size(37, 21)
        Me.XrLabel25.Text = "AC"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel45
        '
        Me.XrLabel45.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel45.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel45.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel45.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel45.ForeColor = System.Drawing.Color.White
        Me.XrLabel45.Location = New System.Drawing.Point(594, 31)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.Size = New System.Drawing.Size(69, 21)
        Me.XrLabel45.Text = "Next Level"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'CHAMod
        '
        Me.CHAMod.BackColor = System.Drawing.Color.Transparent
        Me.CHAMod.BorderColor = System.Drawing.Color.DimGray
        Me.CHAMod.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.CHAMod.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.CHAMod", "")})
        Me.CHAMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHAMod.ForeColor = System.Drawing.Color.Black
        Me.CHAMod.Location = New System.Drawing.Point(354, 161)
        Me.CHAMod.Name = "CHAMod"
        Me.CHAMod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CHAMod.Size = New System.Drawing.Size(42, 21)
        Me.CHAMod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'WISMod
        '
        Me.WISMod.BackColor = System.Drawing.Color.Transparent
        Me.WISMod.BorderColor = System.Drawing.Color.DimGray
        Me.WISMod.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.WISMod.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.WISMod", "")})
        Me.WISMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WISMod.ForeColor = System.Drawing.Color.Black
        Me.WISMod.Location = New System.Drawing.Point(307, 161)
        Me.WISMod.Name = "WISMod"
        Me.WISMod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.WISMod.Size = New System.Drawing.Size(42, 21)
        Me.WISMod.Text = "+3"
        Me.WISMod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'INTMod
        '
        Me.INTMod.BackColor = System.Drawing.Color.Transparent
        Me.INTMod.BorderColor = System.Drawing.Color.DimGray
        Me.INTMod.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.INTMod.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.INTMod", "")})
        Me.INTMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INTMod.ForeColor = System.Drawing.Color.Black
        Me.INTMod.Location = New System.Drawing.Point(260, 161)
        Me.INTMod.Name = "INTMod"
        Me.INTMod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.INTMod.Size = New System.Drawing.Size(42, 21)
        Me.INTMod.Text = "+1"
        Me.INTMod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'CONMod
        '
        Me.CONMod.BackColor = System.Drawing.Color.Transparent
        Me.CONMod.BorderColor = System.Drawing.Color.DimGray
        Me.CONMod.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.CONMod.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.CONMod", "")})
        Me.CONMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONMod.ForeColor = System.Drawing.Color.Black
        Me.CONMod.Location = New System.Drawing.Point(214, 161)
        Me.CONMod.Name = "CONMod"
        Me.CONMod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CONMod.Size = New System.Drawing.Size(41, 21)
        Me.CONMod.Text = "+1"
        Me.CONMod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DEXMod
        '
        Me.DEXMod.BackColor = System.Drawing.Color.Transparent
        Me.DEXMod.BorderColor = System.Drawing.Color.DimGray
        Me.DEXMod.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DEXMod.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.DEXMod", "")})
        Me.DEXMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEXMod.ForeColor = System.Drawing.Color.Black
        Me.DEXMod.Location = New System.Drawing.Point(167, 161)
        Me.DEXMod.Name = "DEXMod"
        Me.DEXMod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DEXMod.Size = New System.Drawing.Size(41, 21)
        Me.DEXMod.Text = "+3"
        Me.DEXMod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'STRMod
        '
        Me.STRMod.BackColor = System.Drawing.Color.Transparent
        Me.STRMod.BorderColor = System.Drawing.Color.DimGray
        Me.STRMod.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.STRMod.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Character.STRMod", "")})
        Me.STRMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STRMod.ForeColor = System.Drawing.Color.Black
        Me.STRMod.Location = New System.Drawing.Point(120, 161)
        Me.STRMod.Name = "STRMod"
        Me.STRMod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.STRMod.Size = New System.Drawing.Size(41, 21)
        Me.STRMod.Text = "+2"
        Me.STRMod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel75
        '
        Me.XrLabel75.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel75.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel75.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel75.ForeColor = System.Drawing.Color.White
        Me.XrLabel75.Location = New System.Drawing.Point(469, 323)
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel75.Size = New System.Drawing.Size(57, 21)
        Me.XrLabel75.Text = "Grapple"
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel55
        '
        Me.XrLabel55.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel55.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel55.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel55.ForeColor = System.Drawing.Color.White
        Me.XrLabel55.Location = New System.Drawing.Point(120, 31)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.Size = New System.Drawing.Size(48, 21)
        Me.XrLabel55.Text = "Level"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel53.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel53.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel53.ForeColor = System.Drawing.Color.White
        Me.XrLabel53.Location = New System.Drawing.Point(120, 5)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.Size = New System.Drawing.Size(48, 21)
        Me.XrLabel53.Text = "Name"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Portrait
        '
        Me.Portrait.BorderColor = System.Drawing.Color.DimGray
        Me.Portrait.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Portrait.Location = New System.Drawing.Point(5, 5)
        Me.Portrait.Name = "Portrait"
        Me.Portrait.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Portrait.Size = New System.Drawing.Size(105, 155)
        Me.Portrait.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel51
        '
        Me.XrLabel51.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel51.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel51.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel51.ForeColor = System.Drawing.Color.White
        Me.XrLabel51.Location = New System.Drawing.Point(547, 5)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.Size = New System.Drawing.Size(74, 21)
        Me.XrLabel51.Text = "Alignment"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel48.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel48.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel48.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel48.ForeColor = System.Drawing.Color.White
        Me.XrLabel48.Location = New System.Drawing.Point(490, 31)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.Size = New System.Drawing.Size(37, 21)
        Me.XrLabel48.Text = "XP"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel47
        '
        Me.XrLabel47.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel47.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel47.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel47.ForeColor = System.Drawing.Color.White
        Me.XrLabel47.Location = New System.Drawing.Point(370, 5)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.Size = New System.Drawing.Size(48, 21)
        Me.XrLabel47.Text = "Race"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel44.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel44.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel44.ForeColor = System.Drawing.Color.White
        Me.XrLabel44.Location = New System.Drawing.Point(229, 31)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.Size = New System.Drawing.Size(59, 21)
        Me.XrLabel44.Text = "Classes"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel36
        '
        Me.XrLabel36.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel36.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel36.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.ForeColor = System.Drawing.Color.White
        Me.XrLabel36.Location = New System.Drawing.Point(359, 323)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.Size = New System.Drawing.Size(57, 21)
        Me.XrLabel36.Text = "Ranged"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel35
        '
        Me.XrLabel35.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel35.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel35.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.ForeColor = System.Drawing.Color.White
        Me.XrLabel35.Location = New System.Drawing.Point(5, 323)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.Size = New System.Drawing.Size(37, 21)
        Me.XrLabel35.Text = "BAB"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel32.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.ForeColor = System.Drawing.Color.White
        Me.XrLabel32.Location = New System.Drawing.Point(615, 323)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.Size = New System.Drawing.Size(62, 21)
        Me.XrLabel32.Text = "Initiative"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel197
        '
        Me.XrLabel197.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel197.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel197.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel197.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel197.ForeColor = System.Drawing.Color.White
        Me.XrLabel197.Location = New System.Drawing.Point(354, 89)
        Me.XrLabel197.Name = "XrLabel197"
        Me.XrLabel197.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel197.Size = New System.Drawing.Size(42, 21)
        Me.XrLabel197.Text = "CHA"
        Me.XrLabel197.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel196
        '
        Me.XrLabel196.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel196.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel196.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel196.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel196.ForeColor = System.Drawing.Color.White
        Me.XrLabel196.Location = New System.Drawing.Point(307, 89)
        Me.XrLabel196.Name = "XrLabel196"
        Me.XrLabel196.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel196.Size = New System.Drawing.Size(42, 21)
        Me.XrLabel196.Text = "WIS"
        Me.XrLabel196.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel195
        '
        Me.XrLabel195.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel195.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel195.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel195.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel195.ForeColor = System.Drawing.Color.White
        Me.XrLabel195.Location = New System.Drawing.Point(260, 89)
        Me.XrLabel195.Name = "XrLabel195"
        Me.XrLabel195.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel195.Size = New System.Drawing.Size(42, 21)
        Me.XrLabel195.Text = "INT"
        Me.XrLabel195.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel194
        '
        Me.XrLabel194.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel194.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel194.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel194.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel194.ForeColor = System.Drawing.Color.White
        Me.XrLabel194.Location = New System.Drawing.Point(214, 89)
        Me.XrLabel194.Name = "XrLabel194"
        Me.XrLabel194.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel194.Size = New System.Drawing.Size(41, 21)
        Me.XrLabel194.Text = "CON"
        Me.XrLabel194.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel193
        '
        Me.XrLabel193.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel193.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel193.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel193.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel193.ForeColor = System.Drawing.Color.White
        Me.XrLabel193.Location = New System.Drawing.Point(167, 89)
        Me.XrLabel193.Name = "XrLabel193"
        Me.XrLabel193.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel193.Size = New System.Drawing.Size(41, 21)
        Me.XrLabel193.Text = "DEX"
        Me.XrLabel193.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel192
        '
        Me.XrLabel192.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel192.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel192.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel192.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel192.ForeColor = System.Drawing.Color.White
        Me.XrLabel192.Location = New System.Drawing.Point(120, 89)
        Me.XrLabel192.Name = "XrLabel192"
        Me.XrLabel192.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel192.Size = New System.Drawing.Size(41, 21)
        Me.XrLabel192.Text = "STR"
        Me.XrLabel192.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel12.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.White
        Me.XrLabel12.Location = New System.Drawing.Point(260, 323)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(46, 21)
        Me.XrLabel12.Text = "Melee"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel2.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.Location = New System.Drawing.Point(411, 135)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(63, 21)
        Me.XrLabel2.Text = "Fortitude"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'CharacterDataset1
        '
        Me.CharacterDataset1.DataSetName = "CharacterDataset"
        Me.CharacterDataset1.EnforceConstraints = False
        Me.CharacterDataset1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CharacterDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrLabel101
        '
        Me.XrLabel101.BackColor = System.Drawing.Color.White
        Me.XrLabel101.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel101.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel101.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel101.ForeColor = System.Drawing.Color.Black
        Me.XrLabel101.Location = New System.Drawing.Point(5, 802)
        Me.XrLabel101.Name = "XrLabel101"
        Me.XrLabel101.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel101.Size = New System.Drawing.Size(73, 36)
        Me.XrLabel101.Text = "JUMP"
        Me.XrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel102
        '
        Me.XrLabel102.BackColor = System.Drawing.Color.White
        Me.XrLabel102.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel102.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel102.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel102.ForeColor = System.Drawing.Color.Black
        Me.XrLabel102.Location = New System.Drawing.Point(5, 802)
        Me.XrLabel102.Name = "XrLabel102"
        Me.XrLabel102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel102.Size = New System.Drawing.Size(73, 36)
        Me.XrLabel102.Text = "JUMP"
        Me.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel103
        '
        Me.XrLabel103.BackColor = System.Drawing.Color.White
        Me.XrLabel103.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel103.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel103.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel103.ForeColor = System.Drawing.Color.Black
        Me.XrLabel103.Location = New System.Drawing.Point(5, 802)
        Me.XrLabel103.Name = "XrLabel103"
        Me.XrLabel103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel103.Size = New System.Drawing.Size(73, 36)
        Me.XrLabel103.Text = "JUMP"
        Me.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.Location = New System.Drawing.Point(94, 411)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(42, 42)
        Me.XrLabel11.Text = "+5"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel42
        '
        Me.XrLabel42.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.ForeColor = System.Drawing.Color.Black
        Me.XrLabel42.Location = New System.Drawing.Point(94, 411)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel42.Size = New System.Drawing.Size(42, 42)
        Me.XrLabel42.Text = "+5"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel73
        '
        Me.XrLabel73.BorderColor = System.Drawing.Color.DimGray
        Me.XrLabel73.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel73.ForeColor = System.Drawing.Color.Black
        Me.XrLabel73.Location = New System.Drawing.Point(47, 328)
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel73.Size = New System.Drawing.Size(42, 42)
        Me.XrLabel73.Text = "0"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Location = New System.Drawing.Point(0, 0)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.Size = New System.Drawing.Size(729, 16)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Height = 33
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer39
        '
        Me.WinControlContainer39.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer39.Location = New System.Drawing.Point(682, 312)
        Me.WinControlContainer39.Name = "WinControlContainer39"
        Me.WinControlContainer39.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer39.WinControl = Me.Initiative
        '
        'Initiative
        '
        Me.Initiative.BackColor = System.Drawing.Color.White
        Me.Initiative.Location = New System.Drawing.Point(0, 0)
        Me.Initiative.Name = "Initiative"
        Me.Initiative.Size = New System.Drawing.Size(40, 40)
        Me.Initiative.TabIndex = 58
        '
        'WinControlContainer38
        '
        Me.WinControlContainer38.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer38.Location = New System.Drawing.Point(422, 312)
        Me.WinControlContainer38.Name = "WinControlContainer38"
        Me.WinControlContainer38.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer38.WinControl = Me.Ranged
        '
        'Ranged
        '
        Me.Ranged.BackColor = System.Drawing.Color.White
        Me.Ranged.Location = New System.Drawing.Point(0, 0)
        Me.Ranged.Name = "Ranged"
        Me.Ranged.Size = New System.Drawing.Size(40, 40)
        Me.Ranged.TabIndex = 57
        '
        'WinControlContainer37
        '
        Me.WinControlContainer37.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer37.Location = New System.Drawing.Point(146, 198)
        Me.WinControlContainer37.Name = "WinControlContainer37"
        Me.WinControlContainer37.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer37.WinControl = Me.ACTouch
        '
        'ACTouch
        '
        Me.ACTouch.BackColor = System.Drawing.Color.White
        Me.ACTouch.Location = New System.Drawing.Point(0, 0)
        Me.ACTouch.Name = "ACTouch"
        Me.ACTouch.Size = New System.Drawing.Size(40, 40)
        Me.ACTouch.TabIndex = 56
        '
        'WinControlContainer36
        '
        Me.WinControlContainer36.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer36.Location = New System.Drawing.Point(312, 312)
        Me.WinControlContainer36.Name = "WinControlContainer36"
        Me.WinControlContainer36.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer36.WinControl = Me.Melee
        '
        'Melee
        '
        Me.Melee.BackColor = System.Drawing.Color.White
        Me.Melee.Location = New System.Drawing.Point(0, 0)
        Me.Melee.Name = "Melee"
        Me.Melee.Size = New System.Drawing.Size(40, 40)
        Me.Melee.TabIndex = 55
        '
        'WinControlContainer35
        '
        Me.WinControlContainer35.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer35.Location = New System.Drawing.Point(531, 312)
        Me.WinControlContainer35.Name = "WinControlContainer35"
        Me.WinControlContainer35.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer35.WinControl = Me.Grapple
        '
        'Grapple
        '
        Me.Grapple.BackColor = System.Drawing.Color.White
        Me.Grapple.Location = New System.Drawing.Point(0, 0)
        Me.Grapple.Name = "Grapple"
        Me.Grapple.Size = New System.Drawing.Size(40, 40)
        Me.Grapple.TabIndex = 54
        '
        'WinControlContainer34
        '
        Me.WinControlContainer34.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer34.Location = New System.Drawing.Point(141, 312)
        Me.WinControlContainer34.Name = "WinControlContainer34"
        Me.WinControlContainer34.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer34.WinControl = Me.BAB3
        '
        'BAB3
        '
        Me.BAB3.BackColor = System.Drawing.Color.White
        Me.BAB3.Location = New System.Drawing.Point(0, 0)
        Me.BAB3.Name = "BAB3"
        Me.BAB3.Size = New System.Drawing.Size(40, 40)
        Me.BAB3.TabIndex = 53
        '
        'WinControlContainer9
        '
        Me.WinControlContainer9.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer9.Location = New System.Drawing.Point(47, 312)
        Me.WinControlContainer9.Name = "WinControlContainer9"
        Me.WinControlContainer9.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer9.WinControl = Me.BAB1
        '
        'BAB1
        '
        Me.BAB1.BackColor = System.Drawing.Color.White
        Me.BAB1.Location = New System.Drawing.Point(0, 0)
        Me.BAB1.Name = "BAB1"
        Me.BAB1.Size = New System.Drawing.Size(40, 40)
        Me.BAB1.TabIndex = 52
        '
        'WinControlContainer8
        '
        Me.WinControlContainer8.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer8.Location = New System.Drawing.Point(94, 312)
        Me.WinControlContainer8.Name = "WinControlContainer8"
        Me.WinControlContainer8.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer8.WinControl = Me.BAB2
        '
        'BAB2
        '
        Me.BAB2.BackColor = System.Drawing.Color.White
        Me.BAB2.Location = New System.Drawing.Point(0, 0)
        Me.BAB2.Name = "BAB2"
        Me.BAB2.Size = New System.Drawing.Size(40, 40)
        Me.BAB2.TabIndex = 51
        '
        'WinControlContainer7
        '
        Me.WinControlContainer7.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer7.Location = New System.Drawing.Point(188, 312)
        Me.WinControlContainer7.Name = "WinControlContainer7"
        Me.WinControlContainer7.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer7.WinControl = Me.BAB4
        '
        'BAB4
        '
        Me.BAB4.BackColor = System.Drawing.Color.White
        Me.BAB4.Location = New System.Drawing.Point(0, 0)
        Me.BAB4.Name = "BAB4"
        Me.BAB4.Size = New System.Drawing.Size(40, 40)
        Me.BAB4.TabIndex = 50
        '
        'WinControlContainer6
        '
        Me.WinControlContainer6.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer6.Location = New System.Drawing.Point(47, 198)
        Me.WinControlContainer6.Name = "WinControlContainer6"
        Me.WinControlContainer6.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer6.WinControl = Me.AC
        '
        'AC
        '
        Me.AC.BackColor = System.Drawing.Color.White
        Me.AC.Location = New System.Drawing.Point(0, 0)
        Me.AC.Name = "AC"
        Me.AC.Size = New System.Drawing.Size(40, 40)
        Me.AC.TabIndex = 49
        '
        'WinControlContainer33
        '
        Me.WinControlContainer33.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer33.Location = New System.Drawing.Point(479, 255)
        Me.WinControlContainer33.Name = "WinControlContainer33"
        Me.WinControlContainer33.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer33.WinControl = Me.HP
        '
        'HP
        '
        Me.HP.BackColor = System.Drawing.Color.White
        Me.HP.Location = New System.Drawing.Point(0, 0)
        Me.HP.Name = "HP"
        Me.HP.Size = New System.Drawing.Size(40, 40)
        Me.HP.TabIndex = 48
        '
        'WinControlContainer32
        '
        Me.WinControlContainer32.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer32.Location = New System.Drawing.Point(94, 255)
        Me.WinControlContainer32.Name = "WinControlContainer32"
        Me.WinControlContainer32.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer32.WinControl = Me.PR
        '
        'PR
        '
        Me.PR.BackColor = System.Drawing.Color.White
        Me.PR.Location = New System.Drawing.Point(0, 0)
        Me.PR.Name = "PR"
        Me.PR.Size = New System.Drawing.Size(40, 40)
        Me.PR.TabIndex = 47
        '
        'WinControlContainer31
        '
        Me.WinControlContainer31.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer31.Location = New System.Drawing.Point(214, 115)
        Me.WinControlContainer31.Name = "WinControlContainer31"
        Me.WinControlContainer31.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer31.WinControl = Me.CON
        '
        'CON
        '
        Me.CON.BackColor = System.Drawing.Color.White
        Me.CON.Location = New System.Drawing.Point(0, 0)
        Me.CON.Name = "CON"
        Me.CON.Size = New System.Drawing.Size(40, 40)
        Me.CON.TabIndex = 46
        '
        'WinControlContainer30
        '
        Me.WinControlContainer30.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer30.Location = New System.Drawing.Point(260, 115)
        Me.WinControlContainer30.Name = "WinControlContainer30"
        Me.WinControlContainer30.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer30.WinControl = Me.INT
        '
        'INT
        '
        Me.INT.BackColor = System.Drawing.Color.White
        Me.INT.Location = New System.Drawing.Point(0, 0)
        Me.INT.Name = "INT"
        Me.INT.Size = New System.Drawing.Size(40, 40)
        Me.INT.TabIndex = 45
        '
        'WinControlContainer29
        '
        Me.WinControlContainer29.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer29.Location = New System.Drawing.Point(266, 198)
        Me.WinControlContainer29.Name = "WinControlContainer29"
        Me.WinControlContainer29.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer29.WinControl = Me.ACFlatFooted
        '
        'ACFlatFooted
        '
        Me.ACFlatFooted.BackColor = System.Drawing.Color.White
        Me.ACFlatFooted.Location = New System.Drawing.Point(0, 0)
        Me.ACFlatFooted.Name = "ACFlatFooted"
        Me.ACFlatFooted.Size = New System.Drawing.Size(40, 40)
        Me.ACFlatFooted.TabIndex = 44
        '
        'WinControlContainer28
        '
        Me.WinControlContainer28.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer28.Location = New System.Drawing.Point(380, 198)
        Me.WinControlContainer28.Name = "WinControlContainer28"
        Me.WinControlContainer28.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer28.WinControl = Me.ACHelpless
        '
        'ACHelpless
        '
        Me.ACHelpless.BackColor = System.Drawing.Color.White
        Me.ACHelpless.Location = New System.Drawing.Point(0, 0)
        Me.ACHelpless.Name = "ACHelpless"
        Me.ACHelpless.Size = New System.Drawing.Size(40, 40)
        Me.ACHelpless.TabIndex = 43
        '
        'WinControlContainer27
        '
        Me.WinControlContainer27.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer27.Location = New System.Drawing.Point(47, 255)
        Me.WinControlContainer27.Name = "WinControlContainer27"
        Me.WinControlContainer27.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer27.WinControl = Me.SR
        '
        'SR
        '
        Me.SR.BackColor = System.Drawing.Color.White
        Me.SR.Location = New System.Drawing.Point(0, 0)
        Me.SR.Name = "SR"
        Me.SR.Size = New System.Drawing.Size(40, 40)
        Me.SR.TabIndex = 42
        '
        'WinControlContainer26
        '
        Me.WinControlContainer26.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer26.Location = New System.Drawing.Point(682, 125)
        Me.WinControlContainer26.Name = "WinControlContainer26"
        Me.WinControlContainer26.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer26.WinControl = Me.Will
        '
        'Will
        '
        Me.Will.BackColor = System.Drawing.Color.White
        Me.Will.Location = New System.Drawing.Point(0, 0)
        Me.Will.Name = "Will"
        Me.Will.Size = New System.Drawing.Size(40, 40)
        Me.Will.TabIndex = 41
        '
        'WinControlContainer23
        '
        Me.WinControlContainer23.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer23.Location = New System.Drawing.Point(589, 125)
        Me.WinControlContainer23.Name = "WinControlContainer23"
        Me.WinControlContainer23.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer23.WinControl = Me.Reflex
        '
        'Reflex
        '
        Me.Reflex.BackColor = System.Drawing.Color.White
        Me.Reflex.Location = New System.Drawing.Point(0, 0)
        Me.Reflex.Name = "Reflex"
        Me.Reflex.Size = New System.Drawing.Size(40, 40)
        Me.Reflex.TabIndex = 40
        '
        'WinControlContainer22
        '
        Me.WinControlContainer22.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer22.Location = New System.Drawing.Point(479, 125)
        Me.WinControlContainer22.Name = "WinControlContainer22"
        Me.WinControlContainer22.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer22.WinControl = Me.Fortitude
        '
        'Fortitude
        '
        Me.Fortitude.BackColor = System.Drawing.Color.White
        Me.Fortitude.Location = New System.Drawing.Point(0, 0)
        Me.Fortitude.Name = "Fortitude"
        Me.Fortitude.Size = New System.Drawing.Size(40, 40)
        Me.Fortitude.TabIndex = 39
        '
        'WinControlContainer5
        '
        Me.WinControlContainer5.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer5.Location = New System.Drawing.Point(354, 115)
        Me.WinControlContainer5.Name = "WinControlContainer5"
        Me.WinControlContainer5.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer5.WinControl = Me.CHA
        '
        'CHA
        '
        Me.CHA.BackColor = System.Drawing.Color.White
        Me.CHA.Location = New System.Drawing.Point(0, 0)
        Me.CHA.Name = "CHA"
        Me.CHA.Size = New System.Drawing.Size(40, 40)
        Me.CHA.TabIndex = 37
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer2.Location = New System.Drawing.Point(307, 115)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer2.WinControl = Me.WIS
        '
        'WIS
        '
        Me.WIS.BackColor = System.Drawing.Color.White
        Me.WIS.Location = New System.Drawing.Point(0, 0)
        Me.WIS.Name = "WIS"
        Me.WIS.Size = New System.Drawing.Size(40, 40)
        Me.WIS.TabIndex = 36
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer1.Location = New System.Drawing.Point(167, 115)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer1.WinControl = Me.DEX
        '
        'DEX
        '
        Me.DEX.BackColor = System.Drawing.Color.White
        Me.DEX.Location = New System.Drawing.Point(0, 0)
        Me.DEX.Name = "DEX"
        Me.DEX.Size = New System.Drawing.Size(40, 40)
        Me.DEX.TabIndex = 35
        '
        'WinControlContainer25
        '
        Me.WinControlContainer25.DrawMethod = DevExpress.XtraReports.UI.WinControlDrawMethod.UseWMPrint
        Me.WinControlContainer25.Location = New System.Drawing.Point(120, 115)
        Me.WinControlContainer25.Name = "WinControlContainer25"
        Me.WinControlContainer25.Size = New System.Drawing.Size(42, 42)
        Me.WinControlContainer25.WinControl = Me.STR
        '
        'STR
        '
        Me.STR.BackColor = System.Drawing.Color.White
        Me.STR.Location = New System.Drawing.Point(0, 0)
        Me.STR.Name = "STR"
        Me.STR.Size = New System.Drawing.Size(40, 40)
        Me.STR.TabIndex = 34
        '
        'CharacterSheet
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter})
        Me.DataMember = "Character"
        Me.DataSource = Me.CharacterDataset1
        Me.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        Me.Version = "8.1"
        CType(Me.CharacterDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    'member vars
    Private data As Rules.CharacterSheetData

    'property
    Public WriteOnly Property CharacterData() As Rules.CharacterSheetData
        Set(ByVal Value As Rules.CharacterSheetData)
            data = Value

            'CharacterDataset1 = data.CharacterData
            'Me.DataSource = CharacterDataset1

            'Me.RefreshDataBindings(data.CharacterData, Nothing, Nothing)
            'Me.DataSource = data.CharacterData

        End Set
    End Property

    Private Sub CharacterSheet_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            'Me.CharacterDataset1 = data.CharacterData
            'Me.RefreshDataBindings(data.CharacterData, Nothing, Nothing)
            'Me.DataSource = data.CharacterData

            'manual bindings
            Me.STR.DataBindings.Add("Text", DataSource, "Character.STR")
            Me.DEX.DataBindings.Add("Text", DataSource, "Character.DEX")
            Me.CON.DataBindings.Add("Text", DataSource, "Character.CON")
            Me.WIS.DataBindings.Add("Text", DataSource, "Character.WIS")
            Me.INT.DataBindings.Add("Text", DataSource, "Character.INT")
            Me.CHA.DataBindings.Add("Text", DataSource, "Character.CHA")

            Me.Reflex.DataBindings.Add("Text", DataSource, "Character.Reflex")
            Me.Fortitude.DataBindings.Add("Text", DataSource, "Character.Fortitude")
            Me.Will.DataBindings.Add("Text", DataSource, "Character.Will")

            Me.AC.DataBindings.Add("Text", DataSource, "Character.AC")
            Me.ACTouch.DataBindings.Add("Text", DataSource, "Character.ACTouch")
            Me.ACFlatFooted.DataBindings.Add("Text", DataSource, "Character.ACFlatfooted")
            Me.ACHelpless.DataBindings.Add("Text", DataSource, "Character.ACHelpless")

            Me.BAB1.DataBindings.Add("Text", DataSource, "Character.BAB1")
            Me.BAB2.DataBindings.Add("Text", DataSource, "Character.BAB2")
            Me.BAB3.DataBindings.Add("Text", DataSource, "Character.BAB3")
            Me.BAB4.DataBindings.Add("Text", DataSource, "Character.BAB4")
            Me.Melee.DataBindings.Add("Text", DataSource, "Character.Melee")
            Me.Ranged.DataBindings.Add("Text", DataSource, "Character.Ranged")
            Me.Grapple.DataBindings.Add("Text", DataSource, "Character.Grapple")

            Me.SR.DataBindings.Add("Text", DataSource, "Character.SR")
            Me.PR.DataBindings.Add("Text", DataSource, "Character.PR")

            Me.HP.DataBindings.Add("Text", DataSource, "Character.HP")
            Me.Initiative.DataBindings.Add("Text", DataSource, "Character.Initiative")

            'set portrait
            Dim Path As String = CType(data.CharacterData.Character.Rows(0), CharacterDataset.CharacterRow).Portrait
            If Path <> "" Then Me.Portrait.Image = New Bitmap(Path)

            'attacks
            Dim AttacksSubreport As New AttacksSubreport
            AttacksSubreport.Data = data.Attacks
            Me.Attacks.ReportSource = AttacksSubreport

            'skills
            Dim SkillsSubreport As New Skills
            SkillsSubreport.Data = data.Skills
            SkillsSubreport.CheckPenaltyString = data.CharacterData.Character.Rows(0).Item("ArmorCheckPenalty").ToString
            Me.Skills.ReportSource = SkillsSubreport

            'conditional modifiers
            Dim ConditionalModifiersSubreport As New ConditionalModifiers
            ConditionalModifiersSubreport.Data = data.ConditionalModifiers
            Me.ConditionalModifiers.ReportSource = ConditionalModifiersSubreport

            'modifiers
            Dim ModifiersSubreport As New Modifiers
            ModifiersSubreport.Data = data.Modifiers
            Me.Modifiers.ReportSource = ModifiersSubreport

            'feats
            Dim FeatsSubreport As New Feats
            FeatsSubreport.Data = data.Feats
            Me.Feats.ReportSource = FeatsSubreport

            'features
            Dim FeaturesSubreport As New Features
            FeaturesSubreport.Data = data.Features
            Me.Features.ReportSource = FeaturesSubreport

            'inventory
            Dim InventorySubreport As New Inventory
            InventorySubreport.Data = data.InventoryData
            Me.Inventory.ReportSource = InventorySubreport

            'assets
            Dim AssetsSubreport As New Assets
            AssetsSubreport.Data = data.AssetsData
            AssetsSubreport.ReportTitle = " ASSETS"
            Me.Assets.ReportSource = AssetsSubreport

            'any caster classes?
            Dim CasterLevelData As CasterLevelDataset = data.CasterLevel
            Dim Caster As Boolean = CasterLevelData.CasterLevel.Rows.Count > 0

            If Caster Then

                'caster level and spell points
                Dim CasterLevelReport As New CasterLevelSpellSave
                CasterLevelReport.data = CasterLevelData
                Me.CasterLevel.ReportSource = CasterLevelReport

                'spellcasting modifiers
                Dim SpellcastingModifiersReport As New SpellModifiers
                SpellcastingModifiersReport.data = data.SpellModifiers
                Me.SpellcastingModifiers.ReportSource = SpellcastingModifiersReport

                'spells per day
                Dim SPDSubreport As New SpellsPerDay
                SPDSubreport.Data = data.SpellsPerDayData
                Me.SpellsPerDay.ReportSource = SPDSubreport

                'domains
                Dim Domains As New DomainsSchools
                Domains.data = data.DomainsAndSchools
                Me.Domains.ReportSource = Domains

                'notes
                Dim SpellcastingNotes As New SpellNotes
                SpellcastingNotes.data = data.SpellNotes
                Me.SpellcastingNotes.ReportSource = SpellcastingNotes

                'spells
                Dim SpellsSubreport As New SpellBook
                SpellsSubreport.Data = data.Spells
                Me.Spells.ReportSource = SpellsSubreport
            Else
                Me.CasterBreak.Visible = False
                Me.CasterLevel.Visible = False
                Me.SpellcastingModifiers.Visible = False
                Me.SpellsPerDay.Visible = False
                Me.Domains.Visible = False
                Me.SpellcastingNotes.Visible = False
                Me.Spells.Visible = False
                Me.SpellFailure.Visible = False
            End If

            'any caster classes?
            Dim ManifesterLevelData As ManifesterLevelDataset = data.ManifesterLevel
            Dim Manifester As Boolean = ManifesterLevelData.ManifesterLevel.Rows.Count > 0

            If Manifester Then

                'caster level and spell points
                Dim ManifesterLevelsReport As New ManifesterLevelPowerSave
                ManifesterLevelsReport.data = ManifesterLevelData
                Me.ManifesterLevels.ReportSource = ManifesterLevelsReport

                'manifiesting modifiers
                Dim ManifestingModifiersReport As New PowerModifiers
                ManifestingModifiersReport.data = data.PowerModifiers
                Me.ManifestingModifiers.ReportSource = ManifestingModifiersReport

                'specializations
                Dim SpecializationsReport As New PsionicSpecializations
                SpecializationsReport.data = data.PsionicSpecializations
                Me.PsionicSpecializations.ReportSource = SpecializationsReport

                'notes
                Dim ManifestingNotesReport As New PowerNotes
                ManifestingNotesReport.data = data.PowerNotes
                Me.ManifestingNotes.ReportSource = ManifestingNotesReport

                'powers
                Dim PowersSubreport As New PowerBook
                PowersSubreport.Data = data.Powers
                Me.Powers.ReportSource = PowersSubreport

                'adjust positions
                If Not Caster Then
                    Dim Adjustment As Integer = Me.ManifesterBreak.Location.Y - Me.CasterBreak.Location.Y
                    Me.ManifesterBreak.Location = New Point(0, Me.ManifesterBreak.Location.Y - Adjustment)
                    Me.ManifesterLevels.Location = New Point(0, Me.ManifesterLevels.Location.Y - Adjustment)
                    Me.ManifestingModifiers.Location = New Point(0, Me.ManifestingModifiers.Location.Y - Adjustment)
                    Me.PsionicSpecializations.Location = New Point(0, Me.PsionicSpecializations.Location.Y - Adjustment)
                    Me.ManifestingNotes.Location = New Point(0, Me.ManifestingNotes.Location.Y - Adjustment)
                    Me.Powers.Location = New Point(0, Me.Powers.Location.Y - Adjustment)
                End If

            Else
                Me.ManifesterBreak.Visible = False
                Me.ManifesterLevels.Visible = False
                Me.ManifestingModifiers.Visible = False
                Me.PsionicSpecializations.Visible = False
                Me.ManifestingNotes.Visible = False
                Me.Powers.Visible = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
