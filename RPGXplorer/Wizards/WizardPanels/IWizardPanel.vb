Option Strict On
Option Explicit On

Public Interface IWizardPanel

    'this interface allows the wizard manager to handle panels generically
    'and to enable/disable wizard manager buttons

    Event EnableNext(ByVal FirstPanel As Boolean)

    Event DisableNext()

    ReadOnly Property IsFirstTab() As Boolean

    ReadOnly Property Initialised() As Boolean

    ReadOnly Property Width() As Integer

    ReadOnly Property Height() As Integer

    Sub InitPanel()

End Interface
