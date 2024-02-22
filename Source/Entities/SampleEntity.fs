namespace Celeste.Mod.VeryFunnyMod.Entities

open Celeste.Mod
open Celeste
open System
open Monocle
open Microsoft.Xna.Framework
open Celeste.Mod.Entities

[<CustomEntity("VeryFunnyMod/SampleEntity")>]
type SampleEntity(data: EntityData, offset: Vector2) as this =
    inherit Entity(data.Position + offset)

    do
        this.Add(GFX.SpriteBank.Create("sampleEntity"))
        this.Collider <- new Hitbox(16f, 16f, -8f, -8f)
