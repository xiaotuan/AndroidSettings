' AndroidTProperty 模块是 Android 13 系统修改系统产品名称、型号、品牌、设备名称和制造商模块
' Android 13 系统修改产品名称、型号、品牌、设备名称和制造商的方法如下：
' 修改 sys\device\mediatek\system\mssi_t_64_cn\sys_mssi_t_64_cn.mk 文件和
' vnd\device\mediateksample\tb8766p1_64_bsp\vnd_tb8766p1_64_bsp.mk 文件中的如下宏的值：
' PRODUCT_MANUFACTURER：制造商
' PRODUCT_MODEL：型号
' PRODUCT_BRAND：品牌
' PRODUCT_SYSTEM_NAME：名称
' PRODUCT_SYSTEM_DEVICE：设备名称

Module AndroidTProperty

    ' 获取产品名称
    '
    ' info：工程信息
    '
    ' return：获取成功返回产品名称，否则返回空字符串
    Public Function GetProductName(ByRef info As ProjectInfo) As String
        'Return GetPropertyValue(info, "PRODUCT_SYSTEM_NAME :=")
        Dim originFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Return FileUtils.GetMakeFileValue("PRODUCT_SYSTEM_NAME", ":=", originFilePath, customFilePath)
    End Function

    ' 获取产品型号
    '
    ' info：工程信息
    '
    ' return：获取成功返回产品型号，否则返回空字符串
    Public Function GetProductModel(ByRef info As ProjectInfo) As String
        'Return GetPropertyValue(info, "PRODUCT_MODEL :=")
        Dim originFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Return FileUtils.GetMakeFileValue("PRODUCT_MODEL", ":=", originFilePath, customFilePath)
    End Function

    ' 获取产品品牌
    '
    ' info：工程信息
    '
    ' return：获取成功返回产品品牌，否则返回空字符串
    Public Function GetProductBrand(ByRef info As ProjectInfo) As String
        'Return GetPropertyValue(info, "PRODUCT_BRAND :=")
        Dim originFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Return FileUtils.GetMakeFileValue("PRODUCT_BRAND", ":=", originFilePath, customFilePath)
    End Function

    ' 获取产品设备名称
    '
    ' info：工程信息
    '
    ' return：获取成功返回产品设备名称，否则返回空字符串
    Public Function GetProductDevice(ByRef info As ProjectInfo) As String
        'Return GetPropertyValue(info, "PRODUCT_SYSTEM_DEVICE :=")
        Dim originFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Return FileUtils.GetMakeFileValue("PRODUCT_SYSTEM_DEVICE", ":=", originFilePath, customFilePath)
    End Function

    ' 获取产品制造商
    '
    ' info：工程信息
    '
    ' return：获取成功返回产品制造商，否则返回空字符串
    Public Function GetProductManufacturer(ByRef info As ProjectInfo) As String
        'Return GetPropertyValue(info, "PRODUCT_MANUFACTURER :=")
        Dim originFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Return FileUtils.GetMakeFileValue("PRODUCT_MANUFACTURER", ":=", originFilePath, customFilePath)
    End Function

    ' 设置产品名称
    '
    ' info：工程信息
    ' name：要设置的产品名称
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetProductName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        'Return SetPropertyValue(info, "PRODUCT_SYSTEM_NAME :=", name)
        Dim sysOriginFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim sysCustomFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Dim vndOriginFilePath As String = info.ProjectPath & "\vnd\device\mediateksample\" & info.PublicDirName &
            "\vnd_" & info.PublicDirName & ".mk"
        Dim vndCustomFilePath As String = info.ProjectPath & "\vnd\weibu\" & info.PublicDirName & "\" & info.DriveDirName &
            "\alps\device\mediateksample\" & info.PublicDirName & "\vnd_" & info.PublicDirName & ".mk"
        Return FileUtils.SetMakeFileValue("PRODUCT_SYSTEM_NAME :=", "PRODUCT_SYSTEM_NAME := " & name, sysCustomFilePath, sysOriginFilePath, vbLf, "") And
            FileUtils.SetMakeFileValue("PRODUCT_SYSTEM_NAME :=", "PRODUCT_SYSTEM_NAME := " & name， vndCustomFilePath, vndOriginFilePath, vbLf, "")
    End Function

    ' 设置产品型号
    '
    ' info：工程信息
    ' model：要设置的产品型号
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetProductModel(ByRef info As ProjectInfo, ByVal model As String) As Boolean
        'Return SetPropertyValue(info, "PRODUCT_MODEL :=", model)
        Dim sysOriginFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim sysCustomFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Dim vndOriginFilePath As String = info.ProjectPath & "\vnd\device\mediateksample\" & info.PublicDirName &
            "\vnd_" & info.PublicDirName & ".mk"
        Dim vndCustomFilePath As String = info.ProjectPath & "\vnd\weibu\" & info.PublicDirName & "\" & info.DriveDirName &
            "\alps\device\mediateksample\" & info.PublicDirName & "\vnd_" & info.PublicDirName & ".mk"
        Return FileUtils.SetMakeFileValue("PRODUCT_MODEL :=", "PRODUCT_MODEL := " & model, sysCustomFilePath, sysOriginFilePath, vbLf, "") And
            FileUtils.SetMakeFileValue("PRODUCT_MODEL :=", "PRODUCT_MODEL := " & model, vndCustomFilePath, vndOriginFilePath, vbLf, "")
    End Function

    ' 设置产品品牌
    '
    ' info：工程信息
    ' brand：要设置的产品品牌
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetProductBrand(ByRef info As ProjectInfo, ByVal brand As String) As Boolean
        'Return SetPropertyValue(info, "PRODUCT_BRAND :=", brand)
        Dim sysOriginFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim sysCustomFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Dim vndOriginFilePath As String = info.ProjectPath & "\vnd\device\mediateksample\" & info.PublicDirName &
            "\vnd_" & info.PublicDirName & ".mk"
        Dim vndCustomFilePath As String = info.ProjectPath & "\vnd\weibu\" & info.PublicDirName & "\" & info.DriveDirName &
            "\alps\device\mediateksample\" & info.PublicDirName & "\vnd_" & info.PublicDirName & ".mk"
        Return FileUtils.SetMakeFileValue("PRODUCT_BRAND :=", "PRODUCT_BRAND := " & brand, sysCustomFilePath, sysOriginFilePath, vbLf, "") And
            FileUtils.SetMakeFileValue("PRODUCT_BRAND :=", "PRODUCT_BRAND := " & brand, vndCustomFilePath, vndOriginFilePath, vbLf, "")
    End Function

    ' 设置产品设备名称
    '
    ' info：工程信息
    ' device：要设置的产品设备名称
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetProductDevice(ByRef info As ProjectInfo, ByVal device As String) As Boolean
        ' Return SetPropertyValue(info, "PRODUCT_SYSTEM_DEVICE :=", device)
        Dim sysOriginFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim sysCustomFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Dim vndOriginFilePath As String = info.ProjectPath & "\vnd\device\mediateksample\" & info.PublicDirName &
            "\vnd_" & info.PublicDirName & ".mk"
        Dim vndCustomFilePath As String = info.ProjectPath & "\vnd\weibu\" & info.PublicDirName & "\" & info.DriveDirName &
            "\alps\device\mediateksample\" & info.PublicDirName & "\vnd_" & info.PublicDirName & ".mk"
        Return FileUtils.SetMakeFileValue("PRODUCT_SYSTEM_DEVICE :=", "PRODUCT_SYSTEM_DEVICE := " & device, sysCustomFilePath, sysOriginFilePath, vbLf, "") And
            FileUtils.SetMakeFileValue("PRODUCT_SYSTEM_DEVICE :=", "PRODUCT_SYSTEM_DEVICE := " & device, vndCustomFilePath, vndOriginFilePath, vbLf, "")
    End Function

    ' 设置产品制造商
    '
    ' info：工程信息
    ' manufacturer：要设置的产品制造商
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetProductManufacturer(ByRef info As ProjectInfo, ByVal manufacturer As String) As Boolean
        ' Return SetPropertyValue(info, "PRODUCT_MANUFACTURER :=", manufacturer)
        Dim sysOriginFilePath As String = info.ProjectPath & "\sys\device\mediatek\system\" & info.MssiDirName &
            "\sys_" & info.MssiDirName & ".mk"
        Dim sysCustomFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName & "\" & info.CustomDirName &
            "\alps\device\mediatek\system\" & info.MssiDirName & "\sys_" & info.MssiDirName & ".mk"
        Dim vndOriginFilePath As String = info.ProjectPath & "\vnd\device\mediateksample\" & info.PublicDirName &
            "\vnd_" & info.PublicDirName & ".mk"
        Dim vndCustomFilePath As String = info.ProjectPath & "\vnd\weibu\" & info.PublicDirName & "\" & info.DriveDirName &
            "\alps\device\mediateksample\" & info.PublicDirName & "\vnd_" & info.PublicDirName & ".mk"
        Return FileUtils.SetMakeFileValue("PRODUCT_MANUFACTURER :=", "PRODUCT_MANUFACTURER := " & manufacturer, sysCustomFilePath, sysOriginFilePath, vbLf, "") And
            FileUtils.SetMakeFileValue("PRODUCT_MANUFACTURER :=", "PRODUCT_MANUFACTURER := " & manufacturer, vndCustomFilePath, vndOriginFilePath, vbLf, "")
    End Function

End Module
