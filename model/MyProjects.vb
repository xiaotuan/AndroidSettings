Module MyProjects

    Public Function GetProjects() As ArrayList
        Dim Projects As New ArrayList()

        ' 优米 536 项目
        Dim YM536Project As New ProjectInfo()
        YM536Project.ProjectId = "536"
        YM536Project.AndroidVersion = "Android 13"
        YM536Project.ProjectPath = ""
        YM536Project.PublicDirName = "tb8766p1_64_bsp"
        YM536Project.MssiDirName = "mssi_t_64_cn"
        YM536Project.DriveDirName = "M869YCR100_YM_536"
        YM536Project.CustomDirName = "M869YCR100_YM_536-MMI"
        YM536Project.Gms = 1
        YM536Project.Go = 0
        YM536Project.ChiperMaker = "MTK"
        YM536Project.ChiperModel = "MT6761"
        Projects.Add(YM536Project)

        ' 优米美版中性 582 项目
        Dim YM582Project As New ProjectInfo()
        YM582Project.ProjectId = "582"
        YM582Project.AndroidVersion = "Android 13"
        YM582Project.ProjectPath = ""
        YM582Project.PublicDirName = "tb8766p1_64_bsp"
        YM582Project.MssiDirName = "mssi_t_64_cn"
        YM582Project.DriveDirName = "M869YCR100_YM_582"
        YM582Project.CustomDirName = "M869YCR100_YM_582-MMI"
        YM582Project.Gms = 1
        YM582Project.Go = 0
        YM582Project.ChiperMaker = "MTK"
        YM582Project.ChiperModel = "MT6761"
        Projects.Add(YM582Project)

        ' 优米海外 537 项目（使用旧 modem ）
        Dim YM537Project As New ProjectInfo()
        YM537Project.ProjectId = "537"
        YM537Project.AndroidVersion = "Android 13"
        YM537Project.ProjectPath = ""
        YM537Project.PublicDirName = "tb8766p1_64_bsp"
        YM537Project.MssiDirName = "mssi_t_64_cn_datasms"
        YM537Project.DriveDirName = "M869YCR100_YM_537"
        YM537Project.CustomDirName = "M869YCR100_YM_537-MMI"
        YM537Project.Gms = 1
        YM537Project.Go = 0
        YM537Project.ChiperMaker = "MTK"
        YM537Project.ChiperModel = "MT6761"
        Projects.Add(YM537Project)

        ' 优米海外 546 项目（使用新 modem ）
        Dim YM546Project As New ProjectInfo()
        YM546Project.ProjectId = "546"
        YM546Project.AndroidVersion = "Android 13"
        YM546Project.ProjectPath = ""
        YM546Project.PublicDirName = "tb8766p1_64_bsp"
        YM546Project.MssiDirName = "mssi_t_64_cn_datasms"
        YM546Project.DriveDirName = "M869YCR100_YM_546"
        YM546Project.CustomDirName = "M869YCR100_YM_546-MMI"
        YM546Project.Gms = 1
        YM546Project.Go = 0
        YM546Project.ChiperMaker = "MTK"
        YM546Project.ChiperModel = "MT6761"
        Projects.Add(YM546Project)

        ' 长城 P10-11 PAPAP 项目
        Dim CC261Project As New ProjectInfo()
        CC261Project.ProjectId = "261"
        CC261Project.AndroidVersion = "Android 12"
        CC261Project.ProjectPath = ""
        CC261Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC261Project.MssiDirName = ""
        CC261Project.DriveDirName = "M100BS_CC_261"
        CC261Project.CustomDirName = "M100BS_CC_261-MMI"
        CC261Project.Gms = 1
        CC261Project.Go = 0
        CC261Project.ChiperMaker = "MTK"
        CC261Project.ChiperModel = "MT8183"
        Projects.Add(CC261Project)

        ' 长城 P10-11 EEA 项目
        Dim CC403Project As New ProjectInfo()
        CC403Project.ProjectId = "403"
        CC403Project.AndroidVersion = "Android 12"
        CC403Project.ProjectPath = ""
        CC403Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC403Project.MssiDirName = ""
        CC403Project.DriveDirName = "M100BS_CC_403"
        CC403Project.CustomDirName = "M100BS_CC_403-MMI"
        CC403Project.Gms = 1
        CC403Project.Go = 0
        CC403Project.ChiperMaker = "MTK"
        CC403Project.ChiperModel = "MT8183"
        Projects.Add(CC403Project)

        ' 长城 P10-11 TR 项目
        Dim CC577Project As New ProjectInfo()
        CC577Project.ProjectId = "577"
        CC577Project.AndroidVersion = "Android 12"
        CC577Project.ProjectPath = ""
        CC577Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC577Project.MssiDirName = ""
        CC577Project.DriveDirName = "M100BS_CC_577"
        CC577Project.CustomDirName = "M100BS_CC_577-MMI"
        CC577Project.Gms = 1
        CC577Project.Go = 0
        CC577Project.ChiperMaker = "MTK"
        CC577Project.ChiperModel = "MT8183"
        Projects.Add(CC577Project)

        ' 长城 M10-11 EEA 项目
        Dim CC474Project As New ProjectInfo()
        CC474Project.ProjectId = "474"
        CC474Project.AndroidVersion = "Android 12"
        CC474Project.ProjectPath = ""
        CC474Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC474Project.MssiDirName = ""
        CC474Project.DriveDirName = "M100BS_CC_474_WIFI"
        CC474Project.CustomDirName = "M100BS_CC_474_WIFI-MMI"
        CC474Project.Gms = 1
        CC474Project.Go = 0
        CC474Project.ChiperMaker = "MTK"
        CC474Project.ChiperModel = "MT8183"
        Projects.Add(CC474Project)

        ' 格瑞特亚 134 项目
        Dim GRTY134Project As New ProjectInfo()
        GRTY134Project.ProjectId = "134"
        GRTY134Project.AndroidVersion = "Android 12"
        GRTY134Project.ProjectPath = ""
        GRTY134Project.PublicDirName = "tb8765ap1_bsp_1g_k419"
        GRTY134Project.MssiDirName = ""
        GRTY134Project.DriveDirName = "M863U_GRTY_134"
        GRTY134Project.CustomDirName = "M863U_GRTY_134-E8765-MMI"
        GRTY134Project.Gms = 1
        GRTY134Project.Go = 0
        GRTY134Project.ChiperMaker = "MTK"
        GRTY134Project.ChiperModel = "MT6739"
        Projects.Add(GRTY134Project)

        ' 赛博宇华 012 项目（带 APK）
        Dim SBYH12Project As New ProjectInfo()
        SBYH12Project.ProjectId = "12"
        SBYH12Project.AndroidVersion = "Android 11"
        SBYH12Project.ProjectPath = ""
        SBYH12Project.PublicDirName = "m863u_bsp_64"
        SBYH12Project.MssiDirName = ""
        SBYH12Project.DriveDirName = "m863ur200_64-SBYH_A8009_MasstelTab8Edu"
        SBYH12Project.CustomDirName = "m863ur200_64-SBYH_A8009_MasstelTab8Edu-apk-MMI"
        SBYH12Project.Gms = 1
        SBYH12Project.Go = 0
        SBYH12Project.ChiperMaker = "MTK"
        SBYH12Project.ChiperModel = "MT6739"
        Projects.Add(SBYH12Project)

        Return Projects
    End Function

End Module
