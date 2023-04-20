Module Sample

    Public Function GetSampleStatus(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSample.GetSampleStatus(info)
        Else
            Return False
        End If
    End Function

    Public Function GetSampleName(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSample.GetSampleName(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetSampleStatus(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSample.SetSampleStatus(info, enabled)
        Else
            Return False
        End If
    End Function

    Public Function SetSampleName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTSample.SetSampleName(info, name)
        Else
            Return False
        End If
    End Function

End Module
