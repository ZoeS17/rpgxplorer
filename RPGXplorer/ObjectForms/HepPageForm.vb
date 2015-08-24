Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General

Public Class HepPageForm
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
    Public WithEvents RpgxListView As RPGXplorer.RPGXListView
    Public WithEvents CloseButton As System.Windows.Forms.Button
    Public WithEvents AddSpellsButton As System.Windows.Forms.Button
    Public WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Public WithEvents ChooseFile As System.Windows.Forms.Button
    Public WithEvents HelpPage As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button
        Me.AddSpellsButton = New System.Windows.Forms.Button
        Me.RpgxListView = New RPGXplorer.RPGXListView
        Me.ChooseFile = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.HelpPage = New DevExpress.XtraEditors.TextEdit
        CType(Me.HelpPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(625, 430)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(85, 24)
        Me.CloseButton.TabIndex = 129
        Me.CloseButton.Text = "Close"
        '
        'AddSpellsButton
        '
        Me.AddSpellsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSpellsButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSpellsButton.Location = New System.Drawing.Point(455, 430)
        Me.AddSpellsButton.Name = "AddSpellsButton"
        Me.AddSpellsButton.Size = New System.Drawing.Size(160, 24)
        Me.AddSpellsButton.TabIndex = 137
        Me.AddSpellsButton.Text = "Move Selection"
        '
        'RpgxListView
        '
        Me.RpgxListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RpgxListView.Location = New System.Drawing.Point(15, 15)
        Me.RpgxListView.Name = "RpgxListView"
        Me.RpgxListView.Size = New System.Drawing.Size(693, 400)
        Me.RpgxListView.TabIndex = 139
        '
        'ChooseFile
        '
        Me.ChooseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChooseFile.Location = New System.Drawing.Point(305, 430)
        Me.ChooseFile.Name = "ChooseFile"
        Me.ChooseFile.Size = New System.Drawing.Size(23, 21)
        Me.ChooseFile.TabIndex = 140
        Me.ChooseFile.Text = "..."
        '
        'HelpPage
        '
        Me.HelpPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HelpPage.Location = New System.Drawing.Point(15, 430)
        Me.HelpPage.Name = "HelpPage"
        '
        'HelpPage.Properties
        '
        Me.HelpPage.Properties.AutoHeight = False
        Me.HelpPage.Properties.MaxLength = 1000
        Me.HelpPage.Properties.ReadOnly = True
        Me.HelpPage.Size = New System.Drawing.Size(285, 21)
        Me.HelpPage.TabIndex = 141
        Me.HelpPage.TabStop = False
        '
        'HepPageForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 471)
        Me.Controls.Add(Me.HelpPage)
        Me.Controls.Add(Me.ChooseFile)
        Me.Controls.Add(Me.RpgxListView)
        Me.Controls.Add(Me.AddSpellsButton)
        Me.Controls.Add(Me.CloseButton)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "HepPageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help Page Mover"
        CType(Me.HelpPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    Private SpellDefinitionsFolder As Objects.ObjectData
    Private SpellListFolder As Objects.ObjectData
    Private BaseSpells As Objects.ObjectDataCollection
    Private CurrentSpells As Objects.ObjectDataCollection

    Private HelpListFormKey As New Objects.ObjectKey("001-cb644cf7-9709-463f-b763-52e080a48da2")

#End Region

    'init
    Public Sub Init(ByVal SpellListFolder As Objects.ObjectData)
        Try
            'init form
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\row_add.ico")

            Dim DisplayObjects As Objects.ObjectDataCollection
            DisplayObjects = Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.RuleFolderPageType)
            DisplayObjects.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.RuleFolderType))
            DisplayObjects.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.RulePageType))
            DisplayObjects.AddMany(Objects.GetAllObjectsOfType(Xml.DBTypes.UserDocs, Objects.RuleTableType))

            Dim FinalObjects As New Objects.ObjectDataCollection

            For Each Obj As Objects.ObjectData In DisplayObjects
                Dim Transform As New Objects.ObjectData
                Transform.Clear()

                Transform.ObjectGUID = Objects.ObjectKey.NewGuid(Xml.DBTypes.UserDocs)
                Transform.Type = Objects.TempItemType
                Transform.Name = Obj.Name
                Transform.Element("BasePath") = Obj.Path
                Transform.Element("HelpPath") = Obj.HTML

                FinalObjects.Add(Transform)
            Next

            RpgxListView.Init(HelpListFormKey, Objects.TempFolderType, SortType.Alphabetic)
            RpgxListView.AddRange(FinalObjects, True)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'handles the close button
    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'closing
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            'save the column layout
            RpgxListView.SaveColumnLayout()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'colors the list view correctly when its first initialised
    Private Sub SpellListForm_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Try
            RpgxListView.ColorListview()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    Private Sub ChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseFile.Click
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()
        HelpPage.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    'move the pages
    Private Sub MovePages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSpellsButton.Click
        Dim SelectedObjects As Objects.ObjectDataCollection
        Try

            SelectedObjects = RpgxListView.SelectedObjects
            If SelectedObjects.Count = 0 Then Exit Sub

            For Each PageObject As Objects.ObjectData In SelectedObjects
                If System.IO.File.Exists(General.HelpPath & PageObject.Element("HelpPath")) Then
                    Dim RulepageInfo As New RulePagePath(PageObject.Element("HelpPath"))
                    If Not System.IO.File.Exists(HelpPage.Text & "\" & RulepageInfo.Filename) Then
                        System.IO.File.Move(General.HelpPath & PageObject.Element("HelpPath"), HelpPage.Text & "\" & RulepageInfo.Filename)
                    Else
                        Dim BaseName As String = HelpPage.Text & "\"
                        Dim FileName As String = RulepageInfo.Filename.Substring(0, RulepageInfo.Filename.LastIndexOf("."))
                        Dim Extention As String = RulepageInfo.Extension
                        Dim Counter As Integer = 1
                        Dim FinalPath As String = BaseName & FileName & Counter.ToString & Extention
                        Dim NotFound As Boolean = False

                        Do
                            If System.IO.File.Exists(FinalPath) Then
                                Counter += 1
                                FinalPath = BaseName & FileName & Counter.ToString & Extention
                            Else
                                NotFound = True
                            End If
                        Loop Until NotFound
                        System.IO.File.Move(General.HelpPath & PageObject.Element("HelpPath"), FinalPath)
                    End If
                End If
            Next

            For Each Item As ListViewItem In RpgxListView.ListView.SelectedItems
                Item.Remove()
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RpgxListView.Refresh()
    End Sub
End Class

