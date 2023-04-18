Imports System.IO

Module AndroidTTimezone

    Public Function GetAutoTimezoneState(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Contains("<bool name=""def_auto_time_zone"">") Then
                        line = line.Trim
                        line = line.Substring(Len("<bool name=""def_auto_time_zone"">"))
                        Dim value = line.Substring(0, line.IndexOf("</bool>"))
                        Debug.WriteLine("[AndroidTTimezone] GetAutoTimezoneState=>value：" & value)
                        If "true".Equals(value) Then
                            result = True
                            Exit Do
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
                    If line.Contains("<bool name=""def_auto_time_zone"">") Then
                        line = line.Trim
                        line = line.Substring(Len("<bool name=""def_auto_time_zone"">"))
                        Dim value = line.Substring(0, line.IndexOf("</bool>"))
                        Debug.WriteLine("[AndroidTTimezone] GetAutoTimezoneState=>value：" & value)
                        If "true".Equals(value) Then
                            result = True
                            Exit Do
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTimezone] GetAutoTimezoneState=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Public Function GetTimezone(ByRef info As ProjectInfo) As String
        Dim zone As String = ""
        Debug.WriteLine("[AndroidTTimezone] GetTimezone=>project path: " & info.ProjectPath)
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/config/system.prop"
        If System.IO.File.Exists(customFilePath) Then
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As StreamReader = Nothing
            Try
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("persist.sys.timezone=") Then
                        zone = line.Split("=")(1).Trim
                        Debug.WriteLine("[AndroidTTimezone] GetTimezone=>timezone: " & zone)
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTTimezone] GetTimezone=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return zone
    End Function

    Public Function SetAutoTimezone(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
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
            Dim contents = fileReader.ReadToEnd().Split(vbLf)
            Dim line As String = Nothing
            Dim length As Integer = 0
            Debug.WriteLine("[AndroidTTimezone] SetAutoTimezone=>lines: " & contents.Length.ToString)
            For Each line In contents
                If line.Trim.StartsWith("<bool name=""def_auto_time_zone"">") Then
                    Debug.WriteLine("[AndroidTTimezone] SetAutoTimezone=>line: " & line)
                    fileWriter.WriteLine("    <bool name=""def_auto_time_zone"">" & isOpen.ToString.ToLower & "</bool>")
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
            Next
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTTimezone] SetAutoTimezone=>error: " + ex.ToString)
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

    Public Function SetTimezone(ByRef info As ProjectInfo, ByVal zone As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = True
        Dim needRestore As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/config/system.prop"
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As System.IO.StreamReader = Nothing
        Dim fileWriter As System.IO.StreamWriter = Nothing
        Dim fs As FileStream = Nothing
        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    fileExists = False
                End If
                File.Create(customFilePath).Close()
            End If
            System.IO.File.Copy(customFilePath, backPath, True)
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Dim found As Boolean = False
            Do Until IsNothing(line)
                If line.StartsWith("persist.sys.timezone=") Then
                    Debug.WriteLine("[AndroidTTimezone] SetTimezone=>line: " & line)
                    fileWriter.WriteLine("persist.sys.timezone=" & zone)
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            If Not result Then
                fileWriter.WriteLine("persist.sys.timezone=" & zone)
                result = True
            End If
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTLanguage] SetLanguage=>error: " + ex.ToString)
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
