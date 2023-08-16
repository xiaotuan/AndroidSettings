Imports System.IO
Imports System.Text

Module JavaFileUtils

    Public Function GetValueFromJavaFile(
                                        filePath As String, ' 文件路径
                                        encoding As Encoding, ' 编码格式
                                        method As String, ' 要获取的值所在的方法所在的行字符串（不包含空格）
                                        startTag As String, ' 开始标签
                                        endTag As String ' 结束标签
                                        ) As String
        Dim result As String = Nothing

        If File.Exists(filePath) Then
            Dim fileReader = New StreamReader(filePath, encoding)
            Dim line = fileReader.ReadLine()

            ' 是否发现方法名
            Dim isInMethod As Boolean = False
            ' 是否发现方法名后的第一个大括号
            Dim foundBrace As Boolean = False
            ' 大括号数量
            Dim braceCount As Integer = 0
            Dim lineNumber As Integer = 1

            Do Until line Is Nothing
                If Not IsEmptyText(method) Then
                    ' 判断当前行是否方法名代码
                    If Not isInMethod And line.Trim.Equals(method) Then
                        Debug.WriteLine("[JavaFileUtils] GetValueFromJavaFile=>Method start line number: " & Str(lineNumber))
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
                                Debug.WriteLine("[JavaFileUtils] GetValueFromJavaFile=>Method end line: " & Str(lineNumber))
                                isInMethod = False
                            End If
                        End If
                    End If

                    If isInMethod Then
                        line = line.Trim
                        If line.StartsWith(startTag) And line.EndsWith(endTag) Then
                            line = line.Substring(startTag.Length)
                            Dim index = line.LastIndexOf(endTag)
                            If index <> -1 Then
                                result = line.Substring(0, index)
                            End If
                            Exit Do
                        End If
                    End If
                Else
                    line = line.Trim
                    If line.StartsWith(startTag) And line.EndsWith(endTag) Then
                        line = line.Substring(startTag.Length)
                        Dim index = line.LastIndexOf(endTag)
                        If index <> -1 Then
                            result = line.Substring(0, index)
                        End If
                        Exit Do
                    End If
                End If
                line = fileReader.ReadLine
                lineNumber += 1
            Loop
            fileReader.Close()
        End If

        Debug.WriteLine("[JavaFileUtils] GetValueFromJavaFile=>result: " & result)
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
