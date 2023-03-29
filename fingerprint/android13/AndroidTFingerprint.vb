Imports System.IO

Module AndroidTFingerprint

    Public Function GetFingerprint(ByRef info As ProjectInfo) As String
        Dim fingerprint As String = ""
        Dim fingerprintFilePath As String = info.ProjectPath + "/sys/weibu/" + info.MssiDirName + "/" + info.CustomDirName + "/alps/device/mediatek/system/common/BoardConfig.mk"
        If System.IO.File.Exists(fingerprintFilePath) Then
            Dim fileReader As New System.IO.StreamReader(fingerprintFilePath, System.Text.Encoding.UTF8)
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                Debug.WriteLine("Line=>line: " & line)
                If line.StartsWith("WEIBU_BUILD_NUMBER :=") Then
                    fingerprint = line.Split(":=")(1).Trim
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
        End If
        Return fingerprint
    End Function

    Public Function SetFingerprint(ByRef info As ProjectInfo, ByVal fp As String) As Boolean
        Dim result As Boolean = False
        If SetAndroidTFingerprint(info, fp) Then
            If SetAndroidSFingerprint(info, fp) Then
                result = True
            End If
        End If
        Return result
    End Function

    Public Function SetAndroidTFingerprint(ByRef info As ProjectInfo, ByVal fp As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim originFingerprintPath As String = info.ProjectPath + "/sys/device/mediatek/system/common/BoardConfig.mk"
        Dim customFingerprintPath As String = info.ProjectPath + "/sys/weibu/" + info.MssiDirName + "/" + info.CustomDirName + "/alps/device/mediatek/system/common/BoardConfig.mk"
        Dim backPath As String = customFingerprintPath & ".bk"
        Try
            If Not System.IO.File.Exists(customFingerprintPath) Then
                System.IO.File.Copy(originFingerprintPath, customFingerprintPath)
            End If
            System.IO.File.Copy(customFingerprintPath, backPath)
            Dim fs As FileStream = Nothing
            fs = New FileStream(customFingerprintPath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(backPath, utf8)
            Dim fileWriter As New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith("WEIBU_BUILD_NUMBER :=") Then
                    fileWriter.WriteLine("WEIBU_BUILD_NUMBER := " & fp)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
            fileWriter.Close()
            fs.Close()
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTFingerprint] SetAndroidTFingerprint=>error: " + Str(ex))
            If Not fileExists Then
                If System.IO.File.Exists(customFingerprintPath) Then
                    System.IO.File.Delete(customFingerprintPath)
                End If
            Else
                If System.IO.File.Exists(backPath) Then
                    System.IO.File.Copy(backPath, customFingerprintPath)
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

    Public Function SetAndroidSFingerprint(ByRef info As ProjectInfo, ByVal fp As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim originFingerprintPath As String = info.ProjectPath + "/vnd/build/make/core/weibu_config.mk"
        Dim customFingerprintPath As String = info.ProjectPath + "/vnd/weibu/" + info.PublicDirName + "/" + info.DriveDirName + "/alps/build/make/core/weibu_config.mk"
        Dim backPath As String = customFingerprintPath & ".bk"
        Try
            If Not System.IO.File.Exists(customFingerprintPath) Then
                System.IO.File.Copy(originFingerprintPath, customFingerprintPath)
            End If
            System.IO.File.Copy(customFingerprintPath, backPath)
            Dim fs As FileStream = Nothing
            fs = New FileStream(customFingerprintPath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(backPath, utf8)
            Dim fileWriter As New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith("WEIBU_BUILD_NUMBER ?=") Then
                    fileWriter.WriteLine("WEIBU_BUILD_NUMBER ?= " & fp)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
            fileWriter.Close()
            fs.Close()
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTFingerprint] SetAndroidSFingerprint=>error: " + ex.ToString)
            If Not fileExists Then
                If System.IO.File.Exists(customFingerprintPath) Then
                    System.IO.File.Delete(customFingerprintPath)
                End If
            Else
                If System.IO.File.Exists(backPath) Then
                    System.IO.File.Copy(backPath, customFingerprintPath)
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

End Module
