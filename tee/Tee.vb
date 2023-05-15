Module Tee

    Public Function GetTeeStatus(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTee.GetTeeStatus(info)
        Else
            Return False
        End If
    End Function

    Public Function SetTeeStatus(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTee.SetTeeStatus(info, enabled)
        Else
            Return False
        End If
    End Function

    Public Function SetCertFile(ByRef info As ProjectInfo, ByVal path As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTee.SetCertFile(info, path)
        Else
            Return False
        End If
    End Function

    Public Function SetArrayFile(ByRef info As ProjectInfo, ByVal path As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTee.SetArrayFile(info, path)
        Else
            Return False
        End If
    End Function

End Module
