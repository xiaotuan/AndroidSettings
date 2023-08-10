' Version 模块类似于接口，它根据不同软件选择不同的实现模块来设置版本号
' 当前只实现了 Android 13 版本的修改
Module Version

    ' 获取软件版本号
    '
    ' info：工程信息
    '
    ' return：获取成功返回软件版本号，否则返回空字符串
    Public Function GetVersion(ByRef info As ProjectInfo) As String
        Debug.WriteLine("[Version] GetVersion=>Android version: " + info.AndroidVersion)
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVersion.GetVersion(info)
        Else
            Return ""
        End If
    End Function

    ' 设置软件版本号
    ' 
    ' info：工程信息
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetVersion(ByRef info As ProjectInfo, ByVal version As String) As Boolean
        Debug.WriteLine("[Version] SetVersion=>version: " + version)
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTVersion.SetVersion(info, version)
        Else
            Return False
        End If
    End Function

End Module
