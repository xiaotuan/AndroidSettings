Imports System.IO

Module Animation

    Public Function SetBootRing(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) And File.Exists(filePath) Then
            Return AndroidTAnimation.SetBootRing(info, filePath)
        Else
            Return False
        End If
    End Function

    Public Function SetBootAnim(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) And File.Exists(filePath) Then
            Return AndroidTAnimation.SetBootAnim(info, filePath)
        Else
            Return False
        End If
    End Function

    Public Function SetShutdownRing(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) And File.Exists(filePath) Then
            Return AndroidTAnimation.SetShutdownRing(info, filePath)
        Else
            Return False
        End If
    End Function

    Public Function SetShutdownAnim(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) And File.Exists(filePath) Then
            Return AndroidTAnimation.SetShutdownAnim(info, filePath)
        Else
            Return False
        End If
    End Function

End Module
