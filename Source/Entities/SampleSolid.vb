Imports Celeste.[Mod].Entities
Imports Microsoft.Xna.Framework

<CustomEntity("VeryBasicMod/SampleSolid")>
Public Class SampleSolid
    Inherits Solid
    Public Sub New(data As EntityData, offset As Vector2)
        MyBase.New(data.Position + offset, data.Width, data.Height, True)
        ' TODO: read properties from data
    End Sub

End Class
