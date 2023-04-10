Module Timezone

    Public Function GetTimezone(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTTimezone.GetTimezone(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetTimezone(ByRef info As ProjectInfo, ByVal zone As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTTimezone.SetTimezone(info, zone)
        Else
            Return False
        End If
    End Function

End Module
