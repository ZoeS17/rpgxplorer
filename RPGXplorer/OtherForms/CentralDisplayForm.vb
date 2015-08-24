Option Explicit On 
Option Strict On

Public Class CentralDisplayForm
    Inherits DevExpress.XtraEditors.XtraForm

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CentralDisplayForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(456, 430)
        Me.Name = "CentralDisplayForm"
        Me.Text = "Breadcrumb"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Member Variables"

    'panels
    Public MyPanel As Control
    Public MyPanelType As Explorer.PanelType

    'other
    Public CharacterFolder As Boolean
    Public CharacterKey As Objects.ObjectKey
    Public TreeNode As TreeNode
    Public Folder As Objects.ObjectData

    'filter
    Public Filter As String

    'needs init
    Public NeedsPanelInit As Boolean = False

#End Region

#Region "Properties"

    Public ReadOnly Property FolderKey() As Objects.ObjectKey
        Get
            Return Folder.ObjectGUID
        End Get
    End Property

#End Region

    'set the current panel and folder
    Public Sub Initialise(ByVal TreeNode As TreeNode, ByVal Folder As Objects.ObjectData, ByVal PanelType As Explorer.PanelType, ByVal CharacterKey As Objects.ObjectKey)
        Try
            'vars
            Me.TreeNode = TreeNode
            Me.Folder = Folder
            Me.CharacterKey = CharacterKey
            Me.MdiParent = General.MainExplorer.Form
            CharacterFolder = False

            'get the panel
            Select Case PanelType
                Case Explorer.PanelType.BasicListView
                    MyPanel = New BasicListViewPanel
                Case Explorer.PanelType.AssetsPanel
                    MyPanel = New AssetsPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Character
                    MyPanel = New CharacterPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Inventory
                    MyPanel = New InventoryPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Modifiers
                    MyPanel = New ModifiersPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Features
                    MyPanel = New FeaturesPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Skills
                    MyPanel = New SkillsPanel
                    CharacterFolder = True
                Case Explorer.PanelType.SpellCaster
                    MyPanel = New SpellcasterPanel2
                    CharacterFolder = True
                Case Explorer.PanelType.SpellList
                    MyPanel = New SpellListPanel
                Case Explorer.PanelType.Weapons
                    MyPanel = New WeaponsPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Feats
                    MyPanel = New FeatPanel
                    CharacterFolder = True
                Case Explorer.PanelType.Memorized
                    MyPanel = New MemorizedPanel
                    CharacterFolder = True
                Case Explorer.PanelType.PowerList
                    MyPanel = New PowerListPanel
                Case Explorer.PanelType.Manifester
                    MyPanel = New ManifesterPanel
                    CharacterFolder = True
            End Select

            'initialise panel
            MyPanel.BackColor = System.Drawing.SystemColors.Control
            MyPanel.Dock = System.Windows.Forms.DockStyle.Fill
            MyPanel.Location = New System.Drawing.Point(0, 0)
            MyPanel.Name = "Panel"
            MyPanel.Padding = New System.Windows.Forms.Padding(1)
            MyPanel.Size = New System.Drawing.Size(456, 430)
            MyPanel.TabIndex = 0
            Me.Controls.Add(MyPanel)
            DirectCast(MyPanel, IPanel).IsDirty = False
            NeedsPanelInit = True

            'set caption
            SetTabName()

            MyPanelType = PanelType

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'show the current panel
    Public Sub RefreshPanel()
        Try
            General.SetWaitCursor(Me)
            DirectCast(MyPanel, IPanel).RefreshPanelData()
            MyPanel.Show()
            General.SetNormalCursor(Me)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save the current column layout
    Public Sub SaveLayout()
        Try
            If Not General.MainExplorer.ListViewManager Is Nothing Then
                General.MainExplorer.ListViewManager.SaveColumnLayout()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'set tab name
    Private Sub SetTabName()
        Try
            Select Case Folder.Type
                Case Objects.ClassLevelType
                    Me.Text = Folder.Parent.Parent.Name & " - " & Folder.Name
                Case Objects.ClassLevelsFolderType, Objects.ClassLevelsSpellsPerDayFolderType, Objects.ClassLevelsSpellsKnownFolderType
                    Me.Text = Folder.Parent.Name & " - " & Folder.Name
                Case Objects.SpellListFolderType
                    Me.Text = Folder.Parent.Name & " - " & Folder.Name
                Case Else
                    If CharacterKey.IsNotEmpty AndAlso Not CharacterKey.Equals(Folder.ObjectGUID) Then
                        Dim Character As New Objects.ObjectData
                        Character.Load(CharacterKey)
                        Me.Text = Character.Name & " - " & Folder.Name
                    Else
                        Me.Text = Folder.Name
                    End If
            End Select

            If Not Filter = "" Then
                Me.Text = Me.Text & " (" & Filter & ")"
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'refresh the tab name
    Public Sub RefreshTabName()
        'reload the folder to make sure we get any saved changes
        Folder.Load(Folder.ObjectGUID)
        SetTabName()
    End Sub

End Class

