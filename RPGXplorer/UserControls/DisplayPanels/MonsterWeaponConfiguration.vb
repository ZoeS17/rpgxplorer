Option Explicit On
Option Strict On

Imports RPGXplorer
Imports RPGXplorer.Rules.Weapons

Public Class MonsterWeaponConfiguration
    Implements IWeaponConfig


#Region "Member Variables"

    Private _Dirty As Boolean = False
    Private _Panel As WeaponsPanel
    Private _Weapons As Rules.MonsterWeapons
    Private _test As Rules.Weapons
    Private _Focused As Boolean = False

    Private StartPoint As Integer = 80

#End Region

#Region "Events"

    Public Event Dirty() Implements IWeaponConfig.Dirty

#End Region

#Region "Properties"

    Public ReadOnly Property Weapons() As Rules.Weapons Implements IWeaponConfig.Weapons
        Get
            Return _Weapons
        End Get
    End Property

    Public Overloads Property Top() As Integer Implements IWeaponConfig.Top
        Get
            Return MyBase.Top
        End Get
        Set(ByVal Value As Integer)
            MyBase.Top = Value
        End Set
    End Property

    Public Overloads Property Left() As Integer Implements IWeaponConfig.Left
        Get
            Return MyBase.Left
        End Get
        Set(ByVal Value As Integer)
            MyBase.Left = Value
        End Set
    End Property


    Public Overloads Property Height() As Integer Implements IWeaponConfig.Height
        Get
            Return MyBase.Height
        End Get
        Set(ByVal Value As Integer)
            MyBase.Height = Value
        End Set
    End Property

    Public Overloads Property Width() As Integer Implements IWeaponConfig.Width
        Get
            Return MyBase.Width
        End Get
        Set(ByVal Value As Integer)
            MyBase.Width = Value
        End Set
    End Property

    Public Overloads Property Anchor() As System.Windows.Forms.AnchorStyles Implements IWeaponConfig.Anchor
        Get
            Return MyBase.Anchor
        End Get
        Set(ByVal Value As System.Windows.Forms.AnchorStyles)
            MyBase.Anchor = Value
        End Set
    End Property

    Public Overloads Property TabStop() As Boolean Implements IWeaponConfig.TabStop
        Get
            Return MyBase.TabStop
        End Get
        Set(ByVal Value As Boolean)
            MyBase.TabStop = Value
        End Set
    End Property

