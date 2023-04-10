Module Language

    Public Function GetLanguage(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTLanguage.GetLanguage(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetLanguage(ByRef info As ProjectInfo, ByVal language As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTLanguage.SetLanguage(info, language)
        Else
            Return False
        End If
    End Function

End Module
