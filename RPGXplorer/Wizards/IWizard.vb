Option Strict On
Option Explicit On

Public Interface IWizard

    'this interface represent the relationship between the wizard and the wizard manager

    Function NextPanel() As IWizardPanel

    Function PreviousPanel() As IWizardPanel

    Sub Finish()

    Sub Cancel()

    Sub InitialUpdate()

    Event EnableFinish()

    Event DisableFinish()

End Interface
