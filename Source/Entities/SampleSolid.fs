namespace Celeste.Mod.VeryFunnyMod.Entities

open Celeste.Mod
open Celeste
open System
open Microsoft.Xna.Framework
open Celeste.Mod.Entities

[<CustomEntity("VeryFunnyMod/SampleSolid")>]
type SampleSolid(data: EntityData, offset: Vector2) as this =
    inherit Solid(data.Position + offset, float32 data.Width, float32 data.Height, true)
