' Fingerprint 模块类似接口，根据不同的 Android 系统，选择不同实现模块设置 fingerprint
' 当前只实现了 Android 13 系统的修改
Module Fingerprint

    ' 获取 fingerprint
    '
    ' info： 工程信息
    '
    ' return：获取成功返回 fingerprint，否则返回空字符串
    Public Function GetFingerprint(ByRef info As ProjectInfo) As String
        Debug.WriteLine("[Fingerprint] GetFingerprint=>Android version: " + info.AndroidVersion)
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTFingerprint.GetFingerprint(info)
        Else
            Return ""
        End If
    End Function

    ' 设置 fingerprint
    '
    ' info：工程信息
    ' fp：要设置的 fingerprint
    ' 
    ' return：设置成功返回 True，否则返回 False
    Public Function SetFingerprint(ByRef info As ProjectInfo, ByVal fp As String) As Boolean
        Debug.WriteLine("[Version] SetFingerprint=>fp: " + fp)
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTFingerprint.SetFingerprint(info, fp)
        Else
            Return False
        End If
    End Function

End Module
