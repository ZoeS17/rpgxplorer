Option Strict On
Option Explicit On

Imports RPGXplorer.General

Public Class AssignAbilityPoints
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
    Public WithEvents CHAMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents WISMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents INTMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents CONMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents DEXMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents STRMod As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents STREdit As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents DEXEdit As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents WISEdit As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents INTEdit As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents CONEdit As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents CHAEdit As DevExpress.XtraEditors.ButtonEdit
    Public WithEvents PointHistory As RPGXplorer.ListBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents AbilityPointsLabel As System.Windows.Forms.Label
    Public WithEvents RemoveLast As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ObjLabel = New System.Windows.Forms.Label
        Me.CHAMod = New RPGXplorer.ReadOnlyTextBox
        Me.WISMod = New RPGXplorer.ReadOnlyTextBox
        Me.INTMod = New RPGXplorer.ReadOnlyTextBox
        Me.CONMod = New RPGXplorer.ReadOnlyTextBox
        Me.DEXMod = New RPGXplorer.ReadOnlyTextBox
        Me.STRMod = New RPGXplorer.ReadOnlyTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.STREdit = New DevExpress.XtraEditors.ButtonEdit
        Me.DEXEdit = New DevExpress.XtraEditors.ButtonEdit
        Me.WISEdit = New DevExpress.XtraEditors.ButtonEdit
        Me.INTEdit = New DevExpress.XtraEditors.ButtonEdit
        Me.CONEdit = New DevExpress.XtraEditors.ButtonEdit
        Me.CHAEdit = New DevExpress.XtraEditors.ButtonEdit
        Me.PointHistory = New RPGXplorer.ListBox
        Me.AbilityPointsLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RemoveLast = New System.Windows.Forms.Button
        CType(Me.STREdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEXEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WISEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHAEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjLabel
        '
        Me.ObjLabel.BackColor = System.Drawing.Color.Transparent
        Me.ObjLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjLabel.Location = New System.Drawing.Point(15, 15)
        Me.ObjLabel.Name = "ObjLabel"
        Me.ObjLabel.Size = New System.Drawing.Size(190, 21)
        Me.ObjLabel.TabIndex = 94
        Me.ObjLabel.Text = "Please assign your ability point(s)"
        Me.ObjLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CHAMod
        '
        Me.CHAMod.BackColor = System.Drawing.Color.White
        Me.CHAMod.Caption = Nothing
        Me.CHAMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHAMod.DockPadding.All = 1
        Me.CHAMod.ForeColor = System.Drawing.Color.Black
        Me.CHAMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.CHAMod.Location = New System.Drawing.Point(110, 220)
        Me.CHAMod.Name = "CHAMod"
        Me.CHAMod.Size = New System.Drawing.Size(35, 21)
        Me.CHAMod.TabIndex = 291
        Me.CHAMod.TabStop = False
        Me.CHAMod.TextColor = System.Drawing.Color.Black
        Me.CHAMod.Vertical = False
        '
        'WISMod
        '
        Me.WISMod.BackColor = System.Drawing.Color.White
        Me.WISMod.Caption = Nothing
        Me.WISMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.WISMod.DockPadding.All = 1
        Me.WISMod.ForeColor = System.Drawing.Color.Black
        Me.WISMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.WISMod.Location = New System.Drawing.Point(110, 190)
        Me.WISMod.Name = "WISMod"
        Me.WISMod.Size = New System.Drawing.Size(35, 21)
        Me.WISMod.TabIndex = 290
        Me.WISMod.TabStop = False
        Me.WISMod.TextColor = System.Drawing.Color.Black
        Me.WISMod.Vertical = False
        '
        'INTMod
        '
        Me.INTMod.BackColor = System.Drawing.Color.White
        Me.INTMod.Caption = Nothing
        Me.INTMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.INTMod.DockPadding.All = 1
        Me.INTMod.ForeColor = System.Drawing.Color.Black
        Me.INTMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.INTMod.Location = New System.Drawing.Point(110, 160)
        Me.INTMod.Name = "INTMod"
        Me.INTMod.Size = New System.Drawing.Size(35, 21)
        Me.INTMod.TabIndex = 289
        Me.INTMod.TabStop = False
        Me.INTMod.TextColor = System.Drawing.Color.Black
        Me.INTMod.Vertical = False
        '
        'CONMod
        '
        Me.CONMod.BackColor = System.Drawing.Color.White
        Me.CONMod.Caption = Nothing
        Me.CONMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CONMod.DockPadding.All = 1
        Me.CONMod.ForeColor = System.Drawing.Color.Black
        Me.CONMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.CONMod.Location = New System.Drawing.Point(110, 130)
        Me.CONMod.Name = "CONMod"
        Me.CONMod.Size = New System.Drawing.Size(35, 21)
        Me.CONMod.TabIndex = 288
        Me.CONMod.TabStop = False
        Me.CONMod.TextColor = System.Drawing.Color.Black
        Me.CONMod.Vertical = False
        '
        'DEXMod
        '
        Me.DEXMod.BackColor = System.Drawing.Color.White
        Me.DEXMod.Caption = Nothing
        Me.DEXMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.DEXMod.DockPadding.All = 1
        Me.DEXMod.ForeColor = System.Drawing.Color.Black
        Me.DEXMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.DEXMod.Location = New System.Drawing.Point(110, 100)
        Me.DEXMod.Name = "DEXMod"
        Me.DEXMod.Size = New System.Drawing.Size(35, 21)
        Me.DEXMod.TabIndex = 287
        Me.DEXMod.TabStop = False
        Me.DEXMod.TextColor = System.Drawing.Color.Black
        Me.DEXMod.Vertical = False
        '
        'STRMod
        '
        Me.STRMod.BackColor = System.Drawing.Color.White
        Me.STRMod.Caption = Nothing
        Me.STRMod.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.STRMod.DockPadding.All = 1
        Me.STRMod.ForeColor = System.Drawing.Color.Black
        Me.STRMod.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.STRMod.Location = New System.Drawing.Point(110, 70)
        Me.STRMod.Name = "STRMod"
        Me.STRMod.Size = New System.Drawing.Size(35, 21)
        Me.STRMod.TabIndex = 286
        Me.STRMod.TabStop = False
        Me.STRMod.TextColor = System.Drawing.Color.Black
        Me.STRMod.Vertical = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 21)
        Me.Label5.TabIndex = 285
        Me.Label5.Text = "INT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 21)
        Me.Label6.TabIndex = 284
        Me.Label6.Text = "WIS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 21)
        Me.Label7.TabIndex = 283
        Me.Label7.Text = "CHA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 21)
        Me.Label8.TabIndex = 282
        Me.Label8.Text = "STR"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 21)
        Me.Label3.TabIndex = 281
        Me.Label3.Text = "DEX"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 21)
        Me.Label4.TabIndex = 280
        Me.Label4.Text = "CON"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'STREdit
        '
        Me.STREdit.EditValue = ""
        Me.STREdit.Location = New System.Drawing.Point(55, 70)
        Me.STREdit.Name = "STREdit"
        '
        'STREdit.Properties
        '
        Me.STREdit.Properties.Appearance.Options.UseTextOptions = True
        Me.STREdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.STREdit.Properties.AutoHeight = False
        Me.STREdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.STREdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.STREdit.Size = New System.Drawing.Size(50, 21)
        Me.STREdit.TabIndex = 0
        '
        'DEXEdit
        '
        Me.DEXEdit.EditValue = ""
        Me.DEXEdit.Location = New System.Drawing.Point(55, 100)
        Me.DEXEdit.Name = "DEXEdit"
        '
        'DEXEdit.Properties
        '
        Me.DEXEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.DEXEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DEXEdit.Properties.AutoHeight = False
        Me.DEXEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.DEXEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DEXEdit.Size = New System.Drawing.Size(50, 21)
        Me.DEXEdit.TabIndex = 1
        '
        'WISEdit
        '
        Me.WISEdit.EditValue = ""
        Me.WISEdit.Location = New System.Drawing.Point(55, 190)
        Me.WISEdit.Name = "WISEdit"
        '
        'WISEdit.Properties
        '
        Me.WISEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.WISEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WISEdit.Properties.AutoHeight = False
        Me.WISEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.WISEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.WISEdit.Size = New System.Drawing.Size(50, 21)
        Me.WISEdit.TabIndex = 4
        '
        'INTEdit
        '
        Me.INTEdit.EditValue = ""
        Me.INTEdit.Location = New System.Drawing.Point(55, 160)
        Me.INTEdit.Name = "INTEdit"
        '
        'INTEdit.Properties
        '
        Me.INTEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.INTEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.INTEdit.Properties.AutoHeight = False
        Me.INTEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.INTEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.INTEdit.Size = New System.Drawing.Size(50, 21)
        Me.INTEdit.TabIndex = 3
        '
        'CONEdit
        '
        Me.CONEdit.EditValue = ""
        Me.CONEdit.Location = New System.Drawing.Point(55, 130)
        Me.CONEdit.Name = "CONEdit"
        '
        'CONEdit.Properties
        '
        Me.CONEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CONEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CONEdit.Properties.AutoHeight = False
        Me.CONEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.CONEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CONEdit.Size = New System.Drawing.Size(50, 21)
        Me.CONEdit.TabIndex = 2
        '
        'CHAEdit
        '
        Me.CHAEdit.EditValue = ""
        Me.CHAEdit.Location = New System.Drawing.Point(55, 220)
        Me.CHAEdit.Name = "CHAEdit"
        '
        'CHAEdit.Properties
        '
        Me.CHAEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CHAEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CHAEdit.Properties.AutoHeight = False
        Me.CHAEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.CHAEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CHAEdit.Size = New System.Drawing.Size(50, 21)
        Me.CHAEdit.TabIndex = 5
        '
        'PointHistory
        '
        Me.PointHistory.Location = New System.Drawing.Point(180, 70)
        Me.PointHistory.Name = "PointHistory"
        Me.PointHistory.Size = New System.Drawing.Size(135, 170)
        Me.PointHistory.TabIndex = 292
        '
        'AbilityPointsLabel
        '
        Me.AbilityPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.AbilityPointsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbilityPointsLabel.Location = New System.Drawing.Point(15, 40)
        Me.AbilityPointsLabel.Name = "AbilityPointsLabel"
        Me.AbilityPointsLabel.Size = New System.Drawing.Size(190, 21)
        Me.AbilityPointsLabel.TabIndex = 293
        Me.AbilityPointsLabel.Text = "N points left to assign"
        Me.AbilityPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 21)
        Me.Label2.TabIndex = 294
        Me.Label2.Text = "Point Assignment History"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemoveLast
        '
        Me.RemoveLast.BackColor = System.Drawing.SystemColors.Control
        Me.RemoveLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RemoveLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveLast.Location = New System.Drawing.Point(180, 250)
        Me.RemoveLast.Name = "RemoveLast"
        Me.RemoveLast.Size = New System.Drawing.Size(100, 25)
        Me.RemoveLast.TabIndex = 295
        Me.RemoveLast.Text = "Remove Last"
        '
        'AssignAbilityPoints
        '
        Me.Controls.Add(Me.RemoveLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AbilityPointsLabel)
        Me.Controls.Add(Me.PointHistory)
        Me.Controls.Add(Me.CHAEdit)
        Me.Controls.Add(Me.CONEdit)
        Me.Controls.Add(Me.INTEdit)
        Me.Controls.Add(Me.WISEdit)
        Me.Controls.Add(Me.DEXEdit)
        Me.Controls.Add(Me.STREdit)
        Me.Controls.Add(Me.CHAMod)
        Me.Controls.Add(Me.WISMod)
        Me.Controls.Add(Me.INTMod)
        Me.Controls.Add(Me.CONMod)
        Me.Controls.Add(Me.DEXMod)
        Me.Controls.Add(Me.STRMod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ObjLabel)
        Me.Name = "AssignAbilityPoints"
        CType(Me.STREdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEXEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WISEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHAEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panel variables
    Private IsInitialised As Boolean
    Private PointsAvailable, LevelsToAdd, PointLevel As Integer
    Private AbilityPointLevels, mPointAssignments As ArrayList
    Private AbilityScores As New Hashtable(6)

    Private LevelMapTable As New Hashtable

#End Region

#Region "Properties"

    Public ReadOnly Property PointAssignments() As Hashtable
        Get
            If mPointAssignments Is Nothing Then Return New Hashtable(0)

            Dim Assignment As LevellingUpWizard.PointAssignment
            Dim Temp As Hashtable

            Temp = New Hashtable(mPointAssignments.Count)

            For Each Assignment In mPointAssignments
                Temp.Add(Assignment.Level, Assignment)
            Next

            Return Temp
        End Get
    End Property

#End Region

    'initialise this panel
    Public Sub Init(ByVal ExistingCharacter As Rules.Character, ByVal LevelsToAdd As Integer)
        Try
            IsInitialised = True
            Me.LevelsToAdd = LevelsToAdd

            PointHistory.Clear()
            PointHistory.List.SortOrder = SortOrder.None
            PointHistory.List.SelectionMode = SelectionMode.None
            PointHistory.List.SelectedIndex = -1
            PointHistory.Refresh()

            'SHOULD NOT NEED THIS AS IT IS WORKED OUT IN PANELREQUIRED
            'get the levels at which ability points are added
            'AbilityPointLevels = Rules.ExperienceAndLevelling.AbilityPointLevels(ExistingCharacter, LevelsToAdd)

            mPointAssignments = New ArrayList
            PointsAvailable = AbilityPointLevels.Count
            PointLevel = 0
            UpdateLabel()

            'set the ability scores to their values prior to levelling
            Dim CharacterObject As Objects.ObjectData = ExistingCharacter.CharacterObject
            AbilityScores("STR") = ExistingCharacter.CurrentLevel.STR()
            AbilityScores("DEX") = ExistingCharacter.CurrentLevel.DEX()
            AbilityScores("CON") = ExistingCharacter.CurrentLevel.CON()
            AbilityScores("INT") = ExistingCharacter.CurrentLevel.INT()
            AbilityScores("WIS") = ExistingCharacter.CurrentLevel.WIS()
            AbilityScores("CHA") = ExistingCharacter.CurrentLevel.CHA()

            UpdateEditors()
            UpdateModifiers()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'is the panel required
    Public Function PanelRequired(ByVal ExistingCharacter As Rules.Character, ByVal LevelsToAdd As Integer, ByVal LevelRanges As LevellingUpWizard.LevelRangeCollection) As Boolean

        'get the levels at which ability points are added
        Select Case ExistingCharacter.CharacterType
            Case Rules.Character.CharacterObjectType.Character
                AbilityPointLevels = Rules.ExperienceAndLevelling.AbilityPointLevels(ExistingCharacter, LevelsToAdd)
                If AbilityPointLevels.Count = 0 Then Return False Else Return True

            Case Rules.Character.CharacterObjectType.Monster

                'we already have ability points from type levels
                If ExistingCharacter.CharacterLevel = 0 Then
                    Dim StartHitDice As Integer = Math.Max(CInt(ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")), 1)
                    AbilityPointLevels = Rules.ExperienceAndLevelling.AbilityPointLevels(StartHitDice, (LevelsToAdd - StartHitDice))
                    If AbilityPointLevels.Count = 0 Then Return False Else Return True
                End If

            Case Rules.Character.CharacterObjectType.AnimalCompanion, Rules.Character.CharacterObjectType.SpecialMount
                'need the current effective level and the number of effective levels we are adding
                AbilityPointLevels = New ArrayList

                'find the starting point
                Dim ClassHitDice As Integer
                Dim StartHitDice As Integer = ExistingCharacter.HitDice

                'if we dont have any yet, start after the racial hit dice, 
                If StartHitDice = 0 Then
                    StartHitDice = Math.Max(CInt(ExistingCharacter.RaceObject.ElementAsNumber("DiceNumber")), 1)
                End If

                Dim EndHitDice As Integer = StartHitDice

                'get the number of hit dice we are adding
                Dim LevelRange As LevellingUpWizard.LevelRange = CType(LevelRanges.LevelRanges.Item(0), LevellingUpWizard.LevelRange)
                Dim AnimalClass As Rules.CharacterClass = Caches.GetCharacterClass(LevelRange.ClassTaken.ObjectGUID)

                'i is the class level count
                For i As Integer = LevelRange.StartClassLevel To (LevelRange.StartClassLevel + LevelRange.LevelsAdded) - 1
                    ClassHitDice = AnimalClass.ClassLevel(i).ElementAsInteger("HitDice")

                    If ClassHitDice > 0 Then
                        'j is the count of hitdice from this class level 
                        For j As Integer = 1 To ClassHitDice
                            EndHitDice += 1
                            'LevelMapTable.Item(EndHitDice) = (LevelRange.StartCharacterLevel + i) - 1
                            LevelMapTable.Item(EndHitDice) = i + (LevelRange.StartCharacterLevel - LevelRange.StartClassLevel)
                        Next
                    End If
                Next

                Dim HitPointLevel As ArrayList = Rules.ExperienceAndLevelling.AbilityPointLevels(StartHitDice, (EndHitDice - StartHitDice))

                For Each i As Integer In HitPointLevel
                    AbilityPointLevels.Add(LevelMapTable(i))
                Next

                If AbilityPointLevels.Count = 0 Then Return False Else Return True

            Case Rules.Character.CharacterObjectType.Familiar
                Return False

        End Select
    End Function

#Region "IWizardPanel"

    'events
    Public Event EnableNext(ByVal FirstPanel As Boolean) Implements IWizardPanel.EnableNext
    Public Event DisableNext() Implements IWizardPanel.DisableNext

    Public ReadOnly Property IsFirstTab() As Boolean Implements IWizardPanel.IsFirstTab
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property Initialised() As Boolean Implements IWizardPanel.Initialised
        Get
            Return IsInitialised
        End Get
    End Property

    Public Shadows ReadOnly Property Width() As Integer Implements IWizardPanel.Width
        Get
            Return 500
        End Get
    End Property

    Public Shadows ReadOnly Property Height() As Integer Implements IWizardPanel.Height
        Get
            Return 500
        End Get
    End Property

    Public Sub InitPanel() Implements IWizardPanel.InitPanel
        If PointsAvailable = 0 Then RaiseEvent EnableNext(False)
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub STREdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles STREdit.ButtonClick
        Try
            If AssignPoint("STR") Then
                AbilityScores("STR") = CInt(AbilityScores("STR")) + 1
                STREdit.EditValue = CInt(AbilityScores("STR"))
                UpdateModifiers()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub DEXEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles DEXEdit.ButtonClick
        Try
            If AssignPoint("DEX") Then
                AbilityScores("DEX") = CInt(AbilityScores("DEX")) + 1
                DEXEdit.EditValue = CInt(AbilityScores("DEX"))
                UpdateModifiers()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub CONEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CONEdit.ButtonClick
        Try
            If AssignPoint("CON") Then
                AbilityScores("CON") = CInt(AbilityScores("CON")) + 1
                CONEdit.EditValue = CInt(AbilityScores("CON"))
                UpdateModifiers()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub INTEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles INTEdit.ButtonClick
        Try
            If AssignPoint("INT") Then
                AbilityScores("INT") = CInt(AbilityScores("INT")) + 1
                INTEdit.EditValue = CInt(AbilityScores("INT"))
                UpdateModifiers()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub WISEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles WISEdit.ButtonClick
        Try
            If AssignPoint("WIS") Then
                AbilityScores("WIS") = CInt(AbilityScores("WIS")) + 1
                WISEdit.EditValue = CInt(AbilityScores("WIS"))
                UpdateModifiers()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub CHAEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CHAEdit.ButtonClick
        Try
            If AssignPoint("CHA") Then
                AbilityScores("CHA") = CInt(AbilityScores("CHA")) + 1
                CHAEdit.EditValue = CInt(AbilityScores("CHA"))
                UpdateModifiers()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub RemoveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveLast.Click
        Try
            DeassignPoint()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Helper Functions"

    'assign a point
    Public Function AssignPoint(ByVal Ability As String) As Boolean
        Dim Assignment As LevellingUpWizard.PointAssignment

        Try
            If PointsAvailable > 0 Then
                Assignment.AbilityRaised = Ability
                Assignment.Level = CInt(AbilityPointLevels(PointLevel))
                PointHistory.AddItem("Level " & Assignment.Level.ToString & " - " & Ability & " +1", Assignment)
                PointHistory.List.SelectedIndex = -1
                mPointAssignments.Add(Assignment)
                PointsAvailable -= 1
                If PointsAvailable = 0 Then RaiseEvent EnableNext(False)
                PointLevel += 1
                UpdateLabel()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'deassign point
    Public Sub DeassignPoint()
        Dim Assignment As LevellingUpWizard.PointAssignment

        Try
            If PointHistory.Count > 0 Then
                Assignment = CType(mPointAssignments(PointLevel - 1), LevellingUpWizard.PointAssignment)
                AbilityScores(Assignment.AbilityRaised) = CInt(AbilityScores(Assignment.AbilityRaised)) - 1
                PointsAvailable += 1
                RaiseEvent DisableNext()
                PointLevel -= 1
                mPointAssignments.RemoveAt(PointLevel)
                UpdateEditors()
                UpdateModifiers()
                UpdateLabel()
                PointHistory.RemoveItem(PointHistory.Count - 1)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'refresh the modifier colours and values
    Private Sub UpdateModifiers()
        Dim Modifier As Integer

        Try
            'strength
            Modifier = Rules.AbilityScores.AbilityScore(CInt(AbilityScores("STR"))).Modifier
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

            'dexterity
            Modifier = Rules.AbilityScores.AbilityScore(CInt(AbilityScores("DEX"))).Modifier
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

            'constitution
            Modifier = Rules.AbilityScores.AbilityScore(CInt(AbilityScores("CON"))).Modifier
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

            'intelligence
            Modifier = Rules.AbilityScores.AbilityScore(CInt(AbilityScores("INT"))).Modifier
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

            'wisdom
            Modifier = Rules.AbilityScores.AbilityScore(CInt(AbilityScores("WIS"))).Modifier
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
            Modifier = Rules.AbilityScores.AbilityScore(CInt(AbilityScores("CHA"))).Modifier
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
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update the editors
    Private Sub UpdateEditors()
        Try
            STREdit.EditValue = CInt(AbilityScores("STR"))
            DEXEdit.EditValue = CInt(AbilityScores("DEX"))
            CONEdit.EditValue = CInt(AbilityScores("CON"))
            INTEdit.EditValue = CInt(AbilityScores("INT"))
            WISEdit.EditValue = CInt(AbilityScores("WIS"))
            CHAEdit.EditValue = CInt(AbilityScores("CHA"))
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update label
    Private Sub UpdateLabel()
        Try
            AbilityPointsLabel.Text = PointsAvailable.ToString & " points left to assign"
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class
