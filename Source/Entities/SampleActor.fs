namespace Celeste.Mod.VeryFunnyMod.Entities

open Celeste.Mod
open Celeste
open System
open Microsoft.Xna.Framework
open Celeste.Mod.Entities

[<CustomEntity("VeryFunnyMod/SampleActor")>]
type SampleActor(data: EntityData, offset: Vector2) as this =
    inherit Actor(data.Position + offset)
