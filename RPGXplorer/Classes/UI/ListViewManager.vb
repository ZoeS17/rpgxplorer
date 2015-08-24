Option Explicit On
Option Strict On

Imports System.Xml

Public Class ListViewManager

    'this class manages everything to do with loading and saving list view columns

#Region "Data Types"

    'holds an array of column headers and the element map for each object type
    Public Structure ListViewData
        Public Columns As ColumnHeader()
        Public Elements As String()
    End Structure

    'simple dictionary to hold list view column definitions
    Public Class ListViewColumnDefinitions
        Inherits System.Collections.DictionaryBase

        Sub Add(ByVal Key As String, ByVal Data As ListViewData)
            Dictionary.Add(Key, Data)
        End Sub

        Default Property Item(ByVal Key As String) As ListViewData
            Get
                Return CType(dictionary.Item(Key), ListViewData)
            End Get
            Set(ByVal Value As ListViewData)
                Dictionary.Item(Key) = Value
            End Set
        End Property

        'Public Function Clone() As ListViewColumnDefinitions

        'End Function

    End Class

#End Region

#Region "Member Variables"

    'shared vars
    Private Shared _ListViewColumnDefs As New ListViewColumnDefinitions
    Private Shared _ListViewColumnDefsBaseline As New ListViewColumnDefinitions

    'instance vars
    Private ListView As ListView
    Private mSortColumn As Integer = 0
    Private mSortDirection As Windows.Forms.SortOrder
    Private mSortType As General.SortType
    Private mFolderKey As Objects.ObjectKey
    Private mFolderType As String

#End Region

#Region "Properties"

    Public Shared ReadOnly Property ListViewColumnDefs() As ListViewColumnDefinitions
        Get
            Return _ListViewColumnDefs
        End Get
    End Property

    Public Property SortType() As General.SortType
        Get
            Return mSortType
        End Get
        Set(ByVal Value As General.SortType)
            mSortType = Value
        End Set
    End Property

