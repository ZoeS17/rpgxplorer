Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class ClassLevelForm
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
    Public WithEvents Cancel As System.Windows.Forms.Button
    Public WithEvents OK As System.Windows.Forms.Button
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents ClassLevel As DevExpress.XtraEditors.TextEdit
    Public WithEvents WillBonus As RPGXplorer.Modifier
    Public WithEvents ReflexBonus As RPGXplorer.Modifier
    Public WithEvents FortitudeBonus As RPGXplorer.Modifier
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents PropertiesTab As RPGXplorer.PropertiesTab
    Public WithEvents BAB As RPGXplorer.Modifier
    Public WithEvents HitdiceLabel As System.Windows.Forms.Label
    Public WithEvents HitDiceLine As RPGXplorer.IndentedLine
    Public WithEvents ClassTab As System.Windows.Forms.TabPage
    Public WithEvents HitDice As RPGXplorer.Modifier
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ClassTab = New System.Windows.Forms.TabPage
        Me.HitDice = New RPGXplorer.Modifier
        Me.HitdiceLabel = New System.Windows.Forms.Label
        Me.HitDiceLine = New RPGXplorer.IndentedLine
        Me.BAB = New RPGXplorer.Modifier
        Me.WillBonus = New RPGXplorer.Modifier
        Me.ReflexBonus = New RPGXplorer.Modifier
        Me.FortitudeBonus = New RPGXplorer.Modifier
        Me.ClassLevel = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PropertiesTab = New RPGXplorer.PropertiesTab
        Me.TabControl1.SuspendLayout()
        Me.ClassTab.SuspendLayout()
        CType(Me.ClassLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(360, 405)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(280, 405)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ClassTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 375)
        Me.TabControl1.TabIndex = 0
        '
        'ClassTab
        '
        Me.ClassTab.Controls.Add(Me.HitDice)
        Me.ClassTab.Controls.Add(Me.HitdiceLabel)
        Me.ClassTab.Controls.Add(Me.HitDiceLine)
        Me.ClassTab.Controls.Add(Me.BAB)
        Me.ClassTab.Controls.Add(Me.WillBonus)
        Me.ClassTab.Controls.Add(Me.ReflexBonus)
        Me.ClassTab.Controls.Add(Me.FortitudeBonus)
        Me.ClassTab.Controls.Add(Me.ClassLevel)
        Me.ClassTab.Controls.Add(Me.Label4)
        Me.ClassTab.Controls.Add(Me.Label2)
        Me.ClassTab.Controls.Add(Me.Label1)
        Me.ClassTab.Controls.Add(Me.IndentedLine3)
        Me.ClassTab.Controls.Add(Me.IndentedLine1)
        Me.ClassTab.Controls.Add(Me.Label3)
        Me.ClassTab.Controls.Add(Me.Label11)
        Me.ClassTab.Location = New System.Drawing.Point(4, 22)
        Me.ClassTab.Name = "ClassTab"
        Me.ClassTab.Size = New System.Drawing.Size(407, 349)
        Me.ClassTab.TabIndex = 0
        Me.ClassTab.Text = "Class Level"
        '
        'HitDice
        '
        Me.HitDice.Location = New System.Drawing.Point(135, 225)
        Me.HitDice.Name = "HitDice"
        Me.HitDice.Size = New System.Drawing.Size(66, 21)
        Me.HitDice.TabIndex = 137
        Me.HitDice.Visible = False
        '
        'HitdiceLabel
        '
        Me.HitdiceLabel.BackColor = System.Drawing.SystemColors.Control
        Me.HitdiceLabel.Location = New System.Drawing.Point(15, 225)
        Me.HitdiceLabel.Name = "HitdiceLabel"
        Me.HitdiceLabel.Size = New System.Drawing.Size(115, 21)
        Me.HitdiceLabel.TabIndex = 135
        Me.HitdiceLabel.Text = "Bonus Hit Dice"
        Me.HitdiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HitdiceLabel.Visible = False
        '
        'HitDiceLine
        '
        Me.HitDiceLine.Location = New System.Drawing.Point(16, 210)
        Me.HitDiceLine.Name = "HitDiceLine"
        Me.HitDiceLine.Size = New System.Drawing.Size(375, 5)
        Me.HitDiceLine.TabIndex = 133
        Me.HitDiceLine.TabStop = False
        Me.HitDiceLine.Visible = False
        '
        'BAB
        '
        Me.BAB.Location = New System.Drawing.Point(135, 65)
        Me.BAB.Name = "BAB"
        Me.BAB.Size = New System.Drawing.Size(66, 21)
        Me.BAB.TabIndex = 1
        '
        'WillBonus
        '
        Me.WillBonus.Location = New System.Drawing.Point(135, 175)
        Me.WillBonus.Name = "WillBonus"
        Me.WillBonus.Size = New System.Drawing.Size(66, 21)
        Me.WillBonus.TabIndex = 7
        '
        'ReflexBonus
        '
        Me.ReflexBonus.Location = New System.Drawing.Point(135, 145)
        Me.ReflexBonus.Name = "ReflexBonus"
        Me.ReflexBonus.Size = New System.Drawing.Size(66, 21)
        Me.ReflexBonus.TabIndex = 6
        '
        'FortitudeBonus
        '
        Me.FortitudeBonus.Location = New System.Drawing.Point(135, 115)
        Me.FortitudeBonus.Name = "FortitudeBonus"
        Me.FortitudeBonus.Size = New System.Drawing.Size(66, 21)
        Me.FortitudeBonus.TabIndex = 5
        '
        'ClassLevel
        '
        Me.ClassLevel.Location = New System.Drawing.Point(60, 15)
        Me.ClassLevel.Name = "ClassLevel"
        '
        'ClassLevel.Properties
        '
        Me.ClassLevel.Properties.Appearance.Options.UseTextOptions = True
        Me.ClassLevel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ClassLevel.Properties.AutoHeight = False
        Me.ClassLevel.Properties.MaxLength = 50
        Me.ClassLevel.Properties.ReadOnly = True
        Me.ClassLevel.Size = New System.Drawing.Size(40, 21)
        Me.ClassLevel.TabIndex = 0
        Me.ClassLevel.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Base Attack Bonus"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Will Save Bonus"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Reflex Save Bonus"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 100)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine3.TabIndex = 122
        Me.IndentedLine3.TabStop = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 50)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(375, 5)
        Me.IndentedLine1.TabIndex = 119
        Me.IndentedLine1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Fortitude Save Bonus"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(15, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 21)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Level"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertiesTab)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(407, 349)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Properties"
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTab.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Size = New System.Drawing.Size(407, 349)
        Me.PropertiesTab.TabIndex = 0
        '
        'ClassLevelForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(444, 443)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ClassLevelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClassLevelForm"
        Me.TabControl1.ResumeLayout(False)
        Me.ClassTab.ResumeLayout(False)
        CType(Me.ClassLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mMode As FormMode

    Private LanguageIndex As Rules.Index.IndexEntry()

    'init
    Public Sub Init()
        Try
            'initialise controls
            TabControl1.TabPages(0).Text = mObject.Parent.Name & " Level"
            FortitudeBonus.ModifierSpin.Properties.MinValue = 0
            ReflexBonus.ModifierSpin.Properties.MinValue = 0
            WillBonus.ModifierSpin.Properties.MinValue = 0
            BAB.ModifierSpin.Properties.MinValue = 0
            FortitudeBonus.ModifierSpin.Properties.MaxValue = 99
            ReflexBonus.ModifierSpin.Properties.MaxValue = 99
            WillBonus.ModifierSpin.Properties.MaxValue = 99
            BAB.ModifierSpin.Properties.MaxValue = 99
            HitDice.ModifierSpin.Properties.MinValue = 0
            HitDice.ModifierSpin.Properties.MaxValue = 20
            PropertiesTab.Init(mObject, mMode)

            'show the hit dice controls if required
            If mObject.ObjectGUID.Database = XML.DBTypes.MonsterClasses Then
                Select Case mObject.Parent.Parent.Element("ClassType")
                    Case "Animal Companion", "Special Mount"
                        HitDiceLine.Visible = True
                        HitdiceLabel.Visible = True
                        HitDice.Visible = True
                End Select
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Dim Obj As Objects.ObjectData
        Dim HighestLevel As Integer = 0
        Dim Level As Integer

        Try
            'get the next level
            Select Case Folder.Type
                Case Objects.ClassLevelsFolderType
                    For Each Obj In Folder.ChildrenOfType(Objects.ClassLevelType)
                        Level = CInt(Obj.Element("Level"))
                        If Level > HighestLevel Then HighestLevel = Level
                    Next
                    mObject.Type = Objects.ClassLevelType
                Case Objects.MonsterClassLevelsFolderType
                    For Each Obj In Folder.ChildrenOfType(Objects.MonsterClassLevelType)
                        Level = CInt(Obj.Element("Level"))
                        If Level > HighestLevel Then HighestLevel = Level
                    Next
                    mObject.Type = Objects.MonsterClassLevelType
            End Select

            mMode = FormMode.Add
            mObject.Name = "Level " & CStr(HighestLevel + 1)
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.ParentGUID = Folder.ObjectGUID
            mObject.Element("Level") = CStr(HighestLevel + 1)

            Me.Text = "Add Class Level"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            Init()

            'initialise controls
            ClassLevel.Text = CStr(HighestLevel + 1)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            mObject = Obj
            mMode = FormMode.Edit
            Me.Text = "Edit Class Level"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_blue.ico")
            Init()

            'initialise controls
            ClassLevel.Text = mObject.Element("Level")
            FortitudeBonus.Text = mObject.Element("FortitudeSaveBonus")
            ReflexBonus.Text = mObject.Element("ReflexSaveBonus")
            WillBonus.Text = mObject.Element("WillSaveBonus")
            BAB.Text = mObject.Element("BaseAttackBonus")
            HitDice.Text = mObject.Element("HitDice")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ClassObj As Objects.ObjectData
        Dim spd, sk, psionic As Boolean
        Dim Level As Integer

        Try
            If Me.Validate Then
                General.MainExplorer.Undo.UndoRecord()
                ClassObj = mObject.Parent.Parent

                Select Case mMode

                    Case FormMode.Add
                        mObject.FKElement("Class", ClassObj.Name, "Name", ClassObj.ObjectGUID)

                        'create corresponding spells per day/spells known if required
                        spd = Rules.CharacterClass.SPD(ClassObj)
                        sk = Rules.CharacterClass.SK(ClassObj)
                        psionic = Rules.CharacterClass.Psionic(ClassObj)

                        Level = mObject.ElementAsInteger("Level")

                        If spd Then
                            Rules.CharacterClass.CreateSpellsPerDay(ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsPerDayFolderType).ObjectGUID, Level)
                        End If

                        If sk Then
                            Rules.CharacterClass.CreateSpellsKnown(ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsKnownFolderType).ObjectGUID, Level)
                        End If

                        If psionic Then
                            Rules.CharacterClass.CreatePowerProgression(ClassObj.FirstChildOfType(Objects.ClassLevelsSpellsKnownFolderType).ObjectGUID, Level)
                        End If

                    Case FormMode.Edit
                        CharacterManager.SetAllDirty(CharacterManager.DirtyStatus.Reload)
                End Select

                'updates common to add and edit
                mObject.Element("FortitudeSaveBonus") = FortitudeBonus.Text
                mObject.Element("ReflexSaveBonus") = ReflexBonus.Text
                mObject.Element("WillSaveBonus") = WillBonus.Text
                mObject.Element("BaseAttackBonus") = BAB.Text
                If HitDice.Visible = True Then
                    If HitDice.Text = "0" Then
                        mObject.Element("HitDice") = ""
                    Else
                        mObject.Element("HitDice") = HitDice.Text
                    End If
                Else
                    mObject.Element("HitDice") = ""
                End If

                mObject = PropertiesTab.UpdateObject(mObject)

                'save, refresh explorer and close
                mObject.Save()
                CommonLogic.UpdateCumulativeModifiers(mObject.Parent)
                WindowManager.SetDirty(mObject.Parent)
                If Caches.ContainsCharacterClass(ClassObj.ObjectGUID) Then Caches.RemoveCharacterClass(ClassObj.ObjectGUID)
                General.MainExplorer.RefreshPanel()
                If mMode = FormMode.Add Then
                    General.MainExplorer.InsertNode(CType(General.MainExplorer.TreeNodes(mObject.ParentGUID), TreeNode), General.MainExplorer.CompleteNodeFromObject(mObject), True)
                End If

                General.MainExplorer.SelectItemByGuid(mObject.ObjectGUID)
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

    'show
    Public Shadows Sub Show()
        Try
            MyBase.Show()
            If Commands.EditForm Is Nothing Then
                Commands.EditForm = Me
            Else
                OK.Enabled = False : Me.Text = Me.Text.Replace("Edit", "View") : Me.Icon = New Drawing.Icon(General.BasePath & "Icons\form_green.ico")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If Commands.EditForm Is Me Then
                Commands.EditForm = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
