Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Module AndroidTSystemConfig

    Public Function GetScreeOffTime(ByRef info As ProjectInfo) As String
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = GetResultFromXml(originFilePath, customFilePath, "<integer name=""def_screen_off_timeout"">", "</integer>")
        Debug.WriteLine("[AndroidTSystemConfig] GetScreeOffTime=>value：" & value)
        Return value
    End Function

    Public Function IsAutoTime(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = GetResultFromXml(originFilePath, customFilePath, "<bool name=""def_auto_time"">", "</bool>")
        Debug.WriteLine("[AndroidTSystemConfig] GetScreeOffTime=>value：" & value)
        Return value.Equals("true")
    End Function

    Public Function IsAutoRotation(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = GetResultFromXml(originFilePath, customFilePath, "<bool name=""def_accelerometer_rotation"">", "</bool>")
        Debug.WriteLine("[AndroidTSystemConfig] IsAutoRotation=>value：" & value)
        Return value.Equals("true")
    End Function

    Public Function IsAutoBrightness(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = GetResultFromXml(originFilePath, customFilePath, "<bool name=""def_screen_brightness_automatic_mode"">", "</bool>")
        Debug.WriteLine("[AndroidTSystemConfig] IsAutoBrightness=>value：" & value)
        Return value.Equals("true")
    End Function

    Public Function IsGPSOn(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = GetResultFromXml(originFilePath, customFilePath, "<integer name=""def_location_mode"">", "</integer>")
        Debug.WriteLine("[AndroidTSystemConfig] IsGPSOn=>value：" & value)
        Return value.Equals("3")
    End Function

    Public Function IsDisableScreenLock(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = GetResultFromXml(originFilePath, customFilePath, "<bool name=""def_lockscreen_disabled"">", "</bool>")
        Debug.WriteLine("[AndroidTSystemConfig] IsDisableScreenLock=>value：" & value)
        Return value.Equals("true")
    End Function

    Public Function Is24TimeFormat(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/src/com/android/providers/settings/DatabaseHelper.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
                "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/src/com/android/providers/settings/DatabaseHelper.java"
        Dim value = GetResultFromJava(originFilePath, customFilePath, "private void loadSystemSettings(SQLiteDatabase db) {", "loadSetting(stmt, Settings.System.TIME_12_24,", ");")
        Debug.WriteLine("[AndroidTSystemConfig] Is24TimeFormat=>value：" & value)
        Return value.Trim.Equals("24")
    End Function

    Public Function SetScreenOffTime(ByRef info As ProjectInfo, ByVal time As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim result = SetXmlValue(originFilePath, customFilePath, "<integer name=""def_screen_off_timeout"">", "</integer>", time)
        Debug.WriteLine("[AndroidTSystemConfig] SetScreenOffTime=>result：" & result)
        Return result
    End Function

    Public Function SetAutoTime(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim result = SetXmlValue(originFilePath, customFilePath, "<bool name=""def_auto_time"">", "</bool>", state)
        Debug.WriteLine("[AndroidTSystemConfig] SetAutoTime=>result：" & result)
        Return result
    End Function

    Public Function SetAutoRotation(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim result = SetXmlValue(originFilePath, customFilePath, "<bool name=""def_accelerometer_rotation"">", "</bool>", state)
        Debug.WriteLine("[AndroidTSystemConfig] SetAutoRotation=>result：" & result)
        Return result
    End Function

    Public Function SetAutoBrightness(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim result = SetXmlValue(originFilePath, customFilePath, "<bool name=""def_screen_brightness_automatic_mode"">", "</bool>", state)
        Debug.WriteLine("[AndroidTSystemConfig] SetAutoBrightness=>result：" & result)
        Return result
    End Function

    Public Function SetGps(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim result = SetXmlValue(originFilePath, customFilePath, "<integer name=""def_location_mode"">", "</integer>", state)
        Debug.WriteLine("[AndroidTSystemConfig] SetAutoBrightness=>result：" & result)
        Return result
    End Function

    Public Function SetDisableScreenLock(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim result = SetXmlValue(originFilePath, customFilePath, "<bool name=""def_lockscreen_disabled"">", "</bool>", state)
        Debug.WriteLine("[AndroidTSystemConfig] SetAutoBrightness=>result：" & result)
        Return result
    End Function

    Public Function Set24TimeFormat(ByRef info As ProjectInfo, ByVal state As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/src/com/android/providers/settings/DatabaseHelper.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
                "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/src/com/android/providers/settings/DatabaseHelper.java"
        Dim line As String = "loadSetting(stmt, Settings.System.TIME_12_24, 12);"
        If state.Equals("24") Then
            line = "loadSetting(stmt, Settings.System.TIME_12_24, 24);"
        End If
        Dim result = SetJavaValue(originFilePath, customFilePath, "private void loadSystemSettings(SQLiteDatabase db) {", "loadSetting(stmt, Settings.System.TIME_12_24,", "loadUISoundEffectsSettings(stmt);", line)
        Debug.WriteLine("[AndroidTSystemConfig] Set24TimeFormat=>result：" & result)
        Return result
    End Function

    Private Function GetResultFromXml(ByVal originFilePath As String, ByVal customFilePath As String, ByVal tag As String, ByVal endTag As String) As String
        Dim result As String = ""

        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Contains(tag) Then
                        line = line.Trim
                        line = line.Substring(Len(tag))
                        Dim value = line.Substring(0, line.IndexOf(endTag))
                        Debug.WriteLine("[AndroidTSystemConfig] GetResultFromXml=>value：" & value)
                        result = value
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            Else
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Contains(tag) Then
                        line = line.Trim
                        line = line.Substring(Len(tag))
                        Dim value = line.Substring(0, line.IndexOf(endTag))
                        Debug.WriteLine("[AndroidTSystemConfig] GetResultFromXml=>value：" & value)
                        result = value
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] GetResultFromXml=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Private Function GetResultFromJava(ByVal originFilePath As String, ByVal customFilePath As String, ByVal method As String, ByVal tag As String, ByVal endTag As String) As String
        Dim result As String = ""

        Dim fileReader As System.IO.StreamReader = Nothing
        Dim isInMethod As Boolean = False
        Dim leftBracesCount As Integer = 0
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If (line.Trim.Equals(method)) Then
                        isInMethod = True
                        If (line.Trim.EndsWith("{")) Then
                            leftBracesCount += 1
                        End If
                    Else
                        If isInMethod Then
                            If (line.Contains("{")) Then
                                leftBracesCount += 1
                            End If
                            If (line.Contains("}")) Then
                                leftBracesCount -= 1
                                If leftBracesCount = 0 Then
                                    isInMethod = False
                                End If
                            End If
                        End If
                    End If
                    If isInMethod Then
                        If line.Trim.StartsWith(tag) And line.Trim.EndsWith(endTag) Then
                            line = line.Trim.Substring(Len(tag))
                            result = line.Substring(0, line.IndexOf(endTag))
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            Else
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If (line.Trim.Equals(method)) Then
                        isInMethod = True
                        If (line.Trim.EndsWith("{")) Then
                            leftBracesCount += 1
                        End If
                    Else
                        If isInMethod Then
                            If (line.Contains("{")) Then
                                leftBracesCount += 1
                            End If
                            If (line.Contains("}")) Then
                                leftBracesCount -= 1
                                If leftBracesCount = 0 Then
                                    isInMethod = False
                                End If
                            End If
                        End If
                    End If
                    If isInMethod Then
                        If line.Trim.StartsWith(tag) And line.Trim.EndsWith(endTag) Then
                            line = line.Trim.Substring(Len(tag))
                            result = line.Substring(0, line.IndexOf(endTag))
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTSystemConfig] GetResultFromJava=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Private Function SetXmlValue(ByVal originFilePath As String, ByVal customFilePath As String, ByVal tag As String, ByVal endTag As String, ByVal value As String) As String
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As System.IO.StreamReader = Nothing
        Dim fileWriter As System.IO.StreamWriter = Nothing
        Try
            If Not System.IO.File.Exists(customFilePath) Then
                If Not System.IO.Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                System.IO.File.Copy(originFilePath, customFilePath, True)
            Else
                fileExists = True
            End If
            System.IO.File.Copy(customFilePath, backPath, True)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(customFilePath, False, utf8) With {
                .NewLine = vbLf
            }
            Dim line As String = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.Trim.StartsWith(tag) Then
                    Debug.WriteLine("[AndroidTSystemConfig] SetXmlValue=>line: " & line)
                    Dim newLine = line.Substring(0, line.IndexOf(tag))
                    fileWriter.WriteLine(newLine & tag & value.Trim & endTag)
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTSystemConfig] SetXmlValue=>error: " + ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If needRestore Then
                If Not fileExists Then
                    If System.IO.File.Exists(customFilePath) Then
                        System.IO.File.Delete(customFilePath)
                    End If
                Else
                    If System.IO.File.Exists(backPath) Then
                        System.IO.File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

    Private Function SetJavaValue(ByVal originFilePath As String, ByVal customFilePath As String, ByVal method As String,
                                  ByVal tag As String, ByVal endTag As String, ByVal value As String) As String
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As System.IO.StreamReader = Nothing
        Dim fileWriter As System.IO.StreamWriter = Nothing
        Dim fs As FileStream = Nothing
        Try
            If Not System.IO.File.Exists(customFilePath) Then
                If Not System.IO.Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                System.IO.File.Copy(originFilePath, customFilePath, True)
            Else
                fileExists = True
            End If
            System.IO.File.Copy(customFilePath, backPath, True)
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim length As Integer = 0
            Dim isInMethod As Boolean = False
            Dim leftBracesCount As Integer = 0
            Dim found As Boolean = False
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If (line.Trim.Equals(method)) Then
                    isInMethod = True
                    If (line.Trim.EndsWith("{")) Then
                        leftBracesCount += 1
                    End If
                Else
                    If isInMethod Then
                        If line.Contains("{") Then
                            leftBracesCount += 1
                        End If
                        If line.Contains("}") Then
                            leftBracesCount -= 1
                            If leftBracesCount = 0 Then
                                isInMethod = False
                            End If
                        End If
                    End If
                End If
                If isInMethod Then
                    Debug.WriteLine("[AndroidTSystemConfig] SetJavaValue=>line: " & line)
                    If line.Trim.StartsWith(tag) Then
                        found = True
                        Dim newLine = line.Substring(0, line.IndexOf(tag))
                        newLine = newLine & value
                        Debug.WriteLine("[AndroidTSystemConfig] SetJavaValue=>newLine1: " & newLine)
                        fileWriter.WriteLine(newLine)
                        result = True
                    ElseIf line.Trim.StartsWith(endTag) Then
                        If Not found Then
                            Dim newLine = line.Substring(0, line.IndexOf(endTag))
                            newLine = newLine & value
                            Debug.WriteLine("[AndroidTSystemConfig] SetJavaValue=>newLine2: " & newLine)
                            fileWriter.WriteLine(newLine)
                            fileWriter.WriteLine()
                            result = True
                        End If
                        fileWriter.WriteLine(line)
                    Else
                        fileWriter.WriteLine(line)
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTSystemConfig] SetJavaValue=>error: " + ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If needRestore Then
                If Not fileExists Then
                    If System.IO.File.Exists(customFilePath) Then
                        System.IO.File.Delete(customFilePath)
                    End If
                Else
                    If System.IO.File.Exists(backPath) Then
                        System.IO.File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

End Module
