Module Brightness

    Public Function GetDefaultBrightness(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBrightness.GetDefaultBrightness(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetMaxBrightness(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBrightness.GetMaxBrightness(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetMinBrightness(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBrightness.GetMinBrightness(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetDefaultBrightness(ByRef info As ProjectInfo, ByVal defaultBrightness As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBrightness.SetDefaultBrightness(info, defaultBrightness)
        Else
            Return False
        End If
    End Function

    Public Function SetMaxBrightness(ByRef info As ProjectInfo, ByVal maxBrightness As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBrightness.SetMaxBrightness(info, maxBrightness)
        Else
            Return False
        End If
    End Function

    Public Function SetMinBrightness(ByRef info As ProjectInfo, ByVal minBrightness As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBrightness.SetMinBrightness(info, minBrightness)
        Else
            Return False
        End If
    End Function

End Module
