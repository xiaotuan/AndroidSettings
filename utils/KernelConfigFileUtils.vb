Imports System.IO
Imports System.Text

Module KernelConfigFileUtils

    Public Function HashValueInKernelConfigFile(
                                               filePath As String, ' 文件路径
                                               encoding As Encoding, ' 文件编码
                                               macro As String ' 宏的名称
                                               ) As Boolean
        Dim result As Boolean = False

        Dim fileReader As StreamReader = Nothing

        Try
            If File.Exists(filePath) Then
                fileReader = New StreamReader(filePath, encoding)

                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith(macro & "=") Or line.Trim.StartsWith("#" & macro & "=") Then
                        result = True
                    End If
                    line = fileReader.ReadLine
                Loop
            Else
                Debug.WriteLine("[KernelConfigFileUtils] HashValueInKernelConfigFile=>" & filePath & " isn't exist.")
            End If
        Catch ex As Exception
            Debug.WriteLine("[KernelConfigFileUtils] HashValueInKernelConfigFile=>error: " & ex.ToString)
        End Try

        If Not IsNothing(fileReader) Then
            fileReader.Close()
        End If

        Debug.WriteLine("[KernelConfigFileUtils] HashValueInKernelConfigFile=>result: " & result)
        Return result
    End Function

    Public Function SetValueToKernelConfigFile(
                                              filePath As String, ' 文件路径
                                              encoding As Encoding, ' 文件编码
                                              position As String, ' 如果宏不存在，则在该位置插入宏（在该位置的上一行添加）
                                              macro As String, ' 宏名称
                                              newValue As String ' 要设置的值
                                              ) As Boolean
        Dim result As Boolean = False

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If File.Exists(filePath) Then
                Dim tempFilePath As String = Utils.GetTempFilePath()
                File.Copy(filePath, tempFilePath, True)
                Dim hasValue As Boolean = HashValueInKernelConfigFile(tempFilePath, New Text.UTF8Encoding(False), macro)
                Dim newLine = Utils.GetNewLineCharacter(File.ReadAllText(tempFilePath))
                fileReader = New StreamReader(tempFilePath, encoding)
                fileWriter = New StreamWriter(filePath, False, encoding) With {
                    .NewLine = newLine
                }

                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If hasValue Then
                        If line.Trim.StartsWith(macro & "=") Or line.Trim.StartsWith("#" & macro & "=") Then
                            fileWriter.WriteLine(newValue)
                            result = True
                        Else
                            fileWriter.WriteLine(line)
                        End If
                    Else
                        If Not IsEmptyText(position) Then
                            If line.Trim.StartsWith(position) Then
                                fileWriter.WriteLine(newValue)
                                result = True
                            End If
                            fileWriter.WriteLine(line)
                        Else
                            fileWriter.WriteLine(line)
                        End If
                    End If
                    line = fileReader.ReadLine
                Loop

                If Not hasValue And IsEmptyText(position) Then
                    fileWriter.WriteLine(newValue)
                    result = True
                End If
            Else
                Debug.WriteLine("[KernelConfigFileUtils] SetValueToKernelConfigFile=>" & filePath & " isn't exist.")
            End If
        Catch ex As Exception
            Debug.WriteLine("[KernelConfigFileUtils] SetValueToKernelConfigFile=>error: " & ex.ToString)
        End Try

        If Not IsNothing(fileReader) Then
            fileReader.Close()
        End If

        If Not IsNothing(fileWriter) Then
            fileWriter.Close()
        End If

        Debug.WriteLine("[KernelConfigFileUtils] SetValueToKernelConfigFile=>result: " & result)
        Return result
    End Function

End Module
