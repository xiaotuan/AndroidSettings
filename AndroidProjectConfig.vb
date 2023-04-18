Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Devices

Public Class AndroidSettingsForm

    Public MyProjectInfo As ProjectInfo = New ProjectInfo()

    Private Sub androidSettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitProjectIdComboBox()
        InitProjectPathComboBox()
        InitLanguageComboBox()
        InitTimezoneComboBox()
    End Sub

    Private Sub InitProjectIdComboBox()
        For Each Project As ProjectInfo In MyProjects.GetProjects()
            CBProjectId.Items.Add(Project.ProjectId)
        Next
    End Sub

    Private Sub InitProjectPathComboBox()
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work1\mtk\13\mt8766_t\A\mtk_sp_t0")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work1\mtk\13\mt8766_t\B\mtk_sp_t0")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work2\mtk\13\mt8766_t\A\mtk_sp_t0")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work2\mtk\13\mt8766_t\B\mtk_sp_t0")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work2\mtk\12\mt8766\A\mt8766_s")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work1\mtk\12\mt8766_s\A\mt8766_s")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work1\mtk\12\mt8766_s\B\mt8766_s")
        CbProjectPath.Items.Add("\\192.168.0.38\qintuanye\work2\mtk\11\mt8766_r\A\mt8766_r")
    End Sub

    Private Sub InitLanguageComboBox()
        cbLanguage.Items.Add("英语（美国）-en_US")
        cbLanguage.Items.Add("简体中文-zh_CN")
        cbLanguage.Items.Add("繁体中文（台湾）-zh_TW")
        cbLanguage.Items.Add("西班牙语-es_ES")
        cbLanguage.Items.Add("葡萄牙语（巴西）-pt_BR")
        cbLanguage.Items.Add("俄语-ru_RU")
        cbLanguage.Items.Add("法语-fr_FR")
        cbLanguage.Items.Add("德语-de_DE")
        cbLanguage.Items.Add("土耳其语-tr_TR")
        cbLanguage.Items.Add("越南语-vi_VN")
        cbLanguage.Items.Add("马来西亚语-ms_MY")
        cbLanguage.Items.Add("印度尼西亚语-in_ID")
        cbLanguage.Items.Add("泰语-th_TH")
        cbLanguage.Items.Add("意大利语-it_IT")
        cbLanguage.Items.Add("阿拉伯语-ar_EG")
        cbLanguage.Items.Add("印地语-hi_IN")
        cbLanguage.Items.Add("孟加拉语（印度）-bn_IN")
        cbLanguage.Items.Add("巴基斯坦语-ur_PK")
        cbLanguage.Items.Add("波斯语-fa_IR")
        cbLanguage.Items.Add("葡萄牙语-pt_PT")
        cbLanguage.Items.Add("荷兰语-nl_NL")
        cbLanguage.Items.Add("希腊语-el_GR")
        cbLanguage.Items.Add("匈牙利语-hu_HU")
        cbLanguage.Items.Add("菲利宾语-tl_PH")
        cbLanguage.Items.Add("罗马尼亚语-ro_RO")
        cbLanguage.Items.Add("捷克语-cs_CZ")
        cbLanguage.Items.Add("朝鲜语-ko_KR")
        cbLanguage.Items.Add("柬埔寨语-km_KH")
        cbLanguage.Items.Add("希伯来语-iw_IL")
        cbLanguage.Items.Add("缅甸语-my_MM")
        cbLanguage.Items.Add("波兰语-pl_PL")
        cbLanguage.Items.Add("西班牙语（美国）-es_US")
        cbLanguage.Items.Add("保加利亚语-bg_BG")
        cbLanguage.Items.Add("克罗地亚语-hr_HR")
        cbLanguage.Items.Add("拉脱维亚语-lv_LV")
        cbLanguage.Items.Add("立陶宛语-lt_LT")
        cbLanguage.Items.Add("斯洛伐克语-sk_SK")
        cbLanguage.Items.Add("乌克兰语-uk_UA")
        cbLanguage.Items.Add("德语（奥地利）-de_AT")
        cbLanguage.Items.Add("丹麦语-da_DK")
        cbLanguage.Items.Add("芬兰语-fi_FI")
        cbLanguage.Items.Add("挪威语-nb_NO")
        cbLanguage.Items.Add("瑞典语-sv_SE")
        cbLanguage.Items.Add("英语（英国）-en_GB")
        cbLanguage.Items.Add("亚美尼亚语-hy_AM")
        cbLanguage.Items.Add("繁体中文（香港）-zh_HK")
        cbLanguage.Items.Add("爱沙尼亚语-et_EE")
        cbLanguage.Items.Add("日语-ja_JP")
        cbLanguage.Items.Add("哈萨克语-kk_KZ")
        cbLanguage.Items.Add("塞尔维亚语-sr_RS")
        cbLanguage.Items.Add("斯洛文尼亚语-sl_SI")
        cbLanguage.Items.Add("加泰隆语（西班牙）-ca_ES")
    End Sub

    Private Sub InitTimezoneComboBox()
        cbTimezone.Items.Add("北京/中国-Asia/Shanghai")
        cbTimezone.Items.Add("香港/中国-Asia/Hong_Kong")
        cbTimezone.Items.Add("台北时间 (台北)-Asia/Taipei")
        cbTimezone.Items.Add("首尔-Asia/Seoul")
        cbTimezone.Items.Add("东京/日本-Asia/Tokyo")
        cbTimezone.Items.Add("丹佛/美国山区-America/Denver")
        cbTimezone.Items.Add("哥斯达黎加/美国中部-America/Costa_Rica")
        cbTimezone.Items.Add("芝加哥/美国中部-America/Chicago")
        cbTimezone.Items.Add("墨西哥城/美国中部-America/Mexico_City")
        cbTimezone.Items.Add("里贾纳/美国中部-America/Regina")
        cbTimezone.Items.Add("马朱罗-Pacific/Majuro")
        cbTimezone.Items.Add("中途岛-Pacific/Midway")
        cbTimezone.Items.Add("檀香山-Pacific/Honolulu")
        cbTimezone.Items.Add("安克雷奇-America/Anchorage")
        cbTimezone.Items.Add("洛杉矶/美国太平洋-America/Los_Angeles")
        cbTimezone.Items.Add("提华纳/美国太平洋-America/Tijuana")
        cbTimezone.Items.Add("凤凰城美国山区-America/Phoenix")
        cbTimezone.Items.Add("奇瓦瓦-America/Chihuahua")
        cbTimezone.Items.Add("波哥大/哥伦比亚-America/Bogota")
        cbTimezone.Items.Add("纽约/美国东部-America/New_York")
        cbTimezone.Items.Add("加拉加斯/委内瑞拉-America/Caracas")
        cbTimezone.Items.Add("巴巴多斯/大西洋-America/Barbados")
        cbTimezone.Items.Add("马瑙斯/亚马逊-America/Manaus")
        cbTimezone.Items.Add("圣地亚哥-America/Santiago")
        cbTimezone.Items.Add("圣约翰/纽芬兰-America/St_Johns")
        cbTimezone.Items.Add("圣保罗-America/Sao_Paulo")
        cbTimezone.Items.Add("布宜诺斯艾利斯-America/Argentina/Buenos_Aires")
        cbTimezone.Items.Add("戈特霍布-America/Godthab")
        cbTimezone.Items.Add("蒙得维的亚/乌拉圭-America/Montevideo")
        cbTimezone.Items.Add("南乔治亚-Atlantic/South_Georgia")
        cbTimezone.Items.Add("亚述尔群岛-Atlantic/Azores")
        cbTimezone.Items.Add("佛得角-Atlantic/Cape_Verde")
        cbTimezone.Items.Add("卡萨布兰卡-Africa/Casablanca")
        cbTimezone.Items.Add("伦敦/格林尼治-Europe/London")
        cbTimezone.Items.Add("阿姆斯特丹/中欧-Europe/Amsterdam")
        cbTimezone.Items.Add("贝尔格莱德/中欧-Europe/Belgrade")
        cbTimezone.Items.Add("布鲁塞尔/中欧-Europe/Brussels")
        cbTimezone.Items.Add("萨拉热窝/中欧-Europe/Sarajevo")
        cbTimezone.Items.Add("温得和克-Africa/Windhoek")
        cbTimezone.Items.Add("布拉扎维/西部非洲-Africa/Brazzaville")
        cbTimezone.Items.Add("安曼/东欧-Asia/Amman")
        cbTimezone.Items.Add("雅典/东欧-Europe/Athens")
        cbTimezone.Items.Add("贝鲁特/东欧-Asia/Beirut")
        cbTimezone.Items.Add("开罗/东欧-Africa/Cairo")
        cbTimezone.Items.Add("赫尔辛基/东欧-Europe/Helsinki")
        cbTimezone.Items.Add("耶路撒冷/以色列-Asia/Jerusalem")
        cbTimezone.Items.Add("明斯克-Europe/Minsk")
        cbTimezone.Items.Add("哈拉雷/中部非洲-Africa/Harare")
        cbTimezone.Items.Add("巴格达-Asia/Baghdad")
        cbTimezone.Items.Add("莫斯科-Europe/Moscow")
        cbTimezone.Items.Add("科威特-Asia/Kuwait")
        cbTimezone.Items.Add("内罗毕/东部非洲-Africa/Nairobi")
        cbTimezone.Items.Add("德黑兰/伊朗-Asia/Tehran")
        cbTimezone.Items.Add("巴库-Asia/Baku")
        cbTimezone.Items.Add("第比利斯-Asia/Tbilisi")
        cbTimezone.Items.Add("埃里温-Asia/Yerevan")
        cbTimezone.Items.Add("迪拜-Asia/Dubai")
        cbTimezone.Items.Add("喀布尔/阿富汗-Asia/Kabul")
        cbTimezone.Items.Add("卡拉奇-Asia/Karachi")
        cbTimezone.Items.Add("乌拉尔-Asia/Oral")
        cbTimezone.Items.Add("叶卡捷林堡-Asia/Yekaterinburg")
        cbTimezone.Items.Add("加尔各答-Asia/Calcutta")
        cbTimezone.Items.Add("科伦坡-Asia/Colombo")
        cbTimezone.Items.Add("加德满都/尼泊尔-Asia/Katmandu")
        cbTimezone.Items.Add("阿拉木图-Asia/Almaty")
        cbTimezone.Items.Add("仰光/缅甸-Asia/Rangoon")
        cbTimezone.Items.Add("克拉斯诺亚尔斯克-Asia/Krasnoyarsk")
        cbTimezone.Items.Add("曼谷-Asia/Bangkok")
        cbTimezone.Items.Add("伊尔库茨克-Asia/Irkutsk")
        cbTimezone.Items.Add("吉隆坡-Asia/Kuala_Lumpur")
        cbTimezone.Items.Add("佩思-Australia/Perth")
        cbTimezone.Items.Add("雅库茨克-Asia/Yakutsk")
        cbTimezone.Items.Add("阿德莱德-Australia/Adelaide")
        cbTimezone.Items.Add("达尔文-Australia/Darwin")
        cbTimezone.Items.Add("布里斯班-Australia/Brisbane")
        cbTimezone.Items.Add("霍巴特-Australia/Hobart")
        cbTimezone.Items.Add("悉尼-Australia/Sydney")
        cbTimezone.Items.Add("符拉迪沃斯托克/海参崴-Asia/Vladivostok")
        cbTimezone.Items.Add("关岛-Pacific/Guam")
        cbTimezone.Items.Add("马加丹-Asia/Magadan")
        cbTimezone.Items.Add("奥克兰-Pacific/Auckland")
        cbTimezone.Items.Add("斐济-Pacific/Fiji")
        cbTimezone.Items.Add("东加塔布-Pacific/Tongatapu")
    End Sub

    Private Sub CBProjectId_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CBProjectId.SelectedIndexChanged
        Dim ProjectId As String
        ProjectId = sender.SelectedItem
        Debug.WriteLine("Select: " + ProjectId)
        ProjectConfigControler.UpdateAndroidProjectConfigFromProjectId(Me, ProjectId)
        MyProjectInfo.ProjectId = ProjectId
    End Sub

    Private Sub CBProjectId_TextChanged(sender As ComboBox, e As EventArgs) Handles CBProjectId.TextChanged
        ProjectConfigControler.UpdateAndroidProjectConfigFromProjectId(Me, sender.Text)
        MyProjectInfo.ProjectId = sender.Text
    End Sub

    Private Sub BtSelectProjectPath_Click(sender As Object, e As EventArgs) Handles BtSelectProjectPath.Click
        If FbdSelectPath.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
            CbProjectPath.Text = FbdSelectPath.SelectedPath
            MyProjectInfo.ProjectPath = FbdSelectPath.SelectedPath
        End If
    End Sub

    Private Sub CbAndroidVersin_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbAndroidVersin.SelectedIndexChanged
        MyProjectInfo.AndroidVersion = sender.SelectedItem
    End Sub

    Private Sub CbAndroidVersin_TextChanged(sender As ComboBox, e As EventArgs) Handles CbAndroidVersin.TextChanged
        MyProjectInfo.AndroidVersion = sender.Text
    End Sub

    Private Sub TbPublicName_TextChanged(sender As TextBox, e As EventArgs) Handles TbPublicName.TextChanged
        MyProjectInfo.PublicDirName = sender.Text
    End Sub

    Private Sub TbMssiName_TextChanged(sender As TextBox, e As EventArgs) Handles TbMssiName.TextChanged
        MyProjectInfo.MssiDirName = sender.Text
    End Sub

    Private Sub TbDriveName_TextChanged(sender As TextBox, e As EventArgs) Handles TbDriveName.TextChanged
        MyProjectInfo.DriveDirName = sender.Text
    End Sub

    Private Sub TbCustomName_TextChanged(sender As TextBox, e As EventArgs) Handles TbCustomName.TextChanged
        MyProjectInfo.CustomDirName = sender.Text
    End Sub

    Private Sub GmsCheckedChanged(sender As RadioButton, e As EventArgs) Handles RbNotGms.CheckedChanged, RbGms.CheckedChanged
        If RbGms.Checked Then
            MyProjectInfo.Gms = 1
        Else
            MyProjectInfo.Gms = 0
        End If
    End Sub

    Private Sub GoCheckedChanged(sender As Object, e As EventArgs) Handles RbNotGo.CheckedChanged, RbOneGbGo.CheckedChanged, RbTwoGbGo.CheckedChanged
        If RbOneGbGo.Checked Then
            MyProjectInfo.Go = 1
        ElseIf RbTwoGbGo.Checked Then
            MyProjectInfo.Go = 2
        Else
            MyProjectInfo.Go = 0
        End If
    End Sub

    Private Sub CbChiperMaker_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbChiperMaker.SelectedIndexChanged
        MyProjectInfo.ChiperMaker = sender.SelectedItem
    End Sub

    Private Sub CbChiperModel_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbChiperModel.SelectedIndexChanged
        MyProjectInfo.ChiperModel = sender.SelectedItem
    End Sub

    Private Sub CbChiperMaker_TextChanged(sender As ComboBox, e As EventArgs) Handles CbChiperMaker.TextChanged
        MyProjectInfo.ChiperMaker = sender.Text
    End Sub

    Private Sub CbChiperModel_TextChanged(sender As ComboBox, e As EventArgs) Handles CbChiperModel.TextChanged
        MyProjectInfo.ChiperModel = sender.Text
    End Sub

    Private Sub btVersion_Click(sender As Object, e As EventArgs) Handles btVersion.Click

        If tbVersion.Text.Trim().Length > 0 Then
            VersionController.SetVersion(Me, tbVersion.Text)
        Else
            MessageBox.Show("版本号不能为空！")
        End If
    End Sub

    Private Sub tcAndroidSettings_SelectedIndexChanged(sender As TabControl, e As EventArgs) Handles tcAndroidSettings.SelectedIndexChanged
        If sender.SelectedTab.Name.Equals("tpVersion") Then
            VersionController.UpdateVersionInfo(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpFingerprint") Then
            FingerprintController.UpdateFingerprintInfo(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpProperty") Then
            PropertyController.UpdatePropertyInfo(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpWifi") Then
            WifiController.UpdateWifiInfo(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpBluetooth") Then
            BluetoothController.UpdateBluetoothInfo(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpLanguage") Then
            LanguageController.UpdateLanguage(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpTimezone") Then
            TimezoneController.UpdateTimezoneInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpLogo") Then
            LogoController.UpdateLogo(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpWallpaper") Then
            WallpaperController.UpdateWallpaperInfos(Me)
        End If
    End Sub

    Private Sub btRandom_Click(sender As Object, e As EventArgs) Handles btRandom.Click
        Dim time As Long = DateDiff("s", "1970-1-1 0:0:0", DateTime.UtcNow)
        tbFingerprint.Text = Str(time).Trim
    End Sub

    Private Sub btFingerprintSet_Click(sender As Object, e As EventArgs) Handles btFingerprintSet.Click
        FingerprintController.SetFingerprint(Me, tbFingerprint.Text)
    End Sub

    Private Sub btPropertySetting_Click(sender As Object, e As EventArgs) Handles btPropertySetting.Click
        PropertyController.SetProperties(Me)
    End Sub

    Private Sub btWifiSetting_Click(sender As Object, e As EventArgs) Handles btWifiSetting.Click
        WifiController.SetWifiInfos(Me)
    End Sub

    Private Sub CbProjectPath_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbProjectPath.SelectedIndexChanged
        MyProjectInfo.ProjectPath = sender.Text
    End Sub

    Private Sub CbProjectPath_TextChanged(sender As Object, e As EventArgs) Handles CbProjectPath.TextChanged
        MyProjectInfo.ProjectPath = sender.Text
    End Sub

    Private Sub btBluetoothSetting_Click(sender As Object, e As EventArgs) Handles btBluetoothSetting.Click
        BluetoothController.SetBluetoothInfos(Me)
    End Sub

    Private Sub btLanguageSetting_Click(sender As Object, e As EventArgs) Handles btLanguageSetting.Click
        LanguageController.SetLanguage(Me)
    End Sub

    Private Sub btTimezoneSetting_Click(sender As Object, e As EventArgs) Handles btTimezoneSetting.Click
        TimezoneController.setTimezoneInfos(Me)
    End Sub

    Private Sub bLogo_Click(sender As Object, e As EventArgs) Handles bLogo.Click
        ofdSelectFile.Title = "选择 Logo 图片"
        ofdSelectFile.Filter = "Windows Bitmaps|*.BMP"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbLogo.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btLogoSetting_Click(sender As Object, e As EventArgs) Handles btLogoSetting.Click
        LogoController.SetLogo(Me)
    End Sub

    Private Sub btWallpaper_Click(sender As Object, e As EventArgs) Handles btWallpaper.Click
        ofdSelectFile.Title = "选择壁纸图片"
        ofdSelectFile.Filter = "PNG|*.png"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbWallpaper.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btInserWallpaper_Click(sender As Object, e As EventArgs) Handles btInserWallpaper.Click
        If FbdSelectPath.ShowDialog() <> DialogResult.Cancel Then
            tbInsertWallpaper.Text = FbdSelectPath.SelectedPath
        End If
    End Sub

    Private Sub btWallpaperSetting_Click(sender As Object, e As EventArgs) Handles btWallpaperSetting.Click
        WallpaperController.SetWallpaperInfos(Me)
    End Sub
End Class