#End Region

    'init 
    Public Sub Init(ByVal Panel As WeaponsPanel, ByVal Weapons As Rules.Weapons) Implements IWeaponConfig.Init
        Try
            _Panel = Panel
            _Weapons = CType(Weapons, Rules.MonsterWeapons)

            'set visable controls
            Dim WeaponsObj As Objects.ObjectData
            WeaponsObj = _Weapons.WeaponsObj

            Dim WeaponCount As Integer

            If WeaponsObj.Element("DisablePrimary") = "Yes" Then
                Primary.Visible = False
            Else
                WeaponCount += 1
            End If

            'get the weapon count and move the description box
            WeaponCount += WeaponsObj.ElementAsInteger("OffHandCount")
            Dim StartPosition As Integer = StartPoint + ((WeaponCount - 1) * 55)
            Dim WidthIncrease As Integer = Description.Location.X - StartPosition
            Description.Location = New System.Drawing.Point(StartPosition, 3)
            Description.Width += WidthIncrease

            'update the borderbox
            ReadOnlyTextBox1.Location = New System.Drawing.Point(StartPosition - 5, 1)
            ReadOnlyTextBox1.Width += WidthIncrease

            'hide remianing boxes
            Select Case WeaponCount
                Case 1
                    OffHand1.Visible = False
                    OffHand2.Visible = False
                    OffHand3.Visible = False
                    OffHand4.Visible = False
                    OffHand5.Visible = False
                Case 2
                    OffHand2.Visible = False
                    OffHand3.Visible = False
                    OffHand4.Visible = False
                    OffHand5.Visible = False
                Case 3
                    OffHand3.Visible = False
                    OffHand4.Visible = False
                    OffHand5.Visible = False
                Case 4
                    OffHand4.Visible = False
                    OffHand5.Visible = False
                Case 5
                    OffHand5.Visible = False
            End Select

            UpdateDisplay()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'update display
    Private Sub UpdateDisplay()
        Dim Display As DisplayDetails

        Try
            Display = _Weapons.GetConfigurationDisplay
            Description.Text = Display.Line1 & Environment.NewLine & Display.Line2
            If Display.Line3 <> "" Then Description.Text &= Environment.NewLine & Display.Line3
            If Display.Line4 <> "" Then Description.Text &= Environment.NewLine & Display.Line4

            'primary
            If _Weapons.PrimaryWield = Wield.NotSet Then
                Primary.Image = Images.DimmedImage("Primary.png")
                Primary.Cursor = Cursors.Hand
            Else
                Primary.Image = Images.Image(_Weapons.PrimaryWeapon.Item.ImageFilename)
                If _Weapons.PrimaryWeapon.IsNatural Then
                    Primary.Cursor = Cursors.Default
                Else
                    Primary.Cursor = Cursors.Hand
                End If
            End If

            'offhands
            'Dim StartPoint As Integer
            Dim WeaponsObj As Objects.ObjectData = _Weapons.WeaponsObj
            Dim OffHandCount As Integer = WeaponsObj.ElementAsInteger("OffHandCount")

            Select Case _Weapons.PrimaryWield
                'Case Wield.DoubleWeapon, Wield.TwoHanded
                '    OffHand.Image = Images.DimmedImage(_Weapons.PrimaryWeapon.Item.ImageFilename)
                Case Else

                    For i As Integer = 1 To OffHandCount
                        If _Weapons.OffHandWield(i) = Wield.NotSet Then
                            GetOffHand(i).Image = Images.DimmedImage("Secondary.png")
                            GetOffHand(i).Cursor = Cursors.Hand
                        Else
                            GetOffHand(i).Image = Images.Image(_Weapons.OffHandItem(i).Item.ImageFilename())
                            If _Weapons.OffHandItem(i).IsNatural Then
                                GetOffHand(i).Cursor = Cursors.Default
                            Else
                                GetOffHand(i).Cursor = Cursors.Hand
                            End If
                        End If
                    Next

            End Select

            'buckler
            If _Weapons.Buckler.BaseItem.IsEmpty Then
                Buckler.Image = Images.DimmedImage("Buckler.png")
            Else
                Buckler.Image = Images.Image(_Weapons.Buckler.Item.ImageFilename())
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    'get the picturebox which displays the given offhand weapon index
    Private Function GetOffHand(ByVal index As Integer) As System.Windows.Forms.PictureBox
        Try
            If Not Primary.Visible Then
                index -= 1
            End If

            Select Case index
                Case 0
                    Return OffHand0
                Case 1
                    Return OffHand1
                Case 2
                    Return OffHand2
                Case 3
                    Return OffHand3
                Case 4
                    Return OffHand4
                Case 5
                    Return OffHand5
            End Select
            Return Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'convert a picturebox index into an Offhand weapon index
    Private Function ConvertWeaponIndex(ByVal index As Integer) As Integer
        Try
            If Not Primary.Visible Then index += 1

            Return index

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    'reset
    Public Sub Reset() Implements IWeaponConfig.Reset
        Try
            _Weapons.PrimaryWeapon.Clear()
            _Weapons.PrimaryWield = Wield.NotSet
            _Weapons.OffHandItem.Clear()
            _Weapons.OffHandWield = Wield.NotSet
            _Weapons.Buckler.Clear()
            UpdateDisplay()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#Region "Click Handlers"

    Private Sub Primary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Primary.Click
        Dim Form As New ChooseWeaponDialog
        Try
            'if it contains a natural weapon quit out
            If _Weapons.PrimaryWeapon.IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.Primary, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.PrimaryWeapon = Form.Choice
                _Weapons.PrimaryWield = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OffHand0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand0.Click
        Dim Form As New ChooseWeaponDialog
        Try

            'if it contains a natural weapon quit out
            If _Weapons.OffHandItem(ConvertWeaponIndex(0)).IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem(ConvertWeaponIndex(0)) = Form.Choice
                _Weapons.OffHandWield(ConvertWeaponIndex(0)) = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OffHand1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand1.Click
        Dim Form As New ChooseWeaponDialog
        Try

            'if it contains a natural weapon quit out
            If _Weapons.OffHandItem(ConvertWeaponIndex(1)).IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem(ConvertWeaponIndex(1)) = Form.Choice
                _Weapons.OffHandWield(ConvertWeaponIndex(1)) = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OffHand2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand2.Click
        Dim Form As New ChooseWeaponDialog
        Try

            'if it contains a natural weapon quit out
            If _Weapons.OffHandItem(ConvertWeaponIndex(2)).IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem(ConvertWeaponIndex(2)) = Form.Choice
                _Weapons.OffHandWield(ConvertWeaponIndex(2)) = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OffHand3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand3.Click
        Dim Form As New ChooseWeaponDialog
        Try

            'if it contains a natural weapon quit out
            If _Weapons.OffHandItem(ConvertWeaponIndex(3)).IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem(ConvertWeaponIndex(3)) = Form.Choice
                _Weapons.OffHandWield(ConvertWeaponIndex(3)) = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OffHand4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand4.Click
        Dim Form As New ChooseWeaponDialog
        Try

            'if it contains a natural weapon quit out
            If _Weapons.OffHandItem(ConvertWeaponIndex(4)).IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem(ConvertWeaponIndex(4)) = Form.Choice
                _Weapons.OffHandWield(ConvertWeaponIndex(4)) = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub OffHand5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand5.Click
        Dim Form As New ChooseWeaponDialog
        Try

            'if it contains a natural weapon quit out
            If _Weapons.OffHandItem(ConvertWeaponIndex(5)).IsNatural Then Exit Sub

            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem(ConvertWeaponIndex(5)) = Form.Choice
                _Weapons.OffHandWield(ConvertWeaponIndex(5)) = Form.Wield
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Buckler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buckler.Click
        Dim Form As New ChooseWeaponDialog

        Try
            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.Buckler, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.Buckler = Form.Choice
                UpdateDisplay()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

