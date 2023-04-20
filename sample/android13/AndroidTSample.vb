Imports System.IO

Module AndroidTSample

    Public Function GetSampleStatus(ByRef info As ProjectInfo) As Boolean
        Dim enabled As Boolean = False
        Dim found As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/device/mediatek/system/" &
            info.MssiDirName & "/SystemConfig.mk"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/config/SystemConfig.mk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fileRead As StreamReader = Nothing

        If File.Exists(customFilePath) Then
            Try
                fileRead = New StreamReader(customFilePath, utf8)
                Dim line = fileRead.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("WEIBU_PRODUCT_SAMPLE_GMS") And
                        line.Split("=").Length = 2 Then
                        Debug.WriteLine("[AndroidTSample] GetSampleStatus=>line1: " & line)
                        line = line.Split("=")(1).Trim()
                        If line = "yes" Then
                            enabled = True
                        Else
                            enabled = False
                        End If
                        found = True
                        Exit Do
                    End If
                    line = fileRead.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTSample] GetSampleStatus=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileRead) Then
                    fileRead.Close()
                    fileRead = Nothing
                End If
            End Try
        End If
        Debug.WriteLine("[AndroidTSample] GetSampleStatus=>found: " & found)
        If Not found And File.Exists(originFilePath) Then
            Try
                fileRead = New StreamReader(originFilePath, utf8)
                Dim line = fileRead.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("WEIBU_PRODUCT_SAMPLE_GMS") And
                        line.Split("=").Length = 2 Then
                        Debug.WriteLine("[AndroidTSample] GetSampleStatus=>line2: " & line)
                        line = line.Split("=")(1).Trim()
                        If line = "yes" Then
                            enabled = True
                        Else
                            enabled = False
                        End If
                        Exit Do
                    End If
                    line = fileRead.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTSample] GetSampleStatus=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileRead) Then
                    fileRead.Close()
                    fileRead = Nothing
                End If
            End Try
        End If

        Return enabled
    End Function

    Public Function GetSampleName(ByRef info As ProjectInfo) As String
        Dim sampleName As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/config/system.prop"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fileReader As StreamReader = Nothing
        If File.Exists(customFilePath) Then
            Try
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line As String = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("persist.sys.sample.device.name") And
                        line.Split("=").Length = 2 Then
                        sampleName = line.Split("=")(1).Trim
                        Exit Do
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTSample] GetSampleName=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return sampleName
    End Function

    Public Function SetSampleStatus(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/config/SystemConfig.mk"
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
                File.Create(customFilePath).Close()
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine()
            Dim found As Boolean = False
            Do Until IsNothing(line)
                If line.StartsWith("WEIBU_PRODUCT_SAMPLE_GMS") Then
                    found = True
                    Dim value As String = "no"
                    If enabled Then
                        value = "yes"
                    End If
                    fileWriter.WriteLine("WEIBU_PRODUCT_SAMPLE_GMS=" & value)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            If Not found Then
                Dim value As String = "no"
                If enabled Then
                    value = "yes"
                End If
                fileWriter.WriteLine("WEIBU_PRODUCT_SAMPLE_GMS=" & value)
            End If
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTSample] SetSampleStatus=>error: " & ex.ToString)
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

    Public Function SetSampleName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/config/system.prop"
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
                File.Create(customFilePath).Close()
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine()
            Dim found As Boolean = False
            Do Until IsNothing(line)
                If line.StartsWith("persist.sys.sample.device.name") Then
                    found = True
                    fileWriter.WriteLine("persist.sys.sample.device.name=" & name)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            If Not found Then
                fileWriter.WriteLine("persist.sys.sample.device.name=" & name)
            End If
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTSample] SetSampleStatus=>error: " & ex.ToString)
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
