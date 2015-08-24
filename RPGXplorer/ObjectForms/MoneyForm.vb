Option Explicit On
Option Strict On

Imports RPGXplorer.Exceptions
Imports RPGXplorer.General
Imports RPGXplorer.Rules

Public Class MoneyForm
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents Errors As System.Windows.Forms.ErrorProvider
    Public WithEvents MoneyTab As System.Windows.Forms.TabPage
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents IndentedLine1 As RPGXplorer.IndentedLine
    Public WithEvents ValueInGP As RPGXplorer.ReadOnlyTextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Weight As RPGXplorer.ReadOnlyTextBox
    Public WithEvents IndentedLine2 As RPGXplorer.IndentedLine
    Public WithEvents ConvertToGold As System.Windows.Forms.Button
    Public WithEvents ConvertToPlatinum As System.Windows.Forms.Button
    Public WithEvents Coins As RPGXplorer.MoneySpin2
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents AddRemove As System.Windows.Forms.TabPage
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents AddSubtractCoins As RPGXplorer.MoneySpin2
    Public WithEvents AddCoins As System.Windows.Forms.Button
    Public WithEvents IndentedLine3 As RPGXplorer.IndentedLine
    Public WithEvents SubtractCoins As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.MoneyTab = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.ConvertToPlatinum = New System.Windows.Forms.Button
        Me.ConvertToGold = New System.Windows.Forms.Button
        Me.IndentedLine2 = New RPGXplorer.IndentedLine
        Me.Label2 = New System.Windows.Forms.Label
        Me.Weight = New RPGXplorer.ReadOnlyTextBox
        Me.IndentedLine1 = New RPGXplorer.IndentedLine
        Me.Coins = New RPGXplorer.MoneySpin2
        Me.Label4 = New System.Windows.Forms.Label
        Me.ValueInGP = New RPGXplorer.ReadOnlyTextBox
        Me.AddRemove = New System.Windows.Forms.TabPage
        Me.SubtractCoins = New System.Windows.Forms.Button
        Me.AddCoins = New System.Windows.Forms.Button
        Me.IndentedLine3 = New RPGXplorer.IndentedLine
        Me.Label3 = New System.Windows.Forms.Label
        Me.AddSubtractCoins = New RPGXplorer.MoneySpin2
        Me.Errors = New System.Windows.Forms.ErrorProvider
        Me.TabControl1.SuspendLayout()
        Me.MoneyTab.SuspendLayout()
        Me.AddRemove.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(160, 365)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(70, 24)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errors.SetIconAlignment(Me.OK, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Errors.SetIconPadding(Me.OK, 6)
        Me.OK.Location = New System.Drawing.Point(80, 365)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(70, 24)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.MoneyTab)
        Me.TabControl1.Controls.Add(Me.AddRemove)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(215, 335)
        Me.TabControl1.TabIndex = 0
        '
        'MoneyTab
        '
        Me.MoneyTab.Controls.Add(Me.Label1)
        Me.MoneyTab.Controls.Add(Me.ConvertToPlatinum)
        Me.MoneyTab.Controls.Add(Me.ConvertToGold)
        Me.MoneyTab.Controls.Add(Me.IndentedLine2)
        Me.MoneyTab.Controls.Add(Me.Label2)
        Me.MoneyTab.Controls.Add(Me.Weight)
        Me.MoneyTab.Controls.Add(Me.IndentedLine1)
        Me.MoneyTab.Controls.Add(Me.Coins)
        Me.MoneyTab.Controls.Add(Me.Label4)
        Me.MoneyTab.Controls.Add(Me.ValueInGP)
        Me.MoneyTab.Location = New System.Drawing.Point(4, 22)
        Me.MoneyTab.Name = "MoneyTab"
        Me.MoneyTab.Size = New System.Drawing.Size(207, 309)
        Me.MoneyTab.TabIndex = 0
        Me.MoneyTab.Text = "Money"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Coins"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConvertToPlatinum
        '
        Me.ConvertToPlatinum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConvertToPlatinum.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ConvertToPlatinum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertToPlatinum.Location = New System.Drawing.Point(15, 270)
        Me.ConvertToPlatinum.Name = "ConvertToPlatinum"
        Me.ConvertToPlatinum.Size = New System.Drawing.Size(175, 24)
        Me.ConvertToPlatinum.TabIndex = 2
        Me.ConvertToPlatinum.Text = "Convert to Platinum Coins"
        '
        'ConvertToGold
        '
        Me.ConvertToGold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConvertToGold.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ConvertToGold.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertToGold.Location = New System.Drawing.Point(15, 235)
        Me.ConvertToGold.Name = "ConvertToGold"
        Me.ConvertToGold.Size = New System.Drawing.Size(175, 24)
        Me.ConvertToGold.TabIndex = 1
        Me.ConvertToGold.Text = "Convert to Gold Coins"
        '
        'IndentedLine2
        '
        Me.IndentedLine2.Location = New System.Drawing.Point(15, 220)
        Me.IndentedLine2.Name = "IndentedLine2"
        Me.IndentedLine2.Size = New System.Drawing.Size(175, 5)
        Me.IndentedLine2.TabIndex = 272
        Me.IndentedLine2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(15, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Weight"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Weight
        '
        Me.Weight.BackColor = System.Drawing.Color.White
        Me.Weight.Caption = Nothing
        Me.Weight.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Weight.DockPadding.All = 1
        Me.Weight.ForeColor = System.Drawing.Color.Black
        Me.Weight.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.Weight.Location = New System.Drawing.Point(90, 185)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(100, 21)
        Me.Weight.TabIndex = 270
        Me.Weight.TabStop = False
        Me.Weight.TextColor = System.Drawing.Color.Black
        Me.Weight.Vertical = False
        '
        'IndentedLine1
        '
        Me.IndentedLine1.Location = New System.Drawing.Point(15, 140)
        Me.IndentedLine1.Name = "IndentedLine1"
        Me.IndentedLine1.Size = New System.Drawing.Size(175, 5)
        Me.IndentedLine1.TabIndex = 267
        Me.IndentedLine1.TabStop = False
        '
        'Coins
        '
        Me.Coins.Location = New System.Drawing.Point(90, 15)
        Me.Coins.Name = "Coins"
        Me.Coins.Size = New System.Drawing.Size(100, 111)
        Me.Coins.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(15, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Value in GP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValueInGP
        '
        Me.ValueInGP.BackColor = System.Drawing.Color.White
        Me.ValueInGP.Caption = Nothing
        Me.ValueInGP.CaptionAligment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ValueInGP.DockPadding.All = 1
        Me.ValueInGP.ForeColor = System.Drawing.Color.Black
        Me.ValueInGP.LineColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(168, Byte), CType(153, Byte))
        Me.ValueInGP.Location = New System.Drawing.Point(90, 155)
        Me.ValueInGP.Name = "ValueInGP"
        Me.ValueInGP.Size = New System.Drawing.Size(100, 21)
        Me.ValueInGP.TabIndex = 263
        Me.ValueInGP.TabStop = False
        Me.ValueInGP.TextColor = System.Drawing.Color.Black
        Me.ValueInGP.Vertical = False
        '
        'AddRemove
        '
        Me.AddRemove.Controls.Add(Me.SubtractCoins)
        Me.AddRemove.Controls.Add(Me.AddCoins)
        Me.AddRemove.Controls.Add(Me.IndentedLine3)
        Me.AddRemove.Controls.Add(Me.Label3)
        Me.AddRemove.Controls.Add(Me.AddSubtractCoins)
        Me.AddRemove.Location = New System.Drawing.Point(4, 22)
        Me.AddRemove.Name = "AddRemove"
        Me.AddRemove.Size = New System.Drawing.Size(207, 309)
        Me.AddRemove.TabIndex = 1
        Me.AddRemove.Text = "Add or Subtract"
        '
        'SubtractCoins
        '
        Me.SubtractCoins.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubtractCoins.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SubtractCoins.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractCoins.Location = New System.Drawing.Point(15, 190)
        Me.SubtractCoins.Name = "SubtractCoins"
        Me.SubtractCoins.Size = New System.Drawing.Size(175, 24)
        Me.SubtractCoins.TabIndex = 2
        Me.SubtractCoins.Text = "Subtract Coins"
        '
        'AddCoins
        '
        Me.AddCoins.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddCoins.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddCoins.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCoins.Location = New System.Drawing.Point(15, 155)
        Me.AddCoins.Name = "AddCoins"
        Me.AddCoins.Size = New System.Drawing.Size(175, 24)
        Me.AddCoins.TabIndex = 1
        Me.AddCoins.Text = "Add Coins"
        '
        'IndentedLine3
        '
        Me.IndentedLine3.Location = New System.Drawing.Point(15, 140)
        Me.IndentedLine3.Name = "IndentedLine3"
        Me.IndentedLine3.Size = New System.Drawing.Size(175, 5)
        Me.IndentedLine3.TabIndex = 278
        Me.IndentedLine3.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 275
        Me.Label3.Text = "Coins"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddSubtractCoins
        '
        Me.AddSubtractCoins.Location = New System.Drawing.Point(90, 15)
        Me.AddSubtractCoins.Name = "AddSubtractCoins"
        Me.AddSubtractCoins.Size = New System.Drawing.Size(100, 111)
        Me.AddSubtractCoins.TabIndex = 0
        '
        'Errors
        '
        Me.Errors.ContainerControl = Me
        '
        'MoneyForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(244, 403)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MoneyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Money"
        Me.TabControl1.ResumeLayout(False)
        Me.MoneyTab.ResumeLayout(False)
        Me.AddRemove.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObject As Objects.ObjectData
    Private mFolder As Objects.ObjectData
    Private mMode As FormMode

    Private Character As Rules.Character

    'init
    Public Sub Init()

        Try
            'init controls
            UpdateDisplays()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for add
    Public Sub InitAdd(ByVal Folder As Objects.ObjectData)
        Try
            'init form vars
            mFolder = Folder
            mMode = FormMode.Add

            'init object
            mObject.ObjectGUID = Objects.ObjectKey.NewGuid(Folder.ObjectGUID.Database)
            mObject.Type = Objects.MoneyType
            mObject.ParentGUID = mFolder.ObjectGUID

            'init form
            Me.Text = "Add Money"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\goldbar.ico")

            'init controls
            Coins.Money = New Money

            'get the character
            Character = CharacterManager.GetCharacter(Folder.GetCharacterKey)

            Init()

            'dont need this page when just adding
            TabControl1.TabPages.Remove(AddRemove)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'initialise the form for edit
    Public Sub InitEdit(ByVal Obj As Objects.ObjectData)
        Try
            'init form vars
            mObject = Obj
            mMode = FormMode.Edit

            'init form
            Me.Text = "Edit Money"
            Me.Icon = New Drawing.Icon(General.BasePath & "Icons\goldbar.ico")

            'init controls
            Coins.Money = New Money(Obj.Name)

            'get the character - get the character from the panel (in case locked window)
            Character = CharacterManager.GetCharacter(WindowManager.CurrentWindow.CharacterKey).Clone()

            Init()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'save changes
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            If Me.Validate Then

                General.MainExplorer.Undo.UndoRecord()

                Select Case mMode
                    Case FormMode.Add
                        'do nothing yet
                    Case FormMode.Edit
                End Select

                'updates common to add and edit
                mObject.Name = Coins.Money.DisplayString
                mObject.Element("Cost") = Coins.Money.DisplayString
                mObject.Element("Weight") = Weight.Text

                'save, refresh explorer and close
                mObject.Save()
                WindowManager.SetDirty(mObject.Parent)
                CharacterManager.SetDirty(Character.CharacterObject.ObjectGUID, CharacterManager.DirtyStatus.Recalculate)
                General.MainExplorer.RefreshPanel()
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

#Region "Validation"

    'form validation
    Private Shadows Function Validate() As Boolean
        Try
            Validate = True

            If Coins.Money.InCopper = 0 Then
                Errors.SetError(Coins, General.ValidationCannotBeZero)
                Validate = False
            Else
                Errors.SetError(Coins, "")
            End If

            General.ValidateFormIndicator(Validate, OK, Errors)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

#End Region

    'update display
    Private Sub UpdateDisplays()
        Dim Gold As Money = New Money(Coins.Money.InGold.Gold & "gp")
        ValueInGP.Text = Gold.DisplayString
        Weight.Text = Rules.Formatting.FormatPounds(Coins.Money.Weight)
    End Sub

    'value changed
    Private Sub Coins_ValueChanged() Handles Coins.ValueChanged
        UpdateDisplays()
    End Sub

    'convert to gold
    Private Sub ConvertToGold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToGold.Click
        If General.ShowQuestionDialog("Are you sure?") = DialogResult.Yes Then
            Coins.Money = Coins.Money.InGold
            UpdateDisplays()
        End If
    End Sub

    'convert to platinum
    Private Sub ConvertToPlatinum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToPlatinum.Click
        If General.ShowQuestionDialog("Are you sure?") = DialogResult.Yes Then
            Coins.Money = Coins.Money.InPlatinum
            UpdateDisplays()
        End If
    End Sub

    'add coins
    Private Sub AddCoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCoins.Click
        Coins.Money.AddMoney(AddSubtractCoins.Money)
        Me.TabControl1.SelectedIndex = 0
        Coins.Refresh()
    End Sub

    'subtract coins
    Private Sub SubtractCoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtractCoins.Click
        If AddSubtractCoins.Money.InCopper > Coins.Money.InCopper Then
            General.ShowInfoDialog("You cannot subtract this amount as it is greater than the amount being subtracted from.")
        Else
            Coins.Money.RemoveMoney(AddSubtractCoins.Money)
            Me.TabControl1.SelectedIndex = 0
            Coins.Refresh()
        End If
    End Sub

End Class
