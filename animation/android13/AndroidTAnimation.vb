Imports System.IO

Module AndroidTAnimation

    Public Function SetBootRing(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/media/bootaudio.mp3"
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
                File.Copy(filePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)
            File.Copy(filePath, customFilePath, True)

            File.Delete(backPath)

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"
            backPath = customFilePath & ".bk"

            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            'fileWriter.NewLine = vbLf

            Dim found As Boolean = False

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Equals("PRODUCT_COPY_FILES += vendor/weibu_sz/media/bootaudio.mp3:system/media/bootaudio.mp3") Then
                    found = True
                End If
                fileWriter.WriteLine(line)
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine("PRODUCT_COPY_FILES += vendor/weibu_sz/media/bootaudio.mp3:system/media/bootaudio.mp3")
            End If

            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>error: " & ex.ToString)
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

    Public Function SetBootAnim(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/media/bootanimation.zip"
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
                File.Copy(filePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)
            File.Copy(filePath, customFilePath, True)

            File.Delete(backPath)

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"
            backPath = customFilePath & ".bk"

            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            'fileWriter.NewLine = vbLf

            Dim found As Boolean = False

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Equals("PRODUCT_COPY_FILES += vendor/weibu_sz/media/bootanimation.zip:system/media/bootanimation.zip") Then
                    found = True
                End If
                fileWriter.WriteLine(line)
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine("PRODUCT_COPY_FILES += vendor/weibu_sz/media/bootanimation.zip:system/media/bootanimation.zip")
            End If

            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>error: " & ex.ToString)
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

    Public Function SetShutdownRing(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/media/shutaudio.mp3"
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
                File.Copy(filePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)
            File.Copy(filePath, customFilePath, True)

            File.Delete(backPath)

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"
            backPath = customFilePath & ".bk"

            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            'fileWriter.NewLine = vbLf

            Dim found As Boolean = False

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Equals("PRODUCT_COPY_FILES += vendor/weibu_sz/media/shutaudio.mp3:system/media/shutaudio.mp3") Then
                    found = True
                End If
                fileWriter.WriteLine(line)
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine("PRODUCT_COPY_FILES += vendor/weibu_sz/media/shutaudio.mp3:system/media/shutaudio.mp3")
            End If

            fileWriter.Close()
            fileReader.Close()
            fs.Close()
            File.Delete(backPath)

            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/config/system.prop"
            backPath = customFilePath & ".bk"

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
            'fileWriter.NewLine = vbLf

            found = False

            line = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("ro.wb.is_support_shutdownani=") Then
                    fileWriter.WriteLine("ro.wb.is_support_shutdownani=1")
                    found = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine("ro.wb.is_support_shutdownani=1")
            End If

            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>error: " & ex.ToString)
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

    Public Function SetShutdownAnim(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/media/shutdownanimation.zip"
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
                File.Copy(filePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)
            File.Copy(filePath, customFilePath, True)

            File.Delete(backPath)

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"
            backPath = customFilePath & ".bk"

            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            'fileWriter.NewLine = vbLf

            Dim found As Boolean = False

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.Equals("PRODUCT_COPY_FILES += vendor/weibu_sz/media/shutdownanimation.zip:system/media/shutanimation.zip") Then
                    found = True
                End If
                fileWriter.WriteLine(line)
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine("PRODUCT_COPY_FILES += vendor/weibu_sz/media/shutdownanimation.zip:system/media/shutanimation.zip")
            End If

            fileWriter.Close()
            fileReader.Close()
            fs.Close()
            File.Delete(backPath)

            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/config/system.prop"
            backPath = customFilePath & ".bk"

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
            'fileWriter.NewLine = vbLf

            found = False

            line = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("ro.wb.is_support_shutdownani=") Then
                    fileWriter.WriteLine("ro.wb.is_support_shutdownani=1")
                    found = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine("ro.wb.is_support_shutdownani=1")
            End If

            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>error: " & ex.ToString)
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
