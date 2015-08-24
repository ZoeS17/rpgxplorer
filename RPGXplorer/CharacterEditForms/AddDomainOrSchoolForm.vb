Option Explicit On 
Option Strict On

Imports RPGXplorer.General

Public Class AddDomainOrSchoolFrom
    Inherits System.Windows.Forms.Form

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
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents SkillLabel As System.Windows.Forms.Label
    Public WithEvents ClassCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents DomainSchoolCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents TypeLabel As System.Windows.Forms.Label
    Public WithEvents Level As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AddDomainOrSchoolFrom))
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.SkillLabel = New System.Windows.Forms.Label
        Me.ClassCombo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.TypeLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DomainSchoolCombo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.Level = New DevExpress.XtraEditors.SpinEdit
        CType(Me.ClassCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomainSchoolCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(197, 125)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 3
        Me.OK.Text = "OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(277, 125)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 110)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(332, 5)
        Me.IndentedLine2.TabIndex = 293
        Me.IndentedLine2.TabStop = False
        '
        'SkillLabel
        '
        Me.SkillLabel.Location = New System.Drawing.Point(15, 15)
        Me.SkillLabel.Name = "SkillLabel"
        Me.SkillLabel.Size = New System.Drawing.Size(120, 21)
        Me.SkillLabel.TabIndex = 295
        Me.SkillLabel.Text = "Class"
        Me.SkillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClassCombo
        '
        Me.ClassCombo.Location = New System.Drawing.Point(140, 15)
        Me.ClassCombo.Name = "ClassCombo"
        '
        'ClassCombo.Properties
        '
        Me.ClassCombo.Properties.AutoHeight = False
        Me.ClassCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClassCombo.Properties.DropDownRows = 10
        Me.ClassCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassCombo.Size = New System.Drawing.Size(200, 21)
        Me.ClassCombo.TabIndex = 0
        '
        'TypeLabel
        '
        Me.TypeLabel.Location = New System.Drawing.Point(15, 45)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(120, 21)
        Me.TypeLabel.TabIndex = 297
        Me.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "Level Taken"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DomainSchoolCombo
        '
        Me.DomainSchoolCombo.Enabled = False
        Me.DomainSchoolCombo.Location = New System.Drawing.Point(140, 45)
        Me.DomainSchoolCombo.Name = "DomainSchoolCombo"
        '
        'DomainSchoolCombo.Properties
        '
        Me.DomainSchoolCombo.Properties.AutoHeight = False
        Me.DomainSchoolCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DomainSchoolCombo.Properties.DropDownRows = 10
        Me.DomainSchoolCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DomainSchoolCombo.Size = New System.Drawing.Size(200, 21)
        Me.DomainSchoolCombo.TabIndex = 1
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'Level
        '
        Me.Level.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Level.Enabled = False
        Me.Level.Location = New System.Drawing.Point(140, 75)
        Me.Level.Name = "Level"
        '
        'Level.Properties
        '
        Me.Level.Properties.Appearance.Options.UseTextOptions = True
        Me.Level.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Level.Properties.AutoHeight = False
        Me.Level.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Level.Properties.IsFloatValue = False
        Me.Level.Properties.Mask.EditMask = "N00"
        Me.Level.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Level.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Level.Size = New System.Drawing.Size(50, 21)
        Me.Level.TabIndex = 301
        '
        'AddDomainOrSchoolFrom
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(359, 161)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DomainSchoolCombo)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.ClassCombo)
        Me.Controls.Add(Me.SkillLabel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.IndentedLine2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddDomainOrSchoolFrom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Domain"
        CType(Me.ClassCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomainSchoolCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'member variables
    Private _Character As Rules.Character
    Private _Type As String

    'indexes
    Private ClassIndex As DataListItem()
    Private DomainSchoolIndex As DataListItem()

    'init
    Public Function Init(ByVal Character As Rules.Character, ByVal Type As String) As Boolean
        Try
            _Character = Character
            _Type = Type

            'get spellcaster classes
            Dim CasterClasses As New Objects.ObjectDataCollection

            For Each ClassKey As Objects.ObjectKey In Character.CharacterClassKeys
                Dim CharacterClass As Rules.CharacterClass = Caches.GetCharacterClass(ClassKey)
                Select Case Type
                    Case Objects.DomainType
                        'can add domains to prestige casters
                        If CharacterClass.ClassObj.Element("CasterAbility") = "Yes" OrElse (CharacterClass.ClassObj.Element("CasterAbility") = "Prestige Advancement" AndAlso CharacterClass.ClassObj.Element("PrestigeSpellType") <> "") Then
                            CasterClasses.Add(CharacterClass.ClassObj)
                        End If

                    Case Objects.SpellSchoolSpecialistChoiceType, Objects.SpellSchoolProhibitedChoiceType
                        'can only add schools to normal casters
                        If CharacterClass.IsCaster Then CasterClasses.Add(CharacterClass.ClassObj)

                    Case Objects.PsionicSpecializationType
                        'can add domains to prestige casters
                        If CharacterClass.ClassObj.Element("CasterAbility") = "Psionic" OrElse (CharacterClass.ClassObj.Element("CasterAbility") = "Prestige Advancement" AndAlso CharacterClass.ClassObj.Element("AdvanceManifester") = "True") Then
                            CasterClasses.Add(CharacterClass.ClassObj)
                        End If
                End Select
            Next

            'add the racial caster
            If Character.IsRacialCaster Then
                If Not CasterClasses.Contains(Character.RacialCasterClass.ObjectGUID) Then
                    CasterClasses.Add(Character.RacialCasterClass)
                End If
            End If

            'set label
            Select Case Type
                Case Objects.DomainType
                    TypeLabel.Text = "Domain"
                Case Objects.SpellSchoolSpecialistChoiceType
                    TypeLabel.Text = "Specialist School"
                Case Objects.SpellSchoolProhibitedChoiceType
                    TypeLabel.Text = "Prohibited School"
                Case Objects.PsionicSpecializationType
                    TypeLabel.Text = "Psionic Specialization"

            End Select

            If Not CasterClasses Is Nothing Then
                'populate combos
                ClassIndex = Rules.Index.DataList(CasterClasses)
                ClassCombo.Properties.Items.AddRange(ClassIndex)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                'create the objects Objects.ObjectData
                Dim ClassDef As New Objects.ObjectData
                ClassDef.Load(CType(ClassCombo.SelectedItem, DataListItem).ObjectGUID)
                Select Case _Type

                    Case Objects.DomainType

                        Dim DomainDef As New Objects.ObjectData
                        DomainDef.Load(CType(DomainSchoolCombo.SelectedItem, DataListItem).ObjectGUID)

                        'saveobjects flag marks it to save feats and features from the domain
                        _Character.Domains.AddDomain(DomainDef, ClassDef, CInt(Level.Text), True)
                        _Character.Domains.Save()

                    Case Objects.SpellSchoolSpecialistChoiceType, Objects.SpellSchoolProhibitedChoiceType

                        Dim ChoiceTakenObject As New Objects.ObjectData
                        Dim SchoolDef As New Objects.ObjectData
                        SchoolDef.Load(CType(DomainSchoolCombo.SelectedItem, DataListItem).ObjectGUID)
                        ChoiceTakenObject.Name = SchoolDef.Name
                        ChoiceTakenObject.ParentGUID = _Character.MagicFolder.FirstChildOfType(Objects.DomainAndSchoolsFolderType).ObjectGUID

                        'set correct type
                        If _Type = Objects.SpellSchoolSpecialistChoiceType Then
                            ChoiceTakenObject.Type = Objects.SpellSchoolSpecialistChoiceType
                        Else
                            ChoiceTakenObject.Type = Objects.SpellSchoolProhibitedChoiceType
                        End If

                        ChoiceTakenObject.ObjectGUID = Objects.ObjectKey.NewGuid(_Character.CharacterObject.ObjectGUID.Database)
                        ChoiceTakenObject.FKElement("Class", ClassDef.Name, "Name", ClassDef.ObjectGUID)
                        ChoiceTakenObject.FKElement("School", SchoolDef.Name, "Name", SchoolDef.ObjectGUID)
                        ChoiceTakenObject.Element("LevelAcquired") = Level.Text
                        ChoiceTakenObject.HTMLGUID = SchoolDef.ObjectGUID
                        ChoiceTakenObject.Save()

                    Case Objects.PsionicSpecializationType
                        Dim SpecializationDef As New Objects.ObjectData
                        SpecializationDef.Load(CType(DomainSchoolCombo.SelectedItem, DataListItem).ObjectGUID)

                        _Character.PsionicSpecializations.AddSpecialization(SpecializationDef, ClassDef, CInt(Level.Text), True)
                        _Character.PsionicSpecializations.Save()

                End Select

                'refresh explorer and close
                CharacterManager.SetDirty(_Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Reload)

                'if it is a spell list syle caster - ask if they want top resync spells 
                Select Case _Type
                    Case Objects.DomainType
                        If ClassDef.Element("SpellAcquisition") = "List" Then
                            General.ShowInfoDialog("If you wish to synchronize this class's spells list, do so from the appropriate spell folder.")
                        End If

                    Case Objects.SpellSchoolSpecialistChoiceType
                        'we might have to regenerage the memorized slots
                        'General.MainExplorer.MemorizedSpellSlotsDirty = True


                End Select

                General.MainExplorer.RefreshPanel()
                Me.DialogResult = DialogResult.OK : Me.Close()

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'cancel
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel : Me.Close()
    End Sub

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Return General.ValidateForm(Me.Controls, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

#Region "Event Handlers"

    Private Sub ClassCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassCombo.SelectedIndexChanged
        Try
            Dim ClassKey As Objects.ObjectKey = CType(ClassCombo.SelectedItem, DataListItem).ObjectGUID

            Select Case _Type
                Case Objects.DomainType

                    'get the domains available for this class
                    DomainSchoolIndex = Rules.Index.DataList(_Character.Domains.AvailableDomains(ClassKey))
                    DomainSchoolCombo.Properties.Items.Clear()
                    DomainSchoolCombo.SelectedIndex = -1
                    DomainSchoolCombo.Properties.Items.AddRange(DomainSchoolIndex)
                    DomainSchoolCombo.Enabled = True

                Case Objects.SpellSchoolSpecialistChoiceType, Objects.SpellSchoolProhibitedChoiceType

                    'get the current schools
                    Dim CurrentSchools As New ArrayList
                    For Each Child As Objects.ObjectData In General.MainExplorer.ObjectSelectedInTree.Children
                        If Child.Type = Objects.SpellSchoolSpecialistChoiceType Or Child.Type = Objects.SpellSchoolProhibitedChoiceType Then
                            If Child.GetFKGuid("Class").Equals(ClassKey) Then
                                CurrentSchools.Add(Child.GetFKGuid("School"))
                            End If
                        End If
                    Next

                    DomainSchoolIndex = Rules.Index.DataListExclude(Objects.GetAllObjectsOfType(XML.DBTypes.SpellSchools, Objects.SpellSchoolType), CurrentSchools)
                    DomainSchoolCombo.Properties.Items.Clear()
                    DomainSchoolCombo.SelectedIndex = -1
                    DomainSchoolCombo.Properties.Items.AddRange(DomainSchoolIndex)
                    DomainSchoolCombo.Enabled = True

                Case Objects.PsionicSpecializationType
                    'get the specialization available for the selected class
                    DomainSchoolIndex = Rules.Index.DataList(_Character.PsionicSpecializations.AvailableSpecializations(ClassKey))
                    DomainSchoolCombo.Properties.Items.Clear()
                    DomainSchoolCombo.SelectedIndex = -1
                    DomainSchoolCombo.Properties.Items.AddRange(DomainSchoolIndex)
                    DomainSchoolCombo.Enabled = True

            End Select

            'get the levels available for this class
            Level.Properties.MinValue = _Character.LowestClassLevel(ClassKey)
            Level.Properties.MaxValue = _Character.CharacterLevel
            Level.Value = _Character.CharacterLevel
            Level.Enabled = True

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

End Class