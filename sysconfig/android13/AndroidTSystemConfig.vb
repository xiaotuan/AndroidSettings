Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Module AndroidTSystemConfig

    Public Function GetScreeOffTime(ByRef info As ProjectInfo) As String
        Dim result As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            result = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<integer name=""def_screen_off_timeout"">", "</integer>")
        Else
            Debug.WriteLine("[AndroidTSystemConfig] GetScreeOffTime=>" & customFilePath & " file isn't exist.")
        End If

        If IsNothing(result) And File.Exists(originFilePath) Then
            result = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<integer name=""def_screen_off_timeout"">", "</integer>")
        Else
            Debug.WriteLine("[AndroidTSystemConfig] GetScreeOffTime=>" & originFilePath & " file isn't exist.")
        End If

        If IsNothing(result) Then
            result = ""
            Debug.WriteLine("[AndroidTSystemConfig] GetScreeOffTime=>Get screen off time fail.")
        End If

        Debug.WriteLine("[AndroidTSystemConfig] GetScreeOffTime=>result：" & result)
        Return result
    End Function

    Public Function IsAutoTime(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<bool name=""def_auto_time"">", "</bool>")
        End If

        If IsNothing(value) And File.Exists(originFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<bool name=""def_auto_time"">", "</bool>")
        End If

        If IsNothing(value) Then
            Debug.WriteLine("[AndroidTSystemConfig] IsAutoTime=>Get screen off time fail.")
            value = ""
        End If

        If "true".Equals(value) Then
            result = True
        End If

        Debug.WriteLine("[AndroidTSystemConfig] IsAutoTime=>result: " & result & ", value：" & value)
        Return value.Equals("true")
    End Function

    Public Function IsAutoRotation(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<bool name=""def_accelerometer_rotation"">", "</bool>")
        End If

        If IsNothing(value) And File.Exists(originFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<bool name=""def_accelerometer_rotation"">", "</bool>")
        End If

        If IsNothing(value) Then
            Debug.WriteLine("[AndroidTSystemConfig] IsAutoRotation=>Get auto rotation fail.")
            value = ""
        End If

        If "true".Equals(value) Then
            result = True
        End If

        Debug.WriteLine("[AndroidTSystemConfig] IsAutoRotation=>result: " & result & ", value：" & value)
        Return value.Equals("true")
    End Function

    Public Function IsAutoBrightness(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = ""

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<bool name=""def_screen_brightness_automatic_mode"">", "</bool>")
        End If

        If IsNothing(value) And File.Exists(originFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<bool name=""def_screen_brightness_automatic_mode"">", "</bool>")
        End If

        If IsNothing(value) Then
            Debug.WriteLine("[AndroidTSystemConfig] IsAutoBrightness=>Get auto brightness fail.")
            value = ""
        End If

        If "true".Equals(value) Then
            result = True
        End If

        Debug.WriteLine("[AndroidTSystemConfig] IsAutoBrightness=>result: " & result & ", value：" & value)
        Return value.Equals("true")
    End Function

    Public Function IsGPSOn(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<integer name=""def_location_mode"">", "</integer>")
        End If

        If IsNothing(value) And File.Exists(originFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<integer name=""def_location_mode"">", "</integer>")
        End If

        If IsNothing(value) Then
            Debug.WriteLine("[AndroidTSystemConfig] IsGPSOn=>Get gps status fail.")
            value = ""
        End If

        If "true".Equals(value) Then
            result = True
        End If

        Debug.WriteLine("[AndroidTSystemConfig] IsGPSOn=>result: " & result & ", value：" & value)
        Return value.Equals("3")
    End Function

    Public Function IsDisableScreenLock(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<bool name=""def_lockscreen_disabled"">", "</bool>")
        End If

        If IsNothing(value) And File.Exists(originFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<bool name=""def_lockscreen_disabled"">", "</bool>")
        End If

        If IsNothing(value) Then
            Debug.WriteLine("[AndroidTSystemConfig] IsDisableScreenLock=>Get screen loce status fail.")
            value = ""
        End If

        If "true".Equals(value) Then
            result = True
        End If

        Debug.WriteLine("[AndroidTSystemConfig] IsDisableScreenLock=>result: " & result & ", value：" & value)
        Return result
    End Function

    Public Function Is24TimeFormat(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        If File.Exists(customFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(customFilePath, New Text.UTF8Encoding(False), "<string name=""def_time_12_24"" translatable=""false"">", "</string>")
        End If

        If IsNothing(value) And File.Exists(originFilePath) Then
            value = XmlFileUtils.GetValueFromXmlFile(originFilePath, New Text.UTF8Encoding(False), "<string name=""def_time_12_24"" translatable=""false"">", "</string>")
        End If

        If IsNothing(value) Then
            Debug.WriteLine("[AndroidTSystemConfig] Is24TimeFormat=>Get 24 time format fail.")
            value = ""
        End If

        If "24".Equals(value) Then
            result = True
        End If

        Debug.WriteLine("[AndroidTSystemConfig] Is24TimeFormat=>result: " & result & ", value：" & value)
        Return result
    End Function

    Public Function SetScreenOffTime(ByRef info As ProjectInfo, ByVal time As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"

        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <integer name=""def_screen_off_timeout"">" & time & "</integer>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<integer name=""def_screen_off_timeout"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] SetScreenOffTime=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] SetScreenOffTime=>result：" & result)
        Return result
    End Function

    Public Function SetAutoTime(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <bool name=""def_auto_time"">" & state & "</bool>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<bool name=""def_auto_time"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] SetAutoTime=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] SetAutoTime=>result：" & result)
        Return result
    End Function

    Public Function SetAutoRotation(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <bool name=""def_accelerometer_rotation"">" & state & "</bool>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<bool name=""def_accelerometer_rotation"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] SetAutoRotation=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] SetAutoRotation=>result：" & result)
        Return result
    End Function

    Public Function SetAutoBrightness(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <bool name=""def_screen_brightness_automatic_mode"">" & state & "</bool>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<bool name=""def_screen_brightness_automatic_mode"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] SetAutoBrightness=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] SetAutoBrightness=>result：" & result)
        Return result
    End Function

    Public Function SetGps(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <integer name=""def_location_mode"">" & state & "</integer>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<integer name=""def_location_mode"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] SetGps=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] SetGps=>result：" & result)
        Return result
    End Function

    Public Function SetDisableScreenLock(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <bool name=""def_lockscreen_disabled"">" & state & "</bool>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<bool name=""def_lockscreen_disabled"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] SetDisableScreenLock=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] SetDisableScreenLock=>result：" & result)
        Return result
    End Function

    Public Function Set24TimeFormat(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backFilePath As String = Nothing
        Dim newValue As String = "    <string name=""def_time_12_24"" translatable=""false"">" & state & "</string>"
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backFilePath = customFilePath & ".bk"
            End If
            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), newValue, "<string name=""def_time_12_24"" translatable=""false"">")
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] Set24TimeFormat=>error: " & ex.ToString)
            If Not IsNothing(backFilePath) Then
                File.Copy(backFilePath, customFilePath, True)
            End If
        End Try

        If Not IsNothing(backFilePath) Then
            File.Delete(backFilePath)
            backFilePath = Nothing
        End If

        Debug.WriteLine("[AndroidTSystemConfig] Set24TimeFormat=>result：" & result)
        Return result
    End Function

End Module
