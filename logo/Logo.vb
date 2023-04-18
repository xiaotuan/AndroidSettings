Module Logo

    Public Function SetLogo(ByRef info As ProjectInfo, ByVal logoPath As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTLogo.SetLogo(info, logoPath)
        Else
            Return False
        End If
    End Function

End Module
