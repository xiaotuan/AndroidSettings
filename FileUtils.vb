Imports System.IO

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
End Module
