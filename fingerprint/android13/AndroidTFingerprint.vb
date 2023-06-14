' AndroidTFingerprint 模块是 Android 13 系统修改 fingerprint 的实现模块
' Android 13 系统修改 fingerprint 方法如下：
' 1. 修改 sys\device\mediatek\system\common\BoardConfig.mk 文件中 WEIBU_BUILD_NUMBER 宏的值
' 2. 修改 vnd\build\make\core\weibu_config.mk 文件中 WEIBU_BUILD_NUMBER 宏的值

Module AndroidTFingerprint

    ' 获取 fingerprint 值
    '
    ' info： 工程信息
    '
    ' return：获取成功返回 fingerprint，否则返回空字符串
    Public Function GetFingerprint(ByRef info As ProjectInfo) As String
        Dim customFilePath As String = info.ProjectPath + "\sys\weibu\" + info.MssiDirName + "\" + info.CustomDirName + "\alps\device\mediatek\system\common\BoardConfig.mk"
        Return FileUtils.GetMakeFileValue("WEIBU_BUILD_NUMBER", ":=", Nothing, customFilePath)
    End Function

    ' 设置 fingerprint
    '
    ' info：工程信息
    ' fp：要设置的 fingerprint
    '
    ' return：设置成功返回 True，否则返回 False
    Public Function SetFingerprint(ByRef info As ProjectInfo, ByVal fp As String) As Boolean
        Dim sysOriginFingerprintPath As String = info.ProjectPath + "\sys\device\mediatek\system\common\BoardConfig.mk"
        Dim sysCustomFingerprintPath As String = info.ProjectPath + "\sys\weibu\" + info.MssiDirName + "\" + info.CustomDirName + "\alps\device\mediatek\system\common\BoardConfig.mk"

        Dim vndOriginFingerprintPath As String = info.ProjectPath + "\vnd\build\make\core\weibu_config.mk"
        Dim vndCustomFingerprintPath As String = info.ProjectPath + "\vnd\weibu\" + info.PublicDirName + "\" + info.DriveDirName + "\alps\build\make\core\weibu_config.mk"

        Dim vndOriginBuildIdPath As String = info.ProjectPath + "\vnd\build\make\core\build_id.mk"
        Dim vndCustomBuildIdPath As String = info.ProjectPath + "\vnd\weibu\" + info.PublicDirName + "\" + info.DriveDirName + "\alps\build\make\core\build_id.mk"

        Dim vndOriginSyspropPath As String = info.ProjectPath + "\vnd\build\make\core\sysprop.mk"
        Dim vndCustomSyspropPath As String = info.ProjectPath + "\vnd\weibu\" + info.PublicDirName + "\" + info.DriveDirName + "\alps\build\make\core\sysprop.mk"

        Return FileUtils.SetMakeFileValue("WEIBU_BUILD_NUMBER :=", "WEIBU_BUILD_NUMBER := " & fp, sysCustomFingerprintPath, sysOriginFingerprintPath, vbLf, "") And
            FileUtils.SetMakeFileValue("WEIBU_BUILD_NUMBER ?=", "WEIBU_BUILD_NUMBER ?= " & fp, vndCustomFingerprintPath, vndOriginFingerprintPath, vbLf, "") And
            FileUtils.SetMakeFileValue("BUILD_ID=", "BUILD_ID=TP1A.220624.014", vndCustomBuildIdPath, vndOriginBuildIdPath, vbLf, "") And
            FileUtils.SetMakeFileValue("BUILD_FINGERPRINT := $(PRODUCT_BRAND)/$(PRODUCT_SYSTEM_NAME)/$(PRODUCT_SYSTEM_DEVICE):", "BUILD_FINGERPRINT := $(PRODUCT_BRAND)/$(PRODUCT_SYSTEM_NAME)/$(PRODUCT_SYSTEM_DEVICE):13/$(BUILD_ID)/$(BF_BUILD_NUMBER):$(TARGET_BUILD_VARIANT)/$(BUILD_VERSION_TAGS)", vndCustomSyspropPath, vndOriginSyspropPath, vbLf, "")
    End Function

End Module
