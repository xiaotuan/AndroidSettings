Module MyProjects

    Public Function GetProjects() As ArrayList
        Dim Projects As New ArrayList()

        ' 纳斯达 395 项目
        Dim CC769Project As New ProjectInfo()
        CC769Project.ProjectId = "769"
        CC769Project.AndroidVersion = "Android 13"
        CC769Project.ProjectPath = ""
        CC769Project.PublicDirName = "tb8768p1_64_bsp"
        CC769Project.MssiDirName = "mssi_t_64_cn_wifi"
        CC769Project.DriveDirName = "M863YAR310_CC_769_WIFI"
        CC769Project.CustomDirName = "M863YAR310_CC_769_WIFI-MMI"
        CC769Project.Gms = 1
        CC769Project.Go = 2
        CC769Project.ChiperMaker = "MTK"
        CC769Project.ChiperModel = "MT8768"
        Projects.Add(CC769Project)

        ' 纳斯达 395 项目
        Dim CC768Project As New ProjectInfo()
        CC768Project.ProjectId = "768"
        CC768Project.AndroidVersion = "Android 13"
        CC768Project.ProjectPath = ""
        CC768Project.PublicDirName = "tb8768p1_64_bsp"
        CC768Project.MssiDirName = "mssi_t_64_cn_wifi"
        CC768Project.DriveDirName = "M863YAR310_CC_768_WIFI"
        CC768Project.CustomDirName = "M863YAR310_CC_768_WIFI-MMI"
        CC768Project.Gms = 1
        CC768Project.Go = 2
        CC768Project.ChiperMaker = "MTK"
        CC768Project.ChiperModel = "MT8768"
        Projects.Add(CC768Project)

        ' 优米 775 项目
        Dim YM775Project As New ProjectInfo()
        YM775Project.ProjectId = "775"
        YM775Project.AndroidVersion = "Android 13"
        YM775Project.ProjectPath = ""
        YM775Project.PublicDirName = "tb8766p1_64_bsp"
        YM775Project.MssiDirName = "mssi_t_64_cn"
        YM775Project.DriveDirName = "M869YCR100_YM_775"
        YM775Project.CustomDirName = "M869YCR100_YM_775-MMI"
        YM775Project.Gms = 1
        YM775Project.Go = 0
        YM775Project.ChiperMaker = "MTK"
        YM775Project.ChiperModel = "MT8766"
        Projects.Add(YM775Project)

        ' 纳斯达 395 项目
        Dim NSD395Project As New ProjectInfo()
        NSD395Project.ProjectId = "395"
        NSD395Project.AndroidVersion = "Android 12"
        NSD395Project.ProjectPath = ""
        NSD395Project.PublicDirName = "tb8788p1_64_bsp_k419"
        NSD395Project.MssiDirName = ""
        NSD395Project.DriveDirName = "M868B_NSD_395_WIFI"
        NSD395Project.CustomDirName = "M868B_NSD_395_WIFI-MMI"
        NSD395Project.Gms = 1
        NSD395Project.Go = 0
        NSD395Project.ChiperMaker = "MTK"
        NSD395Project.ChiperModel = "MT8788"
        Projects.Add(NSD395Project)

        ' 启昌智能 511 项目
        Dim QCZN511Project As New ProjectInfo()
        QCZN511Project.ProjectId = "511"
        QCZN511Project.AndroidVersion = "Android 13"
        QCZN511Project.ProjectPath = ""
        QCZN511Project.PublicDirName = "tb8788p1_64_bsp_k419"
        QCZN511Project.MssiDirName = "mssi_t_64_cn"
        QCZN511Project.DriveDirName = "M102BS_QCZN_511"
        QCZN511Project.CustomDirName = "M102BS_QCZN_511-MMI"
        QCZN511Project.Gms = 1
        QCZN511Project.Go = 0
        QCZN511Project.ChiperMaker = "MTK"
        QCZN511Project.ChiperModel = "MT8788"
        Projects.Add(QCZN511Project)

        ' 铭优 657 项目
        Dim MY657Project As New ProjectInfo()
        MY657Project.ProjectId = "657"
        MY657Project.AndroidVersion = "Android 13"
        MY657Project.ProjectPath = ""
        MY657Project.PublicDirName = "tb8781p1_64"
        MY657Project.MssiDirName = "mssi_t_64_cn_armv82"
        MY657Project.DriveDirName = "M100TB_MY_657"
        MY657Project.CustomDirName = "M100TB_MY_657-MMI"
        MY657Project.Gms = 1
        MY657Project.Go = 0
        MY657Project.ChiperMaker = "MTK"
        MY657Project.ChiperModel = "MT8781"
        Projects.Add(MY657Project)

        ' 新基德 645 项目
        Dim XJD645Project As New ProjectInfo()
        XJD645Project.ProjectId = "645"
        XJD645Project.AndroidVersion = "Android 13"
        XJD645Project.ProjectPath = ""
        XJD645Project.PublicDirName = "tb8766p1_64_bsp"
        XJD645Project.MssiDirName = "mssi_t_64_cn"
        XJD645Project.DriveDirName = "M863YAR310_XJD_645"
        XJD645Project.CustomDirName = "M863YAR310_XJD_645-MMI"
        XJD645Project.Gms = 1
        XJD645Project.Go = 0
        XJD645Project.ChiperMaker = "MTK"
        XJD645Project.ChiperModel = "MT6761"
        Projects.Add(XJD645Project)

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

        ' 长城 M10-11 PAPAP 项目
        Dim CC475Project As New ProjectInfo()
        CC475Project.ProjectId = "475"
        CC475Project.AndroidVersion = "Android 12"
        CC475Project.ProjectPath = ""
        CC475Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC475Project.MssiDirName = ""
        CC475Project.DriveDirName = "M100BS_CC_475_WIFI"
        CC475Project.CustomDirName = "M100BS_CC_475_WIFI-MMI"
        CC475Project.Gms = 1
        CC475Project.Go = 0
        CC475Project.ChiperMaker = "MTK"
        CC475Project.ChiperModel = "MT8183"
        Projects.Add(CC475Project)

        ' 长城 598 项目
        Dim CC598Project As New ProjectInfo()
        CC598Project.ProjectId = "598"
        CC598Project.AndroidVersion = "Android 12"
        CC598Project.ProjectPath = ""
        CC598Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC598Project.MssiDirName = ""
        CC598Project.DriveDirName = "M100BS_CC_598"
        CC598Project.CustomDirName = "M100BS_CC_598-MMI"
        CC598Project.Gms = 1
        CC598Project.Go = 0
        CC598Project.ChiperMaker = "MTK"
        CC598Project.ChiperModel = "MT8183"
        Projects.Add(CC598Project)

        ' 长城 600 项目
        Dim CC600Project As New ProjectInfo()
        CC600Project.ProjectId = "600"
        CC600Project.AndroidVersion = "Android 12"
        CC600Project.ProjectPath = ""
        CC600Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC600Project.MssiDirName = ""
        CC600Project.DriveDirName = "M100BS_CC_600_WIFI"
        CC600Project.CustomDirName = "M100BS_CC_600_WIFI-MMI"
        CC600Project.Gms = 1
        CC600Project.Go = 0
        CC600Project.ChiperMaker = "MTK"
        CC600Project.ChiperModel = "MT8183"
        Projects.Add(CC600Project)

        ' 长城 671 项目
        Dim CC671Project As New ProjectInfo()
        CC671Project.ProjectId = "671"
        CC671Project.AndroidVersion = "Android 12"
        CC671Project.ProjectPath = ""
        CC671Project.PublicDirName = "tb8788p1_64_bsp_k419"
        CC671Project.MssiDirName = ""
        CC671Project.DriveDirName = "M100BS_CC_671"
        CC671Project.CustomDirName = "M100BS_CC_671-MMI"
        CC671Project.Gms = 1
        CC671Project.Go = 0
        CC671Project.ChiperMaker = "MTK"
        CC671Project.ChiperModel = "MT8183"
        Projects.Add(CC671Project)

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
