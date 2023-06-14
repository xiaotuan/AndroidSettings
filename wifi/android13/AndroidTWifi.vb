
Imports System.Text

Module AndroidTWifi

    Public Function GetWifiDefaultState(ByRef info As ProjectInfo) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value = FileUtils.GetXmlValue(originFilePath, customFilePath, "<bool name=""def_wifi_on"">", "<bool name=""def_wifi_on"">", "</bool>")
        Debug.WriteLine($"[AndroidTWifi] GetWifiDefaultState=>value: {value}")
        Return value.Equals("true")
    End Function

    Public Function GetHotspotName(ByRef info As ProjectInfo) As String
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/WifiApConfigStore.java"
        Return FileUtils.GetJavaValue("", customFilePath, "private SoftApConfiguration getDefaultApConfiguration() {",
                                      "configBuilder.setSsid(", "configBuilder.setSsid(""", """);")
    End Function

    Public Function GetScreenCastName(ByRef info As ProjectInfo) As String
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/p2p/WifiP2pServiceImpl.java"
        Return FileUtils.GetJavaValue("", customFilePath, "private String getPersistedDeviceName() {",
                                      "deviceName = ", "deviceName = """, """;")
    End Function

    Public Function SetWifiDefaultState(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim javaOriginFilePath = info.ProjectPath & "/sys/frameworks/base/services/core/java/com/android/server/am/ActivityManagerService.java"
        Dim javaCustomFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/frameworks/base/services/core/java/com/android/server/am/ActivityManagerService.java"

        Dim newLine As String = vbLf
        Dim value As String = "false"
        If isOpen Then
            value = "true"
        End If
        Dim wifiOffJavaStr As StringBuilder = New StringBuilder()
        If isOpen Then
            wifiOffJavaStr.Append(newLine)
        End If
        wifiOffJavaStr.Append("        if (intent != null && intent.getAction() != null && intent.getAction().equals(Intent.ACTION_PACKAGE_CHANGED)) {").Append(newLine)
        wifiOffJavaStr.Append("            String data =intent.getDataString();").Append(newLine)
        wifiOffJavaStr.Append("            if (data != null && data.length() != 0) {").Append(newLine)
        wifiOffJavaStr.Append("                if (data.endsWith(""setupwizard"")) {").Append(newLine)
        wifiOffJavaStr.Append("                    if (android.provider.Settings.Global.getInt(mContext.getContentResolver(), android.provider.Settings.Global.WIFI_ON, 0) == 0) {").Append(newLine)
        wifiOffJavaStr.Append("                        android.net.wifi.WifiManager mWifiManager =(android.net.wifi.WifiManager) mContext.getSystemService(Context.WIFI_SERVICE);").Append(newLine)
        wifiOffJavaStr.Append("                        int state =mWifiManager.getWifiState();").Append(newLine)
        wifiOffJavaStr.Append("                        if(state == android.net.wifi.WifiManager.WIFI_STATE_ENABLED){").Append(newLine)
        wifiOffJavaStr.Append("                            mWifiManager.setWifiEnabled(false);").Append(newLine)
        wifiOffJavaStr.Append("                        }").Append(newLine)
        wifiOffJavaStr.Append("                    }").Append(newLine)
        wifiOffJavaStr.Append("                }").Append(newLine)
        wifiOffJavaStr.Append("            }").Append(newLine)
        wifiOffJavaStr.Append("        }")

        If isOpen Then
            Return FileUtils.SetXmlValue(originFilePath, customFilePath, newLine, "<bool name=""def_wifi_on"">",
                                     "", "<bool name=""def_wifi_on"">" & value & "</bool>") And FileUtils.SetJavaValue(
                                     javaOriginFilePath, javaCustomFilePath, newLine, "final int broadcastIntentLocked(ProcessRecord callerApp, String callerPackage,",
                                     "if (intent != null && intent.getAction() != null && intent.getAction().equals(Intent.ACTION_PACKAGE_CHANGED)) {", "", wifiOffJavaStr.ToString, True)
        Else
            Return FileUtils.SetXmlValue(originFilePath, customFilePath, newLine, "<bool name=""def_wifi_on"">",
                                     "", "<bool name=""def_wifi_on"">" & value & "</bool>") And FileUtils.SetJavaValue(
                                     javaOriginFilePath, javaCustomFilePath, newLine, "final int broadcastIntentLocked(ProcessRecord callerApp, String callerPackage,",
                                     "", "final boolean isCallerSystem;", wifiOffJavaStr.ToString, False)
        End If
    End Function

    Public Function SetHotspotName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/packages/modules/Wifi/service/java/com/android/server/wifi/WifiApConfigStore.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/WifiApConfigStore.java"
        Return FileUtils.SetJavaValue(originFilePath, customFilePath, vbLf, "private SoftApConfiguration getDefaultApConfiguration() {",
                                      "configBuilder.setSsid", "", "configBuilder.setSsid(""" & name & """);", False)
    End Function

    Public Function SetScreenCastName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Dim originFilePath As String = info.ProjectPath & "/sys/packages/modules/Wifi/service/java/com/android/server/wifi/p2p/WifiP2pServiceImpl.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/packages/modules/Wifi/service/java/com/android/server/wifi/p2p/WifiP2pServiceImpl.java"
        Return FileUtils.SetJavaValue(originFilePath, customFilePath, vbLf, "private String getPersistedDeviceName() {", "deviceName = ", "", "deviceName = """ & name & """;", False)
    End Function

End Module
