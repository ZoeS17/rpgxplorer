Option Explicit On
Option Strict On

Imports RPGXplorer
Imports RPGXplorer.Rules.Weapons

Public Class WeaponConfiguration
    Implements IWeaponConfig

#Region "Member Variables"

    Private _Dirty As Boolean = False
    Private _Panel As WeaponsPanel
    Private _Weapons As Rules.Weapons
    Private _Focused As Boolean = False

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
            _Weapons = Weapons
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
            Else
                Primary.Image = Images.Image(_Weapons.PrimaryWeapon.Item.ImageFilename)
            End If

            'offhand
            Select Case _Weapons.PrimaryWield
                Case Wield.DoubleWeapon, Wield.TwoHanded
                    OffHand.Image = Images.DimmedImage(_Weapons.PrimaryWeapon.Item.ImageFilename)
                Case Else
                    If _Weapons.OffHandWield = Wield.NotSet Then
                        OffHand.Image = Images.DimmedImage("Offhand.png")
                    Else
                        OffHand.Image = Images.Image(_Weapons.OffHandItem.Item.ImageFilename())
                    End If
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

    Private Sub OffHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffHand.Click
        Dim Form As New ChooseWeaponDialog

        Try
            SetFocus(True)
            Form.Init(ChooseWeaponDialog.ViewMode.Inventory, Hand.OffHand, _Panel.InventoryFolder, _Panel.Character, _Weapons)
            If Form.ShowDialog() = DialogResult.OK Then
                RaiseEvent Dirty()
                _Weapons.OffHandItem = Form.Choice
                _Weapons.OffHandWield = Form.Wield
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

End Class
