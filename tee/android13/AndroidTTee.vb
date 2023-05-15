Imports System.Drawing.Imaging
Imports System.IO

Module AndroidTTee

    Public Function GetTeeStatus(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/vnd/device/mediateksample/" &
            info.PublicDirName & "/ProjectConfig.mk"
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/config/ProjectConfig.mk"

        Dim utf8 = New System.Text.UTF8Encoding(False)
        Dim fileReader As StreamReader
        If File.Exists(originFilePath) Then
            Try
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("TRUSTKERNEL_TEE_SUPPORT") Then
                        Debug.WriteLine("[AndroidTTee] GetTeeStatus=>line1: " & line)
                        If line.Trim.Split("=").Length = 2 Then
                            If line.Trim.Split("=")(1).Trim.Equals("yes") Then
                                result = True
                            End If
                        End If
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTTee] GetTeeStatus=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        If File.Exists(customFilePath) Then
            Try
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("TRUSTKERNEL_TEE_SUPPORT") Then
                        Debug.WriteLine("[AndroidTTee] GetTeeStatus=>line2: " & line)
                        If line.Trim.Split("=").Length = 2 Then
                            If line.Trim.Split("=")(1).Equals("yes") Then
                                result = True
                            Else
                                result = False
                            End If
                        End If
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTTee] GetTeeStatus=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Debug.WriteLine("[AndroidTTee] GetTeeStatus=>result: " & result.ToString)
        Return result
    End Function

    Public Function SetTeeStatus(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False
        If SetProjectConfigFile(info, enabled) Then
            If SetDefConfigFile(info, enabled) Then
                If SetPreloadConfigFile(info, enabled) Then
                    If SetTrustzone(info, enabled) Then
                        result = True
                    End If
                End If
            End If
        End If
        Return result
    End Function

    Public Function SetCertFile(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" &
            info.DriveDirName & "/alps/vendor/mediatek/proprietary/trustzone/trustkernel/source/build/" &
            info.PublicDirName & "/cert.dat"
        Dim backPath As String = customFilePath & ".bk"

        Try
            If Not File.Exists(customFilePath) Then
                If Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
            Else
                File.Copy(customFilePath, backPath, True)
            End If
            File.Copy(filePath, customFilePath, True)
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetCertFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If needRestore Then
                If File.Exists(backPath) Then
                    File.Copy(backPath, customFilePath, True)
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    Public Function SetArrayFile(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" &
            info.DriveDirName & "/alps/vendor/mediatek/proprietary/trustzone/trustkernel/source/build/" &
            info.PublicDirName & "/array.c"
        Dim backPath As String = customFilePath & ".bk"

        Try
            If Not File.Exists(customFilePath) Then
                If Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
            Else
                fileExist = True
                File.Copy(customFilePath, backPath, True)
            End If
            File.Copy(filePath, customFilePath, True)
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetArrayFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If needRestore Then
                If fileExist Then
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
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

    Public Function SetProjectConfigFile(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/config/ProjectConfig.mk"
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
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf

            Dim foundMtk As Boolean = False
            Dim foundTee As Boolean = False
            Dim foundTrust As Boolean = False
            Dim value As String = "yes"
            If Not enabled Then
                value = "no"
            End If

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("MTK_PERSIST_PARTITION_SUPPORT") Then
                    foundMtk = True
                    fileWriter.WriteLine("MTK_PERSIST_PARTITION_SUPPORT=" & value)
                ElseIf line.Trim.StartsWith("MTK_TEE_SUPPORT") Then
                    foundTee = True
                    fileWriter.WriteLine("MTK_TEE_SUPPORT=" & value)
                ElseIf line.Trim.StartsWith("TRUSTKERNEL_TEE_SUPPORT") Then
                    foundTrust = True
                    fileWriter.WriteLine("TRUSTKERNEL_TEE_SUPPORT=" & value)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            If Not foundMtk Then
                fileWriter.WriteLine("MTK_PERSIST_PARTITION_SUPPORT=" & value)
            End If

            If Not foundTee Then
                fileWriter.WriteLine("MTK_TEE_SUPPORT=" & value)
            End If

            If Not foundTrust Then
                fileWriter.WriteLine("TRUSTKERNEL_TEE_SUPPORT=" & value)
            End If
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetProjectConfigFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
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

    Public Function SetDefConfigFile(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/config/" & info.PublicDirName & "_defconfig"
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
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8) With {
                .NewLine = vbLf
            }

            Dim foundTee As Boolean = False
            Dim foundTeeFP As Boolean = False
            Dim foundTeeRpmb As Boolean = False

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Contains("CONFIG_TRUSTKERNEL_TEE_SUPPORT") Then
                    foundTee = True
                    If enabled Then
                        fileWriter.WriteLine("MTK_PERSIST_PARTITION_SUPPORT=y")
                    Else
                        fileWriter.WriteLine("#MTK_PERSIST_PARTITION_SUPPORT=y")
                    End If
                ElseIf line.Trim.StartsWith("CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT") Then
                    foundTeeFP = True
                    If enabled Then
                        fileWriter.WriteLine("CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT=y")
                    Else
                        fileWriter.WriteLine("#CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT=y")
                    End If
                ElseIf line.Trim.StartsWith("CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT") Then
                    foundTeeRpmb = True
                    If enabled Then
                        fileWriter.WriteLine("CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT=y")
                    Else
                        fileWriter.WriteLine("#CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT=y")
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            If Not foundTee Then
                If enabled Then
                    fileWriter.WriteLine("MTK_PERSIST_PARTITION_SUPPORT=y")
                Else
                    fileWriter.WriteLine("#MTK_PERSIST_PARTITION_SUPPORT=y")
                End If
            End If

            If Not foundTeeFP Then
                If enabled Then
                    fileWriter.WriteLine("CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT=y")
                Else
                    fileWriter.WriteLine("#CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT=y")
                End If
            End If

            If Not foundTeeRpmb Then
                If enabled Then
                    fileWriter.WriteLine("CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT=y")
                Else
                    fileWriter.WriteLine("#CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT=y")
                End If
            End If
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetProjectConfigFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
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

    Public Function SetPreloadConfigFile(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/config/" & info.PublicDirName & "_pl.mk"
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
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8) With {
                .NewLine = vbLf
            }

            Dim foundTee As Boolean = False
            Dim foundTrust As Boolean = False

            Dim value As String = "yes"
            If Not enabled Then
                value = "no"
            End If

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Contains("MTK_TEE_SUPPORT") Then
                    foundTee = True
                    fileWriter.WriteLine("MTK_TEE_SUPPORT=" & value)
                ElseIf line.Trim.StartsWith("TRUSTKERNEL_TEE_SUPPORT") Then
                    foundTrust = True
                    fileWriter.WriteLine("TRUSTKERNEL_TEE_SUPPORT=" & value)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            If Not foundTee Then
                fileWriter.WriteLine("MTK_TEE_SUPPORT=" & value)
            End If

            If Not foundTrust Then
                fileWriter.WriteLine("TRUSTKERNEL_TEE_SUPPORT=" & value)
            End If
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetProjectConfigFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
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

    Private Function SetTrustzone(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/vendor/mediatek/proprietary/trustzone/custom/build/project/" &
             info.PublicDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/alps/vendor/mediatek/proprietary/trustzone/custom/build/project/" &
            info.PublicDirName & ".mk"
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
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8) With {
                .NewLine = vbLf
            }

            Dim foundTee As Boolean = False
            Dim foundTrust As Boolean = False

            Dim value As String = "yes"
            If Not enabled Then
                value = "no"
            End If

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Contains("MTK_TEE_SUPPORT") Then
                    foundTee = True
                    fileWriter.WriteLine("MTK_TEE_SUPPORT=" & value)
                ElseIf line.Trim.StartsWith("TRUSTKERNEL_TEE_SUPPORT") Then
                    foundTrust = True
                    fileWriter.WriteLine("TRUSTKERNEL_TEE_SUPPORT=" & value)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            If Not foundTee Then
                fileWriter.WriteLine("MTK_TEE_SUPPORT=" & value)
            End If

            If Not foundTrust Then
                fileWriter.WriteLine("TRUSTKERNEL_TEE_SUPPORT=" & value)
            End If
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetProjectConfigFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
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
