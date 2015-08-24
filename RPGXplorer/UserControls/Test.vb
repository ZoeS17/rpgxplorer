Public Class Test
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Public WithEvents CharacterName As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CharacterName = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        CType(Me.CharacterName, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'CharacterName
        '
        Me.CharacterName.AutoHeight = False
        Me.CharacterName.Name = "CharacterName"
        '
        'Test
        '
        Me.Name = "Test"
        Me.Size = New System.Drawing.Size(520, 360)
        CType(Me.CharacterName, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class
