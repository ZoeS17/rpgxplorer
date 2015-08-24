Imports System.ComponentModel

Public Class AttributeCircle

    <Bindable(True)> Public Overrides Property Text() As String
        Get
            Return ValueLabel.Text
        End Get
        Set(ByVal value As String)
            ValueLabel.Text = value
        End Set
    End Property

End Class
