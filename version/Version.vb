Module Version

    Public Function GetVersion(ByRef info As ProjectInfo) As String
        Debug.WriteLine("[Version] GetVersion=>Android version: " + info.AndroidVersion)
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTVersion.GetVersion(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetVersion(ByRef info As ProjectInfo, ByVal version As String) As Boolean
        Debug.WriteLine("[Version] SetVersion=>version: " + version)
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTVersion.SetVersion(info, version)
        Else
            Return False
        End If
    End Function

End Module
