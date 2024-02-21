Imports Celeste.[Mod].Entities
Imports Microsoft.Xna.Framework
Imports Monocle

<CustomEntity("VeryBasicMod/SampleEntity")>
Public Class SampleEntity
    Inherits Entity
    Public Sub New(data As EntityData, offset As Vector2)
        MyBase.New(data.Position + offset)
        ' TODO: read properties from data
        Add(GFX.SpriteBank.Create("sampleEntity"))
        Collider = New Hitbox(16, 16, -8, -8)
    End Sub

End Class
