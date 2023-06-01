' AndroidTVerion 模块是 Android 13 系统修改软件版本号的实现
' Android 13 修改软件版本号的方法是：
' 修改 sys/build/make/tools/buildinfo.sh 文件中的如下行：
'   echo "ro.build.display.id=$BUILD_DISPLAY_ID"
Module AndroidTVersion

    ' 获取软件版本号
    '
    ' info：工程信息
    '
    ' return：获取成功返回软件版本号，否则返回空字符串
    Public Function GetVersion(ByRef info As ProjectInfo) As String
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" &
            info.CustomDirName & "/alps/build/make/tools/buildinfo.sh"
        Return FileUtils.GetShellFileValue("", customFilePath, "echo ""ro.build.display.id=", "", """", "=")
    End Function

    ' 设置软件版本号
    '
    ' info：工程信息
    ' version：要设置的软件版本号
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetVersion(ByRef info As ProjectInfo, ByVal version As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/build/make/tools/buildinfo.sh"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" &
            info.CustomDirName & "/alps/build/make/tools/buildinfo.sh"
        Return FileUtils.SetShellFileValue(originFilePath, customFilePath, vbLf, "echo ""ro.build.display.id=", "", "echo ""ro.build.display.id=" & version & """")
    End Function

End Module
