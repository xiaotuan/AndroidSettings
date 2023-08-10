Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Module CppFileUtils

    Public Function AddCodeToCppFile(
                                    filePath As String, ' 文件路径
                                    encoding As Encoding, ' 字符编码
                                    method As String, ' 代码所在的方法，如果不在方法中，则传入空字符串
                                    value As String, ' 要插入的代码
                                    insertPosition As String ' 代码插入位置
                                    ) As Boolean
        Debug.WriteLine("[CppFileUtils] AddCodeToCppFile=>filePath: " & filePath)
        Dim result As Boolean = False

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Try
            If File.Exists(filePath) Then
                Dim tempFilePath = GetTempFilePath()
                File.Copy(filePath, tempFilePath)
                fileReader = New StreamReader(tempFilePath, encoding)
                Dim line = fileReader.ReadLine
                Dim newLine = GetNewLineCharacter(line)
                fileWriter = New StreamWriter(filePath, False, encoding) With {
                    .NewLine = newLine
                }

                If Not newLine.Equals(vbLf) Then
                    Debug.WriteLine("[CppFileUtils] HasCodeInCppFile=>replace new line char")
                    value = value.Replace(vbLf, newLine)
                End If

                ' 是否发现方法名
                Dim isInMethod As Boolean = False
                ' 是否发现方法名后的第一个大括号
                Dim foundBrace As Boolean = False
                ' 大括号数量
                Dim braceCount As Integer = 0
                Dim lineNumber As Integer = 1
                Do Until IsNothing(line)
                    If Not IsEmptyText(method) Then
                        ' 判断当前行是否方法名代码
                        If Not isInMethod And line.Trim.Equals(method) Then
                            Debug.WriteLine("[CppFileUtils] AddCodeToCppFile=>Method start line: " & Str(lineNumber))
                            isInMethod = True
                            braceCount = GetBraceCount(line, "{")
                            foundBrace = braceCount > 0
                            braceCount -= GetBraceCount(line, "}")
                            If foundBrace And braceCount = 0 Then
                                isInMethod = False
                            End If
                        Else
                            If isInMethod Then
                                braceCount += GetBraceCount(line, "{")
                                foundBrace = braceCount > 0
                                braceCount -= GetBraceCount(line, "}")
                                If foundBrace And braceCount = 0 Then
                                    Debug.WriteLine("[CppFileUtils] AddCodeToCppFile=>Method end line: " & Str(lineNumber))
                                    isInMethod = False
                                End If
                            End If
                        End If

                        If isInMethod Then
                            If Not IsEmptyText(insertPosition) And line.Trim().StartsWith(insertPosition) Then
                                fileWriter.WriteLine(value)
                                result = True
                            End If
                        End If
                    Else
                        If Not IsEmptyText(insertPosition) And line.Trim().StartsWith(insertPosition) Then
                            fileWriter.WriteLine(value)
                            result = True
                        End If
                    End If
                    fileWriter.WriteLine(line)
                    line = fileReader.ReadLine
                    lineNumber += 1
                Loop

                If IsEmptyText(insertPosition) Then
                    fileWriter.WriteLine(value)
                    result = True
                End If

                fileReader.Close()
                fileReader = Nothing
                fileWriter.Close()
                fileWriter = Nothing
            End If
        Catch ex As Exception
            Debug.WriteLine("[CppFileUtils] AddCodeToCppFile=>error: " & ex.ToString)
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
        End Try

        Debug.WriteLine("[CppFileUtils] AddCodeToCppFile=>result: " & result)
        Return result
    End Function

    Public Function HasCodeInCppFile(
                                    filePath As String, ' 文件路径
                                    encoding As Encoding, ' 字符编码
                                    value As String ' 要查找的代码
                                    ） As Boolean
        Dim result As Boolean = False

        Try
            If File.Exists(filePath) Then
                Dim fileReader = New StreamReader(filePath, encoding)
                Dim content = fileReader.ReadToEnd()
                fileReader.Close()
                Dim newLine = GetNewLineCharacter(content)
                If Not newLine.Equals(vbLf) Then
                    Debug.WriteLine("[CppFileUtils] HasCodeInCppFile=>replace new line char")
                    value = value.Replace(vbLf, newLine)
                End If
                result = content.Contains(value)
            End If
        Catch ex As Exception
            Debug.WriteLine("[CppFileUtils] HasCodeInCppFile=>error: " & ex.ToString)
        End Try

        Debug.WriteLine("[CppFileUtils] HasCodeInCppFile=>result: " & result)
        Return result
    End Function

    Function GetNewLineCharacter(line As String) As String
        If line.Contains(vbCrLf) Then
            Return vbCrLf
        ElseIf line.Contains(vbCr) Then
            Return vbCr
        ElseIf line.Contains(vbLf) Then
            Return vbLf
        Else
            Return Environment.NewLine
        End If
    End Function

    Function GetTempFilePath() As String
        Dim tempFloderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AndroidProjectConfig\Temp"
        If Not Directory.Exists(tempFloderPath) Then
            Directory.CreateDirectory(tempFloderPath)
        End If
        Dim tempFilePath = tempFloderPath & "\back.tmp"
        If File.Exists(tempFilePath) Then
            File.Delete(tempFilePath)
        End If
        Return tempFilePath
    End Function

    Function GetBraceCount(line As String, charStr As String) As Integer
        Dim count As Integer = 0
        For Each c As String In line
            If c.Equals(charStr) Then
                count += 1
            End If
        Next
        'If line.Contains(charStr) Then
        '    Debug.WriteLine("[CppFileUtils] GetBraceCount=>line: " & line)
        'End If
        Return count
    End Function

End Module
