namespace Celeste.Mod.VeryFunnyMod.Triggers

open Celeste.Mod
open Celeste
open System
open Microsoft.Xna.Framework
open Celeste.Mod.Entities

[<CustomEntity("VeryFunnyMod/SampleTrigger")>]
type SampleTrigger(data: EntityData, offset: Vector2) as this =
    inherit Trigger(data, offset)
