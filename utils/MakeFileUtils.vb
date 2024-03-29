﻿Imports System.IO
Imports System.Text

Module MakeFileUtils

    Public Function GetValueFromMakeFile(
                                        filePath As String, ' 文件路径
                                        macroName As String, ' 宏的名称
                                        encoding As Encoding, ' 编码格式
                                        separator As String ' 名称与值的分隔符
                                        ) As String
        Debug.WriteLine("[MakeFileUtils] GetValueFromMakeFile=>filePath: " & filePath)
        Dim result As String = Nothing
        If File.Exists(filePath) Then
            Dim fileReader = New StreamReader(filePath, encoding)
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.Trim.StartsWith(macroName) Then
                    Dim items = line.Split(separator)
                    If items.Length = 2 And items(0).Trim.Equals(macroName) Then
                        result = items(1).Trim
                    End If
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
        End If

        Debug.WriteLine("[MakeFileUtils] GetValueFromMakeFile=>result: " & result)
        Return result
    End Function

    Public Function HasValueInMakeFile(
                                      filePath As String, ' 原始文件路径
                                      encoding As Encoding, ' 编码格式
                                      value As String ' 要查询的字符串
                                      ) As Boolean
        Dim result As Boolean = False

        Try
            If File.Exists(filePath) Then
                Dim fileReader = New StreamReader(filePath, encoding)
                Dim content = fileReader.ReadToEnd()
                fileReader.Close()
                result = content.Contains(value)
            End If
        Catch ex As Exception
            Debug.WriteLine("[MakeFileUtils] HasValueInMakeFile=>error: " & ex.ToString)
        End Try

        Debug.WriteLine("[MakeFileUtils] HasValueInMakeFile=>result: " & result)
        Return result
    End Function

    Public Function SetValueToMakeFile(
                                      filePath As String, ' 原始文件路径
                                      encoding As Encoding, ' 换行符
                                      setPosition As String, ' 要修改的位置（该行开头的一段字符串）
                                      newValue As String ' 修改的值（整行字符串）
                                      ) As Boolean
        Dim result As Boolean = False

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Try
            If File.Exists(filePath) Then
                Dim tempFilePath = Utils.GetTempFilePath()
                File.Copy(filePath, tempFilePath)
                Dim newLine As String = Utils.GetNewLineCharacter(File.ReadAllText(tempFilePath))
                fileReader = New StreamReader(tempFilePath, encoding)
                fileWriter = New StreamWriter(filePath, False, encoding) With {
                    .NewLine = newLine
                }

                Dim line As String = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.StartsWith(setPosition) Then
                        fileWriter.WriteLine(newValue)
                        result = True
                    Else
                        fileWriter.WriteLine(line)
                    End If
                    line = fileReader.ReadLine
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[MakeFileUtils] SetValueToMakeFile=>error: " & ex.ToString)
        End Try

        If Not IsNothing(fileReader) Then
            fileReader.Close()
        End If
        If Not IsNothing(fileWriter) Then
            fileWriter.Close()
        End If

        Debug.WriteLine("[MakeFileUtils] SetValueToMakeFile=>result: " & result)
        Return result
    End Function

    Public Function AddValueToMakeFile(
                                       filePath As String, ' 原始文件路径
                                       encoding As Encoding, ' 编码格式
                                       value As String, ' 要添加的字符串
                                       insertPosition As String ' 要插入的位置（位于该位置的上一行），如果值为空字符串，则表示在文件末尾添加
                                      ) As Boolean
        Dim result As Boolean = False

        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing
        Try
            If File.Exists(filePath) Then
                Dim tempFilePath = Utils.GetTempFilePath()
                File.Copy(filePath, tempFilePath)
                Dim newLine As String = Utils.GetNewLineCharacter(File.ReadAllText(tempFilePath))
                fileReader = New StreamReader(tempFilePath, encoding)
                fileWriter = New StreamWriter(filePath, False, encoding) With {
                    .NewLine = newLine
                }

                Dim line = fileReader.ReadLine
                Do Until IsNothing(line)
                    If Not IsEmptyText(insertPosition) And line.Trim().StartsWith(insertPosition) Then
                        fileWriter.WriteLine(value)
                        result = True
                    End If
                    fileWriter.WriteLine(line)
                    line = fileReader.ReadLine
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
            Debug.WriteLine("[MakeFileUtils] AddValueToMakeFile=>error: " & ex.ToString)
            If Not IsNothing(fileReader) Then
                fileReader.Close()
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
            End If
        End Try

        Debug.WriteLine("[MakeFileUtils] AddValueToMakeFile=>result: " & result)
        Return result
    End Function

    Public Function RemoveValueFromMakeFile(
                                           originFilePath As String, ' 原始文件路径
                                           customFilePath As String, ' 客制文件路径
                                           macroName As String ' 宏的名称
                                           ) As Boolean
        Return False
    End Function

End Module
