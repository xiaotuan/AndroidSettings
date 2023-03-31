Imports System.IO

Module AndroidTProperty

    Public Function GetProductName(ByRef info As ProjectInfo) As String
        Return GetPropertyValue(info, "PRODUCT_SYSTEM_NAME :=")
    End Function

    Public Function GetProductModel(ByRef info As ProjectInfo) As String
        Return GetPropertyValue(info, "PRODUCT_MODEL :=")
    End Function

    Public Function GetProductBrand(ByRef info As ProjectInfo) As String
        Return GetPropertyValue(info, "PRODUCT_BRAND :=")
    End Function

    Public Function GetProductDevice(ByRef info As ProjectInfo) As String
        Return GetPropertyValue(info, "PRODUCT_SYSTEM_DEVICE :=")
    End Function

    Public Function GetProductManufacturer(ByRef info As ProjectInfo) As String
        Return GetPropertyValue(info, "PRODUCT_MANUFACTURER :=")
    End Function

    Public Function SetProductName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Return SetPropertyValue(info, "PRODUCT_SYSTEM_NAME :=", name)
    End Function

    Public Function SetProductModel(ByRef info As ProjectInfo, ByVal model As String) As Boolean
        Return SetPropertyValue(info, "PRODUCT_MODEL :=", model)
    End Function

    Public Function SetProductBrand(ByRef info As ProjectInfo, ByVal brand As String) As Boolean
        Return SetPropertyValue(info, "PRODUCT_BRAND :=", brand)
    End Function

    Public Function SetProductDevice(ByRef info As ProjectInfo, ByVal device As String) As Boolean
        Return SetPropertyValue(info, "PRODUCT_SYSTEM_DEVICE :=", device)
    End Function

    Public Function SetProductManufacturer(ByRef info As ProjectInfo, ByVal manufacturer As String) As Boolean
        Return SetPropertyValue(info, "PRODUCT_MANUFACTURER :=", manufacturer)
    End Function

    Private Function GetPropertyValue(ByRef info As ProjectInfo, tag As String) As String
        Dim name As String = ""
        Dim originFilePath As String = info.ProjectPath & "/sys/device/mediatek/system/" + info.MssiDirName + "/sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/device/mediatek/system/" + info.MssiDirName + "/sys_" & info.MssiDirName & ".mk"
        If System.IO.File.Exists(customFilePath) Then
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(customFilePath, utf8)
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith(tag) Then
                    name = line.Split(":=")(1).Trim
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
        Else
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(originFilePath, utf8)
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith(tag) Then
                    name = line.Split(":=")(1).Trim
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
        End If
        Return name
    End Function

    Private Function SetPropertyValue(ByRef info As ProjectInfo, tag As String, value As String) As Boolean
        If SetAndroidSPropertyValue(info, tag, value) Then
            If SetAndroidTPropertyValue(info, tag, value) Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function SetAndroidTPropertyValue(ByRef info As ProjectInfo, tag As String, value As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/device/mediatek/system/" + info.MssiDirName + "/sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/device/mediatek/system/" + info.MssiDirName + "/sys_" & info.MssiDirName & ".mk"
        Dim backPath As String = customFilePath & ".bk"
        Try
            If Not System.IO.File.Exists(customFilePath) Then
                System.IO.File.Copy(originFilePath, customFilePath)
            End If
            System.IO.File.Copy(customFilePath, backPath)
            Dim fs As FileStream = Nothing
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(backPath, utf8)
            Dim fileWriter As New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith(tag) Then
                    fileWriter.WriteLine(tag & " " & value)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
            fileWriter.Close()
            fs.Close()
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTProperty] SetAndroidTPropertyValue=>error: " + ex.ToString)
            If Not fileExists Then
                If System.IO.File.Exists(customFilePath) Then
                    System.IO.File.Delete(customFilePath)
                End If
            Else
                If System.IO.File.Exists(backPath) Then
                    System.IO.File.Copy(backPath, customFilePath)
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

    Private Function SetAndroidSPropertyValue(ByRef info As ProjectInfo, tag As String, value As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/vnd/device/mediateksample/" + info.PublicDirName + "/vnd_" & info.PublicDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/device/mediateksample/" + info.PublicDirName + "/vnd_" & info.PublicDirName & ".mk"
        Dim backPath As String = customFilePath & ".bk"
        Try
            If Not System.IO.File.Exists(customFilePath) Then
                System.IO.File.Copy(originFilePath, customFilePath)
            End If
            System.IO.File.Copy(customFilePath, backPath)
            Dim fs As FileStream = Nothing
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(backPath, utf8)
            Dim fileWriter As New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith(tag) Then
                    fileWriter.WriteLine(tag & " " & value)
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
            fileWriter.Close()
            fs.Close()
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTProperty] SetAndroidSPropertyValue=>error: " + ex.ToString)
            If Not fileExists Then
                If System.IO.File.Exists(customFilePath) Then
                    System.IO.File.Delete(customFilePath)
                End If
            Else
                If System.IO.File.Exists(backPath) Then
                    System.IO.File.Copy(backPath, customFilePath)
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

End Module
