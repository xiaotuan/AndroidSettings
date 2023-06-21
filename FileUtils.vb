Imports System.IO
Imports System.Text

Module FileUtils

    ' 获取 Makefile 文件中定义的宏的值
    '
    ' 首先先读取客制化文件中宏的定义，如果在客制化文件中已定义该宏，
    ' 则直接返回该宏的值；否则继续读取原始文件中该宏的值，如果在原始文件中已定义该宏，
    ' 则返回该宏的值，否则返回空字符串
    '
    ' originFilePath: 原始文件路径
    ' customFilePath: 客制化文件路径
    ' macroName: 宏的名称
    ' splitTag: 分割字符串
    '
    ' return: 如果宏已定义，返回最后一次定义的宏的值；否则返回空字符串
    Public Function GetMakeFileValue(originFilePath As String, customFilePath As String,
                                     macroName As String, splitTag As String) As String
        Dim value As String = ""
        Dim fileReader As IO.StreamReader = Nothing
        Dim found As Boolean = False
        Try
            If File.Exists(customFilePath) Then
                Dim utf8 = New Text.UTF8Encoding(False)
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(macroName) Then
                        Dim items = line.Split(splitTag)
                        If items.Length = 2 And items(0).Trim.Equals(macroName) Then
                            value = items(1).Trim
                            found = True
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
            If Not found And File.Exists(originFilePath) Then
                Dim utf8 = New Text.UTF8Encoding(False)
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(macroName) Then
                        Dim items = line.Split(splitTag)
                        If items.Length = 2 And items(0).Trim.Equals(macroName) Then
                            value = items(1).Trim
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetMakeFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    ' 设置 Makefile 文件中宏的值
    '
    ' 如果客制化文件不存在，则先拷贝原始文件内容至客制化文件中
    ' 在客制化文件查找 indexTag 开头的行，找到后使用 value 替换该行
    ' 如果未找到 indexTag 开头的行，但找到 insertTag 开头的行，则在该行的前面添加 value
    ' 如果 insertTag 为空字符串，则在未找到 insertTag 开头的行时，在文件末尾添加 value
    '
    ' originFilePath: 原始文件路径
    ' customFilePath: 客制化文件路径
    ' newLine: 文件换行符
    ' indexTag: 用于判断是否需要修改的行的字符串
    ' insertTag: 如果在该标签对应的行前未找到 indexTag 行，将会在此行前插入新宏值；如果 insertTag 为空字符串，则在文件末尾添加新宏值
    ' value: 要设置的宏的值
    '
    ' return: 设置成功返回 True，否则返回 False
    Public Function SetMakeFileValue(originFilePath As String, customFilePath As String, newLine As String,
                                     indexTag As String, ByRef insertTag As String, value As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Dim found As Boolean = False

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                If File.Exists(originFilePath) Then
                    File.Copy(originFilePath, customFilePath)
                Else
                    File.Create(customFilePath).Close()
                End If
            Else
                fileExists = True
            End If

            File.Copy(customFilePath, backPath, True)

            Dim utf8 = New Text.UTF8Encoding(False)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(customFilePath, False, utf8) With {
                .NewLine = newLine
            }

            Dim line As String = fileReader.ReadLine
            Do Until line Is Nothing
                If line.Trim.StartsWith(indexTag) Then
                    Dim space = line.Substring(0, line.IndexOf(indexTag))
                    fileWriter.WriteLine(space & value)
                    found = True
                Else
                    If Not found And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                        Dim space = line.Substring(0, line.IndexOf(insertTag))
                        fileWriter.WriteLine(space & value)
                        found = True
                    End If
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            If Not found Then
                fileWriter.WriteLine(value)
            End If
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetMakeFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
            If needRestore Then
                If Not fileExists Then
                    If File.Exists(customFilePath) Then
                        File.Delete(customFilePath)
                    End If
                Else
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    ' 获取 .sh 文件中的属性值
    ' 
    ' 首先先读取客制化文件中是否有该属性的定义，如果有则返回该属性的值；
    ' 如果没有，则读取原始文件中是否有该属性的定义，如果有则返回该属性的值；
    ' 否则返回 Nothing
    '
    ' originFilePath: 原始文件路径
    ' customFilePath: 客制化文件路径
    ' indexTag: 用于判断该行是否是要获取数据的行的字符串
    ' startTag: 包围属性值的开头字符串
    ' endTag: 包围属性值的结束字符串
    ' splitTag: 分割字符串
    '
    ' return: 如果找到属性，则返回属性值；否则返回 Nothing
    Public Function GetShellFileValue(originFilePath As String, customFilePath As String, indexTag As String,
                                     startTag As String, endTag As String, splitTag As String) As String
        Dim value As String = Nothing
        Dim fileReader As IO.StreamReader = Nothing
        Dim utf8 = New Text.UTF8Encoding(False)
        Dim found As Boolean = False
        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(indexTag) Then
                        Dim items = line.Split(splitTag)
                        If items.Length = 2 Then
                            value = items(1).Trim
                            Dim startIndex = value.IndexOf(startTag)
                            'Debug.WriteLine($"[FileUtils] GetShellFileValue=>startIndex: {startIndex}")
                            If startIndex < 0 Then
                                startIndex = 0
                            End If
                            Dim endIndex = value.IndexOf(endTag)
                            'Debug.WriteLine($"[FileUtils] GetShellFileValue=>endIndex: {endIndex}")
                            If endIndex < 0 Then
                                endIndex = value.Length
                            End If
                            'Debug.WriteLine($"[FileUtils] GetShellFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                            value = value.Substring(startIndex, endIndex)
                            found = True
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
            If Not found And File.Exists(originFilePath) Then
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(indexTag) Then
                        Dim items = line.Split(splitTag)
                        If items.Length = 2 Then
                            value = items(1).Trim
                            Dim startIndex = value.IndexOf(startTag)
                            If startIndex < 0 Then
                                startIndex = 0
                            End If
                            Dim endIndex = value.IndexOf(endTag)
                            If endIndex < 0 Then
                                endIndex = value.Length
                            End If
                            value = value.Substring(startIndex, endIndex)
                            found = True
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetShellFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    ' 设置 .sh 文件属性值
    '
    ' 如果客制化文件不存在，则拷贝原始文件内容到客制化文件中
    ' 根据 indexTag 参数判断是否是要修改的行
    ' 如果未找到要修改的行，且 insertTag 参数不为空字符串，则在找到 insertTag 相关行时，在其前面插入 value
    '如果 insertTag 为空字符串，且未找到要修改的行，则在文件末尾添加 value
    '
    ' originFilePath：原始文件路径
    ' customFilePath：客制化文件路径
    ' newLine：换行符
    ' indexTag：用于查找要修改行的标识字符串
    ' insertTag：如果在找到该字符串对应的行时，还为发现 indexTag 对应的行，则在该行的前面插入 value
    ' value：要插入的字符串（完整的一行）
    '
    ' return：修改成功返回 True，否则返回 False
    Public Function SetShellFileValue(originFilePath As String, customFilePath As String, newLine As String,
                                      indexTag As String, insertTag As String, value As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Dim found As Boolean = False

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                If File.Exists(originFilePath) Then
                    File.Copy(originFilePath, customFilePath)
                Else
                    File.Create(customFilePath).Close()
                End If
            Else
                fileExists = True
            End If

            File.Copy(customFilePath, backPath, True)

            Dim utf8 = New Text.UTF8Encoding(False)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(customFilePath, False, utf8) With {
                .NewLine = newLine
            }

            Dim line As String = fileReader.ReadLine
            Do Until line Is Nothing
                If line.Trim.StartsWith(indexTag) Then
                    Dim spaces As String = line.Substring(0, line.IndexOf(indexTag))
                    fileWriter.WriteLine(spaces & value)
                    found = True
                Else
                    If Not found And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                        Dim spaces As String = line.Substring(0, line.IndexOf(insertTag))
                        fileWriter.WriteLine(spaces & value)
                        found = True
                    End If
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            If Not found Then
                fileWriter.WriteLine(value)
            End If
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetMakeFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
            If needRestore Then
                If Not fileExists Then
                    If File.Exists(customFilePath) Then
                        File.Delete(customFilePath)
                    End If
                Else
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    ' 摘要：
    ' 从 xml 文件中读取数据。
    '
    ' 参数：
    ' originFilePath: 原始文件路径
    ' customFilePath: 客制化文件路径
    ' indexTag: 用于判断是否要获取值的行
    ' startTag: 值前面的字符串
    ' endTag: 值后面的字符串
    '
    ' 返回值:
    ' 获取成功返回值，否则返回空字符串
    Public Function GetXmlFileValue(originFilePath As String, customFilePath As String, indexTag As String, startTag As String, endTag As String) As String
        Dim value As String = ""
        Dim fileReader As IO.StreamReader = Nothing
        Dim utf8 = New Text.UTF8Encoding(False)
        Dim found As Boolean = False
        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(indexTag) Then
                        Debug.WriteLine($"[FileUtils] GetXmlFileValue=>line1: {line}")
                        Dim startIndex = line.Trim.IndexOf(startTag)
                        If startIndex < 0 Then
                            startIndex = startTag.Length
                        Else
                            startIndex += startTag.Length
                        End If
                        Dim endIndex = line.Trim.LastIndexOf(endTag)
                        If endIndex < 0 Then
                            endIndex = line.Trim.Length
                        End If
                        value = line.Trim.Substring(startIndex, endIndex - startIndex)
                        found = True
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
            If Not found And File.Exists(originFilePath) Then
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(indexTag) Then
                        Debug.WriteLine($"[FileUtils] GetXmlFileValue=>line2: {line}")
                        Dim startIndex = line.Trim.IndexOf(startTag)
                        If startIndex < 0 Then
                            startIndex = startTag.Length
                        Else
                            startIndex += startTag.Length
                        End If
                        Dim endIndex = line.Trim.LastIndexOf(endTag)
                        If endIndex < 0 Then
                            endIndex = line.Trim.Length
                        End If
                        value = line.Trim.Substring(startIndex, endIndex - startIndex)
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetXmlFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    '
    ' 摘要:
    '       在 xml 文件修改或添加值。
    '
    ' 参数:
    '   originFilePath:
    '       原始文件路径
    '  
    '   customFilePath:
    '       客制化文件路径
    '
    '   newLine:
    '       文件使用的换行符
    '
    '   value：
    '       要设置或修改的值（完整的，不仅仅只是值）
    '
    '   indexTag:
    '       用于判断修改行的字符串
    '
    '   insertTag:
    '       用于判断插入行的字符串，插入位置在该行前面
    '
    ' 返回结果:
    '       修改或添加成功返回 True，否则返回 False
    Public Function SetXmlFileValue(originFilePath As String, customFilePath As String, newLine As String, value As String, indexTag As String, insertTag As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Dim found As Boolean = False

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                If File.Exists(originFilePath) Then
                    File.Copy(originFilePath, customFilePath)
                Else
                    File.Create(customFilePath).Close()
                End If
            Else
                fileExists = True
            End If

            File.Copy(customFilePath, backPath, True)

            Dim utf8 = New Text.UTF8Encoding(False)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(customFilePath, False, utf8) With {
                .NewLine = newLine
            }

            Dim line As String = fileReader.ReadLine
            Do Until line Is Nothing
                If line.Trim.StartsWith(indexTag) Then
                    Dim spaces As String = line.Substring(0, line.IndexOf(indexTag))
                    fileWriter.WriteLine(spaces & value)
                    found = True
                Else
                    If Not found And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                        Dim spaces As String = line.Substring(0, line.IndexOf(insertTag))
                        fileWriter.WriteLine(spaces & value)
                        found = True
                    End If
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            If Not found Then
                fileWriter.WriteLine(value)
            End If
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetXmlFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
            If needRestore Then
                If Not fileExists Then
                    If File.Exists(customFilePath) Then
                        File.Delete(customFilePath)
                    End If
                Else
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    '
    ' 摘要:
    '       从 Java 文件中获取值
    '
    ' 参数:
    '   originFilePaht:
    '       原始文件路径
    '
    '   customFilePath:
    '       客制化文件路径
    '   
    '   methodLine:
    '       方法名所在的行字符串
    '   
    '   indexTag:
    '       用于判断获取值的行的字符串
    '
    '   startTag:
    '       用于分割值前面的字符串
    '  
    '   endTag:
    '       用于分割值后面的字符串
    '
    ' 返回结果:
    '       获取值成功返回值，否则返回空字符串
    Public Function GetJavaFileValue(originFilePath As String, customFilePath As String, methodLine As String, indexTag As String, startTag As String, endTag As String) As String
        Dim value As String = ""
        Dim fileReader As IO.StreamReader = Nothing
        Dim utf8 = New Text.UTF8Encoding(False)
        Dim found As Boolean = False
        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
                Dim methodCode As StringBuilder = New StringBuilder()
                Dim isMultilineSearch As Boolean = indexTag.Contains(vbLf)
                Dim isInMethod As Boolean = False
                Dim braceCount As Integer = 0
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(methodLine) Then
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>method start line: {line}")
                        If isMultilineSearch Then
                            methodCode.Append(line)
                        End If
                        isInMethod = True
                        If line.Contains("{") Then
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            If braceCount = 0 Then
                                isInMethod = False
                                Dim startIndex = line.Trim.IndexOf(startTag)
                                Dim endIndex = line.Trim.IndexOf(endTag)
                                If startIndex >= 0 And endIndex >= 0 Then
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line1: {line}")
                                    startIndex += startTag.Length
                                    value = line.Trim.Substring(startIndex, endIndex - startIndex)
                                End If
                            End If
                        End If
                    Else
                        If isInMethod Then
                            If isMultilineSearch Then
                                methodCode.Append(line)
                            End If
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}, braceCount: {braceCount}")
                            If braceCount = 0 Then
                                isInMethod = False
                                If isMultilineSearch Then
                                    Dim methodCodeStr As String = methodCode.ToString()
                                    Dim index As Integer = methodCodeStr.IndexOf(indexTag)
                                    If index >= 0 Then
                                        methodCodeStr = methodCodeStr.Substring(index)
                                        Dim startIndex = methodCodeStr.Trim.IndexOf(startTag)
                                        Dim endIndex = methodCodeStr.Trim.IndexOf(endTag)
                                        If startIndex >= 0 And endIndex >= 0 Then
                                            startIndex += startTag.Length
                                            value = methodCodeStr.Trim.Substring(startIndex, endIndex - startIndex)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If isInMethod And Not isMultilineSearch And line.Trim.StartsWith(indexTag) Then
                        Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line2: {line}")
                        Dim startIndex = line.Trim.IndexOf(startTag)
                        Dim endIndex = line.Trim.IndexOf(endTag)
                        Debug.WriteLine($"[FileUtils] GetJavaFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                        If startIndex >= 0 And endIndex >= 0 Then
                            startIndex += startTag.Length
                            value = line.Trim.Substring(startIndex, endIndex - startIndex)
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
            If Not found And File.Exists(originFilePath) Then
                fileReader = New StreamReader(originFilePath, utf8)
                Dim methodCode As StringBuilder = New StringBuilder()
                Dim isMultilineSearch As Boolean = indexTag.Contains(vbLf)
                Dim isInMethod As Boolean = False
                Dim braceCount As Integer = 0
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(methodLine) Then
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>method start line: {line}")
                        If isMultilineSearch Then
                            methodCode.Append(line)
                        End If
                        isInMethod = True
                        If line.Contains("{") Then
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            If braceCount = 0 Then
                                isInMethod = False
                                Dim startIndex = line.Trim.IndexOf(startTag)
                                Dim endIndex = line.Trim.IndexOf(endTag)
                                If startIndex >= 0 And endIndex >= 0 Then
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line1: {line}")
                                    startIndex += startTag.Length
                                    value = line.Trim.Substring(startIndex, endIndex - startIndex)
                                End If
                            End If
                        End If
                    Else
                        If isInMethod Then
                            If isMultilineSearch Then
                                methodCode.Append(line)
                            End If
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}, braceCount: {braceCount}")
                            If braceCount = 0 Then
                                isInMethod = False
                                If isMultilineSearch Then
                                    Dim methodCodeStr As String = methodCode.ToString()
                                    Dim index As Integer = methodCodeStr.IndexOf(indexTag)
                                    If index >= 0 Then
                                        methodCodeStr = methodCodeStr.Substring(index)
                                        Dim startIndex = methodCodeStr.Trim.IndexOf(startTag)
                                        Dim endIndex = methodCodeStr.Trim.IndexOf(endTag)
                                        If startIndex >= 0 And endIndex >= 0 Then
                                            startIndex += startTag.Length
                                            value = methodCodeStr.Trim.Substring(startIndex, endIndex - startIndex)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If isInMethod And Not isMultilineSearch And line.Trim.StartsWith(indexTag) Then
                        Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line2: {line}")
                        Dim startIndex = line.Trim.IndexOf(startTag)
                        Dim endIndex = line.Trim.IndexOf(endTag)
                        Debug.WriteLine($"[FileUtils] GetJavaFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                        If startIndex >= 0 And endIndex >= 0 Then
                            startIndex += startTag.Length
                            value = line.Trim.Substring(startIndex, endIndex - startIndex)
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    '
    ' 摘要:
    '       修改 Java 文件中的代码
    '
    ' 参数:
    '   originFilePath:
    '       原始文件路径
    '   
    '   customFilePath:
    '       客制化文件路径
    '  
    '   newLine:
    '       文件使用的换行符
    '
    '   methodLine:
    '       要修改的代码所在的方法的第一行定义
    '
    '   indexTag:
    '       判断是否是要修改的行的字符串
    '
    '   insertTag:
    '       判断是否是要插入代码的行的字符串
    '
    ' 返回结果:
    '       设置成功返回 True，否则返回 False
    Public Function SetJavaFileValue(originFilePath As String, customFilePath As String, newLine As String, value As String, methodLine As String, indexTag As String, insertTag As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                If File.Exists(originFilePath) Then
                    File.Copy(originFilePath, customFilePath)
                Else
                    File.Create(customFilePath).Close()
                End If
            Else
                fileExists = True
            End If

            File.Copy(customFilePath, backPath, True)

            Dim utf8 = New Text.UTF8Encoding(False)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(customFilePath, False, utf8) With {
                .NewLine = newLine
            }

            Dim methodCode As StringBuilder = New StringBuilder()
            Dim isMultilineSearch As Boolean = indexTag.Contains(vbLf)
            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>isMultilineSearch: {isMultilineSearch}")
            Dim isInMethod As Boolean = False
            Dim braceCount As Integer = 0
            Dim foundFirstBrace As Boolean = False
            Dim found As Boolean = False
            Dim line As String = fileReader.ReadLine
            Do Until line Is Nothing
                If line.Trim.StartsWith(methodLine) Then
                    ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>method start line: {line}")
                    If isMultilineSearch Then
                        methodCode.Append(line).Append(newLine)
                    End If
                    isInMethod = True
                    If line.Contains("{") Then
                        foundFirstBrace = True
                        braceCount += GetCharCount(line, "{")
                        braceCount -= GetCharCount(line, "}")
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>braceCount: {braceCount}")
                        ' 说明该方法在一行内定义完成
                        If braceCount = 0 Then
                            isInMethod = False
                            If line.Trim.StartsWith(indexTag) Then
                                fileWriter.WriteLine(value)
                                result = True
                            ElseIf line.Trim.StartsWith(insertTag) Then
                                fileWriter.WriteLine(value)
                                result = True
                            End If
                        End If
                    End If
                    If isMultilineSearch Then
                        line = fileReader.ReadLine
                        Continue Do
                    End If
                Else
                    If isInMethod Then
                        If isMultilineSearch Then
                            methodCode.Append(line).Append(newLine)
                        End If
                        braceCount += GetCharCount(line, "{")
                        If Not foundFirstBrace And braceCount > 0 Then
                            foundFirstBrace = True
                        End If
                        braceCount -= GetCharCount(line, "}")
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}, braceCount: {braceCount}")
                        If foundFirstBrace And braceCount = 0 Then
                            isInMethod = False
                            If isMultilineSearch Then
                                Dim methodCodeStr As String = methodCode.ToString()
                                ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>methodCodeStr: {methodCodeStr}")
                                If methodCodeStr.Contains(indexTag) Then
                                    methodCodeStr = methodCodeStr.Replace(indexTag, value)
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>after replace methodCodeStr: {methodCodeStr}")
                                    methodCodeStr = methodCodeStr.Substring(0, methodCodeStr.LastIndexOf(vbLf))
                                    fileWriter.WriteLine(methodCodeStr)
                                    result = True
                                End If
                            End If
                        End If
                        If isMultilineSearch Then
                            line = fileReader.ReadLine
                            Continue Do
                        End If
                    End If
                End If

                If isInMethod Then
                    ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}")
                    If Not isMultilineSearch Then
                        If indexTag.Trim.Length > 0 And line.Trim.StartsWith(indexTag) Then
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>replace line: {line}")
                            fileWriter.WriteLine(value)
                            result = True
                        Else
                            If Not result And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                                Debug.WriteLine($"[FileUtils] GetJavaFileValue=>insert line: {line}")
                                fileWriter.WriteLine(value)
                                result = True
                            End If
                            fileWriter.WriteLine(line)
                        End If
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetJavaFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
            If needRestore Then
                If Not fileExists Then
                    If File.Exists(customFilePath) Then
                        File.Delete(customFilePath)
                    End If
                Else
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    '
    ' 摘要:
    '       从 cpp 文件中获取值
    '
    ' 参数:
    '   originFilePath:
    '       原始文件路径
    '
    '   customFilePath:
    '       客制化文件路径
    '
    '   methodLine:
    '       方法定义所在的行字符串，不包括前后空白符
    '
    '   indexTag:
    '       用于判断该行是否是要获取值的行
    '
    '   startTag:
    '       值前面的字符串
    '
    '   endTag:
    '       值后面的字符串
    '   
    ' 返回结果:
    '       获取成功返回值，否则返回空字符串
    Public Function GetCppFileValue(originFilePath As String, customFilePath As String, methodLine As String, indexTag As String, startTag As String, endTag As String) As String
        Dim value As String = ""
        Dim fileReader As IO.StreamReader = Nothing
        Dim utf8 = New Text.UTF8Encoding(False)
        Dim found As Boolean = False
        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
                Dim methodCode As StringBuilder = New StringBuilder()
                Dim isMultilineSearch As Boolean = indexTag.Contains(vbLf)
                Dim isInMethod As Boolean = False
                Dim braceCount As Integer = 0
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If Not String.IsNullOrEmpty(methodLine) And line.Trim.StartsWith(methodLine) Then
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>method start line: {line}")
                        If isMultilineSearch Then
                            methodCode.Append(line)
                        End If
                        isInMethod = True
                        If line.Contains("{") Then
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            If braceCount = 0 Then
                                isInMethod = False
                                Dim startIndex = line.Trim.IndexOf(startTag)
                                Dim endIndex = line.Trim.IndexOf(endTag)
                                If startIndex >= 0 And endIndex >= 0 Then
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line1: {line}")
                                    startIndex += startTag.Length
                                    value = line.Trim.Substring(startIndex, endIndex - startIndex)
                                End If
                            End If
                        End If
                    Else
                        If Not String.IsNullOrEmpty(methodLine) And isInMethod Then
                            If isMultilineSearch Then
                                methodCode.Append(line)
                            End If
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}, braceCount: {braceCount}")
                            If braceCount = 0 Then
                                isInMethod = False
                                If isMultilineSearch Then
                                    Dim methodCodeStr As String = methodCode.ToString()
                                    Dim index As Integer = methodCodeStr.IndexOf(indexTag)
                                    If index >= 0 Then
                                        methodCodeStr = methodCodeStr.Substring(index)
                                        Dim startIndex = methodCodeStr.Trim.IndexOf(startTag)
                                        Dim endIndex = methodCodeStr.Trim.IndexOf(endTag)
                                        If startIndex >= 0 And endIndex >= 0 Then
                                            startIndex += startTag.Length
                                            value = methodCodeStr.Trim.Substring(startIndex, endIndex - startIndex)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If Not String.IsNullOrEmpty(methodLine) Then
                        If isInMethod And Not isMultilineSearch And line.Trim.StartsWith(indexTag) Then
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line2: {line}")
                            Dim startIndex = line.Trim.IndexOf(startTag)
                            Dim endIndex = line.Trim.IndexOf(endTag)
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                            If startIndex >= 0 And endIndex >= 0 Then
                                startIndex += startTag.Length
                                value = line.Trim.Substring(startIndex, endIndex - startIndex)
                            End If
                        End If
                    Else
                        If Not String.IsNullOrEmpty(indexTag) And line.Trim.StartsWith(indexTag) Then
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line3: {line}")
                            Dim startIndex = line.Trim.IndexOf(startTag)
                            Dim endIndex = line.Trim.IndexOf(endTag)
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                            If startIndex >= 0 And endIndex >= 0 Then
                                startIndex += startTag.Length
                                value = line.Trim.Substring(startIndex, endIndex - startIndex)
                            End If
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
            If Not found And File.Exists(originFilePath) Then
                fileReader = New StreamReader(originFilePath, utf8)
                Dim methodCode As StringBuilder = New StringBuilder()
                Dim isMultilineSearch As Boolean = indexTag.Contains(vbLf)
                Dim isInMethod As Boolean = False
                Dim braceCount As Integer = 0
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If Not String.IsNullOrEmpty(methodLine) And line.Trim.StartsWith(methodLine) Then
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>method start line: {line}")
                        If isMultilineSearch Then
                            methodCode.Append(line)
                        End If
                        isInMethod = True
                        If line.Contains("{") Then
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            If braceCount = 0 Then
                                isInMethod = False
                                Dim startIndex = line.Trim.IndexOf(startTag)
                                Dim endIndex = line.Trim.IndexOf(endTag)
                                If startIndex >= 0 And endIndex >= 0 Then
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line1: {line}")
                                    startIndex += startTag.Length
                                    value = line.Trim.Substring(startIndex, endIndex - startIndex)
                                End If
                            End If
                        End If
                    Else
                        If Not String.IsNullOrEmpty(methodLine) And isInMethod Then
                            If isMultilineSearch Then
                                methodCode.Append(line)
                            End If
                            braceCount += GetCharCount(line, "{")
                            braceCount -= GetCharCount(line, "}")
                            ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}, braceCount: {braceCount}")
                            If braceCount = 0 Then
                                isInMethod = False
                                If isMultilineSearch Then
                                    Dim methodCodeStr As String = methodCode.ToString()
                                    Dim index As Integer = methodCodeStr.IndexOf(indexTag)
                                    If index >= 0 Then
                                        methodCodeStr = methodCodeStr.Substring(index)
                                        Dim startIndex = methodCodeStr.Trim.IndexOf(startTag)
                                        Dim endIndex = methodCodeStr.Trim.IndexOf(endTag)
                                        If startIndex >= 0 And endIndex >= 0 Then
                                            startIndex += startTag.Length
                                            value = methodCodeStr.Trim.Substring(startIndex, endIndex - startIndex)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If Not String.IsNullOrEmpty(methodLine) Then
                        If isInMethod And Not isMultilineSearch And line.Trim.StartsWith(indexTag) Then
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line2: {line}")
                            Dim startIndex = line.Trim.IndexOf(startTag)
                            Dim endIndex = line.Trim.IndexOf(endTag)
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                            If startIndex >= 0 And endIndex >= 0 Then
                                startIndex += startTag.Length
                                value = line.Trim.Substring(startIndex, endIndex - startIndex)
                            End If
                        End If
                    Else
                        If Not String.IsNullOrEmpty(indexTag) And line.Trim.StartsWith(indexTag) Then
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line3: {line}")
                            Dim startIndex = line.Trim.IndexOf(startTag)
                            Dim endIndex = line.Trim.IndexOf(endTag)
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>startIndex: {startIndex}, endIndex: {endIndex}")
                            If startIndex >= 0 And endIndex >= 0 Then
                                startIndex += startTag.Length
                                value = line.Trim.Substring(startIndex, endIndex - startIndex)
                            End If
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    '
    ' 摘要:
    '       修改 Cpp 文件中的代码
    '
    ' 参数:
    '   originFilePath:
    '       原始文件路径
    '   
    '   customFilePath:
    '       客制化文件路径
    '  
    '   newLine:
    '       文件使用的换行符
    '
    '   methodLine:
    '       要修改的代码所在的方法的第一行定义
    '
    '   indexTag:
    '       判断是否是要修改的行的字符串
    '
    '   insertTag:
    '       判断是否是要插入代码的行的字符串
    '
    ' 返回结果:
    '       设置成功返回 True，否则返回 False
    Public Function SetCppFileValue(originFilePath As String, customFilePath As String, newLine As String, value As String, methodLine As String, indexTag As String, insertTag As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                If File.Exists(originFilePath) Then
                    File.Copy(originFilePath, customFilePath)
                Else
                    File.Create(customFilePath).Close()
                End If
            Else
                fileExists = True
            End If

            File.Copy(customFilePath, backPath, True)

            Dim utf8 = New Text.UTF8Encoding(False)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(customFilePath, False, utf8) With {
                .NewLine = newLine
            }

            Dim methodCode As StringBuilder = New StringBuilder()
            Dim isMultilineSearch As Boolean = indexTag.Contains(vbLf)
            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>isMultilineSearch: {isMultilineSearch}")
            Dim isInMethod As Boolean = False
            Dim braceCount As Integer = 0
            Dim foundFirstBrace As Boolean = False
            Dim found As Boolean = False
            Dim line As String = fileReader.ReadLine
            Do Until line Is Nothing
                If Not String.IsNullOrEmpty(methodLine) And line.Trim.StartsWith(methodLine) Then
                    ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>method start line: {line}")
                    If isMultilineSearch Then
                        methodCode.Append(line).Append(newLine)
                    End If
                    isInMethod = True
                    If line.Contains("{") Then
                        foundFirstBrace = True
                        braceCount += GetCharCount(line, "{")
                        braceCount -= GetCharCount(line, "}")
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>braceCount: {braceCount}")
                        ' 说明该方法在一行内定义完成
                        If braceCount = 0 Then
                            isInMethod = False
                            If line.Trim.StartsWith(indexTag) Then
                                fileWriter.WriteLine(value)
                                result = True
                            ElseIf line.Trim.StartsWith(insertTag) Then
                                fileWriter.WriteLine(value)
                                result = True
                            End If
                        End If
                    End If
                    If isMultilineSearch Then
                        line = fileReader.ReadLine
                        Continue Do
                    End If
                Else
                    If Not String.IsNullOrEmpty(methodLine) And isInMethod Then
                        If isMultilineSearch Then
                            methodCode.Append(line).Append(newLine)
                        End If
                        braceCount += GetCharCount(line, "{")
                        If Not foundFirstBrace And braceCount > 0 Then
                            foundFirstBrace = True
                        End If
                        braceCount -= GetCharCount(line, "}")
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}, braceCount: {braceCount}")
                        If foundFirstBrace And braceCount = 0 Then
                            isInMethod = False
                            If isMultilineSearch Then
                                Dim methodCodeStr As String = methodCode.ToString()
                                ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>methodCodeStr: {methodCodeStr}")
                                If methodCodeStr.Contains(indexTag) Then
                                    methodCodeStr = methodCodeStr.Replace(indexTag, value)
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>after replace methodCodeStr: {methodCodeStr}")
                                    methodCodeStr = methodCodeStr.Substring(0, methodCodeStr.LastIndexOf(vbLf))
                                    fileWriter.WriteLine(methodCodeStr)
                                    result = True
                                End If
                            End If
                        End If
                        If isMultilineSearch Then
                            line = fileReader.ReadLine
                            Continue Do
                        End If
                    End If
                End If

                If Not String.IsNullOrEmpty(methodLine) Then
                    If isInMethod Then
                        ' Debug.WriteLine($"[FileUtils] GetJavaFileValue=>line: {line}")
                        If Not isMultilineSearch Then
                            If indexTag.Trim.Length > 0 And line.Trim.StartsWith(indexTag) Then
                                Debug.WriteLine($"[FileUtils] GetJavaFileValue=>replace line: {line}")
                                fileWriter.WriteLine(value)
                                result = True
                            Else
                                If Not result And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                                    Debug.WriteLine($"[FileUtils] GetJavaFileValue=>insert line: {line}")
                                    fileWriter.WriteLine(value)
                                    result = True
                                End If
                                fileWriter.WriteLine(line)
                            End If
                        End If
                    Else
                        fileWriter.WriteLine(line)
                    End If
                Else
                    If indexTag.Trim.Length > 0 And line.Trim.StartsWith(indexTag) Then
                        Debug.WriteLine($"[FileUtils] GetJavaFileValue=>replace line: {line}")
                        fileWriter.WriteLine(value)
                        result = True
                    Else
                        If Not result And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                            Debug.WriteLine($"[FileUtils] GetJavaFileValue=>insert line: {line}")
                            fileWriter.WriteLine(value)
                            result = True
                        End If
                        fileWriter.WriteLine(line)
                    End If
                End If
                line = fileReader.ReadLine
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetJavaFileValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
            If needRestore Then
                If Not fileExists Then
                    If File.Exists(customFilePath) Then
                        File.Delete(customFilePath)
                    End If
                Else
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    '
    ' 摘要:
    '       在一个字符串中获取某个字符出现的次数
    '
    ' 参数:
    '   line:
    '       要测试的字符串
    '
    '   charStr:
    '       要测试的字符
    '
    ' 返回结果:
    '       返回 charStr 字符在 line 字符串中出现的次数
    Private Function GetCharCount(line As String, charStr As String) As Integer
        Dim count As Integer = 0
        For Each c As String In line
            If c.Equals(charStr) Then
                count += 1
            End If
        Next
        Return count
    End Function

End Module
