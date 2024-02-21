' to whom it may concern: lmao

Public Class VeryBasicModModule
    Inherits EverestModule

    Private Shared _Instance As VeryBasicModModule

    Public Shared Property Instance As VeryBasicModModule
        Get
            Return _Instance
        End Get
        Set(value As VeryBasicModModule)
            _Instance = value
        End Set
    End Property

    Public Overrides ReadOnly Property SettingsType As Type
        Get
            Return GetType(VeryBasicModSettings)
        End Get
    End Property

    Public Shared ReadOnly Property Settings As VeryBasicModSettings
        Get
            Return CType(Instance._Settings, VeryBasicModSettings)
        End Get
    End Property

    Public Overrides ReadOnly Property SessionType As Type
        Get
            Return GetType(VeryBasicModSession)
        End Get
    End Property

    Public Shared ReadOnly Property Session As VeryBasicModSession
        Get
            Return CType(Instance._Session, VeryBasicModSession)
        End Get
    End Property

    Public Overrides ReadOnly Property SaveDataType As Type
        Get
            Return GetType(VeryBasicModSaveData)
        End Get
    End Property

    Public Shared ReadOnly Property SaveData As VeryBasicModSaveData
        Get
            Return CType(Instance._SaveData, VeryBasicModSaveData)
        End Get
    End Property

    Public Sub New()
        Instance = Me

#If DEBUG Then
        ' debug builds use verbose logging
        Logger.SetLogLevel(NameOf(VeryBasicModModule), LogLevel.Verbose)
#Else
        ' release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(NameOf(VeryBasicModModule), LogLevel.Info)
#End If
    End Sub

    Public Overrides Sub Load()
        ' TODO: apply any hooks that should always be active
        Logger.Log(LogLevel.Info, NameOf(VeryBasicModModule), "Hello, world!")
    End Sub

    Public Overrides Sub Unload()
        ' TODO: unapply any hooks applied in Load()
    End Sub

End Class