Imports System.Security.Policy

Module Timezone

    Public Function GetAutoTimezoneState(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTimezone.GetAutoTimezoneState(info)
        Else
            Return False
        End If
    End Function

    Public Function GetTimezone(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTimezone.GetTimezone(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetAutoTimezone(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTimezone.SetAutoTimezone(info, isOpen)
        Else
            Return False
        End If
    End Function

    Public Function SetTimezone(ByRef info As ProjectInfo, ByVal zone As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTTimezone.SetTimezone(info, zone)
        Else
            Return False
        End If
    End Function

End Module
