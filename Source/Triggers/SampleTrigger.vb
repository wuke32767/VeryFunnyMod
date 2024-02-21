Imports Celeste.[Mod].Entities
Imports Microsoft.Xna.Framework

<CustomEntity("VeryBasicMod/SampleTrigger")>
Public Class SampleTrigger
    Inherits Trigger
    Public Sub New(data As EntityData, offset As Vector2)
        MyBase.New(data, offset)
        ' TODO: read properties from data
    End Sub

End Class
