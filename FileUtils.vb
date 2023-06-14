Imports System.IO
Imports System.Text

Module FileUtils

    ' 
    ' 摘要
    ' 从 Makefile 文件中读取指定宏的值。首先从客制化文件中读取宏的值，如果客制化文件中未定义该宏；
    ' 则继续读取原始文件中宏的值，如果在客制化文件和原始文件中都未定义宏，则返回空字符串
    '
    ' 参数
    ' macroName：宏的名称
    ' splitTag：用于分割宏与宏值的分隔符
    ' originFilePath：原始文件路径
    ' customFilePath：客制化文件路径
    '
    ' 返回结果
    ' 获取成功返回宏的值，否则返回空字符串
    Public Function GetMakeFileValue(macroName As String, Optional splitTag As String = "=",
                                     Optional originFilePath As String = Nothing,
                                     Optional customFilePath As String = Nothing) As String
        Debug.WriteLine($"[FileUtils] GetMakeFileValue=>macroName: {macroName}, splitTag: {splitTag}, originFilePath: {originFilePath}, customFilePath: {customFilePath}")
        Dim value As String = ""
        Dim fileReader As IO.StreamReader = Nothing
        Dim found As Boolean = False
        Try
            ' 从客制化文件中获取宏的值
            If Not IsNothing(customFilePath) And File.Exists(customFilePath) Then
                Dim utf8 = New Text.UTF8Encoding(False)
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    ' 如果一行的开头去掉空格后以指定的宏名称开头的行就是定义该宏的位置
                    ' 获取到宏的值并不会停止继续搜索，如果一个文件里定义有多个宏，返回最后一个定义的宏的值
                    If line.Trim.StartsWith(macroName) Then
                        ' 通过分割符提取宏的值
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
            ' 如果在客制化文件中未找到宏的定义，则在原始文件中进行查找
            If Not found And Not IsNothing(originFilePath) And File.Exists(originFilePath) Then
                Dim utf8 = New Text.UTF8Encoding(False)
                fileReader = New StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    ' 如果一行的开头去掉空格后以指定的宏名称开头的行就是定义该宏的位置
                    ' 获取到宏的值并不会停止继续搜索，如果一个文件里定义有多个宏，返回最后一个定义的宏的值
                    If line.Trim.StartsWith(macroName) Then
                        ' 通过分割符提取宏的值
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

    '
    ' 摘要
    ' 在 Makefile 文件中添加或修改宏的值。
    '
    ' 参数
    ' indexTag：用于判断是否是宏定义的行的字符串
    ' value：要设置的宏的值，为宏的整个定义，而不是单纯的宏值
    ' customFilePath: 客制化文件路径
    ' originFilePath: 原始文件路径
    ' newLine: 行符号，例如 vbLf 或 vbCrLf
    ' insertTag：用于判断是否是定义宏的位置的标识符
    '
    ' 返回结果
    ' 添加或修改宏成功，返回 True，否则返回 False
    Public Function SetMakeFileValue(indexTag As String, value As String, customFilePath As String, Optional originFilePath As String = Nothing,
                                     Optional newLine As String = vbLf, Optional insertTag As String = Nothing) As Boolean
        Debug.WriteLine($"[FileUtils] SetMakeFileValue=>indexTag: {indexTag}, value: {value}, customFilePath: {customFilePath}, originFilePath: {originFilePath}, insertTag: {insertTag}")
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Dim found As Boolean = False

        Try
            ' 如果客制化文件不存在，则创建客制化文件，并将原始文件内容拷贝到客制化文件中
            If Not File.Exists(customFilePath) Then
                ' 如果客制化文件目录不存在，则创建该目录
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                If Not IsNothing(originFilePath) And File.Exists(originFilePath) Then
                    ' 将原始文件拷贝至客制化文件中
                    File.Copy(originFilePath, customFilePath)
                Else
                    ' 原始文件不存在，只创建客制化文件
                    File.Create(customFilePath).Close()
                End If
            Else
                ' 标志客制化文件已经存在
                fileExists = True
            End If

            ' 备份客制化文件，当出现写入错误时，用于还原客制化文件
            File.Copy(customFilePath, backPath, True)

            Dim utf8 = New Text.UTF8Encoding(False)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(customFilePath, False, utf8) With {
                .NewLine = newLine
            }

            Dim line As String = fileReader.ReadLine
            Do Until line Is Nothing
                If line.Trim.StartsWith(indexTag) Then
                    ' 找到 indexTag 对应的行，也就是要修改的宏的行
                    ' 提取宏前面的空格，然后添加在修改行前面，使其保持与原始文件风格一致
                    Dim space = line.Substring(0, line.IndexOf(indexTag))
                    fileWriter.WriteLine(space & value)
                    found = True
                Else
                    ' 如果 insertTag 不为 Nothing，且为找到 indexTag 对应的行，确找到了 insertTag 对应的行
                    ' 这说明了要设置的宏未定义，这时在当前行的签名插入该宏的定义
                    If Not found And Not IsNothing(insertTag) And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                        ' 找到 indexTag 对应的行，也就是要修改的宏的行
                        ' 提取宏前面的空格，然后添加在修改行前面，使其保持与原始文件风格一致
                        Dim space = line.Substring(0, line.IndexOf(insertTag))
                        fileWriter.WriteLine(space & value)
                        found = True
                    End If
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

            ' 如果遍历完文件后还是未找到对应宏的行以及要插入的行，且 insertTag 不为 Nothing
            ' 这时在文件末尾插入该宏的定义
            If Not found And Not IsNothing(insertTag) Then
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

    '
    ' 摘要：
    '       获取 XML 文件中指定标签的值，例如：要获取 <bool name="auto_time_zone">true</bool> 的值为例
    ' 
    '
    ' 参数：
    '   originFilePath：
    '       原始文件路径
    '   customFilePath：
    '       客制化文件路径
    '   indexTag：
    '       用于判断当前位置是否是要操作的行的对比字符串，例如 <bool name="auto_time_zone">
    '   startTag:
    '       提取值时要去掉的前面的字符串，例如 <bool name="auto_time_zone">
    '   endTag:
    '       提取值时要去掉的后面的字符串，例如 </bool>
    '
    ' 返回值
    '   返回 xml 标签的值
    '
    Public Function GetXmlValue(originFilePath As String, customFilePath As String, indexTag As String,
                                     startTag As String, endTag As String) As String
        Dim value As String = ""
        Dim found As Boolean = False
        Dim fileReader As StreamReader = Nothing
        Dim utf8 = New Text.UTF8Encoding(False)
        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Trim.StartsWith(indexTag) Then
                        found = True
                        Dim startIndex = line.IndexOf(startTag)
                        If startIndex >= 0 Then
                            startIndex += Len(startTag)
                            line = line.Substring(startIndex)
                        End If
                        Dim endIndex = line.IndexOf(endTag)
                        Debug.WriteLine($"[FileUtils] GetXmlValue=>line：{line}, endIndex: {endIndex}")
                        If endIndex >= 0 Then
                            value = line.Substring(0, endIndex)
                        End If
                        Debug.WriteLine($"[FileUtils] GetXmlValue=>value：{value}")
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
                        Dim startIndex = line.IndexOf(startTag)
                        If startIndex < 0 Then
                            startIndex = 0
                        End If
                        Dim endIndex = line.IndexOf(endTag)
                        If endIndex < 0 Then
                            endIndex = line.Length
                        End If
                        value = line.Substring(startIndex, endIndex)
                        Debug.WriteLine($"[FileUtils] GetXmlValue=>value：{value}")
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetXmlValue=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    '
    ' 摘要：
    '       设置 XML 文件中指定标签的值，例如：要获取 <bool name="auto_time_zone">true</bool> 的值为例
    ' 
    '
    ' 参数：
    '   originFilePath：
    '       原始文件路径
    '   customFilePath：
    '       客制化文件路径
    '   newLine:
    '       文件使用的换行符，例如 vbLf 或者 vbCrLf
    '   indexTag：
    '       用于判断当前位置是否是要操作的行的对比字符串，例如 <bool name="auto_time_zone">
    '   insertTag:
    '       在没有找到 indexTag 位置且当前找到
    '   endTag:
    '       提取值时要去掉的后面的字符串，例如 </bool>
    '
    ' 返回值
    '   返回 xml 标签的值
    '
    Public Function SetXmlValue(originFilePath As String, customFilePath As String, newLine As String,
                                      indexTag As String, insertTag As String, value As String) As Boolean
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
                    File.Copy(originFilePath, customFilePath, True)
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

            Dim found As Boolean = False
            Dim line As String = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.Trim.StartsWith(indexTag) Then
                    Dim spaces = line.Substring(0, line.IndexOf(indexTag))
                    fileWriter.WriteLine(spaces & value)
                    found = True
                Else
                    If Not found And insertTag.Trim.Length > 0 And line.Trim.StartsWith(insertTag) Then
                        found = True
                        Dim spaces = line.Substring(0, line.IndexOf(indexTag))
                        fileWriter.WriteLine(spaces & value)
                    End If
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            result = found
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetXmlValue=>error: {ex}")
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

    Public Function GetJavaValue(originFilePath As String, customFilePath As String, method As String,
                                 indexTag As String, startTag As String, endTag As String) As String
        Dim value As String = ""
        Dim fileReader As StreamReader = Nothing
        Dim utf8 = New Text.UTF8Encoding(False)
        Dim isInMethod As Boolean = False
        Dim found As Boolean = False
        Dim leftBracesCount As Integer = 0

        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If (line.Trim.Equals(method)) Then
                        isInMethod = True
                        If (line.Trim.EndsWith("{")) Then
                            leftBracesCount += 1
                        End If
                    Else
                        If isInMethod Then
                            If (line.Contains("{")) Then
                                leftBracesCount += 1
                            End If
                            If (line.Contains("}")) Then
                                leftBracesCount -= 1
                                If leftBracesCount = 0 Then
                                    isInMethod = False
                                End If
                            End If
                        End If
                    End If
                    If isInMethod Then
                        If line.Trim.StartsWith(indexTag) Then
                            Dim startIndex = line.IndexOf(startTag)
                            Dim endIndex = line.IndexOf(endTag)
                            If startIndex >= 0 And endIndex >= startIndex Then
                                found = True
                                value = line.Substring(startIndex, endIndex)
                            End If
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
                    If (line.Trim.Equals(method)) Then
                        isInMethod = True
                        If (line.Trim.EndsWith("{")) Then
                            leftBracesCount += 1
                        End If
                    Else
                        If isInMethod Then
                            If (line.Contains("{")) Then
                                leftBracesCount += 1
                            End If
                            If (line.Contains("}")) Then
                                leftBracesCount -= 1
                                If leftBracesCount = 0 Then
                                    isInMethod = False
                                End If
                            End If
                        End If
                    End If
                    If isInMethod Then
                        If line.Trim.StartsWith(indexTag) Then
                            Dim startIndex = line.IndexOf(startTag)
                            Dim endIndex = line.IndexOf(endTag)
                            If startIndex >= 0 And endTag >= startIndex Then
                                found = True
                                value = line.Substring(startIndex, endIndex)
                            End If
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine($"[FileUtils] GetResultFromJava=>error: {ex}")
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
        End Try
        Return value
    End Function

    Public Function SetJavaValue(originFilePath As String, customFilePath As String, newLine As String, method As String,
                                      indexTag As String, insertTag As String, value As String, isDeleted As Boolean) As Boolean
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
                    File.Copy(originFilePath, customFilePath, True)
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
            Dim methods As StringBuilder = New StringBuilder()
            Dim length As Integer = 0
            Dim isInMethod As Boolean = False
            Dim leftBracesCount As Integer = 0
            Dim found As Boolean = False

            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If (line.Trim.Equals(method)) Then
                    Debug.WriteLine($"[FileUtils] SetJavaValue=>method start: {line}")
                    isInMethod = True
                    If (line.Trim.Contains("{")) Then
                        leftBracesCount += GetCharCount(line, "{")
                    End If
                Else
                    If isInMethod Then
                        If line.Contains("{") Then
                            'Debug.WriteLine($"[FileUtils] SetJavaValue=>left {{: {line}, leftBracesCount: {leftBracesCount}")
                            leftBracesCount += GetCharCount(line, "{")
                        End If
                        If line.Contains("}") Then
                            'Debug.WriteLine($"[FileUtils] SetJavaValue=>left }}: {line}, leftBracesCount: {leftBracesCount}")
                            leftBracesCount -= GetCharCount(line, "}")
                            If isInMethod And leftBracesCount = 0 Then
                                'Debug.WriteLine($"[FileUtils] SetJavaValue=>method end: {line}")
                                isInMethod = False
                                If indexTag.Trim.Length > 0 Then
                                    Dim methodStr = methods.ToString
                                    'Debug.WriteLine($"[FileUtils] SetJavaValue=>methods: {methodStr}")
                                    If isDeleted Then
                                        'Debug.WriteLine($"[FileUtils] SetJavaValue=>has value: {methodStr.Substring(methodStr.IndexOf(value), value.Length)}, length: {methodStr.Length}")
                                        methodStr = methodStr.Replace(value, "")
                                    Else
                                        Debug.WriteLine($"[FileUtils] SetJavaValue=>has indexTag: {methodStr.Contains(indexTag)}")

                                        methodStr = methodStr.Replace(indexTag, value)
                                    End If
                                    methodStr = methodStr.Substring(0, methodStr.Length - newLine.Length)
                                    fileWriter.WriteLine(methodStr)
                                    result = True
                                End If
                            End If
                        End If
                    End If
                End If
                If isInMethod Then
                    'Debug.WriteLine($"[FileUtils] SetJavaValue=>line: {line}")
                    If insertTag.Trim.Length > 0 Then
                        If value.Trim.Split(newLine)(0).Trim.Equals(line.Trim) Then
                            found = True
                            result = True
                        End If
                        If Not found And line.Trim.StartsWith(insertTag) Then
                            fileWriter.WriteLine(value)
                            result = True
                        End If
                        fileWriter.WriteLine(line)
                    Else
                        methods.Append(line).Append(newLine)
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine($"[FileUtils] SetJavaValue=>error: {ex}")
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