#End Region

    'constructor
    Public Sub New(ByVal ListView As ListView, ByVal NodeKey As Objects.ObjectKey, ByVal FolderType As String, ByVal SortType As General.SortType)
        Me.ListView = ListView
        mSortType = SortType
        mFolderKey = NodeKey
        mFolderType = FolderType

        If mFolderType Is Nothing Then mFolderType = ""

        AddHandler ListView.ColumnClick, AddressOf ListView_ColumnClick
    End Sub

    'load the list view column definitons
    Public Shared Sub LoadListViewColumnDefinitions()
        Dim XmlRdr As XmlTextReader
        Dim Elements(0) As String
        Dim Columns(0) As ColumnHeader
        Dim Column As ColumnHeader = Nothing
        Dim ObjType As String = ""
        Dim Definitions, Pos As Integer
        Dim Data As ListViewData

        XmlRdr = XML.GetXMLTextReader(General.BasePath & "XML\ListViewColumns.xml")

        While XmlRdr.Read
            'get the list view col definition
            Select Case XmlRdr.NodeType
                Case XmlNodeType.Element
                    Select Case XmlRdr.Name
                        Case "ListViewColumnDefinitions"
                            'new set of definitions
                            ObjType = XmlRdr.GetAttribute("type")
                            Definitions = CInt(XmlRdr.GetAttribute("definitions"))

                            ReDim Elements(Definitions - 1)
                            ReDim Columns(Definitions - 1)
                            Pos = 0

                        Case "ListViewColumn"
                            Column = New ColumnHeader
                        Case "ElementName"
                            Elements(Pos) = XmlRdr.ReadString
                        Case "ColumnTitle"
                            Column.Text = XmlRdr.ReadString
                        Case "ColumnAlignment"
                            Select Case XmlRdr.ReadString
                                Case "Left"
                                    Column.TextAlign = HorizontalAlignment.Left
                                Case "Right"
                                    Column.TextAlign = HorizontalAlignment.Right
                                Case "Centred"
                                    Column.TextAlign = HorizontalAlignment.Center
                            End Select
                        Case "ColumnWidth"
                            Column.Width = CInt(XmlRdr.ReadString)
                            Columns(Pos) = Column
                            Pos += 1
                    End Select
                Case XmlNodeType.EndElement
                    'write to the database once we have a full column 
                    If XmlRdr.Name = "ListViewColumnDefinitions" Then
                        Data.Columns = Columns
                        Data.Elements = Elements
                        _ListViewColumnDefs.Add(ObjType, Data)
                        _ListViewColumnDefsBaseline.Add(ObjType, Data)
                    End If

            End Select
        End While

        'single column list views need to set up differently in order for the "extra columns" to work
        ReDim Elements(-1)
        ReDim Columns(0)
        Column = New ColumnHeader
        Column.Text = "Name"
        Column.TextAlign = HorizontalAlignment.Left
        Column.Width = 200
        Columns(0) = Column
        Data.Columns = Columns
        Data.Elements = Elements

        'characters
        _ListViewColumnDefs.Add(Objects.CharacterFolderType, Data)
        _ListViewColumnDefsBaseline.Add(Objects.CharacterFolderType, Data)

        'language
        _ListViewColumnDefs.Add(Objects.LanguageDefinitionFolderType, Data)
        _ListViewColumnDefsBaseline.Add(Objects.LanguageDefinitionFolderType, Data)

        'spell descriptors
        _ListViewColumnDefs.Add(Objects.SpellDescriptorDefinitionFolderType, Data)
        _ListViewColumnDefsBaseline.Add(Objects.SpellDescriptorDefinitionFolderType, Data)

        'special materials
        _ListViewColumnDefs.Add(Objects.SpecialMaterialDefinitionsFolderType, Data)
        _ListViewColumnDefsBaseline.Add(Objects.SpecialMaterialDefinitionsFolderType, Data)

        'spell categoreis
        _ListViewColumnDefs.Add(Objects.SpellCategoryFolder, Data)
        _ListViewColumnDefsBaseline.Add(Objects.SpellCategoryFolder, Data)

    End Sub

    'set the list view columns based on the type of the currently selected object
    Public Sub SetListViewColumns()
        Dim ColumnCount, Dash, Dollar As Integer
        Dim Column As ColumnHeader
        Dim Columns As ColumnHeader()
        Dim ColumnLayout As New Objects.ObjectData
        Dim ColumnList As ArrayList
        Dim ColumnName, ColumnData As String

        'set flag for whether optional columns should be used
        Dim OptionalColumns As Boolean = Objects.ObjectData.ShowOptionalColumns(mFolderType) And (Not _ListViewColumnDefs.Item(mFolderType).Columns Is Nothing)

        'check db for user defined column layout
        Dim Node As XmlNode = XML.SelectSingleNode(XML.DBTypes.ColumnLayouts, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & mFolderKey.ToString & "']")

        If Not Node Is Nothing Then
            ColumnLayout.LoadFromNode(Node)
            mSortColumn = ColumnLayout.ElementAsInteger("SortColumn")
            mSortDirection = CType(ColumnLayout.ElementAsInteger("SortDirection"), Windows.Forms.SortOrder)
            ListView.View = CType(ColumnLayout.ElementAsInteger("View"), Windows.Forms.View)

            ColumnList = ColumnLayout.ElementsAsList

            'count the columns
            If Not _ListViewColumnDefs.Item(mFolderType).Columns Is Nothing Then
                Dim TempColumnCount As Integer = 0
                For Each CName As String In ColumnList
                    Select Case CName
                        Case "NameColumn"
                            'ignore if not a single colum folder
                            Select Case mFolderType
                                Case Objects.CharacterFolderType, Objects.LanguageDefinitionFolderType, Objects.SpellDescriptorDefinitionFolderType, Objects.SpecialMaterialDefinitionsFolderType, Objects.SpellCategoryFolder
                                    TempColumnCount += 1
                            End Select
                        Case "Sourcebook", "Page", "License", "Tags"
                            'ignore
                        Case Else
                            TempColumnCount += 1
                    End Select
                Next
                If _ListViewColumnDefs.Item(mFolderType).Columns.Length <> TempColumnCount Then GoTo DefaultColumns
            End If

            '#If DEBUG Then
            '            'check to see that number of columns matches - DEV ONLY
            '            If Not _ListViewColumnDefs.Item(mFolderType).Columns Is Nothing Then
            '                If _ListViewColumnDefs.Item(mFolderType).Columns.Length <> ColumnList.Count - 1 Then GoTo DefaultColumns
            '            End If
            '#End If

            'optional column widths
            Dim SourcebookWidth, PageNoWidth, TagsWidth, LicenseWidth As Integer

            For n As Integer = 0 To ColumnList.Count - 1
                Column = New ColumnHeader

                ColumnName = ColumnList(n).ToString
                ColumnData = ColumnLayout.Element(ColumnName)
                Dash = ColumnData.IndexOf("-")
                Dollar = ColumnData.IndexOf("$")

                Select Case ColumnName
                    Case "NameColumn"
                        Column.Text = "Name"
                    Case "TypeColumn"
                        Column.Text = "Type"
                    Case "Sourcebook"
                        If OptionalColumns AndAlso General.Config.Element("ShowSourcebook") = "Yes" Then SourcebookWidth = CType(ColumnData.Substring(0, Dash), Integer)
                        Continue For
                    Case "Page"
                        If OptionalColumns AndAlso General.Config.Element("ShowPageNo") = "Yes" Then PageNoWidth = CType(ColumnData.Substring(0, Dash), Integer)
                        Continue For
                    Case "License"
                        If OptionalColumns AndAlso General.Config.Element("ShowLicense") = "Yes" Then LicenseWidth = CType(ColumnData.Substring(0, Dash), Integer)
                        Continue For
                    Case "Tags"
                        If OptionalColumns AndAlso General.Config.Element("ShowTags") = "Yes" Then TagsWidth = CType(ColumnData.Substring(0, Dash), Integer)
                        Continue For
                    Case Else
                        Column.Text = ColumnData.Substring(Dollar + 1)
                End Select

                Column.Width = CType(ColumnData.Substring(0, Dash), Integer)
                Column.TextAlign = CType(ColumnData.Substring(Dash + 1, 1), Windows.Forms.HorizontalAlignment)

                ListView.Columns.Add(Column)
            Next

            'optional columns 
            If OptionalColumns Then
                If General.Config.Element("ShowSourcebook") = "Yes" Then
                    If SourcebookWidth > 0 Then ListView.Columns.Add(SourcebookColumn(SourcebookWidth)) Else ListView.Columns.Add(SourcebookColumn())
                End If
                If General.Config.Element("ShowPageNo") = "Yes" Then
                    If PageNoWidth > 0 Then ListView.Columns.Add(PageNoColumn(PageNoWidth)) Else ListView.Columns.Add(PageNoColumn)
                End If
                If General.Config.Element("ShowLicense") = "Yes" Then
                    If LicenseWidth > 0 Then ListView.Columns.Add(LicenseColumn(LicenseWidth)) Else ListView.Columns.Add(LicenseColumn)
                End If
                If General.Config.Element("ShowTags") = "Yes" Then
                    If TagsWidth > 0 Then ListView.Columns.Add(TagsColumn(TagsWidth)) Else ListView.Columns.Add(TagsColumn)
                End If
            End If
        Else
