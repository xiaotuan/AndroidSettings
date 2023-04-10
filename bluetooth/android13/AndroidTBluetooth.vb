Imports System.IO

Module AndroidTBluetooth

    Public Function GetDefaultState(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Debug.WriteLine("[AndroidTBluetooth] GetDefaultState=>originFilePath：" & originFilePath)
        Debug.WriteLine("[AndroidTBluetooth] GetDefaultState=>customFilePath：" & customFilePath)
        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Contains("<bool name=""def_bluetooth_on"">") Then
                        line = line.Trim
                        line = line.Substring(Len("<bool name=""def_bluetooth_on"">"))
                        Dim value = line.Substring(0, line.IndexOf("</bool>"))
                        Debug.WriteLine("[AndroidTBluetooth] GetDefaultState=>value：" & value)
                        If "true".Equals(value) Then
                            result = True
                            Exit Do
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            Else
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Contains("<bool name=""def_bluetooth_on"">") Then
                        line = line.Trim
                        line = line.Substring(Len("<bool name=""def_bluetooth_on"">"))
                        Dim value = line.Substring(0, line.IndexOf("</bool>"))
                        Debug.WriteLine("[AndroidTBluetooth] GetDefaultState=>value：" & value)
                        If "true".Equals(value) Then
                            result = True
                            Exit Do
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTBluetooth] GetDefaultState=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Public Function GetBluetoothName(ByRef info As ProjectInfo) As String
        Dim result As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/modules/Bluetooth/system/btif/src/btif_dm.cc"
        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.StartsWith("static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] = """) Then
                        line = line.Trim
                        line = line.Substring(Len("static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] = """))
                        result = line.Substring(0, line.IndexOf(""";"))
                        Debug.WriteLine("[AndroidTBluetooth] GetBluetoothName=>result：" & line)
                        result = result
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTBluetooth] GetBluetoothName=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Public Function SetDefaultState(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim backPath As String = customFilePath & ".bk"

        Dim fileReader As System.IO.StreamReader = Nothing
        Dim fileWriter As System.IO.StreamWriter = Nothing
        Dim fs As FileStream = Nothing
        Try
            If Not System.IO.File.Exists(customFilePath) Then
                If Not System.IO.Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                System.IO.File.Copy(originFilePath, customFilePath, True)
            Else
                fileExists = True
            End If
            System.IO.File.Copy(customFilePath, backPath, True)
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim contents = fileReader.ReadToEnd().Split(vbLf)
            Dim line As String = Nothing
            Dim length As Integer = 0
            Debug.WriteLine("[AndroidTBluetooth] SetDefaultState=>lines: " & contents.Length.ToString)
            For Each line In contents
                If line.Trim.StartsWith("<bool name=""def_bluetooth_on"">") Then
                    Debug.WriteLine("[AndroidTBluetooth] SetDefaultState=>line: " & line)
                    fileWriter.WriteLine("    <bool name=""def_bluetooth_on"">" & isOpen.ToString.ToLower & "</bool>")
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
            Next
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTBluetooth] SetDefaultState=>error: " + ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If Not fileExists Then
                If System.IO.File.Exists(customFilePath) Then
                    System.IO.File.Delete(customFilePath)
                End If
            Else
                If needRestore And System.IO.File.Exists(backPath) Then
                    System.IO.File.Copy(backPath, customFilePath, True)
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

    Public Function SetBluetoothName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/modules/Bluetooth/system/btif/src/btif_dm.cc"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/modules/Bluetooth/system/btif/src/btif_dm.cc"
        Dim backPath As String = customFilePath & ".bk"

        Dim fs As FileStream = Nothing
        Dim fileReader As System.IO.StreamReader = Nothing
        Dim fileWriter As System.IO.StreamWriter = Nothing
        Try
            If Not System.IO.File.Exists(customFilePath) Then
                If Not System.IO.Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                System.IO.File.Copy(originFilePath, customFilePath, True)
            Else
                fileExists = True
            End If
            System.IO.File.Copy(customFilePath, backPath, True)
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.Trim.StartsWith("static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] =") Then
                    fileWriter.WriteLine("static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] = """ & name & """;")
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTBluetooth] SetBluetoothName=>error: " + ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If Not fileExists Then
                If System.IO.File.Exists(customFilePath) Then
                    System.IO.File.Delete(customFilePath)
                End If
            Else
                If needRestore And System.IO.File.Exists(backPath) Then
                    System.IO.File.Copy(backPath, customFilePath, True)
                End If
            End If
        End Try
        If System.IO.File.Exists(backPath) Then
            System.IO.File.Delete(backPath)
        End If
        Return result
    End Function

End Module
