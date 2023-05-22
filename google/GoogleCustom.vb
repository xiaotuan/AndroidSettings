Module GoogleCustom

    Public Function SetChromeHomePage(ByRef info As ProjectInfo, ByVal homePage As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTGoogleCustom.SetChromeHomePage(info, homePage)
        Else
            Return False
        End If
    End Function

    Public Function SetEmailSignature(ByRef info As ProjectInfo, ByVal signature As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTGoogleCustom.SetEmailSignature(info, signature)
        Else
            Return False
        End If
    End Function

End Module
