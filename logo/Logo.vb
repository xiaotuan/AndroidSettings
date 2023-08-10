Module Logo

    Public Function SetLogo(ByRef info As ProjectInfo, ByVal logoPath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTLogo.SetLogo(info, logoPath)
        Else
            Return False
        End If
    End Function

End Module
