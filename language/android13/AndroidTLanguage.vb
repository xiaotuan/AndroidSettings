Imports System.IO

Module AndroidTLanguage

    Public Function GetLanguage(ByRef info As ProjectInfo) As String
        Dim language As String = "en_US"
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/device/mediateksample/" & info.PublicDirName & "/vnd_" & info.PublicDirName & ".mk"
        If File.Exists(customFilePath) Then
            Dim utf8 = New Text.UTF8Encoding(False)
            Dim fileReader As StreamReader = Nothing
            Try
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("PRODUCT_LOCALES :=") Then
                        language = line.Split("=")(1).Trim.Split(" ")(0)
                        Debug.WriteLine("[AndroidTLanguage] GetLanguage=>language: " & language)
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTLanguage] GetLanguage=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                End If
            End Try
        End If
        Return language
    End Function

    Public Function SetLanguage(ByRef info As ProjectInfo, ByVal language As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = True
        Dim needRestore As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/vnd/device/mediateksample/" & info.PublicDirName & "/vnd_" & info.PublicDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/device/mediateksample/" & info.PublicDirName & "/vnd_" & info.PublicDirName & ".mk"
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
                File.Copy(originFilePath, customFilePath, True)
            End If
            System.IO.File.Copy(customFilePath, backPath, True)
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.StartsWith("PRODUCT_LOCALES :=") Then
                    Debug.WriteLine("[AndroidTLanguage] SetLanguage=>line: " & line)
                    Dim languages = line.Split("=")(1).Trim.Split(" ")
                    Dim newLine As String = "PRODUCT_LOCALES := " & language
                    For Each lang As String In languages
                        If Not lang.Equals(language) Then
                            newLine = newLine & " " & lang
                        End If
                    Next
                    fileWriter.WriteLine(newLine)
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
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
