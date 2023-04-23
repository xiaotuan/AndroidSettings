Imports System.IO

Module AndroidTBrightness

    Public Function GetDefaultBrightness(ByRef info As ProjectInfo) As String
        Dim defaultBrightness As String = ""
        Dim originFilePath = info.ProjectPath &
            "/sys/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fileReader As StreamReader = Nothing

        Debug.WriteLine("[AndroidTBrightness] GetDefaultBrightness=>customFilePath: " & customFilePath & ", exist: " & File.Exists(customFilePath).ToString)

        If File.Exists(customFilePath) Then
            Try
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line As String = fileReader.ReadLine()
                Debug.WriteLine("[AndroidTBrightness] GetDefaultBrightness=>line: " & line)
                Do Until IsNothing(line)
                    Debug.WriteLine("[AndroidTBrightness] GetDefaultBrightness=>line: " & line)
                    If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingDefaultFloat"" format=""float"" type=""dimen"">") Then
                        line = line.Trim.Substring("<item name=""config_screenBrightnessSettingDefaultFloat"" format=""float"" type=""dimen"">".Length)
                        defaultBrightness = line.Substring(0, line.IndexOf("<"))
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTBrightness] GetDefaultBrightness=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        ElseIf File.Exists(originFilePath) Then
            Try
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingDefaultFloat"" format=""float"" type=""dimen"">") Then
                        line = line.Trim.Substring("<item name=""config_screenBrightnessSettingDefaultFloat"" format=""float"" type=""dimen"">".Length)
                        defaultBrightness = line.Substring(0, line.IndexOf("<"))
                        Exit Do
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTBrightness] GetDefaultBrightness=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return defaultBrightness
    End Function

    Public Function GetMaxBrightness(ByRef info As ProjectInfo) As String
        Dim maxBrightness As String = ""
        Dim originFilePath = info.ProjectPath &
            "/sys/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fileReader As StreamReader = Nothing

        If File.Exists(customFilePath) Then
            Try
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingMaximumFloat"" format=""float"" type=""dimen"">") Then
                        line = line.Trim.Substring("<item name=""config_screenBrightnessSettingMaximumFloat"" format=""float"" type=""dimen"">".Length)
                        maxBrightness = line.Substring(0, line.IndexOf("<"))
                        Exit Do
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTBrightness] GetMaxBrightness=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        ElseIf File.Exists(originFilePath) Then
            Try
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingMaximumFloat"" format=""float"" type=""dimen"">") Then
                        line = line.Trim.Substring("<item name=""config_screenBrightnessSettingMaximumFloat"" format=""float"" type=""dimen"">".Length)
                        maxBrightness = line.Substring(0, line.IndexOf("<"))
                        Exit Do
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTBrightness] GetMaxBrightness=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return maxBrightness
    End Function

    Public Function GetMinBrightness(ByRef info As ProjectInfo) As String
        Dim minBrightness As String = ""
        Dim originFilePath = info.ProjectPath &
            "/sys/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fileReader As StreamReader = Nothing

        If File.Exists(customFilePath) Then
            Try
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingMinimumFloat"" format=""float"" type=""dimen"">") Then
                        line = line.Trim.Substring("<item name=""config_screenBrightnessSettingMinimumFloat"" format=""float"" type=""dimen"">".Length)
                        minBrightness = line.Substring(0, line.IndexOf("<"))
                        Exit Do
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTBrightness] GetMinBrightness=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        ElseIf File.Exists(originFilePath) Then
            Try
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingMinimumFloat"" format=""float"" type=""dimen"">") Then
                        line = line.Trim.Substring("<item name=""config_screenBrightnessSettingMinimumFloat"" format=""float"" type=""dimen"">".Length)
                        minBrightness = line.Substring(0, line.IndexOf("<"))
                        Exit Do
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTBrightness] GetMinBrightness=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return minBrightness
    End Function

    Public Function SetDefaultBrightness(ByRef info As ProjectInfo, ByVal defaultBrightness As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath = info.ProjectPath &
            "/sys/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim backPath As String = customFilePath & ".bk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fs As FileStream = Nothing
        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)

            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingDefaultFloat"" format=""float"" type=""dimen"">") Then
                    fileWriter.WriteLine("    <item name=""config_screenBrightnessSettingDefaultFloat"" format=""float"" type=""dimen"">" & defaultBrightness & "</item>")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTBrightness] SetDefaultBrightness=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    File.Copy(backPath, customFilePath, True)
                Else
                    File.Delete(customFilePath)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Return result
    End Function

    Public Function SetMaxBrightness(ByRef info As ProjectInfo, ByVal maxBrightness As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath = info.ProjectPath &
            "/sys/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim backPath As String = customFilePath & ".bk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fs As FileStream = Nothing
        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)

            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingMaximumFloat"" format=""float"" type=""dimen"">") Then
                    fileWriter.WriteLine("    <item name=""config_screenBrightnessSettingMaximumFloat"" format=""float"" type=""dimen"">" & maxBrightness & "</item>")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTBrightness] SetMaxBrightness=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    File.Copy(backPath, customFilePath, True)
                Else
                    File.Delete(customFilePath)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Return result
    End Function

    Public Function SetMinBrightness(ByRef info As ProjectInfo, ByVal minBrightness As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath = info.ProjectPath &
            "/sys/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/vendor/mediatek/proprietary/packages/overlay/vendor/FrameworkResOverlay/res/values/config.xml"
        Dim backPath As String = customFilePath & ".bk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fs As FileStream = Nothing
        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)

            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.Trim.StartsWith("<item name=""config_screenBrightnessSettingMinimumFloat"" format=""float"" type=""dimen"">") Then
                    fileWriter.WriteLine("    <item name=""config_screenBrightnessSettingMinimumFloat"" format=""float"" type=""dimen"">" & minBrightness & "</item>")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTBrightness] SetMinBrightness=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    File.Copy(backPath, customFilePath, True)
                Else
                    File.Delete(customFilePath)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Return result
    End Function

End Module
