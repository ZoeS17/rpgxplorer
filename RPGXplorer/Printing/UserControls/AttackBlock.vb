Public Class AttackBlock
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Height = 100
    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Public WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Public WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemoEdit1
        '
        Me.MemoEdit1.EditValue = "MemoEdit1"
        Me.MemoEdit1.Location = New System.Drawing.Point(225, 10)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(115, 40)
        Me.MemoEdit1.TabIndex = 0
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "alksdjf;alksjd l;aksjdf ;laksjdf; lakjsd flkjas;ldkfj alsdj falksdj fl"
        Me.TextEdit1.Location = New System.Drawing.Point(385, 50)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.TabIndex = 1
        '
        'AttackBlock
        '
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.MemoEdit1)
        Me.Name = "AttackBlock"
        Me.Size = New System.Drawing.Size(535, 75)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Public Property Display() As String
    '    Get
    '        Return DisplayText.Text
    '    End Get
    '    Set(ByVal Value As String)
    '        DisplayText.Text = Value
    '    End Set
    'End Property

End Class
