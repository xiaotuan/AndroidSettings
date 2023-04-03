Imports System.IO
Imports System.Text.Unicode
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module AndroidTWifi

    Public Function GetWifiDefaultState(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until line Is Nothing
                    If line.Contains("<bool name=""def_wifi_on"">") Then
                        line = line.Trim
                        line = line.Substring(Len("<bool name=""def_wifi_on"">"))
                        Dim value = line.Substring(0, line.IndexOf("</bool>"))
                        Debug.WriteLine("[AndroidTWifi] GetWifiDefaultState=>value：" & value)
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
                    If line.Contains("<bool name=""def_wifi_on"">") Then
                        line = line.Trim
                        line = line.Substring(Len("<bool name=""def_wifi_on"">"))
                        Dim value = line.Substring(0, line.IndexOf("</bool>"))
                        Debug.WriteLine("[AndroidTWifi] GetWifiDefaultState=>value：" & value)
                        If "true".Equals(value) Then
                            result = True
                            Exit Do
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTWifi] GetWifiDefaultState=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Public Function GetHotspotName(ByRef info As ProjectInfo) As String
        Dim result As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/WifiApConfigStore.java"
        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Dim findMethod As Boolean = False
                Dim bracesCount As Integer = 0
                Do Until line Is Nothing
                    If line.Trim.StartsWith("private SoftApConfiguration getDefaultApConfiguration() {") Then
                        findMethod = True
                        bracesCount = 1
                        line = fileReader.ReadLine()
                        Continue Do
                    End If
                    If findMethod Then
                        If line.Trim.StartsWith("configBuilder.setSsid(""") Then
                            line = line.Trim
                            line = line.Substring(Len("configBuilder.setSsid("""))
                            result = line.Substring(0, line.IndexOf(""");"))
                            Debug.WriteLine("[AndroidTWifi] GetHotspotName=>result：" & line)
                            result = result
                            Exit Do
                        End If
                        If line.Contains("{") Then
                            bracesCount += 1
                        End If
                        If line.Contains("}") Then
                            bracesCount -= 1
                        End If
                        If bracesCount = 0 Then
                            findMethod = False
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTWifi] GetHotspotName=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Public Function GetScreenCastName(ByRef info As ProjectInfo) As String
        Dim result As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/p2p/WifiP2pServiceImpl.java"
        Dim fileReader As System.IO.StreamReader = Nothing
        Try
            If System.IO.File.Exists(customFilePath) Then
                Dim utf8 = New System.Text.UTF8Encoding(False)
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Dim findMethod As Boolean = False
                Dim bracesCount As Integer = 0
                Do Until line Is Nothing
                    If line.Trim.StartsWith("private String getPersistedDeviceName() {") Then
                        findMethod = True
                        bracesCount = 1
                        line = fileReader.ReadLine()
                        Continue Do
                    End If
                    If findMethod Then
                        If line.Trim.StartsWith("deviceName = """) Then
                            line = line.Trim
                            line = line.Substring("deviceName = """.Length).Trim
                            line = line.Substring(0, line.IndexOf("""") + 1)
                            result = line.Substring(0, line.Length - 1)
                            Debug.WriteLine("[AndroidTWifi] GetScreenCastName=>result：" & result)
                            Exit Do
                        End If
                        If line.Contains("{") Then
                            bracesCount += 1
                        End If
                        If line.Contains("}") Then
                            bracesCount -= 1
                        End If
                        If bracesCount = 0 Then
                            findMethod = False
                        End If
                    End If
                    line = fileReader.ReadLine()
                Loop
                fileReader.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTWifi] GetScreenCastName=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
        End Try
        Return result
    End Function

    Public Function SetWifiDefaultState(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
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
                System.IO.File.Copy(originFilePath, customFilePath)
            Else
                fileExists = True
            End If
            System.IO.File.Copy(customFilePath, backPath)
            fs = New FileStream(customFilePath, FileMode.Open)
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fileReader = New System.IO.StreamReader(backPath, utf8)
            fileWriter = New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until IsNothing(line)
                'Debug.WriteLine("[AndroidTWifi] SetWifiDefaultState=>line: " & line)
                If line.Trim.StartsWith("<bool name=""def_wifi_on"">") Then
                    Debug.WriteLine("[AndroidTWifi] SetWifiDefaultState=>line: " & line)
                    fileWriter.WriteLine("    <bool name=""def_wifi_on"">" & isOpen.ToString.ToLower & "</bool>")
                    result = True
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            If Not isOpen Then
                fileReader.Close()
                fileReader = Nothing
                fileWriter.Close()
                fileWriter = Nothing
                If System.IO.File.Exists(backPath) Then
                    System.IO.File.Delete(backPath)
                End If
                originFilePath = info.ProjectPath & "/sys/frameworks/base/services/core/java/com/android/server/am/ActivityManagerService.java"
                customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/frameworks/base/services/core/java/com/android/server/am/ActivityManagerService.java"
                backPath = customFilePath & ".bak"
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
                fileReader = New System.IO.StreamReader(backPath, utf8)
                fileWriter = New System.IO.StreamWriter(fs, utf8)
                fileWriter.NewLine = vbLf
                line = fileReader.ReadLine()
                Dim findMethod As Boolean = False
                Dim bracesCount As Integer = 0
                Dim findBlock As Boolean = False
                Do Until IsNothing(line)
                    If line.Trim.StartsWith("final int broadcastIntentLocked(ProcessRecord callerApp, String callerPackage,") Then
                        findMethod = True
                        bracesCount = 1
                        fileWriter.WriteLine(line)
                        line = fileReader.ReadLine()
                        Continue Do
                    End If
                    If line.Trim.StartsWith("if (intent != null && intent.getAction() != null && intent.getAction().equals(Intent.ACTION_PACKAGE_CHANGED)) {") Then
                        findBlock = True
                    End If
                    If Not findBlock And findMethod Then
                        Debug.WriteLine("[AndroidTWifi] SetHotspotName=>line: " & line)
                        If line.Contains("{") Then
                            bracesCount += 1
                        End If
                        If line.Contains("}") Then
                            bracesCount -= 1
                        End If
                        If bracesCount = 0 Then
                            findMethod = False
                        End If
                        If line.Trim.StartsWith("final boolean isCallerSystem;") Then
                            fileWriter.WriteLine("        if (intent != null && intent.getAction() != null && intent.getAction().equals(Intent.ACTION_PACKAGE_CHANGED)) {")
                            fileWriter.WriteLine("            String data =intent.getDataString();")
                            fileWriter.WriteLine("            if (data != null && data.length() != 0) {")
                            fileWriter.WriteLine("                if (data.endsWith(""setupwizard"")) {")
                            fileWriter.WriteLine("                    if (android.provider.Settings.Global.getInt(mContext.getContentResolver(), android.provider.Settings.Global.WIFI_ON, 0) == 0) {")
                            fileWriter.WriteLine("                        android.net.wifi.WifiManager mWifiManager =(android.net.wifi.WifiManager) mContext.getSystemService(Context.WIFI_SERVICE);")
                            fileWriter.WriteLine("                        int state =mWifiManager.getWifiState();")
                            fileWriter.WriteLine("                        if(state == android.net.wifi.WifiManager.WIFI_STATE_ENABLED){")
                            fileWriter.WriteLine("                            mWifiManager.setWifiEnabled(false);")
                            fileWriter.WriteLine("                        }")
                            fileWriter.WriteLine("                    }")
                            fileWriter.WriteLine("                }")
                            fileWriter.WriteLine("            }")
                            fileWriter.WriteLine("        }")
                            fileWriter.WriteLine("")
                            fileWriter.WriteLine(line)
                            result = True
                        Else
                            fileWriter.WriteLine(line)
                        End If
                    Else
                        fileWriter.WriteLine(line)
                    End If
                    line = fileReader.ReadLine()
                Loop
            End If
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTWifi] SetWifiDefaultState=>error: " + ex.ToString)
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

    Public Function SetHotspotName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/packages/modules/Wifi/service/java/com/android/server/wifi/WifiApConfigStore.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/WifiApConfigStore.java"
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
            Dim findMethod As Boolean = False
            Dim bracesCount As Integer = 0
            Do Until IsNothing(line)
                If line.Trim.StartsWith("private SoftApConfiguration getDefaultApConfiguration() {") Then
                    findMethod = True
                    bracesCount = 1
                    fileWriter.WriteLine(line)
                    line = fileReader.ReadLine()
                    Continue Do
                End If
                If findMethod Then
                    Debug.WriteLine("[AndroidTWifi] SetHotspotName=>line: " & line)
                    If line.Trim.StartsWith("configBuilder.setSsid(") Then
                        fileWriter.WriteLine("        configBuilder.setSsid(""" & name & """);")
                        result = True
                    Else
                        fileWriter.WriteLine(line)
                    End If
                    If line.Contains("{") Then
                        bracesCount += 1
                    End If
                    If line.Contains("}") Then
                        bracesCount -= 1
                    End If
                    If bracesCount = 0 Then
                        findMethod = False
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTWifi] SetHotspotName=>error: " + ex.ToString)
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

    Public Function SetScreenCastName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Debug.WriteLine("[AndroidTWifi] SetScreenCastName()...")
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/packages/modules/Wifi/service/java/com/android/server/wifi/p2p/WifiP2pServiceImpl.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/p2p/WifiP2pServiceImpl.java"
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
            Dim findMethod As Boolean = False
            Dim bracesCount As Integer = 0
            Do Until IsNothing(line)
                If line.Trim.StartsWith("private String getPersistedDeviceName() {") Then
                    findMethod = True
                    bracesCount = 1
                    fileWriter.WriteLine(line)
                    line = fileReader.ReadLine()
                    Continue Do
                End If
                If findMethod Then
                    Debug.WriteLine("[AndroidTWifi] SetScreenCastName=>line: " & line)
                    If line.Trim.StartsWith("deviceName = ") Then
                        fileWriter.WriteLine("                deviceName = """ & name & """;")
                        result = True
                    Else
                        fileWriter.WriteLine(line)
                    End If
                    If line.Contains("{") Then
                        bracesCount += 1
                    End If
                    If line.Contains("}") Then
                        bracesCount -= 1
                    End If
                    If bracesCount = 0 Then
                        findMethod = False
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
        Catch ex As Exception
            result = False
            needRestore = True
            Debug.WriteLine("[AndroidTWifi] SetScreenCastName=>error: " + ex.ToString)
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
