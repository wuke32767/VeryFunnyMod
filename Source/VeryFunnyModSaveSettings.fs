namespace Celeste.Mod.VeryFunnyMod

open Celeste.Mod

type VeryFunnyModSettings() as this =
    inherit Celeste.Mod.EverestModuleSettings()

    let mutable _MySetting: bool = false

    [<SettingSubText(":glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad::glad:")>]
    member this.MySetting
        with get (): bool = _MySetting
        and set (value: bool) = _MySetting <- value
