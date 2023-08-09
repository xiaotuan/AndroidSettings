Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Devices

Public Class AndroidSettingsForm

    Public MyProjectInfo As ProjectInfo = New ProjectInfo()
    Public Projects As ArrayList = New ArrayList()
    Public Versions As ArrayList = New ArrayList()
    Public ProjectPaths As ArrayList = New ArrayList()
    Public PublicNames As Hashtable = New Hashtable()
    Public DriveNames As Hashtable = New Hashtable()
    Public MssiNames As Hashtable = New Hashtable()
    Public CustomNames As Hashtable = New Hashtable()
    Public ChiperMakers As ArrayList = New ArrayList()
    Public ChiperModels As Hashtable = New Hashtable()
    Public Languages As ArrayList = New ArrayList()
    Public Timezones As ArrayList = New ArrayList()

    Private Sub androidSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AndroidProjectInit.Init(Me)
        InitVersionComboBox()
        InitProjectIdComboBox()
        InitProjectPathComboBox()
        InitPublicNameComboBox()
        InitMssiNameComboBox()
        InitDriveNameComboBox()
        InitCustomNameComboBox()
        InitChiperMakerComboBox()
        InitChiperModelComboBox()
        InitLanguageComboBox()
        InitTimezoneComboBox()
    End Sub

    Private Sub InitVersionComboBox()
        CbAndroidVersion.Items.Clear()
        For Each androidVersion As String In Versions
            CbAndroidVersion.Items.Add(androidVersion)
        Next
    End Sub

    Private Sub InitProjectIdComboBox()
        For Each Project As ProjectInfo In Projects
            CBProjectId.Items.Add(Project.ProjectId)
        Next
    End Sub

    Private Sub InitProjectPathComboBox()
        CbProjectPath.Items.Clear()
        For Each path As String In ProjectPaths
            CbProjectPath.Items.Add(path)
        Next
    End Sub

    Public Sub InitPublicNameComboBox()
        CbPublicName.Items.Clear()
        Dim androidVersion = CbAndroidVersion.Text.Trim
        If Not IsEmptyText(androidVersion) Then
            If PublicNames.ContainsKey(androidVersion) Then
                For Each name As String In PublicNames(androidVersion)
                    CbPublicName.Items.Add(name)
                Next
            Else
                Debug.WriteLine("[AndroidProjectConfig] InitPublicNameComboBox=>" & androidVersion & " key isn't contain.")
            End If
        Else
            Debug.WriteLine("[AndroidProjectConfig] InitPublicNameComboBox=>Android version is empty.")
        End If
    End Sub

    Public Sub InitMssiNameComboBox()
        CbMssiName.Items.Clear()
        Dim androidVersion = CbAndroidVersion.Text.Trim
        If Not IsEmptyText(androidVersion) Then
            If MssiNames.ContainsKey(androidVersion) Then
                For Each name As String In MssiNames(androidVersion)
                    CbMssiName.Items.Add(name)
                Next
            Else
                Debug.WriteLine("[AndroidProjectConfig] InitMssiNameComboBox=>" & androidVersion & " key isn't contain.")
            End If
        Else
            Debug.WriteLine("[AndroidProjectConfig] InitMssiNameComboBox=>Android version is empty.")
        End If
    End Sub

    Public Sub InitDriveNameComboBox()
        CbDriveName.Items.Clear()
        Dim androidVersion = CbAndroidVersion.Text.Trim
        If Not IsEmptyText(androidVersion) Then
            If DriveNames.ContainsKey(androidVersion) Then
                Dim publicName = CbPublicName.Text.Trim
                If Not IsEmptyText(publicName) Then
                    Dim item As Hashtable = DriveNames(androidVersion)
                    If item.ContainsKey(publicName) Then
                        For Each name As String In item(publicName)
                            CbDriveName.Items.Add(name)
                        Next
                    Else
                        Debug.WriteLine("[AndroidProjectConfig] InitDriveNameComboBox=>" & publicName & " key isn't contain.")
                    End If
                Else
                    Debug.WriteLine("[AndroidProjectConfig] InitDriveNameComboBox=>Public name is empty.")
                End If
            Else
                Debug.WriteLine("[AndroidProjectConfig] InitDriveNameComboBox=>" & androidVersion & " key isn't contain.")
            End If
        Else
            Debug.WriteLine("[AndroidProjectConfig] InitDriveNameComboBox=>Android version is empty.")
        End If
    End Sub

    Public Sub InitCustomNameComboBox()
        CbCustomName.Items.Clear()
        Dim androidVersion = CbAndroidVersion.Text.Trim
        If Not IsEmptyText(androidVersion) Then
            If CustomNames.ContainsKey(androidVersion) Then
                Dim mssiName = CbMssiName.Text.Trim
                If Not IsEmptyText(mssiName) Then
                    Dim item As Hashtable = CustomNames(androidVersion)
                    If item.ContainsKey(mssiName) Then
                        For Each name As String In item(mssiName)
                            CbCustomName.Items.Add(name)
                        Next
                    Else
                        Debug.WriteLine("[AndroidProjectConfig] InitCustomNameComboBox=>" & mssiName & " key isn't contain.")
                    End If
                Else
                    Debug.WriteLine("[AndroidProjectConfig] InitCustomNameComboBox=>Mssi name is empty.")
                End If
            Else
                Debug.WriteLine("[AndroidProjectConfig] InitCustomNameComboBox=>" & androidVersion & " key isn't contain.")
            End If
        Else
            Debug.WriteLine("[AndroidProjectConfig] InitCustomNameComboBox=>Android version is empty.")
        End If
    End Sub

    Private Sub InitChiperMakerComboBox()
        CbChiperMaker.Items.Clear()
        For Each path As String In ChiperMakers
            CbChiperMaker.Items.Add(path)
        Next
    End Sub

    Public Sub InitChiperModelComboBox()
        CbChiperModel.Items.Clear()
        Dim chiperMaker = CbChiperMaker.Text.Trim
        If Not IsEmptyText(chiperMaker) Then
            If ChiperModels.ContainsKey(chiperMaker) Then
                For Each name As String In ChiperModels(chiperMaker)
                    CbChiperModel.Items.Add(name)
                Next
            Else
                Debug.WriteLine("[AndroidProjectConfig] InitChiperModelComboBox=>" & chiperMaker & " key isn't contain.")
            End If
        Else
            Debug.WriteLine("[AndroidProjectConfig] InitChiperModelComboBox=>Chiper maker is empty.")
        End If
    End Sub

    Private Sub InitLanguageComboBox()
        cbLanguage.Items.Clear()
        For Each language As String In Languages
            cbLanguage.Items.Add(language)
        Next
    End Sub

    Private Sub InitTimezoneComboBox()
        cbTimezone.Items.Clear()
        For Each timezone As String In Timezones
            cbTimezone.Items.Add(timezone)
        Next
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

    Private Sub CbAndroidVersin_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbAndroidVersion.SelectedIndexChanged
        MyProjectInfo.AndroidVersion = sender.SelectedItem
    End Sub

    Private Sub CbAndroidVersin_TextChanged(sender As ComboBox, e As EventArgs) Handles CbAndroidVersion.TextChanged
        MyProjectInfo.AndroidVersion = sender.Text
        InitPublicNameComboBox()
        InitMssiNameComboBox()
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
        InitChiperModelComboBox()
    End Sub

    Private Sub CbChiperModel_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbChiperModel.SelectedIndexChanged
        MyProjectInfo.ChiperModel = sender.SelectedItem
    End Sub

    Private Sub CbChiperMaker_TextChanged(sender As ComboBox, e As EventArgs) Handles CbChiperMaker.TextChanged
        MyProjectInfo.ChiperMaker = sender.Text
        InitChiperModelComboBox()
    End Sub

    Private Sub CbChiperModel_TextChanged(sender As ComboBox, e As EventArgs) Handles CbChiperModel.TextChanged
        MyProjectInfo.ChiperModel = sender.Text
    End Sub

    Private Sub btVersion_Click(sender As Object, e As EventArgs) Handles btVersion.Click
        VersionController.SetVersion(Me)
    End Sub

    Private Sub CbPublicName_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbPublicName.SelectedIndexChanged
        MyProjectInfo.PublicDirName = sender.SelectedItem
        InitDriveNameComboBox()
    End Sub

    Private Sub CbPublicName_TextChanged(sender As ComboBox, e As EventArgs) Handles CbPublicName.TextChanged
        MyProjectInfo.PublicDirName = sender.Text
        InitDriveNameComboBox()
    End Sub

    Private Sub CbMssiName_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbMssiName.SelectedIndexChanged
        MyProjectInfo.MssiDirName = sender.SelectedItem
        InitCustomNameComboBox()
    End Sub

    Private Sub CbMssiName_TextChanged(sender As ComboBox, e As EventArgs) Handles CbMssiName.TextChanged
        MyProjectInfo.MssiDirName = sender.Text
        InitCustomNameComboBox()
    End Sub

    Private Sub CbDriveName_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbDriveName.SelectedIndexChanged
        MyProjectInfo.DriveDirName = sender.SelectedItem
    End Sub

    Private Sub CbDriveName_TextChanged(sender As ComboBox, e As EventArgs) Handles CbDriveName.TextChanged
        MyProjectInfo.DriveDirName = sender.Text
    End Sub

    Private Sub CbCustomName_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbCustomName.SelectedIndexChanged
        MyProjectInfo.CustomDirName = sender.SelectedItem
    End Sub

    Private Sub CbCustomName_TextChanged(sender As ComboBox, e As EventArgs) Handles CbCustomName.TextChanged
        MyProjectInfo.CustomDirName = sender.Text
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
        ElseIf sender.SelectedTab.Name.Equals("tpSample") Then
            SampleController.UpdateSampleInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpScreenBrightness") Then
            BrightnessController.UpdateBrightnessInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpVolume") Then
            VolumeController.UpdateVolumeInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpTee") Then
            TeeController.UpdateTeeInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpGoogleCustom") Then
            GoogleCustomController.UpdateGoogleCustomInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpAnimation") Then
            AnimationController.UpdateAnimationInfos(Me)
        ElseIf sender.SelectedTab.Name.Equals("tpSystemSettings") Then
            SystemConfigController.UpdateSystemConfigInfos(Me)
        End If
    End Sub

    Private Sub btRandom_Click(sender As Object, e As EventArgs) Handles btRandom.Click
        Dim time As Long = DateDiff("s", "1970-1-1 0:0:0", DateTime.UtcNow)
        tbFingerprint.Text = Str(time).Trim
    End Sub

    Private Sub btFingerprintSet_Click(sender As Object, e As EventArgs) Handles btFingerprintSet.Click
        FingerprintController.SetFingerprint(Me)
    End Sub

    Private Sub btName_Click(sender As Object, e As EventArgs) Handles btName.Click
        PropertyController.SetProductName(Me)
    End Sub

    Private Sub btModel_Click(sender As Object, e As EventArgs) Handles btModel.Click
        PropertyController.SetProductModel(Me)
    End Sub

    Private Sub btBrand_Click(sender As Object, e As EventArgs) Handles btBrand.Click
        PropertyController.SetProductBrand(Me)
    End Sub

    Private Sub btDevice_Click(sender As Object, e As EventArgs) Handles btDevice.Click
        PropertyController.SetProductDevice(Me)
    End Sub

    Private Sub btManufacturer_Click(sender As Object, e As EventArgs) Handles btManufacturer.Click
        PropertyController.SetProductManufacturer(Me)
    End Sub

    Private Sub btPropertySetting_Click(sender As Object, e As EventArgs) Handles btPropertySetting.Click
        PropertyController.SetProductName(Me)
        PropertyController.SetProductModel(Me)
        PropertyController.SetProductBrand(Me)
        PropertyController.SetProductDevice(Me)
        PropertyController.SetProductManufacturer(Me)
    End Sub

    Private Sub btWifiStatus_Click(sender As Object, e As EventArgs) Handles btWifiStatus.Click
        WifiController.SetWifiDefaultState(Me)
    End Sub

    Private Sub btWifiHostName_Click(sender As Object, e As EventArgs) Handles btWifiHostName.Click
        WifiController.SetHotspotName(Me)
    End Sub

    Private Sub btWifiCastName_Click(sender As Object, e As EventArgs) Handles btWifiCastName.Click
        WifiController.SetScreenCastName(Me)
    End Sub

    Private Sub btWifiSetting_Click(sender As Object, e As EventArgs) Handles btWifiSetting.Click
        WifiController.SetWifiDefaultState(Me)
        WifiController.SetHotspotName(Me)
        WifiController.SetScreenCastName(Me)
    End Sub

    Private Sub CbProjectPath_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbProjectPath.SelectedIndexChanged
        MyProjectInfo.ProjectPath = sender.Text
    End Sub

    Private Sub CbProjectPath_TextChanged(sender As Object, e As EventArgs) Handles CbProjectPath.TextChanged
        MyProjectInfo.ProjectPath = sender.Text
    End Sub

    Private Sub btBluetoothStatus_Click(sender As Object, e As EventArgs) Handles btBluetoothStatus.Click
        BluetoothController.SetBluetoothStatus(Me)
    End Sub

    Private Sub btBluetoothName_Click(sender As Object, e As EventArgs) Handles btBluetoothName.Click
        BluetoothController.SetBluetoothName(Me)
    End Sub

    Private Sub btBluetoothSetting_Click(sender As Object, e As EventArgs) Handles btBluetoothSetting.Click
        BluetoothController.SetBluetoothStatus(Me)
        BluetoothController.SetBluetoothName(Me)
    End Sub

    Private Sub btLanguageSetting_Click(sender As Object, e As EventArgs) Handles btLanguageSetting.Click
        LanguageController.SetLanguage(Me)
    End Sub

    Private Sub btAutoTimeZone_Click(sender As Object, e As EventArgs) Handles btAutoTimeZone.Click
        TimezoneController.SetAutoTimezone(Me)
    End Sub

    Private Sub btTimeZone_Click(sender As Object, e As EventArgs) Handles btTimeZone.Click
        TimezoneController.SetTimezone(Me)
    End Sub

    Private Sub btTimezoneSetting_Click(sender As Object, e As EventArgs) Handles btTimezoneSetting.Click
        TimezoneController.SetAutoTimezone(Me)
        TimezoneController.SetTimezone(Me)
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

    Private Sub BtSetWallpaper_Click(sender As Object, e As EventArgs) Handles BtSetWallpaper.Click
        WallpaperController.SetWallpaper(Me)
    End Sub

    Private Sub BtSetIn_Click(sender As Object, e As EventArgs) Handles BtSetIn.Click
        WallpaperController.SetBuildInWallpaper(Me)
    End Sub

    Private Sub btWallpaperSetting_Click(sender As Object, e As EventArgs) Handles btWallpaperSetting.Click
        WallpaperController.SetWallpaper(Me)
        WallpaperController.SetBuildInWallpaper(Me)
    End Sub

    Private Sub btSample_Click(sender As Object, e As EventArgs) Handles btSample.Click
        SampleController.SetSampleStatus(Me)
    End Sub

    Private Sub btSampleName_Click(sender As Object, e As EventArgs) Handles btSampleName.Click
        SampleController.SetSampleName(Me)
    End Sub

    Private Sub btSampleSetting_Click(sender As Object, e As EventArgs) Handles btSampleSetting.Click
        SampleController.SetSampleStatus(Me)
        SampleController.SetSampleName(Me)
    End Sub

    Private Sub btDefaultBrightness_Click(sender As Object, e As EventArgs) Handles btDefaultBrightness.Click
        BrightnessController.SetDefaultBrightness(Me)
    End Sub

    Private Sub btMaxBrightness_Click(sender As Object, e As EventArgs) Handles btMaxBrightness.Click
        BrightnessController.SetMaxBrightness(Me)
    End Sub

    Private Sub btMinBrightness_Click(sender As Object, e As EventArgs) Handles btMinBrightness.Click
        BrightnessController.SetMinBrightness(Me)
    End Sub

    Private Sub btBrightnessAllSet_Click(sender As Object, e As EventArgs) Handles btBrightnessAllSet.Click
        BrightnessController.SetDefaultBrightness(Me)
        BrightnessController.SetMaxBrightness(Me)
        BrightnessController.SetMinBrightness(Me)
    End Sub

    Private Sub btCallVolume_Click(sender As Object, e As EventArgs) Handles btCallVolume.Click
        VolumeController.SetCallVolume(Me)
    End Sub

    Private Sub btRingVolume_Click(sender As Object, e As EventArgs) Handles btRingVolume.Click
        VolumeController.SetRingVolume(Me)
    End Sub

    Private Sub btMusicVolume_Click(sender As Object, e As EventArgs) Handles btMusicVolume.Click
        VolumeController.SetMusicVolume(Me)
    End Sub

    Private Sub btAlarmVolume_Click(sender As Object, e As EventArgs) Handles btAlarmVolume.Click
        VolumeController.SetAlarmVolume(Me)
    End Sub

    Private Sub btNotifyVolume_Click(sender As Object, e As EventArgs) Handles btNotifyVolume.Click
        VolumeController.SetNotificationVolume(Me)
    End Sub

    Private Sub btOtherVolume_Click(sender As Object, e As EventArgs) Handles btOtherVolume.Click
        VolumeController.SetOtherVolume(Me)
    End Sub

    Private Sub btVolumeAllSet_Click(sender As Object, e As EventArgs) Handles btVolumeAllSet.Click
        VolumeController.SetCallVolume(Me)
        VolumeController.SetRingVolume(Me)
        VolumeController.SetMusicVolume(Me)
        VolumeController.SetAlarmVolume(Me)
        VolumeController.SetNotificationVolume(Me)
        VolumeController.SetOtherVolume(Me)
    End Sub

    Private Sub btTee_Click(sender As Object, e As EventArgs) Handles btTee.Click
        TeeController.SetTeeStatus(Me)
    End Sub

    Private Sub btTeeCert_Click(sender As Object, e As EventArgs) Handles btTeeCert.Click
        TeeController.SetCertFile(Me)
    End Sub

    Private Sub btTeeArray_Click(sender As Object, e As EventArgs) Handles btTeeArray.Click
        TeeController.SetArrayFile(Me)
    End Sub

    Private Sub btTeeAllSet_Click(sender As Object, e As EventArgs) Handles btTeeAllSet.Click
        TeeController.SetTeeStatus(Me)
        TeeController.SetCertFile(Me)
        TeeController.SetArrayFile(Me)
    End Sub

    Private Sub btnTeeSelectCert_Click(sender As Object, e As EventArgs) Handles btnTeeSelectCert.Click
        ofdSelectFile.Title = "选择 cert.dat"
        ofdSelectFile.Filter = "DAT|*.dat"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbTeeCert.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btnTeeSelectArray_Click(sender As Object, e As EventArgs) Handles btnTeeSelectArray.Click
        ofdSelectFile.Title = "选择 array.c"
        ofdSelectFile.Filter = "C file|*.c"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbTeeArray.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btHomePage_Click(sender As Object, e As EventArgs) Handles btHomePage.Click
        GoogleCustomController.SetChromeHomePage(Me)
    End Sub

    Private Sub btEmailSignature_Click(sender As Object, e As EventArgs) Handles btEmailSignature.Click
        GoogleCustomController.SetEmailSignature(Me)
    End Sub

    Private Sub btGoogleCustom_Click(sender As Object, e As EventArgs) Handles btGoogleCustom.Click
        GoogleCustomController.SetChromeHomePage(Me)
        GoogleCustomController.SetEmailSignature(Me)
    End Sub

    Private Sub btSelectBootRing_Click(sender As Object, e As EventArgs) Handles btSelectBootRing.Click
        ofdSelectFile.Title = "选择开机铃声"
        ofdSelectFile.Filter = "MP3 file|*.mp3"
        ofdSelectFile.FileName = "bootaudio"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbBootRing.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btSelectBootAnim_Click(sender As Object, e As EventArgs) Handles btSelectBootAnim.Click
        ofdSelectFile.Title = "选择开机动画"
        ofdSelectFile.Filter = "ZIP file|*.zip"
        ofdSelectFile.FileName = "bootanimation"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbBootAnim.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btSelectShutdownRing_Click(sender As Object, e As EventArgs) Handles btSelectShutdownRing.Click
        ofdSelectFile.Title = "选择关机铃声"
        ofdSelectFile.Filter = "MP3 file|*.mp3"
        ofdSelectFile.FileName = "shutaudio"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbShutdownRing.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btSelectShutdownAnim_Click(sender As Object, e As EventArgs) Handles btSelectShutdownAnim.Click
        ofdSelectFile.Title = "选择关机动画"
        ofdSelectFile.Filter = "ZIP file|*.zip"
        ofdSelectFile.FileName = "shutdownanimation"
        ofdSelectFile.Multiselect = False
        If ofdSelectFile.ShowDialog() <> DialogResult.Cancel Then
            tbShutdownAnim.Text = ofdSelectFile.FileName
        End If
    End Sub

    Private Sub btBootRing_Click(sender As Object, e As EventArgs) Handles btBootRing.Click
        AnimationController.SetBootRing(Me)
    End Sub

    Private Sub btBootAnim_Click(sender As Object, e As EventArgs) Handles btBootAnim.Click
        AnimationController.SetBootAnim(Me)
    End Sub

    Private Sub btShutdownRing_Click(sender As Object, e As EventArgs) Handles btShutdownRing.Click
        AnimationController.SetShutdownRing(Me)
    End Sub

    Private Sub btShutdownAnim_Click(sender As Object, e As EventArgs) Handles btShutdownAnim.Click
        AnimationController.SetShutdownAnim(Me)
    End Sub

    Private Sub btAnimSet_Click(sender As Object, e As EventArgs) Handles btAnimSet.Click
        AnimationController.SetBootRing(Me)
        AnimationController.SetBootAnim(Me)
        AnimationController.SetShutdownRing(Me)
        AnimationController.SetShutdownAnim(Me)
    End Sub

    Private Sub btnScreenOffTime_Click(sender As Object, e As EventArgs) Handles btnScreenOffTime.Click
        SystemConfigController.SetScreenOffTime(Me)
    End Sub

    Private Sub btAutoRotation_Click(sender As Object, e As EventArgs) Handles btAutoRotation.Click
        SystemConfigController.SetAutoRotation(Me)
    End Sub

    Private Sub btAutoTime_Click(sender As Object, e As EventArgs) Handles btAutoTime.Click
        SystemConfigController.SetAutoTime(Me)
    End Sub

    Private Sub btGps_Click(sender As Object, e As EventArgs) Handles btGps.Click
        SystemConfigController.SetGps(Me)
    End Sub

    Private Sub btAutoBrightness_Click(sender As Object, e As EventArgs) Handles btAutoBrightness.Click
        SystemConfigController.SetAutoBrightness(Me)
    End Sub

    Private Sub bt24TimeFormat_Click(sender As Object, e As EventArgs) Handles bt24TimeFormat.Click
        SystemConfigController.Set24TimeFormat(Me)
    End Sub

    Private Sub btDisableScreenlock_Click(sender As Object, e As EventArgs) Handles btDisableScreenlock.Click
        SystemConfigController.SetDisableScreenLock(Me)
    End Sub

    Private Sub btSystemConfig_Click(sender As Object, e As EventArgs) Handles btSystemConfig.Click
        SystemConfigController.SetScreenOffTime(Me)
        SystemConfigController.SetAutoRotation(Me)
        SystemConfigController.SetAutoTime(Me)
        SystemConfigController.SetGps(Me)
        SystemConfigController.SetAutoBrightness(Me)
        SystemConfigController.Set24TimeFormat(Me)
        SystemConfigController.SetDisableScreenLock(Me)
    End Sub

End Class