DefaultColumns:
            'default list view mode
            ListView.View = View.Details

            'default sort
            mSortColumn = 0
            mSortDirection = SortOrder.Ascending

            'add the default columns

            If _ListViewColumnDefs.Item(mFolderType).Columns Is Nothing Then
                ListView.Columns.Add("Name", 200, HorizontalAlignment.Left)
            Else
                If (Not mFolderType = Objects.LanguageDefinitionFolderType) AndAlso (Not mFolderType = Objects.SpellDescriptorDefinitionFolderType) AndAlso (Not mFolderType = Objects.SpecialMaterialDefinitionsFolderType) AndAlso (Not mFolderType = Objects.SpellCategoryFolder) AndAlso (Not mFolderType = Objects.CharacterFolderType) Then
                    ListView.Columns.Add("Name", 200, HorizontalAlignment.Left)
                End If

                Columns = _ListViewColumnDefs.Item(mFolderType).Columns

                ColumnCount = Columns.GetUpperBound(0)
                For n As Integer = 0 To ColumnCount
                    ListView.Columns.Add(CType(Columns(n).Clone(), ColumnHeader))
                Next
            End If

            'optional columns
            If OptionalColumns Then
                If General.Config.Element("ShowSourcebook") = "Yes" Then ListView.Columns.Add(SourcebookColumn)
                If General.Config.Element("ShowPageNo") = "Yes" Then ListView.Columns.Add(PageNoColumn)
                If General.Config.Element("ShowLicense") = "Yes" Then ListView.Columns.Add(LicenseColumn)
                If General.Config.Element("ShowTags") = "Yes" Then ListView.Columns.Add(TagsColumn)
            End If
        End If

        'update list view defs if needed
        If OptionalColumns Then
            'update listview column defs and add optional columns 
            Dim Temp As ListViewData = CType(_ListViewColumnDefsBaseline.Item(mFolderType), ListViewData)

            If General.Config.Element("ShowSourcebook") = "Yes" Then
                If Not Temp.Elements Is Nothing Then
                    ReDim Preserve Temp.Elements(Temp.Elements.GetUpperBound(0) + 1)
                    Temp.Elements(Temp.Elements.GetUpperBound(0)) = "Sourcebook"
                End If
            End If
            If General.Config.Element("ShowPageNo") = "Yes" Then
                If Not Temp.Elements Is Nothing Then
                    ReDim Preserve Temp.Elements(Temp.Elements.GetUpperBound(0) + 1)
                    Temp.Elements(Temp.Elements.GetUpperBound(0)) = "PageNoRef"
                End If
            End If
            If General.Config.Element("ShowLicense") = "Yes" Then
                If Not Temp.Elements Is Nothing Then
                    ReDim Preserve Temp.Elements(Temp.Elements.GetUpperBound(0) + 1)
                    Temp.Elements(Temp.Elements.GetUpperBound(0)) = "License"
                End If
            End If
            If General.Config.Element("ShowTags") = "Yes" Then
                If Not Temp.Elements Is Nothing Then
                    ReDim Preserve Temp.Elements(Temp.Elements.GetUpperBound(0) + 1)
                    Temp.Elements(Temp.Elements.GetUpperBound(0)) = "Tags"
                End If
            End If

            _ListViewColumnDefs.Item(mFolderType) = Temp
        End If
    End Sub

    'sourcebook column
    Private Function SourcebookColumn(Optional ByVal Width As Integer = 200) As ColumnHeader
        Dim Column As New ColumnHeader
        Column.Text = "Sourcebook"
        Column.Width = Width
        Column.TextAlign = HorizontalAlignment.Left
        Return Column
    End Function

    'page no column
    Private Function PageNoColumn(Optional ByVal Width As Integer = 40) As ColumnHeader
        Dim Column As New ColumnHeader
        Column.Text = "Page"
        Column.Width = Width
        Column.TextAlign = HorizontalAlignment.Center
        Return Column
    End Function

    'license column
    Private Function LicenseColumn(Optional ByVal Width As Integer = 70) As ColumnHeader
        Dim Column As New ColumnHeader
        Column.Text = "License"
        Column.Width = Width
        Column.TextAlign = HorizontalAlignment.Center
        Return Column
    End Function

    'tags column
    Private Function TagsColumn(Optional ByVal Width As Integer = 200) As ColumnHeader
        Dim Column As New ColumnHeader
        Column.Text = "Tags"
        Column.Width = Width
        Column.TextAlign = HorizontalAlignment.Left
        Return Column
    End Function

    'save the column layout to the db
    Public Sub SaveColumnLayout()
        Dim ColumnLayout As New Objects.ObjectData
        Dim Column As ColumnHeader
        Dim Node As XmlNode = XML.SelectSingleNode(XML.DBTypes.ColumnLayouts, "/RPGXplorerDatabase/RPGXplorerObject[ParentGUID='" & mFolderKey.ToString & "']")

        If Node Is Nothing Then
            ColumnLayout.Name = "Column Layout"
            ColumnLayout.ObjectGUID = Objects.ObjectKey.NewGuid(XML.DBTypes.ColumnLayouts)
            ColumnLayout.Type = Objects.ColumnLayoutType
            ColumnLayout.ParentGUID = mFolderKey
        Else
            ColumnLayout.LoadFromNode(Node)
        End If

        'write the new layout
        ColumnLayout.ClearElements()
        ColumnLayout.ElementAsInteger("SortColumn") = mSortColumn
        If mSortDirection = SortOrder.None Then mSortDirection = SortOrder.Ascending
        ColumnLayout.ElementAsInteger("SortDirection") = mSortDirection
        ColumnLayout.ElementAsInteger("View") = ListView.View

        If ListView.Columns.Count = 0 Then
            ColumnLayout.Element("NameColumn") = "500-0$Name"
        Else
            For n As Integer = 0 To ListView.Columns.Count - 1
                Column = ListView.Columns.Item(n)
                Select Case Column.Text
                    Case "Name"
                        ColumnLayout.Element("NameColumn") = Column.Width.ToString & "-" & CType(Column.TextAlign, Integer).ToString & "$Name"
                    Case "Type"
                        ColumnLayout.Element("TypeColumn") = Column.Width.ToString & "-" & CType(Column.TextAlign, Integer).ToString & "$"
                    Case Else
                        ColumnLayout.Element(XML.CleanName(Column.Text)) = Column.Width.ToString & "-" & CType(Column.TextAlign, Integer).ToString & "$" & Column.Text
                End Select
            Next
        End If

        ColumnLayout.Save()
    End Sub

    'colour the list view with an alternating colour per line
    Public Sub ColourListView()
        Dim Item As ListViewItem

        If Not ListView Is Nothing Then
            If ListView.View = View.Details And ListView.Columns.Count > 1 Then
                'For Each Item In ListView.Items

                For n As Integer = 0 To ListView.Items.Count - 1
                    Item = ListView.Items(n)
                    If n Mod 2 = 0 Then
                        Item.BackColor = General.ListViewAlternateColourFirst
                    Else
                        Item.BackColor = General.ListViewAlternateColourSecond
                    End If
                    'For Each SubItem In Item.SubItems
                    '    SubItem.BackColor = Item.BackColor
                    'Next
                Next
            Else
                For Each Item In ListView.Items
                    Item.BackColor = General.ListViewAlternateColourFirst
                    'For Each SubItem In Item.SubItems
                    '    SubItem.BackColor = Item.BackColor
                    'Next
                Next
            End If
        End If
    End Sub

    'sort the list view
    Public Sub SortListView()
        ListView.ListViewItemSorter = Nothing
        If ListView.View = View.LargeIcon Then
            ListView.ListViewItemSorter = New Sorter.ListViewItemComparer(mSortType, 0, SortOrder.Ascending)
        Else
            If mSortColumn = 0 Then
                ListView.ListViewItemSorter = New Sorter.ListViewItemComparer(mSortType, 0, mSortDirection)
            Else
                ListView.ListViewItemSorter = New Sorter.ListViewItemComparer(General.SortType.Alphabetic, mSortColumn, mSortDirection)
            End If
        End If
        ListView.Sort()
    End Sub

    'load the given object into the list view
    Public Sub LoadListViewItems(ByVal ObjectList As Objects.ObjectDataCollection, ByVal VirtualObjects As Boolean)
        Dim ListViewItem As ListViewItem
        Dim Element As String
        Dim ColumnCount, ItemNo As Integer
        Dim Items() As ListViewItem

        'init
        ColumnCount = ListView.Columns.Count - 1

        'are there any objects?
        If ObjectList.Count = 0 Then
            Exit Sub
        Else
            ReDim Items(ObjectList.Count - 1)
        End If

        'display them
        ItemNo = 0
        For Each Obj As Objects.ObjectData In ObjectList

            'create a new list view item
            ListViewItem = New ListViewItem(Obj.Name)
            ListViewItem.UseItemStyleForSubItems = True
            ListViewItem.ImageIndex = Images.SmallImageIndex(Obj.ImageFilename)

            If VirtualObjects Then
                ListViewItem.Tag = Obj
            Else
                ListViewItem.Tag = Obj.ObjectGUID
            End If

            'add subitems
            If ColumnCount > 0 Then
                For x As Integer = 0 To ColumnCount - 1
                    Element = ListViewManager.ListViewColumnDefs.Item(mFolderType).Elements(x)
                    If Element = "Type" Then
                        ListViewItem.SubItems.Add(Objects.ObjectTypes.Item(Obj.Type).Friendly)
                    Else
                        ListViewItem.SubItems.Add(Obj.Element(Element))
                    End If
                Next
            End If

            'add to list view
            Items(ItemNo) = ListViewItem
            ItemNo += 1
        Next

        ListView.BeginUpdate()
        ListView.Items.AddRange(Items)
        ListView.EndUpdate()
    End Sub

#Region "Event Handlers"

    'sort column
    Private Sub ListView_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        'sort by column
        If mSortColumn = e.Column Then
            Select Case mSortDirection
                Case SortOrder.None
                    mSortDirection = SortOrder.Ascending
                Case SortOrder.Ascending
                    mSortDirection = SortOrder.Descending
                Case SortOrder.Descending
                    mSortDirection = SortOrder.Ascending
            End Select
        End If
        mSortColumn = e.Column
        SortListView()
        ColourListView()
    End Sub

#End Region

End Class