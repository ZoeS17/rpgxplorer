Option Explicit On 
Option Strict On

Public Interface IPanel

    'simple interface for use by explorer in saving panels when a new panel is about to be shown or re-initialised.

    Property IsDirty() As Boolean

    ReadOnly Property ListView() As ListView

    Sub RefreshPanelData()

    Sub Save()

    WriteOnly Property [ReadOnly]() As Boolean

End Interface


