Public Class CompareForm
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
    Public Shadows WithEvents Close As System.Windows.Forms.Button
    Public WithEvents DataElements As System.Windows.Forms.ListView
    Public WithEvents ExistingElements As System.Windows.Forms.ListView
    Public WithEvents DataComponents As System.Windows.Forms.ListView
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents MissingLabel As System.Windows.Forms.Label
    Public WithEvents RestrictedBlock As System.Windows.Forms.Panel
    Public WithEvents NewLabel As System.Windows.Forms.Label
    Public WithEvents TakenBlock As System.Windows.Forms.Panel
    Public WithEvents ChangeLabel As System.Windows.Forms.Label
    Public WithEvents PrestigeDomainBlock As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CompareForm))
        Me.Close = New System.Windows.Forms.Button
        Me.DataElements = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ExistingElements = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.DataComponents = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.MissingLabel = New System.Windows.Forms.Label
        Me.RestrictedBlock = New System.Windows.Forms.Panel
        Me.NewLabel = New System.Windows.Forms.Label
        Me.TakenBlock = New System.Windows.Forms.Panel
        Me.ChangeLabel = New System.Windows.Forms.Label
        Me.PrestigeDomainBlock = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Label3 = New System.Windows.Forms.Label
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Close
        '
        Me.Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close.Location = New System.Drawing.Point(535, 562)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(100, 23)
        Me.Close.TabIndex = 3
        Me.Close.Text = "Close"
        '
        'DataElements
        '
        Me.DataElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.DataElements.FullRowSelect = True
        Me.DataElements.Location = New System.Drawing.Point(15, 320)
        Me.DataElements.MultiSelect = False
        Me.DataElements.Name = "DataElements"
        Me.DataElements.Size = New System.Drawing.Size(300, 215)
        Me.DataElements.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.DataElements.TabIndex = 1
        Me.DataElements.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Dataset"
        Me.ColumnHeader3.Width = 296
        '
        'ExistingElements
        '
        Me.ExistingElements.BackColor = System.Drawing.Color.White
        Me.ExistingElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.ExistingElements.FullRowSelect = True
        Me.ExistingElements.Location = New System.Drawing.Point(335, 320)
        Me.ExistingElements.MultiSelect = False
        Me.ExistingElements.Name = "ExistingElements"
        Me.ExistingElements.Size = New System.Drawing.Size(300, 215)
        Me.ExistingElements.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ExistingElements.TabIndex = 2
        Me.ExistingElements.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "My Database"
        Me.ColumnHeader4.Width = 296
        '
        'DataComponents
        '
        Me.DataComponents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.DataComponents.FullRowSelect = True
        Me.DataComponents.Location = New System.Drawing.Point(15, 45)
        Me.DataComponents.MultiSelect = False
        Me.DataComponents.Name = "DataComponents"
        Me.DataComponents.Size = New System.Drawing.Size(260, 220)
        Me.DataComponents.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.DataComponents.TabIndex = 0
        Me.DataComponents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Changed, New, Missing"
        Me.ColumnHeader1.Width = 256
        '
        'MissingLabel
        '
        Me.MissingLabel.Location = New System.Drawing.Point(355, 225)
        Me.MissingLabel.Name = "MissingLabel"
        Me.MissingLabel.Size = New System.Drawing.Size(155, 25)
        Me.MissingLabel.TabIndex = 17
        Me.MissingLabel.Text = "Missing Component/Element"
        Me.MissingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RestrictedBlock
        '
        Me.RestrictedBlock.BackColor = System.Drawing.Color.Gray
        Me.RestrictedBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RestrictedBlock.Location = New System.Drawing.Point(325, 225)
        Me.RestrictedBlock.Name = "RestrictedBlock"
        Me.RestrictedBlock.Size = New System.Drawing.Size(25, 25)
        Me.RestrictedBlock.TabIndex = 16
        '
        'NewLabel
        '
        Me.NewLabel.Location = New System.Drawing.Point(355, 190)
        Me.NewLabel.Name = "NewLabel"
        Me.NewLabel.Size = New System.Drawing.Size(140, 25)
        Me.NewLabel.TabIndex = 15
        Me.NewLabel.Text = "New Component/Element"
        Me.NewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TakenBlock
        '
        Me.TakenBlock.BackColor = System.Drawing.Color.Green
        Me.TakenBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TakenBlock.Location = New System.Drawing.Point(325, 190)
        Me.TakenBlock.Name = "TakenBlock"
        Me.TakenBlock.Size = New System.Drawing.Size(25, 25)
        Me.TakenBlock.TabIndex = 14
        '
        'ChangeLabel
        '
        Me.ChangeLabel.Location = New System.Drawing.Point(355, 155)
        Me.ChangeLabel.Name = "ChangeLabel"
        Me.ChangeLabel.Size = New System.Drawing.Size(165, 25)
        Me.ChangeLabel.TabIndex = 13
        Me.ChangeLabel.Text = "Changed Component/Element"
        Me.ChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrestigeDomainBlock
        '
        Me.PrestigeDomainBlock.BackColor = System.Drawing.Color.Red
        Me.PrestigeDomainBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrestigeDomainBlock.Location = New System.Drawing.Point(325, 155)
        Me.PrestigeDomainBlock.Name = "PrestigeDomainBlock"
        Me.PrestigeDomainBlock.Size = New System.Drawing.Size(25, 25)
        Me.PrestigeDomainBlock.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Legend"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(320, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(305, 20)
        Me.Label23.TabIndex = 311
        Me.Label23.Text = "Select a changed, new or missing component to view it."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(290, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 310
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(320, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 45)
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "For changed components you will see a comparison between what you are loading and" & _
        " what you already have in your database."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine1.Location = New System.Drawing.Point(-112, 547)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(872, 5)
        Me.IndentedLine1.TabIndex = 313
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(320, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 30)
        Me.Label3.TabIndex = 312
        Me.Label3.Text = "For new or missing items you will be shown their contents in the appropriate wind" & _
        "ow."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndentedLine2.Location = New System.Drawing.Point(-105, 280)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(872, 5)
        Me.IndentedLine2.TabIndex = 313
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Comparison/Contents:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Selected Component and Children:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompareForm
        '
        Me.AcceptButton = Me.Close
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Close
        Me.ClientSize = New System.Drawing.Size(649, 598)
        Me.Controls.Add(Me.IndentedLine1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MissingLabel)
        Me.Controls.Add(Me.RestrictedBlock)
        Me.Controls.Add(Me.NewLabel)
        Me.Controls.Add(Me.TakenBlock)
        Me.Controls.Add(Me.ChangeLabel)
        Me.Controls.Add(Me.PrestigeDomainBlock)
        Me.Controls.Add(Me.DataComponents)
        Me.Controls.Add(Me.ExistingElements)
        Me.Controls.Add(Me.DataElements)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IndentedLine2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompareForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private NewObjs, ExistingObjs As Objects.ObjectDataCollection

    Public Sub Init(ByVal NewObjects As Objects.ObjectDataCollection, ByVal ExistingObjects As Objects.ObjectDataCollection)
        Try

            NewObjs = NewObjects
            ExistingObjs = ExistingObjects

            Dim Item As ListViewItem

            For Each Obj As Objects.ObjectData In NewObjects
                Item = New ListViewItem
                Item.Text = obj.Type & " - " & obj.Name
                Item.Tag = obj

                'see if this object is present in the existing collection
                If ExistingObjects.Contains(obj.ObjectGUID) Then
                    'if it does check if its different
                    Select Case obj.Type

                        Case Objects.SpellDefinitionType, Objects.PowerDefinitionType
                            If Not obj.SpellDefCompare(ExistingObjects.Item(obj.ObjectGUID)) Then
                                Item.ForeColor = System.Drawing.Color.Red
                                DataComponents.Items.Add(Item)
                            End If

                        Case Else
                            If Not obj.Compare(ExistingObjects.Item(obj.ObjectGUID)) Then
                                Item.ForeColor = System.Drawing.Color.Red
                                DataComponents.Items.Add(Item)
                            End If

                    End Select
                Else
                    Select Case obj.Type

                        Case Objects.SpellLevelType, Objects.PowerLevelType
                            'does a level with the same source exist?
                            Dim ElementString As String
                            Dim ExistingLevel As Objects.ObjectData

                            ElementString = obj.GetFirstFKElementName
                            ExistingLevel = ExistingObjects.Item(ElementString, obj.GetFKGuid(ElementString))

                            If Not ExistingLevel.IsEmpty Then
                                If Not obj.Compare(ExistingLevel, True) Then
                                    Item.ForeColor = System.Drawing.Color.Red
                                    DataComponents.Items.Add(Item)
                                End If
                            Else
                                Item.ForeColor = System.Drawing.Color.Green
                                DataComponents.Items.Add(Item)
                            End If

                        Case Else
                            Item.ForeColor = System.Drawing.Color.Green
                            DataComponents.Items.Add(Item)
                    End Select
                End If
            Next

            For Each Obj As Objects.ObjectData In ExistingObjects
                Select Case obj.Type

                    Case Objects.SpellLevelType, Objects.PowerLevelType
                        'do nothing

                    Case Else
                        'see if this item has been removed from the dataset version
                        If Not NewObjects.Contains(obj.ObjectGUID) Then
                            Item = New ListViewItem
                            Item.Text = obj.Type & " - " & obj.Name
                            Item.Tag = obj
                            Item.ForeColor = System.Drawing.Color.Gray
                            DataComponents.Items.Add(Item)
                        End If
                End Select
            Next

            'select the first item
            If DataComponents.Items.Count > 0 Then
                DataComponents.Items.Item(0).Selected = True
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close.Click
        MyBase.Close()
    End Sub

    Private Sub DataComponents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataComponents.SelectedIndexChanged

        If DataComponents.SelectedItems.Count > 0 Then
            DataElements.Items.Clear()
            ExistingElements.Items.Clear()

            Dim SelectedItem As ListViewItem
            Dim SelectedObject, ExistingObject As Objects.ObjectData

            SelectedItem = DataComponents.SelectedItems.Item(0)
            SelectedObject = CType(SelectedItem.Tag, Objects.ObjectData)

            If SelectedItem.ForeColor.Equals(Color.Red) Then
                Dim Item As ListViewItem

                Dim DataNodeTable, ExistingNodeTable As Hashtable
                DataNodeTable = New Hashtable : ExistingNodeTable = New Hashtable

                Select Case SelectedObject.Type

                    Case Objects.SpellLevelType, Objects.PowerLevelType
                        Dim ElementString As String = SelectedObject.GetFirstFKElementName
                        ExistingObject = ExistingObjs.Item(ElementString, SelectedObject.GetFKGuid(ElementString))

                    Case Else
                        ExistingObject = ExistingObjs.Item(SelectedObject.ObjectGUID)

                End Select

                'load the node tables for quick comparison
                LoadNodeTable(SelectedObject, DataNodeTable)
                LoadNodeTable(ExistingObject, ExistingNodeTable)

                For Each TableItem As DictionaryEntry In DataNodeTable

                    'check if node exists in both objects
                    If ExistingNodeTable.Contains(TableItem.Key) Then
                        If Not TableItem.Value.ToString = ExistingNodeTable(TableItem.Key).ToString Then
                            Item = New ListViewItem
                            Item.Text = TableItem.Key.ToString & " - " & TableItem.Value.ToString
                            Item.ForeColor = Color.Red
                            DataElements.Items.Add(Item)

                            Item = New ListViewItem
                            Item.Text = TableItem.Key.ToString & " - " & ExistingNodeTable(TableItem.Key).ToString
                            Item.ForeColor = Color.Red
                            ExistingElements.Items.Add(Item)
                        End If
                    Else
                        If TableItem.Value.ToString <> "" Then
                            Item = New ListViewItem
                            Item.Text = TableItem.Key.ToString & " - " & TableItem.Value.ToString
                            Item.ForeColor = Color.Green
                            DataElements.Items.Add(Item)
                        End If
                    End If
                Next

                'check for any removed nodes
                For Each TableItem As DictionaryEntry In ExistingNodeTable
                    If Not DataNodeTable.Contains(TableItem.Key) Then
                        Item = New ListViewItem
                        Item.Text = TableItem.Key.ToString & " - " & TableItem.Value.ToString
                        Item.ForeColor = Color.Gray
                        ExistingElements.Items.Add(Item)
                    End If
                Next

            ElseIf SelectedItem.ForeColor.Equals(Color.Green) Then
                For Each Node As System.Xml.XmlNode In SelectedObject.XMLNode.ChildNodes
                    DataElements.Items.Add(Node.Name & " - " & Node.InnerText)
                Next

            ElseIf SelectedItem.ForeColor.Equals(Color.Gray) Then
                For Each Node As System.Xml.XmlNode In SelectedObject.XMLNode.ChildNodes
                    ExistingElements.Items.Add(Node.Name & " - " & Node.InnerText)
                Next

            End If

        End If
    End Sub

    Private Sub LoadNodeTable(ByVal Obj As Objects.ObjectData, ByVal Table As Hashtable)

        For Each Node As System.Xml.XmlNode In Obj.XMLNode.ChildNodes
            Select Case Node.Name

                Case "ImageFilename"
                    Table.Item(Node.Name) = Obj.ImageFilename

                Case "URL", "Filter"
                    'ignore

                Case "Arcane", "Divine"
                    If Obj.Type = Objects.SpellDefinitionType OrElse Obj.Type = Objects.PowerDefinitionType Then
                        'ignore
                    Else
                        Table.Item(Node.Name) = Node.InnerText
                    End If

                Case Else
                    Table.Item(Node.Name) = Node.InnerText

            End Select
        Next

    End Sub

End Class
