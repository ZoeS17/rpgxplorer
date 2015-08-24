<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowserPane
    Inherits System.Windows.Forms.UserControl

    Public Sub New(ByVal DocumentViewer As DocumentViewer)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        _DocViewer = DocumentViewer
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BrowserPane))
        Me.AxWebBrowser1 = New System.Windows.Forms.WebBrowser
        'CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.AxWebBrowser1.Enabled = True
        Me.AxWebBrowser1.Location = New System.Drawing.Point(0, 0)        
        Me.AxWebBrowser1.Size = New System.Drawing.Size(525, 480)
        Me.AxWebBrowser1.TabIndex = 0
        '
        'BrowserPane
        '
        Me.Controls.Add(Me.AxWebBrowser1)
        Me.Name = "BrowserPane"
        Me.Size = New System.Drawing.Size(525, 480)
        'CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public WithEvents AxWebBrowser1 As System.Windows.Forms.WebBrowser

End Class
