namespace Celeste.Mod.VeryFunnyMod

open Celeste.Mod
open System

type VeryFunnyModModule() as this =
    inherit EverestModule()

    [<DefaultValue>]
    static val mutable private _Instance: VeryFunnyModModule

    static member Instance
        with get (): VeryFunnyModModule = VeryFunnyModModule._Instance
        and set (value: VeryFunnyModModule) = VeryFunnyModModule._Instance <- value

    override this.SettingsType: Type = typeof<VeryFunnyModSettings>

    [<DefaultValue>]
    val mutable private _Settings: VeryFunnyModSettings

    static member Settings: EverestModuleSettings = VeryFunnyModModule.Instance._Settings

    [<DefaultValue>]
    val mutable private _Session: VeryFunnyModSession

    static member Session: EverestModuleSession = VeryFunnyModModule.Instance._Session

    [<DefaultValue>]
    val mutable private _SaveData: VeryFunnyModSaveData

    static member SaveData: EverestModuleSaveData = VeryFunnyModModule.Instance._SaveData

    do
        VeryFunnyModModule._Instance <- this
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof (VeryFunnyModModule), LogLevel.Verbose)
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof (VeryFunnyModModule), LogLevel.Info)
#endif

    override this.Load() = ()
    override this.Unload() = ()
