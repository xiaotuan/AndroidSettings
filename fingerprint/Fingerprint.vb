Module Fingerprint

    Public Function GetFingerprint(ByRef info As ProjectInfo) As String
        Debug.WriteLine("[Fingerprint] GetFingerprint=>Android version: " + info.AndroidVersion)
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTFingerprint.GetFingerprint(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetFingerprint(ByRef info As ProjectInfo, ByVal fp As String) As Boolean
        Debug.WriteLine("[Version] SetFingerprint=>fp: " + fp)
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTFingerprint.SetFingerprint(info, fp)
        Else
            Return False
        End If
    End Function

End Module