#End Region

#Region "Focus"

    Public Shadows Event GotFocus(ByVal sender As Object, ByVal e As EventArgs) Implements IWeaponConfig.GotFocus

    Public Sub SetFocus(ByVal Focused As Boolean) Implements IWeaponConfig.SetFocus
        Try
            If Focused Then
                _Focused = True
                RaiseEvent GotFocus(Me, Nothing)
            Else
                _Focused = False
            End If
            Me.Refresh()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub WeaponConfiguration_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Try
            SetFocus(True)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub Description_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Description.Click
        Try
            SetFocus(True)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
#End Region

#Region "Paint Events"

    Private Sub WeaponConfiguration_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If Not _Panel.IsLoading Then
            If Me.Width > 1 Then
                If _Focused Then
                    'Dim rect As New Rectangle(0, 0, Me.Width, 60)
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, Me.ClientRectangle)
                Else
                    'Dim rect As New Rectangle(0, 0, 200, 60)
                    'Dim gradbrush As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(Me.ClientRectangle, SystemColors.Control, Color.White, Drawing2D.LinearGradientMode.Horizontal)
                    'e.Graphics.FillRectangle(gradbrush, Me.ClientRectangle)
                End If
            End If
        End If
    End Sub

    Private Sub WeaponConfiguration_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'If Not _Panel Is Nothing Then
        '    If Not _Panel.IsLoading Then Me.Refresh()
        'End If
    End Sub

#End Region

    Private Sub WeaponBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Primary.Paint, OffHand0.Paint, OffHand1.Paint, OffHand2.Paint, OffHand3.Paint, OffHand4.Paint, OffHand5.Paint

        Dim Control As PictureBox = CType(sender, PictureBox)
        Dim WeaponsObj As Objects.ObjectData = _Weapons.WeaponsObj
        Dim OffHandCount As Integer = WeaponsObj.ElementAsInteger("OffHandCount")
        Dim AttackNumber, OffHandIndex As Integer

        'get attack number
        Select Case CType(sender, PictureBox).Name
            Case "Primary"
                If Control.Visible Then
                    AttackNumber = WeaponsObj.ElementAsInteger("PrimaryAttackNumber")
                Else
                    Exit Sub
                End If

            Case "OffHand0"
                If Primary.Visible Then
                    Exit Sub
                Else
                    AttackNumber = WeaponsObj.ElementAsInteger("OffHand1AttackNumber")
                End If

            Case Else
                OffHandIndex = ConvertWeaponIndex(Sorter.StripRightNumbers(Control.Name))

                If OffHandIndex > OffHandCount Then
                    Exit Sub
                Else
                    AttackNumber = WeaponsObj.ElementAsInteger("OffHand" + OffHandIndex.ToString + "AttackNumber")
                End If
        End Select

        If AttackNumber > 1 Then
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Dim Rectangle As New RectangleF(32, 0, 20, 15)
            e.Graphics.FillRectangle(Brushes.Ivory, Rectangle)
            e.Graphics.DrawRectangles(Pens.Gray, New RectangleF() {Rectangle})

            'set font size
            Dim drawFont As System.Drawing.Font
            If AttackNumber > 9 Then
                drawFont = New System.Drawing.Font("Arial", 7)
            Else
                drawFont = New System.Drawing.Font("Arial", 9)
            End If

            Dim StringFormat As New StringFormat
            StringFormat.LineAlignment = StringAlignment.Center
            StringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("x" & AttackNumber.ToString, drawFont, Brushes.Black, Rectangle, StringFormat)
        End If

    End Sub

End Class