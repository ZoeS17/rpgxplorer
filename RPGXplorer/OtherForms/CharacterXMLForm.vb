Option Explicit On 
Option Strict On

Imports RPGXplorer.Rules

Public Class CharacterXMLForm
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
    Public WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents Bar1 As DevExpress.XtraBars.Bar
    Public WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents CharacterComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public WithEvents Browser As System.Windows.Forms.WebBrowser
    Public WithEvents CharacterEditItem As DevExpress.XtraBars.BarEditItem
    Public WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents TransformFileDialog As System.Windows.Forms.OpenFileDialog
    Public WithEvents XMLInput As DevExpress.XtraEditors.MemoEdit
    Public WithEvents XMLOutput As DevExpress.XtraEditors.MemoEdit
    Public WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Public WithEvents FileName As DevExpress.XtraBars.BarEditItem
    Public WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents Bar2 As DevExpress.XtraBars.Bar
    Public WithEvents SaveCharacterXML As DevExpress.XtraBars.BarButtonItem
    Public WithEvents SaveTransformedXML As DevExpress.XtraBars.BarButtonItem
    Public WithEvents TransformButton As DevExpress.XtraBars.BarButtonItem
    Public WithEvents SaveXMLDialog As System.Windows.Forms.SaveFileDialog
    Public WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents CharacterXMLTab As DevExpress.XtraTab.XtraTabPage
    Public WithEvents TextOutputTab As DevExpress.XtraTab.XtraTabPage
    Public WithEvents BrowserOutputTab As DevExpress.XtraTab.XtraTabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterXMLForm))
        Me.XMLInput = New DevExpress.XtraEditors.MemoEdit
        Me.TransformFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.XMLOutput = New DevExpress.XtraEditors.MemoEdit
        Me.Browser = New System.Windows.Forms.WebBrowser
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.CharacterEditItem = New DevExpress.XtraBars.BarEditItem
        Me.CharacterComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.FileName = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.TransformButton = New DevExpress.XtraBars.BarButtonItem
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.SaveCharacterXML = New DevExpress.XtraBars.BarButtonItem
        Me.SaveTransformedXML = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.CharacterXMLTab = New DevExpress.XtraTab.XtraTabPage
        Me.TextOutputTab = New DevExpress.XtraTab.XtraTabPage
        Me.BrowserOutputTab = New DevExpress.XtraTab.XtraTabPage
        Me.SaveXMLDialog = New System.Windows.Forms.SaveFileDialog
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.Splitter1 = New System.Windows.Forms.Splitter
        CType(Me.XMLInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XMLOutput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CharacterXMLTab.SuspendLayout()
        Me.TextOutputTab.SuspendLayout()
        Me.BrowserOutputTab.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XMLInput
        '
        Me.XMLInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XMLInput.EditValue = ""
        Me.XMLInput.Location = New System.Drawing.Point(0, 0)
        Me.XMLInput.Name = "XMLInput"
        Me.XMLInput.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.XMLInput.Properties.Appearance.Options.UseBackColor = True
        Me.XMLInput.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.XMLInput.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.XMLInput.Properties.ReadOnly = True
        Me.XMLInput.Size = New System.Drawing.Size(853, 500)
        Me.XMLInput.TabIndex = 0
        '
        'XMLOutput
        '
        Me.XMLOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XMLOutput.EditValue = ""
        Me.XMLOutput.Location = New System.Drawing.Point(0, 0)
        Me.XMLOutput.Name = "XMLOutput"
        Me.XMLOutput.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.XMLOutput.Properties.Appearance.Options.UseBackColor = True
        Me.XMLOutput.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.XMLOutput.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.XMLOutput.Properties.ReadOnly = True
        Me.XMLOutput.Size = New System.Drawing.Size(853, 500)
        Me.XMLOutput.TabIndex = 1
        '
        'Browser
        '
        Me.Browser.CausesValidation = False
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(0, 0)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(853, 500)
        Me.Browser.TabIndex = 4
        Me.Browser.TabStop = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CharacterEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.TransformButton, Me.BarStaticItem1, Me.FileName, Me.SaveCharacterXML, Me.SaveTransformedXML})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CharacterComboBox, Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Menu Bar"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.CharacterEditItem, "", False, True, True, 212), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.FileName, "", False, True, True, 146), New DevExpress.XtraBars.LinkPersistInfo(Me.TransformButton)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AllowRename = True
        Me.Bar1.Text = "Menu Bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarStaticItem1.Caption = "Character"
        Me.BarStaticItem1.Id = 6
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'CharacterEditItem
        '
        Me.CharacterEditItem.Caption = "BarEditItem1"
        Me.CharacterEditItem.Edit = Me.CharacterComboBox
        Me.CharacterEditItem.EditValue = "<Please Select A Character>"
        Me.CharacterEditItem.Id = 0
        Me.CharacterEditItem.Name = "CharacterEditItem"
        '
        'CharacterComboBox
        '
        Me.CharacterComboBox.AutoHeight = False
        Me.CharacterComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CharacterComboBox.Items.AddRange(New Object() {"Test"})
        Me.CharacterComboBox.Name = "CharacterComboBox"
        Me.CharacterComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Generate XML"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Hint = "Generates an XML document for the selected character"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Load Transformation"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Hint = "Selects an XSL document to use in the transform"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'FileName
        '
        Me.FileName.Caption = "barEditItem1"
        Me.FileName.Edit = Me.RepositoryItemTextEdit1
        Me.FileName.Id = 7
        Me.FileName.Name = "FileName"
        Me.FileName.Width = 10
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'TransformButton
        '
        Me.TransformButton.Caption = "Transform"
        Me.TransformButton.Enabled = False
        Me.TransformButton.Glyph = CType(resources.GetObject("TransformButton.Glyph"), System.Drawing.Image)
        Me.TransformButton.Hint = "Apply XSL Transformation"
        Me.TransformButton.Id = 5
        Me.TransformButton.Name = "TransformButton"
        Me.TransformButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar2
        '
        Me.Bar2.BarName = "Save Bar"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SaveCharacterXML), New DevExpress.XtraBars.LinkPersistInfo(Me.SaveTransformedXML)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.Text = "Save Bar"
        '
        'SaveCharacterXML
        '
        Me.SaveCharacterXML.Caption = "Save Character XML"
        Me.SaveCharacterXML.Enabled = False
        Me.SaveCharacterXML.Glyph = CType(resources.GetObject("SaveCharacterXML.Glyph"), System.Drawing.Image)
        Me.SaveCharacterXML.Hint = "Save the character's XML data to disk"
        Me.SaveCharacterXML.Id = 8
        Me.SaveCharacterXML.Name = "SaveCharacterXML"
        Me.SaveCharacterXML.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'SaveTransformedXML
        '
        Me.SaveTransformedXML.Caption = "Save Transformed Output"
        Me.SaveTransformedXML.Enabled = False
        Me.SaveTransformedXML.Glyph = CType(resources.GetObject("SaveTransformedXML.Glyph"), System.Drawing.Image)
        Me.SaveTransformedXML.Hint = "Save the transformed output to disk"
        Me.SaveTransformedXML.Id = 9
        Me.SaveTransformedXML.Name = "SaveTransformedXML"
        Me.SaveTransformedXML.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'CharacterXMLTab
        '
        Me.CharacterXMLTab.Controls.Add(Me.XMLInput)
        Me.CharacterXMLTab.Name = "CharacterXMLTab"
        Me.CharacterXMLTab.Size = New System.Drawing.Size(853, 500)
        Me.CharacterXMLTab.Text = "Character XML"
        '
        'TextOutputTab
        '
        Me.TextOutputTab.Controls.Add(Me.XMLOutput)
        Me.TextOutputTab.Name = "TextOutputTab"
        Me.TextOutputTab.Size = New System.Drawing.Size(853, 500)
        Me.TextOutputTab.Text = "Output to Text"
        '
        'BrowserOutputTab
        '
        Me.BrowserOutputTab.Controls.Add(Me.Browser)
        Me.BrowserOutputTab.Name = "BrowserOutputTab"
        Me.BrowserOutputTab.Size = New System.Drawing.Size(853, 500)
        Me.BrowserOutputTab.Text = "Output to Browser"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 56)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.CharacterXMLTab
        Me.XtraTabControl1.Size = New System.Drawing.Size(862, 530)
        Me.XtraTabControl1.TabIndex = 48
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.CharacterXMLTab, Me.TextOutputTab, Me.BrowserOutputTab})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Enabled = False
        Me.Splitter1.Location = New System.Drawing.Point(0, 53)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(862, 3)
        Me.Splitter1.TabIndex = 49
        Me.Splitter1.TabStop = False
        '
        'CharacterXMLForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(862, 586)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CharacterXMLForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XML Workshop"
        CType(Me.XMLInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XMLOutput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CharacterXMLTab.ResumeLayout(False)
        Me.TextOutputTab.ResumeLayout(False)
        Me.BrowserOutputTab.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private CharacterIndex As General.DataListItem()
    Public TransformFile As String
    Public TransformLoaded, XMLGenerated, TransformApplied As Boolean

    'init the form
    Public Sub Init()
        Try
            'get the characters for the dropdown
            Dim CharIndex As General.DataListItem()
            Dim MonsterIndex As General.DataListItem()

            CharIndex = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.CharacterType)
            MonsterIndex = Rules.Index.DataList(Xml.DBTypes.Monsters, Objects.MonsterType)

            ReDim CharacterIndex((CharIndex.Length + MonsterIndex.Length) - 1)

            Array.Copy(CharIndex, 0, CharacterIndex, 0, CharIndex.Length)
            Array.Copy(MonsterIndex, 0, CharacterIndex, CharIndex.Length, MonsterIndex.Length)

            CharacterComboBox.Items.Clear()
            CharacterComboBox.Items.AddRange(CharacterIndex)

            'clear the browser
            Browser.Navigate(General.BasePath & "HTML\HelpPages\Index.htm")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'reinit form, called when a change is made to the characters
    Public Sub ReInit()
        Try
            'get the characters for the dropdown
            Dim CharIndex As General.DataListItem()
            Dim MonsterIndex As General.DataListItem()

            CharIndex = Rules.Index.DataList(Xml.DBTypes.Characters, Objects.CharacterType)
            MonsterIndex = Rules.Index.DataList(Xml.DBTypes.Monsters, Objects.MonsterType)

            ReDim CharacterIndex((CharIndex.Length + MonsterIndex.Length) - 1)

            Array.Copy(CharIndex, 0, CharacterIndex, 0, CharIndex.Length)
            Array.Copy(MonsterIndex, 0, CharacterIndex, CharIndex.Length, MonsterIndex.Length)

            CharacterComboBox.Items.Clear()
            CharacterComboBox.Items.AddRange(CharacterIndex)
            CharacterEditItem.EditValue = "<Please Select A Character>"
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'generate XML
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try

            If TypeOf CharacterEditItem.EditValue Is General.DataListItem Then
                'reload character object to make sure its still there
                Dim CharacterObject As Objects.ObjectData = CType(CType(CharacterEditItem.EditValue, General.DataListItem).ValueMember, Objects.ObjectData)

                If CharacterObject.FirstChildOfType(Objects.CharacterLevelsFolderType).Children.Count > 0 Then
                    'clear current displays
                    Browser.Navigate(General.BasePath & "HTML\HelpPages\Index.htm")
                    XMLOutput.Text = ""
                    XMLInput.Text = ""

                    'get the characters DataSet
                    Dim DataSets As CharacterXMLData = New CharacterXMLData
                    Dim ProgressBar As New RPGXplorer.ProgressBar
                    ProgressBar.Show()
                    ProgressBar.TopMost = True
                    General.SetWaitCursor(Me)
                    DataSets.Init(CharacterObject, ProgressBar)
                    ProgressBar.Close()
                    General.SetNormalCursor(Me)
                    XMLInput.Text = DataSets.CharacterData.GetXml()
                    XMLGenerated = True : EnableControls()
                Else
                    XMLGenerated = False : EnableControls()
                    General.ShowErrorDialog("This character has not taken any levels.")
                End If
            Else
                XMLGenerated = False : EnableControls()
                General.ShowErrorDialog("Please select a character.")
            End If

        Catch ex As Exception
            XMLGenerated = False : EnableControls()
            HandleException(ex)
        End Try
    End Sub

    'load XLST
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            'TransformFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            TransformFileDialog.InitialDirectory = General.BasePath & "XSLT\"
            TransformFileDialog.Filter = "XSLT Files (*.xsl)|*.xsl"

            If TransformFileDialog.ShowDialog(Me) = DialogResult.OK Then
                TransformFile = TransformFileDialog.FileName

                'display the filename
                Dim NameIndex As Integer = TransformFile.LastIndexOf("\")
                If NameIndex > 0 Then
                    FileName.EditValue = TransformFile.Substring(NameIndex + 1)
                Else
                    FileName.EditValue = TransformFile
                End If

                TransformLoaded = True : EnableControls()
            End If

        Catch ex As Exception
            TransformLoaded = False
            EnableControls()
            TransformFile = ""
            FileName.EditValue = ""
            HandleException(ex)
        End Try
    End Sub

    'transform
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles TransformButton.ItemClick
        Try
            'exit if there is no input or transform
            If XMLInput.Text = "" Then
                General.ShowErrorDialog("No XML data to apply transformation.")
                Exit Sub
            End If

            If TransformFile = "" Then
                General.ShowErrorDialog("No XLST selected.")
                Exit Sub
            End If

            'load the generated XML
            Dim Input As New System.Xml.XmlDocument
            Input.LoadXml(XMLInput.Text)

            'apply the transform
            Dim Output As New System.IO.StringWriter

            Dim XLST As New System.Xml.Xsl.XslCompiledTransform()
            XLST.Load(TransformFile, System.Xml.Xsl.XsltSettings.TrustedXslt, New System.Xml.XmlUrlResolver)
            XLST.Transform(Input, Nothing, Output)
            XMLOutput.Text = Output.ToString

            'write the tempfile
            Dim TempFile As System.IO.StreamWriter = System.IO.File.CreateText(RPGXplorer.General.BasePath & "temp")
            TempFile.Write(Output.ToString)
            TempFile.Close()

            'display result on the browser
            Browser.Navigate(RPGXplorer.General.BasePath & "temp")

            'enable save control
            TransformApplied = True : EnableControls()

            'switch to an output tab
            If XtraTabControl1.SelectedTabPageIndex < 1 Then
                XtraTabControl1.SelectedTabPageIndex = 1
            End If

        Catch ex As System.Xml.Xsl.XsltException
            TransformApplied = False
            EnableControls()
            Browser.Navigate(General.BasePath & "HTML\HelpPages\Index.htm")
            XMLOutput.Text = ""
            General.ShowErrorDialog("Error in performing XLS Transform")
        Catch ex As Exception
            TransformApplied = False
            EnableControls()
            Browser.Navigate(General.BasePath & "HTML\HelpPages\Index.htm")
            XMLOutput.Text = ""
            HandleException(ex)
        End Try
    End Sub

    'enables the transform button
    Public Sub EnableControls()
        Try
            'transform button
            If TransformLoaded And XMLGenerated Then
                TransformButton.Enabled = True
            Else
                TransformButton.Enabled = False
            End If

            'save character xml button
            If XMLGenerated Then
                SaveCharacterXML.Enabled = True
            Else
                SaveCharacterXML.Enabled = False
            End If

            'save transformed xml button
            If TransformApplied Then
                SaveTransformedXML.Enabled = True
            Else
                SaveTransformedXML.Enabled = False
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'save character xml
    Private Sub SaveCharacterXML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SaveCharacterXML.ItemClick
        Try

            If XMLInput.Text = "" Then
                General.ShowErrorDialog("No XML data to save.")
                Exit Sub
            End If

            'show file dialog
            SaveXMLDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            SaveXMLDialog.Filter = "XML Files (*.xml)|*.xml"
            SaveXMLDialog.OverwritePrompt = True
            SaveXMLDialog.FileName = CType(CType(CharacterEditItem.EditValue, General.DataListItem).ValueMember, Objects.ObjectData).Name & ".xml"

            If SaveXMLDialog.ShowDialog() = DialogResult.OK Then
                Dim SaveFile As System.IO.StreamWriter = System.IO.File.CreateText(SaveXMLDialog.FileName)
                SaveFile.Write(XMLInput.Text)
                SaveFile.Close()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'save transformed file
    Private Sub SaveTransformedXML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SaveTransformedXML.ItemClick
        Try

            If XMLOutput.Text = "" Then
                General.ShowErrorDialog("No XML data to save.")
                Exit Sub
            End If

            'show file dialog
            SaveXMLDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            SaveXMLDialog.Filter = ""
            SaveXMLDialog.OverwritePrompt = True
            SaveXMLDialog.FileName = ""

            If SaveXMLDialog.ShowDialog() = DialogResult.OK Then
                Dim SaveFile As System.IO.StreamWriter = System.IO.File.CreateText(SaveXMLDialog.FileName)
                SaveFile.Write(XMLOutput.Text)
                SaveFile.Close()
            End If

        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'exception handler
    Private Sub HandleException(ByVal ex As Exception)
        Dim ErrorDialog As New ErrorForm
        ErrorDialog.ErrorMessage = "An Error has occured. Please report the following to customer.support@rpgxplorer.com: " & ex.Message & " - " & ex.Source.ToString & " - " & ex.TargetSite.ToString
        ErrorDialog.ShowDialog()
    End Sub

    'clean up after close
    Private Sub CharacterXMLForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            e.Cancel = True
            Me.Hide()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    'for use with the toolbars xslt commands
    Public Sub ExternalGenerateCharacterXML()
        BarButtonItem1_ItemClick(Nothing, Nothing)
    End Sub

    Public Sub ExternalTransform()
        BarButtonItem3_ItemClick(Nothing, Nothing)
    End Sub

    Public Sub ExternalSetTransformation(ByVal XSLFileName As String)
        Try
            TransformFile = XSLFileName

            'display the filename
            Dim NameIndex As Integer = TransformFile.LastIndexOf("\")
            If NameIndex > 0 Then
                FileName.EditValue = TransformFile.Substring(NameIndex + 1)
            Else
                FileName.EditValue = TransformFile
            End If

            TransformLoaded = True : EnableControls()

        Catch ex As Exception
            TransformLoaded = False
            EnableControls()
            TransformFile = ""
            FileName.EditValue = ""
            HandleException(ex)
        End Try
    End Sub

End Class
