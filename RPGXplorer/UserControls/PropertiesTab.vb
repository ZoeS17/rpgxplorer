Option Explicit On
Option Strict On

Public Class PropertiesTab

    'Member variables
    Private mObject As Objects.ObjectData
    Private TagList As ArrayList
    Private mMode As RPGXplorer.General.FormMode
    Private ShowOptional As Boolean

    'init controls
    Private Sub InitControls()
        Try
            If ShowOptional Then
                If Not Rules.Lists.UserTags Is Nothing Then TagList = New ArrayList(Rules.Lists.UserTags)

                License.Properties.Items.Add("")
                Sourcebook.Properties.Items.Add("")

                If Not Rules.Lists.Licenses Is Nothing Then License.Properties.Items.AddRange(Rules.Lists.Licenses)
                If Not Rules.Lists.Sourcebooks Is Nothing Then Sourcebook.Properties.Items.AddRange(Rules.Lists.Sourcebooks)

            Else
                License.Enabled = False
                License.Text = "Only available for primary components..."
                Sourcebook.Enabled = False
                Sourcebook.Text = "e.g. Classes, Domains, Feats etc."
                PageNoRef.Enabled = False
                PageNoRef.Text = "NA"
                UserTags.Enabled = False
                UserTags.Text = "NA"
                EditTags.Enabled = False
            End If

            If mMode = General.FormMode.Add Then
                Clear.Enabled = False
                DeletePage.Enabled = False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Init
    Public Sub Init(ByVal Obj As Objects.ObjectData, ByVal Mode As RPGXplorer.General.FormMode)
        Try

            mObject = Obj
            mMode = Mode

            If Obj.AllowReferenceProperties Then ShowOptional = True
            InitControls()

            ObjName.Text = Obj.Name
            UniqueID.Text = Obj.ObjectGUID.ToString()
            Type.Text = Obj.Type

            ImageFilename.Text = Obj.ImageFilename
            License.Text = Obj.Element("License")
            Sourcebook.Text = Obj.Element("Sourcebook")
            UserTags.Text = Obj.Element("Tags")
            PageNoRef.Text = Obj.Element("PageNoRef")

            'help/rule page
            If Obj.HTMLGUID.IsNotEmpty Then
                Dim HelpObj As New Objects.ObjectData

                HelpObj.Load(Obj.HTMLGUID)
                HelpPage.Text = HelpObj.HTML
                HelpPage.Properties.Enabled = False
                HelpPage.BackColor = Color.Silver

                'disable buttons
                ChooseFile.Enabled = False
                DeletePage.Enabled = False
                Clear.Enabled = False
            Else
                HelpPage.Text = Obj.HTML
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Init for use with multiple selected objects
    Public Sub InitForMultiple(ByVal Objs As Objects.ObjectDataCollection)
        Dim Types As ArrayList = Nothing
        Dim TypeName As String
        Dim Obj As New Objects.ObjectData

        Try
            'determine whether license, sourcebook etc. are enabled.
            If Objs.Count = 1 Then
                If Obj.AllowReferenceProperties Then ShowOptional = True
            Else
                Types = Objs.GetTypes
                For Each Type As String In Types
                    If Objects.ObjectData.AllowReferenceProperties(Type) Then
                        ShowOptional = True
                        Exit For
                    End If
                Next
            End If
            InitControls()

            'init
            If Objs.Count = 1 Then
                Obj = Objs.Item(0)
                mObject = Obj
                ObjName.Text = Obj.Name
                UniqueID.Text = Obj.ObjectGUID.ToString
                Type.Text = Obj.Type
                ImageFilename.Text = Obj.ImageFilename
                License.Text = Obj.Element("License")
                Sourcebook.Text = Obj.Element("Sourcebook")
                UserTags.Text = Obj.Element("Tags")
                PageNoRef.Text = Obj.Element("PageNoRef")

                'help/rule page
                If Obj.HTMLGUID.IsNotEmpty Then
                    Dim HelpObj As New Objects.ObjectData

                    HelpObj.Load(Obj.HTMLGUID)
                    HelpPage.Text = HelpObj.HTML
                    HelpPage.Properties.Enabled = False
                    HelpPage.BackColor = Color.Silver

                    'disable buttons
                    ChooseFile.Enabled = False
                    DeletePage.Enabled = False
                    Clear.Enabled = False
                Else
                    HelpPage.Text = Obj.HTML
                End If
            Else
                ObjName.Text = "Multiple Components Selected"
                UniqueID.Text = "Multiple Components Selected"

                'types
                For Each TypeName In Types
                    If Type.Text <> "" Then Type.Text &= ", "
                    Type.Text &= TypeName
                Next

                'page buttons
                DeletePage.Enabled = False
                Clear.Enabled = False

                'check to see if any of the objects have an HTML reference
                For Each Obj In Objs
                    If Obj.HTMLGUID.IsNotEmpty Then
                        HelpPage.Text = "Selection contains fixed HTML references."
                        HelpPage.Properties.Enabled = False
                        HelpPage.BackColor = Color.Silver
                        ChooseFile.Enabled = False
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Update the object with the properties
    Public Function UpdateObject(ByVal Obj As Objects.ObjectData) As Objects.ObjectData
        Try
            Obj.HTML = HelpPage.Text
            If ImageFilename.Text <> "" Then Obj.ImageFilename = ImageFilename.Text

            If ShowOptional Then
                Obj.Element("License") = License.Text
                Obj.Element("Sourcebook") = Sourcebook.Text
                Obj.Element("Tags") = UserTags.Text
                Obj.Element("PageNoRef") = PageNoRef.Text
            End If

            Return Obj

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'Update multiple selected objects
    Public Sub UpdateMultipleObjects()
        Dim Obj As Objects.ObjectData

        Try
            For Each Obj In General.MainExplorer.CurrentSelectedObjects
                If HelpPage.Text <> "" Then Obj.HTML = HelpPage.Text
                If ImageFilename.Text <> "" Then Obj.ImageFilename = ImageFilename.Text
                If ShowOptional Then
                    If License.Text <> "" Then Obj.Element("License") = License.Text
                    If Sourcebook.Text <> "" Then Obj.Element("Sourcebook") = Sourcebook.Text
                    If UserTags.Text <> "" Then Obj.Element("Tags") = UserTags.Text
                    If PageNoRef.Text <> "" Then Obj.Element("PageNoRef") = PageNoRef.Text
                End If
                Obj.Save()
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'Validate
    Public Shadows Function Validate() As Boolean
        Try
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'choose the help page file
    Private Sub ChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseFile.Click
        Dim temp As String

        Try
            OpenFileDialog1.Filter = "All files (*.*)|*.*"

            If Not mObject.IsEmpty Then
                Select Case mObject.Type
                    Case Objects.FeatDefinitionType
                        OpenFileDialog1.InitialDirectory = General.BasePath & "HTML\HelpPages\Feats\"
                    Case Objects.SkillDefinitionType
                        OpenFileDialog1.InitialDirectory = General.BasePath & "HTML\HelpPages\Skills"
                    Case Objects.SpellDefinitionType, Objects.PotionDefinitionType
                        OpenFileDialog1.InitialDirectory = General.BasePath & "HTML\HelpPages\Spells\"
                    Case Else
                        OpenFileDialog1.InitialDirectory = General.BasePath & "HTML\HelpPages\"
                End Select
            Else
                OpenFileDialog1.InitialDirectory = General.BasePath & "HTML\HelpPages\"
            End If
            OpenFileDialog1.RestoreDirectory = True

            If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                temp = OpenFileDialog1.FileName
                If temp.IndexOf(General.BasePath & "HTML\HelpPages\") <> -1 Then
                    temp = temp.Replace(General.BasePath & "HTML\HelpPages\", "")
                End If
                HelpPage.Text = temp
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'choose the image file
    Private Sub ChooseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseImage.Click
        Dim temp As String

        Try
            OpenFileDialog1.Filter = "Image Files (*.bmp; *.png)| *.bmp; *.png"
            OpenFileDialog1.InitialDirectory = General.BasePath & "Images\LargeImages\"
            OpenFileDialog1.RestoreDirectory = True

            If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                temp = OpenFileDialog1.FileName
                If temp.IndexOf(General.BasePath & "Images\LargeImages\") = -1 Then
                    General.ShowErrorDialog(General.InvalidImagesPath)
                Else
                    ImageFilename.Text = temp.Replace(General.BasePath & "Images\LargeImages\", "")
                End If
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'edit tags
    Private Sub EditTags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTags.Click
        Try
            If TagList Is Nothing Then
                General.ShowInfoDialog("No Tags defined. Please go to Tools -> Edit a List")
                Exit Sub
            End If

            Dim Form As New ConstructListDialog

            'get value lists
            Dim Tags As ArrayList

            If UserTags.Text = "" Then
                Tags = New ArrayList
            Else
                Tags = New ArrayList(UserTags.Text.Split(New Char() {";"c}))
            End If

            'init and show form
            Form.Init("Tags", "Tags", "Please select the Tags to be assigned.", "Available Tags", "Tags Assigned")
            Form.InitTextList(TagList, Tags)

            If Form.ShowDialog() = DialogResult.OK Then
                Tags = Form.ListBFinal
                UserTags.Text = CommonLogic.DelimitedList(";", Tags)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'delete rule/help page
    Private Sub DeletePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePage.Click
        Try

            If HelpPage.Text = "" Then
                General.ShowInfoDialog("Rule/Help Page not set.")
                Exit Sub
            End If

            If General.ShowQuestionDialog("Are you sure?") = DialogResult.Yes Then
                Dim RetVal As Integer = RulePageManager.Delete(HelpPage.Text, New Objects.ObjectKey(UniqueID.Text))
                If RetVal >= 0 Then
                    If General.ShowQuestionDialog("This page is referenced by other components. Delete Anyway?") = DialogResult.Yes Then
                        RetVal = RulePageManager.Delete(HelpPage.Text, Nothing, True)
                        If RetVal <> -999 Then
                            HelpPage.Text = ""
                        End If
                    End If
                Else
                    If RetVal <> -999 Then
                        HelpPage.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'clear 
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Try
            mObject.CreateDefaultRulePage()
            HelpPage.Text = mObject.HTML
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
