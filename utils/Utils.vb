Imports System.IO

Module Utils

    Public Function IsEmptyText(Optional value As String = Nothing) As Boolean
        If value Is Nothing Or Len(value.Trim) = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function GetNewLineCharacter(line As String) As String
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

    Public Function GetTempFilePath() As String
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

    Public Function GetBraceCount(line As String, charStr As String) As Integer
        Dim count As Integer = 0
        For Each c As String In line
            If c.Equals(charStr) Then
                count += 1
            End If
        Next
        Return count
    End Function

End Module
