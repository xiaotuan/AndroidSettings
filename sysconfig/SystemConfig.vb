Module SystemConfig

    Public Function GetScreeOffTime(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.GetScreeOffTime(info)
        Else
            Return ""
        End If
    End Function

    Public Function IsAutoTime(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.IsAutoTime(info)
        Else
            Return False
        End If
    End Function

    Public Function IsAutoRotation(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.IsAutoRotation(info)
        Else
            Return False
        End If
    End Function

    Public Function IsAutoBrightness(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.IsAutoBrightness(info)
        Else
            Return False
        End If
    End Function

    Public Function IsGPSOn(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.IsGPSOn(info)
        Else
            Return False
        End If
    End Function

    Public Function IsDisableScreenLock(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.IsDisableScreenLock(info)
        Else
            Return False
        End If
    End Function

    Public Function Is24TimeFormat(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.Is24TimeFormat(info)
        Else
            Return False
        End If
    End Function

    Public Function SetScreenOffTime(ByRef info As ProjectInfo, ByVal time As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.SetScreenOffTime(info, time)
        Else
            Return False
        End If
    End Function

    Public Function SetAutoTime(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.SetAutoTime(info, state)
        Else
            Return False
        End If
    End Function

    Public Function SetAutoRotation(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.SetAutoRotation(info, state)
        Else
            Return False
        End If
    End Function

    Public Function SetAutoBrightness(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.SetAutoBrightness(info, state)
        Else
            Return False
        End If
    End Function

    Public Function SetGps(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.SetGps(info, state)
        Else
            Return False
        End If
    End Function

    Public Function SetDisableScreenLock(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.SetDisableScreenLock(info, state)
        Else
            Return False
        End If
    End Function

    Public Function Set24TimeFormat(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSystemConfig.Set24TimeFormat(info, state)
        Else
            Return False
        End If
    End Function

End Module
