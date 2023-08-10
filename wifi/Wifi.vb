Module Wifi

    Public Function GetWifiDefaultState(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWifi.GetWifiDefaultState(info)
        Else
            Return False
        End If
    End Function

    Public Function GetHotspotName(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWifi.GetHotspotName(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetScreenCastName(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWifi.GetScreenCastName(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetWifiDefaultState(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWifi.SetWifiDefaultState(info, isOpen)
        Else
            Return False
        End If
    End Function

    Public Function SetHotspotName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWifi.SetHotspotName(info, name)
        Else
            Return False
        End If
    End Function

    Public Function SetScreenCastName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWifi.SetScreenCastName(info, name)
        Else
            Return False
        End If
    End Function

End Module
