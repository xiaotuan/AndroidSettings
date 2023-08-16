Imports System.IO
Imports System.Text

Public Module XmlFileUtils

    Public Function GetValueFromXmlFile(
                                        filePath As String, ' 文件路径
                                        encoding As Encoding, ' 编码格式
                                        startTag As String, ' 开始标签
                                        endTag As String ' 结束标签
                                        ) As String
        Debug.WriteLine("[XmlFileUtils] GetValueFromXmlFile=>filePath: " & filePath)
        Dim result As String = Nothing

        If File.Exists(filePath) Then
            Dim fileReader = New StreamReader(filePath, encoding)
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                line = line.Trim()
                If line.StartsWith(startTag) And line.EndsWith(endTag) Then
                    line = line.Substring(Len(startTag))
                    Dim index = line.IndexOf(endTag)
                    If index <> -1 Then
                        result = line.Substring(0, index)
                        Exit Do
                    End If
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
        End If

        Debug.WriteLine("[XmlFileUtils] GetValueFromXmlFile=>result: " & result)
        Return result
    End Function

    Public Function SetValueToXmlFile(
                                     filePath As String, ' 文件路径
                                     encoding As Encoding, ' 文件编码
                                     newValue As String, ' 要设置的值（整行）
                                     positionTag As String ' 要设置值的位置标签
                                     ) As Boolean
        Dim result As Boolean = False

        If File.Exists(filePath) Then
            Dim fileReader As StreamReader = Nothing
            Dim fileWriter As StreamWriter = Nothing
            Try
                Dim tempFilePath = GetTempFilePath()
                File.Copy(filePath, tempFilePath)
                Dim newLine = GetNewLineCharacter(File.ReadAllText(tempFilePath))
                fileReader = New StreamReader(tempFilePath, encoding)
                Dim line = fileReader.ReadLine
                fileWriter = New StreamWriter(filePath, False, encoding) With {
                    .NewLine = newLine
                }
                Do Until IsNothing(line)
                    If line.Trim.StartsWith(positionTag) Then
                        fileWriter.WriteLine(newValue)
                        result = True
                    Else
                        fileWriter.WriteLine(line)
                    End If
                    line = fileReader.ReadLine
                Loop
            Catch ex As Exception
                Debug.WriteLine("[XmlFileUtils] SetValueToXmlFile=>error: " & ex.ToString)
            End Try
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
        Else
            Debug.WriteLine("[XmlFileUtils] SetValueToXmlFile=>" & filePath & " not exist.")
        End If

        Debug.WriteLine("[XmlFileUtils] SetValueToXmlFile=>result: " & result)
        Return result
    End Function

    Function GetNewLineCharacter(line As String) As String
        If line.Contains(vbCrLf) Then
            Debug.WriteLine("[XmlFileUtils] GetNewLineCharacter=>newline: vbCrLf")
            Return vbCrLf
        ElseIf line.Contains(vbCr) Then
            Debug.WriteLine("[XmlFileUtils] GetNewLineCharacter=>newline: vbCr")
            Return vbCr
        ElseIf line.Contains(vbLf) Then
            Debug.WriteLine("[XmlFileUtils] GetNewLineCharacter=>newline: vbLf")
            Return vbLf
        Else
            Debug.WriteLine("[XmlFileUtils] GetNewLineCharacter=>newline: Environment.NewLine")
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

End Module
