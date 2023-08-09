Public Class ProjectInfo

    ' 工程禅道号 ID, 例如 546、139
    Public ProjectId As String
    ' Android 版本号，例如 Android 12、Android 13
    Public AndroidVersion As String
    ' 工程代码根目录路径
    Public ProjectPath As String
    ' 公版目录名称，例如 tb8766p1_64_bsp
    Public PublicDirName As String
    ' Mssi 目录名称，例如 mssi_t_64_cn
    Public MssiDirName As String
    ' 驱动目录名称，例如 M869YCR100_YM_536
    Public DriveDirName As String
    ' 客制化目录名称，例如 M869YCR100_YM_536-MMI
    Public CustomDirName As String
    ' GMS 信息，例如 非 GMS 项目的值为 0，GMS 项目为 1
    Public Gms As Integer
    ' GO GMS 信息，例如 非 GO 项目的值为 0，1GB GO 项目的值为 1,2GB GO 项目的值为 2
    Public Go As Integer
    ' 芯片厂商，例如 MediaTek 的值为 MTK，展讯的值为 unisoc
    Public ChiperMaker As String
    ' 芯片型号，例如 MT8766
    Public ChiperModel As String

    Public Overrides Function ToString() As String
        Return "Project [ ProjectId: " & ProjectId & ", AndroidVersion: " & AndroidVersion &
            ", ProjectPath: " & ProjectPath & ", PublicDirName: " & PublicDirName & ", MssiDirName: " &
            MssiDirName & ", DriveDirName: " & DriveDirName & ", CustomDirName: " & CustomDirName & ", Gms: " &
            Gms & ", Go: " & Gms & ", ChiperMaker: " & ChiperMaker & ", ChiperModel: " & ChiperModel
    End Function

End Class
