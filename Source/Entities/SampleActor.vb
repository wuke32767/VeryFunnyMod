Imports Celeste.[Mod].Entities
Imports Microsoft.Xna.Framework

<CustomEntity("VeryBasicMod/SampleActor")>
Public Class SampleActor
    Inherits Actor
    Public Sub New(data As EntityData, offset As Vector2)
        MyBase.New(data.Position + offset)
        ' TODO: read properties from data
    End Sub

End Class
