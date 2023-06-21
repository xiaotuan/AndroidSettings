Imports System.IO

Module AndroidTBluetooth

    Public Function GetDefaultState(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        result = FileUtils.GetXmlFileValue(originFilePath, customFilePath, "<bool name=""def_bluetooth_on"">", "<bool name=""def_bluetooth_on"">", "</bool>")
        Return result
    End Function

    Public Function GetBluetoothName(ByRef info As ProjectInfo) As String
        Dim result As String = ""
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/modules/Bluetooth/system/btif/src/btif_dm.cc"
        result = FileUtils.GetCppFileValue("", customFilePath, "", "static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] =", "static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] = """, """;")
        Return result
    End Function

    Public Function SetDefaultState(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/SettingsProvider/res/values/defaults.xml"
        Dim value As String = "false"
        If isOpen Then
            value = "true"
        End If
        result = FileUtils.SetXmlFileValue(originFilePath, customFilePath, vbLf, "<bool name=""def_bluetooth_on"">" & value & "</bool>", "<bool name=""def_bluetooth_on"">", "")
        Return result
    End Function

    Public Function SetBluetoothName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        Dim result As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/vendor/mediatek/proprietary/packages/modules/Bluetooth/system/btif/src/btif_dm.cc"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/modules/Bluetooth/system/btif/src/btif_dm.cc"
        result = FileUtils.SetCppFileValue(originFilePath, customFilePath, vbLf, "static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] = """ & name & """;", "", "static char btif_default_local_name[DEFAULT_LOCAL_NAME_MAX + 1] =", "")
        Return result
    End Function

End Module
