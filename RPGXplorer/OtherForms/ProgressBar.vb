Option Strict On
Option Explicit On 

Public Class ProgressBar
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
    Public WithEvents Progress As DevExpress.XtraEditors.ProgressBarControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Progress = New DevExpress.XtraEditors.ProgressBarControl
        CType(Me.Progress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Progress
        '
        Me.Progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Progress.Location = New System.Drawing.Point(0, 0)
        Me.Progress.Name = "Progress"
        Me.Progress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Progress.Properties.DisplayFormat.FormatString = "0'%'"
        Me.Progress.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Progress.Properties.EndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Progress.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Progress.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.Progress.Properties.ShowTitle = True
        Me.Progress.Properties.StartColor = System.Drawing.Color.LimeGreen
        Me.Progress.Size = New System.Drawing.Size(400, 31)
        Me.Progress.TabIndex = 0
        '
        'ProgressBar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 31)
        Me.ControlBox = False
        Me.Controls.Add(Me.Progress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ProgressBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caption"
        CType(Me.Progress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'caption
    Public WriteOnly Property Caption() As String
        Set(ByVal Value As String)
            Me.Text = Value
        End Set
    End Property

    'set progress
    Public WriteOnly Property Maximum() As Integer
        Set(ByVal Value As Integer)
            Progress.Properties.Maximum = Value
        End Set
    End Property

    'increment 
    Public Sub Increment()
        Progress.Increment(1)
        Application.DoEvents()
    End Sub

    'increment 
    Public Sub Increment(ByVal Value As Integer)
        Progress.Increment(Value)
        Application.DoEvents()
    End Sub

    'reset
    Public Sub Reset()
        Progress.EditValue = 0
    End Sub

    'switch to working mode
    Public Sub SwitchWorkingOn()
        Progress.Properties.ShowTitle = False
        Progress.Properties.PercentView = False
        Progress.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Vertical
    End Sub

End Class
