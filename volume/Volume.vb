Module Volume

    Public Function GetCallVolume(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.GetCallVolume(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetRingVolume(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.GetRingVolume(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetMusicVolume(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.GetMusicVolume(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetAlarmVolume(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.GetAlarmVolume(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetNotificationVolume(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.GetNotificationVolume(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetOtherVolume(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.GetOtherVolume(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetCallVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.SetCallVolume(info, volume)
        Else
            Return False
        End If
    End Function

    Public Function SetRingVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.SetRingVolume(info, volume)
        Else
            Return False
        End If
    End Function

    Public Function SetMusicVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.SetMusicVolume(info, volume)
        Else
            Return False
        End If
    End Function

    Public Function SetAlarmVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.SetAlarmVolume(info, volume)
        Else
            Return False
        End If
    End Function

    Public Function SetNotificationVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.SetNotificationVolume(info, volume)
        Else
            Return False
        End If
    End Function

    Public Function SetOtherVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVolume.SetOtherVolume(info, volume)
        Else
            Return False
        End If
    End Function

End Module
